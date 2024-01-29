using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using CloudFine.ThrowLab.UI;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class BetterStreamingAssets
{
	[Token(Token = "0x2000003")]
	internal struct ReadInfo
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string readPath;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long size;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long offset;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint crc32;
	}

	[Token(Token = "0x2000004")]
	internal static class ApkImpl
	{
		[Token(Token = "0x2000005")]
		private struct PartInfo
		{
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long size;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long offset;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint crc32;
		}

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] s_paths;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PartInfo[] s_streamingAssets;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string s_root;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x9FBF74", Offset = "0x9FBF74", VA = "0x9FBF74")]
		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9FC1F8", Offset = "0x9FC1F8", VA = "0x9FC1F8")]
		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9FC35C", Offset = "0x9FC35C", VA = "0x9FC35C")]
		public static bool DirectoryExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x9FCF14", Offset = "0x9FCF14", VA = "0x9FCF14")]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9FCBDC", Offset = "0x9FCBDC", VA = "0x9FCBDC")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x9FC53C", Offset = "0x9FC53C", VA = "0x9FC53C")]
		public static Stream OpenRead(string path)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x9FDD44", Offset = "0x9FDD44", VA = "0x9FDD44")]
		private static int GetDirectoryIndex(string path)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9FD424", Offset = "0x9FD424", VA = "0x9FD424")]
		private static void GetStreamingAssetsInfoFromJar(string apkPath, List<string> paths, List<PartInfo> parts)
		{
		}
	}

	[Token(Token = "0x17000001")]
	public static string Root
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x9FBF08", Offset = "0x9FBF08", VA = "0x9FBF08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9FBF50", Offset = "0x9FBF50", VA = "0x9FBF50")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x9FC1D0", Offset = "0x9FC1D0", VA = "0x9FC1D0")]
	public static bool FileExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9FC358", Offset = "0x9FC358", VA = "0x9FC358")]
	public static bool DirectoryExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9FC3DC", Offset = "0x9FC3DC", VA = "0x9FC3DC")]
	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9FC454", Offset = "0x9FC454", VA = "0x9FC454")]
	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9FC484", Offset = "0x9FC484", VA = "0x9FC484")]
	public static Stream OpenRead(string path)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9FC684", Offset = "0x9FC684", VA = "0x9FC684")]
	public static StreamReader OpenText(string path)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9FC784", Offset = "0x9FC784", VA = "0x9FC784")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9FC910", Offset = "0x9FC910", VA = "0x9FC910")]
	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9FCB24", Offset = "0x9FCB24", VA = "0x9FCB24")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9FCF10", Offset = "0x9FCF10", VA = "0x9FCF10")]
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9FD3B4", Offset = "0x9FD3B4", VA = "0x9FD3B4")]
	public static string[] GetFiles(string path)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9FD3C0", Offset = "0x9FD3C0", VA = "0x9FD3C0")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9FC40C", Offset = "0x9FC40C", VA = "0x9FC40C")]
	private static ReadInfo GetInfoOrThrow(string path)
	{
		return default(ReadInfo);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9FD3C8", Offset = "0x9FD3C8", VA = "0x9FD3C8")]
	private static void ThrowFileNotFound(string path)
	{
	}
}
[Token(Token = "0x2000008")]
public class CameraHolder : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float windowDpi;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GUIStyle screenGUI;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] Prefabs;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int Prefab;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject Instance;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9FDF68", Offset = "0x9FDF68", VA = "0x9FDF68")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9FE164", Offset = "0x9FE164", VA = "0x9FE164")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9FE034", Offset = "0x9FE034", VA = "0x9FE034")]
	private void Counter(int count)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x9FE2AC", Offset = "0x9FE2AC", VA = "0x9FE2AC")]
	public CameraHolder()
	{
	}
}
[Token(Token = "0x2000009")]
public class FG_GameObjectGUIDs : MonoBehaviour
{
	[NonSerialized]
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool _dirty;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string[] guids;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public UnityEngine.Object[] objects;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9FE320", Offset = "0x9FE320", VA = "0x9FE320")]
	private FG_GameObjectGUIDs()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9FE3F4", Offset = "0x9FE3F4", VA = "0x9FE3F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9FE450", Offset = "0x9FE450", VA = "0x9FE450")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9FE4AC", Offset = "0x9FE4AC", VA = "0x9FE4AC")]
	private void OnDestroy()
	{
	}
}
[Token(Token = "0x200000A")]
public class ButtonAnimation : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float initial_size_x;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float initial_size_y;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float factor;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool GO;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9FE554", Offset = "0x9FE554", VA = "0x9FE554")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9FE59C", Offset = "0x9FE59C", VA = "0x9FE59C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9FE680", Offset = "0x9FE680", VA = "0x9FE680")]
	private void Go()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9FE6C0", Offset = "0x9FE6C0", VA = "0x9FE6C0")]
	public ButtonAnimation()
	{
	}
}
[Token(Token = "0x200000B")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh text_fx_name;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] fx_prefabs;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int index_fx;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Ray ray;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private RaycastHit2D ray_cast_hit;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9FE6D4", Offset = "0x9FE6D4", VA = "0x9FE6D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9FE7B4", Offset = "0x9FE7B4", VA = "0x9FE7B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9FEF4C", Offset = "0x9FEF4C", VA = "0x9FEF4C")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class SelfDestruct : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float selfdestruct_in;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9FEF54", Offset = "0x9FEF54", VA = "0x9FEF54")]
	private void Start()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9FEFEC", Offset = "0x9FEFEC", VA = "0x9FEFEC")]
	public SelfDestruct()
	{
	}
}
[Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoStopLoopedEffect : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float effectDuration;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float d;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9FEFFC", Offset = "0x9FEFFC", VA = "0x9FEFFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9FF008", Offset = "0x9FF008", VA = "0x9FF008")]
	private void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9FF124", Offset = "0x9FF124", VA = "0x9FF124")]
	public CFX_AutoStopLoopedEffect()
	{
	}
}
[Token(Token = "0x200000E")]
public class CFX_Demo : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo <>4__this;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xA00980", Offset = "0xA00980", VA = "0xA00980", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xA009C8", Offset = "0xA009C8", VA = "0xA009C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA001DC", Offset = "0xA001DC", VA = "0xA001DC")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xA0079C", Offset = "0xA0079C", VA = "0xA0079C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xA007A0", Offset = "0xA007A0", VA = "0xA007A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xA00988", Offset = "0xA00988", VA = "0xA00988", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool orderedSpawns;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float step;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float order;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material groundMat;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material waterMat;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleExamples;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, float> ParticlesYOffsetD;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int exampleIndex;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string randomSpawnsDelay;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool randomSpawns;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool slowMo;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9FF134", Offset = "0x9FF134", VA = "0x9FF134")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9FF284", Offset = "0x9FF284", VA = "0x9FF284")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9FF59C", Offset = "0x9FF59C", VA = "0x9FF59C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xA00168", Offset = "0xA00168", VA = "0xA00168")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__15))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xA00204", Offset = "0xA00204", VA = "0xA00204")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9FFE18", Offset = "0x9FFE18", VA = "0x9FFE18")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9FFFC4", Offset = "0x9FFFC4", VA = "0x9FFFC4")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xA0024C", Offset = "0xA0024C", VA = "0xA0024C")]
	public CFX_Demo()
	{
	}
}
[Token(Token = "0x2000010")]
public class CFX_Demo_New : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <CheckForDeletedParticles>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo_New <>4__this;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xA01930", Offset = "0xA01930", VA = "0xA01930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA01978", Offset = "0xA01978", VA = "0xA01978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA01634", Offset = "0xA01634", VA = "0xA01634")]
		[DebuggerHidden]
		public <CheckForDeletedParticles>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA017AC", Offset = "0xA017AC", VA = "0xA017AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA017B0", Offset = "0xA017B0", VA = "0xA017B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA01938", Offset = "0xA01938", VA = "0xA01938", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer groundRenderer;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider groundCollider;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[Space]
	public Image slowMoBtn;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text slowMoLabel;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image camRotBtn;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text camRotLabel;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image groundBtn;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text groundLabel;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space]
	public Text EffectLabel;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text EffectIndexLabel;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject[] ParticleExamples;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int exampleIndex;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool slowMo;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 defaultCamPosition;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Quaternion defaultCamRotation;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> onScreenParticles;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xA009D0", Offset = "0xA009D0", VA = "0xA009D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xA00D68", Offset = "0xA00D68", VA = "0xA00D68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xA01388", Offset = "0xA01388", VA = "0xA01388")]
	public void OnToggleGround()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xA01448", Offset = "0xA01448", VA = "0xA01448")]
	public void OnToggleCamera()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xA01518", Offset = "0xA01518", VA = "0xA01518")]
	public void OnToggleSlowMo()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xA015B8", Offset = "0xA015B8", VA = "0xA015B8")]
	public void OnPreviousEffect()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xA015BC", Offset = "0xA015BC", VA = "0xA015BC")]
	public void OnNextEffect()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xA00C3C", Offset = "0xA00C3C", VA = "0xA00C3C")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xA011A4", Offset = "0xA011A4", VA = "0xA011A4")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xA015C0", Offset = "0xA015C0", VA = "0xA015C0")]
	[IteratorStateMachine(typeof(<CheckForDeletedParticles>d__25))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xA0100C", Offset = "0xA0100C", VA = "0xA0100C")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xA01040", Offset = "0xA01040", VA = "0xA01040")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xA01074", Offset = "0xA01074", VA = "0xA01074")]
	private void destroyParticles()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xA0165C", Offset = "0xA0165C", VA = "0xA0165C")]
	public CFX_Demo_New()
	{
	}
}
[Token(Token = "0x2000013")]
public class CFX_Demo_RandomDir : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 min;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 max;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xA01980", Offset = "0xA01980", VA = "0xA01980")]
	private void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xA01A08", Offset = "0xA01A08", VA = "0xA01A08")]
	public CFX_Demo_RandomDir()
	{
	}
}
[Token(Token = "0x2000014")]
public class CFX_Demo_RandomDirectionTranslate : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 baseDir;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xA01A20", Offset = "0xA01A20", VA = "0xA01A20")]
	private void Start()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xA01B64", Offset = "0xA01B64", VA = "0xA01B64")]
	private void Update()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xA01C40", Offset = "0xA01C40", VA = "0xA01C40")]
	public CFX_Demo_RandomDirectionTranslate()
	{
	}
}
[Token(Token = "0x2000015")]
public class CFX_Demo_RotateCamera : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool rotating;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rotationCenter;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xA01CDC", Offset = "0xA01CDC", VA = "0xA01CDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xA01E18", Offset = "0xA01E18", VA = "0xA01E18")]
	public CFX_Demo_RotateCamera()
	{
	}
}
[Token(Token = "0x2000016")]
public class CFX_Demo_Translate : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 rotation;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xA01E74", Offset = "0xA01E74", VA = "0xA01E74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xA01F14", Offset = "0xA01F14", VA = "0xA01F14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xA01F84", Offset = "0xA01F84", VA = "0xA01F84")]
	public CFX_Demo_Translate()
	{
	}
}
[Token(Token = "0x2000017")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_AutoDestructShuriken <>4__this;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem <ps>5__2;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xA02280", Offset = "0xA02280", VA = "0xA02280", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xA022C8", Offset = "0xA022C8", VA = "0xA022C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA020C0", Offset = "0xA020C0", VA = "0xA020C0")]
		[DebuggerHidden]
		public <CheckIfAlive>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA020F0", Offset = "0xA020F0", VA = "0xA020F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA020F4", Offset = "0xA020F4", VA = "0xA020F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA02288", Offset = "0xA02288", VA = "0xA02288", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool OnlyDeactivate;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xA02000", Offset = "0xA02000", VA = "0xA02000")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xA0204C", Offset = "0xA0204C", VA = "0xA0204C")]
	[IteratorStateMachine(typeof(<CheckIfAlive>d__2))]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xA020E8", Offset = "0xA020E8", VA = "0xA020E8")]
	public CFX_AutoDestructShuriken()
	{
	}
}
[Token(Token = "0x2000019")]
public class CFX_AutodestructWhenNoChildren : MonoBehaviour
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0xA022D0", Offset = "0xA022D0", VA = "0xA022D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xA02368", Offset = "0xA02368", VA = "0xA02368")]
	public CFX_AutodestructWhenNoChildren()
	{
	}
}
[Token(Token = "0x200001A")]
public class CFX_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotation;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Space space;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xA02370", Offset = "0xA02370", VA = "0xA02370")]
	private void Update()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xA023D8", Offset = "0xA023D8", VA = "0xA023D8")]
	public CFX_AutoRotate()
	{
	}
}
[Token(Token = "0x200001B")]
public class CFX_InspectorHelp : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Locked;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Title;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string HelpText;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int MsgType;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xA023E8", Offset = "0xA023E8", VA = "0xA023E8")]
	[ContextMenu("Unlock editing")]
	private void Unlock()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xA023F0", Offset = "0xA023F0", VA = "0xA023F0")]
	public CFX_InspectorHelp()
	{
	}
}
[Token(Token = "0x200001C")]
[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float finalIntensity;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float baseIntensity;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autodestruct;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float p_lifetime;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float p_delay;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xA023F8", Offset = "0xA023F8", VA = "0xA023F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xA02468", Offset = "0xA02468", VA = "0xA02468")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xA024E4", Offset = "0xA024E4", VA = "0xA024E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xA0265C", Offset = "0xA0265C", VA = "0xA0265C")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x200001D")]
public class CFX_ShurikenThreadFix : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class <WaitFrame>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_ShurikenThreadFix <>4__this;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xA028B0", Offset = "0xA028B0", VA = "0xA028B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xA028F8", Offset = "0xA028F8", VA = "0xA028F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA027CC", Offset = "0xA027CC", VA = "0xA027CC")]
		[DebuggerHidden]
		public <WaitFrame>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA027FC", Offset = "0xA027FC", VA = "0xA027FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA02800", Offset = "0xA02800", VA = "0xA02800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA028B8", Offset = "0xA028B8", VA = "0xA028B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] systems;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xA0266C", Offset = "0xA0266C", VA = "0xA0266C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xA02758", Offset = "0xA02758", VA = "0xA02758")]
	[IteratorStateMachine(typeof(<WaitFrame>d__2))]
	private IEnumerator WaitFrame()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xA027F4", Offset = "0xA027F4", VA = "0xA027F4")]
	public CFX_ShurikenThreadFix()
	{
	}
}
[Token(Token = "0x200001F")]
public class CFX_SpawnSystem : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CFX_SpawnSystem instance;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool spawnAsChildren;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool onlyGetInactiveObjects;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool instantiateIfNeeded;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool allObjectsLoaded;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x1700000A")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA03910", Offset = "0xA03910", VA = "0xA03910")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xA02900", Offset = "0xA02900", VA = "0xA02900")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xA030F8", Offset = "0xA030F8", VA = "0xA030F8")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xA03474", Offset = "0xA03474", VA = "0xA03474")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xA03160", Offset = "0xA03160", VA = "0xA03160")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xA034CC", Offset = "0xA034CC", VA = "0xA034CC")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xA02F68", Offset = "0xA02F68", VA = "0xA02F68")]
	private void increasePoolCursor(int uniqueId)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xA03964", Offset = "0xA03964", VA = "0xA03964")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xA03A64", Offset = "0xA03A64", VA = "0xA03A64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xA03AE4", Offset = "0xA03AE4", VA = "0xA03AE4")]
	public CFX_SpawnSystem()
	{
	}
}
[Token(Token = "0x2000020")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xA03C30", Offset = "0xA03C30", VA = "0xA03C30")]
	public string GetShaderNameForPipeline()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xA03CBC", Offset = "0xA03CBC", VA = "0xA03CBC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xA041E8", Offset = "0xA041E8", VA = "0xA041E8")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xA043E0", Offset = "0xA043E0", VA = "0xA043E0")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000021")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600008C")]
	[Address(RVA = "0xA04454", Offset = "0xA04454", VA = "0xA04454")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xA044FC", Offset = "0xA044FC", VA = "0xA044FC")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000022")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xA04504", Offset = "0xA04504", VA = "0xA04504")]
	private void Start()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xA04658", Offset = "0xA04658", VA = "0xA04658")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xA04820", Offset = "0xA04820", VA = "0xA04820")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xA04DD4", Offset = "0xA04DD4", VA = "0xA04DD4")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000023")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000092")]
	[Address(RVA = "0xA04DDC", Offset = "0xA04DDC", VA = "0xA04DDC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xA04E84", Offset = "0xA04E84", VA = "0xA04E84")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000024")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xA05674", Offset = "0xA05674", VA = "0xA05674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xA056BC", Offset = "0xA056BC", VA = "0xA056BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA053A8", Offset = "0xA053A8", VA = "0xA053A8")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA05500", Offset = "0xA05500", VA = "0xA05500", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA05504", Offset = "0xA05504", VA = "0xA05504", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA0567C", Offset = "0xA0567C", VA = "0xA0567C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xA04E8C", Offset = "0xA04E8C", VA = "0xA04E8C")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xA04F10", Offset = "0xA04F10", VA = "0xA04F10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xA05334", Offset = "0xA05334", VA = "0xA05334")]
	[IteratorStateMachine(typeof(<largeNumber>d__6))]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xA053D0", Offset = "0xA053D0", VA = "0xA053D0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xA05478", Offset = "0xA05478", VA = "0xA05478")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000026")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xA056C4", Offset = "0xA056C4", VA = "0xA056C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xA05714", Offset = "0xA05714", VA = "0xA05714")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xA05794", Offset = "0xA05794", VA = "0xA05794")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xA0583C", Offset = "0xA0583C", VA = "0xA0583C")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000027")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xA05844", Offset = "0xA05844", VA = "0xA05844")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xA05974", Offset = "0xA05974", VA = "0xA05974")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x2000028")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xA0597C", Offset = "0xA0597C", VA = "0xA0597C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xA05A24", Offset = "0xA05A24", VA = "0xA05A24")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000029")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xA05A2C", Offset = "0xA05A2C", VA = "0xA05A2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xA05C34", Offset = "0xA05C34", VA = "0xA05C34")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xA06A00", Offset = "0xA06A00", VA = "0xA06A00")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xA06B0C", Offset = "0xA06B0C", VA = "0xA06B0C")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200002A")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xA06B14", Offset = "0xA06B14", VA = "0xA06B14")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xA06BBC", Offset = "0xA06BBC", VA = "0xA06BBC")]
	public void Start()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xA06C5C", Offset = "0xA06C5C", VA = "0xA06C5C")]
	public void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xA06EF8", Offset = "0xA06EF8", VA = "0xA06EF8")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Token(Token = "0x200002B")]
public static class BallisticsUtility
{
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xA06F00", Offset = "0xA06F00", VA = "0xA06F00")]
	public static bool IsZero(double d)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xA06F28", Offset = "0xA06F28", VA = "0xA06F28")]
	public static int SolveQuadric(double c0, double c1, double c2, out double s0, out double s1)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xA07018", Offset = "0xA07018", VA = "0xA07018")]
	public static int SolveCubic(double c0, double c1, double c2, double c3, out double s0, out double s1, out double s2)
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xA07264", Offset = "0xA07264", VA = "0xA07264")]
	public static int SolveQuartic(double c0, double c1, double c2, double c3, double c4, out double s0, out double s1, out double s2, out double s3)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xA0761C", Offset = "0xA0761C", VA = "0xA0761C")]
	public static float ballistic_range(float speed, float gravity, float initial_height)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xA07654", Offset = "0xA07654", VA = "0xA07654")]
	public static int solve_ballistic_arc(Vector3 proj_pos, float proj_speed, Vector3 target, float gravity, out Vector3 s0, out Vector3 s1)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xA07968", Offset = "0xA07968", VA = "0xA07968")]
	public static int solve_ballistic_arc(Vector3 proj_pos, float proj_speed, Vector3 target_pos, Vector3 target_velocity, float gravity, out Vector3 s0, out Vector3 s1)
	{
		return default(int);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xA07C8C", Offset = "0xA07C8C", VA = "0xA07C8C")]
	public static bool solve_ballistic_arc_lateral(Vector3 proj_pos, float lateral_speed, Vector3 target_pos, float max_height, out Vector3 fire_velocity, out float gravity)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xA07E78", Offset = "0xA07E78", VA = "0xA07E78")]
	public static bool solve_ballistic_arc_lateral(Vector3 proj_pos, float lateral_speed, Vector3 target, Vector3 target_velocity, float max_height_offset, out Vector3 fire_velocity, out float gravity, out Vector3 impact_point)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xA08170", Offset = "0xA08170", VA = "0xA08170")]
	public static int solve_ballistic_arc(Vector3 proj_pos, float proj_speed, Vector3 target, Vector3 acceleration, out Vector3 s0, out Vector3 s1)
	{
		return default(int);
	}
}
[Token(Token = "0x200002C")]
public class EffectOnCollision : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <FlashRenderer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshRenderer renderer;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xA08778", Offset = "0xA08778", VA = "0xA08778", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xA087C0", Offset = "0xA087C0", VA = "0xA087C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xA085F8", Offset = "0xA085F8", VA = "0xA085F8")]
		[DebuggerHidden]
		public <FlashRenderer>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA08628", Offset = "0xA08628", VA = "0xA08628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA0862C", Offset = "0xA0862C", VA = "0xA0862C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA08780", Offset = "0xA08780", VA = "0xA08780", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem _particleEffect;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource _audio;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer _flashRenderer;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xA0848C", Offset = "0xA0848C", VA = "0xA0848C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xA08580", Offset = "0xA08580", VA = "0xA08580")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xA08490", Offset = "0xA08490", VA = "0xA08490")]
	private void Effect()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xA08584", Offset = "0xA08584", VA = "0xA08584")]
	[IteratorStateMachine(typeof(<FlashRenderer>d__6))]
	private IEnumerator FlashRenderer(MeshRenderer renderer)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xA08620", Offset = "0xA08620", VA = "0xA08620")]
	public EffectOnCollision()
	{
	}
}
[Token(Token = "0x200002E")]
public static class EstimationUtility
{
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xA087C8", Offset = "0xA087C8", VA = "0xA087C8")]
	public static Vector3 SimpleAverage(Vector3[] inputs, out float[] componentWeights)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xA088E0", Offset = "0xA088E0", VA = "0xA088E0")]
	public static Vector3 WeightedMovingAverage(Vector3[] inputs, out float[] componentWeights)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xA08A1C", Offset = "0xA08A1C", VA = "0xA08A1C")]
	public static Vector3 ExponentialMovingAverage(Vector3[] inputs, out float[] componentWeights)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xA08BB0", Offset = "0xA08BB0", VA = "0xA08BB0")]
	public static Vector3 CustomCurveAverage(Vector3[] inputs, AnimationCurve curve, out float[] componentWeights)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200002F")]
public static class MaterialModifier
{
	[Token(Token = "0x2000030")]
	public interface Interface
	{
		[Token(Token = "0x60000C8")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x60000C9")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x60000CA")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x60000CB")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x60000CC")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x2000031")]
	public delegate void Callback(Interface owner);
}
[Token(Token = "0x2000032")]
public static class SRPHelper
{
	[Token(Token = "0x2000033")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400009A")]
		Undefined,
		[Token(Token = "0x400009B")]
		BuiltIn,
		[Token(Token = "0x400009C")]
		URP,
		[Token(Token = "0x400009D")]
		LWRP,
		[Token(Token = "0x400009E")]
		HDRP
	}

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderPipeline m_RenderPipelineCached;

	[Token(Token = "0x1700000F")]
	public static RenderPipeline renderPipelineType
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA08E74", Offset = "0xA08E74", VA = "0xA08E74")]
		get
		{
			return default(RenderPipeline);
		}
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xA08ED0", Offset = "0xA08ED0", VA = "0xA08ED0")]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xA08FF8", Offset = "0xA08FF8", VA = "0xA08FF8")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xA090D4", Offset = "0xA090D4", VA = "0xA090D4")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xA0914C", Offset = "0xA0914C", VA = "0xA0914C")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000034")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		public enum Mode
		{
			[Token(Token = "0x40000A5")]
			Trigger,
			[Token(Token = "0x40000A6")]
			Replace,
			[Token(Token = "0x40000A7")]
			Activate,
			[Token(Token = "0x40000A8")]
			Enable,
			[Token(Token = "0x40000A9")]
			Animate,
			[Token(Token = "0x40000AA")]
			Deactivate
		}

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA091B8", Offset = "0xA091B8", VA = "0xA091B8")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA095E4", Offset = "0xA095E4", VA = "0xA095E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA095E8", Offset = "0xA095E8", VA = "0xA095E8")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xA0A0D0", Offset = "0xA0A0D0", VA = "0xA0A0D0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public class ReplacementList
		{
			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xA0A0D8", Offset = "0xA0A0D8", VA = "0xA0A0D8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA09600", Offset = "0xA09600", VA = "0xA09600")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA0A0C8", Offset = "0xA0A0C8", VA = "0xA0A0C8")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xA0A224", Offset = "0xA0A224", VA = "0xA0A224")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA0A13C", Offset = "0xA0A13C", VA = "0xA0A13C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA0A158", Offset = "0xA0A158", VA = "0xA0A158")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA0A21C", Offset = "0xA0A21C", VA = "0xA0A21C")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class CameraRefocus
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA0A234", Offset = "0xA0A234", VA = "0xA0A234")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA0A29C", Offset = "0xA0A29C", VA = "0xA0A29C")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA0A2A4", Offset = "0xA0A2A4", VA = "0xA0A2A4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA0A2AC", Offset = "0xA0A2AC", VA = "0xA0A2AC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA0A398", Offset = "0xA0A398", VA = "0xA0A398")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA0A3DC", Offset = "0xA0A3DC", VA = "0xA0A3DC")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA0A47C", Offset = "0xA0A47C", VA = "0xA0A47C")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA0A56C", Offset = "0xA0A56C", VA = "0xA0A56C")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F0")]
				[Address(RVA = "0xA0AF0C", Offset = "0xA0AF0C", VA = "0xA0AF0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0xA0AF54", Offset = "0xA0AF54", VA = "0xA0AF54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xA0AC98", Offset = "0xA0AC98", VA = "0xA0AC98")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xA0ACC8", Offset = "0xA0ACC8", VA = "0xA0ACC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xA0ACCC", Offset = "0xA0ACCC", VA = "0xA0ACCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA0AF14", Offset = "0xA0AF14", VA = "0xA0AF14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C3")]
		private const float k_Spring = 50f;

		[Token(Token = "0x40000C4")]
		private const float k_Damper = 5f;

		[Token(Token = "0x40000C5")]
		private const float k_Drag = 10f;

		[Token(Token = "0x40000C6")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x40000C7")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x40000C8")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA0A7B8", Offset = "0xA0A7B8", VA = "0xA0A7B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA0AC14", Offset = "0xA0AC14", VA = "0xA0AC14")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA0AB64", Offset = "0xA0AB64", VA = "0xA0AB64")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA0ACC0", Offset = "0xA0ACC0", VA = "0xA0ACC0")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA0AF5C", Offset = "0xA0AF5C", VA = "0xA0AF5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA0AF84", Offset = "0xA0AF84", VA = "0xA0AF84")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA0B1A8", Offset = "0xA0B1A8", VA = "0xA0B1A8")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA0B1DC", Offset = "0xA0B1DC", VA = "0xA0B1DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA0B238", Offset = "0xA0B238", VA = "0xA0B238")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class FOVKick
	{
		[Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000101")]
				[Address(RVA = "0xA0B614", Offset = "0xA0B614", VA = "0xA0B614", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000103")]
				[Address(RVA = "0xA0B65C", Offset = "0xA0B65C", VA = "0xA0B65C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xA0B3FC", Offset = "0xA0B3FC", VA = "0xA0B3FC")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xA0B4DC", Offset = "0xA0B4DC", VA = "0xA0B4DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0xA0B4E0", Offset = "0xA0B4E0", VA = "0xA0B4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0xA0B61C", Offset = "0xA0B61C", VA = "0xA0B61C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000014")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000107")]
				[Address(RVA = "0xA0B7B0", Offset = "0xA0B7B0", VA = "0xA0B7B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xA0B7F8", Offset = "0xA0B7F8", VA = "0xA0B7F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0xA0B498", Offset = "0xA0B498", VA = "0xA0B498")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0xA0B664", Offset = "0xA0B664", VA = "0xA0B664", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0xA0B668", Offset = "0xA0B668", VA = "0xA0B668", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0xA0B7B8", Offset = "0xA0B7B8", VA = "0xA0B7B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA0B250", Offset = "0xA0B250", VA = "0xA0B250")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA0B298", Offset = "0xA0B298", VA = "0xA0B298")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA0B380", Offset = "0xA0B380", VA = "0xA0B380")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA0B388", Offset = "0xA0B388", VA = "0xA0B388")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA0B424", Offset = "0xA0B424", VA = "0xA0B424")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA0B4C0", Offset = "0xA0B4C0", VA = "0xA0B4C0")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x40000F0")]
		private const string display = "{0} FPS";

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text uiText;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA0B800", Offset = "0xA0B800", VA = "0xA0B800")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA0B87C", Offset = "0xA0B87C", VA = "0xA0B87C")]
		private void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA0B970", Offset = "0xA0B970", VA = "0xA0B970")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000016")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0xA0BBDC", Offset = "0xA0BBDC", VA = "0xA0BBDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000115")]
				[Address(RVA = "0xA0BC24", Offset = "0xA0BC24", VA = "0xA0BC24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0xA0B9F4", Offset = "0xA0B9F4", VA = "0xA0B9F4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0xA0BA24", Offset = "0xA0BA24", VA = "0xA0BA24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000112")]
			[Address(RVA = "0xA0BA28", Offset = "0xA0BA28", VA = "0xA0BA28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0xA0BBE4", Offset = "0xA0BBE4", VA = "0xA0BBE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA0B978", Offset = "0xA0B978", VA = "0xA0B978")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA0B980", Offset = "0xA0B980", VA = "0xA0B980")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA0BA1C", Offset = "0xA0BA1C", VA = "0xA0BA1C")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000018")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600011D")]
				[Address(RVA = "0xA0C0B8", Offset = "0xA0C0B8", VA = "0xA0C0B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600011F")]
				[Address(RVA = "0xA0C100", Offset = "0xA0C100", VA = "0xA0C100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0xA0BDF8", Offset = "0xA0BDF8", VA = "0xA0BDF8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0xA0BE28", Offset = "0xA0BE28", VA = "0xA0BE28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0xA0BE2C", Offset = "0xA0BE2C", VA = "0xA0BE2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0xA0C0C0", Offset = "0xA0C0C0", VA = "0xA0C0C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA0BC2C", Offset = "0xA0BC2C", VA = "0xA0BC2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA0BD54", Offset = "0xA0BD54", VA = "0xA0BD54")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA0BD74", Offset = "0xA0BD74", VA = "0xA0BD74")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA0BE20", Offset = "0xA0BE20", VA = "0xA0BE20")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000126")]
				[Address(RVA = "0xA0C500", Offset = "0xA0C500", VA = "0xA0C500", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000128")]
				[Address(RVA = "0xA0C548", Offset = "0xA0C548", VA = "0xA0C548", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0xA0C17C", Offset = "0xA0C17C", VA = "0xA0C17C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0xA0C1C4", Offset = "0xA0C1C4", VA = "0xA0C1C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0xA0C1C8", Offset = "0xA0C1C8", VA = "0xA0C1C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0xA0C508", Offset = "0xA0C508", VA = "0xA0C508", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA0C108", Offset = "0xA0C108", VA = "0xA0C108")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA0C1A4", Offset = "0xA0C1A4", VA = "0xA0C1A4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA0C1B0", Offset = "0xA0C1B0", VA = "0xA0C1B0")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200004C")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400010F")]
			Standalone,
			[Token(Token = "0x4000110")]
			Mobile
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA0C550", Offset = "0xA0C550", VA = "0xA0C550")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA0C554", Offset = "0xA0C554", VA = "0xA0C554")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA0C564", Offset = "0xA0C564", VA = "0xA0C564")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA0C950", Offset = "0xA0C950", VA = "0xA0C950")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA0C9EC", Offset = "0xA0C9EC", VA = "0xA0C9EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA0CA1C", Offset = "0xA0CA1C", VA = "0xA0CA1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA0CE94", Offset = "0xA0CE94", VA = "0xA0CE94")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA0CEB4", Offset = "0xA0CEB4", VA = "0xA0CEB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA0CEB8", Offset = "0xA0CEB8", VA = "0xA0CEB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA0D1EC", Offset = "0xA0D1EC", VA = "0xA0D1EC")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		public enum Action
		{
			[Token(Token = "0x4000122")]
			Activate,
			[Token(Token = "0x4000123")]
			Deactivate,
			[Token(Token = "0x4000124")]
			Destroy,
			[Token(Token = "0x4000125")]
			ReloadLevel,
			[Token(Token = "0x4000126")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public class Entry
		{
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000138")]
			[Address(RVA = "0xA0D568", Offset = "0xA0D568", VA = "0xA0D568")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public class Entries
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000139")]
			[Address(RVA = "0xA0D560", Offset = "0xA0D560", VA = "0xA0D560")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0xA0D644", Offset = "0xA0D644", VA = "0xA0D644", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0xA0D68C", Offset = "0xA0D68C", VA = "0xA0D68C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0xA0D474", Offset = "0xA0D474", VA = "0xA0D474")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0xA0D570", Offset = "0xA0D570", VA = "0xA0D570", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0xA0D574", Offset = "0xA0D574", VA = "0xA0D574", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0xA0D64C", Offset = "0xA0D64C", VA = "0xA0D64C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0xA0D768", Offset = "0xA0D768", VA = "0xA0D768", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0xA0D7B0", Offset = "0xA0D7B0", VA = "0xA0D7B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0xA0D49C", Offset = "0xA0D49C", VA = "0xA0D49C")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0xA0D694", Offset = "0xA0D694", VA = "0xA0D694", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0xA0D698", Offset = "0xA0D698", VA = "0xA0D698", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0xA0D770", Offset = "0xA0D770", VA = "0xA0D770", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000020")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0xA0D8C4", Offset = "0xA0D8C4", VA = "0xA0D8C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600014B")]
				[Address(RVA = "0xA0D90C", Offset = "0xA0D90C", VA = "0xA0D90C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0xA0D4C4", Offset = "0xA0D4C4", VA = "0xA0D4C4")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0xA0D7B8", Offset = "0xA0D7B8", VA = "0xA0D7B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0xA0D7BC", Offset = "0xA0D7BC", VA = "0xA0D7BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0xA0D8CC", Offset = "0xA0D8CC", VA = "0xA0D8CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA0D200", Offset = "0xA0D200", VA = "0xA0D200")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA0D318", Offset = "0xA0D318", VA = "0xA0D318")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA0D38C", Offset = "0xA0D38C", VA = "0xA0D38C")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA0D400", Offset = "0xA0D400", VA = "0xA0D400")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA0D4EC", Offset = "0xA0D4EC", VA = "0xA0D4EC")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA0D914", Offset = "0xA0D914", VA = "0xA0D914")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA0D964", Offset = "0xA0D964", VA = "0xA0D964")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA0D9F4", Offset = "0xA0D9F4", VA = "0xA0D9F4")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000058")]
		public class WaypointList
		{
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600015B")]
			[Address(RVA = "0xA0E514", Offset = "0xA0E514", VA = "0xA0E514")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000059")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600015C")]
			[Address(RVA = "0xA0E0F0", Offset = "0xA0E0F0", VA = "0xA0E0F0")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000022")]
		public float Length
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xA0DA04", Offset = "0xA0DA04", VA = "0xA0DA04")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xA0DA0C", Offset = "0xA0DA0C", VA = "0xA0DA0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xA0DA14", Offset = "0xA0DA14", VA = "0xA0DA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA0DA30", Offset = "0xA0DA30", VA = "0xA0DA30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA0DD60", Offset = "0xA0DD60", VA = "0xA0DD60")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA0DE90", Offset = "0xA0DE90", VA = "0xA0DE90")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA0E100", Offset = "0xA0E100", VA = "0xA0E100")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA0DA80", Offset = "0xA0DA80", VA = "0xA0DA80")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA0E20C", Offset = "0xA0E20C", VA = "0xA0E20C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA0E48C", Offset = "0xA0E48C", VA = "0xA0E48C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA0E214", Offset = "0xA0E214", VA = "0xA0E214")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA0E494", Offset = "0xA0E494", VA = "0xA0E494")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200005B")]
		public enum ProgressStyle
		{
			[Token(Token = "0x400015A")]
			SmoothAlongRoute,
			[Token(Token = "0x400015B")]
			PointToPoint
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000024")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xA0E578", Offset = "0xA0E578", VA = "0xA0E578")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xA0E58C", Offset = "0xA0E58C", VA = "0xA0E58C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xA0E5A0", Offset = "0xA0E5A0", VA = "0xA0E5A0")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xA0E5B4", Offset = "0xA0E5B4", VA = "0xA0E5B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xA0E5C8", Offset = "0xA0E5C8", VA = "0xA0E5C8")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xA0E5DC", Offset = "0xA0E5DC", VA = "0xA0E5DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA0E5F0", Offset = "0xA0E5F0", VA = "0xA0E5F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA0E6EC", Offset = "0xA0E6EC", VA = "0xA0E6EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA0E7B8", Offset = "0xA0E7B8", VA = "0xA0E7B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xA0EC90", Offset = "0xA0EC90", VA = "0xA0EC90")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA0EDEC", Offset = "0xA0EDEC", VA = "0xA0EDEC")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200005C")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA0EE08", Offset = "0xA0EE08", VA = "0xA0EE08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA0F04C", Offset = "0xA0F04C", VA = "0xA0F04C")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA0F1D0", Offset = "0xA0F1D0", VA = "0xA0F1D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA0F1EC", Offset = "0xA0F1EC", VA = "0xA0F1EC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA0F2B8", Offset = "0xA0F2B8", VA = "0xA0F2B8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA0F31C", Offset = "0xA0F31C", VA = "0xA0F31C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA0F388", Offset = "0xA0F388", VA = "0xA0F388")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA0F38C", Offset = "0xA0F38C", VA = "0xA0F38C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA0F454", Offset = "0xA0F454", VA = "0xA0F454")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA0F51C", Offset = "0xA0F51C", VA = "0xA0F51C")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA0F5E4", Offset = "0xA0F5E4", VA = "0xA0F5E4")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA0F6AC", Offset = "0xA0F6AC", VA = "0xA0F6AC")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA0F774", Offset = "0xA0F774", VA = "0xA0F774")]
		public void Update()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA0F778", Offset = "0xA0F778", VA = "0xA0F778")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200005F")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000167")]
			Hardware,
			[Token(Token = "0x4000168")]
			Touch
		}

		[Token(Token = "0x2000060")]
		public class VirtualAxis
		{
			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000028")]
			public string name
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0xA0FF70", Offset = "0xA0FF70", VA = "0xA0FF70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000190")]
				[Address(RVA = "0xA0FF78", Offset = "0xA0FF78", VA = "0xA0FF78")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0xA0FF80", Offset = "0xA0FF80", VA = "0xA0FF80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000192")]
				[Address(RVA = "0xA0FF88", Offset = "0xA0FF88", VA = "0xA0FF88")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public float GetValue
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0xA10074", Offset = "0xA10074", VA = "0xA10074")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002B")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000198")]
				[Address(RVA = "0xA1007C", Offset = "0xA1007C", VA = "0xA1007C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0xA0FF94", Offset = "0xA0FF94", VA = "0xA0FF94")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0xA0FFD0", Offset = "0xA0FFD0", VA = "0xA0FFD0")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0xA10010", Offset = "0xA10010", VA = "0xA10010")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0xA1006C", Offset = "0xA1006C", VA = "0xA1006C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000061")]
		public class VirtualButton
		{
			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700002C")]
			public string name
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0xA10084", Offset = "0xA10084", VA = "0xA10084")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600019A")]
				[Address(RVA = "0xA1008C", Offset = "0xA1008C", VA = "0xA1008C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0xA10094", Offset = "0xA10094", VA = "0xA10094")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600019C")]
				[Address(RVA = "0xA1009C", Offset = "0xA1009C", VA = "0xA1009C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public bool GetButton
			{
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0xA101DC", Offset = "0xA101DC", VA = "0xA101DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002F")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0xA101E4", Offset = "0xA101E4", VA = "0xA101E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000030")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0xA10208", Offset = "0xA10208", VA = "0xA10208")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA100A8", Offset = "0xA100A8", VA = "0xA100A8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0xA100EC", Offset = "0xA100EC", VA = "0xA100EC")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0xA10134", Offset = "0xA10134", VA = "0xA10134")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xA10160", Offset = "0xA10160", VA = "0xA10160")]
			public void Released()
			{
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xA10180", Offset = "0xA10180", VA = "0xA10180")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000027")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xA0FDA8", Offset = "0xA0FDA8", VA = "0xA0FDA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA0F780", Offset = "0xA0F780", VA = "0xA0F780")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA0F858", Offset = "0xA0F858", VA = "0xA0F858")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA0EF08", Offset = "0xA0EF08", VA = "0xA0EF08")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA0F8FC", Offset = "0xA0F8FC", VA = "0xA0F8FC")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA0EF74", Offset = "0xA0EF74", VA = "0xA0EF74")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA0F968", Offset = "0xA0F968", VA = "0xA0F968")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA0F9D4", Offset = "0xA0F9D4", VA = "0xA0F9D4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA0FA90", Offset = "0xA0FA90", VA = "0xA0FA90")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA0EFE0", Offset = "0xA0EFE0", VA = "0xA0EFE0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA0CE3C", Offset = "0xA0CE3C", VA = "0xA0CE3C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA0FB7C", Offset = "0xA0FB7C", VA = "0xA0FB7C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA0FAFC", Offset = "0xA0FAFC", VA = "0xA0FAFC")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA0FBD4", Offset = "0xA0FBD4", VA = "0xA0FBD4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA0FC44", Offset = "0xA0FC44", VA = "0xA0FC44")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA0FCB4", Offset = "0xA0FCB4", VA = "0xA0FCB4")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA0F3E4", Offset = "0xA0F3E4", VA = "0xA0F3E4")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA0F4AC", Offset = "0xA0F4AC", VA = "0xA0F4AC")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA0F574", Offset = "0xA0F574", VA = "0xA0F574")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA0F704", Offset = "0xA0F704", VA = "0xA0F704")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA0F63C", Offset = "0xA0F63C", VA = "0xA0F63C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA0FD24", Offset = "0xA0FD24", VA = "0xA0FD24")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA0FE14", Offset = "0xA0FE14", VA = "0xA0FE14")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA0FE88", Offset = "0xA0FE88", VA = "0xA0FE88")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA0FEFC", Offset = "0xA0FEFC", VA = "0xA0FEFC")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA1022C", Offset = "0xA1022C", VA = "0xA1022C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA10230", Offset = "0xA10230", VA = "0xA10230")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA102A4", Offset = "0xA102A4", VA = "0xA102A4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000064")]
		public enum AxisOption
		{
			[Token(Token = "0x400017C")]
			Both,
			[Token(Token = "0x400017D")]
			OnlyHorizontal,
			[Token(Token = "0x400017E")]
			OnlyVertical
		}

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA102AC", Offset = "0xA102AC", VA = "0xA102AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA10448", Offset = "0xA10448", VA = "0xA10448")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA102E0", Offset = "0xA102E0", VA = "0xA102E0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA104A8", Offset = "0xA104A8", VA = "0xA104A8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA105F4", Offset = "0xA105F4", VA = "0xA105F4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA10630", Offset = "0xA10630", VA = "0xA10630", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA10634", Offset = "0xA10634", VA = "0xA10634")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA10674", Offset = "0xA10674", VA = "0xA10674")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA10700", Offset = "0xA10700", VA = "0xA10700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA10708", Offset = "0xA10708", VA = "0xA10708")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA10710", Offset = "0xA10710", VA = "0xA10710")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA10A08", Offset = "0xA10A08", VA = "0xA10A08")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000185")]
			ForwardAxis,
			[Token(Token = "0x4000186")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000068")]
		public class AxisMapping
		{
			[Token(Token = "0x2000069")]
			public enum MappingType
			{
				[Token(Token = "0x400018A")]
				NamedAxis,
				[Token(Token = "0x400018B")]
				MousePositionX,
				[Token(Token = "0x400018C")]
				MousePositionY,
				[Token(Token = "0x400018D")]
				MousePositionZ
			}

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xA10D74", Offset = "0xA10D74", VA = "0xA10D74")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA10A10", Offset = "0xA10A10", VA = "0xA10A10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA10AF0", Offset = "0xA10AF0", VA = "0xA10AF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA10D4C", Offset = "0xA10D4C", VA = "0xA10D4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA10D64", Offset = "0xA10D64", VA = "0xA10D64")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200006B")]
		public enum AxisOption
		{
			[Token(Token = "0x40001A1")]
			Both,
			[Token(Token = "0x40001A2")]
			OnlyHorizontal,
			[Token(Token = "0x40001A3")]
			OnlyVertical
		}

		[Token(Token = "0x200006C")]
		public enum ControlStyle
		{
			[Token(Token = "0x40001A5")]
			Absolute,
			[Token(Token = "0x40001A6")]
			Relative,
			[Token(Token = "0x40001A7")]
			Swipe
		}

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA10D7C", Offset = "0xA10D7C", VA = "0xA10D7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA10E18", Offset = "0xA10E18", VA = "0xA10E18")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA10F80", Offset = "0xA10F80", VA = "0xA10F80")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA11080", Offset = "0xA11080", VA = "0xA11080", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA110B8", Offset = "0xA110B8", VA = "0xA110B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA11290", Offset = "0xA11290", VA = "0xA11290", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA112F0", Offset = "0xA112F0", VA = "0xA112F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA113C0", Offset = "0xA113C0", VA = "0xA113C0")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000031")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xA11454", Offset = "0xA11454", VA = "0xA11454")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xA11460", Offset = "0xA11460", VA = "0xA11460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA1146C", Offset = "0xA1146C", VA = "0xA1146C")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA114C4", Offset = "0xA114C4", VA = "0xA114C4")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA1151C", Offset = "0xA1151C", VA = "0xA1151C")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA11660", Offset = "0xA11660", VA = "0xA11660")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA117A4", Offset = "0xA117A4", VA = "0xA117A4")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA11834", Offset = "0xA11834", VA = "0xA11834")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA118C4", Offset = "0xA118C4", VA = "0xA118C4")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA11964", Offset = "0xA11964", VA = "0xA11964")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA1196C", Offset = "0xA1196C", VA = "0xA1196C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA11974", Offset = "0xA11974", VA = "0xA11974")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60001CD")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60001CE")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60001CF")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60001D0")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60001D1")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60001D2")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60001D3")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60001D4")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60001D5")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60001D6")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60001D7")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA1197C", Offset = "0xA1197C", VA = "0xA1197C")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200006E")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA11AA4", Offset = "0xA11AA4", VA = "0xA11AA4")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA11B58", Offset = "0xA11B58", VA = "0xA11B58")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA11C04", Offset = "0xA11C04", VA = "0xA11C04", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA11CAC", Offset = "0xA11CAC", VA = "0xA11CAC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA11D6C", Offset = "0xA11D6C", VA = "0xA11D6C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA11E20", Offset = "0xA11E20", VA = "0xA11E20", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA11ECC", Offset = "0xA11ECC", VA = "0xA11ECC", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA11F78", Offset = "0xA11F78", VA = "0xA11F78", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA12020", Offset = "0xA12020", VA = "0xA12020", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA120CC", Offset = "0xA120CC", VA = "0xA120CC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA12188", Offset = "0xA12188", VA = "0xA12188", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA12244", Offset = "0xA12244", VA = "0xA12244", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA122EC", Offset = "0xA122EC", VA = "0xA122EC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA122F8", Offset = "0xA122F8", VA = "0xA122F8")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA122FC", Offset = "0xA122FC", VA = "0xA122FC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA12310", Offset = "0xA12310", VA = "0xA12310", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA1231C", Offset = "0xA1231C", VA = "0xA1231C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA12328", Offset = "0xA12328", VA = "0xA12328", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA12334", Offset = "0xA12334", VA = "0xA12334", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA12384", Offset = "0xA12384", VA = "0xA12384", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA123D4", Offset = "0xA123D4", VA = "0xA123D4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA12424", Offset = "0xA12424", VA = "0xA12424", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA12474", Offset = "0xA12474", VA = "0xA12474", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA124C4", Offset = "0xA124C4", VA = "0xA124C4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA12514", Offset = "0xA12514", VA = "0xA12514", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA1251C", Offset = "0xA1251C", VA = "0xA1251C")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000070")]
	[RequireComponent(typeof(NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000032")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xA12520", Offset = "0xA12520", VA = "0xA12520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xA12528", Offset = "0xA12528", VA = "0xA12528")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xA12530", Offset = "0xA12530", VA = "0xA12530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xA12538", Offset = "0xA12538", VA = "0xA12538")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA12540", Offset = "0xA12540", VA = "0xA12540")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA1260C", Offset = "0xA1260C", VA = "0xA1260C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA12960", Offset = "0xA12960", VA = "0xA12960")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA12968", Offset = "0xA12968", VA = "0xA12968")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(1f, 4f)]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40001BB")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA12970", Offset = "0xA12970", VA = "0xA12970")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA12704", Offset = "0xA12704", VA = "0xA12704")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA12E54", Offset = "0xA12E54", VA = "0xA12E54")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA13064", Offset = "0xA13064", VA = "0xA13064")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA131DC", Offset = "0xA131DC", VA = "0xA131DC")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA12DBC", Offset = "0xA12DBC", VA = "0xA12DBC")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA12CA0", Offset = "0xA12CA0", VA = "0xA12CA0")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA12C1C", Offset = "0xA12C1C", VA = "0xA12C1C")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA1349C", Offset = "0xA1349C", VA = "0xA1349C")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA12A98", Offset = "0xA12A98", VA = "0xA12A98")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA1353C", Offset = "0xA1353C", VA = "0xA1353C")]
		public ThirdPersonCharacter()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x2000072")]
	public static class BatchingHelper
	{
		[Token(Token = "0x40001C3")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000034")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xA1355C", Offset = "0xA1355C", VA = "0xA1355C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA13600", Offset = "0xA13600", VA = "0xA13600")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA13614", Offset = "0xA13614", VA = "0xA13614")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA1362C", Offset = "0xA1362C", VA = "0xA1362C")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA1397C", Offset = "0xA1397C", VA = "0xA1397C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA13AD0", Offset = "0xA13AD0", VA = "0xA13AD0")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	[AddComponentMenu("")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000040")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0xA176F8", Offset = "0xA176F8", VA = "0xA176F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0xA17740", Offset = "0xA17740", VA = "0xA17740", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0xA13E3C", Offset = "0xA13E3C", VA = "0xA13E3C")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0xA17658", Offset = "0xA17658", VA = "0xA17658", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0xA1765C", Offset = "0xA1765C", VA = "0xA1765C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0xA17700", Offset = "0xA17700", VA = "0xA17700", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000035")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xA13BA8", Offset = "0xA13BA8", VA = "0xA13BA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xA13BB0", Offset = "0xA13BB0", VA = "0xA13BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xA13BB8", Offset = "0xA13BB8", VA = "0xA13BB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xA13BC0", Offset = "0xA13BC0", VA = "0xA13BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xA13BC8", Offset = "0xA13BC8", VA = "0xA13BC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xA13BD0", Offset = "0xA13BD0", VA = "0xA13BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool visible
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xA13BD8", Offset = "0xA13BD8", VA = "0xA13BD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xA13BF4", Offset = "0xA13BF4", VA = "0xA13BF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xA13C14", Offset = "0xA13C14", VA = "0xA13C14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xA13C30", Offset = "0xA13C30", VA = "0xA13C30")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public int sortingOrder
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xA13C4C", Offset = "0xA13C4C", VA = "0xA13C4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xA13C68", Offset = "0xA13C68", VA = "0xA13C68")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xA13C84", Offset = "0xA13C84", VA = "0xA13C84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xA14524", Offset = "0xA14524", VA = "0xA14524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xA1452C", Offset = "0xA1452C", VA = "0xA1452C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xA15F9C", Offset = "0xA15F9C", VA = "0xA15F9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xA16090", Offset = "0xA16090", VA = "0xA16090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA13C94", Offset = "0xA13C94", VA = "0xA13C94")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA13DC8", Offset = "0xA13DC8", VA = "0xA13DC8")]
		[IteratorStateMachine(typeof(<CoUpdateFadeOut>d__30))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA13E64", Offset = "0xA13E64", VA = "0xA13E64")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA13F6C", Offset = "0xA13F6C", VA = "0xA13F6C")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA1427C", Offset = "0xA1427C", VA = "0xA1427C")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA1435C", Offset = "0xA1435C", VA = "0xA1435C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA143F8", Offset = "0xA143F8", VA = "0xA143F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA14494", Offset = "0xA14494", VA = "0xA14494")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA14570", Offset = "0xA14570", VA = "0xA14570")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA145F8", Offset = "0xA145F8", VA = "0xA145F8")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA14D1C", Offset = "0xA14D1C", VA = "0xA14D1C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA15DDC", Offset = "0xA15DDC", VA = "0xA15DDC")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA14A8C", Offset = "0xA14A8C", VA = "0xA14A8C")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA140DC", Offset = "0xA140DC", VA = "0xA140DC", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA16650", Offset = "0xA16650", VA = "0xA16650", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA16768", Offset = "0xA16768", VA = "0xA16768", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA16880", Offset = "0xA16880", VA = "0xA16880", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA169B0", Offset = "0xA169B0", VA = "0xA169B0", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA14024", Offset = "0xA14024", VA = "0xA14024")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA141C4", Offset = "0xA141C4", VA = "0xA141C4")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA16A8C", Offset = "0xA16A8C", VA = "0xA16A8C")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA15924", Offset = "0xA15924", VA = "0xA15924")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA16EA8", Offset = "0xA16EA8", VA = "0xA16EA8")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA16FC8", Offset = "0xA16FC8", VA = "0xA16FC8")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA16FD4", Offset = "0xA16FD4", VA = "0xA16FD4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA17008", Offset = "0xA17008", VA = "0xA17008")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA170EC", Offset = "0xA170EC", VA = "0xA170EC")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA17650", Offset = "0xA17650", VA = "0xA17650")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("renderPipeline")]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("renderingMode")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000042")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xA17748", Offset = "0xA17748", VA = "0xA17748")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xA17750", Offset = "0xA17750", VA = "0xA17750")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xA177B8", Offset = "0xA177B8", VA = "0xA177B8")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xA177C0", Offset = "0xA177C0", VA = "0xA177C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xA135AC", Offset = "0xA135AC", VA = "0xA135AC")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000045")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xA17868", Offset = "0xA17868", VA = "0xA17868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xA14F9C", Offset = "0xA14F9C", VA = "0xA14F9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public Shader beamShader
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xA17880", Offset = "0xA17880", VA = "0xA17880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0xA17888", Offset = "0xA17888", VA = "0xA17888")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000049")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xA13EF8", Offset = "0xA13EF8", VA = "0xA13EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xA17934", Offset = "0xA17934", VA = "0xA17934")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public static Config Instance
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xA135A4", Offset = "0xA135A4", VA = "0xA135A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA17828", Offset = "0xA17828", VA = "0xA17828")]
		public void SetRenderingModeAndRefreshShader(RenderingMode mode)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA1782C", Offset = "0xA1782C", VA = "0xA1782C")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA17894", Offset = "0xA17894", VA = "0xA17894")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA17964", Offset = "0xA17964", VA = "0xA17964")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA17AC8", Offset = "0xA17AC8", VA = "0xA17AC8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA17A4C", Offset = "0xA17A4C", VA = "0xA17A4C")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA17B98", Offset = "0xA17B98", VA = "0xA17B98")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA17DE0", Offset = "0xA17DE0", VA = "0xA17DE0")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA17F80", Offset = "0xA17F80", VA = "0xA17F80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA17F8C", Offset = "0xA17F8C", VA = "0xA17F8C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA17F90", Offset = "0xA17F90", VA = "0xA17F90")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA18094", Offset = "0xA18094", VA = "0xA18094")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x40001E6")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA18194", Offset = "0xA18194", VA = "0xA18194")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public static class Consts
	{
		[Token(Token = "0x40001E7")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x40001E8")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x40001E9")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x40001EA")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x40001EB")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x40001EC")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x40001ED")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x40001F0")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x40001F1")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x40001F2")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x40001F3")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x40001F4")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x40001F5")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x40001F6")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x40001F7")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x40001F8")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x40001F9")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x40001FA")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x40001FB")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x40001FC")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x40001FD")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x40001FE")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x40001FF")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000200")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000201")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000202")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000203")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000204")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000205")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000206")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000207")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000208")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000209")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400020A")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x400020B")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x400020C")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x400020D")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400020E")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400020F")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000210")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000211")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000213")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000214")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x4000215")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x4000216")]
		public const Dimensions BeamDimensions = Dimensions.Dim3D;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x4000218")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x4000219")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x400021A")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x400021B")]
		public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x400021C")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x400021D")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x400021E")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x400021F")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000220")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000221")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000222")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000223")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000224")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000225")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000226")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x4000227")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x4000228")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000229")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400022A")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400022B")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x400022C")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400022D")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x400022E")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

		[Token(Token = "0x400022F")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000230")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000231")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x4000232")]
		public const float ConfigDitheringFactor = 0f;

		[Token(Token = "0x1700004C")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xA1491C", Offset = "0xA1491C", VA = "0xA1491C")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000078")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000079")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x400023B")]
			RenderLoop,
			[Token(Token = "0x400023C")]
			OnEnable,
			[Token(Token = "0x400023D")]
			EditorUpdate,
			[Token(Token = "0x400023E")]
			User
		}

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x1700004D")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xA1864C", Offset = "0xA1864C", VA = "0xA1864C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xA183D0", Offset = "0xA183D0", VA = "0xA183D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xA1846C", Offset = "0xA1846C", VA = "0xA1846C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA18224", Offset = "0xA18224", VA = "0xA18224")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA1822C", Offset = "0xA1822C", VA = "0xA1822C")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x600025F")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x6000260")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000261")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000262")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000263")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA18654", Offset = "0xA18654", VA = "0xA18654", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA18674", Offset = "0xA18674", VA = "0xA18674", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA18700", Offset = "0xA18700", VA = "0xA18700", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA1874C", Offset = "0xA1874C", VA = "0xA1874C", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA18B34", Offset = "0xA18B34", VA = "0xA18B34", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA18C5C", Offset = "0xA18C5C", VA = "0xA18C5C")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA1871C", Offset = "0xA1871C", VA = "0xA1871C")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA18E4C", Offset = "0xA18E4C", VA = "0xA18E4C")]
		protected DynamicOcclusionAbstractBase()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask layerMask;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useOcclusionCulling;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int depthMapResolution;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_DepthCamera;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA18EBC", Offset = "0xA18EBC", VA = "0xA18EBC", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA18EFC", Offset = "0xA18EFC", VA = "0xA18EFC", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA18F04", Offset = "0xA18F04", VA = "0xA18F04")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA190FC", Offset = "0xA190FC", VA = "0xA190FC", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA19134", Offset = "0xA19134", VA = "0xA19134")]
		private void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA18F28", Offset = "0xA18F28", VA = "0xA18F28")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA19300", Offset = "0xA19300", VA = "0xA19300")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA19364", Offset = "0xA19364", VA = "0xA19364", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA193C8", Offset = "0xA193C8", VA = "0xA193C8")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA196A4", Offset = "0xA196A4", VA = "0xA196A4", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA196A8", Offset = "0xA196A8", VA = "0xA196A8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA19740", Offset = "0xA19740", VA = "0xA19740", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA19744", Offset = "0xA19744", VA = "0xA19744", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA1975C", Offset = "0xA1975C", VA = "0xA1975C")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA198AC", Offset = "0xA198AC", VA = "0xA198AC", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA19A28", Offset = "0xA19A28", VA = "0xA19A28")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
	[ExecuteInEditMode]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x200007D")]
		public class HitResult
		{
			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000053")]
			public bool hasCollider
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0xA1A8E0", Offset = "0xA1A8E0", VA = "0xA1A8E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000054")]
			public string name
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0xA1B2AC", Offset = "0xA1B2AC", VA = "0xA1B2AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			public Bounds bounds
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0xA1B370", Offset = "0xA1B370", VA = "0xA1B370")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0xA1A550", Offset = "0xA1A550", VA = "0xA1A550")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xA1A664", Offset = "0xA1A664", VA = "0xA1A664")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xA1A5D4", Offset = "0xA1A5D4", VA = "0xA1A5D4")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x200007E")]
		private enum Direction
		{
			[Token(Token = "0x4000258")]
			Up = 0,
			[Token(Token = "0x4000259")]
			Down = 1,
			[Token(Token = "0x400025A")]
			Left = 2,
			[Token(Token = "0x400025B")]
			Right = 3,
			[Token(Token = "0x400025C")]
			Max2D = 1,
			[Token(Token = "0x400025D")]
			Max3D = 3
		}

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dimensions dimensions;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask layerMask;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool considerTriggers;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float minOccluderArea;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float minSurfaceRatio;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float maxSurfaceDot;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float planeOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700004E")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0xA19ADC", Offset = "0xA19ADC", VA = "0xA19ADC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xA19AE4", Offset = "0xA19AE4", VA = "0xA19AE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xA19C00", Offset = "0xA19C00", VA = "0xA19C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xA19C08", Offset = "0xA19C08", VA = "0xA19C08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xA19C58", Offset = "0xA19C58", VA = "0xA19C58")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xA19C64", Offset = "0xA19C64", VA = "0xA19C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xA19EE0", Offset = "0xA19EE0", VA = "0xA19EE0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000052")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xA19EF4", Offset = "0xA19EF4", VA = "0xA19EF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA19AEC", Offset = "0xA19AEC", VA = "0xA19AEC")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA19C10", Offset = "0xA19C10", VA = "0xA19C10", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA19C50", Offset = "0xA19C50", VA = "0xA19C50", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA19C70", Offset = "0xA19C70", VA = "0xA19C70", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA19CAC", Offset = "0xA19CAC", VA = "0xA19CAC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xA19CB8", Offset = "0xA19CB8", VA = "0xA19CB8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA19D84", Offset = "0xA19D84", VA = "0xA19D84")]
		private void Start()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA19E30", Offset = "0xA19E30", VA = "0xA19E30")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA19F2C", Offset = "0xA19F2C", VA = "0xA19F2C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA19F40", Offset = "0xA19F40", VA = "0xA19F40")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA1A1E4", Offset = "0xA1A1E4", VA = "0xA1A1E4")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA1A6E8", Offset = "0xA1A6E8", VA = "0xA1A6E8")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA1A700", Offset = "0xA1A700", VA = "0xA1A700")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA1A864", Offset = "0xA1A864", VA = "0xA1A864")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA1A9E0", Offset = "0xA1A9E0", VA = "0xA1A9E0", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA19CE0", Offset = "0xA19CE0", VA = "0xA19CE0")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA1AEB0", Offset = "0xA1AEB0", VA = "0xA1AEB0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA1ADA0", Offset = "0xA1ADA0", VA = "0xA1ADA0")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA1AD68", Offset = "0xA1AD68", VA = "0xA1AD68")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA1B1E0", Offset = "0xA1B1E0", VA = "0xA1B1E0")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA1B1EC", Offset = "0xA1B1EC", VA = "0xA1B1EC")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public enum ColorMode
	{
		[Token(Token = "0x400025F")]
		Flat,
		[Token(Token = "0x4000260")]
		Gradient
	}
	[Token(Token = "0x2000080")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000262")]
		Linear,
		[Token(Token = "0x4000263")]
		Quadratic,
		[Token(Token = "0x4000264")]
		Blend
	}
	[Token(Token = "0x2000081")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000266")]
		Additive,
		[Token(Token = "0x4000267")]
		SoftAdditive,
		[Token(Token = "0x4000268")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000082")]
	public enum NoiseMode
	{
		[Token(Token = "0x400026A")]
		Disabled,
		[Token(Token = "0x400026B")]
		WorldSpace,
		[Token(Token = "0x400026C")]
		LocalSpace
	}
	[Token(Token = "0x2000083")]
	public enum MeshType
	{
		[Token(Token = "0x400026E")]
		Shared,
		[Token(Token = "0x400026F")]
		Custom
	}
	[Token(Token = "0x2000084")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000271")]
		BuiltIn,
		[Token(Token = "0x4000272")]
		URP,
		[Token(Token = "0x4000273")]
		HDRP
	}
	[Token(Token = "0x2000085")]
	public enum RenderingMode
	{
		[Token(Token = "0x4000275")]
		MultiPass,
		[Token(Token = "0x4000276")]
		SinglePass,
		[Token(Token = "0x4000277")]
		GPUInstancing,
		[Token(Token = "0x4000278")]
		SRPBatcher
	}
	[Token(Token = "0x2000086")]
	public enum RenderQueue
	{
		[Token(Token = "0x400027A")]
		Custom = 0,
		[Token(Token = "0x400027B")]
		Background = 1000,
		[Token(Token = "0x400027C")]
		Geometry = 2000,
		[Token(Token = "0x400027D")]
		AlphaTest = 2450,
		[Token(Token = "0x400027E")]
		GeometryLast = 2500,
		[Token(Token = "0x400027F")]
		Transparent = 3000,
		[Token(Token = "0x4000280")]
		Overlay = 4000
	}
	[Token(Token = "0x2000087")]
	public enum Dimensions
	{
		[Token(Token = "0x4000282")]
		Dim3D,
		[Token(Token = "0x4000283")]
		Dim2D
	}
	[Token(Token = "0x2000088")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000285")]
		Surface,
		[Token(Token = "0x4000286")]
		Beam
	}
	[Token(Token = "0x2000089")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x4000288")]
		Never = 1,
		[Token(Token = "0x4000289")]
		OnEnable = 2,
		[Token(Token = "0x400028A")]
		OnBeamMove = 4,
		[Token(Token = "0x400028B")]
		EveryXFrames = 8,
		[Token(Token = "0x400028C")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200008A")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA157A0", Offset = "0xA157A0", VA = "0xA157A0")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA1B458", Offset = "0xA1B458", VA = "0xA1B458")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA1B524", Offset = "0xA1B524", VA = "0xA1B524")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public static class MaterialManager
	{
		[Token(Token = "0x200008D")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000296")]
			Additive,
			[Token(Token = "0x4000297")]
			SoftAdditive,
			[Token(Token = "0x4000298")]
			TraditionalTransparency,
			[Token(Token = "0x4000299")]
			Count
		}

		[Token(Token = "0x200008E")]
		public enum Noise3D
		{
			[Token(Token = "0x400029B")]
			Off,
			[Token(Token = "0x400029C")]
			On,
			[Token(Token = "0x400029D")]
			Count
		}

		[Token(Token = "0x200008F")]
		public enum DepthBlend
		{
			[Token(Token = "0x400029F")]
			Off,
			[Token(Token = "0x40002A0")]
			On,
			[Token(Token = "0x40002A1")]
			Count
		}

		[Token(Token = "0x2000090")]
		public enum ColorGradient
		{
			[Token(Token = "0x40002A3")]
			Off,
			[Token(Token = "0x40002A4")]
			MatrixLow,
			[Token(Token = "0x40002A5")]
			MatrixHigh,
			[Token(Token = "0x40002A6")]
			Count
		}

		[Token(Token = "0x2000091")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x40002A8")]
			Off,
			[Token(Token = "0x40002A9")]
			ClippingPlane,
			[Token(Token = "0x40002AA")]
			DepthTexture,
			[Token(Token = "0x40002AB")]
			Count
		}

		[Token(Token = "0x2000092")]
		public class StaticProperties
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x17000056")]
			public int materialID
			{
				[Token(Token = "0x60002A8")]
				[Address(RVA = "0xA1B6BC", Offset = "0xA1B6BC", VA = "0xA1B6BC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xA16158", Offset = "0xA16158", VA = "0xA16158")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA16138", Offset = "0xA16138", VA = "0xA16138")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000093")]
		private class MaterialsGroup
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xA1B62C", Offset = "0xA1B62C", VA = "0xA1B62C")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA14980", Offset = "0xA14980", VA = "0xA14980")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA1B52C", Offset = "0xA1B52C", VA = "0xA1B52C")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA163C0", Offset = "0xA163C0", VA = "0xA163C0")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40002B2")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA1B8C0", Offset = "0xA1B8C0", VA = "0xA1B8C0")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA1B8D8", Offset = "0xA1B8D8", VA = "0xA1B8D8")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA1B948", Offset = "0xA1B948", VA = "0xA1B948")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA14FB4", Offset = "0xA14FB4", VA = "0xA14FB4")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA1B9B4", Offset = "0xA1B9B4", VA = "0xA1B9B4")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA1B9D0", Offset = "0xA1B9D0", VA = "0xA1B9D0")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA1B9F8", Offset = "0xA1B9F8", VA = "0xA1B9F8")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA1BA58", Offset = "0xA1BA58", VA = "0xA1BA58")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000095")]
	public static class Noise3D
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40002B6")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40002B7")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000057")]
		public static bool isSupported
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xA15FD4", Offset = "0xA15FD4", VA = "0xA15FD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xA1BB60", Offset = "0xA1BB60", VA = "0xA1BB60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xA1BABC", Offset = "0xA1BABC", VA = "0xA1BABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA1BBD8", Offset = "0xA1BBD8", VA = "0xA1BBD8")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA16D1C", Offset = "0xA16D1C", VA = "0xA16D1C")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA1BBDC", Offset = "0xA1BBDC", VA = "0xA1BBDC")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000097")]
		public struct Plane2D
		{
			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xA1BE84", Offset = "0xA1BE84", VA = "0xA1BE84")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xA1BEA0", Offset = "0xA1BEA0", VA = "0xA1BEA0")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xA1BECC", Offset = "0xA1BECC", VA = "0xA1BECC")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xA1BF5C", Offset = "0xA1BF5C", VA = "0xA1BF5C")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xA1BF80", Offset = "0xA1BF80", VA = "0xA1BF80")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xA1C078", Offset = "0xA1C078", VA = "0xA1C078")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xA1C088", Offset = "0xA1C088", VA = "0xA1C088")]
			public void Flip()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xA1C0A4", Offset = "0xA1C0A4", VA = "0xA1C0A4")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA1C278", Offset = "0xA1C278", VA = "0xA1C278", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA1BE7C", Offset = "0xA1BE7C", VA = "0xA1BE7C")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DrawCap;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int CameraParams;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int GlobalNoiseParam;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalDitheringNoiseTex;

		[Token(Token = "0x40002DB")]
		public const string KeywordSRP = "VLB_SRP_API";
	}
	[Token(Token = "0x2000099")]
	public static class TransformUtils
	{
		[Token(Token = "0x200009A")]
		public class Packed
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xA1C944", Offset = "0xA1C944", VA = "0xA1C944")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA185AC", Offset = "0xA185AC", VA = "0xA185AC")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA18D54", Offset = "0xA18D54", VA = "0xA18D54")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009B")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x40002E6")]
			OnEnable,
			[Token(Token = "0x40002E7")]
			OnOcclusionChange
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40002E1")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x1700005A")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xA1C94C", Offset = "0xA1C94C", VA = "0xA1C94C")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA1C9D0", Offset = "0xA1C9D0", VA = "0xA1C9D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA1D04C", Offset = "0xA1D04C", VA = "0xA1D04C")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA1CB38", Offset = "0xA1CB38", VA = "0xA1CB38")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA1D0C8", Offset = "0xA1D0C8", VA = "0xA1D0C8")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public static class Utils
	{
		[Token(Token = "0x200009E")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40002EB")]
			High = 64,
			[Token(Token = "0x40002EC")]
			Low = 8,
			[Token(Token = "0x40002ED")]
			Undef = 0
		}

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40002E9")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA1D0E0", Offset = "0xA1D0E0", VA = "0xA1D0E0")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60002CE")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA14C30", Offset = "0xA14C30", VA = "0xA14C30")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA1D114", Offset = "0xA1D114", VA = "0xA1D114")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA1D1E4", Offset = "0xA1D1E4", VA = "0xA1D1E4")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA1D1E8", Offset = "0xA1D1E8", VA = "0xA1D1E8")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA1D1F0", Offset = "0xA1D1F0", VA = "0xA1D1F0")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA1D1FC", Offset = "0xA1D1FC", VA = "0xA1D1FC")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA1D20C", Offset = "0xA1D20C", VA = "0xA1D20C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA1D218", Offset = "0xA1D218", VA = "0xA1D218")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA1D220", Offset = "0xA1D220", VA = "0xA1D220")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA1A4C0", Offset = "0xA1A4C0", VA = "0xA1A4C0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA1D268", Offset = "0xA1D268", VA = "0xA1D268")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA1D270", Offset = "0xA1D270", VA = "0xA1D270")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA1B074", Offset = "0xA1B074", VA = "0xA1B074")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA1D050", Offset = "0xA1D050", VA = "0xA1D050")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA1BF44", Offset = "0xA1BF44", VA = "0xA1BF44")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA19BB8", Offset = "0xA19BB8", VA = "0xA19BB8")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA16B60", Offset = "0xA16B60", VA = "0xA16B60")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA1D600", Offset = "0xA1D600", VA = "0xA1D600")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA16C3C", Offset = "0xA16C3C", VA = "0xA16C3C")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA1D670", Offset = "0xA1D670", VA = "0xA1D670")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA1D754", Offset = "0xA1D754", VA = "0xA1D754")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA1D614", Offset = "0xA1D614", VA = "0xA1D614")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA160C8", Offset = "0xA160C8", VA = "0xA160C8")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA1D768", Offset = "0xA1D768", VA = "0xA1D768")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA1D76C", Offset = "0xA1D76C", VA = "0xA1D76C")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public static class Version
	{
		[Token(Token = "0x40002EE")]
		public const int Current = 1870;
	}
	[Token(Token = "0x20000A0")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		public enum Direction
		{
			[Token(Token = "0x4000300")]
			Beam,
			[Token(Token = "0x4000301")]
			Random
		}

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float alpha;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0.0001f, 0.1f)]
		public float size;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float spawnMinDistance;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float spawnMaxDistance;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700005B")]
		public bool isCulled
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xA1D770", Offset = "0xA1D770", VA = "0xA1D770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA1D778", Offset = "0xA1D778", VA = "0xA1D778")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA1D784", Offset = "0xA1D784", VA = "0xA1D784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA1D7E0", Offset = "0xA1D7E0", VA = "0xA1D7E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA1D864", Offset = "0xA1D864", VA = "0xA1D864")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		public Camera mainCamera
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA1D900", Offset = "0xA1D900", VA = "0xA1D900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA1DB1C", Offset = "0xA1DB1C", VA = "0xA1DB1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA1DB98", Offset = "0xA1DB98", VA = "0xA1DB98")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA1DE1C", Offset = "0xA1DE1C", VA = "0xA1DE1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA1DD70", Offset = "0xA1DD70", VA = "0xA1DD70")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA1E460", Offset = "0xA1E460", VA = "0xA1E460")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA1E4F0", Offset = "0xA1E4F0", VA = "0xA1E4F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA1E598", Offset = "0xA1E598", VA = "0xA1E598")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA1DE20", Offset = "0xA1DE20", VA = "0xA1DE20")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA1E5C0", Offset = "0xA1E5C0", VA = "0xA1E5C0")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA1E914", Offset = "0xA1E914", VA = "0xA1E914")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x20000A4")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class <CoPlaytimeUpdate>d__161 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0xA1FE10", Offset = "0xA1FE10", VA = "0xA1FE10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0xA1FE58", Offset = "0xA1FE58", VA = "0xA1FE58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0xA1F90C", Offset = "0xA1F90C", VA = "0xA1F90C")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__161(int <>1__state)
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0xA1FD7C", Offset = "0xA1FD7C", VA = "0xA1FD7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0xA1FD80", Offset = "0xA1FD80", VA = "0xA1FD80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0xA1FE18", Offset = "0xA1FE18", VA = "0xA1FE18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 8f)]
		[FormerlySerializedAs("alphaInside")]
		public float intensityInside;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Range(0f, 8f)]
		public float intensityOutside;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float glareFrontal;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float glareBehind;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dimensions dimensions;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000060")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xA1E9A8", Offset = "0xA1E9A8", VA = "0xA1E9A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xA1E9B0", Offset = "0xA1E9B0", VA = "0xA1E9B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xA1E9B8", Offset = "0xA1E9B8", VA = "0xA1E9B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xA1E9C0", Offset = "0xA1E9C0", VA = "0xA1E9C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xA1E9C8", Offset = "0xA1E9C8", VA = "0xA1E9C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xA1E9D0", Offset = "0xA1E9D0", VA = "0xA1E9D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public float coneAngle
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xA16B80", Offset = "0xA16B80", VA = "0xA16B80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000064")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xA15E84", Offset = "0xA15E84", VA = "0xA15E84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public float coneVolume
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xA1E9D8", Offset = "0xA1E9D8", VA = "0xA1E9D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000066")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xA16BDC", Offset = "0xA16BDC", VA = "0xA16BDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000067")]
		public int geomSides
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xA1EA34", Offset = "0xA1EA34", VA = "0xA1EA34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xA1EA6C", Offset = "0xA1EA6C", VA = "0xA1EA6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int geomSegments
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA1EAE8", Offset = "0xA1EAE8", VA = "0xA1EAE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA1EB20", Offset = "0xA1EB20", VA = "0xA1EB20")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA1EB9C", Offset = "0xA1EB9C", VA = "0xA1EB9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA1EBA4", Offset = "0xA1EBA4", VA = "0xA1EBA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA16CF4", Offset = "0xA16CF4", VA = "0xA16CF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006B")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xA1EBB0", Offset = "0xA1EBB0", VA = "0xA1EBB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xA1EBB8", Offset = "0xA1EBB8", VA = "0xA1EBB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA1EBC0", Offset = "0xA1EBC0", VA = "0xA1EBC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA1EBC8", Offset = "0xA1EBC8", VA = "0xA1EBC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA13B98", Offset = "0xA13B98", VA = "0xA13B98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA1EBD0", Offset = "0xA1EBD0", VA = "0xA1EBD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA1EBE0", Offset = "0xA1EBE0", VA = "0xA1EBE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA1EBFC", Offset = "0xA1EBFC", VA = "0xA1EBFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0xA1EC04", Offset = "0xA1EC04", VA = "0xA1EC04")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xA1EC60", Offset = "0xA1EC60", VA = "0xA1EC60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA1EC68", Offset = "0xA1EC68", VA = "0xA1EC68")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xA13DA4", Offset = "0xA13DA4", VA = "0xA13DA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0xA1EC70", Offset = "0xA1EC70", VA = "0xA1EC70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xA1EC78", Offset = "0xA1EC78", VA = "0xA1EC78")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public string sortingLayerName
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xA1ED18", Offset = "0xA1ED18", VA = "0xA1ED18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA1ED24", Offset = "0xA1ED24", VA = "0xA1ED24")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public int sortingOrder
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xA1ED48", Offset = "0xA1ED48", VA = "0xA1ED48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA1ED50", Offset = "0xA1ED50", VA = "0xA1ED50")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA1EDF0", Offset = "0xA1EDF0", VA = "0xA1EDF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xA1EDF8", Offset = "0xA1EDF8", VA = "0xA1EDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0xA1EE6C", Offset = "0xA1EE6C", VA = "0xA1EE6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xA1E7A4", Offset = "0xA1E7A4", VA = "0xA1E7A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public Bounds bounds
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xA1E804", Offset = "0xA1E804", VA = "0xA1E804")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000079")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xA1EE7C", Offset = "0xA1EE7C", VA = "0xA1EE7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007A")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xA15EBC", Offset = "0xA15EBC", VA = "0xA15EBC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700007B")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xA191D0", Offset = "0xA191D0", VA = "0xA191D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xA1A970", Offset = "0xA1A970", VA = "0xA1A970")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007D")]
		public Vector3 beamGlobalUp
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xA1A784", Offset = "0xA1A784", VA = "0xA1A784")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007E")]
		public Vector3 beamGlobalRight
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xA1A7F4", Offset = "0xA1A7F4", VA = "0xA1A7F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007F")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xA1926C", Offset = "0xA1926C", VA = "0xA1926C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000080")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xA1EF54", Offset = "0xA1EF54", VA = "0xA1EF54")]
			[CompilerGenerated]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xA1EF5C", Offset = "0xA1EF5C", VA = "0xA1EF5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xA16140", Offset = "0xA16140", VA = "0xA16140")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000082")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xA1F034", Offset = "0xA1F034", VA = "0xA1F034")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA1F03C", Offset = "0xA1F03C", VA = "0xA1F03C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public string meshStats
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA1F044", Offset = "0xA1F044", VA = "0xA1F044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA1F1E4", Offset = "0xA1F1E4", VA = "0xA1F1E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0xA1F29C", Offset = "0xA1F29C", VA = "0xA1F29C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000086")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0xA1F370", Offset = "0xA1F370", VA = "0xA1F370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0xA18910", Offset = "0xA18910", VA = "0xA18910")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xA18BC0", Offset = "0xA18BC0", VA = "0xA18BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA18508", Offset = "0xA18508", VA = "0xA18508")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xA174A4", Offset = "0xA174A4", VA = "0xA174A4")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA18A54", Offset = "0xA18A54", VA = "0xA18A54")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA1EF64", Offset = "0xA1EF64", VA = "0xA1EF64")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA1EC0C", Offset = "0xA1EC0C", VA = "0xA1EC0C")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA1EFA0", Offset = "0xA1EFA0", VA = "0xA1EFA0")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA1F468", Offset = "0xA1F468", VA = "0xA1F468")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA174C0", Offset = "0xA174C0", VA = "0xA174C0")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA1F4BC", Offset = "0xA1F4BC", VA = "0xA1F4BC")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA1F4C8", Offset = "0xA1F4C8", VA = "0xA1F4C8", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xA1F6F0", Offset = "0xA1F6F0", VA = "0xA1F6F0", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA1F774", Offset = "0xA1F774", VA = "0xA1F774")]
		private void Start()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA1F780", Offset = "0xA1F780", VA = "0xA1F780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA1F808", Offset = "0xA1F808", VA = "0xA1F808")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA1EE04", Offset = "0xA1EE04", VA = "0xA1EE04")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA1F898", Offset = "0xA1F898", VA = "0xA1F898")]
		[IteratorStateMachine(typeof(<CoPlaytimeUpdate>d__161))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA1F934", Offset = "0xA1F934", VA = "0xA1F934")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA1F938", Offset = "0xA1F938", VA = "0xA1F938")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA1F9E0", Offset = "0xA1F9E0", VA = "0xA1F9E0")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA1FAD0", Offset = "0xA1FAD0", VA = "0xA1FAD0")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA1F6CC", Offset = "0xA1F6CC", VA = "0xA1F6CC")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA1F5F0", Offset = "0xA1F5F0", VA = "0xA1F5F0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA1FC00", Offset = "0xA1FC00", VA = "0xA1FC00")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x20000A6")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA1FE60", Offset = "0xA1FE60", VA = "0xA1FE60")]
		private void Update()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA1FF24", Offset = "0xA1FF24", VA = "0xA1FF24")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA1FF34", Offset = "0xA1FF34", VA = "0xA1FF34")]
		private void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA20024", Offset = "0xA20024", VA = "0xA20024")]
		private void Update()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA200D8", Offset = "0xA200D8", VA = "0xA200D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA200E0", Offset = "0xA200E0", VA = "0xA200E0")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA201A0", Offset = "0xA201A0", VA = "0xA201A0")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA201A8", Offset = "0xA201A8", VA = "0xA201A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA20210", Offset = "0xA20210", VA = "0xA20210")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000089")]
		private bool useMouseView
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0xA20218", Offset = "0xA20218", VA = "0xA20218")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0xA20220", Offset = "0xA20220", VA = "0xA20220")]
			set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA20250", Offset = "0xA20250", VA = "0xA20250")]
		private void Start()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA202E0", Offset = "0xA202E0", VA = "0xA202E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA208BC", Offset = "0xA208BC", VA = "0xA208BC")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(1f, 100f)]
		private int CountX;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA208E0", Offset = "0xA208E0", VA = "0xA208E0")]
		public void Generate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA20F64", Offset = "0xA20F64", VA = "0xA20F64")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA20F80", Offset = "0xA20F80", VA = "0xA20F80")]
		private void Update()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA21050", Offset = "0xA21050", VA = "0xA21050")]
		public Rotater()
		{
		}
	}
}
namespace UnityEngine.UI
{
	[Token(Token = "0x20000AC")]
	[AddComponentMenu("UI/Raycast Filters/Ignore Raycast Filter")]
	public class UIIgnoreRaycast : MonoBehaviour, ICanvasRaycastFilter
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA210B0", Offset = "0xA210B0", VA = "0xA210B0", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA210B8", Offset = "0xA210B8", VA = "0xA210B8")]
		public UIIgnoreRaycast()
		{
		}
	}
}
namespace Wacki
{
	[Token(Token = "0x20000AD")]
	public abstract class IUILaserPointer : MonoBehaviour
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float laserThickness;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float laserHitScale;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool laserAlwaysOn;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color color;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject hitPoint;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject pointer;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _distanceLimit;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA210C0", Offset = "0xA210C0", VA = "0xA210C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA21550", Offset = "0xA21550", VA = "0xA21550")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA2168C", Offset = "0xA2168C", VA = "0xA2168C", Slot = "4")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA21690", Offset = "0xA21690", VA = "0xA21690", Slot = "5")]
		public virtual void OnEnterControl(GameObject control)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA21694", Offset = "0xA21694", VA = "0xA21694", Slot = "6")]
		public virtual void OnExitControl(GameObject control)
		{
		}

		[Token(Token = "0x6000374")]
		public abstract bool ButtonDown();

		[Token(Token = "0x6000375")]
		public abstract bool ButtonUp();

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA21698", Offset = "0xA21698", VA = "0xA21698", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA21874", Offset = "0xA21874", VA = "0xA21874", Slot = "10")]
		public virtual void LimitLaserDistance(float distance)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA21898", Offset = "0xA21898", VA = "0xA21898")]
		protected IUILaserPointer()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class LaserPointerEventData : PointerEventData
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public GameObject current;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public IUILaserPointer controller;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA218AC", Offset = "0xA218AC", VA = "0xA218AC")]
		public LaserPointerEventData(EventSystem e)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA218B4", Offset = "0xA218B4", VA = "0xA218B4", Slot = "4")]
		public override void Reset()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class LaserPointerInputModule : BaseInputModule
	{
		[Token(Token = "0x20000B0")]
		private class ControllerData
		{
			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LaserPointerEventData pointerEvent;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject currentPoint;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject currentPressed;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject currentDragging;

			[Token(Token = "0x6000385")]
			[Address(RVA = "0xA23160", Offset = "0xA23160", VA = "0xA23160")]
			public ControllerData()
			{
			}
		}

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LaserPointerInputModule _instance;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LayerMask layerMask;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera UICamera;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PhysicsRaycaster raycaster;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HashSet<IUILaserPointer> _controllers;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<IUILaserPointer, ControllerData> _controllerData;

		[Token(Token = "0x1700008A")]
		public static LaserPointerInputModule instance
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xA218EC", Offset = "0xA218EC", VA = "0xA218EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA21934", Offset = "0xA21934", VA = "0xA21934", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA21A58", Offset = "0xA21A58", VA = "0xA21A58", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA214BC", Offset = "0xA214BC", VA = "0xA214BC")]
		public void AddController(IUILaserPointer controller)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA21634", Offset = "0xA21634", VA = "0xA21634")]
		public void RemoveController(IUILaserPointer controller)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA21C08", Offset = "0xA21C08", VA = "0xA21C08")]
		protected void UpdateCameraPosition(IUILaserPointer controller)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA21CA0", Offset = "0xA21CA0", VA = "0xA21CA0")]
		public void ClearSelection()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA21D2C", Offset = "0xA21D2C", VA = "0xA21D2C")]
		private void Select(GameObject go)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA21E10", Offset = "0xA21E10", VA = "0xA21E10", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA230D8", Offset = "0xA230D8", VA = "0xA230D8")]
		public LaserPointerInputModule()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class OVRUILaserPointer : IUILaserPointer
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public OVRInput.Button primaryTrigger;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVRInput.Controller controller;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private OVRHapticsClip enterHapticClip;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private OVRHapticsClip exitHapticClip;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA23168", Offset = "0xA23168", VA = "0xA23168", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA232C4", Offset = "0xA232C4", VA = "0xA232C4", Slot = "7")]
		public override bool ButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA23324", Offset = "0xA23324", VA = "0xA23324", Slot = "8")]
		public override bool ButtonUp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA23384", Offset = "0xA23384", VA = "0xA23384", Slot = "5")]
		public override void OnEnterControl(GameObject control)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA23454", Offset = "0xA23454", VA = "0xA23454", Slot = "6")]
		public override void OnExitControl(GameObject control)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA23184", Offset = "0xA23184", VA = "0xA23184")]
		private void InitHaptics()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA23524", Offset = "0xA23524", VA = "0xA23524")]
		private void WriteHapticSamples(OVRHapticsClip clip, float freq, float amplitude, int duration)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA23694", Offset = "0xA23694", VA = "0xA23694")]
		public OVRUILaserPointer()
		{
		}
	}
}
namespace CloudFine
{
	[Token(Token = "0x20000B2")]
	public class Billboard : MonoBehaviour
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA2369C", Offset = "0xA2369C", VA = "0xA2369C")]
		private void Update()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA23838", Offset = "0xA23838", VA = "0xA23838")]
		public Billboard()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class CollisionListener : MonoBehaviour
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Collision> CollisionEnter;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Collision> CollisionExit;

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA23840", Offset = "0xA23840", VA = "0xA23840")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA2385C", Offset = "0xA2385C", VA = "0xA2385C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA23878", Offset = "0xA23878", VA = "0xA23878")]
		public CollisionListener()
		{
		}
	}
}
namespace CloudFine.ThrowLab
{
	[Token(Token = "0x20000B4")]
	public enum Device
	{
		[Token(Token = "0x4000361")]
		UNSPECIFIED,
		[Token(Token = "0x4000362")]
		OCULUS_TOUCH,
		[Token(Token = "0x4000363")]
		VIVE,
		[Token(Token = "0x4000364")]
		KNUCKLES,
		[Token(Token = "0x4000365")]
		WINDOWS_MR
	}
	[Token(Token = "0x20000B5")]
	public enum HandSide
	{
		[Token(Token = "0x4000367")]
		RIGHT,
		[Token(Token = "0x4000368")]
		LEFT
	}
	[Token(Token = "0x20000B6")]
	public static class DeviceDetectionUtility
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Device, Vector3> _centerOfMassOfssets;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA23880", Offset = "0xA23880", VA = "0xA23880")]
		public static Vector3 GetCenterOfMassOffset(Device controller, HandSide side)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000B7")]
	public abstract class DeviceDetector : MonoBehaviour
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandSide _side;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Device _detected;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _drawGizmo;

		[Token(Token = "0x1700008B")]
		public HandSide Side
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0xA23BF4", Offset = "0xA23BF4", VA = "0xA23BF4")]
			get
			{
				return default(HandSide);
			}
		}

		[Token(Token = "0x1700008C")]
		public Device DetectedDevice
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0xA23BFC", Offset = "0xA23BFC", VA = "0xA23BFC")]
			get
			{
				return default(Device);
			}
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA23C04", Offset = "0xA23C04", VA = "0xA23C04")]
		protected void OnControllerTypeDetermined(Device device)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA23C0C", Offset = "0xA23C0C", VA = "0xA23C0C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xA23CCC", Offset = "0xA23CCC", VA = "0xA23CCC")]
		protected DeviceDetector()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class GrabThresholdModifier : MonoBehaviour
	{
		[Token(Token = "0x600039A")]
		public abstract float GripValue();

		[Token(Token = "0x600039B")]
		public abstract void SetGrabThreshold(float grip);

		[Token(Token = "0x600039C")]
		public abstract void SetReleaseThreshold(float grip);

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA23CDC", Offset = "0xA23CDC", VA = "0xA23CDC")]
		protected GrabThresholdModifier()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class LabManager : MonoBehaviour
	{
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Spawn")]
		public List<ThrowHandle> _throwablePrefabs;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform _spawnPoint;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem _spawnEffect;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ThrowHandle _throwablePrefab;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ThrowTracker _trackerPrefab;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("UI")]
		public UIThrowConfiguration _configurationUI;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DeviceDetectorUI _deviceDetector;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RectTransform _trackerUIListRoot;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text _throwableLabel;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Lines")]
		public Texture2D[] _lineTextures;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color[] _lineColors;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Variants")]
		public GameObject variantPanelRoot;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Image[] tabFills;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Button variantResetButton;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Button variantSaveButton;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject warningNoConfigs;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Toggle variantEnabledToggle;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Toggle variantLineEnabledToggle;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Toggle variantSamplesEnabledToggle;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _throwableIndex;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Device _device;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<ThrowTracker> _trackers;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Dictionary<ThrowConfiguration, ThrowConfiguration[]> _tempConfigVariants;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ThrowHandle _currentSpawn;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int currentConfigIndex;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ThrowConfiguration[] configSet;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ThrowConfiguration original;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Color[] colorSet;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool[] configEnabled;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool[] showSamples;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool[] showLine;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA23CE4", Offset = "0xA23CE4", VA = "0xA23CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA23DCC", Offset = "0xA23DCC", VA = "0xA23DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA243A8", Offset = "0xA243A8", VA = "0xA243A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA24CA8", Offset = "0xA24CA8", VA = "0xA24CA8")]
		private void SetDevice(Device device)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA244F4", Offset = "0xA244F4", VA = "0xA244F4")]
		public void SpawnTrackedThrowable()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA2586C", Offset = "0xA2586C", VA = "0xA2586C")]
		private void RespawnThrowable()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA25910", Offset = "0xA25910", VA = "0xA25910")]
		public void SetCurrentConfigEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA242D0", Offset = "0xA242D0", VA = "0xA242D0")]
		public void SetConfigEnabled(int i, bool enabled)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA259F0", Offset = "0xA259F0", VA = "0xA259F0")]
		public void SetCurrentLineEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA25A00", Offset = "0xA25A00", VA = "0xA25A00")]
		public void SetLineEnabled(int i, bool enabled)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xA25A34", Offset = "0xA25A34", VA = "0xA25A34")]
		public void SetCurrentSampleVisEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA25A44", Offset = "0xA25A44", VA = "0xA25A44")]
		public void SetSampleVisualizationEnabled(int i, bool enabled)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA25A78", Offset = "0xA25A78", VA = "0xA25A78")]
		public void SaveCurrentConfig()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA25D0C", Offset = "0xA25D0C", VA = "0xA25D0C")]
		public void ResetCurrentConfig()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xA25E7C", Offset = "0xA25E7C", VA = "0xA25E7C")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA26190", Offset = "0xA26190", VA = "0xA26190")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA26194", Offset = "0xA26194", VA = "0xA26194")]
		public void CycleThrowableRight()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xA2620C", Offset = "0xA2620C", VA = "0xA2620C")]
		public void CycleThrowableLeft()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xA23ED8", Offset = "0xA23ED8", VA = "0xA23ED8")]
		private void SelectThrowable(int i)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xA25D58", Offset = "0xA25D58", VA = "0xA25D58")]
		public void LoadConfig(int i)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xA25978", Offset = "0xA25978", VA = "0xA25978")]
		public void ReloadCurrentConfig()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xA26C64", Offset = "0xA26C64", VA = "0xA26C64")]
		public LabManager()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[CreateAssetMenu(fileName = "NewThrowConfig", menuName = "ThrowLab/ThrowConfiguration", order = 1)]
	public class ThrowConfiguration : ScriptableObject
	{
		[Token(Token = "0x20000BB")]
		public enum EstimationAlgorithm
		{
			[Token(Token = "0x40003A8")]
			SIMPLE_AVERAGE,
			[Token(Token = "0x40003A9")]
			WEIGHTED_AVERAGE,
			[Token(Token = "0x40003AA")]
			EXPONENTIAL_AVERAGE,
			[Token(Token = "0x40003AB")]
			CUSTOM_CURVE
		}

		[Token(Token = "0x20000BC")]
		public enum PeriodMeasurement
		{
			[Token(Token = "0x40003AD")]
			FRAMES,
			[Token(Token = "0x40003AE")]
			TIME
		}

		[Token(Token = "0x20000BD")]
		public enum SampleTime
		{
			[Token(Token = "0x40003B0")]
			SCALED,
			[Token(Token = "0x40003B1")]
			UNSCALED,
			[Token(Token = "0x40003B2")]
			FIXED
		}

		[Token(Token = "0x20000BE")]
		public enum VelocitySource
		{
			[Token(Token = "0x40003B4")]
			DEVICE_CENTER_OF_MASS,
			[Token(Token = "0x40003B5")]
			HAND_TRACKED_POSITION,
			[Token(Token = "0x40003B6")]
			OBJECT_CENTER,
			[Token(Token = "0x40003B7")]
			OBJECT_CUSTOM_OFFSET
		}

		[Token(Token = "0x20000BF")]
		public enum AssistTargetMethod
		{
			[Token(Token = "0x40003B9")]
			GAZE,
			[Token(Token = "0x40003BA")]
			NEAREST
		}

		[Token(Token = "0x20000C0")]
		public enum FalloffSource
		{
			[Token(Token = "0x40003BC")]
			TIME,
			[Token(Token = "0x40003BD")]
			DISTANCE,
			[Token(Token = "0x40003BE")]
			MIN_TIME_DIST
		}

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Velocity Smoothing")]
		public bool smoothingEnabled;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EstimationAlgorithm estimationFunction;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PeriodMeasurement samplePeriodMeasurement;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public SampleTime sampleTime;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int periodFrames;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float periodSeconds;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VelocitySource sampleSourceType;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve smoothingAverageCustomCurve;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Velocity Scaling")]
		public bool scaleEnabled;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float scaleMultiplier;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float scaleThreshold;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 5f)]
		public float scaleRampExponent;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useScaleRampCustomCurve;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve scaleRampCustomCurve;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Aim Assist")]
		public bool assistEnabled;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 1f)]
		public float assistWeight;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 180f)]
		public float assistRangeDegrees;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 5f)]
		public float assistRampExponent;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useAssistRampCustomCurve;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve assistRampCustomCurve;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AssistTargetMethod assistTargetMethod;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Header("Friction")]
		public bool frictionEnabled;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float frictionFalloffSeconds;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 5f)]
		public float frictionFalloffExponent;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool useFrictionFalloffCustomCurve;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve frictionFalloffCustomCurve;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private string uniqueID;

		[Token(Token = "0x1700008D")]
		private string path
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xA270B4", Offset = "0xA270B4", VA = "0xA270B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private string saveDirectory
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xA272F4", Offset = "0xA272F4", VA = "0xA272F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xA26EDC", Offset = "0xA26EDC", VA = "0xA26EDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA26F20", Offset = "0xA26F20", VA = "0xA26F20")]
		public float SampleAssistCurve(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA26FA0", Offset = "0xA26FA0", VA = "0xA26FA0")]
		public float SampleFrictionCurve(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA26FF8", Offset = "0xA26FF8", VA = "0xA26FF8")]
		public float SampleScalingCurve(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA26F64", Offset = "0xA26F64", VA = "0xA26F64")]
		private static float SampleExponentialCurve(float t, float exp, bool flip = false)
		{
			return default(float);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA2703C", Offset = "0xA2703C", VA = "0xA2703C")]
		public Vector3 GetEstimate(Vector3[] inputs, out float[] componentWeights)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xA27098", Offset = "0xA27098", VA = "0xA27098")]
		public float[] GetWeights(Vector3[] inputs)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xA26280", Offset = "0xA26280", VA = "0xA26280")]
		public ThrowConfiguration Clone()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA25AC4", Offset = "0xA25AC4", VA = "0xA25AC4")]
		public void CopyTo(ThrowConfiguration other)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA25C80", Offset = "0xA25C80", VA = "0xA25C80")]
		public void SaveToJSON()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA26EE0", Offset = "0xA26EE0", VA = "0xA26EE0")]
		public void LoadFromJSON()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA27340", Offset = "0xA27340", VA = "0xA27340")]
		public ThrowConfiguration()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class ThrowConfigurationSet
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ThrowConfiguration[] _deviceConfigurations;

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA275E8", Offset = "0xA275E8", VA = "0xA275E8")]
		public ThrowConfiguration GetConfigForDevice(Device device)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA277A8", Offset = "0xA277A8", VA = "0xA277A8")]
		public void SetConfigForDevice(Device device, ThrowConfiguration config)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA27810", Offset = "0xA27810", VA = "0xA27810")]
		public void SetConfigs(ThrowConfiguration[] set)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA27818", Offset = "0xA27818", VA = "0xA27818")]
		public ThrowConfigurationSet()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class ThrowHandle : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		public struct VelocitySample
		{
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 velocity;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotation;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 angularVelocity;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float time;

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xA287F0", Offset = "0xA287F0", VA = "0xA287F0")]
			public VelocitySample(Vector3 position, Vector3 velocity, Quaternion rotation, Vector3 angular, float time)
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private sealed class <IgnoreCollisionWithOtherRoutine>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThrowHandle <>4__this;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject other;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0xA2A43C", Offset = "0xA2A43C", VA = "0xA2A43C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0xA2A484", Offset = "0xA2A484", VA = "0xA2A484", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xA29688", Offset = "0xA29688", VA = "0xA29688")]
			[DebuggerHidden]
			public <IgnoreCollisionWithOtherRoutine>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xA2A2BC", Offset = "0xA2A2BC", VA = "0xA2A2BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xA2A2C0", Offset = "0xA2A2C0", VA = "0xA2A2C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xA2A444", Offset = "0xA2A444", VA = "0xA2A444", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onDetachFromHand;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<GameObject, GameObject> onPickUp;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Vector3> onFinalTrajectory;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<VelocitySample> OnSampleRecorded;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<ThrowHandle> OnDestroyHandle;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onFrictionApplied;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("_controllerConfigurations")]
		private ThrowConfiguration[] _deviceConfigurations;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ThrowConfigurationSet _throwConfigurationSet;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Device _attachedDevice;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _velocitySensor;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject _handCollisionRoot;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ThrowTarget currentTarget;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<VelocitySample> _velocityHistory;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _sampledPreviousPosition;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion _sampledPreviousRotation;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _rootMotionTransform;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 _rootVelocity;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 _previousRootPosition;

		[Token(Token = "0x1700008F")]
		public bool _attached
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xA27820", Offset = "0xA27820", VA = "0xA27820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xA27828", Offset = "0xA27828", VA = "0xA27828")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public float _timeOfRelease
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xA27834", Offset = "0xA27834", VA = "0xA27834")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xA2783C", Offset = "0xA2783C", VA = "0xA2783C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool _applyingInfluence
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xA27844", Offset = "0xA27844", VA = "0xA27844")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xA2784C", Offset = "0xA2784C", VA = "0xA2784C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool _frictionActive
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xA27858", Offset = "0xA27858", VA = "0xA27858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public ThrowConfiguration Settings
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xA278BC", Offset = "0xA278BC", VA = "0xA278BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA278DC", Offset = "0xA278DC", VA = "0xA278DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA27B30", Offset = "0xA27B30", VA = "0xA27B30")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA27A80", Offset = "0xA27A80", VA = "0xA27A80")]
		private void MigrateData()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA27B34", Offset = "0xA27B34", VA = "0xA27B34")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA28474", Offset = "0xA28474", VA = "0xA28474")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA285D8", Offset = "0xA285D8", VA = "0xA285D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA286A4", Offset = "0xA286A4", VA = "0xA286A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA28764", Offset = "0xA28764", VA = "0xA28764")]
		public ThrowConfigurationSet GetConfigSet()
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA2876C", Offset = "0xA2876C", VA = "0xA2876C")]
		public void SetConfigSet(ThrowConfigurationSet set)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA24CB8", Offset = "0xA24CB8", VA = "0xA24CB8")]
		public ThrowConfiguration GetConfigForDevice(Device device)
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA24CD0", Offset = "0xA24CD0", VA = "0xA24CD0")]
		public void SetConfigForDevice(Device device, ThrowConfiguration config)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xA27DCC", Offset = "0xA27DCC", VA = "0xA27DCC")]
		private void RecordVelocitySample(float deltaTime, float time)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xA28774", Offset = "0xA28774", VA = "0xA28774")]
		public Transform GetSampleSource()
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA2881C", Offset = "0xA2881C", VA = "0xA2881C")]
		private void ClearOldSamples()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xA289D0", Offset = "0xA289D0", VA = "0xA289D0")]
		public List<VelocitySample> GetSampleWeights(out float[] weights)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xA28B20", Offset = "0xA28B20", VA = "0xA28B20")]
		public void OnAttach(GameObject hand, GameObject collisionRoot)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xA28E9C", Offset = "0xA28E9C", VA = "0xA28E9C")]
		public void OnDetach()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA24CE8", Offset = "0xA24CE8", VA = "0xA24CE8")]
		public void SetPhysicsEnabled(bool collision)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA25748", Offset = "0xA25748", VA = "0xA25748")]
		public void IgnoreCollisionWithOther(GameObject other, bool ignore)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA295D8", Offset = "0xA295D8", VA = "0xA295D8")]
		public void IgnoreCollisionWithOtherForFixedUpdate(GameObject other)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA295F8", Offset = "0xA295F8", VA = "0xA295F8")]
		[IteratorStateMachine(typeof(<IgnoreCollisionWithOtherRoutine>d__56))]
		protected IEnumerator IgnoreCollisionWithOtherRoutine(GameObject other)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA29038", Offset = "0xA29038", VA = "0xA29038")]
		public Vector3 GetVelocityEstimate()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA29424", Offset = "0xA29424", VA = "0xA29424")]
		public Vector3 GetAngularVelocityEstimate()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA296B0", Offset = "0xA296B0", VA = "0xA296B0")]
		private Vector3 GetEstimate(Vector3[] inputs)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA280F0", Offset = "0xA280F0", VA = "0xA280F0")]
		private ThrowTarget FindBestGazeBasedThrowTarget(List<ThrowTarget> targets)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA29D8C", Offset = "0xA29D8C", VA = "0xA29D8C")]
		private ThrowTarget FindClosestThrowTarget(Vector3 origin, Vector3 rawVelocity, List<ThrowTarget> targets)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA29954", Offset = "0xA29954", VA = "0xA29954")]
		private Vector3 ApplyAssist(Vector3 rawVelocity, Vector3 origin, Vector3 targetPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xA296E4", Offset = "0xA296E4", VA = "0xA296E4")]
		private Vector3 ApplySpeedIncrease(Vector3 rawVelocity)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA2A0D0", Offset = "0xA2A0D0", VA = "0xA2A0D0")]
		public float GetHandFriction()
		{
			return default(float);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA284F8", Offset = "0xA284F8", VA = "0xA284F8")]
		private void ApplyFriction()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA2A180", Offset = "0xA2A180", VA = "0xA2A180")]
		public ThrowHandle()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class ThrowTarget : MonoBehaviour
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _showReticle;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject reticle;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ThrowHandle> targettingHandles;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThrowTarget> _allTargets;

		[Token(Token = "0x17000096")]
		public static List<ThrowTarget> AllTargets
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xA28038", Offset = "0xA28038", VA = "0xA28038")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xA2A48C", Offset = "0xA2A48C", VA = "0xA2A48C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA2A4E4", Offset = "0xA2A4E4", VA = "0xA2A4E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA2A6A0", Offset = "0xA2A6A0", VA = "0xA2A6A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA2A7E8", Offset = "0xA2A7E8", VA = "0xA2A7E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA2A9F4", Offset = "0xA2A9F4", VA = "0xA2A9F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA2AA48", Offset = "0xA2AA48", VA = "0xA2AA48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA283E4", Offset = "0xA283E4", VA = "0xA283E4")]
		public void AddTargettingHandle(ThrowHandle handle)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA28354", Offset = "0xA28354", VA = "0xA28354")]
		public void RemoveTargettingHandle(ThrowHandle handle)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA2A680", Offset = "0xA2A680", VA = "0xA2A680")]
		private void ShowHideReticle(bool show)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA2A7EC", Offset = "0xA2A7EC", VA = "0xA2A7EC")]
		private void MaintainReticleSize()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA29934", Offset = "0xA29934", VA = "0xA29934")]
		public Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA2AA9C", Offset = "0xA2AA9C", VA = "0xA2AA9C")]
		public ThrowTarget()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ThrowTracker : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LineRenderer _trajectoryLine;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem _sampleParticleSystem;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystemRenderer _particleRenderer;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIThrowTracker _trackerUIPrefab;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject _collisionMarkerPrefab;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _origin;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 _releaseVelocity;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ThrowHandle _handle;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 _groundHitPoint;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _tracking;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Vector3> _positions;

		[Token(Token = "0x40003F6")]
		private const int _positionsCap = 500;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UIThrowTracker _ui;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _show;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _showLine;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool _showSamples;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Color _color;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 particleMaxSize;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<ThrowHandle.VelocitySample> visSamples;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] visWeights;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ParticleSystem.Particle[] _smoothingSampleSet;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<ParticleSystem.Particle> _postReleaseSampleSet;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject _collisionMarker;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<MeshRenderer> _outlineRenderers;

		[Token(Token = "0x17000097")]
		public float GroundDistance
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xA2AC00", Offset = "0xA2AC00", VA = "0xA2AC00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA2ACC4", Offset = "0xA2ACC4", VA = "0xA2ACC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA2AD2C", Offset = "0xA2AD2C", VA = "0xA2AD2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA2AF34", Offset = "0xA2AF34", VA = "0xA2AF34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA24DC0", Offset = "0xA24DC0", VA = "0xA24DC0")]
		public void TrackThrowable(ThrowHandle throwable)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xA25340", Offset = "0xA25340", VA = "0xA25340")]
		public void SetLineAppearance(Texture lineTex, Color lineColor)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA253DC", Offset = "0xA253DC", VA = "0xA253DC")]
		public void ShowHideLine(bool show)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA25414", Offset = "0xA25414", VA = "0xA25414")]
		public void ShowHideSamples(bool show)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA2B2D4", Offset = "0xA2B2D4", VA = "0xA2B2D4")]
		public void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA254C8", Offset = "0xA254C8", VA = "0xA254C8")]
		public void AttachUIToRoot(Transform root)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA2B2E0", Offset = "0xA2B2E0", VA = "0xA2B2E0")]
		public void OnDetach()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xA2BDFC", Offset = "0xA2BDFC", VA = "0xA2BDFC")]
		public void EndTracking()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xA2BE04", Offset = "0xA2BE04", VA = "0xA2BE04")]
		public void OnAttach(GameObject hand, GameObject collisionRoot)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xA2BE0C", Offset = "0xA2BE0C", VA = "0xA2BE0C")]
		private void RecordFinalTrajectory(Vector3 launch)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xA2BFEC", Offset = "0xA2BFEC", VA = "0xA2BFEC")]
		private void VisualizeSmoothingSample(ThrowHandle.VelocitySample sample)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA2B7D4", Offset = "0xA2B7D4", VA = "0xA2B7D4")]
		private void VisualizeEstimatedVelocity()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA2BB4C", Offset = "0xA2BB4C", VA = "0xA2BB4C")]
		private void RefreshParticles()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xA2C4D8", Offset = "0xA2C4D8", VA = "0xA2C4D8")]
		private ParticleSystem.Particle CreateParticleForCurrentEstimatedVelocity()
		{
			return default(ParticleSystem.Particle);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xA2C06C", Offset = "0xA2C06C", VA = "0xA2C06C")]
		private void VisualizeVelocitySmoothingData(List<ThrowHandle.VelocitySample> samples, float[] weights)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA2C920", Offset = "0xA2C920", VA = "0xA2C920")]
		public void ToggleVisible()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xA2C938", Offset = "0xA2C938", VA = "0xA2C938")]
		public void ShowHide(bool show)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xA2CAB8", Offset = "0xA2CAB8", VA = "0xA2CAB8")]
		private void OnHandleDestroyed(ThrowHandle handle)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xA26044", Offset = "0xA26044", VA = "0xA26044")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xA2CABC", Offset = "0xA2CABC", VA = "0xA2CABC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xA2CBC0", Offset = "0xA2CBC0", VA = "0xA2CBC0")]
		private void PlaceCollisionMarker(Vector3 position, Vector3 normal)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xA2AF38", Offset = "0xA2AF38", VA = "0xA2AF38")]
		private void CreateOutline(GameObject original)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA2BC88", Offset = "0xA2BC88", VA = "0xA2BC88")]
		private void ShowHideOutline(bool show)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA2CE34", Offset = "0xA2CE34", VA = "0xA2CE34")]
		public ThrowTracker()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class DeviceDetectorUI : MonoBehaviour
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text _leftDetected;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text _rightDetected;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text _warning;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DeviceDetector _leftDetector;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DeviceDetector _rightDetector;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Device _detected;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<Device> OnDeviceDetected;

		[Token(Token = "0x17000098")]
		public Device DetectedDevice
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xA2CF98", Offset = "0xA2CF98", VA = "0xA2CF98")]
			get
			{
				return default(Device);
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA2CFA0", Offset = "0xA2CFA0", VA = "0xA2CFA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xA2D310", Offset = "0xA2D310", VA = "0xA2D310")]
		private void Update()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xA2D51C", Offset = "0xA2D51C", VA = "0xA2D51C")]
		public DeviceDetectorUI()
		{
		}
	}
}
namespace CloudFine.ThrowLab.UnityXR
{
	[Token(Token = "0x20000CC")]
	[RequireComponent(typeof(ThrowHandle))]
	public class ThrowLabXRGrabInteractable : XRGrabInteractable
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private ThrowHandle m_handle;

		[Token(Token = "0x17000099")]
		private ThrowHandle _handle
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xA2D5DC", Offset = "0xA2D5DC", VA = "0xA2D5DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xA2D6F0", Offset = "0xA2D6F0", VA = "0xA2D6F0", Slot = "65")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xA2D7CC", Offset = "0xA2D7CC", VA = "0xA2D7CC", Slot = "66")]
		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xA2D7F4", Offset = "0xA2D7F4", VA = "0xA2D7F4")]
		public ThrowLabXRGrabInteractable()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ThrowLab_XRDirectInteractor : XRDirectInteractor
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0xA2D7FC", Offset = "0xA2D7FC", VA = "0xA2D7FC", Slot = "77")]
		public override void GetValidTargets(List<XRBaseInteractable> validTargets)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xA2D93C", Offset = "0xA2D93C", VA = "0xA2D93C")]
		public ThrowLab_XRDirectInteractor()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[RequireComponent(typeof(XRController))]
	public class UnityXR_DeviceDetector : DeviceDetector
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private XRController _controller;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Device _device;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _deviceLoaded;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xA2DA68", Offset = "0xA2DA68", VA = "0xA2DA68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xA2DAD0", Offset = "0xA2DAD0", VA = "0xA2DAD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xA2DC50", Offset = "0xA2DC50", VA = "0xA2DC50")]
		public UnityXR_DeviceDetector()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[RequireComponent(typeof(XRController))]
	public class UnityXR_GrabThresholdModifier : GrabThresholdModifier
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float val;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XRController _controller;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xA2DC60", Offset = "0xA2DC60", VA = "0xA2DC60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xA2DCC8", Offset = "0xA2DCC8", VA = "0xA2DCC8", Slot = "4")]
		public override float GripValue()
		{
			return default(float);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xA2DE5C", Offset = "0xA2DE5C", VA = "0xA2DE5C", Slot = "5")]
		public override void SetGrabThreshold(float grip)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xA2DE78", Offset = "0xA2DE78", VA = "0xA2DE78", Slot = "6")]
		public override void SetReleaseThreshold(float grip)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xA2DE94", Offset = "0xA2DE94", VA = "0xA2DE94")]
		public UnityXR_GrabThresholdModifier()
		{
		}
	}
}
namespace CloudFine.ThrowLab.Oculus
{
	[Token(Token = "0x20000D1")]
	public class Oculus_DeviceDetector : DeviceDetector
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0xA2DE9C", Offset = "0xA2DE9C", VA = "0xA2DE9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xA2DEA8", Offset = "0xA2DEA8", VA = "0xA2DEA8")]
		public Oculus_DeviceDetector()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Oculus_GrabThresholdModifier : GrabThresholdModifier
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private OVRGrabber _grabber;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xA2DEB8", Offset = "0xA2DEB8", VA = "0xA2DEB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xA2DF20", Offset = "0xA2DF20", VA = "0xA2DF20", Slot = "4")]
		public override float GripValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA2DF80", Offset = "0xA2DF80", VA = "0xA2DF80", Slot = "5")]
		public override void SetGrabThreshold(float grip)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xA2DF9C", Offset = "0xA2DF9C", VA = "0xA2DF9C", Slot = "6")]
		public override void SetReleaseThreshold(float grip)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xA2DFB8", Offset = "0xA2DFB8", VA = "0xA2DFB8")]
		public Oculus_GrabThresholdModifier()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[RequireComponent(typeof(ThrowHandle))]
	public class ThrowLabOVRGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent OnGrab;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent OnRelease;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ThrowHandle m_handle;

		[Token(Token = "0x1700009A")]
		private ThrowHandle _handle
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xA2DFC0", Offset = "0xA2DFC0", VA = "0xA2DFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA2E0D4", Offset = "0xA2E0D4", VA = "0xA2E0D4", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xA2E150", Offset = "0xA2E150", VA = "0xA2E150", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA2E188", Offset = "0xA2E188", VA = "0xA2E188")]
		public ThrowLabOVRGrabbable()
		{
		}
	}
}
namespace CloudFine.ThrowLab.UI
{
	[Token(Token = "0x20000D4")]
	[RequireComponent(typeof(Image))]
	public class UIAngleValue : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Image image;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA2E190", Offset = "0xA2E190", VA = "0xA2E190")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA2E1F8", Offset = "0xA2E1F8", VA = "0xA2E1F8")]
		public void SetRange(float range)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA2E27C", Offset = "0xA2E27C", VA = "0xA2E27C")]
		public UIAngleValue()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class UIColorMeTag : MonoBehaviour
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA2E284", Offset = "0xA2E284", VA = "0xA2E284")]
		public UIColorMeTag()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[RequireComponent(typeof(LineRenderer))]
	public class UICurveLine : MonoBehaviour
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Func<float, float> curveFunction;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer line;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numPositions;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xA2E28C", Offset = "0xA2E28C", VA = "0xA2E28C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA2E2F4", Offset = "0xA2E2F4", VA = "0xA2E2F4")]
		public void SetCurveFunc(Func<float, float> curveFunc)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA2E310", Offset = "0xA2E310", VA = "0xA2E310")]
		public void RefreshCurve()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA2E47C", Offset = "0xA2E47C", VA = "0xA2E47C")]
		public UICurveLine()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class UISmoothingVisual : MonoBehaviour
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] bars;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThrowConfiguration.EstimationAlgorithm algorithm;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] dummyData;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] weights;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Func<Vector3[], float[]> _func;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA2E48C", Offset = "0xA2E48C", VA = "0xA2E48C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA2E54C", Offset = "0xA2E54C", VA = "0xA2E54C")]
		public void SetFunc(Func<Vector3[], float[]> func)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA2E554", Offset = "0xA2E554", VA = "0xA2E554")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA2E60C", Offset = "0xA2E60C", VA = "0xA2E60C")]
		public UISmoothingVisual()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[RequireComponent(typeof(RectTransform))]
	public class UIStepper : UIBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class StepperValueChangedEvent : UnityEvent<float>
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0xA2E9B4", Offset = "0xA2E9B4", VA = "0xA2E9B4")]
			public StepperValueChangedEvent()
			{
			}
		}

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Button[] _sides;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _value;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _minimum;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maximum;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _step;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _wrap;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Graphic _separator;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _separatorWidth;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StepperValueChangedEvent _onValueChanged;

		[Token(Token = "0x1700009B")]
		public Button[] sides
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xA2E614", Offset = "0xA2E614", VA = "0xA2E614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public float value
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xA2E724", Offset = "0xA2E724", VA = "0xA2E724")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0xA2E72C", Offset = "0xA2E72C", VA = "0xA2E72C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float minimum
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xA2E7AC", Offset = "0xA2E7AC", VA = "0xA2E7AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xA2E7B4", Offset = "0xA2E7B4", VA = "0xA2E7B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public float maximum
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xA2E7BC", Offset = "0xA2E7BC", VA = "0xA2E7BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xA2E7C4", Offset = "0xA2E7C4", VA = "0xA2E7C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float step
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xA2E7CC", Offset = "0xA2E7CC", VA = "0xA2E7CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0xA2E7D4", Offset = "0xA2E7D4", VA = "0xA2E7D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool wrap
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xA2E7DC", Offset = "0xA2E7DC", VA = "0xA2E7DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xA2E7E4", Offset = "0xA2E7E4", VA = "0xA2E7E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Graphic separator
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xA2E7F0", Offset = "0xA2E7F0", VA = "0xA2E7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xA2E7F8", Offset = "0xA2E7F8", VA = "0xA2E7F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		private float separatorWidth
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xA2E800", Offset = "0xA2E800", VA = "0xA2E800")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		public StepperValueChangedEvent onValueChanged
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xA2E928", Offset = "0xA2E928", VA = "0xA2E928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xA2E930", Offset = "0xA2E930", VA = "0xA2E930")]
			set
			{
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA2E938", Offset = "0xA2E938", VA = "0xA2E938")]
		protected UIStepper()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA2E65C", Offset = "0xA2E65C", VA = "0xA2E65C")]
		private Button[] GetSides()
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA2EA94", Offset = "0xA2EA94", VA = "0xA2EA94")]
		public void StepUp()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA2EB40", Offset = "0xA2EB40", VA = "0xA2EB40")]
		public void StepDown()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA2EA9C", Offset = "0xA2EA9C", VA = "0xA2EA9C")]
		private void Step(float amount)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA2E9FC", Offset = "0xA2E9FC", VA = "0xA2E9FC")]
		private void DisableAtExtremes(Button[] sides)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA2EB4C", Offset = "0xA2EB4C", VA = "0xA2EB4C")]
		private void RecreateSprites(Button[] sides)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[RequireComponent(typeof(Button))]
	public class UIStepperSide : UIBehaviour, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		[Token(Token = "0x170000A4")]
		private Button button
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xA2ED84", Offset = "0xA2ED84", VA = "0xA2ED84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private UIStepper stepper
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xA2EDE0", Offset = "0xA2EDE0", VA = "0xA2EDE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private bool leftmost
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xA2EE3C", Offset = "0xA2EE3C", VA = "0xA2EE3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA2EED0", Offset = "0xA2EED0", VA = "0xA2EED0")]
		protected UIStepperSide()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA2EED8", Offset = "0xA2EED8", VA = "0xA2EED8", Slot = "19")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA2EF80", Offset = "0xA2EF80", VA = "0xA2EF80", Slot = "20")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA2EEFC", Offset = "0xA2EEFC", VA = "0xA2EEFC")]
		private void Press()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class UITabBar : MonoBehaviour
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform _frontTabRoot;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform _backTabRoot;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button[] _tabButtons;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xA2EF84", Offset = "0xA2EF84", VA = "0xA2EF84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xA2EF8C", Offset = "0xA2EF8C", VA = "0xA2EF8C")]
		public void SetTab(int tab)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA2F028", Offset = "0xA2F028", VA = "0xA2F028")]
		public UITabBar()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class UIThrowConfiguration : MonoBehaviour
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThrowConfiguration currentConfig;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color currentColor;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text configLabel;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject configOptionsRoot;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject variantPanelRoot;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Smoothing")]
		public Toggle smoothingToggle;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject smoothingOptionsRoot;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dropdown smoothingAlgorithmDropdown;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Dropdown smoothingPeriodDropdown;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dropdown smoothingTimeDropdown;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UIStepper smoothingFramesStepper;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UIStepper smoothignSecondsStepper;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Dropdown smoothingPointDropdown;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UISmoothingVisual smoothingUI;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Header("Friction")]
		public Toggle frictionToggle;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject frictionOptionsRoot;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Slider frictionFalloffSlider;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Toggle frictionCustomCurveToggle;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UIStepper frictionSecondsStepper;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UICurveLine frictionCurveUI;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Header("Assist")]
		public Toggle assistToggle;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GameObject assistOptionsRoot;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Toggle assistCustomCurveToggle;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Slider assistGravitySlider;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Slider assistWeightSlider;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Slider assistRangeSlider;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public UICurveLine assistCurveUI;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Dropdown targetSelectionDropdown;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Header("Scale")]
		public Toggle scaleToggle;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public GameObject scaleOptionsRoot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Toggle scaleCustomCurveToggle;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Slider scaleRampSlider;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public UIStepper scaleStepper;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UIStepper scaleThresholdStepper;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UICurveLine scaleCurveUI;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xA2F030", Offset = "0xA2F030", VA = "0xA2F030")]
		private void Awake()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA262DC", Offset = "0xA262DC", VA = "0xA262DC")]
		public void LoadConfig(ThrowConfiguration config, Color color, bool enabled)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA2F6D0", Offset = "0xA2F6D0", VA = "0xA2F6D0")]
		public void SetAssistEnabled(bool enabled)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA2F288", Offset = "0xA2F288", VA = "0xA2F288")]
		public void SetAssistEnabled(bool enabled, bool configEnabled)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA2F8C8", Offset = "0xA2F8C8", VA = "0xA2F8C8")]
		public void SetFrictionEnabled(bool enabled)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA2F34C", Offset = "0xA2F34C", VA = "0xA2F34C")]
		public void SetFrictionEnabled(bool enabled, bool configEnabled)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA2F9D0", Offset = "0xA2F9D0", VA = "0xA2F9D0")]
		public void SetSmoothingEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA2F410", Offset = "0xA2F410", VA = "0xA2F410")]
		public void SetSmoothingEnabled(bool enabled, bool configEnabled)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA2F9DC", Offset = "0xA2F9DC", VA = "0xA2F9DC")]
		public void SetScalingEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA2F4C0", Offset = "0xA2F4C0", VA = "0xA2F4C0")]
		public void SetScalingEnabled(bool enabled, bool configEnabled)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA2F6DC", Offset = "0xA2F6DC", VA = "0xA2F6DC")]
		private void SetPanelEnabled(GameObject panelRoot, GameObject toggle, bool enabled)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xA2F584", Offset = "0xA2F584", VA = "0xA2F584")]
		private void SetChildrenColor(GameObject root, Color c)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA2FAE4", Offset = "0xA2FAE4", VA = "0xA2FAE4")]
		public void SetEstimationAlgorithm(int value)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA2FB64", Offset = "0xA2FB64", VA = "0xA2FB64")]
		public void SetPeriodMeasurement(int value)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA2FCB8", Offset = "0xA2FCB8", VA = "0xA2FCB8")]
		public void SetSampleSource(int value)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA2FD38", Offset = "0xA2FD38", VA = "0xA2FD38")]
		public void SetSmoothingSampleTime(int value)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA2FDB8", Offset = "0xA2FDB8", VA = "0xA2FDB8")]
		public void SetSmoothingSeconds(float seconds)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA2FE38", Offset = "0xA2FE38", VA = "0xA2FE38")]
		public void SetSmoothingFrames(float frames)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA2FED0", Offset = "0xA2FED0", VA = "0xA2FED0")]
		public void SetAssistRange(float range)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA2FF50", Offset = "0xA2FF50", VA = "0xA2FF50")]
		public void SetAssistGravity(float gravity)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA2FFD0", Offset = "0xA2FFD0", VA = "0xA2FFD0")]
		public void SetAssistWeight(float weight)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA2F7CC", Offset = "0xA2F7CC", VA = "0xA2F7CC")]
		public void SetAssistCustomCurve(bool value)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA30050", Offset = "0xA30050", VA = "0xA30050")]
		public void SetTargetSelectionMethod(int value)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA300D0", Offset = "0xA300D0", VA = "0xA300D0")]
		public void SetScalingMultiplier(float scale)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA30150", Offset = "0xA30150", VA = "0xA30150")]
		public void SetScalingThreshold(float threshold)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA301D0", Offset = "0xA301D0", VA = "0xA301D0")]
		public void SetScalingRamp(float value)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA2F9E8", Offset = "0xA2F9E8", VA = "0xA2F9E8")]
		public void SetScalingCustomCurve(bool value)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xA30250", Offset = "0xA30250", VA = "0xA30250")]
		public void SetFrictionDuration(float value)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xA302D0", Offset = "0xA302D0", VA = "0xA302D0")]
		public void SetFrictionFalloff(float value)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xA2F8D4", Offset = "0xA2F8D4", VA = "0xA2F8D4")]
		public void SetFrictionCustomCurve(bool value)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xA30350", Offset = "0xA30350", VA = "0xA30350")]
		public UIThrowConfiguration()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class UIThrowGrip : MonoBehaviour
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] gripLevels;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image[] hands;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text noHandsWarning;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool[] gripStates;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite openHand;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite closedHand;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GrabThresholdModifier> grips;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Slider grabBeginSlider;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Slider grabEndSlider;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool beginEndEqual;

		[Token(Token = "0x170000A7")]
		private float grabBegin
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xA30358", Offset = "0xA30358", VA = "0xA30358")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xA303A0", Offset = "0xA303A0", VA = "0xA303A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		private float grabEnd
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xA303F4", Offset = "0xA303F4", VA = "0xA303F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xA3043C", Offset = "0xA3043C", VA = "0xA3043C")]
			set
			{
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xA30490", Offset = "0xA30490", VA = "0xA30490")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xA3071C", Offset = "0xA3071C", VA = "0xA3071C")]
		private void Update()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xA30A68", Offset = "0xA30A68", VA = "0xA30A68")]
		public void SetGripBegin(float val)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xA30AFC", Offset = "0xA30AFC", VA = "0xA30AFC")]
		public void SetGripEnd(float val)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xA30594", Offset = "0xA30594", VA = "0xA30594")]
		protected void ShowHidePanel(bool show)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xA30B90", Offset = "0xA30B90", VA = "0xA30B90")]
		public UIThrowGrip()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class UIThrowTracker : MonoBehaviour
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text _distanceText;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text _angleText;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text _speedText;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button showHideButton;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Button clearButton;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image visibility;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Sprite visibleSprite;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Sprite invisibleSprite;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xA30BF4", Offset = "0xA30BF4", VA = "0xA30BF4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xA2B734", Offset = "0xA2B734", VA = "0xA2B734")]
		public void SetAngle(float angle)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xA2B694", Offset = "0xA2B694", VA = "0xA2B694")]
		public void SetSpeed(float speed)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xA2AE94", Offset = "0xA2AE94", VA = "0xA2AE94")]
		public void UpdateDistance(float distance)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xA2CA84", Offset = "0xA2CA84", VA = "0xA2CA84")]
		public void RefreshVisibilityButton(bool showing)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA30C14", Offset = "0xA30C14", VA = "0xA30C14")]
		public UIThrowTracker()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[RequireComponent(typeof(Text))]
	public class UIValueText : MonoBehaviour
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string _preDecorator;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string _toStringPattern;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string _postDecorator;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA30C1C", Offset = "0xA30C1C", VA = "0xA30C1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA30C84", Offset = "0xA30C84", VA = "0xA30C84")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA30CF0", Offset = "0xA30CF0", VA = "0xA30CF0")]
		public UIValueText()
		{
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x20000E0")]
	public class CallbackNotification : MonoBehaviour
	{
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA30D84", Offset = "0xA30D84", VA = "0xA30D84")]
		public void OnModifyLocalization()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA30EA4", Offset = "0xA30EA4", VA = "0xA30EA4")]
		public CallbackNotification()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class Example_ChangeLanguage : MonoBehaviour
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA30EAC", Offset = "0xA30EAC", VA = "0xA30EAC")]
		public void SetLanguage_English()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA30F7C", Offset = "0xA30F7C", VA = "0xA30F7C")]
		public void SetLanguage_French()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA30FBC", Offset = "0xA30FBC", VA = "0xA30FBC")]
		public void SetLanguage_Spanish()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA30EEC", Offset = "0xA30EEC", VA = "0xA30EEC")]
		public void SetLanguage(string LangName)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA30FFC", Offset = "0xA30FFC", VA = "0xA30FFC")]
		public Example_ChangeLanguage()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class Example_LocalizedString : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizedString _MyLocalizedString;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string _NormalString;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TermsPopup("")]
		public string _StringWithTermPopup;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA31004", Offset = "0xA31004", VA = "0xA31004")]
		public void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA31334", Offset = "0xA31334", VA = "0xA31334")]
		public Example_LocalizedString()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class GlobalParametersExample : RegisterGlobalParameters
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA3133C", Offset = "0xA3133C", VA = "0xA3133C", Slot = "7")]
		public override string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA313FC", Offset = "0xA313FC", VA = "0xA313FC")]
		public GlobalParametersExample()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class RealTimeTranslation : MonoBehaviour
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string OriginalText;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string TranslatedText;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool IsTranslating;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xA31404", Offset = "0xA31404", VA = "0xA31404")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xA31994", Offset = "0xA31994", VA = "0xA31994")]
		public void StartTranslating(string fromCode, string toCode)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA31C3C", Offset = "0xA31C3C", VA = "0xA31C3C")]
		private void OnTranslationReady(string Translation, string errorMsg)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA31CC8", Offset = "0xA31CC8", VA = "0xA31CC8")]
		public void ExampleMultiTranslations_Blocking()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA31A68", Offset = "0xA31A68", VA = "0xA31A68")]
		public void ExampleMultiTranslations_Async()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA31F3C", Offset = "0xA31F3C", VA = "0xA31F3C")]
		private void OnMultitranslationReady(Dictionary<string, TranslationQuery> dict, string errorMsg)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA321B4", Offset = "0xA321B4", VA = "0xA321B4")]
		public bool IsWaitingForTranslation()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA321BC", Offset = "0xA321BC", VA = "0xA321BC")]
		public string GetTranslatedText()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xA321C4", Offset = "0xA321C4", VA = "0xA321C4")]
		public void SetOriginalText(string text)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA321CC", Offset = "0xA321CC", VA = "0xA321CC")]
		public RealTimeTranslation()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA32258", Offset = "0xA32258", VA = "0xA32258")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA322FC", Offset = "0xA322FC", VA = "0xA322FC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA3235C", Offset = "0xA3235C", VA = "0xA3235C", Slot = "5")]
		public virtual UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA32364", Offset = "0xA32364", VA = "0xA32364")]
		public RegisterBundlesManager()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class ToggleLanguage : MonoBehaviour
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA3236C", Offset = "0xA3236C", VA = "0xA3236C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA323BC", Offset = "0xA323BC", VA = "0xA323BC")]
		private void test()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA32480", Offset = "0xA32480", VA = "0xA32480")]
		public ToggleLanguage()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public static class PersistentStorage
	{
		[Token(Token = "0x20000E8")]
		public enum eFileType
		{
			[Token(Token = "0x4000470")]
			Raw,
			[Token(Token = "0x4000471")]
			Persistent,
			[Token(Token = "0x4000472")]
			Temporal,
			[Token(Token = "0x4000473")]
			Streaming
		}

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA32488", Offset = "0xA32488", VA = "0xA32488")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA32558", Offset = "0xA32558", VA = "0xA32558")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA32620", Offset = "0xA32620", VA = "0xA32620")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xA326D8", Offset = "0xA326D8", VA = "0xA326D8")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xA32790", Offset = "0xA32790", VA = "0xA32790")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xA32840", Offset = "0xA32840", VA = "0xA32840")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA328F0", Offset = "0xA328F0", VA = "0xA328F0")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA329D0", Offset = "0xA329D0", VA = "0xA329D0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA32AA0", Offset = "0xA32AA0", VA = "0xA32AA0")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xA32B70", Offset = "0xA32B70", VA = "0xA32B70")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E9")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xA32C44", Offset = "0xA32C44", VA = "0xA32C44", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA32EE0", Offset = "0xA32EE0", VA = "0xA32EE0", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA3315C", Offset = "0xA3315C", VA = "0xA3315C", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA3339C", Offset = "0xA3339C", VA = "0xA3339C", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xA333A4", Offset = "0xA333A4", VA = "0xA333A4", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA333B0", Offset = "0xA333B0", VA = "0xA333B0", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA333B8", Offset = "0xA333B8", VA = "0xA333B8")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA33450", Offset = "0xA33450", VA = "0xA33450", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xA335E4", Offset = "0xA335E4", VA = "0xA335E4", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA3376C", Offset = "0xA3376C", VA = "0xA3376C", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA338E8", Offset = "0xA338E8", VA = "0xA338E8", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA33A64", Offset = "0xA33A64", VA = "0xA33A64")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA32550", Offset = "0xA32550", VA = "0xA32550")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA33A6C", Offset = "0xA33A6C", VA = "0xA33A6C", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA340B8", Offset = "0xA340B8", VA = "0xA340B8", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA34114", Offset = "0xA34114", VA = "0xA34114", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA341BC", Offset = "0xA341BC", VA = "0xA341BC")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA341C4", Offset = "0xA341C4", VA = "0xA341C4")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA341E8", Offset = "0xA341E8", VA = "0xA341E8")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA343E0", Offset = "0xA343E0", VA = "0xA343E0")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA3476C", Offset = "0xA3476C", VA = "0xA3476C")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA34500", Offset = "0xA34500", VA = "0xA34500")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA34BEC", Offset = "0xA34BEC", VA = "0xA34BEC")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class EventCallback
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA34E08", Offset = "0xA34E08", VA = "0xA34E08")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA34E6C", Offset = "0xA34E6C", VA = "0xA34E6C")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xA34EF0", Offset = "0xA34EF0", VA = "0xA34EF0")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public enum ePluralType
	{
		[Token(Token = "0x400047A")]
		Zero,
		[Token(Token = "0x400047B")]
		One,
		[Token(Token = "0x400047C")]
		Two,
		[Token(Token = "0x400047D")]
		Few,
		[Token(Token = "0x400047E")]
		Many,
		[Token(Token = "0x400047F")]
		Plural
	}
	[Token(Token = "0x20000EF")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x20000F0")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xA34F50", Offset = "0xA34F50", VA = "0xA34F50")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA353E8", Offset = "0xA353E8", VA = "0xA353E8")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA3529C", Offset = "0xA3529C", VA = "0xA3529C")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA359AC", Offset = "0xA359AC", VA = "0xA359AC")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA35AF8", Offset = "0xA35AF8", VA = "0xA35AF8")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA35BC8", Offset = "0xA35BC8", VA = "0xA35BC8")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA35D54", Offset = "0xA35D54", VA = "0xA35D54")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA36000", Offset = "0xA36000", VA = "0xA36000")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA36364", Offset = "0xA36364", VA = "0xA36364")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA36630", Offset = "0xA36630", VA = "0xA36630")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA36884", Offset = "0xA36884", VA = "0xA36884")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA36AC4", Offset = "0xA36AC4", VA = "0xA36AC4")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA36C74", Offset = "0xA36C74", VA = "0xA36C74")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA37314", Offset = "0xA37314", VA = "0xA37314")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA372FC", Offset = "0xA372FC", VA = "0xA372FC")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F1")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x20000F2")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x20000F3")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0xA43D50", Offset = "0xA43D50", VA = "0xA43D50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0xA43D98", Offset = "0xA43D98", VA = "0xA43D98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xA41950", Offset = "0xA41950", VA = "0xA41950")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xA43BBC", Offset = "0xA43BBC", VA = "0xA43BBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xA43BC0", Offset = "0xA43BC0", VA = "0xA43BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xA43D58", Offset = "0xA43D58", VA = "0xA43D58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xA4010C", Offset = "0xA4010C", VA = "0xA4010C")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA4035C", Offset = "0xA4035C", VA = "0xA4035C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xA40B30", Offset = "0xA40B30", VA = "0xA40B30")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xA40A9C", Offset = "0xA40A9C", VA = "0xA40A9C")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xA41284", Offset = "0xA41284", VA = "0xA41284")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xA41300", Offset = "0xA41300", VA = "0xA41300")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xA411B8", Offset = "0xA411B8", VA = "0xA411B8")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xA418F0", Offset = "0xA418F0", VA = "0xA418F0")]
		[IteratorStateMachine(typeof(<WaitForTranslations>d__11))]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA41978", Offset = "0xA41978", VA = "0xA41978")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA4213C", Offset = "0xA4213C", VA = "0xA4213C")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA421F0", Offset = "0xA421F0", VA = "0xA421F0")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xA40734", Offset = "0xA40734", VA = "0xA40734")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xA42480", Offset = "0xA42480", VA = "0xA42480")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xA40CE8", Offset = "0xA40CE8", VA = "0xA40CE8")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xA42EE4", Offset = "0xA42EE4", VA = "0xA42EE4")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xA41E64", Offset = "0xA41E64", VA = "0xA41E64")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xA426D0", Offset = "0xA426D0", VA = "0xA426D0")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA428A4", Offset = "0xA428A4", VA = "0xA428A4")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA4276C", Offset = "0xA4276C", VA = "0xA4276C")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA42FE4", Offset = "0xA42FE4", VA = "0xA42FE4")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA4208C", Offset = "0xA4208C", VA = "0xA4208C")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA42994", Offset = "0xA42994", VA = "0xA42994")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA410A0", Offset = "0xA410A0", VA = "0xA410A0")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA430AC", Offset = "0xA430AC", VA = "0xA430AC")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA43448", Offset = "0xA43448", VA = "0xA43448")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA437B0", Offset = "0xA437B0", VA = "0xA437B0")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA4183C", Offset = "0xA4183C", VA = "0xA4183C")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public struct TranslationQuery
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x20000F7")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x20000F8")]
		public enum eJobState
		{
			[Token(Token = "0x4000495")]
			Running,
			[Token(Token = "0x4000496")]
			Succeeded,
			[Token(Token = "0x4000497")]
			Failed
		}

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA43DA0", Offset = "0xA43DA0", VA = "0xA43DA0", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA43DA8", Offset = "0xA43DA8", VA = "0xA43DA8", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA43DAC", Offset = "0xA43DAC", VA = "0xA43DAC")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA43DB4", Offset = "0xA43DB4", VA = "0xA43DB4", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA43DE0", Offset = "0xA43DE0", VA = "0xA43DE0")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA43DE8", Offset = "0xA43DE8", VA = "0xA43DE8")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA43E9C", Offset = "0xA43E9C", VA = "0xA43E9C")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA43FCC", Offset = "0xA43FCC", VA = "0xA43FCC", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA44078", Offset = "0xA44078", VA = "0xA44078")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA40FF8", Offset = "0xA40FF8", VA = "0xA40FF8")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA4434C", Offset = "0xA4434C", VA = "0xA4434C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA44560", Offset = "0xA44560", VA = "0xA44560", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA44190", Offset = "0xA44190", VA = "0xA44190")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA445C0", Offset = "0xA445C0", VA = "0xA445C0", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA4465C", Offset = "0xA4465C", VA = "0xA4465C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA44744", Offset = "0xA44744", VA = "0xA44744")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA44798", Offset = "0xA44798", VA = "0xA44798")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA44BAC", Offset = "0xA44BAC", VA = "0xA44BAC")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA44F64", Offset = "0xA44F64", VA = "0xA44F64", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA45010", Offset = "0xA45010", VA = "0xA45010")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA45144", Offset = "0xA45144", VA = "0xA45144")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FF")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x40004B1")]
		DISABLED = 1,
		[Token(Token = "0x40004B2")]
		KEEP_LOADED = 2,
		[Token(Token = "0x40004B3")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000100")]
	public class LanguageData
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA45868", Offset = "0xA45868", VA = "0xA45868")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xA45878", Offset = "0xA45878", VA = "0xA45878")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xA45894", Offset = "0xA45894", VA = "0xA45894")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xA458A4", Offset = "0xA458A4", VA = "0xA458A4")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xA458B4", Offset = "0xA458B4", VA = "0xA458B4")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA458D0", Offset = "0xA458D0", VA = "0xA458D0")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xA458EC", Offset = "0xA458EC", VA = "0xA458EC")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x2000102")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x170000AB")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xA458F4", Offset = "0xA458F4", VA = "0xA458F4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0xA458FC", Offset = "0xA458FC", VA = "0xA458FC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA45904", Offset = "0xA45904", VA = "0xA45904")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xA459A0", Offset = "0xA459A0", VA = "0xA459A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA45A3C", Offset = "0xA45A3C", VA = "0xA45A3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA45ADC", Offset = "0xA45ADC", VA = "0xA45ADC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA45B50", Offset = "0xA45B50", VA = "0xA45B50")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA45C40", Offset = "0xA45C40", VA = "0xA45C40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA45C4C", Offset = "0xA45C4C", VA = "0xA45C4C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xA46494", Offset = "0xA46494", VA = "0xA46494")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x170000AC")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xA467F4", Offset = "0xA467F4", VA = "0xA467F4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xA467FC", Offset = "0xA467FC", VA = "0xA467FC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xA46804", Offset = "0xA46804", VA = "0xA46804")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public interface ILanguageSource
	{
		[Token(Token = "0x170000AD")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x600055A")]
			get;
			[Token(Token = "0x600055B")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000105")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x2000106")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x40004EA")]
			Empty,
			[Token(Token = "0x40004EB")]
			Fallback,
			[Token(Token = "0x40004EC")]
			ShowWarning,
			[Token(Token = "0x40004ED")]
			ShowTerm
		}

		[Token(Token = "0x2000107")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x40004EF")]
			Never,
			[Token(Token = "0x40004F0")]
			OnlyInDevice,
			[Token(Token = "0x40004F1")]
			EditorAndDevice
		}

		[Token(Token = "0x2000108")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x40004F3")]
			Always,
			[Token(Token = "0x40004F4")]
			Never,
			[Token(Token = "0x40004F5")]
			Daily,
			[Token(Token = "0x40004F6")]
			Weekly,
			[Token(Token = "0x40004F7")]
			Monthly,
			[Token(Token = "0x40004F8")]
			OnlyOnce,
			[Token(Token = "0x40004F9")]
			EveryOtherDay
		}

		[Token(Token = "0x2000109")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x40004FB")]
			Manual,
			[Token(Token = "0x40004FC")]
			OnSceneLoaded,
			[Token(Token = "0x40004FD")]
			AsSoonAsDownloaded
		}

		[Token(Token = "0x200010B")]
		[CompilerGenerated]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool forceUpdate;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool JustCheck;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0xA4F3A0", Offset = "0xA4F3A0", VA = "0xA4F3A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0xA4F3E8", Offset = "0xA4F3E8", VA = "0xA4F3E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xA4C9EC", Offset = "0xA4C9EC", VA = "0xA4C9EC")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xA4F0AC", Offset = "0xA4F0AC", VA = "0xA4F0AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xA4F0B0", Offset = "0xA4F0B0", VA = "0xA4F0B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xA4F3A8", Offset = "0xA4F3A8", VA = "0xA4F3A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x170000AE")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xA46874", Offset = "0xA46874", VA = "0xA46874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xA463F8", Offset = "0xA463F8", VA = "0xA463F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xA468F0", Offset = "0xA468F0", VA = "0xA468F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xA45A6C", Offset = "0xA45A6C", VA = "0xA45A6C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xA45AFC", Offset = "0xA45AFC", VA = "0xA45AFC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xA473FC", Offset = "0xA473FC", VA = "0xA473FC")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xA47A0C", Offset = "0xA47A0C", VA = "0xA47A0C")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xA47B1C", Offset = "0xA47B1C", VA = "0xA47B1C")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xA47C60", Offset = "0xA47C60", VA = "0xA47C60")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xA47C68", Offset = "0xA47C68", VA = "0xA47C68")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xA46E98", Offset = "0xA46E98", VA = "0xA46E98")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA47C6C", Offset = "0xA47C6C", VA = "0xA47C6C")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA47D40", Offset = "0xA47D40", VA = "0xA47D40")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA47D98", Offset = "0xA47D98", VA = "0xA47D98")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xA47E30", Offset = "0xA47E30", VA = "0xA47E30")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xA483B8", Offset = "0xA483B8", VA = "0xA483B8")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xA48B2C", Offset = "0xA48B2C", VA = "0xA48B2C")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xA48D88", Offset = "0xA48D88", VA = "0xA48D88")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xA48E5C", Offset = "0xA48E5C", VA = "0xA48E5C")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xA49810", Offset = "0xA49810", VA = "0xA49810")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xA496AC", Offset = "0xA496AC", VA = "0xA496AC")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xA49A70", Offset = "0xA49A70", VA = "0xA49A70")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xA49BEC", Offset = "0xA49BEC", VA = "0xA49BEC")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xA49DB0", Offset = "0xA49DB0", VA = "0xA49DB0")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xA4A274", Offset = "0xA4A274", VA = "0xA4A274")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xA4AF84", Offset = "0xA4AF84", VA = "0xA4AF84")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xA4A38C", Offset = "0xA4A38C", VA = "0xA4A38C")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xA4B1BC", Offset = "0xA4B1BC", VA = "0xA4B1BC")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xA4B58C", Offset = "0xA4B58C", VA = "0xA4B58C")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xA4B7E4", Offset = "0xA4B7E4", VA = "0xA4B7E4")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xA4BA1C", Offset = "0xA4BA1C", VA = "0xA4BA1C")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xA4BBEC", Offset = "0xA4BBEC", VA = "0xA4BBEC")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xA4C020", Offset = "0xA4C020", VA = "0xA4C020")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xA4C6DC", Offset = "0xA4C6DC", VA = "0xA4C6DC")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xA4BE60", Offset = "0xA4BE60", VA = "0xA4BE60")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xA4C958", Offset = "0xA4C958", VA = "0xA4C958")]
		[IteratorStateMachine(typeof(<Import_Google_Coroutine>d__65))]
		private IEnumerator Import_Google_Coroutine(bool forceUpdate, bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xA4CA14", Offset = "0xA4CA14", VA = "0xA4CA14")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xA4CAC0", Offset = "0xA4CAC0", VA = "0xA4CAC0")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xA4CC20", Offset = "0xA4CC20", VA = "0xA4CC20")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xA4CD94", Offset = "0xA4CD94", VA = "0xA4CD94")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xA4C0B0", Offset = "0xA4C0B0", VA = "0xA4C0B0")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xA47574", Offset = "0xA47574", VA = "0xA47574")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xA4CFE8", Offset = "0xA4CFE8", VA = "0xA4CFE8")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xA4D078", Offset = "0xA4D078", VA = "0xA4D078")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xA4B24C", Offset = "0xA4B24C", VA = "0xA4B24C")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xA4CE2C", Offset = "0xA4CE2C", VA = "0xA4CE2C")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xA4D12C", Offset = "0xA4D12C", VA = "0xA4D12C")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xA4D1B8", Offset = "0xA4D1B8", VA = "0xA4D1B8")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xA4D250", Offset = "0xA4D250", VA = "0xA4D250")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xA4D2C8", Offset = "0xA4D2C8", VA = "0xA4D2C8")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xA4D488", Offset = "0xA4D488", VA = "0xA4D488")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xA4D760", Offset = "0xA4D760", VA = "0xA4D760")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xA4D8A4", Offset = "0xA4D8A4", VA = "0xA4D8A4")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xA4DA5C", Offset = "0xA4DA5C", VA = "0xA4DA5C")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xA4DAF8", Offset = "0xA4DAF8", VA = "0xA4DAF8")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xA4DB9C", Offset = "0xA4DB9C", VA = "0xA4DB9C")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xA4DBAC", Offset = "0xA4DBAC", VA = "0xA4DBAC")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xA4DDFC", Offset = "0xA4DDFC", VA = "0xA4DDFC")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xA4E20C", Offset = "0xA4E20C", VA = "0xA4E20C")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xA4DF78", Offset = "0xA4DF78", VA = "0xA4DF78")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xA4B6CC", Offset = "0xA4B6CC", VA = "0xA4B6CC")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xA4B624", Offset = "0xA4B624", VA = "0xA4B624")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xA49FE4", Offset = "0xA49FE4", VA = "0xA49FE4")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xA4E358", Offset = "0xA4E358", VA = "0xA4E358")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xA4E290", Offset = "0xA4E290", VA = "0xA4E290")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xA4E404", Offset = "0xA4E404", VA = "0xA4E404")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA46B94", Offset = "0xA46B94", VA = "0xA46B94")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xA4E51C", Offset = "0xA4E51C", VA = "0xA4E51C")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xA4E550", Offset = "0xA4E550", VA = "0xA4E550")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xA480F0", Offset = "0xA480F0", VA = "0xA480F0")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xA4E880", Offset = "0xA4E880", VA = "0xA4E880")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xA47740", Offset = "0xA47740", VA = "0xA47740")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xA4EA88", Offset = "0xA4EA88", VA = "0xA4EA88")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xA4EAA4", Offset = "0xA4EAA4", VA = "0xA4EAA4")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xA4E88C", Offset = "0xA4E88C", VA = "0xA4E88C")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xA4ECB4", Offset = "0xA4ECB4", VA = "0xA4ECB4")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xA4B3E8", Offset = "0xA4B3E8", VA = "0xA4B3E8")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xA46158", Offset = "0xA46158", VA = "0xA46158")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x400050C")]
		None,
		[Token(Token = "0x400050D")]
		Replace,
		[Token(Token = "0x400050E")]
		Merge,
		[Token(Token = "0x400050F")]
		AddNewTerms
	}
	[Token(Token = "0x200010D")]
	public class LocalizationReader
	{
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA4F3F0", Offset = "0xA4F3F0", VA = "0xA4F3F0")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xA4F65C", Offset = "0xA4F65C", VA = "0xA4F65C")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA4FAEC", Offset = "0xA4FAEC", VA = "0xA4FAEC")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xA4A2B0", Offset = "0xA4A2B0", VA = "0xA4A2B0")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xA4FD0C", Offset = "0xA4FD0C", VA = "0xA4FD0C")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA4FEF8", Offset = "0xA4FEF8", VA = "0xA4FEF8")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xA4AFBC", Offset = "0xA4AFBC", VA = "0xA4AFBC")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xA4FA44", Offset = "0xA4FA44", VA = "0xA4FA44")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xA50028", Offset = "0xA50028", VA = "0xA50028")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xA4F99C", Offset = "0xA4F99C", VA = "0xA4F99C")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xA50120", Offset = "0xA50120", VA = "0xA50120")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x200010F")]
		public enum TermModification
		{
			[Token(Token = "0x4000531")]
			DontModify,
			[Token(Token = "0x4000532")]
			ToUpper,
			[Token(Token = "0x4000533")]
			ToLower,
			[Token(Token = "0x4000534")]
			ToUpperFirst,
			[Token(Token = "0x4000535")]
			ToTitle
		}

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool AllowParameters;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x170000B1")]
		public string Term
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xA50128", Offset = "0xA50128", VA = "0xA50128")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xA50130", Offset = "0xA50130", VA = "0xA50130")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public string SecondaryTerm
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xA50188", Offset = "0xA50188", VA = "0xA50188")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xA50190", Offset = "0xA50190", VA = "0xA50190")]
			set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xA50214", Offset = "0xA50214", VA = "0xA50214")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xA51378", Offset = "0xA51378", VA = "0xA51378")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xA51380", Offset = "0xA51380", VA = "0xA51380")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA50A88", Offset = "0xA50A88", VA = "0xA50A88")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA505B0", Offset = "0xA505B0", VA = "0xA505B0")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA513C8", Offset = "0xA513C8", VA = "0xA513C8")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xA51B9C", Offset = "0xA51B9C", VA = "0xA51B9C")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xA51C64", Offset = "0xA51C64", VA = "0xA51C64")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xA50134", Offset = "0xA50134", VA = "0xA50134")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xA5019C", Offset = "0xA5019C", VA = "0xA5019C")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x60005D2")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xA50248", Offset = "0xA50248", VA = "0xA50248")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60005D4")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA51CB4", Offset = "0xA51CB4", VA = "0xA51CB4")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x60005D7")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA51DC4", Offset = "0xA51DC4", VA = "0xA51DC4")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xA51E48", Offset = "0xA51E48", VA = "0xA51E48")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xA51EE0", Offset = "0xA51EE0", VA = "0xA51EE0")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xA52004", Offset = "0xA52004", VA = "0xA52004")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AddComponentMenu("I2/Localization/Localize Dropdown")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xA52408", Offset = "0xA52408", VA = "0xA52408")]
		public void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xA5271C", Offset = "0xA5271C", VA = "0xA5271C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xA52894", Offset = "0xA52894", VA = "0xA52894")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xA52630", Offset = "0xA52630", VA = "0xA52630")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xA528EC", Offset = "0xA528EC", VA = "0xA528EC")]
		private void FillValues()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xA52B04", Offset = "0xA52B04", VA = "0xA52B04")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xA53030", Offset = "0xA53030", VA = "0xA53030")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xA52E30", Offset = "0xA52E30", VA = "0xA52E30")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xA53350", Offset = "0xA53350", VA = "0xA53350")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000113")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters);

		[Token(Token = "0x2000114")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000115")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class <Delayed_Import_Google>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0xA59018", Offset = "0xA59018", VA = "0xA59018", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0xA59060", Offset = "0xA59060", VA = "0xA59060", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xA58F28", Offset = "0xA58F28", VA = "0xA58F28")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xA58F50", Offset = "0xA58F50", VA = "0xA58F50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xA58F54", Offset = "0xA58F54", VA = "0xA58F54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xA59020", Offset = "0xA59020", VA = "0xA59020", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200011D")]
		[CompilerGenerated]
		private sealed class <Coroutine_LocalizeAll>d__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0xA5918C", Offset = "0xA5918C", VA = "0xA5918C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0xA591D4", Offset = "0xA591D4", VA = "0xA591D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xA59098", Offset = "0xA59098", VA = "0xA59098")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__88(int <>1__state)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xA590C0", Offset = "0xA590C0", VA = "0xA590C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xA590C4", Offset = "0xA590C4", VA = "0xA590C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xA59194", Offset = "0xA59194", VA = "0xA59194", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] GlobalSources;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x170000B3")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xA4BB90", Offset = "0xA4BB90", VA = "0xA4BB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xA51F34", Offset = "0xA51F34", VA = "0xA51F34")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xA541B8", Offset = "0xA541B8", VA = "0xA541B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xA54214", Offset = "0xA54214", VA = "0xA54214")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public static string CurrentRegion
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xA544BC", Offset = "0xA544BC", VA = "0xA544BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xA54630", Offset = "0xA54630", VA = "0xA54630")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xA547F0", Offset = "0xA547F0", VA = "0xA547F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xA548C0", Offset = "0xA548C0", VA = "0xA548C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xA549C4", Offset = "0xA549C4", VA = "0xA549C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xA52554", Offset = "0xA52554", VA = "0xA52554")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xA527B8", Offset = "0xA527B8", VA = "0xA527B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xA40670", Offset = "0xA40670", VA = "0xA40670")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xA53A04", Offset = "0xA53A04", VA = "0xA53A04")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xA4CE24", Offset = "0xA4CE24", VA = "0xA4CE24")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xA401B0", Offset = "0xA401B0", VA = "0xA401B0")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xA53FBC", Offset = "0xA53FBC", VA = "0xA53FBC")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xA54A1C", Offset = "0xA54A1C", VA = "0xA54A1C")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xA54C0C", Offset = "0xA54C0C", VA = "0xA54C0C")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xA54B10", Offset = "0xA54B10", VA = "0xA54B10")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xA535E8", Offset = "0xA535E8", VA = "0xA535E8")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xA54D3C", Offset = "0xA54D3C", VA = "0xA54D3C")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xA53A44", Offset = "0xA53A44", VA = "0xA53A44")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xA53DE4", Offset = "0xA53DE4", VA = "0xA53DE4")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xA542DC", Offset = "0xA542DC", VA = "0xA542DC")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xA54F0C", Offset = "0xA54F0C", VA = "0xA54F0C")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xA5519C", Offset = "0xA5519C", VA = "0xA5519C")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xA55400", Offset = "0xA55400", VA = "0xA55400")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xA55504", Offset = "0xA55504", VA = "0xA55504")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xA5563C", Offset = "0xA5563C", VA = "0xA5563C")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xA533D8", Offset = "0xA533D8", VA = "0xA533D8")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xA55734", Offset = "0xA55734", VA = "0xA55734")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xA51628", Offset = "0xA51628", VA = "0xA51628")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xA55D90", Offset = "0xA55D90", VA = "0xA55D90")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xA558F8", Offset = "0xA558F8", VA = "0xA558F8")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xA55FF4", Offset = "0xA55FF4", VA = "0xA55FF4")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xA56290", Offset = "0xA56290", VA = "0xA56290")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xA51B40", Offset = "0xA51B40", VA = "0xA51B40")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xA51718", Offset = "0xA51718", VA = "0xA51718")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xA56454", Offset = "0xA56454", VA = "0xA56454")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xA54B88", Offset = "0xA54B88", VA = "0xA54B88")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xA53564", Offset = "0xA53564", VA = "0xA53564")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xA564F0", Offset = "0xA564F0", VA = "0xA564F0")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xA567A8", Offset = "0xA567A8", VA = "0xA567A8")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xA56608", Offset = "0xA56608", VA = "0xA56608")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xA5693C", Offset = "0xA5693C", VA = "0xA5693C")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xA4698C", Offset = "0xA4698C", VA = "0xA4698C")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xA569F0", Offset = "0xA569F0", VA = "0xA569F0")]
		[IteratorStateMachine(typeof(<Delayed_Import_Google>d__63))]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xA4737C", Offset = "0xA4737C", VA = "0xA4737C")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xA56A88", Offset = "0xA56A88", VA = "0xA56A88")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xA56B0C", Offset = "0xA56B0C", VA = "0xA56B0C")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xA56CB8", Offset = "0xA56CB8", VA = "0xA56CB8")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xA56DF8", Offset = "0xA56DF8", VA = "0xA56DF8")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xA54CA0", Offset = "0xA54CA0", VA = "0xA54CA0")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xA56EDC", Offset = "0xA56EDC", VA = "0xA56EDC")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xA57384", Offset = "0xA57384", VA = "0xA57384")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xA51564", Offset = "0xA51564", VA = "0xA51564")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xA577C8", Offset = "0xA577C8", VA = "0xA577C8")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xA575CC", Offset = "0xA575CC", VA = "0xA575CC")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xA57874", Offset = "0xA57874", VA = "0xA57874")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xA472B0", Offset = "0xA472B0", VA = "0xA472B0")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xA57BE8", Offset = "0xA57BE8", VA = "0xA57BE8")]
		[IteratorStateMachine(typeof(<Coroutine_LocalizeAll>d__88))]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xA57A70", Offset = "0xA57A70", VA = "0xA57A70")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xA57C48", Offset = "0xA57C48", VA = "0xA57C48")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xA57D80", Offset = "0xA57D80", VA = "0xA57D80")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xA57FD4", Offset = "0xA57FD4", VA = "0xA57FD4")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xA55E88", Offset = "0xA55E88", VA = "0xA55E88")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000655")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000656")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x6000657")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6000658")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6000659")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x600065A")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x600065B")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x600065C")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xA591DC", Offset = "0xA591DC", VA = "0xA591DC")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x600065E")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x6000660")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x6000661")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x6000662")]
		public abstract Type GetTargetType();

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xA591E4", Offset = "0xA591E4", VA = "0xA591E4")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x6000664")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6000667")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xA591EC", Offset = "0xA591EC", VA = "0xA591EC")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xA591F0", Offset = "0xA591F0", VA = "0xA591F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xA592B8", Offset = "0xA592B8", VA = "0xA592B8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xA592C0", Offset = "0xA592C0", VA = "0xA592C0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xA592C8", Offset = "0xA592C8", VA = "0xA592C8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xA592D0", Offset = "0xA592D0", VA = "0xA592D0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xA592D8", Offset = "0xA592D8", VA = "0xA592D8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xA592E0", Offset = "0xA592E0", VA = "0xA592E0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xA593FC", Offset = "0xA593FC", VA = "0xA593FC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xA59988", Offset = "0xA59988", VA = "0xA59988")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xA59BF0", Offset = "0xA59BF0", VA = "0xA59BF0")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xA598A8", Offset = "0xA598A8", VA = "0xA598A8")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xA59AF0", Offset = "0xA59AF0", VA = "0xA59AF0")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xA59F84", Offset = "0xA59F84", VA = "0xA59F84")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xA59FE0", Offset = "0xA59FE0", VA = "0xA59FE0")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xA59FE4", Offset = "0xA59FE4", VA = "0xA59FE4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA5A0AC", Offset = "0xA5A0AC", VA = "0xA5A0AC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xA5A0B4", Offset = "0xA5A0B4", VA = "0xA5A0B4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xA5A0BC", Offset = "0xA5A0BC", VA = "0xA5A0BC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xA5A0C4", Offset = "0xA5A0C4", VA = "0xA5A0C4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xA5A0CC", Offset = "0xA5A0CC", VA = "0xA5A0CC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xA5A0D4", Offset = "0xA5A0D4", VA = "0xA5A0D4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xA5A1F0", Offset = "0xA5A1F0", VA = "0xA5A1F0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xA5A69C", Offset = "0xA5A69C", VA = "0xA5A69C")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0xA5A6F8", Offset = "0xA5A6F8", VA = "0xA5A6F8")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xA5A6FC", Offset = "0xA5A6FC", VA = "0xA5A6FC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xA5A7C4", Offset = "0xA5A7C4", VA = "0xA5A7C4", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xA5A7CC", Offset = "0xA5A7CC", VA = "0xA5A7CC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xA5A7D4", Offset = "0xA5A7D4", VA = "0xA5A7D4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xA5A7DC", Offset = "0xA5A7DC", VA = "0xA5A7DC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xA5A7E4", Offset = "0xA5A7E4", VA = "0xA5A7E4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xA5A7EC", Offset = "0xA5A7EC", VA = "0xA5A7EC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xA5A8C8", Offset = "0xA5A8C8", VA = "0xA5A8C8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA5AA38", Offset = "0xA5AA38", VA = "0xA5AA38")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x600068C")]
		[Address(RVA = "0xA5AA80", Offset = "0xA5AA80", VA = "0xA5AA80", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xA5AAB4", Offset = "0xA5AAB4", VA = "0xA5AAB4")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x600068E")]
		[Address(RVA = "0xA5AAFC", Offset = "0xA5AAFC", VA = "0xA5AAFC")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xA5AB00", Offset = "0xA5AB00", VA = "0xA5AB00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xA5ABB0", Offset = "0xA5ABB0", VA = "0xA5ABB0", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xA5ABE4", Offset = "0xA5ABE4", VA = "0xA5ABE4", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xA5ABEC", Offset = "0xA5ABEC", VA = "0xA5ABEC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xA5ABF4", Offset = "0xA5ABF4", VA = "0xA5ABF4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xA5ABFC", Offset = "0xA5ABFC", VA = "0xA5ABFC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xA5AC04", Offset = "0xA5AC04", VA = "0xA5AC04", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xA5AC0C", Offset = "0xA5AC0C", VA = "0xA5AC0C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xA5AC58", Offset = "0xA5AC58", VA = "0xA5AC58", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xA5AD98", Offset = "0xA5AD98", VA = "0xA5AD98")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x6000699")]
		[Address(RVA = "0xA5ADE0", Offset = "0xA5ADE0", VA = "0xA5ADE0")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xA5ADE4", Offset = "0xA5ADE4", VA = "0xA5ADE4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xA5AEAC", Offset = "0xA5AEAC", VA = "0xA5AEAC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xA5AEB4", Offset = "0xA5AEB4", VA = "0xA5AEB4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xA5AEBC", Offset = "0xA5AEBC", VA = "0xA5AEBC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xA5AEC4", Offset = "0xA5AEC4", VA = "0xA5AEC4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xA5AECC", Offset = "0xA5AECC", VA = "0xA5AECC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xA5AED4", Offset = "0xA5AED4", VA = "0xA5AED4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xA5B0D0", Offset = "0xA5B0D0", VA = "0xA5B0D0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xA5B29C", Offset = "0xA5B29C", VA = "0xA5B29C")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xA5B2E4", Offset = "0xA5B2E4", VA = "0xA5B2E4", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xA5B2EC", Offset = "0xA5B2EC", VA = "0xA5B2EC")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xA5B334", Offset = "0xA5B334", VA = "0xA5B334")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xA5B338", Offset = "0xA5B338", VA = "0xA5B338")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xA5B3E8", Offset = "0xA5B3E8", VA = "0xA5B3E8", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xA5B3F0", Offset = "0xA5B3F0", VA = "0xA5B3F0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xA5B3F8", Offset = "0xA5B3F8", VA = "0xA5B3F8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xA5B400", Offset = "0xA5B400", VA = "0xA5B400", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xA5B408", Offset = "0xA5B408", VA = "0xA5B408", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xA5B410", Offset = "0xA5B410", VA = "0xA5B410", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xA5B418", Offset = "0xA5B418", VA = "0xA5B418", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xA5B464", Offset = "0xA5B464", VA = "0xA5B464", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xA5B668", Offset = "0xA5B668", VA = "0xA5B668")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xA5B81C", Offset = "0xA5B81C", VA = "0xA5B81C")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xA5B864", Offset = "0xA5B864", VA = "0xA5B864")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xA5B868", Offset = "0xA5B868", VA = "0xA5B868")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xA5B930", Offset = "0xA5B930", VA = "0xA5B930", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xA5B938", Offset = "0xA5B938", VA = "0xA5B938", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xA5B940", Offset = "0xA5B940", VA = "0xA5B940", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xA5B948", Offset = "0xA5B948", VA = "0xA5B948", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xA5B950", Offset = "0xA5B950", VA = "0xA5B950", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xA5B958", Offset = "0xA5B958", VA = "0xA5B958", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xA5BA38", Offset = "0xA5BA38", VA = "0xA5BA38", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xA5BB34", Offset = "0xA5BB34", VA = "0xA5BB34")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xA5BB7C", Offset = "0xA5BB7C", VA = "0xA5BB7C")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xA5BB80", Offset = "0xA5BB80", VA = "0xA5BB80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xA5BC48", Offset = "0xA5BC48", VA = "0xA5BC48", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xA5BC50", Offset = "0xA5BC50", VA = "0xA5BC50", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xA5BC58", Offset = "0xA5BC58", VA = "0xA5BC58", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xA5BC60", Offset = "0xA5BC60", VA = "0xA5BC60", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xA5BC68", Offset = "0xA5BC68", VA = "0xA5BC68", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xA5BC70", Offset = "0xA5BC70", VA = "0xA5BC70", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xA5BD94", Offset = "0xA5BD94", VA = "0xA5BD94", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xA5C040", Offset = "0xA5C040", VA = "0xA5C040")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xA5C098", Offset = "0xA5C098", VA = "0xA5C098")]
		static LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xA5C09C", Offset = "0xA5C09C", VA = "0xA5C09C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xA5C164", Offset = "0xA5C164", VA = "0xA5C164", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xA5C16C", Offset = "0xA5C16C", VA = "0xA5C16C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xA5C174", Offset = "0xA5C174", VA = "0xA5C174", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xA5C17C", Offset = "0xA5C17C", VA = "0xA5C17C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xA5C184", Offset = "0xA5C184", VA = "0xA5C184", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xA5C18C", Offset = "0xA5C18C", VA = "0xA5C18C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xA5C26C", Offset = "0xA5C26C", VA = "0xA5C26C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xA5C368", Offset = "0xA5C368", VA = "0xA5C368")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xA5C3B0", Offset = "0xA5C3B0", VA = "0xA5C3B0")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xA5C3B4", Offset = "0xA5C3B4", VA = "0xA5C3B4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xA5C47C", Offset = "0xA5C47C", VA = "0xA5C47C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xA5C484", Offset = "0xA5C484", VA = "0xA5C484", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xA5C48C", Offset = "0xA5C48C", VA = "0xA5C48C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xA5C494", Offset = "0xA5C494", VA = "0xA5C494", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xA5C514", Offset = "0xA5C514", VA = "0xA5C514", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xA5C51C", Offset = "0xA5C51C", VA = "0xA5C51C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xA5C6B8", Offset = "0xA5C6B8", VA = "0xA5C6B8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xA5C7A8", Offset = "0xA5C7A8", VA = "0xA5C7A8")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xA5C7F0", Offset = "0xA5C7F0", VA = "0xA5C7F0")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xA5C7F4", Offset = "0xA5C7F4", VA = "0xA5C7F4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xA5C8BC", Offset = "0xA5C8BC", VA = "0xA5C8BC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xA5C8C4", Offset = "0xA5C8C4", VA = "0xA5C8C4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xA5C8CC", Offset = "0xA5C8CC", VA = "0xA5C8CC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xA5C8D4", Offset = "0xA5C8D4", VA = "0xA5C8D4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xA5C8DC", Offset = "0xA5C8DC", VA = "0xA5C8DC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xA5C8E4", Offset = "0xA5C8E4", VA = "0xA5C8E4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xA5C9D4", Offset = "0xA5C9D4", VA = "0xA5C9D4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xA5CAC4", Offset = "0xA5CAC4", VA = "0xA5CAC4")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xA5CB0C", Offset = "0xA5CB0C", VA = "0xA5CB0C")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xA5CB10", Offset = "0xA5CB10", VA = "0xA5CB10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xA5CBD8", Offset = "0xA5CBD8", VA = "0xA5CBD8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xA5CBE0", Offset = "0xA5CBE0", VA = "0xA5CBE0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xA5CBE8", Offset = "0xA5CBE8", VA = "0xA5CBE8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xA5CBF0", Offset = "0xA5CBF0", VA = "0xA5CBF0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xA5CBF8", Offset = "0xA5CBF8", VA = "0xA5CBF8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xA5CC00", Offset = "0xA5CC00", VA = "0xA5CC00", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xA5CD2C", Offset = "0xA5CD2C", VA = "0xA5CD2C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xA5CFD4", Offset = "0xA5CFD4", VA = "0xA5CFD4")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xA5D08C", Offset = "0xA5D08C", VA = "0xA5D08C")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public enum eTermType
	{
		[Token(Token = "0x4000572")]
		Text,
		[Token(Token = "0x4000573")]
		Font,
		[Token(Token = "0x4000574")]
		Texture,
		[Token(Token = "0x4000575")]
		AudioClip,
		[Token(Token = "0x4000576")]
		GameObject,
		[Token(Token = "0x4000577")]
		Sprite,
		[Token(Token = "0x4000578")]
		Material,
		[Token(Token = "0x4000579")]
		Child,
		[Token(Token = "0x400057A")]
		Mesh,
		[Token(Token = "0x400057B")]
		TextMeshPFont,
		[Token(Token = "0x400057C")]
		Object,
		[Token(Token = "0x400057D")]
		Video
	}
	[Token(Token = "0x2000132")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x400057F")]
		Normal = 1,
		[Token(Token = "0x4000580")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000133")]
	public class TermData
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xA5D0E4", Offset = "0xA5D0E4", VA = "0xA5D0E4")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xA5D1F8", Offset = "0xA5D1F8", VA = "0xA5D1F8")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xA5D2DC", Offset = "0xA5D2DC", VA = "0xA5D2DC")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xA5D330", Offset = "0xA5D330", VA = "0xA5D330")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xA5D4D0", Offset = "0xA5D4D0", VA = "0xA5D4D0")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xA5D504", Offset = "0xA5D504", VA = "0xA5D504")]
		public void Validate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xA5D700", Offset = "0xA5D700", VA = "0xA5D700")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xA5D788", Offset = "0xA5D788", VA = "0xA5D788")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xA5D850", Offset = "0xA5D850", VA = "0xA5D850")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xA5D938", Offset = "0xA5D938", VA = "0xA5D938")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x170000BC")]
		public string Filter
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xA5DAB0", Offset = "0xA5DAB0", VA = "0xA5DAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xA5DAB8", Offset = "0xA5DAB8", VA = "0xA5DAB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xA5DA80", Offset = "0xA5DA80", VA = "0xA5DA80")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xA5DAC0", Offset = "0xA5DAC0", VA = "0xA5DAC0")]
		public void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xA5DB14", Offset = "0xA5DB14", VA = "0xA5DB14")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x170000BD")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xA5DB1C", Offset = "0xA5DB1C", VA = "0xA5DB1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xA5DC6C", Offset = "0xA5DC6C", VA = "0xA5DC6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xA5DCF0", Offset = "0xA5DCF0", VA = "0xA5DCF0")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xA5DD14", Offset = "0xA5DD14", VA = "0xA5DD14")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xA5DD1C", Offset = "0xA5DD1C", VA = "0xA5DD1C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xA5DDF4", Offset = "0xA5DDF4", VA = "0xA5DDF4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xA5DE98", Offset = "0xA5DE98", VA = "0xA5DE98")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xA5DEB4", Offset = "0xA5DEB4", VA = "0xA5DEB4")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class HindiFixer
	{
		[Token(Token = "0x6000705")]
		[Address(RVA = "0xA5DF28", Offset = "0xA5DF28", VA = "0xA5DF28")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xA5E334", Offset = "0xA5E334", VA = "0xA5E334")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public static class I2Utils
	{
		[Token(Token = "0x400058C")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x400058D")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x400058E")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xA59DD8", Offset = "0xA59DD8", VA = "0xA59DD8")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA5E444", Offset = "0xA5E444", VA = "0xA5E444")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xA5E664", Offset = "0xA5E664", VA = "0xA5E664")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xA5E70C", Offset = "0xA5E70C", VA = "0xA5E70C")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xA5E9B0", Offset = "0xA5E9B0", VA = "0xA5E9B0")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xA5E684", Offset = "0xA5E684", VA = "0xA5E684")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xA5EB34", Offset = "0xA5EB34", VA = "0xA5EB34")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xA5EDD8", Offset = "0xA5EDD8", VA = "0xA5EDD8")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xA5EDE0", Offset = "0xA5EDE0", VA = "0xA5EDE0")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xA5EEB0", Offset = "0xA5EEB0", VA = "0xA5EEB0")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xA5EF10", Offset = "0xA5EF10", VA = "0xA5EF10")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xA5F050", Offset = "0xA5F050", VA = "0xA5F050")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xA5F178", Offset = "0xA5F178", VA = "0xA5F178")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xA5F224", Offset = "0xA5F224", VA = "0xA5F224")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x200013D")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x600071D")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200013E")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public struct ParamValue
		{
			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA5F2BC", Offset = "0xA5F2BC", VA = "0xA5F2BC", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA5F394", Offset = "0xA5F394", VA = "0xA5F394")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA5F534", Offset = "0xA5F534", VA = "0xA5F534")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xA5F5E0", Offset = "0xA5F5E0", VA = "0xA5F5E0", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA5F5F0", Offset = "0xA5F5F0", VA = "0xA5F5F0")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xA5F6CC", Offset = "0xA5F6CC", VA = "0xA5F6CC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA5F74C", Offset = "0xA5F74C", VA = "0xA5F74C")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000140")]
	public struct LocalizedString
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA5F7D4", Offset = "0xA5F7D4", VA = "0xA5F7D4")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xA5F89C", Offset = "0xA5F89C", VA = "0xA5F89C")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xA5F8D8", Offset = "0xA5F8D8", VA = "0xA5F8D8")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xA5F7D8", Offset = "0xA5F7D8", VA = "0xA5F7D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000141")]
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0xA5F92C", Offset = "0xA5F92C", VA = "0xA5F92C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xA5F9CC", Offset = "0xA5F9CC", VA = "0xA5F9CC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xA5FA6C", Offset = "0xA5FA6C", VA = "0xA5FA6C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xA5FAC8", Offset = "0xA5FAC8", VA = "0xA5FAC8", Slot = "4")]
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xA5FAD0", Offset = "0xA5FAD0", VA = "0xA5FAD0")]
		public RegisterCallback_AllowSyncFromGoogle()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x600072E")]
		[Address(RVA = "0xA5FAD8", Offset = "0xA5FAD8", VA = "0xA5FAD8", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xA5FBB4", Offset = "0xA5FBB4", VA = "0xA5FBB4", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xA5FC34", Offset = "0xA5FC34", VA = "0xA5FC34", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA5FC3C", Offset = "0xA5FC3C", VA = "0xA5FC3C")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000732")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x2000144")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x170000BE")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xA5FC44", Offset = "0xA5FC44", VA = "0xA5FC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xA6002C", Offset = "0xA6002C", VA = "0xA6002C")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000735")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xA600F4", Offset = "0xA600F4", VA = "0xA600F4")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xA60218", Offset = "0xA60218", VA = "0xA60218")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA60088", Offset = "0xA60088", VA = "0xA60088")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA60278", Offset = "0xA60278", VA = "0xA60278")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class RTLFixer
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA603B4", Offset = "0xA603B4", VA = "0xA603B4")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA6063C", Offset = "0xA6063C", VA = "0xA6063C")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA603C0", Offset = "0xA603C0", VA = "0xA603C0")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA61514", Offset = "0xA61514", VA = "0xA61514")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x2000146")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x40005A1")]
		Hamza = 65152,
		[Token(Token = "0x40005A2")]
		Alef = 65165,
		[Token(Token = "0x40005A3")]
		AlefHamza = 65155,
		[Token(Token = "0x40005A4")]
		WawHamza = 65157,
		[Token(Token = "0x40005A5")]
		AlefMaksoor = 65159,
		[Token(Token = "0x40005A6")]
		AlefMaksora = 64508,
		[Token(Token = "0x40005A7")]
		HamzaNabera = 65161,
		[Token(Token = "0x40005A8")]
		Ba = 65167,
		[Token(Token = "0x40005A9")]
		Ta = 65173,
		[Token(Token = "0x40005AA")]
		Tha2 = 65177,
		[Token(Token = "0x40005AB")]
		Jeem = 65181,
		[Token(Token = "0x40005AC")]
		H7aa = 65185,
		[Token(Token = "0x40005AD")]
		Khaa2 = 65189,
		[Token(Token = "0x40005AE")]
		Dal = 65193,
		[Token(Token = "0x40005AF")]
		Thal = 65195,
		[Token(Token = "0x40005B0")]
		Ra2 = 65197,
		[Token(Token = "0x40005B1")]
		Zeen = 65199,
		[Token(Token = "0x40005B2")]
		Seen = 65201,
		[Token(Token = "0x40005B3")]
		Sheen = 65205,
		[Token(Token = "0x40005B4")]
		S9a = 65209,
		[Token(Token = "0x40005B5")]
		Dha = 65213,
		[Token(Token = "0x40005B6")]
		T6a = 65217,
		[Token(Token = "0x40005B7")]
		T6ha = 65221,
		[Token(Token = "0x40005B8")]
		Ain = 65225,
		[Token(Token = "0x40005B9")]
		Gain = 65229,
		[Token(Token = "0x40005BA")]
		Fa = 65233,
		[Token(Token = "0x40005BB")]
		Gaf = 65237,
		[Token(Token = "0x40005BC")]
		Kaf = 65241,
		[Token(Token = "0x40005BD")]
		Lam = 65245,
		[Token(Token = "0x40005BE")]
		Meem = 65249,
		[Token(Token = "0x40005BF")]
		Noon = 65253,
		[Token(Token = "0x40005C0")]
		Ha = 65257,
		[Token(Token = "0x40005C1")]
		Waw = 65261,
		[Token(Token = "0x40005C2")]
		Ya = 65265,
		[Token(Token = "0x40005C3")]
		AlefMad = 65153,
		[Token(Token = "0x40005C4")]
		TaMarboota = 65171,
		[Token(Token = "0x40005C5")]
		PersianPe = 64342,
		[Token(Token = "0x40005C6")]
		PersianChe = 64378,
		[Token(Token = "0x40005C7")]
		PersianZe = 64394,
		[Token(Token = "0x40005C8")]
		PersianGaf = 64402,
		[Token(Token = "0x40005C9")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x2000147")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x40005CB")]
		Hamza = 1569,
		[Token(Token = "0x40005CC")]
		Alef = 1575,
		[Token(Token = "0x40005CD")]
		AlefHamza = 1571,
		[Token(Token = "0x40005CE")]
		WawHamza = 1572,
		[Token(Token = "0x40005CF")]
		AlefMaksoor = 1573,
		[Token(Token = "0x40005D0")]
		AlefMagsora = 1609,
		[Token(Token = "0x40005D1")]
		HamzaNabera = 1574,
		[Token(Token = "0x40005D2")]
		Ba = 1576,
		[Token(Token = "0x40005D3")]
		Ta = 1578,
		[Token(Token = "0x40005D4")]
		Tha2 = 1579,
		[Token(Token = "0x40005D5")]
		Jeem = 1580,
		[Token(Token = "0x40005D6")]
		H7aa = 1581,
		[Token(Token = "0x40005D7")]
		Khaa2 = 1582,
		[Token(Token = "0x40005D8")]
		Dal = 1583,
		[Token(Token = "0x40005D9")]
		Thal = 1584,
		[Token(Token = "0x40005DA")]
		Ra2 = 1585,
		[Token(Token = "0x40005DB")]
		Zeen = 1586,
		[Token(Token = "0x40005DC")]
		Seen = 1587,
		[Token(Token = "0x40005DD")]
		Sheen = 1588,
		[Token(Token = "0x40005DE")]
		S9a = 1589,
		[Token(Token = "0x40005DF")]
		Dha = 1590,
		[Token(Token = "0x40005E0")]
		T6a = 1591,
		[Token(Token = "0x40005E1")]
		T6ha = 1592,
		[Token(Token = "0x40005E2")]
		Ain = 1593,
		[Token(Token = "0x40005E3")]
		Gain = 1594,
		[Token(Token = "0x40005E4")]
		Fa = 1601,
		[Token(Token = "0x40005E5")]
		Gaf = 1602,
		[Token(Token = "0x40005E6")]
		Kaf = 1603,
		[Token(Token = "0x40005E7")]
		Lam = 1604,
		[Token(Token = "0x40005E8")]
		Meem = 1605,
		[Token(Token = "0x40005E9")]
		Noon = 1606,
		[Token(Token = "0x40005EA")]
		Ha = 1607,
		[Token(Token = "0x40005EB")]
		Waw = 1608,
		[Token(Token = "0x40005EC")]
		Ya = 1610,
		[Token(Token = "0x40005ED")]
		AlefMad = 1570,
		[Token(Token = "0x40005EE")]
		TaMarboota = 1577,
		[Token(Token = "0x40005EF")]
		PersianPe = 1662,
		[Token(Token = "0x40005F0")]
		PersianChe = 1670,
		[Token(Token = "0x40005F1")]
		PersianZe = 1688,
		[Token(Token = "0x40005F2")]
		PersianGaf = 1711,
		[Token(Token = "0x40005F3")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x2000148")]
	internal class ArabicMapping
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA6151C", Offset = "0xA6151C", VA = "0xA6151C")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x2000149")]
	internal class ArabicTable
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x170000BF")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xA62104", Offset = "0xA62104", VA = "0xA62104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xA61548", Offset = "0xA61548", VA = "0xA61548")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xA62188", Offset = "0xA62188", VA = "0xA62188")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014A")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xA62330", Offset = "0xA62330", VA = "0xA62330")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x200014B")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xA62360", Offset = "0xA62360", VA = "0xA62360")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xA62880", Offset = "0xA62880", VA = "0xA62880")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA6083C", Offset = "0xA6083C", VA = "0xA6083C")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xA62AC8", Offset = "0xA62AC8", VA = "0xA62AC8")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xA63098", Offset = "0xA63098", VA = "0xA63098")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xA62F54", Offset = "0xA62F54", VA = "0xA62F54")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xA62C24", Offset = "0xA62C24", VA = "0xA62C24")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xA63384", Offset = "0xA63384", VA = "0xA63384")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xA633D8", Offset = "0xA633D8", VA = "0xA633D8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xA633DC", Offset = "0xA633DC", VA = "0xA633DC")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA63474", Offset = "0xA63474", VA = "0xA63474")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA6347C", Offset = "0xA6347C", VA = "0xA6347C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA636C4", Offset = "0xA636C4", VA = "0xA636C4")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xA637BC", Offset = "0xA637BC", VA = "0xA637BC")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class StringObfucator
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xA637C4", Offset = "0xA637C4", VA = "0xA637C4")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xA63AB8", Offset = "0xA63AB8", VA = "0xA63AB8")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xA63A34", Offset = "0xA63A34", VA = "0xA63A34")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xA63B90", Offset = "0xA63B90", VA = "0xA63B90")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xA6389C", Offset = "0xA6389C", VA = "0xA6389C")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xA63C1C", Offset = "0xA63C1C", VA = "0xA63C1C")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200014F")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x40005FF")]
		Array = 1,
		[Token(Token = "0x4000600")]
		Class,
		[Token(Token = "0x4000601")]
		Value,
		[Token(Token = "0x4000602")]
		IntValue,
		[Token(Token = "0x4000603")]
		DoubleValue,
		[Token(Token = "0x4000604")]
		BoolValue,
		[Token(Token = "0x4000605")]
		FloatValue
	}
	[Token(Token = "0x2000150")]
	public class JSONNode
	{
		[Token(Token = "0x2000151")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170000CC")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0xA65D78", Offset = "0xA65D78", VA = "0xA65D78", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0xA65DC0", Offset = "0xA65DC0", VA = "0xA65DC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xA63DF0", Offset = "0xA63DF0", VA = "0xA63DF0")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xA65D5C", Offset = "0xA65D5C", VA = "0xA65D5C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xA65D60", Offset = "0xA65D60", VA = "0xA65D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xA65D80", Offset = "0xA65D80", VA = "0xA65D80", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xA65DC8", Offset = "0xA65DC8", VA = "0xA65DC8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xA65E60", Offset = "0xA65E60", VA = "0xA65E60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000152")]
		[CompilerGenerated]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170000CE")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0xA664CC", Offset = "0xA664CC", VA = "0xA664CC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0xA66514", Offset = "0xA66514", VA = "0xA66514", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xA63EA8", Offset = "0xA63EA8", VA = "0xA63EA8")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xA65E64", Offset = "0xA65E64", VA = "0xA65E64", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xA65F1C", Offset = "0xA65F1C", VA = "0xA65F1C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xA6641C", Offset = "0xA6641C", VA = "0xA6641C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xA6636C", Offset = "0xA6636C", VA = "0xA6636C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xA664D4", Offset = "0xA664D4", VA = "0xA664D4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xA6651C", Offset = "0xA6651C", VA = "0xA6651C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0xA665C8", Offset = "0xA665C8", VA = "0xA665C8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0xA63CA4", Offset = "0xA63CA4", VA = "0xA63CA4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xA63CAC", Offset = "0xA63CAC", VA = "0xA63CAC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0xA63CB0", Offset = "0xA63CB0", VA = "0xA63CB0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075F")]
			[Address(RVA = "0xA63CB8", Offset = "0xA63CB8", VA = "0xA63CB8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public virtual string Value
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0xA63CBC", Offset = "0xA63CBC", VA = "0xA63CBC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0xA63CFC", Offset = "0xA63CFC", VA = "0xA63CFC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public virtual int Count
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0xA63D00", Offset = "0xA63D00", VA = "0xA63D00", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C4")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xA63D80", Offset = "0xA63D80", VA = "0xA63D80", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__17))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0xA63E24", Offset = "0xA63E24", VA = "0xA63E24")]
			[IteratorStateMachine(typeof(<get_DeepChilds>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public virtual int AsInt
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xA63F5C", Offset = "0xA63F5C", VA = "0xA63F5C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xA63F90", Offset = "0xA63F90", VA = "0xA63F90", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xA63FCC", Offset = "0xA63FCC", VA = "0xA63FCC", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0xA64004", Offset = "0xA64004", VA = "0xA64004", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xA64040", Offset = "0xA64040", VA = "0xA64040", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0xA64078", Offset = "0xA64078", VA = "0xA64078", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0xA640B4", Offset = "0xA640B4", VA = "0xA640B4", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xA6416C", Offset = "0xA6416C", VA = "0xA6416C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xA641E4", Offset = "0xA641E4", VA = "0xA641E4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xA6425C", Offset = "0xA6425C", VA = "0xA6425C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xA63CA0", Offset = "0xA63CA0", VA = "0xA63CA0", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xA63D08", Offset = "0xA63D08", VA = "0xA63D08", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xA63D68", Offset = "0xA63D68", VA = "0xA63D68", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xA63D70", Offset = "0xA63D70", VA = "0xA63D70", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA63D78", Offset = "0xA63D78", VA = "0xA63D78", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xA63EDC", Offset = "0xA63EDC", VA = "0xA63EDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xA63F1C", Offset = "0xA63F1C", VA = "0xA63F1C", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xA642D4", Offset = "0xA642D4", VA = "0xA642D4")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xA64374", Offset = "0xA64374", VA = "0xA64374")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xA643B0", Offset = "0xA643B0", VA = "0xA643B0")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xA64438", Offset = "0xA64438", VA = "0xA64438")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xA64450", Offset = "0xA64450", VA = "0xA64450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xA6445C", Offset = "0xA6445C", VA = "0xA6445C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xA64464", Offset = "0xA64464", VA = "0xA64464")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA64630", Offset = "0xA64630", VA = "0xA64630")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA64EE4", Offset = "0xA64EE4", VA = "0xA64EE4", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA64EE8", Offset = "0xA64EE8", VA = "0xA64EE8")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xA64F68", Offset = "0xA64F68", VA = "0xA64F68")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xA64FB8", Offset = "0xA64FB8", VA = "0xA64FB8")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xA65008", Offset = "0xA65008", VA = "0xA65008")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xA65058", Offset = "0xA65058", VA = "0xA65058")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA65228", Offset = "0xA65228", VA = "0xA65228")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xA65428", Offset = "0xA65428", VA = "0xA65428")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xA658A0", Offset = "0xA658A0", VA = "0xA658A0")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xA658F0", Offset = "0xA658F0", VA = "0xA658F0")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xA65940", Offset = "0xA65940", VA = "0xA65940")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xA65990", Offset = "0xA65990", VA = "0xA65990")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xA65B24", Offset = "0xA65B24", VA = "0xA65B24")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xA65CA0", Offset = "0xA65CA0", VA = "0xA65CA0")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xA65D54", Offset = "0xA65D54", VA = "0xA65D54")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000154")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000D4")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0xA6731C", Offset = "0xA6731C", VA = "0xA6731C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0xA67364", Offset = "0xA67364", VA = "0xA67364", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xA66A74", Offset = "0xA66A74", VA = "0xA66A74")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xA670EC", Offset = "0xA670EC", VA = "0xA670EC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xA67108", Offset = "0xA67108", VA = "0xA67108", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xA672CC", Offset = "0xA672CC", VA = "0xA672CC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xA67324", Offset = "0xA67324", VA = "0xA67324", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xA6736C", Offset = "0xA6736C", VA = "0xA6736C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xA67418", Offset = "0xA67418", VA = "0xA67418", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000155")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B9")]
				[Address(RVA = "0xA6764C", Offset = "0xA6764C", VA = "0xA6764C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0xA67694", Offset = "0xA67694", VA = "0xA67694", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xA66B1C", Offset = "0xA66B1C", VA = "0xA66B1C")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xA6741C", Offset = "0xA6741C", VA = "0xA6741C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xA67438", Offset = "0xA67438", VA = "0xA67438", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xA675FC", Offset = "0xA675FC", VA = "0xA675FC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xA67654", Offset = "0xA67654", VA = "0xA67654", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x170000D0")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0xA665CC", Offset = "0xA665CC", VA = "0xA665CC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xA666C8", Offset = "0xA666C8", VA = "0xA666C8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xA6677C", Offset = "0xA6677C", VA = "0xA6677C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xA667DC", Offset = "0xA667DC", VA = "0xA667DC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public override int Count
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xA66834", Offset = "0xA66834", VA = "0xA66834", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D3")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xA669F0", Offset = "0xA669F0", VA = "0xA669F0", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__13))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA6687C", Offset = "0xA6687C", VA = "0xA6687C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA668D4", Offset = "0xA668D4", VA = "0xA668D4", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA66990", Offset = "0xA66990", VA = "0xA66990", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xA66AA8", Offset = "0xA66AA8", VA = "0xA66AA8", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xA66B44", Offset = "0xA66B44", VA = "0xA66B44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA66D70", Offset = "0xA66D70", VA = "0xA66D70", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA67008", Offset = "0xA67008", VA = "0xA67008", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA64E5C", Offset = "0xA64E5C", VA = "0xA64E5C")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000158")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000DC")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0xA68F8C", Offset = "0xA68F8C", VA = "0xA68F8C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0xA68FD4", Offset = "0xA68FD4", VA = "0xA68FD4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xA68010", Offset = "0xA68010", VA = "0xA68010")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xA68D28", Offset = "0xA68D28", VA = "0xA68D28", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xA68D44", Offset = "0xA68D44", VA = "0xA68D44", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xA68F3C", Offset = "0xA68F3C", VA = "0xA68F3C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xA68F94", Offset = "0xA68F94", VA = "0xA68F94", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xA68FDC", Offset = "0xA68FDC", VA = "0xA68FDC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xA69088", Offset = "0xA69088", VA = "0xA69088", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0xA692F4", Offset = "0xA692F4", VA = "0xA692F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0xA6933C", Offset = "0xA6933C", VA = "0xA6933C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xA680B8", Offset = "0xA680B8", VA = "0xA680B8")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xA6908C", Offset = "0xA6908C", VA = "0xA6908C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xA690A8", Offset = "0xA690A8", VA = "0xA690A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xA692A4", Offset = "0xA692A4", VA = "0xA692A4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xA692FC", Offset = "0xA692FC", VA = "0xA692FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x170000D8")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xA6769C", Offset = "0xA6769C", VA = "0xA6769C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xA677B0", Offset = "0xA677B0", VA = "0xA677B0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xA6787C", Offset = "0xA6787C", VA = "0xA6787C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xA67944", Offset = "0xA67944", VA = "0xA67944", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public override int Count
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xA67A40", Offset = "0xA67A40", VA = "0xA67A40", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DB")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xA67F8C", Offset = "0xA67F8C", VA = "0xA67F8C", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__14))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xA67A90", Offset = "0xA67A90", VA = "0xA67A90", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xA67BA4", Offset = "0xA67BA4", VA = "0xA67BA4", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xA67C70", Offset = "0xA67C70", VA = "0xA67C70", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xA67D84", Offset = "0xA67D84", VA = "0xA67D84", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xA68044", Offset = "0xA68044", VA = "0xA68044", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xA680E0", Offset = "0xA680E0", VA = "0xA680E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xA68564", Offset = "0xA68564", VA = "0xA68564", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xA68A74", Offset = "0xA68A74", VA = "0xA68A74", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xA64D68", Offset = "0xA64D68", VA = "0xA64D68")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x170000E0")]
		public override string Value
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xA69344", Offset = "0xA69344", VA = "0xA69344", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xA6934C", Offset = "0xA6934C", VA = "0xA6934C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xA64344", Offset = "0xA64344", VA = "0xA64344")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xA65868", Offset = "0xA65868", VA = "0xA65868")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xA657F8", Offset = "0xA657F8", VA = "0xA657F8")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xA65830", Offset = "0xA65830", VA = "0xA65830")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xA657C0", Offset = "0xA657C0", VA = "0xA657C0")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xA69354", Offset = "0xA69354", VA = "0xA69354", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xA693AC", Offset = "0xA693AC", VA = "0xA693AC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xA69404", Offset = "0xA69404", VA = "0xA69404", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x200015B")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x170000E1")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xA69734", Offset = "0xA69734", VA = "0xA69734", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xA69794", Offset = "0xA69794", VA = "0xA69794", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xA69814", Offset = "0xA69814", VA = "0xA69814", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xA69884", Offset = "0xA69884", VA = "0xA69884", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public override int AsInt
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0xA69AE4", Offset = "0xA69AE4", VA = "0xA69AE4", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0xA69B68", Offset = "0xA69B68", VA = "0xA69B68", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public override float AsFloat
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xA69BF0", Offset = "0xA69BF0", VA = "0xA69BF0", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xA69C74", Offset = "0xA69C74", VA = "0xA69C74", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public override double AsDouble
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xA69CFC", Offset = "0xA69CFC", VA = "0xA69CFC", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xA69D80", Offset = "0xA69D80", VA = "0xA69D80", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public override bool AsBool
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xA69E08", Offset = "0xA69E08", VA = "0xA69E08", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xA69E8C", Offset = "0xA69E8C", VA = "0xA69E8C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xA69F14", Offset = "0xA69F14", VA = "0xA69F14", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xA69F7C", Offset = "0xA69F7C", VA = "0xA69F7C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xA66688", Offset = "0xA66688", VA = "0xA66688")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xA6776C", Offset = "0xA6776C", VA = "0xA6776C")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xA696D4", Offset = "0xA696D4", VA = "0xA696D4")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xA6990C", Offset = "0xA6990C", VA = "0xA6990C", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xA6998C", Offset = "0xA6998C", VA = "0xA6998C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xA69A14", Offset = "0xA69A14", VA = "0xA69A14")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xA69A2C", Offset = "0xA69A2C", VA = "0xA69A2C")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xA69A44", Offset = "0xA69A44", VA = "0xA69A44", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xA69A5C", Offset = "0xA69A5C", VA = "0xA69A5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xA69A64", Offset = "0xA69A64", VA = "0xA69A64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xA69AA4", Offset = "0xA69AA4", VA = "0xA69AA4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x200015C")]
	public static class JSON
	{
		[Token(Token = "0x6000800")]
		[Address(RVA = "0xA69FE4", Offset = "0xA69FE4", VA = "0xA69FE4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace Better.StreamingAssets
{
	[Token(Token = "0x200015D")]
	public static class PathUtil
	{
		[Token(Token = "0x200015E")]
		private enum NormalizeState
		{
			[Token(Token = "0x4000628")]
			PrevSlash,
			[Token(Token = "0x4000629")]
			PrevDot,
			[Token(Token = "0x400062A")]
			PrevDoubleDot,
			[Token(Token = "0x400062B")]
			NothingSpecial
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xA69FE8", Offset = "0xA69FE8", VA = "0xA69FE8")]
		public static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xA6A004", Offset = "0xA6A004", VA = "0xA6A004")]
		public static string FixTrailingDirectorySeparators(string path)
		{
			return null;
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xA6A11C", Offset = "0xA6A11C", VA = "0xA6A11C")]
		public static string CombineSlash(string a, string b)
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xA6A278", Offset = "0xA6A278", VA = "0xA6A278")]
		public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xA6A694", Offset = "0xA6A694", VA = "0xA6A694")]
		public static bool IsValidCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xA6A6F8", Offset = "0xA6A6F8", VA = "0xA6A6F8")]
		public static Regex WildcardToRegex(string pattern)
		{
			return null;
		}
	}
	[Token(Token = "0x200015F")]
	internal class SubReadOnlyStream : Stream
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly long m_offset;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool m_leaveOpen;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long? m_length;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stream m_actualStream;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_position;

		[Token(Token = "0x170000E9")]
		public override long Length
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0xA6AA28", Offset = "0xA6AA28", VA = "0xA6AA28", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000EA")]
		public override long Position
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0xA6ABC4", Offset = "0xA6ABC4", VA = "0xA6ABC4", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600080B")]
			[Address(RVA = "0xA6ABE4", Offset = "0xA6ABE4", VA = "0xA6ABE4", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public override bool CanRead
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xA6AC28", Offset = "0xA6AC28", VA = "0xA6AC28", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		public override bool CanSeek
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0xA6AC48", Offset = "0xA6AC48", VA = "0xA6AC48", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public override bool CanWrite
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xA6AC68", Offset = "0xA6AC68", VA = "0xA6AC68", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xA6A83C", Offset = "0xA6A83C", VA = "0xA6A83C")]
		public SubReadOnlyStream(Stream actualStream, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xA6A910", Offset = "0xA6A910", VA = "0xA6A910")]
		public SubReadOnlyStream(Stream actualStream, long offset, long length, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xA6AC70", Offset = "0xA6AC70", VA = "0xA6AC70", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xA6AE28", Offset = "0xA6AE28", VA = "0xA6AE28", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xA6AEEC", Offset = "0xA6AEEC", VA = "0xA6AEEC", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xA6AF2C", Offset = "0xA6AF2C", VA = "0xA6AF2C", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xA6AF6C", Offset = "0xA6AF6C", VA = "0xA6AF6C", Slot = "20")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xA6AFAC", Offset = "0xA6AFAC", VA = "0xA6AFAC", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xA6AB34", Offset = "0xA6AB34", VA = "0xA6AB34")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xA6ADD0", Offset = "0xA6ADD0", VA = "0xA6ADD0")]
		private void ThrowIfCantRead()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class BSA_TestSceneGUI : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		private class CoroutineHost : MonoBehaviour
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xA6D6B4", Offset = "0xA6D6B4", VA = "0xA6D6B4")]
			public CoroutineHost()
			{
			}
		}

		[Token(Token = "0x2000162")]
		private class TestInfo
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReadMode readMode;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public TestType testType;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string path;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int attempts;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Exception error;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TimeSpan duration;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long bytesRead;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public long memoryPeak;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public long maxMemoryPeak;

			[Token(Token = "0x6000824")]
			[Address(RVA = "0xA6D6BC", Offset = "0xA6D6BC", VA = "0xA6D6BC")]
			public TestInfo()
			{
			}
		}

		[Token(Token = "0x2000163")]
		private delegate void TestResultDelegate(TimeSpan avgDuration, long avgBytesRead, long avgMemoryPeak, long maxMemoryPeak, string[] assetNames);

		[Token(Token = "0x2000164")]
		[Flags]
		private enum ReadMode
		{
			[Token(Token = "0x4000648")]
			BSA = 1,
			[Token(Token = "0x4000649")]
			WWW = 2,
			[Token(Token = "0x400064A")]
			Direct = 0x20,
			[Token(Token = "0x400064B")]
			UnityWebRequest = 0x40
		}

		[Token(Token = "0x2000165")]
		[Flags]
		private enum TestType
		{
			[Token(Token = "0x400064D")]
			CheckIfExists = 1,
			[Token(Token = "0x400064E")]
			LoadBytes = 2
		}

		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TestInfo testInfo;

			[Token(Token = "0x6000829")]
			[Address(RVA = "0xA6D878", Offset = "0xA6D878", VA = "0xA6D878")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0xA6D880", Offset = "0xA6D880", VA = "0xA6D880")]
			internal void <TestAllCoroutine>b__0(TimeSpan duration, long bytes, long memory, long maxMemory, string[] names)
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0xA6D8AC", Offset = "0xA6D8AC", VA = "0xA6D8AC")]
			internal void <TestAllCoroutine>b__1(Exception ex)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <TestAllCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<TestInfo> results;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IEnumerable<string> paths;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ReadMode readModes;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public TestType testTypes;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int attempts;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <logPath>5__2;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private IEnumerator<string> <>7__wrap2;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private string <path>5__4;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private IEnumerator <>7__wrap4;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ReadMode <readMode>5__6;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private IEnumerator <>7__wrap6;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0xA6EE44", Offset = "0xA6EE44", VA = "0xA6EE44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0xA6EE8C", Offset = "0xA6EE8C", VA = "0xA6EE8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0xA6D278", Offset = "0xA6D278", VA = "0xA6D278")]
			[DebuggerHidden]
			public <TestAllCoroutine>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xA6D8C8", Offset = "0xA6D8C8", VA = "0xA6D8C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0xA6DA60", Offset = "0xA6DA60", VA = "0xA6DA60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0xA6E770", Offset = "0xA6E770", VA = "0xA6E770")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0xA6E6C0", Offset = "0xA6E6C0", VA = "0xA6E6C0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xA6E604", Offset = "0xA6E604", VA = "0xA6E604")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xA6E548", Offset = "0xA6E548", VA = "0xA6E548")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xA6EE4C", Offset = "0xA6EE4C", VA = "0xA6EE4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[CompilerGenerated]
		private sealed class <ErrorCatchingCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator inner;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> onError;

			[Token(Token = "0x170000F1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000839")]
				[Address(RVA = "0xA6F0AC", Offset = "0xA6F0AC", VA = "0xA6F0AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600083B")]
				[Address(RVA = "0xA6F0F4", Offset = "0xA6F0F4", VA = "0xA6F0F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xA6D420", Offset = "0xA6D420", VA = "0xA6D420")]
			[DebuggerHidden]
			public <ErrorCatchingCoroutine>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0xA6EE94", Offset = "0xA6EE94", VA = "0xA6EE94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xA6EE98", Offset = "0xA6EE98", VA = "0xA6EE98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0xA6F0B4", Offset = "0xA6F0B4", VA = "0xA6F0B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class <TestHarness>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ReadMode readMode;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public TestType testType;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int attempts;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TestResultDelegate callback;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Stopwatch <stopwatch>5__2;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string[] <assetNames>5__3;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string <streamingAssetsUrl>5__4;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private long <bytesRead>5__5;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private long <maxMemoryPeak>5__6;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private long <totalMemoryPeaks>5__7;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int <i>5__8;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private IDisposable <toDispose>5__9;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private long <memoryUnityBefore>5__10;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private WWW <www>5__11;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private UnityWebRequest <www>5__12;

			[Token(Token = "0x170000F3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0xA6F82C", Offset = "0xA6F82C", VA = "0xA6F82C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0xA6F874", Offset = "0xA6F874", VA = "0xA6F874", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0xA6D510", Offset = "0xA6D510", VA = "0xA6D510")]
			[DebuggerHidden]
			public <TestHarness>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xA6F0FC", Offset = "0xA6F0FC", VA = "0xA6F0FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xA6F100", Offset = "0xA6F100", VA = "0xA6F100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xA6F834", Offset = "0xA6F834", VA = "0xA6F834", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text InProgressText;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string EditorApkPath;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int RepetitionCount;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool LogToFile;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_status;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TestType m_testModes;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private ReadMode m_readModes;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CoroutineHost coroutineHost;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 m_assetsScroll;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector2 m_resultsScroll;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] m_allStreamingAssets;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<TestInfo> m_results;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HashSet<string> m_selectedPaths;

		[Token(Token = "0x170000EE")]
		private string StreamingAssetsPath
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0xA6D270", Offset = "0xA6D270", VA = "0xA6D270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xA6B004", Offset = "0xA6B004", VA = "0xA6B004")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA6B024", Offset = "0xA6B024", VA = "0xA6B024")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA6B044", Offset = "0xA6B044", VA = "0xA6B044")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xA6CD30", Offset = "0xA6CD30", VA = "0xA6CD30")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xA6CF68", Offset = "0xA6CF68", VA = "0xA6CF68")]
		private void DoTestTypeToggle(TestType testMode)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xA6D088", Offset = "0xA6D088", VA = "0xA6D088")]
		private void DoReadModeToggle(ReadMode readMode)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xA6D1A8", Offset = "0xA6D1A8", VA = "0xA6D1A8")]
		[IteratorStateMachine(typeof(<TestAllCoroutine>d__26))]
		private IEnumerator TestAllCoroutine(IEnumerable<string> paths, int attempts, ReadMode readModes, TestType testTypes, List<TestInfo> results)
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xA6D2A0", Offset = "0xA6D2A0", VA = "0xA6D2A0")]
		private void LogWorkProgress(string status)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xA6D37C", Offset = "0xA6D37C", VA = "0xA6D37C")]
		[IteratorStateMachine(typeof(<ErrorCatchingCoroutine>d__28))]
		private IEnumerator ErrorCatchingCoroutine(IEnumerator inner, Action<Exception> onError)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xA6D448", Offset = "0xA6D448", VA = "0xA6D448")]
		[IteratorStateMachine(typeof(<TestHarness>d__29))]
		private IEnumerator TestHarness(ReadMode readMode, string path, TestType testType, int attempts, TestResultDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xA6D538", Offset = "0xA6D538", VA = "0xA6D538")]
		public BSA_TestSceneGUI()
		{
		}
	}
}
namespace Better.StreamingAssets.ZipArchive
{
	[Token(Token = "0x200016A")]
	internal struct ZipGenericExtraField
	{
		[Token(Token = "0x4000677")]
		private const int SizeOfHeader = 4;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _tag;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort _size;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] _data;

		[Token(Token = "0x170000F5")]
		public ushort Tag
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xA6F87C", Offset = "0xA6F87C", VA = "0xA6F87C")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x170000F6")]
		public ushort Size
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xA6F884", Offset = "0xA6F884", VA = "0xA6F884")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x170000F7")]
		public byte[] Data
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0xA6F88C", Offset = "0xA6F88C", VA = "0xA6F88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xA6F894", Offset = "0xA6F894", VA = "0xA6F894")]
		public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016B")]
	internal struct Zip64ExtraField
	{
		[Token(Token = "0x400067B")]
		public const int OffsetToFirstField = 4;

		[Token(Token = "0x400067C")]
		private const ushort TagConstant = 1;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _size;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long? _uncompressedSize;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long? _compressedSize;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long? _localHeaderOffset;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int? _startDiskNumber;

		[Token(Token = "0x170000F8")]
		public long? UncompressedSize
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0xA6F978", Offset = "0xA6F978", VA = "0xA6F978")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xA6F984", Offset = "0xA6F984", VA = "0xA6F984")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public long? CompressedSize
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0xA6FB14", Offset = "0xA6FB14", VA = "0xA6FB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0xA6FB20", Offset = "0xA6FB20", VA = "0xA6FB20")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public long? LocalHeaderOffset
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xA6FB28", Offset = "0xA6FB28", VA = "0xA6FB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xA6FB34", Offset = "0xA6FB34", VA = "0xA6FB34")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public int? StartDiskNumber
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xA6FB3C", Offset = "0xA6FB3C", VA = "0xA6FB3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xA6F98C", Offset = "0xA6F98C", VA = "0xA6F98C")]
		private void UpdateSize()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xA6FB44", Offset = "0xA6FB44", VA = "0xA6FB44")]
		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			return default(Zip64ExtraField);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xA6FDD8", Offset = "0xA6FDD8", VA = "0xA6FDD8")]
		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016C")]
	internal struct Zip64EndOfCentralDirectoryLocator
	{
		[Token(Token = "0x4000682")]
		public const uint SignatureConstant = 117853008u;

		[Token(Token = "0x4000683")]
		public const int SizeOfBlockWithoutSignature = 16;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint NumberOfDiskWithZip64EOCD;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong OffsetOfZip64EOCD;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint TotalNumberOfDisks;

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xA7154C", Offset = "0xA7154C", VA = "0xA7154C")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016D")]
	internal struct Zip64EndOfCentralDirectoryRecord
	{
		[Token(Token = "0x4000687")]
		private const uint SignatureConstant = 101075792u;

		[Token(Token = "0x4000688")]
		private const ulong NormalSize = 44uL;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong SizeOfThisRecord;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort VersionMadeBy;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint NumberOfThisDisk;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint NumberOfDiskWithStartOfCD;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong NumberOfEntriesOnThisDisk;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong NumberOfEntriesTotal;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong SizeOfCentralDirectory;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ulong OffsetOfCentralDirectory;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xA715EC", Offset = "0xA715EC", VA = "0xA715EC")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016E")]
	internal struct ZipLocalFileHeader
	{
		[Token(Token = "0x4000692")]
		public const uint DataDescriptorSignature = 134695760u;

		[Token(Token = "0x4000693")]
		public const uint SignatureConstant = 67324752u;

		[Token(Token = "0x4000694")]
		public const int OffsetToCrcFromHeaderStart = 14;

		[Token(Token = "0x4000695")]
		public const int OffsetToBitFlagFromHeaderStart = 6;

		[Token(Token = "0x4000696")]
		public const int SizeOfLocalHeader = 30;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xA71724", Offset = "0xA71724", VA = "0xA71724")]
		public static bool TrySkipBlock(BinaryReader reader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016F")]
	internal struct ZipCentralDirectoryFileHeader
	{
		[Token(Token = "0x4000697")]
		public const uint SignatureConstant = 33639248u;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte VersionMadeByCompatibility;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte VersionMadeBySpecification;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort GeneralPurposeBitFlag;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort CompressionMethod;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint LastModified;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint Crc32;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long CompressedSize;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long UncompressedSize;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ushort FilenameLength;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public ushort ExtraFieldLength;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ushort FileCommentLength;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int DiskNumberStart;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ushort InternalFileAttributes;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint ExternalFileAttributes;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long RelativeOffsetOfLocalHeader;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] Filename;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] FileComment;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ZipGenericExtraField> ExtraFields;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xA718AC", Offset = "0xA718AC", VA = "0xA718AC")]
		public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000170")]
	internal struct ZipEndOfCentralDirectoryBlock
	{
		[Token(Token = "0x40006AB")]
		public const uint SignatureConstant = 101010256u;

		[Token(Token = "0x40006AC")]
		public const int SizeOfBlockWithoutSignature = 18;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Signature;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort NumberOfThisDisk;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort NumberOfEntriesInTheCentralDirectory;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint SizeOfCentralDirectory;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] ArchiveComment;

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xA720B0", Offset = "0xA720B0", VA = "0xA720B0")]
		public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000171")]
	internal static class ZipHelper
	{
		[Token(Token = "0x40006B5")]
		internal const uint Mask32Bit = uint.MaxValue;

		[Token(Token = "0x40006B6")]
		internal const ushort Mask16Bit = ushort.MaxValue;

		[Token(Token = "0x40006B7")]
		private const int BackwardsSeekingBufferSize = 32;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xA721D8", Offset = "0xA721D8", VA = "0xA721D8")]
		internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xA72284", Offset = "0xA72284", VA = "0xA72284")]
		internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA71FC4", Offset = "0xA71FC4", VA = "0xA71FC4")]
		internal static void AdvanceToPosition(this Stream stream, long position)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA72380", Offset = "0xA72380", VA = "0xA72380")]
		private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000172")]
	public class ZipArchiveException : Exception
	{
		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA72498", Offset = "0xA72498", VA = "0xA72498")]
		public ZipArchiveException(string msg)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xA72500", Offset = "0xA72500", VA = "0xA72500")]
		public ZipArchiveException(string msg, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public static class ZipArchiveUtils
	{
		[Token(Token = "0x600085B")]
		[Address(RVA = "0xA72570", Offset = "0xA72570", VA = "0xA72570")]
		public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
		{
		}
	}
}
