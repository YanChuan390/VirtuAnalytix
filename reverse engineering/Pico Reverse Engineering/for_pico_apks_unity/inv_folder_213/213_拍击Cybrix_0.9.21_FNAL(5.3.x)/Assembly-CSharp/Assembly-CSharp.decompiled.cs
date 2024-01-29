using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Cybrix;
using Cybrix.Audio;
using Cybrix.DataStorage;
using Cybrix.Gameplay.Levels;
using Cybrix.Interaction;
using Cybrix.Leaderboards;
using Cybrix.Leaderboards.UI;
using Cybrix.UI;
using DG.Tweening;
using Facebook.WitAi;
using Facebook.WitAi.Lib;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Sirenix.OdinInspector;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityStandardAssets.Utility;
using VRUiKits.Utils;
using Zenject;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ParticleEffectsLibrary : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleEffectsLibrary GlobalAccess;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TotalEffects;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int CurrentParticleEffectIndex;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int CurrentParticleEffectNum;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] ParticleEffectSpawnOffsets;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] ParticleEffectLifetimes;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleEffectPrefabs;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string effectNameString;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Transform> currentActivePEList;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 spawnPosition;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF3ACA0", Offset = "0xF3ACA0", VA = "0xF3ACA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF3B070", Offset = "0xF3B070", VA = "0xF3B070")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF3B074", Offset = "0xF3B074", VA = "0xF3B074")]
	public string GetCurrentPENameString()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF3B2E8", Offset = "0xF3B2E8", VA = "0xF3B2E8")]
	public void PreviousParticleEffect()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF3B6C4", Offset = "0xF3B6C4", VA = "0xF3B6C4")]
	public void NextParticleEffect()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF3BAB0", Offset = "0xF3BAB0", VA = "0xF3BAB0")]
	public void SpawnParticleEffect(Vector3 positionInWorldToSpawn)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF3BDF4", Offset = "0xF3BDF4", VA = "0xF3BDF4")]
	public ParticleEffectsLibrary()
	{
	}
}
[Token(Token = "0x2000003")]
public enum ButtonTypes
{
	[Token(Token = "0x400000C")]
	NotDefined,
	[Token(Token = "0x400000D")]
	Previous,
	[Token(Token = "0x400000E")]
	Next
}
[Token(Token = "0x2000004")]
public class PEButtonScript : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button myButton;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ButtonTypes ButtonType;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF3BE8C", Offset = "0xF3BE8C", VA = "0xF3BE8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF3BEF4", Offset = "0xF3BEF4", VA = "0xF3BEF4", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF3C03C", Offset = "0xF3C03C", VA = "0xF3C03C", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF3C134", Offset = "0xF3C134", VA = "0xF3C134")]
	public void OnButtonClicked()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF3C1A8", Offset = "0xF3C1A8", VA = "0xF3C1A8")]
	public PEButtonScript()
	{
	}
}
[Token(Token = "0x2000005")]
public class PEDestoryTimed : MonoBehaviour
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0xF3C1B0", Offset = "0xF3C1B0", VA = "0xF3C1B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xF3C1B4", Offset = "0xF3C1B4", VA = "0xF3C1B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF3C1B8", Offset = "0xF3C1B8", VA = "0xF3C1B8")]
	public PEDestoryTimed()
	{
	}
}
[Token(Token = "0x2000006")]
public class UICanvasManager : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UICanvasManager GlobalAccess;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool MouseOverButton;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text PENameText;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text ToolTipText;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RaycastHit rayHit;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xF3C1C0", Offset = "0xF3C1C0", VA = "0xF3C1C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF3C218", Offset = "0xF3C218", VA = "0xF3C218")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF3C2D4", Offset = "0xF3C2D4", VA = "0xF3C2D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF3BF54", Offset = "0xF3BF54", VA = "0xF3BF54")]
	public void UpdateToolTip(ButtonTypes toolTipType)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF3C090", Offset = "0xF3C090", VA = "0xF3C090")]
	public void ClearToolTip()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF3C3F8", Offset = "0xF3C3F8", VA = "0xF3C3F8")]
	private void SelectPreviousPE()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xF3C4C8", Offset = "0xF3C4C8", VA = "0xF3C4C8")]
	private void SelectNextPE()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF3C338", Offset = "0xF3C338", VA = "0xF3C338")]
	private void SpawnCurrentParticleEffect()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF3C18C", Offset = "0xF3C18C", VA = "0xF3C18C")]
	public void UIButtonClick(ButtonTypes buttonTypeClicked)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF3C598", Offset = "0xF3C598", VA = "0xF3C598")]
	public UICanvasManager()
	{
	}
}
[Token(Token = "0x2000007")]
public class ETFXProjectileScript : MonoBehaviour
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject impactParticle;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject projectileParticle;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject muzzleParticle;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] trailParticles;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Vector3 impactNormal;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool hasCollided;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF3C5A0", Offset = "0xF3C5A0", VA = "0xF3C5A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xF3C7C8", Offset = "0xF3C7C8", VA = "0xF3C7C8")]
	private void OnCollisionEnter(Collision hit)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xF3CBE0", Offset = "0xF3CBE0", VA = "0xF3CBE0")]
	public ETFXProjectileScript()
	{
	}
}
[Token(Token = "0x2000008")]
public class ETFXSceneManager : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool GUIHide;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool GUIHide2;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool GUIHide3;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF3CBE8", Offset = "0xF3CBE8", VA = "0xF3CBE8")]
	public void LoadScene1()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xF3CC50", Offset = "0xF3CC50", VA = "0xF3CC50")]
	public void LoadScene2()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xF3CCB8", Offset = "0xF3CCB8", VA = "0xF3CCB8")]
	public void LoadScene3()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF3CD20", Offset = "0xF3CD20", VA = "0xF3CD20")]
	public void LoadScene4()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xF3CD88", Offset = "0xF3CD88", VA = "0xF3CD88")]
	public void LoadScene5()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xF3CDF0", Offset = "0xF3CDF0", VA = "0xF3CDF0")]
	public void LoadScene6()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xF3CE58", Offset = "0xF3CE58", VA = "0xF3CE58")]
	public void LoadScene7()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xF3CEC0", Offset = "0xF3CEC0", VA = "0xF3CEC0")]
	public void LoadScene8()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xF3CF28", Offset = "0xF3CF28", VA = "0xF3CF28")]
	public void LoadScene9()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xF3CF90", Offset = "0xF3CF90", VA = "0xF3CF90")]
	public void LoadScene10()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xF3CFF8", Offset = "0xF3CFF8", VA = "0xF3CFF8")]
	public void LoadScene11()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xF3D060", Offset = "0xF3D060", VA = "0xF3D060")]
	public void LoadScene12()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xF3D0C8", Offset = "0xF3D0C8", VA = "0xF3D0C8")]
	public void LoadScene13()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xF3D130", Offset = "0xF3D130", VA = "0xF3D130")]
	private void Update()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xF3D290", Offset = "0xF3D290", VA = "0xF3D290")]
	public ETFXSceneManager()
	{
	}
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoStopLoopedEffect : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float effectDuration;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float d;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xF3D298", Offset = "0xF3D298", VA = "0xF3D298")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xF3D2A4", Offset = "0xF3D2A4", VA = "0xF3D2A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xF3D3BC", Offset = "0xF3D3BC", VA = "0xF3D3BC")]
	public CFX_AutoStopLoopedEffect()
	{
	}
}
[Token(Token = "0x200000A")]
public class CFX_Demo : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xF3EAD0", Offset = "0xF3EAD0", VA = "0xF3EAD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xF3EB18", Offset = "0xF3EB18", VA = "0xF3EB18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xF3E394", Offset = "0xF3E394", VA = "0xF3E394")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xF3E8EC", Offset = "0xF3E8EC", VA = "0xF3E8EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF3E8F0", Offset = "0xF3E8F0", VA = "0xF3E8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xF3EAD8", Offset = "0xF3EAD8", VA = "0xF3EAD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool orderedSpawns;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float step;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float order;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material groundMat;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material waterMat;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleExamples;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, float> ParticlesYOffsetD;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int exampleIndex;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string randomSpawnsDelay;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool randomSpawns;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool slowMo;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xF3D3CC", Offset = "0xF3D3CC", VA = "0xF3D3CC")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xF3D518", Offset = "0xF3D518", VA = "0xF3D518")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xF3D7C0", Offset = "0xF3D7C0", VA = "0xF3D7C0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xF3E320", Offset = "0xF3E320", VA = "0xF3E320")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__15))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xF3E3BC", Offset = "0xF3E3BC", VA = "0xF3E3BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xF3E008", Offset = "0xF3E008", VA = "0xF3E008")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xF3E198", Offset = "0xF3E198", VA = "0xF3E198")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xF3E404", Offset = "0xF3E404", VA = "0xF3E404")]
	public CFX_Demo()
	{
	}
}
[Token(Token = "0x200000C")]
public class CFX_Demo_New : MonoBehaviour
{
	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <CheckForDeletedParticles>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo_New <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xF3FB08", Offset = "0xF3FB08", VA = "0xF3FB08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xF3FB50", Offset = "0xF3FB50", VA = "0xF3FB50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xF3F814", Offset = "0xF3F814", VA = "0xF3F814")]
		[DebuggerHidden]
		public <CheckForDeletedParticles>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xF3F98C", Offset = "0xF3F98C", VA = "0xF3F98C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xF3F990", Offset = "0xF3F990", VA = "0xF3F990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xF3FB10", Offset = "0xF3FB10", VA = "0xF3FB10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer groundRenderer;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider groundCollider;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[Space]
	public Image slowMoBtn;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text slowMoLabel;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image camRotBtn;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text camRotLabel;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image groundBtn;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text groundLabel;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space]
	public Text EffectLabel;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text EffectIndexLabel;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject[] ParticleExamples;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int exampleIndex;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool slowMo;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 defaultCamPosition;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Quaternion defaultCamRotation;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> onScreenParticles;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xF3EB20", Offset = "0xF3EB20", VA = "0xF3EB20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xF3EF04", Offset = "0xF3EF04", VA = "0xF3EF04")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xF3F568", Offset = "0xF3F568", VA = "0xF3F568")]
	public void OnToggleGround()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xF3F628", Offset = "0xF3F628", VA = "0xF3F628")]
	public void OnToggleCamera()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xF3F6F8", Offset = "0xF3F6F8", VA = "0xF3F6F8")]
	public void OnToggleSlowMo()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xF3F798", Offset = "0xF3F798", VA = "0xF3F798")]
	public void OnPreviousEffect()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xF3F79C", Offset = "0xF3F79C", VA = "0xF3F79C")]
	public void OnNextEffect()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xF3EDD8", Offset = "0xF3EDD8", VA = "0xF3EDD8")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xF3F340", Offset = "0xF3F340", VA = "0xF3F340")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xF3F7A0", Offset = "0xF3F7A0", VA = "0xF3F7A0")]
	[IteratorStateMachine(typeof(<CheckForDeletedParticles>d__25))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xF3F1A8", Offset = "0xF3F1A8", VA = "0xF3F1A8")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xF3F1DC", Offset = "0xF3F1DC", VA = "0xF3F1DC")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xF3F210", Offset = "0xF3F210", VA = "0xF3F210")]
	private void destroyParticles()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xF3F83C", Offset = "0xF3F83C", VA = "0xF3F83C")]
	public CFX_Demo_New()
	{
	}
}
[Token(Token = "0x200000F")]
public class CFX_Demo_RandomDir : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 min;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 max;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xF3FB58", Offset = "0xF3FB58", VA = "0xF3FB58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xF3FBE0", Offset = "0xF3FBE0", VA = "0xF3FBE0")]
	public CFX_Demo_RandomDir()
	{
	}
}
[Token(Token = "0x2000010")]
public class CFX_Demo_RandomDirectionTranslate : MonoBehaviour
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 baseDir;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xF3FBF8", Offset = "0xF3FBF8", VA = "0xF3FBF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xF3FD3C", Offset = "0xF3FD3C", VA = "0xF3FD3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xF3FE18", Offset = "0xF3FE18", VA = "0xF3FE18")]
	public CFX_Demo_RandomDirectionTranslate()
	{
	}
}
[Token(Token = "0x2000011")]
public class CFX_Demo_RotateCamera : MonoBehaviour
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool rotating;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rotationCenter;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xF3FEB4", Offset = "0xF3FEB4", VA = "0xF3FEB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xF3FFF0", Offset = "0xF3FFF0", VA = "0xF3FFF0")]
	public CFX_Demo_RotateCamera()
	{
	}
}
[Token(Token = "0x2000012")]
public class CFX_Demo_Translate : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 rotation;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xF4004C", Offset = "0xF4004C", VA = "0xF4004C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xF400EC", Offset = "0xF400EC", VA = "0xF400EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xF4015C", Offset = "0xF4015C", VA = "0xF4015C")]
	public CFX_Demo_Translate()
	{
	}
}
[Token(Token = "0x2000013")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_AutoDestructShuriken <>4__this;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem <ps>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xF40454", Offset = "0xF40454", VA = "0xF40454", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xF4049C", Offset = "0xF4049C", VA = "0xF4049C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xF40298", Offset = "0xF40298", VA = "0xF40298")]
		[DebuggerHidden]
		public <CheckIfAlive>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xF402C8", Offset = "0xF402C8", VA = "0xF402C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xF402CC", Offset = "0xF402CC", VA = "0xF402CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xF4045C", Offset = "0xF4045C", VA = "0xF4045C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool OnlyDeactivate;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xF401D8", Offset = "0xF401D8", VA = "0xF401D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xF40224", Offset = "0xF40224", VA = "0xF40224")]
	[IteratorStateMachine(typeof(<CheckIfAlive>d__2))]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xF402C0", Offset = "0xF402C0", VA = "0xF402C0")]
	public CFX_AutoDestructShuriken()
	{
	}
}
[Token(Token = "0x2000015")]
public class CFX_AutodestructWhenNoChildren : MonoBehaviour
{
	[Token(Token = "0x6000068")]
	[Address(RVA = "0xF404A4", Offset = "0xF404A4", VA = "0xF404A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xF4053C", Offset = "0xF4053C", VA = "0xF4053C")]
	public CFX_AutodestructWhenNoChildren()
	{
	}
}
[Token(Token = "0x2000016")]
public class CFX_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotation;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Space space;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xF40544", Offset = "0xF40544", VA = "0xF40544")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xF405AC", Offset = "0xF405AC", VA = "0xF405AC")]
	public CFX_AutoRotate()
	{
	}
}
[Token(Token = "0x2000017")]
public class CFX_InspectorHelp : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Locked;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Title;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string HelpText;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int MsgType;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xF405BC", Offset = "0xF405BC", VA = "0xF405BC")]
	[ContextMenu("Unlock editing")]
	private void Unlock()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xF405C4", Offset = "0xF405C4", VA = "0xF405C4")]
	public CFX_InspectorHelp()
	{
	}
}
[Token(Token = "0x2000018")]
[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float finalIntensity;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float baseIntensity;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autodestruct;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float p_lifetime;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float p_delay;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xF405CC", Offset = "0xF405CC", VA = "0xF405CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xF4062C", Offset = "0xF4062C", VA = "0xF4062C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xF406A8", Offset = "0xF406A8", VA = "0xF406A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xF4080C", Offset = "0xF4080C", VA = "0xF4080C")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x2000019")]
public class CFX_ShurikenThreadFix : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <WaitFrame>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_ShurikenThreadFix <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xF40A60", Offset = "0xF40A60", VA = "0xF40A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xF40AA8", Offset = "0xF40AA8", VA = "0xF40AA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xF4097C", Offset = "0xF4097C", VA = "0xF4097C")]
		[DebuggerHidden]
		public <WaitFrame>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xF409AC", Offset = "0xF409AC", VA = "0xF409AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xF409B0", Offset = "0xF409B0", VA = "0xF409B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xF40A68", Offset = "0xF40A68", VA = "0xF40A68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] systems;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xF4081C", Offset = "0xF4081C", VA = "0xF4081C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xF40908", Offset = "0xF40908", VA = "0xF40908")]
	[IteratorStateMachine(typeof(<WaitFrame>d__2))]
	private IEnumerator WaitFrame()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xF409A4", Offset = "0xF409A4", VA = "0xF409A4")]
	public CFX_ShurikenThreadFix()
	{
	}
}
[Token(Token = "0x200001B")]
public class CFX_SpawnSystem : MonoBehaviour
{
	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CFX_SpawnSystem instance;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool spawnAsChildren;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool onlyGetInactiveObjects;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool instantiateIfNeeded;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool allObjectsLoaded;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x17000009")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xF41A40", Offset = "0xF41A40", VA = "0xF41A40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xF40AB0", Offset = "0xF40AB0", VA = "0xF40AB0")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xF41230", Offset = "0xF41230", VA = "0xF41230")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xF415DC", Offset = "0xF415DC", VA = "0xF415DC")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xF41298", Offset = "0xF41298", VA = "0xF41298")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xF41634", Offset = "0xF41634", VA = "0xF41634")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xF410D0", Offset = "0xF410D0", VA = "0xF410D0")]
	private void increasePoolCursor(int uniqueId)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xF41A94", Offset = "0xF41A94", VA = "0xF41A94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xF41B94", Offset = "0xF41B94", VA = "0xF41B94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xF41C14", Offset = "0xF41C14", VA = "0xF41C14")]
	public CFX_SpawnSystem()
	{
	}
}
[Token(Token = "0x200001C")]
public class Fan : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _speed;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xF41D60", Offset = "0xF41D60", VA = "0xF41D60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xF41DB8", Offset = "0xF41DB8", VA = "0xF41DB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xF41DFC", Offset = "0xF41DFC", VA = "0xF41DFC")]
	public Fan()
	{
	}
}
[Token(Token = "0x200001D")]
public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(5f)]
	public Material m_Material;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(5f)]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProceduralTexture2D proceduralTexAssetNormal;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProceduralTexture2D proceduralTexAssetMask;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xF41E0C", Offset = "0xF41E0C", VA = "0xF41E0C")]
	public void SyncMatWithProceduralTextureAsset()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xF424A8", Offset = "0xF424A8", VA = "0xF424A8")]
	public ApplyProceduralTextureProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[CreateAssetMenu(fileName = "New Procedural Texture 2D", menuName = "", order = 1)]
public class ProceduralTexture2D : ScriptableObject
{
	[Token(Token = "0x200001F")]
	public enum TextureType
	{
		[Token(Token = "0x4000091")]
		Color,
		[Token(Token = "0x4000092")]
		Normal,
		[Token(Token = "0x4000093")]
		Other
	}

	[Token(Token = "0x2000020")]
	public enum CompressionLevel
	{
		[Token(Token = "0x4000095")]
		None = -1,
		[Token(Token = "0x4000096")]
		LowQuality = 0,
		[Token(Token = "0x4000097")]
		NormalQuality = 50,
		[Token(Token = "0x4000098")]
		HighQuality = 100
	}

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureType type;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool includeAlpha;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool generateMipMaps;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FilterMode filterMode;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int anisoLevel;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CompressionLevel compressionQuality;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D Tinput;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D invT;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 colorSpaceOrigin;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 colorSpaceVector1;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 colorSpaceVector2;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 colorSpaceVector3;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector4 compressionScalers;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public long memoryUsageBytes;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D currentInput;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextureType currentType;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool currentIncludeAlpha;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool currentGenerateMipMaps;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FilterMode currentFilterMode;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int currentAnisoLevel;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CompressionLevel currentCompressionQuality;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xF424B0", Offset = "0xF424B0", VA = "0xF424B0")]
	public ProceduralTexture2D()
	{
	}
}
[Token(Token = "0x2000021")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xF4259C", Offset = "0xF4259C", VA = "0xF4259C")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xF426DC", Offset = "0xF426DC", VA = "0xF426DC")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xF42A0C", Offset = "0xF42A0C", VA = "0xF42A0C")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xF42BA4", Offset = "0xF42BA4", VA = "0xF42BA4", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xF42BD0", Offset = "0xF42BD0", VA = "0xF42BD0")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000022")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xF42C38", Offset = "0xF42C38", VA = "0xF42C38")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xF42CB4", Offset = "0xF42CB4", VA = "0xF42CB4")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xF42E24", Offset = "0xF42E24", VA = "0xF42E24")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000023")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700000A")]
	public bool IsVisible
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xF42E2C", Offset = "0xF42E2C", VA = "0xF42E2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xF42E34", Offset = "0xF42E34", VA = "0xF42E34")]
		set
		{
		}
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xF42F58", Offset = "0xF42F58", VA = "0xF42F58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xF43148", Offset = "0xF43148", VA = "0xF43148")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xF43150", Offset = "0xF43150", VA = "0xF43150")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000024")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x2000025")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xF43D68", Offset = "0xF43D68", VA = "0xF43D68")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000026")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMax;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMin;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float LatencyWeight;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int MaxSamples;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xF43D70", Offset = "0xF43D70", VA = "0xF43D70")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xF43F64", Offset = "0xF43F64", VA = "0xF43F64")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xF43164", Offset = "0xF43164", VA = "0xF43164")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xF432BC", Offset = "0xF432BC", VA = "0xF432BC")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xF436B8", Offset = "0xF436B8", VA = "0xF436B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xF4360C", Offset = "0xF4360C", VA = "0xF4360C")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xF43A4C", Offset = "0xF43A4C", VA = "0xF43A4C")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF43EA4", Offset = "0xF43EA4", VA = "0xF43EA4")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000027")]
public class P2PManager
{
	[Token(Token = "0x2000028")]
	private enum MessageType : byte
	{
		[Token(Token = "0x40000B0")]
		Update = 1
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xF44004", Offset = "0xF44004", VA = "0xF44004")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xF440D0", Offset = "0xF440D0", VA = "0xF440D0")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xF44310", Offset = "0xF44310", VA = "0xF44310")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xF44458", Offset = "0xF44458", VA = "0xF44458")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xF445A8", Offset = "0xF445A8", VA = "0xF445A8")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xF44794", Offset = "0xF44794", VA = "0xF44794")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xF44B4C", Offset = "0xF44B4C", VA = "0xF44B4C")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xF44DD4", Offset = "0xF44DD4", VA = "0xF44DD4")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xF44958", Offset = "0xF44958", VA = "0xF44958")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xF44D20", Offset = "0xF44D20", VA = "0xF44D20")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xF44A24", Offset = "0xF44A24", VA = "0xF44A24")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xF44FFC", Offset = "0xF44FFC", VA = "0xF44FFC")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xF44994", Offset = "0xF44994", VA = "0xF44994")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xF44D58", Offset = "0xF44D58", VA = "0xF44D58")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xF44ABC", Offset = "0xF44ABC", VA = "0xF44ABC")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xF45078", Offset = "0xF45078", VA = "0xF45078")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000029")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xF450F4", Offset = "0xF450F4", VA = "0xF450F4", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xF454E0", Offset = "0xF454E0", VA = "0xF454E0", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xF45504", Offset = "0xF45504", VA = "0xF45504", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xF458B4", Offset = "0xF458B4", VA = "0xF458B4")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xF45A14", Offset = "0xF45A14", VA = "0xF45A14")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xF45A90", Offset = "0xF45A90", VA = "0xF45A90")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xF45B7C", Offset = "0xF45B7C", VA = "0xF45B7C")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x200002A")]
public class RemotePlayer
{
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xF45C60", Offset = "0xF45C60", VA = "0xF45C60")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x200002B")]
public class RoomManager
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xF45C68", Offset = "0xF45C68", VA = "0xF45C68")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xF45D4C", Offset = "0xF45D4C", VA = "0xF45D4C")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xF45F4C", Offset = "0xF45F4C", VA = "0xF45F4C")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xF46064", Offset = "0xF46064", VA = "0xF46064")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xF4611C", Offset = "0xF4611C", VA = "0xF4611C")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xF46508", Offset = "0xF46508", VA = "0xF46508")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xF45F78", Offset = "0xF45F78", VA = "0xF45F78")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xF46580", Offset = "0xF46580", VA = "0xF46580")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xF46CFC", Offset = "0xF46CFC", VA = "0xF46CFC")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xF4703C", Offset = "0xF4703C", VA = "0xF4703C")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xF468AC", Offset = "0xF468AC", VA = "0xF468AC")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x200002C")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum State
	{
		[Token(Token = "0x40000E8")]
		INITIALIZING,
		[Token(Token = "0x40000E9")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x40000EA")]
		CREATING_A_ROOM,
		[Token(Token = "0x40000EB")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x40000EC")]
		JOINING_A_ROOM,
		[Token(Token = "0x40000ED")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x40000EE")]
		LEAVING_A_ROOM,
		[Token(Token = "0x40000EF")]
		SHUTDOWN
	}

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700000B")]
	public static State CurrentState
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xF48DFC", Offset = "0xF48DFC", VA = "0xF48DFC")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700000C")]
	public static ulong MyID
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xF44198", Offset = "0xF44198", VA = "0xF44198")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000D")]
	public static string MyOculusID
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xF48E60", Offset = "0xF48E60", VA = "0xF48E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xF4551C", Offset = "0xF4551C", VA = "0xF4551C", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xF45128", Offset = "0xF45128", VA = "0xF45128", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xF47AE4", Offset = "0xF47AE4", VA = "0xF47AE4")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xF45500", Offset = "0xF45500", VA = "0xF45500", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xF47C6C", Offset = "0xF47C6C", VA = "0xF47C6C")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xF47D64", Offset = "0xF47D64", VA = "0xF47D64")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xF4854C", Offset = "0xF4854C", VA = "0xF4854C")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xF48964", Offset = "0xF48964", VA = "0xF48964")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xF48B88", Offset = "0xF48B88", VA = "0xF48B88")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xF48D94", Offset = "0xF48D94", VA = "0xF48D94")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xF47970", Offset = "0xF47970", VA = "0xF47970")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xF45EA0", Offset = "0xF45EA0", VA = "0xF45EA0")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xF46208", Offset = "0xF46208", VA = "0xF46208")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xF48F64", Offset = "0xF48F64", VA = "0xF48F64")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xF46448", Offset = "0xF46448", VA = "0xF46448")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xF470A4", Offset = "0xF470A4", VA = "0xF470A4")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xF4749C", Offset = "0xF4749C", VA = "0xF4749C")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xF4757C", Offset = "0xF4757C", VA = "0xF4757C")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xF4425C", Offset = "0xF4425C", VA = "0xF4425C")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xF47228", Offset = "0xF47228", VA = "0xF47228")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xF472B0", Offset = "0xF472B0", VA = "0xF472B0")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xF490E8", Offset = "0xF490E8", VA = "0xF490E8")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xF493AC", Offset = "0xF493AC", VA = "0xF493AC")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xF478F8", Offset = "0xF478F8", VA = "0xF478F8")]
	[MonoPInvokeCallback(typeof(CAPI.FilterCallback))]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xF44380", Offset = "0xF44380", VA = "0xF44380")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xF45BD8", Offset = "0xF45BD8", VA = "0xF45BD8")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x200002E")]
public class VoipManager
{
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xF47A18", Offset = "0xF47A18", VA = "0xF47A18")]
	public VoipManager()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xF492E4", Offset = "0xF492E4", VA = "0xF492E4")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xF48D24", Offset = "0xF48D24", VA = "0xF48D24")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xF496E8", Offset = "0xF496E8", VA = "0xF496E8")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xF49838", Offset = "0xF49838", VA = "0xF49838")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200002F")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xF49A24", Offset = "0xF49A24", VA = "0xF49A24")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xF49AA8", Offset = "0xF49AA8", VA = "0xF49AA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xF49BEC", Offset = "0xF49BEC", VA = "0xF49BEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xF49C40", Offset = "0xF49C40", VA = "0xF49C40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xF49AD8", Offset = "0xF49AD8", VA = "0xF49AD8")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xF49CF0", Offset = "0xF49CF0", VA = "0xF49CF0")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xF49D08", Offset = "0xF49D08", VA = "0xF49D08")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class AvatarLayer
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xF49D10", Offset = "0xF49D10", VA = "0xF49D10")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000031")]
public class PacketRecordSettings
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xF49D18", Offset = "0xF49D18", VA = "0xF49D18")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000032")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000033")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xF4CE10", Offset = "0xF4CE10", VA = "0xF4CE10")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x2000034")]
	public enum HandType
	{
		[Token(Token = "0x4000151")]
		Right,
		[Token(Token = "0x4000152")]
		Left,
		[Token(Token = "0x4000153")]
		Max
	}

	[Token(Token = "0x2000035")]
	public enum HandJoint
	{
		[Token(Token = "0x4000155")]
		HandBase,
		[Token(Token = "0x4000156")]
		IndexBase,
		[Token(Token = "0x4000157")]
		IndexTip,
		[Token(Token = "0x4000158")]
		ThumbBase,
		[Token(Token = "0x4000159")]
		ThumbTip,
		[Token(Token = "0x400015A")]
		Max
	}

	[Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xF4EF58", Offset = "0xF4EF58", VA = "0xF4EF58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xF4EFA0", Offset = "0xF4EFA0", VA = "0xF4EFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xF4EA14", Offset = "0xF4EA14", VA = "0xF4EA14")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xF4EDB0", Offset = "0xF4EDB0", VA = "0xF4EDB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xF4EDB4", Offset = "0xF4EDB4", VA = "0xF4EDB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xF4EF60", Offset = "0xF4EF60", VA = "0xF4EF60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Avatar")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Capabilities")]
	public bool EnableBody;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("Network")]
	public bool RecordPackets;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Visibility")]
	public bool StartWithControllers;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("Performance")]
	[Tooltip("LOD mesh complexity and texture resolution. Highest LOD recommended on PC and simple mobile apps. Medium LOD recommended on mobile devices or for background characters on PC. Lowest LOD recommended for background characters on mobile.")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Tooltip("Enable to use combined meshes to reduce draw calls. Currently only available on mobile devices. Will be forced to false on PC.")]
	private bool CombineMeshes;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[Tooltip("Enable to use transparent queue, disable to use geometry queue. Requires restart to take effect.")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Shaders")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("Other")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[Tooltip("Enable laughter detection and animation as part of OVRLipSync.")]
	public bool EnableLaughter;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x4000131")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x4000133")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x4000134")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x4000135")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x4000136")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x4000137")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xF49D2C", Offset = "0xF49D2C", VA = "0xF49D2C")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xF4A1C0", Offset = "0xF4A1C0", VA = "0xF4A1C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xF4A258", Offset = "0xF4A258", VA = "0xF4A258")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xF4A2B4", Offset = "0xF4A2B4", VA = "0xF4A2B4")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xF4A3C8", Offset = "0xF4A3C8", VA = "0xF4A3C8")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xF4A4A4", Offset = "0xF4A4A4", VA = "0xF4A4A4")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xF4A574", Offset = "0xF4A574", VA = "0xF4A574")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xF4A744", Offset = "0xF4A744", VA = "0xF4A744")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xF4A80C", Offset = "0xF4A80C", VA = "0xF4A80C")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xF4A880", Offset = "0xF4A880", VA = "0xF4A880")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xF4A938", Offset = "0xF4A938", VA = "0xF4A938")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xF4A9C0", Offset = "0xF4A9C0", VA = "0xF4A9C0")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xF4AA64", Offset = "0xF4AA64", VA = "0xF4AA64")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xF4AA7C", Offset = "0xF4AA7C", VA = "0xF4AA7C")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x60000FE")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xF4AE88", Offset = "0xF4AE88", VA = "0xF4AE88")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xF4B1B4", Offset = "0xF4B1B4", VA = "0xF4B1B4")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xF4B38C", Offset = "0xF4B38C", VA = "0xF4B38C")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xF4B5C8", Offset = "0xF4B5C8", VA = "0xF4B5C8")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xF4B6FC", Offset = "0xF4B6FC", VA = "0xF4B6FC")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xF4BA48", Offset = "0xF4BA48", VA = "0xF4BA48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xF4BD68", Offset = "0xF4BD68", VA = "0xF4BD68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xF4C838", Offset = "0xF4C838", VA = "0xF4C838")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xF4C87C", Offset = "0xF4C87C", VA = "0xF4C87C")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xF45AD4", Offset = "0xF45AD4", VA = "0xF45AD4")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xF4B9A0", Offset = "0xF4B9A0", VA = "0xF4B9A0")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xF4C8A8", Offset = "0xF4C8A8", VA = "0xF4C8A8")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xF4C154", Offset = "0xF4C154", VA = "0xF4C154")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xF4CB34", Offset = "0xF4CB34", VA = "0xF4CB34")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xF4C958", Offset = "0xF4C958", VA = "0xF4C958")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xF4CE84", Offset = "0xF4CE84", VA = "0xF4CE84")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xF4D308", Offset = "0xF4D308", VA = "0xF4D308")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xF4D5D8", Offset = "0xF4D5D8", VA = "0xF4D5D8")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xF4D710", Offset = "0xF4D710", VA = "0xF4D710")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xF4D8DC", Offset = "0xF4D8DC", VA = "0xF4D8DC")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xF4C310", Offset = "0xF4C310", VA = "0xF4C310")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xF4D9A4", Offset = "0xF4D9A4", VA = "0xF4D9A4")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xF4C164", Offset = "0xF4C164", VA = "0xF4C164")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xF4DA80", Offset = "0xF4DA80", VA = "0xF4DA80")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xF4E0B0", Offset = "0xF4E0B0", VA = "0xF4E0B0")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xF4E538", Offset = "0xF4E538", VA = "0xF4E538")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xF4E560", Offset = "0xF4E560", VA = "0xF4E560")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xF4E588", Offset = "0xF4E588", VA = "0xF4E588")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xF4C6E0", Offset = "0xF4C6E0", VA = "0xF4C6E0")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xF4DB3C", Offset = "0xF4DB3C", VA = "0xF4DB3C")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xF4E9A0", Offset = "0xF4E9A0", VA = "0xF4E9A0")]
	[IteratorStateMachine(typeof(<WaitForMouthAudioSource>d__137))]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xF4EA3C", Offset = "0xF4EA3C", VA = "0xF4EA3C")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xF4E834", Offset = "0xF4E834", VA = "0xF4E834")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xF494D8", Offset = "0xF494D8", VA = "0xF494D8")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xF4EAE0", Offset = "0xF4EAE0", VA = "0xF4EAE0")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xF4E5C4", Offset = "0xF4E5C4", VA = "0xF4E5C4")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xF4EBA8", Offset = "0xF4EBA8", VA = "0xF4EBA8")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x2000037")]
public class OvrAvatarAsset
{
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xF4EFA8", Offset = "0xF4EFA8", VA = "0xF4EFA8")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x2000038")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xF4EFB0", Offset = "0xF4EFB0", VA = "0xF4EFB0")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xF50144", Offset = "0xF50144", VA = "0xF50144")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xF4FD90", Offset = "0xF4FD90", VA = "0xF4FD90")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xF4FB14", Offset = "0xF4FB14", VA = "0xF4FB14")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xF4FBF4", Offset = "0xF4FBF4", VA = "0xF4FBF4")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xF50390", Offset = "0xF50390", VA = "0xF50390")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x2000039")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x4000163")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xF50920", Offset = "0xF50920", VA = "0xF50920")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x200003A")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xF50B68", Offset = "0xF50B68", VA = "0xF50B68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xF50F88", Offset = "0xF50F88", VA = "0xF50F88")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x200003B")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xF510B4", Offset = "0xF510B4", VA = "0xF510B4")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xF51200", Offset = "0xF51200", VA = "0xF51200")]
	private void Update()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xF51314", Offset = "0xF51314", VA = "0xF51314")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x200003C")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xF51368", Offset = "0xF51368", VA = "0xF51368")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xF50C7C", Offset = "0xF50C7C", VA = "0xF50C7C")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xF51930", Offset = "0xF51930", VA = "0xF51930")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xF51984", Offset = "0xF51984", VA = "0xF51984")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xF5208C", Offset = "0xF5208C", VA = "0xF5208C")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xF50FDC", Offset = "0xF50FDC", VA = "0xF50FDC")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x200003D")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x200003E")]
	public enum PacketMode
	{
		[Token(Token = "0x4000177")]
		SDK,
		[Token(Token = "0x4000178")]
		Unity
	}

	[Token(Token = "0x200003F")]
	public struct ControllerPose
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF54280", Offset = "0xF54280", VA = "0xF54280")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000040")]
	public struct PoseFrame
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF542F0", Offset = "0xF542F0", VA = "0xF542F0")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xF53F6C", Offset = "0xF53F6C", VA = "0xF53F6C")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x6000140")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xF53F7C", Offset = "0xF53F7C", VA = "0xF53F7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xF53FF8", Offset = "0xF53FF8", VA = "0xF53FF8")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xF54268", Offset = "0xF54268", VA = "0xF54268")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xF54270", Offset = "0xF54270", VA = "0xF54270")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000041")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xF545E8", Offset = "0xF545E8", VA = "0xF545E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xF54728", Offset = "0xF54728", VA = "0xF54728")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000042")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xF54784", Offset = "0xF54784", VA = "0xF54784")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xF548C4", Offset = "0xF548C4", VA = "0xF548C4")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xF54BF4", Offset = "0xF54BF4", VA = "0xF54BF4")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xF54E10", Offset = "0xF54E10", VA = "0xF54E10", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xF54E38", Offset = "0xF54E38", VA = "0xF54E38")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000043")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000044")]
	public enum TextureType
	{
		[Token(Token = "0x40001AE")]
		DiffuseTextures,
		[Token(Token = "0x40001AF")]
		NormalMaps,
		[Token(Token = "0x40001B0")]
		RoughnessMaps,
		[Token(Token = "0x40001B1")]
		Count
	}

	[Token(Token = "0x2000045")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x2000046")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000047")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000048")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF572A8", Offset = "0xF572A8", VA = "0xF572A8")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xF57DA4", Offset = "0xF57DA4", VA = "0xF57DA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xF57DEC", Offset = "0xF57DEC", VA = "0xF57DEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xF57064", Offset = "0xF57064", VA = "0xF57064")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF57700", Offset = "0xF57700", VA = "0xF57700", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF57704", Offset = "0xF57704", VA = "0xF57704", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF57DAC", Offset = "0xF57DAC", VA = "0xF57DAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x40001A9")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x40001AA")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x40001AB")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x40001AC")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xF54ED8", Offset = "0xF54ED8", VA = "0xF54ED8")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xF550AC", Offset = "0xF550AC", VA = "0xF550AC")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xF550E8", Offset = "0xF550E8", VA = "0xF550E8")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xF5581C", Offset = "0xF5581C", VA = "0xF5581C")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xF55AEC", Offset = "0xF55AEC", VA = "0xF55AEC")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xF55188", Offset = "0xF55188", VA = "0xF55188")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xF55BC8", Offset = "0xF55BC8", VA = "0xF55BC8")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xF555D4", Offset = "0xF555D4", VA = "0xF555D4")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xF55E58", Offset = "0xF55E58", VA = "0xF55E58")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xF560DC", Offset = "0xF560DC", VA = "0xF560DC")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xF56200", Offset = "0xF56200", VA = "0xF56200")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xF56238", Offset = "0xF56238", VA = "0xF56238")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xF5578C", Offset = "0xF5578C", VA = "0xF5578C")]
	[IteratorStateMachine(typeof(<RunLoadingAnimation>d__49))]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xF5708C", Offset = "0xF5708C", VA = "0xF5708C")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x200004A")]
public class OvrAvatarPacket
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000012")]
	public float Duration
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xF57DF4", Offset = "0xF57DF4", VA = "0xF57DF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000013")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF57E58", Offset = "0xF57E58", VA = "0xF57E58")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xF57EE0", Offset = "0xF57EE0", VA = "0xF57EE0")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xF58034", Offset = "0xF58034", VA = "0xF58034")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xF582CC", Offset = "0xF582CC", VA = "0xF582CC")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF58458", Offset = "0xF58458", VA = "0xF58458")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xF585DC", Offset = "0xF585DC", VA = "0xF585DC")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF587B8", Offset = "0xF587B8", VA = "0xF587B8")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xF58D04", Offset = "0xF58D04", VA = "0xF58D04")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x200004B")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF58F28", Offset = "0xF58F28", VA = "0xF58F28")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF59030", Offset = "0xF59030", VA = "0xF59030")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF591BC", Offset = "0xF591BC", VA = "0xF591BC")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xF59094", Offset = "0xF59094", VA = "0xF59094")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF5911C", Offset = "0xF5911C", VA = "0xF5911C")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x200004C")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF58B68", Offset = "0xF58B68", VA = "0xF58B68")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF593E4", Offset = "0xF593E4", VA = "0xF593E4")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF59204", Offset = "0xF59204", VA = "0xF59204")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF59270", Offset = "0xF59270", VA = "0xF59270")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF59300", Offset = "0xF59300", VA = "0xF59300")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x200004D")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x40001D3")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x40001D4")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF59434", Offset = "0xF59434", VA = "0xF59434")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF594B8", Offset = "0xF594B8", VA = "0xF594B8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xF594D4", Offset = "0xF594D4", VA = "0xF594D4")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xF59684", Offset = "0xF59684", VA = "0xF59684")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xF59840", Offset = "0xF59840", VA = "0xF59840")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x200004E")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xF598FC", Offset = "0xF598FC", VA = "0xF598FC")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF599D8", Offset = "0xF599D8", VA = "0xF599D8")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xF59BC4", Offset = "0xF59BC4", VA = "0xF59BC4")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF59F0C", Offset = "0xF59F0C", VA = "0xF59F0C")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF5A010", Offset = "0xF5A010", VA = "0xF5A010")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x200004F")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x40001DD")]
	Body = 1,
	[Token(Token = "0x40001DE")]
	Hands = 2,
	[Token(Token = "0x40001DF")]
	Base = 4,
	[Token(Token = "0x40001E0")]
	BodyTilt = 0x10,
	[Token(Token = "0x40001E1")]
	Expressive = 0x20,
	[Token(Token = "0x40001E2")]
	All = -1
}
[Token(Token = "0x2000050")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x40001E4")]
	AvatarSpecification,
	[Token(Token = "0x40001E5")]
	AssetLoaded,
	[Token(Token = "0x40001E6")]
	Count
}
[Token(Token = "0x2000051")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000052")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000053")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x40001EC")]
	Mesh,
	[Token(Token = "0x40001ED")]
	Texture,
	[Token(Token = "0x40001EE")]
	Pose,
	[Token(Token = "0x40001EF")]
	Material,
	[Token(Token = "0x40001F0")]
	CombinedMesh,
	[Token(Token = "0x40001F1")]
	PBSMaterial,
	[Token(Token = "0x40001F2")]
	FailedLoad,
	[Token(Token = "0x40001F3")]
	Count
}
[Token(Token = "0x2000054")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x2000055")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000056")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x2000057")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000058")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000059")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x4000228")]
	RGB24,
	[Token(Token = "0x4000229")]
	DXT1,
	[Token(Token = "0x400022A")]
	DXT5,
	[Token(Token = "0x400022B")]
	ASTC_RGB_6x6,
	[Token(Token = "0x400022C")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x400022D")]
	Count
}
[Token(Token = "0x200005A")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x200005B")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x4000235")]
	SkinnedMeshRender,
	[Token(Token = "0x4000236")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x4000237")]
	ProjectorRender,
	[Token(Token = "0x4000238")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x4000239")]
	Count
}
[Token(Token = "0x200005C")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x400023B")]
	Unknown,
	[Token(Token = "0x400023C")]
	Default,
	[Token(Token = "0x400023D")]
	Verbose,
	[Token(Token = "0x400023E")]
	Debug,
	[Token(Token = "0x400023F")]
	Info,
	[Token(Token = "0x4000240")]
	Warn,
	[Token(Token = "0x4000241")]
	Error,
	[Token(Token = "0x4000242")]
	Fatal,
	[Token(Token = "0x4000243")]
	Silent
}
[Token(Token = "0x200005D")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x200005E")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x4000248")]
	One = 1,
	[Token(Token = "0x4000249")]
	Two = 2,
	[Token(Token = "0x400024A")]
	Three = 4,
	[Token(Token = "0x400024B")]
	Joystick = 8
}
[Token(Token = "0x200005F")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x400024D")]
	One = 1,
	[Token(Token = "0x400024E")]
	Two = 2,
	[Token(Token = "0x400024F")]
	Joystick = 4,
	[Token(Token = "0x4000250")]
	ThumbRest = 8,
	[Token(Token = "0x4000251")]
	Index = 0x10,
	[Token(Token = "0x4000252")]
	Pointing = 0x40,
	[Token(Token = "0x4000253")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000060")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000061")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000062")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000063")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000064")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000065")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x2000066")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000067")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000068")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x4000273")]
	Add,
	[Token(Token = "0x4000274")]
	Multiply,
	[Token(Token = "0x4000275")]
	Count
}
[Token(Token = "0x2000069")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x4000277")]
	Color,
	[Token(Token = "0x4000278")]
	Texture,
	[Token(Token = "0x4000279")]
	TextureSingleChannel,
	[Token(Token = "0x400027A")]
	Parallax,
	[Token(Token = "0x400027B")]
	Count
}
[Token(Token = "0x200006A")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x400027D")]
	None,
	[Token(Token = "0x400027E")]
	Positional,
	[Token(Token = "0x400027F")]
	ViewReflection,
	[Token(Token = "0x4000280")]
	Fresnel,
	[Token(Token = "0x4000281")]
	Pulse,
	[Token(Token = "0x4000282")]
	Count
}
[Token(Token = "0x200006B")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x4000284")]
	Touch,
	[Token(Token = "0x4000285")]
	Malibu,
	[Token(Token = "0x4000286")]
	Go,
	[Token(Token = "0x4000287")]
	Quest,
	[Token(Token = "0x4000288")]
	Count
}
[Token(Token = "0x200006C")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x400028A")]
	Lowest = 1,
	[Token(Token = "0x400028B")]
	Medium = 3,
	[Token(Token = "0x400028C")]
	Highest = 5
}
[Token(Token = "0x200006D")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x400028E")]
	Unknown = -1,
	[Token(Token = "0x400028F")]
	One,
	[Token(Token = "0x4000290")]
	Two
}
[Token(Token = "0x200006E")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xF5A3E8", Offset = "0xF5A3E8", VA = "0xF5A3E8")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xF5A418", Offset = "0xF5A418", VA = "0xF5A418", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xF5A628", Offset = "0xF5A628", VA = "0xF5A628", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200006F")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xF5A86C", Offset = "0xF5A86C", VA = "0xF5A86C")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xF5A89C", Offset = "0xF5A89C", VA = "0xF5A89C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xF5AC2C", Offset = "0xF5AC2C", VA = "0xF5AC2C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000070")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xF5AFD4", Offset = "0xF5AFD4", VA = "0xF5AFD4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xF5B004", Offset = "0xF5B004", VA = "0xF5B004", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xF5B24C", Offset = "0xF5B24C", VA = "0xF5B24C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000071")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xF5B520", Offset = "0xF5B520", VA = "0xF5B520")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xF5B550", Offset = "0xF5B550", VA = "0xF5B550", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xF5B718", Offset = "0xF5B718", VA = "0xF5B718", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000072")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xF5B92C", Offset = "0xF5B92C", VA = "0xF5B92C")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000073")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x2000074")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x40002C5")]
	FirstPerson = 1,
	[Token(Token = "0x40002C6")]
	ThirdPerson = 2,
	[Token(Token = "0x40002C7")]
	SelfOccluding = 4
}
[Token(Token = "0x2000075")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000076")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000077")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x2000078")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000079")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x40002DD")]
	Default,
	[Token(Token = "0x40002DE")]
	GripSphere,
	[Token(Token = "0x40002DF")]
	GripCube,
	[Token(Token = "0x40002E0")]
	Count
}
[Token(Token = "0x200007A")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x40002E2")]
	Body,
	[Token(Token = "0x40002E3")]
	Clothing,
	[Token(Token = "0x40002E4")]
	Eyewear,
	[Token(Token = "0x40002E5")]
	Hair,
	[Token(Token = "0x40002E6")]
	Beard,
	[Token(Token = "0x40002E7")]
	Count
}
[Token(Token = "0x200007B")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x200007C")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x200007D")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x200007E")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x200007F")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x40002F1")]
	AvatarHead,
	[Token(Token = "0x40002F2")]
	AvatarHand,
	[Token(Token = "0x40002F3")]
	Object,
	[Token(Token = "0x40002F4")]
	ObjectStatic,
	[Token(Token = "0x40002F5")]
	Count
}
[Token(Token = "0x2000080")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000081")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000082")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000083")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x2000084")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x4000301")]
	Point,
	[Token(Token = "0x4000302")]
	Direction,
	[Token(Token = "0x4000303")]
	Spot,
	[Token(Token = "0x4000304")]
	Count
}
[Token(Token = "0x2000085")]
public struct ovrAvatarLight
{
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x2000086")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x2000087")]
public struct ovrAvatarLights
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x2000088")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x2000089")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x400031A")]
	None = 0u,
	[Token(Token = "0x400031B")]
	GazeTarget = 1u,
	[Token(Token = "0x400031C")]
	Any = uint.MaxValue
}
[Token(Token = "0x200008A")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x200008B")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x200008C")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x200008D")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x200008E")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x200008F")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xF5DA54", Offset = "0xF5DA54", VA = "0xF5DA54")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x4000331")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000014")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xF52118", Offset = "0xF52118", VA = "0xF52118")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xF5C788", Offset = "0xF5C788", VA = "0xF5C788")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xF5CAD8", Offset = "0xF5CAD8", VA = "0xF5CAD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xF5CB3C", Offset = "0xF5CB3C", VA = "0xF5CB3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xF5D4D8", Offset = "0xF5D4D8", VA = "0xF5D4D8")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xF5D528", Offset = "0xF5D528", VA = "0xF5D528")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xF5D578", Offset = "0xF5D578", VA = "0xF5D578")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xF5D620", Offset = "0xF5D620", VA = "0xF5D620")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xF5D678", Offset = "0xF5D678", VA = "0xF5D678")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xF5D2FC", Offset = "0xF5D2FC", VA = "0xF5D2FC")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xF5D73C", Offset = "0xF5D73C", VA = "0xF5D73C")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xF5D888", Offset = "0xF5D888", VA = "0xF5D888")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xF52304", Offset = "0xF52304", VA = "0xF52304")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xF5D974", Offset = "0xF5D974", VA = "0xF5D974")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xF5CA98", Offset = "0xF5CA98", VA = "0xF5CA98")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xF55878", Offset = "0xF55878", VA = "0xF55878")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xF5DA3C", Offset = "0xF5DA3C", VA = "0xF5DA3C")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000091")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000015")]
	public static string AppID
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xF5DA04", Offset = "0xF5DA04", VA = "0xF5DA04")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xF5DC00", Offset = "0xF5DC00", VA = "0xF5DC00")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public static string MobileAppID
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xF5DA20", Offset = "0xF5DA20", VA = "0xF5DA20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xF5DC24", Offset = "0xF5DC24", VA = "0xF5DC24")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xF5DABC", Offset = "0xF5DABC", VA = "0xF5DABC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xF5DC48", Offset = "0xF5DC48", VA = "0xF5DC48")]
		set
		{
		}
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xF5DCA0", Offset = "0xF5DCA0", VA = "0xF5DCA0")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000092")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xF5DD08", Offset = "0xF5DD08", VA = "0xF5DD08")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xF51370", Offset = "0xF51370", VA = "0xF51370")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xF5DE84", Offset = "0xF5DE84", VA = "0xF5DE84")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xF5DFCC", Offset = "0xF5DFCC", VA = "0xF5DFCC")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000093")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xF5DFDC", Offset = "0xF5DFDC", VA = "0xF5DFDC")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xF5157C", Offset = "0xF5157C", VA = "0xF5157C")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xF5E12C", Offset = "0xF5E12C", VA = "0xF5E12C")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x2000094")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x4000348")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x4000349")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x400034A")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xF5E13C", Offset = "0xF5E13C", VA = "0xF5E13C")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xF51724", Offset = "0xF51724", VA = "0xF51724")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xF5F0E0", Offset = "0xF5F0E0", VA = "0xF5F0E0")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xF5E87C", Offset = "0xF5E87C", VA = "0xF5E87C")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xF5E578", Offset = "0xF5E578", VA = "0xF5E578")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xF5E6F0", Offset = "0xF5E6F0", VA = "0xF5E6F0")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xF5F8E8", Offset = "0xF5F8E8", VA = "0xF5F8E8")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x2000095")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000096")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x2000097")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xF60040", Offset = "0xF60040", VA = "0xF60040")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x2000098")]
	public struct TextureSet
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xF60090", Offset = "0xF60090", VA = "0xF60090")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xF608C0", Offset = "0xF608C0", VA = "0xF608C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xF60908", Offset = "0xF60908", VA = "0xF60908", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xF60160", Offset = "0xF60160", VA = "0xF60160")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xF602EC", Offset = "0xF602EC", VA = "0xF602EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xF602F0", Offset = "0xF602F0", VA = "0xF602F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF608C8", Offset = "0xF608C8", VA = "0xF608C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x400034E")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x400034F")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x4000352")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x4000353")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x4000354")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x4000355")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x4000356")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x4000357")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x4000358")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xF5F8F8", Offset = "0xF5F8F8", VA = "0xF5F8F8")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xF5FE5C", Offset = "0xF5FE5C", VA = "0xF5FE5C")]
	public void Update()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xF57D5C", Offset = "0xF57D5C", VA = "0xF57D5C")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xF55C98", Offset = "0xF55C98", VA = "0xF55C98")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xF5FFC0", Offset = "0xF5FFC0", VA = "0xF5FFC0")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xF558EC", Offset = "0xF558EC", VA = "0xF558EC")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xF55B30", Offset = "0xF55B30", VA = "0xF55B30")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xF600B8", Offset = "0xF600B8", VA = "0xF600B8")]
	[IteratorStateMachine(typeof(<DeleteTextureSetCoroutine>d__24))]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xF5D6FC", Offset = "0xF5D6FC", VA = "0xF5D6FC")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xF60188", Offset = "0xF60188", VA = "0xF60188")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x200009A")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xF60910", Offset = "0xF60910", VA = "0xF60910")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xF60A50", Offset = "0xF60A50", VA = "0xF60A50")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x200009B")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	public delegate void OnClick();

	[Token(Token = "0x200009D")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200009E")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200009F")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x400036A")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x400036B")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x400036C")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x400037B")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x400037C")]
	public const float marginH = 16f;

	[Token(Token = "0x400037D")]
	public const float marginV = 16f;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LaserPointer lp;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private LineRenderer lr;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public bool isHorizontal;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xF60AAC", Offset = "0xF60AAC", VA = "0xF60AAC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xF61010", Offset = "0xF61010", VA = "0xF61010")]
	public void Show()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xF61598", Offset = "0xF61598", VA = "0xF61598")]
	public void Hide()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xF6137C", Offset = "0xF6137C", VA = "0xF6137C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xF61714", Offset = "0xF61714", VA = "0xF61714")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xF61A90", Offset = "0xF61A90", VA = "0xF61A90")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xF61E40", Offset = "0xF61E40", VA = "0xF61E40")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xF61F38", Offset = "0xF61F38", VA = "0xF61F38")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xF62108", Offset = "0xF62108", VA = "0xF62108")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xF621A0", Offset = "0xF621A0", VA = "0xF621A0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xF6237C", Offset = "0xF6237C", VA = "0xF6237C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xF62578", Offset = "0xF62578", VA = "0xF62578")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xF62870", Offset = "0xF62870", VA = "0xF62870")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xF62960", Offset = "0xF62960", VA = "0xF62960")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xF629F4", Offset = "0xF629F4", VA = "0xF629F4")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000A5")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xF63064", Offset = "0xF63064", VA = "0xF63064")]
	private void Start()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xF63108", Offset = "0xF63108", VA = "0xF63108")]
	private void Update()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xF631A4", Offset = "0xF631A4", VA = "0xF631A4")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xF631DC", Offset = "0xF631DC", VA = "0xF631DC")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000A6")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000A7")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400039B")]
		On,
		[Token(Token = "0x400039C")]
		Off,
		[Token(Token = "0x400039D")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700001A")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xF631E4", Offset = "0xF631E4", VA = "0xF631E4")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF60FD0", Offset = "0xF60FD0", VA = "0xF60FD0")]
		set
		{
		}
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xF631EC", Offset = "0xF631EC", VA = "0xF631EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xF63244", Offset = "0xF63244", VA = "0xF63244")]
	private void Start()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xF6337C", Offset = "0xF6337C", VA = "0xF6337C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xF63398", Offset = "0xF63398", VA = "0xF63398", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xF633E8", Offset = "0xF633E8", VA = "0xF633E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xF63588", Offset = "0xF63588", VA = "0xF63588")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xF63698", Offset = "0xF63698", VA = "0xF63698")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xF6371C", Offset = "0xF6371C", VA = "0xF6371C")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xF637DC", Offset = "0xF637DC", VA = "0xF637DC")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xF63884", Offset = "0xF63884", VA = "0xF63884")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xF63970", Offset = "0xF63970", VA = "0xF63970")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000A8")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400039E")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400039F")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x40003A0")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xF63980", Offset = "0xF63980", VA = "0xF63980")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xF63988", Offset = "0xF63988", VA = "0xF63988")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xF63A18", Offset = "0xF63A18", VA = "0xF63A18")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xF63AA4", Offset = "0xF63AA4", VA = "0xF63AA4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xF63B30", Offset = "0xF63B30", VA = "0xF63B30")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xF63E50", Offset = "0xF63E50", VA = "0xF63E50")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xF640B0", Offset = "0xF640B0", VA = "0xF640B0")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000A9")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xF64808", Offset = "0xF64808", VA = "0xF64808")]
	private void Start()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xF648B4", Offset = "0xF648B4", VA = "0xF648B4")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000AA")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	public enum States
	{
		[Token(Token = "0x40003CE")]
		Ready,
		[Token(Token = "0x40003CF")]
		Aim,
		[Token(Token = "0x40003D0")]
		CancelAim,
		[Token(Token = "0x40003D1")]
		PreTeleport,
		[Token(Token = "0x40003D2")]
		CancelTeleport,
		[Token(Token = "0x40003D3")]
		Teleporting,
		[Token(Token = "0x40003D4")]
		PostTeleport
	}

	[Token(Token = "0x20000AC")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40003D6")]
		None,
		[Token(Token = "0x40003D7")]
		Aim,
		[Token(Token = "0x40003D8")]
		PreTeleport,
		[Token(Token = "0x40003D9")]
		Teleport
	}

	[Token(Token = "0x20000AD")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40003DB")]
		Point,
		[Token(Token = "0x40003DC")]
		Sphere,
		[Token(Token = "0x40003DD")]
		Capsule
	}

	[Token(Token = "0x20000AE")]
	public class AimData
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x1700001E")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xF6650C", Offset = "0xF6650C", VA = "0xF6650C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xF66514", Offset = "0xF66514", VA = "0xF66514")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xF66484", Offset = "0xF66484", VA = "0xF66484")]
		public AimData()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xF6651C", Offset = "0xF6651C", VA = "0xF6651C")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xF66684", Offset = "0xF66684", VA = "0xF66684", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xF666CC", Offset = "0xF666CC", VA = "0xF666CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xF652A0", Offset = "0xF652A0", VA = "0xF652A0")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xF66574", Offset = "0xF66574", VA = "0xF66574", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xF66578", Offset = "0xF66578", VA = "0xF66578", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xF6668C", Offset = "0xF6668C", VA = "0xF6668C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xF66830", Offset = "0xF66830", VA = "0xF66830", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xF66878", Offset = "0xF66878", VA = "0xF66878", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF65728", Offset = "0xF65728", VA = "0xF65728")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xF666D4", Offset = "0xF666D4", VA = "0xF666D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xF666D8", Offset = "0xF666D8", VA = "0xF666D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF66838", Offset = "0xF66838", VA = "0xF66838", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xF6695C", Offset = "0xF6695C", VA = "0xF6695C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xF669A4", Offset = "0xF669A4", VA = "0xF669A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF66880", Offset = "0xF66880", VA = "0xF66880")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF668A8", Offset = "0xF668A8", VA = "0xF668A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xF668AC", Offset = "0xF668AC", VA = "0xF668AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xF66964", Offset = "0xF66964", VA = "0xF66964", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xF66AC8", Offset = "0xF66AC8", VA = "0xF66AC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xF66B10", Offset = "0xF66B10", VA = "0xF66B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xF669AC", Offset = "0xF669AC", VA = "0xF669AC")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xF669D4", Offset = "0xF669D4", VA = "0xF669D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xF669D8", Offset = "0xF669D8", VA = "0xF669D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xF66AD0", Offset = "0xF66AD0", VA = "0xF66AD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xF66BF4", Offset = "0xF66BF4", VA = "0xF66BF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xF66C3C", Offset = "0xF66C3C", VA = "0xF66C3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xF66B18", Offset = "0xF66B18", VA = "0xF66B18")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xF66B40", Offset = "0xF66B40", VA = "0xF66B40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xF66B44", Offset = "0xF66B44", VA = "0xF66B44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xF66BFC", Offset = "0xF66BFC", VA = "0xF66BFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xF66D58", Offset = "0xF66D58", VA = "0xF66D58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xF66DA0", Offset = "0xF66DA0", VA = "0xF66DA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xF66C44", Offset = "0xF66C44", VA = "0xF66C44")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xF66C6C", Offset = "0xF66C6C", VA = "0xF66C6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xF66C70", Offset = "0xF66C70", VA = "0xF66C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF66D60", Offset = "0xF66D60", VA = "0xF66D60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xF66ED8", Offset = "0xF66ED8", VA = "0xF66ED8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xF66F20", Offset = "0xF66F20", VA = "0xF66F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF66DA8", Offset = "0xF66DA8", VA = "0xF66DA8")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF66DD0", Offset = "0xF66DD0", VA = "0xF66DD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xF66DD4", Offset = "0xF66DD4", VA = "0xF66DD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xF66EE0", Offset = "0xF66EE0", VA = "0xF66EE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700001B")]
	public States CurrentState
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xF64904", Offset = "0xF64904", VA = "0xF64904")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xF6490C", Offset = "0xF6490C", VA = "0xF6490C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xF64ADC", Offset = "0xF64ADC", VA = "0xF64ADC")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700001D")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xF64B00", Offset = "0xF64B00", VA = "0xF64B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xF64B08", Offset = "0xF64B08", VA = "0xF64B08")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xF64914", Offset = "0xF64914", VA = "0xF64914")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xF649C4", Offset = "0xF649C4", VA = "0xF649C4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xF65168", Offset = "0xF65168", VA = "0xF65168")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xF65204", Offset = "0xF65204", VA = "0xF65204")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xF652C8", Offset = "0xF652C8", VA = "0xF652C8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xF65364", Offset = "0xF65364", VA = "0xF65364")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xF65400", Offset = "0xF65400", VA = "0xF65400")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xF654B0", Offset = "0xF654B0", VA = "0xF654B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xF6557C", Offset = "0xF6557C", VA = "0xF6557C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xF65618", Offset = "0xF65618", VA = "0xF65618")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xF65750", Offset = "0xF65750", VA = "0xF65750")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xF657EC", Offset = "0xF657EC", VA = "0xF657EC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xF658FC", Offset = "0xF658FC", VA = "0xF658FC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF65998", Offset = "0xF65998", VA = "0xF65998")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xF65AA8", Offset = "0xF65AA8", VA = "0xF65AA8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF65B44", Offset = "0xF65B44", VA = "0xF65B44")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF65C54", Offset = "0xF65C54", VA = "0xF65C54")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xF65CF0", Offset = "0xF65CF0", VA = "0xF65CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF65E00", Offset = "0xF65E00", VA = "0xF65E00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF65E9C", Offset = "0xF65E9C", VA = "0xF65E9C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF65FAC", Offset = "0xF65FAC", VA = "0xF65FAC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF6605C", Offset = "0xF6605C", VA = "0xF6605C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xF648BC", Offset = "0xF648BC", VA = "0xF648BC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xF648E0", Offset = "0xF648E0", VA = "0xF648E0")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xF64A74", Offset = "0xF64A74", VA = "0xF64A74")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xF64B10", Offset = "0xF64B10", VA = "0xF64B10")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xF64DD8", Offset = "0xF64DD8", VA = "0xF64DD8")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xF64E80", Offset = "0xF64E80", VA = "0xF64E80")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xF64F6C", Offset = "0xF64F6C", VA = "0xF64F6C")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xF64F88", Offset = "0xF64F88", VA = "0xF64F88")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xF65038", Offset = "0xF65038", VA = "0xF65038")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xF65068", Offset = "0xF65068", VA = "0xF65068")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xF650C8", Offset = "0xF650C8", VA = "0xF650C8", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xF65160", Offset = "0xF65160", VA = "0xF65160", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xF650EC", Offset = "0xF650EC", VA = "0xF650EC")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xF65560", Offset = "0xF65560", VA = "0xF65560")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xF656B4", Offset = "0xF656B4", VA = "0xF656B4")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xF65888", Offset = "0xF65888", VA = "0xF65888")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xF65A34", Offset = "0xF65A34", VA = "0xF65A34")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF65BE0", Offset = "0xF65BE0", VA = "0xF65BE0")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xF65D8C", Offset = "0xF65D8C", VA = "0xF65D8C")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xF65F38", Offset = "0xF65F38", VA = "0xF65F38")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xF6610C", Offset = "0xF6610C", VA = "0xF6610C")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF66220", Offset = "0xF66220", VA = "0xF66220")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF66250", Offset = "0xF66250", VA = "0xF66250")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF6638C", Offset = "0xF6638C", VA = "0xF6638C")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF66474", Offset = "0xF66474", VA = "0xF66474")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000B6")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF66F28", Offset = "0xF66F28", VA = "0xF66F28")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF66FC4", Offset = "0xF66FC4", VA = "0xF66FC4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF67060", Offset = "0xF67060", VA = "0xF67060")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF670FC", Offset = "0xF670FC", VA = "0xF670FC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xF67198", Offset = "0xF67198", VA = "0xF67198")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xF67278", Offset = "0xF67278", VA = "0xF67278")]
	private void Start()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xF6727C", Offset = "0xF6727C", VA = "0xF6727C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xF672F0", Offset = "0xF672F0", VA = "0xF672F0")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xF67414", Offset = "0xF67414", VA = "0xF67414")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xF6768C", Offset = "0xF6768C", VA = "0xF6768C")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xF678AC", Offset = "0xF678AC", VA = "0xF678AC")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000B7")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x600028D")]
	[Address(RVA = "0xF678CC", Offset = "0xF678CC", VA = "0xF678CC", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xF6795C", Offset = "0xF6795C", VA = "0xF6795C", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600028F")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xF67A2C", Offset = "0xF67A2C", VA = "0xF67A2C")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xF67A3C", Offset = "0xF67A3C", VA = "0xF67A3C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xF67BCC", Offset = "0xF67BCC", VA = "0xF67BCC")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000B9")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xF67BDC", Offset = "0xF67BDC", VA = "0xF67BDC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xF67DB0", Offset = "0xF67DB0", VA = "0xF67DB0")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000BA")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xF67DC4", Offset = "0xF67DC4", VA = "0xF67DC4")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xF67EF0", Offset = "0xF67EF0", VA = "0xF67EF0")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xF67F1C", Offset = "0xF67F1C", VA = "0xF67F1C")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xF67F48", Offset = "0xF67F48", VA = "0xF67F48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xF67FEC", Offset = "0xF67FEC", VA = "0xF67FEC", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xF6804C", Offset = "0xF6804C", VA = "0xF6804C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xF680A8", Offset = "0xF680A8", VA = "0xF680A8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000BB")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700002D")]
	public bool IsValidDestination
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF681A4", Offset = "0xF681A4", VA = "0xF681A4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xF681AC", Offset = "0xF681AC", VA = "0xF681AC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xF6833C", Offset = "0xF6833C", VA = "0xF6833C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xF683EC", Offset = "0xF683EC", VA = "0xF683EC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xF681B8", Offset = "0xF681B8", VA = "0xF681B8")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xF6823C", Offset = "0xF6823C", VA = "0xF6823C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xF68304", Offset = "0xF68304", VA = "0xF68304")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xF68338", Offset = "0xF68338", VA = "0xF68338")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xF6849C", Offset = "0xF6849C", VA = "0xF6849C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xF684C0", Offset = "0xF684C0", VA = "0xF684C0")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xF684E0", Offset = "0xF684E0", VA = "0xF684E0", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000BC")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xF68AB8", Offset = "0xF68AB8", VA = "0xF68AB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xF68B00", Offset = "0xF68B00", VA = "0xF68B00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xF68924", Offset = "0xF68924", VA = "0xF68924")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xF68A28", Offset = "0xF68A28", VA = "0xF68A28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xF68A2C", Offset = "0xF68A2C", VA = "0xF68A2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF68AC0", Offset = "0xF68AC0", VA = "0xF68AC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xF68BA4", Offset = "0xF68BA4", VA = "0xF68BA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xF68BEC", Offset = "0xF68BEC", VA = "0xF68BEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xF689C0", Offset = "0xF689C0", VA = "0xF689C0")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xF68B08", Offset = "0xF68B08", VA = "0xF68B08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xF68B0C", Offset = "0xF68B0C", VA = "0xF68B0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF68BAC", Offset = "0xF68BAC", VA = "0xF68BAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xF686D4", Offset = "0xF686D4", VA = "0xF686D4")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xF687A8", Offset = "0xF687A8", VA = "0xF687A8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xF687FC", Offset = "0xF687FC", VA = "0xF687FC", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xF688B0", Offset = "0xF688B0", VA = "0xF688B0")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xF6894C", Offset = "0xF6894C", VA = "0xF6894C")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60002AD")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x20000BF")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000032")]
	public Transform Pointer
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF68BF4", Offset = "0xF68BF4", VA = "0xF68BF4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF68BFC", Offset = "0xF68BFC", VA = "0xF68BFC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xF68C04", Offset = "0xF68C04", VA = "0xF68C04", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xF68D30", Offset = "0xF68D30", VA = "0xF68D30", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xF68DE4", Offset = "0xF68DE4", VA = "0xF68DE4")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000C0")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000C1")]
	public enum InputModes
	{
		[Token(Token = "0x400042E")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400042F")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x4000430")]
		ThumbstickTeleport,
		[Token(Token = "0x4000431")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000C2")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000433")]
		A,
		[Token(Token = "0x4000434")]
		B,
		[Token(Token = "0x4000435")]
		LeftTrigger,
		[Token(Token = "0x4000436")]
		LeftThumbstick,
		[Token(Token = "0x4000437")]
		RightTrigger,
		[Token(Token = "0x4000438")]
		RightThumbstick,
		[Token(Token = "0x4000439")]
		X,
		[Token(Token = "0x400043A")]
		Y
	}

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xF68DE8", Offset = "0xF68DE8", VA = "0xF68DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xF68DEC", Offset = "0xF68DEC", VA = "0xF68DEC", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xF69220", Offset = "0xF69220", VA = "0xF69220", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xF692DC", Offset = "0xF692DC", VA = "0xF692DC")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000C3")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000C4")]
	public enum OrientationModes
	{
		[Token(Token = "0x400043F")]
		HeadRelative,
		[Token(Token = "0x4000440")]
		ForwardFacing
	}

	[Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xF6979C", Offset = "0xF6979C", VA = "0xF6979C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xF697E4", Offset = "0xF697E4", VA = "0xF697E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF695AC", Offset = "0xF695AC", VA = "0xF695AC")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF696EC", Offset = "0xF696EC", VA = "0xF696EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF696F0", Offset = "0xF696F0", VA = "0xF696F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF697A4", Offset = "0xF697A4", VA = "0xF697A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xF693CC", Offset = "0xF693CC", VA = "0xF693CC")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xF694B4", Offset = "0xF694B4", VA = "0xF694B4")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xF694BC", Offset = "0xF694BC", VA = "0xF694BC", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xF694FC", Offset = "0xF694FC", VA = "0xF694FC", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xF69538", Offset = "0xF69538", VA = "0xF69538")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60002CB")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xF695D4", Offset = "0xF695D4", VA = "0xF695D4")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x20000C6")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xF697EC", Offset = "0xF697EC", VA = "0xF697EC", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xF697F0", Offset = "0xF697F0", VA = "0xF697F0", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xF69868", Offset = "0xF69868", VA = "0xF69868")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000C7")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xF6986C", Offset = "0xF6986C", VA = "0xF6986C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xF698BC", Offset = "0xF698BC", VA = "0xF698BC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xF69D38", Offset = "0xF69D38", VA = "0xF69D38")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000C8")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xF69D3C", Offset = "0xF69D3C", VA = "0xF69D3C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xF69D74", Offset = "0xF69D74", VA = "0xF69D74", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xF6A24C", Offset = "0xF6A24C", VA = "0xF6A24C")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000C9")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xF6A25C", Offset = "0xF6A25C", VA = "0xF6A25C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xF6A260", Offset = "0xF6A260", VA = "0xF6A260")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xF6A268", Offset = "0xF6A268", VA = "0xF6A268")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xF6A354", Offset = "0xF6A354", VA = "0xF6A354")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xF6A370", Offset = "0xF6A370", VA = "0xF6A370")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000CA")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000035")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF6A388", Offset = "0xF6A388", VA = "0xF6A388")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF6A390", Offset = "0xF6A390", VA = "0xF6A390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xF678F4", Offset = "0xF678F4", VA = "0xF678F4", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xF67A04", Offset = "0xF67A04", VA = "0xF67A04", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xF6A398", Offset = "0xF6A398", VA = "0xF6A398")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xF68040", Offset = "0xF68040", VA = "0xF68040", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xF680A0", Offset = "0xF680A0", VA = "0xF680A0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xF67A34", Offset = "0xF67A34", VA = "0xF67A34")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000CB")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xF6AA84", Offset = "0xF6AA84", VA = "0xF6AA84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xF6AACC", Offset = "0xF6AACC", VA = "0xF6AACC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF6A64C", Offset = "0xF6A64C", VA = "0xF6A64C")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF6A7CC", Offset = "0xF6A7CC", VA = "0xF6A7CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF6A7D0", Offset = "0xF6A7D0", VA = "0xF6A7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xF6AA8C", Offset = "0xF6AA8C", VA = "0xF6AA8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x400045A")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xF6A468", Offset = "0xF6A468", VA = "0xF6A468")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xF6A584", Offset = "0xF6A584", VA = "0xF6A584", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xF6A5B0", Offset = "0xF6A5B0", VA = "0xF6A5B0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xF6A5D8", Offset = "0xF6A5D8", VA = "0xF6A5D8")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xF6A674", Offset = "0xF6A674", VA = "0xF6A674", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60002EF")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xF6A690", Offset = "0xF6A690", VA = "0xF6A690", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x20000CD")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xF6AAD4", Offset = "0xF6AAD4", VA = "0xF6AAD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xF6AB3C", Offset = "0xF6AB3C", VA = "0xF6AB3C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xF6ACA8", Offset = "0xF6ACA8", VA = "0xF6ACA8", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xF6AD98", Offset = "0xF6AD98", VA = "0xF6AD98")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xF6AD9C", Offset = "0xF6AD9C", VA = "0xF6AD9C")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000CE")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xF6ADA8", Offset = "0xF6ADA8", VA = "0xF6ADA8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xF6AFA8", Offset = "0xF6AFA8", VA = "0xF6AFA8")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000CF")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xF6AFB4", Offset = "0xF6AFB4", VA = "0xF6AFB4", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xF6B120", Offset = "0xF6B120", VA = "0xF6B120")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000D0")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000301")]
	[Address(RVA = "0xF6B124", Offset = "0xF6B124", VA = "0xF6B124", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xF6B1AC", Offset = "0xF6B1AC", VA = "0xF6B1AC", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000303")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xF6B230", Offset = "0xF6B230", VA = "0xF6B230")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000D1")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xF6B598", Offset = "0xF6B598", VA = "0xF6B598", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xF6B5E0", Offset = "0xF6B5E0", VA = "0xF6B5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF6B2CC", Offset = "0xF6B2CC", VA = "0xF6B2CC")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF6B490", Offset = "0xF6B490", VA = "0xF6B490", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF6B494", Offset = "0xF6B494", VA = "0xF6B494", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF6B5A0", Offset = "0xF6B5A0", VA = "0xF6B5A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	public float TransitionDuration;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	public float TeleportDelay;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xF6B238", Offset = "0xF6B238", VA = "0xF6B238", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xF6B258", Offset = "0xF6B258", VA = "0xF6B258")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xF6B2F4", Offset = "0xF6B2F4", VA = "0xF6B2F4")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000D3")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x600030E")]
	[Address(RVA = "0xF6B5E8", Offset = "0xF6B5E8", VA = "0xF6B5E8", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xF6B604", Offset = "0xF6B604", VA = "0xF6B604")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000D4")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xF6B834", Offset = "0xF6B834", VA = "0xF6B834", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xF6B87C", Offset = "0xF6B87C", VA = "0xF6B87C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF6B6A0", Offset = "0xF6B6A0", VA = "0xF6B6A0")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF6B710", Offset = "0xF6B710", VA = "0xF6B710", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF6B714", Offset = "0xF6B714", VA = "0xF6B714", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF6B83C", Offset = "0xF6B83C", VA = "0xF6B83C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	[Tooltip("How much time the warp transition takes to complete.")]
	public float TransitionDuration;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xF6B60C", Offset = "0xF6B60C", VA = "0xF6B60C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xF6B62C", Offset = "0xF6B62C", VA = "0xF6B62C")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xF6B6C8", Offset = "0xF6B6C8", VA = "0xF6B6C8")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000D6")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x20000D7")]
	public enum PlabackState
	{
		[Token(Token = "0x400048A")]
		Idle = 1,
		[Token(Token = "0x400048B")]
		Preparing,
		[Token(Token = "0x400048C")]
		Buffering,
		[Token(Token = "0x400048D")]
		Ready,
		[Token(Token = "0x400048E")]
		Ended
	}

	[Token(Token = "0x20000D8")]
	public enum StereoMode
	{
		[Token(Token = "0x4000490")]
		Unknown = -1,
		[Token(Token = "0x4000491")]
		Mono,
		[Token(Token = "0x4000492")]
		TopBottom,
		[Token(Token = "0x4000493")]
		LeftRight,
		[Token(Token = "0x4000494")]
		Mesh
	}

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700003C")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF6B884", Offset = "0xF6B884", VA = "0xF6B884")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003D")]
	private static IntPtr Activity
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF6BB74", Offset = "0xF6BB74", VA = "0xF6BB74")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003E")]
	public static bool IsAvailable
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF6BDF4", Offset = "0xF6BDF4", VA = "0xF6BDF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public static bool IsPlaying
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF6BE68", Offset = "0xF6BE68", VA = "0xF6BE68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000040")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF6BF6C", Offset = "0xF6BF6C", VA = "0xF6BF6C")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000041")]
	public static long Duration
	{
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF6C074", Offset = "0xF6C074", VA = "0xF6C074")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000042")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF6C17C", Offset = "0xF6C17C", VA = "0xF6C17C")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000043")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF6C284", Offset = "0xF6C284", VA = "0xF6C284")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF6C38C", Offset = "0xF6C38C", VA = "0xF6C38C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000045")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF6C494", Offset = "0xF6C494", VA = "0xF6C494")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF6C59C", Offset = "0xF6C59C", VA = "0xF6C59C")]
		set
		{
		}
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xF6C704", Offset = "0xF6C704", VA = "0xF6C704")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xF6C91C", Offset = "0xF6C91C", VA = "0xF6C91C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xF6CA24", Offset = "0xF6CA24", VA = "0xF6CA24")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xF6CB2C", Offset = "0xF6CB2C", VA = "0xF6CB2C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xF6CC34", Offset = "0xF6CC34", VA = "0xF6CC34")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xF6CDA4", Offset = "0xF6CDA4", VA = "0xF6CDA4")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xF6CF10", Offset = "0xF6CF10", VA = "0xF6CF10")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000D9")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xF6D164", Offset = "0xF6D164", VA = "0xF6D164")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF6D200", Offset = "0xF6D200", VA = "0xF6D200")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xF6D29C", Offset = "0xF6D29C", VA = "0xF6D29C", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xF6D2B8", Offset = "0xF6D2B8", VA = "0xF6D2B8")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000DA")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x20000DB")]
	public enum ButtonType
	{
		[Token(Token = "0x4000498")]
		Play,
		[Token(Token = "0x4000499")]
		Pause,
		[Token(Token = "0x400049A")]
		FastForward,
		[Token(Token = "0x400049B")]
		Rewind,
		[Token(Token = "0x400049C")]
		SkipForward,
		[Token(Token = "0x400049D")]
		SkipBack,
		[Token(Token = "0x400049E")]
		Stop
	}

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000046")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF6D2C0", Offset = "0xF6D2C0", VA = "0xF6D2C0")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF6D2C8", Offset = "0xF6D2C8", VA = "0xF6D2C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xF6D2EC", Offset = "0xF6D2EC", VA = "0xF6D2EC", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xF6E140", Offset = "0xF6E140", VA = "0xF6E140")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000DC")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x20000DD")]
	public enum VideoShape
	{
		[Token(Token = "0x40004B3")]
		_360,
		[Token(Token = "0x40004B4")]
		_180,
		[Token(Token = "0x40004B5")]
		Quad
	}

	[Token(Token = "0x20000DE")]
	public enum VideoStereo
	{
		[Token(Token = "0x40004B7")]
		Mono,
		[Token(Token = "0x40004B8")]
		TopBottom,
		[Token(Token = "0x40004B9")]
		LeftRight,
		[Token(Token = "0x40004BA")]
		BottomTop
	}

	[Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0xF6F668", Offset = "0xF6F668", VA = "0xF6F668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xF6F6B0", Offset = "0xF6F6B0", VA = "0xF6F6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF6E824", Offset = "0xF6E824", VA = "0xF6E824")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF6F4BC", Offset = "0xF6F4BC", VA = "0xF6F4BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF6F4C0", Offset = "0xF6F4C0", VA = "0xF6F4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF6F670", Offset = "0xF6F670", VA = "0xF6F670", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000047")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF6E198", Offset = "0xF6E198", VA = "0xF6E198")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF6E1A0", Offset = "0xF6E1A0", VA = "0xF6E1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public long Duration
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF6E1AC", Offset = "0xF6E1AC", VA = "0xF6E1AC")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF6E1B4", Offset = "0xF6E1B4", VA = "0xF6E1B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public long PlaybackPosition
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF6E1BC", Offset = "0xF6E1BC", VA = "0xF6E1BC")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF6E1C4", Offset = "0xF6E1C4", VA = "0xF6E1C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xF6E1CC", Offset = "0xF6E1CC", VA = "0xF6E1CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xF6E450", Offset = "0xF6E450", VA = "0xF6E450")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xF6E4B0", Offset = "0xF6E4B0", VA = "0xF6E4B0")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xF6E7B0", Offset = "0xF6E7B0", VA = "0xF6E7B0")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xF6E84C", Offset = "0xF6E84C", VA = "0xF6E84C")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xF6EB24", Offset = "0xF6EB24", VA = "0xF6EB24")]
	public void Play()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xF6EBA8", Offset = "0xF6EBA8", VA = "0xF6EBA8")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xF6EC28", Offset = "0xF6EC28", VA = "0xF6EC28")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xF6ED14", Offset = "0xF6ED14", VA = "0xF6ED14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xF6F2B0", Offset = "0xF6F2B0", VA = "0xF6F2B0")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xF6F34C", Offset = "0xF6F34C", VA = "0xF6F34C")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xF6F3CC", Offset = "0xF6F3CC", VA = "0xF6F3CC")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xF6F4AC", Offset = "0xF6F4AC", VA = "0xF6F4AC")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000E1")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000E2")]
	private enum PlaybackState
	{
		[Token(Token = "0x40004D7")]
		Playing,
		[Token(Token = "0x40004D8")]
		Paused,
		[Token(Token = "0x40004D9")]
		Rewinding,
		[Token(Token = "0x40004DA")]
		FastForwarding
	}

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xF6F78C", Offset = "0xF6F78C", VA = "0xF6F78C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xF6FAB8", Offset = "0xF6FAB8", VA = "0xF6FAB8")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xF6FC88", Offset = "0xF6FC88", VA = "0xF6FC88")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xF6FDAC", Offset = "0xF6FDAC", VA = "0xF6FDAC")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xF6FEA8", Offset = "0xF6FEA8", VA = "0xF6FEA8")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xF6FD80", Offset = "0xF6FD80", VA = "0xF6FD80")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xF6FF08", Offset = "0xF6FF08", VA = "0xF6FF08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xF6F9B8", Offset = "0xF6F9B8", VA = "0xF6F9B8")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xF70238", Offset = "0xF70238", VA = "0xF70238")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000E3")]
public static class VectorUtil
{
	[Token(Token = "0x6000358")]
	[Address(RVA = "0xF6F238", Offset = "0xF6F238", VA = "0xF6F238")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000E4")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40004DB")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40004DC")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xF70248", Offset = "0xF70248", VA = "0xF70248")]
	private void Start()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xF7089C", Offset = "0xF7089C", VA = "0xF7089C")]
	private void Update()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xF70AF8", Offset = "0xF70AF8", VA = "0xF70AF8")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xF70C5C", Offset = "0xF70C5C", VA = "0xF70C5C")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xF70DC4", Offset = "0xF70DC4", VA = "0xF70DC4")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xF70F48", Offset = "0xF70F48", VA = "0xF70F48")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000E5")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40004E5")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xF70F58", Offset = "0xF70F58", VA = "0xF70F58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xF70FB0", Offset = "0xF70FB0", VA = "0xF70FB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xF70FB4", Offset = "0xF70FB4", VA = "0xF70FB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xF70644", Offset = "0xF70644", VA = "0xF70644")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xF70FB8", Offset = "0xF70FB8", VA = "0xF70FB8")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xF711D4", Offset = "0xF711D4", VA = "0xF711D4")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000E6")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xF711DC", Offset = "0xF711DC", VA = "0xF711DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xF7173C", Offset = "0xF7173C", VA = "0xF7173C")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xF717E8", Offset = "0xF717E8", VA = "0xF717E8")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xF71A78", Offset = "0xF71A78", VA = "0xF71A78")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xF71B4C", Offset = "0xF71B4C", VA = "0xF71B4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xF71C24", Offset = "0xF71C24", VA = "0xF71C24")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xF71C8C", Offset = "0xF71C8C", VA = "0xF71C8C")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x20000E7")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000370")]
	[Address(RVA = "0xF71E34", Offset = "0xF71E34", VA = "0xF71E34")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000E8")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xF71E3C", Offset = "0xF71E3C", VA = "0xF71E3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xF71ED4", Offset = "0xF71ED4", VA = "0xF71ED4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xF71FAC", Offset = "0xF71FAC", VA = "0xF71FAC")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xF72008", Offset = "0xF72008", VA = "0xF72008")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000E9")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000375")]
	[Address(RVA = "0xF72010", Offset = "0xF72010", VA = "0xF72010")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000EA")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xF72420", Offset = "0xF72420", VA = "0xF72420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xF72468", Offset = "0xF72468", VA = "0xF72468", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xF722BC", Offset = "0xF722BC", VA = "0xF722BC")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xF722EC", Offset = "0xF722EC", VA = "0xF722EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF722F0", Offset = "0xF722F0", VA = "0xF722F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF72428", Offset = "0xF72428", VA = "0xF72428", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xF72018", Offset = "0xF72018", VA = "0xF72018")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xF72124", Offset = "0xF72124", VA = "0xF72124")]
	private void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xF720B0", Offset = "0xF720B0", VA = "0xF720B0")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xF722E4", Offset = "0xF722E4", VA = "0xF722E4")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000EC")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xF72470", Offset = "0xF72470", VA = "0xF72470")]
	private void Update()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xF73E18", Offset = "0xF73E18", VA = "0xF73E18")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000ED")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700004E")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF73E20", Offset = "0xF73E20", VA = "0xF73E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xF73E70", Offset = "0xF73E70", VA = "0xF73E70")]
	public void Start()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xF742A8", Offset = "0xF742A8", VA = "0xF742A8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xF74380", Offset = "0xF74380", VA = "0xF74380")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000386")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000388")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000389")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600038A")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600038B")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600038C")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600038D")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xF743D8", Offset = "0xF743D8", VA = "0xF743D8")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xF74418", Offset = "0xF74418", VA = "0xF74418")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xF74484", Offset = "0xF74484", VA = "0xF74484")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xF745D0", Offset = "0xF745D0", VA = "0xF745D0")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xF746A0", Offset = "0xF746A0", VA = "0xF746A0")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xF74184", Offset = "0xF74184", VA = "0xF74184")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xF74770", Offset = "0xF74770", VA = "0xF74770")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xF747BC", Offset = "0xF747BC", VA = "0xF747BC")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xF748CC", Offset = "0xF748CC", VA = "0xF748CC")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000EE")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000EF")]
	public enum DrawMode
	{
		[Token(Token = "0x4000514")]
		Opaque,
		[Token(Token = "0x4000515")]
		OpaqueWithClip,
		[Token(Token = "0x4000516")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000517")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700004F")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF75F10", Offset = "0xF75F10", VA = "0xF75F10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF75F94", Offset = "0xF75F94", VA = "0xF75F94")]
		set
		{
		}
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xF748D4", Offset = "0xF748D4", VA = "0xF748D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xF75598", Offset = "0xF75598", VA = "0xF75598")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xF7560C", Offset = "0xF7560C", VA = "0xF7560C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xF756DC", Offset = "0xF756DC", VA = "0xF756DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xF757AC", Offset = "0xF757AC", VA = "0xF757AC", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xF759B0", Offset = "0xF759B0", VA = "0xF759B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xF76050", Offset = "0xF76050", VA = "0xF76050")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000F0")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xF7610C", Offset = "0xF7610C", VA = "0xF7610C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xF764AC", Offset = "0xF764AC", VA = "0xF764AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xF76640", Offset = "0xF76640", VA = "0xF76640")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xF76648", Offset = "0xF76648", VA = "0xF76648")]
	public void Release()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xF76630", Offset = "0xF76630", VA = "0xF76630")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xF76650", Offset = "0xF76650", VA = "0xF76650")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000F1")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xF76D98", Offset = "0xF76D98", VA = "0xF76D98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xF76DE0", Offset = "0xF76DE0", VA = "0xF76DE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xF76C3C", Offset = "0xF76C3C", VA = "0xF76C3C")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xF76C94", Offset = "0xF76C94", VA = "0xF76C94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xF76C98", Offset = "0xF76C98", VA = "0xF76C98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xF76DA0", Offset = "0xF76DA0", VA = "0xF76DA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xF76F64", Offset = "0xF76F64", VA = "0xF76F64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xF76FAC", Offset = "0xF76FAC", VA = "0xF76FAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xF76C64", Offset = "0xF76C64", VA = "0xF76C64")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF76DE8", Offset = "0xF76DE8", VA = "0xF76DE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF76DEC", Offset = "0xF76DEC", VA = "0xF76DEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xF76F6C", Offset = "0xF76F6C", VA = "0xF76F6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xF76658", Offset = "0xF76658", VA = "0xF76658")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xF76938", Offset = "0xF76938", VA = "0xF76938")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xF76988", Offset = "0xF76988", VA = "0xF76988")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xF76B00", Offset = "0xF76B00", VA = "0xF76B00")]
	public void Release()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xF76BA4", Offset = "0xF76BA4", VA = "0xF76BA4")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xF76A40", Offset = "0xF76A40", VA = "0xF76A40")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xF76C8C", Offset = "0xF76C8C", VA = "0xF76C8C")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000F4")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xF76FB4", Offset = "0xF76FB4", VA = "0xF76FB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xF77008", Offset = "0xF77008", VA = "0xF77008")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000F5")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xF77010", Offset = "0xF77010", VA = "0xF77010")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xF771E4", Offset = "0xF771E4", VA = "0xF771E4")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xF77274", Offset = "0xF77274", VA = "0xF77274")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xF772D0", Offset = "0xF772D0", VA = "0xF772D0")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000F6")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xF784A8", Offset = "0xF784A8", VA = "0xF784A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xF784F0", Offset = "0xF784F0", VA = "0xF784F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xF78210", Offset = "0xF78210", VA = "0xF78210")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xF782D8", Offset = "0xF782D8", VA = "0xF782D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xF782DC", Offset = "0xF782DC", VA = "0xF782DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xF784B0", Offset = "0xF784B0", VA = "0xF784B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xF772D8", Offset = "0xF772D8", VA = "0xF772D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xF775C0", Offset = "0xF775C0", VA = "0xF775C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xF778AC", Offset = "0xF778AC", VA = "0xF778AC")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xF77BD4", Offset = "0xF77BD4", VA = "0xF77BD4")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xF77EAC", Offset = "0xF77EAC", VA = "0xF77EAC")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xF77F94", Offset = "0xF77F94", VA = "0xF77F94")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xF7812C", Offset = "0xF7812C", VA = "0xF7812C")]
	public void Release()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xF7807C", Offset = "0xF7807C", VA = "0xF7807C")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xF78238", Offset = "0xF78238", VA = "0xF78238")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000F8")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000F9")]
	public enum ManipulationType
	{
		[Token(Token = "0x400054C")]
		Default,
		[Token(Token = "0x400054D")]
		ForcedHand,
		[Token(Token = "0x400054E")]
		DollyHand,
		[Token(Token = "0x400054F")]
		DollyAttached,
		[Token(Token = "0x4000550")]
		HorizontalScaled,
		[Token(Token = "0x4000551")]
		VerticalScaled,
		[Token(Token = "0x4000552")]
		Menu
	}

	[Token(Token = "0x20000FA")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000FB")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000FC")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xF784F8", Offset = "0xF784F8", VA = "0xF784F8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xF78558", Offset = "0xF78558", VA = "0xF78558")]
	public void Release()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xF78574", Offset = "0xF78574", VA = "0xF78574")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xF78590", Offset = "0xF78590", VA = "0xF78590")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000FD")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xF78848", Offset = "0xF78848", VA = "0xF78848")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xF78AA8", Offset = "0xF78AA8", VA = "0xF78AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xF78C70", Offset = "0xF78C70", VA = "0xF78C70")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xF792C4", Offset = "0xF792C4", VA = "0xF792C4")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xF7985C", Offset = "0xF7985C", VA = "0xF7985C")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xF7BB64", Offset = "0xF7BB64", VA = "0xF7BB64")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xF7BED8", Offset = "0xF7BED8", VA = "0xF7BED8")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000FE")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xF7CEFC", Offset = "0xF7CEFC", VA = "0xF7CEFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xF7D264", Offset = "0xF7D264", VA = "0xF7D264")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xF7CF98", Offset = "0xF7CF98", VA = "0xF7CF98")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xF7D6CC", Offset = "0xF7D6CC", VA = "0xF7D6CC")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xF7DC3C", Offset = "0xF7DC3C", VA = "0xF7DC3C")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000FF")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xF804C8", Offset = "0xF804C8", VA = "0xF804C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xF80510", Offset = "0xF80510", VA = "0xF80510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF7FE08", Offset = "0xF7FE08", VA = "0xF7FE08")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF801F0", Offset = "0xF801F0", VA = "0xF801F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF801F4", Offset = "0xF801F4", VA = "0xF801F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF804D0", Offset = "0xF804D0", VA = "0xF804D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xF7DC4C", Offset = "0xF7DC4C", VA = "0xF7DC4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xF7DE48", Offset = "0xF7DE48", VA = "0xF7DE48")]
	private void Update()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xF7ED74", Offset = "0xF7ED74", VA = "0xF7ED74")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xF7FB0C", Offset = "0xF7FB0C", VA = "0xF7FB0C")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xF7DDD4", Offset = "0xF7DDD4", VA = "0xF7DDD4")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xF7E098", Offset = "0xF7E098", VA = "0xF7E098")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xF7F06C", Offset = "0xF7F06C", VA = "0xF7F06C")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xF7FE30", Offset = "0xF7FE30", VA = "0xF7FE30")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xF7FEE4", Offset = "0xF7FEE4", VA = "0xF7FEE4")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xF7FF14", Offset = "0xF7FF14", VA = "0xF7FF14")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xF7FCEC", Offset = "0xF7FCEC", VA = "0xF7FCEC")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xF80004", Offset = "0xF80004", VA = "0xF80004")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000101")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xF80518", Offset = "0xF80518", VA = "0xF80518")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xF80684", Offset = "0xF80684", VA = "0xF80684")]
	private void Update()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xF80738", Offset = "0xF80738", VA = "0xF80738")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000102")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000103")]
	public enum BrushState
	{
		[Token(Token = "0x400058F")]
		Idle,
		[Token(Token = "0x4000590")]
		Inking
	}

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xF80740", Offset = "0xF80740", VA = "0xF80740")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xF80748", Offset = "0xF80748", VA = "0xF80748")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xF809F8", Offset = "0xF809F8", VA = "0xF809F8")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xF80C2C", Offset = "0xF80C2C", VA = "0xF80C2C")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xF80E6C", Offset = "0xF80E6C", VA = "0xF80E6C")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xF80910", Offset = "0xF80910", VA = "0xF80910")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xF80F3C", Offset = "0xF80F3C", VA = "0xF80F3C")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000104")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xF80FD8", Offset = "0xF80FD8", VA = "0xF80FD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xF81144", Offset = "0xF81144", VA = "0xF81144")]
	private void Update()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xF8132C", Offset = "0xF8132C", VA = "0xF8132C")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000105")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xF81334", Offset = "0xF81334", VA = "0xF81334")]
	private void Start()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xF8151C", Offset = "0xF8151C", VA = "0xF8151C")]
	private void Update()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xF816BC", Offset = "0xF816BC", VA = "0xF816BC")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000106")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xF8234C", Offset = "0xF8234C", VA = "0xF8234C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xF82394", Offset = "0xF82394", VA = "0xF82394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF82074", Offset = "0xF82074", VA = "0xF82074")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF821D8", Offset = "0xF821D8", VA = "0xF821D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF821DC", Offset = "0xF821DC", VA = "0xF821DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF82354", Offset = "0xF82354", VA = "0xF82354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xF82524", Offset = "0xF82524", VA = "0xF82524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xF8256C", Offset = "0xF8256C", VA = "0xF8256C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF8209C", Offset = "0xF8209C", VA = "0xF8209C")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF8239C", Offset = "0xF8239C", VA = "0xF8239C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF823A0", Offset = "0xF823A0", VA = "0xF823A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF8252C", Offset = "0xF8252C", VA = "0xF8252C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float savedPosterize;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] compactObjects;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xF816C4", Offset = "0xF816C4", VA = "0xF816C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xF819F8", Offset = "0xF819F8", VA = "0xF819F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xF81D98", Offset = "0xF81D98", VA = "0xF81D98")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xF81F0C", Offset = "0xF81F0C", VA = "0xF81F0C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xF81E88", Offset = "0xF81E88", VA = "0xF81E88")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__19))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xF81FF0", Offset = "0xF81FF0", VA = "0xF81FF0")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__20))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xF820C4", Offset = "0xF820C4", VA = "0xF820C4")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xF820E4", Offset = "0xF820E4", VA = "0xF820E4")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xF82104", Offset = "0xF82104", VA = "0xF82104")]
	public void OnPosterizeChanged(float newValue)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xF82124", Offset = "0xF82124", VA = "0xF82124")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xF81990", Offset = "0xF81990", VA = "0xF81990")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xF82158", Offset = "0xF82158", VA = "0xF82158")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xF82164", Offset = "0xF82164", VA = "0xF82164")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xF81A10", Offset = "0xF81A10", VA = "0xF81A10")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xF82170", Offset = "0xF82170", VA = "0xF82170")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000109")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xF82574", Offset = "0xF82574", VA = "0xF82574")]
	private void Start()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xF82628", Offset = "0xF82628", VA = "0xF82628")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x200010A")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xF82630", Offset = "0xF82630", VA = "0xF82630")]
	private void Awake()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xF8269C", Offset = "0xF8269C", VA = "0xF8269C")]
	private void Update()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xF82990", Offset = "0xF82990", VA = "0xF82990")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x200010B")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xF82998", Offset = "0xF82998", VA = "0xF82998")]
	private void Update()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xF82DEC", Offset = "0xF82DEC", VA = "0xF82DEC")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x200010C")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xF82DF4", Offset = "0xF82DF4", VA = "0xF82DF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xF8305C", Offset = "0xF8305C", VA = "0xF8305C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xF830A8", Offset = "0xF830A8", VA = "0xF830A8")]
	public void Release()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xF830E8", Offset = "0xF830E8", VA = "0xF830E8")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200010D")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong anchorHandle_;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas canvas_;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivot_;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject anchorMenu_;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSelected_;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isHovered_;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI anchorName_;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject saveIcon_;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image labelImage_;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color labelBaseColor_;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color labelHighlightColor_;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Color labelSelectedColor_;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnchorUIManager uiManager_;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MeshRenderer[] renderers_;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int menuIndex_;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button selectedButton_;

	[Token(Token = "0x1700005C")]
	public ulong anchorHandle
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF830F0", Offset = "0xF830F0", VA = "0xF830F0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xF830F8", Offset = "0xF830F8", VA = "0xF830F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xF831E0", Offset = "0xF831E0", VA = "0xF831E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xF83440", Offset = "0xF83440", VA = "0xF83440")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xF834A4", Offset = "0xF834A4", VA = "0xF834A4")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xF83504", Offset = "0xF83504", VA = "0xF83504")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xF83564", Offset = "0xF83564", VA = "0xF83564")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xF83680", Offset = "0xF83680", VA = "0xF83680")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xF83788", Offset = "0xF83788", VA = "0xF83788")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xF838B0", Offset = "0xF838B0", VA = "0xF838B0")]
	public void SetAnchorHandle(ulong handle)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xF83940", Offset = "0xF83940", VA = "0xF83940")]
	public void ShowSaveIcon()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xF83218", Offset = "0xF83218", VA = "0xF83218")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xF8334C", Offset = "0xF8334C", VA = "0xF8334C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xF83960", Offset = "0xF83960", VA = "0xF83960")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xF83A60", Offset = "0xF83A60", VA = "0xF83A60")]
	public Anchor()
	{
	}
}
[Token(Token = "0x200010E")]
public class AnchorHelpers
{
	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera camera;

	[Token(Token = "0x1700005D")]
	private static Camera MainCamera
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0xF83A68", Offset = "0xF83A68", VA = "0xF83A68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xF83B18", Offset = "0xF83B18", VA = "0xF83B18")]
	public static OVRPlugin.Posef UnityWorldSpacePoseToTrackingSpacePose(Transform pose)
	{
		return default(OVRPlugin.Posef);
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xF83B90", Offset = "0xF83B90", VA = "0xF83B90")]
	public static OVRPose TrackingSpacePoseToUnityWorldSpacePose(OVRPlugin.Posef pose)
	{
		return default(OVRPose);
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xF83BF8", Offset = "0xF83BF8", VA = "0xF83BF8")]
	public static OVRPose getTransformUnityWorldFromDevice()
	{
		return default(OVRPose);
	}

	[Token(Token = "0x6000446")]
	public static T ByteArrayToStruct<T>(byte[] bytes) where T : struct
	{
		return (T)null;
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xF83C44", Offset = "0xF83C44", VA = "0xF83C44")]
	public static string UuidToString(byte[] encodedMessage)
	{
		return null;
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xF83EC4", Offset = "0xF83EC4", VA = "0xF83EC4")]
	public static byte[] StringToUuid(string str)
	{
		return null;
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xF84028", Offset = "0xF84028", VA = "0xF84028")]
	private static int GetHexVal(char hex)
	{
		return default(int);
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xF840E0", Offset = "0xF840E0", VA = "0xF840E0")]
	public AnchorHelpers()
	{
	}
}
[Token(Token = "0x200010F")]
public abstract class AnchorSession : MonoBehaviour
{
	[Token(Token = "0x2000110")]
	public enum StorageLocation
	{
		[Token(Token = "0x40005D8")]
		LOCAL
	}

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSession Instance;

	[Token(Token = "0x40005D2")]
	public const ulong kInvalidHandle = ulong.MaxValue;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, Anchor> handleToAnchor;

	[Token(Token = "0x40005D4")]
	protected const int maxEvents = 5;

	[Token(Token = "0x40005D5")]
	protected const float eventPollingRate = 0.1f;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject anchorPrefab_;

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xF840E8", Offset = "0xF840E8", VA = "0xF840E8", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xF83E38", Offset = "0xF83E38", VA = "0xF83E38")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xF841E4", Offset = "0xF841E4", VA = "0xF841E4")]
	protected static bool isFlagSet(uint bitset, uint flag)
	{
		return default(bool);
	}

	[Token(Token = "0x600044E")]
	public abstract ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor);

	[Token(Token = "0x600044F")]
	public abstract void DestroyAnchor(ulong anchorHandle);

	[Token(Token = "0x6000450")]
	public abstract void SaveAnchor(ulong anchorHandle, StorageLocation location);

	[Token(Token = "0x6000451")]
	public abstract void EraseAnchor(ulong anchorHandle);

	[Token(Token = "0x6000452")]
	public abstract void QueryAllLocalAnchors();

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xF841F0", Offset = "0xF841F0", VA = "0xF841F0")]
	protected AnchorSession()
	{
	}
}
[Token(Token = "0x2000111")]
public class AnchorSpawner : MonoBehaviour
{
	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSpawner Instance;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject anchorPrefab_;

	[Token(Token = "0x1700005E")]
	public GameObject AnchorPrefab
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF84278", Offset = "0xF84278", VA = "0xF84278")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xF84280", Offset = "0xF84280", VA = "0xF84280")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xF84374", Offset = "0xF84374", VA = "0xF84374")]
	public void PlaceAnchorAtTransform(Transform transform)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xF8459C", Offset = "0xF8459C", VA = "0xF8459C")]
	public AnchorSpawner()
	{
	}
}
[Token(Token = "0x2000112")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x2000113")]
	public enum AnchorMode
	{
		[Token(Token = "0x40005EE")]
		Create,
		[Token(Token = "0x40005EF")]
		Select
	}

	[Token(Token = "0x2000114")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject mainMenu_;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject createModeButton_;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject selectModeButton_;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform trackedDevice_;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform raycastOrigin_;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool drawRaycast_;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LineRenderer lineRenderer_;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor hoveredAnchor_;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Anchor selectedAnchor_;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnchorMode mode_;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int menuIndex_;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Button selectedButton_;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject placementPreview_;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform anchorPlacementTransform_;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate primaryPressDelegate_;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isFocused_;

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xF845A4", Offset = "0xF845A4", VA = "0xF845A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xF84670", Offset = "0xF84670", VA = "0xF84670")]
	private void Start()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xF847C0", Offset = "0xF847C0", VA = "0xF847C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xF84C30", Offset = "0xF84C30", VA = "0xF84C30")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xF84C9C", Offset = "0xF84C9C", VA = "0xF84C9C")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xF84758", Offset = "0xF84758", VA = "0xF84758")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xF84D14", Offset = "0xF84D14", VA = "0xF84D14")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xF84D9C", Offset = "0xF84D9C", VA = "0xF84D9C")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xF84DBC", Offset = "0xF84DBC", VA = "0xF84DBC")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xF84CF4", Offset = "0xF84CF4", VA = "0xF84CF4")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xF84B3C", Offset = "0xF84B3C", VA = "0xF84B3C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xF84FBC", Offset = "0xF84FBC", VA = "0xF84FBC")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xF84E44", Offset = "0xF84E44", VA = "0xF84E44")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xF84F30", Offset = "0xF84F30", VA = "0xF84F30")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xF850BC", Offset = "0xF850BC", VA = "0xF850BC")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xF84F50", Offset = "0xF84F50", VA = "0xF84F50")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xF84F88", Offset = "0xF84F88", VA = "0xF84F88")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xF848C0", Offset = "0xF848C0", VA = "0xF848C0")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xF85114", Offset = "0xF85114", VA = "0xF85114")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xF8513C", Offset = "0xF8513C", VA = "0xF8513C")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xF851CC", Offset = "0xF851CC", VA = "0xF851CC")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xF85314", Offset = "0xF85314", VA = "0xF85314")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x2000115")]
public class SpatialAnchorSession : AnchorSession
{
	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<ulong, ulong> locateAnchorRequest;

	[Token(Token = "0x40005F1")]
	private const string numUuids = "numUuids";

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xF85364", Offset = "0xF85364", VA = "0xF85364")]
	private void Start()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xF85560", Offset = "0xF85560", VA = "0xF85560")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xF8575C", Offset = "0xF8575C", VA = "0xF8575C")]
	private void SpatialEntitySetComponentEnabled(ulong requestId, bool result, OVRPlugin.SpatialEntityComponentType componentType, ulong space)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xF85954", Offset = "0xF85954", VA = "0xF85954")]
	private void SpatialAnchorSaved(ulong requestId, ulong space, bool result, OVRPlugin.SpatialEntityUuid uuid)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xF85E50", Offset = "0xF85E50", VA = "0xF85E50")]
	private void SpatialEntityStorageErase(ulong requestId, bool result, OVRPlugin.SpatialEntityUuid uuid, OVRPlugin.SpatialEntityStorageLocation location)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xF86190", Offset = "0xF86190", VA = "0xF86190")]
	private void SpatialEntityQueryResults(ulong requestId, int numResults, OVRPlugin.SpatialEntityQueryResult[] results)
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xF86884", Offset = "0xF86884", VA = "0xF86884")]
	private void SpatialEntityQueryComplete(ulong requestId, bool result, int numFound)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xF85D84", Offset = "0xF85D84", VA = "0xF85D84")]
	private string GetUuidString(OVRPlugin.SpatialEntityUuid uuid)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xF86484", Offset = "0xF86484", VA = "0xF86484")]
	private void tryEnableComponent(ulong anchorHandle, OVRPlugin.SpatialEntityComponentType type)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xF85848", Offset = "0xF85848", VA = "0xF85848")]
	private void CreateAnchorGameobject(ulong anchorHandle)
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xF86AEC", Offset = "0xF86AEC", VA = "0xF86AEC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xF86DAC", Offset = "0xF86DAC", VA = "0xF86DAC", Slot = "5")]
	public override ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor)
	{
		return default(ulong);
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xF86F3C", Offset = "0xF86F3C", VA = "0xF86F3C", Slot = "6")]
	public override void DestroyAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xF870DC", Offset = "0xF870DC", VA = "0xF870DC", Slot = "8")]
	public override void EraseAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0xF8728C", Offset = "0xF8728C", VA = "0xF8728C")]
	public void QueryAnchorByUuid()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xF8754C", Offset = "0xF8754C", VA = "0xF8754C", Slot = "9")]
	public override void QueryAllLocalAnchors()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xF87650", Offset = "0xF87650", VA = "0xF87650", Slot = "7")]
	public override void SaveAnchor(ulong anchorHandle, StorageLocation location)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xF87794", Offset = "0xF87794", VA = "0xF87794")]
	public SpatialAnchorSession()
	{
	}
}
[Token(Token = "0x2000116")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xF87818", Offset = "0xF87818", VA = "0xF87818")]
	private void Start()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xF87A2C", Offset = "0xF87A2C", VA = "0xF87A2C")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xF87B30", Offset = "0xF87B30", VA = "0xF87B30")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x2000118")]
public class SpawnEffect : MonoBehaviour
{
	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float spawnEffectTime;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float pause;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve fadeIn;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Renderer _renderer;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int shaderProperty;

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xF87B54", Offset = "0xF87B54", VA = "0xF87B54")]
	private void Start()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xF87C54", Offset = "0xF87C54", VA = "0xF87C54")]
	private void Update()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xF87D14", Offset = "0xF87D14", VA = "0xF87D14")]
	public SpawnEffect()
	{
	}
}
[Token(Token = "0x2000119")]
[CreateAssetMenu]
public class RampAsset : ScriptableObject
{
	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient gradient;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int size;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool up;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool overwriteExisting;

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xF87D28", Offset = "0xF87D28", VA = "0xF87D28")]
	public RampAsset()
	{
	}
}
[Token(Token = "0x200011A")]
public class AdjustTimeScale : MonoBehaviour
{
	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI textMesh;

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xF87DAC", Offset = "0xF87DAC", VA = "0xF87DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xF87E04", Offset = "0xF87E04", VA = "0xF87E04")]
	private void Update()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xF88008", Offset = "0xF88008", VA = "0xF88008")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xF8802C", Offset = "0xF8802C", VA = "0xF8802C")]
	public AdjustTimeScale()
	{
	}
}
[Token(Token = "0x200011B")]
public class ProximityActivate : MonoBehaviour
{
	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform distanceActivator;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform lookAtActivator;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform activator;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool activeState;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CanvasGroup target;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool lookAtCamera;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool enableInfoPanel;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject infoIcon;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float alpha;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CanvasGroup infoPanel;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Quaternion originRotation;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion targetRotation;

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xF88034", Offset = "0xF88034", VA = "0xF88034")]
	private void Start()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xF88144", Offset = "0xF88144", VA = "0xF88144")]
	private bool IsTargetNear()
	{
		return default(bool);
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xF884FC", Offset = "0xF884FC", VA = "0xF884FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xF887B4", Offset = "0xF887B4", VA = "0xF887B4")]
	public ProximityActivate()
	{
	}
}
[Token(Token = "0x200011C")]
[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterMotor : MonoBehaviour
{
	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CursorLockMode cursorLockMode;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool cursorVisible;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Movement")]
	public float walkSpeed;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float runSpeed;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float gravity;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Look")]
	[Space]
	public Transform cameraPivot;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float lookSpeed;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool invertY;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Smoothing")]
	[Space]
	public float movementAcceleration;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CharacterController controller;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 movement;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 finalMovement;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float speed;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion targetRotation;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion targetPivotRotation;

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xF887C4", Offset = "0xF887C4", VA = "0xF887C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xF88884", Offset = "0xF88884", VA = "0xF88884")]
	private void Update()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xF88A4C", Offset = "0xF88A4C", VA = "0xF88A4C")]
	private void UpdateLookRotation()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xF8889C", Offset = "0xF8889C", VA = "0xF8889C")]
	private void UpdateTranslation()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xF88DEC", Offset = "0xF88DEC", VA = "0xF88DEC")]
	public SimpleCharacterMotor()
	{
	}
}
[Token(Token = "0x200011D")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200011E")]
	public class Section
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xF88E30", Offset = "0xF88E30", VA = "0xF88E30")]
		public Section()
		{
		}
	}

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xF88E28", Offset = "0xF88E28", VA = "0xF88E28")]
	public Readme()
	{
	}
}
[Token(Token = "0x200011F")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x600049C")]
	[Address(RVA = "0xF88E38", Offset = "0xF88E38", VA = "0xF88E38")]
	private void Update()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xF88ED0", Offset = "0xF88ED0", VA = "0xF88ED0")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x2000120")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xF88ED8", Offset = "0xF88ED8", VA = "0xF88ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xF88F30", Offset = "0xF88F30", VA = "0xF88F30")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xF89048", Offset = "0xF89048", VA = "0xF89048")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x2000121")]
public class skyboxspace_demo_v1 : MonoBehaviour
{
	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] skyBoxMaterial;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] sunPosition;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int skyBoxLength;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int currentSkyBoxIndex;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string topText;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float counter;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int frames;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fps;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GUIStyle whiteStyle;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GUIStyle blackStyle;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sun;

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xF89050", Offset = "0xF89050", VA = "0xF89050")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xF89100", Offset = "0xF89100", VA = "0xF89100")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xF89258", Offset = "0xF89258", VA = "0xF89258", Slot = "4")]
	protected virtual void OnGUI()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xF894F4", Offset = "0xF894F4", VA = "0xF894F4")]
	private static void DrawText(string text, TextAnchor anchor, int offsetX = 15, int offsetY = 15)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xF89A18", Offset = "0xF89A18", VA = "0xF89A18")]
	public skyboxspace_demo_v1()
	{
	}
}
[Token(Token = "0x2000122")]
public class skyboxspace_mouselook_v1 : MonoBehaviour
{
	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 sensitivity;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 smoothing;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 targetDirection;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject characterBody;

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xF89A20", Offset = "0xF89A20", VA = "0xF89A20")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xF89B0C", Offset = "0xF89B0C", VA = "0xF89B0C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xF8A074", Offset = "0xF8A074", VA = "0xF8A074")]
	public skyboxspace_mouselook_v1()
	{
	}
}
[Token(Token = "0x2000123")]
public class ExampleCardItemAction : MonoBehaviour
{
	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text title;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text description;

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xF8A094", Offset = "0xF8A094", VA = "0xF8A094")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xF8A14C", Offset = "0xF8A14C", VA = "0xF8A14C")]
	private void ShowDescription(Card card)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xF8A1A4", Offset = "0xF8A1A4", VA = "0xF8A1A4")]
	public ExampleCardItemAction()
	{
	}
}
[Token(Token = "0x2000124")]
public class ExampleDynamicCardList : MonoBehaviour
{
	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CardListManager clm;

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xF8A1AC", Offset = "0xF8A1AC", VA = "0xF8A1AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xF8A1B0", Offset = "0xF8A1B0", VA = "0xF8A1B0")]
	public void UpdateList()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xF8A360", Offset = "0xF8A360", VA = "0xF8A360")]
	public ExampleDynamicCardList()
	{
	}
}
[Token(Token = "0x2000125")]
public class ExampleOptionControl : MonoBehaviour
{
	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OptionsManager optionsManager;

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xF8A368", Offset = "0xF8A368", VA = "0xF8A368")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xF8A430", Offset = "0xF8A430", VA = "0xF8A430")]
	private void SwitchInteractionMode(int i)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xF8A5B8", Offset = "0xF8A5B8", VA = "0xF8A5B8")]
	public ExampleOptionControl()
	{
	}
}
[Token(Token = "0x2000126")]
public class ExternalCamera : MonoBehaviour
{
	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform _pivot;

	[Token(Token = "0x4000640")]
	private const float Speed = 60f;

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xF8A5C0", Offset = "0xF8A5C0", VA = "0xF8A5C0")]
	public void Update()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xF8A954", Offset = "0xF8A954", VA = "0xF8A954")]
	public ExternalCamera()
	{
	}
}
[Token(Token = "0x2000127")]
public class MainMenuInstaller : MonoInstaller
{
	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UIAudioClips _uiAudioClips;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LevelScreenshots _screenshots;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ScreenFade _screenFade;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ScreenFade _focusFade;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioMixer _mixer;

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xF8A95C", Offset = "0xF8A95C", VA = "0xF8A95C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xF8A968", Offset = "0xF8A968", VA = "0xF8A968", Slot = "8")]
	public override void InstallBindings()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xF8AE5C", Offset = "0xF8AE5C", VA = "0xF8AE5C")]
	private void Set90Hz()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xF8AE60", Offset = "0xF8AE60", VA = "0xF8AE60")]
	public MainMenuInstaller()
	{
	}
}
[Token(Token = "0x2000128")]
public class DifficultyDropdown : MonoBehaviour
{
	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameSettings _gameSettings;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dropdown _dropdown;

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xF8AE68", Offset = "0xF8AE68", VA = "0xF8AE68")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xF8AF6C", Offset = "0xF8AF6C", VA = "0xF8AF6C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xF8B014", Offset = "0xF8B014", VA = "0xF8B014")]
	private void OnValueChanged(int index)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xF8B030", Offset = "0xF8B030", VA = "0xF8B030")]
	public DifficultyDropdown()
	{
	}
}
[Token(Token = "0x2000129")]
public class SetLevelButtonTexts : MonoBehaviour
{
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xF8B038", Offset = "0xF8B038", VA = "0xF8B038")]
	[Button]
	private void Set()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xF8B210", Offset = "0xF8B210", VA = "0xF8B210")]
	public SetLevelButtonTexts()
	{
	}
}
[Token(Token = "0x200012A")]
public class IntroInstaller : MonoInstaller
{
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xF8B218", Offset = "0xF8B218", VA = "0xF8B218", Slot = "8")]
	public override void InstallBindings()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xF8B2D4", Offset = "0xF8B2D4", VA = "0xF8B2D4")]
	public IntroInstaller()
	{
	}
}
[Token(Token = "0x200012B")]
public class IntroMenuItem : MonoBehaviour
{
	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _sceneName;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SignalBus _signalBus;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Collider _collider;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform _rectTransform;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Tweener _tweener;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _canHighlight;

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xF8B2DC", Offset = "0xF8B2DC", VA = "0xF8B2DC")]
	[Inject]
	private void Construct(SignalBus signalBus, Collider collider)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xF8B30C", Offset = "0xF8B30C", VA = "0xF8B30C")]
	public void LoadLevel()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xF8B368", Offset = "0xF8B368", VA = "0xF8B368")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xF8B3C0", Offset = "0xF8B3C0", VA = "0xF8B3C0")]
	public void Disable()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xF8B3E0", Offset = "0xF8B3E0", VA = "0xF8B3E0")]
	public void Enable()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xF8B400", Offset = "0xF8B400", VA = "0xF8B400")]
	public void Highlight()
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xF8B578", Offset = "0xF8B578", VA = "0xF8B578")]
	public void Dehighlight()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xF8B6C0", Offset = "0xF8B6C0", VA = "0xF8B6C0")]
	public IntroMenuItem()
	{
	}
}
[Token(Token = "0x200012C")]
public struct IntroMenuItemHitSignal
{
	[Token(Token = "0x1700005F")]
	public IntroMenuItem IntroMenuItem
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xF8B6E4", Offset = "0xF8B6E4", VA = "0xF8B6E4")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xF8B6EC", Offset = "0xF8B6EC", VA = "0xF8B6EC")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Token(Token = "0x200012D")]
public class ScreenshotTaker : MonoBehaviour
{
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xF8B6F4", Offset = "0xF8B6F4", VA = "0xF8B6F4")]
	[Button]
	private void TakeScreenshot()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xF8B9C0", Offset = "0xF8B9C0", VA = "0xF8B9C0")]
	public ScreenshotTaker()
	{
	}
}
namespace Cybrix.Tools.Levels
{
	[Token(Token = "0x200012E")]
	public class GridSnapper : MonoBehaviour
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF8B9C8", Offset = "0xF8B9C8", VA = "0xF8B9C8")]
		[Button]
		private void SnapToGrid()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xF8BC38", Offset = "0xF8BC38", VA = "0xF8BC38")]
		public GridSnapper()
		{
		}
	}
}
namespace Cybrix.UI
{
	[Token(Token = "0x200012F")]
	public class CalibrateUI : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TrackingSpace _trackingSpace;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF8BC40", Offset = "0xF8BC40", VA = "0xF8BC40")]
		[Inject]
		private void Construct(TrackingSpace trackingSpace)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF8BC48", Offset = "0xF8BC48", VA = "0xF8BC48")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xF8BC64", Offset = "0xF8BC64", VA = "0xF8BC64")]
		public CalibrateUI()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class EndlessLevelSelectionUI : UIElement
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LeaderboardUI _leaderboardUI;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractionSystem _interactionSystem;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIController _uiController;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF8BC6C", Offset = "0xF8BC6C", VA = "0xF8BC6C")]
		[Inject]
		private void Construct(InteractionSystem interactionSystem, UIController uiController)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF8BC9C", Offset = "0xF8BC9C", VA = "0xF8BC9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xF8BD90", Offset = "0xF8BD90", VA = "0xF8BD90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xF8BDE4", Offset = "0xF8BDE4", VA = "0xF8BDE4")]
		public void PlayLevel(string name)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF8BE44", Offset = "0xF8BE44", VA = "0xF8BE44")]
		public EndlessLevelSelectionUI()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class GameSlot : MonoBehaviour
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _slotName;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _completion;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _emptyColor;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _clearButton;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _yesNo;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PersistentData _persistentData;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xF8BE6C", Offset = "0xF8BE6C", VA = "0xF8BE6C")]
		[Inject]
		private void Construct(PersistentData persistentData)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xF8BE74", Offset = "0xF8BE74", VA = "0xF8BE74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xF8BE78", Offset = "0xF8BE78", VA = "0xF8BE78")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xF8BEC8", Offset = "0xF8BEC8", VA = "0xF8BEC8")]
		private void SetButtonState(float percent)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xF8C008", Offset = "0xF8C008", VA = "0xF8C008")]
		public void SetYesNoActive(bool value)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xF8C028", Offset = "0xF8C028", VA = "0xF8C028")]
		public void OnClick()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xF8C124", Offset = "0xF8C124", VA = "0xF8C124")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xF8C1D4", Offset = "0xF8C1D4", VA = "0xF8C1D4")]
		public void No()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xF8C284", Offset = "0xF8C284", VA = "0xF8C284")]
		public void Yes()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xF8C378", Offset = "0xF8C378", VA = "0xF8C378")]
		public GameSlot()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class GameSlotsUI : MonoBehaviour
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<GameSlot> _gameSlots;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xF8C380", Offset = "0xF8C380", VA = "0xF8C380")]
		[Inject]
		private void Construct(List<GameSlot> gameSlots)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xF8C388", Offset = "0xF8C388", VA = "0xF8C388")]
		public void OnBackClicked()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF8C490", Offset = "0xF8C490", VA = "0xF8C490")]
		public GameSlotsUI()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class HeightCalibrationUI : MonoBehaviour
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _movingElements;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _targetArea;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _target;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _bar;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _message;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MainMenuUI _mainMenuUI;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _initialMenu;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TrackingSpace _trackingSpace;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly ReactiveProperty<bool> _isAligned;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Tweener _barFillTween;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _wasCalibrated;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _initialMessageLocalPosition;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xF8C534", Offset = "0xF8C534", VA = "0xF8C534")]
		[Inject]
		private void Construct(TrackingSpace trackingSpace)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF8C53C", Offset = "0xF8C53C", VA = "0xF8C53C")]
		[Inject]
		private void Initialize()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xF8C574", Offset = "0xF8C574", VA = "0xF8C574")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF8C624", Offset = "0xF8C624", VA = "0xF8C624")]
		private void Start()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xF8CA48", Offset = "0xF8CA48", VA = "0xF8CA48")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xF8CC58", Offset = "0xF8CC58", VA = "0xF8CC58")]
		public HeightCalibrationUI()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class InitialMenuUI : MonoBehaviour
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xF8D1DC", Offset = "0xF8D1DC", VA = "0xF8D1DC")]
		public void QuitGame()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xF8D264", Offset = "0xF8D264", VA = "0xF8D264")]
		public InitialMenuUI()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class LevelSelectionInstaller : MonoInstaller
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF8D26C", Offset = "0xF8D26C", VA = "0xF8D26C", Slot = "8")]
		public override void InstallBindings()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF8D3B8", Offset = "0xF8D3B8", VA = "0xF8D3B8")]
		public LevelSelectionInstaller()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class LevelButton : MonoBehaviour
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Button _button;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI _text;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LevelButtonFrame _frame;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform _rectTransform;

		[Token(Token = "0x17000060")]
		public Button.ButtonClickedEvent OnClick
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xF8D3C0", Offset = "0xF8D3C0", VA = "0xF8D3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public bool IsInteractable
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xF8D3DC", Offset = "0xF8D3DC", VA = "0xF8D3DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xF8D3F8", Offset = "0xF8D3F8", VA = "0xF8D3F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF8D448", Offset = "0xF8D448", VA = "0xF8D448")]
		[Inject]
		private void Construct(Button button, TextMeshProUGUI text, LevelButtonFrame frame, RectTransform rectTransform)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xF8D4A8", Offset = "0xF8D4A8", VA = "0xF8D4A8")]
		[Inject]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF8D53C", Offset = "0xF8D53C", VA = "0xF8D53C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xF8D5D0", Offset = "0xF8D5D0", VA = "0xF8D5D0")]
		private void OnButtonClick()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF8D610", Offset = "0xF8D610", VA = "0xF8D610")]
		public LevelButton()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class LevelButtonFrame : MonoBehaviour
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform _rectTransform;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF8D618", Offset = "0xF8D618", VA = "0xF8D618")]
		[Inject]
		private void Construct(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF8D5F0", Offset = "0xF8D5F0", VA = "0xF8D5F0")]
		public void SetParent(RectTransform parent)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xF8D620", Offset = "0xF8D620", VA = "0xF8D620")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF8D648", Offset = "0xF8D648", VA = "0xF8D648")]
		public LevelButtonFrame()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[CreateAssetMenu(fileName = "Level Screenshots", menuName = "Cybrix/Level Screenshots")]
	public class LevelScreenshots : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		private struct Data
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string _level;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Sprite _screenshot;

			[Token(Token = "0x17000062")]
			public string Level
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0xF8D82C", Offset = "0xF8D82C", VA = "0xF8D82C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			public Sprite Screenshot
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0xF8D834", Offset = "0xF8D834", VA = "0xF8D834")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[TableList]
		private List<Data> _data;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF8D650", Offset = "0xF8D650", VA = "0xF8D650")]
		public Sprite Get(string levelName)
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF8D824", Offset = "0xF8D824", VA = "0xF8D824")]
		public LevelScreenshots()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class LevelSelectionDetailsUI : UIElement
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		private struct SpawnablesData
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private ESpawnableType _type;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			private ESpawnable _spawnable;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameObject _gameObject;

			[Token(Token = "0x17000065")]
			public ESpawnableType Type
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0xF8EADC", Offset = "0xF8EADC", VA = "0xF8EADC")]
				get
				{
					return default(ESpawnableType);
				}
			}

			[Token(Token = "0x17000066")]
			public ESpawnable Spawnable
			{
				[Token(Token = "0x600051E")]
				[Address(RVA = "0xF8EAE4", Offset = "0xF8EAE4", VA = "0xF8EAE4")]
				get
				{
					return default(ESpawnable);
				}
			}

			[Token(Token = "0x17000067")]
			public GameObject GameObject
			{
				[Token(Token = "0x600051F")]
				[Address(RVA = "0xF8EAEC", Offset = "0xF8EAEC", VA = "0xF8EAEC")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x200013F")]
		private enum ESpawnableType
		{
			[Token(Token = "0x4000688")]
			PowerUp,
			[Token(Token = "0x4000689")]
			Destructible
		}

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _lives;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _score;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Toggle> _difficultyToggles;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[TableList]
		[SerializeField]
		private List<SpawnablesData> _spawnables;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _powerUps;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _destructibles;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _screenshotPlaceholder;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LeaderboardUI _leaderboard;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameSettings _gameSettings;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InteractionSystem _interactionSystem;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private LevelScreenshots _screenshots;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ILeaderboardService _leaderboardService;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIController _uiController;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private LevelSettings _settings;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Subject<EDifficulty> _difficultyChanged;

		[Token(Token = "0x17000064")]
		public bool IsActive
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xF8D850", Offset = "0xF8D850", VA = "0xF8D850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xF8D870", Offset = "0xF8D870", VA = "0xF8D870")]
		[Inject]
		private void Construct(GameSettings gameSettings, InteractionSystem interactionSystem, LevelScreenshots screenshots, ILeaderboardService leaderboardService, UIController uiController)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xF8D8E4", Offset = "0xF8D8E4", VA = "0xF8D8E4")]
		[Inject]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xF8DC60", Offset = "0xF8DC60", VA = "0xF8DC60")]
		public void Activate(string levelName)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xF8E1EC", Offset = "0xF8E1EC", VA = "0xF8E1EC")]
		public void LoadLeaderboardOnLevelChanged()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xF8DC64", Offset = "0xF8DC64", VA = "0xF8DC64")]
		public void FillWithData(string levelName)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF8E2AC", Offset = "0xF8E2AC", VA = "0xF8E2AC")]
		private void SetNormalDifficulty(bool value)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xF8E3CC", Offset = "0xF8E3CC", VA = "0xF8E3CC")]
		private void SetHardDifficulty(bool value)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF8E4F0", Offset = "0xF8E4F0", VA = "0xF8E4F0")]
		private void SetExtremeDifficulty(bool value)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xF8E614", Offset = "0xF8E614", VA = "0xF8E614")]
		public void PlayLevel()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xF8E678", Offset = "0xF8E678", VA = "0xF8E678")]
		private void OnLeaderboardLoaded(LeaderboardLoadInfo info)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF8E7C0", Offset = "0xF8E7C0", VA = "0xF8E7C0")]
		public LevelSelectionDetailsUI()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class LevelSelectionUI : UIElement
	{
		[Token(Token = "0x2000142")]
		private enum EPageNavigation
		{
			[Token(Token = "0x400069B")]
			Previous,
			[Token(Token = "0x400069C")]
			Next
		}

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _levelPages;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _levelPageButtons;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LevelSelectionDetailsUI _details;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InteractionSystem _interactionSystem;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<LevelButton> _buttons;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PersistentData _persistentData;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LevelButtonFrame _levelButtonFrame;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _currentPageIndex;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<RectTransform> _levelPagesRectTransforms;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _currentLevel;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<MainMenuUIEffects> _levelPagesEffects;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LevelButton _lastPlayedLevelButton;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIController _uiController;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF8EBB8", Offset = "0xF8EBB8", VA = "0xF8EBB8")]
		[Inject]
		private void Construct(LevelSelectionDetailsUI details, InteractionSystem interactionSystem, List<LevelButton> buttons, PersistentData persistentData, LevelButtonFrame levelButtonFrame, UIController uiController)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF8EC48", Offset = "0xF8EC48", VA = "0xF8EC48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF8F014", Offset = "0xF8F014", VA = "0xF8F014")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF8F4B8", Offset = "0xF8F4B8", VA = "0xF8F4B8")]
		public void SelectLevel(string levelName)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xF8F594", Offset = "0xF8F594", VA = "0xF8F594")]
		private void OnLeaderboardRead(LeaderboardLoadInfo info)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xF8F5B4", Offset = "0xF8F5B4", VA = "0xF8F5B4")]
		public void GetNextPage()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF8FA10", Offset = "0xF8FA10", VA = "0xF8FA10")]
		public void GetPreviousPage()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xF8F698", Offset = "0xF8F698", VA = "0xF8F698")]
		private void UpdatePages(EPageNavigation navigation)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF8F3D8", Offset = "0xF8F3D8", VA = "0xF8F3D8")]
		private void ActivatePage(int level)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xF8F248", Offset = "0xF8F248", VA = "0xF8F248")]
		private void SetPageButtons()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF8FE28", Offset = "0xF8FE28", VA = "0xF8FE28")]
		public LevelSelectionUI()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class MainMenuUI : MonoBehaviour
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _initialMenu;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _levelSelection;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _endlessLevelMenu;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameSettings _gameSettings;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _currentlyOpen;

		[Token(Token = "0x17000068")]
		public static EGameMode LastModePlayed
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF90224", Offset = "0xF90224", VA = "0xF90224")]
			[CompilerGenerated]
			get
			{
				return default(EGameMode);
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xF9026C", Offset = "0xF9026C", VA = "0xF9026C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public static EDifficulty LastDifficultyPlayed
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xF902B8", Offset = "0xF902B8", VA = "0xF902B8")]
			[CompilerGenerated]
			get
			{
				return default(EDifficulty);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF90300", Offset = "0xF90300", VA = "0xF90300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF9034C", Offset = "0xF9034C", VA = "0xF9034C")]
		[Inject]
		private void Construct(GameSettings gameSettings)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF90354", Offset = "0xF90354", VA = "0xF90354")]
		private void Start()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF8CFAC", Offset = "0xF8CFAC", VA = "0xF8CFAC")]
		public void OpenUISection(GameObject section)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF904C4", Offset = "0xF904C4", VA = "0xF904C4")]
		public void SetHardDifficulty()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF904E4", Offset = "0xF904E4", VA = "0xF904E4")]
		public MainMenuUI()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class MainMenuUIEffects : MonoBehaviour
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[LabelText("Exceptions")]
		private bool _hasExceptions;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ShowIf("_hasExceptions", true)]
		[SerializeField]
		private List<Image> _imageExceptions;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Image> _images;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<TextMeshProUGUI> _texts;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sequence _fadeSequence;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _color;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Image> _filteredImages;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF904EC", Offset = "0xF904EC", VA = "0xF904EC")]
		[Inject]
		private void Construct(List<Image> images, List<TextMeshProUGUI> texts)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF9051C", Offset = "0xF9051C", VA = "0xF9051C")]
		[Inject]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF905A0", Offset = "0xF905A0", VA = "0xF905A0")]
		private void Fade(float endValue, float duration, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF8FAD8", Offset = "0xF8FAD8", VA = "0xF8FAD8")]
		public void FadeOut(float duration, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF8FE1C", Offset = "0xF8FE1C", VA = "0xF8FE1C")]
		public void FadeIn(float duration, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF8FAE4", Offset = "0xF8FAE4", VA = "0xF8FAE4")]
		public void SetAlpha(float value)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF90968", Offset = "0xF90968", VA = "0xF90968")]
		public MainMenuUIEffects()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class MainMenuUIManager : IInitializable, IDisposable
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly InteractionSystem _interactionSystem;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ScreenFade _focusFade;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IFocusHandler _focusHandler;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly CompositeDisposable _disposables;

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF9098C", Offset = "0xF9098C", VA = "0xF9098C")]
		public MainMenuUIManager(InteractionSystem interactionSystem, ScreenFade focusFade, IFocusHandler focusHandler)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF90A4C", Offset = "0xF90A4C", VA = "0xF90A4C", Slot = "4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF90C60", Offset = "0xF90C60", VA = "0xF90C60", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class SettingsUI : MonoBehaviour
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[BoxGroup("Audio", true, false, 0)]
		private Slider _musicSlider;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[BoxGroup("Audio", true, false, 0)]
		private Slider _sfxSlider;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[BoxGroup("Audio", true, false, 0)]
		private Slider _speechSlider;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[BoxGroup("Comfort Mode", true, false, 0)]
		private Toggle _comfortModeToggle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[BoxGroup("Comfort Mode", true, false, 0)]
		private TextMeshProUGUI _comfortModeMessage;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MixerManager _mixerManager;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameSettings _gameSettings;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF90F2C", Offset = "0xF90F2C", VA = "0xF90F2C")]
		[Inject]
		private void Construct(MixerManager mixerManager, GameSettings gameSettings)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF90F5C", Offset = "0xF90F5C", VA = "0xF90F5C")]
		[Inject]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xF91120", Offset = "0xF91120", VA = "0xF91120")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF91308", Offset = "0xF91308", VA = "0xF91308")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xF914F0", Offset = "0xF914F0", VA = "0xF914F0")]
		private void SetComfortMode(bool value)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF9106C", Offset = "0xF9106C", VA = "0xF9106C")]
		private void SetComfortModeMessage(bool value)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF915A8", Offset = "0xF915A8", VA = "0xF915A8")]
		private void SetPassthrough(bool value)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xF91650", Offset = "0xF91650", VA = "0xF91650")]
		public void ResetToDefaults()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xF91684", Offset = "0xF91684", VA = "0xF91684")]
		public void OnSFXSliderPointer(BaseEventData data)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF91704", Offset = "0xF91704", VA = "0xF91704")]
		public void OnSpeechSliderPointer(BaseEventData data)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF91784", Offset = "0xF91784", VA = "0xF91784")]
		public void OnMusicSliderPointerUp(BaseEventData data)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF917B0", Offset = "0xF917B0", VA = "0xF917B0")]
		public void OnSFXSliderPointerUp(BaseEventData data)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xF917DC", Offset = "0xF917DC", VA = "0xF917DC")]
		public void OnSpeechSliderPointerUp(BaseEventData data)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF91808", Offset = "0xF91808", VA = "0xF91808")]
		public SettingsUI()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class UIController
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ScreenFade _screenFade;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly SceneLoader _sceneLoader;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly InteractionSystem _interactionSystem;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IMusicFader _musicFader;

		[Token(Token = "0x1700006A")]
		public string CurrentLevel
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xF91894", Offset = "0xF91894", VA = "0xF91894")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xF9189C", Offset = "0xF9189C", VA = "0xF9189C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xF918A4", Offset = "0xF918A4", VA = "0xF918A4")]
		public UIController(ScreenFade screenFade, SceneLoader sceneLoader, InteractionSystem interactionSystem, IMusicFader musicFader)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xF91918", Offset = "0xF91918", VA = "0xF91918")]
		private void PlayLevel(string name)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xF8E62C", Offset = "0xF8E62C", VA = "0xF8E62C")]
		public void PlayCampaignLevel()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xF8BDFC", Offset = "0xF8BDFC", VA = "0xF8BDFC")]
		public void PlayEndlessLevel(string name)
		{
		}
	}
}
namespace Cybrix.Gameplay.Props
{
	[Token(Token = "0x200014D")]
	public class LaserGun : Gun
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IMemoryPool<Vector3, Quaternion, LaserBullet> _bulletPool;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IObservable<Unit> _fireReleased;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xF91B70", Offset = "0xF91B70", VA = "0xF91B70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xF91BF8", Offset = "0xF91BF8", VA = "0xF91BF8")]
		private void HandleFirePressed()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xF91DC4", Offset = "0xF91DC4", VA = "0xF91DC4", Slot = "6")]
		protected override void Fire(string audioClip, float hapticsAmplitude, float hapticsDuration)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xF91F08", Offset = "0xF91F08", VA = "0xF91F08")]
		public LaserGun()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class Racket : Prop
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SignalBus _signalBus;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xF92260", Offset = "0xF92260", VA = "0xF92260")]
		[Inject]
		private void Construct(SignalBus signalBus)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xF92268", Offset = "0xF92268", VA = "0xF92268", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xF92400", Offset = "0xF92400", VA = "0xF92400")]
		private void PlayRepeatedHaptics()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF925BC", Offset = "0xF925BC", VA = "0xF925BC")]
		public Racket()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class Shotgun : Gun
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Tooltip("Number of bullets that the gun fires in a single shot.")]
		private int _bullets;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IMemoryPool<Vector3, Quaternion, LaserBullet> _bulletPool;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF9269C", Offset = "0xF9269C", VA = "0xF9269C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xF92724", Offset = "0xF92724", VA = "0xF92724")]
		private void HandleFirePressed()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xF92888", Offset = "0xF92888", VA = "0xF92888", Slot = "6")]
		protected override void Fire(string audioClip, float hapticsAmplitude, float hapticsDuration)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF92A5C", Offset = "0xF92A5C", VA = "0xF92A5C")]
		public Shotgun()
		{
		}
	}
}
namespace VRUiKits.Utils
{
	[Token(Token = "0x2000150")]
	public class TextMeshProConverter : MonoBehaviour
	{
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF92B50", Offset = "0xF92B50", VA = "0xF92B50")]
		public static int CheckTextsTotalNumber()
		{
			return default(int);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF92C4C", Offset = "0xF92C4C", VA = "0xF92C4C")]
		public TextMeshProConverter()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class ImageHoverOutline : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image targetImage;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color outlineColor;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float outlineWidth;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Outline outline;

		[Token(Token = "0x1700006B")]
		private Outline _Outline
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xF92C54", Offset = "0xF92C54", VA = "0xF92C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF92DF0", Offset = "0xF92DF0", VA = "0xF92DF0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF92E88", Offset = "0xF92E88", VA = "0xF92E88", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF92F20", Offset = "0xF92F20", VA = "0xF92F20")]
		public ImageHoverOutline()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class TextHoverScale : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text targetText;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int originSize;

		[Token(Token = "0x1700006C")]
		private Text TargetText
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xF92F3C", Offset = "0xF92F3C", VA = "0xF92F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF9301C", Offset = "0xF9301C", VA = "0xF9301C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF9318C", Offset = "0xF9318C", VA = "0xF9318C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF93224", Offset = "0xF93224", VA = "0xF93224")]
		public TextHoverScale()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class GazeInputModule : UIKitInputModule
	{
		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool previewWithoutHeadset;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool preventRepeatClick;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public RaycastResult currentRaycast;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GazeInputModule Instance;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PointerEventData pointerEventData;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject currentTarget;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float currentClickTime;

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF93238", Offset = "0xF93238", VA = "0xF93238")]
		protected GazeInputModule()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF932BC", Offset = "0xF932BC", VA = "0xF932BC", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xF932D4", Offset = "0xF932D4", VA = "0xF932D4")]
		private void GazeControl()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF934EC", Offset = "0xF934EC", VA = "0xF934EC")]
		private void HandleSelection()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xF93774", Offset = "0xF93774", VA = "0xF93774", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF93828", Offset = "0xF93828", VA = "0xF93828", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF93844", Offset = "0xF93844", VA = "0xF93844")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF93880", Offset = "0xF93880", VA = "0xF93880", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}
	}
	[Token(Token = "0x2000154")]
	[RequireComponent(typeof(VREventSystemHelper))]
	public class LaserInputModule : UIKitInputModule
	{
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public VRPlatform platform;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Pointer pointer;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public OVRInput.Button trigger;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private OVRInput.Controller activeController;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private OVRCameraRig oculusRig;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject currentTarget;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float currentClickTime;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LaserInputModule _instance;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera helperCamera;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIKitPointer controller;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool triggerPressed;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool triggerPressedLastFrame;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private PointerEventData pointerEventData;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 lastRaycastHitPoint;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float pressedDistance;

		[Token(Token = "0x1700006D")]
		public Transform TargetControllerTransform
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xF938C8", Offset = "0xF938C8", VA = "0xF938C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public static LaserInputModule instance
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xF9390C", Offset = "0xF9390C", VA = "0xF9390C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xF93954", Offset = "0xF93954", VA = "0xF93954", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xF93ABC", Offset = "0xF93ABC", VA = "0xF93ABC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xF93D84", Offset = "0xF93D84", VA = "0xF93D84")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xF93CAC", Offset = "0xF93CAC", VA = "0xF93CAC")]
		private void SetCanvasCamera()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xF93D80", Offset = "0xF93D80", VA = "0xF93D80")]
		private void SetupHmd()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF93FC4", Offset = "0xF93FC4", VA = "0xF93FC4")]
		public void SetController(UIKitPointer _controller)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xF93FCC", Offset = "0xF93FCC", VA = "0xF93FCC")]
		public void RemoveController(UIKitPointer _controller)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xF94084", Offset = "0xF94084", VA = "0xF94084", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xF94128", Offset = "0xF94128", VA = "0xF94128")]
		private void UpdateHelperCamera()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF944A4", Offset = "0xF944A4", VA = "0xF944A4")]
		private void CheckTriggerStatus()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF941C8", Offset = "0xF941C8", VA = "0xF941C8")]
		private void ProcessGazePointer()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF945A8", Offset = "0xF945A8", VA = "0xF945A8")]
		private void ProcessLaserPointer()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF94E34", Offset = "0xF94E34", VA = "0xF94E34")]
		private void ProcessPress(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF948B0", Offset = "0xF948B0", VA = "0xF948B0")]
		private PointerEventData GetPointerEventData()
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xF957E4", Offset = "0xF957E4", VA = "0xF957E4")]
		private bool TriggerReleasedThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF957C4", Offset = "0xF957C4", VA = "0xF957C4")]
		private bool TriggerPressedThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xF94768", Offset = "0xF94768", VA = "0xF94768")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xF95804", Offset = "0xF95804", VA = "0xF95804", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF958B8", Offset = "0xF958B8", VA = "0xF958B8", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF958D4", Offset = "0xF958D4", VA = "0xF958D4")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF95910", Offset = "0xF95910", VA = "0xF95910")]
		private bool ShouldStartDrag(float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF9592C", Offset = "0xF9592C", VA = "0xF9592C", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xF9552C", Offset = "0xF9552C", VA = "0xF9552C")]
		private void ProcessDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xF93D9C", Offset = "0xF93D9C", VA = "0xF93D9C")]
		private void SetupOculus()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF95974", Offset = "0xF95974", VA = "0xF95974")]
		public LaserInputModule()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public enum VRPlatform
	{
		[Token(Token = "0x40006EB")]
		NONE,
		[Token(Token = "0x40006EC")]
		OCULUS,
		[Token(Token = "0x40006ED")]
		VIVE,
		[Token(Token = "0x40006EE")]
		VIVE_STEAM2
	}
	[Token(Token = "0x2000156")]
	public enum Pointer
	{
		[Token(Token = "0x40006F0")]
		RightHand,
		[Token(Token = "0x40006F1")]
		LeftHand,
		[Token(Token = "0x40006F2")]
		Eye
	}
	[Token(Token = "0x2000157")]
	public class MouseInputModule : StandaloneInputModule
	{
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF95994", Offset = "0xF95994", VA = "0xF95994", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF959EC", Offset = "0xF959EC", VA = "0xF959EC")]
		protected new void ProcessMouseEvent()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF95CC4", Offset = "0xF95CC4", VA = "0xF95CC4")]
		private static bool UseMouse(bool pressed, bool released, PointerEventData pointerData)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xF95D08", Offset = "0xF95D08", VA = "0xF95D08")]
		protected new void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xF96370", Offset = "0xF96370", VA = "0xF96370")]
		public MouseInputModule()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class GazeProgressCircle : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private sealed class <FillCircle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GazeProgressCircle <>4__this;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <timer>5__2;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0xF96968", Offset = "0xF96968", VA = "0xF96968", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0xF969B0", Offset = "0xF969B0", VA = "0xF969B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xF967D0", Offset = "0xF967D0", VA = "0xF967D0")]
			[DebuggerHidden]
			public <FillCircle>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xF96800", Offset = "0xF96800", VA = "0xF96800", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xF96804", Offset = "0xF96804", VA = "0xF96804", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xF96970", Offset = "0xF96970", VA = "0xF96970", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image circle;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Coroutine fillCircle;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIKitInputModule m_inputModule;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xF96378", Offset = "0xF96378", VA = "0xF96378")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xF965D0", Offset = "0xF965D0", VA = "0xF965D0")]
		private void HandleProgressCircle(GameObject target)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xF9675C", Offset = "0xF9675C", VA = "0xF9675C")]
		[IteratorStateMachine(typeof(<FillCircle>d__5))]
		private IEnumerator FillCircle()
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xF96694", Offset = "0xF96694", VA = "0xF96694")]
		private void ResetGazer()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xF967F8", Offset = "0xF967F8", VA = "0xF967F8")]
		public GazeProgressCircle()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class LaserPointer : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LineRenderer lr;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xF969B8", Offset = "0xF969B8", VA = "0xF969B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xF96A10", Offset = "0xF96A10", VA = "0xF96A10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xF96BD0", Offset = "0xF96BD0", VA = "0xF96BD0")]
		public LaserPointer()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class UIKitPointer : MonoBehaviour
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gazePointer;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject laser;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Pointer? temp;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRInput.Controller activeController;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool allowAutoSwitchHand;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xF96BD8", Offset = "0xF96BD8", VA = "0xF96BD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xF96CC0", Offset = "0xF96CC0", VA = "0xF96CC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xF9702C", Offset = "0xF9702C", VA = "0xF9702C")]
		private void SetPointer(Pointer targetPointer)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xF97178", Offset = "0xF97178", VA = "0xF97178")]
		private void ResetTransform(Transform trans)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xF97258", Offset = "0xF97258", VA = "0xF97258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xF9733C", Offset = "0xF9733C", VA = "0xF9733C")]
		public UIKitPointer()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class UIKitInputModule : BaseInputModule
	{
		[Token(Token = "0x200015D")]
		public delegate void OnGazeChangedHandler(GameObject target);

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float gazeTimeInSeconds;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public float delayTimeInSeconds;

		[Token(Token = "0x14000010")]
		public event OnGazeChangedHandler OnGazeChanged
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xF96534", Offset = "0xF96534", VA = "0xF96534")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xF97344", Offset = "0xF97344", VA = "0xF97344")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF93758", Offset = "0xF93758", VA = "0xF93758")]
		protected void RaiseGazeChangeEvent(GameObject target)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xF973E0", Offset = "0xF973E0", VA = "0xF973E0", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xF932A8", Offset = "0xF932A8", VA = "0xF932A8")]
		public UIKitInputModule()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015E")]
	public class Card
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string subtitle;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string description;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite image;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF97424", Offset = "0xF97424", VA = "0xF97424")]
		public Card()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class CardItem : MonoBehaviour
	{
		[Token(Token = "0x2000160")]
		public delegate void OnCardClickedHandler(Card card);

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform title;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform subtitle;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform description;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image image;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Card card;

		[Token(Token = "0x17000071")]
		public Text Title
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xF97564", Offset = "0xF97564", VA = "0xF97564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public Text Subtitle
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xF97600", Offset = "0xF97600", VA = "0xF97600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public Text Description
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xF9769C", Offset = "0xF9769C", VA = "0xF9769C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public Card Card
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xF97738", Offset = "0xF97738", VA = "0xF97738")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xF97740", Offset = "0xF97740", VA = "0xF97740")]
			set
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event OnCardClickedHandler OnCardClicked
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xF9742C", Offset = "0xF9742C", VA = "0xF9742C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xF974C8", Offset = "0xF974C8", VA = "0xF974C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xF97904", Offset = "0xF97904", VA = "0xF97904")]
		public void Awake()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xF97A18", Offset = "0xF97A18", VA = "0xF97A18")]
		public CardItem()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class CardListManager : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform listContent;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject itemTemplate;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<Card> cardList;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<CardItem> cardItems;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Card selectedCard;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF97BC4", Offset = "0xF97BC4", VA = "0xF97BC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF97C7C", Offset = "0xF97C7C", VA = "0xF97C7C")]
		private void SetSelectedCard(Card card)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF97C84", Offset = "0xF97C84", VA = "0xF97C84")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF97BF0", Offset = "0xF97BF0", VA = "0xF97BF0")]
		public void PopulateList()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF97E18", Offset = "0xF97E18", VA = "0xF97E18")]
		public void AddCardItem(Card card)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xF97FB4", Offset = "0xF97FB4", VA = "0xF97FB4")]
		public CardListManager()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class InputFocusHelper : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class <ActivateInputFieldWithCaret>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InputFocusHelper <>4__this;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0xF98354", Offset = "0xF98354", VA = "0xF98354", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005ED")]
				[Address(RVA = "0xF9839C", Offset = "0xF9839C", VA = "0xF9839C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xF981CC", Offset = "0xF981CC", VA = "0xF981CC")]
			[DebuggerHidden]
			public <ActivateInputFieldWithCaret>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xF981FC", Offset = "0xF981FC", VA = "0xF981FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xF98200", Offset = "0xF98200", VA = "0xF98200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF9835C", Offset = "0xF9835C", VA = "0xF9835C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField input;

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF9808C", Offset = "0xF9808C", VA = "0xF9808C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xF980E4", Offset = "0xF980E4", VA = "0xF980E4", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF98158", Offset = "0xF98158", VA = "0xF98158")]
		[IteratorStateMachine(typeof(<ActivateInputFieldWithCaret>d__3))]
		private IEnumerator ActivateInputFieldWithCaret()
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF981F4", Offset = "0xF981F4", VA = "0xF981F4")]
		public InputFocusHelper()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class UIKitInputField : MonoBehaviour, ISelectHandler, IEventSystemHandler, IPointerClickHandler, IDeselectHandler
	{
		[Token(Token = "0x2000165")]
		public enum ContentType
		{
			[Token(Token = "0x4000723")]
			Standard,
			[Token(Token = "0x4000724")]
			Password
		}

		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class <BlinkCaret>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIKitInputField <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0xF98BC4", Offset = "0xF98BC4", VA = "0xF98BC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0xF98C0C", Offset = "0xF98C0C", VA = "0xF98C0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xF989FC", Offset = "0xF989FC", VA = "0xF989FC")]
			[DebuggerHidden]
			public <BlinkCaret>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xF98A88", Offset = "0xF98A88", VA = "0xF98A88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xF98A8C", Offset = "0xF98A8C", VA = "0xF98A8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xF98BCC", Offset = "0xF98BCC", VA = "0xF98BCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform wrapper;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text textComponent;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int characterLimit;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public ContentType contentType;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text placeholder;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform caretTransform;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 4f)]
		public float caretBlinkRate;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float maxW_textComponent;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string displayedText;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string prevText;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text caretText;

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xF983A4", Offset = "0xF983A4", VA = "0xF983A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xF98444", Offset = "0xF98444", VA = "0xF98444", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xF984F8", Offset = "0xF984F8", VA = "0xF984F8", Slot = "5")]
		public void OnPointerClick(PointerEventData pointerEventData)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xF98574", Offset = "0xF98574", VA = "0xF98574", Slot = "6")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xF985E4", Offset = "0xF985E4", VA = "0xF985E4")]
		public void ForceCaretUpdate()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xF98640", Offset = "0xF98640", VA = "0xF98640")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xF98790", Offset = "0xF98790", VA = "0xF98790")]
		private void CalculateLengthOfText(string text)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xF98988", Offset = "0xF98988", VA = "0xF98988")]
		[IteratorStateMachine(typeof(<BlinkCaret>d__20))]
		private IEnumerator BlinkCaret()
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xF98A24", Offset = "0xF98A24", VA = "0xF98A24")]
		public UIKitInputField()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class KeyboardExtentionMethods : MonoBehaviour
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject symbols;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject alphabets;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xF98C14", Offset = "0xF98C14", VA = "0xF98C14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xF98D18", Offset = "0xF98D18", VA = "0xF98D18")]
		public void SwitchSymbols()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xF98D34", Offset = "0xF98D34", VA = "0xF98D34")]
		public void ToggleObject(GameObject go)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xF98D68", Offset = "0xF98D68", VA = "0xF98D68")]
		public KeyboardExtentionMethods()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class KeyboardManager : MonoBehaviour
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the character is uppercase at the initialization")]
		[Header("User defined")]
		public bool isUppercase;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Essentials")]
		public Transform keys;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InputField target;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Key[] keyList;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool capslockFlag;

		[Token(Token = "0x17000079")]
		public static InputField Target
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xF98D70", Offset = "0xF98D70", VA = "0xF98D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xF98ED4", Offset = "0xF98ED4", VA = "0xF98ED4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		private string Input
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xF98F2C", Offset = "0xF98F2C", VA = "0xF98F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xF98FC4", Offset = "0xF98FC4", VA = "0xF98FC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xF99078", Offset = "0xF99078", VA = "0xF99078")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xF990DC", Offset = "0xF990DC", VA = "0xF990DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xF9940C", Offset = "0xF9940C", VA = "0xF9940C")]
		public void Backspace()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xF99464", Offset = "0xF99464", VA = "0xF99464")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xF99338", Offset = "0xF99338", VA = "0xF99338")]
		public void CapsLock()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xF994A4", Offset = "0xF994A4", VA = "0xF994A4")]
		public void Shift()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xF99568", Offset = "0xF99568", VA = "0xF99568")]
		public void GenerateInput(string s)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xF9958C", Offset = "0xF9958C", VA = "0xF9958C")]
		public KeyboardManager()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class Alphabet : Key
	{
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xF99594", Offset = "0xF99594", VA = "0xF99594", Slot = "5")]
		public override void CapsLock(bool isUppercase)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xF995F8", Offset = "0xF995F8", VA = "0xF995F8")]
		public Alphabet()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class Key : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		public delegate void OnKeyClickedHandler(string key);

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Text key;

		[Token(Token = "0x14000012")]
		public event OnKeyClickedHandler OnKeyClicked
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xF9929C", Offset = "0xF9929C", VA = "0xF9929C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0xF99608", Offset = "0xF99608", VA = "0xF99608")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xF996A4", Offset = "0xF996A4", VA = "0xF996A4", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xF997B4", Offset = "0xF997B4", VA = "0xF997B4", Slot = "5")]
		public virtual void CapsLock(bool isUppercase)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xF997B8", Offset = "0xF997B8", VA = "0xF997B8", Slot = "6")]
		public virtual void ShiftKey()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xF99600", Offset = "0xF99600", VA = "0xF99600")]
		public Key()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class Number : Key
	{
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xF99840", Offset = "0xF99840", VA = "0xF99840")]
		public Number()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class Shift : Key
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text subscript;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xF99848", Offset = "0xF99848", VA = "0xF99848", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF998DC", Offset = "0xF998DC", VA = "0xF998DC", Slot = "6")]
		public override void ShiftKey()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xF99968", Offset = "0xF99968", VA = "0xF99968")]
		public Shift()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class Symbol : Key
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xF99970", Offset = "0xF99970", VA = "0xF99970")]
		public Symbol()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class MobileKeyboardManager : MonoBehaviour
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("User defined")]
		[Tooltip("If the character is uppercase at the initialization")]
		public bool isUppercase;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Essentials")]
		public Transform keys;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UIKitInputField target;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Key[] keyList;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool capslockFlag;

		[Token(Token = "0x1700007B")]
		public static UIKitInputField Target
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xF99978", Offset = "0xF99978", VA = "0xF99978")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xF99ADC", Offset = "0xF99ADC", VA = "0xF99ADC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		private string Input
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xF99B34", Offset = "0xF99B34", VA = "0xF99B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xF99BCC", Offset = "0xF99BCC", VA = "0xF99BCC")]
			set
			{
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xF99CB0", Offset = "0xF99CB0", VA = "0xF99CB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xF99D14", Offset = "0xF99D14", VA = "0xF99D14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xF99EC4", Offset = "0xF99EC4", VA = "0xF99EC4")]
		public void Backspace()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xF99F1C", Offset = "0xF99F1C", VA = "0xF99F1C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xF99DF0", Offset = "0xF99DF0", VA = "0xF99DF0")]
		public void CapsLock()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xF99FBC", Offset = "0xF99FBC", VA = "0xF99FBC")]
		public void Shift()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xF9A080", Offset = "0xF9A080", VA = "0xF9A080")]
		public void GenerateInput(string s)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xF9A0A4", Offset = "0xF9A0A4", VA = "0xF9A0A4")]
		public MobileKeyboardManager()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class Item : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		public delegate void OnItemSelectedHandler(Item item);

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button button;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Color temp;

		[Token(Token = "0x14000013")]
		public event OnItemSelectedHandler OnItemSelected
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0xF9A0AC", Offset = "0xF9A0AC", VA = "0xF9A0AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xF9A148", Offset = "0xF9A148", VA = "0xF9A148")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xF9A1E4", Offset = "0xF9A1E4", VA = "0xF9A1E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xF9A390", Offset = "0xF9A390", VA = "0xF9A390", Slot = "4")]
		public virtual void Activate()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xF9A3FC", Offset = "0xF9A3FC", VA = "0xF9A3FC", Slot = "5")]
		public virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xF9A474", Offset = "0xF9A474", VA = "0xF9A474", Slot = "6")]
		public virtual void DeactivateSubMenu()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xF9A478", Offset = "0xF9A478", VA = "0xF9A478")]
		public Item()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class ListSelectionHelper : MonoBehaviour
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform list;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Item initialActivatedItem;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Item currentSelectedItem;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Item[] items;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xF9A61C", Offset = "0xF9A61C", VA = "0xF9A61C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xF9A67C", Offset = "0xF9A67C", VA = "0xF9A67C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xF9A7C4", Offset = "0xF9A7C4", VA = "0xF9A7C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xF9A95C", Offset = "0xF9A95C", VA = "0xF9A95C")]
		private void SelectionHelper(Item item)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xF9A8D0", Offset = "0xF9A8D0", VA = "0xF9A8D0")]
		public void DeselectCurrentItem()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xF9A9A0", Offset = "0xF9A9A0", VA = "0xF9A9A0")]
		public ListSelectionHelper()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class MenuItem : Item
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject subMenu;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF9A9A8", Offset = "0xF9A9A8", VA = "0xF9A9A8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF9AA38", Offset = "0xF9AA38", VA = "0xF9AA38", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xF9AA58", Offset = "0xF9AA58", VA = "0xF9AA58", Slot = "6")]
		public override void DeactivateSubMenu()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xF9AAE0", Offset = "0xF9AAE0", VA = "0xF9AAE0")]
		public MenuItem()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class TabItem : Item
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject relatedPanel;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xF9AAE8", Offset = "0xF9AAE8", VA = "0xF9AAE8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xF9AB78", Offset = "0xF9AB78", VA = "0xF9AB78", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xF9AC08", Offset = "0xF9AC08", VA = "0xF9AC08")]
		public TabItem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public struct Option
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string value;
	}
	[Token(Token = "0x2000176")]
	public class OptionItem : MonoBehaviour
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Option option;

		[Token(Token = "0x1700007D")]
		public string Value
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xF9AC10", Offset = "0xF9AC10", VA = "0xF9AC10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public Option Option
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xF9AC18", Offset = "0xF9AC18", VA = "0xF9AC18")]
			get
			{
				return default(Option);
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xF9AC20", Offset = "0xF9AC20", VA = "0xF9AC20")]
			set
			{
			}
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xF9ACFC", Offset = "0xF9ACFC", VA = "0xF9ACFC")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF9AD20", Offset = "0xF9AD20", VA = "0xF9AD20")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF9AD44", Offset = "0xF9AD44", VA = "0xF9AD44")]
		public OptionItem()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class OptionsManager : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		public delegate void OnOptionSelectedHandler(int index);

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Template")]
		public GameObject optionTemplate;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<Option> optionsList;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public string selectedValue;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int selectedIdx;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<OptionItem> optionItems;

		[Token(Token = "0x14000014")]
		public event OnOptionSelectedHandler OnOptionSelected
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xF9AD4C", Offset = "0xF9AD4C", VA = "0xF9AD4C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xF9ADE8", Offset = "0xF9ADE8", VA = "0xF9ADE8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF9AE84", Offset = "0xF9AE84", VA = "0xF9AE84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xF9B078", Offset = "0xF9B078", VA = "0xF9B078")]
		private void Start()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF9AEB0", Offset = "0xF9AEB0", VA = "0xF9AEB0")]
		private void PopulateOptions()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF9B284", Offset = "0xF9B284", VA = "0xF9B284")]
		public void PrevOption()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xF9B354", Offset = "0xF9B354", VA = "0xF9B354")]
		public void NextOption()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xF9B100", Offset = "0xF9B100", VA = "0xF9B100")]
		private void ActivateOption(int i)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xF9B2CC", Offset = "0xF9B2CC", VA = "0xF9B2CC")]
		private void DeactivateOption(int i)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF9B3E0", Offset = "0xF9B3E0", VA = "0xF9B3E0")]
		public OptionsManager()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public enum ButtonDeactiveStyle
	{
		[Token(Token = "0x4000749")]
		Disabled,
		[Token(Token = "0x400074A")]
		Hidden
	}
	[Token(Token = "0x200017A")]
	public class Pagination : MonoBehaviour
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Target")]
		public Transform targetObject;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Pagination Buttons")]
		public ButtonDeactiveStyle buttonDeactiveStyle;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button nextBtn;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button prevBtn;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int currentPage;

		[Token(Token = "0x1700007F")]
		public int CurrentPage
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xF9B55C", Offset = "0xF9B55C", VA = "0xF9B55C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xF9B564", Offset = "0xF9B564", VA = "0xF9B564")]
			set
			{
			}
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF9B880", Offset = "0xF9B880", VA = "0xF9B880")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xF9B9F0", Offset = "0xF9B9F0", VA = "0xF9B9F0")]
		public void Next()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xF9B9FC", Offset = "0xF9B9FC", VA = "0xF9B9FC")]
		public void Prev()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xF9B738", Offset = "0xF9B738", VA = "0xF9B738")]
		private void PagintionBtnControl(bool nextEnabled, bool prevEnabled)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xF9BA08", Offset = "0xF9BA08", VA = "0xF9BA08")]
		public Pagination()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[RequireComponent(typeof(ProgressBarManager))]
	public class CircularProgressBar : MonoBehaviour
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image circle;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float step;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Value")]
		public Transform valueText;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float min;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float max;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProgressBarManager progressBarManager;

		[Token(Token = "0x17000080")]
		public Text ValueText
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0xF9BA10", Offset = "0xF9BA10", VA = "0xF9BA10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public float Value
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0xF9BA60", Offset = "0xF9BA60", VA = "0xF9BA60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0xF9BA7C", Offset = "0xF9BA7C", VA = "0xF9BA7C")]
			set
			{
			}
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xF9BA98", Offset = "0xF9BA98", VA = "0xF9BA98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF9BAF0", Offset = "0xF9BAF0", VA = "0xF9BAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xF9BEE4", Offset = "0xF9BEE4", VA = "0xF9BEE4")]
		public void IncreaseValue()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xF9BFA8", Offset = "0xF9BFA8", VA = "0xF9BFA8")]
		public void DecreaseValue()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xF9C06C", Offset = "0xF9C06C", VA = "0xF9C06C")]
		private void UpdateValue(float newValue)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xF9BBD4", Offset = "0xF9BBD4", VA = "0xF9BBD4")]
		private void UpdateValueText(float newValue)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xF9C088", Offset = "0xF9C088", VA = "0xF9C088")]
		public CircularProgressBar()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class ProgressBarManager : MonoBehaviour
	{
		[Token(Token = "0x200017D")]
		public delegate void OnValueUpdatedHandler(float updatedValue);

		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private sealed class <SlideTo>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float target;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float toValue;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressBarManager <>4__this;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <fromValue>5__2;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__3;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0xF9C450", Offset = "0xF9C450", VA = "0xF9C450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0xF9C498", Offset = "0xF9C498", VA = "0xF9C498", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xF9C274", Offset = "0xF9C274", VA = "0xF9C274")]
			[DebuggerHidden]
			public <SlideTo>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xF9C348", Offset = "0xF9C348", VA = "0xF9C348", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xF9C34C", Offset = "0xF9C34C", VA = "0xF9C34C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xF9C458", Offset = "0xF9C458", VA = "0xF9C458", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Coroutine slideCoroutine;

		[Token(Token = "0x14000015")]
		public event OnValueUpdatedHandler OnValueIsUpdating
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xF9BDAC", Offset = "0xF9BDAC", VA = "0xF9BDAC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xF9C0A4", Offset = "0xF9C0A4", VA = "0xF9C0A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event OnValueUpdatedHandler OnValueStopUpgating
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xF9BE48", Offset = "0xF9BE48", VA = "0xF9BE48")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xF9C140", Offset = "0xF9C140", VA = "0xF9C140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xF9BF14", Offset = "0xF9BF14", VA = "0xF9BF14")]
		public void IncreaseValue(float target, float step, float min, float max)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xF9BFD8", Offset = "0xF9BFD8", VA = "0xF9BFD8")]
		public void DecreaseValue(float target, float step, float min, float max)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xF9C1DC", Offset = "0xF9C1DC", VA = "0xF9C1DC")]
		[IteratorStateMachine(typeof(<SlideTo>d__10))]
		private IEnumerator SlideTo(float target, float toValue, float time = 0.2f)
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xF9C29C", Offset = "0xF9C29C", VA = "0xF9C29C")]
		public ProgressBarManager()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[RequireComponent(typeof(ProgressBarManager))]
	public class ScrollController : MonoBehaviour
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Scrollbar scrollbar;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float step;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float min;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float max;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ProgressBarManager progressBarManager;

		[Token(Token = "0x17000084")]
		public float Value
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xF9C4A0", Offset = "0xF9C4A0", VA = "0xF9C4A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0xF9C4BC", Offset = "0xF9C4BC", VA = "0xF9C4BC")]
			set
			{
			}
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xF9C4D8", Offset = "0xF9C4D8", VA = "0xF9C4D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xF9C530", Offset = "0xF9C530", VA = "0xF9C530")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xF9C5B4", Offset = "0xF9C5B4", VA = "0xF9C5B4")]
		public void IncreaseValue()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xF9C5F4", Offset = "0xF9C5F4", VA = "0xF9C5F4")]
		public void DecreaseValue()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xF9C634", Offset = "0xF9C634", VA = "0xF9C634")]
		private void UpdateValue(float newValue)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xF9C650", Offset = "0xF9C650", VA = "0xF9C650")]
		public ScrollController()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[RequireComponent(typeof(ProgressBarManager))]
	public class SliderProgressBar : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		public enum ValueType
		{
			[Token(Token = "0x400076E")]
			Percentage,
			[Token(Token = "0x400076F")]
			Number
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider slider;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float step;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Value")]
		public ValueType valuePresentedAs;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform valueText;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float roundedPercentage;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float roundedValue;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProgressBarManager progressBarManager;

		[Token(Token = "0x17000085")]
		public Text ValueText
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xF9C668", Offset = "0xF9C668", VA = "0xF9C668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public float Value
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xF9C6B8", Offset = "0xF9C6B8", VA = "0xF9C6B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xF9C6DC", Offset = "0xF9C6DC", VA = "0xF9C6DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xF9C700", Offset = "0xF9C700", VA = "0xF9C700")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xF9C758", Offset = "0xF9C758", VA = "0xF9C758")]
		private void Start()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xF9CB34", Offset = "0xF9CB34", VA = "0xF9CB34")]
		public void IncreaseValue()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xF9CB88", Offset = "0xF9CB88", VA = "0xF9CB88")]
		public void DecreaseValue()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xF9CBDC", Offset = "0xF9CBDC", VA = "0xF9CBDC")]
		private void UpdateValue(float newValue)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xF9C8AC", Offset = "0xF9C8AC", VA = "0xF9C8AC")]
		private void CalculateValue(float newValue)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xF9CA34", Offset = "0xF9CA34", VA = "0xF9CA34")]
		private void UpdateValueText(float newValue)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xF9CC00", Offset = "0xF9CC00", VA = "0xF9CC00")]
		public SliderProgressBar()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class Util : MonoBehaviour
	{
		[Token(Token = "0x600068E")]
		public static T SafeDestroy<T>(T obj) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		public static T SafeDestroyGameObject<T>(T component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xF9CC14", Offset = "0xF9CC14", VA = "0xF9CC14")]
		public static void DestroyChildren(Transform root)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xF9CC98", Offset = "0xF9CC98", VA = "0xF9CC98")]
		public Util()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class VREventSystemHelper : EventSystem
	{
		[Token(Token = "0x6000692")]
		[Address(RVA = "0xF9CCA0", Offset = "0xF9CCA0", VA = "0xF9CCA0", Slot = "17")]
		protected override void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xF9CCAC", Offset = "0xF9CCAC", VA = "0xF9CCAC")]
		public VREventSystemHelper()
		{
		}
	}
}
namespace VRUiKits.Demo
{
	[Token(Token = "0x2000184")]
	public class ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material material;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color color;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isClicked;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xF9CD04", Offset = "0xF9CD04", VA = "0xF9CD04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xF9CD6C", Offset = "0xF9CD6C", VA = "0xF9CD6C")]
		public void PointerEnter()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xF9CDBC", Offset = "0xF9CDBC", VA = "0xF9CDBC")]
		public void PointerLeave()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xF9CDF4", Offset = "0xF9CDF4", VA = "0xF9CDF4")]
		public void PointerClick()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xF9CE30", Offset = "0xF9CE30", VA = "0xF9CE30")]
		public ChangeColor()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class MouseLook : MonoBehaviour
	{
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float x;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float y;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xF9CE38", Offset = "0xF9CE38", VA = "0xF9CE38")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xF9CFC0", Offset = "0xF9CFC0", VA = "0xF9CFC0")]
		public MouseLook()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000186")]
	[RequireComponent(typeof(CharacterController))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RunstepLenghten;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Camera m_Camera;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_Jump;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_YRotation;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 m_Input;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float m_StepCycle;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_NextStep;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_Jumping;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xF9CFD0", Offset = "0xF9CFD0", VA = "0xF9CFD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xF9D20C", Offset = "0xF9D20C", VA = "0xF9D20C")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xF9D3B8", Offset = "0xF9D3B8", VA = "0xF9D3B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xF9D9A4", Offset = "0xF9D9A4", VA = "0xF9D9A4")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xF9DAD8", Offset = "0xF9DAD8", VA = "0xF9DAD8")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xF9D7B0", Offset = "0xF9D7B0", VA = "0xF9D7B0")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xF9D2F4", Offset = "0xF9D2F4", VA = "0xF9D2F4")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xF9E25C", Offset = "0xF9E25C", VA = "0xF9E25C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xF9E380", Offset = "0xF9E380", VA = "0xF9E380")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xF9E72C", Offset = "0xF9E72C", VA = "0xF9E72C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xF9E778", Offset = "0xF9E778", VA = "0xF9E778")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xF9E9F0", Offset = "0xF9E9F0", VA = "0xF9E9F0")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000188")]
	public class MouseLook
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xF9D1BC", Offset = "0xF9D1BC", VA = "0xF9D1BC")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xF9DF00", Offset = "0xF9DF00", VA = "0xF9DF00")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xF9EB00", Offset = "0xF9EB00", VA = "0xF9EB00")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xF9DD18", Offset = "0xF9DD18", VA = "0xF9DD18")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xF9EB34", Offset = "0xF9EB34", VA = "0xF9EB34")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xF9EA9C", Offset = "0xF9EA9C", VA = "0xF9EA9C")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xF9EBAC", Offset = "0xF9EBAC", VA = "0xF9EBAC")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000189")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018A")]
		public class MovementSettings
		{
			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xF9FA10", Offset = "0xF9FA10", VA = "0xF9FA10")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xF9FBF0", Offset = "0xF9FBF0", VA = "0xF9FBF0")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018B")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xF9FDAC", Offset = "0xF9FDAC", VA = "0xF9FDAC")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000087")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xF9E9CC", Offset = "0xF9E9CC", VA = "0xF9E9CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000088")]
		public bool Grounded
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xF9EBE0", Offset = "0xF9EBE0", VA = "0xF9EBE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public bool Jumping
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xF9EBE8", Offset = "0xF9EBE8", VA = "0xF9EBE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool Running
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xF9E9E8", Offset = "0xF9E9E8", VA = "0xF9E9E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xF9EBF0", Offset = "0xF9EBF0", VA = "0xF9EBF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xF9ECC0", Offset = "0xF9ECC0", VA = "0xF9ECC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xF9EEA4", Offset = "0xF9EEA4", VA = "0xF9EEA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xF9F564", Offset = "0xF9F564", VA = "0xF9F564")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xF9F6C4", Offset = "0xF9F6C4", VA = "0xF9F6C4")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xF9F4C0", Offset = "0xF9F4C0", VA = "0xF9F4C0")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xF9ED28", Offset = "0xF9ED28", VA = "0xF9ED28")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xF9F2F4", Offset = "0xF9F2F4", VA = "0xF9F2F4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xF9FAC8", Offset = "0xF9FAC8", VA = "0xF9FAC8")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x200018C")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xF9D11C", Offset = "0xF9D11C", VA = "0xF9D11C")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xF9DD28", Offset = "0xF9DD28", VA = "0xF9DD28")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xF9E4D8", Offset = "0xF9E4D8", VA = "0xF9E4D8")]
		public CurveControlledBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200018D")]
	public class FOVKick
	{
		[Token(Token = "0x200018E")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0xFA0040", Offset = "0xFA0040", VA = "0xFA0040", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0xFA0088", Offset = "0xFA0088", VA = "0xFA0088", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xF9FEB8", Offset = "0xF9FEB8", VA = "0xF9FEB8")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xF9FF08", Offset = "0xF9FF08", VA = "0xF9FF08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xF9FF0C", Offset = "0xF9FF0C", VA = "0xF9FF0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xFA0048", Offset = "0xFA0048", VA = "0xFA0048", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018F")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0xFA01DC", Offset = "0xFA01DC", VA = "0xFA01DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0xFA0224", Offset = "0xFA0224", VA = "0xFA0224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xF9FEE0", Offset = "0xF9FEE0", VA = "0xF9FEE0")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0xFA0090", Offset = "0xFA0090", VA = "0xFA0090", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xFA0094", Offset = "0xFA0094", VA = "0xFA0094", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xFA01E4", Offset = "0xFA01E4", VA = "0xFA01E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xF9D0D4", Offset = "0xF9D0D4", VA = "0xF9D0D4")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xF9FDC8", Offset = "0xF9FDC8", VA = "0xF9FDC8")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xF9FEB0", Offset = "0xF9FEB0", VA = "0xF9FEB0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xF9DE8C", Offset = "0xF9DE8C", VA = "0xF9DE8C")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xF9DE18", Offset = "0xF9DE18", VA = "0xF9DE18")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xF9E4BC", Offset = "0xF9E4BC", VA = "0xF9E4BC")]
		public FOVKick()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000190")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0xFA0414", Offset = "0xFA0414", VA = "0xFA0414", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0xFA045C", Offset = "0xFA045C", VA = "0xFA045C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xFA0234", Offset = "0xFA0234", VA = "0xFA0234")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xFA025C", Offset = "0xFA025C", VA = "0xFA025C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xFA0260", Offset = "0xFA0260", VA = "0xFA0260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xFA041C", Offset = "0xFA041C", VA = "0xFA041C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFA022C", Offset = "0xFA022C", VA = "0xFA022C")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xF9D344", Offset = "0xF9D344", VA = "0xF9D344")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xF9E724", Offset = "0xF9E724", VA = "0xF9E724")]
		public LerpControlledBob()
		{
		}
	}
}
namespace sergeyiwanski
{
	[Token(Token = "0x2000192")]
	public class ExitOnKey : MonoBehaviour
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode key;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFA0464", Offset = "0xFA0464", VA = "0xFA0464")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFA048C", Offset = "0xFA048C", VA = "0xFA048C")]
		public ExitOnKey()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class ReplaceByClick : MonoBehaviour
	{
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject replaceable;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFA049C", Offset = "0xFA049C", VA = "0xFA049C")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xFA05EC", Offset = "0xFA05EC", VA = "0xFA05EC")]
		public ReplaceByClick()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class RotateArround : MonoBehaviour
	{
		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational speed.")]
		public Vector3 rotation;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xFA05F4", Offset = "0xFA05F4", VA = "0xFA05F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xFA0624", Offset = "0xFA0624", VA = "0xFA0624")]
		public RotateArround()
		{
		}
	}
}
namespace sergeyiwanski.effectspack
{
	[Token(Token = "0x2000195")]
	public class ActivateEffect : MonoBehaviour
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button btnBack;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button btnNext;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text label;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool mouse_control;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int startIndex;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject[] particles;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject particle;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int particle_index;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xFA062C", Offset = "0xFA062C", VA = "0xFA062C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xFA07E4", Offset = "0xFA07E4", VA = "0xFA07E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xFA0890", Offset = "0xFA0890", VA = "0xFA0890")]
		private void RespawnParticle()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xFA0A94", Offset = "0xFA0A94", VA = "0xFA0A94")]
		private void MoveParticle()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xFA0B48", Offset = "0xFA0B48", VA = "0xFA0B48")]
		public ActivateEffect()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class CamRotateZoom : MonoBehaviour
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject targetObj;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float mouseSence;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float rotationX;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float rotationY;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float cameraPositionZ;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float minY;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float maxY;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float minZ;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float maxZ;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion newRotation;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 newPosition;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFA0E00", Offset = "0xFA0E00", VA = "0xFA0E00")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFA0EF8", Offset = "0xFA0EF8", VA = "0xFA0EF8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFA0FF4", Offset = "0xFA0FF4", VA = "0xFA0FF4")]
		private void Zoom()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFA1078", Offset = "0xFA1078", VA = "0xFA1078")]
		public CamRotateZoom()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class Shoot : MonoBehaviour
	{
		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool destroyUp;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFA109C", Offset = "0xFA109C", VA = "0xFA109C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFA120C", Offset = "0xFA120C", VA = "0xFA120C")]
		public Shoot()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class AutoRotate : MonoBehaviour
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 speed;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFA1214", Offset = "0xFA1214", VA = "0xFA1214")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFA1240", Offset = "0xFA1240", VA = "0xFA1240")]
		public AutoRotate()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class SkillColor : MonoBehaviour
	{
		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color color;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(-1f, 1f)]
		public float bright;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture texture;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color emissionColor;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem[] particles;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xFA1248", Offset = "0xFA1248", VA = "0xFA1248")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xFA1764", Offset = "0xFA1764", VA = "0xFA1764")]
		public SkillColor()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200019A")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200019B")]
		private class CameraState
		{
			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xFA17E0", Offset = "0xFA17E0", VA = "0xFA17E0")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xFA1D20", Offset = "0xFA1D20", VA = "0xFA1D20")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xFA1DA0", Offset = "0xFA1DA0", VA = "0xFA1DA0")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xFA1E28", Offset = "0xFA1E28", VA = "0xFA1E28")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xFA204C", Offset = "0xFA204C", VA = "0xFA204C")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		[Header("Movement Settings")]
		public float boost;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xFA178C", Offset = "0xFA178C", VA = "0xFA178C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xFA1864", Offset = "0xFA1864", VA = "0xFA1864")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xFA1A94", Offset = "0xFA1A94", VA = "0xFA1A94")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xFA1E70", Offset = "0xFA1E70", VA = "0xFA1E70")]
		public SimpleCameraController()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200019C")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000091")]
		public bool Highlight
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xFA2054", Offset = "0xFA2054", VA = "0xFA2054")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xFA205C", Offset = "0xFA205C", VA = "0xFA205C")]
			set
			{
			}
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xFA2068", Offset = "0xFA2068", VA = "0xFA2068")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xFA2208", Offset = "0xFA2208", VA = "0xFA2208", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xFA2224", Offset = "0xFA2224", VA = "0xFA2224", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xFA2240", Offset = "0xFA2240", VA = "0xFA2240")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xFA2114", Offset = "0xFA2114", VA = "0xFA2114")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xFA24F4", Offset = "0xFA24F4", VA = "0xFA24F4")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000092")]
		public bool InRange
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xFA256C", Offset = "0xFA256C", VA = "0xFA256C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xFA2574", Offset = "0xFA2574", VA = "0xFA2574")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool Targeted
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0xFA26E0", Offset = "0xFA26E0", VA = "0xFA26E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xFA26E8", Offset = "0xFA26E8", VA = "0xFA26E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xFA26F4", Offset = "0xFA26F4", VA = "0xFA26F4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xFA2580", Offset = "0xFA2580", VA = "0xFA2580")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xFA28E4", Offset = "0xFA28E4", VA = "0xFA28E4")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200019E")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x17000094")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xFA28EC", Offset = "0xFA28EC", VA = "0xFA28EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xFA28F4", Offset = "0xFA28F4", VA = "0xFA28F4")]
			set
			{
			}
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xFA2910", Offset = "0xFA2910", VA = "0xFA2910", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xFA2B1C", Offset = "0xFA2B1C", VA = "0xFA2B1C", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xFA3408", Offset = "0xFA3408", VA = "0xFA3408", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xFA3970", Offset = "0xFA3970", VA = "0xFA3970", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xFA3D80", Offset = "0xFA3D80", VA = "0xFA3D80")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xFA2D44", Offset = "0xFA2D44", VA = "0xFA2D44")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xFA3E6C", Offset = "0xFA3E6C", VA = "0xFA3E6C")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFA426C", Offset = "0xFA426C", VA = "0xFA426C", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xFA4284", Offset = "0xFA4284", VA = "0xFA4284", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xFA428C", Offset = "0xFA428C", VA = "0xFA428C")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20001A0")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000822")]
			Disabled,
			[Token(Token = "0x4000823")]
			Enabled,
			[Token(Token = "0x4000824")]
			Targeted
		}

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xFA42AC", Offset = "0xFA42AC", VA = "0xFA42AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xFA2858", Offset = "0xFA2858", VA = "0xFA2858")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xFA4314", Offset = "0xFA4314", VA = "0xFA4314")]
		private void Update()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xFA434C", Offset = "0xFA434C", VA = "0xFA434C")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xFA4354", Offset = "0xFA4354", VA = "0xFA4354")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xFA4400", Offset = "0xFA4400", VA = "0xFA4400")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xFA44A8", Offset = "0xFA44A8", VA = "0xFA44A8")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600071F")]
		[Address(RVA = "0xFA44B0", Offset = "0xFA44B0", VA = "0xFA44B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xFA459C", Offset = "0xFA459C", VA = "0xFA459C")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xFA45A8", Offset = "0xFA45A8", VA = "0xFA45A8")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xFA45B4", Offset = "0xFA45B4", VA = "0xFA45B4")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xFA45BC", Offset = "0xFA45BC", VA = "0xFA45BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xFA460C", Offset = "0xFA460C", VA = "0xFA460C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xFA49E4", Offset = "0xFA49E4", VA = "0xFA49E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xFA4AD0", Offset = "0xFA4AD0", VA = "0xFA4AD0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xFA4610", Offset = "0xFA4610", VA = "0xFA4610")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xFA4BBC", Offset = "0xFA4BBC", VA = "0xFA4BBC")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20001A5")]
		public enum ContactTest
		{
			[Token(Token = "0x400083B")]
			PerpenTest,
			[Token(Token = "0x400083C")]
			BackwardsPress
		}

		[Token(Token = "0x400082C")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x400082D")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x17000095")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0xFA4C94", Offset = "0xFA4C94", VA = "0xFA4C94", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xFA4C9C", Offset = "0xFA4C9C", VA = "0xFA4C9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000097")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0xFA4CA8", Offset = "0xFA4CA8", VA = "0xFA4CA8")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0xFA4CB0", Offset = "0xFA4CB0", VA = "0xFA4CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xFA4CB8", Offset = "0xFA4CB8", VA = "0xFA4CB8", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xFA4DB8", Offset = "0xFA4DB8", VA = "0xFA4DB8")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xFA4FC0", Offset = "0xFA4FC0", VA = "0xFA4FC0", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xFA5588", Offset = "0xFA5588", VA = "0xFA5588")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xFA5638", Offset = "0xFA5638", VA = "0xFA5638")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xFA54AC", Offset = "0xFA54AC", VA = "0xFA54AC")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xFA5748", Offset = "0xFA5748", VA = "0xFA5748")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xFA5854", Offset = "0xFA5854", VA = "0xFA5854")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xFA58D4", Offset = "0xFA58D4", VA = "0xFA58D4")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x17000098")]
		public Collider Collider
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xFA59F0", Offset = "0xFA59F0", VA = "0xFA59F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xFA59F8", Offset = "0xFA59F8", VA = "0xFA59F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xFA5A00", Offset = "0xFA5A00", VA = "0xFA5A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000739")]
			[Address(RVA = "0xFA5A08", Offset = "0xFA5A08", VA = "0xFA5A08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0xFA5A10", Offset = "0xFA5A10", VA = "0xFA5A10", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xFA5A60", Offset = "0xFA5A60", VA = "0xFA5A60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xFA5AF4", Offset = "0xFA5AF4", VA = "0xFA5AF4")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public interface ColliderZone
	{
		[Token(Token = "0x1700009B")]
		Collider Collider
		{
			[Token(Token = "0x600073D")]
			get;
		}

		[Token(Token = "0x1700009C")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x600073E")]
			get;
		}

		[Token(Token = "0x1700009D")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600073F")]
			get;
		}
	}
	[Token(Token = "0x20001A8")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xFA4F14", Offset = "0xFA4F14", VA = "0xFA4F14")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public enum InteractionType
	{
		[Token(Token = "0x4000845")]
		Enter,
		[Token(Token = "0x4000846")]
		Stay,
		[Token(Token = "0x4000847")]
		Exit
	}
	[Token(Token = "0x20001AA")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000859")]
			Mesh,
			[Token(Token = "0x400085A")]
			Skeleton,
			[Token(Token = "0x400085B")]
			Both
		}

		[Token(Token = "0x20001AC")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0xFA6F60", Offset = "0xFA6F60", VA = "0xFA6F60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000764")]
				[Address(RVA = "0xFA6FA8", Offset = "0xFA6FA8", VA = "0xFA6FA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xFA6D0C", Offset = "0xFA6D0C", VA = "0xFA6D0C")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xFA6D34", Offset = "0xFA6D34", VA = "0xFA6D34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xFA6D38", Offset = "0xFA6D38", VA = "0xFA6D38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xFA6F68", Offset = "0xFA6F68", VA = "0xFA6F68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000848")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x1700009E")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0xFA5AFC", Offset = "0xFA5AFC", VA = "0xFA5AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xFA5B28", Offset = "0xFA5B28", VA = "0xFA5B28")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xFA5B8C", Offset = "0xFA5B8C", VA = "0xFA5B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xFA5BB8", Offset = "0xFA5BB8", VA = "0xFA5BB8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0xFA5C1C", Offset = "0xFA5C1C", VA = "0xFA5C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xFA5C48", Offset = "0xFA5C48", VA = "0xFA5C48")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0xFA5CAC", Offset = "0xFA5CAC", VA = "0xFA5CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xFA5CD8", Offset = "0xFA5CD8", VA = "0xFA5CD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xFA5D3C", Offset = "0xFA5D3C", VA = "0xFA5D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0xFA5D68", Offset = "0xFA5D68", VA = "0xFA5D68")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0xFA5DCC", Offset = "0xFA5DCC", VA = "0xFA5DCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xFA5DF4", Offset = "0xFA5DF4", VA = "0xFA5DF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xFA5E54", Offset = "0xFA5E54", VA = "0xFA5E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xFA5E7C", Offset = "0xFA5E7C", VA = "0xFA5E7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xFA5EDC", Offset = "0xFA5EDC", VA = "0xFA5EDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xFA5F04", Offset = "0xFA5F04", VA = "0xFA5F04")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xFA5F64", Offset = "0xFA5F64", VA = "0xFA5F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xFA5F8C", Offset = "0xFA5F8C", VA = "0xFA5F8C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0xFA5FEC", Offset = "0xFA5FEC", VA = "0xFA5FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xFA6014", Offset = "0xFA6014", VA = "0xFA6014")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0xFA6074", Offset = "0xFA6074", VA = "0xFA6074")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0xFA60BC", Offset = "0xFA60BC", VA = "0xFA60BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xFA6114", Offset = "0xFA6114", VA = "0xFA6114")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xFA64D0", Offset = "0xFA64D0", VA = "0xFA64D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xFA645C", Offset = "0xFA645C", VA = "0xFA645C")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xFA654C", Offset = "0xFA654C", VA = "0xFA654C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xFA6610", Offset = "0xFA6610", VA = "0xFA6610")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xFA67E0", Offset = "0xFA67E0", VA = "0xFA67E0")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xFA6A44", Offset = "0xFA6A44", VA = "0xFA6A44")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xFA6BA4", Offset = "0xFA6BA4", VA = "0xFA6BA4")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AE")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xFA7654", Offset = "0xFA7654", VA = "0xFA7654")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000AB")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xFA6FB0", Offset = "0xFA6FB0", VA = "0xFA6FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xFA6FB8", Offset = "0xFA6FB8", VA = "0xFA6FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xFA6FC0", Offset = "0xFA6FC0", VA = "0xFA6FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0xFA6FC8", Offset = "0xFA6FC8", VA = "0xFA6FC8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0xFA6FD0", Offset = "0xFA6FD0", VA = "0xFA6FD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xFA7080", Offset = "0xFA7080", VA = "0xFA7080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xFA714C", Offset = "0xFA714C", VA = "0xFA714C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xFA71FC", Offset = "0xFA71FC", VA = "0xFA71FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xFA72C8", Offset = "0xFA72C8", VA = "0xFA72C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0xFA7378", Offset = "0xFA7378", VA = "0xFA7378")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xFA7130", Offset = "0xFA7130", VA = "0xFA7130", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xFA72AC", Offset = "0xFA72AC", VA = "0xFA72AC", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xFA7428", Offset = "0xFA7428", VA = "0xFA7428", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000772")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xFA7444", Offset = "0xFA7444", VA = "0xFA7444", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xFA7548", Offset = "0xFA7548", VA = "0xFA7548", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xFA764C", Offset = "0xFA764C", VA = "0xFA764C")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000867")]
		None,
		[Token(Token = "0x4000868")]
		Proximity,
		[Token(Token = "0x4000869")]
		Contact,
		[Token(Token = "0x400086A")]
		Action
	}
	[Token(Token = "0x20001B0")]
	public enum InteractableState
	{
		[Token(Token = "0x400086C")]
		Default,
		[Token(Token = "0x400086D")]
		ProximityState,
		[Token(Token = "0x400086E")]
		ContactState,
		[Token(Token = "0x400086F")]
		ActionState
	}
	[Token(Token = "0x20001B1")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFA769C", Offset = "0xFA769C", VA = "0xFA769C")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000AF")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0xFA7754", Offset = "0xFA7754", VA = "0xFA7754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xFA7498", Offset = "0xFA7498", VA = "0xFA7498")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xFA759C", Offset = "0xFA759C", VA = "0xFA759C")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xFA77AC", Offset = "0xFA77AC", VA = "0xFA77AC")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001B4")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0xFA7F78", Offset = "0xFA7F78", VA = "0xFA7F78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000787")]
				[Address(RVA = "0xFA7FC0", Offset = "0xFA7FC0", VA = "0xFA7FC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xFA7954", Offset = "0xFA7954", VA = "0xFA7954")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xFA7A90", Offset = "0xFA7A90", VA = "0xFA7A90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xFA7AAC", Offset = "0xFA7AAC", VA = "0xFA7AAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xFA7F28", Offset = "0xFA7F28", VA = "0xFA7F28")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xFA7F80", Offset = "0xFA7F80", VA = "0xFA7F80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xFA784C", Offset = "0xFA784C", VA = "0xFA784C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFA78B8", Offset = "0xFA78B8", VA = "0xFA78B8")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xFA797C", Offset = "0xFA797C", VA = "0xFA797C")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xFA7A88", Offset = "0xFA7A88", VA = "0xFA7A88")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000B2")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xFA7FC8", Offset = "0xFA7FC8", VA = "0xFA7FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xFA8124", Offset = "0xFA8124", VA = "0xFA8124")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xFA81C0", Offset = "0xFA81C0", VA = "0xFA81C0")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xFA825C", Offset = "0xFA825C", VA = "0xFA825C")]
		private void Update()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xFA8514", Offset = "0xFA8514", VA = "0xFA8514")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xFA8550", Offset = "0xFA8550", VA = "0xFA8550")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xFA8828", Offset = "0xFA8828", VA = "0xFA8828")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xFA8A30", Offset = "0xFA8A30", VA = "0xFA8A30")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001B7")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A1")]
				[Address(RVA = "0xFA9C18", Offset = "0xFA9C18", VA = "0xFA9C18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0xFA9C60", Offset = "0xFA9C60", VA = "0xFA9C60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xFA8CCC", Offset = "0xFA8CCC", VA = "0xFA8CCC")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0xFA977C", Offset = "0xFA977C", VA = "0xFA977C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xFA9780", Offset = "0xFA9780", VA = "0xFA9780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xFA9C20", Offset = "0xFA9C20", VA = "0xFA9C20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000888")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000B3")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xFA8B38", Offset = "0xFA8B38", VA = "0xFA8B38", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000B4")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0xFA8B40", Offset = "0xFA8B40", VA = "0xFA8B40", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000B5")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0xFA8B48", Offset = "0xFA8B48", VA = "0xFA8B48", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		public override bool EnableState
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xFA8B50", Offset = "0xFA8B50", VA = "0xFA8B50", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000794")]
			[Address(RVA = "0xFA8B78", Offset = "0xFA8B78", VA = "0xFA8B78", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xFA8BA8", Offset = "0xFA8BA8", VA = "0xFA8BA8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xFA8C58", Offset = "0xFA8C58", VA = "0xFA8C58")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xFA8CF4", Offset = "0xFA8CF4", VA = "0xFA8CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xFA8F7C", Offset = "0xFA8F7C", VA = "0xFA8F7C")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xFA9138", Offset = "0xFA9138", VA = "0xFA9138")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xFA9224", Offset = "0xFA9224", VA = "0xFA9224", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xFA95B8", Offset = "0xFA95B8", VA = "0xFA95B8", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xFA95BC", Offset = "0xFA95BC", VA = "0xFA95BC", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xFA95C0", Offset = "0xFA95C0", VA = "0xFA95C0")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x170000B9")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xFA9C68", Offset = "0xFA9C68", VA = "0xFA9C68", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xFA9C70", Offset = "0xFA9C70", VA = "0xFA9C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool EnableState
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xFA9C78", Offset = "0xFA9C78", VA = "0xFA9C78", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xFA9C94", Offset = "0xFA9C94", VA = "0xFA9C94", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xFA9CB4", Offset = "0xFA9CB4", VA = "0xFA9CB4", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xFA9CBC", Offset = "0xFA9CBC", VA = "0xFA9CBC", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public float SphereRadius
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xFA9CC8", Offset = "0xFA9CC8", VA = "0xFA9CC8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xFA9CD0", Offset = "0xFA9CD0", VA = "0xFA9CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xFA9CD8", Offset = "0xFA9CD8", VA = "0xFA9CD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xFA9D14", Offset = "0xFA9D14", VA = "0xFA9D14", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xFA9D18", Offset = "0xFA9D18", VA = "0xFA9D18")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x400089B")]
		None = 0,
		[Token(Token = "0x400089C")]
		Ray = 1,
		[Token(Token = "0x400089D")]
		Poke = 4,
		[Token(Token = "0x400089E")]
		All = -1
	}
	[Token(Token = "0x20001BA")]
	public enum ToolInputState
	{
		[Token(Token = "0x40008A0")]
		Inactive,
		[Token(Token = "0x40008A1")]
		PrimaryInputDown,
		[Token(Token = "0x40008A2")]
		PrimaryInputDownStay,
		[Token(Token = "0x40008A3")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001BB")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xFA9564", Offset = "0xFA9564", VA = "0xFA9564")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000BD")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xFA9D20", Offset = "0xFA9D20", VA = "0xFA9D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xFA9D28", Offset = "0xFA9D28", VA = "0xFA9D28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xFA9D30", Offset = "0xFA9D30", VA = "0xFA9D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60007B3")]
			get;
		}

		[Token(Token = "0x170000C0")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60007B4")]
			get;
		}

		[Token(Token = "0x170000C1")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60007B5")]
			get;
		}

		[Token(Token = "0x170000C2")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xFA9D3C", Offset = "0xFA9D3C", VA = "0xFA9D3C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xFA9D48", Offset = "0xFA9D48", VA = "0xFA9D48")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xFA9D54", Offset = "0xFA9D54", VA = "0xFA9D54")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xFA9D60", Offset = "0xFA9D60", VA = "0xFA9D60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60007BE")]
			get;
			[Token(Token = "0x60007BF")]
			set;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xFA9D6C", Offset = "0xFA9D6C", VA = "0xFA9D6C")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60007BB")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60007BC")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60007BD")]
		public abstract void DeFocus();

		[Token(Token = "0x60007C0")]
		public abstract void Initialize();

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xFA8998", Offset = "0xFA8998", VA = "0xFA8998")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xFA89E0", Offset = "0xFA89E0", VA = "0xFA89E0")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xFA9D74", Offset = "0xFA9D74", VA = "0xFA9D74", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xFAA03C", Offset = "0xFAA03C", VA = "0xFAA03C", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xFA95D4", Offset = "0xFA95D4", VA = "0xFA95D4")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000C5")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x60007C6")]
			get;
		}

		[Token(Token = "0x170000C6")]
		bool EnableState
		{
			[Token(Token = "0x60007C8")]
			get;
			[Token(Token = "0x60007C9")]
			set;
		}

		[Token(Token = "0x170000C7")]
		bool ToolActivateState
		{
			[Token(Token = "0x60007CA")]
			get;
			[Token(Token = "0x60007CB")]
			set;
		}

		[Token(Token = "0x60007C7")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20001BE")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001BF")]
		private enum PinchState
		{
			[Token(Token = "0x40008B4")]
			None,
			[Token(Token = "0x40008B5")]
			PinchDown,
			[Token(Token = "0x40008B6")]
			PinchStay,
			[Token(Token = "0x40008B7")]
			PinchUp
		}

		[Token(Token = "0x40008B0")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000C8")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xFAA8D8", Offset = "0xFAA8D8", VA = "0xFAA8D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xFAA954", Offset = "0xFAA954", VA = "0xFAA954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xFAA9D0", Offset = "0xFAA9D0", VA = "0xFAA9D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xFAAA4C", Offset = "0xFAAA4C", VA = "0xFAAA4C")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xFAAA74", Offset = "0xFAAA74", VA = "0xFAAA74")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40008B8")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40008B9")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40008BA")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40008BB")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40008BC")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000CB")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xFAABEC", Offset = "0xFAABEC", VA = "0xFAABEC", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000CC")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xFAABF4", Offset = "0xFAABF4", VA = "0xFAABF4", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000CD")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xFAAC50", Offset = "0xFAAC50", VA = "0xFAAC50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public override bool EnableState
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xFAAC58", Offset = "0xFAAC58", VA = "0xFAAC58", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xFAAC98", Offset = "0xFAAC98", VA = "0xFAAC98", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFAAD08", Offset = "0xFAAD08", VA = "0xFAAD08", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xFAAD5C", Offset = "0xFAAD5C", VA = "0xFAAD5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xFAADE8", Offset = "0xFAADE8", VA = "0xFAADE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xFAB094", Offset = "0xFAB094", VA = "0xFAB094")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFAB110", Offset = "0xFAB110", VA = "0xFAB110", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFAB504", Offset = "0xFAB504", VA = "0xFAB504")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFAB6A0", Offset = "0xFAB6A0", VA = "0xFAB6A0")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xFAB7B8", Offset = "0xFAB7B8", VA = "0xFAB7B8")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xFABADC", Offset = "0xFABADC", VA = "0xFABADC")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFABE58", Offset = "0xFABE58", VA = "0xFABE58", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFABF30", Offset = "0xFABF30", VA = "0xFABF30", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFABF60", Offset = "0xFABF60", VA = "0xFABF60")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40008C8")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40008C9")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000CF")]
		public bool EnableState
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xFAAC7C", Offset = "0xFAAC7C", VA = "0xFAAC7C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xFAACB4", Offset = "0xFAACB4", VA = "0xFAACB4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xFAC074", Offset = "0xFAC074", VA = "0xFAC074", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xFAB058", Offset = "0xFAB058", VA = "0xFAB058", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xFAC29C", Offset = "0xFAC29C", VA = "0xFAC29C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0xFAC2A4", Offset = "0xFAC2A4", VA = "0xFAC2A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFAC07C", Offset = "0xFAC07C", VA = "0xFAC07C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xFABE90", Offset = "0xFABE90", VA = "0xFABE90", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xFAC2AC", Offset = "0xFAC2AC", VA = "0xFAC2AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xFAC558", Offset = "0xFAC558", VA = "0xFAC558")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xFAC600", Offset = "0xFAC600", VA = "0xFAC600")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000D2")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xFAC664", Offset = "0xFAC664", VA = "0xFAC664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xFAC66C", Offset = "0xFAC66C", VA = "0xFAC66C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xFAC6D8", Offset = "0xFAC6D8", VA = "0xFAC6D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0xFAC6E0", Offset = "0xFAC6E0", VA = "0xFAC6E0")]
			set
			{
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xFAC73C", Offset = "0xFAC73C", VA = "0xFAC73C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xFAC9DC", Offset = "0xFAC9DC", VA = "0xFAC9DC")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xFAC9EC", Offset = "0xFAC9EC", VA = "0xFAC9EC")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xFAC9FC", Offset = "0xFAC9FC", VA = "0xFAC9FC")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xFACA04", Offset = "0xFACA04", VA = "0xFACA04")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xFACA08", Offset = "0xFACA08", VA = "0xFACA08")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xFACA94", Offset = "0xFACA94", VA = "0xFACA94")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xFACB24", Offset = "0xFACB24", VA = "0xFACB24")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xFACBB4", Offset = "0xFACBB4", VA = "0xFACBB4")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xFACC60", Offset = "0xFACC60", VA = "0xFACC60")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xFACD3C", Offset = "0xFACD3C", VA = "0xFACD3C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xFACD80", Offset = "0xFACD80", VA = "0xFACD80")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xFACDE4", Offset = "0xFACDE4", VA = "0xFACDE4")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFACE44", Offset = "0xFACE44", VA = "0xFACE44")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFACE4C", Offset = "0xFACE4C", VA = "0xFACE4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFACE50", Offset = "0xFACE50", VA = "0xFACE50")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFACE14", Offset = "0xFACE14", VA = "0xFACE14")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFACE84", Offset = "0xFACE84", VA = "0xFACE84")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001C6")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0xFAD504", Offset = "0xFAD504", VA = "0xFAD504", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080D")]
				[Address(RVA = "0xFAD54C", Offset = "0xFAD54C", VA = "0xFAD54C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0xFAD27C", Offset = "0xFAD27C", VA = "0xFAD27C")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0xFAD344", Offset = "0xFAD344", VA = "0xFAD344", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0xFAD348", Offset = "0xFAD348", VA = "0xFAD348", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0xFAD50C", Offset = "0xFAD50C", VA = "0xFAD50C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008D9")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x40008DA")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFACE8C", Offset = "0xFACE8C", VA = "0xFACE8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFACF2C", Offset = "0xFACF2C", VA = "0xFACF2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFAD23C", Offset = "0xFAD23C", VA = "0xFAD23C")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xFAD1C8", Offset = "0xFAD1C8", VA = "0xFAD1C8")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFAD2A4", Offset = "0xFAD2A4", VA = "0xFAD2A4")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001C8")]
		public enum SelectionState
		{
			[Token(Token = "0x40008F0")]
			Off,
			[Token(Token = "0x40008F1")]
			Selected,
			[Token(Token = "0x40008F2")]
			Highlighted
		}

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000D6")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xFAD554", Offset = "0xFAD554", VA = "0xFAD554")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xFAD55C", Offset = "0xFAD55C", VA = "0xFAD55C")]
			set
			{
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xFAD6B0", Offset = "0xFAD6B0", VA = "0xFAD6B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xFAD874", Offset = "0xFAD874", VA = "0xFAD874")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xFAD5D0", Offset = "0xFAD5D0", VA = "0xFAD5D0")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xFAD93C", Offset = "0xFAD93C", VA = "0xFAD93C")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001CA")]
		public enum SegmentType
		{
			[Token(Token = "0x4000901")]
			Straight,
			[Token(Token = "0x4000902")]
			LeftTurn,
			[Token(Token = "0x4000903")]
			RightTurn,
			[Token(Token = "0x4000904")]
			Switch
		}

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x40008F9")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x40008FA")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000D7")]
		public float StartDistance
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xFAD9AC", Offset = "0xFAD9AC", VA = "0xFAD9AC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xFAD9B4", Offset = "0xFAD9B4", VA = "0xFAD9B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public float GridSize
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0xFAD9BC", Offset = "0xFAD9BC", VA = "0xFAD9BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xFAD9C4", Offset = "0xFAD9C4", VA = "0xFAD9C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public int SubDivCount
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0xFAD9CC", Offset = "0xFAD9CC", VA = "0xFAD9CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600081A")]
			[Address(RVA = "0xFAD9D4", Offset = "0xFAD9D4", VA = "0xFAD9D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public SegmentType Type
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0xFAD9DC", Offset = "0xFAD9DC", VA = "0xFAD9DC")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000DB")]
		public Pose EndPose
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0xFAD9E4", Offset = "0xFAD9E4", VA = "0xFAD9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public float Radius
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xFADDB8", Offset = "0xFADDB8", VA = "0xFADDB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DD")]
		public float SegmentLength
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xFADA40", Offset = "0xFADA40", VA = "0xFADA40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xFADDC8", Offset = "0xFADDC8", VA = "0xFADDC8")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xFADDE0", Offset = "0xFADDE0", VA = "0xFADDE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xFADA80", Offset = "0xFADA80", VA = "0xFADA80")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xFADDE4", Offset = "0xFADDE4", VA = "0xFADDE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xFADDE8", Offset = "0xFADDE8", VA = "0xFADDE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFADE44", Offset = "0xFADE44", VA = "0xFADE44")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xFAE778", Offset = "0xFAE778", VA = "0xFAE778")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xFAE9FC", Offset = "0xFAE9FC", VA = "0xFAE9FC")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001CC")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0xFAF520", Offset = "0xFAF520", VA = "0xFAF520", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000837")]
				[Address(RVA = "0xFAF568", Offset = "0xFAF568", VA = "0xFAF568", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xFAF354", Offset = "0xFAF354", VA = "0xFAF354")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0xFAF3A4", Offset = "0xFAF3A4", VA = "0xFAF3A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xFAF3A8", Offset = "0xFAF3A8", VA = "0xFAF3A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xFAF528", Offset = "0xFAF528", VA = "0xFAF528", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000905")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000906")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xFAEB5C", Offset = "0xFAEB5C", VA = "0xFAEB5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xFAEC14", Offset = "0xFAEC14", VA = "0xFAEC14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xFAECA4", Offset = "0xFAECA4", VA = "0xFAECA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xFAEDEC", Offset = "0xFAEDEC", VA = "0xFAEDEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFAEF78", Offset = "0xFAEF78", VA = "0xFAEF78")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFAF088", Offset = "0xFAF088", VA = "0xFAF088")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFAF28C", Offset = "0xFAF28C", VA = "0xFAF28C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFAF198", Offset = "0xFAF198", VA = "0xFAF198")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFAF1AC", Offset = "0xFAF1AC", VA = "0xFAF1AC")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFAF2E0", Offset = "0xFAF2E0", VA = "0xFAF2E0")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFAF37C", Offset = "0xFAF37C", VA = "0xFAF37C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001CD")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000E0")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xFAF570", Offset = "0xFAF570", VA = "0xFAF570")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFAF580", Offset = "0xFAF580", VA = "0xFAF580", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFAF588", Offset = "0xFAF588", VA = "0xFAF588", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFAF8B8", Offset = "0xFAF8B8", VA = "0xFAF8B8")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x400091E")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x400091F")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000E1")]
		public float Distance
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0xFAF9B4", Offset = "0xFAF9B4", VA = "0xFAF9B4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0xFAF9BC", Offset = "0xFAF9BC", VA = "0xFAF9BC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public float Scale
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0xFAF9C4", Offset = "0xFAF9C4", VA = "0xFAF9C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xFAF9CC", Offset = "0xFAF9CC", VA = "0xFAF9CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFAF584", Offset = "0xFAF584", VA = "0xFAF584", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFAF9D4", Offset = "0xFAF9D4", VA = "0xFAF9D4")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFAF5C4", Offset = "0xFAF5C4", VA = "0xFAF5C4")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFAF7D4", Offset = "0xFAF7D4", VA = "0xFAF7D4")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000844")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFAF918", Offset = "0xFAF918", VA = "0xFAF918")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001CF")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000853")]
				[Address(RVA = "0xFB02A4", Offset = "0xFB02A4", VA = "0xFB02A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000855")]
				[Address(RVA = "0xFB02EC", Offset = "0xFB02EC", VA = "0xFB02EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xFAFF18", Offset = "0xFAFF18", VA = "0xFAFF18")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0xFB008C", Offset = "0xFB008C", VA = "0xFB008C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0xFB0090", Offset = "0xFB0090", VA = "0xFB0090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0xFB02AC", Offset = "0xFB02AC", VA = "0xFB02AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFAFB44", Offset = "0xFAFB44", VA = "0xFAFB44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xFAFBA0", Offset = "0xFAFBA0", VA = "0xFAFBA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xFAFC78", Offset = "0xFAFC78", VA = "0xFAFC78")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xFAFDCC", Offset = "0xFAFDCC", VA = "0xFAFDCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xFAFCD4", Offset = "0xFAFCD4", VA = "0xFAFCD4")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xFAFE94", Offset = "0xFAFE94", VA = "0xFAFE94")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFAFF40", Offset = "0xFAFF40", VA = "0xFAFF40")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFAFFD8", Offset = "0xFAFFD8", VA = "0xFAFFD8")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFB0034", Offset = "0xFB0034", VA = "0xFB0034")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001D2")]
		private enum EngineSoundState
		{
			[Token(Token = "0x400095C")]
			Start,
			[Token(Token = "0x400095D")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x400095E")]
			Stop
		}

		[Token(Token = "0x20001D3")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0xFB0B84", Offset = "0xFB0B84", VA = "0xFB0B84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0xFB0BCC", Offset = "0xFB0BCC", VA = "0xFB0BCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0xFB0594", Offset = "0xFB0594", VA = "0xFB0594")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0xFB095C", Offset = "0xFB095C", VA = "0xFB095C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0xFB0960", Offset = "0xFB0960", VA = "0xFB0960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0xFB0B8C", Offset = "0xFB0B8C", VA = "0xFB0B8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400093E")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x400093F")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000940")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000941")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFB02F4", Offset = "0xFB02F4", VA = "0xFB02F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xFB0450", Offset = "0xFB0450", VA = "0xFB0450")]
		private void Update()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFB045C", Offset = "0xFB045C", VA = "0xFB045C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xFACA38", Offset = "0xFACA38", VA = "0xFACA38")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xFB03C8", Offset = "0xFB03C8", VA = "0xFB03C8")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xFB05BC", Offset = "0xFB05BC", VA = "0xFB05BC")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xFB0534", Offset = "0xFB0534", VA = "0xFB0534")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xFACAC4", Offset = "0xFACAC4", VA = "0xFACAC4")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xFACB54", Offset = "0xFACB54", VA = "0xFACB54")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xFB07D0", Offset = "0xFB07D0", VA = "0xFB07D0")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xFB08C4", Offset = "0xFB08C4", VA = "0xFB08C4")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xFACBE4", Offset = "0xFACBE4", VA = "0xFACBE4")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xFACC90", Offset = "0xFACC90", VA = "0xFACC90")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xFACD70", Offset = "0xFACD70", VA = "0xFACD70")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xFB0900", Offset = "0xFB0900", VA = "0xFB0900")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000E7")]
		public float TrackLength
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xFB0BD4", Offset = "0xFB0BD4", VA = "0xFB0BD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xFB0BDC", Offset = "0xFB0BDC", VA = "0xFB0BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xFB0BE4", Offset = "0xFB0BE4", VA = "0xFB0BE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xFAFA3C", Offset = "0xFAFA3C", VA = "0xFAFA3C")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFB0BE8", Offset = "0xFB0BE8", VA = "0xFB0BE8")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xFB0DE0", Offset = "0xFB0DE0", VA = "0xFB0DE0")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xFB0EC0", Offset = "0xFB0EC0", VA = "0xFB0EC0")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public class Pose
	{
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xFAEAC4", Offset = "0xFAEAC4", VA = "0xFAEAC4")]
		public Pose()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xFB0EDC", Offset = "0xFB0EDC", VA = "0xFB0EDC")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001D7")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0xFB14D0", Offset = "0xFB14D0", VA = "0xFB14D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0xFB1518", Offset = "0xFB1518", VA = "0xFB1518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0xFB11B8", Offset = "0xFB11B8", VA = "0xFB11B8")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0xFB132C", Offset = "0xFB132C", VA = "0xFB132C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xFB1330", Offset = "0xFB1330", VA = "0xFB1330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xFB14D8", Offset = "0xFB14D8", VA = "0xFB14D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001D8")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000EB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000886")]
				[Address(RVA = "0xFB15F4", Offset = "0xFB15F4", VA = "0xFB15F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0xFB163C", Offset = "0xFB163C", VA = "0xFB163C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0xFB1294", Offset = "0xFB1294", VA = "0xFB1294")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xFB1520", Offset = "0xFB1520", VA = "0xFB1520", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0xFB1524", Offset = "0xFB1524", VA = "0xFB1524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0xFB15FC", Offset = "0xFB15FC", VA = "0xFB15FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000971")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000E8")]
		public bool IsMoving
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xFB0F40", Offset = "0xFB0F40", VA = "0xFB0F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xFB0F48", Offset = "0xFB0F48", VA = "0xFB0F48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xFB0F54", Offset = "0xFB0F54", VA = "0xFB0F54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xFB0F84", Offset = "0xFB0F84", VA = "0xFB0F84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xFB10C4", Offset = "0xFB10C4", VA = "0xFB10C4")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xFB1134", Offset = "0xFB1134", VA = "0xFB1134")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xFB11E0", Offset = "0xFB11E0", VA = "0xFB11E0")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xFB12BC", Offset = "0xFB12BC", VA = "0xFB12BC")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFB1324", Offset = "0xFB1324", VA = "0xFB1324")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xFB1644", Offset = "0xFB1644", VA = "0xFB1644")]
		private void Awake()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xFB16B8", Offset = "0xFB16B8", VA = "0xFB16B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFB1780", Offset = "0xFB1780", VA = "0xFB1780")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFB1890", Offset = "0xFB1890", VA = "0xFB1890")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFB190C", Offset = "0xFB190C", VA = "0xFB190C")]
		private void Update()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFB19D4", Offset = "0xFB19D4", VA = "0xFB19D4")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x400098E")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x400098F")]
		EUDT_OverlayQuad,
		[Token(Token = "0x4000990")]
		EUDT_None,
		[Token(Token = "0x4000991")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20001DB")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001DC")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A2")]
				[Address(RVA = "0xFB3064", Offset = "0xFB3064", VA = "0xFB3064", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A4")]
				[Address(RVA = "0xFB30AC", Offset = "0xFB30AC", VA = "0xFB30AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0xFB26F4", Offset = "0xFB26F4", VA = "0xFB26F4")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xFB2E68", Offset = "0xFB2E68", VA = "0xFB2E68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xFB2E6C", Offset = "0xFB2E6C", VA = "0xFB2E6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xFB306C", Offset = "0xFB306C", VA = "0xFB306C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000993")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000994")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000995")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xFB19E4", Offset = "0xFB19E4", VA = "0xFB19E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xFB2224", Offset = "0xFB2224", VA = "0xFB2224")]
		private void Update()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xFB234C", Offset = "0xFB234C", VA = "0xFB234C")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xFB247C", Offset = "0xFB247C", VA = "0xFB247C")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFB25AC", Offset = "0xFB25AC", VA = "0xFB25AC")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xFB232C", Offset = "0xFB232C", VA = "0xFB232C")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xFB2680", Offset = "0xFB2680", VA = "0xFB2680")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xFB271C", Offset = "0xFB271C", VA = "0xFB271C")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xFB1E54", Offset = "0xFB1E54", VA = "0xFB1E54")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xFB2864", Offset = "0xFB2864", VA = "0xFB2864")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xFB2744", Offset = "0xFB2744", VA = "0xFB2744")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xFB2BEC", Offset = "0xFB2BEC", VA = "0xFB2BEC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFB2CD8", Offset = "0xFB2CD8", VA = "0xFB2CD8")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001DD")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x40009AD")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40009AE")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40009AF")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40009B0")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40009B1")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40009B2")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40009B3")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40009B4")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40009B5")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40009B6")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40009B7")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFB30B4", Offset = "0xFB30B4", VA = "0xFB30B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xFB310C", Offset = "0xFB310C", VA = "0xFB310C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xFB355C", Offset = "0xFB355C", VA = "0xFB355C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFB3648", Offset = "0xFB3648", VA = "0xFB3648")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFB37AC", Offset = "0xFB37AC", VA = "0xFB37AC")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xFB3A7C", Offset = "0xFB3A7C", VA = "0xFB3A7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xFB3B60", Offset = "0xFB3B60", VA = "0xFB3B60")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xFB3D10", Offset = "0xFB3D10", VA = "0xFB3D10")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFB3838", Offset = "0xFB3838", VA = "0xFB3838")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFB388C", Offset = "0xFB388C", VA = "0xFB388C")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFB341C", Offset = "0xFB341C", VA = "0xFB341C")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFB3E34", Offset = "0xFB3E34", VA = "0xFB3E34")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public enum HandPoseId
	{
		[Token(Token = "0x40009CC")]
		Default,
		[Token(Token = "0x40009CD")]
		Generic,
		[Token(Token = "0x40009CE")]
		PingPongBall,
		[Token(Token = "0x40009CF")]
		Controller
	}
	[Token(Token = "0x20001E0")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000EF")]
		public bool AllowPointing
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xFB3EEC", Offset = "0xFB3EEC", VA = "0xFB3EEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0xFB3EF4", Offset = "0xFB3EF4", VA = "0xFB3EF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xFB3EFC", Offset = "0xFB3EFC", VA = "0xFB3EFC")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFB3F04", Offset = "0xFB3F04", VA = "0xFB3F04")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFB3F0C", Offset = "0xFB3F0C", VA = "0xFB3F0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFB41D8", Offset = "0xFB41D8", VA = "0xFB41D8")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFB4228", Offset = "0xFB4228", VA = "0xFB4228")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFB4260", Offset = "0xFB4260", VA = "0xFB4260")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Voice.Demo.UIShapesDemo
{
	[Token(Token = "0x20001E2")]
	public class InteractionHandler : MonoBehaviour
	{
		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Default States")]
		[Multiline]
		[SerializeField]
		private string freshStateText;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("UI")]
		[SerializeField]
		private Text textArea;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool showJson;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Voice")]
		[SerializeField]
		private AppVoiceExperience appVoiceExperience;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string pendingText;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFB4268", Offset = "0xFB4268", VA = "0xFB4268")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFB4318", Offset = "0xFB4318", VA = "0xFB4318")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFB43C8", Offset = "0xFB43C8", VA = "0xFB43C8")]
		private void OnRequestStarted(WitRequest r)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFB4468", Offset = "0xFB4468", VA = "0xFB4468")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFB44B0", Offset = "0xFB44B0", VA = "0xFB44B0")]
		public void OnResponse(WitResponseNode response)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFB459C", Offset = "0xFB459C", VA = "0xFB459C")]
		public void OnError(string error, string message)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFB47B4", Offset = "0xFB47B4", VA = "0xFB47B4")]
		public void ToggleActivation()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFB4808", Offset = "0xFB4808", VA = "0xFB4808")]
		public InteractionHandler()
		{
		}
	}
	[Token(Token = "0x20001E3")]
	public class ColorChanger : MonoBehaviour
	{
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFB4868", Offset = "0xFB4868", VA = "0xFB4868")]
		private void SetColor(Transform trans, Color color)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFB4900", Offset = "0xFB4900", VA = "0xFB4900")]
		public void UpdateColor(WitResponseNode commandResult)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFB4B1C", Offset = "0xFB4B1C", VA = "0xFB4B1C")]
		public void UpdateColor(string[] results)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFB4990", Offset = "0xFB4990", VA = "0xFB4990")]
		public void UpdateColor(string colorName, string shape)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xFB4B4C", Offset = "0xFB4B4C", VA = "0xFB4B4C")]
		public ColorChanger()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	[ExecuteAlways]
	public class Instructions : MonoBehaviour
	{
		[Token(Token = "0x20001E5")]
		internal enum Step
		{
			[Token(Token = "0x40009DF")]
			SetupWit,
			[Token(Token = "0x40009E0")]
			MissingServerToken,
			[Token(Token = "0x40009E1")]
			MissingClientToken,
			[Token(Token = "0x40009E2")]
			AddConfig,
			[Token(Token = "0x40009E3")]
			AddVoiceExperiences,
			[Token(Token = "0x40009E4")]
			SetConfig,
			[Token(Token = "0x40009E5")]
			Ready
		}

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] steps;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text instructionText;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Step currentStep;

		[Token(Token = "0x170000F2")]
		internal Step CurrentStep
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xFB4B54", Offset = "0xFB4B54", VA = "0xFB4B54")]
			get
			{
				return default(Step);
			}
		}

		[Token(Token = "0x170000F3")]
		internal string CurrentStepText
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xFB4B5C", Offset = "0xFB4B5C", VA = "0xFB4B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xFB4BDC", Offset = "0xFB4BDC", VA = "0xFB4BDC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFB4BE4", Offset = "0xFB4BE4", VA = "0xFB4BE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFB4BE8", Offset = "0xFB4BE8", VA = "0xFB4BE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xFB4BE0", Offset = "0xFB4BE0", VA = "0xFB4BE0")]
		private void UpdateStep()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xFB4BEC", Offset = "0xFB4BEC", VA = "0xFB4BEC")]
		public Instructions()
		{
		}
	}
}
namespace Oculus.Voice.Demo.BuiltInDemo
{
	[Token(Token = "0x20001E6")]
	public class TimerController : MonoBehaviour
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _time;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _timerExist;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _timerRunning;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The UI text element to show app messages.")]
		public Text logText;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The timer ring sound.")]
		public AudioClip buzzSound;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xFB4F0C", Offset = "0xFB4F0C", VA = "0xFB4F0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xFB4FF8", Offset = "0xFB4FF8", VA = "0xFB4FF8")]
		private void Log(string msg)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xFB4F60", Offset = "0xFB4F60", VA = "0xFB4F60")]
		private void OnElapsedTime()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xFB507C", Offset = "0xFB507C", VA = "0xFB507C")]
		public void DeleteTimer()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFB50EC", Offset = "0xFB50EC", VA = "0xFB50EC")]
		public void CreateTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFB54C8", Offset = "0xFB54C8", VA = "0xFB54C8")]
		public void GetTimerIntent()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFB5560", Offset = "0xFB5560", VA = "0xFB5560")]
		public void PauseTimer()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFB55AC", Offset = "0xFB55AC", VA = "0xFB55AC")]
		public void ResumeTimer()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xFB55FC", Offset = "0xFB55FC", VA = "0xFB55FC")]
		public void SubtractTimeTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xFB5708", Offset = "0xFB5708", VA = "0xFB5708")]
		public void AddTimeToTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xFB5808", Offset = "0xFB5808", VA = "0xFB5808")]
		public float GetRemainingTime()
		{
			return default(float);
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xFB54E4", Offset = "0xFB54E4", VA = "0xFB54E4")]
		public string GetFormattedTimeFromSeconds()
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xFB5364", Offset = "0xFB5364", VA = "0xFB5364")]
		private bool ParseTime(string[] entityValues, out float time)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xFB5810", Offset = "0xFB5810", VA = "0xFB5810")]
		public TimerController()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	public class TimerDisplay : MonoBehaviour
	{
		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TimerController timer;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _uiText;

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xFB5818", Offset = "0xFB5818", VA = "0xFB5818")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xFB5870", Offset = "0xFB5870", VA = "0xFB5870")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xFB58AC", Offset = "0xFB58AC", VA = "0xFB58AC")]
		public TimerDisplay()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	public class WitActivation : MonoBehaviour
	{
		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppVoiceExperience voiceExperience;

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xFB58B4", Offset = "0xFB58B4", VA = "0xFB58B4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xFB5960", Offset = "0xFB5960", VA = "0xFB5960")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xFB59B8", Offset = "0xFB59B8", VA = "0xFB59B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xFB5A38", Offset = "0xFB5A38", VA = "0xFB5A38")]
		public void ActivateWit()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xFB5A5C", Offset = "0xFB5A5C", VA = "0xFB5A5C")]
		public WitActivation()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x20001E9")]
	public static class AvatarLogger
	{
		[Token(Token = "0x40009EE")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x40009EF")]
		public const string Tab = "    ";

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xFB5A64", Offset = "0xFB5A64", VA = "0xFB5A64")]
		[Conditional("ENABLE_AVATAR_LOG_BASIC")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xFB5AF0", Offset = "0xFB5AF0", VA = "0xFB5AF0")]
		[Conditional("ENABLE_AVATAR_LOG_BASIC")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xFB5B84", Offset = "0xFB5B84", VA = "0xFB5B84")]
		[Conditional("ENABLE_AVATAR_LOG_WARNING")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xFB5C10", Offset = "0xFB5C10", VA = "0xFB5C10")]
		[Conditional("ENABLE_AVATAR_LOG_ERROR")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xFB5C9C", Offset = "0xFB5C9C", VA = "0xFB5C9C")]
		[Conditional("ENABLE_AVATAR_LOG_ERROR")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class CAPI
	{
		[Token(Token = "0x20001EB")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x20001EC")]
		public enum Result
		{
			[Token(Token = "0x40009FB")]
			Success = 0,
			[Token(Token = "0x40009FC")]
			Failure = -1000,
			[Token(Token = "0x40009FD")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x40009FE")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x40009FF")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x4000A00")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x4000A01")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x4000A02")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x4000A03")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x20001ED")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000981")]
			[Address(RVA = "0xFBD224", Offset = "0xFBD224", VA = "0xFBD224")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x40009F0")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x40009F8")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xFB5D88", Offset = "0xFB5D88", VA = "0xFB5D88")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xFB5E14", Offset = "0xFB5E14", VA = "0xFB5E14")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xFB6030", Offset = "0xFB6030", VA = "0xFB6030")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xFB6108", Offset = "0xFB6108", VA = "0xFB6108")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xFB616C", Offset = "0xFB616C", VA = "0xFB616C")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xFB61D4", Offset = "0xFB61D4", VA = "0xFB61D4")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xFB6250", Offset = "0xFB6250", VA = "0xFB6250")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xFB6380", Offset = "0xFB6380", VA = "0xFB6380")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xFB63FC", Offset = "0xFB63FC", VA = "0xFB63FC")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xFB652C", Offset = "0xFB652C", VA = "0xFB652C")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xFB65A8", Offset = "0xFB65A8", VA = "0xFB65A8")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xFB6624", Offset = "0xFB6624", VA = "0xFB6624")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xFB66A0", Offset = "0xFB66A0", VA = "0xFB66A0")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xFB671C", Offset = "0xFB671C", VA = "0xFB671C")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xFB67A0", Offset = "0xFB67A0", VA = "0xFB67A0")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xFB6824", Offset = "0xFB6824", VA = "0xFB6824")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xFB68A8", Offset = "0xFB68A8", VA = "0xFB68A8")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xFB6924", Offset = "0xFB6924", VA = "0xFB6924")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xFB69A0", Offset = "0xFB69A0", VA = "0xFB69A0")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000900")]
		[Address(RVA = "0xFB6A24", Offset = "0xFB6A24", VA = "0xFB6A24")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x6000901")]
		[Address(RVA = "0xFB6AA8", Offset = "0xFB6AA8", VA = "0xFB6AA8")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000902")]
		[Address(RVA = "0xFB6B2C", Offset = "0xFB6B2C", VA = "0xFB6B2C")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000903")]
		[Address(RVA = "0xFB6BA8", Offset = "0xFB6BA8", VA = "0xFB6BA8")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xFB6C3C", Offset = "0xFB6C3C", VA = "0xFB6C3C")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000905")]
		[Address(RVA = "0xFB6CA4", Offset = "0xFB6CA4", VA = "0xFB6CA4")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x6000906")]
		[Address(RVA = "0xFB6D40", Offset = "0xFB6D40", VA = "0xFB6D40")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x6000907")]
		[Address(RVA = "0xFB6DF4", Offset = "0xFB6DF4", VA = "0xFB6DF4")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000908")]
		[Address(RVA = "0xFB6EB8", Offset = "0xFB6EB8", VA = "0xFB6EB8")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000909")]
		[Address(RVA = "0xFB6F44", Offset = "0xFB6F44", VA = "0xFB6F44")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600090A")]
		[Address(RVA = "0xFB6FC8", Offset = "0xFB6FC8", VA = "0xFB6FC8")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600090B")]
		[Address(RVA = "0xFB704C", Offset = "0xFB704C", VA = "0xFB704C")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600090C")]
		[Address(RVA = "0xFB70D0", Offset = "0xFB70D0", VA = "0xFB70D0")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600090D")]
		[Address(RVA = "0xFB7154", Offset = "0xFB7154", VA = "0xFB7154")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xFB71D0", Offset = "0xFB71D0", VA = "0xFB71D0")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xFB72D4", Offset = "0xFB72D4", VA = "0xFB72D4")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFB7250", Offset = "0xFB7250", VA = "0xFB7250")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xFB74C0", Offset = "0xFB74C0", VA = "0xFB74C0")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000912")]
		[Address(RVA = "0xFB7624", Offset = "0xFB7624", VA = "0xFB7624")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000913")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xFB76A0", Offset = "0xFB76A0", VA = "0xFB76A0")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000915")]
		[Address(RVA = "0xFB7934", Offset = "0xFB7934", VA = "0xFB7934")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xFB79B0", Offset = "0xFB79B0", VA = "0xFB79B0")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000917")]
		[Address(RVA = "0xFB7B14", Offset = "0xFB7B14", VA = "0xFB7B14")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xFB7B90", Offset = "0xFB7B90", VA = "0xFB7B90")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFB7CF4", Offset = "0xFB7CF4", VA = "0xFB7CF4")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFB7D70", Offset = "0xFB7D70", VA = "0xFB7D70")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFB7ED4", Offset = "0xFB7ED4", VA = "0xFB7ED4")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFB7F50", Offset = "0xFB7F50", VA = "0xFB7F50")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFB80B4", Offset = "0xFB80B4", VA = "0xFB80B4")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFB8130", Offset = "0xFB8130", VA = "0xFB8130")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x600091F")]
		[Address(RVA = "0xFB81AC", Offset = "0xFB81AC", VA = "0xFB81AC")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFB8238", Offset = "0xFB8238", VA = "0xFB8238")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xFB82B4", Offset = "0xFB82B4", VA = "0xFB82B4")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFB846C", Offset = "0xFB846C", VA = "0xFB846C")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x6000923")]
		[Address(RVA = "0xFB85A8", Offset = "0xFB85A8", VA = "0xFB85A8")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000924")]
		[Address(RVA = "0xFB83F0", Offset = "0xFB83F0", VA = "0xFB83F0")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000925")]
		[Address(RVA = "0xFB8624", Offset = "0xFB8624", VA = "0xFB8624")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000926")]
		[Address(RVA = "0xFB86A0", Offset = "0xFB86A0", VA = "0xFB86A0")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000927")]
		[Address(RVA = "0xFB8724", Offset = "0xFB8724", VA = "0xFB8724")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000928")]
		[Address(RVA = "0xFB87A0", Offset = "0xFB87A0", VA = "0xFB87A0")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000929")]
		[Address(RVA = "0xFB8824", Offset = "0xFB8824", VA = "0xFB8824")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600092A")]
		[Address(RVA = "0xFB88A0", Offset = "0xFB88A0", VA = "0xFB88A0")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xFB891C", Offset = "0xFB891C", VA = "0xFB891C")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600092C")]
		[Address(RVA = "0xFB8B64", Offset = "0xFB8B64", VA = "0xFB8B64")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xFB8BE8", Offset = "0xFB8BE8", VA = "0xFB8BE8")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600092E")]
		[Address(RVA = "0xFB8DFC", Offset = "0xFB8DFC", VA = "0xFB8DFC")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xFB8E90", Offset = "0xFB8E90", VA = "0xFB8E90")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x6000930")]
		[Address(RVA = "0xFB8FC4", Offset = "0xFB8FC4", VA = "0xFB8FC4")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000931")]
		[Address(RVA = "0xFB9040", Offset = "0xFB9040", VA = "0xFB9040")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xFB90BC", Offset = "0xFB90BC", VA = "0xFB90BC")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x6000933")]
		[Address(RVA = "0xFB91F4", Offset = "0xFB91F4", VA = "0xFB91F4")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xFB9270", Offset = "0xFB9270", VA = "0xFB9270")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x6000935")]
		[Address(RVA = "0xFB93A8", Offset = "0xFB93A8", VA = "0xFB93A8")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000936")]
		[Address(RVA = "0xFB9424", Offset = "0xFB9424", VA = "0xFB9424")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000937")]
		[Address(RVA = "0xFB94A8", Offset = "0xFB94A8", VA = "0xFB94A8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000938")]
		[Address(RVA = "0xFB952C", Offset = "0xFB952C", VA = "0xFB952C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000939")]
		[Address(RVA = "0xFB95B0", Offset = "0xFB95B0", VA = "0xFB95B0")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093A")]
		[Address(RVA = "0xFB962C", Offset = "0xFB962C", VA = "0xFB962C")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093B")]
		[Address(RVA = "0xFB96B0", Offset = "0xFB96B0", VA = "0xFB96B0")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093C")]
		[Address(RVA = "0xFB9734", Offset = "0xFB9734", VA = "0xFB9734")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093D")]
		[Address(RVA = "0xFB97B0", Offset = "0xFB97B0", VA = "0xFB97B0")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093E")]
		[Address(RVA = "0xFB982C", Offset = "0xFB982C", VA = "0xFB982C")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600093F")]
		[Address(RVA = "0xFB98DC", Offset = "0xFB98DC", VA = "0xFB98DC")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000940")]
		[Address(RVA = "0xFB9960", Offset = "0xFB9960", VA = "0xFB9960")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000941")]
		[Address(RVA = "0xFB99E4", Offset = "0xFB99E4", VA = "0xFB99E4")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000942")]
		[Address(RVA = "0xFB9A60", Offset = "0xFB9A60", VA = "0xFB9A60")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000943")]
		[Address(RVA = "0xFB9ADC", Offset = "0xFB9ADC", VA = "0xFB9ADC")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000944")]
		[Address(RVA = "0xFB9B58", Offset = "0xFB9B58", VA = "0xFB9B58")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000945")]
		[Address(RVA = "0xFB9BEC", Offset = "0xFB9BEC", VA = "0xFB9BEC")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x6000946")]
		[Address(RVA = "0xFB9C78", Offset = "0xFB9C78", VA = "0xFB9C78")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x6000947")]
		[Address(RVA = "0xFB9D04", Offset = "0xFB9D04", VA = "0xFB9D04")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x6000948")]
		[Address(RVA = "0xFB9D90", Offset = "0xFB9D90", VA = "0xFB9D90")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000949")]
		[Address(RVA = "0xFB9E24", Offset = "0xFB9E24", VA = "0xFB9E24")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x600094A")]
		[Address(RVA = "0xFB9EB8", Offset = "0xFB9EB8", VA = "0xFB9EB8")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600094B")]
		[Address(RVA = "0xFB9F34", Offset = "0xFB9F34", VA = "0xFB9F34")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xFB9FB0", Offset = "0xFB9FB0", VA = "0xFB9FB0")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x600094D")]
		[Address(RVA = "0xFBA0E8", Offset = "0xFBA0E8", VA = "0xFBA0E8")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xFBA164", Offset = "0xFBA164", VA = "0xFBA164")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x600094F")]
		[Address(RVA = "0xFBA29C", Offset = "0xFBA29C", VA = "0xFBA29C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xFBA318", Offset = "0xFBA318", VA = "0xFBA318")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000951")]
		[Address(RVA = "0xFBA438", Offset = "0xFBA438", VA = "0xFBA438")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xFBA4B4", Offset = "0xFBA4B4", VA = "0xFBA4B4")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xFBA668", Offset = "0xFBA668", VA = "0xFBA668")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000954")]
		[Address(RVA = "0xFBA910", Offset = "0xFBA910", VA = "0xFBA910")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000955")]
		[Address(RVA = "0xFBA5EC", Offset = "0xFBA5EC", VA = "0xFBA5EC")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000956")]
		[Address(RVA = "0xFBA994", Offset = "0xFBA994", VA = "0xFBA994")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000957")]
		[Address(RVA = "0xFBAA10", Offset = "0xFBAA10", VA = "0xFBAA10")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x6000958")]
		[Address(RVA = "0xFBAA94", Offset = "0xFBAA94", VA = "0xFBAA94")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000959")]
		[Address(RVA = "0xFBAB18", Offset = "0xFBAB18", VA = "0xFBAB18")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x600095A")]
		[Address(RVA = "0xFBAB9C", Offset = "0xFBAB9C", VA = "0xFBAB9C")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x600095B")]
		[Address(RVA = "0xFBAC38", Offset = "0xFBAC38", VA = "0xFBAC38")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x600095C")]
		[Address(RVA = "0xFBACD4", Offset = "0xFBACD4", VA = "0xFBACD4")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x600095D")]
		[Address(RVA = "0xFBAD68", Offset = "0xFBAD68", VA = "0xFBAD68")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600095E")]
		[Address(RVA = "0xFBADE4", Offset = "0xFBADE4", VA = "0xFBADE4")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600095F")]
		[Address(RVA = "0xFBAE60", Offset = "0xFBAE60", VA = "0xFBAE60")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000960")]
		[Address(RVA = "0xFBAEDC", Offset = "0xFBAEDC", VA = "0xFBAEDC")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000961")]
		[Address(RVA = "0xFBAF58", Offset = "0xFBAF58", VA = "0xFBAF58")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000962")]
		[Address(RVA = "0xFBAFD4", Offset = "0xFBAFD4", VA = "0xFBAFD4")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000963")]
		[Address(RVA = "0xFBB0F8", Offset = "0xFBB0F8", VA = "0xFBB0F8")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000964")]
		[Address(RVA = "0xFBB184", Offset = "0xFBB184", VA = "0xFBB184")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xFBB200", Offset = "0xFBB200", VA = "0xFBB200")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xFBB254", Offset = "0xFBB254", VA = "0xFBB254")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000967")]
		[Address(RVA = "0xFBB388", Offset = "0xFBB388", VA = "0xFBB388")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xFBB40C", Offset = "0xFBB40C", VA = "0xFBB40C")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000969")]
		[Address(RVA = "0xFBB540", Offset = "0xFBB540", VA = "0xFBB540")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x600096A")]
		[Address(RVA = "0xFBB5C4", Offset = "0xFBB5C4", VA = "0xFBB5C4")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xFBB658", Offset = "0xFBB658", VA = "0xFBB658")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600096C")]
		[Address(RVA = "0xFBB990", Offset = "0xFBB990", VA = "0xFBB990")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x600096D")]
		[Address(RVA = "0xFBBA0C", Offset = "0xFBBA0C", VA = "0xFBBA0C")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xFBBA98", Offset = "0xFBBA98", VA = "0xFBBA98")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600096F")]
		[Address(RVA = "0xFBC1EC", Offset = "0xFBC1EC", VA = "0xFBC1EC")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x6000970")]
		[Address(RVA = "0xFBC268", Offset = "0xFBC268", VA = "0xFBC268")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xFB5D30", Offset = "0xFB5D30", VA = "0xFB5D30")]
		[MonoPInvokeCallback(typeof(LoggingDelegate))]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000972")]
		[Address(RVA = "0xFBC2F4", Offset = "0xFBC2F4", VA = "0xFBC2F4")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000973")]
		[Address(RVA = "0xFBC374", Offset = "0xFBC374", VA = "0xFBC374")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x6000974")]
		[Address(RVA = "0xFBC3F0", Offset = "0xFBC3F0", VA = "0xFBC3F0")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000975")]
		[Address(RVA = "0xFBC46C", Offset = "0xFBC46C", VA = "0xFBC46C")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xFBC4E8", Offset = "0xFBC4E8", VA = "0xFBC4E8")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000977")]
		[Address(RVA = "0xFBCE40", Offset = "0xFBCE40", VA = "0xFBCE40")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xFBCEBC", Offset = "0xFBCEBC", VA = "0xFBCEBC")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000979")]
		[Address(RVA = "0xFBD2FC", Offset = "0xFBD2FC", VA = "0xFBD2FC")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xFBD1A0", Offset = "0xFBD1A0", VA = "0xFBD1A0")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xFBD364", Offset = "0xFBD364", VA = "0xFBD364")]
		public CAPI()
		{
		}
	}
}
namespace LuxURPEssentials
{
	[Token(Token = "0x20001EE")]
	public class DecalManager : MonoBehaviour
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Gizmos;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawDecalGizmos;

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xFBD644", Offset = "0xFBD644", VA = "0xFBD644")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xFBD6A4", Offset = "0xFBD6A4", VA = "0xFBD6A4")]
		public DecalManager()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	[RequireComponent(typeof(MeshFilter))]
	public class LuxURP_BillboardBounds : MonoBehaviour
	{
		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Scale of the tweaked bounding box.")]
		[Space(18f)]
		[Space(5f)]
		[LuxURP_HelpBtn("h.9i03ddhmnooa")]
		private Vector3 _Scale;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("If checked Unity will instantiate the assigned mesh on Start().")]
		private bool _createUniqueMesh;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[Tooltip("Check this to preview the scaled bounding box.")]
		[Space(8f)]
		[SerializeField]
		private bool _drawBounds;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh _Mesh;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xFBD700", Offset = "0xFBD700", VA = "0xFBD700")]
		private void Start()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xFBD710", Offset = "0xFBD710", VA = "0xFBD710")]
		private void SetBounds()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xFBD92C", Offset = "0xFBD92C", VA = "0xFBD92C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xFBDB64", Offset = "0xFBDB64", VA = "0xFBDB64")]
		public LuxURP_BillboardBounds()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class LuxURP_HelpBtn : PropertyAttribute
	{
		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xFBDB84", Offset = "0xFBDB84", VA = "0xFBDB84")]
		public LuxURP_HelpBtn(string URL)
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(5f, order = 1)]
		[LuxURP_HelpBtn("h.2uxuzzrgrwpo", order = 0)]
		public LayerMask SmallDetailsLayer;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SmallDetailsDistance;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask MediumDetailsLayer;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MediumDetailsDistance;

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xFBDBB4", Offset = "0xFBDBB4", VA = "0xFBDBB4")]
		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xFBDBD4", Offset = "0xFBDBD4", VA = "0xFBDBD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xFBDD68", Offset = "0xFBDD68", VA = "0xFBDD68")]
		public LuxURP_LayerBasedCulling()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	[ExecuteAlways]
	public class LuxURP_SetupGlobals : MonoBehaviour
	{
		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D _BestFittingNormal;

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xFBDD80", Offset = "0xFBDD80", VA = "0xFBDD80")]
		private void SetupGlobals()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xFBDE14", Offset = "0xFBDE14", VA = "0xFBDE14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xFBDE18", Offset = "0xFBDE18", VA = "0xFBDE18")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xFBDE1C", Offset = "0xFBDE1C", VA = "0xFBDE1C")]
		public LuxURP_SetupGlobals()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F3")]
	public enum RTSize
	{
		[Token(Token = "0x4000A12")]
		_128 = 128,
		[Token(Token = "0x4000A13")]
		_256 = 256,
		[Token(Token = "0x4000A14")]
		_384 = 384,
		[Token(Token = "0x4000A15")]
		_512 = 512,
		[Token(Token = "0x4000A16")]
		_1024 = 1024
	}
	[Serializable]
	[Token(Token = "0x20001F4")]
	public enum RTFormat
	{
		[Token(Token = "0x4000A18")]
		ARGB32,
		[Token(Token = "0x4000A19")]
		ARGBHalf
	}
	[Serializable]
	[Token(Token = "0x20001F5")]
	public enum GustMixLayer
	{
		[Token(Token = "0x4000A1B")]
		Layer_0,
		[Token(Token = "0x4000A1C")]
		Layer_1,
		[Token(Token = "0x4000A1D")]
		Layer_2
	}
	[Token(Token = "0x20001F6")]
	[ExecuteAlways]
	[RequireComponent(typeof(WindZone))]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(5f)]
		[LuxURP_HelpBtn("h.wnnhm4pxp610")]
		[Space(3f)]
		public bool UpdateInEditMode;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Space(4f)]
		[Tooltip("Smaller resoltions will speed up rendering but may result in some quantization regarding the final bending.")]
		[Header("Render Texture Settings")]
		public RTSize Resolution;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("ARGB32 needs less memory and bandwidth but creates a slightly more quantized results - while ARGBHalf needs more memory and bandwith but gives you smoother results.")]
		public RTFormat Format;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Expects an RGBA texture with diffirently scaled noise patterns. If left empty the script will grab the default one.")]
		public Texture WindBaseTex;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader WindCompositeShader;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Wind Frequency and Turbulence")]
		[Space(4f)]
		[Range(0.1f, 1f)]
		[Tooltip("Drives the frequency of the turbulence animation according to the main wind strength.")]
		public float WindToFrequency;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Drives the strength of turbulence according to the main wind strength.")]
		public AnimationCurve WindToTurbulence;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 4f)]
		[Tooltip("Scales the final turbulence value used by the shaders.")]
		public float MaxTurbulence;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Header("Wind Speed and Size")]
		[Space(4f)]
		[Tooltip("Base Wind Speed in km/h at Main = 1 (WindZone).")]
		public float BaseWindSpeed;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Size of the Wind RenderTexture in World Space.")]
		public float SizeInWorldSpace;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Space(4f)]
		[Tooltip("Speed of Layer0 (red channel) relative to the Base Wind Speed.")]
		public float speedLayer0;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Speed of Layer1 (green channel) relative to the Base Wind Speed.")]
		public float speedLayer1;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Speed of Layer3 (blue channel) relative to the Base Wind Speed.")]
		public float speedLayer2;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Tiling of the gust layer (alpha channel) relative to Size In WorldSpace.")]
		[Space(4f)]
		[Header("Noise")]
		public int GrassGustTiling;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Speed of the gust layer (alpha channel) relative to the Base Wind Speed.")]
		public float GrassGustSpeed;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Lets you choose a Wind Layer you want the dedicated Gust sample to be combined with.")]
		public GustMixLayer LayerToMixWith;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Space(4f)]
		[Header("Wind Multipliers")]
		public float Grass;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float Foliage;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTexture WindRenderTexture;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material m_material;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 uvs;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 uvs1;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 uvs2;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 uvs3;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform trans;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private WindZone windZone;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float mainWind;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int WindRTPID;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int LuxURPWindDirSizePID;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int LuxURPWindStrengthMultipliersPID;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int LuxURPSinTimePID;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int LuxURPGustPID;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int LuxURPGustMixLayerPID;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int LuxURPBendFrequencyPID;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int LuxURPWindUVsPID;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int LuxURPWindUVs1PID;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int LuxURPWindUVs2PID;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int LuxURPWindUVs3PID;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int previousRTSize;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int previousRTFormat;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector4 WindDirectionSize;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float WindTurbulence;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector3[] MixLayers;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private double currentTime;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double domainTime_Wind;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float temp_WindFrequency;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float freqSpeed;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xFBDE24", Offset = "0xFBDE24", VA = "0xFBDE24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xFBE180", Offset = "0xFBE180", VA = "0xFBE180")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xFBE00C", Offset = "0xFBE00C", VA = "0xFBE00C")]
		private void SetupRT()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xFBE2C4", Offset = "0xFBE2C4", VA = "0xFBE2C4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xFBE4F8", Offset = "0xFBE4F8", VA = "0xFBE4F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xFBE8BC", Offset = "0xFBE8BC", VA = "0xFBE8BC")]
		public LuxURP_Wind()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	[RequireComponent(typeof(Terrain))]
	public class GetTerrainHeightNormalMap : MonoBehaviour
	{
		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData targetTerrainData;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string savePathTerrainHeightNormalMap;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xFBED5C", Offset = "0xFBED5C", VA = "0xFBED5C")]
		public void GetTerData()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xFBEE2C", Offset = "0xFBEE2C", VA = "0xFBEE2C")]
		public GetTerrainHeightNormalMap()
		{
		}
	}
}
namespace Lux_SRP_GrassDisplacement
{
	[Token(Token = "0x20001F8")]
	public class RotateAndMove : MonoBehaviour
	{
		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rotate;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool MoveUpDown;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float posy;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform trans;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xFBEE34", Offset = "0xFBEE34", VA = "0xFBEE34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xFBEEAC", Offset = "0xFBEEAC", VA = "0xFBEEAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xFBEF78", Offset = "0xFBEF78", VA = "0xFBEF78")]
		public RotateAndMove()
		{
		}
	}
	[Token(Token = "0x20001F9")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 velocity;

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xFBEF88", Offset = "0xFBEF88", VA = "0xFBEF88")]
		private void Update()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xFBF06C", Offset = "0xFBF06C", VA = "0xFBF06C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x20001FA")]
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer rend;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock mpb;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xFBF0D8", Offset = "0xFBF0D8", VA = "0xFBF0D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xFBF1D0", Offset = "0xFBF1D0", VA = "0xFBF1D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xFBF204", Offset = "0xFBF204", VA = "0xFBF204")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xFBF3AC", Offset = "0xFBF3AC", VA = "0xFBF3AC")]
		public ControlDisplacer()
		{
		}
	}
	[Token(Token = "0x20001FB")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem ps;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule main;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float min_alpha;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float max_alpha;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color min_StartColor;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color max_StartColor;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xFBF3C8", Offset = "0xFBF3C8", VA = "0xFBF3C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xFBF524", Offset = "0xFBF524", VA = "0xFBF524")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xFBF730", Offset = "0xFBF730", VA = "0xFBF730")]
		public ControlDisplacerParticleSys()
		{
		}
	}
	[Token(Token = "0x20001FC")]
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001FD")]
		public enum DebugSize
		{
			[Token(Token = "0x4000A6F")]
			_128 = 0x80,
			[Token(Token = "0x4000A70")]
			_256 = 0x100,
			[Token(Token = "0x4000A71")]
			_512 = 0x200,
			[Token(Token = "0x4000A72")]
			_1024 = 0x400
		}

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_EnableDebug;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugSize currentDebugSize;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xFBF74C", Offset = "0xFBF74C", VA = "0xFBF74C")]
		public DebugGrassDisplacementTex()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x20001FF")]
		public enum RTDisplacementSize
		{
			[Token(Token = "0x4000A76")]
			_128 = 0x80,
			[Token(Token = "0x4000A77")]
			_256 = 0x100,
			[Token(Token = "0x4000A78")]
			_512 = 0x200,
			[Token(Token = "0x4000A79")]
			_1024 = 0x400
		}

		[Serializable]
		[Token(Token = "0x2000200")]
		public class GrassDisplacementSettings
		{
			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RTDisplacementSize Resolution;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Size;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool ShiftRenderTex;

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xFBFA64", Offset = "0xFBFA64", VA = "0xFBFA64")]
			public GrassDisplacementSettings()
			{
			}
		}

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrassDisplacementSettings settings;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GrassDisplacementPass m_GrassDisplacementPass;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xFBF764", Offset = "0xFBF764", VA = "0xFBF764", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xFBF9C0", Offset = "0xFBF9C0", VA = "0xFBF9C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xFBF9E4", Offset = "0xFBF9E4", VA = "0xFBF9E4")]
		public GrassDisplacementRenderFeature()
		{
		}
	}
	[Token(Token = "0x2000201")]
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000A7D")]
		private const string ProfilerTag = "Render Lux Grass Displacement FX";

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ShaderTagId m_GrassDisplacementFXShaderTag;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private SinglePassStereoMode m_StereoRenderingMode;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Color m_ClearColor;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTargetHandle m_GrassDisplacementFX;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public float m_Size;

		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public int m_Resolution;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool m_ShiftRenderTex;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float stepSize;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float oneOverStepSize;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector4 posSize;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int DisplacementTexPosSizePID;

		[Token(Token = "0x170000F4")]
		private FilteringSettings transparentFilterSettings
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xFBFA78", Offset = "0xFBFA78", VA = "0xFBFA78")]
			[CompilerGenerated]
			get
			{
				return default(FilteringSettings);
			}
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xFBFA90", Offset = "0xFBFA90", VA = "0xFBFA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xFBF7FC", Offset = "0xFBF7FC", VA = "0xFBF7FC")]
		public GrassDisplacementPass()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xFBFAA8", Offset = "0xFBFAA8", VA = "0xFBFAA8", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xFBFCD8", Offset = "0xFBFCD8", VA = "0xFBFCD8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xFC0234", Offset = "0xFC0234", VA = "0xFC0234", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000202")]
	[AttributeUsage(AttributeTargets.Field)]
	public class LayerAttribute : PropertyAttribute
	{
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xFC0324", Offset = "0xFC0324", VA = "0xFC0324")]
		public LayerAttribute()
		{
		}
	}
}
namespace Unity.Linq.Sample
{
	[Token(Token = "0x2000203")]
	public class SampleSceneScript : MonoBehaviour
	{
		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject[] array;

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xFC032C", Offset = "0xFC032C", VA = "0xFC032C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xFC3F44", Offset = "0xFC3F44", VA = "0xFC3F44")]
		public SampleSceneScript()
		{
		}
	}
}
namespace EpicToonFX
{
	[Token(Token = "0x2000205")]
	public class ETFXButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ETFXFireProjectile effectScript;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ETFXProjectileScript projectileScript;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xFC43CC", Offset = "0xFC43CC", VA = "0xFC43CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xFC4588", Offset = "0xFC4588", VA = "0xFC4588")]
		private void Update()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xFC44D4", Offset = "0xFC44D4", VA = "0xFC44D4")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xFC45B4", Offset = "0xFC45B4", VA = "0xFC45B4")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xFC468C", Offset = "0xFC468C", VA = "0xFC468C")]
		public ETFXButtonScript()
		{
		}
	}
	[Token(Token = "0x2000206")]
	public class ETFXFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RaycastHit hit;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] projectiles;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform spawnPosition;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public int currentProjectile;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float speed;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ETFXButtonScript selectedProjectileButton;

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xFC4694", Offset = "0xFC4694", VA = "0xFC4694")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xFC4710", Offset = "0xFC4710", VA = "0xFC4710")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xFC4B1C", Offset = "0xFC4B1C", VA = "0xFC4B1C")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xFC4B58", Offset = "0xFC4B58", VA = "0xFC4B58")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xFC4B94", Offset = "0xFC4B94", VA = "0xFC4B94")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xFC4B9C", Offset = "0xFC4B9C", VA = "0xFC4B9C")]
		public ETFXFireProjectile()
		{
		}
	}
	[Token(Token = "0x2000207")]
	public class ETFXLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000208")]
		[CompilerGenerated]
		private sealed class <EffectLoop>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ETFXLoopScript <>4__this;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x170000F5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0xFC4F44", Offset = "0xFC4F44", VA = "0xFC4F44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D1")]
				[Address(RVA = "0xFC4F8C", Offset = "0xFC4F8C", VA = "0xFC4F8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xFC4C70", Offset = "0xFC4C70", VA = "0xFC4C70")]
			[DebuggerHidden]
			public <EffectLoop>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xFC4CB0", Offset = "0xFC4CB0", VA = "0xFC4CB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xFC4CB4", Offset = "0xFC4CB4", VA = "0xFC4CB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xFC4F4C", Offset = "0xFC4F4C", VA = "0xFC4F4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Spawn without")]
		public bool spawnWithoutLight;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool spawnWithoutSound;

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xFC4BAC", Offset = "0xFC4BAC", VA = "0xFC4BAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xFC4BB0", Offset = "0xFC4BB0", VA = "0xFC4BB0")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xFC4BFC", Offset = "0xFC4BFC", VA = "0xFC4BFC")]
		[IteratorStateMachine(typeof(<EffectLoop>d__6))]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xFC4C98", Offset = "0xFC4C98", VA = "0xFC4C98")]
		public ETFXLoopScript()
		{
		}
	}
	[Token(Token = "0x2000209")]
	public class ETFXMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xFC4F94", Offset = "0xFC4F94", VA = "0xFC4F94")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xFC5060", Offset = "0xFC5060", VA = "0xFC5060")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xFC53DC", Offset = "0xFC53DC", VA = "0xFC53DC")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xFC5418", Offset = "0xFC5418", VA = "0xFC5418")]
		public ETFXMouseOrbit()
		{
		}
	}
	[Token(Token = "0x200020A")]
	public class ETFXLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xFC5434", Offset = "0xFC5434", VA = "0xFC5434")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xFC5550", Offset = "0xFC5550", VA = "0xFC5550")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xFC56A4", Offset = "0xFC56A4", VA = "0xFC56A4")]
		public ETFXLightFade()
		{
		}
	}
	[Token(Token = "0x200020B")]
	public class ETFXPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xFC56C0", Offset = "0xFC56C0", VA = "0xFC56C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xFC5770", Offset = "0xFC5770", VA = "0xFC5770")]
		public ETFXPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x200020C")]
	public class ETFXRotation : MonoBehaviour
	{
		[Token(Token = "0x200020D")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000AC1")]
			Local,
			[Token(Token = "0x4000AC2")]
			World
		}

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xFC5780", Offset = "0xFC5780", VA = "0xFC5780")]
		private void Start()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xFC5784", Offset = "0xFC5784", VA = "0xFC5784")]
		private void Update()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xFC5858", Offset = "0xFC5858", VA = "0xFC5858")]
		public ETFXRotation()
		{
		}
	}
}
