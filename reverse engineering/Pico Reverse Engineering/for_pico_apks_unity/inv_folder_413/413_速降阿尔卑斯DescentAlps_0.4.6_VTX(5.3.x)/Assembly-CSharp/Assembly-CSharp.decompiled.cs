using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Il2CppDummyDll;
using LitJson;
using NLayer;
using NLayer.Decoder;
using Oculus.Platform;
using Oculus.Platform.Models;
using Oculus.Spatializer.Propagation;
using Pvr_UnitySDKAPI;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD3EC", Offset = "0x6CD3EC")]
public class FastList<T>
{
	[Token(Token = "0x2000130")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD71C", Offset = "0x6CD71C")]
	private sealed class <GetEnumerator>d__25 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FastList<T> <>4__this;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x17000103")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000A09")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000104")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A0B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A06")]
		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000A07")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A08")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0A")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] array;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x6000003")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public T Item
	{
		[Token(Token = "0x6000005")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000006")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	public FastList()
	{
	}

	[Token(Token = "0x6000002")]
	public FastList(int size)
	{
	}

	[Token(Token = "0x6000007")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000008")]
	public void AddUnique(T item)
	{
	}

	[Token(Token = "0x6000009")]
	public void AddRange(IEnumerable<T> items)
	{
	}

	[Token(Token = "0x600000A")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x600000B")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600000D")]
	public bool RemoveFast(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	public void RemoveAtFast(int index)
	{
	}

	[Token(Token = "0x600000F")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000012")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000014")]
	public void InsertionSort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000015")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CF664", Offset = "0x6CF664")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	public T Find(Predicate<T> match)
	{
		return (T)null;
	}

	[Token(Token = "0x6000017")]
	private void Allocate()
	{
	}

	[Token(Token = "0x6000018")]
	private void Trim()
	{
	}

	[Token(Token = "0x6000019")]
	public void Clear()
	{
	}

	[Token(Token = "0x600001A")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000003")]
public class InspectorNoteAttribute : PropertyAttribute
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string header;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string message;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9A00E0", Offset = "0x9A00E0", VA = "0x9A00E0")]
	public InspectorNoteAttribute(string header, string message = "")
	{
	}
}
[Token(Token = "0x2000004")]
public class InspectorCommentAttribute : PropertyAttribute
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string message;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9A00B4", Offset = "0x9A00B4", VA = "0x9A00B4")]
	public InspectorCommentAttribute(string message = "")
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CD424", Offset = "0x6CD424")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000132")]
	public enum RotationAxes
	{
		[Token(Token = "0x4000A8E")]
		MouseXAndY,
		[Token(Token = "0x4000A8F")]
		MouseX,
		[Token(Token = "0x4000A90")]
		MouseY
	}

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10835B0", Offset = "0x10835B0", VA = "0x10835B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1083810", Offset = "0x1083810", VA = "0x1083810")]
	private void Start()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10838D0", Offset = "0x10838D0", VA = "0x10838D0")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x2000006")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x2000133")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x4000A92")]
		Uninitialized = -1,
		[Token(Token = "0x4000A93")]
		NotEnabled,
		[Token(Token = "0x4000A94")]
		Success,
		[Token(Token = "0x4000A95")]
		StreamError,
		[Token(Token = "0x4000A96")]
		ProcessError,
		[Token(Token = "0x4000A97")]
		MaxStatValue
	}

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xC43518", Offset = "0xC43518", VA = "0xC43518")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xC4374C", Offset = "0xC4374C", VA = "0xC4374C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xC43950", Offset = "0xC43950", VA = "0xC43950")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x2000007")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x2000134")]
	private enum Parameters
	{
		[Token(Token = "0x4000A99")]
		P_GAIN,
		[Token(Token = "0x4000A9A")]
		P_USEINVSQR,
		[Token(Token = "0x4000A9B")]
		P_NEAR,
		[Token(Token = "0x4000A9C")]
		P_FAR,
		[Token(Token = "0x4000A9D")]
		P_RADIUS,
		[Token(Token = "0x4000A9E")]
		P_DISABLE_RFL,
		[Token(Token = "0x4000A9F")]
		P_AMBISTAT,
		[Token(Token = "0x4000AA0")]
		P_READONLY_GLOBAL_RFL_ENABLED,
		[Token(Token = "0x4000AA1")]
		P_READONLY_NUM_VOICES,
		[Token(Token = "0x4000AA2")]
		P_SENDLEVEL,
		[Token(Token = "0x4000AA3")]
		P_NUM
	}

	[Token(Token = "0x4000012")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000003")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xC43CAC", Offset = "0xC43CAC", VA = "0xC43CAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xC43CB4", Offset = "0xC43CB4", VA = "0xC43CB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public float Gain
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xC43CC0", Offset = "0xC43CC0", VA = "0xC43CC0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0xC43CC8", Offset = "0xC43CC8", VA = "0xC43CC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool UseInvSqr
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xC43D4C", Offset = "0xC43D4C", VA = "0xC43D4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xC43D54", Offset = "0xC43D54", VA = "0xC43D54")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public float Near
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0xC43D60", Offset = "0xC43D60", VA = "0xC43D60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xC43D68", Offset = "0xC43D68", VA = "0xC43D68")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public float Far
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xC43DF0", Offset = "0xC43DF0", VA = "0xC43DF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xC43DF8", Offset = "0xC43DF8", VA = "0xC43DF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public float VolumetricRadius
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xC43E80", Offset = "0xC43E80", VA = "0xC43E80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xC43E88", Offset = "0xC43E88", VA = "0xC43E88")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float ReverbSend
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xC43F10", Offset = "0xC43F10", VA = "0xC43F10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xC43F18", Offset = "0xC43F18", VA = "0xC43F18")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool EnableRfl
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xC43FA0", Offset = "0xC43FA0", VA = "0xC43FA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xC43FA8", Offset = "0xC43FA8", VA = "0xC43FA8")]
		set
		{
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xC439C4", Offset = "0xC439C4", VA = "0xC439C4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6CF6C8", Offset = "0x6CF6C8")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xC43BCC", Offset = "0xC43BCC", VA = "0xC43BCC")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length);

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xC43FB4", Offset = "0xC43FB4", VA = "0xC43FB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xC44128", Offset = "0xC44128", VA = "0xC44128")]
	private void Start()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xC4412C", Offset = "0xC4412C", VA = "0xC4412C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xC44020", Offset = "0xC44020", VA = "0xC44020")]
	public void SetParameters(ref AudioSource source)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xC441F4", Offset = "0xC441F4", VA = "0xC441F4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xC44654", Offset = "0xC44654", VA = "0xC44654")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600003C")]
	[Address(RVA = "0xC43B4C", Offset = "0xC43B4C", VA = "0xC43B4C")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xC44724", Offset = "0xC44724", VA = "0xC44724")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x2000008")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x400001D")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x400001F")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xC44744", Offset = "0xC44744", VA = "0xC44744")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xC44750", Offset = "0xC44750", VA = "0xC44750")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000041")]
	[Address(RVA = "0xC44808", Offset = "0xC44808", VA = "0xC44808")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x6000042")]
	[Address(RVA = "0xC44788", Offset = "0xC44788", VA = "0xC44788")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xC44888", Offset = "0xC44888", VA = "0xC44888")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x2000009")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	private struct MeshMaterial
	{
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x2000136")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x4000026")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x1700000B")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xC47304", Offset = "0xC47304", VA = "0xC47304")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public string filePath
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xC47390", Offset = "0xC47390", VA = "0xC47390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xC47408", Offset = "0xC47408", VA = "0xC47408")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xC47550", Offset = "0xC47550", VA = "0xC47550")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xC47554", Offset = "0xC47554", VA = "0xC47554")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xC47AB4", Offset = "0xC47AB4", VA = "0xC47AB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xC47E4C", Offset = "0xC47E4C", VA = "0xC47E4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xC47FA8", Offset = "0xC47FA8", VA = "0xC47FA8")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, ref int ignoredMeshCount)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xC48680", Offset = "0xC48680", VA = "0xC48680")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xC486BC", Offset = "0xC486BC", VA = "0xC486BC")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, ref int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xC49E60", Offset = "0xC49E60", VA = "0xC49E60")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xC49D38", Offset = "0xC49D38", VA = "0xC49D38")]
	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xC478EC", Offset = "0xC478EC", VA = "0xC478EC")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xC47720", Offset = "0xC47720", VA = "0xC47720")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xC4A474", Offset = "0xC4A474", VA = "0xC4A474")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xC4A8B0", Offset = "0xC4A8B0", VA = "0xC4A8B0")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x200000A")]
internal class ONSPPropagation
{
	[Token(Token = "0x2000137")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x4000AAA")]
		Int8,
		[Token(Token = "0x4000AAB")]
		UInt8,
		[Token(Token = "0x4000AAC")]
		Int16,
		[Token(Token = "0x4000AAD")]
		UInt16,
		[Token(Token = "0x4000AAE")]
		Int32,
		[Token(Token = "0x4000AAF")]
		UInt32,
		[Token(Token = "0x4000AB0")]
		Int64,
		[Token(Token = "0x4000AB1")]
		UInt64,
		[Token(Token = "0x4000AB2")]
		Float16,
		[Token(Token = "0x4000AB3")]
		Float32,
		[Token(Token = "0x4000AB4")]
		Float64
	}

	[Token(Token = "0x2000138")]
	public class ClientType
	{
		[Token(Token = "0x4000AB5")]
		public const uint OVRA_CLIENT_TYPE_NATIVE = 0u;

		[Token(Token = "0x4000AB6")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2016 = 1u;

		[Token(Token = "0x4000AB7")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_1 = 2u;

		[Token(Token = "0x4000AB8")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_2 = 3u;

		[Token(Token = "0x4000AB9")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2018_1 = 4u;

		[Token(Token = "0x4000ABA")]
		public const uint OVRA_CLIENT_TYPE_FMOD = 5u;

		[Token(Token = "0x4000ABB")]
		public const uint OVRA_CLIENT_TYPE_UNITY = 6u;

		[Token(Token = "0x4000ABC")]
		public const uint OVRA_CLIENT_TYPE_UE4 = 7u;

		[Token(Token = "0x4000ABD")]
		public const uint OVRA_CLIENT_TYPE_VST = 8u;

		[Token(Token = "0x4000ABE")]
		public const uint OVRA_CLIENT_TYPE_AAX = 9u;

		[Token(Token = "0x4000ABF")]
		public const uint OVRA_CLIENT_TYPE_TEST = 10u;

		[Token(Token = "0x4000AC0")]
		public const uint OVRA_CLIENT_TYPE_OTHER = 11u;

		[Token(Token = "0x4000AC1")]
		public const uint OVRA_CLIENT_TYPE_WWISE_UNKNOWN = 12u;

		[Token(Token = "0x4000AC2")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_1 = 13u;

		[Token(Token = "0x4000AC3")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_2 = 14u;

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xC44D3C", Offset = "0xC44D3C", VA = "0xC44D3C")]
		public ClientType()
		{
		}
	}

	[Token(Token = "0x2000139")]
	public interface PropagationInterface
	{
		[Token(Token = "0x6000A0D")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x6000A0E")]
		int SetPropagationThreadAffinity(ulong cpuMask);

		[Token(Token = "0x6000A0F")]
		int CreateAudioGeometry(out IntPtr geometry);

		[Token(Token = "0x6000A10")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000A11")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x6000A12")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000A13")]
		int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000A14")]
		int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A15")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A16")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A17")]
		int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000A18")]
		int CreateAudioMaterial(out IntPtr material);

		[Token(Token = "0x6000A19")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000A1A")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000A1B")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x200013A")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x4000AC4")]
		public const string strOSPS = "AudioPluginOculusSpatializer";

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000105")]
		private IntPtr context
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xC459AC", Offset = "0xC459AC", VA = "0xC459AC")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xC45A10", Offset = "0xC45A10", VA = "0xC45A10")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xC45AA0", Offset = "0xC45AA0", VA = "0xC45AA0")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xC45B30", Offset = "0xC45B30", VA = "0xC45B30", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xC45B54", Offset = "0xC45B54", VA = "0xC45B54")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xC45BE4", Offset = "0xC45BE4", VA = "0xC45BE4", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xC45C08", Offset = "0xC45C08", VA = "0xC45C08")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xC45C94", Offset = "0xC45C94", VA = "0xC45C94", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xC45CB8", Offset = "0xC45CB8", VA = "0xC45CB8")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xC45D38", Offset = "0xC45D38", VA = "0xC45D38", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xC45D40", Offset = "0xC45D40", VA = "0xC45D40")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xC45E60", Offset = "0xC45E60", VA = "0xC45E60", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xC45F58", Offset = "0xC45F58", VA = "0xC45F58")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xC45FF0", Offset = "0xC45FF0", VA = "0xC45FF0", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xC45FFC", Offset = "0xC45FFC", VA = "0xC45FFC")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xC46128", Offset = "0xC46128", VA = "0xC46128", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xC46134", Offset = "0xC46134", VA = "0xC46134")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xC461E0", Offset = "0xC461E0", VA = "0xC461E0", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xC461EC", Offset = "0xC461EC", VA = "0xC461EC")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xC46298", Offset = "0xC46298", VA = "0xC46298", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xC462A4", Offset = "0xC462A4", VA = "0xC462A4")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xC46350", Offset = "0xC46350", VA = "0xC46350", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xC4635C", Offset = "0xC4635C", VA = "0xC4635C")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xC463E8", Offset = "0xC463E8", VA = "0xC463E8", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xC4640C", Offset = "0xC4640C", VA = "0xC4640C")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xC4648C", Offset = "0xC4648C", VA = "0xC4648C", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xC46494", Offset = "0xC46494", VA = "0xC46494")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xC4653C", Offset = "0xC4653C", VA = "0xC4653C", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xC46548", Offset = "0xC46548", VA = "0xC46548")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xC465F0", Offset = "0xC465F0", VA = "0xC465F0", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xC46600", Offset = "0xC46600", VA = "0xC46600")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xC46690", Offset = "0xC46690", VA = "0xC46690", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xC44CE8", Offset = "0xC44CE8", VA = "0xC44CE8")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x200013B")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000AC6")]
		public const string strOSPS = "OculusSpatializerWwise";

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000106")]
		private IntPtr context
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xC4669C", Offset = "0xC4669C", VA = "0xC4669C")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xC44B30", Offset = "0xC44B30", VA = "0xC44B30")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xC46700", Offset = "0xC46700", VA = "0xC46700")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xC46790", Offset = "0xC46790", VA = "0xC46790", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xC467B4", Offset = "0xC467B4", VA = "0xC467B4")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xC46844", Offset = "0xC46844", VA = "0xC46844", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xC46868", Offset = "0xC46868", VA = "0xC46868")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xC468F8", Offset = "0xC468F8", VA = "0xC468F8", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xC4691C", Offset = "0xC4691C", VA = "0xC4691C")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xC4699C", Offset = "0xC4699C", VA = "0xC4699C", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xC469A4", Offset = "0xC469A4", VA = "0xC469A4")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xC46AC4", Offset = "0xC46AC4", VA = "0xC46AC4", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xC46BBC", Offset = "0xC46BBC", VA = "0xC46BBC")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xC46C54", Offset = "0xC46C54", VA = "0xC46C54", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xC46C60", Offset = "0xC46C60", VA = "0xC46C60")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xC46D8C", Offset = "0xC46D8C", VA = "0xC46D8C", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xC46D98", Offset = "0xC46D98", VA = "0xC46D98")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xC46E44", Offset = "0xC46E44", VA = "0xC46E44", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xC46E50", Offset = "0xC46E50", VA = "0xC46E50")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xC46EFC", Offset = "0xC46EFC", VA = "0xC46EFC", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xC46F08", Offset = "0xC46F08", VA = "0xC46F08")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xC46FB4", Offset = "0xC46FB4", VA = "0xC46FB4", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xC46FC0", Offset = "0xC46FC0", VA = "0xC46FC0")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xC47050", Offset = "0xC47050", VA = "0xC47050", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xC47074", Offset = "0xC47074", VA = "0xC47074")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xC470F4", Offset = "0xC470F4", VA = "0xC470F4", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xC470FC", Offset = "0xC470FC", VA = "0xC470FC")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xC471A4", Offset = "0xC471A4", VA = "0xC471A4", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xC471B0", Offset = "0xC471B0", VA = "0xC471B0")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xC47258", Offset = "0xC47258", VA = "0xC47258", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xC47268", Offset = "0xC47268", VA = "0xC47268")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xC472F8", Offset = "0xC472F8", VA = "0xC472F8", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xC44BC0", Offset = "0xC44BC0", VA = "0xC44BC0")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x200013C")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000AC8")]
		public const string strOSPS = "OculusSpatializerFMOD";

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000107")]
		private IntPtr context
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xC44D44", Offset = "0xC44D44", VA = "0xC44D44")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xC44C0C", Offset = "0xC44C0C", VA = "0xC44C0C")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xC44DA8", Offset = "0xC44DA8", VA = "0xC44DA8")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xC44E38", Offset = "0xC44E38", VA = "0xC44E38", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xC44E5C", Offset = "0xC44E5C", VA = "0xC44E5C")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xC44EEC", Offset = "0xC44EEC", VA = "0xC44EEC", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xC44F10", Offset = "0xC44F10", VA = "0xC44F10")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xC44FA0", Offset = "0xC44FA0", VA = "0xC44FA0", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xC44FC4", Offset = "0xC44FC4", VA = "0xC44FC4")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xC45044", Offset = "0xC45044", VA = "0xC45044", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xC4504C", Offset = "0xC4504C", VA = "0xC4504C")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xC4516C", Offset = "0xC4516C", VA = "0xC4516C", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xC45264", Offset = "0xC45264", VA = "0xC45264")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xC452FC", Offset = "0xC452FC", VA = "0xC452FC", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xC45308", Offset = "0xC45308", VA = "0xC45308")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xC45434", Offset = "0xC45434", VA = "0xC45434", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xC45440", Offset = "0xC45440", VA = "0xC45440")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xC454EC", Offset = "0xC454EC", VA = "0xC454EC", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xC454F8", Offset = "0xC454F8", VA = "0xC454F8")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xC455A4", Offset = "0xC455A4", VA = "0xC455A4", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xC455B0", Offset = "0xC455B0", VA = "0xC455B0")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xC4565C", Offset = "0xC4565C", VA = "0xC4565C", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xC45668", Offset = "0xC45668", VA = "0xC45668")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xC456F8", Offset = "0xC456F8", VA = "0xC456F8", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xC4571C", Offset = "0xC4571C", VA = "0xC4571C")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xC4579C", Offset = "0xC4579C", VA = "0xC4579C", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xC457A4", Offset = "0xC457A4", VA = "0xC457A4")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xC4584C", Offset = "0xC4584C", VA = "0xC4584C", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xC45858", Offset = "0xC45858", VA = "0xC45858")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xC45900", Offset = "0xC45900", VA = "0xC45900", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xC45910", Offset = "0xC45910", VA = "0xC45910")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xC459A0", Offset = "0xC459A0", VA = "0xC459A0", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xC44C9C", Offset = "0xC44C9C", VA = "0xC44C9C")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x1700000D")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xC44898", Offset = "0xC44898", VA = "0xC44898")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xC44908", Offset = "0xC44908", VA = "0xC44908")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xC44D34", Offset = "0xC44D34", VA = "0xC44D34")]
	public ONSPPropagation()
	{
	}
}
[Token(Token = "0x200000B")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x200013D")]
	public enum Preset
	{
		[Token(Token = "0x4000ACB")]
		Custom,
		[Token(Token = "0x4000ACC")]
		AcousticTile,
		[Token(Token = "0x4000ACD")]
		Brick,
		[Token(Token = "0x4000ACE")]
		BrickPainted,
		[Token(Token = "0x4000ACF")]
		Carpet,
		[Token(Token = "0x4000AD0")]
		CarpetHeavy,
		[Token(Token = "0x4000AD1")]
		CarpetHeavyPadded,
		[Token(Token = "0x4000AD2")]
		CeramicTile,
		[Token(Token = "0x4000AD3")]
		Concrete,
		[Token(Token = "0x4000AD4")]
		ConcreteRough,
		[Token(Token = "0x4000AD5")]
		ConcreteBlock,
		[Token(Token = "0x4000AD6")]
		ConcreteBlockPainted,
		[Token(Token = "0x4000AD7")]
		Curtain,
		[Token(Token = "0x4000AD8")]
		Foliage,
		[Token(Token = "0x4000AD9")]
		Glass,
		[Token(Token = "0x4000ADA")]
		GlassHeavy,
		[Token(Token = "0x4000ADB")]
		Grass,
		[Token(Token = "0x4000ADC")]
		Gravel,
		[Token(Token = "0x4000ADD")]
		GypsumBoard,
		[Token(Token = "0x4000ADE")]
		PlasterOnBrick,
		[Token(Token = "0x4000ADF")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x4000AE0")]
		Soil,
		[Token(Token = "0x4000AE1")]
		SoundProof,
		[Token(Token = "0x4000AE2")]
		Snow,
		[Token(Token = "0x4000AE3")]
		Steel,
		[Token(Token = "0x4000AE4")]
		Water,
		[Token(Token = "0x4000AE5")]
		WoodThin,
		[Token(Token = "0x4000AE6")]
		WoodThick,
		[Token(Token = "0x4000AE7")]
		WoodFloor,
		[Token(Token = "0x4000AE8")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x200013E")]
	public sealed class Point
	{
		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xC52784", Offset = "0xC52784", VA = "0xC52784")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xC528CC", Offset = "0xC528CC", VA = "0xC528CC")]
		public static implicit operator Point(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xC5293C", Offset = "0xC5293C", VA = "0xC5293C")]
		public static implicit operator Vector2(Point point)
		{
			return default(Vector2);
		}
	}

	[Serializable]
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD72C", Offset = "0x6CD72C")]
	public sealed class Spectrum
	{
		[Serializable]
		[Token(Token = "0x20001F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDBBC", Offset = "0x6CDBBC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000D33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000D34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Point, float> <>9__3_0;

			[Token(Token = "0x4000D35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Point, float> <>9__3_1;

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0xC52D94", Offset = "0xC52D94", VA = "0xC52D94")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0xC52D9C", Offset = "0xC52D9C", VA = "0xC52D9C")]
			internal float <get_Item>b__3_0(Point p)
			{
				return default(float);
			}

			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0xC52DB4", Offset = "0xC52DB4", VA = "0xC52DB4")]
			internal float <get_Item>b__3_1(Point p)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x17000108")]
		public float Item
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xC52974", Offset = "0xC52974", VA = "0xC52974")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xC52854", Offset = "0xC52854", VA = "0xC52854")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CDC4C", Offset = "0x6CDC4C")]
	public Spectrum absorption;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CDC84", Offset = "0x6CDC84")]
	public Spectrum transmission;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CDCBC", Offset = "0x6CDCBC")]
	public Spectrum scattering;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x1700000E")]
	public Preset preset
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0xC4A988", Offset = "0xC4A988", VA = "0xC4A988")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xC4A990", Offset = "0xC4A990", VA = "0xC4A990")]
		set
		{
		}
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xC4A9B8", Offset = "0xC4A9B8", VA = "0xC4A9B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC4A308", Offset = "0xC4A308", VA = "0xC4A308")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC4AF68", Offset = "0xC4AF68", VA = "0xC4AF68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xC4AF6C", Offset = "0xC4AF6C", VA = "0xC4AF6C")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC4A9BC", Offset = "0xC4A9BC", VA = "0xC4A9BC")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xC49BA4", Offset = "0xC49BA4", VA = "0xC49BA4")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xC4B050", Offset = "0xC4B050", VA = "0xC4B050")]
	private static void AcousticTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xC4B4B0", Offset = "0xC4B4B0", VA = "0xC4B4B0")]
	private static void Brick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xC4B910", Offset = "0xC4B910", VA = "0xC4B910")]
	private static void BrickPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xC4BD70", Offset = "0xC4BD70", VA = "0xC4BD70")]
	private static void Carpet(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xC4C1D0", Offset = "0xC4C1D0", VA = "0xC4C1D0")]
	private static void CarpetHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xC4C630", Offset = "0xC4C630", VA = "0xC4C630")]
	private static void CarpetHeavyPadded(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xC4CA90", Offset = "0xC4CA90", VA = "0xC4CA90")]
	private static void CeramicTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xC4CEF0", Offset = "0xC4CEF0", VA = "0xC4CEF0")]
	private static void Concrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xC4D350", Offset = "0xC4D350", VA = "0xC4D350")]
	private static void ConcreteRough(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xC4D7B0", Offset = "0xC4D7B0", VA = "0xC4D7B0")]
	private static void ConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xC4DC10", Offset = "0xC4DC10", VA = "0xC4DC10")]
	private static void ConcreteBlockPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xC4E070", Offset = "0xC4E070", VA = "0xC4E070")]
	private static void Curtain(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xC4E4D0", Offset = "0xC4E4D0", VA = "0xC4E4D0")]
	private static void Foliage(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xC4E930", Offset = "0xC4E930", VA = "0xC4E930")]
	private static void Glass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xC4ED88", Offset = "0xC4ED88", VA = "0xC4ED88")]
	private static void GlassHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xC4F1E8", Offset = "0xC4F1E8", VA = "0xC4F1E8")]
	private static void Grass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xC4F524", Offset = "0xC4F524", VA = "0xC4F524")]
	private static void Gravel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xC4F860", Offset = "0xC4F860", VA = "0xC4F860")]
	private static void GypsumBoard(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xC4FCC0", Offset = "0xC4FCC0", VA = "0xC4FCC0")]
	private static void PlasterOnBrick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xC50120", Offset = "0xC50120", VA = "0xC50120")]
	private static void PlasterOnConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xC50580", Offset = "0xC50580", VA = "0xC50580")]
	private static void Soil(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xC508BC", Offset = "0xC508BC", VA = "0xC508BC")]
	private static void SoundProof(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xC50A18", Offset = "0xC50A18", VA = "0xC50A18")]
	private static void Snow(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xC50D54", Offset = "0xC50D54", VA = "0xC50D54")]
	private static void Steel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xC511AC", Offset = "0xC511AC", VA = "0xC511AC")]
	private static void Water(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xC5160C", Offset = "0xC5160C", VA = "0xC5160C")]
	private static void WoodThin(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC51A64", Offset = "0xC51A64", VA = "0xC51A64")]
	private static void WoodThick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC51EC4", Offset = "0xC51EC4", VA = "0xC51EC4")]
	private static void WoodFloor(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC52324", Offset = "0xC52324", VA = "0xC52324")]
	private static void WoodOnConcrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xC527BC", Offset = "0xC527BC", VA = "0xC527BC")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x200000C")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xC52DCC", Offset = "0xC52DCC", VA = "0xC52DCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xC52E9C", Offset = "0xC52E9C", VA = "0xC52E9C")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x200000D")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x1700000F")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC43A38", Offset = "0xC43A38", VA = "0xC43A38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xC53458", Offset = "0xC53458", VA = "0xC53458")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x200000E")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x6000082")]
	[Address(RVA = "0xC53468", Offset = "0xC53468", VA = "0xC53468")]
	private static extern void ONSP_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC53500", Offset = "0xC53500", VA = "0xC53500")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC5360C", Offset = "0xC5360C", VA = "0xC5360C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC53610", Offset = "0xC53610", VA = "0xC53610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC53614", Offset = "0xC53614", VA = "0xC53614")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x200000F")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x2000140")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x4000040")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x4000046")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x9DA39C", Offset = "0x9DA39C", VA = "0x9DA39C")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x9DA1CC", Offset = "0x9DA1CC", VA = "0x9DA1CC")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6CF6DC", Offset = "0x6CF6DC")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9DA3D4", Offset = "0x9DA3D4", VA = "0x9DA3D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9DA508", Offset = "0x9DA508", VA = "0x9DA508")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x9DA5FC", Offset = "0x9DA5FC", VA = "0x9DA5FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x9DAFB4", Offset = "0x9DAFB4", VA = "0x9DAFB4")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9DA474", Offset = "0x9DA474", VA = "0x9DA474")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x9DA56C", Offset = "0x9DA56C", VA = "0x9DA56C")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9DAD1C", Offset = "0x9DAD1C", VA = "0x9DAD1C")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9DAD9C", Offset = "0x9DAD9C", VA = "0x9DAD9C")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x9DAE24", Offset = "0x9DAE24", VA = "0x9DAE24")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x9DAEAC", Offset = "0x9DAEAC", VA = "0x9DAEAC")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9DAF2C", Offset = "0x9DAF2C", VA = "0x9DAF2C")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x9DBDEC", Offset = "0x9DBDEC", VA = "0x9DBDEC")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x9DBE94", Offset = "0x9DBE94", VA = "0x9DBE94")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x9DBF3C", Offset = "0x9DBF3C", VA = "0x9DBF3C")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x2000010")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x2000011")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xC52EAC", Offset = "0xC52EAC", VA = "0xC52EAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xC52EB0", Offset = "0xC52EB0", VA = "0xC52EB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xC52EB4", Offset = "0xC52EB4", VA = "0xC52EB4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xC5301C", Offset = "0xC5301C", VA = "0xC5301C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xC52F00", Offset = "0xC52F00", VA = "0xC52F00")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xC52F90", Offset = "0xC52F90", VA = "0xC52F90")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xC53068", Offset = "0xC53068", VA = "0xC53068")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xC53100", Offset = "0xC53100", VA = "0xC53100")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xC53268", Offset = "0xC53268", VA = "0xC53268")]
	private void SetReflectionValues(ref ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xC533D0", Offset = "0xC533D0", VA = "0xC533D0")]
	public ONSPReflectionZone()
	{
	}
}
[Token(Token = "0x2000012")]
public class Pvr_Controller : MonoBehaviour
{
	[Token(Token = "0x2000141")]
	public enum UserHandNess
	{
		[Token(Token = "0x4000AEE")]
		Right,
		[Token(Token = "0x4000AEF")]
		Left
	}

	[Token(Token = "0x2000142")]
	public enum GazeType
	{
		[Token(Token = "0x4000AF1")]
		Never,
		[Token(Token = "0x4000AF2")]
		DuringMotion,
		[Token(Token = "0x4000AF3")]
		Always
	}

	[Token(Token = "0x2000143")]
	public enum ControllerAxis
	{
		[Token(Token = "0x4000AF5")]
		Controller,
		[Token(Token = "0x4000AF6")]
		Wrist,
		[Token(Token = "0x4000AF7")]
		Elbow,
		[Token(Token = "0x4000AF8")]
		Shoulder
	}

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject controller0;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject controller1;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UserHandNess handness;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ControllerAxis Axis;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GazeType Gazetype;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CDD14", Offset = "0x6CDD14")]
	public float ElbowHeight;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CDD30", Offset = "0x6CDD30")]
	public float ElbowDepth;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CDD4C", Offset = "0x6CDD4C")]
	public float PointerTiltAngle;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float mouseX;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float mouseY;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float mouseZ;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3[] inputDirection;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDD64", Offset = "0x6CDD64")]
	private static Vector3 <pointerPosition>k__BackingField;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDD74", Offset = "0x6CDD74")]
	private static Quaternion <pointerRotation>k__BackingField;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDD84", Offset = "0x6CDD84")]
	private static Vector3 <elbowPosition>k__BackingField;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDD94", Offset = "0x6CDD94")]
	private static Quaternion <elbowRotation>k__BackingField;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDA4", Offset = "0x6CDDA4")]
	private static Vector3 <wristPosition>k__BackingField;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDB4", Offset = "0x6CDDB4")]
	private static Quaternion <wristRotation>k__BackingField;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDC4", Offset = "0x6CDDC4")]
	private static Vector3 <shoulderPosition>k__BackingField;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDD4", Offset = "0x6CDDD4")]
	private static Quaternion <shoulderRotation>k__BackingField;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDE4", Offset = "0x6CDDE4")]
	private static Vector3 <originOffsetL>k__BackingField;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDDF4", Offset = "0x6CDDF4")]
	private static Vector3 <originOffsetR>k__BackingField;

	[Token(Token = "0x17000010")]
	public static Vector3 pointerPosition
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9E0F8C", Offset = "0x9E0F8C", VA = "0x9E0F8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF740", Offset = "0x6CF740")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9E0FE0", Offset = "0x9E0FE0", VA = "0x9E0FE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF750", Offset = "0x6CF750")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public static Quaternion pointerRotation
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9E1050", Offset = "0x9E1050", VA = "0x9E1050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF760", Offset = "0x6CF760")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9E10A4", Offset = "0x9E10A4", VA = "0x9E10A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF770", Offset = "0x6CF770")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public static Vector3 elbowPosition
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9E1118", Offset = "0x9E1118", VA = "0x9E1118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF780", Offset = "0x6CF780")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x9E116C", Offset = "0x9E116C", VA = "0x9E116C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF790", Offset = "0x6CF790")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public static Quaternion elbowRotation
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9E11DC", Offset = "0x9E11DC", VA = "0x9E11DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7A0", Offset = "0x6CF7A0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x9E1230", Offset = "0x9E1230", VA = "0x9E1230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7B0", Offset = "0x6CF7B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public static Vector3 wristPosition
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9E12A4", Offset = "0x9E12A4", VA = "0x9E12A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7C0", Offset = "0x6CF7C0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9E12F8", Offset = "0x9E12F8", VA = "0x9E12F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7D0", Offset = "0x6CF7D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public static Quaternion wristRotation
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x9E1368", Offset = "0x9E1368", VA = "0x9E1368")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7E0", Offset = "0x6CF7E0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9E13BC", Offset = "0x9E13BC", VA = "0x9E13BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF7F0", Offset = "0x6CF7F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public static Vector3 shoulderPosition
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9E1430", Offset = "0x9E1430", VA = "0x9E1430")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF800", Offset = "0x6CF800")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x9E1484", Offset = "0x9E1484", VA = "0x9E1484")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF810", Offset = "0x6CF810")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public static Quaternion shoulderRotation
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9E14F4", Offset = "0x9E14F4", VA = "0x9E14F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF820", Offset = "0x6CF820")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9E1548", Offset = "0x9E1548", VA = "0x9E1548")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF830", Offset = "0x6CF830")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public static Vector3 originOffsetL
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x9E15BC", Offset = "0x9E15BC", VA = "0x9E15BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF840", Offset = "0x6CF840")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x9E1610", Offset = "0x9E1610", VA = "0x9E1610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF850", Offset = "0x6CF850")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public static Vector3 originOffsetR
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9E1680", Offset = "0x9E1680", VA = "0x9E1680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF860", Offset = "0x6CF860")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9E16D4", Offset = "0x9E16D4", VA = "0x9E16D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF870", Offset = "0x6CF870")]
		set
		{
		}
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x9DE6D4", Offset = "0x9DE6D4", VA = "0x9DE6D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9DEBC0", Offset = "0x9DEBC0", VA = "0x9DEBC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x9DEC30", Offset = "0x9DEC30", VA = "0x9DEC30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x9DF11C", Offset = "0x9DF11C", VA = "0x9DF11C")]
	private void MainControllerChanged(string index)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x9DF1C4", Offset = "0x9DF1C4", VA = "0x9DF1C4")]
	private void HandnessChanged(string index)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9DF1C8", Offset = "0x9DF1C8", VA = "0x9DF1C8")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x9DF120", Offset = "0x9DF120", VA = "0x9DF120")]
	private void RefreshHandness()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x9DF228", Offset = "0x9DF228", VA = "0x9DF228")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x9DF3AC", Offset = "0x9DF3AC", VA = "0x9DF3AC")]
	private void ShowController()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x9DF50C", Offset = "0x9DF50C", VA = "0x9DF50C")]
	private void CheckControllerState(string data)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9DF5E0", Offset = "0x9DF5E0", VA = "0x9DF5E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x9DF1CC", Offset = "0x9DF1CC", VA = "0x9DF1CC")]
	public static void ChangeHandNess()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9DF9F8", Offset = "0x9DF9F8", VA = "0x9DF9F8")]
	private void DoUpdateControler0()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9DFA74", Offset = "0x9DFA74", VA = "0x9DFA74")]
	private void DoUpdateControler1()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x9DFAF8", Offset = "0x9DFAF8", VA = "0x9DFAF8")]
	private void UpdateControlloerRay(bool update0 = true, bool update1 = true)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9E0DA8", Offset = "0x9E0DA8", VA = "0x9E0DA8")]
	private Quaternion UpdateSimulatedFrameParams()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9DFC48", Offset = "0x9DFC48", VA = "0x9DFC48")]
	private void SetArmParaToSo(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9DFC58", Offset = "0x9DFC58", VA = "0x9DFC58")]
	private void CalcArmModelfromSo(int hand)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9E0134", Offset = "0x9E0134", VA = "0x9E0134")]
	public void UpdateControllerDataSO(int hand)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9E1744", Offset = "0x9E1744", VA = "0x9E1744")]
	public Pvr_Controller()
	{
	}
}
[Token(Token = "0x2000013")]
public class Pvr_ControllerDemo : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject HeadSetController;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject controller0;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject controller1;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cube;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Ray ray;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject currentController;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform lastHit;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform currentHit;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Material normat;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Material gazemat;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Material clickmat;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool noClick;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject referenceObj;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float rayDefaultLength;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool isHasController;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	private bool headcontrolmode;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private RaycastHit hit;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject rayLine;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject dot;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Transform dragObj;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float disX;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float disY;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float disZ;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9E17AC", Offset = "0x9E17AC", VA = "0x9E17AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x9E1B0C", Offset = "0x9E1B0C", VA = "0x9E1B0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x9E1DF8", Offset = "0x9E1DF8", VA = "0x9E1DF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x9E36C8", Offset = "0x9E36C8", VA = "0x9E36C8")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9E3760", Offset = "0x9E3760", VA = "0x9E3760")]
	private void ControllerStateListener(string data)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9E37F8", Offset = "0x9E37F8", VA = "0x9E37F8")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9E3890", Offset = "0x9E3890", VA = "0x9E3890")]
	public void SwitchControlMode()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9E3894", Offset = "0x9E3894", VA = "0x9E3894")]
	public Pvr_ControllerDemo()
	{
	}
}
[Token(Token = "0x2000014")]
public class Pvr_ControllerEventsExamples : MonoBehaviour
{
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9E38A4", Offset = "0x9E38A4", VA = "0x9E38A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x9E3ADC", Offset = "0x9E3ADC", VA = "0x9E3ADC")]
	private void UIPointerElementEnter(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x9E3B78", Offset = "0x9E3B78", VA = "0x9E3B78")]
	private void UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x9E3C14", Offset = "0x9E3C14", VA = "0x9E3C14")]
	private void UIPointerElementClick(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x9E3CB0", Offset = "0x9E3CB0", VA = "0x9E3CB0")]
	private void UIPointerElementDragStart(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x9E3D4C", Offset = "0x9E3D4C", VA = "0x9E3D4C")]
	private void UIPointerElementDragEnd(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x9E3DE8", Offset = "0x9E3DE8", VA = "0x9E3DE8")]
	public Pvr_ControllerEventsExamples()
	{
	}
}
[Token(Token = "0x2000015")]
public class Pvr_ControllerInit : MonoBehaviour
{
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD764", Offset = "0x6CD764")]
	private sealed class <RefreshController>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int id;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Pvr_ControllerInit <>4__this;

		[Token(Token = "0x17000109")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x9E5BC8", Offset = "0x9E5BC8", VA = "0x9E5BC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x9E5C30", Offset = "0x9E5C30", VA = "0x9E5C30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x9E4BCC", Offset = "0x9E4BCC", VA = "0x9E4BCC")]
		[DebuggerHidden]
		public <RefreshController>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x9E5838", Offset = "0x9E5838", VA = "0x9E5838", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x9E583C", Offset = "0x9E583C", VA = "0x9E583C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x9E5BD0", Offset = "0x9E5BD0", VA = "0x9E5BD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ControllerVariety Variety;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isCustomModel;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject goblin;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject g2;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject neo2L;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject neo2R;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject neo3L;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject neo3R;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Material standardMat;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material unlitMat;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int controllerType;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public bool loadModelSuccess;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int systemOrUnity;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private JsonData curControllerData;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string modelName;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string texFormat;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string prePath;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string modelFilePath;

	[Token(Token = "0x400008C")]
	private const string goblinTexbasePath = "Controller/controller1/controller1";

	[Token(Token = "0x400008D")]
	private const string g2TexbasePath = "Controller/controller3/controller3";

	[Token(Token = "0x400008E")]
	private const string neo2TexbasePath = "Controller/controller4/controller4";

	[Token(Token = "0x400008F")]
	private const string neo3TexbasePath = "Controller/controller5/controller5";

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9E3DF0", Offset = "0x9E3DF0", VA = "0x9E3DF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9E3F5C", Offset = "0x9E3F5C", VA = "0x9E3F5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9E4054", Offset = "0x9E4054", VA = "0x9E4054")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x9E42E4", Offset = "0x9E42E4", VA = "0x9E42E4")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9E44DC", Offset = "0x9E44DC", VA = "0x9E44DC")]
	private void LoadResFromJson()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x9E46C4", Offset = "0x9E46C4", VA = "0x9E46C4")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9E4A68", Offset = "0x9E4A68", VA = "0x9E4A68")]
	private void CheckControllerStateOfAbility(string data)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9E4060", Offset = "0x9E4060", VA = "0x9E4060")]
	private void DestroyLocalController()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x9E47B0", Offset = "0x9E47B0", VA = "0x9E47B0")]
	private void DestroySysController()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x9E4644", Offset = "0x9E4644", VA = "0x9E4644")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CF880", Offset = "0x6CF880")]
	private IEnumerator RefreshController(int id)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x9E4BF8", Offset = "0x9E4BF8", VA = "0x9E4BF8")]
	private void LoadControllerFromPrefab()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x9E519C", Offset = "0x9E519C", VA = "0x9E519C")]
	private void LoadControllerFromSystem(int id)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x9E4EA8", Offset = "0x9E4EA8", VA = "0x9E4EA8")]
	private void LoadTexture(Pvr_ControllerVisual visual, string controllerName, bool fromRes)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x9E55AC", Offset = "0x9E55AC", VA = "0x9E55AC")]
	private Texture2D LoadOneTexture(string filepath, bool fromRes)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x9E56B8", Offset = "0x9E56B8", VA = "0x9E56B8")]
	private byte[] ReadPNG(string path)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x9E57C4", Offset = "0x9E57C4", VA = "0x9E57C4")]
	public Pvr_ControllerInit()
	{
	}
}
[Token(Token = "0x2000016")]
public class Pvr_ControllerLink
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaClass javaHummingbirdClass;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AndroidJavaClass javaPico2ReceiverClass;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AndroidJavaClass javaserviceClass;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AndroidJavaClass javavractivityclass;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AndroidJavaClass javaCVClass;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AndroidJavaObject activity;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string gameobjname;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool picoDevice;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string hummingBirdMac;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int hummingBirdRSSI;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool goblinserviceStarted;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool neoserviceStarted;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	public bool controller0Connected;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	public bool controller1Connected;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int mainHandID;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Pvr_Controller.UserHandNess handness;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int controllerType;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ControllerHand Controller0;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ControllerHand Controller1;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int platFormType;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int trackingmode;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int systemProp;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int enablehand6dofbyhead;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool switchHomeKey;

	[Token(Token = "0x40000A8")]
	private const float SWITCH_METER = 1000f;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float[] hbPoseData;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float[] sensorData;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int[] keyData;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int[] neo3TouchValue;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float[] fixedState;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float[] neoposeData;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int[] goblinKeyArray;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int[] neoKeyArray;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int[] neotriggerV;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float[] velocity;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float[] angularVelocity;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float[] acceData;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float[] predictData;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x9E5C38", Offset = "0x9E5C38", VA = "0x9E5C38")]
	public Pvr_ControllerLink(string name)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x9E5FCC", Offset = "0x9E5FCC", VA = "0x9E5FCC")]
	private void StartHummingBirdService()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x9E69C4", Offset = "0x9E69C4", VA = "0x9E69C4")]
	public bool IsServiceExisted()
	{
		return default(bool);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9E6768", Offset = "0x9E6768", VA = "0x9E6768")]
	public void SetGameObjectToJar(string name)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9E6878", Offset = "0x9E6878", VA = "0x9E6878")]
	public void BindService()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x9E6B4C", Offset = "0x9E6B4C", VA = "0x9E6B4C")]
	public void UnBindService()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9E6C98", Offset = "0x9E6C98", VA = "0x9E6C98")]
	public void StopReceiver()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9E6D90", Offset = "0x9E6D90", VA = "0x9E6D90")]
	public void StartReceiver()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x9E6EB4", Offset = "0x9E6EB4", VA = "0x9E6EB4")]
	public int getHandness()
	{
		return default(int);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x9E70C0", Offset = "0x9E70C0", VA = "0x9E70C0")]
	public void setHandness(int hand)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x9E7214", Offset = "0x9E7214", VA = "0x9E7214")]
	public void StartScan()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x9E7328", Offset = "0x9E7328", VA = "0x9E7328")]
	public void StopScan()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x9E65F8", Offset = "0x9E65F8", VA = "0x9E65F8")]
	public int GetSysproc()
	{
		return default(int);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x9E7440", Offset = "0x9E7440", VA = "0x9E7440")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x9E7644", Offset = "0x9E7644", VA = "0x9E7644")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x9E7780", Offset = "0x9E7780", VA = "0x9E7780")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9E78A0", Offset = "0x9E78A0", VA = "0x9E78A0")]
	public bool StartUpgrade()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x9E79DC", Offset = "0x9E79DC", VA = "0x9E79DC")]
	public void setBinPath(string path, bool isasset)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9E7B54", Offset = "0x9E7B54", VA = "0x9E7B54")]
	public string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x9E7CB8", Offset = "0x9E7CB8", VA = "0x9E7CB8")]
	public long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9E7E20", Offset = "0x9E7E20", VA = "0x9E7E20")]
	public string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x9E7F84", Offset = "0x9E7F84", VA = "0x9E7F84")]
	public long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x9E80EC", Offset = "0x9E80EC", VA = "0x9E80EC")]
	public int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x9E8428", Offset = "0x9E8428", VA = "0x9E8428")]
	public void RebackToLauncher()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x9E8610", Offset = "0x9E8610", VA = "0x9E8610")]
	public void TurnUpVolume()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x9E878C", Offset = "0x9E878C", VA = "0x9E878C")]
	public void TurnDownVolume()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x9E8908", Offset = "0x9E8908", VA = "0x9E8908")]
	public float[] GetHBControllerPoseData()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x9E8CCC", Offset = "0x9E8CCC", VA = "0x9E8CCC")]
	public float[] GetControllerSensorData()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x9E8E94", Offset = "0x9E8E94", VA = "0x9E8E94")]
	public int[] GetControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x9E8F98", Offset = "0x9E8F98", VA = "0x9E8F98")]
	public int[] GetNeo3TouchData(int hand)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x9E970C", Offset = "0x9E970C", VA = "0x9E970C")]
	public int GetNeo3GripValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9E9898", Offset = "0x9E9898", VA = "0x9E9898")]
	public float[] GetControllerFixedSensorState(int hand)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x9E9E3C", Offset = "0x9E9E3C", VA = "0x9E9E3C")]
	public float[] GetCvControllerPoseData(int hand)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x9EA408", Offset = "0x9EA408", VA = "0x9EA408")]
	public int[] GetHBControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x9EB718", Offset = "0x9EB718", VA = "0x9EB718")]
	public int GetHBKeyValue()
	{
		return default(int);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x9EB8B4", Offset = "0x9EB8B4", VA = "0x9EB8B4")]
	public int[] GetCvControllerKeyData(int hand)
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9ED358", Offset = "0x9ED358", VA = "0x9ED358")]
	public int GetCVTriggerValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x9ED50C", Offset = "0x9ED50C", VA = "0x9ED50C")]
	public void AutoConnectHbController(int scanTimeMs)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x9ED680", Offset = "0x9ED680", VA = "0x9ED680")]
	public void StartControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x9ED844", Offset = "0x9ED844", VA = "0x9ED844")]
	public void StopControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x9EDA08", Offset = "0x9EDA08", VA = "0x9EDA08")]
	public void SetUnityVersionToJar(string version)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x9EDB28", Offset = "0x9EDB28", VA = "0x9EDB28")]
	public Vector3 GetVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x9EDEC8", Offset = "0x9EDEC8", VA = "0x9EDEC8")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x9EE374", Offset = "0x9EE374", VA = "0x9EE374")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9EE7F8", Offset = "0x9EE7F8", VA = "0x9EE7F8")]
	public string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x9EE958", Offset = "0x9EE958", VA = "0x9EE958")]
	public void VibrateNeo2Controller(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x9EEC30", Offset = "0x9EEC30", VA = "0x9EEC30")]
	public void VibrateController(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9EEF08", Offset = "0x9EEF08", VA = "0x9EEF08")]
	public int GetMainControllerIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x9EF07C", Offset = "0x9EF07C", VA = "0x9EF07C")]
	public void SetMainController(int index)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x9EF1CC", Offset = "0x9EF1CC", VA = "0x9EF1CC")]
	public void ResetHeadSensorForController()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x9EF2F0", Offset = "0x9EF2F0", VA = "0x9EF2F0")]
	public void GetDeviceVersion(int deviceType)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x9EF448", Offset = "0x9EF448", VA = "0x9EF448")]
	public void GetControllerSnCode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x9EF5A0", Offset = "0x9EF5A0", VA = "0x9EF5A0")]
	public void SetControllerUnbind(int controllerSerialNum)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x9EF6F8", Offset = "0x9EF6F8", VA = "0x9EF6F8")]
	public void SetStationRestart()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x9EF81C", Offset = "0x9EF81C", VA = "0x9EF81C")]
	public void StartStationOtaUpdate()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x9EF940", Offset = "0x9EF940", VA = "0x9EF940")]
	public void StartControllerOtaUpdate(int mode, int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9EFAF8", Offset = "0x9EFAF8", VA = "0x9EFAF8")]
	public void EnterPairMode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9EFC50", Offset = "0x9EFC50", VA = "0x9EFC50")]
	public void SetControllerShutdown(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x9EFDA8", Offset = "0x9EFDA8", VA = "0x9EFDA8")]
	public int GetStationPairState()
	{
		return default(int);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x9EFF20", Offset = "0x9EFF20", VA = "0x9EFF20")]
	public int GetStationOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x9F0098", Offset = "0x9F0098", VA = "0x9F0098")]
	public int GetControllerOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x9F0210", Offset = "0x9F0210", VA = "0x9F0210")]
	public void GetControllerVersionAndSN(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x9F0368", Offset = "0x9F0368", VA = "0x9F0368")]
	public void GetControllerUniqueID()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x9F048C", Offset = "0x9F048C", VA = "0x9F048C")]
	public void InterruptStationPairMode()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x9F05B0", Offset = "0x9F05B0", VA = "0x9F05B0")]
	public int GetControllerAbility(int controllerSerialNum)
	{
		return default(int);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x9F0724", Offset = "0x9F0724", VA = "0x9F0724")]
	public void SwitchHomeKey(bool state)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x9F07D4", Offset = "0x9F07D4", VA = "0x9F07D4")]
	public void SetBootReconnect()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x9F08F0", Offset = "0x9F08F0", VA = "0x9F08F0")]
	public int GetTemperature()
	{
		return default(int);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x9F0A60", Offset = "0x9F0A60", VA = "0x9F0A60")]
	public int GetDeviceType()
	{
		return default(int);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x9F0BD0", Offset = "0x9F0BD0", VA = "0x9F0BD0")]
	public int GetControllerType()
	{
		return default(int);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x9F0CD8", Offset = "0x9F0CD8", VA = "0x9F0CD8")]
	public string GetHummingBird2SN()
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x9F0E30", Offset = "0x9F0E30", VA = "0x9F0E30")]
	public string GetControllerVersion()
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x9F0F88", Offset = "0x9F0F88", VA = "0x9F0F88")]
	public bool IsEnbleTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x9F10E4", Offset = "0x9F10E4", VA = "0x9F10E4")]
	public void StartCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x9F123C", Offset = "0x9F123C", VA = "0x9F123C")]
	public void StopCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x9F1394", Offset = "0x9F1394", VA = "0x9F1394")]
	public int GetControllerBindingState(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x9F14F8", Offset = "0x9F14F8", VA = "0x9F14F8")]
	public void setIsEnbleHomeKey(bool state)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x9F1640", Offset = "0x9F1640", VA = "0x9F1640")]
	public int getControllerSensorStatus(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x9F17A4", Offset = "0x9F17A4", VA = "0x9F17A4")]
	public float[] GetControllerPredictSensorData(int controllerID, float predictTime)
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
public class Pvr_ControllerManager : MonoBehaviour
{
	[Token(Token = "0x2000145")]
	public delegate void PvrServiceStartSuccess();

	[Token(Token = "0x2000146")]
	public delegate void PvrControllerStateChanged(string data);

	[Token(Token = "0x2000147")]
	public delegate void ChangeMainControllerCallBack(string index);

	[Token(Token = "0x2000148")]
	public delegate void ChangeHandNessCallBack(string index);

	[Token(Token = "0x2000149")]
	public delegate void SetHbServiceBindState();

	[Token(Token = "0x200014A")]
	public delegate void ControllerThreadStartedCallback();

	[Token(Token = "0x200014B")]
	public delegate void SetControllerServiceBindState();

	[Token(Token = "0x200014C")]
	public delegate void ControllerStatusChange(string isconnect);

	[Token(Token = "0x200014D")]
	public delegate void SetControllerAbility(string data);

	[Token(Token = "0x200014E")]
	public delegate void SetControllerStateChanged(string data);

	[Token(Token = "0x200014F")]
	public delegate void SetHbControllerMac(string mac);

	[Token(Token = "0x2000150")]
	public delegate void ControllerDeviceVersionCallback(string data);

	[Token(Token = "0x2000151")]
	public delegate void ControllerSnCodeCallback(string data);

	[Token(Token = "0x2000152")]
	public delegate void ControllerUnbindCallback(string status);

	[Token(Token = "0x2000153")]
	public delegate void ControllerStationStatusCallback(string status);

	[Token(Token = "0x2000154")]
	public delegate void ControllerStationBusyCallback(string status);

	[Token(Token = "0x2000155")]
	public delegate void ControllerOtaStartCodeCallback(string data);

	[Token(Token = "0x2000156")]
	public delegate void ControllerDeviceVersionAndSNCallback(string data);

	[Token(Token = "0x2000157")]
	public delegate void ControllerUniqueIDCallback(string data);

	[Token(Token = "0x2000158")]
	public delegate void ControllerCombinedKeyUnbindCallback(string data);

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ControllerManager instance;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Pvr_ControllerLink controllerlink;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float cTime;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool stopConnect;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text toast;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool controllerServicestate;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float disConnectTime;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool LengthAdaptiveRay;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] sensorData;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int[] keyData;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] g2SensorData;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int[] g2KeyData;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int keyOffset;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int rotControllerMode;

	[Token(Token = "0x1700001A")]
	public static Pvr_ControllerManager Instance
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9E0B78", Offset = "0x9E0B78", VA = "0x9E0B78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event PvrServiceStartSuccess PvrServiceStartSuccessEvent
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x9DE800", Offset = "0x9DE800", VA = "0x9DE800")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8E4", Offset = "0x6CF8E4")]
		add
		{
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9DED5C", Offset = "0x9DED5C", VA = "0x9DED5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8F4", Offset = "0x6CF8F4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event PvrControllerStateChanged PvrControllerStateChangedEvent
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9F1980", Offset = "0x9F1980", VA = "0x9F1980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF904", Offset = "0x6CF904")]
		add
		{
		}
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9F1A70", Offset = "0x9F1A70", VA = "0x9F1A70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF914", Offset = "0x6CF914")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event ChangeMainControllerCallBack ChangeMainControllerCallBackEvent
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9DE9E0", Offset = "0x9DE9E0", VA = "0x9DE9E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF924", Offset = "0x6CF924")]
		add
		{
		}
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x9DEF3C", Offset = "0x9DEF3C", VA = "0x9DEF3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF934", Offset = "0x6CF934")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event ChangeHandNessCallBack ChangeHandNessCallBackEvent
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x9DEAD0", Offset = "0x9DEAD0", VA = "0x9DEAD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF944", Offset = "0x6CF944")]
		add
		{
		}
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9DF02C", Offset = "0x9DF02C", VA = "0x9DF02C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF954", Offset = "0x6CF954")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event SetHbServiceBindState SetHbServiceBindStateEvent
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x9F1B60", Offset = "0x9F1B60", VA = "0x9F1B60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF964", Offset = "0x6CF964")]
		add
		{
		}
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x9F1C50", Offset = "0x9F1C50", VA = "0x9F1C50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF974", Offset = "0x6CF974")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event ControllerThreadStartedCallback ControllerThreadStartedCallbackEvent
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9F1D40", Offset = "0x9F1D40", VA = "0x9F1D40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF984", Offset = "0x6CF984")]
		add
		{
		}
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9F1E30", Offset = "0x9F1E30", VA = "0x9F1E30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF994", Offset = "0x6CF994")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event SetControllerServiceBindState SetControllerServiceBindStateEvent
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9F1F20", Offset = "0x9F1F20", VA = "0x9F1F20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9A4", Offset = "0x6CF9A4")]
		add
		{
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x9F2010", Offset = "0x9F2010", VA = "0x9F2010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9B4", Offset = "0x6CF9B4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event ControllerStatusChange ControllerStatusChangeEvent
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x9E1A1C", Offset = "0x9E1A1C", VA = "0x9E1A1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9C4", Offset = "0x6CF9C4")]
		add
		{
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x9E1D08", Offset = "0x9E1D08", VA = "0x9E1D08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9D4", Offset = "0x6CF9D4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event SetControllerAbility SetControllerAbilityEvent
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9DE8F0", Offset = "0x9DE8F0", VA = "0x9DE8F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9E4", Offset = "0x6CF9E4")]
		add
		{
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9DEE4C", Offset = "0x9DEE4C", VA = "0x9DEE4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9F4", Offset = "0x6CF9F4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event SetControllerStateChanged SetControllerStateChangedEvent
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9E192C", Offset = "0x9E192C", VA = "0x9E192C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA04", Offset = "0x6CFA04")]
		add
		{
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9E1C18", Offset = "0x9E1C18", VA = "0x9E1C18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA14", Offset = "0x6CFA14")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event SetHbControllerMac SetHbControllerMacEvent
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9F2100", Offset = "0x9F2100", VA = "0x9F2100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA24", Offset = "0x6CFA24")]
		add
		{
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9F21F0", Offset = "0x9F21F0", VA = "0x9F21F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA34", Offset = "0x6CFA34")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event ControllerDeviceVersionCallback ControllerDeviceVersionCallbackEvent
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9F22E0", Offset = "0x9F22E0", VA = "0x9F22E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA44", Offset = "0x6CFA44")]
		add
		{
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9F23D0", Offset = "0x9F23D0", VA = "0x9F23D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA54", Offset = "0x6CFA54")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event ControllerSnCodeCallback ControllerSnCodeCallbackEvent
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9F24C0", Offset = "0x9F24C0", VA = "0x9F24C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA64", Offset = "0x6CFA64")]
		add
		{
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x9F25B0", Offset = "0x9F25B0", VA = "0x9F25B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA74", Offset = "0x6CFA74")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event ControllerUnbindCallback ControllerUnbindCallbackEvent
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9F26A0", Offset = "0x9F26A0", VA = "0x9F26A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA84", Offset = "0x6CFA84")]
		add
		{
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x9F2790", Offset = "0x9F2790", VA = "0x9F2790")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA94", Offset = "0x6CFA94")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event ControllerStationStatusCallback ControllerStationStatusCallbackEvent
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x9F2880", Offset = "0x9F2880", VA = "0x9F2880")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAA4", Offset = "0x6CFAA4")]
		add
		{
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9F2970", Offset = "0x9F2970", VA = "0x9F2970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAB4", Offset = "0x6CFAB4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event ControllerStationBusyCallback ControllerStationBusyCallbackEvent
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9F2A60", Offset = "0x9F2A60", VA = "0x9F2A60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAC4", Offset = "0x6CFAC4")]
		add
		{
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9F2B50", Offset = "0x9F2B50", VA = "0x9F2B50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAD4", Offset = "0x6CFAD4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event ControllerOtaStartCodeCallback ControllerOtaStartCodeCallbackEvent
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9F2C40", Offset = "0x9F2C40", VA = "0x9F2C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAE4", Offset = "0x6CFAE4")]
		add
		{
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9F2D30", Offset = "0x9F2D30", VA = "0x9F2D30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAF4", Offset = "0x6CFAF4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event ControllerDeviceVersionAndSNCallback ControllerDeviceVersionAndSNCallbackEvent
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9F2E20", Offset = "0x9F2E20", VA = "0x9F2E20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB04", Offset = "0x6CFB04")]
		add
		{
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x9F2F10", Offset = "0x9F2F10", VA = "0x9F2F10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB14", Offset = "0x6CFB14")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event ControllerUniqueIDCallback ControllerUniqueIDCallbackEvent
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9F3000", Offset = "0x9F3000", VA = "0x9F3000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB24", Offset = "0x6CFB24")]
		add
		{
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x9F30F0", Offset = "0x9F30F0", VA = "0x9F30F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB34", Offset = "0x6CFB34")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event ControllerCombinedKeyUnbindCallback ControllerCombinedKeyUnbindCallbackEvent
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x9F31E0", Offset = "0x9F31E0", VA = "0x9F31E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB44", Offset = "0x6CFB44")]
		add
		{
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x9F32D0", Offset = "0x9F32D0", VA = "0x9F32D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB54", Offset = "0x6CFB54")]
		remove
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x9F33C0", Offset = "0x9F33C0", VA = "0x9F33C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x9F36A8", Offset = "0x9F36A8", VA = "0x9F36A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x9F3750", Offset = "0x9F3750", VA = "0x9F3750")]
	private void Update()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x9F51CC", Offset = "0x9F51CC", VA = "0x9F51CC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x9F561C", Offset = "0x9F561C", VA = "0x9F561C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x9F56F8", Offset = "0x9F56F8", VA = "0x9F56F8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x9F5838", Offset = "0x9F5838", VA = "0x9F5838")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x9F5918", Offset = "0x9F5918", VA = "0x9F5918")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x9F3604", Offset = "0x9F3604", VA = "0x9F3604")]
	public void BindService()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x9F59F8", Offset = "0x9F59F8", VA = "0x9F59F8")]
	public void StartScan()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x9F5A9C", Offset = "0x9F5A9C", VA = "0x9F5A9C")]
	public void StopScan()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x9F5B40", Offset = "0x9F5B40", VA = "0x9F5B40")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x9F55A4", Offset = "0x9F55A4", VA = "0x9F55A4")]
	public static int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x9F5BEC", Offset = "0x9F5BEC", VA = "0x9F5BEC")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x9F5C90", Offset = "0x9F5C90", VA = "0x9F5C90")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x9F5D34", Offset = "0x9F5D34", VA = "0x9F5D34")]
	public void SetBinPath(string path, bool isAsset)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x9F5DF4", Offset = "0x9F5DF4", VA = "0x9F5DF4")]
	public void StartUpgrade()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x9F5E98", Offset = "0x9F5E98", VA = "0x9F5E98")]
	public static string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x9F5F08", Offset = "0x9F5F08", VA = "0x9F5F08")]
	public static long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x9F5F78", Offset = "0x9F5F78", VA = "0x9F5F78")]
	public static string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x9F5FE8", Offset = "0x9F5FE8", VA = "0x9F5FE8")]
	public static long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x9F6058", Offset = "0x9F6058", VA = "0x9F6058")]
	public static void AutoConnectHbController(int scans)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x9F6104", Offset = "0x9F6104", VA = "0x9F6104")]
	public static string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x9F61B8", Offset = "0x9F61B8", VA = "0x9F61B8")]
	public void setHbControllerMac(string mac)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x9F6370", Offset = "0x9F6370", VA = "0x9F6370")]
	public int GetControllerRSSI()
	{
		return default(int);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x9F63E4", Offset = "0x9F63E4", VA = "0x9F63E4")]
	public void setHbServiceBindState(string state)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x9F666C", Offset = "0x9F666C", VA = "0x9F666C")]
	public void setControllerServiceBindState(string state)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x9F68F0", Offset = "0x9F68F0", VA = "0x9F68F0")]
	public void setHbControllerConnectState(string isconnect)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x9F6B84", Offset = "0x9F6B84", VA = "0x9F6B84")]
	public void setControllerStateChanged(string state)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x9F7114", Offset = "0x9F7114", VA = "0x9F7114")]
	public void setControllerAbility(string data)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x9F720C", Offset = "0x9F720C", VA = "0x9F720C")]
	public void controllerThreadStartedCallback()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x9F763C", Offset = "0x9F763C", VA = "0x9F763C")]
	public void controllerDeviceVersionCallback(string data)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x9F7734", Offset = "0x9F7734", VA = "0x9F7734")]
	public void controllerSnCodeCallback(string data)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x9F782C", Offset = "0x9F782C", VA = "0x9F782C")]
	public void controllerUnbindCallback(string status)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x9F7924", Offset = "0x9F7924", VA = "0x9F7924")]
	public void controllerStationStatusCallback(string status)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x9F7A1C", Offset = "0x9F7A1C", VA = "0x9F7A1C")]
	public void controllerStationBusyCallback(string status)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x9F7B14", Offset = "0x9F7B14", VA = "0x9F7B14")]
	public void controllerOTAStartCodeCallback(string data)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x9F7C0C", Offset = "0x9F7C0C", VA = "0x9F7C0C")]
	public void controllerDeviceVersionAndSNCallback(string data)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x9F7D04", Offset = "0x9F7D04", VA = "0x9F7D04")]
	public void controllerUniqueIDCallback(string data)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x9F7DFC", Offset = "0x9F7DFC", VA = "0x9F7DFC")]
	public void controllerCombinedKeyUnbindCallback(string controllerSerialNum)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x9F7EAC", Offset = "0x9F7EAC", VA = "0x9F7EAC")]
	public void setupdateFailed()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x9F7EB0", Offset = "0x9F7EB0", VA = "0x9F7EB0")]
	public void setupdateSuccess()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x9F7EB4", Offset = "0x9F7EB4", VA = "0x9F7EB4")]
	public void setupdateProgress(string progress)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x9F7EB8", Offset = "0x9F7EB8", VA = "0x9F7EB8")]
	public void setHbAutoConnectState(string state)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x9F81D0", Offset = "0x9F81D0", VA = "0x9F81D0")]
	public void callbackControllerServiceState(string state)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x9F8328", Offset = "0x9F8328", VA = "0x9F8328")]
	public void changeMainControllerCallback(string index)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x9F8474", Offset = "0x9F8474", VA = "0x9F8474")]
	public void changeHandnessCallback(string index)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x9F8008", Offset = "0x9F8008", VA = "0x9F8008")]
	private void ShowToast(int type)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x9F85C0", Offset = "0x9F85C0", VA = "0x9F85C0")]
	private void HideToast()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x9F8668", Offset = "0x9F8668", VA = "0x9F8668")]
	private void CheckControllerService()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x9F7348", Offset = "0x9F7348", VA = "0x9F7348")]
	private void GetCVControllerState()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x9F4AC4", Offset = "0x9F4AC4", VA = "0x9F4AC4")]
	private void SetSystemKey()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x9F46F8", Offset = "0x9F46F8", VA = "0x9F46F8")]
	private void TransformData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x9F867C", Offset = "0x9F867C", VA = "0x9F867C")]
	private void TransSingleKey(PvrControllerKey key, int beginIndex, int[] data)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x9F87CC", Offset = "0x9F87CC", VA = "0x9F87CC")]
	private void TransformTouchData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x9F8870", Offset = "0x9F8870", VA = "0x9F8870")]
	private void TransSingleTouchValue(PvrControllerKey key, int beginIndex, int[] data)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x9F8970", Offset = "0x9F8970", VA = "0x9F8970")]
	public Pvr_ControllerManager()
	{
	}
}
[Token(Token = "0x2000018")]
public class Pvr_ControllerModuleInit : MonoBehaviour
{
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD774", Offset = "0x6CD774")]
	private sealed class <ShowOrHideRay>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_ControllerModuleInit <>4__this;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int id;

		[Token(Token = "0x1700010B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x14720C0", Offset = "0x14720C0", VA = "0x14720C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x1472128", Offset = "0x1472128", VA = "0x1472128", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x1471AC8", Offset = "0x1471AC8", VA = "0x1471AC8")]
		[DebuggerHidden]
		public <ShowOrHideRay>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x1471E80", Offset = "0x1471E80", VA = "0x1471E80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x1471E84", Offset = "0x1471E84", VA = "0x1471E84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x14720C8", Offset = "0x14720C8", VA = "0x14720C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControllerVariety Variety;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool IsCustomModel;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject dot;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rayLine;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject controller;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool moduleState;

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1471640", Offset = "0x1471640", VA = "0x1471640")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x14717D8", Offset = "0x14717D8", VA = "0x14717D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x14718CC", Offset = "0x14718CC", VA = "0x14718CC")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1471940", Offset = "0x1471940", VA = "0x1471940")]
	private void ControllerStateChanged(string data)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1471A44", Offset = "0x1471A44", VA = "0x1471A44")]
	private void MainControllerIDChanged(string data)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x14718D0", Offset = "0x14718D0", VA = "0x14718D0")]
	private void RefreshRay()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1471A48", Offset = "0x1471A48", VA = "0x1471A48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFB64", Offset = "0x6CFB64")]
	private IEnumerator ShowOrHideRay(int id)
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1471AF4", Offset = "0x1471AF4", VA = "0x1471AF4")]
	public void ForceHideOrShow(bool state)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1471BF0", Offset = "0x1471BF0", VA = "0x1471BF0")]
	public void UpdateRay()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1471E70", Offset = "0x1471E70", VA = "0x1471E70")]
	public Pvr_ControllerModuleInit()
	{
	}
}
[Token(Token = "0x2000019")]
public class Pvr_ControllerPower : MonoBehaviour
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite power1;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite power2;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite power3;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite power4;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite power5;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image powerImage;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int powerValue;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float power;

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1472130", Offset = "0x1472130", VA = "0x1472130")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x14721F8", Offset = "0x14721F8", VA = "0x14721F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1472218", Offset = "0x1472218", VA = "0x1472218")]
	private void RefreshPower(int hand)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x14723FC", Offset = "0x14723FC", VA = "0x14723FC")]
	public Pvr_ControllerPower()
	{
	}
}
[Token(Token = "0x200001A")]
public class Pvr_ControllerVisual : MonoBehaviour
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControllerDevice currentDevice;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D m_idle;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D m_app;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D m_home;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D m_touchpad;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D m_volUp;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_volDn;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D m_trigger;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D m_a;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D m_b;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D m_x;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D m_y;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D m_grip;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Renderer controllerRenderMat;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1472404", Offset = "0x1472404", VA = "0x1472404")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x147245C", Offset = "0x147245C", VA = "0x147245C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x14724CC", Offset = "0x14724CC", VA = "0x14724CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x14724EC", Offset = "0x14724EC", VA = "0x14724EC")]
	private void ChangeKeyEffects(int hand)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1472F28", Offset = "0x1472F28", VA = "0x1472F28")]
	public Pvr_ControllerVisual()
	{
	}
}
[Token(Token = "0x200001B")]
public class Pvr_ToolTips : MonoBehaviour
{
	[Token(Token = "0x200015A")]
	public enum TipBtn
	{
		[Token(Token = "0x4000B02")]
		app,
		[Token(Token = "0x4000B03")]
		touchpad,
		[Token(Token = "0x4000B04")]
		home,
		[Token(Token = "0x4000B05")]
		volup,
		[Token(Token = "0x4000B06")]
		voldown,
		[Token(Token = "0x4000B07")]
		trigger,
		[Token(Token = "0x4000B08")]
		grip
	}

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ControllerDevice currentDevice;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float tipsAlpha;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Pvr_ToolTips tooltips;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1478224", Offset = "0x1478224", VA = "0x1478224")]
	public void ChangeTipsText(TipBtn tip, string key)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x147839C", Offset = "0x147839C", VA = "0x147839C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1478414", Offset = "0x1478414", VA = "0x1478414")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1478618", Offset = "0x1478618", VA = "0x1478618")]
	private void LoadTextFromJson()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1478A64", Offset = "0x1478A64", VA = "0x1478A64")]
	public static void RefreshTips()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1478B08", Offset = "0x1478B08", VA = "0x1478B08")]
	public Pvr_ToolTips()
	{
	}
}
[Token(Token = "0x200001C")]
public class Pvr_TouchPadScroll : MonoBehaviour
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScrollRect scrollRect;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isHoving;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int mainHand;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SwipeDirection direction;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector2 currPos;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector2 tarPos;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float lerpSpeed;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform tranViewport;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float ignoreDis;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector2 lastTouchDownPos;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector2 lastTouchUpPos;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isTouching;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isClosed;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2 vecOrigin;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 vecOriginNeo2;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1478B10", Offset = "0x1478B10", VA = "0x1478B10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1478BA0", Offset = "0x1478BA0", VA = "0x1478BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1479038", Offset = "0x1479038", VA = "0x1479038")]
	private bool IsControllerConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1478CE8", Offset = "0x1478CE8", VA = "0x1478CE8")]
	private void UpdateTargetPos()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1479864", Offset = "0x1479864", VA = "0x1479864")]
	private void ComputeTouchPos()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1479BA8", Offset = "0x1479BA8", VA = "0x1479BA8")]
	private void ComputeRockerPos()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x147A01C", Offset = "0x147A01C", VA = "0x147A01C")]
	private bool VerifyNeo2TouchValid(Vector2 nowTouchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1478E34", Offset = "0x1478E34", VA = "0x1478E34")]
	private void UpdatePos()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1479788", Offset = "0x1479788", VA = "0x1479788")]
	private void ResetParameter()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1478BCC", Offset = "0x1478BCC", VA = "0x1478BCC")]
	private void Process()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x147A058", Offset = "0x147A058", VA = "0x147A058")]
	private bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x147A244", Offset = "0x147A244", VA = "0x147A244")]
	private bool FindTree(Transform tran)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x147A330", Offset = "0x147A330", VA = "0x147A330")]
	public Pvr_TouchPadScroll()
	{
	}
}
[Token(Token = "0x200001D")]
public class Pvr_TouchVisual : MonoBehaviour
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer touchRenderer;

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x147A3EC", Offset = "0x147A3EC", VA = "0x147A3EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x147A494", Offset = "0x147A494", VA = "0x147A494")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x147A4B4", Offset = "0x147A4B4", VA = "0x147A4B4")]
	private void ChangeEffects(int hand)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x147A784", Offset = "0x147A784", VA = "0x147A784")]
	public Pvr_TouchVisual()
	{
	}
}
[Token(Token = "0x200001E")]
public class DemoController : MonoBehaviour
{
	[Token(Token = "0x200015B")]
	public delegate void showLoadingEventHandler();

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD784", Offset = "0x6CD784")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject btnObj;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DemoController <>4__this;

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x99D690", Offset = "0x99D690", VA = "0x99D690")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x99DF6C", Offset = "0x99DF6C", VA = "0x99DF6C")]
		internal void <InitDelegate>b__0()
		{
		}
	}

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Callback callback;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject msg;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Pvr_UnitySDKManager picoVrManager;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string currentOrderID;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loading;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject BG;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject InputPanel;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static showLoadingEventHandler showLoading;

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x99CEFC", Offset = "0x99CEFC", VA = "0x99CEFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x99D0B0", Offset = "0x99D0B0", VA = "0x99D0B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x99D52C", Offset = "0x99D52C", VA = "0x99D52C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x99D174", Offset = "0x99D174", VA = "0x99D174")]
	private void InitDelegate()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x99D698", Offset = "0x99D698", VA = "0x99D698")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x99DA20", Offset = "0x99DA20", VA = "0x99DA20")]
	public string getRamdomTestOrderID()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x99D97C", Offset = "0x99D97C", VA = "0x99D97C")]
	private void StartLoading()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x99DAC4", Offset = "0x99DAC4", VA = "0x99DAC4")]
	public void StopLoading()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x99DBD4", Offset = "0x99DBD4", VA = "0x99DBD4")]
	public void DoPayByCode()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x99DE94", Offset = "0x99DE94", VA = "0x99DE94")]
	private bool VerifyLocalToken()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x99DF64", Offset = "0x99DF64", VA = "0x99DF64")]
	public DemoController()
	{
	}
}
[Token(Token = "0x200001F")]
public class LoadingRatation : MonoBehaviour
{
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x9A0118", Offset = "0x9A0118", VA = "0x9A0118")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x9A011C", Offset = "0x9A011C", VA = "0x9A011C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x9A0190", Offset = "0x9A0190", VA = "0x9A0190")]
	public LoadingRatation()
	{
	}
}
[Token(Token = "0x2000020")]
public class InputManager : MonoBehaviour
{
	[Token(Token = "0x200015D")]
	public delegate void doEnterEventHandler();

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD794", Offset = "0x6CD794")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject btnObj;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputManager <>4__this;

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x99F484", Offset = "0x99F484", VA = "0x99F484")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x9A005C", Offset = "0x9A005C", VA = "0x9A005C")]
		internal void <InitKeyBoard>b__0()
		{
		}
	}

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static doEnterEventHandler doEnter;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StringBuilder sb;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ArrayList btnsName;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject enter;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x99EBA8", Offset = "0x99EBA8", VA = "0x99EBA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x99F47C", Offset = "0x99F47C", VA = "0x99F47C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x99F480", Offset = "0x99F480", VA = "0x99F480")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x99EBAC", Offset = "0x99EBAC", VA = "0x99EBAC")]
	private void InitKeyBoard()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x99F48C", Offset = "0x99F48C", VA = "0x99F48C")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x99FEE8", Offset = "0x99FEE8", VA = "0x99FEE8")]
	private void EnterChar(string s)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x99F6C0", Offset = "0x99F6C0", VA = "0x99F6C0")]
	private void DoCapslock(bool IsUpper)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x99FC6C", Offset = "0x99FC6C", VA = "0x99FC6C")]
	private void ClearBuffer()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x99FFD4", Offset = "0x99FFD4", VA = "0x99FFD4")]
	public InputManager()
	{
	}
}
[Token(Token = "0x2000021")]
public class Callback : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string IS_SUCCESS;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string MSG;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string CODE;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x99BC00", Offset = "0x99BC00", VA = "0x99BC00")]
	public void LoginCallback(string LoginInfo)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x99C1A4", Offset = "0x99C1A4", VA = "0x99C1A4")]
	public void QueryOrPayCallback(string queryOrPayInfo)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x99C3B4", Offset = "0x99C3B4", VA = "0x99C3B4")]
	public void UserInfoCallback(string userInfo)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x99BE0C", Offset = "0x99BE0C", VA = "0x99BE0C")]
	public void SetMassage(string massage)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x99C480", Offset = "0x99C480", VA = "0x99C480")]
	public GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x99C4CC", Offset = "0x99C4CC", VA = "0x99C4CC")]
	public void ActivityForResultCallback(string activity)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x99C5F4", Offset = "0x99C5F4", VA = "0x99C5F4")]
	public Callback()
	{
	}
}
[Token(Token = "0x2000022")]
public class CommonDic
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CommonDic dic;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, string> mydic;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string _app_ID;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string _app_Key;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _user_token;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _access_token;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _open_id;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _refresh_token;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _expires_in;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _user_info;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _subject;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _body;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _order_id;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string _total;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string _goods_tag;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string _notify_url;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string _trade_type;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string _pay_code;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string _order_info;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string _code;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string _msg;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string _merchant_ID;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string _payKey;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private string _isSuucess;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string _loginMsg;

	[Token(Token = "0x1700001B")]
	public string subject
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x99CD8C", Offset = "0x99CD8C", VA = "0x99CD8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x99CD94", Offset = "0x99CD94", VA = "0x99CD94")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public string body
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x99CD9C", Offset = "0x99CD9C", VA = "0x99CD9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x99CDA4", Offset = "0x99CDA4", VA = "0x99CDA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public string order_id
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x99CDAC", Offset = "0x99CDAC", VA = "0x99CDAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x99CDB4", Offset = "0x99CDB4", VA = "0x99CDB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public string total
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x99CDBC", Offset = "0x99CDBC", VA = "0x99CDBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x99CDC4", Offset = "0x99CDC4", VA = "0x99CDC4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public string goods_tag
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x99CDCC", Offset = "0x99CDCC", VA = "0x99CDCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x99CDD4", Offset = "0x99CDD4", VA = "0x99CDD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public string notify_url
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x99CDDC", Offset = "0x99CDDC", VA = "0x99CDDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x99CDE4", Offset = "0x99CDE4", VA = "0x99CDE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public string pay_code
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x99CDEC", Offset = "0x99CDEC", VA = "0x99CDEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x99CDF4", Offset = "0x99CDF4", VA = "0x99CDF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public string trade_type
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x99CDFC", Offset = "0x99CDFC", VA = "0x99CDFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x99CE04", Offset = "0x99CE04", VA = "0x99CE04")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public string user_token
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x99CE0C", Offset = "0x99CE0C", VA = "0x99CE0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x99CE14", Offset = "0x99CE14", VA = "0x99CE14")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public string access_token
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x99CE1C", Offset = "0x99CE1C", VA = "0x99CE1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x99CE24", Offset = "0x99CE24", VA = "0x99CE24")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public string open_id
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x99CE2C", Offset = "0x99CE2C", VA = "0x99CE2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x99CE34", Offset = "0x99CE34", VA = "0x99CE34")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public string refresh_token
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x99CE3C", Offset = "0x99CE3C", VA = "0x99CE3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x99CE44", Offset = "0x99CE44", VA = "0x99CE44")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public string expires_in
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x99CE4C", Offset = "0x99CE4C", VA = "0x99CE4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x99CE54", Offset = "0x99CE54", VA = "0x99CE54")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public string isSuccess
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x99CE5C", Offset = "0x99CE5C", VA = "0x99CE5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x99CE64", Offset = "0x99CE64", VA = "0x99CE64")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public string loginMsg
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x99CE6C", Offset = "0x99CE6C", VA = "0x99CE6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x99CE74", Offset = "0x99CE74", VA = "0x99CE74")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public string user_info
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x99CE7C", Offset = "0x99CE7C", VA = "0x99CE7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x99CE84", Offset = "0x99CE84", VA = "0x99CE84")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public string order_info
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x99CE8C", Offset = "0x99CE8C", VA = "0x99CE8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x99CE94", Offset = "0x99CE94", VA = "0x99CE94")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public string code
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x99CE9C", Offset = "0x99CE9C", VA = "0x99CE9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x99CEA4", Offset = "0x99CEA4", VA = "0x99CEA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public string msg
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x99CEAC", Offset = "0x99CEAC", VA = "0x99CEAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x99CEB4", Offset = "0x99CEB4", VA = "0x99CEB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public string app_ID
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x99CEBC", Offset = "0x99CEBC", VA = "0x99CEBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x99CEC4", Offset = "0x99CEC4", VA = "0x99CEC4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public string app_Key
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x99CECC", Offset = "0x99CECC", VA = "0x99CECC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x99CED4", Offset = "0x99CED4", VA = "0x99CED4")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public string merchant_ID
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x99CEDC", Offset = "0x99CEDC", VA = "0x99CEDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x99CEE4", Offset = "0x99CEE4", VA = "0x99CEE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public string paykey
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x99CEEC", Offset = "0x99CEEC", VA = "0x99CEEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x99CEF4", Offset = "0x99CEF4", VA = "0x99CEF4")]
		set
		{
		}
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x99C0E0", Offset = "0x99C0E0", VA = "0x99C0E0")]
	public static CommonDic getInstance()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x99CB74", Offset = "0x99CB74", VA = "0x99CB74")]
	public Dictionary<string, string> getDic()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x99CBC4", Offset = "0x99CBC4", VA = "0x99CBC4")]
	public void setParameters(string name, string value)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x99CD1C", Offset = "0x99CD1C", VA = "0x99CD1C")]
	public string PayOrderString()
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x99C6F0", Offset = "0x99C6F0", VA = "0x99C6F0")]
	public static void InitDicData(Dictionary<string, string> mydic)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x99C684", Offset = "0x99C684", VA = "0x99C684")]
	public CommonDic()
	{
	}
}
[Token(Token = "0x2000023")]
public class LoginSDK
{
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x99D9C0", Offset = "0x99D9C0", VA = "0x99D9C0")]
	public static void Login()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x99DA64", Offset = "0x99DA64", VA = "0x99DA64")]
	public static void GetUserAPI()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x9A0198", Offset = "0x9A0198", VA = "0x9A0198")]
	public LoginSDK()
	{
	}
}
[Token(Token = "0x2000024")]
public class PicoPaymentSDK
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _jo;

	[Token(Token = "0x17000032")]
	public static AndroidJavaObject jo
	{
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9DE028", Offset = "0x9DE028", VA = "0x9DE028")]
		get
		{
			return null;
		}
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9DE090", Offset = "0x9DE090", VA = "0x9DE090")]
		set
		{
		}
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x9DD7D8", Offset = "0x9DD7D8", VA = "0x9DD7D8")]
	public static void Login()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x9DE0FC", Offset = "0x9DE0FC", VA = "0x9DE0FC")]
	public static void Pay(string payOrderJson)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x9DE324", Offset = "0x9DE324", VA = "0x9DE324")]
	public static void QueryOrder(string orderId)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x9DDBAC", Offset = "0x9DDBAC", VA = "0x9DDBAC")]
	public static void GetUserAPI()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x9DE54C", Offset = "0x9DE54C", VA = "0x9DE54C")]
	public PicoPaymentSDK()
	{
	}
}
[Token(Token = "0x2000025")]
public class PLOG : MonoBehaviour
{
	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int logLevel;

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9DD0A0", Offset = "0x9DD0A0", VA = "0x9DD0A0")]
	public static void getConfigTraceLevel()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x9DD10C", Offset = "0x9DD10C", VA = "0x9DD10C")]
	public static void D(string msg)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x9DD1B4", Offset = "0x9DD1B4", VA = "0x9DD1B4")]
	public static void I(string msg)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x9DD25C", Offset = "0x9DD25C", VA = "0x9DD25C")]
	public static void W(string msg)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x9DD304", Offset = "0x9DD304", VA = "0x9DD304")]
	public static void E(string msg)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x9DD36C", Offset = "0x9DD36C", VA = "0x9DD36C")]
	public PLOG()
	{
	}
}
[Token(Token = "0x2000026")]
public class PicoDevice : MonoBehaviour
{
	[Token(Token = "0x200015F")]
	public enum DeviceType
	{
		[Token(Token = "0x4000B0E")]
		HMD,
		[Token(Token = "0x4000B0F")]
		LeftController,
		[Token(Token = "0x4000B10")]
		RightController
	}

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DeviceType deviceType;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 devicePos;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion deviceRot;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x9DD378", Offset = "0x9DD378", VA = "0x9DD378")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x9DD598", Offset = "0x9DD598", VA = "0x9DD598")]
	private void Update()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x9DD774", Offset = "0x9DD774", VA = "0x9DD774")]
	public PicoDevice()
	{
	}
}
[Token(Token = "0x2000027")]
public class CPicoSDKSettingAsset : ScriptableObject
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IgnoreSDKSetting;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool DontshowBuildWaring;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool AppIDChecked;

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x99BBF8", Offset = "0x99BBF8", VA = "0x99BBF8")]
	public CPicoSDKSettingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000028")]
public class Pvr_UnitySDKProjectSetting : ScriptableObject
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTextureAntiAliasing rtAntiAlising;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RenderTextureDepth rtBitDepth;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTextureFormat rtFormat;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool usedefaultRenderTexture;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 customRTSize;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool usedefaultfps;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int customfps;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool usesinglepass;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool usecontentprotect;

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x143DB1C", Offset = "0x143DB1C", VA = "0x143DB1C")]
	public static Pvr_UnitySDKProjectSetting GetProjectConfig()
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x143DB70", Offset = "0x143DB70", VA = "0x143DB70")]
	public Pvr_UnitySDKProjectSetting()
	{
	}
}
[Token(Token = "0x2000029")]
public sealed class Pvr_UnitySDKPlatformSetting : ScriptableObject
{
	[Token(Token = "0x2000160")]
	public enum simulationType
	{
		[Token(Token = "0x4000B12")]
		Null,
		[Token(Token = "0x4000B13")]
		Invalid,
		[Token(Token = "0x4000B14")]
		Valid
	}

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool entitlementchecksimulation;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool startTimeEntitlementCheck;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string appID;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<string> deviceSN;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKPlatformSetting instance;

	[Token(Token = "0x17000033")]
	public static bool Entitlementchecksimulation
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x143CE18", Offset = "0x143CE18", VA = "0x143CE18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x143CE38", Offset = "0x143CE38", VA = "0x143CE38")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public static bool StartTimeEntitlementCheck
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x143C7F4", Offset = "0x143C7F4", VA = "0x143C7F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x143CE84", Offset = "0x143CE84", VA = "0x143CE84")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public static Pvr_UnitySDKPlatformSetting Instance
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x143C814", Offset = "0x143C814", VA = "0x143C814")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x143CED0", Offset = "0x143CED0", VA = "0x143CED0")]
		set
		{
		}
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x143CF24", Offset = "0x143CF24", VA = "0x143CF24")]
	public Pvr_UnitySDKPlatformSetting()
	{
	}
}
[Token(Token = "0x200002A")]
public class Pvr_UnitySDKManager : MonoBehaviour
{
	[Token(Token = "0x2000161")]
	public delegate void EntitlementCheckResult(int ReturnValue);

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7A4", Offset = "0x6CD7A4")]
	private sealed class <ToastManager>d__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int type;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool state;

		[Token(Token = "0x1700010D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x143CAA0", Offset = "0x143CAA0", VA = "0x143CAA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x143CB08", Offset = "0x143CB08", VA = "0x143CB08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x143C93C", Offset = "0x143C93C", VA = "0x143C93C")]
		[DebuggerHidden]
		public <ToastManager>d__97(int <>1__state)
		{
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x143C968", Offset = "0x143C968", VA = "0x143C968", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x143C96C", Offset = "0x143C96C", VA = "0x143C96C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x143CAA8", Offset = "0x143CAA8", VA = "0x143CAA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7B4", Offset = "0x6CD7B4")]
	private sealed class <>c__DisplayClass102_0
	{
		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trans;

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x143B348", Offset = "0x143B348", VA = "0x143B348")]
		public <>c__DisplayClass102_0()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x143B350", Offset = "0x143B350", VA = "0x143B350")]
		internal void <SetProperty>b__0()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7C4", Offset = "0x6CD7C4")]
	private sealed class <G3TipsManager>d__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject tip;

		[Token(Token = "0x1700010F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x143B490", Offset = "0x143B490", VA = "0x143B490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x143B4F8", Offset = "0x143B4F8", VA = "0x143B4F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x143B3A8", Offset = "0x143B3A8", VA = "0x143B3A8")]
		[DebuggerHidden]
		public <G3TipsManager>d__106(int <>1__state)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x143B3D4", Offset = "0x143B3D4", VA = "0x143B3D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x143B3D8", Offset = "0x143B3D8", VA = "0x143B3D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x143B498", Offset = "0x143B498", VA = "0x143B498", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7D4", Offset = "0x6CD7D4")]
	private sealed class <Start>d__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x17000111")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x143C8CC", Offset = "0x143C8CC", VA = "0x143C8CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x143C934", Offset = "0x143C934", VA = "0x143C934", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x143C538", Offset = "0x143C538", VA = "0x143C538")]
		[DebuggerHidden]
		public <Start>d__118(int <>1__state)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x143C564", Offset = "0x143C564", VA = "0x143C564", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x143C568", Offset = "0x143C568", VA = "0x143C568", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x143C8D4", Offset = "0x143C8D4", VA = "0x143C8D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7E4", Offset = "0x6CD7E4")]
	private sealed class <InitRenderThreadRoutine>d__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <i>5__2;

		[Token(Token = "0x17000113")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x143B8E4", Offset = "0x143B8E4", VA = "0x143B8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x143B94C", Offset = "0x143B94C", VA = "0x143B94C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x143B500", Offset = "0x143B500", VA = "0x143B500")]
		[DebuggerHidden]
		public <InitRenderThreadRoutine>d__119(int <>1__state)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x143B52C", Offset = "0x143B52C", VA = "0x143B52C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x143B530", Offset = "0x143B530", VA = "0x143B530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x143B8EC", Offset = "0x143B8EC", VA = "0x143B8EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD7F4", Offset = "0x6CD7F4")]
	private sealed class <OnResume>d__132 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <ability6dof>5__2;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <waitNum>5__3;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <resetNum>5__4;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__5;

		[Token(Token = "0x17000115")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x143C4C8", Offset = "0x143C4C8", VA = "0x143C4C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x143C530", Offset = "0x143C530", VA = "0x143C530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x143B954", Offset = "0x143B954", VA = "0x143B954")]
		[DebuggerHidden]
		public <OnResume>d__132(int <>1__state)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x143B980", Offset = "0x143B980", VA = "0x143B980", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x143B984", Offset = "0x143B984", VA = "0x143B984", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x143C4D0", Offset = "0x143C4D0", VA = "0x143C4D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlatForm platform;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Pvr_UnitySDKManager sdk;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public float EyesAspect;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public int posStatus;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool ismirroring;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 resetBasePos;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public int trackingmode;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public int systemprop;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool systemFPS;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float[] headData;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool rotfoldout;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool hmdOnlyrot;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool controllerOnlyrot;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private TrackingOrigin trackingOrigin;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool ResetTrackerOnLoad;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public Vector3 leftEyeOffset;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Vector3 rightEyeOffset;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public Rect leftEyeRect;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Rect rightEyeRect;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public Matrix4x4 leftEyeView;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[HideInInspector]
	public Matrix4x4 rightEyeView;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public Pvr_UnitySDKEditor pvr_UnitySDKEditor;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private bool vrModeEnabled;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[HideInInspector]
	public Material Eyematerial;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[HideInInspector]
	public Material Middlematerial;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE264", Offset = "0x6CE264")]
	private bool <picovrTriggered>k__BackingField;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	[HideInInspector]
	public bool newPicovrTriggered;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
	[SerializeField]
	private bool showFPS;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	[HideInInspector]
	public Vector3 neckOffset;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private bool pVRNeck;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
	[HideInInspector]
	public bool UseCustomNeckPara;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
	[HideInInspector]
	public bool onResume;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
	[HideInInspector]
	public bool isEnterVRMode;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool isHasController;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Pvr_UnitySDKConfigProfile pvr_UnitySDKConfig;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject calltoast;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject msgtoast;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject lowhmdBatterytoast;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject lowphoneBatterytoast;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject LowPhoneHealthtoast;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject LowcontrollerBatterytoast;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool lowControllerpowerstate;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private float controllerpowershowtime;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool UseToast;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GameObject G3LiteTips;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private bool monoscopic;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
	private bool mIsAndroid7;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Func<bool> eventEnterVRMode;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
	[HideInInspector]
	public bool ShowVideoSeethrough;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	public int SystemDebugFFRLevel;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public int SystemFFRLevel;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public int AppCheckResult;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Action longPressHomeKeyAction;

	[Token(Token = "0x17000036")]
	public static Pvr_UnitySDKManager SDK
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1488E00", Offset = "0x1488E00", VA = "0x1488E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public bool Rotfoldout
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x149ABB4", Offset = "0x149ABB4", VA = "0x149ABB4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x149ABBC", Offset = "0x149ABBC", VA = "0x149ABBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public bool HmdOnlyrot
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x149ABDC", Offset = "0x149ABDC", VA = "0x149ABDC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x149ABE4", Offset = "0x149ABE4", VA = "0x149ABE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public bool ControllerOnlyrot
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x149AC04", Offset = "0x149AC04", VA = "0x149AC04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x149AC0C", Offset = "0x149AC0C", VA = "0x149AC0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public TrackingOrigin TrackingOrigin
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x149AC2C", Offset = "0x149AC2C", VA = "0x149AC2C")]
		get
		{
			return default(TrackingOrigin);
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x149AC34", Offset = "0x149AC34", VA = "0x149AC34")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	[HideInInspector]
	public bool VRModeEnabled
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x149ACE8", Offset = "0x149ACE8", VA = "0x149ACE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x14943E0", Offset = "0x14943E0", VA = "0x14943E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	[HideInInspector]
	public bool picovrTriggered
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x149ACF0", Offset = "0x149ACF0", VA = "0x149ACF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBC8", Offset = "0x6CFBC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x149ACF8", Offset = "0x149ACF8", VA = "0x149ACF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBD8", Offset = "0x6CFBD8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public bool ShowFPS
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x149AD04", Offset = "0x149AD04", VA = "0x149AD04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x149AD0C", Offset = "0x149AD0C", VA = "0x149AD0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public bool PVRNeck
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x149AD2C", Offset = "0x149AD2C", VA = "0x149AD2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x149AD34", Offset = "0x149AD34", VA = "0x149AD34")]
		set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	[HideInInspector]
	public bool Monoscopic
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x149AD54", Offset = "0x149AD54", VA = "0x149AD54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x149AD5C", Offset = "0x149AD5C", VA = "0x149AD5C")]
		set
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event EntitlementCheckResult EntitlementCheckResultEvent
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x149AD84", Offset = "0x149AD84", VA = "0x149AD84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBE8", Offset = "0x6CFBE8")]
		add
		{
		}
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x149AE74", Offset = "0x149AE74", VA = "0x149AE74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBF8", Offset = "0x6CFBF8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x149AC50", Offset = "0x149AC50", VA = "0x149AC50")]
	public void ChangeDefaultCustomRtSize(int w, int h)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x14957D0", Offset = "0x14957D0", VA = "0x14957D0")]
	public Vector3 EyeOffset(Eye eye)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x149ACAC", Offset = "0x149ACAC", VA = "0x149ACAC")]
	public Rect EyeRect(Eye eye)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x149AF64", Offset = "0x149AF64", VA = "0x149AF64")]
	private bool SDKManagerInit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x149B0B4", Offset = "0x149B0B4", VA = "0x149B0B4")]
	private bool SDKManagerInitCoreAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x149B1E8", Offset = "0x149B1E8", VA = "0x149B1E8")]
	public void smsReceivedCallback(string msg)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x149B908", Offset = "0x149B908", VA = "0x149B908")]
	public void phoneStateCallback(string state)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x149BC88", Offset = "0x149BC88", VA = "0x149BC88")]
	public void phoneBatteryStateCallback(string state)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x149BF38", Offset = "0x149BF38", VA = "0x149BF38")]
	public void hmdLowBatteryCallback(string level)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x149B568", Offset = "0x149B568", VA = "0x149B568")]
	private string TransformNumber(string number)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x149C070", Offset = "0x149C070", VA = "0x149C070")]
	public void onHmdOrientationReseted()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x149B86C", Offset = "0x149B86C", VA = "0x149B86C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFC08", Offset = "0x6CFC08")]
	private IEnumerator ToastManager(int type, bool state, float time)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x149C074", Offset = "0x149C074", VA = "0x149C074")]
	private void CheckControllerStateForG2(string state)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x149C220", Offset = "0x149C220", VA = "0x149C220")]
	public void notificationCallback(string data)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x149D198", Offset = "0x149D198", VA = "0x149D198")]
	private Sprite LoadSprite(Vector2 size, string filepath)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x149D2E4", Offset = "0x149D2E4", VA = "0x149D2E4")]
	private byte[] ReadTex(string path)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x149C5A8", Offset = "0x149C5A8", VA = "0x149C5A8")]
	private void SetProperty(int type, JsonData data, string value)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x149CAA4", Offset = "0x149CAA4", VA = "0x149CAA4")]
	private void SetBaseProperty(Transform trans, JsonData data, string value)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x149CE80", Offset = "0x149CE80", VA = "0x149CE80")]
	private void SetImageProperty(Transform image, JsonData data, string value)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x149D428", Offset = "0x149D428", VA = "0x149D428")]
	private void SetTextProperty(Transform text, JsonData data, string value)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x149D118", Offset = "0x149D118", VA = "0x149D118")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFC6C", Offset = "0x6CFC6C")]
	private IEnumerator G3TipsManager(GameObject tip, float time)
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x149D6DC", Offset = "0x149D6DC", VA = "0x149D6DC")]
	private float JsonToFloat(JsonData data)
	{
		return default(float);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x149D758", Offset = "0x149D758", VA = "0x149D758")]
	private bool SDKManagerInitFPS()
	{
		return default(bool);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x149B040", Offset = "0x149B040", VA = "0x149B040")]
	private bool SDKManagerInitConfigProfile()
	{
		return default(bool);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x149D910", Offset = "0x149D910", VA = "0x149D910")]
	private bool SDKManagerInitEditor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x149D9BC", Offset = "0x149D9BC", VA = "0x149D9BC")]
	private bool SDKManagerInitPara()
	{
		return default(bool);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x149D9C4", Offset = "0x149D9C4", VA = "0x149D9C4")]
	public void SDKManagerLongHomeKey()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x149DAD0", Offset = "0x149DAD0", VA = "0x149DAD0")]
	private void setLongHomeKey()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x149DD50", Offset = "0x149DD50", VA = "0x149DD50")]
	public void verifyAPPCallback(string code)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x149DE8C", Offset = "0x149DE8C", VA = "0x149DE8C")]
	public void IpdRefreshCallBack(string ipd)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x149DFBC", Offset = "0x149DFBC", VA = "0x149DFBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x149EF58", Offset = "0x149EF58", VA = "0x149EF58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFCD0", Offset = "0x6CFCD0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x149EFC8", Offset = "0x149EFC8", VA = "0x149EFC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFD34", Offset = "0x6CFD34")]
	private IEnumerator InitRenderThreadRoutine()
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x149F028", Offset = "0x149F028", VA = "0x149F028")]
	private void Update()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x149F2B4", Offset = "0x149F2B4", VA = "0x149F2B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x149F414", Offset = "0x149F414", VA = "0x149F414")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x149F544", Offset = "0x149F544", VA = "0x149F544")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x149F54C", Offset = "0x149F54C", VA = "0x149F54C")]
	private void OnPause()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x149F66C", Offset = "0x149F66C", VA = "0x149F66C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x149F914", Offset = "0x149F914", VA = "0x149F914")]
	public void EnterVRMode()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x149F5FC", Offset = "0x149F5FC", VA = "0x149F5FC")]
	public void LeaveVRMode()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x149F9FC", Offset = "0x149F9FC", VA = "0x149F9FC")]
	public void SixDofForceQuit()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x149E9B4", Offset = "0x149E9B4", VA = "0x149E9B4")]
	private void InitUI()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x149EBB0", Offset = "0x149EBB0", VA = "0x149EBB0")]
	private void RefreshTextByLanguage()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x149E5DC", Offset = "0x149E5DC", VA = "0x149E5DC")]
	private void LoadIsMirroringValue()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x149F8A4", Offset = "0x149F8A4", VA = "0x149F8A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFD98", Offset = "0x6CFD98")]
	private IEnumerator OnResume()
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x149FA04", Offset = "0x149FA04", VA = "0x149FA04")]
	public Pvr_UnitySDKManager()
	{
	}
}
[Token(Token = "0x200002B")]
public class QuitGame : MonoBehaviour
{
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1445878", Offset = "0x1445878", VA = "0x1445878")]
	private void Start()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x144587C", Offset = "0x144587C", VA = "0x144587C")]
	private void Update()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x14458A8", Offset = "0x14458A8", VA = "0x14458A8")]
	public QuitGame()
	{
	}
}
[Token(Token = "0x200002C")]
public class Pvr_UnityEyeMask : MonoBehaviour
{
	[Token(Token = "0x2000168")]
	private class EyeMaskData
	{
		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Eye eyeSide;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommandBuffer cmdBuf;

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x147F9D0", Offset = "0x147F9D0", VA = "0x147F9D0")]
		public EyeMaskData()
		{
		}
	}

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Shader eyeMaskShader;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material eyeMaskMaterial;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh eyeMaskMeshLeft;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Mesh eyeMaskMeshRight;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Mesh eyeMaskMeshBoth;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float zDir;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Color eyeMaskColor;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<EyeMaskData> cameraDataList;

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x147E0F8", Offset = "0x147E0F8", VA = "0x147E0F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x147E1B0", Offset = "0x147E1B0", VA = "0x147E1B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x147ED08", Offset = "0x147ED08", VA = "0x147ED08")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x147E744", Offset = "0x147E744", VA = "0x147E744")]
	private void CreateCommandBuffer()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x147F808", Offset = "0x147F808", VA = "0x147F808")]
	private void OnCustomPreRender(Camera cam)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x147F07C", Offset = "0x147F07C", VA = "0x147F07C")]
	private Mesh GetStencilMesh(Eye eyeSide)
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x147F3D4", Offset = "0x147F3D4", VA = "0x147F3D4")]
	private Mesh GetStencilMeshBoth(Mesh leftMesh, Mesh rightMesh)
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x147EF6C", Offset = "0x147EF6C", VA = "0x147EF6C")]
	private bool VerifyCommadBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x147E404", Offset = "0x147E404", VA = "0x147E404")]
	private void PrepareCameras()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x147F9A4", Offset = "0x147F9A4", VA = "0x147F9A4")]
	private void AddCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x147EED4", Offset = "0x147EED4", VA = "0x147EED4")]
	private void RemoveCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x147EF00", Offset = "0x147EF00", VA = "0x147EF00")]
	private void CleanEyeMask()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x147F9D8", Offset = "0x147F9D8", VA = "0x147F9D8")]
	public Pvr_UnityEyeMask()
	{
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CD45C", Offset = "0x6CD45C")]
public class Pvr_UnitySDKEye : MonoBehaviour
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEye> Instances;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Eye eyeSide;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE314", Offset = "0x6CE314")]
	private Camera <eyecamera>k__BackingField;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int eyeCameraOriginCullingMask;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private CameraClearFlags eyeCameraOriginClearFlag;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color eyeCameraOriginBackgroundColor;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int lastBoundaryState;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Matrix4x4 realProj;

	[Token(Token = "0x4000192")]
	private const int bufferSize = 3;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int IDIndex;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RenderEventType eventType;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int previousId;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool setLevel;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Material mat_Vignette;

	[Token(Token = "0x17000040")]
	public Camera eyecamera
	{
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x149449C", Offset = "0x149449C", VA = "0x149449C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDFC", Offset = "0x6CFDFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x14944A4", Offset = "0x14944A4", VA = "0x14944A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE0C", Offset = "0x6CFE0C")]
		private set
		{
		}
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x14944AC", Offset = "0x14944AC", VA = "0x14944AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x149454C", Offset = "0x149454C", VA = "0x149454C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1494ACC", Offset = "0x1494ACC", VA = "0x1494ACC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1494D00", Offset = "0x1494D00", VA = "0x1494D00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1494E28", Offset = "0x1494E28", VA = "0x1494E28")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1494F50", Offset = "0x1494F50", VA = "0x1494F50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1494FD4", Offset = "0x1494FD4", VA = "0x1494FD4")]
	public void MyPreRender(Camera camera)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x14951C0", Offset = "0x14951C0", VA = "0x14951C0")]
	public void MyPreRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1495280", Offset = "0x1495280", VA = "0x1495280")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1495094", Offset = "0x1495094", VA = "0x1495094")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1495340", Offset = "0x1495340", VA = "0x1495340")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1495654", Offset = "0x1495654", VA = "0x1495654")]
	public void EyeRender()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1494624", Offset = "0x1494624", VA = "0x1494624")]
	private void Setup(Eye eyeSide)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1494834", Offset = "0x1494834", VA = "0x1494834")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x148D810", Offset = "0x148D810", VA = "0x148D810")]
	public void RefreshCameraPosition(float ipd)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1495808", Offset = "0x1495808", VA = "0x1495808")]
	private void DrawVignetteLine()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1495934", Offset = "0x1495934", VA = "0x1495934")]
	private void vignette()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x14954D8", Offset = "0x14954D8", VA = "0x14954D8")]
	private void SetFFRParameter()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1495BB4", Offset = "0x1495BB4", VA = "0x1495BB4")]
	public Pvr_UnitySDKEye()
	{
	}
}
[Token(Token = "0x200002E")]
public class Pvr_UnitySDKEyeManager : MonoBehaviour
{
	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD804", Offset = "0x6CD804")]
	private sealed class <EndOfFrame>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKEyeManager <>4__this;

		[Token(Token = "0x17000117")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x14995D8", Offset = "0x14995D8", VA = "0x14995D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x1499640", Offset = "0x1499640", VA = "0x1499640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x1497BA0", Offset = "0x1497BA0", VA = "0x1497BA0")]
		[DebuggerHidden]
		public <EndOfFrame>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x14986D4", Offset = "0x14986D4", VA = "0x14986D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x14986D8", Offset = "0x14986D8", VA = "0x14986D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x14995E0", Offset = "0x14995E0", VA = "0x14995E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD814", Offset = "0x6CD814")]
	private sealed class <ScreenFade>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKEyeManager <>4__this;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startAlpha;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float endAlpha;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000119")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x149977C", Offset = "0x149977C", VA = "0x149977C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x14997E4", Offset = "0x14997E4", VA = "0x14997E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x1498620", Offset = "0x1498620", VA = "0x1498620")]
		[DebuggerHidden]
		public <ScreenFade>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x1499648", Offset = "0x1499648", VA = "0x1499648", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x149964C", Offset = "0x149964C", VA = "0x149964C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x1499784", Offset = "0x1499784", VA = "0x1499784", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKEyeManager instance;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Pvr_UnitySDKEye[] eyes;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Camera LeftEyeCamera;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Camera RightEyeCamera;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Camera MonoEyeCamera;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Camera BothEyeCamera;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int MonoEyeTextureID;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private readonly int WaitSplashScreenFrames;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int frameNum;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[HideInInspector]
	private bool foveatedRendering;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private EFoveationLevel foveationLevel;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int eyeTextureId;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RenderEventType eventType;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Pvr_UnitySDKEyeOverlay compositeLayer;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int overlayLayerDepth;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int underlayLayerDepth;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isHeadLocked;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int layerFlags;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public bool EyeTracking;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 eyePoint;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private EyeTrackingData eyePoseData;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static bool supportEyeTracking;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE404", Offset = "0x6CE404")]
	public bool screenFade;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE43C", Offset = "0x6CE43C")]
	public float fadeTime;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE474", Offset = "0x6CE474")]
	public Color fadeColor;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int renderQueue;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private MeshRenderer fadeMeshRenderer;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private MeshFilter fadeMeshFilter;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Material fadeMaterial;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float elapsedTime;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool isFading;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private float currentAlpha;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float nowFadeAlpha;

	[Token(Token = "0x17000041")]
	public static Pvr_UnitySDKEyeManager Instance
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x148D688", Offset = "0x148D688", VA = "0x148D688")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public Pvr_UnitySDKEye[] Eyes
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x148D780", Offset = "0x148D780", VA = "0x148D780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	[HideInInspector]
	public bool FoveatedRendering
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1495CCC", Offset = "0x1495CCC", VA = "0x1495CCC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1495CD4", Offset = "0x1495CD4", VA = "0x1495CD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	[HideInInspector]
	public EFoveationLevel FoveationLevel
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1495D38", Offset = "0x1495D38", VA = "0x1495D38")]
		get
		{
			return default(EFoveationLevel);
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1495D40", Offset = "0x1495D40", VA = "0x1495D40")]
		set
		{
		}
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1495D54", Offset = "0x1495D54", VA = "0x1495D54")]
	private void SetCameraEnableEditor()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1495F64", Offset = "0x1495F64", VA = "0x1495F64")]
	private void SetCamerasEnableByStereoRendering()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1496028", Offset = "0x1496028", VA = "0x1496028")]
	private void SetupMonoCamera()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x149613C", Offset = "0x149613C", VA = "0x149613C")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1496218", Offset = "0x1496218", VA = "0x1496218")]
	private void MonoEyeRender()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x1496394", Offset = "0x1496394", VA = "0x1496394")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x1496B3C", Offset = "0x1496B3C", VA = "0x1496B3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x14973C4", Offset = "0x14973C4", VA = "0x14973C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x14973E8", Offset = "0x14973E8", VA = "0x14973E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1497644", Offset = "0x1497644", VA = "0x1497644")]
	private void OnPause()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1497728", Offset = "0x1497728", VA = "0x1497728")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x14978D0", Offset = "0x14978D0", VA = "0x14978D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x14979C8", Offset = "0x14979C8", VA = "0x14979C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x14977E4", Offset = "0x14977E4", VA = "0x14977E4")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1497B30", Offset = "0x1497B30", VA = "0x1497B30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFE1C", Offset = "0x6CFE1C")]
	private IEnumerator EndOfFrame()
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1497BCC", Offset = "0x1497BCC", VA = "0x1497BCC")]
	private void CreateExternalSurface(Pvr_UnitySDKEyeOverlay overlayInstance, int layerDepth)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1497FB4", Offset = "0x1497FB4", VA = "0x1497FB4")]
	public bool SetEyeTrackingMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x148E620", Offset = "0x148E620", VA = "0x148E620")]
	public Vector3 GetEyeTrackingPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x149826C", Offset = "0x149826C", VA = "0x149826C")]
	private EyeDeviceInfo GetDeviceInfo()
	{
		return default(EyeDeviceInfo);
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x14966D0", Offset = "0x14966D0", VA = "0x14966D0")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x14979CC", Offset = "0x14979CC", VA = "0x14979CC")]
	private void DestoryFadeMesh()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x1496B34", Offset = "0x1496B34", VA = "0x1496B34")]
	public void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1497340", Offset = "0x1497340", VA = "0x1497340")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFE80", Offset = "0x6CFE80")]
	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x14984C8", Offset = "0x14984C8", VA = "0x14984C8")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x14971F0", Offset = "0x14971F0", VA = "0x14971F0")]
	public bool GfxDeviceAdvanceFrameGLES()
	{
		return default(bool);
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x149864C", Offset = "0x149864C", VA = "0x149864C")]
	public Pvr_UnitySDKEyeManager()
	{
	}
}
[Token(Token = "0x200002F")]
public class Pvr_UnitySDKEyeOverlay : MonoBehaviour, IComparable<Pvr_UnitySDKEyeOverlay>
{
	[Token(Token = "0x200016B")]
	public delegate void ExternalAndroidSurfaceObjectCreated();

	[Token(Token = "0x200016C")]
	public enum OverlayShape
	{
		[Token(Token = "0x4000B3B")]
		Quad,
		[Token(Token = "0x4000B3C")]
		Cylinder,
		[Token(Token = "0x4000B3D")]
		Equirect
	}

	[Token(Token = "0x200016D")]
	public enum OverlayType
	{
		[Token(Token = "0x4000B3F")]
		Overlay,
		[Token(Token = "0x4000B40")]
		Underlay
	}

	[Token(Token = "0x200016E")]
	public enum OverlayTexFilterMode
	{
		[Token(Token = "0x4000B42")]
		NotCare,
		[Token(Token = "0x4000B43")]
		Nearest,
		[Token(Token = "0x4000B44")]
		Linear,
		[Token(Token = "0x4000B45")]
		Nearest_Mipmap_Nearest,
		[Token(Token = "0x4000B46")]
		Linear_Mipmap_Nearest,
		[Token(Token = "0x4000B47")]
		Nearest_Mipmap_Linear,
		[Token(Token = "0x4000B48")]
		Linear_Mipmap_Linear
	}

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEyeOverlay> Instances;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int layerIndex;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public OverlayType overlayType;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OverlayShape overlayShape;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform layerTransform;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] layerTextures;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int[] layerTextureIds;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Matrix4x4[] MVMatrixs;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] ModelScales;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Quaternion[] ModelRotations;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3[] ModelTranslations;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Quaternion[] CameraRotations;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] CameraTranslations;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Camera[] layerEyeCamera;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool overrideColorScaleAndOffset;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector4 colorScale;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Vector4 colorOffset;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector4 overlayLayerColorScaleDefault;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Vector4 overlayLayerColorOffsetDefault;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool isExternalAndroidSurface;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public IntPtr externalAndroidSurfaceObject;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x14997EC", Offset = "0x14997EC", VA = "0x14997EC", Slot = "4")]
	public int CompareTo(Pvr_UnitySDKEyeOverlay other)
	{
		return default(int);
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x149980C", Offset = "0x149980C", VA = "0x149980C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x1499CF0", Offset = "0x1499CF0", VA = "0x1499CF0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x149A1A4", Offset = "0x149A1A4", VA = "0x149A1A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1496FB8", Offset = "0x1496FB8", VA = "0x1496FB8")]
	public void RefreshCamera()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1499B3C", Offset = "0x1499B3C", VA = "0x1499B3C")]
	private void InitializeBuffer()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1499CF4", Offset = "0x1499CF4", VA = "0x1499CF4")]
	private void UpdateCoords()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x149A228", Offset = "0x149A228", VA = "0x149A228")]
	public void SetTexture(Texture texture)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x149A2C0", Offset = "0x149A2C0", VA = "0x149A2C0")]
	public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x1499558", Offset = "0x1499558", VA = "0x1499558")]
	public Vector4 GetLayerColorScale()
	{
		return default(Vector4);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x1499598", Offset = "0x1499598", VA = "0x1499598")]
	public Vector4 GetLayerColorOffset()
	{
		return default(Vector4);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x149A2D4", Offset = "0x149A2D4", VA = "0x149A2D4")]
	public Pvr_UnitySDKEyeOverlay()
	{
	}
}
[Token(Token = "0x2000030")]
public class Pvr_UnitySDKRender
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKRender instance;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaObject activity;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static AndroidJavaClass javaVrActivityClass;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static AndroidJavaClass javaSysActivityClass;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static AndroidJavaClass javaserviceClass;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static AndroidJavaClass javaVrActivityLongReceiver;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static AndroidJavaClass javaVrActivityClientClass;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool canConnecttoActivity;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isInitrenderThread;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string model;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 prefinger1;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 prefinger2;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int eyeTextureCount;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RenderTexture[] eyeTextures;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] eyeTextureIds;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int currEyeTextureIdx;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int nextEyeTextureIdx;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int lastEyeTextureIdx;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isSwitchSDK;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int RenderviewNumber;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool isFirstStartup;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool isShellMode;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private StereoRenderingPathPico stereoRenderPath;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE4AC", Offset = "0x6CE4AC")]
	private SDKStereoRendering <StereoRendering>k__BackingField;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float rtScaleFactor;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float eyeVFov;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float eyeHFov;

	[Token(Token = "0x17000045")]
	public static Pvr_UnitySDKRender Instance
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x143B6D4", Offset = "0x143B6D4", VA = "0x143B6D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x143DC88", Offset = "0x143DC88", VA = "0x143DC88")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public StereoRenderingPathPico StereoRenderPath
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x143E61C", Offset = "0x143E61C", VA = "0x143E61C")]
		get
		{
			return default(StereoRenderingPathPico);
		}
	}

	[Token(Token = "0x17000047")]
	public SDKStereoRendering StereoRendering
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x143E624", Offset = "0x143E624", VA = "0x143E624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEE4", Offset = "0x6CFEE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x143E62C", Offset = "0x143E62C", VA = "0x143E62C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEF4", Offset = "0x6CFEF4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public float RtScaleFactor
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x143E634", Offset = "0x143E634", VA = "0x143E634")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x143E63C", Offset = "0x143E63C", VA = "0x143E63C")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public float EyeVFoV
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x143E79C", Offset = "0x143E79C", VA = "0x143E79C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x143E7A4", Offset = "0x143E7A4", VA = "0x143E7A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public float EyeHFoV
	{
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x143E7B8", Offset = "0x143E7B8", VA = "0x143E7B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x143E7C0", Offset = "0x143E7C0", VA = "0x143E7C0")]
		set
		{
		}
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x143DB78", Offset = "0x143DB78", VA = "0x143DB78")]
	public Pvr_UnitySDKRender()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x143DCF4", Offset = "0x143DCF4", VA = "0x143DCF4")]
	public void ConnectToAndriod()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x143E59C", Offset = "0x143E59C", VA = "0x143E59C")]
	public void Init()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x143EC18", Offset = "0x143EC18", VA = "0x143EC18")]
	private bool InitRenderAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x143ED34", Offset = "0x143ED34", VA = "0x143ED34")]
	private bool UpdateRenderParaFrame()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x143EDE0", Offset = "0x143EDE0", VA = "0x143EDE0")]
	private bool CreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x143F78C", Offset = "0x143F78C", VA = "0x143F78C")]
	private void InitSinglePass()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x143F134", Offset = "0x143F134", VA = "0x143F134")]
	public float GetEyeVFOV()
	{
		return default(float);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x143F294", Offset = "0x143F294", VA = "0x143F294")]
	public float GetEyeHFOV()
	{
		return default(float);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x143F9CC", Offset = "0x143F9CC", VA = "0x143F9CC")]
	private void ConfigureEyeBuffer(int eyeTextureIndex, Vector2 resolution)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x143E654", Offset = "0x143E654", VA = "0x143E654")]
	public bool ReCreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x143C7DC", Offset = "0x143C7DC", VA = "0x143C7DC")]
	public void ReInit()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x143B794", Offset = "0x143B794", VA = "0x143B794")]
	public void IssueRenderThread()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x143FF10", Offset = "0x143FF10", VA = "0x143FF10")]
	private void AutoAdpatForPico1s()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x143F3F4", Offset = "0x143F3F4", VA = "0x143F3F4")]
	public Vector2 GetEyeBufferResolution()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1440138", Offset = "0x1440138", VA = "0x1440138")]
	public bool GetUsePredictedMatrix()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x143E7D4", Offset = "0x143E7D4", VA = "0x143E7D4")]
	public bool GetIsShellMode()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000031")]
public class Pvr_UnitySDKSinglePass : SDKStereoRendering
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera bothCamera;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Matrix4x4[] unity_StereoMatrixP;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Matrix4x4[] unity_StereoMatrixInvP;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Matrix4x4[] unity_StereoWorldToCamera;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Matrix4x4[] unity_StereoCameraToWorld;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Matrix4x4[] unity_StereoMatrixVP;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] eyesOffset;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Matrix4x4[] eyesOffsetMatrix;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CommandBuffer commandBufferBeforeForwardOpaque;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommandBuffer commandBufferBeforeSkybox;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CommandBuffer commandBufferAfterSkybox;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x144301C", Offset = "0x144301C", VA = "0x144301C", Slot = "4")]
	public override void InitEye(Camera eye)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1443894", Offset = "0x1443894", VA = "0x1443894", Slot = "5")]
	public override void OnSDKRenderInited()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x14439BC", Offset = "0x14439BC", VA = "0x14439BC", Slot = "6")]
	public override void OnSDKPreRender()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x14441E0", Offset = "0x14441E0", VA = "0x14441E0", Slot = "7")]
	public override void OnSDKPostRender()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1443898", Offset = "0x1443898", VA = "0x1443898")]
	public void OnSDKRenderInited_SinglePass()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1444298", Offset = "0x1444298", VA = "0x1444298")]
	private void SetAntiAliasing()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1443338", Offset = "0x1443338", VA = "0x1443338")]
	public void SetEyesPosition()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x144374C", Offset = "0x144374C", VA = "0x144374C")]
	public void SetEyeProjection()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x14443A0", Offset = "0x14443A0", VA = "0x14443A0")]
	private static Matrix4x4 GetProjection(float near, float far)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x14445B8", Offset = "0x14445B8", VA = "0x14445B8")]
	public static Matrix4x4 MakeProjection(float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1444474", Offset = "0x1444474", VA = "0x1444474")]
	public void SetStereoProjectionMatrix(Matrix4x4 left, Matrix4x4 right)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x14441E8", Offset = "0x14441E8", VA = "0x14441E8")]
	private void SwitchKeywordAndDeviceView(bool enable)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1444794", Offset = "0x1444794", VA = "0x1444794")]
	public static Matrix4x4[] GetStereoWorldToCameraMat()
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x14439C0", Offset = "0x14439C0", VA = "0x14439C0")]
	public void SinglePassPreRender()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x1444A40", Offset = "0x1444A40", VA = "0x1444A40")]
	private void SetCommandBuffers()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x14449A0", Offset = "0x14449A0", VA = "0x14449A0")]
	private void SetRenderTextureWithDepth()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x143FE68", Offset = "0x143FE68", VA = "0x143FE68")]
	public Pvr_UnitySDKSinglePass()
	{
	}
}
[Token(Token = "0x2000032")]
public abstract class SDKStereoRendering
{
	[Token(Token = "0x6000300")]
	public abstract void InitEye(Camera eye);

	[Token(Token = "0x6000301")]
	public abstract void OnSDKRenderInited();

	[Token(Token = "0x6000302")]
	public abstract void OnSDKPreRender();

	[Token(Token = "0x6000303")]
	public abstract void OnSDKPostRender();

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1445090", Offset = "0x1445090", VA = "0x1445090")]
	protected SDKStereoRendering()
	{
	}
}
[Token(Token = "0x2000033")]
public class HighlightAtGaze : MonoBehaviour
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color HighlightColor;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float AnimationTime;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer myRenderer;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color originalColor;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color targetColor;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x99E908", Offset = "0x99E908", VA = "0x99E908")]
	private void Start()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x99E98C", Offset = "0x99E98C", VA = "0x99E98C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x99EB68", Offset = "0x99EB68", VA = "0x99EB68")]
	public HighlightAtGaze()
	{
	}
}
[Token(Token = "0x2000034")]
public class RayVisualizer : MonoBehaviour
{
	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer _line;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x14458B0", Offset = "0x14458B0", VA = "0x14458B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1445948", Offset = "0x1445948", VA = "0x1445948")]
	private void Update()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x1445AE0", Offset = "0x1445AE0", VA = "0x1445AE0")]
	public RayVisualizer()
	{
	}
}
[Token(Token = "0x2000035")]
public class GetSeeThroughImage : MonoBehaviour
{
	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RawImage viewImage_left;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage viewImage_right;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int width;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int height;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture cameraTex_left;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture cameraTex_right;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool cameraPreview;

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x99E744", Offset = "0x99E744", VA = "0x99E744")]
	private void Start()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x99E85C", Offset = "0x99E85C", VA = "0x99E85C")]
	private void Update()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x99E8E8", Offset = "0x99E8E8", VA = "0x99E8E8")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x99E748", Offset = "0x99E748", VA = "0x99E748")]
	private void CreateTexture()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x99E898", Offset = "0x99E898", VA = "0x99E898")]
	private void DrawTexture()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x99E900", Offset = "0x99E900", VA = "0x99E900")]
	public GetSeeThroughImage()
	{
	}
}
[Token(Token = "0x2000036")]
public class OverlayExternalSurfaceDemo : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD824", Offset = "0x6CD824")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Pvr_UnitySDKEyeOverlay.ExternalAndroidSurfaceObjectCreated <>9__7_0;

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x9DD02C", Offset = "0x9DD02C", VA = "0x9DD02C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x9DD034", Offset = "0x9DD034", VA = "0x9DD034")]
		internal void <StartPlay>b__7_0()
		{
		}
	}

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string movieName;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Pvr_UnitySDKEyeOverlay.OverlayType overlayType;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Pvr_UnitySDKEyeOverlay.OverlayShape overlayShape;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Pvr_UnitySDKEyeOverlay overlay;

	[Token(Token = "0x4000208")]
	private const string TAG = "[ExternalSurface]>>>>>>";

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x9DCC28", Offset = "0x9DCC28", VA = "0x9DCC28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x9DCD4C", Offset = "0x9DCD4C", VA = "0x9DCD4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x9DCDD0", Offset = "0x9DCDD0", VA = "0x9DCDD0")]
	private void StartPlay(string moviePath, string licenceUrl)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x9DCFC0", Offset = "0x9DCFC0", VA = "0x9DCFC0")]
	public OverlayExternalSurfaceDemo()
	{
	}
}
[Token(Token = "0x2000037")]
public class MoveCylinder : MonoBehaviour
{
	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startingPosition;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion startingRotation;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x10838F0", Offset = "0x10838F0", VA = "0x10838F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x108394C", Offset = "0x108394C", VA = "0x108394C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x10839A4", Offset = "0x10839A4", VA = "0x10839A4")]
	public MoveCylinder()
	{
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CD4C0", Offset = "0x6CD4C0")]
public class MoveSphere : MonoBehaviour
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startingPosition;

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x10839AC", Offset = "0x10839AC", VA = "0x10839AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x1083B20", Offset = "0x1083B20", VA = "0x1083B20")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x1083A88", Offset = "0x1083A88", VA = "0x1083A88")]
	public void SetGazedAt(bool gazedAt)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x1083B24", Offset = "0x1083B24", VA = "0x1083B24")]
	public void Reset()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x1083C24", Offset = "0x1083C24", VA = "0x1083C24")]
	public void TeleportRandomly()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x1083D30", Offset = "0x1083D30", VA = "0x1083D30")]
	public MoveSphere()
	{
	}
}
[Token(Token = "0x2000039")]
public class Resetbutton : MonoBehaviour
{
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x1445AF8", Offset = "0x1445AF8", VA = "0x1445AF8")]
	public void DemoResetTracking()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x1445B8C", Offset = "0x1445B8C", VA = "0x1445B8C")]
	public Resetbutton()
	{
	}
}
[Token(Token = "0x200003A")]
public class UserEntitlementCheck : MonoBehaviour
{
	[Token(Token = "0x6000320")]
	[Address(RVA = "0x8B55F4", Offset = "0x8B55F4", VA = "0x8B55F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x8B5688", Offset = "0x8B5688", VA = "0x8B5688")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x8B571C", Offset = "0x8B571C", VA = "0x8B571C")]
	private void HandelEntitlementCheckResult(int resultCode)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8B59E8", Offset = "0x8B59E8", VA = "0x8B59E8")]
	public UserEntitlementCheck()
	{
	}
}
[Token(Token = "0x200003B")]
public class Pvr_SQPLoader : MonoBehaviour
{
	[Token(Token = "0x2000170")]
	private struct SceneInfo
	{
		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<string> scenes;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long version;

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x147821C", Offset = "0x147821C", VA = "0x147821C")]
		public SceneInfo(List<string> sceneList, long currentSceneEpochVersion)
		{
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD834", Offset = "0x6CD834")]
	private sealed class <onCheckNewSceneCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_SQPLoader <>4__this;

		[Token(Token = "0x1700011B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x14781AC", Offset = "0x14781AC", VA = "0x14781AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x1478214", Offset = "0x1478214", VA = "0x1478214", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1477D94", Offset = "0x1477D94", VA = "0x1477D94")]
		[DebuggerHidden]
		public <onCheckNewSceneCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1477E40", Offset = "0x1477E40", VA = "0x1477E40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x1477E44", Offset = "0x1477E44", VA = "0x1477E44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x14781B4", Offset = "0x14781B4", VA = "0x14781B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400020C")]
	public const string RESOURCE_BUNDLE_NAME = "asset_resources";

	[Token(Token = "0x400020D")]
	public const string EXTERNAL_STORAGE_PATH = "/sdcard/Android/data";

	[Token(Token = "0x400020E")]
	public const string SCENE_LOAD_DATA_NAME = "SceneLoadData.txt";

	[Token(Token = "0x400020F")]
	private const string SQP_INDEX_NAME = "PvrSQPIndex";

	[Token(Token = "0x4000210")]
	private const string CACHE_SCENES_PATH = "cache/scenes";

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOperation loadSceneOperation;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string scenePath;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string sceneLoadDataPath;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AssetBundle> loadedAssetBundles;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SceneInfo currentSceneInfo;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x147752C", Offset = "0x147752C", VA = "0x147752C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x14775A8", Offset = "0x14775A8", VA = "0x14775A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1477CF4", Offset = "0x1477CF4", VA = "0x1477CF4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x14776B4", Offset = "0x14776B4", VA = "0x14776B4")]
	private SceneInfo GetSceneInfo()
	{
		return default(SceneInfo);
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1477878", Offset = "0x1477878", VA = "0x1477878")]
	private void LoadScene(SceneInfo sceneInfo)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1477CF8", Offset = "0x1477CF8", VA = "0x1477CF8")]
	private void LoadSceneOperation_completed(AsyncOperation obj)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1477D24", Offset = "0x1477D24", VA = "0x1477D24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFF04", Offset = "0x6CFF04")]
	private IEnumerator onCheckNewSceneCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1477DC0", Offset = "0x1477DC0", VA = "0x1477DC0")]
	public Pvr_SQPLoader()
	{
	}
}
[Token(Token = "0x200003C")]
public class Pvr_UnitySDKHeadTrack : MonoBehaviour
{
	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE4BC", Offset = "0x6CE4BC")]
	public bool trackRotation;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE4F4", Offset = "0x6CE4F4")]
	public bool trackPosition;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool updated;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool dataClock;

	[Token(Token = "0x1700004B")]
	public Ray Gaze
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x149A6A4", Offset = "0x149A6A4", VA = "0x149A6A4")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x149AB9C", Offset = "0x149AB9C", VA = "0x149AB9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x149A740", Offset = "0x149A740", VA = "0x149A740")]
	private void UpdateHead()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x149ABA4", Offset = "0x149ABA4", VA = "0x149ABA4")]
	public Pvr_UnitySDKHeadTrack()
	{
	}
}
[Token(Token = "0x200003D")]
public class Pvr_UnitySDKPose
{
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly Matrix4x4 flipZ;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE52C", Offset = "0x6CE52C")]
	private Vector3 <Position>k__BackingField;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE53C", Offset = "0x6CE53C")]
	private Quaternion <Orientation>k__BackingField;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE54C", Offset = "0x6CE54C")]
	private Matrix4x4 <Matrix>k__BackingField;

	[Token(Token = "0x1700004C")]
	public Matrix4x4 RightHandedMatrix
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x143D450", Offset = "0x143D450", VA = "0x143D450")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x1700004D")]
	public Vector3 Position
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x143D594", Offset = "0x143D594", VA = "0x143D594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF68", Offset = "0x6CFF68")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x143D5A0", Offset = "0x143D5A0", VA = "0x143D5A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF78", Offset = "0x6CFF78")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public Quaternion Orientation
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x143D5AC", Offset = "0x143D5AC", VA = "0x143D5AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF88", Offset = "0x6CFF88")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x143D5B8", Offset = "0x143D5B8", VA = "0x143D5B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF98", Offset = "0x6CFF98")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public Matrix4x4 Matrix
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x143D5C4", Offset = "0x143D5C4", VA = "0x143D5C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFA8", Offset = "0x6CFFA8")]
		get
		{
			return default(Matrix4x4);
		}
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x143D5E0", Offset = "0x143D5E0", VA = "0x143D5E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFB8", Offset = "0x6CFFB8")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x143D5FC", Offset = "0x143D5FC", VA = "0x143D5FC")]
	public Pvr_UnitySDKPose(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x143D7B4", Offset = "0x143D7B4", VA = "0x143D7B4")]
	public Pvr_UnitySDKPose(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x143D834", Offset = "0x143D834", VA = "0x143D834")]
	public void Set(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x143D648", Offset = "0x143D648", VA = "0x143D648")]
	protected void Set(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x143D964", Offset = "0x143D964", VA = "0x143D964")]
	private Quaternion NormalizeQuaternion(ref Quaternion q)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x200003E")]
public class Pvr_UnitySDKSensor
{
	[Token(Token = "0x2000172")]
	public delegate void Enter3DofModel();

	[Token(Token = "0x2000173")]
	public delegate void Exit3DofModel();

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKSensor instance;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool SensorStart;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool SensorInit;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Quaternion UnityQuaternion;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 UnityPosition;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Sensorindex sensorIndex;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool dofClock;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action EyeFovChanged;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Pvr_UnitySDKPose HeadPose;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float vfov;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float hfov;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float w;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float x;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float y;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float z;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float px;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float py;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float pz;

	[Token(Token = "0x17000050")]
	public static Pvr_UnitySDKSensor Instance
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x143BF68", Offset = "0x143BF68", VA = "0x143BF68")]
		get
		{
			return null;
		}
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1440200", Offset = "0x1440200", VA = "0x1440200")]
		set
		{
		}
	}

	[Token(Token = "0x14000016")]
	public static event Enter3DofModel Enter3DofModelEvent
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14403A0", Offset = "0x14403A0", VA = "0x14403A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFC8", Offset = "0x6CFFC8")]
		add
		{
		}
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1440490", Offset = "0x1440490", VA = "0x1440490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFD8", Offset = "0x6CFFD8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public static event Exit3DofModel Exit3DofModelEvent
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1440580", Offset = "0x1440580", VA = "0x1440580")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFE8", Offset = "0x6CFFE8")]
		add
		{
		}
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1440670", Offset = "0x1440670", VA = "0x1440670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFFF8", Offset = "0x6CFFF8")]
		remove
		{
		}
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x1440144", Offset = "0x1440144", VA = "0x1440144")]
	public Pvr_UnitySDKSensor()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x144026C", Offset = "0x144026C", VA = "0x144026C")]
	public void Init()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x1440AE4", Offset = "0x1440AE4", VA = "0x1440AE4")]
	public void SensorUpdate()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x14409A8", Offset = "0x14409A8", VA = "0x14409A8")]
	public bool InitUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1440760", Offset = "0x1440760", VA = "0x1440760")]
	public bool InitUnitySDK6DofSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x143C028", Offset = "0x143C028", VA = "0x143C028")]
	public bool StartUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1441B40", Offset = "0x1441B40", VA = "0x1441B40")]
	public bool StopUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x143C164", Offset = "0x143C164", VA = "0x143C164")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x143C2E0", Offset = "0x143C2E0", VA = "0x143C2E0")]
	public bool OptionalResetUnitySDKSensor(int resetRot, int resetPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1440B30", Offset = "0x1440B30", VA = "0x1440B30")]
	public bool GetUnitySDKSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1442234", Offset = "0x1442234", VA = "0x1442234")]
	public bool GetUnitySDKPSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1442094", Offset = "0x1442094", VA = "0x1442094")]
	private void RefreshHeadData(float x, float y, float z, float w, float px, float py, float pz)
	{
	}
}
[Token(Token = "0x200003F")]
public class CLoadingAsset : ScriptableObject
{
	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int SplashScreenType;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> splashImage;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D Inside_background;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseSplashText;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string DefaultText;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string ChineseText;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string EnglishText;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string JapaneseText;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string KoreanText;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string FontSize;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color FontColor;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string TextHeight;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool UseCarousel;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int SplashTextAlignment;

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x99BB88", Offset = "0x99BB88", VA = "0x99BB88")]
	public CLoadingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000040")]
public class Pvr_UnitySDKConfigProfile
{
	[Token(Token = "0x2000174")]
	public struct Lenses
	{
		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float separation;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float offset;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float distance;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int alignment;

		[Token(Token = "0x4000B54")]
		public const int AlignTop = -1;

		[Token(Token = "0x4000B55")]
		public const int AlignCenter = 0;

		[Token(Token = "0x4000B56")]
		public const int AlignBottom = 1;
	}

	[Token(Token = "0x2000175")]
	public struct MaxFOV
	{
		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float upper;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float lower;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float inner;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float outer;
	}

	[Token(Token = "0x2000176")]
	public struct Distortion
	{
		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float k1;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float k2;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float k3;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float k4;

		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float k5;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float k6;

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x1493148", Offset = "0x1493148", VA = "0x1493148")]
		public float distort(float r)
		{
			return default(float);
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x1492C74", Offset = "0x1492C74", VA = "0x1492C74")]
		public float distort(float r, float dist)
		{
			return default(float);
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x1493150", Offset = "0x1493150", VA = "0x1493150")]
		public float diatortInv(float radious)
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000177")]
	public struct Device
	{
		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Lenses devLenses;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MaxFOV devMaxFov;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Distortion devDistortion;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Distortion devDistortionInv;
	}

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Device SimulateDevice;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Device device;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly Pvr_UnitySDKConfigProfile Default;

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x14928F4", Offset = "0x14928F4", VA = "0x14928F4")]
	public Pvr_UnitySDKConfigProfile Clone()
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x149298C", Offset = "0x149298C", VA = "0x149298C")]
	public static Pvr_UnitySDKConfigProfile GetPicoProfile()
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1492A34", Offset = "0x1492A34", VA = "0x1492A34")]
	public float[] GetLeftEyeVisibleTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1492D80", Offset = "0x1492D80", VA = "0x1492D80")]
	public float[] GetLeftEyeNoLensTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1492FAC", Offset = "0x1492FAC", VA = "0x1492FAC")]
	public Rect GetLeftEyeVisibleScreenRect(float[] undistortedFrustum, float width, float height)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1492984", Offset = "0x1492984", VA = "0x1492984")]
	public Pvr_UnitySDKConfigProfile()
	{
	}
}
[Token(Token = "0x2000041")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CD524", Offset = "0x6CD524")]
public class Pvr_UnitySDKFPS : MonoBehaviour
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text fpsText;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float updateInterval;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float accum;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frames;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timeLeft;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string strFps;

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x149A504", Offset = "0x149A504", VA = "0x149A504")]
	private void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x149A58C", Offset = "0x149A58C", VA = "0x149A58C")]
	private void ShowFps()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x149A694", Offset = "0x149A694", VA = "0x149A694")]
	public Pvr_UnitySDKFPS()
	{
	}
}
[Token(Token = "0x2000042")]
public class Pvr_GazeFuse : MonoBehaviour
{
	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gazeGameObject;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image image;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1472F38", Offset = "0x1472F38", VA = "0x1472F38")]
	private void Start()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1472F90", Offset = "0x1472F90", VA = "0x1472F90")]
	private void Update()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x14730C4", Offset = "0x14730C4", VA = "0x14730C4")]
	private void FuseAmountChanged(float fuseAmount)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x147316C", Offset = "0x147316C", VA = "0x147316C")]
	public Pvr_GazeFuse()
	{
	}
}
[Token(Token = "0x2000043")]
public class Pvr_GazeInputModule : PointerInputModule
{
	[Token(Token = "0x2000178")]
	public enum Mode
	{
		[Token(Token = "0x4000B66")]
		Click,
		[Token(Token = "0x4000B67")]
		Gaze
	}

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Mode mode;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE57C", Offset = "0x6CE57C")]
	public string ClickInputName;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE5B4", Offset = "0x6CE5B4")]
	public float GazeTimeInSeconds;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE5EC", Offset = "0x6CE5EC")]
	private static float <gazeFraction>k__BackingField;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE5FC", Offset = "0x6CE5FC")]
	private static GameObject <gazeGameObject>k__BackingField;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RaycastResult CurrentRaycast;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private PointerEventData pointerEventData;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject currentLookAtHandler;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float currentLookAtHandlerClickTime;

	[Token(Token = "0x17000051")]
	public static float gazeFraction
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1473174", Offset = "0x1473174", VA = "0x1473174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0008", Offset = "0x6D0008")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x14731C4", Offset = "0x14731C4", VA = "0x14731C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0018", Offset = "0x6D0018")]
		private set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public static GameObject gazeGameObject
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1473220", Offset = "0x1473220", VA = "0x1473220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0028", Offset = "0x6D0028")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1473270", Offset = "0x1473270", VA = "0x1473270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0038", Offset = "0x6D0038")]
		private set
		{
		}
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x14732C4", Offset = "0x14732C4", VA = "0x14732C4", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x14732E8", Offset = "0x14732E8", VA = "0x14732E8")]
	private void HandleLook()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x14734AC", Offset = "0x14734AC", VA = "0x14734AC")]
	private void HandleSelection()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x1473958", Offset = "0x1473958", VA = "0x1473958")]
	public Pvr_GazeInputModule()
	{
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CD588", Offset = "0x6CD588")]
public class Pvr_GazeInputModuleCrosshair : MonoBehaviour
{
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DisplayCrosshair;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE60C", Offset = "0x6CE60C")]
	public Transform Crosshair;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Pvr_GazeInputModule gazeInputModule;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 CrosshairOriginalScale;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float CrosshairOriginalDistance;

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x14739B8", Offset = "0x14739B8", VA = "0x14739B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1473A10", Offset = "0x1473A10", VA = "0x1473A10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1473A78", Offset = "0x1473A78", VA = "0x1473A78")]
	private void Update()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1473B88", Offset = "0x1473B88", VA = "0x1473B88")]
	private void SetCrossHairAtDistance(float dist)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1473C80", Offset = "0x1473C80", VA = "0x1473C80")]
	public Pvr_GazeInputModuleCrosshair()
	{
	}
}
[Token(Token = "0x2000045")]
public enum RenderEventType
{
	[Token(Token = "0x400025B")]
	InitRenderThread = 1024,
	[Token(Token = "0x400025C")]
	Pause,
	[Token(Token = "0x400025D")]
	Resume,
	[Token(Token = "0x400025E")]
	LeftEyeEndFrame,
	[Token(Token = "0x400025F")]
	RightEyeEndFrame,
	[Token(Token = "0x4000260")]
	TimeWarp,
	[Token(Token = "0x4000261")]
	ResetVrModeParms,
	[Token(Token = "0x4000262")]
	ShutdownRenderThread,
	[Token(Token = "0x4000263")]
	BeginEye,
	[Token(Token = "0x4000264")]
	EndEye,
	[Token(Token = "0x4000265")]
	BoundaryRenderLeft,
	[Token(Token = "0x4000266")]
	BoundaryRenderRight,
	[Token(Token = "0x4000267")]
	BothEyeEndFrame,
	[Token(Token = "0x4000268")]
	CameraFrameLeft,
	[Token(Token = "0x4000269")]
	CameraFrameRight,
	[Token(Token = "0x400026A")]
	StartCameraFrame,
	[Token(Token = "0x400026B")]
	StopCameraFrame
}
[Token(Token = "0x2000046")]
public static class Pvr_UnitySDKPluginEvent
{
	[Token(Token = "0x2000179")]
	private delegate void RenderEventDelegate(int eventId);

	[Token(Token = "0x400026C")]
	private const uint IS_DATA_FLAG = 2147483648u;

	[Token(Token = "0x400026D")]
	private const uint DATA_POS_MASK = 1073741824u;

	[Token(Token = "0x400026E")]
	private const int DATA_POS_SHIFT = 30;

	[Token(Token = "0x400026F")]
	private const uint EVENT_TYPE_MASK = 1056899072u;

	[Token(Token = "0x4000270")]
	private const int EVENT_TYPE_SHIFT = 17;

	[Token(Token = "0x4000271")]
	private const uint PAYLOAD_MASK = 65535u;

	[Token(Token = "0x4000272")]
	private const int PAYLOAD_SHIFT = 16;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderEventDelegate SetSinglePassBeforeForwardOpaqueHandle;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static IntPtr SetSinglePassBeforeForwardOpaquePtr;

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x143CF9C", Offset = "0x143CF9C", VA = "0x143CF9C")]
	public static void Issue(RenderEventType eventType)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x143CFC8", Offset = "0x143CFC8", VA = "0x143CFC8")]
	private static int EncodeType(int eventType)
	{
		return default(int);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x143CFD0", Offset = "0x143CFD0", VA = "0x143CFD0")]
	private static int EncodeData(int eventId, int eventData, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x143CFF0", Offset = "0x143CFF0", VA = "0x143CFF0")]
	private static int DecodeData(int eventData)
	{
		return default(int);
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x143CF94", Offset = "0x143CF94", VA = "0x143CF94")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6D0048", Offset = "0x6D0048")]
	private static void SetSinglePassBeforeForwardOpaque(int eventId)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x143D004", Offset = "0x143D004", VA = "0x143D004")]
	public static void SetSinglePassBeforeForwardOpaque(CommandBuffer cmd)
	{
	}
}
[Token(Token = "0x2000047")]
public class Pvr_UnitySDKSightInputModule : BaseInputModule
{
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE644", Offset = "0x6CE644")]
	public GameObject cursor;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int trigger;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public float clickTime;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Vector2 hotspot;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PointerEventData pointerData;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x1442404", Offset = "0x1442404", VA = "0x1442404", Slot = "21")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x1442498", Offset = "0x1442498", VA = "0x1442498", Slot = "22")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1442784", Offset = "0x1442784", VA = "0x1442784", Slot = "20")]
	public override bool IsPointerOverGameObject(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x144280C", Offset = "0x144280C", VA = "0x144280C", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x1442848", Offset = "0x1442848", VA = "0x1442848")]
	private void CastRayFromGaze()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x144298C", Offset = "0x144298C", VA = "0x144298C")]
	private void UpdateCurrentObject()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x1442B2C", Offset = "0x1442B2C", VA = "0x1442B2C")]
	private void PlaceCursor()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x1442594", Offset = "0x1442594", VA = "0x1442594")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1442D54", Offset = "0x1442D54", VA = "0x1442D54")]
	private void HandleTrigger()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x1442FC8", Offset = "0x1442FC8", VA = "0x1442FC8")]
	public Pvr_UnitySDKSightInputModule()
	{
	}
}
[Token(Token = "0x2000048")]
public class Pvr_ObjImporter
{
	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ObjImporter _instance;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> triangles;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Vector3> vertices;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector2> uv;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<PvrVector3Int> faceData;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> intArray;

	[Token(Token = "0x4000281")]
	private const int MIN_POW_10 = -16;

	[Token(Token = "0x4000282")]
	private const int MAX_POW_10 = 16;

	[Token(Token = "0x4000283")]
	private const int NUM_POWS_10 = 33;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly float[] pow10;

	[Token(Token = "0x17000053")]
	public static Pvr_ObjImporter Instance
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1476294", Offset = "0x1476294", VA = "0x1476294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x1476340", Offset = "0x1476340", VA = "0x1476340")]
	public Mesh ImportFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x1476764", Offset = "0x1476764", VA = "0x1476764")]
	private void LoadMeshData(string fileName)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1476E38", Offset = "0x1476E38", VA = "0x1476E38")]
	private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
	{
		return default(float);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1476FB0", Offset = "0x1476FB0", VA = "0x1476FB0")]
	private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
	{
		return default(int);
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x14773B8", Offset = "0x14773B8", VA = "0x14773B8")]
	private static float[] GenerateLookupTable()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x14770F0", Offset = "0x14770F0", VA = "0x14770F0")]
	private float ParseFloat(StringBuilder value)
	{
		return default(float);
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x147732C", Offset = "0x147732C", VA = "0x147732C")]
	private int IntParseFast(StringBuilder value)
	{
		return default(int);
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1476338", Offset = "0x1476338", VA = "0x1476338")]
	public Pvr_ObjImporter()
	{
	}
}
[Token(Token = "0x2000049")]
public sealed class PvrVector3Int
{
	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE69C", Offset = "0x6CE69C")]
	private int <x>k__BackingField;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE6AC", Offset = "0x6CE6AC")]
	private int <y>k__BackingField;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE6BC", Offset = "0x6CE6BC")]
	private int <z>k__BackingField;

	[Token(Token = "0x17000054")]
	public int x
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x9DE65C", Offset = "0x9DE65C", VA = "0x9DE65C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00AC", Offset = "0x6D00AC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x9DE664", Offset = "0x9DE664", VA = "0x9DE664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00BC", Offset = "0x6D00BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public int y
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x9DE66C", Offset = "0x9DE66C", VA = "0x9DE66C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00CC", Offset = "0x6D00CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x9DE674", Offset = "0x9DE674", VA = "0x9DE674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00DC", Offset = "0x6D00DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public int z
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x9DE67C", Offset = "0x9DE67C", VA = "0x9DE67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00EC", Offset = "0x6D00EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x9DE684", Offset = "0x9DE684", VA = "0x9DE684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00FC", Offset = "0x6D00FC")]
		set
		{
		}
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x9DE68C", Offset = "0x9DE68C", VA = "0x9DE68C")]
	public PvrVector3Int()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x9DE694", Offset = "0x9DE694", VA = "0x9DE694")]
	public PvrVector3Int(int x, int y, int z)
	{
	}
}
[Token(Token = "0x200004A")]
public class Pvr_EnumFlags : PropertyAttribute
{
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1472F30", Offset = "0x1472F30", VA = "0x1472F30")]
	public Pvr_EnumFlags()
	{
	}
}
[Token(Token = "0x200004B")]
public enum ConfirmBtn
{
	[Token(Token = "0x4000289")]
	App = 1,
	[Token(Token = "0x400028A")]
	TouchPad = 2,
	[Token(Token = "0x400028B")]
	Trigger = 4
}
[Token(Token = "0x200004C")]
public class Pvr_InputModule : PointerInputModule
{
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UIPointer> pointers;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Pvr_EnumFlags]
	public ConfirmBtn confirmBtn;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RaycastResult> rayCasts;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RaycastResult rayCastResult;

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1473CDC", Offset = "0x1473CDC", VA = "0x1473CDC", Slot = "30")]
	public virtual void Initialise()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1473D58", Offset = "0x1473D58", VA = "0x1473D58")]
	public static void AddPoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1473E28", Offset = "0x1473E28", VA = "0x1473E28")]
	public static void RemovePoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x1473EF8", Offset = "0x1473EF8", VA = "0x1473EF8", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1474260", Offset = "0x1474260", VA = "0x1474260", Slot = "31")]
	protected virtual List<RaycastResult> CheckRaycasts(Pvr_UIPointer pointer)
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x1474310", Offset = "0x1474310", VA = "0x1474310", Slot = "32")]
	protected virtual bool CheckTransformTree(Transform target, Transform source)
	{
		return default(bool);
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x1474400", Offset = "0x1474400", VA = "0x1474400", Slot = "33")]
	protected virtual bool NoValidCollision(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x14744C0", Offset = "0x14744C0", VA = "0x14744C0", Slot = "34")]
	protected virtual bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x14746C8", Offset = "0x14746C8", VA = "0x14746C8", Slot = "35")]
	protected virtual bool ValidElement(GameObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x1474778", Offset = "0x1474778", VA = "0x1474778", Slot = "36")]
	protected virtual void CheckPointerHoverClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1474814", Offset = "0x1474814", VA = "0x1474814", Slot = "37")]
	protected virtual void Hover(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1475390", Offset = "0x1475390", VA = "0x1475390", Slot = "38")]
	protected virtual void Click(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x14753D8", Offset = "0x14753D8", VA = "0x14753D8", Slot = "39")]
	protected virtual void ClickOnUp(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1475478", Offset = "0x1475478", VA = "0x1475478", Slot = "40")]
	protected virtual void ClickOnDown(Pvr_UIPointer pointer, List<RaycastResult> results, bool forceClick = false)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1475534", Offset = "0x1475534", VA = "0x1475534", Slot = "41")]
	protected virtual bool IsEligibleClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1475808", Offset = "0x1475808", VA = "0x1475808", Slot = "42")]
	protected virtual bool AttemptClick(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1475AD4", Offset = "0x1475AD4", VA = "0x1475AD4", Slot = "43")]
	protected virtual void Drag(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x14761A8", Offset = "0x14761A8", VA = "0x14761A8")]
	public Pvr_InputModule()
	{
	}
}
[Token(Token = "0x200004D")]
public class Pvr_UICanvas : MonoBehaviour
{
	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD844", Offset = "0x6CD844")]
	private sealed class <CreateDraggablePanel>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 canvasSize;

		[Token(Token = "0x1700011D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x147B254", Offset = "0x147B254", VA = "0x147B254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x147B2BC", Offset = "0x147B2BC", VA = "0x147B2BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x147ABBC", Offset = "0x147ABBC", VA = "0x147ABBC")]
		[DebuggerHidden]
		public <CreateDraggablePanel>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x147AED0", Offset = "0x147AED0", VA = "0x147AED0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x147AED4", Offset = "0x147AED4", VA = "0x147AED4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x147B25C", Offset = "0x147B25C", VA = "0x147B25C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool clickOnPointerCollision;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float autoActivateWithinDistance;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected BoxCollider canvasBoxCollider;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Rigidbody canvasRigidBody;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Coroutine draggablePanelCreation;

	[Token(Token = "0x4000295")]
	protected const string CANVAS_DRAGGABLE_PANEL = "UICANVAS_DRAGGABLE_PANEL";

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x147A78C", Offset = "0x147A78C", VA = "0x147A78C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x147A798", Offset = "0x147A798", VA = "0x147A798", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x147A7A4", Offset = "0x147A7A4", VA = "0x147A7A4", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x147A7B0", Offset = "0x147A7B0", VA = "0x147A7B0", Slot = "7")]
	protected virtual void SetupCanvas()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x147AB38", Offset = "0x147AB38", VA = "0x147AB38", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D010C", Offset = "0x6D010C")]
	protected virtual IEnumerator CreateDraggablePanel(Canvas canvas, Vector2 canvasSize)
	{
		return null;
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x147ABE8", Offset = "0x147ABE8", VA = "0x147ABE8", Slot = "9")]
	protected virtual void RemoveCanvas()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x147AEC8", Offset = "0x147AEC8", VA = "0x147AEC8")]
	public Pvr_UICanvas()
	{
	}
}
[Token(Token = "0x200004E")]
public struct UIDraggableItemEventArgs
{
	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject target;
}
[Token(Token = "0x200004F")]
public delegate void UIDraggableItemEventHandler(object sender, UIDraggableItemEventArgs e);
[Token(Token = "0x2000050")]
public class Pvr_UIDraggableItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool restrictToDropZone;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool restrictToOriginalCanvas;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float moveOffset;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject validDropZone;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected RectTransform dragTransform;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 startPosition;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected Quaternion startRotation;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject startDropZone;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Transform startParent;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Canvas startCanvas;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected CanvasGroup canvasGroup;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Pvr_InputModule currentInputmodule;

	[Token(Token = "0x14000018")]
	public event UIDraggableItemEventHandler DraggableItemDropped
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x147B2C4", Offset = "0x147B2C4", VA = "0x147B2C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0170", Offset = "0x6D0170")]
		add
		{
		}
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x147B368", Offset = "0x147B368", VA = "0x147B368")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0180", Offset = "0x6D0180")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public event UIDraggableItemEventHandler DraggableItemReset
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x147B40C", Offset = "0x147B40C", VA = "0x147B40C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0190", Offset = "0x6D0190")]
		add
		{
		}
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x147B4B0", Offset = "0x147B4B0", VA = "0x147B4B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01A0", Offset = "0x6D01A0")]
		remove
		{
		}
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x147B554", Offset = "0x147B554", VA = "0x147B554", Slot = "7")]
	public virtual void OnDraggableItemDropped(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x147B574", Offset = "0x147B574", VA = "0x147B574", Slot = "8")]
	public virtual void OnDraggableItemReset(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x147B594", Offset = "0x147B594", VA = "0x147B594", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x147B7A8", Offset = "0x147B7A8", VA = "0x147B7A8", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x147B7B4", Offset = "0x147B7B4", VA = "0x147B7B4", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x147BBF4", Offset = "0x147BBF4", VA = "0x147BBF4", Slot = "9")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x147BCE8", Offset = "0x147BCE8", VA = "0x147BCE8", Slot = "10")]
	protected virtual Pvr_UIPointer GetPointer()
	{
		return null;
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x147BE6C", Offset = "0x147BE6C", VA = "0x147BE6C", Slot = "11")]
	protected virtual void SetDragPosition(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x147C130", Offset = "0x147C130", VA = "0x147C130", Slot = "12")]
	protected virtual void ResetElement()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x147C1E0", Offset = "0x147C1E0", VA = "0x147C1E0", Slot = "13")]
	protected virtual UIDraggableItemEventArgs SetEventPayload(GameObject target)
	{
		return default(UIDraggableItemEventArgs);
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x147C1E8", Offset = "0x147C1E8", VA = "0x147C1E8")]
	public Pvr_UIDraggableItem()
	{
	}
}
[Token(Token = "0x2000051")]
public class Pvr_UIDropZone : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Pvr_UIDraggableItem droppableItem;

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x147C1FC", Offset = "0x147C1FC", VA = "0x147C1FC", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x147C2EC", Offset = "0x147C2EC", VA = "0x147C2EC", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x147C374", Offset = "0x147C374", VA = "0x147C374")]
	public Pvr_UIDropZone()
	{
	}
}
[Token(Token = "0x2000052")]
public class Pvr_UIGraphicRaycaster : GraphicRaycaster
{
	[Serializable]
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD854", Offset = "0x6CD854")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<RaycastResult> <>9__7_0;

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x147D284", Offset = "0x147D284", VA = "0x147D284")]
		public <>c()
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x147D28C", Offset = "0x147D28C", VA = "0x147D28C")]
		internal int <Raycast>b__7_0(RaycastResult g1, RaycastResult g2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Canvas currentCanvas;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector2 lastKnownPosition;

	[Token(Token = "0x40002A8")]
	protected const float UI_CONTROL_OFFSET = 1E-05f;

	[NonSerialized]
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RaycastResult> s_RaycastResults;

	[Token(Token = "0x17000057")]
	protected virtual Canvas canvas
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x147D09C", Offset = "0x147D09C", VA = "0x147D09C", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x147C37C", Offset = "0x147C37C", VA = "0x147C37C", Slot = "17")]
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x147C52C", Offset = "0x147C52C", VA = "0x147C52C", Slot = "22")]
	protected virtual void SetNearestRaycast(ref PointerEventData eventData, ref List<RaycastResult> resultAppendList, ref List<RaycastResult> raycastResults)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x147C7B0", Offset = "0x147C7B0", VA = "0x147C7B0", Slot = "23")]
	protected virtual float GetHitDistance(Ray ray)
	{
		return default(float);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x147CAD0", Offset = "0x147CAD0", VA = "0x147CAD0", Slot = "24")]
	protected virtual void Raycast(Canvas canvas, Camera eventCamera, Ray ray, ref List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x147D144", Offset = "0x147D144", VA = "0x147D144")]
	public Pvr_UIGraphicRaycaster()
	{
	}
}
[Token(Token = "0x2000053")]
public struct UIPointerEventArgs
{
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isActive;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GameObject currentTarget;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject previousTarget;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RaycastResult raycastResult;
}
[Token(Token = "0x2000054")]
public delegate void UIPointerEventHandler(object sender, UIPointerEventArgs e);
[Token(Token = "0x2000055")]
public class Pvr_UIPointer : MonoBehaviour
{
	[Token(Token = "0x200017C")]
	public enum ClickMethods
	{
		[Token(Token = "0x4000B6F")]
		ClickOnButtonUp,
		[Token(Token = "0x4000B70")]
		ClickOnButtonDown
	}

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ClickMethods clickMethod;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public bool collisionClick;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool pressToDrag;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject autoActivatingCanvas;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public PointerEventData pointerEventData;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GameObject hoveringElement;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float hoverDurationTimer;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool canClickOnHover;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pointerOriginTransform;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool pointerClicked;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	protected bool beamEnabledState;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	protected bool lastPointerPressState;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	protected bool lastPointerClickState;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected GameObject currentTarget;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected EventSystem cachedEventSystem;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Pvr_InputModule cachedVRInputModule;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Transform originalPointerOriginTransform;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool TouchBtnValue;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool AppBtnValue;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool TriggerBtnValue;

	[Token(Token = "0x1400001A")]
	public event UIPointerEventHandler UIPointerElementEnter
	{
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x147D29C", Offset = "0x147D29C", VA = "0x147D29C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01B0", Offset = "0x6D01B0")]
		add
		{
		}
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x147D340", Offset = "0x147D340", VA = "0x147D340")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01C0", Offset = "0x6D01C0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event UIPointerEventHandler UIPointerElementExit
	{
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x147D3E4", Offset = "0x147D3E4", VA = "0x147D3E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01D0", Offset = "0x6D01D0")]
		add
		{
		}
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x147D488", Offset = "0x147D488", VA = "0x147D488")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01E0", Offset = "0x6D01E0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public event UIPointerEventHandler UIPointerElementClick
	{
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x147D52C", Offset = "0x147D52C", VA = "0x147D52C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01F0", Offset = "0x6D01F0")]
		add
		{
		}
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x147D5D0", Offset = "0x147D5D0", VA = "0x147D5D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0200", Offset = "0x6D0200")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event UIPointerEventHandler UIPointerElementDragStart
	{
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x147D674", Offset = "0x147D674", VA = "0x147D674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0210", Offset = "0x6D0210")]
		add
		{
		}
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x147D718", Offset = "0x147D718", VA = "0x147D718")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0220", Offset = "0x6D0220")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public event UIPointerEventHandler UIPointerElementDragEnd
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x147D7BC", Offset = "0x147D7BC", VA = "0x147D7BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0230", Offset = "0x6D0230")]
		add
		{
		}
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x147D860", Offset = "0x147D860", VA = "0x147D860")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0240", Offset = "0x6D0240")]
		remove
		{
		}
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x147D904", Offset = "0x147D904", VA = "0x147D904", Slot = "4")]
	public virtual bool PointerActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x147D90C", Offset = "0x147D90C", VA = "0x147D90C", Slot = "5")]
	public virtual bool IsSelectionButtonPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x147D9EC", Offset = "0x147D9EC", VA = "0x147D9EC", Slot = "6")]
	public virtual Vector3 GetOriginPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x147DA80", Offset = "0x147DA80", VA = "0x147DA80", Slot = "7")]
	public virtual Vector3 GetOriginForward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x147DB14", Offset = "0x147DB14", VA = "0x147DB14", Slot = "8")]
	public virtual bool ValidClick(bool checkLastClick, bool lastClickState = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x147DB30", Offset = "0x147DB30", VA = "0x147DB30", Slot = "9")]
	protected virtual void ResetHoverTimer()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x147DB3C", Offset = "0x147DB3C", VA = "0x147DB3C", Slot = "10")]
	public virtual void OnUIPointerElementEnter(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x147DC10", Offset = "0x147DC10", VA = "0x147DC10", Slot = "11")]
	public virtual void OnUIPointerElementExit(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x147DCDC", Offset = "0x147DCDC", VA = "0x147DCDC", Slot = "12")]
	public virtual void OnUIPointerElementClick(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x147DDA8", Offset = "0x147DDA8", VA = "0x147DDA8", Slot = "13")]
	public virtual void OnUIPointerElementDragStart(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x147DDF4", Offset = "0x147DDF4", VA = "0x147DDF4", Slot = "14")]
	public virtual void OnUIPointerElementDragEnd(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x147DE40", Offset = "0x147DE40", VA = "0x147DE40", Slot = "15")]
	public virtual UIPointerEventArgs SetUIPointerEvent(RaycastResult currentRaycastResult, GameObject currentTarget, [Optional] GameObject lastTarget)
	{
		return default(UIPointerEventArgs);
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x147DEA4", Offset = "0x147DEA4", VA = "0x147DEA4", Slot = "16")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x147DEB0", Offset = "0x147DEB0", VA = "0x147DEB0", Slot = "17")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x147DEE8", Offset = "0x147DEE8", VA = "0x147DEE8", Slot = "18")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x147DF4C", Offset = "0x147DF4C", VA = "0x147DF4C", Slot = "19")]
	protected virtual void ConfigureEventSystem()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x147E0EC", Offset = "0x147E0EC", VA = "0x147E0EC")]
	public Pvr_UIPointer()
	{
	}
}
[Token(Token = "0x2000056")]
[ExecuteInEditMode]
public class Pvr_UnitySDKEditor : MonoBehaviour
{
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool vrModeEnabled;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mouseX;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float mouseY;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float mouseZ;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float neckModelScale;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool autoUntiltHead;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 neckOffset;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Matrix4x4 headView;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Matrix4x4 leftEyeUndistortedProj;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Matrix4x4 rightEyeUndistortedProj;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	public Matrix4x4 leftEyeProj;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public Matrix4x4 rightEyeProj;

	[Token(Token = "0x40002D3")]
	private const float TOUCH_TIME_LIMIT = 0.2f;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private float touchStartTime;

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1493158", Offset = "0x1493158", VA = "0x1493158")]
	public Matrix4x4 UndistortedProjection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x149317C", Offset = "0x149317C", VA = "0x149317C")]
	public Matrix4x4 Projection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x14931A0", Offset = "0x14931A0", VA = "0x14931A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1493388", Offset = "0x1493388", VA = "0x1493388")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x14931B4", Offset = "0x14931B4", VA = "0x14931B4")]
	public void InitEyePara()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1493300", Offset = "0x1493300", VA = "0x1493300")]
	private void InitEditorSensorPara()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1493BD8", Offset = "0x1493BD8", VA = "0x1493BD8")]
	public static Matrix4x4 MakeProjection(float l, float t, float r, float b, float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x1493D7C", Offset = "0x1493D7C", VA = "0x1493D7C")]
	public bool UpdateStatesensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1493520", Offset = "0x1493520", VA = "0x1493520")]
	public void ComputeEyesFromProfile()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1494200", Offset = "0x1494200", VA = "0x1494200")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x149341C", Offset = "0x149341C", VA = "0x149341C")]
	private void SimulateInput()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1493B24", Offset = "0x1493B24", VA = "0x1493B24")]
	private void FovAdjust()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x14942B0", Offset = "0x14942B0", VA = "0x14942B0")]
	private Rect RectAdjust(Rect eyeRect)
	{
		return default(Rect);
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1493D94", Offset = "0x1493D94", VA = "0x1493D94")]
	private void UpdateSimulatedSensor()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x14939B4", Offset = "0x14939B4", VA = "0x14939B4")]
	private void InitForEye(ref Material mat, ref Material mat1)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1494214", Offset = "0x1494214", VA = "0x1494214")]
	private void EnableVEmodel()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1494400", Offset = "0x1494400", VA = "0x1494400")]
	public Pvr_UnitySDKEditor()
	{
	}
}
[Token(Token = "0x2000057")]
public class Pvr_VolumePowerBrightness : MonoBehaviour
{
	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool VolEnable;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool BattEnable;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text showResult;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text setVolumnum;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text setBrightnum;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string MusicPath;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1445114", Offset = "0x1445114", VA = "0x1445114")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x14451E4", Offset = "0x14451E4", VA = "0x14451E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1445238", Offset = "0x1445238", VA = "0x1445238")]
	public void GetMaxVolumeNumber()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x14452D8", Offset = "0x14452D8", VA = "0x14452D8")]
	public void GetCurrentVolumeNumber()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1445378", Offset = "0x1445378", VA = "0x1445378")]
	public void VolumeUp()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x14453FC", Offset = "0x14453FC", VA = "0x14453FC")]
	public void VolumeDown()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1445480", Offset = "0x1445480", VA = "0x1445480")]
	public void SetVolumeNum()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1445598", Offset = "0x1445598", VA = "0x1445598")]
	public void SetBrightness()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x14456B0", Offset = "0x14456B0", VA = "0x14456B0")]
	public void GetCurrentBrightness()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1445750", Offset = "0x1445750", VA = "0x1445750")]
	public bool setAudio(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x14457E0", Offset = "0x14457E0", VA = "0x14457E0")]
	public bool setBattery(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x144517C", Offset = "0x144517C", VA = "0x144517C")]
	private bool InitBatteryVolClass()
	{
		return default(bool);
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1445184", Offset = "0x1445184", VA = "0x1445184")]
	private bool StartBatteryReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1445230", Offset = "0x1445230", VA = "0x1445230")]
	private bool StopBatteryReceiver()
	{
		return default(bool);
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x14451B4", Offset = "0x14451B4", VA = "0x14451B4")]
	private bool StartAudioReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x1445228", Offset = "0x1445228", VA = "0x1445228")]
	private bool StopAudioReceiver()
	{
		return default(bool);
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1445870", Offset = "0x1445870", VA = "0x1445870")]
	public Pvr_VolumePowerBrightness()
	{
	}
}
[Token(Token = "0x2000058")]
public class DepthNormalsFeature : ScriptableRendererFeature
{
	[Token(Token = "0x200017D")]
	private class DepthNormalsPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int kDepthBufferBits;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF624", Offset = "0x6CF624")]
		private RenderTargetHandle <depthAttachmentHandle>k__BackingField;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF634", Offset = "0x6CF634")]
		private RenderTextureDescriptor <descriptor>k__BackingField;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material depthNormalsMaterial;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string m_ProfilerTag;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ShaderTagId m_ShaderTagId;

		[Token(Token = "0x1700011F")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x99E320", Offset = "0x99E320", VA = "0x99E320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D19F0", Offset = "0x6D19F0")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x99E328", Offset = "0x99E328", VA = "0x99E328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A00", Offset = "0x6D1A00")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		internal RenderTextureDescriptor descriptor
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x99E330", Offset = "0x99E330", VA = "0x99E330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A10", Offset = "0x6D1A10")]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x99E350", Offset = "0x99E350", VA = "0x99E350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A20", Offset = "0x6D1A20")]
			private set
			{
			}
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x99E0DC", Offset = "0x99E0DC", VA = "0x99E0DC")]
		public DepthNormalsPass(RenderQueueRange renderQueueRange, LayerMask layerMask, Material material)
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x99E2B8", Offset = "0x99E2B8", VA = "0x99E2B8")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle)
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x99E370", Offset = "0x99E370", VA = "0x99E370", Slot = "4")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x99E444", Offset = "0x99E444", VA = "0x99E444", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x99E678", Offset = "0x99E678", VA = "0x99E678", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DepthNormalsPass depthNormalsPass;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTargetHandle depthNormalsTexture;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material depthNormalsMaterial;

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x99DFC4", Offset = "0x99DFC4", VA = "0x99DFC4", Slot = "4")]
	public override void Create()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x99E1F0", Offset = "0x99E1F0", VA = "0x99E1F0", Slot = "5")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x99E318", Offset = "0x99E318", VA = "0x99E318")]
	public DepthNormalsFeature()
	{
	}
}
[Token(Token = "0x2000059")]
public class OutlineFeature : ScriptableRendererFeature
{
	[Token(Token = "0x200017E")]
	private class OutlinePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF644", Offset = "0x6CF644")]
		private RenderTargetIdentifier <source>k__BackingField;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF654", Offset = "0x6CF654")]
		private RenderTargetHandle <destination>k__BackingField;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Material outlineMaterial;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTargetHandle temporaryColorTexture;

		[Token(Token = "0x17000121")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x9DC874", Offset = "0x9DC874", VA = "0x9DC874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A30", Offset = "0x6D1A30")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x9DC88C", Offset = "0x9DC88C", VA = "0x9DC88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A40", Offset = "0x6D1A40")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x9DC8A4", Offset = "0x9DC8A4", VA = "0x9DC8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A50", Offset = "0x6D1A50")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x9DC8AC", Offset = "0x9DC8AC", VA = "0x9DC8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A60", Offset = "0x6D1A60")]
			set
			{
			}
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x9DC7E8", Offset = "0x9DC7E8", VA = "0x9DC7E8")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x9DC5DC", Offset = "0x9DC5DC", VA = "0x9DC5DC")]
		public OutlinePass(Material outlineMaterial)
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x9DC8B4", Offset = "0x9DC8B4", VA = "0x9DC8B4", Slot = "4")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x9DC8B8", Offset = "0x9DC8B8", VA = "0x9DC8B8", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x9DCB78", Offset = "0x9DCB78", VA = "0x9DCB78", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017F")]
	public class OutlineSettings
	{
		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material outlineMaterial;

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x9DC86C", Offset = "0x9DC86C", VA = "0x9DC86C")]
		public OutlineSettings()
		{
		}
	}

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OutlineSettings settings;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OutlinePass outlinePass;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTargetHandle outlineTexture;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x9DC540", Offset = "0x9DC540", VA = "0x9DC540", Slot = "4")]
	public override void Create()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x9DC608", Offset = "0x9DC608", VA = "0x9DC608", Slot = "5")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x9DC804", Offset = "0x9DC804", VA = "0x9DC804")]
	public OutlineFeature()
	{
	}
}
[Token(Token = "0x200005A")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000180")]
	public class Section
	{
		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x1445AF0", Offset = "0x1445AF0", VA = "0x1445AF0")]
		public Section()
		{
		}
	}

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1445AE8", Offset = "0x1445AE8", VA = "0x1445AE8")]
	public Readme()
	{
	}
}
[Token(Token = "0x200005B")]
public class mParent : MonoBehaviour
{
	[Token(Token = "0x2000181")]
	private enum Mode
	{
		[Token(Token = "0x4000B82")]
		Idle,
		[Token(Token = "0x4000B83")]
		Ground,
		[Token(Token = "0x4000B84")]
		Hand,
		[Token(Token = "0x4000B85")]
		Back
	}

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mParentCon;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mode m_Mode;

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x9108FC", Offset = "0x9108FC", VA = "0x9108FC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x910A2C", Offset = "0x910A2C", VA = "0x910A2C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x910AA4", Offset = "0x910AA4", VA = "0x910AA4")]
	public void hand()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x910B1C", Offset = "0x910B1C", VA = "0x910B1C")]
	public void back()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x910B94", Offset = "0x910B94", VA = "0x910B94")]
	public mParent()
	{
	}
}
[Token(Token = "0x200005C")]
public class OculusIntegration : UnityEngine.Object
{
	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string userName;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool userGotName;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool oculusConFailed;

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x9D9BD0", Offset = "0x9D9BD0", VA = "0x9D9BD0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x9D9E34", Offset = "0x9D9E34", VA = "0x9D9E34")]
	private void OnInitializationCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9D9F48", Offset = "0x9D9F48", VA = "0x9D9F48")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x9DA06C", Offset = "0x9DA06C", VA = "0x9DA06C")]
	private void GetLoggedInOculusUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x9DA164", Offset = "0x9DA164", VA = "0x9DA164")]
	public OculusIntegration()
	{
	}
}
[Token(Token = "0x200005D")]
public class PicoIntegration : MonoBehaviour
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string userName;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool userGotName;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool picoConFailed;

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x9DD77C", Offset = "0x9DD77C", VA = "0x9DD77C")]
	public void init()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x9DDA44", Offset = "0x9DDA44", VA = "0x9DDA44")]
	public void LoginCallback(string result)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x9DDE18", Offset = "0x9DDE18", VA = "0x9DDE18")]
	public void UserInfoCallback(string result)
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x9DE020", Offset = "0x9DE020", VA = "0x9DE020")]
	public PicoIntegration()
	{
	}
}
[Token(Token = "0x200005E")]
public class UIstateTemplate
{
	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject courseSelectMenu;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject settingsMenu;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject heightMenu;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beginMenu;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject endMenu;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject pauseMenu;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject itemMenu;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject musicMenu;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject gameOverMenu;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject yesNoPromptSettings;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject yesNoPromptGear;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject yesNoPromptMap;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject difficulty;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject welcomeInfo;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject scoreBreakdown;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject scoreBreakdownEnd;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RawImage easySelected;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RawImage normalSelected;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public RawImage hardSelected;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RawImage freeSelected;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RectTransform loadingFade;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RawImage loadingFadeImage;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public CanvasGroup whiteFade;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool fadeIn;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool fadeOut;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
	public bool useBlackFade;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
	public bool fadeReadyForLoad;

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x8B3DE8", Offset = "0x8B3DE8", VA = "0x8B3DE8")]
	public void HideAll()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x8B4248", Offset = "0x8B4248", VA = "0x8B4248")]
	public UIstateTemplate()
	{
	}
}
[Token(Token = "0x200005F")]
public class ObjectStateTemplate
{
	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject stickRight;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject stickLeft;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject stickPointer;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject skiRight;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject skiLeft;

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x9D9888", Offset = "0x9D9888", VA = "0x9D9888")]
	public void HideAll()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x9D9A28", Offset = "0x9D9A28", VA = "0x9D9A28")]
	public void ShowDefault()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x9D9BC8", Offset = "0x9D9BC8", VA = "0x9D9BC8")]
	public ObjectStateTemplate()
	{
	}
}
[Token(Token = "0x2000060")]
public class UIManager : MonoBehaviour
{
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD864", Offset = "0x6CD864")]
	private sealed class <SpawnBeginMenu>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x17000123")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x8B1D28", Offset = "0x8B1D28", VA = "0x8B1D28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x8B1D90", Offset = "0x8B1D90", VA = "0x8B1D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x8B19AC", Offset = "0x8B19AC", VA = "0x8B19AC")]
		[DebuggerHidden]
		public <SpawnBeginMenu>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x8B19D8", Offset = "0x8B19D8", VA = "0x8B19D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x8B19DC", Offset = "0x8B19DC", VA = "0x8B19DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x8B1D30", Offset = "0x8B1D30", VA = "0x8B1D30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD874", Offset = "0x6CD874")]
	private sealed class <SpawnEndMenu>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ObjectStateTemplate ObjectState;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x17000125")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x8B25F8", Offset = "0x8B25F8", VA = "0x8B25F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x8B2660", Offset = "0x8B2660", VA = "0x8B2660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x8B1D98", Offset = "0x8B1D98", VA = "0x8B1D98")]
		[DebuggerHidden]
		public <SpawnEndMenu>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x8B1DC4", Offset = "0x8B1DC4", VA = "0x8B1DC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x8B1DC8", Offset = "0x8B1DC8", VA = "0x8B1DC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x8B2600", Offset = "0x8B2600", VA = "0x8B2600", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD884", Offset = "0x6CD884")]
	private sealed class <SpawnItemMenu>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectStateTemplate ObjectState;

		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x17000127")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x8B293C", Offset = "0x8B293C", VA = "0x8B293C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x8B29A4", Offset = "0x8B29A4", VA = "0x8B29A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x8B2668", Offset = "0x8B2668", VA = "0x8B2668")]
		[DebuggerHidden]
		public <SpawnItemMenu>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x8B2694", Offset = "0x8B2694", VA = "0x8B2694", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x8B2698", Offset = "0x8B2698", VA = "0x8B2698", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x8B2944", Offset = "0x8B2944", VA = "0x8B2944", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD894", Offset = "0x6CD894")]
	private struct <populateScoreBoard>d__56 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private scoreList <scoreData>5__2;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<scoreList> <>u__1;

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x8B29AC", Offset = "0x8B29AC", VA = "0x8B29AC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x8B37A8", Offset = "0x8B37A8", VA = "0x8B37A8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIstateTemplate UIstate;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectStateTemplate ObjectState;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public walletObject wallet;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int pointerButton;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject selectedItem;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool click;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource clickSoundEffect;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource tagSoundEffect;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyPosition body;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private calcBodyMovement move;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private dataManager data;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private connectionManager connection;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private particleEffects effect;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private stateManager state;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private courseRhythm cr;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int layerMaskMainUI;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool triggerHeld;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string menuSelectedScene;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<GameObject> nestedMenus;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<GameObject> activeBackdrops;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject pointerLoc;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject clickLoc;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ParticleSystem clickLocEmit;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 pointerOrigin;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 pointerDir;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool itemAccepted;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float loadingFadeTimer;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float clearHighLightTimer;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float highLightTimer;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool courseInit;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject currentLockIcon;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject currentUnLockIcon;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Transform sfxBar;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Transform musicBar;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private AudioMixer audioMixer;

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x144FE50", Offset = "0x144FE50", VA = "0x144FE50")]
	public void TogglePuaseMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x145038C", Offset = "0x145038C", VA = "0x145038C")]
	public void ResumePuaseMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x14503E4", Offset = "0x14503E4", VA = "0x14503E4")]
	public void toggleHeightAdjustment(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1450534", Offset = "0x1450534", VA = "0x1450534")]
	public void toggleSetting(UIstateTemplate UIstate, string settingName, bool flip = true)
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1450800", Offset = "0x1450800", VA = "0x1450800")]
	private int checkGear(UIstateTemplate UIstate, string gearName)
	{
		return default(int);
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1450998", Offset = "0x1450998", VA = "0x1450998")]
	private void updateGear(UIstateTemplate UIstate, string gearName)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x1450B40", Offset = "0x1450B40", VA = "0x1450B40")]
	public void toggleGear(UIstateTemplate UIstate, string gearName, bool flip = true)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x14510F4", Offset = "0x14510F4", VA = "0x14510F4")]
	public void toggleMusicMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x1451430", Offset = "0x1451430", VA = "0x1451430")]
	public void toggleSong(UIstateTemplate UIstate, string settingName)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x1451690", Offset = "0x1451690", VA = "0x1451690")]
	public void selectDifficulty(UIstateTemplate UIstate, string settingName)
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x145198C", Offset = "0x145198C", VA = "0x145198C")]
	public void setVolumeBars()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x1451C04", Offset = "0x1451C04", VA = "0x1451C04")]
	public void setVolume()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x1451D08", Offset = "0x1451D08", VA = "0x1451D08")]
	public void toggleDifficultyMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x1451FAC", Offset = "0x1451FAC", VA = "0x1451FAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0250", Offset = "0x6D0250")]
	public IEnumerator SpawnBeginMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x1452028", Offset = "0x1452028", VA = "0x1452028")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D02B4", Offset = "0x6D02B4")]
	public IEnumerator SpawnEndMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x14520AC", Offset = "0x14520AC", VA = "0x14520AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0318", Offset = "0x6D0318")]
	public IEnumerator SpawnItemMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x1452130", Offset = "0x1452130", VA = "0x1452130")]
	public void AcceptBeginMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x14521F0", Offset = "0x14521F0", VA = "0x14521F0")]
	public void AcceptGameOverMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x1452244", Offset = "0x1452244", VA = "0x1452244")]
	public void LerpFade(UIstateTemplate UIstate, int fadeTarget, float fadeDelay)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x14528F0", Offset = "0x14528F0", VA = "0x14528F0")]
	public void displayDifficultySelection(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x1452B50", Offset = "0x1452B50", VA = "0x1452B50")]
	public void initSettingsMenu()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x1452D08", Offset = "0x1452D08", VA = "0x1452D08")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D037C", Offset = "0x6D037C")]
	public void populateScoreBoard(UIstateTemplate UIstate, string sceneName)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x1452DD8", Offset = "0x1452DD8", VA = "0x1452DD8")]
	public void HideBackdrop(GameObject selectObj)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x1452F28", Offset = "0x1452F28", VA = "0x1452F28")]
	public void ShowBackdrop(GameObject selectObj)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x145309C", Offset = "0x145309C", VA = "0x145309C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x1453614", Offset = "0x1453614", VA = "0x1453614")]
	private void Start()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x145398C", Offset = "0x145398C", VA = "0x145398C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x1450070", Offset = "0x1450070", VA = "0x1450070")]
	private Transform FindDeepChild(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x145694C", Offset = "0x145694C", VA = "0x145694C")]
	private static void OpenOculusStorePDPAndroid(string targetAppID)
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1456DA8", Offset = "0x1456DA8", VA = "0x1456DA8")]
	public UIManager()
	{
	}
}
[Token(Token = "0x2000061")]
public class analyzeMusic : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8A4", Offset = "0x6CD8A4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<float> source;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int width;

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x8B61D8", Offset = "0x8B61D8", VA = "0x8B61D8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x8B61E8", Offset = "0x8B61E8", VA = "0x8B61E8")]
		internal float <RollingAverage>b__0(int i)
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x8B59F0", Offset = "0x8B59F0", VA = "0x8B59F0")]
	public List<float> generateBeatMap(AudioClip clip, int sampleOffset = 1024)
	{
		return null;
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x8B5FC4", Offset = "0x8B5FC4", VA = "0x8B5FC4")]
	private static IList<int> FindPeaks(IList<float> values, int rangeOfPeaks)
	{
		return null;
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x8B5ECC", Offset = "0x8B5ECC", VA = "0x8B5ECC")]
	private List<float> RollingAverage(List<float> source, int width)
	{
		return null;
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x8B61E0", Offset = "0x8B61E0", VA = "0x8B61E0")]
	public analyzeMusic()
	{
	}
}
[Token(Token = "0x2000062")]
public class attentionTrigger : MonoBehaviour
{
	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject attentionTarget;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float attentionTimer;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effects;

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x8B6264", Offset = "0x8B6264", VA = "0x8B6264")]
	private void Start()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x8B62D4", Offset = "0x8B62D4", VA = "0x8B62D4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x8B6338", Offset = "0x8B6338", VA = "0x8B6338")]
	public attentionTrigger()
	{
	}
}
[Token(Token = "0x2000063")]
public class avalancheManager : MonoBehaviour
{
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject followTarget;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float avalancheSpeed;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private particleEffects effects;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject scriptHolder;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CharacterController charControl;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem avalanche1;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem avalanche2;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool init;

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x8B6348", Offset = "0x8B6348", VA = "0x8B6348")]
	private void Start()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x8B6480", Offset = "0x8B6480", VA = "0x8B6480")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x8B68F0", Offset = "0x8B68F0", VA = "0x8B68F0")]
	public avalancheManager()
	{
	}
}
[Token(Token = "0x2000064")]
public class avalancheTrigger : MonoBehaviour
{
	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject avalanche;

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x8B68F8", Offset = "0x8B68F8", VA = "0x8B68F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x8B6990", Offset = "0x8B6990", VA = "0x8B6990")]
	public avalancheTrigger()
	{
	}
}
[Token(Token = "0x2000065")]
public class beginMenu : MonoBehaviour
{
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D t1;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D t2;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D c2;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D c3;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D c4;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D c6;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D c7;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D c8;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D c9;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D c10;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D c11;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D c12;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D c13;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture2D c14;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture2D c15;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D c16;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Texture2D c17;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Texture2D c18;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Sprite race;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Sprite endless;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite practice;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Sprite obstacle;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Sprite jump;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public RawImage header;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage musicFreeRide;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Image gamemode;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject freeRide;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject easy;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject normal;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject hard;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public localizedText gameInfoTxt;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private stateManager state;

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x8B6A08", Offset = "0x8B6A08", VA = "0x8B6A08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x8B7100", Offset = "0x8B7100", VA = "0x8B7100")]
	public beginMenu()
	{
	}
}
[Token(Token = "0x2000066")]
public class birdsEscaping : MonoBehaviour
{
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem birds;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float timer;

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x8B7108", Offset = "0x8B7108", VA = "0x8B7108")]
	private void Start()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x8B7170", Offset = "0x8B7170", VA = "0x8B7170")]
	private void Update()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x8B71F0", Offset = "0x8B71F0", VA = "0x8B71F0")]
	public birdsEscaping()
	{
	}
}
[Token(Token = "0x2000067")]
public class bodyColliderManager : MonoBehaviour
{
	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject bodyObj;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject rightHandObj;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject leftHandObj;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private BoxCollider bodyCol;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private BoxCollider rightHandCol;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private BoxCollider leftHandCol;

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x8B71F8", Offset = "0x8B71F8", VA = "0x8B71F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x8B74F4", Offset = "0x8B74F4", VA = "0x8B74F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x8B7714", Offset = "0x8B7714", VA = "0x8B7714")]
	public bodyColliderManager()
	{
	}
}
[Token(Token = "0x2000068")]
public class calcBodyMovement : MonoBehaviour
{
	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE81C", Offset = "0x6CE81C")]
	private static calcBodyMovement <Instance>k__BackingField;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 velocityVector;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 direction;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speedGradient;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float turnAngle;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float jumpEnabler;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float jumpEnablerCap;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float flowMultiplier;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isGrounded;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float jumpTimer;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool punting;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float heightGained;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int artificalJumpFac;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int maxFallAngle;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool skiJumpMode;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float skiJumpLength;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool lowDeAcceleration;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector2 airControlFac;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float impuleTimer;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float impuleForce;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float tuneTurnSpeed;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float deltaSpeed;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float airAlignment;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool stickInContact;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool onSlipperySurface;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Vector3 slipperyNormal;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float slipperyTimer;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool inStopTurn;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject player;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private calcBodyPosition body;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public CharacterController CharControl;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private puntLocomotion punt;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private slopeLocomotion slope;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private stateManager state;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private particleEffects effect;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private damageManager damage;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float speedCap;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float frameSpeedCap;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float heightBoost;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector3 jumpVector;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 velocityAirVector;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector2 accelerationFactors;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float turnAngleFactor;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float prevSpeed;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float heightSpeedBoost;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<float> slopeGradientBoostLst;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float slopeGradientBoost;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private int halfPipeFac;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<Vector3> charPosLst;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool initOnGround;

	[Token(Token = "0x17000058")]
	public static calcBodyMovement Instance
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x8B771C", Offset = "0x8B771C", VA = "0x8B771C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03E0", Offset = "0x6D03E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x8B776C", Offset = "0x8B776C", VA = "0x8B776C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03F0", Offset = "0x6D03F0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x8B77C0", Offset = "0x8B77C0", VA = "0x8B77C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x8B789C", Offset = "0x8B789C", VA = "0x8B789C")]
	private void Start()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x8B7C44", Offset = "0x8B7C44", VA = "0x8B7C44")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x8B9744", Offset = "0x8B9744", VA = "0x8B9744")]
	public calcBodyMovement()
	{
	}
}
[Token(Token = "0x2000069")]
public class calcBodyPosition : MonoBehaviour
{
	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE82C", Offset = "0x6CE82C")]
	private static calcBodyPosition <Instance>k__BackingField;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 forwardDirection;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 heading;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 noHandsHeading;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 rightControllerPosition;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 leftControllerPosition;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 rightControllerDirection;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 leftControllerDirection;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 eyeDirection;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform rightHandAnchor;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform leftHandAnchor;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject cameraAnchor;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Vector3 bodyPosition;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float bodyHeight;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float deltaBodyHeight;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<float> bodyHeightLst;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Quaternion rotationOffset;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Vector3 localBackPos;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public bool allowSkiControl;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
	public bool turnRebound;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
	public bool handsInView;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float handsApartRatio;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float handsApartRatioThreshold;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float handsApartRatioBoost;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform startPos;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private stateManager state;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private dataManager data;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private slopeLocomotion slope;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform myPlayer;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject myFeet;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject myBack;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject myBackAnchor;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject localCalcObj;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 handsHeading;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 bodyHeading;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float leanAngle;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float offAlignemtTimer;

	[Token(Token = "0x17000059")]
	public static calcBodyPosition Instance
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x8B9944", Offset = "0x8B9944", VA = "0x8B9944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0400", Offset = "0x6D0400")]
		get
		{
			return null;
		}
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x8B9994", Offset = "0x8B9994", VA = "0x8B9994")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0410", Offset = "0x6D0410")]
		private set
		{
		}
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x8B99E8", Offset = "0x8B99E8", VA = "0x8B99E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x8B9AC4", Offset = "0x8B9AC4", VA = "0x8B9AC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x8BA0B8", Offset = "0x8BA0B8", VA = "0x8BA0B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x8BA0BC", Offset = "0x8BA0BC", VA = "0x8BA0BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x8B9FE4", Offset = "0x8B9FE4", VA = "0x8B9FE4")]
	public void resetBackPos()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x8B9D58", Offset = "0x8B9D58", VA = "0x8B9D58")]
	public void tuneBodyHeight()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x8BAF98", Offset = "0x8BAF98", VA = "0x8BAF98")]
	public calcBodyPosition()
	{
	}
}
[Token(Token = "0x200006A")]
public class cameraFollow : MonoBehaviour
{
	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float keepAtDist;

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x8BB054", Offset = "0x8BB054", VA = "0x8BB054")]
	private void Start()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x8BB058", Offset = "0x8BB058", VA = "0x8BB058")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x8BB2D4", Offset = "0x8BB2D4", VA = "0x8BB2D4")]
	public cameraFollow()
	{
	}
}
[Token(Token = "0x200006B")]
public class cloudManager : MonoBehaviour
{
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x8BB2E4", Offset = "0x8BB2E4", VA = "0x8BB2E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x8BB384", Offset = "0x8BB384", VA = "0x8BB384")]
	public cloudManager()
	{
	}
}
[Token(Token = "0x200006C")]
public class AuthObject
{
	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string idToken;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string email;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string refreshToken;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string expiresIn;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string localId;

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x998B54", Offset = "0x998B54", VA = "0x998B54")]
	public AuthObject()
	{
	}
}
[Token(Token = "0x200006D")]
public class nameObject
{
	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string datetime;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int userType;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool upgraded;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playerID;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x91276C", Offset = "0x91276C", VA = "0x91276C")]
	public nameObject()
	{
	}
}
[Token(Token = "0x200006E")]
public class tuneParamObject
{
	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int tuneGateFreq;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int tuneGateSize;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tuneGateOffset;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float tuneTurnSpeed;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tuneSpeedFac;

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1466904", Offset = "0x1466904", VA = "0x1466904")]
	public tuneParamObject()
	{
	}
}
[Token(Token = "0x200006F")]
public class connectionManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8B4", Offset = "0x6CD8B4")]
	private struct <anonAuthRequest>d__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x8BC510", Offset = "0x8BC510", VA = "0x8BC510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x8BC988", Offset = "0x8BC988", VA = "0x8BC988", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8C4", Offset = "0x6CD8C4")]
	private struct <putScore>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string runId;

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string dateTime;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string courseName;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int scoreValue;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int difficulty;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string authKey;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x8C0FBC", Offset = "0x8C0FBC", VA = "0x8C0FBC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x8C135C", Offset = "0x8C135C", VA = "0x8C135C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8D4", Offset = "0x6CD8D4")]
	private struct <putScoreWrap>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string courseName;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string playerName;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int scoreValue;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string runId;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int difficulty;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string dateTime;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <timeout>5__2;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Task<string> <scoreTask>5__4;

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x8C13BC", Offset = "0x8C13BC", VA = "0x8C13BC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x8C1944", Offset = "0x8C1944", VA = "0x8C1944", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8E4", Offset = "0x6CD8E4")]
	private struct <loadScore>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreList> <>t__builder;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string authKey;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool minigame;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x8BDC00", Offset = "0x8BDC00", VA = "0x8BDC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x8BE1B4", Offset = "0x8BE1B4", VA = "0x8BE1B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD8F4", Offset = "0x6CD8F4")]
	private struct <loadScoreWrap>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreList> <>t__builder;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool minigame;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <timeout>5__2;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private scoreList <scoreData>5__3;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Task<scoreList> <scoreTask>5__5;

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x8BEC24", Offset = "0x8BEC24", VA = "0x8BEC24", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x8BF178", Offset = "0x8BF178", VA = "0x8BF178", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD904", Offset = "0x6CD904")]
	private struct <loadScoreStats>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreStatsObj> <>t__builder;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string authKey;

		[Token(Token = "0x4000BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x8BE214", Offset = "0x8BE214", VA = "0x8BE214", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x8BE614", Offset = "0x8BE614", VA = "0x8BE614", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD914", Offset = "0x6CD914")]
	private struct <loadScoreStatsWrap>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreStatsObj> <>t__builder;

		[Token(Token = "0x4000BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <timeout>5__2;

		[Token(Token = "0x4000BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private scoreStatsObj <scoreStatsData>5__3;

		[Token(Token = "0x4000BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<scoreStatsObj> <scoreStatsTask>5__5;

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x8BE674", Offset = "0x8BE674", VA = "0x8BE674", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x8BEBC4", Offset = "0x8BEBC4", VA = "0x8BEBC4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD924", Offset = "0x6CD924")]
	private struct <putGhost>d__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public sharedRunObject runData;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string authKey;

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x8BF870", Offset = "0x8BF870", VA = "0x8BF870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x8BFD04", Offset = "0x8BFD04", VA = "0x8BFD04", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD934", Offset = "0x6CD934")]
	private struct <putGhostWrap>d__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string courseName;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int difficulty;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public sharedRunObject runData;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <timeout>5__2;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Task<string> <ghostTask>5__4;

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x8BFD64", Offset = "0x8BFD64", VA = "0x8BFD64", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x8C02E4", Offset = "0x8C02E4", VA = "0x8C02E4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD944", Offset = "0x6CD944")]
	private struct <loadGhost>d__18 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<sharedRunList> <>t__builder;

		[Token(Token = "0x4000BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string songTitle;

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string authKey;

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int num;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x8BC9E8", Offset = "0x8BC9E8", VA = "0x8BC9E8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x8BD1C0", Offset = "0x8BD1C0", VA = "0x8BD1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD954", Offset = "0x6CD954")]
	private struct <loadGhostWrap>d__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<sharedRunList> <>t__builder;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string songTitle;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int num;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int <timeout>5__2;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private sharedRunList <ghostData>5__3;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Task<sharedRunList> <ghostTask>5__5;

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x8BD220", Offset = "0x8BD220", VA = "0x8BD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x8BD774", Offset = "0x8BD774", VA = "0x8BD774", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD964", Offset = "0x6CD964")]
	private struct <loadName>d__20 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<nameObject> <>t__builder;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playerName;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string authKey;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x8BD7D4", Offset = "0x8BD7D4", VA = "0x8BD7D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x8BDBA0", Offset = "0x8BDBA0", VA = "0x8BDBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD974", Offset = "0x6CD974")]
	private struct <putName>d__21 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string authKey;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private nameObject <data>5__2;

		[Token(Token = "0x4000C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<nameObject> <>u__1;

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<HttpResponseMessage> <>u__2;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<string> <>u__3;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x8C02F0", Offset = "0x8C02F0", VA = "0x8C02F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x8C08D4", Offset = "0x8C08D4", VA = "0x8C08D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD984", Offset = "0x6CD984")]
	private struct <putNameWrap>d__22 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string userName;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <timeout>5__2;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task<string> <nameTask>5__4;

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x8C0934", Offset = "0x8C0934", VA = "0x8C0934", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x8C0F5C", Offset = "0x8C0F5C", VA = "0x8C0F5C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD994", Offset = "0x6CD994")]
	private struct <loadTuneParams>d__23 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<tuneParamObject> <>t__builder;

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x8BF1D8", Offset = "0x8BF1D8", VA = "0x8BF1D8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x8BF4AC", Offset = "0x8BF4AC", VA = "0x8BF4AC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9A4", Offset = "0x6CD9A4")]
	private struct <loadTuneParamsWrap>d__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<tuneParamObject> <>t__builder;

		[Token(Token = "0x4000C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private tuneParamObject <tuneParams>5__2;

		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Task<tuneParamObject> <paramTask>5__3;

		[Token(Token = "0x4000C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x8BF50C", Offset = "0x8BF50C", VA = "0x8BF50C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x8BF810", Offset = "0x8BF810", VA = "0x8BF810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly HttpClient client;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string authURL;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string dbScoreURL;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string dbScoreStatsURL;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string dbGhostURL;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string dbNameURL;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string apiKey;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly string tuningParamsURL;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string authKey;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x8BB38C", Offset = "0x8BB38C", VA = "0x8BB38C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0420", Offset = "0x6D0420")]
	private Task<string> anonAuthRequest()
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x8BB4AC", Offset = "0x8BB4AC", VA = "0x8BB4AC")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0484", Offset = "0x6D0484")]
	private Task<string> putScore(string authKey, string courseName, string playerName, int scoreValue, string runId, int difficulty, string dateTime)
	{
		return null;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x8BB5F8", Offset = "0x8BB5F8", VA = "0x8BB5F8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D04E8", Offset = "0x6D04E8")]
	public void putScoreWrap(string courseName, string playerName, int scoreValue, string runId, int difficulty, string dateTime)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x8BB6F8", Offset = "0x8BB6F8", VA = "0x8BB6F8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D054C", Offset = "0x6D054C")]
	private Task<scoreList> loadScore(string authKey, string courseName, int difficulty, bool minigame = false)
	{
		return null;
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x8B367C", Offset = "0x8B367C", VA = "0x8B367C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D05B0", Offset = "0x6D05B0")]
	public Task<scoreList> loadScoreWrap(string courseName, int difficulty, bool minigame = false)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x8BB828", Offset = "0x8BB828", VA = "0x8BB828")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0614", Offset = "0x6D0614")]
	private Task<scoreStatsObj> loadScoreStats(string authKey, string courseName, int difficulty)
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x8BB944", Offset = "0x8BB944", VA = "0x8BB944")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0678", Offset = "0x6D0678")]
	public Task<scoreStatsObj> loadScoreStatsWrap(string courseName, int difficulty)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x8BBA64", Offset = "0x8BBA64", VA = "0x8BBA64")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D06DC", Offset = "0x6D06DC")]
	private Task<string> putGhost(string authKey, string courseName, int difficulty, sharedRunObject runData)
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x8BBB8C", Offset = "0x8BBB8C", VA = "0x8BBB8C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0740", Offset = "0x6D0740")]
	public void putGhostWrap(string courseName, int difficulty, sharedRunObject runData)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x8BBC64", Offset = "0x8BBC64", VA = "0x8BBC64")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D07A4", Offset = "0x6D07A4")]
	private Task<sharedRunList> loadGhost(string authKey, string courseName, int difficulty, string songTitle, int num)
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x8BBDA0", Offset = "0x8BBDA0", VA = "0x8BBDA0")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0808", Offset = "0x6D0808")]
	public Task<sharedRunList> loadGhostWrap(string courseName, int difficulty, string songTitle, int num)
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x8BBED8", Offset = "0x8BBED8", VA = "0x8BBED8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D086C", Offset = "0x6D086C")]
	private Task<nameObject> loadName(string authKey, string playerName)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x8BBFE4", Offset = "0x8BBFE4", VA = "0x8BBFE4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D08D0", Offset = "0x6D08D0")]
	private Task<string> putName(string authKey, string playerName)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x8BC104", Offset = "0x8BC104", VA = "0x8BC104")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0934", Offset = "0x6D0934")]
	public Task<bool> putNameWrap(string userName, bool auth)
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x8BC214", Offset = "0x8BC214", VA = "0x8BC214")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0998", Offset = "0x6D0998")]
	private Task<tuneParamObject> loadTuneParams()
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x8BC30C", Offset = "0x8BC30C", VA = "0x8BC30C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D09FC", Offset = "0x6D09FC")]
	public Task<tuneParamObject> loadTuneParamsWrap()
	{
		return null;
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x8BC40C", Offset = "0x8BC40C", VA = "0x8BC40C")]
	public connectionManager()
	{
	}
}
[Token(Token = "0x2000070")]
public class copyTransform : MonoBehaviour
{
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetTransform;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zOffset;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float yOffset;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool doLerp;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Quaternion initalRot;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 initalPos;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x8C1950", Offset = "0x8C1950", VA = "0x8C1950")]
	private void Start()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x8C1A00", Offset = "0x8C1A00", VA = "0x8C1A00")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x8C1D0C", Offset = "0x8C1D0C", VA = "0x8C1D0C")]
	public copyTransform()
	{
	}
}
[Token(Token = "0x2000071")]
public class courseBuilder : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9B4", Offset = "0x6CD9B4")]
	private struct <downLoadTuneParams>d__80 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public courseBuilder <>4__this;

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<tuneParamObject> <>u__1;

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x8C68A8", Offset = "0x8C68A8", VA = "0x8C68A8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x8C6A64", Offset = "0x8C6A64", VA = "0x8C6A64", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9C4", Offset = "0x6CD9C4")]
	private sealed class <generateCource>d__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x17000129")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x8C6B60", Offset = "0x8C6B60", VA = "0x8C6B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x8C6BC8", Offset = "0x8C6BC8", VA = "0x8C6BC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x8C4E4C", Offset = "0x8C4E4C", VA = "0x8C4E4C")]
		[DebuggerHidden]
		public <generateCource>d__88(int <>1__state)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x8C6A70", Offset = "0x8C6A70", VA = "0x8C6A70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x8C6A74", Offset = "0x8C6A74", VA = "0x8C6A74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x8C6B68", Offset = "0x8C6B68", VA = "0x8C6B68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9D4", Offset = "0x6CD9D4")]
	private sealed class <cleanPath>d__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x4000C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool smooth;

		[Token(Token = "0x4000C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool reset;

		[Token(Token = "0x4000C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x1700012B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x8C6838", Offset = "0x8C6838", VA = "0x8C6838", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x8C68A0", Offset = "0x8C68A0", VA = "0x8C68A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x8C4F08", Offset = "0x8C4F08", VA = "0x8C4F08")]
		[DebuggerHidden]
		public <cleanPath>d__89(int <>1__state)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x8C6040", Offset = "0x8C6040", VA = "0x8C6040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x8C6044", Offset = "0x8C6044", VA = "0x8C6044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x8C6840", Offset = "0x8C6840", VA = "0x8C6840", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200019A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9E4", Offset = "0x6CD9E4")]
	private sealed class <checkPath>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x1700012D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x8C5FD0", Offset = "0x8C5FD0", VA = "0x8C5FD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x8C6038", Offset = "0x8C6038", VA = "0x8C6038", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x8C4FA4", Offset = "0x8C4FA4", VA = "0x8C4FA4")]
		[DebuggerHidden]
		public <checkPath>d__90(int <>1__state)
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x8C58A0", Offset = "0x8C58A0", VA = "0x8C58A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x8C58A4", Offset = "0x8C58A4", VA = "0x8C58A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x8C5FD8", Offset = "0x8C5FD8", VA = "0x8C5FD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD9F4", Offset = "0x6CD9F4")]
	private sealed class <searchPath>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x4000C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 startSearchingFromPos;

		[Token(Token = "0x1700012F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x8C7F54", Offset = "0x8C7F54", VA = "0x8C7F54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x8C7FBC", Offset = "0x8C7FBC", VA = "0x8C7FBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x8C5064", Offset = "0x8C5064", VA = "0x8C5064")]
		[DebuggerHidden]
		public <searchPath>d__91(int <>1__state)
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x8C6BD0", Offset = "0x8C6BD0", VA = "0x8C6BD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x8C6BD4", Offset = "0x8C6BD4", VA = "0x8C6BD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x8C7F5C", Offset = "0x8C7F5C", VA = "0x8C7F5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE83C", Offset = "0x6CE83C")]
	private static courseBuilder <Instance>k__BackingField;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject powerUpPrefab;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject powerDownPrefab;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject gatePairPrefabRed;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject gatePairPrefabBlue;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject endFlagPrefab;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 currentPathPos;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Vector3> path;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<bool> pathAllowDrop;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector3> pathPosLst;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int currentSpawnIndex;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pathDist;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float avergePathDist;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int averageSpawnSteps;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int powerUpSpawnCount;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int powerDownSpawnCount;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int gateHitCount;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int gateClearCount;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int powerUpSpawnFreq;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int curveFactor;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float bounceAngle;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int maxSteepness;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool gateDroped;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool lastStrech;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int maxSearchSteps;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector2 horSearchDirBounds;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector2 endOfCourseLimits;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int totalPathIndex;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int pathIndex;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Vector3> ghostPath;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool tuneCourseInit;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public int shardSpawnCount;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int shardCombo;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int pulseCombo;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int pulseComboMax;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool spawnPulse;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool spawnEndSection;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
	public bool generateCourse;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD7")]
	public bool dropGates;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<KeyValuePair<Transform, Vector3>> spawnedGatePosLst;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int gateSpawnIndexBoost;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool lookingForPath;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private courseRhythm cr;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private calcBodyPosition body;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private calcBodyMovement move;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private dataManager data;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private stateManager state;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private connectionManager connection;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private slopeLocomotion slope;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ghostManager ghost;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private UIManager UI;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject startPos;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3 currentPos;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<Vector3> posLst;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int gateSpawnDist;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<Vector3> deadEndLst;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float strechLen;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public int sphereRad;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public int castDist;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private LineRenderer pathLine;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<Vector2> gateDifficultySettings;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private int gateDifficulty;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private int pathOffset;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int totalPathCount;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private int highestSpawnIndex;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Vector3 lastSpawnPos;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<GameObject> spawnedObjects;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 currentGateSpawnPos;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float distToEnd;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private int horLayerMask;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private int verLayerMask;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public bool tuneMode;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private int tuneModeGateIndex;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private tuneParamObject tuneParams;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public List<Vector3> tunePath;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private int nPathsGenerated;

	[Token(Token = "0x1700005A")]
	public static courseBuilder Instance
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x8C1D14", Offset = "0x8C1D14", VA = "0x8C1D14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A60", Offset = "0x6D0A60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8C1D64", Offset = "0x8C1D64", VA = "0x8C1D64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A70", Offset = "0x6D0A70")]
		private set
		{
		}
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x8C1DB8", Offset = "0x8C1DB8", VA = "0x8C1DB8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0A80", Offset = "0x6D0A80")]
	private void downLoadTuneParams()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x8C1E78", Offset = "0x8C1E78", VA = "0x8C1E78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x8C1F54", Offset = "0x8C1F54", VA = "0x8C1F54")]
	private void Start()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x8C2284", Offset = "0x8C2284", VA = "0x8C2284")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x8C2E90", Offset = "0x8C2E90", VA = "0x8C2E90")]
	public void spawnGate(int nPathSections)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x8C4714", Offset = "0x8C4714", VA = "0x8C4714")]
	public Vector3 spawnGateTutorial(int nPathSections, int baseOffset)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x8C41F8", Offset = "0x8C41F8", VA = "0x8C41F8")]
	public void spawnPowerUp(int nBeats)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x8C448C", Offset = "0x8C448C", VA = "0x8C448C")]
	public void spawnPowerDown(int nBeats)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x8C2214", Offset = "0x8C2214", VA = "0x8C2214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0AE4", Offset = "0x6D0AE4")]
	public IEnumerator generateCource()
	{
		return null;
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x8C4E78", Offset = "0x8C4E78", VA = "0x8C4E78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0B48", Offset = "0x6D0B48")]
	public IEnumerator cleanPath(bool smooth = true, bool reset = false)
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x8C4F34", Offset = "0x8C4F34", VA = "0x8C4F34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0BAC", Offset = "0x6D0BAC")]
	public IEnumerator checkPath()
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x8C4FD0", Offset = "0x8C4FD0", VA = "0x8C4FD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0C10", Offset = "0x6D0C10")]
	public IEnumerator searchPath(Vector3 startSearchingFromPos)
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x8C5090", Offset = "0x8C5090", VA = "0x8C5090")]
	public static Vector3[] SmoothLine(Vector3[] inputPoints, float segmentSize)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x8C55A0", Offset = "0x8C55A0", VA = "0x8C55A0")]
	public courseBuilder()
	{
	}
}
[Token(Token = "0x2000072")]
public class courseRhythm : MonoBehaviour
{
	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource track;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<float> beatMap;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> beatMapRaw;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float trackTimer;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float beatLenght;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float beatMapCurrent;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool beatFrame;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool beatWindow;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool firstBeat;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool rhythmFailed;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int songIndex;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float beatTimer;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private dataManager data;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseBuilder course;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private musicLib music;

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x8C7FC4", Offset = "0x8C7FC4", VA = "0x8C7FC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x8C8034", Offset = "0x8C8034", VA = "0x8C8034")]
	private void Start()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x8C8420", Offset = "0x8C8420", VA = "0x8C8420")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x8C89D4", Offset = "0x8C89D4", VA = "0x8C89D4")]
	private void selectSong()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x8C8D00", Offset = "0x8C8D00", VA = "0x8C8D00")]
	public courseRhythm()
	{
	}
}
[Token(Token = "0x2000073")]
public class customCameraSettings : MonoBehaviour
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CameraClearFlags clearFlags;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera cam;

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x8FEBB0", Offset = "0x8FEBB0", VA = "0x8FEBB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x8FEC60", Offset = "0x8FEC60", VA = "0x8FEC60")]
	public customCameraSettings()
	{
	}
}
[Token(Token = "0x2000074")]
public class damageManager : MonoBehaviour
{
	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool doDamage;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int damageCounter;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private stateManager state;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private dataManager data;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform bloodFade;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float bloodFadeTimer;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource hurt;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 defaultScale;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x8FEC68", Offset = "0x8FEC68", VA = "0x8FEC68")]
	public void damage()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x8FEE00", Offset = "0x8FEE00", VA = "0x8FEE00")]
	private void Start()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x8FEF04", Offset = "0x8FEF04", VA = "0x8FEF04")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x8FF164", Offset = "0x8FF164", VA = "0x8FF164")]
	public damageManager()
	{
	}
}
[Token(Token = "0x2000075")]
public class scoreObject
{
	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string runId;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerName;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string courseName;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string dateTime;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int score;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x145A310", Offset = "0x145A310", VA = "0x145A310")]
	public scoreObject()
	{
	}
}
[Token(Token = "0x2000076")]
public class scoreList
{
	[Serializable]
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA04", Offset = "0x6CDA04")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<scoreObject, int> <>9__1_0;

		[Token(Token = "0x4000C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<scoreObject, int> <>9__2_0;

		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<scoreObject, string> <>9__3_0;

		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<scoreObject, string> <>9__5_0;

		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<IGrouping<string, scoreObject>, scoreObject> <>9__5_1;

		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<scoreObject, string> <>9__6_0;

		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<IGrouping<string, scoreObject>, scoreObject> <>9__6_1;

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x145A3EC", Offset = "0x145A3EC", VA = "0x145A3EC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x145A3F4", Offset = "0x145A3F4", VA = "0x145A3F4")]
		internal int <sort>b__1_0(scoreObject o)
		{
			return default(int);
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x145A40C", Offset = "0x145A40C", VA = "0x145A40C")]
		internal int <sortAscending>b__2_0(scoreObject o)
		{
			return default(int);
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x145A424", Offset = "0x145A424", VA = "0x145A424")]
		internal string <sortOnDate>b__3_0(scoreObject o)
		{
			return null;
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x145A43C", Offset = "0x145A43C", VA = "0x145A43C")]
		internal string <uniqueID>b__5_0(scoreObject elem)
		{
			return null;
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x145A454", Offset = "0x145A454", VA = "0x145A454")]
		internal scoreObject <uniqueID>b__5_1(IGrouping<string, scoreObject> group)
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x145A4A4", Offset = "0x145A4A4", VA = "0x145A4A4")]
		internal string <uniqueName>b__6_0(scoreObject elem)
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x145A4BC", Offset = "0x145A4BC", VA = "0x145A4BC")]
		internal scoreObject <uniqueName>b__6_1(IGrouping<string, scoreObject> group)
		{
			return null;
		}
	}

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<scoreObject> list;

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x1459984", Offset = "0x1459984", VA = "0x1459984")]
	public void sort()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x1459AB0", Offset = "0x1459AB0", VA = "0x1459AB0")]
	public void sortAscending()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x1459864", Offset = "0x1459864", VA = "0x1459864")]
	public void sortOnDate()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x1459BC0", Offset = "0x1459BC0", VA = "0x1459BC0")]
	public void crop(int n)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x14596A8", Offset = "0x14596A8", VA = "0x14596A8")]
	public void uniqueID()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x1459C38", Offset = "0x1459C38", VA = "0x1459C38")]
	public void uniqueName()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x1459DF4", Offset = "0x1459DF4", VA = "0x1459DF4")]
	public string serialize()
	{
		return null;
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x145A0AC", Offset = "0x145A0AC", VA = "0x145A0AC")]
	public void deserialize(string scoreLstStr)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x145A318", Offset = "0x145A318", VA = "0x145A318")]
	public scoreList()
	{
	}
}
[Token(Token = "0x2000077")]
public class sharedRunObject
{
	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string runId;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerName;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string courseName;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string dateTime;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string songTitle;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int score;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector3> ghostPos;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Vector3> coursePath;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<int> gateSpawnSongIndex;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> gateSpawnPathIndex;

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x145B438", Offset = "0x145B438", VA = "0x145B438")]
	public sharedRunObject()
	{
	}
}
[Token(Token = "0x2000078")]
public class sharedRunList
{
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<sharedRunObject> list;

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x145B3C8", Offset = "0x145B3C8", VA = "0x145B3C8")]
	public sharedRunList()
	{
	}
}
[Token(Token = "0x2000079")]
public class gameOverStateObject
{
	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int gameOverState;

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x8FFD28", Offset = "0x8FFD28", VA = "0x8FFD28")]
	public gameOverStateObject()
	{
	}
}
[Token(Token = "0x200007A")]
public class settingsObject
{
	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool freeRide;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool freeRideUnlocked;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool leftHand;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool ghostMarker;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int difficulty;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float bodyHeight;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ski;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rocketBoots;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int hookShoot;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int musicVol;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sfxVol;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool musicInFreeRide;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool highRefresh;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool smallHud;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<int> music;

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x145A75C", Offset = "0x145A75C", VA = "0x145A75C")]
	public settingsObject()
	{
	}
}
[Token(Token = "0x200007B")]
public class walletObject
{
	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int balance;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int collectedInLastCourse;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ski0;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ski1;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int ski2;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int ski3;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ski4;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int ski5;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rocketBoots;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int hookShoot;

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x146CFA0", Offset = "0x146CFA0", VA = "0x146CFA0")]
	public walletObject()
	{
	}
}
[Token(Token = "0x200007C")]
public class scoreStatsObj
{
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<float> normCounts;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<float> bins;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string lastUpdate;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x145A50C", Offset = "0x145A50C", VA = "0x145A50C")]
	public scoreStatsObj()
	{
	}
}
[Token(Token = "0x200007D")]
public class fallBackPath
{
	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Vector3> path;

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x900428", Offset = "0x900428", VA = "0x900428")]
	public fallBackPath()
	{
	}
}
[Token(Token = "0x200007E")]
public class beatMapLst
{
	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<float> lst;

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x8B6998", Offset = "0x8B6998", VA = "0x8B6998")]
	public beatMapLst()
	{
	}
}
[Token(Token = "0x200007F")]
public class dataManager : MonoBehaviour
{
	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA14", Offset = "0x6CDA14")]
	private sealed class <loadCustomMusic>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dataManager <>4__this;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <dirPath>5__2;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private analyzeMusic <am>5__3;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private musicLib <ml>5__4;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <count>5__5;

		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> <loadedSongs>5__6;

		[Token(Token = "0x4000C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FileInfo[] <>7__wrap6;

		[Token(Token = "0x4000C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <>7__wrap7;

		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string <songName>5__9;

		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MpegFile <mpegFile>5__10;

		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioClip <clip>5__11;

		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<float> <customSongBeatMap>5__12;

		[Token(Token = "0x17000131")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x901228", Offset = "0x901228", VA = "0x901228", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x901290", Offset = "0x901290", VA = "0x901290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x9008F4", Offset = "0x9008F4", VA = "0x9008F4")]
		[DebuggerHidden]
		public <loadCustomMusic>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x900B60", Offset = "0x900B60", VA = "0x900B60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x900B64", Offset = "0x900B64", VA = "0x900B64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x901230", Offset = "0x901230", VA = "0x901230", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool routineRunning;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string currentSongProcessed;

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x8FF1C8", Offset = "0x8FF1C8", VA = "0x8FF1C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x8FF280", Offset = "0x8FF280", VA = "0x8FF280")]
	public void writeRun(string playerName, sharedRunObject runData)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x8FF374", Offset = "0x8FF374", VA = "0x8FF374")]
	public sharedRunObject readRun(string playerName)
	{
		return null;
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x8FF470", Offset = "0x8FF470", VA = "0x8FF470")]
	public void writeScore(string playerName, string courseName, int score, string runId, int difficulty, string dateTime)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x8FF770", Offset = "0x8FF770", VA = "0x8FF770")]
	public scoreList readScore(string playerName, string courseName, int difficulty, bool includeUnAuth = false)
	{
		return null;
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x8FED00", Offset = "0x8FED00", VA = "0x8FED00")]
	public void writeGameOverState(string playerName, int gameOverState)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x8FFD30", Offset = "0x8FFD30", VA = "0x8FFD30")]
	public int readGameOverState(string playerName)
	{
		return default(int);
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x8FFE3C", Offset = "0x8FFE3C", VA = "0x8FFE3C")]
	public void writeSettings(string playerName, settingsObject settings)
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x8FFF18", Offset = "0x8FFF18", VA = "0x8FFF18")]
	public settingsObject readSettings(string playerName)
	{
		return null;
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x900018", Offset = "0x900018", VA = "0x900018")]
	public walletObject readWallet(string playerName)
	{
		return null;
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x90024C", Offset = "0x90024C", VA = "0x90024C")]
	public void writeWallet(string playerName, walletObject wallet)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x900328", Offset = "0x900328", VA = "0x900328")]
	public void writeFallBackPath(string cource, List<Vector3> path)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x900430", Offset = "0x900430", VA = "0x900430")]
	public List<Vector3> readFallBackPath(string cource)
	{
		return null;
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x90051C", Offset = "0x90051C", VA = "0x90051C")]
	public void writeBeatMapLst(string track, List<float> lst)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x90061C", Offset = "0x90061C", VA = "0x90061C")]
	public List<float> readBeatMapLst(string track)
	{
		return null;
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x9007A4", Offset = "0x9007A4", VA = "0x9007A4")]
	public string readPlayerID()
	{
		return null;
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x8FFB1C", Offset = "0x8FFB1C", VA = "0x8FFB1C")]
	public string readPlayerName(bool getUnAuthUser = false)
	{
		return null;
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x900884", Offset = "0x900884", VA = "0x900884")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0C74", Offset = "0x6D0C74")]
	public IEnumerator loadCustomMusic()
	{
		return null;
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x900920", Offset = "0x900920", VA = "0x900920")]
	public void clearData(bool force = false)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x900B08", Offset = "0x900B08", VA = "0x900B08")]
	public dataManager()
	{
	}
}
[Token(Token = "0x2000080")]
public class demoManager : MonoBehaviour
{
	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<BoxCollider> muteInDemo;

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x901298", Offset = "0x901298", VA = "0x901298")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x901394", Offset = "0x901394", VA = "0x901394")]
	public demoManager()
	{
	}
}
[Token(Token = "0x2000081")]
public class dropShadow : MonoBehaviour
{
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x90139C", Offset = "0x90139C", VA = "0x90139C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x901474", Offset = "0x901474", VA = "0x901474")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x901724", Offset = "0x901724", VA = "0x901724")]
	public dropShadow()
	{
	}
}
[Token(Token = "0x2000082")]
public class endlessManager : MonoBehaviour
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> sectionLst;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject worldBackDrop;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool scrollWorld;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sectionCount;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sectionTimer;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 newSectionLocation;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 newSectionRotation;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 bodyPosDelta;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyPosition body;

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x90172C", Offset = "0x90172C", VA = "0x90172C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x90179C", Offset = "0x90179C", VA = "0x90179C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x901910", Offset = "0x901910", VA = "0x901910")]
	public GameObject getSectionPrefab()
	{
		return null;
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x901990", Offset = "0x901990", VA = "0x901990")]
	public endlessManager()
	{
	}
}
[Token(Token = "0x2000083")]
public class endlessPowerUp : MonoBehaviour
{
	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private endlessManager endless;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private particleEffects effect;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool hit;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float aliveTimer;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject loop;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject infPart1;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject infPart2;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject infPart3;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject hitFlash;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource hitSound;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem effectCollected;

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x901A38", Offset = "0x901A38", VA = "0x901A38")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x901C8C", Offset = "0x901C8C", VA = "0x901C8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x901CB8", Offset = "0x901CB8", VA = "0x901CB8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x901EC8", Offset = "0x901EC8", VA = "0x901EC8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x902268", Offset = "0x902268", VA = "0x902268")]
	public endlessPowerUp()
	{
	}
}
[Token(Token = "0x2000084")]
public class enterNewSection : MonoBehaviour
{
	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int sectionType;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseBuilder course;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool loaded;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x902270", Offset = "0x902270", VA = "0x902270")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x902328", Offset = "0x902328", VA = "0x902328")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x902668", Offset = "0x902668", VA = "0x902668")]
	public enterNewSection()
	{
	}
}
[Token(Token = "0x2000085")]
public class enterStationaryArea : MonoBehaviour
{
	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private stateManager state;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UIManager UI;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private particleEffects effect;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyPosition body;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool loaded;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pulseTimer;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform moveableObjects;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform sprite1Trans;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Color sprite1Color;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float sprite1Alpha;

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x902670", Offset = "0x902670", VA = "0x902670")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x9028B8", Offset = "0x9028B8", VA = "0x9028B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x9028D4", Offset = "0x9028D4", VA = "0x9028D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x902C74", Offset = "0x902C74", VA = "0x902C74")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x902CFC", Offset = "0x902CFC", VA = "0x902CFC")]
	public enterStationaryArea()
	{
	}
}
[Token(Token = "0x2000086")]
public class fadeRhythmDot : MonoBehaviour
{
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startSize;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float aliveTimer;

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x902D04", Offset = "0x902D04", VA = "0x902D04")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x902DC8", Offset = "0x902DC8", VA = "0x902DC8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x902F24", Offset = "0x902F24", VA = "0x902F24")]
	public fadeRhythmDot()
	{
	}
}
[Token(Token = "0x2000087")]
public class flagManager : MonoBehaviour
{
	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private particleEffects effect;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseBuilder course;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem pulse1;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem pulse2;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource hitSound;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject pole;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject flag;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject banner1;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject banner2;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isHit;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int moveDir;

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x902F34", Offset = "0x902F34", VA = "0x902F34")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x903284", Offset = "0x903284", VA = "0x903284")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x9033BC", Offset = "0x9033BC", VA = "0x9033BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x903728", Offset = "0x903728", VA = "0x903728")]
	public flagManager()
	{
	}
}
[Token(Token = "0x2000088")]
public class flowMarker : MonoBehaviour
{
	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject markerAnchor;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject marker;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject ring;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject dot;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color sprite1Color;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float sprite1Alpha;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float dotScale;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float hudScaleFac;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float hudPosFac;

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x903738", Offset = "0x903738", VA = "0x903738")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x903920", Offset = "0x903920", VA = "0x903920")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x903DAC", Offset = "0x903DAC", VA = "0x903DAC")]
	public flowMarker()
	{
	}
}
[Token(Token = "0x2000089")]
public class freeRideEnd : MonoBehaviour
{
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private dataManager data;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UIManager UI;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool endOfCourse;

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x903DCC", Offset = "0x903DCC", VA = "0x903DCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x903EA8", Offset = "0x903EA8", VA = "0x903EA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x903F8C", Offset = "0x903F8C", VA = "0x903F8C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x904028", Offset = "0x904028", VA = "0x904028")]
	public freeRideEnd()
	{
	}
}
[Token(Token = "0x200008A")]
public class gateConnector : MonoBehaviour
{
	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform gateRed;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform gateBlue;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hit;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<bool> grounded;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int pathIndex;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 pathDir;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LineRenderer line;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private calcBodyPosition body;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyMovement move;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private courseBuilder course;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private courseRhythm cr;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BoxCollider col;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool landed;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool powerUpRoll;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 lineDir;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float lineDist;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Vector3> linePosLst;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float limitBurstTimer;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private UnityEngine.Object pulseObj;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Transform> hitFlashLst;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float beatDiff;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int gateCount;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float totalAdjustment;

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x904030", Offset = "0x904030", VA = "0x904030")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x904374", Offset = "0x904374", VA = "0x904374")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x905DE0", Offset = "0x905DE0", VA = "0x905DE0")]
	public gateConnector()
	{
	}
}
[Token(Token = "0x200008B")]
public class gateConnectorHit : MonoBehaviour
{
	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private courseBuilder course;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private particleEffects effect;

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x905EA8", Offset = "0x905EA8", VA = "0x905EA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x905F54", Offset = "0x905F54", VA = "0x905F54")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x906048", Offset = "0x906048", VA = "0x906048")]
	public gateConnectorHit()
	{
	}
}
[Token(Token = "0x200008C")]
public class gateControl : MonoBehaviour
{
	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effect;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseRhythm cr;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseBuilder course;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private mogulManager mogul;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CharacterController charControl;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform hitFlash;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AudioSource swosh;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource hitSound;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float aliveTimer;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float verticalMotionFac;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion targetRot;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool hit;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool close;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject p1;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject p2;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private gateConnector parentConnector;

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x906050", Offset = "0x906050", VA = "0x906050")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x906568", Offset = "0x906568", VA = "0x906568")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x906F0C", Offset = "0x906F0C", VA = "0x906F0C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x90721C", Offset = "0x90721C", VA = "0x90721C")]
	public gateControl()
	{
	}
}
[Token(Token = "0x200008D")]
public class gateHit : MonoBehaviour
{
	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x90722C", Offset = "0x90722C", VA = "0x90722C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x9072C0", Offset = "0x9072C0", VA = "0x9072C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x9072C4", Offset = "0x9072C4", VA = "0x9072C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x907420", Offset = "0x907420", VA = "0x907420")]
	public gateHit()
	{
	}
}
[Token(Token = "0x200008E")]
public class gateKeeper : MonoBehaviour
{
	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool firstGate;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource cowbell;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject scriptHolder;

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x907428", Offset = "0x907428", VA = "0x907428")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x907480", Offset = "0x907480", VA = "0x907480")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x9076AC", Offset = "0x9076AC", VA = "0x9076AC")]
	public gateKeeper()
	{
	}
}
[Token(Token = "0x200008F")]
[ExecuteInEditMode]
public class gatePlacementEditor : MonoBehaviour
{
	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gatePrefab;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool placeGates;

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x9076B4", Offset = "0x9076B4", VA = "0x9076B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x9080D8", Offset = "0x9080D8", VA = "0x9080D8")]
	public gatePlacementEditor()
	{
	}
}
[Token(Token = "0x2000090")]
public class getSpectrum : MonoBehaviour
{
	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA24", Offset = "0x6CDA24")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float avg1;

		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float avg2;

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x908A7C", Offset = "0x908A7C", VA = "0x908A7C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x908B1C", Offset = "0x908B1C", VA = "0x908B1C")]
		internal float <ComputeCoeff>b__0(float x1, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x908B30", Offset = "0x908B30", VA = "0x908B30")]
		internal float <ComputeCoeff>b__1(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x908BA8", Offset = "0x908BA8", VA = "0x908BA8")]
		internal float <ComputeCoeff>b__2(float y)
		{
			return default(float);
		}
	}

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject rhythmDot1;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rhythmDot2;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private playerRhythm pr;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<float> waveForm;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<float> motionDelta;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] sampleArray;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource track;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject marker;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float markerScaleFac;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float waveIndexLen;

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x9080E0", Offset = "0x9080E0", VA = "0x9080E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x9088A4", Offset = "0x9088A4", VA = "0x9088A4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x9088A8", Offset = "0x9088A8", VA = "0x9088A8")]
	public float ComputeCoeff(float[] values1, float[] values2)
	{
		return default(float);
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x908690", Offset = "0x908690", VA = "0x908690")]
	public static IList<int> FindPeaks(IList<float> values, int rangeOfPeaks)
	{
		return null;
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x908A84", Offset = "0x908A84", VA = "0x908A84")]
	public getSpectrum()
	{
	}
}
[Token(Token = "0x2000091")]
public class ghostController : MonoBehaviour
{
	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float keepAtDist;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool punt;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool instruct;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool hunch;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool jump;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float airTimer;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool followMode;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> wayPointPos;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<float> wayPointTime;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedFac;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color scarfColor;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int delay;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform rightFoot;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform leftFoot;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform rightHand;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform leftHand;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform bothFoots;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform bothHands;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform rightStick;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform leftStick;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform hips;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform spine;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform dropShadow;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Transform recordAnchor;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RaycastHit hit;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ParticleSystem snowClotts;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Transform scarf;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private LineRenderer scarfLine;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Vector3> scarfPos;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 defaultHipRot;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Vector3 defaultSpineRot;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 defaultStickPos;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 hunchHipRot;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 hunchHipPos;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private Vector3 hunchSpineRot;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Vector3 turnRightHand;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private Vector3 turnLeftHand;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Vector3 jumpRightFoot;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Vector3 jumpLeftFoot;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Vector3 jumpHipRot;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private Vector3 jumpHipPos;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Vector3 jumpStickScale;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector3 puntAnchorHigh;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 puntAnchorLow;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float puntTimer;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool init;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float slopeGrad;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private stateManager state;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private courseBuilder course;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private calcBodyMovement move;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private courseRhythm cr;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Vector3 currentDir;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float currentDist;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private int overShotSign;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private float overShotAmount;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public float speed;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Renderer[] allRenderers;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private float changeTargetTimer;

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x908C20", Offset = "0x908C20", VA = "0x908C20")]
	private void Start()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x909078", Offset = "0x909078", VA = "0x909078")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x90C058", Offset = "0x90C058", VA = "0x90C058")]
	public void jumpPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x90C0A4", Offset = "0x90C0A4", VA = "0x90C0A4")]
	public ghostController()
	{
	}
}
[Token(Token = "0x2000092")]
public class ghostManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA34", Offset = "0x6CDA34")]
	private struct <spawnGhost>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ghostManager <>4__this;

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<sharedRunList> <>u__1;

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x90C898", Offset = "0x90C898", VA = "0x90C898", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x90CE78", Offset = "0x90CE78", VA = "0x90CE78", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ghostSkierPrefab;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public sharedRunObject runData;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxNum;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private dataManager data;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseRhythm cr;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private connectionManager connection;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool initGhosts;

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x90C508", Offset = "0x90C508", VA = "0x90C508")]
	private void Start()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x90C628", Offset = "0x90C628", VA = "0x90C628")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x90C7C8", Offset = "0x90C7C8", VA = "0x90C7C8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0CD8", Offset = "0x6D0CD8")]
	private void spawnGhost()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x90C888", Offset = "0x90C888", VA = "0x90C888")]
	public ghostManager()
	{
	}
}
[Token(Token = "0x2000093")]
public class ghostSkierJumpCol : MonoBehaviour
{
	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x90CE84", Offset = "0x90CE84", VA = "0x90CE84")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x90CEE8", Offset = "0x90CEE8", VA = "0x90CEE8")]
	public ghostSkierJumpCol()
	{
	}
}
[Token(Token = "0x2000094")]
public class gradualActivator : MonoBehaviour
{
	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA44", Offset = "0x6CDA44")]
	private sealed class <activationLoop>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public gradualActivator <>4__this;

		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <nsize>5__2;

		[Token(Token = "0x17000133")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x90D22C", Offset = "0x90D22C", VA = "0x90D22C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x90D294", Offset = "0x90D294", VA = "0x90D294", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x90CF8C", Offset = "0x90CF8C", VA = "0x90CF8C")]
		[DebuggerHidden]
		public <activationLoop>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x90D030", Offset = "0x90D030", VA = "0x90D030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x90D034", Offset = "0x90D034", VA = "0x90D034", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x90D234", Offset = "0x90D234", VA = "0x90D234", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> objectLst;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int iterations;

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x90CEF0", Offset = "0x90CEF0", VA = "0x90CEF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x90CF1C", Offset = "0x90CF1C", VA = "0x90CF1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0D3C", Offset = "0x6D0D3C")]
	private IEnumerator activationLoop()
	{
		return null;
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x90CFB8", Offset = "0x90CFB8", VA = "0x90CFB8")]
	public gradualActivator()
	{
	}
}
[Token(Token = "0x2000095")]
public class hideOnQ1 : MonoBehaviour
{
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x90D29C", Offset = "0x90D29C", VA = "0x90D29C")]
	private void Start()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x90D370", Offset = "0x90D370", VA = "0x90D370")]
	public hideOnQ1()
	{
	}
}
[Token(Token = "0x2000096")]
public class hudDisplay : MonoBehaviour
{
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showHud;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject fpsDisplay;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject speedDisplay;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float deltaTime;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float updateRate;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fps;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int frameCount;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x90D378", Offset = "0x90D378", VA = "0x90D378")]
	private void Start()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x90D418", Offset = "0x90D418", VA = "0x90D418")]
	private void Update()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x90D494", Offset = "0x90D494", VA = "0x90D494")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x90D608", Offset = "0x90D608", VA = "0x90D608")]
	public hudDisplay()
	{
	}
}
[Token(Token = "0x2000097")]
public class initManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA54", Offset = "0x6CDA54")]
	private struct <waitForUserNameReg>d__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public initManager <>4__this;

		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string userName;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x90E0B0", Offset = "0x90E0B0", VA = "0x90E0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x90E280", Offset = "0x90E280", VA = "0x90E280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA64", Offset = "0x6CDA64")]
	private sealed class <LoadYourAsyncScene>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;

		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x17000135")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x90E040", Offset = "0x90E040", VA = "0x90E040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x90E0A8", Offset = "0x90E0A8", VA = "0x90E0A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x90DF38", Offset = "0x90DF38", VA = "0x90DF38")]
		[DebuggerHidden]
		public <LoadYourAsyncScene>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x90DF74", Offset = "0x90DF74", VA = "0x90DF74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x90DF78", Offset = "0x90DF78", VA = "0x90DF78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x90E048", Offset = "0x90E048", VA = "0x90E048", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private dataManager data;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private connectionManager connection;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool initDone;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool initWaiting;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool loading;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TextMeshProUGUI dots;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private localizedText info;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI version;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextMeshProUGUI infoTxt;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PicoIntegration picoCon;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int picoRetCode;

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x90D618", Offset = "0x90D618", VA = "0x90D618")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x90D74C", Offset = "0x90D74C", VA = "0x90D74C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x90D95C", Offset = "0x90D95C", VA = "0x90D95C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x90D9F0", Offset = "0x90D9F0", VA = "0x90D9F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x90DA84", Offset = "0x90DA84", VA = "0x90DA84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x90DE10", Offset = "0x90DE10", VA = "0x90DE10")]
	private void picoEntitlementCheck(int code)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x90DD4C", Offset = "0x90DD4C", VA = "0x90DD4C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0DA0", Offset = "0x6D0DA0")]
	private void waitForUserNameReg(string userName)
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x90DD20", Offset = "0x90DD20", VA = "0x90DD20")]
	private void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x90DEC8", Offset = "0x90DEC8", VA = "0x90DEC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0E04", Offset = "0x6D0E04")]
	private IEnumerator LoadYourAsyncScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x90DF64", Offset = "0x90DF64", VA = "0x90DF64")]
	public initManager()
	{
	}
}
[Token(Token = "0x2000098")]
public class instructorBillboardControl : MonoBehaviour
{
	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform ghost;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform player;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool flip;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool fromInstructor;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeLimit;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float matchTimerLimit;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int type;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float fadeTimer;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SpriteRenderer infoRenderer;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SpriteRenderer matchRenderer;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string spriteName;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string spriteNameMatch;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int currentIndex;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private stateManager state;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private calcBodyMovement move;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private tutorialManager tutorial;

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x90E28C", Offset = "0x90E28C", VA = "0x90E28C")]
	private void Start()
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x90E770", Offset = "0x90E770", VA = "0x90E770")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x90EC50", Offset = "0x90EC50", VA = "0x90EC50")]
	public instructorBillboardControl()
	{
	}
}
[Token(Token = "0x2000099")]
public class instructorCol : MonoBehaviour
{
	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int type;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x90EC70", Offset = "0x90EC70", VA = "0x90EC70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x90ECE0", Offset = "0x90ECE0", VA = "0x90ECE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x90EDB8", Offset = "0x90EDB8", VA = "0x90EDB8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x90EEC8", Offset = "0x90EEC8", VA = "0x90EEC8")]
	public instructorCol()
	{
	}
}
[Token(Token = "0x200009A")]
public class loadNewEndlessSection : MonoBehaviour
{
	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA74", Offset = "0x6CDA74")]
	private sealed class <addEnlessSection>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public loadNewEndlessSection <>4__this;

		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 pos;

		[Token(Token = "0x17000137")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x90F844", Offset = "0x90F844", VA = "0x90F844", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x90F8AC", Offset = "0x90F8AC", VA = "0x90F8AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x90F490", Offset = "0x90F490", VA = "0x90F490")]
		[DebuggerHidden]
		public <addEnlessSection>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x90F4C4", Offset = "0x90F4C4", VA = "0x90F4C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x90F4C8", Offset = "0x90F4C8", VA = "0x90F4C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x90F84C", Offset = "0x90F84C", VA = "0x90F84C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private endlessManager endless;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private rhythmManager rm;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private dataManager data;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool loaded;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool smooth;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform endlessPowerUp;

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x90EED8", Offset = "0x90EED8", VA = "0x90EED8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x90EFFC", Offset = "0x90EFFC", VA = "0x90EFFC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x90F3FC", Offset = "0x90F3FC", VA = "0x90F3FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0E68", Offset = "0x6D0E68")]
	private IEnumerator addEnlessSection(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x90F4BC", Offset = "0x90F4BC", VA = "0x90F4BC")]
	public loadNewEndlessSection()
	{
	}
}
[Token(Token = "0x200009B")]
public class loadNewSection : MonoBehaviour
{
	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private dataManager data;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 newSectionLocation;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool loaded;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool smooth;

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x90F8B4", Offset = "0x90F8B4", VA = "0x90F8B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x90F9B4", Offset = "0x90F9B4", VA = "0x90F9B4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x910208", Offset = "0x910208", VA = "0x910208")]
	public loadNewSection()
	{
	}
}
[Token(Token = "0x200009C")]
public class localizedManager : MonoBehaviour
{
	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, Dictionary<string, string>> data;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string currentLocal;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<string> header;

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x910270", Offset = "0x910270", VA = "0x910270")]
	public void Awake()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x9106B0", Offset = "0x9106B0", VA = "0x9106B0")]
	private void setCurrentLocal()
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x910284", Offset = "0x910284", VA = "0x910284")]
	private void readFile()
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x910804", Offset = "0x910804", VA = "0x910804")]
	public localizedManager()
	{
	}
}
[Token(Token = "0x200009D")]
public class localizedText : MonoBehaviour
{
	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string code;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool gui;

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x9108E8", Offset = "0x9108E8", VA = "0x9108E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x90D83C", Offset = "0x90D83C", VA = "0x90D83C")]
	public void setText()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x9108EC", Offset = "0x9108EC", VA = "0x9108EC")]
	public localizedText()
	{
	}
}
[Token(Token = "0x200009E")]
public class menuSkyDrop : MonoBehaviour
{
	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem groundSnowEffect;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource groundSoundEffect;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float downForce;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float downForceDamp;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x910B9C", Offset = "0x910B9C", VA = "0x910B9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x910DB8", Offset = "0x910DB8", VA = "0x910DB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x910E98", Offset = "0x910E98", VA = "0x910E98")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x9114C4", Offset = "0x9114C4", VA = "0x9114C4")]
	public menuSkyDrop()
	{
	}
}
[Token(Token = "0x200009F")]
public class mogulManager : MonoBehaviour
{
	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mogul;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int lastDropedAtIndex;

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x9114D8", Offset = "0x9114D8", VA = "0x9114D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x906A50", Offset = "0x906A50", VA = "0x906A50")]
	public void spawnMoguls(Vector3 pos, Transform owener)
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x911A6C", Offset = "0x911A6C", VA = "0x911A6C")]
	public mogulManager()
	{
	}
}
[Token(Token = "0x20000A0")]
public class musicLib : MonoBehaviour
{
	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AudioClip> musicLst;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TextAsset> rawBeatMapLst;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<List<float>> beatMapLst;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool customMusic;

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x911A7C", Offset = "0x911A7C", VA = "0x911A7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x911C08", Offset = "0x911C08", VA = "0x911C08")]
	public musicLib()
	{
	}
}
[Token(Token = "0x20000A1")]
public class musicPlayer : MonoBehaviour
{
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource player;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform playIcon;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> songPosLst;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<TextMeshProUGUI> songTitleLst;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RawImage zane;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RawImage custom;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<float> beatMap;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float beatMapCurrent;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float timer;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 playIconScale;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int songIndex;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private stateManager state;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UIManager UI;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private musicLib music;

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x911C78", Offset = "0x911C78", VA = "0x911C78")]
	private void Start()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x911F3C", Offset = "0x911F3C", VA = "0x911F3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x912400", Offset = "0x912400", VA = "0x912400")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x9124F0", Offset = "0x9124F0", VA = "0x9124F0")]
	public void playSong(int selectedSongIndex)
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x9126D4", Offset = "0x9126D4", VA = "0x9126D4")]
	public musicPlayer()
	{
	}
}
[Token(Token = "0x20000A2")]
public class obstacleCourseBuilder : MonoBehaviour
{
	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> pulseSpawnPoints;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityEngine.Object pulseObj;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x912774", Offset = "0x912774", VA = "0x912774")]
	private void Start()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x912AF4", Offset = "0x912AF4", VA = "0x912AF4")]
	public obstacleCourseBuilder()
	{
	}
}
[Token(Token = "0x20000A3")]
public class obstacleHit : MonoBehaviour
{
	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float hitPenalty;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool causeDamage;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool causeCrash;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool emitSnow;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject emitParticle;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private dataManager data;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private damageManager damage;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private calcBodyPosition body;

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x912AFC", Offset = "0x912AFC", VA = "0x912AFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x912C4C", Offset = "0x912C4C", VA = "0x912C4C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x913194", Offset = "0x913194", VA = "0x913194")]
	public obstacleHit()
	{
	}
}
[Token(Token = "0x20000A4")]
public class particleEffects : MonoBehaviour
{
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource skiAmbienceInit;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource skiAmbience1;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource skiAmbience2;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource skiAmbience3;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource skiTurn;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource skiTurnAlt;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource skiGrounding;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem cowbellEffect;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showSnowEffects;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int sideSnowAmount;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float snowBallAmount;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float rumbleStr;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float rumbleFreq;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pulseTimer;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int speedStripeAmount;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private calcBodyMovement move;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private calcBodyPosition body;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private stateManager state;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private slopeLocomotion slope;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private courseRhythm cr;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private rhythmManager rm;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private courseBuilder course;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ParticleSystem sideSnowR;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ParticleSystem sideSnowL;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject dropShadow;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private SpriteRenderer dropShadowImage;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float dropShadowJumpPos;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource hearthSound;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Transform skies;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform sprite1Trans;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Color sprite1Color;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float sprite1Alpha;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float snowBallAmountResetTimer;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<Transform> hitFlashLst;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private UnityEngine.Object whiteShard;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float rumbleTime;

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x9131A4", Offset = "0x9131A4", VA = "0x9131A4")]
	public void playCowbellEffect()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x9131A8", Offset = "0x9131A8", VA = "0x9131A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x9135F0", Offset = "0x9135F0", VA = "0x9135F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x914834", Offset = "0x914834", VA = "0x914834")]
	public void stopRumble()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x91483C", Offset = "0x91483C", VA = "0x91483C")]
	public particleEffects()
	{
	}
}
[Token(Token = "0x20000A5")]
[ExecuteInEditMode]
public class pineBillBoardInit : MonoBehaviour
{
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x9148CC", Offset = "0x9148CC", VA = "0x9148CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x914A38", Offset = "0x914A38", VA = "0x914A38")]
	public pineBillBoardInit()
	{
	}
}
[Token(Token = "0x20000A6")]
public class playerRhythm : MonoBehaviour
{
	[Token(Token = "0x20001A4")]
	public class stateObj
	{
		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPaused;

		[Token(Token = "0x4000C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool doRhythm;

		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool gameOver;

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x914CCC", Offset = "0x914CCC", VA = "0x914CCC")]
		public stateObj()
		{
		}
	}

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float frameMotion;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 lastHeading;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 lastEyeDir;

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x914A40", Offset = "0x914A40", VA = "0x914A40")]
	private void Start()
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x914AD4", Offset = "0x914AD4", VA = "0x914AD4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x914C44", Offset = "0x914C44", VA = "0x914C44")]
	public playerRhythm()
	{
	}
}
[Token(Token = "0x20000A7")]
public class powerDownTrigger : MonoBehaviour
{
	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float beatTargetTime;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private damageManager damage;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseRhythm cr;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private particleEffects effect;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem effectRing;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem effectTail;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float aliveTimer;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CharacterController charControl;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float verMotionFac;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float horMotionFac;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 randomOffset;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 generalDirection;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool hit;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject star;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject p1;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject p2;

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x914CDC", Offset = "0x914CDC", VA = "0x914CDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x914FD0", Offset = "0x914FD0", VA = "0x914FD0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x9153C0", Offset = "0x9153C0", VA = "0x9153C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x915738", Offset = "0x915738", VA = "0x915738")]
	public powerDownTrigger()
	{
	}
}
[Token(Token = "0x20000A8")]
public class powerUpTrigger : MonoBehaviour
{
	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float beatTargetTime;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> hitSounds;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseRhythm cr;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseBuilder cource;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effect;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem effectRing;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ParticleSystem effectTail;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ParticleSystem effectCollected;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject hitFlash;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource hitSound;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float aliveTimer;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private CharacterController charControl;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float verticalMotionFac;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float verticalMotionFacTarget;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 randomOffset;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 generalDirection;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool hit;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject ring;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject ringHalf1;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject ringHalf2;

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x9157BC", Offset = "0x9157BC", VA = "0x9157BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x915C30", Offset = "0x915C30", VA = "0x915C30")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x916100", Offset = "0x916100", VA = "0x916100")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x916478", Offset = "0x916478", VA = "0x916478")]
	public powerUpTrigger()
	{
	}
}
[Token(Token = "0x20000A9")]
public class progressManager : MonoBehaviour
{
	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject mainMenu;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private dataManager data;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UIManager UI;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> tutorialCourseLst;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<int> main1CourseLst;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> main2CourseLst;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> sideCourseLst;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> miniCourseLst;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool tutorialDone1;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool tutorialDone2;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int gameProgressCount;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool unlockAll;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool demoMod;

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x9164F8", Offset = "0x9164F8", VA = "0x9164F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x919174", Offset = "0x919174", VA = "0x919174")]
	public progressManager()
	{
	}
}
[Token(Token = "0x20000AA")]
public class pulseControl : MonoBehaviour
{
	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 endPos;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showComboText;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedBoost;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyPosition body;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private particleEffects effect;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private courseBuilder course;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioSource hitSound;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform sprite1Trans;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform sprite2Trans;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Color sprite1Color;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float sprite1Alpha;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 sprite2Scale;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ParticleSystem dotEffect;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private TextMeshProUGUI comboText;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private BoxCollider col;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool arrived;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1456E88", Offset = "0x1456E88", VA = "0x1456E88")]
	private void Start()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x145732C", Offset = "0x145732C", VA = "0x145732C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x145789C", Offset = "0x145789C", VA = "0x145789C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1457AF0", Offset = "0x1457AF0", VA = "0x1457AF0")]
	public pulseControl()
	{
	}
}
[Token(Token = "0x20000AB")]
public class puntLocomotion : MonoBehaviour
{
	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 puntVector;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float leftAngVelocity;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float rightAngVelocity;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float scale;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 samplePos;

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x1457B08", Offset = "0x1457B08", VA = "0x1457B08")]
	private void Start()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1457B9C", Offset = "0x1457B9C", VA = "0x1457B9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1457DB4", Offset = "0x1457DB4", VA = "0x1457DB4")]
	public puntLocomotion()
	{
	}
}
[Token(Token = "0x20000AC")]
public class rhythmManager : MonoBehaviour
{
	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool beatMatched;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool carving;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float matchFactor;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> waveForm;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<float> motionDelta;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float standardDeviation;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float corr;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<float> flowDeflateLimit;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private stateManager state;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private courseRhythm cr;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UIManager ui;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private courseBuilder course;

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1457E38", Offset = "0x1457E38", VA = "0x1457E38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1457F38", Offset = "0x1457F38", VA = "0x1457F38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x14581AC", Offset = "0x14581AC", VA = "0x14581AC")]
	public rhythmManager()
	{
	}
}
[Token(Token = "0x20000AD")]
public class rhythmMarker : MonoBehaviour
{
	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private rhythmManager rm;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseBuilder cource;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beatMarker;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject beatMatch;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem beatMatchEffect;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 currentTaget;

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x14582AC", Offset = "0x14582AC", VA = "0x14582AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1458468", Offset = "0x1458468", VA = "0x1458468")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x1458694", Offset = "0x1458694", VA = "0x1458694")]
	public rhythmMarker()
	{
	}
}
[Token(Token = "0x20000AE")]
public class scoreBreakdownManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA84", Offset = "0x6CDA84")]
	private struct <populateScoreBreakDown>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public scoreBreakdownManager <>4__this;

		[Token(Token = "0x4000C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string course;

		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int difficulty;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int currentScore;

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private scoreList <scoreData>5__2;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<scoreStatsObj> <>u__1;

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x1458FC8", Offset = "0x1458FC8", VA = "0x1458FC8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x1459AA4", Offset = "0x1459AA4", VA = "0x1459AA4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDA94", Offset = "0x6CDA94")]
	private sealed class <animateData>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public scoreBreakdownManager <>4__this;

		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public scoreStatsObj scoreStatsData;

		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float scoreDelta;

		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bestDelta;

		[Token(Token = "0x17000139")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x1458F58", Offset = "0x1458F58", VA = "0x1458F58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x1458FC0", Offset = "0x1458FC0", VA = "0x1458FC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1458AB8", Offset = "0x1458AB8", VA = "0x1458AB8")]
		[DebuggerHidden]
		public <animateData>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x1458B34", Offset = "0x1458B34", VA = "0x1458B34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1458B38", Offset = "0x1458B38", VA = "0x1458B38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x1458F60", Offset = "0x1458F60", VA = "0x1458F60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> barLst;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform scoreMark;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bestMark;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI score;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI best;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI bin0;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI bin5;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI bin9;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject star;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2 scoreMarkerMaxMin;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private dataManager data;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private connectionManager connection;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float aliveTime;

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x145869C", Offset = "0x145869C", VA = "0x145869C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6D0ECC", Offset = "0x6D0ECC")]
	public void populateScoreBreakDown(string playerName, int currentScore, string course, int difficulty)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x145877C", Offset = "0x145877C", VA = "0x145877C")]
	public void resetGraph()
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x1458A28", Offset = "0x1458A28", VA = "0x1458A28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0F30", Offset = "0x6D0F30")]
	private IEnumerator animateData(scoreStatsObj scoreStatsData, float scoreDelta, float bestDelta)
	{
		return null;
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x1458AE4", Offset = "0x1458AE4", VA = "0x1458AE4")]
	public scoreBreakdownManager()
	{
	}
}
[Token(Token = "0x20000AF")]
public class shakeImage : MonoBehaviour
{
	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 initScale;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x145A8B8", Offset = "0x145A8B8", VA = "0x145A8B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x145A8F4", Offset = "0x145A8F4", VA = "0x145A8F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x145AAA4", Offset = "0x145AAA4", VA = "0x145AAA4")]
	public shakeImage()
	{
	}
}
[Token(Token = "0x20000B0")]
public class shardControl : MonoBehaviour
{
	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 endPos;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float aliveTimer;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float endDist;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool hit;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject shard;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource hitSound;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CapsuleCollider capsuleCol;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject hitFlash;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private calcBodyMovement move;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private stateManager state;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private particleEffects effect;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private courseBuilder course;

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x145AAAC", Offset = "0x145AAAC", VA = "0x145AAAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x145AC70", Offset = "0x145AC70", VA = "0x145AC70")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x145B0C0", Offset = "0x145B0C0", VA = "0x145B0C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x145B3B8", Offset = "0x145B3B8", VA = "0x145B3B8")]
	public shardControl()
	{
	}
}
[Token(Token = "0x20000B1")]
public class skiJumpManager : MonoBehaviour
{
	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI jumpLen;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LineRenderer pathLine;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool landingSet;

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x145BD78", Offset = "0x145BD78", VA = "0x145BD78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x145BE70", Offset = "0x145BE70", VA = "0x145BE70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x145BEA8", Offset = "0x145BEA8", VA = "0x145BEA8")]
	private void jumpLanding()
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x145BFE8", Offset = "0x145BFE8", VA = "0x145BFE8")]
	public skiJumpManager()
	{
	}
}
[Token(Token = "0x20000B2")]
public class skiJumpTrigger : MonoBehaviour
{
	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource sfx;

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x145BFF0", Offset = "0x145BFF0", VA = "0x145BFF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x145C078", Offset = "0x145C078", VA = "0x145C078")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x145C154", Offset = "0x145C154", VA = "0x145C154")]
	public skiJumpTrigger()
	{
	}
}
[Token(Token = "0x20000B3")]
public class skiManager : MonoBehaviour
{
	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject snowBall;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool stationary;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private slopeLocomotion slope;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private stateManager state;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseRhythm cr;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effects;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 skiForward;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 skiPosition;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float skiSlopeDistance;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float turnAngleLerp;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float turnPushOut;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion vertRot;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 skiNormal;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float separation;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float separationLastValue;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float separationFac;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ParticleSystem sideSnowEffect;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ParticleSystem groundSnowEffect;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float rightSlopeDist;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float leftSlopeDist;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int maxSnowBallAmount;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float jumpPosStartTime;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float stopTurnFactor;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float stopTurnLimit;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float eyeSkiDirectionAngle;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int vertAlignBoost;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float telemarkFac;

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x145D0B0", Offset = "0x145D0B0", VA = "0x145D0B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x145D9EC", Offset = "0x145D9EC", VA = "0x145D9EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x1461AF0", Offset = "0x1461AF0", VA = "0x1461AF0")]
	public skiManager()
	{
	}
}
[Token(Token = "0x20000B4")]
public class slipperySurface : MonoBehaviour
{
	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x1461C08", Offset = "0x1461C08", VA = "0x1461C08")]
	private void Start()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x1461C78", Offset = "0x1461C78", VA = "0x1461C78")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x1461D98", Offset = "0x1461D98", VA = "0x1461D98")]
	public slipperySurface()
	{
	}
}
[Token(Token = "0x20000B5")]
public class slopeLocomotion : MonoBehaviour
{
	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float slopeGradient;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float hardSlopeGradient;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float slopeGradientMulti;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float slopeGradientDelta;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float slopeDistance;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float slopeVelcoity;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fallLineDist;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fallLineDistDelta;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 fallLine;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 slopeNormal;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool slopeContact;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float slopeContactTimer;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<float> slopeGradientLst;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private calcBodyPosition body;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private calcBodyMovement move;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private stateManager state;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UIManager UI;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int layerMask;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float scale;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float contactTimer;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> fallLineDistLst;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<float> slopeGradientMultiLst;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float slopeGradientMultiTarget;

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x1461DA0", Offset = "0x1461DA0", VA = "0x1461DA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x1461F80", Offset = "0x1461F80", VA = "0x1461F80")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x1462660", Offset = "0x1462660", VA = "0x1462660")]
	public slopeLocomotion()
	{
	}
}
[Token(Token = "0x20000B6")]
public class speedPadHit : MonoBehaviour
{
	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedBoost;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem beatEffect;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x14627B8", Offset = "0x14627B8", VA = "0x14627B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1462888", Offset = "0x1462888", VA = "0x1462888")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x14628C4", Offset = "0x14628C4", VA = "0x14628C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x14629A0", Offset = "0x14629A0", VA = "0x14629A0")]
	public speedPadHit()
	{
	}
}
[Token(Token = "0x20000B7")]
[ExecuteInEditMode]
public class speedPadPlacementEditor : MonoBehaviour
{
	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject speedPadPrefab;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool placeSpeedPad;

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x14629B0", Offset = "0x14629B0", VA = "0x14629B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1462D18", Offset = "0x1462D18", VA = "0x1462D18")]
	public speedPadPlacementEditor()
	{
	}
}
[Token(Token = "0x20000B8")]
public class stateManager : MonoBehaviour
{
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAA4", Offset = "0x6CDAA4")]
	private sealed class <LoadYourAsyncSceneWithFade>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public stateManager <>4__this;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x1700013B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x1464868", Offset = "0x1464868", VA = "0x1464868", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x14648D0", Offset = "0x14648D0", VA = "0x14648D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x1463B68", Offset = "0x1463B68", VA = "0x1463B68")]
		[DebuggerHidden]
		public <LoadYourAsyncSceneWithFade>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x1464778", Offset = "0x1464778", VA = "0x1464778", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x146477C", Offset = "0x146477C", VA = "0x146477C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x1464870", Offset = "0x1464870", VA = "0x1464870", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAB4", Offset = "0x6CDAB4")]
	private sealed class <LoadYourAsyncScene>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;

		[Token(Token = "0x4000C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x1700013D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x1464708", Offset = "0x1464708", VA = "0x1464708", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x1464770", Offset = "0x1464770", VA = "0x1464770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x1463C38", Offset = "0x1463C38", VA = "0x1463C38")]
		[DebuggerHidden]
		public <LoadYourAsyncScene>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x146463C", Offset = "0x146463C", VA = "0x146463C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1464640", Offset = "0x1464640", VA = "0x1464640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x1464710", Offset = "0x1464710", VA = "0x1464710", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE8CC", Offset = "0x6CE8CC")]
	private static stateManager <Instance>k__BackingField;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float raceTimer;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float confinementDist;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isPaused;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inFocus;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool loading;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool gameOver;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool stopingState;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool courseCleared;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inRace;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool doRhythm;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool generatingCourse;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool canFail;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool forceFreeRide;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool rewardItem;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool levelIsActive;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerName;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string currentScene;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int powerUpCount;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int score;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string runId;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string dateTime;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float deviceTweakFactor1;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float deviceTweakFactor2;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public settingsObject settings;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int hmdType;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private calcBodyPosition body;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private calcBodyMovement move;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private courseBuilder course;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private damageManager damage;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private UIManager UI;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private dataManager data;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private connectionManager connection;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ghostManager ghost;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private slopeLocomotion slope;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int layerMaskConfinement;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Renderer confinementRender;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float edgeColTimer;

	[Token(Token = "0x1700005B")]
	public static stateManager Instance
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1462D20", Offset = "0x1462D20", VA = "0x1462D20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F94", Offset = "0x6D0F94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1462D70", Offset = "0x1462D70", VA = "0x1462D70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FA4", Offset = "0x6D0FA4")]
		private set
		{
		}
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1462DC4", Offset = "0x1462DC4", VA = "0x1462DC4")]
	public void updatePlayerData()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x1462EF8", Offset = "0x1462EF8", VA = "0x1462EF8")]
	public void populateEndMenu(int mode)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1463AB8", Offset = "0x1463AB8", VA = "0x1463AB8")]
	public void LoadSceneWithFade(string sceneName)
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1463AEC", Offset = "0x1463AEC", VA = "0x1463AEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0FB4", Offset = "0x6D0FB4")]
	private IEnumerator LoadYourAsyncSceneWithFade(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1463B94", Offset = "0x1463B94", VA = "0x1463B94")]
	public void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1463BC8", Offset = "0x1463BC8", VA = "0x1463BC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D1018", Offset = "0x6D1018")]
	private IEnumerator LoadYourAsyncScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1463C64", Offset = "0x1463C64", VA = "0x1463C64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1463FBC", Offset = "0x1463FBC", VA = "0x1463FBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x14642B8", Offset = "0x14642B8", VA = "0x14642B8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x14644A0", Offset = "0x14644A0", VA = "0x14644A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x14644A4", Offset = "0x14644A4", VA = "0x14644A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x14644A8", Offset = "0x14644A8", VA = "0x14644A8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1464364", Offset = "0x1464364", VA = "0x1464364")]
	public void focusGained()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x14642C4", Offset = "0x14642C4", VA = "0x14642C4")]
	public void focusLost()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x14645B4", Offset = "0x14645B4", VA = "0x14645B4")]
	public stateManager()
	{
	}
}
[Token(Token = "0x20000B9")]
public class stickManager : MonoBehaviour
{
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject snowBall;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool setSticks;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private particleEffects effect;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform rightAnchor;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform leftAnchor;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform pointAnchor;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform rightStick;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform leftStick;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform pointStick;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 rightStuckPos;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 leftStuckPos;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 pointStuckPos;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float stickLength;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lerpSpeed;

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x14648D8", Offset = "0x14648D8", VA = "0x14648D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x1464A2C", Offset = "0x1464A2C", VA = "0x1464A2C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x1465DAC", Offset = "0x1465DAC", VA = "0x1465DAC")]
	public stickManager()
	{
	}
}
[Token(Token = "0x20000BA")]
public class strapManager : MonoBehaviour
{
	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform pole;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform bone;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 polePos;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 bonePos;

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x1465E58", Offset = "0x1465E58", VA = "0x1465E58")]
	private void Start()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x1465F64", Offset = "0x1465F64", VA = "0x1465F64")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x1466140", Offset = "0x1466140", VA = "0x1466140")]
	public strapManager()
	{
	}
}
[Token(Token = "0x20000BB")]
public class toggleEffects : MonoBehaviour
{
	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool toggleSnowEffects;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool toggleFly;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ParticleSystem> emitEffects;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<int> emitNumber;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Renderer> activateRenderLst;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Renderer> deactivateRenderLst;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> activateObjLst;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> deactivateObjLst;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effects;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyMovement move;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private stateManager state;

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1466148", Offset = "0x1466148", VA = "0x1466148")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1466378", Offset = "0x1466378", VA = "0x1466378")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x14667E4", Offset = "0x14667E4", VA = "0x14667E4")]
	public toggleEffects()
	{
	}
}
[Token(Token = "0x20000BC")]
public class tuneParamTrigger : MonoBehaviour
{
	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private courseRhythm cr;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private dataManager data;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private connectionManager connection;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private slopeLocomotion slope;

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x1466924", Offset = "0x1466924", VA = "0x1466924")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x1466A6C", Offset = "0x1466A6C", VA = "0x1466A6C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x1466C88", Offset = "0x1466C88", VA = "0x1466C88")]
	public tuneParamTrigger()
	{
	}
}
[Token(Token = "0x20000BD")]
public class tutorialJumpTrigger : MonoBehaviour
{
	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int type;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effects;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource hurtSound;

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x1466C90", Offset = "0x1466C90", VA = "0x1466C90")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x1466D5C", Offset = "0x1466D5C", VA = "0x1466D5C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x1466E94", Offset = "0x1466E94", VA = "0x1466E94")]
	public tutorialJumpTrigger()
	{
	}
}
[Token(Token = "0x20000BE")]
public class tutorialManager : MonoBehaviour
{
	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> sectionLst;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject worldBackDrop;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool scrollWorld;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int currentSection;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currentSubSectionIndex;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sectionCount;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int prevSectionCount;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int eventCount;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float sectionTimer;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource cowbell;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource tagChime;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<AudioClip> infoVoice1Lst;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<AudioClip> infoVoice2Lst;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 spawnVector;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject spawnSection;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float instructorAirFactor;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ghostController ghost;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject instructorBillboard;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float matchTimer;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool spawnInstructorBillboardHunch;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool spawnInstructorBillboardJump;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 tutorialInstructorAnchorTarget;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Vector3> tutorialGateLst;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool dropZigZagGates;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
	public bool transitionToCourse;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public AudioSource infoVoice1;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AudioSource infoVoice2;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AudioSource infoVoiceGreat;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource infoVoiceLetsGo;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool infoVoice1Played;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	public bool infoVoice2Played;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
	public bool matched;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private calcBodyMovement move;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private calcBodyPosition body;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private stateManager state;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private rhythmManager rm;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private courseRhythm cr;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private UIManager UI;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private dataManager data;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private slopeLocomotion slope;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private particleEffects effects;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private courseBuilder course;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private puntLocomotion punt;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3 bodyPosDelta;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject tutorialInstructorAnchor;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject tutorialInstructorAnchorLocal;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject instructorBillboardInstance;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool drawLine;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private LineRenderer pathLine;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<Vector3> pathLinePosLst;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Gradient pathLineGradient;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GradientColorKey[] colorKey;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GradientAlphaKey[] alphaKey;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<Transform> arrowLst;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<Transform> arrowMatchLst;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<float> arrowOffset;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject stationaryArea;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject taskMenuUI;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float periodicTimer;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float generalTimer;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float pathTurnFactor;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private int slalomFactor;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private int verticalMotionConst;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private int lastPlayedVoiceSection;

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x1466E9C", Offset = "0x1466E9C", VA = "0x1466E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x1467140", Offset = "0x1467140", VA = "0x1467140")]
	private void Start()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x146767C", Offset = "0x146767C", VA = "0x146767C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x146A380", Offset = "0x146A380", VA = "0x146A380")]
	private void tutorialAdvanced()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x1467C7C", Offset = "0x1467C7C", VA = "0x1467C7C")]
	private void tutorialBasicMotion()
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x146BBE8", Offset = "0x146BBE8", VA = "0x146BBE8")]
	public void nextSubSection(bool newSection = false)
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x146760C", Offset = "0x146760C", VA = "0x146760C")]
	public GameObject getSectionPrefab()
	{
		return null;
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x146BA80", Offset = "0x146BA80", VA = "0x146BA80")]
	private void playVoiceInfo()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x146BC4C", Offset = "0x146BC4C", VA = "0x146BC4C")]
	public tutorialManager()
	{
	}
}
[Token(Token = "0x20000BF")]
public class unParent : MonoBehaviour
{
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x146BE9C", Offset = "0x146BE9C", VA = "0x146BE9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x146BEC4", Offset = "0x146BEC4", VA = "0x146BEC4")]
	public unParent()
	{
	}
}
[Token(Token = "0x20000C0")]
public class unloadSection : MonoBehaviour
{
	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool destory;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x146BECC", Offset = "0x146BECC", VA = "0x146BECC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x146BF3C", Offset = "0x146BF3C", VA = "0x146BF3C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x146C014", Offset = "0x146C014", VA = "0x146C014")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x146C0DC", Offset = "0x146C0DC", VA = "0x146C0DC")]
	public unloadSection()
	{
	}
}
[Token(Token = "0x20000C1")]
public class videoCameraControl : MonoBehaviour
{
	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform lookAtTarget;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speedUp;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speedForward;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int delay;

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x146C0E4", Offset = "0x146C0E4", VA = "0x146C0E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x146C118", Offset = "0x146C118", VA = "0x146C118")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x146C334", Offset = "0x146C334", VA = "0x146C334")]
	public videoCameraControl()
	{
	}
}
[Token(Token = "0x20000C2")]
public class walkieTalkieManager : MonoBehaviour
{
	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effect;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform markerAnchor;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpriteRenderer talkie;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private localizedText subtitleTxt;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource audioSource1;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource audioSource2;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float updateStep;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int sampleDataLength;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float currentUpdateTime;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float timeSinceTalk;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float clipLoudness;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float[] clipSampleData;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, string> subtitles;

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x146C344", Offset = "0x146C344", VA = "0x146C344")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x146C4E0", Offset = "0x146C4E0", VA = "0x146C4E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x146C8E4", Offset = "0x146C8E4", VA = "0x146C8E4")]
	private void getLoudness()
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x146CC5C", Offset = "0x146CC5C", VA = "0x146CC5C")]
	public walkieTalkieManager()
	{
	}
}
[Token(Token = "0x20000C3")]
public class skiLiftManager : MonoBehaviour
{
	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Vector3> pointsLeft;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> pointsRight;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<List<Vector3>> posLst;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Transform> gondolas;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector3> gondolasCurrentTarget;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Quaternion> gondolasPeriodicRot;

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x145C15C", Offset = "0x145C15C", VA = "0x145C15C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x145C8B4", Offset = "0x145C8B4", VA = "0x145C8B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x145CEE4", Offset = "0x145CEE4", VA = "0x145CEE4")]
	public skiLiftManager()
	{
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20000C4")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001A9")]
		private class CameraState
		{
			[Token(Token = "0x4000C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x8B4B40", Offset = "0x8B4B40", VA = "0x8B4B40")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x8B51C8", Offset = "0x8B51C8", VA = "0x8B51C8")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x8B5298", Offset = "0x8B5298", VA = "0x8B5298")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x8B53BC", Offset = "0x8B53BC", VA = "0x8B53BC")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x8B55EC", Offset = "0x8B55EC", VA = "0x8B55EC")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE8DC", Offset = "0x6CE8DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE8DC", Offset = "0x6CE8DC")]
		public float boost;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE93C", Offset = "0x6CE93C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE93C", Offset = "0x6CE93C")]
		public float positionLerpTime;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE994", Offset = "0x6CE994")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE994", Offset = "0x6CE994")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE9F4", Offset = "0x6CE9F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE9F4", Offset = "0x6CE9F4")]
		public float rotationLerpTime;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEA4C", Offset = "0x6CEA4C")]
		public bool invertY;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8B4AE8", Offset = "0x8B4AE8", VA = "0x8B4AE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x8B4BC8", Offset = "0x8B4BC8", VA = "0x8B4BC8")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x8B4E84", Offset = "0x8B4E84", VA = "0x8B4E84")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x8B544C", Offset = "0x8B544C", VA = "0x8B544C")]
		public SimpleCameraController()
		{
		}
	}
}
namespace UnityEngine.Rendering.LWRP
{
	[Token(Token = "0x20000C5")]
	public class Blit : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x20001AA")]
		public class BlitSettings
		{
			[Token(Token = "0x4000C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			[Token(Token = "0x4000C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			[Token(Token = "0x4000C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int blitMaterialPassIndex;

			[Token(Token = "0x4000C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Target destination;

			[Token(Token = "0x4000C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureId;

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x8B46C0", Offset = "0x8B46C0", VA = "0x8B46C0")]
			public BlitSettings()
			{
			}
		}

		[Token(Token = "0x20001AB")]
		public enum Target
		{
			[Token(Token = "0x4000C8F")]
			Color,
			[Token(Token = "0x4000C90")]
			Texture
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlitSettings settings;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTargetHandle m_RenderTextureHandle;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BlitPass blitPass;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x8B4250", Offset = "0x8B4250", VA = "0x8B4250", Slot = "4")]
		public override void Create()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x8B4444", Offset = "0x8B4444", VA = "0x8B4444", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x8B465C", Offset = "0x8B465C", VA = "0x8B465C")]
		public Blit()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	internal class BlitPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001AC")]
		public enum RenderTarget
		{
			[Token(Token = "0x4000C92")]
			Color,
			[Token(Token = "0x4000C93")]
			RenderTexture
		}

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Material blitMaterial;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int blitShaderPassIndex;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA84", Offset = "0x6CEA84")]
		private FilterMode <filterMode>k__BackingField;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA94", Offset = "0x6CEA94")]
		private RenderTargetIdentifier <source>k__BackingField;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEAA4", Offset = "0x6CEAA4")]
		private RenderTargetHandle <destination>k__BackingField;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RenderTargetHandle m_TemporaryColorTexture;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string m_ProfilerTag;

		[Token(Token = "0x1700005C")]
		public FilterMode filterMode
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x8B4728", Offset = "0x8B4728", VA = "0x8B4728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D107C", Offset = "0x6D107C")]
			get
			{
				return default(FilterMode);
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x8B4730", Offset = "0x8B4730", VA = "0x8B4730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D108C", Offset = "0x6D108C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x8B4738", Offset = "0x8B4738", VA = "0x8B4738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D109C", Offset = "0x6D109C")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x8B4750", Offset = "0x8B4750", VA = "0x8B4750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D10AC", Offset = "0x6D10AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x8B4768", Offset = "0x8B4768", VA = "0x8B4768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D10BC", Offset = "0x6D10BC")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x8B4770", Offset = "0x8B4770", VA = "0x8B4770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D10CC", Offset = "0x6D10CC")]
			set
			{
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8B43B4", Offset = "0x8B43B4", VA = "0x8B43B4")]
		public BlitPass(RenderPassEvent renderPassEvent, Material blitMaterial, int blitShaderPassIndex, string tag)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x8B4640", Offset = "0x8B4640", VA = "0x8B4640")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x8B4778", Offset = "0x8B4778", VA = "0x8B4778", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x8B4A38", Offset = "0x8B4A38", VA = "0x8B4A38", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x20000C7")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000760")]
		Array = 1,
		[Token(Token = "0x4000761")]
		Object = 2,
		[Token(Token = "0x4000762")]
		String = 3,
		[Token(Token = "0x4000763")]
		Number = 4,
		[Token(Token = "0x4000764")]
		NullValue = 5,
		[Token(Token = "0x4000765")]
		Boolean = 6,
		[Token(Token = "0x4000766")]
		None = 7,
		[Token(Token = "0x4000767")]
		Custom = 255
	}
	[Token(Token = "0x20000C8")]
	public enum JSONTextMode
	{
		[Token(Token = "0x4000769")]
		Compact,
		[Token(Token = "0x400076A")]
		Indent
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD62C", Offset = "0x6CD62C")]
	public abstract class JSONNode
	{
		[Token(Token = "0x20001AD")]
		public struct Enumerator
		{
			[Token(Token = "0x20001F5")]
			private enum Type
			{
				[Token(Token = "0x4000D37")]
				None,
				[Token(Token = "0x4000D38")]
				Array,
				[Token(Token = "0x4000D39")]
				Object
			}

			[Token(Token = "0x4000C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x4000C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x4000C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x1700013F")]
			public bool IsValid
			{
				[Token(Token = "0x6000BEF")]
				[Address(RVA = "0x144D4B0", Offset = "0x144D4B0", VA = "0x144D4B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000140")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000BF2")]
				[Address(RVA = "0x144D4E4", Offset = "0x144D4E4", VA = "0x144D4E4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x1446420", Offset = "0x1446420", VA = "0x1446420")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x144D4C0", Offset = "0x144D4C0", VA = "0x144D4C0")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x144D598", Offset = "0x144D598", VA = "0x144D598")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001AE")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x4000C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000141")]
			public JSONNode Current
			{
				[Token(Token = "0x6000BF7")]
				[Address(RVA = "0x144D9E8", Offset = "0x144D9E8", VA = "0x144D9E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x144D93C", Offset = "0x144D93C", VA = "0x144D93C")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x144D984", Offset = "0x144D984", VA = "0x144D984")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x144D9D0", Offset = "0x144D9D0", VA = "0x144D9D0")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x144DA34", Offset = "0x144DA34", VA = "0x144DA34")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x144DA38", Offset = "0x144DA38", VA = "0x144DA38")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x20001AF")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x4000C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000142")]
			public string Current
			{
				[Token(Token = "0x6000BFD")]
				[Address(RVA = "0x144D6D4", Offset = "0x144D6D4", VA = "0x144D6D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x144D628", Offset = "0x144D628", VA = "0x144D628")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x144D670", Offset = "0x144D670", VA = "0x144D670")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x144D6BC", Offset = "0x144D6BC", VA = "0x144D6BC")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x144D718", Offset = "0x144D718", VA = "0x144D718")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x144D71C", Offset = "0x144D71C", VA = "0x144D71C")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x20001B0")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x4000C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x4000C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000143")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000C01")]
				[Address(RVA = "0x144D72C", Offset = "0x144D72C", VA = "0x144D72C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000144")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C02")]
				[Address(RVA = "0x144D734", Offset = "0x144D734", VA = "0x144D734", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x144893C", Offset = "0x144893C", VA = "0x144893C")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x144D7A0", Offset = "0x144D7A0", VA = "0x144D7A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x144D7A8", Offset = "0x144D7A8", VA = "0x144D7A8", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x144D7C8", Offset = "0x144D7C8", VA = "0x144D7C8", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x144D82C", Offset = "0x144D82C", VA = "0x144D82C", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x144D8D8", Offset = "0x144D8D8", VA = "0x144D8D8", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAC4", Offset = "0x6CDAC4")]
		private sealed class <get_Children>d__42 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000145")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C0B")]
				[Address(RVA = "0x144CC54", Offset = "0x144CC54", VA = "0x144CC54", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000146")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C0D")]
				[Address(RVA = "0x144CCBC", Offset = "0x144CCBC", VA = "0x144CCBC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x14486A8", Offset = "0x14486A8", VA = "0x14486A8")]
			[DebuggerHidden]
			public <get_Children>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x144CC38", Offset = "0x144CC38", VA = "0x144CC38", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x144CC3C", Offset = "0x144CC3C", VA = "0x144CC3C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x144CC5C", Offset = "0x144CC5C", VA = "0x144CC5C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x144CCC4", Offset = "0x144CCC4", VA = "0x144CCC4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x144CD5C", Offset = "0x144CD5C", VA = "0x144CD5C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAD4", Offset = "0x6CDAD4")]
		private sealed class <get_DeepChildren>d__44 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000147")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C15")]
				[Address(RVA = "0x144D390", Offset = "0x144D390", VA = "0x144D390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000148")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C17")]
				[Address(RVA = "0x144D3F8", Offset = "0x144D3F8", VA = "0x144D3F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x1448760", Offset = "0x1448760", VA = "0x1448760")]
			[DebuggerHidden]
			public <get_DeepChildren>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x144CD60", Offset = "0x144CD60", VA = "0x144CD60", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x144CF70", Offset = "0x144CF70", VA = "0x144CF70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x144CEB0", Offset = "0x144CEB0", VA = "0x144CEB0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x144CDF0", Offset = "0x144CDF0", VA = "0x144CDF0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x144D398", Offset = "0x144D398", VA = "0x144D398", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x144D400", Offset = "0x144D400", VA = "0x144D400", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x144D4AC", Offset = "0x144D4AC", VA = "0x144D4AC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x400076E")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x1700005F")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x60005D2")]
			get;
		}

		[Token(Token = "0x17000060")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1448500", Offset = "0x1448500", VA = "0x1448500", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1448508", Offset = "0x1448508", VA = "0x1448508", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x144850C", Offset = "0x144850C", VA = "0x144850C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1448514", Offset = "0x1448514", VA = "0x1448514", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public virtual string Value
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1448518", Offset = "0x1448518", VA = "0x1448518", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1448560", Offset = "0x1448560", VA = "0x1448560", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public virtual int Count
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1448564", Offset = "0x1448564", VA = "0x1448564", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000064")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x144856C", Offset = "0x144856C", VA = "0x144856C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public virtual bool IsString
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1448574", Offset = "0x1448574", VA = "0x1448574", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x144857C", Offset = "0x144857C", VA = "0x144857C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public virtual bool IsNull
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1448584", Offset = "0x1448584", VA = "0x1448584", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public virtual bool IsArray
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x144858C", Offset = "0x144858C", VA = "0x144858C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public virtual bool IsObject
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1448594", Offset = "0x1448594", VA = "0x1448594", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public virtual bool Inline
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x144859C", Offset = "0x144859C", VA = "0x144859C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x14485A4", Offset = "0x14485A4", VA = "0x14485A4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1448638", Offset = "0x1448638", VA = "0x1448638", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D10DC", Offset = "0x6D10DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x14486E0", Offset = "0x14486E0", VA = "0x14486E0")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D1140", Offset = "0x6D1140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x14488DC", Offset = "0x14488DC", VA = "0x14488DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1448A00", Offset = "0x1448A00", VA = "0x1448A00")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x1700006F")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1448A48", Offset = "0x1448A48", VA = "0x1448A48")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000070")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1448A90", Offset = "0x1448A90", VA = "0x1448A90", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1448B6C", Offset = "0x1448B6C", VA = "0x1448B6C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public virtual int AsInt
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1448C04", Offset = "0x1448C04", VA = "0x1448C04", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1448C3C", Offset = "0x1448C3C", VA = "0x1448C3C", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1448C54", Offset = "0x1448C54", VA = "0x1448C54", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1448C78", Offset = "0x1448C78", VA = "0x1448C78", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1448C8C", Offset = "0x1448C8C", VA = "0x1448C8C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1448D54", Offset = "0x1448D54", VA = "0x1448D54", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public virtual long AsLong
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1448DD0", Offset = "0x1448DD0", VA = "0x1448DD0", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1448E10", Offset = "0x1448E10", VA = "0x1448E10", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1448E50", Offset = "0x1448E50", VA = "0x1448E50", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1448ED0", Offset = "0x1448ED0", VA = "0x1448ED0", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x14495F4", Offset = "0x14495F4", VA = "0x14495F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x14485A8", Offset = "0x14485A8", VA = "0x14485A8", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x14485AC", Offset = "0x14485AC", VA = "0x14485AC", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1448618", Offset = "0x1448618", VA = "0x1448618", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1448620", Offset = "0x1448620", VA = "0x1448620", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1448628", Offset = "0x1448628", VA = "0x1448628", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1448630", Offset = "0x1448630", VA = "0x1448630", Slot = "25")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1448798", Offset = "0x1448798", VA = "0x1448798", Slot = "27")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x14487A0", Offset = "0x14487A0", VA = "0x14487A0", Slot = "28")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x14487A8", Offset = "0x14487A8", VA = "0x14487A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x144883C", Offset = "0x144883C", VA = "0x144883C", Slot = "29")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x60005EF")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1448F50", Offset = "0x1448F50", VA = "0x1448F50")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1448FB0", Offset = "0x1448FB0", VA = "0x1448FB0")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1449044", Offset = "0x1449044", VA = "0x1449044")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x14490AC", Offset = "0x14490AC", VA = "0x14490AC")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1449144", Offset = "0x1449144", VA = "0x1449144")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x14491AC", Offset = "0x14491AC", VA = "0x14491AC")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1449244", Offset = "0x1449244", VA = "0x1449244")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x14492A4", Offset = "0x14492A4", VA = "0x14492A4")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x144933C", Offset = "0x144933C", VA = "0x144933C")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x144940C", Offset = "0x144940C", VA = "0x144940C")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x14494A4", Offset = "0x14494A4", VA = "0x14494A4")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1449504", Offset = "0x1449504", VA = "0x1449504")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x144959C", Offset = "0x144959C", VA = "0x144959C")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1446664", Offset = "0x1446664", VA = "0x1446664")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1446E44", Offset = "0x1446E44", VA = "0x1446E44")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x14495E0", Offset = "0x14495E0", VA = "0x14495E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x14495EC", Offset = "0x14495EC", VA = "0x14495EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x14496C4", Offset = "0x14496C4", VA = "0x14496C4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1449964", Offset = "0x1449964", VA = "0x1449964")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1445BF8", Offset = "0x1445BF8", VA = "0x1445BF8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		public abstract void SerializeBinary(BinaryWriter aWriter);

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1449B68", Offset = "0x1449B68", VA = "0x1449B68")]
		public void SaveToBinaryStream(Stream aData)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1449BE8", Offset = "0x1449BE8", VA = "0x1449BE8")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1449C54", Offset = "0x1449C54", VA = "0x1449C54")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1449CC0", Offset = "0x1449CC0", VA = "0x1449CC0")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1449D2C", Offset = "0x1449D2C", VA = "0x1449D2C")]
		public void SaveToBinaryFile(string aFileName)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1449E80", Offset = "0x1449E80", VA = "0x1449E80")]
		public string SaveToBinaryBase64()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x144A004", Offset = "0x144A004", VA = "0x144A004")]
		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x144A328", Offset = "0x144A328", VA = "0x144A328")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x144A394", Offset = "0x144A394", VA = "0x144A394")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x144A400", Offset = "0x144A400", VA = "0x144A400")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x144A46C", Offset = "0x144A46C", VA = "0x144A46C")]
		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x144A5AC", Offset = "0x144A5AC", VA = "0x144A5AC")]
		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x144A6E0", Offset = "0x144A6E0", VA = "0x144A6E0")]
		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x144A7B4", Offset = "0x144A7B4", VA = "0x144A7B4")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x144A830", Offset = "0x144A830", VA = "0x144A830")]
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x144AA10", Offset = "0x144AA10", VA = "0x144AA10")]
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x144AC74", Offset = "0x144AC74", VA = "0x144AC74")]
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x144AF4C", Offset = "0x144AF4C", VA = "0x144AF4C")]
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x144B224", Offset = "0x144B224", VA = "0x144B224")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x144B558", Offset = "0x144B558", VA = "0x144B558")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x144B884", Offset = "0x144B884", VA = "0x144B884")]
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x144B904", Offset = "0x144B904", VA = "0x144B904")]
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x144B984", Offset = "0x144B984", VA = "0x144B984")]
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x144BA04", Offset = "0x144BA04", VA = "0x144BA04")]
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x144BA84", Offset = "0x144BA84", VA = "0x144BA84")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x144BABC", Offset = "0x144BABC", VA = "0x144BABC")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x144BB34", Offset = "0x144BB34", VA = "0x144BB34")]
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x144BC90", Offset = "0x144BC90", VA = "0x144BC90")]
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x144B898", Offset = "0x144B898", VA = "0x144B898")]
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x144A8D4", Offset = "0x144A8D4", VA = "0x144A8D4")]
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x144BDA4", Offset = "0x144BDA4", VA = "0x144BDA4")]
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x144BF7C", Offset = "0x144BF7C", VA = "0x144BF7C")]
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x144B918", Offset = "0x144B918", VA = "0x144B918")]
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x144AAD0", Offset = "0x144AAD0", VA = "0x144AAD0")]
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x144C0E0", Offset = "0x144C0E0", VA = "0x144C0E0")]
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x144B998", Offset = "0x144B998", VA = "0x144B998")]
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x144AD18", Offset = "0x144AD18", VA = "0x144AD18")]
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x144C31C", Offset = "0x144C31C", VA = "0x144C31C")]
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x144BA18", Offset = "0x144BA18", VA = "0x144BA18")]
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x144AFF0", Offset = "0x144AFF0", VA = "0x144AFF0")]
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x144C558", Offset = "0x144C558", VA = "0x144C558")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x144BAA8", Offset = "0x144BAA8", VA = "0x144BAA8")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x144B2C8", Offset = "0x144B2C8", VA = "0x144B2C8")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x144C794", Offset = "0x144C794", VA = "0x144C794")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x144BAD0", Offset = "0x144BAD0", VA = "0x144BAD0")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x144B5D4", Offset = "0x144B5D4", VA = "0x144B5D4")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x144C9EC", Offset = "0x144C9EC", VA = "0x144C9EC")]
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x144CAFC", Offset = "0x144CAFC", VA = "0x144CAFC")]
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x14471D4", Offset = "0x14471D4", VA = "0x14471D4")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD664", Offset = "0x6CD664")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAE4", Offset = "0x6CDAE4")]
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000149")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C1E")]
				[Address(RVA = "0x14473A4", Offset = "0x14473A4", VA = "0x14473A4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C20")]
				[Address(RVA = "0x144740C", Offset = "0x144740C", VA = "0x144740C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1446F44", Offset = "0x1446F44", VA = "0x1446F44")]
			[DebuggerHidden]
			public <get_Children>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x14471DC", Offset = "0x14471DC", VA = "0x14471DC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x1447250", Offset = "0x1447250", VA = "0x1447250", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x14471F8", Offset = "0x14471F8", VA = "0x14471F8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x14473AC", Offset = "0x14473AC", VA = "0x14473AC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x1447414", Offset = "0x1447414", VA = "0x1447414", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x14474C0", Offset = "0x14474C0", VA = "0x14474C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000078")]
		public override bool Inline
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1446368", Offset = "0x1446368", VA = "0x1446368", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1446370", Offset = "0x1446370", VA = "0x1446370", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x144637C", Offset = "0x144637C", VA = "0x144637C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700007A")]
		public override bool IsArray
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x1446384", Offset = "0x1446384", VA = "0x1446384", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public override JSONNode Item
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x1446448", Offset = "0x1446448", VA = "0x1446448", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1446568", Offset = "0x1446568", VA = "0x1446568", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public override JSONNode Item
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1446894", Offset = "0x1446894", VA = "0x1446894", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x14468F4", Offset = "0x14468F4", VA = "0x14468F4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override int Count
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x14469B4", Offset = "0x14469B4", VA = "0x14469B4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007E")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1446EC4", Offset = "0x1446EC4", VA = "0x1446EC4", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D11A4", Offset = "0x6D11A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x144638C", Offset = "0x144638C", VA = "0x144638C", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1446A04", Offset = "0x1446A04", VA = "0x1446A04", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1446AC4", Offset = "0x1446AC4", VA = "0x1446AC4", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1446B70", Offset = "0x1446B70", VA = "0x1446B70", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1446BE0", Offset = "0x1446BE0", VA = "0x1446BE0", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1446F7C", Offset = "0x1446F7C", VA = "0x1446F7C", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x14470F4", Offset = "0x14470F4", VA = "0x14470F4", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1446DB4", Offset = "0x1446DB4", VA = "0x1446DB4")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD69C", Offset = "0x6CD69C")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDAF4", Offset = "0x6CDAF4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x144EBBC", Offset = "0x144EBBC", VA = "0x144EBBC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x144F34C", Offset = "0x144F34C", VA = "0x144F34C")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB04", Offset = "0x6CDB04")]
		private sealed class <get_Children>d__26 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700014B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C29")]
				[Address(RVA = "0x144F594", Offset = "0x144F594", VA = "0x144F594", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C2B")]
				[Address(RVA = "0x144F5FC", Offset = "0x144F5FC", VA = "0x144F5FC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x144EE90", Offset = "0x144EE90", VA = "0x144EE90")]
			[DebuggerHidden]
			public <get_Children>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x144F3C4", Offset = "0x144F3C4", VA = "0x144F3C4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x144F438", Offset = "0x144F438", VA = "0x144F438", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x144F3E0", Offset = "0x144F3E0", VA = "0x144F3E0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x144F59C", Offset = "0x144F59C", VA = "0x144F59C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x144F604", Offset = "0x144F604", VA = "0x144F604", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x144F6B0", Offset = "0x144F6B0", VA = "0x144F6B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700007F")]
		public override bool Inline
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x144E2BC", Offset = "0x144E2BC", VA = "0x144E2BC", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x144E2C4", Offset = "0x144E2C4", VA = "0x144E2C4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x144E2D0", Offset = "0x144E2D0", VA = "0x144E2D0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000081")]
		public override bool IsObject
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x144E2D8", Offset = "0x144E2D8", VA = "0x144E2D8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public override JSONNode Item
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x144E378", Offset = "0x144E378", VA = "0x144E378", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x144E434", Offset = "0x144E434", VA = "0x144E434", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x144E548", Offset = "0x144E548", VA = "0x144E548", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x144E5E0", Offset = "0x144E5E0", VA = "0x144E5E0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public override int Count
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x144E6FC", Offset = "0x144E6FC", VA = "0x144E6FC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x144EE10", Offset = "0x144EE10", VA = "0x144EE10", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D1208", Offset = "0x6D1208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x144E2E0", Offset = "0x144E2E0", VA = "0x144E2E0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x144E754", Offset = "0x144E754", VA = "0x144E754", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x144E8CC", Offset = "0x144E8CC", VA = "0x144E8CC", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x144E988", Offset = "0x144E988", VA = "0x144E988", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x144EA44", Offset = "0x144EA44", VA = "0x144EA44", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x144EBC4", Offset = "0x144EBC4", VA = "0x144EBC4", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x144ED1C", Offset = "0x144ED1C", VA = "0x144ED1C", Slot = "27")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x144ED84", Offset = "0x144ED84", VA = "0x144ED84", Slot = "28")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x144EEC8", Offset = "0x144EEC8", VA = "0x144EEC8", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x144F194", Offset = "0x144F194", VA = "0x144F194", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1447B10", Offset = "0x1447B10", VA = "0x1447B10")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000086")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x144F6B4", Offset = "0x144F6B4", VA = "0x144F6B4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000087")]
		public override bool IsString
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x144F6BC", Offset = "0x144F6BC", VA = "0x144F6BC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public override string Value
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x144F6E4", Offset = "0x144F6E4", VA = "0x144F6E4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x144F6EC", Offset = "0x144F6EC", VA = "0x144F6EC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x144F6C4", Offset = "0x144F6C4", VA = "0x144F6C4", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1448150", Offset = "0x1448150", VA = "0x1448150")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x144F6F4", Offset = "0x144F6F4", VA = "0x144F6F4", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x144F758", Offset = "0x144F758", VA = "0x144F758", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x144F810", Offset = "0x144F810", VA = "0x144F810", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x144F924", Offset = "0x144F924", VA = "0x144F924", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x144F944", Offset = "0x144F944", VA = "0x144F944", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x17000089")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x144DD28", Offset = "0x144DD28", VA = "0x144DD28", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700008A")]
		public override bool IsNumber
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x144DD30", Offset = "0x144DD30", VA = "0x144DD30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public override string Value
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x144DD58", Offset = "0x144DD58", VA = "0x144DD58", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x144DDD0", Offset = "0x144DDD0", VA = "0x144DDD0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public override double AsDouble
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x144DE94", Offset = "0x144DE94", VA = "0x144DE94", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x144DE9C", Offset = "0x144DE9C", VA = "0x144DE9C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public override long AsLong
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x144DEA4", Offset = "0x144DEA4", VA = "0x144DEA4", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x144DEC4", Offset = "0x144DEC4", VA = "0x144DEC4", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x144DD38", Offset = "0x144DD38", VA = "0x144DD38", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1447D98", Offset = "0x1447D98", VA = "0x1447D98")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x144DED0", Offset = "0x144DED0", VA = "0x144DED0")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x144DF58", Offset = "0x144DF58", VA = "0x144DF58", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x144DFC4", Offset = "0x144DFC4", VA = "0x144DFC4", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x144E004", Offset = "0x144E004", VA = "0x144E004")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x144E134", Offset = "0x144E134", VA = "0x144E134", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x144E260", Offset = "0x144E260", VA = "0x144E260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x144E26C", Offset = "0x144E26C", VA = "0x144E26C", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x1700008E")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x14474C4", Offset = "0x14474C4", VA = "0x14474C4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700008F")]
		public override bool IsBoolean
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x14474CC", Offset = "0x14474CC", VA = "0x14474CC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public override string Value
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x14474F4", Offset = "0x14474F4", VA = "0x14474F4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1447500", Offset = "0x1447500", VA = "0x1447500", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public override bool AsBool
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x144758C", Offset = "0x144758C", VA = "0x144758C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1447594", Offset = "0x1447594", VA = "0x1447594", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x14474D4", Offset = "0x14474D4", VA = "0x14474D4", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x14475A0", Offset = "0x14475A0", VA = "0x14475A0")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1447620", Offset = "0x1447620", VA = "0x1447620")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x14476A8", Offset = "0x14476A8", VA = "0x14476A8", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x144770C", Offset = "0x144770C", VA = "0x144770C", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1447788", Offset = "0x1447788", VA = "0x1447788", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1447810", Offset = "0x1447810", VA = "0x1447810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x144781C", Offset = "0x144781C", VA = "0x144781C", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x17000092")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x144DAB0", Offset = "0x144DAB0", VA = "0x144DAB0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000093")]
		public override bool IsNull
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x144DAB8", Offset = "0x144DAB8", VA = "0x144DAB8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public override string Value
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x144DAE0", Offset = "0x144DAE0", VA = "0x144DAE0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x144DB28", Offset = "0x144DB28", VA = "0x144DB28", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public override bool AsBool
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x144DB2C", Offset = "0x144DB2C", VA = "0x144DB2C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x144DB34", Offset = "0x144DB34", VA = "0x144DB34", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x14467F4", Offset = "0x14467F4", VA = "0x14467F4")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x144DA48", Offset = "0x144DA48", VA = "0x144DA48")]
		private JSONNull()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x144DAC0", Offset = "0x144DAC0", VA = "0x144DAC0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x144DB38", Offset = "0x144DB38", VA = "0x144DB38", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x144DB94", Offset = "0x144DB94", VA = "0x144DB94", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x144DC30", Offset = "0x144DC30", VA = "0x144DC30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x144DC38", Offset = "0x144DC38", VA = "0x144DC38", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x144DC94", Offset = "0x144DC94", VA = "0x144DC94", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6CD6D4", Offset = "0x6CD6D4")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000096")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1447868", Offset = "0x1447868", VA = "0x1447868", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000097")]
		public override JSONNode Item
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1447910", Offset = "0x1447910", VA = "0x1447910", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1447970", Offset = "0x1447970", VA = "0x1447970", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public override JSONNode Item
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1447A04", Offset = "0x1447A04", VA = "0x1447A04", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1447A74", Offset = "0x1447A74", VA = "0x1447A74", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public override int AsInt
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1447D20", Offset = "0x1447D20", VA = "0x1447D20", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1447E14", Offset = "0x1447E14", VA = "0x1447E14", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public override float AsFloat
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1447E90", Offset = "0x1447E90", VA = "0x1447E90", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1447F08", Offset = "0x1447F08", VA = "0x1447F08", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public override double AsDouble
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1447F84", Offset = "0x1447F84", VA = "0x1447F84", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1447FFC", Offset = "0x1447FFC", VA = "0x1447FFC", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public override long AsLong
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1448078", Offset = "0x1448078", VA = "0x1448078", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x14481CC", Offset = "0x14481CC", VA = "0x14481CC", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public override bool AsBool
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x14482D4", Offset = "0x14482D4", VA = "0x14482D4", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x144834C", Offset = "0x144834C", VA = "0x144834C", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x14483C8", Offset = "0x14483C8", VA = "0x14483C8", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1448434", Offset = "0x1448434", VA = "0x1448434", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1447870", Offset = "0x1447870", VA = "0x1447870", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x14464EC", Offset = "0x14464EC", VA = "0x14464EC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1447890", Offset = "0x1447890", VA = "0x1447890")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60006AB")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1447BA0", Offset = "0x1447BA0", VA = "0x1447BA0", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1447C34", Offset = "0x1447C34", VA = "0x1447C34", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1447CD0", Offset = "0x1447CD0", VA = "0x1447CD0")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1447CE8", Offset = "0x1447CE8", VA = "0x1447CE8")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1447D00", Offset = "0x1447D00", VA = "0x1447D00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1447D18", Offset = "0x1447D18", VA = "0x1447D18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x14484A0", Offset = "0x14484A0", VA = "0x14484A0", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x14484FC", Offset = "0x14484FC", VA = "0x14484FC", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public static class JSON
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1445B94", Offset = "0x1445B94", VA = "0x1445B94")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	public enum JSONContainerType
	{
		[Token(Token = "0x400077E")]
		Array,
		[Token(Token = "0x400077F")]
		Object
	}
}
namespace shortid
{
	[Token(Token = "0x20000D3")]
	public static class ShortId
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _random;

		[Token(Token = "0x4000781")]
		private const string Bigs = "ABCDEFGHIJKLMNOPQRSTUVWXY";

		[Token(Token = "0x4000782")]
		private const string Smalls = "abcdefghjlkmnopqrstuvwxyz";

		[Token(Token = "0x4000783")]
		private const string Numbers = "0123456789";

		[Token(Token = "0x4000784")]
		private const string Specials = "-_";

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _pool;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly object ThreadLock;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x145B508", Offset = "0x145B508", VA = "0x145B508")]
		public static string Generate(bool useNumbers = false, bool useSpecial = true)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x145B5AC", Offset = "0x145B5AC", VA = "0x145B5AC")]
		public static string Generate(bool useNumbers, bool useSpecial, int length)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x145B84C", Offset = "0x145B84C", VA = "0x145B84C")]
		public static string Generate(int length)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x145B8B8", Offset = "0x145B8B8", VA = "0x145B8B8")]
		public static void SetCharacters(string characters)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x145BA7C", Offset = "0x145BA7C", VA = "0x145BA7C")]
		public static void SetSeed(int seed)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x145BB9C", Offset = "0x145BB9C", VA = "0x145BB9C")]
		public static void Reset()
		{
		}
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x20000D4")]
	public class PvrControllerKey
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool State;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool PressedDown;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool PressedUp;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool LongPressed;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Click;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool Touch;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool TouchDown;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool TouchUp;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1486EE8", Offset = "0x1486EE8", VA = "0x1486EE8")]
		public PvrControllerKey()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class ControllerHand
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PvrControllerKey App;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PvrControllerKey Touch;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvrControllerKey Home;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PvrControllerKey VolumeDown;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PvrControllerKey VolumeUp;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PvrControllerKey Trigger;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PvrControllerKey X;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PvrControllerKey Y;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PvrControllerKey A;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PvrControllerKey B;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public PvrControllerKey Left;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public PvrControllerKey Right;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public PvrControllerKey Thumbrest;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2 TouchPadPosition;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int TriggerNum;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int GripValue;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Quaternion Rotation;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 Position;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int Battery;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public ControllerState ConnectState;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public SwipeDirection SwipeDirection;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TouchPadClick TouchPadClick;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isShowBoundary;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1486D04", Offset = "0x1486D04", VA = "0x1486D04")]
		public ControllerHand()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public enum ControllerState
	{
		[Token(Token = "0x40007A7")]
		Error = -1,
		[Token(Token = "0x40007A8")]
		DisConnected,
		[Token(Token = "0x40007A9")]
		Connected
	}
	[Token(Token = "0x20000D7")]
	public enum Pvr_KeyCode
	{
		[Token(Token = "0x40007AB")]
		None = 0,
		[Token(Token = "0x40007AC")]
		APP = 1,
		[Token(Token = "0x40007AD")]
		TOUCHPAD = 2,
		[Token(Token = "0x40007AE")]
		HOME = 4,
		[Token(Token = "0x40007AF")]
		VOLUMEUP = 8,
		[Token(Token = "0x40007B0")]
		VOLUMEDOWN = 16,
		[Token(Token = "0x40007B1")]
		TRIGGER = 32,
		[Token(Token = "0x40007B2")]
		A = 64,
		[Token(Token = "0x40007B3")]
		B = 128,
		[Token(Token = "0x40007B4")]
		X = 256,
		[Token(Token = "0x40007B5")]
		Y = 512,
		[Token(Token = "0x40007B6")]
		Left = 1024,
		[Token(Token = "0x40007B7")]
		Right = 2048,
		[Token(Token = "0x40007B8")]
		Thumbrest = 4096,
		[Token(Token = "0x40007B9")]
		Any = -1
	}
	[Token(Token = "0x20000D8")]
	public enum SwipeDirection
	{
		[Token(Token = "0x40007BB")]
		No,
		[Token(Token = "0x40007BC")]
		SwipeUp,
		[Token(Token = "0x40007BD")]
		SwipeDown,
		[Token(Token = "0x40007BE")]
		SwipeLeft,
		[Token(Token = "0x40007BF")]
		SwipeRight
	}
	[Token(Token = "0x20000D9")]
	public enum TouchPadClick
	{
		[Token(Token = "0x40007C1")]
		No,
		[Token(Token = "0x40007C2")]
		ClickUp,
		[Token(Token = "0x40007C3")]
		ClickDown,
		[Token(Token = "0x40007C4")]
		ClickLeft,
		[Token(Token = "0x40007C5")]
		ClickRight
	}
	[Token(Token = "0x20000DA")]
	public struct Controller
	{
		[Token(Token = "0x40007C6")]
		private const float JOYSTICK_THRESHOLD = 0.4f;

		[Token(Token = "0x40007C7")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1479F20", Offset = "0x1479F20", VA = "0x1479F20")]
		public static Vector2 UPvr_GetTouchPadPosition(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x14813B4", Offset = "0x14813B4", VA = "0x14813B4")]
		public static float UPvr_GetAxis1D(int hand, Pvr_KeyCode key)
		{
			return default(float);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1481538", Offset = "0x1481538", VA = "0x1481538")]
		public static Vector2 UPvr_GetAxis2D(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x14817D0", Offset = "0x14817D0", VA = "0x14817D0")]
		public static bool UPvr_GetJoystickUp(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x14819F8", Offset = "0x14819F8", VA = "0x14819F8")]
		public static bool UPvr_GetJoystickDown(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1481C24", Offset = "0x1481C24", VA = "0x1481C24")]
		public static bool UPvr_GetJoystickLeft(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1481E50", Offset = "0x1481E50", VA = "0x1481E50")]
		public static bool UPvr_GetJoystickRight(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1471FBC", Offset = "0x1471FBC", VA = "0x1471FBC")]
		public static ControllerState UPvr_GetControllerState(int hand)
		{
			return default(ControllerState);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1482078", Offset = "0x1482078", VA = "0x1482078")]
		public static Quaternion UPvr_GetControllerQUA(int hand)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1482190", Offset = "0x1482190", VA = "0x1482190")]
		public static Vector3 UPvr_GetControllerPOS(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x14822A4", Offset = "0x14822A4", VA = "0x14822A4")]
		public static Quaternion UPvr_GetControllerPredictRotation(int hand, float predictTime)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x148238C", Offset = "0x148238C", VA = "0x148238C")]
		public static Vector3 UPvr_GetControllerPredictPosition(int hand, float predictTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1472E58", Offset = "0x1472E58", VA = "0x1472E58")]
		public static int UPvr_GetControllerTriggerValue(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x147232C", Offset = "0x147232C", VA = "0x147232C")]
		public static int UPvr_GetControllerPower(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1482490", Offset = "0x1482490", VA = "0x1482490")]
		public static int UPvr_GetControllerPowerByPercent(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1482568", Offset = "0x1482568", VA = "0x1482568")]
		public static SwipeDirection UPvr_GetSwipeDirection(int hand)
		{
			return default(SwipeDirection);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1482638", Offset = "0x1482638", VA = "0x1482638")]
		public static TouchPadClick UPvr_GetTouchPadClick(int hand)
		{
			return default(TouchPadClick);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x14727E4", Offset = "0x14727E4", VA = "0x14727E4")]
		public static bool UPvr_GetKey(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1479114", Offset = "0x1479114", VA = "0x1479114")]
		public static bool UPvr_GetKeyDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1482708", Offset = "0x1482708", VA = "0x1482708")]
		public static bool UPvr_GetKeyUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1482D7C", Offset = "0x1482D7C", VA = "0x1482D7C")]
		public static bool UPvr_GetTouch(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1483140", Offset = "0x1483140", VA = "0x1483140")]
		public static bool UPvr_GetTouchDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1483504", Offset = "0x1483504", VA = "0x1483504")]
		public static bool UPvr_GetTouchUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x14838C8", Offset = "0x14838C8", VA = "0x14838C8")]
		public static bool UPvr_GetKeyClick(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1483F3C", Offset = "0x1483F3C", VA = "0x1483F3C")]
		public static bool UPvr_GetKeyLongPressed(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x147A5B8", Offset = "0x147A5B8", VA = "0x147A5B8")]
		public static bool UPvr_IsTouching(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x14845B0", Offset = "0x14845B0", VA = "0x14845B0")]
		public static void UPvr_SetHandNess(Pvr_Controller.UserHandNess hand)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1484670", Offset = "0x1484670", VA = "0x1484670")]
		public static Pvr_Controller.UserHandNess UPvr_GetHandNess()
		{
			return default(Pvr_Controller.UserHandNess);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x14846E4", Offset = "0x14846E4", VA = "0x14846E4")]
		public static int UPvr_GetPreferenceDevice()
		{
			return default(int);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x14847A0", Offset = "0x14847A0", VA = "0x14847A0")]
		public static bool UPvr_IsEnbleTrigger()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1471DFC", Offset = "0x1471DFC", VA = "0x1471DFC")]
		public static int UPvr_GetDeviceType()
		{
			return default(int);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1471F48", Offset = "0x1471F48", VA = "0x1471F48")]
		public static int UPvr_GetMainHandNess()
		{
			return default(int);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1484814", Offset = "0x1484814", VA = "0x1484814")]
		public static void UPvr_SetMainHandNess(int hand)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1484890", Offset = "0x1484890", VA = "0x1484890")]
		public static int UPvr_GetControllerAbility(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x148490C", Offset = "0x148490C", VA = "0x148490C")]
		public static void UPvr_VibrateNeo2Controller(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x14849A8", Offset = "0x14849A8", VA = "0x14849A8")]
		public static void UPvr_VibrateController(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1484A44", Offset = "0x1484A44", VA = "0x1484A44")]
		public static int UPvr_GetControllerBindingState(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1484AC0", Offset = "0x1484AC0", VA = "0x1484AC0")]
		public static Vector3 UPvr_GetVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1484B3C", Offset = "0x1484B3C", VA = "0x1484B3C")]
		public static Vector3 UPvr_GetAngularVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1484BB8", Offset = "0x1484BB8", VA = "0x1484BB8")]
		public static Vector3 UPvr_GetAcceleration(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1484C34", Offset = "0x1484C34", VA = "0x1484C34")]
		public static void UPvr_ScanController()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1484CA8", Offset = "0x1484CA8", VA = "0x1484CA8")]
		public static void UPvr_StopScanController()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1484D1C", Offset = "0x1484D1C", VA = "0x1484D1C")]
		public static void UPvr_ConnectController(string mac)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1484DE0", Offset = "0x1484DE0", VA = "0x1484DE0")]
		public static void UPvr_DisConnectController()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1484E54", Offset = "0x1484E54", VA = "0x1484E54")]
		public static void UPvr_ResetController(int hand)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1484ED0", Offset = "0x1484ED0", VA = "0x1484ED0")]
		public static string UPvr_GetControllerVersion()
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1484F44", Offset = "0x1484F44", VA = "0x1484F44")]
		public static void UPvr_GetDeviceVersion(int deviceType)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1484FC0", Offset = "0x1484FC0", VA = "0x1484FC0")]
		public static void UPvr_GetControllerSnCode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x148503C", Offset = "0x148503C", VA = "0x148503C")]
		public static void UPvr_SetControllerUnbind(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x14850B8", Offset = "0x14850B8", VA = "0x14850B8")]
		public static void UPvr_SetStationRestart()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x148512C", Offset = "0x148512C", VA = "0x148512C")]
		public static void UPvr_StartStationOtaUpdate()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x14851A0", Offset = "0x14851A0", VA = "0x14851A0")]
		public static void UPvr_StartControllerOtaUpdate(int mode, int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x148522C", Offset = "0x148522C", VA = "0x148522C")]
		public static void UPvr_EnterPairMode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x14852A8", Offset = "0x14852A8", VA = "0x14852A8")]
		public static void UPvr_SetControllerShutdown(int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1485324", Offset = "0x1485324", VA = "0x1485324")]
		public static int UPvr_GetStationPairState()
		{
			return default(int);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1485398", Offset = "0x1485398", VA = "0x1485398")]
		public static int UPvr_GetStationOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x148540C", Offset = "0x148540C", VA = "0x148540C")]
		public static int UPvr_GetControllerOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1485480", Offset = "0x1485480", VA = "0x1485480")]
		public static void UPvr_GetControllerVersionAndSN(int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x14854FC", Offset = "0x14854FC", VA = "0x14854FC")]
		public static void UPvr_GetControllerUniqueID()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1485570", Offset = "0x1485570", VA = "0x1485570")]
		public void UPvr_InterruptStationPairMode()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x14855E4", Offset = "0x14855E4", VA = "0x14855E4")]
		public void UPvr_StartCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1485660", Offset = "0x1485660", VA = "0x1485660")]
		public void UPvr_StopCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x14856DC", Offset = "0x14856DC", VA = "0x14856DC")]
		public static void UPvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1485798", Offset = "0x1485798", VA = "0x1485798")]
		public static void UPvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] controllerPrimary)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x148584C", Offset = "0x148584C", VA = "0x148584C")]
		public static void UPvr_GetPointerPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x14858F0", Offset = "0x14858F0", VA = "0x14858F0")]
		public static void UPvr_GetElbowPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1485990", Offset = "0x1485990", VA = "0x1485990")]
		public static void UPvr_GetWristPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1485A30", Offset = "0x1485A30", VA = "0x1485A30")]
		public static void UPvr_GetShoulderPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1485AD4", Offset = "0x1485AD4", VA = "0x1485AD4")]
		public static void UPvr_IsEnbleHomeKey(bool state)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1485B50", Offset = "0x1485B50", VA = "0x1485B50")]
		public static void UPvr_SwitchHomeKey(bool state)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1485BCC", Offset = "0x1485BCC", VA = "0x1485BCC")]
		public static int UPvr_GetControllerSensorStatus(int id)
		{
			return default(int);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1485C48", Offset = "0x1485C48", VA = "0x1485C48")]
		public static void UPvr_SetControllerOriginOffset(int hand, Vector3 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x148579C", Offset = "0x148579C", VA = "0x148579C")]
		private static extern void Pvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] gyro);

		[PreserveSig]
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1485850", Offset = "0x1485850", VA = "0x1485850")]
		private static extern void Pvr_GetPointerPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x14858F4", Offset = "0x14858F4", VA = "0x14858F4")]
		private static extern void Pvr_GetElbowPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1485994", Offset = "0x1485994", VA = "0x1485994")]
		private static extern void Pvr_GetWristPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1485A34", Offset = "0x1485A34", VA = "0x1485A34")]
		private static extern void Pvr_GetShoulderPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x14856E0", Offset = "0x14856E0", VA = "0x14856E0")]
		private static extern void Pvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle);
	}
	[Token(Token = "0x20000DB")]
	public enum ControllerVariety
	{
		[Token(Token = "0x40007C9")]
		Controller0,
		[Token(Token = "0x40007CA")]
		Controller1
	}
	[Token(Token = "0x20000DC")]
	public enum ControllerDevice
	{
		[Token(Token = "0x40007CC")]
		Goblin,
		[Token(Token = "0x40007CD")]
		Neo,
		[Token(Token = "0x40007CE")]
		G2,
		[Token(Token = "0x40007CF")]
		Neo2,
		[Token(Token = "0x40007D0")]
		Neo3,
		[Token(Token = "0x40007D1")]
		NewController
	}
	[Token(Token = "0x20000DD")]
	public enum GlobalIntConfigs
	{
		[Token(Token = "0x40007D3")]
		EYE_TEXTURE_RESOLUTION0,
		[Token(Token = "0x40007D4")]
		EYE_TEXTURE_RESOLUTION1,
		[Token(Token = "0x40007D5")]
		SEENSOR_COUNT,
		[Token(Token = "0x40007D6")]
		ABILITY6DOF,
		[Token(Token = "0x40007D7")]
		PLATFORM_TYPE,
		[Token(Token = "0x40007D8")]
		TRACKING_MODE,
		[Token(Token = "0x40007D9")]
		LOG_LEVEL,
		[Token(Token = "0x40007DA")]
		ENBLE_HAND6DOF_BY_HEAD,
		[Token(Token = "0x40007DB")]
		ENBLE_6DOF_GLOBAL_TRACKING,
		[Token(Token = "0x40007DC")]
		TARGET_FRAME_RATE,
		[Token(Token = "0x40007DD")]
		iShowFPS,
		[Token(Token = "0x40007DE")]
		SensorMode,
		[Token(Token = "0x40007DF")]
		LOGICFLOW,
		[Token(Token = "0x40007E0")]
		EYE_TEXTURE_RES_HIGH,
		[Token(Token = "0x40007E1")]
		EYE_TEXTURE_RES_NORMAL,
		[Token(Token = "0x40007E2")]
		iCtrlModelLoadingPri,
		[Token(Token = "0x40007E3")]
		iPhoneHMDModeEnabled,
		[Token(Token = "0x40007E4")]
		isEnableBoundary,
		[Token(Token = "0x40007E5")]
		Enable_Activity_Rotation,
		[Token(Token = "0x40007E6")]
		GetDisplay_Orientation,
		[Token(Token = "0x40007E7")]
		GetWaitFrameNum,
		[Token(Token = "0x40007E8")]
		GetResetFrameNum,
		[Token(Token = "0x40007E9")]
		EnableFFRBYSYS,
		[Token(Token = "0x40007EA")]
		RotControllerMode
	}
	[Token(Token = "0x20000DE")]
	public enum GlobalFloatConfigs
	{
		[Token(Token = "0x40007EC")]
		IPD,
		[Token(Token = "0x40007ED")]
		VFOV,
		[Token(Token = "0x40007EE")]
		HFOV,
		[Token(Token = "0x40007EF")]
		NECK_MODEL_X,
		[Token(Token = "0x40007F0")]
		NECK_MODEL_Y,
		[Token(Token = "0x40007F1")]
		NECK_MODEL_Z,
		[Token(Token = "0x40007F2")]
		DISPLAY_REFRESH_RATE
	}
	[Token(Token = "0x20000DF")]
	public enum RenderTextureAntiAliasing
	{
		[Token(Token = "0x40007F4")]
		X_1 = 1,
		[Token(Token = "0x40007F5")]
		X_2 = 2,
		[Token(Token = "0x40007F6")]
		X_4 = 4,
		[Token(Token = "0x40007F7")]
		X_8 = 8
	}
	[Token(Token = "0x20000E0")]
	public enum PlatForm
	{
		[Token(Token = "0x40007F9")]
		Android = 1,
		[Token(Token = "0x40007FA")]
		IOS,
		[Token(Token = "0x40007FB")]
		Win,
		[Token(Token = "0x40007FC")]
		Notsupport
	}
	[Token(Token = "0x20000E1")]
	public enum RenderTextureDepth
	{
		[Token(Token = "0x40007FE")]
		BD_0 = 0,
		[Token(Token = "0x40007FF")]
		BD_16 = 16,
		[Token(Token = "0x4000800")]
		BD_24 = 24
	}
	[Token(Token = "0x20000E2")]
	public enum RenderTextureLevel
	{
		[Token(Token = "0x4000802")]
		Normal,
		[Token(Token = "0x4000803")]
		High
	}
	[Token(Token = "0x20000E3")]
	public enum Sensorindex
	{
		[Token(Token = "0x4000805")]
		Default,
		[Token(Token = "0x4000806")]
		FirstSensor,
		[Token(Token = "0x4000807")]
		SecondSensor
	}
	[Token(Token = "0x20000E4")]
	public enum Eye
	{
		[Token(Token = "0x4000809")]
		LeftEye,
		[Token(Token = "0x400080A")]
		RightEye,
		[Token(Token = "0x400080B")]
		BothEye
	}
	[Token(Token = "0x20000E5")]
	public enum ResUtilsType
	{
		[Token(Token = "0x400080D")]
		TYPE_TEXTSIZE,
		[Token(Token = "0x400080E")]
		TYPE_COLOR,
		[Token(Token = "0x400080F")]
		TYPE_TEXT,
		[Token(Token = "0x4000810")]
		TYPE_FONT,
		[Token(Token = "0x4000811")]
		TYPE_VALUE,
		[Token(Token = "0x4000812")]
		TYPE_DRAWABLE,
		[Token(Token = "0x4000813")]
		TYPE_OBJECT,
		[Token(Token = "0x4000814")]
		TYPR_OBJECTARRAY
	}
	[Token(Token = "0x20000E6")]
	public enum TrackingOrigin
	{
		[Token(Token = "0x4000816")]
		EyeLevel,
		[Token(Token = "0x4000817")]
		FloorLevel,
		[Token(Token = "0x4000818")]
		StageLevel
	}
	[Token(Token = "0x20000E7")]
	public enum EFoveationLevel
	{
		[Token(Token = "0x400081A")]
		Low,
		[Token(Token = "0x400081B")]
		Med,
		[Token(Token = "0x400081C")]
		High,
		[Token(Token = "0x400081D")]
		Top_High
	}
	[Token(Token = "0x20000E8")]
	public enum StereoRenderingPathPico
	{
		[Token(Token = "0x400081F")]
		MultiPass,
		[Token(Token = "0x4000820")]
		SinglePass
	}
	[Token(Token = "0x20000E9")]
	public enum ExtraLatencyMode
	{
		[Token(Token = "0x4000822")]
		ExtraLatencyModeOff,
		[Token(Token = "0x4000823")]
		ExtraLatencyModeOn,
		[Token(Token = "0x4000824")]
		ExtraLatencyModeDynamic
	}
	[Token(Token = "0x20000EA")]
	public enum pvrEyePoseStatus
	{
		[Token(Token = "0x4000826")]
		kGazePointValid = 1,
		[Token(Token = "0x4000827")]
		kGazeVectorValid = 2,
		[Token(Token = "0x4000828")]
		kEyeOpennessValid = 4,
		[Token(Token = "0x4000829")]
		kEyePupilDilationValid = 8,
		[Token(Token = "0x400082A")]
		kEyePositionGuideValid = 0x10
	}
	[Token(Token = "0x20000EB")]
	public enum TrackingMode
	{
		[Token(Token = "0x400082C")]
		PVR_TRACKING_MODE_ROTATION = 1,
		[Token(Token = "0x400082D")]
		PVR_TRACKING_MODE_POSITION = 2,
		[Token(Token = "0x400082E")]
		PVR_TRACKING_MODE_EYE = 4
	}
	[Token(Token = "0x20000EC")]
	public struct EyeTrackingData
	{
		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int leftEyePoseStatus;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int rightEyePoseStatus;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int combinedEyePoseStatus;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 leftEyeGazePoint;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rightEyeGazePoint;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 combinedEyeGazePoint;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 leftEyeGazeVector;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rightEyeGazeVector;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 combinedEyeGazeVector;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float leftEyeOpenness;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rightEyeOpenness;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float leftEyePupilDilation;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rightEyePupilDilation;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 leftEyePositionGuide;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 rightEyePositionGuide;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 foveatedGazeDirection;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int foveatedGazeTrackingState;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public byte[] reserved;
	}
	[Token(Token = "0x20000ED")]
	public struct EyeTrackingGazeRay
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Direction;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool IsValid;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Origin;
	}
	[Token(Token = "0x20000EE")]
	public struct EyeDeviceInfo
	{
		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ViewFrustum targetFrustumLeft;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ViewFrustum targetFrustumRight;
	}
	[Token(Token = "0x20000EF")]
	public struct ViewFrustum
	{
		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float right;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float top;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float near;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float far;
	}
	[Token(Token = "0x20000F0")]
	public struct EyeSetting
	{
		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform eyelocalPosition;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Rect eyeRect;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float eyeFov;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float eyeAspect;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Matrix4x4 eyeProjectionMatrix;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader eyeShader;
	}
	[Token(Token = "0x20000F1")]
	public struct Sensor
	{
		[Token(Token = "0x4000852")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x148981C", Offset = "0x148981C", VA = "0x148981C")]
		private static extern int Pvr_Enable6DofModule(bool enable);

		[PreserveSig]
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x148989C", Offset = "0x148989C", VA = "0x148989C")]
		private static extern int Pvr_OptionalResetSensor(int index, int resetRot, int resetPos);

		[PreserveSig]
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1489930", Offset = "0x1489930", VA = "0x1489930")]
		private static extern int Pvr_Init(int index);

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x14899B0", Offset = "0x14899B0", VA = "0x14899B0")]
		private static extern int Pvr_StartSensor(int index);

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1489A30", Offset = "0x1489A30", VA = "0x1489A30")]
		private static extern int Pvr_StopSensor(int index);

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1489AB0", Offset = "0x1489AB0", VA = "0x1489AB0")]
		private static extern int Pvr_ResetSensor(int index);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1489B30", Offset = "0x1489B30", VA = "0x1489B30")]
		private static extern int Pvr_ResetSensorAll(int index);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1489BB0", Offset = "0x1489BB0", VA = "0x1489BB0")]
		private static extern int Pvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1489C88", Offset = "0x1489C88", VA = "0x1489C88")]
		private static extern int Pvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1489D6C", Offset = "0x1489D6C", VA = "0x1489D6C")]
		private static extern int Pvr_GetPsensorState();

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1489DE0", Offset = "0x1489DE0", VA = "0x1489DE0")]
		private static extern int Pvr_GetHmdPSensorStatus();

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1489E54", Offset = "0x1489E54", VA = "0x1489E54")]
		private static extern int Pvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1489EFC", Offset = "0x1489EFC", VA = "0x1489EFC")]
		private static extern int Pvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1489FA4", Offset = "0x1489FA4", VA = "0x1489FA4")]
		private static extern int Pvr_Get6DofSensorQualityStatus();

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x148A018", Offset = "0x148A018", VA = "0x148A018")]
		private static extern bool Pvr_Get6DofSafePanelFlag();

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x148A094", Offset = "0x148A094", VA = "0x148A094")]
		private static extern void Pvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x148A184", Offset = "0x148A184", VA = "0x148A184")]
		private static extern bool Pvr_SetTrackingOriginType(TrackingOrigin trackingOriginType);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x148A20C", Offset = "0x148A20C", VA = "0x148A20C")]
		private static extern bool Pvr_GetAcceleration(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x148A2AC", Offset = "0x148A2AC", VA = "0x148A2AC")]
		private static extern bool Pvr_GetAngularVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x148A34C", Offset = "0x148A34C", VA = "0x148A34C")]
		private static extern bool Pvr_GetVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x148A3EC", Offset = "0x148A3EC", VA = "0x148A3EC")]
		private static extern bool Pvr_GetAngularAcceleration(ref float x, ref float y, ref float z);

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x148A48C", Offset = "0x148A48C", VA = "0x148A48C")]
		public static bool UPvr_Pvr_Get6DofSafePanelFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x148A490", Offset = "0x148A490", VA = "0x148A490")]
		public static int UPvr_Init(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x148A494", Offset = "0x148A494", VA = "0x148A494")]
		public static void UPvr_InitPsensor()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x148A67C", Offset = "0x148A67C", VA = "0x148A67C")]
		public static int UPvr_GetPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x148A8D8", Offset = "0x148A8D8", VA = "0x148A8D8")]
		public static int UPvr_GetPSensorStatus()
		{
			return default(int);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x148A8DC", Offset = "0x148A8DC", VA = "0x148A8DC")]
		public static void UPvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x148AAD4", Offset = "0x148AAD4", VA = "0x148AAD4")]
		public static int UPvr_StartSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x148AAD8", Offset = "0x148AAD8", VA = "0x148AAD8")]
		public static int UPvr_StopSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x148AADC", Offset = "0x148AADC", VA = "0x148AADC")]
		public static int UPvr_ResetSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x148AB54", Offset = "0x148AB54", VA = "0x148AB54")]
		public static int UPvr_OptionalResetSensor(int index, int resetRot, int resetPos)
		{
			return default(int);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x148AB58", Offset = "0x148AB58", VA = "0x148AB58")]
		public static int UPvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz)
		{
			return default(int);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x148AB5C", Offset = "0x148AB5C", VA = "0x148AB5C")]
		public static int UPvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x148AB68", Offset = "0x148AB68", VA = "0x148AB68")]
		public static int UPvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x148AB6C", Offset = "0x148AB6C", VA = "0x148AB6C")]
		public static int UPvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x148AB70", Offset = "0x148AB70", VA = "0x148AB70")]
		public static int UPvr_Get6DofSensorQualityStatus()
		{
			return default(int);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x148AB74", Offset = "0x148AB74", VA = "0x148AB74")]
		public static int UPvr_Enable6DofModule(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x148A498", Offset = "0x148A498", VA = "0x148A498")]
		public static void Pvr_InitPsensor()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x148AD8C", Offset = "0x148AD8C", VA = "0x148AD8C")]
		public static bool Pvr_IsHead6dofReset()
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x148A6D0", Offset = "0x148A6D0", VA = "0x148A6D0")]
		public static int Pvr_GetAndroidPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x148A8E0", Offset = "0x148A8E0", VA = "0x148A8E0")]
		public static void Pvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x148AFAC", Offset = "0x148AFAC", VA = "0x148AFAC")]
		public static int UPvr_ResetSensorAll(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x148AFB0", Offset = "0x148AFB0", VA = "0x148AFB0")]
		public static void UPvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x148B3BC", Offset = "0x148B3BC", VA = "0x148B3BC")]
		public static bool UPvr_SetTrackingOriginType(TrackingOrigin trackingOriginType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x148B3C0", Offset = "0x148B3C0", VA = "0x148B3C0")]
		public static Vector3 UPvr_GetAcceleration()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x148B41C", Offset = "0x148B41C", VA = "0x148B41C")]
		public static Vector3 UPvr_AngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x148B470", Offset = "0x148B470", VA = "0x148B470")]
		public static Vector3 UPvr_GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x148B4CC", Offset = "0x148B4CC", VA = "0x148B4CC")]
		public static Vector3 UPvr_GetAngularAcceleration()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000F2")]
	public struct Render
	{
		[Token(Token = "0x4000853")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1487ED4", Offset = "0x1487ED4", VA = "0x1487ED4")]
		private static extern void Pvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1487FA4", Offset = "0x1487FA4", VA = "0x1487FA4")]
		private static extern int Pvr_SetRatio(float midH, float midV);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1488030", Offset = "0x1488030", VA = "0x1488030")]
		private static extern int Pvr_SetPupillaryPoint(bool enable);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x14880B0", Offset = "0x14880B0", VA = "0x14880B0")]
		private static extern IntPtr Pvr_GetSupportHMDTypes();

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1488124", Offset = "0x1488124", VA = "0x1488124")]
		private static extern void Pvr_SetCurrentHMDType(string type);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x14881B4", Offset = "0x14881B4", VA = "0x14881B4")]
		private static extern int Pvr_GetIntConfig(int configsenum, ref int res);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1488240", Offset = "0x1488240", VA = "0x1488240")]
		private static extern int Pvr_GetFloatConfig(int configsenum, ref float res);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x14882CC", Offset = "0x14882CC", VA = "0x14882CC")]
		private static extern void Pvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1488394", Offset = "0x1488394", VA = "0x1488394")]
		private static extern void Pvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1488474", Offset = "0x1488474", VA = "0x1488474")]
		private static extern void Pvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, float[] mvMatrix, float[] modelS, float[] modelR, float[] modelT, float[] cameraR, float[] cameraT, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x14885B0", Offset = "0x14885B0", VA = "0x14885B0")]
		private static extern bool Pvr_EnableFoveation(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1488638", Offset = "0x1488638", VA = "0x1488638")]
		private static extern void Pvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1488710", Offset = "0x1488710", VA = "0x1488710")]
		private static extern void Pvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x14887B8", Offset = "0x14887B8", VA = "0x14887B8")]
		private static extern void Pvr_SetFoveationParameters2(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x148885C", Offset = "0x148885C", VA = "0x148885C")]
		private static extern void Pvr_SetFoveationLevel(EFoveationLevel level);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x14888DC", Offset = "0x14888DC", VA = "0x14888DC")]
		private static extern EFoveationLevel Pvr_GetFoveationLevel();

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1488950", Offset = "0x1488950", VA = "0x1488950")]
		private static extern bool Pvr_GetIntSysProc(string property, ref int res);

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x14889FC", Offset = "0x14889FC", VA = "0x14889FC")]
		private static extern void Pvr_SetColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1488A7C", Offset = "0x1488A7C", VA = "0x1488A7C")]
		private static extern void Pvr_SetCastingColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1488AFC", Offset = "0x1488AFC", VA = "0x1488AFC")]
		private static extern IntPtr Pvr_CreateLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1488B8C", Offset = "0x1488B8C", VA = "0x1488B8C")]
		private static extern IntPtr Pvr_GetLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1488C1C", Offset = "0x1488C1C", VA = "0x1488C1C")]
		private static extern void Pvr_SetMonoMode(bool openMono);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1488C9C", Offset = "0x1488C9C", VA = "0x1488C9C")]
		private static extern void Pvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexData, ref IntPtr indexData);

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1488D4C", Offset = "0x1488D4C", VA = "0x1488D4C")]
		public static void UPvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1488D50", Offset = "0x1488D50", VA = "0x1488D50")]
		public static int UPvr_SetRatio(float midH, float midV)
		{
			return default(int);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1488D54", Offset = "0x1488D54", VA = "0x1488D54")]
		public static void UPvr_EnableFoveation(bool enable)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1488F28", Offset = "0x1488F28", VA = "0x1488F28")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D126C", Offset = "0x6D126C")]
		public static void UPvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1488F2C", Offset = "0x1488F2C", VA = "0x1488F2C")]
		public static void UPvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1488F30", Offset = "0x1488F30", VA = "0x1488F30")]
		public static void SetFoveatedRenderingLevel(EFoveationLevel level)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1489024", Offset = "0x1489024", VA = "0x1489024")]
		public static EFoveationLevel GetFoveatedRenderingLevel()
		{
			return default(EFoveationLevel);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1489028", Offset = "0x1489028", VA = "0x1489028")]
		public static void SetFoveatedRenderingParameters(Vector2 ffrGainValue, float ffrAreaValue, float ffrMinimumValue)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1489154", Offset = "0x1489154", VA = "0x1489154")]
		public static bool UPvr_GetIntSysProc(string property, ref int res)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1489158", Offset = "0x1489158", VA = "0x1489158")]
		public static int UPvr_GetIntConfig(int configsenum, ref int res)
		{
			return default(int);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x148915C", Offset = "0x148915C", VA = "0x148915C")]
		public static int UPvr_GetFloatConfig(int configsenum, ref float res)
		{
			return default(int);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1489160", Offset = "0x1489160", VA = "0x1489160")]
		public static string UPvr_GetSupportHMDTypes()
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x14891EC", Offset = "0x14891EC", VA = "0x14891EC")]
		public static void UPvr_SetCurrentHMDType(string type)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x14891F0", Offset = "0x14891F0", VA = "0x14891F0")]
		public static void UPvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1489330", Offset = "0x1489330", VA = "0x1489330")]
		public static void UPvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1489334", Offset = "0x1489334", VA = "0x1489334")]
		public static void UPvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, Matrix4x4 mvMatrix, Vector3 modelS, Quaternion modelR, Vector3 modelT, Quaternion cameraR, Vector3 cameraT, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1489800", Offset = "0x1489800", VA = "0x1489800")]
		public static void UPvr_SetColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1489804", Offset = "0x1489804", VA = "0x1489804")]
		public static void UPvr_SetCastingColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1489808", Offset = "0x1489808", VA = "0x1489808")]
		public static IntPtr UPvr_CreateLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x148980C", Offset = "0x148980C", VA = "0x148980C")]
		public static IntPtr UPvr_GetLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1489810", Offset = "0x1489810", VA = "0x1489810")]
		public static void UPvr_SetMonoMode(bool openMono)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1489818", Offset = "0x1489818", VA = "0x1489818")]
		public static void UPvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexDataPtr, ref IntPtr indexDataPtr)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public struct System
	{
		[Token(Token = "0x4000854")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x4000855")]
		public const string UnitySDKVersion = "2.8.10.4";

		[PreserveSig]
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x148B520", Offset = "0x148B520", VA = "0x148B520")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x148B5B0", Offset = "0x148B5B0", VA = "0x148B5B0")]
		private static extern IntPtr Pvr_GetSDKVersion();

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x148B624", Offset = "0x148B624", VA = "0x148B624")]
		public static extern int Pvr_GetHmdHardwareVersion();

		[PreserveSig]
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x148B698", Offset = "0x148B698", VA = "0x148B698")]
		public static extern IntPtr Pvr_GetHmdFirmwareVersion();

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x148B70C", Offset = "0x148B70C", VA = "0x148B70C")]
		public static extern IntPtr Pvr_GetHmdSerialNumber();

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x148B780", Offset = "0x148B780", VA = "0x148B780")]
		public static extern int PVR_GetHmdBatteryStatus();

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x148B7F4", Offset = "0x148B7F4", VA = "0x148B7F4")]
		public static extern float PVR_GetHmdBatteryTemperature();

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x148B864", Offset = "0x148B864", VA = "0x148B864")]
		public static extern int PVR_SetHmdAudioStatus(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x148B8E4", Offset = "0x148B8E4", VA = "0x148B8E4")]
		public static extern bool Pvr_GetEyeTrackingData(ref int leftEyePoseStatus, ref int rightEyePoseStatus, ref int combinedEyePoseStatus, ref float leftEyeGazePointX, ref float leftEyeGazePointY, ref float leftEyeGazePointZ, ref float rightEyeGazePointX, ref float rightEyeGazePointY, ref float rightEyeGazePointZ, ref float combinedEyeGazePointX, ref float combinedEyeGazePointY, ref float combinedEyeGazePointZ, ref float leftEyeGazeVectorX, ref float leftEyeGazeVectorY, ref float leftEyeGazeVectorZ, ref float rightEyeGazeVectorX, ref float rightEyeGazeVectorY, ref float rightEyeGazeVectorZ, ref float combinedEyeGazeVectorX, ref float combinedEyeGazeVectorY, ref float combinedEyeGazeVectorZ, ref float leftEyeOpenness, ref float rightEyeOpenness, ref float leftEyePupilDilation, ref float rightEyePupilDilation, ref float leftEyePositionGuideX, ref float leftEyePositionGuideY, ref float leftEyePositionGuideZ, ref float rightEyePositionGuideX, ref float rightEyePositionGuideY, ref float rightEyePositionGuideZ, ref float foveatedGazeDirectionX, ref float foveatedGazeDirectionY, ref float foveatedGazeDirectionZ, ref int foveatedGazeTrackingState);

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x148BAD4", Offset = "0x148BAD4", VA = "0x148BAD4")]
		public static extern bool Pvr_SetTrackingMode(int trackingMode);

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x148BB5C", Offset = "0x148BB5C", VA = "0x148BB5C")]
		public static extern int Pvr_GetTrackingMode();

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x148BBD0", Offset = "0x148BBD0", VA = "0x148BBD0")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x148BC44", Offset = "0x148BC44", VA = "0x148BC44")]
		public static extern void UnityEventData(long data);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x148BCC4", Offset = "0x148BCC4", VA = "0x148BCC4")]
		public static extern bool Pvr_EnableSinglePass(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x148BD4C", Offset = "0x148BD4C", VA = "0x148BD4C")]
		public static extern void Pvr_SetAntiAliasing(int antiAliasing);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x148BDCC", Offset = "0x148BDCC", VA = "0x148BDCC")]
		public static extern void Pvr_SinglePassBeforeForwardOpaque();

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x148BE3C", Offset = "0x148BE3C", VA = "0x148BE3C")]
		public static extern void Pvr_SetCurrentRenderTexture(uint textureId);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x148BEBC", Offset = "0x148BEBC", VA = "0x148BEBC")]
		public static extern bool Pvr_SetSinglePassDepthBufferWidthHeight(int width, int height);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x148BF54", Offset = "0x148BF54", VA = "0x148BF54")]
		public static extern int PVR_setPerformanceLevels(int cpuLevel, int gpuLevel);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x148BFE4", Offset = "0x148BFE4", VA = "0x148BFE4")]
		public static extern bool Pvr_SetIPD(float distance);

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x148C074", Offset = "0x148C074", VA = "0x148C074")]
		public static extern float Pvr_GetIPD();

		[PreserveSig]
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x148C0E4", Offset = "0x148C0E4", VA = "0x148C0E4")]
		public static extern bool Pvr_SetTrackingIPDEnabled(bool enable);

		[PreserveSig]
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x148C16C", Offset = "0x148C16C", VA = "0x148C16C")]
		public static extern bool Pvr_GetTrackingIPDEnabled();

		[PreserveSig]
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x148C1E8", Offset = "0x148C1E8", VA = "0x148C1E8")]
		public static extern bool Pvr_GetEyeTrackingAutoIPD(ref float autoIPD);

		[PreserveSig]
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1487E60", Offset = "0x1487E60", VA = "0x1487E60")]
		public static extern int PVR_GetHmdAudioStatus();

		[PreserveSig]
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x148C270", Offset = "0x148C270", VA = "0x148C270")]
		private static extern float Pvr_GetPredictedDisplayTime();

		[PreserveSig]
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x148C2E0", Offset = "0x148C2E0", VA = "0x148C2E0")]
		public static extern bool Pvr_SetExtraLatencyMode(int mode);

		[Token(Token = "0x6000794")]
		public static bool UPvr_CallStaticMethod<T>(ref T result, AndroidJavaClass jclass, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x148AB7C", Offset = "0x148AB7C", VA = "0x148AB7C")]
		public static bool UPvr_CallStaticMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		public static bool UPvr_CallMethod<T>(ref T result, AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x148C368", Offset = "0x148C368", VA = "0x148C368")]
		public static bool UPvr_CallMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x148C578", Offset = "0x148C578", VA = "0x148C578")]
		public static string UPvr_GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x148C60C", Offset = "0x148C60C", VA = "0x148C60C")]
		public static string UPvr_GetUnitySDKVersion()
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x148C654", Offset = "0x148C654", VA = "0x148C654")]
		public static string UPvr_GetDeviceMode()
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x148C65C", Offset = "0x148C65C", VA = "0x148C65C")]
		public static string UPvr_GetDeviceModel()
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x14870F8", Offset = "0x14870F8", VA = "0x14870F8")]
		public static string UPvr_GetDeviceSN()
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x148750C", Offset = "0x148750C", VA = "0x148750C")]
		public static AndroidJavaObject UPvr_GetCurrentActivity()
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x148C664", Offset = "0x148C664", VA = "0x148C664")]
		public static bool UPvr_SetMonoPresentation()
		{
			return default(bool);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x148C74C", Offset = "0x148C74C", VA = "0x148C74C")]
		public static bool UPvr_IsPresentationExisted()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x148C858", Offset = "0x148C858", VA = "0x148C858")]
		public static bool UPvr_GetMainActivityPauseStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x148C964", Offset = "0x148C964", VA = "0x148C964")]
		public static void UPvr_Sleep()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x148CA70", Offset = "0x148CA70", VA = "0x148CA70")]
		public static bool UPvr_StartHomeKeyReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x148CCF8", Offset = "0x148CCF8", VA = "0x148CCF8")]
		public static bool UPvr_StopHomeKeyReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x148CF38", Offset = "0x148CF38", VA = "0x148CF38")]
		public static void UPvr_StartVRModel()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x148D044", Offset = "0x148D044", VA = "0x148D044")]
		public static void UPvr_RemovePlatformLogo()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x148D150", Offset = "0x148D150", VA = "0x148D150")]
		public static void UPvr_ShowPlatformLogo()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x148D25C", Offset = "0x148D25C", VA = "0x148D25C")]
		public static bool UPvr_IsPicoActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x148D368", Offset = "0x148D368", VA = "0x148D368")]
		public static void UPvr_StopVRModel()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x148D474", Offset = "0x148D474", VA = "0x148D474")]
		public static string UPvr_GetCountryCode()
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x148D584", Offset = "0x148D584", VA = "0x148D584")]
		public static bool UPvr_SetIPD(float distance)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x148D9B4", Offset = "0x148D9B4", VA = "0x148D9B4")]
		public static float UPvr_GetIPD()
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x148DA74", Offset = "0x148DA74", VA = "0x148DA74")]
		public static bool UPvr_SetTrackingIPDEnabled(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x148DA7C", Offset = "0x148DA7C", VA = "0x148DA7C")]
		public static bool UPvr_GetTrackingIPDEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x148DA80", Offset = "0x148DA80", VA = "0x148DA80")]
		public static bool UPvr_GetEyeTrackingAutoIPD(ref float autoipd)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x148DA84", Offset = "0x148DA84", VA = "0x148DA84")]
		public static void UPvr_UnityEventData(long data)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x148DA88", Offset = "0x148DA88", VA = "0x148DA88")]
		public static long UPvr_GetEyeBufferData(int id)
		{
			return default(long);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x148DB04", Offset = "0x148DB04", VA = "0x148DB04")]
		public static bool UPvr_checkDevice(string packagename)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x148DC34", Offset = "0x148DC34", VA = "0x148DC34")]
		public static int UPvr_GetHmdHardwareVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x148DC38", Offset = "0x148DC38", VA = "0x148DC38")]
		public static string UPvr_GetHmdFirmwareVersion()
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x148DCCC", Offset = "0x148DCCC", VA = "0x148DCCC")]
		public static string UPvr_GetHmdSerialNumber()
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x148DD60", Offset = "0x148DD60", VA = "0x148DD60")]
		public static int UPvr_GetHmdBatteryStatus()
		{
			return default(int);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x148DD64", Offset = "0x148DD64", VA = "0x148DD64")]
		public static float UPvr_GetHmdBatteryTemperature()
		{
			return default(float);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x148DD68", Offset = "0x148DD68", VA = "0x148DD68")]
		public static int UPvr_SetHmdAudioStatus(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x148DD70", Offset = "0x148DD70", VA = "0x148DD70")]
		public static int UPvr_GetTrackingMode()
		{
			return default(int);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x148DD74", Offset = "0x148DD74", VA = "0x148DD74")]
		public static bool UPvr_setTrackingMode(int trackingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x148DD78", Offset = "0x148DD78", VA = "0x148DD78")]
		public static bool UPvr_getEyeTrackingData(ref EyeTrackingData trackingData)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x148DFE0", Offset = "0x148DFE0", VA = "0x148DFE0")]
		public static bool UPvr_getEyeTrackingGazeRay(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x148E20C", Offset = "0x148E20C", VA = "0x148E20C")]
		public static bool UPvr_getEyeTrackingGazeRayWorld(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x148E4DC", Offset = "0x148E4DC", VA = "0x148E4DC")]
		public static Vector3 UPvr_getEyeTrackingPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x148E84C", Offset = "0x148E84C", VA = "0x148E84C")]
		public static int UPvr_GetPhoneScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x148E950", Offset = "0x148E950", VA = "0x148E950")]
		public static void UPvr_SetPhoneScreenBrightness(int level)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x148EA8C", Offset = "0x148EA8C", VA = "0x148EA8C")]
		public static bool UPvr_IsPicoDefaultActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x148EDAC", Offset = "0x148EDAC", VA = "0x148EDAC")]
		public static bool UPvr_EnableSinglePass(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x148EDB4", Offset = "0x148EDB4", VA = "0x148EDB4")]
		public static void UPvr_SetAntiAliasing(int antiAliasing)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x148EDB8", Offset = "0x148EDB8", VA = "0x148EDB8")]
		public static void UPvr_SinglePassBeforeForwardOpaque()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x148EDBC", Offset = "0x148EDBC", VA = "0x148EDBC")]
		public static void UPvr_SetCurrentRenderTexture(uint textureId)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x148EDC0", Offset = "0x148EDC0", VA = "0x148EDC0")]
		public static bool UPvr_SetSinglePassDepthBufferWidthHeight(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x148EDC4", Offset = "0x148EDC4", VA = "0x148EDC4")]
		public static int UPVR_setPerformanceLevels(int cpuLevel, int gpuLevel)
		{
			return default(int);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x148EDC8", Offset = "0x148EDC8", VA = "0x148EDC8")]
		public static int UPvr_GetColorRes(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x148EFAC", Offset = "0x148EFAC", VA = "0x148EFAC")]
		public static int UPvr_GetConfigInt(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x148F190", Offset = "0x148F190", VA = "0x148F190")]
		public static string UPvr_GetConfigString(string name)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x148F37C", Offset = "0x148F37C", VA = "0x148F37C")]
		public static string UPvr_GetDrawableLocation(string name)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x148F568", Offset = "0x148F568", VA = "0x148F568")]
		public static int UPvr_GetTextSize(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x148F74C", Offset = "0x148F74C", VA = "0x148F74C")]
		public static string UPvr_GetLangString(string name)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x148F938", Offset = "0x148F938", VA = "0x148F938")]
		public static string UPvr_GetStringValue(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x148FB90", Offset = "0x148FB90", VA = "0x148FB90")]
		public static int UPvr_GetIntValue(string id, int type)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x148FDE0", Offset = "0x148FDE0", VA = "0x148FDE0")]
		public static float UPvr_GetFloatValue(string id)
		{
			return default(float);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x148FFC4", Offset = "0x148FFC4", VA = "0x148FFC4")]
		public static string UPvr_GetObjectOrArray(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x149021C", Offset = "0x149021C", VA = "0x149021C")]
		public static int UPvr_GetCharSpace(string id)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1490400", Offset = "0x1490400", VA = "0x1490400")]
		public static bool UPvr_SetExtraLatencyMode(ExtraLatencyMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1490404", Offset = "0x1490404", VA = "0x1490404")]
		public static float UPvr_GetPredictedDisplayTime()
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000F4")]
	public struct BoundarySystem
	{
		[Token(Token = "0x20001B6")]
		public enum BoundaryType
		{
			[Token(Token = "0x4000CB0")]
			OuterBoundary,
			[Token(Token = "0x4000CB1")]
			PlayArea
		}

		[Token(Token = "0x20001B7")]
		public struct BoundaryTestResult
		{
			[Token(Token = "0x4000CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool IsTriggering;

			[Token(Token = "0x4000CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float ClosestDistance;

			[Token(Token = "0x4000CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 ClosestPoint;

			[Token(Token = "0x4000CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 ClosestPointNormal;
		}

		[Token(Token = "0x20001B8")]
		public enum BoundaryTrackingNode
		{
			[Token(Token = "0x4000CB7")]
			HandLeft,
			[Token(Token = "0x4000CB8")]
			HandRight,
			[Token(Token = "0x4000CB9")]
			Head
		}

		[Token(Token = "0x20001B9")]
		public enum BoundaryTrackingState
		{
			[Token(Token = "0x4000CBB")]
			LostNoReason = 3,
			[Token(Token = "0x4000CBC")]
			LostCamera,
			[Token(Token = "0x4000CBD")]
			LostHighLight,
			[Token(Token = "0x4000CBE")]
			LostLowLight,
			[Token(Token = "0x4000CBF")]
			LostLowFeatureCount,
			[Token(Token = "0x4000CC0")]
			LostReLocation,
			[Token(Token = "0x4000CC1")]
			LostInitialization,
			[Token(Token = "0x4000CC2")]
			LostNoCamera,
			[Token(Token = "0x4000CC3")]
			LostNoIMU,
			[Token(Token = "0x4000CC4")]
			LostIMUJitter,
			[Token(Token = "0x4000CC5")]
			LostUnknown
		}

		[Token(Token = "0x4000856")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x147FA60", Offset = "0x147FA60", VA = "0x147FA60")]
		private static extern float Pvr_GetFloorHeight();

		[PreserveSig]
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x147FAD0", Offset = "0x147FAD0", VA = "0x147FAD0")]
		private static extern int Pvr_GetSeeThroughState();

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x147FB44", Offset = "0x147FB44", VA = "0x147FB44")]
		private static extern void Pvr_BoundarySetSTBackground(bool value);

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x147FBC4", Offset = "0x147FBC4", VA = "0x147FBC4")]
		private static extern int Pvr_GetTrackingState();

		[PreserveSig]
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x147FC38", Offset = "0x147FC38", VA = "0x147FC38")]
		private static extern bool Pvr_GetFrameRateLimit();

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x147FCB4", Offset = "0x147FCB4", VA = "0x147FCB4")]
		private static extern bool Pvr_IsBoundaryEnable();

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x147FD30", Offset = "0x147FD30", VA = "0x147FD30")]
		private static extern bool Pvr_BoundaryGetConfigured();

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x147FDAC", Offset = "0x147FDAC", VA = "0x147FDAC")]
		private static extern bool Pvr_BoundaryTestNode(int node, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x147FEB0", Offset = "0x147FEB0", VA = "0x147FEB0")]
		private static extern bool Pvr_BoundaryTestPoint(float x, float y, float z, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x147FFD8", Offset = "0x147FFD8", VA = "0x147FFD8")]
		private static extern int Pvr_BoundaryGetGeometry(out IntPtr handle, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1480064", Offset = "0x1480064", VA = "0x1480064")]
		private static extern int Pvr_BoundaryGetDimensions(ref float x, ref float y, ref float z, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x148010C", Offset = "0x148010C", VA = "0x148010C")]
		private static extern bool Pvr_BoundaryGetEnabled();

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1480188", Offset = "0x1480188", VA = "0x1480188")]
		private static extern void Pvr_BoundarySetVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1480208", Offset = "0x1480208", VA = "0x1480208")]
		private static extern bool Pvr_BoundaryGetVisible();

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1480284", Offset = "0x1480284", VA = "0x1480284")]
		private static extern bool Pvr_EnableLWRP(bool enable);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x148030C", Offset = "0x148030C", VA = "0x148030C")]
		private static extern bool Pvr_SetViewportSize(int w, int h);

		[PreserveSig]
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x14803A4", Offset = "0x14803A4", VA = "0x14803A4")]
		private static extern void Pvr_BoundarySetSeeThroughVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1480424", Offset = "0x1480424", VA = "0x1480424")]
		private static extern void PVR_SetCameraImageRect(int width, int height);

		[PreserveSig]
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x14804B4", Offset = "0x14804B4", VA = "0x14804B4")]
		private static extern void Pvr_SetGuardianSystemDisable(bool value);

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1480534", Offset = "0x1480534", VA = "0x1480534")]
		private static extern int Pvr_GetDialogState();

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x14805A8", Offset = "0x14805A8", VA = "0x14805A8")]
		public static float UPvr_GetFloorHeight()
		{
			return default(float);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x14805AC", Offset = "0x14805AC", VA = "0x14805AC")]
		public static int UPvr_GetSeeThroughState()
		{
			return default(int);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x14805B0", Offset = "0x14805B0", VA = "0x14805B0")]
		public static void UPvr_EnableSeeThroughManual(bool enable)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x14805B8", Offset = "0x14805B8", VA = "0x14805B8")]
		public static BoundaryTrackingState UPvr_GetTrackingState()
		{
			return default(BoundaryTrackingState);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x14805BC", Offset = "0x14805BC", VA = "0x14805BC")]
		public static bool UPvr_GetFrameRateLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x14805C0", Offset = "0x14805C0", VA = "0x14805C0")]
		public static bool UPvr_IsBoundaryEnable()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x14805C4", Offset = "0x14805C4", VA = "0x14805C4")]
		public static bool UPvr_BoundaryGetConfigured()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x14805C8", Offset = "0x14805C8", VA = "0x14805C8")]
		public static BoundaryTestResult UPvr_BoundaryTestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x148070C", Offset = "0x148070C", VA = "0x148070C")]
		public static BoundaryTestResult UPvr_BoundaryTestPoint(Vector3 point, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x148085C", Offset = "0x148085C", VA = "0x148085C")]
		public static Vector3[] UPvr_BoundaryGetGeometry(BoundaryType boundaryType)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1480A38", Offset = "0x1480A38", VA = "0x1480A38")]
		public static Vector3 UPvr_BoundaryGetDimensions(BoundaryType boundaryType)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1480A94", Offset = "0x1480A94", VA = "0x1480A94")]
		public static bool UPvr_BoundaryGetEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1480A98", Offset = "0x1480A98", VA = "0x1480A98")]
		public static void UPvr_BoundarySetVisible(bool value)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1480AA0", Offset = "0x1480AA0", VA = "0x1480AA0")]
		public static bool UPvr_BoundaryGetVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1480AA4", Offset = "0x1480AA4", VA = "0x1480AA4")]
		public static bool UPvr_EnableLWRP(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1480AAC", Offset = "0x1480AAC", VA = "0x1480AAC")]
		public static bool UPvr_SetViewportSize(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1480AB0", Offset = "0x1480AB0", VA = "0x1480AB0")]
		public static void UPvr_StartCameraFrame()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1480BF4", Offset = "0x1480BF4", VA = "0x1480BF4")]
		public static void UPvr_StopCameraFrame()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1480D38", Offset = "0x1480D38", VA = "0x1480D38")]
		public static void UPvr_BoundaryGetSeeThroughData(int cameraIndex, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1480F18", Offset = "0x1480F18", VA = "0x1480F18")]
		public static void UPvr_BoundarySetCameraImageRect(int width, int height)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1481050", Offset = "0x1481050", VA = "0x1481050")]
		public static void UPvr_BoundarySetSeeThroughVisible(bool value)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1481174", Offset = "0x1481174", VA = "0x1481174")]
		public static void UPvr_SetGuardianSystemDisable(bool value)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1481298", Offset = "0x1481298", VA = "0x1481298")]
		public static int UPvr_GetDialogState()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F5")]
	public struct PlatformSettings
	{
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1486F10", Offset = "0x1486F10", VA = "0x1486F10")]
		public static Pvr_UnitySDKPlatformSetting.simulationType UPvr_IsCurrentDeviceValid()
		{
			return default(Pvr_UnitySDKPlatformSetting.simulationType);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x148722C", Offset = "0x148722C", VA = "0x148722C")]
		public static bool UPvr_AppEntitlementCheck(string appid)
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1487594", Offset = "0x1487594", VA = "0x1487594")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D12A4", Offset = "0x6D12A4")]
		public static bool UPvr_KeyEntitlementCheck(string publicKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1487874", Offset = "0x1487874", VA = "0x1487874")]
		public static int UPvr_AppEntitlementCheckExtra(string appid)
		{
			return default(int);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1487B68", Offset = "0x1487B68", VA = "0x1487B68")]
		public static int UPvr_KeyEntitlementCheckExtra(string publicKey)
		{
			return default(int);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1487E5C", Offset = "0x1487E5C", VA = "0x1487E5C")]
		public static int UPvr_GetHmdAudioStatus()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F6")]
	public enum DeviceCommand
	{
		[Token(Token = "0x4000858")]
		SET_PICO_NEO_HMD_BRIGHTNESS = 12,
		[Token(Token = "0x4000859")]
		SET_PICO_NEO_HMD_SLEEPDELAY
	}
	[Token(Token = "0x20000F7")]
	public enum BrightnessLevel
	{
		[Token(Token = "0x400085B")]
		VR_BRIGHTNESS_LEVEL_MIN = 1,
		[Token(Token = "0x400085C")]
		VR_BRIGHTNESS_LEVEL_MAX = 100,
		[Token(Token = "0x400085D")]
		VR_BRIGHTNESS_LEVEL_DOWN = 1000,
		[Token(Token = "0x400085E")]
		VR_BRIGHTNESS_LEVEL_UP = 1001,
		[Token(Token = "0x400085F")]
		VR_BRIGHTNESS_LEVEL_SCREEN_OFF = -100
	}
	[Token(Token = "0x20000F8")]
	public struct VolumePowerBrightness
	{
		[Token(Token = "0x4000860")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AndroidJavaObject activity;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AndroidJavaClass javaSysActivityClass;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass batteryjavaVrActivityClass;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass volumejavaVrActivityClass;

		[PreserveSig]
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1490520", Offset = "0x1490520", VA = "0x1490520")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x14905B0", Offset = "0x14905B0", VA = "0x14905B0")]
		private static extern bool Pvr_IsHmdExist();

		[PreserveSig]
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x149062C", Offset = "0x149062C", VA = "0x149062C")]
		private static extern int Pvr_GetHmdScreenBrightness();

		[PreserveSig]
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x14906A0", Offset = "0x14906A0", VA = "0x14906A0")]
		private static extern bool Pvr_SetHmdScreenBrightness(int brightness);

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1490728", Offset = "0x1490728", VA = "0x1490728")]
		public static bool UPvr_IsHmdExist()
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x149072C", Offset = "0x149072C", VA = "0x149072C")]
		public static int UPvr_GetHmdScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1490730", Offset = "0x1490730", VA = "0x1490730")]
		public static bool UPvr_SetHmdScreenBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1490734", Offset = "0x1490734", VA = "0x1490734")]
		public static bool UPvr_SetCommonBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x14909BC", Offset = "0x14909BC", VA = "0x14909BC")]
		public static int UPvr_GetCommonBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1490BD8", Offset = "0x1490BD8", VA = "0x1490BD8")]
		public static int[] UPvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1490DD8", Offset = "0x1490DD8", VA = "0x1490DD8")]
		public static void UPvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1491008", Offset = "0x1491008", VA = "0x1491008")]
		public static bool UPvr_SetDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x149115C", Offset = "0x149115C", VA = "0x149115C")]
		public static string UPvr_GetDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x149128C", Offset = "0x149128C", VA = "0x149128C")]
		public static bool UPvr_InitBatteryClass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x149148C", Offset = "0x149148C", VA = "0x149148C")]
		public static bool UPvr_InitBatteryVolClass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1491754", Offset = "0x1491754", VA = "0x1491754")]
		public static bool UPvr_StartBatteryReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1491988", Offset = "0x1491988", VA = "0x1491988")]
		public static bool UPvr_StopBatteryReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x149076C", Offset = "0x149076C", VA = "0x149076C")]
		public static bool UPvr_SetBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x14909DC", Offset = "0x14909DC", VA = "0x14909DC")]
		public static int UPvr_GetCurrentBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1490BDC", Offset = "0x1490BDC", VA = "0x1490BDC")]
		public static int[] Pvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1490DDC", Offset = "0x1490DDC", VA = "0x1490DDC")]
		public static void Pvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1491B74", Offset = "0x1491B74", VA = "0x1491B74")]
		public static bool UPvr_StartAudioReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1491DA8", Offset = "0x1491DA8", VA = "0x1491DA8")]
		public static bool UPvr_StopAudioReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1491F94", Offset = "0x1491F94", VA = "0x1491F94")]
		public static int UPvr_GetMaxVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x149217C", Offset = "0x149217C", VA = "0x149217C")]
		public static int UPvr_GetCurrentVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1492364", Offset = "0x1492364", VA = "0x1492364")]
		public static bool UPvr_VolumeUp()
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x149253C", Offset = "0x149253C", VA = "0x149253C")]
		public static bool UPvr_VolumeDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1492714", Offset = "0x1492714", VA = "0x1492714")]
		public static bool UPvr_SetVolumeNum(int volume)
		{
			return default(bool);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x14928E4", Offset = "0x14928E4", VA = "0x14928E4")]
		public static bool UPvr_SetAudio(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x14928EC", Offset = "0x14928EC", VA = "0x14928EC")]
		public static bool UPvr_SetBattery(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1491160", Offset = "0x1491160", VA = "0x1491160")]
		private static string getDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x149100C", Offset = "0x149100C", VA = "0x149100C")]
		private static bool setDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}
	}
}
namespace BoundarySystem_Ext
{
	[Token(Token = "0x20000F9")]
	internal static class Pvr_BoundaryAPI
	{
		[Token(Token = "0x4000865")]
		private const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x998B5C", Offset = "0x998B5C", VA = "0x998B5C")]
		public static extern void Pvr_StartSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x998BCC", Offset = "0x998BCC", VA = "0x998BCC")]
		public static extern void Pvr_ShutdownSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x998C3C", Offset = "0x998C3C", VA = "0x998C3C")]
		private static extern int Pvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x998D20", Offset = "0x998D20", VA = "0x998D20")]
		private static extern IntPtr Pvr_GetCameraData_Ext();

		[PreserveSig]
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x998D94", Offset = "0x998D94", VA = "0x998D94")]
		public static extern void Pvr_ResetVrModebyForce();

		[PreserveSig]
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x998E04", Offset = "0x998E04", VA = "0x998E04")]
		private static extern bool Pvr_ResumeBoundaryForSTS();

		[PreserveSig]
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x998E80", Offset = "0x998E80", VA = "0x998E80")]
		private static extern void Pvr_PauseBoundaryForSTS();

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x998EF0", Offset = "0x998EF0", VA = "0x998EF0")]
		public static int UPvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x998EFC", Offset = "0x998EFC", VA = "0x998EFC")]
		public static IntPtr UPvr_GetCameraData_Ext()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x998F38", Offset = "0x998F38", VA = "0x998F38")]
		public static bool UPvr_ResumeBoundaryForSTS()
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x998F3C", Offset = "0x998F3C", VA = "0x998F3C")]
		public static void UPvr_PauseBoundaryForSTS()
		{
		}

		[Token(Token = "0x6000830")]
		public static IntPtr StructToIntPtr<T>(T info)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000831")]
		public static T IntPtrToStruct<T>(IntPtr info)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20000FA")]
	internal static class Pvr_SafeAreaAlgoAPI
	{
		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x6CDB14", Offset = "0x6CDB14")]
		public delegate void SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr);

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x6CDB28", Offset = "0x6CDB28")]
		public delegate void SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr);

		[Token(Token = "0x20001BC")]
		public struct GSAPoint3i
		{
			[Token(Token = "0x4000CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000CC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000CC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x20001BD")]
		public struct GSALine
		{
			[Token(Token = "0x4000CC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr pointArray;

			[Token(Token = "0x4000CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int pointCount;
		}

		[Token(Token = "0x20001BE")]
		public struct GSALineCollection
		{
			[Token(Token = "0x4000CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr lineArray;

			[Token(Token = "0x4000CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int lineCount;
		}

		[Token(Token = "0x20001BF")]
		public struct GSALegalData
		{
			[Token(Token = "0x4000CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int overMaxRange;

			[Token(Token = "0x4000CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int includeBigGrap;

			[Token(Token = "0x4000CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int bigGapNum;

			[Token(Token = "0x4000CD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int centerOut;

			[Token(Token = "0x4000CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int removeNarrow;

			[Token(Token = "0x4000CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int overMaxRange_more;

			[Token(Token = "0x4000CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int validShrinkArea;
		}

		[Token(Token = "0x20001C0")]
		public struct GSARect
		{
			[Token(Token = "0x4000CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GSAPoint3i leftup;

			[Token(Token = "0x4000CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public GSAPoint3i leftdown;

			[Token(Token = "0x4000CD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GSAPoint3i rightup;

			[Token(Token = "0x4000CD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public GSAPoint3i rightdown;

			[Token(Token = "0x4000CD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GSAPoint3i center;

			[Token(Token = "0x4000CD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x4000CDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x4000CDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int isLegal;

			[Token(Token = "0x4000CDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GSALegalData legalData;
		}

		[Token(Token = "0x4000866")]
		private const string LibFileName = "SafetyArea";

		[PreserveSig]
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x9991D4", Offset = "0x9991D4", VA = "0x9991D4")]
		private static extern int GSAInit(int width, int height);

		[PreserveSig]
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x999264", Offset = "0x999264", VA = "0x999264")]
		private static extern int GSAShutDown();

		[PreserveSig]
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x9992D8", Offset = "0x9992D8", VA = "0x9992D8")]
		private static extern int GSASetCallback(SafeAreaCallback cb);

		[PreserveSig]
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x99935C", Offset = "0x99935C", VA = "0x99935C")]
		private static extern int GSASetCallbackShrink(SafeAreaCallbackShrink cb);

		[PreserveSig]
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x9993E0", Offset = "0x9993E0", VA = "0x9993E0")]
		private static extern int GSAUpDateData(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x999460", Offset = "0x999460", VA = "0x999460")]
		private static extern int GSASetConfigFilePath(IntPtr configPath);

		[PreserveSig]
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x9994E0", Offset = "0x9994E0", VA = "0x9994E0")]
		private static extern bool GSAGetClosedAreaUpdateFlag();

		[PreserveSig]
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x99955C", Offset = "0x99955C", VA = "0x99955C")]
		private static extern int GSALoadSafetyArea(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x9995DC", Offset = "0x9995DC", VA = "0x9995DC")]
		private static extern double GSABoundaryDetector(ref GSAPoint3i pointPtr);

		[PreserveSig]
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x99965C", Offset = "0x99965C", VA = "0x99965C")]
		private static extern int GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x9996EC", Offset = "0x9996EC", VA = "0x9996EC")]
		private static extern double GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir);

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x999794", Offset = "0x999794", VA = "0x999794")]
		public static int Pvr_GSAInit(int width, int height)
		{
			return default(int);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x999798", Offset = "0x999798", VA = "0x999798")]
		public static int Pvr_GSASetCallback(SafeAreaCallback cb)
		{
			return default(int);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x99979C", Offset = "0x99979C", VA = "0x99979C")]
		public static int Pvr_GSASetCallbackShrink(SafeAreaCallbackShrink cb)
		{
			return default(int);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x9997A0", Offset = "0x9997A0", VA = "0x9997A0")]
		public static int Pvr_GSAUpDateData(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x9997A4", Offset = "0x9997A4", VA = "0x9997A4")]
		public static bool Pvr_GSAGetClosedAreaUpdateFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x9997A8", Offset = "0x9997A8", VA = "0x9997A8")]
		public static int Pvr_GSASetConfigFilePath(string configPath)
		{
			return default(int);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x999830", Offset = "0x999830", VA = "0x999830")]
		public static int Pvr_GSALoadSafetyArea(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x999834", Offset = "0x999834", VA = "0x999834")]
		public static double Pvr_GSABoundaryDetector(ref GSAPoint3i point)
		{
			return default(double);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x999838", Offset = "0x999838", VA = "0x999838")]
		public static int Pvr_GSAShutDown()
		{
			return default(int);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x99983C", Offset = "0x99983C", VA = "0x99983C")]
		public static int Pvr_GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea)
		{
			return default(int);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x999844", Offset = "0x999844", VA = "0x999844")]
		public static double Pvr_GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20000FB")]
	public class Pvr_BoundarySystem
	{
		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_BoundarySystem instance;

		[Token(Token = "0x4000868")]
		public const int CameraImageWidth = 1280;

		[Token(Token = "0x4000869")]
		public const int CameraImageHeight = 400;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr CameraFramePtr;

		[Token(Token = "0x170000A0")]
		public static Pvr_BoundarySystem Instance
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x998F40", Offset = "0x998F40", VA = "0x998F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x999008", Offset = "0x999008", VA = "0x999008")]
		public void OpenBoundary()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x99900C", Offset = "0x99900C", VA = "0x99900C")]
		public void CloseBoundary()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x999010", Offset = "0x999010", VA = "0x999010")]
		public void Reset6Dof()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x999014", Offset = "0x999014", VA = "0x999014")]
		public float[] GetControllerFixedPoseData(int hand)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x998FBC", Offset = "0x998FBC", VA = "0x998FBC")]
		public Pvr_BoundarySystem()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class Pvr_SafeAreaAlgoModule
	{
		[Token(Token = "0x20001C1")]
		public struct ExtraInfo
		{
			[Token(Token = "0x4000CDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool overMaxRange;

			[Token(Token = "0x4000CDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeBigGap;

			[Token(Token = "0x4000CDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int bigGapNum;

			[Token(Token = "0x4000CE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool centerOut;

			[Token(Token = "0x4000CE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool removeNarrow;

			[Token(Token = "0x4000CE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool overMaxRange_more;

			[Token(Token = "0x4000CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int validShrinkArea;
		}

		[Token(Token = "0x20001C2")]
		public struct BoundaryPlayerArea
		{
			[Token(Token = "0x4000CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lowerleft;

			[Token(Token = "0x4000CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 upperleft;

			[Token(Token = "0x4000CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 upperRight;

			[Token(Token = "0x4000CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 lowerRight;

			[Token(Token = "0x4000CE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 center;

			[Token(Token = "0x4000CE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x4000CEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x4000CEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isLegal;

			[Token(Token = "0x4000CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ExtraInfo extraInfo;
		}

		[Token(Token = "0x20001C3")]
		public delegate void BoundarySystemCallback(BoundaryPlayerArea playAreaInfo, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x20001C4")]
		public delegate void BoundarySystemCallbackShrink(List<Vector3> rectPoints, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_SafeAreaAlgoModule instance;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoundarySystemCallback boundarySystemCallback;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BoundarySystemCallbackShrink boundarySystemCallbackShrink;

		[Token(Token = "0x170000A1")]
		public static Pvr_SafeAreaAlgoModule Instance
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x99AC8C", Offset = "0x99AC8C", VA = "0x99AC8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x99AD14", Offset = "0x99AD14", VA = "0x99AD14")]
		public void RegisterCallBack(BoundarySystemCallback callback)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x99AD1C", Offset = "0x99AD1C", VA = "0x99AD1C")]
		public void RegisterCallBackShrink(BoundarySystemCallbackShrink callback)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x99AD24", Offset = "0x99AD24", VA = "0x99AD24")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x99AE44", Offset = "0x99AE44", VA = "0x99AE44")]
		public bool CommitNewLineData(bool isFistLine, Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x99B0FC", Offset = "0x99B0FC", VA = "0x99B0FC")]
		public bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x99B180", Offset = "0x99B180", VA = "0x99B180")]
		public double QueryDistanceOfPoint(Vector3 point)
		{
			return default(double);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x99B210", Offset = "0x99B210", VA = "0x99B210")]
		public double QueryDistanceOfPoint(Vector3 point, bool isPlayArea, ref Vector3 closestPoint, ref Vector3 normalDir)
		{
			return default(double);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x999EBC", Offset = "0x999EBC", VA = "0x999EBC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6D12DC", Offset = "0x6D12DC")]
		private static void _SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x99A5D4", Offset = "0x99A5D4", VA = "0x99A5D4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6D1340", Offset = "0x6D1340")]
		private static void _SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x99AD0C", Offset = "0x99AD0C", VA = "0x99AD0C")]
		public Pvr_SafeAreaAlgoModule()
		{
		}
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x20000FD")]
	public enum FaceType : uint
	{
		[Token(Token = "0x400086F")]
		TRIANGLES,
		[Token(Token = "0x4000870")]
		QUADS
	}
	[Token(Token = "0x20000FE")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x4000872")]
		ABSORPTION,
		[Token(Token = "0x4000873")]
		TRANSMISSION,
		[Token(Token = "0x4000874")]
		SCATTERING
	}
	[Token(Token = "0x20000FF")]
	public struct MeshGroup
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace OVR
{
	[Token(Token = "0x2000100")]
	public class TestScript : MonoBehaviour
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectorNoteAttribute", RVA = "0x6CEAC4", Offset = "0x6CEAC4")]
		public SoundFXRef testSound1;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundFXRef testSound2;

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x9D97BC", Offset = "0x9D97BC", VA = "0x9D97BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x9D97C0", Offset = "0x9D97C0", VA = "0x9D97C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x9D9880", Offset = "0x9D9880", VA = "0x9D9880")]
		public TestScript()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class AmbienceEmitter : MonoBehaviour
	{
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFXRef[] ambientSounds;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoActivate;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEB10", Offset = "0x6CEB10")]
		public bool autoRetrigger;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6CEB48", Offset = "0x6CEB48")]
		public Vector2 randomRetriggerDelaySecs;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEB6C", Offset = "0x6CEB6C")]
		public Transform[] playPositions;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool activated;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int playingIdx;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float fadeTime;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int lastPosIdx;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xC5361C", Offset = "0xC5361C", VA = "0xC5361C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xC537A0", Offset = "0xC537A0", VA = "0xC537A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xC53980", Offset = "0xC53980", VA = "0xC53980")]
		public void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xC53800", Offset = "0xC53800", VA = "0xC53800")]
		public void Play()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xC53A44", Offset = "0xC53A44", VA = "0xC53A44")]
		public void EnableEmitter(bool enable)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xC53BBC", Offset = "0xC53BBC", VA = "0xC53BBC")]
		public AmbienceEmitter()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public enum PreloadSounds
	{
		[Token(Token = "0x4000886")]
		Default,
		[Token(Token = "0x4000887")]
		Preload,
		[Token(Token = "0x4000888")]
		ManualPreload
	}
	[Token(Token = "0x2000103")]
	public enum Fade
	{
		[Token(Token = "0x400088A")]
		In,
		[Token(Token = "0x400088B")]
		Out
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	public class SoundGroup
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFX[] soundList;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEBA4", Offset = "0x6CEBA4")]
		public int maxPlayingSounds;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PreloadSounds preloadAudio;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float volumeOverride;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public int playingSoundCount;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x9D969C", Offset = "0x9D969C", VA = "0x9D969C")]
		public SoundGroup(string name)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x9D9730", Offset = "0x9D9730", VA = "0x9D9730")]
		public SoundGroup()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x9D739C", Offset = "0x9D739C", VA = "0x9D739C")]
		public void IncrementPlayCount()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x9D76D8", Offset = "0x9D76D8", VA = "0x9D76D8")]
		public void DecrementPlayCount()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x9D8C50", Offset = "0x9D8C50", VA = "0x9D8C50")]
		public bool CanPlaySound()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000105")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x20001C5")]
		public enum Fade
		{
			[Token(Token = "0x4000CEE")]
			In,
			[Token(Token = "0x4000CEF")]
			Out
		}

		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB3C", Offset = "0x6CDB3C")]
		private sealed class <>c__DisplayClass77_0
		{
			[Token(Token = "0x4000CF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoundPriority priority;

			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x9D6E00", Offset = "0x9D6E00", VA = "0x9D6E00")]
			public <>c__DisplayClass77_0()
			{
			}

			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x9D6E08", Offset = "0x9D6E08", VA = "0x9D6E08")]
			internal bool <FindFreeEmitter>b__0(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB4C", Offset = "0x6CDB4C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<SoundEmitter> <>9__77_1;

			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x9D6D68", Offset = "0x9D6D68", VA = "0x9D6D68")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x9D6D70", Offset = "0x9D6D70", VA = "0x9D6D70")]
			internal bool <FindFreeEmitter>b__77_1(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEBD0", Offset = "0x6CEBD0")]
		public bool makePersistent;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEC08", Offset = "0x6CEC08")]
		public bool enableSpatializedAudio;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEC40", Offset = "0x6CEC40")]
		public bool enableSpatializedFastOverride;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEC78", Offset = "0x6CEC78")]
		public AudioMixer audioMixer;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CECB0", Offset = "0x6CECB0")]
		public AudioMixerGroup defaultMixerGroup;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CECE8", Offset = "0x6CECE8")]
		public AudioMixerGroup reservedMixerGroup;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CED20", Offset = "0x6CED20")]
		public AudioMixerGroup voiceChatMixerGroup;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CED58", Offset = "0x6CED58")]
		public bool verboseLogging;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CED90", Offset = "0x6CED90")]
		public int maxSoundEmitters;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEDC8", Offset = "0x6CEDC8")]
		public float volumeSoundFX;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEE00", Offset = "0x6CEE00")]
		public float soundFxFadeSecs;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float audioMinFallOffDistance;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float audioMaxFallOffDistance;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SoundGroup[] soundGroupings;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, SoundFX> soundFXCache;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager theAudioManager;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FastList<string> names;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] defaultSound;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SoundFX nullSound;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool hideWarnings;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float audioMaxFallOffDistanceSqr;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SoundEmitter[] soundEmitters;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FastList<SoundEmitter> playingEmitters;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FastList<SoundEmitter> nextFreeEmitters;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MixerSnapshot currentSnapshot;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject soundEmitterParent;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform staticListenerPosition;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool showPlayingEmitterCount;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private static bool forceShowEmitterCount;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool soundEnabled;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly AnimationCurve defaultReverbZoneMix;

		[Token(Token = "0x170000A2")]
		public static bool enableSpatialization
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xC53C7C", Offset = "0xC53C7C", VA = "0xC53C7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public static AudioManager Instance
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xC53D5C", Offset = "0xC53D5C", VA = "0xC53D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public static float NearFallOff
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xC53DC4", Offset = "0xC53DC4", VA = "0xC53DC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A5")]
		public static float FarFallOff
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xC53E38", Offset = "0xC53E38", VA = "0xC53E38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A6")]
		public static AudioMixerGroup EmitterGroup
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xC53EAC", Offset = "0xC53EAC", VA = "0xC53EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public static AudioMixerGroup ReservedGroup
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xC53F20", Offset = "0xC53F20", VA = "0xC53F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public static AudioMixerGroup VoipGroup
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xC53F94", Offset = "0xC53F94", VA = "0xC53F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public static bool SoundEnabled
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xC55D10", Offset = "0xC55D10", VA = "0xC55D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xC54008", Offset = "0xC54008", VA = "0xC54008")]
		private void Awake()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xC54230", Offset = "0xC54230", VA = "0xC54230")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xC5400C", Offset = "0xC5400C", VA = "0xC5400C")]
		private void Init()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xC54E80", Offset = "0xC54E80", VA = "0xC54E80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xC54388", Offset = "0xC54388", VA = "0xC54388")]
		private void RebuildSoundFXCache()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xC554AC", Offset = "0xC554AC", VA = "0xC554AC")]
		public static SoundFX FindSoundFX(string name, bool rebuildCache = false)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xC5562C", Offset = "0xC5562C", VA = "0xC5562C")]
		private static bool FindAudioManager()
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xC557C8", Offset = "0xC557C8", VA = "0xC557C8")]
		public static GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xC558C8", Offset = "0xC558C8", VA = "0xC558C8")]
		public static string NameMinusGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xC55958", Offset = "0xC55958", VA = "0xC55958")]
		public static string[] GetSoundFXNames(string currentValue, out int currentIdx)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xC55D78", Offset = "0xC55D78", VA = "0xC55D78")]
		private static int CalculateMaxEmittersSize()
		{
			return default(int);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xC55DF0", Offset = "0xC55DF0", VA = "0xC55DF0")]
		private static bool ValidateEmitterIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xC547D4", Offset = "0xC547D4", VA = "0xC547D4")]
		private void InitializeSoundSystem()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xC54E84", Offset = "0xC54E84", VA = "0xC54E84")]
		private void UpdateFreeEmitters()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xC55F34", Offset = "0xC55F34", VA = "0xC55F34")]
		private string Fmt(int count)
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xC56038", Offset = "0xC56038", VA = "0xC56038")]
		private string FmtFree(int count)
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xC56140", Offset = "0xC56140", VA = "0xC56140")]
		private void OnPreSceneLoad()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xC55E68", Offset = "0xC55E68", VA = "0xC55E68")]
		private void ResetFreeEmitters()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xC56274", Offset = "0xC56274", VA = "0xC56274")]
		public static void FadeOutSoundChannel(int channel, float delaySecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xC56330", Offset = "0xC56330", VA = "0xC56330")]
		public static bool StopSound(int idx, bool fadeOut = true, bool stopReserved = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xC56450", Offset = "0xC56450", VA = "0xC56450")]
		public static void FadeInSound(int idx, float fadeTime, float volume)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xC53990", Offset = "0xC53990", VA = "0xC53990")]
		public static void FadeInSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xC53B08", Offset = "0xC53B08", VA = "0xC53B08")]
		public static void FadeOutSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xC5650C", Offset = "0xC5650C", VA = "0xC5650C")]
		public static void StopAllSounds(bool fadeOut, bool stopReserved = false)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xC565D8", Offset = "0xC565D8", VA = "0xC565D8")]
		public void MuteAllSounds(bool mute, bool muteReserved = false)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xC5666C", Offset = "0xC5666C", VA = "0xC5666C")]
		public void UnMuteAllSounds(bool unmute, bool unmuteReserved = false)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xC56730", Offset = "0xC56730", VA = "0xC56730")]
		public static float GetEmitterEndTime(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xC567D4", Offset = "0xC567D4", VA = "0xC567D4")]
		public static float SetEmitterTime(int idx, float time)
		{
			return default(float);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xC56890", Offset = "0xC56890", VA = "0xC56890")]
		public static int PlaySound(AudioClip clip, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitchVariance = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xC57380", Offset = "0xC57380", VA = "0xC57380")]
		private static int FindFreeEmitter(EmitterChannel src, SoundPriority priority)
		{
			return default(int);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xC57A3C", Offset = "0xC57A3C", VA = "0xC57A3C")]
		public static int PlaySound(SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xC57C1C", Offset = "0xC57C1C", VA = "0xC57C1C")]
		public static int PlaySoundAt(Vector3 position, SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xC58758", Offset = "0xC58758", VA = "0xC58758")]
		public static int PlayRandomSoundAt(Vector3 position, AudioClip[] clips, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xC56A98", Offset = "0xC56A98", VA = "0xC56A98")]
		public static int PlaySoundAt(Vector3 position, AudioClip clip, float volume = 1f, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xC58878", Offset = "0xC58878", VA = "0xC58878")]
		public static void SetOnFinished(int emitterIdx, Action onFinished)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xC5894C", Offset = "0xC5894C", VA = "0xC5894C")]
		public static void SetOnFinished(int emitterIdx, Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xC58A3C", Offset = "0xC58A3C", VA = "0xC58A3C")]
		public static void AttachSoundToParent(int idx, Transform parent)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xC58CFC", Offset = "0xC58CFC", VA = "0xC58CFC")]
		public static void DetachSoundFromParent(int idx)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xC58E44", Offset = "0xC58E44", VA = "0xC58E44")]
		public static void DetachSoundsFromParent(SoundEmitter[] emitters, bool stopSounds = true)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xC58F6C", Offset = "0xC58F6C", VA = "0xC58F6C")]
		public static void SetEmitterMixerGroup(int idx, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xC59090", Offset = "0xC59090", VA = "0xC59090")]
		public static MixerSnapshot GetActiveSnapshot()
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xC59168", Offset = "0xC59168", VA = "0xC59168")]
		public static void SetCurrentSnapshot(MixerSnapshot mixerSnapshot)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xC5929C", Offset = "0xC5929C", VA = "0xC5929C")]
		public static void BlendWithCurrentSnapshot(MixerSnapshot blendSnapshot, float weight, float blendTime = 0f)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xC59688", Offset = "0xC59688", VA = "0xC59688")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public enum EmitterChannel
	{
		[Token(Token = "0x40008B3")]
		None = -1,
		[Token(Token = "0x40008B4")]
		Reserved,
		[Token(Token = "0x40008B5")]
		Any
	}
	[Serializable]
	[Token(Token = "0x2000107")]
	public class MixerSnapshot
	{
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixerSnapshot snapshot;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float transitionTime;

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x9D6F04", Offset = "0x9D6F04", VA = "0x9D6F04")]
		public MixerSnapshot()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minDefaultVal;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxDefaultVal;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x9D6EA8", Offset = "0x9D6EA8", VA = "0x9D6EA8")]
		public MinMaxAttribute(float minDefaultVal, float maxDefaultVal, float min, float max)
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class SoundEmitter : MonoBehaviour
	{
		[Token(Token = "0x20001C8")]
		public enum FadeState
		{
			[Token(Token = "0x4000CF4")]
			Null,
			[Token(Token = "0x4000CF5")]
			FadingIn,
			[Token(Token = "0x4000CF6")]
			FadingOut,
			[Token(Token = "0x4000CF7")]
			Ducking
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB5C", Offset = "0x6CDB5C")]
		private sealed class <DelayedSyncTo>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000CFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000CFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundEmitter other;

			[Token(Token = "0x4000CFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float fadeTime;

			[Token(Token = "0x4000CFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float toVolume;

			[Token(Token = "0x1700014D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C46")]
				[Address(RVA = "0x9D7FB8", Offset = "0x9D7FB8", VA = "0x9D7FB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C48")]
				[Address(RVA = "0x9D8020", Offset = "0x9D8020", VA = "0x9D8020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x9D7A70", Offset = "0x9D7A70", VA = "0x9D7A70")]
			[DebuggerHidden]
			public <DelayedSyncTo>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x9D7EC8", Offset = "0x9D7EC8", VA = "0x9D7EC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x9D7ECC", Offset = "0x9D7ECC", VA = "0x9D7ECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x9D7FC0", Offset = "0x9D7FC0", VA = "0x9D7FC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB6C", Offset = "0x6CDB6C")]
		private sealed class <FadeSoundChannelTo>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000D01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toVolume;

			[Token(Token = "0x4000D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeTime;

			[Token(Token = "0x4000D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <start>5__2;

			[Token(Token = "0x4000D04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <end>5__3;

			[Token(Token = "0x4000D05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000D06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__5;

			[Token(Token = "0x1700014F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C4C")]
				[Address(RVA = "0x9D846C", Offset = "0x9D846C", VA = "0x9D846C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000150")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C4E")]
				[Address(RVA = "0x9D84D4", Offset = "0x9D84D4", VA = "0x9D84D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x9D7E58", Offset = "0x9D7E58", VA = "0x9D7E58")]
			[DebuggerHidden]
			public <FadeSoundChannelTo>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x9D8300", Offset = "0x9D8300", VA = "0x9D8300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x9D8304", Offset = "0x9D8304", VA = "0x9D8304", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x9D8474", Offset = "0x9D8474", VA = "0x9D8474", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB7C", Offset = "0x6CDB7C")]
		private sealed class <FadeSoundChannel>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySecs;

			[Token(Token = "0x4000D0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Fade fadeType;

			[Token(Token = "0x4000D0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float defaultVolume;

			[Token(Token = "0x4000D0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000D0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float fadeTime;

			[Token(Token = "0x4000D0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <start>5__2;

			[Token(Token = "0x4000D0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <end>5__3;

			[Token(Token = "0x4000D10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <restartPlay>5__4;

			[Token(Token = "0x4000D11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <startTime>5__5;

			[Token(Token = "0x4000D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsedTime>5__6;

			[Token(Token = "0x17000151")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C52")]
				[Address(RVA = "0x9D8290", Offset = "0x9D8290", VA = "0x9D8290", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000152")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C54")]
				[Address(RVA = "0x9D82F8", Offset = "0x9D82F8", VA = "0x9D82F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x9D7E84", Offset = "0x9D7E84", VA = "0x9D7E84")]
			[DebuggerHidden]
			public <FadeSoundChannel>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x9D8028", Offset = "0x9D8028", VA = "0x9D8028", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x9D802C", Offset = "0x9D802C", VA = "0x9D802C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x9D8298", Offset = "0x9D8298", VA = "0x9D8298", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmitterChannel channel;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSpatialization;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeState state;

		[NonSerialized]
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource;

		[NonSerialized]
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundPriority priority;

		[NonSerialized]
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ONSPAudioSource osp;

		[NonSerialized]
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float endPlayTime;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lastParentTransform;

		[NonSerialized]
		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float defaultVolume;

		[NonSerialized]
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Transform defaultParent;

		[NonSerialized]
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int originalIdx;

		[NonSerialized]
		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action onFinished;

		[NonSerialized]
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Action<object> onFinishedObject;

		[NonSerialized]
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public object onFinishedParam;

		[NonSerialized]
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public SoundGroup playingSoundGroup;

		[Token(Token = "0x170000AA")]
		public float volume
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x9D6FA4", Offset = "0x9D6FA4", VA = "0x9D6FA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x9D6FC0", Offset = "0x9D6FC0", VA = "0x9D6FC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float pitch
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x9D6FDC", Offset = "0x9D6FDC", VA = "0x9D6FDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x9D6FF8", Offset = "0x9D6FF8", VA = "0x9D6FF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public AudioClip clip
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x9D7014", Offset = "0x9D7014", VA = "0x9D7014")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x9D7030", Offset = "0x9D7030", VA = "0x9D7030")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float time
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x9D704C", Offset = "0x9D704C", VA = "0x9D704C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x9D7068", Offset = "0x9D7068", VA = "0x9D7068")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float length
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x9D7084", Offset = "0x9D7084", VA = "0x9D7084")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AF")]
		public bool loop
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x9D713C", Offset = "0x9D713C", VA = "0x9D713C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x9D7158", Offset = "0x9D7158", VA = "0x9D7158")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool mute
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x9D7178", Offset = "0x9D7178", VA = "0x9D7178")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x9D7194", Offset = "0x9D7194", VA = "0x9D7194")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x9D71B4", Offset = "0x9D71B4", VA = "0x9D71B4")]
			get
			{
				return default(AudioVelocityUpdateMode);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x9D71D0", Offset = "0x9D71D0", VA = "0x9D71D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public bool isPlaying
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x9D71EC", Offset = "0x9D71EC", VA = "0x9D71EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x9D7208", Offset = "0x9D7208", VA = "0x9D7208")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x9D7388", Offset = "0x9D7388", VA = "0x9D7388")]
		public void SetPlayingSoundGroup(SoundGroup soundGroup)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x9D742C", Offset = "0x9D742C", VA = "0x9D742C")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x9D7434", Offset = "0x9D7434", VA = "0x9D7434")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x9D743C", Offset = "0x9D743C", VA = "0x9D743C")]
		public void SetChannel(int _channel)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x9D7444", Offset = "0x9D7444", VA = "0x9D7444")]
		public void SetDefaultParent(Transform parent)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x9D744C", Offset = "0x9D744C", VA = "0x9D744C")]
		public void SetAudioMixer(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x9D74F4", Offset = "0x9D74F4", VA = "0x9D74F4")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x9D7560", Offset = "0x9D7560", VA = "0x9D7560")]
		public void Play()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x9D75C0", Offset = "0x9D75C0", VA = "0x9D75C0")]
		public void Pause()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x9D75F8", Offset = "0x9D75F8", VA = "0x9D75F8")]
		public void Stop()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x9D7768", Offset = "0x9D7768", VA = "0x9D7768")]
		private int GetSampleTime()
		{
			return default(int);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x9D77C0", Offset = "0x9D77C0", VA = "0x9D77C0")]
		public void ParentTo(Transform parent)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x9D78BC", Offset = "0x9D78BC", VA = "0x9D78BC")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x9D7974", Offset = "0x9D7974", VA = "0x9D7974")]
		public void ResetParent(Transform parent)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x9D79B4", Offset = "0x9D79B4", VA = "0x9D79B4")]
		public void SyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x9D79E0", Offset = "0x9D79E0", VA = "0x9D79E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D13A4", Offset = "0x6D13A4")]
		private IEnumerator DelayedSyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x9D7A9C", Offset = "0x9D7A9C", VA = "0x9D7A9C")]
		public void FadeTo(float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x9D7B88", Offset = "0x9D7B88", VA = "0x9D7B88")]
		public void FadeIn(float fadeTime, float defaultVolume)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x9D7CAC", Offset = "0x9D7CAC", VA = "0x9D7CAC")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x9D7D24", Offset = "0x9D7D24", VA = "0x9D7D24")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x9D7DBC", Offset = "0x9D7DBC", VA = "0x9D7DBC")]
		public void FadeOutDelayed(float delayedSecs, float fadeTime)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x9D7B04", Offset = "0x9D7B04", VA = "0x9D7B04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D1408", Offset = "0x6D1408")]
		private IEnumerator FadeSoundChannelTo(float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x9D7C04", Offset = "0x9D7C04", VA = "0x9D7C04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D146C", Offset = "0x6D146C")]
		private IEnumerator FadeSoundChannel(float delaySecs, float fadeTime, Fade fadeType, float defaultVolume)
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x9D7EB0", Offset = "0x9D7EB0", VA = "0x9D7EB0")]
		public SoundEmitter()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public enum SoundFXNext
	{
		[Token(Token = "0x40008CC")]
		Random,
		[Token(Token = "0x40008CD")]
		Sequential
	}
	[Token(Token = "0x200010B")]
	public enum FreqHint
	{
		[Token(Token = "0x40008CF")]
		None,
		[Token(Token = "0x40008D0")]
		Wide,
		[Token(Token = "0x40008D1")]
		Narrow
	}
	[Token(Token = "0x200010C")]
	public enum SoundPriority
	{
		[Token(Token = "0x40008D3")]
		VeryLow = -2,
		[Token(Token = "0x40008D4")]
		Low,
		[Token(Token = "0x40008D5")]
		Default,
		[Token(Token = "0x40008D6")]
		High,
		[Token(Token = "0x40008D7")]
		VeryHigh
	}
	[Serializable]
	[Token(Token = "0x200010D")]
	public class OSPProps
	{
		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEEE8", Offset = "0x6CEEE8")]
		public bool enableSpatialization;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEF20", Offset = "0x6CEF20")]
		public bool useFastOverride;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEF58", Offset = "0x6CEF58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEF58", Offset = "0x6CEF58")]
		public float gain;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEFAC", Offset = "0x6CEFAC")]
		public bool enableInvSquare;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEFE4", Offset = "0x6CEFE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEFE4", Offset = "0x6CEFE4")]
		public float volumetric;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF03C", Offset = "0x6CF03C")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6CF03C", Offset = "0x6CF03C")]
		public Vector2 invSquareFalloff;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x9D6F14", Offset = "0x9D6F14", VA = "0x9D6F14")]
		public OSPProps()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010E")]
	public class SoundFX
	{
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF09C", Offset = "0x6CF09C")]
		public string name;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF0D4", Offset = "0x6CF0D4")]
		public SoundFXNext playback;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF10C", Offset = "0x6CF10C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF10C", Offset = "0x6CF10C")]
		public float volume;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF160", Offset = "0x6CF160")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6CF160", Offset = "0x6CF160")]
		public Vector2 pitchVariance;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF1BC", Offset = "0x6CF1BC")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6CF1BC", Offset = "0x6CF1BC")]
		public Vector2 falloffDistance;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF21C", Offset = "0x6CF21C")]
		public AudioRolloffMode falloffCurve;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF254", Offset = "0x6CF254")]
		public AnimationCurve volumeFalloffCurve;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF28C", Offset = "0x6CF28C")]
		public AnimationCurve reverbZoneMix;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF2C4", Offset = "0x6CF2C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF2C4", Offset = "0x6CF2C4")]
		public float spread;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF31C", Offset = "0x6CF31C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF31C", Offset = "0x6CF31C")]
		public float pctChanceToPlay;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF370", Offset = "0x6CF370")]
		public SoundPriority priority;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF3A8", Offset = "0x6CF3A8")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6CF3A8", Offset = "0x6CF3A8")]
		public Vector2 delay;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF404", Offset = "0x6CF404")]
		public bool looping;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OSPProps ospProps;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF43C", Offset = "0x6CF43C")]
		public AudioClip[] soundClips;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool visibilityToggle;

		[NonSerialized]
		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SoundGroup soundGroup;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int lastIdx;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int playingIdx;

		[Token(Token = "0x170000B3")]
		public int Length
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x9D89C4", Offset = "0x9D89C4", VA = "0x9D89C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B4")]
		public bool IsValid
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x9D89E0", Offset = "0x9D89E0", VA = "0x9D89E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		public SoundGroup Group
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x9D8A84", Offset = "0x9D8A84", VA = "0x9D8A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x9D8A8C", Offset = "0x9D8A8C", VA = "0x9D8A8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public float MaxFalloffDistSquared
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x9D8A94", Offset = "0x9D8A94", VA = "0x9D8A94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B7")]
		public float GroupVolumeOverride
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x9D8AA0", Offset = "0x9D8AA0", VA = "0x9D8AA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x9D84DC", Offset = "0x9D84DC", VA = "0x9D84DC")]
		public SoundFX()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x9D8AB8", Offset = "0x9D8AB8", VA = "0x9D8AB8")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x9D8B88", Offset = "0x9D8B88", VA = "0x9D8B88")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroup defaultMixerGroup)
		{
			return null;
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x9D8C28", Offset = "0x9D8C28", VA = "0x9D8C28")]
		public bool ReachedGroupPlayLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x9D8C70", Offset = "0x9D8C70", VA = "0x9D8C70")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x9D8D6C", Offset = "0x9D8D6C", VA = "0x9D8D6C")]
		public float GetPitch()
		{
			return default(float);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x9D8D78", Offset = "0x9D8D78", VA = "0x9D8D78")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x9D8E58", Offset = "0x9D8E58", VA = "0x9D8E58")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x9D8F70", Offset = "0x9D8F70", VA = "0x9D8F70")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x9D9000", Offset = "0x9D9000", VA = "0x9D9000")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x9D9098", Offset = "0x9D9098", VA = "0x9D9098")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x9D9128", Offset = "0x9D9128", VA = "0x9D9128")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x9D91B8", Offset = "0x9D91B8", VA = "0x9D91B8")]
		public void DetachFromParent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class SoundFXRef
	{
		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundFXName;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SoundFX soundFXCached;

		[Token(Token = "0x170000B8")]
		public SoundFX soundFX
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x9D9234", Offset = "0x9D9234", VA = "0x9D9234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public string name
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x9D9330", Offset = "0x9D9330", VA = "0x9D9330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x9D9338", Offset = "0x9D9338", VA = "0x9D9338")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public int Length
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x9D9340", Offset = "0x9D9340", VA = "0x9D9340")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BB")]
		public bool IsValid
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x9D9384", Offset = "0x9D9384", VA = "0x9D9384")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x9D9264", Offset = "0x9D9264", VA = "0x9D9264")]
		private void Init()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x9D93BC", Offset = "0x9D93BC", VA = "0x9D93BC")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x9D93F4", Offset = "0x9D93F4", VA = "0x9D93F4")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x9D9434", Offset = "0x9D9434", VA = "0x9D9434")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x9D947C", Offset = "0x9D947C", VA = "0x9D947C")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volume = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x9D94FC", Offset = "0x9D94FC", VA = "0x9D94FC")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x9D953C", Offset = "0x9D953C", VA = "0x9D953C")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x9D958C", Offset = "0x9D958C", VA = "0x9D958C")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x9D95C4", Offset = "0x9D95C4", VA = "0x9D95C4")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x9D9604", Offset = "0x9D9604", VA = "0x9D9604")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x9D963C", Offset = "0x9D963C", VA = "0x9D963C")]
		public SoundFXRef()
		{
		}
	}
}
namespace NLayer
{
	[Token(Token = "0x2000110")]
	public enum MpegVersion
	{
		[Token(Token = "0x40008F5")]
		Unknown = 0,
		[Token(Token = "0x40008F6")]
		Version1 = 10,
		[Token(Token = "0x40008F7")]
		Version2 = 20,
		[Token(Token = "0x40008F8")]
		Version25 = 25
	}
	[Token(Token = "0x2000111")]
	public enum MpegLayer
	{
		[Token(Token = "0x40008FA")]
		Unknown,
		[Token(Token = "0x40008FB")]
		LayerI,
		[Token(Token = "0x40008FC")]
		LayerII,
		[Token(Token = "0x40008FD")]
		LayerIII
	}
	[Token(Token = "0x2000112")]
	public enum MpegChannelMode
	{
		[Token(Token = "0x40008FF")]
		Stereo,
		[Token(Token = "0x4000900")]
		JointStereo,
		[Token(Token = "0x4000901")]
		DualChannel,
		[Token(Token = "0x4000902")]
		Mono
	}
	[Token(Token = "0x2000113")]
	public enum StereoMode
	{
		[Token(Token = "0x4000904")]
		Both,
		[Token(Token = "0x4000905")]
		LeftOnly,
		[Token(Token = "0x4000906")]
		RightOnly,
		[Token(Token = "0x4000907")]
		DownmixToMono
	}
	[Token(Token = "0x2000114")]
	public interface IMpegFrame
	{
		[Token(Token = "0x170000BC")]
		int SampleRate
		{
			[Token(Token = "0x60008EB")]
			get;
		}

		[Token(Token = "0x170000BD")]
		int SampleRateIndex
		{
			[Token(Token = "0x60008EC")]
			get;
		}

		[Token(Token = "0x170000BE")]
		int FrameLength
		{
			[Token(Token = "0x60008ED")]
			get;
		}

		[Token(Token = "0x170000BF")]
		int BitRate
		{
			[Token(Token = "0x60008EE")]
			get;
		}

		[Token(Token = "0x170000C0")]
		MpegVersion Version
		{
			[Token(Token = "0x60008EF")]
			get;
		}

		[Token(Token = "0x170000C1")]
		MpegLayer Layer
		{
			[Token(Token = "0x60008F0")]
			get;
		}

		[Token(Token = "0x170000C2")]
		MpegChannelMode ChannelMode
		{
			[Token(Token = "0x60008F1")]
			get;
		}

		[Token(Token = "0x170000C3")]
		int ChannelModeExtension
		{
			[Token(Token = "0x60008F2")]
			get;
		}

		[Token(Token = "0x170000C4")]
		int SampleCount
		{
			[Token(Token = "0x60008F3")]
			get;
		}

		[Token(Token = "0x170000C5")]
		int BitRateIndex
		{
			[Token(Token = "0x60008F4")]
			get;
		}

		[Token(Token = "0x170000C6")]
		bool IsCopyrighted
		{
			[Token(Token = "0x60008F5")]
			get;
		}

		[Token(Token = "0x170000C7")]
		bool HasCrc
		{
			[Token(Token = "0x60008F6")]
			get;
		}

		[Token(Token = "0x170000C8")]
		bool IsCorrupted
		{
			[Token(Token = "0x60008F7")]
			get;
		}

		[Token(Token = "0x60008F8")]
		void Reset();

		[Token(Token = "0x60008F9")]
		int ReadBits(int bitCount);
	}
	[Token(Token = "0x2000115")]
	public class MpegFile : IDisposable
	{
		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stream _stream;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _closeStream;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _eofFound;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MpegStreamReader _reader;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MpegFrameDecoder _decoder;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _seekLock;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long _position;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] _readBuf;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _readBufLen;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _readBufOfs;

		[Token(Token = "0x170000C9")]
		public int SampleRate
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0xC420AC", Offset = "0xC420AC", VA = "0xC420AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CA")]
		public int Channels
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xC420C4", Offset = "0xC420C4", VA = "0xC420C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		public bool CanSeek
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0xC4210C", Offset = "0xC4210C", VA = "0xC4210C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		public long Length
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0xC42128", Offset = "0xC42128", VA = "0xC42128")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000CD")]
		public TimeSpan Duration
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0xC42194", Offset = "0xC42194", VA = "0xC42194")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000CE")]
		public long Position
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0xC4226C", Offset = "0xC4226C", VA = "0xC4226C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000904")]
			[Address(RVA = "0xC42274", Offset = "0xC42274", VA = "0xC42274")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public TimeSpan Time
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0xC42798", Offset = "0xC42798", VA = "0xC42798")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000906")]
			[Address(RVA = "0xC42868", Offset = "0xC42868", VA = "0xC42868")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public StereoMode StereoMode
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0xC42A70", Offset = "0xC42A70", VA = "0xC42A70")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0xC42A8C", Offset = "0xC42A8C", VA = "0xC42A8C")]
			set
			{
			}
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xC41E14", Offset = "0xC41E14", VA = "0xC41E14")]
		public MpegFile(string fileName)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xC41F60", Offset = "0xC41F60", VA = "0xC41F60")]
		public MpegFile(Stream stream)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xC41EC8", Offset = "0xC41EC8", VA = "0xC41EC8")]
		private void Init(Stream stream, bool closeStream)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xC42070", Offset = "0xC42070", VA = "0xC42070", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xC42928", Offset = "0xC42928", VA = "0xC42928")]
		public void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xC42AA8", Offset = "0xC42AA8", VA = "0xC42AA8")]
		public int ReadSamples(byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xC42EE4", Offset = "0xC42EE4", VA = "0xC42EE4")]
		public int ReadSamples(float[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xC42B78", Offset = "0xC42B78", VA = "0xC42B78")]
		private int ReadSamplesImpl(Array buffer, int index, int count)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000116")]
	public class MpegFrameDecoder
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LayerIDecoder _layerIDecoder;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LayerIIDecoder _layerIIDecoder;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LayerIIIDecoder _layerIIIDecoder;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _eqFactors;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] _ch0;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _ch1;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF474", Offset = "0x6CF474")]
		private StereoMode <StereoMode>k__BackingField;

		[Token(Token = "0x170000D1")]
		public StereoMode StereoMode
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xC42FBC", Offset = "0xC42FBC", VA = "0xC42FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D14D0", Offset = "0x6D14D0")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0xC42FC4", Offset = "0xC42FC4", VA = "0xC42FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D14E0", Offset = "0x6D14E0")]
			set
			{
			}
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xC41FFC", Offset = "0xC41FFC", VA = "0xC41FFC")]
		public MpegFrameDecoder()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xC42940", Offset = "0xC42940", VA = "0xC42940")]
		public void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xC42FCC", Offset = "0xC42FCC", VA = "0xC42FCC")]
		public int DecodeFrame(IMpegFrame frame, byte[] dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xC425A4", Offset = "0xC425A4", VA = "0xC425A4")]
		public int DecodeFrame(IMpegFrame frame, float[] dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xC43210", Offset = "0xC43210", VA = "0xC43210")]
		private int DecodeFrameImpl(IMpegFrame frame, Array dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xC42544", Offset = "0xC42544", VA = "0xC42544")]
		public void Reset()
		{
		}
	}
}
namespace NLayer.Decoder
{
	[Token(Token = "0x2000117")]
	internal class BitReservoir
	{
		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _buf;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _start;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _end;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _bitsLeft;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _bitsRead;

		[Token(Token = "0x170000D2")]
		public int BitsAvailable
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x10846DC", Offset = "0x10846DC", VA = "0x10846DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D3")]
		public long BitsRead
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1084724", Offset = "0x1084724", VA = "0x1084724")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1083D38", Offset = "0x1083D38", VA = "0x1083D38")]
		private static int GetSlots(IMpegFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1084038", Offset = "0x1084038", VA = "0x1084038")]
		public bool AddBits(IMpegFrame frame, int overlap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1084234", Offset = "0x1084234", VA = "0x1084234")]
		public int GetBits(int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x10845E0", Offset = "0x10845E0", VA = "0x10845E0")]
		public int Get1Bit()
		{
			return default(int);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x10842F0", Offset = "0x10842F0", VA = "0x10842F0")]
		public int TryPeekBits(int count, out int readCount)
		{
			return default(int);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x10844E4", Offset = "0x10844E4", VA = "0x10844E4")]
		public void SkipBits(int count)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x108472C", Offset = "0x108472C", VA = "0x108472C")]
		public void RewindBits(int count)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x108479C", Offset = "0x108479C", VA = "0x108479C")]
		public void FlushBits()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x10847B0", Offset = "0x10847B0", VA = "0x10847B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x10847C0", Offset = "0x10847C0", VA = "0x10847C0")]
		public BitReservoir()
		{
		}
	}
	[Token(Token = "0x2000118")]
	internal abstract class FrameBase
	{
		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _totalAllocation;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF484", Offset = "0x6CF484")]
		private long <Offset>k__BackingField;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF494", Offset = "0x6CF494")]
		private int <Length>k__BackingField;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MpegStreamReader _reader;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _savedBuffer;

		[Token(Token = "0x170000D4")]
		internal static int TotalAllocation
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1084828", Offset = "0x1084828", VA = "0x1084828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D5")]
		internal long Offset
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1084898", Offset = "0x1084898", VA = "0x1084898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D14F0", Offset = "0x6D14F0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x10848A0", Offset = "0x10848A0", VA = "0x10848A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1500", Offset = "0x6D1500")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		internal int Length
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x10848A8", Offset = "0x10848A8", VA = "0x10848A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1510", Offset = "0x6D1510")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x10848B0", Offset = "0x10848B0", VA = "0x10848B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1520", Offset = "0x6D1520")]
			set
			{
			}
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x10848B8", Offset = "0x10848B8", VA = "0x10848B8")]
		protected FrameBase()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x10848C0", Offset = "0x10848C0", VA = "0x10848C0")]
		internal bool Validate(long offset, MpegStreamReader reader)
		{
			return default(bool);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1084908", Offset = "0x1084908", VA = "0x1084908")]
		protected int Read(int offset, byte[] buffer)
		{
			return default(int);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x1084924", Offset = "0x1084924", VA = "0x1084924")]
		protected int Read(int offset, byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x10849C0", Offset = "0x10849C0", VA = "0x10849C0")]
		protected int ReadByte(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x600092B")]
		protected abstract int Validate();

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x1084A9C", Offset = "0x1084A9C", VA = "0x1084A9C")]
		internal void SaveBuffer()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1084B4C", Offset = "0x1084B4C", VA = "0x1084B4C")]
		internal void ClearBuffer()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1084BC8", Offset = "0x1084BC8", VA = "0x1084BC8", Slot = "5")]
		internal virtual void Parse()
		{
		}
	}
	[Token(Token = "0x2000119")]
	internal class Huffman
	{
		[Token(Token = "0x20001CC")]
		private class HuffmanListNode
		{
			[Token(Token = "0x4000D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal byte Value;

			[Token(Token = "0x4000D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int Length;

			[Token(Token = "0x4000D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int Bits;

			[Token(Token = "0x4000D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int Mask;

			[Token(Token = "0x4000D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal HuffmanListNode Next;

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x10862E8", Offset = "0x10862E8", VA = "0x10862E8")]
			public HuffmanListNode()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB8C", Offset = "0x6CDB8C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000D18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<HuffmanListNode> <>9__12_0;

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x108635C", Offset = "0x108635C", VA = "0x108635C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x1086364", Offset = "0x1086364", VA = "0x1086364")]
			internal int <BuildLinkedList>b__12_0(HuffmanListNode i1, HuffmanListNode i2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[][,] _codeTables;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] _floatLookup;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static HuffmanListNode[] _llCache;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int[] _llCacheMaxBits;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[] LIN_BITS;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1084BD0", Offset = "0x1084BD0", VA = "0x1084BD0")]
		static Huffman()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1085380", Offset = "0x1085380", VA = "0x1085380")]
		internal static void Decode(BitReservoir br, int table, out float x, out float y)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x10856F4", Offset = "0x10856F4", VA = "0x10856F4")]
		internal static void Decode(BitReservoir br, int table, out float x, out float y, out float v, out float w)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x10855F4", Offset = "0x10855F4", VA = "0x10855F4")]
		private static byte DecodeSymbol(BitReservoir br, int table)
		{
			return default(byte);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1085A24", Offset = "0x1085A24", VA = "0x1085A24")]
		private static HuffmanListNode GetNode(int table, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1085C38", Offset = "0x1085C38", VA = "0x1085C38")]
		private static HuffmanListNode InitTable(byte[,] tree, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1085E7C", Offset = "0x1085E7C", VA = "0x1085E7C")]
		private static int FindPreviousNode(byte[,] tree, int idx, out int bit)
		{
			return default(int);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1085FD8", Offset = "0x1085FD8", VA = "0x1085FD8")]
		private static HuffmanListNode BuildLinkedList(List<byte> values, List<int> lengthList, List<int> codeList, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x10862F0", Offset = "0x10862F0", VA = "0x10862F0")]
		public Huffman()
		{
		}
	}
	[Token(Token = "0x200011A")]
	internal class ID3Frame : FrameBase
	{
		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _version;

		[Token(Token = "0x170000D7")]
		internal int Version
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x1086620", Offset = "0x1086620", VA = "0x1086620")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x108638C", Offset = "0x108638C", VA = "0x108638C")]
		internal static ID3Frame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x108645C", Offset = "0x108645C", VA = "0x108645C")]
		private ID3Frame()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x10864C4", Offset = "0x10864C4", VA = "0x10864C4", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1086610", Offset = "0x1086610", VA = "0x1086610", Slot = "5")]
		internal override void Parse()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x108661C", Offset = "0x108661C", VA = "0x108661C")]
		private void ParseV1(int offset)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1086618", Offset = "0x1086618", VA = "0x1086618")]
		private void ParseV1Enh()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1086614", Offset = "0x1086614", VA = "0x1086614")]
		private void ParseV2()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1086630", Offset = "0x1086630", VA = "0x1086630")]
		internal void Merge(ID3Frame newFrame)
		{
		}
	}
	[Token(Token = "0x200011B")]
	internal abstract class LayerDecoderBase
	{
		[Token(Token = "0x4000929")]
		protected const int SBLIMIT = 32;

		[Token(Token = "0x400092A")]
		private const float INV_SQRT_2 = 0.70710677f;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] DEWINDOW_TABLE;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float[] SYNTH_COS64_TABLE;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<float[]> _synBuf;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> _bufOffset;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] _eq;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4A4", Offset = "0x6CF4A4")]
		private StereoMode <StereoMode>k__BackingField;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] ippuv;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] ei32;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] eo32;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] oi32;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] oo32;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] ei16;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] eo16;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] oi16;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] oo16;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] ei8;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] tmp8;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] oi8;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] oo8;

		[Token(Token = "0x170000D8")]
		internal StereoMode StereoMode
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x10867CC", Offset = "0x10867CC", VA = "0x10867CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1530", Offset = "0x6D1530")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x10867D4", Offset = "0x10867D4", VA = "0x10867D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1540", Offset = "0x6D1540")]
			set
			{
			}
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1086634", Offset = "0x1086634", VA = "0x1086634")]
		internal LayerDecoderBase()
		{
		}

		[Token(Token = "0x6000943")]
		internal abstract int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1);

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x10867B4", Offset = "0x10867B4", VA = "0x10867B4")]
		internal void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x10867DC", Offset = "0x10867DC", VA = "0x10867DC", Slot = "5")]
		internal virtual void ResetForSeek()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x108684C", Offset = "0x108684C", VA = "0x108684C")]
		protected void InversePolyPhase(int channel, float[] data)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1086928", Offset = "0x1086928", VA = "0x1086928")]
		private void GetBufAndOffset(int channel, out float[] synBuf, out int k)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1086A8C", Offset = "0x1086A8C", VA = "0x1086A8C")]
		private void DCT32(float[] _in, float[] _out, int k)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x10870FC", Offset = "0x10870FC", VA = "0x10870FC")]
		private void DCT16(float[] _in, float[] _out)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x10877E8", Offset = "0x10877E8", VA = "0x10877E8")]
		private void DCT8(float[] _in, float[] _out)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1086D04", Offset = "0x1086D04", VA = "0x1086D04")]
		private void BuildUVec(float[] u_vec, float[] cur_synbuf, int k)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1086E78", Offset = "0x1086E78", VA = "0x1086E78")]
		private void DewindowOutput(float[] u_vec, float[] samples)
		{
		}
	}
	[Token(Token = "0x200011C")]
	internal class LayerIDecoder : LayerIIDecoderBase
	{
		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] _rateTable;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _allocLookupTable;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x10880C8", Offset = "0x10880C8", VA = "0x10880C8")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1088468", Offset = "0x1088468", VA = "0x1088468")]
		internal LayerIDecoder()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x10888BC", Offset = "0x10888BC", VA = "0x10888BC", Slot = "6")]
		protected override int[] GetRateTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1088924", Offset = "0x1088924", VA = "0x1088924", Slot = "7")]
		protected override void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels)
		{
		}
	}
	[Token(Token = "0x200011D")]
	internal class LayerIIDecoder : LayerIIDecoderBase
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][] _rateLookupTable;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _allocLookupTable;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1088A24", Offset = "0x1088A24", VA = "0x1088A24")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1088AE8", Offset = "0x1088AE8", VA = "0x1088AE8")]
		private static int[] SelectTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1088F6C", Offset = "0x1088F6C", VA = "0x1088F6C")]
		internal LayerIIDecoder()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1089008", Offset = "0x1089008", VA = "0x1089008", Slot = "6")]
		protected override int[] GetRateTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x108906C", Offset = "0x108906C", VA = "0x108906C", Slot = "7")]
		protected override void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels)
		{
		}
	}
	[Token(Token = "0x200011E")]
	internal abstract class LayerIIDecoderBase : LayerDecoderBase
	{
		[Token(Token = "0x4000942")]
		protected const int SSLIMIT = 12;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] _groupedC;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] _groupedD;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly float[] _C;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly float[] _D;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly float[] _denormalMultiplier;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _channels;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _jsbound;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _granuleCount;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[][] _allocLookupTable;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int[][] _scfsi;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[][] _samples;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[][][] _scalefac;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] _polyPhaseBuf;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int[][] _allocation;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1088180", Offset = "0x1088180", VA = "0x1088180")]
		protected static bool GetCRC(MpegFrame frame, int[] rateTable, int[][] allocLookupTable, bool readScfsiBits, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1088504", Offset = "0x1088504", VA = "0x1088504")]
		protected LayerIIDecoderBase(int[][] allocLookupTable, int granuleCount)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x108965C", Offset = "0x108965C", VA = "0x108965C", Slot = "4")]
		internal override int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1)
		{
			return default(int);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x10897D8", Offset = "0x10897D8", VA = "0x10897D8")]
		private void InitFrame(IMpegFrame frame)
		{
		}

		[Token(Token = "0x600095F")]
		protected abstract int[] GetRateTable(IMpegFrame frame);

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1089938", Offset = "0x1089938", VA = "0x1089938")]
		private void ReadAllocation(IMpegFrame frame, int[] rateTable)
		{
		}

		[Token(Token = "0x6000961")]
		protected abstract void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels);

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1089C90", Offset = "0x1089C90", VA = "0x1089C90")]
		private void ReadScaleFactors(IMpegFrame frame)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x108A3F0", Offset = "0x108A3F0", VA = "0x108A3F0")]
		private void ReadSamples(IMpegFrame frame)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x108A840", Offset = "0x108A840", VA = "0x108A840")]
		private int DecodeSamples(float[] ch0, float[] ch1)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200011F")]
	internal sealed class LayerIIIDecoder : LayerDecoderBase
	{
		[Token(Token = "0x20001CE")]
		private class HybridMDCT
		{
			[Token(Token = "0x4000D1A")]
			private const float PI = (float)Math.PI;

			[Token(Token = "0x4000D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static float[][] _swin;

			[Token(Token = "0x4000D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static float[] icos72_table;

			[Token(Token = "0x4000D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<float[]> _prevBlock;

			[Token(Token = "0x4000D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<float[]> _nextBlock;

			[Token(Token = "0x4000D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float[] _imdctTemp;

			[Token(Token = "0x4000D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float[] _imdctResult;

			[Token(Token = "0x4000D21")]
			private const float sqrt32 = 0.8660254f;

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x1093F7C", Offset = "0x1093F7C", VA = "0x1093F7C")]
			static HybridMDCT()
			{
			}

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x108BD6C", Offset = "0x108BD6C", VA = "0x108BD6C")]
			internal HybridMDCT()
			{
			}

			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x1092398", Offset = "0x1092398", VA = "0x1092398")]
			internal void Reset()
			{
			}

			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x1094590", Offset = "0x1094590", VA = "0x1094590")]
			private void GetPrevBlock(int channel, out float[] prevBlock, out float[] nextBlock)
			{
			}

			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x10920D4", Offset = "0x10920D4", VA = "0x10920D4")]
			internal void Apply(float[] fsIn, int channel, int blockType, bool doMixed)
			{
			}

			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x1094704", Offset = "0x1094704", VA = "0x1094704")]
			private void LongImpl(float[] fsIn, int sbStart, int sbLimit, float[] nextblck, int blockType)
			{
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x1094BF8", Offset = "0x1094BF8", VA = "0x1094BF8")]
			private static void LongIMDCT(float[] invec, float[] outvec)
			{
			}

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x109575C", Offset = "0x109575C", VA = "0x109575C")]
			private static float ICOS72_A(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x10956BC", Offset = "0x10956BC", VA = "0x10956BC")]
			private static float ICOS36_A(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x109528C", Offset = "0x109528C", VA = "0x109528C")]
			private static void imdct_9pt(float[] invec, float[] outvec)
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x109490C", Offset = "0x109490C", VA = "0x109490C")]
			private void ShortImpl(float[] fsIn, int sbStart, float[] nextblck)
			{
			}

			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x10957F4", Offset = "0x10957F4", VA = "0x10957F4")]
			private static void ShortIMDCT(float[] invec, int inIdx, float[] outvec)
			{
			}
		}

		[Token(Token = "0x4000951")]
		private const int SSLIMIT = 18;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HybridMDCT _hybrid;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BitReservoir _bitRes;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _channels;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _privBits;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _mainDataBegin;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[][] _scfsi;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[][] _part23Length;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int[][] _bigValues;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float[][] _globalGain;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[][] _scalefacCompress;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool[][] _blockSplitFlag;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool[][] _mixedBlockFlag;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int[][] _blockType;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int[][][] _tableSelect;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float[][][] _subblockGain;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int[][] _regionAddress1;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int[][] _regionAddress2;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int[][] _preflag;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float[][] _scalefacScale;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int[][] _count1TableSelect;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] GAIN_TAB;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int[] _sfBandIndexL;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int[] _sfBandIndexS;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private byte[] _cbLookupL;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private byte[] _cbLookupS;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private byte[] _cbwLookupS;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int _cbLookupSR;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _sfBandIndexLTable;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[][] _sfBandIndexSTable;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int[][][] _scalefac;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[][] _slen;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[][][] _sfbBlockCntTab;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float[][] _samples;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int[] PRETAB;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly float[] POW2_TAB;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly float[][] _isRatio;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly float[][][] _lsfRatio;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float[] _reorderBuf;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly float[] _scs;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly float[] _sca;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float[] _polyPhase;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x108AEA8", Offset = "0x108AEA8", VA = "0x108AEA8")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x108AF70", Offset = "0x108AF70", VA = "0x108AF70")]
		internal LayerIIIDecoder()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x108BE28", Offset = "0x108BE28", VA = "0x108BE28", Slot = "4")]
		internal override int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1)
		{
			return default(int);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1092354", Offset = "0x1092354", VA = "0x1092354", Slot = "5")]
		internal override void ResetForSeek()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x108C49C", Offset = "0x108C49C", VA = "0x108C49C")]
		private void ReadSideInfo(IMpegFrame frame)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x108EA80", Offset = "0x108EA80", VA = "0x108EA80")]
		private void PrepTables(IMpegFrame frame)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x108F188", Offset = "0x108F188", VA = "0x108F188")]
		private int ReadScalefactors(int gr, int ch)
		{
			return default(int);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1090108", Offset = "0x1090108", VA = "0x1090108")]
		private int ReadLsfScalefactors(int gr, int ch, int chanModeExt)
		{
			return default(int);
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1090B74", Offset = "0x1090B74", VA = "0x1090B74")]
		private void ReadSamples(int sfBits, int gr, int ch)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1092400", Offset = "0x1092400", VA = "0x1092400")]
		private float Dequantize(int idx, float val, int gr, int ch)
		{
			return default(float);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x10914B4", Offset = "0x10914B4", VA = "0x10914B4")]
		private void Stereo(MpegChannelMode channelMode, int chanModeExt, int gr, bool lsf)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1092C7C", Offset = "0x1092C7C", VA = "0x1092C7C")]
		private void ApplyIStereo(int i, int sb, int isPos)
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1092A94", Offset = "0x1092A94", VA = "0x1092A94")]
		private void ApplyLsfIStereo(int i, int sb, int isPos, int scalefacCompress)
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x10928A4", Offset = "0x10928A4", VA = "0x10928A4")]
		private void ApplyMidSide(int i, int sb)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x10929E8", Offset = "0x10929E8", VA = "0x10929E8")]
		private void ApplyFullStereo(int i, int sb)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1091DC4", Offset = "0x1091DC4", VA = "0x1091DC4")]
		private void Reorder(float[] buf, bool mixedBlock)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1091EEC", Offset = "0x1091EEC", VA = "0x1091EEC")]
		private void AntiAlias(float[] buf, bool mixedBlock)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x10921FC", Offset = "0x10921FC", VA = "0x10921FC")]
		private void FrequencyInversion(float[] buf)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x109226C", Offset = "0x109226C", VA = "0x109226C")]
		private void InversePolyphase(float[] buf, int ch, int ofs, float[] outBuf)
		{
		}
	}
	[Token(Token = "0x2000120")]
	internal class MpegFrame : FrameBase, IMpegFrame
	{
		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][][] _bitRateTable;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal MpegFrame Next;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int Number;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _syncBits;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _readOffset;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _bitsRead;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ulong _bitBucket;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long _offset;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isMuted;

		[Token(Token = "0x170000D9")]
		public int FrameLength
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0xC3FC48", Offset = "0xC3FC48", VA = "0xC3FC48", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DA")]
		public MpegVersion Version
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0xC3F474", Offset = "0xC3F474", VA = "0xC3F474", Slot = "10")]
			get
			{
				return default(MpegVersion);
			}
		}

		[Token(Token = "0x170000DB")]
		public MpegLayer Layer
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0xC3F014", Offset = "0xC3F014", VA = "0xC3F014", Slot = "11")]
			get
			{
				return default(MpegLayer);
			}
		}

		[Token(Token = "0x170000DC")]
		public bool HasCrc
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xC3F268", Offset = "0xC3F268", VA = "0xC3F268", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public int BitRate
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xC3F024", Offset = "0xC3F024", VA = "0xC3F024", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DE")]
		public int BitRateIndex
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xC3F17C", Offset = "0xC3F17C", VA = "0xC3F17C", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public int SampleRate
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xC3F188", Offset = "0xC3F188", VA = "0xC3F188", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public int SampleRateIndex
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xC3FC50", Offset = "0xC3FC50", VA = "0xC3FC50", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E1")]
		private int Padding
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0xC3F1C0", Offset = "0xC3F1C0", VA = "0xC3F1C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E2")]
		public MpegChannelMode ChannelMode
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0xC3F170", Offset = "0xC3F170", VA = "0xC3F170", Slot = "12")]
			get
			{
				return default(MpegChannelMode);
			}
		}

		[Token(Token = "0x170000E3")]
		public int ChannelModeExtension
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xC3F468", Offset = "0xC3F468", VA = "0xC3F468", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E4")]
		internal int Channels
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0xC3FBEC", Offset = "0xC3FBEC", VA = "0xC3FBEC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsCopyrighted
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xC3FC5C", Offset = "0xC3FC5C", VA = "0xC3FC5C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		internal bool IsOriginal
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xC3FC68", Offset = "0xC3FC68", VA = "0xC3FC68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		internal int EmphasisMode
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xC3FC74", Offset = "0xC3FC74", VA = "0xC3FC74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E8")]
		public bool IsCorrupted
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xC3FC80", Offset = "0xC3FC80", VA = "0xC3FC80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public int SampleCount
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xC3FC04", Offset = "0xC3FC04", VA = "0xC3FC04", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EA")]
		internal long SampleOffset
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xC3FC88", Offset = "0xC3FC88", VA = "0xC3FC88")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xC3FC90", Offset = "0xC3FC90", VA = "0xC3FC90")]
			set
			{
			}
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xC3ED2C", Offset = "0xC3ED2C", VA = "0xC3ED2C")]
		internal static MpegFrame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xC3EDF0", Offset = "0xC3EDF0", VA = "0xC3EDF0")]
		private MpegFrame()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xC3EE58", Offset = "0xC3EE58", VA = "0xC3EE58", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xC3F1CC", Offset = "0xC3F1CC", VA = "0xC3F1CC")]
		internal int GetSideDataSize()
		{
			return default(int);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xC3F278", Offset = "0xC3F278", VA = "0xC3F278")]
		private bool ValidateCRC()
		{
			return default(bool);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xC3F490", Offset = "0xC3F490", VA = "0xC3F490")]
		internal static void UpdateCRC(int data, int length, ref uint crc)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xC3F4DC", Offset = "0xC3F4DC", VA = "0xC3F4DC")]
		internal VBRInfo ParseVBR()
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xC3F6E4", Offset = "0xC3F6E4", VA = "0xC3F6E4")]
		private VBRInfo ParseXing(int offset)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xC3F98C", Offset = "0xC3F98C", VA = "0xC3F98C")]
		private VBRInfo ParseVBRI()
		{
			return null;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xC3F42C", Offset = "0xC3F42C", VA = "0xC3F42C", Slot = "19")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xC3FC98", Offset = "0xC3FC98", VA = "0xC3FC98", Slot = "20")]
		public int ReadBits(int bitCount)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000121")]
	internal class MpegStreamReader
	{
		[Token(Token = "0x20001CF")]
		private class ReadBuffer
		{
			[Token(Token = "0x4000D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] Data;

			[Token(Token = "0x4000D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long BaseOffset;

			[Token(Token = "0x4000D24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int End;

			[Token(Token = "0x4000D25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int DiscardCount;

			[Token(Token = "0x4000D26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _localLock;

			[Token(Token = "0x6000C65")]
			[Address(RVA = "0xC40248", Offset = "0xC40248", VA = "0xC40248")]
			public ReadBuffer(int initialSize)
			{
			}

			[Token(Token = "0x6000C66")]
			[Address(RVA = "0xC40B74", Offset = "0xC40B74", VA = "0xC40B74")]
			public int Read(MpegStreamReader reader, long offset, byte[] buffer, int index, int count)
			{
				return default(int);
			}

			[Token(Token = "0x6000C67")]
			[Address(RVA = "0xC40CF4", Offset = "0xC40CF4", VA = "0xC40CF4")]
			public int ReadByte(MpegStreamReader reader, long offset)
			{
				return default(int);
			}

			[Token(Token = "0x6000C68")]
			[Address(RVA = "0xC4145C", Offset = "0xC4145C", VA = "0xC4145C")]
			private int EnsureFilled(MpegStreamReader reader, long offset, ref int count)
			{
				return default(int);
			}

			[Token(Token = "0x6000C69")]
			[Address(RVA = "0xC40E30", Offset = "0xC40E30", VA = "0xC40E30")]
			public void DiscardThrough(long offset)
			{
			}

			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0xC41A20", Offset = "0xC41A20", VA = "0xC41A20")]
			private void Truncate()
			{
			}

			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0xC41A28", Offset = "0xC41A28", VA = "0xC41A28")]
			private void CommitDiscard()
			{
			}
		}

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ID3Frame _id3Frame;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ID3Frame _id3v1Frame;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RiffHeaderFrame _riffHeaderFrame;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VBRInfo _vbrInfo;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MpegFrame _first;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MpegFrame _current;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MpegFrame _last;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MpegFrame _lastFree;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long _readOffset;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long _eofOffset;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Stream _source;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _canSeek;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _endFound;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _mixedFrameSize;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object _readLock;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _frameLock;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ReadBuffer _readBuf;

		[Token(Token = "0x170000EB")]
		internal bool CanSeek
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0xC410C0", Offset = "0xC410C0", VA = "0xC410C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		internal long SampleCount
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xC410C8", Offset = "0xC410C8", VA = "0xC410C8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000ED")]
		internal int SampleRate
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0xC41148", Offset = "0xC41148", VA = "0xC41148")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EE")]
		internal int Channels
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0xC41170", Offset = "0xC41170", VA = "0xC41170")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EF")]
		internal int FirstFrameSampleCount
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0xC411AC", Offset = "0xC411AC", VA = "0xC411AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xC400A0", Offset = "0xC400A0", VA = "0xC400A0")]
		internal MpegStreamReader(Stream source)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xC40324", Offset = "0xC40324", VA = "0xC40324")]
		private FrameBase FindNextFrame()
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xC409F4", Offset = "0xC409F4", VA = "0xC409F4")]
		internal int Read(long offset, byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xC40C54", Offset = "0xC40C54", VA = "0xC40C54")]
		internal int ReadByte(long offset)
		{
			return default(int);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xC40AE8", Offset = "0xC40AE8", VA = "0xC40AE8")]
		internal void DiscardThrough(long offset, bool minimalRead)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xC40F4C", Offset = "0xC40F4C", VA = "0xC40F4C")]
		internal void ReadToEnd()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xC411BC", Offset = "0xC411BC", VA = "0xC411BC")]
		internal long SeekTo(long sampleNumber)
		{
			return default(long);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xC41340", Offset = "0xC41340", VA = "0xC41340")]
		internal MpegFrame NextFrame()
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xC41454", Offset = "0xC41454", VA = "0xC41454")]
		internal MpegFrame GetCurrentFrame()
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	internal class RiffHeaderFrame : FrameBase
	{
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xC40B00", Offset = "0xC40B00", VA = "0xC40B00")]
		internal static RiffHeaderFrame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xC41AB0", Offset = "0xC41AB0", VA = "0xC41AB0")]
		private RiffHeaderFrame()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xC41B18", Offset = "0xC41B18", VA = "0xC41B18", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000123")]
	internal class VBRInfo
	{
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4B4", Offset = "0x6CF4B4")]
		private int <SampleCount>k__BackingField;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4C4", Offset = "0x6CF4C4")]
		private int <SampleRate>k__BackingField;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4D4", Offset = "0x6CF4D4")]
		private int <Channels>k__BackingField;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4E4", Offset = "0x6CF4E4")]
		private int <VBRFrames>k__BackingField;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF4F4", Offset = "0x6CF4F4")]
		private int <VBRBytes>k__BackingField;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF504", Offset = "0x6CF504")]
		private int <VBRQuality>k__BackingField;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF514", Offset = "0x6CF514")]
		private int <VBRDelay>k__BackingField;

		[Token(Token = "0x170000F0")]
		internal int SampleCount
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xC41D5C", Offset = "0xC41D5C", VA = "0xC41D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1550", Offset = "0x6D1550")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xC41D64", Offset = "0xC41D64", VA = "0xC41D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1560", Offset = "0x6D1560")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		internal int SampleRate
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xC41D6C", Offset = "0xC41D6C", VA = "0xC41D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1570", Offset = "0x6D1570")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0xC41D74", Offset = "0xC41D74", VA = "0xC41D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1580", Offset = "0x6D1580")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		internal int Channels
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0xC41D7C", Offset = "0xC41D7C", VA = "0xC41D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1590", Offset = "0x6D1590")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xC41D84", Offset = "0xC41D84", VA = "0xC41D84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15A0", Offset = "0x6D15A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		internal int VBRFrames
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xC41D8C", Offset = "0xC41D8C", VA = "0xC41D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15B0", Offset = "0x6D15B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xC41D94", Offset = "0xC41D94", VA = "0xC41D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15C0", Offset = "0x6D15C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		internal int VBRBytes
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0xC41D9C", Offset = "0xC41D9C", VA = "0xC41D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15D0", Offset = "0x6D15D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xC41DA4", Offset = "0xC41DA4", VA = "0xC41DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15E0", Offset = "0x6D15E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		internal int VBRQuality
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0xC41DAC", Offset = "0xC41DAC", VA = "0xC41DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D15F0", Offset = "0x6D15F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0xC41DB4", Offset = "0xC41DB4", VA = "0xC41DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1600", Offset = "0x6D1600")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		internal int VBRDelay
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0xC41DBC", Offset = "0xC41DBC", VA = "0xC41DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1610", Offset = "0x6D1610")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xC41DC4", Offset = "0xC41DC4", VA = "0xC41DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1620", Offset = "0x6D1620")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		internal long VBRStreamSampleCount
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xC41134", Offset = "0xC41134", VA = "0xC41134")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000F8")]
		internal int VBRAverageBitrate
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0xC41DCC", Offset = "0xC41DCC", VA = "0xC41DCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xC3FBE4", Offset = "0xC3FBE4", VA = "0xC3FBE4")]
		internal VBRInfo()
		{
		}
	}
}
namespace MeshBrush
{
	[Token(Token = "0x2000124")]
	public class MeshBrush : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDB9C", Offset = "0x6CDB9C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000D27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000D28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transform, MeshFilter> <>9__113_0;

			[Token(Token = "0x4000D29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Keyframe, XElement> <>9__126_0;

			[Token(Token = "0x4000D2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<bool, int, XElement> <>9__126_1;

			[Token(Token = "0x4000D2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<XElement, Keyframe> <>9__127_1;

			[Token(Token = "0x4000D2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<XElement, bool> <>9__127_0;

			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x107EB1C", Offset = "0x107EB1C", VA = "0x107EB1C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x107EB24", Offset = "0x107EB24", VA = "0x107EB24")]
			internal MeshFilter <CombineMeshes>b__113_0(Transform mesh)
			{
				return null;
			}

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x107EB7C", Offset = "0x107EB7C", VA = "0x107EB7C")]
			internal XElement <SaveTemplate>b__126_0(Keyframe key)
			{
				return null;
			}

			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x107EE60", Offset = "0x107EE60", VA = "0x107EE60")]
			internal XElement <SaveTemplate>b__126_1(bool layer, int index)
			{
				return null;
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x107F004", Offset = "0x107F004", VA = "0x107F004")]
			internal Keyframe <LoadTemplate>b__127_1(XElement key)
			{
				return default(Keyframe);
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x107F178", Offset = "0x107F178", VA = "0x107F178")]
			internal bool <LoadTemplate>b__127_0(XElement layerElement)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400099C")]
		public const float version = 2f;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool active;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupName;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showGlobalPaintingLayersInspector;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool[] layerMask;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float radius;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color color;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 quantityRange;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDensity;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 densityRange;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float delay;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector2 offsetRange;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector2 slopeInfluenceRange;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useSlopeFilter;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2 angleThresholdRange;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool inverseSlopeFilter;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 slopeReferenceVector;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 slopeReferenceVectorSampleLocation;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool yAxisTangent;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public bool strokeAlignment;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		public bool autoIgnoreRaycast;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector2 scatteringRange;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool useOverlapFilter;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector2 minimumAbsoluteDistanceRange;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool uniformRandomScale;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool uniformAdditiveScale;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector2 randomScaleRange;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector2 randomScaleRangeX;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector2 randomScaleRangeY;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 randomScaleRangeZ;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector2 additiveScaleRange;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Vector3 additiveScaleNonUniform;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AnimationCurve randomScaleCurve;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float randomScaleCurveVariation;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public Vector2 randomRotationRangeX;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Vector2 randomRotationRangeY;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public Vector2 randomRotationRangeZ;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool positionBrushRandomizer;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool rotationBrushRandomizer;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x116")]
		public bool scaleBrushRandomizer;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public KeyCode paintKey;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public KeyCode deleteKey;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public KeyCode combineKey;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public KeyCode randomizeKey;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public KeyCode increaseRadiusKey;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public KeyCode decreaseRadiusKey;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private int maxQuantityLimit;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float maxDelayLimit;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float maxDensityLimit;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float minOffsetLimit;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float maxOffsetLimit;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float maxMinimumAbsoluteDistanceLimit;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float maxAdditiveScaleLimit;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private float maxRandomScaleLimit;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool helpFoldout;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool helpTemplatesFoldout;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool helpGeneralUsageFoldout;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool helpOptimizationFoldout;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool meshesFoldout;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
		public bool templatesFoldout;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x156")]
		public bool keyBindingsFoldout;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x157")]
		public bool brushFoldout;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool slopesFoldout;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool randomizersFoldout;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool overlapFilterFoldout;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool additiveScaleFoldout;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool optimizationFoldout;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		[SerializeField]
		private bool globalPaintingMode;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		public bool collapsed;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		public bool stats;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public bool lockSceneView;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		public bool classicUI;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float previewIconSize;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool manualReferenceVectorSampling;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool showReferenceVectorInSceneView;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		public bool autoStatic;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		public bool autoSelectOnCombine;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Transform cachedTransform;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Collider cachedCollider;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private GameObject brush;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Transform brushTransform;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Transform holderObj;

		[Token(Token = "0x40009EE")]
		private const string minString = "min";

		[Token(Token = "0x40009EF")]
		private const string maxString = "max";

		[Token(Token = "0x40009F0")]
		private const string trueString = "true";

		[Token(Token = "0x40009F1")]
		private const string falseString = "false";

		[Token(Token = "0x40009F2")]
		private const string enabledString = "enabled";

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Vector3 lastPaintLocation;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public Vector3 brushStrokeDirection;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private List<GameObject> meshes;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private List<GameObject> deactivatedMeshes;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private List<Transform> paintedMeshes;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<Transform> paintedMeshesInsideBrushArea;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float nextFeasibleStrokeTime;

		[Token(Token = "0x170000F9")]
		public Transform CachedTransform
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x9A455C", Offset = "0x9A455C", VA = "0x9A455C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public Collider CachedCollider
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x9A45EC", Offset = "0x9A45EC", VA = "0x9A45EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public GameObject Brush
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x9A4684", Offset = "0x9A4684", VA = "0x9A4684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public Transform BrushTransform
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x9A47BC", Offset = "0x9A47BC", VA = "0x9A47BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public Transform HolderObj
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x9A4840", Offset = "0x9A4840", VA = "0x9A4840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x9A4A58", Offset = "0x9A4A58", VA = "0x9A4A58")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x9A4E4C", Offset = "0x9A4E4C", VA = "0x9A4E4C")]
		private void ValidateRangeLimits()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x9A4DE4", Offset = "0x9A4DE4", VA = "0x9A4DE4")]
		private void ValidateKeyBindings()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x9A4FA4", Offset = "0x9A4FA4", VA = "0x9A4FA4")]
		public void GatherPaintedMeshes()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x9A5018", Offset = "0x9A5018", VA = "0x9A5018")]
		public void CleanSetOfMeshesToPaint()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x9A5140", Offset = "0x9A5140", VA = "0x9A5140")]
		private void GatherMeshesInsideBrushArea(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x9A2314", Offset = "0x9A2314", VA = "0x9A2314")]
		public void PaintMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x9A31E8", Offset = "0x9A31E8", VA = "0x9A31E8")]
		public void RandomizeMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x9A3008", Offset = "0x9A3008", VA = "0x9A3008")]
		public void DeleteMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x9A5988", Offset = "0x9A5988", VA = "0x9A5988")]
		public void CombineMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x9A5B4C", Offset = "0x9A5B4C", VA = "0x9A5B4C")]
		public void SampleReferenceVector(Vector3 referenceVector, Vector3 sampleLocation)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x9A5678", Offset = "0x9A5678", VA = "0x9A5678")]
		private void OrientPaintedMesh(Transform targetTransform, RaycastHit targetLocation)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x9A53F4", Offset = "0x9A53F4", VA = "0x9A53F4")]
		private bool CheckOverlap(Vector3 objPos)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x9A48C4", Offset = "0x9A48C4", VA = "0x9A48C4")]
		private void CheckHolder()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x9A4708", Offset = "0x9A4708", VA = "0x9A4708")]
		private void CheckBrush()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x9A5B5C", Offset = "0x9A5B5C", VA = "0x9A5B5C")]
		private void CreateHolder()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x9A5CA0", Offset = "0x9A5CA0", VA = "0x9A5CA0")]
		private void CreateBrush()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x9A5D5C", Offset = "0x9A5D5C", VA = "0x9A5D5C")]
		public void ResetKeyBindings()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x9A5D7C", Offset = "0x9A5D7C", VA = "0x9A5D7C")]
		public void ResetSlopeSettings()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x9A5DF8", Offset = "0x9A5DF8", VA = "0x9A5DF8")]
		public void ResetRandomizers()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x9A5EE8", Offset = "0x9A5EE8", VA = "0x9A5EE8")]
		public void ResetAdditiveScale()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x9A5F8C", Offset = "0x9A5F8C", VA = "0x9A5F8C")]
		public void ResetOverlapFilterSettings()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x9A5FCC", Offset = "0x9A5FCC", VA = "0x9A5FCC")]
		public XDocument SaveTemplate(string filePath)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x9AA7BC", Offset = "0x9AA7BC", VA = "0x9AA7BC")]
		public bool LoadTemplate(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x9B0154", Offset = "0x9B0154", VA = "0x9B0154")]
		public MeshBrush()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class MeshBrushParent : MonoBehaviour
	{
		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform[] paintedMeshes;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshFilter[] meshFilters;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 localTransformationMatrix;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Hashtable materialToMesh;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MeshFilter currentMeshFilter;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Renderer currentRenderer;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material[] materials;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CombineUtility.MeshInstance instance;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CombineUtility.MeshInstance[] instances;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ArrayList objects;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ArrayList elements;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x107F1E8", Offset = "0x107F1E8", VA = "0x107F1E8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x107F258", Offset = "0x107F258", VA = "0x107F258")]
		public void FlagMeshesAsStatic()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x107F2EC", Offset = "0x107F2EC", VA = "0x107F2EC")]
		public void UnflagMeshesAsStatic()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x107F380", Offset = "0x107F380", VA = "0x107F380")]
		public int GetMeshCount()
		{
			return default(int);
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x107F3B0", Offset = "0x107F3B0", VA = "0x107F3B0")]
		public int GetTrisCount()
		{
			return default(int);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x107F474", Offset = "0x107F474", VA = "0x107F474")]
		public void DeleteAllMeshes()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x107F4F0", Offset = "0x107F4F0", VA = "0x107F4F0")]
		public void CombinePaintedMeshes(bool autoSelect, MeshFilter[] meshFilters)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x107FFD8", Offset = "0x107FFD8", VA = "0x107FFD8")]
		public MeshBrushParent()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class SaveCombinedMesh : MonoBehaviour
	{
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1080610", Offset = "0x1080610", VA = "0x1080610")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1080678", Offset = "0x1080678", VA = "0x1080678")]
		public SaveCombinedMesh()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public static class EditorIcons
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D saveTemplateIcon;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture2D loadTemplateIcon;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D nullIcon;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Texture2D addIcon;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D saveMeshIcon;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static byte[] saveTemplateIconBytes;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static byte[] loadTemplateIconBytes;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static byte[] nullIconBytes;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static byte[] addIconBytes;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static byte[] saveMeshIconBytes;

		[Token(Token = "0x170000FE")]
		public static Texture2D SaveTemplateIcon
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x9A1804", Offset = "0x9A1804", VA = "0x9A1804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public static Texture2D LoadTemplateIcon
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x9A194C", Offset = "0x9A194C", VA = "0x9A194C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public static Texture2D NullIcon
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x9A1A90", Offset = "0x9A1A90", VA = "0x9A1A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		public static Texture2D AddIcon
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x9A1BD4", Offset = "0x9A1BD4", VA = "0x9A1BD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public static Texture2D SaveMeshIcon
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x9A1D18", Offset = "0x9A1D18", VA = "0x9A1D18")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000128")]
	public static class CombineUtility
	{
		[Token(Token = "0x20001D1")]
		public struct MeshInstance
		{
			[Token(Token = "0x4000D2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh mesh;

			[Token(Token = "0x4000D2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int subMeshIndex;

			[Token(Token = "0x4000D2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Matrix4x4 transform;
		}

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int vertexCount;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int triangleCount;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int stripCount;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int curStripCount;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Vector3[] vertices;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector3[] normals;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Vector4[] tangents;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Vector2[] uv;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector2[] uv1;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Color[] colors;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static int[] triangles;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static int[] strip;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static int offset;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static int triangleOffset;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int stripOffset;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static int vertexOffset;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Matrix4x4 invTranspose;

		[Token(Token = "0x4000A20")]
		public const string combinedMeshName = "Combined Mesh";

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Vector4 p4;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static Vector3 p;

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x9A01A0", Offset = "0x9A01A0", VA = "0x9A01A0")]
		public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x9A1358", Offset = "0x9A1358", VA = "0x9A1358")]
		private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x9A1438", Offset = "0x9A1438", VA = "0x9A1438")]
		private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x9A16F8", Offset = "0x9A16F8", VA = "0x9A16F8")]
		private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset)
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x9A177C", Offset = "0x9A177C", VA = "0x9A177C")]
		private static void CopyColors(int vertexcount, Color[] src, Color[] dst, ref int offset)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x9A153C", Offset = "0x9A153C", VA = "0x9A153C")]
		private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform)
		{
		}
	}
	[Token(Token = "0x2000129")]
	public static class FavouriteTemplatesUtility
	{
		[Serializable]
		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CDBAC", Offset = "0x6CDBAC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000D30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000D31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, XElement> <>9__0_0;

			[Token(Token = "0x4000D32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<XElement, string> <>9__1_0;

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x9A446C", Offset = "0x9A446C", VA = "0x9A446C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x9A4474", Offset = "0x9A4474", VA = "0x9A4474")]
			internal XElement <SaveFavouriteTemplates>b__0_0(string template)
			{
				return null;
			}

			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x9A4540", Offset = "0x9A4540", VA = "0x9A4540")]
			internal string <LoadFavouriteTemplates>b__1_0(XElement path)
			{
				return null;
			}
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x9A3AE8", Offset = "0x9A3AE8", VA = "0x9A3AE8")]
		public static XDocument SaveFavouriteTemplates(List<string> favouriteTemplates, string filePath)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x9A3DB8", Offset = "0x9A3DB8", VA = "0x9A3DB8")]
		public static List<string> LoadFavouriteTemplates(string filePath)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x9A3F90", Offset = "0x9A3F90", VA = "0x9A3F90")]
		public static bool LoadFavouriteTemplates(string filePath, List<string> targetList)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012A")]
	public static class MeshTransformationUtility
	{
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x107FFE0", Offset = "0x107FFE0", VA = "0x107FFE0")]
		public static void ApplyRandomScale(Transform targetTransform, Vector2 range)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x10800A8", Offset = "0x10800A8", VA = "0x10800A8")]
		public static void ApplyRandomScale(Transform targetTransform, Vector4 scaleRanges)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x108016C", Offset = "0x108016C", VA = "0x108016C")]
		public static void ApplyRandomScale(Transform targetTransform, Vector2 rangeX, Vector2 rangeY, Vector2 rangeZ)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1080250", Offset = "0x1080250", VA = "0x1080250")]
		public static void AddConstantScale(Transform targetTransform, Vector2 range)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1080384", Offset = "0x1080384", VA = "0x1080384")]
		public static void AddConstantScale(Transform targetTransform, float x, float y, float z)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x108047C", Offset = "0x108047C", VA = "0x108047C")]
		public static void ApplyRandomRotation(Transform targetTransform, float randomRotationIntensityPercentageX, float randomRotationIntensityPercentageY, float randomRotationIntensityPercentageZ)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1080534", Offset = "0x1080534", VA = "0x1080534")]
		public static void ApplyMeshOffset(Transform targetTransform, float offset, Vector3 direction)
		{
		}
	}
	[Token(Token = "0x200012B")]
	public static class TemplateMigrationUtility
	{
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1080680", Offset = "0x1080680", VA = "0x1080680")]
		public static bool TryMigrate(string filePath)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012C")]
	public static class VectorClampingUtility
	{
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x10832EC", Offset = "0x10832EC", VA = "0x10832EC")]
		public static void ClampVector(ref Vector2 vector, float minX, float maxX, float minY, float maxY)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x10833AC", Offset = "0x10833AC", VA = "0x10833AC")]
		public static void ClampVector(ref Vector3 vector, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1083498", Offset = "0x1083498", VA = "0x1083498")]
		public static void ClampVector(ref Vector4 vector, float minX, float maxX, float minY, float maxY, float minZ, float maxZ, float minW, float maxW)
		{
		}
	}
	[Token(Token = "0x200012D")]
	public enum BrushMode
	{
		[Token(Token = "0x4000A24")]
		Paint,
		[Token(Token = "0x4000A25")]
		PrecisionPlacement,
		[Token(Token = "0x4000A26")]
		SampleReferenceVector
	}
}
namespace MeshBrush.Examples
{
	[Token(Token = "0x200012E")]
	public class RuntimeExample : MonoBehaviour
	{
		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshBrush meshbrushInstance;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform circleBrush;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider radiusSlider;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider scatteringSlider;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider densitySlider;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform mainCamera;

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x9A1FA0", Offset = "0x9A1FA0", VA = "0x9A1FA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x9A1FD8", Offset = "0x9A1FD8", VA = "0x9A1FD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x9A3AE0", Offset = "0x9A3AE0", VA = "0x9A3AE0")]
		public RuntimeExample()
		{
		}
	}
}
