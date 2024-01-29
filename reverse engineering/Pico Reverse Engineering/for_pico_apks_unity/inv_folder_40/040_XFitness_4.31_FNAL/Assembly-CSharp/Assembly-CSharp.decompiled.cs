using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Crosstales.DJ;
using CurvedUI;
using Il2CppDummyDll;
using NAudio.Wave;
using NeuralNetwork;
using Pico.Platform;
using Pico.Platform.Models;
using RhythmTool;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("1.0.0.0")]
[Token(Token = "0x2000002")]
public class SciFiBeamScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] beamLineRendererPrefab;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] beamStartPrefab;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] beamEndPrefab;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBeam;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject beamStart;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beamEnd;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject beam;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LineRenderer line;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float beamEndOffset;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float textureScrollSpeed;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float textureLengthScale;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Slider endOffSetSlider;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Slider scrollSpeedSlider;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text textBeamName;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x71F4C0", Offset = "0x71F4C0", VA = "0x71F4C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x71F600", Offset = "0x71F600", VA = "0x71F600")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x71FE5C", Offset = "0x71FE5C", VA = "0x71FE5C")]
	public void nextBeam()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x71FF3C", Offset = "0x71FF3C", VA = "0x71FF3C")]
	public void previousBeam()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x72001C", Offset = "0x72001C", VA = "0x72001C")]
	public void UpdateEndOffset()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x72004C", Offset = "0x72004C", VA = "0x72004C")]
	public void UpdateScrollSpeed()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x71FA38", Offset = "0x71FA38", VA = "0x71FA38")]
	private void ShootBeamInDir(Vector3 start, Vector3 dir)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x72007C", Offset = "0x72007C", VA = "0x72007C")]
	public SciFiBeamScript()
	{
	}
}
[Token(Token = "0x2000003")]
public class SciFiLightFlicker : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string waveFunction;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float startValue;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float amplitude;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float phase;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float frequency;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color originalColor;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x720098", Offset = "0x720098", VA = "0x720098")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7200FC", Offset = "0x7200FC", VA = "0x7200FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x720190", Offset = "0x720190", VA = "0x720190")]
	private float EvalWave()
	{
		return default(float);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x72035C", Offset = "0x72035C", VA = "0x72035C")]
	public SciFiLightFlicker()
	{
	}
}
[Token(Token = "0x2000004")]
public class arena_b_pillar_rotator : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float rotate_speed;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game m_Game;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7203C4", Offset = "0x7203C4", VA = "0x7203C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x72043C", Offset = "0x72043C", VA = "0x72043C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x720518", Offset = "0x720518", VA = "0x720518")]
	public arena_b_pillar_rotator()
	{
	}
}
[Token(Token = "0x2000005")]
public class pillar_rotator_a : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x720528", Offset = "0x720528", VA = "0x720528")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7205CC", Offset = "0x7205CC", VA = "0x7205CC")]
	public pillar_rotator_a()
	{
	}
}
[Token(Token = "0x2000006")]
public class ImporterExample : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	private sealed class <Import>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ImporterExample <>4__this;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x720ABC", Offset = "0x720ABC", VA = "0x720ABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x720B04", Offset = "0x720B04", VA = "0x720B04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x720838", Offset = "0x720838", VA = "0x720838")]
		[DebuggerHidden]
		public <Import>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x720868", Offset = "0x720868", VA = "0x720868", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x72086C", Offset = "0x72086C", VA = "0x72086C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x720AC4", Offset = "0x720AC4", VA = "0x720AC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Browser browser;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioImporter importer;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource audioSource;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7205DC", Offset = "0x7205DC", VA = "0x7205DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x720714", Offset = "0x720714", VA = "0x720714")]
	private void OnFileSelected(string path)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7207A8", Offset = "0x7207A8", VA = "0x7207A8")]
	private IEnumerator Import(string path)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x720860", Offset = "0x720860", VA = "0x720860")]
	public ImporterExample()
	{
	}
}
[Token(Token = "0x2000008")]
public abstract class AudioImporter : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Uri <uri>k__BackingField;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioClip <audioClip>k__BackingField;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float <progress>k__BackingField;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool <isDone>k__BackingField;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool <isInitialized>k__BackingField;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool <isError>k__BackingField;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string <error>k__BackingField;

	[Token(Token = "0x17000003")]
	public Uri uri
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x720C6C", Offset = "0x720C6C", VA = "0x720C6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x720C74", Offset = "0x720C74", VA = "0x720C74")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public virtual AudioClip audioClip
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x720C7C", Offset = "0x720C7C", VA = "0x720C7C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x720C84", Offset = "0x720C84", VA = "0x720C84", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public virtual float progress
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x720C8C", Offset = "0x720C8C", VA = "0x720C8C", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x720C94", Offset = "0x720C94", VA = "0x720C94", Slot = "7")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public virtual bool isDone
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x720C9C", Offset = "0x720C9C", VA = "0x720C9C", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x720CA4", Offset = "0x720CA4", VA = "0x720CA4", Slot = "9")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public virtual bool isInitialized
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x720CB0", Offset = "0x720CB0", VA = "0x720CB0", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x720CB8", Offset = "0x720CB8", VA = "0x720CB8", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual bool isError
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x720CC4", Offset = "0x720CC4", VA = "0x720CC4", Slot = "12")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x720CCC", Offset = "0x720CCC", VA = "0x720CCC", Slot = "13")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public virtual string error
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x720CD8", Offset = "0x720CD8", VA = "0x720CD8", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x720CE0", Offset = "0x720CE0", VA = "0x720CE0", Slot = "15")]
		protected set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<AudioClip> Loaded
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x720B0C", Offset = "0x720B0C", VA = "0x720B0C")]
		add
		{
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x720BBC", Offset = "0x720BBC", VA = "0x720BBC")]
		remove
		{
		}
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7209D0", Offset = "0x7209D0", VA = "0x7209D0")]
	public void Import(string uri)
	{
	}

	[Token(Token = "0x600002D")]
	public abstract void Abort();

	[Token(Token = "0x600002E")]
	protected abstract void Import();

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x720CE8", Offset = "0x720CE8", VA = "0x720CE8")]
	protected void OnLoaded()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x720D24", Offset = "0x720D24", VA = "0x720D24")]
	protected AudioImporter()
	{
	}
}
[Token(Token = "0x2000009")]
public class Browser : MonoBehaviour
{
	[Token(Token = "0x200000A")]
	private sealed class <refreshFiles>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Browser <>4__this;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x721FCC", Offset = "0x721FCC", VA = "0x721FCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x722014", Offset = "0x722014", VA = "0x722014", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x721770", Offset = "0x721770", VA = "0x721770")]
		[DebuggerHidden]
		public <refreshFiles>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x721F10", Offset = "0x721F10", VA = "0x721F10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x721F14", Offset = "0x721F14", VA = "0x721F14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x721FD4", Offset = "0x721FD4", VA = "0x721FD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	private sealed class <refreshDirectories>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Browser <>4__this;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x7220D8", Offset = "0x7220D8", VA = "0x7220D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x722120", Offset = "0x722120", VA = "0x722120", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x721798", Offset = "0x721798", VA = "0x721798")]
		[DebuggerHidden]
		public <refreshDirectories>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x72201C", Offset = "0x72201C", VA = "0x72201C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x722020", Offset = "0x722020", VA = "0x722020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7220E0", Offset = "0x7220E0", VA = "0x7220E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Browser <>4__this;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7219F4", Offset = "0x7219F4", VA = "0x7219F4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x722128", Offset = "0x722128", VA = "0x722128")]
		internal void <AddFileItem>b__0()
		{
		}
	}

	[Token(Token = "0x200000D")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Browser <>4__this;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x721C48", Offset = "0x721C48", VA = "0x721C48")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x722148", Offset = "0x722148", VA = "0x722148")]
		internal void <AddDirectoryItem>b__0()
		{
		}
	}

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> extensions;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject listItemPrefab;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject upButton;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ScrollRect scrollRect;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject folderPanel;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject filePanel;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string currentDirectory;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] drives;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<string> directories;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<string> files;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool selectDrive;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool scrolling;

	[Token(Token = "0x14000002")]
	public event Action<string> FileSelected
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x720664", Offset = "0x720664", VA = "0x720664")]
		add
		{
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x720D2C", Offset = "0x720D2C", VA = "0x720D2C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x720DDC", Offset = "0x720DDC", VA = "0x720DDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7212EC", Offset = "0x7212EC", VA = "0x7212EC")]
	public void Up()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x720F48", Offset = "0x720F48", VA = "0x720F48")]
	private void BuildContent()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7213B4", Offset = "0x7213B4", VA = "0x7213B4")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7215F8", Offset = "0x7215F8", VA = "0x7215F8")]
	private void OnFileSelected(int index)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7216B8", Offset = "0x7216B8", VA = "0x7216B8")]
	private void OnDirectorySelected(int index)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x721584", Offset = "0x721584", VA = "0x721584")]
	private IEnumerator refreshFiles()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x721510", Offset = "0x721510", VA = "0x721510")]
	private IEnumerator refreshDirectories()
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7217C0", Offset = "0x7217C0", VA = "0x7217C0")]
	private void AddFileItem(int index)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7219FC", Offset = "0x7219FC", VA = "0x7219FC")]
	private void AddDirectoryItem(int index)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x721C50", Offset = "0x721C50", VA = "0x721C50")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x721F08", Offset = "0x721F08", VA = "0x721F08")]
	public Browser()
	{
	}
}
[Token(Token = "0x200000E")]
public abstract class DecoderImporter : AudioImporter
{
	[Token(Token = "0x200000F")]
	protected class AudioInfo
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <lengthSamples>k__BackingField;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <channels>k__BackingField;

		[Token(Token = "0x1700000E")]
		public int lengthSamples
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x722C5C", Offset = "0x722C5C", VA = "0x722C5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x722C64", Offset = "0x722C64", VA = "0x722C64")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int sampleRate
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x722C6C", Offset = "0x722C6C", VA = "0x722C6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x722C74", Offset = "0x722C74", VA = "0x722C74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int channels
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x722C7C", Offset = "0x722C7C", VA = "0x722C7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x722C84", Offset = "0x722C84", VA = "0x722C84")]
			private set
			{
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x722C8C", Offset = "0x722C8C", VA = "0x722C8C")]
		public AudioInfo(int lengthSamples, int sampleRate, int channels)
		{
		}
	}

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioInfo info;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int bufferSize;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] buffer;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AutoResetEvent waitForMainThread;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Thread import;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int index;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool abort;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Queue<Action> executionQueue;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private object _lock;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x722168", Offset = "0x722168", VA = "0x722168", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x72231C", Offset = "0x72231C", VA = "0x72231C", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7224A4", Offset = "0x7224A4", VA = "0x7224A4")]
	private void DoImport()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7226D4", Offset = "0x7226D4", VA = "0x7226D4")]
	private void Decode()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x722834", Offset = "0x722834", VA = "0x722834")]
	private void CreateClip()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7228EC", Offset = "0x7228EC", VA = "0x7228EC")]
	private void SetData()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x722A1C", Offset = "0x722A1C", VA = "0x722A1C")]
	protected void OnError(string error)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7225C0", Offset = "0x7225C0", VA = "0x7225C0")]
	private void Dispatch(Action action)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x722A64", Offset = "0x722A64", VA = "0x722A64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000058")]
	protected abstract void Initialize();

	[Token(Token = "0x6000059")]
	protected abstract void Cleanup();

	[Token(Token = "0x600005A")]
	protected abstract int GetSamples(float[] buffer, int offset, int count);

	[Token(Token = "0x600005B")]
	protected abstract AudioInfo GetInfo();

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x722B98", Offset = "0x722B98", VA = "0x722B98")]
	protected DecoderImporter()
	{
	}
}
[Token(Token = "0x2000010")]
public class MobileImporter : AudioImporter
{
	[Token(Token = "0x2000011")]
	private sealed class <WaitForWebRequest>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MobileImporter <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x72300C", Offset = "0x72300C", VA = "0x72300C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x723054", Offset = "0x723054", VA = "0x723054", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x722EFC", Offset = "0x722EFC", VA = "0x722EFC")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x722F2C", Offset = "0x722F2C", VA = "0x722F2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x722F30", Offset = "0x722F30", VA = "0x722F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x723014", Offset = "0x723014", VA = "0x723014", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AsyncOperation operation;

	[Token(Token = "0x17000011")]
	public override float progress
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x722CC8", Offset = "0x722CC8", VA = "0x722CC8", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public override bool isDone
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x722CE0", Offset = "0x722CE0", VA = "0x722CE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public override bool isInitialized
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x722CF4", Offset = "0x722CF4", VA = "0x722CF4", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public override bool isError
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x722D00", Offset = "0x722D00", VA = "0x722D00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public override string error
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x722D40", Offset = "0x722D40", VA = "0x722D40", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x722DA4", Offset = "0x722DA4", VA = "0x722DA4", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x722E08", Offset = "0x722E08", VA = "0x722E08", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x722E88", Offset = "0x722E88", VA = "0x722E88")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x722F24", Offset = "0x722F24", VA = "0x722F24")]
	public MobileImporter()
	{
	}
}
[Token(Token = "0x2000012")]
public class NAudioImporter : DecoderImporter
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Mp3FileReader reader;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ISampleProvider sampleProvider;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x72305C", Offset = "0x72305C", VA = "0x72305C", Slot = "18")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x72325C", Offset = "0x72325C", VA = "0x72325C", Slot = "19")]
	protected override void Cleanup()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7232A4", Offset = "0x7232A4", VA = "0x7232A4", Slot = "21")]
	protected override AudioInfo GetInfo()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x723370", Offset = "0x723370", VA = "0x723370", Slot = "20")]
	protected override int GetSamples(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x723430", Offset = "0x723430", VA = "0x723430")]
	public NAudioImporter()
	{
	}
}
[Token(Token = "0x2000013")]
public class BallEffect : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshFilter m_LightshaftsMesh;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer m_LightshaftRenderer;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool m_Spin;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x723434", Offset = "0x723434", VA = "0x723434")]
	private void Start()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7244B8", Offset = "0x7244B8", VA = "0x7244B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x72351C", Offset = "0x72351C", VA = "0x72351C")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x724AC4", Offset = "0x724AC4", VA = "0x724AC4")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7252FC", Offset = "0x7252FC", VA = "0x7252FC")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x724758", Offset = "0x724758", VA = "0x724758")]
	private void GeneratePiramid(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x725814", Offset = "0x725814", VA = "0x725814")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x72589C", Offset = "0x72589C", VA = "0x72589C")]
	public BallEffect()
	{
	}
}
[Token(Token = "0x2000014")]
public class BeatProcessor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000015")]
	public class OnBeatEventHandler : UnityEvent
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x726AF0", Offset = "0x726AF0", VA = "0x726AF0")]
		public OnBeatEventHandler()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000016")]
	public class OnSpectrumEventHandler : UnityEvent<float[]>
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x726AF8", Offset = "0x726AF8", VA = "0x726AF8")]
		public OnSpectrumEventHandler()
		{
		}
	}

	[Token(Token = "0x2000017")]
	private class Autoco
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int del_length;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float decay;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] delays;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] outputs;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int indx;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] bpms;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] rweight;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float wmidbpm;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float woctavewidth;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x725C6C", Offset = "0x725C6C", VA = "0x725C6C")]
		public Autoco(int len, float alpha, float framePeriod, float bandwidth)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x726650", Offset = "0x726650", VA = "0x726650")]
		public void newVal(float val)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x726710", Offset = "0x726710", VA = "0x726710")]
		public float autoco(int del)
		{
			return default(float);
		}
	}

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private long lastT;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private long nowT;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private long diff;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private long entries;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private long sum;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int bufferSize;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int samplingRate;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int nBand;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float gThresh;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int blipDelayLen;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int[] blipDelay;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int sinceLast;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float framePeriod;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int colmax;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float[] spectrum;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float[] averages;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float[] acVals;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float[] onsets;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float[] scorefun;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float[] dobeat;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int now;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float[] spec;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int maxlag;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float decay;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Autoco auco;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Game m_Game;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float alph;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public OnBeatEventHandler onBeat;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public OnSpectrumEventHandler onSpectrum;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float m_PrevBeatTime;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x7258A4", Offset = "0x7258A4", VA = "0x7258A4")]
	private long getCurrentTimeMillis()
	{
		return default(long);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x725928", Offset = "0x725928", VA = "0x725928")]
	private void initArrays()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x725A5C", Offset = "0x725A5C", VA = "0x725A5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x725E60", Offset = "0x725E60", VA = "0x725E60")]
	public void tapTempo()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x725F2C", Offset = "0x725F2C", VA = "0x725F2C")]
	private double[] toDoubleArray(float[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x725FDC", Offset = "0x725FDC", VA = "0x725FDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x726764", Offset = "0x726764", VA = "0x726764")]
	public void changeCameraColor()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x725C48", Offset = "0x725C48", VA = "0x725C48")]
	public float getBandWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x726834", Offset = "0x726834", VA = "0x726834")]
	public int freqToIndex(int freq)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x726488", Offset = "0x726488", VA = "0x726488")]
	public void computeAverages(float[] data)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x726988", Offset = "0x726988", VA = "0x726988")]
	private float map(float s, float a1, float a2, float b1, float b2)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7269A4", Offset = "0x7269A4", VA = "0x7269A4")]
	public float constrain(float value, float inclusiveMinimum, float inlusiveMaximum)
	{
		return default(float);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7269C0", Offset = "0x7269C0", VA = "0x7269C0")]
	public void OnBeat()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x726AAC", Offset = "0x726AAC", VA = "0x726AAC")]
	public BeatProcessor()
	{
	}
}
[Token(Token = "0x2000018")]
public class BeatsComposer : MonoBehaviour
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool train;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool multi_train;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audio_source;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] multi_channel_samples;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] pre_processed_samples;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int num_channels;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int num_total_samples;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int sample_rate;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float clip_length;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool finished;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int progress;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float[][] notes;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float[][] bands;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int no_sections;

	[Token(Token = "0x4000090")]
	public const int NO_TRAINS = 200;

	[Token(Token = "0x4000091")]
	public const int NO_SAMPLES = 2048;

	[Token(Token = "0x4000092")]
	public const int NO_NOTES = 12;

	[Token(Token = "0x4000093")]
	public const int NO_BANDS = 7;

	[Token(Token = "0x4000094")]
	public const int NO_SECTIONS_TO_ANALIZE = 9;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float[] beat_times;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float[] markers;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int last_beat_idx;

	[Token(Token = "0x4000098")]
	private const int BAND_NN_INPUTS = 63;

	[Token(Token = "0x4000099")]
	private const int NOTES_NN_INPUTS = 108;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private NeuralNet bands_net;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private NeuralNet notes_net;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float[] band_markers;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float[] notes_markers;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x726B40", Offset = "0x726B40", VA = "0x726B40")]
	public void SetBeats(List<float> times)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x726C20", Offset = "0x726C20", VA = "0x726C20")]
	public int TimeToSection(float time)
	{
		return default(int);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x726CA0", Offset = "0x726CA0", VA = "0x726CA0")]
	public float SectionToTime(int section)
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x726CCC", Offset = "0x726CCC", VA = "0x726CCC")]
	public void Process(Game game)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x727584", Offset = "0x727584", VA = "0x727584")]
	private void TrainNotesNN()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7278C4", Offset = "0x7278C4", VA = "0x7278C4")]
	private void SaveBeatSamples(List<DataSet> data, string name)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x726F50", Offset = "0x726F50", VA = "0x726F50")]
	private void MultiTrainNN()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x727D04", Offset = "0x727D04", VA = "0x727D04")]
	private void LoadWeights()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x727EA4", Offset = "0x727EA4", VA = "0x727EA4")]
	private void MakeNotes()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x728100", Offset = "0x728100", VA = "0x728100")]
	private void TrainBandsNN()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x728414", Offset = "0x728414", VA = "0x728414")]
	private void VisBands()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x728680", Offset = "0x728680", VA = "0x728680")]
	private void Train()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7286B0", Offset = "0x7286B0", VA = "0x7286B0")]
	private void MarkHits()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x728808", Offset = "0x728808", VA = "0x728808")]
	private void VisHits()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7288B0", Offset = "0x7288B0", VA = "0x7288B0")]
	private void NormalizeFFT()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x728B7C", Offset = "0x728B7C", VA = "0x728B7C")]
	private void AnalyzeFFT()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x728FF8", Offset = "0x728FF8", VA = "0x728FF8")]
	private void MakeMono()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x7290E4", Offset = "0x7290E4", VA = "0x7290E4")]
	public void Compose()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x72927C", Offset = "0x72927C", VA = "0x72927C")]
	private void GenrateEvents()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x729430", Offset = "0x729430", VA = "0x729430")]
	public BeatsComposer()
	{
	}
}
[Token(Token = "0x2000019")]
public class Bullet : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Dangerous;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_Yellow;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 m_StartPos;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] m_PrevPos;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Game m_Game;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_BeatIDx;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float m_ProgressShift;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 TARGET_MUL;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_Vis;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int m_TrialSoundBlock;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x72950C", Offset = "0x72950C", VA = "0x72950C")]
	private float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x72956C", Offset = "0x72956C", VA = "0x72956C")]
	private bool IsYellow()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7295A0", Offset = "0x7295A0", VA = "0x7295A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x729634", Offset = "0x729634", VA = "0x729634")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x729834", Offset = "0x729834", VA = "0x729834")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x72A6DC", Offset = "0x72A6DC", VA = "0x72A6DC")]
	private void OnTimeOut()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x72A86C", Offset = "0x72A86C", VA = "0x72A86C")]
	private void PlayFX(string name, Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x729BC4", Offset = "0x729BC4", VA = "0x729BC4")]
	private bool UpdateColls(Vector3 a_pos, Vector3 b_pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x72AA10", Offset = "0x72AA10", VA = "0x72AA10")]
	private void OnPlayerHit()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x72AB84", Offset = "0x72AB84", VA = "0x72AB84")]
	public Bullet()
	{
	}
}
[Token(Token = "0x200001A")]
public class Center : MonoBehaviour
{
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x72AC00", Offset = "0x72AC00", VA = "0x72AC00")]
	public Center()
	{
	}
}
[Token(Token = "0x200001B")]
public class CollTester : MonoBehaviour
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_Help1;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform m_Help2;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x72AC08", Offset = "0x72AC08", VA = "0x72AC08")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x72AC80", Offset = "0x72AC80", VA = "0x72AC80")]
	public CollTester()
	{
	}
}
[Token(Token = "0x200001C")]
public class ColorSwitcher : MonoBehaviour
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_Frames;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool m_ColorsInv;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material m_GloveRMat;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material m_GloveCoverRMat;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_GloveBladeRMat;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material m_GloveBladeFXRMat;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture m_CoverAddYellow;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color m_GloveEmmisYellow;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color m_BladeEmmisYellow;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture m_BladeFXTextYellow;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material m_GloveLMat;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material m_GloveCoverLMat;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material m_GloveBladeLMat;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material m_GloveBladeFXLMat;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture m_CoverAddBlue;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color m_GloveEmmisBlue;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color m_BladeEmmisBlue;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture m_BladeFXTextBlue;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x72AC88", Offset = "0x72AC88", VA = "0x72AC88")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x72ACA0", Offset = "0x72ACA0", VA = "0x72ACA0")]
	public void SwitchColors()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x72AEE4", Offset = "0x72AEE4", VA = "0x72AEE4")]
	public ColorSwitcher()
	{
	}
}
[Token(Token = "0x200001D")]
public class Compositor : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	private struct XSequence
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string dev_name;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string part_1;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string part_2;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int tempo;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int obstacles;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool horiz_obst;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int jabs;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int tow;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool projectiles;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int probality;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool good_for_silient;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool must_be_full;
	}

	[Serializable]
	[Token(Token = "0x200001F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<XSequence> <>9__62_0;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x730D94", Offset = "0x730D94", VA = "0x730D94")]
		public <>c()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x730D9C", Offset = "0x730D9C", VA = "0x730D9C")]
		internal int <SelectSequences>b__62_0(XSequence p1, XSequence p2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MainMenu m_MainMenu;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRKeyboard m_Keyboard;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RhythmAnalyzer m_Analyzer;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource m_SelMusicSource;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string MAIN_LETTERS;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text m_DebugText;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite m_SpriteON;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite m_SpriteOFF;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Image[] m_TOWImages;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image[] m_TempoImages;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Image[] m_ComplexityImages;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image[] m_ObstaclesImages;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Image[] m_DifferentiationImages;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Image[] m_JabImages;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Sprite m_SpriteCheckOn;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Sprite m_SpriteCheckOff;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Image m_ProjectilesImages;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Image m_BPM160Images;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image m_HorzObstImages;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text m_SelPresetName;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text m_APresetName;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text m_BPresetName;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text m_CPresetName;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image m_Icon_AAA;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image m_Icon_BBB;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Image m_Icon_CCC;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool m_Compose;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool m_Finished;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool m_Loading;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private RhythmData rhythmData;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<Beat> m_Beats;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Value> m_Segments;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<int> m_BeatSeg;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<int> m_UpDownSeg;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int BPM;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public int BASE_BEAT;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string notes;

	[Token(Token = "0x40000E2")]
	public const int MAX_NO_CACHED_TITLES = 200;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public AudioImporter m_AudioImporter;

	[Token(Token = "0x40000E4")]
	private const int SLOW_BPM = 110;

	[Token(Token = "0x40000E5")]
	private const int FAST_BPM = 130;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public string m_PresetPrefix;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool m_HorizObstacles;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public int m_Jabs;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public int m_TOW;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool m_Projectiles;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public int m_Obstacles;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public int m_Complexity;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int m_Tempo;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int m_Differentiation;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool m_UseHigestBPM;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public TextAsset m_FileSequence;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool m_PresetNameChanged;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<XSequence> SEQUENCES;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<XSequence> m_PoolOfSeq;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<int> m_PoolProbs;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private List<string> sel_sequences;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<int> sel_seq_idx;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int left_right;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x72AEFC", Offset = "0x72AEFC", VA = "0x72AEFC")]
	private int RandomSeq(bool first_in_seg, int up_down, int last_seq, bool full_length)
	{
		return default(int);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x72B130", Offset = "0x72B130", VA = "0x72B130")]
	private int CalculateWeightMod(bool first_in_seg, int up_down, int i)
	{
		return default(int);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x72B234", Offset = "0x72B234", VA = "0x72B234")]
	private void ComposeNotes()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x72BD74", Offset = "0x72BD74", VA = "0x72BD74")]
	private int AddPadding(int beat_idx, int i)
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x72B5E4", Offset = "0x72B5E4", VA = "0x72B5E4")]
	private void UpDownSegments()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x72BFCC", Offset = "0x72BFCC", VA = "0x72BFCC")]
	public void SelectSequences()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x72C8EC", Offset = "0x72C8EC", VA = "0x72C8EC")]
	private int CalculateTempo()
	{
		return default(int);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x72C958", Offset = "0x72C958", VA = "0x72C958")]
	private void MatchNoSequences()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x72CB2C", Offset = "0x72CB2C", VA = "0x72CB2C")]
	public void MatchTempo()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x72D428", Offset = "0x72D428", VA = "0x72D428")]
	private void ReadNotes(string fs)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x72D92C", Offset = "0x72D92C", VA = "0x72D92C")]
	public void CalculateBPM()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x72DD58", Offset = "0x72DD58", VA = "0x72DD58")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x72DE3C", Offset = "0x72DE3C", VA = "0x72DE3C")]
	private void LoadAudioClip()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x72DFCC", Offset = "0x72DFCC", VA = "0x72DFCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x72E610", Offset = "0x72E610", VA = "0x72E610")]
	public void Compose()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x72E7C4", Offset = "0x72E7C4", VA = "0x72E7C4")]
	public void Abort()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x72E880", Offset = "0x72E880", VA = "0x72E880")]
	public void CutBeats()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x72E09C", Offset = "0x72E09C", VA = "0x72E09C")]
	public void UpdateCompositor()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x72F1D8", Offset = "0x72F1D8", VA = "0x72F1D8")]
	private void MakeHeader(string title)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x72F2FC", Offset = "0x72F2FC", VA = "0x72F2FC")]
	private void RemoveTooOftenSegments()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x72F54C", Offset = "0x72F54C", VA = "0x72F54C")]
	private void CalculateSegments()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x72FA04", Offset = "0x72FA04", VA = "0x72FA04")]
	public void CreateTrackTest()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x72E900", Offset = "0x72E900", VA = "0x72E900")]
	public void CreateTrack()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x72FC94", Offset = "0x72FC94", VA = "0x72FC94")]
	private void SaveTamps(string title_path, string prefix)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x730000", Offset = "0x730000", VA = "0x730000")]
	public void SaveGeneratedTrack(string title_path, string prefix, string notes)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7300DC", Offset = "0x7300DC", VA = "0x7300DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x730270", Offset = "0x730270", VA = "0x730270")]
	private void ReadPreset()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x72E1B8", Offset = "0x72E1B8", VA = "0x72E1B8")]
	private void RefreshOptions()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7304B8", Offset = "0x7304B8", VA = "0x7304B8")]
	public void OnChangePresetName()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x73058C", Offset = "0x73058C", VA = "0x73058C")]
	public void OnSelectPreset(int preset_idx)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x73018C", Offset = "0x73018C", VA = "0x73018C")]
	private void SelectedPresetToPrefix()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x730620", Offset = "0x730620", VA = "0x730620")]
	public void OnClickTOW(int idx)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x7306CC", Offset = "0x7306CC", VA = "0x7306CC")]
	public void OnClickTempo(int idx)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x730778", Offset = "0x730778", VA = "0x730778")]
	public void OnClickDifferentiation(int idx)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x730824", Offset = "0x730824", VA = "0x730824")]
	public void OnClickObstacles(int idx)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7308D0", Offset = "0x7308D0", VA = "0x7308D0")]
	public void OnClickComplexity(int idx)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x73097C", Offset = "0x73097C", VA = "0x73097C")]
	public void OnClickJabs(int idx)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x730A28", Offset = "0x730A28", VA = "0x730A28")]
	public void OnClickProjectiles()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x730AD8", Offset = "0x730AD8", VA = "0x730AD8")]
	public void OnClickHorizObstacles()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x72BC98", Offset = "0x72BC98", VA = "0x72BC98")]
	private void RandomizeRotation(ref string notes, int part_of_song)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x730B88", Offset = "0x730B88", VA = "0x730B88")]
	public Compositor()
	{
	}
}
[Token(Token = "0x2000020")]
public class Damagable : MonoBehaviour
{
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x730DB0", Offset = "0x730DB0", VA = "0x730DB0", Slot = "4")]
	public virtual void TakeDamage(int source_id, int damage, Vector3 dir, Vector3 pos)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x730DB4", Offset = "0x730DB4", VA = "0x730DB4")]
	public Damagable()
	{
	}
}
[Token(Token = "0x2000021")]
public class Enemy : Damagable
{
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x730DBC", Offset = "0x730DBC", VA = "0x730DBC", Slot = "5")]
	public virtual bool IsAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x730DC4", Offset = "0x730DC4", VA = "0x730DC4", Slot = "6")]
	public virtual Vector3 GetAimCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x730DE4", Offset = "0x730DE4", VA = "0x730DE4", Slot = "7")]
	public virtual float GetAimRadius()
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x730DEC", Offset = "0x730DEC", VA = "0x730DEC", Slot = "8")]
	public virtual Vector3 GetAimFutureCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x730E68", Offset = "0x730E68", VA = "0x730E68")]
	public Enemy()
	{
	}
}
[Token(Token = "0x2000022")]
public class Drone : MonoBehaviour
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Game m_Game;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool m_Yellow;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool m_Dangerous;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_BeatIDx;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float m_Dir;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_Shift;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_Beta;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int m_NoBulets;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float m_Tempo;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int m_Step;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float m_RotationSpeed;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float m_MaxSpeed;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_SpeedLimiter;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float m_Accelerate;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float m_Fluctuations;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 m_DestPos;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 m_Coords;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 m_CurrSpeed;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject m_Vis;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject m_SpawnFX;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x730E70", Offset = "0x730E70", VA = "0x730E70")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x730F88", Offset = "0x730F88", VA = "0x730F88")]
	private void UpdatePath()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7310DC", Offset = "0x7310DC", VA = "0x7310DC")]
	private void Shot()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x731344", Offset = "0x731344", VA = "0x731344")]
	private void UpdateSpawn()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x731474", Offset = "0x731474", VA = "0x731474")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x731988", Offset = "0x731988", VA = "0x731988")]
	private void UpdateFluctuations()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x731C68", Offset = "0x731C68", VA = "0x731C68")]
	public Drone()
	{
	}
}
[Token(Token = "0x2000023")]
public class EnemyBullet : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Target;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_WhooshDist;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool m_WhooshPlayed;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float m_Speed;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_SourceID;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_Damage;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Game m_Game;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float m_AfterHit;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x731CEC", Offset = "0x731CEC", VA = "0x731CEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x732054", Offset = "0x732054", VA = "0x732054")]
	private void Hit(RaycastHit hit_info)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x732314", Offset = "0x732314", VA = "0x732314")]
	private void PlayHitFX(string fx_name, string fx_sound, Vector3 pos)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7324F8", Offset = "0x7324F8", VA = "0x7324F8")]
	public EnemyBullet()
	{
	}
}
[Token(Token = "0x2000024")]
public class EqualizerEffect : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LevelMovement m_Elevator;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool m_Tutorial;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material m_AnimLightMat;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material m_RoundEqulizerMat;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_BarsEqulizerMat;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material m_BarsEqulizerHaloMat;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material m_SkyscraperWindowsMat;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material m_SkyscraperWindowsHaloMat;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material m_MotionMat;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material m_MotionColorofonMat;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material m_MotionColorofonHaloMat;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material m_FlorHaloMat;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material m_SkyMat;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material m_ArenaMat;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material m_ArenaMatNoReflects;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material m_ArenaLinesMat;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material m_ArenaLinesHaloMat;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Material m_LavaToAnimMat;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float LavaMul;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Light m_HUDLight;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float m_WallEffectPow;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float m_SpecAmpltudeMod;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float m_AnimMatTime;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float m_ScaleMod;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float m_Hue;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int m_HueIDX;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int m_HueStep;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int m_NoBands;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float[] m_SpecVis;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float[] m_NotesVis;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float[] m_NotesVisBlend;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool m_UseNotes;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool m_MainMenu;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public int m_ColorScheme;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool m_DimColors;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float m_LavaProgress;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x73251C", Offset = "0x73251C", VA = "0x73251C")]
	private void UpdateHue()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x732670", Offset = "0x732670", VA = "0x732670")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x732808", Offset = "0x732808", VA = "0x732808")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x732DCC", Offset = "0x732DCC", VA = "0x732DCC")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x733290", Offset = "0x733290", VA = "0x733290")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x733330", Offset = "0x733330", VA = "0x733330")]
	private Color HueToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x733480", Offset = "0x733480", VA = "0x733480")]
	private Color HueToLineColor()
	{
		return default(Color);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x733678", Offset = "0x733678", VA = "0x733678")]
	private void UpdateWallEffect()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x733770", Offset = "0x733770", VA = "0x733770")]
	private void UpdateLava()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7338AC", Offset = "0x7338AC", VA = "0x7338AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x734CAC", Offset = "0x734CAC", VA = "0x734CAC")]
	private void UpdateSkyFog()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x733C80", Offset = "0x733C80", VA = "0x733C80")]
	private void RoundEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x733FC0", Offset = "0x733FC0", VA = "0x733FC0")]
	private void BarsEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7345EC", Offset = "0x7345EC", VA = "0x7345EC")]
	private void MotionMatUpdate()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x733ED8", Offset = "0x733ED8", VA = "0x733ED8")]
	private void UpdateLightSynchroMats()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x735204", Offset = "0x735204", VA = "0x735204")]
	public EqualizerEffect()
	{
	}
}
[Token(Token = "0x2000025")]
public class EqualizerHallo : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EqualizerEffect m_Equalizer;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Game m_Game;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_Phase;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int m_NoBands;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] m_SpecVis;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 m_StartPos;

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x7352C8", Offset = "0x7352C8", VA = "0x7352C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x7353D4", Offset = "0x7353D4", VA = "0x7353D4")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7358D0", Offset = "0x7358D0", VA = "0x7358D0")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x735D98", Offset = "0x735D98", VA = "0x735D98")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x735E38", Offset = "0x735E38", VA = "0x735E38")]
	private void Update()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x736550", Offset = "0x736550", VA = "0x736550")]
	public EqualizerHallo()
	{
	}
}
[Token(Token = "0x2000026")]
public class ExitButton : MonoBehaviour
{
	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR m_VR;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_Time;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_CircleMat;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7365FC", Offset = "0x7365FC", VA = "0x7365FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7366DC", Offset = "0x7366DC", VA = "0x7366DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x736BD0", Offset = "0x736BD0", VA = "0x736BD0")]
	public ExitButton()
	{
	}
}
[Token(Token = "0x2000027")]
public class Game : MonoBehaviour
{
	[Token(Token = "0x2000028")]
	public enum EEventType
	{
		[Token(Token = "0x40001D1")]
		Empty = 0,
		[Token(Token = "0x40001D2")]
		Punch = 1,
		[Token(Token = "0x40001D3")]
		Wall = 2,
		[Token(Token = "0x40001D4")]
		Cut = 4,
		[Token(Token = "0x40001D5")]
		Shield = 8,
		[Token(Token = "0x40001D6")]
		TutorialTest = 0x10,
		[Token(Token = "0x40001D7")]
		Block = 0x20,
		[Token(Token = "0x40001D8")]
		Cannon = 0x40
	}

	[Token(Token = "0x2000029")]
	public struct HandStats
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_Speed;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_Timing;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_Precision;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_Bomb;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EEventType m_Type;
	}

	[Token(Token = "0x200002A")]
	public struct TrackEvent
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EEventType m_Type;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_Coll;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_ShiftColl;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_Row;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_Dir;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_Blue;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool m_Bomb;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_NoElems;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_Tempo;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m_Shift;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool m_RightRot;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int m_AngleRot;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Time;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool m_HalfUp;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int m_Count;
	}

	[Token(Token = "0x200002B")]
	public enum Difficulty
	{
		[Token(Token = "0x40001EE")]
		WarmUp,
		[Token(Token = "0x40001EF")]
		Workout,
		[Token(Token = "0x40001F0")]
		Intense
	}

	[Token(Token = "0x200002C")]
	private sealed class <LoadAudioClip>d__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x73E34C", Offset = "0x73E34C", VA = "0x73E34C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x73E394", Offset = "0x73E394", VA = "0x73E394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x736CDC", Offset = "0x736CDC", VA = "0x736CDC")]
		[DebuggerHidden]
		public <LoadAudioClip>d__104(int <>1__state)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x73E0F0", Offset = "0x73E0F0", VA = "0x73E0F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x73E0F4", Offset = "0x73E0F4", VA = "0x73E0F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x73E354", Offset = "0x73E354", VA = "0x73E354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	private sealed class <LoadLocalClip>d__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x73E5C0", Offset = "0x73E5C0", VA = "0x73E5C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x73E608", Offset = "0x73E608", VA = "0x73E608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x736D78", Offset = "0x736D78", VA = "0x736D78")]
		[DebuggerHidden]
		public <LoadLocalClip>d__105(int <>1__state)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x73E39C", Offset = "0x73E39C", VA = "0x73E39C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x73E3A0", Offset = "0x73E3A0", VA = "0x73E3A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x73E5C8", Offset = "0x73E5C8", VA = "0x73E5C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000155")]
	public const int PLAYER_LAYER = 8;

	[Token(Token = "0x4000156")]
	public const int SHIELD_LAYER = 19;

	[Token(Token = "0x4000157")]
	public const int METAL_LAYER = 20;

	[Token(Token = "0x4000158")]
	public const int WALL_LAYER = 16;

	[Token(Token = "0x4000159")]
	public const int ENEMY_LAYER = 17;

	[Token(Token = "0x400015A")]
	public const int COLL_MASK = 1245440;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_OffsetTest;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_TimeTest;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string m_Notes;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_Song;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_AvHeight;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_CurrTime;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_PrevTime;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int m_AnalizedBeat;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_PrevAnalizedBeat;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int m_GBeatIDx;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_GBeatProgress;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int m_FXBeatIDx;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float m_FXBeatProgress;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int m_PrevIDx;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CommonVR m_VR;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int m_StartBeat;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float m_BPM;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_Offset;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int m_FinisBeatIDx;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public VideoPlayer m_ClipSource;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioSource m_Music;

	[Token(Token = "0x4000170")]
	private const int NO_PARALLEL_EVENTS = 5;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TrackEvent[][] m_Events;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float m_SnapPow;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float m_Blackout;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<string> m_RescueIDs;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<string> m_RescueURLs;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_SourceID;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int m_ScoreMul;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int m_ScoreMulProgress;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool m_Finished;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LevelCompleted m_LevelCompleted;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public HUD m_HUD;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<float> CommonBeats;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AudioClip m_ClipToPlay;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool m_TrailerMode;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	private bool m_WasStarted;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	private bool m_Inited;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float m_Volume;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public int m_HitFeadback;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Glove m_LGlove;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Glove m_RGlove;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject[] m_Tutorials;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public int m_TutorialProgress;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float m_TutorialRevTime;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float m_TutorialFailAnim;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public bool m_Tutorial;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
	public bool m_RepeatedTut;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
	private bool m_SmallArea;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
	private bool m_SkullOff;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool m_HorizObstaclesOff;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool m_VertObstaclesOff;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	public bool m_ReflexMode;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public TextAsset m_NotesFile;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string[,] m_Sequences;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public int m_Score;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public int m_Combo;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int m_MaxCombo;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public int m_Hits;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int m_Misses;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private HandStats[] m_LStats;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private HandStats[] m_RStats;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int m_LStatIDX;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int m_RStatIDX;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float m_MaxProg;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public float m_LMaxProg;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public float m_RMaxProg;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public EEventType m_LEvent;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public EEventType m_REvent;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public Vector3 m_MarkersPos;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject m_WallHitEffect;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public string m_ReloadSceneName;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public int m_HitNotes;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public int m_SlashNotes;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public int m_WallNotes;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public int m_DroneNotes;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public int m_Traps;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	public int m_TrackLength;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public bool m_Pause;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
	public bool m_CannonMode;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public GameObject m_ContinueMenu;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public GameObject m_LaserBeam;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public float m_ArenaLShift;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	public float m_ArenaRShift;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float m_EnergyMod;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float[] m_TimeStamps;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool m_HitDirArrow;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
	public bool m_ColorsInv;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public AudioImporter m_AudioImporter;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float m_GlobalSynchro;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public Difficulty m_Difficulty;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public int m_NoMissesOnRow;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	public float m_TimeWithoutAction;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private float m_LHandEnergy;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float m_RHandEnergy;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private float m_HeadEnergy;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	public float m_Calories;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public int m_NoDodging;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public int m_NoWallsHits;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public int m_NoRSmashingProj;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public int m_NoLSmashingProj;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public int m_NoRMissProj;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	public int m_NoLMissProj;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private Vector3 m_LHandSpeed;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private Vector3 m_RHandSpeed;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Vector3 m_HeadSpeed;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private Vector3 m_LHandSpeedPrev;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Vector3 m_RHandSpeedPrev;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private Vector3 m_HeadSpeedPrev;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private Vector3 m_LHandPos;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private Vector3 m_RHandPos;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Vector3 m_HeadPos;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private Vector3 m_LHandPosPrev;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private Vector3 m_RHandPosPrev;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	private Vector3 m_HeadPosPrev;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public Turntable m_Turnable;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x736BD8", Offset = "0x736BD8", VA = "0x736BD8")]
	public static int GetSourceID()
	{
		return default(int);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x736C38", Offset = "0x736C38", VA = "0x736C38")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x736C68", Offset = "0x736C68", VA = "0x736C68")]
	private IEnumerator LoadAudioClip()
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x736D04", Offset = "0x736D04", VA = "0x736D04")]
	private IEnumerator LoadLocalClip()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x736DA0", Offset = "0x736DA0", VA = "0x736DA0")]
	private void Init()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x737068", Offset = "0x737068", VA = "0x737068")]
	private void Start()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x737700", Offset = "0x737700", VA = "0x737700")]
	private void ClearEvents()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x737800", Offset = "0x737800", VA = "0x737800")]
	private void StartGame()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x7378D4", Offset = "0x7378D4", VA = "0x7378D4")]
	public void PrepareTrack()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x737AD8", Offset = "0x737AD8", VA = "0x737AD8")]
	public void ParseInfo(string notes)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x738FDC", Offset = "0x738FDC", VA = "0x738FDC")]
	private string ParseTrack(string track, ref int beat_idx, ref bool blue, ref int speed, ref int shift, ref int y_shift)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x73A0A0", Offset = "0x73A0A0", VA = "0x73A0A0")]
	public float GetCurrProgress()
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x73A0B0", Offset = "0x73A0B0", VA = "0x73A0B0")]
	public float GetCurrMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x73A0C0", Offset = "0x73A0C0", VA = "0x73A0C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x73BAD8", Offset = "0x73BAD8", VA = "0x73BAD8")]
	private void CreateMarker(int curr_beat)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x73C404", Offset = "0x73C404", VA = "0x73C404")]
	private bool UpdateTutorial(int curr_beat)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x73AF7C", Offset = "0x73AF7C", VA = "0x73AF7C")]
	private void UpdateTutorialFailAnim()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x73B08C", Offset = "0x73B08C", VA = "0x73B08C")]
	private void UpdateBlackout()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x73C55C", Offset = "0x73C55C", VA = "0x73C55C")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x73C594", Offset = "0x73C594", VA = "0x73C594")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x73A1A8", Offset = "0x73A1A8", VA = "0x73A1A8")]
	private void ShowContinueMenu()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x73A454", Offset = "0x73A454", VA = "0x73A454")]
	public void OnFinish()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x73C66C", Offset = "0x73C66C", VA = "0x73C66C")]
	public void OnFail(bool right)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x736BA8", Offset = "0x736BA8", VA = "0x736BA8")]
	public bool IsExitButtonVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x73C70C", Offset = "0x73C70C", VA = "0x73C70C")]
	private void ClearExitCondition()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x73C740", Offset = "0x73C740", VA = "0x73C740")]
	public void OnPassBomb(bool right)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x73C7C4", Offset = "0x73C7C4", VA = "0x73C7C4")]
	public void OnPass(bool right)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x73C878", Offset = "0x73C878", VA = "0x73C878")]
	public void OnPassWall()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x73C8F0", Offset = "0x73C8F0", VA = "0x73C8F0")]
	public void OnPassBlock()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x73CAEC", Offset = "0x73CAEC", VA = "0x73CAEC")]
	public int OnPass(float speed, float precis, float timimg, bool right, Vector3 pos, Vector3 dir_, bool slash, bool bad_angle = false)
	{
		return default(int);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x73CE28", Offset = "0x73CE28", VA = "0x73CE28")]
	public void OnBomb(bool right)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x73CEC0", Offset = "0x73CEC0", VA = "0x73CEC0")]
	public void OnTimeOut(bool right, bool bulet = false)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x73C6D4", Offset = "0x73C6D4", VA = "0x73C6D4")]
	private void DecraseMul()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x73CDA8", Offset = "0x73CDA8", VA = "0x73CDA8")]
	private void IncraseMul()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x73CF44", Offset = "0x73CF44", VA = "0x73CF44")]
	public int GetCapacity()
	{
		return default(int);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x73CA4C", Offset = "0x73CA4C", VA = "0x73CA4C")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x73CF98", Offset = "0x73CF98", VA = "0x73CF98")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7373F8", Offset = "0x7373F8", VA = "0x7373F8")]
	public void ReadSequences()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x73D140", Offset = "0x73D140", VA = "0x73D140")]
	private void GetSeq(string line, string letter, int idx, int coll)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7389BC", Offset = "0x7389BC", VA = "0x7389BC")]
	private string PrepareTrack(string track)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x73B1EC", Offset = "0x73B1EC", VA = "0x73B1EC")]
	private void EnergyCalculator()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x73D314", Offset = "0x73D314", VA = "0x73D314")]
	public void StopPreview()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x73D3AC", Offset = "0x73D3AC", VA = "0x73D3AC")]
	private void LoadLocalClipPrev()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x73D548", Offset = "0x73D548", VA = "0x73D548")]
	private void LoadAudioClipPrev()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x73D674", Offset = "0x73D674", VA = "0x73D674")]
	public void PlayPreview()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x73D78C", Offset = "0x73D78C", VA = "0x73D78C")]
	private void UpdateTimeStamp()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x73A284", Offset = "0x73A284", VA = "0x73A284")]
	private void UpdateBeatIDx()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x73AF24", Offset = "0x73AF24", VA = "0x73AF24")]
	private void AnalyzeEvents()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x73D930", Offset = "0x73D930", VA = "0x73D930")]
	private void CheckKeyboard()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x73DBAC", Offset = "0x73DBAC", VA = "0x73DBAC")]
	private void OnExit()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x73DD5C", Offset = "0x73DD5C", VA = "0x73DD5C")]
	public Game()
	{
	}
}
[Token(Token = "0x200002E")]
public class Glove : MonoBehaviour
{
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Right;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_Yellow;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR m_VR;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 m_CurrSpeed;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 m_CurrBladeSpeed;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 m_OldPos;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 m_OldBladePos;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject m_Glove;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject m_Blade;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject m_GloveVis;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject m_BladeVis;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject m_Shield;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject m_ShieldVis;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject m_ShieldFrontVis;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject m_HandVis;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float m_ShieldProgress;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Vector3[] m_ShieldPos;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AudioClip[] m_PunchClips;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public AudioClip m_ShieldClip;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AudioClip[] m_CutClips;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject m_SpeedMarker;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float m_ShieldFrontAnim;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int m_HitSFXVol;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool m_InvertTrigger;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform m_BladeTransform;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int m_PunchSFX;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int m_SlashSFX;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 AFF_RADIUS;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector3 AFF_TRANS;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int m_NODissapearedFrames;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x73E610", Offset = "0x73E610", VA = "0x73E610")]
	private void Start()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x73E7A8", Offset = "0x73E7A8", VA = "0x73E7A8")]
	private void SetupSFX()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x73EA30", Offset = "0x73EA30", VA = "0x73EA30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x73F0DC", Offset = "0x73F0DC", VA = "0x73F0DC")]
	private void UpdateShield()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x73F774", Offset = "0x73F774", VA = "0x73F774")]
	private void UpdateTask()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x73F9A8", Offset = "0x73F9A8", VA = "0x73F9A8")]
	public void PlayPunchSFX(float volume)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x73FABC", Offset = "0x73FABC", VA = "0x73FABC")]
	public void PlaySlashSFX(float volume)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x73FBC0", Offset = "0x73FBC0", VA = "0x73FBC0")]
	public void OnHit(Game.EEventType ev_type)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x73F8D8", Offset = "0x73F8D8", VA = "0x73F8D8")]
	private void UpdateAffector()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x73FD0C", Offset = "0x73FD0C", VA = "0x73FD0C")]
	public Glove()
	{
	}
}
[Token(Token = "0x200002F")]
public class GloveMorpher : MonoBehaviour
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_Input;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform m_BeginHelper;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string m_OutName;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_NoFramesToGenerate;

	[Token(Token = "0x400021C")]
	private const float EPSILON = 0.01f;

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x73FE3C", Offset = "0x73FE3C", VA = "0x73FE3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x73FE4C", Offset = "0x73FE4C", VA = "0x73FE4C")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x73FE50", Offset = "0x73FE50", VA = "0x73FE50")]
	private void Compress(ref Vector3[] verts, ref Vector3[] normals, ref Vector2[] uv, ref int[] tris)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x740114", Offset = "0x740114", VA = "0x740114")]
	private int GetNearestVertIDX(ref Vector3[] verts)
	{
		return default(int);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x740234", Offset = "0x740234", VA = "0x740234")]
	public GloveMorpher()
	{
	}
}
[Token(Token = "0x2000030")]
public class Ground : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_NoIslands;

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x740244", Offset = "0x740244", VA = "0x740244")]
	private void Start()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x7403F4", Offset = "0x7403F4", VA = "0x7403F4")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x740B34", Offset = "0x740B34", VA = "0x740B34")]
	private void GeneratePiramide(ref Vector3[] vertices, Vector3 pos, int idx, float size)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x740F14", Offset = "0x740F14", VA = "0x740F14")]
	public Ground()
	{
	}
}
[Token(Token = "0x2000031")]
public class HitHUD : MonoBehaviour
{
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Right;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Game.HandStats m_Stats;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Perfect;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Timing;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject m_SpeedMarker;

	[Token(Token = "0x4000226")]
	private const int NO_SPEED_MARKS = 7;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject[] m_Speed;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CommonVR m_VR;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_Time;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x740F24", Offset = "0x740F24", VA = "0x740F24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7411E8", Offset = "0x7411E8", VA = "0x7411E8")]
	public void OnSet(Vector3 pos, Vector3 dir_)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x74167C", Offset = "0x74167C", VA = "0x74167C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7417C4", Offset = "0x7417C4", VA = "0x7417C4")]
	public HitHUD()
	{
	}
}
[Token(Token = "0x2000032")]
public class HUD : MonoBehaviour
{
	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Score;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Combo;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_Multi;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_MultiX;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_Calories;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Game m_Game;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material LHitMat;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material RHitMat;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material BonusMat;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_LastScore;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int m_LastCombo;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_LastMulti;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float m_FPS;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m_LHitSpeed;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float m_LHitAnimTime;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_RHitSpeed;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float m_RHitAnimTime;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x741830", Offset = "0x741830", VA = "0x741830")]
	public void Show()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x74186C", Offset = "0x74186C", VA = "0x74186C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x741890", Offset = "0x741890", VA = "0x741890")]
	private void Update()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x741B24", Offset = "0x741B24", VA = "0x741B24")]
	private void UpdateHitMat()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x741C6C", Offset = "0x741C6C", VA = "0x741C6C")]
	public void SetLHandSpeed(float speed)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x741C7C", Offset = "0x741C7C", VA = "0x741C7C")]
	public void SetRHandSpeed(float speed)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x741C8C", Offset = "0x741C8C", VA = "0x741C8C")]
	private void UpdatePos()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x741E28", Offset = "0x741E28", VA = "0x741E28")]
	public HUD()
	{
	}
}
[Token(Token = "0x2000033")]
public class LaserEffect : MonoBehaviour
{
	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_NoProjectors;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_NoSegments;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_RotSpeed;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_Rot;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_PrevRot;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Game m_Game;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x741E38", Offset = "0x741E38", VA = "0x741E38")]
	private void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x742414", Offset = "0x742414", VA = "0x742414")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x741F20", Offset = "0x741F20", VA = "0x741F20")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x742690", Offset = "0x742690", VA = "0x742690")]
	public LaserEffect()
	{
	}
}
[Token(Token = "0x2000034")]
public class LevelCompleted : MonoBehaviour
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Game m_Game;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_LaserBeam;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_LoadHUB;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_TimeToHide;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x7426AC", Offset = "0x7426AC", VA = "0x7426AC")]
	public void Show()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x742708", Offset = "0x742708", VA = "0x742708")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x74282C", Offset = "0x74282C", VA = "0x74282C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x742860", Offset = "0x742860", VA = "0x742860")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x74288C", Offset = "0x74288C", VA = "0x74288C")]
	public LevelCompleted()
	{
	}
}
[Token(Token = "0x2000035")]
public class LevelMovement : MonoBehaviour
{
	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_CurrYPos;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_AnimProgress;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Level;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_ForceLevel;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_LRotate;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_RRotate;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_ElevatorOff;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject m_Flor1ToHide;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject m_Flor2ToHide;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_Flor2ToScale;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_LeftRotator;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject m_RightRotator;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_1LevelY;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float m_2LevelY;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject m_Flor1ToRotate;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject m_Flor0ToChange;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float m_RotateAnimProgress;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] m_ToShowGeoms;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x74289C", Offset = "0x74289C", VA = "0x74289C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x74296C", Offset = "0x74296C", VA = "0x74296C")]
	private void UpdateRotators()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x742B20", Offset = "0x742B20", VA = "0x742B20")]
	private void Update()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x743554", Offset = "0x743554", VA = "0x743554")]
	private void ShowHideLevels(bool to_up)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x743604", Offset = "0x743604", VA = "0x743604")]
	public LevelMovement()
	{
	}
}
[Token(Token = "0x2000036")]
public class LightShaftMaker : MonoBehaviour
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshFilter;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x743620", Offset = "0x743620", VA = "0x743620")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x743944", Offset = "0x743944", VA = "0x743944")]
	public LightShaftMaker()
	{
	}
}
[Token(Token = "0x2000037")]
public class PlaylistItem
{
	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string title;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string track_id;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string notes;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float energy_index;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool local;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool navigation;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool directory;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool file;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int arena_id;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public MainMenu.EGameMode mode;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<string> program_titles;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<int> program_diff;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int pr_length;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int pr_bpm_min;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int pr_bpm_max;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int pr_hits;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int pr_slashes;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int pr_obstacles;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int pr_drones;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int pr_traps;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool group;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool random_program;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int start_group_index;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int end_group_index;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x74394C", Offset = "0x74394C", VA = "0x74394C")]
	public PlaylistItem()
	{
	}
}
[Token(Token = "0x2000038")]
public class MainMenu : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	public enum EGameMode
	{
		[Token(Token = "0x40002FF")]
		WarmUp,
		[Token(Token = "0x4000300")]
		Workout,
		[Token(Token = "0x4000301")]
		Intense,
		[Token(Token = "0x4000302")]
		Rocky,
		[Token(Token = "0x4000303")]
		Program,
		[Token(Token = "0x4000304")]
		MP3Old,
		[Token(Token = "0x4000305")]
		MP3_X,
		[Token(Token = "0x4000306")]
		Jabs,
		[Token(Token = "0x4000307")]
		Options,
		[Token(Token = "0x4000308")]
		Cannonade,
		[Token(Token = "0x4000309")]
		MP3_A,
		[Token(Token = "0x400030A")]
		MP3_B,
		[Token(Token = "0x400030B")]
		MP3_C,
		[Token(Token = "0x400030C")]
		WarmUp_DOff,
		[Token(Token = "0x400030D")]
		Workout_DOff,
		[Token(Token = "0x400030E")]
		Intense_DOff,
		[Token(Token = "0x400030F")]
		Count
	}

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR m_VR;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UITrack[] m_TrackListUI;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UITrack m_SampleTrackUI;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<List<PlaylistItem>> m_Lists;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PlaylistItem m_SelectedItem;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_SelectedIDX;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_SelListIDX;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_SelMP3PresetIDX;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text m_ProfileName;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text m_ProfileHeight;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text m_ProfileWeight;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text m_Length;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text m_BPM;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text m_HitNotes;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text m_SlashNotes;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text m_WallNotes;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text m_DroneNotes;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text m_Traps;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text m_EnergyIndex;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text m_SelClipTitle;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text m_FolderName;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Button[] m_ButtonLists;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Game m_Game;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject m_ExitContinue;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Sprite m_SelFoldSprite;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Sprite m_FoldSprite;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite m_SelItemSprite;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Sprite m_ItemSprite;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Button m_PlayButton;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Button m_A_PlayButton;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button m_B_PlayButton;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Button m_C_PlayButton;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Button m_ComposeButton;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Button m_EditProgramButton;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject m_ComposeSection;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text m_ComposeButtonName;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Statistic m_Statistics;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public TextAsset m_NotesFile;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public TextAsset m_ProgramsFile;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public AudioSource m_ClickSFX;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public ProgramListUI m_ProgramList;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool m_HUB;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameLeaderboard m_LeaderboardManager;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject m_MainLayout;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject m_ProgramLayout;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject m_CommonLayout;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject m_OptionsLayout;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Text m_TodayCal;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Text m_WeekCal;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Text m_MonthCal;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public GameObject m_ResetCenterText;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public GameObject m_HowToUseMP3;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public float m_AvHeight;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public ProfileInfo[] m_Profiles;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Sprite m_SpriteKG;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Sprite m_SpriteLBS;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Image m_UnitsImg;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public ScrollRect m_FolderScroll;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public RectTransform m_GenerateProgress;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Compositor m_Compositor;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Image m_SmallRoomImg;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Image m_SkullsImg;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Text m_HitSFXText;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public Image m_VibrationsImg;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public Image m_ShortDistanceImg;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public Image m_ElevatorImg;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public Image m_HorzObstImg;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public Image m_VertObstImg;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public Image m_InvTriggerImg;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Image m_InvColorsImg;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public Text m_PunchSFX;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Text m_SlashSFX;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public Sprite m_SpriteON;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public Sprite m_SpriteOFF;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Image[] m_ColorSchemes;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Sprite m_ColorSchemeOn;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public Sprite m_ColorSchemeOff;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public Image m_DimmImage;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public EqualizerEffect m_EqalizerEffect;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public Image m_HitDirImage;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public Image m_DronesComplexImage;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public GameObject m_RootButton;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public bool m_ProgramEditor;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public GameObject m_UILaserPoint;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public ColorSwitcher m_ColorSwitcher;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public TranslatorTool m_Translator;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public TranslatorTool m_Translator2;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public Text m_SMSText;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public TextAsset m_SMSEn;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public GameObject m_Up;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public GameObject m_Down;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public GameObject m_Remove;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public VRKeyboard m_Keyboard;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Image m_Arena1Img;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public Sprite m_Arena1SpriteON;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public Sprite m_Arena1SpriteOFF;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public Image m_Arena2Img;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public Sprite m_Arena2SpriteON;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public Sprite m_Arena2SpriteOFF;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public Image m_Arena3Img;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public Sprite m_Arena3SpriteON;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public Sprite m_Arena3SpriteOFF;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public Image m_Arena4Img;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public Sprite m_Arena4SpriteON;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public Sprite m_Arena4SpriteOFF;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public Image m_Arena5Img;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public Sprite m_Arena5SpriteON;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public Sprite m_Arena5SpriteOFF;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public Image m_Arena6Img;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public Sprite m_Arena6SpriteON;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public Sprite m_Arena6SpriteOFF;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public Text m_GlobalSynchroText;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public Image m_Icon_AAA;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public Image m_Icon_BBB;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public Image m_Icon_CCC;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	private float m_TimeToOpenArena;

	[Token(Token = "0x40002E8")]
	private const int NO_ARENAS = 6;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3AC")]
	public bool m_SetupCenterMode;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public float m_FPS;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
	private bool m_KeyboardActive;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	private int FirstUpdate;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
	private float TimeToRefreshButtons;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	private float pulse_time;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	private PlaylistItem m_EditedProgramItem;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private int m_EditedProgramItemIDx;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public Text m_ProgramName;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public GameObject LangGroup;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public Image LangImage;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	public Sprite[] LangSprites;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	private float m_TimeToRandomSMS;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public Sprite m_SelPanelSprite;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public Sprite m_PanelSprite;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	public GameObject m_GameplayPanel;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public GameObject m_SFXPanel;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	public Button m_GameplayButton;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public Button m_SFXButton;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	private bool m_GameplaypanaleSelected;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
	public int temp;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x743A34", Offset = "0x743A34", VA = "0x743A34")]
	public static bool IsMP3(EGameMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x743A64", Offset = "0x743A64", VA = "0x743A64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x7454C4", Offset = "0x7454C4", VA = "0x7454C4")]
	private void FirstInit()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x749BA8", Offset = "0x749BA8", VA = "0x749BA8")]
	private void SelectDefaultLanguage()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x749DCC", Offset = "0x749DCC", VA = "0x749DCC")]
	public void OnClickRandom()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x749A3C", Offset = "0x749A3C", VA = "0x749A3C")]
	public void OnGlobalSynchro(int delay)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x74A020", Offset = "0x74A020", VA = "0x74A020")]
	public void OnColorScheme(int i)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x74A0C8", Offset = "0x74A0C8", VA = "0x74A0C8")]
	public void OnDimColorScheme()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x74A174", Offset = "0x74A174", VA = "0x74A174")]
	public void OnHitDirArrow()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x74A220", Offset = "0x74A220", VA = "0x74A220")]
	public void OnDronesInComplex()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x748A4C", Offset = "0x748A4C", VA = "0x748A4C")]
	public void RefreshColorShemes()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x74A2E4", Offset = "0x74A2E4", VA = "0x74A2E4")]
	public void RandColorScheme()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x74A408", Offset = "0x74A408", VA = "0x74A408")]
	public void OnPlay(int preset_idx)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x74A678", Offset = "0x74A678", VA = "0x74A678")]
	private void StartProgram()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x7453C0", Offset = "0x7453C0", VA = "0x7453C0")]
	private void StartNextProgramTrack()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x74AEA4", Offset = "0x74AEA4", VA = "0x74AEA4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x74AF04", Offset = "0x74AF04", VA = "0x74AF04")]
	private void OpenArena()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x74B3A0", Offset = "0x74B3A0", VA = "0x74B3A0")]
	public PlaylistItem FindTrack(string track_id, int mode)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x7496B4", Offset = "0x7496B4", VA = "0x7496B4")]
	public int FindTrackIDX(string track_id, int mode)
	{
		return default(int);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x74A954", Offset = "0x74A954", VA = "0x74A954")]
	private bool SelectNextProgramTrack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x74A744", Offset = "0x74A744", VA = "0x74A744")]
	private void SetSelectedClipInfo(int preset)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x74BAC4", Offset = "0x74BAC4", VA = "0x74BAC4")]
	private void OnSelectedClip()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x7478E0", Offset = "0x7478E0", VA = "0x7478E0")]
	public void RefreshProfileStats()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x74BC20", Offset = "0x74BC20", VA = "0x74BC20")]
	public void OnReSetCenter()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x74BC58", Offset = "0x74BC58", VA = "0x74BC58")]
	public void OnChangeUnit()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x74BD08", Offset = "0x74BD08", VA = "0x74BD08")]
	public void OnChangeHitSFX()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x74BE90", Offset = "0x74BE90", VA = "0x74BE90")]
	public void OnChangeVibrations()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x74BF40", Offset = "0x74BF40", VA = "0x74BF40")]
	public void OnChangeShortDistanceMode()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x74C02C", Offset = "0x74C02C", VA = "0x74C02C")]
	public void OnChangeSkull()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x74C0DC", Offset = "0x74C0DC", VA = "0x74C0DC")]
	public void OnChangeElevator()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x74C18C", Offset = "0x74C18C", VA = "0x74C18C")]
	public void OnChangeHorizObstacles()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x74C23C", Offset = "0x74C23C", VA = "0x74C23C")]
	public void OnChangeVertObstacles()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x74C2EC", Offset = "0x74C2EC", VA = "0x74C2EC")]
	public void OnChangeTrigger()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x74C39C", Offset = "0x74C39C", VA = "0x74C39C")]
	public void OnChangeInvCollors()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x74C4A0", Offset = "0x74C4A0", VA = "0x74C4A0")]
	public void OnChangeSmallRoom()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x74C550", Offset = "0x74C550", VA = "0x74C550")]
	public void OnPunchSFX()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x74C69C", Offset = "0x74C69C", VA = "0x74C69C")]
	public void OnSlashSFX()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x74C7E8", Offset = "0x74C7E8", VA = "0x74C7E8")]
	public void OnSelectProfile(int profile_idx)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x74C86C", Offset = "0x74C86C", VA = "0x74C86C")]
	private EGameMode StringToMode(string name)
	{
		return default(EGameMode);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x74CAA8", Offset = "0x74CAA8", VA = "0x74CAA8")]
	private string ModeToString(EGameMode mode)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x743FA0", Offset = "0x743FA0", VA = "0x743FA0")]
	private void ReadNotes()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x74CC2C", Offset = "0x74CC2C", VA = "0x74CC2C")]
	public void SaveProgramsLog()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x744844", Offset = "0x744844", VA = "0x744844")]
	private void ReadPrograms()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x74CFAC", Offset = "0x74CFAC", VA = "0x74CFAC")]
	private void ParseStats(ref PlaylistItem item, string config)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x749FF0", Offset = "0x749FF0", VA = "0x749FF0")]
	public void PlayClick()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x74D324", Offset = "0x74D324", VA = "0x74D324")]
	public void OnTutorial()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x74D3A8", Offset = "0x74D3A8", VA = "0x74D3A8")]
	public void OnHowToUseMP3()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x74D42C", Offset = "0x74D42C", VA = "0x74D42C")]
	private void RefreshProgramStats()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x746BBC", Offset = "0x746BBC", VA = "0x746BBC")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x74D7F8", Offset = "0x74D7F8", VA = "0x74D7F8")]
	public void OnSelectTrack(UITrack track)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x748CC4", Offset = "0x748CC4", VA = "0x748CC4")]
	public void OnSelectList(int idx)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x748784", Offset = "0x748784", VA = "0x748784")]
	private void RefreshLayout()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x748FD4", Offset = "0x748FD4", VA = "0x748FD4")]
	public void OnSelect(int idx, bool on_start = false)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x747420", Offset = "0x747420", VA = "0x747420")]
	private void RefreshTrackList()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x74DD4C", Offset = "0x74DD4C", VA = "0x74DD4C")]
	public void OnDownload()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x74DE20", Offset = "0x74DE20", VA = "0x74DE20")]
	public void OnMusic()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x74DEF4", Offset = "0x74DEF4", VA = "0x74DEF4")]
	public void OnRoot()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x74DFC0", Offset = "0x74DFC0", VA = "0x74DFC0")]
	public void OnExit()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x74DFC8", Offset = "0x74DFC8", VA = "0x74DFC8")]
	public void OnCompose()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x74E10C", Offset = "0x74E10C", VA = "0x74E10C")]
	private void UpdateHeight()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x74E300", Offset = "0x74E300", VA = "0x74E300")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x74D814", Offset = "0x74D814", VA = "0x74D814")]
	private void RefreshPlayButtons(bool force)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x74EB48", Offset = "0x74EB48", VA = "0x74EB48")]
	public void OnSelectMP3PresetIDX(int idx)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x74B4C8", Offset = "0x74B4C8", VA = "0x74B4C8")]
	private void ReadMP3SelNotes(string track_id, int preset_idx)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x74E83C", Offset = "0x74E83C", VA = "0x74E83C")]
	private void UpdateComposeProgress()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x74E668", Offset = "0x74E668", VA = "0x74E668")]
	private void UpdatePulseCompositor()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x74F018", Offset = "0x74F018", VA = "0x74F018")]
	public void OnEditProgram()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x74F118", Offset = "0x74F118", VA = "0x74F118")]
	public void OnCancelProgram()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x749DE4", Offset = "0x749DE4", VA = "0x749DE4")]
	public void OnRefreshEditedProgram()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x749538", Offset = "0x749538", VA = "0x749538")]
	private void ReadEditedProgram()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x74F194", Offset = "0x74F194", VA = "0x74F194")]
	public void OnAddToProgram(int preset_idx)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x74F480", Offset = "0x74F480", VA = "0x74F480")]
	public void OnSelectProgramTrack(ProgramItemUI track)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x74F478", Offset = "0x74F478", VA = "0x74F478")]
	public void OnSelectProgramTrack(int idx)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x74F49C", Offset = "0x74F49C", VA = "0x74F49C")]
	public void OnRemoveProgramTrack()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x74F560", Offset = "0x74F560", VA = "0x74F560")]
	public void OnUpProgramTrack()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x74F72C", Offset = "0x74F72C", VA = "0x74F72C")]
	public void OnDownProgramTrack()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x74F8F8", Offset = "0x74F8F8", VA = "0x74F8F8")]
	private void CalculateProgramStats()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x74FA94", Offset = "0x74FA94", VA = "0x74FA94")]
	public void OnChangeProgramName()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x74FB34", Offset = "0x74FB34", VA = "0x74FB34")]
	public void OnSaveProgram()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x7497A8", Offset = "0x7497A8", VA = "0x7497A8")]
	public void RefreshScenes()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x7508B0", Offset = "0x7508B0", VA = "0x7508B0")]
	public void OnChangeScenes(int idx)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x750960", Offset = "0x750960", VA = "0x750960")]
	public void OnLanguage()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x7509EC", Offset = "0x7509EC", VA = "0x7509EC")]
	public void OnSelectLanguage(int idx)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x74E9A0", Offset = "0x74E9A0", VA = "0x74E9A0")]
	private void RandomSMSText()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x750BB0", Offset = "0x750BB0", VA = "0x750BB0")]
	public void OnSFXPanel()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x749940", Offset = "0x749940", VA = "0x749940")]
	public void OnGameplayPanel()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x745EA8", Offset = "0x745EA8", VA = "0x745EA8")]
	private void OpenDirectory(string path, int channel, int min_index, int max_index)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x750CA8", Offset = "0x750CA8", VA = "0x750CA8")]
	private int FillFiles(string path, int channel, FileInfo[] fileinfo, int no_records)
	{
		return default(int);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x751640", Offset = "0x751640", VA = "0x751640")]
	private int FillGroupFiles(int channel, FileInfo[] fileinfo, int no_records, int min_index, int max_index)
	{
		return default(int);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x7519E4", Offset = "0x7519E4", VA = "0x7519E4")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x751A88", Offset = "0x751A88", VA = "0x751A88")]
	public void OpenOculusStoreDeepLink()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x751A8C", Offset = "0x751A8C", VA = "0x751A8C")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x200003A")]
public class Marker : MonoBehaviour
{
	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Yellow;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_ShiftAlpha;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_Alpha;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Game m_Game;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_Dir;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool m_Wall;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_StartYAngle;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Inactive;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool m_Cut;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool m_Bomb;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool m_Block;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_BombIcon;

	[Token(Token = "0x400031E")]
	public const float RADIUS = 0.4f;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_Sliced;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float m_MusicTime;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_NoTestToFail;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool m_Cannon;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 m_OrginalScale;

	[Token(Token = "0x4000324")]
	private const float REFLEX_MODE_PROGESS = 0.9f;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int m_NoBadColls;

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x752BA4", Offset = "0x752BA4", VA = "0x752BA4")]
	private void UpdatePunch()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x753A40", Offset = "0x753A40", VA = "0x753A40")]
	private void OnPuchHit(Glove glove)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x753E60", Offset = "0x753E60", VA = "0x753E60")]
	public void SetBomb()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x753E8C", Offset = "0x753E8C", VA = "0x753E8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x754534", Offset = "0x754534", VA = "0x754534")]
	private void UpdateWallColl()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x75550C", Offset = "0x75550C", VA = "0x75550C")]
	private bool UpdateCutColl(Glove glove, ref bool near)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x754C3C", Offset = "0x754C3C", VA = "0x754C3C")]
	private void UpdateDisc()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x754CC0", Offset = "0x754CC0", VA = "0x754CC0")]
	private void UpdateBlock()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x7550CC", Offset = "0x7550CC", VA = "0x7550CC")]
	private void UpdateTask(float progress)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x755224", Offset = "0x755224", VA = "0x755224")]
	private void UpdateScale()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x7541B0", Offset = "0x7541B0", VA = "0x7541B0")]
	private void UpdatePosition(float progress)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x7563E4", Offset = "0x7563E4", VA = "0x7563E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x75638C", Offset = "0x75638C", VA = "0x75638C")]
	private float GetTiming()
	{
		return default(float);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x752F44", Offset = "0x752F44", VA = "0x752F44")]
	private bool OnPassPunch(Glove glove, float dot, Vector3 speed)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x755410", Offset = "0x755410", VA = "0x755410")]
	private void OnWall()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x753C64", Offset = "0x753C64", VA = "0x753C64")]
	private void OnBomb(bool right)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x753E2C", Offset = "0x753E2C", VA = "0x753E2C")]
	private void OnFail(bool right)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x75533C", Offset = "0x75533C", VA = "0x75533C")]
	private void OnTimeOut(bool right)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x7539D4", Offset = "0x7539D4", VA = "0x7539D4")]
	private void Destroy()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x7560F8", Offset = "0x7560F8", VA = "0x7560F8")]
	private void PlayFX(string name, Vector3 pos, Quaternion rot, float scale = 1f)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x7566F0", Offset = "0x7566F0", VA = "0x7566F0")]
	public Marker()
	{
	}
}
[Token(Token = "0x200003B")]
public class NoteInfo : MonoBehaviour
{
	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Tact;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Note;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_FPS;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Game m_Game;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float FPS;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x756758", Offset = "0x756758", VA = "0x756758")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7567D0", Offset = "0x7567D0", VA = "0x7567D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x7568D4", Offset = "0x7568D4", VA = "0x7568D4")]
	public NoteInfo()
	{
	}
}
[Token(Token = "0x200003C")]
public class ProfileInfo : MonoBehaviour
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_AutoText;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_HeightText;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_MassText;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_TodayCal;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_WeekCal;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text m_MonthCal;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text m_ProfileName;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int m_ProfileIDX;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MainMenu m_Menu;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sprite m_NormalSprite;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sprite m_SelSprite;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool m_KeyboardActive;

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x7568E4", Offset = "0x7568E4", VA = "0x7568E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x757004", Offset = "0x757004", VA = "0x757004")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x756964", Offset = "0x756964", VA = "0x756964")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x757278", Offset = "0x757278", VA = "0x757278")]
	public void OnIncraseWeight()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x757404", Offset = "0x757404", VA = "0x757404")]
	public void OnDecraseWeight()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x757590", Offset = "0x757590", VA = "0x757590")]
	public void OnIncraseHeight()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x757710", Offset = "0x757710", VA = "0x757710")]
	public void OnDecraseHeight()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x757894", Offset = "0x757894", VA = "0x757894")]
	public void OnAutoManual()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x7579E4", Offset = "0x7579E4", VA = "0x7579E4")]
	public void OnChangeName()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x757AB4", Offset = "0x757AB4", VA = "0x757AB4")]
	public void OnSelectProfil()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x757AE8", Offset = "0x757AE8", VA = "0x757AE8")]
	public ProfileInfo()
	{
	}
}
[Token(Token = "0x200003D")]
public class ProgramItemUI : MonoBehaviour
{
	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_TrackName;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image m_Icon;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Index;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x757AF0", Offset = "0x757AF0", VA = "0x757AF0")]
	public ProgramItemUI()
	{
	}
}
[Token(Token = "0x200003E")]
public class ProgramListUI : MonoBehaviour
{
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] m_Icons;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color[] m_Colors;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProgramItemUI m_SampleItem;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProgramItemUI[] m_Items;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ScrollRect m_FolderScroll;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite m_SpriteCheckOn;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite m_SpriteCheckOff;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image m_RandomImages;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_Wait;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_SetupScroll;

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x757AF8", Offset = "0x757AF8", VA = "0x757AF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x757B40", Offset = "0x757B40", VA = "0x757B40")]
	public void RefreshProgramList(PlaylistItem program, MainMenu menu, int edited_program_item_idx = -1)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x7580D8", Offset = "0x7580D8", VA = "0x7580D8")]
	public ProgramListUI()
	{
	}
}
[Token(Token = "0x200003F")]
public class GameLeaderboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000040")]
	private sealed class <>c
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Message<PlatformInitializeResult>.Handler <>9__13_0;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x7597E8", Offset = "0x7597E8", VA = "0x7597E8")]
		public <>c()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x7597F0", Offset = "0x7597F0", VA = "0x7597F0")]
		internal void <Start>b__13_0(Message<PlatformInitializeResult> m)
		{
		}
	}

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LBResult m_SampleResult;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LBResult[] m_Results;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform m_ScrolTransform;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite m_SelSprite;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite m_Sprite;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button m_FriendsButton;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button m_OverallButton;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SortedDictionary<int, LeaderboardEntry> m_HighScores;

	[Token(Token = "0x400034C")]
	private const int NO_REULTS = 10;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string m_LB_ID;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_FriendsMode;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int request_delay;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int first_request_delay;

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x7580E8", Offset = "0x7580E8", VA = "0x7580E8")]
	public void OnFriends()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x758328", Offset = "0x758328", VA = "0x758328")]
	public void OnOverall()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x758330", Offset = "0x758330", VA = "0x758330")]
	private void Start()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x7586E4", Offset = "0x7586E4", VA = "0x7586E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x7584BC", Offset = "0x7584BC", VA = "0x7584BC")]
	private void FillEmpty()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x75893C", Offset = "0x75893C", VA = "0x75893C")]
	public void OnHighLeaderboardUpdated()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x758C20", Offset = "0x758C20", VA = "0x758C20")]
	public void OnNearLeaderboardUpdated()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x758730", Offset = "0x758730", VA = "0x758730")]
	private void QueryHighScoreLeaderboard()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x758F58", Offset = "0x758F58", VA = "0x758F58")]
	private void MostScoreGetEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x759280", Offset = "0x759280", VA = "0x759280")]
	private void AroundGetEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7580F4", Offset = "0x7580F4", VA = "0x7580F4")]
	public void RefreshScore()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x759514", Offset = "0x759514", VA = "0x759514")]
	public void UpdateScoreInternal()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x759714", Offset = "0x759714", VA = "0x759714")]
	public GameLeaderboard()
	{
	}
}
[Token(Token = "0x2000041")]
public class LBResult : MonoBehaviour
{
	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_LP;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_UserName;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_Score;

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x759964", Offset = "0x759964", VA = "0x759964")]
	public LBResult()
	{
	}
}
[Token(Token = "0x2000042")]
public class RecenterUI : MonoBehaviour
{
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR m_VR;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_Time;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material m_CircleMat;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_SetupIcon;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_UseIcon;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool m_SetupMode;

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x75996C", Offset = "0x75996C", VA = "0x75996C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x7599E4", Offset = "0x7599E4", VA = "0x7599E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x75A014", Offset = "0x75A014", VA = "0x75A014")]
	public RecenterUI()
	{
	}
}
[Token(Token = "0x2000043")]
public class ReflectionCamera : MonoBehaviour
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR m_VR;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera m_Cam;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material m_ArenaMat;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_ArenaMat2;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x75A01C", Offset = "0x75A01C", VA = "0x75A01C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x75A0C4", Offset = "0x75A0C4", VA = "0x75A0C4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x75A3EC", Offset = "0x75A3EC", VA = "0x75A3EC")]
	public ReflectionCamera()
	{
	}
}
[Token(Token = "0x2000044")]
public class RingEffect : MonoBehaviour
{
	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_NoBands;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] m_SpecVis;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x75A3F4", Offset = "0x75A3F4", VA = "0x75A3F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x75A4DC", Offset = "0x75A4DC", VA = "0x75A4DC")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x75A9DC", Offset = "0x75A9DC", VA = "0x75A9DC")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x75AE84", Offset = "0x75AE84", VA = "0x75AE84")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x75AF24", Offset = "0x75AF24", VA = "0x75AF24")]
	private void Update()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x75B22C", Offset = "0x75B22C", VA = "0x75B22C")]
	public RingEffect()
	{
	}
}
[Token(Token = "0x2000045")]
public class RythmAnalizer : MonoBehaviour
{
	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource m_AudioSource;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_Box;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] m_Spectrum;

	[Token(Token = "0x4000368")]
	private const int NO_BANDS = 6;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] m_Averages;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_Vis;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject[] m_Beats;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool[] m_Beat;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int[] m_NoUp;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int[] m_NoDown;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] m_TopChange;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] m_TopTime;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float[] m_LastBeatTime;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject[] m_Line;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float m_Change;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float m_ChangeDown;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float m_BeatLevel;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float[] m_Markers;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float m_PrevBeatTime;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int m_BPM;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float[] m_Probality;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int m_PrevBeatIDX;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int TESTED_CHANNEL;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Game m_Game;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x75B298", Offset = "0x75B298", VA = "0x75B298")]
	private void Update()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x75B7C8", Offset = "0x75B7C8", VA = "0x75B7C8")]
	public void OnBeat(float time)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x75BA9C", Offset = "0x75BA9C", VA = "0x75BA9C")]
	private void Visualize(int idx, float power)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x75B46C", Offset = "0x75B46C", VA = "0x75B46C")]
	private float MarkBeats()
	{
		return default(float);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x75BBCC", Offset = "0x75BBCC", VA = "0x75BBCC")]
	private void MarkBeat(float time, float value)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x75BB58", Offset = "0x75BB58", VA = "0x75BB58")]
	private int FindBPM()
	{
		return default(int);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x75BAA0", Offset = "0x75BAA0", VA = "0x75BAA0")]
	private void FillBeatsProb(int bpm, float val)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x75BCB8", Offset = "0x75BCB8", VA = "0x75BCB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x75BD70", Offset = "0x75BD70", VA = "0x75BD70")]
	public RythmAnalizer()
	{
	}
}
[Token(Token = "0x2000046")]
public class SabreTrail : MonoBehaviour
{
	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 m_APos;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 m_BPos;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] m_Verts;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Mesh mesh;

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x75BF9C", Offset = "0x75BF9C", VA = "0x75BF9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x75C2F4", Offset = "0x75C2F4", VA = "0x75C2F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x75C42C", Offset = "0x75C42C", VA = "0x75C42C")]
	public SabreTrail()
	{
	}
}
[Token(Token = "0x2000047")]
public class Shield : MonoBehaviour
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_Width;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int m_Height;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshFilter m_FrameMesh;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommonVR m_VR;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool m_Yellow;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool m_WasTrigger;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_BlueFrameMat;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material m_YellowFrameMat;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material m_BlueMat;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material m_YellowMat;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x75C434", Offset = "0x75C434", VA = "0x75C434")]
	private void Start()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x75D0F4", Offset = "0x75D0F4", VA = "0x75D0F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x75D200", Offset = "0x75D200", VA = "0x75D200")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x75C550", Offset = "0x75C550", VA = "0x75C550")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x75CB10", Offset = "0x75CB10", VA = "0x75CB10")]
	private void GenerateFrame()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x75D5C4", Offset = "0x75D5C4", VA = "0x75D5C4")]
	private static void Sculptor(int no_tris, Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x75D7E8", Offset = "0x75D7E8", VA = "0x75D7E8")]
	private void GenerateFrame(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x75D990", Offset = "0x75D990", VA = "0x75D990")]
	private static int MakeFrameSeg(Vector3[] vertices, int idx, Vector3 beg, Vector3 end)
	{
		return default(int);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x75D318", Offset = "0x75D318", VA = "0x75D318")]
	private void GenerateNet(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x75DF34", Offset = "0x75DF34", VA = "0x75DF34")]
	public Shield()
	{
	}
}
[Token(Token = "0x2000048")]
public class ShieldMaker : MonoBehaviour
{
	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x75DF44", Offset = "0x75DF44", VA = "0x75DF44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x75E584", Offset = "0x75E584", VA = "0x75E584")]
	public ShieldMaker()
	{
	}
}
[Token(Token = "0x2000049")]
public class Slicer : MonoBehaviour
{
	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_SlicePos;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion m_SliceRot;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 m_SliceUp;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_SliceForward;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_Top;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_Bottom;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject m_Core;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float m_Time;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool m_BadDir;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x75E58C", Offset = "0x75E58C", VA = "0x75E58C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x755CC8", Offset = "0x755CC8", VA = "0x755CC8")]
	public void SetBladeTransform(Transform cut_transform, Vector3 curr_speed, bool bad_dir)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x75E6B0", Offset = "0x75E6B0", VA = "0x75E6B0")]
	private void Slice(GameObject vis, bool top)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x75EA44", Offset = "0x75EA44", VA = "0x75EA44")]
	private void Update()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x75EEA8", Offset = "0x75EEA8", VA = "0x75EEA8")]
	public Slicer()
	{
	}
}
[Token(Token = "0x200004A")]
public class SongInfo : MonoBehaviour
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Length;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_TitleName;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_ProgramInfo;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_NoSecToEnd;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Game m_Game;

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x75EEB0", Offset = "0x75EEB0", VA = "0x75EEB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x75F028", Offset = "0x75F028", VA = "0x75F028")]
	private void Update()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x75F17C", Offset = "0x75F17C", VA = "0x75F17C")]
	public SongInfo()
	{
	}
}
[Token(Token = "0x200004B")]
public class SphereMaker : MonoBehaviour
{
	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshFilter;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x75F184", Offset = "0x75F184", VA = "0x75F184")]
	private void Start()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x75F7C4", Offset = "0x75F7C4", VA = "0x75F7C4")]
	public SphereMaker()
	{
	}
}
[Token(Token = "0x200004C")]
public class Statistic : MonoBehaviour
{
	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_HighScore;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Score;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_Combo;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_Hits;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_Misses;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text m_Energy;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text m_HitSpeedL;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text m_HitSpeedR;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text m_AvgSpeedL;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text m_AvgSpeedR;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text m_HitAccuL;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text m_HitAccuR;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text m_HitTimL;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text m_HitTimR;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text m_SlashAccuL;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text m_SlashAccuR;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text m_SlashTimL;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text m_SlashTimR;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text m_ShotSmashL;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text m_ShotSmashR;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text m_SuccDodging;

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x75F7CC", Offset = "0x75F7CC", VA = "0x75F7CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x75F7D0", Offset = "0x75F7D0", VA = "0x75F7D0")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x76038C", Offset = "0x76038C", VA = "0x76038C")]
	public Statistic()
	{
	}
}
[Token(Token = "0x200004D")]
public class Track : MonoBehaviour
{
	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string m_ID;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string m_Title;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_Artist;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_StartShift;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] m_Sequences;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x760394", Offset = "0x760394", VA = "0x760394")]
	public Track()
	{
	}
}
[Token(Token = "0x200004E")]
public class TranslatorTool : MonoBehaviour
{
	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] m_Text;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] m_ID;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextAsset m_EnTranslateFile;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAsset m_CnTranslateFile;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset m_JpTranslateFile;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset m_KrTranslateFile;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset m_FrTranslateFile;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset m_CzTranslateFile;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextAsset m_DeTranslateFile;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextAsset m_SpTranslateFile;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextAsset m_PtTranslateFile;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAsset m_ThTranslateFile;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextAsset m_PlTranslateFile;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<string>> m_Translate;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x76039C", Offset = "0x76039C", VA = "0x76039C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x760BCC", Offset = "0x760BCC", VA = "0x760BCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x760870", Offset = "0x760870", VA = "0x760870")]
	private void ReadTransalte(TextAsset translate_file)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x760BD0", Offset = "0x760BD0", VA = "0x760BD0")]
	public void SetupLanguage()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x760C4C", Offset = "0x760C4C", VA = "0x760C4C")]
	private void SetupLanguage(int lang_idx)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x760DA8", Offset = "0x760DA8", VA = "0x760DA8")]
	public string Translate(string text)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x760F44", Offset = "0x760F44", VA = "0x760F44")]
	public TranslatorTool()
	{
	}
}
[Token(Token = "0x200004F")]
public class Turret : MonoBehaviour
{
	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_Alive;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game m_Game;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_ToShootProgress;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private EnemyBullet[] m_Bullets;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 m_TargetSpeed;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] m_LasersDeviations;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform[] m_LaserTags;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform[] m_LaserFlats;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject m_Target;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_Seed;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float m_BulletsSpeed;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_Slomo;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int m_SourceID;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool m_Pistol;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool m_AimSoundPlayed;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool m_ShootSoundPlayed;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject m_HeadLaserSpot;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x760FCC", Offset = "0x760FCC", VA = "0x760FCC")]
	public bool IsReadyToShoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x760FE0", Offset = "0x760FE0", VA = "0x760FE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x761100", Offset = "0x761100", VA = "0x761100")]
	public void OnKill()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x7611C8", Offset = "0x7611C8", VA = "0x7611C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x761270", Offset = "0x761270", VA = "0x761270")]
	private void Start()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x761374", Offset = "0x761374", VA = "0x761374")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x761414", Offset = "0x761414", VA = "0x761414")]
	private void UpdateBullets()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x761894", Offset = "0x761894", VA = "0x761894")]
	private void UpdateAming()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x761B10", Offset = "0x761B10", VA = "0x761B10")]
	private void UpdateTurret()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x762D34", Offset = "0x762D34", VA = "0x762D34")]
	public void InitShooting(GameObject target, int seed)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x762068", Offset = "0x762068", VA = "0x762068")]
	private void UpdateLaserTags()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x761A70", Offset = "0x761A70", VA = "0x761A70")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x763374", Offset = "0x763374", VA = "0x763374")]
	public Turret()
	{
	}
}
[Token(Token = "0x2000050")]
public class Tutorial : MonoBehaviour
{
	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_AnimProgress;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rec_transform;

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x764404", Offset = "0x764404", VA = "0x764404")]
	private void Start()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x76445C", Offset = "0x76445C", VA = "0x76445C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x764464", Offset = "0x764464", VA = "0x764464")]
	private void Update()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x764570", Offset = "0x764570", VA = "0x764570")]
	public Tutorial()
	{
	}
}
[Token(Token = "0x2000051")]
public class UITrack : MonoBehaviour
{
	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text track_name;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string track_id;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject main_ui;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int idx;

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x764578", Offset = "0x764578", VA = "0x764578")]
	public UITrack()
	{
	}
}
[Token(Token = "0x2000052")]
public class URLPlayer : MonoBehaviour
{
	[Token(Token = "0x2000053")]
	private sealed class <GrabWWWTexture>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public URLPlayer <>4__this;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x764928", Offset = "0x764928", VA = "0x764928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x764970", Offset = "0x764970", VA = "0x764970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x764614", Offset = "0x764614", VA = "0x764614")]
		[DebuggerHidden]
		public <GrabWWWTexture>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x764694", Offset = "0x764694", VA = "0x764694", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x764698", Offset = "0x764698", VA = "0x764698", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x764930", Offset = "0x764930", VA = "0x764930", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string url;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x764580", Offset = "0x764580", VA = "0x764580")]
	private void Start()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x7645A0", Offset = "0x7645A0", VA = "0x7645A0")]
	private IEnumerator GrabWWWTexture()
	{
		return null;
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x76463C", Offset = "0x76463C", VA = "0x76463C")]
	public URLPlayer()
	{
	}
}
[Token(Token = "0x2000054")]
public class VideoBeats : MonoBehaviour
{
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer m_VideoPlayer;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_PrevHit;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_Speed;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_TargetSpeed;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_FreeTime;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x764978", Offset = "0x764978", VA = "0x764978")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x764A20", Offset = "0x764A20", VA = "0x764A20")]
	public VideoBeats()
	{
	}
}
[Token(Token = "0x2000055")]
public class WindEffect : MonoBehaviour
{
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_Width;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_Height;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_SphereMat;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Game m_Game;

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x764A38", Offset = "0x764A38", VA = "0x764A38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x76583C", Offset = "0x76583C", VA = "0x76583C")]
	private void Update()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x764B20", Offset = "0x764B20", VA = "0x764B20")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x765B28", Offset = "0x765B28", VA = "0x765B28")]
	public WindEffect()
	{
	}
}
[Token(Token = "0x2000056")]
public class CommonVR : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	public enum FFType
	{
		[Token(Token = "0x4000401")]
		Positive,
		[Token(Token = "0x4000402")]
		Negative,
		[Token(Token = "0x4000403")]
		Reloaded,
		[Token(Token = "0x4000404")]
		Damage
	}

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CommonVR Instance;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_PicoVR;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Pointer m_LeftPointer;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Pointer m_RightPointer;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Pointer m_ForwardPointer;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera m_Camera;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_VibrationsOff;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool m_Blackout;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject m_BlackoutQuad;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MainMenu m_MainMenu;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_MenuWasPressed;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool m_MenuPressedNow;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_BlackoutScale;

	[Token(Token = "0x1700001E")]
	public bool UpPressed
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x766F48", Offset = "0x766F48", VA = "0x766F48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public bool DownPressed
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x767090", Offset = "0x767090", VA = "0x767090")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x765B3C", Offset = "0x765B3C", VA = "0x765B3C")]
	public void RestoreHandsAnimators()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x765B54", Offset = "0x765B54", VA = "0x765B54")]
	public void RestoreLHandAnimator()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x765D3C", Offset = "0x765D3C", VA = "0x765D3C")]
	public void RestoreRHandAnimator()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x765F24", Offset = "0x765F24", VA = "0x765F24")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x766094", Offset = "0x766094", VA = "0x766094")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x76609C", Offset = "0x76609C", VA = "0x76609C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x766200", Offset = "0x766200", VA = "0x766200")]
	private void Update()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x766808", Offset = "0x766808", VA = "0x766808")]
	public bool IsMenuPressedNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x766308", Offset = "0x766308", VA = "0x766308")]
	public bool IsMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x766810", Offset = "0x766810", VA = "0x766810")]
	public bool IsAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x766818", Offset = "0x766818", VA = "0x766818")]
	public bool IsSteam()
	{
		return default(bool);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x766820", Offset = "0x766820", VA = "0x766820")]
	public void ForceFeedback(bool right_hand, FFType type)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x7667A0", Offset = "0x7667A0", VA = "0x7667A0")]
	public bool IsTriggerPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x766844", Offset = "0x766844", VA = "0x766844")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7669D0", Offset = "0x7669D0", VA = "0x7669D0")]
	public Vector3 GetLHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x766AB0", Offset = "0x766AB0", VA = "0x766AB0")]
	public Vector3 GetRHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x766B90", Offset = "0x766B90", VA = "0x766B90")]
	public Vector3 GetLHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x766C70", Offset = "0x766C70", VA = "0x766C70")]
	public Vector3 GetRHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x766404", Offset = "0x766404", VA = "0x766404")]
	public Vector3 GetPointerPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x766D50", Offset = "0x766D50", VA = "0x766D50")]
	public Vector3 GetPointerRot()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7665D0", Offset = "0x7665D0", VA = "0x7665D0")]
	public Vector3 GetPointerDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x766EF0", Offset = "0x766EF0", VA = "0x766EF0")]
	public Vector3 GetHeadPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x766F18", Offset = "0x766F18", VA = "0x766F18")]
	public Vector3 GetHeadDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x766F40", Offset = "0x766F40", VA = "0x766F40")]
	public bool IsHQVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7671D8", Offset = "0x7671D8", VA = "0x7671D8")]
	public CommonVR()
	{
	}
}
[Token(Token = "0x2000058")]
public class Pointer : MonoBehaviour
{
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_ForceFeedback;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool m_Left;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator m_HandAnimator;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_IsTrigger;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool m_ForwardPointer;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CommonVR m_CommonVR;

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x766934", Offset = "0x766934", VA = "0x766934")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x7671E8", Offset = "0x7671E8", VA = "0x7671E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x7672A4", Offset = "0x7672A4", VA = "0x7672A4")]
	public Pointer()
	{
	}
}
[Token(Token = "0x2000059")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x7672AC", Offset = "0x7672AC", VA = "0x7672AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x7674C8", Offset = "0x7674C8", VA = "0x7674C8")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x200005A")]
public class CUI_MoveHeartbeat : MonoBehaviour
{
	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool wrapAroundParent;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectie;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform parentRectie;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x7674D0", Offset = "0x7674D0", VA = "0x7674D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x7675AC", Offset = "0x7675AC", VA = "0x7675AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7676CC", Offset = "0x7676CC", VA = "0x7676CC")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x200005B")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x7676DC", Offset = "0x7676DC", VA = "0x7676DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x7678C0", Offset = "0x7678C0", VA = "0x7678C0")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x200005C")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x7678C8", Offset = "0x7678C8", VA = "0x7678C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x767998", Offset = "0x767998", VA = "0x767998")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x200005D")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7679A0", Offset = "0x7679A0", VA = "0x7679A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x767A20", Offset = "0x767A20", VA = "0x767A20")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x767AD4", Offset = "0x767AD4", VA = "0x767AD4")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x200005E")]
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	[Token(Token = "0x200005F")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x4000431")]
		MOUSE = 0,
		[Token(Token = "0x4000432")]
		GAZE = 1,
		[Token(Token = "0x4000433")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x4000434")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x4000435")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x4000436")]
		OCULUSVR = 5,
		[Token(Token = "0x4000437")]
		STEAMVR_2 = 8,
		[Token(Token = "0x4000438")]
		UNITY_XR = 9
	}

	[Token(Token = "0x2000060")]
	public enum Hand
	{
		[Token(Token = "0x400043A")]
		Both,
		[Token(Token = "0x400043B")]
		Right,
		[Token(Token = "0x400043C")]
		Left
	}

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Camera mainEventCamera;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LayerMask raycastLayerMask;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform pointerTransformOverride;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject currentDragging;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject m_rightController;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject m_leftController;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float gazeTimerProgress;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Ray customControllerRay;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float dragThreshold;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool pressedDown;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	private bool pressedLastFrame;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector2 lastEventDataPosition;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private PointerInputModule.MouseButtonEventData storedData;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private XRBaseController rightXRController;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private XRBaseController leftXRController;

	[Token(Token = "0x17000020")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x769BDC", Offset = "0x769BDC", VA = "0x769BDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x769CD0", Offset = "0x769CD0", VA = "0x769CD0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public static bool CanInstanceBeAccessed
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x769D30", Offset = "0x769D30", VA = "0x769D30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x767D08", Offset = "0x767D08", VA = "0x767D08")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x769DB8", Offset = "0x769DB8", VA = "0x769DB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public LayerMask RaycastLayerMask
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x769E3C", Offset = "0x769E3C", VA = "0x769E3C")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x769E44", Offset = "0x769E44", VA = "0x769E44")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Hand UsedHand
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x769E4C", Offset = "0x769E4C", VA = "0x769E4C")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x769E54", Offset = "0x769E54", VA = "0x769E54")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x769914", Offset = "0x769914", VA = "0x769914")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x769EC0", Offset = "0x769EC0", VA = "0x769EC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000027")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x769EDC", Offset = "0x769EDC", VA = "0x769EDC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000028")]
	public Transform PointerTransformOverride
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x769E5C", Offset = "0x769E5C", VA = "0x769E5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x769EF8", Offset = "0x769EF8", VA = "0x769EF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x769F64", Offset = "0x769F64", VA = "0x769F64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public Camera EventCamera
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x769F6C", Offset = "0x769F6C", VA = "0x769F6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x767C58", Offset = "0x767C58", VA = "0x767C58")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public static Vector2 MousePosition
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x76A1B0", Offset = "0x76A1B0", VA = "0x76A1B0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool LeftMouseButton
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x76A298", Offset = "0x76A298", VA = "0x76A298")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x76A22C", Offset = "0x76A22C", VA = "0x76A22C")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x76671C", Offset = "0x76671C", VA = "0x76671C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x76A2EC", Offset = "0x76A2EC", VA = "0x76A2EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x7667A4", Offset = "0x7667A4", VA = "0x7667A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	[Obsolete("Use CustomControllerButtonState instead.")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x76A348", Offset = "0x76A348", VA = "0x76A348")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x76A394", Offset = "0x76A394", VA = "0x76A394")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x76A3E8", Offset = "0x76A3E8", VA = "0x76A3E8")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x76A3F0", Offset = "0x76A3F0", VA = "0x76A3F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x76A3FC", Offset = "0x76A3FC", VA = "0x76A3FC")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000032")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x76A410", Offset = "0x76A410", VA = "0x76A410")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x76A418", Offset = "0x76A418", VA = "0x76A418")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x76A420", Offset = "0x76A420", VA = "0x76A420")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x76A428", Offset = "0x76A428", VA = "0x76A428")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public float GazeClickTimer
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x76A434", Offset = "0x76A434", VA = "0x76A434")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x76A43C", Offset = "0x76A43C", VA = "0x76A43C")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x76A44C", Offset = "0x76A44C", VA = "0x76A44C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x76A454", Offset = "0x76A454", VA = "0x76A454")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x76A464", Offset = "0x76A464", VA = "0x76A464")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000037")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x76A46C", Offset = "0x76A46C", VA = "0x76A46C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x76A474", Offset = "0x76A474", VA = "0x76A474")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public XRBaseController RightXRController
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x76A47C", Offset = "0x76A47C", VA = "0x76A47C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x76A484", Offset = "0x76A484", VA = "0x76A484")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public XRBaseController LeftXRController
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x76A494", Offset = "0x76A494", VA = "0x76A494")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x76A49C", Offset = "0x76A49C", VA = "0x76A49C")]
		set
		{
		}
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x767ADC", Offset = "0x767ADC", VA = "0x767ADC", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x767F14", Offset = "0x767F14", VA = "0x767F14", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x767F40", Offset = "0x767F40", VA = "0x767F40", Slot = "27")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x767D64", Offset = "0x767D64", VA = "0x767D64")]
	private void SetupUnityXrControllers()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x76813C", Offset = "0x76813C", VA = "0x76813C", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x7682C4", Offset = "0x7682C4", VA = "0x7682C4")]
	protected PointerInputModule.MouseButtonEventData GetEventData()
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x768528", Offset = "0x768528", VA = "0x768528")]
	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x768B40", Offset = "0x768B40", VA = "0x768B40")]
	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7691E0", Offset = "0x7691E0", VA = "0x7691E0")]
	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x769484", Offset = "0x769484", VA = "0x769484")]
	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x769600", Offset = "0x769600", VA = "0x769600")]
	private void ProcessUnityXrController()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x7699B4", Offset = "0x7699B4", VA = "0x7699B4", Slot = "28")]
	protected virtual void ProcessMouseController()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x769AF4", Offset = "0x769AF4", VA = "0x769AF4", Slot = "29")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x769AF8", Offset = "0x769AF8", VA = "0x769AF8", Slot = "30")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x769760", Offset = "0x769760", VA = "0x769760")]
	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x769734", Offset = "0x769734", VA = "0x769734")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x60002A6")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x769F74", Offset = "0x769F74", VA = "0x769F74")]
	public Ray GetEventRay([Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x76A4AC", Offset = "0x76A4AC", VA = "0x76A4AC")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x2000061")]
public class LivingParticleArrayController : MonoBehaviour
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] affectors;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector4[] positions;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x76A5E8", Offset = "0x76A5E8", VA = "0x76A5E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x76A6AC", Offset = "0x76A6AC", VA = "0x76A6AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x76A818", Offset = "0x76A818", VA = "0x76A818")]
	public LivingParticleArrayController()
	{
	}
}
[Token(Token = "0x2000062")]
public class LivingParticleController : MonoBehaviour
{
	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform affector;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x76A820", Offset = "0x76A820", VA = "0x76A820")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x76A878", Offset = "0x76A878", VA = "0x76A878")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x76A8F8", Offset = "0x76A8F8", VA = "0x76A8F8")]
	public LivingParticleController()
	{
	}
}
[Token(Token = "0x2000063")]
public class ParticleGridGenerator : MonoBehaviour
{
	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool rewriteVertexStreams;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float particleSize;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color particleColor;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 particleRotation3D;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool randomColorAlpha;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float xDistance;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float yDistance;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float zDistance;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int xSize;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int ySize;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int zSize;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float OffsetEven;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool updateEveryFrame;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float even;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] positions;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem ps;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Vector4> customData;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<Vector4> customData2;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x76A900", Offset = "0x76A900", VA = "0x76A900")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x76AA84", Offset = "0x76AA84", VA = "0x76AA84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x76A960", Offset = "0x76A960", VA = "0x76A960")]
	public void UpdateGrid()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x76AAE4", Offset = "0x76AAE4", VA = "0x76AAE4")]
	private void GenerateGrid()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x76AC20", Offset = "0x76AC20", VA = "0x76AC20")]
	private void GenerateParticles()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x76B058", Offset = "0x76B058", VA = "0x76B058")]
	private void CreateOffsetVector()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x76B138", Offset = "0x76B138", VA = "0x76B138")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x76B148", Offset = "0x76B148", VA = "0x76B148")]
	public ParticleGridGenerator()
	{
	}
}
[Token(Token = "0x2000064")]
public class ParticleSystemRampGenerator : MonoBehaviour
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient procedrualGradientRamp;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool procedrualGradientEnabled;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool updateEveryFrame;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Texture2D rampTexture;

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x76B240", Offset = "0x76B240", VA = "0x76B240")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x76B334", Offset = "0x76B334", VA = "0x76B334")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x76B34C", Offset = "0x76B34C", VA = "0x76B34C")]
	private Texture2D GenerateTextureFromGradient(Gradient grad)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x76B2B8", Offset = "0x76B2B8", VA = "0x76B2B8")]
	public void UpdateRampTexture()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x76B430", Offset = "0x76B430", VA = "0x76B430")]
	public ParticleSystemRampGenerator()
	{
	}
}
[Token(Token = "0x2000065")]
public class SuperSimpleMovement : MonoBehaviour
{
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float movementSpeed;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x76B438", Offset = "0x76B438", VA = "0x76B438")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x76B518", Offset = "0x76B518", VA = "0x76B518")]
	public SuperSimpleMovement()
	{
	}
}
[Token(Token = "0x2000066")]
public class UIController : MonoBehaviour
{
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light directionalLight;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ReflectionProbe reflectionProbe;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material daySkyboxMaterial;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material nightSkyboxMaterial;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform prefabHolder;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text text;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform[] prefabs;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<Transform> lt;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int activeNumber;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x76B528", Offset = "0x76B528", VA = "0x76B528")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x76B74C", Offset = "0x76B74C", VA = "0x76B74C")]
	public void EnableActive()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x76B824", Offset = "0x76B824", VA = "0x76B824")]
	public void ChangeEffect(bool bo)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x76B880", Offset = "0x76B880", VA = "0x76B880")]
	public void SetDay()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x76B8C0", Offset = "0x76B8C0", VA = "0x76B8C0")]
	public void SetNight()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x76B900", Offset = "0x76B900", VA = "0x76B900")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x76B97C", Offset = "0x76B97C", VA = "0x76B97C")]
	public UIController()
	{
	}
}
[Token(Token = "0x2000067")]
public class MenuToggle : MonoBehaviour
{
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Canvas CanvasObject;

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x76B984", Offset = "0x76B984", VA = "0x76B984")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x76B9DC", Offset = "0x76B9DC", VA = "0x76B9DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x76BA44", Offset = "0x76BA44", VA = "0x76BA44")]
	public MenuToggle()
	{
	}
}
[Token(Token = "0x2000068")]
public class SimpleSmoothMouseLook : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool lockCursor;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 sensitivity;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 smoothing;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 targetDirection;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject characterBody;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x76BA4C", Offset = "0x76BA4C", VA = "0x76BA4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x76BB38", Offset = "0x76BB38", VA = "0x76BB38")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x76C030", Offset = "0x76C030", VA = "0x76C030")]
	public SimpleSmoothMouseLook()
	{
	}
}
[Token(Token = "0x2000069")]
public class SkyboxChanger : MonoBehaviour
{
	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] Skyboxes;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dropdown _dropdown;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x76C050", Offset = "0x76C050", VA = "0x76C050")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x76C0A8", Offset = "0x76C0A8", VA = "0x76C0A8")]
	public void ChangeSkybox()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x76C0E8", Offset = "0x76C0E8", VA = "0x76C0E8")]
	public SkyboxChanger()
	{
	}
}
[Token(Token = "0x200006A")]
public class CameraToTexture : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	private sealed class <SaveCameraView>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CameraToTexture <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x76C2C8", Offset = "0x76C2C8", VA = "0x76C2C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x76C310", Offset = "0x76C310", VA = "0x76C310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x76C1A4", Offset = "0x76C1A4", VA = "0x76C1A4")]
		[DebuggerHidden]
		public <SaveCameraView>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x76C1DC", Offset = "0x76C1DC", VA = "0x76C1DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x76C1E0", Offset = "0x76C1E0", VA = "0x76C1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x76C2D0", Offset = "0x76C2D0", VA = "0x76C2D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTexture securityCameraTexture;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera securityCamera;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int finished;

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x76C0F0", Offset = "0x76C0F0", VA = "0x76C0F0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x76C130", Offset = "0x76C130", VA = "0x76C130")]
	public IEnumerator SaveCameraView()
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x76C1CC", Offset = "0x76C1CC", VA = "0x76C1CC")]
	public CameraToTexture()
	{
	}
}
[Token(Token = "0x200006C")]
public class ExitContinue : MonoBehaviour
{
	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Agrement;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool m_Accepted;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game m_Game;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_MainButtons;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_ProgramButtons;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x76C318", Offset = "0x76C318", VA = "0x76C318")]
	private void Start()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x76C470", Offset = "0x76C470", VA = "0x76C470")]
	public void OnExit()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x76C504", Offset = "0x76C504", VA = "0x76C504")]
	public void OnContinue()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x76C64C", Offset = "0x76C64C", VA = "0x76C64C")]
	public void OnSkip()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x76C7C8", Offset = "0x76C7C8", VA = "0x76C7C8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x76C854", Offset = "0x76C854", VA = "0x76C854")]
	public ExitContinue()
	{
	}
}
[Token(Token = "0x200006D")]
public class FlatCounter : MonoBehaviour
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] m_Digits;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer[] m_Adds;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Count;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_AlarmValue;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color m_Color;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color m_AlarmColor;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_PrevCount;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_SetColor;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool m_Align;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string m_PerfName;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color m_HighlightColor;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_HighlightProgress;

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x76C85C", Offset = "0x76C85C", VA = "0x76C85C")]
	private void Start()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x76CA24", Offset = "0x76CA24", VA = "0x76CA24")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x76CD14", Offset = "0x76CD14", VA = "0x76CD14")]
	private void UpdateAlarm()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x76C8F8", Offset = "0x76C8F8", VA = "0x76C8F8")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x76CDA4", Offset = "0x76CDA4", VA = "0x76CDA4")]
	public FlatCounter()
	{
	}
}
[Token(Token = "0x200006E")]
public class Interactive : MonoBehaviour
{
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x76CDC0", Offset = "0x76CDC0", VA = "0x76CDC0")]
	public Interactive()
	{
	}
}
[Token(Token = "0x200006F")]
public class Item : Interactive
{
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x76CDC8", Offset = "0x76CDC8", VA = "0x76CDC8")]
	public Item()
	{
	}
}
[Token(Token = "0x2000070")]
public class LODTile : MonoBehaviour
{
	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Cart;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] m_Segments;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float[] m_ActivateDist;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x76CDD0", Offset = "0x76CDD0", VA = "0x76CDD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x76CFA4", Offset = "0x76CFA4", VA = "0x76CFA4")]
	public LODTile()
	{
	}
}
[Token(Token = "0x2000071")]
public class MegaSphere : MonoBehaviour
{
	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Cubemap m_Cubemap;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool m_WorkInGame;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x76CFAC", Offset = "0x76CFAC", VA = "0x76CFAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x76D02C", Offset = "0x76D02C", VA = "0x76D02C")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x76D030", Offset = "0x76D030", VA = "0x76D030")]
	private void SaveTextures()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x76D318", Offset = "0x76D318", VA = "0x76D318")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x76E5B8", Offset = "0x76E5B8", VA = "0x76E5B8")]
	private void CalculateNormals(Vector3[] vertices, ref Vector3[] normals, int no_tris)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x76E05C", Offset = "0x76E05C", VA = "0x76E05C")]
	private void Trim(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x76E1A8", Offset = "0x76E1A8", VA = "0x76E1A8")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x76E430", Offset = "0x76E430", VA = "0x76E430")]
	private void Pump(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x76DB54", Offset = "0x76DB54", VA = "0x76DB54")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x76D63C", Offset = "0x76D63C", VA = "0x76D63C")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x76EC8C", Offset = "0x76EC8C", VA = "0x76EC8C")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x76ED14", Offset = "0x76ED14", VA = "0x76ED14")]
	public MegaSphere()
	{
	}
}
[Token(Token = "0x2000072")]
public class MeshCombinator : MonoBehaviour
{
	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Meshes;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string m_OutName;

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x76ED24", Offset = "0x76ED24", VA = "0x76ED24")]
	private void Update()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x76ED34", Offset = "0x76ED34", VA = "0x76ED34")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x76ED38", Offset = "0x76ED38", VA = "0x76ED38")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x76F14C", Offset = "0x76F14C", VA = "0x76F14C")]
	private void CombineMesh(ref Mesh mesh, MeshFilter[] meshes)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x76F32C", Offset = "0x76F32C", VA = "0x76F32C")]
	private void CopyMesh(MeshFilter[] meshes, ref Vector3[] vertices, ref Vector3[] normals, ref Vector2[] uv)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x76F6F8", Offset = "0x76F6F8", VA = "0x76F6F8")]
	private int CountTris(MeshFilter[] meshes)
	{
		return default(int);
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x76F834", Offset = "0x76F834", VA = "0x76F834")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x76FA64", Offset = "0x76FA64", VA = "0x76FA64")]
	public MeshCombinator()
	{
	}
}
[Token(Token = "0x2000073")]
public class Metronom : MonoBehaviour
{
	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip m_Clip;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_BeatIDx;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_BeatTime;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_Divider;

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x76FA74", Offset = "0x76FA74", VA = "0x76FA74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x76FB40", Offset = "0x76FB40", VA = "0x76FB40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x76FC70", Offset = "0x76FC70", VA = "0x76FC70")]
	public Metronom()
	{
	}
}
[Token(Token = "0x2000074")]
public class MockupMaker : MonoBehaviour
{
	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_ToTrim;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Decoration;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Mockup;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Bound;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform m_VROrientation;

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x76FC80", Offset = "0x76FC80", VA = "0x76FC80")]
	private void Start()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x7704A4", Offset = "0x7704A4", VA = "0x7704A4")]
	public void Show()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x7706B8", Offset = "0x7706B8", VA = "0x7706B8")]
	public void Hide()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x76FD88", Offset = "0x76FD88", VA = "0x76FD88")]
	private void GenerateSegments(MeshFilter[] meshes, MeshFilter[] segments)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x770774", Offset = "0x770774", VA = "0x770774")]
	private Mesh TrimMesh(MeshFilter mf)
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x770A4C", Offset = "0x770A4C", VA = "0x770A4C")]
	public MockupMaker()
	{
	}
}
[Token(Token = "0x2000075")]
public class PanoramaMaker : MonoBehaviour
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Cubemap m_Cubemap;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Meshes;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string m_OutName;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform[] m_Planes;

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x770A54", Offset = "0x770A54", VA = "0x770A54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x770A64", Offset = "0x770A64", VA = "0x770A64")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x770A68", Offset = "0x770A68", VA = "0x770A68")]
	private void SaveTextures()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x770DDC", Offset = "0x770DDC", VA = "0x770DDC")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x7719B0", Offset = "0x7719B0", VA = "0x7719B0")]
	private void CutMesh(ref Vector3[] vertices, ref int no_tris)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x77246C", Offset = "0x77246C", VA = "0x77246C")]
	private void SliceTraingle(ref Vector3[] vertices, ref int no_tris, int idx)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x771224", Offset = "0x771224", VA = "0x771224")]
	private void CopyMesh(ref Mesh mesh, MeshFilter[] meshes)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x772BF0", Offset = "0x772BF0", VA = "0x772BF0")]
	private int CountTris(MeshFilter[] meshes)
	{
		return default(int);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x771D98", Offset = "0x771D98", VA = "0x771D98")]
	private void CalculateNormals(Vector3[] vertices, ref Vector3[] normals, int no_tris)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x771404", Offset = "0x771404", VA = "0x771404")]
	private void Trim(ref Vector3[] vertices, ref int no_tris)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x771B68", Offset = "0x771B68", VA = "0x771B68")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x772D2C", Offset = "0x772D2C", VA = "0x772D2C")]
	private void Pump(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x772EB4", Offset = "0x772EB4", VA = "0x772EB4")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x7733BC", Offset = "0x7733BC", VA = "0x7733BC")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x7738D4", Offset = "0x7738D4", VA = "0x7738D4")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x77395C", Offset = "0x77395C", VA = "0x77395C")]
	public PanoramaMaker()
	{
	}
}
[Serializable]
[Token(Token = "0x2000076")]
public class GameEvent
{
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int source_id;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frame;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 v3_param;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int i_param;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int i_param2;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool was_played;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rejcected;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x77396C", Offset = "0x77396C", VA = "0x77396C")]
	public GameEvent()
	{
	}
}
[Token(Token = "0x2000077")]
public class Recorder : MonoBehaviour
{
	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_PrevFrame;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_SourceID;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_Record;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool m_Smooth;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool m_Copy;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool m_RecordTransform;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameEvent> m_Events;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] m_RecordingPos;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Quaternion[] m_RecordingRot;

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x773974", Offset = "0x773974", VA = "0x773974")]
	public void Copy(ref Recorder reference)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x7739F0", Offset = "0x7739F0", VA = "0x7739F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x773C04", Offset = "0x773C04", VA = "0x773C04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x773D5C", Offset = "0x773D5C", VA = "0x773D5C")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x773E30", Offset = "0x773E30", VA = "0x773E30")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x773EB4", Offset = "0x773EB4", VA = "0x773EB4")]
	public void Play()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x773F40", Offset = "0x773F40", VA = "0x773F40")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x774218", Offset = "0x774218", VA = "0x774218")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x774220", Offset = "0x774220", VA = "0x774220")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x774238", Offset = "0x774238", VA = "0x774238")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x774250", Offset = "0x774250", VA = "0x774250")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int i_param2, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x77443C", Offset = "0x77443C", VA = "0x77443C")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x774604", Offset = "0x774604", VA = "0x774604")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x7747A0", Offset = "0x7747A0", VA = "0x7747A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x773CC8", Offset = "0x773CC8", VA = "0x773CC8")]
	public int GetCurrFrame()
	{
		return default(int);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x774A88", Offset = "0x774A88", VA = "0x774A88")]
	private float GetDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x7747BC", Offset = "0x7747BC", VA = "0x7747BC")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x774888", Offset = "0x774888", VA = "0x774888")]
	private void PlayFrame()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x774AF0", Offset = "0x774AF0", VA = "0x774AF0")]
	public Recorder()
	{
	}
}
[Token(Token = "0x2000078")]
public class Remaper2D : MonoBehaviour
{
	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshFilter m_MeshFilter;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool XZ;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_OutName;

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x774B8C", Offset = "0x774B8C", VA = "0x774B8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x774DDC", Offset = "0x774DDC", VA = "0x774DDC")]
	public Remaper2D()
	{
	}
}
[Token(Token = "0x2000079")]
public class Selector : MonoBehaviour
{
	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_MinNoSelected;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_MaxNoSelected;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoSelected;

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x774DE4", Offset = "0x774DE4", VA = "0x774DE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x7751F8", Offset = "0x7751F8", VA = "0x7751F8")]
	public Selector()
	{
	}
}
[Token(Token = "0x200007A")]
public class SpeedSim : MonoBehaviour
{
	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 m_CurrSpeed;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 m_PosMod;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 m_Translate;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 m_PerlinShift;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 m_PerlinFreq;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_CenterObj;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float m_TimeShift;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 m_StartPos;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Game m_Game;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x775208", Offset = "0x775208", VA = "0x775208")]
	private void Start()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x7752B0", Offset = "0x7752B0", VA = "0x7752B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x77576C", Offset = "0x77576C", VA = "0x77576C")]
	public SpeedSim()
	{
	}
}
[Token(Token = "0x200007B")]
public class SteamLeaderboardManager : MonoBehaviour
{
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x775884", Offset = "0x775884", VA = "0x775884")]
	public SteamLeaderboardManager()
	{
	}
}
[Token(Token = "0x200007C")]
public class TActivator : MonoBehaviour
{
	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x77588C", Offset = "0x77588C", VA = "0x77588C")]
	private void Start()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x7758F0", Offset = "0x7758F0", VA = "0x7758F0")]
	public TActivator()
	{
	}
}
[Token(Token = "0x200007D")]
public class TimeDestroyer : MonoBehaviour
{
	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_TimeOut;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool m_DetachChildren;

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x7758F8", Offset = "0x7758F8", VA = "0x7758F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x775948", Offset = "0x775948", VA = "0x775948")]
	private void DestroyNow()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x7759D8", Offset = "0x7759D8", VA = "0x7759D8")]
	public TimeDestroyer()
	{
	}
}
[Token(Token = "0x200007E")]
public class Tools
{
	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int m_Seed;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x7759E8", Offset = "0x7759E8", VA = "0x7759E8")]
	public static bool CollTriangleVSSection(Vector3 t1, Vector3 t2, Vector3 t3, Vector3 p1, Vector3 p2, ref Vector3 coll_p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x77510C", Offset = "0x77510C", VA = "0x77510C")]
	public static float GetRandom(int seed, int idx)
	{
		return default(float);
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x774FF0", Offset = "0x774FF0", VA = "0x774FF0")]
	public static int GetRandomIDX(int seed, int idx, int max)
	{
		return default(int);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x765AE4", Offset = "0x765AE4", VA = "0x765AE4")]
	public static float CosFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x765AD8", Offset = "0x765AD8", VA = "0x765AD8")]
	public static float Mod01(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x775758", Offset = "0x775758", VA = "0x775758")]
	public static float Mod(float val, float mod)
	{
		return default(float);
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x775C54", Offset = "0x775C54", VA = "0x775C54")]
	public static AudioClip GetRandomAudio(string name, int no_samples = 3)
	{
		return null;
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x775D64", Offset = "0x775D64", VA = "0x775D64")]
	public static float GetFloat(string key, float defValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x76C468", Offset = "0x76C468", VA = "0x76C468")]
	public static int GetInt(string key, int defValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x775D6C", Offset = "0x775D6C", VA = "0x775D6C")]
	public static string GetString(string key, string defValue = "")
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x775D74", Offset = "0x775D74", VA = "0x775D74")]
	public static void SetFloat(string key, float value)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x76C63C", Offset = "0x76C63C", VA = "0x76C63C")]
	public static void SetInt(string key, int value)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x775D7C", Offset = "0x775D7C", VA = "0x775D7C")]
	public static void SetString(string key, string value)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x76C644", Offset = "0x76C644", VA = "0x76C644")]
	public static void Save()
	{
	}
}
[Token(Token = "0x200007F")]
public class TurnFaceToCamera : MonoBehaviour
{
	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_StabilizePos;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_StabilizeXRot;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_StabilizeRot;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR m_VR;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 m_BaseShift;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Parent;

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x775DD0", Offset = "0x775DD0", VA = "0x775DD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x775E48", Offset = "0x775E48", VA = "0x775E48")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x7761EC", Offset = "0x7761EC", VA = "0x7761EC")]
	public TurnFaceToCamera()
	{
	}
}
[Token(Token = "0x2000080")]
public class UVAnimator : MonoBehaviour
{
	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material m_Material;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 m_Speed;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float time;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x776258", Offset = "0x776258", VA = "0x776258")]
	private void Update()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x7762D4", Offset = "0x7762D4", VA = "0x7762D4")]
	public UVAnimator()
	{
	}
}
[Token(Token = "0x2000081")]
public class VRKeyboard : MonoBehaviour
{
	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] ButtonLists;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Output;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource m_ClickSFX;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool CapsLock;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string EditedText;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string EditedStringName;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x7762DC", Offset = "0x7762DC", VA = "0x7762DC")]
	public void Show(string edited_string_name)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x7763C0", Offset = "0x7763C0", VA = "0x7763C0")]
	public void OnButtonDown(string letter)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x7764D8", Offset = "0x7764D8", VA = "0x7764D8")]
	public void OnCapsLock()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x776590", Offset = "0x776590", VA = "0x776590")]
	public void OnClear()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x776604", Offset = "0x776604", VA = "0x776604")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x776670", Offset = "0x776670", VA = "0x776670")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x7766F8", Offset = "0x7766F8", VA = "0x7766F8")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x776448", Offset = "0x776448", VA = "0x776448")]
	private void PlayClick()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x776728", Offset = "0x776728", VA = "0x776728")]
	public VRKeyboard()
	{
	}
}
[Token(Token = "0x2000082")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float ROTATE_SPEED;

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x776798", Offset = "0x776798", VA = "0x776798")]
	private void Start()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x7767C4", Offset = "0x7767C4", VA = "0x7767C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x776868", Offset = "0x776868", VA = "0x776868")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x2000083")]
public class PressedBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button btn;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform myIcon;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x776878", Offset = "0x776878", VA = "0x776878")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x77692C", Offset = "0x77692C", VA = "0x77692C")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x7769EC", Offset = "0x7769EC", VA = "0x7769EC")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x776AC0", Offset = "0x776AC0", VA = "0x776AC0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x776AC4", Offset = "0x776AC4", VA = "0x776AC4", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x776AC8", Offset = "0x776AC8", VA = "0x776AC8", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x776ACC", Offset = "0x776ACC", VA = "0x776ACC", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x776AD0", Offset = "0x776AD0", VA = "0x776AD0")]
	public PressedBtn()
	{
	}
}
[Token(Token = "0x2000084")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x776AD8", Offset = "0x776AD8", VA = "0x776AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x776B30", Offset = "0x776B30", VA = "0x776B30")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x776C48", Offset = "0x776C48", VA = "0x776C48")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x2000085")]
public class handanimations : MonoBehaviour
{
	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ViveController;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject OculusController;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject StickUp;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject StickFront;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator anim;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int Idle;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int Point;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int GrabLarge;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int GrabSmall;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int GrabStickUp;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int GrabStickFront;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int ThumbUp;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int Fist;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int Gun;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int GunShoot;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int PushButton;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int Spread;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int MiddleFinger;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int Peace;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int OK;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int Phone;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int Rock;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int Natural;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int Number3;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int Number4;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int Number3V2;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int HoldViveController;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int PressTriggerViveController;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int HoldOculusController;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int PressTriggerOculusController;

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x776C50", Offset = "0x776C50", VA = "0x776C50")]
	private void Start()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x776D00", Offset = "0x776D00", VA = "0x776D00")]
	private void Update()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x777174", Offset = "0x777174", VA = "0x777174")]
	public handanimations()
	{
	}
}
[Token(Token = "0x2000086")]
internal class AnimateSpriteSheet : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	private sealed class <UpdateTiling>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateSpriteSheet <>4__this;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <y>5__2;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 <offset>5__3;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__4;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <j>5__5;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x77792C", Offset = "0x77792C", VA = "0x77792C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x777974", Offset = "0x777974", VA = "0x777974", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x77771C", Offset = "0x77771C", VA = "0x77771C")]
		[DebuggerHidden]
		public <UpdateTiling>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x777764", Offset = "0x777764", VA = "0x777764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x777768", Offset = "0x777768", VA = "0x777768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x777934", Offset = "0x777934", VA = "0x777934", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Columns;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Rows;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float FramesPerSecond;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool RunOnce;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material materialCopy;

	[Token(Token = "0x1700003C")]
	public float RunTimeInSeconds
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x77754C", Offset = "0x77754C", VA = "0x77754C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x77756C", Offset = "0x77756C", VA = "0x77756C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x777688", Offset = "0x777688", VA = "0x777688")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x7776A8", Offset = "0x7776A8", VA = "0x7776A8")]
	private IEnumerator UpdateTiling()
	{
		return null;
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x777744", Offset = "0x777744", VA = "0x777744")]
	public AnimateSpriteSheet()
	{
	}
}
[Token(Token = "0x2000088")]
public class Turn_Move : MonoBehaviour
{
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TurnX;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int TurnY;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int TurnZ;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int MoveX;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int MoveY;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int MoveZ;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool World;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x77797C", Offset = "0x77797C", VA = "0x77797C")]
	private void Update()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x777B00", Offset = "0x777B00", VA = "0x777B00")]
	public Turn_Move()
	{
	}
}
[Token(Token = "0x2000089")]
public class DoorHori : MonoBehaviour
{
	[Token(Token = "0x200008A")]
	private sealed class <WaitToClose>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DoorHori <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x7785F0", Offset = "0x7785F0", VA = "0x7785F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x778638", Offset = "0x778638", VA = "0x778638", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x7783CC", Offset = "0x7783CC", VA = "0x7783CC")]
		[DebuggerHidden]
		public <WaitToClose>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7783FC", Offset = "0x7783FC", VA = "0x7783FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x778400", Offset = "0x778400", VA = "0x778400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7785F8", Offset = "0x7785F8", VA = "0x7785F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float translateValue;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float easeTime;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OTween.EaseType ease;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float waitTime;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 StartlocalPos;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 endlocalPos;

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x777B08", Offset = "0x777B08", VA = "0x777B08")]
	private void Start()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x777B50", Offset = "0x777B50", VA = "0x777B50")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x778210", Offset = "0x778210", VA = "0x778210")]
	private void UpdateOpenDoor(float f)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x778298", Offset = "0x778298", VA = "0x778298")]
	private void UpdateCloseDoor(float f)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x778314", Offset = "0x778314", VA = "0x778314")]
	private void EndOpen()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x778358", Offset = "0x778358", VA = "0x778358")]
	private IEnumerator WaitToClose()
	{
		return null;
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x7783F4", Offset = "0x7783F4", VA = "0x7783F4")]
	public DoorHori()
	{
	}
}
[Token(Token = "0x200008B")]
public class DoorVert : MonoBehaviour
{
	[Token(Token = "0x200008C")]
	private sealed class <WaitToClose>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DoorVert <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x778BDC", Offset = "0x778BDC", VA = "0x778BDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x778C24", Offset = "0x778C24", VA = "0x778C24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x7789B8", Offset = "0x7789B8", VA = "0x7789B8")]
		[DebuggerHidden]
		public <WaitToClose>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x7789E8", Offset = "0x7789E8", VA = "0x7789E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x7789EC", Offset = "0x7789EC", VA = "0x7789EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x778BE4", Offset = "0x778BE4", VA = "0x778BE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float translateValue;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float easeTime;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OTween.EaseType ease;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float waitTime;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 StartlocalPos;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 endlocalPos;

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x778640", Offset = "0x778640", VA = "0x778640")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x778688", Offset = "0x778688", VA = "0x778688")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x7787FC", Offset = "0x7787FC", VA = "0x7787FC")]
	private void UpdateOpenDoor(float f)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x778884", Offset = "0x778884", VA = "0x778884")]
	private void UpdateCloseDoor(float f)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x778900", Offset = "0x778900", VA = "0x778900")]
	private void EndOpen()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x778944", Offset = "0x778944", VA = "0x778944")]
	private IEnumerator WaitToClose()
	{
		return null;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x7789E0", Offset = "0x7789E0", VA = "0x7789E0")]
	public DoorVert()
	{
	}
}
[Token(Token = "0x200008D")]
public class HDRColorChange : MonoBehaviour
{
	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color colorStart;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer rend;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x778C2C", Offset = "0x778C2C", VA = "0x778C2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x778D0C", Offset = "0x778D0C", VA = "0x778D0C")]
	public HDRColorChange()
	{
	}
}
[Token(Token = "0x200008E")]
public class HoriDoorManager : MonoBehaviour
{
	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DoorHori door1;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DoorHori door2;

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x778D1C", Offset = "0x778D1C", VA = "0x778D1C")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x778DD0", Offset = "0x778DD0", VA = "0x778DD0")]
	public HoriDoorManager()
	{
	}
}
[Token(Token = "0x200008F")]
public class OTween : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public enum EaseType
	{
		[Token(Token = "0x4000538")]
		Linear,
		[Token(Token = "0x4000539")]
		CubicIn,
		[Token(Token = "0x400053A")]
		CubicOut,
		[Token(Token = "0x400053B")]
		BounceIn,
		[Token(Token = "0x400053C")]
		BounceOut,
		[Token(Token = "0x400053D")]
		ElasticIn,
		[Token(Token = "0x400053E")]
		ElasticOut
	}

	[Token(Token = "0x2000091")]
	private enum VariableType
	{
		[Token(Token = "0x4000540")]
		Float,
		[Token(Token = "0x4000541")]
		V3,
		[Token(Token = "0x4000542")]
		V2
	}

	[Token(Token = "0x2000092")]
	private sealed class <LaunchEase>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OTween <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x779EDC", Offset = "0x779EDC", VA = "0x779EDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x779F24", Offset = "0x779F24", VA = "0x779F24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x779654", Offset = "0x779654", VA = "0x779654")]
		[DebuggerHidden]
		public <LaunchEase>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x779DE4", Offset = "0x779DE4", VA = "0x779DE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x779DE8", Offset = "0x779DE8", VA = "0x779DE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x779EE4", Offset = "0x779EE4", VA = "0x779EE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string tweenId;

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x779B74", Offset = "0x779B74", VA = "0x779B74")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x779F2C", Offset = "0x779F2C", VA = "0x779F2C")]
		internal bool <UpdateEndValue>b__0(OTween t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EaseType easeType;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float delayToStart;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float duration;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool isStart;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string startCallBack;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string updateCallBack;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string endCallBack;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float startValue1;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float startValue2;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float startValue3;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float endValue1;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float endValue2;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float endValue3;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float startTime;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private VariableType variableType;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<OTween> tweens;

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x778DD8", Offset = "0x778DD8", VA = "0x778DD8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x778FFC", Offset = "0x778FFC", VA = "0x778FFC")]
	private float UpdateTween(float start, float end, float time)
	{
		return default(float);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x7791F4", Offset = "0x7791F4", VA = "0x7791F4")]
	private void SendUpdate(float v1, float v2, float v3)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x7795E0", Offset = "0x7795E0", VA = "0x7795E0")]
	private IEnumerator LaunchEase()
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x779328", Offset = "0x779328", VA = "0x779328")]
	private float Linear(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x77933C", Offset = "0x77933C", VA = "0x77933C")]
	private float BounceIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x779370", Offset = "0x779370", VA = "0x779370")]
	private float BounceOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x77943C", Offset = "0x77943C", VA = "0x77943C")]
	private float CubicIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x779458", Offset = "0x779458", VA = "0x779458")]
	private float CubicOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x779484", Offset = "0x779484", VA = "0x779484")]
	private float ElasticIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x779534", Offset = "0x779534", VA = "0x779534")]
	private float ElasticOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x77967C", Offset = "0x77967C", VA = "0x77967C")]
	private void StartEase()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x777CC4", Offset = "0x777CC4", VA = "0x777CC4")]
	public static string ValueTo(GameObject obj, EaseType easeType, object startValue, object endValue, float duration, float delaytToStart = 0f, string startCallBack = "", string updateCallBack = "", string endCallBack = "")
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x7796C8", Offset = "0x7796C8", VA = "0x7796C8")]
	public static void UpdateEndValue(string tweenId, object endValue)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x779B7C", Offset = "0x779B7C", VA = "0x779B7C")]
	public static void StopTween(GameObject obj)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x779D44", Offset = "0x779D44", VA = "0x779D44")]
	public OTween()
	{
	}
}
[Token(Token = "0x2000094")]
[RequireComponent(typeof(AudioSource))]
public class ParticleSound : MonoBehaviour
{
	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip OnBirthSound;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem emitter;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int particleNum;

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x779F50", Offset = "0x779F50", VA = "0x779F50")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x779FF8", Offset = "0x779FF8", VA = "0x779FF8")]
	public ParticleSound()
	{
	}
}
[Token(Token = "0x2000095")]
public class VertDoorManager : MonoBehaviour
{
	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DoorVert door1;

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x77A000", Offset = "0x77A000", VA = "0x77A000")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x77A080", Offset = "0x77A080", VA = "0x77A080")]
	public VertDoorManager()
	{
	}
}
namespace NeuralNetwork
{
	[Token(Token = "0x2000096")]
	public class NeuralNet
	{
		[Token(Token = "0x2000097")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] inputs;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x77C3D0", Offset = "0x77C3D0", VA = "0x77C3D0")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x77C618", Offset = "0x77C618", VA = "0x77C618")]
			internal void <ForwardPropagate>b__0(Neuron a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		private sealed class <>c
		{
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Neuron> <>9__31_2;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<Neuron> <>9__31_1;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<Neuron> <>9__32_2;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Neuron, float> <>9__33_0;

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x77C6CC", Offset = "0x77C6CC", VA = "0x77C6CC")]
			public <>c()
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x77C6D4", Offset = "0x77C6D4", VA = "0x77C6D4")]
			internal void <ForwardPropagate>b__31_2(Neuron a)
			{
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x77C6F4", Offset = "0x77C6F4", VA = "0x77C6F4")]
			internal void <ForwardPropagate>b__31_1(Neuron a)
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x77C714", Offset = "0x77C714", VA = "0x77C714")]
			internal void <BackPropagate>b__32_2(Neuron a)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x77C89C", Offset = "0x77C89C", VA = "0x77C89C")]
			internal float <Compute>b__33_0(Neuron a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000099")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] targets;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NeuralNet <>4__this;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Neuron> <>9__3;

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x77C3D8", Offset = "0x77C3D8", VA = "0x77C3D8")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x77C8B4", Offset = "0x77C8B4", VA = "0x77C8B4")]
			internal void <BackPropagate>b__0(Neuron a)
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x77C950", Offset = "0x77C950", VA = "0x77C950")]
			internal void <BackPropagate>b__3(Neuron a)
			{
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x77CB24", Offset = "0x77CB24", VA = "0x77CB24")]
			internal void <BackPropagate>b__1(Neuron a)
			{
			}
		}

		[Token(Token = "0x200009A")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] targets;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x77C510", Offset = "0x77C510", VA = "0x77C510")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x77CB50", Offset = "0x77CB50", VA = "0x77CB50")]
			internal float <CalculateError>b__0(Neuron a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float <LearnRate>k__BackingField;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <Momentum>k__BackingField;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <LearnRateFactor>k__BackingField;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Neuron> <InputLayer>k__BackingField;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<List<Neuron>> <HiddenLayers>k__BackingField;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Neuron> <OutputLayer>k__BackingField;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random Random;

		[Token(Token = "0x17000045")]
		public float LearnRate
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x77A088", Offset = "0x77A088", VA = "0x77A088")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x77A090", Offset = "0x77A090", VA = "0x77A090")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float Momentum
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x77A098", Offset = "0x77A098", VA = "0x77A098")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x77A0A0", Offset = "0x77A0A0", VA = "0x77A0A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public float LearnRateFactor
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x77A0A8", Offset = "0x77A0A8", VA = "0x77A0A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x77A0B0", Offset = "0x77A0B0", VA = "0x77A0B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public List<Neuron> InputLayer
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x77A0B8", Offset = "0x77A0B8", VA = "0x77A0B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x77A0C0", Offset = "0x77A0C0", VA = "0x77A0C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public List<List<Neuron>> HiddenLayers
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x77A0C8", Offset = "0x77A0C8", VA = "0x77A0C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x77A0D0", Offset = "0x77A0D0", VA = "0x77A0D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<Neuron> OutputLayer
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x77A0D8", Offset = "0x77A0D8", VA = "0x77A0D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x77A0E0", Offset = "0x77A0E0", VA = "0x77A0E0")]
			set
			{
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x77A0E8", Offset = "0x77A0E8", VA = "0x77A0E8")]
		public void Store(ref List<float> weights)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x77A480", Offset = "0x77A480", VA = "0x77A480")]
		public void Restore(ref List<float> weights)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x77A794", Offset = "0x77A794", VA = "0x77A794")]
		public NeuralNet(bool const_hidden_size, int input_size, int hidden_size, int output_size, int num_hidden_layers = 1, [Optional] float? learn_rate, [Optional] float? momentum)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x77B1A4", Offset = "0x77B1A4", VA = "0x77B1A4")]
		public float CalcError(List<DataSet> dataSets)
		{
			return default(float);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x77B8C4", Offset = "0x77B8C4", VA = "0x77B8C4")]
		public void Train(List<DataSet> dataSets, float min_error, int number_of_eppoch)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x77B454", Offset = "0x77B454", VA = "0x77B454")]
		private void ForwardPropagate(params float[] inputs)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x77BDF8", Offset = "0x77BDF8", VA = "0x77BDF8")]
		private void BackPropagate(params float[] targets)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x77C3E0", Offset = "0x77C3E0", VA = "0x77C3E0")]
		public float[] Compute(params float[] inputs)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x77B7D8", Offset = "0x77B7D8", VA = "0x77B7D8")]
		private float CalculateError(params float[] targets)
		{
			return default(float);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x77C518", Offset = "0x77C518", VA = "0x77C518")]
		public static float GetRandom()
		{
			return default(float);
		}
	}
	[Token(Token = "0x200009B")]
	public class Neuron
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Synapse, float> <>9__26_0;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Synapse, float> <>9__28_0;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x77CEBC", Offset = "0x77CEBC", VA = "0x77CEBC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x77CEC4", Offset = "0x77CEC4", VA = "0x77CEC4")]
			internal float <CalculateValue>b__26_0(Synapse a)
			{
				return default(float);
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x77CEEC", Offset = "0x77CEEC", VA = "0x77CEEC")]
			internal float <CalculateGradient>b__28_0(Synapse a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Synapse> <InputSynapses>k__BackingField;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Synapse> <OutputSynapses>k__BackingField;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <Bias>k__BackingField;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <BiasDelta>k__BackingField;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <Gradient>k__BackingField;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <Value>k__BackingField;

		[Token(Token = "0x1700004B")]
		public List<Synapse> InputSynapses
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x77CBA4", Offset = "0x77CBA4", VA = "0x77CBA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x77CBAC", Offset = "0x77CBAC", VA = "0x77CBAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public List<Synapse> OutputSynapses
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x77CBB4", Offset = "0x77CBB4", VA = "0x77CBB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x77CBBC", Offset = "0x77CBBC", VA = "0x77CBBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public float Bias
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x77CBC4", Offset = "0x77CBC4", VA = "0x77CBC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x77CBCC", Offset = "0x77CBCC", VA = "0x77CBCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public float BiasDelta
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x77CBD4", Offset = "0x77CBD4", VA = "0x77CBD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x77CBDC", Offset = "0x77CBDC", VA = "0x77CBDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public float Gradient
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x77CBE4", Offset = "0x77CBE4", VA = "0x77CBE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x77CBEC", Offset = "0x77CBEC", VA = "0x77CBEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float Value
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x77CBF4", Offset = "0x77CBF4", VA = "0x77CBF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x77CBFC", Offset = "0x77CBFC", VA = "0x77CBFC")]
			set
			{
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x77AC94", Offset = "0x77AC94", VA = "0x77AC94")]
		public Neuron()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x77AD7C", Offset = "0x77AD7C", VA = "0x77AD7C")]
		public Neuron(IEnumerable<Neuron> inputNeurons)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x77CC98", Offset = "0x77CC98", VA = "0x77CC98", Slot = "4")]
		public virtual float CalculateValue()
		{
			return default(float);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x77CB98", Offset = "0x77CB98", VA = "0x77CB98")]
		public float CalculateError(float target)
		{
			return default(float);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x77C72C", Offset = "0x77C72C", VA = "0x77C72C")]
		public float CalculateGradient([Optional] float? target)
		{
			return default(float);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x77C97C", Offset = "0x77C97C", VA = "0x77C97C")]
		public void UpdateWeights(float learnRate, float momentum)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x77A270", Offset = "0x77A270", VA = "0x77A270")]
		public void Store(ref List<float> weights)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x77A608", Offset = "0x77A608", VA = "0x77A608")]
		public void Restore(ref List<float> weights)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class Synapse
	{
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Neuron <InputNeuron>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Neuron <OutputNeuron>k__BackingField;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <Weight>k__BackingField;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <WeightDelta>k__BackingField;

		[Token(Token = "0x17000051")]
		public Neuron InputNeuron
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x77CF14", Offset = "0x77CF14", VA = "0x77CF14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x77CF1C", Offset = "0x77CF1C", VA = "0x77CF1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public Neuron OutputNeuron
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x77CF24", Offset = "0x77CF24", VA = "0x77CF24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x77CF2C", Offset = "0x77CF2C", VA = "0x77CF2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float Weight
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x77CF34", Offset = "0x77CF34", VA = "0x77CF34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x77CF3C", Offset = "0x77CF3C", VA = "0x77CF3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float WeightDelta
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x77CF44", Offset = "0x77CF44", VA = "0x77CF44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x77CF4C", Offset = "0x77CF4C", VA = "0x77CF4C")]
			set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x77CC04", Offset = "0x77CC04", VA = "0x77CC04")]
		public Synapse(Neuron inputNeuron, Neuron outputNeuron)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class Sigmoid
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x77CDEC", Offset = "0x77CDEC", VA = "0x77CDEC")]
		public static float Output(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x77CE3C", Offset = "0x77CE3C", VA = "0x77CE3C")]
		public static float Derivative(float x)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200009F")]
	public class DataSet
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] <Inputs>k__BackingField;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] <Outputs>k__BackingField;

		[Token(Token = "0x17000055")]
		public float[] Inputs
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x77CF54", Offset = "0x77CF54", VA = "0x77CF54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x77CF5C", Offset = "0x77CF5C", VA = "0x77CF5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float[] Outputs
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x77CF64", Offset = "0x77CF64", VA = "0x77CF64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x77CF6C", Offset = "0x77CF6C", VA = "0x77CF6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x77CF74", Offset = "0x77CF74", VA = "0x77CF74")]
		public DataSet(float[] inputs, float[] outputs)
		{
		}
	}
}
namespace DSPLib
{
	[Token(Token = "0x20000A0")]
	public class FFT
	{
		[Token(Token = "0x20000A1")]
		private class FFTElement
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public double re;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double im;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FFTElement next;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint revTgt;

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x77D290", Offset = "0x77D290", VA = "0x77D290")]
			public FFTElement()
			{
			}
		}

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double mFFTScale;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint mLogN;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint mN;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint mLengthTotal;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private uint mLengthHalf;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FFTElement[] mX;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x77CFB8", Offset = "0x77CFB8", VA = "0x77CFB8")]
		public FFT()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x77CFC8", Offset = "0x77CFC8", VA = "0x77CFC8")]
		public void Initialize(uint inputDataLength, uint zeroPaddingLength = 0u)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x77D2BC", Offset = "0x77D2BC", VA = "0x77D2BC")]
		public Complex[] Execute(double[] timeSeries)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x77D298", Offset = "0x77D298", VA = "0x77D298")]
		private uint BitReverse(uint x, uint numBits)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x20000A2")]
	public class DSP
	{
		[Token(Token = "0x20000A3")]
		public static class Window
		{
			[Token(Token = "0x20000A4")]
			public enum Type
			{
				[Token(Token = "0x4000579")]
				None,
				[Token(Token = "0x400057A")]
				Rectangular,
				[Token(Token = "0x400057B")]
				Welch,
				[Token(Token = "0x400057C")]
				Bartlett,
				[Token(Token = "0x400057D")]
				Hanning,
				[Token(Token = "0x400057E")]
				Hann,
				[Token(Token = "0x400057F")]
				Hamming,
				[Token(Token = "0x4000580")]
				Nutall3,
				[Token(Token = "0x4000581")]
				Nutall4,
				[Token(Token = "0x4000582")]
				Nutall3A,
				[Token(Token = "0x4000583")]
				Nutall3B,
				[Token(Token = "0x4000584")]
				Nutall4A,
				[Token(Token = "0x4000585")]
				BH92,
				[Token(Token = "0x4000586")]
				Nutall4B,
				[Token(Token = "0x4000587")]
				SFT3F,
				[Token(Token = "0x4000588")]
				SFT3M,
				[Token(Token = "0x4000589")]
				FTNI,
				[Token(Token = "0x400058A")]
				SFT4F,
				[Token(Token = "0x400058B")]
				SFT5F,
				[Token(Token = "0x400058C")]
				SFT4M,
				[Token(Token = "0x400058D")]
				FTHP,
				[Token(Token = "0x400058E")]
				HFT70,
				[Token(Token = "0x400058F")]
				FTSRS,
				[Token(Token = "0x4000590")]
				SFT5M,
				[Token(Token = "0x4000591")]
				HFT90D,
				[Token(Token = "0x4000592")]
				HFT95,
				[Token(Token = "0x4000593")]
				HFT116D,
				[Token(Token = "0x4000594")]
				HFT144D,
				[Token(Token = "0x4000595")]
				HFT169D,
				[Token(Token = "0x4000596")]
				HFT196D,
				[Token(Token = "0x4000597")]
				HFT223D,
				[Token(Token = "0x4000598")]
				HFT248D
			}

			[Token(Token = "0x20000A5")]
			public static class ScaleFactor
			{
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x77DF68", Offset = "0x77DF68", VA = "0x77DF68")]
				public static double Signal(double[] windowCoefficients)
				{
					return default(double);
				}
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x77D600", Offset = "0x77D600", VA = "0x77D600")]
			public static double[] Coefficients(Type windowName, uint points)
			{
				return null;
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x77DC9C", Offset = "0x77DC9C", VA = "0x77DC9C")]
			private static double[] SineExpansion(uint points, double c0, double c1 = 0.0, double c2 = 0.0, double c3 = 0.0, double c4 = 0.0, double c5 = 0.0, double c6 = 0.0, double c7 = 0.0, double c8 = 0.0, double c9 = 0.0, double c10 = 0.0)
			{
				return null;
			}
		}

		[Token(Token = "0x20000A6")]
		public static class ConvertComplex
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x77DFD8", Offset = "0x77DFD8", VA = "0x77DFD8")]
			public static double[] ToMagnitude(Complex[] rawFFT)
			{
				return null;
			}
		}

		[Token(Token = "0x20000A7")]
		public static class Math
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x77E0FC", Offset = "0x77E0FC", VA = "0x77E0FC")]
			public static double[] Multiply(double[] a, double[] b)
			{
				return null;
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x77E1C0", Offset = "0x77E1C0", VA = "0x77E1C0")]
			public static double[] Multiply(double[] a, double b)
			{
				return null;
			}
		}
	}
}
namespace System.Numerics
{
	[Serializable]
	[Token(Token = "0x20000A8")]
	public struct Complex : IEquatable<Complex>, IFormattable
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double m_real;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private double m_imaginary;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Complex Zero;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Complex One;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Complex ImaginaryOne;

		[Token(Token = "0x17000057")]
		public double Real
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x77E274", Offset = "0x77E274", VA = "0x77E274")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000058")]
		public double Magnitude
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x77E098", Offset = "0x77E098", VA = "0x77E098")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x77D5F8", Offset = "0x77D5F8", VA = "0x77D5F8")]
		public Complex(double real, double imaginary)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x77E27C", Offset = "0x77E27C", VA = "0x77E27C")]
		public static double Abs(Complex value)
		{
			return default(double);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x77E3E4", Offset = "0x77E3E4", VA = "0x77E3E4")]
		public static bool operator ==(Complex left, Complex right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x77E3FC", Offset = "0x77E3FC", VA = "0x77E3FC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x77E4B8", Offset = "0x77E4B8", VA = "0x77E4B8", Slot = "4")]
		public bool Equals(Complex value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x77E4FC", Offset = "0x77E4FC", VA = "0x77E4FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x77E5D4", Offset = "0x77E5D4", VA = "0x77E5D4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x77E664", Offset = "0x77E664", VA = "0x77E664", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RhythmTool
{
	[Token(Token = "0x20000A9")]
	public abstract class Analysis : MonoBehaviour
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int <frameSize>k__BackingField;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <hopSize>k__BackingField;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int <frameIndex>k__BackingField;

		[Token(Token = "0x17000059")]
		public Track track
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x77E7CC", Offset = "0x77E7CC", VA = "0x77E7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public int sampleRate
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x77E7D8", Offset = "0x77E7D8", VA = "0x77E7D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x77E7E0", Offset = "0x77E7E0", VA = "0x77E7E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public int frameSize
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x77E7E8", Offset = "0x77E7E8", VA = "0x77E7E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x77E7F0", Offset = "0x77E7F0", VA = "0x77E7F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int hopSize
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x77E7F8", Offset = "0x77E7F8", VA = "0x77E7F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x77E800", Offset = "0x77E800", VA = "0x77E800")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public new abstract string name
		{
			[Token(Token = "0x6000440")]
			get;
		}

		[Token(Token = "0x1700005E")]
		protected int frameIndex
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x77E808", Offset = "0x77E808", VA = "0x77E808")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x77E810", Offset = "0x77E810", VA = "0x77E810")]
			private set
			{
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x77E818", Offset = "0x77E818", VA = "0x77E818", Slot = "5")]
		public virtual void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x77E824", Offset = "0x77E824", VA = "0x77E824", Slot = "6")]
		public virtual void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x77E82C", Offset = "0x77E82C", VA = "0x77E82C")]
		protected float FrameIndexToSeconds(float frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000446")]
		protected abstract Track GetTrack();

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x77E848", Offset = "0x77E848", VA = "0x77E848")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[ExecuteInEditMode]
	public abstract class Analysis<T> : Analysis where T : Feature
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Track<T> <track>k__BackingField;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toAdd;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toRemove;

		[Token(Token = "0x1700005F")]
		public new Track<T> track
		{
			[Token(Token = "0x6000448")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000449")]
			private set
			{
			}
		}

		[Token(Token = "0x600044A")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x600044B")]
		protected sealed override Track GetTrack()
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		protected void AddFeature(T feature)
		{
		}

		[Token(Token = "0x600044D")]
		protected void RemoveFeature(T feature)
		{
		}

		[Token(Token = "0x600044E")]
		private void Update()
		{
		}

		[Token(Token = "0x600044F")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BeatTrack : Track<Beat>
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x77E850", Offset = "0x77E850", VA = "0x77E850")]
		public BeatTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class Beat : Feature
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float bpm;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x77E8BC", Offset = "0x77E8BC", VA = "0x77E8BC")]
		public Beat()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[DisallowMultipleComponent]
	public class BeatTracker : Analysis<Beat>
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] signalBuffer;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] signal;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] smoothedSignal;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] autoCorrelation;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] combFilter;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] lengthScore;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] offsetScore;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] signalWindow;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] offsetWindow;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] kernel;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] prevMagnitude;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float prevSpectralFlux;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int maxBeatLength;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int minBeatLength;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int beatLength;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int prevBeatLength;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int beatOffset;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int updateOffset;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int bufferSize;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int resolution;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int combElements;

		[Token(Token = "0x17000060")]
		public override string name
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x77E8CC", Offset = "0x77E8CC", VA = "0x77E8CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x77E90C", Offset = "0x77E90C", VA = "0x77E90C", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x77EE5C", Offset = "0x77EE5C", VA = "0x77EE5C", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x77EFB4", Offset = "0x77EFB4", VA = "0x77EFB4")]
		private float GetSample(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x77F068", Offset = "0x77F068", VA = "0x77F068")]
		private void UpdateSignal()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x77F3CC", Offset = "0x77F3CC", VA = "0x77F3CC")]
		private void UpdateOffset()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x77F1E0", Offset = "0x77F1E0", VA = "0x77F1E0")]
		private void UpdateLength()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x77F9E0", Offset = "0x77F9E0", VA = "0x77F9E0")]
		private void UpdateAutoCorrelation()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x77FB60", Offset = "0x77FB60", VA = "0x77FB60")]
		private void UpdateLengthScore()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x77FDB8", Offset = "0x77FDB8", VA = "0x77FDB8")]
		public BeatTracker()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public static class Bindings<T>
	{
		[Token(Token = "0x20000AF")]
		private delegate T ObjectActivator(params object[] args);

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, ObjectActivator> bindings;

		[Token(Token = "0x600045C")]
		public static T GetBinding(params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x600045D")]
		private static ObjectActivator GetCachedActivator(Type type)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		private static ObjectActivator GetActivator(ConstructorInfo ctor)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		private static Type GetBindingType(Type featureType)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		private static ConstructorInfo GetConstructor(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	public class Chromagram : Analysis<Chroma>
	{
		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int startNote;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int endNote;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int downsampleFactor;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int chromaInterval;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] noteIndices;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] downsampled;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] spectrum;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] magnitude;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] window;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] pitchWindow;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] pitch;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] chroma;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int offset;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[] chromaHistory;

		[Token(Token = "0x17000061")]
		public override string name
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x77FE0C", Offset = "0x77FE0C", VA = "0x77FE0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x77FE4C", Offset = "0x77FE4C", VA = "0x77FE4C", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x780310", Offset = "0x780310", VA = "0x780310", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x780354", Offset = "0x780354", VA = "0x780354")]
		private void Downsample(float[] samples)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x78047C", Offset = "0x78047C", VA = "0x78047C")]
		private void UpdateChroma()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x78019C", Offset = "0x78019C", VA = "0x78019C")]
		private static int FrequencyToIndex(float frequency, int length, int samplerate)
		{
			return default(int);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x780170", Offset = "0x780170", VA = "0x780170")]
		private static float GetMidiFrequency(int index)
		{
			return default(float);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x780B60", Offset = "0x780B60", VA = "0x780B60")]
		public Chromagram()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class ChromaTrack : Track<Chroma>
	{
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x780BBC", Offset = "0x780BBC", VA = "0x780BBC")]
		public ChromaTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class Chroma : Feature
	{
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Note note;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x780B58", Offset = "0x780B58", VA = "0x780B58")]
		public Chroma()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public enum Note
	{
		[Token(Token = "0x40005CD")]
		A,
		[Token(Token = "0x40005CE")]
		ASharp,
		[Token(Token = "0x40005CF")]
		B,
		[Token(Token = "0x40005D0")]
		C,
		[Token(Token = "0x40005D1")]
		CSHARP,
		[Token(Token = "0x40005D2")]
		D,
		[Token(Token = "0x40005D3")]
		DSHARP,
		[Token(Token = "0x40005D4")]
		E,
		[Token(Token = "0x40005D5")]
		F,
		[Token(Token = "0x40005D6")]
		FSHARP,
		[Token(Token = "0x40005D7")]
		G,
		[Token(Token = "0x40005D8")]
		GSHARP
	}
	[Token(Token = "0x20000B4")]
	[RequireComponent(typeof(RhythmPlayer))]
	public class DebugDrawer : MonoBehaviour
	{
		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RhythmPlayer <rhythmPlayer>k__BackingField;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float width;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float height;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float padding;

		[Token(Token = "0x17000062")]
		public RhythmPlayer rhythmPlayer
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x780C28", Offset = "0x780C28", VA = "0x780C28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x780C30", Offset = "0x780C30", VA = "0x780C30")]
			private set
			{
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x780C38", Offset = "0x780C38", VA = "0x780C38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x780C90", Offset = "0x780C90", VA = "0x780C90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x78143C", Offset = "0x78143C", VA = "0x78143C")]
		public DebugDrawer()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public abstract class TrackDrawer
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, TrackDrawer> trackDrawers;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x781134", Offset = "0x781134", VA = "0x781134")]
		public static void Draw(Track track, Rect rect, float start, float end)
		{
		}

		[Token(Token = "0x6000474")]
		protected abstract void DrawTrack(Track track, Rect rect, float start, float end);

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x781458", Offset = "0x781458", VA = "0x781458")]
		public static TrackDrawer GetTrackDrawer(Track track)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B6")]
	public class Feature
	{
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timestamp;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float length;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x77E8C4", Offset = "0x77E8C4", VA = "0x77E8C4")]
		public Feature()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class LomontFFT
	{
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] cosTable;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] sinTable;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7816A0", Offset = "0x7816A0", VA = "0x7816A0")]
		public void FFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x781B20", Offset = "0x781B20", VA = "0x781B20")]
		public void RealFFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x781BCC", Offset = "0x781BCC", VA = "0x781BCC")]
		private void Reconstruct(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x78198C", Offset = "0x78198C", VA = "0x78198C")]
		private void InitializeTables(int length)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7818FC", Offset = "0x7818FC", VA = "0x7818FC")]
		private static void BitReverse(float[] data)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x781D70", Offset = "0x781D70", VA = "0x781D70")]
		private static void Swap(float[] data, int a, int b)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x781DB0", Offset = "0x781DB0", VA = "0x781DB0")]
		public LomontFFT()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class OnsetDetector : Analysis<Onset>
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float normalization;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float threshold;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bufferSize;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int start;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int end;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mean;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m2;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] prevMagnitude;

		[Token(Token = "0x17000063")]
		public override string name
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x781DB8", Offset = "0x781DB8", VA = "0x781DB8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x781DF8", Offset = "0x781DF8", VA = "0x781DF8", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x781ECC", Offset = "0x781ECC", VA = "0x781ECC", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x782090", Offset = "0x782090", VA = "0x782090")]
		private float SpectralDifference(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x782144", Offset = "0x782144", VA = "0x782144")]
		private float Normalize(float sample)
		{
			return default(float);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x7821C0", Offset = "0x7821C0", VA = "0x7821C0")]
		public OnsetDetector()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class OnsetTrack : Track<Onset>
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x782224", Offset = "0x782224", VA = "0x782224")]
		public OnsetTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class Onset : Feature
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float strength;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x7821B8", Offset = "0x7821B8", VA = "0x7821B8")]
		public Onset()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[ExecuteInEditMode]
	public class RhythmAnalyzer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Analysis> <>9__41_0;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Analysis, Track> <>9__41_1;

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x7832FC", Offset = "0x7832FC", VA = "0x7832FC")]
			public <>c()
			{
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x783304", Offset = "0x783304", VA = "0x783304")]
			internal bool <Initialize>b__41_0(Analysis a)
			{
				return default(bool);
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x78332C", Offset = "0x78332C", VA = "0x78332C")]
			internal Track <Initialize>b__41_1(Analysis a)
			{
				return null;
			}
		}

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RhythmData <rhythmData>k__BackingField;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <progress>k__BackingField;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool <isDone>k__BackingField;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool <initialized>k__BackingField;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioClip audioClip;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int hopSize;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int frameSize;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int bufferCount;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int channels;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int sampleRate;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int totalFrames;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastFrame;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] window;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] samples;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] monoSamples;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] spectrum;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] magnitude;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Thread analyze;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AutoResetEvent waitForMainThread;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool getData;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool abort;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int initialLength;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Analysis> analyses;

		[Token(Token = "0x17000064")]
		public RhythmData rhythmData
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x7823F0", Offset = "0x7823F0", VA = "0x7823F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x7823F8", Offset = "0x7823F8", VA = "0x7823F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public float progress
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x782400", Offset = "0x782400", VA = "0x782400")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x782408", Offset = "0x782408", VA = "0x782408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool isDone
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x782410", Offset = "0x782410", VA = "0x782410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x782418", Offset = "0x782418", VA = "0x782418")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool initialized
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x782424", Offset = "0x782424", VA = "0x782424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x78242C", Offset = "0x78242C", VA = "0x78242C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<RhythmData> Initialized
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x782290", Offset = "0x782290", VA = "0x782290")]
			add
			{
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x782340", Offset = "0x782340", VA = "0x782340")]
			remove
			{
			}
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x782438", Offset = "0x782438", VA = "0x782438")]
		public RhythmData Analyze(AudioClip audioClip, float initialLength = 5f)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x78256C", Offset = "0x78256C", VA = "0x78256C")]
		public void Abort()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x7825C8", Offset = "0x7825C8", VA = "0x7825C8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x782A50", Offset = "0x782A50", VA = "0x782A50")]
		private void StartAnalyze()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x782C60", Offset = "0x782C60", VA = "0x782C60")]
		private void Analyze()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x782F0C", Offset = "0x782F0C", VA = "0x782F0C")]
		private void OnAnalysisDone()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x782D4C", Offset = "0x782D4C", VA = "0x782D4C")]
		private void ProcessFrame(float[] samples)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x782D20", Offset = "0x782D20", VA = "0x782D20")]
		private void FillBuffer()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x7830E4", Offset = "0x7830E4", VA = "0x7830E4")]
		private void GetData()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x783190", Offset = "0x783190", VA = "0x783190")]
		private void Update()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x7831F0", Offset = "0x7831F0", VA = "0x7831F0")]
		public RhythmAnalyzer()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class RhythmData : ScriptableObject, IEnumerable<Track>, IEnumerable
	{
		[Token(Token = "0x20000BE")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<Track>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Track <>2__current;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RhythmData <>4__this;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Track>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000069")]
			private Track System.Collections.Generic.IEnumerator<RhythmTool.Track>.Current
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0x7839B8", Offset = "0x7839B8", VA = "0x7839B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x783A00", Offset = "0x783A00", VA = "0x783A00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x7833C8", Offset = "0x7833C8", VA = "0x7833C8")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x7837A4", Offset = "0x7837A4", VA = "0x7837A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x7837C0", Offset = "0x7837C0", VA = "0x7837C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x783968", Offset = "0x783968", VA = "0x783968")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x7839C0", Offset = "0x7839C0", VA = "0x7839C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		private sealed class <>c
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Track> <>9__14_0;

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x783A78", Offset = "0x783A78", VA = "0x783A78")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x783A80", Offset = "0x783A80", VA = "0x783A80")]
			internal bool <OnEnable>b__14_0(Track t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Track> _tracks;

		[Token(Token = "0x17000068")]
		public List<Track> tracks
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x78334C", Offset = "0x78334C", VA = "0x78334C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A1")]
		public Track<T> GetTrack<T>() where T : Feature
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		public Track<T> GetTrack<T>(string trackName) where T : Feature
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		public void GetTracks<T>(List<Track<T>> tracks) where T : Feature
		{
		}

		[Token(Token = "0x60004A4")]
		public void GetTracks<T>(List<Track<T>> tracks, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60004A5")]
		public void GetFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x60004A6")]
		public void GetFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60004A7")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x60004A8")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x783354", Offset = "0x783354", VA = "0x783354", Slot = "4")]
		public IEnumerator<Track> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7833F0", Offset = "0x7833F0", VA = "0x7833F0", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x783480", Offset = "0x783480", VA = "0x783480")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x783588", Offset = "0x783588", VA = "0x783588")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x78298C", Offset = "0x78298C", VA = "0x78298C")]
		public static RhythmData Create(AudioClip audioClip, IEnumerable<Track> tracks)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x78371C", Offset = "0x78371C", VA = "0x78371C")]
		public RhythmData()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class RhythmEventProvider : RhythmTarget
	{
		[Token(Token = "0x20000C1")]
		private abstract class RhythmEvent : IDisposable
		{
			[Token(Token = "0x60004C3")]
			public abstract void Process(RhythmData rhythmData, float start, float end);

			[Token(Token = "0x60004C4")]
			public abstract void Dispose();

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x783F14", Offset = "0x783F14", VA = "0x783F14")]
			protected RhythmEvent()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		private class RhythmEvent<T> : RhythmEvent where T : Feature
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> _action;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<T> _features;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string trackName;

			[Token(Token = "0x60004C6")]
			public RhythmEvent(string trackName)
			{
			}

			[Token(Token = "0x60004C7")]
			public override void Process(RhythmData rhythmData, float start, float end)
			{
			}

			[Token(Token = "0x60004C8")]
			public void Register(Action<T> action)
			{
			}

			[Token(Token = "0x60004C9")]
			public void Unregister(Action<T> action)
			{
			}

			[Token(Token = "0x60004CA")]
			public override void Dispose()
			{
			}
		}

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float offset;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, RhythmEvent> _events;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x783ADC", Offset = "0x783ADC", VA = "0x783ADC", Slot = "4")]
		public override void Process(RhythmData rhythmData, float start, float end)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x783C58", Offset = "0x783C58", VA = "0x783C58", Slot = "5")]
		public override void Reset(RhythmData rhythmData, float time)
		{
		}

		[Token(Token = "0x60004BB")]
		public void Register<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x60004BC")]
		public void Unregister<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x60004BD")]
		public void Register<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60004BE")]
		public void Unregister<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x783C7C", Offset = "0x783C7C", VA = "0x783C7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x783E18", Offset = "0x783E18", VA = "0x783E18")]
		private static int GetHashCode(Type type, string trackName)
		{
			return default(int);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x783E78", Offset = "0x783E78", VA = "0x783E78")]
		private static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x783E84", Offset = "0x783E84", VA = "0x783E84")]
		public RhythmEventProvider()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[RequireComponent(typeof(AudioSource))]
	public class RhythmPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audioSource>k__BackingField;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <prevTime>k__BackingField;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RhythmData rhythmData;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<RhythmTarget> targets;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _time;

		[Token(Token = "0x1700006B")]
		public AudioSource audioSource
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x78418C", Offset = "0x78418C", VA = "0x78418C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x784194", Offset = "0x784194", VA = "0x784194")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public AudioClip audioClip
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x78419C", Offset = "0x78419C", VA = "0x78419C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public float time
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x78421C", Offset = "0x78421C", VA = "0x78421C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x784224", Offset = "0x784224", VA = "0x784224")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float volume
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x784248", Offset = "0x784248", VA = "0x784248")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x784264", Offset = "0x784264", VA = "0x784264")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float pitch
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x784280", Offset = "0x784280", VA = "0x784280")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x78429C", Offset = "0x78429C", VA = "0x78429C")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool isPlaying
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x7842B8", Offset = "0x7842B8", VA = "0x7842B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public float prevTime
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x7842D4", Offset = "0x7842D4", VA = "0x7842D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x7842DC", Offset = "0x7842DC", VA = "0x7842DC")]
			private set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action SongEnded
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x783F1C", Offset = "0x783F1C", VA = "0x783F1C")]
			add
			{
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x783FB8", Offset = "0x783FB8", VA = "0x783FB8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action Reset
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x784054", Offset = "0x784054", VA = "0x784054")]
			add
			{
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x7840F0", Offset = "0x7840F0", VA = "0x7840F0")]
			remove
			{
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7842E4", Offset = "0x7842E4", VA = "0x7842E4")]
		public void Play()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x784578", Offset = "0x784578", VA = "0x784578")]
		public void Stop()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x784594", Offset = "0x784594", VA = "0x784594")]
		public void Pause()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7845B0", Offset = "0x7845B0", VA = "0x7845B0")]
		public void UnPause()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x7845CC", Offset = "0x7845CC", VA = "0x7845CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x784624", Offset = "0x784624", VA = "0x784624")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x784934", Offset = "0x784934", VA = "0x784934")]
		private void OnSongEnded()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7843B4", Offset = "0x7843B4", VA = "0x7843B4")]
		private void OnReset()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x784950", Offset = "0x784950", VA = "0x784950")]
		public RhythmPlayer()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class RhythmTarget : ScriptableObject
	{
		[Token(Token = "0x60004E4")]
		public abstract void Process(RhythmData rhythmData, float start, float end);

		[Token(Token = "0x60004E5")]
		public abstract void Reset(RhythmData rhythmData, float time);

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x783F0C", Offset = "0x783F0C", VA = "0x783F0C")]
		protected RhythmTarget()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class Segmenter : Analysis<Value>
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float threshold;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int smoothing;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 changeWeight;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float changeStartSlope;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float changeEndSlope;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int iterations;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int bufferSize;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[][] buffer;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] kernel;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float w;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float current;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float next;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool change;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float changeSign;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector2 changeStart;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float maxSlope;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int maxSlopeIndex;

		[Token(Token = "0x17000072")]
		public override string name
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x784958", Offset = "0x784958", VA = "0x784958", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x784998", Offset = "0x784998", VA = "0x784998", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x784B74", Offset = "0x784B74", VA = "0x784B74", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x784E34", Offset = "0x784E34", VA = "0x784E34")]
		private void FindSegments()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x784E94", Offset = "0x784E94", VA = "0x784E94")]
		private void FindChangeEnd(float slope)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x785010", Offset = "0x785010", VA = "0x785010")]
		private void FindChangeStart(float slope)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x78507C", Offset = "0x78507C", VA = "0x78507C")]
		public Segmenter()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public abstract class Track : ScriptableObject
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x17000073")]
		public new string name
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x7850F4", Offset = "0x7850F4", VA = "0x7850F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7850FC", Offset = "0x7850FC", VA = "0x7850FC")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public abstract class Track<T> : Track where T : Feature
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Comparison<T> <>9__11_0;

			[Token(Token = "0x6000501")]
			public <>c()
			{
			}

			[Token(Token = "0x6000502")]
			internal int <Sort>b__11_0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _features;

		[NonSerialized]
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<int> cachedTimestamps;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, int> cachedIndices;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type concreteType;

		[Token(Token = "0x17000074")]
		public T this[int index]
		{
			[Token(Token = "0x60004F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public int count
		{
			[Token(Token = "0x60004F1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004F2")]
		static Track()
		{
		}

		[Token(Token = "0x60004F3")]
		public void Add(T feature)
		{
		}

		[Token(Token = "0x60004F4")]
		public void Remove(T feature)
		{
		}

		[Token(Token = "0x60004F5")]
		public void Sort()
		{
		}

		[Token(Token = "0x60004F6")]
		public void GetFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60004F7")]
		public void GetIntersectingFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60004F8")]
		public int GetIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60004F9")]
		public int GetIndex(T feature)
		{
			return default(int);
		}

		[Token(Token = "0x60004FA")]
		public int GetIntersectingIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60004FB")]
		private int BinarySearch(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60004FC")]
		private int GetCacheIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		private void ClearCache(float timestamp)
		{
		}

		[Token(Token = "0x60004FE")]
		public static Track<T> Create(string name)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Util
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LomontFFT fft;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x782F18", Offset = "0x782F18", VA = "0x782F18")]
		public static void GetMono(float[] samples, float[] monoSamples, int channels = 0)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x780940", Offset = "0x780940", VA = "0x780940")]
		public static void GetSpectrum(float[] samples)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7809AC", Offset = "0x7809AC", VA = "0x7809AC")]
		public static void GetSpectrumMagnitude(float[] spectrum, float[] magnitude)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7808D4", Offset = "0x7808D4", VA = "0x7808D4")]
		internal static void ApplyWindow(float[] array, float[] window)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x780AEC", Offset = "0x780AEC", VA = "0x780AEC")]
		public static float Mean(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x784D90", Offset = "0x784D90", VA = "0x784D90")]
		public static float WeightedSum(float[] array, float[] kernel, int index)
		{
			return default(float);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x77F960", Offset = "0x77F960", VA = "0x77F960")]
		public static int MaxIndex(float[] array, int start = 0, int end = 0)
		{
			return default(int);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x77FD28", Offset = "0x77FD28", VA = "0x77FD28")]
		public static float Max(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x77F80C", Offset = "0x77F80C", VA = "0x77F80C")]
		public static void Smooth(float[] array, float[] smoothedArray, float[] kernel)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x77F8D8", Offset = "0x77F8D8", VA = "0x77F8D8")]
		public static float Interpolate(float[] array, float index)
		{
			return default(float);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x785104", Offset = "0x785104", VA = "0x785104")]
		public static void HannWindow(float[] array)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x780284", Offset = "0x780284", VA = "0x780284")]
		public static float[] HannWindow(int length)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x77EE20", Offset = "0x77EE20", VA = "0x77EE20")]
		public static float HannWindow(int n, int windowSize)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000CA")]
	public class ValueTrack : Track<Value>
	{
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x785260", Offset = "0x785260", VA = "0x785260")]
		public ValueTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class Value : Feature
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x785074", Offset = "0x785074", VA = "0x785074")]
		public Value()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class VolumeSampler : Analysis<Value>
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _interval;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _smoothing;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int smoothingBufferSize;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] buffer;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] smoothingBuffer;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] smoothingKernel;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float w;

		[Token(Token = "0x17000076")]
		public override string name
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x7852CC", Offset = "0x7852CC", VA = "0x7852CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public int interval
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x78530C", Offset = "0x78530C", VA = "0x78530C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x785314", Offset = "0x785314", VA = "0x785314")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public int smoothing
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x785330", Offset = "0x785330", VA = "0x785330")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x785338", Offset = "0x785338", VA = "0x785338")]
			set
			{
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x785350", Offset = "0x785350", VA = "0x785350", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7854C4", Offset = "0x7854C4", VA = "0x7854C4", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7856DC", Offset = "0x7856DC", VA = "0x7856DC")]
		public VolumeSampler()
		{
		}
	}
}
namespace RhythmTool.Examples
{
	[Token(Token = "0x20000CD")]
	public abstract class SongSelector : MonoBehaviour
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x785730", Offset = "0x785730", VA = "0x785730", Slot = "4")]
		public virtual void NextSong()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x785754", Offset = "0x785754", VA = "0x785754")]
		protected SongSelector()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class AudioClipSelector : SongSelector
	{
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioClip> songs;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentSong;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x78575C", Offset = "0x78575C", VA = "0x78575C")]
		private void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x785768", Offset = "0x785768", VA = "0x785768", Slot = "4")]
		public override void NextSong()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x785858", Offset = "0x785858", VA = "0x785858")]
		public AudioClipSelector()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <timestamp>k__BackingField;

		[Token(Token = "0x17000079")]
		public float timestamp
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x785868", Offset = "0x785868", VA = "0x785868")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x785870", Offset = "0x785870", VA = "0x785870")]
			private set
			{
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x785878", Offset = "0x785878", VA = "0x785878")]
		public void Init(Color color, float opacity, float timestamp)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x78595C", Offset = "0x78595C", VA = "0x78595C")]
		public Line()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class Visualizer : MonoBehaviour
	{
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RhythmEventProvider eventProvider;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text textBPM;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Line linePrefab;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Line> lines;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Chroma> chromaFeatures;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Note lastNote;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x785964", Offset = "0x785964", VA = "0x785964")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x785C64", Offset = "0x785C64", VA = "0x785C64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x785CA0", Offset = "0x785CA0", VA = "0x785CA0")]
		private void UpdateLines()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x78612C", Offset = "0x78612C", VA = "0x78612C")]
		private void OnInitialized(RhythmData rhythmData)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x786144", Offset = "0x786144", VA = "0x786144")]
		private void OnReset()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7862FC", Offset = "0x7862FC", VA = "0x7862FC")]
		private void OnBeat(Beat beat)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x786638", Offset = "0x786638", VA = "0x786638")]
		private void OnOnset(Onset onset)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x78690C", Offset = "0x78690C", VA = "0x78690C")]
		private void OnSegment(Value segment)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x786480", Offset = "0x786480", VA = "0x786480")]
		private void CreateLine(float timestamp, float position, float scale, Color color, float opacity)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x786948", Offset = "0x786948", VA = "0x786948")]
		public Visualizer()
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x20000D1")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x787958", Offset = "0x787958", VA = "0x787958")]
		private void Update()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x787B30", Offset = "0x787B30", VA = "0x787B30")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController Instance;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x787B38", Offset = "0x787B38", VA = "0x787B38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x787B90", Offset = "0x787B90", VA = "0x787B90")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Sensitivity;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _oldMousePos;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x787BA8", Offset = "0x787BA8", VA = "0x787BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x787C04", Offset = "0x787C04", VA = "0x787C04")]
		public CUI_CameraRotationOnButtonHeld()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class CUI_ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x787C14", Offset = "0x787C14", VA = "0x787C14")]
		public void ChangeColorToBlue()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x787C88", Offset = "0x787C88", VA = "0x787C88")]
		public void ChangeColorToCyan()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x787CFC", Offset = "0x787CFC", VA = "0x787CFC")]
		public void ChangeColorToWhite()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x787D70", Offset = "0x787D70", VA = "0x787D70")]
		public CUI_ChangeColor()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x787D78", Offset = "0x787D78", VA = "0x787D78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x787DF4", Offset = "0x787DF4", VA = "0x787DF4")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x787F44", Offset = "0x787F44", VA = "0x787F44", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x787FD4", Offset = "0x787FD4", VA = "0x787FD4", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x788058", Offset = "0x788058", VA = "0x788058")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x788060", Offset = "0x788060", VA = "0x788060", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x788378", Offset = "0x788378", VA = "0x788378", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x788AE0", Offset = "0x788AE0", VA = "0x788AE0", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7881A0", Offset = "0x7881A0", VA = "0x7881A0")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x788B48", Offset = "0x788B48", VA = "0x788B48")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x788B50", Offset = "0x788B50", VA = "0x788B50", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x788E70", Offset = "0x788E70", VA = "0x788E70", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x788E74", Offset = "0x788E74", VA = "0x788E74", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x788EE8", Offset = "0x788EE8", VA = "0x788EE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x788C98", Offset = "0x788C98", VA = "0x788C98")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x788FFC", Offset = "0x788FFC", VA = "0x788FFC")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		private sealed class <>c
		{
			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x789520", Offset = "0x789520", VA = "0x789520")]
			public <>c()
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x789528", Offset = "0x789528", VA = "0x789528")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x789004", Offset = "0x789004", VA = "0x789004")]
		private void Update()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x7894A8", Offset = "0x7894A8", VA = "0x7894A8")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 lastMouse;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x7895E4", Offset = "0x7895E4", VA = "0x7895E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x789640", Offset = "0x789640", VA = "0x789640")]
		private void Update()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7897AC", Offset = "0x7897AC", VA = "0x7897AC")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7897C0", Offset = "0x7897C0", VA = "0x7897C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x789804", Offset = "0x789804", VA = "0x789804")]
		private void Update()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x789A18", Offset = "0x789A18", VA = "0x789A18")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x789A28", Offset = "0x789A28", VA = "0x789A28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x789A80", Offset = "0x789A80", VA = "0x789A80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x78A014", Offset = "0x78A014", VA = "0x78A014")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x78A01C", Offset = "0x78A01C", VA = "0x78A01C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x78A09C", Offset = "0x78A09C", VA = "0x78A09C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x78A170", Offset = "0x78A170", VA = "0x78A170")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x78A180", Offset = "0x78A180", VA = "0x78A180")]
		private void Start()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x78A200", Offset = "0x78A200", VA = "0x78A200")]
		private void Update()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x78A280", Offset = "0x78A280", VA = "0x78A280")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x78A294", Offset = "0x78A294", VA = "0x78A294")]
		public void PickThis()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x78A434", Offset = "0x78A434", VA = "0x78A434")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x78A43C", Offset = "0x78A43C", VA = "0x78A43C")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x78A494", Offset = "0x78A494", VA = "0x78A494")]
		private void Update()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x78A574", Offset = "0x78A574", VA = "0x78A574")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x78A57C", Offset = "0x78A57C", VA = "0x78A57C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x78A8FC", Offset = "0x78A8FC", VA = "0x78A8FC")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x78A910", Offset = "0x78A910", VA = "0x78A910")]
		private void Start()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x78A980", Offset = "0x78A980", VA = "0x78A980")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x20000E4")]
		private enum ViveButton
		{
			[Token(Token = "0x400067B")]
			Trigger,
			[Token(Token = "0x400067C")]
			TouchpadTouch,
			[Token(Token = "0x400067D")]
			TouchpadPress,
			[Token(Token = "0x400067E")]
			Grip,
			[Token(Token = "0x400067F")]
			Menu
		}

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x78A988", Offset = "0x78A988", VA = "0x78A988")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x78A9A8", Offset = "0x78A9A8", VA = "0x78A9A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x78A9B4", Offset = "0x78A9B4", VA = "0x78A9B4")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x78A9D0", Offset = "0x78A9D0", VA = "0x78A9D0")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x78A9D8", Offset = "0x78A9D8", VA = "0x78A9D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x78AB00", Offset = "0x78AB00", VA = "0x78AB00")]
		private void Update()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x78AB88", Offset = "0x78AB88", VA = "0x78AB88")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x78AB90", Offset = "0x78AB90", VA = "0x78AB90")]
		private void Update()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x78AE84", Offset = "0x78AE84", VA = "0x78AE84")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x78AE8C", Offset = "0x78AE8C", VA = "0x78AE8C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x78AEF0", Offset = "0x78AEF0", VA = "0x78AEF0")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x78AF48", Offset = "0x78AF48", VA = "0x78AF48")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x7899FC", Offset = "0x7899FC", VA = "0x7899FC")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x78AF78", Offset = "0x78AF78", VA = "0x78AF78")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x78AFA4", Offset = "0x78AFA4", VA = "0x78AFA4")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x78AFB8", Offset = "0x78AFB8", VA = "0x78AFB8")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x789498", Offset = "0x789498", VA = "0x789498")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x7894A0", Offset = "0x7894A0", VA = "0x7894A0")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x789490", Offset = "0x789490", VA = "0x789490")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x788734", Offset = "0x788734", VA = "0x788734")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000579")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x20000EA")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool autoSwitchHands;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform leftHandOverride;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform rightHandOverride;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x78AFC0", Offset = "0x78AFC0", VA = "0x78AFC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x78B2C4", Offset = "0x78B2C4", VA = "0x78B2C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x78B028", Offset = "0x78B028", VA = "0x78B028")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x78B4B4", Offset = "0x78B4B4", VA = "0x78B4B4")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000EC")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000591")]
				[Address(RVA = "0x78C094", Offset = "0x78C094", VA = "0x78C094", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x78C0DC", Offset = "0x78C0DC", VA = "0x78C0DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x78BC84", Offset = "0x78BC84", VA = "0x78BC84")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x78BF78", Offset = "0x78BF78", VA = "0x78BF78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x78BF7C", Offset = "0x78BF7C", VA = "0x78BF7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x78C09C", Offset = "0x78C09C", VA = "0x78C09C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x1700007A")]
		public Color CaretColor
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x78BF00", Offset = "0x78BF00", VA = "0x78BF00")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x78BF0C", Offset = "0x78BF0C", VA = "0x78BF0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x78BF18", Offset = "0x78BF18", VA = "0x78BF18")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x78BF24", Offset = "0x78BF24", VA = "0x78BF24")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x78BF30", Offset = "0x78BF30", VA = "0x78BF30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x78BF4C", Offset = "0x78BF4C", VA = "0x78BF4C")]
			set
			{
			}
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x78B4C4", Offset = "0x78B4C4", VA = "0x78B4C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x78B51C", Offset = "0x78B51C", VA = "0x78B51C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x78B7E0", Offset = "0x78B7E0", VA = "0x78B7E0", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x78BC50", Offset = "0x78BC50", VA = "0x78BC50", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x78BBDC", Offset = "0x78BBDC", VA = "0x78BBDC")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x78B890", Offset = "0x78B890", VA = "0x78B890")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x78B52C", Offset = "0x78B52C", VA = "0x78B52C")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x78BCAC", Offset = "0x78BCAC", VA = "0x78BCAC")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x78BF68", Offset = "0x78BF68", VA = "0x78BF68")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		private sealed class <>c
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__3_0;

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x78C6E0", Offset = "0x78C6E0", VA = "0x78C6E0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x78C6E8", Offset = "0x78C6E8", VA = "0x78C6E8")]
			internal bool <Update>b__3_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x78C0E4", Offset = "0x78C0E4", VA = "0x78C0E4")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x78C668", Offset = "0x78C668", VA = "0x78C668")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RaycastHit hitInfo;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastResult result;

		[Token(Token = "0x1700007F")]
		public int CompoundEventMask
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x78CB24", Offset = "0x78CB24", VA = "0x78CB24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000080")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x78CC18", Offset = "0x78CC18", VA = "0x78CC18", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public virtual int Depth
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x78CCD4", Offset = "0x78CCD4", VA = "0x78CCD4", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000082")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x78CD98", Offset = "0x78CD98", VA = "0x78CD98", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x78C7C8", Offset = "0x78C7C8", VA = "0x78C7C8")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x78C7D8", Offset = "0x78C7D8", VA = "0x78C7D8", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		private sealed class <>c
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__21_0;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__32_0;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x795A48", Offset = "0x795A48", VA = "0x795A48")]
			public <>c()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x795A50", Offset = "0x795A50", VA = "0x795A50")]
			internal bool <Update>b__21_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x795B08", Offset = "0x795B08", VA = "0x795B08")]
			internal int <FlatRaycastAndSort>b__32_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x795B5C", Offset = "0x795B5C", VA = "0x795B5C")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x17000083")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x78DC94", Offset = "0x78DC94", VA = "0x78DC94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x794E40", Offset = "0x794E40", VA = "0x794E40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x78CDA0", Offset = "0x78CDA0", VA = "0x78CDA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x78CFE0", Offset = "0x78CFE0", VA = "0x78CFE0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x78D714", Offset = "0x78D714", VA = "0x78D714", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x78DAF8", Offset = "0x78DAF8", VA = "0x78DAF8")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x78DAD8", Offset = "0x78DAD8", VA = "0x78DAD8")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x78E1FC", Offset = "0x78E1FC", VA = "0x78E1FC", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x78F48C", Offset = "0x78F48C", VA = "0x78F48C", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x78FC34", Offset = "0x78FC34", VA = "0x78FC34", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x790308", Offset = "0x790308", VA = "0x790308", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x790904", Offset = "0x790904", VA = "0x790904", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x78EE78", Offset = "0x78EE78", VA = "0x78EE78")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x791490", Offset = "0x791490", VA = "0x791490")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x78D230", Offset = "0x78D230", VA = "0x78D230")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x793480", Offset = "0x793480", VA = "0x793480")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x791A04", Offset = "0x791A04", VA = "0x791A04")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x792694", Offset = "0x792694", VA = "0x792694")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x793534", Offset = "0x793534", VA = "0x793534")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x7944D4", Offset = "0x7944D4", VA = "0x7944D4")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x78FB64", Offset = "0x78FB64", VA = "0x78FB64")]
		private LayerMask GetRaycastLayerMask()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x78FBC4", Offset = "0x78FBC4", VA = "0x78FBC4")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x794520", Offset = "0x794520", VA = "0x794520")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x794550", Offset = "0x794550", VA = "0x794550", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x78E93C", Offset = "0x78E93C", VA = "0x78E93C")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x794568", Offset = "0x794568", VA = "0x794568")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x794B8C", Offset = "0x794B8C", VA = "0x794B8C")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x794D00", Offset = "0x794D00", VA = "0x794D00")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x78D060", Offset = "0x78D060", VA = "0x78D060")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x794E48", Offset = "0x794E48", VA = "0x794E48")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x789404", Offset = "0x789404", VA = "0x789404")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x794E78", Offset = "0x794E78", VA = "0x794E78")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x794F54", Offset = "0x794F54", VA = "0x794F54")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x78DCF4", Offset = "0x78DCF4", VA = "0x78DCF4")]
		public void Click()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x793F90", Offset = "0x793F90", VA = "0x793F90")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x7954B8", Offset = "0x7954B8", VA = "0x7954B8")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x7957AC", Offset = "0x7957AC", VA = "0x7957AC")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[RequireComponent(typeof(Canvas))]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x40006C7")]
			CYLINDER,
			[Token(Token = "0x40006C8")]
			RING,
			[Token(Token = "0x40006C9")]
			SPHERE,
			[Token(Token = "0x40006CA")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x40006B5")]
		public const string Version = "3.3";

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x17000085")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x795C30", Offset = "0x795C30", VA = "0x795C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x796DCC", Offset = "0x796DCC", VA = "0x796DCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public int Angle
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x796DD4", Offset = "0x796DD4", VA = "0x796DD4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x796DDC", Offset = "0x796DDC", VA = "0x796DDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public float Quality
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x796DF0", Offset = "0x796DF0", VA = "0x796DF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x796DF8", Offset = "0x796DF8", VA = "0x796DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x796E14", Offset = "0x796E14", VA = "0x796E14")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x796E1C", Offset = "0x796E1C", VA = "0x796E1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public int VerticalAngle
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x796E3C", Offset = "0x796E3C", VA = "0x796E3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x796E44", Offset = "0x796E44", VA = "0x796E44")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public float RingFill
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x796E64", Offset = "0x796E64", VA = "0x796E64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x787B14", Offset = "0x787B14", VA = "0x787B14")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public float SavedRadius
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x7965D8", Offset = "0x7965D8", VA = "0x7965D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008D")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x796E6C", Offset = "0x796E6C", VA = "0x796E6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x796E74", Offset = "0x796E74", VA = "0x796E74")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x796E94", Offset = "0x796E94", VA = "0x796E94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x796E9C", Offset = "0x796E9C", VA = "0x796E9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool PreserveAspect
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x796EBC", Offset = "0x796EBC", VA = "0x796EBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x796EC4", Offset = "0x796EC4", VA = "0x796EC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool Interactable
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x796EE4", Offset = "0x796EE4", VA = "0x796EE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x796EEC", Offset = "0x796EEC", VA = "0x796EEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x796EF8", Offset = "0x796EF8", VA = "0x796EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x796F00", Offset = "0x796F00", VA = "0x796F00")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x796F0C", Offset = "0x796F0C", VA = "0x796F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x796F14", Offset = "0x796F14", VA = "0x796F14")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		[Obsolete("Use RaycastLayerMask property instead.")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x796FE0", Offset = "0x796FE0", VA = "0x796FE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x797084", Offset = "0x797084", VA = "0x797084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x794B3C", Offset = "0x794B3C", VA = "0x794B3C")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x79723C", Offset = "0x79723C", VA = "0x79723C")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x797514", Offset = "0x797514", VA = "0x797514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x797574", Offset = "0x797574", VA = "0x797574")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public float GazeClickTimer
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x7975DC", Offset = "0x7975DC", VA = "0x7975DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x79763C", Offset = "0x79763C", VA = "0x79763C")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x7976AC", Offset = "0x7976AC", VA = "0x7976AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x79770C", Offset = "0x79770C", VA = "0x79770C")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x79777C", Offset = "0x79777C", VA = "0x79777C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x795BB0", Offset = "0x795BB0", VA = "0x795BB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x795D00", Offset = "0x795D00", VA = "0x795D00")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x796088", Offset = "0x796088", VA = "0x796088")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x796128", Offset = "0x796128", VA = "0x796128")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x7961C8", Offset = "0x7961C8", VA = "0x7961C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x7962E8", Offset = "0x7962E8", VA = "0x7962E8")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x796500", Offset = "0x796500", VA = "0x796500")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x7965FC", Offset = "0x7965FC", VA = "0x7965FC")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x7966D4", Offset = "0x7966D4", VA = "0x7966D4")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x7967A4", Offset = "0x7967A4", VA = "0x7967A4")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x79693C", Offset = "0x79693C", VA = "0x79693C")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x796CC8", Offset = "0x796CC8", VA = "0x796CC8")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x789C14", Offset = "0x789C14", VA = "0x789C14")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x789D7C", Offset = "0x789D7C", VA = "0x789D7C")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x78892C", Offset = "0x78892C", VA = "0x78892C")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x78CEA8", Offset = "0x78CEA8", VA = "0x78CEA8")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x793CE8", Offset = "0x793CE8", VA = "0x793CE8")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x796D50", Offset = "0x796D50", VA = "0x796D50")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x796FE8", Offset = "0x796FE8", VA = "0x796FE8")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x797184", Offset = "0x797184", VA = "0x797184")]
		public void Click()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x78C56C", Offset = "0x78C56C", VA = "0x78C56C")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x797294", Offset = "0x797294", VA = "0x797294")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x7973EC", Offset = "0x7973EC", VA = "0x7973EC")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x7977DC", Offset = "0x7977DC", VA = "0x7977DC")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool DoNotTesselate;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private Vector3 savedPos;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Vector3 savedUp;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private Vector2 savedRectSize;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Color savedColor;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private Vector4 savedTextUV0;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private float savedFill;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x1700009A")]
		private bool tesselationRequired
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x797820", Offset = "0x797820", VA = "0x797820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x797828", Offset = "0x797828", VA = "0x797828")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool TesselationRequired
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x79AB64", Offset = "0x79AB64", VA = "0x79AB64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x787FC8", Offset = "0x787FC8", VA = "0x787FC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool CurvingRequired
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x79AB6C", Offset = "0x79AB6C", VA = "0x79AB6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x79AB74", Offset = "0x79AB74", VA = "0x79AB74")]
			set
			{
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x797834", Offset = "0x797834", VA = "0x797834", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x797938", Offset = "0x797938", VA = "0x797938", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x797AF4", Offset = "0x797AF4", VA = "0x797AF4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x79816C", Offset = "0x79816C", VA = "0x79816C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x798304", Offset = "0x798304", VA = "0x798304")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x798310", Offset = "0x798310", VA = "0x798310")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x79839C", Offset = "0x79839C", VA = "0x79839C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x798AF8", Offset = "0x798AF8", VA = "0x798AF8", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x799ABC", Offset = "0x799ABC", VA = "0x799ABC")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x7991C4", Offset = "0x7991C4", VA = "0x7991C4")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x7992A8", Offset = "0x7992A8", VA = "0x7992A8")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x788814", Offset = "0x788814", VA = "0x788814")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x7997B8", Offset = "0x7997B8", VA = "0x7997B8")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x79953C", Offset = "0x79953C", VA = "0x79953C")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x79A1B0", Offset = "0x79A1B0", VA = "0x79A1B0")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x799D98", Offset = "0x799D98", VA = "0x799D98")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x79A8BC", Offset = "0x79A8BC", VA = "0x79A8BC")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x7964F4", Offset = "0x7964F4", VA = "0x7964F4")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x79AB80", Offset = "0x79AB80", VA = "0x79AB80")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x79ACC8", Offset = "0x79ACC8", VA = "0x79ACC8")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x20000F7")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x79ACD0", Offset = "0x79ACD0", VA = "0x79ACD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x79AD80", Offset = "0x79AD80", VA = "0x79AD80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x79B0A4", Offset = "0x79B0A4", VA = "0x79B0A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x79B220", Offset = "0x79B220", VA = "0x79B220")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x79B22C", Offset = "0x79B22C", VA = "0x79B22C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x79BA38", Offset = "0x79BA38", VA = "0x79BA38")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x79BFDC", Offset = "0x79BFDC", VA = "0x79BFDC")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x79BD00", Offset = "0x79BD00", VA = "0x79BD00")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x79AF34", Offset = "0x79AF34", VA = "0x79AF34")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x79BE60", Offset = "0x79BE60", VA = "0x79BE60")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x79B750", Offset = "0x79B750", VA = "0x79B750")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x79C020", Offset = "0x79C020", VA = "0x79C020")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x79C03C", Offset = "0x79C03C", VA = "0x79C03C")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x79C048", Offset = "0x79C048", VA = "0x79C048")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000F9")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x79DF58", Offset = "0x79DF58", VA = "0x79DF58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x79DFA0", Offset = "0x79DFA0", VA = "0x79DFA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x79DCFC", Offset = "0x79DCFC", VA = "0x79DCFC")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x79DE3C", Offset = "0x79DE3C", VA = "0x79DE3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x79DE40", Offset = "0x79DE40", VA = "0x79DE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x79DF60", Offset = "0x79DF60", VA = "0x79DF60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x1700009D")]
		public Color CaretColor
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x79DDCC", Offset = "0x79DDCC", VA = "0x79DDCC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x79DDD8", Offset = "0x79DDD8", VA = "0x79DDD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x79DDE4", Offset = "0x79DDE4", VA = "0x79DDE4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x79DDF0", Offset = "0x79DDF0", VA = "0x79DDF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x79DDFC", Offset = "0x79DDFC", VA = "0x79DDFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x79DE18", Offset = "0x79DE18", VA = "0x79DE18")]
			set
			{
			}
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x79D120", Offset = "0x79D120", VA = "0x79D120")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x79D594", Offset = "0x79D594", VA = "0x79D594")]
		private void Update()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x79D838", Offset = "0x79D838", VA = "0x79D838", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x79DCC8", Offset = "0x79DCC8", VA = "0x79DCC8", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x79DC54", Offset = "0x79DC54", VA = "0x79DC54")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x79D8E8", Offset = "0x79D8E8", VA = "0x79D8E8")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x79D5A4", Offset = "0x79D5A4", VA = "0x79D5A4")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x79DD24", Offset = "0x79DD24", VA = "0x79DD24")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x79D1D4", Offset = "0x79D1D4", VA = "0x79D1D4")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x79DE34", Offset = "0x79DE34", VA = "0x79DE34")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x79DFA8", Offset = "0x79DFA8", VA = "0x79DFA8")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x79E390", Offset = "0x79E390", VA = "0x79E390")]
		public CurvedUITMPSubmesh()
		{
		}
	}
}
namespace SciFiArsenal
{
	[Token(Token = "0x20000FB")]
	public class SciFiButtonScript : MonoBehaviour
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiFireProjectile effectScript;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SciFiProjectileScript projectileScript;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x79E398", Offset = "0x79E398", VA = "0x79E398")]
		private void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x79E554", Offset = "0x79E554", VA = "0x79E554")]
		private void Update()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x79E4A0", Offset = "0x79E4A0", VA = "0x79E4A0")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x79E580", Offset = "0x79E580", VA = "0x79E580")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x79E658", Offset = "0x79E658", VA = "0x79E658")]
		public SciFiButtonScript()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class SciFiDragMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x79E660", Offset = "0x79E660", VA = "0x79E660")]
		private void Start()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x79E72C", Offset = "0x79E72C", VA = "0x79E72C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x79EAA8", Offset = "0x79EAA8", VA = "0x79EAA8")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x79EAE4", Offset = "0x79EAE4", VA = "0x79EAE4")]
		public SciFiDragMouseOrbit()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class SciFiFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RaycastHit hit;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] projectiles;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform spawnPosition;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int currentProjectile;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float speed;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SciFiButtonScript selectedProjectileButton;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x79EB00", Offset = "0x79EB00", VA = "0x79EB00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x79EB7C", Offset = "0x79EB7C", VA = "0x79EB7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x79EFC8", Offset = "0x79EFC8", VA = "0x79EFC8")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x79EFF8", Offset = "0x79EFF8", VA = "0x79EFF8")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x79F028", Offset = "0x79F028", VA = "0x79F028")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x79F030", Offset = "0x79F030", VA = "0x79F030")]
		public SciFiFireProjectile()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class SciFiLoadSceneOnClick : MonoBehaviour
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x79F040", Offset = "0x79F040", VA = "0x79F040")]
		public void LoadSceneSciFiProjectiles()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x79F0A8", Offset = "0x79F0A8", VA = "0x79F0A8")]
		public void LoadSceneSciFiBeamup()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x79F110", Offset = "0x79F110", VA = "0x79F110")]
		public void LoadSceneSciFiBuff()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x79F178", Offset = "0x79F178", VA = "0x79F178")]
		public void LoadSceneSciFiFlamethrowers2()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x79F1E0", Offset = "0x79F1E0", VA = "0x79F1E0")]
		public void LoadSceneSciFiQuestZone()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x79F248", Offset = "0x79F248", VA = "0x79F248")]
		public void LoadSceneSciFiLightjump()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x79F2B0", Offset = "0x79F2B0", VA = "0x79F2B0")]
		public void LoadSceneSciFiLoot()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x79F318", Offset = "0x79F318", VA = "0x79F318")]
		public void LoadSceneSciFiBeams()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x79F380", Offset = "0x79F380", VA = "0x79F380")]
		public void LoadSceneSciFiPortals()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x79F3E8", Offset = "0x79F3E8", VA = "0x79F3E8")]
		public void LoadSceneSciFiRegenerate()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x79F450", Offset = "0x79F450", VA = "0x79F450")]
		public void LoadSceneSciFiShields()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x79F4B8", Offset = "0x79F4B8", VA = "0x79F4B8")]
		public void LoadSceneSciFiSwirlyAura()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x79F520", Offset = "0x79F520", VA = "0x79F520")]
		public void LoadSceneSciFiWarpgates()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x79F588", Offset = "0x79F588", VA = "0x79F588")]
		public void LoadSceneSciFiJetflame()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x79F5F0", Offset = "0x79F5F0", VA = "0x79F5F0")]
		public void LoadSceneSciFiUltimateNova()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x79F658", Offset = "0x79F658", VA = "0x79F658")]
		public void LoadSceneSciFiFire()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x79F6C0", Offset = "0x79F6C0", VA = "0x79F6C0")]
		public SciFiLoadSceneOnClick()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class SciFiLoadSceneOnClick2 : MonoBehaviour
	{
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x79F6C8", Offset = "0x79F6C8", VA = "0x79F6C8")]
		public void LoadSceneSciFiUpdate1()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x79F730", Offset = "0x79F730", VA = "0x79F730")]
		public void LoadSceneSciFiUpdate2()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x79F798", Offset = "0x79F798", VA = "0x79F798")]
		public void LoadSceneSciFiUpdate3()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x79F800", Offset = "0x79F800", VA = "0x79F800")]
		public void LoadSceneSciFiUpdate4()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x79F868", Offset = "0x79F868", VA = "0x79F868")]
		public void LoadSceneSciFiUpdate5()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x79F8D0", Offset = "0x79F8D0", VA = "0x79F8D0")]
		public void LoadSceneSciFiUpdate6()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x79F938", Offset = "0x79F938", VA = "0x79F938")]
		public void LoadSceneSciFiUpdate7()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x79F9A0", Offset = "0x79F9A0", VA = "0x79F9A0")]
		public SciFiLoadSceneOnClick2()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class SciFiLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		private sealed class <EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SciFiLoopScript <>4__this;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x79FC70", Offset = "0x79FC70", VA = "0x79FC70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x79FCB8", Offset = "0x79FCB8", VA = "0x79FCB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x79FA6C", Offset = "0x79FA6C", VA = "0x79FA6C")]
			[DebuggerHidden]
			public <EffectLoop>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x79FAA4", Offset = "0x79FAA4", VA = "0x79FAA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x79FAA8", Offset = "0x79FAA8", VA = "0x79FAA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x79FC78", Offset = "0x79FC78", VA = "0x79FC78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x79F9A8", Offset = "0x79F9A8", VA = "0x79F9A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x79F9AC", Offset = "0x79F9AC", VA = "0x79F9AC")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x79F9F8", Offset = "0x79F9F8", VA = "0x79F9F8")]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x79FA94", Offset = "0x79FA94", VA = "0x79FA94")]
		public SciFiLoopScript()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class SciFiProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject impactParticle;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectileParticle;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] trailParticles;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 impactNormal;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasCollided;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x79FCC0", Offset = "0x79FCC0", VA = "0x79FCC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x79FFBC", Offset = "0x79FFBC", VA = "0x79FFBC")]
		private void OnCollisionEnter(Collision hit)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x7A03D4", Offset = "0x7A03D4", VA = "0x7A03D4")]
		public SciFiProjectileScript()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class SciFiLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float life;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x7A03DC", Offset = "0x7A03DC", VA = "0x7A03DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x7A04F8", Offset = "0x7A04F8", VA = "0x7A04F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7A0634", Offset = "0x7A0634", VA = "0x7A0634")]
		public SciFiLightFade()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SciFiRotation : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		public enum spaceEnum
		{
			[Token(Token = "0x400073B")]
			Local,
			[Token(Token = "0x400073C")]
			World
		}

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x7A0650", Offset = "0x7A0650", VA = "0x7A0650")]
		private void Update()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7A0724", Offset = "0x7A0724", VA = "0x7A0724")]
		public SciFiRotation()
		{
		}
	}
}
