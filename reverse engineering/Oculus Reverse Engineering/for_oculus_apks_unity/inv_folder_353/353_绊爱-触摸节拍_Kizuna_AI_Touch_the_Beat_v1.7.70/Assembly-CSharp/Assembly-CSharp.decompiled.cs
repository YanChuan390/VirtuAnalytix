using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Assets.RATOBA_LIVE.Scripts.DrivenKey;
using Common;
using Game;
using Game.MiniChara;
using Game.SpecialNote;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using Trancer;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class ScreenshotTool
{
	[Token(Token = "0x4000001")]
	private const string FOLDER_NAME = "Screenshot";

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7B1B74", Offset = "0x7B1B74", VA = "0x7B1B74")]
	public static void Capture()
	{
	}
}
[Token(Token = "0x2000003")]
public static class Extention
{
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7B1C94", Offset = "0x7B1C94", VA = "0x7B1C94")]
	public static bool IsNullOrEmpty(this string self)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	public static List<T> SafeAdd<T>(this List<T> self, T add)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	public static List<T> SafeRemove<T>(this List<T> self, T remove)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7B1C9C", Offset = "0x7B1C9C", VA = "0x7B1C9C")]
	public static void AttachParent(this Transform self, Transform parent)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7B1D84", Offset = "0x7B1D84", VA = "0x7B1D84")]
	public static Transform FindParent(this Transform self, string name)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7B1E2C", Offset = "0x7B1E2C", VA = "0x7B1E2C")]
	public static Transform FindInChildren(this Transform self, string name)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public class AudioLineRenderer : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	private const uint SAMPLE_MIN = 2u;

	[Token(Token = "0x4000003")]
	private const uint SAMPLE_MAX = 4096u;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Range(2f, 4096f)]
	private uint m_audioSampleNum;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector2 m_size;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioSource m_audioSource;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LineRenderer[] m_lineRenderers;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] m_dataArray;

	[Token(Token = "0x17000001")]
	public uint audioSampleNum
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x7B1F20", Offset = "0x7B1F20", VA = "0x7B1F20")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000002")]
	public Vector2 size
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7B1F28", Offset = "0x7B1F28", VA = "0x7B1F28")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7B1F2C", Offset = "0x7B1F2C", VA = "0x7B1F2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7B1F84", Offset = "0x7B1F84", VA = "0x7B1F84")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7B20CC", Offset = "0x7B20CC", VA = "0x7B20CC")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7B20F4", Offset = "0x7B20F4", VA = "0x7B20F4")]
	public void SetLineColor(Gradient m_color)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7B215C", Offset = "0x7B215C", VA = "0x7B215C")]
	public AudioLineRenderer()
	{
	}
}
[Token(Token = "0x2000005")]
public class MatAlphaMoveComponent : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	public enum ComponentType
	{
		[Token(Token = "0x4000015")]
		Sprite,
		[Token(Token = "0x4000016")]
		Image,
		[Token(Token = "0x4000017")]
		Mesh
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ComponentType m_type;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_shaderColorName;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_max;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_min;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_speed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool m_isInitMatColor;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_timer;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_mat;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color m_color;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_shaderId;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Image m_image;

	[Token(Token = "0x17000003")]
	public Color CurrentColor
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x7B2178", Offset = "0x7B2178", VA = "0x7B2178")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7B2184", Offset = "0x7B2184", VA = "0x7B2184")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7B22C4", Offset = "0x7B22C4", VA = "0x7B22C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7B23A4", Offset = "0x7B23A4", VA = "0x7B23A4")]
	public void SetColor(Color rgb)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7B23B0", Offset = "0x7B23B0", VA = "0x7B23B0")]
	public void SetColor(float r, float g, float b)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7B23BC", Offset = "0x7B23BC", VA = "0x7B23BC")]
	public MatAlphaMoveComponent()
	{
	}
}
[Token(Token = "0x2000007")]
public class NotesRotationComponent : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	private const float SPEED = 2f;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_isRotateX;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool m_isRotateY;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool m_isRotateZ;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NotesRotationComponent m_parent;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 m_rotation;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7B2438", Offset = "0x7B2438", VA = "0x7B2438")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7B251C", Offset = "0x7B251C", VA = "0x7B251C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7B25A0", Offset = "0x7B25A0", VA = "0x7B25A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x7B25CC", Offset = "0x7B25CC", VA = "0x7B25CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7B2680", Offset = "0x7B2680", VA = "0x7B2680")]
	public Vector3 GetRotationSpeed()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x7B268C", Offset = "0x7B268C", VA = "0x7B268C")]
	public NotesRotationComponent()
	{
	}
}
[Token(Token = "0x2000008")]
public abstract class StageGimmickInitializer : MonoBehaviour
{
	[Token(Token = "0x600001B")]
	public abstract void Initialize();

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7B26A4", Offset = "0x7B26A4", VA = "0x7B26A4")]
	protected StageGimmickInitializer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class AngleDriverData
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string applicationVersion;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string author;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AngleDriverDriver> datalist;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string application;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string version;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string creationData;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7B26AC", Offset = "0x7B26AC", VA = "0x7B26AC")]
	public AngleDriverData()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class AngleDriverDriver
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string driver;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> localMatrix;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7B26B4", Offset = "0x7B26B4", VA = "0x7B26B4")]
	public AngleDriverDriver()
	{
	}
}
[Token(Token = "0x200000B")]
public class DrivenKeyController : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	public enum Translate
	{
		[Token(Token = "0x400002D")]
		translateX,
		[Token(Token = "0x400002E")]
		translateY,
		[Token(Token = "0x400002F")]
		translateZ,
		[Token(Token = "0x4000030")]
		rotateX,
		[Token(Token = "0x4000031")]
		rotateY,
		[Token(Token = "0x4000032")]
		rotateZ,
		[Token(Token = "0x4000033")]
		scaleX,
		[Token(Token = "0x4000034")]
		scaleY,
		[Token(Token = "0x4000035")]
		scaleZ
	}

	[Token(Token = "0x200000D")]
	public enum AngleDriver
	{
		[Token(Token = "0x4000037")]
		angle2XZ,
		[Token(Token = "0x4000038")]
		angle2YX,
		[Token(Token = "0x4000039")]
		angle2ZY
	}

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AngleDriverPresenter _driver;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AngleDriver _angleDriver;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AnimationCurve _drivenCurve;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Transform _target;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Translate _targetTranslate;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7B26BC", Offset = "0x7B26BC", VA = "0x7B26BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7B2848", Offset = "0x7B2848", VA = "0x7B2848")]
	private void OnDriverChanged(Vector3 vec)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7B2A98", Offset = "0x7B2A98", VA = "0x7B2A98")]
	public void Init(DrivenKeyDriver data)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7B2FD0", Offset = "0x7B2FD0", VA = "0x7B2FD0")]
	public DrivenKeyController()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class DrivenKeyData
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string applicationVersion;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string author;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<DrivenKeyDriver> datalist;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string application;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string version;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string creationData;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7B2FD8", Offset = "0x7B2FD8", VA = "0x7B2FD8")]
	public DrivenKeyData()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class DrivenKeyDriver
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<DrivenKeyElement> keyData;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> driver;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string target;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7B2FE0", Offset = "0x7B2FE0", VA = "0x7B2FE0")]
	public DrivenKeyDriver()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class DrivenKeyElement
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<float> inWeight;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<float> inTangentX;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> outTangentY;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<float> value;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<float> outWeight;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<float> time;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<float> outTangentX;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<float> inTangentY;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<float> outAngle;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<float> inAngle;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7B2FE8", Offset = "0x7B2FE8", VA = "0x7B2FE8")]
	public DrivenKeyElement()
	{
	}
}
[Token(Token = "0x2000011")]
public class HalfRotaterController : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform driver;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Quaternion startRotation;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Transform target;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float weight;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7B2FF0", Offset = "0x7B2FF0", VA = "0x7B2FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x7B3040", Offset = "0x7B3040", VA = "0x7B3040")]
	private void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7B3134", Offset = "0x7B3134", VA = "0x7B3134")]
	public void Init(HalfRotaterDriver data)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7B3188", Offset = "0x7B3188", VA = "0x7B3188")]
	public HalfRotaterController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class HalfRotaterData
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string applicationVersion;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string author;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<HalfRotaterDriver> datalist;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string application;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string version;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string creationData;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7B3198", Offset = "0x7B3198", VA = "0x7B3198")]
	public HalfRotaterData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class HalfRotaterDriver
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string driver;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string target;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float weight;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7B31A0", Offset = "0x7B31A0", VA = "0x7B31A0")]
	public HalfRotaterDriver()
	{
	}
}
[Token(Token = "0x2000014")]
public class DynamicBoneDemo1 : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Player;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_weight;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_sleepTime;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7B31A8", Offset = "0x7B31A8", VA = "0x7B31A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7B32EC", Offset = "0x7B32EC", VA = "0x7B32EC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7B3740", Offset = "0x7B3740", VA = "0x7B3740")]
	public DynamicBoneDemo1()
	{
	}
}
[Token(Token = "0x2000015")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000081")]
		Normal,
		[Token(Token = "0x4000082")]
		AnimatePhysics,
		[Token(Token = "0x4000083")]
		UnscaledTime,
		[Token(Token = "0x4000084")]
		Default
	}

	[Token(Token = "0x2000017")]
	public enum FreezeAxis
	{
		[Token(Token = "0x4000086")]
		None,
		[Token(Token = "0x4000087")]
		X,
		[Token(Token = "0x4000088")]
		Y,
		[Token(Token = "0x4000089")]
		Z
	}

	[Token(Token = "0x2000018")]
	private class Particle
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Damping;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Elasticity;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Stiffness;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Inert;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Friction;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_Radius;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_BoneLength;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool m_isCollide;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 m_Position;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7B5A74", Offset = "0x7B5A74", VA = "0x7B5A74")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The root of the transform hierarchy to apply physics.")]
	public Transform m_Root;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("How much the bones slowed down.")]
	public float m_Damping;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("How much the force applied to return each bone to original orientation.")]
	[Range(0f, 1f)]
	public float m_Elasticity;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How much bone's original orientation are preserved.")]
	[Range(0f, 1f)]
	public float m_Stiffness;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("How much character's position change is ignored in physics simulation.")]
	[Range(0f, 1f)]
	public float m_Inert;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve m_FrictionDistrib;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Tooltip("Constrain bones to move on specified plane.")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float m_DistanceToObject;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 m_LocalGravity;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float m_BoneTotalLength;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float m_ObjectScale;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float m_Time;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float m_Weight;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool m_DistantDisabled;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private Vector3 m_GravityNormal;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<Particle> m_Particles;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7B3750", Offset = "0x7B3750", VA = "0x7B3750")]
	private void Start()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7B3998", Offset = "0x7B3998", VA = "0x7B3998")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7B39EC", Offset = "0x7B39EC", VA = "0x7B39EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7B3A1C", Offset = "0x7B3A1C", VA = "0x7B3A1C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7B39C8", Offset = "0x7B39C8", VA = "0x7B39C8")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7B3A84", Offset = "0x7B3A84", VA = "0x7B3A84")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7B4058", Offset = "0x7B4058", VA = "0x7B4058")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7B405C", Offset = "0x7B405C", VA = "0x7B405C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7B4060", Offset = "0x7B4060", VA = "0x7B4060")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7B4120", Offset = "0x7B4120", VA = "0x7B4120")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7B36F0", Offset = "0x7B36F0", VA = "0x7B36F0")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7B42B0", Offset = "0x7B42B0", VA = "0x7B42B0")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7B3BFC", Offset = "0x7B3BFC", VA = "0x7B3BFC")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7B382C", Offset = "0x7B382C", VA = "0x7B382C")]
	public void SetupParticles()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7B51F8", Offset = "0x7B51F8", VA = "0x7B51F8")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7B5768", Offset = "0x7B5768", VA = "0x7B5768")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7B3E08", Offset = "0x7B3E08", VA = "0x7B3E08")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7B3F0C", Offset = "0x7B3F0C", VA = "0x7B3F0C")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7B42B8", Offset = "0x7B42B8", VA = "0x7B42B8")]
	private void UpdateParticles1(float timeVar)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7B4490", Offset = "0x7B4490", VA = "0x7B4490")]
	private void UpdateParticles2(float timeVar)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7B4AF8", Offset = "0x7B4AF8", VA = "0x7B4AF8")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7B5B50", Offset = "0x7B5B50", VA = "0x7B5B50")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x7B4F9C", Offset = "0x7B4F9C", VA = "0x7B4F9C")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x7B5B84", Offset = "0x7B5B84", VA = "0x7B5B84")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x2000019")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The height of the capsule.")]
	public float m_Height;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x7B5CE4", Offset = "0x7B5CE4", VA = "0x7B5CE4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x7B5CFC", Offset = "0x7B5CFC", VA = "0x7B5CFC", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x7B5EF0", Offset = "0x7B5EF0", VA = "0x7B5EF0")]
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x7B5F5C", Offset = "0x7B5F5C", VA = "0x7B5F5C")]
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7B5FC0", Offset = "0x7B5FC0", VA = "0x7B5FC0")]
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7B6150", Offset = "0x7B6150", VA = "0x7B6150")]
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7B62B8", Offset = "0x7B62B8", VA = "0x7B62B8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7B6454", Offset = "0x7B6454", VA = "0x7B6454")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x200001A")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	public enum Direction
	{
		[Token(Token = "0x400009F")]
		X,
		[Token(Token = "0x40000A0")]
		Y,
		[Token(Token = "0x40000A1")]
		Z
	}

	[Token(Token = "0x200001C")]
	public enum Bound
	{
		[Token(Token = "0x40000A3")]
		Outside,
		[Token(Token = "0x40000A4")]
		Inside
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The axis of the capsule's height.")]
	public Direction m_Direction;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public Bound m_Bound;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x7B64C4", Offset = "0x7B64C4", VA = "0x7B64C4", Slot = "4")]
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7B6460", Offset = "0x7B6460", VA = "0x7B6460")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x200001D")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7B64CC", Offset = "0x7B64CC", VA = "0x7B64CC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7B64D0", Offset = "0x7B64D0", VA = "0x7B64D0", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7B6660", Offset = "0x7B6660", VA = "0x7B6660")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7B67C0", Offset = "0x7B67C0", VA = "0x7B67C0")]
	public DynamicBonePlaneCollider()
	{
	}
}
[Token(Token = "0x200001E")]
public class InputName
{
	[Token(Token = "0x40000A5")]
	public const string Horizontal = "Horizontal";

	[Token(Token = "0x40000A6")]
	public const string Vertical = "Vertical";

	[Token(Token = "0x40000A7")]
	public const string Submit = "Submit";

	[Token(Token = "0x40000A8")]
	public const string Decide = "Decide";

	[Token(Token = "0x40000A9")]
	public const string Cancel = "Cancel";

	[Token(Token = "0x40000AA")]
	public const string Move = "Move";

	[Token(Token = "0x40000AB")]
	public const string Pointing = "Pointing";

	[Token(Token = "0x40000AC")]
	public const string Debug = "Debug";

	[Token(Token = "0x40000AD")]
	public const string ChangeMove = "ChangeMove";

	[Token(Token = "0x40000AE")]
	public const string MouseX = "Mouse X";

	[Token(Token = "0x40000AF")]
	public const string MouseY = "Mouse Y";

	[Token(Token = "0x40000B0")]
	public const string MouseScrollWheel = "Mouse ScrollWheel";

	[Token(Token = "0x40000B1")]
	public const string Oculus_CrossPlatform_Button2 = "Oculus_CrossPlatform_Button2";

	[Token(Token = "0x40000B2")]
	public const string Oculus_CrossPlatform_Button4 = "Oculus_CrossPlatform_Button4";

	[Token(Token = "0x40000B3")]
	public const string Oculus_CrossPlatform_PrimaryThumbstick = "Oculus_CrossPlatform_PrimaryThumbstick";

	[Token(Token = "0x40000B4")]
	public const string Oculus_CrossPlatform_SecondaryThumbstick = "Oculus_CrossPlatform_SecondaryThumbstick";

	[Token(Token = "0x40000B5")]
	public const string Oculus_CrossPlatform_PrimaryIndexTrigger = "Oculus_CrossPlatform_PrimaryIndexTrigger";

	[Token(Token = "0x40000B6")]
	public const string Oculus_CrossPlatform_SecondaryIndexTrigger = "Oculus_CrossPlatform_SecondaryIndexTrigger";

	[Token(Token = "0x40000B7")]
	public const string Oculus_CrossPlatform_PrimaryHandTrigger = "Oculus_CrossPlatform_PrimaryHandTrigger";

	[Token(Token = "0x40000B8")]
	public const string Oculus_CrossPlatform_SecondaryHandTrigger = "Oculus_CrossPlatform_SecondaryHandTrigger";

	[Token(Token = "0x40000B9")]
	public const string Oculus_CrossPlatform_PrimaryThumbstickHorizontal = "Oculus_CrossPlatform_PrimaryThumbstickHorizontal";

	[Token(Token = "0x40000BA")]
	public const string Oculus_CrossPlatform_PrimaryThumbstickVertical = "Oculus_CrossPlatform_PrimaryThumbstickVertical";

	[Token(Token = "0x40000BB")]
	public const string Oculus_CrossPlatform_SecondaryThumbstickHorizontal = "Oculus_CrossPlatform_SecondaryThumbstickHorizontal";

	[Token(Token = "0x40000BC")]
	public const string Oculus_CrossPlatform_SecondaryThumbstickVertical = "Oculus_CrossPlatform_SecondaryThumbstickVertical";

	[Token(Token = "0x40000BD")]
	public const string EnableDebugButton1 = "Enable Debug Button 1";

	[Token(Token = "0x40000BE")]
	public const string EnableDebugButton2 = "Enable Debug Button 2";

	[Token(Token = "0x40000BF")]
	public const string DebugReset = "Debug Reset";

	[Token(Token = "0x40000C0")]
	public const string DebugNext = "Debug Next";

	[Token(Token = "0x40000C1")]
	public const string DebugPrevious = "Debug Previous";

	[Token(Token = "0x40000C2")]
	public const string DebugValidate = "Debug Validate";

	[Token(Token = "0x40000C3")]
	public const string DebugPersistent = "Debug Persistent";

	[Token(Token = "0x40000C4")]
	public const string DebugMultiplier = "Debug Multiplier";

	[Token(Token = "0x40000C5")]
	public const string DebugHorizontal = "Debug Horizontal";

	[Token(Token = "0x40000C6")]
	public const string DebugVertical = "Debug Vertical";

	[Token(Token = "0x40000C7")]
	public const string leftstick1horizontal = "leftstick1horizontal";

	[Token(Token = "0x40000C8")]
	public const string leftstick1vertical = "leftstick1vertical";

	[Token(Token = "0x40000C9")]
	public const string rightstick1horizontal = "rightstick1horizontal";

	[Token(Token = "0x40000CA")]
	public const string rightstick1vertical = "rightstick1vertical";

	[Token(Token = "0x40000CB")]
	public const string joystick1_left_trigger = "joystick1_left_trigger";

	[Token(Token = "0x40000CC")]
	public const string joystick1_right_trigger = "joystick1_right_trigger";

	[Token(Token = "0x40000CD")]
	public const string dpad1_horizontal = "dpad1_horizontal";

	[Token(Token = "0x40000CE")]
	public const string dpad1_vertical = "dpad1_vertical";

	[Token(Token = "0x40000CF")]
	public const string leftstick2horizontal = "leftstick2horizontal";

	[Token(Token = "0x40000D0")]
	public const string leftstick2vertical = "leftstick2vertical";

	[Token(Token = "0x40000D1")]
	public const string rightstick2horizontal = "rightstick2horizontal";

	[Token(Token = "0x40000D2")]
	public const string rightstick2vertical = "rightstick2vertical";

	[Token(Token = "0x40000D3")]
	public const string joystick2_left_trigger = "joystick2_left_trigger";

	[Token(Token = "0x40000D4")]
	public const string joystick2_right_trigger = "joystick2_right_trigger";

	[Token(Token = "0x40000D5")]
	public const string dpad2_horizontal = "dpad2_horizontal";

	[Token(Token = "0x40000D6")]
	public const string dpad2_vertical = "dpad2_vertical";

	[Token(Token = "0x40000D7")]
	public const string leftstick3horizontal = "leftstick3horizontal";

	[Token(Token = "0x40000D8")]
	public const string leftstick3vertical = "leftstick3vertical";

	[Token(Token = "0x40000D9")]
	public const string rightstick3horizontal = "rightstick3horizontal";

	[Token(Token = "0x40000DA")]
	public const string rightstick3vertical = "rightstick3vertical";

	[Token(Token = "0x40000DB")]
	public const string joystick3_left_trigger = "joystick3_left_trigger";

	[Token(Token = "0x40000DC")]
	public const string joystick3_right_trigger = "joystick3_right_trigger";

	[Token(Token = "0x40000DD")]
	public const string dpad3_horizontal = "dpad3_horizontal";

	[Token(Token = "0x40000DE")]
	public const string dpad3_vertical = "dpad3_vertical";

	[Token(Token = "0x40000DF")]
	public const string leftstick4horizontal = "leftstick4horizontal";

	[Token(Token = "0x40000E0")]
	public const string leftstick4vertical = "leftstick4vertical";

	[Token(Token = "0x40000E1")]
	public const string rightstick4horizontal = "rightstick4horizontal";

	[Token(Token = "0x40000E2")]
	public const string rightstick4vertical = "rightstick4vertical";

	[Token(Token = "0x40000E3")]
	public const string joystick4_left_trigger = "joystick4_left_trigger";

	[Token(Token = "0x40000E4")]
	public const string joystick4_right_trigger = "joystick4_right_trigger";

	[Token(Token = "0x40000E5")]
	public const string dpad4_horizontal = "dpad4_horizontal";

	[Token(Token = "0x40000E6")]
	public const string dpad4_vertical = "dpad4_vertical";

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] names;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7B67C4", Offset = "0x7B67C4", VA = "0x7B67C4")]
	public InputName()
	{
	}
}
[Token(Token = "0x200001F")]
public class LayerName
{
	[Token(Token = "0x40000E8")]
	public const string Default = "Default";

	[Token(Token = "0x40000E9")]
	public const string TransparentFX = "TransparentFX";

	[Token(Token = "0x40000EA")]
	public const string IgnoreRaycast = "Ignore Raycast";

	[Token(Token = "0x40000EB")]
	public const string Water = "Water";

	[Token(Token = "0x40000EC")]
	public const string UI = "UI";

	[Token(Token = "0x40000ED")]
	public const string PostProcessing = "PostProcessing";

	[Token(Token = "0x40000EE")]
	public const string Floor = "Floor";

	[Token(Token = "0x40000EF")]
	public const string Wall = "Wall";

	[Token(Token = "0x40000F0")]
	public const string CanTouch = "CanTouch";

	[Token(Token = "0x40000F1")]
	public const string Character = "Character";

	[Token(Token = "0x40000F2")]
	public const string OtherLight_01 = "OtherLight_01";

	[Token(Token = "0x40000F3")]
	public const string OtherLight_02 = "OtherLight_02";

	[Token(Token = "0x40000F4")]
	public const string OtherLight_03 = "OtherLight_03";

	[Token(Token = "0x40000F5")]
	public const string RayOnly = "RayOnly";

	[Token(Token = "0x40000F6")]
	public const string NotReflection = "NotReflection";

	[Token(Token = "0x40000F7")]
	public const string Movie = "Movie";

	[Token(Token = "0x40000F8")]
	public const string Notes = "Notes";

	[Token(Token = "0x40000F9")]
	public const string Game0 = "Game0";

	[Token(Token = "0x40000FA")]
	public const string Game1 = "Game1";

	[Token(Token = "0x40000FB")]
	public const string Game2 = "Game2";

	[Token(Token = "0x40000FC")]
	public const string NotMainCamera = "NotMainCamera";

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] names;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7B813C", Offset = "0x7B813C", VA = "0x7B813C")]
	public LayerName()
	{
	}
}
[Token(Token = "0x2000020")]
public class SceneName
{
	[Token(Token = "0x40000FE")]
	public const string Boot = "Boot";

	[Token(Token = "0x40000FF")]
	public const string Empty = "Empty";

	[Token(Token = "0x4000100")]
	public const string Title = "Title";

	[Token(Token = "0x4000101")]
	public const string Music00 = "Music00";

	[Token(Token = "0x4000102")]
	public const string Music01 = "Music01";

	[Token(Token = "0x4000103")]
	public const string Credit = "Credit";

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] names;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7B8960", Offset = "0x7B8960", VA = "0x7B8960")]
	public SceneName()
	{
	}
}
[Token(Token = "0x2000021")]
public class TagName
{
	[Token(Token = "0x4000105")]
	public const string Untagged = "Untagged";

	[Token(Token = "0x4000106")]
	public const string Respawn = "Respawn";

	[Token(Token = "0x4000107")]
	public const string Finish = "Finish";

	[Token(Token = "0x4000108")]
	public const string EditorOnly = "EditorOnly";

	[Token(Token = "0x4000109")]
	public const string MainCamera = "MainCamera";

	[Token(Token = "0x400010A")]
	public const string Player = "Player";

	[Token(Token = "0x400010B")]
	public const string GameController = "GameController";

	[Token(Token = "0x400010C")]
	public const string MiniChara = "MiniChara";

	[Token(Token = "0x400010D")]
	public const string Face = "Face";

	[Token(Token = "0x400010E")]
	public const string Correct = "Correct";

	[Token(Token = "0x400010F")]
	public const string SliderFillArea = "SliderFillArea";

	[Token(Token = "0x4000110")]
	public const string SliderHandle = "SliderHandle";

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] names;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7B8C1C", Offset = "0x7B8C1C", VA = "0x7B8C1C")]
	public TagName()
	{
	}
}
[Token(Token = "0x2000022")]
public class SleeveScaleFromArmBone : MonoBehaviour
{
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform scaleBone1;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float scalingRate1;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform scaleBone2;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float scalingRate2;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform scaleBone3;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float scalingRate3;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform lowArmBone;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float scaleStartAngle;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float scaleEndAngle;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7B9100", Offset = "0x7B9100", VA = "0x7B9100")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x7B9104", Offset = "0x7B9104", VA = "0x7B9104")]
	private void Update()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x7B92B0", Offset = "0x7B92B0", VA = "0x7B92B0")]
	public SleeveScaleFromArmBone()
	{
	}
}
namespace VRM
{
	[Token(Token = "0x2000023")]
	public static class EnumUtil
	{
		[Token(Token = "0x6000061")]
		public static T TryParseOrDefault<T>(string src, [Optional] T defaultValue) where T : struct
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000024")]
	[DefaultExecutionOrder(11000)]
	public class VRMSpringBone : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum SpringBoneUpdateType
		{
			[Token(Token = "0x400012B")]
			LateUpdate,
			[Token(Token = "0x400012C")]
			FixedUpdate
		}

		[Token(Token = "0x2000026")]
		public class VRMSpringBoneLogic
		{
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Transform m_transform;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_length;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 m_currentTail;

			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 m_prevTail;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 m_localDir;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Quaternion m_localRotation;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 m_boneAxis;

			[Token(Token = "0x17000004")]
			public Transform Head
			{
				[Token(Token = "0x600006C")]
				[Address(RVA = "0x7BB170", Offset = "0x7BB170", VA = "0x7BB170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000005")]
			public Vector3 Tail
			{
				[Token(Token = "0x600006D")]
				[Address(RVA = "0x7BB178", Offset = "0x7BB178", VA = "0x7BB178")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000006")]
			public Quaternion LocalRotation
			{
				[Token(Token = "0x600006E")]
				[Address(RVA = "0x7BB1F0", Offset = "0x7BB1F0", VA = "0x7BB1F0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000007")]
			public float Radius
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x7BB1FC", Offset = "0x7BB1FC", VA = "0x7BB1FC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000070")]
				[Address(RVA = "0x7BB204", Offset = "0x7BB204", VA = "0x7BB204")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000008")]
			private Quaternion ParentRotation
			{
				[Token(Token = "0x6000072")]
				[Address(RVA = "0x7BB20C", Offset = "0x7BB20C", VA = "0x7BB20C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x7BA290", Offset = "0x7BA290", VA = "0x7BA290")]
			public VRMSpringBoneLogic(Transform center, Transform transform, Vector3 localChildPosition)
			{
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x7BA864", Offset = "0x7BA864", VA = "0x7BA864")]
			public void Update(Transform center, float stiffnessForce, float dragForce, Vector3 external, List<SphereCollider> colliders)
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x7BB2E4", Offset = "0x7BB2E4", VA = "0x7BB2E4", Slot = "4")]
			protected virtual Quaternion ApplyRotation(Vector3 nextTail)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x7BB478", Offset = "0x7BB478", VA = "0x7BB478", Slot = "5")]
			protected virtual Vector3 Collision(List<SphereCollider> colliders, Vector3 nextTail)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x7BAE24", Offset = "0x7BAE24", VA = "0x7BAE24")]
			public void DrawGizmo(Transform center, float radius, Color color)
			{
			}
		}

		[Token(Token = "0x2000027")]
		public struct SphereCollider
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 Position;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float Radius;
		}

		[Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <GetChildren>d__19 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform parent;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__parent;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			[Token(Token = "0x17000009")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x7BB8B8", Offset = "0x7BB8B8", VA = "0x7BB8B8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x7BB900", Offset = "0x7BB900", VA = "0x7BB900", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x7BA25C", Offset = "0x7BA25C", VA = "0x7BA25C")]
			[DebuggerHidden]
			public <GetChildren>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x7BB814", Offset = "0x7BB814", VA = "0x7BB814", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x7BB818", Offset = "0x7BB818", VA = "0x7BB818", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x7BB8C0", Offset = "0x7BB8C0", VA = "0x7BB8C0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x7BB908", Offset = "0x7BB908", VA = "0x7BB908", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x7BB9B4", Offset = "0x7BB9B4", VA = "0x7BB9B4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string m_comment;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Gizmo")]
		[SerializeField]
		private bool m_drawGizmo;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color m_gizmoColor;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 4f)]
		[SerializeField]
		[Header("Settings")]
		public float m_stiffnessForce;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 2f)]
		[SerializeField]
		public float m_gravityPower;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public Vector3 m_gravityDir;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[SerializeField]
		public float m_dragForce;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public Transform m_center;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public List<Transform> RootBones;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Transform, Quaternion> m_initialLocalRotationMap;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Range(0f, 0.5f)]
		[Header("Collider")]
		public float m_hitRadius;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public VRMSpringBoneColliderGroup[] ColliderGroups;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public SpringBoneUpdateType m_updateType;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<VRMSpringBoneLogic> m_verlet;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<SphereCollider> m_colliderList;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7B92C4", Offset = "0x7B92C4", VA = "0x7B92C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7B92CC", Offset = "0x7B92CC", VA = "0x7B92CC")]
		[ContextMenu("Reset bones")]
		public void Setup(bool force = false)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x7BA040", Offset = "0x7BA040", VA = "0x7BA040")]
		public void SetLocalRotationsIdentity()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7BA1D8", Offset = "0x7BA1D8", VA = "0x7BA1D8")]
		[IteratorStateMachine(typeof(<GetChildren>d__19))]
		private static IEnumerable<Transform> GetChildren(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7B9A38", Offset = "0x7B9A38", VA = "0x7B9A38")]
		private void SetupRecursive(Transform center, Transform parent)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7BA4B0", Offset = "0x7BA4B0", VA = "0x7BA4B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7BA834", Offset = "0x7BA834", VA = "0x7BA834")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7BA4DC", Offset = "0x7BA4DC", VA = "0x7BA4DC")]
		private void UpdateProcess(float deltaTime)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7BACC4", Offset = "0x7BACC4", VA = "0x7BACC4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x7BB010", Offset = "0x7BB010", VA = "0x7BB010")]
		public VRMSpringBone()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[DefaultExecutionOrder(11001)]
	public class VRMSpringBoneColliderGroup : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		public class SphereCollider
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 Offset;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			public float Radius;

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x7BBC3C", Offset = "0x7BBC3C", VA = "0x7BBC3C")]
			public SphereCollider()
			{
			}
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SphereCollider[] Colliders;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_gizmoColor;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7BB9B8", Offset = "0x7BB9B8", VA = "0x7BB9B8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7BBB40", Offset = "0x7BBB40", VA = "0x7BBB40")]
		public VRMSpringBoneColliderGroup()
		{
		}
	}
}
namespace UniGLTF
{
	[Token(Token = "0x200002B")]
	public struct PosRot
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x7BBC44", Offset = "0x7BBC44", VA = "0x7BBC44")]
		public static PosRot FromGlobalTransform(Transform t)
		{
			return default(PosRot);
		}
	}
	[Token(Token = "0x200002C")]
	public class BlendShape
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Vector3> Positions;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Vector3> Normals;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> Tangents;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x7BBCA8", Offset = "0x7BBCA8", VA = "0x7BBCA8")]
		public BlendShape(string name)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class UnityExtensions
	{
		[Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class <GetChildren>d__15 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform self;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__self;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x1700000B")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x7BD6B0", Offset = "0x7BD6B0", VA = "0x7BD6B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x7BD6F8", Offset = "0x7BD6F8", VA = "0x7BD6F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x7BC7F0", Offset = "0x7BC7F0", VA = "0x7BC7F0")]
			[DebuggerHidden]
			public <GetChildren>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x7BD364", Offset = "0x7BD364", VA = "0x7BD364", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x7BD380", Offset = "0x7BD380", VA = "0x7BD380", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x7BD5F4", Offset = "0x7BD5F4", VA = "0x7BD5F4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x7BD6B8", Offset = "0x7BD6B8", VA = "0x7BD6B8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x7BD700", Offset = "0x7BD700", VA = "0x7BD700", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x7BD7AC", Offset = "0x7BD7AC", VA = "0x7BD7AC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class <Traverse>d__16 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__t;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<Transform> <>7__wrap2;

			[Token(Token = "0x1700000D")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x7BDE24", Offset = "0x7BDE24", VA = "0x7BDE24", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x7BDE6C", Offset = "0x7BDE6C", VA = "0x7BDE6C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x7BC824", Offset = "0x7BC824", VA = "0x7BC824")]
			[DebuggerHidden]
			public <Traverse>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x7BD7B0", Offset = "0x7BD7B0", VA = "0x7BD7B0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x7BD868", Offset = "0x7BD868", VA = "0x7BD868", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x7BDD68", Offset = "0x7BDD68", VA = "0x7BDD68")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x7BDCB8", Offset = "0x7BDCB8", VA = "0x7BDCB8")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x7BDE2C", Offset = "0x7BDE2C", VA = "0x7BDE2C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x7BDE74", Offset = "0x7BDE74", VA = "0x7BDE74", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x7BDF20", Offset = "0x7BDF20", VA = "0x7BDF20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class <Ancestors>d__19 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__t;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<Transform> <>7__wrap1;

			[Token(Token = "0x1700000F")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60000BA")]
				[Address(RVA = "0x7BE36C", Offset = "0x7BE36C", VA = "0x7BE36C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BC")]
				[Address(RVA = "0x7BE3B4", Offset = "0x7BE3B4", VA = "0x7BE3B4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x7BC9D8", Offset = "0x7BC9D8", VA = "0x7BC9D8")]
			[DebuggerHidden]
			public <Ancestors>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x7BDF50", Offset = "0x7BDF50", VA = "0x7BDF50", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x7BDF6C", Offset = "0x7BDF6C", VA = "0x7BDF6C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x7BE2BC", Offset = "0x7BE2BC", VA = "0x7BE2BC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x7BE374", Offset = "0x7BE374", VA = "0x7BE374", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x7BE3BC", Offset = "0x7BE3BC", VA = "0x7BE3BC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x7BE468", Offset = "0x7BE468", VA = "0x7BE468", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x7BBD9C", Offset = "0x7BBD9C", VA = "0x7BBD9C")]
		public static Vector4 ReverseZ(this Vector4 v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x7BBDA4", Offset = "0x7BBDA4", VA = "0x7BBDA4")]
		public static Vector3 ReverseZ(this Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x7BBDAC", Offset = "0x7BBDAC", VA = "0x7BBDAC")]
		[Obsolete]
		public static Vector2 ReverseY(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7BBDB4", Offset = "0x7BBDB4", VA = "0x7BBDB4")]
		public static Vector2 ReverseUV(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7BBDC0", Offset = "0x7BBDC0", VA = "0x7BBDC0")]
		public static Quaternion ReverseZ(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7BBE1C", Offset = "0x7BBE1C", VA = "0x7BBE1C")]
		public static Matrix4x4 Matrix4x4FromColumns(Vector4 c0, Vector4 c1, Vector4 c2, Vector4 c3)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7BBE58", Offset = "0x7BBE58", VA = "0x7BBE58")]
		public static Matrix4x4 Matrix4x4FromRotation(Quaternion q)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x7BBE8C", Offset = "0x7BBE8C", VA = "0x7BBE8C")]
		public static Matrix4x4 ReverseZ(this Matrix4x4 m)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7BC0EC", Offset = "0x7BC0EC", VA = "0x7BC0EC")]
		public static Matrix4x4 MatrixFromArray(float[] values)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7BBF6C", Offset = "0x7BBF6C", VA = "0x7BBF6C")]
		public static Quaternion ExtractRotation(this Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7BBF60", Offset = "0x7BBF60", VA = "0x7BBF60")]
		public static Vector3 ExtractPosition(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7BBF84", Offset = "0x7BBF84", VA = "0x7BBF84")]
		public static Vector3 ExtractScale(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7BC1C4", Offset = "0x7BC1C4", VA = "0x7BC1C4")]
		public static string RelativePathFrom(this Transform self, Transform root)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7BC380", Offset = "0x7BC380", VA = "0x7BC380")]
		public static Transform GetChildByName(this Transform self, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7BC6DC", Offset = "0x7BC6DC", VA = "0x7BC6DC")]
		public static Transform GetFromPath(this Transform self, string path)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7BC76C", Offset = "0x7BC76C", VA = "0x7BC76C")]
		[IteratorStateMachine(typeof(<GetChildren>d__15))]
		public static IEnumerable<Transform> GetChildren(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7B99B4", Offset = "0x7B99B4", VA = "0x7B99B4")]
		[IteratorStateMachine(typeof(<Traverse>d__16))]
		public static IEnumerable<Transform> Traverse(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7BC858", Offset = "0x7BC858", VA = "0x7BC858")]
		[Obsolete("Use FindDescendant(name)")]
		public static Transform FindDescenedant(this Transform t, string name)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7BC85C", Offset = "0x7BC85C", VA = "0x7BC85C")]
		public static Transform FindDescendant(this Transform t, string name)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7BC954", Offset = "0x7BC954", VA = "0x7BC954")]
		[IteratorStateMachine(typeof(<Ancestors>d__19))]
		public static IEnumerable<Transform> Ancestors(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7BCA0C", Offset = "0x7BCA0C", VA = "0x7BCA0C")]
		public static float[] ToArray(this Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7BCAB0", Offset = "0x7BCAB0", VA = "0x7BCAB0")]
		public static float[] ToArray(this Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x7BCB44", Offset = "0x7BCB44", VA = "0x7BCB44")]
		public static float[] ToArray(this Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7BCBE8", Offset = "0x7BCBE8", VA = "0x7BCBE8")]
		public static float[] ToArray(this Color c)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7BCC8C", Offset = "0x7BCC8C", VA = "0x7BCC8C")]
		public static void ReverseZRecursive(this Transform root)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x7BD188", Offset = "0x7BD188", VA = "0x7BD188")]
		public static Mesh GetSharedMesh(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7BD29C", Offset = "0x7BD29C", VA = "0x7BD29C")]
		public static Material[] GetSharedMaterials(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		public static bool Has<T>(this Transform transform, T t) where T : Component
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		public static T GetOrAddComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}
	}
}
namespace Activ8.Controller.RiggingSet.Runtime
{
	[Serializable]
	[Token(Token = "0x2000033")]
	public class ReferencePoseSC
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string applicationVersion;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string author;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float version;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string application;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string creationData;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] names;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float[] matrices;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x7BE520", Offset = "0x7BE520", VA = "0x7BE520")]
		public ReferencePoseSC()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	public class ReferencePose : MonoBehaviour
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAsset m_text;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAsset m_old_text;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_newbind;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Dictionary<string, Matrix4x4> m_ref;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7BE528", Offset = "0x7BE528", VA = "0x7BE528")]
		private void update_json()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7BE84C", Offset = "0x7BE84C", VA = "0x7BE84C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7BE850", Offset = "0x7BE850", VA = "0x7BE850")]
		public bool Bind()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x7BE8C8", Offset = "0x7BE8C8", VA = "0x7BE8C8")]
		public ReferencePose()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AddComponentMenu("")]
	public class TwistBoneBase : MonoBehaviour
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform m_begin_constraint;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform m_twist_begin;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform m_twist_end;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public ReferencePose m_ref;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<Transform> m_bones;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<Matrix4x4> m_refposes;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Matrix4x4 m_constraint_parent_inverse_matrix;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public Matrix4x4 m_constraint_matrix;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7BE958", Offset = "0x7BE958", VA = "0x7BE958")]
		private Matrix4x4 find_reference(string name, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7BEBB4", Offset = "0x7BEBB4", VA = "0x7BEBB4")]
		private void register_constraint(ref Transform constraint)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7BED3C", Offset = "0x7BED3C", VA = "0x7BED3C")]
		private void register_twist(ref Transform begin, ref Transform end)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7BF120", Offset = "0x7BF120", VA = "0x7BF120")]
		private int nodedepth(Transform node)
		{
			return default(int);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7BF1C8", Offset = "0x7BF1C8", VA = "0x7BF1C8")]
		public void update_node()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7BF1EC", Offset = "0x7BF1EC", VA = "0x7BF1EC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x7BF2E8", Offset = "0x7BF2E8", VA = "0x7BF2E8")]
		public TwistBoneBase()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[ExecuteInEditMode]
	public class TwistBoneFK : TwistBoneBase
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float m_power;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 m_dir;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7BF424", Offset = "0x7BF424", VA = "0x7BF424")]
		private new void OnEnable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7BF428", Offset = "0x7BF428", VA = "0x7BF428")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7BF54C", Offset = "0x7BF54C", VA = "0x7BF54C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7BFCD8", Offset = "0x7BFCD8", VA = "0x7BFCD8")]
		public TwistBoneFK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	public class TwistBoneIK : TwistBoneBase
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 m_dir;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Transform m_end_constraint;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float m_power;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7BFCE8", Offset = "0x7BFCE8", VA = "0x7BFCE8")]
		private new void OnEnable()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7BFCEC", Offset = "0x7BFCEC", VA = "0x7BFCEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7BFE10", Offset = "0x7BFE10", VA = "0x7BFE10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7C0544", Offset = "0x7C0544", VA = "0x7C0544")]
		public TwistBoneIK()
		{
		}
	}
}
namespace Trancer
{
	[Token(Token = "0x2000038")]
	public class CustomMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_cachedTransform;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_cachedGameObject;

		[Token(Token = "0x17000011")]
		public Transform cachedTransform
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x7C0560", Offset = "0x7C0560", VA = "0x7C0560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public GameObject cachedGameObject
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x7C05F0", Offset = "0x7C05F0", VA = "0x7C05F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7C0680", Offset = "0x7C0680", VA = "0x7C0680")]
		public CustomMonoBehaviour()
		{
		}
	}
}
namespace Assets.RATOBA_LIVE.Scripts.DrivenKey
{
	[Token(Token = "0x2000039")]
	public class AngleDriverPresenter : CustomMonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string _name;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 _ovX;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 _ovY;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 _ovZ;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<Vector3> _driverChangeAction;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _driver;

		[Token(Token = "0x17000013")]
		public Action<Vector3> OnDriverChanged
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x7C0688", Offset = "0x7C0688", VA = "0x7C0688")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x7B278C", Offset = "0x7B278C", VA = "0x7B278C")]
			set
			{
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x7C0690", Offset = "0x7C0690", VA = "0x7C0690")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x7C0694", Offset = "0x7C0694", VA = "0x7C0694")]
		private void DriverUpdate()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7C0E9C", Offset = "0x7C0E9C", VA = "0x7C0E9C")]
		private Vector3 GetVectorX(Quaternion q)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7C0EE0", Offset = "0x7C0EE0", VA = "0x7C0EE0")]
		private Vector3 GetVectorY(Quaternion q)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7C0F20", Offset = "0x7C0F20", VA = "0x7C0F20")]
		private Vector3 GetVectorZ(Quaternion q)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7C0F60", Offset = "0x7C0F60", VA = "0x7C0F60")]
		public AngleDriverPresenter()
		{
		}
	}
}
namespace Const
{
	[Token(Token = "0x200003A")]
	public static class UI
	{
		[Token(Token = "0x400017E")]
		public const string ANIM_ENABLE_NAME = "open";

		[Token(Token = "0x400017F")]
		public const string ANIM_DISABLE_NAME = "close";

		[Token(Token = "0x4000180")]
		public const string ANIM_ENTER_NAME = "enter";

		[Token(Token = "0x4000181")]
		public const string ANIM_EXIT_NAME = "exit";

		[Token(Token = "0x4000182")]
		public const string ANIM_DECIDE_NAME = "decide";

		[Token(Token = "0x4000183")]
		public const int LAYER_MASK = 32;
	}
}
namespace Game
{
	[Token(Token = "0x200003B")]
	public class AnniversaryLogoTextComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200003C")]
		private enum logoType
		{
			[Token(Token = "0x400019A")]
			Default,
			[Token(Token = "0x400019B")]
			Anniversary,
			[Token(Token = "0x400019C")]
			NUM
		}

		[Token(Token = "0x200003D")]
		private enum OrdinalType
		{
			[Token(Token = "0x400019E")]
			st,
			[Token(Token = "0x400019F")]
			nd,
			[Token(Token = "0x40001A0")]
			rd,
			[Token(Token = "0x40001A1")]
			th,
			[Token(Token = "0x40001A2")]
			NUM
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 DEFAULT_LOGO_SCALE;

		[Token(Token = "0x4000185")]
		private const float DEFAULT_LOGO_POSY = 2.58f;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly Vector3 ANIV_LOGO_SCALE;

		[Token(Token = "0x4000187")]
		private const float ANIV_LOGO_POSY = 2.51f;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_titleLogoParent;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int m_anniversaryNum;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite[] m_ordinalSprite;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite[] m_numberSprite;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite[] m_logoBaseSprtes;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite[] m_logoGlowSprites;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform m_xxthTransform;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform m_logoTransform;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform m_anniversaryNameTransform;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SpriteRenderer m_titleLogoBase;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SpriteRenderer m_titleLogoGlow;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SpriteRenderer m_bg;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SpriteRenderer m_anniversarySprite;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private SpriteRenderer m_number00;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private SpriteRenderer m_number0;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SpriteRenderer m_ordinal;

		[Token(Token = "0x17000014")]
		public int OrdinalValue
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x7C0F68", Offset = "0x7C0F68", VA = "0x7C0F68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsLogoCreate
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x7C0F70", Offset = "0x7C0F70", VA = "0x7C0F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x7C0F78", Offset = "0x7C0F78", VA = "0x7C0F78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x7C0F84", Offset = "0x7C0F84", VA = "0x7C0F84")]
		public void Initlaize()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7C15B4", Offset = "0x7C15B4", VA = "0x7C15B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7C15B8", Offset = "0x7C15B8", VA = "0x7C15B8")]
		public AnniversaryLogoTextComponent()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class OrdinalMaterialTextComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200003F")]
		private enum ValueType
		{
			[Token(Token = "0x40001A9")]
			None,
			[Token(Token = "0x40001AA")]
			Ordinal,
			[Token(Token = "0x40001AB")]
			Value0,
			[Token(Token = "0x40001AC")]
			Value00,
			[Token(Token = "0x40001AD")]
			NUM
		}

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite[] m_sprites;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SpriteRenderer m_spriteRenderer;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnniversaryLogoTextComponent m_anniversaryLogoTextComponent;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ValueType m_valueType;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool m_isLoaded;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7C16DC", Offset = "0x7C16DC", VA = "0x7C16DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7C1734", Offset = "0x7C1734", VA = "0x7C1734")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x7C1950", Offset = "0x7C1950", VA = "0x7C1950")]
		private void SetRenderer(Sprite sprite)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x7C196C", Offset = "0x7C196C", VA = "0x7C196C")]
		public OrdinalMaterialTextComponent()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class BirthdayLogoComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		private const float DEFAULT_LOGO_POSY = 2.58f;

		[Token(Token = "0x40001AF")]
		private const float BIRTHDAY_LOGO_POSY = 2.51f;

		[Token(Token = "0x40001B0")]
		private const float TITLECALL_ENDED_LOGO_SPAWN_TIME = 1.5f;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 BIRTHDAY_LOGO_SCALE;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_titleLogoParent;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform[] m_endTitleCallSpawnObject;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform[] m_titlteCallCurrentSpawnObject;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] m_eventEffect;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform[] m_eventEffectOnce;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform[] m_otherThanHomeEffect;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<SpriteRenderer> m_titleCallEndedRenderer;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InterpolatorFloat m_alphaInterpolator;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIBlinkingComponent m_uiBlinkingComponent;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x7C19D0", Offset = "0x7C19D0", VA = "0x7C19D0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x7C1C24", Offset = "0x7C1C24", VA = "0x7C1C24")]
		private void SetActive(bool enabled)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7C1D6C", Offset = "0x7C1D6C", VA = "0x7C1D6C")]
		private void InitlaizeTitleCallEndedLogo()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7C20F0", Offset = "0x7C20F0", VA = "0x7C20F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7C21B8", Offset = "0x7C21B8", VA = "0x7C21B8")]
		public void ForcedBirthdayLogoSpawn()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7C2224", Offset = "0x7C2224", VA = "0x7C2224")]
		public void TitleCallEndedInvoke([Optional] Action onEndedAction)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7C1E54", Offset = "0x7C1E54", VA = "0x7C1E54")]
		private void SetTitleCallRendererAlphaValue(float alpha)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7C23E0", Offset = "0x7C23E0", VA = "0x7C23E0")]
		public void SetIsHomeOpen(bool enabled)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7C2508", Offset = "0x7C2508", VA = "0x7C2508")]
		public BirthdayLogoComponent()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class AnimationComponent : ModelComponent
	{
		[Token(Token = "0x2000043")]
		private struct AnimParam
		{
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string m_name;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float m_fadeTime;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int m_layer;
		}

		[Token(Token = "0x40001BD")]
		private const float FINISH_ANIM_RATE = 0.99f;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<AnimParam> m_nextAnimList;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SkinnedMeshRenderer m_faceRenderer;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected string m_facePath;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7C27C8", Offset = "0x7C27C8", VA = "0x7C27C8", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7C2884", Offset = "0x7C2884", VA = "0x7C2884", Slot = "12")]
		public virtual void PlayAnimation(string animName, float fadeTime = 0.5f, int layer = 0)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x7C29F0", Offset = "0x7C29F0", VA = "0x7C29F0")]
		public float GetNormalizeAnimationTime(int layer = 0)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x7C2A54", Offset = "0x7C2A54", VA = "0x7C2A54")]
		public bool IsFinishedAnimation(int layer = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x7C2AE0", Offset = "0x7C2AE0", VA = "0x7C2AE0", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x7C2CF4", Offset = "0x7C2CF4", VA = "0x7C2CF4")]
		protected void SetFacePath(string objectPath)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x7C2C28", Offset = "0x7C2C28", VA = "0x7C2C28")]
		protected void SetFaceModel()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x7C2D90", Offset = "0x7C2D90", VA = "0x7C2D90")]
		public void SetBlendShape(int index, float value)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7C2DA4", Offset = "0x7C2DA4", VA = "0x7C2DA4")]
		public float GetBlendShape(int index)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x7C2E40", Offset = "0x7C2E40", VA = "0x7C2E40")]
		public AnimationComponent()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class AnimationEventReceiver : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000045")]
		public class EventSeParam
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_name;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float m_volume;

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x7C3244", Offset = "0x7C3244", VA = "0x7C3244")]
			public EventSeParam()
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x7C2EC8", Offset = "0x7C2EC8", VA = "0x7C2EC8")]
		private void PlayVoice(string name)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x7C2F80", Offset = "0x7C2F80", VA = "0x7C2F80")]
		private void PlaySE_volumeLow(string name)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x7C3084", Offset = "0x7C3084", VA = "0x7C3084")]
		private void PlaySE_Step()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7C3194", Offset = "0x7C3194", VA = "0x7C3194")]
		private void JumpStart()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x7C323C", Offset = "0x7C323C", VA = "0x7C323C")]
		public AnimationEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class BlinkController
	{
		[Token(Token = "0x2000047")]
		private enum eState
		{
			[Token(Token = "0x40001D2")]
			Default,
			[Token(Token = "0x40001D3")]
			Close,
			[Token(Token = "0x40001D4")]
			Closing,
			[Token(Token = "0x40001D5")]
			Open,
			[Token(Token = "0x40001D6")]
			UnUsed,
			[Token(Token = "0x40001D7")]
			Stop
		}

		[Token(Token = "0x40001C6")]
		private const float TIME_MAX = 7f;

		[Token(Token = "0x40001C7")]
		private const float TIME_MIN = 4f;

		[Token(Token = "0x40001C8")]
		private const float CLOSE_TIME = 0.1f;

		[Token(Token = "0x40001C9")]
		private const float CLOSING_TIME = 0.15f;

		[Token(Token = "0x40001CA")]
		private const float OPEN_TIME = 0.1f;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private eState m_state;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SkinnedMeshRenderer m_mesh;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_rightIndex;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_leftIndex;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_timer;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_isUsed;

		[Token(Token = "0x17000016")]
		public bool IsUsed
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x7C324C", Offset = "0x7C324C", VA = "0x7C324C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x7C3254", Offset = "0x7C3254", VA = "0x7C3254")]
			set
			{
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x7C32A8", Offset = "0x7C32A8", VA = "0x7C32A8")]
		public BlinkController(SkinnedMeshRenderer mesh, int right, int left)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x7C32F0", Offset = "0x7C32F0", VA = "0x7C32F0")]
		public void OnLateUpdate()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x7C33B8", Offset = "0x7C33B8", VA = "0x7C33B8")]
		private void DefaultUpdate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x7C33F8", Offset = "0x7C33F8", VA = "0x7C33F8")]
		private void CloseUpdate()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x7C3490", Offset = "0x7C3490", VA = "0x7C3490")]
		private void ClosingUpdate()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7C34D8", Offset = "0x7C34D8", VA = "0x7C34D8")]
		private void OpenUpdate()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7C3574", Offset = "0x7C3574", VA = "0x7C3574")]
		private void StopUpdate()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7C363C", Offset = "0x7C363C", VA = "0x7C363C")]
		public void ForceStop()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class CharacterComponent : AnimationComponent
	{
		[Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class <FirstModelViewCoroutine>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterComponent <>4__this;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x7C542C", Offset = "0x7C542C", VA = "0x7C542C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x7C5474", Offset = "0x7C5474", VA = "0x7C5474", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x7C4144", Offset = "0x7C4144", VA = "0x7C4144")]
			[DebuggerHidden]
			public <FirstModelViewCoroutine>d__47(int <>1__state)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x7C53B4", Offset = "0x7C53B4", VA = "0x7C53B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x7C53B8", Offset = "0x7C53B8", VA = "0x7C53B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x7C5434", Offset = "0x7C5434", VA = "0x7C5434", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D8")]
		private const int BLINK_L = 48;

		[Token(Token = "0x40001D9")]
		private const int BLINK_R = 49;

		[Token(Token = "0x40001DA")]
		private const string VOICE_BONE_NAME = "Voice Audio Source";

		[Token(Token = "0x40001DB")]
		private const string PONY_TAIL_NAME = "RJ_C_ponyAA";

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CharaFadeController m_charaFade;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private HeadLookAtController m_headLookAt;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private EyeLookAtController m_eyeLookAt;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FacialController m_facial;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private LipSyncComponent m_lipsync;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform m_hip;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform m_head;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private DynamicBone[] m_hairDynamicBoneArray;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private CharacterModelParameter m_modelInfo;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CharacterState.eState m_initState;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public CharacterManager.eModelType m_nextModelType;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_keepModelChangeActive;

		[Token(Token = "0x17000017")]
		public Transform VoiceTrans
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x7C3648", Offset = "0x7C3648", VA = "0x7C3648")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x7C3650", Offset = "0x7C3650", VA = "0x7C3650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Transform HipTrans
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x7C3658", Offset = "0x7C3658", VA = "0x7C3658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Transform Head
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x7C3660", Offset = "0x7C3660", VA = "0x7C3660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public CharacterState State
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x7C3668", Offset = "0x7C3668", VA = "0x7C3668")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x7C3670", Offset = "0x7C3670", VA = "0x7C3670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool IsSetVoiceTrans
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x7C3678", Offset = "0x7C3678", VA = "0x7C3678")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x7C3680", Offset = "0x7C3680", VA = "0x7C3680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Animator EyeAnimator
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x7C368C", Offset = "0x7C368C", VA = "0x7C368C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x7C3694", Offset = "0x7C3694", VA = "0x7C3694")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public CharacterManager.eModelType CurrentModelType
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x7C369C", Offset = "0x7C369C", VA = "0x7C369C")]
			get
			{
				return default(CharacterManager.eModelType);
			}
		}

		[Token(Token = "0x1700001E")]
		public CharacterManager.eModelType NextModelType
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x7C36B4", Offset = "0x7C36B4", VA = "0x7C36B4")]
			get
			{
				return default(CharacterManager.eModelType);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x7C36BC", Offset = "0x7C36BC", VA = "0x7C36BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7C36D0", Offset = "0x7C36D0", VA = "0x7C36D0")]
		public void Initialize(CharacterState.eState initState)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7C36D8", Offset = "0x7C36D8", VA = "0x7C36D8")]
		public void SetModelInfo(CharacterModelParameter modelInfo)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7C3730", Offset = "0x7C3730", VA = "0x7C3730")]
		public void SetModelInfo()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x7C37E8", Offset = "0x7C37E8", VA = "0x7C37E8", Slot = "9")]
		public override void SetModelPath(string path)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x7C380C", Offset = "0x7C380C", VA = "0x7C380C", Slot = "11")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7C3890", Offset = "0x7C3890", VA = "0x7C3890", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x7C40D0", Offset = "0x7C40D0", VA = "0x7C40D0")]
		[IteratorStateMachine(typeof(<FirstModelViewCoroutine>d__47))]
		private IEnumerator FirstModelViewCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7C416C", Offset = "0x7C416C", VA = "0x7C416C", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x7C4438", Offset = "0x7C4438", VA = "0x7C4438")]
		public void SetFacial(string name)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x7C4844", Offset = "0x7C4844", VA = "0x7C4844")]
		public void ResetFacial()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x7C4A5C", Offset = "0x7C4A5C", VA = "0x7C4A5C", Slot = "8")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x7C5110", Offset = "0x7C5110", VA = "0x7C5110")]
		public void ChangeState(CharacterState.eState state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x7C5124", Offset = "0x7C5124", VA = "0x7C5124")]
		public void EnableLookAt(bool isEnable)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7C51BC", Offset = "0x7C51BC", VA = "0x7C51BC")]
		public void EnableBlink(bool isEnable)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x7C51C0", Offset = "0x7C51C0", VA = "0x7C51C0")]
		public void EnableLipSync(bool isEnalbe)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x7C51E0", Offset = "0x7C51E0", VA = "0x7C51E0", Slot = "12")]
		public override void PlayAnimation(string animName, float fadeTime = 0.5f, int layer = 0)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x7C51E4", Offset = "0x7C51E4", VA = "0x7C51E4")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x7C5334", Offset = "0x7C5334", VA = "0x7C5334")]
		public void SetVoiceAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x7C5348", Offset = "0x7C5348", VA = "0x7C5348")]
		public void ChangeEnableHairDynamicBone(bool isEnabled)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x7C53B0", Offset = "0x7C53B0", VA = "0x7C53B0")]
		public CharacterComponent()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class CharacterManager : SingletonMonoBehaviour<CharacterManager>
	{
		[Token(Token = "0x200004B")]
		public enum eModelType
		{
			[Token(Token = "0x40001F5")]
			Invalid,
			[Token(Token = "0x40001F6")]
			Regular,
			[Token(Token = "0x40001F7")]
			HW,
			[Token(Token = "0x40001F8")]
			HW_generic,
			[Token(Token = "0x40001F9")]
			HW2020,
			[Token(Token = "0x40001FA")]
			HW2020_generic,
			[Token(Token = "0x40001FB")]
			Regular_generic,
			[Token(Token = "0x40001FC")]
			BD2019,
			[Token(Token = "0x40001FD")]
			BD2019_generic
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly eModelType[] CHANGE_MODEL_LIST;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly eModelType[] CHANGE_RESULT_MODEL_LIST;

		[Token(Token = "0x17000021")]
		public CharacterComponent Character
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x7C547C", Offset = "0x7C547C", VA = "0x7C547C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x7C5484", Offset = "0x7C5484", VA = "0x7C5484")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public CharacterComponent GenericCharacter
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x7C548C", Offset = "0x7C548C", VA = "0x7C548C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x7C5494", Offset = "0x7C5494", VA = "0x7C5494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public MiniCharaComponent MiniCharacter
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x7C549C", Offset = "0x7C549C", VA = "0x7C549C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x7C54A4", Offset = "0x7C54A4", VA = "0x7C54A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x7C54AC", Offset = "0x7C54AC", VA = "0x7C54AC")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x7C56F4", Offset = "0x7C56F4", VA = "0x7C56F4")]
		public void SetNextModel(eModelType modelType)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7C581C", Offset = "0x7C581C", VA = "0x7C581C")]
		public void ChangeNextModel()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x7C5844", Offset = "0x7C5844", VA = "0x7C5844")]
		private void ChangeModel(eModelType modelType, CharacterComponent chara)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x7C58B8", Offset = "0x7C58B8", VA = "0x7C58B8")]
		public bool IsReadyModel()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x7C5964", Offset = "0x7C5964", VA = "0x7C5964")]
		public CharacterManager()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class FacialController
	{
		[Token(Token = "0x200004D")]
		private class ChangeFacial
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float current;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float change;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int next;

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x7C5A90", Offset = "0x7C5A90", VA = "0x7C5A90")]
			public ChangeFacial()
			{
			}
		}

		[Token(Token = "0x40001FE")]
		private const float FACIAL_FADE_TIME = 0.3f;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, ChangeFacial> m_changeFacialList;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> m_removeList;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimationComponent m_component;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_timer;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x7C3FDC", Offset = "0x7C3FDC", VA = "0x7C3FDC")]
		public FacialController(AnimationComponent component)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7C4280", Offset = "0x7C4280", VA = "0x7C4280")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x7C4E0C", Offset = "0x7C4E0C", VA = "0x7C4E0C")]
		public void OnLateUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x7C4448", Offset = "0x7C4448", VA = "0x7C4448")]
		public void SetFacial(string name)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x7C4854", Offset = "0x7C4854", VA = "0x7C4854")]
		public void ResetFacial()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x7C3830", Offset = "0x7C3830", VA = "0x7C3830")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class HeadLookAtController
	{
		[Token(Token = "0x4000206")]
		private const float HEAD_SPEED = 10f;

		[Token(Token = "0x4000207")]
		private const float HEAD_RETURN_SPEED = 180f;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_xMax;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_yMax;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_headTrans;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_defaultHeadAngle;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_currentHeadAngle;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_headSpeed;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_isEnable;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_isTargetReverse;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		private bool m_isReturnEnded;

		[Token(Token = "0x17000024")]
		public Transform Head
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x7C5A98", Offset = "0x7C5A98", VA = "0x7C5A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public bool IsEnable
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x7C5AA0", Offset = "0x7C5AA0", VA = "0x7C5AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x7C5160", Offset = "0x7C5160", VA = "0x7C5160")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform Target
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x7C5B60", Offset = "0x7C5B60", VA = "0x7C5B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x7C5B68", Offset = "0x7C5B68", VA = "0x7C5B68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x7C3EE4", Offset = "0x7C3EE4", VA = "0x7C3EE4")]
		public HeadLookAtController(Transform headTrans, float horizontalMax = 30f, float verticalMax = 10f, bool isTargetReverse = false, float headSpeed = 10f)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x7C4AA0", Offset = "0x7C4AA0", VA = "0x7C4AA0")]
		public void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x7C5AA8", Offset = "0x7C5AA8", VA = "0x7C5AA8")]
		private void NormalizedAngle(ref Vector3 angle)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x7C5B70", Offset = "0x7C5B70", VA = "0x7C5B70")]
		private void NormalizeAngle(ref float angle)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EyeLookAtController
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int[] EYE_MOVE_RIGHT;

		[Token(Token = "0x4000213")]
		private const float EYE_RETURN_SPEED = 360f;

		[Token(Token = "0x4000214")]
		private const float EYE_Z_MAX = 7f;

		[Token(Token = "0x4000215")]
		private const float EYE_Y_DIFF_MAX = 6f;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform[] m_eyeArray;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_eyeCurrentZ;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_eyeCurrentY;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_isReturnEnded;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_headTrans;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] m_baseY;

		[Token(Token = "0x17000027")]
		public bool IsEnable
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x7C5BB0", Offset = "0x7C5BB0", VA = "0x7C5BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x7C5BB8", Offset = "0x7C5BB8", VA = "0x7C5BB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x7C5BC4", Offset = "0x7C5BC4", VA = "0x7C5BC4")]
		public EyeLookAtController(Transform headTrans, string[] eyeLAndR)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7C5DD0", Offset = "0x7C5DD0", VA = "0x7C5DD0")]
		public void OnLateUpdate()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class MiniCharaComponent : AnimationComponent
	{
		[Token(Token = "0x2000051")]
		private class Blink
		{
			[Token(Token = "0x2000052")]
			private enum eState
			{
				[Token(Token = "0x4000242")]
				OPEN,
				[Token(Token = "0x4000243")]
				CLOSE
			}

			[Token(Token = "0x4000239")]
			private const float MIN_TIME = 4f;

			[Token(Token = "0x400023A")]
			private const float MAX_TIME = 8f;

			[Token(Token = "0x400023B")]
			private const float CLOSE_TIME = 0.1f;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private eState m_state;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Material m_mat;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Texture m_baseTex;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Texture m_closeEyeTex;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float m_timer;

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x7C6CEC", Offset = "0x7C6CEC", VA = "0x7C6CEC")]
			public Blink(Material mat)
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x7C6F9C", Offset = "0x7C6F9C", VA = "0x7C6F9C")]
			public void OnUpdate()
			{
			}
		}

		[Token(Token = "0x400021D")]
		private const float SCALE = 2f;

		[Token(Token = "0x400021E")]
		private const string MODEL_PATH = "Prefab/Character_mini";

		[Token(Token = "0x400021F")]
		private const string HEAD_PATH = "Root/Hip/Spine/Head";

		[Token(Token = "0x4000220")]
		private const string HAND_R_PATH = "Root/Hip/Spine/R_Upperarm/R_ForeArm/R_Hand";

		[Token(Token = "0x4000221")]
		private const string HAND_L_PATH = "Root/Hip/Spine/L_Upperarm/L_ForeArm/L_Hand";

		[Token(Token = "0x4000222")]
		private const string HEAD_TOP_PATH = "Root/Hip/Spine/Head/HeadTop";

		[Token(Token = "0x4000223")]
		private const float LOOK_AT_CHANGE_SQR_DIST = 0.25f;

		[Token(Token = "0x4000224")]
		private const float LOOK_AT_KEEP_TIME = 0.1f;

		[Token(Token = "0x4000225")]
		private const float LOOK_AT_CHANGE_TIME = 0.3f;

		[Token(Token = "0x4000226")]
		private const float LOOK_AT_HEAD_SPEED = 3f;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private HeadLookAtController m_lookAt;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool m_isLookAt;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string m_animName;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform m_parent;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_posOffset;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private MiniCharaState m_miniCharaState;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform[] m_penlightArray;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform m_changeLookAtTarget;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float m_lookAtTargetTimer;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_lookAtKeepTimer;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ModelComponent m_anivPartyHatModel;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Blink m_blink;

		[Token(Token = "0x17000028")]
		public Transform RightHand
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x7C64D0", Offset = "0x7C64D0", VA = "0x7C64D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x7C64D8", Offset = "0x7C64D8", VA = "0x7C64D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Transform LeftHand
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x7C64E0", Offset = "0x7C64E0", VA = "0x7C64E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x7C64E8", Offset = "0x7C64E8", VA = "0x7C64E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public PenLightComponent GrabPenlight
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x7C64F0", Offset = "0x7C64F0", VA = "0x7C64F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x7C64F8", Offset = "0x7C64F8", VA = "0x7C64F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Transform GrabPoint
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x7C6500", Offset = "0x7C6500", VA = "0x7C6500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x7C6508", Offset = "0x7C6508", VA = "0x7C6508")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool CanJumpFromAnim
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x7C6510", Offset = "0x7C6510", VA = "0x7C6510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x7C6518", Offset = "0x7C6518", VA = "0x7C6518")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		private Transform HeadTop
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x7C6524", Offset = "0x7C6524", VA = "0x7C6524")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x7C652C", Offset = "0x7C652C", VA = "0x7C652C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x7C653C", Offset = "0x7C653C", VA = "0x7C653C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7C66F4", Offset = "0x7C66F4", VA = "0x7C66F4", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7C67B8", Offset = "0x7C67B8", VA = "0x7C67B8", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7C6CD4", Offset = "0x7C6CD4", VA = "0x7C6CD4")]
		public void EnableLookAt(bool isEnable)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x7C6E84", Offset = "0x7C6E84", VA = "0x7C6E84")]
		private void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x7C7058", Offset = "0x7C7058", VA = "0x7C7058", Slot = "13")]
		protected virtual void LookAtTargetUpdate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7C7350", Offset = "0x7C7350", VA = "0x7C7350")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x7C7364", Offset = "0x7C7364", VA = "0x7C7364")]
		private void OnTriggerEnter(Collider coll)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x7C739C", Offset = "0x7C739C", VA = "0x7C739C")]
		public MiniCharaComponent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class MiniCharaState
	{
		[Token(Token = "0x2000054")]
		public enum eState
		{
			[Token(Token = "0x4000255")]
			Invalid,
			[Token(Token = "0x4000256")]
			Wait,
			[Token(Token = "0x4000257")]
			Walk,
			[Token(Token = "0x4000258")]
			FallDown,
			[Token(Token = "0x4000259")]
			ComeClose,
			[Token(Token = "0x400025A")]
			Dangle,
			[Token(Token = "0x400025B")]
			Cheer
		}

		[Token(Token = "0x2000055")]
		public enum eType
		{
			[Token(Token = "0x400025D")]
			Look,
			[Token(Token = "0x400025E")]
			Move
		}

		[Token(Token = "0x2000056")]
		private class MiniPenlight
		{
			[Token(Token = "0x400025F")]
			private const int MAX_PENLIGHTSET = 10;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MiniPenlightComponent[] m_havingMiniPenlightArray;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_popPenlightSet;

			[Token(Token = "0x17000033")]
			public bool IsHavingMiniPenlight
			{
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x7C7420", Offset = "0x7C7420", VA = "0x7C7420")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x7C7430", Offset = "0x7C7430", VA = "0x7C7430")]
			public bool CanCreatePenlight()
			{
				return default(bool);
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x7C7640", Offset = "0x7C7640", VA = "0x7C7640")]
			public void CreatePenlightSet(Transform rightHand, Transform leftHand)
			{
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x7C7898", Offset = "0x7C7898", VA = "0x7C7898")]
			public void ReleaseMiniPenlight()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x7C79A4", Offset = "0x7C79A4", VA = "0x7C79A4")]
			public MiniPenlight()
			{
			}
		}

		[Token(Token = "0x4000244")]
		public const string ANIM_WAIT = "miniai_idle_01";

		[Token(Token = "0x4000245")]
		public const string ANIM_RUN = "miniai_run_01";

		[Token(Token = "0x4000246")]
		public const string ANIM_FALLDOWN = "miniai_fly_01";

		[Token(Token = "0x4000247")]
		public const string ANIM_STANDUP = "miniai_standup_01";

		[Token(Token = "0x4000248")]
		public const string ANIM_JUMP = "miniai_jump_01";

		[Token(Token = "0x4000249")]
		public const string ANIM_DANGLE = "miniai_dangle_01";

		[Token(Token = "0x400024A")]
		public const string ANIM_TAKE_PENLIGHT = "miniai_take_pen_01";

		[Token(Token = "0x400024B")]
		public const string ANIM_WAIT_HAVING_PENLIGHT = "miniai_idle_02";

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private eState m_currentState;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool m_isDefaultRandom;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private eType m_charaType;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] m_walkPointArray;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Game.MiniChara.BaseState m_state;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MiniPenlight m_miniPenlight;

		[Token(Token = "0x1700002E")]
		public bool IsDefaultRandom
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x7C73AC", Offset = "0x7C73AC", VA = "0x7C73AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public eType CharaType
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x7C73B4", Offset = "0x7C73B4", VA = "0x7C73B4")]
			get
			{
				return default(eType);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x7C73BC", Offset = "0x7C73BC", VA = "0x7C73BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public MiniCharaComponent Component
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x7C73CC", Offset = "0x7C73CC", VA = "0x7C73CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x7C73D4", Offset = "0x7C73D4", VA = "0x7C73D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public CameraComponent Camera
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x7C73DC", Offset = "0x7C73DC", VA = "0x7C73DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x7C73E4", Offset = "0x7C73E4", VA = "0x7C73E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool IsEnterCheerState
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x7C73EC", Offset = "0x7C73EC", VA = "0x7C73EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7C73C4", Offset = "0x7C73C4", VA = "0x7C73C4")]
		public Transform[] GetWalkPoint()
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7C6DC4", Offset = "0x7C6DC4", VA = "0x7C6DC4")]
		public void Initialize(MiniCharaComponent component)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7C745C", Offset = "0x7C745C", VA = "0x7C745C")]
		public void ChangeState(eState state)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x7C7440", Offset = "0x7C7440", VA = "0x7C7440")]
		public eState GetDefaultState(eType type)
		{
			return default(eState);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x7C6F84", Offset = "0x7C6F84", VA = "0x7C6F84")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x7C7384", Offset = "0x7C7384", VA = "0x7C7384")]
		public void OnTriggerEnter(Collider coll)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x7C7628", Offset = "0x7C7628", VA = "0x7C7628")]
		public void CreatePenlight(Transform rightHand, Transform leftHand)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7C7858", Offset = "0x7C7858", VA = "0x7C7858")]
		public void ReleaseMiniPenlight()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7C790C", Offset = "0x7C790C", VA = "0x7C790C")]
		public bool IsHavingMiniPenlight()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x7C7930", Offset = "0x7C7930", VA = "0x7C7930")]
		public MiniCharaState()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class CharacterState
	{
		[Token(Token = "0x2000058")]
		public class CharacterDefaultState : BaseState
		{
			[Token(Token = "0x2000059")]
			private enum eInnerState
			{
				[Token(Token = "0x4000277")]
				Wait,
				[Token(Token = "0x4000278")]
				RandomAnim,
				[Token(Token = "0x4000279")]
				AnimWaitFrame
			}

			[Token(Token = "0x400026A")]
			private const string RANDOM_ANIM_PRE = "chara_action_";

			[Token(Token = "0x400026B")]
			private const int RANDOM_MIN = 1;

			[Token(Token = "0x400026C")]
			private const int RANDOM_MAX = 4;

			[Token(Token = "0x400026D")]
			private const float WAIT_TIME_MIN = 4f;

			[Token(Token = "0x400026E")]
			private const float WAIT_TIME_MAX = 8f;

			[Token(Token = "0x400026F")]
			private const float WAIT_CHECK = 1f;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly int[] HOME_ONLY_ARRAY;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private eInnerState m_innerState;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private eInnerState m_nextState;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float m_timer;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float m_time;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int m_beforeActionIndex;

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x7C7FF8", Offset = "0x7C7FF8", VA = "0x7C7FF8", Slot = "4")]
			public override void Initialize(CharacterComponent component)
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x7C80B4", Offset = "0x7C80B4", VA = "0x7C80B4", Slot = "6")]
			public override void OnUpdate()
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0x7C838C", Offset = "0x7C838C", VA = "0x7C838C")]
			private void ChangeInnerState(eInnerState next)
			{
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x7C81A4", Offset = "0x7C81A4", VA = "0x7C81A4")]
			private void Wait()
			{
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x7C82E8", Offset = "0x7C82E8", VA = "0x7C82E8")]
			private void RandomAnim()
			{
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x7C8090", Offset = "0x7C8090", VA = "0x7C8090")]
			private void SetRandomTime()
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x7C83BC", Offset = "0x7C83BC", VA = "0x7C83BC")]
			private int GetRandmAnimIndex()
			{
				return default(int);
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x7C7BF8", Offset = "0x7C7BF8", VA = "0x7C7BF8")]
			public CharacterDefaultState()
			{
			}
		}

		[Token(Token = "0x200005A")]
		public class CharacterMusicGameState : BaseState
		{
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RuntimeAnimatorController m_anim;

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x7C83FC", Offset = "0x7C83FC", VA = "0x7C83FC", Slot = "4")]
			public override void Initialize(CharacterComponent component)
			{
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x7C8468", Offset = "0x7C8468", VA = "0x7C8468", Slot = "5")]
			public override void OnExit()
			{
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x7C7C98", Offset = "0x7C7C98", VA = "0x7C7C98")]
			public CharacterMusicGameState()
			{
			}
		}

		[Token(Token = "0x200005B")]
		public enum eState
		{
			[Token(Token = "0x400027C")]
			Default,
			[Token(Token = "0x400027D")]
			MusicGame
		}

		[Token(Token = "0x200005C")]
		public abstract class BaseState
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected CharacterComponent m_component;

			[Token(Token = "0x17000037")]
			public bool CanChangeState
			{
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0x7C849C", Offset = "0x7C849C", VA = "0x7C849C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x7C84A4", Offset = "0x7C84A4", VA = "0x7C84A4")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x7C84B0", Offset = "0x7C84B0", VA = "0x7C84B0", Slot = "4")]
			public virtual void Initialize(CharacterComponent component)
			{
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x7C8498", Offset = "0x7C8498", VA = "0x7C8498", Slot = "5")]
			public virtual void OnExit()
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x7C81A0", Offset = "0x7C81A0", VA = "0x7C81A0", Slot = "6")]
			public virtual void OnUpdate()
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x7C84B8", Offset = "0x7C84B8", VA = "0x7C84B8")]
			protected void PlayVoice(string fileName)
			{
			}

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x7C83EC", Offset = "0x7C83EC", VA = "0x7C83EC")]
			protected BaseState()
			{
			}
		}

		[Token(Token = "0x4000262")]
		private const string WAIT_ANIM = "chara_wait_01_loop";

		[Token(Token = "0x4000263")]
		private const float ANGLE_SPEED = 360f;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BaseState m_current;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BaseState m_next;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CharacterComponent m_component;

		[Token(Token = "0x17000034")]
		public Transform Target
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x7C79F0", Offset = "0x7C79F0", VA = "0x7C79F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x7C79F8", Offset = "0x7C79F8", VA = "0x7C79F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public float TargetBetweenAngle
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x7C7A00", Offset = "0x7C7A00", VA = "0x7C7A00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x7C7A08", Offset = "0x7C7A08", VA = "0x7C7A08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 TargetPos
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x7C7A10", Offset = "0x7C7A10", VA = "0x7C7A10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x7C7A1C", Offset = "0x7C7A1C", VA = "0x7C7A1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7C7A28", Offset = "0x7C7A28", VA = "0x7C7A28")]
		public CharacterState(CharacterComponent component, eState initState)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7C7B44", Offset = "0x7C7B44", VA = "0x7C7B44")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7C7A9C", Offset = "0x7C7A9C", VA = "0x7C7A9C")]
		public BaseState CreateState(eState state)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7C7CA8", Offset = "0x7C7CA8", VA = "0x7C7CA8")]
		public void ChangeState(eState nextState)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x7C7B70", Offset = "0x7C7B70", VA = "0x7C7B70")]
		private void CheckChangeState()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7C7CD0", Offset = "0x7C7CD0", VA = "0x7C7CD0")]
		private void UpdateBetweenAngle()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x7C7F28", Offset = "0x7C7F28", VA = "0x7C7F28")]
		private bool ChangeAngle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7C7FC0", Offset = "0x7C7FC0", VA = "0x7C7FC0")]
		private static bool CheckNear(ref Vector3 posA, ref Vector3 posB, float dist)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005D")]
	public class LightComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x17000038")]
		public Light m_light
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x7C8558", Offset = "0x7C8558", VA = "0x7C8558")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x7C8560", Offset = "0x7C8560", VA = "0x7C8560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7C8568", Offset = "0x7C8568", VA = "0x7C8568")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7C85F8", Offset = "0x7C85F8", VA = "0x7C85F8", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7C86B8", Offset = "0x7C86B8", VA = "0x7C86B8")]
		public LightComponent()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class MatAlphaMoveListComponent : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum ComponentType
		{
			[Token(Token = "0x400028E")]
			Sprite,
			[Token(Token = "0x400028F")]
			Image,
			[Token(Token = "0x4000290")]
			Mesh
		}

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ComponentType m_type;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_shaderColorName;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_max;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_min;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_speed;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_isInitMatColor;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_timer;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material[] m_mat;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Color> m_color;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SpriteRenderer[] m_alphaMoveRenderers;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_shaderId;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image[] m_image;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7C86C0", Offset = "0x7C86C0", VA = "0x7C86C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7C8718", Offset = "0x7C8718", VA = "0x7C8718")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x7C8BDC", Offset = "0x7C8BDC", VA = "0x7C8BDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x7C8DA0", Offset = "0x7C8DA0", VA = "0x7C8DA0")]
		public void SetColor(Color rgb)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x7C8E78", Offset = "0x7C8E78", VA = "0x7C8E78")]
		public void SetColor(float r, float g, float b)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7C8F50", Offset = "0x7C8F50", VA = "0x7C8F50")]
		public MatAlphaMoveListComponent()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class MiniPenlightComponent : ModelComponent
	{
		[Token(Token = "0x4000291")]
		private const string MODEL_PATH = "Prefab/Penlight_mini";

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7C9024", Offset = "0x7C9024", VA = "0x7C9024", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7C79AC", Offset = "0x7C79AC", VA = "0x7C79AC")]
		public void ReleaseByHand()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7C9074", Offset = "0x7C9074", VA = "0x7C9074")]
		public MiniPenlightComponent()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class ObjectMoveComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 m_moveSpeed;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 m_moveDist;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_time;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_basePos;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7C907C", Offset = "0x7C907C", VA = "0x7C907C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7C90D4", Offset = "0x7C90D4", VA = "0x7C90D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x7C91EC", Offset = "0x7C91EC", VA = "0x7C91EC")]
		private float UpdateValue(float deltaTime, ref float time, float basePos, float speed, float dist)
		{
			return default(float);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x7C9248", Offset = "0x7C9248", VA = "0x7C9248")]
		public ObjectMoveComponent()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class ReadyComponent : GameComponent
	{
		[Token(Token = "0x2000063")]
		public enum eState
		{
			[Token(Token = "0x400029F")]
			Open,
			[Token(Token = "0x40002A0")]
			Wait,
			[Token(Token = "0x40002A1")]
			Close,
			[Token(Token = "0x40002A2")]
			End
		}

		[Token(Token = "0x4000296")]
		private const float SCALE_TIME = 0.15f;

		[Token(Token = "0x4000297")]
		private const float WAIT_TIME = 2f;

		[Token(Token = "0x4000298")]
		private const float PERFORMANCE_TIME_PER_ONE = 0.0625f;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private eState m_state;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_waitTimer;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_performanceCounter;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MusicGameController m_gameController;

		[Token(Token = "0x17000039")]
		public bool IsUsing
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x7C92BC", Offset = "0x7C92BC", VA = "0x7C92BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x7C92CC", Offset = "0x7C92CC", VA = "0x7C92CC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x7C9324", Offset = "0x7C9324", VA = "0x7C9324")]
		public void Initialize(MusicGameController gameController)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x7C932C", Offset = "0x7C932C", VA = "0x7C932C", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x7C9528", Offset = "0x7C9528", VA = "0x7C9528")]
		public void Open()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7C961C", Offset = "0x7C961C", VA = "0x7C961C")]
		public void ForceClose()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7C9700", Offset = "0x7C9700", VA = "0x7C9700")]
		public ReadyComponent()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RotationComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 m_rotationSpeed;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7C977C", Offset = "0x7C977C", VA = "0x7C977C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x7C9780", Offset = "0x7C9780", VA = "0x7C9780")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7C97DC", Offset = "0x7C97DC", VA = "0x7C97DC")]
		public RotationComponent()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class SpriteAnimComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite[] m_sprites;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_changeTime;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SpriteRenderer m_spriteRenderer;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_counter;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_timer;

		[Token(Token = "0x1700003A")]
		public int Counter
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x7C97EC", Offset = "0x7C97EC", VA = "0x7C97EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x7C97F4", Offset = "0x7C97F4", VA = "0x7C97F4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x7C9858", Offset = "0x7C9858", VA = "0x7C9858")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x7C98A0", Offset = "0x7C98A0", VA = "0x7C98A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7C9860", Offset = "0x7C9860", VA = "0x7C9860")]
		private void ChangedSprite()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7C9910", Offset = "0x7C9910", VA = "0x7C9910")]
		public SpriteAnimComponent()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class TitleLogoComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40002A9")]
		private const float SCALE_MIN = 0.4f;

		[Token(Token = "0x40002AA")]
		private const float PERFORMANCE_TIME = 0.25f;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpriteRenderer[] m_rendererArray;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InterpolatorFloat m_alphaInterpolator;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Color m_color;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIBlinkingComponent m_uiBlinkingComponent;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_isShow;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool m_isTop;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x7C9924", Offset = "0x7C9924", VA = "0x7C9924", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7C99C8", Offset = "0x7C99C8", VA = "0x7C99C8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7C99CC", Offset = "0x7C99CC", VA = "0x7C99CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7C9B08", Offset = "0x7C9B08", VA = "0x7C9B08")]
		private void ColorUpdate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7C9BD8", Offset = "0x7C9BD8", VA = "0x7C9BD8")]
		public void ChangeShow(bool isShow)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7C9C8C", Offset = "0x7C9C8C", VA = "0x7C9C8C")]
		public void ChangeTop(bool isTop)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x7C9DD4", Offset = "0x7C9DD4", VA = "0x7C9DD4")]
		public TitleLogoComponent()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class TutorialIconComponent : BaseMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public class RenderIcon
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int m_parentIndex;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_sprite;

			[Token(Token = "0x1700003B")]
			public int ParentIndex
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x7C9FF8", Offset = "0x7C9FF8", VA = "0x7C9FF8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700003C")]
			public Sprite DrawSprite
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x7CA000", Offset = "0x7CA000", VA = "0x7CA000")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x7CA008", Offset = "0x7CA008", VA = "0x7CA008")]
			public RenderIcon()
			{
			}
		}

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RenderIcon[] m_renderIcons;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SpriteRenderer m_spriteRenderer;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SpriteAnimComponent m_parentSpriteAnimComponent;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_currentParentSpriteIndex;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x7C9E8C", Offset = "0x7C9E8C", VA = "0x7C9E8C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x7C9F3C", Offset = "0x7C9F3C", VA = "0x7C9F3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7C9FF0", Offset = "0x7C9FF0", VA = "0x7C9FF0")]
		public TutorialIconComponent()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class UVScrollComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_scrollSpeed;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 m_scrollSpeed2;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 m_scrollValue;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector2 m_scrollValue2;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_mat;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int ADD_ID;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7CA010", Offset = "0x7CA010", VA = "0x7CA010", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x7CA100", Offset = "0x7CA100", VA = "0x7CA100", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x7CA19C", Offset = "0x7CA19C", VA = "0x7CA19C")]
		public void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7CA350", Offset = "0x7CA350", VA = "0x7CA350")]
		private void CheckLoop(ref Vector2 val)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x7CA3A4", Offset = "0x7CA3A4", VA = "0x7CA3A4")]
		public UVScrollComponent()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class CreditComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200006B")]
		private enum eState
		{
			[Token(Token = "0x40002CE")]
			FADE_WAIT,
			[Token(Token = "0x40002CF")]
			FADE_IN,
			[Token(Token = "0x40002D0")]
			MOVE,
			[Token(Token = "0x40002D1")]
			FADE_OUT,
			[Token(Token = "0x40002D2")]
			END
		}

		[Token(Token = "0x200006C")]
		public enum ePos
		{
			[Token(Token = "0x40002D4")]
			Right,
			[Token(Token = "0x40002D5")]
			Left,
			[Token(Token = "0x40002D6")]
			Center
		}

		[Token(Token = "0x40002BE")]
		private const float START_Y = 0.1f;

		[Token(Token = "0x40002BF")]
		private const float END_Y = 3f;

		[Token(Token = "0x40002C0")]
		private const float FADE_DIST = 0.4f;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected TMP_Text m_text;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string m_textJp;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string m_textEn;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string m_textTc;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string m_textSc;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected SpriteRenderer m_sprite;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_notJpPosY;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_jpPosY;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool m_isJpOnly;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool m_isCurrentJp;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected Color m_color;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private eState m_state;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x7CA404", Offset = "0x7CA404", VA = "0x7CA404", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x7CA660", Offset = "0x7CA660", VA = "0x7CA660")]
		public bool OnUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x7CA7A0", Offset = "0x7CA7A0", VA = "0x7CA7A0")]
		private void Init()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x7CA910", Offset = "0x7CA910", VA = "0x7CA910")]
		public void SetParam(string jp, string en, string tc, string sc, TextAlignmentOptions alignment, float notJpY, bool isJpOnly)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7CA9C8", Offset = "0x7CA9C8", VA = "0x7CA9C8")]
		public void SetParam(Sprite tex, float notJpY, bool isOnlyJp)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x7CA4F4", Offset = "0x7CA4F4", VA = "0x7CA4F4")]
		public void SetLanguage(ProjectDefine.eLanguage language)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x7CAA1C", Offset = "0x7CAA1C", VA = "0x7CAA1C", Slot = "6")]
		protected virtual void ChangeEnable(bool isEnabled)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x7CAA20", Offset = "0x7CAA20", VA = "0x7CAA20", Slot = "7")]
		protected virtual void SetColor()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x7CAA24", Offset = "0x7CAA24", VA = "0x7CAA24")]
		public CreditComponent()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CreditManager : SingletonMonoBehaviour<CreditManager>
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x7CAA34", Offset = "0x7CAA34", VA = "0x7CAA34")]
		public CreditManager()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CreditParentComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		private const float SPEED = 0.25f;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CreditComponent> CreditList;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action OnEnd;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 pos;

		[Token(Token = "0x1700003D")]
		public bool IsPause
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x7CAA7C", Offset = "0x7CAA7C", VA = "0x7CAA7C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x7CAA84", Offset = "0x7CAA84", VA = "0x7CAA84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsEnd
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x7CAA90", Offset = "0x7CAA90", VA = "0x7CAA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x7CAA98", Offset = "0x7CAA98", VA = "0x7CAA98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x7CAAA4", Offset = "0x7CAAA4", VA = "0x7CAAA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x7CAAD4", Offset = "0x7CAAD4", VA = "0x7CAAD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x7CABEC", Offset = "0x7CABEC", VA = "0x7CABEC")]
		public void ChangeLanguage(ProjectDefine.eLanguage language)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x7CAC84", Offset = "0x7CAC84", VA = "0x7CAC84")]
		public CreditParentComponent()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class CreditPictureComponent : CreditComponent
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x7CAD4C", Offset = "0x7CAD4C", VA = "0x7CAD4C", Slot = "6")]
		protected override void ChangeEnable(bool isEnabled)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x7CAD6C", Offset = "0x7CAD6C", VA = "0x7CAD6C", Slot = "7")]
		protected override void SetColor()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x7CAD94", Offset = "0x7CAD94", VA = "0x7CAD94")]
		public CreditPictureComponent()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class CreditTextComponent : CreditComponent
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x7CADA4", Offset = "0x7CADA4", VA = "0x7CADA4", Slot = "6")]
		protected override void ChangeEnable(bool isEnabled)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x7CADC4", Offset = "0x7CADC4", VA = "0x7CADC4", Slot = "7")]
		protected override void SetColor()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x7CADF4", Offset = "0x7CADF4", VA = "0x7CADF4")]
		public CreditTextComponent()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DateManager : SingletonMonoBehaviour<DateManager>
	{
		[Token(Token = "0x2000072")]
		private class BirthdayDateCommon
		{
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DateTime RELEASE_DAY;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly TimeSpan JPN_TIMESPAN;

			[Token(Token = "0x40002E9")]
			public const int MONTH = 6;

			[Token(Token = "0x40002EA")]
			public const int DAY = 30;

			[Token(Token = "0x40002EB")]
			public const int PERIOD_BEFORE_DAY = 0;

			[Token(Token = "0x40002EC")]
			public const int PERIOD_AFTER_DAY = 10;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private DateTime m_eventStartDay;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private DateTime m_eventEndDay;

			[Token(Token = "0x17000042")]
			public int ReleaseValue
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x7CB2A8", Offset = "0x7CB2A8", VA = "0x7CB2A8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x7CB320", Offset = "0x7CB320", VA = "0x7CB320")]
			private void DateUpdate()
			{
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x7CB0A4", Offset = "0x7CB0A4", VA = "0x7CB0A4")]
			public bool IsEventFireCaluculate(DateTime currentDate)
			{
				return default(bool);
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x7CB41C", Offset = "0x7CB41C", VA = "0x7CB41C")]
			public bool IsEventFireCaluculate(DateTime currentDate, int limitYears)
			{
				return default(bool);
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x7CB1FC", Offset = "0x7CB1FC", VA = "0x7CB1FC")]
			public BirthdayDateCommon()
			{
			}
		}

		[Token(Token = "0x40002DD")]
		private const int ANIV_EVENT_START_MONTH = 10;

		[Token(Token = "0x40002DE")]
		private const int ANIV_EVENT_START_DAY = 13;

		[Token(Token = "0x40002DF")]
		private const int ANIV_EVENT_DAY_PERIOD = 7;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime RELEASE_DAY;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly TimeSpan JPN_TIMESPAN;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DateTime m_anivEventStartDay;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTime m_anivEventEndDay;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BirthdayDateCommon m_birthdayDateCommon;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isAnivasaryPeriod;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isBirthdayPeriod;

		[Token(Token = "0x1700003F")]
		public bool IsAnivasaryPeriod
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x7CAE04", Offset = "0x7CAE04", VA = "0x7CAE04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x7CAE0C", Offset = "0x7CAE0C", VA = "0x7CAE0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool IsBirthdayPeriod
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x7CAE18", Offset = "0x7CAE18", VA = "0x7CAE18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x7CAE20", Offset = "0x7CAE20", VA = "0x7CAE20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int ReleaseValue
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x7CAE2C", Offset = "0x7CAE2C", VA = "0x7CAE2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x7CAEA4", Offset = "0x7CAEA4", VA = "0x7CAEA4", Slot = "7")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7CAEB0", Offset = "0x7CAEB0", VA = "0x7CAEB0", Slot = "8")]
		public virtual void DateUpdate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x7CAFF0", Offset = "0x7CAFF0", VA = "0x7CAFF0")]
		private bool GetIsAnnivasaryCalculate(DateTime currentDate)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x7CB154", Offset = "0x7CB154", VA = "0x7CB154")]
		public bool GetIsEventFire()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x7CB174", Offset = "0x7CB174", VA = "0x7CB174")]
		public DateManager()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class EventManager : SingletonMonoBehaviour<EventManager>
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventRunner m_runner;

		[Token(Token = "0x17000043")]
		public bool IsRunning
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x7C8398", Offset = "0x7C8398", VA = "0x7C8398")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7CB590", Offset = "0x7CB590", VA = "0x7CB590")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x7CB600", Offset = "0x7CB600", VA = "0x7CB600")]
		private void Update()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x7CB7B8", Offset = "0x7CB7B8", VA = "0x7CB7B8")]
		public void Play(string eventName, [Optional] Action onEnd)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x7CB880", Offset = "0x7CB880", VA = "0x7CB880")]
		public EventManager()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class EventRunner
	{
		[Token(Token = "0x2000075")]
		public enum eCommandType
		{
			[Token(Token = "0x40002F6")]
			Invalid,
			[Token(Token = "0x40002F7")]
			PlayMotion,
			[Token(Token = "0x40002F8")]
			PlayFacial,
			[Token(Token = "0x40002F9")]
			PlayVoice,
			[Token(Token = "0x40002FA")]
			ShowSubtitle,
			[Token(Token = "0x40002FB")]
			Wait,
			[Token(Token = "0x40002FC")]
			FadeIn,
			[Token(Token = "0x40002FD")]
			FadeOut,
			[Token(Token = "0x40002FE")]
			MoveCharacter,
			[Token(Token = "0x40002FF")]
			SetTransform
		}

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EventGroup m_currentEvent;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_currentIndex;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_timer;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<bool> m_checkEndFunc;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action m_onEndEventCallBack;

		[Token(Token = "0x17000044")]
		public bool IsRunning
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x7CB580", Offset = "0x7CB580", VA = "0x7CB580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7CB610", Offset = "0x7CB610", VA = "0x7CB610")]
		public void Run()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x7CB84C", Offset = "0x7CB84C", VA = "0x7CB84C")]
		public void SetEvent(EventGroup eventGroup, [Optional] Action onEnd)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x7CB8C8", Offset = "0x7CB8C8", VA = "0x7CB8C8")]
		private bool PlayMotion(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x7CBA3C", Offset = "0x7CBA3C", VA = "0x7CBA3C")]
		private bool PlayFacial(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x7CBB0C", Offset = "0x7CBB0C", VA = "0x7CBB0C")]
		private bool PlayVoice(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x7CBCA8", Offset = "0x7CBCA8", VA = "0x7CBCA8")]
		private bool ShowSubtitle(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7CBDC4", Offset = "0x7CBDC4", VA = "0x7CBDC4")]
		private bool Wait(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x7CBE3C", Offset = "0x7CBE3C", VA = "0x7CBE3C")]
		private bool FadeIn(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7CBFA0", Offset = "0x7CBFA0", VA = "0x7CBFA0")]
		private bool FadeOut(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7CC104", Offset = "0x7CC104", VA = "0x7CC104")]
		private bool MoveCharacter(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7CC10C", Offset = "0x7CC10C", VA = "0x7CC10C")]
		private bool SetTransform(EventParameter param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7CB5F8", Offset = "0x7CB5F8", VA = "0x7CB5F8")]
		public EventRunner()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class ControllerComponent : ModelComponent
	{
		[Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <CreatePointerCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ControllerComponent <>4__this;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000242")]
				[Address(RVA = "0x7CD1D0", Offset = "0x7CD1D0", VA = "0x7CD1D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000244")]
				[Address(RVA = "0x7CD218", Offset = "0x7CD218", VA = "0x7CD218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x7CC5D4", Offset = "0x7CC5D4", VA = "0x7CC5D4")]
			[DebuggerHidden]
			public <CreatePointerCoroutine>d__38(int <>1__state)
			{
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x7CD0E8", Offset = "0x7CD0E8", VA = "0x7CD0E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x7CD0EC", Offset = "0x7CD0EC", VA = "0x7CD0EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x7CD1D8", Offset = "0x7CD1D8", VA = "0x7CD1D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000305")]
		private const int VELOCITY_BUFFER = 10;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PointLaserComponent m_pointLaser;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] m_velocityArray;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_velocityIndex;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 m_beforePos;

		[Token(Token = "0x17000045")]
		public bool IsUsedMain
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x7CC430", Offset = "0x7CC430", VA = "0x7CC430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x7CC438", Offset = "0x7CC438", VA = "0x7CC438")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool IsAlwaysViewPointLaser
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x7CC444", Offset = "0x7CC444", VA = "0x7CC444")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x7CC44C", Offset = "0x7CC44C", VA = "0x7CC44C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool IsUsePointLaserInGame
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x7CC458", Offset = "0x7CC458", VA = "0x7CC458")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x7CC460", Offset = "0x7CC460", VA = "0x7CC460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool IsUsePointLaserInUI
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x7CC46C", Offset = "0x7CC46C", VA = "0x7CC46C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x7CC474", Offset = "0x7CC474", VA = "0x7CC474")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public InputManager.eActionType DecideAction
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x7CC480", Offset = "0x7CC480", VA = "0x7CC480")]
			[CompilerGenerated]
			get
			{
				return default(InputManager.eActionType);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x7CC488", Offset = "0x7CC488", VA = "0x7CC488")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public InputManager.eActiveHandType HandType
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x7CC490", Offset = "0x7CC490", VA = "0x7CC490")]
			[CompilerGenerated]
			get
			{
				return default(InputManager.eActiveHandType);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x7CC498", Offset = "0x7CC498", VA = "0x7CC498")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public GameObject CurrentModel
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x7CC4A0", Offset = "0x7CC4A0", VA = "0x7CC4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x7CC4A8", Offset = "0x7CC4A8", VA = "0x7CC4A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public PenLightComponent PenlightComponent
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x7CC4B0", Offset = "0x7CC4B0", VA = "0x7CC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x7CC4B8", Offset = "0x7CC4B8", VA = "0x7CC4B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x7CC4C0", Offset = "0x7CC4C0", VA = "0x7CC4C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7CC560", Offset = "0x7CC560", VA = "0x7CC560")]
		[IteratorStateMachine(typeof(<CreatePointerCoroutine>d__38))]
		private IEnumerator CreatePointerCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7CC5FC", Offset = "0x7CC5FC", VA = "0x7CC5FC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7CC64C", Offset = "0x7CC64C", VA = "0x7CC64C", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x7CCAF0", Offset = "0x7CCAF0", VA = "0x7CCAF0", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x7CCC64", Offset = "0x7CCC64", VA = "0x7CCC64")]
		private void UpdateVelocity()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x7CCD0C", Offset = "0x7CCD0C", VA = "0x7CCD0C")]
		private void UpdatePointLaser()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x7CCE20", Offset = "0x7CCE20", VA = "0x7CCE20")]
		public Vector3 CalcVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x7CCED8", Offset = "0x7CCED8", VA = "0x7CCED8")]
		public void SetControllerType(InputManager.eActiveHandType handType)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x7CCC44", Offset = "0x7CCC44", VA = "0x7CCC44")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7CCEE0", Offset = "0x7CCEE0", VA = "0x7CCEE0")]
		public void ChangeTempModel(GameObject model)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7CD074", Offset = "0x7CD074", VA = "0x7CD074")]
		public void OnChangeUsedMain(bool isUsedMain)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7CC7A4", Offset = "0x7CC7A4", VA = "0x7CC7A4")]
		private void SetPointLaserActive(bool isEnable)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7CD080", Offset = "0x7CD080", VA = "0x7CD080")]
		public void InitializePose()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7CD084", Offset = "0x7CD084", VA = "0x7CD084")]
		public ControllerComponent()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class PenLightComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200007A")]
		public enum eLightType
		{
			[Token(Token = "0x4000333")]
			Default,
			[Token(Token = "0x4000334")]
			Red,
			[Token(Token = "0x4000335")]
			Orange,
			[Token(Token = "0x4000336")]
			Yellow,
			[Token(Token = "0x4000337")]
			YellowGreen,
			[Token(Token = "0x4000338")]
			Green,
			[Token(Token = "0x4000339")]
			BlueGreen,
			[Token(Token = "0x400033A")]
			Blue,
			[Token(Token = "0x400033B")]
			Ultramarine,
			[Token(Token = "0x400033C")]
			NavyBlue,
			[Token(Token = "0x400033D")]
			Purple,
			[Token(Token = "0x400033E")]
			ReddishPurple,
			[Token(Token = "0x400033F")]
			White,
			[Token(Token = "0x4000340")]
			Max
		}

		[Token(Token = "0x200007B")]
		public enum eGameEffectType
		{
			[Token(Token = "0x4000342")]
			Off,
			[Token(Token = "0x4000343")]
			Normal,
			[Token(Token = "0x4000344")]
			Special
		}

		[Token(Token = "0x4000315")]
		private const int MAX_POINT = 15;

		[Token(Token = "0x4000316")]
		private const int MAX_EFFECT = 18;

		[Token(Token = "0x4000317")]
		private const string MOVIE_EFFECT_PREFAB_PATH = "Effect/effect01";

		[Token(Token = "0x4000318")]
		private const string TRAIL_EFFECT_POINT = "effectPoint";

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, string[]> TRAIL_EFFECT_LIST;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<eLightType, Color[]> LIGHT_COLOR_LIST;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private eGameEffectType m_currentEffectType;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private eGameEffectType m_keepEffectType;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private readonly float SWING_ANGLE;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_checkPoint;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] m_pointCacheArray;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_insertIndex;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_isCheck;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool m_useParticle;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform m_effectPoint;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ParticleSystem m_normalEffect;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ParticleSystem m_specialEffect;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MatAlphaMoveComponent m_bloomComponent;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material m_lightMat;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private InterpolatorVector3 m_lightColorInterpolator;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InterpolatorVector3 m_bloomColorInterpolator;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int m_vibrationCounter;

		[Token(Token = "0x1700004F")]
		public eLightType CurrentColor
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x7CD220", Offset = "0x7CD220", VA = "0x7CD220")]
			[CompilerGenerated]
			get
			{
				return default(eLightType);
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x7CD228", Offset = "0x7CD228", VA = "0x7CD228")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public ControllerComponent Controller
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x7CD230", Offset = "0x7CD230", VA = "0x7CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x7CD238", Offset = "0x7CD238", VA = "0x7CD238")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform GameJudgePointTrans
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x7CD240", Offset = "0x7CD240", VA = "0x7CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x7CD248", Offset = "0x7CD248", VA = "0x7CD248")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public InputManager.eActiveHandType HandType
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x7CD250", Offset = "0x7CD250", VA = "0x7CD250")]
			[CompilerGenerated]
			get
			{
				return default(InputManager.eActiveHandType);
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x7CD258", Offset = "0x7CD258", VA = "0x7CD258")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool IsActiveLaser
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x7CD260", Offset = "0x7CD260", VA = "0x7CD260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x7CD268", Offset = "0x7CD268", VA = "0x7CD268")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float MoveDist
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x7CD274", Offset = "0x7CD274", VA = "0x7CD274")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x7CD27C", Offset = "0x7CD27C", VA = "0x7CD27C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 CurrentMoveDir
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x7CD284", Offset = "0x7CD284", VA = "0x7CD284")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x7CD290", Offset = "0x7CD290", VA = "0x7CD290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7CD29C", Offset = "0x7CD29C", VA = "0x7CD29C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7CC834", Offset = "0x7CC834", VA = "0x7CC834")]
		public void Initialize(InputManager.eActiveHandType handType)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x7CD73C", Offset = "0x7CD73C", VA = "0x7CD73C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7CD840", Offset = "0x7CD840", VA = "0x7CD840")]
		private void MovieSwingUpdate()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7CDC58", Offset = "0x7CDC58", VA = "0x7CDC58")]
		private void MusicGameSwingUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7CDCC8", Offset = "0x7CDCC8", VA = "0x7CDCC8")]
		public float GetSwingPower()
		{
			return default(float);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7CD3C8", Offset = "0x7CD3C8", VA = "0x7CD3C8")]
		public void SetGameEffect(string sceneName)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x7CD2A4", Offset = "0x7CD2A4", VA = "0x7CD2A4")]
		public void ChangeGameEffect(eGameEffectType type)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7CDDD8", Offset = "0x7CDDD8", VA = "0x7CDDD8")]
		public void PushGameEffect()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7CDDE4", Offset = "0x7CDDE4", VA = "0x7CDDE4")]
		public void PopGameEffect()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x7CDDEC", Offset = "0x7CDDEC", VA = "0x7CDDEC")]
		public void SetLightColor(eLightType type, float time = 0.2f)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x7CE094", Offset = "0x7CE094", VA = "0x7CE094")]
		public void SetLightNextColor()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x7CE0B0", Offset = "0x7CE0B0", VA = "0x7CE0B0")]
		public void SetLightBackColor()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7CE0D0", Offset = "0x7CE0D0", VA = "0x7CE0D0")]
		public void SetUseParticle(bool isUsed)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7CE0DC", Offset = "0x7CE0DC", VA = "0x7CE0DC")]
		public void Vibration(float time, float power, float delay = -1f)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x7CE15C", Offset = "0x7CE15C", VA = "0x7CE15C")]
		public void VibrationContinue(float power, float delay = -1f)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7CE22C", Offset = "0x7CE22C", VA = "0x7CE22C")]
		public void StopVibration()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7CE2E4", Offset = "0x7CE2E4", VA = "0x7CE2E4")]
		public void ForceStopVibration()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7CE39C", Offset = "0x7CE39C", VA = "0x7CE39C")]
		public Transform GetTopPoint()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x7CE3A4", Offset = "0x7CE3A4", VA = "0x7CE3A4")]
		public PenLightComponent()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class PointLaserComponent : GameComponent
	{
		[Token(Token = "0x400034A")]
		private const float DEFAULT_LEN = 0.2f;

		[Token(Token = "0x400034B")]
		private const float CHANGE_TIME = 0.15f;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 m_localScale;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIPointerComponent m_target;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_isPointerUsed;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x17000056")]
		public bool IsActive
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x7CCAD0", Offset = "0x7CCAD0", VA = "0x7CCAD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x7CCAA8", Offset = "0x7CCAA8", VA = "0x7CCAA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public InputManager.eActiveHandType HandType
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x7CEE1C", Offset = "0x7CEE1C", VA = "0x7CEE1C")]
			[CompilerGenerated]
			get
			{
				return default(InputManager.eActiveHandType);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x7CEE14", Offset = "0x7CEE14", VA = "0x7CEE14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7CEE24", Offset = "0x7CEE24", VA = "0x7CEE24")]
		public void SetPointer(UIPointerComponent pointer)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7CEE2C", Offset = "0x7CEE2C", VA = "0x7CEE2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7CEEE4", Offset = "0x7CEEE4", VA = "0x7CEEE4", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7CEEB4", Offset = "0x7CEEB4", VA = "0x7CEEB4")]
		private void SetLength(float len)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7CF248", Offset = "0x7CF248", VA = "0x7CF248")]
		public PointLaserComponent()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class BaseDLCMenuComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x4000351")]
		protected const float COMING_SOON_COLOR = 0.6f;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private SpriteRenderer m_bg;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SpriteRenderer m_frame;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected GameObject m_netErrorIcon;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected TMP_Text m_titleText;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected GameDefine.eMusic m_title;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected string m_viewTitle;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected BasePlatform.BaseProductData m_productData;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7CF2D0", Offset = "0x7CF2D0", VA = "0x7CF2D0")]
		protected void Initialize()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x7CF48C", Offset = "0x7CF48C", VA = "0x7CF48C", Slot = "20")]
		protected virtual void ParamViewSetting()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x7CF4B8", Offset = "0x7CF4B8", VA = "0x7CF4B8", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x7CF798", Offset = "0x7CF798", VA = "0x7CF798")]
		protected void SetBGColor(bool isPlayable)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x7CF7FC", Offset = "0x7CF7FC", VA = "0x7CF7FC", Slot = "21")]
		protected virtual void SetBGColor(Color color)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x7CF818", Offset = "0x7CF818", VA = "0x7CF818", Slot = "22")]
		protected virtual bool IsPreInstall(GameDefine.eMusic title)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x7CF904", Offset = "0x7CF904", VA = "0x7CF904", Slot = "23")]
		protected virtual void OnChangeIAPStatus(BasePlatform.eIAPStatus newStatus)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x7CF908", Offset = "0x7CF908", VA = "0x7CF908", Slot = "24")]
		protected virtual void OnChangeDownloadStatus(BasePlatform.eDownloadStatus newStatus)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x7CF90C", Offset = "0x7CF90C", VA = "0x7CF90C", Slot = "25")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x7CF9B0", Offset = "0x7CF9B0", VA = "0x7CF9B0", Slot = "15")]
		public override void Close(float closeTime = 0.2f)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x7CFC28", Offset = "0x7CFC28", VA = "0x7CFC28", Slot = "26")]
		protected virtual bool IsDefaultMusic()
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7CFD30", Offset = "0x7CFD30", VA = "0x7CFD30")]
		public BaseDLCMenuComponent()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public abstract class BaseMenuItemComponent : ModelComponent
	{
		[Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class <ExitItemCloseCoroutine>d__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseMenuItemComponent <>4__this;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float subSpeed;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x7D0EEC", Offset = "0x7D0EEC", VA = "0x7D0EEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A2")]
				[Address(RVA = "0x7D0F34", Offset = "0x7D0F34", VA = "0x7D0F34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x7D0C80", Offset = "0x7D0C80", VA = "0x7D0C80")]
			[DebuggerHidden]
			public <ExitItemCloseCoroutine>d__50(int <>1__state)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x7D0D6C", Offset = "0x7D0D6C", VA = "0x7D0D6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x7D0D70", Offset = "0x7D0D70", VA = "0x7D0D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x7D0EF4", Offset = "0x7D0EF4", VA = "0x7D0EF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000359")]
		private const float BUTTON_VIBRATION_TIME = 0.02f;

		[Token(Token = "0x400035A")]
		private const float BUTTON_VIBRATION_POWER = 0.5f;

		[Token(Token = "0x400035B")]
		protected const float OPEN_CLOSE_TIME = 0.2f;

		[Token(Token = "0x400035C")]
		private const float SELECTING_ROTATE_SPEED = 20f;

		[Token(Token = "0x400035D")]
		private const float PLAY_VOICE_DELAY = 0.25f;

		[Token(Token = "0x400035E")]
		private const float BETWEEN_HEIGHT = 0.2f;

		[Token(Token = "0x400035F")]
		private const float MOVE_HEIGHT_SPEED = 2f;

		[Token(Token = "0x4000360")]
		private const string DEFAULT_ANIM = "Default";

		[Token(Token = "0x4000361")]
		private const string ENTER_ANIM = "Enter";

		[Token(Token = "0x4000362")]
		private const string EXIT_ANIM = "Exit";

		[Token(Token = "0x4000363")]
		private const float SQR_NOT_MOVE_DIST = 0.0025000002f;

		[Token(Token = "0x4000364")]
		private const float BASE_HEIGHT_DIFF = 0.5f;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private InterpolatorVector3 m_moveInterpolator;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SceneHomeComponent m_scene;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_moveToPos;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_selectTimer;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected bool m_isSelecting;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected string m_enterVoiceName;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_voiceTimer;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool[] m_isOnPointer;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected bool m_isCloseWhenDecide;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		protected bool m_isHide;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		protected bool m_isComingSoon;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject m_comingSoonText;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected bool m_canSelect;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		protected bool m_isMoving;

		[Token(Token = "0x17000058")]
		protected SceneHomeComponent Scene
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x7CFE28", Offset = "0x7CFE28", VA = "0x7CFE28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public bool IsHide
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x7CFEE4", Offset = "0x7CFEE4", VA = "0x7CFEE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x7CFEEC", Offset = "0x7CFEEC", VA = "0x7CFEEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool IsMoveActive
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x7CFEF8", Offset = "0x7CFEF8", VA = "0x7CFEF8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x7CFF00", Offset = "0x7CFF00", VA = "0x7CFF00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x7CFF0C", Offset = "0x7CFF0C", VA = "0x7CFF0C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x7CFF84", Offset = "0x7CFF84", VA = "0x7CFF84", Slot = "11")]
		public virtual void Initialize(Vector3 pos)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x7D0030", Offset = "0x7D0030", VA = "0x7D0030", Slot = "12")]
		public virtual void Initialize(Vector3 pos, float forwardDistance)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x7CF660", Offset = "0x7CF660", VA = "0x7CF660", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x7D00DC", Offset = "0x7D00DC", VA = "0x7D00DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x7D01B0", Offset = "0x7D01B0", VA = "0x7D01B0", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x7D0718", Offset = "0x7D0718", VA = "0x7D0718", Slot = "8")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x7D0720", Offset = "0x7D0720", VA = "0x7D0720", Slot = "13")]
		public virtual void Open(float openTime = 0.2f)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x7D087C", Offset = "0x7D087C", VA = "0x7D087C", Slot = "14")]
		protected virtual void OnOpen()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x7CFB78", Offset = "0x7CFB78", VA = "0x7CFB78", Slot = "15")]
		public virtual void Close(float closeTime = 0.2f)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x7D091C", Offset = "0x7D091C", VA = "0x7D091C", Slot = "16")]
		protected virtual void OnClose()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x7D0920", Offset = "0x7D0920", VA = "0x7D0920", Slot = "17")]
		protected virtual void OnDecide()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x7D0A08", Offset = "0x7D0A08", VA = "0x7D0A08", Slot = "18")]
		protected virtual void OnEnter(InputManager.eActiveHandType handType, bool useVibration = true)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x7D0B74", Offset = "0x7D0B74", VA = "0x7D0B74", Slot = "19")]
		protected virtual void OnExit()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x7D0BFC", Offset = "0x7D0BFC", VA = "0x7D0BFC")]
		[IteratorStateMachine(typeof(<ExitItemCloseCoroutine>d__50))]
		private IEnumerator ExitItemCloseCoroutine(float subSpeed = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x7D0910", Offset = "0x7D0910", VA = "0x7D0910")]
		protected void StopVoiceTimer()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x7D0CA8", Offset = "0x7D0CA8", VA = "0x7D0CA8")]
		public void SetMove(Vector3 from, Vector3 to, float time)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7D0D60", Offset = "0x7D0D60", VA = "0x7D0D60")]
		public void SetHide(bool isHide)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7CF910", Offset = "0x7CF910", VA = "0x7CF910")]
		protected void CalcForward()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7CFD34", Offset = "0x7CFD34", VA = "0x7CFD34")]
		protected BaseMenuItemComponent()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class BaseMenuItemGroup
	{
		[Token(Token = "0x2000084")]
		public enum eSortType
		{
			[Token(Token = "0x4000386")]
			Default,
			[Token(Token = "0x4000387")]
			AlphabeticalOder,
			[Token(Token = "0x4000388")]
			Having,
			[Token(Token = "0x4000389")]
			MAX
		}

		[Token(Token = "0x4000379")]
		private const float BETWEEN_ANGLE = 36f;

		[Token(Token = "0x400037A")]
		protected const float ICON_BETWEEN_ANGLE = 26.666666f;

		[Token(Token = "0x400037B")]
		private const float NEXT_ICON_BETWEEN_ANGLE = 23.333334f;

		[Token(Token = "0x400037C")]
		private const float ICON_NEXT_ADJ_DIST = -0.05f;

		[Token(Token = "0x400037D")]
		protected const int MAX_SIDE_NUM = 6;

		[Token(Token = "0x400037E")]
		protected const int VIEW_ITEM_NUM = 4;

		[Token(Token = "0x400037F")]
		private const float OPEN_CLOSE_ANIM_RATE = 0.8f;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<BaseMenuItemComponent> m_menuItemList;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected int m_maxItemNum;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected int m_currentChooseItem;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int m_CurrentIndex;

		[Token(Token = "0x1700005D")]
		public MenuComponent.eMenuType Type
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x7D0F3C", Offset = "0x7D0F3C", VA = "0x7D0F3C")]
			[CompilerGenerated]
			get
			{
				return default(MenuComponent.eMenuType);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x7D0F44", Offset = "0x7D0F44", VA = "0x7D0F44")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		protected NextItemMenuComponent LeftArrow
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x7D0F4C", Offset = "0x7D0F4C", VA = "0x7D0F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		protected NextItemMenuComponent RightArrow
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x7D1000", Offset = "0x7D1000", VA = "0x7D1000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x7D10B4", Offset = "0x7D10B4", VA = "0x7D10B4")]
		public bool IsEndInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x7D118C", Offset = "0x7D118C", VA = "0x7D118C")]
		public void AllActiveDisable()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x7D1228", Offset = "0x7D1228", VA = "0x7D1228", Slot = "4")]
		public virtual void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x60002AA")]
		protected T CreateMenuItem<T>(string modelName) where T : BaseMenuItemComponent
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x7D15F4", Offset = "0x7D15F4", VA = "0x7D15F4")]
		protected Vector3 CalcItemPos(int index, int maxSideNum, float betweenAngle = 36f, float height = 1.2f, float adjDist = 0f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x7D16D8", Offset = "0x7D16D8", VA = "0x7D16D8", Slot = "5")]
		public virtual void OnOpen()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x7D1780", Offset = "0x7D1780", VA = "0x7D1780")]
		public void OnClose()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x7D1828", Offset = "0x7D1828", VA = "0x7D1828")]
		public int NextItem(int add, float moveTime)
		{
			return default(int);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x7D1CA0", Offset = "0x7D1CA0", VA = "0x7D1CA0", Slot = "6")]
		protected virtual void UpdateIconData(int iconIndex, int newItemIndex, bool isHide = false)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x7D1CA4", Offset = "0x7D1CA4", VA = "0x7D1CA4")]
		protected void CreateNextItem(int maxItemNum, string baseModelName, MenuComponent menu)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x7D1344", Offset = "0x7D1344", VA = "0x7D1344")]
		public void Sort(eSortType sortType, bool isInit = false)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x7D2010", Offset = "0x7D2010", VA = "0x7D2010", Slot = "7")]
		protected virtual void SortDefault()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x7D2014", Offset = "0x7D2014", VA = "0x7D2014", Slot = "8")]
		protected virtual void SortAlphabeticalOrder()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x7D2018", Offset = "0x7D2018", VA = "0x7D2018", Slot = "9")]
		protected virtual void SortHaving()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x7D201C", Offset = "0x7D201C", VA = "0x7D201C")]
		public BaseMenuItemGroup()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class DLCMenuComponent : BaseDLCMenuComponent
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UITextComponent m_text;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIArrowButtonComponent m_upArrow;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private UIArrowButtonComponent m_downArrow;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextScroller m_textScroller;

		[Token(Token = "0x17000060")]
		public ShopParameter Param
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x7D20B4", Offset = "0x7D20B4", VA = "0x7D20B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x7D20BC", Offset = "0x7D20BC", VA = "0x7D20BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7D20CC", Offset = "0x7D20CC", VA = "0x7D20CC")]
		public void Initialize(ShopParameter param, bool isHide)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x7D21FC", Offset = "0x7D21FC", VA = "0x7D21FC", Slot = "11")]
		public override void Initialize(Vector3 pos)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x7D2214", Offset = "0x7D2214", VA = "0x7D2214", Slot = "20")]
		protected override void ParamViewSetting()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7D22E0", Offset = "0x7D22E0", VA = "0x7D22E0", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x7D2458", Offset = "0x7D2458", VA = "0x7D2458", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x7D248C", Offset = "0x7D248C", VA = "0x7D248C", Slot = "14")]
		protected override void OnOpen()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x7D26F0", Offset = "0x7D26F0", VA = "0x7D26F0", Slot = "23")]
		protected override void OnChangeIAPStatus(BasePlatform.eIAPStatus newStatus)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x7D2730", Offset = "0x7D2730", VA = "0x7D2730", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x7D2810", Offset = "0x7D2810", VA = "0x7D2810")]
		public DLCMenuComponent()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MenuComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x2000087")]
		public enum eMenuType
		{
			[Token(Token = "0x400039D")]
			Invalid,
			[Token(Token = "0x400039E")]
			Top,
			[Token(Token = "0x400039F")]
			Movie,
			[Token(Token = "0x40003A0")]
			MusicGame,
			[Token(Token = "0x40003A1")]
			View,
			[Token(Token = "0x40003A2")]
			Shop,
			[Token(Token = "0x40003A3")]
			Max
		}

		[Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class <SortItemCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MenuComponent <>4__this;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseMenuItemGroup.eSortType type;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private eMenuType <current>5__2;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0x7D38DC", Offset = "0x7D38DC", VA = "0x7D38DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0x7D3924", Offset = "0x7D3924", VA = "0x7D3924", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x7D3250", Offset = "0x7D3250", VA = "0x7D3250")]
			[DebuggerHidden]
			public <SortItemCoroutine>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x7D377C", Offset = "0x7D377C", VA = "0x7D377C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7D3780", Offset = "0x7D3780", VA = "0x7D3780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x7D38E4", Offset = "0x7D38E4", VA = "0x7D38E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400038F")]
		public const float ICON_DIST = 1.5f;

		[Token(Token = "0x4000390")]
		public const float NEXT_MOVE_TIME = 0.3f;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 RETURN_ICON_POS;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly Vector3 SORT_ICON_POS;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BaseMenuItemGroup> m_itemGroupList;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ReturnItemComponent m_returnItem;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SortItemComponent m_sortItem;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_nextTimer;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_nextContinueCount;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<float> m_continueAction;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_continueActionValue;

		[Token(Token = "0x17000061")]
		public eMenuType Current
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x7D28C0", Offset = "0x7D28C0", VA = "0x7D28C0")]
			[CompilerGenerated]
			get
			{
				return default(eMenuType);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x7D28C8", Offset = "0x7D28C8", VA = "0x7D28C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public eMenuType Before
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x7D28D0", Offset = "0x7D28D0", VA = "0x7D28D0")]
			[CompilerGenerated]
			get
			{
				return default(eMenuType);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x7D28D8", Offset = "0x7D28D8", VA = "0x7D28D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool CanNextMove
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x7D28E0", Offset = "0x7D28E0", VA = "0x7D28E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x7D28F0", Offset = "0x7D28F0", VA = "0x7D28F0")]
		public void SetNextTimer(float time)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7D28F8", Offset = "0x7D28F8", VA = "0x7D28F8")]
		public bool IsEndInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7D299C", Offset = "0x7D299C", VA = "0x7D299C")]
		public void AllActiveDisable()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x7D2A24", Offset = "0x7D2A24", VA = "0x7D2A24", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x7D3090", Offset = "0x7D3090", VA = "0x7D3090")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x7D3100", Offset = "0x7D3100", VA = "0x7D3100")]
		public void SortItem(BaseMenuItemGroup.eSortType type)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x7D31A4", Offset = "0x7D31A4", VA = "0x7D31A4")]
		public void SortItemNext()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7D3120", Offset = "0x7D3120", VA = "0x7D3120")]
		[IteratorStateMachine(typeof(<SortItemCoroutine>d__29))]
		private IEnumerator SortItemCoroutine(BaseMenuItemGroup.eSortType type)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7D2EE8", Offset = "0x7D2EE8", VA = "0x7D2EE8")]
		private void CreateReturnItem()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x7D2FB0", Offset = "0x7D2FB0", VA = "0x7D2FB0")]
		private void CreateSrotItem()
		{
		}

		[Token(Token = "0x60002D3")]
		private T CreateMenuItem<T>(string modelName) where T : BaseMenuItemComponent
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x7D3278", Offset = "0x7D3278", VA = "0x7D3278")]
		public void OpenNext(eMenuType type)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x7D33D8", Offset = "0x7D33D8", VA = "0x7D33D8")]
		public void CloseCurrent()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x7D3528", Offset = "0x7D3528", VA = "0x7D3528")]
		public void CloseAll()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x7D355C", Offset = "0x7D355C", VA = "0x7D355C")]
		public BaseMenuItemGroup.eSortType GetCurrentSortType()
		{
			return default(BaseMenuItemGroup.eSortType);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x7D3618", Offset = "0x7D3618", VA = "0x7D3618")]
		public void SetContinueNext(int count, Action<float> action, float time)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x7D3674", Offset = "0x7D3674", VA = "0x7D3674")]
		public MenuComponent()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class MovieIconGroup : BaseMenuItemGroup
	{
		[Token(Token = "0x40003A9")]
		private const string ICON_NAME = "MovieIcon";

		[Token(Token = "0x40003AA")]
		private const string ARROW_NAME = "MovieArraw";

		[Token(Token = "0x40003AB")]
		private const string DELETE_NAME = "DeletedIcon";

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MovieParameter> m_sortedParamList;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x7D2E58", Offset = "0x7D2E58", VA = "0x7D2E58")]
		public MovieIconGroup()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7D392C", Offset = "0x7D392C", VA = "0x7D392C", Slot = "4")]
		public override void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x7D3ED8", Offset = "0x7D3ED8", VA = "0x7D3ED8", Slot = "6")]
		protected override void UpdateIconData(int iconIndex, int newItemIndex, bool isHide = false)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x7D3FEC", Offset = "0x7D3FEC", VA = "0x7D3FEC", Slot = "7")]
		protected override void SortDefault()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x7D409C", Offset = "0x7D409C", VA = "0x7D409C", Slot = "8")]
		protected override void SortAlphabeticalOrder()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x7D4364", Offset = "0x7D4364", VA = "0x7D4364", Slot = "9")]
		protected override void SortHaving()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class MusicDLCMenuComponent : BaseDLCMenuComponent
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SpriteRenderer m_icon;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject m_buy;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject m_downloading;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TMP_Text m_prodText;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TMP_Text m_titleNoProdText;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TMP_Text m_dlPriceText;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TMP_Text m_dlRateText;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected string m_viewProd;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected Sprite m_iconTexture;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private uint m_dlTotal;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int m_dlTransferred;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool m_isDlStarted;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x7D47CC", Offset = "0x7D47CC", VA = "0x7D47CC", Slot = "20")]
		protected override void ParamViewSetting()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x7D4C14", Offset = "0x7D4C14", VA = "0x7D4C14", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7D4EA0", Offset = "0x7D4EA0", VA = "0x7D4EA0", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7D5000", Offset = "0x7D5000", VA = "0x7D5000", Slot = "21")]
		protected override void SetBGColor(Color color)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x7D5060", Offset = "0x7D5060", VA = "0x7D5060", Slot = "14")]
		protected override void OnOpen()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x7D5498", Offset = "0x7D5498", VA = "0x7D5498", Slot = "23")]
		protected override void OnChangeIAPStatus(BasePlatform.eIAPStatus newStatus)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x7D5504", Offset = "0x7D5504", VA = "0x7D5504", Slot = "24")]
		protected override void OnChangeDownloadStatus(BasePlatform.eDownloadStatus newStatus)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x7D5454", Offset = "0x7D5454", VA = "0x7D5454")]
		public void SetDLIconActive(bool isEnabled)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x7D4EB8", Offset = "0x7D4EB8", VA = "0x7D4EB8")]
		private void UpdateDLRate()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x7D5434", Offset = "0x7D5434", VA = "0x7D5434")]
		private void SetActiveBuyIcon(bool isActive)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x7D55A4", Offset = "0x7D55A4", VA = "0x7D55A4", Slot = "27")]
		protected virtual void SetPlayableGameData(ref bool isPlayable)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x7D55A8", Offset = "0x7D55A8", VA = "0x7D55A8", Slot = "28")]
		public virtual void ResetDLValue()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x7D55B8", Offset = "0x7D55B8", VA = "0x7D55B8")]
		public MusicDLCMenuComponent()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class MusicGameIconGroup : BaseMenuItemGroup
	{
		[Token(Token = "0x40003BB")]
		private const string ICON_NAME = "MusicGameIcon";

		[Token(Token = "0x40003BC")]
		private const string ARROW_NAME = "MusicGameArraw";

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MusicGameParameter> m_sortedParamList;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x7D2DC8", Offset = "0x7D2DC8", VA = "0x7D2DC8")]
		public MusicGameIconGroup()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x7D55C4", Offset = "0x7D55C4", VA = "0x7D55C4", Slot = "4")]
		public override void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x7D57E0", Offset = "0x7D57E0", VA = "0x7D57E0")]
		private void SetItems()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x7D5B3C", Offset = "0x7D5B3C", VA = "0x7D5B3C", Slot = "6")]
		protected override void UpdateIconData(int iconIndex, int newItemIndex, bool isHide = false)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x7D5C4C", Offset = "0x7D5C4C", VA = "0x7D5C4C", Slot = "7")]
		protected override void SortDefault()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x7D5CB0", Offset = "0x7D5CB0", VA = "0x7D5CB0", Slot = "8")]
		protected override void SortAlphabeticalOrder()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x7D5FFC", Offset = "0x7D5FFC", VA = "0x7D5FFC", Slot = "9")]
		protected override void SortHaving()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class MusicGameMenuComponent : MusicDLCMenuComponent
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int m_scoreEasy;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int m_scoreNormal;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private int m_scoreHard;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private SpriteRenderer m_rankEasyIcon;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private SpriteRenderer m_rankNormalIcon;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private SpriteRenderer m_rankHardIcon;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private TMP_Text m_scoreEasyText;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private TMP_Text m_scoreNormalText;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private TMP_Text m_scoreHardText;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Transform m_normalTitle;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private MusicGameParameter m_param;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private SpriteRenderer m_easyOldIcon;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private SpriteRenderer m_normalOldIcon;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private SpriteRenderer m_hardOldIcon;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7D5A4C", Offset = "0x7D5A4C", VA = "0x7D5A4C")]
		public void Initialize(MusicGameParameter param, bool isHide)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x7D6464", Offset = "0x7D6464", VA = "0x7D6464")]
		private bool GetScore(GameDefine.eMusic title, int level, ref int score)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x7D6518", Offset = "0x7D6518", VA = "0x7D6518", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x7D689C", Offset = "0x7D689C", VA = "0x7D689C", Slot = "20")]
		protected override void ParamViewSetting()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7D6BD8", Offset = "0x7D6BD8", VA = "0x7D6BD8", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x7D6DB8", Offset = "0x7D6DB8", VA = "0x7D6DB8", Slot = "27")]
		protected override void SetPlayableGameData(ref bool isPlayable)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7D6D18", Offset = "0x7D6D18", VA = "0x7D6D18")]
		private void OpenMusicGameWindowu()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x7D6DE4", Offset = "0x7D6DE4", VA = "0x7D6DE4")]
		public MusicGameMenuComponent()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class NextItemMenuComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x40003CE")]
		private const float TIME_WHEN_CONTINUE = 0.05f;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action<float> m_decideAction;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_isShow;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MenuComponent m_menu;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_isRight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int m_pageNum;

		[Token(Token = "0x17000066")]
		public bool IsRight
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x7D6E10", Offset = "0x7D6E10", VA = "0x7D6E10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x7D6E18", Offset = "0x7D6E18", VA = "0x7D6E18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool IsShow
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x7D6E24", Offset = "0x7D6E24", VA = "0x7D6E24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x7D6E2C", Offset = "0x7D6E2C", VA = "0x7D6E2C")]
			private set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7D1FB8", Offset = "0x7D1FB8", VA = "0x7D1FB8")]
		public void Initialize(Action<float> decideAction, bool isShow, MenuComponent menu, bool isRight, int pageNum)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x7D6E38", Offset = "0x7D6E38", VA = "0x7D6E38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7D1C60", Offset = "0x7D1C60", VA = "0x7D1C60")]
		public void SetShow(bool isShow)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x7D7074", Offset = "0x7D7074", VA = "0x7D7074", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x7D6FA0", Offset = "0x7D6FA0", VA = "0x7D6FA0")]
		public void Next(float time)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x7D715C", Offset = "0x7D715C", VA = "0x7D715C", Slot = "20")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x7D7160", Offset = "0x7D7160", VA = "0x7D7160", Slot = "13")]
		public override void Open(float openTime = 0.2f)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x7D7170", Offset = "0x7D7170", VA = "0x7D7170", Slot = "14")]
		protected override void OnOpen()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7D7218", Offset = "0x7D7218", VA = "0x7D7218", Slot = "16")]
		protected override void OnClose()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x7D72B8", Offset = "0x7D72B8", VA = "0x7D72B8")]
		public NextItemMenuComponent()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class ReturnItemComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x17000068")]
		public MenuComponent.eMenuType ReturnMenu
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x7D82BC", Offset = "0x7D82BC", VA = "0x7D82BC")]
			[CompilerGenerated]
			get
			{
				return default(MenuComponent.eMenuType);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x7D82C4", Offset = "0x7D82C4", VA = "0x7D82C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x7D82CC", Offset = "0x7D82CC", VA = "0x7D82CC", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x7D8348", Offset = "0x7D8348", VA = "0x7D8348")]
		public ReturnItemComponent()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class ShopIconGroup : BaseMenuItemGroup
	{
		[Token(Token = "0x40003D5")]
		private const string ICON_NAME = "DLCIcon";

		[Token(Token = "0x40003D6")]
		private const string ARROW_NAME = "DLCArraw";

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ShopParameter> m_shopParamList;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x7D8358", Offset = "0x7D8358", VA = "0x7D8358")]
		public ShopIconGroup()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x7D83EC", Offset = "0x7D83EC", VA = "0x7D83EC", Slot = "4")]
		public override void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x7D894C", Offset = "0x7D894C", VA = "0x7D894C", Slot = "6")]
		protected override void UpdateIconData(int iconIndex, int newItemIndex, bool isHide = false)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x7D8A64", Offset = "0x7D8A64", VA = "0x7D8A64", Slot = "5")]
		public override void OnOpen()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class SortItemComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private MenuComponent m_menu;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TMP_Text m_description;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x7D8F10", Offset = "0x7D8F10", VA = "0x7D8F10")]
		public void Initialize(MenuComponent menu)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x7D906C", Offset = "0x7D906C", VA = "0x7D906C", Slot = "13")]
		public override void Open(float openTime = 0.2f)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x7D91C8", Offset = "0x7D91C8", VA = "0x7D91C8", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x7D90C0", Offset = "0x7D90C0", VA = "0x7D90C0")]
		private string GetTypeText()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x7D934C", Offset = "0x7D934C", VA = "0x7D934C")]
		public SortItemComponent()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class TopIconGroup : BaseMenuItemGroup
	{
		[Token(Token = "0x40003DD")]
		private const float BETWEEN_ANGLE = 25f;

		[Token(Token = "0x40003DE")]
		private const string TOP_ICON_BASE_NAME = "TopIcon_";

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MenuComponent.eMenuType[] nextTypesArray;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] voiceNames;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x7D9530", Offset = "0x7D9530", VA = "0x7D9530")]
		public TopIconGroup()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x7D9550", Offset = "0x7D9550", VA = "0x7D9550", Slot = "4")]
		public override void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x7D964C", Offset = "0x7D964C", VA = "0x7D964C")]
		private void CreateItemsVR()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class TopMenuComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private MenuComponent.eMenuType m_nextMenu;

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x7D99FC", Offset = "0x7D99FC", VA = "0x7D99FC")]
		public void Initialize(MenuComponent.eMenuType next, string enterVoiceName)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x7D9A0C", Offset = "0x7D9A0C", VA = "0x7D9A0C", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x7D9A6C", Offset = "0x7D9A6C", VA = "0x7D9A6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x7D9A74", Offset = "0x7D9A74", VA = "0x7D9A74")]
		public TopMenuComponent()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ViewIconGroup : BaseMenuItemGroup
	{
		[Token(Token = "0x40003E2")]
		private const string ICON_NAME = "ViewIcon";

		[Token(Token = "0x40003E3")]
		private const string ARROW_NAME = "ViewArraw";

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MusicGameParameter> m_sortedParamList;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x7D9A7C", Offset = "0x7D9A7C", VA = "0x7D9A7C")]
		public ViewIconGroup()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x7D9B10", Offset = "0x7D9B10", VA = "0x7D9B10", Slot = "4")]
		public override void CreateItems(MenuComponent menu)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x7DA0E8", Offset = "0x7DA0E8", VA = "0x7DA0E8", Slot = "6")]
		protected override void UpdateIconData(int iconIndex, int newItemIndex, bool isHide = false)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7DA1F8", Offset = "0x7DA1F8", VA = "0x7DA1F8", Slot = "7")]
		protected override void SortDefault()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7DA258", Offset = "0x7DA258", VA = "0x7DA258", Slot = "8")]
		protected override void SortAlphabeticalOrder()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x7DA5A0", Offset = "0x7DA5A0", VA = "0x7DA5A0", Slot = "9")]
		protected override void SortHaving()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class ViewMenuComponent : MusicDLCMenuComponent
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private MusicGameParameter m_param;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x7D9FF4", Offset = "0x7D9FF4", VA = "0x7D9FF4")]
		public void Initialize(MusicGameParameter param, bool isHide)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x7DAA08", Offset = "0x7DAA08", VA = "0x7DAA08", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x7DAA30", Offset = "0x7DAA30", VA = "0x7DAA30", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x7DAC18", Offset = "0x7DAC18", VA = "0x7DAC18", Slot = "27")]
		protected override void SetPlayableGameData(ref bool isPlayable)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x7DAB74", Offset = "0x7DAB74", VA = "0x7DAB74")]
		private void OpenViewMenuWindow()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x7DAC44", Offset = "0x7DAC44", VA = "0x7DAC44")]
		public ViewMenuComponent()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class BasePlayerMover
	{
		[Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class <MoveCheckCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BasePlayerMover <>4__this;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator moveCoroutine;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float coolTime;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x7DB2EC", Offset = "0x7DB2EC", VA = "0x7DB2EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x7DB334", Offset = "0x7DB334", VA = "0x7DB334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x7DAD74", Offset = "0x7DAD74", VA = "0x7DAD74")]
			[DebuggerHidden]
			public <MoveCheckCoroutine>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x7DB1EC", Offset = "0x7DB1EC", VA = "0x7DB1EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x7DB1F0", Offset = "0x7DB1F0", VA = "0x7DB1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x7DB2F4", Offset = "0x7DB2F4", VA = "0x7DB2F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class <AngleMoveCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float moveAngle;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x7DB528", Offset = "0x7DB528", VA = "0x7DB528", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x7DB570", Offset = "0x7DB570", VA = "0x7DB570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x7DAF60", Offset = "0x7DAF60", VA = "0x7DAF60")]
			[DebuggerHidden]
			public <AngleMoveCoroutine>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x7DB33C", Offset = "0x7DB33C", VA = "0x7DB33C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x7DB340", Offset = "0x7DB340", VA = "0x7DB340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x7DB530", Offset = "0x7DB530", VA = "0x7DB530", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E8")]
		private const float ANGLE_ROTATION = 30f;

		[Token(Token = "0x40003E9")]
		private const float MOVE_COOL_TIME = 0.3f;

		[Token(Token = "0x40003EA")]
		private const float ANGLE_COOL_TIME = 0.1f;

		[Token(Token = "0x40003EB")]
		protected const float FADE_OUT_TIME = 0.1f;

		[Token(Token = "0x40003EC")]
		protected const float FADE_IN_TIME = 0.1f;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected PlayerComponent m_player;

		[Token(Token = "0x17000069")]
		public bool IsMoving
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x7DAC70", Offset = "0x7DAC70", VA = "0x7DAC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x7DAC78", Offset = "0x7DAC78", VA = "0x7DAC78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public ControllerComponent Controller
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x7DAC84", Offset = "0x7DAC84", VA = "0x7DAC84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x7DAC8C", Offset = "0x7DAC8C", VA = "0x7DAC8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7DAC94", Offset = "0x7DAC94", VA = "0x7DAC94", Slot = "4")]
		public virtual void Initialize(PlayerComponent player)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7DACD0", Offset = "0x7DACD0", VA = "0x7DACD0", Slot = "5")]
		public virtual void OnUpdateMove(bool isEnable)
		{
		}

		[Token(Token = "0x6000346")]
		protected abstract IEnumerator MoveCoroutine();

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x7DACD4", Offset = "0x7DACD4", VA = "0x7DACD4")]
		[IteratorStateMachine(typeof(<MoveCheckCoroutine>d__17))]
		private IEnumerator MoveCheckCoroutine(IEnumerator moveCoroutine, float coolTime = 0.3f)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7DAD9C", Offset = "0x7DAD9C", VA = "0x7DAD9C")]
		protected void Move()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7DADEC", Offset = "0x7DADEC", VA = "0x7DADEC")]
		public void OnUpdateAngle()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x7DAEF0", Offset = "0x7DAEF0", VA = "0x7DAEF0")]
		[IteratorStateMachine(typeof(<AngleMoveCoroutine>d__20))]
		private IEnumerator AngleMoveCoroutine(float moveAngle)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7DAF88", Offset = "0x7DAF88", VA = "0x7DAF88")]
		public void ResetAngle()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7DB080", Offset = "0x7DB080", VA = "0x7DB080")]
		protected Vector3 GetMovedPlayerPos(Vector3 target)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x7DB14C", Offset = "0x7DB14C", VA = "0x7DB14C")]
		public void ForcedMove(Vector3 pos, bool isCalcRealPos = true)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x7DACB0", Offset = "0x7DACB0", VA = "0x7DACB0")]
		protected void SetRightController()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x7DB1C4", Offset = "0x7DB1C4", VA = "0x7DB1C4")]
		protected void SetLeftController()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x7DB1E4", Offset = "0x7DB1E4", VA = "0x7DB1E4")]
		protected BasePlayerMover()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class BaseTargetPlayerMover : BasePlayerMover
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int FLOOR_MASK;

		[Token(Token = "0x40003F9")]
		private const float MAX_MOVE_DIST = 7f;

		[Token(Token = "0x40003FA")]
		private const float MAX_BEZIER_UP = 2f;

		[Token(Token = "0x40003FB")]
		private const float NOT_MOVE_DIST_SQR = 0.09f;

		[Token(Token = "0x40003FC")]
		private const int MAX_BEZIER_POINT_NUM = 20;

		[Token(Token = "0x40003FD")]
		private const float TARGET_ADJUST_RATE = 0.2f;

		[Token(Token = "0x40003FE")]
		private const float TARGET_ADD_Y = 0.01f;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LineRenderer m_lineRenderer;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool m_isShowTarget;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool m_isTargetUpdate;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected Vector3 m_targetPoint;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_adjustTargetPoint;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastHit[] hitArray;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3[] linePointArray;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator m_targetAnimator;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private InputManager.eActionType m_moveInputType;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private InputManager.eActionType m_otherInputType;

		[Token(Token = "0x1700006F")]
		public bool IsShowTarget
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x7DB578", Offset = "0x7DB578", VA = "0x7DB578")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		protected Vector3 TargetAnimForward
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x7DB580", Offset = "0x7DB580", VA = "0x7DB580")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000071")]
		public bool IsForwardToChara
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x7DB5B4", Offset = "0x7DB5B4", VA = "0x7DB5B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x7DB5A8", Offset = "0x7DB5A8", VA = "0x7DB5A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x7DB5BC", Offset = "0x7DB5BC", VA = "0x7DB5BC")]
		public void SetTargetAnimator(Animator anim)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7DB638", Offset = "0x7DB638", VA = "0x7DB638", Slot = "4")]
		public override void Initialize(PlayerComponent player)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x7DB870", Offset = "0x7DB870", VA = "0x7DB870", Slot = "5")]
		public override void OnUpdateMove(bool isEnable)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7DBA08", Offset = "0x7DBA08", VA = "0x7DBA08")]
		private bool UpdateTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7DBD68", Offset = "0x7DBD68", VA = "0x7DBD68")]
		private void ShowUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x7DC470", Offset = "0x7DC470", VA = "0x7DC470")]
		protected Vector3 GetMovedPlayerPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x7DC47C", Offset = "0x7DC47C", VA = "0x7DC47C")]
		protected BaseTargetPlayerMover()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class MoveAreaComponent : MonoBehaviour
	{
		[Token(Token = "0x400040A")]
		private const float ALPHA_MAX = 0.4f;

		[Token(Token = "0x400040B")]
		private const float ANIM_TIME = 0.5f;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer m_mesh;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_areaSharedMat;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InterpolatorFloat m_alphaInterpolator;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_beforeIsShow;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerComponent m_playerCache;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color m_color;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x7DC6D0", Offset = "0x7DC6D0", VA = "0x7DC6D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x7DC794", Offset = "0x7DC794", VA = "0x7DC794")]
		private void Update()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x7DC928", Offset = "0x7DC928", VA = "0x7DC928")]
		public MoveAreaComponent()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PlayerMoveController
	{
		[Token(Token = "0x20000A0")]
		public enum eType
		{
			[Token(Token = "0x400041A")]
			Invalid,
			[Token(Token = "0x400041B")]
			Teleport,
			[Token(Token = "0x400041C")]
			Shift
		}

		[Token(Token = "0x4000412")]
		private const string PREFAB_PATH = "Prefab/WarpTarget";

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BasePlayerMover m_playerMover;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayerComponent m_player;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator m_targetPoint;

		[Token(Token = "0x17000072")]
		public BasePlayerMover PlayerMover
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x7DC99C", Offset = "0x7DC99C", VA = "0x7DC99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public bool IsSystemEnable
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x7DC9A4", Offset = "0x7DC9A4", VA = "0x7DC9A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x7DC9AC", Offset = "0x7DC9AC", VA = "0x7DC9AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsGameEnable
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x7DC9B8", Offset = "0x7DC9B8", VA = "0x7DC9B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x7DC9C0", Offset = "0x7DC9C0", VA = "0x7DC9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		private bool IsEnable
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x7DC9CC", Offset = "0x7DC9CC", VA = "0x7DC9CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public bool IsAngleEnable
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x7DC9EC", Offset = "0x7DC9EC", VA = "0x7DC9EC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x7DC9F4", Offset = "0x7DC9F4", VA = "0x7DC9F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x7DCA00", Offset = "0x7DCA00", VA = "0x7DCA00")]
		public PlayerMoveController(PlayerComponent player)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x7DCC24", Offset = "0x7DCC24", VA = "0x7DCC24")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7DCB00", Offset = "0x7DCB00", VA = "0x7DCB00")]
		public void SetMoveType(eType type)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x7DCE14", Offset = "0x7DCE14", VA = "0x7DCE14")]
		public void ForcedMove(Vector3 pos, bool isCalcRealPos = true)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7DCE28", Offset = "0x7DCE28", VA = "0x7DCE28")]
		public void Reset()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x7DCF34", Offset = "0x7DCF34", VA = "0x7DCF34")]
		public void ResetGame()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7DCF2C", Offset = "0x7DCF2C", VA = "0x7DCF2C")]
		private float GetCurrentCameraHeight()
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000A2")]
	public class QuickPlayerMover : BasePlayerMover
	{
		[Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <MoveCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public QuickPlayerMover <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0x7DD520", Offset = "0x7DD520", VA = "0x7DD520", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x7DD568", Offset = "0x7DD568", VA = "0x7DD568", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x7DD368", Offset = "0x7DD368", VA = "0x7DD368")]
			[DebuggerHidden]
			public <MoveCoroutine>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x7DD398", Offset = "0x7DD398", VA = "0x7DD398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x7DD39C", Offset = "0x7DD39C", VA = "0x7DD39C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x7DD528", Offset = "0x7DD528", VA = "0x7DD528", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400041E")]
		private const float MOVE_DIST = 1f;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7DD1E4", Offset = "0x7DD1E4", VA = "0x7DD1E4", Slot = "5")]
		public override void OnUpdateMove(bool isEnable)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7DD2F4", Offset = "0x7DD2F4", VA = "0x7DD2F4", Slot = "6")]
		[IteratorStateMachine(typeof(<MoveCoroutine>d__2))]
		protected override IEnumerator MoveCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7DD390", Offset = "0x7DD390", VA = "0x7DD390")]
		public QuickPlayerMover()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ShiftPlayerMover : BaseTargetPlayerMover
	{
		[Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class <MoveCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShiftPlayerMover <>4__this;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <start>5__2;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <y>5__3;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <end>5__4;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <timer>5__5;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x7DD760", Offset = "0x7DD760", VA = "0x7DD760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x7DD7A8", Offset = "0x7DD7A8", VA = "0x7DD7A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x7DD5E4", Offset = "0x7DD5E4", VA = "0x7DD5E4")]
			[DebuggerHidden]
			public <MoveCoroutine>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x7DD60C", Offset = "0x7DD60C", VA = "0x7DD60C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x7DD610", Offset = "0x7DD610", VA = "0x7DD610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x7DD768", Offset = "0x7DD768", VA = "0x7DD768", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000422")]
		private const float MOVE_TIME = 0.1f;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x7DD570", Offset = "0x7DD570", VA = "0x7DD570", Slot = "6")]
		[IteratorStateMachine(typeof(<MoveCoroutine>d__1))]
		protected override IEnumerator MoveCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x7DCDC0", Offset = "0x7DCDC0", VA = "0x7DCDC0")]
		public ShiftPlayerMover()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class TelepotationPlayerMover : BaseTargetPlayerMover
	{
		[Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class <MoveCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TelepotationPlayerMover <>4__this;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FadeManager <fadeMng>5__2;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 <newPos>5__3;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x7DDC90", Offset = "0x7DDC90", VA = "0x7DDC90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x7DDCD8", Offset = "0x7DDCD8", VA = "0x7DDCD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x7DD824", Offset = "0x7DD824", VA = "0x7DD824")]
			[DebuggerHidden]
			public <MoveCoroutine>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x7DD84C", Offset = "0x7DD84C", VA = "0x7DD84C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x7DD850", Offset = "0x7DD850", VA = "0x7DD850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x7DDC98", Offset = "0x7DDC98", VA = "0x7DDC98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400042A")]
		private const float MOVE_TIME = 0.5f;

		[Token(Token = "0x400042B")]
		private const float MOVE_TIME_MIN = 0.1f;

		[Token(Token = "0x400042C")]
		private const float MOVE_TIME_MAX = 0.7f;

		[Token(Token = "0x400042D")]
		private const float MOVE_DIST_MAX = 5f;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private InterpolatorVector3 m_movePosInterpolator;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7DD7B0", Offset = "0x7DD7B0", VA = "0x7DD7B0", Slot = "6")]
		[IteratorStateMachine(typeof(<MoveCoroutine>d__5))]
		protected override IEnumerator MoveCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7DCD2C", Offset = "0x7DCD2C", VA = "0x7DCD2C")]
		public TelepotationPlayerMover()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class GameMovieManager : DefaultMovieManager<GameMovieManager>
	{
		[Token(Token = "0x20000A9")]
		private class PanoramicShaderParameter
		{
			[Token(Token = "0x20000AA")]
			public enum eMovieType
			{
				[Token(Token = "0x4000441")]
				Screen,
				[Token(Token = "0x4000442")]
				Angle360,
				[Token(Token = "0x4000443")]
				Angle180,
				[Token(Token = "0x4000444")]
				Angle180_SideBySide
			}

			[Token(Token = "0x20000AB")]
			private enum eImageType
			{
				[Token(Token = "0x4000446")]
				Angle360,
				[Token(Token = "0x4000447")]
				Angle180
			}

			[Token(Token = "0x20000AC")]
			private enum e3DLayout
			{
				[Token(Token = "0x4000449")]
				None,
				[Token(Token = "0x400044A")]
				SideBySide,
				[Token(Token = "0x400044B")]
				OverUnder
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x7DE544", Offset = "0x7DE544", VA = "0x7DE544")]
			public static int GetImageType(eMovieType type)
			{
				return default(int);
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x7DE568", Offset = "0x7DE568", VA = "0x7DE568")]
			public static int Get3DLayout(eMovieType type)
			{
				return default(int);
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x7DE58C", Offset = "0x7DE58C", VA = "0x7DE58C")]
			public static float GetRotation(eMovieType type)
			{
				return default(float);
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x7DE8F4", Offset = "0x7DE8F4", VA = "0x7DE8F4")]
			public PanoramicShaderParameter()
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class <StopCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameMovieManager <>4__this;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FadeManager <fade>5__2;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x7DEC10", Offset = "0x7DEC10", VA = "0x7DEC10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x7DEC58", Offset = "0x7DEC58", VA = "0x7DEC58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x7DE3C0", Offset = "0x7DE3C0", VA = "0x7DE3C0")]
			[DebuggerHidden]
			public <StopCoroutine>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x7DE940", Offset = "0x7DE940", VA = "0x7DE940", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x7DE944", Offset = "0x7DE944", VA = "0x7DE944", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x7DEC18", Offset = "0x7DEC18", VA = "0x7DEC18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action m_openNextAction;

		[Token(Token = "0x4000435")]
		private const int SKYBOX_MOVIE_CAMERA_MASK = 33554464;

		[Token(Token = "0x4000436")]
		private const int SCREEN_MOVIE_CAMERA_MASK = -131073;

		[Token(Token = "0x4000437")]
		private const int ALL_VIEW_CAMERA_MASK = int.MaxValue;

		[Token(Token = "0x4000438")]
		private const float SCREEN_DIST = 2f;

		[Token(Token = "0x4000439")]
		private const float SCREEN_HEIGHT = 0.2f;

		[Token(Token = "0x400043A")]
		private const float SCREEN_SCALE = 3f;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<MovieComponent> m_movieList;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MovieComponent m_playingMovie;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine m_coroutine;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject m_screen;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private PenLightComponent[] m_penLight;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7DDCE0", Offset = "0x7DDCE0", VA = "0x7DDCE0")]
		public void AddMovie(MovieComponent component)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7DDD38", Offset = "0x7DDD38", VA = "0x7DDD38")]
		public void RemoveMovie(MovieComponent component)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7DDD90", Offset = "0x7DDD90", VA = "0x7DDD90")]
		public void Play(MovieComponent component, [Optional] Action onPlayAction, [Optional] Action onEndAction)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x7DE218", Offset = "0x7DE218", VA = "0x7DE218", Slot = "11")]
		public override void Resume()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x7DE298", Offset = "0x7DE298", VA = "0x7DE298", Slot = "12")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x7DE34C", Offset = "0x7DE34C", VA = "0x7DE34C")]
		[IteratorStateMachine(typeof(<StopCoroutine>d__18))]
		private IEnumerator StopCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x7DE3E8", Offset = "0x7DE3E8", VA = "0x7DE3E8", Slot = "7")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7DE4DC", Offset = "0x7DE4DC", VA = "0x7DE4DC")]
		public void SetSkyboxMovieTexture()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7DE08C", Offset = "0x7DE08C", VA = "0x7DE08C")]
		public void SettingEnv(MovieComponent component)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x7DE06C", Offset = "0x7DE06C", VA = "0x7DE06C")]
		private void SettingScreen()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7DE5A4", Offset = "0x7DE5A4", VA = "0x7DE5A4")]
		public void CloseScreen()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7DE5C4", Offset = "0x7DE5C4", VA = "0x7DE5C4")]
		public GameMovieManager()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class MovieComponent : MusicDLCMenuComponent
	{
		[Token(Token = "0x4000453")]
		public const float MOVIE_FADE_TIME = 0.5f;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string m_moviePath;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private SpriteRenderer m_typeIcon;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TMP_Text m_versionText;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private GameObject m_annotation;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private GameObject m_subText;

		[Token(Token = "0x1700007F")]
		public MovieParameter Param
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x7DEC68", Offset = "0x7DEC68", VA = "0x7DEC68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x7DEC70", Offset = "0x7DEC70", VA = "0x7DEC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public DeleteButtonUIComponent DeleteButton
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x7DEC80", Offset = "0x7DEC80", VA = "0x7DEC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x7DEC88", Offset = "0x7DEC88", VA = "0x7DEC88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7DEC98", Offset = "0x7DEC98", VA = "0x7DEC98")]
		public void Initialize(MovieParameter param, bool isHide)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7DED9C", Offset = "0x7DED9C", VA = "0x7DED9C")]
		private void CheckDeleteThisMovieCompoentAction()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7DEE9C", Offset = "0x7DEE9C", VA = "0x7DEE9C")]
		private bool IsCheckButtonIconActiveOnDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7DEF38", Offset = "0x7DEF38", VA = "0x7DEF38", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7DEF68", Offset = "0x7DEF68", VA = "0x7DEF68", Slot = "20")]
		protected override void ParamViewSetting()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7DEFC8", Offset = "0x7DEFC8", VA = "0x7DEFC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x7DF028", Offset = "0x7DF028", VA = "0x7DF028", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x7DF090", Offset = "0x7DF090", VA = "0x7DF090", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x7DF360", Offset = "0x7DF360", VA = "0x7DF360", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x7DF514", Offset = "0x7DF514", VA = "0x7DF514", Slot = "14")]
		protected override void OnOpen()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7DF660", Offset = "0x7DF660", VA = "0x7DF660", Slot = "27")]
		protected override void SetPlayableGameData(ref bool isPlayable)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7DF6FC", Offset = "0x7DF6FC", VA = "0x7DF6FC", Slot = "22")]
		protected override bool IsPreInstall(GameDefine.eMusic title)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7DF5E4", Offset = "0x7DF5E4", VA = "0x7DF5E4")]
		private void DeleteButtonUpdateActivate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x7DF760", Offset = "0x7DF760", VA = "0x7DF760", Slot = "24")]
		protected override void OnChangeDownloadStatus(BasePlatform.eDownloadStatus newStatus)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7DF7E0", Offset = "0x7DF7E0", VA = "0x7DF7E0")]
		public MovieComponent()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class MovieScreenComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x7DF82C", Offset = "0x7DF82C", VA = "0x7DF82C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7DF9DC", Offset = "0x7DF9DC", VA = "0x7DF9DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7DF9E0", Offset = "0x7DF9E0", VA = "0x7DF9E0")]
		public MovieScreenComponent()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class BaseNotesComponent : ModelComponent
	{
		[Token(Token = "0x20000B4")]
		private enum eFrameType
		{
			[Token(Token = "0x40004A1")]
			Front,
			[Token(Token = "0x40004A2")]
			Middle,
			[Token(Token = "0x40004A3")]
			Back
		}

		[Token(Token = "0x20000B5")]
		public enum eNoteType
		{
			[Token(Token = "0x40004A5")]
			Normal,
			[Token(Token = "0x40004A6")]
			Double,
			[Token(Token = "0x40004A7")]
			Special1,
			[Token(Token = "0x40004A8")]
			Special2,
			[Token(Token = "0x40004A9")]
			Long
		}

		[Token(Token = "0x20000B6")]
		private class Touched
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_timer;

			[Token(Token = "0x17000086")]
			public PenLightComponent PenLight
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0x7E3A74", Offset = "0x7E3A74", VA = "0x7E3A74")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003EF")]
				[Address(RVA = "0x7E3A7C", Offset = "0x7E3A7C", VA = "0x7E3A7C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x7E2B38", Offset = "0x7E2B38", VA = "0x7E2B38")]
			public Touched(PenLightComponent penlight)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x7E069C", Offset = "0x7E069C", VA = "0x7E069C")]
			public bool OnUpdate()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400045D")]
		private const string MISS_NOTE_NAME = "MissNote";

		[Token(Token = "0x400045E")]
		private const string LONG_BACK_CUBE = "longCube";

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<string> OBJ_NAME_ARRAY;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly ReadOnlyCollection<string> FRAME_MAT_NAME_ARRAY;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly ReadOnlyCollection<string> BLOOM_MAT_NAME_ARRAY;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly ReadOnlyCollection<string> FRAME_PATH_ARRAY;

		[Token(Token = "0x4000463")]
		private const float COLL_SIZE = 0.11f;

		[Token(Token = "0x4000464")]
		private const float COLL_JUST_SIZE = 0.22f;

		[Token(Token = "0x4000465")]
		private const float COLL_LONG_SIZE = 0.32999998f;

		[Token(Token = "0x4000466")]
		private const float FAST_MISS_TIME = 0.2f;

		[Token(Token = "0x4000467")]
		private const float MISS_TIME = -0.2f;

		[Token(Token = "0x4000468")]
		private const float VANISH_TIME_AFTER_MISS = -0.5f;

		[Token(Token = "0x4000469")]
		private const float LONG_MISS_TIME = 0.2f;

		[Token(Token = "0x400046A")]
		private const float SWEET_MISS_RATE = 2f;

		[Token(Token = "0x400046B")]
		private const float SCALE_BASE = 1f;

		[Token(Token = "0x400046C")]
		private const float SCALE_ADD = 0.2f;

		[Token(Token = "0x400046D")]
		private const float TIME_ADJUST = -0.05f;

		[Token(Token = "0x400046E")]
		private const float HIT_POWER_RATE = 100f;

		[Token(Token = "0x400046F")]
		protected const float MISS_POWER_RATE = 1.5f;

		[Token(Token = "0x4000470")]
		private const float MIN_Y = 0.07f;

		[Token(Token = "0x4000471")]
		private const float MARKER_CALL_REMAIN_TIME = 1.5f;

		[Token(Token = "0x4000472")]
		private const float LONG_TOUCH_REMOVE_TIME = 0.1f;

		[Token(Token = "0x4000473")]
		private const float NORMAL_VIBRATION_POWER = 1f;

		[Token(Token = "0x4000474")]
		private const float LONG_VIBRATION_POWER = 0.3f;

		[Token(Token = "0x4000475")]
		private const float POP_TIME = 0.5f;

		[Token(Token = "0x4000476")]
		private const float END_VANISH_TIME = 1f;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Transform m_start;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Transform m_end;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Material m_keepMat;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected float m_reachedTime;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject m_missNoteObj;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float m_speed;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected eNoteType m_noteObjType;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		protected bool m_isNoteEnded;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected MusicGameController m_controller;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_isDouble;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool m_isEndAnswer;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		protected bool m_isSpecial;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int m_endIndex;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3? m_afterVec;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected bool m_isMiss;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected BezierCurve m_afterCurve;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected InterpolatorFloat m_afterInterpolator;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected GameObject[] m_subObjArray;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject m_longBackCube;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected bool m_isMarkerSet;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Transform[] m_frameArray;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected MeshRenderer[] m_frameMeshList;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected Transform m_frameBackPoint;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float m_baseFrameScale;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		protected Transform m_bloomTrans;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected MeshRenderer m_bloomMesh;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_isFastMiss;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float m_longTouchTime;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float m_longTouchTimer;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float m_longTouchNGTimer;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float m_longTouchAddScale;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private EffectComponent m_longEffect;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private SoundComponent m_longSound;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private BoxCollider m_boxColl;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float m_beforeRemainTime;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private bool m_isTouched;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		protected float m_missTimeRate;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<PenLightComponent> m_touchList;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<Touched> m_touchedList;

		[Token(Token = "0x17000081")]
		public bool IsNoteVisible
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x7DF9E8", Offset = "0x7DF9E8", VA = "0x7DF9E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x7DF9F0", Offset = "0x7DF9F0", VA = "0x7DF9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public virtual bool IsEnded
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x7DF9FC", Offset = "0x7DF9FC", VA = "0x7DF9FC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		private bool IsLongTouch
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x7DFA04", Offset = "0x7DFA04", VA = "0x7DFA04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		private bool IsNotTouch
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x7DFA14", Offset = "0x7DFA14", VA = "0x7DFA14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		private bool IsTouchedRemoved
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x7DFA64", Offset = "0x7DFA64", VA = "0x7DFA64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7DFA78", Offset = "0x7DFA78", VA = "0x7DFA78", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7DFCB0", Offset = "0x7DFCB0", VA = "0x7DFCB0", Slot = "12")]
		public virtual void Initialize(float reachedTime, Transform start, Transform end, int endIndex, float speed, float touchingTime, bool isDouble = false)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7DFF0C", Offset = "0x7DFF0C", VA = "0x7DFF0C", Slot = "10")]
		protected override void OnCreateModel()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7E041C", Offset = "0x7E041C", VA = "0x7E041C")]
		public void BloomUpdate()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x7E0524", Offset = "0x7E0524", VA = "0x7E0524", Slot = "13")]
		public virtual void OnUpdate(float currentTime)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x7E06D0", Offset = "0x7E06D0", VA = "0x7E06D0")]
		protected void NoteUpdate(float currentTime)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x7E108C", Offset = "0x7E108C", VA = "0x7E108C")]
		protected void MoveNote(float currentTime)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7E169C", Offset = "0x7E169C", VA = "0x7E169C")]
		protected void FrameUpdate(float currentTime)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7E1484", Offset = "0x7E1484", VA = "0x7E1484")]
		private void SetNotesModel()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x7E1728", Offset = "0x7E1728", VA = "0x7E1728")]
		private void CalcFrameScale()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x7E1908", Offset = "0x7E1908", VA = "0x7E1908")]
		protected void AfterMoveUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x7E1DB4", Offset = "0x7E1DB4", VA = "0x7E1DB4", Slot = "14")]
		protected virtual void Miss()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x7E1F7C", Offset = "0x7E1F7C", VA = "0x7E1F7C", Slot = "15")]
		protected virtual void Good()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x7E20D8", Offset = "0x7E20D8", VA = "0x7E20D8")]
		public void SetModelScale(float rate)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x7E0C8C", Offset = "0x7E0C8C", VA = "0x7E0C8C")]
		protected void SetOutwardMoveVec()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x7E21AC", Offset = "0x7E21AC", VA = "0x7E21AC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x7E28FC", Offset = "0x7E28FC", VA = "0x7E28FC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x7E2860", Offset = "0x7E2860", VA = "0x7E2860")]
		private void PlayGoodPerformance(Vector3 pos, Vector3 forward)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x7E2B74", Offset = "0x7E2B74", VA = "0x7E2B74")]
		private void PlayGoodSE()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x7E2DF4", Offset = "0x7E2DF4", VA = "0x7E2DF4")]
		public void SetController(MusicGameController controller)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x7E0F10", Offset = "0x7E0F10", VA = "0x7E0F10")]
		protected void BreakFrame(Vector3 forward)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x7E2DFC", Offset = "0x7E2DFC", VA = "0x7E2DFC")]
		protected void ChangeFrameEnable(bool isEnabled)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x7E1A64", Offset = "0x7E1A64", VA = "0x7E1A64")]
		private void AfterInit()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x7E3070", Offset = "0x7E3070", VA = "0x7E3070")]
		public void ChangeActiveAllModel(bool isActive)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x7E316C", Offset = "0x7E316C", VA = "0x7E316C")]
		public BaseNotesComponent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class EffectEmissionChanger
	{
		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ParticleSystem m_effect;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_min;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_max;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem.EmissionModule m_effectEmission;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_before;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x7E3C58", Offset = "0x7E3C58", VA = "0x7E3C58")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x7E3CC8", Offset = "0x7E3CC8", VA = "0x7E3CC8")]
		public void OnUpdate(float rate)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x7E3D54", Offset = "0x7E3D54", VA = "0x7E3D54")]
		public EffectEmissionChanger()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class MusicGameController
	{
		[Token(Token = "0x20000BB")]
		public enum eSpecialType
		{
			[Token(Token = "0x40004F8")]
			OAD_R_TO_L,
			[Token(Token = "0x40004F9")]
			OAD_L_TO_R,
			[Token(Token = "0x40004FA")]
			FrontSwing_R,
			[Token(Token = "0x40004FB")]
			FrontSwing_L,
			[Token(Token = "0x40004FC")]
			Max
		}

		[Token(Token = "0x20000BC")]
		public enum eLoadState
		{
			[Token(Token = "0x40004FE")]
			Loading,
			[Token(Token = "0x40004FF")]
			ChangeEnable,
			[Token(Token = "0x4000500")]
			ChangeDisable,
			[Token(Token = "0x4000501")]
			CheckEndEffect,
			[Token(Token = "0x4000502")]
			End
		}

		[Token(Token = "0x20000BD")]
		public enum Rank
		{
			[Token(Token = "0x4000504")]
			Invalid = -1,
			[Token(Token = "0x4000505")]
			SS,
			[Token(Token = "0x4000506")]
			S,
			[Token(Token = "0x4000507")]
			A,
			[Token(Token = "0x4000508")]
			B,
			[Token(Token = "0x4000509")]
			C,
			[Token(Token = "0x400050A")]
			D
		}

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private eLoadState m_loadState;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ReadOnlyCollection<string> SPECIAL_PREFAB_ARRAY;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ReadOnlyCollection<string> SPECIAL_GUIDE_PREFAB_ARRAY;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly ReadOnlyCollection<string> RANK_TEX_NAME_ARRAY;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly ReadOnlyCollection<int> RANK_SCORE_ARRAY;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly ReadOnlyCollection<string> RANK_VOICE_NAME_ARRAY;

		[Token(Token = "0x40004BA")]
		private const string NORMAL_NOTES_NAME = "NormalNote";

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string GOOD_EFFECT_NAME;

		[Token(Token = "0x40004BC")]
		private const int NORMAL_NOTES_BUFFER = 50;

		[Token(Token = "0x40004BD")]
		private const int SPECIAL_NOTES_BUFFER = 8;

		[Token(Token = "0x40004BE")]
		private const int SPECIAL_GAUGE_BUFFER = 3;

		[Token(Token = "0x40004BF")]
		private const int SPECIAL_GUIDE_BUFFER = 8;

		[Token(Token = "0x40004C0")]
		private const int MAX_SCORE = 1000000;

		[Token(Token = "0x40004C1")]
		private const int RESULT_BEST_SE_SCORE = 1000000;

		[Token(Token = "0x40004C2")]
		private const int RESULT_OK_SE_SCORE = 600000;

		[Token(Token = "0x40004C3")]
		private const byte NORMAL_NOTE_ID = 1;

		[Token(Token = "0x40004C4")]
		private const float EFFECT_MAX_RATE = 0.8f;

		[Token(Token = "0x40004C5")]
		public const float MARKER_OPEN_SPEED = 1f;

		[Token(Token = "0x40004C6")]
		private const float MARKER_CLOSE_SPEED = 0.1f;

		[Token(Token = "0x40004C7")]
		private const string NORMAL_HIT_EFFECT = "hit_01";

		[Token(Token = "0x40004C8")]
		public const string NORMAL_HIT_EFFECT_STRONG = "hit_02";

		[Token(Token = "0x40004C9")]
		private const string CRASH_EFFECT = "hit_03";

		[Token(Token = "0x40004CA")]
		public const string LONG_EFFECT_NAME = "hit_04";

		[Token(Token = "0x40004CB")]
		public const string SPECIAL_END_EFFECT = "hit_special";

		[Token(Token = "0x40004CC")]
		private const int CHEERS_COMBO_NUM = 100;

		[Token(Token = "0x40004CD")]
		private const int MAX_HIT_EFFECT = 4;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NormalNotesComponent[] m_normalNotesArray;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpecialNotesComponent[] m_specialNotesArray;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpecialNotesGaugeComponent[][] m_specialGaugeArray;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] m_specialGaugeIndexArray;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpecialNotesGuideComponent[][] m_specialGuideArray;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] m_specialGuideIndexArray;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScriptableMusicGameDataParameter m_param;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Note> m_noteList;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_currentBpmIndex;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_currentNumIndex;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] m_startArray;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] m_endArary;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int[] m_markerCountArray;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InterpolatorFloat[] m_markerInterpolatorArray;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_notesSpeed;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool m_isAllNotePlacement;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_currentNoteIndex;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_lastHoldStartPos;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_lastHoldEndPos;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_lastHoldNoteIndex;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_isOldSimultaneous;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int m_oldSimultaneousSeed;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int m_stageComboCount;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SceneMusicGameComponent m_scene;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int m_specialGaugeReadyCount;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int m_specialGuideReadyCount;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_isEndPlayMaxComboSe;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[] m_penLightEffectCount;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private EffectComponent m_stageComboEffect;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<EffectComponent> m_initEffectList;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundComponent m_resultSE;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private EffectComponent[] m_hitEffectArray;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private EffectComponent[] m_crashEffectArray;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int m_hitEffectIndex;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool m_isHalfUpdateFlg;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool m_isUsedGuide;

		[Token(Token = "0x17000087")]
		public int ComboCount
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x7E3D5C", Offset = "0x7E3D5C", VA = "0x7E3D5C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x7E3D64", Offset = "0x7E3D64", VA = "0x7E3D64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int MaxComboCount
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x7E3D6C", Offset = "0x7E3D6C", VA = "0x7E3D6C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x7E3D74", Offset = "0x7E3D74", VA = "0x7E3D74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int OkCount
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x7E3D7C", Offset = "0x7E3D7C", VA = "0x7E3D7C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x7E3D84", Offset = "0x7E3D84", VA = "0x7E3D84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public int MissCount
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x7E3D8C", Offset = "0x7E3D8C", VA = "0x7E3D8C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x7E3D94", Offset = "0x7E3D94", VA = "0x7E3D94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool IsReady
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x7E3D9C", Offset = "0x7E3D9C", VA = "0x7E3D9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public Transform EndPointCenter
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x7E2190", Offset = "0x7E2190", VA = "0x7E2190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public Transform AiStage
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x7E3054", Offset = "0x7E3054", VA = "0x7E3054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public bool IsPause
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x7E3DD0", Offset = "0x7E3DD0", VA = "0x7E3DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x7E3DD8", Offset = "0x7E3DD8", VA = "0x7E3DD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool IsFullCombo
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x7E3DE4", Offset = "0x7E3DE4", VA = "0x7E3DE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public bool IsEndResultSE
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x7E3E0C", Offset = "0x7E3E0C", VA = "0x7E3E0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x7E3EA0", Offset = "0x7E3EA0", VA = "0x7E3EA0")]
		public void SetPenLightEffect(SceneMusicGameComponent.ePenLightType hand, PenLightComponent.eGameEffectType effect)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x7E3FC4", Offset = "0x7E3FC4", VA = "0x7E3FC4")]
		public void Initialize(ref Transform[] startArray, ref Transform[] endArray, float notesSpeed, SceneMusicGameComponent scene)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x7E4F14", Offset = "0x7E4F14", VA = "0x7E4F14")]
		public void Calibration()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x7E512C", Offset = "0x7E512C", VA = "0x7E512C")]
		public bool IsEndLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x7E53E4", Offset = "0x7E53E4", VA = "0x7E53E4")]
		public void SetParameter(ScriptableMusicGameDataParameter param)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x7E5680", Offset = "0x7E5680", VA = "0x7E5680")]
		public bool SettingNextNote(ref NormalNotesComponent component)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7E5B5C", Offset = "0x7E5B5C", VA = "0x7E5B5C")]
		public bool SettingNextNote(ref SpecialNotesComponent component)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x7E5DA8", Offset = "0x7E5DA8", VA = "0x7E5DA8")]
		private eSpecialType NotesTypeToSpecialType(GameDefine.eNotesType notesType)
		{
			return default(eSpecialType);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x7E5DBC", Offset = "0x7E5DBC", VA = "0x7E5DBC")]
		private SpecialNotesGaugeComponent GetGauge(eSpecialType type)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x7E5E34", Offset = "0x7E5E34", VA = "0x7E5E34")]
		private SpecialNotesGuideComponent GetGuide(eSpecialType type)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x7E5D80", Offset = "0x7E5D80", VA = "0x7E5D80")]
		private int CoaxNotePosition(float currentPosition)
		{
			return default(int);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x7E603C", Offset = "0x7E603C", VA = "0x7E603C")]
		public void OnUpdate(AudioSource m_bgm)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x7E6538", Offset = "0x7E6538", VA = "0x7E6538")]
		public void UpdateMarker()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x7E1FB8", Offset = "0x7E1FB8", VA = "0x7E1FB8")]
		public void Good(int endIndex)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x7E6700", Offset = "0x7E6700", VA = "0x7E6700")]
		public void Fast()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7E664C", Offset = "0x7E664C", VA = "0x7E664C")]
		private void CheckMaxCombo(int comboCount)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7E1E5C", Offset = "0x7E1E5C", VA = "0x7E1E5C")]
		public void Miss()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x7E1CA8", Offset = "0x7E1CA8", VA = "0x7E1CA8")]
		public void StageComboAdd()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7E1C30", Offset = "0x7E1C30", VA = "0x7E1C30")]
		public void StageComboMiss()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7E6740", Offset = "0x7E6740", VA = "0x7E6740")]
		public void SettingResultData()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x7E69A4", Offset = "0x7E69A4", VA = "0x7E69A4")]
		private int CalcScore()
		{
			return default(int);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x7E69DC", Offset = "0x7E69DC", VA = "0x7E69DC")]
		public Rank GetRank()
		{
			return default(Rank);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x7E6AF0", Offset = "0x7E6AF0", VA = "0x7E6AF0")]
		public void PlayResultSE()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x7E0F88", Offset = "0x7E0F88", VA = "0x7E0F88")]
		public void IncrementMarkerCount(int index)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x7E1E90", Offset = "0x7E1E90", VA = "0x7E1E90")]
		public void DecrementMarkerCount(int index)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x7E6C28", Offset = "0x7E6C28", VA = "0x7E6C28")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x7E6C34", Offset = "0x7E6C34", VA = "0x7E6C34")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7E6C3C", Offset = "0x7E6C3C", VA = "0x7E6C3C")]
		public void PlayResultVoice()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7E6F78", Offset = "0x7E6F78", VA = "0x7E6F78")]
		public void AllDisable()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7E2CE4", Offset = "0x7E2CE4", VA = "0x7E2CE4")]
		public void PlayHitEffect(int index, Vector3 pos, Vector3 forward)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7E2E64", Offset = "0x7E2E64", VA = "0x7E2E64")]
		public void PlayCrashEffect(int index, Vector3 pos, Vector3 forward)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7E6FD8", Offset = "0x7E6FD8", VA = "0x7E6FD8")]
		public MusicGameController()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class NormalNotesComponent : BaseNotesComponent
	{
		[Token(Token = "0x4000516")]
		private const float SQR_STAGE_REACHED_DIST = 0.010000001f;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7E853C", Offset = "0x7E853C", VA = "0x7E853C", Slot = "13")]
		public override void OnUpdate(float currentTime)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x7E85E8", Offset = "0x7E85E8", VA = "0x7E85E8")]
		public NormalNotesComponent()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class ScriptableMusicGameDataParameter : ScriptableObject
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip m_bgm;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip m_vo;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TimelineAsset m_timeline;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TimelineAsset[] m_costumeTimelineArray;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite m_backScreenImage;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_bpm;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_totalCombo;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<Note> m_notes;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float m_adjTime;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<BPMVariation> m_variationList;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x7E863C", Offset = "0x7E863C", VA = "0x7E863C")]
		public ScriptableMusicGameDataParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class BPMVariation
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_startTime;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_distTime;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_Bpm;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Note> m_notes;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7E8644", Offset = "0x7E8644", VA = "0x7E8644")]
		public BPMVariation()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class Note
	{
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_time;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] m_data;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_specialEndTime;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7E864C", Offset = "0x7E864C", VA = "0x7E864C")]
		public Note()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class ScriptableMusicGameListParameter : ScriptableObject
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MusicGameParameter> m_param;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7E8654", Offset = "0x7E8654", VA = "0x7E8654")]
		public ScriptableMusicGameListParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class MusicGameParameter
	{
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameDefine.eMusic m_title;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_viewTitle;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_viewProd;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite m_icon;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip m_intro;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameDefine.eStageType m_stageType;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PenLightComponent.eLightType m_penlightType;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Gradient m_audioLineColor;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[ColorUsage(false, true)]
		public Color m_stageColor;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float m_charaFarDist;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float m_charaNearDist;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7E865C", Offset = "0x7E865C", VA = "0x7E865C")]
		public MusicGameParameter()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class SpecialNotesComponent : BaseNotesComponent
	{
		[Token(Token = "0x4000535")]
		private const float SUCCESS_VIBRATION_TIME = 0.05f;

		[Token(Token = "0x4000536")]
		private const float MIN_VIBRATION_RATE = 0.1f;

		[Token(Token = "0x4000537")]
		private const float MAX_VIBRATION_RATE = 0.8f;

		[Token(Token = "0x4000538")]
		private const float INIT_U = -0.5f;

		[Token(Token = "0x4000539")]
		private const float CHECK_ADJ_TIME = 0.15f;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private BaseSpecialNotesData m_noteData;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private SpecialNotesGaugeComponent m_specialGauge;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private SpecialNotesGuideComponent m_specialGuide;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector2 m_uv;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float m_specialDuringTime;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private bool m_isSpecialEnded;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int m_checkIndex;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private List<InputManager.eActiveHandType> m_pickHandList;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float m_vibrationStartTimer;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x7E8678", Offset = "0x7E8678", VA = "0x7E8678", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7E5EBC", Offset = "0x7E5EBC", VA = "0x7E5EBC")]
		public void InitializeSpecial(float endTime, SpecialNotesGaugeComponent specialObj, SpecialNotesGuideComponent guideObj)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7E879C", Offset = "0x7E879C", VA = "0x7E879C", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7E87A4", Offset = "0x7E87A4", VA = "0x7E87A4", Slot = "13")]
		public override void OnUpdate(float currentTime)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7E8880", Offset = "0x7E8880", VA = "0x7E8880")]
		private void MoveNoteAfterReached(float currentTime)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7E88E0", Offset = "0x7E88E0", VA = "0x7E88E0")]
		private void SpecialUpdate(float remainTime)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7E8E04", Offset = "0x7E8E04", VA = "0x7E8E04")]
		private void VibrationUpdate(float remainTime)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7E89C8", Offset = "0x7E89C8", VA = "0x7E89C8")]
		private void JudgementUpdate(float currentTime)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7E8F6C", Offset = "0x7E8F6C", VA = "0x7E8F6C")]
		private void CheckHandPosJudgement(float diffTime)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7E949C", Offset = "0x7E949C", VA = "0x7E949C")]
		private void CheckOADCenter(float diffTime)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7E97B8", Offset = "0x7E97B8", VA = "0x7E97B8")]
		public SpecialNotesComponent()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class SpecialNotesGaugeComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public enum eResult
		{
			[Token(Token = "0x4000556")]
			Good,
			[Token(Token = "0x4000557")]
			Miss
		}

		[Token(Token = "0x20000CD")]
		private enum eJudgementType
		{
			[Token(Token = "0x4000559")]
			Top,
			[Token(Token = "0x400055A")]
			Bottom,
			[Token(Token = "0x400055B")]
			Max
		}

		[Token(Token = "0x4000543")]
		private const float RING_MAS_SCALE = 1f;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<float> INIT_POS_ADJ;

		[Token(Token = "0x4000545")]
		private const float BASE_MIN_HIEGHT = 1.05f;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly ReadOnlyCollection<float> INIT_POS_MIN;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string JUDGEMENT_TOP_NAME;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string JUDGEMENT_BOTTOM_NAME;

		[Token(Token = "0x4000549")]
		private const float SQR_SUCCESS_RADIUS = 0.040000003f;

		[Token(Token = "0x400054A")]
		private const float SQR_SUCCESS_SWEET_RADIUS = 0.09f;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] m_checkPoint;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MeshRenderer m_meshRenderer;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform[] m_uniqueCheckPoint;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material m_mat;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform[] m_rightJudgeTrans;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform[] m_leftJudgeTrans;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] m_lineDistArray;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_lineSumDist;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float m_sqrSuccessRadius;

		[Token(Token = "0x17000091")]
		public MusicGameController.eSpecialType SpecialType
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x7E986C", Offset = "0x7E986C", VA = "0x7E986C")]
			[CompilerGenerated]
			get
			{
				return default(MusicGameController.eSpecialType);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x7E9874", Offset = "0x7E9874", VA = "0x7E9874")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		private Material Mat
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x7E987C", Offset = "0x7E987C", VA = "0x7E987C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7E9918", Offset = "0x7E9918", VA = "0x7E9918", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7E7EA0", Offset = "0x7E7EA0", VA = "0x7E7EA0")]
		public void Initialize(MusicGameController.eSpecialType type)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7E4FC0", Offset = "0x7E4FC0", VA = "0x7E4FC0")]
		public void Calibration()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7E95A8", Offset = "0x7E95A8", VA = "0x7E95A8")]
		public eResult Judgment(int index, out InputManager.eActiveHandType handType)
		{
			return default(eResult);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7E96C4", Offset = "0x7E96C4", VA = "0x7E96C4")]
		public eResult JudgementUnderCenter()
		{
			return default(eResult);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x7E8D70", Offset = "0x7E8D70", VA = "0x7E8D70")]
		public void SetUV(ref Vector2 uv)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7E8698", Offset = "0x7E8698", VA = "0x7E8698")]
		public Transform GetStart()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x7E8B90", Offset = "0x7E8B90", VA = "0x7E8B90")]
		public Vector3 GetLinePos(float rate)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x7E9D00", Offset = "0x7E9D00", VA = "0x7E9D00")]
		public SpecialNotesGaugeComponent()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class SpecialNotesGuideComponent : BaseMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Point
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform m_trans;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float m_timing;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 m_basePos;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 m_scale;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private bool m_isView;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float m_fadeRate;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float m_scaleRate;

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x7EA290", Offset = "0x7EA290", VA = "0x7EA290")]
			public void Init()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x7EA24C", Offset = "0x7EA24C", VA = "0x7EA24C")]
			public void OnUpdate(float currentTiming)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x7EA230", Offset = "0x7EA230", VA = "0x7EA230")]
			public void UpdateScaleRate(float rate)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x7EA2AC", Offset = "0x7EA2AC", VA = "0x7EA2AC")]
			private void SetScale(float s)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x7EA2B8", Offset = "0x7EA2B8", VA = "0x7EA2B8")]
			private void UpdateScale()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x7EA2F0", Offset = "0x7EA2F0", VA = "0x7EA2F0")]
			private void SetActive(bool isEnable)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x7E9EC0", Offset = "0x7E9EC0", VA = "0x7E9EC0")]
			public void SetSpeed(float speed)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x7EA33C", Offset = "0x7EA33C", VA = "0x7EA33C")]
			public Point()
			{
			}
		}

		[Token(Token = "0x400055E")]
		private const float BASE_SCALE_RATE = 0.5f;

		[Token(Token = "0x400055F")]
		private const float ADD_SCALE_RATE = 0.8f;

		[Token(Token = "0x4000560")]
		private const float POINT_FADE_RATE = 0.2f;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_startPos;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_end;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_speed;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_reachedTime;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Point[] m_pointArray;

		[Token(Token = "0x17000093")]
		public bool IsActive
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x7E9EAC", Offset = "0x7E9EAC", VA = "0x7E9EAC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x7E9EB4", Offset = "0x7E9EB4", VA = "0x7E9EB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x7E86C0", Offset = "0x7E86C0", VA = "0x7E86C0")]
		public void Initialize(float reachedTime, float duaringTime, float speed, Transform start, Transform end)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x7E89C4", Offset = "0x7E89C4", VA = "0x7E89C4")]
		public void OnUpdate(float currentTime)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x7E64B4", Offset = "0x7E64B4", VA = "0x7E64B4")]
		public void OnScaleUpdate(float beatRate)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x7E9F28", Offset = "0x7E9F28", VA = "0x7E9F28")]
		private void Move(float currentTime)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x7E8D94", Offset = "0x7E8D94", VA = "0x7E8D94")]
		public void SetUV(ref Vector2 uv)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x7E9560", Offset = "0x7E9560", VA = "0x7E9560")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x7EA280", Offset = "0x7EA280", VA = "0x7EA280")]
		public SpecialNotesGuideComponent()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class BootParameter : ScriptableObject
	{
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite[] m_logoArray;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x7EA360", Offset = "0x7EA360", VA = "0x7EA360")]
		public BootParameter()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class ParameterManager : SingletonMonoBehaviour<ParameterManager>
	{
		[Token(Token = "0x20000D3")]
		public enum eParam
		{
			[Token(Token = "0x4000581")]
			MessageData,
			[Token(Token = "0x4000582")]
			UIMessageData,
			[Token(Token = "0x4000583")]
			UpdateMessageData,
			[Token(Token = "0x4000584")]
			Font,
			[Token(Token = "0x4000585")]
			Movie,
			[Token(Token = "0x4000586")]
			CharaFade,
			[Token(Token = "0x4000587")]
			EventGroup,
			[Token(Token = "0x4000588")]
			Facial,
			[Token(Token = "0x4000589")]
			Lipsync,
			[Token(Token = "0x400058A")]
			Asset,
			[Token(Token = "0x400058B")]
			MusicGame,
			[Token(Token = "0x400058C")]
			Timeline,
			[Token(Token = "0x400058D")]
			Shop,
			[Token(Token = "0x400058E")]
			Character,
			[Token(Token = "0x400058F")]
			Stage,
			[Token(Token = "0x4000590")]
			Max
		}

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_isSetup;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string[] m_paramPath;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, StringData> m_messageList;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, StringData> m_uiMessageList;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScriptableUpdateDescriptionParameter m_updateMessageParam;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private FontParameter m_fontParam;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScriptableMovieParameter m_movieParam;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ScriptableCharaFadeParameter m_charaFade;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ScriptableEventGroupParameter m_eventGroup;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ScriptableFacialParameter m_facial;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ScriptableLipSyncParameter m_lipSync;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ScriptableAssetParameter m_asset;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ScriptableMusicGameListParameter m_musicGame;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ScriptableTimelineParameter m_timeline;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ScriptableShopParameter m_shop;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ScriptableCharacterParameter m_chara;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ScriptableStageParameter m_stage;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7EA368", Offset = "0x7EA368", VA = "0x7EA368")]
		public void Load()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x7EA468", Offset = "0x7EA468", VA = "0x7EA468")]
		public bool SetupParameter()
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x7EAEC8", Offset = "0x7EAEC8", VA = "0x7EAEC8", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x7EAF90", Offset = "0x7EAF90", VA = "0x7EAF90")]
		public string GetMessage(string id, ProjectDefine.eLanguage language = ProjectDefine.eLanguage.Max)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7D9214", Offset = "0x7D9214", VA = "0x7D9214")]
		public string GetUIMessage(string id, ProjectDefine.eLanguage language = ProjectDefine.eLanguage.Max)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x7EB0C8", Offset = "0x7EB0C8", VA = "0x7EB0C8")]
		public string GetUpdateDesctiptionVersion(int index)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x7EB1A4", Offset = "0x7EB1A4", VA = "0x7EB1A4")]
		public int GetUpdateDesctiptionCount()
		{
			return default(int);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7EB238", Offset = "0x7EB238", VA = "0x7EB238")]
		public string GetDescriptionMessage(int index, ProjectDefine.eLanguage language = ProjectDefine.eLanguage.Max)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x7EB3A4", Offset = "0x7EB3A4", VA = "0x7EB3A4")]
		public TMP_FontAsset GetFont(ProjectDefine.eLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x7EB488", Offset = "0x7EB488", VA = "0x7EB488")]
		public TMP_FontAsset GetDefaultFont()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x7EB508", Offset = "0x7EB508", VA = "0x7EB508")]
		public MovieParameter GetMovieParameter(string moviePath)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x7EB5E8", Offset = "0x7EB5E8", VA = "0x7EB5E8")]
		public MovieParameter GetMovieParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x7EB69C", Offset = "0x7EB69C", VA = "0x7EB69C")]
		public MovieParameter[] GetAllMovieParameter()
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x7EB71C", Offset = "0x7EB71C", VA = "0x7EB71C")]
		public CharaFadeParameter GetCharaFadeParameter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x7EB85C", Offset = "0x7EB85C", VA = "0x7EB85C")]
		public EventGroup GetEvent(string name)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x7EB99C", Offset = "0x7EB99C", VA = "0x7EB99C")]
		public FacialParameter GetFacialParameter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7EBADC", Offset = "0x7EBADC", VA = "0x7EBADC")]
		public LipSyncParameter GetLipSyncParameter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7EBC1C", Offset = "0x7EBC1C", VA = "0x7EBC1C")]
		public Sprite GetSprite(string name)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x7EBD5C", Offset = "0x7EBD5C", VA = "0x7EBD5C")]
		public Sprite GetRankSprite(int score)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x7E17C8", Offset = "0x7E17C8", VA = "0x7E17C8")]
		public Material GetMaterial(string name)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7EBE9C", Offset = "0x7EBE9C", VA = "0x7EBE9C")]
		public Texture GetTexture(string name)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7EBFDC", Offset = "0x7EBFDC", VA = "0x7EBFDC")]
		public Material GetFontMaterial(ProjectDefine.eLanguage language)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x7EC2EC", Offset = "0x7EC2EC", VA = "0x7EC2EC")]
		public PhysicMaterial GetPhisicMaterial(string name)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x7EC42C", Offset = "0x7EC42C", VA = "0x7EC42C")]
		public Texture2D GetRandomFakePyokoTexture()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7D9F74", Offset = "0x7D9F74", VA = "0x7D9F74")]
		public List<MusicGameParameter> GetMusicList()
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x7EC4F4", Offset = "0x7EC4F4", VA = "0x7EC4F4")]
		public MusicGameParameter GetMusicParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7EC5C4", Offset = "0x7EC5C4", VA = "0x7EC5C4")]
		public TimelineParameter GetTimelineParameter(GameDefine.eMusic title)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x7D88CC", Offset = "0x7D88CC", VA = "0x7D88CC")]
		public ShopParameter[] GetShopParameter()
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x7EC6D4", Offset = "0x7EC6D4", VA = "0x7EC6D4")]
		public ShopParameter GetShopParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x7EC788", Offset = "0x7EC788", VA = "0x7EC788")]
		public string GetDLCDetailText(string title)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x7EC89C", Offset = "0x7EC89C", VA = "0x7EC89C")]
		public CharacterModelParameter GetModelParameter(CharacterManager.eModelType type)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x7EC9AC", Offset = "0x7EC9AC", VA = "0x7EC9AC")]
		public string GetModelName(CharacterManager.eModelType type)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x7EC9D8", Offset = "0x7EC9D8", VA = "0x7EC9D8")]
		public List<CharacterModelParameter> GetCharaParameter()
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x7ECA58", Offset = "0x7ECA58", VA = "0x7ECA58")]
		public StageParameter GetStageParam(GameDefine.eStageType stageType)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7ECB68", Offset = "0x7ECB68", VA = "0x7ECB68")]
		public StageParameter GetStageParam(string viewName)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7ECC80", Offset = "0x7ECC80", VA = "0x7ECC80")]
		public List<StageParameter> GetStageList()
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x7ECD00", Offset = "0x7ECD00", VA = "0x7ECD00")]
		public ParameterManager()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class ScriptableCharacterParameter : ScriptableObject
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<CharacterModelParameter> m_params;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x7EE7E0", Offset = "0x7EE7E0", VA = "0x7EE7E0")]
		public ScriptableCharacterParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DF")]
	public class CharacterModelParameter
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterManager.eModelType m_type;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_prefabPath;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_fadeParamName;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_viewNameTextId;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string m_headPath;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string m_hipsPath;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_faceGeoPath;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_eye_L_name;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_eye_R_name;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string m_lipsyncName;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_eyeAnimPath;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7EE7E8", Offset = "0x7EE7E8", VA = "0x7EE7E8")]
		public CharacterModelParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E0")]
	public class CreditParameter
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_type;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_size;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_leftJp;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_leftEn;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_leftTc;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string m_leftSc;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string m_rightJp;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_rightEn;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_isJpOnly;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x7EE7F0", Offset = "0x7EE7F0", VA = "0x7EE7F0")]
		public CreditParameter()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class ScriptableCreditParameter : ScriptableObject
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<CreditParameter> m_params;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x7EE7F8", Offset = "0x7EE7F8", VA = "0x7EE7F8")]
		public ScriptableCreditParameter()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class ScriptableEventGroupParameter : ScriptableObject
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<EventGroup> m_param;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7EE800", Offset = "0x7EE800", VA = "0x7EE800")]
		public ScriptableEventGroupParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E3")]
	public class EventGroup
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScriptableEventParameter m_commandParam;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7EE808", Offset = "0x7EE808", VA = "0x7EE808")]
		public EventGroup()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ScriptableEventParameter : ScriptableObject
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<EventParameter> m_param;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7EE810", Offset = "0x7EE810", VA = "0x7EE810")]
		public ScriptableEventParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class EventParameter
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventRunner.eCommandType m_type;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] m_string;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] m_float;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] m_int;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool[] m_flag;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool m_isWait;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7EE818", Offset = "0x7EE818", VA = "0x7EE818")]
		public EventParameter()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class ScriptableFacialParameter : ScriptableObject
	{
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<FacialParameter> m_param;

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x7EE820", Offset = "0x7EE820", VA = "0x7EE820")]
		public ScriptableFacialParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E7")]
	public class FacialParameter
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public struct BlendShapePair
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int m_index;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int m_value;
		}

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BlendShapePair[] m_param;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x7EE828", Offset = "0x7EE828", VA = "0x7EE828")]
		public FacialParameter()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class ScriptableMovieParameter : ScriptableObject
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MovieParameter[] m_params;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x7EE830", Offset = "0x7EE830", VA = "0x7EE830")]
		public ScriptableMovieParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EA")]
	public class MovieParameter
	{
		[Token(Token = "0x20000EB")]
		public enum eMovieType
		{
			[Token(Token = "0x40005D2")]
			Screen,
			[Token(Token = "0x40005D3")]
			Angle180_None,
			[Token(Token = "0x40005D4")]
			Angle360,
			[Token(Token = "0x40005D5")]
			Angle180_SideBySide
		}

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameDefine.eMusic m_title;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_viewTitle;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_viewProd;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_verText;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string m_moviePath;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public eMovieType m_movieType;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 2f)]
		public float m_volumeMagnification;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite m_icon;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Sprite m_type;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7EE838", Offset = "0x7EE838", VA = "0x7EE838")]
		public MovieParameter()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class ScriptableShopParameter : ScriptableObject
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShopParameter[] m_params;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x7EE848", Offset = "0x7EE848", VA = "0x7EE848")]
		public ScriptableShopParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class ShopParameter
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_title;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_detailTextId;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x7EE850", Offset = "0x7EE850", VA = "0x7EE850")]
		public ShopParameter()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class ScriptableStageParameter : ScriptableObject
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<StageParameter> m_params;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x7EE858", Offset = "0x7EE858", VA = "0x7EE858")]
		public ScriptableStageParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class StageParameter
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameDefine.eStageType m_type;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_viewName;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7EE860", Offset = "0x7EE860", VA = "0x7EE860")]
		public StageParameter()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class ScriptableTimelineParameter : ScriptableObject
	{
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<TimelineParameter> m_param;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7EE868", Offset = "0x7EE868", VA = "0x7EE868")]
		public ScriptableTimelineParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public class TimelineParameter
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameDefine.eMusic m_title;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TrackParameter[] param;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7EE870", Offset = "0x7EE870", VA = "0x7EE870")]
		public TimelineParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class TrackParameter
	{
		[Token(Token = "0x20000F3")]
		public enum eResourceType
		{
			[Token(Token = "0x40005E8")]
			Prefab,
			[Token(Token = "0x40005E9")]
			Effect,
			[Token(Token = "0x40005EA")]
			Others
		}

		[Token(Token = "0x20000F4")]
		public enum eScenePathType
		{
			[Token(Token = "0x40005EC")]
			Default,
			[Token(Token = "0x40005ED")]
			Chara
		}

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_trackName;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eResourceType m_resourceType;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_isInScene;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_resourcePath;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public eScenePathType m_scenePathType;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string m_scenePath;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x7EE878", Offset = "0x7EE878", VA = "0x7EE878")]
		public TrackParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class UpdateDescriptionParameter
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_version;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_jp;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_en;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_tc;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string m_sc;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x7EE880", Offset = "0x7EE880", VA = "0x7EE880")]
		public UpdateDescriptionParameter()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ScriptableUpdateDescriptionParameter : ScriptableObject
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<UpdateDescriptionParameter> m_param;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x7EE888", Offset = "0x7EE888", VA = "0x7EE888")]
		public ScriptableUpdateDescriptionParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F7")]
	public class StringData
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Multiline]
		[SerializeField]
		public string m_stringID;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		[SerializeField]
		public string m_stringJP;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Multiline]
		public string m_stringEN;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Multiline]
		public string m_stringTC;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Multiline]
		public string m_stringSC;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x7EE890", Offset = "0x7EE890", VA = "0x7EE890")]
		public StringData()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class StringDataParameter : ScriptableObject
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<StringData> m_texts;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x7EE898", Offset = "0x7EE898", VA = "0x7EE898")]
		public StringDataParameter()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class PlayerComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_leftControllerAnchor;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_rightControllerAnchor;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform m_rotationTargetTrans;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayerMoveController m_moveController;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_isSetup;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_useTargetMode;

		[Token(Token = "0x17000094")]
		public Transform RotationTargetTransform
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x7EE8A0", Offset = "0x7EE8A0", VA = "0x7EE8A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public ControllerComponent RightController
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x7EE8A8", Offset = "0x7EE8A8", VA = "0x7EE8A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x7EE8B0", Offset = "0x7EE8B0", VA = "0x7EE8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public ControllerComponent LeftController
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x7EE8B8", Offset = "0x7EE8B8", VA = "0x7EE8B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x7EE8C0", Offset = "0x7EE8C0", VA = "0x7EE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool UseTargetMode
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x7EE8C8", Offset = "0x7EE8C8", VA = "0x7EE8C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x7EE8D0", Offset = "0x7EE8D0", VA = "0x7EE8D0")]
			set
			{
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x7EE8DC", Offset = "0x7EE8DC", VA = "0x7EE8DC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x7EE9E4", Offset = "0x7EE9E4", VA = "0x7EE9E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x7EEA44", Offset = "0x7EEA44", VA = "0x7EEA44")]
		public void Setup()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x7EECE8", Offset = "0x7EECE8", VA = "0x7EECE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x7EED04", Offset = "0x7EED04", VA = "0x7EED04")]
		private void UpdateMoveTransforms()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x7EEB54", Offset = "0x7EEB54", VA = "0x7EEB54")]
		private void CreateController()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x7EED08", Offset = "0x7EED08", VA = "0x7EED08")]
		private void OnChangeActiveController(InputManager.eActiveHandType type)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x7EEDFC", Offset = "0x7EEDFC", VA = "0x7EEDFC")]
		public void ForcedMove(Vector3 pos, bool isCalcRealPos = true)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x7EEE14", Offset = "0x7EEE14", VA = "0x7EEE14")]
		public void SetMoveSystemEnable(bool isEnable)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x7EEE28", Offset = "0x7EEE28", VA = "0x7EEE28")]
		public void SetMoveGameEnable(bool isEnable)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7EEE3C", Offset = "0x7EEE3C", VA = "0x7EEE3C")]
		public bool IsEnableMove()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x7EEE70", Offset = "0x7EEE70", VA = "0x7EEE70")]
		public void ResetTrans()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x7EEE84", Offset = "0x7EEE84", VA = "0x7EEE84")]
		public void ResetGameTrans()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7EEE98", Offset = "0x7EEE98", VA = "0x7EEE98")]
		public void SetLaserPointerInGame(bool isActive)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x7EEEC4", Offset = "0x7EEEC4", VA = "0x7EEEC4")]
		public void SetLaserPointerInUI(bool isActive)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x7EEEF0", Offset = "0x7EEEF0", VA = "0x7EEEF0")]
		public void SetLaserPointerAlways(bool isActive)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x7EEF1C", Offset = "0x7EEF1C", VA = "0x7EEF1C")]
		public bool GetEnableLaserPointer()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7EF004", Offset = "0x7EF004", VA = "0x7EF004")]
		public void SetPenLightParticle(bool isUsed)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x7EF040", Offset = "0x7EF040", VA = "0x7EF040")]
		public void SetPenLightNextColor()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x7EF080", Offset = "0x7EF080", VA = "0x7EF080")]
		public void SetPenLightBackColor()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x7EF0C0", Offset = "0x7EF0C0", VA = "0x7EF0C0")]
		public void SetPenLightColor(PenLightComponent.eLightType type)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x7EF128", Offset = "0x7EF128", VA = "0x7EF128")]
		public void UpdatePenLightColorChange()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x7EF1C4", Offset = "0x7EF1C4", VA = "0x7EF1C4")]
		public bool IsShowMoveTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x7EF260", Offset = "0x7EF260", VA = "0x7EF260")]
		public bool IsMoving()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x7EF284", Offset = "0x7EF284", VA = "0x7EF284")]
		public PlayerComponent()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public static class ResourcePath
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x7EF28C", Offset = "0x7EF28C", VA = "0x7EF28C")]
		public static string GetUIPrefabPath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x7EF314", Offset = "0x7EF314", VA = "0x7EF314")]
		public static string GetEffectPrefabPath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x7EF39C", Offset = "0x7EF39C", VA = "0x7EF39C")]
		public static string GetHomeIconPrefabPath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x7EF424", Offset = "0x7EF424", VA = "0x7EF424")]
		public static string GetFukuwaraiBasePath(int type)
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x7EF500", Offset = "0x7EF500", VA = "0x7EF500")]
		public static string GetFukuwaraiPartsPath(int fakeId, int type)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7EF5F0", Offset = "0x7EF5F0", VA = "0x7EF5F0")]
		public static string GetFukuwaraiFakePath(int fakeId, int type)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7EF6F8", Offset = "0x7EF6F8", VA = "0x7EF6F8")]
		public static string GetMusicGamePrefabPath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7EF780", Offset = "0x7EF780", VA = "0x7EF780")]
		public static string GetHideAndSeekPath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x7EF808", Offset = "0x7EF808", VA = "0x7EF808")]
		public static string GetSeekObjPath(int id)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x7EF8DC", Offset = "0x7EF8DC", VA = "0x7EF8DC")]
		public static string GetBGMPath(string bgmName)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x7EF964", Offset = "0x7EF964", VA = "0x7EF964")]
		public static string GetSEPath(string seName)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x7EF9EC", Offset = "0x7EF9EC", VA = "0x7EF9EC")]
		public static string GetVoicePath(string voiceName)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x7EFA74", Offset = "0x7EFA74", VA = "0x7EFA74")]
		public static string GetTexturePath(string name)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x7EFADC", Offset = "0x7EFADC", VA = "0x7EFADC")]
		public static string GetMusicGameDataName(string title, int level)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x7EFB88", Offset = "0x7EFB88", VA = "0x7EFB88")]
		public static string GetMusicGameAssetPath(string title, int level)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x7EFC20", Offset = "0x7EFC20", VA = "0x7EFC20")]
		public static string GetTimelineResourcePath(string path, TrackParameter.eResourceType type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000FB")]
	public class SaveData
	{
		[Token(Token = "0x20000FC")]
		private struct Data
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte[] array;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int size;

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x7F0424", Offset = "0x7F0424", VA = "0x7F0424")]
			public Data(int data)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x7F04B0", Offset = "0x7F04B0", VA = "0x7F04B0")]
			public Data(bool data)
			{
			}
		}

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_language;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_bgmVolume;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_seVolume;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_voiceVolume;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool m_subtitles;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] m_bestScore;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int m_flag;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int m_version;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] m_bestScoreSweet;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Data> dataList;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x7EFD3C", Offset = "0x7EFD3C", VA = "0x7EFD3C")]
		public byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x7F01A0", Offset = "0x7F01A0", VA = "0x7F01A0")]
		public void SetBytes(ref byte[] byteArray)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x7F0320", Offset = "0x7F0320", VA = "0x7F0320")]
		private int GetInt(ref byte[] data, ref int start)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7F03A0", Offset = "0x7F03A0", VA = "0x7F03A0")]
		private bool GetBool(ref byte[] data, ref int start)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7EFFB0", Offset = "0x7EFFB0", VA = "0x7EFFB0")]
		private int Add(int param)
		{
			return default(int);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x7F00A8", Offset = "0x7F00A8", VA = "0x7F00A8")]
		private int Add(bool param)
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x7F053C", Offset = "0x7F053C", VA = "0x7F053C")]
		public SaveData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FD")]
	public class SaveData2 : SaveData
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7F05E0", Offset = "0x7F05E0", VA = "0x7F05E0")]
		public SaveData2()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class SaveManager : SingletonMonoBehaviour<SaveManager>
	{
		[Token(Token = "0x400060E")]
		private const int MUSIC_GAME_LEVEL_NUM = 3;

		[Token(Token = "0x400060F")]
		public const int MUSIC_GAME_SCORE_NUM = 192;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SaveData m_data;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_isDirty;

		[Token(Token = "0x4000612")]
		public const string SAVE_FILE_NAME = "SaveData.dat";

		[Token(Token = "0x4000613")]
		public const string SAVE2_FILE_NAME = "SaveData2.dat";

		[Token(Token = "0x17000098")]
		public bool IsLoadingData
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x7F0638", Offset = "0x7F0638", VA = "0x7F0638")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x7F0640", Offset = "0x7F0640", VA = "0x7F0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool IsInitNotFound
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x7F064C", Offset = "0x7F064C", VA = "0x7F064C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x7F0654", Offset = "0x7F0654", VA = "0x7F0654")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public bool IsBrokenData
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x7F0660", Offset = "0x7F0660", VA = "0x7F0660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x7F0668", Offset = "0x7F0668", VA = "0x7F0668")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7F0674", Offset = "0x7F0674", VA = "0x7F0674")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x7F0798", Offset = "0x7F0798", VA = "0x7F0798")]
		private void CreateData()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7F0A00", Offset = "0x7F0A00", VA = "0x7F0A00")]
		private void CreateData(SaveData old)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7F095C", Offset = "0x7F095C", VA = "0x7F095C")]
		private void InitMusicGameScore()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x7F0860", Offset = "0x7F0860", VA = "0x7F0860")]
		private void InitMusicGameScoreSweet()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7F0A80", Offset = "0x7F0A80", VA = "0x7F0A80")]
		public void InitializeLocalParam()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x7F0CB4", Offset = "0x7F0CB4", VA = "0x7F0CB4")]
		public void Save()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x7F06B8", Offset = "0x7F06B8", VA = "0x7F06B8")]
		public bool Load()
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x7F0E6C", Offset = "0x7F0E6C", VA = "0x7F0E6C")]
		public void SetData(string str)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x7F0EDC", Offset = "0x7F0EDC", VA = "0x7F0EDC")]
		public void SetData(ref byte[] data)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x7F0DC8", Offset = "0x7F0DC8", VA = "0x7F0DC8")]
		private void CheckAfterLoad()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x7F0904", Offset = "0x7F0904", VA = "0x7F0904")]
		private int CheckInitializeLanguage()
		{
			return default(int);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x7F0C04", Offset = "0x7F0C04", VA = "0x7F0C04")]
		public ProjectDefine.eLanguage GetLanguage()
		{
			return default(ProjectDefine.eLanguage);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x7F0F78", Offset = "0x7F0F78", VA = "0x7F0F78")]
		public void SetLanguage(ProjectDefine.eLanguage language)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7F0F9C", Offset = "0x7F0F9C", VA = "0x7F0F9C")]
		public int GetBgmIntVolume()
		{
			return default(int);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7F0C1C", Offset = "0x7F0C1C", VA = "0x7F0C1C")]
		public float GetBgmVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x7F0FB4", Offset = "0x7F0FB4", VA = "0x7F0FB4")]
		public void SetBgmIntVolume(int volume)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x7F0FD8", Offset = "0x7F0FD8", VA = "0x7F0FD8")]
		public int GetSeIntVolume()
		{
			return default(int);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x7F0C44", Offset = "0x7F0C44", VA = "0x7F0C44")]
		public float GetSeVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x7F0FF0", Offset = "0x7F0FF0", VA = "0x7F0FF0")]
		public void SetSeIntVolume(int volume)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x7F1014", Offset = "0x7F1014", VA = "0x7F1014")]
		public int GetVoiceIntVolume()
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7F0C6C", Offset = "0x7F0C6C", VA = "0x7F0C6C")]
		public float GetVoiceVolume()
		{
			return default(float);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x7F102C", Offset = "0x7F102C", VA = "0x7F102C")]
		public void SetVoiceIntVolume(int volume)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x7F0C94", Offset = "0x7F0C94", VA = "0x7F0C94")]
		public bool GetSubtitlesFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x7F1050", Offset = "0x7F1050", VA = "0x7F1050")]
		public void SetSubtitlesFlag(bool isOn)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x7F10D8", Offset = "0x7F10D8", VA = "0x7F10D8")]
		public void SetMusicGameScore(GameDefine.eMusic title, int level, int score)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x7F115C", Offset = "0x7F115C", VA = "0x7F115C")]
		public void SetMusicGameScoreSweet(GameDefine.eMusic title, int level, int score)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x7F11E0", Offset = "0x7F11E0", VA = "0x7F11E0")]
		public int GetMusicGameScore(GameDefine.eMusic title, int level)
		{
			return default(int);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x7F1250", Offset = "0x7F1250", VA = "0x7F1250")]
		public int GetMusicGameScoreSweet(GameDefine.eMusic title, int level)
		{
			return default(int);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7F12C0", Offset = "0x7F12C0", VA = "0x7F12C0")]
		public int GetVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7F12DC", Offset = "0x7F12DC", VA = "0x7F12DC")]
		public void ForceSetDirty()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7F12E8", Offset = "0x7F12E8", VA = "0x7F12E8")]
		public SaveManager()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class BaseSceneComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000617")]
		protected const string START_VOICE_NAME = "vo_3001";

		[Token(Token = "0x4000618")]
		protected const string END_VOICE_NAME = "vo_3002";

		[Token(Token = "0x4000619")]
		protected const string LAST_30_VOICE_NAME = "vo_3003";

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool m_canPause;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_miniChara;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 100f)]
		[SerializeField]
		private int m_enableMiniCharaRate;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_isAppearMiniChara;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7F1330", Offset = "0x7F1330", VA = "0x7F1330", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x7F1454", Offset = "0x7F1454", VA = "0x7F1454", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x7F1560", Offset = "0x7F1560", VA = "0x7F1560", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x7F1634", Offset = "0x7F1634", VA = "0x7F1634", Slot = "8")]
		public virtual void OnPause()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x7F16A0", Offset = "0x7F16A0", VA = "0x7F16A0", Slot = "9")]
		public virtual void OnResume()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x7F16A4", Offset = "0x7F16A4", VA = "0x7F16A4")]
		public void SetMiniCharaActive(bool isActive)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x7F16D4", Offset = "0x7F16D4", VA = "0x7F16D4")]
		public BaseSceneComponent()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class SceneBootComponent : BaseSceneComponent
	{
		[Token(Token = "0x2000101")]
		private enum eState
		{
			[Token(Token = "0x4000622")]
			Logo = 0,
			[Token(Token = "0x4000623")]
			ResourceSetup = 1,
			[Token(Token = "0x4000624")]
			ResourceWait = 2,
			[Token(Token = "0x4000625")]
			EntitlementCheck = 4,
			[Token(Token = "0x4000626")]
			EntitlementCheckWait = 8,
			[Token(Token = "0x4000627")]
			WaitOneFrame = 0x10,
			[Token(Token = "0x4000628")]
			OtherSetup = 0x20,
			[Token(Token = "0x4000629")]
			WaitLoadSave = 0x40,
			[Token(Token = "0x400062A")]
			WaitCloseWindow = 0x1000,
			[Token(Token = "0x400062B")]
			ChangeScene = 0x2000,
			[Token(Token = "0x400062C")]
			End = 0x4000,
			[Token(Token = "0x400062D")]
			OpenHowToPlay = 0x8000,
			[Token(Token = "0x400062E")]
			UIOpenBrokenSaveData = 0x10000
		}

		[Token(Token = "0x2000102")]
		private class LogoViewer
		{
			[Token(Token = "0x2000103")]
			private enum eState
			{
				[Token(Token = "0x400063A")]
				Setting,
				[Token(Token = "0x400063B")]
				FadeIn,
				[Token(Token = "0x400063C")]
				Keep,
				[Token(Token = "0x400063D")]
				FadeOut
			}

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private eState m_state;

			[Token(Token = "0x4000630")]
			private const float FADE_TIME = 1f;

			[Token(Token = "0x4000631")]
			private const float KEEP_TIME = 2f;

			[Token(Token = "0x4000632")]
			private const float CAMERA_DIST = 5f;

			[Token(Token = "0x4000633")]
			private const float SPEED_TIME = 0.5f;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_nowViewIndex;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SpriteRenderer m_spriteRenderer;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Transform m_trans;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Color m_color;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float m_timer;

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x7F1890", Offset = "0x7F1890", VA = "0x7F1890")]
			public LogoViewer(SpriteRenderer sr)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x7F1DB0", Offset = "0x7F1DB0", VA = "0x7F1DB0")]
			public bool OnUpdate(Sprite[] textureArray)
			{
				return default(bool);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x7F21FC", Offset = "0x7F21FC", VA = "0x7F21FC")]
			private void PosUpdate()
			{
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x7F23F4", Offset = "0x7F23F4", VA = "0x7F23F4")]
			private void FrontUpdate()
			{
			}
		}

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private eState m_state;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BootParameter m_bootParameter;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LogoViewer m_logoViewr;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7F16E4", Offset = "0x7F16E4", VA = "0x7F16E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x7F18F4", Offset = "0x7F18F4", VA = "0x7F18F4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7F18F8", Offset = "0x7F18F8", VA = "0x7F18F8", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x7F1EF4", Offset = "0x7F1EF4", VA = "0x7F1EF4")]
		private void InitResourceLoad()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7F21EC", Offset = "0x7F21EC", VA = "0x7F21EC")]
		public SceneBootComponent()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SceneCreditComponent : BaseSceneComponent
	{
		[Token(Token = "0x2000105")]
		private enum eState
		{
			[Token(Token = "0x4000641")]
			Init,
			[Token(Token = "0x4000642")]
			Play,
			[Token(Token = "0x4000643")]
			Pause,
			[Token(Token = "0x4000644")]
			End
		}

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private eState m_state;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CreditParentComponent m_credit;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x7F251C", Offset = "0x7F251C", VA = "0x7F251C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7F2580", Offset = "0x7F2580", VA = "0x7F2580", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7F27AC", Offset = "0x7F27AC", VA = "0x7F27AC", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7F27E8", Offset = "0x7F27E8", VA = "0x7F27E8")]
		private void Init()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7F2950", Offset = "0x7F2950", VA = "0x7F2950")]
		private void Play()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7F29E4", Offset = "0x7F29E4", VA = "0x7F29E4", Slot = "8")]
		public override void OnPause()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x7F2A20", Offset = "0x7F2A20", VA = "0x7F2A20", Slot = "9")]
		public override void OnResume()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x7F2A90", Offset = "0x7F2A90", VA = "0x7F2A90")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7F2AA4", Offset = "0x7F2AA4", VA = "0x7F2AA4")]
		public SceneCreditComponent()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class SceneHomeComponent : BaseSceneComponent
	{
		[Token(Token = "0x2000107")]
		private enum eState
		{
			[Token(Token = "0x4000653")]
			WaitMenuCreated,
			[Token(Token = "0x4000654")]
			Init,
			[Token(Token = "0x4000655")]
			FadeInWait,
			[Token(Token = "0x4000656")]
			TitleCallInit,
			[Token(Token = "0x4000657")]
			TitleCall,
			[Token(Token = "0x4000658")]
			UpdateDescription,
			[Token(Token = "0x4000659")]
			Main,
			[Token(Token = "0x400065A")]
			WaitPlayMovie,
			[Token(Token = "0x400065B")]
			BirthdayEvent,
			[Token(Token = "0x400065C")]
			BirthdayEventWait
		}

		[Token(Token = "0x4000645")]
		private const string TITLE_CALL_VOICE_NAME = "vo_0002";

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] ANIVASARY_CALL_VOICE_NAMES;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private eState m_state;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MenuComponent m_menu;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TitleLogoComponent m_logo;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnniversaryLogoTextComponent m_anniversaryLogo;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BirthdayLogoComponent m_birthdayLogoComponent;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject[] m_birthdayObject;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MenuComponent.eMenuType m_keepMenuType;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private MenuComponent.eMenuType m_pauseMenuType;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private MovieComponent m_keepMovieComponent;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SoundComponent m_titleCall;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UIBlinkingComponent m_uiBlinkingComponent;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7F2AB4", Offset = "0x7F2AB4", VA = "0x7F2AB4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x7F2EA0", Offset = "0x7F2EA0", VA = "0x7F2EA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x7F31D8", Offset = "0x7F31D8", VA = "0x7F31D8", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x7F34D0", Offset = "0x7F34D0", VA = "0x7F34D0")]
		private void InitUpdate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x7F374C", Offset = "0x7F374C", VA = "0x7F374C")]
		private void FadeInWaitUpdate()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x7F38B4", Offset = "0x7F38B4", VA = "0x7F38B4")]
		private void TitleCallInit()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x7F3B60", Offset = "0x7F3B60", VA = "0x7F3B60")]
		private void TitleCallUpdate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x7F3C44", Offset = "0x7F3C44", VA = "0x7F3C44")]
		private void UpdateDescriptionUpdate()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x7F3C48", Offset = "0x7F3C48", VA = "0x7F3C48")]
		private void MainUpdate()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x7F4014", Offset = "0x7F4014", VA = "0x7F4014")]
		private void BirthdayEventWaitUpdate()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x7F404C", Offset = "0x7F404C", VA = "0x7F404C")]
		public void SetPlayMovie(MovieComponent component)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7F4070", Offset = "0x7F4070", VA = "0x7F4070")]
		public void BatteryOffEvent(InputManager.eActiveHandType hand)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7F3F80", Offset = "0x7F3F80", VA = "0x7F3F80")]
		public void OpenLogo()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7F3E84", Offset = "0x7F3E84", VA = "0x7F3E84")]
		public void CloseLogo()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x7F407C", Offset = "0x7F407C", VA = "0x7F407C")]
		public void ChangeLogoTop(bool isTop)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x7F409C", Offset = "0x7F409C", VA = "0x7F409C", Slot = "8")]
		public override void OnPause()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7F418C", Offset = "0x7F418C", VA = "0x7F418C")]
		public void OnPauseMovie()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7F424C", Offset = "0x7F424C", VA = "0x7F424C", Slot = "9")]
		public override void OnResume()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7F427C", Offset = "0x7F427C", VA = "0x7F427C")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x7F3F18", Offset = "0x7F3F18", VA = "0x7F3F18")]
		public void OpenMenu(MenuComponent.eMenuType type)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x7F4288", Offset = "0x7F4288", VA = "0x7F4288")]
		public void CloseCurrentMenu()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x7F42C4", Offset = "0x7F42C4", VA = "0x7F42C4")]
		public void CloseAllMenu()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x7F42E0", Offset = "0x7F42E0", VA = "0x7F42E0")]
		public SceneHomeComponent()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class SceneMusicGameComponent : BaseSceneComponent
	{
		[Token(Token = "0x200010A")]
		public enum ePenLightType
		{
			[Token(Token = "0x400069C")]
			Right,
			[Token(Token = "0x400069D")]
			Left,
			[Token(Token = "0x400069E")]
			Max
		}

		[Token(Token = "0x200010B")]
		public enum eState
		{
			[Token(Token = "0x40006A0")]
			Init,
			[Token(Token = "0x40006A1")]
			ReadySetting,
			[Token(Token = "0x40006A2")]
			WaitReady,
			[Token(Token = "0x40006A3")]
			Play,
			[Token(Token = "0x40006A4")]
			Pause,
			[Token(Token = "0x40006A5")]
			PauseEnd,
			[Token(Token = "0x40006A6")]
			EndPlayFade,
			[Token(Token = "0x40006A7")]
			Result,
			[Token(Token = "0x40006A8")]
			ViewEnd,
			[Token(Token = "0x40006A9")]
			ViewEndFade
		}

		[Token(Token = "0x200010C")]
		public enum eLevel
		{
			[Token(Token = "0x40006AB")]
			Unknown = -1,
			[Token(Token = "0x40006AC")]
			Easy,
			[Token(Token = "0x40006AD")]
			Normal,
			[Token(Token = "0x40006AE")]
			Hard
		}

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color CAMERA_CLEAR_COLOR;

		[Token(Token = "0x4000660")]
		private const string TIMELINE_BIND_CHARA_NAME = "Chara";

		[Token(Token = "0x4000661")]
		private const string TIMELINE_BIND_EYE_NAME = "Eye";

		[Token(Token = "0x4000662")]
		private const string TIMELINE_BIND_HAIR_NAME = "Hair";

		[Token(Token = "0x4000663")]
		private const string FULL_COMBO_VOICE_NAME = "vo_4001";

		[Token(Token = "0x4000664")]
		private const string END_GAME_VOICE_NAME = "vo_4002";

		[Token(Token = "0x4000665")]
		private const float DEFAULT_SPEED = 1f;

		[Token(Token = "0x4000666")]
		private const float INIT_END_POS_HEIGHT_FROM_CAMERA = -0.2f;

		[Token(Token = "0x4000667")]
		public const float BASE_MIN_END_POS_HEIGHT = 1.05f;

		[Token(Token = "0x4000668")]
		private const float INIT_END_POS_HEIGHT_MIN = 0.84999996f;

		[Token(Token = "0x4000669")]
		public const int NOTES_POS_NUM = 8;

		[Token(Token = "0x400066A")]
		private const float NOTES_END_RADIUS = 0.4f;

		[Token(Token = "0x400066B")]
		private const float COMBO_SCALE_ADD = 0.2f;

		[Token(Token = "0x400066C")]
		private const float COMBO_SCALE_TIME = 0.3f;

		[Token(Token = "0x400066D")]
		private const float NOTES_START_DIST = 5f;

		[Token(Token = "0x400066E")]
		private const float CHARA_DIST_MAX_COMBO = 40f;

		[Token(Token = "0x400066F")]
		private const float END_FADE_OUT_TIME = 0.5f;

		[Token(Token = "0x4000670")]
		private const float END_FADE_IN_TIME = 1f;

		[Token(Token = "0x4000671")]
		private const float CHARA_MOVE_TIME = 1f;

		[Token(Token = "0x4000672")]
		private const float CHARA_Y = 0.33f;

		[Token(Token = "0x4000673")]
		private const float POSITION_OFFSETY_2019_BD = 0.04f;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private eState m_state;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform[] m_startPointArray;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform[] m_endPointArray;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform m_startParent;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform m_endParent;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PlayableDirector m_timeline;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SoundComponent m_bgmComponent;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SoundComponent m_voiceComponent;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TMP_Text m_comboText;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MusicGameController m_gameController;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ScriptableMusicGameDataParameter m_param;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_comboTimer;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InterpolatorVector3 m_charaPosInterpolator;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private SoundComponent m_resultSEComponent;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_isEndResultSE;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ReadyComponent m_ready;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SpriteRenderer m_backScreen;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private MeshRenderer m_floor;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform m_aiStage;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private EffectEmissionChanger[] m_effectForScoreArray;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject m_tutorialParent;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private PlayableDirector m_tutorial;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private SpriteRenderer[] m_tutorialRendererArray;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_isTutorial;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private eLevel m_currentLevel;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_isEndVoice;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool m_isViewMode;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private AudioLineRenderer m_audioLineRenderer;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<BaseStageDifferentSetter> m_differentSetterList;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Color m_stageColor;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject m_onlyViewModeObject;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float m_charaFarDist;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float m_charaNearDist;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private SpriteRenderer m_oldIcon;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject m_footPrint;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private TimelineParameter m_timelineParam;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private List<GameObject> m_objForTimelineList;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private StageGimmickInitializer[] m_gimmickArray;

		[Token(Token = "0x1700009B")]
		public Transform EndParent
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x7F46A4", Offset = "0x7F46A4", VA = "0x7F46A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public Transform AiStage
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x7F46AC", Offset = "0x7F46AC", VA = "0x7F46AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public PenLightComponent[] PenLight
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x7F46B4", Offset = "0x7F46B4", VA = "0x7F46B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x7F46BC", Offset = "0x7F46BC", VA = "0x7F46BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x7F46CC", Offset = "0x7F46CC", VA = "0x7F46CC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7F4FE0", Offset = "0x7F4FE0", VA = "0x7F4FE0")]
		private void CreateEndPoint()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x7F5210", Offset = "0x7F5210", VA = "0x7F5210", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7F5964", Offset = "0x7F5964", VA = "0x7F5964", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7F6F00", Offset = "0x7F6F00", VA = "0x7F6F00")]
		private void ComboScaleUpdate()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7F6F9C", Offset = "0x7F6F9C", VA = "0x7F6F9C")]
		private void AiStageUpdate()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x7F5FEC", Offset = "0x7F5FEC", VA = "0x7F5FEC")]
		private void InitUpdate()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x7F6580", Offset = "0x7F6580", VA = "0x7F6580")]
		private void ReadySettingUpdate()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x7F66B0", Offset = "0x7F66B0", VA = "0x7F66B0")]
		private void WaitReadyUpdate()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x7F6958", Offset = "0x7F6958", VA = "0x7F6958")]
		private void PlayUpdate()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x7F7D8C", Offset = "0x7F7D8C", VA = "0x7F7D8C")]
		private void ViewModeUpdate()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x7F7D90", Offset = "0x7F7D90", VA = "0x7F7D90", Slot = "8")]
		public override void OnPause()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x7F7F14", Offset = "0x7F7F14", VA = "0x7F7F14", Slot = "9")]
		public override void OnResume()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x7F7CA0", Offset = "0x7F7CA0", VA = "0x7F7CA0")]
		private void Calibration()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x7F8020", Offset = "0x7F8020", VA = "0x7F8020")]
		public void SetComboNum(int combo)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x7F80B8", Offset = "0x7F80B8", VA = "0x7F80B8")]
		public void SetStageMoveComboNum(int combo)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x7F8310", Offset = "0x7F8310", VA = "0x7F8310")]
		public void SetEffectForScoreEmission(float rate)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x7F8390", Offset = "0x7F8390", VA = "0x7F8390")]
		public void BatteryOffEvent(InputManager.eActiveHandType hand)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x7F839C", Offset = "0x7F839C", VA = "0x7F839C")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x7F7BF0", Offset = "0x7F7BF0", VA = "0x7F7BF0")]
		public void ChangeViewModeStage(bool isEnabled)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x7F83B0", Offset = "0x7F83B0", VA = "0x7F83B0")]
		public void AddDifferentSetter(BaseStageDifferentSetter stageDiff)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x7F8460", Offset = "0x7F8460", VA = "0x7F8460")]
		private void ResetPlayerTrans()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x7F6EE8", Offset = "0x7F6EE8", VA = "0x7F6EE8")]
		private BasePlatform.eTrophy GetTrophyRank(eLevel level)
		{
			return default(BasePlatform.eTrophy);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7F4EC0", Offset = "0x7F4EC0", VA = "0x7F4EC0")]
		private void TimelineResourceLoadRequest(GameDefine.eMusic title)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7F7060", Offset = "0x7F7060", VA = "0x7F7060")]
		private bool IsFinishTimelineResourceLoad()
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7F7138", Offset = "0x7F7138", VA = "0x7F7138")]
		private void BindTimeline()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x7F8560", Offset = "0x7F8560", VA = "0x7F8560")]
		public SceneMusicGameComponent()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class BaseStageDifferentSetter : BaseMonoBehaviour
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x7F8838", Offset = "0x7F8838", VA = "0x7F8838")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x7F88AC", Offset = "0x7F88AC", VA = "0x7F88AC", Slot = "6")]
		public virtual void SetColor(Color col)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x7F88B0", Offset = "0x7F88B0", VA = "0x7F88B0")]
		public BaseStageDifferentSetter()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class ColorDifferentSetter : BaseStageDifferentSetter
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MeshRenderer[] m_meshArray;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x7F88B8", Offset = "0x7F88B8", VA = "0x7F88B8", Slot = "6")]
		public override void SetColor(Color col)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x7F89C0", Offset = "0x7F89C0", VA = "0x7F89C0")]
		public ColorDifferentSetter()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class EmissionDifferentSetter : BaseStageDifferentSetter
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SHADER_ID_EMISSIVE;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MeshRenderer[] m_meshArray;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x7F89C8", Offset = "0x7F89C8", VA = "0x7F89C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x7F8A78", Offset = "0x7F8A78", VA = "0x7F8A78", Slot = "6")]
		public override void SetColor(Color col)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x7F8BC4", Offset = "0x7F8BC4", VA = "0x7F8BC4")]
		public EmissionDifferentSetter()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class StepSplasher : StageGimmickInitializer
	{
		[Token(Token = "0x2000113")]
		private class Foot
		{
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_isUp;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float m_coolTimer;

			[Token(Token = "0x1700009E")]
			public Transform FootTrans
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x7F96B4", Offset = "0x7F96B4", VA = "0x7F96B4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x7F96BC", Offset = "0x7F96BC", VA = "0x7F96BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x7F8E64", Offset = "0x7F8E64", VA = "0x7F8E64")]
			public Foot(Transform trans)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x7F9108", Offset = "0x7F9108", VA = "0x7F9108")]
			public bool OnUpdate(Transform baseTrans)
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x7F96C4", Offset = "0x7F96C4", VA = "0x7F96C4")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000114")]
		private class EffectData
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private EffectComponent m_effect;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 m_baseDiff;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform m_parent;

			[Token(Token = "0x1700009F")]
			public bool IsPlaying
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x7F93B0", Offset = "0x7F93B0", VA = "0x7F93B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x7F91D4", Offset = "0x7F91D4", VA = "0x7F91D4")]
			public EffectData(EffectComponent effect, Transform parent)
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x7F9438", Offset = "0x7F9438", VA = "0x7F9438")]
			public void OnLateUpdate()
			{
			}
		}

		[Token(Token = "0x40006B6")]
		private const float OVER_Y = 0.08f;

		[Token(Token = "0x40006B7")]
		private const float UNDER_Y = 0.07f;

		[Token(Token = "0x40006B8")]
		private const float COOL_TIME = 0.1f;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<string> FEET_PATH_LIST;

		[Token(Token = "0x40006BA")]
		private const string WAVE_NAME = "wave_Step";

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_baseTrans;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Foot[] m_feetList;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_posParent;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<EffectData> m_effectList;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x7F8C18", Offset = "0x7F8C18", VA = "0x7F8C18", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x7F8E94", Offset = "0x7F8E94", VA = "0x7F8E94")]
		public void Update()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x7F927C", Offset = "0x7F927C", VA = "0x7F927C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x7F94C4", Offset = "0x7F94C4", VA = "0x7F94C4")]
		public StepSplasher()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public static class GameDefine
	{
		[Token(Token = "0x2000116")]
		public enum eStageType
		{
			[Token(Token = "0x40006EA")]
			Music00,
			[Token(Token = "0x40006EB")]
			Music01
		}

		[Token(Token = "0x2000117")]
		public enum eNotesType
		{
			[Token(Token = "0x40006ED")]
			None,
			[Token(Token = "0x40006EE")]
			Normal,
			[Token(Token = "0x40006EF")]
			OAD_RightToLeft,
			[Token(Token = "0x40006F0")]
			OAD_LeftToRight,
			[Token(Token = "0x40006F1")]
			FrontSwing_Right,
			[Token(Token = "0x40006F2")]
			FrontSwing_Left,
			[Token(Token = "0x40006F3")]
			Long
		}

		[Token(Token = "0x2000118")]
		public enum eMusic
		{
			[Token(Token = "0x40006F5")]
			Tutorial = 0,
			[Token(Token = "0x40006F6")]
			MeltyWorld = 1,
			[Token(Token = "0x40006F7")]
			HelloMorning = 2,
			[Token(Token = "0x40006F8")]
			TheMIRACLE = 3,
			[Token(Token = "0x40006F9")]
			Again = 4,
			[Token(Token = "0x40006FA")]
			Awakening = 5,
			[Token(Token = "0x40006FB")]
			Mirai = 6,
			[Token(Token = "0x40006FC")]
			NewWorld = 7,
			[Token(Token = "0x40006FD")]
			FutureBase = 8,
			[Token(Token = "0x40006FE")]
			SkyHigh = 9,
			[Token(Token = "0x40006FF")]
			FLAIYER = 10,
			[Token(Token = "0x4000700")]
			TouchMe = 11,
			[Token(Token = "0x4000701")]
			MeetYou = 12,
			[Token(Token = "0x4000702")]
			RADIOLOVEHIGHWAY = 13,
			[Token(Token = "0x4000703")]
			Helloalone = 14,
			[Token(Token = "0x4000704")]
			HereForYou = 15,
			[Token(Token = "0x4000705")]
			ComingSoon = 1000,
			[Token(Token = "0x4000706")]
			Shop = 1001
		}

		[Token(Token = "0x40006C5")]
		public const string SE_DECIDE = "se_0001";

		[Token(Token = "0x40006C6")]
		public const string SE_CURSOR = "se_0002";

		[Token(Token = "0x40006C7")]
		public const string SE_IMPORTANT_DECIDE = "se_0003";

		[Token(Token = "0x40006C8")]
		public const string SE_CANCEL = "se_0004";

		[Token(Token = "0x40006C9")]
		public const string SE_COUNT_DOWN = "se_3001";

		[Token(Token = "0x40006CA")]
		public const string SE_TIME_UP = "se_3002";

		[Token(Token = "0x40006CB")]
		public const string SE_GRAB = "se_3003";

		[Token(Token = "0x40006CC")]
		public const string SE_RESULT_0 = "se_3004";

		[Token(Token = "0x40006CD")]
		public const string SE_RESULT_1 = "se_3005";

		[Token(Token = "0x40006CE")]
		public const string SE_RESULT_2 = "se_3006";

		[Token(Token = "0x40006CF")]
		public const string SE_RESULT_3 = "se_3007";

		[Token(Token = "0x40006D0")]
		public const string SE_PARTS_SET = "se_3101";

		[Token(Token = "0x40006D1")]
		public const string SE_STEP = "se_3102";

		[Token(Token = "0x40006D2")]
		public const string SE_NOTE_SUCCESS = "se_3001";

		[Token(Token = "0x40006D3")]
		public const string SE_NOTE_SUCCESS_DOUBLE = "se_3002";

		[Token(Token = "0x40006D4")]
		public const string SE_NOTE_LONG_END_SUCCESS = "se_3002";

		[Token(Token = "0x40006D5")]
		public const string SE_NOTE_LONG_TOUCHING = "se_3010";

		[Token(Token = "0x40006D6")]
		public const string SE_NOTE_SWING_START = "se_3003";

		[Token(Token = "0x40006D7")]
		public const string SE_NOTE_SWING_END = "se_3004";

		[Token(Token = "0x40006D8")]
		public const string SE_NOTE_OAD_START = "se_3005";

		[Token(Token = "0x40006D9")]
		public const string SE_NOTE_OAD_END = "se_3006";

		[Token(Token = "0x40006DA")]
		public const string SE_COMBO_HALF = "se_3007";

		[Token(Token = "0x40006DB")]
		public const string SE_COMBO_MAX = "se_3008";

		[Token(Token = "0x40006DC")]
		public const string SE_COMBO_BOOING = "se_3009";

		[Token(Token = "0x40006DD")]
		public const string SE_GAME_RESULT = "se_3501";

		[Token(Token = "0x40006DE")]
		public const string BGM_HOME = "bgm_000";

		[Token(Token = "0x40006DF")]
		public const string TUTORIAL_TITLE = "Tutorial";

		[Token(Token = "0x40006E0")]
		public const string COMING_SOON_TITLE = "CS";

		[Token(Token = "0x40006E1")]
		public const string INIT_PRICE_VALUE = "0.00";

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<eMusic> PRE_INSTALL_MUSIC_ARRAY;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly eMusic PRE_INSTALL_MOVIE;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly ReadOnlyCollection<BasePlatform.eDLC> DEFAULT_MUSIC_ARRAY;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly ReadOnlyCollection<eMusic> LOW_RES_VER_MOVIE_ARRAY;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly ReadOnlyCollection<string> STAGE_NAME_ARRAY;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly ReadOnlyCollection<string> MUSIC_STRING_ARRAY;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Dictionary<eMusic, BasePlatform.eDLC> MUSIC_DLC_LIST;
	}
	[Token(Token = "0x2000119")]
	public class GameManager : SingletonMonoBehaviour<GameManager>
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_initialized;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BaseSceneComponent m_scene;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_rightHandEnableCache;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool m_leftHandEnableCache;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_currentBgmName;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action m_appFocusAction;

		[Token(Token = "0x170000A0")]
		public PlayerComponent Player
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x7FA1C8", Offset = "0x7FA1C8", VA = "0x7FA1C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x7FA1D0", Offset = "0x7FA1D0", VA = "0x7FA1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public LightComponent Light
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x7FA1D8", Offset = "0x7FA1D8", VA = "0x7FA1D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x7FA1E0", Offset = "0x7FA1E0", VA = "0x7FA1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool IsFirstHome
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x7FA1E8", Offset = "0x7FA1E8", VA = "0x7FA1E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x7FA1F0", Offset = "0x7FA1F0", VA = "0x7FA1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public BasePlatform Platform
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x7FA1FC", Offset = "0x7FA1FC", VA = "0x7FA1FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x7FA204", Offset = "0x7FA204", VA = "0x7FA204")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool IsViewMode
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x7FA20C", Offset = "0x7FA20C", VA = "0x7FA20C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x7FA214", Offset = "0x7FA214", VA = "0x7FA214")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool IsSweetMode
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x7FA220", Offset = "0x7FA220", VA = "0x7FA220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x7FA228", Offset = "0x7FA228", VA = "0x7FA228")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsRandomMode
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x7FA234", Offset = "0x7FA234", VA = "0x7FA234")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x7FA23C", Offset = "0x7FA23C", VA = "0x7FA23C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool IsFixedPosition
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x7FA248", Offset = "0x7FA248", VA = "0x7FA248")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x7FA250", Offset = "0x7FA250", VA = "0x7FA250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool IsUseEffect
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x7FA25C", Offset = "0x7FA25C", VA = "0x7FA25C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x7FA264", Offset = "0x7FA264", VA = "0x7FA264")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool IsUsePenlight
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x7FA270", Offset = "0x7FA270", VA = "0x7FA270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x7FA278", Offset = "0x7FA278", VA = "0x7FA278")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public Dictionary<MenuComponent.eMenuType, int> CurrentMenuLeftIndexList
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x7FA284", Offset = "0x7FA284", VA = "0x7FA284")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x7FA28C", Offset = "0x7FA28C", VA = "0x7FA28C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public Dictionary<MenuComponent.eMenuType, BaseMenuItemGroup.eSortType> MenuSortTypeList
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x7FA294", Offset = "0x7FA294", VA = "0x7FA294")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x7FA29C", Offset = "0x7FA29C", VA = "0x7FA29C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public Dictionary<MenuComponent.eMenuType, int> CurrentChooseIndexList
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x7FA2A4", Offset = "0x7FA2A4", VA = "0x7FA2A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x7FA2AC", Offset = "0x7FA2AC", VA = "0x7FA2AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x7FA2B4", Offset = "0x7FA2B4", VA = "0x7FA2B4")]
		public void AddAppFocusAction(Action action)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x7FA344", Offset = "0x7FA344", VA = "0x7FA344")]
		public void RemoveAppFocusAction(Action action)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x7F205C", Offset = "0x7F205C", VA = "0x7F205C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x7FA3D4", Offset = "0x7FA3D4", VA = "0x7FA3D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x7FA3F4", Offset = "0x7FA3F4", VA = "0x7FA3F4")]
		public void ResetGame()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x7EEA3C", Offset = "0x7EEA3C", VA = "0x7EEA3C")]
		public void SetPlayer(PlayerComponent p)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x7FA3F8", Offset = "0x7FA3F8", VA = "0x7FA3F8")]
		public void SetLight(LightComponent l)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x7FA400", Offset = "0x7FA400", VA = "0x7FA400")]
		public void RemoveLight(LightComponent l)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x7FA490", Offset = "0x7FA490", VA = "0x7FA490")]
		public void SetScene(BaseSceneComponent component)
		{
		}

		[Token(Token = "0x60005C2")]
		public T GetScene<T>() where T : BaseSceneComponent
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x7FA498", Offset = "0x7FA498", VA = "0x7FA498")]
		private void OnAppFocus()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x7FA600", Offset = "0x7FA600", VA = "0x7FA600")]
		private void OnAppFocusLost()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x7FA768", Offset = "0x7FA768", VA = "0x7FA768")]
		private void OnMounted()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x7FA800", Offset = "0x7FA800", VA = "0x7FA800")]
		private void OnUnMounted()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x7F2DC8", Offset = "0x7F2DC8", VA = "0x7F2DC8")]
		public void PlayBGM(string name)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x7FA898", Offset = "0x7FA898", VA = "0x7FA898")]
		public void PlayRandomBGM()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x7F4E5C", Offset = "0x7F4E5C", VA = "0x7F4E5C")]
		public void StopBGM()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x7FA89C", Offset = "0x7FA89C", VA = "0x7FA89C")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x7FA8BC", Offset = "0x7FA8BC", VA = "0x7FA8BC")]
		public void SetCanCameraMoveAngle(bool canMove, bool isReset = true)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x7FA950", Offset = "0x7FA950", VA = "0x7FA950")]
		public GameManager()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class RaycastController
	{
		[Token(Token = "0x200011B")]
		public class RayData
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int m_mask;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public RaycastHit m_hit;

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x7FACA8", Offset = "0x7FACA8", VA = "0x7FACA8")]
			public RayData()
			{
			}
		}

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, RayData> m_cacheList;

		[Token(Token = "0x170000AD")]
		public Transform StartTrans
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x7FAA78", Offset = "0x7FAA78", VA = "0x7FAA78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x7FAA80", Offset = "0x7FAA80", VA = "0x7FAA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x7FAA88", Offset = "0x7FAA88", VA = "0x7FAA88")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x7FAAD8", Offset = "0x7FAAD8", VA = "0x7FAAD8")]
		public RayData Raycast(int mask)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x7FACB0", Offset = "0x7FACB0", VA = "0x7FACB0")]
		public RaycastController()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class BasePreviewComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200011D")]
		public enum eState
		{
			[Token(Token = "0x4000727")]
			Open,
			[Token(Token = "0x4000728")]
			Wait,
			[Token(Token = "0x4000729")]
			Close,
			[Token(Token = "0x400072A")]
			End
		}

		[Token(Token = "0x400071E")]
		private const float ANIM_TIME = 0.2f;

		[Token(Token = "0x400071F")]
		private const float OPENING_TIME = 2f;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private eState m_state;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Image m_costumeImage;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Canvas m_canvas;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InterpolatorFloat m_scaleInterpolator;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_localScale;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_timer;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x7FAD3C", Offset = "0x7FAD3C", VA = "0x7FAD3C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x7FAE1C", Offset = "0x7FAE1C", VA = "0x7FAE1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D5")]
		public abstract void Show(int typeIndex);

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x7FAFA0", Offset = "0x7FAFA0", VA = "0x7FAFA0")]
		protected void Show()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x7FB044", Offset = "0x7FB044", VA = "0x7FB044")]
		public void SetSortingOrder(int sortingOrder)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x7FB060", Offset = "0x7FB060", VA = "0x7FB060")]
		protected BasePreviewComponent()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class BaseUIComponent : GameComponent
	{
		[Token(Token = "0x400072B")]
		private const float ANIM_FADE_TIME = 0.1f;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<string> m_animationNameList;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action m_onEndAnim;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isSetAnimFrame;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x7FB0EC", Offset = "0x7FB0EC", VA = "0x7FB0EC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x7FB240", Offset = "0x7FB240", VA = "0x7FB240", Slot = "9")]
		public virtual void OnEnableAnim()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x7FB384", Offset = "0x7FB384", VA = "0x7FB384", Slot = "10")]
		public virtual void OnDisableAnim([Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x7FB3DC", Offset = "0x7FB3DC", VA = "0x7FB3DC", Slot = "11")]
		public virtual void OnEnterPointer()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x7FB428", Offset = "0x7FB428", VA = "0x7FB428", Slot = "12")]
		public virtual void OnExitPointer()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x7FB474", Offset = "0x7FB474", VA = "0x7FB474", Slot = "13")]
		public virtual void OnClick(InputManager.eActiveHandType handType, [Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x7FB4CC", Offset = "0x7FB4CC", VA = "0x7FB4CC", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x7FB28C", Offset = "0x7FB28C", VA = "0x7FB28C")]
		protected void PlayAnimation(string animName, [Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x7FB5B0", Offset = "0x7FB5B0", VA = "0x7FB5B0")]
		public BaseUIComponent()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class BaseWindowComponent : BaseUIComponent
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		protected class LeftRightGroup
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text m_valueText;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIButtonComponent m_leftButton;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIButtonComponent m_rightButton;

			[Token(Token = "0x170000B0")]
			public string[] DataList
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x7FD480", Offset = "0x7FD480", VA = "0x7FD480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x7FD488", Offset = "0x7FD488", VA = "0x7FD488")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public bool IsLoop
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x7FD490", Offset = "0x7FD490", VA = "0x7FD490")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x7FD498", Offset = "0x7FD498", VA = "0x7FD498")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public int Index
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x7FD4A4", Offset = "0x7FD4A4", VA = "0x7FD4A4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x7FD4AC", Offset = "0x7FD4AC", VA = "0x7FD4AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x7FD4B4", Offset = "0x7FD4B4", VA = "0x7FD4B4")]
			public void SetValueIndex(int index)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x7FD5A4", Offset = "0x7FD5A4", VA = "0x7FD5A4", Slot = "4")]
			public virtual void NextIndex(bool isAdd = true)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x7FD5BC", Offset = "0x7FD5BC", VA = "0x7FD5BC")]
			public void SetRightButtonActive(bool isActive)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x7FD5EC", Offset = "0x7FD5EC", VA = "0x7FD5EC")]
			public void SetLeftButtonActive(bool isActive)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x7FD61C", Offset = "0x7FD61C", VA = "0x7FD61C")]
			public LeftRightGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000121")]
		protected class LeftRightBuyGroup : LeftRightGroup
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject m_networkErrorIcon;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GameObject m_buyButton;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TMP_Text m_priceText;

			[Token(Token = "0x170000B3")]
			public BasePlatform.eDLC[] DlcArray
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x7FD624", Offset = "0x7FD624", VA = "0x7FD624")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x7FD62C", Offset = "0x7FD62C", VA = "0x7FD62C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x7FD634", Offset = "0x7FD634", VA = "0x7FD634")]
			public void Init(GameObject networkErrorIcon, GameObject buyButton, TMP_Text priceText)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x7FD678", Offset = "0x7FD678", VA = "0x7FD678")]
			public void BuyAction([Optional] Action onEnd)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x7FD7B8", Offset = "0x7FD7B8", VA = "0x7FD7B8")]
			public void CheckCostumeState()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x7FD8D8", Offset = "0x7FD8D8", VA = "0x7FD8D8", Slot = "4")]
			public override void NextIndex(bool isAdd)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x7FD904", Offset = "0x7FD904", VA = "0x7FD904")]
			public LeftRightBuyGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		protected class LeftRightToggleGroup : LeftRightGroup
		{
			[Token(Token = "0x170000B4")]
			public bool Flag
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x7FD9B4", Offset = "0x7FD9B4", VA = "0x7FD9B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x7FD9C4", Offset = "0x7FD9C4", VA = "0x7FD9C4")]
				set
				{
				}
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x7FD9CC", Offset = "0x7FD9CC", VA = "0x7FD9CC")]
			public void Init(bool isDefaultTrue = true)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x7FDB14", Offset = "0x7FDB14", VA = "0x7FDB14")]
			public LeftRightToggleGroup()
			{
			}
		}

		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <MovedWaitCoroutine>d__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseWindowComponent <>4__this;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float waitTime;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x7FDD6C", Offset = "0x7FDD6C", VA = "0x7FDD6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x7FDDB4", Offset = "0x7FDDB4", VA = "0x7FDDB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x7FD3F8", Offset = "0x7FD3F8", VA = "0x7FD3F8")]
			[DebuggerHidden]
			public <MovedWaitCoroutine>d__53(int <>1__state)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x7FDCB0", Offset = "0x7FDCB0", VA = "0x7FDCB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x7FDCB4", Offset = "0x7FDCB4", VA = "0x7FDCB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x7FDD74", Offset = "0x7FDD74", VA = "0x7FDD74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072F")]
		private const float BUTTON_VIBRATION_TIME = 0.02f;

		[Token(Token = "0x4000730")]
		private const float BUTTON_VIBRATION_POWER = 0.5f;

		[Token(Token = "0x4000731")]
		private const float SHOW_CAMERA_DIST = 1.5f;

		[Token(Token = "0x4000732")]
		private const string COSTUME_VIEW_PREFAB_PATH = "Prefab/";

		[Token(Token = "0x4000733")]
		private const float DEFAULT_UI_TO_CAMERA_DISTANCE = 0.5f;

		[Token(Token = "0x4000734")]
		protected const float DEFAULT_OPTION_MENU_DISTANCE = 1f;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIManager.eUsePlayType UsePlayType;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected UIButtonComponent[] m_componentList;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Action[] m_decideActionList;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] m_hitIndexArray;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int[] m_hitIndexBeforeArray;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected Action m_closedAction;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_isOpen;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Canvas m_canvas;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] m_colliderArray;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_isViewFront;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float m_frontDist;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected bool m_isCollderDisable;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		protected bool m_isMenuMoving;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected UIButtonComponent m_currentChooseComponent;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected int m_currentUIButtonIndex;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_waitTime;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_waitMaxTime;

		[Token(Token = "0x170000AE")]
		public UIManager.eWindowType WindowType
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x7FB638", Offset = "0x7FB638", VA = "0x7FB638")]
			[CompilerGenerated]
			get
			{
				return default(UIManager.eWindowType);
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x7FB640", Offset = "0x7FB640", VA = "0x7FB640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool IsActive
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x7FB648", Offset = "0x7FB648", VA = "0x7FB648")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x7FB650", Offset = "0x7FB650", VA = "0x7FB650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x7FB65C", Offset = "0x7FB65C", VA = "0x7FB65C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x7FB6C8", Offset = "0x7FB6C8", VA = "0x7FB6C8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x7FB8D0", Offset = "0x7FB8D0", VA = "0x7FB8D0")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x7FB97C", Offset = "0x7FB97C", VA = "0x7FB97C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x7FBAE8", Offset = "0x7FBAE8", VA = "0x7FBAE8", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x7FC208", Offset = "0x7FC208", VA = "0x7FC208", Slot = "8")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x7FC288", Offset = "0x7FC288", VA = "0x7FC288", Slot = "14")]
		public virtual void OnOpen()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x7FC3D8", Offset = "0x7FC3D8", VA = "0x7FC3D8", Slot = "15")]
		public virtual void OnClose()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x7FC530", Offset = "0x7FC530", VA = "0x7FC530")]
		protected void SetPosToCameraFront()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x7FC780", Offset = "0x7FC780", VA = "0x7FC780")]
		public void SetCloseAction(Action action)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x7FC788", Offset = "0x7FC788", VA = "0x7FC788")]
		protected bool IsPointerOn(int componentIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x7FC7E0", Offset = "0x7FC7E0", VA = "0x7FC7E0")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x7FC7F4", Offset = "0x7FC7F4", VA = "0x7FC7F4")]
		private void ReCalcPos()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x7FC804", Offset = "0x7FC804", VA = "0x7FC804")]
		protected void CreateCostumeViewer(Transform parent)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x7FBB74", Offset = "0x7FBB74", VA = "0x7FBB74")]
		private void PointerUpdate()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x7FC91C", Offset = "0x7FC91C", VA = "0x7FC91C")]
		protected bool DecideButtonAction([Optional] Action onPressDecideAction)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x7FCA3C", Offset = "0x7FCA3C", VA = "0x7FCA3C")]
		protected bool CloseButtonAction(int closeButtonIndex, [Optional] Action onPressCloseAction)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x7FCB8C", Offset = "0x7FCB8C", VA = "0x7FCB8C")]
		protected bool LeftMoveAction([Optional] Action onPressedMoveAction)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x7FCE70", Offset = "0x7FCE70", VA = "0x7FCE70")]
		protected bool RightMoveAction([Optional] Action onPressedMoveAction)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x7FD0D8", Offset = "0x7FD0D8", VA = "0x7FD0D8")]
		protected bool RightMoveAction(int maxArrayCount)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x7FD328", Offset = "0x7FD328", VA = "0x7FD328", Slot = "16")]
		protected virtual bool UpMoveAction()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x7FD390", Offset = "0x7FD390", VA = "0x7FD390", Slot = "17")]
		protected virtual bool DownMoveAction()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x7FCDEC", Offset = "0x7FCDEC", VA = "0x7FCDEC")]
		[IteratorStateMachine(typeof(<MovedWaitCoroutine>d__53))]
		protected IEnumerator MovedWaitCoroutine(float waitTime = 0.1f)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x7FD420", Offset = "0x7FD420", VA = "0x7FD420")]
		public BaseWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class BuyIconAnimComponent : BaseCurveAnimComponent
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_default;

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x7FDDBC", Offset = "0x7FDDBC", VA = "0x7FDDBC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x7FDFBC", Offset = "0x7FDFBC", VA = "0x7FDFBC", Slot = "8")]
		protected override void Animation(float value)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x7FE064", Offset = "0x7FE064", VA = "0x7FE064")]
		public BuyIconAnimComponent()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class CostumeViewComponent : BasePreviewComponent
	{
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x7FE06C", Offset = "0x7FE06C", VA = "0x7FE06C", Slot = "6")]
		public override void Show(int typeIndex)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7FE170", Offset = "0x7FE170", VA = "0x7FE170")]
		public CostumeViewComponent()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class DebugWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x400075C")]
		private const int COMPONENT_COUNT = 3;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_transformResetButton;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_stopMovieButton;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x7FE174", Offset = "0x7FE174", VA = "0x7FE174")]
		public DebugWindowComponent()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class DeleteButtonUIComponent : BaseMenuItemComponent
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action m_onDecideAction;

		[Token(Token = "0x170000B7")]
		public bool isDeleteStart
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x7FE188", Offset = "0x7FE188", VA = "0x7FE188")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x7FE190", Offset = "0x7FE190", VA = "0x7FE190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x7FE19C", Offset = "0x7FE19C", VA = "0x7FE19C", Slot = "17")]
		protected override void OnDecide()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x7FE1C8", Offset = "0x7FE1C8", VA = "0x7FE1C8")]
		public void SetOnDecideAction(Action onDecideAction)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7FE258", Offset = "0x7FE258", VA = "0x7FE258")]
		public DeleteButtonUIComponent()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class HowToPlayWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x4000762")]
		private const int COMPONENT_COUNT = 1;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_closeButton;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x7FE260", Offset = "0x7FE260", VA = "0x7FE260", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x7FE3D8", Offset = "0x7FE3D8", VA = "0x7FE3D8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x7FE3DC", Offset = "0x7FE3DC", VA = "0x7FE3DC")]
		private void ActionClose()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x7FE3EC", Offset = "0x7FE3EC", VA = "0x7FE3EC", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x7FE404", Offset = "0x7FE404", VA = "0x7FE404", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x7FE408", Offset = "0x7FE408", VA = "0x7FE408")]
		public HowToPlayWindowComponent()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class LicenseWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x200012D")]
		private enum LicenseWindowUIState
		{
			[Token(Token = "0x400076C")]
			Close = 0,
			[Token(Token = "0x400076D")]
			ArrowUp = 1,
			[Token(Token = "0x400076E")]
			ArrowDown = 2,
			[Token(Token = "0x400076F")]
			Count = 3,
			[Token(Token = "0x4000770")]
			ButtonNum = 1
		}

		[Token(Token = "0x4000764")]
		private const int COMPONENT_COUNT = 3;

		[Token(Token = "0x4000765")]
		private const float SCROLL_BUTTON_VALUE = 1f;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_closeButton;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIArrowButtonComponent m_upButton;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIArrowButtonComponent m_downButton;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UITextComponent m_textComponent;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextScroller m_scrollText;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x7FE41C", Offset = "0x7FE41C", VA = "0x7FE41C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x7FE840", Offset = "0x7FE840", VA = "0x7FE840", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x7FE880", Offset = "0x7FE880", VA = "0x7FE880")]
		private void ActionClose()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x7FE890", Offset = "0x7FE890", VA = "0x7FE890", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x7FE8A8", Offset = "0x7FE8A8", VA = "0x7FE8A8", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7FE8DC", Offset = "0x7FE8DC", VA = "0x7FE8DC")]
		public LicenseWindowComponent()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class MovieWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000130")]
		private enum MovieWindowUIState
		{
			[Token(Token = "0x400077C")]
			Stop,
			[Token(Token = "0x400077D")]
			Exit,
			[Token(Token = "0x400077E")]
			Count
		}

		[Token(Token = "0x4000774")]
		private const int COMPONENT_COUNT = 1;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_stopButton;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIMovieSliderComponent m_movieSlider;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject m_slidehandle;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject m_silderArea;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_isSliderHit;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x7FEA1C", Offset = "0x7FEA1C", VA = "0x7FEA1C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7FEC40", Offset = "0x7FEC40", VA = "0x7FEC40", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7FECF4", Offset = "0x7FECF4", VA = "0x7FECF4")]
		private void ActionStop()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x7FED60", Offset = "0x7FED60", VA = "0x7FED60")]
		private void ActionExit()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x7FEDE4", Offset = "0x7FEDE4", VA = "0x7FEDE4", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x7FEE64", Offset = "0x7FEE64", VA = "0x7FEE64", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x7FEEEC", Offset = "0x7FEEEC", VA = "0x7FEEEC")]
		private void HitCheckSlider()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x7FEC5C", Offset = "0x7FEC5C", VA = "0x7FEC5C")]
		private void SetSliderColor(bool isHit)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x7FF1B4", Offset = "0x7FF1B4", VA = "0x7FF1B4")]
		public MovieWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class MusicGameMenuWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000132")]
		private enum ButtonActionState
		{
			[Token(Token = "0x40007A3")]
			DiffcultyEasy,
			[Token(Token = "0x40007A4")]
			DiffcultyNormal,
			[Token(Token = "0x40007A5")]
			DiffcultyHard,
			[Token(Token = "0x40007A6")]
			Speed1,
			[Token(Token = "0x40007A7")]
			Speed1_5,
			[Token(Token = "0x40007A8")]
			Speed2,
			[Token(Token = "0x40007A9")]
			Speed3,
			[Token(Token = "0x40007AA")]
			Speed4,
			[Token(Token = "0x40007AB")]
			ExitAction,
			[Token(Token = "0x40007AC")]
			StartAction,
			[Token(Token = "0x40007AD")]
			CostumeChooseLeft,
			[Token(Token = "0x40007AE")]
			CostumeChooseRight,
			[Token(Token = "0x40007AF")]
			CostumeBuy,
			[Token(Token = "0x40007B0")]
			StageChooseLeft,
			[Token(Token = "0x40007B1")]
			StageChooseRight,
			[Token(Token = "0x40007B2")]
			StageBuy,
			[Token(Token = "0x40007B3")]
			CuttingEasyChooseLeft,
			[Token(Token = "0x40007B4")]
			CuttingEasyChooseRight,
			[Token(Token = "0x40007B5")]
			RandomModeChooseLeft,
			[Token(Token = "0x40007B6")]
			RandomModeChooseRight,
			[Token(Token = "0x40007B7")]
			FixedPositionChooseLeft,
			[Token(Token = "0x40007B8")]
			FixedPositionChooseRight,
			[Token(Token = "0x40007B9")]
			ComponentCount
		}

		[Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class <ChangeSceneCoroutine>d__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MusicGameMenuWindowComponent <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x801D5C", Offset = "0x801D5C", VA = "0x801D5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x801DA4", Offset = "0x801DA4", VA = "0x801DA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x801B30", Offset = "0x801B30", VA = "0x801B30")]
			[DebuggerHidden]
			public <ChangeSceneCoroutine>d__53(int <>1__state)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x801B58", Offset = "0x801B58", VA = "0x801B58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x801B5C", Offset = "0x801B5C", VA = "0x801B5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x801D64", Offset = "0x801D64", VA = "0x801D64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077F")]
		private const int COMPONENT_COUNT = 22;

		[Token(Token = "0x4000780")]
		private const string START_VOICE_NAME = "vo_0451";

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Image m_icon;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIToggleComponent m_easyButton;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIToggleComponent m_normalButton;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIToggleComponent m_hardButton;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIToggleComponent m_speed_1Button;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIToggleComponent m_speed_1_5Button;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIToggleComponent m_speed_2Button;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIToggleComponent m_speed_3Button;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIToggleComponent m_speed_4Button;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIButtonComponent m_startButton;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private TMP_Text m_titleText;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private TMP_Text m_prodText;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private TMP_Text m_scoreText;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Image m_rank;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Image m_oldIcon;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Image m_oldModeIcon;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private LeftRightBuyGroup m_costumeGroup;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private UIButtonComponent m_costumeBuyButton;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject m_networkErrorIcon;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private TMP_Text m_costumePriceText;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private CostumeViewComponent m_costumeViewer;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private LeftRightBuyGroup m_stageGroup;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private UIButtonComponent m_stageBuyButton;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private TMP_Text m_stagePriceText;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject m_stageNetworkErrorIcon;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private StageViewComponent m_stageViewer;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private LeftRightToggleGroup m_cuttingEasyGroup;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private LeftRightToggleGroup m_randomNoteGroup;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private LeftRightToggleGroup m_fixedPositionGroup;

		[Token(Token = "0x170000B8")]
		public int Level
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x7FF1C8", Offset = "0x7FF1C8", VA = "0x7FF1C8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x7FF1D0", Offset = "0x7FF1D0", VA = "0x7FF1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float Speed
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x7FF1D8", Offset = "0x7FF1D8", VA = "0x7FF1D8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x7FF1E0", Offset = "0x7FF1E0", VA = "0x7FF1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public MusicGameParameter Param
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x7FF1E8", Offset = "0x7FF1E8", VA = "0x7FF1E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x7FF1F0", Offset = "0x7FF1F0", VA = "0x7FF1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x7FF200", Offset = "0x7FF200", VA = "0x7FF200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x8001B8", Offset = "0x8001B8", VA = "0x8001B8")]
		private void SetLevel(int level)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x800358", Offset = "0x800358", VA = "0x800358")]
		private void SetSweet(bool isSweet)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x8003C0", Offset = "0x8003C0", VA = "0x8003C0")]
		private void SetRandom(bool isUseRandom)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x800418", Offset = "0x800418", VA = "0x800418")]
		private void SetFixedPosition(bool isUseFixedPosition)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x800470", Offset = "0x800470", VA = "0x800470", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x800B90", Offset = "0x800B90", VA = "0x800B90")]
		private void ActionStart()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x800E1C", Offset = "0x800E1C", VA = "0x800E1C")]
		private void ActionBuyCostume()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x800DA8", Offset = "0x800DA8", VA = "0x800DA8")]
		[IteratorStateMachine(typeof(<ChangeSceneCoroutine>d__53))]
		private IEnumerator ChangeSceneCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x800EA8", Offset = "0x800EA8", VA = "0x800EA8")]
		private void ActionCostumeChange(bool add)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x800F98", Offset = "0x800F98", VA = "0x800F98")]
		private void ActionStageChange(bool add)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x801018", Offset = "0x801018", VA = "0x801018")]
		private void ActionBuyStage()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x8010A4", Offset = "0x8010A4", VA = "0x8010A4")]
		private void ActionCuttingEasyChange()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x8010E8", Offset = "0x8010E8", VA = "0x8010E8")]
		private void ActionRandomNoteChange()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x801128", Offset = "0x801128", VA = "0x801128")]
		private void ActionFixedPositionChange()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x801168", Offset = "0x801168", VA = "0x801168")]
		private void ActionExit()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8011FC", Offset = "0x8011FC", VA = "0x8011FC", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x8012E0", Offset = "0x8012E0", VA = "0x8012E0")]
		public void SetParameter(MusicGameParameter param)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x8001C0", Offset = "0x8001C0", VA = "0x8001C0")]
		private void ScoreUpdate()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x8015F0", Offset = "0x8015F0", VA = "0x8015F0")]
		public MusicGameMenuWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class MusicGameResultWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000135")]
		public class ResultData
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_title;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string m_prod;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int m_level;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int m_score;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int m_bestScore;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int m_maxCombo;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int m_ok;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int m_miss;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Sprite m_iconTex;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Sprite m_rankTex;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x802CB4", Offset = "0x802CB4", VA = "0x802CB4")]
			public ResultData()
			{
			}
		}

		[Token(Token = "0x2000136")]
		private enum MusicGameResultWindowUIState
		{
			[Token(Token = "0x40007DA")]
			Retry,
			[Token(Token = "0x40007DB")]
			Home,
			[Token(Token = "0x40007DC")]
			Count
		}

		[Token(Token = "0x40007BD")]
		private const int COMPONENT_COUNT = 2;

		[Token(Token = "0x40007BE")]
		private const string RETRY_VOICE_NAME = "vo_4111";

		[Token(Token = "0x40007BF")]
		private const string BACK_HOME_VOICE_NAME = "vo_4112";

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_retryButton;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_homeButton;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TMP_Text m_title;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TMP_Text m_prod;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private TMP_Text m_titleOneLine;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TMP_Text m_level;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TMP_Text m_score;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TMP_Text m_bestScore;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TMP_Text m_combo;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private TMP_Text m_ok;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TMP_Text m_miss;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Image m_icon;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Image m_rank;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Image m_oldIcon;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ResultRankAnimationComponent m_rankAnim;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x801DAC", Offset = "0x801DAC", VA = "0x801DAC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x801FD4", Offset = "0x801FD4", VA = "0x801FD4")]
		private void ActionRetry()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x802284", Offset = "0x802284", VA = "0x802284")]
		private void ActionHome()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x8023D8", Offset = "0x8023D8", VA = "0x8023D8")]
		public void SetData(ResultData data)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x802BAC", Offset = "0x802BAC", VA = "0x802BAC", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x802CAC", Offset = "0x802CAC", VA = "0x802CAC")]
		public MusicGameResultWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class NetworkErrorWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000139")]
		private enum eState
		{
			[Token(Token = "0x40007EA")]
			FADE_IN,
			[Token(Token = "0x40007EB")]
			VIEW,
			[Token(Token = "0x40007EC")]
			FADE_OUT,
			[Token(Token = "0x40007ED")]
			END
		}

		[Token(Token = "0x40007DF")]
		private const int COMPONENT_COUNT = 0;

		[Token(Token = "0x40007E0")]
		private const float FADE_TIME = 0.3f;

		[Token(Token = "0x40007E1")]
		private const float VIEW_TIME = 3f;

		[Token(Token = "0x40007E2")]
		private const float DIST_FROM_CAMERA = 1.3f;

		[Token(Token = "0x40007E3")]
		private const float MOVE_SEC = 0.5f;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private eState m_state;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float m_timer;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private InterpolatorFloat m_alphaInterpolator;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Color m_color;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image m_icon;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x802DC8", Offset = "0x802DC8", VA = "0x802DC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x802E70", Offset = "0x802E70", VA = "0x802E70", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x803224", Offset = "0x803224", VA = "0x803224", Slot = "15")]
		public override void OnClose()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x803230", Offset = "0x803230", VA = "0x803230", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x802F00", Offset = "0x802F00", VA = "0x802F00")]
		private void CalcPos(bool isForce = false)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x8033D0", Offset = "0x8033D0", VA = "0x8033D0")]
		public void CheckOpen()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x803404", Offset = "0x803404", VA = "0x803404")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x80343C", Offset = "0x80343C", VA = "0x80343C")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x803474", Offset = "0x803474", VA = "0x803474")]
		public NetworkErrorWindowComponent()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class OptionWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x200013B")]
		private enum eSoundGroupType
		{
			[Token(Token = "0x4000804")]
			Voice,
			[Token(Token = "0x4000805")]
			Se,
			[Token(Token = "0x4000806")]
			Bgm,
			[Token(Token = "0x4000807")]
			MAX
		}

		[Token(Token = "0x200013C")]
		private enum OptionWIndowUIState
		{
			[Token(Token = "0x4000809")]
			VoiceVolumeLeft = 0,
			[Token(Token = "0x400080A")]
			VoiceVolumeRight = 1,
			[Token(Token = "0x400080B")]
			SEVolumeLeft = 2,
			[Token(Token = "0x400080C")]
			SEVolumeRight = 3,
			[Token(Token = "0x400080D")]
			BGMvolumeLeft = 4,
			[Token(Token = "0x400080E")]
			BGMVolumeRight = 5,
			[Token(Token = "0x400080F")]
			UpdateLog = 6,
			[Token(Token = "0x4000810")]
			Close = 7,
			[Token(Token = "0x4000811")]
			Subtitles = 8,
			[Token(Token = "0x4000812")]
			LanguageJp = 9,
			[Token(Token = "0x4000813")]
			LanguageEn = 10,
			[Token(Token = "0x4000814")]
			LanguageTc = 11,
			[Token(Token = "0x4000815")]
			LanguageSc = 12,
			[Token(Token = "0x4000816")]
			Credit = 13,
			[Token(Token = "0x4000817")]
			License = 14,
			[Token(Token = "0x4000818")]
			Count = 15,
			[Token(Token = "0x4000819")]
			ButtonNum = 4,
			[Token(Token = "0x400081A")]
			ViewMode_ButtonNum = 4
		}

		[Token(Token = "0x40007EE")]
		private const int COMPONENT_COUNT = 15;

		[Token(Token = "0x40007EF")]
		private const int TOGGLE_START_INDEX_COUNT = 6;

		[Token(Token = "0x40007F0")]
		private const int BUTTON_NUM_IN_GROUP = 2;

		[Token(Token = "0x40007F1")]
		private const string CHANGE_LANGUAGE_VOICE_NAME = "vo_0902";

		[Token(Token = "0x40007F2")]
		public const int SE_VOLUME_MIN = 0;

		[Token(Token = "0x40007F3")]
		public const int BGM_VOLUME_MIN = 2;

		[Token(Token = "0x40007F4")]
		public const int VOICE_VOLUME_MIN = 2;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private LeftRightGroup[] m_soundGroupArray;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIToggleComponent m_subtitlesOff;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIToggleComponent m_langJp;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIToggleComponent m_langEn;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIToggleComponent m_langTc;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIToggleComponent m_langSc;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIButtonComponent m_creditButton;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIButtonComponent m_logButton;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private TMP_Text m_versionText;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIButtonComponent m_licenseButton;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool m_isUseSubtitle;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool m_isInitialize;

		[Token(Token = "0x170000BD")]
		public UIManager.eWindowType ExitToType
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x8034F0", Offset = "0x8034F0", VA = "0x8034F0")]
			[CompilerGenerated]
			get
			{
				return default(UIManager.eWindowType);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x8034F8", Offset = "0x8034F8", VA = "0x8034F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x803500", Offset = "0x803500", VA = "0x803500", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x8043A8", Offset = "0x8043A8", VA = "0x8043A8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x8043C4", Offset = "0x8043C4", VA = "0x8043C4")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x80459C", Offset = "0x80459C", VA = "0x80459C")]
		private void PlayChangeLangageVoice()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x80468C", Offset = "0x80468C", VA = "0x80468C")]
		private void ActionChangeVolume(eSoundGroupType type, bool isUp)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x8048C4", Offset = "0x8048C4", VA = "0x8048C4")]
		private void ActionLanguage(ProjectDefine.eLanguage language)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x804A64", Offset = "0x804A64", VA = "0x804A64")]
		private void ActionExit()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x804CD4", Offset = "0x804CD4", VA = "0x804CD4")]
		private void ActionCredit()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x804DA0", Offset = "0x804DA0", VA = "0x804DA0")]
		private void ActionLog()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x804F00", Offset = "0x804F00", VA = "0x804F00")]
		private void ActionLicense()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x804B0C", Offset = "0x804B0C", VA = "0x804B0C")]
		private void SetSave()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x805060", Offset = "0x805060", VA = "0x805060", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x80543C", Offset = "0x80543C", VA = "0x80543C", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x8054C0", Offset = "0x8054C0", VA = "0x8054C0")]
		public OptionWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class PauseWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000141")]
		private enum PauseWindowUIState
		{
			[Token(Token = "0x400082E")]
			Options = 0,
			[Token(Token = "0x400082F")]
			Close = 1,
			[Token(Token = "0x4000830")]
			Restart = 2,
			[Token(Token = "0x4000831")]
			Home = 3,
			[Token(Token = "0x4000832")]
			ViewMode_StageArrowLeft = 4,
			[Token(Token = "0x4000833")]
			ViewMode_StageArrowRight = 5,
			[Token(Token = "0x4000834")]
			ViewMode_HeartEffectArrowLeft = 6,
			[Token(Token = "0x4000835")]
			ViewMode_HeartEffectArrowRight = 7,
			[Token(Token = "0x4000836")]
			Count = 8,
			[Token(Token = "0x4000837")]
			ViewModeCount = 8,
			[Token(Token = "0x4000838")]
			GameModeCount = 4
		}

		[Token(Token = "0x4000821")]
		private const int COMPONENT_COUNT = 8;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_optionButton;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIButtonComponent m_returnButton;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIButtonComponent m_retryButton;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private OptionWindowComponent m_optionWindow;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject m_viewModeParent;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private LeftRightToggleGroup m_stageGroup;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private LeftRightToggleGroup m_penlightEffectGroup;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_isViewMode;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ViewMenuWindowComponent m_viewWindow;

		[Token(Token = "0x170000BE")]
		public Action OnResume
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x80598C", Offset = "0x80598C", VA = "0x80598C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x805994", Offset = "0x805994", VA = "0x805994")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x80599C", Offset = "0x80599C", VA = "0x80599C")]
		private int GetCurrentWindowUICount()
		{
			return default(int);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x8059B4", Offset = "0x8059B4", VA = "0x8059B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x806034", Offset = "0x806034", VA = "0x806034", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x806078", Offset = "0x806078", VA = "0x806078")]
		private void ActionOption()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x8060F4", Offset = "0x8060F4", VA = "0x8060F4")]
		private void ActionReturn()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x8061C0", Offset = "0x8061C0", VA = "0x8061C0")]
		private void ActionRetry()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x8063AC", Offset = "0x8063AC", VA = "0x8063AC")]
		private void ActionStageToggle(bool isEnabled)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x806438", Offset = "0x806438", VA = "0x806438")]
		private void ActionStageChange()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x806504", Offset = "0x806504", VA = "0x806504")]
		private void ActionPenlightEffectChange()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x8065C0", Offset = "0x8065C0", VA = "0x8065C0")]
		private void ActionExit()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x806668", Offset = "0x806668", VA = "0x806668", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x8067D4", Offset = "0x8067D4", VA = "0x8067D4", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x806858", Offset = "0x806858", VA = "0x806858")]
		public PauseWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class ResultRankAnimationComponent : BaseCurveAnimComponent
	{
		[Token(Token = "0x2000144")]
		private enum eOverrideState
		{
			[Token(Token = "0x4000840")]
			Wait,
			[Token(Token = "0x4000841")]
			Pop,
			[Token(Token = "0x4000842")]
			BaseState
		}

		[Token(Token = "0x400083A")]
		private const float WAIT_TIME = 2f;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private eOverrideState m_overrideState;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_defaultRotate;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_overrideTimer;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private InterpolatorVector3 m_scaleInterpolator;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8068C4", Offset = "0x8068C4", VA = "0x8068C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x806960", Offset = "0x806960", VA = "0x806960", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x806B38", Offset = "0x806B38", VA = "0x806B38", Slot = "8")]
		protected override void Animation(float value)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x802BD4", Offset = "0x802BD4", VA = "0x802BD4")]
		public void Play()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x806C04", Offset = "0x806C04", VA = "0x806C04")]
		public ResultRankAnimationComponent()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class StageViewComponent : BasePreviewComponent
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x806C80", Offset = "0x806C80", VA = "0x806C80", Slot = "6")]
		public override void Show(int typeIndex)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x806D54", Offset = "0x806D54", VA = "0x806D54")]
		public StageViewComponent()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class TextScroller
	{
		[Token(Token = "0x4000843")]
		private const float STICK_ON = 0.2f;

		[Token(Token = "0x4000844")]
		private const float SCROLL_PER_SEC = 70f;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UITextComponent m_textComponent;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UIArrowButtonComponent m_upButton;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIArrowButtonComponent m_downButton;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_scrollRate;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_textWindowSize;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_textSize;

		[Token(Token = "0x170000BF")]
		public bool IsScroll
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x806D5C", Offset = "0x806D5C", VA = "0x806D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x806D70", Offset = "0x806D70", VA = "0x806D70")]
		public void Initialize(UITextComponent textComponent, UIArrowButtonComponent upButton, UIArrowButtonComponent downButton)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x806E34", Offset = "0x806E34", VA = "0x806E34")]
		public void UpdateScroll(float value)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x806FCC", Offset = "0x806FCC", VA = "0x806FCC")]
		public void UpdateText()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x807130", Offset = "0x807130", VA = "0x807130")]
		public void UpdateStick()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x8071EC", Offset = "0x8071EC", VA = "0x8071EC")]
		public TextScroller()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class UIArrowButtonComponent : UIButtonComponent
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InputManager.eActiveHandType m_clickHandType;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Action HoldAction;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x8071F4", Offset = "0x8071F4", VA = "0x8071F4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x807354", Offset = "0x807354", VA = "0x807354", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x807424", Offset = "0x807424", VA = "0x807424", Slot = "14")]
		protected override void ChangeSelect(bool isOn)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x8075AC", Offset = "0x8075AC", VA = "0x8075AC", Slot = "13")]
		public override void OnClick(InputManager.eActiveHandType handType, [Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x807770", Offset = "0x807770", VA = "0x807770")]
		public UIArrowButtonComponent()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class UIBlinkingComponent : BaseMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000149")]
		private class ValueRange
		{
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float min;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float max;

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x807F4C", Offset = "0x807F4C", VA = "0x807F4C")]
			public ValueRange(float _min = 0f, float _max = 1f)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x807F80", Offset = "0x807F80", VA = "0x807F80")]
			public ValueRange(ValueRange value)
			{
			}
		}

		[Token(Token = "0x200014A")]
		private class UIBlinkCommon
		{
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SpriteRenderer[] m_spriteRenderers;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private InterpolatorFloat m_alphaInterpolator;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private InterpolatorFloat m_scaleInterpolator;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ValueRange m_alphaValue;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ValueRange m_blinkTimerMinValue;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ValueRange m_blinkTimerMaxValue;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ValueRange m_blinkingThickness;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float m_currentElapsedTime;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float m_fireBlinkTime;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool m_alphaMoveEnabled;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			private bool m_isMoveBirghten;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 m_defaultScale;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float m_blinkWaitValue;

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x8079F8", Offset = "0x8079F8", VA = "0x8079F8")]
			public UIBlinkCommon(SpriteRenderer[] renderer, ValueRange alpha, ValueRange blinkMinTimer, ValueRange blinkMaxTimer, ValueRange blinkingThickess)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x807C58", Offset = "0x807C58", VA = "0x807C58")]
			public bool OnUpdate()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x808140", Offset = "0x808140", VA = "0x808140")]
			private void InitilaizeAlphaInterpolator(bool isBrighten)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x807FBC", Offset = "0x807FBC", VA = "0x807FBC")]
			private void SetRenderersAlpha(float newAlpha)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x808050", Offset = "0x808050", VA = "0x808050")]
			private void SetRenderersScale(float newScale)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x80824C", Offset = "0x80824C", VA = "0x80824C")]
			private void UpdateBlinkValue()
			{
			}
		}

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpriteRenderer[] m_blinkSprites;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ValueRange m_alpha;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ValueRange m_brightMinTimer;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ValueRange m_brightMaxTimer;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ValueRange m_blinkingThickness;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<UIBlinkCommon> m_blinkCommons;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x807870", Offset = "0x807870", VA = "0x807870")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x807BA8", Offset = "0x807BA8", VA = "0x807BA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x807DA4", Offset = "0x807DA4", VA = "0x807DA4")]
		public UIBlinkingComponent()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class UIButtonComponent : BaseUIComponent
	{
		[Token(Token = "0x200014C")]
		public enum eSeType
		{
			[Token(Token = "0x400086E")]
			Default,
			[Token(Token = "0x400086F")]
			Important,
			[Token(Token = "0x4000870")]
			Cancel
		}

		[Token(Token = "0x200014D")]
		[CompilerGenerated]
		private sealed class <ClickAnimCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIButtonComponent <>4__this;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <m_timer>5__2;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x808CFC", Offset = "0x808CFC", VA = "0x808CFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x808D44", Offset = "0x808D44", VA = "0x808D44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x808700", Offset = "0x808700", VA = "0x808700")]
			[DebuggerHidden]
			public <ClickAnimCoroutine>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x808B10", Offset = "0x808B10", VA = "0x808B10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x808B14", Offset = "0x808B14", VA = "0x808B14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x808D04", Offset = "0x808D04", VA = "0x808D04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014E")]
		[CompilerGenerated]
		private sealed class <PlayAfterOneFrame>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIButtonComponent <>4__this;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string name;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x808DBC", Offset = "0x808DBC", VA = "0x808DBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x808E04", Offset = "0x808E04", VA = "0x808E04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x808878", Offset = "0x808878", VA = "0x808878")]
			[DebuggerHidden]
			public <PlayAfterOneFrame>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x808D4C", Offset = "0x808D4C", VA = "0x808D4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x808D50", Offset = "0x808D50", VA = "0x808D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x808DC4", Offset = "0x808DC4", VA = "0x808DC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private readonly Color ENABLE_COLOR;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private readonly Color DISABLE_COLOR;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AnimationCurve m_clickAnimCurve;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 m_localBaseScale;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine m_clickAnimCoroutine;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Image m_image;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UITextComponent m_textComponent;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected bool m_isOn;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		[SerializeField]
		private bool m_isPlaySE;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private eSeType m_seType;

		[Token(Token = "0x170000C0")]
		protected Image ButtonImage
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x8072AC", Offset = "0x8072AC", VA = "0x8072AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public UITextComponent TextComponent
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x807504", Offset = "0x807504", VA = "0x807504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public List<InputManager.eActiveHandType> ThisFrameOnList
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x808290", Offset = "0x808290", VA = "0x808290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x808298", Offset = "0x808298", VA = "0x808298")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8082A0", Offset = "0x8082A0", VA = "0x8082A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8082E0", Offset = "0x8082E0", VA = "0x8082E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x8083D8", Offset = "0x8083D8", VA = "0x8083D8", Slot = "8")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x80842C", Offset = "0x80842C", VA = "0x80842C")]
		public void SetButtonEnable(bool isEnable)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x80858C", Offset = "0x80858C", VA = "0x80858C", Slot = "11")]
		public override void OnEnterPointer()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x808664", Offset = "0x808664", VA = "0x808664", Slot = "12")]
		public override void OnExitPointer()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x808678", Offset = "0x808678", VA = "0x808678", Slot = "9")]
		public override void OnEnableAnim()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x8075D0", Offset = "0x8075D0", VA = "0x8075D0", Slot = "13")]
		public override void OnClick(InputManager.eActiveHandType handType, [Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x80868C", Offset = "0x80868C", VA = "0x80868C")]
		[IteratorStateMachine(typeof(<ClickAnimCoroutine>d__27))]
		private IEnumerator ClickAnimCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x808728", Offset = "0x808728", VA = "0x808728", Slot = "14")]
		protected virtual void ChangeSelect(bool isOn)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x8084FC", Offset = "0x8084FC", VA = "0x8084FC")]
		[IteratorStateMachine(typeof(<PlayAfterOneFrame>d__29))]
		private IEnumerator PlayAfterOneFrame(string name)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8088A0", Offset = "0x8088A0", VA = "0x8088A0")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x8077CC", Offset = "0x8077CC", VA = "0x8077CC")]
		public UIButtonComponent()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class UIDescriptionTextComponent : UITextComponent
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected int m_textIndex;

		[Token(Token = "0x170000C7")]
		public int TextIndex
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x808E0C", Offset = "0x808E0C", VA = "0x808E0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x808E14", Offset = "0x808E14", VA = "0x808E14")]
			set
			{
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x808E34", Offset = "0x808E34", VA = "0x808E34", Slot = "6")]
		public override void UpdateText()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x808F24", Offset = "0x808F24", VA = "0x808F24")]
		public UIDescriptionTextComponent()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class UIImageButtonComponent : UIButtonComponent
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string m_onTexName;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string m_offTexName;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image m_frame;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string m_onFrameTexName;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string m_offFrameTexName;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x808F80", Offset = "0x808F80", VA = "0x808F80", Slot = "11")]
		public override void OnEnterPointer()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x809058", Offset = "0x809058", VA = "0x809058", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x809180", Offset = "0x809180", VA = "0x809180", Slot = "14")]
		protected override void ChangeSelect(bool isOn)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x80931C", Offset = "0x80931C", VA = "0x80931C")]
		public UIImageButtonComponent()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class UIManager : SingletonMonoBehaviour<UIManager>
	{
		[Token(Token = "0x2000152")]
		public enum eWindowType
		{
			[Token(Token = "0x4000898")]
			Option,
			[Token(Token = "0x4000899")]
			Movie,
			[Token(Token = "0x400089A")]
			Pause,
			[Token(Token = "0x400089B")]
			YesNo,
			[Token(Token = "0x400089C")]
			MusicGameMenu,
			[Token(Token = "0x400089D")]
			Result,
			[Token(Token = "0x400089E")]
			NetworkError,
			[Token(Token = "0x400089F")]
			ViewMenu,
			[Token(Token = "0x40008A0")]
			UpdateDescription,
			[Token(Token = "0x40008A1")]
			License,
			[Token(Token = "0x40008A2")]
			HowTo
		}

		[Token(Token = "0x2000153")]
		public enum eUsePlayType
		{
			[Token(Token = "0x40008A4")]
			Everything,
			[Token(Token = "0x40008A5")]
			VRModeOnly
		}

		[Token(Token = "0x400087F")]
		private const string POINTER_PREFAB = "UIPointer";

		[Token(Token = "0x4000880")]
		private const string SUBTITLE_PREFAB = "Subtitle";

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] WINDOW_UI_PATH_ARRAY;

		[Token(Token = "0x4000882")]
		private const string BUTTON_OFF_TEXTURE_NAME = "IngameSquareButton_Line";

		[Token(Token = "0x4000883")]
		private const string BUTTON_ON_TEXTURE_NAME = "IngameSquareButton_WhitePink";

		[Token(Token = "0x4000884")]
		private const string TOGGLE_ON_TEXTURE_NAME = "IngameButton_WhitePink";

		[Token(Token = "0x4000885")]
		private const string TOGGLE_OVER_TEXTURE_NAME = "IngameButton_Toggle";

		[Token(Token = "0x4000886")]
		private const string TOGGLE_OFF_TEXTURE_NAME = "IngameButton_Line";

		[Token(Token = "0x4000887")]
		private const string ARROW_ON_TEXTURE_NAME = "TriangleButton_ON_E";

		[Token(Token = "0x4000888")]
		private const string ARROW_OFF_TEXTURE_NAME = "TriangleButton_E";

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<BaseWindowComponent> m_windowList;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<UIPointerComponent> m_uiPointerList_VR;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SubtitleComponent m_subtitle;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UiMovieLoadingComponent m_loadingIcon;

		[Token(Token = "0x170000C8")]
		public UITextController TextController
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x809370", Offset = "0x809370", VA = "0x809370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x809378", Offset = "0x809378", VA = "0x809378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public List<UIPointerComponent> UiPointerList
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x809380", Offset = "0x809380", VA = "0x809380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public Sprite ButtonOnTex
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x809388", Offset = "0x809388", VA = "0x809388")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x809390", Offset = "0x809390", VA = "0x809390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public Sprite ButtonOffTex
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x809398", Offset = "0x809398", VA = "0x809398")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x8093A0", Offset = "0x8093A0", VA = "0x8093A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Sprite ToggleOnTex
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x8093A8", Offset = "0x8093A8", VA = "0x8093A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x8093B0", Offset = "0x8093B0", VA = "0x8093B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public Sprite ToggleOverTex
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x8093B8", Offset = "0x8093B8", VA = "0x8093B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x8093C0", Offset = "0x8093C0", VA = "0x8093C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public Sprite ToggleOffTex
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x8093C8", Offset = "0x8093C8", VA = "0x8093C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x8093D0", Offset = "0x8093D0", VA = "0x8093D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public Sprite ArrowOnTex
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x8093D8", Offset = "0x8093D8", VA = "0x8093D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x8093E0", Offset = "0x8093E0", VA = "0x8093E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public Sprite ArrowOffTex
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x8093E8", Offset = "0x8093E8", VA = "0x8093E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x8093F0", Offset = "0x8093F0", VA = "0x8093F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Material ButtonOnTextMat
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x8093F8", Offset = "0x8093F8", VA = "0x8093F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x809400", Offset = "0x809400", VA = "0x809400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool IsOpenAnything
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x809408", Offset = "0x809408", VA = "0x809408")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x809410", Offset = "0x809410", VA = "0x809410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x80941C", Offset = "0x80941C", VA = "0x80941C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x809A34", Offset = "0x809A34", VA = "0x809A34")]
		public void InitializeLoad()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x809B28", Offset = "0x809B28", VA = "0x809B28")]
		public void AddWindowList(BaseWindowComponent component)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x809C10", Offset = "0x809C10", VA = "0x809C10")]
		public void RemoveWindowList(BaseWindowComponent component)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x809814", Offset = "0x809814", VA = "0x809814")]
		private void CreateWindow()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x809CA8", Offset = "0x809CA8", VA = "0x809CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x809EE8", Offset = "0x809EE8", VA = "0x809EE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x804BE0", Offset = "0x804BE0", VA = "0x804BE0")]
		public void OpenWindow(eWindowType type)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x809F98", Offset = "0x809F98", VA = "0x809F98")]
		public void CloseWindow(eWindowType type)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x80A080", Offset = "0x80A080", VA = "0x80A080")]
		public bool IsOpenWindow(eWindowType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		public T GetWindow<T>(eWindowType type, eUsePlayType usePlayType = eUsePlayType.Everything) where T : BaseWindowComponent
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x80A14C", Offset = "0x80A14C", VA = "0x80A14C")]
		public void SetSubtitleText(string text, float time)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x80A1AC", Offset = "0x80A1AC", VA = "0x80A1AC")]
		public void SetSubtitleText(string text, [Optional] AudioSource source)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x80A200", Offset = "0x80A200", VA = "0x80A200")]
		public void SetSubtitleTextId(string textId, float time)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8021DC", Offset = "0x8021DC", VA = "0x8021DC")]
		public void SetSubtitleTextId(string textId, [Optional] AudioSource source)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x80A2A8", Offset = "0x80A2A8", VA = "0x80A2A8")]
		public void SetSubtitleView(bool isEnable)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x80A2C0", Offset = "0x80A2C0", VA = "0x80A2C0")]
		public void ShowMessage(string msg, Action onYes, Action onNo)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x80A454", Offset = "0x80A454", VA = "0x80A454")]
		public void ShowMessage(string msg, Action onClose)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x80A5C4", Offset = "0x80A5C4", VA = "0x80A5C4")]
		public void ShowMessageId(string textId, Action onYes, Action onNo)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x80A650", Offset = "0x80A650", VA = "0x80A650")]
		public void ShowMessageId(string textId, Action onClose)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x80A6CC", Offset = "0x80A6CC", VA = "0x80A6CC")]
		public void StartLoading()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x80A92C", Offset = "0x80A92C", VA = "0x80A92C")]
		public void EndLoading()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x80A958", Offset = "0x80A958", VA = "0x80A958")]
		public void CreateUIPointer(ControllerComponent controller)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x80AAB0", Offset = "0x80AAB0", VA = "0x80AAB0")]
		public void SetIsOpen(bool isOpen)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x80AABC", Offset = "0x80AABC", VA = "0x80AABC")]
		public void SetButtonOnlyInput(bool isButtonOnly)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x80AAC0", Offset = "0x80AAC0", VA = "0x80AAC0")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class UiMovieLoadingComponent : MonoBehaviour
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RawImage m_LoadingImage;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_rotateValue;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_defaultRotateAngle;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_currentVanishTime;

		[Token(Token = "0x40008B5")]
		private const float VANISH_TIME = 1f;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double m_oldClockTime;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action m_loadingEndedAction;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_endedLoading;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x80B9CC", Offset = "0x80B9CC", VA = "0x80B9CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x80BBB0", Offset = "0x80BBB0", VA = "0x80BBB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x80B500", Offset = "0x80B500", VA = "0x80B500")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x80A6E8", Offset = "0x80A6E8", VA = "0x80A6E8")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x80BCD0", Offset = "0x80BCD0", VA = "0x80BCD0")]
		public void SetActive(bool isActive, double currentClockTime)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x80BCDC", Offset = "0x80BCDC", VA = "0x80BCDC")]
		public void LoadingAction(Action endAction)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x80A94C", Offset = "0x80A94C", VA = "0x80A94C")]
		public void LoadingEndedAction()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x80ACB0", Offset = "0x80ACB0", VA = "0x80ACB0")]
		public UiMovieLoadingComponent()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class UIMovieSliderComponent : UIButtonComponent
	{
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Slider m_UISlider;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_rayHitPosition;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 m_rayHitInitPosition;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Image m_knobObject;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Sprite m_activeButtonImage;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Sprite m_deactiveButtonImage;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private BoxCollider m_sliderCollider;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool m_isDrawActive;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float m_currentSliderValue;

		[Token(Token = "0x170000D3")]
		public Vector3 rayHitPosition
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x80BCE4", Offset = "0x80BCE4", VA = "0x80BCE4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x80BCF0", Offset = "0x80BCF0", VA = "0x80BCF0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool DragActive
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x80BE2C", Offset = "0x80BE2C", VA = "0x80BE2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x80BE34", Offset = "0x80BE34", VA = "0x80BE34")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public Slider slider
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x80BD58", Offset = "0x80BD58", VA = "0x80BD58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x80BF80", Offset = "0x80BF80", VA = "0x80BF80")]
			private set
			{
			}
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x80BF88", Offset = "0x80BF88", VA = "0x80BF88", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x80C040", Offset = "0x80C040", VA = "0x80C040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x80C13C", Offset = "0x80C13C", VA = "0x80C13C")]
		public void OnSlide()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x80C140", Offset = "0x80C140", VA = "0x80C140")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x80C144", Offset = "0x80C144", VA = "0x80C144")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x80C148", Offset = "0x80C148", VA = "0x80C148")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x80C14C", Offset = "0x80C14C", VA = "0x80C14C", Slot = "15")]
		public virtual void OnOpen()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x80C278", Offset = "0x80C278", VA = "0x80C278", Slot = "16")]
		public virtual void OnClose()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x80C27C", Offset = "0x80C27C", VA = "0x80C27C")]
		public void SetRayData(RaycastController.RayData rayData, InputManager.eActiveHandType handType)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x80C698", Offset = "0x80C698", VA = "0x80C698")]
		private void SetDragActive(InputManager.eActiveHandType handType)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x80C6EC", Offset = "0x80C6EC", VA = "0x80C6EC")]
		public void SetHandleIcon(bool IsActive)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x80C798", Offset = "0x80C798", VA = "0x80C798")]
		public UIMovieSliderComponent()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class UIPointerComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpriteRenderer m_sprite;

		[Token(Token = "0x170000D6")]
		public RaycastController RayController
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x80C840", Offset = "0x80C840", VA = "0x80C840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x80C848", Offset = "0x80C848", VA = "0x80C848")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public InputManager.eActiveHandType HandType
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x80C850", Offset = "0x80C850", VA = "0x80C850")]
			[CompilerGenerated]
			get
			{
				return default(InputManager.eActiveHandType);
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x80C858", Offset = "0x80C858", VA = "0x80C858")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool IsUsed
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x80C860", Offset = "0x80C860", VA = "0x80C860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D9")]
		public Vector3 TargetPoint
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x80C8E8", Offset = "0x80C8E8", VA = "0x80C8E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x80C910", Offset = "0x80C910", VA = "0x80C910", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x809E28", Offset = "0x809E28", VA = "0x809E28")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x809F7C", Offset = "0x809F7C", VA = "0x809F7C")]
		public void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x809E08", Offset = "0x809E08", VA = "0x809E08")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x80B8D4", Offset = "0x80B8D4", VA = "0x80B8D4")]
		public void SetHand(ControllerComponent controller)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x80C968", Offset = "0x80C968", VA = "0x80C968")]
		public UIPointerComponent()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class UISliderFillAreaComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider m_Handle;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIMovieSliderComponent m_sliderComponent;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform m_FillAreaRect;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform m_BackGroundRect;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x80C9DC", Offset = "0x80C9DC", VA = "0x80C9DC")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x80CA6C", Offset = "0x80CA6C", VA = "0x80CA6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x80CB20", Offset = "0x80CB20", VA = "0x80CB20")]
		public UISliderFillAreaComponent()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class UITextComponent : MonoBehaviour
	{
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string m_textId;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("言語固定にするか")]
		[SerializeField]
		protected bool m_isForceLanguage;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Header("固定にする言語")]
		protected ProjectDefine.eLanguage m_forceLanguage;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_text;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material m_defaultMat;

		[Token(Token = "0x170000DA")]
		public string TextId
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x80CB28", Offset = "0x80CB28", VA = "0x80CB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x80CB30", Offset = "0x80CB30", VA = "0x80CB30")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public TMP_Text Text
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x807088", Offset = "0x807088", VA = "0x807088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x80CB88", Offset = "0x80CB88", VA = "0x80CB88", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x80CD08", Offset = "0x80CD08", VA = "0x80CD08", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x80CE50", Offset = "0x80CE50", VA = "0x80CE50", Slot = "6")]
		public virtual void UpdateText()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x80CF50", Offset = "0x80CF50", VA = "0x80CF50", Slot = "7")]
		public virtual void SetFontMaterial([Optional] Material mat)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x808F28", Offset = "0x808F28", VA = "0x808F28")]
		public UITextComponent()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class UITextController
	{
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<UITextComponent> m_list;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x80CC20", Offset = "0x80CC20", VA = "0x80CC20")]
		public void Add(UITextComponent component)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x80CDC0", Offset = "0x80CDC0", VA = "0x80CDC0")]
		public void Remove(UITextComponent component)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x8049B8", Offset = "0x8049B8", VA = "0x8049B8")]
		public void UpdateAllText()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x80AC28", Offset = "0x80AC28", VA = "0x80AC28")]
		public UITextController()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class UITextsComponent : UITextComponent
	{
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] m_textIds;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x80D048", Offset = "0x80D048", VA = "0x80D048", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x80D04C", Offset = "0x80D04C", VA = "0x80D04C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x80D050", Offset = "0x80D050", VA = "0x80D050", Slot = "6")]
		public override void UpdateText()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x80D2C4", Offset = "0x80D2C4", VA = "0x80D2C4")]
		private string GetUIMessage(string id)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x80D340", Offset = "0x80D340", VA = "0x80D340", Slot = "7")]
		public override void SetFontMaterial([Optional] Material mat)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x80D344", Offset = "0x80D344", VA = "0x80D344")]
		public UITextsComponent()
		{
		}
	}
	[Token(Token = "0x2000161")]
	[RequireComponent(typeof(TMP_Text))]
	public class UITitleTextScrollComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40008D0")]
		private const float TO_MOVING_WAITING_TIME = 1f;

		[Token(Token = "0x40008D1")]
		private const float TEXT_MOVE_SPEED = 8f;

		[Token(Token = "0x40008D2")]
		private const float RESET_TEXT_POSITION_OFFSET = 6f;

		[Token(Token = "0x40008D3")]
		private const float DEFAULT_NON_SCROLL_POSX = 1f;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_textTransform;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TMP_Text m_titleText;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_initialPosition;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_elapsedTime;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_textWidth;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_canvasWidth;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_useScroll;

		[Token(Token = "0x170000DC")]
		protected TMP_Text titleText
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x80D418", Offset = "0x80D418", VA = "0x80D418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		protected Transform textTransform
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x80D4C0", Offset = "0x80D4C0", VA = "0x80D4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x80D568", Offset = "0x80D568", VA = "0x80D568")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x80D594", Offset = "0x80D594", VA = "0x80D594")]
		private void Update()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x80D6E8", Offset = "0x80D6E8", VA = "0x80D6E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x802A00", Offset = "0x802A00", VA = "0x802A00")]
		public void UseScroll(float textWidth, float canvasWidth, float drawOffset = 0f, float canvasCenterPos = 0f)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x80D77C", Offset = "0x80D77C", VA = "0x80D77C")]
		public UITitleTextScrollComponent()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class UIToggleComponent : UIButtonComponent
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_isOnToggle;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Action OnEnableToggle;

		[Token(Token = "0x170000DE")]
		public bool IsOnToggle
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x80D784", Offset = "0x80D784", VA = "0x80D784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x80D78C", Offset = "0x80D78C", VA = "0x80D78C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x80D844", Offset = "0x80D844", VA = "0x80D844", Slot = "14")]
		protected override void ChangeSelect(bool isOn)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x80D92C", Offset = "0x80D92C", VA = "0x80D92C", Slot = "13")]
		public override void OnClick(InputManager.eActiveHandType handType, [Optional] Action onEndCallback)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x805324", Offset = "0x805324", VA = "0x805324")]
		public void ChangeToggle(bool isOn, bool isOver = false)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x80D94C", Offset = "0x80D94C", VA = "0x80D94C")]
		public UIToggleComponent()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class UpdateDescriptionWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000164")]
		private enum UpdateDescriptionUIState
		{
			[Token(Token = "0x40008EA")]
			Before = 0,
			[Token(Token = "0x40008EB")]
			Close = 1,
			[Token(Token = "0x40008EC")]
			Next = 2,
			[Token(Token = "0x40008ED")]
			ArrowUp = 3,
			[Token(Token = "0x40008EE")]
			ArrowDown = 4,
			[Token(Token = "0x40008EF")]
			Count = 5,
			[Token(Token = "0x40008F0")]
			ButtonNum = 3
		}

		[Token(Token = "0x40008DD")]
		private const float SCROLL_BUTTON_VALUE = 1f;

		[Token(Token = "0x40008DE")]
		private const float UPDATE_DESCRIPTION_UI_DISTANCE = 0.72f;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_beforeButton;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_nextButton;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIButtonComponent m_closeButton;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TMP_Text m_versionText;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIDescriptionTextComponent m_descriptionText;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIArrowButtonComponent m_upButton;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIArrowButtonComponent m_downButton;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextScroller m_scrollText;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int m_descriptionCount;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int m_currentIndex;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x80D9A0", Offset = "0x80D9A0", VA = "0x80D9A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x80DF20", Offset = "0x80DF20", VA = "0x80DF20", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x80E104", Offset = "0x80E104", VA = "0x80E104")]
		private void ActionBefore()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x80E15C", Offset = "0x80E15C", VA = "0x80E15C")]
		private void ActionNext()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x80E1C4", Offset = "0x80E1C4", VA = "0x80E1C4")]
		private void ActionClose()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x80E1D4", Offset = "0x80E1D4", VA = "0x80E1D4", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x80DFA4", Offset = "0x80DFA4", VA = "0x80DFA4")]
		private void SetDescription(int index)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x80E230", Offset = "0x80E230", VA = "0x80E230", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x80E264", Offset = "0x80E264", VA = "0x80E264")]
		public UpdateDescriptionWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class ViewMenuWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x2000167")]
		protected enum ViewMenuWindowUIState
		{
			[Token(Token = "0x400090B")]
			CostumeArrowLeft,
			[Token(Token = "0x400090C")]
			CostumeArrowRight,
			[Token(Token = "0x400090D")]
			CostumeBuyButton,
			[Token(Token = "0x400090E")]
			SceneArrowLeft,
			[Token(Token = "0x400090F")]
			SceneArrowRight,
			[Token(Token = "0x4000910")]
			SceneBuyButton,
			[Token(Token = "0x4000911")]
			Cancel,
			[Token(Token = "0x4000912")]
			Start,
			[Token(Token = "0x4000913")]
			StageLeftButton,
			[Token(Token = "0x4000914")]
			StageRightButton,
			[Token(Token = "0x4000915")]
			HeartEffectArrowLeft,
			[Token(Token = "0x4000916")]
			HeartEffectArrowRight,
			[Token(Token = "0x4000917")]
			Count
		}

		[Token(Token = "0x2000168")]
		[CompilerGenerated]
		private sealed class <ChangeSceneCoroutine>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ViewMenuWindowComponent <>4__this;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x80FE00", Offset = "0x80FE00", VA = "0x80FE00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x80FE48", Offset = "0x80FE48", VA = "0x80FE48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x80F4B8", Offset = "0x80F4B8", VA = "0x80F4B8")]
			[DebuggerHidden]
			public <ChangeSceneCoroutine>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x80FBA4", Offset = "0x80FBA4", VA = "0x80FBA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x80FBA8", Offset = "0x80FBA8", VA = "0x80FBA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x80FE08", Offset = "0x80FE08", VA = "0x80FE08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008F4")]
		private const int COMPONENT_COUNT = 12;

		[Token(Token = "0x40008F5")]
		private const string START_VOICE_NAME = "vo_0451";

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonComponent m_startButton;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonComponent m_exitButton;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TMP_Text m_titleText;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TMP_Text m_prodText;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image m_icon;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private LeftRightBuyGroup m_costumeGroup;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButtonComponent m_costumeBuyButton;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject m_costumeNetworkErrorIcon;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TMP_Text m_costumePriceText;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CostumeViewComponent m_costumeViewer;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private LeftRightBuyGroup m_stageGroup;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private UIButtonComponent m_stageBuyButton;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private TMP_Text m_stagePriceText;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject m_stageNetworkErrorIcon;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private StageViewComponent m_stageViewer;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private LeftRightToggleGroup m_viewStageGroup;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private LeftRightToggleGroup m_penlightEffectGroup;

		[Token(Token = "0x170000DF")]
		public MusicGameParameter Param
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x80E398", Offset = "0x80E398", VA = "0x80E398")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x80E3A0", Offset = "0x80E3A0", VA = "0x80E3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool IsLookAtMe
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x80E3B0", Offset = "0x80E3B0", VA = "0x80E3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x80E3B8", Offset = "0x80E3B8", VA = "0x80E3B8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public bool IsStage
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x80E3C4", Offset = "0x80E3C4", VA = "0x80E3C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x80E3CC", Offset = "0x80E3CC", VA = "0x80E3CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x80E3D8", Offset = "0x80E3D8", VA = "0x80E3D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x80ECD8", Offset = "0x80ECD8", VA = "0x80ECD8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x80F160", Offset = "0x80F160", VA = "0x80F160")]
		protected void ChangeStageView()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x80F1A4", Offset = "0x80F1A4", VA = "0x80F1A4")]
		protected void ChangePenlightEffect()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x80F22C", Offset = "0x80F22C", VA = "0x80F22C")]
		protected void ActionStart()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x80F444", Offset = "0x80F444", VA = "0x80F444")]
		[IteratorStateMachine(typeof(<ChangeSceneCoroutine>d__37))]
		private IEnumerator ChangeSceneCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x80F4E0", Offset = "0x80F4E0", VA = "0x80F4E0")]
		protected void ActionCostumeChange(bool add)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x80F5C0", Offset = "0x80F5C0", VA = "0x80F5C0")]
		protected void ActionBuyCostume()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x80F650", Offset = "0x80F650", VA = "0x80F650")]
		protected void ActionStageChange(bool add)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x80F6C0", Offset = "0x80F6C0", VA = "0x80F6C0")]
		protected void ActionBuyStage()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x80F750", Offset = "0x80F750", VA = "0x80F750")]
		protected void ActionExit()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x80F7EC", Offset = "0x80F7EC", VA = "0x80F7EC", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x80F8C4", Offset = "0x80F8C4", VA = "0x80F8C4")]
		public void SetParameter(MusicGameParameter param)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x80FB7C", Offset = "0x80FB7C", VA = "0x80FB7C")]
		public ViewMenuWindowComponent()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class YesNoWindowComponent : BaseWindowComponent
	{
		[Token(Token = "0x200016A")]
		private enum YesNoWindowUIState
		{
			[Token(Token = "0x4000929")]
			Yes,
			[Token(Token = "0x400092A")]
			No,
			[Token(Token = "0x400092B")]
			Close,
			[Token(Token = "0x400092C")]
			Count
		}

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject m_buttonParent;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject m_iconParent;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject m_iconDecideParentOnly;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIButtonComponent m_yesButton;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIButtonComponent m_noButton;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIButtonComponent m_closeButton;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TMP_Text m_text;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Image m_iconImageL;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Image m_iconImageR;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image m_iconDecideImageL;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Image m_iconDecideImageR;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Action m_yesAction;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Action m_noAction;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x80FE50", Offset = "0x80FE50", VA = "0x80FE50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x810260", Offset = "0x810260", VA = "0x810260")]
		private void ActionYes()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x81029C", Offset = "0x81029C", VA = "0x81029C")]
		private void ActionNo()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x8102D8", Offset = "0x8102D8", VA = "0x8102D8")]
		private void ActionClose()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x810314", Offset = "0x810314", VA = "0x810314", Slot = "14")]
		public override void OnOpen()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x80A35C", Offset = "0x80A35C", VA = "0x80A35C")]
		public void Set(string text, Action yesAction, Action noAction)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x80A4E0", Offset = "0x80A4E0", VA = "0x80A4E0")]
		public void Set(string text, Action closeAction)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x810334", Offset = "0x810334", VA = "0x810334")]
		public YesNoWindowComponent()
		{
		}
	}
}
namespace Game.SpecialNote
{
	[Token(Token = "0x200016B")]
	public class BaseSpecialNotesData
	{
		[Token(Token = "0x200016C")]
		public enum eJudgeType
		{
			[Token(Token = "0x4000932")]
			Start,
			[Token(Token = "0x4000933")]
			CenterUnique,
			[Token(Token = "0x4000934")]
			End
		}

		[Token(Token = "0x170000E4")]
		public eJudgeType[] JudgeArray
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x81033C", Offset = "0x81033C", VA = "0x81033C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x810344", Offset = "0x810344", VA = "0x810344")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public int[] CheckIndexArray
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x81034C", Offset = "0x81034C", VA = "0x81034C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x810354", Offset = "0x810354", VA = "0x810354")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public float[] CheckTimingArray
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x81035C", Offset = "0x81035C", VA = "0x81035C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x810364", Offset = "0x810364", VA = "0x810364")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public BaseNotesComponent.eNoteType Type
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x81036C", Offset = "0x81036C", VA = "0x81036C")]
			[CompilerGenerated]
			get
			{
				return default(BaseNotesComponent.eNoteType);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x810374", Offset = "0x810374", VA = "0x810374")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x81037C", Offset = "0x81037C", VA = "0x81037C")]
		public BaseSpecialNotesData()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class OADData : BaseSpecialNotesData
	{
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x810384", Offset = "0x810384", VA = "0x810384")]
		public OADData()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class SwingData : BaseSpecialNotesData
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8104D0", Offset = "0x8104D0", VA = "0x8104D0")]
		public SwingData()
		{
		}
	}
}
namespace Game.MiniChara
{
	[Token(Token = "0x200016F")]
	public class BaseState
	{
		[Token(Token = "0x4000935")]
		protected const float SQR_REACHED_TO_PLAYER_DIST = 0.64000005f;

		[Token(Token = "0x4000936")]
		protected const float MOVE_SPEED = 0.8f;

		[Token(Token = "0x4000937")]
		private const float GRAB_TIME = 0.9f;

		[Token(Token = "0x4000938")]
		private const float GRAB_RAY_HIGHT = 0.2f;

		[Token(Token = "0x4000939")]
		private const float GRAB_RAY_SIZE = 0.1f;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float RELEASE_COS;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly float JUMP_COS;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected MiniCharaState m_state;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PenLightComponent[] m_penlightArray;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RaycastHit[] m_penlightHitArray;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_grabTimer;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x8105F0", Offset = "0x8105F0", VA = "0x8105F0")]
		public BaseState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x81079C", Offset = "0x81079C", VA = "0x81079C", Slot = "4")]
		public virtual void OnExit()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8107A0", Offset = "0x8107A0", VA = "0x8107A0", Slot = "5")]
		public virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x8107E4", Offset = "0x8107E4", VA = "0x8107E4", Slot = "6")]
		protected virtual void LookUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x8107E8", Offset = "0x8107E8", VA = "0x8107E8", Slot = "7")]
		protected virtual void MoveUpdate()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x8107EC", Offset = "0x8107EC", VA = "0x8107EC", Slot = "8")]
		public virtual void OnTriggerEnter(Collider coll)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8107F0", Offset = "0x8107F0", VA = "0x8107F0")]
		protected bool MoveToPoint(Vector3 point, float sqrReachedDist)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x810964", Offset = "0x810964", VA = "0x810964")]
		protected void CheckGrabPenlight()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x811040", Offset = "0x811040", VA = "0x811040")]
		protected bool CheckReleasePenlight(Transform target)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000170")]
	public class WaitState : BaseState
	{
		[Token(Token = "0x4000940")]
		private const float SQR_INSIDE_RATE = 0.040000003f;

		[Token(Token = "0x4000941")]
		private const float LOOK_TIME = 3f;

		[Token(Token = "0x4000942")]
		private const float CHANGE_TIME_MIN = 5f;

		[Token(Token = "0x4000943")]
		private const float CHANGE_TIME_MAX = 10f;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_timer;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x8110F0", Offset = "0x8110F0", VA = "0x8110F0")]
		public WaitState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x811194", Offset = "0x811194", VA = "0x811194", Slot = "6")]
		protected override void LookUpdate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x811414", Offset = "0x811414", VA = "0x811414", Slot = "5")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x81142C", Offset = "0x81142C", VA = "0x81142C", Slot = "7")]
		protected override void MoveUpdate()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class WalkState : BaseState
	{
		[Token(Token = "0x4000945")]
		private const float SQR_REACHED_DIST = 0.09f;

		[Token(Token = "0x4000946")]
		private const float CHANGE_TIME = 7f;

		[Token(Token = "0x4000947")]
		private const float NOT_FALLDOWN_TIME = 2f;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_beforePointIndex;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_toPointIndex;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3? m_toPoint;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_timer;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_fallDownSafeTimer;

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x811480", Offset = "0x811480", VA = "0x811480")]
		public WalkState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x81150C", Offset = "0x81150C", VA = "0x81150C")]
		public void ChangePoint()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x811600", Offset = "0x811600", VA = "0x811600", Slot = "5")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x8116B8", Offset = "0x8116B8", VA = "0x8116B8", Slot = "8")]
		public override void OnTriggerEnter(Collider coll)
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class FallDownState : BaseState
	{
		[Token(Token = "0x400094D")]
		private const float DOWN_MIN = 1f;

		[Token(Token = "0x400094E")]
		private const float DOWN_MAX = 4f;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float timer;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InterpolatorFloat m_slideInterpolator;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x8116EC", Offset = "0x8116EC", VA = "0x8116EC")]
		public FallDownState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x811808", Offset = "0x811808", VA = "0x811808", Slot = "5")]
		public override void OnUpdate()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class ComeCloseState : BaseState
	{
		[Token(Token = "0x4000951")]
		private const int CHEER_RATE = 30;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x811A18", Offset = "0x811A18", VA = "0x811A18")]
		public ComeCloseState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x811AA4", Offset = "0x811AA4", VA = "0x811AA4", Slot = "5")]
		public override void OnUpdate()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class DangleState : BaseState
	{
		[Token(Token = "0x2000175")]
		private enum eInnerState
		{
			[Token(Token = "0x4000964")]
			Jump,
			[Token(Token = "0x4000965")]
			Dangling,
			[Token(Token = "0x4000966")]
			Release,
			[Token(Token = "0x4000967")]
			Standup
		}

		[Token(Token = "0x4000952")]
		private const float GRAVITY = 9.8f;

		[Token(Token = "0x4000953")]
		private const float KEEP_RATE = 0.99f;

		[Token(Token = "0x4000954")]
		private const float GRAB_DIST = 0.2f;

		[Token(Token = "0x4000955")]
		private const float SQR_GRABING_OK_DIST = 0.0001f;

		[Token(Token = "0x4000956")]
		private const float PULL_RATE = 1f;

		[Token(Token = "0x4000957")]
		private const float BOUND_RATE = 0.6f;

		[Token(Token = "0x4000958")]
		private const float SQR_LANDING_Y = 0.010000001f;

		[Token(Token = "0x4000959")]
		private const float JUMP_ADD_HIGHT = 0.05f;

		[Token(Token = "0x400095A")]
		private const float RELEASE_FALLDOWN_Y = 0.1f;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private eInnerState m_innderState;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_moveVec;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_beforeTargetPos;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 m_beforeTargetUp;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InterpolatorFloat m_rotationInterpolator;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion m_from;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_to;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_isFalldown;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x811B88", Offset = "0x811B88", VA = "0x811B88")]
		public DangleState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x8121A8", Offset = "0x8121A8", VA = "0x8121A8", Slot = "4")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x8121D0", Offset = "0x8121D0", VA = "0x8121D0", Slot = "5")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x812410", Offset = "0x812410", VA = "0x812410")]
		private void UpdateJump()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x812614", Offset = "0x812614", VA = "0x812614")]
		private void UpdateDangling()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x812664", Offset = "0x812664", VA = "0x812664")]
		private void UpdateRelease()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x8128FC", Offset = "0x8128FC", VA = "0x8128FC")]
		private void UpdatePos()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x812BE0", Offset = "0x812BE0", VA = "0x812BE0")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x81300C", Offset = "0x81300C", VA = "0x81300C")]
		private void CheckReleaseHand()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x811E24", Offset = "0x811E24", VA = "0x811E24")]
		private Vector3 CalcEndPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x812860", Offset = "0x812860", VA = "0x812860")]
		private void UpdateGravity()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x811FC0", Offset = "0x811FC0", VA = "0x811FC0")]
		private void SetInterpolatorRotation(Vector3 toForward)
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class CheerState : BaseState
	{
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x813170", Offset = "0x813170", VA = "0x813170")]
		public CheerState(MiniCharaState state)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x813210", Offset = "0x813210", VA = "0x813210", Slot = "5")]
		public override void OnUpdate()
		{
		}
	}
}
namespace Common
{
	[Token(Token = "0x2000177")]
	public class CameraComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000968")]
		private const float MAX_CAMERA_X = 70f;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_camera;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_parent;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SphereCollider m_sphereColl;

		[Token(Token = "0x170000E8")]
		public Camera Camera
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x8132A8", Offset = "0x8132A8", VA = "0x8132A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public Transform Parent
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x813350", Offset = "0x813350", VA = "0x813350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public SphereCollider SphereColl
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x813358", Offset = "0x813358", VA = "0x813358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x8134A4", Offset = "0x8134A4", VA = "0x8134A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x8134A8", Offset = "0x8134A8", VA = "0x8134A8")]
		public void SetForward(Vector3 forward)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x8134FC", Offset = "0x8134FC", VA = "0x8134FC")]
		public void SetLocalRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x813558", Offset = "0x813558", VA = "0x813558")]
		public void SetRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8135B4", Offset = "0x8135B4", VA = "0x8135B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x81364C", Offset = "0x81364C", VA = "0x81364C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x813738", Offset = "0x813738", VA = "0x813738")]
		public Vector3 ViewportToWorld(Vector3 viewport)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x811324", Offset = "0x811324", VA = "0x811324")]
		public Vector3 WorldToViewport(Vector3 worldPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x813828", Offset = "0x813828", VA = "0x813828")]
		public CameraComponent()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class CameraManager : SingletonMonoBehaviour<CameraManager>
	{
		[Token(Token = "0x170000EB")]
		public CameraComponent MainCamera
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x813830", Offset = "0x813830", VA = "0x813830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x813838", Offset = "0x813838", VA = "0x813838")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Transform Parent
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x813840", Offset = "0x813840", VA = "0x813840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public bool CanMoveCameraAngle
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x8138C0", Offset = "0x8138C0", VA = "0x8138C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x8138C8", Offset = "0x8138C8", VA = "0x8138C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x8138D4", Offset = "0x8138D4", VA = "0x8138D4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x813608", Offset = "0x813608", VA = "0x813608")]
		public void SetCamera(CameraComponent camera)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x8136A8", Offset = "0x8136A8", VA = "0x8136A8")]
		public void RemoveCamera(CameraComponent camera)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x8139F0", Offset = "0x8139F0", VA = "0x8139F0")]
		public void SetClearFlag(CameraClearFlags flag)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x813A90", Offset = "0x813A90", VA = "0x813A90")]
		public void SetClearFlag(CameraClearFlags flag, Color color)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x813B80", Offset = "0x813B80", VA = "0x813B80")]
		public void SetClearColor(Color color)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x813C44", Offset = "0x813C44", VA = "0x813C44")]
		public void SetCullingMask(int mask)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x813CE4", Offset = "0x813CE4", VA = "0x813CE4")]
		public void AddCullingMask(int layer)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x813D9C", Offset = "0x813D9C", VA = "0x813D9C")]
		public void RemoveCullingMask(int layer)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x813E54", Offset = "0x813E54", VA = "0x813E54")]
		public CameraManager()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public abstract class BaseCurveAnimComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x200017C")]
		protected enum eState
		{
			[Token(Token = "0x4000975")]
			Wait,
			[Token(Token = "0x4000976")]
			Anim
		}

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected eState m_state;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected AnimationCurve m_curve;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector2 m_animDelay;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_timer;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x80693C", Offset = "0x80693C", VA = "0x80693C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x806B04", Offset = "0x806B04", VA = "0x806B04", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x81403C", Offset = "0x81403C", VA = "0x81403C")]
		private void StateUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x806BE0", Offset = "0x806BE0", VA = "0x806BE0")]
		protected void ResetState()
		{
		}

		[Token(Token = "0x600080E")]
		protected abstract void Animation(float value);

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x806C78", Offset = "0x806C78", VA = "0x806C78")]
		protected BaseCurveAnimComponent()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class BillboardComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000977")]
		private const float ADJ_ALPHA_MAX = 0.9f;

		[Token(Token = "0x4000978")]
		private const float ADJ_ALPHA_MIN = 0.98f;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTrans;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_isEnableY;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool m_isReverse;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool m_isOnlyY;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform m_upTrans;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_mat;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string m_shaderColorName;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_shaderId;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x814150", Offset = "0x814150", VA = "0x814150")]
		private void Start()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x8142A4", Offset = "0x8142A4", VA = "0x8142A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x814508", Offset = "0x814508", VA = "0x814508")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x814744", Offset = "0x814744", VA = "0x814744")]
		public BillboardComponent()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class ColliderComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<Collider> OnEnter;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<Collider> OnExit;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x81475C", Offset = "0x81475C", VA = "0x81475C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x814778", Offset = "0x814778", VA = "0x814778")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x814794", Offset = "0x814794", VA = "0x814794")]
		public ColliderComponent()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public abstract class GameComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x2000180")]
		protected enum eComponentType
		{
			[Token(Token = "0x4000986")]
			Object,
			[Token(Token = "0x4000987")]
			UI
		}

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected eComponentType m_componentType;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected bool m_isAutoCallUpdate;

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x81479C", Offset = "0x81479C", VA = "0x81479C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x8148EC", Offset = "0x8148EC", VA = "0x8148EC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x814A48", Offset = "0x814A48", VA = "0x814A48", Slot = "7")]
		public virtual void OnUpdate()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x808428", Offset = "0x808428", VA = "0x808428", Slot = "8")]
		public virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x814A4C", Offset = "0x814A4C", VA = "0x814A4C")]
		public void SetPos(Vector3 pos)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x814A94", Offset = "0x814A94", VA = "0x814A94")]
		public void AddPos(Vector3 add)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x814AEC", Offset = "0x814AEC", VA = "0x814AEC")]
		public void SetRotation(float angleY)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x814B3C", Offset = "0x814B3C", VA = "0x814B3C")]
		public void SetTrans(Vector3 pos, float angleY)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x814B64", Offset = "0x814B64", VA = "0x814B64")]
		protected GameComponent()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class GameComponentManager : SingletonMonoBehaviour<GameComponentManager>
	{
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GameComponent> componentList;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<GameComponent> uiList;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x81482C", Offset = "0x81482C", VA = "0x81482C")]
		public void AddComponent(GameComponent component)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x81488C", Offset = "0x81488C", VA = "0x81488C")]
		public void AddUI(GameComponent component)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x814988", Offset = "0x814988", VA = "0x814988")]
		public void RemoveComponent(GameComponent component)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x8149E8", Offset = "0x8149E8", VA = "0x8149E8")]
		public void RemoveUI(GameComponent component)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x814B74", Offset = "0x814B74", VA = "0x814B74")]
		public void Update()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x814CF0", Offset = "0x814CF0", VA = "0x814CF0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x814E6C", Offset = "0x814E6C", VA = "0x814E6C")]
		public GameComponentManager()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class ModelComponent : GameComponent
	{
		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string modelPath;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isModelLoaded;

		[Token(Token = "0x170000EE")]
		public GameObject Model
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x814F40", Offset = "0x814F40", VA = "0x814F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x814F48", Offset = "0x814F48", VA = "0x814F48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x814F50", Offset = "0x814F50", VA = "0x814F50", Slot = "9")]
		public virtual void SetModelPath(string path)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x81508C", Offset = "0x81508C", VA = "0x81508C", Slot = "7")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x8150D4", Offset = "0x8150D4", VA = "0x8150D4")]
		private void CreateModel(string path)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x8152B8", Offset = "0x8152B8", VA = "0x8152B8", Slot = "10")]
		protected virtual void OnCreateModel()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x8152BC", Offset = "0x8152BC", VA = "0x8152BC")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x815344", Offset = "0x815344", VA = "0x815344")]
		public ModelComponent()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class CharaFadeViewer : MonoBehaviour
	{
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x815368", Offset = "0x815368", VA = "0x815368")]
		public CharaFadeViewer()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public static class Debug
	{
		[Token(Token = "0x170000EF")]
		public static bool EnableLog
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x815370", Offset = "0x815370", VA = "0x815370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x8153C8", Offset = "0x8153C8", VA = "0x8153C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x815424", Offset = "0x815424", VA = "0x815424")]
		[Conditional("__LOG__")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x815500", Offset = "0x815500", VA = "0x815500")]
		[Conditional("__LOG__")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x8155C8", Offset = "0x8155C8", VA = "0x8155C8")]
		[Conditional("__LOG__")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x8156A4", Offset = "0x8156A4", VA = "0x8156A4")]
		[Conditional("__LOG__")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x81576C", Offset = "0x81576C", VA = "0x81576C")]
		[Conditional("__LOG__")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x815848", Offset = "0x815848", VA = "0x815848")]
		[Conditional("__LOG__")]
		public static void LogError(object message)
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class ScriptableDebugDLCParameter : ScriptableObject
	{
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<DebugDLCParameter> m_params;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x81595C", Offset = "0x81595C", VA = "0x81595C")]
		public ScriptableDebugDLCParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000187")]
	public class DebugDLCParameter
	{
		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameDefine.eMusic m_title;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BasePlatform.eDLC m_dlc;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_isEntitlement;

		[Token(Token = "0x170000F0")]
		public bool IsBeforeEntitlement
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x815964", Offset = "0x815964", VA = "0x815964")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x81596C", Offset = "0x81596C", VA = "0x81596C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x815978", Offset = "0x815978", VA = "0x815978")]
		public DebugDLCParameter()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class EffectComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem m_effect;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isLoading;

		[Token(Token = "0x170000F1")]
		public string Path
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x815980", Offset = "0x815980", VA = "0x815980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x815988", Offset = "0x815988", VA = "0x815988")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x815990", Offset = "0x815990", VA = "0x815990")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F3")]
		public bool IsUsed
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x815A18", Offset = "0x815A18", VA = "0x815A18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F4")]
		public float PlayTime
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x815A44", Offset = "0x815A44", VA = "0x815A44")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x815A4C", Offset = "0x815A4C", VA = "0x815A4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x815A54", Offset = "0x815A54", VA = "0x815A54")]
		public void CreateEffect(string path)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x815BA4", Offset = "0x815BA4", VA = "0x815BA4")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x815CAC", Offset = "0x815CAC", VA = "0x815CAC")]
		public void Play()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x815C8C", Offset = "0x815C8C", VA = "0x815C8C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x815D70", Offset = "0x815D70", VA = "0x815D70")]
		public void Pause()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x815D88", Offset = "0x815D88", VA = "0x815D88")]
		public void Resume()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x815DA0", Offset = "0x815DA0", VA = "0x815DA0")]
		public EffectComponent()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class EffectManager : SingletonMonoBehaviour<EffectManager>
	{
		[Token(Token = "0x400099C")]
		private const int MAX_LIST_NUM = 32;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<EffectComponent> m_effectList;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<EffectComponent> m_cacheList;

		[Token(Token = "0x170000F5")]
		public bool IsPause
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x815F68", Offset = "0x815F68", VA = "0x815F68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x815F70", Offset = "0x815F70", VA = "0x815F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x815F7C", Offset = "0x815F7C", VA = "0x815F7C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x815F80", Offset = "0x815F80", VA = "0x815F80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x816170", Offset = "0x816170", VA = "0x816170")]
		public EffectComponent Play(string path, Vector3 pos, Vector3 forward, float time = -1f, bool isCache = true)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x81655C", Offset = "0x81655C", VA = "0x81655C")]
		public EffectComponent Play(string path, Transform parent, bool isCache = true)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x816360", Offset = "0x816360", VA = "0x816360")]
		private int GetCacheIndex(string path)
		{
			return default(int);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x816494", Offset = "0x816494", VA = "0x816494")]
		private EffectComponent CreateComponent()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8166BC", Offset = "0x8166BC", VA = "0x8166BC")]
		public void Pause()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x816774", Offset = "0x816774", VA = "0x816774")]
		public void Resume()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x816828", Offset = "0x816828", VA = "0x816828")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8168CC", Offset = "0x8168CC", VA = "0x8168CC")]
		public EffectManager()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class CharaFadeController
	{
		[Token(Token = "0x200018D")]
		public class Sphere
		{
			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform m_bone;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float m_range;

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x816ED0", Offset = "0x816ED0", VA = "0x816ED0")]
			public float DistanceRate(Vector3 pos)
			{
				return default(float);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x816DCC", Offset = "0x816DCC", VA = "0x816DCC")]
			public Sphere()
			{
			}
		}

		[Token(Token = "0x200018E")]
		public class Capsule
		{
			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Sphere m_start;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Sphere m_end;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float m_range;

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x816F80", Offset = "0x816F80", VA = "0x816F80")]
			public float DistanceRate(Vector3 pos)
			{
				return default(float);
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x816DD4", Offset = "0x816DD4", VA = "0x816DD4")]
			public Capsule()
			{
			}
		}

		[Token(Token = "0x40009A0")]
		private const float FADE_DIST = 0.02f;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Sphere[] m_sphereArray;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Capsule[] m_capsuleArray;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isSetup;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8169A0", Offset = "0x8169A0", VA = "0x8169A0")]
		public void Initialize(Transform character, CharaFadeParameter param)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x816DDC", Offset = "0x816DDC", VA = "0x816DDC")]
		public float OnUpdate(Vector3 cameraPos)
		{
			return default(float);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x817204", Offset = "0x817204", VA = "0x817204")]
		public CharaFadeController()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class FadeComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x40009A9")]
		public const string FADE_PREFAB_PATH = "Prefab/FadeObj";

		[Token(Token = "0x40009AA")]
		public const float DEFAULT_TIME = 2f;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int COLOR_SHADER_ID;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Color m_color;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_material;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer m_mesh;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected float m_fadeTime;

		[Token(Token = "0x170000F6")]
		public float FadeRate
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x81720C", Offset = "0x81720C", VA = "0x81720C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x817214", Offset = "0x817214", VA = "0x817214")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool IsUsing
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x81721C", Offset = "0x81721C", VA = "0x81721C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x817294", Offset = "0x817294", VA = "0x817294")]
		protected void SetRenderQueue(int renderQueue)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x81732C", Offset = "0x81732C", VA = "0x81732C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x817658", Offset = "0x817658", VA = "0x817658", Slot = "6")]
		public virtual void OnUpdate()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x817770", Offset = "0x817770", VA = "0x817770")]
		public FadeComponent()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class FadeManager : SingletonMonoBehaviour<FadeManager>
	{
		[Token(Token = "0x2000192")]
		public enum eFadeState
		{
			[Token(Token = "0x40009B6")]
			DEFAULT,
			[Token(Token = "0x40009B7")]
			IN,
			[Token(Token = "0x40009B8")]
			OUT,
			[Token(Token = "0x40009B9")]
			WHITE_IN,
			[Token(Token = "0x40009BA")]
			WHITE_OUT,
			[Token(Token = "0x40009BB")]
			FORCE_ON,
			[Token(Token = "0x40009BC")]
			FORCE_OFF
		}

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isPause;

		[Token(Token = "0x170000F8")]
		public GameFadeComponent GameFade
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x8177E8", Offset = "0x8177E8", VA = "0x8177E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x8177F0", Offset = "0x8177F0", VA = "0x8177F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public SystemFadeComponent SystemFade
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x8177F8", Offset = "0x8177F8", VA = "0x8177F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x817800", Offset = "0x817800", VA = "0x817800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public float FadeRate
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x817808", Offset = "0x817808", VA = "0x817808")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FB")]
		public bool IsPause
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x817880", Offset = "0x817880", VA = "0x817880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x817888", Offset = "0x817888", VA = "0x817888")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float CharaRate
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x817894", Offset = "0x817894", VA = "0x817894")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x81790C", Offset = "0x81790C", VA = "0x81790C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool IsUsing
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x81798C", Offset = "0x81798C", VA = "0x81798C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public bool IsFading
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x817A0C", Offset = "0x817A0C", VA = "0x817A0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FF")]
		public bool IsEnd
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x817A90", Offset = "0x817A90", VA = "0x817A90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x817B14", Offset = "0x817B14", VA = "0x817B14")]
		public void Inititialize()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x817CB0", Offset = "0x817CB0", VA = "0x817CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x817CF4", Offset = "0x817CF4", VA = "0x817CF4")]
		public void FadeIn(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x817DA8", Offset = "0x817DA8", VA = "0x817DA8")]
		public void FadeOut(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x817E54", Offset = "0x817E54", VA = "0x817E54")]
		public void WhiteIn(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x817F04", Offset = "0x817F04", VA = "0x817F04")]
		public void WhiteOut(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x817FAC", Offset = "0x817FAC", VA = "0x817FAC")]
		public void ForceFadeOn(Color color)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x817FEC", Offset = "0x817FEC", VA = "0x817FEC")]
		public void ForceFadeOff()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x818038", Offset = "0x818038", VA = "0x818038")]
		public void SetEndFadeAction(Action endAction)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x8180D0", Offset = "0x8180D0", VA = "0x8180D0")]
		public FadeManager()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class GameFadeComponent : FadeComponent
	{
		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color WHITE_OUT_COLOR;

		[Token(Token = "0x40009BE")]
		private const float MAX_COLOR_RATE = 1f;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isAlreadyCalledNowFrame;

		[Token(Token = "0x17000100")]
		public FadeManager.eFadeState FadeState
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x818118", Offset = "0x818118", VA = "0x818118")]
			[CompilerGenerated]
			get
			{
				return default(FadeManager.eFadeState);
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x818120", Offset = "0x818120", VA = "0x818120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool IsEndFade
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x818128", Offset = "0x818128", VA = "0x818128")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x818130", Offset = "0x818130", VA = "0x818130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public Action OnEndAction
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x81813C", Offset = "0x81813C", VA = "0x81813C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x818144", Offset = "0x818144", VA = "0x818144")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x81814C", Offset = "0x81814C", VA = "0x81814C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x818168", Offset = "0x818168", VA = "0x818168", Slot = "6")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x81822C", Offset = "0x81822C", VA = "0x81822C")]
		private void EndFade()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x817D04", Offset = "0x817D04", VA = "0x817D04")]
		public void FadeIn(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x817DB8", Offset = "0x817DB8", VA = "0x817DB8")]
		public void FadeOut(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x817E64", Offset = "0x817E64", VA = "0x817E64")]
		public void WhiteIn(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x817F14", Offset = "0x817F14", VA = "0x817F14")]
		public void WhiteOut(float time = 2f, float startTime = 0f)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x817FBC", Offset = "0x817FBC", VA = "0x817FBC")]
		public void ForceFadeOn(Color color)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x817FFC", Offset = "0x817FFC", VA = "0x817FFC")]
		public void ForceFadeOff()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x81826C", Offset = "0x81826C", VA = "0x81826C")]
		public GameFadeComponent()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class ScriptableCharaFadeParameter : ScriptableObject
	{
		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<CharaFadeParameter> m_param;

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x8182E4", Offset = "0x8182E4", VA = "0x8182E4")]
		public ScriptableCharaFadeParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000195")]
	public class CharaFadeParameter
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		public class Sphere
		{
			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_bonePath;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float m_range;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x8182F4", Offset = "0x8182F4", VA = "0x8182F4")]
			public Sphere()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000197")]
		public class Capsule
		{
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_startPath;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string m_endPath;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float m_range;

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x8182FC", Offset = "0x8182FC", VA = "0x8182FC")]
			public Capsule()
			{
			}
		}

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sphere[] m_sphereArray;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Capsule[] m_capsuleArray;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x8182EC", Offset = "0x8182EC", VA = "0x8182EC")]
		public CharaFadeParameter()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class SystemFadeComponent : FadeComponent
	{
		[Token(Token = "0x17000103")]
		public float AreaValue
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x818304", Offset = "0x818304", VA = "0x818304")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x81830C", Offset = "0x81830C", VA = "0x81830C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public float CharaValue
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x818314", Offset = "0x818314", VA = "0x818314")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x81831C", Offset = "0x81831C", VA = "0x81831C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x818324", Offset = "0x818324", VA = "0x818324", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x818340", Offset = "0x818340", VA = "0x818340", Slot = "6")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x818364", Offset = "0x818364", VA = "0x818364")]
		public SystemFadeComponent()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public abstract class BaseInput
	{
		[Token(Token = "0x200019A")]
		public delegate bool UpdateInput();

		[Token(Token = "0x200019B")]
		public delegate float UpdateAxis();

		[Token(Token = "0x200019C")]
		public class PushData
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool m_push;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool m_repeat;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool m_release;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<UpdateInput> m_updateList;

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x818534", Offset = "0x818534", VA = "0x818534")]
			public PushData()
			{
			}
		}

		[Token(Token = "0x200019D")]
		public class StickData
		{
			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 m_inputValue;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool m_canUse;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<UpdateAxis> m_verticalUpdateList;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<UpdateAxis> m_horizontalUpdateList;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x8185BC", Offset = "0x8185BC", VA = "0x8185BC")]
			public StickData()
			{
			}
		}

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PushData[] m_pushDataArray;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StickData[] m_stickDataArray;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<InputManager.eActiveHandType> RemoveBatteryEvent;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x8183D0", Offset = "0x8183D0", VA = "0x8183D0", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x818674", Offset = "0x818674", VA = "0x818674", Slot = "5")]
		public virtual void InitializeVR()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x818678", Offset = "0x818678", VA = "0x818678", Slot = "6")]
		public virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x8188BC", Offset = "0x8188BC", VA = "0x8188BC", Slot = "7")]
		public virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x8188C0", Offset = "0x8188C0", VA = "0x8188C0")]
		protected void AddInput(InputManager.eActionType action, UpdateInput update)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x818944", Offset = "0x818944", VA = "0x818944")]
		protected void AddStickInput(InputManager.eStickType stick, UpdateAxis update, bool isHorizontal)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x818A0C", Offset = "0x818A0C", VA = "0x818A0C")]
		protected UpdateInput GetInputButtonAction(Key keyName)
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x818B64", Offset = "0x818B64", VA = "0x818B64")]
		protected UpdateInput GetInputKeyAction(Key code)
		{
			return null;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x818C14", Offset = "0x818C14", VA = "0x818C14")]
		protected UpdateAxis GetAxisButtonAction(string name, bool isInverse)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x818D9C", Offset = "0x818D9C", VA = "0x818D9C")]
		public bool GetButtonDown(InputManager.eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x818DE4", Offset = "0x818DE4", VA = "0x818DE4")]
		public bool GetButton(InputManager.eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x818E2C", Offset = "0x818E2C", VA = "0x818E2C")]
		public bool GetButtonRelease(InputManager.eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x818E74", Offset = "0x818E74", VA = "0x818E74")]
		public Vector2 GetStick(InputManager.eStickType type)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x818EEC", Offset = "0x818EEC", VA = "0x818EEC", Slot = "8")]
		public virtual void Vibration(float time, InputManager.eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x818EF0", Offset = "0x818EF0", VA = "0x818EF0", Slot = "9")]
		public virtual void Vibration(InputManager.eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x818EF4", Offset = "0x818EF4", VA = "0x818EF4", Slot = "10")]
		public virtual void StopVibration(InputManager.eActiveHandType hand)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x818EF8", Offset = "0x818EF8", VA = "0x818EF8", Slot = "11")]
		public virtual bool CanUseController(InputManager.eActiveHandType handType)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x818F00", Offset = "0x818F00", VA = "0x818F00", Slot = "12")]
		public virtual void DeactiveVRConfig()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x818F04", Offset = "0x818F04", VA = "0x818F04")]
		protected BaseInput()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public abstract class BaseOculusInput : BaseInput
	{
		[Token(Token = "0x20001A2")]
		public class Battery
		{
			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OVRInput.Controller m_ovrType;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public InputManager.eActiveHandType m_handType;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_isRemainBatteryBefore;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x819C78", Offset = "0x819C78", VA = "0x819C78")]
			public void Initialize(OVRInput.Controller ovrType, InputManager.eActiveHandType handType)
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x819614", Offset = "0x819614", VA = "0x819614")]
			public bool OnUpdate()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x819C80", Offset = "0x819C80", VA = "0x819C80")]
			public Battery()
			{
			}
		}

		[Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private sealed class <VibrationCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float power;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OVRInput.Controller controller;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float time;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BaseOculusInput <>4__this;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E0")]
				[Address(RVA = "0x81A0C0", Offset = "0x81A0C0", VA = "0x81A0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E2")]
				[Address(RVA = "0x81A108", Offset = "0x81A108", VA = "0x81A108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x819874", Offset = "0x819874", VA = "0x819874")]
			[DebuggerHidden]
			public <VibrationCoroutine>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x819E84", Offset = "0x819E84", VA = "0x819E84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x819E88", Offset = "0x819E88", VA = "0x819E88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x81A0C8", Offset = "0x81A0C8", VA = "0x81A0C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class <VibrationContinueCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float power;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OVRInput.Controller controller;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WaitForSeconds <wait>5__2;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x81A2EC", Offset = "0x81A2EC", VA = "0x81A2EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x81A334", Offset = "0x81A334", VA = "0x81A334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x819A68", Offset = "0x819A68", VA = "0x819A68")]
			[DebuggerHidden]
			public <VibrationContinueCoroutine>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x81A110", Offset = "0x81A110", VA = "0x81A110", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x81A114", Offset = "0x81A114", VA = "0x81A114", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x81A2F4", Offset = "0x81A2F4", VA = "0x81A2F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine m_vibrationRCoroutine;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine m_vibrationLCoroutine;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine m_vibrationRContinueCoroutine;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine m_vibrationLContinueCoroutine;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Battery[] m_batteryCheckArray;

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x819198", Offset = "0x819198", VA = "0x819198")]
		protected UpdateInput GetInput(OVRInput.RawAxis1D axis)
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x819248", Offset = "0x819248", VA = "0x819248")]
		protected UpdateInput GetInput(OVRInput.RawButton button)
		{
			return null;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x8192F8", Offset = "0x8192F8", VA = "0x8192F8")]
		protected UpdateAxis GetAxis(OVRInput.Axis1D axis)
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x8193A8", Offset = "0x8193A8", VA = "0x8193A8")]
		private UpdateAxis GetAxisX(OVRInput.Axis2D axis)
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x819458", Offset = "0x819458", VA = "0x819458")]
		private UpdateAxis GetAxisY(OVRInput.Axis2D axis)
		{
			return null;
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x819508", Offset = "0x819508", VA = "0x819508")]
		protected void AddStickInput(InputManager.eStickType type, OVRInput.Axis2D axis)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x81955C", Offset = "0x81955C", VA = "0x81955C", Slot = "6")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x8196A4", Offset = "0x8196A4", VA = "0x8196A4", Slot = "8")]
		public override void Vibration(float time, InputManager.eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x8197CC", Offset = "0x8197CC", VA = "0x8197CC")]
		[IteratorStateMachine(typeof(<VibrationCoroutine>d__14))]
		private IEnumerator VibrationCoroutine(float time, OVRInput.Controller controller, float power, float delay)
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x81989C", Offset = "0x81989C", VA = "0x81989C", Slot = "9")]
		public override void Vibration(InputManager.eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x8199EC", Offset = "0x8199EC", VA = "0x8199EC")]
		[IteratorStateMachine(typeof(<VibrationContinueCoroutine>d__16))]
		private IEnumerator VibrationContinueCoroutine(OVRInput.Controller controller, float power, float delay)
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x819A90", Offset = "0x819A90", VA = "0x819A90", Slot = "10")]
		public override void StopVibration(InputManager.eActiveHandType hand)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x819BF0", Offset = "0x819BF0", VA = "0x819BF0", Slot = "11")]
		public override bool CanUseController(InputManager.eActiveHandType handType)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x819C74", Offset = "0x819C74", VA = "0x819C74")]
		protected BaseOculusInput()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class InputManager : SingletonMonoBehaviour<InputManager>
	{
		[Token(Token = "0x20001AB")]
		public enum eDevice
		{
			[Token(Token = "0x40009FE")]
			PC,
			[Token(Token = "0x40009FF")]
			OculusRift,
			[Token(Token = "0x4000A00")]
			OculusQuest
		}

		[Token(Token = "0x20001AC")]
		public enum eActionType
		{
			[Token(Token = "0x4000A02")]
			Decide_R,
			[Token(Token = "0x4000A03")]
			Decide_L,
			[Token(Token = "0x4000A04")]
			Cancel,
			[Token(Token = "0x4000A05")]
			Move_R,
			[Token(Token = "0x4000A06")]
			Move_L,
			[Token(Token = "0x4000A07")]
			ChangeMove,
			[Token(Token = "0x4000A08")]
			RightHand,
			[Token(Token = "0x4000A09")]
			LeftHand,
			[Token(Token = "0x4000A0A")]
			Menu,
			[Token(Token = "0x4000A0B")]
			Pointing_R,
			[Token(Token = "0x4000A0C")]
			Pointing_L,
			[Token(Token = "0x4000A0D")]
			LightColorNext,
			[Token(Token = "0x4000A0E")]
			LightColorBack,
			[Token(Token = "0x4000A0F")]
			Swing_R,
			[Token(Token = "0x4000A10")]
			Swing_L,
			[Token(Token = "0x4000A11")]
			MAX
		}

		[Token(Token = "0x20001AD")]
		public enum eStickType
		{
			[Token(Token = "0x4000A13")]
			Right,
			[Token(Token = "0x4000A14")]
			Left,
			[Token(Token = "0x4000A15")]
			MAX
		}

		[Token(Token = "0x20001AE")]
		public enum eActiveHandType
		{
			[Token(Token = "0x4000A17")]
			CanNotUseHand,
			[Token(Token = "0x4000A18")]
			Right,
			[Token(Token = "0x4000A19")]
			Left,
			[Token(Token = "0x4000A1A")]
			MAX
		}

		[Token(Token = "0x40009F7")]
		public const float AXIS_THRESHOLD = 0.9f;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BaseInput m_input;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IsActiveHandChangeFrame;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<eActionType> m_onceCheckList;

		[Token(Token = "0x17000109")]
		public eActiveHandType ActiveHandType
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x81A33C", Offset = "0x81A33C", VA = "0x81A33C")]
			[CompilerGenerated]
			get
			{
				return default(eActiveHandType);
			}
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x81A344", Offset = "0x81A344", VA = "0x81A344")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool IsHandController
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x81A4AC", Offset = "0x81A4AC", VA = "0x81A4AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<eActiveHandType> OnChangeActiveHand
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x81A34C", Offset = "0x81A34C", VA = "0x81A34C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x81A3FC", Offset = "0x81A3FC", VA = "0x81A3FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x81A4BC", Offset = "0x81A4BC", VA = "0x81A4BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x81A6A8", Offset = "0x81A6A8", VA = "0x81A6A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x81A6B0", Offset = "0x81A6B0", VA = "0x81A6B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x81A530", Offset = "0x81A530", VA = "0x81A530")]
		private void CheckActiveHand()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x81A714", Offset = "0x81A714", VA = "0x81A714")]
		public void SetDevice(eDevice platform)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x81A7F0", Offset = "0x81A7F0", VA = "0x81A7F0")]
		public bool GetButtonDown(eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x81A874", Offset = "0x81A874", VA = "0x81A874")]
		public bool GetButtonDownOnce(eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x81A990", Offset = "0x81A990", VA = "0x81A990")]
		public bool GetButton(eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x81AA14", Offset = "0x81AA14", VA = "0x81AA14")]
		public bool GetButtonRelease(eActionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x81AA98", Offset = "0x81AA98", VA = "0x81AA98")]
		public Vector2 GetStick(eStickType type)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x81AAE8", Offset = "0x81AAE8", VA = "0x81AAE8")]
		public void Vibration(float time, eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x81AB00", Offset = "0x81AB00", VA = "0x81AB00")]
		public void Vibration(eActiveHandType hand, float power = 1f, float delay = -1f)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x81AB18", Offset = "0x81AB18", VA = "0x81AB18")]
		public void StopVibration(eActiveHandType hand)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x81AB30", Offset = "0x81AB30", VA = "0x81AB30")]
		public void AddControllerBatteryCallback(Action<eActiveHandType> action)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x81ABF0", Offset = "0x81ABF0", VA = "0x81ABF0")]
		public void RemoveControllerBatteryCallback(Action<eActiveHandType> action)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x81A6C8", Offset = "0x81A6C8", VA = "0x81A6C8")]
		public bool CanUseController(eActiveHandType handType)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x81ACB0", Offset = "0x81ACB0", VA = "0x81ACB0")]
		public void DeactiveVRConfig()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x81ACD0", Offset = "0x81ACD0", VA = "0x81ACD0")]
		public void InitializeVR()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x81ACF0", Offset = "0x81ACF0", VA = "0x81ACF0")]
		public InputManager()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class InputOculusQuest : BaseOculusInput
	{
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x81AD90", Offset = "0x81AD90", VA = "0x81AD90", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x81A7EC", Offset = "0x81A7EC", VA = "0x81A7EC")]
		public InputOculusQuest()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class InputOculusRift : BaseOculusInput
	{
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x81AF58", Offset = "0x81AF58", VA = "0x81AF58", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x81A7E8", Offset = "0x81A7E8", VA = "0x81A7E8")]
		public InputOculusRift()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class InputPC : BaseInput
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x81B0F0", Offset = "0x81B0F0", VA = "0x81B0F0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x81A7E4", Offset = "0x81A7E4", VA = "0x81A7E4")]
		public InputPC()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class LipSyncComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x20001B3")]
		public enum eMouthType
		{
			[Token(Token = "0x4000A27")]
			Small,
			[Token(Token = "0x4000A28")]
			Midium,
			[Token(Token = "0x4000A29")]
			Large,
			[Token(Token = "0x4000A2A")]
			Max
		}

		[Token(Token = "0x20001B4")]
		public class Mouth
		{
			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int m_blendShapeIndex;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float m_currentValue;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float m_toValue;

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x81B384", Offset = "0x81B384", VA = "0x81B384")]
			public Mouth()
			{
			}
		}

		[Token(Token = "0x4000A1B")]
		private const int WAVE_BUFFER_SIZE = 256;

		[Token(Token = "0x4000A1C")]
		private const float CHANGE_SPEED = 200f;

		[Token(Token = "0x4000A1D")]
		private const float CHECK_DELAY = 0.08f;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource m_source;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SkinnedMeshRenderer m_mesh;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LipSyncParameter m_param;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Mouth[] m_mouthArray;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_checkDelayTimer;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_isActive;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] m_waveArray;

		[Token(Token = "0x1700010B")]
		public bool IsEnable
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x81B208", Offset = "0x81B208", VA = "0x81B208")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x81B210", Offset = "0x81B210", VA = "0x81B210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x81B21C", Offset = "0x81B21C", VA = "0x81B21C")]
		public void Initialize(AudioSource source, SkinnedMeshRenderer mesh, LipSyncParameter param)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x81B38C", Offset = "0x81B38C", VA = "0x81B38C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x81B470", Offset = "0x81B470", VA = "0x81B470")]
		private void Update()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x81B5C0", Offset = "0x81B5C0", VA = "0x81B5C0")]
		private void CheckVolume()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x81B8D8", Offset = "0x81B8D8", VA = "0x81B8D8")]
		private float CalcVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x81B7BC", Offset = "0x81B7BC", VA = "0x81B7BC")]
		private void UpdateMouthValue()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x81B94C", Offset = "0x81B94C", VA = "0x81B94C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x81B9FC", Offset = "0x81B9FC", VA = "0x81B9FC")]
		private void UpdateBlendShape()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x81BA6C", Offset = "0x81BA6C", VA = "0x81BA6C")]
		public void SetAoudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x81BA74", Offset = "0x81BA74", VA = "0x81BA74")]
		public LipSyncComponent()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class ScriptableLipSyncParameter : ScriptableObject
	{
		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<LipSyncParameter> m_param;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x81BB18", Offset = "0x81BB18", VA = "0x81BB18")]
		public ScriptableLipSyncParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B6")]
	public class LipSyncParameter
	{
		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_smallMouthIndex;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_mediumMouthIndex;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m_largeMouthIndex;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_smallMaxVolume;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_mediumMaxVolume;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_largeMaxVolume;

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x81BB20", Offset = "0x81BB20", VA = "0x81BB20")]
		public LipSyncParameter()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class BezierCurve
	{
		[Token(Token = "0x1700010C")]
		public Vector3 Start
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x81BB28", Offset = "0x81BB28", VA = "0x81BB28")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x81BB34", Offset = "0x81BB34", VA = "0x81BB34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public Vector3 End
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x81BB40", Offset = "0x81BB40", VA = "0x81BB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x81BB4C", Offset = "0x81BB4C", VA = "0x81BB4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public Vector3 Control
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x81BB58", Offset = "0x81BB58", VA = "0x81BB58")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x81BB64", Offset = "0x81BB64", VA = "0x81BB64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x81BB70", Offset = "0x81BB70", VA = "0x81BB70")]
		public BezierCurve(Vector3 start, Vector3 end, Vector3 control)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x81BBE4", Offset = "0x81BBE4", VA = "0x81BBE4")]
		public Vector3 GetPoint(float rate)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20001B8")]
	public abstract class Interpolator<T>
	{
		[Token(Token = "0x20001B9")]
		public enum eType
		{
			[Token(Token = "0x4000A41")]
			Linear,
			[Token(Token = "0x4000A42")]
			EaseIn,
			[Token(Token = "0x4000A43")]
			EaseOut,
			[Token(Token = "0x4000A44")]
			EaseInOut
		}

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T m_start;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T m_end;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float m_timer;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float m_time;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_onEndAction;

		[Token(Token = "0x1700010F")]
		public eType CurveType
		{
			[Token(Token = "0x600091F")]
			[CompilerGenerated]
			get
			{
				return default(eType);
			}
			[Token(Token = "0x6000920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public float CurrentTime
		{
			[Token(Token = "0x6000921")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		public bool IsEnable
		{
			[Token(Token = "0x6000922")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000923")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000924")]
		public T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000925")]
		public void Initialize(T start, T end, float time, eType type, [Optional] Action onEndAction)
		{
		}

		[Token(Token = "0x6000926")]
		public bool OnUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000927")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000928")]
		protected float NowTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000929")]
		protected abstract T CalcLinear();

		[Token(Token = "0x600092A")]
		protected abstract T CalcEaseIn();

		[Token(Token = "0x600092B")]
		protected abstract T CalcEaseOut();

		[Token(Token = "0x600092C")]
		protected abstract T CalcEaseInOut();

		[Token(Token = "0x600092D")]
		protected Interpolator()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class InterpolatorFloat : Interpolator<float>
	{
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x81BC64", Offset = "0x81BC64", VA = "0x81BC64", Slot = "4")]
		protected override float CalcLinear()
		{
			return default(float);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x81BCC8", Offset = "0x81BCC8", VA = "0x81BCC8", Slot = "5")]
		protected override float CalcEaseIn()
		{
			return default(float);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x81BD28", Offset = "0x81BD28", VA = "0x81BD28", Slot = "6")]
		protected override float CalcEaseOut()
		{
			return default(float);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x81BD90", Offset = "0x81BD90", VA = "0x81BD90", Slot = "7")]
		protected override float CalcEaseInOut()
		{
			return default(float);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x81BE38", Offset = "0x81BE38", VA = "0x81BE38")]
		public static float CalcNormalizeEaseOut(float rate)
		{
			return default(float);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x81BE48", Offset = "0x81BE48", VA = "0x81BE48")]
		public static float CalcNormalizeEaseIn(float rate)
		{
			return default(float);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x81BE50", Offset = "0x81BE50", VA = "0x81BE50")]
		public static float CalcNormalizeEaseInOut(float rate)
		{
			return default(float);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x81BE90", Offset = "0x81BE90", VA = "0x81BE90")]
		public InterpolatorFloat()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class InterpolatorVector2 : Interpolator<Vector2>
	{
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x81BED8", Offset = "0x81BED8", VA = "0x81BED8", Slot = "4")]
		protected override Vector2 CalcLinear()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x81BF44", Offset = "0x81BF44", VA = "0x81BF44", Slot = "5")]
		protected override Vector2 CalcEaseIn()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x81BFAC", Offset = "0x81BFAC", VA = "0x81BFAC", Slot = "6")]
		protected override Vector2 CalcEaseOut()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x81C01C", Offset = "0x81C01C", VA = "0x81C01C", Slot = "7")]
		protected override Vector2 CalcEaseInOut()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x81C0D0", Offset = "0x81C0D0", VA = "0x81C0D0")]
		public InterpolatorVector2()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class InterpolatorVector3 : Interpolator<Vector3>
	{
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x81C118", Offset = "0x81C118", VA = "0x81C118", Slot = "4")]
		protected override Vector3 CalcLinear()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x81C1A0", Offset = "0x81C1A0", VA = "0x81C1A0", Slot = "5")]
		protected override Vector3 CalcEaseIn()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x81C220", Offset = "0x81C220", VA = "0x81C220", Slot = "6")]
		protected override Vector3 CalcEaseOut()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x81C2A8", Offset = "0x81C2A8", VA = "0x81C2A8", Slot = "7")]
		protected override Vector3 CalcEaseInOut()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x81C394", Offset = "0x81C394", VA = "0x81C394")]
		public InterpolatorVector3()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public class DefaultMovieManager<T> : MovieManager<T> where T : MovieManager<T>
	{
		[Token(Token = "0x20001BF")]
		[CompilerGenerated]
		private sealed class <RequestCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DefaultMovieManager<T> <>4__this;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string path;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetName;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isPreinstall;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000955")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000957")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000952")]
			[DebuggerHidden]
			public <RequestCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000953")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000954")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000956")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private VideoPlayer m_videoPlayer;

		[Token(Token = "0x4000A46")]
		private const ulong ENDED_MOVIE_FRAME_OFFSET = 120uL;

		[Token(Token = "0x17000112")]
		public RenderTexture MovieTexture
		{
			[Token(Token = "0x6000940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000942")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000943")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000944")]
		[IteratorStateMachine(typeof(DefaultMovieManager<>.<RequestCoroutine>d__8))]
		protected override IEnumerator RequestCoroutine(string path, string assetName, bool isPreinstall)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		private void OnPrepareCompleted(VideoPlayer source)
		{
		}

		[Token(Token = "0x6000946")]
		public override void Pause()
		{
		}

		[Token(Token = "0x6000947")]
		public override void Resume()
		{
		}

		[Token(Token = "0x6000948")]
		public override void Stop()
		{
		}

		[Token(Token = "0x6000949")]
		public override void ClearTexture()
		{
		}

		[Token(Token = "0x600094A")]
		public override void SetVolume(float volume)
		{
		}

		[Token(Token = "0x600094B")]
		public override void SetVideoClipPosition(double normalizedPosition)
		{
		}

		[Token(Token = "0x600094C")]
		public override double GetVideoClipNormalizedPosition()
		{
			return default(double);
		}

		[Token(Token = "0x600094D")]
		public DefaultMovieManager()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public class MovieManager<T> : SingletonMonoBehaviour<T> where T : MovieManager<T>
	{
		[Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class <RequestCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x17000116")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000969")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000117")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000966")]
			[DebuggerHidden]
			public <RequestCoroutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000967")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000968")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A50")]
		protected const int RENDER_TEX_WIDTH = 3840;

		[Token(Token = "0x4000A51")]
		protected const int RENDER_TEX_HEIGHT = 2160;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool m_isPause;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Action m_onPlayAction;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Action m_onEndAction;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool m_isLoading;

		[Token(Token = "0x17000115")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000958")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000959")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600095A")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x600095B")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600095C")]
		public void Play(string moviePath, string assetName, Action onPlayAction, Action onEndAction, bool isPreinstall)
		{
		}

		[Token(Token = "0x600095D")]
		[IteratorStateMachine(typeof(MovieManager<>.<RequestCoroutine>d__13))]
		protected virtual IEnumerator RequestCoroutine(string path, string assetName, bool isPreinstall)
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		public virtual void Pause()
		{
		}

		[Token(Token = "0x600095F")]
		public virtual void Resume()
		{
		}

		[Token(Token = "0x6000960")]
		public virtual void Stop()
		{
		}

		[Token(Token = "0x6000961")]
		public virtual void ClearTexture()
		{
		}

		[Token(Token = "0x6000962")]
		public virtual void SetVolume(float volume)
		{
		}

		[Token(Token = "0x6000963")]
		public virtual void SetVideoClipPosition(double normalizedPosition)
		{
		}

		[Token(Token = "0x6000964")]
		public virtual double GetVideoClipNormalizedPosition()
		{
			return default(double);
		}

		[Token(Token = "0x6000965")]
		public MovieManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001C2")]
	public class FontParameter : ScriptableObject
	{
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_FontAsset m_defaltFontAsset;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset m_jpFont;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset m_enFont;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_FontAsset m_tcFont;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TMP_FontAsset m_scFont;

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x81C3DC", Offset = "0x81C3DC", VA = "0x81C3DC")]
		public FontParameter()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class ScriptableAssetParameter : ScriptableObject
	{
		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Sprite> m_sprites;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Material> m_materials;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PhysicMaterial> m_PhisicMaterials;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Texture2D> m_fakePyokoTexs;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Texture> m_textures;

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x81C3E4", Offset = "0x81C3E4", VA = "0x81C3E4")]
		public ScriptableAssetParameter()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class BasePlatform
	{
		[Token(Token = "0x20001C5")]
		public enum eDLC
		{
			[Token(Token = "0x4000A6B")]
			Invalid = 0,
			[Token(Token = "0x4000A6C")]
			MUSIC_001 = 1,
			[Token(Token = "0x4000A6D")]
			MUSIC_002 = 2,
			[Token(Token = "0x4000A6E")]
			MUSIC_003 = 3,
			[Token(Token = "0x4000A6F")]
			MUSIC_004 = 4,
			[Token(Token = "0x4000A70")]
			MUSIC_005 = 5,
			[Token(Token = "0x4000A71")]
			MUSIC_006 = 6,
			[Token(Token = "0x4000A72")]
			MUSIC_007 = 7,
			[Token(Token = "0x4000A73")]
			MUSIC_008 = 8,
			[Token(Token = "0x4000A74")]
			MUSIC_009 = 9,
			[Token(Token = "0x4000A75")]
			MUSIC_010 = 10,
			[Token(Token = "0x4000A76")]
			MUSIC_011 = 11,
			[Token(Token = "0x4000A77")]
			MUSIC_012 = 12,
			[Token(Token = "0x4000A78")]
			MUSIC_013 = 13,
			[Token(Token = "0x4000A79")]
			DEFAULT_MUSIC_001 = 500,
			[Token(Token = "0x4000A7A")]
			DEFAULT_MUSIC_002 = 501,
			[Token(Token = "0x4000A7B")]
			MUSIC_FULL = 1000,
			[Token(Token = "0x4000A7C")]
			COSTUME_001 = 2000,
			[Token(Token = "0x4000A7D")]
			COSTUME_002 = 2001
		}

		[Token(Token = "0x20001C6")]
		public enum eIAPStatus
		{
			[Token(Token = "0x4000A7F")]
			Invalid,
			[Token(Token = "0x4000A80")]
			Free,
			[Token(Token = "0x4000A81")]
			Entitled,
			[Token(Token = "0x4000A82")]
			NotEntitled
		}

		[Token(Token = "0x20001C7")]
		public enum eDownloadStatus
		{
			[Token(Token = "0x4000A84")]
			Invalid,
			[Token(Token = "0x4000A85")]
			Installed,
			[Token(Token = "0x4000A86")]
			Available,
			[Token(Token = "0x4000A87")]
			InProgress
		}

		[Token(Token = "0x20001C8")]
		public enum eTrophy
		{
			[Token(Token = "0x4000A89")]
			Combo_100,
			[Token(Token = "0x4000A8A")]
			Combo_500,
			[Token(Token = "0x4000A8B")]
			Easy_Rank_S,
			[Token(Token = "0x4000A8C")]
			Normal_Rank_S,
			[Token(Token = "0x4000A8D")]
			Hard_Rank_S,
			[Token(Token = "0x4000A8E")]
			Rank_SS,
			[Token(Token = "0x4000A8F")]
			Random_Rank_SS,
			[Token(Token = "0x4000A90")]
			ViewMode_Play,
			[Token(Token = "0x4000A91")]
			ViewMode_Move,
			[Token(Token = "0x4000A92")]
			MiniAi_LookAt,
			[Token(Token = "0x4000A93")]
			Invalid
		}

		[Token(Token = "0x20001C9")]
		public class BaseProductData
		{
			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<eIAPStatus> OnChangeIAPStatus;

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<eDownloadStatus> OnChangeDownloadStatus;

			[Token(Token = "0x1700011C")]
			public eDLC Dlc
			{
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x81CA24", Offset = "0x81CA24", VA = "0x81CA24")]
				[CompilerGenerated]
				get
				{
					return default(eDLC);
				}
				[Token(Token = "0x6000998")]
				[Address(RVA = "0x81CA2C", Offset = "0x81CA2C", VA = "0x81CA2C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			public string Price
			{
				[Token(Token = "0x6000999")]
				[Address(RVA = "0x81CA34", Offset = "0x81CA34", VA = "0x81CA34")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600099A")]
				[Address(RVA = "0x81CA3C", Offset = "0x81CA3C", VA = "0x81CA3C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x1700011E")]
			public eIAPStatus IAPStatus
			{
				[Token(Token = "0x600099B")]
				[Address(RVA = "0x81CA44", Offset = "0x81CA44", VA = "0x81CA44")]
				[CompilerGenerated]
				get
				{
					return default(eIAPStatus);
				}
				[Token(Token = "0x600099C")]
				[Address(RVA = "0x81CA4C", Offset = "0x81CA4C", VA = "0x81CA4C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x1700011F")]
			public eDownloadStatus DownloadStatus
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x81CA54", Offset = "0x81CA54", VA = "0x81CA54")]
				[CompilerGenerated]
				get
				{
					return default(eDownloadStatus);
				}
				[Token(Token = "0x600099E")]
				[Address(RVA = "0x81CA5C", Offset = "0x81CA5C", VA = "0x81CA5C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x17000120")]
			public uint DataBytesTotal
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x81CA64", Offset = "0x81CA64", VA = "0x81CA64")]
				[CompilerGenerated]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x81CA6C", Offset = "0x81CA6C", VA = "0x81CA6C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x17000121")]
			public int DataBytesTransferred
			{
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0x81CA74", Offset = "0x81CA74", VA = "0x81CA74")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x81CA7C", Offset = "0x81CA7C", VA = "0x81CA7C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x17000122")]
			public bool IsCanDownload
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x81CAB0", Offset = "0x81CAB0", VA = "0x81CAB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0x81CAB8", Offset = "0x81CAB8", VA = "0x81CAB8")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x81CA84", Offset = "0x81CA84", VA = "0x81CA84")]
			public BaseProductData()
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x81CAC4", Offset = "0x81CAC4", VA = "0x81CAC4")]
			public void AlreadyDownload()
			{
			}
		}

		[Token(Token = "0x4000A63")]
		private const string KEY = "HDfEkDEGtXa8u9zy";

		[Token(Token = "0x4000A64")]
		private const string IV = "LrRsM8cfhcNKyjYd";

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<BaseProductData> m_productList;

		[Token(Token = "0x17000118")]
		public bool IsDLCInitialize
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x81C3EC", Offset = "0x81C3EC", VA = "0x81C3EC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x81C3F4", Offset = "0x81C3F4", VA = "0x81C3F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public bool IsVRInitializeCompleted
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x81C400", Offset = "0x81C400", VA = "0x81C400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x81C408", Offset = "0x81C408", VA = "0x81C408")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		protected GameObject EntitlementCheckedObject
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x81C414", Offset = "0x81C414", VA = "0x81C414")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x81C41C", Offset = "0x81C41C", VA = "0x81C41C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsEntitlementCheckCompleted
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x81C424", Offset = "0x81C424", VA = "0x81C424")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x81C42C", Offset = "0x81C42C", VA = "0x81C42C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x81C438", Offset = "0x81C438", VA = "0x81C438", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x81C4A0", Offset = "0x81C4A0", VA = "0x81C4A0", Slot = "5")]
		public virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x81C4A4", Offset = "0x81C4A4", VA = "0x81C4A4", Slot = "6")]
		public virtual void BuyDLC(eDLC dlc, Action<bool> onEndCallback)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x81C4C0", Offset = "0x81C4C0", VA = "0x81C4C0")]
		public BaseProductData GetData(eDLC dlc)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x81C588", Offset = "0x81C588", VA = "0x81C588", Slot = "7")]
		public virtual bool IsHaveDLC(eDLC dlc)
		{
			return default(bool);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x81C590", Offset = "0x81C590", VA = "0x81C590", Slot = "8")]
		public virtual void AddRecenterdAction(Action action)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x81C594", Offset = "0x81C594", VA = "0x81C594", Slot = "9")]
		public virtual void RemoveRecenterdAction(Action action)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x81C598", Offset = "0x81C598", VA = "0x81C598", Slot = "10")]
		public virtual void DownloadMovie(eDLC dlc)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x81C59C", Offset = "0x81C59C", VA = "0x81C59C", Slot = "11")]
		public virtual void DeleteDLCOBBFile(eDLC dlc)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x81C5A0", Offset = "0x81C5A0", VA = "0x81C5A0", Slot = "12")]
		public virtual bool Save(string data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x81C67C", Offset = "0x81C67C", VA = "0x81C67C", Slot = "13")]
		public virtual bool Save(ref byte[] data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x81C684", Offset = "0x81C684", VA = "0x81C684", Slot = "14")]
		public virtual bool Load(ref string dataStr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x81C770", Offset = "0x81C770", VA = "0x81C770", Slot = "15")]
		public virtual bool Load(ref byte[] data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x81C778", Offset = "0x81C778", VA = "0x81C778", Slot = "16")]
		public virtual void OnEndSaveLoaded()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x81C5F8", Offset = "0x81C5F8", VA = "0x81C5F8")]
		private string GetDataPath(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x81C948", Offset = "0x81C948", VA = "0x81C948", Slot = "17")]
		public virtual void DeleteSaveData()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x81C94C", Offset = "0x81C94C", VA = "0x81C94C", Slot = "18")]
		public virtual void UnlockTrophy(eTrophy trophy)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x81C950", Offset = "0x81C950", VA = "0x81C950", Slot = "19")]
		public virtual void AddRecenteredAction(Action action)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x81C954", Offset = "0x81C954", VA = "0x81C954", Slot = "20")]
		public virtual void AddFocusLostEvent(Action lostAction)
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x81C958", Offset = "0x81C958", VA = "0x81C958", Slot = "21")]
		public virtual void RemoveFocusLostEvent(Action lostAction)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x81C95C", Offset = "0x81C95C", VA = "0x81C95C", Slot = "22")]
		public virtual void AddFocusEvent(Action lostAction)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x81C960", Offset = "0x81C960", VA = "0x81C960", Slot = "23")]
		public virtual void RemoveFocusEvent(Action lostAction)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x81C964", Offset = "0x81C964", VA = "0x81C964", Slot = "24")]
		public virtual void AddHMDUnmounted(Action action)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x81C968", Offset = "0x81C968", VA = "0x81C968", Slot = "25")]
		public virtual void AddHMDMounted(Action action)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x81C96C", Offset = "0x81C96C", VA = "0x81C96C", Slot = "26")]
		public virtual void RemoveHMDUnmounted(Action action)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x81C970", Offset = "0x81C970", VA = "0x81C970", Slot = "27")]
		public virtual void RemoveHMDMounted(Action action)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x81C974", Offset = "0x81C974", VA = "0x81C974", Slot = "28")]
		public virtual void ChangeVRMode()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x81C978", Offset = "0x81C978", VA = "0x81C978", Slot = "29")]
		public virtual bool IsMoveControllerConnected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x81C980", Offset = "0x81C980", VA = "0x81C980", Slot = "30")]
		public virtual int GetMoveConnectedCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x81C988", Offset = "0x81C988", VA = "0x81C988", Slot = "31")]
		public virtual bool IsHMDConnected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x81C990", Offset = "0x81C990", VA = "0x81C990", Slot = "32")]
		public virtual int GetEnterButtonAssign()
		{
			return default(int);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x81C998", Offset = "0x81C998", VA = "0x81C998", Slot = "33")]
		public virtual void TryChangeVRMode()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x81C99C", Offset = "0x81C99C", VA = "0x81C99C")]
		public BasePlatform()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class DebugPlatform : BasePlatform
	{
		[Token(Token = "0x20001CB")]
		public class DebugProductData : BaseProductData
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x81D614", Offset = "0x81D614", VA = "0x81D614")]
			public DebugProductData(eDLC dlc)
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x81D6A0", Offset = "0x81D6A0", VA = "0x81D6A0")]
			public void SetPurchase()
			{
			}
		}

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ScriptableDebugDLCParameter m_dlc;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x81CAD0", Offset = "0x81CAD0", VA = "0x81CAD0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x81D6D4", Offset = "0x81D6D4", VA = "0x81D6D4", Slot = "6")]
		public override void BuyDLC(eDLC dlc, Action<bool> onEndCallback)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x81D848", Offset = "0x81D848", VA = "0x81D848", Slot = "5")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x81D978", Offset = "0x81D978", VA = "0x81D978", Slot = "7")]
		public override bool IsHaveDLC(eDLC dlc)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x81DA44", Offset = "0x81DA44", VA = "0x81DA44")]
		public DebugPlatform()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public class OculusPlatform : BasePlatform
	{
		[Token(Token = "0x20001CD")]
		public class DLC
		{
			[Token(Token = "0x4000AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public eDLC m_dlc;

			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string m_sku;

			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string m_assetFileName;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x8220E4", Offset = "0x8220E4", VA = "0x8220E4")]
			public DLC(eDLC dlc, string sku, string assetFileName)
			{
			}
		}

		[Token(Token = "0x20001CE")]
		public class Bundle
		{
			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private eDLC[] m_itemArray;

			[Token(Token = "0x17000123")]
			public eDLC Dlc
			{
				[Token(Token = "0x60009D3")]
				[Address(RVA = "0x82218C", Offset = "0x82218C", VA = "0x82218C")]
				[CompilerGenerated]
				get
				{
					return default(eDLC);
				}
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x822194", Offset = "0x822194", VA = "0x822194")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000124")]
			public string ViewName
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x82219C", Offset = "0x82219C", VA = "0x82219C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60009D6")]
				[Address(RVA = "0x8221A4", Offset = "0x8221A4", VA = "0x8221A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x822138", Offset = "0x822138", VA = "0x822138")]
			public Bundle(eDLC dlc, string viewName, eDLC[] itemArray)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x81FB08", Offset = "0x81FB08", VA = "0x81FB08")]
			public void SetPurchase(OculusPlatform platform)
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x8221AC", Offset = "0x8221AC", VA = "0x8221AC")]
			public bool Contains(eDLC dlc)
			{
				return default(bool);
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x820E2C", Offset = "0x820E2C", VA = "0x820E2C")]
			public bool IsHave(OculusPlatform platform)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001CF")]
		public class OculusProductData : BaseProductData
		{
			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ulong AssetFileId;

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x81F72C", Offset = "0x81F72C", VA = "0x81F72C")]
			public OculusProductData(Product product)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x820460", Offset = "0x820460", VA = "0x820460")]
			public OculusProductData(string sku)
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x81F9DC", Offset = "0x81F9DC", VA = "0x81F9DC")]
			public void SetPurchase()
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x8204E8", Offset = "0x8204E8", VA = "0x8204E8")]
			public void SetIAPStatus(eIAPStatus status)
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x81ECFC", Offset = "0x81ECFC", VA = "0x81ECFC")]
			public void SetDownloadStatus(eDownloadStatus status)
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x822208", Offset = "0x822208", VA = "0x822208")]
			private void StatusByNameCallback(Message<AssetDetails> msg)
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x81DC80", Offset = "0x81DC80", VA = "0x81DC80")]
			public void DownloadAssets()
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x822340", Offset = "0x822340", VA = "0x822340")]
			private void DownloadByNameCallback(Message<AssetFileDownloadResult> msg)
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x81E168", Offset = "0x81E168", VA = "0x81E168")]
			public void SetDownloadUpdateNotification(uint total, int transferred, bool isCompleted)
			{
			}
		}

		[Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private sealed class <InitliazeCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OculusPlatform <>4__this;

			[Token(Token = "0x17000125")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E7")]
				[Address(RVA = "0x822680", Offset = "0x822680", VA = "0x822680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000126")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E9")]
				[Address(RVA = "0x8226C8", Offset = "0x8226C8", VA = "0x8226C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x81DB50", Offset = "0x81DB50", VA = "0x81DB50")]
			[DebuggerHidden]
			public <InitliazeCoroutine>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x8223E0", Offset = "0x8223E0", VA = "0x8223E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x8223E4", Offset = "0x8223E4", VA = "0x8223E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x822688", Offset = "0x822688", VA = "0x822688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A9E")]
		private const string BUNDLE_ALL_01_SKU = "global_pack_4";

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<DLC> DLC_LIST;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Bundle[] DLC_BUNDLE_ARRAY;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<bool> m_buyDLCCallback;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private eDLC m_keepCheckoutDLC;

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x81DA48", Offset = "0x81DA48", VA = "0x81DA48", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x81DADC", Offset = "0x81DADC", VA = "0x81DADC")]
		[IteratorStateMachine(typeof(<InitliazeCoroutine>d__9))]
		private IEnumerator InitliazeCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x81DB78", Offset = "0x81DB78", VA = "0x81DB78", Slot = "10")]
		public override void DownloadMovie(eDLC dlc)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x81DDA4", Offset = "0x81DDA4", VA = "0x81DDA4")]
		private void InitDLCCheck()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x81DFB4", Offset = "0x81DFB4", VA = "0x81DFB4")]
		private void DownloadUpdateNotificationCallback(Message<AssetFileDownloadUpdate> msg)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x81E1A4", Offset = "0x81E1A4", VA = "0x81E1A4")]
		private void DeleteDLCOBBFileAll()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x81E9A4", Offset = "0x81E9A4", VA = "0x81E9A4", Slot = "11")]
		public override void DeleteDLCOBBFile(eDLC dlc)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x81ED28", Offset = "0x81ED28", VA = "0x81ED28")]
		private void GetListCallback(Message<AssetDetailsList> msg)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x81EFC0", Offset = "0x81EFC0", VA = "0x81EFC0")]
		public static void DownloadByIdCallback(Message<AssetFileDownloadResult> msg)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x81EFFC", Offset = "0x81EFFC", VA = "0x81EFFC")]
		private void GetProductsBySKUCallback(Message<ProductList> msg)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x81F7C8", Offset = "0x81F7C8", VA = "0x81F7C8")]
		private void SetPurchase(eDLC dlc)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x81FB6C", Offset = "0x81FB6C", VA = "0x81FB6C")]
		private void GetViewerPurchasesCallback(Message<PurchaseList> msg)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x81FF04", Offset = "0x81FF04", VA = "0x81FF04")]
		private void GetViewerPurchasesDurableCacheCallback(Message<PurchaseList> msg)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x81F684", Offset = "0x81F684", VA = "0x81F684")]
		private bool IsContainsProductList(eDLC dlc)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x820630", Offset = "0x820630", VA = "0x820630", Slot = "6")]
		public override void BuyDLC(eDLC dlc, Action<bool> onEndCallback)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x820874", Offset = "0x820874", VA = "0x820874")]
		private void LaunchCheckoutFlow(Message<Purchase> msg)
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x820754", Offset = "0x820754", VA = "0x820754")]
		private string DLCToSKU(eDLC dlc)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x81F560", Offset = "0x81F560", VA = "0x81F560")]
		private static eDLC SKUToDLC(string sku)
		{
			return default(eDLC);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x820514", Offset = "0x820514", VA = "0x820514")]
		private static string DLCToAssetFileName(eDLC dlc)
		{
			return null;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x820ADC", Offset = "0x820ADC", VA = "0x820ADC")]
		private static eIAPStatus ToIAPStatus(string status)
		{
			return default(eIAPStatus);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x820B98", Offset = "0x820B98", VA = "0x820B98")]
		private static eDownloadStatus ToDownloadStatus(string status)
		{
			return default(eDownloadStatus);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x820C54", Offset = "0x820C54", VA = "0x820C54", Slot = "7")]
		public override bool IsHaveDLC(eDLC dlc)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x820EA8", Offset = "0x820EA8", VA = "0x820EA8", Slot = "8")]
		public override void AddRecenterdAction(Action action)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x820F44", Offset = "0x820F44", VA = "0x820F44", Slot = "9")]
		public override void RemoveRecenterdAction(Action action)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x820FE0", Offset = "0x820FE0", VA = "0x820FE0", Slot = "16")]
		public override void OnEndSaveLoaded()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x821064", Offset = "0x821064", VA = "0x821064", Slot = "19")]
		public override void AddRecenteredAction(Action action)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x821154", Offset = "0x821154", VA = "0x821154", Slot = "20")]
		public override void AddFocusLostEvent(Action lostAction)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x8211AC", Offset = "0x8211AC", VA = "0x8211AC", Slot = "21")]
		public override void RemoveFocusLostEvent(Action lostAction)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x821204", Offset = "0x821204", VA = "0x821204", Slot = "22")]
		public override void AddFocusEvent(Action lostAction)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x82125C", Offset = "0x82125C", VA = "0x82125C", Slot = "23")]
		public override void RemoveFocusEvent(Action lostAction)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x8212B4", Offset = "0x8212B4", VA = "0x8212B4", Slot = "24")]
		public override void AddHMDUnmounted(Action action)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x82130C", Offset = "0x82130C", VA = "0x82130C", Slot = "25")]
		public override void AddHMDMounted(Action action)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x821364", Offset = "0x821364", VA = "0x821364", Slot = "26")]
		public override void RemoveHMDUnmounted(Action action)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x8213BC", Offset = "0x8213BC", VA = "0x8213BC", Slot = "27")]
		public override void RemoveHMDMounted(Action action)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x821414", Offset = "0x821414", VA = "0x821414")]
		public OculusPlatform()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class ResourceManager : SingletonMonoBehaviour<ResourceManager>
	{
		[Token(Token = "0x20001D2")]
		public enum eResourceType
		{
			[Token(Token = "0x4000AB5")]
			Dynamic,
			[Token(Token = "0x4000AB6")]
			Static,
			[Token(Token = "0x4000AB7")]
			MusicGame,
			[Token(Token = "0x4000AB8")]
			Movie
		}

		[Token(Token = "0x20001D3")]
		public class Data
		{
			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_name;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public eResourceType m_resourceType;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityEngine.Object m_object;

			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AssetBundleData m_parent;

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x82384C", Offset = "0x82384C", VA = "0x82384C")]
			public Data()
			{
			}
		}

		[Token(Token = "0x20001D4")]
		public class LoadData : Data
		{
			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string m_path;

			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action m_onLoaded;

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool m_isObb;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public AssetBundleCreateRequest m_request;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public AssetBundleRequest m_assetRequest;

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x822C04", Offset = "0x822C04", VA = "0x822C04")]
			public LoadData()
			{
			}
		}

		[Token(Token = "0x20001D5")]
		public class AssetBundleData
		{
			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_path;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AssetBundle m_assetBundle;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int m_referenceCount;

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x823844", Offset = "0x823844", VA = "0x823844")]
			public AssetBundleData()
			{
			}
		}

		[Token(Token = "0x20001DB")]
		[CompilerGenerated]
		private sealed class <LoadOBBCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceManager <>4__this;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AssetBundleCreateRequest <abRequest>5__2;

			[Token(Token = "0x17000129")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x824188", Offset = "0x824188", VA = "0x824188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A10")]
				[Address(RVA = "0x8241D0", Offset = "0x8241D0", VA = "0x8241D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x823ABC", Offset = "0x823ABC", VA = "0x823ABC")]
			[DebuggerHidden]
			public <LoadOBBCoroutine>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x823FC8", Offset = "0x823FC8", VA = "0x823FC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x823FCC", Offset = "0x823FCC", VA = "0x823FCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x824190", Offset = "0x824190", VA = "0x824190", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001DE")]
		[CompilerGenerated]
		private sealed class <LoadMovieCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceManager <>4__this;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string fileName;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<VideoClip> onLoaded;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundleRequest <request>5__2;

			[Token(Token = "0x1700012B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x824420", Offset = "0x824420", VA = "0x824420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0x824468", Offset = "0x824468", VA = "0x824468", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x823D28", Offset = "0x823D28", VA = "0x823D28")]
			[DebuggerHidden]
			public <LoadMovieCoroutine>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x824310", Offset = "0x824310", VA = "0x824310", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x824314", Offset = "0x824314", VA = "0x824314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x824428", Offset = "0x824428", VA = "0x824428", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AAD")]
		private const int MAX_SAME_LOAD_NUM = 16;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Data> m_loadedList;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<LoadData> m_loadingList;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<LoadData> m_requestList;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<AssetBundleData> m_assetBundleList;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AssetBundle m_movieAssetBundle;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_obbPath;

		[Token(Token = "0x17000127")]
		public bool IsLoading
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x8226D0", Offset = "0x8226D0", VA = "0x8226D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public string ObbPath
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x81E3AC", Offset = "0x81E3AC", VA = "0x81E3AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x82273C", Offset = "0x82273C", VA = "0x82273C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x822740", Offset = "0x822740", VA = "0x822740")]
		public void LoadRequest(string path, [Optional] Action onLoaded, eResourceType type = eResourceType.Dynamic, bool isObb = false)
		{
		}

		[Token(Token = "0x60009EE")]
		public bool GetResource<T>(string path, Action<T> action) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x822C0C", Offset = "0x822C0C", VA = "0x822C0C")]
		public bool IsLoaded(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x822D44", Offset = "0x822D44", VA = "0x822D44")]
		public bool IsLoadedAssetBundle(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x822E7C", Offset = "0x822E7C", VA = "0x822E7C")]
		public void Unload(string path)
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x823088", Offset = "0x823088", VA = "0x823088")]
		public void Unload(eResourceType unloadType)
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x8232D8", Offset = "0x8232D8", VA = "0x8232D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x823854", Offset = "0x823854", VA = "0x823854")]
		private void Load(LoadData request)
		{
		}

		[Token(Token = "0x60009F5")]
		public T DirectLoad<T>(string path, eResourceType type = eResourceType.Static) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x823A28", Offset = "0x823A28", VA = "0x823A28")]
		private void LoadOBB()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x823A48", Offset = "0x823A48", VA = "0x823A48")]
		[IteratorStateMachine(typeof(<LoadOBBCoroutine>d__26))]
		private IEnumerator LoadOBBCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x823AE4", Offset = "0x823AE4", VA = "0x823AE4")]
		public void LoadMovie(string fileName, string assetName, Action<VideoClip> onLoaded, bool isPreinstall)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x823C84", Offset = "0x823C84", VA = "0x823C84")]
		[IteratorStateMachine(typeof(<LoadMovieCoroutine>d__28))]
		private IEnumerator LoadMovieCoroutine(string fileName, Action<VideoClip> onLoaded, bool isPreinstall)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x823D50", Offset = "0x823D50", VA = "0x823D50")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class SoundComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x20001E0")]
		public enum SoundType
		{
			[Token(Token = "0x4000AE0")]
			Se,
			[Token(Token = "0x4000AE1")]
			Bgm,
			[Token(Token = "0x4000AE2")]
			Voice
		}

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SoundType m_type;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource m_audioSource;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InterpolatorFloat m_interpolator;

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_localVolume;

		[Token(Token = "0x1700012D")]
		public float LocalVolume
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x824470", Offset = "0x824470", VA = "0x824470")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x824478", Offset = "0x824478", VA = "0x824478")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public bool IsLoading
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x8244B4", Offset = "0x8244B4", VA = "0x8244B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x8244BC", Offset = "0x8244BC", VA = "0x8244BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x8244C8", Offset = "0x8244C8", VA = "0x8244C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public bool IsPause
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x824564", Offset = "0x824564", VA = "0x824564")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x82456C", Offset = "0x82456C", VA = "0x82456C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public Action EndAction
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x824578", Offset = "0x824578", VA = "0x824578")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x824580", Offset = "0x824580", VA = "0x824580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x824588", Offset = "0x824588", VA = "0x824588", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x8245E4", Offset = "0x8245E4", VA = "0x8245E4")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x824684", Offset = "0x824684", VA = "0x824684")]
		public void PlayVoice(VoiceParam param)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x8248DC", Offset = "0x8248DC", VA = "0x8248DC")]
		public void PlayOtherVoice(SEParam param)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x824C00", Offset = "0x824C00", VA = "0x824C00")]
		public void PlaySE(SEParam param)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x824F20", Offset = "0x824F20", VA = "0x824F20")]
		public void PlayBGM(BGMParam param)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x825168", Offset = "0x825168", VA = "0x825168")]
		public void PlayDirect(AudioClip clip, SoundType type)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x8251BC", Offset = "0x8251BC", VA = "0x8251BC")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x8251E4", Offset = "0x8251E4", VA = "0x8251E4")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x825208", Offset = "0x825208", VA = "0x825208")]
		public void SetFade(float end, float time, [Optional] Action onEndFade)
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x82533C", Offset = "0x82533C", VA = "0x82533C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x824480", Offset = "0x824480", VA = "0x824480")]
		public void UpdateVolume()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x8252A4", Offset = "0x8252A4", VA = "0x8252A4")]
		private float GetTypeVolume()
		{
			return default(float);
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x825398", Offset = "0x825398", VA = "0x825398")]
		public AudioSource GetAudioSouce()
		{
			return null;
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x8253A0", Offset = "0x8253A0", VA = "0x8253A0")]
		public SoundComponent()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	public class SoundManager : SingletonMonoBehaviour<SoundManager>
	{
		[Token(Token = "0x4000AF3")]
		public const string SOUND_PREFAB_PATH = "Prefab/Sound";

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<string> MIXER_GROUP_NAME_ARRAY;

		[Token(Token = "0x4000AF5")]
		private const int MAX_SE_NUM = 32;

		[Token(Token = "0x4000AF6")]
		private const int MAX_BGM_NUM = 2;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SoundComponent[] m_seArray;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SoundComponent[] m_bgmArray;

		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SoundComponent m_voice;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_nonUsedSeIndex;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_currentBGMIndex;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform m_charaVoiceTrans;

		[Token(Token = "0x17000132")]
		public float SeVolume
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x825940", Offset = "0x825940", VA = "0x825940")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x825948", Offset = "0x825948", VA = "0x825948")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public float BgmVolume
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x825950", Offset = "0x825950", VA = "0x825950")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x825958", Offset = "0x825958", VA = "0x825958")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public float VoiceVolume
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x825960", Offset = "0x825960", VA = "0x825960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x825968", Offset = "0x825968", VA = "0x825968")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public AudioMixer Mixer
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x825970", Offset = "0x825970", VA = "0x825970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x825978", Offset = "0x825978", VA = "0x825978")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public SoundComponent CurrentBGM
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x825980", Offset = "0x825980", VA = "0x825980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x8259B4", Offset = "0x8259B4", VA = "0x8259B4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x825D24", Offset = "0x825D24", VA = "0x825D24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x82600C", Offset = "0x82600C", VA = "0x82600C")]
		public void StopAllSE()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x826128", Offset = "0x826128", VA = "0x826128")]
		public SoundComponent PlaySE(SEParam param)
		{
			return null;
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x826194", Offset = "0x826194", VA = "0x826194")]
		public SoundComponent PlayOtherVoice(SEParam param)
		{
			return null;
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x826200", Offset = "0x826200", VA = "0x826200")]
		public void PlayBGM(BGMParam param)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x826380", Offset = "0x826380", VA = "0x826380")]
		public void StopBGM()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x826430", Offset = "0x826430", VA = "0x826430")]
		public void SetVoiceTransform(Transform trans)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x826438", Offset = "0x826438", VA = "0x826438")]
		public AudioSource GetVoiceAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x826454", Offset = "0x826454", VA = "0x826454")]
		public SoundComponent PlayVoice(VoiceParam param)
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x82668C", Offset = "0x82668C", VA = "0x82668C")]
		public bool IsPlayingVoice()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x8266B8", Offset = "0x8266B8", VA = "0x8266B8")]
		public void SetVoiceVolume(float value)
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x826724", Offset = "0x826724", VA = "0x826724")]
		public void SetSeVolume(float value)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x826784", Offset = "0x826784", VA = "0x826784")]
		public void SetBgmVolume(float value)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x8267E4", Offset = "0x8267E4", VA = "0x8267E4")]
		public SoundManager()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	public abstract class SoundParam
	{
		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_fileName;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_volume;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_isLoop;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action m_endAction;

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x826AA8", Offset = "0x826AA8", VA = "0x826AA8")]
		protected SoundParam()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public class BGMParam : SoundParam
	{
		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_fadeTime;

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x826AB0", Offset = "0x826AB0", VA = "0x826AB0")]
		public BGMParam(string fileName, float volume = 1f, bool isLoop = true, float fadeTime = 2f)
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class SEParam : SoundParam
	{
		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_is3D;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 m_pos;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform m_transform;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float m_pitch;

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x8265E4", Offset = "0x8265E4", VA = "0x8265E4")]
		public SEParam(string fileName, float volume = 1f, bool isLoop = false)
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x826B04", Offset = "0x826B04", VA = "0x826B04")]
		public void Set3D(Vector3 pos)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x826B18", Offset = "0x826B18", VA = "0x826B18")]
		public void Set3D(Transform transform)
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public class VoiceParam : SoundParam
	{
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x826B28", Offset = "0x826B28", VA = "0x826B28")]
		public VoiceParam(string fileName, float volume = 1f)
		{
		}
	}
	[Token(Token = "0x20001EC")]
	public class SubtitleComponent : BaseMonoBehaviour
	{
		[Token(Token = "0x4000B0C")]
		private const float INSIDE_X_RATE = 0.1f;

		[Token(Token = "0x4000B0D")]
		private const float INSIDE_Y_RATE = 0.05f;

		[Token(Token = "0x4000B0E")]
		private const float DIST_TO_CAMERA = 0.5f;

		[Token(Token = "0x4000B0F")]
		private const float MOVE_X_RATE_PER_SEC = 0.1f;

		[Token(Token = "0x4000B10")]
		private const float MOVE_Y_RATE_PER_SEC = 0.03f;

		[Token(Token = "0x4000B11")]
		private const float CENTER_RATE = 0.01f;

		[Token(Token = "0x4000B12")]
		private const float OFFSET_Y = -0.13f;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text m_text;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_isCentering;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_isPlayingVoice;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource m_voiceSource;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_showTimer;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x826B70", Offset = "0x826B70", VA = "0x826B70")]
		public void Start()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x826C5C", Offset = "0x826C5C", VA = "0x826C5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x826C7C", Offset = "0x826C7C", VA = "0x826C7C")]
		private void MoveUpdate()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x826E58", Offset = "0x826E58", VA = "0x826E58")]
		private void AngleUpdate()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x826F1C", Offset = "0x826F1C", VA = "0x826F1C")]
		private void CheckEnd()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x826FF4", Offset = "0x826FF4", VA = "0x826FF4")]
		public void SetText(string text, float time)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x827000", Offset = "0x827000", VA = "0x827000")]
		public void SetText(string text, [Optional] AudioSource source)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x826C18", Offset = "0x826C18", VA = "0x826C18")]
		public void Close()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x827148", Offset = "0x827148", VA = "0x827148")]
		public void SetEnableView(bool isEnable)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x827168", Offset = "0x827168", VA = "0x827168")]
		public SubtitleComponent()
		{
		}
	}
	[Token(Token = "0x20001ED")]
	public abstract class BaseMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject m_gameObject;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer m_renderer;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider m_collider;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_rigidbody;

		[Token(Token = "0x17000137")]
		public new GameObject gameObject
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x817C1C", Offset = "0x817C1C", VA = "0x817C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public new Transform transform
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x8175B0", Offset = "0x8175B0", VA = "0x8175B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public Renderer renderer
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x827170", Offset = "0x827170", VA = "0x827170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		public Collider collider
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x827218", Offset = "0x827218", VA = "0x827218")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x8272C0", Offset = "0x8272C0", VA = "0x8272C0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public Animator animator
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x8272C8", Offset = "0x8272C8", VA = "0x8272C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x827370", Offset = "0x827370", VA = "0x827370")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x827378", Offset = "0x827378", VA = "0x827378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x8245E0", Offset = "0x8245E0", VA = "0x8245E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x827420", Offset = "0x827420", VA = "0x827420", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x81778C", Offset = "0x81778C", VA = "0x81778C")]
		protected BaseMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class FontManager : SingletonMonoBehaviour<FontManager>
	{
		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TMP_FontAsset m_defaultFont;

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x827424", Offset = "0x827424", VA = "0x827424")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x827448", Offset = "0x827448", VA = "0x827448", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x8274C0", Offset = "0x8274C0", VA = "0x8274C0")]
		public void ChangeFont(ProjectDefine.eLanguage language)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x8278F8", Offset = "0x8278F8", VA = "0x8278F8")]
		public FontManager()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	public class ProjectDefine
	{
		[Token(Token = "0x20001F0")]
		public enum eLanguage
		{
			[Token(Token = "0x4000B23")]
			Japanese,
			[Token(Token = "0x4000B24")]
			English,
			[Token(Token = "0x4000B25")]
			ChineseTC,
			[Token(Token = "0x4000B26")]
			ChineseSC,
			[Token(Token = "0x4000B27")]
			Max
		}

		[Token(Token = "0x4000B1F")]
		public const string PACKAGE_NAME = "com.activ8.kizunaaivr";

		[Token(Token = "0x4000B20")]
		public const string VERSION = "1.7";

		[Token(Token = "0x4000B21")]
		public const int VERSION_CODE = 70;

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x827940", Offset = "0x827940", VA = "0x827940")]
		public ProjectDefine()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public abstract class SingletonMonoBehaviour<T> : BaseMonoBehaviour where T : BaseMonoBehaviour
	{
		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T m_instance;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool m_isQuitting;

		[Token(Token = "0x1700013D")]
		public static T Instance
		{
			[Token(Token = "0x6000A7D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7E")]
		public static T CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000A7F")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A80")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000A81")]
		protected SingletonMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	public class StageSceneManager : SingletonMonoBehaviour<StageSceneManager>
	{
		[Token(Token = "0x20001F3")]
		[CompilerGenerated]
		private sealed class <LoadSceneCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public StageSceneManager <>4__this;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isFade;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private FadeManager <fadeMng>5__2;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <async>5__3;

			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceManager <resourceMng>5__4;

			[Token(Token = "0x17000141")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x828050", Offset = "0x828050", VA = "0x828050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A91")]
				[Address(RVA = "0x828098", Offset = "0x828098", VA = "0x828098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x827BD8", Offset = "0x827BD8", VA = "0x827BD8")]
			[DebuggerHidden]
			public <LoadSceneCoroutine>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x827C48", Offset = "0x827C48", VA = "0x827C48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x827C4C", Offset = "0x827C4C", VA = "0x827C4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x828058", Offset = "0x828058", VA = "0x828058", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Scene m_currentScene;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string m_nextSceneName;

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action m_onEndSceneLoad;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine m_loadCroutine;

		[Token(Token = "0x1700013E")]
		public Scene CurrentScene
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x827948", Offset = "0x827948", VA = "0x827948")]
			get
			{
				return default(Scene);
			}
		}

		[Token(Token = "0x1700013F")]
		public string BeforeSceneName
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x827950", Offset = "0x827950", VA = "0x827950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x827958", Offset = "0x827958", VA = "0x827958")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public bool IsFinishLoadScene
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x827960", Offset = "0x827960", VA = "0x827960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x827968", Offset = "0x827968", VA = "0x827968")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x827974", Offset = "0x827974", VA = "0x827974")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x8279D0", Offset = "0x8279D0", VA = "0x8279D0")]
		public bool IsGameScene()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x827A9C", Offset = "0x827A9C", VA = "0x827A9C")]
		public void ChangeScene(string sceneName, [Optional] Action onEndSceneLoad, bool isFade = false, bool isForce = false)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x827B50", Offset = "0x827B50", VA = "0x827B50")]
		[IteratorStateMachine(typeof(<LoadSceneCoroutine>d__17))]
		private IEnumerator LoadSceneCoroutine(bool isFade)
		{
			return null;
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x827C00", Offset = "0x827C00", VA = "0x827C00")]
		public StageSceneManager()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	public abstract class BaseState
	{
		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected StateMachine m_machine;

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x8280A0", Offset = "0x8280A0", VA = "0x8280A0", Slot = "4")]
		public virtual void OnEnter(StateMachine machine)
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x8280A8", Offset = "0x8280A8", VA = "0x8280A8", Slot = "5")]
		public virtual void Execute()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x8280AC", Offset = "0x8280AC", VA = "0x8280AC", Slot = "6")]
		public virtual void OnExit()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x8280B0", Offset = "0x8280B0", VA = "0x8280B0")]
		protected BaseState()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	public class StateMachine
	{
		[Token(Token = "0x17000143")]
		public BaseState CurrentState
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x8280B8", Offset = "0x8280B8", VA = "0x8280B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x8280C0", Offset = "0x8280C0", VA = "0x8280C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public BaseState NextState
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x8280C8", Offset = "0x8280C8", VA = "0x8280C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x8280D0", Offset = "0x8280D0", VA = "0x8280D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x8280D8", Offset = "0x8280D8", VA = "0x8280D8")]
		public StateMachine(BaseState startState)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x828104", Offset = "0x828104", VA = "0x828104")]
		public void ChangeState(BaseState nextState)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x828148", Offset = "0x828148", VA = "0x828148")]
		private void CheckChangeState()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x8281C8", Offset = "0x8281C8", VA = "0x8281C8")]
		public void OnUpdate()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	public class StrBuilder
	{
		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StringBuilder m_builder;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string m_cache;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x81C77C", Offset = "0x81C77C", VA = "0x81C77C")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x81C80C", Offset = "0x81C80C", VA = "0x81C80C")]
		public static void Append(string str)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x828200", Offset = "0x828200", VA = "0x828200")]
		public static void Append(char c)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x81C88C", Offset = "0x81C88C", VA = "0x81C88C")]
		public static string GetStr()
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x828280", Offset = "0x828280", VA = "0x828280")]
		public StrBuilder()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	public class VRManager : SingletonMonoBehaviour<VRManager>
	{
		[Token(Token = "0x20001F8")]
		public enum eFoveatedLevel
		{
			[Token(Token = "0x4000B3E")]
			Off,
			[Token(Token = "0x4000B3F")]
			Low,
			[Token(Token = "0x4000B40")]
			Medium,
			[Token(Token = "0x4000B41")]
			High,
			[Token(Token = "0x4000B42")]
			HighTop
		}

		[Token(Token = "0x4000B3C")]
		private const float RESOLUTION_SCALE = 1f;

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x828310", Offset = "0x828310", VA = "0x828310")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x828330", Offset = "0x828330", VA = "0x828330")]
		public void SetGPULevel(int value = 0)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x828388", Offset = "0x828388", VA = "0x828388")]
		public void SetCPULevel(int value = 0)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x8283E0", Offset = "0x8283E0", VA = "0x8283E0")]
		public void SetFoveatedLevel(eFoveatedLevel level)
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x8284E4", Offset = "0x8284E4", VA = "0x8284E4")]
		public VRManager()
		{
		}
	}
}
