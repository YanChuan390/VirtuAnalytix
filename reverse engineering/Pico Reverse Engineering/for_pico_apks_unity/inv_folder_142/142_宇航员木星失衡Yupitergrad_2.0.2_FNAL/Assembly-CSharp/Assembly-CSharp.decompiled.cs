using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Oculus.Spatializer.Propagation;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class CausticsVolumeDriver : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D fogTexture2D;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Texture3D fogVolume3D;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2150C74", Offset = "0x2150C74", VA = "0x2150C74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2150CA4", Offset = "0x2150CA4", VA = "0x2150CA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2150FB4", Offset = "0x2150FB4", VA = "0x2150FB4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2150CD4", Offset = "0x2150CD4", VA = "0x2150CD4")]
	public static Texture3D Convert(Texture2D temp2DTex)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2151008", Offset = "0x2151008", VA = "0x2151008")]
	public static bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x21510FC", Offset = "0x21510FC", VA = "0x21510FC")]
	public CausticsVolumeDriver()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xF0AF30", Offset = "0xF0AF30")]
public class FastList<T>
{
	[Token(Token = "0x2000084")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B020", Offset = "0xF0B020")]
	private sealed class <GetEnumerator>d__25 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FastList<T> <>4__this;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x17000030")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x60002B7")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B4")]
		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60002B5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002B6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] array;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x6000009")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000A")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public T Item
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x600000C")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	public FastList()
	{
	}

	[Token(Token = "0x6000008")]
	public FastList(int size)
	{
	}

	[Token(Token = "0x600000D")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x600000E")]
	public void AddUnique(T item)
	{
	}

	[Token(Token = "0x600000F")]
	public void AddRange(IEnumerable<T> items)
	{
	}

	[Token(Token = "0x6000010")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x6000011")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x6000013")]
	public bool RemoveFast(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	public void RemoveAtFast(int index)
	{
	}

	[Token(Token = "0x6000015")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6000017")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000018")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x600001A")]
	public void InsertionSort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x600001B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0BE78", Offset = "0xF0BE78")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	public T Find(Predicate<T> match)
	{
		return (T)null;
	}

	[Token(Token = "0x600001D")]
	private void Allocate()
	{
	}

	[Token(Token = "0x600001E")]
	private void Trim()
	{
	}

	[Token(Token = "0x600001F")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000020")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000004")]
public class InspectorNoteAttribute : PropertyAttribute
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string header;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string message;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x21515B0", Offset = "0x21515B0", VA = "0x21515B0")]
	public InspectorNoteAttribute(string header, string message = "")
	{
	}
}
[Token(Token = "0x2000005")]
public class InspectorCommentAttribute : PropertyAttribute
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string message;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x215157C", Offset = "0x215157C", VA = "0x215157C")]
	public InspectorCommentAttribute(string message = "")
	{
	}
}
[Token(Token = "0x2000006")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x21511F8", Offset = "0x21511F8", VA = "0x21511F8")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2151278", Offset = "0x2151278", VA = "0x2151278")]
	private void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x21513F4", Offset = "0x21513F4", VA = "0x21513F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2151458", Offset = "0x2151458", VA = "0x2151458")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x21512B4", Offset = "0x21512B4", VA = "0x21512B4")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2151514", Offset = "0x2151514", VA = "0x2151514")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2151574", Offset = "0x2151574", VA = "0x2151574")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class AvatarLayer
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2150558", Offset = "0x2150558", VA = "0x2150558")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class PacketRecordSettings
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x244FA94", Offset = "0x244FA94", VA = "0x244FA94")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000009")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000086")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x183F2E4", Offset = "0x183F2E4", VA = "0x183F2E4")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x2000087")]
	public enum HandType
	{
		[Token(Token = "0x400030E")]
		Right,
		[Token(Token = "0x400030F")]
		Left,
		[Token(Token = "0x4000310")]
		Max
	}

	[Token(Token = "0x2000088")]
	public enum HandJoint
	{
		[Token(Token = "0x4000312")]
		HandBase,
		[Token(Token = "0x4000313")]
		IndexBase,
		[Token(Token = "0x4000314")]
		IndexTip,
		[Token(Token = "0x4000315")]
		ThumbBase,
		[Token(Token = "0x4000316")]
		ThumbTip,
		[Token(Token = "0x4000317")]
		Max
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B030", Offset = "0xF0B030")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1841680", Offset = "0x1841680", VA = "0x1841680", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x18416E8", Offset = "0x18416E8", VA = "0x18416E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x184106C", Offset = "0x184106C", VA = "0x184106C")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x18414E4", Offset = "0x18414E4", VA = "0x18414E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x18414E8", Offset = "0x18414E8", VA = "0x18414E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1841688", Offset = "0x1841688", VA = "0x1841688", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B0F8", Offset = "0xF0B0F8")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B130", Offset = "0xF0B130")]
	public bool EnableBody;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B168", Offset = "0xF0B168")]
	public bool RecordPackets;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B1A0", Offset = "0xF0B1A0")]
	public bool StartWithControllers;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B1D8", Offset = "0xF0B1D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B1D8", Offset = "0xF0B1D8")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B248", Offset = "0xF0B248")]
	private bool CombineMeshes;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B280", Offset = "0xF0B280")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B2B8", Offset = "0xF0B2B8")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF0B2F0", Offset = "0xF0B2F0")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B328", Offset = "0xF0B328")]
	public bool EnableLaughter;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x4000049")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x400004B")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x400004C")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x400004D")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x400004E")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x400004F")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x183BD20", Offset = "0x183BD20", VA = "0x183BD20")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x183C138", Offset = "0x183C138", VA = "0x183C138")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x183C1C0", Offset = "0x183C1C0", VA = "0x183C1C0")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x183C22C", Offset = "0x183C22C", VA = "0x183C22C")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x183C34C", Offset = "0x183C34C", VA = "0x183C34C")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x183C430", Offset = "0x183C430", VA = "0x183C430")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x183C510", Offset = "0x183C510", VA = "0x183C510")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x183C6F8", Offset = "0x183C6F8", VA = "0x183C6F8")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x183C7C0", Offset = "0x183C7C0", VA = "0x183C7C0")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x18332A0", Offset = "0x18332A0", VA = "0x18332A0")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1838E70", Offset = "0x1838E70", VA = "0x1838E70")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x183C844", Offset = "0x183C844", VA = "0x183C844")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x183C960", Offset = "0x183C960", VA = "0x183C960")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x183C9C0", Offset = "0x183C9C0", VA = "0x183C9C0")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x600003A")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x183CE14", Offset = "0x183CE14", VA = "0x183CE14")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x183D164", Offset = "0x183D164", VA = "0x183D164")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x183D30C", Offset = "0x183D30C", VA = "0x183D30C")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x183D5D4", Offset = "0x183D5D4", VA = "0x183D5D4")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x183D6C0", Offset = "0x183D6C0", VA = "0x183D6C0")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x183DCA8", Offset = "0x183DCA8", VA = "0x183DCA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x183DFB4", Offset = "0x183DFB4", VA = "0x183DFB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x183E9C8", Offset = "0x183E9C8", VA = "0x183E9C8")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x183EA1C", Offset = "0x183EA1C", VA = "0x183EA1C")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x183D92C", Offset = "0x183D92C", VA = "0x183D92C")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x183D9C4", Offset = "0x183D9C4", VA = "0x183D9C4")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x183EA4C", Offset = "0x183EA4C", VA = "0x183EA4C")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x183E320", Offset = "0x183E320", VA = "0x183E320")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x183EC84", Offset = "0x183EC84", VA = "0x183EC84")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x183EAB4", Offset = "0x183EAB4", VA = "0x183EAB4")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x183F368", Offset = "0x183F368", VA = "0x183F368")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x183F754", Offset = "0x183F754", VA = "0x183F754")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x183FAD4", Offset = "0x183FAD4", VA = "0x183FAD4")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x183FC10", Offset = "0x183FC10", VA = "0x183FC10")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x183FDC8", Offset = "0x183FDC8", VA = "0x183FDC8")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x183E4C8", Offset = "0x183E4C8", VA = "0x183E4C8")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x183FEA0", Offset = "0x183FEA0", VA = "0x183FEA0")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x183E330", Offset = "0x183E330", VA = "0x183E330")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x183FF94", Offset = "0x183FF94", VA = "0x183FF94")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x184059C", Offset = "0x184059C", VA = "0x184059C")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1840A58", Offset = "0x1840A58", VA = "0x1840A58")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1840AD0", Offset = "0x1840AD0", VA = "0x1840AD0")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1840B4C", Offset = "0x1840B4C", VA = "0x1840B4C")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x183E860", Offset = "0x183E860", VA = "0x183E860")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x184005C", Offset = "0x184005C", VA = "0x184005C")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1840FF0", Offset = "0x1840FF0", VA = "0x1840FF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0BEDC", Offset = "0xF0BEDC")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1841098", Offset = "0x1841098", VA = "0x1841098")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1840E94", Offset = "0x1840E94", VA = "0x1840E94")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1841160", Offset = "0x1841160", VA = "0x1841160")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x184124C", Offset = "0x184124C", VA = "0x184124C")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1840C1C", Offset = "0x1840C1C", VA = "0x1840C1C")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1841338", Offset = "0x1841338", VA = "0x1841338")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x200000A")]
public class OvrAvatarAsset
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x18416F0", Offset = "0x18416F0", VA = "0x18416F0")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x200000B")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x18417A4", Offset = "0x18417A4", VA = "0x18417A4")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1842A78", Offset = "0x1842A78", VA = "0x1842A78")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1842628", Offset = "0x1842628", VA = "0x1842628")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x18423E8", Offset = "0x18423E8", VA = "0x18423E8")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x18424BC", Offset = "0x18424BC", VA = "0x18424BC")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1842CD4", Offset = "0x1842CD4", VA = "0x1842CD4")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x400006C")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1843294", Offset = "0x1843294", VA = "0x1843294")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x200000D")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x18434F8", Offset = "0x18434F8", VA = "0x18434F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1843900", Offset = "0x1843900", VA = "0x1843900")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x200000E")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x183F980", Offset = "0x183F980", VA = "0x183F980")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1843A14", Offset = "0x1843A14", VA = "0x1843A14")]
	private void Update()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1843B38", Offset = "0x1843B38", VA = "0x1843B38")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x200000F")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1843B9C", Offset = "0x1843B9C", VA = "0x1843B9C")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x184361C", Offset = "0x184361C", VA = "0x184361C")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1843BA4", Offset = "0x1843BA4", VA = "0x1843BA4")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1843C04", Offset = "0x1843C04", VA = "0x1843C04")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x18443E8", Offset = "0x18443E8", VA = "0x18443E8")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1843964", Offset = "0x1843964", VA = "0x1843964")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000010")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x200008A")]
	public enum PacketMode
	{
		[Token(Token = "0x400031C")]
		SDK,
		[Token(Token = "0x400031D")]
		Unity
	}

	[Token(Token = "0x200008B")]
	public struct ControllerPose
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1845A64", Offset = "0x1845A64", VA = "0x1845A64")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x200008C")]
	public struct PoseFrame
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x183EF2C", Offset = "0x183EF2C", VA = "0x183EF2C")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x18459B0", Offset = "0x18459B0", VA = "0x18459B0")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x6000075")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x18459C0", Offset = "0x18459C0", VA = "0x18459C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x183DA5C", Offset = "0x183DA5C", VA = "0x183DA5C")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1845A4C", Offset = "0x1845A4C", VA = "0x1845A4C")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1845A54", Offset = "0x1845A54", VA = "0x1845A54")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000011")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1845BC0", Offset = "0x1845BC0", VA = "0x1845BC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1845D20", Offset = "0x1845D20", VA = "0x1845D20")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000012")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1845D8C", Offset = "0x1845D8C", VA = "0x1845D8C")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1845EF8", Offset = "0x1845EF8", VA = "0x1845EF8")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x184629C", Offset = "0x184629C", VA = "0x184629C")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x18464B8", Offset = "0x18464B8", VA = "0x18464B8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x18464E4", Offset = "0x18464E4", VA = "0x18464E4")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000013")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x200008D")]
	public enum TextureType
	{
		[Token(Token = "0x400032E")]
		DiffuseTextures,
		[Token(Token = "0x400032F")]
		NormalMaps,
		[Token(Token = "0x4000330")]
		RoughnessMaps,
		[Token(Token = "0x4000331")]
		Count
	}

	[Token(Token = "0x200008E")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x200008F")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000090")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000091")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2449070", Offset = "0x2449070", VA = "0x2449070")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B040", Offset = "0xF0B040")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2449000", Offset = "0x2449000", VA = "0x2449000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2449068", Offset = "0x2449068", VA = "0x2449068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x24486D8", Offset = "0x24486D8", VA = "0x24486D8")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2448704", Offset = "0x2448704", VA = "0x2448704", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2448708", Offset = "0x2448708", VA = "0x2448708", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2449008", Offset = "0x2449008", VA = "0x2449008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x40000A0")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x40000A1")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x40000A2")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x40000A3")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1846594", Offset = "0x1846594", VA = "0x1846594")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1846748", Offset = "0x1846748", VA = "0x1846748")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1846788", Offset = "0x1846788", VA = "0x1846788")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1846ED8", Offset = "0x1846ED8", VA = "0x1846ED8")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1846F44", Offset = "0x1846F44", VA = "0x1846F44")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x184681C", Offset = "0x184681C", VA = "0x184681C")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1846F98", Offset = "0x1846F98", VA = "0x1846F98")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1846C38", Offset = "0x1846C38", VA = "0x1846C38")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1847088", Offset = "0x1847088", VA = "0x1847088")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1847300", Offset = "0x1847300", VA = "0x1847300")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x18473FC", Offset = "0x18473FC", VA = "0x18473FC")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1847434", Offset = "0x1847434", VA = "0x1847434")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1846E40", Offset = "0x1846E40", VA = "0x1846E40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0BF40", Offset = "0xF0BF40")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1848300", Offset = "0x1848300", VA = "0x1848300")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x2000014")]
public class OvrAvatarPacket
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000003")]
	public float Duration
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2449078", Offset = "0x2449078", VA = "0x2449078")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000004")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x24490E4", Offset = "0x24490E4", VA = "0x24490E4")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2449168", Offset = "0x2449168", VA = "0x2449168")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2449250", Offset = "0x2449250", VA = "0x2449250")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x24493C0", Offset = "0x24493C0", VA = "0x24493C0")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x24494E8", Offset = "0x24494E8", VA = "0x24494E8")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x24495B8", Offset = "0x24495B8", VA = "0x24495B8")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x24497C4", Offset = "0x24497C4", VA = "0x24497C4")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2449A1C", Offset = "0x2449A1C", VA = "0x2449A1C")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000015")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2150960", Offset = "0x2150960", VA = "0x2150960")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2150A74", Offset = "0x2150A74", VA = "0x2150A74")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2150C20", Offset = "0x2150C20", VA = "0x2150C20")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2150AE4", Offset = "0x2150AE4", VA = "0x2150AE4")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2150B78", Offset = "0x2150B78", VA = "0x2150B78")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000016")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2150560", Offset = "0x2150560", VA = "0x2150560")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2150904", Offset = "0x2150904", VA = "0x2150904")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2150700", Offset = "0x2150700", VA = "0x2150700")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2150778", Offset = "0x2150778", VA = "0x2150778")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2150814", Offset = "0x2150814", VA = "0x2150814")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000017")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x40000AB")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x40000AC")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2449C0C", Offset = "0x2449C0C", VA = "0x2449C0C")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2449C98", Offset = "0x2449C98", VA = "0x2449C98", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2449CB4", Offset = "0x2449CB4", VA = "0x2449CB4")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2449E60", Offset = "0x2449E60", VA = "0x2449E60")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x244A034", Offset = "0x244A034", VA = "0x244A034")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000018")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x244A0BC", Offset = "0x244A0BC", VA = "0x244A0BC")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x244A1A0", Offset = "0x244A1A0", VA = "0x244A1A0")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x244A418", Offset = "0x244A418", VA = "0x244A418")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x244A7AC", Offset = "0x244A7AC", VA = "0x244A7AC")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x244A8A4", Offset = "0x244A8A4", VA = "0x244A8A4")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000019")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x40000B5")]
	Body = 1,
	[Token(Token = "0x40000B6")]
	Hands = 2,
	[Token(Token = "0x40000B7")]
	Base = 4,
	[Token(Token = "0x40000B8")]
	BodyTilt = 0x10,
	[Token(Token = "0x40000B9")]
	Expressive = 0x20,
	[Token(Token = "0x40000BA")]
	All = -1
}
[Token(Token = "0x200001A")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x40000BC")]
	AvatarSpecification,
	[Token(Token = "0x40000BD")]
	AssetLoaded,
	[Token(Token = "0x40000BE")]
	Count
}
[Token(Token = "0x200001B")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x200001C")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x200001D")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x40000C4")]
	Mesh,
	[Token(Token = "0x40000C5")]
	Texture,
	[Token(Token = "0x40000C6")]
	Pose,
	[Token(Token = "0x40000C7")]
	Material,
	[Token(Token = "0x40000C8")]
	CombinedMesh,
	[Token(Token = "0x40000C9")]
	PBSMaterial,
	[Token(Token = "0x40000CA")]
	FailedLoad,
	[Token(Token = "0x40000CB")]
	Count
}
[Token(Token = "0x200001E")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x200001F")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000020")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x2000021")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000022")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000023")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x4000100")]
	RGB24,
	[Token(Token = "0x4000101")]
	DXT1,
	[Token(Token = "0x4000102")]
	DXT5,
	[Token(Token = "0x4000103")]
	ASTC_RGB_6x6,
	[Token(Token = "0x4000104")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x4000105")]
	Count
}
[Token(Token = "0x2000024")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000025")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x400010D")]
	SkinnedMeshRender,
	[Token(Token = "0x400010E")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x400010F")]
	ProjectorRender,
	[Token(Token = "0x4000110")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x4000111")]
	Count
}
[Token(Token = "0x2000026")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x4000113")]
	Unknown,
	[Token(Token = "0x4000114")]
	Default,
	[Token(Token = "0x4000115")]
	Verbose,
	[Token(Token = "0x4000116")]
	Debug,
	[Token(Token = "0x4000117")]
	Info,
	[Token(Token = "0x4000118")]
	Warn,
	[Token(Token = "0x4000119")]
	Error,
	[Token(Token = "0x400011A")]
	Fatal,
	[Token(Token = "0x400011B")]
	Silent
}
[Token(Token = "0x2000027")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000028")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x4000120")]
	One = 1,
	[Token(Token = "0x4000121")]
	Two = 2,
	[Token(Token = "0x4000122")]
	Three = 4,
	[Token(Token = "0x4000123")]
	Joystick = 8
}
[Token(Token = "0x2000029")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x4000125")]
	One = 1,
	[Token(Token = "0x4000126")]
	Two = 2,
	[Token(Token = "0x4000127")]
	Joystick = 4,
	[Token(Token = "0x4000128")]
	ThumbRest = 8,
	[Token(Token = "0x4000129")]
	Index = 0x10,
	[Token(Token = "0x400012A")]
	Pointing = 0x40,
	[Token(Token = "0x400012B")]
	ThumbUp = 0x80
}
[Token(Token = "0x200002A")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x200002B")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x200002C")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x200002D")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200002E")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200002F")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x2000030")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000031")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000032")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x400014B")]
	Add,
	[Token(Token = "0x400014C")]
	Multiply,
	[Token(Token = "0x400014D")]
	Count
}
[Token(Token = "0x2000033")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x400014F")]
	Color,
	[Token(Token = "0x4000150")]
	Texture,
	[Token(Token = "0x4000151")]
	TextureSingleChannel,
	[Token(Token = "0x4000152")]
	Parallax,
	[Token(Token = "0x4000153")]
	Count
}
[Token(Token = "0x2000034")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x4000155")]
	None,
	[Token(Token = "0x4000156")]
	Positional,
	[Token(Token = "0x4000157")]
	ViewReflection,
	[Token(Token = "0x4000158")]
	Fresnel,
	[Token(Token = "0x4000159")]
	Pulse,
	[Token(Token = "0x400015A")]
	Count
}
[Token(Token = "0x2000035")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x400015C")]
	Touch,
	[Token(Token = "0x400015D")]
	Malibu,
	[Token(Token = "0x400015E")]
	Go,
	[Token(Token = "0x400015F")]
	Quest,
	[Token(Token = "0x4000160")]
	Count
}
[Token(Token = "0x2000036")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x4000162")]
	Lowest = 1,
	[Token(Token = "0x4000163")]
	Medium = 3,
	[Token(Token = "0x4000164")]
	Highest = 5
}
[Token(Token = "0x2000037")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x4000166")]
	Unknown = -1,
	[Token(Token = "0x4000167")]
	One,
	[Token(Token = "0x4000168")]
	Two
}
[Token(Token = "0x2000038")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2450928", Offset = "0x2450928", VA = "0x2450928")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2450958", Offset = "0x2450958", VA = "0x2450958", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2450B78", Offset = "0x2450B78", VA = "0x2450B78", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000039")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2450C5C", Offset = "0x2450C5C", VA = "0x2450C5C")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2450C8C", Offset = "0x2450C8C", VA = "0x2450C8C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2451020", Offset = "0x2451020", VA = "0x2451020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200003A")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x244FFD0", Offset = "0x244FFD0", VA = "0x244FFD0")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2450000", Offset = "0x2450000", VA = "0x2450000", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2450294", Offset = "0x2450294", VA = "0x2450294", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200003B")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2451188", Offset = "0x2451188", VA = "0x2451188")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x24511B8", Offset = "0x24511B8", VA = "0x24511B8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x24513AC", Offset = "0x24513AC", VA = "0x24513AC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200003C")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x18416F8", Offset = "0x18416F8", VA = "0x18416F8")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x200003D")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x200003E")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x400019D")]
	FirstPerson = 1,
	[Token(Token = "0x400019E")]
	ThirdPerson = 2,
	[Token(Token = "0x400019F")]
	SelfOccluding = 4
}
[Token(Token = "0x200003F")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000040")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000041")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x2000042")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000043")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x40001B5")]
	Default,
	[Token(Token = "0x40001B6")]
	GripSphere,
	[Token(Token = "0x40001B7")]
	GripCube,
	[Token(Token = "0x40001B8")]
	Count
}
[Token(Token = "0x2000044")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x40001BA")]
	Body,
	[Token(Token = "0x40001BB")]
	Clothing,
	[Token(Token = "0x40001BC")]
	Eyewear,
	[Token(Token = "0x40001BD")]
	Hair,
	[Token(Token = "0x40001BE")]
	Beard,
	[Token(Token = "0x40001BF")]
	Count
}
[Token(Token = "0x2000045")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x2000046")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000047")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000048")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000049")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x40001C9")]
	AvatarHead,
	[Token(Token = "0x40001CA")]
	AvatarHand,
	[Token(Token = "0x40001CB")]
	Object,
	[Token(Token = "0x40001CC")]
	ObjectStatic,
	[Token(Token = "0x40001CD")]
	Count
}
[Token(Token = "0x200004A")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x200004B")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x200004C")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x200004D")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x200004E")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x40001D9")]
	Point,
	[Token(Token = "0x40001DA")]
	Direction,
	[Token(Token = "0x40001DB")]
	Spot,
	[Token(Token = "0x40001DC")]
	Count
}
[Token(Token = "0x200004F")]
public struct ovrAvatarLight
{
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x2000050")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x2000051")]
public struct ovrAvatarLights
{
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x2000052")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x2000053")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x40001F2")]
	None = 0u,
	[Token(Token = "0x40001F3")]
	GazeTarget = 1u,
	[Token(Token = "0x40001F4")]
	Any = uint.MaxValue
}
[Token(Token = "0x2000054")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x2000055")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x2000056")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000057")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000058")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000059")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000093")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x244C19C", Offset = "0x244C19C", VA = "0x244C19C")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x4000209")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000005")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2448D78", Offset = "0x2448D78", VA = "0x2448D78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x244A8B4", Offset = "0x244A8B4", VA = "0x244A8B4")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x244AB48", Offset = "0x244AB48", VA = "0x244AB48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x244ABBC", Offset = "0x244ABBC", VA = "0x244ABBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x244BC50", Offset = "0x244BC50", VA = "0x244BC50")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x244BCA8", Offset = "0x244BCA8", VA = "0x244BCA8")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x244BD00", Offset = "0x244BD00", VA = "0x244BD00")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x244BD68", Offset = "0x244BD68", VA = "0x244BD68")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x244BDD0", Offset = "0x244BDD0", VA = "0x244BDD0")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x244B23C", Offset = "0x244B23C", VA = "0x244B23C")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x244BEB0", Offset = "0x244BEB0", VA = "0x244BEB0")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x244BFCC", Offset = "0x244BFCC", VA = "0x244BFCC")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x244A398", Offset = "0x244A398", VA = "0x244A398")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x244C0AC", Offset = "0x244C0AC", VA = "0x244C0AC")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x244AAFC", Offset = "0x244AAFC", VA = "0x244AAFC")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2448F2C", Offset = "0x2448F2C", VA = "0x2448F2C")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x244C184", Offset = "0x244C184", VA = "0x244C184")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x200005A")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000006")]
	public static string AppID
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x244C144", Offset = "0x244C144", VA = "0x244C144")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x244C344", Offset = "0x244C344", VA = "0x244C344")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public static string MobileAppID
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x244C164", Offset = "0x244C164", VA = "0x244C164")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x244C374", Offset = "0x244C374", VA = "0x244C374")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x244C218", Offset = "0x244C218", VA = "0x244C218")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x244C3A4", Offset = "0x244C3A4", VA = "0x244C3A4")]
		set
		{
		}
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x244C3FC", Offset = "0x244C3FC", VA = "0x244C3FC")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x200005B")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x244DE0C", Offset = "0x244DE0C", VA = "0x244DE0C")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x244E0E4", Offset = "0x244E0E4", VA = "0x244E0E4")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x244DF84", Offset = "0x244DF84", VA = "0x244DF84")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x244E310", Offset = "0x244E310", VA = "0x244E310")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x200005C")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x244E320", Offset = "0x244E320", VA = "0x244E320")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x244E468", Offset = "0x244E468", VA = "0x244E468")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x244E608", Offset = "0x244E608", VA = "0x244E608")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x200005D")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x4000218")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x4000219")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x400021A")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x244C46C", Offset = "0x244C46C", VA = "0x244C46C")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x244D390", Offset = "0x244D390", VA = "0x244D390")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x244D5AC", Offset = "0x244D5AC", VA = "0x244D5AC")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x244CAB0", Offset = "0x244CAB0", VA = "0x244CAB0")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x244C880", Offset = "0x244C880", VA = "0x244C880")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x244C994", Offset = "0x244C994", VA = "0x244C994")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x244DDFC", Offset = "0x244DDFC", VA = "0x244DDFC")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x200005E")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000094")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x2000095")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x244EE14", Offset = "0x244EE14", VA = "0x244EE14")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x2000096")]
	public struct TextureSet
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x244F028", Offset = "0x244F028", VA = "0x244F028")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B050", Offset = "0xF0B050")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x244F848", Offset = "0x244F848", VA = "0x244F848", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x244F8B0", Offset = "0x244F8B0", VA = "0x244F8B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x244F1B0", Offset = "0x244F1B0", VA = "0x244F1B0")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x244F358", Offset = "0x244F358", VA = "0x244F358", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x244F35C", Offset = "0x244F35C", VA = "0x244F35C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x244F850", Offset = "0x244F850", VA = "0x244F850", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x400021E")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x400021F")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x4000222")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x4000223")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x4000224")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x4000225")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x4000226")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x4000227")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x4000228")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x244E618", Offset = "0x244E618", VA = "0x244E618")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x244EA6C", Offset = "0x244EA6C", VA = "0x244EA6C")]
	public void Update()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2448FB0", Offset = "0x2448FB0", VA = "0x2448FB0")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x244EC64", Offset = "0x244EC64", VA = "0x244EC64")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x244EBD4", Offset = "0x244EBD4", VA = "0x244EBD4")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x244EE70", Offset = "0x244EE70", VA = "0x244EE70")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x244F058", Offset = "0x244F058", VA = "0x244F058")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x244F100", Offset = "0x244F100", VA = "0x244F100")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0C044", Offset = "0xF0C044")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x244BE64", Offset = "0x244BE64", VA = "0x244BE64")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x244F1DC", Offset = "0x244F1DC", VA = "0x244F1DC")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x200005F")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x244F8B8", Offset = "0x244F8B8", VA = "0x244F8B8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x244FA24", Offset = "0x244FA24", VA = "0x244FA24")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000060")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF0AFD8", Offset = "0xF0AFD8")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000098")]
	public enum RotationAxes
	{
		[Token(Token = "0x4000364")]
		MouseXAndY,
		[Token(Token = "0x4000365")]
		MouseX,
		[Token(Token = "0x4000366")]
		MouseY
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2151600", Offset = "0x2151600", VA = "0x2151600")]
	private void Update()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2151860", Offset = "0x2151860", VA = "0x2151860")]
	private void Start()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2151920", Offset = "0x2151920", VA = "0x2151920")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x2000061")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x4000368")]
		Uninitialized = -1,
		[Token(Token = "0x4000369")]
		NotEnabled,
		[Token(Token = "0x400036A")]
		Success,
		[Token(Token = "0x400036B")]
		StreamError,
		[Token(Token = "0x400036C")]
		ProcessError,
		[Token(Token = "0x400036D")]
		MaxStatValue
	}

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2151940", Offset = "0x2151940", VA = "0x2151940")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2151B84", Offset = "0x2151B84", VA = "0x2151B84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2151D70", Offset = "0x2151D70", VA = "0x2151D70")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x2000062")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x200009A")]
	private enum Parameters
	{
		[Token(Token = "0x400036F")]
		P_GAIN,
		[Token(Token = "0x4000370")]
		P_USEINVSQR,
		[Token(Token = "0x4000371")]
		P_NEAR,
		[Token(Token = "0x4000372")]
		P_FAR,
		[Token(Token = "0x4000373")]
		P_RADIUS,
		[Token(Token = "0x4000374")]
		P_DISABLE_RFL,
		[Token(Token = "0x4000375")]
		P_AMBISTAT,
		[Token(Token = "0x4000376")]
		P_READONLY_GLOBAL_RFL_ENABLED,
		[Token(Token = "0x4000377")]
		P_READONLY_NUM_VOICES,
		[Token(Token = "0x4000378")]
		P_SENDLEVEL,
		[Token(Token = "0x4000379")]
		P_NUM
	}

	[Token(Token = "0x4000237")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000009")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x21520E4", Offset = "0x21520E4", VA = "0x21520E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x21520EC", Offset = "0x21520EC", VA = "0x21520EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float Gain
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x21520F8", Offset = "0x21520F8", VA = "0x21520F8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2152100", Offset = "0x2152100", VA = "0x2152100")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool UseInvSqr
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2152184", Offset = "0x2152184", VA = "0x2152184")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x215218C", Offset = "0x215218C", VA = "0x215218C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float Near
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2152198", Offset = "0x2152198", VA = "0x2152198")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x21521A0", Offset = "0x21521A0", VA = "0x21521A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float Far
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2152228", Offset = "0x2152228", VA = "0x2152228")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2152230", Offset = "0x2152230", VA = "0x2152230")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public float VolumetricRadius
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x21522B8", Offset = "0x21522B8", VA = "0x21522B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x21522C0", Offset = "0x21522C0", VA = "0x21522C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public float ReverbSend
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2152348", Offset = "0x2152348", VA = "0x2152348")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2152350", Offset = "0x2152350", VA = "0x2152350")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool EnableRfl
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x21523D8", Offset = "0x21523D8", VA = "0x21523D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x21523E0", Offset = "0x21523E0", VA = "0x21523E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2151DE4", Offset = "0x2151DE4", VA = "0x2151DE4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xF0C0A8", Offset = "0xF0C0A8")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2152004", Offset = "0x2152004", VA = "0x2152004")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length);

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x21523EC", Offset = "0x21523EC", VA = "0x21523EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2152560", Offset = "0x2152560", VA = "0x2152560")]
	private void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2152564", Offset = "0x2152564", VA = "0x2152564")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2152458", Offset = "0x2152458", VA = "0x2152458")]
	public void SetParameters(ref AudioSource source)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x215262C", Offset = "0x215262C", VA = "0x215262C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2152A94", Offset = "0x2152A94", VA = "0x2152A94")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2151F84", Offset = "0x2151F84", VA = "0x2151F84")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2152B78", Offset = "0x2152B78", VA = "0x2152B78")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x2000063")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x4000242")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x4000244")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2152B98", Offset = "0x2152B98", VA = "0x2152B98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2152BA4", Offset = "0x2152BA4", VA = "0x2152BA4")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2152C5C", Offset = "0x2152C5C", VA = "0x2152C5C")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2152BDC", Offset = "0x2152BDC", VA = "0x2152BDC")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2152CDC", Offset = "0x2152CDC", VA = "0x2152CDC")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x2000064")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x200009B")]
	private struct MeshMaterial
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x200009C")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x400024B")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x17000011")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x215577C", Offset = "0x215577C", VA = "0x215577C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public string filePath
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2155808", Offset = "0x2155808", VA = "0x2155808")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2155880", Offset = "0x2155880", VA = "0x2155880")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x21559C8", Offset = "0x21559C8", VA = "0x21559C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x21559CC", Offset = "0x21559CC", VA = "0x21559CC")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2155F2C", Offset = "0x2155F2C", VA = "0x2155F2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x21562C4", Offset = "0x21562C4", VA = "0x21562C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2156420", Offset = "0x2156420", VA = "0x2156420")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, ref int ignoredMeshCount)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x2156B64", Offset = "0x2156B64", VA = "0x2156B64")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2156BA0", Offset = "0x2156BA0", VA = "0x2156BA0")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, ref int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x21583F4", Offset = "0x21583F4", VA = "0x21583F4")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2158138", Offset = "0x2158138", VA = "0x2158138")]
	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2155D64", Offset = "0x2155D64", VA = "0x2155D64")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x2155B98", Offset = "0x2155B98", VA = "0x2155B98")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2158A08", Offset = "0x2158A08", VA = "0x2158A08")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2158E44", Offset = "0x2158E44", VA = "0x2158E44")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x2000065")]
internal class ONSPPropagation
{
	[Token(Token = "0x200009D")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x4000380")]
		Int8,
		[Token(Token = "0x4000381")]
		UInt8,
		[Token(Token = "0x4000382")]
		Int16,
		[Token(Token = "0x4000383")]
		UInt16,
		[Token(Token = "0x4000384")]
		Int32,
		[Token(Token = "0x4000385")]
		UInt32,
		[Token(Token = "0x4000386")]
		Int64,
		[Token(Token = "0x4000387")]
		UInt64,
		[Token(Token = "0x4000388")]
		Float16,
		[Token(Token = "0x4000389")]
		Float32,
		[Token(Token = "0x400038A")]
		Float64
	}

	[Token(Token = "0x200009E")]
	public class ClientType
	{
		[Token(Token = "0x400038B")]
		public const uint OVRA_CLIENT_TYPE_NATIVE = 0u;

		[Token(Token = "0x400038C")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2016 = 1u;

		[Token(Token = "0x400038D")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_1 = 2u;

		[Token(Token = "0x400038E")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_2 = 3u;

		[Token(Token = "0x400038F")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2018_1 = 4u;

		[Token(Token = "0x4000390")]
		public const uint OVRA_CLIENT_TYPE_FMOD = 5u;

		[Token(Token = "0x4000391")]
		public const uint OVRA_CLIENT_TYPE_UNITY = 6u;

		[Token(Token = "0x4000392")]
		public const uint OVRA_CLIENT_TYPE_UE4 = 7u;

		[Token(Token = "0x4000393")]
		public const uint OVRA_CLIENT_TYPE_VST = 8u;

		[Token(Token = "0x4000394")]
		public const uint OVRA_CLIENT_TYPE_AAX = 9u;

		[Token(Token = "0x4000395")]
		public const uint OVRA_CLIENT_TYPE_TEST = 10u;

		[Token(Token = "0x4000396")]
		public const uint OVRA_CLIENT_TYPE_OTHER = 11u;

		[Token(Token = "0x4000397")]
		public const uint OVRA_CLIENT_TYPE_WWISE_UNKNOWN = 12u;

		[Token(Token = "0x4000398")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_1 = 13u;

		[Token(Token = "0x4000399")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_2 = 14u;

		[Token(Token = "0x400039A")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2021_1 = 15u;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x215319C", Offset = "0x215319C", VA = "0x215319C")]
		public ClientType()
		{
		}
	}

	[Token(Token = "0x200009F")]
	public interface PropagationInterface
	{
		[Token(Token = "0x60002D4")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x60002D5")]
		int SetPropagationThreadAffinity(ulong cpuMask);

		[Token(Token = "0x60002D6")]
		int CreateAudioGeometry(out IntPtr geometry);

		[Token(Token = "0x60002D7")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60002D8")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x60002D9")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60002DA")]
		int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60002DB")]
		int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60002DC")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60002DD")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60002DE")]
		int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x60002DF")]
		int CreateAudioMaterial(out IntPtr material);

		[Token(Token = "0x60002E0")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60002E1")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60002E2")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x20000A0")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x400039B")]
		public const string strOSPS = "AudioPluginOculusSpatializer";

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000038")]
		private IntPtr context
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2153E14", Offset = "0x2153E14", VA = "0x2153E14")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2153E78", Offset = "0x2153E78", VA = "0x2153E78")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2153F08", Offset = "0x2153F08", VA = "0x2153F08")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2153F98", Offset = "0x2153F98", VA = "0x2153F98", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2153FBC", Offset = "0x2153FBC", VA = "0x2153FBC")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x215404C", Offset = "0x215404C", VA = "0x215404C", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2154070", Offset = "0x2154070", VA = "0x2154070")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x21540FC", Offset = "0x21540FC", VA = "0x21540FC", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2154120", Offset = "0x2154120", VA = "0x2154120")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x21541A0", Offset = "0x21541A0", VA = "0x21541A0", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x21541A8", Offset = "0x21541A8", VA = "0x21541A8")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x21542C8", Offset = "0x21542C8", VA = "0x21542C8", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x21543C0", Offset = "0x21543C0", VA = "0x21543C0")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2154458", Offset = "0x2154458", VA = "0x2154458", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2154464", Offset = "0x2154464", VA = "0x2154464")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2154598", Offset = "0x2154598", VA = "0x2154598", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x21545A4", Offset = "0x21545A4", VA = "0x21545A4")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2154650", Offset = "0x2154650", VA = "0x2154650", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x215465C", Offset = "0x215465C", VA = "0x215465C")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2154708", Offset = "0x2154708", VA = "0x2154708", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2154714", Offset = "0x2154714", VA = "0x2154714")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x21547C0", Offset = "0x21547C0", VA = "0x21547C0", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x21547CC", Offset = "0x21547CC", VA = "0x21547CC")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2154858", Offset = "0x2154858", VA = "0x2154858", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x215487C", Offset = "0x215487C", VA = "0x215487C")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x21548FC", Offset = "0x21548FC", VA = "0x21548FC", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2154904", Offset = "0x2154904", VA = "0x2154904")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x21549AC", Offset = "0x21549AC", VA = "0x21549AC", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x21549B8", Offset = "0x21549B8", VA = "0x21549B8")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2154A60", Offset = "0x2154A60", VA = "0x2154A60", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2154A70", Offset = "0x2154A70", VA = "0x2154A70")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2154B00", Offset = "0x2154B00", VA = "0x2154B00", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2153148", Offset = "0x2153148", VA = "0x2153148")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x20000A1")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x400039D")]
		public const string strOSPS = "OculusSpatializerWwise";

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000039")]
		private IntPtr context
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2154B0C", Offset = "0x2154B0C", VA = "0x2154B0C")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2152F90", Offset = "0x2152F90", VA = "0x2152F90")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2154B70", Offset = "0x2154B70", VA = "0x2154B70")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2154C00", Offset = "0x2154C00", VA = "0x2154C00", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2154C24", Offset = "0x2154C24", VA = "0x2154C24")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2154CB4", Offset = "0x2154CB4", VA = "0x2154CB4", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2154CD8", Offset = "0x2154CD8", VA = "0x2154CD8")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2154D68", Offset = "0x2154D68", VA = "0x2154D68", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2154D8C", Offset = "0x2154D8C", VA = "0x2154D8C")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2154E0C", Offset = "0x2154E0C", VA = "0x2154E0C", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2154E14", Offset = "0x2154E14", VA = "0x2154E14")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2154F34", Offset = "0x2154F34", VA = "0x2154F34", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x215502C", Offset = "0x215502C", VA = "0x215502C")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x21550C4", Offset = "0x21550C4", VA = "0x21550C4", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x21550D0", Offset = "0x21550D0", VA = "0x21550D0")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2155204", Offset = "0x2155204", VA = "0x2155204", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2155210", Offset = "0x2155210", VA = "0x2155210")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x21552BC", Offset = "0x21552BC", VA = "0x21552BC", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x21552C8", Offset = "0x21552C8", VA = "0x21552C8")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2155374", Offset = "0x2155374", VA = "0x2155374", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2155380", Offset = "0x2155380", VA = "0x2155380")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x215542C", Offset = "0x215542C", VA = "0x215542C", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2155438", Offset = "0x2155438", VA = "0x2155438")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x21554C8", Offset = "0x21554C8", VA = "0x21554C8", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x21554EC", Offset = "0x21554EC", VA = "0x21554EC")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x215556C", Offset = "0x215556C", VA = "0x215556C", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2155574", Offset = "0x2155574", VA = "0x2155574")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x215561C", Offset = "0x215561C", VA = "0x215561C", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2155628", Offset = "0x2155628", VA = "0x2155628")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x21556D0", Offset = "0x21556D0", VA = "0x21556D0", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x21556E0", Offset = "0x21556E0", VA = "0x21556E0")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2155770", Offset = "0x2155770", VA = "0x2155770", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2153020", Offset = "0x2153020", VA = "0x2153020")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x20000A2")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x400039F")]
		public const string strOSPS = "OculusSpatializerFMOD";

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x1700003A")]
		private IntPtr context
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x21531A4", Offset = "0x21531A4", VA = "0x21531A4")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x215306C", Offset = "0x215306C", VA = "0x215306C")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2153208", Offset = "0x2153208", VA = "0x2153208")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2153298", Offset = "0x2153298", VA = "0x2153298", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x21532BC", Offset = "0x21532BC", VA = "0x21532BC")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x215334C", Offset = "0x215334C", VA = "0x215334C", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2153370", Offset = "0x2153370", VA = "0x2153370")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2153400", Offset = "0x2153400", VA = "0x2153400", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2153424", Offset = "0x2153424", VA = "0x2153424")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x21534A4", Offset = "0x21534A4", VA = "0x21534A4", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x21534AC", Offset = "0x21534AC", VA = "0x21534AC")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x21535CC", Offset = "0x21535CC", VA = "0x21535CC", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x21536C4", Offset = "0x21536C4", VA = "0x21536C4")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x215375C", Offset = "0x215375C", VA = "0x215375C", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2153768", Offset = "0x2153768", VA = "0x2153768")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x215389C", Offset = "0x215389C", VA = "0x215389C", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x21538A8", Offset = "0x21538A8", VA = "0x21538A8")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2153954", Offset = "0x2153954", VA = "0x2153954", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2153960", Offset = "0x2153960", VA = "0x2153960")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2153A0C", Offset = "0x2153A0C", VA = "0x2153A0C", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2153A18", Offset = "0x2153A18", VA = "0x2153A18")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2153AC4", Offset = "0x2153AC4", VA = "0x2153AC4", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2153AD0", Offset = "0x2153AD0", VA = "0x2153AD0")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2153B60", Offset = "0x2153B60", VA = "0x2153B60", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2153B84", Offset = "0x2153B84", VA = "0x2153B84")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2153C04", Offset = "0x2153C04", VA = "0x2153C04", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2153C0C", Offset = "0x2153C0C", VA = "0x2153C0C")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2153CB4", Offset = "0x2153CB4", VA = "0x2153CB4", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2153CC0", Offset = "0x2153CC0", VA = "0x2153CC0")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2153D68", Offset = "0x2153D68", VA = "0x2153D68", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2153D78", Offset = "0x2153D78", VA = "0x2153D78")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2153E08", Offset = "0x2153E08", VA = "0x2153E08", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x21530FC", Offset = "0x21530FC", VA = "0x21530FC")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x17000013")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2152CEC", Offset = "0x2152CEC", VA = "0x2152CEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x2152D68", Offset = "0x2152D68", VA = "0x2152D68")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x2153194", Offset = "0x2153194", VA = "0x2153194")]
	public ONSPPropagation()
	{
	}
}
[Token(Token = "0x2000066")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	public enum Preset
	{
		[Token(Token = "0x40003A2")]
		Custom,
		[Token(Token = "0x40003A3")]
		AcousticTile,
		[Token(Token = "0x40003A4")]
		Brick,
		[Token(Token = "0x40003A5")]
		BrickPainted,
		[Token(Token = "0x40003A6")]
		Carpet,
		[Token(Token = "0x40003A7")]
		CarpetHeavy,
		[Token(Token = "0x40003A8")]
		CarpetHeavyPadded,
		[Token(Token = "0x40003A9")]
		CeramicTile,
		[Token(Token = "0x40003AA")]
		Concrete,
		[Token(Token = "0x40003AB")]
		ConcreteRough,
		[Token(Token = "0x40003AC")]
		ConcreteBlock,
		[Token(Token = "0x40003AD")]
		ConcreteBlockPainted,
		[Token(Token = "0x40003AE")]
		Curtain,
		[Token(Token = "0x40003AF")]
		Foliage,
		[Token(Token = "0x40003B0")]
		Glass,
		[Token(Token = "0x40003B1")]
		GlassHeavy,
		[Token(Token = "0x40003B2")]
		Grass,
		[Token(Token = "0x40003B3")]
		Gravel,
		[Token(Token = "0x40003B4")]
		GypsumBoard,
		[Token(Token = "0x40003B5")]
		PlasterOnBrick,
		[Token(Token = "0x40003B6")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x40003B7")]
		Soil,
		[Token(Token = "0x40003B8")]
		SoundProof,
		[Token(Token = "0x40003B9")]
		Snow,
		[Token(Token = "0x40003BA")]
		Steel,
		[Token(Token = "0x40003BB")]
		Water,
		[Token(Token = "0x40003BC")]
		WoodThin,
		[Token(Token = "0x40003BD")]
		WoodThick,
		[Token(Token = "0x40003BE")]
		WoodFloor,
		[Token(Token = "0x40003BF")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x20000A4")]
	public sealed class Point
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x21610C4", Offset = "0x21610C4", VA = "0x21610C4")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x216123C", Offset = "0x216123C", VA = "0x216123C")]
		public static implicit operator Point(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x21612AC", Offset = "0x21612AC", VA = "0x21612AC")]
		public static implicit operator Vector2(Point point)
		{
			return default(Vector2);
		}
	}

	[Serializable]
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xF0B060", Offset = "0xF0B060")]
	public sealed class Spectrum
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B0E8", Offset = "0xF0B0E8")]
		private sealed class <>c
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Point, float> <>9__3_0;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Point, float> <>9__3_1;

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2161718", Offset = "0x2161718", VA = "0x2161718")]
			public <>c()
			{
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2161720", Offset = "0x2161720", VA = "0x2161720")]
			internal float <get_Item>b__3_0(Point p)
			{
				return default(float);
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2161738", Offset = "0x2161738", VA = "0x2161738")]
			internal float <get_Item>b__3_1(Point p)
			{
				return default(float);
			}
		}

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x1700003B")]
		public float Item
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x21612E4", Offset = "0x21612E4", VA = "0x21612E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x21611B8", Offset = "0x21611B8", VA = "0x21611B8")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B400", Offset = "0xF0B400")]
	public Spectrum absorption;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B438", Offset = "0xF0B438")]
	public Spectrum transmission;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B470", Offset = "0xF0B470")]
	public Spectrum scattering;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x17000014")]
	public Preset preset
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2158F28", Offset = "0x2158F28", VA = "0x2158F28")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2158F30", Offset = "0x2158F30", VA = "0x2158F30")]
		set
		{
		}
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x2158F58", Offset = "0x2158F58", VA = "0x2158F58")]
	private void Start()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x215889C", Offset = "0x215889C", VA = "0x215889C")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2159508", Offset = "0x2159508", VA = "0x2159508")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x215950C", Offset = "0x215950C", VA = "0x215950C")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2158F5C", Offset = "0x2158F5C", VA = "0x2158F5C")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2158260", Offset = "0x2158260", VA = "0x2158260")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x21595F0", Offset = "0x21595F0", VA = "0x21595F0")]
	private static void AcousticTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2159A70", Offset = "0x2159A70", VA = "0x2159A70")]
	private static void Brick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2159EF0", Offset = "0x2159EF0", VA = "0x2159EF0")]
	private static void BrickPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x215A370", Offset = "0x215A370", VA = "0x215A370")]
	private static void Carpet(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x215A7F0", Offset = "0x215A7F0", VA = "0x215A7F0")]
	private static void CarpetHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x215AC70", Offset = "0x215AC70", VA = "0x215AC70")]
	private static void CarpetHeavyPadded(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x215B0F0", Offset = "0x215B0F0", VA = "0x215B0F0")]
	private static void CeramicTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x215B570", Offset = "0x215B570", VA = "0x215B570")]
	private static void Concrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x215B9F0", Offset = "0x215B9F0", VA = "0x215B9F0")]
	private static void ConcreteRough(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x215BE70", Offset = "0x215BE70", VA = "0x215BE70")]
	private static void ConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x215C2F0", Offset = "0x215C2F0", VA = "0x215C2F0")]
	private static void ConcreteBlockPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x215C770", Offset = "0x215C770", VA = "0x215C770")]
	private static void Curtain(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x215CBF0", Offset = "0x215CBF0", VA = "0x215CBF0")]
	private static void Foliage(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x215D070", Offset = "0x215D070", VA = "0x215D070")]
	private static void Glass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x215D4E8", Offset = "0x215D4E8", VA = "0x215D4E8")]
	private static void GlassHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x215D968", Offset = "0x215D968", VA = "0x215D968")]
	private static void Grass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x215DCC4", Offset = "0x215DCC4", VA = "0x215DCC4")]
	private static void Gravel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x215E020", Offset = "0x215E020", VA = "0x215E020")]
	private static void GypsumBoard(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x215E4A0", Offset = "0x215E4A0", VA = "0x215E4A0")]
	private static void PlasterOnBrick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x215E920", Offset = "0x215E920", VA = "0x215E920")]
	private static void PlasterOnConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x215EDA0", Offset = "0x215EDA0", VA = "0x215EDA0")]
	private static void Soil(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x215F0FC", Offset = "0x215F0FC", VA = "0x215F0FC")]
	private static void SoundProof(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x215F278", Offset = "0x215F278", VA = "0x215F278")]
	private static void Snow(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x215F5D4", Offset = "0x215F5D4", VA = "0x215F5D4")]
	private static void Steel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x215FA4C", Offset = "0x215FA4C", VA = "0x215FA4C")]
	private static void Water(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x215FECC", Offset = "0x215FECC", VA = "0x215FECC")]
	private static void WoodThin(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2160344", Offset = "0x2160344", VA = "0x2160344")]
	private static void WoodThick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x21607C4", Offset = "0x21607C4", VA = "0x21607C4")]
	private static void WoodFloor(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2160C44", Offset = "0x2160C44", VA = "0x2160C44")]
	private static void WoodOnConcrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x21610FC", Offset = "0x21610FC", VA = "0x21610FC")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x2000067")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2161750", Offset = "0x2161750", VA = "0x2161750")]
	private void Update()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2161820", Offset = "0x2161820", VA = "0x2161820")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x2000068")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x17000015")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2151E58", Offset = "0x2151E58", VA = "0x2151E58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2161DF4", Offset = "0x2161DF4", VA = "0x2161DF4")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x2000069")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x4000256")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2161E04", Offset = "0x2161E04", VA = "0x2161E04")]
	private static extern void ONSP_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2161E9C", Offset = "0x2161E9C", VA = "0x2161E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2161FA8", Offset = "0x2161FA8", VA = "0x2161FA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2161FAC", Offset = "0x2161FAC", VA = "0x2161FAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2161FB0", Offset = "0x2161FB0", VA = "0x2161FB0")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x200006A")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x4000265")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x400026B")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1839ADC", Offset = "0x1839ADC", VA = "0x1839ADC")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x183990C", Offset = "0x183990C", VA = "0x183990C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xF0C0BC", Offset = "0xF0C0BC")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1839B14", Offset = "0x1839B14", VA = "0x1839B14")]
	private void Start()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1839C58", Offset = "0x1839C58", VA = "0x1839C58")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1839D4C", Offset = "0x1839D4C", VA = "0x1839D4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x183A710", Offset = "0x183A710", VA = "0x183A710")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1839BC4", Offset = "0x1839BC4", VA = "0x1839BC4")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1839CBC", Offset = "0x1839CBC", VA = "0x1839CBC")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x183A478", Offset = "0x183A478", VA = "0x183A478")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x183A4F8", Offset = "0x183A4F8", VA = "0x183A4F8")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x183A580", Offset = "0x183A580", VA = "0x183A580")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x183A608", Offset = "0x183A608", VA = "0x183A608")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x183A688", Offset = "0x183A688", VA = "0x183A688")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x183B584", Offset = "0x183B584", VA = "0x183B584")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x183B62C", Offset = "0x183B62C", VA = "0x183B62C")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x183B6D4", Offset = "0x183B6D4", VA = "0x183B6D4")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x200006B")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x200006C")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2161830", Offset = "0x2161830", VA = "0x2161830")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2161834", Offset = "0x2161834", VA = "0x2161834")]
	private void Update()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2161838", Offset = "0x2161838", VA = "0x2161838")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x21619A0", Offset = "0x21619A0", VA = "0x21619A0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2161884", Offset = "0x2161884", VA = "0x2161884")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2161914", Offset = "0x2161914", VA = "0x2161914")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x21619EC", Offset = "0x21619EC", VA = "0x21619EC")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2161A84", Offset = "0x2161A84", VA = "0x2161A84")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2161BF4", Offset = "0x2161BF4", VA = "0x2161BF4")]
	private void SetReflectionValues(ref ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2161D64", Offset = "0x2161D64", VA = "0x2161D64")]
	public ONSPReflectionZone()
	{
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x200006D")]
	public enum FaceType : uint
	{
		[Token(Token = "0x4000273")]
		TRIANGLES,
		[Token(Token = "0x4000274")]
		QUADS
	}
	[Token(Token = "0x200006E")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x4000276")]
		ABSORPTION,
		[Token(Token = "0x4000277")]
		TRANSMISSION,
		[Token(Token = "0x4000278")]
		SCATTERING
	}
	[Token(Token = "0x200006F")]
	public struct MeshGroup
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x2000070")]
	public static class AvatarLogger
	{
		[Token(Token = "0x400027D")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x400027E")]
		public const string Tab = "    ";

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1831784", Offset = "0x1831784", VA = "0x1831784")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C120", Offset = "0xF0C120")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C120", Offset = "0xF0C120")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x183180C", Offset = "0x183180C", VA = "0x183180C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C180", Offset = "0xF0C180")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C180", Offset = "0xF0C180")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x18318A4", Offset = "0x18318A4", VA = "0x18318A4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C1E0", Offset = "0xF0C1E0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C1E0", Offset = "0xF0C1E0")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x183192C", Offset = "0x183192C", VA = "0x183192C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C240", Offset = "0xF0C240")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C240", Offset = "0xF0C240")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x18319B4", Offset = "0x18319B4", VA = "0x18319B4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C2A0", Offset = "0xF0C2A0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xF0C2A0", Offset = "0xF0C2A0")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class CAPI
	{
		[Token(Token = "0x20000A7")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x20000A8")]
		public enum Result
		{
			[Token(Token = "0x40003C5")]
			Success = 0,
			[Token(Token = "0x40003C6")]
			Failure = -1000,
			[Token(Token = "0x40003C7")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x40003C8")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x40003C9")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x40003CA")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x40003CB")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x40003CC")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x40003CD")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x20000A9")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1839380", Offset = "0x1839380", VA = "0x1839380")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x400027F")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x4000287")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1831AB4", Offset = "0x1831AB4", VA = "0x1831AB4")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1831B44", Offset = "0x1831B44", VA = "0x1831B44")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1831D0C", Offset = "0x1831D0C", VA = "0x1831D0C")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1831DF0", Offset = "0x1831DF0", VA = "0x1831DF0")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1831E60", Offset = "0x1831E60", VA = "0x1831E60")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1831ED4", Offset = "0x1831ED4", VA = "0x1831ED4")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1831F54", Offset = "0x1831F54", VA = "0x1831F54")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x183206C", Offset = "0x183206C", VA = "0x183206C")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x18320EC", Offset = "0x18320EC", VA = "0x18320EC")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1832204", Offset = "0x1832204", VA = "0x1832204")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1832284", Offset = "0x1832284", VA = "0x1832284")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1832304", Offset = "0x1832304", VA = "0x1832304")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1832384", Offset = "0x1832384", VA = "0x1832384")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1832404", Offset = "0x1832404", VA = "0x1832404")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1832494", Offset = "0x1832494", VA = "0x1832494")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1832524", Offset = "0x1832524", VA = "0x1832524")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x18325B4", Offset = "0x18325B4", VA = "0x18325B4")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1832634", Offset = "0x1832634", VA = "0x1832634")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x18326B4", Offset = "0x18326B4", VA = "0x18326B4")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1832744", Offset = "0x1832744", VA = "0x1832744")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x18327D4", Offset = "0x18327D4", VA = "0x18327D4")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1832864", Offset = "0x1832864", VA = "0x1832864")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x18328E4", Offset = "0x18328E4", VA = "0x18328E4")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1832984", Offset = "0x1832984", VA = "0x1832984")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1832A04", Offset = "0x1832A04", VA = "0x1832A04")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1832AA4", Offset = "0x1832AA4", VA = "0x1832AA4")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1832B64", Offset = "0x1832B64", VA = "0x1832B64")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1832C34", Offset = "0x1832C34", VA = "0x1832C34")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1832CC4", Offset = "0x1832CC4", VA = "0x1832CC4")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1832D54", Offset = "0x1832D54", VA = "0x1832D54")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1832DE4", Offset = "0x1832DE4", VA = "0x1832DE4")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1832E74", Offset = "0x1832E74", VA = "0x1832E74")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1832F04", Offset = "0x1832F04", VA = "0x1832F04")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1832F84", Offset = "0x1832F84", VA = "0x1832F84")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x18330A4", Offset = "0x18330A4", VA = "0x18330A4")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1833014", Offset = "0x1833014", VA = "0x1833014")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1833388", Offset = "0x1833388", VA = "0x1833388")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x18334C0", Offset = "0x18334C0", VA = "0x18334C0")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x60001B1")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1833540", Offset = "0x1833540", VA = "0x1833540")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x18337A4", Offset = "0x18337A4", VA = "0x18337A4")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1833824", Offset = "0x1833824", VA = "0x1833824")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x183395C", Offset = "0x183395C", VA = "0x183395C")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x18339DC", Offset = "0x18339DC", VA = "0x18339DC")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1833B14", Offset = "0x1833B14", VA = "0x1833B14")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1833B94", Offset = "0x1833B94", VA = "0x1833B94")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1833CCC", Offset = "0x1833CCC", VA = "0x1833CCC")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1833D4C", Offset = "0x1833D4C", VA = "0x1833D4C")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1833E84", Offset = "0x1833E84", VA = "0x1833E84")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1833F04", Offset = "0x1833F04", VA = "0x1833F04")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1833F84", Offset = "0x1833F84", VA = "0x1833F84")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x183401C", Offset = "0x183401C", VA = "0x183401C")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x183409C", Offset = "0x183409C", VA = "0x183409C")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1834248", Offset = "0x1834248", VA = "0x1834248")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1834374", Offset = "0x1834374", VA = "0x1834374")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x18341C8", Offset = "0x18341C8", VA = "0x18341C8")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x18343F4", Offset = "0x18343F4", VA = "0x18343F4")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1834474", Offset = "0x1834474", VA = "0x1834474")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1834504", Offset = "0x1834504", VA = "0x1834504")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1834584", Offset = "0x1834584", VA = "0x1834584")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1834614", Offset = "0x1834614", VA = "0x1834614")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1834694", Offset = "0x1834694", VA = "0x1834694")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1834714", Offset = "0x1834714", VA = "0x1834714")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1834950", Offset = "0x1834950", VA = "0x1834950")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x18349E0", Offset = "0x18349E0", VA = "0x18349E0")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1834BCC", Offset = "0x1834BCC", VA = "0x1834BCC")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1834C64", Offset = "0x1834C64", VA = "0x1834C64")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1834D88", Offset = "0x1834D88", VA = "0x1834D88")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1834E08", Offset = "0x1834E08", VA = "0x1834E08")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1834E88", Offset = "0x1834E88", VA = "0x1834E88")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1834FB0", Offset = "0x1834FB0", VA = "0x1834FB0")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1835030", Offset = "0x1835030", VA = "0x1835030")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1835158", Offset = "0x1835158", VA = "0x1835158")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x18351D8", Offset = "0x18351D8", VA = "0x18351D8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1835268", Offset = "0x1835268", VA = "0x1835268")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x18352F8", Offset = "0x18352F8", VA = "0x18352F8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1835388", Offset = "0x1835388", VA = "0x1835388")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1835408", Offset = "0x1835408", VA = "0x1835408")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1835490", Offset = "0x1835490", VA = "0x1835490")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1835518", Offset = "0x1835518", VA = "0x1835518")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1835598", Offset = "0x1835598", VA = "0x1835598")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1835618", Offset = "0x1835618", VA = "0x1835618")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x18356CC", Offset = "0x18356CC", VA = "0x18356CC")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x183575C", Offset = "0x183575C", VA = "0x183575C")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x18357EC", Offset = "0x18357EC", VA = "0x18357EC")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x183586C", Offset = "0x183586C", VA = "0x183586C")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x18358EC", Offset = "0x18358EC", VA = "0x18358EC")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x183596C", Offset = "0x183596C", VA = "0x183596C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1835A04", Offset = "0x1835A04", VA = "0x1835A04")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1835A94", Offset = "0x1835A94", VA = "0x1835A94")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1835B24", Offset = "0x1835B24", VA = "0x1835B24")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1835BB4", Offset = "0x1835BB4", VA = "0x1835BB4")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1835C4C", Offset = "0x1835C4C", VA = "0x1835C4C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1835CE4", Offset = "0x1835CE4", VA = "0x1835CE4")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1835D64", Offset = "0x1835D64", VA = "0x1835D64")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1835DE4", Offset = "0x1835DE4", VA = "0x1835DE4")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1835F0C", Offset = "0x1835F0C", VA = "0x1835F0C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1835F8C", Offset = "0x1835F8C", VA = "0x1835F8C")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x18360B4", Offset = "0x18360B4", VA = "0x18360B4")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1836134", Offset = "0x1836134", VA = "0x1836134")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x183625C", Offset = "0x183625C", VA = "0x183625C")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x18362DC", Offset = "0x18362DC", VA = "0x18362DC")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1836484", Offset = "0x1836484", VA = "0x1836484")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1836720", Offset = "0x1836720", VA = "0x1836720")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1836404", Offset = "0x1836404", VA = "0x1836404")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x18367B0", Offset = "0x18367B0", VA = "0x18367B0")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1836830", Offset = "0x1836830", VA = "0x1836830")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x18368C0", Offset = "0x18368C0", VA = "0x18368C0")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1836950", Offset = "0x1836950", VA = "0x1836950")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x18369E0", Offset = "0x18369E0", VA = "0x18369E0")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1836A80", Offset = "0x1836A80", VA = "0x1836A80")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1836B20", Offset = "0x1836B20", VA = "0x1836B20")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1836BC0", Offset = "0x1836BC0", VA = "0x1836BC0")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1836C40", Offset = "0x1836C40", VA = "0x1836C40")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1836CC0", Offset = "0x1836CC0", VA = "0x1836CC0")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1836D40", Offset = "0x1836D40", VA = "0x1836D40")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1836DC0", Offset = "0x1836DC0", VA = "0x1836DC0")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1836E40", Offset = "0x1836E40", VA = "0x1836E40")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1836F68", Offset = "0x1836F68", VA = "0x1836F68")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1837000", Offset = "0x1837000", VA = "0x1837000")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1837080", Offset = "0x1837080", VA = "0x1837080")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x18370E4", Offset = "0x18370E4", VA = "0x18370E4")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1837200", Offset = "0x1837200", VA = "0x1837200")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1837290", Offset = "0x1837290", VA = "0x1837290")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x18373D4", Offset = "0x18373D4", VA = "0x18373D4")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1837464", Offset = "0x1837464", VA = "0x1837464")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1837504", Offset = "0x1837504", VA = "0x1837504")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x183789C", Offset = "0x183789C", VA = "0x183789C")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x183791C", Offset = "0x183791C", VA = "0x183791C")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x18379B4", Offset = "0x18379B4", VA = "0x18379B4")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x183817C", Offset = "0x183817C", VA = "0x183817C")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x18381FC", Offset = "0x18381FC", VA = "0x18381FC")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1831A4C", Offset = "0x1831A4C", VA = "0x1831A4C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xF0C300", Offset = "0xF0C300")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1838294", Offset = "0x1838294", VA = "0x1838294")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1838318", Offset = "0x1838318", VA = "0x1838318")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1838398", Offset = "0x1838398", VA = "0x1838398")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1838418", Offset = "0x1838418", VA = "0x1838418")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1838498", Offset = "0x1838498", VA = "0x1838498")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1838EFC", Offset = "0x1838EFC", VA = "0x1838EFC")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1838F7C", Offset = "0x1838F7C", VA = "0x1838F7C")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x183945C", Offset = "0x183945C", VA = "0x183945C")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x18392F0", Offset = "0x18392F0", VA = "0x18392F0")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x18394D0", Offset = "0x18394D0", VA = "0x18394D0")]
		public CAPI()
		{
		}
	}
}
namespace OVR
{
	[Token(Token = "0x2000072")]
	public class TestScript : MonoBehaviour
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectorNoteAttribute", RVA = "0xF0B4C8", Offset = "0xF0B4C8")]
		public SoundFXRef testSound1;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundFXRef testSound2;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x18316B8", Offset = "0x18316B8", VA = "0x18316B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x18316BC", Offset = "0x18316BC", VA = "0x18316BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x183177C", Offset = "0x183177C", VA = "0x183177C")]
		public TestScript()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class AmbienceEmitter : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFXRef[] ambientSounds;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoActivate;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B514", Offset = "0xF0B514")]
		public bool autoRetrigger;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xF0B54C", Offset = "0xF0B54C")]
		public Vector2 randomRetriggerDelaySecs;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B570", Offset = "0xF0B570")]
		public Transform[] playPositions;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool activated;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int playingIdx;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float fadeTime;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int lastPosIdx;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2161FB8", Offset = "0x2161FB8", VA = "0x2161FB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2162168", Offset = "0x2162168", VA = "0x2162168")]
		private void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2162348", Offset = "0x2162348", VA = "0x2162348")]
		public void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x21621C8", Offset = "0x21621C8", VA = "0x21621C8")]
		public void Play()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x216240C", Offset = "0x216240C", VA = "0x216240C")]
		public void EnableEmitter(bool enable)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2162584", Offset = "0x2162584", VA = "0x2162584")]
		public AmbienceEmitter()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public enum PreloadSounds
	{
		[Token(Token = "0x4000296")]
		Default,
		[Token(Token = "0x4000297")]
		Preload,
		[Token(Token = "0x4000298")]
		ManualPreload
	}
	[Token(Token = "0x2000075")]
	public enum Fade
	{
		[Token(Token = "0x400029A")]
		In,
		[Token(Token = "0x400029B")]
		Out
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class SoundGroup
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFX[] soundList;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0B5A8", Offset = "0xF0B5A8")]
		public int maxPlayingSounds;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PreloadSounds preloadAudio;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float volumeOverride;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public int playingSoundCount;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1831548", Offset = "0x1831548", VA = "0x1831548")]
		public SoundGroup(string name)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x18315FC", Offset = "0x18315FC", VA = "0x18315FC")]
		public SoundGroup()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x182F098", Offset = "0x182F098", VA = "0x182F098")]
		public void IncrementPlayCount()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x182F434", Offset = "0x182F434", VA = "0x182F434")]
		public void DecrementPlayCount()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1830AB4", Offset = "0x1830AB4", VA = "0x1830AB4")]
		public bool CanPlaySound()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000077")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		public enum Fade
		{
			[Token(Token = "0x40003D0")]
			In,
			[Token(Token = "0x40003D1")]
			Out
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B098", Offset = "0xF0B098")]
		private sealed class <>c__DisplayClass77_0
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoundPriority priority;

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x182EAA0", Offset = "0x182EAA0", VA = "0x182EAA0")]
			public <>c__DisplayClass77_0()
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x182EAA8", Offset = "0x182EAA8", VA = "0x182EAA8")]
			internal bool <FindFreeEmitter>b__0(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B0A8", Offset = "0xF0B0A8")]
		private sealed class <>c
		{
			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<SoundEmitter> <>9__77_1;

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x182EA08", Offset = "0x182EA08", VA = "0x182EA08")]
			public <>c()
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x182EA10", Offset = "0x182EA10", VA = "0x182EA10")]
			internal bool <FindFreeEmitter>b__77_1(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B5D4", Offset = "0xF0B5D4")]
		public bool makePersistent;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B60C", Offset = "0xF0B60C")]
		public bool enableSpatializedAudio;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B644", Offset = "0xF0B644")]
		public bool enableSpatializedFastOverride;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B67C", Offset = "0xF0B67C")]
		public AudioMixer audioMixer;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B6B4", Offset = "0xF0B6B4")]
		public AudioMixerGroup defaultMixerGroup;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B6EC", Offset = "0xF0B6EC")]
		public AudioMixerGroup reservedMixerGroup;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B724", Offset = "0xF0B724")]
		public AudioMixerGroup voiceChatMixerGroup;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B75C", Offset = "0xF0B75C")]
		public bool verboseLogging;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B794", Offset = "0xF0B794")]
		public int maxSoundEmitters;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B7CC", Offset = "0xF0B7CC")]
		public float volumeSoundFX;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B804", Offset = "0xF0B804")]
		public float soundFxFadeSecs;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float audioMinFallOffDistance;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float audioMaxFallOffDistance;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SoundGroup[] soundGroupings;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, SoundFX> soundFXCache;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager theAudioManager;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FastList<string> names;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] defaultSound;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SoundFX nullSound;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool hideWarnings;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float audioMaxFallOffDistanceSqr;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SoundEmitter[] soundEmitters;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FastList<SoundEmitter> playingEmitters;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FastList<SoundEmitter> nextFreeEmitters;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MixerSnapshot currentSnapshot;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject soundEmitterParent;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform staticListenerPosition;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool showPlayingEmitterCount;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private static bool forceShowEmitterCount;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool soundEnabled;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly AnimationCurve defaultReverbZoneMix;

		[Token(Token = "0x17000016")]
		public static bool enableSpatialization
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x216265C", Offset = "0x216265C", VA = "0x216265C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public static AudioManager Instance
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x216273C", Offset = "0x216273C", VA = "0x216273C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static float NearFallOff
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x21627A4", Offset = "0x21627A4", VA = "0x21627A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		public static float FarFallOff
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2162818", Offset = "0x2162818", VA = "0x2162818")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		public static AudioMixerGroup EmitterGroup
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x216288C", Offset = "0x216288C", VA = "0x216288C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public static AudioMixerGroup ReservedGroup
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2162900", Offset = "0x2162900", VA = "0x2162900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public static AudioMixerGroup VoipGroup
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2162974", Offset = "0x2162974", VA = "0x2162974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static bool SoundEnabled
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2164830", Offset = "0x2164830", VA = "0x2164830")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x21629E8", Offset = "0x21629E8", VA = "0x21629E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2162C1C", Offset = "0x2162C1C", VA = "0x2162C1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x21629EC", Offset = "0x21629EC", VA = "0x21629EC")]
		private void Init()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x216394C", Offset = "0x216394C", VA = "0x216394C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2162D74", Offset = "0x2162D74", VA = "0x2162D74")]
		private void RebuildSoundFXCache()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2163FCC", Offset = "0x2163FCC", VA = "0x2163FCC")]
		public static SoundFX FindSoundFX(string name, bool rebuildCache = false)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x216414C", Offset = "0x216414C", VA = "0x216414C")]
		private static bool FindAudioManager()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x21642E8", Offset = "0x21642E8", VA = "0x21642E8")]
		public static GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x21643E8", Offset = "0x21643E8", VA = "0x21643E8")]
		public static string NameMinusGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2164478", Offset = "0x2164478", VA = "0x2164478")]
		public static string[] GetSoundFXNames(string currentValue, out int currentIdx)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2164898", Offset = "0x2164898", VA = "0x2164898")]
		private static int CalculateMaxEmittersSize()
		{
			return default(int);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2164910", Offset = "0x2164910", VA = "0x2164910")]
		private static bool ValidateEmitterIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2163228", Offset = "0x2163228", VA = "0x2163228")]
		private void InitializeSoundSystem()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2163950", Offset = "0x2163950", VA = "0x2163950")]
		private void UpdateFreeEmitters()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2164A54", Offset = "0x2164A54", VA = "0x2164A54")]
		private string Fmt(int count)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2164B58", Offset = "0x2164B58", VA = "0x2164B58")]
		private string FmtFree(int count)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2164C60", Offset = "0x2164C60", VA = "0x2164C60")]
		private void OnPreSceneLoad()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2164988", Offset = "0x2164988", VA = "0x2164988")]
		private void ResetFreeEmitters()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2164D94", Offset = "0x2164D94", VA = "0x2164D94")]
		public static void FadeOutSoundChannel(int channel, float delaySecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2164E50", Offset = "0x2164E50", VA = "0x2164E50")]
		public static bool StopSound(int idx, bool fadeOut = true, bool stopReserved = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2164F70", Offset = "0x2164F70", VA = "0x2164F70")]
		public static void FadeInSound(int idx, float fadeTime, float volume)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2162358", Offset = "0x2162358", VA = "0x2162358")]
		public static void FadeInSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x21624D0", Offset = "0x21624D0", VA = "0x21624D0")]
		public static void FadeOutSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x216502C", Offset = "0x216502C", VA = "0x216502C")]
		public static void StopAllSounds(bool fadeOut, bool stopReserved = false)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x21650F8", Offset = "0x21650F8", VA = "0x21650F8")]
		public void MuteAllSounds(bool mute, bool muteReserved = false)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x216518C", Offset = "0x216518C", VA = "0x216518C")]
		public void UnMuteAllSounds(bool unmute, bool unmuteReserved = false)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2165250", Offset = "0x2165250", VA = "0x2165250")]
		public static float GetEmitterEndTime(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x21652F4", Offset = "0x21652F4", VA = "0x21652F4")]
		public static float SetEmitterTime(int idx, float time)
		{
			return default(float);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x21653B0", Offset = "0x21653B0", VA = "0x21653B0")]
		public static int PlaySound(AudioClip clip, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitchVariance = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2165F48", Offset = "0x2165F48", VA = "0x2165F48")]
		private static int FindFreeEmitter(EmitterChannel src, SoundPriority priority)
		{
			return default(int);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2166644", Offset = "0x2166644", VA = "0x2166644")]
		public static int PlaySound(SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2166824", Offset = "0x2166824", VA = "0x2166824")]
		public static int PlaySoundAt(Vector3 position, SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2167408", Offset = "0x2167408", VA = "0x2167408")]
		public static int PlayRandomSoundAt(Vector3 position, AudioClip[] clips, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x21655B8", Offset = "0x21655B8", VA = "0x21655B8")]
		public static int PlaySoundAt(Vector3 position, AudioClip clip, float volume = 1f, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2167528", Offset = "0x2167528", VA = "0x2167528")]
		public static void SetOnFinished(int emitterIdx, Action onFinished)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2167610", Offset = "0x2167610", VA = "0x2167610")]
		public static void SetOnFinished(int emitterIdx, Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2167700", Offset = "0x2167700", VA = "0x2167700")]
		public static void AttachSoundToParent(int idx, Transform parent)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x21679F8", Offset = "0x21679F8", VA = "0x21679F8")]
		public static void DetachSoundFromParent(int idx)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2167B40", Offset = "0x2167B40", VA = "0x2167B40")]
		public static void DetachSoundsFromParent(SoundEmitter[] emitters, bool stopSounds = true)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2167C68", Offset = "0x2167C68", VA = "0x2167C68")]
		public static void SetEmitterMixerGroup(int idx, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2167D8C", Offset = "0x2167D8C", VA = "0x2167D8C")]
		public static MixerSnapshot GetActiveSnapshot()
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2167E64", Offset = "0x2167E64", VA = "0x2167E64")]
		public static void SetCurrentSnapshot(MixerSnapshot mixerSnapshot)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2167FAC", Offset = "0x2167FAC", VA = "0x2167FAC")]
		public static void BlendWithCurrentSnapshot(MixerSnapshot blendSnapshot, float weight, float blendTime = 0f)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x21683B0", Offset = "0x21683B0", VA = "0x21683B0")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public enum EmitterChannel
	{
		[Token(Token = "0x40002C3")]
		None = -1,
		[Token(Token = "0x40002C4")]
		Reserved,
		[Token(Token = "0x40002C5")]
		Any
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class MixerSnapshot
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixerSnapshot snapshot;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float transitionTime;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x182EBA4", Offset = "0x182EBA4", VA = "0x182EBA4")]
		public MixerSnapshot()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minDefaultVal;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxDefaultVal;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x182EB48", Offset = "0x182EB48", VA = "0x182EB48")]
		public MinMaxAttribute(float minDefaultVal, float maxDefaultVal, float min, float max)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class SoundEmitter : MonoBehaviour
	{
		[Token(Token = "0x20000AD")]
		public enum FadeState
		{
			[Token(Token = "0x40003D6")]
			Null,
			[Token(Token = "0x40003D7")]
			FadingIn,
			[Token(Token = "0x40003D8")]
			FadingOut,
			[Token(Token = "0x40003D9")]
			Ducking
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B0B8", Offset = "0xF0B0B8")]
		private sealed class <DelayedSyncTo>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundEmitter other;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float fadeTime;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float toVolume;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x182FD84", Offset = "0x182FD84", VA = "0x182FD84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x182FDEC", Offset = "0x182FDEC", VA = "0x182FDEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x182F818", Offset = "0x182F818", VA = "0x182F818")]
			[DebuggerHidden]
			public <DelayedSyncTo>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x182FC88", Offset = "0x182FC88", VA = "0x182FC88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x182FC8C", Offset = "0x182FC8C", VA = "0x182FC8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x182FD8C", Offset = "0x182FD8C", VA = "0x182FD8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B0C8", Offset = "0xF0B0C8")]
		private sealed class <FadeSoundChannelTo>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toVolume;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeTime;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <start>5__2;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <end>5__3;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__5;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x183025C", Offset = "0x183025C", VA = "0x183025C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x18302C4", Offset = "0x18302C4", VA = "0x18302C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x182FC18", Offset = "0x182FC18", VA = "0x182FC18")]
			[DebuggerHidden]
			public <FadeSoundChannelTo>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x18300E4", Offset = "0x18300E4", VA = "0x18300E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x18300E8", Offset = "0x18300E8", VA = "0x18300E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1830264", Offset = "0x1830264", VA = "0x1830264", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0B0D8", Offset = "0xF0B0D8")]
		private sealed class <FadeSoundChannel>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySecs;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Fade fadeType;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float defaultVolume;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float fadeTime;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <start>5__2;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <end>5__3;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <restartPlay>5__4;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <startTime>5__5;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsedTime>5__6;

			[Token(Token = "0x17000040")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x1830074", Offset = "0x1830074", VA = "0x1830074", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x18300DC", Offset = "0x18300DC", VA = "0x18300DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x182FC44", Offset = "0x182FC44", VA = "0x182FC44")]
			[DebuggerHidden]
			public <FadeSoundChannel>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x182FDF4", Offset = "0x182FDF4", VA = "0x182FDF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x182FDF8", Offset = "0x182FDF8", VA = "0x182FDF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x183007C", Offset = "0x183007C", VA = "0x183007C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmitterChannel channel;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSpatialization;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeState state;

		[NonSerialized]
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource;

		[NonSerialized]
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundPriority priority;

		[NonSerialized]
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ONSPAudioSource osp;

		[NonSerialized]
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float endPlayTime;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lastParentTransform;

		[NonSerialized]
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float defaultVolume;

		[NonSerialized]
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Transform defaultParent;

		[NonSerialized]
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int originalIdx;

		[NonSerialized]
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action onFinished;

		[NonSerialized]
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Action<object> onFinishedObject;

		[NonSerialized]
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public object onFinishedParam;

		[NonSerialized]
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public SoundGroup playingSoundGroup;

		[Token(Token = "0x1700001E")]
		public float volume
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x182EC44", Offset = "0x182EC44", VA = "0x182EC44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x182EC60", Offset = "0x182EC60", VA = "0x182EC60")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float pitch
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x182EC7C", Offset = "0x182EC7C", VA = "0x182EC7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x182EC98", Offset = "0x182EC98", VA = "0x182EC98")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public AudioClip clip
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x182ECB4", Offset = "0x182ECB4", VA = "0x182ECB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x182ECD0", Offset = "0x182ECD0", VA = "0x182ECD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float time
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x182ECEC", Offset = "0x182ECEC", VA = "0x182ECEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x182ED08", Offset = "0x182ED08", VA = "0x182ED08")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float length
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x182ED24", Offset = "0x182ED24", VA = "0x182ED24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		public bool loop
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x182EDDC", Offset = "0x182EDDC", VA = "0x182EDDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x182EDF8", Offset = "0x182EDF8", VA = "0x182EDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool mute
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x182EE18", Offset = "0x182EE18", VA = "0x182EE18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x182EE34", Offset = "0x182EE34", VA = "0x182EE34")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x182EE54", Offset = "0x182EE54", VA = "0x182EE54")]
			get
			{
				return default(AudioVelocityUpdateMode);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x182EE70", Offset = "0x182EE70", VA = "0x182EE70")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool isPlaying
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x182EE8C", Offset = "0x182EE8C", VA = "0x182EE8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x182EEA8", Offset = "0x182EEA8", VA = "0x182EEA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x182F060", Offset = "0x182F060", VA = "0x182F060")]
		public void SetPlayingSoundGroup(SoundGroup soundGroup)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x182F128", Offset = "0x182F128", VA = "0x182F128")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x182F130", Offset = "0x182F130", VA = "0x182F130")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x182F164", Offset = "0x182F164", VA = "0x182F164")]
		public void SetChannel(int _channel)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x182F16C", Offset = "0x182F16C", VA = "0x182F16C")]
		public void SetDefaultParent(Transform parent)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x182F174", Offset = "0x182F174", VA = "0x182F174")]
		public void SetAudioMixer(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x182F21C", Offset = "0x182F21C", VA = "0x182F21C")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x182F288", Offset = "0x182F288", VA = "0x182F288")]
		public void Play()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x182F2E8", Offset = "0x182F2E8", VA = "0x182F2E8")]
		public void Pause()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x182F320", Offset = "0x182F320", VA = "0x182F320")]
		public void Stop()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x182F4C4", Offset = "0x182F4C4", VA = "0x182F4C4")]
		private int GetSampleTime()
		{
			return default(int);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x182F51C", Offset = "0x182F51C", VA = "0x182F51C")]
		public void ParentTo(Transform parent)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x182F628", Offset = "0x182F628", VA = "0x182F628")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x182F6F8", Offset = "0x182F6F8", VA = "0x182F6F8")]
		public void ResetParent(Transform parent)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x182F740", Offset = "0x182F740", VA = "0x182F740")]
		public void SyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x182F76C", Offset = "0x182F76C", VA = "0x182F76C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0C364", Offset = "0xF0C364")]
		private IEnumerator DelayedSyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x182F844", Offset = "0x182F844", VA = "0x182F844")]
		public void FadeTo(float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x182F93C", Offset = "0x182F93C", VA = "0x182F93C")]
		public void FadeIn(float fadeTime, float defaultVolume)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x182FA6C", Offset = "0x182FA6C", VA = "0x182FA6C")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x182FAE4", Offset = "0x182FAE4", VA = "0x182FAE4")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x182FB7C", Offset = "0x182FB7C", VA = "0x182FB7C")]
		public void FadeOutDelayed(float delayedSecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x182F8AC", Offset = "0x182F8AC", VA = "0x182F8AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0C3C8", Offset = "0xF0C3C8")]
		private IEnumerator FadeSoundChannelTo(float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x182F9B8", Offset = "0x182F9B8", VA = "0x182F9B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF0C42C", Offset = "0xF0C42C")]
		private IEnumerator FadeSoundChannel(float delaySecs, float fadeTime, Fade fadeType, float defaultVolume)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x182FC70", Offset = "0x182FC70", VA = "0x182FC70")]
		public SoundEmitter()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public enum SoundFXNext
	{
		[Token(Token = "0x40002DC")]
		Random,
		[Token(Token = "0x40002DD")]
		Sequential
	}
	[Token(Token = "0x200007D")]
	public enum FreqHint
	{
		[Token(Token = "0x40002DF")]
		None,
		[Token(Token = "0x40002E0")]
		Wide,
		[Token(Token = "0x40002E1")]
		Narrow
	}
	[Token(Token = "0x200007E")]
	public enum SoundPriority
	{
		[Token(Token = "0x40002E3")]
		VeryLow = -2,
		[Token(Token = "0x40002E4")]
		Low,
		[Token(Token = "0x40002E5")]
		Default,
		[Token(Token = "0x40002E6")]
		High,
		[Token(Token = "0x40002E7")]
		VeryHigh
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class OSPProps
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B8EC", Offset = "0xF0B8EC")]
		public bool enableSpatialization;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B924", Offset = "0xF0B924")]
		public bool useFastOverride;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B95C", Offset = "0xF0B95C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0B95C", Offset = "0xF0B95C")]
		public float gain;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B9B0", Offset = "0xF0B9B0")]
		public bool enableInvSquare;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0B9E8", Offset = "0xF0B9E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0B9E8", Offset = "0xF0B9E8")]
		public float volumetric;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BA40", Offset = "0xF0BA40")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xF0BA40", Offset = "0xF0BA40")]
		public Vector2 invSquareFalloff;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x182EBB4", Offset = "0x182EBB4", VA = "0x182EBB4")]
		public OSPProps()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class SoundFX
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BAA0", Offset = "0xF0BAA0")]
		public string name;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BAD8", Offset = "0xF0BAD8")]
		public SoundFXNext playback;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BB10", Offset = "0xF0BB10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0BB10", Offset = "0xF0BB10")]
		public float volume;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BB64", Offset = "0xF0BB64")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xF0BB64", Offset = "0xF0BB64")]
		public Vector2 pitchVariance;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BBC0", Offset = "0xF0BBC0")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xF0BBC0", Offset = "0xF0BBC0")]
		public Vector2 falloffDistance;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BC20", Offset = "0xF0BC20")]
		public AudioRolloffMode falloffCurve;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BC58", Offset = "0xF0BC58")]
		public AnimationCurve volumeFalloffCurve;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BC90", Offset = "0xF0BC90")]
		public AnimationCurve reverbZoneMix;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BCC8", Offset = "0xF0BCC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0BCC8", Offset = "0xF0BCC8")]
		public float spread;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BD20", Offset = "0xF0BD20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF0BD20", Offset = "0xF0BD20")]
		public float pctChanceToPlay;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BD74", Offset = "0xF0BD74")]
		public SoundPriority priority;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BDAC", Offset = "0xF0BDAC")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xF0BDAC", Offset = "0xF0BDAC")]
		public Vector2 delay;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BE08", Offset = "0xF0BE08")]
		public bool looping;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OSPProps ospProps;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF0BE40", Offset = "0xF0BE40")]
		public AudioClip[] soundClips;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool visibilityToggle;

		[NonSerialized]
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SoundGroup soundGroup;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int lastIdx;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int playingIdx;

		[Token(Token = "0x17000027")]
		public int Length
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1830828", Offset = "0x1830828", VA = "0x1830828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public bool IsValid
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1830844", Offset = "0x1830844", VA = "0x1830844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public SoundGroup Group
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x18308E8", Offset = "0x18308E8", VA = "0x18308E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x18308F0", Offset = "0x18308F0", VA = "0x18308F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float MaxFalloffDistSquared
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x18308F8", Offset = "0x18308F8", VA = "0x18308F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float GroupVolumeOverride
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1830904", Offset = "0x1830904", VA = "0x1830904")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x18302CC", Offset = "0x18302CC", VA = "0x18302CC")]
		public SoundFX()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x183091C", Offset = "0x183091C", VA = "0x183091C")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x18309EC", Offset = "0x18309EC", VA = "0x18309EC")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroup defaultMixerGroup)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1830A8C", Offset = "0x1830A8C", VA = "0x1830A8C")]
		public bool ReachedGroupPlayLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1830AD4", Offset = "0x1830AD4", VA = "0x1830AD4")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1830BD0", Offset = "0x1830BD0", VA = "0x1830BD0")]
		public float GetPitch()
		{
			return default(float);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1830BDC", Offset = "0x1830BDC", VA = "0x1830BDC")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1830CBC", Offset = "0x1830CBC", VA = "0x1830CBC")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1830DD4", Offset = "0x1830DD4", VA = "0x1830DD4")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1830E64", Offset = "0x1830E64", VA = "0x1830E64")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1830EFC", Offset = "0x1830EFC", VA = "0x1830EFC")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1830F8C", Offset = "0x1830F8C", VA = "0x1830F8C")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x183101C", Offset = "0x183101C", VA = "0x183101C")]
		public void DetachFromParent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class SoundFXRef
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundFXName;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SoundFX soundFXCached;

		[Token(Token = "0x1700002C")]
		public SoundFX soundFX
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1831098", Offset = "0x1831098", VA = "0x1831098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public string name
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x18311B4", Offset = "0x18311B4", VA = "0x18311B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x18311BC", Offset = "0x18311BC", VA = "0x18311BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int Length
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x18311E4", Offset = "0x18311E4", VA = "0x18311E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool IsValid
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1831228", Offset = "0x1831228", VA = "0x1831228")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x18310C8", Offset = "0x18310C8", VA = "0x18310C8")]
		private void Init()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1831260", Offset = "0x1831260", VA = "0x1831260")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1831298", Offset = "0x1831298", VA = "0x1831298")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x18312D8", Offset = "0x18312D8", VA = "0x18312D8")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1831320", Offset = "0x1831320", VA = "0x1831320")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volume = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x18313A0", Offset = "0x18313A0", VA = "0x18313A0")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x18313E0", Offset = "0x18313E0", VA = "0x18313E0")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1831430", Offset = "0x1831430", VA = "0x1831430")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1831468", Offset = "0x1831468", VA = "0x1831468")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x18314A8", Offset = "0x18314A8", VA = "0x18314A8")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x18314E0", Offset = "0x18314E0", VA = "0x18314E0")]
		public SoundFXRef()
		{
		}
	}
}
namespace Game.Assets._3DAssets.OutlineParticles
{
	[Token(Token = "0x2000082")]
	public class UsePointTopologyMeshMode : MonoBehaviour
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2151104", Offset = "0x2151104", VA = "0x2151104")]
		private void Start()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2151108", Offset = "0x2151108", VA = "0x2151108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xF0C490", Offset = "0xF0C490")]
		private void ConvertToPointTopology()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x21511F0", Offset = "0x21511F0", VA = "0x21511F0")]
		public UsePointTopologyMeshMode()
		{
		}
	}
}
