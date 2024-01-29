using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820658", Offset = "0x820658")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xFE7E3C", Offset = "0xFE7E3C", VA = "0xFE7E3C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820690", Offset = "0x820690")]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xFE97C8", Offset = "0xFE97C8", VA = "0xFE97C8")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public static class BetterStreamingAssets
{
	[Token(Token = "0x2000005")]
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

	[Token(Token = "0x2000006")]
	internal static class ApkImpl
	{
		[Token(Token = "0x2000007")]
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

		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206C8", Offset = "0x8206C8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string searchPattern;

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1A6B5E4", Offset = "0x1A6B5E4", VA = "0x1A6B5E4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1A6B5EC", Offset = "0x1A6B5EC", VA = "0x1A6B5EC")]
			internal bool <GetFiles>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206D8", Offset = "0x8206D8")]
		private sealed class <>c__DisplayClass7_1
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Regex regex;

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1A6B61C", Offset = "0x1A6B61C", VA = "0x1A6B61C")]
			public <>c__DisplayClass7_1()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1A6B624", Offset = "0x1A6B624", VA = "0x1A6B624")]
			internal bool <GetFiles>b__1(string x)
			{
				return default(bool);
			}
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

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xFF9490", Offset = "0xFF9490", VA = "0xFF9490")]
		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xFF9F20", Offset = "0xFF9F20", VA = "0xFF9F20")]
		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xFFA094", Offset = "0xFFA094", VA = "0xFFA094")]
		public static bool DirectoryExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xFFA308", Offset = "0xFFA308", VA = "0xFFA308")]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xFFA7B4", Offset = "0xFFA7B4", VA = "0xFFA7B4")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xFFAA7C", Offset = "0xFFAA7C", VA = "0xFFAA7C")]
		public static Stream OpenRead(string path)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xFFA114", Offset = "0xFFA114", VA = "0xFFA114")]
		private static int GetDirectoryIndex(string path)
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xFF96D0", Offset = "0xFF96D0", VA = "0xFF96D0")]
		private static void GetStreamingAssetsInfoFromJar(string apkPath, List<string> paths, List<PartInfo> parts)
		{
		}
	}

	[Token(Token = "0x17000001")]
	public static string Root
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xD97ACC", Offset = "0xD97ACC", VA = "0xD97ACC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD9351C", Offset = "0xD9351C", VA = "0xD9351C")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD97B18", Offset = "0xD97B18", VA = "0xD97B18")]
	public static bool FileExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD97B48", Offset = "0xD97B48", VA = "0xD97B48")]
	public static bool DirectoryExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD97B50", Offset = "0xD97B50", VA = "0xD97B50")]
	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD97BDC", Offset = "0xD97BDC", VA = "0xD97BDC")]
	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD97C18", Offset = "0xD97C18", VA = "0xD97C18")]
	public static Stream OpenRead(string path)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD97CD0", Offset = "0xD97CD0", VA = "0xD97CD0")]
	public static StreamReader OpenText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD97DD8", Offset = "0xD97DD8", VA = "0xD97DD8")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD97F28", Offset = "0xD97F28", VA = "0xD97F28")]
	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD98114", Offset = "0xD98114", VA = "0xD98114")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD93B24", Offset = "0xD93B24", VA = "0xD93B24")]
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD981CC", Offset = "0xD981CC", VA = "0xD981CC")]
	public static string[] GetFiles(string path)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD981DC", Offset = "0xD981DC", VA = "0xD981DC")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD97B8C", Offset = "0xD97B8C", VA = "0xD97B8C")]
	private static ReadInfo GetInfoOrThrow(string path)
	{
		return default(ReadInfo);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD981E8", Offset = "0xD981E8", VA = "0xD981E8")]
	private static void ThrowFileNotFound(string path)
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class FastLUTPostprocess : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture3D lutTexture;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821440", Offset = "0x821440")]
	public bool enableBlendOfLUTIntensity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821478", Offset = "0x821478")]
	public float blendProgress;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821490", Offset = "0x821490")]
	public bool clampColorRangeTo01;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Shader lutShader;

	[Token(Token = "0x4000012")]
	private const string shaderName = "Hidden/MODev/Postprocess/FastLut";

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material lutMat;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xFE7E44", Offset = "0xFE7E44", VA = "0xFE7E44")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xFE7EDC", Offset = "0xFE7EDC", VA = "0xFE7EDC")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xFE8008", Offset = "0xFE8008", VA = "0xFE8008")]
	protected void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xFE8004", Offset = "0xFE8004", VA = "0xFE8004")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xFE8308", Offset = "0xFE8308", VA = "0xFE8308")]
	public void SetBlendProgress(float progress)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xFE8144", Offset = "0xFE8144", VA = "0xFE8144")]
	private void InitializeLUTMat()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xFE8320", Offset = "0xFE8320", VA = "0xFE8320")]
	public FastLUTPostprocess()
	{
	}
}
[Token(Token = "0x200000B")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD93E60", Offset = "0xD93E60", VA = "0xD93E60")]
	public string GetShaderNameForPipeline()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD93EF0", Offset = "0xD93EF0", VA = "0xD93EF0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD944BC", Offset = "0xD944BC", VA = "0xD944BC")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD946C4", Offset = "0xD946C4", VA = "0xD946C4")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xFE9EB0", Offset = "0xFE9EB0", VA = "0xFE9EB0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xFE9F90", Offset = "0xFE9F90", VA = "0xFE9F90")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000D")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xFEB8F8", Offset = "0xFEB8F8", VA = "0xFEB8F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xFEBA40", Offset = "0xFEBA40", VA = "0xFEBA40")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xFEBCB4", Offset = "0xFEBCB4", VA = "0xFEBCB4")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xFEC240", Offset = "0xFEC240", VA = "0xFEC240")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x200000E")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000030")]
	[Address(RVA = "0xFEA928", Offset = "0xFEA928", VA = "0xFEA928")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xFEAA08", Offset = "0xFEAA08", VA = "0xFEAA08")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000F")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206F8", Offset = "0x8206F8")]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1A699C0", Offset = "0x1A699C0", VA = "0x1A699C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1A69A08", Offset = "0x1A69A08", VA = "0x1A69A08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1A69830", Offset = "0x1A69830", VA = "0x1A69830")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1A6985C", Offset = "0x1A6985C", VA = "0x1A6985C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1A69860", Offset = "0x1A69860", VA = "0x1A69860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1A699C8", Offset = "0x1A699C8", VA = "0x1A699C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xFE9F98", Offset = "0xFE9F98", VA = "0xFE9F98")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xFEA030", Offset = "0xFEA030", VA = "0xFEA030")]
	private void Start()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xFEA40C", Offset = "0xFEA40C", VA = "0xFEA40C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x821E3C", Offset = "0x821E3C")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xFEA478", Offset = "0xFEA478", VA = "0xFEA478")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xFEA558", Offset = "0xFEA558", VA = "0xFEA558")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000011")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xFEA5D0", Offset = "0xFEA5D0", VA = "0xFEA5D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xFEA62C", Offset = "0xFEA62C", VA = "0xFEA62C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xFEA6B8", Offset = "0xFEA6B8", VA = "0xFEA6B8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xFEA798", Offset = "0xFEA798", VA = "0xFEA798")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000012")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xFEA7A0", Offset = "0xFEA7A0", VA = "0xFEA7A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xFEA838", Offset = "0xFEA838", VA = "0xFEA838")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x2000013")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x6000043")]
	[Address(RVA = "0xFEA840", Offset = "0xFEA840", VA = "0xFEA840")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xFEA920", Offset = "0xFEA920", VA = "0xFEA920")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000014")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xFEAA10", Offset = "0xFEAA10", VA = "0xFEAA10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xFEAC04", Offset = "0xFEAC04", VA = "0xFEAC04")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xFEB7D8", Offset = "0xFEB7D8", VA = "0xFEB7D8")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xFEB8F0", Offset = "0xFEB8F0", VA = "0xFEB8F0")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x2000015")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xFEC248", Offset = "0xFEC248", VA = "0xFEC248")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xFEC328", Offset = "0xFEC328", VA = "0xFEC328")]
	public void Start()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xFEC3CC", Offset = "0xFEC3CC", VA = "0xFEC3CC")]
	public void Update()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xFEC66C", Offset = "0xFEC66C", VA = "0xFEC66C")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000016")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000031")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000004")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xD94728", Offset = "0xD94728", VA = "0xD94728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xD94874", Offset = "0xD94874", VA = "0xD94874")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xD9488C", Offset = "0xD9488C", VA = "0xD9488C")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xD948A8", Offset = "0xD948A8", VA = "0xD948A8")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xD94EF0", Offset = "0xD94EF0", VA = "0xD94EF0")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xD950A4", Offset = "0xD950A4", VA = "0xD950A4")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820708", Offset = "0x820708")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x820708", Offset = "0x820708")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820778", Offset = "0x820778")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000083")]
				[Address(RVA = "0xFF9440", Offset = "0xFF9440", VA = "0xFF9440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000085")]
				[Address(RVA = "0xFF9488", Offset = "0xFF9488", VA = "0xFF9488", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xFF9378", Offset = "0xFF9378", VA = "0xFF9378")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xFF93A4", Offset = "0xFF93A4", VA = "0xFF93A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xFF93A8", Offset = "0xFF93A8", VA = "0xFF93A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0xFF9448", Offset = "0xFF9448", VA = "0xFF9448", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214D8", Offset = "0x8214D8")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214E8", Offset = "0x8214E8")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214F8", Offset = "0x8214F8")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000005")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xD95164", Offset = "0xD95164", VA = "0xD95164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EEC", Offset = "0x821EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xD9516C", Offset = "0xD9516C", VA = "0xD9516C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EFC", Offset = "0x821EFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xD95174", Offset = "0xD95174", VA = "0xD95174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F0C", Offset = "0x821F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xD9517C", Offset = "0xD9517C", VA = "0xD9517C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F1C", Offset = "0x821F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xD95184", Offset = "0xD95184", VA = "0xD95184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F2C", Offset = "0x821F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xD9518C", Offset = "0xD9518C", VA = "0xD9518C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F3C", Offset = "0x821F3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool visible
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xD95194", Offset = "0xD95194", VA = "0xD95194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xD951B0", Offset = "0xD951B0", VA = "0xD951B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int sortingLayerID
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xD951D0", Offset = "0xD951D0", VA = "0xD951D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xD951EC", Offset = "0xD951EC", VA = "0xD951EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public int sortingOrder
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xD95208", Offset = "0xD95208", VA = "0xD95208")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xD95224", Offset = "0xD95224", VA = "0xD95224")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xD95240", Offset = "0xD95240", VA = "0xD95240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xD95B24", Offset = "0xD95B24", VA = "0xD95B24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xD95B2C", Offset = "0xD95B2C", VA = "0xD95B2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xD96EC8", Offset = "0xD96EC8", VA = "0xD96EC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xD96F64", Offset = "0xD96F64", VA = "0xD96F64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD95250", Offset = "0xD95250", VA = "0xD95250")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xD95338", Offset = "0xD95338", VA = "0xD95338")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x821F4C", Offset = "0x821F4C")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xD953A4", Offset = "0xD953A4", VA = "0xD953A4")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xD954EC", Offset = "0xD954EC", VA = "0xD954EC")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xD95844", Offset = "0xD95844", VA = "0xD95844")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xD95900", Offset = "0xD95900", VA = "0xD95900")]
		private void Start()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xD959BC", Offset = "0xD959BC", VA = "0xD959BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xD95A60", Offset = "0xD95A60", VA = "0xD95A60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xD95BC0", Offset = "0xD95BC0", VA = "0xD95BC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD95C84", Offset = "0xD95C84", VA = "0xD95C84")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD96244", Offset = "0xD96244", VA = "0xD96244")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD96DF0", Offset = "0xD96DF0", VA = "0xD96DF0")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xD96004", Offset = "0xD96004", VA = "0xD96004")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xD9567C", Offset = "0xD9567C", VA = "0xD9567C", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD96FA8", Offset = "0xD96FA8", VA = "0xD96FA8", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD970D4", Offset = "0xD970D4", VA = "0xD970D4", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD97200", Offset = "0xD97200", VA = "0xD97200", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD97334", Offset = "0xD97334", VA = "0xD97334", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xD955B0", Offset = "0xD955B0", VA = "0xD955B0")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD95778", Offset = "0xD95778", VA = "0xD95778")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xD97424", Offset = "0xD97424", VA = "0xD97424")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD96588", Offset = "0xD96588", VA = "0xD96588")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xD97524", Offset = "0xD97524", VA = "0xD97524")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xD9769C", Offset = "0xD9769C", VA = "0xD9769C")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xD976A4", Offset = "0xD976A4", VA = "0xD976A4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xD97724", Offset = "0xD97724", VA = "0xD97724")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xD9780C", Offset = "0xD9780C", VA = "0xD9780C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xD97AC4", Offset = "0xD97AC4", VA = "0xD97AC4")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820788", Offset = "0x820788")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400003F")]
		public const string ClassName = "Config";

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821508", Offset = "0x821508")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821554", Offset = "0x821554")]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8215A0", Offset = "0x8215A0")]
		public float globalNoiseScale;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x17000012")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xD986F0", Offset = "0xD986F0", VA = "0xD986F0")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xD986F8", Offset = "0xD986F8", VA = "0xD986F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xD9876C", Offset = "0xD9876C", VA = "0xD9876C")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD98774", Offset = "0xD98774", VA = "0xD98774")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xD94828", Offset = "0xD94828", VA = "0xD94828")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000015")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xD98870", Offset = "0xD98870", VA = "0xD98870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xD9656C", Offset = "0xD9656C", VA = "0xD9656C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public Shader beamShader
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xD9888C", Offset = "0xD9888C", VA = "0xD9888C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xD9546C", Offset = "0xD9546C", VA = "0xD9546C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xD9892C", Offset = "0xD9892C", VA = "0xD9892C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static Config Instance
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xD947CC", Offset = "0xD947CC", VA = "0xD947CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD987E8", Offset = "0xD987E8", VA = "0xD987E8")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xD98894", Offset = "0xD98894", VA = "0xD98894")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xD989A8", Offset = "0xD989A8", VA = "0xD989A8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x821FFC", Offset = "0x821FFC")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xD98B80", Offset = "0xD98B80", VA = "0xD98B80")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xD98AA8", Offset = "0xD98AA8", VA = "0xD98AA8")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xD98C80", Offset = "0xD98C80", VA = "0xD98C80")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xD98E2C", Offset = "0xD98E2C", VA = "0xD98E2C")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xD98FFC", Offset = "0xD98FFC", VA = "0xD98FFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xD99008", Offset = "0xD99008", VA = "0xD99008")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xD9900C", Offset = "0xD9900C", VA = "0xD9900C")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xD991D0", Offset = "0xD991D0", VA = "0xD991D0")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8207C0", Offset = "0x8207C0")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400005A")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD992D8", Offset = "0xD992D8", VA = "0xD992D8")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class Consts
	{
		[Token(Token = "0x200001C")]
		public static class Help
		{
			[Token(Token = "0x400005C")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x400005D")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

			[Token(Token = "0x400005E")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			[Token(Token = "0x400005F")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

			[Token(Token = "0x4000060")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

			[Token(Token = "0x4000061")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			[Token(Token = "0x4000062")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

			[Token(Token = "0x4000063")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			[Token(Token = "0x4000064")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			[Token(Token = "0x4000065")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		[Token(Token = "0x200001D")]
		public static class Internal
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x1700001B")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x600009E")]
				[Address(RVA = "0xFE974C", Offset = "0xFE974C", VA = "0xFE974C")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x200001E")]
		public static class Beam
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x4000068")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x4000069")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x400006A")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x400006B")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x400006C")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x400006D")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x400006E")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x400006F")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000070")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000071")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000072")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x4000073")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x4000074")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x4000075")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x4000076")]
			public const bool GeomCap = false;

			[Token(Token = "0x4000077")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x4000078")]
			public const float AttenuationCustomBlending = 0.5f;

			[Token(Token = "0x4000079")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x400007A")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x400007B")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x400007C")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x400007D")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x400007E")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x400007F")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000080")]
			public const float GlareFrontal = 0.5f;

			[Token(Token = "0x4000081")]
			public const float GlareBehind = 0.5f;

			[Token(Token = "0x4000082")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x4000083")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x4000084")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x4000085")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x4000086")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x4000087")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x4000088")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x400008A")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x400008B")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x400008C")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x400008D")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x400008E")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000091")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200001F")]
		public static class DustParticles
		{
			[Token(Token = "0x4000092")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x4000093")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x4000094")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x4000096")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x4000097")]
			public const float DensityMin = 0f;

			[Token(Token = "0x4000098")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x400009A")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x400009B")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x400009C")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x2000020")]
		public static class DynOcclusion
		{
			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x400009E")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x400009F")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x40000A0")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x40000A1")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x40000A2")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x40000A3")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x40000A4")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x40000A5")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x40000A6")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x40000A7")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x40000A8")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x40000A9")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x40000AA")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x40000AB")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x40000AC")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x40000AD")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x2000021")]
		public static class Effects
		{
			[Token(Token = "0x40000AE")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x40000AF")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x40000B0")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x40000B1")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x40000B5")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x2000022")]
		public static class Config
		{
			[Token(Token = "0x40000B6")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x40000B7")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x40000B8")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x40000B9")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x40000BA")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x40000BB")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x40000BC")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x40000BD")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x40000BE")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x40000BF")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x40000C0")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x40000C1")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x40000C2")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x400005B")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x2000023")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000024")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8207F8", Offset = "0x8207F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8207F8", Offset = "0x8207F8")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x40000CD")]
			RenderLoop,
			[Token(Token = "0x40000CE")]
			OnEnable,
			[Token(Token = "0x40000CF")]
			EditorUpdate,
			[Token(Token = "0x40000D0")]
			User
		}

		[Token(Token = "0x40000C3")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x82160C", Offset = "0x82160C")]
		public int waitXFrames;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x1700001C")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xDA89A8", Offset = "0xDA89A8", VA = "0xDA89A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xDA8868", Offset = "0xDA8868", VA = "0xDA8868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82200C", Offset = "0x82200C")]
			add
			{
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xDA8908", Offset = "0xDA8908", VA = "0xDA8908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82201C", Offset = "0x82201C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xDA8634", Offset = "0xDA8634", VA = "0xDA8634")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xDA863C", Offset = "0xDA863C", VA = "0xDA863C")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x60000A9")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x60000AA")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x60000AB")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x60000AC")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x60000AD")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xDA89B0", Offset = "0xDA89B0", VA = "0xDA89B0", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xDA89E4", Offset = "0xDA89E4", VA = "0xDA89E4", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xDA8A58", Offset = "0xDA8A58", VA = "0xDA8A58", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xDA8AB4", Offset = "0xDA8AB4", VA = "0xDA8AB4", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xDA8C5C", Offset = "0xDA8C5C", VA = "0xDA8C5C", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xDA8CF8", Offset = "0xDA8CF8", VA = "0xDA8CF8")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xDA8A74", Offset = "0xDA8A74", VA = "0xDA8A74")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xDA8E88", Offset = "0xDA8E88", VA = "0xDA8E88")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xDA8EF4", Offset = "0xDA8EF4", VA = "0xDA8EF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82202C", Offset = "0x82202C")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82088C", Offset = "0x82088C")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000D1")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask layerMask;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int depthMapResolution;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xDA8EFC", Offset = "0xDA8EFC", VA = "0xDA8EFC", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xDA8F40", Offset = "0xDA8F40", VA = "0xDA8F40", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xDA8F48", Offset = "0xDA8F48", VA = "0xDA8F48")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xDA9114", Offset = "0xDA9114", VA = "0xDA9114", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xDA91A4", Offset = "0xDA91A4", VA = "0xDA91A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xDA8F78", Offset = "0xDA8F78", VA = "0xDA8F78")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xDA925C", Offset = "0xDA925C", VA = "0xDA925C")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xDA9314", Offset = "0xDA9314", VA = "0xDA9314", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xDA9380", Offset = "0xDA9380", VA = "0xDA9380")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xDA9670", Offset = "0xDA9670", VA = "0xDA9670", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xDA9674", Offset = "0xDA9674", VA = "0xDA9674", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xDA9718", Offset = "0xDA9718", VA = "0xDA9718", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xDA971C", Offset = "0xDA971C", VA = "0xDA971C", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xDA9740", Offset = "0xDA9740", VA = "0xDA9740")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xDA98A8", Offset = "0xDA98A8", VA = "0xDA98A8", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xDA9A40", Offset = "0xDA9A40", VA = "0xDA9A40")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8208D8", Offset = "0x8208D8")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000028")]
		public struct HitResult
		{
			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x17000021")]
			public bool hasCollider
			{
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x1A69078", Offset = "0x1A69078", VA = "0x1A69078")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000022")]
			public string name
			{
				[Token(Token = "0x60000E7")]
				[Address(RVA = "0x1A69128", Offset = "0x1A69128", VA = "0x1A69128")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			public Bounds bounds
			{
				[Token(Token = "0x60000E8")]
				[Address(RVA = "0x1A6920C", Offset = "0x1A6920C", VA = "0x1A6920C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1A68FA8", Offset = "0x1A68FA8", VA = "0x1A68FA8")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1A69010", Offset = "0x1A69010", VA = "0x1A69010")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1A69308", Offset = "0x1A69308", VA = "0x1A69308")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x2000029")]
		private enum Direction
		{
			[Token(Token = "0x40000EC")]
			Up = 0,
			[Token(Token = "0x40000ED")]
			Down = 1,
			[Token(Token = "0x40000EE")]
			Left = 2,
			[Token(Token = "0x40000EF")]
			Right = 3,
			[Token(Token = "0x40000F0")]
			Max2D = 1,
			[Token(Token = "0x40000F1")]
			Max3D = 3
		}

		[Token(Token = "0x40000D8")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dimensions dimensions;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LayerMask layerMask;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool considerTriggers;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minOccluderArea;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float planeOffset;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821654", Offset = "0x821654")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82168C", Offset = "0x82168C")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8232EC", Offset = "0x8232EC")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xDA9B08", Offset = "0xDA9B08", VA = "0xDA9B08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xDA9B10", Offset = "0xDA9B10", VA = "0xDA9B10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xDA9B64", Offset = "0xDA9B64", VA = "0xDA9B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82203C", Offset = "0x82203C")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xDA9B70", Offset = "0xDA9B70", VA = "0xDA9B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82204C", Offset = "0x82204C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xDA9DA4", Offset = "0xDA9DA4", VA = "0xDA9DA4")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000020")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xDA9DB8", Offset = "0xDA9DB8", VA = "0xDA9DB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD985B8", Offset = "0xD985B8", VA = "0xD985B8")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xDA9B18", Offset = "0xDA9B18", VA = "0xDA9B18", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xDA9B5C", Offset = "0xDA9B5C", VA = "0xDA9B5C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xDA9B7C", Offset = "0xDA9B7C", VA = "0xDA9B7C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xDA9BDC", Offset = "0xDA9BDC", VA = "0xDA9BDC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xDA9BE8", Offset = "0xDA9BE8", VA = "0xDA9BE8", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xDA9C40", Offset = "0xDA9C40", VA = "0xDA9C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xDA9CFC", Offset = "0xDA9CFC", VA = "0xDA9CFC")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xDA9E10", Offset = "0xDA9E10", VA = "0xDA9E10")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xDA9E60", Offset = "0xDA9E60", VA = "0xDA9E60")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xDAA11C", Offset = "0xDAA11C", VA = "0xDAA11C")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xDAA418", Offset = "0xDAA418", VA = "0xDAA418")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xDAA430", Offset = "0xDAA430", VA = "0xDAA430")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xDAA4C8", Offset = "0xDAA4C8", VA = "0xDAA4C8")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xDAA544", Offset = "0xDAA544", VA = "0xDAA544", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xDAA868", Offset = "0xDAA868", VA = "0xDAA868")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xDA9C18", Offset = "0xDA9C18", VA = "0xDA9C18")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xDAAA98", Offset = "0xDAAA98", VA = "0xDAAA98", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xDAA934", Offset = "0xDAA934", VA = "0xDAA934")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xDAAA50", Offset = "0xDAAA50", VA = "0xDAAA50")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xDAACA4", Offset = "0xDAACA4", VA = "0xDAACA4")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xDAACB0", Offset = "0xDAACB0", VA = "0xDAACB0")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x820924", Offset = "0x820924")]
	[DisallowMultipleComponent]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40000FC")]
			UnityLight = 1,
			[Token(Token = "0x40000FD")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40000FE")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x40000F2")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Light m_Light;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFE7668", Offset = "0xFE7668", VA = "0xFE7668")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFE78EC", Offset = "0xFE78EC", VA = "0xFE78EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFE7A6C", Offset = "0xFE7A6C", VA = "0xFE7A6C", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFE7A74", Offset = "0xFE7A74", VA = "0xFE7A74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xFE7AB4", Offset = "0xFE7AB4", VA = "0xFE7AB4")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820980", Offset = "0x820980")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209B8", Offset = "0x8209B8")]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remaining>5__2;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x1A696A8", Offset = "0x1A696A8", VA = "0x1A696A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F9")]
				[Address(RVA = "0x1A696F0", Offset = "0x1A696F0", VA = "0x1A696F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1A6959C", Offset = "0x1A6959C", VA = "0x1A6959C")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1A695C8", Offset = "0x1A695C8", VA = "0x1A695C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1A695CC", Offset = "0x1A695CC", VA = "0x1A695CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1A696B0", Offset = "0x1A696B0", VA = "0x1A696B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209C8", Offset = "0x8209C8")]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remainingDuration>5__2;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FD")]
				[Address(RVA = "0x1A6954C", Offset = "0x1A6954C", VA = "0x1A6954C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0x1A69594", Offset = "0x1A69594", VA = "0x1A69594", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1A69448", Offset = "0x1A69448", VA = "0x1A69448")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1A69474", Offset = "0x1A69474", VA = "0x1A69474", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1A69478", Offset = "0x1A69478", VA = "0x1A69478", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1A69554", Offset = "0x1A69554", VA = "0x1A69554", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209D8", Offset = "0x8209D8")]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float nextIntensity;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float expectedDuration;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <velocity>5__2;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000103")]
				[Address(RVA = "0x1A693F8", Offset = "0x1A693F8", VA = "0x1A693F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000105")]
				[Address(RVA = "0x1A69440", Offset = "0x1A69440", VA = "0x1A69440", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1A69310", Offset = "0x1A69310", VA = "0x1A69310")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1A6933C", Offset = "0x1A6933C", VA = "0x1A6933C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1A69340", Offset = "0x1A69340", VA = "0x1A69340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1A69400", Offset = "0x1A69400", VA = "0x1A69400", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FF")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82169C", Offset = "0x82169C")]
		public float frequency;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x8216B8", Offset = "0x8216B8")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x8216D0", Offset = "0x8216D0")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x8216E8", Offset = "0x8216E8")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821700", Offset = "0x821700")]
		public float smoothing;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xFE7ACC", Offset = "0xFE7ACC", VA = "0xFE7ACC", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFE7B04", Offset = "0xFE7B04", VA = "0xFE7B04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82205C", Offset = "0x82205C")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xFE7B70", Offset = "0xFE7B70", VA = "0xFE7B70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8220BC", Offset = "0x8220BC")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFE7BDC", Offset = "0xFE7BDC", VA = "0xFE7BDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82211C", Offset = "0x82211C")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xFE7C5C", Offset = "0xFE7C5C", VA = "0xFE7C5C")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8209E8", Offset = "0x8209E8")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A20", Offset = "0x820A20")]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectPulse <>4__this;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600010C")]
				[Address(RVA = "0x1A697E0", Offset = "0x1A697E0", VA = "0x1A697E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600010E")]
				[Address(RVA = "0x1A69828", Offset = "0x1A69828", VA = "0x1A69828", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1A696F8", Offset = "0x1A696F8", VA = "0x1A696F8")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1A69724", Offset = "0x1A69724", VA = "0x1A69724", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1A69728", Offset = "0x1A69728", VA = "0x1A69728", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1A697E8", Offset = "0x1A697E8", VA = "0x1A697E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000117")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821718", Offset = "0x821718")]
		public float frequency;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x821738", Offset = "0x821738")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xFE7D0C", Offset = "0xFE7D0C", VA = "0xFE7D0C", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xFE7D44", Offset = "0xFE7D44", VA = "0xFE7D44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82226C", Offset = "0x82226C")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFE7DB0", Offset = "0xFE7DB0", VA = "0xFE7DB0")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x400011F")]
		Off,
		[Token(Token = "0x4000120")]
		HighOnly,
		[Token(Token = "0x4000121")]
		HighAndLow
	}
	[Token(Token = "0x2000033")]
	public enum ColorMode
	{
		[Token(Token = "0x4000123")]
		Flat,
		[Token(Token = "0x4000124")]
		Gradient
	}
	[Token(Token = "0x2000034")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000126")]
		Linear,
		[Token(Token = "0x4000127")]
		Quadratic,
		[Token(Token = "0x4000128")]
		Blend
	}
	[Token(Token = "0x2000035")]
	public enum BlendingMode
	{
		[Token(Token = "0x400012A")]
		Additive,
		[Token(Token = "0x400012B")]
		SoftAdditive,
		[Token(Token = "0x400012C")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000036")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x400012E")]
		Fast,
		[Token(Token = "0x400012F")]
		High
	}
	[Token(Token = "0x2000037")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000131")]
		Disabled,
		[Token(Token = "0x4000132")]
		WorldSpace,
		[Token(Token = "0x4000133")]
		LocalSpace
	}
	[Token(Token = "0x2000038")]
	public enum MeshType
	{
		[Token(Token = "0x4000135")]
		Shared,
		[Token(Token = "0x4000136")]
		Custom
	}
	[Token(Token = "0x2000039")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000138")]
		BuiltIn,
		[Token(Token = "0x4000139")]
		URP,
		[Token(Token = "0x400013A")]
		HDRP
	}
	[Token(Token = "0x200003A")]
	public enum RenderingMode
	{
		[Token(Token = "0x400013C")]
		MultiPass,
		[Token(Token = "0x400013D")]
		SinglePass,
		[Token(Token = "0x400013E")]
		GPUInstancing,
		[Token(Token = "0x400013F")]
		SRPBatcher
	}
	[Token(Token = "0x200003B")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000141")]
		Custom = 0,
		[Token(Token = "0x4000142")]
		Background = 1000,
		[Token(Token = "0x4000143")]
		Geometry = 2000,
		[Token(Token = "0x4000144")]
		AlphaTest = 2450,
		[Token(Token = "0x4000145")]
		GeometryLast = 2500,
		[Token(Token = "0x4000146")]
		Transparent = 3000,
		[Token(Token = "0x4000147")]
		Overlay = 4000
	}
	[Token(Token = "0x200003C")]
	public enum Dimensions
	{
		[Token(Token = "0x4000149")]
		Dim3D,
		[Token(Token = "0x400014A")]
		Dim2D
	}
	[Token(Token = "0x200003D")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x400014C")]
		Surface,
		[Token(Token = "0x400014D")]
		Beam
	}
	[Token(Token = "0x200003E")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x400014F")]
		Never = 1,
		[Token(Token = "0x4000150")]
		OnEnable = 2,
		[Token(Token = "0x4000151")]
		OnBeamMove = 4,
		[Token(Token = "0x4000152")]
		EveryXFrames = 8,
		[Token(Token = "0x4000153")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200003F")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x4000155")]
		Random,
		[Token(Token = "0x4000156")]
		LocalSpace,
		[Token(Token = "0x4000157")]
		WorldSpace
	}
	[Token(Token = "0x2000040")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFE8C10", Offset = "0xFE8C10", VA = "0xFE8C10")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFE8E40", Offset = "0xFE8E40", VA = "0xFE8E40")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFE97C0", Offset = "0xFE97C0", VA = "0xFE97C0")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000043")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000161")]
			Additive,
			[Token(Token = "0x4000162")]
			SoftAdditive,
			[Token(Token = "0x4000163")]
			TraditionalTransparency,
			[Token(Token = "0x4000164")]
			Count
		}

		[Token(Token = "0x2000044")]
		public enum Noise3D
		{
			[Token(Token = "0x4000166")]
			Off,
			[Token(Token = "0x4000167")]
			On,
			[Token(Token = "0x4000168")]
			Count
		}

		[Token(Token = "0x2000045")]
		public enum DepthBlend
		{
			[Token(Token = "0x400016A")]
			Off,
			[Token(Token = "0x400016B")]
			On,
			[Token(Token = "0x400016C")]
			Count
		}

		[Token(Token = "0x2000046")]
		public enum ColorGradient
		{
			[Token(Token = "0x400016E")]
			Off,
			[Token(Token = "0x400016F")]
			MatrixLow,
			[Token(Token = "0x4000170")]
			MatrixHigh,
			[Token(Token = "0x4000171")]
			Count
		}

		[Token(Token = "0x2000047")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000173")]
			Off,
			[Token(Token = "0x4000174")]
			ClippingPlane,
			[Token(Token = "0x4000175")]
			DepthTexture,
			[Token(Token = "0x4000176")]
			Count
		}

		[Token(Token = "0x2000048")]
		public enum MeshSkewing
		{
			[Token(Token = "0x4000178")]
			Off,
			[Token(Token = "0x4000179")]
			On,
			[Token(Token = "0x400017A")]
			Count
		}

		[Token(Token = "0x2000049")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x400017C")]
			Fast,
			[Token(Token = "0x400017D")]
			High,
			[Token(Token = "0x400017E")]
			Count
		}

		[Token(Token = "0x200004A")]
		public struct StaticProperties
		{
			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x1700002C")]
			private int blendingModeID
			{
				[Token(Token = "0x6000117")]
				[Address(RVA = "0x1A69AA0", Offset = "0x1A69AA0", VA = "0x1A69AA0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002D")]
			private int noise3DID
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x1A69AA8", Offset = "0x1A69AA8", VA = "0x1A69AA8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002E")]
			private int depthBlendID
			{
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x1A69B28", Offset = "0x1A69B28", VA = "0x1A69B28")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002F")]
			private int colorGradientID
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x1A69BA8", Offset = "0x1A69BA8", VA = "0x1A69BA8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000030")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x1A69C28", Offset = "0x1A69C28", VA = "0x1A69C28")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000031")]
			private int meshSkewingID
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x1A69CA8", Offset = "0x1A69CA8", VA = "0x1A69CA8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000032")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x1A69D28", Offset = "0x1A69D28", VA = "0x1A69D28")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000033")]
			public int materialID
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x1A69DA8", Offset = "0x1A69DA8", VA = "0x1A69DA8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1A69E40", Offset = "0x1A69E40", VA = "0x1A69E40")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x200004B")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1A69A10", Offset = "0x1A69A10", VA = "0x1A69A10")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFEC674", Offset = "0xFEC674", VA = "0xFEC674")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFEC7E8", Offset = "0xFEC7E8", VA = "0xFEC7E8")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFEC8F4", Offset = "0xFEC8F4", VA = "0xFEC8F4")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public static class MaterialModifier
	{
		[Token(Token = "0x200004D")]
		public interface Interface
		{
			[Token(Token = "0x6000121")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x6000122")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x6000123")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x6000124")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x6000125")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x200004E")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x200004F")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000187")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xFECD40", Offset = "0xFECD40", VA = "0xFECD40")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xFECD58", Offset = "0xFECD58", VA = "0xFECD58")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFECDCC", Offset = "0xFECDCC", VA = "0xFECDCC")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFE8F48", Offset = "0xFE8F48", VA = "0xFE8F48")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFECE3C", Offset = "0xFECE3C", VA = "0xFECE3C")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFECEA0", Offset = "0xFECEA0", VA = "0xFECEA0")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFECEBC", Offset = "0xFECEBC", VA = "0xFECEBC")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFECEE4", Offset = "0xFECEE4", VA = "0xFECEE4")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFECF88", Offset = "0xFECF88", VA = "0xFECF88")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x17000034")]
		public float minValue
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xFED088", Offset = "0xFED088", VA = "0xFED088")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public float maxValue
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xFED090", Offset = "0xFED090", VA = "0xFED090")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float randomValue
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xFED098", Offset = "0xFED098", VA = "0xFED098")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public Vector2 asVector2
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xFED0A4", Offset = "0xFED0A4", VA = "0xFED0A4")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFED0AC", Offset = "0xFED0AC", VA = "0xFED0AC")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFED0C4", Offset = "0xFED0C4", VA = "0xFED0C4")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821770", Offset = "0x821770")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821780", Offset = "0x821780")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x17000038")]
		public float minValue
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xFED030", Offset = "0xFED030", VA = "0xFED030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82231C", Offset = "0x82231C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xFED038", Offset = "0xFED038", VA = "0xFED038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82232C", Offset = "0x82232C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float maxValue
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xFED040", Offset = "0xFED040", VA = "0xFED040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82233C", Offset = "0x82233C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xFED048", Offset = "0xFED048", VA = "0xFED048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82234C", Offset = "0x82234C")]
			private set
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xFED050", Offset = "0xFED050", VA = "0xFED050")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public static class Noise3D
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400018F")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700003A")]
		public static bool isSupported
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xFE83F4", Offset = "0xFE83F4", VA = "0xFE83F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xFED0CC", Offset = "0xFED0CC", VA = "0xFED0CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xFE854C", Offset = "0xFE854C", VA = "0xFE854C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xFED16C", Offset = "0xFED16C", VA = "0xFED16C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x82235C", Offset = "0x82235C")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xFED1C4", Offset = "0xFED1C4", VA = "0xFED1C4")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class PlatformHelper
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xFEDBF8", Offset = "0xFEDBF8", VA = "0xFEDBF8")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xFEDC10", Offset = "0xFEDC10", VA = "0xFEDC10")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xFEDC90", Offset = "0xFEDC90", VA = "0xFEDC90")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		public struct Plane2D
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1A6A518", Offset = "0x1A6A518", VA = "0x1A6A518")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1A6A534", Offset = "0x1A6A534", VA = "0x1A6A534")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1A6A560", Offset = "0x1A6A560", VA = "0x1A6A560")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1A6A658", Offset = "0x1A6A658", VA = "0x1A6A658")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1A6A67C", Offset = "0x1A6A67C", VA = "0x1A6A67C")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1A6A6DC", Offset = "0x1A6A6DC", VA = "0x1A6A6DC")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1A6A6EC", Offset = "0x1A6A6EC", VA = "0x1A6A6EC")]
			public void Flip()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1A6A708", Offset = "0x1A6A708", VA = "0x1A6A708")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1A6A8F4", Offset = "0x1A6A8F4", VA = "0x1A6A8F4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xFEDC98", Offset = "0xFEDC98", VA = "0xFEDC98")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public static class SRPHelper
	{
		[Token(Token = "0x2000057")]
		public enum RenderPipeline
		{
			[Token(Token = "0x4000194")]
			Undefined,
			[Token(Token = "0x4000195")]
			BuiltIn,
			[Token(Token = "0x4000196")]
			URP,
			[Token(Token = "0x4000197")]
			LWRP,
			[Token(Token = "0x4000198")]
			HDRP
		}

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x1700003D")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xFEDDA8", Offset = "0xFEDDA8", VA = "0xFEDDA8")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xFEDE58", Offset = "0xFEDE58", VA = "0xFEDE58")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xFEDF8C", Offset = "0xFEDF8C", VA = "0xFEDF8C")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xFEE084", Offset = "0xFEE084", VA = "0xFEE084")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xFEE134", Offset = "0xFEE134", VA = "0xFEE134")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x2000058")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x4000199")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x400019A")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x400019B")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x400019C")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x400019D")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x400019E")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x400019F")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x40001A0")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x40001A1")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000059")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820A40", Offset = "0x820A40")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A8C", Offset = "0x820A8C")]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000164")]
				[Address(RVA = "0x1A6ADF8", Offset = "0x1A6ADF8", VA = "0x1A6ADF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0x1A6AE40", Offset = "0x1A6AE40", VA = "0x1A6AE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1A6AD5C", Offset = "0x1A6AD5C", VA = "0x1A6AD5C")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1A6AD88", Offset = "0x1A6AD88", VA = "0x1A6AD88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1A6AD8C", Offset = "0x1A6AD8C", VA = "0x1A6AD8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1A6AE00", Offset = "0x1A6AE00", VA = "0x1A6AE00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xFEFA7C", Offset = "0xFEFA7C", VA = "0xFEFA7C")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xFEFB5C", Offset = "0xFEFB5C", VA = "0xFEFB5C")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xFEFC00", Offset = "0xFEFC00", VA = "0xFEFC00")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xFEFC44", Offset = "0xFEFC44", VA = "0xFEFC44")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xFEFC58", Offset = "0xFEFC58", VA = "0xFEFC58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xFEFCF8", Offset = "0xFEFCF8", VA = "0xFEFCF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xFEFD54", Offset = "0xFEFD54", VA = "0xFEFD54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82236C", Offset = "0x82236C")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xFEFC8C", Offset = "0xFEFC8C", VA = "0xFEFC8C")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xFEFDC0", Offset = "0xFEFDC0", VA = "0xFEFDC0")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public static class TransformUtils
	{
		[Token(Token = "0x200005D")]
		public struct Packed
		{
			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1A6AE48", Offset = "0x1A6AE48", VA = "0x1A6AE48")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xFF04F4", Offset = "0xFF04F4", VA = "0xFF04F4")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820AAC", Offset = "0x820AAC")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x820AAC", Offset = "0x820AAC")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x40001D6")]
			OnEnable,
			[Token(Token = "0x40001D7")]
			OnOcclusionChange
		}

		[Token(Token = "0x40001CE")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40001D1")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000040")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xFF058C", Offset = "0xFF058C", VA = "0xFF058C")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xFF061C", Offset = "0xFF061C", VA = "0xFF061C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xFF0D6C", Offset = "0xFF0D6C", VA = "0xFF0D6C")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xFF0780", Offset = "0xFF0780", VA = "0xFF0780")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xFF0F78", Offset = "0xFF0F78", VA = "0xFF0F78")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public static class Utils
	{
		[Token(Token = "0x2000061")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40001DC")]
			High = 64,
			[Token(Token = "0x40001DD")]
			Low = 8,
			[Token(Token = "0x40001DE")]
			Undef = 0
		}

		[Token(Token = "0x40001D8")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40001DA")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xFF0F90", Offset = "0xFF0F90", VA = "0xFF0F90")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xFF0FC8", Offset = "0xFF0FC8", VA = "0xFF0FC8")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xFF1100", Offset = "0xFF1100", VA = "0xFF1100")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xFF11E0", Offset = "0xFF11E0", VA = "0xFF11E0")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xFF11E4", Offset = "0xFF11E4", VA = "0xFF11E4")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xFF11EC", Offset = "0xFF11EC", VA = "0xFF11EC")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xFF11F8", Offset = "0xFF11F8", VA = "0xFF11F8")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xFF1208", Offset = "0xFF1208", VA = "0xFF1208")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xFF1214", Offset = "0xFF1214", VA = "0xFF1214")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xFF121C", Offset = "0xFF121C", VA = "0xFF121C")]
		public static bool Approximately(float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xFF122C", Offset = "0xFF122C", VA = "0xFF122C")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xFF1260", Offset = "0xFF1260", VA = "0xFF1260")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xFF128C", Offset = "0xFF128C", VA = "0xFF128C")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xFF12E8", Offset = "0xFF12E8", VA = "0xFF12E8")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xFF1318", Offset = "0xFF1318", VA = "0xFF1318")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xFF13C4", Offset = "0xFF13C4", VA = "0xFF13C4")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xFF1418", Offset = "0xFF1418", VA = "0xFF1418")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xFF14B8", Offset = "0xFF14B8", VA = "0xFF14B8")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFF14EC", Offset = "0xFF14EC", VA = "0xFF14EC")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xFF0EFC", Offset = "0xFF0EFC", VA = "0xFF0EFC")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xFF0EE4", Offset = "0xFF0EE4", VA = "0xFF0EE4")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xFF0E98", Offset = "0xFF0E98", VA = "0xFF0E98")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xFF1594", Offset = "0xFF1594", VA = "0xFF1594")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xFF15B8", Offset = "0xFF15B8", VA = "0xFF15B8")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFF15CC", Offset = "0xFF15CC", VA = "0xFF15CC")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xFF17E8", Offset = "0xFF17E8", VA = "0xFF17E8")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xFF18CC", Offset = "0xFF18CC", VA = "0xFF18CC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xFF16F0", Offset = "0xFF16F0", VA = "0xFF16F0")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFF190C", Offset = "0xFF190C", VA = "0xFF190C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFF19D8", Offset = "0xFF19D8", VA = "0xFF19D8")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFF19DC", Offset = "0xFF19DC", VA = "0xFF19DC")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class Version
	{
		[Token(Token = "0x40001DF")]
		public const int Current = 1950;
	}
	[Token(Token = "0x2000063")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x820B50", Offset = "0x820B50")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820B50", Offset = "0x820B50")]
	[ExecuteInEditMode]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821790", Offset = "0x821790")]
		public float alpha;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8217A8", Offset = "0x8217A8")]
		public float size;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8217C8", Offset = "0x8217C8")]
		public float speed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x821800", Offset = "0x821800")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x821818", Offset = "0x821818")]
		public float spawnMinDistance;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x821850", Offset = "0x821850")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821888", Offset = "0x821888")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_Material;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Gradient m_GradientCached;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000041")]
		public bool isCulled
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xFF19E4", Offset = "0xFF19E4", VA = "0xFF19E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82259C", Offset = "0x82259C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xFF19EC", Offset = "0xFF19EC", VA = "0xFF19EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225AC", Offset = "0x8225AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xFF19F8", Offset = "0xFF19F8", VA = "0xFF19F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xFE78D0", Offset = "0xFE78D0", VA = "0xFE78D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xFF1A00", Offset = "0xFF1A00", VA = "0xFF1A00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xFF1A68", Offset = "0xFF1A68", VA = "0xFF1A68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xFF1AF8", Offset = "0xFF1AF8", VA = "0xFF1AF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xFF1BA0", Offset = "0xFF1BA0", VA = "0xFF1BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xFF1E24", Offset = "0xFF1E24", VA = "0xFF1E24")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xFF1F6C", Offset = "0xFF1F6C", VA = "0xFF1F6C")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xFF2270", Offset = "0xFF2270", VA = "0xFF2270")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xFF2298", Offset = "0xFF2298", VA = "0xFF2298")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xFF21E0", Offset = "0xFF21E0", VA = "0xFF21E0")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xFF2344", Offset = "0xFF2344", VA = "0xFF2344")]
		private void Play()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xFF2A70", Offset = "0xFF2A70", VA = "0xFF2A70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xFF2A78", Offset = "0xFF2A78", VA = "0xFF2A78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xFF2B8C", Offset = "0xFF2B8C", VA = "0xFF2B8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xFF23F0", Offset = "0xFF23F0", VA = "0xFF23F0")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xFF1EAC", Offset = "0xFF1EAC", VA = "0xFF1EAC")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xFF2CB8", Offset = "0xFF2CB8", VA = "0xFF2CB8")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xFF3150", Offset = "0xFF3150", VA = "0xFF3150")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x820BF4", Offset = "0x820BF4")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000066")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C60", Offset = "0x820C60")]
		private sealed class <CoPlaytimeUpdate>d__187 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x1A6AF8C", Offset = "0x1A6AF8C", VA = "0x1A6AF8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x1A6AFD4", Offset = "0x1A6AFD4", VA = "0x1A6AFD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1A6AED8", Offset = "0x1A6AED8", VA = "0x1A6AED8")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__187(int <>1__state)
			{
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1A6AF04", Offset = "0x1A6AF04", VA = "0x1A6AF04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1A6AF08", Offset = "0x1A6AF08", VA = "0x1A6AF08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1A6AF94", Offset = "0x1A6AF94", VA = "0x1A6AF94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F6")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8218A8", Offset = "0x8218A8")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x8218A8", Offset = "0x8218A8")]
		public Color color;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8218FC", Offset = "0x8218FC")]
		public float intensityInside;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821934", Offset = "0x821934")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821934", Offset = "0x821934")]
		public float intensityOutside;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821994", Offset = "0x821994")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8219CC", Offset = "0x8219CC")]
		public float spotAngle;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8219EC", Offset = "0x8219EC")]
		public float coneRadiusStart;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821A24", Offset = "0x821A24")]
		public int geomCustomSides;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821A5C", Offset = "0x821A5C")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821A94", Offset = "0x821A94")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821AAC", Offset = "0x821AAC")]
		public float fallOffStart;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821AE4", Offset = "0x821AE4")]
		public float fallOffEnd;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821B1C", Offset = "0x821B1C")]
		public float glareFrontal;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821B34", Offset = "0x821B34")]
		public float glareBehind;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821B4C", Offset = "0x821B4C")]
		public float fresnelPow;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821B84", Offset = "0x821B84")]
		public float noiseIntensity;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821B9C", Offset = "0x821B9C")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821BD8", Offset = "0x821BD8")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821C44", Offset = "0x821C44")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821C90", Offset = "0x821C90")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821CDC", Offset = "0x821CDC")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Light m_CachedLight;

		[Token(Token = "0x17000047")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xFF2EAC", Offset = "0xFF2EAC", VA = "0xFF2EAC")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000048")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x823324", Offset = "0x823324")]
		public float alphaInside
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xFF3244", Offset = "0xFF3244", VA = "0xFF3244")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xFF324C", Offset = "0xFF324C", VA = "0xFF324C")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x82335C", Offset = "0x82335C")]
		public float alphaOutside
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xFF3254", Offset = "0xFF3254", VA = "0xFF3254")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xFF325C", Offset = "0xFF325C", VA = "0xFF325C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float intensityGlobal
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xFF3264", Offset = "0xFF3264", VA = "0xFF3264")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xFF326C", Offset = "0xFF326C", VA = "0xFF326C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public float coneAngle
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xFF2F2C", Offset = "0xFF2F2C", VA = "0xFF2F2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xFF0D70", Offset = "0xFF0D70", VA = "0xFF0D70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		public float coneVolume
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xFF32D4", Offset = "0xFF32D4", VA = "0xFF32D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xFF3328", Offset = "0xFF3328", VA = "0xFF3328")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public int geomSides
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xFF0E10", Offset = "0xFF0E10", VA = "0xFF0E10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xFF33A0", Offset = "0xFF33A0", VA = "0xFF33A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public int geomSegments
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xFF3428", Offset = "0xFF3428", VA = "0xFF3428")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xFF34B0", Offset = "0xFF34B0", VA = "0xFF34B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xFF3538", Offset = "0xFF3538", VA = "0xFF3538")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000052")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xFF365C", Offset = "0xFF365C", VA = "0xFF365C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000053")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xFEFBF0", Offset = "0xFEFBF0", VA = "0xFEFBF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xFF3784", Offset = "0xFF3784", VA = "0xFF3784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x823394", Offset = "0x823394")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xFF3860", Offset = "0xFF3860", VA = "0xFF3860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xFF3868", Offset = "0xFF3868", VA = "0xFF3868")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xFF3874", Offset = "0xFF3874", VA = "0xFF3874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000057")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8233CC", Offset = "0x8233CC")]
		public float fadeStart
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xFF389C", Offset = "0xFF389C", VA = "0xFF389C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xFF38A4", Offset = "0xFF38A4", VA = "0xFF38A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x823404", Offset = "0x823404")]
		public float fadeEnd
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xFF38AC", Offset = "0xFF38AC", VA = "0xFF38AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xFF38B4", Offset = "0xFF38B4", VA = "0xFF38B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xFF32A0", Offset = "0xFF32A0", VA = "0xFF32A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005A")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xFF38BC", Offset = "0xFF38BC", VA = "0xFF38BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x82343C", Offset = "0x82343C")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xFF38CC", Offset = "0xFF38CC", VA = "0xFF38CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xFF38DC", Offset = "0xFF38DC", VA = "0xFF38DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float fadeOutBegin
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xFF38F8", Offset = "0xFF38F8", VA = "0xFF38F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xFF3900", Offset = "0xFF3900", VA = "0xFF3900")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xFF395C", Offset = "0xFF395C", VA = "0xFF395C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xFF3964", Offset = "0xFF3964", VA = "0xFF3964")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xFF2F98", Offset = "0xFF2F98", VA = "0xFF2F98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public bool isTilted
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xFF396C", Offset = "0xFF396C", VA = "0xFF396C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public int sortingLayerID
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xFF3A0C", Offset = "0xFF3A0C", VA = "0xFF3A0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xFF3A14", Offset = "0xFF3A14", VA = "0xFF3A14")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public string sortingLayerName
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xFF3AB8", Offset = "0xFF3AB8", VA = "0xFF3AB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xFF3AC4", Offset = "0xFF3AC4", VA = "0xFF3AC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public int sortingOrder
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xFF3AF4", Offset = "0xFF3AF4", VA = "0xFF3AF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xFF3AFC", Offset = "0xFF3AFC", VA = "0xFF3AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xFF3BA0", Offset = "0xFF3BA0", VA = "0xFF3BA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xFF3BA8", Offset = "0xFF3BA8", VA = "0xFF3BA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xFF3C08", Offset = "0xFF3C08", VA = "0xFF3C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public bool hasGeometry
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xFF2FBC", Offset = "0xFF2FBC", VA = "0xFF2FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public Bounds bounds
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xFF3028", Offset = "0xFF3028", VA = "0xFF3028")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000067")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xFF3C18", Offset = "0xFF3C18", VA = "0xFF3C18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000068")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xFF2208", Offset = "0xFF2208", VA = "0xFF2208")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xFF3CFC", Offset = "0xFF3CFC", VA = "0xFF3CFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xFF3D14", Offset = "0xFF3D14", VA = "0xFF3D14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006B")]
		public float raycastDistance
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xFF3DAC", Offset = "0xFF3DAC", VA = "0xFF3DAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xFF3E3C", Offset = "0xFF3E3C", VA = "0xFF3E3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xFF3EE4", Offset = "0xFF3EE4", VA = "0xFF3EE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xFF3F60", Offset = "0xFF3F60", VA = "0xFF3F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xFF3FDC", Offset = "0xFF3FDC", VA = "0xFF3FDC")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xFF405C", Offset = "0xFF405C", VA = "0xFF405C")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xFF4064", Offset = "0xFF4064", VA = "0xFF4064")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000071")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xFF4380", Offset = "0xFF4380", VA = "0xFF4380")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xFF442C", Offset = "0xFF442C", VA = "0xFF442C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225DC", Offset = "0x8225DC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xFF4434", Offset = "0xFF4434", VA = "0xFF4434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225EC", Offset = "0x8225EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public string meshStats
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xFF443C", Offset = "0xFF443C", VA = "0xFF443C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xFF45F0", Offset = "0xFF45F0", VA = "0xFF45F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xFF46C8", Offset = "0xFF46C8", VA = "0xFF46C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000076")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xFF4890", Offset = "0xFF4890", VA = "0xFF4890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xFF412C", Offset = "0xFF412C", VA = "0xFF412C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225BC", Offset = "0x8225BC")]
			add
			{
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xFF41CC", Offset = "0xFF41CC", VA = "0xFF41CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225CC", Offset = "0x8225CC")]
			remove
			{
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xFF3274", Offset = "0xFF3274", VA = "0xFF3274")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xFF4078", Offset = "0xFF4078", VA = "0xFF4078")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xFF426C", Offset = "0xFF426C", VA = "0xFF426C")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xFF4280", Offset = "0xFF4280", VA = "0xFF4280")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xFF4350", Offset = "0xFF4350", VA = "0xFF4350")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xFF3908", Offset = "0xFF3908", VA = "0xFF3908")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xFF4388", Offset = "0xFF4388", VA = "0xFF4388")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xFF47B8", Offset = "0xFF47B8", VA = "0xFF47B8")]
		private Light GetLightSpotAttached()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xFF486C", Offset = "0xFF486C", VA = "0xFF486C")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xFF4898", Offset = "0xFF4898", VA = "0xFF4898")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xFF48F8", Offset = "0xFF48F8", VA = "0xFF48F8")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xFF4A70", Offset = "0xFF4A70", VA = "0xFF4A70")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8225FC", Offset = "0x8225FC")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xFF4A7C", Offset = "0xFF4A7C", VA = "0xFF4A7C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xFF4D00", Offset = "0xFF4D00", VA = "0xFF4D00", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xFF4DA0", Offset = "0xFF4DA0", VA = "0xFF4DA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xFF4DD0", Offset = "0xFF4DD0", VA = "0xFF4DD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xFF4E5C", Offset = "0xFF4E5C", VA = "0xFF4E5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xFF3BB4", Offset = "0xFF3BB4", VA = "0xFF3BB4")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xFF4EE8", Offset = "0xFF4EE8", VA = "0xFF4EE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x822634", Offset = "0x822634")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xFF4F54", Offset = "0xFF4F54", VA = "0xFF4F54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xFF4F58", Offset = "0xFF4F58", VA = "0xFF4F58")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xFF5014", Offset = "0xFF5014", VA = "0xFF5014")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xFF5110", Offset = "0xFF5110", VA = "0xFF5110")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xFF4CD8", Offset = "0xFF4CD8", VA = "0xFF4CD8")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xFF4BD8", Offset = "0xFF4BD8", VA = "0xFF4BD8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xFF52A0", Offset = "0xFF52A0", VA = "0xFF52A0")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x820C70", Offset = "0x820C70")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xD98244", Offset = "0xD98244", VA = "0xD98244")]
		private void Update()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD98340", Offset = "0xD98340", VA = "0xD98340")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x820CD0", Offset = "0x820CD0")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xD98350", Offset = "0xD98350", VA = "0xD98350")]
		private void Start()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xD98420", Offset = "0xD98420", VA = "0xD98420")]
		private void Update()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xD984E4", Offset = "0xD984E4", VA = "0xD984E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xD984EC", Offset = "0xD984EC", VA = "0xD984EC")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xD986E8", Offset = "0xD986E8", VA = "0xD986E8")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0xFE8330", Offset = "0xFE8330", VA = "0xFE8330")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xFE85F4", Offset = "0xFE85F4", VA = "0xFE85F4")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000079")]
		private bool useMouseView
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xFE85FC", Offset = "0xFE85FC", VA = "0xFE85FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xFE8604", Offset = "0xFE8604", VA = "0xFE8604")]
			set
			{
			}
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xFE8640", Offset = "0xFE8640", VA = "0xFE8640")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xFE86D8", Offset = "0xFE86D8", VA = "0xFE86D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xFE8BEC", Offset = "0xFE8BEC", VA = "0xFE8BEC")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821CFC", Offset = "0x821CFC")]
		private int CountX;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x821D40", Offset = "0x821D40")]
		private int CountY;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xFE97D0", Offset = "0xFE97D0", VA = "0xFE97D0")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xFE9E94", Offset = "0xFE9E94", VA = "0xFE9E94")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x821DC4", Offset = "0x821DC4")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xFEDCA0", Offset = "0xFEDCA0", VA = "0xFEDCA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xFEDD74", Offset = "0xFEDD74", VA = "0xFEDD74")]
		public Rotater()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200006E")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D98", Offset = "0x820D98")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000234")]
			[Address(RVA = "0xFFB0BC", Offset = "0xFFB0BC", VA = "0xFFB0BC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0xFFB0C4", Offset = "0xFFB0C4", VA = "0xFFB0C4")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0xFFB0E0", Offset = "0xFFB0E0", VA = "0xFFB0E0")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DA8", Offset = "0x820DA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000237")]
			[Address(RVA = "0xFFB0FC", Offset = "0xFFB0FC", VA = "0xFFB0FC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0xFFB104", Offset = "0xFFB104", VA = "0xFFB104")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0xFFB120", Offset = "0xFFB120", VA = "0xFFB120")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DB8", Offset = "0x820DB8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x600023A")]
			[Address(RVA = "0xFFB13C", Offset = "0xFFB13C", VA = "0xFFB13C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0xFFB144", Offset = "0xFFB144", VA = "0xFFB144")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0xFFB184", Offset = "0xFFB184", VA = "0xFFB184")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xD9D8B4", Offset = "0xD9D8B4", VA = "0xD9D8B4")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xD9DA94", Offset = "0xD9DA94", VA = "0xD9DA94")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD9DC2C", Offset = "0xD9DC2C", VA = "0xD9DC2C")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD9DDC8", Offset = "0xD9DDC8", VA = "0xD9DDC8")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD9DE3C", Offset = "0xD9DE3C", VA = "0xD9DE3C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD9DEB0", Offset = "0xD9DEB0", VA = "0xD9DEB0")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD9DF14", Offset = "0xD9DF14", VA = "0xD9DF14")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD9DF98", Offset = "0xD9DF98", VA = "0xD9DF98")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xD9DFFC", Offset = "0xD9DFFC", VA = "0xD9DFFC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD9E060", Offset = "0xD9E060", VA = "0xD9E060")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xD9E0C4", Offset = "0xD9E0C4", VA = "0xD9E0C4")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD9E128", Offset = "0xD9E128", VA = "0xD9E128")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD9E194", Offset = "0xD9E194", VA = "0xD9E194")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD9E1FC", Offset = "0xD9E1FC", VA = "0xD9E1FC")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD9E260", Offset = "0xD9E260", VA = "0xD9E260")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000072")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DD8", Offset = "0x820DD8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000248")]
			[Address(RVA = "0xFFB1A8", Offset = "0xFFB1A8", VA = "0xFFB1A8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0xFFB1B0", Offset = "0xFFB1B0", VA = "0xFFB1B0")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DE8", Offset = "0x820DE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600024A")]
			[Address(RVA = "0xFFB2F0", Offset = "0xFFB2F0", VA = "0xFFB2F0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0xFFB2F8", Offset = "0xFFB2F8", VA = "0xFFB2F8")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DF8", Offset = "0x820DF8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600024C")]
			[Address(RVA = "0xFFB314", Offset = "0xFFB314", VA = "0xFFB314")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0xFFB31C", Offset = "0xFFB31C", VA = "0xFFB31C")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E08", Offset = "0x820E08")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600024E")]
			[Address(RVA = "0xFFB338", Offset = "0xFFB338", VA = "0xFFB338")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0xFFB340", Offset = "0xFFB340", VA = "0xFFB340")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E18", Offset = "0x820E18")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000250")]
			[Address(RVA = "0xFFB35C", Offset = "0xFFB35C", VA = "0xFFB35C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0xFFB364", Offset = "0xFFB364", VA = "0xFFB364")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E28", Offset = "0x820E28")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000252")]
			[Address(RVA = "0xFFB380", Offset = "0xFFB380", VA = "0xFFB380")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0xFFB388", Offset = "0xFFB388", VA = "0xFFB388")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E38", Offset = "0x820E38")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000254")]
			[Address(RVA = "0xFFB3A4", Offset = "0xFFB3A4", VA = "0xFFB3A4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0xFFB3AC", Offset = "0xFFB3AC", VA = "0xFFB3AC")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0xFFB3C8", Offset = "0xFFB3C8", VA = "0xFFB3C8")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0xFFB3FC", Offset = "0xFFB3FC", VA = "0xFFB3FC")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0xFFB418", Offset = "0xFFB418", VA = "0xFFB418")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0xFFB434", Offset = "0xFFB434", VA = "0xFFB434")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E48", Offset = "0x820E48")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600025A")]
			[Address(RVA = "0xFFB4F4", Offset = "0xFFB4F4", VA = "0xFFB4F4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0xFFB4FC", Offset = "0xFFB4FC", VA = "0xFFB4FC")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E58", Offset = "0x820E58")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600025C")]
			[Address(RVA = "0xFFB518", Offset = "0xFFB518", VA = "0xFFB518")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0xFFB520", Offset = "0xFFB520", VA = "0xFFB520")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0xFFB53C", Offset = "0xFFB53C", VA = "0xFFB53C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E68", Offset = "0x820E68")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600025F")]
			[Address(RVA = "0xFFB63C", Offset = "0xFFB63C", VA = "0xFFB63C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0xFFB644", Offset = "0xFFB644", VA = "0xFFB644")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E78", Offset = "0x820E78")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000261")]
			[Address(RVA = "0xFFB1CC", Offset = "0xFFB1CC", VA = "0xFFB1CC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0xFFB1D4", Offset = "0xFFB1D4", VA = "0xFFB1D4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0xFFB1F0", Offset = "0xFFB1F0", VA = "0xFFB1F0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD9B020", Offset = "0xD9B020", VA = "0xD9B020")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD9E2C4", Offset = "0xD9E2C4", VA = "0xD9E2C4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD9E484", Offset = "0xD9E484", VA = "0xD9E484")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD9E644", Offset = "0xD9E644", VA = "0xD9E644")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD9B1EC", Offset = "0xD9B1EC", VA = "0xD9B1EC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD9E804", Offset = "0xD9E804", VA = "0xD9E804")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD9EA48", Offset = "0xD9EA48", VA = "0xD9EA48")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD9EF40", Offset = "0xD9EF40", VA = "0xD9EF40")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD9F1AC", Offset = "0xD9F1AC", VA = "0xD9F1AC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD9F42C", Offset = "0xD9F42C", VA = "0xD9F42C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD9F60C", Offset = "0xD9F60C", VA = "0xD9F60C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E98", Offset = "0x820E98")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000268")]
			[Address(RVA = "0xFFB660", Offset = "0xFFB660", VA = "0xFFB660")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0xFFB668", Offset = "0xFFB668", VA = "0xFFB668")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0xFFB684", Offset = "0xFFB684", VA = "0xFFB684")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EA8", Offset = "0x820EA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xFFB6A0", Offset = "0xFFB6A0", VA = "0xFFB6A0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xFFB6A8", Offset = "0xFFB6A8", VA = "0xFFB6A8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xFFB6C4", Offset = "0xFFB6C4", VA = "0xFFB6C4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EB8", Offset = "0x820EB8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600026E")]
			[Address(RVA = "0xFFB6E0", Offset = "0xFFB6E0", VA = "0xFFB6E0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0xFFB6E8", Offset = "0xFFB6E8", VA = "0xFFB6E8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0xFFB6F4", Offset = "0xFFB6F4", VA = "0xFFB6F4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD9B56C", Offset = "0xD9B56C", VA = "0xD9B56C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xD9BAAC", Offset = "0xD9BAAC", VA = "0xD9BAAC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xD9F7F8", Offset = "0xD9F7F8", VA = "0xD9F7F8")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD9F9E4", Offset = "0xD9F9E4", VA = "0xD9F9E4")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000083")]
		public static class Utils
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1A65530", Offset = "0x1A65530", VA = "0x1A65530")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820ED8", Offset = "0x820ED8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x600029B")]
			[Address(RVA = "0xFFB7A0", Offset = "0xFFB7A0", VA = "0xFFB7A0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xFFB7A8", Offset = "0xFFB7A8", VA = "0xFFB7A8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xFFB7C4", Offset = "0xFFB7C4", VA = "0xFFB7C4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EE8", Offset = "0x820EE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600029E")]
			[Address(RVA = "0xFFBA68", Offset = "0xFFBA68", VA = "0xFFBA68")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0xFFBA70", Offset = "0xFFBA70", VA = "0xFFBA70")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xFFBA94", Offset = "0xFFBA94", VA = "0xFFBA94")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EF8", Offset = "0x820EF8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xFFBE7C", Offset = "0xFFBE7C", VA = "0xFFBE7C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xFFBE84", Offset = "0xFFBE84", VA = "0xFFBE84")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xFFBEA8", Offset = "0xFFBEA8", VA = "0xFFBEA8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F08", Offset = "0x820F08")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1A65128", Offset = "0x1A65128", VA = "0x1A65128")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1A65130", Offset = "0x1A65130", VA = "0x1A65130")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1A65154", Offset = "0x1A65154", VA = "0x1A65154")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F18", Offset = "0x820F18")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1A65248", Offset = "0x1A65248", VA = "0x1A65248")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1A65250", Offset = "0x1A65250", VA = "0x1A65250")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1A65274", Offset = "0x1A65274", VA = "0x1A65274")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F28", Offset = "0x820F28")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1A65298", Offset = "0x1A65298", VA = "0x1A65298")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1A652A0", Offset = "0x1A652A0", VA = "0x1A652A0")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1A652BC", Offset = "0x1A652BC", VA = "0x1A652BC")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F38", Offset = "0x820F38")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1A652D8", Offset = "0x1A652D8", VA = "0x1A652D8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1A652E0", Offset = "0x1A652E0", VA = "0x1A652E0")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1A65344", Offset = "0x1A65344", VA = "0x1A65344")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F48", Offset = "0x820F48")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1A653A0", Offset = "0x1A653A0", VA = "0x1A653A0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1A653A8", Offset = "0x1A653A8", VA = "0x1A653A8")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1A6540C", Offset = "0x1A6540C", VA = "0x1A6540C")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F58", Offset = "0x820F58")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1A65468", Offset = "0x1A65468", VA = "0x1A65468")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1A65470", Offset = "0x1A65470", VA = "0x1A65470")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1A654D4", Offset = "0x1A654D4", VA = "0x1A654D4")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F68", Offset = "0x820F68")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xFFB7E0", Offset = "0xFFB7E0", VA = "0xFFB7E0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xFFB7E8", Offset = "0xFFB7E8", VA = "0xFFB7E8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xFFB808", Offset = "0xFFB808", VA = "0xFFB808")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F78", Offset = "0x820F78")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xFFB824", Offset = "0xFFB824", VA = "0xFFB824")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xFFB82C", Offset = "0xFFB82C", VA = "0xFFB82C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xFFB84C", Offset = "0xFFB84C", VA = "0xFFB84C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F88", Offset = "0x820F88")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xFFB868", Offset = "0xFFB868", VA = "0xFFB868")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xFFB870", Offset = "0xFFB870", VA = "0xFFB870")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xFFB88C", Offset = "0xFFB88C", VA = "0xFFB88C")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F98", Offset = "0x820F98")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xFFB8A8", Offset = "0xFFB8A8", VA = "0xFFB8A8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xFFB8B0", Offset = "0xFFB8B0", VA = "0xFFB8B0")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xFFB8CC", Offset = "0xFFB8CC", VA = "0xFFB8CC")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FA8", Offset = "0x820FA8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xFFB8E8", Offset = "0xFFB8E8", VA = "0xFFB8E8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xFFB8F0", Offset = "0xFFB8F0", VA = "0xFFB8F0")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xFFB90C", Offset = "0xFFB90C", VA = "0xFFB90C")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FB8", Offset = "0x820FB8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xFFB928", Offset = "0xFFB928", VA = "0xFFB928")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xFFB930", Offset = "0xFFB930", VA = "0xFFB930")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xFFB94C", Offset = "0xFFB94C", VA = "0xFFB94C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FC8", Offset = "0x820FC8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xFFB968", Offset = "0xFFB968", VA = "0xFFB968")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xFFB970", Offset = "0xFFB970", VA = "0xFFB970")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xFFB98C", Offset = "0xFFB98C", VA = "0xFFB98C")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FD8", Offset = "0x820FD8")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xFFB9A8", Offset = "0xFFB9A8", VA = "0xFFB9A8")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xFFB9B0", Offset = "0xFFB9B0", VA = "0xFFB9B0")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xFFB9CC", Offset = "0xFFB9CC", VA = "0xFFB9CC")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FE8", Offset = "0x820FE8")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xFFB9E8", Offset = "0xFFB9E8", VA = "0xFFB9E8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xFFB9F0", Offset = "0xFFB9F0", VA = "0xFFB9F0")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xFFBA0C", Offset = "0xFFBA0C", VA = "0xFFBA0C")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FF8", Offset = "0x820FF8")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xFFBA28", Offset = "0xFFBA28", VA = "0xFFBA28")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xFFBA30", Offset = "0xFFBA30", VA = "0xFFBA30")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xFFBA4C", Offset = "0xFFBA4C", VA = "0xFFBA4C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821008", Offset = "0x821008")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xFFBAB8", Offset = "0xFFBAB8", VA = "0xFFBAB8")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xFFBAC0", Offset = "0xFFBAC0", VA = "0xFFBAC0")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xFFBADC", Offset = "0xFFBADC", VA = "0xFFBADC")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821018", Offset = "0x821018")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xFFBAF8", Offset = "0xFFBAF8", VA = "0xFFBAF8")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xFFBB00", Offset = "0xFFBB00", VA = "0xFFBB00")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xFFBB1C", Offset = "0xFFBB1C", VA = "0xFFBB1C")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821028", Offset = "0x821028")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xFFBB38", Offset = "0xFFBB38", VA = "0xFFBB38")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xFFBB40", Offset = "0xFFBB40", VA = "0xFFBB40")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xFFBB5C", Offset = "0xFFBB5C", VA = "0xFFBB5C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821038", Offset = "0x821038")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xFFBB78", Offset = "0xFFBB78", VA = "0xFFBB78")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xFFBB80", Offset = "0xFFBB80", VA = "0xFFBB80")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xFFBB9C", Offset = "0xFFBB9C", VA = "0xFFBB9C")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821048", Offset = "0x821048")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xFFBBB8", Offset = "0xFFBBB8", VA = "0xFFBBB8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xFFBBC0", Offset = "0xFFBBC0", VA = "0xFFBBC0")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xFFBBDC", Offset = "0xFFBBDC", VA = "0xFFBBDC")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821058", Offset = "0x821058")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xFFBBF8", Offset = "0xFFBBF8", VA = "0xFFBBF8")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xFFBC00", Offset = "0xFFBC00", VA = "0xFFBC00")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xFFBC1C", Offset = "0xFFBC1C", VA = "0xFFBC1C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821068", Offset = "0x821068")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xFFBC38", Offset = "0xFFBC38", VA = "0xFFBC38")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xFFBC40", Offset = "0xFFBC40", VA = "0xFFBC40")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xFFBC68", Offset = "0xFFBC68", VA = "0xFFBC68")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821078", Offset = "0x821078")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xFFBC84", Offset = "0xFFBC84", VA = "0xFFBC84")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xFFBC8C", Offset = "0xFFBC8C", VA = "0xFFBC8C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xFFBCB4", Offset = "0xFFBCB4", VA = "0xFFBCB4")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821088", Offset = "0x821088")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xFFBCD0", Offset = "0xFFBCD0", VA = "0xFFBCD0")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xFFBCD8", Offset = "0xFFBCD8", VA = "0xFFBCD8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xFFBD00", Offset = "0xFFBD00", VA = "0xFFBD00")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821098", Offset = "0x821098")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xFFBD1C", Offset = "0xFFBD1C", VA = "0xFFBD1C")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xFFBD24", Offset = "0xFFBD24", VA = "0xFFBD24")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xFFBD40", Offset = "0xFFBD40", VA = "0xFFBD40")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xFFBD5C", Offset = "0xFFBD5C", VA = "0xFFBD5C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xFFBD90", Offset = "0xFFBD90", VA = "0xFFBD90")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xFFBDAC", Offset = "0xFFBDAC", VA = "0xFFBDAC")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xFFBDC8", Offset = "0xFFBDC8", VA = "0xFFBDC8")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210A8", Offset = "0x8210A8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xFFBECC", Offset = "0xFFBECC", VA = "0xFFBECC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xFFBED4", Offset = "0xFFBED4", VA = "0xFFBED4")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xFFBF28", Offset = "0xFFBF28", VA = "0xFFBF28")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210B8", Offset = "0x8210B8")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1A64D1C", Offset = "0x1A64D1C", VA = "0x1A64D1C")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x1A64D24", Offset = "0x1A64D24", VA = "0x1A64D24")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1A64D40", Offset = "0x1A64D40", VA = "0x1A64D40")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210C8", Offset = "0x8210C8")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x1A64D5C", Offset = "0x1A64D5C", VA = "0x1A64D5C")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1A64D64", Offset = "0x1A64D64", VA = "0x1A64D64")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1A64D80", Offset = "0x1A64D80", VA = "0x1A64D80")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210D8", Offset = "0x8210D8")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1A64D9C", Offset = "0x1A64D9C", VA = "0x1A64D9C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1A64DA4", Offset = "0x1A64DA4", VA = "0x1A64DA4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1A64DC8", Offset = "0x1A64DC8", VA = "0x1A64DC8")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210E8", Offset = "0x8210E8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1A64DEC", Offset = "0x1A64DEC", VA = "0x1A64DEC")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1A64DF4", Offset = "0x1A64DF4", VA = "0x1A64DF4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1A64E18", Offset = "0x1A64E18", VA = "0x1A64E18")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210F8", Offset = "0x8210F8")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1A64E3C", Offset = "0x1A64E3C", VA = "0x1A64E3C")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1A64E44", Offset = "0x1A64E44", VA = "0x1A64E44")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1A64E4C", Offset = "0x1A64E4C", VA = "0x1A64E4C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821108", Offset = "0x821108")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1A64EE8", Offset = "0x1A64EE8", VA = "0x1A64EE8")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1A64EF0", Offset = "0x1A64EF0", VA = "0x1A64EF0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1A64F14", Offset = "0x1A64F14", VA = "0x1A64F14")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821118", Offset = "0x821118")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1A64F38", Offset = "0x1A64F38", VA = "0x1A64F38")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1A64F40", Offset = "0x1A64F40", VA = "0x1A64F40")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1A64F64", Offset = "0x1A64F64", VA = "0x1A64F64")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821128", Offset = "0x821128")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1A64F88", Offset = "0x1A64F88", VA = "0x1A64F88")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1A64F90", Offset = "0x1A64F90", VA = "0x1A64F90")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1A64F9C", Offset = "0x1A64F9C", VA = "0x1A64F9C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821138", Offset = "0x821138")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1A65058", Offset = "0x1A65058", VA = "0x1A65058")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1A65060", Offset = "0x1A65060", VA = "0x1A65060")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1A6506C", Offset = "0x1A6506C", VA = "0x1A6506C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821148", Offset = "0x821148")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1A65178", Offset = "0x1A65178", VA = "0x1A65178")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1A65180", Offset = "0x1A65180", VA = "0x1A65180")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1A6518C", Offset = "0x1A6518C", VA = "0x1A6518C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD9BF74", Offset = "0xD9BF74", VA = "0xD9BF74")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD9B72C", Offset = "0xD9B72C", VA = "0xD9B72C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD9BC44", Offset = "0xD9BC44", VA = "0xD9BC44")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD9FC30", Offset = "0xD9FC30", VA = "0xD9FC30")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xD9FDF0", Offset = "0xD9FDF0", VA = "0xD9FDF0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xD9FF88", Offset = "0xD9FF88", VA = "0xD9FF88")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xDA0144", Offset = "0xDA0144", VA = "0xDA0144")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xDA0338", Offset = "0xDA0338", VA = "0xDA0338")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xDA04F0", Offset = "0xDA04F0", VA = "0xDA04F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xDA06A8", Offset = "0xDA06A8", VA = "0xDA06A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xDA0860", Offset = "0xDA0860", VA = "0xDA0860")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xDA0A20", Offset = "0xDA0A20", VA = "0xDA0A20")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xDA0BB8", Offset = "0xDA0BB8", VA = "0xDA0BB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xDA0D60", Offset = "0xDA0D60", VA = "0xDA0D60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xDA0F18", Offset = "0xDA0F18", VA = "0xDA0F18")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xDA10C8", Offset = "0xDA10C8", VA = "0xDA10C8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD9AE60", Offset = "0xD9AE60", VA = "0xD9AE60")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xDA1278", Offset = "0xDA1278", VA = "0xDA1278")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xDA142C", Offset = "0xDA142C", VA = "0xDA142C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xDA15E0", Offset = "0xDA15E0", VA = "0xDA15E0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xDA1794", Offset = "0xDA1794", VA = "0xDA1794")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xDA194C", Offset = "0xDA194C", VA = "0xDA194C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xDA1B04", Offset = "0xDA1B04", VA = "0xDA1B04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xDA1CAC", Offset = "0xDA1CAC", VA = "0xDA1CAC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xDA1E58", Offset = "0xDA1E58", VA = "0xDA1E58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xD9B3B4", Offset = "0xD9B3B4", VA = "0xD9B3B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xD9C350", Offset = "0xD9C350", VA = "0xD9C350")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xDA2004", Offset = "0xDA2004", VA = "0xDA2004")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xD9C518", Offset = "0xD9C518", VA = "0xD9C518")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xDA21EC", Offset = "0xDA21EC", VA = "0xDA21EC")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xDA2618", Offset = "0xDA2618", VA = "0xDA2618")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xDA27C4", Offset = "0xDA27C4", VA = "0xDA27C4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xDA2960", Offset = "0xDA2960", VA = "0xDA2960")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xDA2AFC", Offset = "0xDA2AFC", VA = "0xDA2AFC")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD9B8EC", Offset = "0xD9B8EC", VA = "0xD9B8EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xDA2CA4", Offset = "0xDA2CA4", VA = "0xDA2CA4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD9BDDC", Offset = "0xD9BDDC", VA = "0xD9BDDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xD9C10C", Offset = "0xD9C10C", VA = "0xD9C10C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xDA2EA8", Offset = "0xDA2EA8", VA = "0xDA2EA8")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xDA30FC", Offset = "0xDA30FC", VA = "0xDA30FC")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xDA3350", Offset = "0xDA3350", VA = "0xDA3350")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AC")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821168", Offset = "0x821168")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1A65774", Offset = "0x1A65774", VA = "0x1A65774")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1A6577C", Offset = "0x1A6577C", VA = "0x1A6577C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1A657A0", Offset = "0x1A657A0", VA = "0x1A657A0")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821178", Offset = "0x821178")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1A657C4", Offset = "0x1A657C4", VA = "0x1A657C4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1A657CC", Offset = "0x1A657CC", VA = "0x1A657CC")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1A657F0", Offset = "0x1A657F0", VA = "0x1A657F0")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821188", Offset = "0x821188")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1A65814", Offset = "0x1A65814", VA = "0x1A65814", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1A65A58", Offset = "0x1A65A58", VA = "0x1A65A58", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821198", Offset = "0x821198")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1A66168", Offset = "0x1A66168", VA = "0x1A66168", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1A663D0", Offset = "0x1A663D0", VA = "0x1A663D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211A8", Offset = "0x8211A8")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1A65CBC", Offset = "0x1A65CBC", VA = "0x1A65CBC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1A65EEC", Offset = "0x1A65EEC", VA = "0x1A65EEC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211B8", Offset = "0x8211B8")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1A65A64", Offset = "0x1A65A64", VA = "0x1A65A64", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1A65CB0", Offset = "0x1A65CB0", VA = "0x1A65CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211C8", Offset = "0x8211C8")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1A65EF8", Offset = "0x1A65EF8", VA = "0x1A65EF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1A6615C", Offset = "0x1A6615C", VA = "0x1A6615C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211D8", Offset = "0x8211D8")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1A663DC", Offset = "0x1A663DC", VA = "0x1A663DC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1A66614", Offset = "0x1A66614", VA = "0x1A66614", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xDA35A4", Offset = "0xDA35A4", VA = "0xDA35A4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xDA3794", Offset = "0xDA3794", VA = "0xDA3794")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xDA3998", Offset = "0xDA3998", VA = "0xDA3998")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDA3A58", Offset = "0xDA3A58", VA = "0xDA3A58")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDA3B18", Offset = "0xDA3B18", VA = "0xDA3B18")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xDA3BD8", Offset = "0xDA3BD8", VA = "0xDA3BD8")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDA3CA8", Offset = "0xDA3CA8", VA = "0xDA3CA8")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDA3D78", Offset = "0xDA3D78", VA = "0xDA3D78")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xDA3E38", Offset = "0xDA3E38", VA = "0xDA3E38")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xDA4050", Offset = "0xDA4050", VA = "0xDA4050")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDA4268", Offset = "0xDA4268", VA = "0xDA4268")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822BF4", Offset = "0x822BF4")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDA436C", Offset = "0xDA436C", VA = "0xDA436C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822C64", Offset = "0x822C64")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDA4470", Offset = "0xDA4470", VA = "0xDA4470")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822CD4", Offset = "0x822CD4")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDA4574", Offset = "0xDA4574", VA = "0xDA4574")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822D44", Offset = "0x822D44")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDA4688", Offset = "0xDA4688", VA = "0xDA4688")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822DB4", Offset = "0x822DB4")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDA479C", Offset = "0xDA479C", VA = "0xDA479C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x822E24", Offset = "0x822E24")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20000B6")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700007A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0xFFADFC", Offset = "0xFFADFC", VA = "0xFFADFC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0xFFAE30", Offset = "0xFFAE30", VA = "0xFFAE30")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000B7")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700007B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600033B")]
				[Address(RVA = "0xFFAFCC", Offset = "0xFFAFCC", VA = "0xFFAFCC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xFFB030", Offset = "0xFFB030", VA = "0xFFB030")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700007C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600033D")]
				[Address(RVA = "0xFFAEE4", Offset = "0xFFAEE4", VA = "0xFFAEE4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0xFFAF00", Offset = "0xFFAF00", VA = "0xFFAF00")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700007D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0xFFAE5C", Offset = "0xFFAE5C", VA = "0xFFAE5C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xFFAEA8", Offset = "0xFFAEA8", VA = "0xFFAEA8")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20000BA")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700007E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0xFFAF2C", Offset = "0xFFAF2C", VA = "0xFFAF2C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xFFAF90", Offset = "0xFFAF90", VA = "0xFFAF90")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20000BB")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700007F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000343")]
				[Address(RVA = "0xFFB05C", Offset = "0xFFB05C", VA = "0xFFB05C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0xFFB090", Offset = "0xFFB090", VA = "0xFFB090")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20000BC")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20000BD")]
		public static class Physics
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1A66620", Offset = "0x1A66620", VA = "0x1A66620")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1A66724", Offset = "0x1A66724", VA = "0x1A66724")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x1A6672C", Offset = "0x1A6672C", VA = "0x1A6672C")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1A667C4", Offset = "0x1A667C4", VA = "0x1A667C4")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xDA48A0", Offset = "0xDA48A0", VA = "0xDA48A0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xDA4964", Offset = "0xDA4964", VA = "0xDA4964")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8211E8", Offset = "0x8211E8")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x20000BF")]
		public enum AnimationType
		{
			[Token(Token = "0x40002DC")]
			None,
			[Token(Token = "0x40002DD")]
			Move,
			[Token(Token = "0x40002DE")]
			LocalMove,
			[Token(Token = "0x40002DF")]
			Rotate,
			[Token(Token = "0x40002E0")]
			LocalRotate,
			[Token(Token = "0x40002E1")]
			Scale,
			[Token(Token = "0x40002E2")]
			Color,
			[Token(Token = "0x40002E3")]
			Fade,
			[Token(Token = "0x40002E4")]
			Text,
			[Token(Token = "0x40002E5")]
			PunchPosition,
			[Token(Token = "0x40002E6")]
			PunchRotation,
			[Token(Token = "0x40002E7")]
			PunchScale,
			[Token(Token = "0x40002E8")]
			ShakePosition,
			[Token(Token = "0x40002E9")]
			ShakeRotation,
			[Token(Token = "0x40002EA")]
			ShakeScale,
			[Token(Token = "0x40002EB")]
			CameraAspect,
			[Token(Token = "0x40002EC")]
			CameraBackgroundColor,
			[Token(Token = "0x40002ED")]
			CameraFieldOfView,
			[Token(Token = "0x40002EE")]
			CameraOrthoSize,
			[Token(Token = "0x40002EF")]
			CameraPixelRect,
			[Token(Token = "0x40002F0")]
			CameraRect,
			[Token(Token = "0x40002F1")]
			UIWidthHeight
		}

		[Token(Token = "0x20000C0")]
		public enum TargetType
		{
			[Token(Token = "0x40002F3")]
			Unset,
			[Token(Token = "0x40002F4")]
			Camera,
			[Token(Token = "0x40002F5")]
			CanvasGroup,
			[Token(Token = "0x40002F6")]
			Image,
			[Token(Token = "0x40002F7")]
			Light,
			[Token(Token = "0x40002F8")]
			RectTransform,
			[Token(Token = "0x40002F9")]
			Renderer,
			[Token(Token = "0x40002FA")]
			SpriteRenderer,
			[Token(Token = "0x40002FB")]
			Rigidbody,
			[Token(Token = "0x40002FC")]
			Rigidbody2D,
			[Token(Token = "0x40002FD")]
			Text,
			[Token(Token = "0x40002FE")]
			Transform,
			[Token(Token = "0x40002FF")]
			tk2dBaseSprite,
			[Token(Token = "0x4000300")]
			tk2dTextMesh,
			[Token(Token = "0x4000301")]
			TextMeshPro,
			[Token(Token = "0x4000302")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000003")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0xD99338", Offset = "0xD99338", VA = "0xD99338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822F34", Offset = "0x822F34")]
			add
			{
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xD993F4", Offset = "0xD993F4", VA = "0xD993F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822F44", Offset = "0x822F44")]
			remove
			{
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD994B0", Offset = "0xD994B0", VA = "0xD994B0")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD9952C", Offset = "0xD9952C", VA = "0xD9952C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD9AB98", Offset = "0xD9AB98", VA = "0xD9AB98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD9ABDC", Offset = "0xD9ABDC", VA = "0xD9ABDC")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD9ABE0", Offset = "0xD9ABE0", VA = "0xD9ABE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD9957C", Offset = "0xD9957C", VA = "0xD9957C")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD9C708", Offset = "0xD9C708", VA = "0xD9C708", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD9C780", Offset = "0xD9C780", VA = "0xD9C780", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD9C7F8", Offset = "0xD9C7F8", VA = "0xD9C7F8", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xD9C870", Offset = "0xD9C870", VA = "0xD9C870", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xD9C8E8", Offset = "0xD9C8E8", VA = "0xD9C8E8", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD9C960", Offset = "0xD9C960", VA = "0xD9C960", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD9CA58", Offset = "0xD9CA58", VA = "0xD9CA58", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xD9CA68", Offset = "0xD9CA68", VA = "0xD9CA68", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xD9CDE4", Offset = "0xD9CDE4", VA = "0xD9CDE4", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xD9CE60", Offset = "0xD9CE60", VA = "0xD9CE60", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD9CEE4", Offset = "0xD9CEE4", VA = "0xD9CEE4")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xD9CF6C", Offset = "0xD9CF6C", VA = "0xD9CF6C")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD9CFD0", Offset = "0xD9CFD0", VA = "0xD9CFD0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD9D034", Offset = "0xD9D034", VA = "0xD9D034")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD9D0BC", Offset = "0xD9D0BC", VA = "0xD9D0BC")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD9D120", Offset = "0xD9D120", VA = "0xD9D120")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD9D1A8", Offset = "0xD9D1A8", VA = "0xD9D1A8")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD9D20C", Offset = "0xD9D20C", VA = "0xD9D20C")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD9D354", Offset = "0xD9D354", VA = "0xD9D354")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xD9D3E0", Offset = "0xD9D3E0", VA = "0xD9D3E0")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD9D45C", Offset = "0xD9D45C", VA = "0xD9D45C")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD9D4F4", Offset = "0xD9D4F4", VA = "0xD9D4F4")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD9D574", Offset = "0xD9D574", VA = "0xD9D574")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD9AC3C", Offset = "0xD9AC3C", VA = "0xD9AC3C")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD9D680", Offset = "0xD9D680", VA = "0xD9D680")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD9AC24", Offset = "0xD9AC24", VA = "0xD9AC24")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xD9CB7C", Offset = "0xD9CB7C", VA = "0xD9CB7C")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD9D6BC", Offset = "0xD9D6BC", VA = "0xD9D6BC")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD9D8AC", Offset = "0xD9D8AC", VA = "0xD9D8AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822F54", Offset = "0x822F54")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000370")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C2")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821240", Offset = "0x821240")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1A66918", Offset = "0x1A66918", VA = "0x1A66918")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1A66920", Offset = "0x1A66920", VA = "0x1A66920")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1A6693C", Offset = "0x1A6693C", VA = "0x1A6693C")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821250", Offset = "0x821250")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x1A66958", Offset = "0x1A66958", VA = "0x1A66958")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1A66960", Offset = "0x1A66960", VA = "0x1A66960")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xDA4A18", Offset = "0xDA4A18", VA = "0xDA4A18")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xDA4A64", Offset = "0xDA4A64", VA = "0xDA4A64")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xDA4D7C", Offset = "0xDA4D7C", VA = "0xDA4D7C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C5")]
	public enum TMPSkewSpanMode
	{
		[Token(Token = "0x4000306")]
		Default,
		[Token(Token = "0x4000307")]
		AsMaxSkewFactor
	}
	[Token(Token = "0x20000C6")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821270", Offset = "0x821270")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1A6A9BC", Offset = "0x1A6A9BC", VA = "0x1A6A9BC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1A6A9C4", Offset = "0x1A6A9C4", VA = "0x1A6A9C4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1A6A9E8", Offset = "0x1A6A9E8", VA = "0x1A6A9E8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821280", Offset = "0x821280")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1A6AA5C", Offset = "0x1A6AA5C", VA = "0x1A6AA5C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1A6AA64", Offset = "0x1A6AA64", VA = "0x1A6AA64")]
			internal Color <DOFaceColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1A6AA90", Offset = "0x1A6AA90", VA = "0x1A6AA90")]
			internal void <DOFaceColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821290", Offset = "0x821290")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1A6AAC8", Offset = "0x1A6AAC8", VA = "0x1A6AAC8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1A6AAD0", Offset = "0x1A6AAD0", VA = "0x1A6AAD0")]
			internal Color <DOOutlineColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1A6AAFC", Offset = "0x1A6AAFC", VA = "0x1A6AAFC")]
			internal void <DOOutlineColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212A0", Offset = "0x8212A0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1A6AB34", Offset = "0x1A6AB34", VA = "0x1A6AB34")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1A6AB3C", Offset = "0x1A6AB3C", VA = "0x1A6AB3C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1A6AB60", Offset = "0x1A6AB60", VA = "0x1A6AB60")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212B0", Offset = "0x8212B0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1A6AB84", Offset = "0x1A6AB84", VA = "0x1A6AB84")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1A6AB8C", Offset = "0x1A6AB8C", VA = "0x1A6AB8C")]
			internal Color <DOFaceFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1A6ABB8", Offset = "0x1A6ABB8", VA = "0x1A6ABB8")]
			internal void <DOFaceFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212C0", Offset = "0x8212C0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1A6ABF0", Offset = "0x1A6ABF0", VA = "0x1A6ABF0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1A6ABF8", Offset = "0x1A6ABF8", VA = "0x1A6ABF8")]
			internal Vector3 <DOScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1A6AC14", Offset = "0x1A6AC14", VA = "0x1A6AC14")]
			internal void <DOScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212D0", Offset = "0x8212D0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TMP_Text target;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1A6AC30", Offset = "0x1A6AC30", VA = "0x1A6AC30")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1A6AC38", Offset = "0x1A6AC38", VA = "0x1A6AC38")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1A6AC40", Offset = "0x1A6AC40", VA = "0x1A6AC40")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212E0", Offset = "0x8212E0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1A6ACDC", Offset = "0x1A6ACDC", VA = "0x1A6ACDC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1A6ACE4", Offset = "0x1A6ACE4", VA = "0x1A6ACE4")]
			internal float <DOFontSize>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1A6AD00", Offset = "0x1A6AD00", VA = "0x1A6AD00")]
			internal void <DOFontSize>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212F0", Offset = "0x8212F0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1A6AD1C", Offset = "0x1A6AD1C", VA = "0x1A6AD1C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1A6AD24", Offset = "0x1A6AD24", VA = "0x1A6AD24")]
			internal int <DOMaxVisibleCharacters>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1A6AD40", Offset = "0x1A6AD40", VA = "0x1A6AD40")]
			internal void <DOMaxVisibleCharacters>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821300", Offset = "0x821300")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x1A6AA0C", Offset = "0x1A6AA0C", VA = "0x1A6AA0C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x1A6AA14", Offset = "0x1A6AA14", VA = "0x1A6AA14")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x1A6AA38", Offset = "0x1A6AA38", VA = "0x1A6AA38")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xFEE84C", Offset = "0xFEE84C", VA = "0xFEE84C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xFEEA0C", Offset = "0xFEEA0C", VA = "0xFEEA0C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xFEEBDC", Offset = "0xFEEBDC", VA = "0xFEEBDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xFEEDAC", Offset = "0xFEEDAC", VA = "0xFEEDAC")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xFEEEA0", Offset = "0xFEEEA0", VA = "0xFEEEA0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xFEF038", Offset = "0xFEF038", VA = "0xFEF038")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xFEF1D0", Offset = "0xFEF1D0", VA = "0xFEF1D0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xFEF380", Offset = "0xFEF380", VA = "0xFEF380")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this TMP_Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xFEF584", Offset = "0xFEF584", VA = "0xFEF584")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xFEF71C", Offset = "0xFEF71C", VA = "0xFEF71C")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xFEF8B4", Offset = "0xFEF8B4", VA = "0xFEF8B4")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D1")]
	public class DOTweenTMPAnimator : IDisposable
	{
		[Token(Token = "0x20000D2")]
		private struct CharVertices
		{
			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 bottomLeft;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 topLeft;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 topRight;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 bottomRight;

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1A68C34", Offset = "0x1A68C34", VA = "0x1A68C34")]
			public CharVertices(Vector3 bottomLeft, Vector3 topLeft, Vector3 topRight, Vector3 bottomRight)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		private struct CharTransform
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int charIndex;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821E2C", Offset = "0x821E2C")]
			private bool <isVisible>k__BackingField;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 offset;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 scale;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _topLeftShift;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 _topRightShift;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _bottomLeftShift;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 _bottomRightShift;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 _charMidBaselineOffset;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int _matIndex;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _firstVertexIndex;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TMP_MeshInfo _meshInfo;

			[Token(Token = "0x17000082")]
			public bool isVisible
			{
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0x1A685DC", Offset = "0x1A685DC", VA = "0x1A685DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823084", Offset = "0x823084")]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0x1A685E4", Offset = "0x1A685E4", VA = "0x1A685E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8230BC", Offset = "0x8230BC")]
				private set
				{
				}
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1A685F0", Offset = "0x1A685F0", VA = "0x1A685F0")]
			public CharTransform(int charIndex, TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1A68670", Offset = "0x1A68670", VA = "0x1A68670")]
			public void Refresh(TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1A687C0", Offset = "0x1A687C0", VA = "0x1A687C0")]
			public void ResetAll(TMP_Text target, TMP_MeshInfo[] meshInfos, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1A68B00", Offset = "0x1A68B00", VA = "0x1A68B00")]
			public void ResetTransformationData()
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1A68800", Offset = "0x1A68800", VA = "0x1A68800")]
			public void ResetGeometry(TMP_Text target, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1A68998", Offset = "0x1A68998", VA = "0x1A68998")]
			public void ResetColors(TMP_Text target, TMP_MeshInfo[] meshInfos)
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1A66A58", Offset = "0x1A66A58", VA = "0x1A66A58")]
			public Color32 GetColor(TMP_MeshInfo[] meshInfos)
			{
				return default(Color32);
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1A68B6C", Offset = "0x1A68B6C", VA = "0x1A68B6C")]
			public CharVertices GetVertices()
			{
				return default(CharVertices);
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1A66BB4", Offset = "0x1A66BB4", VA = "0x1A66BB4")]
			public void UpdateAlpha(TMP_Text target, Color alphaColor, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1A66E98", Offset = "0x1A66E98", VA = "0x1A66E98")]
			public void UpdateColor(TMP_Text target, Color32 color, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1A67164", Offset = "0x1A67164", VA = "0x1A67164")]
			public void UpdateGeometry(TMP_Text target, Vector3 offset, Quaternion rotation, Vector3 scale, TMP_MeshInfo[] cachedMeshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1A68C64", Offset = "0x1A68C64", VA = "0x1A68C64")]
			public void ShiftVertices(TMP_Text target, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1A68E24", Offset = "0x1A68E24", VA = "0x1A68E24")]
			public void ResetVerticesShift(TMP_Text target)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821310", Offset = "0x821310")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1A6697C", Offset = "0x1A6697C", VA = "0x1A6697C")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1A66984", Offset = "0x1A66984", VA = "0x1A66984")]
			internal Color <DOFadeChar>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1A66AB4", Offset = "0x1A66AB4", VA = "0x1A66AB4")]
			internal void <DOFadeChar>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821320", Offset = "0x821320")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1A66CA4", Offset = "0x1A66CA4", VA = "0x1A66CA4")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1A66CAC", Offset = "0x1A66CAC", VA = "0x1A66CAC")]
			internal Color <DOColorChar>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1A66D80", Offset = "0x1A66D80", VA = "0x1A66D80")]
			internal void <DOColorChar>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821330", Offset = "0x821330")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1A66F70", Offset = "0x1A66F70", VA = "0x1A66F70")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1A66F78", Offset = "0x1A66F78", VA = "0x1A66F78")]
			internal Vector3 <DOOffsetChar>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1A66FF8", Offset = "0x1A66FF8", VA = "0x1A66FF8")]
			internal void <DOOffsetChar>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821340", Offset = "0x821340")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1A6757C", Offset = "0x1A6757C", VA = "0x1A6757C")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1A67584", Offset = "0x1A67584", VA = "0x1A67584")]
			internal Quaternion <DORotateChar>b__0()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1A67604", Offset = "0x1A67604", VA = "0x1A67604")]
			internal void <DORotateChar>b__1(Quaternion x)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821350", Offset = "0x821350")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1A67778", Offset = "0x1A67778", VA = "0x1A67778")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1A67780", Offset = "0x1A67780", VA = "0x1A67780")]
			internal Vector3 <DOScaleChar>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1A67800", Offset = "0x1A67800", VA = "0x1A67800")]
			internal void <DOScaleChar>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821360", Offset = "0x821360")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1A6795C", Offset = "0x1A6795C", VA = "0x1A6795C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1A67964", Offset = "0x1A67964", VA = "0x1A67964")]
			internal Vector3 <DOPunchCharOffset>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1A679E4", Offset = "0x1A679E4", VA = "0x1A679E4")]
			internal void <DOPunchCharOffset>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821370", Offset = "0x821370")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1A67B50", Offset = "0x1A67B50", VA = "0x1A67B50")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1A67B58", Offset = "0x1A67B58", VA = "0x1A67B58")]
			internal Vector3 <DOPunchCharRotation>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1A67C04", Offset = "0x1A67C04", VA = "0x1A67C04")]
			internal void <DOPunchCharRotation>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821380", Offset = "0x821380")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1A67DB8", Offset = "0x1A67DB8", VA = "0x1A67DB8")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1A67DC0", Offset = "0x1A67DC0", VA = "0x1A67DC0")]
			internal Vector3 <DOPunchCharScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1A67E40", Offset = "0x1A67E40", VA = "0x1A67E40")]
			internal void <DOPunchCharScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821390", Offset = "0x821390")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1A67F9C", Offset = "0x1A67F9C", VA = "0x1A67F9C")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1A67FA4", Offset = "0x1A67FA4", VA = "0x1A67FA4")]
			internal Vector3 <DOShakeCharOffset>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1A68024", Offset = "0x1A68024", VA = "0x1A68024")]
			internal void <DOShakeCharOffset>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213A0", Offset = "0x8213A0")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1A68190", Offset = "0x1A68190", VA = "0x1A68190")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1A68198", Offset = "0x1A68198", VA = "0x1A68198")]
			internal Vector3 <DOShakeCharRotation>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1A68244", Offset = "0x1A68244", VA = "0x1A68244")]
			internal void <DOShakeCharRotation>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213B0", Offset = "0x8213B0")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1A683F8", Offset = "0x1A683F8", VA = "0x1A683F8")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1A68400", Offset = "0x1A68400", VA = "0x1A68400")]
			internal Vector3 <DOShakeCharScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1A68480", Offset = "0x1A68480", VA = "0x1A68480")]
			internal void <DOShakeCharScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821E0C", Offset = "0x821E0C")]
		private TMP_Text <target>k__BackingField;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821E1C", Offset = "0x821E1C")]
		private TMP_TextInfo <textInfo>k__BackingField;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<CharTransform> _charTransforms;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_MeshInfo[] _cachedMeshInfos;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _ignoreTextChangedEvent;

		[Token(Token = "0x17000080")]
		public TMP_Text target
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xDA50A0", Offset = "0xDA50A0", VA = "0xDA50A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823044", Offset = "0x823044")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xDA50A8", Offset = "0xDA50A8", VA = "0xDA50A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823054", Offset = "0x823054")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xDA50B0", Offset = "0xDA50B0", VA = "0xDA50B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823064", Offset = "0x823064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xDA50B8", Offset = "0xDA50B8", VA = "0xDA50B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823074", Offset = "0x823074")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xDA50C0", Offset = "0xDA50C0", VA = "0xDA50C0")]
		public DOTweenTMPAnimator(TMP_Text target)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xDA54B4", Offset = "0xDA54B4", VA = "0xDA54B4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xDA5258", Offset = "0xDA5258", VA = "0xDA5258")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xDA55D4", Offset = "0xDA55D4", VA = "0xDA55D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xDA56C4", Offset = "0xDA56C4", VA = "0xDA56C4")]
		private void OnTextChanged(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xDA5790", Offset = "0xDA5790", VA = "0xDA5790")]
		private bool ValidateChar(int charIndex, bool isTween = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xDA5934", Offset = "0xDA5934", VA = "0xDA5934")]
		private bool ValidateSpan(int fromCharIndex, int toCharIndex, out int firstVisibleCharIndex, out int lastVisibleCharIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xDA5A9C", Offset = "0xDA5A9C", VA = "0xDA5A9C")]
		public void SkewSpanX(int fromCharIndex, int toCharIndex, float skewFactor, bool skewTop = true)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xDA5DC4", Offset = "0xDA5DC4", VA = "0xDA5DC4")]
		public void SkewSpanY(int fromCharIndex, int toCharIndex, float skewFactor, TMPSkewSpanMode mode = TMPSkewSpanMode.Default, bool skewRight = true)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xDA6580", Offset = "0xDA6580", VA = "0xDA6580")]
		public Color GetCharColor(int charIndex)
		{
			return default(Color);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xDA6660", Offset = "0xDA6660", VA = "0xDA6660")]
		public Vector3 GetCharOffset(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xDA66FC", Offset = "0xDA66FC", VA = "0xDA66FC")]
		public Vector3 GetCharRotation(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xDA67C8", Offset = "0xDA67C8", VA = "0xDA67C8")]
		public Vector3 GetCharScale(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xDA6864", Offset = "0xDA6864", VA = "0xDA6864")]
		public void SetCharColor(int charIndex, Color32 color)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xDA6420", Offset = "0xDA6420", VA = "0xDA6420")]
		public void SetCharOffset(int charIndex, Vector3 offset)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xDA6998", Offset = "0xDA6998", VA = "0xDA6998")]
		public void SetCharRotation(int charIndex, Vector3 rotation)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xDA6B38", Offset = "0xDA6B38", VA = "0xDA6B38")]
		public void SetCharScale(int charIndex, Vector3 scale)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xDA6C88", Offset = "0xDA6C88", VA = "0xDA6C88")]
		public void ShiftCharVertices(int charIndex, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xDA5C08", Offset = "0xDA5C08", VA = "0xDA5C08")]
		public float SkewCharX(int charIndex, float skewFactor, bool skewTop = true)
		{
			return default(float);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xDA6214", Offset = "0xDA6214", VA = "0xDA6214")]
		public float SkewCharY(int charIndex, float skewFactor, bool skewRight = true, bool fixedSkew = false)
		{
			return default(float);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xDA6E0C", Offset = "0xDA6E0C", VA = "0xDA6E0C")]
		public void ResetVerticesShift(int charIndex)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xDA6F20", Offset = "0xDA6F20", VA = "0xDA6F20")]
		public TweenerCore<Color, Color, ColorOptions> DOFadeChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xDA70C0", Offset = "0xDA70C0", VA = "0xDA70C0")]
		public TweenerCore<Color, Color, ColorOptions> DOColorChar(int charIndex, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xDA7290", Offset = "0xDA7290", VA = "0xDA7290")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOOffsetChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xDA744C", Offset = "0xDA744C", VA = "0xDA744C")]
		public TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateChar(int charIndex, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xDA7604", Offset = "0xDA7604", VA = "0xDA7604")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xDA7614", Offset = "0xDA7614", VA = "0xDA7614")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xDA77D0", Offset = "0xDA77D0", VA = "0xDA77D0")]
		public Tweener DOPunchCharOffset(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xDA7A24", Offset = "0xDA7A24", VA = "0xDA7A24")]
		public Tweener DOPunchCharRotation(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xDA7C78", Offset = "0xDA7C78", VA = "0xDA7C78")]
		public Tweener DOPunchCharScale(int charIndex, float punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xDA7C8C", Offset = "0xDA7C8C", VA = "0xDA7C8C")]
		public Tweener DOPunchCharScale(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xDA7EE0", Offset = "0xDA7EE0", VA = "0xDA7EE0")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xDA7EF4", Offset = "0xDA7EF4", VA = "0xDA7EF4")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xDA8158", Offset = "0xDA8158", VA = "0xDA8158")]
		public Tweener DOShakeCharRotation(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDA83BC", Offset = "0xDA83BC", VA = "0xDA83BC")]
		public Tweener DOShakeCharScale(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xDA83D0", Offset = "0xDA83D0", VA = "0xDA83D0")]
		public Tweener DOShakeCharScale(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}
	}
}
namespace Better.StreamingAssets
{
	[Token(Token = "0x20000DF")]
	public static class PathUtil
	{
		[Token(Token = "0x20000E0")]
		private enum NormalizeState
		{
			[Token(Token = "0x4000342")]
			PrevSlash,
			[Token(Token = "0x4000343")]
			PrevDot,
			[Token(Token = "0x4000344")]
			PrevDoubleDot,
			[Token(Token = "0x4000345")]
			NothingSpecial
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xFED36C", Offset = "0xFED36C", VA = "0xFED36C")]
		public static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xFED388", Offset = "0xFED388", VA = "0xFED388")]
		public static string FixTrailingDirectorySeparators(string path)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xFED4B4", Offset = "0xFED4B4", VA = "0xFED4B4")]
		public static string CombineSlash(string a, string b)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xFED61C", Offset = "0xFED61C", VA = "0xFED61C")]
		public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xFEDA48", Offset = "0xFEDA48", VA = "0xFEDA48")]
		public static bool IsValidCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xFEDAAC", Offset = "0xFEDAAC", VA = "0xFEDAAC")]
		public static Regex WildcardToRegex(string pattern)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	internal class SubReadOnlyStream : Stream
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly long m_offset;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool m_leaveOpen;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long? m_length;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stream m_actualStream;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_position;

		[Token(Token = "0x17000083")]
		public override long Length
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xFEFFA8", Offset = "0xFEFFA8", VA = "0xFEFFA8", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000084")]
		public override long Position
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xFF00F0", Offset = "0xFF00F0", VA = "0xFF00F0", Slot = "11")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xFF011C", Offset = "0xFF011C", VA = "0xFF011C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public override bool CanRead
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xFF0160", Offset = "0xFF0160", VA = "0xFF0160", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xFF0180", Offset = "0xFF0180", VA = "0xFF0180", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xFF01A0", Offset = "0xFF01A0", VA = "0xFF01A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xFEFDC8", Offset = "0xFEFDC8", VA = "0xFEFDC8")]
		public SubReadOnlyStream(Stream actualStream, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xFEFE98", Offset = "0xFEFE98", VA = "0xFEFE98")]
		public SubReadOnlyStream(Stream actualStream, long offset, long length, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xFF01A8", Offset = "0xFF01A8", VA = "0xFF01A8", Slot = "28")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xFF0320", Offset = "0xFF0320", VA = "0xFF0320", Slot = "26")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xFF03E8", Offset = "0xFF03E8", VA = "0xFF03E8", Slot = "27")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xFF0428", Offset = "0xFF0428", VA = "0xFF0428", Slot = "30")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xFF0468", Offset = "0xFF0468", VA = "0xFF0468", Slot = "18")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xFF04A8", Offset = "0xFF04A8", VA = "0xFF04A8", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xFF0068", Offset = "0xFF0068", VA = "0xFF0068")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xFF02C4", Offset = "0xFF02C4", VA = "0xFF02C4")]
		private void ThrowIfCantRead()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class BSA_TestSceneGUI : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		private class CoroutineHost : MonoBehaviour
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xFF9278", Offset = "0xFF9278", VA = "0xFF9278")]
			public CoroutineHost()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		private class TestInfo
		{
			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReadMode readMode;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public TestType testType;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string path;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int attempts;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Exception error;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TimeSpan duration;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long bytesRead;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public long memoryPeak;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public long maxMemoryPeak;

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xFF8858", Offset = "0xFF8858", VA = "0xFF8858")]
			public TestInfo()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		private delegate void TestResultDelegate(TimeSpan avgDuration, long avgBytesRead, long avgMemoryPeak, long maxMemoryPeak, string[] assetNames);

		[Token(Token = "0x20000E6")]
		[Flags]
		private enum ReadMode
		{
			[Token(Token = "0x4000362")]
			BSA = 1,
			[Token(Token = "0x4000363")]
			WWW = 2,
			[Token(Token = "0x4000364")]
			Direct = 0x20,
			[Token(Token = "0x4000365")]
			UnityWebRequest = 0x40
		}

		[Token(Token = "0x20000E7")]
		[Flags]
		private enum TestType
		{
			[Token(Token = "0x4000367")]
			CheckIfExists = 1,
			[Token(Token = "0x4000368")]
			LoadBytes = 2
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213E0", Offset = "0x8213E0")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TestInfo testInfo;

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xFF7194", Offset = "0xFF7194", VA = "0xFF7194")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xFF719C", Offset = "0xFF719C", VA = "0xFF719C")]
			internal void <TestAllCoroutine>b__0(TimeSpan duration, long bytes, long memory, long maxMemory, string[] names)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0xFF71E0", Offset = "0xFF71E0", VA = "0xFF71E0")]
			internal void <TestAllCoroutine>b__1(Exception ex)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213F0", Offset = "0x8213F0")]
		private sealed class <TestAllCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<TestInfo> results;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IEnumerable<string> paths;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ReadMode readModes;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public TestType testTypes;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int attempts;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <logPath>5__2;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private IEnumerator<string> <>7__wrap2;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private string <path>5__4;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private IEnumerator <>7__wrap4;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ReadMode <readMode>5__6;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private IEnumerator <>7__wrap6;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600042D")]
				[Address(RVA = "0xFF8870", Offset = "0xFF8870", VA = "0xFF8870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0xFF88B8", Offset = "0xFF88B8", VA = "0xFF88B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xFF74A4", Offset = "0xFF74A4", VA = "0xFF74A4")]
			[DebuggerHidden]
			public <TestAllCoroutine>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xFF74D0", Offset = "0xFF74D0", VA = "0xFF74D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0xFF7E38", Offset = "0xFF7E38", VA = "0xFF7E38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0xFF782C", Offset = "0xFF782C", VA = "0xFF782C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xFF7770", Offset = "0xFF7770", VA = "0xFF7770")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0xFF76A8", Offset = "0xFF76A8", VA = "0xFF76A8")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0xFF75E0", Offset = "0xFF75E0", VA = "0xFF75E0")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0xFF8878", Offset = "0xFF8878", VA = "0xFF8878", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821400", Offset = "0x821400")]
		private sealed class <ErrorCatchingCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator inner;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> onError;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000433")]
				[Address(RVA = "0xFF7454", Offset = "0xFF7454", VA = "0xFF7454", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0xFF749C", Offset = "0xFF749C", VA = "0xFF749C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0xFF71FC", Offset = "0xFF71FC", VA = "0xFF71FC")]
			[DebuggerHidden]
			public <ErrorCatchingCoroutine>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0xFF7228", Offset = "0xFF7228", VA = "0xFF7228", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xFF722C", Offset = "0xFF722C", VA = "0xFF722C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xFF745C", Offset = "0xFF745C", VA = "0xFF745C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821410", Offset = "0x821410")]
		private sealed class <TestHarness>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ReadMode readMode;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public TestType testType;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int attempts;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TestResultDelegate callback;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Stopwatch <stopwatch>5__2;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string[] <assetNames>5__3;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string <streamingAssetsUrl>5__4;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private long <bytesRead>5__5;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private long <maxMemoryPeak>5__6;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private long <totalMemoryPeaks>5__7;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int <i>5__8;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private IDisposable <toDispose>5__9;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private long <memoryUnityBefore>5__10;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private WWW <www>5__11;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private UnityWebRequest <www>5__12;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000439")]
				[Address(RVA = "0xFF9228", Offset = "0xFF9228", VA = "0xFF9228", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600043B")]
				[Address(RVA = "0xFF9270", Offset = "0xFF9270", VA = "0xFF9270", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xFF88C0", Offset = "0xFF88C0", VA = "0xFF88C0")]
			[DebuggerHidden]
			public <TestHarness>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xFF88EC", Offset = "0xFF88EC", VA = "0xFF88EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xFF88F0", Offset = "0xFF88F0", VA = "0xFF88F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xFF9230", Offset = "0xFF9230", VA = "0xFF9230", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text InProgressText;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string EditorApkPath;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int RepetitionCount;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool LogToFile;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_status;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TestType m_testModes;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private ReadMode m_readModes;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CoroutineHost coroutineHost;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 m_assetsScroll;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector2 m_resultsScroll;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] m_allStreamingAssets;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<TestInfo> m_results;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HashSet<string> m_selectedPaths;

		[Token(Token = "0x17000088")]
		private string StreamingAssetsPath
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xD93B1C", Offset = "0xD93B1C", VA = "0xD93B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD91758", Offset = "0xD91758", VA = "0xD91758")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD91778", Offset = "0xD91778", VA = "0xD91778")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD91798", Offset = "0xD91798", VA = "0xD91798")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD93554", Offset = "0xD93554", VA = "0xD93554")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD93768", Offset = "0xD93768", VA = "0xD93768")]
		private void DoTestTypeToggle(TestType testMode)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD938F0", Offset = "0xD938F0", VA = "0xD938F0")]
		private void DoReadModeToggle(ReadMode readMode)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD93A78", Offset = "0xD93A78", VA = "0xD93A78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8230CC", Offset = "0x8230CC")]
		private IEnumerator TestAllCoroutine(IEnumerable<string> paths, int attempts, ReadMode readModes, TestType testTypes, List<TestInfo> results)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD93B2C", Offset = "0xD93B2C", VA = "0xD93B2C")]
		private void LogWorkProgress(string status)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD93C0C", Offset = "0xD93C0C", VA = "0xD93C0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82312C", Offset = "0x82312C")]
		private IEnumerator ErrorCatchingCoroutine(IEnumerator inner, Action<Exception> onError)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD93C8C", Offset = "0xD93C8C", VA = "0xD93C8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82318C", Offset = "0x82318C")]
		private IEnumerator TestHarness(ReadMode readMode, string path, TestType testType, int attempts, TestResultDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD93D30", Offset = "0xD93D30", VA = "0xD93D30")]
		public BSA_TestSceneGUI()
		{
		}
	}
}
namespace Better.StreamingAssets.ZipArchive
{
	[Token(Token = "0x20000EC")]
	internal struct ZipGenericExtraField
	{
		[Token(Token = "0x4000391")]
		private const int SizeOfHeader = 4;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _tag;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort _size;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] _data;

		[Token(Token = "0x1700008F")]
		public ushort Tag
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xFF6E2C", Offset = "0xFF6E2C", VA = "0xFF6E2C")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000090")]
		public ushort Size
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xFF6E34", Offset = "0xFF6E34", VA = "0xFF6E34")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000091")]
		public byte[] Data
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xFF6E3C", Offset = "0xFF6E3C", VA = "0xFF6E3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xFF5E68", Offset = "0xFF5E68", VA = "0xFF5E68")]
		public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000ED")]
	internal struct Zip64ExtraField
	{
		[Token(Token = "0x4000395")]
		public const int OffsetToFirstField = 4;

		[Token(Token = "0x4000396")]
		private const ushort TagConstant = 1;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _size;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long? _uncompressedSize;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long? _compressedSize;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long? _localHeaderOffset;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int? _startDiskNumber;

		[Token(Token = "0x17000092")]
		public long? UncompressedSize
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xFF55B0", Offset = "0xFF55B0", VA = "0xFF55B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xFF55BC", Offset = "0xFF55BC", VA = "0xFF55BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public long? CompressedSize
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xFF5650", Offset = "0xFF5650", VA = "0xFF5650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xFF565C", Offset = "0xFF565C", VA = "0xFF565C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public long? LocalHeaderOffset
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xFF5664", Offset = "0xFF5664", VA = "0xFF5664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xFF5670", Offset = "0xFF5670", VA = "0xFF5670")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int? StartDiskNumber
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xFF5678", Offset = "0xFF5678", VA = "0xFF5678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xFF55C4", Offset = "0xFF55C4", VA = "0xFF55C4")]
		private void UpdateSize()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xFF5680", Offset = "0xFF5680", VA = "0xFF5680")]
		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			return default(Zip64ExtraField);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xFF58C8", Offset = "0xFF58C8", VA = "0xFF58C8")]
		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EE")]
	internal struct Zip64EndOfCentralDirectoryLocator
	{
		[Token(Token = "0x400039C")]
		public const uint SignatureConstant = 117853008u;

		[Token(Token = "0x400039D")]
		public const int SizeOfBlockWithoutSignature = 16;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint NumberOfDiskWithZip64EOCD;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong OffsetOfZip64EOCD;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint TotalNumberOfDisks;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xFF53D0", Offset = "0xFF53D0", VA = "0xFF53D0")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EF")]
	internal struct Zip64EndOfCentralDirectoryRecord
	{
		[Token(Token = "0x40003A1")]
		private const uint SignatureConstant = 101075792u;

		[Token(Token = "0x40003A2")]
		private const ulong NormalSize = 44uL;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong SizeOfThisRecord;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort VersionMadeBy;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint NumberOfThisDisk;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint NumberOfDiskWithStartOfCD;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong NumberOfEntriesOnThisDisk;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong NumberOfEntriesTotal;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong SizeOfCentralDirectory;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ulong OffsetOfCentralDirectory;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xFF5474", Offset = "0xFF5474", VA = "0xFF5474")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F0")]
	internal struct ZipLocalFileHeader
	{
		[Token(Token = "0x40003AC")]
		public const uint DataDescriptorSignature = 134695760u;

		[Token(Token = "0x40003AD")]
		public const uint SignatureConstant = 67324752u;

		[Token(Token = "0x40003AE")]
		public const int OffsetToCrcFromHeaderStart = 14;

		[Token(Token = "0x40003AF")]
		public const int OffsetToBitFlagFromHeaderStart = 6;

		[Token(Token = "0x40003B0")]
		public const int SizeOfLocalHeader = 30;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xFF7008", Offset = "0xFF7008", VA = "0xFF7008")]
		public static bool TrySkipBlock(BinaryReader reader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F1")]
	internal struct ZipCentralDirectoryFileHeader
	{
		[Token(Token = "0x40003B1")]
		public const uint SignatureConstant = 33639248u;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte VersionMadeByCompatibility;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte VersionMadeBySpecification;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort GeneralPurposeBitFlag;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort CompressionMethod;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint LastModified;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint Crc32;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long CompressedSize;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long UncompressedSize;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ushort FilenameLength;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public ushort ExtraFieldLength;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ushort FileCommentLength;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int DiskNumberStart;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ushort InternalFileAttributes;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint ExternalFileAttributes;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long RelativeOffsetOfLocalHeader;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] Filename;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] FileComment;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ZipGenericExtraField> ExtraFields;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xFF6794", Offset = "0xFF6794", VA = "0xFF6794")]
		public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F2")]
	internal struct ZipEndOfCentralDirectoryBlock
	{
		[Token(Token = "0x40003C5")]
		public const uint SignatureConstant = 101010256u;

		[Token(Token = "0x40003C6")]
		public const int SizeOfBlockWithoutSignature = 18;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Signature;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort NumberOfThisDisk;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort NumberOfEntriesInTheCentralDirectory;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint SizeOfCentralDirectory;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] ArchiveComment;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xFF666C", Offset = "0xFF666C", VA = "0xFF666C")]
		public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F3")]
	internal static class ZipHelper
	{
		[Token(Token = "0x40003CF")]
		internal const uint Mask32Bit = uint.MaxValue;

		[Token(Token = "0x40003D0")]
		internal const ushort Mask16Bit = ushort.MaxValue;

		[Token(Token = "0x40003D1")]
		private const int BackwardsSeekingBufferSize = 32;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xFF6E44", Offset = "0xFF6E44", VA = "0xFF6E44")]
		internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xFF6568", Offset = "0xFF6568", VA = "0xFF6568")]
		internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xFF6D3C", Offset = "0xFF6D3C", VA = "0xFF6D3C")]
		internal static void AdvanceToPosition(this Stream stream, long position)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xFF6EEC", Offset = "0xFF6EEC", VA = "0xFF6EEC")]
		private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F4")]
	public class ZipArchiveException : Exception
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0xFF5F4C", Offset = "0xFF5F4C", VA = "0xFF5F4C")]
		public ZipArchiveException(string msg)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xFF5FC0", Offset = "0xFF5FC0", VA = "0xFF5FC0")]
		public ZipArchiveException(string msg, Exception inner)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public static class ZipArchiveUtils
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0xFF603C", Offset = "0xFF603C", VA = "0xFF603C")]
		public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
		{
		}
	}
}
