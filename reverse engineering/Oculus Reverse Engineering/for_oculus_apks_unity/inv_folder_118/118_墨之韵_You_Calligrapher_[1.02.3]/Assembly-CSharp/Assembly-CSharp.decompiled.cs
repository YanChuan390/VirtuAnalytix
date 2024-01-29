using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;
using Game.UI;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Android;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AndroidSignSettings : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string passwordFilePath;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7B5BA8", Offset = "0x7B5BA8", VA = "0x7B5BA8")]
	public AndroidSignSettings()
	{
	}
}
[Token(Token = "0x2000003")]
public class AchievementUtilsTest : MonoBehaviour
{
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7AEEA8", Offset = "0x7AEEA8", VA = "0x7AEEA8")]
	public AchievementUtilsTest()
	{
	}
}
[Token(Token = "0x2000004")]
public class AchievementUtils_Oculus : AchievementRemoteAPI
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFB68", Offset = "0x5FFB68")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<ICollection<AchievementData>> action;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isDone;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7D72D8", Offset = "0x7D72D8", VA = "0x7D72D8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7D72E0", Offset = "0x7D72E0", VA = "0x7D72E0")]
		internal void <GetAchievemets0>b__0(Message<AchievementProgressList> list)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7D7720", Offset = "0x7D7720", VA = "0x7D7720")]
		internal bool <GetAchievemets0>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFB78", Offset = "0x5FFB78")]
	private sealed class <GetAchievemets0>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<ICollection<AchievementData>> action;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x7D7924", Offset = "0x7D7924", VA = "0x7D7924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x7D796C", Offset = "0x7D796C", VA = "0x7D796C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7D7728", Offset = "0x7D7728", VA = "0x7D7728")]
		[DebuggerHidden]
		public <GetAchievemets0>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7D7754", Offset = "0x7D7754", VA = "0x7D7754", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7D7758", Offset = "0x7D7758", VA = "0x7D7758", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x7D792C", Offset = "0x7D792C", VA = "0x7D792C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x17000001")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x7AEEB0", Offset = "0x7AEEB0", VA = "0x7AEEB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7AEEB8", Offset = "0x7AEEB8", VA = "0x7AEEB8", Slot = "7")]
	public override Coroutine GetAchievemets(Action<ICollection<AchievementData>> action)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7AEF58", Offset = "0x7AEF58", VA = "0x7AEF58", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7AEEE4", Offset = "0x7AEEE4", VA = "0x7AEEE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6056CC", Offset = "0x6056CC")]
	private IEnumerator GetAchievemets0(Action<ICollection<AchievementData>> action)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7AF108", Offset = "0x7AF108", VA = "0x7AF108", Slot = "8")]
	public override void SetAchievementCompelete(string id)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7AF114", Offset = "0x7AF114", VA = "0x7AF114")]
	public AchievementUtils_Oculus()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x5FFB88", Offset = "0x5FFB88")]
public class OculusApp : ScriptableObject
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _AppCredentials;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _AppId;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _AppSecret;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OculusApp mInstance;

	[Token(Token = "0x17000004")]
	public static string appCredentials
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12BF00C", Offset = "0x12BF00C", VA = "0x12BF00C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public static string appId
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x12BF10C", Offset = "0x12BF10C", VA = "0x12BF10C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public static string appSecret
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x12BF12C", Offset = "0x12BF12C", VA = "0x12BF12C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	private static OculusApp instance
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12BF02C", Offset = "0x12BF02C", VA = "0x12BF02C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12BF14C", Offset = "0x12BF14C", VA = "0x12BF14C")]
	public OculusApp()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x5FFBD4", Offset = "0x5FFBD4")]
public class OculusManager : SingletonGameObject<OculusManager>
{
	[Serializable]
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFC08", Offset = "0x5FFC08")]
	private sealed class <>c
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Message.Callback <>9__3_0;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Message<User>.Callback <>9__3_1;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action <>9__4_0;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x12DAB60", Offset = "0x12DAB60", VA = "0x12DAB60")]
		public <>c()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12DAB68", Offset = "0x12DAB68", VA = "0x12DAB68")]
		internal void <OnInit>b__3_0(Message c)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12DACBC", Offset = "0x12DACBC", VA = "0x12DACBC")]
		internal void <OnInit>b__3_1(Message<User> callback)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x12DAE88", Offset = "0x12DAE88", VA = "0x12DAE88")]
		internal void <OnAfterSceneLoad>b__4_0()
		{
		}
	}

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool mSuccess;

	[Token(Token = "0x17000008")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x12BF154", Offset = "0x12BF154", VA = "0x12BF154", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12BF15C", Offset = "0x12BF15C", VA = "0x12BF15C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x605784", Offset = "0x605784")]
	private static void OnInit()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x12BF54C", Offset = "0x12BF54C", VA = "0x12BF54C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x605798", Offset = "0x605798")]
	private static void OnAfterSceneLoad()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12BF748", Offset = "0x12BF748", VA = "0x12BF748")]
	public OculusManager()
	{
	}
}
[Token(Token = "0x200000A")]
public class LogoCanvas : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScenesLoader _scenesLoader;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _distance;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _smooth;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _maxSpeed;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _maxAngle;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 currentVelocity;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool mRun;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8B7688", Offset = "0x8B7688", VA = "0x8B7688")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8B79B8", Offset = "0x8B79B8", VA = "0x8B79B8")]
	public LogoCanvas()
	{
	}
}
[Token(Token = "0x200000B")]
public class LogoFollower : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _distance;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _smooth;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _maxSpeed;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _maxAngle;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 currentVelocity;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool mRun;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8B79CC", Offset = "0x8B79CC", VA = "0x8B79CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8B7B90", Offset = "0x8B7B90", VA = "0x8B7B90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8B7EC0", Offset = "0x8B7EC0", VA = "0x8B7EC0")]
	public LogoFollower()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
public class BackgroundBlendLayer : IPaintingBlendLayer, PaintingCanvasLayer, IBackgroundBlendLayer
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Texture _BackgroundTexture;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color _BackgroundColor;

	[Token(Token = "0x17000009")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x7B63C8", Offset = "0x7B63C8", VA = "0x7B63C8", Slot = "5")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x1700000A")]
	public Texture backgroundTexture
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x7B63D0", Offset = "0x7B63D0", VA = "0x7B63D0", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x7B63D8", Offset = "0x7B63D8", VA = "0x7B63D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Color backgroundColor
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7B63E0", Offset = "0x7B63E0", VA = "0x7B63E0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7B63EC", Offset = "0x7B63EC", VA = "0x7B63EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Texture preview
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x7B63F8", Offset = "0x7B63F8", VA = "0x7B63F8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7B6400", Offset = "0x7B6400", VA = "0x7B6400", Slot = "6")]
	public void ClearContent()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7B6404", Offset = "0x7B6404", VA = "0x7B6404", Slot = "4")]
	public void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7B6514", Offset = "0x7B6514", VA = "0x7B6514")]
	public BackgroundBlendLayer()
	{
	}
}
[Token(Token = "0x200000D")]
public static class MaterialsUtils
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8B81CC", Offset = "0x8B81CC", VA = "0x8B81CC")]
	public static void SyncMaterial(Material old, Material source)
	{
	}
}
[Token(Token = "0x200000E")]
public class Painter : MonoBehaviour, IPaintingBlendLayer, PaintingCanvasLayer
{
	[Token(Token = "0x200000F")]
	public class SingleChannelBlendHistoryBuffer : PaintingHistoryManager.HistoryBuffer, IDisposable
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material mMaterial;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderTexture mRenderTexture;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color mColor;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string mName;

		[Token(Token = "0x1700000F")]
		public Texture previewTexture
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x12DB654", Offset = "0x12DB654", VA = "0x12DB654", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public string name
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x12DB65C", Offset = "0x12DB65C", VA = "0x12DB65C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x12DB28C", Offset = "0x12DB28C", VA = "0x12DB28C")]
		public SingleChannelBlendHistoryBuffer(string name, Color color, Material layerMergeMaterial, RenderTexture source, bool copyingRenderTexture = true)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x12DB42C", Offset = "0x12DB42C", VA = "0x12DB42C", Slot = "4")]
		public void LayerMerge(Texture baseTexture, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x12DB5D8", Offset = "0x12DB5D8", VA = "0x12DB5D8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x12DB664", Offset = "0x12DB664", VA = "0x12DB664", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000010")]
	public class RBGABlendHistoryBuffer : PaintingHistoryManager.HistoryBuffer, IDisposable
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material mMaterial;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderTexture mRenderTexture;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string mName;

		[Token(Token = "0x17000011")]
		public Texture previewTexture
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x12DB274", Offset = "0x12DB274", VA = "0x12DB274", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string name
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x12DB27C", Offset = "0x12DB27C", VA = "0x12DB27C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x12DAF04", Offset = "0x12DAF04", VA = "0x12DAF04")]
		public RBGABlendHistoryBuffer(string name, Material layerMergeMaterial, RenderTexture source, bool copyingRenderTexture = true)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x12DB04C", Offset = "0x12DB04C", VA = "0x12DB04C", Slot = "4")]
		public void LayerMerge(Texture baseTexture, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x12DB1F8", Offset = "0x12DB1F8", VA = "0x12DB1F8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x12DB284", Offset = "0x12DB284", VA = "0x12DB284", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000011")]
	protected struct PainterMaterials
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material layerMergeMaterial;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Material layerBlendMaterial;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material paintingMaterial;
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected RenderTextureFormat _RenderTextureFormat;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected PainterMaterials _RRBAFormatMaterials;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected PainterMaterials _RFormatMaterials;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected bool _OverrideMSAALevel;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x602438", Offset = "0x602438")]
	protected int _MSAALevel;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Color _Color;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected RenderTexture mRenderTexture;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Material mCopyingBlendMaterial;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Material mCopyingPaintingMaterial;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool mPreventInitRenderTextureCycle;

	[Token(Token = "0x1700000D")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x12BFD04", Offset = "0x12BFD04", VA = "0x12BFD04", Slot = "5")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x1700000E")]
	public Texture preview
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12BFD0C", Offset = "0x12BFD0C", VA = "0x12BFD0C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x12BFD14", Offset = "0x12BFD14", VA = "0x12BFD14", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x12BFE24", Offset = "0x12BFE24", VA = "0x12BFE24", Slot = "9")]
	protected virtual PaintingHistoryManager.HistoryBuffer CreateHistoryBuffer(string name, Color color, bool copyingRenderTexture = true)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12BFF64", Offset = "0x12BFF64", VA = "0x12BFF64")]
	protected static bool IsSingleChannelTextureFormat(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x12BFF8C", Offset = "0x12BFF8C", VA = "0x12BFF8C", Slot = "10")]
	protected virtual void InitRenderTexture(PaintingCanvas canvas)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x12C06F8", Offset = "0x12C06F8", VA = "0x12C06F8", Slot = "11")]
	protected virtual void InitMaterials()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x12C086C", Offset = "0x12C086C", VA = "0x12C086C", Slot = "12")]
	public virtual void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x12C0A48", Offset = "0x12C0A48", VA = "0x12C0A48", Slot = "13")]
	public virtual void ClearContent()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12C0B8C", Offset = "0x12C0B8C", VA = "0x12C0B8C")]
	public Painter()
	{
	}
}
[Token(Token = "0x2000012")]
public abstract class PaintingCanvas : IDisposable, IEnumerable<PaintingCanvasLayer>, IEnumerable
{
	[Token(Token = "0x2000013")]
	private class PaintingCanvasLayerSorter : IComparer<PaintingCanvasLayer>
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x12DB66C", Offset = "0x12DB66C", VA = "0x12DB66C", Slot = "4")]
		public int Compare(PaintingCanvasLayer x, PaintingCanvasLayer y)
		{
			return default(int);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x12DB7E0", Offset = "0x12DB7E0", VA = "0x12DB7E0")]
		public PaintingCanvasLayerSorter()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<PaintingCanvasLayer> mBlendLayers;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PaintingCanvasLayerSorter mCanvasLayerSorter;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool mIsDirty;

	[Token(Token = "0x17000013")]
	public abstract RenderTexture renderTexture
	{
		[Token(Token = "0x6000045")]
		get;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12C0BC0", Offset = "0x12C0BC0", VA = "0x12C0BC0", Slot = "8")]
	public virtual void AddBlendLayer(IPaintingBlendLayer blendLayer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12C0C24", Offset = "0x12C0C24", VA = "0x12C0C24", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x12C0C28", Offset = "0x12C0C28", VA = "0x12C0C28", Slot = "5")]
	public IEnumerator<PaintingCanvasLayer> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x12C0CCC", Offset = "0x12C0CCC", VA = "0x12C0CCC", Slot = "10")]
	public virtual void Invalidate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12C0CD8", Offset = "0x12C0CD8", VA = "0x12C0CD8", Slot = "11")]
	public virtual void RemoveBlendLayer(IPaintingBlendLayer blendLayer)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12C0D3C", Offset = "0x12C0D3C", VA = "0x12C0D3C", Slot = "12")]
	public virtual bool UpdateTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x12C12BC", Offset = "0x12C12BC", VA = "0x12C12BC", Slot = "6")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x12C1360", Offset = "0x12C1360", VA = "0x12C1360")]
	protected PaintingCanvas()
	{
	}
}
[Token(Token = "0x2000014")]
public interface PaintingCanvasLayer
{
	[Token(Token = "0x17000014")]
	CanvasLayerOrder order
	{
		[Token(Token = "0x6000050")]
		get;
	}

	[Token(Token = "0x17000015")]
	Texture preview
	{
		[Token(Token = "0x6000052")]
		get;
	}

	[Token(Token = "0x6000051")]
	void ClearContent();
}
[Token(Token = "0x2000015")]
public enum CanvasLayerOrder
{
	[Token(Token = "0x4000037")]
	Background = 0,
	[Token(Token = "0x4000038")]
	PaintingHistory = 100,
	[Token(Token = "0x4000039")]
	Painting = 200
}
[Token(Token = "0x2000016")]
public interface IPaintingBlendLayer : PaintingCanvasLayer
{
	[Token(Token = "0x6000053")]
	void RenderTo(RenderTexture target, IBackgroundBlendLayer layer);
}
[Token(Token = "0x2000017")]
public interface IPaintingBlendLayer2 : PaintingCanvasLayer
{
	[Token(Token = "0x6000054")]
	void RenderTo(RenderTexture source, RenderTexture target, IBackgroundBlendLayer layer);
}
[Token(Token = "0x2000018")]
public interface IBackgroundBlendLayer
{
	[Token(Token = "0x17000016")]
	Texture backgroundTexture
	{
		[Token(Token = "0x6000055")]
		get;
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class PaintingHistoryManager : IDisposable, IPaintingBlendLayer, PaintingCanvasLayer
{
	[Token(Token = "0x200001A")]
	public interface HistoryBuffer : IDisposable
	{
		[Token(Token = "0x17000022")]
		Texture previewTexture
		{
			[Token(Token = "0x6000071")]
			get;
		}

		[Token(Token = "0x17000023")]
		string name
		{
			[Token(Token = "0x6000072")]
			get;
		}

		[Token(Token = "0x6000070")]
		void LayerMerge(Texture from, RenderTexture to, IBackgroundBlendLayer background);
	}

	[Token(Token = "0x200001B")]
	public sealed class ClearHistoryBuffer : HistoryBuffer, IDisposable
	{
		[Token(Token = "0x17000024")]
		public Texture previewTexture
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x12DB888", Offset = "0x12DB888", VA = "0x12DB888", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string name
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x12DB890", Offset = "0x12DB890", VA = "0x12DB890", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12DB8D4", Offset = "0x12DB8D4", VA = "0x12DB8D4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x12DB8D8", Offset = "0x12DB8D8", VA = "0x12DB8D8", Slot = "4")]
		public void LayerMerge(Texture from, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x12DB910", Offset = "0x12DB910", VA = "0x12DB910")]
		public ClearHistoryBuffer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFC18", Offset = "0x5FFC18")]
	private sealed class <>c
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RenderTextureDescriptor, RenderTextureDescriptor> <>9__41_0;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<RenderTextureDescriptor, RenderTextureDescriptor> <>9__41_1;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x12DB848", Offset = "0x12DB848", VA = "0x12DB848")]
		public <>c()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x12DB850", Offset = "0x12DB850", VA = "0x12DB850")]
		internal RenderTextureDescriptor <Init>b__41_0(RenderTextureDescriptor description)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12DB86C", Offset = "0x12DB86C", VA = "0x12DB86C")]
		internal RenderTextureDescriptor <Init>b__41_1(RenderTextureDescriptor description)
		{
			return default(RenderTextureDescriptor);
		}
	}

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x602488", Offset = "0x602488")]
	protected int _MaxHistoryCount;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Material _BlitMaterial;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Material _AlphaBlendMergeMaterial;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected RenderTexture mOverflowMergedHisotryBuffer;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected RenderTexture mMergedHisotryBuffer;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<HistoryBuffer> mHistoryStack;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int mUndoHistoryCount;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool mIsHistoryDirty;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected int mLastUndoClearHistoryIndex;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected IBackgroundBlendLayer mCatchedBackground;

	[Token(Token = "0x17000017")]
	public int undoHistoryCount
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x12C141C", Offset = "0x12C141C", VA = "0x12C141C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000018")]
	public RenderTexture mergedHisotryBuffer
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x12C1424", Offset = "0x12C1424", VA = "0x12C1424")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public RenderTexture overflowMergedHisotryBuffer
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x12C142C", Offset = "0x12C142C", VA = "0x12C142C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public ReadOnlyCollection<HistoryBuffer> historyStack
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x12C1434", Offset = "0x12C1434", VA = "0x12C1434")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	public int maxHistoryCount
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x12C1488", Offset = "0x12C1488", VA = "0x12C1488")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x12C1490", Offset = "0x12C1490", VA = "0x12C1490")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Material blitMaterial
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x12C14BC", Offset = "0x12C14BC", VA = "0x12C14BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x12C14C4", Offset = "0x12C14C4", VA = "0x12C14C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12C14CC", Offset = "0x12C14CC", VA = "0x12C14CC", Slot = "6")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x1700001E")]
	public bool canUndo
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12C14D4", Offset = "0x12C14D4", VA = "0x12C14D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public bool canRedo
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12C14E4", Offset = "0x12C14E4", VA = "0x12C14E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool isDirty
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12C153C", Offset = "0x12C153C", VA = "0x12C153C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public Texture preview
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12C1544", Offset = "0x12C1544", VA = "0x12C1544", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x12C154C", Offset = "0x12C154C", VA = "0x12C154C", Slot = "9")]
	public virtual void Undo()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x12C1568", Offset = "0x12C1568", VA = "0x12C1568", Slot = "10")]
	public virtual void Redo()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x12C15D0", Offset = "0x12C15D0", VA = "0x12C15D0", Slot = "11")]
	public virtual void ClearContent()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x12C17BC", Offset = "0x12C17BC", VA = "0x12C17BC")]
	private void ClearRedoHistory()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x12C18EC", Offset = "0x12C18EC", VA = "0x12C18EC", Slot = "12")]
	public virtual void AddPaintAction(HistoryBuffer historyBuffer)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x12C19F8", Offset = "0x12C19F8", VA = "0x12C19F8", Slot = "13")]
	public virtual void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x12C245C", Offset = "0x12C245C", VA = "0x12C245C", Slot = "14")]
	public virtual void MergeHistoryTo(RenderTexture target)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x12C1B54", Offset = "0x12C1B54", VA = "0x12C1B54")]
	private void Init(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x12C253C", Offset = "0x12C253C", VA = "0x12C253C", Slot = "15")]
	protected virtual void OnOverflowHistoryMerged(HistoryBuffer history)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12C2540", Offset = "0x12C2540", VA = "0x12C2540", Slot = "16")]
	protected virtual void OnHistoryBuffersUpdated()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12C1EB8", Offset = "0x12C1EB8", VA = "0x12C1EB8")]
	private void UpdateHistoryBuffers()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x12C2544", Offset = "0x12C2544", VA = "0x12C2544", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x12C26FC", Offset = "0x12C26FC", VA = "0x12C26FC")]
	public PaintingHistoryManager()
	{
	}
}
[Token(Token = "0x200001D")]
public static class RenderTextureUtils
{
	[Token(Token = "0x200001E")]
	public enum GetTemporaryFlag
	{
		[Token(Token = "0x4000048")]
		None,
		[Token(Token = "0x4000049")]
		Clear,
		[Token(Token = "0x400004A")]
		CopyOldContent
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFC38", Offset = "0x5FFC38")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float colorSpaceFacter;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NativeArray<Color32> rawData;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x12DD028", Offset = "0x12DD028", VA = "0x12DD028")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x12DD030", Offset = "0x12DD030", VA = "0x12DD030")]
		internal void <RenderTextureTo2d>b__0(int i)
		{
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x12D0B1C", Offset = "0x12D0B1C", VA = "0x12D0B1C")]
	public static RenderTexture GetTemporary(RenderTexture old, RenderTexture matchTarget, bool clear)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x12C0470", Offset = "0x12C0470", VA = "0x12C0470")]
	public static bool GetTemporary(RenderTexture target, RenderTextureDescriptor descriptor, GetTemporaryFlag flag = GetTemporaryFlag.CopyOldContent, [Optional] Func<RenderTextureDescriptor, RenderTextureDescriptor> onCreate)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x12BFD98", Offset = "0x12BFD98", VA = "0x12BFD98")]
	public static void ReleaseTemporary(RenderTexture texture)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x12D0C88", Offset = "0x12D0C88", VA = "0x12D0C88")]
	public static void SetRenderTargetAndClear(RenderTexture texture)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x12C3C4C", Offset = "0x12C3C4C", VA = "0x12C3C4C")]
	public static void SetRenderTargetAndClear(RenderTexture texture, Color color)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x12C0AF0", Offset = "0x12C0AF0", VA = "0x12C0AF0")]
	public static void Clear(this RenderTexture rt, bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1f)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x12C3E60", Offset = "0x12C3E60", VA = "0x12C3E60")]
	public static Texture2D RenderTextureTo2d(RenderTexture rt, bool apply = true, bool changeColorSpace = false, float colorSpaceFacter = 0.45454544f)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public class UIPainter : Painter, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	[Token(Token = "0x2000021")]
	protected class ActionData
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int pointId;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUp;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x12DE3D4", Offset = "0x12DE3D4", VA = "0x12DE3D4")]
		public ActionData()
		{
		}
	}

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected UIPaintingCanvas _PainterCanvasLayers;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x602504", Offset = "0x602504")]
	protected float _Size;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected RectTransform mRectTransform;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected ActionData mActionData;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x7CF6BC", Offset = "0x7CF6BC", VA = "0x7CF6BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x7CF738", Offset = "0x7CF738", VA = "0x7CF738")]
	public void AddLayer(RenderTexture source)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7CF7BC", Offset = "0x7CF7BC", VA = "0x7CF7BC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x7CFC94", Offset = "0x7CFC94", VA = "0x7CFC94", Slot = "17")]
	protected virtual void SetDone()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7CF9D8", Offset = "0x7CF9D8", VA = "0x7CF9D8")]
	private void Draw(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x7CFD44", Offset = "0x7CFD44", VA = "0x7CFD44", Slot = "15")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7CFDE0", Offset = "0x7CFDE0", VA = "0x7CFDE0", Slot = "14")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7CFE18", Offset = "0x7CFE18", VA = "0x7CFE18", Slot = "16")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7CFE60", Offset = "0x7CFE60", VA = "0x7CFE60")]
	public UIPainter()
	{
	}
}
[Token(Token = "0x2000022")]
public class UIPaintingCanvas : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000023")]
	private class Canvas : PaintingCanvas
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RenderTexture _RenderTexture;

		[Token(Token = "0x17000028")]
		public override RenderTexture renderTexture
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x12DE3DC", Offset = "0x12DE3DC", VA = "0x12DE3DC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x12DE3E4", Offset = "0x12DE3E4", VA = "0x12DE3E4")]
		public Canvas()
		{
		}
	}

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas _Canvas;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BackgroundBlendLayer _Background;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PaintingHistoryManager _HistoryManager;

	[Token(Token = "0x17000026")]
	public PaintingHistoryManager historyManager
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7CFE70", Offset = "0x7CFE70", VA = "0x7CFE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	public PaintingCanvas canvas
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7CFE78", Offset = "0x7CFE78", VA = "0x7CFE78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7CFE80", Offset = "0x7CFE80", VA = "0x7CFE80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x7CFECC", Offset = "0x7CFECC", VA = "0x7CFECC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7CFFAC", Offset = "0x7CFFAC", VA = "0x7CFFAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7D0108", Offset = "0x7D0108", VA = "0x7D0108")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7D0150", Offset = "0x7D0150", VA = "0x7D0150")]
	public UIPaintingCanvas()
	{
	}
}
[Token(Token = "0x2000024")]
public class VRPCCameraController : SingletonGameObject<VRPCCameraController>
{
	[Token(Token = "0x2000025")]
	private class MouseInput : MouseVRRayInput
	{
		[Token(Token = "0x1700002C")]
		public override bool isVRDeviceActive
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x12DEC14", Offset = "0x12DEC14", VA = "0x12DEC14", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x12DEC1C", Offset = "0x12DEC1C", VA = "0x12DEC1C")]
		public MouseInput()
		{
		}
	}

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private KeyCode _ActiveKey;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private KeyCode _UIHideKey;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MenuPanel _HelpUI;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRPCCamera mVRPCCamera;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TPSCamera mTpsCamera;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform mViewPosition;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool mIsUIHided;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private XmlElement mSavedNode;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float mMoveSpeed;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private VRRayController mMouseRayController;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool mHelpUIAndSettingsInited;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private HashSet<VRRayController> mDisabledRays;

	[Token(Token = "0x17000029")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7D26AC", Offset = "0x7D26AC", VA = "0x7D26AC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002A")]
	public XmlElement savedData
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7D2E1C", Offset = "0x7D2E1C", VA = "0x7D2E1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	private bool isInValidScene
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7D3984", Offset = "0x7D3984", VA = "0x7D3984")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7D26B4", Offset = "0x7D26B4", VA = "0x7D26B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7D2A40", Offset = "0x7D2A40", VA = "0x7D2A40")]
	private void InitHelpUIAndSettings()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7D2918", Offset = "0x7D2918", VA = "0x7D2918")]
	private void CreatePCCameraRay()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7D2F68", Offset = "0x7D2F68", VA = "0x7D2F68")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x7D312C", Offset = "0x7D312C", VA = "0x7D312C")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7D3394", Offset = "0x7D3394", VA = "0x7D3394", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x7D3524", Offset = "0x7D3524", VA = "0x7D3524")]
	private void CreateVRPCCamera()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7D3840", Offset = "0x7D3840", VA = "0x7D3840")]
	private void DestroyVRPCamera()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x7D3A90", Offset = "0x7D3A90", VA = "0x7D3A90")]
	private void UpdateVRPCCamera()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x7D3DC4", Offset = "0x7D3DC4", VA = "0x7D3DC4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x7D3520", Offset = "0x7D3520", VA = "0x7D3520")]
	private void DisableOtherMouseRay(bool disable)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x7D3950", Offset = "0x7D3950", VA = "0x7D3950")]
	private void LockAndCursor(bool lockAndHide)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7D3130", Offset = "0x7D3130", VA = "0x7D3130")]
	private void ResetCameraPosition()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7D4164", Offset = "0x7D4164", VA = "0x7D4164")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7D41B4", Offset = "0x7D41B4", VA = "0x7D41B4")]
	public VRPCCameraController()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7D4258", Offset = "0x7D4258", VA = "0x7D4258")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6057BC", Offset = "0x6057BC")]
	private void <InitHelpUIAndSettings>b__14_0(float v)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x7D42EC", Offset = "0x7D42EC", VA = "0x7D42EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6057CC", Offset = "0x6057CC")]
	private void <InitHelpUIAndSettings>b__14_1(float v)
	{
	}
}
[Token(Token = "0x2000026")]
public class VRPCCameraLoader
{
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7D43CC", Offset = "0x7D43CC", VA = "0x7D43CC")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6057DC", Offset = "0x6057DC")]
	public static void OnInit()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x7D43FC", Offset = "0x7D43FC", VA = "0x7D43FC")]
	private static void Load()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x7D448C", Offset = "0x7D448C", VA = "0x7D448C")]
	public VRPCCameraLoader()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x5FFC48", Offset = "0x5FFC48")]
public abstract class AchievementRemoteAPI : SingletonGameObject<AchievementRemoteAPI>
{
	[Token(Token = "0x2000028")]
	public class AchievementData
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isCompleted;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7D7218", Offset = "0x7D7218", VA = "0x7D7218")]
		public AchievementData()
		{
		}
	}

	[Token(Token = "0x1700002D")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7AD928", Offset = "0x7AD928", VA = "0x7AD928", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000B1")]
	public abstract Coroutine GetAchievemets(Action<ICollection<AchievementData>> action);

	[Token(Token = "0x60000B2")]
	public abstract void SetAchievementCompelete(string id);

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7AD930", Offset = "0x7AD930", VA = "0x7AD930")]
	protected AchievementRemoteAPI()
	{
	}
}
[Token(Token = "0x2000029")]
public class AchievementSystem : SingletonGameObject<AchievementSystem>
{
	[Serializable]
	[Token(Token = "0x200002A")]
	private class ImportSettings
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string csvFile;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string headerId;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string headerNameFmt;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string headerDescriptionFmt;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string defineXmlFile;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7D7220", Offset = "0x7D7220", VA = "0x7D7220")]
		public ImportSettings()
		{
		}
	}

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _AudioOnAchievementDone;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ImportSettings _ImportSettings;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, Achievement> mAchievementDic;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XmlElement mDataNode;

	[Token(Token = "0x1700002E")]
	public XmlDocument document
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7AD984", Offset = "0x7AD984", VA = "0x7AD984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	private XmlElement dataNode
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7AD9E0", Offset = "0x7AD9E0", VA = "0x7AD9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public IReadOnlyDictionary<string, Achievement> achievements
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7ADB24", Offset = "0x7ADB24", VA = "0x7ADB24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x7ADB2C", Offset = "0x7ADB2C", VA = "0x7ADB2C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7AD1C0", Offset = "0x7AD1C0", VA = "0x7AD1C0")]
	public XmlElement GetSavedData(string achivementId)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7ADB34", Offset = "0x7ADB34", VA = "0x7ADB34", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7AE79C", Offset = "0x7AE79C", VA = "0x7AE79C")]
	private void SavedXmlData_onSavingData()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7ADDA0", Offset = "0x7ADDA0", VA = "0x7ADDA0")]
	private void LoadAchievements()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7AE8D8", Offset = "0x7AE8D8", VA = "0x7AE8D8")]
	public void OnReceiveRemoteAchivement(AchievementRemoteAPI.AchievementData achievementData)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7AD3E4", Offset = "0x7AD3E4", VA = "0x7AD3E4")]
	public void OnAchievementCompleted(Achievement achievement)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7AE9E0", Offset = "0x7AE9E0", VA = "0x7AE9E0")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x7AEA3C", Offset = "0x7AEA3C", VA = "0x7AEA3C", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7AEB78", Offset = "0x7AEB78", VA = "0x7AEB78")]
	public AchievementSystem()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7AEC14", Offset = "0x7AEC14", VA = "0x7AEC14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6057EC", Offset = "0x6057EC")]
	private void <OnAwake>b__13_0(ICollection<AchievementRemoteAPI.AchievementData> achievements)
	{
	}
}
[Token(Token = "0x200002B")]
public abstract class Achievement : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	public enum LevelMode
	{
		[Token(Token = "0x400007F")]
		None,
		[Token(Token = "0x4000080")]
		Tutorial,
		[Token(Token = "0x4000081")]
		Freedom,
		[Token(Token = "0x4000082")]
		Challenge
	}

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string _Name;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _Description;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6025F0", Offset = "0x6025F0")]
	private string <id>k__BackingField;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602600", Offset = "0x602600")]
	private bool <hidden>k__BackingField;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602610", Offset = "0x602610")]
	private AchievementSystem <system>k__BackingField;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602620", Offset = "0x602620")]
	private bool <isOnServer>k__BackingField;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602630", Offset = "0x602630")]
	private bool <isCompleted>k__BackingField;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602640", Offset = "0x602640")]
	private LevelMode <levelMode>k__BackingField;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602650", Offset = "0x602650")]
	private XmlElement <savedData>k__BackingField;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602660", Offset = "0x602660")]
	private bool <newCompleted>k__BackingField;

	[Token(Token = "0x17000032")]
	public string id
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7ACBC4", Offset = "0x7ACBC4", VA = "0x7ACBC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6057FC", Offset = "0x6057FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7ACBCC", Offset = "0x7ACBCC", VA = "0x7ACBCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60580C", Offset = "0x60580C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public new string name
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x7ACBD4", Offset = "0x7ACBD4", VA = "0x7ACBD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000034")]
	public bool hidden
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7ACC94", Offset = "0x7ACC94", VA = "0x7ACC94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60581C", Offset = "0x60581C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7ACC9C", Offset = "0x7ACC9C", VA = "0x7ACC9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60582C", Offset = "0x60582C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public string description
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7ACCA8", Offset = "0x7ACCA8", VA = "0x7ACCA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000036")]
	public AchievementSystem system
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7ACD68", Offset = "0x7ACD68", VA = "0x7ACD68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60583C", Offset = "0x60583C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7ACD70", Offset = "0x7ACD70", VA = "0x7ACD70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60584C", Offset = "0x60584C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public bool isOnServer
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7ACD78", Offset = "0x7ACD78", VA = "0x7ACD78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60585C", Offset = "0x60585C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x7ACD80", Offset = "0x7ACD80", VA = "0x7ACD80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60586C", Offset = "0x60586C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public bool isCompleted
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7ACD8C", Offset = "0x7ACD8C", VA = "0x7ACD8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60587C", Offset = "0x60587C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7ACD94", Offset = "0x7ACD94", VA = "0x7ACD94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60588C", Offset = "0x60588C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public LevelMode levelMode
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7ACDA0", Offset = "0x7ACDA0", VA = "0x7ACDA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60589C", Offset = "0x60589C")]
		get
		{
			return default(LevelMode);
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7ACDA8", Offset = "0x7ACDA8", VA = "0x7ACDA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058AC", Offset = "0x6058AC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public virtual int progressMax
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7ACDB0", Offset = "0x7ACDB0", VA = "0x7ACDB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003B")]
	public virtual int progress
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7ACDB8", Offset = "0x7ACDB8", VA = "0x7ACDB8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool isCurrentLevelValid
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7ACDC0", Offset = "0x7ACDC0", VA = "0x7ACDC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	protected XmlElement savedData
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7ACF70", Offset = "0x7ACF70", VA = "0x7ACF70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058BC", Offset = "0x6058BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7ACF78", Offset = "0x7ACF78", VA = "0x7ACF78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058CC", Offset = "0x6058CC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public bool newCompleted
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7ACF80", Offset = "0x7ACF80", VA = "0x7ACF80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058DC", Offset = "0x6058DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7ACF88", Offset = "0x7ACF88", VA = "0x7ACF88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058EC", Offset = "0x6058EC")]
		set
		{
		}
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7ACF94", Offset = "0x7ACF94", VA = "0x7ACF94", Slot = "6")]
	public virtual void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x7AD350", Offset = "0x7AD350", VA = "0x7AD350")]
	public void SetComplete()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7AD570", Offset = "0x7AD570", VA = "0x7AD570", Slot = "7")]
	public virtual void OnSaveData()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7AD644", Offset = "0x7AD644", VA = "0x7AD644")]
	public void OnReceiveRemoteAchivement(AchievementRemoteAPI.AchievementData achievementData)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7AD6E4", Offset = "0x7AD6E4", VA = "0x7AD6E4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x7AD920", Offset = "0x7AD920", VA = "0x7AD920")]
	protected Achievement()
	{
	}
}
[Token(Token = "0x200002D")]
public class Achievement_ApplyAllCopybooks : Achievement
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private HashSet<string> mAppliedCopybooks;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<string> mNotAppliedCopybooks;

	[Token(Token = "0x1700003F")]
	public override int progress
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7AF228", Offset = "0x7AF228", VA = "0x7AF228", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000040")]
	public override int progressMax
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7AF274", Offset = "0x7AF274", VA = "0x7AF274", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x7AF118", Offset = "0x7AF118", VA = "0x7AF118")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7AF1A0", Offset = "0x7AF1A0", VA = "0x7AF1A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x7AF2D0", Offset = "0x7AF2D0", VA = "0x7AF2D0")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x7AF4A0", Offset = "0x7AF4A0", VA = "0x7AF4A0", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x7AF7B0", Offset = "0x7AF7B0", VA = "0x7AF7B0", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x7AF858", Offset = "0x7AF858", VA = "0x7AF858", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x7AF944", Offset = "0x7AF944", VA = "0x7AF944")]
	public Achievement_ApplyAllCopybooks()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x7AF9DC", Offset = "0x7AF9DC", VA = "0x7AF9DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058FC", Offset = "0x6058FC")]
	private void <OnInit>b__9_0(Texture t, string path)
	{
	}
}
[Token(Token = "0x200002E")]
public class Achievement_ChallengeLevelComplete : Achievement
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602670", Offset = "0x602670")]
	private int <count>k__BackingField;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int mCaledLevels;

	[Token(Token = "0x17000041")]
	public int count
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7AFABC", Offset = "0x7AFABC", VA = "0x7AFABC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60590C", Offset = "0x60590C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x7AFAC4", Offset = "0x7AFAC4", VA = "0x7AFAC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60591C", Offset = "0x60591C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public override int progress
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x7AFACC", Offset = "0x7AFACC", VA = "0x7AFACC", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000043")]
	public override int progressMax
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x7AFAD4", Offset = "0x7AFAD4", VA = "0x7AFAD4", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7AFB48", Offset = "0x7AFB48", VA = "0x7AFB48")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x7AFBD0", Offset = "0x7AFBD0", VA = "0x7AFBD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7AFC58", Offset = "0x7AFC58", VA = "0x7AFC58")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7B0214", Offset = "0x7B0214", VA = "0x7B0214", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7B032C", Offset = "0x7B032C", VA = "0x7B032C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x7B0460", Offset = "0x7B0460", VA = "0x7B0460")]
	public Achievement_ChallengeLevelComplete()
	{
	}
}
[Token(Token = "0x200002F")]
public class Achievement_ChallengeScoreCombo : Achievement
{
	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602680", Offset = "0x602680")]
	private int <combo>k__BackingField;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602690", Offset = "0x602690")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int mCurrentCombo;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int mLastLevel;

	[Token(Token = "0x17000044")]
	public int combo
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7B0468", Offset = "0x7B0468", VA = "0x7B0468")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60592C", Offset = "0x60592C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7B0470", Offset = "0x7B0470", VA = "0x7B0470")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60593C", Offset = "0x60593C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public int scoreLevel
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x7B0478", Offset = "0x7B0478", VA = "0x7B0478")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60594C", Offset = "0x60594C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x7B0480", Offset = "0x7B0480", VA = "0x7B0480")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60595C", Offset = "0x60595C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public override int progressMax
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x7B0488", Offset = "0x7B0488", VA = "0x7B0488", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000047")]
	public override int progress
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7B0490", Offset = "0x7B0490", VA = "0x7B0490", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x7B0498", Offset = "0x7B0498", VA = "0x7B0498")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x7B05C0", Offset = "0x7B05C0", VA = "0x7B05C0")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x7B05CC", Offset = "0x7B05CC", VA = "0x7B05CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7B06EC", Offset = "0x7B06EC", VA = "0x7B06EC")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7B0AB4", Offset = "0x7B0AB4", VA = "0x7B0AB4", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7B0BCC", Offset = "0x7B0BCC", VA = "0x7B0BCC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7B0C88", Offset = "0x7B0C88", VA = "0x7B0C88")]
	public Achievement_ChallengeScoreCombo()
	{
	}
}
[Token(Token = "0x2000030")]
public class Achievement_ChallengeScoreLevelCount : Achievement
{
	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026A0", Offset = "0x6026A0")]
	private int <count>k__BackingField;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026B0", Offset = "0x6026B0")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int mCurrentCaledCount;

	[Token(Token = "0x17000048")]
	public int count
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7B0C98", Offset = "0x7B0C98", VA = "0x7B0C98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60596C", Offset = "0x60596C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x7B0CA0", Offset = "0x7B0CA0", VA = "0x7B0CA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60597C", Offset = "0x60597C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public int scoreLevel
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x7B0CA8", Offset = "0x7B0CA8", VA = "0x7B0CA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60598C", Offset = "0x60598C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x7B0CB0", Offset = "0x7B0CB0", VA = "0x7B0CB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60599C", Offset = "0x60599C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public override int progressMax
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x7B0CB8", Offset = "0x7B0CB8", VA = "0x7B0CB8", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004B")]
	public override int progress
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7B0D2C", Offset = "0x7B0D2C", VA = "0x7B0D2C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7B0D34", Offset = "0x7B0D34", VA = "0x7B0D34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x7B0DBC", Offset = "0x7B0DBC", VA = "0x7B0DBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x7B0E44", Offset = "0x7B0E44", VA = "0x7B0E44")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x7B0F10", Offset = "0x7B0F10", VA = "0x7B0F10")]
	private int CalTargetCount()
	{
		return default(int);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7B1344", Offset = "0x7B1344", VA = "0x7B1344", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7B1464", Offset = "0x7B1464", VA = "0x7B1464", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x7B1564", Offset = "0x7B1564", VA = "0x7B1564")]
	public Achievement_ChallengeScoreLevelCount()
	{
	}
}
[Token(Token = "0x2000031")]
public class Achievement_ColorPalettePick : Achievement
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026C0", Offset = "0x6026C0")]
	private string <targetColorPalette>k__BackingField;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026D0", Offset = "0x6026D0")]
	private int <count>k__BackingField;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026E0", Offset = "0x6026E0")]
	private float <cd>k__BackingField;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mCurrentCount;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float mLastTime;

	[Token(Token = "0x1700004C")]
	public string targetColorPalette
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x7B156C", Offset = "0x7B156C", VA = "0x7B156C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059AC", Offset = "0x6059AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x7B1574", Offset = "0x7B1574", VA = "0x7B1574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059BC", Offset = "0x6059BC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public int count
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7B157C", Offset = "0x7B157C", VA = "0x7B157C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059CC", Offset = "0x6059CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7B1584", Offset = "0x7B1584", VA = "0x7B1584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059DC", Offset = "0x6059DC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public float cd
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7B158C", Offset = "0x7B158C", VA = "0x7B158C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059EC", Offset = "0x6059EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x7B1594", Offset = "0x7B1594", VA = "0x7B1594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6059FC", Offset = "0x6059FC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public override int progressMax
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x7B159C", Offset = "0x7B159C", VA = "0x7B159C", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000050")]
	public override int progress
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7B15A4", Offset = "0x7B15A4", VA = "0x7B15A4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x7B15AC", Offset = "0x7B15AC", VA = "0x7B15AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x7B1634", Offset = "0x7B1634", VA = "0x7B1634")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x7B16BC", Offset = "0x7B16BC", VA = "0x7B16BC")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x7B185C", Offset = "0x7B185C", VA = "0x7B185C", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x7B19A4", Offset = "0x7B19A4", VA = "0x7B19A4", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7B1A20", Offset = "0x7B1A20", VA = "0x7B1A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x7B1BB4", Offset = "0x7B1BB4", VA = "0x7B1BB4")]
	public Achievement_ColorPalettePick()
	{
	}
}
[Token(Token = "0x2000032")]
public class Achievement_MatchEvents : Achievement
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string mMsgType;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int mWhat;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int mCount;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mCurrentCount;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float mCD;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float mLastTime;

	[Token(Token = "0x17000051")]
	public override int progressMax
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7B1BBC", Offset = "0x7B1BBC", VA = "0x7B1BBC", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000052")]
	public override int progress
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7B1BC4", Offset = "0x7B1BC4", VA = "0x7B1BC4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x7B1BCC", Offset = "0x7B1BCC", VA = "0x7B1BCC", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x7B1DE0", Offset = "0x7B1DE0", VA = "0x7B1DE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x7B1E68", Offset = "0x7B1E68", VA = "0x7B1E68")]
	private bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x7B1F88", Offset = "0x7B1F88", VA = "0x7B1F88", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x7B2004", Offset = "0x7B2004", VA = "0x7B2004", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x7B2268", Offset = "0x7B2268", VA = "0x7B2268")]
	public Achievement_MatchEvents()
	{
	}
}
[Token(Token = "0x2000033")]
public class Achievement_OneStroke_MatchMultiStroke : Achievement
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026F0", Offset = "0x6026F0")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x17000053")]
	public int scoreLevel
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7B2270", Offset = "0x7B2270", VA = "0x7B2270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A0C", Offset = "0x605A0C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x7B2278", Offset = "0x7B2278", VA = "0x7B2278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A1C", Offset = "0x605A1C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x7B2280", Offset = "0x7B2280", VA = "0x7B2280")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x7B2308", Offset = "0x7B2308", VA = "0x7B2308")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x7B2390", Offset = "0x7B2390", VA = "0x7B2390")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7B25F0", Offset = "0x7B25F0", VA = "0x7B25F0", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x7B26CC", Offset = "0x7B26CC", VA = "0x7B26CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x7B276C", Offset = "0x7B276C", VA = "0x7B276C")]
	public Achievement_OneStroke_MatchMultiStroke()
	{
	}
}
[Token(Token = "0x2000034")]
public class Achievement_OneStroke_MathWordCount : Achievement
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602700", Offset = "0x602700")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602710", Offset = "0x602710")]
	private int <minWordsCount>k__BackingField;

	[Token(Token = "0x17000054")]
	public int scoreLevel
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7B2774", Offset = "0x7B2774", VA = "0x7B2774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A2C", Offset = "0x605A2C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x7B277C", Offset = "0x7B277C", VA = "0x7B277C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A3C", Offset = "0x605A3C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public int minWordsCount
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x7B2784", Offset = "0x7B2784", VA = "0x7B2784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A4C", Offset = "0x605A4C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x7B278C", Offset = "0x7B278C", VA = "0x7B278C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A5C", Offset = "0x605A5C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x7B2794", Offset = "0x7B2794", VA = "0x7B2794")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x7B281C", Offset = "0x7B281C", VA = "0x7B281C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7B28A4", Offset = "0x7B28A4", VA = "0x7B28A4")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7B2B18", Offset = "0x7B2B18", VA = "0x7B2B18", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7B2C30", Offset = "0x7B2C30", VA = "0x7B2C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x7B2CEC", Offset = "0x7B2CEC", VA = "0x7B2CEC")]
	public Achievement_OneStroke_MathWordCount()
	{
	}
}
[Token(Token = "0x2000035")]
public class Achievement_OverStroke_MatchLevelCount : Achievement
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602720", Offset = "0x602720")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602730", Offset = "0x602730")]
	private int <levelCount>k__BackingField;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<string> mLevels;

	[Token(Token = "0x17000056")]
	public int scoreLevel
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7B2CF4", Offset = "0x7B2CF4", VA = "0x7B2CF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A6C", Offset = "0x605A6C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x7B2CFC", Offset = "0x7B2CFC", VA = "0x7B2CFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A7C", Offset = "0x605A7C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public int levelCount
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7B2D04", Offset = "0x7B2D04", VA = "0x7B2D04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A8C", Offset = "0x605A8C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7B2D0C", Offset = "0x7B2D0C", VA = "0x7B2D0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605A9C", Offset = "0x605A9C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public override int progressMax
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7B2D14", Offset = "0x7B2D14", VA = "0x7B2D14", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000059")]
	public override int progress
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7B2D1C", Offset = "0x7B2D1C", VA = "0x7B2D1C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x7B2D68", Offset = "0x7B2D68", VA = "0x7B2D68")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x7B2DF0", Offset = "0x7B2DF0", VA = "0x7B2DF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7B2E78", Offset = "0x7B2E78", VA = "0x7B2E78")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7B311C", Offset = "0x7B311C", VA = "0x7B311C", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x7B32C4", Offset = "0x7B32C4", VA = "0x7B32C4", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x7B336C", Offset = "0x7B336C", VA = "0x7B336C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x7B3570", Offset = "0x7B3570", VA = "0x7B3570")]
	public Achievement_OverStroke_MatchLevelCount()
	{
	}
}
[Token(Token = "0x2000036")]
public class Achievement_OverStroke_MatchWord : Achievement
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602740", Offset = "0x602740")]
	private string <targetWord>k__BackingField;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602750", Offset = "0x602750")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x1700005A")]
	public string targetWord
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x7B35F0", Offset = "0x7B35F0", VA = "0x7B35F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605AAC", Offset = "0x605AAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x7B35F8", Offset = "0x7B35F8", VA = "0x7B35F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605ABC", Offset = "0x605ABC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public int scoreLevel
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7B3600", Offset = "0x7B3600", VA = "0x7B3600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605ACC", Offset = "0x605ACC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x7B3608", Offset = "0x7B3608", VA = "0x7B3608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605ADC", Offset = "0x605ADC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7B3610", Offset = "0x7B3610", VA = "0x7B3610")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7B3698", Offset = "0x7B3698", VA = "0x7B3698")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7B3720", Offset = "0x7B3720", VA = "0x7B3720")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7B398C", Offset = "0x7B398C", VA = "0x7B398C", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x7B3A98", Offset = "0x7B3A98", VA = "0x7B3A98", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x7B3B40", Offset = "0x7B3B40", VA = "0x7B3B40")]
	public Achievement_OverStroke_MatchWord()
	{
	}
}
[Token(Token = "0x2000037")]
public class Achievement_PaintAllColors : Achievement
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private HashSet<string> mNotPaintTargets;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<string> mPaintedTargets;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ColorPalette mLastColorPalette;

	[Token(Token = "0x1700005C")]
	public override int progressMax
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x7B3B48", Offset = "0x7B3B48", VA = "0x7B3B48", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005D")]
	public override int progress
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x7B3BA4", Offset = "0x7B3BA4", VA = "0x7B3BA4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x7B3BF0", Offset = "0x7B3BF0", VA = "0x7B3BF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x7B3C78", Offset = "0x7B3C78", VA = "0x7B3C78")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x7B3D00", Offset = "0x7B3D00", VA = "0x7B3D00")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7B4010", Offset = "0x7B4010", VA = "0x7B4010")]
	private bool ColorEquals(Color a, Color b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x7B4148", Offset = "0x7B4148", VA = "0x7B4148")]
	private void SetTargetPainted(string target)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x7B4208", Offset = "0x7B4208", VA = "0x7B4208", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x7B42B0", Offset = "0x7B42B0", VA = "0x7B42B0", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x7B44C4", Offset = "0x7B44C4", VA = "0x7B44C4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x7B4728", Offset = "0x7B4728", VA = "0x7B4728")]
	public Achievement_PaintAllColors()
	{
	}
}
[Token(Token = "0x2000038")]
public class Achievement_PaintTime : Achievement
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602760", Offset = "0x602760")]
	private string <targetPaper>k__BackingField;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602770", Offset = "0x602770")]
	private float <time>k__BackingField;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float mCurrentTime;

	[Token(Token = "0x1700005E")]
	public string targetPaper
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x7B47C0", Offset = "0x7B47C0", VA = "0x7B47C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605AEC", Offset = "0x605AEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7B47C8", Offset = "0x7B47C8", VA = "0x7B47C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605AFC", Offset = "0x605AFC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public float time
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7B47D0", Offset = "0x7B47D0", VA = "0x7B47D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B0C", Offset = "0x605B0C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7B47D8", Offset = "0x7B47D8", VA = "0x7B47D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B1C", Offset = "0x605B1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public override int progressMax
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7B47E0", Offset = "0x7B47E0", VA = "0x7B47E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000061")]
	public override int progress
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7B4810", Offset = "0x7B4810", VA = "0x7B4810", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x7B4840", Offset = "0x7B4840", VA = "0x7B4840")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x7B48C8", Offset = "0x7B48C8", VA = "0x7B48C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x7B4950", Offset = "0x7B4950", VA = "0x7B4950")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7B4AC8", Offset = "0x7B4AC8", VA = "0x7B4AC8", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x7B4C04", Offset = "0x7B4C04", VA = "0x7B4C04", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7B4C80", Offset = "0x7B4C80", VA = "0x7B4C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x7B4E14", Offset = "0x7B4E14", VA = "0x7B4E14")]
	public Achievement_PaintTime()
	{
	}
}
[Token(Token = "0x2000039")]
public class Achievement_PerfactWriting : Achievement
{
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602780", Offset = "0x602780")]
	private float <targetScore>k__BackingField;

	[Token(Token = "0x17000062")]
	public float targetScore
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7B4E1C", Offset = "0x7B4E1C", VA = "0x7B4E1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B2C", Offset = "0x605B2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x7B4E24", Offset = "0x7B4E24", VA = "0x7B4E24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B3C", Offset = "0x605B3C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x7B4E2C", Offset = "0x7B4E2C", VA = "0x7B4E2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x7B4EB4", Offset = "0x7B4EB4", VA = "0x7B4EB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x7B4F3C", Offset = "0x7B4F3C", VA = "0x7B4F3C")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x7B5030", Offset = "0x7B5030", VA = "0x7B5030", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x7B5110", Offset = "0x7B5110", VA = "0x7B5110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x7B51B0", Offset = "0x7B51B0", VA = "0x7B51B0")]
	public Achievement_PerfactWriting()
	{
	}
}
[Token(Token = "0x200003A")]
public class Achievement_SubmitEmpty : Achievement
{
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x7B51B8", Offset = "0x7B51B8", VA = "0x7B51B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x7B5240", Offset = "0x7B5240", VA = "0x7B5240")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x7B52C8", Offset = "0x7B52C8", VA = "0x7B52C8")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x7B5464", Offset = "0x7B5464", VA = "0x7B5464", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x7B5468", Offset = "0x7B5468", VA = "0x7B5468")]
	public Achievement_SubmitEmpty()
	{
	}
}
[Token(Token = "0x200003B")]
public class Achievement_SubmitWithSeal : Achievement
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602790", Offset = "0x602790")]
	private int <scoreLevel>k__BackingField;

	[Token(Token = "0x17000063")]
	public int scoreLevel
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7B5470", Offset = "0x7B5470", VA = "0x7B5470")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B4C", Offset = "0x605B4C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7B5478", Offset = "0x7B5478", VA = "0x7B5478")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B5C", Offset = "0x605B5C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x7B5480", Offset = "0x7B5480", VA = "0x7B5480")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x7B5508", Offset = "0x7B5508", VA = "0x7B5508")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x7B5590", Offset = "0x7B5590", VA = "0x7B5590")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x7B57D8", Offset = "0x7B57D8", VA = "0x7B57D8", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x7B58B4", Offset = "0x7B58B4", VA = "0x7B58B4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x7B5954", Offset = "0x7B5954", VA = "0x7B5954")]
	public Achievement_SubmitWithSeal()
	{
	}
}
[Token(Token = "0x200003C")]
public class Authorization : MonoBehaviour
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Authorization _instance;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x7B5F00", Offset = "0x7B5F00", VA = "0x7B5F00")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x7B5FF0", Offset = "0x7B5FF0", VA = "0x7B5FF0")]
	public static byte[] Check()
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x7B6300", Offset = "0x7B6300", VA = "0x7B6300")]
	public Authorization()
	{
	}
}
[Token(Token = "0x200003D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFC84", Offset = "0x5FFC84")]
public class BugFix_ScrollRect_UnscaledDeltaTimeZero : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScrollRect mScrollRect;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 mOldVelocity;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x7BD068", Offset = "0x7BD068", VA = "0x7BD068")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x7BD0C4", Offset = "0x7BD0C4", VA = "0x7BD0C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x7BD25C", Offset = "0x7BD25C", VA = "0x7BD25C")]
	public BugFix_ScrollRect_UnscaledDeltaTimeZero()
	{
	}
}
[Token(Token = "0x200003E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFCEC", Offset = "0x5FFCEC")]
public class BookAnimationController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200003F")]
	private struct Audios
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AudioClip open;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip close;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip nextPage;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip prevPage;
	}

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Audios _StateAudios;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _StateOpen;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string _StateClose;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _StateNextPage;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _StatePrevPage;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UnityEvents.IntEvent _OnPageOffsetChanged;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator mAnimator;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mCurrentPageOffset;

	[Token(Token = "0x17000064")]
	public int currentPageOffset
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7B9168", Offset = "0x7B9168", VA = "0x7B9168")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7B9170", Offset = "0x7B9170", VA = "0x7B9170")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public int pageCount
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x7B91F4", Offset = "0x7B91F4", VA = "0x7B91F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000066")]
	public UnityEvents.IntEvent OnPageOffsetChanged
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x7B91FC", Offset = "0x7B91FC", VA = "0x7B91FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x7B9204", Offset = "0x7B9204", VA = "0x7B9204")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x7B9284", Offset = "0x7B9284", VA = "0x7B9284")]
	private void Update()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x7B9350", Offset = "0x7B9350", VA = "0x7B9350")]
	public void PrevPage()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x7B9470", Offset = "0x7B9470", VA = "0x7B9470")]
	public void NextPage()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x7B9590", Offset = "0x7B9590", VA = "0x7B9590")]
	public void Open()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x7B9638", Offset = "0x7B9638", VA = "0x7B9638")]
	public void Close()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x7B96E0", Offset = "0x7B96E0", VA = "0x7B96E0")]
	public BookAnimationController()
	{
	}
}
[Token(Token = "0x2000040")]
public class BookLevelPagerUI : MonoBehaviour
{
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x7B96E8", Offset = "0x7B96E8", VA = "0x7B96E8")]
	public BookLevelPagerUI()
	{
	}
}
[Token(Token = "0x2000041")]
[ExecuteInEditMode]
public class BookLight : MonoBehaviour
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material[] _Materials;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x7B96F0", Offset = "0x7B96F0", VA = "0x7B96F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x7B980C", Offset = "0x7B980C", VA = "0x7B980C")]
	public BookLight()
	{
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFD8C", Offset = "0x5FFD8C")]
public class BookPagerUI : MonoBehaviour
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonPrevPage;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonNextPage;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonHomePaper;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CanvasGroup mCanvasGroup;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602840", Offset = "0x602840")]
	private int <pageIndex>k__BackingField;

	[Token(Token = "0x17000067")]
	public Button buttonPrevPage
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7B9814", Offset = "0x7B9814", VA = "0x7B9814")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000068")]
	public Button buttonNextPage
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7B981C", Offset = "0x7B981C", VA = "0x7B981C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000069")]
	public Button buttonHomePaper
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7B9824", Offset = "0x7B9824", VA = "0x7B9824")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006A")]
	public int pageIndex
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7B982C", Offset = "0x7B982C", VA = "0x7B982C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B6C", Offset = "0x605B6C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x7B9834", Offset = "0x7B9834", VA = "0x7B9834")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B7C", Offset = "0x605B7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public CanvasGroup canvasGroup
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7B983C", Offset = "0x7B983C", VA = "0x7B983C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x7B98E4", Offset = "0x7B98E4", VA = "0x7B98E4")]
	public BookPagerUI()
	{
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFDF4", Offset = "0x5FFDF4")]
public class BookUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000044")]
	private class CataloguePager
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int entryCountInPage;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7D8550", Offset = "0x7D8550", VA = "0x7D8550")]
		public CataloguePager()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000045")]
	private class LevelPager
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7D8844", Offset = "0x7D8844", VA = "0x7D8844")]
		public LevelPager()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000046")]
	private class EmptyPager
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x7D883C", Offset = "0x7D883C", VA = "0x7D883C")]
		public EmptyPager()
		{
		}
	}

	[Token(Token = "0x2000047")]
	private class ChallengeStatisticsInfo
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] levelsPassed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] maxScores;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int scoreACount;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int scoreBCount;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int scoreCCount;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int scoreDCount;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x7D8560", Offset = "0x7D8560", VA = "0x7D8560")]
		public ChallengeStatisticsInfo()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x7D87B8", Offset = "0x7D87B8", VA = "0x7D87B8")]
		public float GetMaxScore(int level)
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE5C", Offset = "0x5FFE5C")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7D84BC", Offset = "0x7D84BC", VA = "0x7D84BC")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7D84C4", Offset = "0x7D84C4", VA = "0x7D84C4")]
		internal void <LoadPage>b__3()
		{
		}
	}

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CataloguePager _Catalogue;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LevelPager _LevelPager;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private EmptyPager _EmptyPager;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BookAnimationController _Book;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private MenuPanel _BackPanel;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _PageWidth;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private DocumentLayoutElement mDocumentLayoutElement;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int mCurrentPage;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<GameObject> mPages;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ChallengeLevelData.Level[] mLevelsData;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ChallengeStatisticsInfo mChallengeStatisticsInfo;

	[Token(Token = "0x1700006C")]
	private int cataloguePageCount
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7B98EC", Offset = "0x7B98EC", VA = "0x7B98EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006D")]
	private int totalPageCount
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x7B9928", Offset = "0x7B9928", VA = "0x7B9928")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x7B995C", Offset = "0x7B995C", VA = "0x7B995C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x7B9B1C", Offset = "0x7B9B1C", VA = "0x7B9B1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x7B9C98", Offset = "0x7B9C98", VA = "0x7B9C98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x7B9CB4", Offset = "0x7B9CB4", VA = "0x7B9CB4")]
	private void SetOffset(int off)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x7B9CEC", Offset = "0x7B9CEC", VA = "0x7B9CEC")]
	private void Clear()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x7B9B90", Offset = "0x7B9B90", VA = "0x7B9B90")]
	public void SetPage(int index)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x7B9E54", Offset = "0x7B9E54", VA = "0x7B9E54")]
	private void RefreshPages()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x7BA428", Offset = "0x7BA428", VA = "0x7BA428")]
	private void ResetPaperPosition()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x7B9F00", Offset = "0x7B9F00", VA = "0x7B9F00")]
	private void ReplaceNext(int index, int count, bool move)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x7BA19C", Offset = "0x7BA19C", VA = "0x7BA19C")]
	private void ReplacePrev(int index, int count, bool move)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x7BA560", Offset = "0x7BA560", VA = "0x7BA560")]
	public void NextPage()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x7BA56C", Offset = "0x7BA56C", VA = "0x7BA56C")]
	public void PrevPage()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x7BA578", Offset = "0x7BA578", VA = "0x7BA578")]
	public void OnHomeButton()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x7BA5C4", Offset = "0x7BA5C4", VA = "0x7BA5C4")]
	public void Close()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x7BA5FC", Offset = "0x7BA5FC", VA = "0x7BA5FC")]
	public void HomePage()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x7BA604", Offset = "0x7BA604", VA = "0x7BA604")]
	private void OnCatalogueSelected(int level)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x7BA634", Offset = "0x7BA634", VA = "0x7BA634", Slot = "4")]
	protected virtual GameObject LoadPage(int pageIndex)
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x7BBC84", Offset = "0x7BBC84", VA = "0x7BBC84")]
	public BookUI()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x7BBD0C", Offset = "0x7BBD0C", VA = "0x7BBD0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B8C", Offset = "0x605B8C")]
	private void <Awake>b__15_0(int pageOffset)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x7BBD38", Offset = "0x7BBD38", VA = "0x7BBD38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605B9C", Offset = "0x605B9C")]
	private void <LoadPage>b__31_0()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x7BBD3C", Offset = "0x7BBD3C", VA = "0x7BBD3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605BAC", Offset = "0x605BAC")]
	private void <LoadPage>b__31_1()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x7BBD48", Offset = "0x7BBD48", VA = "0x7BBD48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605BBC", Offset = "0x605BBC")]
	private void <LoadPage>b__31_2()
	{
	}
}
[Token(Token = "0x2000049")]
public class ChallengeBookMenuController : SingletonGameObject<ChallengeBookMenuController>
{
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScenesLoader _ScenesLoaderChallenge;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x7BE6E4", Offset = "0x7BE6E4", VA = "0x7BE6E4")]
	public void LoadChallengeLevel(int level)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x7BE754", Offset = "0x7BE754", VA = "0x7BE754")]
	public ChallengeBookMenuController()
	{
	}
}
[Token(Token = "0x200004A")]
public class ChallengeBookPaperRenderController : MonoBehaviour
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 _CameraOffset;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RenderTexture _RenderTarget;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _PageIndex;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Camera _Camera;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform mRectTransform;

	[Token(Token = "0x1700006E")]
	public int pageIndex
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7BE7A8", Offset = "0x7BE7A8", VA = "0x7BE7A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7BE7B0", Offset = "0x7BE7B0", VA = "0x7BE7B0")]
		set
		{
		}
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x7BE890", Offset = "0x7BE890", VA = "0x7BE890")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x7BE9D8", Offset = "0x7BE9D8", VA = "0x7BE9D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x7BEB3C", Offset = "0x7BEB3C", VA = "0x7BEB3C")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x7BEA78", Offset = "0x7BEA78", VA = "0x7BEA78")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x7BECDC", Offset = "0x7BECDC", VA = "0x7BECDC")]
	public ChallengeBookPaperRenderController()
	{
	}
}
[Token(Token = "0x200004B")]
public class ChallengeCatalogueList : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE6C", Offset = "0x5FFE6C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChallengeCatalogueListRow row;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ChallengeCatalogueList <>4__this;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7DA948", Offset = "0x7DA948", VA = "0x7DA948")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7DA950", Offset = "0x7DA950", VA = "0x7DA950")]
		internal void <Awake>b__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE7C", Offset = "0x5FFE7C")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<ChallengeCatalogueListRow> <>9__10_0;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<ChallengeCatalogueListRow> <>9__10_1;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7DA8BC", Offset = "0x7DA8BC", VA = "0x7DA8BC")]
		public <>c()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7DA8C4", Offset = "0x7DA8C4", VA = "0x7DA8C4")]
		internal void <Awake>b__10_0(ChallengeCatalogueListRow row)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7DA918", Offset = "0x7DA918", VA = "0x7DA918")]
		internal void <Awake>b__10_1(ChallengeCatalogueListRow row)
		{
		}
	}

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ChallengeCatalogueListRow _RowTemplate;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvents.IntEvent _OnCatalogueSelected;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _RowCountInPage;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ObjectPool<ChallengeCatalogueListRow> mPoolRows;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<ChallengeCatalogueListRow> mRows;

	[Token(Token = "0x1700006F")]
	public int rowCountInPage
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x7BED10", Offset = "0x7BED10", VA = "0x7BED10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x7BED18", Offset = "0x7BED18", VA = "0x7BED18")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public UnityEvents.IntEvent onPageSelected
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7BED20", Offset = "0x7BED20", VA = "0x7BED20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x7BED28", Offset = "0x7BED28", VA = "0x7BED28")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x7BF028", Offset = "0x7BF028", VA = "0x7BF028")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x7BF02C", Offset = "0x7BF02C", VA = "0x7BF02C")]
	private void RefreshTexts()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x7BF490", Offset = "0x7BF490", VA = "0x7BF490")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x7BF55C", Offset = "0x7BF55C", VA = "0x7BF55C")]
	private void Clear()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x7BB8AC", Offset = "0x7BB8AC", VA = "0x7BB8AC")]
	public void SetPage(int index)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x7BF6B8", Offset = "0x7BF6B8", VA = "0x7BF6B8")]
	public ChallengeCatalogueList()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x7BF740", Offset = "0x7BF740", VA = "0x7BF740")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605BCC", Offset = "0x605BCC")]
	private ChallengeCatalogueListRow <Awake>b__10_2()
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
public class ChallengeCatalogueListRow : MonoBehaviour
{
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _Button;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _TextIndex;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI _TextEntry;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image _Locker;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _Level;

	[Token(Token = "0x17000071")]
	public Button button
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7BF8CC", Offset = "0x7BF8CC", VA = "0x7BF8CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000072")]
	public TextMeshProUGUI textIndex
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7BF8D4", Offset = "0x7BF8D4", VA = "0x7BF8D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000073")]
	public TextMeshProUGUI textEntry
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x7BF8DC", Offset = "0x7BF8DC", VA = "0x7BF8DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000074")]
	public int level
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x7BF8E4", Offset = "0x7BF8E4", VA = "0x7BF8E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x7BF8EC", Offset = "0x7BF8EC", VA = "0x7BF8EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public Image locker
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7BF8F4", Offset = "0x7BF8F4", VA = "0x7BF8F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x7BF8FC", Offset = "0x7BF8FC", VA = "0x7BF8FC")]
	public ChallengeCatalogueListRow()
	{
	}
}
[Token(Token = "0x200004F")]
public class ChallengeLevelController : SingletonGameObject<ChallengeLevelController>
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE8C", Offset = "0x5FFE8C")]
	private sealed class <Load>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int levelIndex;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChallengeLevelController <>4__this;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x7DACC8", Offset = "0x7DACC8", VA = "0x7DACC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x7DAD10", Offset = "0x7DAD10", VA = "0x7DAD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x7DA9B8", Offset = "0x7DA9B8", VA = "0x7DA9B8")]
		[DebuggerHidden]
		public <Load>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x7DA9E4", Offset = "0x7DA9E4", VA = "0x7DA9E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x7DA9E8", Offset = "0x7DA9E8", VA = "0x7DA9E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x7DACD0", Offset = "0x7DACD0", VA = "0x7DACD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Paper _PaperMain;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Paper _PaperChirography;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BrushRecorder _ChallengeRecorder;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BrushRecorder _MainPaperRecorder;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioSource _PronunciationAudio;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ScenesLoader _BackScenesLoader;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float mPlayingTime;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] mScoreTextFmtKeys;

	[Token(Token = "0x17000076")]
	public Paper paperMain
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x7BF904", Offset = "0x7BF904", VA = "0x7BF904")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000077")]
	public Paper paperChirography
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7BF90C", Offset = "0x7BF90C", VA = "0x7BF90C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000078")]
	public BrushRecorder challengeRecorder
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7BF914", Offset = "0x7BF914", VA = "0x7BF914")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000079")]
	public BrushRecorder mainPaperRecorder
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x7BF91C", Offset = "0x7BF91C", VA = "0x7BF91C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007A")]
	public AudioSource pronunciationAudio
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x7BF924", Offset = "0x7BF924", VA = "0x7BF924")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007B")]
	public ScenesLoader backScenesLoader
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7BF92C", Offset = "0x7BF92C", VA = "0x7BF92C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x7BF934", Offset = "0x7BF934", VA = "0x7BF934")]
	public void PlayPronunciation()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x7BFA04", Offset = "0x7BFA04", VA = "0x7BFA04", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x7BFA88", Offset = "0x7BFA88", VA = "0x7BFA88")]
	public void Start()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x7BFC8C", Offset = "0x7BFC8C", VA = "0x7BFC8C", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x7BFE30", Offset = "0x7BFE30", VA = "0x7BFE30")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x7BFAEC", Offset = "0x7BFAEC", VA = "0x7BFAEC")]
	public void LoadLevel(int level)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x7BFEE4", Offset = "0x7BFEE4", VA = "0x7BFEE4")]
	public void ResetChirography()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x7BFE68", Offset = "0x7BFE68", VA = "0x7BFE68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x605BDC", Offset = "0x605BDC")]
	private IEnumerator Load(int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x7BB9F4", Offset = "0x7BB9F4", VA = "0x7BB9F4")]
	public static string GetScoreLevelText(float score)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x7B0A58", Offset = "0x7B0A58", VA = "0x7B0A58")]
	public static int GetScoreLevel(float score)
	{
		return default(int);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x7BF34C", Offset = "0x7BF34C", VA = "0x7BF34C")]
	public static bool GetLevelUnlocked(int level)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x7BFFF0", Offset = "0x7BFFF0", VA = "0x7BFFF0")]
	public ChallengeLevelController()
	{
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x5FFE9C", Offset = "0x5FFE9C")]
public class ChallengeLevelData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000052")]
	public class Level
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string word;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D scoreTexture;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D copybook;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip audio;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string pinyin;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string english;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int strokeCount;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x7DAD18", Offset = "0x7DAD18", VA = "0x7DAD18")]
		public Level()
		{
		}
	}

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Level[] _Levels;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _ScoreTextureAssetPathFmt;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _CopybookAssetPathFmt;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _AudioAssetPathFmt;

	[Token(Token = "0x1700007E")]
	public Level[] levels
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x7C01CC", Offset = "0x7C01CC", VA = "0x7C01CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7C01D4", Offset = "0x7C01D4", VA = "0x7C01D4")]
	public ChallengeLevelData()
	{
	}
}
[Token(Token = "0x2000053")]
public class ChallengeMainUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFEAC", Offset = "0x5FFEAC")]
	private sealed class <>c
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__16_0;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static UnityAction <>9__16_1;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static UnityAction <>9__16_2;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static UnityAction <>9__16_6;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static UnityAction <>9__16_7;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static UnityAction <>9__16_10;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7DAD80", Offset = "0x7DAD80", VA = "0x7DAD80")]
		public <>c()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x7DAD88", Offset = "0x7DAD88", VA = "0x7DAD88")]
		internal void <Start>b__16_0()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x7DADDC", Offset = "0x7DADDC", VA = "0x7DADDC")]
		internal void <Start>b__16_1()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x7DAEC0", Offset = "0x7DAEC0", VA = "0x7DAEC0")]
		internal void <Start>b__16_2()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x7DAF14", Offset = "0x7DAF14", VA = "0x7DAF14")]
		internal void <Start>b__16_6()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x7DAF98", Offset = "0x7DAF98", VA = "0x7DAF98")]
		internal void <Start>b__16_7()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x7DB01C", Offset = "0x7DB01C", VA = "0x7DB01C")]
		internal void <Start>b__16_10()
		{
		}
	}

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip[] _AudioScoreLevels;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonBack;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonReplayChirography;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button _ButtonRecordChirography;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button _ButtonCommit;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button _ButtonPronunciation;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button _ButtonNextLevel;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button _ButtonPrevLevel;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button _Button_BackToCatalogue;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button _ButtonSave;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ChallengeWordInfoUI _ChallengeWordInfoUI;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private MenuPanel _ScorePanel;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button _Button_Score_Rechallenge;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Button _Button_Score_NextLevel;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Button _Button_Score_BackToCatalogue;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int mLastLevel;

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x7C01DC", Offset = "0x7C01DC", VA = "0x7C01DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x7C09F0", Offset = "0x7C09F0", VA = "0x7C09F0")]
	public void SubmitScore(float score)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x7C1204", Offset = "0x7C1204", VA = "0x7C1204")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x7C15B8", Offset = "0x7C15B8", VA = "0x7C15B8")]
	public ChallengeMainUI()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x7C15C8", Offset = "0x7C15C8", VA = "0x7C15C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605C94", Offset = "0x605C94")]
	private void <Start>b__16_3()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x7C1660", Offset = "0x7C1660", VA = "0x7C1660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CA4", Offset = "0x605CA4")]
	private void <Start>b__16_4()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x7C1778", Offset = "0x7C1778", VA = "0x7C1778")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CB4", Offset = "0x605CB4")]
	private void <Start>b__16_5()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x7C19BC", Offset = "0x7C19BC", VA = "0x7C19BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CC4", Offset = "0x605CC4")]
	private void <Start>b__16_8()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x7C1A6C", Offset = "0x7C1A6C", VA = "0x7C1A6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CD4", Offset = "0x605CD4")]
	private void <Start>b__16_9()
	{
	}
}
[Token(Token = "0x2000055")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x5FFEBC", Offset = "0x5FFEBC")]
public class ChallengeManager : SingletonGameObject<ChallengeManager>
{
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int _CurrentLevel;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChallengeLevelData _LevelData;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602B10", Offset = "0x602B10")]
	private bool <active>k__BackingField;

	[Token(Token = "0x1700007F")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x7C1B1C", Offset = "0x7C1B1C", VA = "0x7C1B1C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000080")]
	public bool active
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x7C1B24", Offset = "0x7C1B24", VA = "0x7C1B24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CE4", Offset = "0x605CE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x7C1B2C", Offset = "0x7C1B2C", VA = "0x7C1B2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605CF4", Offset = "0x605CF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000081")]
	public int currentLevel
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x7C1B38", Offset = "0x7C1B38", VA = "0x7C1B38")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x7C1B40", Offset = "0x7C1B40", VA = "0x7C1B40")]
		set
		{
		}
	}

	[Token(Token = "0x17000082")]
	public ChallengeLevelData.Level currentLevelData
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7BF9BC", Offset = "0x7BF9BC", VA = "0x7BF9BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000083")]
	public ChallengeLevelData levelData
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x7C1B48", Offset = "0x7C1B48", VA = "0x7C1B48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7C1B50", Offset = "0x7C1B50", VA = "0x7C1B50")]
	public ChallengeManager()
	{
	}
}
[Token(Token = "0x2000056")]
public static class ChallengeSavedData
{
	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static XmlElement mDataNode;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument mDocument;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Regex mArraySpliter;

	[Token(Token = "0x17000084")]
	public static float playingTime
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x7BB7D8", Offset = "0x7BB7D8", VA = "0x7BB7D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7BFD20", Offset = "0x7BFD20", VA = "0x7BFD20")]
		set
		{
		}
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7C1BA4", Offset = "0x7C1BA4", VA = "0x7C1BA4")]
	static ChallengeSavedData()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x7C1DAC", Offset = "0x7C1DAC", VA = "0x7C1DAC")]
	private static XmlElement GetLevelElement(int levelIndex, bool create = true)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x7C1048", Offset = "0x7C1048", VA = "0x7C1048")]
	public static void AddScore(int levelIndex, float score)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x7C1144", Offset = "0x7C1144", VA = "0x7C1144")]
	public static void UnlockLevel(int levelIndex, bool unlocked = true)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x7BBBA8", Offset = "0x7BBBA8", VA = "0x7BBBA8")]
	public static bool GetLevelUnlocked(int levelIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x7B10E8", Offset = "0x7B10E8", VA = "0x7B10E8")]
	public static float[] GetScores(int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7AFD60", Offset = "0x7AFD60", VA = "0x7AFD60")]
	public static int[] GetLevels()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7BFDD4", Offset = "0x7BFDD4", VA = "0x7BFDD4")]
	public static void Save()
	{
	}
}
[Token(Token = "0x2000057")]
public class ChallengeWordInfoUI : MonoBehaviour
{
	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI _TextWord;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _TextPinyin;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI _TextEngligh;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x7C2070", Offset = "0x7C2070", VA = "0x7C2070")]
	private void Start()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x7C1828", Offset = "0x7C1828", VA = "0x7C1828")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x7C2074", Offset = "0x7C2074", VA = "0x7C2074")]
	public ChallengeWordInfoUI()
	{
	}
}
[Token(Token = "0x2000058")]
public class ChangeRayCursorUILayerWhenEnable : MonoBehaviour
{
	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, int> mDic;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x7C207C", Offset = "0x7C207C", VA = "0x7C207C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x7C24D0", Offset = "0x7C24D0", VA = "0x7C24D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x7C2688", Offset = "0x7C2688", VA = "0x7C2688")]
	public ChangeRayCursorUILayerWhenEnable()
	{
	}
}
[Token(Token = "0x2000059")]
public class Configuration
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string resourceXmlPath;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument _config;

	[Token(Token = "0x17000085")]
	private static Stream dataStream
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x7C3904", Offset = "0x7C3904", VA = "0x7C3904")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000086")]
	public static XmlDocument config
	{
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x7C3A24", Offset = "0x7C3A24", VA = "0x7C3A24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x7C3C88", Offset = "0x7C3C88", VA = "0x7C3C88")]
	public static void SaveConfig()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x7C3AC8", Offset = "0x7C3AC8", VA = "0x7C3AC8")]
	public static void Reload()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x7C3CE8", Offset = "0x7C3CE8", VA = "0x7C3CE8")]
	public Configuration()
	{
	}
}
[Token(Token = "0x200005A")]
public class ConfigurationTool : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	private class ConfigObject
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObjectConfiguration configObject;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ConfigComponent> components;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool opened;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x7DB134", Offset = "0x7DB134", VA = "0x7DB134")]
		public ConfigObject()
		{
		}
	}

	[Token(Token = "0x200005C")]
	private class ConfigComponent
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Component component;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, MemberInfo> members;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool opened;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x7DB12C", Offset = "0x7DB12C", VA = "0x7DB12C")]
		public ConfigComponent()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool mShowGUI;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ConfigObject> mObjects;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 mGUIScroll;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mLastEditCtrl;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string mLastEditedText;

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x7C3D5C", Offset = "0x7C3D5C", VA = "0x7C3D5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x7C3D60", Offset = "0x7C3D60", VA = "0x7C3D60")]
	private void InitGUI()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x7C414C", Offset = "0x7C414C", VA = "0x7C414C")]
	public void ReloadConfiguration()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x7C41A4", Offset = "0x7C41A4", VA = "0x7C41A4")]
	public void ApplyConfigurationToAllGameObject(bool includeInactive = true)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x7C4294", Offset = "0x7C4294", VA = "0x7C4294")]
	public void SaveConfig()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x7C42EC", Offset = "0x7C42EC", VA = "0x7C42EC")]
	public void SaveConfigOfAllGameObject(bool includeInactive = true)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x7C43DC", Offset = "0x7C43DC", VA = "0x7C43DC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x7C4564", Offset = "0x7C4564", VA = "0x7C4564")]
	private void WindowProc(int windowId)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x7C5324", Offset = "0x7C5324", VA = "0x7C5324")]
	private string Edit(string text)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7C5118", Offset = "0x7C5118", VA = "0x7C5118")]
	private static bool FolderButton(bool opened, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x7C54E8", Offset = "0x7C54E8", VA = "0x7C54E8")]
	public ConfigurationTool()
	{
	}
}
[Token(Token = "0x200005D")]
public class CopybookLoader : MonoBehaviour
{
	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GalleryPanel mGalleryPanel;

	[Token(Token = "0x4000133")]
	private const string _CopybookPath = "Data\\Copybooks";

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x7C54F0", Offset = "0x7C54F0", VA = "0x7C54F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x7C55EC", Offset = "0x7C55EC", VA = "0x7C55EC")]
	public CopybookLoader()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x7C55F4", Offset = "0x7C55F4", VA = "0x7C55F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605D04", Offset = "0x605D04")]
	private void <Start>b__2_0(Texture texture, string path)
	{
	}
}
[Token(Token = "0x200005E")]
public class GameObjectConfiguration : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	public delegate string OTS(object o);

	[Token(Token = "0x2000060")]
	public delegate bool STO(string s, [Out] object o);

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFEF8", Offset = "0x5FFEF8")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, MemberInfo> props;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x12D8178", Offset = "0x12D8178", VA = "0x12D8178")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x12D8180", Offset = "0x12D8180", VA = "0x12D8180")]
		internal bool <GetConfigurableMembers>b__0(MemberInfo mem, object filterCriteria)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string preferedSaveNode;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string objectId;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Type TypeInt;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Type TypeFloat;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Type TypeString;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Type TypeBool;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly Type TypeVector3;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly Type TypeQuaternion;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Type TypeColor;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly Dictionary<Type, OTS> TypeToStrings;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly Dictionary<Type, STO> StringToTypes;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly char[] ValueStringSpliter;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly Type TypeConfigurableMember;

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x81A638", Offset = "0x81A638", VA = "0x81A638")]
	static GameObjectConfiguration()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x81ACC0", Offset = "0x81ACC0", VA = "0x81ACC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x81ACC4", Offset = "0x81ACC4", VA = "0x81ACC4")]
	public void Load()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x81BBA4", Offset = "0x81BBA4", VA = "0x81BBA4")]
	public void Save()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x81BF28", Offset = "0x81BF28", VA = "0x81BF28")]
	public static XmlNode GetOrCreatePath(string path, XmlNode parent, XmlDocument xmlDocument)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x81C078", Offset = "0x81C078", VA = "0x81C078")]
	private void ApplyGameObjectConfigToNode(XmlNode objectNode, XmlDocument xmlDocument)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x81C674", Offset = "0x81C674", VA = "0x81C674")]
	private void ApplyComponentConfigToNode(Component component, XmlNode componentNode, XmlDocument xmlDocument)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x81CB44", Offset = "0x81CB44", VA = "0x81CB44")]
	public static object GetMemberValue(object obj, MemberInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x81CD48", Offset = "0x81CD48", VA = "0x81CD48")]
	public string ObjectToString(object o)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x81CE2C", Offset = "0x81CE2C", VA = "0x81CE2C")]
	public static bool TryParseValue(Type type, string value, [Out] object result)
	{
		return default(bool);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x81CF08", Offset = "0x81CF08", VA = "0x81CF08")]
	public static string Vector3ToString(object o)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x81D064", Offset = "0x81D064", VA = "0x81D064")]
	public static string QuaternionToString(object o)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x81D1EC", Offset = "0x81D1EC", VA = "0x81D1EC")]
	public static string ColorToString(object o)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x81D374", Offset = "0x81D374", VA = "0x81D374")]
	public static bool ParseInt(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x81D404", Offset = "0x81D404", VA = "0x81D404")]
	public static bool ParseFloat(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x81D494", Offset = "0x81D494", VA = "0x81D494")]
	public static bool ParseBool(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x81D544", Offset = "0x81D544", VA = "0x81D544")]
	public static bool ParseString(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x81D554", Offset = "0x81D554", VA = "0x81D554")]
	public static bool ParseVector3(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x81D6B0", Offset = "0x81D6B0", VA = "0x81D6B0")]
	public static bool ParseQuaternion(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x81D824", Offset = "0x81D824", VA = "0x81D824")]
	public static bool ParseColor(string s, [Out] object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x81C4B8", Offset = "0x81C4B8", VA = "0x81C4B8")]
	public List<Component> GetConfigurableComponents()
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x81B160", Offset = "0x81B160", VA = "0x81B160")]
	private void LoadComponentNode(XmlNode componentNode)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x81D998", Offset = "0x81D998", VA = "0x81D998")]
	private Dictionary<string, MemberInfo> GetConfigurableMembers(string type, [Out] Component comObject)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x81DBC4", Offset = "0x81DBC4", VA = "0x81DBC4")]
	public static Type GetMemberValueType(MemberInfo member)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x81CA24", Offset = "0x81CA24", VA = "0x81CA24")]
	public static Dictionary<string, MemberInfo> GetConfigurableMembers(Type comType)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x81DCC4", Offset = "0x81DCC4", VA = "0x81DCC4")]
	public static void SetMemberValue(MemberInfo member, object o, object value)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x81DE04", Offset = "0x81DE04", VA = "0x81DE04")]
	public GameObjectConfiguration()
	{
	}
}
[Token(Token = "0x2000062")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5FFF08", Offset = "0x5FFF08")]
internal sealed class ConfigurableMember : Attribute
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string mName;

	[Token(Token = "0x17000087")]
	public string Name
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7C38FC", Offset = "0x7C38FC", VA = "0x7C38FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x7C38D0", Offset = "0x7C38D0", VA = "0x7C38D0")]
	public ConfigurableMember(string name)
	{
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5FFF40", Offset = "0x5FFF40")]
internal sealed class ConfigurableComponent : Attribute
{
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x7C38C8", Offset = "0x7C38C8", VA = "0x7C38C8")]
	public ConfigurableComponent()
	{
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x5FFF78", Offset = "0x5FFF78")]
public class InternalSeals : ScriptableObject
{
	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Texture> _Textures;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static InternalSeals sInternalSeals;

	[Token(Token = "0x17000088")]
	public IReadOnlyList<Texture> textures
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8B3E9C", Offset = "0x8B3E9C", VA = "0x8B3E9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000089")]
	public static InternalSeals instance
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8B3EA4", Offset = "0x8B3EA4", VA = "0x8B3EA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x8B3F84", Offset = "0x8B3F84", VA = "0x8B3F84")]
	public InternalSeals()
	{
	}
}
[Token(Token = "0x2000065")]
public static class SavedXmlData
{
	[Token(Token = "0x2000066")]
	private class FileSteamWarpper : FileStream
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte[] mBuffer;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x12DD458", Offset = "0x12DD458", VA = "0x12DD458")]
		public FileSteamWarpper(string path, FileMode mode)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x12DD4DC", Offset = "0x12DD4DC", VA = "0x12DD4DC", Slot = "28")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x12DD500", Offset = "0x12DD500", VA = "0x12DD500", Slot = "27")]
		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x12DD580", Offset = "0x12DD580", VA = "0x12DD580", Slot = "29")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x12DD688", Offset = "0x12DD688", VA = "0x12DD688", Slot = "30")]
		public override void WriteByte(byte value)
		{
		}
	}

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument mDocument;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string mDataPath;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string mUser;

	[Token(Token = "0x1700008A")]
	private static bool saveAsEncoded
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x12D185C", Offset = "0x12D185C", VA = "0x12D185C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700008B")]
	public static string user
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x12D1864", Offset = "0x12D1864", VA = "0x12D1864")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008C")]
	public static XmlElement root
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x12D1ADC", Offset = "0x12D1ADC", VA = "0x12D1ADC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008D")]
	public static XmlDocument document
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x12D1B44", Offset = "0x12D1B44", VA = "0x12D1B44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action onSavingData
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x12D1674", Offset = "0x12D1674", VA = "0x12D1674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605D14", Offset = "0x605D14")]
		add
		{
		}
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x12D1768", Offset = "0x12D1768", VA = "0x12D1768")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605D24", Offset = "0x605D24")]
		remove
		{
		}
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x12D18C8", Offset = "0x12D18C8", VA = "0x12D18C8")]
	public static void SetUser(string user)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x12D2160", Offset = "0x12D2160", VA = "0x12D2160")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x12D2004", Offset = "0x12D2004", VA = "0x12D2004")]
	private static Stream GetDataSteam(string path, bool save)
	{
		return null;
	}
}
[Token(Token = "0x2000067")]
public class StreamingAssetsUtil
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IReadOnlyCollection<string> _androidAssets;

	[Token(Token = "0x1700008E")]
	public static bool isAndroidDevice
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7C7934", Offset = "0x7C7934", VA = "0x7C7934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700008F")]
	public static IReadOnlyCollection<string> androidAssets
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x7C79E4", Offset = "0x7C79E4", VA = "0x7C79E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x7C77EC", Offset = "0x7C77EC", VA = "0x7C77EC")]
	public static string GetAssetUrl(string assetName)
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x7C786C", Offset = "0x7C786C", VA = "0x7C786C")]
	public static string GetAssetPath(string assetName)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x7C7954", Offset = "0x7C7954", VA = "0x7C7954")]
	public static bool IsAssetExists(string assetName)
	{
		return default(bool);
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x7C80DC", Offset = "0x7C80DC", VA = "0x7C80DC")]
	public static List<string> ListAssetNames(string path, [Optional] Func<string, bool> matcher)
	{
		return null;
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x7C85A0", Offset = "0x7C85A0", VA = "0x7C85A0")]
	public StreamingAssetsUtil()
	{
	}
}
[Token(Token = "0x2000068")]
[ConfigurableComponent]
public class TransformConf : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _targetObject;

	[Token(Token = "0x17000090")]
	public GameObject targetObject
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7CC028", Offset = "0x7CC028", VA = "0x7CC028")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7CC0C0", Offset = "0x7CC0C0", VA = "0x7CC0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000091")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607DB8", Offset = "0x607DB8")]
	public Vector3 localPosition
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7CC0C8", Offset = "0x7CC0C8", VA = "0x7CC0C8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7CC0F4", Offset = "0x7CC0F4", VA = "0x7CC0F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000092")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607DF0", Offset = "0x607DF0")]
	public Quaternion localRotation
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7CC148", Offset = "0x7CC148", VA = "0x7CC148")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7CC174", Offset = "0x7CC174", VA = "0x7CC174")]
		set
		{
		}
	}

	[Token(Token = "0x17000093")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607E28", Offset = "0x607E28")]
	public Vector3 localScale
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7CC1D0", Offset = "0x7CC1D0", VA = "0x7CC1D0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x7CC1FC", Offset = "0x7CC1FC", VA = "0x7CC1FC")]
		set
		{
		}
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7CC250", Offset = "0x7CC250", VA = "0x7CC250")]
	public TransformConf()
	{
	}
}
[Token(Token = "0x2000069")]
public class DebugToastMessage
{
	[Token(Token = "0x200006A")]
	private class Controller : MonoBehaviour
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x12D6658", Offset = "0x12D6658", VA = "0x12D6658")]
		public Controller()
		{
		}
	}

	[Token(Token = "0x200006B")]
	private class ToastTask
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x12D6660", Offset = "0x12D6660", VA = "0x12D6660")]
		public ToastTask()
		{
		}
	}

	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFFD4", Offset = "0x5FFFD4")]
	private sealed class <ShowUntil0>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<bool> until;

		[Token(Token = "0x17000094")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x12D6608", Offset = "0x12D6608", VA = "0x12D6608", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x12D6650", Offset = "0x12D6650", VA = "0x12D6650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x12D64A8", Offset = "0x12D64A8", VA = "0x12D64A8")]
		[DebuggerHidden]
		public <ShowUntil0>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x12D64D4", Offset = "0x12D64D4", VA = "0x12D64D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x12D64D8", Offset = "0x12D64D8", VA = "0x12D64D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x12D6610", Offset = "0x12D6610", VA = "0x12D6610", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFFE4", Offset = "0x5FFFE4")]
	private sealed class <QueueTask>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ToastTask <task>5__2;

		[Token(Token = "0x17000096")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x12D6458", Offset = "0x12D6458", VA = "0x12D6458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x12D64A0", Offset = "0x12D64A0", VA = "0x12D64A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x12D61B0", Offset = "0x12D61B0", VA = "0x12D61B0")]
		[DebuggerHidden]
		public <QueueTask>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x12D61DC", Offset = "0x12D61DC", VA = "0x12D61DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x12D61E0", Offset = "0x12D61E0", VA = "0x12D61E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x12D6460", Offset = "0x12D6460", VA = "0x12D6460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float defaultPlaneDistance;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int defaultCanvasSortOrder;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float defaultMessagPanelWidth;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int defaultFontSize;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static GameObject controller;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Queue<ToastTask> canvasList;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x7C5834", Offset = "0x7C5834", VA = "0x7C5834")]
	public static void SetOverlayWorldCamera(Canvas canvas, Camera camera)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x7C5A14", Offset = "0x7C5A14", VA = "0x7C5A14")]
	public static GameObject CreatMessage(string text, [Optional] Camera camera)
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x7C5F10", Offset = "0x7C5F10", VA = "0x7C5F10")]
	public static void ShowMessage(string text, float time = 2f, [Optional] Camera camera)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x7C60A4", Offset = "0x7C60A4", VA = "0x7C60A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x605D34", Offset = "0x605D34")]
	private static IEnumerator ShowUntil0(GameObject gameObject, Func<bool> until)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x7C611C", Offset = "0x7C611C", VA = "0x7C611C")]
	public static float ActiveWithAnimation(GameObject gameObject, string aniName = "ToastIn")
	{
		return default(float);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7C6248", Offset = "0x7C6248", VA = "0x7C6248")]
	public static void DestroyWithAnimation(GameObject gameObject, string aniName = "ToastOut")
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7C63C8", Offset = "0x7C63C8", VA = "0x7C63C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x605D9C", Offset = "0x605D9C")]
	private static IEnumerator QueueTask()
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x7C6424", Offset = "0x7C6424", VA = "0x7C6424")]
	private static void InitController()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x7C5FB4", Offset = "0x7C5FB4", VA = "0x7C5FB4")]
	public static void ShowCanvas(GameObject canvasObject, float time)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x7C6580", Offset = "0x7C6580", VA = "0x7C6580")]
	public static void ShowUntil(GameObject canvasObject, Func<bool> until)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x7C663C", Offset = "0x7C663C", VA = "0x7C663C")]
	public DebugToastMessage()
	{
	}
}
[Token(Token = "0x200006E")]
public class FPSDisplayer : MonoBehaviour
{
	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int mCount;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mDeltaTime;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float mDPS;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x811ADC", Offset = "0x811ADC", VA = "0x811ADC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x811B70", Offset = "0x811B70", VA = "0x811B70")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x811C8C", Offset = "0x811C8C", VA = "0x811C8C")]
	public FPSDisplayer()
	{
	}
}
[Token(Token = "0x200006F")]
public class PlatformSelectorPreprocesser : DocumentLayoutXmlLoader.IDocumentPreprocesser
{
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFFF4", Offset = "0x5FFFF4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool falied;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x12DCD98", Offset = "0x12DCD98", VA = "0x12DCD98")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x12DCDA0", Offset = "0x12DCDA0", VA = "0x12DCDA0")]
		internal void <Preprocess>b__0(string runtimePlatform)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x12DCDE0", Offset = "0x12DCDE0", VA = "0x12DCDE0")]
		internal void <Preprocess>b__1(string vrPlatformRegex)
		{
		}
	}

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _runtimePlatform;

	[Token(Token = "0x17000098")]
	private static string runtimePlatform
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x12CD0DC", Offset = "0x12CD0DC", VA = "0x12CD0DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x12CCF24", Offset = "0x12CCF24", VA = "0x12CCF24", Slot = "4")]
	public bool Preprocess(DocumentLayoutXmlLoader loader, XmlNode node, DocumentLayoutXmlLoader.StyleAttributs style)
	{
		return default(bool);
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x12CD28C", Offset = "0x12CD28C", VA = "0x12CD28C")]
	public PlatformSelectorPreprocesser()
	{
	}
}
[Token(Token = "0x2000071")]
public static class Extensions
{
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x8117CC", Offset = "0x8117CC", VA = "0x8117CC")]
	public static bool IsInOrToState(this Animator animator, string name, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x811890", Offset = "0x811890", VA = "0x811890")]
	public static bool IsInOrToState(this Animator animator, int nameHash, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x811954", Offset = "0x811954", VA = "0x811954")]
	public static bool IsInOrToStateByTag(this Animator animator, string tag, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x811A18", Offset = "0x811A18", VA = "0x811A18")]
	public static bool IsInOrToStateByTag(this Animator animator, int tagHash, int layer = 0)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000072")]
public class FileUtils
{
	[Token(Token = "0x2000073")]
	public enum MediaType
	{
		[Token(Token = "0x4000164")]
		SavedMyWorks = 1,
		[Token(Token = "0x4000165")]
		UserMusic,
		[Token(Token = "0x4000166")]
		SavedChallengeWorks,
		[Token(Token = "0x4000167")]
		UserPictures,
		[Token(Token = "0x4000168")]
		Seals
	}

	[Token(Token = "0x4000160")]
	public const string AppSubfolder = "YouCalligrapher";

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PermissionCallbacks sPermissionCallbacks;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool sPermissionStorageWriteDenied;

	[Token(Token = "0x17000099")]
	private static PermissionCallbacks permissionCallbacks
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8159FC", Offset = "0x8159FC", VA = "0x8159FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	private static string oldMyWorksDirectory
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x816118", Offset = "0x816118", VA = "0x816118")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x814CDC", Offset = "0x814CDC", VA = "0x814CDC")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x605EE4", Offset = "0x605EE4")]
	private static void CreateMediaFolders()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x815318", Offset = "0x815318", VA = "0x815318")]
	public static bool SaveTextureToFile(Texture2D tex, string path, MediaType mediaType)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x815860", Offset = "0x815860", VA = "0x815860")]
	private static void GetPermission()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x815BB8", Offset = "0x815BB8", VA = "0x815BB8")]
	private static void SPermissionCallbacks_PermissionDeniedAndDontAskAgain(string obj)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x815C58", Offset = "0x815C58", VA = "0x815C58")]
	private static void SPermissionCallbacks_PermissionGranted(string obj)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x815CF4", Offset = "0x815CF4", VA = "0x815CF4")]
	private static void SPermissionCallbacks_PermissionDenied(string obj)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x81516C", Offset = "0x81516C", VA = "0x81516C")]
	public static string[] GetMediaDirectory(MediaType type)
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x815D94", Offset = "0x815D94", VA = "0x815D94")]
	public static string GetExternalStorageDirectory()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x815FF0", Offset = "0x815FF0", VA = "0x815FF0")]
	private static string GetMediaSubfolder(MediaType type)
	{
		return null;
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x816448", Offset = "0x816448", VA = "0x816448")]
	public static string[] FindPictures(MediaType mediaType)
	{
		return null;
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x816924", Offset = "0x816924", VA = "0x816924")]
	private static bool IsImageFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x8169E8", Offset = "0x8169E8", VA = "0x8169E8")]
	public FileUtils()
	{
	}
}
[Token(Token = "0x2000074")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x600014", Offset = "0x600014")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600014", Offset = "0x600014")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x600014", Offset = "0x600014")]
public class GameController : SingletonGameObject<GameController>
{
	[Token(Token = "0x2000075")]
	public enum TutorialOption
	{
		[Token(Token = "0x4000171")]
		Tutorial,
		[Token(Token = "0x4000172")]
		Normal
	}

	[Token(Token = "0x2000076")]
	public enum StartMenuOption
	{
		[Token(Token = "0x4000174")]
		First,
		[Token(Token = "0x4000175")]
		Normal,
		[Token(Token = "0x4000176")]
		OpenBookMenu
	}

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x602B80", Offset = "0x602B80")]
	private string _LoadLocalGameObjectResource;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TutorialOption _tutorialOption;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private StartMenuOption _startMenuOption;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602BEC", Offset = "0x602BEC")]
	private BrushRecorder <activeRecordingRecorder>k__BackingField;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602BFC", Offset = "0x602BFC")]
	private Paper <mainPaper>k__BackingField;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameLanguageContext mGameLanguageContext;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float mLongF12Press;

	[Token(Token = "0x1700009B")]
	public TutorialOption tutorialOption
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x819598", Offset = "0x819598", VA = "0x819598")]
		get
		{
			return default(TutorialOption);
		}
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8195A0", Offset = "0x8195A0", VA = "0x8195A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8195A8", Offset = "0x8195A8", VA = "0x8195A8", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700009D")]
	public StartMenuOption startMenuOption
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8195B0", Offset = "0x8195B0", VA = "0x8195B0")]
		get
		{
			return default(StartMenuOption);
		}
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8195B8", Offset = "0x8195B8", VA = "0x8195B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public bool settings_IsEnterTutorial
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8195C0", Offset = "0x8195C0", VA = "0x8195C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x819688", Offset = "0x819688", VA = "0x819688")]
		set
		{
		}
	}

	[Token(Token = "0x1700009F")]
	public BrushRecorder activeRecordingRecorder
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x819748", Offset = "0x819748", VA = "0x819748")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605EF8", Offset = "0x605EF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x819750", Offset = "0x819750", VA = "0x819750")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605F08", Offset = "0x605F08")]
		set
		{
		}
	}

	[Token(Token = "0x170000A0")]
	public Paper mainPaper
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x819758", Offset = "0x819758", VA = "0x819758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605F18", Offset = "0x605F18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x819760", Offset = "0x819760", VA = "0x819760")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605F28", Offset = "0x605F28")]
		set
		{
		}
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x819768", Offset = "0x819768", VA = "0x819768", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x819920", Offset = "0x819920", VA = "0x819920")]
	public void ClearPaper(Paper paper)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x819A0C", Offset = "0x819A0C", VA = "0x819A0C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x819C34", Offset = "0x819C34", VA = "0x819C34")]
	public GameController()
	{
	}
}
[Token(Token = "0x2000077")]
public class GameEventHandler
{
	[Token(Token = "0x2000078")]
	public delegate bool OnMessage(GameMessageType msgType, int what, params object[] args);

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameEventHandler mHandler;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<OnMessage>[] mLisnters;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<OnMessage> mLisnersAll;

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x819C88", Offset = "0x819C88", VA = "0x819C88")]
	public static void RegisterListner(OnMessage handler, GameMessageType msgType)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x819E98", Offset = "0x819E98", VA = "0x819E98")]
	public static bool UnregisterListner(OnMessage handler, GameMessageType msgType)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x80F0F4", Offset = "0x80F0F4", VA = "0x80F0F4")]
	public static void SendMessage(GameMessageType msgType, int what, params object[] args)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x819F68", Offset = "0x819F68", VA = "0x819F68")]
	public static void ClearAllListner()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x819DEC", Offset = "0x819DEC", VA = "0x819DEC")]
	public GameEventHandler()
	{
	}
}
[Token(Token = "0x2000079")]
public enum GameMessageType : byte
{
	[Token(Token = "0x400017B")]
	All,
	[Token(Token = "0x400017C")]
	Default,
	[Token(Token = "0x400017D")]
	Character,
	[Token(Token = "0x400017E")]
	Level,
	[Token(Token = "0x400017F")]
	System
}
[Token(Token = "0x200007A")]
public class MsgLevel
{
	[Token(Token = "0x4000180")]
	public const int Item_Picked = 1;

	[Token(Token = "0x4000181")]
	public const int Item_Droped = 2;

	[Token(Token = "0x4000182")]
	public const int BrushUpdated = 3;

	[Token(Token = "0x4000183")]
	public const int SealPainted = 4;

	[Token(Token = "0x4000184")]
	public const int ArtsSaved = 5;

	[Token(Token = "0x4000185")]
	public const int PanelOpen = 6;

	[Token(Token = "0x4000186")]
	public const int PanelClose = 7;

	[Token(Token = "0x4000187")]
	public const int CopybookApplied = 8;

	[Token(Token = "0x4000188")]
	public const int PaperCleared = 9;

	[Token(Token = "0x4000189")]
	public const int DeskHeightAdjusted = 10;

	[Token(Token = "0x400018A")]
	public const int PaperUndo = 11;

	[Token(Token = "0x400018B")]
	public const int PaperRedo = 12;

	[Token(Token = "0x400018C")]
	public const int InkGrinding = 13;

	[Token(Token = "0x400018D")]
	public const int Challenge_Level_Completed = 101;

	[Token(Token = "0x400018E")]
	public const int Tutorial_Completed = 201;

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x8C0024", Offset = "0x8C0024", VA = "0x8C0024")]
	public MsgLevel()
	{
	}
}
[Token(Token = "0x200007B")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x6000C0", Offset = "0x6000C0")]
public class GameLanguageContext : MonoBehaviour, LanguageUtils.IPropertes, IEnumerable<string>, IEnumerable
{
	[Serializable]
	[Token(Token = "0x200007C")]
	private class Config
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public class Value
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string value;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Multiline]
			public string controllerRegex;

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x12DF0AC", Offset = "0x12DF0AC", VA = "0x12DF0AC")]
			public Value()
			{
			}
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string languageKey;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string defaultValue;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Value[] values;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x12D8170", Offset = "0x12D8170", VA = "0x12D8170")]
		public Config()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6000D4", Offset = "0x6000D4")]
	private sealed class <GetEnumerator>d__8 : IEnumerator<string>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string <>2__current;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameLanguageContext <>4__this;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator <>7__wrap1;

		[Token(Token = "0x170000A1")]
		private string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x12D8120", Offset = "0x12D8120", VA = "0x12D8120", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x12D8168", Offset = "0x12D8168", VA = "0x12D8168", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x12D7D6C", Offset = "0x12D7D6C", VA = "0x12D7D6C")]
		[DebuggerHidden]
		public <GetEnumerator>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x12D7D98", Offset = "0x12D7D98", VA = "0x12D7D98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x12D7E80", Offset = "0x12D7E80", VA = "0x12D7E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12D7DB4", Offset = "0x12D7DB4", VA = "0x12D7DB4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x12D8128", Offset = "0x12D8128", VA = "0x12D8128", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RuntimePlatform _TestRuntimePlatform;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Config[] _Configs;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hashtable mProperties;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mCurrentHandControllerType;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x819FB4", Offset = "0x819FB4", VA = "0x819FB4", Slot = "4")]
	public string GetString(string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x819FF4", Offset = "0x819FF4", VA = "0x819FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x81A2B8", Offset = "0x81A2B8", VA = "0x81A2B8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x81A524", Offset = "0x81A524", VA = "0x81A524")]
	public void SetObject(string key, object obj)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x81A54C", Offset = "0x81A54C", VA = "0x81A54C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x605F38", Offset = "0x605F38")]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x81A5C0", Offset = "0x81A5C0", VA = "0x81A5C0", Slot = "6")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x81A5C4", Offset = "0x81A5C4", VA = "0x81A5C4")]
	public GameLanguageContext()
	{
	}
}
[Token(Token = "0x200007F")]
public class GamePadHighliter : MonoBehaviour
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color hightlightColor;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material highlightMaterial;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject targetObject;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve curve;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material mLastMaterial;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject mLastObject;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float mCurrentTime;

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x81DE60", Offset = "0x81DE60", VA = "0x81DE60")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x81E0DC", Offset = "0x81E0DC", VA = "0x81E0DC")]
	private void RemoveHighlight(GameObject o)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x81E314", Offset = "0x81E314", VA = "0x81E314")]
	private void AddHighlight(GameObject o)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x81E570", Offset = "0x81E570", VA = "0x81E570")]
	public GamePadHighliter()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x81E5A4", Offset = "0x81E5A4", VA = "0x81E5A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605FF0", Offset = "0x605FF0")]
	private bool <RemoveHighlight>b__8_0(Material m)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x81E61C", Offset = "0x81E61C", VA = "0x81E61C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606000", Offset = "0x606000")]
	private bool <AddHighlight>b__9_0(Material m)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000080")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6000E4", Offset = "0x6000E4")]
public class Grader : MonoBehaviour
{
	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public KeyCode printGradeKey;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Paper mPaper;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GalleryPanel.PaperConent mSelectedPaper;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mWordsMaskFileUrl;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool mWordsMaskFileUrlExists;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Texture2D mMaskTexure;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool mIsLoadedTexture;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Material blit;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material _ClonedMaterial;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RenderTexture mTmpRenderTexture;

	[Token(Token = "0x170000A3")]
	public Texture2D maskTexture
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x81E9C0", Offset = "0x81E9C0", VA = "0x81E9C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A4")]
	public Material Blit
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x81E9C8", Offset = "0x81E9C8", VA = "0x81E9C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A5")]
	public bool canCalScore
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x81EFE4", Offset = "0x81EFE4", VA = "0x81EFE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x81E90C", Offset = "0x81E90C", VA = "0x81E90C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x81E9BC", Offset = "0x81E9BC", VA = "0x81E9BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x81EAAC", Offset = "0x81EAAC", VA = "0x81EAAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x81EBB8", Offset = "0x81EBB8", VA = "0x81EBB8")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x81ECB4", Offset = "0x81ECB4", VA = "0x81ECB4")]
	public void SetMaskTexture(Texture2D texture)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x81ED68", Offset = "0x81ED68", VA = "0x81ED68")]
	public RenderTexture OnRenderPaperImage(RenderTexture source)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x81EF08", Offset = "0x81EF08", VA = "0x81EF08")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x81F058", Offset = "0x81F058", VA = "0x81F058")]
	public float CalScore(bool debug = false)
	{
		return default(float);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x81F188", Offset = "0x81F188", VA = "0x81F188")]
	public static float CalScore(Texture2D mask, RenderTexture render, bool debug = false)
	{
		return default(float);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x81F5D8", Offset = "0x81F5D8", VA = "0x81F5D8")]
	private static void SetTextureColor(Texture2D texture, float x, float y, Color color)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x81F720", Offset = "0x81F720", VA = "0x81F720")]
	private static void BlendTextureColor(Texture2D texture, int x, int y, Color color)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x81F804", Offset = "0x81F804", VA = "0x81F804")]
	public void OnEndRender()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x81F88C", Offset = "0x81F88C", VA = "0x81F88C")]
	public Grader()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x81F894", Offset = "0x81F894", VA = "0x81F894")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606010", Offset = "0x606010")]
	private void <OnMessage>b__16_0(UnityWebRequest request, DownloadHandlerTexture handler)
	{
	}
}
[Token(Token = "0x2000081")]
public class HandController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000082")]
	private class Events
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VRHandInput.Button clear;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public VRHandInput.Button undoOrRecording;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRHandInput.Button redo;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x12D8874", Offset = "0x12D8874", VA = "0x12D8874")]
		public Events()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000083")]
	private struct AudioData
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AudioClip undo;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip redo;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip clear;
	}

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioData _Audios;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Events _Events;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _DefaultAnimationTrigger;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _HandModel;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _DefaultHandPosition;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _HindController;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _DefaultPaper;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private FeatherBrush mBrush;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private VRVirtualBody mHand;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private VRControllerMananger mControllerMananger;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform mCurrentPos;

	[Token(Token = "0x170000A6")]
	public GameObject handModel
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x8214B8", Offset = "0x8214B8", VA = "0x8214B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x820E84", Offset = "0x820E84", VA = "0x820E84")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x820EE4", Offset = "0x820EE4", VA = "0x820EE4")]
	private void OnItemPicked(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x820F5C", Offset = "0x820F5C", VA = "0x820F5C")]
	private void OnItemDroped(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x820F60", Offset = "0x820F60", VA = "0x820F60")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x80EC9C", Offset = "0x80EC9C", VA = "0x80EC9C")]
	public void SetCustomState(string animationTrigger, string handPosition)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x80ED6C", Offset = "0x80ED6C", VA = "0x80ED6C")]
	public void SetIdleState()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x821104", Offset = "0x821104", VA = "0x821104")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x8211A8", Offset = "0x8211A8", VA = "0x8211A8")]
	private void ProcessEvents()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x8214C0", Offset = "0x8214C0", VA = "0x8214C0")]
	private Paper GetTargetPaper()
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x821638", Offset = "0x821638", VA = "0x821638")]
	public HandController()
	{
	}
}
[Token(Token = "0x2000084")]
public class InteractionHand : InteractableHandler
{
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x8B3E94", Offset = "0x8B3E94", VA = "0x8B3E94")]
	public InteractionHand()
	{
	}
}
[Token(Token = "0x2000085")]
public class InkStick : InteractableHandler
{
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _RayTranform;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _RayDistance;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private LayerMask _TargetLayer;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private VRVirtualBody mHand;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private InkStickGroundable mInkStickGroundable;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private InteractableObject mCurrentObject;

	[Token(Token = "0x170000A7")]
	public VRVirtualBody currentHand
	{
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x8B10AC", Offset = "0x8B10AC", VA = "0x8B10AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x8B10B4", Offset = "0x8B10B4", VA = "0x8B10B4")]
		set
		{
		}
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x8B1048", Offset = "0x8B1048", VA = "0x8B1048")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x8B10A4", Offset = "0x8B10A4", VA = "0x8B10A4")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x8B10BC", Offset = "0x8B10BC", VA = "0x8B10BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x8B135C", Offset = "0x8B135C", VA = "0x8B135C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8B1488", Offset = "0x8B1488", VA = "0x8B1488")]
	public InkStick()
	{
	}
}
[Token(Token = "0x2000086")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60014C", Offset = "0x60014C")]
public class InkStickGroundable : InteractableObject
{
	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip _AudioGriding;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Renderer _InkAera;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ColorPalette _ColorPalette;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color _NotGrindedColor;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color _GrindedColor;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _GrindingSpeed;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 mLastHandPos;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private VRHandInput mCatchedInput;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602D5C", Offset = "0x602D5C")]
	private float <handSpeed>k__BackingField;

	[Token(Token = "0x170000A8")]
	public ColorPalette colorPalette
	{
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x8B15B8", Offset = "0x8B15B8", VA = "0x8B15B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A9")]
	public float handSpeed
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8B15C0", Offset = "0x8B15C0", VA = "0x8B15C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606020", Offset = "0x606020")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8B15C8", Offset = "0x8B15C8", VA = "0x8B15C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606030", Offset = "0x606030")]
		private set
		{
		}
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8B149C", Offset = "0x8B149C", VA = "0x8B149C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x8B14F8", Offset = "0x8B14F8", VA = "0x8B14F8", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x8B153C", Offset = "0x8B153C", VA = "0x8B153C", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x8B15D0", Offset = "0x8B15D0", VA = "0x8B15D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x8B1B00", Offset = "0x8B1B00", VA = "0x8B1B00")]
	public InkStickGroundable()
	{
	}
}
[Token(Token = "0x2000087")]
public class LaserController : MonoBehaviour
{
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float forwardMin;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float forwardMax;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRDefaultCursor target;

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x8B4A50", Offset = "0x8B4A50", VA = "0x8B4A50")]
	private void Update()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x8B4B64", Offset = "0x8B4B64", VA = "0x8B4B64")]
	public LaserController()
	{
	}
}
[Token(Token = "0x2000088")]
public class LogoManager : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6001B4", Offset = "0x6001B4")]
	private sealed class <StartLogo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LogoManager <>4__this;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation <animation>5__2;

		[Token(Token = "0x170000AA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x12D9EA0", Offset = "0x12D9EA0", VA = "0x12D9EA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x12D9EE8", Offset = "0x12D9EE8", VA = "0x12D9EE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12D9BD4", Offset = "0x12D9BD4", VA = "0x12D9BD4")]
		[DebuggerHidden]
		public <StartLogo>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x12D9C00", Offset = "0x12D9C00", VA = "0x12D9C00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12D9C04", Offset = "0x12D9C04", VA = "0x12D9C04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12D9EA8", Offset = "0x12D9EA8", VA = "0x12D9EA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x8B7ED4", Offset = "0x8B7ED4", VA = "0x8B7ED4")]
	private void Start()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x8B7F00", Offset = "0x8B7F00", VA = "0x8B7F00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606040", Offset = "0x606040")]
	private IEnumerator StartLogo()
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x8B7F74", Offset = "0x8B7F74", VA = "0x8B7F74")]
	public LogoManager()
	{
	}
}
[Token(Token = "0x200008A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6001C4", Offset = "0x6001C4")]
[ExecuteInEditMode]
public class LogoSpriteAnimation : MonoBehaviour
{
	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite[] _Sprites;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x602D7C", Offset = "0x602D7C")]
	private float _NormalizedTime;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SpriteRenderer mSpriteRenderer;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x8B7F7C", Offset = "0x8B7F7C", VA = "0x8B7F7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x8B7FD8", Offset = "0x8B7FD8", VA = "0x8B7FD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x8B81C4", Offset = "0x8B81C4", VA = "0x8B81C4")]
	public LogoSpriteAnimation()
	{
	}
}
[Token(Token = "0x200008B")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60023C", Offset = "0x60023C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60023C", Offset = "0x60023C")]
public class MeshLineRenderer : MonoBehaviour
{
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material lMat;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh ml;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 s;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lineSize;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool firstQuad;

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x8BAEC0", Offset = "0x8BAEC0", VA = "0x8BAEC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x8BAF58", Offset = "0x8BAF58", VA = "0x8BAF58")]
	private void Update()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x8BAF5C", Offset = "0x8BAF5C", VA = "0x8BAF5C")]
	public void setWidth(float lineSize)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x8BAF64", Offset = "0x8BAF64", VA = "0x8BAF64")]
	public void AddPoint(Vector3 point)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x8BB018", Offset = "0x8BB018", VA = "0x8BB018")]
	private Vector3[] MakeQuad(Vector3 s, Vector3 e, float w, bool all)
	{
		return null;
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x8BB2EC", Offset = "0x8BB2EC", VA = "0x8BB2EC")]
	private void AddLine(Mesh m, Vector3[] quad)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x8BB824", Offset = "0x8BB824", VA = "0x8BB824")]
	private Vector3[] resizeVectices(Vector3[] ovs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x8BB8EC", Offset = "0x8BB8EC", VA = "0x8BB8EC")]
	private Vector2[] resizeUVs(Vector2[] uvs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x8BB9AC", Offset = "0x8BB9AC", VA = "0x8BB9AC")]
	private int[] resizeTriangles(int[] ovs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8BBA6C", Offset = "0x8BBA6C", VA = "0x8BBA6C")]
	public MeshLineRenderer()
	{
	}
}
[Token(Token = "0x200008C")]
public class MouseLineRenderer : MonoBehaviour
{
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> positions;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera mainCamera;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rect canvasRect;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool leftMousePressed;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x8BBA88", Offset = "0x8BBA88", VA = "0x8BBA88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x8BBAEC", Offset = "0x8BBAEC", VA = "0x8BBAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x8BBCE0", Offset = "0x8BBCE0", VA = "0x8BBCE0")]
	private LineRenderer createLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x8BBE48", Offset = "0x8BBE48", VA = "0x8BBE48")]
	private void moveCameraWithRightMouse()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x8BBFC0", Offset = "0x8BBFC0", VA = "0x8BBFC0")]
	public MouseLineRenderer()
	{
	}
}
[Token(Token = "0x200008D")]
public class MouseTrailRenderer : MonoBehaviour
{
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x8BBFC8", Offset = "0x8BBFC8", VA = "0x8BBFC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x8BBFCC", Offset = "0x8BBFCC", VA = "0x8BBFCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x8BC180", Offset = "0x8BC180", VA = "0x8BC180")]
	public MouseTrailRenderer()
	{
	}
}
[Token(Token = "0x200008E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6002D8", Offset = "0x6002D8")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x6002D8", Offset = "0x6002D8")]
public class MusicPlayer : SingletonGameObject<MusicPlayer>, MediaPlayerController.MediaPlayer
{
	[Serializable]
	[Token(Token = "0x200008F")]
	public class MusicInfo
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[NonSerialized]
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string loadedUrl;

		[NonSerialized]
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isLoadedExternal;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x12DAAF8", Offset = "0x12DAAF8", VA = "0x12DAAF8")]
		public MusicInfo()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600368", Offset = "0x600368")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicPlayer <>4__this;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicInfo music;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x12DA778", Offset = "0x12DA778", VA = "0x12DA778")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x12DA780", Offset = "0x12DA780", VA = "0x12DA780")]
		internal void <Play>b__0(UnityWebRequest request, DownloadHandlerAudioClip handler)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600378", Offset = "0x600378")]
	private sealed class <>c
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<UnityWebRequest, DownloadHandlerAudioClip> <>9__23_0;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<MusicInfo> <>9__30_0;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x12DA740", Offset = "0x12DA740", VA = "0x12DA740")]
		public <>c()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x12DA748", Offset = "0x12DA748", VA = "0x12DA748")]
		internal void <set_isPlaying>b__23_0(UnityWebRequest request, DownloadHandlerAudioClip handler)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x12DA74C", Offset = "0x12DA74C", VA = "0x12DA74C")]
		internal int <FindAllUserMusicInfo>b__30_0(MusicInfo x, MusicInfo y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<MusicInfo> clips;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float volumeStep;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602DBC", Offset = "0x602DBC")]
	public bool autoPlay;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool dontPlayInEditor;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool _DontDestroyOnLoad;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602DF4", Offset = "0x602DF4")]
	private MusicInfo <currentPlaying>k__BackingField;

	[Token(Token = "0x170000AC")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x8C13E0", Offset = "0x8C13E0", VA = "0x8C13E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000AD")]
	private int currentClipIndex
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x8C13E8", Offset = "0x8C13E8", VA = "0x8C13E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AE")]
	public MusicInfo currentPlaying
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8C1454", Offset = "0x8C1454", VA = "0x8C1454")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6060F8", Offset = "0x6060F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x8C145C", Offset = "0x8C145C", VA = "0x8C145C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606108", Offset = "0x606108")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AF")]
	public bool isPlaying
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8C0B94", Offset = "0x8C0B94", VA = "0x8C0B94", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x8C0D74", Offset = "0x8C0D74", VA = "0x8C0D74", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x170000B0")]
	private AudioSource audioSource
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8C0CCC", Offset = "0x8C0CCC", VA = "0x8C0CCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B1")]
	public bool isPaused
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8C19A0", Offset = "0x8C19A0", VA = "0x8C19A0", Slot = "9")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x8C1A6C", Offset = "0x8C1A6C", VA = "0x8C1A6C", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x170000B2")]
	public bool canPlay
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x8C1AE0", Offset = "0x8C1AE0", VA = "0x8C1AE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B3")]
	public bool canPlayNext
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8C1AE8", Offset = "0x8C1AE8", VA = "0x8C1AE8", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B4")]
	public bool canPlayPrev
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8C1AF0", Offset = "0x8C1AF0", VA = "0x8C1AF0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B5")]
	public float volumn
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8C1AF8", Offset = "0x8C1AF8", VA = "0x8C1AF8", Slot = "16")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8C1B18", Offset = "0x8C1B18", VA = "0x8C1B18", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public float time
	{
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x8C1B48", Offset = "0x8C1B48", VA = "0x8C1B48", Slot = "18")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8C1B68", Offset = "0x8C1B68", VA = "0x8C1B68", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public float length
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8C1B98", Offset = "0x8C1B98", VA = "0x8C1B98", Slot = "20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x8C0C2C", Offset = "0x8C0C2C", VA = "0x8C0C2C", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x8C0978", Offset = "0x8C0978", VA = "0x8C0978")]
	public void PlayAt(int index)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x8C1464", Offset = "0x8C1464", VA = "0x8C1464")]
	public void Play(MusicInfo music)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x8C1850", Offset = "0x8C1850", VA = "0x8C1850", Slot = "11")]
	public void PlayNext()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x8C18B4", Offset = "0x8C18B4", VA = "0x8C18B4", Slot = "12")]
	public void PlayPrev()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x8C1918", Offset = "0x8C1918", VA = "0x8C1918")]
	public void VolumeDown()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x8C195C", Offset = "0x8C195C", VA = "0x8C195C")]
	public void VolumeUp()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x8C1730", Offset = "0x8C1730", VA = "0x8C1730")]
	public static AudioType GetAudioType(string extesion)
	{
		return default(AudioType);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x8C109C", Offset = "0x8C109C", VA = "0x8C109C")]
	private List<MusicInfo> FindAllUserMusicInfo()
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x8C1C54", Offset = "0x8C1C54", VA = "0x8C1C54")]
	public MusicPlayer()
	{
	}
}
[Token(Token = "0x2000092")]
public class AlphaPalette : PaperObject
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float colorSmooth;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float width;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float length;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float alphaMutiply;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve alphaCurve;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Color mLastColor;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Material> mMats;

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x7B595C", Offset = "0x7B595C", VA = "0x7B595C")]
	public float GetAlphaFromLocalPosition(Vector3 pos)
	{
		return default(float);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x7B59E4", Offset = "0x7B59E4", VA = "0x7B59E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x7B5B04", Offset = "0x7B5B04", VA = "0x7B5B04")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x7B5B94", Offset = "0x7B5B94", VA = "0x7B5B94")]
	public AlphaPalette()
	{
	}
}
[Token(Token = "0x2000093")]
[ExecuteInEditMode]
public class ColorPalette : PaperObject
{
	[Token(Token = "0x2000094")]
	[Flags]
	public enum ColorMask
	{
		[Token(Token = "0x4000202")]
		R = 1,
		[Token(Token = "0x4000203")]
		G = 2,
		[Token(Token = "0x4000204")]
		B = 4,
		[Token(Token = "0x4000205")]
		A = 8
	}

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color color;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float colorSmooth;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x602E04", Offset = "0x602E04")]
	public float volumn;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ColorMask _ColorMask;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _LinearColorBlendSpeed;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Renderer[] _TargetRenderers;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color mLastColor;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Material> mMats;

	[Token(Token = "0x170000B8")]
	public override Vector3 normal
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7C3170", Offset = "0x7C3170", VA = "0x7C3170", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170000B9")]
	public ColorMask colorMask
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7C31A4", Offset = "0x7C31A4", VA = "0x7C31A4")]
		get
		{
			return default(ColorMask);
		}
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7C31AC", Offset = "0x7C31AC", VA = "0x7C31AC")]
		set
		{
		}
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x7C31B4", Offset = "0x7C31B4", VA = "0x7C31B4", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x7C32F0", Offset = "0x7C32F0", VA = "0x7C32F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x7C38A8", Offset = "0x7C38A8", VA = "0x7C38A8")]
	public ColorPalette()
	{
	}
}
[Token(Token = "0x2000095")]
[ExecuteAlways]
[ConfigurableComponent]
public class FeatherBrush : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000096")]
	public class BrushNode
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOnPlane;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool lastOnPlane;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 onPaperLocalPosition;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 lastOnPaperLocalPosition;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12D6D7C", Offset = "0x12D6D7C", VA = "0x12D6D7C")]
		public BrushNode()
		{
		}
	}

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602E4C", Offset = "0x602E4C")]
	public int nodeCount;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602E84", Offset = "0x602E84")]
	public float brushLength;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602EBC", Offset = "0x602EBC")]
	public float smooth;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool drawBrushInEdtior;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float onPagerError;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float errorHeight;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float holderHeight;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxAngle;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x602EF4", Offset = "0x602EF4")]
	private float mSizeMultipy;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public AnimationCurve brushSize;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _Paint;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private BrushNode[] mNodes;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mLastNodeCount;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material mMat;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool mSizeChanged;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private FeatherBrushInteractable mCurrentObject;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool mSetHandVibration;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float mHandVibration;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private VRVirtualBody mHand;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int debugNode;

	[Token(Token = "0x170000BA")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607E60", Offset = "0x607E60")]
	public float sizeMultipy
	{
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x811C94", Offset = "0x811C94", VA = "0x811C94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x811C9C", Offset = "0x811C9C", VA = "0x811C9C")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public FeatherBrushInteractable currentObject
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x812954", Offset = "0x812954", VA = "0x812954")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x81295C", Offset = "0x81295C", VA = "0x81295C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	private Ray detectRay
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x812A7C", Offset = "0x812A7C", VA = "0x812A7C")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x170000BD")]
	private float detectRayDitance
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x812B60", Offset = "0x812B60", VA = "0x812B60")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000BE")]
	private bool setHandVibration
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x812CEC", Offset = "0x812CEC", VA = "0x812CEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x812BDC", Offset = "0x812BDC", VA = "0x812BDC")]
		set
		{
		}
	}

	[Token(Token = "0x170000BF")]
	public BrushNode[] nodes
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x812F2C", Offset = "0x812F2C", VA = "0x812F2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C0")]
	public bool isAnyNodeOnPlane
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x812F34", Offset = "0x812F34", VA = "0x812F34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C1")]
	public bool paint
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x812F94", Offset = "0x812F94", VA = "0x812F94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x812F9C", Offset = "0x812F9C", VA = "0x812F9C")]
		set
		{
		}
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x811CAC", Offset = "0x811CAC", VA = "0x811CAC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x811DA4", Offset = "0x811DA4", VA = "0x811DA4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x811DCC", Offset = "0x811DCC", VA = "0x811DCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x811CD4", Offset = "0x811CD4", VA = "0x811CD4")]
	private void UpdateBrush(float deltaTime)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x8128FC", Offset = "0x8128FC", VA = "0x8128FC")]
	public void OnValidate()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x811EF0", Offset = "0x811EF0", VA = "0x811EF0")]
	private void CheckParamChanges()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x812B74", Offset = "0x812B74", VA = "0x812B74")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x812CC4", Offset = "0x812CC4", VA = "0x812CC4")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x812100", Offset = "0x812100", VA = "0x812100")]
	private void DetectObjects()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x8127DC", Offset = "0x8127DC", VA = "0x8127DC")]
	private void UpdateColors(float deltaTime)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x812908", Offset = "0x812908", VA = "0x812908")]
	public float CalculateNodeSize(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x8123B8", Offset = "0x8123B8", VA = "0x8123B8")]
	private void UpdateNodes(float deltaTime)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x812CF4", Offset = "0x812CF4", VA = "0x812CF4")]
	public static Vector3 ClampAngle(Vector3 normal, Vector3 vector, float maxAngle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x812DE4", Offset = "0x812DE4", VA = "0x812DE4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x812FA8", Offset = "0x812FA8", VA = "0x812FA8")]
	public FeatherBrush()
	{
	}
}
[Token(Token = "0x2000097")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6003E0", Offset = "0x6003E0")]
[ConfigurableComponent]
public class FeatherBrushPainter : Painter
{
	[Serializable]
	[Token(Token = "0x2000098")]
	private class Painter
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600458", Offset = "0x600458")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Paper paper;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FeatherBrush.BrushNode[] node;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Painter <>4__this;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Paper, FeatherBrush> onPaint;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FeatherBrush brush;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isPainted;

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x12D70E4", Offset = "0x12D70E4", VA = "0x12D70E4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x12DEC24", Offset = "0x12DEC24", VA = "0x12DEC24")]
			internal void <Paint>b__0(Material mat, int pass)
			{
			}
		}

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool renderFirstNode;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool renderframe;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool notMove;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool move;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool leave;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float leaveRaduisScale;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float leaveMoveScale;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x12D6D84", Offset = "0x12D6D84", VA = "0x12D6D84")]
		public bool Paint(FeatherBrushPainter painter, Paper paper, FeatherBrush brush, Action<Paper, FeatherBrush> onPaint)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x12D70EC", Offset = "0x12D70EC", VA = "0x12D70EC")]
		public static void DrawCircleMove(Vector3 start, Vector3 end, float r1, float r2, Vector3 normal)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x12D7208", Offset = "0x12D7208", VA = "0x12D7208")]
		public static void DrawCircleMove(Vector3 start, Vector3 end, Vector3 forward1, Vector3 right1, Vector3 forward2, Vector3 right2)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x12D7510", Offset = "0x12D7510", VA = "0x12D7510")]
		public static void DrawCircle(Vector3 start, Vector3 forward, Vector3 right)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x12D762C", Offset = "0x12D762C", VA = "0x12D762C")]
		public Painter()
		{
		}
	}

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Painter _Painter;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool _CopyTexture;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private FeatherBrush mBrush;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Paper mCurrentPaper;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool mIsFirstNodePainted;

	[Token(Token = "0x170000C2")]
	public static string paintTypeName
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x813280", Offset = "0x813280", VA = "0x813280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x8132C4", Offset = "0x8132C4", VA = "0x8132C4")]
	private static void SetAllPasses(Material material, Action<Material, int> update)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x813374", Offset = "0x813374", VA = "0x813374", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x813540", Offset = "0x813540", VA = "0x813540")]
	private void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x8135E0", Offset = "0x8135E0", VA = "0x8135E0", Slot = "12")]
	public override void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x8136B4", Offset = "0x8136B4", VA = "0x8136B4")]
	private void InitCanvas(Paper paper, FeatherBrush brush)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x8133A8", Offset = "0x8133A8", VA = "0x8133A8")]
	private void CommitPainting()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x8137C0", Offset = "0x8137C0", VA = "0x8137C0")]
	private void OnBrushPaint()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x8139F0", Offset = "0x8139F0", VA = "0x8139F0")]
	public FeatherBrushPainter()
	{
	}
}
[Token(Token = "0x200009A")]
[ExecuteAlways]
[ConfigurableComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600468", Offset = "0x600468")]
public class FeatherBrushRenderer : MonoBehaviour
{
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float paperUpOffset;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602F90", Offset = "0x602F90")]
	public int verticlePerCircle;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x602FC8", Offset = "0x602FC8")]
	public int meshNodeCount;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float alphaMapMin;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float alphaMapMax;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FeatherBrush mBrush;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mMeshFilter;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int mLastNodeCount;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int mLastVerticlePerCircle;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh mMesh;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] mVerticls;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2[] mUVs;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] mTriangles;

	[Token(Token = "0x170000C3")]
	private Material material
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x814640", Offset = "0x814640", VA = "0x814640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x8139F8", Offset = "0x8139F8", VA = "0x8139F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x813B7C", Offset = "0x813B7C", VA = "0x813B7C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x813C58", Offset = "0x813C58", VA = "0x813C58")]
	private void Init()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x814554", Offset = "0x814554", VA = "0x814554")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x813CD0", Offset = "0x813CD0", VA = "0x813CD0")]
	private void BuildMesh()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x814690", Offset = "0x814690", VA = "0x814690")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x814738", Offset = "0x814738", VA = "0x814738")]
	private void UpdateNodes()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x814B38", Offset = "0x814B38", VA = "0x814B38")]
	private void SetVerticlsTranform(int meshNode, Vector3 position, Quaternion rotation, float raduis)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x814694", Offset = "0x814694", VA = "0x814694")]
	private void UpdateMesh()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x814CB4", Offset = "0x814CB4", VA = "0x814CB4")]
	public FeatherBrushRenderer()
	{
	}
}
[Token(Token = "0x200009B")]
public abstract class FeatherBrushInteractable : CollectableBehavior<FeatherBrushInteractable>
{
	[Token(Token = "0x4000243")]
	public const string LAYER_NAME = "BrushInteractable";

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<FeatherBrush> mBrushes;

	[Token(Token = "0x170000C4")]
	public abstract Vector3 normal
	{
		[Token(Token = "0x6000390")]
		get;
	}

	[Token(Token = "0x170000C5")]
	public IReadOnlyList<FeatherBrush> brushes
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x8130A8", Offset = "0x8130A8", VA = "0x8130A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x813008", Offset = "0x813008", VA = "0x813008", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x8130B0", Offset = "0x8130B0", VA = "0x8130B0", Slot = "10")]
	public virtual void AttachBrush(FeatherBrush brush)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x813150", Offset = "0x813150", VA = "0x813150", Slot = "11")]
	public virtual void DettachBrush(FeatherBrush brush)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x8131B4", Offset = "0x8131B4", VA = "0x8131B4", Slot = "12")]
	public virtual void UpdateBrush(FeatherBrush brush, float deltaTime)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x8131B8", Offset = "0x8131B8", VA = "0x8131B8")]
	protected FeatherBrushInteractable()
	{
	}
}
[Token(Token = "0x200009C")]
public class Paper : PaperObject
{
	[Serializable]
	[Token(Token = "0x200009D")]
	private class PaperCanvas : PaintingCanvas
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RenderTexture _RenderTextureDescriptor;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture _FinalRenderTexture;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer[] _ApplyRenderers;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int _Size;

		[Token(Token = "0x170000CE")]
		public override RenderTexture renderTexture
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x12DC65C", Offset = "0x12DC65C", VA = "0x12DC65C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public Vector2Int size
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x12DC7F4", Offset = "0x12DC7F4", VA = "0x12DC7F4")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x12DC7FC", Offset = "0x12DC7FC", VA = "0x12DC7FC")]
			set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x12DC680", Offset = "0x12DC680", VA = "0x12DC680")]
		private void InitFinalRenderTexture()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x12DC804", Offset = "0x12DC804", VA = "0x12DC804", Slot = "9")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x12DC830", Offset = "0x12DC830", VA = "0x12DC830")]
		public PaperCanvas()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200009E")]
	public class HistoryManager : PaintingHistoryManager
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Hashtable mPaintTypeOverlowCounts;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Hashtable mPaintTypeUndoCounts;

		[Token(Token = "0x170000D0")]
		public IEnumerable<string> allPaintTypes
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x12DBF24", Offset = "0x12DBF24", VA = "0x12DBF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x12DBB04", Offset = "0x12DBB04", VA = "0x12DBB04", Slot = "16")]
		protected override void OnHistoryBuffersUpdated()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x12DBD24", Offset = "0x12DBD24", VA = "0x12DBD24", Slot = "15")]
		protected override void OnOverflowHistoryMerged(HistoryBuffer history)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x12DBED0", Offset = "0x12DBED0", VA = "0x12DBED0", Slot = "11")]
		public override void ClearContent()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x12DC4E8", Offset = "0x12DC4E8", VA = "0x12DC4E8")]
		public int GetPaintTypeCount(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x12DC5D8", Offset = "0x12DC5D8", VA = "0x12DC5D8")]
		public HistoryManager()
		{
		}
	}

	[Token(Token = "0x200009F")]
	public class PaperTemplate
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture texture;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PaperTemplateType type;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object tag;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x12DC844", Offset = "0x12DC844", VA = "0x12DC844")]
		public PaperTemplate()
		{
		}
	}

	[Token(Token = "0x20000A0")]
	public enum PaperTemplateType
	{
		[Token(Token = "0x4000258")]
		None,
		[Token(Token = "0x4000259")]
		Copybook,
		[Token(Token = "0x400025A")]
		MyWork,
		[Token(Token = "0x400025B")]
		UserTemplate
	}

	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600518", Offset = "0x600518")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LanguageUtils.LanguagePack languagePack;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x12DBADC", Offset = "0x12DBADC", VA = "0x12DBADC")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x12DBAE4", Offset = "0x12DBAE4", VA = "0x12DBAE4")]
		internal void <LoadLocalConfigFile>b__0(string key, string value)
		{
		}
	}

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RenderTexture _RenderTextureDescriptor;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private MeshFilter _paperMesh;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private bool _isPaperMeshFlat;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _LocalConfigFile;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BackgroundBlendLayer _Background;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PaperCanvas _Canvas;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private HistoryManager _HistoryManager;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PaperTemplate mPaperTemplate;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Texture2D _emptyTexture;

	[Token(Token = "0x170000C6")]
	public bool isPaperMeshFlat
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x12C6F2C", Offset = "0x12C6F2C", VA = "0x12C6F2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C7")]
	public RenderTexture finalRenderTexture
	{
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x12C2CB8", Offset = "0x12C2CB8", VA = "0x12C2CB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C8")]
	public MeshFilter paperMesh
	{
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12C7538", Offset = "0x12C7538", VA = "0x12C7538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C9")]
	public Texture emptyTexure
	{
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x12C7540", Offset = "0x12C7540", VA = "0x12C7540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CA")]
	public Texture backgroundTexture
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x12C7630", Offset = "0x12C7630", VA = "0x12C7630")]
		get
		{
			return null;
		}
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x12C7650", Offset = "0x12C7650", VA = "0x12C7650")]
		set
		{
		}
	}

	[Token(Token = "0x170000CB")]
	public PaperTemplate tempate
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x12C7700", Offset = "0x12C7700", VA = "0x12C7700")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12C6654", Offset = "0x12C6654", VA = "0x12C6654")]
		set
		{
		}
	}

	[Token(Token = "0x170000CC")]
	public PaintingCanvas canvas
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x12C78CC", Offset = "0x12C78CC", VA = "0x12C78CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CD")]
	public HistoryManager historyManager
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x12C78D4", Offset = "0x12C78D4", VA = "0x12C78D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x12C6B80", Offset = "0x12C6B80", VA = "0x12C6B80")]
	public void CalculatePaperRect()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x12C6F34", Offset = "0x12C6F34", VA = "0x12C6F34")]
	private void LoadLocalConfigFile()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x12C7670", Offset = "0x12C7670", VA = "0x12C7670")]
	private void Start()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x12C76DC", Offset = "0x12C76DC", VA = "0x12C76DC")]
	public void ClearContent()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x12C7708", Offset = "0x12C7708", VA = "0x12C7708")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x12C775C", Offset = "0x12C775C", VA = "0x12C775C", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x12C7808", Offset = "0x12C7808", VA = "0x12C7808")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x12C78DC", Offset = "0x12C78DC", VA = "0x12C78DC")]
	public Paper()
	{
	}
}
[Token(Token = "0x20000A2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600528", Offset = "0x600528")]
public class PaperHandler : MonoBehaviour
{
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRHandInput.Button buttonClear;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public VRHandInput.Button buttonUndo;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRHandInput.Button buttonRedo;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string defaultPaper;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FeatherBrush mBrush;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRHandInput mHandInput;

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x12C7940", Offset = "0x12C7940", VA = "0x12C7940")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x12C7944", Offset = "0x12C7944", VA = "0x12C7944")]
	private void ProcessEvents()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x12C7CE0", Offset = "0x12C7CE0", VA = "0x12C7CE0")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x12C7D70", Offset = "0x12C7D70", VA = "0x12C7D70")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x12C7B68", Offset = "0x12C7B68", VA = "0x12C7B68")]
	private Paper GetTargetPaper()
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x12C7D78", Offset = "0x12C7D78", VA = "0x12C7D78")]
	public PaperHandler()
	{
	}
}
[Token(Token = "0x20000A3")]
public class PaperObject : FeatherBrushInteractable
{
	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Rect _paperRect;

	[Token(Token = "0x170000D1")]
	public Rect paperRect
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12C7DE8", Offset = "0x12C7DE8", VA = "0x12C7DE8")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170000D2")]
	public override Vector3 normal
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x12C7DF4", Offset = "0x12C7DF4", VA = "0x12C7DF4", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x12C7E28", Offset = "0x12C7E28", VA = "0x12C7E28", Slot = "12")]
	public override void UpdateBrush(FeatherBrush brush, float deltaTime)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x12C78E8", Offset = "0x12C78E8", VA = "0x12C78E8")]
	public PaperObject()
	{
	}
}
[Token(Token = "0x20000A4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600590", Offset = "0x600590")]
public class PaperPainter : MonoBehaviour
{
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6005F8", Offset = "0x6005F8")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FeatherBrush brush;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Paper paper;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PaperPainter <>4__this;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FeatherBrush.BrushNode[] node;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x12DC84C", Offset = "0x12DC84C", VA = "0x12DC84C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x12DC854", Offset = "0x12DC854", VA = "0x12DC854")]
		internal void <PaintTo>b__0(Material mat, int pass)
		{
		}
	}

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mat;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material blit;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool renderFirstNode;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool renderframe;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool notMove;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool move;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool leave;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float leaveRaduisScale;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float leaveMoveScale;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Paper mPaper;

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x12C8334", Offset = "0x12C8334", VA = "0x12C8334")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x12C8390", Offset = "0x12C8390", VA = "0x12C8390")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x12C8B0C", Offset = "0x12C8B0C", VA = "0x12C8B0C")]
	private static void SetAllPasses(Material material, Action<Material, int> update)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x12C8674", Offset = "0x12C8674", VA = "0x12C8674")]
	public void PaintTo(FeatherBrush brush, Paper paper)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x12C8BBC", Offset = "0x12C8BBC", VA = "0x12C8BBC")]
	public static void DrawCircleMove(Vector3 start, Vector3 end, float r1, float r2, Vector3 normal)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x12C8CD8", Offset = "0x12C8CD8", VA = "0x12C8CD8")]
	public static void DrawCircleMove(Vector3 start, Vector3 end, Vector3 forward1, Vector3 right1, Vector3 forward2, Vector3 right2)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x12C8FE0", Offset = "0x12C8FE0", VA = "0x12C8FE0")]
	public static void DrawCircle(Vector3 start, Vector3 forward, Vector3 right)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x12C90FC", Offset = "0x12C90FC", VA = "0x12C90FC")]
	public PaperPainter()
	{
	}
}
[Token(Token = "0x20000A6")]
public class SavedPaintings : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	public class Painting
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool loadFromFile;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture tex;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DateTime time;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Coroutine loading;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool loadingError;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly SavedPaintings owner;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12DD42C", Offset = "0x12DD42C", VA = "0x12DD42C")]
		public Painting(SavedPaintings o)
		{
		}
	}

	[Token(Token = "0x20000A8")]
	public enum ChangeType
	{
		[Token(Token = "0x4000282")]
		Added,
		[Token(Token = "0x4000283")]
		Deleted,
		[Token(Token = "0x4000284")]
		RangeAdded,
		[Token(Token = "0x4000285")]
		Updated
	}

	[Token(Token = "0x20000A9")]
	public delegate void OnPaintingsChangedDelegate(int index, ChangeType type);

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600608", Offset = "0x600608")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Painting painting;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SavedPaintings <>4__this;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x12DD100", Offset = "0x12DD100", VA = "0x12DD100")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x12DD108", Offset = "0x12DD108", VA = "0x12DD108")]
		internal void <Load>b__0(UnityWebRequest request, DownloadHandlerTexture hanlder)
		{
		}
	}

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnPaintingsChangedDelegate OnPaintingsChanged;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6030D8", Offset = "0x6030D8")]
	private bool <loadedImages>k__BackingField;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Painting> mPaintings;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mMaxLoadCount;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int mMinViewIndex;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int mMaxViewIndex;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private FileUtils.MediaType mMediaType;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<FileUtils.MediaType, SavedPaintings> mInstances;

	[Token(Token = "0x170000D3")]
	public bool loadedImages
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x12D0CB0", Offset = "0x12D0CB0", VA = "0x12D0CB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606118", Offset = "0x606118")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x12D0CB8", Offset = "0x12D0CB8", VA = "0x12D0CB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606128", Offset = "0x606128")]
		set
		{
		}
	}

	[Token(Token = "0x170000D4")]
	public int count
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x12C4620", Offset = "0x12C4620", VA = "0x12C4620")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000D5")]
	public FileUtils.MediaType MediaType
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x12D1554", Offset = "0x12D1554", VA = "0x12D1554")]
		get
		{
			return default(FileUtils.MediaType);
		}
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x12C389C", Offset = "0x12C389C", VA = "0x12C389C")]
	public static SavedPaintings Get(FileUtils.MediaType media)
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x12C3B2C", Offset = "0x12C3B2C", VA = "0x12C3B2C")]
	public void Add(Painting painting)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x12D0CC4", Offset = "0x12D0CC4", VA = "0x12D0CC4")]
	private void Add(List<Painting> paintings)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x12C47A8", Offset = "0x12C47A8", VA = "0x12C47A8")]
	public void LoadImages()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x12C3A9C", Offset = "0x12C3A9C", VA = "0x12C3A9C")]
	public void UpdatePainting(Painting painting)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x12C5D50", Offset = "0x12C5D50", VA = "0x12C5D50")]
	public void SetViewingRange(int minIndex, int maxIndex)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x12C5B6C", Offset = "0x12C5B6C", VA = "0x12C5B6C")]
	public void Load(Painting painting)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x12D0D78", Offset = "0x12D0D78", VA = "0x12D0D78")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x12D10D0", Offset = "0x12D10D0", VA = "0x12D10D0")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x12C66EC", Offset = "0x12C66EC", VA = "0x12C66EC")]
	public void Remove(Painting painting)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x12D1364", Offset = "0x12D1364", VA = "0x12D1364")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x12C466C", Offset = "0x12C466C", VA = "0x12C466C")]
	public Painting Get(int index)
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x12D155C", Offset = "0x12D155C", VA = "0x12D155C")]
	public SavedPaintings()
	{
	}
}
[Token(Token = "0x20000AB")]
public class Seal : MonoBehaviour
{
	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _width;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _height;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _material;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _PaitingMaterial;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _LayerMergeMaterial;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture _texture;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float cosAnle;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip audioClip;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _Vibration;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _VibrationDuration;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _VibrationAmplitude;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshFilter mMeshFilter;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private MeshRenderer mMeshRenderer;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Paper mLastPaper;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 mLastPosition;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool mDirty;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Material mCopiedPaintingMaterial;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string mTextureTag;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string sSavedTextureTag;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture sSavedTexture;

	[Token(Token = "0x170000D6")]
	public Texture texture
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x12D2688", Offset = "0x12D2688", VA = "0x12D2688")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D7")]
	public string textureTag
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x12D2690", Offset = "0x12D2690", VA = "0x12D2690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D8")]
	public static string paintTypeName
	{
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x12D366C", Offset = "0x12D366C", VA = "0x12D366C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x12D2564", Offset = "0x12D2564", VA = "0x12D2564")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x12D2618", Offset = "0x12D2618", VA = "0x12D2618")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x12C65D4", Offset = "0x12C65D4", VA = "0x12C65D4")]
	public void SetTexture(Texture texture, [Optional] string textureTag)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x12D2698", Offset = "0x12D2698", VA = "0x12D2698")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x12D269C", Offset = "0x12D269C", VA = "0x12D269C")]
	public void ReInit()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x12D2880", Offset = "0x12D2880", VA = "0x12D2880")]
	private void CalculateMesh()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x12D2AF0", Offset = "0x12D2AF0", VA = "0x12D2AF0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x12D2FE8", Offset = "0x12D2FE8", VA = "0x12D2FE8")]
	private void Paint(Paper paper)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x12D36B0", Offset = "0x12D36B0", VA = "0x12D36B0")]
	public Seal()
	{
	}
}
[Token(Token = "0x20000AC")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x600618", Offset = "0x600618")]
public class PaintingSaver : SingletonGameObject<PaintingSaver>
{
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image mImage;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh mMesh;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material mMaterial;

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x12C27A0", Offset = "0x12C27A0", VA = "0x12C27A0", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x12C28CC", Offset = "0x12C28CC", VA = "0x12C28CC", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x12C2968", Offset = "0x12C2968", VA = "0x12C2968")]
	public void Save(PhotoFrameListData.Data photoFrame, Paper paper, SavedPaintings.Painting replacePainting, FileUtils.MediaType mediaType)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x12C2CDC", Offset = "0x12C2CDC", VA = "0x12C2CDC")]
	private Texture2D RenderTextureTo2d(RenderTexture rt, PhotoFrameListData.Data photoFrame)
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x12C40E8", Offset = "0x12C40E8", VA = "0x12C40E8")]
	public PaintingSaver()
	{
	}
}
[Token(Token = "0x20000AD")]
[ConfigurableComponent]
public class PanoramaBallConfig : MonoBehaviour
{
	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool autoPlayMovie;

	[Token(Token = "0x170000D9")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607E98", Offset = "0x607E98")]
	public float positionX
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x12C67D8", Offset = "0x12C67D8", VA = "0x12C67D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x12C67FC", Offset = "0x12C67FC", VA = "0x12C67FC")]
		set
		{
		}
	}

	[Token(Token = "0x170000DA")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607ED0", Offset = "0x607ED0")]
	public float positionY
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x12C686C", Offset = "0x12C686C", VA = "0x12C686C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x12C6898", Offset = "0x12C6898", VA = "0x12C6898")]
		set
		{
		}
	}

	[Token(Token = "0x170000DB")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607F08", Offset = "0x607F08")]
	public float positionZ
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x12C6908", Offset = "0x12C6908", VA = "0x12C6908")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x12C6934", Offset = "0x12C6934", VA = "0x12C6934")]
		set
		{
		}
	}

	[Token(Token = "0x170000DC")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607F40", Offset = "0x607F40")]
	public float scaleX
	{
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x12C69A4", Offset = "0x12C69A4", VA = "0x12C69A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x12C69C8", Offset = "0x12C69C8", VA = "0x12C69C8")]
		set
		{
		}
	}

	[Token(Token = "0x170000DD")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607F78", Offset = "0x607F78")]
	public float scaleY
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12C6A38", Offset = "0x12C6A38", VA = "0x12C6A38")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12C6A64", Offset = "0x12C6A64", VA = "0x12C6A64")]
		set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	[AttributeAttribute(Name = "ConfigurableMember", RVA = "0x607FB0", Offset = "0x607FB0")]
	public float scaleZ
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12C6AD4", Offset = "0x12C6AD4", VA = "0x12C6AD4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12C6B00", Offset = "0x12C6B00", VA = "0x12C6B00")]
		set
		{
		}
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x12C67D4", Offset = "0x12C67D4", VA = "0x12C67D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x12C6B70", Offset = "0x12C6B70", VA = "0x12C6B70")]
	public PanoramaBallConfig()
	{
	}
}
[Token(Token = "0x20000AE")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60065C", Offset = "0x60065C")]
public class PickAndDropHighlighter : MonoBehaviour
{
	[Token(Token = "0x20000AF")]
	private class HighlightObject
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object originalObject;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject obj;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool needDestroy;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x12DCD90", Offset = "0x12DCD90", VA = "0x12DCD90")]
		public HighlightObject()
		{
		}
	}

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color highlightColor;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material highlightMaterial;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float smooth;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Color mCurrentColor;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material mHighlightMat;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PickAndDropItemPosition mPickAndDropPosition;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<HighlightObject> mHighlightingObjects;

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x12CB1B4", Offset = "0x12CB1B4", VA = "0x12CB1B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x12CB264", Offset = "0x12CB264", VA = "0x12CB264")]
	private void Update()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x12CB504", Offset = "0x12CB504", VA = "0x12CB504")]
	public void HightlightDrop(PickAndDropItem itemInHand)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x12CB828", Offset = "0x12CB828", VA = "0x12CB828")]
	private static GameObject CreateHighlightGameObject(PickAndDropItem item, Material material, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x12CBE78", Offset = "0x12CBE78", VA = "0x12CBE78")]
	private void OnItemPicked(PickAndDropItem item)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x12CBE7C", Offset = "0x12CBE7C", VA = "0x12CBE7C")]
	private void OnItemDroped(PickAndDropItem item)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x12CBE80", Offset = "0x12CBE80", VA = "0x12CBE80")]
	private void OnHoverEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x12CBF88", Offset = "0x12CBF88", VA = "0x12CBF88")]
	private void OnHoverExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x12CB5EC", Offset = "0x12CB5EC", VA = "0x12CB5EC")]
	public bool HighlightDropOff([Optional] PickAndDropItem newItem)
	{
		return default(bool);
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x12CBD44", Offset = "0x12CBD44", VA = "0x12CBD44")]
	private static Vector3 Scale(Transform parent, Transform child)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x12CBF90", Offset = "0x12CBF90", VA = "0x12CBF90")]
	private static Vector3 VectorMul(Vector3 v1, Vector3 v2)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x12CBFA0", Offset = "0x12CBFA0", VA = "0x12CBFA0")]
	public PickAndDropHighlighter()
	{
	}
}
[Token(Token = "0x20000B0")]
public class PickAndDropItem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000B1")]
	public struct Pose
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 rotation;
	}

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pickedPosition;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pickedEuler;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 dropedPosition;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 dropedEuler;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool localPositionAsDropPosition;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string itemTag;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool realPosition;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string animationTrigger;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string targetHandObject;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string applyHandPosition;

	[NonSerialized]
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PickAndDropItemPosition fromPosition;

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x12CC038", Offset = "0x12CC038", VA = "0x12CC038")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x12CC09C", Offset = "0x12CC09C", VA = "0x12CC09C")]
	public PickAndDropItem()
	{
	}
}
[Token(Token = "0x20000B2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6006C4", Offset = "0x6006C4")]
public class PickAndDropItemPosition : InteractableVRObject
{
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioClip _SoundPick;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AudioClip _SoundDrop;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string handlerTag;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private PickAndDropItem mItem;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource mAudio;

	[Token(Token = "0x170000DF")]
	public PickAndDropItem item
	{
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x12CC0A4", Offset = "0x12CC0A4", VA = "0x12CC0A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x12CC0AC", Offset = "0x12CC0AC", VA = "0x12CC0AC", Slot = "17")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x12CC138", Offset = "0x12CC138", VA = "0x12CC138", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x12CC300", Offset = "0x12CC300", VA = "0x12CC300", Slot = "21")]
	protected virtual void DoPickAndDrop(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x12CC554", Offset = "0x12CC554", VA = "0x12CC554", Slot = "22")]
	protected virtual void PickItem(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x12CC834", Offset = "0x12CC834", VA = "0x12CC834", Slot = "23")]
	protected virtual void DropItem(PickAndDropItem item, InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x12CCA8C", Offset = "0x12CCA8C", VA = "0x12CCA8C", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x12CCB10", Offset = "0x12CCB10", VA = "0x12CCB10", Slot = "13")]
	public override void OnExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x12CCB94", Offset = "0x12CCB94", VA = "0x12CCB94", Slot = "20")]
	protected override void OnProcessEvents(VRHandInput vrInput)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x12CCBF0", Offset = "0x12CCBF0", VA = "0x12CCBF0")]
	public PickAndDropItemPosition()
	{
	}
}
[Token(Token = "0x20000B3")]
public class BrushRecorder : MonoBehaviour
{
	[Token(Token = "0x20000B4")]
	private class PlayingObjects
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject hand;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform handBrushPosition;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject childBrush;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator coroutine;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7DA6B8", Offset = "0x7DA6B8", VA = "0x7DA6B8")]
		public PlayingObjects()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	private struct RecordingFile
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string mOpenPath;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string mSavePath;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool mIsAsset;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string mCopybook;

		[Token(Token = "0x170000E8")]
		public bool isExists
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x7DA7B8", Offset = "0x7DA7B8", VA = "0x7DA7B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public string copybook
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x7DA7DC", Offset = "0x7DA7DC", VA = "0x7DA7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public bool isAsset
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x7DA7E4", Offset = "0x7DA7E4", VA = "0x7DA7E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public string openUrl
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x7DA7EC", Offset = "0x7DA7EC", VA = "0x7DA7EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public string savePath
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x7DA854", Offset = "0x7DA854", VA = "0x7DA854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x7DA6C0", Offset = "0x7DA6C0", VA = "0x7DA6C0")]
		public void MatchCopybookAssetPath(string assetPath)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60072C", Offset = "0x60072C")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<HandController> <>9__22_0;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7D88AC", Offset = "0x7D88AC", VA = "0x7D88AC")]
		public <>c()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x7D88B4", Offset = "0x7D88B4", VA = "0x7D88B4")]
		internal bool <findHoldingBrush>b__22_0(HandController m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60073C", Offset = "0x60073C")]
	private sealed class <Recording>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject obj;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BrushRecorder <>4__this;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string filePath;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <dely>5__2;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <childBrush>5__3;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <startTime>5__4;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <length>5__5;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Stream <sf>5__6;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BinaryWriter <bw>5__7;

		[Token(Token = "0x170000ED")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x7DA668", Offset = "0x7DA668", VA = "0x7DA668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x7DA6B0", Offset = "0x7DA6B0", VA = "0x7DA6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7D98E0", Offset = "0x7D98E0", VA = "0x7D98E0")]
		[DebuggerHidden]
		public <Recording>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7D990C", Offset = "0x7D990C", VA = "0x7D990C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7D99EC", Offset = "0x7D99EC", VA = "0x7D99EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7D9938", Offset = "0x7D9938", VA = "0x7D9938")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7DA670", Offset = "0x7DA670", VA = "0x7DA670", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60074C", Offset = "0x60074C")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] data;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7D894C", Offset = "0x7D894C", VA = "0x7D894C")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7D8954", Offset = "0x7D8954", VA = "0x7D8954")]
		internal void <Play>b__0(UnityWebRequest request)
		{
		}
	}

	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60075C", Offset = "0x60075C")]
	private sealed class <>c__DisplayClass43_1
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int brushId;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7D8A1C", Offset = "0x7D8A1C", VA = "0x7D8A1C")]
		public <>c__DisplayClass43_1()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7D8A24", Offset = "0x7D8A24", VA = "0x7D8A24")]
		internal bool <Play>b__1(BrushRecorderId id)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60076C", Offset = "0x60076C")]
	private sealed class <Play>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushRecorder <>4__this;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass43_0 <>8__1;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Stream <sf>5__2;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BinaryReader <br0>5__3;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <ver>5__4;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <length>5__5;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BinaryReader <br>5__6;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 <oldPos>5__7;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion <oldRot>5__8;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float <oldTime>5__9;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float <curTime>5__10;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int <i>5__11;

		[Token(Token = "0x170000EF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x7D9890", Offset = "0x7D9890", VA = "0x7D9890", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x7D98D8", Offset = "0x7D98D8", VA = "0x7D98D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7D8A60", Offset = "0x7D8A60", VA = "0x7D8A60")]
		[DebuggerHidden]
		public <Play>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7D8A8C", Offset = "0x7D8A8C", VA = "0x7D8A8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7D8B6C", Offset = "0x7D8B6C", VA = "0x7D8B6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7D8AB8", Offset = "0x7D8AB8", VA = "0x7D8AB8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7D9898", Offset = "0x7D9898", VA = "0x7D9898", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6031B8", Offset = "0x6031B8")]
	public float sample;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool usingUpdateTime;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Paper paper;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool allowRecord;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool playPainting;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public readonly float vertion;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject handPrefab;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float zRotationOffset;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool mRecording;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool mPlaying;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	private bool mPaused;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayingObjects mPlayingObject;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RecordingFile mRecordingFile;

	[Token(Token = "0x40002CA")]
	private const int HeaderLength = 28;

	[Token(Token = "0x170000E0")]
	private static string externalDirector
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x7BC490", Offset = "0x7BC490", VA = "0x7BC490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E1")]
	public bool isPlayingOrRecording
	{
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7BCB9C", Offset = "0x7BCB9C", VA = "0x7BCB9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E2")]
	public bool isPlaying
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7BCBD4", Offset = "0x7BCBD4", VA = "0x7BCBD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E3")]
	public bool isRecording
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7BCBDC", Offset = "0x7BCBDC", VA = "0x7BCBDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E4")]
	public bool canPlay
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7BCBE4", Offset = "0x7BCBE4", VA = "0x7BCBE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E5")]
	public bool canRecord
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7BCC08", Offset = "0x7BCC08", VA = "0x7BCC08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E6")]
	public bool isPaused
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x7BCC34", Offset = "0x7BCC34", VA = "0x7BCC34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E7")]
	public string recordingFileUrl
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7BCD48", Offset = "0x7BCD48", VA = "0x7BCD48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x7BC518", Offset = "0x7BC518", VA = "0x7BC518")]
	public void Awake()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x7BC5A0", Offset = "0x7BC5A0", VA = "0x7BC5A0")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x7BC664", Offset = "0x7BC664", VA = "0x7BC664")]
	public void SetTemplate(string name)
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x7BC6E8", Offset = "0x7BC6E8", VA = "0x7BC6E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x7BC770", Offset = "0x7BC770", VA = "0x7BC770")]
	public void Record([Optional] GameObject obj)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x7BCB80", Offset = "0x7BCB80", VA = "0x7BCB80")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x7BCBBC", Offset = "0x7BCBBC", VA = "0x7BCBBC")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x7BC984", Offset = "0x7BC984", VA = "0x7BC984")]
	private GameObject findHoldingBrush()
	{
		return null;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x7BCC5C", Offset = "0x7BCC5C", VA = "0x7BCC5C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x7BCCA0", Offset = "0x7BCCA0", VA = "0x7BCCA0")]
	private void DestoryPlayingObjects()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x7BC6BC", Offset = "0x7BC6BC", VA = "0x7BC6BC")]
	public void Clear()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x7BCD54", Offset = "0x7BCD54", VA = "0x7BCD54")]
	public void Play()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x7BC8FC", Offset = "0x7BC8FC", VA = "0x7BC8FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606138", Offset = "0x606138")]
	private IEnumerator Recording(GameObject obj, string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x7BCE64", Offset = "0x7BCE64", VA = "0x7BCE64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6061A0", Offset = "0x6061A0")]
	private IEnumerator Play(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x7BCEDC", Offset = "0x7BCEDC", VA = "0x7BCEDC")]
	public BrushRecorder()
	{
	}
}
[Token(Token = "0x20000BB")]
public class BrushRecorderId : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int _id;

	[Token(Token = "0x170000F1")]
	public int id
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7BCF94", Offset = "0x7BCF94", VA = "0x7BCF94")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x7BCF00", Offset = "0x7BCF00", VA = "0x7BCF00")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x7BD000", Offset = "0x7BD000", VA = "0x7BD000")]
	public static bool HasId(int id, BrushRecorderId[] brushRecorderIds)
	{
		return default(bool);
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x7BCF24", Offset = "0x7BCF24", VA = "0x7BCF24")]
	public static int GetNewId()
	{
		return default(int);
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x7BD058", Offset = "0x7BD058", VA = "0x7BD058")]
	public BrushRecorderId()
	{
	}
}
[Token(Token = "0x20000BC")]
public class Settings : MonoBehaviour
{
	[Token(Token = "0x40002F2")]
	public const string Is_Entered_Tutorial = "IsEnteredTutorial";

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x12D46E8", Offset = "0x12D46E8", VA = "0x12D46E8")]
	public Settings()
	{
	}
}
[Token(Token = "0x20000BD")]
[ExecuteAlways]
public class SimpleURPProjector : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60078C", Offset = "0x60078C")]
	private sealed class <>c
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Material> <>9__11_1;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Material> <>9__14_0;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x12DD6F8", Offset = "0x12DD6F8", VA = "0x12DD6F8")]
		public <>c()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x12DD700", Offset = "0x12DD700", VA = "0x12DD700")]
		internal void <get_materialPool>b__11_1(Material mat)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x12DD704", Offset = "0x12DD704", VA = "0x12DD704")]
		internal void <OnDestroy>b__14_0(Material mat)
		{
		}
	}

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer[] _Targets;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _ProjectorMaterial;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _NearClipPlane;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _FarClipPlane;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _AspectRatio;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _FieldOfView;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _OrthographicSize;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool _Orthographic;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Material> mCopiedMaterials;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ObjectPool<Material> mMaterialPool;

	[Token(Token = "0x170000F2")]
	public ObjectPool<Material> materialPool
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x12D4FA0", Offset = "0x12D4FA0", VA = "0x12D4FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x12D51B0", Offset = "0x12D51B0", VA = "0x12D51B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x12D5A98", Offset = "0x12D5A98", VA = "0x12D5A98")]
	private void DrawTarget(Renderer renderer, Material renderMaterial)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x12D5C90", Offset = "0x12D5C90", VA = "0x12D5C90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x12D5930", Offset = "0x12D5930", VA = "0x12D5930")]
	private void ClearCopiedMaterials()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x12D5DD4", Offset = "0x12D5DD4", VA = "0x12D5DD4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x12D5F9C", Offset = "0x12D5F9C", VA = "0x12D5F9C")]
	public SimpleURPProjector()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x12D6030", Offset = "0x12D6030", VA = "0x12D6030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6062A8", Offset = "0x6062A8")]
	private void <get_materialPool>b__11_0(Material mat)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x12D610C", Offset = "0x12D610C", VA = "0x12D610C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6062B8", Offset = "0x6062B8")]
	private Material <get_materialPool>b__11_2()
	{
		return null;
	}
}
[Token(Token = "0x20000BF")]
[ExecuteAlways]
public class SimpleURPProjectorTarget : CollectableBehavior<SimpleURPProjectorTarget>
{
	[Token(Token = "0x170000F3")]
	protected override bool enabledOnly
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x7C6710", Offset = "0x7C6710", VA = "0x7C6710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x7C6718", Offset = "0x7C6718", VA = "0x7C6718")]
	public SimpleURPProjectorTarget()
	{
	}
}
[Token(Token = "0x20000C0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6007AC", Offset = "0x6007AC")]
public class AnimatorEvent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C1")]
	private class Config
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[NonSerialized]
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool invoked;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvents.EmptyEvent action;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x7D7974", Offset = "0x7D7974", VA = "0x7D7974")]
		public Config()
		{
		}
	}

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Config[] _Configs;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator mAnimator;

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x7B5D90", Offset = "0x7B5D90", VA = "0x7B5D90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x7B5DEC", Offset = "0x7B5DEC", VA = "0x7B5DEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x7B5EF8", Offset = "0x7B5EF8", VA = "0x7B5EF8")]
	public AnimatorEvent()
	{
	}
}
[Token(Token = "0x20000C2")]
public class DocumentTab : MonoBehaviour
{
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Graphic _SelectedTarget;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _DocumentLanKey;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Button _Button;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _IsSelected;

	[Token(Token = "0x170000F4")]
	public string documentKey
	{
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8116A0", Offset = "0x8116A0", VA = "0x8116A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F5")]
	public Button button
	{
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8116A8", Offset = "0x8116A8", VA = "0x8116A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F6")]
	public bool isSelected
	{
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x811750", Offset = "0x811750", VA = "0x811750")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x811758", Offset = "0x811758", VA = "0x811758")]
		set
		{
		}
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x811654", Offset = "0x811654", VA = "0x811654")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x8117C4", Offset = "0x8117C4", VA = "0x8117C4")]
	public DocumentTab()
	{
	}
}
[Token(Token = "0x20000C3")]
public class LanguageList : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C4")]
	private class Config
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SystemLanguage language;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x12D9148", Offset = "0x12D9148", VA = "0x12D9148")]
		public Config()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600814", Offset = "0x600814")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LanguageListRow row;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageList <>4__this;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x12D9084", Offset = "0x12D9084", VA = "0x12D9084")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x12D908C", Offset = "0x12D908C", VA = "0x12D908C")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LanguageListRow _Template;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Config[] _Languages;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvents.StringEvent _OnSetLanguage;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<LanguageListRow> mRows;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x8B4124", Offset = "0x8B4124", VA = "0x8B4124")]
	private void Start()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x8B47B4", Offset = "0x8B47B4", VA = "0x8B47B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x8B47B8", Offset = "0x8B47B8", VA = "0x8B47B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x8B4884", Offset = "0x8B4884", VA = "0x8B4884")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x8B45A8", Offset = "0x8B45A8", VA = "0x8B45A8")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x8B491C", Offset = "0x8B491C", VA = "0x8B491C")]
	public LanguageList()
	{
	}
}
[Token(Token = "0x20000C6")]
public class LanguageListRow : MonoBehaviour
{
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image _Image;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _Text;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Graphic _SelectedTarget;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Button _Button;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _IsSelected;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60331C", Offset = "0x60331C")]
	private string <language>k__BackingField;

	[Token(Token = "0x170000F7")]
	public string language
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8B49E8", Offset = "0x8B49E8", VA = "0x8B49E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6062C8", Offset = "0x6062C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8B49F0", Offset = "0x8B49F0", VA = "0x8B49F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6062D8", Offset = "0x6062D8")]
		set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	public string text
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8B49F8", Offset = "0x8B49F8", VA = "0x8B49F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8B4888", Offset = "0x8B4888", VA = "0x8B4888")]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public Sprite sprite
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8B4A20", Offset = "0x8B4A20", VA = "0x8B4A20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x8B44E0", Offset = "0x8B44E0", VA = "0x8B44E0")]
		set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	public Button button
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x8B4500", Offset = "0x8B4500", VA = "0x8B4500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FB")]
	public bool isSelected
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x8B4A40", Offset = "0x8B4A40", VA = "0x8B4A40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8B48B0", Offset = "0x8B48B0", VA = "0x8B48B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x8B499C", Offset = "0x8B499C", VA = "0x8B499C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x8B4A48", Offset = "0x8B4A48", VA = "0x8B4A48")]
	public LanguageListRow()
	{
	}
}
[Token(Token = "0x20000C7")]
public class MenuAnimation_StartMenu_Main : MonoBehaviour, MenuPanel.IMenuAnimation
{
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600824", Offset = "0x600824")]
	private sealed class <CheckPlayDone>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MenuAnimation_StartMenu_Main <>4__this;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action done;

		[Token(Token = "0x170000FD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x12DA060", Offset = "0x12DA060", VA = "0x12DA060", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x12DA0A8", Offset = "0x12DA0A8", VA = "0x12DA0A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x12D9EF0", Offset = "0x12D9EF0", VA = "0x12D9EF0")]
		[DebuggerHidden]
		public <CheckPlayDone>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x12D9F1C", Offset = "0x12D9F1C", VA = "0x12D9F1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x12D9F20", Offset = "0x12D9F20", VA = "0x12D9F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x12DA068", Offset = "0x12DA068", VA = "0x12DA068", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int layer;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string logoFadeIn;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string normalFadeIn;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string fadeOut;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator mAnimator;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool mPlayed;

	[Token(Token = "0x170000FC")]
	private bool playLogo
	{
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8BAD64", Offset = "0x8BAD64", VA = "0x8BAD64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x8BAC50", Offset = "0x8BAC50", VA = "0x8BAC50", Slot = "5")]
	public void OnClose([Optional] Action done)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x8BAD10", Offset = "0x8BAD10", VA = "0x8BAD10", Slot = "4")]
	public void OnOpen([Optional] Action done)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x8BAC60", Offset = "0x8BAC60", VA = "0x8BAC60")]
	private void PlayAnimation(string name, Action done)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x8BADD4", Offset = "0x8BADD4", VA = "0x8BADD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6062E8", Offset = "0x6062E8")]
	private IEnumerator CheckPlayDone(string name, Action done)
	{
		return null;
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x8BAE5C", Offset = "0x8BAE5C", VA = "0x8BAE5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x8BAEB8", Offset = "0x8BAEB8", VA = "0x8BAEB8")]
	public MenuAnimation_StartMenu_Main()
	{
	}
}
[Token(Token = "0x20000C9")]
public class StartMenuHelpUI : MonoBehaviour
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600834", Offset = "0x600834")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DocumentTab tab;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenuHelpUI <>4__this;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x12DD7AC", Offset = "0x12DD7AC", VA = "0x12DD7AC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x12DD7B4", Offset = "0x12DD7B4", VA = "0x12DD7B4")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600844", Offset = "0x600844")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect scrollRect;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x12DD7DC", Offset = "0x12DD7DC", VA = "0x12DD7DC")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x12DD7E4", Offset = "0x12DD7E4", VA = "0x12DD7E4")]
		internal void <SelectTab>b__0()
		{
		}
	}

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DocumentTab[] _Tabs;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DocumentLayoutXmlLoader _Document;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DocumentTab _SelectedTab;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _currentDocumentResource;

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x7C68E4", Offset = "0x7C68E4", VA = "0x7C68E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x7C6CD8", Offset = "0x7C6CD8", VA = "0x7C6CD8")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x7C6E98", Offset = "0x7C6E98", VA = "0x7C6E98")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x7C6ACC", Offset = "0x7C6ACC", VA = "0x7C6ACC")]
	private void SelectTab(DocumentTab tab)
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x7C6D78", Offset = "0x7C6D78", VA = "0x7C6D78")]
	private void SetDocument(string resourceKey)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x7C6F64", Offset = "0x7C6F64", VA = "0x7C6F64")]
	public StartMenuHelpUI()
	{
	}
}
[Token(Token = "0x20000CC")]
public class StartMenuLogoEvents : MonoBehaviour
{
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x7C6F6C", Offset = "0x7C6F6C", VA = "0x7C6F6C")]
	public void PlayAudio(AudioClip clip)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x7C6FF0", Offset = "0x7C6FF0", VA = "0x7C6FF0")]
	public StartMenuLogoEvents()
	{
	}
}
[Token(Token = "0x20000CD")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600854", Offset = "0x600854")]
public class StartMenuUI : MonoBehaviour
{
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonStart;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScenesLoader _TutorialScene;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _LogoTime;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MenuPanelManager mMenuPanelManager;

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x7C6FF8", Offset = "0x7C6FF8", VA = "0x7C6FF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x7C71C4", Offset = "0x7C71C4", VA = "0x7C71C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x7C7260", Offset = "0x7C7260", VA = "0x7C7260")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x7C7128", Offset = "0x7C7128", VA = "0x7C7128")]
	public void PlayMusic()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x7C72D8", Offset = "0x7C72D8", VA = "0x7C72D8")]
	private void StartMusic()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x7C7330", Offset = "0x7C7330", VA = "0x7C7330")]
	public StartMenuUI()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x7C7340", Offset = "0x7C7340", VA = "0x7C7340")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6063A0", Offset = "0x6063A0")]
	private void <Awake>b__4_0()
	{
	}
}
[Token(Token = "0x20000CE")]
public class SteamDrawLineManager : MonoBehaviour
{
	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material lMat;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pencilWidth;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool drawing;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool picking;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color currentColor;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshLineRenderer currentLine;

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x7C752C", Offset = "0x7C752C", VA = "0x7C752C")]
	public LineRenderer CreateLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x7C7694", Offset = "0x7C7694", VA = "0x7C7694")]
	public MeshLineRenderer CreateMeshLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x7C77E4", Offset = "0x7C77E4", VA = "0x7C77E4")]
	public SteamDrawLineManager()
	{
	}
}
[Token(Token = "0x20000CF")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x6008BC", Offset = "0x6008BC")]
public class CopybooksManager : SingletonGameObject<CopybooksManager>
{
	[Token(Token = "0x20000D0")]
	public class Copybook
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Texture texture;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string path;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x12D6178", Offset = "0x12D6178", VA = "0x12D6178")]
		public Copybook(Texture texture, string path)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6008F0", Offset = "0x6008F0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<string, bool> <>9__7_0;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7DB19C", Offset = "0x7DB19C", VA = "0x7DB19C")]
		public <>c()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x7DB1A4", Offset = "0x7DB1A4", VA = "0x7DB1A4")]
		internal bool <Load>b__7_0(string name)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600900", Offset = "0x600900")]
	private sealed class <Load>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CopybooksManager <>4__this;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Texture, string> action;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string>.Enumerator <>7__wrap1;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <asset>5__3;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <w>5__4;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DownloadHandlerTexture <downloadHandler>5__5;

		[Token(Token = "0x17000101")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x7DB734", Offset = "0x7DB734", VA = "0x7DB734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x7DB77C", Offset = "0x7DB77C", VA = "0x7DB77C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x7DB1FC", Offset = "0x7DB1FC", VA = "0x7DB1FC")]
		[DebuggerHidden]
		public <Load>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x7DB228", Offset = "0x7DB228", VA = "0x7DB228", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x7DB2A0", Offset = "0x7DB2A0", VA = "0x7DB2A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x7DB244", Offset = "0x7DB244", VA = "0x7DB244")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x7DB73C", Offset = "0x7DB73C", VA = "0x7DB73C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000334")]
	private const string _CopybookPath = "Data\\Copybooks";

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Copybook> mLoadedCopybooks;

	[Token(Token = "0x170000FF")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x7C5758", Offset = "0x7C5758", VA = "0x7C5758", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000100")]
	public IReadOnlyList<Copybook> loadedCopybooks
	{
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x7C57D8", Offset = "0x7C57D8", VA = "0x7C57D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x7AF650", Offset = "0x7AF650", VA = "0x7AF650")]
	public void LoadCopybooks(Action<Texture, string> action)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x7C5760", Offset = "0x7C5760", VA = "0x7C5760")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6063B0", Offset = "0x6063B0")]
	private IEnumerator Load(Action<Texture, string> action)
	{
		return null;
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x7C57E0", Offset = "0x7C57E0", VA = "0x7C57E0")]
	public CopybooksManager()
	{
	}
}
[Token(Token = "0x20000D3")]
public class HintForControllerTooCloseToHead : MonoBehaviour
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _CheckRaduis;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mStartTime;

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x8228F0", Offset = "0x8228F0", VA = "0x8228F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x822918", Offset = "0x822918", VA = "0x822918")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x822B34", Offset = "0x822B34", VA = "0x822B34")]
	private bool CheckControllers(params VRBodyType[] controllers)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x822D90", Offset = "0x822D90", VA = "0x822D90")]
	public HintForControllerTooCloseToHead()
	{
	}
}
[Token(Token = "0x20000D4")]
public class StudyRoomController : SingletonGameObject<StudyRoomController>
{
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Paper _MainPaper;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BrushRecorder _BrushRecorder;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ScenesLoader _ScenesLoaderStartMenu;

	[Token(Token = "0x17000103")]
	public Paper mainPaper
	{
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7C8710", Offset = "0x7C8710", VA = "0x7C8710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000104")]
	public BrushRecorder brushRecorder
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7C8718", Offset = "0x7C8718", VA = "0x7C8718")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x7C8720", Offset = "0x7C8720", VA = "0x7C8720", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x7C87A4", Offset = "0x7C87A4", VA = "0x7C87A4")]
	public void Quit()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x7C8840", Offset = "0x7C8840", VA = "0x7C8840")]
	public StudyRoomController()
	{
	}
}
[Token(Token = "0x20000D5")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600910", Offset = "0x600910")]
public class CheckResourceNode : BehaviorTreeNode
{
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _ResourceKey;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ExecuteState mState;

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x7C2AD4", Offset = "0x7C2AD4", VA = "0x7C2AD4", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x7C2BCC", Offset = "0x7C2BCC", VA = "0x7C2BCC")]
	public CheckResourceNode()
	{
	}
}
[Token(Token = "0x20000D6")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x60094C", Offset = "0x60094C")]
public class DemonstrationActionNode : BehaviorTreeNode
{
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableFloat _Progress;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _MaxProgress;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _Prefab;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _Position;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject _Demonstration;

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x80E1B4", Offset = "0x80E1B4", VA = "0x80E1B4", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x80E2CC", Offset = "0x80E2CC", VA = "0x80E2CC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x80E450", Offset = "0x80E450", VA = "0x80E450")]
	public DemonstrationActionNode()
	{
	}
}
[Token(Token = "0x20000D7")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600988", Offset = "0x600988")]
public class HintNode : BehaviorTreeNode
{
	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string hinTextKey;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string hintTitleKey;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform target;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool showOnCamera;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int keepShowFrames;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string resource;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool viewNavgation;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool hasArrow;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite sprite;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string spriteLanResource;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool showProgress;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BehaviorVariableFloat _ProgressValue;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private HintController mController;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Slider mSlider;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int mFrames;

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x822DA0", Offset = "0x822DA0", VA = "0x822DA0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x8232A8", Offset = "0x8232A8", VA = "0x8232A8", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x8233A8", Offset = "0x8233A8", VA = "0x8233A8")]
	public HintNode()
	{
	}
}
[Token(Token = "0x20000D8")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x6009C4", Offset = "0x6009C4")]
public class IsTutorialNode : BehaviorTreeNode
{
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x8B40BC", Offset = "0x8B40BC", VA = "0x8B40BC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x8B411C", Offset = "0x8B411C", VA = "0x8B411C")]
	public IsTutorialNode()
	{
	}
}
[Token(Token = "0x20000D9")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600A00", Offset = "0x600A00")]
public class PlayAudioNode : BehaviorTreeNode
{
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip _Clip;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioSource _Source;

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x12CD554", Offset = "0x12CD554", VA = "0x12CD554", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x12CD5FC", Offset = "0x12CD5FC", VA = "0x12CD5FC")]
	public PlayAudioNode()
	{
	}
}
[Token(Token = "0x20000DA")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600A3C", Offset = "0x600A3C")]
public class SetObjectInterable : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _Interable;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InteractableObject _InteractableObject;

	[Token(Token = "0x17000105")]
	public string information
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x12D43B0", Offset = "0x12D43B0", VA = "0x12D43B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x12D4458", Offset = "0x12D4458", VA = "0x12D4458", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x12D44F4", Offset = "0x12D44F4", VA = "0x12D44F4")]
	public SetObjectInterable()
	{
	}
}
[Token(Token = "0x20000DB")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600A78", Offset = "0x600A78")]
public class TutorialCompleted : BehaviorTreeNode
{
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x7CC2C4", Offset = "0x7CC2C4", VA = "0x7CC2C4", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x7CC388", Offset = "0x7CC388", VA = "0x7CC388")]
	public TutorialCompleted()
	{
	}
}
[Token(Token = "0x20000DC")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600AB4", Offset = "0x600AB4")]
public class TutorialSelectTargetCopybook : WaitTargetCopybookSelected
{
	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _HintKeyApply;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _HintKeyApplyTitle;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string _HintKeySelect;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string _HintKeySelectTitle;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _HintTransform;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GalleryPanel _List;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _AutoScrollCd;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HintController _HintController;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float _CurrentAutoScrollCd;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int mLastSelectedIndex;

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x7CC390", Offset = "0x7CC390", VA = "0x7CC390", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x7CC3AC", Offset = "0x7CC3AC", VA = "0x7CC3AC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x7CC57C", Offset = "0x7CC57C", VA = "0x7CC57C")]
	private void ShowHint(string message, string title)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x7CC6EC", Offset = "0x7CC6EC", VA = "0x7CC6EC")]
	protected void Update()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x7CC784", Offset = "0x7CC784", VA = "0x7CC784")]
	public TutorialSelectTargetCopybook()
	{
	}
}
[Token(Token = "0x20000DD")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600AF0", Offset = "0x600AF0")]
public class WaitArtSaved : WaitMessageNode
{
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x7D54E0", Offset = "0x7D54E0", VA = "0x7D54E0", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x7D5538", Offset = "0x7D5538", VA = "0x7D5538")]
	public WaitArtSaved()
	{
	}
}
[Token(Token = "0x20000DE")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600B2C", Offset = "0x600B2C")]
public class WaitChiorgraphyPlaying : WaitEventNode
{
	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _invest;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private BrushRecorder mBrushRecorder;

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x7D5548", Offset = "0x7D5548", VA = "0x7D5548")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x7D55CC", Offset = "0x7D55CC", VA = "0x7D55CC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x7D568C", Offset = "0x7D568C", VA = "0x7D568C")]
	public WaitChiorgraphyPlaying()
	{
	}
}
[Token(Token = "0x20000DF")]
public abstract class WaitEventNode : BehaviorTreeNode
{
	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ExecuteState actionState;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x7D552C", Offset = "0x7D552C", VA = "0x7D552C")]
	public void SetDone()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x7D569C", Offset = "0x7D569C", VA = "0x7D569C")]
	public void SetFailed()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x7CC3A0", Offset = "0x7CC3A0", VA = "0x7CC3A0", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x7CC6D8", Offset = "0x7CC6D8", VA = "0x7CC6D8", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x7D5694", Offset = "0x7D5694", VA = "0x7D5694")]
	protected WaitEventNode()
	{
	}
}
[Token(Token = "0x20000E0")]
public abstract class WaitMessageNode : WaitEventNode
{
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x7D59E0", Offset = "0x7D59E0", VA = "0x7D59E0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60004DF")]
	public abstract bool OnMessage(GameMessageType msgType, int what, params object[] args);

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x7D5A6C", Offset = "0x7D5A6C", VA = "0x7D5A6C", Slot = "15")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x7D5540", Offset = "0x7D5540", VA = "0x7D5540")]
	protected WaitMessageNode()
	{
	}
}
[Token(Token = "0x20000E1")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600B68", Offset = "0x600B68")]
public class WaitInkGrounded : BehaviorTreeNode
{
	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InkStickGroundable _TargetInk;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x7D56A8", Offset = "0x7D56A8", VA = "0x7D56A8", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x7D5720", Offset = "0x7D5720", VA = "0x7D5720", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x7D5820", Offset = "0x7D5820", VA = "0x7D5820")]
	public WaitInkGrounded()
	{
	}
}
[Token(Token = "0x20000E2")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600BA4", Offset = "0x600BA4")]
public class WaitItemPickAndDroppedNode : WaitMessageNode
{
	[Token(Token = "0x20000E3")]
	private enum Option
	{
		[Token(Token = "0x4000374")]
		Pick,
		[Token(Token = "0x4000375")]
		Drop
	}

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _itemTag;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PickAndDropItem _targetItem;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Option _option;

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x7D5828", Offset = "0x7D5828", VA = "0x7D5828", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x7D59D8", Offset = "0x7D59D8", VA = "0x7D59D8")]
	public WaitItemPickAndDroppedNode()
	{
	}
}
[Token(Token = "0x20000E4")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600BE0", Offset = "0x600BE0")]
public class WaitMyPaintingsSelectedNode : WaitEventNode
{
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PaintingsList _paintingsList;

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x7D5AF8", Offset = "0x7D5AF8", VA = "0x7D5AF8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x7D5BE4", Offset = "0x7D5BE4", VA = "0x7D5BE4")]
	public WaitMyPaintingsSelectedNode()
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x7D5BEC", Offset = "0x7D5BEC", VA = "0x7D5BEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606468", Offset = "0x606468")]
	private void <Awake>b__1_0(int index)
	{
	}
}
[Token(Token = "0x20000E5")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600C1C", Offset = "0x600C1C")]
public class WaitPaintedNode : WaitMessageNode
{
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float motionTime;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string paperName;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float mCurrentMotionTime;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Paper mLastPlaper;

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x7D5D5C", Offset = "0x7D5D5C", VA = "0x7D5D5C", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x7D5D6C", Offset = "0x7D5D6C", VA = "0x7D5D6C", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x7D5F18", Offset = "0x7D5F18", VA = "0x7D5F18", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x7D5FC8", Offset = "0x7D5FC8", VA = "0x7D5FC8")]
	public WaitPaintedNode()
	{
	}
}
[Token(Token = "0x20000E6")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600C58", Offset = "0x600C58")]
public class WaitPanelOpenedNode : BehaviorTreeNode
{
	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MenuPanel targetPanel;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool closeWhenOpened;

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x7D5FD8", Offset = "0x7D5FD8", VA = "0x7D5FD8", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x7D6034", Offset = "0x7D6034", VA = "0x7D6034", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x7D6098", Offset = "0x7D6098", VA = "0x7D6098")]
	public WaitPanelOpenedNode()
	{
	}
}
[Token(Token = "0x20000E7")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600C94", Offset = "0x600C94")]
public class WaitPaperCleared : WaitMessageNode
{
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x7D60A8", Offset = "0x7D60A8", VA = "0x7D60A8", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x7D60F4", Offset = "0x7D60F4", VA = "0x7D60F4")]
	public WaitPaperCleared()
	{
	}
}
[Token(Token = "0x20000E8")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600CD0", Offset = "0x600CD0")]
public class WaitPickedColorNode : WaitMessageNode
{
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float motionTime;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float mCurrentMotionTime;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ColorPalette mLastColorPalette;

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x7D60FC", Offset = "0x7D60FC", VA = "0x7D60FC", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x7D6108", Offset = "0x7D6108", VA = "0x7D6108", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x7D6310", Offset = "0x7D6310", VA = "0x7D6310", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x7D63C0", Offset = "0x7D63C0", VA = "0x7D63C0")]
	public WaitPickedColorNode()
	{
	}
}
[Token(Token = "0x20000E9")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600D0C", Offset = "0x600D0C")]
public class WaitSetVideoTemplateNode : WaitMessageNode
{
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x7D63D0", Offset = "0x7D63D0", VA = "0x7D63D0", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x7D644C", Offset = "0x7D644C", VA = "0x7D644C")]
	public WaitSetVideoTemplateNode()
	{
	}
}
[Token(Token = "0x20000EA")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600D48", Offset = "0x600D48")]
public class WaitSimpleEventNode : WaitMessageNode
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int what;

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x7D6454", Offset = "0x7D6454", VA = "0x7D6454", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x7D64A4", Offset = "0x7D64A4", VA = "0x7D64A4")]
	public WaitSimpleEventNode()
	{
	}
}
[Token(Token = "0x20000EB")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600D84", Offset = "0x600D84")]
public class WaitSimpleEventsNode : WaitMessageNode
{
	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int[] whats;

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x7D64AC", Offset = "0x7D64AC", VA = "0x7D64AC", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x7D6544", Offset = "0x7D6544", VA = "0x7D6544")]
	public WaitSimpleEventsNode()
	{
	}
}
[Token(Token = "0x20000EC")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600DC0", Offset = "0x600DC0")]
public class WaitTargetCopybookSelected : WaitMessageNode
{
	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected string _targetCopybookName;

	[Token(Token = "0x17000106")]
	public string targetCopybookName
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7D6604", Offset = "0x7D6604", VA = "0x7D6604")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7D660C", Offset = "0x7D660C", VA = "0x7D660C")]
		set
		{
		}
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x7D6614", Offset = "0x7D6614", VA = "0x7D6614", Slot = "16")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x7CC79C", Offset = "0x7CC79C", VA = "0x7CC79C")]
	public WaitTargetCopybookSelected()
	{
	}
}
[Token(Token = "0x20000ED")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600DFC", Offset = "0x600DFC")]
public class WaitVideoPlayingNode : WaitEventNode
{
	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _invest;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x7D695C", Offset = "0x7D695C", VA = "0x7D695C", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x7D6A10", Offset = "0x7D6A10", VA = "0x7D6A10")]
	public WaitVideoPlayingNode()
	{
	}
}
[Token(Token = "0x20000EE")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x600E38", Offset = "0x600E38")]
public class WaitVRRecentered : WaitEventNode
{
	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int what;

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x7D6740", Offset = "0x7D6740", VA = "0x7D6740", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x7D681C", Offset = "0x7D681C", VA = "0x7D681C")]
	private void Platform_isRecentered()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x7D6858", Offset = "0x7D6858", VA = "0x7D6858", Slot = "15")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x7D6954", Offset = "0x7D6954", VA = "0x7D6954")]
	public WaitVRRecentered()
	{
	}
}
[Token(Token = "0x20000EF")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600E74", Offset = "0x600E74")]
public class DemonstrationAction : MonoBehaviour
{
	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationInvoker[] _Animations;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float[] _LayerWeights;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _PlayOnAwake;

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x80E0A0", Offset = "0x80E0A0", VA = "0x80E0A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x80E0B0", Offset = "0x80E0B0", VA = "0x80E0B0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x80E1AC", Offset = "0x80E1AC", VA = "0x80E1AC")]
	public DemonstrationAction()
	{
	}
}
[Token(Token = "0x20000F0")]
public class BallEffectCtrl : MonoBehaviour
{
	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject effect;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer mat;

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x7B651C", Offset = "0x7B651C", VA = "0x7B651C")]
	private void OnUITrigger()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x7B6598", Offset = "0x7B6598", VA = "0x7B6598")]
	public BallEffectCtrl()
	{
	}
}
[Token(Token = "0x20000F1")]
public class ButtonEfx : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip pointerEnter;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip pointerClick;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool vibrationOnEnter;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float vibrationOnEnterTime;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float vibrationOnEnterAmplitude;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Selectable mSelectable;

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x7BDEDC", Offset = "0x7BDEDC", VA = "0x7BDEDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x7BDF38", Offset = "0x7BDF38", VA = "0x7BDF38", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x7BE01C", Offset = "0x7BE01C", VA = "0x7BE01C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x7BE44C", Offset = "0x7BE44C", VA = "0x7BE44C")]
	public ButtonEfx()
	{
	}
}
[Token(Token = "0x20000F2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600EDC", Offset = "0x600EDC")]
public class ButtonToggle : MonoBehaviour
{
	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x7BE468", Offset = "0x7BE468", VA = "0x7BE468")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x7BE520", Offset = "0x7BE520", VA = "0x7BE520")]
	public ButtonToggle()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x7BE528", Offset = "0x7BE528", VA = "0x7BE528")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606478", Offset = "0x606478")]
	private void <Awake>b__1_0()
	{
	}
}
[Token(Token = "0x20000F3")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600F44", Offset = "0x600F44")]
public class DeskHandle : InteractableVRObject
{
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject desk;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float minDeskheight;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float maxDeskHeight;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color normalColor;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color highlightColor;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color pressedColor;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material highlightMaterial;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string highlighColorName;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private AudioClip _AudioHoldOn;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private AudioClip _AudioHoldingMove;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AudioClip _AudioHoldOff;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string _HoldingAnimationTrigger;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private string _HoldingAlignPosition;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float mBaseDeskY;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float mStartDeskHeightDelta;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float mStartHandY;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool mIsHolding;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private HandController mHoldingHand;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform mHoldingHandAlignPosition;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 mHoldingResetPosition;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Quaternion mHoldingResetRotation;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float mCatchedDeskHeight;

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x80E458", Offset = "0x80E458", VA = "0x80E458", Slot = "17")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x80E724", Offset = "0x80E724", VA = "0x80E724")]
	private void SetHighlighColor(Color color)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x80E810", Offset = "0x80E810", VA = "0x80E810", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x80E8F0", Offset = "0x80E8F0", VA = "0x80E8F0", Slot = "19")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x80E564", Offset = "0x80E564", VA = "0x80E564")]
	private void SetHeight(float height)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x80EDD4", Offset = "0x80EDD4", VA = "0x80EDD4", Slot = "20")]
	protected override void OnProcessEvents(VRHandInput vrInput)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x80F088", Offset = "0x80F088", VA = "0x80F088", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x80F0BC", Offset = "0x80F0BC", VA = "0x80F0BC", Slot = "13")]
	public override void OnExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x80EF3C", Offset = "0x80EF3C", VA = "0x80EF3C")]
	private void End()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x80F374", Offset = "0x80F374", VA = "0x80F374")]
	public DeskHandle()
	{
	}
}
[Token(Token = "0x20000F4")]
public class DialogBuilder : MonoBehaviour
{
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FAC", Offset = "0x600FAC")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<string, bool> onClicked;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DialogBuilder <>4__this;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x12D6CDC", Offset = "0x12D6CDC", VA = "0x12D6CDC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x12D6CE4", Offset = "0x12D6CE4", VA = "0x12D6CE4")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _TextTitle;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _TextMessage;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _ButtonsPanel;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _TemplateButton;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<GameObject> mButtons;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Func<string, bool> mOnClicked;

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x80F470", Offset = "0x80F470", VA = "0x80F470")]
	private void Awake()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x80F4A0", Offset = "0x80F4A0", VA = "0x80F4A0")]
	public DialogBuilder Clear()
	{
		return null;
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x80F648", Offset = "0x80F648", VA = "0x80F648")]
	public DialogBuilder SetTitle(string title)
	{
		return null;
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x80F704", Offset = "0x80F704", VA = "0x80F704")]
	public DialogBuilder SetMessage(string message)
	{
		return null;
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x80F7C0", Offset = "0x80F7C0", VA = "0x80F7C0")]
	public DialogBuilder AddButton(string key, string text, [Optional] Func<string, bool> onClicked)
	{
		return null;
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x80F9F4", Offset = "0x80F9F4", VA = "0x80F9F4")]
	public DialogBuilder SetButtonListener(Func<string, bool> onClicked)
	{
		return null;
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x80F9FC", Offset = "0x80F9FC", VA = "0x80F9FC")]
	public void Open()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x80FA74", Offset = "0x80FA74", VA = "0x80FA74")]
	public void Close()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x80FADC", Offset = "0x80FADC", VA = "0x80FADC")]
	public DialogBuilder()
	{
	}
}
[Token(Token = "0x20000F6")]
public class ImagePaperTemplate : AbsGalleryPaperTemplate
{
	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x60366C", Offset = "0x60366C")]
	private Image mImage;

	[Token(Token = "0x14000002")]
	public override event OnPagerClicked Clicked
	{
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x8B0E7C", Offset = "0x8B0E7C", VA = "0x8B0E7C", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606488", Offset = "0x606488")]
		add
		{
		}
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x8B0F1C", Offset = "0x8B0F1C", VA = "0x8B0F1C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606498", Offset = "0x606498")]
		remove
		{
		}
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x8B0FBC", Offset = "0x8B0FBC", VA = "0x8B0FBC", Slot = "8")]
	public override void OnSetContentIndex(int index, GalleryPanel panel)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x8B0FC0", Offset = "0x8B0FC0", VA = "0x8B0FC0", Slot = "9")]
	public override bool UpdatePaper(GalleryPanel panel)
	{
		return default(bool);
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x8B1000", Offset = "0x8B1000", VA = "0x8B1000", Slot = "10")]
	public override void CopyStateFrom(AbsGalleryPaperTemplate from)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x8B1040", Offset = "0x8B1040", VA = "0x8B1040")]
	public ImagePaperTemplate()
	{
	}
}
[Token(Token = "0x20000F7")]
public class LevelListController : MonoBehaviour
{
	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _startButton;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UILevelList _levelList;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x8B53D0", Offset = "0x8B53D0", VA = "0x8B53D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x8B5550", Offset = "0x8B5550", VA = "0x8B5550")]
	private void Load(int index)
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x8B5724", Offset = "0x8B5724", VA = "0x8B5724")]
	public void SetTutorialMode(bool tutorial)
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x8B578C", Offset = "0x8B578C", VA = "0x8B578C")]
	public LevelListController()
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x8B5794", Offset = "0x8B5794", VA = "0x8B5794")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064A8", Offset = "0x6064A8")]
	private void <Awake>b__2_0(int index)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x8B58C4", Offset = "0x8B58C4", VA = "0x8B58C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064B8", Offset = "0x6064B8")]
	private void <Awake>b__2_1(int index)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x8B58C8", Offset = "0x8B58C8", VA = "0x8B58C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064C8", Offset = "0x6064C8")]
	private void <Awake>b__2_2()
	{
	}
}
[Token(Token = "0x20000F8")]
public class LevelListItemEvent : MonoBehaviour
{
	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip _AudioAction;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvents.EmptyEvent _OnAction;

	[Token(Token = "0x17000107")]
	public UnityEvents.EmptyEvent onAction
	{
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x8B58E8", Offset = "0x8B58E8", VA = "0x8B58E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x8B58F0", Offset = "0x8B58F0", VA = "0x8B58F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x8B5984", Offset = "0x8B5984", VA = "0x8B5984")]
	public LevelListItemEvent()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x8B598C", Offset = "0x8B598C", VA = "0x8B598C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064D8", Offset = "0x6064D8")]
	private void <Start>b__4_0()
	{
	}
}
[Token(Token = "0x20000F9")]
public abstract class MediaPlayerController : MonoBehaviour
{
	[Token(Token = "0x20000FA")]
	public interface MediaPlayer
	{
		[Token(Token = "0x17000109")]
		bool isPlaying
		{
			[Token(Token = "0x6000546")]
			get;
			[Token(Token = "0x6000547")]
			set;
		}

		[Token(Token = "0x1700010A")]
		bool isPaused
		{
			[Token(Token = "0x6000548")]
			get;
			[Token(Token = "0x6000549")]
			set;
		}

		[Token(Token = "0x1700010B")]
		bool canPlay
		{
			[Token(Token = "0x600054C")]
			get;
		}

		[Token(Token = "0x1700010C")]
		bool canPlayNext
		{
			[Token(Token = "0x600054D")]
			get;
		}

		[Token(Token = "0x1700010D")]
		bool canPlayPrev
		{
			[Token(Token = "0x600054E")]
			get;
		}

		[Token(Token = "0x1700010E")]
		float volumn
		{
			[Token(Token = "0x600054F")]
			get;
			[Token(Token = "0x6000550")]
			set;
		}

		[Token(Token = "0x1700010F")]
		float time
		{
			[Token(Token = "0x6000551")]
			get;
			[Token(Token = "0x6000552")]
			set;
		}

		[Token(Token = "0x17000110")]
		float length
		{
			[Token(Token = "0x6000553")]
			get;
		}

		[Token(Token = "0x600054A")]
		void PlayNext();

		[Token(Token = "0x600054B")]
		void PlayPrev();
	}

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _buttonPlayNext;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _buttonPlayPrev;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _buttonPlay;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button _buttonPause;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button _buttonVolumnUp;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button _buttonVolumnDown;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Slider _sliderVolumn;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Slider _sliderProgress;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float volumnDelta;

	[Token(Token = "0x17000108")]
	protected abstract MediaPlayer mediaPlayer
	{
		[Token(Token = "0x600053A")]
		get;
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x8B83BC", Offset = "0x8B83BC", VA = "0x8B83BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x8B8880", Offset = "0x8B8880", VA = "0x8B8880")]
	private void Update()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x8B8E9C", Offset = "0x8B8E9C", VA = "0x8B8E9C")]
	protected MediaPlayerController()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x8B8EB0", Offset = "0x8B8EB0", VA = "0x8B8EB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064E8", Offset = "0x6064E8")]
	private void <Awake>b__11_0()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x8B8F70", Offset = "0x8B8F70", VA = "0x8B8F70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064F8", Offset = "0x6064F8")]
	private void <Awake>b__11_1()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x8B9030", Offset = "0x8B9030", VA = "0x8B9030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606508", Offset = "0x606508")]
	private void <Awake>b__11_2()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x8B910C", Offset = "0x8B910C", VA = "0x8B910C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606518", Offset = "0x606518")]
	private void <Awake>b__11_3()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x8B91E8", Offset = "0x8B91E8", VA = "0x8B91E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606528", Offset = "0x606528")]
	private void <Awake>b__11_4()
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x8B9340", Offset = "0x8B9340", VA = "0x8B9340")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606538", Offset = "0x606538")]
	private void <Awake>b__11_5()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x8B9498", Offset = "0x8B9498", VA = "0x8B9498")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606548", Offset = "0x606548")]
	private void <Awake>b__11_6(float value)
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x8B961C", Offset = "0x8B961C", VA = "0x8B961C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606558", Offset = "0x606558")]
	private void <Awake>b__11_7(float value)
	{
	}
}
[Token(Token = "0x20000FB")]
public class MovieList : PlayableList
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MoviePlayer mMoviePlayer;

	[Token(Token = "0x17000111")]
	public override object currentPlayble
	{
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x8BC5EC", Offset = "0x8BC5EC", VA = "0x8BC5EC", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000112")]
	public override bool isPlaying
	{
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x8BC60C", Offset = "0x8BC60C", VA = "0x8BC60C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x8BC188", Offset = "0x8BC188", VA = "0x8BC188")]
	private void Start()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x8BC450", Offset = "0x8BC450", VA = "0x8BC450", Slot = "5")]
	protected override void OnRowClicked(PlayableListRow listRow)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x8BC654", Offset = "0x8BC654", VA = "0x8BC654")]
	public void BtnPlayNext()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x8BC7C8", Offset = "0x8BC7C8", VA = "0x8BC7C8")]
	public void BtnPlayBack()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x8BC940", Offset = "0x8BC940", VA = "0x8BC940")]
	public void BtnPlay()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x8BCA40", Offset = "0x8BCA40", VA = "0x8BCA40")]
	public void AudioVolumnUp(float up)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x8BCAC0", Offset = "0x8BCAC0", VA = "0x8BCAC0")]
	public MovieList()
	{
	}
}
[Token(Token = "0x20000FC")]
public class MoviePlayButton : PlayButton
{
	[Token(Token = "0x17000113")]
	protected override bool isPlaying
	{
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x8BCAC8", Offset = "0x8BCAC8", VA = "0x8BCAC8", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x8BCB54", Offset = "0x8BCB54", VA = "0x8BCB54", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x8BCBC4", Offset = "0x8BCBC4", VA = "0x8BCBC4")]
	public MoviePlayButton()
	{
	}
}
[Token(Token = "0x20000FD")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x600FBC", Offset = "0x600FBC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600FBC", Offset = "0x600FBC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600FBC", Offset = "0x600FBC")]
public class MoviePlayer : SingletonGameObject<MoviePlayer>, MediaPlayerController.MediaPlayer
{
	[Serializable]
	[Token(Token = "0x20000FE")]
	public class Movie
	{
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip clip;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUnlocked;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D template;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x12DA0B0", Offset = "0x12DA0B0", VA = "0x12DA0B0")]
		public Movie()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000FF")]
	public class MovieGroup
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Movie> movies;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x12DA0B8", Offset = "0x12DA0B8", VA = "0x12DA0B8")]
		public MovieGroup()
		{
		}
	}

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MovieGroup[] _groups;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioMixerGroup _musicGroup;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _downMusicAttenuation;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VideoPlayer mPlayer;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Movie mCurrentMovie;

	[Token(Token = "0x17000114")]
	public bool isPaused
	{
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x8BCDC4", Offset = "0x8BCDC4", VA = "0x8BCDC4", Slot = "9")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x8BC9A4", Offset = "0x8BC9A4", VA = "0x8BC9A4", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000115")]
	public bool isPlaying
	{
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8BC634", Offset = "0x8BC634", VA = "0x8BC634", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8BC9D4", Offset = "0x8BC9D4", VA = "0x8BC9D4", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000116")]
	public Movie currentMovie
	{
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x8BCFC0", Offset = "0x8BCFC0", VA = "0x8BCFC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000117")]
	public MovieGroup[] Groups
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8BCFC8", Offset = "0x8BCFC8", VA = "0x8BCFC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000118")]
	public VideoPlayer player
	{
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8BCFD0", Offset = "0x8BCFD0", VA = "0x8BCFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000119")]
	public bool canPlay
	{
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8BCFD8", Offset = "0x8BCFD8", VA = "0x8BCFD8", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700011A")]
	public bool canPlayNext
	{
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8BCFE0", Offset = "0x8BCFE0", VA = "0x8BCFE0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700011B")]
	public bool canPlayPrev
	{
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x8BCFE8", Offset = "0x8BCFE8", VA = "0x8BCFE8", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700011C")]
	public float volumn
	{
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x8BCFF0", Offset = "0x8BCFF0", VA = "0x8BCFF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x8BD010", Offset = "0x8BD010", VA = "0x8BD010", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x1700011D")]
	public float time
	{
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8BD030", Offset = "0x8BD030", VA = "0x8BD030", Slot = "18")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8BD058", Offset = "0x8BD058", VA = "0x8BD058", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x1700011E")]
	public float length
	{
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x8BD07C", Offset = "0x8BD07C", VA = "0x8BD07C", Slot = "20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x8BCBCC", Offset = "0x8BCBCC", VA = "0x8BCBCC", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x8BCD04", Offset = "0x8BCD04", VA = "0x8BCD04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x8BCDA4", Offset = "0x8BCDA4", VA = "0x8BCDA4")]
	private void MPlayer_prepareCompleted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x8BCDE4", Offset = "0x8BCDE4", VA = "0x8BCDE4")]
	public void PlayAt(int groupIndex, int movieIndex)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x8BC4EC", Offset = "0x8BC4EC", VA = "0x8BC4EC")]
	public void Play(Movie movie)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x8BC670", Offset = "0x8BC670", VA = "0x8BC670")]
	public bool PlayNext()
	{
		return default(bool);
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x8BC7E4", Offset = "0x8BC7E4", VA = "0x8BC7E4")]
	public bool PlayBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x8BCE8C", Offset = "0x8BCE8C", VA = "0x8BCE8C")]
	public bool FindIndex(Movie movie, [Out] int groupIndex, [Out] int movieIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x8BD0A4", Offset = "0x8BD0A4", VA = "0x8BD0A4", Slot = "11")]
	private void MediaPlayerController.MediaPlayer.PlayNext()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x8BD0A8", Offset = "0x8BD0A8", VA = "0x8BD0A8", Slot = "12")]
	public void PlayPrev()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x8BD0AC", Offset = "0x8BD0AC", VA = "0x8BD0AC")]
	public MoviePlayer()
	{
	}
}
[Token(Token = "0x2000100")]
public class MoviePlayerController : MonoBehaviour
{
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _timeFormatKey;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Slider _sliderProgress;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text _textTime;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RawImage _videoView;

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x8BD108", Offset = "0x8BD108", VA = "0x8BD108")]
	private void Awake()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x8BD1EC", Offset = "0x8BD1EC", VA = "0x8BD1EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x8BD4A0", Offset = "0x8BD4A0", VA = "0x8BD4A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x8BD4A4", Offset = "0x8BD4A4", VA = "0x8BD4A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x8BD1F0", Offset = "0x8BD1F0", VA = "0x8BD1F0")]
	private void UpdateSlider()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x8BD52C", Offset = "0x8BD52C", VA = "0x8BD52C")]
	private void SetProgress(float progress)
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x8BD63C", Offset = "0x8BD63C", VA = "0x8BD63C")]
	public MoviePlayerController()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x8BD644", Offset = "0x8BD644", VA = "0x8BD644")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606568", Offset = "0x606568")]
	private void <Awake>b__4_0(float value)
	{
	}
}
[Token(Token = "0x2000101")]
public class MusicList : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60107C", Offset = "0x60107C")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<MusicListRow> <>9__4_0;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x12DA450", Offset = "0x12DA450", VA = "0x12DA450")]
		public <>c()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x12DA458", Offset = "0x12DA458", VA = "0x12DA458")]
		internal void <Start>b__4_0(MusicListRow row)
		{
		}
	}

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<MusicListRow> mRows;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MusicListRow mTemplateRow;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mNeedScrollToSelected;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MusicPlayer.MusicInfo mLastPlaying;

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x8C002C", Offset = "0x8C002C", VA = "0x8C002C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x8C0208", Offset = "0x8C0208", VA = "0x8C0208")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x8C0214", Offset = "0x8C0214", VA = "0x8C0214")]
	private void Update()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x8C07F0", Offset = "0x8C07F0", VA = "0x8C07F0")]
	private void ScrollToVisible(GameObject go)
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x8C085C", Offset = "0x8C085C", VA = "0x8C085C")]
	public void OnClickDelegate(PointerEventData eventData, GameObject obj)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x8C0A14", Offset = "0x8C0A14", VA = "0x8C0A14")]
	public MusicList()
	{
	}
}
[Token(Token = "0x2000103")]
public class MusicListRow : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x2000104")]
	public delegate void OnClickDelegate(PointerEventData eventData, GameObject obj);

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI title;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image playIcon;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button button;

	[Token(Token = "0x14000003")]
	public event OnClickDelegate OnClicked
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x8C0750", Offset = "0x8C0750", VA = "0x8C0750")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606578", Offset = "0x606578")]
		add
		{
		}
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8C0A1C", Offset = "0x8C0A1C", VA = "0x8C0A1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606588", Offset = "0x606588")]
		remove
		{
		}
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x8C0ABC", Offset = "0x8C0ABC", VA = "0x8C0ABC", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x8C0B04", Offset = "0x8C0B04", VA = "0x8C0B04")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x8C0B0C", Offset = "0x8C0B0C", VA = "0x8C0B0C")]
	public MusicListRow()
	{
	}
}
[Token(Token = "0x2000105")]
public class MusicPlayButton : PlayButton
{
	[Token(Token = "0x1700011F")]
	protected override bool isPlaying
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8C0B14", Offset = "0x8C0B14", VA = "0x8C0B14", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x8C0BB4", Offset = "0x8C0BB4", VA = "0x8C0BB4", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x8C0C24", Offset = "0x8C0C24", VA = "0x8C0C24")]
	public MusicPlayButton()
	{
	}
}
[Token(Token = "0x2000106")]
public abstract class PlayButton : MonoBehaviour
{
	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playTextKey;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string pauseTextKey;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool prePlayState;

	[Token(Token = "0x17000120")]
	protected abstract bool isPlaying
	{
		[Token(Token = "0x6000599")]
		get;
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x12CD604", Offset = "0x12CD604", VA = "0x12CD604")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x12CD6E0", Offset = "0x12CD6E0", VA = "0x12CD6E0")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x12CD6EC", Offset = "0x12CD6EC", VA = "0x12CD6EC", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x12CD7B8", Offset = "0x12CD7B8", VA = "0x12CD7B8", Slot = "6")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x12CD824", Offset = "0x12CD824", VA = "0x12CD824", Slot = "7")]
	protected virtual void UpdateText()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x12CD8DC", Offset = "0x12CD8DC", VA = "0x12CD8DC")]
	protected PlayButton()
	{
	}
}
[Token(Token = "0x2000107")]
public class MusicPlayerController : MediaPlayerController
{
	[Token(Token = "0x17000121")]
	protected override MediaPlayer mediaPlayer
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x8C1D0C", Offset = "0x8C1D0C", VA = "0x8C1D0C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x8C1D80", Offset = "0x8C1D80", VA = "0x8C1D80")]
	public MusicPlayerController()
	{
	}
}
[Token(Token = "0x2000108")]
public class PaintingPreview : MonoBehaviour
{
	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject template;

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x12C278C", Offset = "0x12C278C", VA = "0x12C278C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x12C2790", Offset = "0x12C2790", VA = "0x12C2790")]
	private void Update()
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x12C2794", Offset = "0x12C2794", VA = "0x12C2794")]
	public void SetTexture(Texture texture)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x12C2798", Offset = "0x12C2798", VA = "0x12C2798")]
	public PaintingPreview()
	{
	}
}
[Token(Token = "0x2000109")]
public class PaintingsList : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[Token(Token = "0x200010A")]
	private class ScrollAction
	{
		[Token(Token = "0x200010B")]
		public enum State
		{
			[Token(Token = "0x40003FC")]
			Start,
			[Token(Token = "0x40003FD")]
			Scrolling
		}

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public State state;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float startTime;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lastScrollTime;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lastHoldingFrame;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x12DBAD4", Offset = "0x12DBAD4", VA = "0x12DBAD4")]
		public ScrollAction()
		{
		}
	}

	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60108C", Offset = "0x60108C")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PicGrid newGrid;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PaintingsList <>4__this;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x12DB918", Offset = "0x12DB918", VA = "0x12DB918")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x12DB920", Offset = "0x12DB920", VA = "0x12DB920")]
		internal void <SetUpImages>b__0()
		{
		}
	}

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PicGrid template;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage previewImage;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scrollSmooth;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject loadingHint;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private FileUtils.MediaType _MediaType;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioClip _AudioPaging;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip _AudioClicked;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _ScrollDeltaTime;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _ScrollHoldDeltaTime;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<PicGrid> mGrids;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LayoutGroup mLayout;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mTargetOffset;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3[] mTempCorners;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PicGrid mSeletedGrid;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UnityEvents.IntEvent _onListItemSelected;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UnityEvents.IntEvent _onListItemClicked;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool mTeleport;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private SavedPaintings mSavedPaintings;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float mLastScrollTime;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ScrollAction mScrollState;

	[Token(Token = "0x17000122")]
	public UnityEvents.IntEvent onListItemSelected
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x12C413C", Offset = "0x12C413C", VA = "0x12C413C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000123")]
	public UnityEvents.IntEvent onListItemClicked
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x12C4144", Offset = "0x12C4144", VA = "0x12C4144")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000124")]
	public PicGrid seletedGrid
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x12C414C", Offset = "0x12C414C", VA = "0x12C414C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x12C4154", Offset = "0x12C4154", VA = "0x12C4154")]
		set
		{
		}
	}

	[Token(Token = "0x17000125")]
	public SavedPaintings savedPaintings
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x12C4390", Offset = "0x12C4390", VA = "0x12C4390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x12C42F4", Offset = "0x12C42F4", VA = "0x12C42F4")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x12C4398", Offset = "0x12C4398", VA = "0x12C4398")]
	public int IndexOf(PicGrid grid)
	{
		return default(int);
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x12C43FC", Offset = "0x12C43FC", VA = "0x12C43FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x12C453C", Offset = "0x12C453C", VA = "0x12C453C")]
	public SavedPaintings.Painting GetSelectedSavedPanting()
	{
		return null;
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x12C46E0", Offset = "0x12C46E0", VA = "0x12C46E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x12C4708", Offset = "0x12C4708", VA = "0x12C4708")]
	private void LoadImages()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x12C4C08", Offset = "0x12C4C08", VA = "0x12C4C08")]
	private void SetUpImages()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x12C50CC", Offset = "0x12C50CC", VA = "0x12C50CC")]
	private void SavedPaintings_OnPaintingsChanged(int index, SavedPaintings.ChangeType type)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x12C5440", Offset = "0x12C5440", VA = "0x12C5440")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x12C5760", Offset = "0x12C5760", VA = "0x12C5760")]
	public void UpdateVisibles()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x12C5D58", Offset = "0x12C5D58", VA = "0x12C5D58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x12C5D5C", Offset = "0x12C5D5C", VA = "0x12C5D5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x12C5E60", Offset = "0x12C5E60", VA = "0x12C5E60", Slot = "4")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x12C5FA8", Offset = "0x12C5FA8", VA = "0x12C5FA8")]
	private void Scroll(float dir)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x12C60B4", Offset = "0x12C60B4", VA = "0x12C60B4")]
	public PaintingsList()
	{
	}
}
[Token(Token = "0x200010D")]
public class PaintingsListController : MonoBehaviour
{
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PaintingsList _List;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonApply;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonDelete;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Paper.PaperTemplateType _ApplyType;

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x12C61A8", Offset = "0x12C61A8", VA = "0x12C61A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x12C6410", Offset = "0x12C6410", VA = "0x12C6410")]
	private void Apply()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x12C66A4", Offset = "0x12C66A4", VA = "0x12C66A4")]
	public PaintingsListController()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x12C66AC", Offset = "0x12C66AC", VA = "0x12C66AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606598", Offset = "0x606598")]
	private void <Start>b__4_0()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x12C66B0", Offset = "0x12C66B0", VA = "0x12C66B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065A8", Offset = "0x6065A8")]
	private void <Start>b__4_1(int index)
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x12C66B4", Offset = "0x12C66B4", VA = "0x12C66B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065B8", Offset = "0x6065B8")]
	private void <Start>b__4_2()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x12C6770", Offset = "0x12C6770", VA = "0x12C6770")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065C8", Offset = "0x6065C8")]
	private void <Start>b__4_3(int index)
	{
	}
}
[Token(Token = "0x200010E")]
public class PhotoFrameList : MonoBehaviour, ILayoutGroup, ILayoutController
{
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60109C", Offset = "0x60109C")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PhotoFrameListItem item;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PhotoFrameList <>4__this;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x12DCD38", Offset = "0x12DCD38", VA = "0x12DCD38")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x12DCD40", Offset = "0x12DCD40", VA = "0x12DCD40")]
		internal void <Awake>b__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010AC", Offset = "0x6010AC")]
	private sealed class <>c
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<PhotoFrameListItem> <>9__20_0;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<PhotoFrameListItem> <>9__20_1;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x12DCC68", Offset = "0x12DCC68", VA = "0x12DCC68")]
		public <>c()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x12DCC70", Offset = "0x12DCC70", VA = "0x12DCC70")]
		internal void <Awake>b__20_0(PhotoFrameListItem item)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x12DCD08", Offset = "0x12DCD08", VA = "0x12DCD08")]
		internal void <Awake>b__20_1(PhotoFrameListItem item)
		{
		}
	}

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectOffset _Padding;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _Space;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector2 _ItemSize;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _ScrollSmooth;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PhotoFrameListItem _Preview;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private FileUtils.MediaType _MediaType;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PhotoFrameListItem mSelectedItem;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int mSelectedIndex;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<PhotoFrameListItem> mItems;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DrivenRectTransformTracker mTracker;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float mScrollOffset;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RectTransform mRectTransform;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private PhotoFrameListItem mItemTemplate;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ObjectPool<PhotoFrameListItem> mItemsPool;

	[Token(Token = "0x17000126")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x12C9AC0", Offset = "0x12C9AC0", VA = "0x12C9AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000127")]
	public PhotoFrameListItem selectedItem
	{
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x12C9CF0", Offset = "0x12C9CF0", VA = "0x12C9CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x12C9CF8", Offset = "0x12C9CF8", VA = "0x12C9CF8")]
		set
		{
		}
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x12C9B68", Offset = "0x12C9B68", VA = "0x12C9B68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x12C9E08", Offset = "0x12C9E08", VA = "0x12C9E08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x12CA390", Offset = "0x12CA390", VA = "0x12CA390")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x12CAA78", Offset = "0x12CAA78", VA = "0x12CAA78", Slot = "4")]
	public void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x12CACA4", Offset = "0x12CACA4", VA = "0x12CACA4", Slot = "5")]
	public void SetLayoutVertical()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x12CAE5C", Offset = "0x12CAE5C", VA = "0x12CAE5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x12C9B6C", Offset = "0x12C9B6C", VA = "0x12C9B6C")]
	private void Invalidate()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x12CAF14", Offset = "0x12CAF14", VA = "0x12CAF14")]
	public PhotoFrameList()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x12CAFB0", Offset = "0x12CAFB0", VA = "0x12CAFB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065D8", Offset = "0x6065D8")]
	private PhotoFrameListItem <Awake>b__20_2()
	{
		return null;
	}
}
[Token(Token = "0x2000111")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6010BC", Offset = "0x6010BC")]
public class PhotoFrameListData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000112")]
	public class Data
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sprite _Sprite;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectOffset _Offset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _Scale;

		[Token(Token = "0x1700012A")]
		public Sprite sprite
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x12DCD68", Offset = "0x12DCD68", VA = "0x12DCD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public RectOffset offset
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x12DCD70", Offset = "0x12DCD70", VA = "0x12DCD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public float scale
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x12DCD78", Offset = "0x12DCD78", VA = "0x12DCD78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x12DCD80", Offset = "0x12DCD80", VA = "0x12DCD80")]
		public Data()
		{
		}
	}

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Data> _Data;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PhotoFrameListData mInstance;

	[Token(Token = "0x17000128")]
	public static PhotoFrameListData instance
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x12CA71C", Offset = "0x12CA71C", VA = "0x12CA71C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000129")]
	public IReadOnlyList<Data> data
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x12CB138", Offset = "0x12CB138", VA = "0x12CB138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x12CB140", Offset = "0x12CB140", VA = "0x12CB140")]
	public PhotoFrameListData()
	{
	}
}
[Token(Token = "0x2000113")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6010F8", Offset = "0x6010F8")]
public class PhotoFrameListItem : MonoBehaviour
{
	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _Button;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image _Frame;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RawImage _Preview;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform mRectTransform;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PhotoFrameListData.Data mData;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603998", Offset = "0x603998")]
	private bool <isChecked>k__BackingField;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6039A8", Offset = "0x6039A8")]
	private float <scale>k__BackingField;

	[Token(Token = "0x1700012D")]
	public bool isChecked
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x12CB148", Offset = "0x12CB148", VA = "0x12CB148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065E8", Offset = "0x6065E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x12CB150", Offset = "0x12CB150", VA = "0x12CB150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6065F8", Offset = "0x6065F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700012E")]
	public PhotoFrameListData.Data data
	{
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x12CB15C", Offset = "0x12CB15C", VA = "0x12CB15C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x12CA7FC", Offset = "0x12CA7FC", VA = "0x12CA7FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public Texture previewTexture
	{
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x12CB164", Offset = "0x12CB164", VA = "0x12CB164")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x12CAEF4", Offset = "0x12CAEF4", VA = "0x12CAEF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000130")]
	public float scale
	{
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x12CB184", Offset = "0x12CB184", VA = "0x12CB184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606608", Offset = "0x606608")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x12CB18C", Offset = "0x12CB18C", VA = "0x12CB18C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606618", Offset = "0x606618")]
		set
		{
		}
	}

	[Token(Token = "0x17000131")]
	public Button button
	{
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x12CB194", Offset = "0x12CB194", VA = "0x12CB194")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000132")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x12CABFC", Offset = "0x12CABFC", VA = "0x12CABFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x12CB19C", Offset = "0x12CB19C", VA = "0x12CB19C")]
	public PhotoFrameListItem()
	{
	}
}
[Token(Token = "0x2000114")]
public class PicGrid : MonoBehaviour
{
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6039B8", Offset = "0x6039B8")]
	[SerializeField]
	private RawImage m_Image;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Graphic _Selected;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Button mButton;

	[Token(Token = "0x17000133")]
	public bool isChecked
	{
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x12C5740", Offset = "0x12C5740", VA = "0x12C5740")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x12C42D0", Offset = "0x12C42D0", VA = "0x12C42D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public RawImage image
	{
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x12CB1A4", Offset = "0x12CB1A4", VA = "0x12CB1A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000135")]
	public Button button
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x12C5024", Offset = "0x12C5024", VA = "0x12C5024")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x12CB1AC", Offset = "0x12CB1AC", VA = "0x12CB1AC")]
	public PicGrid()
	{
	}
}
[Token(Token = "0x2000115")]
public abstract class PlayableList : MonoBehaviour
{
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601160", Offset = "0x601160")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayableListRow row;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayableList <>4__this;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x12DCFC0", Offset = "0x12DCFC0", VA = "0x12DCFC0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x12DCFC8", Offset = "0x12DCFC8", VA = "0x12DCFC8")]
		internal void <Awake>b__6()
		{
		}
	}

	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601170", Offset = "0x601170")]
	private sealed class <>c__DisplayClass5_1
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayableListHead head;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayableList <>4__this;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x12DCFF4", Offset = "0x12DCFF4", VA = "0x12DCFF4")]
		public <>c__DisplayClass5_1()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x12DCFFC", Offset = "0x12DCFFC", VA = "0x12DCFFC")]
		internal void <Awake>b__7()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601180", Offset = "0x601180")]
	private sealed class <>c
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<PlayableListRow> <>9__5_1;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x12DCF88", Offset = "0x12DCF88", VA = "0x12DCF88")]
		public <>c()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x12DCF90", Offset = "0x12DCF90", VA = "0x12DCF90")]
		internal void <Awake>b__5_1(PlayableListRow row)
		{
		}
	}

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected ObjectPool<PlayableListRow> mRowPool;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected ObjectPool<PlayableListHead> mHeadPool;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected PlayableListRow mTemplateRow;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected PlayableListHead mTemplateHead;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<UnityEngine.Object> mItems;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private object lastPlayable;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PlayableListRow _currentRow;

	[Token(Token = "0x17000136")]
	public PlayableListRow currentRow
	{
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x12CE280", Offset = "0x12CE280", VA = "0x12CE280")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x12CE288", Offset = "0x12CE288", VA = "0x12CE288")]
		set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public abstract object currentPlayble
	{
		[Token(Token = "0x60005F4")]
		get;
	}

	[Token(Token = "0x17000138")]
	public abstract bool isPlaying
	{
		[Token(Token = "0x60005F5")]
		get;
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x12CD9B8", Offset = "0x12CD9B8", VA = "0x12CD9B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x12CDE60", Offset = "0x12CDE60", VA = "0x12CDE60", Slot = "4")]
	protected virtual void OnHeadClicked(PlayableListHead listHead)
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x12CE07C", Offset = "0x12CE07C", VA = "0x12CE07C", Slot = "5")]
	protected virtual void OnRowClicked(PlayableListRow listRow)
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x12CE080", Offset = "0x12CE080", VA = "0x12CE080")]
	public PlayableListHead AddHead()
	{
		return null;
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x12CE10C", Offset = "0x12CE10C", VA = "0x12CE10C")]
	public PlayableListRow AddRow([Optional] PlayableListHead head)
	{
		return null;
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x12CE3B8", Offset = "0x12CE3B8", VA = "0x12CE3B8")]
	public void Update()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x12CE4C0", Offset = "0x12CE4C0", VA = "0x12CE4C0")]
	public PlayableListRow FindRow(object data)
	{
		return null;
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x12CE91C", Offset = "0x12CE91C", VA = "0x12CE91C")]
	protected PlayableList()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x12CE99C", Offset = "0x12CE99C", VA = "0x12CE99C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606628", Offset = "0x606628")]
	private void <Awake>b__5_0(PlayableListRow row)
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x12CEAF8", Offset = "0x12CEAF8", VA = "0x12CEAF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606638", Offset = "0x606638")]
	private PlayableListRow <Awake>b__5_2()
	{
		return null;
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x12CEBE0", Offset = "0x12CEBE0", VA = "0x12CEBE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606648", Offset = "0x606648")]
	private void <Awake>b__5_3(PlayableListHead head)
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x12CED20", Offset = "0x12CED20", VA = "0x12CED20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606658", Offset = "0x606658")]
	private void <Awake>b__5_4(PlayableListHead head)
	{
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x12CEEA0", Offset = "0x12CEEA0", VA = "0x12CEEA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606668", Offset = "0x606668")]
	private PlayableListHead <Awake>b__5_5()
	{
		return null;
	}
}
[Token(Token = "0x2000119")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601190", Offset = "0x601190")]
public class PlayableListHead : MonoBehaviour
{
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _title;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _collapsed;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _expanded;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603A44", Offset = "0x603A44")]
	private object <data>k__BackingField;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603A54", Offset = "0x603A54")]
	private List<PlayableListRow> <rows>k__BackingField;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isOpened;

	[Token(Token = "0x17000139")]
	public object data
	{
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x12CEF88", Offset = "0x12CEF88", VA = "0x12CEF88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606678", Offset = "0x606678")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x12CEF90", Offset = "0x12CEF90", VA = "0x12CEF90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606688", Offset = "0x606688")]
		set
		{
		}
	}

	[Token(Token = "0x1700013A")]
	public List<PlayableListRow> rows
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x12CEF98", Offset = "0x12CEF98", VA = "0x12CEF98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606698", Offset = "0x606698")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x12CEFA0", Offset = "0x12CEFA0", VA = "0x12CEFA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066A8", Offset = "0x6066A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700013B")]
	public bool isOpened
	{
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x12CEFA8", Offset = "0x12CEFA8", VA = "0x12CEFA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x12CDE88", Offset = "0x12CDE88", VA = "0x12CDE88")]
		set
		{
		}
	}

	[Token(Token = "0x1700013C")]
	public string title
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x12CEFB0", Offset = "0x12CEFB0", VA = "0x12CEFB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x12CEFD8", Offset = "0x12CEFD8", VA = "0x12CEFD8")]
		set
		{
		}
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x12CF000", Offset = "0x12CF000", VA = "0x12CF000")]
	public PlayableListHead()
	{
	}
}
[Token(Token = "0x200011A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6011F8", Offset = "0x6011F8")]
public class PlayableListRow : MonoBehaviour
{
	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _title;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image _playIcon;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _locker;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603A94", Offset = "0x603A94")]
	private object <data>k__BackingField;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603AA4", Offset = "0x603AA4")]
	private PlayableListHead <head>k__BackingField;

	[Token(Token = "0x1700013D")]
	public object data
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x12CF008", Offset = "0x12CF008", VA = "0x12CF008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066B8", Offset = "0x6066B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x12CF010", Offset = "0x12CF010", VA = "0x12CF010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066C8", Offset = "0x6066C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700013E")]
	public PlayableListHead head
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x12CF018", Offset = "0x12CF018", VA = "0x12CF018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066D8", Offset = "0x6066D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x12CF020", Offset = "0x12CF020", VA = "0x12CF020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066E8", Offset = "0x6066E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700013F")]
	public bool isLocked
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x12CF028", Offset = "0x12CF028", VA = "0x12CF028")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x12CF054", Offset = "0x12CF054", VA = "0x12CF054")]
		set
		{
		}
	}

	[Token(Token = "0x17000140")]
	public string title
	{
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x12CF090", Offset = "0x12CF090", VA = "0x12CF090")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x12CF0B8", Offset = "0x12CF0B8", VA = "0x12CF0B8")]
		set
		{
		}
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x12CE350", Offset = "0x12CE350", VA = "0x12CE350")]
	public void SetPlaying(bool playing)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x12CF0E0", Offset = "0x12CF0E0", VA = "0x12CF0E0")]
	public PlayableListRow()
	{
	}
}
[Token(Token = "0x200011B")]
public class PlayButtonText : MonoBehaviour
{
	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playText;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pauseText;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text text;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MusicPlayer audioPlayer;

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x12CD8E4", Offset = "0x12CD8E4", VA = "0x12CD8E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x12CD9B0", Offset = "0x12CD9B0", VA = "0x12CD9B0")]
	public PlayButtonText()
	{
	}
}
[Token(Token = "0x200011C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601260", Offset = "0x601260")]
public class SealEditorCanvasMasker : MonoBehaviour
{
	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Paper _Paper;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _ZOffset;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _Aspect;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private DocumentLayoutElement _Left;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DocumentLayoutElement _Middle;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private DocumentLayoutElement _Right;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform _RectTransform;

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x12D36EC", Offset = "0x12D36EC", VA = "0x12D36EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x12D3748", Offset = "0x12D3748", VA = "0x12D3748")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x12D395C", Offset = "0x12D395C", VA = "0x12D395C")]
	private void Update()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x12D374C", Offset = "0x12D374C", VA = "0x12D374C")]
	private void UpdateLayout()
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x12D3B34", Offset = "0x12D3B34", VA = "0x12D3B34")]
	public SealEditorCanvasMasker()
	{
	}
}
[Token(Token = "0x200011D")]
public class SealsListController : MonoBehaviour
{
	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PaintingsList _List;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonDelete;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Seal mSeal;

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x12D3B48", Offset = "0x12D3B48", VA = "0x12D3B48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x12D3D3C", Offset = "0x12D3D3C", VA = "0x12D3D3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x12D3DC4", Offset = "0x12D3DC4", VA = "0x12D3DC4")]
	private int GetCurrentSealIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x12D3ECC", Offset = "0x12D3ECC", VA = "0x12D3ECC")]
	private void Apply()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x12D3FCC", Offset = "0x12D3FCC", VA = "0x12D3FCC")]
	public SealsListController()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x12D3FD4", Offset = "0x12D3FD4", VA = "0x12D3FD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6066F8", Offset = "0x6066F8")]
	private void <Start>b__3_0(int index)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x12D3FD8", Offset = "0x12D3FD8", VA = "0x12D3FD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606708", Offset = "0x606708")]
	private void <Start>b__3_1()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x12D4010", Offset = "0x12D4010", VA = "0x12D4010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606718", Offset = "0x606718")]
	private void <Start>b__3_2(int index)
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x12D4084", Offset = "0x12D4084", VA = "0x12D4084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606728", Offset = "0x606728")]
	private void <OnEnable>b__4_0()
	{
	}
}
[Token(Token = "0x200011E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6012C8", Offset = "0x6012C8")]
public class SetVideoRenderTexture : MonoBehaviour
{
	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage _Image;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _ClearColor;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x603B54", Offset = "0x603B54")]
	private int _Width;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x603B90", Offset = "0x603B90")]
	private int _Height;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VideoPlayer mVideoPlayer;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture mRenderTexture;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTextureDescriptor mDescriptor;

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x12D44FC", Offset = "0x12D44FC", VA = "0x12D44FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x12D459C", Offset = "0x12D459C", VA = "0x12D459C")]
	private void Update()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x12D46A4", Offset = "0x12D46A4", VA = "0x12D46A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x12D46AC", Offset = "0x12D46AC", VA = "0x12D46AC")]
	public SetVideoRenderTexture()
	{
	}
}
[Token(Token = "0x200011F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601330", Offset = "0x601330")]
[ExecuteAlways]
public class SliderImageFiller : MonoBehaviour
{
	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Slider _slider;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _startFill;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _endFill;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Image mImage;

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x7C6798", Offset = "0x7C6798", VA = "0x7C6798")]
	private void Awake()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x7C6804", Offset = "0x7C6804", VA = "0x7C6804")]
	private void Update()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x7C68DC", Offset = "0x7C68DC", VA = "0x7C68DC")]
	public SliderImageFiller()
	{
	}
}
[Token(Token = "0x2000120")]
public class UIAchievementList : MonoBehaviour
{
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIAchievementListItem _Template;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<UIAchievementListItem> mItems;

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x7CC7A4", Offset = "0x7CC7A4", VA = "0x7CC7A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x7CCDA0", Offset = "0x7CCDA0", VA = "0x7CCDA0")]
	public UIAchievementList()
	{
	}
}
[Token(Token = "0x2000121")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6013A8", Offset = "0x6013A8")]
public class UIAchievementListItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image _ImageIcon;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _Locker;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _UnlockHinter;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI _TextTitle;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI _TextDescription;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI _TextProgress;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Regex mRegex;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Achievement mAchievement;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Animator mAnimator;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string mHiddenString;

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x7CCE20", Offset = "0x7CCE20", VA = "0x7CCE20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x7CCC30", Offset = "0x7CCC30", VA = "0x7CCC30")]
	public void OnInit(UIAchievementList list, Achievement achievement)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x7CCE7C", Offset = "0x7CCE7C", VA = "0x7CCE7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x7CD0BC", Offset = "0x7CD0BC", VA = "0x7CD0BC", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x7CD144", Offset = "0x7CD144", VA = "0x7CD144")]
	public UIAchievementListItem()
	{
	}
}
[Token(Token = "0x2000122")]
public class UIAnimationMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000123")]
	public class SelectionChangedEvent : UnityEvent<int>
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x12DE184", Offset = "0x12DE184", VA = "0x12DE184")]
		public SelectionChangedEvent()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> menus;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inactiveMenusOnInit;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string inAnimation;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string outAnimation;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject firstSelection;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SelectionChangedEvent selectionChanged;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject mSelectedMenu;

	[Token(Token = "0x17000141")]
	public GameObject selectedMenu
	{
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7CD1E0", Offset = "0x7CD1E0", VA = "0x7CD1E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x7CD1E8", Offset = "0x7CD1E8", VA = "0x7CD1E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000142")]
	public int selectedIndex
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7CD5DC", Offset = "0x7CD5DC", VA = "0x7CD5DC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x7CD8E0", Offset = "0x7CD8E0", VA = "0x7CD8E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x7CD464", Offset = "0x7CD464", VA = "0x7CD464")]
	private void MenuIn(GameObject target)
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x7CD2EC", Offset = "0x7CD2EC", VA = "0x7CD2EC")]
	private void MenuOut(GameObject target)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x7CD634", Offset = "0x7CD634", VA = "0x7CD634")]
	public void Awake()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x7CD748", Offset = "0x7CD748", VA = "0x7CD748")]
	public void Start()
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x7CD7D8", Offset = "0x7CD7D8", VA = "0x7CD7D8")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x7CD870", Offset = "0x7CD870", VA = "0x7CD870")]
	public void SelectNext()
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x7CD8E4", Offset = "0x7CD8E4", VA = "0x7CD8E4")]
	public void SelectPre()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x7CD91C", Offset = "0x7CD91C", VA = "0x7CD91C")]
	public UIAnimationMenu()
	{
	}
}
[Token(Token = "0x2000124")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x601410", Offset = "0x601410")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601410", Offset = "0x601410")]
public class UIAudioSource : SingletonGameObject<UIAudioSource>
{
	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource mAudioSouce;

	[Token(Token = "0x17000143")]
	public static AudioSource audioSource
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x7C6F9C", Offset = "0x7C6F9C", VA = "0x7C6F9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000144")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x7CDA74", Offset = "0x7CDA74", VA = "0x7CDA74", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x7CD9A4", Offset = "0x7CD9A4", VA = "0x7CD9A4", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x7CDA7C", Offset = "0x7CDA7C", VA = "0x7CDA7C")]
	public UIAudioSource()
	{
	}
}
[Token(Token = "0x2000125")]
public class UICopybookDirectoryList : MonoBehaviour
{
	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Stack<UICopybookDirectoryListTemplate> mItemsPool;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UICopybookDirectoryListTemplate mUICopybookDirectoryListTemplate;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string mCurrentPath;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string CopybookPath;

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x7CDAD0", Offset = "0x7CDAD0", VA = "0x7CDAD0")]
	private UICopybookDirectoryListTemplate getNewUICopybookDirectoryListTemplate()
	{
		return null;
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x7CDBEC", Offset = "0x7CDBEC", VA = "0x7CDBEC")]
	private void Recycle(UICopybookDirectoryListTemplate template)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x7CDC80", Offset = "0x7CDC80", VA = "0x7CDC80")]
	public void OnItemClicked(UICopybookDirectoryListTemplate template)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x7CDDB0", Offset = "0x7CDDB0", VA = "0x7CDDB0")]
	public void OpenPath(string path)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x7CE050", Offset = "0x7CE050", VA = "0x7CE050")]
	public void Back()
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x7CE0F8", Offset = "0x7CE0F8", VA = "0x7CE0F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x7CE2D8", Offset = "0x7CE2D8", VA = "0x7CE2D8")]
	public UICopybookDirectoryList()
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x7CE37C", Offset = "0x7CE37C", VA = "0x7CE37C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606738", Offset = "0x606738")]
	private void <OpenPath>b__7_0(UICopybookDirectoryListTemplate t)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x7CE380", Offset = "0x7CE380", VA = "0x7CE380")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606748", Offset = "0x606748")]
	private void <Start>b__9_0(UICopybookDirectoryListTemplate t)
	{
	}
}
[Token(Token = "0x2000126")]
public class UICopybookDirectoryListTemplate : MonoBehaviour
{
	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text uiText;

	[Token(Token = "0x17000145")]
	public string text
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x7CDD88", Offset = "0x7CDD88", VA = "0x7CDD88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x7CE028", Offset = "0x7CE028", VA = "0x7CE028")]
		set
		{
		}
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x7CE384", Offset = "0x7CE384", VA = "0x7CE384")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x7CE3E4", Offset = "0x7CE3E4", VA = "0x7CE3E4")]
	public UICopybookDirectoryListTemplate()
	{
	}
}
[Token(Token = "0x2000127")]
public class UIHoverTransform : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _target;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 _targetLocalPosition;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 _targetLocalRotation;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector3 _targetLocalScale;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _smooth;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 mInitLocalPosition;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion mInitLocalRotation;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 mInitLocalScale;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mPointerCount;

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x7CE3EC", Offset = "0x7CE3EC", VA = "0x7CE3EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x7CE454", Offset = "0x7CE454", VA = "0x7CE454", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x7CE464", Offset = "0x7CE464", VA = "0x7CE464", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x7CE474", Offset = "0x7CE474", VA = "0x7CE474")]
	private void Update()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x7CE6A4", Offset = "0x7CE6A4", VA = "0x7CE6A4")]
	public UIHoverTransform()
	{
	}
}
[Token(Token = "0x2000128")]
public class UILevelList : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000129")]
	public class OnSelectedEvent : UnityEvent<int>
	{
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x12DE380", Offset = "0x12DE380", VA = "0x12DE380")]
		public OnSelectedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200012A")]
	private struct ListPosition
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject start;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GameObject middle;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject end;
	}

	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6014A4", Offset = "0x6014A4")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UILevelList <>4__this;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x12DE1D8", Offset = "0x12DE1D8", VA = "0x12DE1D8")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x12DE1E0", Offset = "0x12DE1E0", VA = "0x12DE1E0")]
		internal void <Awake>b__0()
		{
		}
	}

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip _AudioPaging;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _AudioClick;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> _contents;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ListPosition _targetPositon;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ListPosition _startPositon;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve _PositionCurve;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _smooth;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OnSelectedEvent _selected;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OnSelectedEvent _onSelectedClicked;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int mSelectedIndex;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject mTmp;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int mDefaultSelectedIndex;

	[Token(Token = "0x17000146")]
	public OnSelectedEvent onSelectedClicked
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x7CE6B4", Offset = "0x7CE6B4", VA = "0x7CE6B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000147")]
	public OnSelectedEvent onSelected
	{
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x7CE6BC", Offset = "0x7CE6BC", VA = "0x7CE6BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000148")]
	public int selectedIndex
	{
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x7CE6C4", Offset = "0x7CE6C4", VA = "0x7CE6C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x7CE6CC", Offset = "0x7CE6CC", VA = "0x7CE6CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000149")]
	public IReadOnlyList<GameObject> contents
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7CE864", Offset = "0x7CE864", VA = "0x7CE864")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x7CE86C", Offset = "0x7CE86C", VA = "0x7CE86C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x7CECFC", Offset = "0x7CECFC", VA = "0x7CECFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x7CEDC4", Offset = "0x7CEDC4", VA = "0x7CEDC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x7CEE64", Offset = "0x7CEE64", VA = "0x7CEE64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x7CED90", Offset = "0x7CED90", VA = "0x7CED90")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x7CF02C", Offset = "0x7CF02C", VA = "0x7CF02C")]
	public void Select(GameObject go)
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x7CE6D0", Offset = "0x7CE6D0", VA = "0x7CE6D0")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x7CF09C", Offset = "0x7CF09C", VA = "0x7CF09C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x7CF0D0", Offset = "0x7CF0D0", VA = "0x7CF0D0")]
	private void SetContentPositionSmooth(ListPosition listPosition, int selectedIndex)
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x7CEE98", Offset = "0x7CEE98", VA = "0x7CEE98")]
	private void SetContentPosition(ListPosition listPosition, int selectedIndex)
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x7CF2B8", Offset = "0x7CF2B8", VA = "0x7CF2B8")]
	private void Lerp(GameObject from, GameObject to, GameObject target, float k)
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x7CF268", Offset = "0x7CF268", VA = "0x7CF268")]
	private void LerpSmooth(GameObject from, GameObject to, GameObject target, float k)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x7CF510", Offset = "0x7CF510", VA = "0x7CF510")]
	public UILevelList()
	{
	}
}
[Token(Token = "0x200012C")]
public class UIPanelSavePainting : MonoBehaviour
{
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6014B4", Offset = "0x6014B4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PhotoFrameListItem selectedItem;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SavedPaintings.Painting painting;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FileUtils.MediaType saveMediaType;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIPanelSavePainting <>4__this;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x12DE3EC", Offset = "0x12DE3EC", VA = "0x12DE3EC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x12DE3F4", Offset = "0x12DE3F4", VA = "0x12DE3F4")]
		internal bool <Start>b__1(string btn)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonSave;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PhotoFrameList _ListPhotoFrame;

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x7D0158", Offset = "0x7D0158", VA = "0x7D0158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x7D0248", Offset = "0x7D0248", VA = "0x7D0248")]
	public UIPanelSavePainting()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x7D0250", Offset = "0x7D0250", VA = "0x7D0250")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606758", Offset = "0x606758")]
	private void <Start>b__2_0()
	{
	}
}
[Token(Token = "0x200012E")]
public class UIRecording : MonoBehaviour
{
	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x603D6C", Offset = "0x603D6C")]
	private Button _ButtonPlay;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x603DB8", Offset = "0x603DB8")]
	[SerializeField]
	private Button _ButtonRecording;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x603E04", Offset = "0x603E04")]
	[SerializeField]
	private Button _ButtonStop;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationInvoker _ButtonAnimationIdle;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationInvoker _ButtonAnimationRecording;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private BrushRecorder _BrushRecorder;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextSetter mTextSetterRecording;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool mIsRecoding;

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x7D07FC", Offset = "0x7D07FC", VA = "0x7D07FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x7D0B18", Offset = "0x7D0B18", VA = "0x7D0B18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x7D0DC0", Offset = "0x7D0DC0", VA = "0x7D0DC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x7D0E94", Offset = "0x7D0E94", VA = "0x7D0E94")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x7D0EF8", Offset = "0x7D0EF8", VA = "0x7D0EF8")]
	public UIRecording()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x7D0F00", Offset = "0x7D0F00", VA = "0x7D0F00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606768", Offset = "0x606768")]
	private void <Start>b__8_0()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x7D0F98", Offset = "0x7D0F98", VA = "0x7D0F98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606778", Offset = "0x606778")]
	private void <Start>b__8_1()
	{
	}
}
[Token(Token = "0x200012F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6014C4", Offset = "0x6014C4")]
public class UISoundPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000130")]
	public struct Sound
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip clip;
	}

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sound[] sounds;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource mAudio;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UISoundPlayer mInstance;

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x7D1030", Offset = "0x7D1030", VA = "0x7D1030")]
	private void Awake()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x7D1160", Offset = "0x7D1160", VA = "0x7D1160")]
	public static void PlaySound(string key)
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x7D1328", Offset = "0x7D1328", VA = "0x7D1328")]
	public UISoundPlayer()
	{
	}
}
[Token(Token = "0x2000131")]
public class UIStudyRoom_MenuBar_Main : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60152C", Offset = "0x60152C")]
	private sealed class <>c
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__3_0;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12DE6C0", Offset = "0x12DE6C0", VA = "0x12DE6C0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x12DE6C8", Offset = "0x12DE6C8", VA = "0x12DE6C8")]
		internal void <Start>b__3_0()
		{
		}
	}

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonQuit;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonUserTemplates;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonAchievement;

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x7D1330", Offset = "0x7D1330", VA = "0x7D1330")]
	private void Start()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x7D1494", Offset = "0x7D1494", VA = "0x7D1494")]
	private void Update()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x7D1624", Offset = "0x7D1624", VA = "0x7D1624")]
	public UIStudyRoom_MenuBar_Main()
	{
	}
}
[Token(Token = "0x2000133")]
public class UIStudyRoom_MenuBar_Tools : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60153C", Offset = "0x60153C")]
	private sealed class <>c
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__10_0;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static UnityAction <>9__10_1;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static UnityAction <>9__10_2;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static UnityAction <>9__10_3;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static UnityAction <>9__10_4;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x12DE77C", Offset = "0x12DE77C", VA = "0x12DE77C")]
		public <>c()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x12DE784", Offset = "0x12DE784", VA = "0x12DE784")]
		internal void <Start>b__10_0()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x12DE868", Offset = "0x12DE868", VA = "0x12DE868")]
		internal void <Start>b__10_1()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x12DEA50", Offset = "0x12DEA50", VA = "0x12DEA50")]
		internal void <Start>b__10_2()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x12DEADC", Offset = "0x12DEADC", VA = "0x12DEADC")]
		internal void <Start>b__10_3()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x12DEB78", Offset = "0x12DEB78", VA = "0x12DEB78")]
		internal void <Start>b__10_4()
		{
		}
	}

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button buttonShowMask;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button buttonGrading;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button buttonClear;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button buttonUndo;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button buttonRedo;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button buttonSetMovieTempalte;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MenuPanel panelMovies;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button _ButtonPlay;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button _ButtonStop;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button _ButtonRecording;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private BrushRecorder mBrushRecorder;

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x7D162C", Offset = "0x7D162C", VA = "0x7D162C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x7D1D88", Offset = "0x7D1D88", VA = "0x7D1D88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x7D2400", Offset = "0x7D2400", VA = "0x7D2400")]
	public UIStudyRoom_MenuBar_Tools()
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x7D2408", Offset = "0x7D2408", VA = "0x7D2408")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606788", Offset = "0x606788")]
	private void <Start>b__10_5()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x7D257C", Offset = "0x7D257C", VA = "0x7D257C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606798", Offset = "0x606798")]
	private void <Start>b__10_6()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x7D2614", Offset = "0x7D2614", VA = "0x7D2614")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6067A8", Offset = "0x6067A8")]
	private void <Start>b__10_7()
	{
	}
}
[Token(Token = "0x2000135")]
public class VideoPlayerController : MediaPlayerController
{
	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool mNeedReplayOnEnable;

	[Token(Token = "0x1700014A")]
	protected override MediaPlayer mediaPlayer
	{
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x7D4CDC", Offset = "0x7D4CDC", VA = "0x7D4CDC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x7D4D50", Offset = "0x7D4D50", VA = "0x7D4D50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x7D4E34", Offset = "0x7D4E34", VA = "0x7D4E34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x7D4F8C", Offset = "0x7D4F8C", VA = "0x7D4F8C")]
	public VideoPlayerController()
	{
	}
}
[Token(Token = "0x2000136")]
public static class BinaryWriterExtension
{
	[Token(Token = "0x6000695")]
	[Address(RVA = "0x7B83A4", Offset = "0x7B83A4", VA = "0x7B83A4")]
	public static void Write(this BinaryWriter bw, Vector3 v)
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x7B8414", Offset = "0x7B8414", VA = "0x7B8414")]
	public static void Write(this BinaryWriter bw, Quaternion q)
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x7B84A8", Offset = "0x7B84A8", VA = "0x7B84A8")]
	public static void Write(this BinaryWriter bw, Color c)
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x7B853C", Offset = "0x7B853C", VA = "0x7B853C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6067E8", Offset = "0x6067E8")]
	public static void Write(this BinaryWriter bw, AnimationCurve ac)
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x7B8750", Offset = "0x7B8750", VA = "0x7B8750")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x606820", Offset = "0x606820")]
	public static AnimationCurve ReadAnimationCurve(this BinaryReader br)
	{
		return null;
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x7B891C", Offset = "0x7B891C", VA = "0x7B891C")]
	public static Vector3 ReadVector3(this BinaryReader br)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x7B8994", Offset = "0x7B8994", VA = "0x7B8994")]
	public static Quaternion ReadQuaternion(this BinaryReader br)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x7B8A50", Offset = "0x7B8A50", VA = "0x7B8A50")]
	public static Color ReadColor(this BinaryReader br)
	{
		return default(Color);
	}
}
[Token(Token = "0x2000137")]
public static class ReflactUtils
{
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x12D0AC0", Offset = "0x12D0AC0", VA = "0x12D0AC0")]
	public static void SetField(object obj, string name, object value)
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x12C3D20", Offset = "0x12C3D20", VA = "0x12C3D20")]
	public static void Invoke(object obj, string name, params object[] args)
	{
	}
}
[Token(Token = "0x2000138")]
[AttributeAttribute(Name = "SingletonOption", RVA = "0x60155C", Offset = "0x60155C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60155C", Offset = "0x60155C")]
public class ViewNavigation : SingletonGameObject<ViewNavigation>
{
	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform hintObject;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform hintArrow;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve raduis;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float raduisScale;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float depth;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float redio;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float clampXAngle;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float clampYAngle;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Canvas mCanvas;

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x7D4F94", Offset = "0x7D4F94", VA = "0x7D4F94")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x7D4FF0", Offset = "0x7D4FF0", VA = "0x7D4FF0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x7D5478", Offset = "0x7D5478", VA = "0x7D5478")]
	public ViewNavigation()
	{
	}
}
[Token(Token = "0x2000139")]
public class VRPlatformGameObjectActiver : MonoBehaviour
{
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRPlatform.PlatformTarget[] _targetPlatforms;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] _Targets;

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x7D4494", Offset = "0x7D4494", VA = "0x7D4494")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x7D45D0", Offset = "0x7D45D0", VA = "0x7D45D0")]
	public VRPlatformGameObjectActiver()
	{
	}
}
[Token(Token = "0x200013A")]
public class WordTemplate : MonoBehaviour
{
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x7D6A18", Offset = "0x7D6A18", VA = "0x7D6A18")]
	public void OnPagerClicked(GalleryPanel o, int index)
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x7D6C50", Offset = "0x7D6C50", VA = "0x7D6C50")]
	public WordTemplate()
	{
	}
}
[Token(Token = "0x200013B")]
public class ChallengeTest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013C")]
	private class ScoreTest : ITestClass
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float score;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x7DB124", Offset = "0x7DB124", VA = "0x7DB124")]
		public ScoreTest()
		{
		}
	}

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TestFunc", RVA = "0x603F00", Offset = "0x603F00")]
	[SerializeField]
	private ScoreTest _ScoreTest;

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x7C1FC4", Offset = "0x7C1FC4", VA = "0x7C1FC4")]
	private void SubmitScore()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x7C2068", Offset = "0x7C2068", VA = "0x7C2068")]
	public ChallengeTest()
	{
	}
}
[Token(Token = "0x200013D")]
public class Test : MonoBehaviour
{
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x7CBC88", Offset = "0x7CBC88", VA = "0x7CBC88")]
	public Test()
	{
	}
}
[Token(Token = "0x200013E")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200013F")]
	public delegate void OnClick();

	[Token(Token = "0x2000140")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000141")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000142")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6015E8", Offset = "0x6015E8")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x12D6668", Offset = "0x12D6668", VA = "0x12D6668")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x12D6670", Offset = "0x12D6670", VA = "0x12D6670")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6015F8", Offset = "0x6015F8")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x12D6730", Offset = "0x12D6730", VA = "0x12D6730")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x12D6738", Offset = "0x12D6738", VA = "0x12D6738")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601608", Offset = "0x601608")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x12D6814", Offset = "0x12D6814", VA = "0x12D6814")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x12D681C", Offset = "0x12D681C", VA = "0x12D681C")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601618", Offset = "0x601618")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x12D6A38", Offset = "0x12D6A38", VA = "0x12D6A38")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x12D6A40", Offset = "0x12D6A40", VA = "0x12D6A40")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601628", Offset = "0x601628")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x12D6A64", Offset = "0x12D6A64", VA = "0x12D6A64")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x12D6A6C", Offset = "0x12D6A6C", VA = "0x12D6A6C")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40004C1")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40004C2")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40004C3")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool[] reEnable;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x40004D0")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x40004D1")]
	private const float marginH = 16f;

	[Token(Token = "0x40004D2")]
	private const float marginV = 16f;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector2[] insertPositions;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 menuOffset;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private OVRCameraRig rig;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private LaserPointer lp;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private LineRenderer lr;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x80C3AC", Offset = "0x80C3AC", VA = "0x80C3AC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x80C868", Offset = "0x80C868", VA = "0x80C868")]
	public void Show()
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x80CE20", Offset = "0x80CE20", VA = "0x80CE20")]
	public void Hide()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x80CC10", Offset = "0x80CC10", VA = "0x80CC10")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x80CFDC", Offset = "0x80CFDC", VA = "0x80CFDC")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x80D2B0", Offset = "0x80D2B0", VA = "0x80D2B0")]
	public RectTransform AddButton(string label, OnClick handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x80D540", Offset = "0x80D540", VA = "0x80D540")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x80D64C", Offset = "0x80D64C", VA = "0x80D64C")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x80D82C", Offset = "0x80D82C", VA = "0x80D82C")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x80D8D0", Offset = "0x80D8D0", VA = "0x80D8D0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x80DAA0", Offset = "0x80DAA0", VA = "0x80DAA0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x80DC90", Offset = "0x80DC90", VA = "0x80DC90")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x80DF80", Offset = "0x80DF80", VA = "0x80DF80")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x80E020", Offset = "0x80E020", VA = "0x80E020")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000148")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x8216D8", Offset = "0x8216D8", VA = "0x8216D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x82177C", Offset = "0x82177C", VA = "0x82177C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x821834", Offset = "0x821834", VA = "0x821834")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x821870", Offset = "0x821870", VA = "0x821870")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000149")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x200014A")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x40004EF")]
		On,
		[Token(Token = "0x40004F0")]
		Off,
		[Token(Token = "0x40004F1")]
		OnWhenHitTarget
	}

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700014B")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x8B4BBC", Offset = "0x8B4BBC", VA = "0x8B4BBC")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x8B4B78", Offset = "0x8B4B78", VA = "0x8B4B78")]
		set
		{
		}
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x8B4BC4", Offset = "0x8B4BC4", VA = "0x8B4BC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x8B4C20", Offset = "0x8B4C20", VA = "0x8B4C20")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x8B4D6C", Offset = "0x8B4D6C", VA = "0x8B4D6C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x8B4D88", Offset = "0x8B4D88", VA = "0x8B4D88", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x8B4DDC", Offset = "0x8B4DDC", VA = "0x8B4DDC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x8B4F90", Offset = "0x8B4F90", VA = "0x8B4F90")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x8B50A4", Offset = "0x8B50A4", VA = "0x8B50A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x8B5140", Offset = "0x8B5140", VA = "0x8B5140")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x8B5218", Offset = "0x8B5218", VA = "0x8B5218")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x8B52CC", Offset = "0x8B52CC", VA = "0x8B52CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x8B53C0", Offset = "0x8B53C0", VA = "0x8B53C0")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200014B")]
public class BoundsLockedObject : MonoBehaviour
{
	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_initialOffset;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig m_playerOrigin;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GuardianBoundaryEnforcer m_enforcer;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Bounds? m_bounds;

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x7BBEB0", Offset = "0x7BBEB0", VA = "0x7BBEB0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x7BC0A8", Offset = "0x7BC0A8", VA = "0x7BC0A8")]
	private void RefreshDisplay()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x7BC488", Offset = "0x7BC488", VA = "0x7BC488")]
	public BoundsLockedObject()
	{
	}
}
[Token(Token = "0x200014C")]
public class GuardianBoundaryDisplay : MonoBehaviour
{
	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GuardianBoundaryEnforcer m_enforcer;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRBoundary.BoundaryType m_boundaryType;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_errorDisplay;

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x81F964", Offset = "0x81F964", VA = "0x81F964")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x81FA9C", Offset = "0x81FA9C", VA = "0x81FA9C")]
	private void RefreshDisplay()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x81FCF8", Offset = "0x81FCF8", VA = "0x81FCF8")]
	public GuardianBoundaryDisplay()
	{
	}
}
[Token(Token = "0x200014D")]
public class GuardianBoundaryEnforcer : MonoBehaviour
{
	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool m_AllowRecenter;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig m_mainCamera;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion m_originalTrackerOrientation;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_framecount;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion m_orientToOriginalForward;

	[Token(Token = "0x1700014C")]
	public Quaternion OrientToOriginalForward
	{
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x81FDA0", Offset = "0x81FDA0", VA = "0x81FDA0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x14000004")]
	public event Action TrackingChanged
	{
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x81F9FC", Offset = "0x81F9FC", VA = "0x81F9FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606888", Offset = "0x606888")]
		add
		{
		}
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x81FD00", Offset = "0x81FD00", VA = "0x81FD00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606898", Offset = "0x606898")]
		remove
		{
		}
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x81FDAC", Offset = "0x81FDAC", VA = "0x81FDAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x81FF20", Offset = "0x81FF20", VA = "0x81FF20")]
	private void Update()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x820070", Offset = "0x820070", VA = "0x820070")]
	private void Recentered()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x820078", Offset = "0x820078", VA = "0x820078")]
	public GuardianBoundaryEnforcer()
	{
	}
}
[Token(Token = "0x200014E")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60401C", Offset = "0x60401C")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604054", Offset = "0x604054")]
	public bool EnableCollision;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60408C", Offset = "0x60408C")]
	public float MaxFade;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6040C4", Offset = "0x6040C4")]
	public float FadeMinDistance;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float PreferredHeight;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6040FC", Offset = "0x6040FC")]
	public float FadeMaxDistance;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _cameraUpdateAction;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action _preCharacterMovementAction;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x7C2708", Offset = "0x7C2708", VA = "0x7C2708")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x7C27A0", Offset = "0x7C27A0", VA = "0x7C27A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x7C2820", Offset = "0x7C2820", VA = "0x7C2820")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x7C2824", Offset = "0x7C2824", VA = "0x7C2824")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x7C284C", Offset = "0x7C284C", VA = "0x7C284C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x7C2874", Offset = "0x7C2874", VA = "0x7C2874")]
	private void CameraUpdate()
	{
	}
}
[Token(Token = "0x200014F")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x8B5A30", Offset = "0x8B5A30", VA = "0x8B5A30")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x8B5AE4", Offset = "0x8B5AE4", VA = "0x8B5AE4")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x2000150")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000151")]
	public enum States
	{
		[Token(Token = "0x4000530")]
		Ready,
		[Token(Token = "0x4000531")]
		Aim,
		[Token(Token = "0x4000532")]
		CancelAim,
		[Token(Token = "0x4000533")]
		PreTeleport,
		[Token(Token = "0x4000534")]
		CancelTeleport,
		[Token(Token = "0x4000535")]
		Teleporting,
		[Token(Token = "0x4000536")]
		PostTeleport
	}

	[Token(Token = "0x2000152")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000538")]
		None,
		[Token(Token = "0x4000539")]
		Aim,
		[Token(Token = "0x400053A")]
		PreTeleport,
		[Token(Token = "0x400053B")]
		Teleport
	}

	[Token(Token = "0x2000153")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400053D")]
		Point,
		[Token(Token = "0x400053E")]
		Sphere,
		[Token(Token = "0x400053F")]
		Capsule
	}

	[Token(Token = "0x2000154")]
	public class AimData
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604514", Offset = "0x604514")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x17000150")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x12D9B64", Offset = "0x12D9B64", VA = "0x12D9B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606D58", Offset = "0x606D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x12D9B6C", Offset = "0x12D9B6C", VA = "0x12D9B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606D68", Offset = "0x606D68")]
			private set
			{
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x12D9AE0", Offset = "0x12D9AE0", VA = "0x12D9AE0")]
		public AimData()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x12D9B74", Offset = "0x12D9B74", VA = "0x12D9B74")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601638", Offset = "0x601638")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000151")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x12D9938", Offset = "0x12D9938", VA = "0x12D9938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x12D9980", Offset = "0x12D9980", VA = "0x12D9980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x12D9818", Offset = "0x12D9818", VA = "0x12D9818")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x12D9844", Offset = "0x12D9844", VA = "0x12D9844", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x12D9848", Offset = "0x12D9848", VA = "0x12D9848", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x12D9940", Offset = "0x12D9940", VA = "0x12D9940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601648", Offset = "0x601648")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000153")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x12D92C0", Offset = "0x12D92C0", VA = "0x12D92C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x12D9308", Offset = "0x12D9308", VA = "0x12D9308", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x12D9150", Offset = "0x12D9150", VA = "0x12D9150")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x12D917C", Offset = "0x12D917C", VA = "0x12D917C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x12D9180", Offset = "0x12D9180", VA = "0x12D9180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x12D92C8", Offset = "0x12D92C8", VA = "0x12D92C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601658", Offset = "0x601658")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000155")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x12D93E0", Offset = "0x12D93E0", VA = "0x12D93E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x12D9428", Offset = "0x12D9428", VA = "0x12D9428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x12D9310", Offset = "0x12D9310", VA = "0x12D9310")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x12D933C", Offset = "0x12D933C", VA = "0x12D933C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x12D9340", Offset = "0x12D9340", VA = "0x12D9340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x12D93E8", Offset = "0x12D93E8", VA = "0x12D93E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601668", Offset = "0x601668")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000157")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x12D97C8", Offset = "0x12D97C8", VA = "0x12D97C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x12D9810", Offset = "0x12D9810", VA = "0x12D9810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x12D96B8", Offset = "0x12D96B8", VA = "0x12D96B8")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x12D96E4", Offset = "0x12D96E4", VA = "0x12D96E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x12D96E8", Offset = "0x12D96E8", VA = "0x12D96E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x12D97D0", Offset = "0x12D97D0", VA = "0x12D97D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601678", Offset = "0x601678")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000159")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x12D9500", Offset = "0x12D9500", VA = "0x12D9500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x12D9548", Offset = "0x12D9548", VA = "0x12D9548", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x12D9430", Offset = "0x12D9430", VA = "0x12D9430")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x12D945C", Offset = "0x12D945C", VA = "0x12D945C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x12D9460", Offset = "0x12D9460", VA = "0x12D9460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x12D9508", Offset = "0x12D9508", VA = "0x12D9508", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601688", Offset = "0x601688")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700015B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x12D9A90", Offset = "0x12D9A90", VA = "0x12D9A90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x12D9AD8", Offset = "0x12D9AD8", VA = "0x12D9AD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x12D9988", Offset = "0x12D9988", VA = "0x12D9988")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x12D99B4", Offset = "0x12D99B4", VA = "0x12D99B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x12D99B8", Offset = "0x12D99B8", VA = "0x12D99B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x12D9A98", Offset = "0x12D9A98", VA = "0x12D9A98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601698", Offset = "0x601698")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700015D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x12D9668", Offset = "0x12D9668", VA = "0x12D9668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x12D96B0", Offset = "0x12D96B0", VA = "0x12D96B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x12D9550", Offset = "0x12D9550", VA = "0x12D9550")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x12D957C", Offset = "0x12D957C", VA = "0x12D957C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x12D9580", Offset = "0x12D9580", VA = "0x12D9580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x12D9670", Offset = "0x12D9670", VA = "0x12D9670", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604134", Offset = "0x604134")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60416C", Offset = "0x60416C")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6041A4", Offset = "0x6041A4")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6041DC", Offset = "0x6041DC")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604214", Offset = "0x604214")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60424C", Offset = "0x60424C")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604284", Offset = "0x604284")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6042BC", Offset = "0x6042BC")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6042F4", Offset = "0x6042F4")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604304", Offset = "0x604304")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60433C", Offset = "0x60433C")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604384", Offset = "0x604384")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604394", Offset = "0x604394")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6043CC", Offset = "0x6043CC")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604404", Offset = "0x604404")]
	public float AimCollisionRadius;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60443C", Offset = "0x60443C")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700014D")]
	public States CurrentState
	{
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8B5B34", Offset = "0x8B5B34", VA = "0x8B5B34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068A8", Offset = "0x6068A8")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8B5B3C", Offset = "0x8B5B3C", VA = "0x8B5B3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068B8", Offset = "0x6068B8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014E")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x8B5D50", Offset = "0x8B5D50", VA = "0x8B5D50")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700014F")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x8B5D78", Offset = "0x8B5D78", VA = "0x8B5D78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068E8", Offset = "0x6068E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x8B5D80", Offset = "0x8B5D80", VA = "0x8B5D80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068F8", Offset = "0x6068F8")]
		private set
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8B5B44", Offset = "0x8B5B44", VA = "0x8B5B44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068C8", Offset = "0x6068C8")]
		add
		{
		}
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8B5BE4", Offset = "0x8B5BE4", VA = "0x8B5BE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6068D8", Offset = "0x6068D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x8B639C", Offset = "0x8B639C", VA = "0x8B639C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606940", Offset = "0x606940")]
		add
		{
		}
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8B643C", Offset = "0x8B643C", VA = "0x8B643C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606950", Offset = "0x606950")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8B64DC", Offset = "0x8B64DC", VA = "0x8B64DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6069C8", Offset = "0x6069C8")]
		add
		{
		}
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x8B657C", Offset = "0x8B657C", VA = "0x8B657C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6069D8", Offset = "0x6069D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x8B661C", Offset = "0x8B661C", VA = "0x8B661C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6069E8", Offset = "0x6069E8")]
		add
		{
		}
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8B66BC", Offset = "0x8B66BC", VA = "0x8B66BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6069F8", Offset = "0x6069F8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8B67CC", Offset = "0x8B67CC", VA = "0x8B67CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606A08", Offset = "0x606A08")]
		add
		{
		}
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8B686C", Offset = "0x8B686C", VA = "0x8B686C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606A18", Offset = "0x606A18")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x8B6980", Offset = "0x8B6980", VA = "0x8B6980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606A90", Offset = "0x606A90")]
		add
		{
		}
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x8B6A20", Offset = "0x8B6A20", VA = "0x8B6A20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606AA0", Offset = "0x606AA0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x8B6B34", Offset = "0x8B6B34", VA = "0x8B6B34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606B18", Offset = "0x606B18")]
		add
		{
		}
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x8B6BD4", Offset = "0x8B6BD4", VA = "0x8B6BD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606B28", Offset = "0x606B28")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x8B6CE8", Offset = "0x8B6CE8", VA = "0x8B6CE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606BA0", Offset = "0x606BA0")]
		add
		{
		}
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x8B6D88", Offset = "0x8B6D88", VA = "0x8B6D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606BB0", Offset = "0x606BB0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x8B6E9C", Offset = "0x8B6E9C", VA = "0x8B6E9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606C28", Offset = "0x606C28")]
		add
		{
		}
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x8B6F3C", Offset = "0x8B6F3C", VA = "0x8B6F3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606C38", Offset = "0x606C38")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x8B7050", Offset = "0x8B7050", VA = "0x8B7050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606CB0", Offset = "0x606CB0")]
		add
		{
		}
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x8B70F0", Offset = "0x8B70F0", VA = "0x8B70F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606CC0", Offset = "0x606CC0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x8B7204", Offset = "0x8B7204", VA = "0x8B7204")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606D38", Offset = "0x606D38")]
		add
		{
		}
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8B72A4", Offset = "0x8B72A4", VA = "0x8B72A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606D48", Offset = "0x606D48")]
		remove
		{
		}
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x8B5AEC", Offset = "0x8B5AEC", VA = "0x8B5AEC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x8B5B10", Offset = "0x8B5B10", VA = "0x8B5B10")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x8B5C84", Offset = "0x8B5C84", VA = "0x8B5C84")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x8B5D88", Offset = "0x8B5D88", VA = "0x8B5D88")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, [Out] RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x8B5FD4", Offset = "0x8B5FD4", VA = "0x8B5FD4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x606908", Offset = "0x606908")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x8B6090", Offset = "0x8B6090", VA = "0x8B6090")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x8B6168", Offset = "0x8B6168", VA = "0x8B6168")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x8B6188", Offset = "0x8B6188", VA = "0x8B6188")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x8B624C", Offset = "0x8B624C", VA = "0x8B624C")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x8B6290", Offset = "0x8B6290", VA = "0x8B6290")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x8B62F0", Offset = "0x8B62F0", VA = "0x8B62F0", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x8B6394", Offset = "0x8B6394", VA = "0x8B6394", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x8B6320", Offset = "0x8B6320", VA = "0x8B6320")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606960", Offset = "0x606960")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x8B675C", Offset = "0x8B675C", VA = "0x8B675C")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x8B690C", Offset = "0x8B690C", VA = "0x8B690C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606A28", Offset = "0x606A28")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x8B6AC0", Offset = "0x8B6AC0", VA = "0x8B6AC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606AB0", Offset = "0x606AB0")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x8B6C74", Offset = "0x8B6C74", VA = "0x8B6C74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606B38", Offset = "0x606B38")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x8B6E28", Offset = "0x8B6E28", VA = "0x8B6E28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606BC0", Offset = "0x606BC0")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x8B6FDC", Offset = "0x8B6FDC", VA = "0x8B6FDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606C48", Offset = "0x606C48")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x8B7190", Offset = "0x8B7190", VA = "0x8B7190")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x606CD0", Offset = "0x606CD0")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x8B7344", Offset = "0x8B7344", VA = "0x8B7344")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x8B7484", Offset = "0x8B7484", VA = "0x8B7484")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x8B74B8", Offset = "0x8B74B8", VA = "0x8B74B8")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x8B7580", Offset = "0x8B7580", VA = "0x8B7580")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x8B7678", Offset = "0x8B7678", VA = "0x8B7678")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200015C")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x14000010")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x12D46F0", Offset = "0x12D46F0", VA = "0x12D46F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FA8", Offset = "0x606FA8")]
		add
		{
		}
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x12D4790", Offset = "0x12D4790", VA = "0x12D4790")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FB8", Offset = "0x606FB8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x12D4830", Offset = "0x12D4830", VA = "0x12D4830")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FC8", Offset = "0x606FC8")]
		add
		{
		}
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x12D48D0", Offset = "0x12D48D0", VA = "0x12D48D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FD8", Offset = "0x606FD8")]
		remove
		{
		}
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x12D4970", Offset = "0x12D4970", VA = "0x12D4970")]
	private void Awake()
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x12D4A34", Offset = "0x12D4A34", VA = "0x12D4A34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x12D4A38", Offset = "0x12D4A38", VA = "0x12D4A38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x12D4AAC", Offset = "0x12D4AAC", VA = "0x12D4AAC")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x12D4BD0", Offset = "0x12D4BD0", VA = "0x12D4BD0")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x12D4DB8", Offset = "0x12D4DB8", VA = "0x12D4DB8")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x12D4F80", Offset = "0x12D4F80", VA = "0x12D4F80")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200015D")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x7C8980", Offset = "0x7C8980", VA = "0x7C8980", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x7C8A18", Offset = "0x7C8A18", VA = "0x7C8A18", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000767")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x7C8AE4", Offset = "0x7C8AE4", VA = "0x7C8AE4")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200015E")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604544", Offset = "0x604544")]
	public float Range;

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x7C8AF4", Offset = "0x7C8AF4", VA = "0x7C8AF4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x7C8BF0", Offset = "0x7C8BF0", VA = "0x7C8BF0")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200015F")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x60457C", Offset = "0x60457C")]
	public float Range;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6045B4", Offset = "0x6045B4")]
	public float MinimumElevation;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6045EC", Offset = "0x6045EC")]
	public float Gravity;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x604624", Offset = "0x604624")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604624", Offset = "0x604624")]
	public float AimVelocity;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x604680", Offset = "0x604680")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604680", Offset = "0x604680")]
	public float AimStep;

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x7C8C00", Offset = "0x7C8C00", VA = "0x7C8C00", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x7C8D90", Offset = "0x7C8D90", VA = "0x7C8D90")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x2000160")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6046D8", Offset = "0x6046D8")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x7C8DA4", Offset = "0x7C8DA4", VA = "0x7C8DA4")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x7C8ED0", Offset = "0x7C8ED0", VA = "0x7C8ED0")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x7C8F00", Offset = "0x7C8F00", VA = "0x7C8F00")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x7C8F30", Offset = "0x7C8F30", VA = "0x7C8F30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x7C8FE0", Offset = "0x7C8FE0", VA = "0x7C8FE0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x7C904C", Offset = "0x7C904C", VA = "0x7C904C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x7C90B4", Offset = "0x7C90B4", VA = "0x7C90B4")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x2000161")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604710", Offset = "0x604710")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604720", Offset = "0x604720")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604758", Offset = "0x604758")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604790", Offset = "0x604790")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700015F")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x7C91D8", Offset = "0x7C91D8", VA = "0x7C91D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FE8", Offset = "0x606FE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x7C91E0", Offset = "0x7C91E0", VA = "0x7C91E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FF8", Offset = "0x606FF8")]
		private set
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x7C939C", Offset = "0x7C939C", VA = "0x7C939C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607008", Offset = "0x607008")]
		add
		{
		}
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x7C943C", Offset = "0x7C943C", VA = "0x7C943C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607018", Offset = "0x607018")]
		remove
		{
		}
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x7C91EC", Offset = "0x7C91EC", VA = "0x7C91EC")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x7C9284", Offset = "0x7C9284", VA = "0x7C9284")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x7C9358", Offset = "0x7C9358", VA = "0x7C9358")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x7C9398", Offset = "0x7C9398", VA = "0x7C9398")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x7C94DC", Offset = "0x7C94DC", VA = "0x7C94DC")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x7C9540", Offset = "0x7C9540", VA = "0x7C9540")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x7C9564", Offset = "0x7C9564", VA = "0x7C9564", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x2000162")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016A8", Offset = "0x6016A8")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000160")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x12DD9E0", Offset = "0x12DD9E0", VA = "0x12DD9E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x12DDA28", Offset = "0x12DDA28", VA = "0x12DDA28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x12DD924", Offset = "0x12DD924", VA = "0x12DD924")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x12DD950", Offset = "0x12DD950", VA = "0x12DD950", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x12DD954", Offset = "0x12DD954", VA = "0x12DD954", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x12DD9E8", Offset = "0x12DD9E8", VA = "0x12DD9E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016B8", Offset = "0x6016B8")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000162")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x12DD8D4", Offset = "0x12DD8D4", VA = "0x12DD8D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x12DD91C", Offset = "0x12DD91C", VA = "0x12DD91C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x12DD814", Offset = "0x12DD814", VA = "0x12DD814")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x12DD840", Offset = "0x12DD840", VA = "0x12DD840", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x12DD844", Offset = "0x12DD844", VA = "0x12DD844", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x12DD8DC", Offset = "0x12DD8DC", VA = "0x12DD8DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x7C9770", Offset = "0x7C9770", VA = "0x7C9770")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x7C9838", Offset = "0x7C9838", VA = "0x7C9838", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x7C9890", Offset = "0x7C9890", VA = "0x7C9890", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x7C9948", Offset = "0x7C9948", VA = "0x7C9948")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x607028", Offset = "0x607028")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x7C99BC", Offset = "0x7C99BC", VA = "0x7C99BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x607090", Offset = "0x607090")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000784")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000785")]
	public abstract void GetAimData([Out] Ray aimRay);

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x7C9A30", Offset = "0x7C9A30", VA = "0x7C9A30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6070F8", Offset = "0x6070F8")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x7C9A5C", Offset = "0x7C9A5C", VA = "0x7C9A5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607108", Offset = "0x607108")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x2000165")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6047D8", Offset = "0x6047D8")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6047E8", Offset = "0x6047E8")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604820", Offset = "0x604820")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604858", Offset = "0x604858")]
	public bool FastTeleport;

	[Token(Token = "0x17000164")]
	public Transform Pointer
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x7C9A88", Offset = "0x7C9A88", VA = "0x7C9A88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6071B8", Offset = "0x6071B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x7C9A90", Offset = "0x7C9A90", VA = "0x7C9A90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6071C8", Offset = "0x6071C8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x7C9A98", Offset = "0x7C9A98", VA = "0x7C9A98", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x7C9BE8", Offset = "0x7C9BE8", VA = "0x7C9BE8", Slot = "9")]
	public override void GetAimData([Out] Ray aimRay)
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x7C9CA0", Offset = "0x7C9CA0", VA = "0x7C9CA0")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000166")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000167")]
	public enum InputModes
	{
		[Token(Token = "0x4000590")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x4000591")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x4000592")]
		ThumbstickTeleport,
		[Token(Token = "0x4000593")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000168")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000595")]
		A,
		[Token(Token = "0x4000596")]
		B,
		[Token(Token = "0x4000597")]
		LeftTrigger,
		[Token(Token = "0x4000598")]
		LeftThumbstick,
		[Token(Token = "0x4000599")]
		RightTrigger,
		[Token(Token = "0x400059A")]
		RightThumbstick,
		[Token(Token = "0x400059B")]
		X,
		[Token(Token = "0x400059C")]
		Y
	}

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604890", Offset = "0x604890")]
	public InputModes InputMode;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6048C8", Offset = "0x6048C8")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604900", Offset = "0x604900")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604938", Offset = "0x604938")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x7C9CA4", Offset = "0x7C9CA4", VA = "0x7C9CA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x7C9CA8", Offset = "0x7C9CA8", VA = "0x7C9CA8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x7CA078", Offset = "0x7CA078", VA = "0x7CA078", Slot = "9")]
	public override void GetAimData([Out] Ray aimRay)
	{
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x7CA138", Offset = "0x7CA138", VA = "0x7CA138")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000169")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x200016A")]
	public enum OrientationModes
	{
		[Token(Token = "0x40005A1")]
		HeadRelative,
		[Token(Token = "0x40005A2")]
		ForwardFacing
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016C8", Offset = "0x6016C8")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000165")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x12DDB04", Offset = "0x12DDB04", VA = "0x12DDB04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x12DDB4C", Offset = "0x12DDB4C", VA = "0x12DDB4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x12DDA30", Offset = "0x12DDA30", VA = "0x12DDA30")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x12DDA5C", Offset = "0x12DDA5C", VA = "0x12DDA5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x12DDA60", Offset = "0x12DDA60", VA = "0x12DDA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x12DDB0C", Offset = "0x12DDB0C", VA = "0x12DDB0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x7CA214", Offset = "0x7CA214", VA = "0x7CA214")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x7CA30C", Offset = "0x7CA30C", VA = "0x7CA30C")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x7CA314", Offset = "0x7CA314", VA = "0x7CA314", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x7CA360", Offset = "0x7CA360", VA = "0x7CA360", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x7CA3A8", Offset = "0x7CA3A8", VA = "0x7CA3A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6071D8", Offset = "0x6071D8")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60007A2")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60007A3")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x7CA41C", Offset = "0x7CA41C", VA = "0x7CA41C")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x7CA4D8", Offset = "0x7CA4D8", VA = "0x7CA4D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607240", Offset = "0x607240")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x200016C")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x7CA504", Offset = "0x7CA504", VA = "0x7CA504", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x7CA508", Offset = "0x7CA508", VA = "0x7CA508", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x7CA584", Offset = "0x7CA584", VA = "0x7CA584")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x200016D")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604970", Offset = "0x604970")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6049A8", Offset = "0x6049A8")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6049E0", Offset = "0x6049E0")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604A18", Offset = "0x604A18")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x7CA588", Offset = "0x7CA588", VA = "0x7CA588", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x7CA5B4", Offset = "0x7CA5B4", VA = "0x7CA5B4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x7CA95C", Offset = "0x7CA95C", VA = "0x7CA95C")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x200016E")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604A50", Offset = "0x604A50")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604A88", Offset = "0x604A88")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604AC0", Offset = "0x604AC0")]
	public float RotateStickThreshold;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x7CA960", Offset = "0x7CA960", VA = "0x7CA960", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x7CA9A4", Offset = "0x7CA9A4", VA = "0x7CA9A4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x7CAD44", Offset = "0x7CAD44", VA = "0x7CAD44")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200016F")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x7CAD54", Offset = "0x7CAD54", VA = "0x7CAD54")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x7CAD58", Offset = "0x7CAD58", VA = "0x7CAD58")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x7CAD60", Offset = "0x7CAD60", VA = "0x7CAD60")]
	private void Update()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x7CAE24", Offset = "0x7CAE24", VA = "0x7CAE24")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x7CAE4C", Offset = "0x7CAE4C", VA = "0x7CAE4C")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x2000170")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604AF8", Offset = "0x604AF8")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000167")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x7CAE64", Offset = "0x7CAE64", VA = "0x7CAE64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6072A0", Offset = "0x6072A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x7CAE6C", Offset = "0x7CAE6C", VA = "0x7CAE6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6072B0", Offset = "0x6072B0")]
		private set
		{
		}
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x7C89B0", Offset = "0x7C89B0", VA = "0x7C89B0", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x7C8AB8", Offset = "0x7C8AB8", VA = "0x7C8AB8", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x7CAE74", Offset = "0x7CAE74", VA = "0x7CAE74")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6072C0", Offset = "0x6072C0")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x7C9040", Offset = "0x7C9040", VA = "0x7C9040", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x7C90AC", Offset = "0x7C90AC", VA = "0x7C90AC", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x7C8AEC", Offset = "0x7C8AEC", VA = "0x7C8AEC")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x2000171")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016D8", Offset = "0x6016D8")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000168")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x12DDE18", Offset = "0x12DDE18", VA = "0x12DDE18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x12DDE60", Offset = "0x12DDE60", VA = "0x12DDE60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x12DDB54", Offset = "0x12DDB54", VA = "0x12DDB54")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x12DDB80", Offset = "0x12DDB80", VA = "0x12DDB80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x12DDB84", Offset = "0x12DDB84", VA = "0x12DDB84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x12DDE20", Offset = "0x12DDE20", VA = "0x12DDE20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604B08", Offset = "0x604B08")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40005BC")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x7CAF50", Offset = "0x7CAF50", VA = "0x7CAF50")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x7CB058", Offset = "0x7CB058", VA = "0x7CB058", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x7CB088", Offset = "0x7CB088", VA = "0x7CB088", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x7CB0B4", Offset = "0x7CB0B4", VA = "0x7CB0B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6072F8", Offset = "0x6072F8")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x7CB128", Offset = "0x7CB128", VA = "0x7CB128", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60007C7")]
	protected abstract bool ConsiderTeleport(Vector3 start, Vector3 end);

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x7CB148", Offset = "0x7CB148", VA = "0x7CB148", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x7CB268", Offset = "0x7CB268", VA = "0x7CB268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607360", Offset = "0x607360")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x2000173")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x7CB294", Offset = "0x7CB294", VA = "0x7CB294")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x7CB2F8", Offset = "0x7CB2F8", VA = "0x7CB2F8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x7CB3F0", Offset = "0x7CB3F0", VA = "0x7CB3F0", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x7CB4E8", Offset = "0x7CB4E8", VA = "0x7CB4E8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6073C0", Offset = "0x6073C0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x7CB4EC", Offset = "0x7CB4EC", VA = "0x7CB4EC")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000174")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604B40", Offset = "0x604B40")]
	public float LOSOffset;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604B78", Offset = "0x604B78")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x7CB4F8", Offset = "0x7CB4F8", VA = "0x7CB4F8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x7CB704", Offset = "0x7CB704", VA = "0x7CB704")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000175")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x7CB710", Offset = "0x7CB710", VA = "0x7CB710", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x7CB808", Offset = "0x7CB808", VA = "0x7CB808")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000176")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x7CB80C", Offset = "0x7CB80C", VA = "0x7CB80C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x7CB8A0", Offset = "0x7CB8A0", VA = "0x7CB8A0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60007DB")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x7CB930", Offset = "0x7CB930", VA = "0x7CB930")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000177")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016E8", Offset = "0x6016E8")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x1700016A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x12DDF94", Offset = "0x12DDF94", VA = "0x12DDF94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x12DDFDC", Offset = "0x12DDFDC", VA = "0x12DDFDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x12DDE68", Offset = "0x12DDE68", VA = "0x12DDE68")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x12DDE94", Offset = "0x12DDE94", VA = "0x12DDE94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x12DDE98", Offset = "0x12DDE98", VA = "0x12DDE98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x12DDF9C", Offset = "0x12DDF9C", VA = "0x12DDF9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x604BB0", Offset = "0x604BB0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604BB0", Offset = "0x604BB0")]
	public float TransitionDuration;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x604C08", Offset = "0x604C08")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604C08", Offset = "0x604C08")]
	public float TeleportDelay;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604C5C", Offset = "0x604C5C")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x7CB938", Offset = "0x7CB938", VA = "0x7CB938", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x7CB964", Offset = "0x7CB964", VA = "0x7CB964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6073F8", Offset = "0x6073F8")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x7CB9D8", Offset = "0x7CB9D8", VA = "0x7CB9D8")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000179")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x7CBB78", Offset = "0x7CBB78", VA = "0x7CBB78", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x7CBB98", Offset = "0x7CBB98", VA = "0x7CBB98")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x200017A")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6016F8", Offset = "0x6016F8")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700016C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x12DE134", Offset = "0x12DE134", VA = "0x12DE134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x12DE17C", Offset = "0x12DE17C", VA = "0x12DE17C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x12DDFE4", Offset = "0x12DDFE4", VA = "0x12DDFE4")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x12DE010", Offset = "0x12DE010", VA = "0x12DE010", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x12DE014", Offset = "0x12DE014", VA = "0x12DE014", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x12DE13C", Offset = "0x12DE13C", VA = "0x12DE13C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x604C94", Offset = "0x604C94")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x604C94", Offset = "0x604C94")]
	public float TransitionDuration;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x7CBBA0", Offset = "0x7CBBA0", VA = "0x7CBBA0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x7CBBCC", Offset = "0x7CBBCC", VA = "0x7CBBCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6074B0", Offset = "0x6074B0")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x7CBC40", Offset = "0x7CBC40", VA = "0x7CBC40")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x200017C")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x200017D")]
	public enum PlabackState
	{
		[Token(Token = "0x40005E9")]
		Idle = 1,
		[Token(Token = "0x40005EA")]
		Preparing,
		[Token(Token = "0x40005EB")]
		Buffering,
		[Token(Token = "0x40005EC")]
		Ready,
		[Token(Token = "0x40005ED")]
		Ended
	}

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700016E")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8C1D94", Offset = "0x8C1D94", VA = "0x8C1D94")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700016F")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8C20C4", Offset = "0x8C20C4", VA = "0x8C20C4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000170")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x8BD8F8", Offset = "0x8BD8F8", VA = "0x8BD8F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000171")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x8BECBC", Offset = "0x8BECBC", VA = "0x8BECBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000172")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x8C2394", Offset = "0x8C2394", VA = "0x8C2394")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000173")]
	public static long Duration
	{
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x8BEEF0", Offset = "0x8BEEF0", VA = "0x8BEEF0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000174")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x8BEDD4", Offset = "0x8BEDD4", VA = "0x8BEDD4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x8BE3B0", Offset = "0x8BE3B0", VA = "0x8BE3B0")]
		set
		{
		}
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x8C24B0", Offset = "0x8C24B0", VA = "0x8C24B0")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x8BF2C8", Offset = "0x8BF2C8", VA = "0x8BF2C8")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x8BDFEC", Offset = "0x8BDFEC", VA = "0x8BDFEC")]
	public static void Play()
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x8BE194", Offset = "0x8BE194", VA = "0x8BE194")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x8BF0C0", Offset = "0x8BF0C0", VA = "0x8BF0C0")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x8C26D8", Offset = "0x8C26D8", VA = "0x8C26D8")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x8BEACC", Offset = "0x8BEACC", VA = "0x8BEACC")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200017E")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x14000013")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x7BDD80", Offset = "0x7BDD80", VA = "0x7BDD80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607568", Offset = "0x607568")]
		add
		{
		}
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x7BDE20", Offset = "0x7BDE20", VA = "0x7BDE20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607578", Offset = "0x607578")]
		remove
		{
		}
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0x7BDEC0", Offset = "0x7BDEC0", VA = "0x7BDEC0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0x7BDED4", Offset = "0x7BDED4", VA = "0x7BDED4")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200017F")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000180")]
	public enum ButtonType
	{
		[Token(Token = "0x40005F1")]
		Play,
		[Token(Token = "0x40005F2")]
		Pause,
		[Token(Token = "0x40005F3")]
		FastForward,
		[Token(Token = "0x40005F4")]
		Rewind,
		[Token(Token = "0x40005F5")]
		SkipForward,
		[Token(Token = "0x40005F6")]
		SkipBack,
		[Token(Token = "0x40005F7")]
		Stop
	}

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000175")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x8B971C", Offset = "0x8B971C", VA = "0x8B971C")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x8B9724", Offset = "0x8B9724", VA = "0x8B9724")]
		set
		{
		}
	}

	[Token(Token = "0x6000807")]
	[Address(RVA = "0x8B9748", Offset = "0x8B9748", VA = "0x8B9748", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000808")]
	[Address(RVA = "0x8BABE4", Offset = "0x8BABE4", VA = "0x8BABE4")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000181")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000182")]
	public enum VideoShape
	{
		[Token(Token = "0x400060B")]
		_360,
		[Token(Token = "0x400060C")]
		_180,
		[Token(Token = "0x400060D")]
		Quad
	}

	[Token(Token = "0x2000183")]
	public enum VideoStereo
	{
		[Token(Token = "0x400060F")]
		Mono,
		[Token(Token = "0x4000610")]
		TopBottom,
		[Token(Token = "0x4000611")]
		LeftRight,
		[Token(Token = "0x4000612")]
		BottomTop
	}

	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601708", Offset = "0x601708")]
	private sealed class <Start>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000179")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x12DA3A0", Offset = "0x12DA3A0", VA = "0x12DA3A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x12DA3E8", Offset = "0x12DA3E8", VA = "0x12DA3E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x12DA1B8", Offset = "0x12DA1B8", VA = "0x12DA1B8")]
		[DebuggerHidden]
		public <Start>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x12DA1E4", Offset = "0x12DA1E4", VA = "0x12DA1E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x12DA1E8", Offset = "0x12DA1E8", VA = "0x12DA1E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x12DA3A8", Offset = "0x12DA3A8", VA = "0x12DA3A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x601718", Offset = "0x601718")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x12DA0C0", Offset = "0x12DA0C0", VA = "0x12DA0C0")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x12DA0C8", Offset = "0x12DA0C8", VA = "0x12DA0C8")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604D1C", Offset = "0x604D1C")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604D2C", Offset = "0x604D2C")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604D3C", Offset = "0x604D3C")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool DisplayMono;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000176")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x8BD648", Offset = "0x8BD648", VA = "0x8BD648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607588", Offset = "0x607588")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x8BD650", Offset = "0x8BD650", VA = "0x8BD650")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607598", Offset = "0x607598")]
		private set
		{
		}
	}

	[Token(Token = "0x17000177")]
	public long Duration
	{
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x8BD65C", Offset = "0x8BD65C", VA = "0x8BD65C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6075A8", Offset = "0x6075A8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8BD664", Offset = "0x8BD664", VA = "0x8BD664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6075B8", Offset = "0x6075B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000178")]
	public long PlaybackPosition
	{
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x8BD66C", Offset = "0x8BD66C", VA = "0x8BD66C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6075C8", Offset = "0x6075C8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x8BD674", Offset = "0x8BD674", VA = "0x8BD674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6075D8", Offset = "0x6075D8")]
		private set
		{
		}
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x8BD67C", Offset = "0x8BD67C", VA = "0x8BD67C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x8BD968", Offset = "0x8BD968", VA = "0x8BD968")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x8BD9CC", Offset = "0x8BD9CC", VA = "0x8BD9CC")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x8BDC40", Offset = "0x8BDC40", VA = "0x8BDC40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6075E8", Offset = "0x6075E8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x8BDCB4", Offset = "0x8BDCB4", VA = "0x8BDCB4")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x8BDF5C", Offset = "0x8BDF5C", VA = "0x8BDF5C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x8BE108", Offset = "0x8BE108", VA = "0x8BE108")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x8BE2B0", Offset = "0x8BE2B0", VA = "0x8BE2B0")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x8BE52C", Offset = "0x8BE52C", VA = "0x8BE52C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x8BF00C", Offset = "0x8BF00C", VA = "0x8BF00C")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x8BF23C", Offset = "0x8BF23C", VA = "0x8BF23C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600081A")]
	[Address(RVA = "0x8BF3E4", Offset = "0x8BF3E4", VA = "0x8BF3E4")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0x8BF4D8", Offset = "0x8BF4D8", VA = "0x8BF4D8")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000186")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000187")]
	private enum PlaybackState
	{
		[Token(Token = "0x400062F")]
		Playing,
		[Token(Token = "0x4000630")]
		Paused,
		[Token(Token = "0x4000631")]
		Rewinding,
		[Token(Token = "0x4000632")]
		FastForwarding
	}

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x8BF4E8", Offset = "0x8BF4E8", VA = "0x8BF4E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x8BF844", Offset = "0x8BF844", VA = "0x8BF844")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x8BFA24", Offset = "0x8BFA24", VA = "0x8BFA24")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x8BFB60", Offset = "0x8BFB60", VA = "0x8BFB60")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0x8BFC6C", Offset = "0x8BFC6C", VA = "0x8BFC6C")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x8BFB30", Offset = "0x8BFB30", VA = "0x8BFB30")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x8BFCD4", Offset = "0x8BFCD4", VA = "0x8BFCD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x8BF730", Offset = "0x8BF730", VA = "0x8BF730")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x8C0014", Offset = "0x8C0014", VA = "0x8C0014")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000188")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601728", Offset = "0x601728")]
[ExecuteInEditMode]
public class OVROverlayMeshGenerator : MonoBehaviour
{
	[Token(Token = "0x2000189")]
	private enum CubeFace
	{
		[Token(Token = "0x4000647")]
		Right,
		[Token(Token = "0x4000648")]
		Left,
		[Token(Token = "0x4000649")]
		Top,
		[Token(Token = "0x400064A")]
		Bottom,
		[Token(Token = "0x400064B")]
		Front,
		[Token(Token = "0x400064C")]
		Back,
		[Token(Token = "0x400064D")]
		COUNT
	}

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Mesh _Mesh;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> _Verts;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector2> _UV;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<int> _Tris;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OVROverlay _Overlay;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter _MeshFilter;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshCollider _MeshCollider;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform _CameraRoot;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform _Transform;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVROverlay.OverlayShape _LastShape;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 _LastPosition;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Quaternion _LastRotation;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _LastScale;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Rect _LastRectLeft;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Rect _LastRectRight;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool _Awake;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3[] BottomLeft;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Vector3[] RightVector;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Vector3[] UpVector;

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x8C2974", Offset = "0x8C2974", VA = "0x8C2974")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x8C2AFC", Offset = "0x8C2AFC", VA = "0x8C2AFC")]
	private Rect GetBoundingRect(Rect a, Rect b)
	{
		return default(Rect);
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x8C2C68", Offset = "0x8C2C68", VA = "0x8C2C68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x8C302C", Offset = "0x8C302C", VA = "0x8C302C")]
	private void UpdateMesh(OVROverlay.OverlayShape shape, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect)
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x8C3344", Offset = "0x8C3344", VA = "0x8C3344")]
	public static void GenerateMesh(List<Vector3> verts, List<Vector2> uvs, List<int> tris, OVROverlay.OverlayShape shape, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x8C441C", Offset = "0x8C441C", VA = "0x8C441C")]
	private static Vector2 GetSphereUV(float theta, float phi, float expand_coef)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x8C4454", Offset = "0x8C4454", VA = "0x8C4454")]
	private static Vector3 GetSphereVert(float theta, float phi)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x8C36BC", Offset = "0x8C36BC", VA = "0x8C36BC")]
	public static void BuildSphere(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect, float worldScale = 800f, int latitudes = 128, int longitudes = 128, float expand_coef = 1f)
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x8C44B0", Offset = "0x8C44B0", VA = "0x8C44B0")]
	private static Vector2 GetCubeUV(CubeFace face, Vector2 sideUV, float expand_coef)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x8C45C8", Offset = "0x8C45C8", VA = "0x8C45C8")]
	private static Vector3 GetCubeVert(CubeFace face, Vector2 sideUV, float expand_coef)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x8C3B34", Offset = "0x8C3B34", VA = "0x8C3B34")]
	public static void BuildCube(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Vector3 position, Quaternion rotation, Vector3 scale, float worldScale = 800f, int subQuads = 1, float expand_coef = 1.01f)
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x8C3E48", Offset = "0x8C3E48", VA = "0x8C3E48")]
	public static void BuildQuad(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Rect rect)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x8C40F4", Offset = "0x8C40F4", VA = "0x8C40F4")]
	public static void BuildHemicylinder(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Vector3 scale, Rect rect, int longitudes = 128)
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x8C46F0", Offset = "0x8C46F0", VA = "0x8C46F0")]
	public OVROverlayMeshGenerator()
	{
	}
}
[Token(Token = "0x200018A")]
public static class VectorUtil
{
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x7D4C48", Offset = "0x7D4C48", VA = "0x7D4C48")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x200018B")]
[DisallowMultipleComponent]
public class BehaviorTree : ParallelNoBlockNode
{
	[Serializable]
	[Token(Token = "0x200018C")]
	public class ObjectVariable
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEngine.Object obj;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x7D7A0C", Offset = "0x7D7A0C", VA = "0x7D7A0C")]
		public ObjectVariable()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6017C0", Offset = "0x6017C0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<BehaviorTreeNode, bool> <>9__7_0;

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x7D79E4", Offset = "0x7D79E4", VA = "0x7D79E4")]
		public <>c()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x7D79EC", Offset = "0x7D79EC", VA = "0x7D79EC")]
		internal bool <set_isRunning>b__7_0(BehaviorTreeNode node)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<ObjectVariable> _objects;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _AutoRun;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool _RunOnStart;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool _RunRepeat;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool _IsRunning;

	[Token(Token = "0x1700017B")]
	public bool isRunning
	{
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x7B65A0", Offset = "0x7B65A0", VA = "0x7B65A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x7B65A8", Offset = "0x7B65A8", VA = "0x7B65A8")]
		set
		{
		}
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x7B6818", Offset = "0x7B6818", VA = "0x7B6818", Slot = "8")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x6000840")]
	public T GetObject<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x7B69EC", Offset = "0x7B69EC", VA = "0x7B69EC")]
	public ObjectVariable GetObjectVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x7B6B30", Offset = "0x7B6B30", VA = "0x7B6B30")]
	public void SetObject(string name, UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x7B6CE4", Offset = "0x7B6CE4", VA = "0x7B6CE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x7B6D28", Offset = "0x7B6D28", VA = "0x7B6D28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x7B6E04", Offset = "0x7B6E04", VA = "0x7B6E04")]
	public BehaviorTree()
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x7B6E1C", Offset = "0x7B6E1C", VA = "0x7B6E1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6076B0", Offset = "0x6076B0")]
	private bool <OnReset>b__8_0(BehaviorTreeNode node)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200018E")]
public class BehaviorTreeEditorData
{
	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 scale;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 position;

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x7B6E3C", Offset = "0x7B6E3C", VA = "0x7B6E3C")]
	public BehaviorTreeEditorData()
	{
	}
}
[Token(Token = "0x200018F")]
[ExecuteAlways]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6017D0", Offset = "0x6017D0")]
[DisallowMultipleComponent]
public class BehaviorTreeNode : MonoBehaviour, IEnumerable<BehaviorTreeNode>, IEnumerable
{
	[Token(Token = "0x2000190")]
	public enum ExecuteState
	{
		[Token(Token = "0x4000660")]
		NotExecute,
		[Token(Token = "0x4000661")]
		Running,
		[Token(Token = "0x4000662")]
		Failed,
		[Token(Token = "0x4000663")]
		Success
	}

	[Token(Token = "0x2000191")]
	public static class Utils
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string undoGroupName;

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x7D7A14", Offset = "0x7D7A14", VA = "0x7D7A14")]
		public static void SetChildIndex(BehaviorTreeNode child, int newIndex)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x7D7CA8", Offset = "0x7D7CA8", VA = "0x7D7CA8")]
		public static BehaviorTreeNode Create(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x7D7ED4", Offset = "0x7D7ED4", VA = "0x7D7ED4")]
		public static BehaviorTreeNode DoublicateNode(BehaviorTreeNode node)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x7D7FB0", Offset = "0x7D7FB0", VA = "0x7D7FB0")]
		public static void AddNode(BehaviorTreeNode node, BehaviorTreeNode parent, int index = -1)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x7D8354", Offset = "0x7D8354", VA = "0x7D8354")]
		public static void RemoveNode(BehaviorTreeNode node)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x7D8204", Offset = "0x7D8204", VA = "0x7D8204")]
		public static void ClearParent(BehaviorTreeNode node)
		{
		}
	}

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[Multiline]
	public string description;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private List<BehaviorTreeNode> mNodes;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private BehaviorTree _owner;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private BehaviorTreeNode _parent;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<BehaviorVariable> mBehaviorVariables;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ExecuteState _state;

	[Token(Token = "0x1700017C")]
	public BehaviorTree owner
	{
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x7B6E44", Offset = "0x7B6E44", VA = "0x7B6E44")]
		get
		{
			return null;
		}
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x7B6E4C", Offset = "0x7B6E4C", VA = "0x7B6E4C")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700017D")]
	public BehaviorTreeNode parent
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x7B690C", Offset = "0x7B690C", VA = "0x7B690C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x7B6E54", Offset = "0x7B6E54", VA = "0x7B6E54")]
		set
		{
		}
	}

	[Token(Token = "0x1700017E")]
	public bool isActive
	{
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x7B7008", Offset = "0x7B7008", VA = "0x7B7008")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700017F")]
	public int childCount
	{
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x7B7010", Offset = "0x7B7010", VA = "0x7B7010")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000180")]
	public BehaviorTreeNode Item
	{
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x7B705C", Offset = "0x7B705C", VA = "0x7B705C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000181")]
	public ExecuteState state
	{
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x7B7134", Offset = "0x7B7134", VA = "0x7B7134")]
		get
		{
			return default(ExecuteState);
		}
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x7B713C", Offset = "0x7B713C", VA = "0x7B713C")]
		set
		{
		}
	}

	[Token(Token = "0x17000182")]
	public virtual int maxChildCount
	{
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x7B7144", Offset = "0x7B7144", VA = "0x7B7144", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x7B6F3C", Offset = "0x7B6F3C", VA = "0x7B6F3C")]
	public static bool CheckCycleParentChild(BehaviorTreeNode child, BehaviorTreeNode parent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x7B70D0", Offset = "0x7B70D0", VA = "0x7B70D0")]
	public int IndexOfChild(BehaviorTreeNode node)
	{
		return default(int);
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x7B714C", Offset = "0x7B714C", VA = "0x7B714C", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x7B6988", Offset = "0x7B6988", VA = "0x7B6988", Slot = "8")]
	public virtual void OnReset()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x7B72B4", Offset = "0x7B72B4", VA = "0x7B72B4", Slot = "9")]
	public virtual void OnResetChildren()
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x7B77A4", Offset = "0x7B77A4", VA = "0x7B77A4", Slot = "10")]
	public virtual void OnResetSelf()
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x7B77A8", Offset = "0x7B77A8", VA = "0x7B77A8", Slot = "11")]
	public virtual ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x7B77BC", Offset = "0x7B77BC", VA = "0x7B77BC", Slot = "12")]
	public virtual void OnRemoved()
	{
	}

	[Token(Token = "0x600085E")]
	public bool CanAcceptChild<T>()
	{
		return default(bool);
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x7B77C0", Offset = "0x7B77C0", VA = "0x7B77C0", Slot = "13")]
	public virtual bool CanAcceptChild(Type t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x7B7710", Offset = "0x7B7710", VA = "0x7B7710", Slot = "4")]
	public IEnumerator<BehaviorTreeNode> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x7B77C8", Offset = "0x7B77C8", VA = "0x7B77C8", Slot = "5")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x7B66EC", Offset = "0x7B66EC", VA = "0x7B66EC")]
	public bool EnumAllNodes(Func<BehaviorTreeNode, bool> func, bool includeSelf = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x7B77CC", Offset = "0x7B77CC", VA = "0x7B77CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x7B715C", Offset = "0x7B715C", VA = "0x7B715C")]
	private void UpdateList(bool includeChildren = false)
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x7B7964", Offset = "0x7B7964", VA = "0x7B7964", Slot = "14")]
	public virtual void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x7B7A3C", Offset = "0x7B7A3C", VA = "0x7B7A3C")]
	public void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x7B7A44", Offset = "0x7B7A44", VA = "0x7B7A44", Slot = "15")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x7B7B00", Offset = "0x7B7B00", VA = "0x7B7B00")]
	public BehaviorVariable Find(string name)
	{
		return null;
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x7B7C44", Offset = "0x7B7C44", VA = "0x7B7C44")]
	internal void RegisterVariable(BehaviorVariable behaviorVariable)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x7B7CA8", Offset = "0x7B7CA8", VA = "0x7B7CA8")]
	internal void UnregisterVariable(BehaviorVariable behaviorVariable)
	{
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0x7B5CA4", Offset = "0x7B5CA4", VA = "0x7B5CA4")]
	public BehaviorTreeNode()
	{
	}
}
[Token(Token = "0x2000192")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x60182C", Offset = "0x60182C")]
public sealed class TreeNode : Attribute
{
	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604E6C", Offset = "0x604E6C")]
	private string <name>k__BackingField;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604E7C", Offset = "0x604E7C")]
	private string <description>k__BackingField;

	[Token(Token = "0x17000183")]
	public string name
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x7CC258", Offset = "0x7CC258", VA = "0x7CC258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6076C0", Offset = "0x6076C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x7CC260", Offset = "0x7CC260", VA = "0x7CC260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6076D0", Offset = "0x6076D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000184")]
	public string description
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x7CC268", Offset = "0x7CC268", VA = "0x7CC268")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6076E0", Offset = "0x6076E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x7CC270", Offset = "0x7CC270", VA = "0x7CC270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6076F0", Offset = "0x6076F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0x7CC278", Offset = "0x7CC278", VA = "0x7CC278")]
	public TreeNode()
	{
	}
}
[Token(Token = "0x2000193")]
public interface IBehaviorTreeNodeInformation
{
	[Token(Token = "0x17000185")]
	string information
	{
		[Token(Token = "0x6000878")]
		get;
	}
}
[Serializable]
[Token(Token = "0x2000194")]
public class BehaviorTreeNodeEditorData
{
	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 position;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;

	[NonSerialized]
	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BehaviorTreeNode.ExecuteState lastState;

	[Token(Token = "0x6000879")]
	[Address(RVA = "0x7B7D0C", Offset = "0x7B7D0C", VA = "0x7B7D0C")]
	public BehaviorTreeNodeEditorData()
	{
	}
}
[Token(Token = "0x2000195")]
public class ObjectFieldGetter : ValueGetter
{
	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEngine.Object mObject;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string mFieldName;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private FieldInfo mFieldInfo;

	[Token(Token = "0x17000186")]
	public override object value
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x12BEEA4", Offset = "0x12BEEA4", VA = "0x12BEEA4", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x12BEED4", Offset = "0x12BEED4", VA = "0x12BEED4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0x12BEE44", Offset = "0x12BEE44", VA = "0x12BEE44")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0x12BEEA0", Offset = "0x12BEEA0", VA = "0x12BEEA0", Slot = "6")]
	public override void OnValidate()
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0x12BEF00", Offset = "0x12BEF00", VA = "0x12BEF00")]
	public ObjectFieldGetter()
	{
	}
}
[Token(Token = "0x2000196")]
public class ObjectGetter : ValueGetter
{
	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEngine.Object mObject;

	[Token(Token = "0x17000187")]
	public override object value
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x12BEF34", Offset = "0x12BEF34", VA = "0x12BEF34", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x12BEF3C", Offset = "0x12BEF3C", VA = "0x12BEF3C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x12BEF08", Offset = "0x12BEF08", VA = "0x12BEF08")]
	public ObjectGetter(UnityEngine.Object obj)
	{
	}
}
[Token(Token = "0x2000197")]
public class ObjectPropertyGetter : ValueGetter
{
	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEngine.Object _object;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _property;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PropertyInfo mPropertyInfo;

	[Token(Token = "0x17000188")]
	public override object value
	{
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x12BEF98", Offset = "0x12BEF98", VA = "0x12BEF98", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x12BEFCC", Offset = "0x12BEFCC", VA = "0x12BEFCC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0x12BEF40", Offset = "0x12BEF40", VA = "0x12BEF40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0x12BEF94", Offset = "0x12BEF94", VA = "0x12BEF94", Slot = "6")]
	public override void OnValidate()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0x12BF004", Offset = "0x12BF004", VA = "0x12BF004")]
	public ObjectPropertyGetter()
	{
	}
}
[Token(Token = "0x2000198")]
public class ValueFieldGetter : ValueGetter
{
	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ValueGetter mValueGetter;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string mFieldName;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private FieldInfo mFieldInfo;

	[Token(Token = "0x17000189")]
	public override object value
	{
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x7D46A8", Offset = "0x7D46A8", VA = "0x7D46A8", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x7D46F8", Offset = "0x7D46F8", VA = "0x7D46F8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x7D45D8", Offset = "0x7D45D8", VA = "0x7D45D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0x7D46A4", Offset = "0x7D46A4", VA = "0x7D46A4", Slot = "6")]
	public override void OnValidate()
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x7D4748", Offset = "0x7D4748", VA = "0x7D4748")]
	public ValueFieldGetter()
	{
	}
}
[Token(Token = "0x2000199")]
public class ValueGetter : ScriptableObject
{
	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string targetType;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604F0C", Offset = "0x604F0C")]
	private object <value>k__BackingField;

	[Token(Token = "0x1700018A")]
	public virtual object value
	{
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x7D4758", Offset = "0x7D4758", VA = "0x7D4758", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607700", Offset = "0x607700")]
		get
		{
			return null;
		}
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x7D4760", Offset = "0x7D4760", VA = "0x7D4760", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607710", Offset = "0x607710")]
		set
		{
		}
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x7D4768", Offset = "0x7D4768", VA = "0x7D4768", Slot = "6")]
	public virtual void OnValidate()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x7D4750", Offset = "0x7D4750", VA = "0x7D4750")]
	public ValueGetter()
	{
	}
}
[Token(Token = "0x200019A")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x601860", Offset = "0x601860")]
public sealed class TargetValueType : Attribute
{
	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604F1C", Offset = "0x604F1C")]
	private Type <type>k__BackingField;

	[Token(Token = "0x1700018B")]
	public Type type
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x7C8970", Offset = "0x7C8970", VA = "0x7C8970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607720", Offset = "0x607720")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x7C8978", Offset = "0x7C8978", VA = "0x7C8978")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607730", Offset = "0x607730")]
		private set
		{
		}
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x7C8944", Offset = "0x7C8944", VA = "0x7C8944")]
	public TargetValueType(Type type)
	{
	}
}
[Token(Token = "0x200019B")]
public class ValueMethodGettter : ValueGetter
{
	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string mMethodName;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ValueGetter mValueGetter;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ValueGetter[] mArgs;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string[] mArgTypeNames;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private object[] mTmpObjs;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Type[] mArgTypes;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MethodInfo mMethodInfo;

	[Token(Token = "0x1700018C")]
	public override object value
	{
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x7D495C", Offset = "0x7D495C", VA = "0x7D495C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x7D4A44", Offset = "0x7D4A44", VA = "0x7D4A44", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x7D476C", Offset = "0x7D476C", VA = "0x7D476C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x7D4958", Offset = "0x7D4958", VA = "0x7D4958", Slot = "6")]
	public override void OnValidate()
	{
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x7D4A84", Offset = "0x7D4A84", VA = "0x7D4A84")]
	public ValueMethodGettter()
	{
	}
}
[Token(Token = "0x200019C")]
public class ValuePropertyGetter : ValueGetter
{
	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ValueGetter mValueGetter;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string mPropertyName;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PropertyInfo mPropertyInfo;

	[Token(Token = "0x1700018D")]
	public override object value
	{
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x7D4B98", Offset = "0x7D4B98", VA = "0x7D4B98", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x7D4BEC", Offset = "0x7D4BEC", VA = "0x7D4BEC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x7D4A8C", Offset = "0x7D4A8C", VA = "0x7D4A8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x7D4B5C", Offset = "0x7D4B5C", VA = "0x7D4B5C", Slot = "6")]
	public override void OnValidate()
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0x7D4B60", Offset = "0x7D4B60", VA = "0x7D4B60")]
	public ValuePropertyGetter(ValueGetter handler, string propertyName)
	{
	}
}
[Token(Token = "0x200019D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x601894", Offset = "0x601894")]
public abstract class BehaviorVariable : MonoBehaviour
{
	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6018FC", Offset = "0x6018FC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x7D848C", Offset = "0x7D848C", VA = "0x7D848C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x7D8494", Offset = "0x7D8494", VA = "0x7D8494")]
		internal bool <Reset>b__0(BehaviorVariable v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected BehaviorTreeNode mNode;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _name;

	[Token(Token = "0x1700018E")]
	public abstract object objectValue
	{
		[Token(Token = "0x600089E")]
		get;
		[Token(Token = "0x600089F")]
		set;
	}

	[Token(Token = "0x1700018F")]
	public virtual bool readOnly
	{
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x7B7F1C", Offset = "0x7B7F1C", VA = "0x7B7F1C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000190")]
	public string variableName
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x7B7F24", Offset = "0x7B7F24", VA = "0x7B7F24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000191")]
	public abstract Type valueType
	{
		[Token(Token = "0x60008A2")]
		get;
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0x7B7D14", Offset = "0x7B7D14", VA = "0x7B7D14", Slot = "4")]
	protected virtual void Reset()
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x7B7F2C", Offset = "0x7B7F2C", VA = "0x7B7F2C", Slot = "9")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x7B7F94", Offset = "0x7B7F94", VA = "0x7B7F94", Slot = "10")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x7B8030", Offset = "0x7B8030", VA = "0x7B8030")]
	protected BehaviorVariable()
	{
	}
}
[Token(Token = "0x200019F")]
public class TreeVariable : Attribute
{
	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604F9C", Offset = "0x604F9C")]
	private readonly Type <type>k__BackingField;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x604FAC", Offset = "0x604FAC")]
	private string <name>k__BackingField;

	[Token(Token = "0x17000192")]
	public Type type
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x7CC280", Offset = "0x7CC280", VA = "0x7CC280")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607740", Offset = "0x607740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000193")]
	public string name
	{
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x7CC2B4", Offset = "0x7CC2B4", VA = "0x7CC2B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607750", Offset = "0x607750")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x7CC2BC", Offset = "0x7CC2BC", VA = "0x7CC2BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607760", Offset = "0x607760")]
		set
		{
		}
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x7CC288", Offset = "0x7CC288", VA = "0x7CC288")]
	public TreeVariable(Type type)
	{
	}
}
[Token(Token = "0x20001A0")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x60190C", Offset = "0x60190C")]
public class BehaviorVariableBool : BehaviorVariableConst<bool>
{
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x7B8038", Offset = "0x7B8038", VA = "0x7B8038")]
	public BehaviorVariableBool()
	{
	}
}
[Token(Token = "0x20001A1")]
public class BehaviorVariableConst<T> : BehaviorVariable
{
	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private T _value;

	[Token(Token = "0x17000194")]
	public override object objectValue
	{
		[Token(Token = "0x60008AD")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008AE")]
		set
		{
		}
	}

	[Token(Token = "0x17000195")]
	public override Type valueType
	{
		[Token(Token = "0x60008AF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000196")]
	public virtual T value
	{
		[Token(Token = "0x60008B0")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60008B1")]
		set
		{
		}
	}

	[Token(Token = "0x60008B2")]
	public BehaviorVariableConst()
	{
	}
}
[Token(Token = "0x20001A2")]
public static class BehaviorVariableExtensions
{
	[Token(Token = "0x60008B3")]
	public static T GetValue<T>(this BehaviorVariable var)
	{
		return (T)null;
	}
}
[Token(Token = "0x20001A3")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x601998", Offset = "0x601998")]
public class BehaviorVariableFloat : BehaviorVariableConst<float>
{
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x7B808C", Offset = "0x7B808C", VA = "0x7B808C")]
	public BehaviorVariableFloat()
	{
	}
}
[Token(Token = "0x20001A4")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x601A14", Offset = "0x601A14")]
public class BehaviorVariableInt : BehaviorVariableConst<int>
{
	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x7B80E0", Offset = "0x7B80E0", VA = "0x7B80E0")]
	public BehaviorVariableInt()
	{
	}
}
[Token(Token = "0x20001A5")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x601A90", Offset = "0x601A90")]
public class BehaviorVariableObject : BehaviorVariableConst<UnityEngine.Object>
{
	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _valueType;

	[Token(Token = "0x17000197")]
	public override Type valueType
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x7B8134", Offset = "0x7B8134", VA = "0x7B8134", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000198")]
	public Type baseType
	{
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x7B8214", Offset = "0x7B8214", VA = "0x7B8214")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x7B8268", Offset = "0x7B8268", VA = "0x7B8268")]
	public void SetType(Type type)
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x7B82A8", Offset = "0x7B82A8", VA = "0x7B82A8")]
	public BehaviorVariableObject()
	{
	}
}
[Token(Token = "0x20001A6")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x601B0C", Offset = "0x601B0C")]
public class BehaviorVariableString : BehaviorVariableConst<string>
{
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x7B82FC", Offset = "0x7B82FC", VA = "0x7B82FC")]
	public BehaviorVariableString()
	{
	}
}
[Token(Token = "0x20001A7")]
[AttributeAttribute(Name = "TreeVariable", RVA = "0x601B88", Offset = "0x601B88")]
public class BehaviorVariableVector3 : BehaviorVariableConst<Vector3>
{
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x7B8350", Offset = "0x7B8350", VA = "0x7B8350")]
	public BehaviorVariableVector3()
	{
	}
}
[Token(Token = "0x20001A8")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601C04", Offset = "0x601C04")]
public class BVStringConditionNode : BehaviorTreeNode
{
	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableString _Variable;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _Value;

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x7B6308", Offset = "0x7B6308", VA = "0x7B6308", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x7B63C4", Offset = "0x7B63C4", VA = "0x7B63C4")]
	public BVStringConditionNode()
	{
	}
}
[Token(Token = "0x20001A9")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601C40", Offset = "0x601C40")]
public class AnimatiorIntNode : BehaviorTreeNode
{
	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AttributeAttribute(Name = "TargetValueType", RVA = "0x604FFC", Offset = "0x604FFC")]
	private BehaviorVariable _Animator;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _ParamName;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int _ParamValue;

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x7B5BB0", Offset = "0x7B5BB0", VA = "0x7B5BB0", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x7B5CA0", Offset = "0x7B5CA0", VA = "0x7B5CA0")]
	public AnimatiorIntNode()
	{
	}
}
[Token(Token = "0x20001AA")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601C7C", Offset = "0x601C7C")]
public class PlayAnimationNode : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Animator _Animator;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TargetValueType", RVA = "0x6050A4", Offset = "0x6050A4")]
	[SerializeField]
	private BehaviorVariable _AnimatorVar;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _Name;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _SetActiveBefore;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	private bool _SetInactiveAfter;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[SerializeField]
	private bool _DontWait;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x60515C", Offset = "0x60515C")]
	private int _Layer;

	[Token(Token = "0x17000199")]
	public string information
	{
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x12CD294", Offset = "0x12CD294", VA = "0x12CD294", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019A")]
	private Animator animator
	{
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x12CD29C", Offset = "0x12CD29C", VA = "0x12CD29C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x12CD3BC", Offset = "0x12CD3BC", VA = "0x12CD3BC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x12CD47C", Offset = "0x12CD47C", VA = "0x12CD47C")]
	private bool CheckDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x12CD544", Offset = "0x12CD544", VA = "0x12CD544")]
	public PlayAnimationNode()
	{
	}
}
[Token(Token = "0x20001AB")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601CB8", Offset = "0x601CB8")]
public class BoolNode : BehaviorTreeNode
{
	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AttributeAttribute(Name = "TargetValueType", RVA = "0x605198", Offset = "0x605198")]
	private ValueGetter _boolValue;

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x7BBD54", Offset = "0x7BBD54", VA = "0x7BBD54", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x7BBEAC", Offset = "0x7BBEAC", VA = "0x7BBEAC")]
	public BoolNode()
	{
	}
}
[Token(Token = "0x20001AC")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601D04", Offset = "0x601D04")]
public class IntSwitchNode : BehaviorTreeNode
{
	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableInt _value;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int mRuningNodeIndex;

	[Token(Token = "0x1700019B")]
	public int value
	{
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x8B1B50", Offset = "0x8B1B50", VA = "0x8B1B50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x8B1B74", Offset = "0x8B1B74", VA = "0x8B1B74")]
		set
		{
		}
	}

	[Token(Token = "0x1700019C")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x8B1BA4", Offset = "0x8B1BA4", VA = "0x8B1BA4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x8B1B98", Offset = "0x8B1B98", VA = "0x8B1B98", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x8B1BAC", Offset = "0x8B1BAC", VA = "0x8B1BAC", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x8B1C48", Offset = "0x8B1C48", VA = "0x8B1C48")]
	public IntSwitchNode()
	{
	}
}
[Token(Token = "0x20001AD")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601D40", Offset = "0x601D40")]
public class StringSwitchNode : BehaviorTreeNode
{
	[Serializable]
	[Token(Token = "0x20001AE")]
	private class Config
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string key;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x12DD80C", Offset = "0x12DD80C", VA = "0x12DD80C")]
		public Config()
		{
		}
	}

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableString _value;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Config[] configs;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int mRuningNodeIndex;

	[Token(Token = "0x1700019D")]
	public string value
	{
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x7C85A8", Offset = "0x7C85A8", VA = "0x7C85A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x7C85CC", Offset = "0x7C85CC", VA = "0x7C85CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700019E")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x7C85FC", Offset = "0x7C85FC", VA = "0x7C85FC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x7C85F0", Offset = "0x7C85F0", VA = "0x7C85F0", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x7C8604", Offset = "0x7C8604", VA = "0x7C8604", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x7C8700", Offset = "0x7C8700", VA = "0x7C8700")]
	public StringSwitchNode()
	{
	}
}
[Token(Token = "0x20001AF")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601D7C", Offset = "0x601D7C")]
public class IdleNode : BehaviorTreeNode
{
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x8B089C", Offset = "0x8B089C", VA = "0x8B089C")]
	public IdleNode()
	{
	}
}
[Token(Token = "0x20001B0")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601DB8", Offset = "0x601DB8")]
public class IfElseNode : BehaviorTreeNode
{
	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int mExcIndex;

	[Token(Token = "0x1700019F")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x8B08A4", Offset = "0x8B08A4", VA = "0x8B08A4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x8B08AC", Offset = "0x8B08AC", VA = "0x8B08AC", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x8B08B4", Offset = "0x8B08B4", VA = "0x8B08B4", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x8B098C", Offset = "0x8B098C", VA = "0x8B098C")]
	public IfElseNode()
	{
	}
}
[Token(Token = "0x20001B1")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601DF4", Offset = "0x601DF4")]
public class IfParallelNode : BehaviorTreeNode
{
	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private BehaviorTreeNode mRunningNode;

	[Token(Token = "0x170001A0")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x8B0994", Offset = "0x8B0994", VA = "0x8B0994", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x8B099C", Offset = "0x8B099C", VA = "0x8B099C", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x8B0C4C", Offset = "0x8B0C4C", VA = "0x8B0C4C", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x8B0E74", Offset = "0x8B0E74", VA = "0x8B0E74")]
	public IfParallelNode()
	{
	}
}
[Token(Token = "0x20001B2")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601E40", Offset = "0x601E40")]
public class GetKeyNode : BehaviorTreeNode
{
	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public KeyCode keyCode;

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x81E694", Offset = "0x81E694", VA = "0x81E694", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x81E6D4", Offset = "0x81E6D4", VA = "0x81E6D4")]
	public GetKeyNode()
	{
	}
}
[Token(Token = "0x20001B3")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601E8C", Offset = "0x601E8C")]
public class InverstNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A1")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x8B3F8C", Offset = "0x8B3F8C", VA = "0x8B3F8C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x8B3F94", Offset = "0x8B3F94", VA = "0x8B3F94", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x8B4088", Offset = "0x8B4088", VA = "0x8B4088")]
	public InverstNode()
	{
	}
}
[Token(Token = "0x20001B4")]
public class Invoke : BehaviorTreeNode
{
	[Serializable]
	[Token(Token = "0x20001B5")]
	private class Action : UnityEvent
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x12D907C", Offset = "0x12D907C", VA = "0x12D907C")]
		public Action()
		{
		}
	}

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Action _action;

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x8B4090", Offset = "0x8B4090", VA = "0x8B4090", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x8B40B4", Offset = "0x8B40B4", VA = "0x8B40B4")]
	public Invoke()
	{
	}
}
[Token(Token = "0x20001B6")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601EC8", Offset = "0x601EC8")]
public class NoRunningNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A2")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x8C28CC", Offset = "0x8C28CC", VA = "0x8C28CC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x8C28D4", Offset = "0x8C28D4", VA = "0x8C28D4", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x8C2900", Offset = "0x8C2900", VA = "0x8C2900", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x8C296C", Offset = "0x8C296C", VA = "0x8C296C")]
	public NoRunningNode()
	{
	}
}
[Token(Token = "0x20001B7")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601F04", Offset = "0x601F04")]
public class OrNoBlockNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A3")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x12BF79C", Offset = "0x12BF79C", VA = "0x12BF79C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x12BF7A4", Offset = "0x12BF7A4", VA = "0x12BF7A4", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x12BF9F4", Offset = "0x12BF9F4", VA = "0x12BF9F4", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x12BFCFC", Offset = "0x12BFCFC", VA = "0x12BFCFC")]
	public OrNoBlockNode()
	{
	}
}
[Token(Token = "0x20001B8")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601F50", Offset = "0x601F50")]
public class ParallelNoBlockNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A4")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x12C911C", Offset = "0x12C911C", VA = "0x12C911C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x12C9124", Offset = "0x12C9124", VA = "0x12C9124", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x12C9374", Offset = "0x12C9374", VA = "0x12C9374", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x12C967C", Offset = "0x12C967C", VA = "0x12C967C")]
	public ParallelNoBlockNode()
	{
	}
}
[Token(Token = "0x20001B9")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601F9C", Offset = "0x601F9C")]
public class ParallelNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A5")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x12C9684", Offset = "0x12C9684", VA = "0x12C9684", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x12C968C", Offset = "0x12C968C", VA = "0x12C968C", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x12C99A4", Offset = "0x12C99A4", VA = "0x12C99A4")]
	public ParallelNode()
	{
	}
}
[Token(Token = "0x20001BA")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x601FE8", Offset = "0x601FE8")]
public class SequenceNode : BehaviorTreeNode
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int mExcIndex;

	[Token(Token = "0x170001A6")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x12D40C4", Offset = "0x12D40C4", VA = "0x12D40C4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x12D40CC", Offset = "0x12D40CC", VA = "0x12D40CC", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x12D40D4", Offset = "0x12D40D4", VA = "0x12D40D4", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x12D423C", Offset = "0x12D423C", VA = "0x12D423C")]
	public SequenceNode()
	{
	}
}
[Token(Token = "0x20001BB")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x602034", Offset = "0x602034")]
public class SequenceOneFrameNode : BehaviorTreeNode
{
	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int mExcIndex;

	[Token(Token = "0x170001A7")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x12D424C", Offset = "0x12D424C", VA = "0x12D424C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x12D4254", Offset = "0x12D4254", VA = "0x12D4254", Slot = "10")]
	public override void OnResetSelf()
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x12D425C", Offset = "0x12D425C", VA = "0x12D425C", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x12D43A0", Offset = "0x12D43A0", VA = "0x12D43A0")]
	public SequenceOneFrameNode()
	{
	}
}
[Token(Token = "0x20001BC")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x602080", Offset = "0x602080")]
public class StartTreeBehaviorNode : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorTree _BehaviorTree;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _WaitEnd;

	[Token(Token = "0x170001A8")]
	public string information
	{
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x7C7400", Offset = "0x7C7400", VA = "0x7C7400", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x7C74C0", Offset = "0x7C74C0", VA = "0x7C74C0", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x7C7524", Offset = "0x7C7524", VA = "0x7C7524")]
	public StartTreeBehaviorNode()
	{
	}
}
[Token(Token = "0x20001BD")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x6020BC", Offset = "0x6020BC")]
public class SuccessNode : BehaviorTreeNode
{
	[Token(Token = "0x170001A9")]
	public override int maxChildCount
	{
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x7C8894", Offset = "0x7C8894", VA = "0x7C8894", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x7C889C", Offset = "0x7C889C", VA = "0x7C889C", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x7C88C8", Offset = "0x7C88C8", VA = "0x7C88C8", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0x7C893C", Offset = "0x7C893C", VA = "0x7C893C")]
	public SuccessNode()
	{
	}
}
[Token(Token = "0x20001BE")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x6020F8", Offset = "0x6020F8")]
public class WaitNode : BehaviorTreeNode
{
	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	[AttributeAttribute(Name = "TargetValueType", RVA = "0x605270", Offset = "0x605270")]
	private float time;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgress;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BehaviorVariableFloat _SetTime;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float mStartTime;

	[Token(Token = "0x6000903")]
	[Address(RVA = "0x7D5C04", Offset = "0x7D5C04", VA = "0x7D5C04", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x7D5D4C", Offset = "0x7D5D4C", VA = "0x7D5D4C")]
	public WaitNode()
	{
	}
}
[Token(Token = "0x20001BF")]
[AttributeAttribute(Name = "TreeNode", RVA = "0x602144", Offset = "0x602144")]
public class WaitSuccessNode : BehaviorTreeNode
{
	[Token(Token = "0x170001AA")]
	public override int maxChildCount
	{
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x7D654C", Offset = "0x7D654C", VA = "0x7D654C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0x7D6554", Offset = "0x7D6554", VA = "0x7D6554", Slot = "9")]
	public override void OnResetChildren()
	{
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0x7D6580", Offset = "0x7D6580", VA = "0x7D6580", Slot = "11")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000908")]
	[Address(RVA = "0x7D65FC", Offset = "0x7D65FC", VA = "0x7D65FC")]
	public WaitSuccessNode()
	{
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20001C0")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170001AB")]
		public bool Highlight
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x7C2BD0", Offset = "0x7C2BD0", VA = "0x7C2BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x7C2BD8", Offset = "0x7C2BD8", VA = "0x7C2BD8")]
			set
			{
			}
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x7C2BE4", Offset = "0x7C2BE4", VA = "0x7C2BE4")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x7C2DA4", Offset = "0x7C2DA4", VA = "0x7C2DA4", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x7C2DCC", Offset = "0x7C2DCC", VA = "0x7C2DCC", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x7C2DF4", Offset = "0x7C2DF4", VA = "0x7C2DF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x7C2CA4", Offset = "0x7C2CA4", VA = "0x7C2CA4")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x7C3088", Offset = "0x7C3088", VA = "0x7C3088")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170001AC")]
		public bool InRange
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x80FB5C", Offset = "0x80FB5C", VA = "0x80FB5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x80FB64", Offset = "0x80FB64", VA = "0x80FB64")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public bool Targeted
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x80FCE8", Offset = "0x80FCE8", VA = "0x80FCE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x80FCF0", Offset = "0x80FCF0", VA = "0x80FCF0")]
			set
			{
			}
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x80FCFC", Offset = "0x80FCFC", VA = "0x80FCFC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x80FB70", Offset = "0x80FB70", VA = "0x80FB70")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x80FED0", Offset = "0x80FED0", VA = "0x80FED0")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x602190", Offset = "0x602190")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170001AE")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x80FED8", Offset = "0x80FED8", VA = "0x80FED8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x80FEE0", Offset = "0x80FEE0", VA = "0x80FEE0")]
			set
			{
			}
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x80FEFC", Offset = "0x80FEFC", VA = "0x80FEFC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x81012C", Offset = "0x81012C", VA = "0x81012C", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x8109F0", Offset = "0x8109F0", VA = "0x8109F0", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x810E68", Offset = "0x810E68", VA = "0x810E68", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x81112C", Offset = "0x81112C", VA = "0x81112C")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x810380", Offset = "0x810380", VA = "0x810380")]
		protected bool FindTarget([Out] DistanceGrabbable dgOut, [Out] Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x811230", Offset = "0x811230", VA = "0x811230")]
		protected bool FindTargetWithSpherecast([Out] DistanceGrabbable dgOut, [Out] Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x811614", Offset = "0x811614", VA = "0x811614", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x81162C", Offset = "0x81162C", VA = "0x81162C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x811634", Offset = "0x811634", VA = "0x811634")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20001C4")]
		public enum CrosshairState
		{
			[Token(Token = "0x40006C6")]
			Disabled,
			[Token(Token = "0x40006C7")]
			Enabled,
			[Token(Token = "0x40006C8")]
			Targeted
		}

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x81E850", Offset = "0x81E850", VA = "0x81E850")]
		private void Start()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x80FE34", Offset = "0x80FE34", VA = "0x80FE34")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x81E8BC", Offset = "0x81E8BC", VA = "0x81E8BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x81E904", Offset = "0x81E904", VA = "0x81E904")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x81E6DC", Offset = "0x81E6DC", VA = "0x81E6DC")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x81E794", Offset = "0x81E794", VA = "0x81E794")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x81E848", Offset = "0x81E848", VA = "0x81E848")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x12C99AC", Offset = "0x12C99AC", VA = "0x12C99AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x12C9AA0", Offset = "0x12C9AA0", VA = "0x12C9AA0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x12C9AAC", Offset = "0x12C9AAC", VA = "0x12C9AAC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x12C9AB8", Offset = "0x12C9AB8", VA = "0x12C9AB8")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x7B8AE8", Offset = "0x7B8AE8", VA = "0x7B8AE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x7B8B3C", Offset = "0x7B8B3C", VA = "0x7B8B3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x7B8E98", Offset = "0x7B8E98", VA = "0x7B8E98")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x7B8F9C", Offset = "0x7B8F9C", VA = "0x7B8F9C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x7B8B40", Offset = "0x7B8B40", VA = "0x7B8B40")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x7B90A0", Offset = "0x7B90A0", VA = "0x7B90A0")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20001C9")]
		public enum ContactTest
		{
			[Token(Token = "0x40006DE")]
			PerpenTest,
			[Token(Token = "0x40006DF")]
			BackwardsPress
		}

		[Token(Token = "0x40006D0")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40006D1")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private InteractableState _currentButtonState;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170001AF")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x7BD264", Offset = "0x7BD264", VA = "0x7BD264", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B0")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x7BD26C", Offset = "0x7BD26C", VA = "0x7BD26C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x7BD278", Offset = "0x7BD278", VA = "0x7BD278", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x7BD364", Offset = "0x7BD364", VA = "0x7BD364")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x7BD554", Offset = "0x7BD554", VA = "0x7BD554", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x7BDAE0", Offset = "0x7BDAE0", VA = "0x7BDAE0")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x7BD9F8", Offset = "0x7BD9F8", VA = "0x7BD9F8")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x7BDB90", Offset = "0x7BDB90", VA = "0x7BDB90")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x7BDC14", Offset = "0x7BDC14", VA = "0x7BDC14")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x7BDCA0", Offset = "0x7BDCA0", VA = "0x7BDCA0")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605438", Offset = "0x605438")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605448", Offset = "0x605448")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170001B1")]
		public Collider Collider
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x7BE5DC", Offset = "0x7BE5DC", VA = "0x7BE5DC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607780", Offset = "0x607780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x7BE5E4", Offset = "0x7BE5E4", VA = "0x7BE5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607790", Offset = "0x607790")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x7BE5EC", Offset = "0x7BE5EC", VA = "0x7BE5EC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6077A0", Offset = "0x6077A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x7BE5F4", Offset = "0x7BE5F4", VA = "0x7BE5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6077B0", Offset = "0x6077B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x7BE5FC", Offset = "0x7BE5FC", VA = "0x7BE5FC", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x7BE650", Offset = "0x7BE650", VA = "0x7BE650")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x7BE6DC", Offset = "0x7BE6DC", VA = "0x7BE6DC")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public interface ColliderZone
	{
		[Token(Token = "0x170001B4")]
		Collider Collider
		{
			[Token(Token = "0x6000947")]
			get;
		}

		[Token(Token = "0x170001B5")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000948")]
			get;
		}

		[Token(Token = "0x170001B6")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000949")]
			get;
		}
	}
	[Token(Token = "0x20001CC")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x7BD4B4", Offset = "0x7BD4B4", VA = "0x7BD4B4")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20001CD")]
	public enum InteractionType
	{
		[Token(Token = "0x40006E8")]
		Enter,
		[Token(Token = "0x40006E9")]
		Stay,
		[Token(Token = "0x40006EA")]
		Exit
	}
	[Token(Token = "0x20001CE")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20001CF")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x40006FC")]
			Mesh,
			[Token(Token = "0x40006FD")]
			Skeleton,
			[Token(Token = "0x40006FE")]
			Both
		}

		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6021F8", Offset = "0x6021F8")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170001C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x12D8AF0", Offset = "0x12D8AF0", VA = "0x12D8AF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x12D8B38", Offset = "0x12D8B38", VA = "0x12D8B38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x12D8890", Offset = "0x12D8890", VA = "0x12D8890")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x12D88BC", Offset = "0x12D88BC", VA = "0x12D88BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x12D88C0", Offset = "0x12D88C0", VA = "0x12D88C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x12D8AF8", Offset = "0x12D8AF8", VA = "0x12D8AF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EB")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605478", Offset = "0x605478")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170001B7")]
		public OVRHand RightHand
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x816FDC", Offset = "0x816FDC", VA = "0x816FDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x821878", Offset = "0x821878", VA = "0x821878")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x8218DC", Offset = "0x8218DC", VA = "0x8218DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x821914", Offset = "0x821914", VA = "0x821914")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x821978", Offset = "0x821978", VA = "0x821978")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x8219B0", Offset = "0x8219B0", VA = "0x8219B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x821A14", Offset = "0x821A14", VA = "0x821A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x821A4C", Offset = "0x821A4C", VA = "0x821A4C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x821AB0", Offset = "0x821AB0", VA = "0x821AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x821AE8", Offset = "0x821AE8", VA = "0x821AE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x816FA8", Offset = "0x816FA8", VA = "0x816FA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x821B4C", Offset = "0x821B4C", VA = "0x821B4C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BD")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x821BAC", Offset = "0x821BAC", VA = "0x821BAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x821BE0", Offset = "0x821BE0", VA = "0x821BE0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BE")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x821C40", Offset = "0x821C40", VA = "0x821C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x821C74", Offset = "0x821C74", VA = "0x821C74")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x821CD4", Offset = "0x821CD4", VA = "0x821CD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x821D08", Offset = "0x821D08", VA = "0x821D08")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x821D68", Offset = "0x821D68", VA = "0x821D68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x821D9C", Offset = "0x821D9C", VA = "0x821D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x821DFC", Offset = "0x821DFC", VA = "0x821DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6077C0", Offset = "0x6077C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x821E48", Offset = "0x821E48", VA = "0x821E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6077D0", Offset = "0x6077D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x821EA0", Offset = "0x821EA0", VA = "0x821EA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x822250", Offset = "0x822250", VA = "0x822250")]
		private void Update()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x8221DC", Offset = "0x8221DC", VA = "0x8221DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6077E0", Offset = "0x6077E0")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x8222D8", Offset = "0x8222D8", VA = "0x8222D8")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x8223BC", Offset = "0x8223BC", VA = "0x8223BC")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x82259C", Offset = "0x82259C", VA = "0x82259C")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x816E1C", Offset = "0x816E1C", VA = "0x816E1C")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x8227C0", Offset = "0x8227C0", VA = "0x8227C0")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001D2")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x12D8B40", Offset = "0x12D8B40", VA = "0x12D8B40")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170001C4")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x8B1C58", Offset = "0x8B1C58", VA = "0x8B1C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x8B1C60", Offset = "0x8B1C60", VA = "0x8B1C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x8B1C68", Offset = "0x8B1C68", VA = "0x8B1C68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x8B1C70", Offset = "0x8B1C70", VA = "0x8B1C70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x8B1C78", Offset = "0x8B1C78", VA = "0x8B1C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607898", Offset = "0x607898")]
			add
			{
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x8B1D18", Offset = "0x8B1D18", VA = "0x8B1D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6078A8", Offset = "0x6078A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x8B1E28", Offset = "0x8B1E28", VA = "0x8B1E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6078B8", Offset = "0x6078B8")]
			add
			{
			}
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x8B1EC8", Offset = "0x8B1EC8", VA = "0x8B1EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6078C8", Offset = "0x6078C8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x8B1FD8", Offset = "0x8B1FD8", VA = "0x8B1FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6078D8", Offset = "0x6078D8")]
			add
			{
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x8B2078", Offset = "0x8B2078", VA = "0x8B2078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6078E8", Offset = "0x6078E8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x8B1DB8", Offset = "0x8B1DB8", VA = "0x8B1DB8", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x8B1F68", Offset = "0x8B1F68", VA = "0x8B1F68", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x8B2118", Offset = "0x8B2118", VA = "0x8B2118", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600097C")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x8B2188", Offset = "0x8B2188", VA = "0x8B2188", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x8B22BC", Offset = "0x8B22BC", VA = "0x8B22BC", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x8B23F0", Offset = "0x8B23F0", VA = "0x8B23F0")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x400070A")]
		None,
		[Token(Token = "0x400070B")]
		Proximity,
		[Token(Token = "0x400070C")]
		Contact,
		[Token(Token = "0x400070D")]
		Action
	}
	[Token(Token = "0x20001D4")]
	public enum InteractableState
	{
		[Token(Token = "0x400070F")]
		Default,
		[Token(Token = "0x4000710")]
		ProximityState,
		[Token(Token = "0x4000711")]
		ContactState,
		[Token(Token = "0x4000712")]
		ActionState
	}
	[Token(Token = "0x20001D5")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x8B2538", Offset = "0x8B2538", VA = "0x8B2538")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170001C8")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x8B243C", Offset = "0x8B243C", VA = "0x8B243C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x8B21F0", Offset = "0x8B21F0", VA = "0x8B21F0")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x8B2324", Offset = "0x8B2324", VA = "0x8B2324")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x8B24A0", Offset = "0x8B24A0", VA = "0x8B24A0")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602208", Offset = "0x602208")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170001C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600098F")]
				[Address(RVA = "0x12D902C", Offset = "0x12D902C", VA = "0x12D902C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000991")]
				[Address(RVA = "0x12D9074", Offset = "0x12D9074", VA = "0x12D9074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x12D8B94", Offset = "0x12D8B94", VA = "0x12D8B94")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x12D8BC0", Offset = "0x12D8BC0", VA = "0x12D8BC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x12D8C38", Offset = "0x12D8C38", VA = "0x12D8C38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x12D8BDC", Offset = "0x12D8BDC", VA = "0x12D8BDC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x12D9034", Offset = "0x12D9034", VA = "0x12D9034", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x8B3224", Offset = "0x8B3224", VA = "0x8B3224")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x8B32A0", Offset = "0x8B32A0", VA = "0x8B32A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6078F8", Offset = "0x6078F8")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x8B3330", Offset = "0x8B3330", VA = "0x8B3330")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x8B3418", Offset = "0x8B3418", VA = "0x8B3418")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170001CB")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x8B3420", Offset = "0x8B3420", VA = "0x8B3420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x8B359C", Offset = "0x8B359C", VA = "0x8B359C")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x8B3644", Offset = "0x8B3644", VA = "0x8B3644")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x8B36EC", Offset = "0x8B36EC", VA = "0x8B36EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x8B39B4", Offset = "0x8B39B4", VA = "0x8B39B4")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x8B39FC", Offset = "0x8B39FC", VA = "0x8B39FC")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x8B3C88", Offset = "0x8B3C88", VA = "0x8B3C88")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x8B3DCC", Offset = "0x8B3DCC", VA = "0x8B3DCC")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602218", Offset = "0x602218")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170001D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0x12D7A60", Offset = "0x12D7A60", VA = "0x12D7A60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AD")]
				[Address(RVA = "0x12D7AA8", Offset = "0x12D7AA8", VA = "0x12D7AA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x12D764C", Offset = "0x12D764C", VA = "0x12D764C")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x12D7678", Offset = "0x12D7678", VA = "0x12D7678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x12D767C", Offset = "0x12D767C", VA = "0x12D767C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x12D7A68", Offset = "0x12D7A68", VA = "0x12D7A68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072B")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170001CC")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x8169F0", Offset = "0x8169F0", VA = "0x8169F0", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170001CD")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x8169F8", Offset = "0x8169F8", VA = "0x8169F8", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170001CE")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x816A00", Offset = "0x816A00", VA = "0x816A00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CF")]
		public override bool EnableState
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x816A08", Offset = "0x816A08", VA = "0x816A08", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x816A34", Offset = "0x816A34", VA = "0x816A34", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x816A70", Offset = "0x816A70", VA = "0x816A70", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x816B10", Offset = "0x816B10", VA = "0x816B10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6079B0", Offset = "0x6079B0")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x816B84", Offset = "0x816B84", VA = "0x816B84")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x817014", Offset = "0x817014", VA = "0x817014")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x8171A0", Offset = "0x8171A0", VA = "0x8171A0")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x817294", Offset = "0x817294", VA = "0x817294", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x81759C", Offset = "0x81759C", VA = "0x81759C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x8175A0", Offset = "0x8175A0", VA = "0x8175A0", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x8175A4", Offset = "0x8175A4", VA = "0x8175A4")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605508", Offset = "0x605508")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605518", Offset = "0x605518")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605528", Offset = "0x605528")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170001D2")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x8175BC", Offset = "0x8175BC", VA = "0x8175BC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607A68", Offset = "0x607A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x8175C4", Offset = "0x8175C4", VA = "0x8175C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607A78", Offset = "0x607A78")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public bool EnableState
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x8175CC", Offset = "0x8175CC", VA = "0x8175CC", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x8175EC", Offset = "0x8175EC", VA = "0x8175EC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x817610", Offset = "0x817610", VA = "0x817610", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607A88", Offset = "0x607A88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x817618", Offset = "0x817618", VA = "0x817618", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607A98", Offset = "0x607A98")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public float SphereRadius
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x817624", Offset = "0x817624", VA = "0x817624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AA8", Offset = "0x607AA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x81762C", Offset = "0x81762C", VA = "0x81762C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AB8", Offset = "0x607AB8")]
			private set
			{
			}
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x817634", Offset = "0x817634", VA = "0x817634")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x81767C", Offset = "0x81767C", VA = "0x81767C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x817680", Offset = "0x817680", VA = "0x817680")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x400073E")]
		None = 0,
		[Token(Token = "0x400073F")]
		Ray = 1,
		[Token(Token = "0x4000740")]
		Poke = 4,
		[Token(Token = "0x4000741")]
		All = -1
	}
	[Token(Token = "0x20001DE")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000743")]
		Inactive,
		[Token(Token = "0x4000744")]
		PrimaryInputDown,
		[Token(Token = "0x4000745")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000746")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001DF")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x8B23F8", Offset = "0x8B23F8", VA = "0x8B23F8")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001E0")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605538", Offset = "0x605538")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605548", Offset = "0x605548")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x605558", Offset = "0x605558")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170001D6")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x8B25D8", Offset = "0x8B25D8", VA = "0x8B25D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D7")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x8B25E0", Offset = "0x8B25E0", VA = "0x8B25E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AC8", Offset = "0x607AC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x8B25E8", Offset = "0x8B25E8", VA = "0x8B25E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AD8", Offset = "0x607AD8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009BD")]
			get;
		}

		[Token(Token = "0x170001D9")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60009BE")]
			get;
		}

		[Token(Token = "0x170001DA")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60009BF")]
			get;
		}

		[Token(Token = "0x170001DB")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x8B25F4", Offset = "0x8B25F4", VA = "0x8B25F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AE8", Offset = "0x607AE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x8B2600", Offset = "0x8B2600", VA = "0x8B2600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AF8", Offset = "0x607AF8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x8B260C", Offset = "0x8B260C", VA = "0x8B260C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B08", Offset = "0x607B08")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x8B2618", Offset = "0x8B2618", VA = "0x8B2618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B18", Offset = "0x607B18")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60009C8")]
			get;
			[Token(Token = "0x60009C9")]
			set;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x8B2624", Offset = "0x8B2624", VA = "0x8B2624")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60009C6")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60009C7")]
		public abstract void DeFocus();

		[Token(Token = "0x60009CA")]
		public abstract void Initialize();

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x8B262C", Offset = "0x8B262C", VA = "0x8B262C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x8B2680", Offset = "0x8B2680", VA = "0x8B2680")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x8B26D4", Offset = "0x8B26D4", VA = "0x8B26D4", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x8B2960", Offset = "0x8B2960", VA = "0x8B2960", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x8B30CC", Offset = "0x8B30CC", VA = "0x8B30CC")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170001DE")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x60009D0")]
			get;
		}

		[Token(Token = "0x170001DF")]
		bool EnableState
		{
			[Token(Token = "0x60009D2")]
			get;
			[Token(Token = "0x60009D3")]
			set;
		}

		[Token(Token = "0x170001E0")]
		bool ToolActivateState
		{
			[Token(Token = "0x60009D4")]
			get;
			[Token(Token = "0x60009D5")]
			set;
		}

		[Token(Token = "0x60009D1")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20001E2")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001E3")]
		private enum PinchState
		{
			[Token(Token = "0x4000757")]
			None,
			[Token(Token = "0x4000758")]
			PinchDown,
			[Token(Token = "0x4000759")]
			PinchStay,
			[Token(Token = "0x400075A")]
			PinchUp
		}

		[Token(Token = "0x4000753")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170001E1")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x12CCBF8", Offset = "0x12CCBF8", VA = "0x12CCBF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E2")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x12CCC80", Offset = "0x12CCC80", VA = "0x12CCC80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E3")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x12CCD08", Offset = "0x12CCD08", VA = "0x12CCD08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x12CCD90", Offset = "0x12CCD90", VA = "0x12CCD90")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x12CCDBC", Offset = "0x12CCDBC", VA = "0x12CCDBC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001E4")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x400075B")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x400075C")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x400075D")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x400075E")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x400075F")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x605578", Offset = "0x605578")]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170001E4")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x12CF0E8", Offset = "0x12CF0E8", VA = "0x12CF0E8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170001E5")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x12CF0F0", Offset = "0x12CF0F0", VA = "0x12CF0F0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170001E6")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x12CF158", Offset = "0x12CF158", VA = "0x12CF158", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E7")]
		public override bool EnableState
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x12CF160", Offset = "0x12CF160", VA = "0x12CF160", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x12CF1A8", Offset = "0x12CF1A8", VA = "0x12CF1A8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x12CF220", Offset = "0x12CF220", VA = "0x12CF220", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x12CF280", Offset = "0x12CF280", VA = "0x12CF280")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x12CF330", Offset = "0x12CF330", VA = "0x12CF330")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x12CF5EC", Offset = "0x12CF5EC", VA = "0x12CF5EC")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x12CF674", Offset = "0x12CF674", VA = "0x12CF674", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x12CFA0C", Offset = "0x12CFA0C", VA = "0x12CFA0C")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x12CFB1C", Offset = "0x12CFB1C", VA = "0x12CFB1C")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x12CFC40", Offset = "0x12CFC40", VA = "0x12CFC40")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x12CFF38", Offset = "0x12CFF38", VA = "0x12CFF38")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x12D02C0", Offset = "0x12D02C0", VA = "0x12D02C0", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x12D0390", Offset = "0x12D0390", VA = "0x12D0390", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x12D03C4", Offset = "0x12D03C4", VA = "0x12D03C4")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x400076B")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x400076C")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6055EC", Offset = "0x6055EC")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170001E8")]
		public bool EnableState
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x12CF188", Offset = "0x12CF188", VA = "0x12CF188", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x12CF1C8", Offset = "0x12CF1C8", VA = "0x12CF1C8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x12D04A4", Offset = "0x12D04A4", VA = "0x12D04A4", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x12CF5AC", Offset = "0x12CF5AC", VA = "0x12CF5AC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x12D06E8", Offset = "0x12D06E8", VA = "0x12D06E8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B28", Offset = "0x607B28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x12D06F0", Offset = "0x12D06F0", VA = "0x12D06F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B38", Offset = "0x607B38")]
			set
			{
			}
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x12D04AC", Offset = "0x12D04AC", VA = "0x12D04AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x12D02F4", Offset = "0x12D02F4", VA = "0x12D02F4", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x12D06F8", Offset = "0x12D06F8", VA = "0x12D06F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x12D096C", Offset = "0x12D096C", VA = "0x12D096C")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x12D0A5C", Offset = "0x12D0A5C", VA = "0x12D0A5C")]
		public RayToolView()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001E6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x602238", Offset = "0x602238")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6022A0", Offset = "0x6022A0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x12D8840", Offset = "0x12D8840", VA = "0x12D8840")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x12D8848", Offset = "0x12D8848", VA = "0x12D8848")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000775")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000776")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000777")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000778")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000779")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x400077A")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x400077B")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x400077C")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x400077D")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x400077E")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x400077F")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x820088", Offset = "0x820088", VA = "0x820088")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x8200E4", Offset = "0x8200E4", VA = "0x8200E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x820568", Offset = "0x820568", VA = "0x820568")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x82065C", Offset = "0x82065C", VA = "0x82065C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x8207C8", Offset = "0x8207C8", VA = "0x8207C8")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x820AD8", Offset = "0x820AD8", VA = "0x820AD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x820BD0", Offset = "0x820BD0", VA = "0x820BD0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x820D30", Offset = "0x820D30", VA = "0x820D30")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x820868", Offset = "0x820868", VA = "0x820868")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x8208BC", Offset = "0x8208BC", VA = "0x8208BC")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x82040C", Offset = "0x82040C", VA = "0x82040C")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x820E6C", Offset = "0x820E6C", VA = "0x820E6C")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000794")]
		Default,
		[Token(Token = "0x4000795")]
		Generic,
		[Token(Token = "0x4000796")]
		PingPongBall,
		[Token(Token = "0x4000797")]
		Controller
	}
	[Token(Token = "0x20001E9")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170001EB")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x8216B8", Offset = "0x8216B8", VA = "0x8216B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001EC")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x8216C0", Offset = "0x8216C0", VA = "0x8216C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001ED")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x8216C8", Offset = "0x8216C8", VA = "0x8216C8")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x8216D0", Offset = "0x8216D0", VA = "0x8216D0")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x7CBC90", Offset = "0x7CBC90", VA = "0x7CBC90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x7CBF80", Offset = "0x7CBF80", VA = "0x7CBF80")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x7CBFDC", Offset = "0x7CBFDC", VA = "0x7CBFDC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x7CC020", Offset = "0x7CC020", VA = "0x7CC020")]
		public TouchController()
		{
		}
	}
}
namespace System.IO.Compression
{
	[Token(Token = "0x20001EB")]
	public class ZipFile
	{
		[Token(Token = "0x400079E")]
		private const int Version = 1;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stream mStream;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int mVersion;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int mEntriesCount;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int mEntryHeaderPosition;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int mEntryHeaderSize;

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x7D6C70", Offset = "0x7D6C70", VA = "0x7D6C70")]
		public ZipFile(string path)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x7D6DC8", Offset = "0x7D6DC8", VA = "0x7D6DC8")]
		public ZipEntry[] getEntries()
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x7D6D1C", Offset = "0x7D6D1C", VA = "0x7D6D1C")]
		private int ReadInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x7D6F54", Offset = "0x7D6F54", VA = "0x7D6F54")]
		private void Write(int i)
		{
		}
	}
	[Token(Token = "0x20001EC")]
	public class ZipEntry
	{
		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60567C", Offset = "0x60567C")]
		private string <name>k__BackingField;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int position;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int size;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int compressiedSize;

		[Token(Token = "0x170001EE")]
		public string name
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x7D6C58", Offset = "0x7D6C58", VA = "0x7D6C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B48", Offset = "0x607B48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x7D6C60", Offset = "0x7D6C60", VA = "0x7D6C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B58", Offset = "0x607B58")]
			set
			{
			}
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x7D6C68", Offset = "0x7D6C68", VA = "0x7D6C68")]
		public ZipEntry()
		{
		}
	}
}
namespace Game.UI
{
	[Token(Token = "0x20001ED")]
	public class GalleryPanel : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001EE")]
		public class PaperConent
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object image;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string title;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x12D7B58", Offset = "0x12D7B58", VA = "0x12D7B58")]
			public PaperConent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001EF")]
		public class GalleryPanelEvent : UnityEvent<GalleryPanel>
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x12D7AB0", Offset = "0x12D7AB0", VA = "0x12D7AB0")]
			public GalleryPanelEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F0")]
		public class GalleryPanelEvent2 : UnityEvent<GalleryPanel, int>
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x12D7B04", Offset = "0x12D7B04", VA = "0x12D7B04")]
			public GalleryPanelEvent2()
			{
			}
		}

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip _AudioPaging;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _AudioClicked;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AbsGalleryPaperTemplate startTemplate;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AbsGalleryPaperTemplate endTemplate;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AbsGalleryPaperTemplate[] templates;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text title;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float smooth;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<PaperConent> paperContents;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int selectedIndex;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int selectionOffset;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GalleryPanelEvent selectionChanged;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GalleryPanelEvent2 pagerClicked;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AbsGalleryPaperTemplate[] mPapers;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int mLastContentLength;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int mLastSelected;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Stack<AbsGalleryPaperTemplate> mGarbages;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<AbsGalleryPaperTemplate> mFadeouts;

		[Token(Token = "0x170001EF")]
		private int startIndex
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x817688", Offset = "0x817688", VA = "0x817688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x817694", Offset = "0x817694", VA = "0x817694")]
			set
			{
			}
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x8176A4", Offset = "0x8176A4", VA = "0x8176A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x8178AC", Offset = "0x8178AC", VA = "0x8178AC")]
		private AbsGalleryPaperTemplate CreatePaper(AbsGalleryPaperTemplate tempate)
		{
			return null;
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x817A40", Offset = "0x817A40", VA = "0x817A40")]
		private AbsGalleryPaperTemplate NewPaper(AbsGalleryPaperTemplate tempate)
		{
			return null;
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x817C2C", Offset = "0x817C2C", VA = "0x817C2C")]
		private void OnPaperClicked(AbsGalleryPaperTemplate sender)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x817E40", Offset = "0x817E40", VA = "0x817E40", Slot = "4")]
		protected virtual void OnSelectionChanged()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x817F9C", Offset = "0x817F9C", VA = "0x817F9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x818D38", Offset = "0x818D38", VA = "0x818D38")]
		public GalleryPanel()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6022B0", Offset = "0x6022B0")]
	public class GalleryPaperTemplate : AbsGalleryPaperTemplate
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage image;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup mCanvasGroup;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform mRectTransform;

		[Token(Token = "0x14000017")]
		public override event OnPagerClicked Clicked
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x818D50", Offset = "0x818D50", VA = "0x818D50", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B68", Offset = "0x607B68")]
			add
			{
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x818DF0", Offset = "0x818DF0", VA = "0x818DF0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B78", Offset = "0x607B78")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x818E90", Offset = "0x818E90", VA = "0x818E90", Slot = "8")]
		public override void OnSetContentIndex(int index, GalleryPanel panel)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x818F70", Offset = "0x818F70", VA = "0x818F70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x81908C", Offset = "0x81908C", VA = "0x81908C")]
		private void OnClicked()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x8190A4", Offset = "0x8190A4", VA = "0x8190A4", Slot = "9")]
		public override bool UpdatePaper(GalleryPanel panel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x81949C", Offset = "0x81949C", VA = "0x81949C", Slot = "10")]
		public override void CopyStateFrom(AbsGalleryPaperTemplate from)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x819588", Offset = "0x819588", VA = "0x819588")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x819590", Offset = "0x819590", VA = "0x819590")]
		public GalleryPaperTemplate()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	public abstract class AbsGalleryPaperTemplate : MonoBehaviour
	{
		[Token(Token = "0x20001F3")]
		public delegate void OnPagerClicked(AbsGalleryPaperTemplate pager);

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6056BC", Offset = "0x6056BC")]
		private AbsGalleryPaperTemplate <targetState>k__BackingField;

		[Token(Token = "0x170001F0")]
		public virtual AbsGalleryPaperTemplate targetState
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x7ACAD0", Offset = "0x7ACAD0", VA = "0x7ACAD0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607BA8", Offset = "0x607BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x7ACAD8", Offset = "0x7ACAD8", VA = "0x7ACAD8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607BB8", Offset = "0x607BB8")]
			set
			{
			}
		}

		[Token(Token = "0x14000018")]
		[method: Token(Token = "0x6000A2A")]
		[method: AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607B88", Offset = "0x607B88")]
		public abstract event OnPagerClicked Clicked;

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x7ACAE0", Offset = "0x7ACAE0", VA = "0x7ACAE0", Slot = "8")]
		public virtual void OnSetContentIndex(int index, GalleryPanel panel)
		{
		}

		[Token(Token = "0x6000A2F")]
		public abstract bool UpdatePaper(GalleryPanel panel);

		[Token(Token = "0x6000A30")]
		public abstract void CopyStateFrom(AbsGalleryPaperTemplate from);

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x7ACAE4", Offset = "0x7ACAE4", VA = "0x7ACAE4", Slot = "11")]
		public virtual AbsGalleryPaperTemplate CloneGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x7ACBBC", Offset = "0x7ACBBC", VA = "0x7ACBBC")]
		protected AbsGalleryPaperTemplate()
		{
		}
	}
}
