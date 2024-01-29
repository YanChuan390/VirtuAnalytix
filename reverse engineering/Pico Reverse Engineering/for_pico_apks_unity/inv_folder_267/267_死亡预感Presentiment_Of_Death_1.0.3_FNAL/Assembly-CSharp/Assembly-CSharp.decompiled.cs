using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMOD.Studio;
using FMODUnity;
using HurricaneVR.Framework.Components;
using HurricaneVR.Framework.ControllerInput;
using HurricaneVR.Framework.Core;
using HurricaneVR.Framework.Core.Grabbers;
using HurricaneVR.Framework.Core.HandPoser;
using HurricaneVR.Framework.Core.Player;
using HurricaneVR.Framework.Core.ScriptableObjects;
using HurricaneVR.Framework.Core.Sockets;
using HurricaneVR.Framework.Core.Stabbing;
using HurricaneVR.Framework.Shared;
using HurricaneVR.Framework.Weapons.Bow;
using Il2CppDummyDll;
using JetBrains.Annotations;
using RootMotion.Dynamics;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;
using UnityEngine.Splines;
using UnityEngine.UI;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CollisionEvent : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Enemy parentEnemy;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BodyPart bodyPart;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _attenuationForce;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 _startForce;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 _force;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isForceActive;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Rigidbody rb;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _minForceMagnitude;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10DDE38", Offset = "0x10DDE38", VA = "0x10DDE38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10DDF14", Offset = "0x10DDF14", VA = "0x10DDF14")]
	public void ApplyForce(Vector3 force)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10DDF28", Offset = "0x10DDF28", VA = "0x10DDF28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x10DDF38", Offset = "0x10DDF38", VA = "0x10DDF38")]
	private void ForceUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10DE050", Offset = "0x10DE050", VA = "0x10DE050")]
	public CollisionEvent()
	{
	}
}
[Token(Token = "0x2000003")]
public enum BodyPart
{
	[Token(Token = "0x400000A")]
	Head,
	[Token(Token = "0x400000B")]
	Hand,
	[Token(Token = "0x400000C")]
	Body,
	[Token(Token = "0x400000D")]
	Legs
}
[Token(Token = "0x2000004")]
public class DeveloperUIManager : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Dropdown SceneList;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject RootContainer;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool testMenu;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> scenesNames;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<string> scenesPaths;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isShowen;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InputActionReference OpenMenuInput;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x10DE070", Offset = "0x10DE070", VA = "0x10DE070")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10DE2CC", Offset = "0x10DE2CC", VA = "0x10DE2CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x10DE340", Offset = "0x10DE340", VA = "0x10DE340")]
	public void ToggleMenu()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10DE35C", Offset = "0x10DE35C", VA = "0x10DE35C")]
	[ContextMenu("Show Menu")]
	public void ShowMenu()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x10DE2A4", Offset = "0x10DE2A4", VA = "0x10DE2A4")]
	[ContextMenu("Hide Menu")]
	public void HideMenu()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x10DE080", Offset = "0x10DE080", VA = "0x10DE080")]
	private void RefreshDropListItems()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x10DE3A0", Offset = "0x10DE3A0", VA = "0x10DE3A0")]
	public void LoadSelectedScene()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x10DE434", Offset = "0x10DE434", VA = "0x10DE434")]
	public DeveloperUIManager()
	{
	}
}
[Token(Token = "0x2000005")]
public class GlobalVolume : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Volume volume;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x10DE4EC", Offset = "0x10DE4EC", VA = "0x10DE4EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x10DE550", Offset = "0x10DE550", VA = "0x10DE550")]
	public GlobalVolume()
	{
	}
}
[Token(Token = "0x2000006")]
[RequireComponent(typeof(VideoPlayer))]
public class LaunchGameVideo : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <Go>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LaunchGameVideo <>4__this;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <alpha>5__2;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <loadingScene>5__3;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x10DEC00", Offset = "0x10DEC00", VA = "0x10DEC00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x10DEC48", Offset = "0x10DEC48", VA = "0x10DEC48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x10DE634", Offset = "0x10DE634", VA = "0x10DE634")]
		[DebuggerHidden]
		public <Go>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x10DE664", Offset = "0x10DE664", VA = "0x10DE664", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x10DE668", Offset = "0x10DE668", VA = "0x10DE668", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x10DEC08", Offset = "0x10DEC08", VA = "0x10DEC08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int scene;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material material;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000019")]
	private const float AlphaTime = 0.5f;

	[Token(Token = "0x400001A")]
	private const float ConstDelta = 2f;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10DE558", Offset = "0x10DE558", VA = "0x10DE558")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10DE630", Offset = "0x10DE630", VA = "0x10DE630")]
	[ContextMenu("Test")]
	public void Test()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x10DE5BC", Offset = "0x10DE5BC", VA = "0x10DE5BC")]
	[IteratorStateMachine(typeof(<Go>d__7))]
	private IEnumerator Go()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x10DE65C", Offset = "0x10DE65C", VA = "0x10DE65C")]
	public LaunchGameVideo()
	{
	}
}
[Token(Token = "0x2000008")]
public class MLPForceNoProbes : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10DEC50", Offset = "0x10DEC50", VA = "0x10DEC50")]
	public MLPForceNoProbes()
	{
	}
}
[Token(Token = "0x2000009")]
public class MLPForceSaveProbes : MonoBehaviour
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10DEC58", Offset = "0x10DEC58", VA = "0x10DEC58")]
	public MLPForceSaveProbes()
	{
	}
}
[Token(Token = "0x200000A")]
public class AndroidOptimization : MonoBehaviour
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10DEC60", Offset = "0x10DEC60", VA = "0x10DEC60")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10DEC84", Offset = "0x10DEC84", VA = "0x10DEC84")]
	public AndroidOptimization()
	{
	}
}
[Token(Token = "0x200000B")]
public class AndroidOptimizationMaterial : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[ItemCanBeNull]
	private Material[] _original;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemCanBeNull]
	private Material[] _androidOptimizationOriginal;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Renderer _renderer;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10DEC8C", Offset = "0x10DEC8C", VA = "0x10DEC8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10DECB0", Offset = "0x10DECB0", VA = "0x10DECB0")]
	public AndroidOptimizationMaterial()
	{
	}
}
[Token(Token = "0x200000C")]
public class AnimationEvent : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <InvulnerableOff>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationEvent <>4__this;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x10DF8D0", Offset = "0x10DF8D0", VA = "0x10DF8D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x10DF918", Offset = "0x10DF918", VA = "0x10DF918", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x10DF3F8", Offset = "0x10DF3F8", VA = "0x10DF3F8")]
		[DebuggerHidden]
		public <InvulnerableOff>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10DF78C", Offset = "0x10DF78C", VA = "0x10DF78C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10DF790", Offset = "0x10DF790", VA = "0x10DF790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x10DF8D8", Offset = "0x10DF8D8", VA = "0x10DF8D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <DissolveSmooth>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isSpawn;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationEvent <>4__this;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material material;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float timeSpawn;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timer>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x10DFBF0", Offset = "0x10DFBF0", VA = "0x10DFBF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x10DFC38", Offset = "0x10DFC38", VA = "0x10DFC38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x10DF420", Offset = "0x10DF420", VA = "0x10DF420")]
		[DebuggerHidden]
		public <DissolveSmooth>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x10DF920", Offset = "0x10DF920", VA = "0x10DF920", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x10DF924", Offset = "0x10DF924", VA = "0x10DF924", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x10DFBF8", Offset = "0x10DFBF8", VA = "0x10DFBF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spearOTheBelt;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject spearInHand;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator animatorBow;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool lockAtPlayer;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 1f)]
	public float lockAtWeight;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject defaultArrow;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("BossArcher")]
	public Transform arrow;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 offsetTake;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material bowMat;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public StudioEventEmitter soundOn;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public StudioEventEmitter soundOff;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private RangeEnemy _rangeEnemy;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Enemy _enemy;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SpearEnemy _spearEnemy;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animator _animator;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool _caughtAnArrow;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform _arrow;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _timerSetIk;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x10DECB8", Offset = "0x10DECB8", VA = "0x10DECB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10DEDB0", Offset = "0x10DEDB0", VA = "0x10DEDB0")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10DEFC0", Offset = "0x10DEFC0", VA = "0x10DEFC0")]
	public void BowSpawn()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10DF384", Offset = "0x10DF384", VA = "0x10DF384")]
	[IteratorStateMachine(typeof(<InvulnerableOff>d__21))]
	private IEnumerator InvulnerableOff()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10DF050", Offset = "0x10DF050", VA = "0x10DF050")]
	[IteratorStateMachine(typeof(<DissolveSmooth>d__22))]
	public IEnumerator DissolveSmooth(Material material, float timeSpawn, bool isSpawn = true)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10DF448", Offset = "0x10DF448", VA = "0x10DF448")]
	public void CaughtAnArrow(Transform arrow)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x10DF46C", Offset = "0x10DF46C", VA = "0x10DF46C")]
	public void LockAtPlayerOn()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x10DF478", Offset = "0x10DF478", VA = "0x10DF478")]
	public void LockAtPlayerOff()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x10DF480", Offset = "0x10DF480", VA = "0x10DF480")]
	public void ShootReady()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x10DF598", Offset = "0x10DF598", VA = "0x10DF598")]
	public void Step()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x10DF5D8", Offset = "0x10DF5D8", VA = "0x10DF5D8")]
	public void SpearOpen()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x10DF674", Offset = "0x10DF674", VA = "0x10DF674")]
	public void SpearTake()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x10DF6AC", Offset = "0x10DF6AC", VA = "0x10DF6AC")]
	public void BowPull()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x10DF700", Offset = "0x10DF700", VA = "0x10DF700")]
	public void ArrowActive()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x10DF784", Offset = "0x10DF784", VA = "0x10DF784")]
	public AnimationEvent()
	{
	}
}
[Token(Token = "0x200000F")]
public class AnimationInTime : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animation animation;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string animationName;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x10DFC40", Offset = "0x10DFC40", VA = "0x10DFC40")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x10DFCD0", Offset = "0x10DFCD0", VA = "0x10DFCD0")]
	public AnimationInTime()
	{
	}
}
[Token(Token = "0x2000010")]
public class ActivateRoot : StateMachineBehaviour
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x10DFCD8", Offset = "0x10DFCD8", VA = "0x10DFCD8", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x10DFCF4", Offset = "0x10DFCF4", VA = "0x10DFCF4", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10DFD10", Offset = "0x10DFD10", VA = "0x10DFD10")]
	public ActivateRoot()
	{
	}
}
[Token(Token = "0x2000011")]
public class AnimatorInTime : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x10DFD18", Offset = "0x10DFD18", VA = "0x10DFD18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x10DFD90", Offset = "0x10DFD90", VA = "0x10DFD90")]
	public AnimatorInTime()
	{
	}
}
[Token(Token = "0x2000012")]
public class Death : StateMachineBehaviour
{
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x10DFD98", Offset = "0x10DFD98", VA = "0x10DFD98", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10DFDB4", Offset = "0x10DFDB4", VA = "0x10DFDB4")]
	public Death()
	{
	}
}
[Token(Token = "0x2000013")]
public class LockAtPlayerOff : StateMachineBehaviour
{
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10DFDBC", Offset = "0x10DFDBC", VA = "0x10DFDBC", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x10DFE60", Offset = "0x10DFE60", VA = "0x10DFE60", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10DFF08", Offset = "0x10DFF08", VA = "0x10DFF08")]
	public LockAtPlayerOff()
	{
	}
}
[Token(Token = "0x2000014")]
public class ArrowDissolve : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <Dissolve>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArrowDissolve <>4__this;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x10E010C", Offset = "0x10E010C", VA = "0x10E010C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x10E0154", Offset = "0x10E0154", VA = "0x10E0154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x10DFFA4", Offset = "0x10DFFA4", VA = "0x10DFFA4")]
		[DebuggerHidden]
		public <Dissolve>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x10DFFDC", Offset = "0x10DFFDC", VA = "0x10DFFDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x10DFFE0", Offset = "0x10DFFE0", VA = "0x10DFFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x10E0114", Offset = "0x10E0114", VA = "0x10E0114", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer renderer;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _timeDissolve;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x10DFF10", Offset = "0x10DFF10", VA = "0x10DFF10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10DFF30", Offset = "0x10DFF30", VA = "0x10DFF30")]
	[IteratorStateMachine(typeof(<Dissolve>d__3))]
	private IEnumerator Dissolve()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10DFFCC", Offset = "0x10DFFCC", VA = "0x10DFFCC")]
	public ArrowDissolve()
	{
	}
}
[Token(Token = "0x2000016")]
public class ArrowEnableEffect : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedRender;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material _renderMat;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x10E015C", Offset = "0x10E015C", VA = "0x10E015C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x10E01F0", Offset = "0x10E01F0", VA = "0x10E01F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x10E02A4", Offset = "0x10E02A4", VA = "0x10E02A4")]
	public ArrowEnableEffect()
	{
	}
}
[Token(Token = "0x2000017")]
public class ArrowSoundFlyPlay : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StudioEventEmitter sound;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Player _player;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isPlaying;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x10E02B4", Offset = "0x10E02B4", VA = "0x10E02B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x10E0308", Offset = "0x10E0308", VA = "0x10E0308")]
	private void Update()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x10E0410", Offset = "0x10E0410", VA = "0x10E0410")]
	public ArrowSoundFlyPlay()
	{
	}
}
[Token(Token = "0x2000018")]
public class BackgroundMusic : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BackgroundMusic Instance;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x10E0420", Offset = "0x10E0420", VA = "0x10E0420")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x10E0524", Offset = "0x10E0524", VA = "0x10E0524")]
	public BackgroundMusic()
	{
	}
}
[Token(Token = "0x2000019")]
public class BossArcher : RangeEnemy
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <DelayTeleport>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportController _teleportController;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BossArcher <>4__this;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 point;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isHit;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x10E1380", Offset = "0x10E1380", VA = "0x10E1380", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x10E13C8", Offset = "0x10E13C8", VA = "0x10E13C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x10E09A8", Offset = "0x10E09A8", VA = "0x10E09A8")]
		[DebuggerHidden]
		public <DelayTeleport>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x10E0DA4", Offset = "0x10E0DA4", VA = "0x10E0DA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x10E0DA8", Offset = "0x10E0DA8", VA = "0x10E0DA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x10E1388", Offset = "0x10E1388", VA = "0x10E1388", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public AnimationEvent animationEvent;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public int layerArrow;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<TeleportController> teleportController;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public BossTeleportPoint bossTeleportPoint;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Material bossMaterial;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Material bowMaterial;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public int phase;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	public bool isInvulnerable;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
	public bool startAnimOff;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
	private bool _caughtAnArrow;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private int _indexTeleport;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private bool _firstEnable;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x10E052C", Offset = "0x10E052C", VA = "0x10E052C", Slot = "10")]
	protected override void StartVirtual()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x10E0710", Offset = "0x10E0710", VA = "0x10E0710")]
	private void Update()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x10E082C", Offset = "0x10E082C", VA = "0x10E082C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x10DF0FC", Offset = "0x10DF0FC", VA = "0x10DF0FC")]
	public void Teleport()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x10E08E8", Offset = "0x10E08E8", VA = "0x10E08E8")]
	[IteratorStateMachine(typeof(<DelayTeleport>d__16))]
	private IEnumerator DelayTeleport(TeleportController _teleportController, Vector3 point, bool isHit = false)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x10E09D0", Offset = "0x10E09D0", VA = "0x10E09D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x10E0AF0", Offset = "0x10E0AF0", VA = "0x10E0AF0", Slot = "11")]
	public override void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisionEvent)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x10E0D70", Offset = "0x10E0D70", VA = "0x10E0D70")]
	public BossArcher()
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class TeleportController
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float delayTeleport;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float timeDissolve;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int phase;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public TypeAttackBossArcher typeAttack;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool firstInPhase;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeAttack;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool nextTeleport;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x10E13F4", Offset = "0x10E13F4", VA = "0x10E13F4")]
	public TeleportController(float _delayTeleport, float _timeDissolve)
	{
	}
}
[Token(Token = "0x200001D")]
public enum TypeAttackBossArcher
{
	[Token(Token = "0x400006C")]
	Default,
	[Token(Token = "0x400006D")]
	DoubleAttack,
	[Token(Token = "0x400006E")]
	Melee
}
[Token(Token = "0x200001E")]
public class BossAxeAlternativeKill : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform deathZona;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _countTarget;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x10E1430", Offset = "0x10E1430", VA = "0x10E1430")]
	public void TargetHit()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x10E1478", Offset = "0x10E1478", VA = "0x10E1478")]
	public BossAxeAlternativeKill()
	{
	}
}
[Token(Token = "0x200001F")]
public class BossElectroTarget : MonoBehaviour
{
	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <Dissolve>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossElectroTarget <>4__this;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x10E18C4", Offset = "0x10E18C4", VA = "0x10E18C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x10E190C", Offset = "0x10E190C", VA = "0x10E190C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x10E1654", Offset = "0x10E1654", VA = "0x10E1654")]
		[DebuggerHidden]
		public <Dissolve>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x10E168C", Offset = "0x10E168C", VA = "0x10E168C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x10E1690", Offset = "0x10E1690", VA = "0x10E1690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x10E18CC", Offset = "0x10E18CC", VA = "0x10E18CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ElectroBoss electroBoss;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer renderer1;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer renderer2;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject animation;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Renderer> renderers;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject effect;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public StudioEventEmitter sound;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float timeEffect;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x10E1480", Offset = "0x10E1480", VA = "0x10E1480")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x10E15E0", Offset = "0x10E15E0", VA = "0x10E15E0")]
	[IteratorStateMachine(typeof(<Dissolve>d__9))]
	private IEnumerator Dissolve()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x10E167C", Offset = "0x10E167C", VA = "0x10E167C")]
	public BossElectroTarget()
	{
	}
}
[Token(Token = "0x2000021")]
public class ButtonArrow : MonoBehaviour
{
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button button;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string tagArrow;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x10E1914", Offset = "0x10E1914", VA = "0x10E1914")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x10E1968", Offset = "0x10E1968", VA = "0x10E1968")]
	public ButtonArrow()
	{
	}
}
[Token(Token = "0x2000022")]
public class CheckHVRGlobal : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CheckHVRGlobal Instance;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x10E1970", Offset = "0x10E1970", VA = "0x10E1970")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x10E1A4C", Offset = "0x10E1A4C", VA = "0x10E1A4C")]
	public CheckHVRGlobal()
	{
	}
}
[Token(Token = "0x2000023")]
public class CustomMathf : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	public class MergedType<T1, T2> : DynamicObject
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 t1;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 t2;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<string, object> members;

		[Token(Token = "0x600008D")]
		public MergedType(T1 t1, T2 t2)
		{
		}

		[Token(Token = "0x600008E")]
		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x10E1A54", Offset = "0x10E1A54", VA = "0x10E1A54")]
	public static float Remap(float inValue, float inMin, float inMax, float outMin, float outMax)
	{
		return default(float);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x10E1A70", Offset = "0x10E1A70", VA = "0x10E1A70")]
	public static Rect Lerp(Rect a, Rect b, float t)
	{
		return default(Rect);
	}

	[Token(Token = "0x600007A")]
	public static void Shuffle<T>(IList<T> list)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x10E1BD8", Offset = "0x10E1BD8", VA = "0x10E1BD8")]
	public static int ConvertFloatToInt(float inNumber)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x10E1C84", Offset = "0x10E1C84", VA = "0x10E1C84")]
	public static float ConvertIntToFloat(int number)
	{
		return default(float);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x10E1C98", Offset = "0x10E1C98", VA = "0x10E1C98")]
	public static void Recenter(Vector3 newPosition, Quaternion newRotation, Transform inTransform)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x10E1CF0", Offset = "0x10E1CF0", VA = "0x10E1CF0")]
	public static void Recenter(Transform inTransformObject, Transform inTransform)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x10E1D44", Offset = "0x10E1D44", VA = "0x10E1D44")]
	public static string RandomString(int inLength, [Optional] string inCharacterSet)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x10E1ED8", Offset = "0x10E1ED8", VA = "0x10E1ED8")]
	public static string FormatTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x10E1FC8", Offset = "0x10E1FC8", VA = "0x10E1FC8")]
	public static bool RateLimiter(int _frequency)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x10E1FF0", Offset = "0x10E1FF0", VA = "0x10E1FF0")]
	public static int CustomSmoothStep(int inFrom, int inTo, float inProgress)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x10E20AC", Offset = "0x10E20AC", VA = "0x10E20AC")]
	public static float CustomSmoothStep(float inFrom, float inTo, float inProgress)
	{
		return default(float);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x10E20FC", Offset = "0x10E20FC", VA = "0x10E20FC")]
	public static Quaternion CustomSmooth(Quaternion inFrom, Quaternion inTo, float inProgress)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x10E214C", Offset = "0x10E214C", VA = "0x10E214C")]
	public static bool IsObjectVisible(Camera @this, Renderer renderer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x10E21B4", Offset = "0x10E21B4", VA = "0x10E21B4")]
	public static bool IsObjectVisible(Camera @this, Bounds bounds)
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x10E21F4", Offset = "0x10E21F4", VA = "0x10E21F4")]
	public static Quaternion RandomRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000088")]
	public static T[] Slice<T>(T[] source, int index, int inLength)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	public static T[][] SliceToArrays<T>(T[] source, int length)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	public static MergedType<T1, T2> Merge<T1, T2>(T1 t1, T2 t2)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x10E2280", Offset = "0x10E2280", VA = "0x10E2280")]
	public static Vector2 RandomVector2(Vector2 min, Vector2 max)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x10E22CC", Offset = "0x10E22CC", VA = "0x10E22CC")]
	public CustomMathf()
	{
	}
}
[Token(Token = "0x2000028")]
public class DeathZona : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radius;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x10E2310", Offset = "0x10E2310", VA = "0x10E2310")]
	private void Update()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x10E2590", Offset = "0x10E2590", VA = "0x10E2590")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x10E25DC", Offset = "0x10E25DC", VA = "0x10E25DC")]
	public DeathZona()
	{
	}
}
[Token(Token = "0x2000029")]
public class DefaultPosition : MonoBehaviour
{
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x10E25E4", Offset = "0x10E25E4", VA = "0x10E25E4")]
	public void SaveDefaultRotation()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x10E26F0", Offset = "0x10E26F0", VA = "0x10E26F0")]
	public DefaultPosition()
	{
	}
}
[Token(Token = "0x200002A")]
public class DeleteCollisionArrow : MonoBehaviour
{
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x10E26F8", Offset = "0x10E26F8", VA = "0x10E26F8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x10E276C", Offset = "0x10E276C", VA = "0x10E276C")]
	public DeleteCollisionArrow()
	{
	}
}
[Token(Token = "0x200002B")]
public class ElectroBoss : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <DefendOffEnumerator>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ElectroBoss <>4__this;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x10E2FEC", Offset = "0x10E2FEC", VA = "0x10E2FEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x10E3034", Offset = "0x10E3034", VA = "0x10E3034", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x10E2C40", Offset = "0x10E2C40", VA = "0x10E2C40")]
		[DebuggerHidden]
		public <DefendOffEnumerator>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x10E2E18", Offset = "0x10E2E18", VA = "0x10E2E18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x10E2E1C", Offset = "0x10E2E1C", VA = "0x10E2E1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10E2FF4", Offset = "0x10E2FF4", VA = "0x10E2FF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Phase> phaseList;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool activePhase;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int phaseIndex;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float timeDisabling;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<EnemySphere> _liveEnemy;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool open;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x10E2774", Offset = "0x10E2774", VA = "0x10E2774")]
	public void StartBoss()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x10E29D0", Offset = "0x10E29D0", VA = "0x10E29D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x10E2B08", Offset = "0x10E2B08", VA = "0x10E2B08")]
	private void DefendOff()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x10E153C", Offset = "0x10E153C", VA = "0x10E153C")]
	public void TargetDestroy()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x10E2BCC", Offset = "0x10E2BCC", VA = "0x10E2BCC")]
	[IteratorStateMachine(typeof(<DefendOffEnumerator>d__10))]
	private IEnumerator DefendOffEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x10E2778", Offset = "0x10E2778", VA = "0x10E2778")]
	public void SpawnEnemy()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x10E2CF8", Offset = "0x10E2CF8", VA = "0x10E2CF8")]
	public ElectroBoss()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class Phase
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int minEnemy;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int maxEnemy;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform post;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StudioEventEmitter sound;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<EnemySphere> enemySpheres;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent unityEvent;

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x10E303C", Offset = "0x10E303C", VA = "0x10E303C")]
	public Phase()
	{
	}
}
[Token(Token = "0x200002F")]
public class AxeBossProjectile : Projectile
{
	[Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class <TimerInWallEnumerator>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxeBossProjectile <>4__this;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x10E3890", Offset = "0x10E3890", VA = "0x10E3890", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x10E38D8", Offset = "0x10E38D8", VA = "0x10E38D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10E35D8", Offset = "0x10E35D8", VA = "0x10E35D8")]
		[DebuggerHidden]
		public <TimerInWallEnumerator>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10E3608", Offset = "0x10E3608", VA = "0x10E3608", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x10E360C", Offset = "0x10E360C", VA = "0x10E360C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x10E3898", Offset = "0x10E3898", VA = "0x10E3898", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public float timerInWall;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public SpearEnemy boss;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool _reversibleMove;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x10E3044", Offset = "0x10E3044", VA = "0x10E3044", Slot = "7")]
	protected override void EndSpline()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x10E3450", Offset = "0x10E3450", VA = "0x10E3450")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x10E32BC", Offset = "0x10E32BC", VA = "0x10E32BC")]
	[IteratorStateMachine(typeof(<TimerInWallEnumerator>d__5))]
	private IEnumerator TimerInWallEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x10E3600", Offset = "0x10E3600", VA = "0x10E3600")]
	public AxeBossProjectile()
	{
	}
}
[Token(Token = "0x2000031")]
public class BossTeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[DraggablePoint]
	public List<Vector3> pointTeleport;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x10E38E0", Offset = "0x10E38E0", VA = "0x10E38E0")]
	public BossTeleportPoint()
	{
	}
}
[Token(Token = "0x2000032")]
public class DraggablePoint : PropertyAttribute
{
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x10E38E8", Offset = "0x10E38E8", VA = "0x10E38E8")]
	public DraggablePoint()
	{
	}
}
[Token(Token = "0x2000033")]
public class DraggablePointRelative : PropertyAttribute
{
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x10E38F0", Offset = "0x10E38F0", VA = "0x10E38F0")]
	public DraggablePointRelative()
	{
	}
}
[Token(Token = "0x2000034")]
public class EffectEnemy : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VisualEffect visualEffect1;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VisualEffect visualEffect2;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VFXPropertyBinder vFXPropertyBinder1;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VFXPropertyBinder vFXPropertyBinder2;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x10E38F8", Offset = "0x10E38F8", VA = "0x10E38F8")]
	public EffectEnemy()
	{
	}
}
[Token(Token = "0x2000035")]
public class Enemy : MonoBehaviour, IDamageable
{
	[Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class <DelayForce>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CollisionEvent collisionEvent;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 f;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BodyPart bp;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Enemy <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x10E5DD4", Offset = "0x10E5DD4", VA = "0x10E5DD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x10E5E1C", Offset = "0x10E5E1C", VA = "0x10E5E1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x10E54FC", Offset = "0x10E54FC", VA = "0x10E54FC")]
		[DebuggerHidden]
		public <DelayForce>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x10E5CC8", Offset = "0x10E5CC8", VA = "0x10E5CC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10E5CCC", Offset = "0x10E5CCC", VA = "0x10E5CCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10E5DDC", Offset = "0x10E5DDC", VA = "0x10E5DDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class <BlendActive>d__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x10E5F58", Offset = "0x10E5F58", VA = "0x10E5F58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x10E5FA0", Offset = "0x10E5FA0", VA = "0x10E5FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10E58B0", Offset = "0x10E58B0", VA = "0x10E58B0")]
		[DebuggerHidden]
		public <BlendActive>d__75(int <>1__state)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10E5E24", Offset = "0x10E5E24", VA = "0x10E5E24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x10E5E28", Offset = "0x10E5E28", VA = "0x10E5E28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10E5F60", Offset = "0x10E5F60", VA = "0x10E5F60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class <BlendRemove>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x10E60DC", Offset = "0x10E60DC", VA = "0x10E60DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x10E6124", Offset = "0x10E6124", VA = "0x10E6124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10E58F8", Offset = "0x10E58F8", VA = "0x10E58F8")]
		[DebuggerHidden]
		public <BlendRemove>d__77(int <>1__state)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10E5FA8", Offset = "0x10E5FA8", VA = "0x10E5FA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10E5FAC", Offset = "0x10E5FAC", VA = "0x10E5FAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10E60E4", Offset = "0x10E60E4", VA = "0x10E60E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool idle;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("Settings")]
	public float maxHeath;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_MaxSpeed;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minDistance;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 offSetTeleport;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speedMultiplier;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float turnMultiplier;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool animationMovement;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float durationMax;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool freeYPosition;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool navMeshMovement;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Body")]
	public List<BodySettings> bodySettings;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Links")]
	public SplineContainer spline;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transformFollow;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<PointSplineAction> pointSplineActions;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Animator animator;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Rigidbody rb;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SplineData<float> speedData;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform physicHead;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public VisualEffect hitEffect;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Renderer> renderers;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Renderer> renderersWeapon;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public NavMeshAgent navMeshAgent;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public StudioEventEmitter startSound;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected bool FixedSpeedAnimation;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	protected float AnimatorSlow;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float _speed;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float _duration;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int _index;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool _lockAtPlayer;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float3 _positionInSpline;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Header("SFX")]
	public StudioEventEmitter stepSound;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("Event")]
	public UnityEvent headShoot;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public UnityEvent die;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float _maxTurn;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector3 _preDirection;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float _distanceSpline;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private bool _inRange;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float _path;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private Vector3 _prePositionEnemy;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _playerInRadiusAttack;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool _blendActive;

	[Token(Token = "0x17000011")]
	public bool isDeath
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x10E3900", Offset = "0x10E3900", VA = "0x10E3900", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x10E3908", Offset = "0x10E3908", VA = "0x10E3908", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool shooting
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x10E3914", Offset = "0x10E3914", VA = "0x10E3914")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x10E391C", Offset = "0x10E391C", VA = "0x10E391C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Transform transformOrigin
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x10E3928", Offset = "0x10E3928", VA = "0x10E3928", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x10E3930", Offset = "0x10E3930", VA = "0x10E3930", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float CurrentHeath
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x10E3938", Offset = "0x10E3938", VA = "0x10E3938")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x10E3940", Offset = "0x10E3940", VA = "0x10E3940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x10E3948", Offset = "0x10E3948", VA = "0x10E3948")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x10E4210", Offset = "0x10E4210", VA = "0x10E4210")]
	private void StartSoundArena()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x10E4284", Offset = "0x10E4284", VA = "0x10E4284", Slot = "10")]
	protected virtual void StartVirtual()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x10E4288", Offset = "0x10E4288", VA = "0x10E4288")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x10E4CCC", Offset = "0x10E4CCC", VA = "0x10E4CCC")]
	private void FollowToObject()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x10E44E4", Offset = "0x10E44E4", VA = "0x10E44E4")]
	private void MovementAndRotate()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x10E4FFC", Offset = "0x10E4FFC", VA = "0x10E4FFC")]
	private void CheckPlayerInRadius()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x10E5184", Offset = "0x10E5184", VA = "0x10E5184", Slot = "6")]
	public void ApplyDamage(float damage, IDamageable damageable)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x10E5258", Offset = "0x10E5258", VA = "0x10E5258", Slot = "11")]
	public virtual void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisionEvent)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x10E5440", Offset = "0x10E5440", VA = "0x10E5440")]
	[IteratorStateMachine(typeof(<DelayForce>d__68))]
	protected IEnumerator DelayForce(CollisionEvent collisionEvent, Vector3 f, BodyPart bp)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x10E5524", Offset = "0x10E5524", VA = "0x10E5524", Slot = "12")]
	public virtual void Die()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x10E561C", Offset = "0x10E561C", VA = "0x10E561C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x10E4DD4", Offset = "0x10E4DD4", VA = "0x10E4DD4")]
	private void CheckPointAction()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x10E3D88", Offset = "0x10E3D88", VA = "0x10E3D88")]
	protected void ActionPlay(PointSplineAction action)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x10E579C", Offset = "0x10E579C", VA = "0x10E579C")]
	public void IdleRemove()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x10E57A4", Offset = "0x10E57A4", VA = "0x10E57A4")]
	public void ActivateBlendAnimation()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x10E56B4", Offset = "0x10E56B4", VA = "0x10E56B4")]
	[IteratorStateMachine(typeof(<BlendActive>d__75))]
	private IEnumerator BlendActive()
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x10E58D8", Offset = "0x10E58D8", VA = "0x10E58D8")]
	public void RemoveBlendAnimation()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x10E5728", Offset = "0x10E5728", VA = "0x10E5728")]
	[IteratorStateMachine(typeof(<BlendRemove>d__77))]
	private IEnumerator BlendRemove()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x10E5920", Offset = "0x10E5920", VA = "0x10E5920")]
	public void ActivateAnimationMovement()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x10E5A70", Offset = "0x10E5A70", VA = "0x10E5A70")]
	public void OffCollision()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x10DF5BC", Offset = "0x10DF5BC", VA = "0x10DF5BC")]
	public void Step()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x10E5A9C", Offset = "0x10E5A9C", VA = "0x10E5A9C")]
	public void HeadShoot()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x10E5B20", Offset = "0x10E5B20", VA = "0x10E5B20")]
	public Enemy()
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class PointSplineAction
{
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int index;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public TypeAction typeAction;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedAnimation;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent eventSplinePoint;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x10E612C", Offset = "0x10E612C", VA = "0x10E612C")]
	public PointSplineAction()
	{
	}
}
[Token(Token = "0x200003C")]
public enum TypeAction
{
	[Token(Token = "0x40000ED")]
	Run,
	[Token(Token = "0x40000EE")]
	WallRun,
	[Token(Token = "0x40000EF")]
	WallRunStop,
	[Token(Token = "0x40000F0")]
	Jump,
	[Token(Token = "0x40000F1")]
	Roll,
	[Token(Token = "0x40000F2")]
	Attack,
	[Token(Token = "0x40000F3")]
	ExtraAttack,
	[Token(Token = "0x40000F4")]
	AttackInJump,
	[Token(Token = "0x40000F5")]
	JavelinAttack,
	[Token(Token = "0x40000F6")]
	ArcherAttack,
	[Token(Token = "0x40000F7")]
	AxeAttack,
	[Token(Token = "0x40000F8")]
	JumpOver,
	[Token(Token = "0x40000F9")]
	Slide,
	[Token(Token = "0x40000FA")]
	archerJump,
	[Token(Token = "0x40000FB")]
	level3Jump,
	[Token(Token = "0x40000FC")]
	jumpArena
}
[Serializable]
[Token(Token = "0x200003D")]
public class BodySettings
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public BodyPart bodyPart;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float force;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool boolDamage;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x10E6134", Offset = "0x10E6134", VA = "0x10E6134")]
	public BodySettings()
	{
	}
}
[Token(Token = "0x200003E")]
public class EnemyController : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <StartEnumerator>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x10E7C20", Offset = "0x10E7C20", VA = "0x10E7C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x10E7C68", Offset = "0x10E7C68", VA = "0x10E7C68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10E624C", Offset = "0x10E624C", VA = "0x10E624C")]
		[DebuggerHidden]
		public <StartEnumerator>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10E7A50", Offset = "0x10E7A50", VA = "0x10E7A50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10E7A54", Offset = "0x10E7A54", VA = "0x10E7A54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10E7C28", Offset = "0x10E7C28", VA = "0x10E7C28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <EventDelay>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyController <>4__this;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent _event;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x10E7F60", Offset = "0x10E7F60", VA = "0x10E7F60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x10E7FA8", Offset = "0x10E7FA8", VA = "0x10E7FA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10E78E0", Offset = "0x10E78E0", VA = "0x10E78E0")]
		[DebuggerHidden]
		public <EventDelay>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10E7E30", Offset = "0x10E7E30", VA = "0x10E7E30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10E7E34", Offset = "0x10E7E34", VA = "0x10E7E34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10E7F68", Offset = "0x10E7F68", VA = "0x10E7F68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <EnumeratorGrab>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject _gameObject;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x10E824C", Offset = "0x10E824C", VA = "0x10E824C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x10E8294", Offset = "0x10E8294", VA = "0x10E8294", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10E7908", Offset = "0x10E7908", VA = "0x10E7908")]
		[DebuggerHidden]
		public <EnumeratorGrab>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10E7FB0", Offset = "0x10E7FB0", VA = "0x10E7FB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10E7FB4", Offset = "0x10E7FB4", VA = "0x10E7FB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10E8254", Offset = "0x10E8254", VA = "0x10E8254", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool gameActive;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<EnemySpawn> enemySpawn;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Timer timer;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LevelController levelController;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> grabs;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[DraggablePoint]
	public List<Vector3> positionPlayer;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[DraggablePoint]
	public List<Vector3> durationPlayer;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<EventStage> unityEventsStage;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool customController;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityEvent startGame;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public FinalBoss finalBoss;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool duplicate;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Transform> _lifeEnemy;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _timer;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float _timeSpawnLastEnemyInStage;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x10E613C", Offset = "0x10E613C", VA = "0x10E613C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x10E61D8", Offset = "0x10E61D8", VA = "0x10E61D8")]
	[IteratorStateMachine(typeof(<StartEnumerator>d__16))]
	private IEnumerator StartEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x10E6274", Offset = "0x10E6274", VA = "0x10E6274")]
	public void StartGame()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x10E6E88", Offset = "0x10E6E88", VA = "0x10E6E88")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x10E74FC", Offset = "0x10E74FC", VA = "0x10E74FC")]
	public void OffAllCollisionEnemy()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x10E11B4", Offset = "0x10E11B4", VA = "0x10E11B4")]
	public void StopGame()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x10E7784", Offset = "0x10E7784", VA = "0x10E7784")]
	public void ReloadGame()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x10E6DE8", Offset = "0x10E6DE8", VA = "0x10E6DE8")]
	[IteratorStateMachine(typeof(<EventDelay>d__22))]
	private IEnumerator EventDelay(UnityEvent _event, float delay)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x10E7710", Offset = "0x10E7710", VA = "0x10E7710")]
	[IteratorStateMachine(typeof(<EnumeratorGrab>d__23))]
	public IEnumerator EnumeratorGrab(GameObject _gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x10E7930", Offset = "0x10E7930", VA = "0x10E7930")]
	public EnemyController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class EnemySpawn
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Enemy enemy;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform alternativeEnemy;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int stage;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeSpawn;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isSpawned;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool isNecessarily;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool customSpawn;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x10E829C", Offset = "0x10E829C", VA = "0x10E829C")]
	public EnemySpawn()
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class EventStage
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UnityEvent eventStage;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeDelay;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int stage;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x10E82AC", Offset = "0x10E82AC", VA = "0x10E82AC")]
	public EventStage()
	{
	}
}
[Token(Token = "0x2000045")]
public class MeleeEnemy : Enemy
{
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x10E82B4", Offset = "0x10E82B4", VA = "0x10E82B4")]
	public MeleeEnemy()
	{
	}
}
[Token(Token = "0x2000046")]
public class RangeEnemy : Enemy
{
	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class <CooldownCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RangeEnemy <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x10E8AF8", Offset = "0x10E8AF8", VA = "0x10E8AF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x10E8B40", Offset = "0x10E8B40", VA = "0x10E8B40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10E8874", Offset = "0x10E8874", VA = "0x10E8874")]
		[DebuggerHidden]
		public <CooldownCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10E89B4", Offset = "0x10E89B4", VA = "0x10E89B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10E89B8", Offset = "0x10E89B8", VA = "0x10E89B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10E8B00", Offset = "0x10E8B00", VA = "0x10E8B00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class <ShootDelay>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RangeEnemy <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x10E8C2C", Offset = "0x10E8C2C", VA = "0x10E8C2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x10E8C74", Offset = "0x10E8C74", VA = "0x10E8C74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10E8930", Offset = "0x10E8930", VA = "0x10E8930")]
		[DebuggerHidden]
		public <ShootDelay>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10E8B48", Offset = "0x10E8B48", VA = "0x10E8B48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10E8B4C", Offset = "0x10E8B4C", VA = "0x10E8B4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10E8C34", Offset = "0x10E8C34", VA = "0x10E8C34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float cooldown;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float speedProjectile;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public float timeAim;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Projectile projectile;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Transform pointShot;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public List<SplineProjectileEnemy> splinesProjectile;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool shootingBySpline;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	[Range(0f, 2f)]
	public float valueBezier;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public int numPoints;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public UnityEvent shoot;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public bool isReadyToShoot;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private float _timerAttack;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected int IndexProjectile;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private float _timerShoot;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x10E067C", Offset = "0x10E067C", VA = "0x10E067C", Slot = "10")]
	protected override void StartVirtual()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x10E82B8", Offset = "0x10E82B8", VA = "0x10E82B8", Slot = "13")]
	public virtual void Shoot()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x10DF574", Offset = "0x10DF574", VA = "0x10DF574")]
	public void ShootReady()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x10E8800", Offset = "0x10E8800", VA = "0x10E8800")]
	[IteratorStateMachine(typeof(<CooldownCoroutine>d__17))]
	private IEnumerator CooldownCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x10E889C", Offset = "0x10E889C", VA = "0x10E889C")]
	public void ShootOff()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x10E88BC", Offset = "0x10E88BC", VA = "0x10E88BC")]
	[IteratorStateMachine(typeof(<ShootDelay>d__19))]
	private IEnumerator ShootDelay()
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x10E8958", Offset = "0x10E8958", VA = "0x10E8958")]
	public void BossRangeBuff()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x10E0D94", Offset = "0x10E0D94", VA = "0x10E0D94")]
	public RangeEnemy()
	{
	}
}
[Serializable]
[Token(Token = "0x2000049")]
public class SplineProjectileEnemy
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SplineContainer splineProjectile;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool autoDrawEndSplinePoint;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int indexPointPlayer;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x10E8C7C", Offset = "0x10E8C7C", VA = "0x10E8C7C")]
	public SplineProjectileEnemy()
	{
	}
}
[Token(Token = "0x200004A")]
public class SpearEnemy : RangeEnemy
{
	[Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class <EffectBossHit>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpearEnemy <>4__this;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x10E9D60", Offset = "0x10E9D60", VA = "0x10E9D60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x10E9DA8", Offset = "0x10E9DA8", VA = "0x10E9DA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10E97F4", Offset = "0x10E97F4", VA = "0x10E97F4")]
		[DebuggerHidden]
		public <EffectBossHit>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x10E9BF4", Offset = "0x10E9BF4", VA = "0x10E9BF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x10E9BF8", Offset = "0x10E9BF8", VA = "0x10E9BF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10E9D68", Offset = "0x10E9D68", VA = "0x10E9D68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public List<Projectile> projectilesInHand;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Vector3 scaleProjectile;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public bool axeBoss;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x195")]
	public bool isAxe;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public StudioEventEmitter hit;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public float timeEffect;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x10E8C84", Offset = "0x10E8C84", VA = "0x10E8C84", Slot = "10")]
	protected override void StartVirtual()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x10E8CDC", Offset = "0x10E8CDC", VA = "0x10E8CDC", Slot = "13")]
	public override void Shoot()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x10E3330", Offset = "0x10E3330", VA = "0x10E3330")]
	public void TakeWeapon()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x10E94E4", Offset = "0x10E94E4", VA = "0x10E94E4", Slot = "11")]
	public override void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisionEvent)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x10E9780", Offset = "0x10E9780", VA = "0x10E9780")]
	[IteratorStateMachine(typeof(<EffectBossHit>d__10))]
	private IEnumerator EffectBossHit()
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x10E981C", Offset = "0x10E981C", VA = "0x10E981C", Slot = "12")]
	public override void Die()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x10E99C4", Offset = "0x10E99C4", VA = "0x10E99C4")]
	public SpearEnemy()
	{
	}
}
[Token(Token = "0x200004E")]
public class EnemySphere : MonoBehaviour, IDamageable
{
	[Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class <DieDelay>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemySphere <>4__this;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x10EA7A8", Offset = "0x10EA7A8", VA = "0x10EA7A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x10EA7F0", Offset = "0x10EA7F0", VA = "0x10EA7F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x10EA5C4", Offset = "0x10EA5C4", VA = "0x10EA5C4")]
		[DebuggerHidden]
		public <DieDelay>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10EA60C", Offset = "0x10EA60C", VA = "0x10EA60C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10EA610", Offset = "0x10EA610", VA = "0x10EA610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x10EA7B0", Offset = "0x10EA7B0", VA = "0x10EA7B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SplineContainer spline;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve speedData;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Renderer renderer;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public VisualEffect hitEffect;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Renderer arrow;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Collider collider;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UnityEvent deathEvent;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public StudioEventEmitter startSound;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float _path;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float _duration;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 _prePositionEnemy;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float _distanceSpline;

	[Token(Token = "0x17000027")]
	public Transform transformOrigin
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10E9DB0", Offset = "0x10E9DB0", VA = "0x10E9DB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10E9DB8", Offset = "0x10E9DB8", VA = "0x10E9DB8", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public bool isDeath
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10EA5F0", Offset = "0x10EA5F0", VA = "0x10EA5F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x10EA5F8", Offset = "0x10EA5F8", VA = "0x10EA5F8", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x10E9DC0", Offset = "0x10E9DC0", VA = "0x10E9DC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x10E9FBC", Offset = "0x10E9FBC", VA = "0x10E9FBC")]
	private void StartSoundArena()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x10E2C68", Offset = "0x10E2C68", VA = "0x10E2C68")]
	public void StartSphere()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x10EA030", Offset = "0x10EA030", VA = "0x10EA030")]
	private void Update()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x10EA438", Offset = "0x10EA438", VA = "0x10EA438")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x10EA43C", Offset = "0x10EA43C", VA = "0x10EA43C", Slot = "6")]
	public void ApplyDamage(float damage, IDamageable damageable)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x10EA550", Offset = "0x10EA550", VA = "0x10EA550")]
	[IteratorStateMachine(typeof(<DieDelay>d__24))]
	private IEnumerator DieDelay()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x10EA5EC", Offset = "0x10EA5EC", VA = "0x10EA5EC", Slot = "7")]
	public void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisionEvent)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x10EA604", Offset = "0x10EA604", VA = "0x10EA604")]
	public EnemySphere()
	{
	}
}
[Token(Token = "0x2000050")]
public class FinalBoss : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class <DefendOffEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FinalBoss <>4__this;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x10EAC20", Offset = "0x10EAC20", VA = "0x10EAC20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x10EAC68", Offset = "0x10EAC68", VA = "0x10EAC68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10EA86C", Offset = "0x10EA86C", VA = "0x10EA86C")]
		[DebuggerHidden]
		public <DefendOffEnumerator>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10EAAA0", Offset = "0x10EAAA0", VA = "0x10EAAA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10EAAA4", Offset = "0x10EAAA4", VA = "0x10EAAA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10EAC28", Offset = "0x10EAC28", VA = "0x10EAC28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class <FinalEnumerator>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FinalBoss <>4__this;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x10EAD54", Offset = "0x10EAD54", VA = "0x10EAD54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x10EAD9C", Offset = "0x10EAD9C", VA = "0x10EAD9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10EAA60", Offset = "0x10EAA60", VA = "0x10EAA60")]
		[DebuggerHidden]
		public <FinalEnumerator>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10EAC70", Offset = "0x10EAC70", VA = "0x10EAC70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10EAC74", Offset = "0x10EAC74", VA = "0x10EAC74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10EAD5C", Offset = "0x10EAD5C", VA = "0x10EAD5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject animationDeath;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject originalBoss;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float timeFinal;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timeOpen;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isOpen;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int phaseIndex;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x10E7478", Offset = "0x10E7478", VA = "0x10E7478")]
	public void PhaseDestroy()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x10EA7F8", Offset = "0x10EA7F8", VA = "0x10EA7F8")]
	[IteratorStateMachine(typeof(<DefendOffEnumerator>d__8))]
	private IEnumerator DefendOffEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x10EA894", Offset = "0x10EA894", VA = "0x10EA894")]
	public void TargetShoot()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x10EA9EC", Offset = "0x10EA9EC", VA = "0x10EA9EC")]
	[IteratorStateMachine(typeof(<FinalEnumerator>d__10))]
	private IEnumerator FinalEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x10EAA88", Offset = "0x10EAA88", VA = "0x10EAA88")]
	public FinalBoss()
	{
	}
}
[Token(Token = "0x2000053")]
public class FinalBossTarget : MonoBehaviour
{
	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FinalBoss finalBoss;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x10EADA4", Offset = "0x10EADA4", VA = "0x10EADA4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x10EADBC", Offset = "0x10EADBC", VA = "0x10EADBC")]
	public FinalBossTarget()
	{
	}
}
[Token(Token = "0x2000054")]
public class FinalCollisionImage : MonoBehaviour
{
	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject sphere;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject image;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x10EADC4", Offset = "0x10EADC4", VA = "0x10EADC4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x10EAEC0", Offset = "0x10EAEC0", VA = "0x10EAEC0")]
	public FinalCollisionImage()
	{
	}
}
[Token(Token = "0x2000055")]
public class FinalTranslator : MonoBehaviour
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject translator;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 vector3;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VideoPlayer video;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public StudioEventEmitter music;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float timeEnd;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator animatorPiano;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool on;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float _timer;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _timerForEnd;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AsyncOperation mainMenu;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x10EAEC8", Offset = "0x10EAEC8", VA = "0x10EAEC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x10EAFFC", Offset = "0x10EAFFC", VA = "0x10EAFFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x10EB12C", Offset = "0x10EB12C", VA = "0x10EB12C")]
	public void Teleport()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x10EB218", Offset = "0x10EB218", VA = "0x10EB218")]
	public FinalTranslator()
	{
	}
}
[Token(Token = "0x2000056")]
public class FixedPosition : MonoBehaviour
{
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform connectTransform;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x10EB240", Offset = "0x10EB240", VA = "0x10EB240")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x10EB2BC", Offset = "0x10EB2BC", VA = "0x10EB2BC")]
	public FixedPosition()
	{
	}
}
[Token(Token = "0x2000057")]
public static class FunctionLibary
{
	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int LayerHurricane;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x10E24B4", Offset = "0x10E24B4", VA = "0x10E24B4")]
	public static IDamageable CheckDamageable(Transform damageable)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x10EB2C4", Offset = "0x10EB2C4", VA = "0x10EB2C4")]
	public static void TryGetDamageable(this Transform inObject, out IDamageable damageable, bool withRoot = false)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x10EB3DC", Offset = "0x10EB3DC", VA = "0x10EB3DC")]
	public static Weapon CheckWeapon(Transform weapon)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	public static T TryGetComponentWithReturn<T>(this Transform inObject, out T outComponent, bool withRoot = false) where T : class
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x10EB4B8", Offset = "0x10EB4B8", VA = "0x10EB4B8")]
	public static void SetGameLayerRecursive(GameObject _go, int _layer)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x10EB88C", Offset = "0x10EB88C", VA = "0x10EB88C")]
	public static bool IsInLayer(this int layer, LayerMask layerMask)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000058")]
public class RendererFeaturesController : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class <SmoothEnable>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RendererFeaturesController <>4__this;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x10EC0A0", Offset = "0x10EC0A0", VA = "0x10EC0A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x10EC0E8", Offset = "0x10EC0E8", VA = "0x10EC0E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x10EBD60", Offset = "0x10EBD60", VA = "0x10EBD60")]
		[DebuggerHidden]
		public <SmoothEnable>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x10EBF84", Offset = "0x10EBF84", VA = "0x10EBF84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x10EBF88", Offset = "0x10EBF88", VA = "0x10EBF88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10EC0A8", Offset = "0x10EC0A8", VA = "0x10EC0A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class <SmoothDisable>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RendererFeaturesController <>4__this;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool> callback;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x10EC224", Offset = "0x10EC224", VA = "0x10EC224", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x10EC26C", Offset = "0x10EC26C", VA = "0x10EC26C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x10EBD88", Offset = "0x10EBD88", VA = "0x10EBD88")]
		[DebuggerHidden]
		public <SmoothDisable>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x10EC0F0", Offset = "0x10EC0F0", VA = "0x10EC0F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x10EC0F4", Offset = "0x10EC0F4", VA = "0x10EC0F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x10EC22C", Offset = "0x10EC22C", VA = "0x10EC22C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UniversalRendererData rendererData;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string featureEnemy;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string featureAllObject;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float transitionPeriod;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Pico")]
	public UniversalRendererData picoRenderData;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedEnable;

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x10EB924", Offset = "0x10EB924", VA = "0x10EB924")]
	private void PlatformInitialize()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x10EB930", Offset = "0x10EB930", VA = "0x10EB930")]
	private void Start()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x10EB950", Offset = "0x10EB950", VA = "0x10EB950")]
	private void StartScene()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10E69C4", Offset = "0x10E69C4", VA = "0x10E69C4")]
	public void StartLevel()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x10EBB8C", Offset = "0x10EBB8C", VA = "0x10EBB8C")]
	public void StartTransition()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x10EB984", Offset = "0x10EB984", VA = "0x10EB984")]
	private bool TryGetFeature(string featureName, out ScriptableRendererFeature feature)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x10EBCC8", Offset = "0x10EBCC8", VA = "0x10EBCC8")]
	[IteratorStateMachine(typeof(<SmoothEnable>d__12))]
	private IEnumerator SmoothEnable(Material material)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x10EBAE8", Offset = "0x10EBAE8", VA = "0x10EBAE8")]
	[IteratorStateMachine(typeof(<SmoothDisable>d__13))]
	private IEnumerator SmoothDisable(Material material, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x10EBDB0", Offset = "0x10EBDB0", VA = "0x10EBDB0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x10EBDB4", Offset = "0x10EBDB4", VA = "0x10EBDB4")]
	public void ReloadScene()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x10EBF2C", Offset = "0x10EBF2C", VA = "0x10EBF2C")]
	public RendererFeaturesController()
	{
	}
}
[Token(Token = "0x200005D")]
public class GraphicsSettings : MonoBehaviour
{
	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Toggle toggle;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x10EC274", Offset = "0x10EC274", VA = "0x10EC274")]
	private void Start()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x10EC2E0", Offset = "0x10EC2E0", VA = "0x10EC2E0")]
	public void EnablePostProcessing(bool enable)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x10EC32C", Offset = "0x10EC32C", VA = "0x10EC32C")]
	public GraphicsSettings()
	{
	}
}
[Token(Token = "0x200005E")]
public interface IDamageable
{
	[Token(Token = "0x17000033")]
	Transform transformOrigin
	{
		[Token(Token = "0x600019A")]
		get;
		[Token(Token = "0x600019B")]
		set;
	}

	[Token(Token = "0x17000034")]
	bool isDeath
	{
		[Token(Token = "0x600019E")]
		get;
		[Token(Token = "0x600019F")]
		set;
	}

	[Token(Token = "0x600019C")]
	void ApplyDamage(float damage, IDamageable damageable);

	[Token(Token = "0x600019D")]
	void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisionEvent);
}
[Token(Token = "0x200005F")]
public class LevelController : MonoBehaviour
{
	[Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class <DelayStartAnimation>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animation anim;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timerDelay>5__2;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x10ECB84", Offset = "0x10ECB84", VA = "0x10ECB84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x10ECBCC", Offset = "0x10ECBCC", VA = "0x10ECBCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10EC5CC", Offset = "0x10EC5CC", VA = "0x10EC5CC")]
		[DebuggerHidden]
		public <DelayStartAnimation>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x10ECA60", Offset = "0x10ECA60", VA = "0x10ECA60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x10ECA64", Offset = "0x10ECA64", VA = "0x10ECA64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10ECB8C", Offset = "0x10ECB8C", VA = "0x10ECB8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneId;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelController <>4__this;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10ECBD4", Offset = "0x10ECBD4", VA = "0x10ECBD4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10ECBDC", Offset = "0x10ECBDC", VA = "0x10ECBDC")]
		internal void <EndLevel>b__0(bool f)
		{
		}
	}

	[Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class <EndLevel>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sceneId;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelController <>4__this;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass19_0 <>8__1;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x10ECE08", Offset = "0x10ECE08", VA = "0x10ECE08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x10ECE50", Offset = "0x10ECE50", VA = "0x10ECE50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10EC878", Offset = "0x10EC878", VA = "0x10EC878")]
		[DebuggerHidden]
		public <EndLevel>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10ECC50", Offset = "0x10ECC50", VA = "0x10ECC50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10ECC54", Offset = "0x10ECC54", VA = "0x10ECC54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10ECE10", Offset = "0x10ECE10", VA = "0x10ECE10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AnimationOnLevel> animationOnLevel;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int stage;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EnemyController enemyController;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EffectController effectController;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LevelController Instance;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RendererFeaturesController rendererFeaturesController;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int sceneIndex;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float endTime;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool gameStop;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool itsArena;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _timer;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<int> OnChangeScene;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x10EC334", Offset = "0x10EC334", VA = "0x10EC334")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x10EC38C", Offset = "0x10EC38C", VA = "0x10EC38C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x10E67F4", Offset = "0x10E67F4", VA = "0x10E67F4")]
	public void ChangeStage()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x10EC4AC", Offset = "0x10EC4AC", VA = "0x10EC4AC")]
	public void PlayAction(string nameAction)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x10EC428", Offset = "0x10EC428", VA = "0x10EC428")]
	[IteratorStateMachine(typeof(<DelayStartAnimation>d__16))]
	private IEnumerator DelayStartAnimation(float delay, Animation anim)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x10EC5F4", Offset = "0x10EC5F4", VA = "0x10EC5F4")]
	public void ReloadScene()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x10EC79C", Offset = "0x10EC79C", VA = "0x10EC79C")]
	public void SwitchNewLevel()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x10EC718", Offset = "0x10EC718", VA = "0x10EC718")]
	[IteratorStateMachine(typeof(<EndLevel>d__19))]
	private IEnumerator EndLevel(int sceneId)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x10EC8A0", Offset = "0x10EC8A0", VA = "0x10EC8A0")]
	public LevelController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000064")]
public class AnimationOnLevel
{
	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Animation animation;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int stage;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float time;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isActivateAction;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string nameAction;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isPlaying;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x10ECE58", Offset = "0x10ECE58", VA = "0x10ECE58")]
	public AnimationOnLevel()
	{
	}
}
[Token(Token = "0x2000065")]
public class MedalArena : MonoBehaviour
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string prefsMedal;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject medalImage;

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x10ECE60", Offset = "0x10ECE60", VA = "0x10ECE60")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x10ECEC0", Offset = "0x10ECEC0", VA = "0x10ECEC0")]
	public MedalArena()
	{
	}
}
[Token(Token = "0x2000066")]
public class LevelButtonHandler : MonoBehaviour
{
	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int levelIndex;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Text nameText;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text levelNumberText;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float disabledAlpha;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private EventTrigger _eventTrigger;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CanvasGroup _canvasGroup;

	[Token(Token = "0x17000039")]
	public string LevelName
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x10ECEC8", Offset = "0x10ECEC8", VA = "0x10ECEC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public string LevelNumber
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10ECEEC", Offset = "0x10ECEEC", VA = "0x10ECEEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x10ECF10", Offset = "0x10ECF10", VA = "0x10ECF10")]
	public void Init()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x10ECFA0", Offset = "0x10ECFA0", VA = "0x10ECFA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x10ECFA4", Offset = "0x10ECFA4", VA = "0x10ECFA4")]
	public void SetUnlockedState(bool setActive)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x10ECFF8", Offset = "0x10ECFF8", VA = "0x10ECFF8")]
	public void ClearPrefs()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x10ED040", Offset = "0x10ED040", VA = "0x10ED040")]
	public LevelButtonHandler()
	{
	}
}
[Token(Token = "0x2000067")]
public class MenuController : MonoBehaviour
{
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Player refs")]
	public Camera playerCamera;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LineRenderer rightPointer;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer leftPointer;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space]
	public EventSystem eventSystem;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Space]
	public GameObject loadingScreen;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space]
	public Transform levelsContainer;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	public TMP_Text continueLevelName;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text continueLevelNumber;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Debug values")]
	public GameObject currentScreen;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool setLevelButtonsState;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Stack<GameObject> _screenHistory;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<LevelButtonHandler> _levelButtons;

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x10ED054", Offset = "0x10ED054", VA = "0x10ED054")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x10ED1C8", Offset = "0x10ED1C8", VA = "0x10ED1C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x10ED308", Offset = "0x10ED308", VA = "0x10ED308")]
	private void UpdateLevelButtonsStates(bool debug = false)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x10ED4AC", Offset = "0x10ED4AC", VA = "0x10ED4AC")]
	private void SetScreenInternal(GameObject screen, bool back = false)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x10ED54C", Offset = "0x10ED54C", VA = "0x10ED54C")]
	public void SetScreen(GameObject screen)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x10ED554", Offset = "0x10ED554", VA = "0x10ED554")]
	[ContextMenu("BackScreen")]
	public void BackScreen()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x10ED5B4", Offset = "0x10ED5B4", VA = "0x10ED5B4")]
	public void LoadLevel(LevelButtonHandler levelBtn)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x10ED624", Offset = "0x10ED624", VA = "0x10ED624")]
	private void DisableInputs()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x10ED670", Offset = "0x10ED670", VA = "0x10ED670")]
	public void ContinueGame()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x10ED704", Offset = "0x10ED704", VA = "0x10ED704")]
	public void ResetSavedData()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x10ED74C", Offset = "0x10ED74C", VA = "0x10ED74C")]
	public void Quit()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x10ED754", Offset = "0x10ED754", VA = "0x10ED754")]
	public MenuController()
	{
	}
}
[Token(Token = "0x2000068")]
public class MyCustomButton : MonoBehaviour
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject selectedImage;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	public GameObject[] goDisableOnHover;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] goEnableOnHover;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image[] imDisableOnHover;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image[] imEnableOnHover;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	public Image[] hoverImages;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image[] changeColorImages;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color[] newImageColors;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color[] _startImageColors;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI[] textsToChange;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color[] newTextsColors;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Color[] _startTextColors;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RectTransform[] objectsToTransform;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RectTransform[] transformedRects;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<(Vector2, Vector2)> _startRects;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<(Vector2, Vector2)> _endRects;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float timeToTransition;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool smthHappening;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UnityEvent onClick;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public UnityEvent OnClickSound;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UnityEvent OnDenySound;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public UnityEvent OnHoverSound;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private sbyte _k;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float _percent;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool changeTransform;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	public bool showHoverImage;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	public bool changeText;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x10ED82C", Offset = "0x10ED82C", VA = "0x10ED82C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x10EDC64", Offset = "0x10EDC64", VA = "0x10EDC64")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x10EE210", Offset = "0x10EE210", VA = "0x10EE210")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x10EE300", Offset = "0x10EE300", VA = "0x10EE300")]
	[ContextMenu("TestClick")]
	public void Click()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x10EE358", Offset = "0x10EE358", VA = "0x10EE358")]
	[ContextMenu("TestClickSounds")]
	public void TestClickSounds()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x10EE37C", Offset = "0x10EE37C", VA = "0x10EE37C")]
	[ContextMenu("Test Hover")]
	public void Hover()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x10EE240", Offset = "0x10EE240", VA = "0x10EE240")]
	[ContextMenu("Test Unhover")]
	public void UnHover()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x10EE44C", Offset = "0x10EE44C", VA = "0x10EE44C")]
	public void Select()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x10EE46C", Offset = "0x10EE46C", VA = "0x10EE46C")]
	public void DeSelect()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x10EE48C", Offset = "0x10EE48C", VA = "0x10EE48C")]
	public void Disable()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x10EE494", Offset = "0x10EE494", VA = "0x10EE494")]
	public MyCustomButton()
	{
	}
}
[Token(Token = "0x200006A")]
public class ScrollController : MonoBehaviour
{
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScrollRect scrollRect;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float scrollSpeed;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float joystickScrollSpeed;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Bounds _bounds;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Camera _rightCamera;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Camera _leftCamera;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _initialized;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[Header("Debug")]
	public bool visibleLeft;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool visibleRight;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x10EE75C", Offset = "0x10EE75C", VA = "0x10EE75C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x10EEB90", Offset = "0x10EEB90", VA = "0x10EEB90")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x10EED50", Offset = "0x10EED50", VA = "0x10EED50")]
	public void ScrollUp()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x10EEDD0", Offset = "0x10EEDD0", VA = "0x10EEDD0")]
	public void ScrollDown()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x10EEE4C", Offset = "0x10EEE4C", VA = "0x10EEE4C")]
	public ScrollController()
	{
	}
}
[Token(Token = "0x200006C")]
public class SliderToTextConnector : MonoBehaviour
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI textLabel;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool roundTo5Hun;

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x10EEFE8", Offset = "0x10EEFE8", VA = "0x10EEFE8")]
	public void SetText(float value)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x10EF17C", Offset = "0x10EF17C", VA = "0x10EF17C")]
	public SliderToTextConnector()
	{
	}
}
[Token(Token = "0x200006D")]
public class TestAlphaSetter : MonoBehaviour
{
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x10EF184", Offset = "0x10EF184", VA = "0x10EF184")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x10EF1E4", Offset = "0x10EF1E4", VA = "0x10EF1E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x10EF1E8", Offset = "0x10EF1E8", VA = "0x10EF1E8")]
	public TestAlphaSetter()
	{
	}
}
[Token(Token = "0x200006E")]
public class VCAController : MonoBehaviour
{
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string vcaName;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VCA _vca;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Slider _slider;

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x10EF1F0", Offset = "0x10EF1F0", VA = "0x10EF1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x10EF2BC", Offset = "0x10EF2BC", VA = "0x10EF2BC")]
	public void ValueUpdate(float value)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x10EF2C8", Offset = "0x10EF2C8", VA = "0x10EF2C8")]
	public VCAController()
	{
	}
}
[Token(Token = "0x200006F")]
public class MovementTimeController : MonoBehaviour
{
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BowControlTime bowControlTime;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _isActive;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x10EF2D0", Offset = "0x10EF2D0", VA = "0x10EF2D0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x10EF498", Offset = "0x10EF498", VA = "0x10EF498")]
	public MovementTimeController()
	{
	}
}
[Token(Token = "0x2000070")]
public class Pause : MonoBehaviour
{
	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool pause;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Rigidbody> notPausedRigidbody;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<HVRHandGrabber> hands;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int hurricane;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int pauseLayer;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Player player;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PauseMenu pauseMenu;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InputAction input;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Rigidbody _listRigidbody;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Rigidbody> _rigidbodiesForPause;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float timerButton;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<Rigidbody, Vector3> _velocity;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<Rigidbody, Vector3> _angularVelocity;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<Rigidbody, bool> _isKinematic;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _playerPosition;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x10EF4A0", Offset = "0x10EF4A0", VA = "0x10EF4A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x10EF508", Offset = "0x10EF508", VA = "0x10EF508")]
	public void Update()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x10EF62C", Offset = "0x10EF62C", VA = "0x10EF62C")]
	public void PauseActive()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x10F00E0", Offset = "0x10F00E0", VA = "0x10F00E0")]
	private void SetChildLayers(Transform trans, int layer)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x10EFB74", Offset = "0x10EFB74", VA = "0x10EFB74")]
	public void UnPause()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x10F04B4", Offset = "0x10F04B4", VA = "0x10F04B4")]
	public void LoadMenu()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x10F0508", Offset = "0x10F0508", VA = "0x10F0508")]
	public void RestartLevel()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x10F0558", Offset = "0x10F0558", VA = "0x10F0558")]
	public Pause()
	{
	}
}
[Token(Token = "0x2000071")]
public class PauseMenu : MonoBehaviour
{
	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PauseMenu Instance;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject canvas;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x10F06B0", Offset = "0x10F06B0", VA = "0x10F06B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x10EFF44", Offset = "0x10EFF44", VA = "0x10EFF44")]
	public void PauseEnable()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x10F0494", Offset = "0x10F0494", VA = "0x10F0494")]
	public void PauseDisable()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x10F0708", Offset = "0x10F0708", VA = "0x10F0708")]
	public void LoadMenu()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x10F075C", Offset = "0x10F075C", VA = "0x10F075C")]
	public void RestartLevel()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x10F07AC", Offset = "0x10F07AC", VA = "0x10F07AC")]
	public void Unpause()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x10F0804", Offset = "0x10F0804", VA = "0x10F0804")]
	public PauseMenu()
	{
	}
}
[Token(Token = "0x2000072")]
public class PlatformHandler : MonoBehaviour
{
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x10F080C", Offset = "0x10F080C", VA = "0x10F080C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x10F0810", Offset = "0x10F0810", VA = "0x10F0810")]
	private static void PushAppQuit(string inMessage = "")
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x10F0890", Offset = "0x10F0890", VA = "0x10F0890")]
	public PlatformHandler()
	{
	}
}
[Token(Token = "0x2000073")]
public class BowControlTime : MonoBehaviour
{
	[Token(Token = "0x6000207")]
	[Address(RVA = "0x10EF3C0", Offset = "0x10EF3C0", VA = "0x10EF3C0")]
	public void AccelerationTime()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x10EF42C", Offset = "0x10EF42C", VA = "0x10EF42C")]
	public void SlowTime()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x10F0898", Offset = "0x10F0898", VA = "0x10F0898")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x10F089C", Offset = "0x10F089C", VA = "0x10F089C")]
	public BowControlTime()
	{
	}
}
[Token(Token = "0x2000074")]
public class CollideForBow : MonoBehaviour
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tagProjectileEnemy;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x10F08A4", Offset = "0x10F08A4", VA = "0x10F08A4")]
	public CollideForBow()
	{
	}
}
[Token(Token = "0x2000075")]
public class HandCheckEnemy : MonoBehaviour
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool invisible;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _timeInvisible;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _timer;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x10F08AC", Offset = "0x10F08AC", VA = "0x10F08AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x10F08F0", Offset = "0x10F08F0", VA = "0x10F08F0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x10F0C04", Offset = "0x10F0C04", VA = "0x10F0C04")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x10F0E38", Offset = "0x10F0E38", VA = "0x10F0E38")]
	public HandCheckEnemy()
	{
	}
}
[Token(Token = "0x2000076")]
public class Player : MonoBehaviour, IDamageable
{
	[Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class <TeleportDelay>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Player <>4__this;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool teleportBow;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x10F1E48", Offset = "0x10F1E48", VA = "0x10F1E48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x10F1E90", Offset = "0x10F1E90", VA = "0x10F1E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x10F15C0", Offset = "0x10F15C0", VA = "0x10F15C0")]
		[DebuggerHidden]
		public <TeleportDelay>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x10F1600", Offset = "0x10F1600", VA = "0x10F1600", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x10F1604", Offset = "0x10F1604", VA = "0x10F1604", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x10F1E50", Offset = "0x10F1E50", VA = "0x10F1E50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Player Instance;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cam;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HVRHandGrabber leftHand;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HVRHandGrabber rightHand;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform leftController;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rightController;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ScreenFading sphereScreenFading;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform playerGeneralTransform;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public HVRTeleporter teleporter;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public StudioEventEmitter deathSound;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Pause pause;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject collider;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int layerEnemyKiller;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UnityEvent death;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float maxHp;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float _timeInvisible;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float _timer;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool _itsFirstTeleport;

	[Token(Token = "0x1700003B")]
	public bool isDeath
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x10F0E54", Offset = "0x10F0E54", VA = "0x10F0E54", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x10F0E5C", Offset = "0x10F0E5C", VA = "0x10F0E5C", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public Transform transformOrigin
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x10F0E68", Offset = "0x10F0E68", VA = "0x10F0E68", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x10F0E70", Offset = "0x10F0E70", VA = "0x10F0E70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public float CurrentHeath
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x10F0E78", Offset = "0x10F0E78", VA = "0x10F0E78")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x10F0E80", Offset = "0x10F0E80", VA = "0x10F0E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x10F0E88", Offset = "0x10F0E88", VA = "0x10F0E88")]
	private void Start()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x10F0A5C", Offset = "0x10F0A5C", VA = "0x10F0A5C", Slot = "6")]
	public void ApplyDamage(float damage, IDamageable damageable)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x10F0EE4", Offset = "0x10F0EE4", VA = "0x10F0EE4", Slot = "7")]
	public void ApplyDamage(float damage, IDamageable damageable, BodyPart bodyPart, Vector3 force, CollisionEvent collisonevent)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x10F0EE8", Offset = "0x10F0EE8", VA = "0x10F0EE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x10F0F40", Offset = "0x10F0F40", VA = "0x10F0F40")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x10F150C", Offset = "0x10F150C", VA = "0x10F150C")]
	private void Update()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x10E6B08", Offset = "0x10E6B08", VA = "0x10E6B08")]
	public void TeleportPlayer(Vector3 position, Vector3 duration, bool teleportBow = true)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x10F1538", Offset = "0x10F1538", VA = "0x10F1538")]
	[IteratorStateMachine(typeof(<TeleportDelay>d__37))]
	private IEnumerator TeleportDelay(bool teleportBow = true)
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x10F15E8", Offset = "0x10F15E8", VA = "0x10F15E8")]
	public Player()
	{
	}
}
[Token(Token = "0x2000078")]
public class PlayerBow : HVRPhysicsBow
{
	[Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class <StartEnumerator>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerBow <>4__this;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1104B0C", Offset = "0x1104B0C", VA = "0x1104B0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1104B54", Offset = "0x1104B54", VA = "0x1104B54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x110394C", Offset = "0x110394C", VA = "0x110394C")]
		[DebuggerHidden]
		public <StartEnumerator>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1104800", Offset = "0x1104800", VA = "0x1104800", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1104804", Offset = "0x1104804", VA = "0x1104804", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1104B14", Offset = "0x1104B14", VA = "0x1104B14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class <SfxOn>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerBow <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x1104C24", Offset = "0x1104C24", VA = "0x1104C24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1104C6C", Offset = "0x1104C6C", VA = "0x1104C6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1104290", Offset = "0x1104290", VA = "0x1104290")]
		[DebuggerHidden]
		public <SfxOn>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1104B5C", Offset = "0x1104B5C", VA = "0x1104B5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1104B60", Offset = "0x1104B60", VA = "0x1104B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1104C2C", Offset = "0x1104C2C", VA = "0x1104C2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class <ShootSoundDelay>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x1104D1C", Offset = "0x1104D1C", VA = "0x1104D1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1104D64", Offset = "0x1104D64", VA = "0x1104D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x11047C0", Offset = "0x11047C0", VA = "0x11047C0")]
		[DebuggerHidden]
		public <ShootSoundDelay>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1104C74", Offset = "0x1104C74", VA = "0x1104C74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1104C78", Offset = "0x1104C78", VA = "0x1104C78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1104D24", Offset = "0x1104D24", VA = "0x1104D24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public int numPoints;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public string tagEnemy;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float gravity;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public HVRArrowLoader hvrArrowLoader;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlayerBow Instance;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[Header("SFX")]
	public RDNA_bow sfxBow;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float bowOffset;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[Header("Indicator")]
	public Material indicatorMaterial;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public float maxDistance;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public LayerMask layerForIndicator;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public StudioEventEmitter indicator;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public UnityEvent shootEvent;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private float _timerChangeArrow;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private bool _maxHaptics;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Action<float> OnTension;

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x11038AC", Offset = "0x11038AC", VA = "0x11038AC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x11038D8", Offset = "0x11038D8", VA = "0x11038D8")]
	[IteratorStateMachine(typeof(<StartEnumerator>d__16))]
	private IEnumerator StartEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1103974", Offset = "0x1103974", VA = "0x1103974")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x11039CC", Offset = "0x11039CC", VA = "0x11039CC", Slot = "11")]
	protected override void ShootArrow(Vector3 direction)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x11040D8", Offset = "0x11040D8", VA = "0x11040D8")]
	public void ReloadArrow()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x11041EC", Offset = "0x11041EC", VA = "0x11041EC")]
	public void SfxOff()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x110421C", Offset = "0x110421C", VA = "0x110421C")]
	[IteratorStateMachine(typeof(<SfxOn>d__21))]
	private IEnumerator SfxOn()
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x11042B8", Offset = "0x11042B8", VA = "0x11042B8", Slot = "8")]
	protected override void FixedUpdateBow()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1104458", Offset = "0x1104458", VA = "0x1104458")]
	private void RaycastIndicator()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x110405C", Offset = "0x110405C", VA = "0x110405C")]
	[IteratorStateMachine(typeof(<ShootSoundDelay>d__24))]
	private IEnumerator ShootSoundDelay()
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x11047E8", Offset = "0x11047E8", VA = "0x11047E8")]
	public PlayerBow()
	{
	}
}
[Token(Token = "0x200007C")]
public enum TypeArrow
{
	[Token(Token = "0x4000240")]
	Default,
	[Token(Token = "0x4000241")]
	Multiple,
	[Token(Token = "0x4000242")]
	Piercing
}
[Token(Token = "0x200007D")]
public class PlayerHelper : MonoBehaviour
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Links")]
	public Camera cameraPlayer;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Settings")]
	public float speed;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float angleSpeed;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion _randomRotate;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 offset;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxDistanceEnemyInNoVisibility;

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1104D6C", Offset = "0x1104D6C", VA = "0x1104D6C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1105078", Offset = "0x1105078", VA = "0x1105078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x110507C", Offset = "0x110507C", VA = "0x110507C")]
	public PlayerHelper()
	{
	}
}
[Token(Token = "0x200007E")]
public class Projectile : MonoBehaviour, Weapon
{
	[Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class <Dissolve>d__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Projectile <>4__this;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1108E28", Offset = "0x1108E28", VA = "0x1108E28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1108E70", Offset = "0x1108E70", VA = "0x1108E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1108A4C", Offset = "0x1108A4C", VA = "0x1108A4C")]
		[DebuggerHidden]
		public <Dissolve>d__96(int <>1__state)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1108B8C", Offset = "0x1108B8C", VA = "0x1108B8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1108B90", Offset = "0x1108B90", VA = "0x1108B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1108E30", Offset = "0x1108E30", VA = "0x1108E30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Test")]
	public bool testVariantForStabDamageable;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("AutoLinks")]
	public HVRStabber stabber;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HVRArrow arrow;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ThrowGrabbable throwGrabbable;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HVRCenterOfMassOverride centerOfMass;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Links")]
	public Animation animationProjectile;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject trailArrowObject;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Collider> colliders;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform pointTip;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform pointBase;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public IDamageable damageable;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TrailRenderer trailKilled;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Animation spearAnimation;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Renderer renderer;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Enemy parentEnemy;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public VisualEffect collideFX;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public StudioEventEmitter soundMeleeAttack;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Header("Sound Links")]
	public StudioEventEmitter soundHitEnemy;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<CollisionMaterial> collisionMaterials;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string defaultMaterialCollision;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("Settings")]
	[Range(0f, 1f)]
	[Tooltip("0 = 0 deg | 1 = 90 deg")]
	public float angleRicochetThreshold;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[Range(0f, 1f)]
	public float depthOfPenetration;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool canRicochet;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int ricochetCount;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool canStab;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public LayerMask layerMaskLevel;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public LayerMask layerMaskNotStab;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public LayerMask layerMaskEnemy;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float damage;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int layerEnemyKiller;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LayerMask nonCollisionLayerMask;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public float forceModifier;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public AnimationCurve dependencePenetrationOnSpeed;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool isHostile;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
	public bool dissolve;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
	[Header("States")]
	public bool isFlying;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float timeCollideFX;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float speed;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float distanceFromTipToBase;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool isCollisionReloads;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool isColdWeapon;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public UnityEvent stopFly;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public UnityEvent shootEvent;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public UnityEvent collideFXStart;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public bool startingShoot;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected SplineContainer _splineContainer;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected float _duration;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected Transform _endPoint;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected bool _lockAtSpline;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private float _gravity;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float _timerCollision;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly float _cooldownCollision;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int _reflectIndex;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<Vector3> _points;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private PlayerBow _bow;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int _indexPoints;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private TrailRenderer trailArrowRenderer;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool _customRotation;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
	private bool _isDissolve;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private Vector3 tipForwardLastFrame;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Vector3 arrowPosLastFrame;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private Vector3 tipPosLastFrame;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Quaternion arrowRotLastFrame;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private readonly Dictionary<string, CollisionMaterial> collisionMaterialsDictionary;

	[Token(Token = "0x17000046")]
	public Transform transformOrigin
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1105084", Offset = "0x1105084", VA = "0x1105084", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x110508C", Offset = "0x110508C", VA = "0x110508C", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x110509C", Offset = "0x110509C", VA = "0x110509C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x11054A4", Offset = "0x11054A4", VA = "0x11054A4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x11061BC", Offset = "0x11061BC", VA = "0x11061BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x11068B0", Offset = "0x11068B0", VA = "0x11068B0")]
	private void Reflect(Collision collision)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1103D64", Offset = "0x1103D64", VA = "0x1103D64")]
	public void ArrowShot(List<Vector3> point, float speed, float gravity, PlayerBow bow, [Optional] IDamageable _damageable, bool customRotation = false)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1106BEC", Offset = "0x1106BEC", VA = "0x1106BEC")]
	public bool CheckBow(Transform bow)
	{
		return default(bool);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1106D48", Offset = "0x1106D48", VA = "0x1106D48")]
	public void ArrowShot(SplineContainer spline, float speed, [Optional] IDamageable _damageable, bool autoDrawEndSplinePoint = false, bool lockAtSpline = true, int indexPointPlayer = 1, [Optional] Transform pointReturned)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x11073F0", Offset = "0x11073F0", VA = "0x11073F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x11074C8", Offset = "0x11074C8", VA = "0x11074C8")]
	public void KilledPlayer()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1107578", Offset = "0x1107578", VA = "0x1107578")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1107BEC", Offset = "0x1107BEC", VA = "0x1107BEC", Slot = "6")]
	protected virtual void MovementBySpline()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1107E30", Offset = "0x1107E30", VA = "0x1107E30", Slot = "7")]
	protected virtual void EndSpline()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1107670", Offset = "0x1107670", VA = "0x1107670")]
	private void MovementByPoint()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x11056E0", Offset = "0x11056E0", VA = "0x11056E0")]
	private void CollisionOther(Collision collision)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1108098", Offset = "0x1108098", VA = "0x1108098")]
	private void StabOther(CollisionMaterial collisionMaterial)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x1105AE0", Offset = "0x1105AE0", VA = "0x1105AE0")]
	private void CollisionDamageable(Collision collision, IDamageable collisionDamageable)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x11063C0", Offset = "0x11063C0", VA = "0x11063C0")]
	private void CollisionDamageable(Transform collision, IDamageable collisionDamageable)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1108438", Offset = "0x1108438", VA = "0x1108438")]
	private void StabDamageable(Collision collision, IDamageable inDamageable)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1108664", Offset = "0x1108664", VA = "0x1108664")]
	private void StabDamageable(Transform collision, IDamageable inDamageable)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x11082CC", Offset = "0x11082CC", VA = "0x11082CC")]
	private void DestroyPhysics()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x110823C", Offset = "0x110823C", VA = "0x110823C")]
	private void DisableArrowLife()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1107F60", Offset = "0x1107F60", VA = "0x1107F60")]
	private void DisableTrail()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1106B5C", Offset = "0x1106B5C", VA = "0x1106B5C")]
	private void EnableTrail()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x110886C", Offset = "0x110886C", VA = "0x110886C")]
	public void OnGrabbed()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1107FE4", Offset = "0x1107FE4", VA = "0x1107FE4")]
	public void StartCollideFx()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1108930", Offset = "0x1108930", VA = "0x1108930")]
	public void OffCollision()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1107EEC", Offset = "0x1107EEC", VA = "0x1107EEC")]
	[IteratorStateMachine(typeof(<Dissolve>d__96))]
	private IEnumerator Dissolve()
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1108A74", Offset = "0x1108A74", VA = "0x1108A74")]
	public Projectile()
	{
	}
}
[Serializable]
[Token(Token = "0x2000080")]
public struct CollisionMaterial
{
	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string tag;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[Range(0f, 1f)]
	public float penetrationMalleability;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public EventReference sound;
}
[Token(Token = "0x2000081")]
public class RaycastEnemy : MonoBehaviour
{
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layer;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1108E78", Offset = "0x1108E78", VA = "0x1108E78")]
	private void Update()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1108FD8", Offset = "0x1108FD8", VA = "0x1108FD8")]
	public RaycastEnemy()
	{
	}
}
[Token(Token = "0x2000082")]
public class RecordingCamera : MonoBehaviour
{
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cam;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float damping;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1108FE0", Offset = "0x1108FE0", VA = "0x1108FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1108FE4", Offset = "0x1108FE4", VA = "0x1108FE4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x11090F8", Offset = "0x11090F8", VA = "0x11090F8")]
	public RecordingCamera()
	{
	}
}
[Token(Token = "0x2000083")]
public class ScreenFading : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class <ScreenFadingOn>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenFading <>4__this;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <scale>5__2;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1109464", Offset = "0x1109464", VA = "0x1109464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x11094AC", Offset = "0x11094AC", VA = "0x11094AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1109190", Offset = "0x1109190", VA = "0x1109190")]
		[DebuggerHidden]
		public <ScreenFadingOn>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x110925C", Offset = "0x110925C", VA = "0x110925C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1109260", Offset = "0x1109260", VA = "0x1109260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x110946C", Offset = "0x110946C", VA = "0x110946C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class <ScreenFadingOff>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenFading <>4__this;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <scale>5__2;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x110966C", Offset = "0x110966C", VA = "0x110966C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x11096B4", Offset = "0x11096B4", VA = "0x11096B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x110922C", Offset = "0x110922C", VA = "0x110922C")]
		[DebuggerHidden]
		public <ScreenFadingOff>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11094B4", Offset = "0x11094B4", VA = "0x11094B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x11094B8", Offset = "0x11094B8", VA = "0x11094B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1109674", Offset = "0x1109674", VA = "0x1109674", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float scaleSphere;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform sphere;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedScaleOn;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speedScaleOff;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1109100", Offset = "0x1109100", VA = "0x1109100")]
	[IteratorStateMachine(typeof(<ScreenFadingOn>d__4))]
	public IEnumerator ScreenFadingOn(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x11091B8", Offset = "0x11091B8", VA = "0x11091B8")]
	[IteratorStateMachine(typeof(<ScreenFadingOff>d__5))]
	public IEnumerator ScreenFadingOff()
	{
		return null;
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1109254", Offset = "0x1109254", VA = "0x1109254")]
	public ScreenFading()
	{
	}
}
[Token(Token = "0x2000086")]
public class SC_FPSCounter : MonoBehaviour
{
	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float updateInterval;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float accum;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frames;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timeleft;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float fps;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GUIStyle textStyle;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x11096BC", Offset = "0x11096BC", VA = "0x11096BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x1109714", Offset = "0x1109714", VA = "0x1109714")]
	private void Update()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1109794", Offset = "0x1109794", VA = "0x1109794")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x110988C", Offset = "0x110988C", VA = "0x110988C")]
	public SC_FPSCounter()
	{
	}
}
[Token(Token = "0x2000087")]
public class ShaderTime : MonoBehaviour
{
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material materialWithTimeEffect;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nameParameter;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxValue;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minValue;

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1109908", Offset = "0x1109908", VA = "0x1109908")]
	private void Update()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x11099E0", Offset = "0x11099E0", VA = "0x11099E0")]
	public ShaderTime()
	{
	}
}
[Token(Token = "0x2000088")]
public class StartArena : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedInAlternativeTime;

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x11099F0", Offset = "0x11099F0", VA = "0x11099F0")]
	public void AlternativeTime()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1109B3C", Offset = "0x1109B3C", VA = "0x1109B3C")]
	public void NoTime()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1109C4C", Offset = "0x1109C4C", VA = "0x1109C4C")]
	public void OriginalTime()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1109D58", Offset = "0x1109D58", VA = "0x1109D58")]
	public void LevelComplete()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1109E28", Offset = "0x1109E28", VA = "0x1109E28")]
	public StartArena()
	{
	}
}
[Token(Token = "0x2000089")]
public class StartLevel : MonoBehaviour
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRGrabbable hvrGrabbable;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool firstGrab;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1109E38", Offset = "0x1109E38", VA = "0x1109E38")]
	public void StartLevelByBow()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1109EA8", Offset = "0x1109EA8", VA = "0x1109EA8")]
	public void NewTaskStart()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1109F60", Offset = "0x1109F60", VA = "0x1109F60")]
	public void StartNewLevel()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1109FB4", Offset = "0x1109FB4", VA = "0x1109FB4")]
	public void FastStartNewLevel()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x110A034", Offset = "0x110A034", VA = "0x110A034")]
	public StartLevel()
	{
	}
}
[Token(Token = "0x200008A")]
public class Sword : MonoBehaviour, Weapon
{
	[Token(Token = "0x1700004D")]
	public Transform transformOrigin
	{
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x110A044", Offset = "0x110A044", VA = "0x110A044", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x110A04C", Offset = "0x110A04C", VA = "0x110A04C", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x110A054", Offset = "0x110A054", VA = "0x110A054")]
	private void Start()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x110A078", Offset = "0x110A078", VA = "0x110A078")]
	public Sword()
	{
	}
}
[Token(Token = "0x200008B")]
public class TimeController : MonoBehaviour
{
	[Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class <SmoothSlowTime>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimeController <>4__this;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <index>5__2;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x110A7C4", Offset = "0x110A7C4", VA = "0x110A7C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x110A80C", Offset = "0x110A80C", VA = "0x110A80C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x110A4BC", Offset = "0x110A4BC", VA = "0x110A4BC")]
		[DebuggerHidden]
		public <SmoothSlowTime>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x110A6B0", Offset = "0x110A6B0", VA = "0x110A6B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x110A6B4", Offset = "0x110A6B4", VA = "0x110A6B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x110A7CC", Offset = "0x110A7CC", VA = "0x110A7CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <SmoothAccelerationTime>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimeController <>4__this;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <index>5__2;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x110A928", Offset = "0x110A928", VA = "0x110A928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x110A970", Offset = "0x110A970", VA = "0x110A970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x110A5E4", Offset = "0x110A5E4", VA = "0x110A5E4")]
		[DebuggerHidden]
		public <SmoothAccelerationTime>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x110A814", Offset = "0x110A814", VA = "0x110A814", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x110A818", Offset = "0x110A818", VA = "0x110A818", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x110A930", Offset = "0x110A930", VA = "0x110A930", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TimeController Instance;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly HashSet<BowControlTime> usingControllers;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve timeUp;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve timeDown;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool alternativeVariant;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool noTime;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speedScale;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float gravityScale;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float endScale;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<float> OnTimeChanged;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x110A080", Offset = "0x110A080", VA = "0x110A080")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x110A0E8", Offset = "0x110A0E8", VA = "0x110A0E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x110A18C", Offset = "0x110A18C", VA = "0x110A18C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x110A214", Offset = "0x110A214", VA = "0x110A214")]
	public void StartGame()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x110A278", Offset = "0x110A278", VA = "0x110A278")]
	public void StopGame()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x110A27C", Offset = "0x110A27C", VA = "0x110A27C")]
	public void DeathPlayer()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x110A29C", Offset = "0x110A29C", VA = "0x110A29C")]
	public void SlowTime(BowControlTime inBowControlTime)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x110A3D4", Offset = "0x110A3D4", VA = "0x110A3D4")]
	[IteratorStateMachine(typeof(<SmoothSlowTime>d__18))]
	private IEnumerator SmoothSlowTime()
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x110A4E4", Offset = "0x110A4E4", VA = "0x110A4E4")]
	public void AccelerationTime(BowControlTime inBowControlTime)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x110A448", Offset = "0x110A448", VA = "0x110A448")]
	[IteratorStateMachine(typeof(<SmoothAccelerationTime>d__20))]
	private IEnumerator SmoothAccelerationTime()
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x110A60C", Offset = "0x110A60C", VA = "0x110A60C")]
	public TimeController()
	{
	}
}
[Token(Token = "0x200008E")]
public class Timer : MonoBehaviour
{
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text timeText;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StudioEventEmitter soundFinal;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject grab;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _timerValue;

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x110A978", Offset = "0x110A978", VA = "0x110A978")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x110AB88", Offset = "0x110AB88", VA = "0x110AB88")]
	public void StopTimer()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x110ABA4", Offset = "0x110ABA4", VA = "0x110ABA4")]
	public Timer()
	{
	}
}
[Token(Token = "0x200008F")]
public class TimerArena : MonoBehaviour
{
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text timeText;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text timeFinal;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _timer;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x110ABAC", Offset = "0x110ABAC", VA = "0x110ABAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x110AED8", Offset = "0x110AED8", VA = "0x110AED8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x110AFD0", Offset = "0x110AFD0", VA = "0x110AFD0")]
	public void GameStop()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x110B074", Offset = "0x110B074", VA = "0x110B074")]
	public TimerArena()
	{
	}
}
[Token(Token = "0x2000090")]
public class TriggerAnimationEvent : MonoBehaviour
{
	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tagWeapon;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nameAction;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float hitsToTrigger;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent unityEventAnimation;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isUsed;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool _waitTimeLeft;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x110B07C", Offset = "0x110B07C", VA = "0x110B07C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x110B15C", Offset = "0x110B15C", VA = "0x110B15C")]
	public TriggerAnimationEvent()
	{
	}
}
[Token(Token = "0x2000091")]
public class EffectController : MonoBehaviour
{
	[Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class <StartTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x110B540", Offset = "0x110B540", VA = "0x110B540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x110B588", Offset = "0x110B588", VA = "0x110B588", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x110B244", Offset = "0x110B244", VA = "0x110B244")]
		[DebuggerHidden]
		public <StartTest>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x110B49C", Offset = "0x110B49C", VA = "0x110B49C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x110B4A0", Offset = "0x110B4A0", VA = "0x110B4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x110B548", Offset = "0x110B548", VA = "0x110B548", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class <TimeControlEffect>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeStart;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EffectController <>4__this;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Enemy enemy;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float timeStop;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public VisualEffect effect;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <timer>5__2;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool <eventHit>5__3;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x110BADC", Offset = "0x110BADC", VA = "0x110BADC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x110BB24", Offset = "0x110BB24", VA = "0x110BB24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x110B42C", Offset = "0x110B42C", VA = "0x110B42C")]
		[DebuggerHidden]
		public <TimeControlEffect>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x110B590", Offset = "0x110B590", VA = "0x110B590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x110B594", Offset = "0x110B594", VA = "0x110B594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x110BAE4", Offset = "0x110BAE4", VA = "0x110BAE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <TimeControlEffect>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectController <>4__this;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemySphere enemy;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VisualEffect effect;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool <eventHit>5__3;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x110BE58", Offset = "0x110BE58", VA = "0x110BE58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x110BEA0", Offset = "0x110BEA0", VA = "0x110BEA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x110B454", Offset = "0x110B454", VA = "0x110B454")]
		[DebuggerHidden]
		public <TimeControlEffect>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x110BB2C", Offset = "0x110BB2C", VA = "0x110BB2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x110BB30", Offset = "0x110BB30", VA = "0x110BB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x110BE60", Offset = "0x110BE60", VA = "0x110BE60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string nameEventStart;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nameEventStop;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float timeEventStart;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeEventStop;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startValueMaterial;

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x110B1C4", Offset = "0x110B1C4", VA = "0x110B1C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x110B1E4", Offset = "0x110B1E4", VA = "0x110B1E4")]
	[IteratorStateMachine(typeof(<StartTest>d__6))]
	private IEnumerator StartTest()
	{
		return null;
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x110B26C", Offset = "0x110B26C", VA = "0x110B26C")]
	public void OnHit(Enemy enemy, float timeStart = 0f, float timeStop = 1.5f)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x110B358", Offset = "0x110B358", VA = "0x110B358")]
	public void OnHit(EnemySphere enemy)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x110B29C", Offset = "0x110B29C", VA = "0x110B29C")]
	[IteratorStateMachine(typeof(<TimeControlEffect>d__9))]
	private IEnumerator TimeControlEffect(VisualEffect effect, Enemy enemy, float timeStart = 0f, float timeStop = 1.5f)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x110B388", Offset = "0x110B388", VA = "0x110B388")]
	[IteratorStateMachine(typeof(<TimeControlEffect>d__10))]
	private IEnumerator TimeControlEffect(VisualEffect effect, EnemySphere enemy)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x110B47C", Offset = "0x110B47C", VA = "0x110B47C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x110B480", Offset = "0x110B480", VA = "0x110B480")]
	public EffectController()
	{
	}
}
[Token(Token = "0x2000095")]
public interface Weapon
{
	[Token(Token = "0x17000058")]
	Transform transformOrigin
	{
		[Token(Token = "0x60002CC")]
		get;
		[Token(Token = "0x60002CD")]
		set;
	}
}
[Token(Token = "0x2000096")]
public class GraphicsHandler : MonoBehaviour
{
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float gameplayRenderScale;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UniversalRenderPipelineAsset pipelineAsset;

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x110BEA8", Offset = "0x110BEA8", VA = "0x110BEA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x110C09C", Offset = "0x110C09C", VA = "0x110C09C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x110BFD4", Offset = "0x110BFD4", VA = "0x110BFD4")]
	[ContextMenu("SetGameplayScale")]
	public void SetGameplayScale()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x110C0A0", Offset = "0x110C0A0", VA = "0x110C0A0")]
	public GraphicsHandler()
	{
	}
}
[Token(Token = "0x2000097")]
public class GraphicsPlayerPrefab : MonoBehaviour
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera camera;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x110C0B4", Offset = "0x110C0B4", VA = "0x110C0B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x110C0DC", Offset = "0x110C0DC", VA = "0x110C0DC")]
	public GraphicsPlayerPrefab()
	{
	}
}
[Token(Token = "0x2000098")]
public class GraphicsSceneHandler : MonoBehaviour
{
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GraphicsSceneHandlerSettings settingsPico;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x110C0E4", Offset = "0x110C0E4", VA = "0x110C0E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x110C170", Offset = "0x110C170", VA = "0x110C170")]
	public GraphicsSceneHandler()
	{
	}
}
[Serializable]
[Token(Token = "0x2000099")]
public class GraphicsSceneHandlerSettings
{
	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("Fog")]
	public bool fogEnabled;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public FogMode fogMode;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Fog/Linear")]
	public float fogLinearStart;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fogLinearEnd;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Fog/ExponentialSquared")]
	public float fogExponentialSquaredDensity;

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x110C178", Offset = "0x110C178", VA = "0x110C178")]
	public GraphicsSceneHandlerSettings()
	{
	}
}
[Token(Token = "0x200009A")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x17000059")]
	public static bool Initialized
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x110C180", Offset = "0x110C180", VA = "0x110C180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x110C188", Offset = "0x110C188", VA = "0x110C188")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x200009B")]
public class FMOD_Anim_Rdna : MonoBehaviour
{
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Projectile projectile;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StudioEventEmitter studioEventEmitter;

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x110C190", Offset = "0x110C190", VA = "0x110C190")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x110C1E8", Offset = "0x110C1E8", VA = "0x110C1E8")]
	public void PlaySound(string track)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x110C21C", Offset = "0x110C21C", VA = "0x110C21C")]
	public FMOD_Anim_Rdna()
	{
	}
}
[Token(Token = "0x200009C")]
public class HVRRigidBodyOverrides_EDIT : HVRRigidBodyOverrides
{
	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("EDIT")]
	public Vector3 inertiaTensorAwake;

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x110C224", Offset = "0x110C224", VA = "0x110C224", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x110C260", Offset = "0x110C260", VA = "0x110C260")]
	public void RevertOverrides()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x110C298", Offset = "0x110C298", VA = "0x110C298")]
	public HVRRigidBodyOverrides_EDIT()
	{
	}
}
[Token(Token = "0x200009D")]
public class Joint_RTEdit_Bow_RDNA : MonoBehaviour
{
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("External Links")]
	public HVRJointSettings defaultJointSettings;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HVRJointSettings newJointSettings;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("AutoLinks")]
	public ConfigurableJoint joint;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PlayerBow playerBow;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Settings")]
	public float thresholdToChangeJointSettings;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Header("States")]
	public bool state;

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x110C2A0", Offset = "0x110C2A0", VA = "0x110C2A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x110C460", Offset = "0x110C460", VA = "0x110C460")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x110C5C8", Offset = "0x110C5C8", VA = "0x110C5C8")]
	private void CustomUpdate(float inValue)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x110C700", Offset = "0x110C700", VA = "0x110C700")]
	public void SetJoint(HVRGrabberBase grabber, HVRGrabbable inGrabbable)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x110C67C", Offset = "0x110C67C", VA = "0x110C67C")]
	public void ApplyJointSettings()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x110C5F8", Offset = "0x110C5F8", VA = "0x110C5F8")]
	public void RevertJointSettings()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x110C78C", Offset = "0x110C78C", VA = "0x110C78C")]
	public Joint_RTEdit_Bow_RDNA()
	{
	}
}
[Token(Token = "0x200009E")]
public class MusicPlayerV1 : MonoBehaviour
{
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MusicPlayerV1 Instance;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x110C794", Offset = "0x110C794", VA = "0x110C794")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x110C7EC", Offset = "0x110C7EC", VA = "0x110C7EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x110C8D4", Offset = "0x110C8D4", VA = "0x110C8D4")]
	public void StopMusic()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x110C9BC", Offset = "0x110C9BC", VA = "0x110C9BC")]
	public MusicPlayerV1()
	{
	}
}
[Token(Token = "0x200009F")]
public static class PICO_HAPTICS
{
}
[Token(Token = "0x20000A0")]
public class RDNA_Arrow : MonoBehaviour
{
	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StudioEventEmitter arrowSound;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float time;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 vector;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timer;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string tagPlayer;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x110C9C4", Offset = "0x110C9C4", VA = "0x110C9C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x110CA6C", Offset = "0x110CA6C", VA = "0x110CA6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x110CA70", Offset = "0x110CA70", VA = "0x110CA70")]
	private void Update()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x110CAD8", Offset = "0x110CAD8", VA = "0x110CAD8")]
	public RDNA_Arrow()
	{
	}
}
[Token(Token = "0x20000A1")]
public class Rdna_arrow2 : MonoBehaviour
{
	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Control")]
	public bool launch;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("Settings")]
	public float speed;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravity;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Links")]
	public Rigidbody mRigidbody;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform spawnPoint;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("States")]
	public bool flying;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x110CAE0", Offset = "0x110CAE0", VA = "0x110CAE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x110CC2C", Offset = "0x110CC2C", VA = "0x110CC2C")]
	private void Launch()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x110CD40", Offset = "0x110CD40", VA = "0x110CD40")]
	private void ApplyGravity()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x110CD9C", Offset = "0x110CD9C", VA = "0x110CD9C")]
	public Rdna_arrow2()
	{
	}
}
[Token(Token = "0x20000A2")]
public class RDNA_bow : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	private enum BowSoundState
	{
		[Token(Token = "0x4000321")]
		Off,
		[Token(Token = "0x4000322")]
		Pulling,
		[Token(Token = "0x4000323")]
		Loosening
	}

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Links")]
	public StudioEventEmitter emitterPulling;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StudioEventEmitter emitterLoosening;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public StudioEventEmitter emitterPullingDone;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public StudioEventEmitter emitterNockFlewOff;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public StudioEventEmitter emitterShot;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("States")]
	[SerializeField]
	private BowSoundState mBowSoundState;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float timerDelta;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool inputThisFrame;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float prevInput;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float deltaInput;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool prevDropped;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool active;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Settings")]
	public Vector2 boundsSoundParameterSpeed;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 boundsDeltaInput;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float timeToProcessDelta;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Header("Hurricane Settings")]
	public int countSymbolsRoundOnZero;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int countSymbolsRoundOnMiddle;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int countSymbolsRoundOnOne;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float toleranceInput;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("Test")]
	public Transform arrowPrefab;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform spawnArrow;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool debug;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool debugShot;

	[Token(Token = "0x1700005A")]
	private BowSoundState PBowSoundState
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x110CDA4", Offset = "0x110CDA4", VA = "0x110CDA4")]
		get
		{
			return default(BowSoundState);
		}
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x110CDAC", Offset = "0x110CDAC", VA = "0x110CDAC")]
		set
		{
		}
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x110CE74", Offset = "0x110CE74", VA = "0x110CE74")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x110466C", Offset = "0x110466C", VA = "0x110466C")]
	public void InputPullingProgress(float value, bool isDropped)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x11040BC", Offset = "0x11040BC", VA = "0x11040BC")]
	public void OnShot()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x110CFB8", Offset = "0x110CFB8", VA = "0x110CFB8")]
	private void ProcessDelta()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x110D038", Offset = "0x110D038", VA = "0x110D038")]
	private void ResetDelta()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x110D040", Offset = "0x110D040", VA = "0x110D040")]
	private void ResetInput()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x110D010", Offset = "0x110D010", VA = "0x110D010")]
	private void ProcessSound()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x110D050", Offset = "0x110D050", VA = "0x110D050")]
	private void ProcessSoundPulling()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x110D0D8", Offset = "0x110D0D8", VA = "0x110D0D8")]
	private void ProcessSoundLoosening()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x110D164", Offset = "0x110D164", VA = "0x110D164")]
	public RDNA_bow()
	{
	}
}
[Token(Token = "0x20000A4")]
[RequireComponent(typeof(TrailRenderer))]
public class RDNA_TrailRendererTimeScaler : MonoBehaviour
{
	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 timeBounds;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TrailRenderer trailRenderer;

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x110D19C", Offset = "0x110D19C", VA = "0x110D19C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x110D1E8", Offset = "0x110D1E8", VA = "0x110D1E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x110D360", Offset = "0x110D360", VA = "0x110D360")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x110D4D8", Offset = "0x110D4D8", VA = "0x110D4D8")]
	private void ChangeTrail(float time)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x110D51C", Offset = "0x110D51C", VA = "0x110D51C")]
	public RDNA_TrailRendererTimeScaler()
	{
	}
}
[Token(Token = "0x20000A5")]
public class ThrowGrabbable : MonoBehaviour
{
	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("AutoLinks")]
	public Rigidbody mRigidbody;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Projectile projectile;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Settings")]
	public float impulseMultiplier;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 angularVelocityThrow;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float autoPilotDistance;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LayerMask layerMaskEnemy;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool customRotation;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[Header("States")]
	public bool isUpdates;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool throwing;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 lastPos;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 throwVelocity;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 throwAngularVelocity;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform _lashHand;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isThrow;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x110D524", Offset = "0x110D524", VA = "0x110D524")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x110D59C", Offset = "0x110D59C", VA = "0x110D59C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x110DB68", Offset = "0x110DB68", VA = "0x110DB68")]
	public void OnGrabbed()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x110DC04", Offset = "0x110DC04", VA = "0x110DC04")]
	public void OnHover()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x110DD00", Offset = "0x110DD00", VA = "0x110DD00")]
	public void Throw()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x110D718", Offset = "0x110D718", VA = "0x110D718")]
	private void ThrowInternal()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x110DD28", Offset = "0x110DD28", VA = "0x110DD28")]
	private void AutoShoot(Vector3 position, Vector3 velocity)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x110DF5C", Offset = "0x110DF5C", VA = "0x110DF5C")]
	public ThrowGrabbable()
	{
	}
}
[Token(Token = "0x20000A6")]
public class TranslatorNext : MonoBehaviour
{
	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isValidate;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool exploded;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent eventOnGrab;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent preEventOnGrab;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float delay;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<TranslatorFragment> translatorFragments;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool readinessRight;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool readinessLeft;

	[Token(Token = "0x400033C")]
	private const string RightHandName = "TranslatorTriggerRight";

	[Token(Token = "0x400033D")]
	private const string LeftHandName = "TranslatorTriggerLeft";

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x110DF74", Offset = "0x110DF74", VA = "0x110DF74")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x110E190", Offset = "0x110E190", VA = "0x110E190")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x110E238", Offset = "0x110E238", VA = "0x110E238")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x110E2D8", Offset = "0x110E2D8", VA = "0x110E2D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x110E3A8", Offset = "0x110E3A8", VA = "0x110E3A8")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x110E5EC", Offset = "0x110E5EC", VA = "0x110E5EC")]
	private void ExecuteEvent()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x110E66C", Offset = "0x110E66C", VA = "0x110E66C")]
	public TranslatorNext()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A7")]
public class TranslatorFragment
{
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rigidbody rigidbody;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider collider;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x110E574", Offset = "0x110E574", VA = "0x110E574")]
	public void Explode(Vector3 pos)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x110E188", Offset = "0x110E188", VA = "0x110E188")]
	public TranslatorFragment()
	{
	}
}
[Token(Token = "0x20000A8")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x110E67C", Offset = "0x110E67C", VA = "0x110E67C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x110E724", Offset = "0x110E724", VA = "0x110E724")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x110E7CC", Offset = "0x110E7CC", VA = "0x110E7CC")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x110EC74", Offset = "0x110EC74", VA = "0x110EC74")]
	public ChatController()
	{
	}
}
[Token(Token = "0x20000A9")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x110EC7C", Offset = "0x110EC7C", VA = "0x110EC7C")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x110ED84", Offset = "0x110ED84", VA = "0x110ED84")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x20000AA")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x110F0CC", Offset = "0x110F0CC", VA = "0x110F0CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x110F114", Offset = "0x110F114", VA = "0x110F114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x110EE88", Offset = "0x110EE88", VA = "0x110EE88")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x110EEB8", Offset = "0x110EEB8", VA = "0x110EEB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x110EEBC", Offset = "0x110EEBC", VA = "0x110EEBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x110F0D4", Offset = "0x110F0D4", VA = "0x110F0D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x110ED8C", Offset = "0x110ED8C", VA = "0x110ED8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x110EE14", Offset = "0x110EE14", VA = "0x110EE14")]
	[IteratorStateMachine(typeof(<Start>d__4))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x110EEB0", Offset = "0x110EEB0", VA = "0x110EEB0")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x20000AC")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class Section
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x110F124", Offset = "0x110F124", VA = "0x110F124")]
		public Section()
		{
		}
	}

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x110F11C", Offset = "0x110F11C", VA = "0x110F11C")]
	public Readme()
	{
	}
}
[Token(Token = "0x20000AE")]
public class ResetPosition : MonoBehaviour
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float distanceToReset;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 startPosition;

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x110F12C", Offset = "0x110F12C", VA = "0x110F12C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x110F15C", Offset = "0x110F15C", VA = "0x110F15C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x110F254", Offset = "0x110F254", VA = "0x110F254")]
	public ResetPosition()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x110F264", Offset = "0x110F264", VA = "0x110F264", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x110F2E4", Offset = "0x110F2E4", VA = "0x110F2E4")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x110F2EC", Offset = "0x110F2EC", VA = "0x110F2EC", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x110F760", Offset = "0x110F760", VA = "0x110F760")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x11101A4", Offset = "0x11101A4", VA = "0x11101A4")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x11101EC", Offset = "0x11101EC", VA = "0x11101EC")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1110234", Offset = "0x1110234", VA = "0x1110234")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x111027C", Offset = "0x111027C", VA = "0x111027C")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x11102C4", Offset = "0x11102C4", VA = "0x11102C4")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x1700005D")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x110F768", Offset = "0x110F768", VA = "0x110F768")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x110F770", Offset = "0x110F770", VA = "0x110F770")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x110F778", Offset = "0x110F778", VA = "0x110F778")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x110F780", Offset = "0x110F780", VA = "0x110F780")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x110F788", Offset = "0x110F788", VA = "0x110F788")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x110F790", Offset = "0x110F790", VA = "0x110F790")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x110F798", Offset = "0x110F798", VA = "0x110F798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x110F7A0", Offset = "0x110F7A0", VA = "0x110F7A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x110F7A8", Offset = "0x110F7A8", VA = "0x110F7A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x110F7B0", Offset = "0x110F7B0", VA = "0x110F7B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x110F7B8", Offset = "0x110F7B8", VA = "0x110F7B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x110F970", Offset = "0x110F970", VA = "0x110F970")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1110044", Offset = "0x1110044", VA = "0x1110044", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1110048", Offset = "0x1110048", VA = "0x1110048", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x110FDE8", Offset = "0x110FDE8", VA = "0x110FDE8")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x110FE5C", Offset = "0x110FE5C", VA = "0x110FE5C")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x110FED0", Offset = "0x110FED0", VA = "0x110FED0")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x110FF4C", Offset = "0x110FF4C", VA = "0x110FF4C")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x110FFC8", Offset = "0x110FFC8", VA = "0x110FFC8")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x111004C", Offset = "0x111004C", VA = "0x111004C")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x20000B7")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034A")]
				[Address(RVA = "0x1110964", Offset = "0x1110964", VA = "0x1110964", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034C")]
				[Address(RVA = "0x11109AC", Offset = "0x11109AC", VA = "0x11109AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1110380", Offset = "0x1110380", VA = "0x1110380")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x11103B0", Offset = "0x11103B0", VA = "0x11103B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x11103B4", Offset = "0x11103B4", VA = "0x11103B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x111096C", Offset = "0x111096C", VA = "0x111096C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000369")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x400036A")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x111030C", Offset = "0x111030C", VA = "0x111030C")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x11103A8", Offset = "0x11103A8", VA = "0x11103A8")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x1110EF0", Offset = "0x1110EF0", VA = "0x1110EF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x1110F38", Offset = "0x1110F38", VA = "0x1110F38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1110A28", Offset = "0x1110A28", VA = "0x1110A28")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1110A58", Offset = "0x1110A58", VA = "0x1110A58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1110A5C", Offset = "0x1110A5C", VA = "0x1110A5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1110EF8", Offset = "0x1110EF8", VA = "0x1110EF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x4000377")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x4000378")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x11109B4", Offset = "0x11109B4", VA = "0x11109B4")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1110A50", Offset = "0x1110A50", VA = "0x1110A50")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1110F40", Offset = "0x1110F40", VA = "0x1110F40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1111540", Offset = "0x1111540", VA = "0x1111540")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x20000BD")]
		public enum BenchmarkType
		{
			[Token(Token = "0x4000387")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x4000388")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x4000389")]
			TMP_SDF,
			[Token(Token = "0x400038A")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x400038B")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1111550", Offset = "0x1111550", VA = "0x1111550")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1111554", Offset = "0x1111554", VA = "0x1111554")]
		private void Start()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1111990", Offset = "0x1111990", VA = "0x1111990")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x11119A0", Offset = "0x11119A0", VA = "0x11119A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1111CA8", Offset = "0x1111CA8", VA = "0x1111CA8")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x20000C0")]
		public enum CameraModes
		{
			[Token(Token = "0x40003AB")]
			Follow,
			[Token(Token = "0x40003AC")]
			Isometric,
			[Token(Token = "0x40003AD")]
			Free
		}

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x40003A8")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x40003A9")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1111CC4", Offset = "0x1111CC4", VA = "0x1111CC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1111D40", Offset = "0x1111D40", VA = "0x1111D40")]
		private void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1111E34", Offset = "0x1111E34", VA = "0x1111E34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1112168", Offset = "0x1112168", VA = "0x1112168")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1112990", Offset = "0x1112990", VA = "0x1112990")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x20000C2")]
		public enum MotionType
		{
			[Token(Token = "0x40003B9")]
			Rotation,
			[Token(Token = "0x40003BA")]
			BackAndForth,
			[Token(Token = "0x40003BB")]
			Translation
		}

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1112A1C", Offset = "0x1112A1C", VA = "0x1112A1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1112E04", Offset = "0x1112E04", VA = "0x1112E04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1112F4C", Offset = "0x1112F4C", VA = "0x1112F4C")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x111320C", Offset = "0x111320C", VA = "0x111320C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x1113254", Offset = "0x1113254", VA = "0x1113254", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1113074", Offset = "0x1113074", VA = "0x1113074")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x11130A4", Offset = "0x11130A4", VA = "0x11130A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x11130A8", Offset = "0x11130A8", VA = "0x11130A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1113214", Offset = "0x1113214", VA = "0x1113214", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1112F60", Offset = "0x1112F60", VA = "0x1112F60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1112FE0", Offset = "0x1112FE0", VA = "0x1112FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1113000", Offset = "0x1113000", VA = "0x1113000")]
		[IteratorStateMachine(typeof(<AnimateProperties>d__6))]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x111309C", Offset = "0x111309C", VA = "0x111309C")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40003C4")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x111325C", Offset = "0x111325C", VA = "0x111325C")]
		private void Start()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1113320", Offset = "0x1113320", VA = "0x1113320")]
		private void Update()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x11133AC", Offset = "0x11133AC", VA = "0x11133AC")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x17000068")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x11140CC", Offset = "0x11140CC", VA = "0x11140CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x1114114", Offset = "0x1114114", VA = "0x1114114", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1113530", Offset = "0x1113530", VA = "0x1113530")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x1113794", Offset = "0x1113794", VA = "0x1113794", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1113798", Offset = "0x1113798", VA = "0x1113798", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x11140D4", Offset = "0x11140D4", VA = "0x11140D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x11133B4", Offset = "0x11133B4", VA = "0x11133B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x111341C", Offset = "0x111341C", VA = "0x111341C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x11134B0", Offset = "0x11134B0", VA = "0x11134B0")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x111343C", Offset = "0x111343C", VA = "0x111343C")]
		[IteratorStateMachine(typeof(<WarpText>d__7))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1113558", Offset = "0x1113558", VA = "0x1113558")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x111450C", Offset = "0x111450C", VA = "0x111450C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000384")]
				[Address(RVA = "0x1114554", Offset = "0x1114554", VA = "0x1114554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1114234", Offset = "0x1114234", VA = "0x1114234")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x11142E0", Offset = "0x11142E0", VA = "0x11142E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x11142E4", Offset = "0x11142E4", VA = "0x11142E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1114514", Offset = "0x1114514", VA = "0x1114514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x111411C", Offset = "0x111411C", VA = "0x111411C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x11141C0", Offset = "0x11141C0", VA = "0x11141C0")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x111425C", Offset = "0x111425C", VA = "0x111425C")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x1114A6C", Offset = "0x1114A6C", VA = "0x1114A6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x1114AB4", Offset = "0x1114AB4", VA = "0x1114AB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x111481C", Offset = "0x111481C", VA = "0x111481C")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x11148E8", Offset = "0x11148E8", VA = "0x11148E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x11148EC", Offset = "0x11148EC", VA = "0x11148EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1114A74", Offset = "0x1114A74", VA = "0x1114A74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x1114C94", Offset = "0x1114C94", VA = "0x1114C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x1114CDC", Offset = "0x1114CDC", VA = "0x1114CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x11148B8", Offset = "0x11148B8", VA = "0x11148B8")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1114ABC", Offset = "0x1114ABC", VA = "0x1114ABC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1114AC0", Offset = "0x1114AC0", VA = "0x1114AC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1114C9C", Offset = "0x1114C9C", VA = "0x1114C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x111455C", Offset = "0x111455C", VA = "0x111455C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x11145C4", Offset = "0x11145C4", VA = "0x11145C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1114678", Offset = "0x1114678", VA = "0x1114678")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1114744", Offset = "0x1114744", VA = "0x1114744")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1114810", Offset = "0x1114810", VA = "0x1114810")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x11145E8", Offset = "0x11145E8", VA = "0x11145E8")]
		[IteratorStateMachine(typeof(<RevealCharacters>d__7))]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1114844", Offset = "0x1114844", VA = "0x1114844")]
		[IteratorStateMachine(typeof(<RevealWords>d__8))]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x11148E0", Offset = "0x11148E0", VA = "0x11148E0")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x10F25B8", Offset = "0x10F25B8", VA = "0x10F25B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x10F2600", Offset = "0x10F2600", VA = "0x10F2600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x10F1E98", Offset = "0x10F1E98", VA = "0x10F1E98")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x10F1EC0", Offset = "0x10F1EC0", VA = "0x10F1EC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x10F1EC4", Offset = "0x10F1EC4", VA = "0x10F1EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x10F25C0", Offset = "0x10F25C0", VA = "0x10F25C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x10F2D10", Offset = "0x10F2D10", VA = "0x10F2D10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x10F2D58", Offset = "0x10F2D58", VA = "0x10F2D58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x10F2608", Offset = "0x10F2608", VA = "0x10F2608")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x10F2630", Offset = "0x10F2630", VA = "0x10F2630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x10F2634", Offset = "0x10F2634", VA = "0x10F2634", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x10F2D18", Offset = "0x10F2D18", VA = "0x10F2D18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1114CE4", Offset = "0x1114CE4", VA = "0x1114CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1114DCC", Offset = "0x1114DCC", VA = "0x1114DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x11151E8", Offset = "0x11151E8", VA = "0x11151E8")]
		[IteratorStateMachine(typeof(<DisplayTextMeshProFloatingText>d__15))]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x111525C", Offset = "0x111525C", VA = "0x111525C")]
		[IteratorStateMachine(typeof(<DisplayTextMeshFloatingText>d__16))]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x11152D0", Offset = "0x11152D0", VA = "0x11152D0")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10F2D60", Offset = "0x10F2D60", VA = "0x10F2D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x10F2D64", Offset = "0x10F2D64", VA = "0x10F2D64")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x10F3064", Offset = "0x10F3064", VA = "0x10F3064")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000414")]
			TopLeft,
			[Token(Token = "0x4000415")]
			BottomLeft,
			[Token(Token = "0x4000416")]
			TopRight,
			[Token(Token = "0x4000417")]
			BottomRight
		}

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x400040E")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x10F3074", Offset = "0x10F3074", VA = "0x10F3074")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x10F332C", Offset = "0x10F332C", VA = "0x10F332C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x10F3440", Offset = "0x10F3440", VA = "0x10F3440")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		public enum objectType
		{
			[Token(Token = "0x400041E")]
			TextMeshPro,
			[Token(Token = "0x400041F")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x400041B")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10F3450", Offset = "0x10F3450", VA = "0x10F3450")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x10F3674", Offset = "0x10F3674", VA = "0x10F3674")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x10F3708", Offset = "0x10F3708", VA = "0x10F3708")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x20000D6")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400042B")]
			TopLeft,
			[Token(Token = "0x400042C")]
			BottomLeft,
			[Token(Token = "0x400042D")]
			TopRight,
			[Token(Token = "0x400042E")]
			BottomRight
		}

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000425")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x10F3710", Offset = "0x10F3710", VA = "0x10F3710")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x10F3B48", Offset = "0x10F3B48", VA = "0x10F3B48")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x10F3B68", Offset = "0x10F3B68", VA = "0x10F3B68")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x10F396C", Offset = "0x10F396C", VA = "0x10F396C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x10F3CBC", Offset = "0x10F3CBC", VA = "0x10F3CBC")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x10F3CD4", Offset = "0x10F3CD4", VA = "0x10F3CD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x10F3FA8", Offset = "0x10F3FA8", VA = "0x10F3FA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x10F4244", Offset = "0x10F4244", VA = "0x10F4244")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x10F4494", Offset = "0x10F4494", VA = "0x10F4494")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x10F46E4", Offset = "0x10F46E4", VA = "0x10F46E4")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x10F49C4", Offset = "0x10F49C4", VA = "0x10F49C4")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x10F4CA4", Offset = "0x10F4CA4", VA = "0x10F4CA4")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10F4FD8", Offset = "0x10F4FD8", VA = "0x10F4FD8")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x10F4FE0", Offset = "0x10F4FE0", VA = "0x10F4FE0")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x10F4FE8", Offset = "0x10F4FE8", VA = "0x10F4FE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x10F508C", Offset = "0x10F508C", VA = "0x10F508C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x10F5730", Offset = "0x10F5730", VA = "0x10F5730", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x10F57A8", Offset = "0x10F57A8", VA = "0x10F57A8", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x10F581C", Offset = "0x10F581C", VA = "0x10F581C")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x400043A")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x400043B")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x10F5834", Offset = "0x10F5834", VA = "0x10F5834")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x10F59FC", Offset = "0x10F59FC", VA = "0x10F59FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x10F5AC8", Offset = "0x10F5AC8", VA = "0x10F5AC8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x10F5B94", Offset = "0x10F5B94", VA = "0x10F5B94")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x10F5C40", Offset = "0x10F5C40", VA = "0x10F5C40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x10F7114", Offset = "0x10F7114", VA = "0x10F7114", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x10F7120", Offset = "0x10F7120", VA = "0x10F7120", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x10F7128", Offset = "0x10F7128", VA = "0x10F7128", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x10F712C", Offset = "0x10F712C", VA = "0x10F712C", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x10F6890", Offset = "0x10F6890", VA = "0x10F6890")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x10F7130", Offset = "0x10F7130", VA = "0x10F7130")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x20000DC")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400044F")]
			TopLeft,
			[Token(Token = "0x4000450")]
			BottomLeft,
			[Token(Token = "0x4000451")]
			TopRight,
			[Token(Token = "0x4000452")]
			BottomRight
		}

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x400044A")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x10F7148", Offset = "0x10F7148", VA = "0x10F7148")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x10F75A4", Offset = "0x10F75A4", VA = "0x10F75A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x10F75C4", Offset = "0x10F75C4", VA = "0x10F75C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x10F736C", Offset = "0x10F736C", VA = "0x10F736C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x10F7718", Offset = "0x10F7718", VA = "0x10F7718")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x10F7B94", Offset = "0x10F7B94", VA = "0x10F7B94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0x10F7BDC", Offset = "0x10F7BDC", VA = "0x10F7BDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x10F781C", Offset = "0x10F781C", VA = "0x10F781C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x10F784C", Offset = "0x10F784C", VA = "0x10F784C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x10F7850", Offset = "0x10F7850", VA = "0x10F7850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x10F7B9C", Offset = "0x10F7B9C", VA = "0x10F7B9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10F7730", Offset = "0x10F7730", VA = "0x10F7730")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x10F7788", Offset = "0x10F7788", VA = "0x10F7788")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x10F77A8", Offset = "0x10F77A8", VA = "0x10F77A8")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__3))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x10F7844", Offset = "0x10F7844", VA = "0x10F7844")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		private struct VertexAnim
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003EB")]
				[Address(RVA = "0x10F8844", Offset = "0x10F8844", VA = "0x10F8844", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003ED")]
				[Address(RVA = "0x10F888C", Offset = "0x10F888C", VA = "0x10F888C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x10F7EE4", Offset = "0x10F7EE4", VA = "0x10F7EE4")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x10F7F24", Offset = "0x10F7F24", VA = "0x10F7F24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x10F7F28", Offset = "0x10F7F28", VA = "0x10F7F28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x10F884C", Offset = "0x10F884C", VA = "0x10F884C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x10F7BE4", Offset = "0x10F7BE4", VA = "0x10F7BE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x10F7C3C", Offset = "0x10F7C3C", VA = "0x10F7C3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x10F7D08", Offset = "0x10F7D08", VA = "0x10F7D08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x10F7DD4", Offset = "0x10F7DD4", VA = "0x10F7DD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x10F7E68", Offset = "0x10F7E68", VA = "0x10F7E68")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x10F7DF4", Offset = "0x10F7DF4", VA = "0x10F7DF4")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10F7F0C", Offset = "0x10F7F0C", VA = "0x10F7F0C")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x10F95F8", Offset = "0x10F95F8", VA = "0x10F95F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0x10F9640", Offset = "0x10F9640", VA = "0x10F9640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x10F8B84", Offset = "0x10F8B84", VA = "0x10F8B84")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x10F8BBC", Offset = "0x10F8BBC", VA = "0x10F8BBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x10F8BC0", Offset = "0x10F8BC0", VA = "0x10F8BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x10F9600", Offset = "0x10F9600", VA = "0x10F9600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x10F8894", Offset = "0x10F8894", VA = "0x10F8894")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x10F88EC", Offset = "0x10F88EC", VA = "0x10F88EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x10F89B8", Offset = "0x10F89B8", VA = "0x10F89B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x10F8A84", Offset = "0x10F8A84", VA = "0x10F8A84")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x10F8B18", Offset = "0x10F8B18", VA = "0x10F8B18")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x10F8AA4", Offset = "0x10F8AA4", VA = "0x10F8AA4")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x10F8BAC", Offset = "0x10F8BAC", VA = "0x10F8BAC")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x10FA89C", Offset = "0x10FA89C", VA = "0x10FA89C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x10FA8E4", Offset = "0x10FA8E4", VA = "0x10FA8E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x10F9938", Offset = "0x10F9938", VA = "0x10F9938")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x10F9978", Offset = "0x10F9978", VA = "0x10F9978", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x10F997C", Offset = "0x10F997C", VA = "0x10F997C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x10FA8A4", Offset = "0x10FA8A4", VA = "0x10FA8A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10F9648", Offset = "0x10F9648", VA = "0x10F9648")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x10F96A0", Offset = "0x10F96A0", VA = "0x10F96A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x10F976C", Offset = "0x10F976C", VA = "0x10F976C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x10F9838", Offset = "0x10F9838", VA = "0x10F9838")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x10F98CC", Offset = "0x10F98CC", VA = "0x10F98CC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x10F9858", Offset = "0x10F9858", VA = "0x10F9858")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x10F9960", Offset = "0x10F9960", VA = "0x10F9960")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x10FAC2C", Offset = "0x10FAC2C", VA = "0x10FAC2C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x10FAC34", Offset = "0x10FAC34", VA = "0x10FAC34")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000414")]
				[Address(RVA = "0x10FB95C", Offset = "0x10FB95C", VA = "0x10FB95C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x10FB9A4", Offset = "0x10FB9A4", VA = "0x10FB9A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x10FABEC", Offset = "0x10FABEC", VA = "0x10FABEC")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x10FACC4", Offset = "0x10FACC4", VA = "0x10FACC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x10FACC8", Offset = "0x10FACC8", VA = "0x10FACC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x10FB964", Offset = "0x10FB964", VA = "0x10FB964", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10FA8EC", Offset = "0x10FA8EC", VA = "0x10FA8EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10FA944", Offset = "0x10FA944", VA = "0x10FA944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10FAA10", Offset = "0x10FAA10", VA = "0x10FAA10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10FAADC", Offset = "0x10FAADC", VA = "0x10FAADC")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10FAB70", Offset = "0x10FAB70", VA = "0x10FAB70")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10FAAFC", Offset = "0x10FAAFC", VA = "0x10FAAFC")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10FAC14", Offset = "0x10FAC14", VA = "0x10FAC14")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x10FC604", Offset = "0x10FC604", VA = "0x10FC604", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x10FC64C", Offset = "0x10FC64C", VA = "0x10FC64C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x10FBB28", Offset = "0x10FBB28", VA = "0x10FBB28")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x10FBD94", Offset = "0x10FBD94", VA = "0x10FBD94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x10FBD98", Offset = "0x10FBD98", VA = "0x10FBD98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x10FC60C", Offset = "0x10FC60C", VA = "0x10FC60C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10FB9AC", Offset = "0x10FB9AC", VA = "0x10FB9AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10FBA14", Offset = "0x10FBA14", VA = "0x10FBA14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10FBAA8", Offset = "0x10FBAA8", VA = "0x10FBAA8")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10FBA34", Offset = "0x10FBA34", VA = "0x10FBA34")]
		[IteratorStateMachine(typeof(<WarpText>d__8))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x10FBB50", Offset = "0x10FBB50", VA = "0x10FBB50")]
		public WarpTextExample()
		{
		}
	}
}
namespace UnityEngine.VFX.Utility
{
	[Token(Token = "0x20000EB")]
	[VFXBinder("Transform/MyPosition")]
	[AddComponentMenu("VFX/Property Binders/Position Binder")]
	internal class MyVFXPositionBinder : VFXBinderBase
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position", "UnityEngine.Vector3" })]
		protected ExposedProperty m_Property;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x17000080")]
		public string Property
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x10FC654", Offset = "0x10FC654", VA = "0x10FC654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x10FC670", Offset = "0x10FC670", VA = "0x10FC670")]
			set
			{
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10FC698", Offset = "0x10FC698", VA = "0x10FC698", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10FC740", Offset = "0x10FC740", VA = "0x10FC740", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10FC7A0", Offset = "0x10FC7A0", VA = "0x10FC7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10FC868", Offset = "0x10FC868", VA = "0x10FC868")]
		public MyVFXPositionBinder()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[VFXBinder("Transform/MyVFXTransformBinder")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	internal class MyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000081")]
		public string Property
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x10FC8CC", Offset = "0x10FC8CC", VA = "0x10FC8CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x10FC8E8", Offset = "0x10FC8E8", VA = "0x10FC8E8")]
			set
			{
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10FCA14", Offset = "0x10FCA14", VA = "0x10FCA14", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10FCA30", Offset = "0x10FCA30", VA = "0x10FCA30")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x10FC918", Offset = "0x10FC918", VA = "0x10FC918")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10FCA34", Offset = "0x10FCA34", VA = "0x10FCA34", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10FCB1C", Offset = "0x10FCB1C", VA = "0x10FCB1C", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x10FCBD8", Offset = "0x10FCBD8", VA = "0x10FCBD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10FCCA0", Offset = "0x10FCCA0", VA = "0x10FCCA0")]
		public MyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/ArmLeftMyVFXTransformBinder")]
	internal class ArmLeftMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000082")]
		public string Property
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x10FCD04", Offset = "0x10FCD04", VA = "0x10FCD04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x10FCD20", Offset = "0x10FCD20", VA = "0x10FCD20")]
			set
			{
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x10FCE4C", Offset = "0x10FCE4C", VA = "0x10FCE4C", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x10FCE68", Offset = "0x10FCE68", VA = "0x10FCE68")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10FCD50", Offset = "0x10FCD50", VA = "0x10FCD50")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x10FCE6C", Offset = "0x10FCE6C", VA = "0x10FCE6C", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x10FCF54", Offset = "0x10FCF54", VA = "0x10FCF54", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x10FD010", Offset = "0x10FD010", VA = "0x10FD010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x10FD0D8", Offset = "0x10FD0D8", VA = "0x10FD0D8")]
		public ArmLeftMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/ArmRightMyVFXTransformBinder")]
	internal class ArmRightMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000083")]
		public string Property
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x10FD13C", Offset = "0x10FD13C", VA = "0x10FD13C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x10FD158", Offset = "0x10FD158", VA = "0x10FD158")]
			set
			{
			}
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x10FD284", Offset = "0x10FD284", VA = "0x10FD284", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x10FD2A0", Offset = "0x10FD2A0", VA = "0x10FD2A0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x10FD188", Offset = "0x10FD188", VA = "0x10FD188")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x10FD2A4", Offset = "0x10FD2A4", VA = "0x10FD2A4", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x10FD38C", Offset = "0x10FD38C", VA = "0x10FD38C", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x10FD448", Offset = "0x10FD448", VA = "0x10FD448", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x10FD510", Offset = "0x10FD510", VA = "0x10FD510")]
		public ArmRightMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/BodyMyVFXTransformBinder")]
	internal class BodyMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000084")]
		public string Property
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x10FD574", Offset = "0x10FD574", VA = "0x10FD574")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x10FD590", Offset = "0x10FD590", VA = "0x10FD590")]
			set
			{
			}
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x10FD6BC", Offset = "0x10FD6BC", VA = "0x10FD6BC", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x10FD6D8", Offset = "0x10FD6D8", VA = "0x10FD6D8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x10FD5C0", Offset = "0x10FD5C0", VA = "0x10FD5C0")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x10FD6DC", Offset = "0x10FD6DC", VA = "0x10FD6DC", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x10FD7C4", Offset = "0x10FD7C4", VA = "0x10FD7C4", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x10FD880", Offset = "0x10FD880", VA = "0x10FD880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x10FD948", Offset = "0x10FD948", VA = "0x10FD948")]
		public BodyMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/ForeArmLeftMyVFXTransformBinder")]
	internal class ForeArmLeftMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000085")]
		public string Property
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x10FD9AC", Offset = "0x10FD9AC", VA = "0x10FD9AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x10FD9C8", Offset = "0x10FD9C8", VA = "0x10FD9C8")]
			set
			{
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10FDAF4", Offset = "0x10FDAF4", VA = "0x10FDAF4", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x10FDB10", Offset = "0x10FDB10", VA = "0x10FDB10")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x10FD9F8", Offset = "0x10FD9F8", VA = "0x10FD9F8")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x10FDB14", Offset = "0x10FDB14", VA = "0x10FDB14", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x10FDBFC", Offset = "0x10FDBFC", VA = "0x10FDBFC", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x10FDCB8", Offset = "0x10FDCB8", VA = "0x10FDCB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x10FDD80", Offset = "0x10FDD80", VA = "0x10FDD80")]
		public ForeArmLeftMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/ForeArmRightMyVFXTransformBinder")]
	internal class ForeArmRightMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000086")]
		public string Property
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x10FDDE4", Offset = "0x10FDDE4", VA = "0x10FDDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x10FDE00", Offset = "0x10FDE00", VA = "0x10FDE00")]
			set
			{
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x10FDF2C", Offset = "0x10FDF2C", VA = "0x10FDF2C", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x10FDF48", Offset = "0x10FDF48", VA = "0x10FDF48")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10FDE30", Offset = "0x10FDE30", VA = "0x10FDE30")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x10FDF4C", Offset = "0x10FDF4C", VA = "0x10FDF4C", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x10FE034", Offset = "0x10FE034", VA = "0x10FE034", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x10FE0F0", Offset = "0x10FE0F0", VA = "0x10FE0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x10FE1B8", Offset = "0x10FE1B8", VA = "0x10FE1B8")]
		public ForeArmRightMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	[VFXBinder("Transform/HeadMyVFXTransformBinder")]
	internal class HeadMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000087")]
		public string Property
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x10FE21C", Offset = "0x10FE21C", VA = "0x10FE21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x10FE238", Offset = "0x10FE238", VA = "0x10FE238")]
			set
			{
			}
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x10FE364", Offset = "0x10FE364", VA = "0x10FE364", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10FE380", Offset = "0x10FE380", VA = "0x10FE380")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x10FE268", Offset = "0x10FE268", VA = "0x10FE268")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x10FE384", Offset = "0x10FE384", VA = "0x10FE384", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x10FE46C", Offset = "0x10FE46C", VA = "0x10FE46C", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x10FE528", Offset = "0x10FE528", VA = "0x10FE528", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x10FE5F0", Offset = "0x10FE5F0", VA = "0x10FE5F0")]
		public HeadMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[VFXBinder("Transform/LeftLegMyVFXTransformBinder")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	internal class LeftLegMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000088")]
		public string Property
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x10FE654", Offset = "0x10FE654", VA = "0x10FE654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x10FE670", Offset = "0x10FE670", VA = "0x10FE670")]
			set
			{
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10FE79C", Offset = "0x10FE79C", VA = "0x10FE79C", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10FE7B8", Offset = "0x10FE7B8", VA = "0x10FE7B8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10FE6A0", Offset = "0x10FE6A0", VA = "0x10FE6A0")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x10FE7BC", Offset = "0x10FE7BC", VA = "0x10FE7BC", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10FE8A4", Offset = "0x10FE8A4", VA = "0x10FE8A4", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10FE960", Offset = "0x10FE960", VA = "0x10FE960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10FEA28", Offset = "0x10FEA28", VA = "0x10FEA28")]
		public LeftLegMyVFXTransformBinder()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[VFXBinder("Transform/RightLegMyVFXTransformBinder")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	internal class RightLegMyVFXTransformBinder : VFXBinderBase
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		protected ExposedProperty m_Property;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Target;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExposedProperty Position;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExposedProperty Angles;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExposedProperty Scale;

		[Token(Token = "0x17000089")]
		public string Property
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x10FEA8C", Offset = "0x10FEA8C", VA = "0x10FEA8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x10FEAA8", Offset = "0x10FEAA8", VA = "0x10FEAA8")]
			set
			{
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10FEBD4", Offset = "0x10FEBD4", VA = "0x10FEBD4", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x10FEBF0", Offset = "0x10FEBF0", VA = "0x10FEBF0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x10FEAD8", Offset = "0x10FEAD8", VA = "0x10FEAD8")]
		private void UpdateSubProperties()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x10FEBF4", Offset = "0x10FEBF4", VA = "0x10FEBF4", Slot = "4")]
		public override bool IsValid(VisualEffect component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10FECDC", Offset = "0x10FECDC", VA = "0x10FECDC", Slot = "9")]
		public override void UpdateBinding(VisualEffect component)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10FED98", Offset = "0x10FED98", VA = "0x10FED98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x10FEE60", Offset = "0x10FEE60", VA = "0x10FEE60")]
		public RightLegMyVFXTransformBinder()
		{
		}
	}
}
namespace MagicLightProbes
{
	[Token(Token = "0x20000F5")]
	public class MLPDataSaver
	{
		[Token(Token = "0x6000479")]
		public static void SaveData<T>(T data, string fullFilePath, string consoleString = "")
		{
		}

		[Token(Token = "0x600047A")]
		public static T LoadData<T>(T dataRecipient, string fullFilePath, string consoleStringSuccess = "", string consoleStringFail = "")
		{
			return (T)null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10FEEC4", Offset = "0x10FEEC4", VA = "0x10FEEC4")]
		public MLPDataSaver()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public static class TransformExtensions
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x10FEECC", Offset = "0x10FEECC", VA = "0x10FEECC")]
		public static bool MLP_IsVisibleFrom(this Transform transform, Camera camera)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F7")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
	[ExecuteInEditMode]
	public class MagicLightProbes : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		public struct VolumeParameters
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int volumeIndex;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 position;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 demensions;

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x10FFC54", Offset = "0x10FFC54", VA = "0x10FFC54")]
			public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions)
			{
			}
		}

		[Token(Token = "0x20000F9")]
		public enum FillingMode
		{
			[Token(Token = "0x4000571")]
			VerticalDublicating,
			[Token(Token = "0x4000572")]
			FullFilling,
			[Token(Token = "0x4000573")]
			SeparateFilling
		}

		[Token(Token = "0x20000FA")]
		public enum Workflow
		{
			[Token(Token = "0x4000575")]
			Simple,
			[Token(Token = "0x4000576")]
			Advanced
		}

		[Token(Token = "0x20000FB")]
		public enum BoundsDisplayMode
		{
			[Token(Token = "0x4000578")]
			Always,
			[Token(Token = "0x4000579")]
			OnSelection
		}

		[Token(Token = "0x20000FC")]
		public enum DebugPasses
		{
			[Token(Token = "0x400057B")]
			MaximumHeight,
			[Token(Token = "0x400057C")]
			GeometryCollision,
			[Token(Token = "0x400057D")]
			GeometryIntersections,
			[Token(Token = "0x400057E")]
			NearGeometry,
			[Token(Token = "0x400057F")]
			OutOfRange,
			[Token(Token = "0x4000580")]
			OutOfRangeBorders,
			[Token(Token = "0x4000581")]
			ShadingBorders,
			[Token(Token = "0x4000582")]
			ContrastAreas,
			[Token(Token = "0x4000583")]
			NearLights,
			[Token(Token = "0x4000584")]
			LightIntensity,
			[Token(Token = "0x4000585")]
			UnlitProbes,
			[Token(Token = "0x4000586")]
			EqualProbes,
			[Token(Token = "0x4000587")]
			GeometryEdges,
			[Token(Token = "0x4000588")]
			EqualColor
		}

		[Token(Token = "0x20000FD")]
		public enum DrawModes
		{
			[Token(Token = "0x400058A")]
			Accepted,
			[Token(Token = "0x400058B")]
			Culled,
			[Token(Token = "0x400058C")]
			Both
		}

		[Token(Token = "0x20000FE")]
		public enum CalculationTarget
		{
			[Token(Token = "0x400058E")]
			GeometryEdges,
			[Token(Token = "0x400058F")]
			GeneralCalculation
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		private struct TempPointData
		{
			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float xPos;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float yPos;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float zPos;

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x10FFC68", Offset = "0x10FFC68", VA = "0x10FFC68")]
			public TempPointData(Vector3 _position)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class WorkPathFoundEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x10FFC74", Offset = "0x10FFC74", VA = "0x10FFC74")]
			public WorkPathFoundEvent()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/";

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator colorThresholdRecalculationRoutine;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator lightProbesVolumeCalculatingRoutine;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator lightProbesVolumeCalculatingSubRoutine;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator executingPassesRoutine;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerator volumeDivideingRoutine;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> groundAndFloorKeywords;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<string> storedGroundAndFloorKeywords;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject probesVolume;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useDynamicDensity;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float volumeSpacing;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float volumeSpacingMin;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float volumeSpacingMax;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float cornersDetectionThreshold;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float cornersDetectionThresholdMin;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float cornersDetectionThresholdMax;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lastCornersDetectionThreshold;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float lastCornersDetectionThresholdMin;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float lastCornersDetectionThresholdMax;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int lastMaxProbesInVolume;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int maxProbesInVolume;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int defaultMaxProbesCount;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float lastVolumeSpacing;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float lastVolumeSpacingMin;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float lastVolumeSpacingMax;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool volumeSpacingChanged;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool tooManySubVolumes;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FillingMode fillingMode;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Workflow workflow;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float maxHeightAboveGeometry;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float lastMaxHeightAboveGeometry;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float maxHeightAboveTerrain;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool considerDistanceToLights;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float lightIntensityTreshold;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float colorTreshold;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float collisionDetectionRadius;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool saveProbesNearbyGeometry;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float cornerProbesSpacing;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float nearbyGeometryDetectionRadius;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float nearbyGeometryDetectionRadiusMin;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float nearbyGeometryDetectionRadiusMax;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float distanceFromNearbyGeometry;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool fillEquivalentVolume;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float equivalentVolumeFillingRate;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool fillUnlitVolume;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		public bool fillFreeVolume;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float unlitVolumeFillingRate;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float freeVolumeFillingRate;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool cullAcceptedVolume;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float acceptedVolumeFillingRate;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float nearbyGeometryVolumeFillingRate;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float verticalDublicatingHeight;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float verticalDublicatingStep;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask raycastFilter;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<MLPLight> excludedLights;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public LayerMask layerMask;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int firstCollisionLayer;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool useMultithreading;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public GameObject previousSelection;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool unloaded;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool sceneChanging;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		public bool waitForPrevious;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public MagicLightProbes previousVolume;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool optimizeForMixedLighting;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool lastOptimizeForMixedLightingValue;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool preventLeakageThroughWalls;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool useVolumeBottom;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public float lastColorThreshold;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float lastLightIntensityThreshold;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float lastEquivalentVolumeFillingRate;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float lastUnlitVolumeFillingRate;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float lastFreeVolumeFillingRate;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float lastCornerProbesSpacing;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public float lastDistanceFromGeometry;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool debugMode;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float debugObjectScale;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public BoundsDisplayMode boundsDisplayMode;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public DebugPasses debugPass;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public DrawModes drawMode;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool debugShowLightIntensity;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool showPreviewGrid;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool nextStep;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool cullByColor;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public bool forceSaveProbesOnShadingBorders;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public string dataPath;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string workPath;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool workPathFound;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<Vector3> localFinishedPositions;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public ComputeShader calculateVolumeFilling;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public ComputeShader calculateProbeSpacing;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public ComputeShader calculateDistanceFromGeometry;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public MLPVolume currentVolume;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public MLPQuickEditing quickEditingComponent;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool recalculationRequired;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<Collider> lightColliders;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<Collider> objectColliders;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<MLPPointData> finalDebugAcceptedPoints;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<MLPPointData> finalDebugCulledPoints;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<GameObject> tempObjects;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private List<GameObject> temporarilyDisabledDynamicObjects;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<GameObject> staticObjectsWithoutCollider;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private GameObject combinedVolumeObject;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private VolumeParameters currentEditingVolume;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 currentSelectedObjectLastPosition;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private GameObject lastSelectedObject;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public bool cancelCombination;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public List<IEnumerator> passesToExecute;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public List<GameObject> staticObjects;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public List<MLPLight> lights;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public List<MLPPointData> tmpSharedPointsArray;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public List<MLPPointData> tmpOutOfRangePoints;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public List<MLPPointData> tmpOutOfMaxHeightPoints;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public List<MLPPointData> tmpGeometryCollisionPoints;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public List<MLPPointData> tmpContrastOnOutOfRangePoints;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public List<MLPPointData> tmpContrastShadingBordersPoints;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public List<MLPPointData> tmpUnlitPoints;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public List<MLPPointData> tmpFreePoints;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public List<MLPPointData> tmpNearbyGeometryPoints;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public List<MLPPointData> tmpPointsNearGeometryIntersections;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public List<MLPPointData> tmpNearbyLightsPoints;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public List<MLPPointData> tmpEqualPoints;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public List<MLPPointData> debugCulledPoints;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public List<MLPPointData> debugAcceptedPoints;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public List<GameObject> subVolumesDivided;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public List<Vector3> points;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<VolumeParameters> innerVolumes;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public List<VolumeParameters> subVolumesParameters;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public List<MagicLightProbes> innerVolumesObjects;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public List<LayerMask> layerMasks;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public List<Vector3> transformedPoints;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public string assetEditorPath;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool operationalDataLost;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public bool localOperationalDataLost;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x311")]
		public bool recombinationNeeded;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x312")]
		public bool isInBackground;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x313")]
		public bool realtimeEditing;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		public bool calculated;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x315")]
		public bool calculatingError;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public int xPointsCount;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		public int yPointsCount;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public int zPointsCount;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		public float prevVolumeScaleX;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public float prevVolumeScaleY;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		public float prevVolumeScaleZ;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public int totalProbes;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public int totalProbesInSubVolume;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public int totalProbesInVolume;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public bool calculatingVolume;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33D")]
		public bool calculatingVolumeSubPass;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public string currentPass;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public int currentPassProgressCounter;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public int currentPassProgressFrameSkipper;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public float totalProgress;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public float currentPassProgress;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public int selectedTab;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35D")]
		public bool restored;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public int currentVolumePart;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		public float eta;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public bool changed;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x369")]
		public bool redivideParts;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36A")]
		public bool combinedVolumeError;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36B")]
		private bool passesExecuting;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private int totalProgressCounter;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private int totalProgressFrameSkipper;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private float startTime;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private float endTime;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		private bool scenePreparing;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x10FEF80", Offset = "0x10FEF80", VA = "0x10FEF80")]
		public void CheckForNearContrast(MLPPointData pointForCheck)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10FF360", Offset = "0x10FF360", VA = "0x10FF360")]
		public bool UpdateProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x10FF3A8", Offset = "0x10FF3A8", VA = "0x10FF3A8")]
		private bool UpdateTotalProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10FF3F0", Offset = "0x10FF3F0", VA = "0x10FF3F0")]
		public MagicLightProbes()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-combined-volume")]
	public class MLPCombinedVolume : MonoBehaviour
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x10FFCBC", Offset = "0x10FFCBC", VA = "0x10FFCBC")]
		public MLPCombinedVolume()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
	public class MLPLight : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		public enum CalculationMode
		{
			[Token(Token = "0x40005B8")]
			AccurateShadows,
			[Token(Token = "0x40005B9")]
			LightIntensity
		}

		[Token(Token = "0x2000104")]
		public enum MLPLightType
		{
			[Token(Token = "0x40005BB")]
			Spot,
			[Token(Token = "0x40005BC")]
			Directional,
			[Token(Token = "0x40005BD")]
			Point,
			[Token(Token = "0x40005BE")]
			Area,
			[Token(Token = "0x40005BF")]
			Mesh
		}

		[Token(Token = "0x2000105")]
		public enum MLPLightTypeMA
		{
			[Token(Token = "0x40005C1")]
			Area = 3,
			[Token(Token = "0x40005C2")]
			Mesh
		}

		[Token(Token = "0x2000106")]
		public enum TracePointSettingMode
		{
			[Token(Token = "0x40005C4")]
			Auto,
			[Token(Token = "0x40005C5")]
			Custom
		}

		[Token(Token = "0x2000107")]
		public enum ShadowmaskMode
		{
			[Token(Token = "0x40005C7")]
			Shadowmask,
			[Token(Token = "0x40005C8")]
			DistanceShadowmask
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MLPLightType lightType;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MLPLightType lastLightType;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MLPLightTypeMA lightTypeMA;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CalculationMode calculationMode;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TracePointSettingMode tracePointSettingMode;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LightmapBakeType lightMode;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowmaskMode shadowmaskMode;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Light targetLight;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject parentGameObject;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 position;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 forward;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool saveNearbyProbes;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float saveRadius;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float range;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useSourceParameters;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool reverseDirection;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angle;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool customTracePoints;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool accurateTrace;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int accuracy;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int lastAccuracy;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isDirectional;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float tracePointSize;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastTracePointSize;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MeshFilter lastMesh;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> tracePoints;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<MLPTracePoint> tracePointsData;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MLPTracePoint mainTracePoint;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float intensity;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool resetEditor;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool showLightOnScene;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool saveOnOutOfRange;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		public bool isHDRP;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 hdrpAreaSize;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x10FFCC4", Offset = "0x10FFCC4", VA = "0x10FFCC4")]
		public MLPLight()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class MLPPointData
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float lightIntensity;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxIntencity;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int col;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int row;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int depth;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<float> distancesToLights;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Vector3> collisionPoints;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<MLPPointData> nearbyPoints;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> nearbyPointsOptimaziable;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool removed;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool outOfRange;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool inSaveRange;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool savedNearGeometry;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool contrastOnOutOfRangeArea;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool inRangeOfLight;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool contrastOnShadingArea;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool equalIntensity;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool equalColor;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool borderPoint;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool outOfMaxHeight;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float angleToLight;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 contactPoint;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool inCorner;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool lockForCull;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool onGeometryEdge;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool lightLeakLocked;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 collisionNormal;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<MLPLight> inRangeForLights;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MLPLight> inShadowForLights;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject temporaryObject;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject collisionObject;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color averagedColor;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool xEndPoint;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool yEndPoint;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool zEndPoint;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		public bool xStartPoint;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool yStartPoint;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool zStartPoint;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int equivalent;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float avaragedColorValue;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isUnlit;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x10FFDA8", Offset = "0x10FFDA8", VA = "0x10FFDA8")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x10FFDB4", Offset = "0x10FFDB4", VA = "0x10FFDB4")]
		public void SetOutOfRange(bool visibility)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x10FFDC0", Offset = "0x10FFDC0", VA = "0x10FFDC0")]
		public void SetLightIntensity(float intensity)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x10FFDC8", Offset = "0x10FFDC8", VA = "0x10FFDC8")]
		public void SetInSaveRange(bool value)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x10FFDD4", Offset = "0x10FFDD4", VA = "0x10FFDD4")]
		public void SetInContrastArea(bool value)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x10FFDE0", Offset = "0x10FFDE0", VA = "0x10FFDE0")]
		public MLPPointData()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[ExecuteInEditMode]
	public class MLPPortal : MonoBehaviour
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float yStep;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float zStep;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int yCounter;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int zCounter;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool calculate;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x10FFFB0", Offset = "0x10FFFB0", VA = "0x10FFFB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10FFFB4", Offset = "0x10FFFB4", VA = "0x10FFFB4")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1100020", Offset = "0x1100020", VA = "0x1100020")]
		private void DrawRayX(Vector3 dir)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x110027C", Offset = "0x110027C", VA = "0x110027C")]
		private void DrawRayZ(Vector3 dir)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x110049C", Offset = "0x110049C", VA = "0x110049C")]
		public MLPPortal()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-quick-editing")]
	public class MLPQuickEditing : MonoBehaviour
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MagicLightProbes parent;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gizmoScale;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float drawDistance;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x11004A4", Offset = "0x11004A4", VA = "0x11004A4")]
		public MLPQuickEditing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010B")]
	public class MLPTracePoint
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 forward;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject pointGameObject;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x11004B4", Offset = "0x11004B4", VA = "0x11004B4")]
		public MLPTracePoint()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[ExecuteInEditMode]
	public class MLPVolume : MonoBehaviour
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MagicLightProbes parentRootComponent;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshRenderer selfRenderer;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool showGizmo;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool showGizmoSelected;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isPartVolume;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool isSubdividedPart;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isCalculated;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool isInProcess;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool skipped;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int id;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color colorOnSelection;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> localAcceptedPoints;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<MLPPointData> localNearbyGeometryPoints;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<MLPPointData> localContrastPoints;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<MLPPointData> localCornerPoints;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Vector3> localNearbyGeometryPointsPositions;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<Vector3> resultNearbyGeometryPointsPositions;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Vector3> localCornerPointsPositions;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Vector3> resultLocalCornerPointsPositions;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<Vector3> localEquivalentPointsPositions;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<Vector3> resultLocalEquivalentPointsPositions;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Vector3> resultLocalFreePointsPositions;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<Vector3> localUnlitPointsPositions;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<Vector3> localFreePointsPositions;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<Vector3> resultLocalUnlitPointsPositions;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<Vector3> localDirections;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<Vector3> localAvaragedDirections;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<MLPPointData> localColorThresholdEditingPoints;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int objectsInside;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x11004BC", Offset = "0x11004BC", VA = "0x11004BC")]
		public MLPVolume()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class CheckForLightLeakAreas
	{
		[Token(Token = "0x200010E")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0x1100EF8", Offset = "0x1100EF8", VA = "0x1100EF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x1100F40", Offset = "0x1100F40", VA = "0x1100F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1100870", Offset = "0x1100870", VA = "0x1100870")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x11008A0", Offset = "0x11008A0", VA = "0x11008A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x11008A4", Offset = "0x11008A4", VA = "0x11008A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1100F00", Offset = "0x1100F00", VA = "0x1100F00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x11007FC", Offset = "0x11007FC", VA = "0x11007FC")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1100898", Offset = "0x1100898", VA = "0x1100898")]
		public CheckForLightLeakAreas()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class DublicateVertical
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <steps>5__2;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<MLPPointData> <candidates>5__3;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MLPPointData> <savedNearGeometry>5__4;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__5;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MLPPointData>.Enumerator <>7__wrap5;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A3")]
				[Address(RVA = "0x1101BE0", Offset = "0x1101BE0", VA = "0x1101BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0x1101C28", Offset = "0x1101C28", VA = "0x1101C28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1100FBC", Offset = "0x1100FBC", VA = "0x1100FBC")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1100FEC", Offset = "0x1100FEC", VA = "0x1100FEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1101008", Offset = "0x1101008", VA = "0x1101008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1101B90", Offset = "0x1101B90", VA = "0x1101B90")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1101BE8", Offset = "0x1101BE8", VA = "0x1101BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1100F48", Offset = "0x1100F48", VA = "0x1100F48")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1100FE4", Offset = "0x1100FE4", VA = "0x1100FE4")]
		public DublicateVertical()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class RandomGen
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _global;

		[Token(Token = "0x4000629")]
		[ThreadStatic]
		private static System.Random _local;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1101C30", Offset = "0x1101C30", VA = "0x1101C30")]
		public static int Next(int min, int max)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000112")]
	public class EquivalentProbesOptimization
	{
		[Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool realtimeEditing;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__3;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__4;

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AD")]
				[Address(RVA = "0x110270C", Offset = "0x110270C", VA = "0x110270C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x1102754", Offset = "0x1102754", VA = "0x1102754", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1101F50", Offset = "0x1101F50", VA = "0x1101F50")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1101F80", Offset = "0x1101F80", VA = "0x1101F80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1101F84", Offset = "0x1101F84", VA = "0x1101F84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1102714", Offset = "0x1102714", VA = "0x1102714", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1101EB4", Offset = "0x1101EB4", VA = "0x1101EB4")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1101F78", Offset = "0x1101F78", VA = "0x1101F78")]
		public EquivalentProbesOptimization()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class PartialVolumeFilling
	{
		[Token(Token = "0x2000115")]
		public enum TargetPoint
		{
			[Token(Token = "0x4000633")]
			Unlit,
			[Token(Token = "0x4000634")]
			Equivalent,
			[Token(Token = "0x4000635")]
			Free
		}

		[Token(Token = "0x2000116")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetPoint targetPoint;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool realtimeEditing;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__2;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<Vector3> <realTimeEditingList>5__3;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vector3> <targetPoints>5__4;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float <fillingRate>5__5;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3[] <exit>5__6;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <i>5__7;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x110385C", Offset = "0x110385C", VA = "0x110385C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x11038A4", Offset = "0x11038A4", VA = "0x11038A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1102808", Offset = "0x1102808", VA = "0x1102808")]
			[DebuggerHidden]
			public <ExecutePass>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1102838", Offset = "0x1102838", VA = "0x1102838", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x110283C", Offset = "0x110283C", VA = "0x110283C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1103864", Offset = "0x1103864", VA = "0x1103864", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x110275C", Offset = "0x110275C", VA = "0x110275C")]
		[IteratorStateMachine(typeof(<ExecutePass>d__1))]
		public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1102830", Offset = "0x1102830", VA = "0x1102830")]
		public PartialVolumeFilling()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class RemoveUnusedPoints
	{
		[Token(Token = "0x2000118")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<MLPPointData> <pointsToRemove>5__2;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__3;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0x10CB3D8", Offset = "0x10CB3D8", VA = "0x10CB3D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x10CB420", Offset = "0x10CB420", VA = "0x10CB420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x10CAE8C", Offset = "0x10CAE8C", VA = "0x10CAE8C")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x10CAEBC", Offset = "0x10CAEBC", VA = "0x10CAEBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x10CAEC0", Offset = "0x10CAEC0", VA = "0x10CAEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x10CB3E0", Offset = "0x10CB3E0", VA = "0x10CB3E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x10CAE18", Offset = "0x10CAE18", VA = "0x10CAE18")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x10CAEB4", Offset = "0x10CAEB4", VA = "0x10CAEB4")]
		public RemoveUnusedPoints()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class SetDistanceFromGeometry
	{
		[Token(Token = "0x200011A")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x10CBA58", Offset = "0x10CBA58", VA = "0x10CBA58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x10CBAA0", Offset = "0x10CBAA0", VA = "0x10CBAA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x10CB4B8", Offset = "0x10CB4B8", VA = "0x10CB4B8")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x10CB4E8", Offset = "0x10CB4E8", VA = "0x10CB4E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x10CB4EC", Offset = "0x10CB4EC", VA = "0x10CB4EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x10CBA60", Offset = "0x10CBA60", VA = "0x10CBA60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x10CB428", Offset = "0x10CB428", VA = "0x10CB428")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, MLPVolume currentVolume)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x10CB4E0", Offset = "0x10CB4E0", VA = "0x10CB4E0")]
		public SetDistanceFromGeometry()
		{
		}
	}
}
namespace LIV.SDK.Unity
{
	[Token(Token = "0x200011B")]
	[Flags]
	public enum INVALIDATION_FLAGS : uint
	{
		[Token(Token = "0x400064E")]
		NONE = 0u,
		[Token(Token = "0x400064F")]
		HMD_CAMERA = 1u,
		[Token(Token = "0x4000650")]
		STAGE = 2u,
		[Token(Token = "0x4000651")]
		MR_CAMERA_PREFAB = 4u,
		[Token(Token = "0x4000652")]
		EXCLUDE_BEHAVIOURS = 8u
	}
	[Token(Token = "0x200011C")]
	[HelpURL("https://liv.tv/sdk-unity-docs")]
	[AddComponentMenu("LIV/LIV")]
	public class LIV : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		[CompilerGenerated]
		private sealed class <WaitForUnityEndOfFrame>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LIV <>4__this;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x10CD248", Offset = "0x10CD248", VA = "0x10CD248", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x10CD290", Offset = "0x10CD290", VA = "0x10CD290", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x10CC4C0", Offset = "0x10CC4C0", VA = "0x10CC4C0")]
			[DebuggerHidden]
			public <WaitForUnityEndOfFrame>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x10CD0A4", Offset = "0x10CD0A4", VA = "0x10CD0A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x10CD0A8", Offset = "0x10CD0A8", VA = "0x10CD0A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x10CD250", Offset = "0x10CD250", VA = "0x10CD250", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onActivate;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<SDKRender> onPreRender;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<SDKRender> onPreRenderBackground;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<SDKRender> onPostRenderBackground;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<SDKRender> onPreRenderForeground;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<SDKRender> onPostRenderForeground;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<SDKRender> onPostRender;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action onDeactivate;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("This is the topmost transform of your VR rig.")]
		[FormerlySerializedAs("TrackedSpaceOrigin")]
		[SerializeField]
		private Transform _stage;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("StageTransform")]
		[SerializeField]
		[Tooltip("This transform is an additional wrapper to the user’s playspace.")]
		private Transform _stageTransform;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("This is the camera responsible for rendering the user’s HMD.")]
		[FormerlySerializedAs("HMDCamera")]
		private Camera _HMDCamera;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("MRCameraPrefab")]
		[Tooltip("Camera prefab for customized rendering.")]
		private Camera _MRCameraPrefab;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("DisableStandardAssets")]
		[Tooltip("This option disables all standard Unity assets for the Mixed Reality rendering.")]
		[SerializeField]
		private bool _disableStandardAssets;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Tooltip("The layer mask defines exactly which object layers should be rendered in MR.")]
		[FormerlySerializedAs("SpectatorLayerMask")]
		private LayerMask _spectatorLayerMask;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("ExcludeBehaviours")]
		[Tooltip("This is for removing unwanted scripts from the cloned MR camera.")]
		[SerializeField]
		private string[] _excludeBehaviours;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Recovers corrupted alpha channel when using post-effects.")]
		[FormerlySerializedAs("FixPostEffectsAlpha")]
		[SerializeField]
		private bool _fixPostEffectsAlpha;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _isActive;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SDKRender _render;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _wasReady;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private INVALIDATION_FLAGS _invalidate;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _stageCandidate;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera _HMDCameraCandidate;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera _MRCameraPrefabCandidate;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string[] _excludeBehavioursCandidate;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _enabled;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Coroutine _waitForEndOfFrameCoroutine;

		[Token(Token = "0x17000096")]
		public Transform stage
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x10CBAA8", Offset = "0x10CBAA8", VA = "0x10CBAA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x10CBB38", Offset = "0x10CBB38", VA = "0x10CBB38")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		[Obsolete("Use stage instead")]
		public Transform trackedSpaceOrigin
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x10CBC44", Offset = "0x10CBC44", VA = "0x10CBC44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x10CBC48", Offset = "0x10CBC48", VA = "0x10CBC48")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x10CBC4C", Offset = "0x10CBC4C", VA = "0x10CBC4C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x17000099")]
		public Matrix4x4 stageWorldToLocalMatrix
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x10CBD44", Offset = "0x10CBD44", VA = "0x10CBD44")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x1700009A")]
		public Transform stageTransform
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x10CBE3C", Offset = "0x10CBE3C", VA = "0x10CBE3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x10CBE44", Offset = "0x10CBE44", VA = "0x10CBE44")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public Camera HMDCamera
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x10CBE4C", Offset = "0x10CBE4C", VA = "0x10CBE4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x10CBE54", Offset = "0x10CBE54", VA = "0x10CBE54")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Camera MRCameraPrefab
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x10CBF4C", Offset = "0x10CBF4C", VA = "0x10CBF4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x10CBF54", Offset = "0x10CBF54", VA = "0x10CBF54")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x10CBFE4", Offset = "0x10CBFE4", VA = "0x10CBFE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x10CBFEC", Offset = "0x10CBFEC", VA = "0x10CBFEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public LayerMask spectatorLayerMask
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x10CBFF8", Offset = "0x10CBFF8", VA = "0x10CBFF8")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x10CC000", Offset = "0x10CC000", VA = "0x10CC000")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public string[] excludeBehaviours
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x10CC008", Offset = "0x10CC008", VA = "0x10CC008")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x10CC010", Offset = "0x10CC010", VA = "0x10CC010")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool fixPostEffectsAlpha
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x10CC044", Offset = "0x10CC044", VA = "0x10CC044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x10CC04C", Offset = "0x10CC04C", VA = "0x10CC04C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool isValid
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x10CC058", Offset = "0x10CC058", VA = "0x10CC058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool isActive
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x10CC1B8", Offset = "0x10CC1B8", VA = "0x10CC1B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		private bool _isReady
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x10CC1C0", Offset = "0x10CC1C0", VA = "0x10CC1C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public SDKRender render
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x10CC2CC", Offset = "0x10CC2CC", VA = "0x10CC2CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x10CC2D4", Offset = "0x10CC2D4", VA = "0x10CC2D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x10CC324", Offset = "0x10CC324", VA = "0x10CC324")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x10CC444", Offset = "0x10CC444", VA = "0x10CC444")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x10CC44C", Offset = "0x10CC44C", VA = "0x10CC44C")]
		[IteratorStateMachine(typeof(<WaitForUnityEndOfFrame>d__68))]
		private IEnumerator WaitForUnityEndOfFrame()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x10CC2E0", Offset = "0x10CC2E0", VA = "0x10CC2E0")]
		private void UpdateSDKReady()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x10CC4E8", Offset = "0x10CC4E8", VA = "0x10CC4E8")]
		private void OnSDKReadyChanged(bool value)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x10CC4F4", Offset = "0x10CC4F4", VA = "0x10CC4F4")]
		private void OnSDKActivate()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x10CC5A0", Offset = "0x10CC5A0", VA = "0x10CC5A0")]
		private void OnSDKDeactivate()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x10CC820", Offset = "0x10CC820", VA = "0x10CC820")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x10CC90C", Offset = "0x10CC90C", VA = "0x10CC90C")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x10CC890", Offset = "0x10CC890", VA = "0x10CC890")]
		private void StartRenderCoroutine()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x10CC8C8", Offset = "0x10CC8C8", VA = "0x10CC8C8")]
		private void StopRenderCoroutine()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x10CC63C", Offset = "0x10CC63C", VA = "0x10CC63C")]
		private void SubmitSDKOutput()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x10CC33C", Offset = "0x10CC33C", VA = "0x10CC33C")]
		private void Invalidate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x10CCE4C", Offset = "0x10CCE4C", VA = "0x10CCE4C")]
		public LIV()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public static class SDKBridge
	{
		[Token(Token = "0x200011F")]
		public struct SDKInjection<T>
		{
			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool active;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action action;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;
		}

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SDKInjection<SDKInputFrame> _injection_SDKInputFrame;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static SDKInjection<SDKResolution> _injection_SDKResolution;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static SDKInjection<bool> _injection_IsActive;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static bool _injection_DisableSubmit;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
		private static bool _injection_DisableSubmitApplicationOutput;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
		private static bool _injection_DisableAddTexture;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19B")]
		private static bool _injection_DisableCreateFrame;

		[Token(Token = "0x170000A7")]
		public static bool IsActive
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x10CC234", Offset = "0x10CC234", VA = "0x10CC234")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x10CD298", Offset = "0x10CD298", VA = "0x10CD298")]
		public static int AddStringToChannel(int slot, IntPtr str, int length, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x10CD2A0", Offset = "0x10CD2A0", VA = "0x10CD2A0")]
		public static int addtexture(IntPtr sourcetexture, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x10CD2A8", Offset = "0x10CD2A8", VA = "0x10CD2A8")]
		public static ulong GetObjectTimeStamp(IntPtr obj)
		{
			return default(ulong);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x10CD2B0", Offset = "0x10CD2B0", VA = "0x10CD2B0")]
		public static ulong GetCurrentTimeTicks()
		{
			return default(ulong);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x10CD2B8", Offset = "0x10CD2B8", VA = "0x10CD2B8")]
		private static bool GetIsCaptureActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x10CD2C0", Offset = "0x10CD2C0", VA = "0x10CD2C0")]
		public static IntPtr GetRenderEventFunc()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x10CD308", Offset = "0x10CD308", VA = "0x10CD308")]
		public static IntPtr GetCompositorChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x10CD350", Offset = "0x10CD350", VA = "0x10CD350")]
		public static int AddObjectToCompositorChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x10CD358", Offset = "0x10CD358", VA = "0x10CD358")]
		public static int AddObjectToFrame(IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x10CD360", Offset = "0x10CD360", VA = "0x10CD360")]
		public static IntPtr updatinputframe(IntPtr InputFrame)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x10CD3A8", Offset = "0x10CD3A8", VA = "0x10CD3A8")]
		public static IntPtr GetViewportTexture()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x10CD3F0", Offset = "0x10CD3F0", VA = "0x10CD3F0")]
		public static IntPtr GetChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x10CD438", Offset = "0x10CD438", VA = "0x10CD438")]
		public static int AddObjectToChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x10CD440", Offset = "0x10CD440", VA = "0x10CD440")]
		public static ulong Tag(string str)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x10CD4C4", Offset = "0x10CD4C4", VA = "0x10CD4C4")]
		public static void AddString(string tag, string value, int slot)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x10CD5C0", Offset = "0x10CD5C0", VA = "0x10CD5C0")]
		public static void AddTexture(SDKTexture texture, ulong tag)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x10CD680", Offset = "0x10CD680", VA = "0x10CD680")]
		public static ulong GetObjectTime(IntPtr objectptr)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x10CD6DC", Offset = "0x10CD6DC", VA = "0x10CD6DC")]
		public static ulong GetCurrentTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x10CD738", Offset = "0x10CD738", VA = "0x10CD738")]
		public static void IssuePluginEvent()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x10CCC50", Offset = "0x10CCC50", VA = "0x10CCC50")]
		public static void SubmitApplicationOutput(SDKApplicationOutput applicationOutput)
		{
		}

		[Token(Token = "0x600050A")]
		public static bool GetStructFromGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		public static int AddStructToGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x600050C")]
		public static bool GetStructFromLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		public static int AddStructToLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x600050E")]
		public static void AddStructToFrame<T>(ref T mystruct, ulong tag)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x10CD7E8", Offset = "0x10CD7E8", VA = "0x10CD7E8")]
		public static bool UpdateInputFrame(ref SDKInputFrame setframe)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x10CDBEC", Offset = "0x10CDBEC", VA = "0x10CDBEC")]
		public static SDKTexture GetViewfinderTexture()
		{
			return default(SDKTexture);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x10CDE1C", Offset = "0x10CDE1C", VA = "0x10CDE1C")]
		public static void AddTexture(SDKTexture texture)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x10CDF4C", Offset = "0x10CDF4C", VA = "0x10CDF4C")]
		public static void CreateFrame(SDKOutputFrame frame)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x10CE0B4", Offset = "0x10CE0B4", VA = "0x10CE0B4")]
		public static void SetGroundPlane(SDKPlane groundPlane)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x10CE154", Offset = "0x10CE154", VA = "0x10CE154")]
		public static bool GetResolution(ref SDKResolution sdkResolution)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000120")]
	public class SDKRender : IDisposable
	{
		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CommandBuffer _clipPlaneCommandBuffer;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CommandBuffer _combineAlphaCommandBuffer;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CommandBuffer _captureTextureCommandBuffer;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CommandBuffer _applyTextureCommandBuffer;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CommandBuffer _optimizedRenderingCommandBuffer;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CameraEvent _clipPlaneCameraEvent;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private CameraEvent _clipPlaneCombineAlphaCameraEvent;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CameraEvent _captureTextureEvent;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private CameraEvent _applyTextureEvent;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CameraEvent _optimizedRenderingCameraEvent;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh _clipPlaneMesh;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _clipPlaneSimpleMaterial;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _clipPlaneSimpleDebugMaterial;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _clipPlaneComplexMaterial;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _clipPlaneComplexDebugMaterial;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material _writeOpaqueToAlphaMaterial;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _combineAlphaMaterial;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material _writeMaterial;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material _forceForwardRenderingMaterial;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RenderTexture _backgroundRenderTexture;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTexture _foregroundRenderTexture;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RenderTexture _optimizedRenderTexture;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RenderTexture _complexClipPlaneRenderTexture;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private LIV _liv;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SDKOutputFrame _outputFrame;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private SDKInputFrame _inputFrame;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private SDKResolution _resolution;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Camera _cameraInstance;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private SDKPose _requestedPose;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private int _requestedPoseFrameIndex;

		[Token(Token = "0x170000A8")]
		private bool useDeferredRendering
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x10CE5B4", Offset = "0x10CE5B4", VA = "0x10CE5B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		private bool interlacedRendering
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x10CE600", Offset = "0x10CE600", VA = "0x10CE600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		private bool canRenderBackground
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x10CE618", Offset = "0x10CE618", VA = "0x10CE618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool canRenderForeground
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x10CE6A4", Offset = "0x10CE6A4", VA = "0x10CE6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		private bool canRenderOptimized
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x10CE744", Offset = "0x10CE744", VA = "0x10CE744")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public LIV liv
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x10D20A4", Offset = "0x10D20A4", VA = "0x10D20A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public SDKOutputFrame outputFrame
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x10D20AC", Offset = "0x10D20AC", VA = "0x10D20AC")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x170000AF")]
		public SDKInputFrame inputFrame
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x10D20BC", Offset = "0x10D20BC", VA = "0x10D20BC")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x170000B0")]
		public SDKResolution resolution
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x10D20CC", Offset = "0x10D20CC", VA = "0x10D20CC")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x170000B1")]
		public Camera cameraInstance
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x10D20D4", Offset = "0x10D20D4", VA = "0x10D20D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		public Camera cameraReference
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x10D1538", Offset = "0x10D1538", VA = "0x10D1538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		public Camera hmdCamera
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x10D20DC", Offset = "0x10D20DC", VA = "0x10D20DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public Transform stage
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x10D20F8", Offset = "0x10D20F8", VA = "0x10D20F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public Transform stageTransform
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x10D2110", Offset = "0x10D2110", VA = "0x10D2110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x10D212C", Offset = "0x10D212C", VA = "0x10D212C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000B7")]
		public Matrix4x4 localToWorldMatrix
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x10D0960", Offset = "0x10D0960", VA = "0x10D0960")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000B8")]
		public int spectatorLayerMask
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x10D0A24", Offset = "0x10D0A24", VA = "0x10D0A24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B9")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x10D0F2C", Offset = "0x10D0F2C", VA = "0x10D0F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BA")]
		public bool canSetPose
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x10D2224", Offset = "0x10D2224", VA = "0x10D2224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x10CE414", Offset = "0x10CE414", VA = "0x10CE414")]
		private Material GetClipPlaneMaterial(bool debugClipPlane, bool complexClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x10CE518", Offset = "0x10CE518", VA = "0x10CE518")]
		private Material GetGroundClipPlaneMaterial(bool debugClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x10CC93C", Offset = "0x10CC93C", VA = "0x10CC93C")]
		public SDKRender(LIV liv)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x10CD184", Offset = "0x10CD184", VA = "0x10CD184")]
		public void Render()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x10CF614", Offset = "0x10CF614", VA = "0x10CF614")]
		private void RenderBackground()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x10CF908", Offset = "0x10CF908", VA = "0x10CF908")]
		private void RenderForeground()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x10D02A0", Offset = "0x10D02A0", VA = "0x10D02A0")]
		private void RenderOptimized()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x10CE88C", Offset = "0x10CE88C", VA = "0x10CE88C")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x10D1E04", Offset = "0x10D1E04", VA = "0x10D1E04")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x10CCAB8", Offset = "0x10CCAB8", VA = "0x10CCAB8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x10D2244", Offset = "0x10D2244", VA = "0x10D2244")]
		public bool SetPose(Vector3 position, Quaternion rotation, float verticalFieldOfView = 60f, bool useLocalSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x10D26E8", Offset = "0x10D26E8", VA = "0x10D26E8")]
		public void SetGroundPlane(float distance, Vector3 normal, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x10D287C", Offset = "0x10D287C", VA = "0x10D287C")]
		public void SetGroundPlane(Plane plane, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x10D28F4", Offset = "0x10D28F4", VA = "0x10D28F4")]
		public void SetGroundPlane(Transform transform, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x10D1F98", Offset = "0x10D1F98", VA = "0x10D1F98")]
		private void ReleaseBridgePoseControl()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x10CF05C", Offset = "0x10CF05C", VA = "0x10CF05C")]
		private void UpdateBridgeResolution()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x10CF0B4", Offset = "0x10CF0B4", VA = "0x10CF0B4")]
		private void UpdateBridgeInputFrame()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x10CF5DC", Offset = "0x10CF5DC", VA = "0x10CF5DC")]
		private void InvokePreRender()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x10D07A0", Offset = "0x10D07A0", VA = "0x10D07A0")]
		private void IvokePostRender()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x10D0D18", Offset = "0x10D0D18", VA = "0x10D0D18")]
		private void InvokePreRenderBackground()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x10D0E6C", Offset = "0x10D0E6C", VA = "0x10D0E6C")]
		private void InvokePostRenderBackground()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x10D13FC", Offset = "0x10D13FC", VA = "0x10D13FC")]
		private void InvokePreRenderForeground()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x10D1434", Offset = "0x10D1434", VA = "0x10D1434")]
		private void InvokePostRenderForeground()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x10D2AB8", Offset = "0x10D2AB8", VA = "0x10D2AB8")]
		private void CreateBackgroundTexture()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x10D2CCC", Offset = "0x10D2CCC", VA = "0x10D2CCC")]
		private void CreateForegroundTexture()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x10D2D60", Offset = "0x10D2D60", VA = "0x10D2D60")]
		private void CreateOptimizedTexture()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x10D2DF4", Offset = "0x10D2DF4", VA = "0x10D2DF4")]
		private void CreateComplexClipPlaneTexture()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x10CF35C", Offset = "0x10CF35C", VA = "0x10CF35C")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x10D0D50", Offset = "0x10D0D50", VA = "0x10D0D50")]
		private void SendTextureToBridge(RenderTexture texture, TEXTURE_ID id)
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal static class SDKShaders
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int LIV_COLOR_MASK;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int LIV_TESSELLATION_PROPERTY;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int LIV_CLIP_PLANE_HEIGHT_MAP_PROPERTY;

		[Token(Token = "0x400069B")]
		public const string LIV_MR_FOREGROUND_KEYWORD = "LIV_MR_FOREGROUND";

		[Token(Token = "0x400069C")]
		public const string LIV_MR_BACKGROUND_KEYWORD = "LIV_MR_BACKGROUND";

		[Token(Token = "0x400069D")]
		public const string LIV_MR_KEYWORD = "LIV_MR";

		[Token(Token = "0x400069E")]
		public const string LIV_CLIP_PLANE_SIMPLE_SHADER = "Hidden/LIV_ClipPlaneSimple";

		[Token(Token = "0x400069F")]
		public const string LIV_CLIP_PLANE_SIMPLE_DEBUG_SHADER = "Hidden/LIV_ClipPlaneSimpleDebug";

		[Token(Token = "0x40006A0")]
		public const string LIV_CLIP_PLANE_COMPLEX_SHADER = "Hidden/LIV_ClipPlaneComplex";

		[Token(Token = "0x40006A1")]
		public const string LIV_CLIP_PLANE_COMPLEX_DEBUG_SHADER = "Hidden/LIV_ClipPlaneComplexDebug";

		[Token(Token = "0x40006A2")]
		public const string LIV_WRITE_OPAQUE_TO_ALPHA_SHADER = "Hidden/LIV_WriteOpaqueToAlpha";

		[Token(Token = "0x40006A3")]
		public const string LIV_COMBINE_ALPHA_SHADER = "Hidden/LIV_CombineAlpha";

		[Token(Token = "0x40006A4")]
		public const string LIV_WRITE_SHADER = "Hidden/LIV_Write";

		[Token(Token = "0x40006A5")]
		public const string LIV_FORCE_FORWARD_RENDERING_SHADER = "Hidden/LIV_ForceForwardRendering";

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x10D0C90", Offset = "0x10D0C90", VA = "0x10D0C90")]
		public static void StartRendering()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x10D0EE8", Offset = "0x10D0EE8", VA = "0x10D0EE8")]
		public static void StopRendering()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x10D13B8", Offset = "0x10D13B8", VA = "0x10D13B8")]
		public static void StartForegroundRendering()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x10D146C", Offset = "0x10D146C", VA = "0x10D146C")]
		public static void StopForegroundRendering()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x10D0CD4", Offset = "0x10D0CD4", VA = "0x10D0CD4")]
		public static void StartBackgroundRendering()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x10D0EA4", Offset = "0x10D0EA4", VA = "0x10D0EA4")]
		public static void StopBackgroundRendering()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public struct SDKConstants
	{
		[Token(Token = "0x40006A6")]
		public const string SDK_ID = "SAIC51SLNW0GEEUOI2OOGMUGY3QPPTQJ";

		[Token(Token = "0x40006A7")]
		public const string SDK_VERSION = "1.5.4";

		[Token(Token = "0x40006A8")]
		public const string ENGINE_NAME = "unity";
	}
	[Token(Token = "0x2000123")]
	public enum PRIORITY : sbyte
	{
		[Token(Token = "0x40006AA")]
		NONE = 0,
		[Token(Token = "0x40006AB")]
		GAME = 63
	}
	[Token(Token = "0x2000124")]
	[Flags]
	public enum FEATURES : ulong
	{
		[Token(Token = "0x40006AD")]
		NONE = 0uL,
		[Token(Token = "0x40006AE")]
		BACKGROUND_RENDER = 1uL,
		[Token(Token = "0x40006AF")]
		FOREGROUND_RENDER = 2uL,
		[Token(Token = "0x40006B0")]
		COMPLEX_CLIP_PLANE = 4uL,
		[Token(Token = "0x40006B1")]
		BACKGROUND_DEPTH_RENDER = 8uL,
		[Token(Token = "0x40006B2")]
		OVERRIDE_POST_PROCESSING = 0x10uL,
		[Token(Token = "0x40006B3")]
		FIX_FOREGROUND_ALPHA = 0x20uL,
		[Token(Token = "0x40006B4")]
		GROUND_CLIP_PLANE = 0x40uL,
		[Token(Token = "0x40006B5")]
		RELEASE_CONTROL = 0x8000uL,
		[Token(Token = "0x40006B6")]
		OPTIMIZED_RENDER = 0x10000000uL,
		[Token(Token = "0x40006B7")]
		INTERLACED_RENDER = 0x20000000uL,
		[Token(Token = "0x40006B8")]
		DEBUG_CLIP_PLANE = 0x1000000000000uL
	}
	[Token(Token = "0x2000125")]
	public enum TEXTURE_ID : uint
	{
		[Token(Token = "0x40006BA")]
		UNDEFINED = 0u,
		[Token(Token = "0x40006BB")]
		BACKGROUND_COLOR_BUFFER_ID = 10u,
		[Token(Token = "0x40006BC")]
		FOREGROUND_COLOR_BUFFER_ID = 20u,
		[Token(Token = "0x40006BD")]
		OPTIMIZED_COLOR_BUFFER_ID = 30u
	}
	[Token(Token = "0x2000126")]
	public enum TEXTURE_TYPE : uint
	{
		[Token(Token = "0x40006BF")]
		UNDEFINED,
		[Token(Token = "0x40006C0")]
		COLOR_BUFFER
	}
	[Token(Token = "0x2000127")]
	public enum TEXTURE_FORMAT : uint
	{
		[Token(Token = "0x40006C2")]
		UNDEFINED = 0u,
		[Token(Token = "0x40006C3")]
		ARGB32 = 10u
	}
	[Token(Token = "0x2000128")]
	public enum TEXTURE_DEVICE : uint
	{
		[Token(Token = "0x40006C5")]
		UNDEFINED,
		[Token(Token = "0x40006C6")]
		RAW,
		[Token(Token = "0x40006C7")]
		DIRECTX,
		[Token(Token = "0x40006C8")]
		OPENGL,
		[Token(Token = "0x40006C9")]
		VULKAN,
		[Token(Token = "0x40006CA")]
		METAL
	}
	[Token(Token = "0x2000129")]
	public enum TEXTURE_COLOR_SPACE : uint
	{
		[Token(Token = "0x40006CC")]
		UNDEFINED,
		[Token(Token = "0x40006CD")]
		LINEAR,
		[Token(Token = "0x40006CE")]
		SRGB
	}
	[Token(Token = "0x200012A")]
	public enum RENDERING_PIPELINE : uint
	{
		[Token(Token = "0x40006D0")]
		UNDEFINED,
		[Token(Token = "0x40006D1")]
		FORWARD,
		[Token(Token = "0x40006D2")]
		DEFERRED,
		[Token(Token = "0x40006D3")]
		VERTEX_LIT,
		[Token(Token = "0x40006D4")]
		UNIVERSAL,
		[Token(Token = "0x40006D5")]
		HIGH_DEFINITION
	}
	[Token(Token = "0x200012B")]
	public struct SDKResolution
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int width;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int height;

		[Token(Token = "0x170000BB")]
		public static SDKResolution zero
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x10CE40C", Offset = "0x10CE40C", VA = "0x10CE40C")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x10D3040", Offset = "0x10D3040", VA = "0x10D3040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200012C")]
	public struct SDKVector3
	{
		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x170000BC")]
		public static SDKVector3 zero
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x10D30E0", Offset = "0x10D30E0", VA = "0x10D30E0")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000BD")]
		public static SDKVector3 one
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x10D30F0", Offset = "0x10D30F0", VA = "0x10D30F0")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000BE")]
		public static SDKVector3 forward
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x10D3100", Offset = "0x10D3100", VA = "0x10D3100")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000BF")]
		public static SDKVector3 up
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x10D3110", Offset = "0x10D3110", VA = "0x10D3110")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000C0")]
		public static SDKVector3 right
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x10D3120", Offset = "0x10D3120", VA = "0x10D3120")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x10D3130", Offset = "0x10D3130", VA = "0x10D3130")]
		public static implicit operator Vector3(SDKVector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x10D269C", Offset = "0x10D269C", VA = "0x10D269C")]
		public static implicit operator SDKVector3(Vector3 v)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x10D3134", Offset = "0x10D3134", VA = "0x10D3134")]
		public static SDKVector3 operator +(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x10D3144", Offset = "0x10D3144", VA = "0x10D3144")]
		public static SDKVector3 operator -(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x10D3154", Offset = "0x10D3154", VA = "0x10D3154")]
		public static SDKVector3 operator *(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x10D3164", Offset = "0x10D3164", VA = "0x10D3164")]
		public static SDKVector3 operator *(SDKVector3 lhs, float rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x10D3174", Offset = "0x10D3174", VA = "0x10D3174", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200012D")]
	public struct SDKQuaternion
	{
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x170000C1")]
		public static SDKQuaternion identity
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x10D3238", Offset = "0x10D3238", VA = "0x10D3238")]
			get
			{
				return default(SDKQuaternion);
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x10D324C", Offset = "0x10D324C", VA = "0x10D324C")]
		public static implicit operator Quaternion(SDKQuaternion v)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x10D26A0", Offset = "0x10D26A0", VA = "0x10D26A0")]
		public static implicit operator SDKQuaternion(Quaternion v)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x10D3250", Offset = "0x10D3250", VA = "0x10D3250")]
		public static SDKQuaternion Euler(float pitch, float yaw, float roll)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x10D3304", Offset = "0x10D3304", VA = "0x10D3304")]
		public static SDKQuaternion operator *(SDKQuaternion lhs, SDKQuaternion rhs)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x10D3378", Offset = "0x10D3378", VA = "0x10D3378")]
		public static SDKVector3 operator *(SDKQuaternion lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x10D341C", Offset = "0x10D341C", VA = "0x10D341C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200012E")]
	public struct SDKMatrix4x4
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m00;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m01;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m02;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m03;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m10;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m11;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m12;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m13;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m20;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m21;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m22;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m23;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m30;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m31;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m32;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m33;

		[Token(Token = "0x170000C2")]
		public static SDKMatrix4x4 identity
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x10D35F8", Offset = "0x10D35F8", VA = "0x10D35F8")]
			get
			{
				return default(SDKMatrix4x4);
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x10D10E8", Offset = "0x10D10E8", VA = "0x10D10E8")]
		public static implicit operator Matrix4x4(SDKMatrix4x4 v)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x10D26A4", Offset = "0x10D26A4", VA = "0x10D26A4")]
		public static implicit operator SDKMatrix4x4(Matrix4x4 v)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x10D3624", Offset = "0x10D3624", VA = "0x10D3624")]
		public static SDKMatrix4x4 Perspective(float vFov, float aspect, float zNear, float zFar)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x10D36D0", Offset = "0x10D36D0", VA = "0x10D36D0")]
		public static SDKMatrix4x4 operator *(SDKMatrix4x4 lhs, SDKMatrix4x4 rhs)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x10D37DC", Offset = "0x10D37DC", VA = "0x10D37DC")]
		public static SDKVector3 operator *(SDKMatrix4x4 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x10D3834", Offset = "0x10D3834", VA = "0x10D3834")]
		public static SDKMatrix4x4 Translate(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x10D3870", Offset = "0x10D3870", VA = "0x10D3870")]
		public static SDKMatrix4x4 Rotate(SDKQuaternion value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x10D3904", Offset = "0x10D3904", VA = "0x10D3904")]
		public static SDKMatrix4x4 Scale(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x10D3930", Offset = "0x10D3930", VA = "0x10D3930")]
		public static SDKMatrix4x4 TRS(SDKVector3 translation, SDKQuaternion rotation, SDKVector3 scale)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x10D3A14", Offset = "0x10D3A14", VA = "0x10D3A14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200012F")]
	public struct SDKPlane
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float distance;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKVector3 normal;

		[Token(Token = "0x170000C3")]
		public static SDKPlane empty
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x10D3FDC", Offset = "0x10D3FDC", VA = "0x10D3FDC")]
			get
			{
				return default(SDKPlane);
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x10D3F80", Offset = "0x10D3F80", VA = "0x10D3F80")]
		public static implicit operator SDKPlane(Plane v)
		{
			return default(SDKPlane);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x10D3FF0", Offset = "0x10D3FF0", VA = "0x10D3FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000130")]
	public struct SDKPriority
	{
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte pose;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte clipPlane;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte stage;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte resolution;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte feature;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte nearFarAdjustment;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte groundPlane;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte reserved2;

		[Token(Token = "0x170000C4")]
		public static SDKPriority empty
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x10D40B4", Offset = "0x10D40B4", VA = "0x10D40B4")]
			get
			{
				return default(SDKPriority);
			}
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x10D40C0", Offset = "0x10D40C0", VA = "0x10D40C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000131")]
	public struct SDKApplicationOutput
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FEATURES supportedFeatures;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string engineName;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string engineVersion;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string applicationName;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string applicationVersion;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string xrDeviceName;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string graphicsAPI;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string sdkID;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string sdkVersion;

		[Token(Token = "0x170000C5")]
		public static SDKApplicationOutput empty
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x10CCAF0", Offset = "0x10CCAF0", VA = "0x10CCAF0")]
			get
			{
				return default(SDKApplicationOutput);
			}
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x10D4380", Offset = "0x10D4380", VA = "0x10D4380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000132")]
	public struct SDKInputFrame
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKPose pose;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKClipPlane clipPlane;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public SDKTransform stageTransform;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public FEATURES features;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public SDKClipPlane groundClipPlane;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public ulong frameid;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public ulong referenceframe;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public SDKPriority priority;

		[Token(Token = "0x170000C6")]
		public static SDKInputFrame empty
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x10CDAA8", Offset = "0x10CDAA8", VA = "0x10CDAA8")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x10D2A94", Offset = "0x10D2A94", VA = "0x10D2A94")]
		public void ReleaseControl()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x10D2AA4", Offset = "0x10D2AA4", VA = "0x10D2AA4")]
		public void ObtainControl()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x10D4678", Offset = "0x10D4678", VA = "0x10D4678", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000133")]
	public struct SDKOutputFrame
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RENDERING_PIPELINE renderingPipeline;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKTrackedSpace trackedSpace;

		[Token(Token = "0x170000C7")]
		public static SDKOutputFrame empty
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x10CE7BC", Offset = "0x10CE7BC", VA = "0x10CE7BC")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x10D4A78", Offset = "0x10D4A78", VA = "0x10D4A78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	public struct SDKTrackedSpace
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 trackedSpaceWorldPosition;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion trackedSpaceWorldRotation;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 trackedSpaceLocalScale;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKMatrix4x4 trackedSpaceLocalToWorldMatrix;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SDKMatrix4x4 trackedSpaceWorldToLocalMatrix;

		[Token(Token = "0x170000C8")]
		public static SDKTrackedSpace empty
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x10D4A14", Offset = "0x10D4A14", VA = "0x10D4A14")]
			get
			{
				return default(SDKTrackedSpace);
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x10D4B3C", Offset = "0x10D4B3C", VA = "0x10D4B3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000135")]
	public struct SDKTexture
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TEXTURE_ID id;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr texturePtr;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr SharedHandle;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TEXTURE_DEVICE device;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int dummy;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TEXTURE_TYPE type;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TEXTURE_FORMAT format;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TEXTURE_COLOR_SPACE colorSpace;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int width;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int height;

		[Token(Token = "0x170000C9")]
		public static SDKTexture empty
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x10CDDC0", Offset = "0x10CDDC0", VA = "0x10CDDC0")]
			get
			{
				return default(SDKTexture);
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x10D4DBC", Offset = "0x10D4DBC", VA = "0x10D4DBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000136")]
	public struct SDKTransform
	{
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 localPosition;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 localScale;

		[Token(Token = "0x170000CA")]
		public static SDKTransform empty
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x10D4664", Offset = "0x10D4664", VA = "0x10D4664")]
			get
			{
				return default(SDKTransform);
			}
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x10D51D8", Offset = "0x10D51D8", VA = "0x10D51D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000137")]
	public struct SDKClipPlane
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 transform;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int width;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int height;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float tesselation;

		[Token(Token = "0x170000CB")]
		public static SDKClipPlane empty
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x10D4630", Offset = "0x10D4630", VA = "0x10D4630")]
			get
			{
				return default(SDKClipPlane);
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x10D52C0", Offset = "0x10D52C0", VA = "0x10D52C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000138")]
	public struct SDKControllerState
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 hmdposition;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion hmdrotation;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 calibrationcameraposition;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKQuaternion calibrationcamerarotation;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SDKVector3 cameraposition;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SDKQuaternion camerarotation;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SDKVector3 leftposition;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SDKQuaternion leftrotation;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKVector3 rightposition;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public SDKQuaternion rightrotation;

		[Token(Token = "0x170000CC")]
		public static SDKControllerState empty
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x10D54CC", Offset = "0x10D54CC", VA = "0x10D54CC")]
			get
			{
				return default(SDKControllerState);
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x10D5518", Offset = "0x10D5518", VA = "0x10D5518", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000139")]
	public struct SDKPose
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 projectionMatrix;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SDKVector3 localPosition;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float verticalFieldOfView;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float nearClipPlane;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float farClipPlane;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int unused0;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int unused1;

		[Token(Token = "0x170000CD")]
		public static SDKPose empty
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x10CE81C", Offset = "0x10CE81C", VA = "0x10CE81C")]
			get
			{
				return default(SDKPose);
			}
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x10D58F8", Offset = "0x10D58F8", VA = "0x10D58F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200013A")]
	public static class SDKUtils
	{
		[Token(Token = "0x170000CE")]
		public static TEXTURE_COLOR_SPACE GetDefaultColorSpace
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x10D5BD0", Offset = "0x10D5BD0", VA = "0x10D5BD0")]
			get
			{
				return default(TEXTURE_COLOR_SPACE);
			}
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x10D1948", Offset = "0x10D1948", VA = "0x10D1948")]
		public static void CreateClipPlane(Mesh mesh, int resX, int resY, bool useQuads, float skirtLength)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x10D5BB8", Offset = "0x10D5BB8", VA = "0x10D5BB8")]
		public static RenderTextureReadWrite GetReadWriteFromColorSpace(TEXTURE_COLOR_SPACE colorSpace)
		{
			return default(RenderTextureReadWrite);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x10D2EEC", Offset = "0x10D2EEC", VA = "0x10D2EEC")]
		public static TEXTURE_COLOR_SPACE GetColorSpace(RenderTexture renderTexture)
		{
			return default(TEXTURE_COLOR_SPACE);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x10D5BFC", Offset = "0x10D5BFC", VA = "0x10D5BFC")]
		public static RENDERING_PIPELINE GetRenderingPipeline(RenderingPath renderingPath)
		{
			return default(RENDERING_PIPELINE);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x10D2E88", Offset = "0x10D2E88", VA = "0x10D2E88")]
		public static TEXTURE_DEVICE GetDevice()
		{
			return default(TEXTURE_DEVICE);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x10CCE40", Offset = "0x10CCE40", VA = "0x10CCE40")]
		public static bool ContainsFlag(ulong flags, ulong flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x10CBC30", Offset = "0x10CBC30", VA = "0x10CBC30")]
		public static ulong SetFlag(ulong flags, ulong flag, bool enabled)
		{
			return default(ulong);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x10D5C1C", Offset = "0x10D5C1C", VA = "0x10D5C1C")]
		public static void GetCameraPositionAndRotation(SDKPose pose, Matrix4x4 originLocalToWorldMatrix, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x10D15C4", Offset = "0x10D15C4", VA = "0x10D15C4")]
		public static void CleanCameraBehaviours(Camera camera, string[] excludeBehaviours)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x10D0A44", Offset = "0x10D0A44", VA = "0x10D0A44")]
		public static void SetCamera(Camera camera, Transform cameraTransform, SDKInputFrame inputFrame, Matrix4x4 originLocalToWorldMatrix, int layerMask)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x10D2538", Offset = "0x10D2538", VA = "0x10D2538")]
		public static Quaternion RotateQuaternionByMatrix(Matrix4x4 matrix, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x10D5C94", Offset = "0x10D5C94", VA = "0x10D5C94")]
		public static SDKTrackedSpace GetTrackedSpace(Transform transform)
		{
			return default(SDKTrackedSpace);
		}

		[Token(Token = "0x6000593")]
		public static bool DestroyObject<T>(ref T reference) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		public static bool DisposeObject<T>(ref T reference) where T : IDisposable
		{
			return default(bool);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x10D2B4C", Offset = "0x10D2B4C", VA = "0x10D2B4C")]
		public static bool CreateTexture(ref RenderTexture renderTexture, int width, int height, int depth, RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x10D1FFC", Offset = "0x10D1FFC", VA = "0x10D1FFC")]
		public static void DestroyTexture(ref RenderTexture _renderTexture)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x10CF26C", Offset = "0x10CF26C", VA = "0x10CF26C")]
		public static void ApplyUserSpaceTransform(SDKRender render)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x10D07D8", Offset = "0x10D07D8", VA = "0x10D07D8")]
		public static void CreateBridgeOutputFrame(SDKRender render)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x10CE60C", Offset = "0x10CE60C", VA = "0x10CE60C")]
		public static bool FeatureEnabled(FEATURES features, FEATURES feature)
		{
			return default(bool);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x10D0F48", Offset = "0x10D0F48", VA = "0x10D0F48")]
		public static void DisableStandardAssets(Camera cameraInstance, ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x10D14B0", Offset = "0x10D14B0", VA = "0x10D14B0")]
		public static void RestoreStandardAssets(ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x10D112C", Offset = "0x10D112C", VA = "0x10D112C")]
		public static void ForceForwardRendering(Camera cameraInstance, Mesh clipPlaneMesh, Material forceForwardRenderingMaterial)
		{
		}
	}
}
namespace HurricaneVR.TechDemo.Scripts
{
	[Token(Token = "0x200013B")]
	public class DemoBackpack : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		[CompilerGenerated]
		private sealed class <IgnoreColliders>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DemoBackpack <>4__this;

			[Token(Token = "0x170000CF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x10D6518", Offset = "0x10D6518", VA = "0x10D6518", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x10D6560", Offset = "0x10D6560", VA = "0x10D6560", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x10D6144", Offset = "0x10D6144", VA = "0x10D6144")]
			[DebuggerHidden]
			public <IgnoreColliders>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x10D63C8", Offset = "0x10D63C8", VA = "0x10D63C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x10D63CC", Offset = "0x10D63CC", VA = "0x10D63CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x10D6520", Offset = "0x10D6520", VA = "0x10D6520", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Used to ignore collision with grabbable colliders.")]
		public List<Collider> Colliders;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x10D5F10", Offset = "0x10D5F10", VA = "0x10D5F10")]
		private void Start()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x10D60D0", Offset = "0x10D60D0", VA = "0x10D60D0")]
		[IteratorStateMachine(typeof(<IgnoreColliders>d__2))]
		public IEnumerator IgnoreColliders()
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x10D616C", Offset = "0x10D616C", VA = "0x10D616C")]
		public void IgnoreCollision(HVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x10D62A0", Offset = "0x10D62A0", VA = "0x10D62A0")]
		public DemoBackpack()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class DemoCodeGrabbing : MonoBehaviour
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRGrabbable Grabbable;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabTrigger GrabTrigger;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HVRPosableGrabPoint GrabPoint;

		[Token(Token = "0x170000D1")]
		public HVRHandGrabber Grabber
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x10D6568", Offset = "0x10D6568", VA = "0x10D6568")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x10D6570", Offset = "0x10D6570", VA = "0x10D6570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x10D6578", Offset = "0x10D6578", VA = "0x10D6578")]
		public void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x10D66D8", Offset = "0x10D66D8", VA = "0x10D66D8")]
		public void Grab()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x10D6810", Offset = "0x10D6810", VA = "0x10D6810")]
		public DemoCodeGrabbing()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[RequireComponent(typeof(ConfigurableJoint))]
	public class DemoDummyArm : MonoBehaviour
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Anchor;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Length;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LineRenderer Rope;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform ArmRopeAnchor;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x10D68B8", Offset = "0x10D68B8", VA = "0x10D68B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x10D6980", Offset = "0x10D6980", VA = "0x10D6980")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x10D69E8", Offset = "0x10D69E8", VA = "0x10D69E8")]
		public DemoDummyArm()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class DemoFullStabConfetti : MonoBehaviour
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HVRStabbable Stabbable;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem Confetti;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool OnFullStab;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 point;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 normal;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x10D69F8", Offset = "0x10D69F8", VA = "0x10D69F8")]
		public void Start()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x10D6C24", Offset = "0x10D6C24", VA = "0x10D6C24")]
		private void FullStabbed(HVRStabber arg0, HVRStabbable arg1)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x10D6C3C", Offset = "0x10D6C3C", VA = "0x10D6C3C")]
		private void PopConfetti(Vector3 dir)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x10D6DD0", Offset = "0x10D6DD0", VA = "0x10D6DD0")]
		private void Unstabbed(HVRStabber arg0, HVRStabbable arg1)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x10D6DD4", Offset = "0x10D6DD4", VA = "0x10D6DD4")]
		private void Stabbed(StabArgs stabArgs)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x10D6E6C", Offset = "0x10D6E6C", VA = "0x10D6E6C")]
		public DemoFullStabConfetti()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class DemoGlassRotate : MonoBehaviour
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Timer;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Degrees;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Unlocked;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool DoneRotating;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip SFXOpen;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _elapsed;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x10D6E74", Offset = "0x10D6E74", VA = "0x10D6E74")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x10D6E78", Offset = "0x10D6E78", VA = "0x10D6E78")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x10D6FD4", Offset = "0x10D6FD4", VA = "0x10D6FD4")]
		public void Unlock()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x10D70DC", Offset = "0x10D70DC", VA = "0x10D70DC")]
		public DemoGlassRotate()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class DemoHatchDoor : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Timer;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Degrees;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Unlocked;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool DoneRotating;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip SFXOpen;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _elapsed;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x10D70F0", Offset = "0x10D70F0", VA = "0x10D70F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x10D724C", Offset = "0x10D724C", VA = "0x10D724C")]
		public void Unlock()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x10D7354", Offset = "0x10D7354", VA = "0x10D7354")]
		public DemoHatchDoor()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class DemoHeavyDoor : MonoBehaviour
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody DoorRigidbody;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRRotationTracker ValveTracker;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRRotationLimiter Limiter;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxAngle;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] SFX;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float SFXAngle;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Angle;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion _startRotation;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x10D7368", Offset = "0x10D7368", VA = "0x10D7368")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x10D73A0", Offset = "0x10D73A0", VA = "0x10D73A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x10D7604", Offset = "0x10D7604", VA = "0x10D7604")]
		public DemoHeavyDoor()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class DemoHelper : MonoBehaviour
	{
		[Token(Token = "0x2000146")]
		private class ResetState
		{
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HVRGrabbable Grabbable;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HVRGrabbable Clone;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 Position;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion Rotation;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform Parent;

			[Token(Token = "0x170000D2")]
			public Vector3 Scale
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x10D889C", Offset = "0x10D889C", VA = "0x10D889C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x10D88A8", Offset = "0x10D88A8", VA = "0x10D88A8")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x10D7EB0", Offset = "0x10D7EB0", VA = "0x10D7EB0")]
			public ResetState()
			{
			}
		}

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> Parents;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<HVRGrabbable> Grabbables;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Debug")]
		public bool ForceReset;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<ResetState> _grabbableState;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<HVRGrabbable> _balls;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x10D761C", Offset = "0x10D761C", VA = "0x10D761C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x10D78D8", Offset = "0x10D78D8", VA = "0x10D78D8")]
		private void AddResetGrabbable(Transform parent)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x10D7CAC", Offset = "0x10D7CAC", VA = "0x10D7CAC")]
		private void SaveResetGrabbable(Transform parent, HVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x10D7EB8", Offset = "0x10D7EB8", VA = "0x10D7EB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x10D8620", Offset = "0x10D8620", VA = "0x10D8620")]
		public void BallSpawned(HVRSocket socket, GameObject ball)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x10D7ED8", Offset = "0x10D7ED8", VA = "0x10D7ED8")]
		public void ResetGrabbables()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x10D86EC", Offset = "0x10D86EC", VA = "0x10D86EC")]
		public DemoHelper()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class DemoHolster : HVRSocket
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x10D8940", Offset = "0x10D8940", VA = "0x10D8940", Slot = "61")]
		protected override Quaternion GetRotationOffset(HVRGrabbable grabbable)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x10D8A2C", Offset = "0x10D8A2C", VA = "0x10D8A2C", Slot = "60")]
		protected override Vector3 GetPositionOffset(HVRGrabbable grabbable)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x10D8B18", Offset = "0x10D8B18", VA = "0x10D8B18")]
		public DemoHolster()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class DemoHolsterOrientation : MonoBehaviour
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Orientation;

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x10D8B20", Offset = "0x10D8B20", VA = "0x10D8B20")]
		public DemoHolsterOrientation()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class DemoKeyHologram : MonoBehaviour
	{
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Interval;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LastMove;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Vector3> Positions;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Index;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x10D8B28", Offset = "0x10D8B28", VA = "0x10D8B28")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x10D8B2C", Offset = "0x10D8B2C", VA = "0x10D8B2C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x10D8C1C", Offset = "0x10D8C1C", VA = "0x10D8C1C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x10D8C88", Offset = "0x10D8C88", VA = "0x10D8C88")]
		public DemoKeyHologram()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class DemoKeypad : MonoBehaviour
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent Unlocked;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Code;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshPro Display;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Entry;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ForceUnlock;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _unlocked;

		[Token(Token = "0x170000D3")]
		public int Index
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x10D8D1C", Offset = "0x10D8D1C", VA = "0x10D8D1C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D4")]
		public int MaxLength
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x10D8D34", Offset = "0x10D8D34", VA = "0x10D8D34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x10D8D4C", Offset = "0x10D8D4C", VA = "0x10D8D4C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x10D907C", Offset = "0x10D907C", VA = "0x10D907C", Slot = "5")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x10D9098", Offset = "0x10D9098", VA = "0x10D9098", Slot = "6")]
		protected virtual void OnButtonDown(HVRPhysicsButton button)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x10D9270", Offset = "0x10D9270", VA = "0x10D9270", Slot = "7")]
		protected virtual void Unlock()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x10D9300", Offset = "0x10D9300", VA = "0x10D9300")]
		public DemoKeypad()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class DemoKeypadButton : HVRPhysicsButton
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public char Key;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TextMeshPro TextMeshPro;

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x10D9398", Offset = "0x10D9398", VA = "0x10D9398", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x10D9418", Offset = "0x10D9418", VA = "0x10D9418")]
		public DemoKeypadButton()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class DemoLeverDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _step;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _angle;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro _tm;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x10D9420", Offset = "0x10D9420", VA = "0x10D9420")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x10D9478", Offset = "0x10D9478", VA = "0x10D9478")]
		public void OnStepChanged(int step)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x10D955C", Offset = "0x10D955C", VA = "0x10D955C")]
		public void OnAngleChanged(float angle, float delta)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x10D9644", Offset = "0x10D9644", VA = "0x10D9644")]
		public DemoLeverDisplay()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[RequireComponent(typeof(DemoPassthroughSocket))]
	public class DemoLock : MonoBehaviour
	{
		[Token(Token = "0x200014F")]
		[CompilerGenerated]
		private sealed class <MoveKey>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HVRGrabbable key;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemoLock <>4__this;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 <start>5__2;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Quaternion <startRot>5__3;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsed>5__4;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x10D9DF0", Offset = "0x10D9DF0", VA = "0x10D9DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x10D9E38", Offset = "0x10D9E38", VA = "0x10D9E38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x10D9A00", Offset = "0x10D9A00", VA = "0x10D9A00")]
			[DebuggerHidden]
			public <MoveKey>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x10D9AAC", Offset = "0x10D9AAC", VA = "0x10D9AAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x10D9AB0", Offset = "0x10D9AB0", VA = "0x10D9AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x10D9DF8", Offset = "0x10D9DF8", VA = "0x10D9DF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DemoPassthroughSocket Socket;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRGrabbable FaceGrabbable;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject Face;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform Key;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AnimationTime;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip SFXUnlocked;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip SFXKeyInserted;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float LockThreshold;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent Unlocked;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _unlocked;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x10D964C", Offset = "0x10D964C", VA = "0x10D964C")]
		public void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x10D9728", Offset = "0x10D9728", VA = "0x10D9728")]
		public void Update()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x10D994C", Offset = "0x10D994C", VA = "0x10D994C")]
		private void OnKeyGrabbed(HVRGrabberBase grabber, HVRGrabbable key)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x10D9970", Offset = "0x10D9970", VA = "0x10D9970")]
		[IteratorStateMachine(typeof(<MoveKey>d__13))]
		private IEnumerator MoveKey(HVRGrabbable key)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x10D9A28", Offset = "0x10D9A28", VA = "0x10D9A28")]
		public DemoLock()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[RequireComponent(typeof(HingeJoint))]
	[RequireComponent(typeof(Rigidbody))]
	public class DemoLockedDoor : MonoBehaviour
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HingeJoint _hinge;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MinAngle;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MaxAngle;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool LockOnStart;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x10D9E40", Offset = "0x10D9E40", VA = "0x10D9E40")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x10D9EF4", Offset = "0x10D9EF4", VA = "0x10D9EF4")]
		private void Lock()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x10D9FA8", Offset = "0x10D9FA8", VA = "0x10D9FA8")]
		public void Unlock()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x10DA05C", Offset = "0x10DA05C", VA = "0x10DA05C")]
		public DemoLockedDoor()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class DemoManualTeleport : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform PositionOne;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform PositionTwo;

		[Token(Token = "0x170000D7")]
		public HVRTeleporter Teleporter
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x10DA06C", Offset = "0x10DA06C", VA = "0x10DA06C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x10DA074", Offset = "0x10DA074", VA = "0x10DA074")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x10DA07C", Offset = "0x10DA07C", VA = "0x10DA07C")]
		public void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x10DA1DC", Offset = "0x10DA1DC", VA = "0x10DA1DC")]
		public void GoToOne()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x10DA2E8", Offset = "0x10DA2E8", VA = "0x10DA2E8")]
		public void GoToTwo()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x10DA3F4", Offset = "0x10DA3F4", VA = "0x10DA3F4")]
		public DemoManualTeleport()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class DemoPassthroughSocket : HVRSocket
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x10DA49C", Offset = "0x10DA49C", VA = "0x10DA49C", Slot = "25")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x10DA4C8", Offset = "0x10DA4C8", VA = "0x10DA4C8", Slot = "41")]
		protected override void OnGrabbed(HVRGrabArgs args)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x10DA57C", Offset = "0x10DA57C", VA = "0x10DA57C")]
		public DemoPassthroughSocket()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class DemoPowerUnit : MonoBehaviour
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent PoweredUp;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRSocket LeftSocket;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRSocket RightSocket;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshRenderer LeftLight;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MeshRenderer RightLight;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HVRRotationTracker LeverRotation;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float RequiredAngle;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip SFXPoweredOn;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int RequiredCells;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int SocketedCellCount;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool Engaged;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Material OnMaterial;

		[Token(Token = "0x170000D8")]
		public bool IsPoweredUp
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x10DA584", Offset = "0x10DA584", VA = "0x10DA584")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x10DA594", Offset = "0x10DA594", VA = "0x10DA594")]
		private void Start()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x10DA698", Offset = "0x10DA698", VA = "0x10DA698")]
		private void OnRightSocketGrabbed(HVRGrabberBase arg0, HVRGrabbable arg1)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x10DA72C", Offset = "0x10DA72C", VA = "0x10DA72C")]
		private void OnLeftSocketGrabbed(HVRGrabberBase arg0, HVRGrabbable arg1)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x10DA7C0", Offset = "0x10DA7C0", VA = "0x10DA7C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x10DA950", Offset = "0x10DA950", VA = "0x10DA950")]
		public DemoPowerUnit()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public enum SafeDialState
	{
		[Token(Token = "0x40007A2")]
		CamOne,
		[Token(Token = "0x40007A3")]
		CamTwo,
		[Token(Token = "0x40007A4")]
		CamThree,
		[Token(Token = "0x40007A5")]
		Unlocked
	}
	[Token(Token = "0x2000156")]
	public class DemoSafeDial : HVRRotationTracker
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshPro NumberLabel;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshPro DebugLabel;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool DisplayDebug;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int First;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int Second;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int Third;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int CurrentNumber;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float CamDistance;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float PreviousDistance;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float Tolerance;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float LowerBound;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float UpperBound;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int AccuracyAllowance;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UnityEvent Unlocked;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SafeDialState _state;

		[Token(Token = "0x170000D9")]
		public SafeDialState State
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x10DA9D4", Offset = "0x10DA9D4", VA = "0x10DA9D4")]
			get
			{
				return default(SafeDialState);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x10DA9DC", Offset = "0x10DA9DC", VA = "0x10DA9DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public int NumberOfRotations
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x10DAA94", Offset = "0x10DAA94", VA = "0x10DAA94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DB")]
		public bool IsFirstInRange
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x10DAEA8", Offset = "0x10DAEA8", VA = "0x10DAEA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public bool IsSecondInRange
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x10DAED4", Offset = "0x10DAED4", VA = "0x10DAED4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public bool IsThirdInRange
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x10DAF00", Offset = "0x10DAF00", VA = "0x10DAF00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x10DAAD4", Offset = "0x10DAAD4", VA = "0x10DAAD4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x10DA9E4", Offset = "0x10DA9E4", VA = "0x10DA9E4")]
		private void ComputeBounds()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x10DAEA0", Offset = "0x10DAEA0", VA = "0x10DAEA0", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x10DAE84", Offset = "0x10DAE84", VA = "0x10DAE84")]
		public void ResetLockState(SafeDialState state)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x10DAF28", Offset = "0x10DAF28", VA = "0x10DAF28", Slot = "6")]
		protected override void OnStepChanged(int step, bool raiseEvents)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x10DB348", Offset = "0x10DB348", VA = "0x10DB348", Slot = "7")]
		protected override void OnAngleChanged(float angle, float delta)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x10DB4C8", Offset = "0x10DB4C8", VA = "0x10DB4C8")]
		public DemoSafeDial()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class DemoSafeDoor : MonoBehaviour
	{
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x10DB55C", Offset = "0x10DB55C", VA = "0x10DB55C")]
		public DemoSafeDoor()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class DemoSlidingDoor : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private sealed class <OpenDoorRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DemoSlidingDoor <>4__this;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <elapsed>5__2;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <LockRotateSpeed>5__3;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <time>5__4;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x10DBC4C", Offset = "0x10DBC4C", VA = "0x10DBC4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x10DBC94", Offset = "0x10DBC94", VA = "0x10DBC94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x10DB704", Offset = "0x10DB704", VA = "0x10DB704")]
			[DebuggerHidden]
			public <OpenDoorRoutine>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x10DB740", Offset = "0x10DB740", VA = "0x10DB740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x10DB744", Offset = "0x10DB744", VA = "0x10DB744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x10DBC54", Offset = "0x10DBC54", VA = "0x10DBC54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody LeftDoor;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody RightDoor;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Lock;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LockRotateTime;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float LockRotateAngles;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float OpenOffset;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Speed;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip OpenedClip;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _opened;

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x10DB564", Offset = "0x10DB564", VA = "0x10DB564")]
		public void Start()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x10DB568", Offset = "0x10DB568", VA = "0x10DB568")]
		public void OpenDoors()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x10DB690", Offset = "0x10DB690", VA = "0x10DB690")]
		[IteratorStateMachine(typeof(<OpenDoorRoutine>d__11))]
		private IEnumerator OpenDoorRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x10DB72C", Offset = "0x10DB72C", VA = "0x10DB72C")]
		public DemoSlidingDoor()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class DemoSocketables : HVREnumFlagsSocketable<DemoSocketableItems>
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x10DBC9C", Offset = "0x10DBC9C", VA = "0x10DBC9C")]
		public DemoSocketables()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[Flags]
	public enum DemoSocketableItems
	{
		[Token(Token = "0x40007C5")]
		None = 0,
		[Token(Token = "0x40007C6")]
		Pistol = 1,
		[Token(Token = "0x40007C7")]
		PistolMagazine = 2,
		[Token(Token = "0x40007C8")]
		SMG = 4,
		[Token(Token = "0x40007C9")]
		SMGMagazine = 8,
		[Token(Token = "0x40007CA")]
		PowerCell = 0x10,
		[Token(Token = "0x40007CB")]
		SmallObject = 0x20,
		[Token(Token = "0x40007CC")]
		LargeObject = 0x40,
		[Token(Token = "0x40007CD")]
		DoorKey = 0x80,
		[Token(Token = "0x40007CE")]
		ShotgunShell = 0x100,
		[Token(Token = "0x40007CF")]
		Valve = 0x200,
		[Token(Token = "0x40007D0")]
		Key = 0x400,
		[Token(Token = "0x40007D1")]
		All = -1
	}
	[Token(Token = "0x200015C")]
	public class DemoSocketFilter : HVREnumFlagsSocketFilter<DemoSocketableItems>
	{
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x10DBCE4", Offset = "0x10DBCE4", VA = "0x10DBCE4")]
		public DemoSocketFilter()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class DemoUIManager : MonoBehaviour
	{
		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HVRPlayerController Player;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRCameraRig CameraRig;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRPlayerInputs Inputs;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI SitStandText;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI PauseText;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI ForceGrabText;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI LeftForceText;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI RightForceText;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Slider TurnRateSlider;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Slider SnapTurnSlider;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI TurnRateText;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI SnapRateText;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Toggle SmoothTurnToggle;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Toggle LineGrabTrigger;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public HVRForceGrabber LeftForce;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public HVRForceGrabber RightForce;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public HVRJointHand LeftHand;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public HVRJointHand RightHand;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform leftparent;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform rightParent;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool Paused;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x10DBD2C", Offset = "0x10DBD2C", VA = "0x10DBD2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x10DC9B4", Offset = "0x10DC9B4", VA = "0x10DC9B4")]
		private void OnLineGrabTriggerChanged(bool arg0)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x10DC9DC", Offset = "0x10DC9DC", VA = "0x10DC9DC")]
		public void CalibrateHeight()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x10DCA5C", Offset = "0x10DCA5C", VA = "0x10DCA5C")]
		public void OnSitStandClicked()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x10DCA94", Offset = "0x10DCA94", VA = "0x10DCA94")]
		public void OnForceGrabClicked()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x10DC7F8", Offset = "0x10DC7F8", VA = "0x10DC7F8")]
		private void UpdateForceGrabButton()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x10DC764", Offset = "0x10DC764", VA = "0x10DC764")]
		private void UpdateSitStandButton()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x10DCAC0", Offset = "0x10DCAC0", VA = "0x10DCAC0")]
		public void OnTurnRateChanged(float rate)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x10DCB04", Offset = "0x10DCB04", VA = "0x10DCB04")]
		public void OnSnapTurnRateChanged(float rate)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x10DCB48", Offset = "0x10DCB48", VA = "0x10DCB48")]
		public void OnSmoothTurnChanged(bool smooth)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x10DCB6C", Offset = "0x10DCB6C", VA = "0x10DCB6C")]
		public void OnLeftForceGrabModeClicked()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x10DCBFC", Offset = "0x10DCBFC", VA = "0x10DCBFC")]
		public void OnRightForceGrabModeClicked()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x10DC88C", Offset = "0x10DC88C", VA = "0x10DC88C")]
		private void UpdateLeftForceButton()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x10DC920", Offset = "0x10DC920", VA = "0x10DC920")]
		private void UpdateRightForceButton()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x10DCC8C", Offset = "0x10DCC8C", VA = "0x10DCC8C")]
		public void TogglePause()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x10DCE30", Offset = "0x10DCE30", VA = "0x10DCE30")]
		public DemoUIManager()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class DemoValveHologram : MonoBehaviour
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Interval;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion StartRotation;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Quaternion EndRotation;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion _current;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion _next;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _elapsed;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x108E7A8", Offset = "0x108E7A8", VA = "0x108E7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x108E7BC", Offset = "0x108E7BC", VA = "0x108E7BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x108E86C", Offset = "0x108E86C", VA = "0x108E86C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x108E8D8", Offset = "0x108E8D8", VA = "0x108E8D8")]
		public DemoValveHologram()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[RequireComponent(typeof(DemoPassthroughSocket))]
	public class DemoValveLock : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		[CompilerGenerated]
		private sealed class <MoveKey>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HVRGrabbable key;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemoValveLock <>4__this;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 <start>5__2;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Quaternion <startRot>5__3;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsed>5__4;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x108ED40", Offset = "0x108ED40", VA = "0x108ED40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x108ED88", Offset = "0x108ED88", VA = "0x108ED88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x108EA80", Offset = "0x108EA80", VA = "0x108EA80")]
			[DebuggerHidden]
			public <MoveKey>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x108EAB8", Offset = "0x108EAB8", VA = "0x108EAB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x108EABC", Offset = "0x108EABC", VA = "0x108EABC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x108ED48", Offset = "0x108ED48", VA = "0x108ED48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DemoPassthroughSocket Socket;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HVRGrabbable FaceGrabbable;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AnimationTime;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x108E8EC", Offset = "0x108E8EC", VA = "0x108E8EC")]
		public void Start()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x108E9C8", Offset = "0x108E9C8", VA = "0x108E9C8")]
		public void Update()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x108E9CC", Offset = "0x108E9CC", VA = "0x108E9CC")]
		private void OnValveGrabbed(HVRGrabberBase grabber, HVRGrabbable key)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x108E9F0", Offset = "0x108E9F0", VA = "0x108E9F0")]
		[IteratorStateMachine(typeof(<MoveKey>d__6))]
		private IEnumerator MoveKey(HVRGrabbable key)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x108EAA8", Offset = "0x108EAA8", VA = "0x108EAA8")]
		public DemoValveLock()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000162")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000163")]
		private class CameraState
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x108EDE4", Offset = "0x108EDE4", VA = "0x108EDE4")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x108F324", Offset = "0x108F324", VA = "0x108F324")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x108F3A4", Offset = "0x108F3A4", VA = "0x108F3A4")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x108F42C", Offset = "0x108F42C", VA = "0x108F42C")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x108F650", Offset = "0x108F650", VA = "0x108F650")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		[Header("Movement Settings")]
		public float boost;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x108ED90", Offset = "0x108ED90", VA = "0x108ED90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x108EE68", Offset = "0x108EE68", VA = "0x108EE68")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x108F098", Offset = "0x108F098", VA = "0x108F098")]
		private void Update()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x108F474", Offset = "0x108F474", VA = "0x108F474")]
		public SimpleCameraController()
		{
		}
	}
}
