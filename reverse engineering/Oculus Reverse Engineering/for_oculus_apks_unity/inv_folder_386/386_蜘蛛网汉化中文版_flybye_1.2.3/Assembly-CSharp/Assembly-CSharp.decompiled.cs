using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x721818", Offset = "0x721818", VA = "0x721818")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x721820", Offset = "0x721820", VA = "0x721820")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x7218A8", Offset = "0x7218A8", VA = "0x7218A8")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x7218D8", Offset = "0x7218D8", VA = "0x7218D8")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Token(Token = "0x2000005")]
public class FreeCam : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float movementSpeed;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fastMovementSpeed;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float freeLookSensitivity;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float zoomSensitivity;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fastZoomSensitivity;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool looking;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x721900", Offset = "0x721900", VA = "0x721900")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x722160", Offset = "0x722160", VA = "0x722160")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x722114", Offset = "0x722114", VA = "0x722114")]
	public void StartLooking()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x72213C", Offset = "0x72213C", VA = "0x72213C")]
	public void StopLooking()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x722184", Offset = "0x722184", VA = "0x722184")]
	public FreeCam()
	{
	}
}
[Token(Token = "0x2000006")]
public class FreeCamera : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableInputCapture;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool holdRightMouseCapture;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lookSpeed;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float sprintSpeed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_inputCaptured;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_yaw;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_pitch;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7221A0", Offset = "0x7221A0", VA = "0x7221A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7221AC", Offset = "0x7221AC", VA = "0x7221AC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7221DC", Offset = "0x7221DC", VA = "0x7221DC")]
	private void CaptureInput()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x72222C", Offset = "0x72222C", VA = "0x72222C")]
	private void ReleaseInput()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x722258", Offset = "0x722258", VA = "0x722258")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x722290", Offset = "0x722290", VA = "0x722290")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x722728", Offset = "0x722728", VA = "0x722728")]
	public FreeCamera()
	{
	}
}
[Token(Token = "0x2000007")]
public class SuperCamera : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject pivot;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeyCode resetShortcut;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 100f)]
	public float rotationSensibility;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool invertRotationX;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool invertRotationY;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 100f)]
	public float translationSensibility;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool invertTranslationX;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool invertTranslationY;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float zoomMax;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float zoomMin;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Range(0f, 100f)]
	public float wheelSensibility;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float delayDoubleClic;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 oldCamPos;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion oldCamRot;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 oldMousePos;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeDoubleClic;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool firstClic;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 pivotPos;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x722748", Offset = "0x722748", VA = "0x722748")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7227D0", Offset = "0x7227D0", VA = "0x7227D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x722FBC", Offset = "0x722FBC", VA = "0x722FBC")]
	public SuperCamera()
	{
	}
}
[Token(Token = "0x2000008")]
public class UIButton_ShowNext : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] GameObjectsList;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int shownGameObjectIndex;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x722FE4", Offset = "0x722FE4", VA = "0x722FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x72304C", Offset = "0x72304C", VA = "0x72304C")]
	public void SelectNextGameObject()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7230FC", Offset = "0x7230FC", VA = "0x7230FC")]
	public void SelectPreviousGameObject()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x723078", Offset = "0x723078", VA = "0x723078")]
	public void SelectGameObject(int index)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x723128", Offset = "0x723128", VA = "0x723128")]
	public UIButton_ShowNext()
	{
	}
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class HighscoreBoard : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Highscores highscores;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Highscore? latestHighscore;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x723138", Offset = "0x723138", VA = "0x723138")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x72351C", Offset = "0x72351C", VA = "0x72351C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x723750", Offset = "0x723750", VA = "0x723750")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x723954", Offset = "0x723954", VA = "0x723954")]
	private void InvokeSaveHighscores()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7239B0", Offset = "0x7239B0", VA = "0x7239B0")]
	private void SaveHighscores()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x723AA4", Offset = "0x723AA4", VA = "0x723AA4")]
	public Highscore HandleFinishGame(int score, string icon)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x724048", Offset = "0x724048", VA = "0x724048")]
	public void ResetHighscores()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x724150", Offset = "0x724150", VA = "0x724150")]
	public void UpdateLatestHighscoreIcon(string icon)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x72428C", Offset = "0x72428C", VA = "0x72428C")]
	public HighscoreBoard()
	{
	}
}
[Token(Token = "0x200000A")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class IconRepresentation : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x724294", Offset = "0x724294", VA = "0x724294")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7242EC", Offset = "0x7242EC", VA = "0x7242EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x724364", Offset = "0x724364", VA = "0x724364")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7243DC", Offset = "0x7243DC", VA = "0x7243DC")]
	private void RefreshIconRepresentation(string newIcon)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x724458", Offset = "0x724458", VA = "0x724458")]
	public IconRepresentation()
	{
	}
}
[Token(Token = "0x200000B")]
[RequireComponent(typeof(StatsBoards))]
public class InstructionsBoards : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Canvas instructionUI1;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Canvas instructionUI2;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Canvas instructionUI3;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Canvas instructionUI4;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI statsTogglerText;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool statsShowing;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private StatsBoards statsBoards;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x724460", Offset = "0x724460", VA = "0x724460")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7244B8", Offset = "0x7244B8", VA = "0x7244B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7246B4", Offset = "0x7246B4", VA = "0x7246B4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7247E4", Offset = "0x7247E4", VA = "0x7247E4")]
	private void StatsToggle()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7247F4", Offset = "0x7247F4", VA = "0x7247F4")]
	private void SetCanvasVisibilities()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x72494C", Offset = "0x72494C", VA = "0x72494C")]
	public bool SetStatsDisplay(CurrStats currStats, string icon)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7249F4", Offset = "0x7249F4", VA = "0x7249F4")]
	public InstructionsBoards()
	{
	}
}
[Token(Token = "0x200000C")]
public class StatsBoards : MonoBehaviour
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Canvas statsUI1;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Canvas statsUI2;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Canvas statsUI3;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI statsText1;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI statsText2;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI statsText3;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CurrStats currStats;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MaxStats maxStats;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<StatNames, string> StatDescriptions;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7249FC", Offset = "0x7249FC", VA = "0x7249FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7259B4", Offset = "0x7259B4", VA = "0x7259B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x725A78", Offset = "0x725A78", VA = "0x725A78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x725B3C", Offset = "0x725B3C", VA = "0x725B3C")]
	private void InvokeSaveStats()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x725B98", Offset = "0x725B98", VA = "0x725B98")]
	private void SaveStats()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x725C8C", Offset = "0x725C8C", VA = "0x725C8C")]
	private void ResetStats()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x726144", Offset = "0x726144", VA = "0x726144")]
	private void UpdateIcon(string icon)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x72498C", Offset = "0x72498C", VA = "0x72498C")]
	public bool SetStatsDisplay(CurrStats currStats, string icon)
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7248F0", Offset = "0x7248F0", VA = "0x7248F0")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x726A48", Offset = "0x726A48", VA = "0x726A48")]
	public string FormatElement(int spaceToTheLeft, StatNames name)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x724FE8", Offset = "0x724FE8", VA = "0x724FE8")]
	public void SetStatsStrings()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x727100", Offset = "0x727100", VA = "0x727100")]
	public StatsBoards()
	{
	}
}
[Token(Token = "0x200000D")]
[RequireComponent(typeof(Light))]
public class SunCycle : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color gameOver;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color gameStart;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color gameEnd;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Light directionalLight;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x727350", Offset = "0x727350", VA = "0x727350")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7273C8", Offset = "0x7273C8", VA = "0x7273C8")]
	public void Sunrise(float progress)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x72745C", Offset = "0x72745C", VA = "0x72745C")]
	public void Sunwierd(float progress)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7274F0", Offset = "0x7274F0", VA = "0x7274F0")]
	public SunCycle()
	{
	}
}
[Token(Token = "0x200000E")]
[RequireComponent(typeof(FlyingParticle))]
[RequireComponent(typeof(AudioSource))]
public class BeeBehaviour : FlyingBehaviour
{
	[Token(Token = "0x200000F")]
	public delegate void BeeAvoidedAction();

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] webDestructionSounds;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool clockwise;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool avoided;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private FlyingParticle particle;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource audioSource;

	[Token(Token = "0x14000001")]
	public static event BeeAvoidedAction RegisterBeeAvoided
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x7274F8", Offset = "0x7274F8", VA = "0x7274F8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x7275B0", Offset = "0x7275B0", VA = "0x7275B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x727668", Offset = "0x727668", VA = "0x727668")]
	private void Start()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x727740", Offset = "0x727740", VA = "0x727740", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7277D0", Offset = "0x7277D0", VA = "0x7277D0", Slot = "4")]
	public override void Initialize(Transform trgt, Transform plyr)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x727858", Offset = "0x727858", VA = "0x727858")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x727A24", Offset = "0x727A24", VA = "0x727A24")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x727B80", Offset = "0x727B80", VA = "0x727B80")]
	public BeeBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public struct StickParams
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float dissapearSpeed;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float rotationSpeed;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float despawnTime;
}
[Token(Token = "0x2000011")]
public enum StickBehaviourResult
{
	[Token(Token = "0x4000048")]
	Destroyed,
	[Token(Token = "0x4000049")]
	Eaten,
	[Token(Token = "0x400004A")]
	None
}
[Token(Token = "0x2000012")]
public class StickBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject fly;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator animator;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private StickParams stickParams;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int a_gotStuckHash;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int a_wingFlapMultiplierHash;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool stuck;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool beingEaten;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float stuckTime;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x727CA4", Offset = "0x727CA4", VA = "0x727CA4")]
	public StickBehaviour(GameObject fly, StickParams stickParams)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x727DA0", Offset = "0x727DA0", VA = "0x727DA0")]
	private Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x727F24", Offset = "0x727F24", VA = "0x727F24")]
	private void ProjectOntoWebLine(LineRenderer lineRenderer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x728004", Offset = "0x728004", VA = "0x728004")]
	private void GraduallyReduceFlapping()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x728094", Offset = "0x728094", VA = "0x728094")]
	public StickBehaviourResult Behave(LineRenderer lineRenderer)
	{
		return default(StickBehaviourResult);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x72824C", Offset = "0x72824C", VA = "0x72824C")]
	public void Stick(GameObject webLine)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7282C8", Offset = "0x7282C8", VA = "0x7282C8")]
	public void IndicateBeingEaten()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7282D4", Offset = "0x7282D4", VA = "0x7282D4")]
	public bool isStuck()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000013")]
public interface ISticks
{
	[Token(Token = "0x6000053")]
	void IndicateBeingEaten();
}
[Token(Token = "0x2000014")]
public class FlyBehaviour : FlyingBehaviour, ISticks
{
	[Token(Token = "0x2000015")]
	public delegate void FlyStuckAction(Vector3 position, Vector3 forward);

	[Token(Token = "0x2000016")]
	public delegate void FlyEatenAction();

	[Token(Token = "0x2000017")]
	public delegate void FlyEscapeAction();

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public StickParams stickParams;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StickBehaviour stickBehaviour;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static int escapeCount;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool escaped;

	[Token(Token = "0x14000002")]
	public static event FlyStuckAction RegisterFlyStuck
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x7282DC", Offset = "0x7282DC", VA = "0x7282DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x728394", Offset = "0x728394", VA = "0x728394")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event FlyEatenAction RegisterFlyEaten
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x72844C", Offset = "0x72844C", VA = "0x72844C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x728508", Offset = "0x728508", VA = "0x728508")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event FlyEscapeAction RegisterFlyEscape
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x7285C4", Offset = "0x7285C4", VA = "0x7285C4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x728680", Offset = "0x728680", VA = "0x728680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x72873C", Offset = "0x72873C", VA = "0x72873C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7287DC", Offset = "0x7287DC", VA = "0x7287DC", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x728844", Offset = "0x728844", VA = "0x728844")]
	public static void ResetEscapeCount()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x72888C", Offset = "0x72888C", VA = "0x72888C", Slot = "6")]
	public void IndicateBeingEaten()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7288AC", Offset = "0x7288AC", VA = "0x7288AC", Slot = "4")]
	public override void Initialize(Transform trgt, Transform plyr)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x7288B0", Offset = "0x7288B0", VA = "0x7288B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x728BFC", Offset = "0x728BFC", VA = "0x728BFC")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x728E7C", Offset = "0x728E7C", VA = "0x728E7C")]
	public FlyBehaviour()
	{
	}
}
[Token(Token = "0x2000018")]
[RequireComponent(typeof(ParticleSystem))]
public class PostFlyEmitter : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] flyStickingSounds;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentIndx;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem flyEmoteParticles;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] emmiters;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x729248", Offset = "0x729248", VA = "0x729248")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x729660", Offset = "0x729660", VA = "0x729660")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7298A4", Offset = "0x7298A4", VA = "0x7298A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x72961C", Offset = "0x72961C", VA = "0x72961C")]
	private int GetNextIndx()
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x729A14", Offset = "0x729A14", VA = "0x729A14")]
	public void Emit(Vector3 position, Vector3 forward)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x729BAC", Offset = "0x729BAC", VA = "0x729BAC")]
	public PostFlyEmitter()
	{
	}
}
[Token(Token = "0x2000019")]
public class StationaryFlyBehaviour : MonoBehaviour, ISticks
{
	[Token(Token = "0x200001A")]
	public delegate void StationaryFlyStuckAction(Vector3 position, Vector3 forward);

	[Token(Token = "0x200001B")]
	public delegate void StationaryFlyEatenAction();

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StickParams stickParams;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int xCoord;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int yCoord;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StickBehaviour stickBehaviour;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action<int, int> action;

	[Token(Token = "0x14000005")]
	public static event StationaryFlyStuckAction RegisterStationaryFlyStuck
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7297EC", Offset = "0x7297EC", VA = "0x7297EC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x72995C", Offset = "0x72995C", VA = "0x72995C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event StationaryFlyEatenAction RegisterStationaryFlyEaten
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x729BBC", Offset = "0x729BBC", VA = "0x729BBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x729C78", Offset = "0x729C78", VA = "0x729C78")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x729D34", Offset = "0x729D34", VA = "0x729D34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x729DD4", Offset = "0x729DD4", VA = "0x729DD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x729EAC", Offset = "0x729EAC", VA = "0x729EAC")]
	public void Initialize(int x, int y, Action<int, int> action)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x729EBC", Offset = "0x729EBC", VA = "0x729EBC", Slot = "4")]
	public void IndicateBeingEaten()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x729EDC", Offset = "0x729EDC", VA = "0x729EDC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x72A03C", Offset = "0x72A03C", VA = "0x72A03C")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x72A2A0", Offset = "0x72A2A0", VA = "0x72A2A0")]
	public StationaryFlyBehaviour()
	{
	}
}
[Token(Token = "0x200001C")]
public class FlyingBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Transform player;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int spawnCount;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int destroyCount;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7277D4", Offset = "0x7277D4", VA = "0x7277D4", Slot = "4")]
	public virtual void Initialize(Transform trgt, Transform plyr)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x72A48C", Offset = "0x72A48C", VA = "0x72A48C", Slot = "5")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x72A4DC", Offset = "0x72A4DC", VA = "0x72A4DC")]
	public static void ResetSpawnDestroyCount()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x72A524", Offset = "0x72A524", VA = "0x72A524")]
	public static int GetCurrentlySpawned()
	{
		return default(int);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x727B90", Offset = "0x727B90", VA = "0x727B90")]
	public FlyingBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class FlyingParams
{
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject Prefab;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableTargeting;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	public float TargetingConstant;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MinSqrAlignment;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float AlignmentConstant;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinSqrCohesion;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public float CohesionConstant;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x72A570", Offset = "0x72A570", VA = "0x72A570")]
	public FlyingParams()
	{
	}
}
[Token(Token = "0x200001E")]
public class FlyingGuide : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("General Flocking Parameters")]
	public bool enableSeparationAlignmentCohesion;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MinSeparation;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float SeparationConstant;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FlyingParams[] flyingThings;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, FlyingParams> flyingDict;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float MinSqrSeparation;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x72A598", Offset = "0x72A598", VA = "0x72A598")]
	private void Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x72A664", Offset = "0x72A664", VA = "0x72A664")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x72B448", Offset = "0x72B448", VA = "0x72B448")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x72B544", Offset = "0x72B544", VA = "0x72B544")]
	public FlyingGuide()
	{
	}
}
[Token(Token = "0x200001F")]
[RequireComponent(typeof(Rigidbody))]
public class FlyingParticle : MonoBehaviour
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float MinVelocity;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MaxVelocity;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float ForceVariability;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 Velocity;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float speedModifier;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody rigbdy;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x72B5E0", Offset = "0x72B5E0", VA = "0x72B5E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x72B690", Offset = "0x72B690", VA = "0x72B690")]
	public void SetSpeedModifier(float modifier)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x72B1D8", Offset = "0x72B1D8", VA = "0x72B1D8")]
	public Vector3 Position()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x72B4DC", Offset = "0x72B4DC", VA = "0x72B4DC")]
	public void LookAhead()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x72B1F8", Offset = "0x72B1F8", VA = "0x72B1F8")]
	public void Simulate(Vector3 force)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x72B698", Offset = "0x72B698", VA = "0x72B698")]
	public FlyingParticle()
	{
	}
}
[Serializable]
[Token(Token = "0x2000020")]
public class Spawnee
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject prefab;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform spawner;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform orchistrator;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float delaySpawn;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float probability;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float currentDelaySpawn;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public float currentSpawnGap;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float nextSpawnGap;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x72B6A0", Offset = "0x72B6A0", VA = "0x72B6A0")]
	public Spawnee()
	{
	}
}
[Token(Token = "0x2000021")]
public class FlyingSpawner : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <Spawn>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlyingSpawner <>4__this;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <nextGap>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x72BD64", Offset = "0x72BD64", VA = "0x72BD64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x72BDAC", Offset = "0x72BDAC", VA = "0x72BDAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x72B84C", Offset = "0x72B84C", VA = "0x72B84C")]
		[DebuggerHidden]
		public <Spawn>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x72B920", Offset = "0x72B920", VA = "0x72B920", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x72B924", Offset = "0x72B924", VA = "0x72B924", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x72BD6C", Offset = "0x72BD6C", VA = "0x72BD6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <LightChange>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlyingSpawner <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x72BF4C", Offset = "0x72BF4C", VA = "0x72BF4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x72BF94", Offset = "0x72BF94", VA = "0x72BF94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x72B8E8", Offset = "0x72B8E8", VA = "0x72B8E8")]
		[DebuggerHidden]
		public <LightChange>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x72BDB4", Offset = "0x72BDB4", VA = "0x72BDB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x72BDB8", Offset = "0x72BDB8", VA = "0x72BDB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x72BF54", Offset = "0x72BF54", VA = "0x72BF54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform player;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxNumSpawned;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve speedProgression;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startSpawnGap;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float endSpawnGap;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float spawnGapDecay;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SunCycle sunCycle;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Spawnee[] spawnees;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float sumProbabilities;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float startTime;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x72B6A8", Offset = "0x72B6A8", VA = "0x72B6A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x72B79C", Offset = "0x72B79C", VA = "0x72B79C")]
	private float GetSpeedModifier()
	{
		return default(float);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x72B6C0", Offset = "0x72B6C0", VA = "0x72B6C0")]
	private void TallyProbabilities()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x72B718", Offset = "0x72B718", VA = "0x72B718")]
	public void ResetState()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x72B7D8", Offset = "0x72B7D8", VA = "0x72B7D8")]
	[IteratorStateMachine(typeof(<Spawn>d__14))]
	private IEnumerator Spawn()
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x72B874", Offset = "0x72B874", VA = "0x72B874")]
	[IteratorStateMachine(typeof(<LightChange>d__15))]
	private IEnumerator LightChange()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x72B910", Offset = "0x72B910", VA = "0x72B910")]
	public FlyingSpawner()
	{
	}
}
[Token(Token = "0x2000024")]
[RequireComponent(typeof(AudioSource))]
public class PodBehaviour : FlyingBehaviour
{
	[Token(Token = "0x2000025")]
	public delegate void PodAvoidedAction();

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] webDestructionSounds;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource audioSource;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool avoided;

	[Token(Token = "0x14000007")]
	public static event PodAvoidedAction RegisterPodAvoided
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x72BF9C", Offset = "0x72BF9C", VA = "0x72BF9C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x72C054", Offset = "0x72C054", VA = "0x72C054")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x72C10C", Offset = "0x72C10C", VA = "0x72C10C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x72C164", Offset = "0x72C164", VA = "0x72C164", Slot = "4")]
	public override void Initialize(Transform trgt, Transform plyr)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x72C168", Offset = "0x72C168", VA = "0x72C168", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x72C1F8", Offset = "0x72C1F8", VA = "0x72C1F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x72C360", Offset = "0x72C360", VA = "0x72C360")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x72C4BC", Offset = "0x72C4BC", VA = "0x72C4BC")]
	public PodBehaviour()
	{
	}
}
[Token(Token = "0x2000026")]
public class PodRotation : MonoBehaviour
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotationVelocity;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rotationVariability;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rotationPhaseStd;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float progress;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x72C5D8", Offset = "0x72C5D8", VA = "0x72C5D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x72C6A8", Offset = "0x72C6A8", VA = "0x72C6A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x72C7B0", Offset = "0x72C7B0", VA = "0x72C7B0")]
	public PodRotation()
	{
	}
}
[Token(Token = "0x2000027")]
public enum Shape
{
	[Token(Token = "0x400009F")]
	CUBE,
	[Token(Token = "0x40000A0")]
	SPHERE
}
[Token(Token = "0x2000028")]
public class Gizmo : MonoBehaviour
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shape shape;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color colorSelected;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x72C7CC", Offset = "0x72C7CC", VA = "0x72C7CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x72C7D0", Offset = "0x72C7D0", VA = "0x72C7D0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x72C998", Offset = "0x72C998", VA = "0x72C998")]
	public Gizmo()
	{
	}
}
[Serializable]
[Token(Token = "0x2000029")]
public class Highscore
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string date;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string icon;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int score;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x72C9AC", Offset = "0x72C9AC", VA = "0x72C9AC")]
	public Highscore(int newScore, string icon)
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class Highscores
{
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Highscore?[] highscores;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x72CA78", Offset = "0x72CA78", VA = "0x72CA78")]
	private void SortHighscores()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x723B1C", Offset = "0x723B1C", VA = "0x723B1C")]
	public Highscore AddHighscore(int newScore, string icon)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7241C8", Offset = "0x7241C8", VA = "0x7241C8")]
	public void UpdateHighscore(Highscore highscore, string icon)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x723C10", Offset = "0x723C10", VA = "0x723C10")]
	public string ToString(Highscore? latestHighscore)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x72CB7C", Offset = "0x72CB7C", VA = "0x72CB7C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7240EC", Offset = "0x7240EC", VA = "0x7240EC")]
	public Highscores()
	{
	}
}
[Token(Token = "0x200002C")]
public class HighscoreIconDrawer : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public delegate void IconChangedAction(string newIcon);

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[ContextMenuItem("Repopulate Grid", "RepopulateGrid")]
	public GameObject flyPrefab;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int columns;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int rows;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float xSpace;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float ySpace;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] flies;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string fullIcon;

	[Token(Token = "0x14000008")]
	public static event IconChangedAction IconChanged
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x723464", Offset = "0x723464", VA = "0x723464")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x723698", Offset = "0x723698", VA = "0x723698")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x72CC60", Offset = "0x72CC60", VA = "0x72CC60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x72CCDC", Offset = "0x72CCDC", VA = "0x72CCDC")]
	private void PopulateGrid()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x72D24C", Offset = "0x72D24C", VA = "0x72D24C")]
	[ContextMenu("Repopulate Grid")]
	private void RepopulateGrid()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x72D334", Offset = "0x72D334", VA = "0x72D334")]
	public bool CheckCleared()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x72D50C", Offset = "0x72D50C", VA = "0x72D50C")]
	public string GetIcon()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x72D040", Offset = "0x72D040", VA = "0x72D040")]
	private string GetFullIcon()
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x72D810", Offset = "0x72D810", VA = "0x72D810")]
	public void RemovedFlyDot(int x, int y)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x72D8B0", Offset = "0x72D8B0", VA = "0x72D8B0")]
	public HighscoreIconDrawer()
	{
	}
}
[Token(Token = "0x200002E")]
public class HighscoreReseter : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	public delegate void HighscoreResetAction();

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject redFly;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject greenFly;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool confirmation;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject reset;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject confirm;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject abort;

	[Token(Token = "0x14000009")]
	public static event HighscoreResetAction RegisterHighscoreReset
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7232C8", Offset = "0x7232C8", VA = "0x7232C8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7235E0", Offset = "0x7235E0", VA = "0x7235E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x72D8F8", Offset = "0x72D8F8", VA = "0x72D8F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x72D8FC", Offset = "0x72D8FC", VA = "0x72D8FC")]
	private void ShowPrompt()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x72DBA0", Offset = "0x72DBA0", VA = "0x72DBA0")]
	private void ShowConfirmation()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x72DFE8", Offset = "0x72DFE8", VA = "0x72DFE8")]
	private void HighscoreReset(int x, int y)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x72E12C", Offset = "0x72E12C", VA = "0x72E12C")]
	public HighscoreReseter()
	{
	}
}
[Token(Token = "0x2000030")]
public static class HighscoreStorage
{
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x7239B8", Offset = "0x7239B8", VA = "0x7239B8")]
	public static void SaveHighscores(Highscores highscores)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7237F8", Offset = "0x7237F8", VA = "0x7237F8")]
	public static Highscores LoadHighscores()
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
public class KeepHeadHeight : MonoBehaviour
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool trackHead;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minBottomGap;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxBottomGap;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x72E174", Offset = "0x72E174", VA = "0x72E174")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x72E178", Offset = "0x72E178", VA = "0x72E178")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x72E2B8", Offset = "0x72E2B8", VA = "0x72E2B8")]
	public KeepHeadHeight()
	{
	}
}
[Token(Token = "0x2000032")]
public static class ScoreKeep
{
	[Token(Token = "0x2000033")]
	private sealed class Destructor
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x72EAC8", Offset = "0x72EAC8", VA = "0x72EAC8", Slot = "1")]
		~Destructor()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x72E3F4", Offset = "0x72E3F4", VA = "0x72E3F4")]
		public Destructor()
		{
		}
	}

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int HANGER_ZERO;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int HANGER_LOW;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int HANGER_MED;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int HANGER_HIGH;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static StateManager stateManager;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int score;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int hanger;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static bool isGameOver;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly Destructor Finalise;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x72E2C0", Offset = "0x72E2C0", VA = "0x72E2C0")]
	static ScoreKeep()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x72E3FC", Offset = "0x72E3FC", VA = "0x72E3FC")]
	private static StateManager GetStateManager()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x72E51C", Offset = "0x72E51C", VA = "0x72E51C")]
	private static void FinishGame()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x72E5DC", Offset = "0x72E5DC", VA = "0x72E5DC")]
	public static bool IsGameOver()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x72E634", Offset = "0x72E634", VA = "0x72E634")]
	public static void ResetGame()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x72E778", Offset = "0x72E778", VA = "0x72E778")]
	public static void RegisterHandsDetected()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x72E82C", Offset = "0x72E82C", VA = "0x72E82C")]
	public static void RegisterStartingGame(float progress)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x72E90C", Offset = "0x72E90C", VA = "0x72E90C")]
	private static void RegisterFlyEaten()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x72EA00", Offset = "0x72EA00", VA = "0x72EA00")]
	private static void RegisterFlyEscape()
	{
	}
}
[Token(Token = "0x2000034")]
internal enum MenuVisibilityState
{
	[Token(Token = "0x40000C7")]
	SetupScreen,
	[Token(Token = "0x40000C8")]
	MainMenu,
	[Token(Token = "0x40000C9")]
	InGame
}
[Token(Token = "0x2000035")]
internal enum HandPose
{
	[Token(Token = "0x40000CB")]
	Open,
	[Token(Token = "0x40000CC")]
	Closed,
	[Token(Token = "0x40000CD")]
	Alternating
}
[Token(Token = "0x2000036")]
[RequireComponent(typeof(StatsKeep))]
[RequireComponent(typeof(FlyingSpawner))]
public class StateManager : MonoBehaviour
{
	[Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class <HandleStats>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StateManager <>4__this;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool hadHighscore;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x72F6A8", Offset = "0x72F6A8", VA = "0x72F6A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x72F6F0", Offset = "0x72F6F0", VA = "0x72F6F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x72F400", Offset = "0x72F400", VA = "0x72F400")]
		[DebuggerHidden]
		public <HandleStats>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x72F59C", Offset = "0x72F59C", VA = "0x72F59C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x72F5A0", Offset = "0x72F5A0", VA = "0x72F5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x72F6B0", Offset = "0x72F6B0", VA = "0x72F6B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class <HandleHighscores>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StateManager <>4__this;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int lastScore;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x72F910", Offset = "0x72F910", VA = "0x72F910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x72F958", Offset = "0x72F958", VA = "0x72F958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x72F4AC", Offset = "0x72F4AC", VA = "0x72F4AC")]
		[DebuggerHidden]
		public <HandleHighscores>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x72F6F8", Offset = "0x72F6F8", VA = "0x72F6F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x72F6FC", Offset = "0x72F6FC", VA = "0x72F6FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x72F918", Offset = "0x72F918", VA = "0x72F918", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI howToPlay;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI lastScore;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI drawAvatar;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator handsAnimator;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Space(20f)]
	public Animator handsOpening;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas handsUI;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Canvas setupUI;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Canvas menuUI;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject flybyeLogo;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject midHelperWebArrow;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject leftHelperWebArrow;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject rightHelperWebArrow;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Space(20f)]
	public HighscoreIconDrawer highscoreIconDrawer;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject highscoreIcon;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject highscoreReset;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject statsToggle;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Space(20f)]
	public SpiderAnger spiderAnger;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public InstructionsBoards instructionsBoards;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Space(20f)]
	public WatchScore watch;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public HighscoreBoard highscoreBoard;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SunCycle sunCycle;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int freezeHandPoseHash;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int openingHandPoseHash;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private FlyingSpawner flyingSpawner;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private StatsKeep statsKeep;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool pause;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x72EC18", Offset = "0x72EC18", VA = "0x72EC18")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x72F148", Offset = "0x72F148", VA = "0x72F148")]
	private void SetInitialMenuTitle(bool initial)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x72F190", Offset = "0x72F190", VA = "0x72F190")]
	private void SetHelperWebArrows(bool value)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x72F1F4", Offset = "0x72F1F4", VA = "0x72F1F4")]
	private void EnableHelperWebArrows()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x72EEC8", Offset = "0x72EEC8", VA = "0x72EEC8")]
	private void SetMenuVisibility(MenuVisibilityState state)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x72E710", Offset = "0x72E710", VA = "0x72E710")]
	public void HandleResetGame(int resetScore, int resetHanger)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x72F378", Offset = "0x72F378", VA = "0x72F378")]
	[IteratorStateMachine(typeof(<HandleStats>d__32))]
	private IEnumerator HandleStats(bool hadHighscore)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x72F428", Offset = "0x72F428", VA = "0x72F428")]
	[IteratorStateMachine(typeof(<HandleHighscores>d__33))]
	private IEnumerator HandleHighscores(int lastScore)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x72E590", Offset = "0x72E590", VA = "0x72E590")]
	public void HandleFinishGame(int lastScore)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x72E7D0", Offset = "0x72E7D0", VA = "0x72E7D0")]
	public void HandleHandsDetected()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x72E894", Offset = "0x72E894", VA = "0x72E894")]
	public void HandleStartingGame(float progress)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x72E9BC", Offset = "0x72E9BC", VA = "0x72E9BC")]
	public void HandleFlyEaten(int newScore, int newHanger)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x72EAAC", Offset = "0x72EAAC", VA = "0x72EAAC")]
	public void HandleFlyEscape(int newHanger)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x72F4DC", Offset = "0x72F4DC", VA = "0x72F4DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x72F594", Offset = "0x72F594", VA = "0x72F594")]
	public StateManager()
	{
	}
}
[Token(Token = "0x2000039")]
public enum StatNames
{
	[Token(Token = "0x40000F1")]
	NUM_EATEN,
	[Token(Token = "0x40000F2")]
	NUM_STUCK,
	[Token(Token = "0x40000F3")]
	NUM_STUCK_BACKWARDS,
	[Token(Token = "0x40000F4")]
	NUM_STUCK_PARALLEL,
	[Token(Token = "0x40000F5")]
	NUM_STUCK_POINT,
	[Token(Token = "0x40000F6")]
	NUM_STUCK_TO_LINE,
	[Token(Token = "0x40000F7")]
	NUM_SPIDER_CALMS,
	[Token(Token = "0x40000F8")]
	NUM_WEB_REPAIRS,
	[Token(Token = "0x40000F9")]
	NUM_PODS_AVOIDED,
	[Token(Token = "0x40000FA")]
	NUM_BEES_AVOIDED
}
[Token(Token = "0x200003A")]
public class CurrStat
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int stat;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool isNewMax;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x72F960", Offset = "0x72F960", VA = "0x72F960")]
	public CurrStat()
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class CurrStats
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<StatNames, CurrStat> stats;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x724A7C", Offset = "0x724A7C", VA = "0x724A7C")]
	public CurrStats()
	{
	}
}
[Serializable]
[Token(Token = "0x200003C")]
public class MaxStat
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int stat;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string icon;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x72F968", Offset = "0x72F968", VA = "0x72F968")]
	public MaxStat()
	{
	}
}
[Serializable]
[Token(Token = "0x200003D")]
public class MaxStats
{
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<StatNames, MaxStat> maxStats;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x725D38", Offset = "0x725D38", VA = "0x725D38")]
	public MaxStats()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x72656C", Offset = "0x72656C", VA = "0x72656C")]
	public bool AccountForCurrStats(CurrStats curr, string icon)
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x726178", Offset = "0x726178", VA = "0x726178")]
	public void UpdateIcon(CurrStats curr, string icon)
	{
	}
}
[Token(Token = "0x200003E")]
public class StatsKeep : MonoBehaviour
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WebController webController;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnchorBuffer anchorBuffer;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CurrStats stats;

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x72F9C0", Offset = "0x72F9C0", VA = "0x72F9C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x72F9C4", Offset = "0x72F9C4", VA = "0x72F9C4")]
	public CurrStats GetStats()
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x72F1FC", Offset = "0x72F1FC", VA = "0x72F1FC")]
	public void ResetStatsKeep()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x72F9CC", Offset = "0x72F9CC", VA = "0x72F9CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x72FEC8", Offset = "0x72FEC8", VA = "0x72FEC8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x73022C", Offset = "0x73022C", VA = "0x73022C")]
	private void HandleFlyEaten()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x73029C", Offset = "0x73029C", VA = "0x73029C")]
	private void HandleFlyStuck(Vector3 position, Vector3 forward)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x730790", Offset = "0x730790", VA = "0x730790")]
	private void HandleWebRepair()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x730800", Offset = "0x730800", VA = "0x730800")]
	private void HandleBeeAvoided()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x730870", Offset = "0x730870", VA = "0x730870")]
	private void HandlePodAvoided()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7308E0", Offset = "0x7308E0", VA = "0x7308E0")]
	private void HandleSpiderCalmed()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x730950", Offset = "0x730950", VA = "0x730950")]
	public StatsKeep()
	{
	}
}
[Token(Token = "0x200003F")]
public static class StatsStorage
{
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x725BA0", Offset = "0x725BA0", VA = "0x725BA0")]
	public static void SaveStats(MaxStats stats)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x724E8C", Offset = "0x724E8C", VA = "0x724E8C")]
	public static MaxStats LoadStats()
	{
		return null;
	}
}
[Token(Token = "0x2000040")]
public class StatsToggler : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	public delegate void StatsToggleAction();

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject greenFly;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject toggle;

	[Token(Token = "0x1400000A")]
	public static event StatsToggleAction RegisterStatsToggle
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x7245FC", Offset = "0x7245FC", VA = "0x7245FC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x72472C", Offset = "0x72472C", VA = "0x72472C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x730958", Offset = "0x730958", VA = "0x730958")]
	private void Start()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x73095C", Offset = "0x73095C", VA = "0x73095C")]
	private void ShowPrompt()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x730BD0", Offset = "0x730BD0", VA = "0x730BD0")]
	private void StatsToggle(int x, int y)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x730C54", Offset = "0x730C54", VA = "0x730C54")]
	public StatsToggler()
	{
	}
}
[Token(Token = "0x2000042")]
public class HandControl : MonoBehaviour
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator leftAnimator;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator rightAnimator;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject leftHand;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject rightHand;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int triggerHash;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool rControllerDetected;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool lControllerDetected;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x730C9C", Offset = "0x730C9C", VA = "0x730C9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x730CEC", Offset = "0x730CEC", VA = "0x730CEC")]
	public bool GetRControllerDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x730CF4", Offset = "0x730CF4", VA = "0x730CF4")]
	public bool GetLControllerDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x730CFC", Offset = "0x730CFC", VA = "0x730CFC")]
	private InputDevice? GetController(InputDeviceCharacteristics side)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x730E10", Offset = "0x730E10", VA = "0x730E10")]
	private void UpdateHandAnimation(Animator animator, InputDevice targetDevice)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x730EC4", Offset = "0x730EC4", VA = "0x730EC4")]
	private void Update()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x730FF0", Offset = "0x730FF0", VA = "0x730FF0")]
	public HandControl()
	{
	}
}
[Token(Token = "0x2000043")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class OptimalExperience : MonoBehaviour
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x730FF8", Offset = "0x730FF8", VA = "0x730FF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x731050", Offset = "0x731050", VA = "0x731050")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x731254", Offset = "0x731254", VA = "0x731254")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x731384", Offset = "0x731384", VA = "0x731384")]
	private void RegisterControllersDetected(bool controllers)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x731400", Offset = "0x731400", VA = "0x731400")]
	public OptimalExperience()
	{
	}
}
[Token(Token = "0x2000044")]
public enum Placement
{
	[Token(Token = "0x4000111")]
	Bottom,
	[Token(Token = "0x4000112")]
	Middle,
	[Token(Token = "0x4000113")]
	Left,
	[Token(Token = "0x4000114")]
	Right
}
[Token(Token = "0x2000045")]
public class InWebPositioner : MonoBehaviour
{
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Placement placement;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnchorBuffer anchorBuffer;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 initialScale;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x731408", Offset = "0x731408", VA = "0x731408")]
	private void Start()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x731438", Offset = "0x731438", VA = "0x731438")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x732174", Offset = "0x732174", VA = "0x732174")]
	public InWebPositioner()
	{
	}
}
[Token(Token = "0x2000046")]
public enum HangerDelta
{
	[Token(Token = "0x4000119")]
	Reset,
	[Token(Token = "0x400011A")]
	Increase,
	[Token(Token = "0x400011B")]
	Decrease,
	[Token(Token = "0x400011C")]
	GameOver
}
[Token(Token = "0x2000047")]
[RequireComponent(typeof(AudioSource))]
public class SpiderAnger : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	public delegate void SpiderCalmedAction();

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator flies;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator tongue;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int stretch;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int rollOut;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform root;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SkinnedMeshRenderer skinned;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image fly1;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image fly2;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image fly3;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(20f)]
	public AudioClip[] angerIncreaseSounds;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip[] angerDecreaseSounds;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioClip[] angerResetSounds;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip[] angerGameOverSounds;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource audioSource;

	[Token(Token = "0x1400000B")]
	public static event SpiderCalmedAction RegisterSpiderCalmed
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x72FC8C", Offset = "0x72FC8C", VA = "0x72FC8C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7300BC", Offset = "0x7300BC", VA = "0x7300BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x73217C", Offset = "0x73217C", VA = "0x73217C")]
	private void Start()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x732228", Offset = "0x732228", VA = "0x732228")]
	private bool SetVisual(int newHanger)
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x7324BC", Offset = "0x7324BC", VA = "0x7324BC")]
	private void PlaySound(HangerDelta spiderAngerDelta, bool changed)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x73258C", Offset = "0x73258C", VA = "0x73258C")]
	public void PlayAnimations(HangerDelta hangerDelta, bool changed)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x72F260", Offset = "0x72F260", VA = "0x72F260")]
	public void Emote(int newHanger, HangerDelta hangerDelta)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x72F4D4", Offset = "0x72F4D4", VA = "0x72F4D4")]
	public void Emote(HangerDelta hangerDelta)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7326AC", Offset = "0x7326AC", VA = "0x7326AC")]
	public SpiderAnger()
	{
	}
}
[Token(Token = "0x2000049")]
public class SpiderBlink : MonoBehaviour
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float phaseShift;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float blinkSpeed;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int cycleDrop;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float progression;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x7326F4", Offset = "0x7326F4", VA = "0x7326F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x732708", Offset = "0x732708", VA = "0x732708")]
	private void Update()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x7327A0", Offset = "0x7327A0", VA = "0x7327A0")]
	public SpiderBlink()
	{
	}
}
[Token(Token = "0x200004A")]
public class SpiderGaze : MonoBehaviour
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform mainCamera;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float moveScale;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 changeSpeed;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 progression;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 initialPos;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7327A8", Offset = "0x7327A8", VA = "0x7327A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7327D8", Offset = "0x7327D8", VA = "0x7327D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x732980", Offset = "0x732980", VA = "0x732980")]
	public SpiderGaze()
	{
	}
}
[Token(Token = "0x200004B")]
public class UIScaleCycle : MonoBehaviour
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float cycleShift;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float cycleSpeed;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float progression;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float scaleX;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float scaleY;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7329E0", Offset = "0x7329E0", VA = "0x7329E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x732A30", Offset = "0x732A30", VA = "0x732A30")]
	private void Update()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x732AD8", Offset = "0x732AD8", VA = "0x732AD8")]
	public UIScaleCycle()
	{
	}
}
[Token(Token = "0x200004C")]
public class TeleportBack : MonoBehaviour
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform eyes;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sqrThreshhold;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x732AE0", Offset = "0x732AE0", VA = "0x732AE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x732AE4", Offset = "0x732AE4", VA = "0x732AE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x732C28", Offset = "0x732C28", VA = "0x732C28")]
	public TeleportBack()
	{
	}
}
[Token(Token = "0x200004D")]
[RequireComponent(typeof(Text))]
public class WatchScore : MonoBehaviour
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text text;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x732C30", Offset = "0x732C30", VA = "0x732C30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x72F31C", Offset = "0x72F31C", VA = "0x72F31C")]
	public void SetWatchScore(int newScore)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x732C88", Offset = "0x732C88", VA = "0x732C88")]
	public WatchScore()
	{
	}
}
[Token(Token = "0x200004E")]
[RequireComponent(typeof(HandControl))]
public class AnchorBuffer : MonoBehaviour
{
	[Token(Token = "0x200004F")]
	public delegate void ControllersDetectedAction(bool value);

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRMeshRenderer leftHand;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRMeshRenderer rightHand;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject web;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject watch;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform leftIndexFingerAnchor;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rightIndexFingerAnchor;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform leftThumbAnchor;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform rightThumbAnchor;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform leftIndexControlAnchor;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform rightIndexControlAnchor;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform leftThumbControlAnchor;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform rightThumbControlAnchor;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform midpointAnchor;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform upperLeftWebAnchor;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform upperRightWebAnchor;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform lowerLeftWebAnchor;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform lowerRightWebAnchor;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float distanceYToHold;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float distanceXToHold;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool handsDetectedFirstTime;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool wasRight;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	private bool wasBoth;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
	private bool wasControllers;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool fingersTogether;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private WebController webController;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 webCrossProduct;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private HandControl handControl;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 origWatchPos;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 origWatchRot;

	[Token(Token = "0x1400000C")]
	public static event ControllersDetectedAction RegisterControllersDetected
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x73119C", Offset = "0x73119C", VA = "0x73119C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x7312CC", Offset = "0x7312CC", VA = "0x7312CC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x732C90", Offset = "0x732C90", VA = "0x732C90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x731550", Offset = "0x731550", VA = "0x731550")]
	public Tuple<Vector3, Quaternion, float> GetBottomPositionRotationScale()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x73181C", Offset = "0x73181C", VA = "0x73181C")]
	public Tuple<Vector3, Quaternion, float> GetMiddlePositionRotationScale()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x731B64", Offset = "0x731B64", VA = "0x731B64")]
	public Tuple<Vector3, Quaternion, float> GetLeftPositionRotationScale()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x731E6C", Offset = "0x731E6C", VA = "0x731E6C")]
	public Tuple<Vector3, Quaternion, float> GetRightPositionRotationScale()
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x732D70", Offset = "0x732D70", VA = "0x732D70")]
	public Vector3 GetWebCrossProduct()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x732D7C", Offset = "0x732D7C", VA = "0x732D7C")]
	public bool FingersTogether()
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x732D84", Offset = "0x732D84", VA = "0x732D84")]
	private void SetContinouousSpeculative()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x732DA8", Offset = "0x732DA8", VA = "0x732DA8")]
	private bool HandleControllerSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x7331A0", Offset = "0x7331A0", VA = "0x7331A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x733728", Offset = "0x733728", VA = "0x733728")]
	public AnchorBuffer()
	{
	}
}
[Token(Token = "0x2000050")]
[RequireComponent(typeof(AudioSource))]
public class FeedingSounds : MonoBehaviour
{
	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] feedingSounds;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x733840", Offset = "0x733840", VA = "0x733840")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x7338F8", Offset = "0x7338F8", VA = "0x7338F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x7339B0", Offset = "0x7339B0", VA = "0x7339B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x733A08", Offset = "0x733A08", VA = "0x733A08")]
	public void Emit()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x733A94", Offset = "0x733A94", VA = "0x733A94")]
	public FeedingSounds()
	{
	}
}
[Token(Token = "0x2000051")]
[RequireComponent(typeof(WebController))]
public class WebActions : MonoBehaviour
{
	[Token(Token = "0x2000052")]
	public delegate void WebRepairAction();

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnchorBuffer anchorBuffer;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeToRepair;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeToRestart;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timeRepairing;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timeRestarting;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private WebController webController;

	[Token(Token = "0x1400000D")]
	public static event WebRepairAction RegisterWebRepair
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x72FE10", Offset = "0x72FE10", VA = "0x72FE10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x730174", Offset = "0x730174", VA = "0x730174")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x733A9C", Offset = "0x733A9C", VA = "0x733A9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x733AF4", Offset = "0x733AF4", VA = "0x733AF4")]
	private void NotifyFliesAboutBeingEaten()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x733BF8", Offset = "0x733BF8", VA = "0x733BF8")]
	private void TriggerActions()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x7341F0", Offset = "0x7341F0", VA = "0x7341F0")]
	public void ResetGame()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x73423C", Offset = "0x73423C", VA = "0x73423C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x734240", Offset = "0x734240", VA = "0x734240")]
	public WebActions()
	{
	}
}
[Token(Token = "0x2000053")]
[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class WebCollider : MonoBehaviour
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radiusModifier;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float scaleCorrection;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool isTopLine;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CapsuleCollider capsuleCollider;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody rigbdy;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem brokenWebParticles;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AnchorBuffer anchorBuffer;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x734294", Offset = "0x734294", VA = "0x734294")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x734338", Offset = "0x734338", VA = "0x734338")]
	public void Initialize(AnchorBuffer ab, ParticleSystem sys)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x7344D0", Offset = "0x7344D0", VA = "0x7344D0")]
	private void UpdateRigidbody()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x7346B8", Offset = "0x7346B8", VA = "0x7346B8")]
	public void Update()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x7346BC", Offset = "0x7346BC", VA = "0x7346BC")]
	public WebCollider()
	{
	}
}
[Token(Token = "0x2000054")]
public class WebController : MonoBehaviour
{
	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnchorBuffer anchorBuffer;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject webLine;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem brokenWebParticleSystem;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform midpointAnchor;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform upperLeftWebAnchor;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform upperRightWebAnchor;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform lowerLeftWebAnchor;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform lowerRightWebAnchor;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public OVRMeshRenderer leftHand;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public OVRMeshRenderer rightHaand;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Space(20f)]
	[Range(0f, 1f)]
	public float webSpacingPower;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Range(1f, 15f)]
	public int radialDensity;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Range(1f, 15f)]
	public int spiralDensity;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int radialNum;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int spiralNum;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int lastRadialExcludeFingers;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int spiralNumExcludeThumbs;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject[,] radialLines;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject[,] spiralLines;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float[] cachedAnglesForRadial;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float[] cachedPowerInterpolations;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x7346D0", Offset = "0x7346D0", VA = "0x7346D0")]
	private void InitNumsAndLineArrays()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x7347A8", Offset = "0x7347A8", VA = "0x7347A8")]
	private void PrecomputeAnglesForRadial()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x73489C", Offset = "0x73489C", VA = "0x73489C")]
	private void PrecomputePowerInterpolations()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x73495C", Offset = "0x73495C", VA = "0x73495C")]
	private bool ChangedDensities()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x733DE8", Offset = "0x733DE8", VA = "0x733DE8")]
	public bool PopulateLineArrays()
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x732F64", Offset = "0x732F64", VA = "0x732F64")]
	public void SetCollisionDetectionMode(CollisionDetectionMode mode)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x732DA0", Offset = "0x732DA0", VA = "0x732DA0")]
	public void SetContinouousSpeculative()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x734994", Offset = "0x734994", VA = "0x734994")]
	public void DestroyAllWeblines()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x734B40", Offset = "0x734B40", VA = "0x734B40")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x734B44", Offset = "0x734B44", VA = "0x734B44")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x734B5C", Offset = "0x734B5C", VA = "0x734B5C")]
	private Vector3 PowerInterpolate(Vector3 start, Vector3 end, int numerator)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x734BB0", Offset = "0x734BB0", VA = "0x734BB0")]
	private void UpdateWebLinePosition(ref GameObject webLine, Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x734CCC", Offset = "0x734CCC", VA = "0x734CCC")]
	private void UpdateIndexFingerLines()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x734EA0", Offset = "0x734EA0", VA = "0x734EA0")]
	private void UpdateRegularRadialLines()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x7353C8", Offset = "0x7353C8", VA = "0x7353C8")]
	private void UpdateRadialLines()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x734AA0", Offset = "0x734AA0", VA = "0x734AA0")]
	private void RemoveWebLine(ref GameObject webLine)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x7353E0", Offset = "0x7353E0", VA = "0x7353E0")]
	private void UpdateSpiralLines()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x7358B4", Offset = "0x7358B4", VA = "0x7358B4")]
	private void UpdateLines()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x7305A8", Offset = "0x7305A8", VA = "0x7305A8")]
	public bool IsLine()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x7358D4", Offset = "0x7358D4", VA = "0x7358D4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x7358D8", Offset = "0x7358D8", VA = "0x7358D8")]
	public WebController()
	{
	}
}
[Token(Token = "0x2000055")]
[RequireComponent(typeof(AudioSource))]
public class WebFixSounds : MonoBehaviour
{
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] fixingSounds;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x7358E0", Offset = "0x7358E0", VA = "0x7358E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x735958", Offset = "0x735958", VA = "0x735958")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x7359D0", Offset = "0x7359D0", VA = "0x7359D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x735A28", Offset = "0x735A28", VA = "0x735A28")]
	public void Emit()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x735AB4", Offset = "0x735AB4", VA = "0x735AB4")]
	public WebFixSounds()
	{
	}
}
[Token(Token = "0x2000056")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x735ABC", Offset = "0x735ABC", VA = "0x735ABC")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x735BFC", Offset = "0x735BFC", VA = "0x735BFC")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x735F2C", Offset = "0x735F2C", VA = "0x735F2C")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x7360C4", Offset = "0x7360C4", VA = "0x7360C4", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x7360F0", Offset = "0x7360F0", VA = "0x7360F0")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000057")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x736158", Offset = "0x736158", VA = "0x736158")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x7361D4", Offset = "0x7361D4", VA = "0x7361D4")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x736344", Offset = "0x736344", VA = "0x736344")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000058")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x17000009")]
	public bool IsVisible
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x73634C", Offset = "0x73634C", VA = "0x73634C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x736354", Offset = "0x736354", VA = "0x736354")]
		set
		{
		}
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x736478", Offset = "0x736478", VA = "0x736478")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x736668", Offset = "0x736668", VA = "0x736668")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x736670", Offset = "0x736670", VA = "0x736670")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000059")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x738350", Offset = "0x738350", VA = "0x738350")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200005B")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMax;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMin;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float LatencyWeight;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int MaxSamples;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x738358", Offset = "0x738358", VA = "0x738358")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x73848C", Offset = "0x73848C", VA = "0x73848C")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x736684", Offset = "0x736684", VA = "0x736684")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x7367DC", Offset = "0x7367DC", VA = "0x7367DC")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x736BDC", Offset = "0x736BDC", VA = "0x736BDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x736B2C", Offset = "0x736B2C", VA = "0x736B2C")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x736F70", Offset = "0x736F70", VA = "0x736F70")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x73728C", Offset = "0x73728C", VA = "0x73728C")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x200005C")]
public class P2PManager
{
	[Token(Token = "0x200005D")]
	private enum MessageType : byte
	{
		[Token(Token = "0x400019A")]
		Update = 1
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x73852C", Offset = "0x73852C", VA = "0x73852C")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x7385F8", Offset = "0x7385F8", VA = "0x7385F8")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x738838", Offset = "0x738838", VA = "0x738838")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x738980", Offset = "0x738980", VA = "0x738980")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x738AD0", Offset = "0x738AD0", VA = "0x738AD0")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x738CBC", Offset = "0x738CBC", VA = "0x738CBC")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x739074", Offset = "0x739074", VA = "0x739074")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x7392FC", Offset = "0x7392FC", VA = "0x7392FC")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x738E80", Offset = "0x738E80", VA = "0x738E80")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x739248", Offset = "0x739248", VA = "0x739248")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x738F4C", Offset = "0x738F4C", VA = "0x738F4C")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x73951C", Offset = "0x73951C", VA = "0x73951C")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x738EBC", Offset = "0x738EBC", VA = "0x738EBC")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x739280", Offset = "0x739280", VA = "0x739280")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x738FE4", Offset = "0x738FE4", VA = "0x738FE4")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x739598", Offset = "0x739598", VA = "0x739598")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x200005E")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x7397EC", Offset = "0x7397EC", VA = "0x7397EC", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x739BD8", Offset = "0x739BD8", VA = "0x739BD8", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x739BFC", Offset = "0x739BFC", VA = "0x739BFC", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x739FAC", Offset = "0x739FAC", VA = "0x739FAC")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x73A10C", Offset = "0x73A10C", VA = "0x73A10C")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x73A188", Offset = "0x73A188", VA = "0x73A188")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x73A274", Offset = "0x73A274", VA = "0x73A274")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x200005F")]
public class RemotePlayer
{
	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x73A358", Offset = "0x73A358", VA = "0x73A358")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000060")]
public class RoomManager
{
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x73A360", Offset = "0x73A360", VA = "0x73A360")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x73A444", Offset = "0x73A444", VA = "0x73A444")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x73A644", Offset = "0x73A644", VA = "0x73A644")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x73A75C", Offset = "0x73A75C", VA = "0x73A75C")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x73A814", Offset = "0x73A814", VA = "0x73A814")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x73AC00", Offset = "0x73AC00", VA = "0x73AC00")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x73A670", Offset = "0x73A670", VA = "0x73A670")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x73AC78", Offset = "0x73AC78", VA = "0x73AC78")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x73B3F4", Offset = "0x73B3F4", VA = "0x73B3F4")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x73B734", Offset = "0x73B734", VA = "0x73B734")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x73AFA4", Offset = "0x73AFA4", VA = "0x73AFA4")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000061")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000062")]
	public enum State
	{
		[Token(Token = "0x40001D2")]
		INITIALIZING,
		[Token(Token = "0x40001D3")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x40001D4")]
		CREATING_A_ROOM,
		[Token(Token = "0x40001D5")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x40001D6")]
		JOINING_A_ROOM,
		[Token(Token = "0x40001D7")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x40001D8")]
		LEAVING_A_ROOM,
		[Token(Token = "0x40001D9")]
		SHUTDOWN
	}

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700000A")]
	public static State CurrentState
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x73D4F4", Offset = "0x73D4F4", VA = "0x73D4F4")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700000B")]
	public static ulong MyID
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7386C0", Offset = "0x7386C0", VA = "0x7386C0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000C")]
	public static string MyOculusID
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x73D558", Offset = "0x73D558", VA = "0x73D558")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x739C14", Offset = "0x739C14", VA = "0x739C14", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x739820", Offset = "0x739820", VA = "0x739820", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x73C1DC", Offset = "0x73C1DC", VA = "0x73C1DC")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x739BF8", Offset = "0x739BF8", VA = "0x739BF8", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x73C364", Offset = "0x73C364", VA = "0x73C364")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x73C45C", Offset = "0x73C45C", VA = "0x73C45C")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x73CC44", Offset = "0x73CC44", VA = "0x73CC44")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x73D05C", Offset = "0x73D05C", VA = "0x73D05C")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x73D280", Offset = "0x73D280", VA = "0x73D280")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x73D48C", Offset = "0x73D48C", VA = "0x73D48C")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x73C068", Offset = "0x73C068", VA = "0x73C068")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x73A598", Offset = "0x73A598", VA = "0x73A598")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x73A900", Offset = "0x73A900", VA = "0x73A900")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x73D65C", Offset = "0x73D65C", VA = "0x73D65C")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x73AB40", Offset = "0x73AB40", VA = "0x73AB40")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x73B79C", Offset = "0x73B79C", VA = "0x73B79C")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x73BB94", Offset = "0x73BB94", VA = "0x73BB94")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x73BC74", Offset = "0x73BC74", VA = "0x73BC74")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x738784", Offset = "0x738784", VA = "0x738784")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x73B920", Offset = "0x73B920", VA = "0x73B920")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x73B9A8", Offset = "0x73B9A8", VA = "0x73B9A8")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x73D7E0", Offset = "0x73D7E0", VA = "0x73D7E0")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x73DAA4", Offset = "0x73DAA4", VA = "0x73DAA4")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x73BFF0", Offset = "0x73BFF0", VA = "0x73BFF0")]
	[MonoPInvokeCallback(typeof(CAPI.FilterCallback))]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x7388A8", Offset = "0x7388A8", VA = "0x7388A8")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x73A2D0", Offset = "0x73A2D0", VA = "0x73A2D0")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000063")]
public class VoipManager
{
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x73C110", Offset = "0x73C110", VA = "0x73C110")]
	public VoipManager()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x73D9DC", Offset = "0x73D9DC", VA = "0x73D9DC")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x73D41C", Offset = "0x73D41C", VA = "0x73D41C")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x73DDE0", Offset = "0x73DDE0", VA = "0x73DDE0")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x73DF30", Offset = "0x73DF30", VA = "0x73DF30")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x2000064")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x73E11C", Offset = "0x73E11C", VA = "0x73E11C")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x73E1A0", Offset = "0x73E1A0", VA = "0x73E1A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x73E2E4", Offset = "0x73E2E4", VA = "0x73E2E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x73E338", Offset = "0x73E338", VA = "0x73E338")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x73E1D0", Offset = "0x73E1D0", VA = "0x73E1D0")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x73E3E8", Offset = "0x73E3E8", VA = "0x73E3E8")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x73E400", Offset = "0x73E400", VA = "0x73E400")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000065")]
public class AvatarLayer
{
	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x73E408", Offset = "0x73E408", VA = "0x73E408")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000066")]
public class PacketRecordSettings
{
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x73E410", Offset = "0x73E410", VA = "0x73E410")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000067")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x741F20", Offset = "0x741F20", VA = "0x741F20")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x2000069")]
	public enum HandType
	{
		[Token(Token = "0x400023B")]
		Right,
		[Token(Token = "0x400023C")]
		Left,
		[Token(Token = "0x400023D")]
		Max
	}

	[Token(Token = "0x200006A")]
	public enum HandJoint
	{
		[Token(Token = "0x400023F")]
		HandBase,
		[Token(Token = "0x4000240")]
		IndexBase,
		[Token(Token = "0x4000241")]
		IndexTip,
		[Token(Token = "0x4000242")]
		ThumbBase,
		[Token(Token = "0x4000243")]
		ThumbTip,
		[Token(Token = "0x4000244")]
		Max
	}

	[Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x7441B0", Offset = "0x7441B0", VA = "0x7441B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x7441F8", Offset = "0x7441F8", VA = "0x7441F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x743C6C", Offset = "0x743C6C", VA = "0x743C6C")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x744008", Offset = "0x744008", VA = "0x744008", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x74400C", Offset = "0x74400C", VA = "0x74400C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7441B8", Offset = "0x7441B8", VA = "0x7441B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Avatar")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Capabilities")]
	public bool EnableBody;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("Network")]
	public bool RecordPackets;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Visibility")]
	public bool StartWithControllers;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("LOD mesh complexity and texture resolution. Highest LOD recommended on PC and simple mobile apps. Medium LOD recommended on mobile devices or for background characters on PC. Lowest LOD recommended for background characters on mobile.")]
	[Header("Performance")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Tooltip("Enable to use combined meshes to reduce draw calls. Currently only available on mobile devices. Will be forced to false on PC.")]
	private bool CombineMeshes;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[Tooltip("Enable to use transparent queue, disable to use geometry queue. Requires restart to take effect.")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Shaders")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("Other")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[Tooltip("Enable laughter detection and animation as part of OVRLipSync.")]
	public bool EnableLaughter;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x400021B")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x400021D")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x400021E")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x400021F")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x4000220")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x4000221")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x73E424", Offset = "0x73E424", VA = "0x73E424")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x73E8B8", Offset = "0x73E8B8", VA = "0x73E8B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x73E950", Offset = "0x73E950", VA = "0x73E950")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x73E9AC", Offset = "0x73E9AC", VA = "0x73E9AC")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x73EAC0", Offset = "0x73EAC0", VA = "0x73EAC0")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x73EB9C", Offset = "0x73EB9C", VA = "0x73EB9C")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x73EC6C", Offset = "0x73EC6C", VA = "0x73EC6C")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x73EE3C", Offset = "0x73EE3C", VA = "0x73EE3C")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x73EF04", Offset = "0x73EF04", VA = "0x73EF04")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x73EF78", Offset = "0x73EF78", VA = "0x73EF78")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x73F030", Offset = "0x73F030", VA = "0x73F030")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x73F0B8", Offset = "0x73F0B8", VA = "0x73F0B8")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x73F15C", Offset = "0x73F15C", VA = "0x73F15C")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x73F174", Offset = "0x73F174", VA = "0x73F174")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x6000208")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x73F580", Offset = "0x73F580", VA = "0x73F580")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x73F8AC", Offset = "0x73F8AC", VA = "0x73F8AC")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x73FA84", Offset = "0x73FA84", VA = "0x73FA84")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x73FCC0", Offset = "0x73FCC0", VA = "0x73FCC0")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x73FDF4", Offset = "0x73FDF4", VA = "0x73FDF4")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x740388", Offset = "0x740388", VA = "0x740388")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x7406A8", Offset = "0x7406A8", VA = "0x7406A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x741178", Offset = "0x741178", VA = "0x741178")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7411BC", Offset = "0x7411BC", VA = "0x7411BC")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x73A1CC", Offset = "0x73A1CC", VA = "0x73A1CC")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x740094", Offset = "0x740094", VA = "0x740094")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7411E8", Offset = "0x7411E8", VA = "0x7411E8")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x740A94", Offset = "0x740A94", VA = "0x740A94")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x741470", Offset = "0x741470", VA = "0x741470")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x741298", Offset = "0x741298", VA = "0x741298")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x741F94", Offset = "0x741F94", VA = "0x741F94")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x742418", Offset = "0x742418", VA = "0x742418")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x742830", Offset = "0x742830", VA = "0x742830")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x742968", Offset = "0x742968", VA = "0x742968")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x742B34", Offset = "0x742B34", VA = "0x742B34")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x740C50", Offset = "0x740C50", VA = "0x740C50")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x742BFC", Offset = "0x742BFC", VA = "0x742BFC")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x740AA4", Offset = "0x740AA4", VA = "0x740AA4")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x742CD8", Offset = "0x742CD8", VA = "0x742CD8")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x743308", Offset = "0x743308", VA = "0x743308")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x743790", Offset = "0x743790", VA = "0x743790")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x7437B8", Offset = "0x7437B8", VA = "0x7437B8")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x7437E0", Offset = "0x7437E0", VA = "0x7437E0")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x741020", Offset = "0x741020", VA = "0x741020")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x742D94", Offset = "0x742D94", VA = "0x742D94")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x743BF8", Offset = "0x743BF8", VA = "0x743BF8")]
	[IteratorStateMachine(typeof(<WaitForMouthAudioSource>d__137))]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x743C94", Offset = "0x743C94", VA = "0x743C94")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x743A8C", Offset = "0x743A8C", VA = "0x743A8C")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x73DBD0", Offset = "0x73DBD0", VA = "0x73DBD0")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x743D38", Offset = "0x743D38", VA = "0x743D38")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x74381C", Offset = "0x74381C", VA = "0x74381C")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x743E00", Offset = "0x743E00", VA = "0x743E00")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x200006C")]
public class OvrAvatarAsset
{
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x744200", Offset = "0x744200", VA = "0x744200")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x200006D")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x744208", Offset = "0x744208", VA = "0x744208")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x74539C", Offset = "0x74539C", VA = "0x74539C")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x744FE8", Offset = "0x744FE8", VA = "0x744FE8")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x744D6C", Offset = "0x744D6C", VA = "0x744D6C")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x744E4C", Offset = "0x744E4C", VA = "0x744E4C")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x7455E8", Offset = "0x7455E8", VA = "0x7455E8")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x400024D")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x745B78", Offset = "0x745B78", VA = "0x745B78")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x200006F")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x745DC0", Offset = "0x745DC0", VA = "0x745DC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x7461E8", Offset = "0x7461E8", VA = "0x7461E8")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000070")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x7426E4", Offset = "0x7426E4", VA = "0x7426E4")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x746314", Offset = "0x746314", VA = "0x746314")]
	private void Update()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x746428", Offset = "0x746428", VA = "0x746428")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000071")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x74647C", Offset = "0x74647C", VA = "0x74647C")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x745ED4", Offset = "0x745ED4", VA = "0x745ED4")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x746484", Offset = "0x746484", VA = "0x746484")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x7464D8", Offset = "0x7464D8", VA = "0x7464D8")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x746BE0", Offset = "0x746BE0", VA = "0x746BE0")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x74623C", Offset = "0x74623C", VA = "0x74623C")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000072")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000073")]
	public enum PacketMode
	{
		[Token(Token = "0x4000261")]
		SDK,
		[Token(Token = "0x4000262")]
		Unity
	}

	[Token(Token = "0x2000074")]
	public struct ControllerPose
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x748908", Offset = "0x748908", VA = "0x748908")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000075")]
	public struct PoseFrame
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x741C28", Offset = "0x741C28", VA = "0x741C28")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x748864", Offset = "0x748864", VA = "0x748864")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x600024A")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x748874", Offset = "0x748874", VA = "0x748874")]
	private void Start()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x74013C", Offset = "0x74013C", VA = "0x74013C")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x7488F0", Offset = "0x7488F0", VA = "0x7488F0")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x7488F8", Offset = "0x7488F8", VA = "0x7488F8")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000076")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x748978", Offset = "0x748978", VA = "0x748978")]
	private void Update()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x748AB8", Offset = "0x748AB8", VA = "0x748AB8")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000077")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x748B14", Offset = "0x748B14", VA = "0x748B14")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x748C54", Offset = "0x748C54", VA = "0x748C54")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x748F84", Offset = "0x748F84", VA = "0x748F84")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x7491A0", Offset = "0x7491A0", VA = "0x7491A0", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x7491C8", Offset = "0x7491C8", VA = "0x7491C8")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000078")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	public enum TextureType
	{
		[Token(Token = "0x4000298")]
		DiffuseTextures,
		[Token(Token = "0x4000299")]
		NormalMaps,
		[Token(Token = "0x400029A")]
		RoughnessMaps,
		[Token(Token = "0x400029B")]
		Count
	}

	[Token(Token = "0x200007A")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x200007B")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x200007C")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x200007D")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x74B190", Offset = "0x74B190", VA = "0x74B190")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x74BC50", Offset = "0x74BC50", VA = "0x74BC50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x74BC98", Offset = "0x74BC98", VA = "0x74BC98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x74AF4C", Offset = "0x74AF4C", VA = "0x74AF4C")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x74B5E8", Offset = "0x74B5E8", VA = "0x74B5E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x74B5EC", Offset = "0x74B5EC", VA = "0x74B5EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x74BC58", Offset = "0x74BC58", VA = "0x74BC58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x4000293")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x4000294")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x4000295")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x4000296")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x749268", Offset = "0x749268", VA = "0x749268")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x74943C", Offset = "0x74943C", VA = "0x74943C")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x749478", Offset = "0x749478", VA = "0x749478")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x749BAC", Offset = "0x749BAC", VA = "0x749BAC")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x749C14", Offset = "0x749C14", VA = "0x749C14")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x749518", Offset = "0x749518", VA = "0x749518")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x749C64", Offset = "0x749C64", VA = "0x749C64")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x749964", Offset = "0x749964", VA = "0x749964")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x749D40", Offset = "0x749D40", VA = "0x749D40")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x749FC4", Offset = "0x749FC4", VA = "0x749FC4")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x74A0E8", Offset = "0x74A0E8", VA = "0x74A0E8")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x74A120", Offset = "0x74A120", VA = "0x74A120")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x749B1C", Offset = "0x749B1C", VA = "0x749B1C")]
	[IteratorStateMachine(typeof(<RunLoadingAnimation>d__49))]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x74AF74", Offset = "0x74AF74", VA = "0x74AF74")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x200007F")]
public class OvrAvatarPacket
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000011")]
	public float Duration
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7419B8", Offset = "0x7419B8", VA = "0x7419B8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x741BA0", Offset = "0x741BA0", VA = "0x741BA0")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x739614", Offset = "0x739614", VA = "0x739614")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x741720", Offset = "0x741720", VA = "0x741720")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x74BCA0", Offset = "0x74BCA0", VA = "0x74BCA0")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x741A1C", Offset = "0x741A1C", VA = "0x741A1C")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x74BE2C", Offset = "0x74BE2C", VA = "0x74BE2C")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x74C008", Offset = "0x74C008", VA = "0x74C008")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x74C554", Offset = "0x74C554", VA = "0x74C554")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000080")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x74C778", Offset = "0x74C778", VA = "0x74C778")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x74C880", Offset = "0x74C880", VA = "0x74C880")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x74CA0C", Offset = "0x74CA0C", VA = "0x74CA0C")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x74C8E4", Offset = "0x74C8E4", VA = "0x74C8E4")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x74C96C", Offset = "0x74C96C", VA = "0x74C96C")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000081")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x74C3B8", Offset = "0x74C3B8", VA = "0x74C3B8")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x74CC34", Offset = "0x74CC34", VA = "0x74CC34")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x74CA54", Offset = "0x74CA54", VA = "0x74CA54")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x74CAC0", Offset = "0x74CAC0", VA = "0x74CAC0")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x74CB50", Offset = "0x74CB50", VA = "0x74CB50")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000082")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x40002BD")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x40002BE")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x739768", Offset = "0x739768", VA = "0x739768")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x74CC84", Offset = "0x74CC84", VA = "0x74CC84", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x74CCA0", Offset = "0x74CCA0", VA = "0x74CCA0")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x74CE50", Offset = "0x74CE50", VA = "0x74CE50")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x74D00C", Offset = "0x74D00C", VA = "0x74D00C")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000083")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x74D0C8", Offset = "0x74D0C8", VA = "0x74D0C8")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x74D1A4", Offset = "0x74D1A4", VA = "0x74D1A4")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x74D394", Offset = "0x74D394", VA = "0x74D394")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x74D6D4", Offset = "0x74D6D4", VA = "0x74D6D4")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x74D7D8", Offset = "0x74D7D8", VA = "0x74D7D8")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000084")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x40002C7")]
	Body = 1,
	[Token(Token = "0x40002C8")]
	Hands = 2,
	[Token(Token = "0x40002C9")]
	Base = 4,
	[Token(Token = "0x40002CA")]
	BodyTilt = 0x10,
	[Token(Token = "0x40002CB")]
	Expressive = 0x20,
	[Token(Token = "0x40002CC")]
	All = -1
}
[Token(Token = "0x2000085")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x40002CE")]
	AvatarSpecification,
	[Token(Token = "0x40002CF")]
	AssetLoaded,
	[Token(Token = "0x40002D0")]
	Count
}
[Token(Token = "0x2000086")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000087")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000088")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x40002D6")]
	Mesh,
	[Token(Token = "0x40002D7")]
	Texture,
	[Token(Token = "0x40002D8")]
	Pose,
	[Token(Token = "0x40002D9")]
	Material,
	[Token(Token = "0x40002DA")]
	CombinedMesh,
	[Token(Token = "0x40002DB")]
	PBSMaterial,
	[Token(Token = "0x40002DC")]
	FailedLoad,
	[Token(Token = "0x40002DD")]
	Count
}
[Token(Token = "0x2000089")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x200008A")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x200008B")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x200008C")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200008D")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200008E")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x4000312")]
	RGB24,
	[Token(Token = "0x4000313")]
	DXT1,
	[Token(Token = "0x4000314")]
	DXT5,
	[Token(Token = "0x4000315")]
	ASTC_RGB_6x6,
	[Token(Token = "0x4000316")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x4000317")]
	Count
}
[Token(Token = "0x200008F")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000090")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x400031F")]
	SkinnedMeshRender,
	[Token(Token = "0x4000320")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x4000321")]
	ProjectorRender,
	[Token(Token = "0x4000322")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x4000323")]
	Count
}
[Token(Token = "0x2000091")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x4000325")]
	Unknown,
	[Token(Token = "0x4000326")]
	Default,
	[Token(Token = "0x4000327")]
	Verbose,
	[Token(Token = "0x4000328")]
	Debug,
	[Token(Token = "0x4000329")]
	Info,
	[Token(Token = "0x400032A")]
	Warn,
	[Token(Token = "0x400032B")]
	Error,
	[Token(Token = "0x400032C")]
	Fatal,
	[Token(Token = "0x400032D")]
	Silent
}
[Token(Token = "0x2000092")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000093")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x4000332")]
	One = 1,
	[Token(Token = "0x4000333")]
	Two = 2,
	[Token(Token = "0x4000334")]
	Three = 4,
	[Token(Token = "0x4000335")]
	Joystick = 8
}
[Token(Token = "0x2000094")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x4000337")]
	One = 1,
	[Token(Token = "0x4000338")]
	Two = 2,
	[Token(Token = "0x4000339")]
	Joystick = 4,
	[Token(Token = "0x400033A")]
	ThumbRest = 8,
	[Token(Token = "0x400033B")]
	Index = 0x10,
	[Token(Token = "0x400033C")]
	Pointing = 0x40,
	[Token(Token = "0x400033D")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000095")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000096")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000097")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000098")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000099")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200009A")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x200009B")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200009C")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200009D")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x400035D")]
	Add,
	[Token(Token = "0x400035E")]
	Multiply,
	[Token(Token = "0x400035F")]
	Count
}
[Token(Token = "0x200009E")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x4000361")]
	Color,
	[Token(Token = "0x4000362")]
	Texture,
	[Token(Token = "0x4000363")]
	TextureSingleChannel,
	[Token(Token = "0x4000364")]
	Parallax,
	[Token(Token = "0x4000365")]
	Count
}
[Token(Token = "0x200009F")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x4000367")]
	None,
	[Token(Token = "0x4000368")]
	Positional,
	[Token(Token = "0x4000369")]
	ViewReflection,
	[Token(Token = "0x400036A")]
	Fresnel,
	[Token(Token = "0x400036B")]
	Pulse,
	[Token(Token = "0x400036C")]
	Count
}
[Token(Token = "0x20000A0")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x400036E")]
	Touch,
	[Token(Token = "0x400036F")]
	Malibu,
	[Token(Token = "0x4000370")]
	Go,
	[Token(Token = "0x4000371")]
	Quest,
	[Token(Token = "0x4000372")]
	Count
}
[Token(Token = "0x20000A1")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x4000374")]
	Lowest = 1,
	[Token(Token = "0x4000375")]
	Medium = 3,
	[Token(Token = "0x4000376")]
	Highest = 5
}
[Token(Token = "0x20000A2")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x4000378")]
	Unknown = -1,
	[Token(Token = "0x4000379")]
	One,
	[Token(Token = "0x400037A")]
	Two
}
[Token(Token = "0x20000A3")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x74DBB0", Offset = "0x74DBB0", VA = "0x74DBB0")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x74DBE0", Offset = "0x74DBE0", VA = "0x74DBE0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x74DDF0", Offset = "0x74DDF0", VA = "0x74DDF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000A4")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x74E034", Offset = "0x74E034", VA = "0x74E034")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x74E064", Offset = "0x74E064", VA = "0x74E064", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x74E3F4", Offset = "0x74E3F4", VA = "0x74E3F4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000A5")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x74F79C", Offset = "0x74F79C", VA = "0x74F79C")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x74F7CC", Offset = "0x74F7CC", VA = "0x74F7CC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x74FA14", Offset = "0x74FA14", VA = "0x74FA14", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000A6")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x74FCE8", Offset = "0x74FCE8", VA = "0x74FCE8")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x74FD18", Offset = "0x74FD18", VA = "0x74FD18", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x74FEE0", Offset = "0x74FEE0", VA = "0x74FEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000A7")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x7500F4", Offset = "0x7500F4", VA = "0x7500F4")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x20000A8")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x20000A9")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x40003AF")]
	FirstPerson = 1,
	[Token(Token = "0x40003B0")]
	ThirdPerson = 2,
	[Token(Token = "0x40003B1")]
	SelfOccluding = 4
}
[Token(Token = "0x20000AA")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000AB")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000AC")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x20000AD")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000AE")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x40003C7")]
	Default,
	[Token(Token = "0x40003C8")]
	GripSphere,
	[Token(Token = "0x40003C9")]
	GripCube,
	[Token(Token = "0x40003CA")]
	Count
}
[Token(Token = "0x20000AF")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x40003CC")]
	Body,
	[Token(Token = "0x40003CD")]
	Clothing,
	[Token(Token = "0x40003CE")]
	Eyewear,
	[Token(Token = "0x40003CF")]
	Hair,
	[Token(Token = "0x40003D0")]
	Beard,
	[Token(Token = "0x40003D1")]
	Count
}
[Token(Token = "0x20000B0")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x20000B1")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x20000B2")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x20000B3")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x20000B4")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x40003DB")]
	AvatarHead,
	[Token(Token = "0x40003DC")]
	AvatarHand,
	[Token(Token = "0x40003DD")]
	Object,
	[Token(Token = "0x40003DE")]
	ObjectStatic,
	[Token(Token = "0x40003DF")]
	Count
}
[Token(Token = "0x20000B5")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x20000B6")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x20000B7")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x20000B8")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x20000B9")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x40003EB")]
	Point,
	[Token(Token = "0x40003EC")]
	Direction,
	[Token(Token = "0x40003ED")]
	Spot,
	[Token(Token = "0x40003EE")]
	Count
}
[Token(Token = "0x20000BA")]
public struct ovrAvatarLight
{
	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x20000BB")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x20000BC")]
public struct ovrAvatarLights
{
	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x20000BD")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x20000BE")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x4000404")]
	None = 0u,
	[Token(Token = "0x4000405")]
	GazeTarget = 1u,
	[Token(Token = "0x4000406")]
	Any = uint.MaxValue
}
[Token(Token = "0x20000BF")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x20000C0")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x20000C1")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x20000C2")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x20000C3")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x20000C4")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7524F8", Offset = "0x7524F8", VA = "0x7524F8")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x400041B")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000013")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x750F50", Offset = "0x750F50", VA = "0x750F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x75113C", Offset = "0x75113C", VA = "0x75113C")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x75148C", Offset = "0x75148C", VA = "0x75148C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x7514F0", Offset = "0x7514F0", VA = "0x7514F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x751E90", Offset = "0x751E90", VA = "0x751E90")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x751EE0", Offset = "0x751EE0", VA = "0x751EE0")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x751F30", Offset = "0x751F30", VA = "0x751F30")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x751FD8", Offset = "0x751FD8", VA = "0x751FD8")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x752030", Offset = "0x752030", VA = "0x752030")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x751CB4", Offset = "0x751CB4", VA = "0x751CB4")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x7520F4", Offset = "0x7520F4", VA = "0x7520F4")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x752240", Offset = "0x752240", VA = "0x752240")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x75232C", Offset = "0x75232C", VA = "0x75232C")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x7523A4", Offset = "0x7523A4", VA = "0x7523A4")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x75144C", Offset = "0x75144C", VA = "0x75144C")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x75246C", Offset = "0x75246C", VA = "0x75246C")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x7524E0", Offset = "0x7524E0", VA = "0x7524E0")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x20000C6")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000014")]
	public static string AppID
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x752434", Offset = "0x752434", VA = "0x752434")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x7526A4", Offset = "0x7526A4", VA = "0x7526A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public static string MobileAppID
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x752450", Offset = "0x752450", VA = "0x752450")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x7526C8", Offset = "0x7526C8", VA = "0x7526C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x752560", Offset = "0x752560", VA = "0x752560")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x7526EC", Offset = "0x7526EC", VA = "0x7526EC")]
		set
		{
		}
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x752744", Offset = "0x752744", VA = "0x752744")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x20000C7")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x7527AC", Offset = "0x7527AC", VA = "0x7527AC")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x752A7C", Offset = "0x752A7C", VA = "0x752A7C")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x75292C", Offset = "0x75292C", VA = "0x75292C")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x752C90", Offset = "0x752C90", VA = "0x752C90")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x20000C8")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x752C98", Offset = "0x752C98", VA = "0x752C98")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x752DF4", Offset = "0x752DF4", VA = "0x752DF4")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x752FA8", Offset = "0x752FA8", VA = "0x752FA8")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x20000C9")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x4000432")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x4000433")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x4000434")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x752FB0", Offset = "0x752FB0", VA = "0x752FB0")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x753F98", Offset = "0x753F98", VA = "0x753F98")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x7541A8", Offset = "0x7541A8", VA = "0x7541A8")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x753714", Offset = "0x753714", VA = "0x753714")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x753410", Offset = "0x753410", VA = "0x753410")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x753588", Offset = "0x753588", VA = "0x753588")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x7549CC", Offset = "0x7549CC", VA = "0x7549CC")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x20000CA")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000CB")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x20000CC")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x755324", Offset = "0x755324", VA = "0x755324")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x20000CD")]
	public struct TextureSet
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x755574", Offset = "0x755574", VA = "0x755574")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x755E40", Offset = "0x755E40", VA = "0x755E40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x755E88", Offset = "0x755E88", VA = "0x755E88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x7556DC", Offset = "0x7556DC", VA = "0x7556DC")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x755868", Offset = "0x755868", VA = "0x755868", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x75586C", Offset = "0x75586C", VA = "0x75586C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x755E48", Offset = "0x755E48", VA = "0x755E48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x4000438")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x4000439")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x400043C")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x400043D")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x400043E")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x400043F")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x4000440")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x4000441")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x4000442")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x7549D4", Offset = "0x7549D4", VA = "0x7549D4")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x754F38", Offset = "0x754F38", VA = "0x754F38")]
	public void Update()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x75511C", Offset = "0x75511C", VA = "0x75511C")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x755164", Offset = "0x755164", VA = "0x755164")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x75509C", Offset = "0x75509C", VA = "0x75509C")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x755374", Offset = "0x755374", VA = "0x755374")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x75559C", Offset = "0x75559C", VA = "0x75559C")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x755634", Offset = "0x755634", VA = "0x755634")]
	[IteratorStateMachine(typeof(<DeleteTextureSetCoroutine>d__24))]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x7520B4", Offset = "0x7520B4", VA = "0x7520B4")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x755704", Offset = "0x755704", VA = "0x755704")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x20000CF")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x755E90", Offset = "0x755E90", VA = "0x755E90")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x755FD4", Offset = "0x755FD4", VA = "0x755FD4")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x20000D0")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x20000D1")]
	public delegate void OnClick();

	[Token(Token = "0x20000D2")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x20000D3")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x20000D4")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000454")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000455")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000456")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x756034", Offset = "0x756034", VA = "0x756034")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x7565A0", Offset = "0x7565A0", VA = "0x7565A0")]
	public void Show()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x75691C", Offset = "0x75691C", VA = "0x75691C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x756A98", Offset = "0x756A98", VA = "0x756A98")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x756CB0", Offset = "0x756CB0", VA = "0x756CB0")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x75690C", Offset = "0x75690C", VA = "0x75690C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x756FA4", Offset = "0x756FA4", VA = "0x756FA4")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x757320", Offset = "0x757320", VA = "0x757320")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x7576D0", Offset = "0x7576D0", VA = "0x7576D0")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x7577C8", Offset = "0x7577C8", VA = "0x7577C8")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x757998", Offset = "0x757998", VA = "0x757998")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x757A30", Offset = "0x757A30", VA = "0x757A30")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x757C0C", Offset = "0x757C0C", VA = "0x757C0C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x757E08", Offset = "0x757E08", VA = "0x757E08")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x758100", Offset = "0x758100", VA = "0x758100")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x7581F0", Offset = "0x7581F0", VA = "0x7581F0")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x758284", Offset = "0x758284", VA = "0x758284")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000DA")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x758904", Offset = "0x758904", VA = "0x758904")]
	private void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x7589A8", Offset = "0x7589A8", VA = "0x7589A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x758A44", Offset = "0x758A44", VA = "0x758A44")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x758A7C", Offset = "0x758A7C", VA = "0x758A7C")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000DB")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000DC")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000486")]
		On,
		[Token(Token = "0x4000487")]
		Off,
		[Token(Token = "0x4000488")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000019")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x758A84", Offset = "0x758A84", VA = "0x758A84")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x756560", Offset = "0x756560", VA = "0x756560")]
		set
		{
		}
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x758A8C", Offset = "0x758A8C", VA = "0x758A8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x758AE4", Offset = "0x758AE4", VA = "0x758AE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x758C1C", Offset = "0x758C1C", VA = "0x758C1C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x758C38", Offset = "0x758C38", VA = "0x758C38", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x758C88", Offset = "0x758C88", VA = "0x758C88")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x758E28", Offset = "0x758E28", VA = "0x758E28")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x758F38", Offset = "0x758F38", VA = "0x758F38")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x758FBC", Offset = "0x758FBC", VA = "0x758FBC")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x75907C", Offset = "0x75907C", VA = "0x75907C")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x759124", Offset = "0x759124", VA = "0x759124")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x759210", Offset = "0x759210", VA = "0x759210")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000DD")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000489")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400048A")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400048B")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x759220", Offset = "0x759220", VA = "0x759220")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x759228", Offset = "0x759228", VA = "0x759228")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x7592B8", Offset = "0x7592B8", VA = "0x7592B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x7593DC", Offset = "0x7593DC", VA = "0x7593DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x759500", Offset = "0x759500", VA = "0x759500")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x759820", Offset = "0x759820", VA = "0x759820")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x759A80", Offset = "0x759A80", VA = "0x759A80")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000DE")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x75A1D8", Offset = "0x75A1D8", VA = "0x75A1D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x75A284", Offset = "0x75A284", VA = "0x75A284")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000DF")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	public enum States
	{
		[Token(Token = "0x40004B9")]
		Ready,
		[Token(Token = "0x40004BA")]
		Aim,
		[Token(Token = "0x40004BB")]
		CancelAim,
		[Token(Token = "0x40004BC")]
		PreTeleport,
		[Token(Token = "0x40004BD")]
		CancelTeleport,
		[Token(Token = "0x40004BE")]
		Teleporting,
		[Token(Token = "0x40004BF")]
		PostTeleport
	}

	[Token(Token = "0x20000E1")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40004C1")]
		None,
		[Token(Token = "0x40004C2")]
		Aim,
		[Token(Token = "0x40004C3")]
		PreTeleport,
		[Token(Token = "0x40004C4")]
		Teleport
	}

	[Token(Token = "0x20000E2")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40004C6")]
		Point,
		[Token(Token = "0x40004C7")]
		Sphere,
		[Token(Token = "0x40004C8")]
		Capsule
	}

	[Token(Token = "0x20000E3")]
	public class AimData
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x1700001D")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x75BFC4", Offset = "0x75BFC4", VA = "0x75BFC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x75BFCC", Offset = "0x75BFCC", VA = "0x75BFCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x75BF3C", Offset = "0x75BF3C", VA = "0x75BF3C")]
		public AimData()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x75BFD4", Offset = "0x75BFD4", VA = "0x75BFD4")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x75C13C", Offset = "0x75C13C", VA = "0x75C13C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x75C184", Offset = "0x75C184", VA = "0x75C184", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x75AC90", Offset = "0x75AC90", VA = "0x75AC90")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x75C02C", Offset = "0x75C02C", VA = "0x75C02C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x75C030", Offset = "0x75C030", VA = "0x75C030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x75C144", Offset = "0x75C144", VA = "0x75C144", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x75C2E8", Offset = "0x75C2E8", VA = "0x75C2E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x75C330", Offset = "0x75C330", VA = "0x75C330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x75B118", Offset = "0x75B118", VA = "0x75B118")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x75C18C", Offset = "0x75C18C", VA = "0x75C18C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x75C190", Offset = "0x75C190", VA = "0x75C190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x75C2F0", Offset = "0x75C2F0", VA = "0x75C2F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x75C3E8", Offset = "0x75C3E8", VA = "0x75C3E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x75C430", Offset = "0x75C430", VA = "0x75C430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x75B2EC", Offset = "0x75B2EC", VA = "0x75B2EC")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x75C338", Offset = "0x75C338", VA = "0x75C338", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x75C33C", Offset = "0x75C33C", VA = "0x75C33C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x75C3F0", Offset = "0x75C3F0", VA = "0x75C3F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x75C520", Offset = "0x75C520", VA = "0x75C520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x75C568", Offset = "0x75C568", VA = "0x75C568", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x75B4C0", Offset = "0x75B4C0", VA = "0x75B4C0")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x75C438", Offset = "0x75C438", VA = "0x75C438", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x75C43C", Offset = "0x75C43C", VA = "0x75C43C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x75C528", Offset = "0x75C528", VA = "0x75C528", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x75C620", Offset = "0x75C620", VA = "0x75C620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x75C668", Offset = "0x75C668", VA = "0x75C668", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x75B694", Offset = "0x75B694", VA = "0x75B694")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x75C570", Offset = "0x75C570", VA = "0x75C570", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x75C574", Offset = "0x75C574", VA = "0x75C574", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x75C628", Offset = "0x75C628", VA = "0x75C628", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x75C754", Offset = "0x75C754", VA = "0x75C754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x75C79C", Offset = "0x75C79C", VA = "0x75C79C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x75B868", Offset = "0x75B868", VA = "0x75B868")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x75C670", Offset = "0x75C670", VA = "0x75C670", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x75C674", Offset = "0x75C674", VA = "0x75C674", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x75C75C", Offset = "0x75C75C", VA = "0x75C75C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x75C8A4", Offset = "0x75C8A4", VA = "0x75C8A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x75C8EC", Offset = "0x75C8EC", VA = "0x75C8EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x75BA3C", Offset = "0x75BA3C", VA = "0x75BA3C")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x75C7A4", Offset = "0x75C7A4", VA = "0x75C7A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x75C7A8", Offset = "0x75C7A8", VA = "0x75C7A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x75C8AC", Offset = "0x75C8AC", VA = "0x75C8AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700001A")]
	public States CurrentState
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x75A2D4", Offset = "0x75A2D4", VA = "0x75A2D4")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x75A2DC", Offset = "0x75A2DC", VA = "0x75A2DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x75A4AC", Offset = "0x75A4AC", VA = "0x75A4AC")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700001C")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x75A4D0", Offset = "0x75A4D0", VA = "0x75A4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x75A4D8", Offset = "0x75A4D8", VA = "0x75A4D8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x75A2E4", Offset = "0x75A2E4", VA = "0x75A2E4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x75A394", Offset = "0x75A394", VA = "0x75A394")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x75AB58", Offset = "0x75AB58", VA = "0x75AB58")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x75ABF4", Offset = "0x75ABF4", VA = "0x75ABF4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x75ACB8", Offset = "0x75ACB8", VA = "0x75ACB8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x75AD54", Offset = "0x75AD54", VA = "0x75AD54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x75ADF0", Offset = "0x75ADF0", VA = "0x75ADF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x75AEA0", Offset = "0x75AEA0", VA = "0x75AEA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x75AF6C", Offset = "0x75AF6C", VA = "0x75AF6C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x75B008", Offset = "0x75B008", VA = "0x75B008")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x75B140", Offset = "0x75B140", VA = "0x75B140")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x75B1DC", Offset = "0x75B1DC", VA = "0x75B1DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x75B314", Offset = "0x75B314", VA = "0x75B314")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x75B3B0", Offset = "0x75B3B0", VA = "0x75B3B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x75B4E8", Offset = "0x75B4E8", VA = "0x75B4E8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x75B584", Offset = "0x75B584", VA = "0x75B584")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x75B6BC", Offset = "0x75B6BC", VA = "0x75B6BC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x75B758", Offset = "0x75B758", VA = "0x75B758")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x75B890", Offset = "0x75B890", VA = "0x75B890")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x75B92C", Offset = "0x75B92C", VA = "0x75B92C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000018")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x75BA64", Offset = "0x75BA64", VA = "0x75BA64")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x75BB14", Offset = "0x75BB14", VA = "0x75BB14")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x75A28C", Offset = "0x75A28C", VA = "0x75A28C")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x75A2B0", Offset = "0x75A2B0", VA = "0x75A2B0")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x75A444", Offset = "0x75A444", VA = "0x75A444")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x75A4E0", Offset = "0x75A4E0", VA = "0x75A4E0")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x75A7A8", Offset = "0x75A7A8", VA = "0x75A7A8")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x75A850", Offset = "0x75A850", VA = "0x75A850")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x75A93C", Offset = "0x75A93C", VA = "0x75A93C")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x75A978", Offset = "0x75A978", VA = "0x75A978")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x75AA28", Offset = "0x75AA28", VA = "0x75AA28")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x75AA58", Offset = "0x75AA58", VA = "0x75AA58")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x75AAB8", Offset = "0x75AAB8", VA = "0x75AAB8", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x75AB50", Offset = "0x75AB50", VA = "0x75AB50", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x75AADC", Offset = "0x75AADC", VA = "0x75AADC")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x75AF50", Offset = "0x75AF50", VA = "0x75AF50")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x75B0A4", Offset = "0x75B0A4", VA = "0x75B0A4")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x75B278", Offset = "0x75B278", VA = "0x75B278")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x75B44C", Offset = "0x75B44C", VA = "0x75B44C")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x75B620", Offset = "0x75B620", VA = "0x75B620")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x75B7F4", Offset = "0x75B7F4", VA = "0x75B7F4")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x75B9C8", Offset = "0x75B9C8", VA = "0x75B9C8")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x75BBC4", Offset = "0x75BBC4", VA = "0x75BBC4")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x75BCD8", Offset = "0x75BCD8", VA = "0x75BCD8")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x75BD08", Offset = "0x75BD08", VA = "0x75BD08")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x75BE44", Offset = "0x75BE44", VA = "0x75BE44")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x75BF2C", Offset = "0x75BF2C", VA = "0x75BF2C")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000EB")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x14000019")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x759340", Offset = "0x759340", VA = "0x759340")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x759464", Offset = "0x759464", VA = "0x759464")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x75C8F4", Offset = "0x75C8F4", VA = "0x75C8F4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x75C990", Offset = "0x75C990", VA = "0x75C990")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x75CA2C", Offset = "0x75CA2C", VA = "0x75CA2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x75CB0C", Offset = "0x75CB0C", VA = "0x75CB0C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x75CB10", Offset = "0x75CB10", VA = "0x75CB10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x75CB84", Offset = "0x75CB84", VA = "0x75CB84")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x75CCA8", Offset = "0x75CCA8", VA = "0x75CCA8")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x75CF20", Offset = "0x75CF20", VA = "0x75CF20")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x75D140", Offset = "0x75D140", VA = "0x75D140")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000EC")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x75D160", Offset = "0x75D160", VA = "0x75D160", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x75D1F0", Offset = "0x75D1F0", VA = "0x75D1F0", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600039B")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x75D2C0", Offset = "0x75D2C0", VA = "0x75D2C0")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000ED")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x75D2D0", Offset = "0x75D2D0", VA = "0x75D2D0", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x75D460", Offset = "0x75D460", VA = "0x75D460")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000EE")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x75D470", Offset = "0x75D470", VA = "0x75D470", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x75D644", Offset = "0x75D644", VA = "0x75D644")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000EF")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x75D658", Offset = "0x75D658", VA = "0x75D658")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x75D784", Offset = "0x75D784", VA = "0x75D784")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x75D7B0", Offset = "0x75D7B0", VA = "0x75D7B0")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x75D7DC", Offset = "0x75D7DC", VA = "0x75D7DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x75D880", Offset = "0x75D880", VA = "0x75D880", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x75D8D4", Offset = "0x75D8D4", VA = "0x75D8D4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x75D924", Offset = "0x75D924", VA = "0x75D924")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000F0")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700002C")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x75DA20", Offset = "0x75DA20", VA = "0x75DA20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x75DA28", Offset = "0x75DA28", VA = "0x75DA28")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x75DBB0", Offset = "0x75DBB0", VA = "0x75DBB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x75DC60", Offset = "0x75DC60", VA = "0x75DC60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x75DA34", Offset = "0x75DA34", VA = "0x75DA34")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x75DAB8", Offset = "0x75DAB8", VA = "0x75DAB8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x75DB7C", Offset = "0x75DB7C", VA = "0x75DB7C")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x75DBAC", Offset = "0x75DBAC", VA = "0x75DBAC")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x75A954", Offset = "0x75A954", VA = "0x75A954")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x75DD10", Offset = "0x75DD10", VA = "0x75DD10")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x75DD2C", Offset = "0x75DD2C", VA = "0x75DD2C", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000F1")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x75E2F4", Offset = "0x75E2F4", VA = "0x75E2F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x75E33C", Offset = "0x75E33C", VA = "0x75E33C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x75E160", Offset = "0x75E160", VA = "0x75E160")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x75E264", Offset = "0x75E264", VA = "0x75E264", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x75E268", Offset = "0x75E268", VA = "0x75E268", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x75E2FC", Offset = "0x75E2FC", VA = "0x75E2FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x75E3E0", Offset = "0x75E3E0", VA = "0x75E3E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x75E428", Offset = "0x75E428", VA = "0x75E428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x75E1FC", Offset = "0x75E1FC", VA = "0x75E1FC")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x75E344", Offset = "0x75E344", VA = "0x75E344", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x75E348", Offset = "0x75E348", VA = "0x75E348", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x75E3E8", Offset = "0x75E3E8", VA = "0x75E3E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x75DF20", Offset = "0x75DF20", VA = "0x75DF20")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x75DFF4", Offset = "0x75DFF4", VA = "0x75DFF4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x75E040", Offset = "0x75E040", VA = "0x75E040", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x75E0EC", Offset = "0x75E0EC", VA = "0x75E0EC")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x75E188", Offset = "0x75E188", VA = "0x75E188")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60003B9")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x20000F4")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000031")]
	public Transform Pointer
	{
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x75E430", Offset = "0x75E430", VA = "0x75E430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x75E438", Offset = "0x75E438", VA = "0x75E438")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x75E440", Offset = "0x75E440", VA = "0x75E440", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x75E56C", Offset = "0x75E56C", VA = "0x75E56C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x75E620", Offset = "0x75E620", VA = "0x75E620")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000F5")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000F6")]
	public enum InputModes
	{
		[Token(Token = "0x4000519")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400051A")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400051B")]
		ThumbstickTeleport,
		[Token(Token = "0x400051C")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000F7")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x400051E")]
		A,
		[Token(Token = "0x400051F")]
		B,
		[Token(Token = "0x4000520")]
		LeftTrigger,
		[Token(Token = "0x4000521")]
		LeftThumbstick,
		[Token(Token = "0x4000522")]
		RightTrigger,
		[Token(Token = "0x4000523")]
		RightThumbstick,
		[Token(Token = "0x4000524")]
		X,
		[Token(Token = "0x4000525")]
		Y
	}

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x75E624", Offset = "0x75E624", VA = "0x75E624")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x75E628", Offset = "0x75E628", VA = "0x75E628", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x75EA5C", Offset = "0x75EA5C", VA = "0x75EA5C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x75EB18", Offset = "0x75EB18", VA = "0x75EB18")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000F8")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000F9")]
	public enum OrientationModes
	{
		[Token(Token = "0x400052A")]
		HeadRelative,
		[Token(Token = "0x400052B")]
		ForwardFacing
	}

	[Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x75EFC8", Offset = "0x75EFC8", VA = "0x75EFC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x75F010", Offset = "0x75F010", VA = "0x75F010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x75EDD8", Offset = "0x75EDD8", VA = "0x75EDD8")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x75EF18", Offset = "0x75EF18", VA = "0x75EF18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x75EF1C", Offset = "0x75EF1C", VA = "0x75EF1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x75EFD0", Offset = "0x75EFD0", VA = "0x75EFD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x75EC08", Offset = "0x75EC08", VA = "0x75EC08")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x75ECF0", Offset = "0x75ECF0", VA = "0x75ECF0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x75ECF8", Offset = "0x75ECF8", VA = "0x75ECF8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x75ED30", Offset = "0x75ED30", VA = "0x75ED30", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x75ED64", Offset = "0x75ED64", VA = "0x75ED64")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60003D7")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x75EE00", Offset = "0x75EE00", VA = "0x75EE00")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x20000FB")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x75F018", Offset = "0x75F018", VA = "0x75F018", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x75F01C", Offset = "0x75F01C", VA = "0x75F01C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x75F0C4", Offset = "0x75F0C4", VA = "0x75F0C4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000FC")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x75F0C8", Offset = "0x75F0C8", VA = "0x75F0C8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x75F118", Offset = "0x75F118", VA = "0x75F118", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x75F5DC", Offset = "0x75F5DC", VA = "0x75F5DC")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000FD")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x75F5E0", Offset = "0x75F5E0", VA = "0x75F5E0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x75F614", Offset = "0x75F614", VA = "0x75F614", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x75FB10", Offset = "0x75FB10", VA = "0x75FB10")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000FE")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x75FB20", Offset = "0x75FB20", VA = "0x75FB20")]
	private void Start()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x75FB24", Offset = "0x75FB24", VA = "0x75FB24")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x75FB2C", Offset = "0x75FB2C", VA = "0x75FB2C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x75FC18", Offset = "0x75FC18", VA = "0x75FC18")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x75FC34", Offset = "0x75FC34", VA = "0x75FC34")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000FF")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000034")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x75FC4C", Offset = "0x75FC4C", VA = "0x75FC4C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x75FC54", Offset = "0x75FC54", VA = "0x75FC54")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x75D188", Offset = "0x75D188", VA = "0x75D188", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x75D298", Offset = "0x75D298", VA = "0x75D298", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x75FC5C", Offset = "0x75FC5C", VA = "0x75FC5C")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x75D8C8", Offset = "0x75D8C8", VA = "0x75D8C8", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x75D91C", Offset = "0x75D91C", VA = "0x75D91C", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x75D2C8", Offset = "0x75D2C8", VA = "0x75D2C8")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x2000100")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x76034C", Offset = "0x76034C", VA = "0x76034C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x760394", Offset = "0x760394", VA = "0x760394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x75FF04", Offset = "0x75FF04", VA = "0x75FF04")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x760080", Offset = "0x760080", VA = "0x760080", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x760084", Offset = "0x760084", VA = "0x760084", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x760354", Offset = "0x760354", VA = "0x760354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000545")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x75FD2C", Offset = "0x75FD2C", VA = "0x75FD2C")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x75FE44", Offset = "0x75FE44", VA = "0x75FE44", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x75FE6C", Offset = "0x75FE6C", VA = "0x75FE6C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x75FE90", Offset = "0x75FE90", VA = "0x75FE90")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x75FF2C", Offset = "0x75FF2C", VA = "0x75FF2C", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60003FB")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x75FF44", Offset = "0x75FF44", VA = "0x75FF44", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x2000102")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x76039C", Offset = "0x76039C", VA = "0x76039C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x760404", Offset = "0x760404", VA = "0x760404", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x76056C", Offset = "0x76056C", VA = "0x76056C", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x760658", Offset = "0x760658", VA = "0x760658")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x76065C", Offset = "0x76065C", VA = "0x76065C")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000103")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x760668", Offset = "0x760668", VA = "0x760668", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x760860", Offset = "0x760860", VA = "0x760860")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000104")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x76086C", Offset = "0x76086C", VA = "0x76086C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x7609D4", Offset = "0x7609D4", VA = "0x7609D4")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000105")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x7609D8", Offset = "0x7609D8", VA = "0x7609D8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x760A5C", Offset = "0x760A5C", VA = "0x760A5C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600040F")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x760ADC", Offset = "0x760ADC", VA = "0x760ADC")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000106")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x760E40", Offset = "0x760E40", VA = "0x760E40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x760E88", Offset = "0x760E88", VA = "0x760E88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x760B78", Offset = "0x760B78", VA = "0x760B78")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x760D3C", Offset = "0x760D3C", VA = "0x760D3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x760D40", Offset = "0x760D40", VA = "0x760D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x760E48", Offset = "0x760E48", VA = "0x760E48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x760AE4", Offset = "0x760AE4", VA = "0x760AE4", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x760B04", Offset = "0x760B04", VA = "0x760B04")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x760BA0", Offset = "0x760BA0", VA = "0x760BA0")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000108")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x760E90", Offset = "0x760E90", VA = "0x760E90", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x760EA8", Offset = "0x760EA8", VA = "0x760EA8")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000109")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x7610CC", Offset = "0x7610CC", VA = "0x7610CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x761114", Offset = "0x761114", VA = "0x761114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x760F44", Offset = "0x760F44", VA = "0x760F44")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x760FB4", Offset = "0x760FB4", VA = "0x760FB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x760FB8", Offset = "0x760FB8", VA = "0x760FB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7610D4", Offset = "0x7610D4", VA = "0x7610D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How much time the warp transition takes to complete.")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x760EB0", Offset = "0x760EB0", VA = "0x760EB0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x760ED0", Offset = "0x760ED0", VA = "0x760ED0")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x760F6C", Offset = "0x760F6C", VA = "0x760F6C")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x200010B")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x200010C")]
	public enum PlabackState
	{
		[Token(Token = "0x4000575")]
		Idle = 1,
		[Token(Token = "0x4000576")]
		Preparing,
		[Token(Token = "0x4000577")]
		Buffering,
		[Token(Token = "0x4000578")]
		Ready,
		[Token(Token = "0x4000579")]
		Ended
	}

	[Token(Token = "0x200010D")]
	public enum StereoMode
	{
		[Token(Token = "0x400057B")]
		Unknown = -1,
		[Token(Token = "0x400057C")]
		Mono,
		[Token(Token = "0x400057D")]
		TopBottom,
		[Token(Token = "0x400057E")]
		LeftRight,
		[Token(Token = "0x400057F")]
		Mesh
	}

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700003B")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x76111C", Offset = "0x76111C", VA = "0x76111C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003C")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x76140C", Offset = "0x76140C", VA = "0x76140C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003D")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x76168C", Offset = "0x76168C", VA = "0x76168C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003E")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x761700", Offset = "0x761700", VA = "0x761700")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x761804", Offset = "0x761804", VA = "0x761804")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000040")]
	public static long Duration
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x76190C", Offset = "0x76190C", VA = "0x76190C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000041")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x761A14", Offset = "0x761A14", VA = "0x761A14")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000042")]
	public static int VideoWidth
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x761B1C", Offset = "0x761B1C", VA = "0x761B1C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000043")]
	public static int VideoHeight
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x761C24", Offset = "0x761C24", VA = "0x761C24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x761D2C", Offset = "0x761D2C", VA = "0x761D2C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x761E34", Offset = "0x761E34", VA = "0x761E34")]
		set
		{
		}
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x761F9C", Offset = "0x761F9C", VA = "0x761F9C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x7621B4", Offset = "0x7621B4", VA = "0x7621B4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x7622BC", Offset = "0x7622BC", VA = "0x7622BC")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x7623C4", Offset = "0x7623C4", VA = "0x7623C4")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x7624CC", Offset = "0x7624CC", VA = "0x7624CC")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x76263C", Offset = "0x76263C", VA = "0x76263C")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x7627A8", Offset = "0x7627A8", VA = "0x7627A8")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200010E")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400001C")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7629FC", Offset = "0x7629FC", VA = "0x7629FC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x762A98", Offset = "0x762A98", VA = "0x762A98")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x762B34", Offset = "0x762B34", VA = "0x762B34", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x762B50", Offset = "0x762B50", VA = "0x762B50")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200010F")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000110")]
	public enum ButtonType
	{
		[Token(Token = "0x4000583")]
		Play,
		[Token(Token = "0x4000584")]
		Pause,
		[Token(Token = "0x4000585")]
		FastForward,
		[Token(Token = "0x4000586")]
		Rewind,
		[Token(Token = "0x4000587")]
		SkipForward,
		[Token(Token = "0x4000588")]
		SkipBack,
		[Token(Token = "0x4000589")]
		Stop
	}

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000045")]
	public ButtonType buttonType
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x762B58", Offset = "0x762B58", VA = "0x762B58")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x762B60", Offset = "0x762B60", VA = "0x762B60")]
		set
		{
		}
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x762B84", Offset = "0x762B84", VA = "0x762B84", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x7639D8", Offset = "0x7639D8", VA = "0x7639D8")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000111")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000112")]
	public enum VideoShape
	{
		[Token(Token = "0x400059E")]
		_360,
		[Token(Token = "0x400059F")]
		_180,
		[Token(Token = "0x40005A0")]
		Quad
	}

	[Token(Token = "0x2000113")]
	public enum VideoStereo
	{
		[Token(Token = "0x40005A2")]
		Mono,
		[Token(Token = "0x40005A3")]
		TopBottom,
		[Token(Token = "0x40005A4")]
		LeftRight,
		[Token(Token = "0x40005A5")]
		BottomTop
	}

	[Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x764F34", Offset = "0x764F34", VA = "0x764F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x764F7C", Offset = "0x764F7C", VA = "0x764F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7640CC", Offset = "0x7640CC", VA = "0x7640CC")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x764D88", Offset = "0x764D88", VA = "0x764D88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x764D8C", Offset = "0x764D8C", VA = "0x764D8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x764F3C", Offset = "0x764F3C", VA = "0x764F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000046")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x763A30", Offset = "0x763A30", VA = "0x763A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x763A38", Offset = "0x763A38", VA = "0x763A38")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public long Duration
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x763A44", Offset = "0x763A44", VA = "0x763A44")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x763A4C", Offset = "0x763A4C", VA = "0x763A4C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public long PlaybackPosition
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x763A54", Offset = "0x763A54", VA = "0x763A54")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x763A5C", Offset = "0x763A5C", VA = "0x763A5C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x763A64", Offset = "0x763A64", VA = "0x763A64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x763CEC", Offset = "0x763CEC", VA = "0x763CEC")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x763D4C", Offset = "0x763D4C", VA = "0x763D4C")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x764058", Offset = "0x764058", VA = "0x764058")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x7640F4", Offset = "0x7640F4", VA = "0x7640F4")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x7643CC", Offset = "0x7643CC", VA = "0x7643CC")]
	public void Play()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x764454", Offset = "0x764454", VA = "0x764454")]
	public void Pause()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x7644D8", Offset = "0x7644D8", VA = "0x7644D8")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x7645C8", Offset = "0x7645C8", VA = "0x7645C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x764B74", Offset = "0x764B74", VA = "0x764B74")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x764C14", Offset = "0x764C14", VA = "0x764C14")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x764C98", Offset = "0x764C98", VA = "0x764C98")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x764D78", Offset = "0x764D78", VA = "0x764D78")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000116")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000117")]
	private enum PlaybackState
	{
		[Token(Token = "0x40005C2")]
		Playing,
		[Token(Token = "0x40005C3")]
		Paused,
		[Token(Token = "0x40005C4")]
		Rewinding,
		[Token(Token = "0x40005C5")]
		FastForwarding
	}

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x765060", Offset = "0x765060", VA = "0x765060")]
	private void Start()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x765350", Offset = "0x765350", VA = "0x765350")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x765470", Offset = "0x765470", VA = "0x765470")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x76556C", Offset = "0x76556C", VA = "0x76556C")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x765640", Offset = "0x765640", VA = "0x765640")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x765540", Offset = "0x765540", VA = "0x765540")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x7656A0", Offset = "0x7656A0", VA = "0x7656A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x765250", Offset = "0x765250", VA = "0x765250")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x7659D0", Offset = "0x7659D0", VA = "0x7659D0")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000118")]
public static class VectorUtil
{
	[Token(Token = "0x6000464")]
	[Address(RVA = "0x764AFC", Offset = "0x764AFC", VA = "0x764AFC")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000119")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40005C6")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40005C7")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x7659E0", Offset = "0x7659E0", VA = "0x7659E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x766034", Offset = "0x766034", VA = "0x766034")]
	private void Update()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x766290", Offset = "0x766290", VA = "0x766290")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x7663F4", Offset = "0x7663F4", VA = "0x7663F4")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x76655C", Offset = "0x76655C", VA = "0x76655C")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x7666E0", Offset = "0x7666E0", VA = "0x7666E0")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x200011A")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40005D0")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x7666F0", Offset = "0x7666F0", VA = "0x7666F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x766748", Offset = "0x766748", VA = "0x766748")]
	private void Start()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x76674C", Offset = "0x76674C", VA = "0x76674C")]
	private void Update()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x765DDC", Offset = "0x765DDC", VA = "0x765DDC")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x766750", Offset = "0x766750", VA = "0x766750")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x76696C", Offset = "0x76696C", VA = "0x76696C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x200011B")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x766974", Offset = "0x766974", VA = "0x766974")]
	private void Start()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x766ED4", Offset = "0x766ED4", VA = "0x766ED4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x766F80", Offset = "0x766F80", VA = "0x766F80")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x767210", Offset = "0x767210", VA = "0x767210")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x7672E4", Offset = "0x7672E4", VA = "0x7672E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x7673BC", Offset = "0x7673BC", VA = "0x7673BC")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x767424", Offset = "0x767424", VA = "0x767424")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x200011C")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x7675CC", Offset = "0x7675CC", VA = "0x7675CC")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x200011D")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x7675D4", Offset = "0x7675D4", VA = "0x7675D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x76766C", Offset = "0x76766C", VA = "0x76766C")]
	private void Update()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x767744", Offset = "0x767744", VA = "0x767744")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x7677A0", Offset = "0x7677A0", VA = "0x7677A0")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x200011E")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x7677A8", Offset = "0x7677A8", VA = "0x7677A8")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x200011F")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x767BB8", Offset = "0x767BB8", VA = "0x767BB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x767C00", Offset = "0x767C00", VA = "0x767C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x767A54", Offset = "0x767A54", VA = "0x767A54")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x767A84", Offset = "0x767A84", VA = "0x767A84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x767A88", Offset = "0x767A88", VA = "0x767A88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x767BC0", Offset = "0x767BC0", VA = "0x767BC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x7677B0", Offset = "0x7677B0", VA = "0x7677B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x7678BC", Offset = "0x7678BC", VA = "0x7678BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x767848", Offset = "0x767848", VA = "0x767848")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x767A7C", Offset = "0x767A7C", VA = "0x767A7C")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x2000121")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x767C08", Offset = "0x767C08", VA = "0x767C08")]
	private void Update()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x7695B0", Offset = "0x7695B0", VA = "0x7695B0")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x2000122")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700004D")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7695B8", Offset = "0x7695B8", VA = "0x7695B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x769608", Offset = "0x769608", VA = "0x769608")]
	public void Start()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x769A40", Offset = "0x769A40", VA = "0x769A40")]
	public void Update()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x769B18", Offset = "0x769B18", VA = "0x769B18")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000492")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000494")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000495")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000496")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000497")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000498")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000499")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x769B70", Offset = "0x769B70", VA = "0x769B70")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x769BB0", Offset = "0x769BB0", VA = "0x769BB0")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x769C1C", Offset = "0x769C1C", VA = "0x769C1C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x769D68", Offset = "0x769D68", VA = "0x769D68")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x769E38", Offset = "0x769E38", VA = "0x769E38")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x76991C", Offset = "0x76991C", VA = "0x76991C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x769F08", Offset = "0x769F08", VA = "0x769F08")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x769F54", Offset = "0x769F54", VA = "0x769F54")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x76A064", Offset = "0x76A064", VA = "0x76A064")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x2000123")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000124")]
	public enum DrawMode
	{
		[Token(Token = "0x40005FF")]
		Opaque,
		[Token(Token = "0x4000600")]
		OpaqueWithClip,
		[Token(Token = "0x4000601")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000602")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700004E")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x76B6A8", Offset = "0x76B6A8", VA = "0x76B6A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x76B72C", Offset = "0x76B72C", VA = "0x76B72C")]
		set
		{
		}
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x76A06C", Offset = "0x76A06C", VA = "0x76A06C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x76AD30", Offset = "0x76AD30", VA = "0x76AD30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x76ADA4", Offset = "0x76ADA4", VA = "0x76ADA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x76AE74", Offset = "0x76AE74", VA = "0x76AE74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x76AF44", Offset = "0x76AF44", VA = "0x76AF44", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x76B148", Offset = "0x76B148", VA = "0x76B148")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x76B7E8", Offset = "0x76B7E8", VA = "0x76B7E8")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x2000125")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x76B8A4", Offset = "0x76B8A4", VA = "0x76B8A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x76BC44", Offset = "0x76BC44", VA = "0x76BC44")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x76BDD8", Offset = "0x76BDD8", VA = "0x76BDD8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x76BDE0", Offset = "0x76BDE0", VA = "0x76BDE0")]
	public void Release()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x76BDC8", Offset = "0x76BDC8", VA = "0x76BDC8")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x76BDE8", Offset = "0x76BDE8", VA = "0x76BDE8")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x2000126")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x76C530", Offset = "0x76C530", VA = "0x76C530", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x76C578", Offset = "0x76C578", VA = "0x76C578", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x76C3D4", Offset = "0x76C3D4", VA = "0x76C3D4")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x76C42C", Offset = "0x76C42C", VA = "0x76C42C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x76C430", Offset = "0x76C430", VA = "0x76C430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x76C538", Offset = "0x76C538", VA = "0x76C538", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x76C6FC", Offset = "0x76C6FC", VA = "0x76C6FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x76C744", Offset = "0x76C744", VA = "0x76C744", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x76C3FC", Offset = "0x76C3FC", VA = "0x76C3FC")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x76C580", Offset = "0x76C580", VA = "0x76C580", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x76C584", Offset = "0x76C584", VA = "0x76C584", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x76C704", Offset = "0x76C704", VA = "0x76C704", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x76BDF0", Offset = "0x76BDF0", VA = "0x76BDF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x76C0D0", Offset = "0x76C0D0", VA = "0x76C0D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x76C120", Offset = "0x76C120", VA = "0x76C120")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x76C298", Offset = "0x76C298", VA = "0x76C298")]
	public void Release()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x76C33C", Offset = "0x76C33C", VA = "0x76C33C")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x76C1D8", Offset = "0x76C1D8", VA = "0x76C1D8")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x76C424", Offset = "0x76C424", VA = "0x76C424")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000129")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x76C74C", Offset = "0x76C74C", VA = "0x76C74C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x76C7A0", Offset = "0x76C7A0", VA = "0x76C7A0")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x200012A")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x76C7A8", Offset = "0x76C7A8", VA = "0x76C7A8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x76C97C", Offset = "0x76C97C", VA = "0x76C97C")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x76CA0C", Offset = "0x76CA0C", VA = "0x76CA0C")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x76CA68", Offset = "0x76CA68", VA = "0x76CA68")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x200012B")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x76DC40", Offset = "0x76DC40", VA = "0x76DC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x76DC88", Offset = "0x76DC88", VA = "0x76DC88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x76D9A8", Offset = "0x76D9A8", VA = "0x76D9A8")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x76DA70", Offset = "0x76DA70", VA = "0x76DA70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x76DA74", Offset = "0x76DA74", VA = "0x76DA74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x76DC48", Offset = "0x76DC48", VA = "0x76DC48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x76CA70", Offset = "0x76CA70", VA = "0x76CA70")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x76CD58", Offset = "0x76CD58", VA = "0x76CD58")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x76D044", Offset = "0x76D044", VA = "0x76D044")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x76D36C", Offset = "0x76D36C", VA = "0x76D36C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x76D644", Offset = "0x76D644", VA = "0x76D644")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x76D72C", Offset = "0x76D72C", VA = "0x76D72C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x76D8C4", Offset = "0x76D8C4", VA = "0x76D8C4")]
	public void Release()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x76D814", Offset = "0x76D814", VA = "0x76D814")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x76D9D0", Offset = "0x76D9D0", VA = "0x76D9D0")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x200012D")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000637")]
		Default,
		[Token(Token = "0x4000638")]
		ForcedHand,
		[Token(Token = "0x4000639")]
		DollyHand,
		[Token(Token = "0x400063A")]
		DollyAttached,
		[Token(Token = "0x400063B")]
		HorizontalScaled,
		[Token(Token = "0x400063C")]
		VerticalScaled,
		[Token(Token = "0x400063D")]
		Menu
	}

	[Token(Token = "0x200012F")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x2000130")]
	public delegate void ReleasedObject();

	[Token(Token = "0x2000131")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x76DC90", Offset = "0x76DC90", VA = "0x76DC90")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x76DCF0", Offset = "0x76DCF0", VA = "0x76DCF0")]
	public void Release()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x76DD0C", Offset = "0x76DD0C", VA = "0x76DD0C")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x76DD28", Offset = "0x76DD28", VA = "0x76DD28")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x2000132")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x76DFE0", Offset = "0x76DFE0", VA = "0x76DFE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x76E240", Offset = "0x76E240", VA = "0x76E240")]
	private void Update()
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x76E408", Offset = "0x76E408", VA = "0x76E408")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x76EA5C", Offset = "0x76EA5C", VA = "0x76EA5C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x76EFF4", Offset = "0x76EFF4", VA = "0x76EFF4")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x7712FC", Offset = "0x7712FC", VA = "0x7712FC")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x771670", Offset = "0x771670", VA = "0x771670")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x2000133")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x771694", Offset = "0x771694", VA = "0x771694")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x7719FC", Offset = "0x7719FC", VA = "0x7719FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x771730", Offset = "0x771730", VA = "0x771730")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x771E64", Offset = "0x771E64", VA = "0x771E64")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x7723D4", Offset = "0x7723D4", VA = "0x7723D4")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x2000134")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x774C7C", Offset = "0x774C7C", VA = "0x774C7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x774CC4", Offset = "0x774CC4", VA = "0x774CC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x7745BC", Offset = "0x7745BC", VA = "0x7745BC")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7749A4", Offset = "0x7749A4", VA = "0x7749A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7749A8", Offset = "0x7749A8", VA = "0x7749A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x774C84", Offset = "0x774C84", VA = "0x774C84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x7723E4", Offset = "0x7723E4", VA = "0x7723E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x7725E0", Offset = "0x7725E0", VA = "0x7725E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x77351C", Offset = "0x77351C", VA = "0x77351C")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x7742B0", Offset = "0x7742B0", VA = "0x7742B0")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x77256C", Offset = "0x77256C", VA = "0x77256C")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x772830", Offset = "0x772830", VA = "0x772830")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x773810", Offset = "0x773810", VA = "0x773810")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x7745E4", Offset = "0x7745E4", VA = "0x7745E4")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x774698", Offset = "0x774698", VA = "0x774698")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x7746C8", Offset = "0x7746C8", VA = "0x7746C8")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x7744A0", Offset = "0x7744A0", VA = "0x7744A0")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x7747B8", Offset = "0x7747B8", VA = "0x7747B8")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000136")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x774CCC", Offset = "0x774CCC", VA = "0x774CCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x774E38", Offset = "0x774E38", VA = "0x774E38")]
	private void Update()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x774EEC", Offset = "0x774EEC", VA = "0x774EEC")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000137")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000138")]
	public enum BrushState
	{
		[Token(Token = "0x400067A")]
		Idle,
		[Token(Token = "0x400067B")]
		Inking
	}

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x774EF4", Offset = "0x774EF4", VA = "0x774EF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x774EFC", Offset = "0x774EFC", VA = "0x774EFC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x7751AC", Offset = "0x7751AC", VA = "0x7751AC")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x7753E0", Offset = "0x7753E0", VA = "0x7753E0")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x775620", Offset = "0x775620", VA = "0x775620")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x7750C4", Offset = "0x7750C4", VA = "0x7750C4")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x7756F0", Offset = "0x7756F0", VA = "0x7756F0")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000139")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x77578C", Offset = "0x77578C", VA = "0x77578C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x7758F8", Offset = "0x7758F8", VA = "0x7758F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x775AE4", Offset = "0x775AE4", VA = "0x775AE4")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x200013A")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x775AEC", Offset = "0x775AEC", VA = "0x775AEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x775CD4", Offset = "0x775CD4", VA = "0x775CD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x775E74", Offset = "0x775E74", VA = "0x775E74")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x200013B")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x776AA4", Offset = "0x776AA4", VA = "0x776AA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x776AEC", Offset = "0x776AEC", VA = "0x776AEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x776928", Offset = "0x776928", VA = "0x776928")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x776950", Offset = "0x776950", VA = "0x776950", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x776954", Offset = "0x776954", VA = "0x776954", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x776AAC", Offset = "0x776AAC", VA = "0x776AAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x776C88", Offset = "0x776C88", VA = "0x776C88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x776CD0", Offset = "0x776CD0", VA = "0x776CD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x776AF4", Offset = "0x776AF4", VA = "0x776AF4")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x776B1C", Offset = "0x776B1C", VA = "0x776B1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x776B20", Offset = "0x776B20", VA = "0x776B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x776C90", Offset = "0x776C90", VA = "0x776C90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x775E7C", Offset = "0x775E7C", VA = "0x775E7C")]
	private void Start()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x7761B8", Offset = "0x7761B8", VA = "0x7761B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x776558", Offset = "0x776558", VA = "0x776558")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x7766CC", Offset = "0x7766CC", VA = "0x7766CC")]
	public void Release()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x776648", Offset = "0x776648", VA = "0x776648")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__18))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x7767B0", Offset = "0x7767B0", VA = "0x7767B0")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__19))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x776834", Offset = "0x776834", VA = "0x776834")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x776854", Offset = "0x776854", VA = "0x776854")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x776874", Offset = "0x776874", VA = "0x776874")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x776150", Offset = "0x776150", VA = "0x776150")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x7768A8", Offset = "0x7768A8", VA = "0x7768A8")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x7768B4", Offset = "0x7768B4", VA = "0x7768B4")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x7761D0", Offset = "0x7761D0", VA = "0x7761D0")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x7768C0", Offset = "0x7768C0", VA = "0x7768C0")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x200013E")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x776CD8", Offset = "0x776CD8", VA = "0x776CD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x776D8C", Offset = "0x776D8C", VA = "0x776D8C")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x200013F")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x776D94", Offset = "0x776D94", VA = "0x776D94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x776E00", Offset = "0x776E00", VA = "0x776E00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x7770F4", Offset = "0x7770F4", VA = "0x7770F4")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x2000140")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x7770FC", Offset = "0x7770FC", VA = "0x7770FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x777550", Offset = "0x777550", VA = "0x777550")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x2000141")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x777558", Offset = "0x777558", VA = "0x777558")]
	private void Start()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x7777C0", Offset = "0x7777C0", VA = "0x7777C0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x77780C", Offset = "0x77780C", VA = "0x77780C")]
	public void Release()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x77784C", Offset = "0x77784C", VA = "0x77784C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x2000142")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x777F68", Offset = "0x777F68", VA = "0x777F68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x777FB0", Offset = "0x777FB0", VA = "0x777FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x777E30", Offset = "0x777E30", VA = "0x777E30")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x777E70", Offset = "0x777E70", VA = "0x777E70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x777E74", Offset = "0x777E74", VA = "0x777E74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x777F70", Offset = "0x777F70", VA = "0x777F70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x777854", Offset = "0x777854", VA = "0x777854")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x777878", Offset = "0x777878", VA = "0x777878")]
	private void Start()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x777980", Offset = "0x777980", VA = "0x777980")]
	private void Update()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x777A24", Offset = "0x777A24", VA = "0x777A24")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x777C78", Offset = "0x777C78", VA = "0x777C78")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x777D1C", Offset = "0x777D1C", VA = "0x777D1C")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x777BF4", Offset = "0x777BF4", VA = "0x777BF4")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x777E58", Offset = "0x777E58", VA = "0x777E58")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x2000144")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x777FB8", Offset = "0x777FB8", VA = "0x777FB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x7782C8", Offset = "0x7782C8", VA = "0x7782C8")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x2000145")]
[RequireComponent(typeof(OVRSceneAnchor))]
[DefaultExecutionOrder(30)]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x7782D0", Offset = "0x7782D0", VA = "0x7782D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x7784E8", Offset = "0x7784E8", VA = "0x7784E8")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x778958", Offset = "0x778958", VA = "0x778958")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x778370", Offset = "0x778370", VA = "0x778370")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x778B78", Offset = "0x778B78", VA = "0x778B78")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x779064", Offset = "0x779064", VA = "0x779064")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x2000146")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x779298", Offset = "0x779298", VA = "0x779298", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x7792E0", Offset = "0x7792E0", VA = "0x7792E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x7790E0", Offset = "0x7790E0", VA = "0x7790E0")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x779198", Offset = "0x779198", VA = "0x779198", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x77919C", Offset = "0x77919C", VA = "0x77919C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x7792A0", Offset = "0x7792A0", VA = "0x7792A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x77906C", Offset = "0x77906C", VA = "0x77906C")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x779108", Offset = "0x779108", VA = "0x779108", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x779128", Offset = "0x779128", VA = "0x779128", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x779190", Offset = "0x779190", VA = "0x779190")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x2000148")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x7792E8", Offset = "0x7792E8", VA = "0x7792E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x7792EC", Offset = "0x7792EC", VA = "0x7792EC")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x2000149")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x7792F4", Offset = "0x7792F4", VA = "0x7792F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x77936C", Offset = "0x77936C", VA = "0x77936C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x7793F0", Offset = "0x7793F0", VA = "0x7793F0")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x200014A")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x200014B")]
	public enum Method
	{
		[Token(Token = "0x40006D7")]
		Adapt,
		[Token(Token = "0x40006D8")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40006D9")]
		Scale,
		[Token(Token = "0x40006DA")]
		None
	}

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700005F")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x779400", Offset = "0x779400", VA = "0x779400")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000060")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x77941C", Offset = "0x77941C", VA = "0x77941C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x779428", Offset = "0x779428", VA = "0x779428")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x779434", Offset = "0x779434", VA = "0x779434")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x779440", Offset = "0x779440", VA = "0x779440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x77944C", Offset = "0x77944C", VA = "0x77944C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x779454", Offset = "0x779454", VA = "0x779454")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x77945C", Offset = "0x77945C", VA = "0x77945C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x779598", Offset = "0x779598", VA = "0x779598")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x200014C")]
public class SimpleResizer
{
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x778CD0", Offset = "0x778CD0", VA = "0x778CD0")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x7795A0", Offset = "0x7795A0", VA = "0x7795A0")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x779824", Offset = "0x779824", VA = "0x779824")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x778CC8", Offset = "0x778CC8", VA = "0x778CC8")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x200014D")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x7798CC", Offset = "0x7798CC", VA = "0x7798CC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x7798D0", Offset = "0x7798D0", VA = "0x7798D0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x779D38", Offset = "0x779D38", VA = "0x779D38")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x200014E")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x200014F")]
	public enum GeometryType
	{
		[Token(Token = "0x40006E2")]
		Plane,
		[Token(Token = "0x40006E3")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x2000150")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x779D90", Offset = "0x779D90", VA = "0x779D90")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x77A1BC", Offset = "0x77A1BC", VA = "0x77A1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x77AAF4", Offset = "0x77AAF4", VA = "0x77AAF4")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x77A9CC", Offset = "0x77A9CC", VA = "0x77A9CC")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x77AB74", Offset = "0x77AB74", VA = "0x77AB74")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x2000151")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x77B93C", Offset = "0x77B93C", VA = "0x77B93C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x77B984", Offset = "0x77B984", VA = "0x77B984", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x77AD70", Offset = "0x77AD70", VA = "0x77AD70")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x77B7C0", Offset = "0x77B7C0", VA = "0x77B7C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x77B7C4", Offset = "0x77B7C4", VA = "0x77B7C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x77B944", Offset = "0x77B944", VA = "0x77B944", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006E6")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("canvas_")]
	private Canvas _canvas;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("pivot_")]
	private Transform _pivot;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("saveIcon_")]
	[SerializeField]
	private GameObject _saveIcon;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("labelImage_")]
	[SerializeField]
	private Image _labelImage;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("labelHighlightColor_")]
	[SerializeField]
	private Color _labelHighlightColor;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("labelSelectedColor_")]
	[SerializeField]
	private Color _labelSelectedColor;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("uiManager_")]
	[SerializeField]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000063")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x77B21C", Offset = "0x77B21C", VA = "0x77B21C")]
		set
		{
		}
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x77AB7C", Offset = "0x77AB7C", VA = "0x77AB7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x77ACFC", Offset = "0x77ACFC", VA = "0x77ACFC")]
	[IteratorStateMachine(typeof(<Start>d__20))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x77AD98", Offset = "0x77AD98", VA = "0x77AD98")]
	private void Update()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x77B010", Offset = "0x77B010", VA = "0x77B010")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x77B0E0", Offset = "0x77B0E0", VA = "0x77B0E0")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x77B14C", Offset = "0x77B14C", VA = "0x77B14C")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x77B23C", Offset = "0x77B23C", VA = "0x77B23C")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x77B358", Offset = "0x77B358", VA = "0x77B358")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x77B460", Offset = "0x77B460", VA = "0x77B460")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x77ADE8", Offset = "0x77ADE8", VA = "0x77ADE8")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x77AF1C", Offset = "0x77AF1C", VA = "0x77AF1C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x77B530", Offset = "0x77B530", VA = "0x77B530")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x77B668", Offset = "0x77B668", VA = "0x77B668")]
	public Anchor()
	{
	}
}
[Token(Token = "0x2000153")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x2000154")]
	public enum AnchorMode
	{
		[Token(Token = "0x400070F")]
		Create,
		[Token(Token = "0x4000710")]
		Select
	}

	[Token(Token = "0x2000155")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("selectModeButton_")]
	[SerializeField]
	private GameObject _selectModeButton;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("placementPreview_")]
	private GameObject _placementPreview;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000066")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x77B98C", Offset = "0x77B98C", VA = "0x77B98C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x77B994", Offset = "0x77B994", VA = "0x77B994")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x77BA60", Offset = "0x77BA60", VA = "0x77BA60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x77BBB0", Offset = "0x77BBB0", VA = "0x77BBB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x77C020", Offset = "0x77C020", VA = "0x77C020")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x77C08C", Offset = "0x77C08C", VA = "0x77C08C")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x77BB48", Offset = "0x77BB48", VA = "0x77BB48")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x77C314", Offset = "0x77C314", VA = "0x77C314")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x77C39C", Offset = "0x77C39C", VA = "0x77C39C")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x77C3BC", Offset = "0x77C3BC", VA = "0x77C3BC")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x77C2F4", Offset = "0x77C2F4", VA = "0x77C2F4")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x77BF2C", Offset = "0x77BF2C", VA = "0x77BF2C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x77C5BC", Offset = "0x77C5BC", VA = "0x77C5BC")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x77C444", Offset = "0x77C444", VA = "0x77C444")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x77C530", Offset = "0x77C530", VA = "0x77C530")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x77C6BC", Offset = "0x77C6BC", VA = "0x77C6BC")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x77C550", Offset = "0x77C550", VA = "0x77C550")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x77C588", Offset = "0x77C588", VA = "0x77C588")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x77BCB0", Offset = "0x77BCB0", VA = "0x77BCB0")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x77C7A8", Offset = "0x77C7A8", VA = "0x77C7A8")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x77C7D0", Offset = "0x77C7D0", VA = "0x77C7D0")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x77C860", Offset = "0x77C860", VA = "0x77C860")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x77C9A8", Offset = "0x77C9A8", VA = "0x77C9A8")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x2000156")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x77C0E0", Offset = "0x77C0E0", VA = "0x77C0E0")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x77CB64", Offset = "0x77CB64", VA = "0x77CB64")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x77CA84", Offset = "0x77CA84", VA = "0x77CA84")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x77CBE8", Offset = "0x77CBE8", VA = "0x77CBE8")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x77C9F8", Offset = "0x77C9F8", VA = "0x77C9F8")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x77CD98", Offset = "0x77CD98", VA = "0x77CD98")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x2000157")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x77CED0", Offset = "0x77CED0", VA = "0x77CED0")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x77D0E4", Offset = "0x77D0E4", VA = "0x77D0E4")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x77D1E8", Offset = "0x77D1E8", VA = "0x77D1E8")]
	public StartMenu()
	{
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x2000159")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000067")]
		public bool Highlight
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x77D20C", Offset = "0x77D20C", VA = "0x77D20C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x77D214", Offset = "0x77D214", VA = "0x77D214")]
			set
			{
			}
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x77D220", Offset = "0x77D220", VA = "0x77D220")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x77D3C0", Offset = "0x77D3C0", VA = "0x77D3C0", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x77D3DC", Offset = "0x77D3DC", VA = "0x77D3DC", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x77D3F8", Offset = "0x77D3F8", VA = "0x77D3F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x77D2CC", Offset = "0x77D2CC", VA = "0x77D2CC")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x77D6AC", Offset = "0x77D6AC", VA = "0x77D6AC")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000068")]
		public bool InRange
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x77D724", Offset = "0x77D724", VA = "0x77D724")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x77D72C", Offset = "0x77D72C", VA = "0x77D72C")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool Targeted
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x77D898", Offset = "0x77D898", VA = "0x77D898")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x77D8A0", Offset = "0x77D8A0", VA = "0x77D8A0")]
			set
			{
			}
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x77D8AC", Offset = "0x77D8AC", VA = "0x77D8AC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x77D738", Offset = "0x77D738", VA = "0x77D738")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x77DA9C", Offset = "0x77DA9C", VA = "0x77DA9C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700006A")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x77DAA4", Offset = "0x77DAA4", VA = "0x77DAA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x77DAAC", Offset = "0x77DAAC", VA = "0x77DAAC")]
			set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x77DAC8", Offset = "0x77DAC8", VA = "0x77DAC8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x77DCD4", Offset = "0x77DCD4", VA = "0x77DCD4", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x77E5C0", Offset = "0x77E5C0", VA = "0x77E5C0", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x77EB28", Offset = "0x77EB28", VA = "0x77EB28", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x77EF38", Offset = "0x77EF38", VA = "0x77EF38")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x77DEFC", Offset = "0x77DEFC", VA = "0x77DEFC")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x77F024", Offset = "0x77F024", VA = "0x77F024")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x77F424", Offset = "0x77F424", VA = "0x77F424", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x77F43C", Offset = "0x77F43C", VA = "0x77F43C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x77F444", Offset = "0x77F444", VA = "0x77F444")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200015D")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000736")]
			Disabled,
			[Token(Token = "0x4000737")]
			Enabled,
			[Token(Token = "0x4000738")]
			Targeted
		}

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x77F464", Offset = "0x77F464", VA = "0x77F464")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x77DA10", Offset = "0x77DA10", VA = "0x77DA10")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x77F4CC", Offset = "0x77F4CC", VA = "0x77F4CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x77F504", Offset = "0x77F504", VA = "0x77F504")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x77F50C", Offset = "0x77F50C", VA = "0x77F50C")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x77F5B8", Offset = "0x77F5B8", VA = "0x77F5B8")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x77F660", Offset = "0x77F660", VA = "0x77F660")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x77F668", Offset = "0x77F668", VA = "0x77F668")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x77F754", Offset = "0x77F754", VA = "0x77F754")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x77F760", Offset = "0x77F760", VA = "0x77F760")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x77F76C", Offset = "0x77F76C", VA = "0x77F76C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x77F774", Offset = "0x77F774", VA = "0x77F774")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x77F7C4", Offset = "0x77F7C4", VA = "0x77F7C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x77FB9C", Offset = "0x77FB9C", VA = "0x77FB9C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x77FC88", Offset = "0x77FC88", VA = "0x77FC88")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x77F7C8", Offset = "0x77F7C8", VA = "0x77F7C8")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x77FD74", Offset = "0x77FD74", VA = "0x77FD74")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000162")]
		public enum ContactTest
		{
			[Token(Token = "0x400074F")]
			PerpenTest,
			[Token(Token = "0x4000750")]
			BackwardsPress
		}

		[Token(Token = "0x4000740")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000741")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700006B")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x77FE4C", Offset = "0x77FE4C", VA = "0x77FE4C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x77FE54", Offset = "0x77FE54", VA = "0x77FE54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x77FE60", Offset = "0x77FE60", VA = "0x77FE60")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x77FE68", Offset = "0x77FE68", VA = "0x77FE68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x77FE70", Offset = "0x77FE70", VA = "0x77FE70", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x77FFC0", Offset = "0x77FFC0", VA = "0x77FFC0")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x7801C8", Offset = "0x7801C8", VA = "0x7801C8", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x78078C", Offset = "0x78078C", VA = "0x78078C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x7808F4", Offset = "0x7808F4", VA = "0x7808F4")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x7806B0", Offset = "0x7806B0", VA = "0x7806B0")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x780A00", Offset = "0x780A00", VA = "0x780A00")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x780B0C", Offset = "0x780B0C", VA = "0x780B0C")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x780B94", Offset = "0x780B94", VA = "0x780B94")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x1700006E")]
		public Collider Collider
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x780CB8", Offset = "0x780CB8", VA = "0x780CB8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x780CC0", Offset = "0x780CC0", VA = "0x780CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x780CC8", Offset = "0x780CC8", VA = "0x780CC8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x780CD0", Offset = "0x780CD0", VA = "0x780CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x780CD8", Offset = "0x780CD8", VA = "0x780CD8", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x780D28", Offset = "0x780D28", VA = "0x780D28")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x780DBC", Offset = "0x780DBC", VA = "0x780DBC")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000071")]
		Collider Collider
		{
			[Token(Token = "0x60005F7")]
			get;
		}

		[Token(Token = "0x17000072")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x60005F8")]
			get;
		}

		[Token(Token = "0x17000073")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005F9")]
			get;
		}
	}
	[Token(Token = "0x2000165")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x78011C", Offset = "0x78011C", VA = "0x78011C")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000166")]
	public enum InteractionType
	{
		[Token(Token = "0x4000759")]
		Enter,
		[Token(Token = "0x400075A")]
		Stay,
		[Token(Token = "0x400075B")]
		Exit
	}
	[Token(Token = "0x2000167")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000168")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x400076D")]
			Mesh,
			[Token(Token = "0x400076E")]
			Skeleton,
			[Token(Token = "0x400076F")]
			Both
		}

		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x1700007F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x78221C", Offset = "0x78221C", VA = "0x78221C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x782264", Offset = "0x782264", VA = "0x782264", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x781814", Offset = "0x781814", VA = "0x781814")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x781FFC", Offset = "0x781FFC", VA = "0x781FFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x782000", Offset = "0x782000", VA = "0x782000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x782224", Offset = "0x782224", VA = "0x782224", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400075C")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x17000074")]
		public OVRHand RightHand
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x780DC4", Offset = "0x780DC4", VA = "0x780DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x780DF0", Offset = "0x780DF0", VA = "0x780DF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x780E54", Offset = "0x780E54", VA = "0x780E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x780E80", Offset = "0x780E80", VA = "0x780E80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x780EE4", Offset = "0x780EE4", VA = "0x780EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x780F10", Offset = "0x780F10", VA = "0x780F10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x780F74", Offset = "0x780F74", VA = "0x780F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x780FA0", Offset = "0x780FA0", VA = "0x780FA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x781004", Offset = "0x781004", VA = "0x781004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x781030", Offset = "0x781030", VA = "0x781030")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x781094", Offset = "0x781094", VA = "0x781094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x7810BC", Offset = "0x7810BC", VA = "0x7810BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x78111C", Offset = "0x78111C", VA = "0x78111C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x781144", Offset = "0x781144", VA = "0x781144")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x7811A4", Offset = "0x7811A4", VA = "0x7811A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x7811CC", Offset = "0x7811CC", VA = "0x7811CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x78122C", Offset = "0x78122C", VA = "0x78122C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x781254", Offset = "0x781254", VA = "0x781254")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x7812B4", Offset = "0x7812B4", VA = "0x7812B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x7812DC", Offset = "0x7812DC", VA = "0x7812DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x78133C", Offset = "0x78133C", VA = "0x78133C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x781384", Offset = "0x781384", VA = "0x781384")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x7813DC", Offset = "0x7813DC", VA = "0x7813DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x781798", Offset = "0x781798", VA = "0x781798")]
		private void Update()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x781724", Offset = "0x781724", VA = "0x781724")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x78183C", Offset = "0x78183C", VA = "0x78183C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x781900", Offset = "0x781900", VA = "0x781900")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x781AD0", Offset = "0x781AD0", VA = "0x781AD0")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x781D34", Offset = "0x781D34", VA = "0x781D34")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x781E94", Offset = "0x781E94", VA = "0x781E94")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016B")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x7828B4", Offset = "0x7828B4", VA = "0x7828B4")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000081")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x78226C", Offset = "0x78226C", VA = "0x78226C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x782274", Offset = "0x782274", VA = "0x782274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x78227C", Offset = "0x78227C", VA = "0x78227C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x782284", Offset = "0x782284", VA = "0x782284", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1400001D")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x78228C", Offset = "0x78228C", VA = "0x78228C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x78233C", Offset = "0x78233C", VA = "0x78233C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x782408", Offset = "0x782408", VA = "0x782408")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x7824B8", Offset = "0x7824B8", VA = "0x7824B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x782584", Offset = "0x782584", VA = "0x782584")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x782634", Offset = "0x782634", VA = "0x782634")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7823EC", Offset = "0x7823EC", VA = "0x7823EC", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x782568", Offset = "0x782568", VA = "0x782568", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7826E4", Offset = "0x7826E4", VA = "0x7826E4", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600062C")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x77FF6C", Offset = "0x77FF6C", VA = "0x77FF6C", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x7827B0", Offset = "0x7827B0", VA = "0x7827B0", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x780CB0", Offset = "0x780CB0", VA = "0x780CB0")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x400077B")]
		None,
		[Token(Token = "0x400077C")]
		Proximity,
		[Token(Token = "0x400077D")]
		Contact,
		[Token(Token = "0x400077E")]
		Action
	}
	[Token(Token = "0x200016D")]
	public enum InteractableState
	{
		[Token(Token = "0x4000780")]
		Default,
		[Token(Token = "0x4000781")]
		ProximityState,
		[Token(Token = "0x4000782")]
		ContactState,
		[Token(Token = "0x4000783")]
		ActionState
	}
	[Token(Token = "0x200016E")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x78083C", Offset = "0x78083C", VA = "0x78083C")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x17000085")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x7828FC", Offset = "0x7828FC", VA = "0x7828FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x782700", Offset = "0x782700", VA = "0x782700")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x782804", Offset = "0x782804", VA = "0x782804")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x782954", Offset = "0x782954", VA = "0x782954")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x783114", Offset = "0x783114", VA = "0x783114", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x78315C", Offset = "0x78315C", VA = "0x78315C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x782AFC", Offset = "0x782AFC", VA = "0x782AFC")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x782C38", Offset = "0x782C38", VA = "0x782C38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x782C54", Offset = "0x782C54", VA = "0x782C54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x7830C4", Offset = "0x7830C4", VA = "0x7830C4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x78311C", Offset = "0x78311C", VA = "0x78311C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7829F4", Offset = "0x7829F4", VA = "0x7829F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x782A60", Offset = "0x782A60", VA = "0x782A60")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x782B24", Offset = "0x782B24", VA = "0x782B24")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x782C30", Offset = "0x782C30", VA = "0x782C30")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x17000088")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x783164", Offset = "0x783164", VA = "0x783164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x7832C0", Offset = "0x7832C0", VA = "0x7832C0")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x78335C", Offset = "0x78335C", VA = "0x78335C")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x7833F8", Offset = "0x7833F8", VA = "0x7833F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x783694", Offset = "0x783694", VA = "0x783694")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x7836D0", Offset = "0x7836D0", VA = "0x7836D0")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x7839A8", Offset = "0x7839A8", VA = "0x7839A8")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x783BB0", Offset = "0x783BB0", VA = "0x783BB0")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000174")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0x784D80", Offset = "0x784D80", VA = "0x784D80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x784DC8", Offset = "0x784DC8", VA = "0x784DC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x783E4C", Offset = "0x783E4C", VA = "0x783E4C")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x7848F0", Offset = "0x7848F0", VA = "0x7848F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x7848F4", Offset = "0x7848F4", VA = "0x7848F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x784D88", Offset = "0x784D88", VA = "0x784D88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400079C")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x17000089")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x783CB8", Offset = "0x783CB8", VA = "0x783CB8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700008A")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x783CC0", Offset = "0x783CC0", VA = "0x783CC0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700008B")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x783CC8", Offset = "0x783CC8", VA = "0x783CC8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public override bool EnableState
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x783CD0", Offset = "0x783CD0", VA = "0x783CD0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x783CF8", Offset = "0x783CF8", VA = "0x783CF8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x783D28", Offset = "0x783D28", VA = "0x783D28", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x783DD8", Offset = "0x783DD8", VA = "0x783DD8")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x783E74", Offset = "0x783E74", VA = "0x783E74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x7840F4", Offset = "0x7840F4", VA = "0x7840F4")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x7842B0", Offset = "0x7842B0", VA = "0x7842B0")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x784398", Offset = "0x784398", VA = "0x784398", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x78472C", Offset = "0x78472C", VA = "0x78472C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x784730", Offset = "0x784730", VA = "0x784730", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x784734", Offset = "0x784734", VA = "0x784734")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x1700008F")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x784DD0", Offset = "0x784DD0", VA = "0x784DD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x784DD8", Offset = "0x784DD8", VA = "0x784DD8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool EnableState
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x784DE0", Offset = "0x784DE0", VA = "0x784DE0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x784DFC", Offset = "0x784DFC", VA = "0x784DFC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x784E1C", Offset = "0x784E1C", VA = "0x784E1C", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x784E24", Offset = "0x784E24", VA = "0x784E24", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public float SphereRadius
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x784E30", Offset = "0x784E30", VA = "0x784E30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x784E38", Offset = "0x784E38", VA = "0x784E38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x784E40", Offset = "0x784E40", VA = "0x784E40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x784E7C", Offset = "0x784E7C", VA = "0x784E7C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x784E80", Offset = "0x784E80", VA = "0x784E80")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000176")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40007AF")]
		None = 0,
		[Token(Token = "0x40007B0")]
		Ray = 1,
		[Token(Token = "0x40007B1")]
		Poke = 4,
		[Token(Token = "0x40007B2")]
		All = -1
	}
	[Token(Token = "0x2000177")]
	public enum ToolInputState
	{
		[Token(Token = "0x40007B4")]
		Inactive,
		[Token(Token = "0x40007B5")]
		PrimaryInputDown,
		[Token(Token = "0x40007B6")]
		PrimaryInputDownStay,
		[Token(Token = "0x40007B7")]
		PrimaryInputUp
	}
	[Token(Token = "0x2000178")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x7846D8", Offset = "0x7846D8", VA = "0x7846D8")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x2000179")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x17000093")]
		public Transform ToolTransform
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x780B8C", Offset = "0x780B8C", VA = "0x780B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x784E88", Offset = "0x784E88", VA = "0x784E88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x784E90", Offset = "0x784E90", VA = "0x784E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x600066D")]
			get;
		}

		[Token(Token = "0x17000096")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x600066E")]
			get;
		}

		[Token(Token = "0x17000097")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x600066F")]
			get;
		}

		[Token(Token = "0x17000098")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x784E9C", Offset = "0x784E9C", VA = "0x784E9C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x784EA8", Offset = "0x784EA8", VA = "0x784EA8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x784EB4", Offset = "0x784EB4", VA = "0x784EB4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x784EC0", Offset = "0x784EC0", VA = "0x784EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000678")]
			get;
			[Token(Token = "0x6000679")]
			set;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x784ECC", Offset = "0x784ECC", VA = "0x784ECC")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x6000676")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x6000677")]
		public abstract void DeFocus();

		[Token(Token = "0x600067A")]
		public abstract void Initialize();

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x783B18", Offset = "0x783B18", VA = "0x783B18")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x783B60", Offset = "0x783B60", VA = "0x783B60")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x784ED4", Offset = "0x784ED4", VA = "0x784ED4", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x78519C", Offset = "0x78519C", VA = "0x78519C", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x784748", Offset = "0x784748", VA = "0x784748")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public interface InteractableToolView
	{
		[Token(Token = "0x1700009B")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000680")]
			get;
		}

		[Token(Token = "0x1700009C")]
		bool EnableState
		{
			[Token(Token = "0x6000682")]
			get;
			[Token(Token = "0x6000683")]
			set;
		}

		[Token(Token = "0x1700009D")]
		bool ToolActivateState
		{
			[Token(Token = "0x6000684")]
			get;
			[Token(Token = "0x6000685")]
			set;
		}

		[Token(Token = "0x6000681")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x200017B")]
	public class PinchStateModule
	{
		[Token(Token = "0x200017C")]
		private enum PinchState
		{
			[Token(Token = "0x40007C8")]
			None,
			[Token(Token = "0x40007C9")]
			PinchDown,
			[Token(Token = "0x40007CA")]
			PinchStay,
			[Token(Token = "0x40007CB")]
			PinchUp
		}

		[Token(Token = "0x40007C4")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x1700009E")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x785A38", Offset = "0x785A38", VA = "0x785A38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x785AB4", Offset = "0x785AB4", VA = "0x785AB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x785B30", Offset = "0x785B30", VA = "0x785B30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x785BAC", Offset = "0x785BAC", VA = "0x785BAC")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x785BD4", Offset = "0x785BD4", VA = "0x785BD4")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40007CC")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40007CD")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40007CE")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40007CF")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40007D0")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000A1")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x785D4C", Offset = "0x785D4C", VA = "0x785D4C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000A2")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x785D54", Offset = "0x785D54", VA = "0x785D54", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000A3")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x785DB0", Offset = "0x785DB0", VA = "0x785DB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public override bool EnableState
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x785DB8", Offset = "0x785DB8", VA = "0x785DB8", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x785DF8", Offset = "0x785DF8", VA = "0x785DF8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x785E68", Offset = "0x785E68", VA = "0x785E68", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x785EBC", Offset = "0x785EBC", VA = "0x785EBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x785F48", Offset = "0x785F48", VA = "0x785F48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x7861EC", Offset = "0x7861EC", VA = "0x7861EC")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x786268", Offset = "0x786268", VA = "0x786268", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x78665C", Offset = "0x78665C", VA = "0x78665C")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x7867F8", Offset = "0x7867F8", VA = "0x7867F8")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x786910", Offset = "0x786910", VA = "0x786910")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x786C34", Offset = "0x786C34", VA = "0x786C34")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x786FB0", Offset = "0x786FB0", VA = "0x786FB0", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x787088", Offset = "0x787088", VA = "0x787088", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x7870B8", Offset = "0x7870B8", VA = "0x7870B8")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40007DC")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40007DD")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000A5")]
		public bool EnableState
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x785DDC", Offset = "0x785DDC", VA = "0x785DDC", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x785E14", Offset = "0x785E14", VA = "0x785E14", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool ToolActivateState
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x7871CC", Offset = "0x7871CC", VA = "0x7871CC", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x7861B0", Offset = "0x7861B0", VA = "0x7861B0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x7873F4", Offset = "0x7873F4", VA = "0x7873F4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x7873FC", Offset = "0x7873FC", VA = "0x7873FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7871D4", Offset = "0x7871D4", VA = "0x7871D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x786FE8", Offset = "0x786FE8", VA = "0x786FE8", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x787404", Offset = "0x787404", VA = "0x787404")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7876B0", Offset = "0x7876B0", VA = "0x7876B0")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x787758", Offset = "0x787758", VA = "0x787758")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000A8")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x7877BC", Offset = "0x7877BC", VA = "0x7877BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x7877C4", Offset = "0x7877C4", VA = "0x7877C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x787840", Offset = "0x787840", VA = "0x787840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x787848", Offset = "0x787848", VA = "0x787848")]
			set
			{
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x7878A4", Offset = "0x7878A4", VA = "0x7878A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x787B44", Offset = "0x787B44", VA = "0x787B44")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x787B54", Offset = "0x787B54", VA = "0x787B54")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x787B64", Offset = "0x787B64", VA = "0x787B64")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x787B6C", Offset = "0x787B6C", VA = "0x787B6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x787B70", Offset = "0x787B70", VA = "0x787B70")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x787BFC", Offset = "0x787BFC", VA = "0x787BFC")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x787C8C", Offset = "0x787C8C", VA = "0x787C8C")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x787D1C", Offset = "0x787D1C", VA = "0x787D1C")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x787DC8", Offset = "0x787DC8", VA = "0x787DC8")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x787EA4", Offset = "0x787EA4", VA = "0x787EA4")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x787EE8", Offset = "0x787EE8", VA = "0x787EE8")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x787F48", Offset = "0x787F48", VA = "0x787F48")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x787FA8", Offset = "0x787FA8", VA = "0x787FA8")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x787FB0", Offset = "0x787FB0", VA = "0x787FB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x787FB4", Offset = "0x787FB4", VA = "0x787FB4")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x787F78", Offset = "0x787F78", VA = "0x787F78")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x787FE8", Offset = "0x787FE8", VA = "0x787FE8")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x788668", Offset = "0x788668", VA = "0x788668", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x7886B0", Offset = "0x7886B0", VA = "0x7886B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x7883E0", Offset = "0x7883E0", VA = "0x7883E0")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x7884A8", Offset = "0x7884A8", VA = "0x7884A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x7884AC", Offset = "0x7884AC", VA = "0x7884AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x788670", Offset = "0x788670", VA = "0x788670", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007ED")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x40007EE")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x787FF0", Offset = "0x787FF0", VA = "0x787FF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x788090", Offset = "0x788090", VA = "0x788090")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x7883A0", Offset = "0x7883A0", VA = "0x7883A0")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x78832C", Offset = "0x78832C", VA = "0x78832C")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x788408", Offset = "0x788408", VA = "0x788408")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		public enum SelectionState
		{
			[Token(Token = "0x4000804")]
			Off,
			[Token(Token = "0x4000805")]
			Selected,
			[Token(Token = "0x4000806")]
			Highlighted
		}

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000AC")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x7886B8", Offset = "0x7886B8", VA = "0x7886B8")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x7886C0", Offset = "0x7886C0", VA = "0x7886C0")]
			set
			{
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x788814", Offset = "0x788814", VA = "0x788814")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x7889D8", Offset = "0x7889D8", VA = "0x7889D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x788734", Offset = "0x788734", VA = "0x788734")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x788AA0", Offset = "0x788AA0", VA = "0x788AA0")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		public enum SegmentType
		{
			[Token(Token = "0x4000815")]
			Straight,
			[Token(Token = "0x4000816")]
			LeftTurn,
			[Token(Token = "0x4000817")]
			RightTurn,
			[Token(Token = "0x4000818")]
			Switch
		}

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x400080D")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x400080E")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000AD")]
		public float StartDistance
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x788B10", Offset = "0x788B10", VA = "0x788B10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x788B18", Offset = "0x788B18", VA = "0x788B18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float GridSize
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x788B20", Offset = "0x788B20", VA = "0x788B20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x788B28", Offset = "0x788B28", VA = "0x788B28")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int SubDivCount
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x788B30", Offset = "0x788B30", VA = "0x788B30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x788B38", Offset = "0x788B38", VA = "0x788B38")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public SegmentType Type
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x788B40", Offset = "0x788B40", VA = "0x788B40")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000B1")]
		public Pose EndPose
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x788B48", Offset = "0x788B48", VA = "0x788B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		public float Radius
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x788F1C", Offset = "0x788F1C", VA = "0x788F1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B3")]
		public float SegmentLength
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x788BA4", Offset = "0x788BA4", VA = "0x788BA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x788F2C", Offset = "0x788F2C", VA = "0x788F2C")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x788F44", Offset = "0x788F44", VA = "0x788F44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x788BE4", Offset = "0x788BE4", VA = "0x788BE4")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x788F48", Offset = "0x788F48", VA = "0x788F48")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x788F4C", Offset = "0x788F4C", VA = "0x788F4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x788FA8", Offset = "0x788FA8", VA = "0x788FA8")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7898DC", Offset = "0x7898DC", VA = "0x7898DC")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x789B60", Offset = "0x789B60", VA = "0x789B60")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x2000189")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x78A5F8", Offset = "0x78A5F8", VA = "0x78A5F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x78A640", Offset = "0x78A640", VA = "0x78A640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x78A42C", Offset = "0x78A42C", VA = "0x78A42C")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x78A47C", Offset = "0x78A47C", VA = "0x78A47C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x78A480", Offset = "0x78A480", VA = "0x78A480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x78A600", Offset = "0x78A600", VA = "0x78A600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000819")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x400081A")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x789C34", Offset = "0x789C34", VA = "0x789C34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x789CEC", Offset = "0x789CEC", VA = "0x789CEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x789D7C", Offset = "0x789D7C", VA = "0x789D7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x789EC4", Offset = "0x789EC4", VA = "0x789EC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x78A050", Offset = "0x78A050", VA = "0x78A050")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x78A160", Offset = "0x78A160", VA = "0x78A160")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x78A364", Offset = "0x78A364", VA = "0x78A364")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x78A270", Offset = "0x78A270", VA = "0x78A270")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x78A284", Offset = "0x78A284", VA = "0x78A284")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x78A3B8", Offset = "0x78A3B8", VA = "0x78A3B8")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x78A454", Offset = "0x78A454", VA = "0x78A454")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000B6")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x78A648", Offset = "0x78A648", VA = "0x78A648")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x78A658", Offset = "0x78A658", VA = "0x78A658", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x78A660", Offset = "0x78A660", VA = "0x78A660", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x78A990", Offset = "0x78A990", VA = "0x78A990")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000832")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000833")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000B7")]
		public float Distance
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x78AA94", Offset = "0x78AA94", VA = "0x78AA94")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x78AA9C", Offset = "0x78AA9C", VA = "0x78AA9C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public float Scale
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x78AAA4", Offset = "0x78AAA4", VA = "0x78AAA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x78AAAC", Offset = "0x78AAAC", VA = "0x78AAAC")]
			set
			{
			}
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x78A65C", Offset = "0x78A65C", VA = "0x78A65C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x78AAB4", Offset = "0x78AAB4", VA = "0x78AAB4")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x78A69C", Offset = "0x78A69C", VA = "0x78A69C")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x78A8AC", Offset = "0x78A8AC", VA = "0x78A8AC")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x60006FE")]
		public abstract void UpdatePosition();

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x78A9F0", Offset = "0x78A9F0", VA = "0x78A9F0")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x78B2D4", Offset = "0x78B2D4", VA = "0x78B2D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x78B31C", Offset = "0x78B31C", VA = "0x78B31C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x78AF48", Offset = "0x78AF48", VA = "0x78AF48")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x78B0BC", Offset = "0x78B0BC", VA = "0x78B0BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x78B0C0", Offset = "0x78B0C0", VA = "0x78B0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x78B2DC", Offset = "0x78B2DC", VA = "0x78B2DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x78AB74", Offset = "0x78AB74", VA = "0x78AB74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x78ABD0", Offset = "0x78ABD0", VA = "0x78ABD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x78ACA8", Offset = "0x78ACA8", VA = "0x78ACA8")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x78ADFC", Offset = "0x78ADFC", VA = "0x78ADFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x78AD04", Offset = "0x78AD04", VA = "0x78AD04")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x78AEC4", Offset = "0x78AEC4", VA = "0x78AEC4")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x78AF70", Offset = "0x78AF70", VA = "0x78AF70")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x78B008", Offset = "0x78B008", VA = "0x78B008")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x78B064", Offset = "0x78B064", VA = "0x78B064")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x200018F")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000870")]
			Start,
			[Token(Token = "0x4000871")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000872")]
			Stop
		}

		[Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x78CBC0", Offset = "0x78CBC0", VA = "0x78CBC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x78CC08", Offset = "0x78CC08", VA = "0x78CC08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x78C964", Offset = "0x78C964", VA = "0x78C964")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x78C98C", Offset = "0x78C98C", VA = "0x78C98C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x78C990", Offset = "0x78C990", VA = "0x78C990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x78CBC8", Offset = "0x78CBC8", VA = "0x78CBC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000852")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000853")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000854")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000855")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x78B324", Offset = "0x78B324", VA = "0x78B324")]
		private void Start()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x78B480", Offset = "0x78B480", VA = "0x78B480")]
		private void Update()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x78B48C", Offset = "0x78B48C", VA = "0x78B48C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x787BA0", Offset = "0x787BA0", VA = "0x787BA0")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x78B3F8", Offset = "0x78B3F8", VA = "0x78B3F8")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x78B5C4", Offset = "0x78B5C4", VA = "0x78B5C4")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x78B564", Offset = "0x78B564", VA = "0x78B564")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x787C2C", Offset = "0x787C2C", VA = "0x787C2C")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x787CBC", Offset = "0x787CBC", VA = "0x787CBC")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x78B7D8", Offset = "0x78B7D8", VA = "0x78B7D8")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x78B8CC", Offset = "0x78B8CC", VA = "0x78B8CC")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x787D4C", Offset = "0x787D4C", VA = "0x787D4C")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x787DF8", Offset = "0x787DF8", VA = "0x787DF8")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x787ED8", Offset = "0x787ED8", VA = "0x787ED8")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x78B908", Offset = "0x78B908", VA = "0x78B908")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000BD")]
		public float TrackLength
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x78CC10", Offset = "0x78CC10", VA = "0x78CC10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x78CC18", Offset = "0x78CC18", VA = "0x78CC18")]
			private set
			{
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x78CC20", Offset = "0x78CC20", VA = "0x78CC20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x78CDF0", Offset = "0x78CDF0", VA = "0x78CDF0")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x78CC24", Offset = "0x78CC24", VA = "0x78CC24")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x78CEA4", Offset = "0x78CEA4", VA = "0x78CEA4")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x78CF84", Offset = "0x78CF84", VA = "0x78CF84")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class Pose
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x78CFA0", Offset = "0x78CFA0", VA = "0x78CFA0")]
		public Pose()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x78D038", Offset = "0x78D038", VA = "0x78D038")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0x78D62C", Offset = "0x78D62C", VA = "0x78D62C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0x78D674", Offset = "0x78D674", VA = "0x78D674", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x78D314", Offset = "0x78D314", VA = "0x78D314")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x78D488", Offset = "0x78D488", VA = "0x78D488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x78D48C", Offset = "0x78D48C", VA = "0x78D48C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x78D634", Offset = "0x78D634", VA = "0x78D634", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x78D750", Offset = "0x78D750", VA = "0x78D750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000742")]
				[Address(RVA = "0x78D798", Offset = "0x78D798", VA = "0x78D798", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x78D3F0", Offset = "0x78D3F0", VA = "0x78D3F0")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x78D67C", Offset = "0x78D67C", VA = "0x78D67C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x78D680", Offset = "0x78D680", VA = "0x78D680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x78D758", Offset = "0x78D758", VA = "0x78D758", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000885")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000BE")]
		public bool IsMoving
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x78D09C", Offset = "0x78D09C", VA = "0x78D09C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x78D0A4", Offset = "0x78D0A4", VA = "0x78D0A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x78D0B0", Offset = "0x78D0B0", VA = "0x78D0B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x78D0E0", Offset = "0x78D0E0", VA = "0x78D0E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x78D220", Offset = "0x78D220", VA = "0x78D220")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x78D290", Offset = "0x78D290", VA = "0x78D290")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x78D33C", Offset = "0x78D33C", VA = "0x78D33C")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x78D418", Offset = "0x78D418", VA = "0x78D418")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x78D480", Offset = "0x78D480", VA = "0x78D480")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x78D7A0", Offset = "0x78D7A0", VA = "0x78D7A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x78D814", Offset = "0x78D814", VA = "0x78D814")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x78D8DC", Offset = "0x78D8DC", VA = "0x78D8DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x78D9EC", Offset = "0x78D9EC", VA = "0x78D9EC")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x78DA68", Offset = "0x78DA68", VA = "0x78DA68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x78DB34", Offset = "0x78DB34", VA = "0x78DB34")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40008A2")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40008A3")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40008A4")]
		EUDT_None,
		[Token(Token = "0x40008A5")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x2000198")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075C")]
				[Address(RVA = "0x78F1C4", Offset = "0x78F1C4", VA = "0x78F1C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x78F20C", Offset = "0x78F20C", VA = "0x78F20C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x78E854", Offset = "0x78E854", VA = "0x78E854")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x78EFC8", Offset = "0x78EFC8", VA = "0x78EFC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x78EFCC", Offset = "0x78EFCC", VA = "0x78EFCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x78F1CC", Offset = "0x78F1CC", VA = "0x78F1CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40008A7")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40008A8")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40008A9")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x78DB44", Offset = "0x78DB44", VA = "0x78DB44")]
		private void Start()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x78E384", Offset = "0x78E384", VA = "0x78E384")]
		private void Update()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x78E4AC", Offset = "0x78E4AC", VA = "0x78E4AC")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x78E5DC", Offset = "0x78E5DC", VA = "0x78E5DC")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x78E70C", Offset = "0x78E70C", VA = "0x78E70C")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x78E48C", Offset = "0x78E48C", VA = "0x78E48C")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x78E7E0", Offset = "0x78E7E0", VA = "0x78E7E0")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x78E87C", Offset = "0x78E87C", VA = "0x78E87C")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x78DFB4", Offset = "0x78DFB4", VA = "0x78DFB4")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x78E9C4", Offset = "0x78E9C4", VA = "0x78E9C4")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x78E8A4", Offset = "0x78E8A4", VA = "0x78E8A4")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x78ED4C", Offset = "0x78ED4C", VA = "0x78ED4C")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x78EE38", Offset = "0x78EE38", VA = "0x78EE38")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200019A")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x40008C1")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40008C2")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40008C3")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40008C4")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40008C5")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40008C6")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40008C7")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40008C8")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40008C9")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40008CA")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40008CB")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x78F214", Offset = "0x78F214", VA = "0x78F214")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x78F26C", Offset = "0x78F26C", VA = "0x78F26C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x78F6BC", Offset = "0x78F6BC", VA = "0x78F6BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x78F7A8", Offset = "0x78F7A8", VA = "0x78F7A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x78F90C", Offset = "0x78F90C", VA = "0x78F90C")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x78FBDC", Offset = "0x78FBDC", VA = "0x78FBDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x78FCC0", Offset = "0x78FCC0", VA = "0x78FCC0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x78FE70", Offset = "0x78FE70", VA = "0x78FE70")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x78F998", Offset = "0x78F998", VA = "0x78F998")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x78F9EC", Offset = "0x78F9EC", VA = "0x78F9EC")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x78F57C", Offset = "0x78F57C", VA = "0x78F57C")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x78FF94", Offset = "0x78FF94", VA = "0x78FF94")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public enum HandPoseId
	{
		[Token(Token = "0x40008E0")]
		Default,
		[Token(Token = "0x40008E1")]
		Generic,
		[Token(Token = "0x40008E2")]
		PingPongBall,
		[Token(Token = "0x40008E3")]
		Controller
	}
	[Token(Token = "0x200019D")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000C5")]
		public bool AllowPointing
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x79004C", Offset = "0x79004C", VA = "0x79004C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x790054", Offset = "0x790054", VA = "0x790054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x79005C", Offset = "0x79005C", VA = "0x79005C")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x790064", Offset = "0x790064", VA = "0x790064")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x79006C", Offset = "0x79006C", VA = "0x79006C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x790338", Offset = "0x790338", VA = "0x790338")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x790388", Offset = "0x790388", VA = "0x790388")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x7903C0", Offset = "0x7903C0", VA = "0x7903C0")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200019F")]
	public static class AvatarLogger
	{
		[Token(Token = "0x40008EA")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x40008EB")]
		public const string Tab = "    ";

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x7903C8", Offset = "0x7903C8", VA = "0x7903C8")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		[Conditional("ENABLE_AVATAR_LOG_BASIC")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x790454", Offset = "0x790454", VA = "0x790454")]
		[Conditional("ENABLE_AVATAR_LOG_BASIC")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x7904E8", Offset = "0x7904E8", VA = "0x7904E8")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		[Conditional("ENABLE_AVATAR_LOG_WARNING")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x790574", Offset = "0x790574", VA = "0x790574")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		[Conditional("ENABLE_AVATAR_LOG_ERROR")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x790600", Offset = "0x790600", VA = "0x790600")]
		[Conditional("ENABLE_AVATAR_LOGS")]
		[Conditional("ENABLE_AVATAR_LOG_ERROR")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class CAPI
	{
		[Token(Token = "0x20001A1")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x20001A2")]
		public enum Result
		{
			[Token(Token = "0x40008F7")]
			Success = 0,
			[Token(Token = "0x40008F8")]
			Failure = -1000,
			[Token(Token = "0x40008F9")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x40008FA")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x40008FB")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x40008FC")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x40008FD")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x40008FE")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x40008FF")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x20001A3")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x797B88", Offset = "0x797B88", VA = "0x797B88")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x40008EC")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x40008F4")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x7906EC", Offset = "0x7906EC", VA = "0x7906EC")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x790778", Offset = "0x790778", VA = "0x790778")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x790994", Offset = "0x790994", VA = "0x790994")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x790A6C", Offset = "0x790A6C", VA = "0x790A6C")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x790AD0", Offset = "0x790AD0", VA = "0x790AD0")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x790B38", Offset = "0x790B38", VA = "0x790B38")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x790BB4", Offset = "0x790BB4", VA = "0x790BB4")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x790CE4", Offset = "0x790CE4", VA = "0x790CE4")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x790D60", Offset = "0x790D60", VA = "0x790D60")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x790E90", Offset = "0x790E90", VA = "0x790E90")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x790F0C", Offset = "0x790F0C", VA = "0x790F0C")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x790F88", Offset = "0x790F88", VA = "0x790F88")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x791004", Offset = "0x791004", VA = "0x791004")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x791080", Offset = "0x791080", VA = "0x791080")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x791104", Offset = "0x791104", VA = "0x791104")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x791188", Offset = "0x791188", VA = "0x791188")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x79120C", Offset = "0x79120C", VA = "0x79120C")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x791288", Offset = "0x791288", VA = "0x791288")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x791304", Offset = "0x791304", VA = "0x791304")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x791388", Offset = "0x791388", VA = "0x791388")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x79140C", Offset = "0x79140C", VA = "0x79140C")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x791490", Offset = "0x791490", VA = "0x791490")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x79150C", Offset = "0x79150C", VA = "0x79150C")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x7915A0", Offset = "0x7915A0", VA = "0x7915A0")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x791608", Offset = "0x791608", VA = "0x791608")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x7916A4", Offset = "0x7916A4", VA = "0x7916A4")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x791758", Offset = "0x791758", VA = "0x791758")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x79181C", Offset = "0x79181C", VA = "0x79181C")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x7918A8", Offset = "0x7918A8", VA = "0x7918A8")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x79192C", Offset = "0x79192C", VA = "0x79192C")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x7919B0", Offset = "0x7919B0", VA = "0x7919B0")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x791A34", Offset = "0x791A34", VA = "0x791A34")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x791AB8", Offset = "0x791AB8", VA = "0x791AB8")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x791B34", Offset = "0x791B34", VA = "0x791B34")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x791C38", Offset = "0x791C38", VA = "0x791C38")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x791BB4", Offset = "0x791BB4", VA = "0x791BB4")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x791E24", Offset = "0x791E24", VA = "0x791E24")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x791F88", Offset = "0x791F88", VA = "0x791F88")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x60007A1")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x792004", Offset = "0x792004", VA = "0x792004")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x792298", Offset = "0x792298", VA = "0x792298")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x792314", Offset = "0x792314", VA = "0x792314")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x792478", Offset = "0x792478", VA = "0x792478")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x7924F4", Offset = "0x7924F4", VA = "0x7924F4")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x792658", Offset = "0x792658", VA = "0x792658")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x7926D4", Offset = "0x7926D4", VA = "0x7926D4")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x792838", Offset = "0x792838", VA = "0x792838")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x7928B4", Offset = "0x7928B4", VA = "0x7928B4")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x792A18", Offset = "0x792A18", VA = "0x792A18")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x792A94", Offset = "0x792A94", VA = "0x792A94")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x792B10", Offset = "0x792B10", VA = "0x792B10")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x792B9C", Offset = "0x792B9C", VA = "0x792B9C")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x792C18", Offset = "0x792C18", VA = "0x792C18")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x792DD0", Offset = "0x792DD0", VA = "0x792DD0")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x792F0C", Offset = "0x792F0C", VA = "0x792F0C")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x792D54", Offset = "0x792D54", VA = "0x792D54")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x792F88", Offset = "0x792F88", VA = "0x792F88")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x793004", Offset = "0x793004", VA = "0x793004")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x793088", Offset = "0x793088", VA = "0x793088")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x793104", Offset = "0x793104", VA = "0x793104")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x793188", Offset = "0x793188", VA = "0x793188")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x793204", Offset = "0x793204", VA = "0x793204")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x793280", Offset = "0x793280", VA = "0x793280")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x7934C8", Offset = "0x7934C8", VA = "0x7934C8")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x79354C", Offset = "0x79354C", VA = "0x79354C")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x793760", Offset = "0x793760", VA = "0x793760")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x7937F4", Offset = "0x7937F4", VA = "0x7937F4")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x793928", Offset = "0x793928", VA = "0x793928")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x7939A4", Offset = "0x7939A4", VA = "0x7939A4")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x793A20", Offset = "0x793A20", VA = "0x793A20")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x793B58", Offset = "0x793B58", VA = "0x793B58")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x793BD4", Offset = "0x793BD4", VA = "0x793BD4")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x793D0C", Offset = "0x793D0C", VA = "0x793D0C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x793D88", Offset = "0x793D88", VA = "0x793D88")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x793E0C", Offset = "0x793E0C", VA = "0x793E0C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x793E90", Offset = "0x793E90", VA = "0x793E90")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x793F14", Offset = "0x793F14", VA = "0x793F14")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x793F90", Offset = "0x793F90", VA = "0x793F90")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x794014", Offset = "0x794014", VA = "0x794014")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x794098", Offset = "0x794098", VA = "0x794098")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x794114", Offset = "0x794114", VA = "0x794114")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x794190", Offset = "0x794190", VA = "0x794190")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x794240", Offset = "0x794240", VA = "0x794240")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x7942C4", Offset = "0x7942C4", VA = "0x7942C4")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x794348", Offset = "0x794348", VA = "0x794348")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x7943C4", Offset = "0x7943C4", VA = "0x7943C4")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x794440", Offset = "0x794440", VA = "0x794440")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x7944BC", Offset = "0x7944BC", VA = "0x7944BC")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x794550", Offset = "0x794550", VA = "0x794550")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x7945DC", Offset = "0x7945DC", VA = "0x7945DC")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x794668", Offset = "0x794668", VA = "0x794668")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x7946F4", Offset = "0x7946F4", VA = "0x7946F4")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x794788", Offset = "0x794788", VA = "0x794788")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x79481C", Offset = "0x79481C", VA = "0x79481C")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x794898", Offset = "0x794898", VA = "0x794898")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x794914", Offset = "0x794914", VA = "0x794914")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x794A4C", Offset = "0x794A4C", VA = "0x794A4C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x794AC8", Offset = "0x794AC8", VA = "0x794AC8")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x794C00", Offset = "0x794C00", VA = "0x794C00")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x794C7C", Offset = "0x794C7C", VA = "0x794C7C")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x794D9C", Offset = "0x794D9C", VA = "0x794D9C")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x794E18", Offset = "0x794E18", VA = "0x794E18")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x794FCC", Offset = "0x794FCC", VA = "0x794FCC")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x795274", Offset = "0x795274", VA = "0x795274")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x794F50", Offset = "0x794F50", VA = "0x794F50")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x7952F8", Offset = "0x7952F8", VA = "0x7952F8")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x795374", Offset = "0x795374", VA = "0x795374")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x7953F8", Offset = "0x7953F8", VA = "0x7953F8")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x79547C", Offset = "0x79547C", VA = "0x79547C")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x795500", Offset = "0x795500", VA = "0x795500")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x79559C", Offset = "0x79559C", VA = "0x79559C")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x795638", Offset = "0x795638", VA = "0x795638")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x7956CC", Offset = "0x7956CC", VA = "0x7956CC")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x795748", Offset = "0x795748", VA = "0x795748")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x7957C4", Offset = "0x7957C4", VA = "0x7957C4")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x795840", Offset = "0x795840", VA = "0x795840")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x7958BC", Offset = "0x7958BC", VA = "0x7958BC")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x795938", Offset = "0x795938", VA = "0x795938")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x795A5C", Offset = "0x795A5C", VA = "0x795A5C")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x795AE8", Offset = "0x795AE8", VA = "0x795AE8")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x795B64", Offset = "0x795B64", VA = "0x795B64")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x795BB8", Offset = "0x795BB8", VA = "0x795BB8")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x795CEC", Offset = "0x795CEC", VA = "0x795CEC")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x795D70", Offset = "0x795D70", VA = "0x795D70")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x795EA4", Offset = "0x795EA4", VA = "0x795EA4")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x795F28", Offset = "0x795F28", VA = "0x795F28")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x795FBC", Offset = "0x795FBC", VA = "0x795FBC")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x7962F4", Offset = "0x7962F4", VA = "0x7962F4")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x796370", Offset = "0x796370", VA = "0x796370")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x7963FC", Offset = "0x7963FC", VA = "0x7963FC")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x796B50", Offset = "0x796B50", VA = "0x796B50")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x796BCC", Offset = "0x796BCC", VA = "0x796BCC")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x790694", Offset = "0x790694", VA = "0x790694")]
		[MonoPInvokeCallback(typeof(LoggingDelegate))]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x796C58", Offset = "0x796C58", VA = "0x796C58")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x796CD8", Offset = "0x796CD8", VA = "0x796CD8")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x796D54", Offset = "0x796D54", VA = "0x796D54")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x796DD0", Offset = "0x796DD0", VA = "0x796DD0")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x796E4C", Offset = "0x796E4C", VA = "0x796E4C")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x7977A4", Offset = "0x7977A4", VA = "0x7977A4")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x797820", Offset = "0x797820", VA = "0x797820")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x797C60", Offset = "0x797C60", VA = "0x797C60")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x797B04", Offset = "0x797B04", VA = "0x797B04")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x797CC8", Offset = "0x797CC8", VA = "0x797CC8")]
		public CAPI()
		{
		}
	}
}
namespace LowPolyWater
{
	[Token(Token = "0x20001A4")]
	public class LowPolyWater : MonoBehaviour
	{
		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float waveHeight;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float waveFrequency;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waveLength;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 waveOriginPosition;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Mesh mesh;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] vertices;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x797FA8", Offset = "0x797FA8", VA = "0x797FA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x798000", Offset = "0x798000", VA = "0x798000")]
		private void Start()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x798008", Offset = "0x798008", VA = "0x798008")]
		private MeshFilter CreateMeshLowPoly(MeshFilter mf)
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x7981A8", Offset = "0x7981A8", VA = "0x7981A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x7981AC", Offset = "0x7981AC", VA = "0x7981AC")]
		private void GenerateWaves()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x798350", Offset = "0x798350", VA = "0x798350")]
		public LowPolyWater()
		{
		}
	}
}
namespace BrokenVector.LowPolyFencePack
{
	[Token(Token = "0x20001A5")]
	[RequireComponent(typeof(Animation))]
	public class DoorController : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		public enum DoorState
		{
			[Token(Token = "0x400090F")]
			Open,
			[Token(Token = "0x4000910")]
			Closed
		}

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DoorState InitialState;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float AnimationSpeed;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationClip openAnimation;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip closeAnimation;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animation animator;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DoorState currentState;

		[Token(Token = "0x170000C8")]
		public DoorState CurrentState
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x798368", Offset = "0x798368", VA = "0x798368")]
			get
			{
				return default(DoorState);
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x798370", Offset = "0x798370", VA = "0x798370")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsDoorOpen
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x7983D4", Offset = "0x7983D4", VA = "0x7983D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsDoorClosed
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x7983E4", Offset = "0x7983E4", VA = "0x7983E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x7983F4", Offset = "0x7983F4", VA = "0x7983F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x7985C8", Offset = "0x7985C8", VA = "0x7985C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x798698", Offset = "0x798698", VA = "0x798698")]
		public void CloseDoor()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x7986B4", Offset = "0x7986B4", VA = "0x7986B4")]
		public void OpenDoor()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x7986C8", Offset = "0x7986C8", VA = "0x7986C8")]
		public void ToggleDoor()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x798378", Offset = "0x798378", VA = "0x798378")]
		private void Animate()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x798630", Offset = "0x798630", VA = "0x798630")]
		private string GetCurrentAnimation()
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x7986DC", Offset = "0x7986DC", VA = "0x7986DC")]
		public DoorController()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[RequireComponent(typeof(DoorController))]
	public class DoorToggle : MonoBehaviour
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DoorController doorController;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x7986F0", Offset = "0x7986F0", VA = "0x7986F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x798748", Offset = "0x798748", VA = "0x798748")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x798760", Offset = "0x798760", VA = "0x798760")]
		public DoorToggle()
		{
		}
	}
}
namespace DitzelGames.FastIK
{
	[Token(Token = "0x20001A8")]
	public class FastIKFabric : MonoBehaviour
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int ChainLength;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Target;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Pole;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Solver Parameters")]
		public int Iterations;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Delta;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float SnapBackStrength;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float[] BonesLength;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected float CompleteLength;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] Bones;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3[] Positions;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3[] StartDirectionSucc;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Quaternion[] StartRotationBone;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Quaternion StartRotationTarget;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Transform Root;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x798768", Offset = "0x798768", VA = "0x798768")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x79876C", Offset = "0x79876C", VA = "0x79876C")]
		private void Init()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x799070", Offset = "0x799070", VA = "0x799070")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x799074", Offset = "0x799074", VA = "0x799074")]
		private void ResolveIK()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x798D04", Offset = "0x798D04", VA = "0x798D04")]
		private Vector3 GetPositionRootSpace(Transform current)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x798E3C", Offset = "0x798E3C", VA = "0x798E3C")]
		private void SetPositionRootSpace(Transform current, Vector3 position)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x798F3C", Offset = "0x798F3C", VA = "0x798F3C")]
		private Quaternion GetRotationRootSpace(Transform current)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x799E30", Offset = "0x799E30", VA = "0x799E30")]
		private void SetRotationRootSpace(Transform current, Quaternion rotation)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x799F6C", Offset = "0x799F6C", VA = "0x799F6C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x799F70", Offset = "0x799F70", VA = "0x799F70")]
		public FastIKFabric()
		{
		}
	}
}
