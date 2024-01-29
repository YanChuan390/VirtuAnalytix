using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using Crosstales.DJ;
using CurvedUI;
using Il2CppDummyDll;
using NAudio.Wave;
using NeuralNetwork;
using Oculus.Platform;
using Oculus.Platform.Models;
using RhythmTool;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
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
	[Address(RVA = "0x890810", Offset = "0x890810", VA = "0x890810")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x890950", Offset = "0x890950", VA = "0x890950")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8911AC", Offset = "0x8911AC", VA = "0x8911AC")]
	public void nextBeam()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x89128C", Offset = "0x89128C", VA = "0x89128C")]
	public void previousBeam()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x89136C", Offset = "0x89136C", VA = "0x89136C")]
	public void UpdateEndOffset()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x89139C", Offset = "0x89139C", VA = "0x89139C")]
	public void UpdateScrollSpeed()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x890D88", Offset = "0x890D88", VA = "0x890D88")]
	private void ShootBeamInDir(Vector3 start, Vector3 dir)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8913CC", Offset = "0x8913CC", VA = "0x8913CC")]
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
	[Address(RVA = "0x8913E8", Offset = "0x8913E8", VA = "0x8913E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x89144C", Offset = "0x89144C", VA = "0x89144C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8914E0", Offset = "0x8914E0", VA = "0x8914E0")]
	private float EvalWave()
	{
		return default(float);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8916AC", Offset = "0x8916AC", VA = "0x8916AC")]
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
	[Address(RVA = "0x891714", Offset = "0x891714", VA = "0x891714")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x89178C", Offset = "0x89178C", VA = "0x89178C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x891868", Offset = "0x891868", VA = "0x891868")]
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
	[Address(RVA = "0x891878", Offset = "0x891878", VA = "0x891878")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x89191C", Offset = "0x89191C", VA = "0x89191C")]
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
			[Address(RVA = "0x891E0C", Offset = "0x891E0C", VA = "0x891E0C", Slot = "4")]
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
			[Address(RVA = "0x891E54", Offset = "0x891E54", VA = "0x891E54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x891B88", Offset = "0x891B88", VA = "0x891B88")]
		[DebuggerHidden]
		public <Import>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x891BB8", Offset = "0x891BB8", VA = "0x891BB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x891BBC", Offset = "0x891BBC", VA = "0x891BBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x891E14", Offset = "0x891E14", VA = "0x891E14", Slot = "8")]
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
	[Address(RVA = "0x89192C", Offset = "0x89192C", VA = "0x89192C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x891A64", Offset = "0x891A64", VA = "0x891A64")]
	private void OnFileSelected(string path)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x891AF8", Offset = "0x891AF8", VA = "0x891AF8")]
	private IEnumerator Import(string path)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x891BB0", Offset = "0x891BB0", VA = "0x891BB0")]
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
		[Address(RVA = "0x891FBC", Offset = "0x891FBC", VA = "0x891FBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x891FC4", Offset = "0x891FC4", VA = "0x891FC4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public virtual AudioClip audioClip
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x891FCC", Offset = "0x891FCC", VA = "0x891FCC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x891FD4", Offset = "0x891FD4", VA = "0x891FD4", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public virtual float progress
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x891FDC", Offset = "0x891FDC", VA = "0x891FDC", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x891FE4", Offset = "0x891FE4", VA = "0x891FE4", Slot = "7")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public virtual bool isDone
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x891FEC", Offset = "0x891FEC", VA = "0x891FEC", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x891FF4", Offset = "0x891FF4", VA = "0x891FF4", Slot = "9")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public virtual bool isInitialized
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x892000", Offset = "0x892000", VA = "0x892000", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x892008", Offset = "0x892008", VA = "0x892008", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual bool isError
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x892014", Offset = "0x892014", VA = "0x892014", Slot = "12")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x89201C", Offset = "0x89201C", VA = "0x89201C", Slot = "13")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public virtual string error
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x892028", Offset = "0x892028", VA = "0x892028", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x892030", Offset = "0x892030", VA = "0x892030", Slot = "15")]
		protected set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<AudioClip> Loaded
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x891E5C", Offset = "0x891E5C", VA = "0x891E5C")]
		add
		{
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x891F0C", Offset = "0x891F0C", VA = "0x891F0C")]
		remove
		{
		}
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x891D20", Offset = "0x891D20", VA = "0x891D20")]
	public void Import(string uri)
	{
	}

	[Token(Token = "0x600002D")]
	public abstract void Abort();

	[Token(Token = "0x600002E")]
	protected abstract void Import();

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x892038", Offset = "0x892038", VA = "0x892038")]
	protected void OnLoaded()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x892074", Offset = "0x892074", VA = "0x892074")]
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
			[Address(RVA = "0x89331C", Offset = "0x89331C", VA = "0x89331C", Slot = "4")]
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
			[Address(RVA = "0x893364", Offset = "0x893364", VA = "0x893364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x892AC0", Offset = "0x892AC0", VA = "0x892AC0")]
		[DebuggerHidden]
		public <refreshFiles>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x893260", Offset = "0x893260", VA = "0x893260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x893264", Offset = "0x893264", VA = "0x893264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x893324", Offset = "0x893324", VA = "0x893324", Slot = "8")]
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
			[Address(RVA = "0x893428", Offset = "0x893428", VA = "0x893428", Slot = "4")]
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
			[Address(RVA = "0x893470", Offset = "0x893470", VA = "0x893470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x892AE8", Offset = "0x892AE8", VA = "0x892AE8")]
		[DebuggerHidden]
		public <refreshDirectories>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x89336C", Offset = "0x89336C", VA = "0x89336C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x893370", Offset = "0x893370", VA = "0x893370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x893430", Offset = "0x893430", VA = "0x893430", Slot = "8")]
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
		[Address(RVA = "0x892D44", Offset = "0x892D44", VA = "0x892D44")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x893478", Offset = "0x893478", VA = "0x893478")]
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
		[Address(RVA = "0x892F98", Offset = "0x892F98", VA = "0x892F98")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x893498", Offset = "0x893498", VA = "0x893498")]
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
		[Address(RVA = "0x8919B4", Offset = "0x8919B4", VA = "0x8919B4")]
		add
		{
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x89207C", Offset = "0x89207C", VA = "0x89207C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x89212C", Offset = "0x89212C", VA = "0x89212C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x89263C", Offset = "0x89263C", VA = "0x89263C")]
	public void Up()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x892298", Offset = "0x892298", VA = "0x892298")]
	private void BuildContent()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x892704", Offset = "0x892704", VA = "0x892704")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x892948", Offset = "0x892948", VA = "0x892948")]
	private void OnFileSelected(int index)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x892A08", Offset = "0x892A08", VA = "0x892A08")]
	private void OnDirectorySelected(int index)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8928D4", Offset = "0x8928D4", VA = "0x8928D4")]
	private IEnumerator refreshFiles()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x892860", Offset = "0x892860", VA = "0x892860")]
	private IEnumerator refreshDirectories()
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x892B10", Offset = "0x892B10", VA = "0x892B10")]
	private void AddFileItem(int index)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x892D4C", Offset = "0x892D4C", VA = "0x892D4C")]
	private void AddDirectoryItem(int index)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x892FA0", Offset = "0x892FA0", VA = "0x892FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x893258", Offset = "0x893258", VA = "0x893258")]
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
			[Address(RVA = "0x893FAC", Offset = "0x893FAC", VA = "0x893FAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x893FB4", Offset = "0x893FB4", VA = "0x893FB4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int sampleRate
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x893FBC", Offset = "0x893FBC", VA = "0x893FBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x893FC4", Offset = "0x893FC4", VA = "0x893FC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int channels
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x893FCC", Offset = "0x893FCC", VA = "0x893FCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x893FD4", Offset = "0x893FD4", VA = "0x893FD4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x893FDC", Offset = "0x893FDC", VA = "0x893FDC")]
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
	[Address(RVA = "0x8934B8", Offset = "0x8934B8", VA = "0x8934B8", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x89366C", Offset = "0x89366C", VA = "0x89366C", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8937F4", Offset = "0x8937F4", VA = "0x8937F4")]
	private void DoImport()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x893A24", Offset = "0x893A24", VA = "0x893A24")]
	private void Decode()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x893B84", Offset = "0x893B84", VA = "0x893B84")]
	private void CreateClip()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x893C3C", Offset = "0x893C3C", VA = "0x893C3C")]
	private void SetData()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x893D6C", Offset = "0x893D6C", VA = "0x893D6C")]
	protected void OnError(string error)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x893910", Offset = "0x893910", VA = "0x893910")]
	private void Dispatch(Action action)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x893DB4", Offset = "0x893DB4", VA = "0x893DB4")]
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
	[Address(RVA = "0x893EE8", Offset = "0x893EE8", VA = "0x893EE8")]
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
			[Address(RVA = "0x89435C", Offset = "0x89435C", VA = "0x89435C", Slot = "4")]
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
			[Address(RVA = "0x8943A4", Offset = "0x8943A4", VA = "0x8943A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x89424C", Offset = "0x89424C", VA = "0x89424C")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x89427C", Offset = "0x89427C", VA = "0x89427C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x894280", Offset = "0x894280", VA = "0x894280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x894364", Offset = "0x894364", VA = "0x894364", Slot = "8")]
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
		[Address(RVA = "0x894018", Offset = "0x894018", VA = "0x894018", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public override bool isDone
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x894030", Offset = "0x894030", VA = "0x894030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public override bool isInitialized
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x894044", Offset = "0x894044", VA = "0x894044", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public override bool isError
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x894050", Offset = "0x894050", VA = "0x894050", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public override string error
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x894090", Offset = "0x894090", VA = "0x894090", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x8940F4", Offset = "0x8940F4", VA = "0x8940F4", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x894158", Offset = "0x894158", VA = "0x894158", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8941D8", Offset = "0x8941D8", VA = "0x8941D8")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x894274", Offset = "0x894274", VA = "0x894274")]
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
	[Address(RVA = "0x8943AC", Offset = "0x8943AC", VA = "0x8943AC", Slot = "18")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8945AC", Offset = "0x8945AC", VA = "0x8945AC", Slot = "19")]
	protected override void Cleanup()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8945F4", Offset = "0x8945F4", VA = "0x8945F4", Slot = "21")]
	protected override AudioInfo GetInfo()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8946C0", Offset = "0x8946C0", VA = "0x8946C0", Slot = "20")]
	protected override int GetSamples(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x894780", Offset = "0x894780", VA = "0x894780")]
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
	[Address(RVA = "0x894784", Offset = "0x894784", VA = "0x894784")]
	private void Start()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x895808", Offset = "0x895808", VA = "0x895808")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x89486C", Offset = "0x89486C", VA = "0x89486C")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x895E14", Offset = "0x895E14", VA = "0x895E14")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x89664C", Offset = "0x89664C", VA = "0x89664C")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x895AA8", Offset = "0x895AA8", VA = "0x895AA8")]
	private void GeneratePiramid(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x896B64", Offset = "0x896B64", VA = "0x896B64")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x896BEC", Offset = "0x896BEC", VA = "0x896BEC")]
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
		[Address(RVA = "0x897E40", Offset = "0x897E40", VA = "0x897E40")]
		public OnBeatEventHandler()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000016")]
	public class OnSpectrumEventHandler : UnityEvent<float[]>
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x897E48", Offset = "0x897E48", VA = "0x897E48")]
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
		[Address(RVA = "0x896FBC", Offset = "0x896FBC", VA = "0x896FBC")]
		public Autoco(int len, float alpha, float framePeriod, float bandwidth)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x8979A0", Offset = "0x8979A0", VA = "0x8979A0")]
		public void newVal(float val)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x897A60", Offset = "0x897A60", VA = "0x897A60")]
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
	[Address(RVA = "0x896BF4", Offset = "0x896BF4", VA = "0x896BF4")]
	private long getCurrentTimeMillis()
	{
		return default(long);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x896C78", Offset = "0x896C78", VA = "0x896C78")]
	private void initArrays()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x896DAC", Offset = "0x896DAC", VA = "0x896DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8971B0", Offset = "0x8971B0", VA = "0x8971B0")]
	public void tapTempo()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x89727C", Offset = "0x89727C", VA = "0x89727C")]
	private double[] toDoubleArray(float[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x89732C", Offset = "0x89732C", VA = "0x89732C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x897AB4", Offset = "0x897AB4", VA = "0x897AB4")]
	public void changeCameraColor()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x896F98", Offset = "0x896F98", VA = "0x896F98")]
	public float getBandWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x897B84", Offset = "0x897B84", VA = "0x897B84")]
	public int freqToIndex(int freq)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8977D8", Offset = "0x8977D8", VA = "0x8977D8")]
	public void computeAverages(float[] data)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x897CD8", Offset = "0x897CD8", VA = "0x897CD8")]
	private float map(float s, float a1, float a2, float b1, float b2)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x897CF4", Offset = "0x897CF4", VA = "0x897CF4")]
	public float constrain(float value, float inclusiveMinimum, float inlusiveMaximum)
	{
		return default(float);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x897D10", Offset = "0x897D10", VA = "0x897D10")]
	public void OnBeat()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x897DFC", Offset = "0x897DFC", VA = "0x897DFC")]
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
	[Address(RVA = "0x897E90", Offset = "0x897E90", VA = "0x897E90")]
	public void SetBeats(List<float> times)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x897F70", Offset = "0x897F70", VA = "0x897F70")]
	public int TimeToSection(float time)
	{
		return default(int);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x897FF0", Offset = "0x897FF0", VA = "0x897FF0")]
	public float SectionToTime(int section)
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x89801C", Offset = "0x89801C", VA = "0x89801C")]
	public void Process(Game game)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8988D4", Offset = "0x8988D4", VA = "0x8988D4")]
	private void TrainNotesNN()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x898C14", Offset = "0x898C14", VA = "0x898C14")]
	private void SaveBeatSamples(List<DataSet> data, string name)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8982A0", Offset = "0x8982A0", VA = "0x8982A0")]
	private void MultiTrainNN()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x899054", Offset = "0x899054", VA = "0x899054")]
	private void LoadWeights()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8991F4", Offset = "0x8991F4", VA = "0x8991F4")]
	private void MakeNotes()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x899450", Offset = "0x899450", VA = "0x899450")]
	private void TrainBandsNN()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x899764", Offset = "0x899764", VA = "0x899764")]
	private void VisBands()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8999D0", Offset = "0x8999D0", VA = "0x8999D0")]
	private void Train()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x899A00", Offset = "0x899A00", VA = "0x899A00")]
	private void MarkHits()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x899B58", Offset = "0x899B58", VA = "0x899B58")]
	private void VisHits()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x899C00", Offset = "0x899C00", VA = "0x899C00")]
	private void NormalizeFFT()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x899ECC", Offset = "0x899ECC", VA = "0x899ECC")]
	private void AnalyzeFFT()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x89A348", Offset = "0x89A348", VA = "0x89A348")]
	private void MakeMono()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x89A434", Offset = "0x89A434", VA = "0x89A434")]
	public void Compose()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x89A5CC", Offset = "0x89A5CC", VA = "0x89A5CC")]
	private void GenrateEvents()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x89A780", Offset = "0x89A780", VA = "0x89A780")]
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
	[Address(RVA = "0x89A85C", Offset = "0x89A85C", VA = "0x89A85C")]
	private float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x89A8BC", Offset = "0x89A8BC", VA = "0x89A8BC")]
	private bool IsYellow()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x89A8F0", Offset = "0x89A8F0", VA = "0x89A8F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x89A984", Offset = "0x89A984", VA = "0x89A984")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x89AB84", Offset = "0x89AB84", VA = "0x89AB84")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x89BA2C", Offset = "0x89BA2C", VA = "0x89BA2C")]
	private void OnTimeOut()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x89BBBC", Offset = "0x89BBBC", VA = "0x89BBBC")]
	private void PlayFX(string name, Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x89AF14", Offset = "0x89AF14", VA = "0x89AF14")]
	private bool UpdateColls(Vector3 a_pos, Vector3 b_pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x89BD60", Offset = "0x89BD60", VA = "0x89BD60")]
	private void OnPlayerHit()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x89BED4", Offset = "0x89BED4", VA = "0x89BED4")]
	public Bullet()
	{
	}
}
[Token(Token = "0x200001A")]
public class Center : MonoBehaviour
{
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x89BF50", Offset = "0x89BF50", VA = "0x89BF50")]
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
	[Address(RVA = "0x89BF58", Offset = "0x89BF58", VA = "0x89BF58")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x89BFD0", Offset = "0x89BFD0", VA = "0x89BFD0")]
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
	[Address(RVA = "0x89BFD8", Offset = "0x89BFD8", VA = "0x89BFD8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x89BFF0", Offset = "0x89BFF0", VA = "0x89BFF0")]
	public void SwitchColors()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x89C234", Offset = "0x89C234", VA = "0x89C234")]
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
		[Address(RVA = "0x8A20E4", Offset = "0x8A20E4", VA = "0x8A20E4")]
		public <>c()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8A20EC", Offset = "0x8A20EC", VA = "0x8A20EC")]
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
	[Address(RVA = "0x89C24C", Offset = "0x89C24C", VA = "0x89C24C")]
	private int RandomSeq(bool first_in_seg, int up_down, int last_seq, bool full_length)
	{
		return default(int);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x89C480", Offset = "0x89C480", VA = "0x89C480")]
	private int CalculateWeightMod(bool first_in_seg, int up_down, int i)
	{
		return default(int);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x89C584", Offset = "0x89C584", VA = "0x89C584")]
	private void ComposeNotes()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x89D0C4", Offset = "0x89D0C4", VA = "0x89D0C4")]
	private int AddPadding(int beat_idx, int i)
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x89C934", Offset = "0x89C934", VA = "0x89C934")]
	private void UpDownSegments()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x89D31C", Offset = "0x89D31C", VA = "0x89D31C")]
	public void SelectSequences()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x89DC3C", Offset = "0x89DC3C", VA = "0x89DC3C")]
	private int CalculateTempo()
	{
		return default(int);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x89DCA8", Offset = "0x89DCA8", VA = "0x89DCA8")]
	private void MatchNoSequences()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x89DE7C", Offset = "0x89DE7C", VA = "0x89DE7C")]
	public void MatchTempo()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x89E778", Offset = "0x89E778", VA = "0x89E778")]
	private void ReadNotes(string fs)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x89EC7C", Offset = "0x89EC7C", VA = "0x89EC7C")]
	public void CalculateBPM()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x89F0A8", Offset = "0x89F0A8", VA = "0x89F0A8")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x89F18C", Offset = "0x89F18C", VA = "0x89F18C")]
	private void LoadAudioClip()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x89F31C", Offset = "0x89F31C", VA = "0x89F31C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x89F960", Offset = "0x89F960", VA = "0x89F960")]
	public void Compose()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x89FB14", Offset = "0x89FB14", VA = "0x89FB14")]
	public void Abort()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x89FBD0", Offset = "0x89FBD0", VA = "0x89FBD0")]
	public void CutBeats()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x89F3EC", Offset = "0x89F3EC", VA = "0x89F3EC")]
	public void UpdateCompositor()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8A0528", Offset = "0x8A0528", VA = "0x8A0528")]
	private void MakeHeader(string title)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8A064C", Offset = "0x8A064C", VA = "0x8A064C")]
	private void RemoveTooOftenSegments()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8A089C", Offset = "0x8A089C", VA = "0x8A089C")]
	private void CalculateSegments()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8A0D54", Offset = "0x8A0D54", VA = "0x8A0D54")]
	public void CreateTrackTest()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x89FC50", Offset = "0x89FC50", VA = "0x89FC50")]
	public void CreateTrack()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8A0FE4", Offset = "0x8A0FE4", VA = "0x8A0FE4")]
	private void SaveTamps(string title_path, string prefix)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8A1350", Offset = "0x8A1350", VA = "0x8A1350")]
	public void SaveGeneratedTrack(string title_path, string prefix, string notes)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8A142C", Offset = "0x8A142C", VA = "0x8A142C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8A15C0", Offset = "0x8A15C0", VA = "0x8A15C0")]
	private void ReadPreset()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x89F508", Offset = "0x89F508", VA = "0x89F508")]
	private void RefreshOptions()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8A1808", Offset = "0x8A1808", VA = "0x8A1808")]
	public void OnChangePresetName()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8A18DC", Offset = "0x8A18DC", VA = "0x8A18DC")]
	public void OnSelectPreset(int preset_idx)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8A14DC", Offset = "0x8A14DC", VA = "0x8A14DC")]
	private void SelectedPresetToPrefix()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8A1970", Offset = "0x8A1970", VA = "0x8A1970")]
	public void OnClickTOW(int idx)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8A1A1C", Offset = "0x8A1A1C", VA = "0x8A1A1C")]
	public void OnClickTempo(int idx)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8A1AC8", Offset = "0x8A1AC8", VA = "0x8A1AC8")]
	public void OnClickDifferentiation(int idx)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8A1B74", Offset = "0x8A1B74", VA = "0x8A1B74")]
	public void OnClickObstacles(int idx)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8A1C20", Offset = "0x8A1C20", VA = "0x8A1C20")]
	public void OnClickComplexity(int idx)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8A1CCC", Offset = "0x8A1CCC", VA = "0x8A1CCC")]
	public void OnClickJabs(int idx)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8A1D78", Offset = "0x8A1D78", VA = "0x8A1D78")]
	public void OnClickProjectiles()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x8A1E28", Offset = "0x8A1E28", VA = "0x8A1E28")]
	public void OnClickHorizObstacles()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x89CFE8", Offset = "0x89CFE8", VA = "0x89CFE8")]
	private void RandomizeRotation(ref string notes, int part_of_song)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8A1ED8", Offset = "0x8A1ED8", VA = "0x8A1ED8")]
	public Compositor()
	{
	}
}
[Token(Token = "0x2000020")]
public class Damagable : MonoBehaviour
{
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8A2100", Offset = "0x8A2100", VA = "0x8A2100", Slot = "4")]
	public virtual void TakeDamage(int source_id, int damage, Vector3 dir, Vector3 pos)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8A2104", Offset = "0x8A2104", VA = "0x8A2104")]
	public Damagable()
	{
	}
}
[Token(Token = "0x2000021")]
public class Enemy : Damagable
{
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8A210C", Offset = "0x8A210C", VA = "0x8A210C", Slot = "5")]
	public virtual bool IsAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x8A2114", Offset = "0x8A2114", VA = "0x8A2114", Slot = "6")]
	public virtual Vector3 GetAimCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x8A2134", Offset = "0x8A2134", VA = "0x8A2134", Slot = "7")]
	public virtual float GetAimRadius()
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x8A213C", Offset = "0x8A213C", VA = "0x8A213C", Slot = "8")]
	public virtual Vector3 GetAimFutureCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x8A21B8", Offset = "0x8A21B8", VA = "0x8A21B8")]
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
	[Address(RVA = "0x8A21C0", Offset = "0x8A21C0", VA = "0x8A21C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x8A22D8", Offset = "0x8A22D8", VA = "0x8A22D8")]
	private void UpdatePath()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x8A242C", Offset = "0x8A242C", VA = "0x8A242C")]
	private void Shot()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8A2694", Offset = "0x8A2694", VA = "0x8A2694")]
	private void UpdateSpawn()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8A27C4", Offset = "0x8A27C4", VA = "0x8A27C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8A2CD8", Offset = "0x8A2CD8", VA = "0x8A2CD8")]
	private void UpdateFluctuations()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8A2FB8", Offset = "0x8A2FB8", VA = "0x8A2FB8")]
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
	[Address(RVA = "0x8A403C", Offset = "0x8A403C", VA = "0x8A403C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x8A43A4", Offset = "0x8A43A4", VA = "0x8A43A4")]
	private void Hit(RaycastHit hit_info)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x8A4664", Offset = "0x8A4664", VA = "0x8A4664")]
	private void PlayHitFX(string fx_name, string fx_sound, Vector3 pos)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x8A4848", Offset = "0x8A4848", VA = "0x8A4848")]
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
	[Address(RVA = "0x8A486C", Offset = "0x8A486C", VA = "0x8A486C")]
	private void UpdateHue()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x8A49C0", Offset = "0x8A49C0", VA = "0x8A49C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x8A4B58", Offset = "0x8A4B58", VA = "0x8A4B58")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x8A511C", Offset = "0x8A511C", VA = "0x8A511C")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x8A55E0", Offset = "0x8A55E0", VA = "0x8A55E0")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x8A5680", Offset = "0x8A5680", VA = "0x8A5680")]
	private Color HueToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x8A57D0", Offset = "0x8A57D0", VA = "0x8A57D0")]
	private Color HueToLineColor()
	{
		return default(Color);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x8A59C8", Offset = "0x8A59C8", VA = "0x8A59C8")]
	private void UpdateWallEffect()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x8A5AC0", Offset = "0x8A5AC0", VA = "0x8A5AC0")]
	private void UpdateLava()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x8A5BFC", Offset = "0x8A5BFC", VA = "0x8A5BFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x8A6FFC", Offset = "0x8A6FFC", VA = "0x8A6FFC")]
	private void UpdateSkyFog()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x8A5FD0", Offset = "0x8A5FD0", VA = "0x8A5FD0")]
	private void RoundEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x8A6310", Offset = "0x8A6310", VA = "0x8A6310")]
	private void BarsEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x8A693C", Offset = "0x8A693C", VA = "0x8A693C")]
	private void MotionMatUpdate()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x8A6228", Offset = "0x8A6228", VA = "0x8A6228")]
	private void UpdateLightSynchroMats()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x8A7554", Offset = "0x8A7554", VA = "0x8A7554")]
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
	[Address(RVA = "0x8A7618", Offset = "0x8A7618", VA = "0x8A7618")]
	private void Start()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x8A7724", Offset = "0x8A7724", VA = "0x8A7724")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x8A7C20", Offset = "0x8A7C20", VA = "0x8A7C20")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x8A80E8", Offset = "0x8A80E8", VA = "0x8A80E8")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x8A8188", Offset = "0x8A8188", VA = "0x8A8188")]
	private void Update()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x8A88A0", Offset = "0x8A88A0", VA = "0x8A88A0")]
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
	[Address(RVA = "0x8A894C", Offset = "0x8A894C", VA = "0x8A894C")]
	private void Start()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8A8A2C", Offset = "0x8A8A2C", VA = "0x8A8A2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8A8F20", Offset = "0x8A8F20", VA = "0x8A8F20")]
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
			[Address(RVA = "0x8B069C", Offset = "0x8B069C", VA = "0x8B069C", Slot = "4")]
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
			[Address(RVA = "0x8B06E4", Offset = "0x8B06E4", VA = "0x8B06E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8A902C", Offset = "0x8A902C", VA = "0x8A902C")]
		[DebuggerHidden]
		public <LoadAudioClip>d__104(int <>1__state)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x8B0440", Offset = "0x8B0440", VA = "0x8B0440", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x8B0444", Offset = "0x8B0444", VA = "0x8B0444", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8B06A4", Offset = "0x8B06A4", VA = "0x8B06A4", Slot = "8")]
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
			[Address(RVA = "0x8B0910", Offset = "0x8B0910", VA = "0x8B0910", Slot = "4")]
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
			[Address(RVA = "0x8B0958", Offset = "0x8B0958", VA = "0x8B0958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8A90C8", Offset = "0x8A90C8", VA = "0x8A90C8")]
		[DebuggerHidden]
		public <LoadLocalClip>d__105(int <>1__state)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x8B06EC", Offset = "0x8B06EC", VA = "0x8B06EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8B06F0", Offset = "0x8B06F0", VA = "0x8B06F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8B0918", Offset = "0x8B0918", VA = "0x8B0918", Slot = "8")]
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
	[Address(RVA = "0x8A8F28", Offset = "0x8A8F28", VA = "0x8A8F28")]
	public static int GetSourceID()
	{
		return default(int);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x8A8F88", Offset = "0x8A8F88", VA = "0x8A8F88")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x8A8FB8", Offset = "0x8A8FB8", VA = "0x8A8FB8")]
	private IEnumerator LoadAudioClip()
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8A9054", Offset = "0x8A9054", VA = "0x8A9054")]
	private IEnumerator LoadLocalClip()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x8A90F0", Offset = "0x8A90F0", VA = "0x8A90F0")]
	private void Init()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x8A93B8", Offset = "0x8A93B8", VA = "0x8A93B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x8A9A50", Offset = "0x8A9A50", VA = "0x8A9A50")]
	private void ClearEvents()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x8A9B50", Offset = "0x8A9B50", VA = "0x8A9B50")]
	private void StartGame()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x8A9C24", Offset = "0x8A9C24", VA = "0x8A9C24")]
	public void PrepareTrack()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x8A9E28", Offset = "0x8A9E28", VA = "0x8A9E28")]
	public void ParseInfo(string notes)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x8AB32C", Offset = "0x8AB32C", VA = "0x8AB32C")]
	private string ParseTrack(string track, ref int beat_idx, ref bool blue, ref int speed, ref int shift, ref int y_shift)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x8AC3F0", Offset = "0x8AC3F0", VA = "0x8AC3F0")]
	public float GetCurrProgress()
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x8AC400", Offset = "0x8AC400", VA = "0x8AC400")]
	public float GetCurrMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8AC410", Offset = "0x8AC410", VA = "0x8AC410")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8ADE28", Offset = "0x8ADE28", VA = "0x8ADE28")]
	private void CreateMarker(int curr_beat)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x8AE754", Offset = "0x8AE754", VA = "0x8AE754")]
	private bool UpdateTutorial(int curr_beat)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x8AD2CC", Offset = "0x8AD2CC", VA = "0x8AD2CC")]
	private void UpdateTutorialFailAnim()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x8AD3DC", Offset = "0x8AD3DC", VA = "0x8AD3DC")]
	private void UpdateBlackout()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x8AE8AC", Offset = "0x8AE8AC", VA = "0x8AE8AC")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8AE8E4", Offset = "0x8AE8E4", VA = "0x8AE8E4")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x8AC4F8", Offset = "0x8AC4F8", VA = "0x8AC4F8")]
	private void ShowContinueMenu()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8AC7A4", Offset = "0x8AC7A4", VA = "0x8AC7A4")]
	public void OnFinish()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8AE9BC", Offset = "0x8AE9BC", VA = "0x8AE9BC")]
	public void OnFail(bool right)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8A8EF8", Offset = "0x8A8EF8", VA = "0x8A8EF8")]
	public bool IsExitButtonVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8AEA5C", Offset = "0x8AEA5C", VA = "0x8AEA5C")]
	private void ClearExitCondition()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x8AEA90", Offset = "0x8AEA90", VA = "0x8AEA90")]
	public void OnPassBomb(bool right)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x8AEB14", Offset = "0x8AEB14", VA = "0x8AEB14")]
	public void OnPass(bool right)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x8AEBC8", Offset = "0x8AEBC8", VA = "0x8AEBC8")]
	public void OnPassWall()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8AEC40", Offset = "0x8AEC40", VA = "0x8AEC40")]
	public void OnPassBlock()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x8AEE3C", Offset = "0x8AEE3C", VA = "0x8AEE3C")]
	public int OnPass(float speed, float precis, float timimg, bool right, Vector3 pos, Vector3 dir_, bool slash, bool bad_angle = false)
	{
		return default(int);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x8AF178", Offset = "0x8AF178", VA = "0x8AF178")]
	public void OnBomb(bool right)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x8AF210", Offset = "0x8AF210", VA = "0x8AF210")]
	public void OnTimeOut(bool right, bool bulet = false)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x8AEA24", Offset = "0x8AEA24", VA = "0x8AEA24")]
	private void DecraseMul()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x8AF0F8", Offset = "0x8AF0F8", VA = "0x8AF0F8")]
	private void IncraseMul()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x8AF294", Offset = "0x8AF294", VA = "0x8AF294")]
	public int GetCapacity()
	{
		return default(int);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x8AED9C", Offset = "0x8AED9C", VA = "0x8AED9C")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x8AF2E8", Offset = "0x8AF2E8", VA = "0x8AF2E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8A9748", Offset = "0x8A9748", VA = "0x8A9748")]
	public void ReadSequences()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x8AF490", Offset = "0x8AF490", VA = "0x8AF490")]
	private void GetSeq(string line, string letter, int idx, int coll)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x8AAD0C", Offset = "0x8AAD0C", VA = "0x8AAD0C")]
	private string PrepareTrack(string track)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x8AD53C", Offset = "0x8AD53C", VA = "0x8AD53C")]
	private void EnergyCalculator()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x8AF664", Offset = "0x8AF664", VA = "0x8AF664")]
	public void StopPreview()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x8AF6FC", Offset = "0x8AF6FC", VA = "0x8AF6FC")]
	private void LoadLocalClipPrev()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x8AF898", Offset = "0x8AF898", VA = "0x8AF898")]
	private void LoadAudioClipPrev()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x8AF9C4", Offset = "0x8AF9C4", VA = "0x8AF9C4")]
	public void PlayPreview()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x8AFADC", Offset = "0x8AFADC", VA = "0x8AFADC")]
	private void UpdateTimeStamp()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x8AC5D4", Offset = "0x8AC5D4", VA = "0x8AC5D4")]
	private void UpdateBeatIDx()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x8AD274", Offset = "0x8AD274", VA = "0x8AD274")]
	private void AnalyzeEvents()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8AFC80", Offset = "0x8AFC80", VA = "0x8AFC80")]
	private void CheckKeyboard()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x8AFEFC", Offset = "0x8AFEFC", VA = "0x8AFEFC")]
	private void OnExit()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8B00AC", Offset = "0x8B00AC", VA = "0x8B00AC")]
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
	[Address(RVA = "0x8B0960", Offset = "0x8B0960", VA = "0x8B0960")]
	private void Start()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x8B0AF8", Offset = "0x8B0AF8", VA = "0x8B0AF8")]
	private void SetupSFX()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x8B0D80", Offset = "0x8B0D80", VA = "0x8B0D80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x8B142C", Offset = "0x8B142C", VA = "0x8B142C")]
	private void UpdateShield()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8B1AC4", Offset = "0x8B1AC4", VA = "0x8B1AC4")]
	private void UpdateTask()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8B1CF8", Offset = "0x8B1CF8", VA = "0x8B1CF8")]
	public void PlayPunchSFX(float volume)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x8B1E0C", Offset = "0x8B1E0C", VA = "0x8B1E0C")]
	public void PlaySlashSFX(float volume)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x8B1F10", Offset = "0x8B1F10", VA = "0x8B1F10")]
	public void OnHit(Game.EEventType ev_type)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x8B1C28", Offset = "0x8B1C28", VA = "0x8B1C28")]
	private void UpdateAffector()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8B205C", Offset = "0x8B205C", VA = "0x8B205C")]
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
	[Address(RVA = "0x8D23B0", Offset = "0x8D23B0", VA = "0x8D23B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x8D23C0", Offset = "0x8D23C0", VA = "0x8D23C0")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x8D23C4", Offset = "0x8D23C4", VA = "0x8D23C4")]
	private void Compress(ref Vector3[] verts, ref Vector3[] normals, ref Vector2[] uv, ref int[] tris)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8D2688", Offset = "0x8D2688", VA = "0x8D2688")]
	private int GetNearestVertIDX(ref Vector3[] verts)
	{
		return default(int);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8D27A8", Offset = "0x8D27A8", VA = "0x8D27A8")]
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
	[Address(RVA = "0x8D27B8", Offset = "0x8D27B8", VA = "0x8D27B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x8D2968", Offset = "0x8D2968", VA = "0x8D2968")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x8D30A8", Offset = "0x8D30A8", VA = "0x8D30A8")]
	private void GeneratePiramide(ref Vector3[] vertices, Vector3 pos, int idx, float size)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x8D3488", Offset = "0x8D3488", VA = "0x8D3488")]
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
	[Address(RVA = "0x8D3498", Offset = "0x8D3498", VA = "0x8D3498")]
	private void Start()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x8D375C", Offset = "0x8D375C", VA = "0x8D375C")]
	public void OnSet(Vector3 pos, Vector3 dir_)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x8D3BF0", Offset = "0x8D3BF0", VA = "0x8D3BF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x8D3D38", Offset = "0x8D3D38", VA = "0x8D3D38")]
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
	[Address(RVA = "0x8D3DA4", Offset = "0x8D3DA4", VA = "0x8D3DA4")]
	public void Show()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8D3DE0", Offset = "0x8D3DE0", VA = "0x8D3DE0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8D3E04", Offset = "0x8D3E04", VA = "0x8D3E04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x8D4098", Offset = "0x8D4098", VA = "0x8D4098")]
	private void UpdateHitMat()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x8D41E0", Offset = "0x8D41E0", VA = "0x8D41E0")]
	public void SetLHandSpeed(float speed)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x8D41F0", Offset = "0x8D41F0", VA = "0x8D41F0")]
	public void SetRHandSpeed(float speed)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8D4200", Offset = "0x8D4200", VA = "0x8D4200")]
	private void UpdatePos()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x8D439C", Offset = "0x8D439C", VA = "0x8D439C")]
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
	[Address(RVA = "0x8D43AC", Offset = "0x8D43AC", VA = "0x8D43AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x8D4988", Offset = "0x8D4988", VA = "0x8D4988")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x8D4494", Offset = "0x8D4494", VA = "0x8D4494")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x8D4C04", Offset = "0x8D4C04", VA = "0x8D4C04")]
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
	[Address(RVA = "0x8D4C20", Offset = "0x8D4C20", VA = "0x8D4C20")]
	public void Show()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x8D4C7C", Offset = "0x8D4C7C", VA = "0x8D4C7C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x8D4DA0", Offset = "0x8D4DA0", VA = "0x8D4DA0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x8D4DD4", Offset = "0x8D4DD4", VA = "0x8D4DD4")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x8D4E00", Offset = "0x8D4E00", VA = "0x8D4E00")]
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
	[Address(RVA = "0x8D4E10", Offset = "0x8D4E10", VA = "0x8D4E10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8D4EE0", Offset = "0x8D4EE0", VA = "0x8D4EE0")]
	private void UpdateRotators()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x8D5094", Offset = "0x8D5094", VA = "0x8D5094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x8D5AC8", Offset = "0x8D5AC8", VA = "0x8D5AC8")]
	private void ShowHideLevels(bool to_up)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x8D5B78", Offset = "0x8D5B78", VA = "0x8D5B78")]
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
	[Address(RVA = "0x8D5B94", Offset = "0x8D5B94", VA = "0x8D5B94")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x8D5EB8", Offset = "0x8D5EB8", VA = "0x8D5EB8")]
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
	[Address(RVA = "0x8D5EC0", Offset = "0x8D5EC0", VA = "0x8D5EC0")]
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
		[Token(Token = "0x4000300")]
		WarmUp,
		[Token(Token = "0x4000301")]
		Workout,
		[Token(Token = "0x4000302")]
		Intense,
		[Token(Token = "0x4000303")]
		Rocky,
		[Token(Token = "0x4000304")]
		Program,
		[Token(Token = "0x4000305")]
		MP3Old,
		[Token(Token = "0x4000306")]
		MP3_X,
		[Token(Token = "0x4000307")]
		Jabs,
		[Token(Token = "0x4000308")]
		Options,
		[Token(Token = "0x4000309")]
		Cannonade,
		[Token(Token = "0x400030A")]
		MP3_A,
		[Token(Token = "0x400030B")]
		MP3_B,
		[Token(Token = "0x400030C")]
		MP3_C,
		[Token(Token = "0x400030D")]
		WarmUp_DOff,
		[Token(Token = "0x400030E")]
		Workout_DOff,
		[Token(Token = "0x400030F")]
		Intense_DOff,
		[Token(Token = "0x4000310")]
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

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	public string xFighterAppID;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x8D5FA8", Offset = "0x8D5FA8", VA = "0x8D5FA8")]
	public static bool IsMP3(EGameMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8D5FD8", Offset = "0x8D5FD8", VA = "0x8D5FD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x8DC120", Offset = "0x8DC120", VA = "0x8DC120")]
	private void HeightsSetup()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x8D7A38", Offset = "0x8D7A38", VA = "0x8D7A38")]
	private void FirstInit()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x8DC354", Offset = "0x8DC354", VA = "0x8DC354")]
	private void SelectDefaultLanguage()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x8DC578", Offset = "0x8DC578", VA = "0x8DC578")]
	public void OnClickRandom()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x8DBFB4", Offset = "0x8DBFB4", VA = "0x8DBFB4")]
	public void OnGlobalSynchro(int delay)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x8DC7CC", Offset = "0x8DC7CC", VA = "0x8DC7CC")]
	public void OnColorScheme(int i)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x8DC874", Offset = "0x8DC874", VA = "0x8DC874")]
	public void OnDimColorScheme()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x8DC920", Offset = "0x8DC920", VA = "0x8DC920")]
	public void OnHitDirArrow()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x8DC9CC", Offset = "0x8DC9CC", VA = "0x8DC9CC")]
	public void OnDronesInComplex()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x8DAFC4", Offset = "0x8DAFC4", VA = "0x8DAFC4")]
	public void RefreshColorShemes()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x8DCA90", Offset = "0x8DCA90", VA = "0x8DCA90")]
	public void RandColorScheme()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x8DCBB4", Offset = "0x8DCBB4", VA = "0x8DCBB4")]
	public void OnPlay(int preset_idx)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x8DCE04", Offset = "0x8DCE04", VA = "0x8DCE04")]
	private void StartProgram()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x8D7934", Offset = "0x8D7934", VA = "0x8D7934")]
	private void StartNextProgramTrack()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x8DD630", Offset = "0x8DD630", VA = "0x8DD630")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x8DD690", Offset = "0x8DD690", VA = "0x8DD690")]
	private void OpenArena()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8DDB2C", Offset = "0x8DDB2C", VA = "0x8DDB2C")]
	public PlaylistItem FindTrack(string track_id, int mode)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x8DBC2C", Offset = "0x8DBC2C", VA = "0x8DBC2C")]
	public int FindTrackIDX(string track_id, int mode)
	{
		return default(int);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x8DD0E0", Offset = "0x8DD0E0", VA = "0x8DD0E0")]
	private bool SelectNextProgramTrack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x8DCED0", Offset = "0x8DCED0", VA = "0x8DCED0")]
	private void SetSelectedClipInfo(int preset)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x8DE250", Offset = "0x8DE250", VA = "0x8DE250")]
	private void OnSelectedClip()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x8D9E58", Offset = "0x8D9E58", VA = "0x8D9E58")]
	public void RefreshProfileStats()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x8DE3AC", Offset = "0x8DE3AC", VA = "0x8DE3AC")]
	public void OnReSetCenter()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8DE3E4", Offset = "0x8DE3E4", VA = "0x8DE3E4")]
	public void OnChangeUnit()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x8DE494", Offset = "0x8DE494", VA = "0x8DE494")]
	public void OnChangeHitSFX()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x8DE61C", Offset = "0x8DE61C", VA = "0x8DE61C")]
	public void OnChangeVibrations()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x8DE6CC", Offset = "0x8DE6CC", VA = "0x8DE6CC")]
	public void OnChangeShortDistanceMode()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x8DE7B8", Offset = "0x8DE7B8", VA = "0x8DE7B8")]
	public void OnChangeSkull()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x8DE868", Offset = "0x8DE868", VA = "0x8DE868")]
	public void OnChangeElevator()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x8DE918", Offset = "0x8DE918", VA = "0x8DE918")]
	public void OnChangeHorizObstacles()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x8DE9C8", Offset = "0x8DE9C8", VA = "0x8DE9C8")]
	public void OnChangeVertObstacles()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x8DEA78", Offset = "0x8DEA78", VA = "0x8DEA78")]
	public void OnChangeTrigger()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8DEB28", Offset = "0x8DEB28", VA = "0x8DEB28")]
	public void OnChangeInvCollors()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x8DEC2C", Offset = "0x8DEC2C", VA = "0x8DEC2C")]
	public void OnChangeSmallRoom()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x8DECDC", Offset = "0x8DECDC", VA = "0x8DECDC")]
	public void OnPunchSFX()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x8DEE28", Offset = "0x8DEE28", VA = "0x8DEE28")]
	public void OnSlashSFX()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8DEF74", Offset = "0x8DEF74", VA = "0x8DEF74")]
	public void OnSelectProfile(int profile_idx)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x8DEFF8", Offset = "0x8DEFF8", VA = "0x8DEFF8")]
	private EGameMode StringToMode(string name)
	{
		return default(EGameMode);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x8DF234", Offset = "0x8DF234", VA = "0x8DF234")]
	private string ModeToString(EGameMode mode)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x8D6514", Offset = "0x8D6514", VA = "0x8D6514")]
	private void ReadNotes()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x8DF3B8", Offset = "0x8DF3B8", VA = "0x8DF3B8")]
	public void SaveProgramsLog()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x8D6DB8", Offset = "0x8D6DB8", VA = "0x8D6DB8")]
	private void ReadPrograms()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x8DF738", Offset = "0x8DF738", VA = "0x8DF738")]
	private void ParseStats(ref PlaylistItem item, string config)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x8DC79C", Offset = "0x8DC79C", VA = "0x8DC79C")]
	public void PlayClick()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x8DFAB0", Offset = "0x8DFAB0", VA = "0x8DFAB0")]
	public void OnTutorial()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x8DFB34", Offset = "0x8DFB34", VA = "0x8DFB34")]
	public void OnHowToUseMP3()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x8DFBB8", Offset = "0x8DFBB8", VA = "0x8DFBB8")]
	private void RefreshProgramStats()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x8D9134", Offset = "0x8D9134", VA = "0x8D9134")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x8DFF84", Offset = "0x8DFF84", VA = "0x8DFF84")]
	public void OnSelectTrack(UITrack track)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x8DB23C", Offset = "0x8DB23C", VA = "0x8DB23C")]
	public void OnSelectList(int idx)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x8DACFC", Offset = "0x8DACFC", VA = "0x8DACFC")]
	private void RefreshLayout()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x8DB54C", Offset = "0x8DB54C", VA = "0x8DB54C")]
	public void OnSelect(int idx, bool on_start = false)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x8D9998", Offset = "0x8D9998", VA = "0x8D9998")]
	private void RefreshTrackList()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x8E04D8", Offset = "0x8E04D8", VA = "0x8E04D8")]
	public void OnDownload()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x8E05AC", Offset = "0x8E05AC", VA = "0x8E05AC")]
	public void OnMusic()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x8E0680", Offset = "0x8E0680", VA = "0x8E0680")]
	public void OnRoot()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x8E074C", Offset = "0x8E074C", VA = "0x8E074C")]
	public void OnExit()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x8E0754", Offset = "0x8E0754", VA = "0x8E0754")]
	public void OnCompose()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x8E0898", Offset = "0x8E0898", VA = "0x8E0898")]
	private void UpdateHeight()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x8E0A98", Offset = "0x8E0A98", VA = "0x8E0A98")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x8DFFA0", Offset = "0x8DFFA0", VA = "0x8DFFA0")]
	private void RefreshPlayButtons(bool force)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x8E12E0", Offset = "0x8E12E0", VA = "0x8E12E0")]
	public void OnSelectMP3PresetIDX(int idx)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x8DDC54", Offset = "0x8DDC54", VA = "0x8DDC54")]
	private void ReadMP3SelNotes(string track_id, int preset_idx)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x8E0FD4", Offset = "0x8E0FD4", VA = "0x8E0FD4")]
	private void UpdateComposeProgress()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x8E0E00", Offset = "0x8E0E00", VA = "0x8E0E00")]
	private void UpdatePulseCompositor()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x8E17B0", Offset = "0x8E17B0", VA = "0x8E17B0")]
	public void OnEditProgram()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x8E18B0", Offset = "0x8E18B0", VA = "0x8E18B0")]
	public void OnCancelProgram()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x8DC590", Offset = "0x8DC590", VA = "0x8DC590")]
	public void OnRefreshEditedProgram()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x8DBAB0", Offset = "0x8DBAB0", VA = "0x8DBAB0")]
	private void ReadEditedProgram()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x8E192C", Offset = "0x8E192C", VA = "0x8E192C")]
	public void OnAddToProgram(int preset_idx)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x8E1C18", Offset = "0x8E1C18", VA = "0x8E1C18")]
	public void OnSelectProgramTrack(ProgramItemUI track)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x8E1C10", Offset = "0x8E1C10", VA = "0x8E1C10")]
	public void OnSelectProgramTrack(int idx)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x8E1C34", Offset = "0x8E1C34", VA = "0x8E1C34")]
	public void OnRemoveProgramTrack()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x8E1CF8", Offset = "0x8E1CF8", VA = "0x8E1CF8")]
	public void OnUpProgramTrack()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x8E1EC4", Offset = "0x8E1EC4", VA = "0x8E1EC4")]
	public void OnDownProgramTrack()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x8E2090", Offset = "0x8E2090", VA = "0x8E2090")]
	private void CalculateProgramStats()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x8E222C", Offset = "0x8E222C", VA = "0x8E222C")]
	public void OnChangeProgramName()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x8E22CC", Offset = "0x8E22CC", VA = "0x8E22CC")]
	public void OnSaveProgram()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x8DBD20", Offset = "0x8DBD20", VA = "0x8DBD20")]
	public void RefreshScenes()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x8E3048", Offset = "0x8E3048", VA = "0x8E3048")]
	public void OnChangeScenes(int idx)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x8E30F8", Offset = "0x8E30F8", VA = "0x8E30F8")]
	public void OnLanguage()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x8E3184", Offset = "0x8E3184", VA = "0x8E3184")]
	public void OnSelectLanguage(int idx)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x8E1138", Offset = "0x8E1138", VA = "0x8E1138")]
	private void RandomSMSText()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x8E3348", Offset = "0x8E3348", VA = "0x8E3348")]
	public void OnSFXPanel()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x8DBEB8", Offset = "0x8DBEB8", VA = "0x8DBEB8")]
	public void OnGameplayPanel()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x8D8420", Offset = "0x8D8420", VA = "0x8D8420")]
	private void OpenDirectory(string path, int channel, int min_index, int max_index)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x8E3440", Offset = "0x8E3440", VA = "0x8E3440")]
	private int FillFiles(string path, int channel, FileInfo[] fileinfo, int no_records)
	{
		return default(int);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x8E3DD8", Offset = "0x8E3DD8", VA = "0x8E3DD8")]
	private int FillGroupFiles(int channel, FileInfo[] fileinfo, int no_records, int min_index, int max_index)
	{
		return default(int);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x8E417C", Offset = "0x8E417C", VA = "0x8E417C")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x8E4220", Offset = "0x8E4220", VA = "0x8E4220")]
	public void OpenOculusStoreDeepLink()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x8E423C", Offset = "0x8E423C", VA = "0x8E423C")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x200003A")]
public class Marker : MonoBehaviour
{
	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Yellow;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_ShiftAlpha;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_Alpha;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Game m_Game;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_Dir;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool m_Wall;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_StartYAngle;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Inactive;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool m_Cut;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool m_Bomb;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool m_Block;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_BombIcon;

	[Token(Token = "0x400031F")]
	public const float RADIUS = 0.4f;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_Sliced;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float m_MusicTime;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_NoTestToFail;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool m_Cannon;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 m_OrginalScale;

	[Token(Token = "0x4000325")]
	private const float REFLEX_MODE_PROGESS = 0.9f;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int m_NoBadColls;

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x8E5378", Offset = "0x8E5378", VA = "0x8E5378")]
	private void UpdatePunch()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x8E6214", Offset = "0x8E6214", VA = "0x8E6214")]
	private void OnPuchHit(Glove glove)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x8E6634", Offset = "0x8E6634", VA = "0x8E6634")]
	public void SetBomb()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x8E6660", Offset = "0x8E6660", VA = "0x8E6660")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x8E6D08", Offset = "0x8E6D08", VA = "0x8E6D08")]
	private void UpdateWallColl()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x8E7CE0", Offset = "0x8E7CE0", VA = "0x8E7CE0")]
	private bool UpdateCutColl(Glove glove, ref bool near)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x8E7410", Offset = "0x8E7410", VA = "0x8E7410")]
	private void UpdateDisc()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x8E7494", Offset = "0x8E7494", VA = "0x8E7494")]
	private void UpdateBlock()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x8E78A0", Offset = "0x8E78A0", VA = "0x8E78A0")]
	private void UpdateTask(float progress)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x8E79F8", Offset = "0x8E79F8", VA = "0x8E79F8")]
	private void UpdateScale()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x8E6984", Offset = "0x8E6984", VA = "0x8E6984")]
	private void UpdatePosition(float progress)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x8E8BB8", Offset = "0x8E8BB8", VA = "0x8E8BB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x8E8B60", Offset = "0x8E8B60", VA = "0x8E8B60")]
	private float GetTiming()
	{
		return default(float);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x8E5718", Offset = "0x8E5718", VA = "0x8E5718")]
	private bool OnPassPunch(Glove glove, float dot, Vector3 speed)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x8E7BE4", Offset = "0x8E7BE4", VA = "0x8E7BE4")]
	private void OnWall()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x8E6438", Offset = "0x8E6438", VA = "0x8E6438")]
	private void OnBomb(bool right)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x8E6600", Offset = "0x8E6600", VA = "0x8E6600")]
	private void OnFail(bool right)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x8E7B10", Offset = "0x8E7B10", VA = "0x8E7B10")]
	private void OnTimeOut(bool right)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x8E61A8", Offset = "0x8E61A8", VA = "0x8E61A8")]
	private void Destroy()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x8E88CC", Offset = "0x8E88CC", VA = "0x8E88CC")]
	private void PlayFX(string name, Vector3 pos, Quaternion rot, float scale = 1f)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x8E8EC4", Offset = "0x8E8EC4", VA = "0x8E8EC4")]
	public Marker()
	{
	}
}
[Token(Token = "0x200003B")]
public class NoteInfo : MonoBehaviour
{
	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Tact;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Note;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_FPS;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Game m_Game;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float FPS;

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x8E8F2C", Offset = "0x8E8F2C", VA = "0x8E8F2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x8E8FA4", Offset = "0x8E8FA4", VA = "0x8E8FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x8E90A8", Offset = "0x8E90A8", VA = "0x8E90A8")]
	public NoteInfo()
	{
	}
}
[Token(Token = "0x200003C")]
public class ProfileInfo : MonoBehaviour
{
	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_AutoText;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_HeightText;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_MassText;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_TodayCal;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_WeekCal;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text m_MonthCal;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text m_ProfileName;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int m_ProfileIDX;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MainMenu m_Menu;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sprite m_NormalSprite;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sprite m_SelSprite;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool m_KeyboardActive;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x8E90B8", Offset = "0x8E90B8", VA = "0x8E90B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x8E97E4", Offset = "0x8E97E4", VA = "0x8E97E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x8E9138", Offset = "0x8E9138", VA = "0x8E9138")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x8E9A60", Offset = "0x8E9A60", VA = "0x8E9A60")]
	public void OnIncraseWeight()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x8E9BEC", Offset = "0x8E9BEC", VA = "0x8E9BEC")]
	public void OnDecraseWeight()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x8E9D78", Offset = "0x8E9D78", VA = "0x8E9D78")]
	public void OnIncraseHeight()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x8E9F14", Offset = "0x8E9F14", VA = "0x8E9F14")]
	public void OnDecraseHeight()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x8EA0B4", Offset = "0x8EA0B4", VA = "0x8EA0B4")]
	public void OnAutoManual()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x8EA204", Offset = "0x8EA204", VA = "0x8EA204")]
	public void OnChangeName()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x8EA2D4", Offset = "0x8EA2D4", VA = "0x8EA2D4")]
	public void OnSelectProfil()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x8EA308", Offset = "0x8EA308", VA = "0x8EA308")]
	public ProfileInfo()
	{
	}
}
[Token(Token = "0x200003D")]
public class ProgramItemUI : MonoBehaviour
{
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_TrackName;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image m_Icon;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Index;

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x8EA310", Offset = "0x8EA310", VA = "0x8EA310")]
	public ProgramItemUI()
	{
	}
}
[Token(Token = "0x200003E")]
public class ProgramListUI : MonoBehaviour
{
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] m_Icons;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color[] m_Colors;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProgramItemUI m_SampleItem;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProgramItemUI[] m_Items;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ScrollRect m_FolderScroll;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite m_SpriteCheckOn;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite m_SpriteCheckOff;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image m_RandomImages;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_Wait;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_SetupScroll;

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x8EA318", Offset = "0x8EA318", VA = "0x8EA318")]
	private void Update()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x8EA360", Offset = "0x8EA360", VA = "0x8EA360")]
	public void RefreshProgramList(PlaylistItem program, MainMenu menu, int edited_program_item_idx = -1)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x8EA8F8", Offset = "0x8EA8F8", VA = "0x8EA8F8")]
	public ProgramListUI()
	{
	}
}
[Token(Token = "0x200003F")]
public class GameLeaderboard : MonoBehaviour
{
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LBResult m_SampleResult;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LBResult[] m_Results;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform m_ScrolTransform;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite m_SelSprite;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite m_Sprite;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button m_FriendsButton;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button m_OverallButton;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SortedDictionary<int, LeaderboardEntry> m_HighScores;

	[Token(Token = "0x400034D")]
	private const int NO_REULTS = 10;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string m_LB_ID;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_FriendsMode;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int request_delay;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int first_request_delay;

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x8EA908", Offset = "0x8EA908", VA = "0x8EA908")]
	public void OnFriends()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x8EAB04", Offset = "0x8EAB04", VA = "0x8EAB04")]
	public void OnOverall()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x8EAB0C", Offset = "0x8EAB0C", VA = "0x8EAB0C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x8EAD38", Offset = "0x8EAD38", VA = "0x8EAD38")]
	private void Update()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x8EAB10", Offset = "0x8EAB10", VA = "0x8EAB10")]
	private void FillEmpty()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x8EAF54", Offset = "0x8EAF54", VA = "0x8EAF54")]
	private void GetFriends(Message _msg)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x8EB31C", Offset = "0x8EB31C", VA = "0x8EB31C")]
	public void OnHighLeaderboardUpdated()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x8EB620", Offset = "0x8EB620", VA = "0x8EB620")]
	public void OnNearLeaderboardUpdated()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x8EAD84", Offset = "0x8EAD84", VA = "0x8EAD84")]
	private void QueryHighScoreLeaderboard()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x8EB978", Offset = "0x8EB978", VA = "0x8EB978")]
	private void MostScoreGetEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x8EBCFC", Offset = "0x8EBCFC", VA = "0x8EBCFC")]
	private void AroundGetEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x8EA914", Offset = "0x8EA914", VA = "0x8EA914")]
	public void RefreshScore()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x8EBFE4", Offset = "0x8EBFE4", VA = "0x8EBFE4")]
	public void UpdateScoreInternal()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x8EC1B4", Offset = "0x8EC1B4", VA = "0x8EC1B4")]
	public GameLeaderboard()
	{
	}
}
[Token(Token = "0x2000040")]
public class LBResult : MonoBehaviour
{
	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_LP;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_UserName;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_Score;

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x8EC218", Offset = "0x8EC218", VA = "0x8EC218")]
	public LBResult()
	{
	}
}
[Token(Token = "0x2000041")]
public class RecenterUI : MonoBehaviour
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR m_VR;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_Time;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material m_CircleMat;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_SetupIcon;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_UseIcon;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool m_SetupMode;

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x8EC220", Offset = "0x8EC220", VA = "0x8EC220")]
	private void Start()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x8EC298", Offset = "0x8EC298", VA = "0x8EC298")]
	private void Update()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x8EC8C8", Offset = "0x8EC8C8", VA = "0x8EC8C8")]
	public RecenterUI()
	{
	}
}
[Token(Token = "0x2000042")]
public class ReflectionCamera : MonoBehaviour
{
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR m_VR;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera m_Cam;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material m_ArenaMat;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_ArenaMat2;

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x8EC8D0", Offset = "0x8EC8D0", VA = "0x8EC8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x8EC978", Offset = "0x8EC978", VA = "0x8EC978")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x8ECCA0", Offset = "0x8ECCA0", VA = "0x8ECCA0")]
	public ReflectionCamera()
	{
	}
}
[Token(Token = "0x2000043")]
public class RingEffect : MonoBehaviour
{
	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_NoBands;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] m_SpecVis;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x8ECCA8", Offset = "0x8ECCA8", VA = "0x8ECCA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x8ECD90", Offset = "0x8ECD90", VA = "0x8ECD90")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x8ED290", Offset = "0x8ED290", VA = "0x8ED290")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x8ED738", Offset = "0x8ED738", VA = "0x8ED738")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x8ED7D8", Offset = "0x8ED7D8", VA = "0x8ED7D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x8EDAE0", Offset = "0x8EDAE0", VA = "0x8EDAE0")]
	public RingEffect()
	{
	}
}
[Token(Token = "0x2000044")]
public class RythmAnalizer : MonoBehaviour
{
	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource m_AudioSource;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_Box;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] m_Spectrum;

	[Token(Token = "0x4000367")]
	private const int NO_BANDS = 6;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] m_Averages;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_Vis;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject[] m_Beats;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool[] m_Beat;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int[] m_NoUp;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int[] m_NoDown;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] m_TopChange;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] m_TopTime;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float[] m_LastBeatTime;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject[] m_Line;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float m_Change;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float m_ChangeDown;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float m_BeatLevel;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float[] m_Markers;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float m_PrevBeatTime;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int m_BPM;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float[] m_Probality;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int m_PrevBeatIDX;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int TESTED_CHANNEL;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Game m_Game;

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x8EDB4C", Offset = "0x8EDB4C", VA = "0x8EDB4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x8EE07C", Offset = "0x8EE07C", VA = "0x8EE07C")]
	public void OnBeat(float time)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x8EE350", Offset = "0x8EE350", VA = "0x8EE350")]
	private void Visualize(int idx, float power)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x8EDD20", Offset = "0x8EDD20", VA = "0x8EDD20")]
	private float MarkBeats()
	{
		return default(float);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x8EE480", Offset = "0x8EE480", VA = "0x8EE480")]
	private void MarkBeat(float time, float value)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x8EE40C", Offset = "0x8EE40C", VA = "0x8EE40C")]
	private int FindBPM()
	{
		return default(int);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x8EE354", Offset = "0x8EE354", VA = "0x8EE354")]
	private void FillBeatsProb(int bpm, float val)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x8EE56C", Offset = "0x8EE56C", VA = "0x8EE56C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x8EE624", Offset = "0x8EE624", VA = "0x8EE624")]
	public RythmAnalizer()
	{
	}
}
[Token(Token = "0x2000045")]
public class SabreTrail : MonoBehaviour
{
	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 m_APos;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 m_BPos;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] m_Verts;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Mesh mesh;

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x8EE850", Offset = "0x8EE850", VA = "0x8EE850")]
	private void Start()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x8EEBA8", Offset = "0x8EEBA8", VA = "0x8EEBA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x8EECE0", Offset = "0x8EECE0", VA = "0x8EECE0")]
	public SabreTrail()
	{
	}
}
[Token(Token = "0x2000046")]
public class Shield : MonoBehaviour
{
	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_Width;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int m_Height;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshFilter m_FrameMesh;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommonVR m_VR;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool m_Yellow;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool m_WasTrigger;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_BlueFrameMat;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material m_YellowFrameMat;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material m_BlueMat;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material m_YellowMat;

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x8EECE8", Offset = "0x8EECE8", VA = "0x8EECE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x8EF9A8", Offset = "0x8EF9A8", VA = "0x8EF9A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x8EFAB4", Offset = "0x8EFAB4", VA = "0x8EFAB4")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x8EEE04", Offset = "0x8EEE04", VA = "0x8EEE04")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x8EF3C4", Offset = "0x8EF3C4", VA = "0x8EF3C4")]
	private void GenerateFrame()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x8EFE78", Offset = "0x8EFE78", VA = "0x8EFE78")]
	private static void Sculptor(int no_tris, Vector3[] vertices)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x8F009C", Offset = "0x8F009C", VA = "0x8F009C")]
	private void GenerateFrame(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x8F0244", Offset = "0x8F0244", VA = "0x8F0244")]
	private static int MakeFrameSeg(Vector3[] vertices, int idx, Vector3 beg, Vector3 end)
	{
		return default(int);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x8EFBCC", Offset = "0x8EFBCC", VA = "0x8EFBCC")]
	private void GenerateNet(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x8F07E8", Offset = "0x8F07E8", VA = "0x8F07E8")]
	public Shield()
	{
	}
}
[Token(Token = "0x2000047")]
public class ShieldMaker : MonoBehaviour
{
	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshFilter;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x8F07F8", Offset = "0x8F07F8", VA = "0x8F07F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x8F0E38", Offset = "0x8F0E38", VA = "0x8F0E38")]
	public ShieldMaker()
	{
	}
}
[Token(Token = "0x2000048")]
public class Slicer : MonoBehaviour
{
	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_SlicePos;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion m_SliceRot;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 m_SliceUp;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_SliceForward;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_Top;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_Bottom;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject m_Core;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float m_Time;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool m_BadDir;

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x8F0E40", Offset = "0x8F0E40", VA = "0x8F0E40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x8E849C", Offset = "0x8E849C", VA = "0x8E849C")]
	public void SetBladeTransform(Transform cut_transform, Vector3 curr_speed, bool bad_dir)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x8F0F64", Offset = "0x8F0F64", VA = "0x8F0F64")]
	private void Slice(GameObject vis, bool top)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x8F12F8", Offset = "0x8F12F8", VA = "0x8F12F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x8F175C", Offset = "0x8F175C", VA = "0x8F175C")]
	public Slicer()
	{
	}
}
[Token(Token = "0x2000049")]
public class SongInfo : MonoBehaviour
{
	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Length;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_TitleName;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_ProgramInfo;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_NoSecToEnd;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Game m_Game;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x8F1764", Offset = "0x8F1764", VA = "0x8F1764")]
	private void Start()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x8F18DC", Offset = "0x8F18DC", VA = "0x8F18DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x8F1A30", Offset = "0x8F1A30", VA = "0x8F1A30")]
	public SongInfo()
	{
	}
}
[Token(Token = "0x200004A")]
public class SphereMaker : MonoBehaviour
{
	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshFilter;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x8F1A38", Offset = "0x8F1A38", VA = "0x8F1A38")]
	private void Start()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x8F2078", Offset = "0x8F2078", VA = "0x8F2078")]
	public SphereMaker()
	{
	}
}
[Token(Token = "0x200004B")]
public class Statistic : MonoBehaviour
{
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_HighScore;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Score;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_Combo;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_Hits;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_Misses;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text m_Energy;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text m_HitSpeedL;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text m_HitSpeedR;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text m_AvgSpeedL;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text m_AvgSpeedR;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text m_HitAccuL;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text m_HitAccuR;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text m_HitTimL;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text m_HitTimR;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text m_SlashAccuL;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text m_SlashAccuR;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text m_SlashTimL;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text m_SlashTimR;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text m_ShotSmashL;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text m_ShotSmashR;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text m_SuccDodging;

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x8F2080", Offset = "0x8F2080", VA = "0x8F2080")]
	private void Start()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x8F2084", Offset = "0x8F2084", VA = "0x8F2084")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x8F2C40", Offset = "0x8F2C40", VA = "0x8F2C40")]
	public Statistic()
	{
	}
}
[Token(Token = "0x200004C")]
public class Track : MonoBehaviour
{
	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string m_ID;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string m_Title;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_Artist;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_StartShift;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] m_Sequences;

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x8F2C48", Offset = "0x8F2C48", VA = "0x8F2C48")]
	public Track()
	{
	}
}
[Token(Token = "0x200004D")]
public class TranslatorTool : MonoBehaviour
{
	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] m_Text;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] m_ID;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextAsset m_EnTranslateFile;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAsset m_CnTranslateFile;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset m_JpTranslateFile;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset m_KrTranslateFile;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset m_FrTranslateFile;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset m_CzTranslateFile;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextAsset m_DeTranslateFile;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextAsset m_SpTranslateFile;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextAsset m_PtTranslateFile;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAsset m_ThTranslateFile;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextAsset m_PlTranslateFile;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<string>> m_Translate;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x8F2C50", Offset = "0x8F2C50", VA = "0x8F2C50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x8F3480", Offset = "0x8F3480", VA = "0x8F3480")]
	private void Start()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x8F3124", Offset = "0x8F3124", VA = "0x8F3124")]
	private void ReadTransalte(TextAsset translate_file)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x8F3484", Offset = "0x8F3484", VA = "0x8F3484")]
	public void SetupLanguage()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x8F3500", Offset = "0x8F3500", VA = "0x8F3500")]
	private void SetupLanguage(int lang_idx)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x8F365C", Offset = "0x8F365C", VA = "0x8F365C")]
	public string Translate(string text)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x8F37F8", Offset = "0x8F37F8", VA = "0x8F37F8")]
	public TranslatorTool()
	{
	}
}
[Token(Token = "0x200004E")]
public class Turret : MonoBehaviour
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_Alive;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game m_Game;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_ToShootProgress;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private EnemyBullet[] m_Bullets;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 m_TargetSpeed;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] m_LasersDeviations;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform[] m_LaserTags;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform[] m_LaserFlats;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject m_Target;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_Seed;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float m_BulletsSpeed;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_Slomo;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int m_SourceID;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool m_Pistol;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool m_AimSoundPlayed;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool m_ShootSoundPlayed;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject m_HeadLaserSpot;

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x8F3880", Offset = "0x8F3880", VA = "0x8F3880")]
	public bool IsReadyToShoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x8F3894", Offset = "0x8F3894", VA = "0x8F3894")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x8F39B4", Offset = "0x8F39B4", VA = "0x8F39B4")]
	public void OnKill()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x8F3A7C", Offset = "0x8F3A7C", VA = "0x8F3A7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x8F3B24", Offset = "0x8F3B24", VA = "0x8F3B24")]
	private void Start()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x8F3C28", Offset = "0x8F3C28", VA = "0x8F3C28")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x8F3CC8", Offset = "0x8F3CC8", VA = "0x8F3CC8")]
	private void UpdateBullets()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x8F4148", Offset = "0x8F4148", VA = "0x8F4148")]
	private void UpdateAming()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x8F43C4", Offset = "0x8F43C4", VA = "0x8F43C4")]
	private void UpdateTurret()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x8F55E8", Offset = "0x8F55E8", VA = "0x8F55E8")]
	public void InitShooting(GameObject target, int seed)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x8F491C", Offset = "0x8F491C", VA = "0x8F491C")]
	private void UpdateLaserTags()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x8F4324", Offset = "0x8F4324", VA = "0x8F4324")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x8F5C28", Offset = "0x8F5C28", VA = "0x8F5C28")]
	public Turret()
	{
	}
}
[Token(Token = "0x200004F")]
public class Tutorial : MonoBehaviour
{
	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_AnimProgress;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rec_transform;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x8F5CB8", Offset = "0x8F5CB8", VA = "0x8F5CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x8F5D10", Offset = "0x8F5D10", VA = "0x8F5D10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x8F5D18", Offset = "0x8F5D18", VA = "0x8F5D18")]
	private void Update()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x8F5E24", Offset = "0x8F5E24", VA = "0x8F5E24")]
	public Tutorial()
	{
	}
}
[Token(Token = "0x2000050")]
public class UITrack : MonoBehaviour
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text track_name;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string track_id;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject main_ui;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int idx;

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x8F5E2C", Offset = "0x8F5E2C", VA = "0x8F5E2C")]
	public UITrack()
	{
	}
}
[Token(Token = "0x2000051")]
public class URLPlayer : MonoBehaviour
{
	[Token(Token = "0x2000052")]
	private sealed class <GrabWWWTexture>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public URLPlayer <>4__this;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x8F61DC", Offset = "0x8F61DC", VA = "0x8F61DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x8F6224", Offset = "0x8F6224", VA = "0x8F6224", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8F5EC8", Offset = "0x8F5EC8", VA = "0x8F5EC8")]
		[DebuggerHidden]
		public <GrabWWWTexture>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x8F5F48", Offset = "0x8F5F48", VA = "0x8F5F48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x8F5F4C", Offset = "0x8F5F4C", VA = "0x8F5F4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x8F61E4", Offset = "0x8F61E4", VA = "0x8F61E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string url;

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x8F5E34", Offset = "0x8F5E34", VA = "0x8F5E34")]
	private void Start()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x8F5E54", Offset = "0x8F5E54", VA = "0x8F5E54")]
	private IEnumerator GrabWWWTexture()
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x8F5EF0", Offset = "0x8F5EF0", VA = "0x8F5EF0")]
	public URLPlayer()
	{
	}
}
[Token(Token = "0x2000053")]
public class VideoBeats : MonoBehaviour
{
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer m_VideoPlayer;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_PrevHit;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_Speed;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_TargetSpeed;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_FreeTime;

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x8F622C", Offset = "0x8F622C", VA = "0x8F622C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x8F62D4", Offset = "0x8F62D4", VA = "0x8F62D4")]
	public VideoBeats()
	{
	}
}
[Token(Token = "0x2000054")]
public class WindEffect : MonoBehaviour
{
	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_Width;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_Height;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material m_SphereMat;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Game m_Game;

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x8F62EC", Offset = "0x8F62EC", VA = "0x8F62EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x8F70F0", Offset = "0x8F70F0", VA = "0x8F70F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x8F63D4", Offset = "0x8F63D4", VA = "0x8F63D4")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x8F7384", Offset = "0x8F7384", VA = "0x8F7384")]
	public WindEffect()
	{
	}
}
[Token(Token = "0x2000055")]
public class CommonVR : MonoBehaviour
{
	[Token(Token = "0x2000056")]
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

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CommonVR Instance;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_PicoVR;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Pointer m_LeftPointer;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Pointer m_RightPointer;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Pointer m_ForwardPointer;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera m_Camera;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_VibrationsOff;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool m_Blackout;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject m_BlackoutQuad;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MainMenu m_MainMenu;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_MenuWasPressed;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool m_MenuPressedNow;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_BlackoutScale;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_EntitlementCheck;

	[Token(Token = "0x1700001E")]
	public bool UpPressed
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8F89B4", Offset = "0x8F89B4", VA = "0x8F89B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public bool DownPressed
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8F8AFC", Offset = "0x8F8AFC", VA = "0x8F8AFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x8F7398", Offset = "0x8F7398", VA = "0x8F7398")]
	public void RestoreHandsAnimators()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x8F73B0", Offset = "0x8F73B0", VA = "0x8F73B0")]
	public void RestoreLHandAnimator()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x8F7598", Offset = "0x8F7598", VA = "0x8F7598")]
	public void RestoreRHandAnimator()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x8F7780", Offset = "0x8F7780", VA = "0x8F7780")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x8F7A04", Offset = "0x8F7A04", VA = "0x8F7A04")]
	private void EntitlementCheck()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x8F7900", Offset = "0x8F7900", VA = "0x8F7900")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x8F7AE8", Offset = "0x8F7AE8", VA = "0x8F7AE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x8F7C4C", Offset = "0x8F7C4C", VA = "0x8F7C4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x8F81F8", Offset = "0x8F81F8", VA = "0x8F81F8")]
	public bool IsMenuPressedNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x8F7D5C", Offset = "0x8F7D5C", VA = "0x8F7D5C")]
	public bool IsMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x8F8200", Offset = "0x8F8200", VA = "0x8F8200")]
	public bool IsAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x8F8208", Offset = "0x8F8208", VA = "0x8F8208")]
	public bool IsSteam()
	{
		return default(bool);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x8F8210", Offset = "0x8F8210", VA = "0x8F8210")]
	public void ForceFeedback(bool right_hand, FFType type)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x8F8190", Offset = "0x8F8190", VA = "0x8F8190")]
	public bool IsTriggerPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x8F82B0", Offset = "0x8F82B0", VA = "0x8F82B0")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x8F843C", Offset = "0x8F843C", VA = "0x8F843C")]
	public Vector3 GetLHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x8F851C", Offset = "0x8F851C", VA = "0x8F851C")]
	public Vector3 GetRHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x8F85FC", Offset = "0x8F85FC", VA = "0x8F85FC")]
	public Vector3 GetLHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x8F86DC", Offset = "0x8F86DC", VA = "0x8F86DC")]
	public Vector3 GetRHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x8F7DF4", Offset = "0x8F7DF4", VA = "0x8F7DF4")]
	public Vector3 GetPointerPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x8F87BC", Offset = "0x8F87BC", VA = "0x8F87BC")]
	public Vector3 GetPointerRot()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x8F7FC0", Offset = "0x8F7FC0", VA = "0x8F7FC0")]
	public Vector3 GetPointerDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x8F895C", Offset = "0x8F895C", VA = "0x8F895C")]
	public Vector3 GetHeadPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x8F8984", Offset = "0x8F8984", VA = "0x8F8984")]
	public Vector3 GetHeadDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x8F89AC", Offset = "0x8F89AC", VA = "0x8F89AC")]
	public bool IsHQVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x8F8C44", Offset = "0x8F8C44", VA = "0x8F8C44")]
	public CommonVR()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x8F8C54", Offset = "0x8F8C54", VA = "0x8F8C54")]
	private void <EntitlementCheck>b__19_0(Message msg)
	{
	}
}
[Token(Token = "0x2000057")]
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

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x8F83A0", Offset = "0x8F83A0", VA = "0x8F83A0")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x8F8CFC", Offset = "0x8F8CFC", VA = "0x8F8CFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x8F8DB8", Offset = "0x8F8DB8", VA = "0x8F8DB8")]
	public Pointer()
	{
	}
}
[Token(Token = "0x2000058")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x8F8DC0", Offset = "0x8F8DC0", VA = "0x8F8DC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x8F8FDC", Offset = "0x8F8FDC", VA = "0x8F8FDC")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x2000059")]
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

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x8F8FE4", Offset = "0x8F8FE4", VA = "0x8F8FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x8F90C0", Offset = "0x8F90C0", VA = "0x8F90C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x8F91E0", Offset = "0x8F91E0", VA = "0x8F91E0")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x200005A")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x8F91F0", Offset = "0x8F91F0", VA = "0x8F91F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x8F93D4", Offset = "0x8F93D4", VA = "0x8F93D4")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x200005B")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x8F93DC", Offset = "0x8F93DC", VA = "0x8F93DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x8F94AC", Offset = "0x8F94AC", VA = "0x8F94AC")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x200005C")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x8F94B4", Offset = "0x8F94B4", VA = "0x8F94B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x8F9534", Offset = "0x8F9534", VA = "0x8F9534")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x8F95E8", Offset = "0x8F95E8", VA = "0x8F95E8")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x200005D")]
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	[Token(Token = "0x200005E")]
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

	[Token(Token = "0x200005F")]
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
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x8FB6F0", Offset = "0x8FB6F0", VA = "0x8FB6F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8FB7E4", Offset = "0x8FB7E4", VA = "0x8FB7E4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public static bool CanInstanceBeAccessed
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8FB844", Offset = "0x8FB844", VA = "0x8FB844")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8F981C", Offset = "0x8F981C", VA = "0x8F981C")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8FB8CC", Offset = "0x8FB8CC", VA = "0x8FB8CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public LayerMask RaycastLayerMask
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8FB950", Offset = "0x8FB950", VA = "0x8FB950")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8FB958", Offset = "0x8FB958", VA = "0x8FB958")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Hand UsedHand
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8FB960", Offset = "0x8FB960", VA = "0x8FB960")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x8FB968", Offset = "0x8FB968", VA = "0x8FB968")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8FB428", Offset = "0x8FB428", VA = "0x8FB428")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8FB9D4", Offset = "0x8FB9D4", VA = "0x8FB9D4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000027")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8FB9F0", Offset = "0x8FB9F0", VA = "0x8FB9F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000028")]
	public Transform PointerTransformOverride
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8FB970", Offset = "0x8FB970", VA = "0x8FB970")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8FBA0C", Offset = "0x8FBA0C", VA = "0x8FBA0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8FBA78", Offset = "0x8FBA78", VA = "0x8FBA78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public Camera EventCamera
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8FBA80", Offset = "0x8FBA80", VA = "0x8FBA80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8F976C", Offset = "0x8F976C", VA = "0x8F976C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public static Vector2 MousePosition
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8FBCC4", Offset = "0x8FBCC4", VA = "0x8FBCC4")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool LeftMouseButton
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8FBDAC", Offset = "0x8FBDAC", VA = "0x8FBDAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8FBD40", Offset = "0x8FBD40", VA = "0x8FBD40")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8F810C", Offset = "0x8F810C", VA = "0x8F810C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8FBE00", Offset = "0x8FBE00", VA = "0x8FBE00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x8F8194", Offset = "0x8F8194", VA = "0x8F8194")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	[Obsolete("Use CustomControllerButtonState instead.")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x8FBE5C", Offset = "0x8FBE5C", VA = "0x8FBE5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x8FBEA8", Offset = "0x8FBEA8", VA = "0x8FBEA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8FBEFC", Offset = "0x8FBEFC", VA = "0x8FBEFC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8FBF04", Offset = "0x8FBF04", VA = "0x8FBF04")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x8FBF10", Offset = "0x8FBF10", VA = "0x8FBF10")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000032")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x8FBF24", Offset = "0x8FBF24", VA = "0x8FBF24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8FBF2C", Offset = "0x8FBF2C", VA = "0x8FBF2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8FBF34", Offset = "0x8FBF34", VA = "0x8FBF34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8FBF3C", Offset = "0x8FBF3C", VA = "0x8FBF3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public float GazeClickTimer
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8FBF48", Offset = "0x8FBF48", VA = "0x8FBF48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8FBF50", Offset = "0x8FBF50", VA = "0x8FBF50")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8FBF60", Offset = "0x8FBF60", VA = "0x8FBF60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8FBF68", Offset = "0x8FBF68", VA = "0x8FBF68")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8FBF78", Offset = "0x8FBF78", VA = "0x8FBF78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000037")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8FBF80", Offset = "0x8FBF80", VA = "0x8FBF80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8FBF88", Offset = "0x8FBF88", VA = "0x8FBF88")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public XRBaseController RightXRController
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8FBF90", Offset = "0x8FBF90", VA = "0x8FBF90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8FBF98", Offset = "0x8FBF98", VA = "0x8FBF98")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public XRBaseController LeftXRController
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8FBFA8", Offset = "0x8FBFA8", VA = "0x8FBFA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8FBFB0", Offset = "0x8FBFB0", VA = "0x8FBFB0")]
		set
		{
		}
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x8F95F0", Offset = "0x8F95F0", VA = "0x8F95F0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x8F9A28", Offset = "0x8F9A28", VA = "0x8F9A28", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x8F9A54", Offset = "0x8F9A54", VA = "0x8F9A54", Slot = "27")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x8F9878", Offset = "0x8F9878", VA = "0x8F9878")]
	private void SetupUnityXrControllers()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x8F9C50", Offset = "0x8F9C50", VA = "0x8F9C50", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x8F9DD8", Offset = "0x8F9DD8", VA = "0x8F9DD8")]
	protected PointerInputModule.MouseButtonEventData GetEventData()
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x8FA03C", Offset = "0x8FA03C", VA = "0x8FA03C")]
	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x8FA654", Offset = "0x8FA654", VA = "0x8FA654")]
	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x8FACF4", Offset = "0x8FACF4", VA = "0x8FACF4")]
	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x8FAF98", Offset = "0x8FAF98", VA = "0x8FAF98")]
	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x8FB114", Offset = "0x8FB114", VA = "0x8FB114")]
	private void ProcessUnityXrController()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x8FB4C8", Offset = "0x8FB4C8", VA = "0x8FB4C8", Slot = "28")]
	protected virtual void ProcessMouseController()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x8FB608", Offset = "0x8FB608", VA = "0x8FB608", Slot = "29")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x8FB60C", Offset = "0x8FB60C", VA = "0x8FB60C", Slot = "30")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x8FB274", Offset = "0x8FB274", VA = "0x8FB274")]
	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x8FB248", Offset = "0x8FB248", VA = "0x8FB248")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x60002A7")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x8FBA88", Offset = "0x8FBA88", VA = "0x8FBA88")]
	public Ray GetEventRay([Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x8FBFC0", Offset = "0x8FBFC0", VA = "0x8FBFC0")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x2000060")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x8FC0FC", Offset = "0x8FC0FC", VA = "0x8FC0FC")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x8FC23C", Offset = "0x8FC23C", VA = "0x8FC23C")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x8FC56C", Offset = "0x8FC56C", VA = "0x8FC56C")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x8FC704", Offset = "0x8FC704", VA = "0x8FC704", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x8FC730", Offset = "0x8FC730", VA = "0x8FC730")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000061")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x8FC798", Offset = "0x8FC798", VA = "0x8FC798")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x8FC814", Offset = "0x8FC814", VA = "0x8FC814")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x8FC984", Offset = "0x8FC984", VA = "0x8FC984")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000062")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700003A")]
	public bool IsVisible
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x8FC98C", Offset = "0x8FC98C", VA = "0x8FC98C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8FC994", Offset = "0x8FC994", VA = "0x8FC994")]
		set
		{
		}
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x8FCAB8", Offset = "0x8FCAB8", VA = "0x8FCAB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x8FCCA8", Offset = "0x8FCCA8", VA = "0x8FCCA8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x8FCCB0", Offset = "0x8FCCB0", VA = "0x8FCCB0")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000063")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x8FD8C0", Offset = "0x8FD8C0", VA = "0x8FD8C0")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000065")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMax;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMin;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float LatencyWeight;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int MaxSamples;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x8FD8C8", Offset = "0x8FD8C8", VA = "0x8FD8C8")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8FDABC", Offset = "0x8FDABC", VA = "0x8FDABC")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x8FCCC4", Offset = "0x8FCCC4", VA = "0x8FCCC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x8FCE1C", Offset = "0x8FCE1C", VA = "0x8FCE1C")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x8FD218", Offset = "0x8FD218", VA = "0x8FD218")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x8FD16C", Offset = "0x8FD16C", VA = "0x8FD16C")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x8FD5AC", Offset = "0x8FD5AC", VA = "0x8FD5AC")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x8FD9FC", Offset = "0x8FD9FC", VA = "0x8FD9FC")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000066")]
public class P2PManager
{
	[Token(Token = "0x2000067")]
	private enum MessageType : byte
	{
		[Token(Token = "0x4000454")]
		Update = 1
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x8FDB5C", Offset = "0x8FDB5C", VA = "0x8FDB5C")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x8FDC28", Offset = "0x8FDC28", VA = "0x8FDC28")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x8FDE68", Offset = "0x8FDE68", VA = "0x8FDE68")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x8FDFB0", Offset = "0x8FDFB0", VA = "0x8FDFB0")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8FE100", Offset = "0x8FE100", VA = "0x8FE100")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x8FE2EC", Offset = "0x8FE2EC", VA = "0x8FE2EC")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x8FE6A4", Offset = "0x8FE6A4", VA = "0x8FE6A4")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x8FE92C", Offset = "0x8FE92C", VA = "0x8FE92C")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x8FE4B0", Offset = "0x8FE4B0", VA = "0x8FE4B0")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x8FE878", Offset = "0x8FE878", VA = "0x8FE878")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x8FE57C", Offset = "0x8FE57C", VA = "0x8FE57C")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x8FEB54", Offset = "0x8FEB54", VA = "0x8FEB54")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x8FE4EC", Offset = "0x8FE4EC", VA = "0x8FE4EC")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x8FE8B0", Offset = "0x8FE8B0", VA = "0x8FE8B0")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x8FE614", Offset = "0x8FE614", VA = "0x8FE614")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x8FEBD0", Offset = "0x8FEBD0", VA = "0x8FEBD0")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000068")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x8FEC4C", Offset = "0x8FEC4C", VA = "0x8FEC4C", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x8FF038", Offset = "0x8FF038", VA = "0x8FF038", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x8FF05C", Offset = "0x8FF05C", VA = "0x8FF05C", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x8FF40C", Offset = "0x8FF40C", VA = "0x8FF40C")]
	private void checkInput()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8FF56C", Offset = "0x8FF56C", VA = "0x8FF56C")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x8FF5E8", Offset = "0x8FF5E8", VA = "0x8FF5E8")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x8FF6D4", Offset = "0x8FF6D4", VA = "0x8FF6D4")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000069")]
public class RemotePlayer
{
	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8FF7B8", Offset = "0x8FF7B8", VA = "0x8FF7B8")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x200006A")]
public class RoomManager
{
	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8FF7C0", Offset = "0x8FF7C0", VA = "0x8FF7C0")]
	public RoomManager()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x8FF8A4", Offset = "0x8FF8A4", VA = "0x8FF8A4")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x8FFAA0", Offset = "0x8FFAA0", VA = "0x8FFAA0")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x8FFBB8", Offset = "0x8FFBB8", VA = "0x8FFBB8")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x8FFC70", Offset = "0x8FFC70", VA = "0x8FFC70")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x8FFACC", Offset = "0x8FFACC", VA = "0x8FFACC")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x90005C", Offset = "0x90005C", VA = "0x90005C")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x9007EC", Offset = "0x9007EC", VA = "0x9007EC")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x900B38", Offset = "0x900B38", VA = "0x900B38")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x90039C", Offset = "0x90039C", VA = "0x90039C")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x200006B")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x200006C")]
	public enum State
	{
		[Token(Token = "0x400048C")]
		INITIALIZING,
		[Token(Token = "0x400048D")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x400048E")]
		CREATING_A_ROOM,
		[Token(Token = "0x400048F")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x4000490")]
		JOINING_A_ROOM,
		[Token(Token = "0x4000491")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x4000492")]
		LEAVING_A_ROOM,
		[Token(Token = "0x4000493")]
		SHUTDOWN
	}

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700003B")]
	public static State CurrentState
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x9028F8", Offset = "0x9028F8", VA = "0x9028F8")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700003C")]
	public static ulong MyID
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8FDCF0", Offset = "0x8FDCF0", VA = "0x8FDCF0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700003D")]
	public static string MyOculusID
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x90295C", Offset = "0x90295C", VA = "0x90295C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x8FF074", Offset = "0x8FF074", VA = "0x8FF074", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x8FEC80", Offset = "0x8FEC80", VA = "0x8FEC80", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x9015E0", Offset = "0x9015E0", VA = "0x9015E0")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x8FF058", Offset = "0x8FF058", VA = "0x8FF058", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x901768", Offset = "0x901768", VA = "0x901768")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x901860", Offset = "0x901860", VA = "0x901860")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x902048", Offset = "0x902048", VA = "0x902048")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x902460", Offset = "0x902460", VA = "0x902460")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x902684", Offset = "0x902684", VA = "0x902684")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x902890", Offset = "0x902890", VA = "0x902890")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x90146C", Offset = "0x90146C", VA = "0x90146C")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x8FF9F4", Offset = "0x8FF9F4", VA = "0x8FF9F4")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x8FFD5C", Offset = "0x8FFD5C", VA = "0x8FFD5C")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x902A60", Offset = "0x902A60", VA = "0x902A60")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x8FFF9C", Offset = "0x8FFF9C", VA = "0x8FFF9C")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x900BA0", Offset = "0x900BA0", VA = "0x900BA0")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x900F98", Offset = "0x900F98", VA = "0x900F98")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x901078", Offset = "0x901078", VA = "0x901078")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8FDDB4", Offset = "0x8FDDB4", VA = "0x8FDDB4")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x900D24", Offset = "0x900D24", VA = "0x900D24")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x900DAC", Offset = "0x900DAC", VA = "0x900DAC")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x902BE4", Offset = "0x902BE4", VA = "0x902BE4")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x902EA8", Offset = "0x902EA8", VA = "0x902EA8")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x9013F4", Offset = "0x9013F4", VA = "0x9013F4")]
	[MonoPInvokeCallback(typeof(CAPI.FilterCallback))]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x8FDED8", Offset = "0x8FDED8", VA = "0x8FDED8")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x8FF730", Offset = "0x8FF730", VA = "0x8FF730")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x200006D")]
public class VoipManager
{
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x901514", Offset = "0x901514", VA = "0x901514")]
	public VoipManager()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x902DE0", Offset = "0x902DE0", VA = "0x902DE0")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x902820", Offset = "0x902820", VA = "0x902820")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x9031E4", Offset = "0x9031E4", VA = "0x9031E4")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x903334", Offset = "0x903334", VA = "0x903334")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200006E")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x903520", Offset = "0x903520", VA = "0x903520")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x9035A4", Offset = "0x9035A4", VA = "0x9035A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x9036E8", Offset = "0x9036E8", VA = "0x9036E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x90373C", Offset = "0x90373C", VA = "0x90373C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x9035D4", Offset = "0x9035D4", VA = "0x9035D4")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x9037EC", Offset = "0x9037EC", VA = "0x9037EC")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x903804", Offset = "0x903804", VA = "0x903804")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x200006F")]
public class AvatarLayer
{
	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x90380C", Offset = "0x90380C", VA = "0x90380C")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000070")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x903814", Offset = "0x903814", VA = "0x903814")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000071")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000072")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x90690C", Offset = "0x90690C", VA = "0x90690C")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x2000073")]
	public enum HandType
	{
		[Token(Token = "0x40004F5")]
		Right,
		[Token(Token = "0x40004F6")]
		Left,
		[Token(Token = "0x40004F7")]
		Max
	}

	[Token(Token = "0x2000074")]
	public enum HandJoint
	{
		[Token(Token = "0x40004F9")]
		HandBase,
		[Token(Token = "0x40004FA")]
		IndexBase,
		[Token(Token = "0x40004FB")]
		IndexTip,
		[Token(Token = "0x40004FC")]
		ThumbBase,
		[Token(Token = "0x40004FD")]
		ThumbTip,
		[Token(Token = "0x40004FE")]
		Max
	}

	[Token(Token = "0x2000075")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x908A54", Offset = "0x908A54", VA = "0x908A54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x908A9C", Offset = "0x908A9C", VA = "0x908A9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x908510", Offset = "0x908510", VA = "0x908510")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x9088AC", Offset = "0x9088AC", VA = "0x9088AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x9088B0", Offset = "0x9088B0", VA = "0x9088B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x908A5C", Offset = "0x908A5C", VA = "0x908A5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool EnableBody;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool RecordPackets;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool StartWithControllers;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool CombineMeshes;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool EnableLaughter;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40004D5")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40004D7")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40004D8")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40004D9")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40004DA")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40004DB")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x903828", Offset = "0x903828", VA = "0x903828")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x903CBC", Offset = "0x903CBC", VA = "0x903CBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x903D54", Offset = "0x903D54", VA = "0x903D54")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x903DB0", Offset = "0x903DB0", VA = "0x903DB0")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x903EC4", Offset = "0x903EC4", VA = "0x903EC4")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x903FA0", Offset = "0x903FA0", VA = "0x903FA0")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x904070", Offset = "0x904070", VA = "0x904070")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x904240", Offset = "0x904240", VA = "0x904240")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x904308", Offset = "0x904308", VA = "0x904308")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x90437C", Offset = "0x90437C", VA = "0x90437C")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x904434", Offset = "0x904434", VA = "0x904434")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x9044BC", Offset = "0x9044BC", VA = "0x9044BC")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x904560", Offset = "0x904560", VA = "0x904560")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x904578", Offset = "0x904578", VA = "0x904578")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x6000348")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x904984", Offset = "0x904984", VA = "0x904984")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x904CB0", Offset = "0x904CB0", VA = "0x904CB0")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x904E88", Offset = "0x904E88", VA = "0x904E88")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x9050C4", Offset = "0x9050C4", VA = "0x9050C4")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x9051F8", Offset = "0x9051F8", VA = "0x9051F8")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x905544", Offset = "0x905544", VA = "0x905544")]
	private void Start()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x905864", Offset = "0x905864", VA = "0x905864")]
	private void Update()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x906334", Offset = "0x906334", VA = "0x906334")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x906378", Offset = "0x906378", VA = "0x906378")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x8FF62C", Offset = "0x8FF62C", VA = "0x8FF62C")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x90549C", Offset = "0x90549C", VA = "0x90549C")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x9063A4", Offset = "0x9063A4", VA = "0x9063A4")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x905C50", Offset = "0x905C50", VA = "0x905C50")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x906630", Offset = "0x906630", VA = "0x906630")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x906454", Offset = "0x906454", VA = "0x906454")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x906980", Offset = "0x906980", VA = "0x906980")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x906E04", Offset = "0x906E04", VA = "0x906E04")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x9070D4", Offset = "0x9070D4", VA = "0x9070D4")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x90720C", Offset = "0x90720C", VA = "0x90720C")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x9073D8", Offset = "0x9073D8", VA = "0x9073D8")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x905E0C", Offset = "0x905E0C", VA = "0x905E0C")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x9074A0", Offset = "0x9074A0", VA = "0x9074A0")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x905C60", Offset = "0x905C60", VA = "0x905C60")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x90757C", Offset = "0x90757C", VA = "0x90757C")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x907BAC", Offset = "0x907BAC", VA = "0x907BAC")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x908034", Offset = "0x908034", VA = "0x908034")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x90805C", Offset = "0x90805C", VA = "0x90805C")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x908084", Offset = "0x908084", VA = "0x908084")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x9061DC", Offset = "0x9061DC", VA = "0x9061DC")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x907638", Offset = "0x907638", VA = "0x907638")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x90849C", Offset = "0x90849C", VA = "0x90849C")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x908538", Offset = "0x908538", VA = "0x908538")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x908330", Offset = "0x908330", VA = "0x908330")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x902FD4", Offset = "0x902FD4", VA = "0x902FD4")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x9085DC", Offset = "0x9085DC", VA = "0x9085DC")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x9080C0", Offset = "0x9080C0", VA = "0x9080C0")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x9086A4", Offset = "0x9086A4", VA = "0x9086A4")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x2000076")]
public class OvrAvatarAsset
{
	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x908AA4", Offset = "0x908AA4", VA = "0x908AA4")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x2000077")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x908AAC", Offset = "0x908AAC", VA = "0x908AAC")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x909C40", Offset = "0x909C40", VA = "0x909C40")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x90988C", Offset = "0x90988C", VA = "0x90988C")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x909610", Offset = "0x909610", VA = "0x909610")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x9096F0", Offset = "0x9096F0", VA = "0x9096F0")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x909E8C", Offset = "0x909E8C", VA = "0x909E8C")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x2000078")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x90A41C", Offset = "0x90A41C", VA = "0x90A41C")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000079")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x90A664", Offset = "0x90A664", VA = "0x90A664")]
	private void Update()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x90A77C", Offset = "0x90A77C", VA = "0x90A77C")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x200007A")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x90B7D4", Offset = "0x90B7D4", VA = "0x90B7D4")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x90B920", Offset = "0x90B920", VA = "0x90B920")]
	private void Update()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x90BD40", Offset = "0x90BD40", VA = "0x90BD40")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x200007B")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x90BE6C", Offset = "0x90BE6C", VA = "0x90BE6C")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x90BA34", Offset = "0x90BA34", VA = "0x90BA34")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x90C434", Offset = "0x90C434", VA = "0x90C434")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x90C488", Offset = "0x90C488", VA = "0x90C488")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x90CB90", Offset = "0x90CB90", VA = "0x90CB90")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x90BD94", Offset = "0x90BD94", VA = "0x90BD94")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x200007C")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x200007D")]
	public enum PacketMode
	{
		[Token(Token = "0x400051A")]
		SDK,
		[Token(Token = "0x400051B")]
		Unity
	}

	[Token(Token = "0x200007E")]
	public struct ControllerPose
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x90ED84", Offset = "0x90ED84", VA = "0x90ED84")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x200007F")]
	public struct PoseFrame
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x90EDF4", Offset = "0x90EDF4", VA = "0x90EDF4")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x90EA70", Offset = "0x90EA70", VA = "0x90EA70")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x600038A")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x90EA80", Offset = "0x90EA80", VA = "0x90EA80")]
	private void Start()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x90EAFC", Offset = "0x90EAFC", VA = "0x90EAFC")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x90ED6C", Offset = "0x90ED6C", VA = "0x90ED6C")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x90ED74", Offset = "0x90ED74", VA = "0x90ED74")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000080")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x90F0EC", Offset = "0x90F0EC", VA = "0x90F0EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x90F22C", Offset = "0x90F22C", VA = "0x90F22C")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000081")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x90F288", Offset = "0x90F288", VA = "0x90F288")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x90F3C8", Offset = "0x90F3C8", VA = "0x90F3C8")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x90F6F8", Offset = "0x90F6F8", VA = "0x90F6F8")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x90F914", Offset = "0x90F914", VA = "0x90F914", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x90F93C", Offset = "0x90F93C", VA = "0x90F93C")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000082")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000083")]
	public enum TextureType
	{
		[Token(Token = "0x4000551")]
		DiffuseTextures,
		[Token(Token = "0x4000552")]
		NormalMaps,
		[Token(Token = "0x4000553")]
		RoughnessMaps,
		[Token(Token = "0x4000554")]
		Count
	}

	[Token(Token = "0x2000084")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x2000085")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000086")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000087")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x911DAC", Offset = "0x911DAC", VA = "0x911DAC")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x2000088")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x9128A8", Offset = "0x9128A8", VA = "0x9128A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x9128F0", Offset = "0x9128F0", VA = "0x9128F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x911B68", Offset = "0x911B68", VA = "0x911B68")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x912204", Offset = "0x912204", VA = "0x912204", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x912208", Offset = "0x912208", VA = "0x912208", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9128B0", Offset = "0x9128B0", VA = "0x9128B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x400054C")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x400054D")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400054E")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x400054F")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x90F9DC", Offset = "0x90F9DC", VA = "0x90F9DC")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x90FBB0", Offset = "0x90FBB0", VA = "0x90FBB0")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x90FBEC", Offset = "0x90FBEC", VA = "0x90FBEC")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x910320", Offset = "0x910320", VA = "0x910320")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x9105F0", Offset = "0x9105F0", VA = "0x9105F0")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x90FC8C", Offset = "0x90FC8C", VA = "0x90FC8C")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x9106CC", Offset = "0x9106CC", VA = "0x9106CC")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x9100D8", Offset = "0x9100D8", VA = "0x9100D8")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x91095C", Offset = "0x91095C", VA = "0x91095C")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x910BE0", Offset = "0x910BE0", VA = "0x910BE0")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x910D04", Offset = "0x910D04", VA = "0x910D04")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x910D3C", Offset = "0x910D3C", VA = "0x910D3C")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x910290", Offset = "0x910290", VA = "0x910290")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x911B90", Offset = "0x911B90", VA = "0x911B90")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x2000089")]
public class OvrAvatarPacket
{
	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000042")]
	public float Duration
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9128F8", Offset = "0x9128F8", VA = "0x9128F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000043")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x91295C", Offset = "0x91295C", VA = "0x91295C")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x9129E4", Offset = "0x9129E4", VA = "0x9129E4")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x912B38", Offset = "0x912B38", VA = "0x912B38")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x912DD0", Offset = "0x912DD0", VA = "0x912DD0")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x912F5C", Offset = "0x912F5C", VA = "0x912F5C")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x9130E0", Offset = "0x9130E0", VA = "0x9130E0")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x9132BC", Offset = "0x9132BC", VA = "0x9132BC")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x9137FC", Offset = "0x9137FC", VA = "0x9137FC")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x200008A")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x913A20", Offset = "0x913A20", VA = "0x913A20")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x913B28", Offset = "0x913B28", VA = "0x913B28")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x913CB4", Offset = "0x913CB4", VA = "0x913CB4")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x913B8C", Offset = "0x913B8C", VA = "0x913B8C")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x913C14", Offset = "0x913C14", VA = "0x913C14")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x200008B")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x913660", Offset = "0x913660", VA = "0x913660")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x913EDC", Offset = "0x913EDC", VA = "0x913EDC")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x913CFC", Offset = "0x913CFC", VA = "0x913CFC")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x913D68", Offset = "0x913D68", VA = "0x913D68")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x913DF8", Offset = "0x913DF8", VA = "0x913DF8")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x200008C")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000576")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000577")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x913F2C", Offset = "0x913F2C", VA = "0x913F2C")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x913FB0", Offset = "0x913FB0", VA = "0x913FB0", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x913FCC", Offset = "0x913FCC", VA = "0x913FCC")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x91417C", Offset = "0x91417C", VA = "0x91417C")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x914338", Offset = "0x914338", VA = "0x914338")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x200008D")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x9143F4", Offset = "0x9143F4", VA = "0x9143F4")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x9144D0", Offset = "0x9144D0", VA = "0x9144D0")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x9146BC", Offset = "0x9146BC", VA = "0x9146BC")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x914A04", Offset = "0x914A04", VA = "0x914A04")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x914B08", Offset = "0x914B08", VA = "0x914B08")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x200008E")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x4000580")]
	Body = 1,
	[Token(Token = "0x4000581")]
	Hands = 2,
	[Token(Token = "0x4000582")]
	Base = 4,
	[Token(Token = "0x4000583")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000584")]
	Expressive = 0x20,
	[Token(Token = "0x4000585")]
	All = -1
}
[Token(Token = "0x200008F")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000587")]
	AvatarSpecification,
	[Token(Token = "0x4000588")]
	AssetLoaded,
	[Token(Token = "0x4000589")]
	Count
}
[Token(Token = "0x2000090")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000091")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000092")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x400058F")]
	Mesh,
	[Token(Token = "0x4000590")]
	Texture,
	[Token(Token = "0x4000591")]
	Pose,
	[Token(Token = "0x4000592")]
	Material,
	[Token(Token = "0x4000593")]
	CombinedMesh,
	[Token(Token = "0x4000594")]
	PBSMaterial,
	[Token(Token = "0x4000595")]
	FailedLoad,
	[Token(Token = "0x4000596")]
	Count
}
[Token(Token = "0x2000093")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x2000094")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000095")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x2000096")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000097")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000098")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x40005CB")]
	RGB24,
	[Token(Token = "0x40005CC")]
	DXT1,
	[Token(Token = "0x40005CD")]
	DXT5,
	[Token(Token = "0x40005CE")]
	ASTC_RGB_6x6,
	[Token(Token = "0x40005CF")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x40005D0")]
	Count
}
[Token(Token = "0x2000099")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x200009A")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x40005D8")]
	SkinnedMeshRender,
	[Token(Token = "0x40005D9")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x40005DA")]
	ProjectorRender,
	[Token(Token = "0x40005DB")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x40005DC")]
	Count
}
[Token(Token = "0x200009B")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40005DE")]
	Unknown,
	[Token(Token = "0x40005DF")]
	Default,
	[Token(Token = "0x40005E0")]
	Verbose,
	[Token(Token = "0x40005E1")]
	Debug,
	[Token(Token = "0x40005E2")]
	Info,
	[Token(Token = "0x40005E3")]
	Warn,
	[Token(Token = "0x40005E4")]
	Error,
	[Token(Token = "0x40005E5")]
	Fatal,
	[Token(Token = "0x40005E6")]
	Silent
}
[Token(Token = "0x200009C")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x200009D")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40005EB")]
	One = 1,
	[Token(Token = "0x40005EC")]
	Two = 2,
	[Token(Token = "0x40005ED")]
	Three = 4,
	[Token(Token = "0x40005EE")]
	Joystick = 8
}
[Token(Token = "0x200009E")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40005F0")]
	One = 1,
	[Token(Token = "0x40005F1")]
	Two = 2,
	[Token(Token = "0x40005F2")]
	Joystick = 4,
	[Token(Token = "0x40005F3")]
	ThumbRest = 8,
	[Token(Token = "0x40005F4")]
	Index = 0x10,
	[Token(Token = "0x40005F5")]
	Pointing = 0x40,
	[Token(Token = "0x40005F6")]
	ThumbUp = 0x80
}
[Token(Token = "0x200009F")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x20000A0")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x20000A1")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x20000A2")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x20000A3")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x20000A4")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x20000A5")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x20000A6")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x20000A7")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x4000616")]
	Add,
	[Token(Token = "0x4000617")]
	Multiply,
	[Token(Token = "0x4000618")]
	Count
}
[Token(Token = "0x20000A8")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x400061A")]
	Color,
	[Token(Token = "0x400061B")]
	Texture,
	[Token(Token = "0x400061C")]
	TextureSingleChannel,
	[Token(Token = "0x400061D")]
	Parallax,
	[Token(Token = "0x400061E")]
	Count
}
[Token(Token = "0x20000A9")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x4000620")]
	None,
	[Token(Token = "0x4000621")]
	Positional,
	[Token(Token = "0x4000622")]
	ViewReflection,
	[Token(Token = "0x4000623")]
	Fresnel,
	[Token(Token = "0x4000624")]
	Pulse,
	[Token(Token = "0x4000625")]
	Count
}
[Token(Token = "0x20000AA")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x4000627")]
	Touch,
	[Token(Token = "0x4000628")]
	Malibu,
	[Token(Token = "0x4000629")]
	Go,
	[Token(Token = "0x400062A")]
	Quest,
	[Token(Token = "0x400062B")]
	Count
}
[Token(Token = "0x20000AB")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x400062D")]
	Lowest = 1,
	[Token(Token = "0x400062E")]
	Medium = 3,
	[Token(Token = "0x400062F")]
	Highest = 5
}
[Token(Token = "0x20000AC")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x4000631")]
	Unknown = -1,
	[Token(Token = "0x4000632")]
	One,
	[Token(Token = "0x4000633")]
	Two
}
[Token(Token = "0x20000AD")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x914EE0", Offset = "0x914EE0", VA = "0x914EE0")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x914F10", Offset = "0x914F10", VA = "0x914F10", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x915120", Offset = "0x915120", VA = "0x915120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000AE")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x915364", Offset = "0x915364", VA = "0x915364")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x915394", Offset = "0x915394", VA = "0x915394", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x915724", Offset = "0x915724", VA = "0x915724", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000AF")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x915ACC", Offset = "0x915ACC", VA = "0x915ACC")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x915AFC", Offset = "0x915AFC", VA = "0x915AFC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x915D44", Offset = "0x915D44", VA = "0x915D44", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000B0")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x916018", Offset = "0x916018", VA = "0x916018")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x916048", Offset = "0x916048", VA = "0x916048", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x916210", Offset = "0x916210", VA = "0x916210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x20000B1")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x916424", Offset = "0x916424", VA = "0x916424")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x20000B2")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x20000B3")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x4000668")]
	FirstPerson = 1,
	[Token(Token = "0x4000669")]
	ThirdPerson = 2,
	[Token(Token = "0x400066A")]
	SelfOccluding = 4
}
[Token(Token = "0x20000B4")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000B5")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000B6")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x20000B7")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x400067C")]
	Default,
	[Token(Token = "0x400067D")]
	GripSphere,
	[Token(Token = "0x400067E")]
	GripCube,
	[Token(Token = "0x400067F")]
	Count
}
[Token(Token = "0x20000B8")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000681")]
	Body,
	[Token(Token = "0x4000682")]
	Clothing,
	[Token(Token = "0x4000683")]
	Eyewear,
	[Token(Token = "0x4000684")]
	Hair,
	[Token(Token = "0x4000685")]
	Beard,
	[Token(Token = "0x4000686")]
	Count
}
[Token(Token = "0x20000B9")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x20000BA")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x20000BB")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x20000BC")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x20000BD")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x4000690")]
	AvatarHead,
	[Token(Token = "0x4000691")]
	AvatarHand,
	[Token(Token = "0x4000692")]
	Object,
	[Token(Token = "0x4000693")]
	ObjectStatic,
	[Token(Token = "0x4000694")]
	Count
}
[Token(Token = "0x20000BE")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x20000BF")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x20000C0")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x20000C1")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x20000C2")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x40006A0")]
	Point,
	[Token(Token = "0x40006A1")]
	Direction,
	[Token(Token = "0x40006A2")]
	Spot,
	[Token(Token = "0x40006A3")]
	Count
}
[Token(Token = "0x20000C3")]
public struct ovrAvatarLight
{
	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x20000C4")]
public struct ovrAvatarLights
{
	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x20000C5")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x20000C6")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x20000C7")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x20000C8")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x20000C9")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x917F9C", Offset = "0x917F9C", VA = "0x917F9C")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x40006BA")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000044")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x90CC1C", Offset = "0x90CC1C", VA = "0x90CC1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x916CCC", Offset = "0x916CCC", VA = "0x916CCC")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x91701C", Offset = "0x91701C", VA = "0x91701C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x917080", Offset = "0x917080", VA = "0x917080")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x917A20", Offset = "0x917A20", VA = "0x917A20")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x917A70", Offset = "0x917A70", VA = "0x917A70")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x917AC0", Offset = "0x917AC0", VA = "0x917AC0")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x917B68", Offset = "0x917B68", VA = "0x917B68")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x917BC0", Offset = "0x917BC0", VA = "0x917BC0")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x917844", Offset = "0x917844", VA = "0x917844")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x917C84", Offset = "0x917C84", VA = "0x917C84")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x917DD0", Offset = "0x917DD0", VA = "0x917DD0")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x90CE08", Offset = "0x90CE08", VA = "0x90CE08")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x917EBC", Offset = "0x917EBC", VA = "0x917EBC")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x916FDC", Offset = "0x916FDC", VA = "0x916FDC")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x91037C", Offset = "0x91037C", VA = "0x91037C")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x917F84", Offset = "0x917F84", VA = "0x917F84")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x20000CA")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000045")]
	public static string AppID
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x917F4C", Offset = "0x917F4C", VA = "0x917F4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x918148", Offset = "0x918148", VA = "0x918148")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public static string MobileAppID
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x917F68", Offset = "0x917F68", VA = "0x917F68")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x91816C", Offset = "0x91816C", VA = "0x91816C")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x918004", Offset = "0x918004", VA = "0x918004")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x918190", Offset = "0x918190", VA = "0x918190")]
		set
		{
		}
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x9181E8", Offset = "0x9181E8", VA = "0x9181E8")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x20000CB")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x918250", Offset = "0x918250", VA = "0x918250")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x90BE74", Offset = "0x90BE74", VA = "0x90BE74")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x9183CC", Offset = "0x9183CC", VA = "0x9183CC")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x918514", Offset = "0x918514", VA = "0x918514")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x20000CC")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x918524", Offset = "0x918524", VA = "0x918524")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x90C080", Offset = "0x90C080", VA = "0x90C080")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x918674", Offset = "0x918674", VA = "0x918674")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x20000CD")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40006D1")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40006D2")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40006D3")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x918684", Offset = "0x918684", VA = "0x918684")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x90C228", Offset = "0x90C228", VA = "0x90C228")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x919628", Offset = "0x919628", VA = "0x919628")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x918DC4", Offset = "0x918DC4", VA = "0x918DC4")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x918AC0", Offset = "0x918AC0", VA = "0x918AC0")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x918C38", Offset = "0x918C38", VA = "0x918C38")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x919E30", Offset = "0x919E30", VA = "0x919E30")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x20000CE")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000CF")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x20000D0")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x91A588", Offset = "0x91A588", VA = "0x91A588")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x20000D1")]
	public struct TextureSet
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x91A5D8", Offset = "0x91A5D8", VA = "0x91A5D8")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x20000D2")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x91AE08", Offset = "0x91AE08", VA = "0x91AE08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x91AE50", Offset = "0x91AE50", VA = "0x91AE50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x91A6A8", Offset = "0x91A6A8", VA = "0x91A6A8")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x91A834", Offset = "0x91A834", VA = "0x91A834", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x91A838", Offset = "0x91A838", VA = "0x91A838", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x91AE10", Offset = "0x91AE10", VA = "0x91AE10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40006D7")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40006D8")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40006DB")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40006DC")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40006DD")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40006DE")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40006DF")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40006E0")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40006E1")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x919E40", Offset = "0x919E40", VA = "0x919E40")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x91A3A4", Offset = "0x91A3A4", VA = "0x91A3A4")]
	public void Update()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x912860", Offset = "0x912860", VA = "0x912860")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x91079C", Offset = "0x91079C", VA = "0x91079C")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x91A508", Offset = "0x91A508", VA = "0x91A508")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x9103F0", Offset = "0x9103F0", VA = "0x9103F0")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x910634", Offset = "0x910634", VA = "0x910634")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x91A600", Offset = "0x91A600", VA = "0x91A600")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x917C44", Offset = "0x917C44", VA = "0x917C44")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x91A6D0", Offset = "0x91A6D0", VA = "0x91A6D0")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x20000D3")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x91AE58", Offset = "0x91AE58", VA = "0x91AE58")]
	private void Update()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x91AF98", Offset = "0x91AF98", VA = "0x91AF98")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x20000D4")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x20000D5")]
	public delegate void OnClick();

	[Token(Token = "0x20000D6")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x20000D7")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x20000D8")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x91C688", Offset = "0x91C688", VA = "0x91C688")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x91D5F4", Offset = "0x91D5F4", VA = "0x91D5F4")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x20000D9")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x91C950", Offset = "0x91C950", VA = "0x91C950")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x91D618", Offset = "0x91D618", VA = "0x91D618")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x20000DA")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x91CBC4", Offset = "0x91CBC4", VA = "0x91CBC4")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x91D63C", Offset = "0x91D63C", VA = "0x91D63C")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000DB")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x91CDC0", Offset = "0x91CDC0", VA = "0x91CDC0")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x91D664", Offset = "0x91D664", VA = "0x91D664")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000DC")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x91D0B8", Offset = "0x91D0B8", VA = "0x91D0B8")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x91D68C", Offset = "0x91D68C", VA = "0x91D68C")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40006F3")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40006F4")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40006F5")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x91AFF4", Offset = "0x91AFF4", VA = "0x91AFF4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x91B560", Offset = "0x91B560", VA = "0x91B560")]
	public void Show()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x91B8DC", Offset = "0x91B8DC", VA = "0x91B8DC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x91BA58", Offset = "0x91BA58", VA = "0x91BA58")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x91BC70", Offset = "0x91BC70", VA = "0x91BC70")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x91B8CC", Offset = "0x91B8CC", VA = "0x91B8CC")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x91BF64", Offset = "0x91BF64", VA = "0x91BF64")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x91C2E0", Offset = "0x91C2E0", VA = "0x91C2E0")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x91C690", Offset = "0x91C690", VA = "0x91C690")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x91C788", Offset = "0x91C788", VA = "0x91C788")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x91C958", Offset = "0x91C958", VA = "0x91C958")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x91C9F0", Offset = "0x91C9F0", VA = "0x91C9F0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x91CBCC", Offset = "0x91CBCC", VA = "0x91CBCC")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x91CDC8", Offset = "0x91CDC8", VA = "0x91CDC8")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x91D0C0", Offset = "0x91D0C0", VA = "0x91D0C0")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x91D1B0", Offset = "0x91D1B0", VA = "0x91D1B0")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x91D244", Offset = "0x91D244", VA = "0x91D244")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000DD")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x91D6B4", Offset = "0x91D6B4", VA = "0x91D6B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x91D758", Offset = "0x91D758", VA = "0x91D758")]
	private void Update()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x91D7F4", Offset = "0x91D7F4", VA = "0x91D7F4")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x91D82C", Offset = "0x91D82C", VA = "0x91D82C")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000DE")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000DF")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000725")]
		On,
		[Token(Token = "0x4000726")]
		Off,
		[Token(Token = "0x4000727")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700004A")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x91D834", Offset = "0x91D834", VA = "0x91D834")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x91B520", Offset = "0x91B520", VA = "0x91B520")]
		set
		{
		}
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x91D83C", Offset = "0x91D83C", VA = "0x91D83C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x91D894", Offset = "0x91D894", VA = "0x91D894")]
	private void Start()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x91D9CC", Offset = "0x91D9CC", VA = "0x91D9CC", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x91D9E8", Offset = "0x91D9E8", VA = "0x91D9E8", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x91DA38", Offset = "0x91DA38", VA = "0x91DA38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x91DBD8", Offset = "0x91DBD8", VA = "0x91DBD8")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x91DCE8", Offset = "0x91DCE8", VA = "0x91DCE8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x91DD6C", Offset = "0x91DD6C", VA = "0x91DD6C")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x91DE2C", Offset = "0x91DE2C", VA = "0x91DE2C")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x91DED4", Offset = "0x91DED4", VA = "0x91DED4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x91DFC0", Offset = "0x91DFC0", VA = "0x91DFC0")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000E0")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000728")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000729")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400072A")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float HeightOffset;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumHeight;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float MaximumHeight;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x91DFD0", Offset = "0x91DFD0", VA = "0x91DFD0")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x91DFD8", Offset = "0x91DFD8", VA = "0x91DFD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x91E068", Offset = "0x91E068", VA = "0x91E068")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x91E0F4", Offset = "0x91E0F4", VA = "0x91E0F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x91E180", Offset = "0x91E180", VA = "0x91E180")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x91E4A0", Offset = "0x91E4A0", VA = "0x91E4A0")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x91E700", Offset = "0x91E700", VA = "0x91E700")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000E1")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x91EE58", Offset = "0x91EE58", VA = "0x91EE58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x91EF04", Offset = "0x91EF04", VA = "0x91EF04")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000E2")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000E3")]
	public enum States
	{
		[Token(Token = "0x4000758")]
		Ready,
		[Token(Token = "0x4000759")]
		Aim,
		[Token(Token = "0x400075A")]
		CancelAim,
		[Token(Token = "0x400075B")]
		PreTeleport,
		[Token(Token = "0x400075C")]
		CancelTeleport,
		[Token(Token = "0x400075D")]
		Teleporting,
		[Token(Token = "0x400075E")]
		PostTeleport
	}

	[Token(Token = "0x20000E4")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000760")]
		None,
		[Token(Token = "0x4000761")]
		Aim,
		[Token(Token = "0x4000762")]
		PreTeleport,
		[Token(Token = "0x4000763")]
		Teleport
	}

	[Token(Token = "0x20000E5")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000765")]
		Point,
		[Token(Token = "0x4000766")]
		Sphere,
		[Token(Token = "0x4000767")]
		Capsule
	}

	[Token(Token = "0x20000E6")]
	public class AimData
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700004E")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x920BD4", Offset = "0x920BD4", VA = "0x920BD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x920BDC", Offset = "0x920BDC", VA = "0x920BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x920B4C", Offset = "0x920B4C", VA = "0x920B4C")]
		public AimData()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x920BE4", Offset = "0x920BE4", VA = "0x920BE4")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000E7")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x920D4C", Offset = "0x920D4C", VA = "0x920D4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x920D94", Offset = "0x920D94", VA = "0x920D94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x91F8F0", Offset = "0x91F8F0", VA = "0x91F8F0")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x920C3C", Offset = "0x920C3C", VA = "0x920C3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x920C40", Offset = "0x920C40", VA = "0x920C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x920D54", Offset = "0x920D54", VA = "0x920D54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E8")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x920EF8", Offset = "0x920EF8", VA = "0x920EF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x920F40", Offset = "0x920F40", VA = "0x920F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x91FD78", Offset = "0x91FD78", VA = "0x91FD78")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x920D9C", Offset = "0x920D9C", VA = "0x920D9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x920DA0", Offset = "0x920DA0", VA = "0x920DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x920F00", Offset = "0x920F00", VA = "0x920F00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x920FFC", Offset = "0x920FFC", VA = "0x920FFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x921044", Offset = "0x921044", VA = "0x921044", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x91FF4C", Offset = "0x91FF4C", VA = "0x91FF4C")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x920F48", Offset = "0x920F48", VA = "0x920F48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x920F4C", Offset = "0x920F4C", VA = "0x920F4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x921004", Offset = "0x921004", VA = "0x921004", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EA")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x921134", Offset = "0x921134", VA = "0x921134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x92117C", Offset = "0x92117C", VA = "0x92117C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x920120", Offset = "0x920120", VA = "0x920120")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x92104C", Offset = "0x92104C", VA = "0x92104C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x921050", Offset = "0x921050", VA = "0x921050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x92113C", Offset = "0x92113C", VA = "0x92113C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x921238", Offset = "0x921238", VA = "0x921238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x921280", Offset = "0x921280", VA = "0x921280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9202F4", Offset = "0x9202F4", VA = "0x9202F4")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x921184", Offset = "0x921184", VA = "0x921184", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x921188", Offset = "0x921188", VA = "0x921188", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x921240", Offset = "0x921240", VA = "0x921240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EC")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x92139C", Offset = "0x92139C", VA = "0x92139C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x9213E4", Offset = "0x9213E4", VA = "0x9213E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x921288", Offset = "0x921288", VA = "0x921288")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x9212B0", Offset = "0x9212B0", VA = "0x9212B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9212B4", Offset = "0x9212B4", VA = "0x9212B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x9213A4", Offset = "0x9213A4", VA = "0x9213A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000ED")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x92151C", Offset = "0x92151C", VA = "0x92151C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x921564", Offset = "0x921564", VA = "0x921564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x9213EC", Offset = "0x9213EC", VA = "0x9213EC")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x921414", Offset = "0x921414", VA = "0x921414", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x921418", Offset = "0x921418", VA = "0x921418", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x921524", Offset = "0x921524", VA = "0x921524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float AimCollisionRadius;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700004B")]
	public States CurrentState
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x91EF54", Offset = "0x91EF54", VA = "0x91EF54")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x91EF5C", Offset = "0x91EF5C", VA = "0x91EF5C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x91F12C", Offset = "0x91F12C", VA = "0x91F12C")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700004D")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x91F150", Offset = "0x91F150", VA = "0x91F150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x91F158", Offset = "0x91F158", VA = "0x91F158")]
		private set
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x91EF64", Offset = "0x91EF64", VA = "0x91EF64")]
		add
		{
		}
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x91F014", Offset = "0x91F014", VA = "0x91F014")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x91F7B8", Offset = "0x91F7B8", VA = "0x91F7B8")]
		add
		{
		}
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x91F854", Offset = "0x91F854", VA = "0x91F854")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x91F918", Offset = "0x91F918", VA = "0x91F918")]
		add
		{
		}
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x91F9B4", Offset = "0x91F9B4", VA = "0x91F9B4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x91FA50", Offset = "0x91FA50", VA = "0x91FA50")]
		add
		{
		}
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x91FB00", Offset = "0x91FB00", VA = "0x91FB00")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x91FBCC", Offset = "0x91FBCC", VA = "0x91FBCC")]
		add
		{
		}
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x91FC68", Offset = "0x91FC68", VA = "0x91FC68")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x91FDA0", Offset = "0x91FDA0", VA = "0x91FDA0")]
		add
		{
		}
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x91FE3C", Offset = "0x91FE3C", VA = "0x91FE3C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x91FF74", Offset = "0x91FF74", VA = "0x91FF74")]
		add
		{
		}
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x920010", Offset = "0x920010", VA = "0x920010")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x920148", Offset = "0x920148", VA = "0x920148")]
		add
		{
		}
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x9201E4", Offset = "0x9201E4", VA = "0x9201E4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x92031C", Offset = "0x92031C", VA = "0x92031C")]
		add
		{
		}
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x9203B8", Offset = "0x9203B8", VA = "0x9203B8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x9204C8", Offset = "0x9204C8", VA = "0x9204C8")]
		add
		{
		}
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x920564", Offset = "0x920564", VA = "0x920564")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x920674", Offset = "0x920674", VA = "0x920674")]
		add
		{
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x920724", Offset = "0x920724", VA = "0x920724")]
		remove
		{
		}
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x91EF0C", Offset = "0x91EF0C", VA = "0x91EF0C")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x91EF30", Offset = "0x91EF30", VA = "0x91EF30")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x91F0C4", Offset = "0x91F0C4", VA = "0x91F0C4")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x91F160", Offset = "0x91F160", VA = "0x91F160")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x91F428", Offset = "0x91F428", VA = "0x91F428")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x91F4D0", Offset = "0x91F4D0", VA = "0x91F4D0")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x91F5BC", Offset = "0x91F5BC", VA = "0x91F5BC")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x91F5D8", Offset = "0x91F5D8", VA = "0x91F5D8")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x91F688", Offset = "0x91F688", VA = "0x91F688")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x91F6B8", Offset = "0x91F6B8", VA = "0x91F6B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x91F718", Offset = "0x91F718", VA = "0x91F718", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x91F7B0", Offset = "0x91F7B0", VA = "0x91F7B0", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x91F73C", Offset = "0x91F73C", VA = "0x91F73C")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x91FBB0", Offset = "0x91FBB0", VA = "0x91FBB0")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x91FD04", Offset = "0x91FD04", VA = "0x91FD04")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x91FED8", Offset = "0x91FED8", VA = "0x91FED8")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x9200AC", Offset = "0x9200AC", VA = "0x9200AC")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x920280", Offset = "0x920280", VA = "0x920280")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x920454", Offset = "0x920454", VA = "0x920454")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x920600", Offset = "0x920600", VA = "0x920600")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x9207D4", Offset = "0x9207D4", VA = "0x9207D4")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x9208E8", Offset = "0x9208E8", VA = "0x9208E8")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x920918", Offset = "0x920918", VA = "0x920918")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x920A54", Offset = "0x920A54", VA = "0x920A54")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x920B3C", Offset = "0x920B3C", VA = "0x920B3C")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000EE")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x4000784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000E")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x92156C", Offset = "0x92156C", VA = "0x92156C")]
		add
		{
		}
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x921608", Offset = "0x921608", VA = "0x921608")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9216A4", Offset = "0x9216A4", VA = "0x9216A4")]
		add
		{
		}
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x921740", Offset = "0x921740", VA = "0x921740")]
		remove
		{
		}
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x9217DC", Offset = "0x9217DC", VA = "0x9217DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x9218BC", Offset = "0x9218BC", VA = "0x9218BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x921930", Offset = "0x921930", VA = "0x921930")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x921A54", Offset = "0x921A54", VA = "0x921A54")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x921CCC", Offset = "0x921CCC", VA = "0x921CCC")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x921EEC", Offset = "0x921EEC", VA = "0x921EEC")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000EF")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x921F0C", Offset = "0x921F0C", VA = "0x921F0C", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x921F9C", Offset = "0x921F9C", VA = "0x921F9C", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60004C8")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x92206C", Offset = "0x92206C", VA = "0x92206C")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000F0")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x92207C", Offset = "0x92207C", VA = "0x92207C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x92220C", Offset = "0x92220C", VA = "0x92220C")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000F1")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumElevation;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Gravity;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x92221C", Offset = "0x92221C", VA = "0x92221C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x9223F0", Offset = "0x9223F0", VA = "0x9223F0")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000F2")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x922404", Offset = "0x922404", VA = "0x922404")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x922530", Offset = "0x922530", VA = "0x922530")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x92255C", Offset = "0x92255C", VA = "0x92255C")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x922588", Offset = "0x922588", VA = "0x922588")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x92262C", Offset = "0x92262C", VA = "0x92262C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x92268C", Offset = "0x92268C", VA = "0x92268C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x9226E8", Offset = "0x9226E8", VA = "0x9226E8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000F3")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform PositionIndicator;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform OrientationIndicator;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700005D")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x9227E4", Offset = "0x9227E4", VA = "0x9227E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x9227EC", Offset = "0x9227EC", VA = "0x9227EC")]
		private set
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x92297C", Offset = "0x92297C", VA = "0x92297C")]
		add
		{
		}
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x922A2C", Offset = "0x922A2C", VA = "0x922A2C")]
		remove
		{
		}
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x9227F8", Offset = "0x9227F8", VA = "0x9227F8")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x92287C", Offset = "0x92287C", VA = "0x92287C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x922944", Offset = "0x922944", VA = "0x922944")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x922978", Offset = "0x922978", VA = "0x922978")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x922ADC", Offset = "0x922ADC", VA = "0x922ADC")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x922B00", Offset = "0x922B00", VA = "0x922B00")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x922B20", Offset = "0x922B20", VA = "0x922B20", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000F4")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000F5")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x9230F8", Offset = "0x9230F8", VA = "0x9230F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x923140", Offset = "0x923140", VA = "0x923140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x922F64", Offset = "0x922F64", VA = "0x922F64")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x923068", Offset = "0x923068", VA = "0x923068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x92306C", Offset = "0x92306C", VA = "0x92306C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x923100", Offset = "0x923100", VA = "0x923100", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F6")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x9231E4", Offset = "0x9231E4", VA = "0x9231E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x92322C", Offset = "0x92322C", VA = "0x92322C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x923000", Offset = "0x923000", VA = "0x923000")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x923148", Offset = "0x923148", VA = "0x923148", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x92314C", Offset = "0x92314C", VA = "0x92314C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x9231EC", Offset = "0x9231EC", VA = "0x9231EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x922D14", Offset = "0x922D14", VA = "0x922D14")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x922DE8", Offset = "0x922DE8", VA = "0x922DE8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x922E3C", Offset = "0x922E3C", VA = "0x922E3C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x922EF0", Offset = "0x922EF0", VA = "0x922EF0")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x922F8C", Offset = "0x922F8C", VA = "0x922F8C")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60004E5")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60004E6")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x923028", Offset = "0x923028", VA = "0x923028")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x923048", Offset = "0x923048", VA = "0x923048")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000F7")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool FastTeleport;

	[Token(Token = "0x17000062")]
	public Transform Pointer
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x923234", Offset = "0x923234", VA = "0x923234")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x92323C", Offset = "0x92323C", VA = "0x92323C")]
		private set
		{
		}
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x923244", Offset = "0x923244", VA = "0x923244", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x923370", Offset = "0x923370", VA = "0x923370", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x923424", Offset = "0x923424", VA = "0x923424")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000F8")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000F9")]
	public enum InputModes
	{
		[Token(Token = "0x40007B8")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40007B9")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40007BA")]
		ThumbstickTeleport,
		[Token(Token = "0x40007BB")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000FA")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40007BD")]
		A,
		[Token(Token = "0x40007BE")]
		B,
		[Token(Token = "0x40007BF")]
		LeftTrigger,
		[Token(Token = "0x40007C0")]
		LeftThumbstick,
		[Token(Token = "0x40007C1")]
		RightTrigger,
		[Token(Token = "0x40007C2")]
		RightThumbstick,
		[Token(Token = "0x40007C3")]
		X,
		[Token(Token = "0x40007C4")]
		Y
	}

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputModes InputMode;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x923428", Offset = "0x923428", VA = "0x923428", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x92385C", Offset = "0x92385C", VA = "0x92385C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x923918", Offset = "0x923918", VA = "0x923918")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000FB")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000FC")]
	public enum OrientationModes
	{
		[Token(Token = "0x40007C9")]
		HeadRelative,
		[Token(Token = "0x40007CA")]
		ForwardFacing
	}

	[Token(Token = "0x20000FD")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x923DD8", Offset = "0x923DD8", VA = "0x923DD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x923E20", Offset = "0x923E20", VA = "0x923E20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x923BE8", Offset = "0x923BE8", VA = "0x923BE8")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x923D28", Offset = "0x923D28", VA = "0x923D28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x923D2C", Offset = "0x923D2C", VA = "0x923D2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x923DE0", Offset = "0x923DE0", VA = "0x923DE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x923A08", Offset = "0x923A08", VA = "0x923A08")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x923AF0", Offset = "0x923AF0", VA = "0x923AF0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x923AF8", Offset = "0x923AF8", VA = "0x923AF8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x923B38", Offset = "0x923B38", VA = "0x923B38", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x923B74", Offset = "0x923B74", VA = "0x923B74")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000502")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000503")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x923C10", Offset = "0x923C10", VA = "0x923C10")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x923D08", Offset = "0x923D08", VA = "0x923D08")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000FE")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x923E28", Offset = "0x923E28", VA = "0x923E28", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x923E2C", Offset = "0x923E2C", VA = "0x923E2C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x923EA4", Offset = "0x923EA4", VA = "0x923EA4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000FF")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x923EA8", Offset = "0x923EA8", VA = "0x923EA8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x923EF8", Offset = "0x923EF8", VA = "0x923EF8", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x924374", Offset = "0x924374", VA = "0x924374")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000100")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float RotateStickThreshold;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x924378", Offset = "0x924378", VA = "0x924378", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x9243B0", Offset = "0x9243B0", VA = "0x9243B0", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x924888", Offset = "0x924888", VA = "0x924888")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x2000101")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x924898", Offset = "0x924898", VA = "0x924898")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x9248A0", Offset = "0x9248A0", VA = "0x9248A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x92498C", Offset = "0x92498C", VA = "0x92498C")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x9249A8", Offset = "0x9249A8", VA = "0x9249A8")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x2000102")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000065")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9249C0", Offset = "0x9249C0", VA = "0x9249C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9249C8", Offset = "0x9249C8", VA = "0x9249C8")]
		private set
		{
		}
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x921F34", Offset = "0x921F34", VA = "0x921F34", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x922044", Offset = "0x922044", VA = "0x922044", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x9249D0", Offset = "0x9249D0", VA = "0x9249D0")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x922680", Offset = "0x922680", VA = "0x922680", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x9226E0", Offset = "0x9226E0", VA = "0x9226E0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x922074", Offset = "0x922074", VA = "0x922074")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x2000103")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000104")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x9250BC", Offset = "0x9250BC", VA = "0x9250BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x925104", Offset = "0x925104", VA = "0x925104", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x924C84", Offset = "0x924C84", VA = "0x924C84")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x924E04", Offset = "0x924E04", VA = "0x924E04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x924E08", Offset = "0x924E08", VA = "0x924E08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x9250C4", Offset = "0x9250C4", VA = "0x9250C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40007E4")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x924AA0", Offset = "0x924AA0", VA = "0x924AA0")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x924BBC", Offset = "0x924BBC", VA = "0x924BBC", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x924BE8", Offset = "0x924BE8", VA = "0x924BE8", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x924C10", Offset = "0x924C10", VA = "0x924C10")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x924CAC", Offset = "0x924CAC", VA = "0x924CAC", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000526")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x924CC8", Offset = "0x924CC8", VA = "0x924CC8", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x924DE4", Offset = "0x924DE4", VA = "0x924DE4")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x2000105")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x92510C", Offset = "0x92510C", VA = "0x92510C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x925174", Offset = "0x925174", VA = "0x925174", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x9252E0", Offset = "0x9252E0", VA = "0x9252E0", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x9253D0", Offset = "0x9253D0", VA = "0x9253D0")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000106")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float LOSOffset;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x9253DC", Offset = "0x9253DC", VA = "0x9253DC", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x9255DC", Offset = "0x9255DC", VA = "0x9255DC")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000107")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x9255E8", Offset = "0x9255E8", VA = "0x9255E8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x925754", Offset = "0x925754", VA = "0x925754")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000108")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x925758", Offset = "0x925758", VA = "0x925758", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x9257E0", Offset = "0x9257E0", VA = "0x9257E0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000539")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x925864", Offset = "0x925864", VA = "0x925864")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000109")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x200010A")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x925BCC", Offset = "0x925BCC", VA = "0x925BCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x925C14", Offset = "0x925C14", VA = "0x925C14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x925900", Offset = "0x925900", VA = "0x925900")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x925AC4", Offset = "0x925AC4", VA = "0x925AC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x925AC8", Offset = "0x925AC8", VA = "0x925AC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x925BD4", Offset = "0x925BD4", VA = "0x925BD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x92586C", Offset = "0x92586C", VA = "0x92586C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x92588C", Offset = "0x92588C", VA = "0x92588C")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x925928", Offset = "0x925928", VA = "0x925928")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x200010B")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x925C1C", Offset = "0x925C1C", VA = "0x925C1C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x925C38", Offset = "0x925C38", VA = "0x925C38")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x200010C")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x200010D")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x925E68", Offset = "0x925E68", VA = "0x925E68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x925EB0", Offset = "0x925EB0", VA = "0x925EB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x925CD4", Offset = "0x925CD4", VA = "0x925CD4")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x925D44", Offset = "0x925D44", VA = "0x925D44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x925D48", Offset = "0x925D48", VA = "0x925D48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x925E70", Offset = "0x925E70", VA = "0x925E70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x925C40", Offset = "0x925C40", VA = "0x925C40", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x925C60", Offset = "0x925C60", VA = "0x925C60")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x925CFC", Offset = "0x925CFC", VA = "0x925CFC")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x200010E")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x200010F")]
	public enum StereoMode
	{
		[Token(Token = "0x4000813")]
		Unknown = -1,
		[Token(Token = "0x4000814")]
		Mono,
		[Token(Token = "0x4000815")]
		TopBottom,
		[Token(Token = "0x4000816")]
		LeftRight,
		[Token(Token = "0x4000817")]
		Mesh
	}

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700006C")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x925EB8", Offset = "0x925EB8", VA = "0x925EB8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700006D")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9261A8", Offset = "0x9261A8", VA = "0x9261A8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700006E")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x926428", Offset = "0x926428", VA = "0x926428")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x92649C", Offset = "0x92649C", VA = "0x92649C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public static long Duration
	{
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x9265A0", Offset = "0x9265A0", VA = "0x9265A0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000071")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x9266A8", Offset = "0x9266A8", VA = "0x9266A8")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000072")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x9267B0", Offset = "0x9267B0", VA = "0x9267B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000073")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x9268B8", Offset = "0x9268B8", VA = "0x9268B8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000074")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x9269C0", Offset = "0x9269C0", VA = "0x9269C0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x926AC8", Offset = "0x926AC8", VA = "0x926AC8")]
		set
		{
		}
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x926C30", Offset = "0x926C30", VA = "0x926C30")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x926E48", Offset = "0x926E48", VA = "0x926E48")]
	public static void Stop()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x926F50", Offset = "0x926F50", VA = "0x926F50")]
	public static void Play()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x927058", Offset = "0x927058", VA = "0x927058")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x927160", Offset = "0x927160", VA = "0x927160")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x9272D0", Offset = "0x9272D0", VA = "0x9272D0")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x92743C", Offset = "0x92743C", VA = "0x92743C")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000110")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x14000011")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x927690", Offset = "0x927690", VA = "0x927690")]
		add
		{
		}
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x92772C", Offset = "0x92772C", VA = "0x92772C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x9277C8", Offset = "0x9277C8", VA = "0x9277C8", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x9277E4", Offset = "0x9277E4", VA = "0x9277E4")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x2000111")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000112")]
	public enum ButtonType
	{
		[Token(Token = "0x400081B")]
		Play,
		[Token(Token = "0x400081C")]
		Pause,
		[Token(Token = "0x400081D")]
		FastForward,
		[Token(Token = "0x400081E")]
		Rewind,
		[Token(Token = "0x400081F")]
		SkipForward,
		[Token(Token = "0x4000820")]
		SkipBack,
		[Token(Token = "0x4000821")]
		Stop
	}

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000075")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x9277EC", Offset = "0x9277EC", VA = "0x9277EC")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x9277F4", Offset = "0x9277F4", VA = "0x9277F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x927818", Offset = "0x927818", VA = "0x927818", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x92866C", Offset = "0x92866C", VA = "0x92866C")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000113")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000114")]
	public enum VideoShape
	{
		[Token(Token = "0x4000836")]
		_360,
		[Token(Token = "0x4000837")]
		_180,
		[Token(Token = "0x4000838")]
		Quad
	}

	[Token(Token = "0x2000115")]
	public enum VideoStereo
	{
		[Token(Token = "0x400083A")]
		Mono,
		[Token(Token = "0x400083B")]
		TopBottom,
		[Token(Token = "0x400083C")]
		LeftRight,
		[Token(Token = "0x400083D")]
		BottomTop
	}

	[Token(Token = "0x2000116")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x929B94", Offset = "0x929B94", VA = "0x929B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x929BDC", Offset = "0x929BDC", VA = "0x929BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x928D50", Offset = "0x928D50", VA = "0x928D50")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x9299E8", Offset = "0x9299E8", VA = "0x9299E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x9299EC", Offset = "0x9299EC", VA = "0x9299EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x929B9C", Offset = "0x929B9C", VA = "0x929B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000117")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x929048", Offset = "0x929048", VA = "0x929048")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x929BE4", Offset = "0x929BE4", VA = "0x929BE4")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000076")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x9286C4", Offset = "0x9286C4", VA = "0x9286C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x9286CC", Offset = "0x9286CC", VA = "0x9286CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public long Duration
	{
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x9286D8", Offset = "0x9286D8", VA = "0x9286D8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x9286E0", Offset = "0x9286E0", VA = "0x9286E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public long PlaybackPosition
	{
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x9286E8", Offset = "0x9286E8", VA = "0x9286E8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x9286F0", Offset = "0x9286F0", VA = "0x9286F0")]
		private set
		{
		}
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x9286F8", Offset = "0x9286F8", VA = "0x9286F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x92897C", Offset = "0x92897C", VA = "0x92897C")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x9289DC", Offset = "0x9289DC", VA = "0x9289DC")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x928CDC", Offset = "0x928CDC", VA = "0x928CDC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x928D78", Offset = "0x928D78", VA = "0x928D78")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x929050", Offset = "0x929050", VA = "0x929050")]
	public void Play()
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x9290D4", Offset = "0x9290D4", VA = "0x9290D4")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x929154", Offset = "0x929154", VA = "0x929154")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x929240", Offset = "0x929240", VA = "0x929240")]
	private void Update()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x9297DC", Offset = "0x9297DC", VA = "0x9297DC")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x929878", Offset = "0x929878", VA = "0x929878")]
	public void Stop()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x9298F8", Offset = "0x9298F8", VA = "0x9298F8")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x9299D8", Offset = "0x9299D8", VA = "0x9299D8")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000118")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000119")]
	private enum PlaybackState
	{
		[Token(Token = "0x400085A")]
		Playing,
		[Token(Token = "0x400085B")]
		Paused,
		[Token(Token = "0x400085C")]
		Rewinding,
		[Token(Token = "0x400085D")]
		FastForwarding
	}

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x929CB8", Offset = "0x929CB8", VA = "0x929CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x929FE4", Offset = "0x929FE4", VA = "0x929FE4")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x92A1B4", Offset = "0x92A1B4", VA = "0x92A1B4")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x92A2D8", Offset = "0x92A2D8", VA = "0x92A2D8")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x92A3D4", Offset = "0x92A3D4", VA = "0x92A3D4")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x92A2AC", Offset = "0x92A2AC", VA = "0x92A2AC")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x92A434", Offset = "0x92A434", VA = "0x92A434")]
	private void Update()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x929EE4", Offset = "0x929EE4", VA = "0x929EE4")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x92A764", Offset = "0x92A764", VA = "0x92A764")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x200011A")]
public static class VectorUtil
{
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x929764", Offset = "0x929764", VA = "0x929764")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x200011B")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400085E")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x400085F")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x92A774", Offset = "0x92A774", VA = "0x92A774")]
	private void Start()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x92ADC8", Offset = "0x92ADC8", VA = "0x92ADC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x92B024", Offset = "0x92B024", VA = "0x92B024")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x92B188", Offset = "0x92B188", VA = "0x92B188")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x92B2F0", Offset = "0x92B2F0", VA = "0x92B2F0")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x92B474", Offset = "0x92B474", VA = "0x92B474")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x200011C")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000868")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x92B484", Offset = "0x92B484", VA = "0x92B484")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x92AB70", Offset = "0x92AB70", VA = "0x92AB70")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x92B4DC", Offset = "0x92B4DC", VA = "0x92B4DC")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x92B6F8", Offset = "0x92B6F8", VA = "0x92B6F8")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x200011D")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x92B700", Offset = "0x92B700", VA = "0x92B700")]
	private void Start()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x92BC60", Offset = "0x92BC60", VA = "0x92BC60")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x92BD0C", Offset = "0x92BD0C", VA = "0x92BD0C")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x92BF9C", Offset = "0x92BF9C", VA = "0x92BF9C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x92C070", Offset = "0x92C070", VA = "0x92C070")]
	private void Update()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x92C148", Offset = "0x92C148", VA = "0x92C148")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x92C1B0", Offset = "0x92C1B0", VA = "0x92C1B0")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x92C1B8", Offset = "0x92C1B8", VA = "0x92C1B8")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x92C220", Offset = "0x92C220", VA = "0x92C220")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x92C288", Offset = "0x92C288", VA = "0x92C288")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x92C2F0", Offset = "0x92C2F0", VA = "0x92C2F0")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x200011E")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x92C358", Offset = "0x92C358", VA = "0x92C358")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x200011F")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x92C360", Offset = "0x92C360", VA = "0x92C360")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x92C3F8", Offset = "0x92C3F8", VA = "0x92C3F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x92C4D0", Offset = "0x92C4D0", VA = "0x92C4D0")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x92C52C", Offset = "0x92C52C", VA = "0x92C52C")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x2000120")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x92C534", Offset = "0x92C534", VA = "0x92C534")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x2000121")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x2000122")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x92C944", Offset = "0x92C944", VA = "0x92C944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x92C98C", Offset = "0x92C98C", VA = "0x92C98C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x92C7E0", Offset = "0x92C7E0", VA = "0x92C7E0")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x92C810", Offset = "0x92C810", VA = "0x92C810", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x92C814", Offset = "0x92C814", VA = "0x92C814", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x92C94C", Offset = "0x92C94C", VA = "0x92C94C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x92C53C", Offset = "0x92C53C", VA = "0x92C53C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x92C648", Offset = "0x92C648", VA = "0x92C648")]
	private void Update()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x92C5D4", Offset = "0x92C5D4", VA = "0x92C5D4")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x92C808", Offset = "0x92C808", VA = "0x92C808")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x2000123")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x92C994", Offset = "0x92C994", VA = "0x92C994")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x92E33C", Offset = "0x92E33C", VA = "0x92E33C")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x2000124")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700007D")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x92E344", Offset = "0x92E344", VA = "0x92E344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x92E394", Offset = "0x92E394", VA = "0x92E394")]
	public void Start()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x92E7CC", Offset = "0x92E7CC", VA = "0x92E7CC")]
	public void Update()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x92E8A4", Offset = "0x92E8A4", VA = "0x92E8A4")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x60005B9")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60005BA")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x60005BB")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x60005BC")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x60005BD")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x60005BE")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x60005BF")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x60005C0")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x92E8FC", Offset = "0x92E8FC", VA = "0x92E8FC")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x92E93C", Offset = "0x92E93C", VA = "0x92E93C")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x92E9A8", Offset = "0x92E9A8", VA = "0x92E9A8")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x92EAF4", Offset = "0x92EAF4", VA = "0x92EAF4")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x92EBC4", Offset = "0x92EBC4", VA = "0x92EBC4")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x92E6A8", Offset = "0x92E6A8", VA = "0x92E6A8")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x92EC94", Offset = "0x92EC94", VA = "0x92EC94")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x92ECE0", Offset = "0x92ECE0", VA = "0x92ECE0")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x92EDF0", Offset = "0x92EDF0", VA = "0x92EDF0")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x2000125")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000126")]
	public enum DrawMode
	{
		[Token(Token = "0x4000897")]
		Opaque,
		[Token(Token = "0x4000898")]
		OpaqueWithClip,
		[Token(Token = "0x4000899")]
		TransparentDefaultAlpha,
		[Token(Token = "0x400089A")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700007E")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x930434", Offset = "0x930434", VA = "0x930434")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9304B8", Offset = "0x9304B8", VA = "0x9304B8")]
		set
		{
		}
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x92EDF8", Offset = "0x92EDF8", VA = "0x92EDF8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x92FABC", Offset = "0x92FABC", VA = "0x92FABC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x92FB30", Offset = "0x92FB30", VA = "0x92FB30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x92FC00", Offset = "0x92FC00", VA = "0x92FC00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x92FCD0", Offset = "0x92FCD0", VA = "0x92FCD0", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x92FED4", Offset = "0x92FED4", VA = "0x92FED4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x930574", Offset = "0x930574", VA = "0x930574")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x2000127")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x930630", Offset = "0x930630", VA = "0x930630")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x9309D0", Offset = "0x9309D0", VA = "0x9309D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x930B64", Offset = "0x930B64", VA = "0x930B64")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x930B6C", Offset = "0x930B6C", VA = "0x930B6C")]
	public void Release()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x930B54", Offset = "0x930B54", VA = "0x930B54")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x930B74", Offset = "0x930B74", VA = "0x930B74")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x2000128")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000129")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x9312BC", Offset = "0x9312BC", VA = "0x9312BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x931304", Offset = "0x931304", VA = "0x931304", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x931160", Offset = "0x931160", VA = "0x931160")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x9311B8", Offset = "0x9311B8", VA = "0x9311B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x9311BC", Offset = "0x9311BC", VA = "0x9311BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9312C4", Offset = "0x9312C4", VA = "0x9312C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012A")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x931488", Offset = "0x931488", VA = "0x931488", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x9314D0", Offset = "0x9314D0", VA = "0x9314D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x931188", Offset = "0x931188", VA = "0x931188")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x93130C", Offset = "0x93130C", VA = "0x93130C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x931310", Offset = "0x931310", VA = "0x931310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x931490", Offset = "0x931490", VA = "0x931490", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x930B7C", Offset = "0x930B7C", VA = "0x930B7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x930E5C", Offset = "0x930E5C", VA = "0x930E5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x930EAC", Offset = "0x930EAC", VA = "0x930EAC")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x931024", Offset = "0x931024", VA = "0x931024")]
	public void Release()
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x9310C8", Offset = "0x9310C8", VA = "0x9310C8")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x930F64", Offset = "0x930F64", VA = "0x930F64")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x9311B0", Offset = "0x9311B0", VA = "0x9311B0")]
	public BrushController()
	{
	}
}
[Token(Token = "0x200012B")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x9314D8", Offset = "0x9314D8", VA = "0x9314D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x93152C", Offset = "0x93152C", VA = "0x93152C")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x200012C")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x931534", Offset = "0x931534", VA = "0x931534")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x931708", Offset = "0x931708", VA = "0x931708")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x931798", Offset = "0x931798", VA = "0x931798")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x9317F4", Offset = "0x9317F4", VA = "0x9317F4")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x200012D")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x9329CC", Offset = "0x9329CC", VA = "0x9329CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x932A14", Offset = "0x932A14", VA = "0x932A14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x932734", Offset = "0x932734", VA = "0x932734")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x9327FC", Offset = "0x9327FC", VA = "0x9327FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x932800", Offset = "0x932800", VA = "0x932800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x9329D4", Offset = "0x9329D4", VA = "0x9329D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x9317FC", Offset = "0x9317FC", VA = "0x9317FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x931AE4", Offset = "0x931AE4", VA = "0x931AE4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x931DD0", Offset = "0x931DD0", VA = "0x931DD0")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x9320F8", Offset = "0x9320F8", VA = "0x9320F8")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x9323D0", Offset = "0x9323D0", VA = "0x9323D0")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x9324B8", Offset = "0x9324B8", VA = "0x9324B8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x932650", Offset = "0x932650", VA = "0x932650")]
	public void Release()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x9325A0", Offset = "0x9325A0", VA = "0x9325A0")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x93275C", Offset = "0x93275C", VA = "0x93275C")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x200012F")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x2000130")]
	public enum ManipulationType
	{
		[Token(Token = "0x40008CF")]
		Default,
		[Token(Token = "0x40008D0")]
		ForcedHand,
		[Token(Token = "0x40008D1")]
		DollyHand,
		[Token(Token = "0x40008D2")]
		DollyAttached,
		[Token(Token = "0x40008D3")]
		HorizontalScaled,
		[Token(Token = "0x40008D4")]
		VerticalScaled,
		[Token(Token = "0x40008D5")]
		Menu
	}

	[Token(Token = "0x2000131")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x2000132")]
	public delegate void ReleasedObject();

	[Token(Token = "0x2000133")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ObjectName;

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ObjectInstructions;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x932A1C", Offset = "0x932A1C", VA = "0x932A1C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x932A7C", Offset = "0x932A7C", VA = "0x932A7C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x932A98", Offset = "0x932A98", VA = "0x932A98")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x932AB4", Offset = "0x932AB4", VA = "0x932AB4")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x2000134")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int radialDivisions;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float borderSize;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fingerTaper;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fingerTipLength;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float webOffset;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x40008DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x932C1C", Offset = "0x932C1C", VA = "0x932C1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x932E7C", Offset = "0x932E7C", VA = "0x932E7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x933044", Offset = "0x933044", VA = "0x933044")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x933698", Offset = "0x933698", VA = "0x933698")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x933C30", Offset = "0x933C30", VA = "0x933C30")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x935F38", Offset = "0x935F38", VA = "0x935F38")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x9362AC", Offset = "0x9362AC", VA = "0x9362AC")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x2000135")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x9362D0", Offset = "0x9362D0", VA = "0x9362D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x936638", Offset = "0x936638", VA = "0x936638")]
	private void Update()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x93636C", Offset = "0x93636C", VA = "0x93636C")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x936AA0", Offset = "0x936AA0", VA = "0x936AA0")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x937010", Offset = "0x937010", VA = "0x937010")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x2000136")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000137")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x93989C", Offset = "0x93989C", VA = "0x93989C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x9398E4", Offset = "0x9398E4", VA = "0x9398E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x9391DC", Offset = "0x9391DC", VA = "0x9391DC")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x9395C4", Offset = "0x9395C4", VA = "0x9395C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x9395C8", Offset = "0x9395C8", VA = "0x9395C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x9398A4", Offset = "0x9398A4", VA = "0x9398A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x937020", Offset = "0x937020", VA = "0x937020")]
	private void Start()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x93721C", Offset = "0x93721C", VA = "0x93721C")]
	private void Update()
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x938148", Offset = "0x938148", VA = "0x938148")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x938EE0", Offset = "0x938EE0", VA = "0x938EE0")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x9371A8", Offset = "0x9371A8", VA = "0x9371A8")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x93746C", Offset = "0x93746C", VA = "0x93746C")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x938440", Offset = "0x938440", VA = "0x938440")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x939204", Offset = "0x939204", VA = "0x939204")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x9392B8", Offset = "0x9392B8", VA = "0x9392B8")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x9392E8", Offset = "0x9392E8", VA = "0x9392E8")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x9390C0", Offset = "0x9390C0", VA = "0x9390C0")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x9393D8", Offset = "0x9393D8", VA = "0x9393D8")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000138")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x9398EC", Offset = "0x9398EC", VA = "0x9398EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x939A58", Offset = "0x939A58", VA = "0x939A58")]
	private void Update()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x939B0C", Offset = "0x939B0C", VA = "0x939B0C")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000139")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x200013A")]
	public enum BrushState
	{
		[Token(Token = "0x4000912")]
		Idle,
		[Token(Token = "0x4000913")]
		Inking
	}

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x939B14", Offset = "0x939B14", VA = "0x939B14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x939B1C", Offset = "0x939B1C", VA = "0x939B1C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x939DCC", Offset = "0x939DCC", VA = "0x939DCC")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x93A000", Offset = "0x93A000", VA = "0x93A000")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x93A240", Offset = "0x93A240", VA = "0x93A240")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x939CE4", Offset = "0x939CE4", VA = "0x939CE4")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x93A310", Offset = "0x93A310", VA = "0x93A310")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x200013B")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x93A3AC", Offset = "0x93A3AC", VA = "0x93A3AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x93A518", Offset = "0x93A518", VA = "0x93A518")]
	private void Update()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x93A704", Offset = "0x93A704", VA = "0x93A704")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x200013C")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x93A70C", Offset = "0x93A70C", VA = "0x93A70C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x93A8F4", Offset = "0x93A8F4", VA = "0x93A8F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x93AA94", Offset = "0x93AA94", VA = "0x93AA94")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x200013D")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x200013E")]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x93B6F8", Offset = "0x93B6F8", VA = "0x93B6F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x93B740", Offset = "0x93B740", VA = "0x93B740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x93B460", Offset = "0x93B460", VA = "0x93B460")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x93B5A4", Offset = "0x93B5A4", VA = "0x93B5A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x93B5A8", Offset = "0x93B5A8", VA = "0x93B5A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x93B700", Offset = "0x93B700", VA = "0x93B700", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013F")]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x93B8B4", Offset = "0x93B8B4", VA = "0x93B8B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x93B8FC", Offset = "0x93B8FC", VA = "0x93B8FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x93B488", Offset = "0x93B488", VA = "0x93B488")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x93B748", Offset = "0x93B748", VA = "0x93B748", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x93B74C", Offset = "0x93B74C", VA = "0x93B74C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x93B8BC", Offset = "0x93B8BC", VA = "0x93B8BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x93AA9C", Offset = "0x93AA9C", VA = "0x93AA9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x93ADE4", Offset = "0x93ADE4", VA = "0x93ADE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x93B184", Offset = "0x93B184", VA = "0x93B184")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x93B2F8", Offset = "0x93B2F8", VA = "0x93B2F8")]
	public void Release()
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x93B274", Offset = "0x93B274", VA = "0x93B274")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x93B3DC", Offset = "0x93B3DC", VA = "0x93B3DC")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x93B4B0", Offset = "0x93B4B0", VA = "0x93B4B0")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x93B4D0", Offset = "0x93B4D0", VA = "0x93B4D0")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x93B4F0", Offset = "0x93B4F0", VA = "0x93B4F0")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x93AD7C", Offset = "0x93AD7C", VA = "0x93AD7C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x93B524", Offset = "0x93B524", VA = "0x93B524")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x93B530", Offset = "0x93B530", VA = "0x93B530")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x93ADFC", Offset = "0x93ADFC", VA = "0x93ADFC")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x93B53C", Offset = "0x93B53C", VA = "0x93B53C")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000140")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x93B904", Offset = "0x93B904", VA = "0x93B904")]
	private void Start()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x93B9B8", Offset = "0x93B9B8", VA = "0x93B9B8")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x2000141")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x93B9C0", Offset = "0x93B9C0", VA = "0x93B9C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x93BA2C", Offset = "0x93BA2C", VA = "0x93BA2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x93BD20", Offset = "0x93BD20", VA = "0x93BD20")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x2000142")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x93BD28", Offset = "0x93BD28", VA = "0x93BD28")]
	private void Update()
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x93C17C", Offset = "0x93C17C", VA = "0x93C17C")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x2000143")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x93C184", Offset = "0x93C184", VA = "0x93C184")]
	private void Start()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x93C3EC", Offset = "0x93C3EC", VA = "0x93C3EC")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x93C438", Offset = "0x93C438", VA = "0x93C438")]
	public void Release()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x93C478", Offset = "0x93C478", VA = "0x93C478")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x2000144")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x2000145")]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x93CB94", Offset = "0x93CB94", VA = "0x93CB94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x93CBDC", Offset = "0x93CBDC", VA = "0x93CBDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x93CA5C", Offset = "0x93CA5C", VA = "0x93CA5C")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x93CA9C", Offset = "0x93CA9C", VA = "0x93CA9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x93CAA0", Offset = "0x93CAA0", VA = "0x93CAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x93CB9C", Offset = "0x93CB9C", VA = "0x93CB9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x93C480", Offset = "0x93C480", VA = "0x93C480")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x93C4A4", Offset = "0x93C4A4", VA = "0x93C4A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x93C5AC", Offset = "0x93C5AC", VA = "0x93C5AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x93C650", Offset = "0x93C650", VA = "0x93C650")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x93C8A4", Offset = "0x93C8A4", VA = "0x93C8A4")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x93C948", Offset = "0x93C948", VA = "0x93C948")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x93C820", Offset = "0x93C820", VA = "0x93C820")]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x93CA84", Offset = "0x93CA84", VA = "0x93CA84")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x2000146")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x93CBE4", Offset = "0x93CBE4", VA = "0x93CBE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x93CEF4", Offset = "0x93CEF4", VA = "0x93CEF4")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x2000147")]
[RequireComponent(typeof(OVRSceneAnchor))]
[DefaultExecutionOrder(30)]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x93CEFC", Offset = "0x93CEFC", VA = "0x93CEFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x93D114", Offset = "0x93D114", VA = "0x93D114")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x93D584", Offset = "0x93D584", VA = "0x93D584")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x93CF9C", Offset = "0x93CF9C", VA = "0x93CF9C")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x93D7A4", Offset = "0x93D7A4", VA = "0x93D7A4")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x93DC90", Offset = "0x93DC90", VA = "0x93DC90")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x2000148")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x2000149")]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x93DEC4", Offset = "0x93DEC4", VA = "0x93DEC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x93DF0C", Offset = "0x93DF0C", VA = "0x93DF0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x93DD0C", Offset = "0x93DD0C", VA = "0x93DD0C")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x93DDC4", Offset = "0x93DDC4", VA = "0x93DDC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x93DDC8", Offset = "0x93DDC8", VA = "0x93DDC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x93DECC", Offset = "0x93DECC", VA = "0x93DECC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x93DC98", Offset = "0x93DC98", VA = "0x93DC98")]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x93DD34", Offset = "0x93DD34", VA = "0x93DD34", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x93DD54", Offset = "0x93DD54", VA = "0x93DD54", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x93DDBC", Offset = "0x93DDBC", VA = "0x93DDBC")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x200014A")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x93DF14", Offset = "0x93DF14", VA = "0x93DF14")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x200014B")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x400095E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x400095F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x93DF1C", Offset = "0x93DF1C", VA = "0x93DF1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x93DF94", Offset = "0x93DF94", VA = "0x93DF94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x93E018", Offset = "0x93E018", VA = "0x93E018")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x200014C")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x200014D")]
	public enum Method
	{
		[Token(Token = "0x400096F")]
		Adapt,
		[Token(Token = "0x4000970")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x4000971")]
		Scale,
		[Token(Token = "0x4000972")]
		None
	}

	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method ScalingX;

	[Token(Token = "0x4000961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x4000962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x4000963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Method ScalingY;

	[Token(Token = "0x4000964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x4000965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x4000966")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Method ScalingZ;

	[Token(Token = "0x4000967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x4000968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x4000969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 <NewSize>k__BackingField;

	[Token(Token = "0x400096A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 <DefaultSize>k__BackingField;

	[Token(Token = "0x400096B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh <Mesh>k__BackingField;

	[Token(Token = "0x400096C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x400096D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700008F")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x93E028", Offset = "0x93E028", VA = "0x93E028")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000090")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x93E044", Offset = "0x93E044", VA = "0x93E044")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x93E050", Offset = "0x93E050", VA = "0x93E050")]
		set
		{
		}
	}

	[Token(Token = "0x17000091")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x93E05C", Offset = "0x93E05C", VA = "0x93E05C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x93E068", Offset = "0x93E068", VA = "0x93E068")]
		private set
		{
		}
	}

	[Token(Token = "0x17000092")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x93E074", Offset = "0x93E074", VA = "0x93E074")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x93E07C", Offset = "0x93E07C", VA = "0x93E07C")]
		private set
		{
		}
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x93E084", Offset = "0x93E084", VA = "0x93E084")]
	private void Awake()
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x93E1C0", Offset = "0x93E1C0", VA = "0x93E1C0")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x200014E")]
public class SimpleResizer
{
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x93D8FC", Offset = "0x93D8FC", VA = "0x93D8FC")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x93E1C8", Offset = "0x93E1C8", VA = "0x93E1C8")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x93E44C", Offset = "0x93E44C", VA = "0x93E44C")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x93D8F4", Offset = "0x93D8F4", VA = "0x93D8F4")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x200014F")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x4000975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x93E4F4", Offset = "0x93E4F4", VA = "0x93E4F4", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x93E4F8", Offset = "0x93E4F8", VA = "0x93E4F8", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x93E960", Offset = "0x93E960", VA = "0x93E960")]
	public Spawnable()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x93E64C", Offset = "0x93E64C", VA = "0x93E64C")]
	internal static int <OnAfterDeserialize>g__IndexOf|4_0(string label, IEnumerable<string> collection)
	{
		return default(int);
	}
}
[Token(Token = "0x2000150")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x2000151")]
	public enum GeometryType
	{
		[Token(Token = "0x400097A")]
		Plane,
		[Token(Token = "0x400097B")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x2000152")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x4000976")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x4000977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x4000978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x93E9B8", Offset = "0x93E9B8", VA = "0x93E9B8")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x93EDE4", Offset = "0x93EDE4", VA = "0x93EDE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x93F71C", Offset = "0x93F71C", VA = "0x93F71C")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x93F5F4", Offset = "0x93F5F4", VA = "0x93F5F4")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x93F79C", Offset = "0x93F79C", VA = "0x93F79C")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x2000153")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x2000154")]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000094")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x940564", Offset = "0x940564", VA = "0x940564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x9405AC", Offset = "0x9405AC", VA = "0x9405AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x93F998", Offset = "0x93F998", VA = "0x93F998")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9403E8", Offset = "0x9403E8", VA = "0x9403E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9403EC", Offset = "0x9403EC", VA = "0x9403EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x94056C", Offset = "0x94056C", VA = "0x94056C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400097E")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x4000981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x4000982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x4000983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x4000985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x4000986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("labelImage_")]
	private Image _labelImage;

	[Token(Token = "0x4000987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("labelBaseColor_")]
	[SerializeField]
	private Color _labelBaseColor;

	[Token(Token = "0x4000988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x4000989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x400098A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x400098B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[FormerlySerializedAs("buttonList_")]
	[SerializeField]
	private List<Button> _buttonList;

	[Token(Token = "0x400098E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x400098F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000093")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x93FE44", Offset = "0x93FE44", VA = "0x93FE44")]
		set
		{
		}
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x93F7A4", Offset = "0x93F7A4", VA = "0x93F7A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x93F924", Offset = "0x93F924", VA = "0x93F924")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x93F9C0", Offset = "0x93F9C0", VA = "0x93F9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x93FC38", Offset = "0x93FC38", VA = "0x93FC38")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x93FD08", Offset = "0x93FD08", VA = "0x93FD08")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x93FD74", Offset = "0x93FD74", VA = "0x93FD74")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x93FE64", Offset = "0x93FE64", VA = "0x93FE64")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x93FF80", Offset = "0x93FF80", VA = "0x93FF80")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x940088", Offset = "0x940088", VA = "0x940088")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x93FA10", Offset = "0x93FA10", VA = "0x93FA10")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x93FB44", Offset = "0x93FB44", VA = "0x93FB44")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x940158", Offset = "0x940158", VA = "0x940158")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x940290", Offset = "0x940290", VA = "0x940290")]
	public Anchor()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x940298", Offset = "0x940298", VA = "0x940298")]
	private void <OnSaveLocalButtonPressed>b__22_0(OVRSpatialAnchor anchor, bool success)
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x9403BC", Offset = "0x9403BC", VA = "0x9403BC")]
	private void <OnEraseButtonPressed>b__24_0(OVRSpatialAnchor anchor, bool success)
	{
	}
}
[Token(Token = "0x2000155")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x2000156")]
	public enum AnchorMode
	{
		[Token(Token = "0x40009A7")]
		Create,
		[Token(Token = "0x40009A8")]
		Select
	}

	[Token(Token = "0x2000157")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("selectModeButton_")]
	[SerializeField]
	private GameObject _selectModeButton;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("trackedDevice_")]
	[SerializeField]
	private Transform _trackedDevice;

	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("lineRenderer_")]
	[SerializeField]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x400099D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x400099E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000096")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x9405B4", Offset = "0x9405B4", VA = "0x9405B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x9405BC", Offset = "0x9405BC", VA = "0x9405BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x940688", Offset = "0x940688", VA = "0x940688")]
	private void Start()
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x9407D8", Offset = "0x9407D8", VA = "0x9407D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x940C48", Offset = "0x940C48", VA = "0x940C48")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x940CB4", Offset = "0x940CB4", VA = "0x940CB4")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x940770", Offset = "0x940770", VA = "0x940770")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x940F3C", Offset = "0x940F3C", VA = "0x940F3C")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x940FC4", Offset = "0x940FC4", VA = "0x940FC4")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x940FE4", Offset = "0x940FE4", VA = "0x940FE4")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x940F1C", Offset = "0x940F1C", VA = "0x940F1C")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x940B54", Offset = "0x940B54", VA = "0x940B54")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x9411E4", Offset = "0x9411E4", VA = "0x9411E4")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x94106C", Offset = "0x94106C", VA = "0x94106C")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x941158", Offset = "0x941158", VA = "0x941158")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x9412E4", Offset = "0x9412E4", VA = "0x9412E4")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x941178", Offset = "0x941178", VA = "0x941178")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x9411B0", Offset = "0x9411B0", VA = "0x9411B0")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x9408D8", Offset = "0x9408D8", VA = "0x9408D8")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x9413D0", Offset = "0x9413D0", VA = "0x9413D0")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x9413F8", Offset = "0x9413F8", VA = "0x9413F8")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x941488", Offset = "0x941488", VA = "0x941488")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x9415D0", Offset = "0x9415D0", VA = "0x9415D0")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x2000158")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x940D08", Offset = "0x940D08", VA = "0x940D08")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x941760", Offset = "0x941760", VA = "0x941760")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x941680", Offset = "0x941680", VA = "0x941680")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x9417E4", Offset = "0x9417E4", VA = "0x9417E4")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x9415F4", Offset = "0x9415F4", VA = "0x9415F4")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x941994", Offset = "0x941994", VA = "0x941994")]
	public SpatialAnchorLoader()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x94199C", Offset = "0x94199C", VA = "0x94199C")]
	private void <Load>b__4_0(OVRSpatialAnchor.UnboundAnchor[] anchors)
	{
	}
}
[Token(Token = "0x2000159")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x200015A")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x941CD8", Offset = "0x941CD8", VA = "0x941CD8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x941DEC", Offset = "0x941DEC", VA = "0x941DEC")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x941ACC", Offset = "0x941ACC", VA = "0x941ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x941CE0", Offset = "0x941CE0", VA = "0x941CE0")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x941DE4", Offset = "0x941DE4", VA = "0x941DE4")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x200015B")]
public class LivingParticleArrayController : MonoBehaviour
{
	[Token(Token = "0x40009B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] affectors;

	[Token(Token = "0x40009B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector4[] positions;

	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x941E08", Offset = "0x941E08", VA = "0x941E08")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x941ECC", Offset = "0x941ECC", VA = "0x941ECC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x942038", Offset = "0x942038", VA = "0x942038")]
	public LivingParticleArrayController()
	{
	}
}
[Token(Token = "0x200015C")]
public class LivingParticleController : MonoBehaviour
{
	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform affector;

	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x942040", Offset = "0x942040", VA = "0x942040")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x942098", Offset = "0x942098", VA = "0x942098")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x942118", Offset = "0x942118", VA = "0x942118")]
	public LivingParticleController()
	{
	}
}
[Token(Token = "0x200015D")]
public class ParticleGridGenerator : MonoBehaviour
{
	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool rewriteVertexStreams;

	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float particleSize;

	[Token(Token = "0x40009B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color particleColor;

	[Token(Token = "0x40009B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 particleRotation3D;

	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool randomColorAlpha;

	[Token(Token = "0x40009BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float xDistance;

	[Token(Token = "0x40009BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float yDistance;

	[Token(Token = "0x40009BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float zDistance;

	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int xSize;

	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int ySize;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int zSize;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float OffsetEven;

	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool updateEveryFrame;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float even;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] positions;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem ps;

	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Vector4> customData;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<Vector4> customData2;

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x942120", Offset = "0x942120", VA = "0x942120")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x9422A4", Offset = "0x9422A4", VA = "0x9422A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x942180", Offset = "0x942180", VA = "0x942180")]
	public void UpdateGrid()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x942304", Offset = "0x942304", VA = "0x942304")]
	private void GenerateGrid()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x942440", Offset = "0x942440", VA = "0x942440")]
	private void GenerateParticles()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x942878", Offset = "0x942878", VA = "0x942878")]
	private void CreateOffsetVector()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x942958", Offset = "0x942958", VA = "0x942958")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x942968", Offset = "0x942968", VA = "0x942968")]
	public ParticleGridGenerator()
	{
	}
}
[Token(Token = "0x200015E")]
public class ParticleSystemRampGenerator : MonoBehaviour
{
	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient procedrualGradientRamp;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool procedrualGradientEnabled;

	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool updateEveryFrame;

	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer psr;

	[Token(Token = "0x40009CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Texture2D rampTexture;

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x942A60", Offset = "0x942A60", VA = "0x942A60")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x942B54", Offset = "0x942B54", VA = "0x942B54")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x942B6C", Offset = "0x942B6C", VA = "0x942B6C")]
	private Texture2D GenerateTextureFromGradient(Gradient grad)
	{
		return null;
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x942AD8", Offset = "0x942AD8", VA = "0x942AD8")]
	public void UpdateRampTexture()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x942C50", Offset = "0x942C50", VA = "0x942C50")]
	public ParticleSystemRampGenerator()
	{
	}
}
[Token(Token = "0x200015F")]
public class SuperSimpleMovement : MonoBehaviour
{
	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float movementSpeed;

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x942C58", Offset = "0x942C58", VA = "0x942C58")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x942D38", Offset = "0x942D38", VA = "0x942D38")]
	public SuperSimpleMovement()
	{
	}
}
[Token(Token = "0x2000160")]
public class UIController : MonoBehaviour
{
	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light directionalLight;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ReflectionProbe reflectionProbe;

	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material daySkyboxMaterial;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material nightSkyboxMaterial;

	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform prefabHolder;

	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text text;

	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform[] prefabs;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<Transform> lt;

	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int activeNumber;

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x942D48", Offset = "0x942D48", VA = "0x942D48")]
	private void Start()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x942F6C", Offset = "0x942F6C", VA = "0x942F6C")]
	public void EnableActive()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x943044", Offset = "0x943044", VA = "0x943044")]
	public void ChangeEffect(bool bo)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x9430A0", Offset = "0x9430A0", VA = "0x9430A0")]
	public void SetDay()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x9430E0", Offset = "0x9430E0", VA = "0x9430E0")]
	public void SetNight()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x943120", Offset = "0x943120", VA = "0x943120")]
	private void Update()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x94319C", Offset = "0x94319C", VA = "0x94319C")]
	public UIController()
	{
	}
}
[Token(Token = "0x2000161")]
public class MenuToggle : MonoBehaviour
{
	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Canvas CanvasObject;

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x9431A4", Offset = "0x9431A4", VA = "0x9431A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x9431FC", Offset = "0x9431FC", VA = "0x9431FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x943264", Offset = "0x943264", VA = "0x943264")]
	public MenuToggle()
	{
	}
}
[Token(Token = "0x2000162")]
public class SimpleSmoothMouseLook : MonoBehaviour
{
	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x40009DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool lockCursor;

	[Token(Token = "0x40009DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 sensitivity;

	[Token(Token = "0x40009DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 smoothing;

	[Token(Token = "0x40009DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 targetDirection;

	[Token(Token = "0x40009DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x40009E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject characterBody;

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x94326C", Offset = "0x94326C", VA = "0x94326C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x943358", Offset = "0x943358", VA = "0x943358")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x943850", Offset = "0x943850", VA = "0x943850")]
	public SimpleSmoothMouseLook()
	{
	}
}
[Token(Token = "0x2000163")]
public class SkyboxChanger : MonoBehaviour
{
	[Token(Token = "0x40009E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] Skyboxes;

	[Token(Token = "0x40009E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dropdown _dropdown;

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x943870", Offset = "0x943870", VA = "0x943870")]
	public void Awake()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x9438C8", Offset = "0x9438C8", VA = "0x9438C8")]
	public void ChangeSkybox()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x943908", Offset = "0x943908", VA = "0x943908")]
	public SkyboxChanger()
	{
	}
}
[Token(Token = "0x2000164")]
public class CameraToTexture : MonoBehaviour
{
	[Token(Token = "0x2000165")]
	private sealed class <SaveCameraView>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CameraToTexture <>4__this;

		[Token(Token = "0x17000097")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x943AE8", Offset = "0x943AE8", VA = "0x943AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x943B30", Offset = "0x943B30", VA = "0x943B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x9439C4", Offset = "0x9439C4", VA = "0x9439C4")]
		[DebuggerHidden]
		public <SaveCameraView>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x9439FC", Offset = "0x9439FC", VA = "0x9439FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x943A00", Offset = "0x943A00", VA = "0x943A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x943AF0", Offset = "0x943AF0", VA = "0x943AF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40009E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTexture securityCameraTexture;

	[Token(Token = "0x40009E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera securityCamera;

	[Token(Token = "0x40009E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int finished;

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x943910", Offset = "0x943910", VA = "0x943910")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x943950", Offset = "0x943950", VA = "0x943950")]
	public IEnumerator SaveCameraView()
	{
		return null;
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x9439EC", Offset = "0x9439EC", VA = "0x9439EC")]
	public CameraToTexture()
	{
	}
}
[Token(Token = "0x2000166")]
public class ExitContinue : MonoBehaviour
{
	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_Agrement;

	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool m_Accepted;

	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game m_Game;

	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_MainButtons;

	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_ProgramButtons;

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x943B38", Offset = "0x943B38", VA = "0x943B38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x943C88", Offset = "0x943C88", VA = "0x943C88")]
	public void OnExit()
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x943D1C", Offset = "0x943D1C", VA = "0x943D1C")]
	public void OnContinue()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x943E54", Offset = "0x943E54", VA = "0x943E54")]
	public void OnSkip()
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x943FD0", Offset = "0x943FD0", VA = "0x943FD0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x94405C", Offset = "0x94405C", VA = "0x94405C")]
	public ExitContinue()
	{
	}
}
[Token(Token = "0x2000167")]
public class FlatCounter : MonoBehaviour
{
	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] m_Digits;

	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer[] m_Adds;

	[Token(Token = "0x40009F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Count;

	[Token(Token = "0x40009F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_AlarmValue;

	[Token(Token = "0x40009F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color m_Color;

	[Token(Token = "0x40009F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color m_AlarmColor;

	[Token(Token = "0x40009F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_PrevCount;

	[Token(Token = "0x40009F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_SetColor;

	[Token(Token = "0x40009F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool m_Align;

	[Token(Token = "0x40009F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string m_PerfName;

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color m_HighlightColor;

	[Token(Token = "0x40009FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_HighlightProgress;

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x944064", Offset = "0x944064", VA = "0x944064")]
	private void Start()
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x94422C", Offset = "0x94422C", VA = "0x94422C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x94451C", Offset = "0x94451C", VA = "0x94451C")]
	private void UpdateAlarm()
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x944100", Offset = "0x944100", VA = "0x944100")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x9445AC", Offset = "0x9445AC", VA = "0x9445AC")]
	public FlatCounter()
	{
	}
}
[Token(Token = "0x2000168")]
public class Interactive : MonoBehaviour
{
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x9445C8", Offset = "0x9445C8", VA = "0x9445C8")]
	public Interactive()
	{
	}
}
[Token(Token = "0x2000169")]
public class Item : Interactive
{
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x9445D0", Offset = "0x9445D0", VA = "0x9445D0")]
	public Item()
	{
	}
}
[Token(Token = "0x200016A")]
public class LODTile : MonoBehaviour
{
	[Token(Token = "0x40009FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Cart;

	[Token(Token = "0x40009FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] m_Segments;

	[Token(Token = "0x40009FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float[] m_ActivateDist;

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x9445D8", Offset = "0x9445D8", VA = "0x9445D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x9447AC", Offset = "0x9447AC", VA = "0x9447AC")]
	public LODTile()
	{
	}
}
[Token(Token = "0x200016B")]
public class MegaSphere : MonoBehaviour
{
	[Token(Token = "0x40009FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40009FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Cubemap m_Cubemap;

	[Token(Token = "0x4000A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x4000A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool m_WorkInGame;

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x9447B4", Offset = "0x9447B4", VA = "0x9447B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x944834", Offset = "0x944834", VA = "0x944834")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x944838", Offset = "0x944838", VA = "0x944838")]
	private void SaveTextures()
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x944B20", Offset = "0x944B20", VA = "0x944B20")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x945DC0", Offset = "0x945DC0", VA = "0x945DC0")]
	private void CalculateNormals(Vector3[] vertices, ref Vector3[] normals, int no_tris)
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x945864", Offset = "0x945864", VA = "0x945864")]
	private void Trim(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x9459B0", Offset = "0x9459B0", VA = "0x9459B0")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x945C38", Offset = "0x945C38", VA = "0x945C38")]
	private void Pump(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x94535C", Offset = "0x94535C", VA = "0x94535C")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x944E44", Offset = "0x944E44", VA = "0x944E44")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x946494", Offset = "0x946494", VA = "0x946494")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x94651C", Offset = "0x94651C", VA = "0x94651C")]
	public MegaSphere()
	{
	}
}
[Token(Token = "0x200016C")]
public class MeshCombinator : MonoBehaviour
{
	[Token(Token = "0x4000A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x4000A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Meshes;

	[Token(Token = "0x4000A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string m_OutName;

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x94652C", Offset = "0x94652C", VA = "0x94652C")]
	private void Update()
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x94653C", Offset = "0x94653C", VA = "0x94653C")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x946540", Offset = "0x946540", VA = "0x946540")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x946954", Offset = "0x946954", VA = "0x946954")]
	private void CombineMesh(ref Mesh mesh, MeshFilter[] meshes)
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x946B34", Offset = "0x946B34", VA = "0x946B34")]
	private void CopyMesh(MeshFilter[] meshes, ref Vector3[] vertices, ref Vector3[] normals, ref Vector2[] uv)
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x946F00", Offset = "0x946F00", VA = "0x946F00")]
	private int CountTris(MeshFilter[] meshes)
	{
		return default(int);
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x94703C", Offset = "0x94703C", VA = "0x94703C")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x94726C", Offset = "0x94726C", VA = "0x94726C")]
	public MeshCombinator()
	{
	}
}
[Token(Token = "0x200016D")]
public class Metronom : MonoBehaviour
{
	[Token(Token = "0x4000A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x4000A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip m_Clip;

	[Token(Token = "0x4000A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x4000A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_BeatIDx;

	[Token(Token = "0x4000A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_BeatTime;

	[Token(Token = "0x4000A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_Divider;

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x94727C", Offset = "0x94727C", VA = "0x94727C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x947348", Offset = "0x947348", VA = "0x947348")]
	private void Update()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x947478", Offset = "0x947478", VA = "0x947478")]
	public Metronom()
	{
	}
}
[Token(Token = "0x200016E")]
public class MockupMaker : MonoBehaviour
{
	[Token(Token = "0x4000A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_ToTrim;

	[Token(Token = "0x4000A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Decoration;

	[Token(Token = "0x4000A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Mockup;

	[Token(Token = "0x4000A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Bound;

	[Token(Token = "0x4000A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform m_VROrientation;

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x947488", Offset = "0x947488", VA = "0x947488")]
	private void Start()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x947CAC", Offset = "0x947CAC", VA = "0x947CAC")]
	public void Show()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x947EC0", Offset = "0x947EC0", VA = "0x947EC0")]
	public void Hide()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x947590", Offset = "0x947590", VA = "0x947590")]
	private void GenerateSegments(MeshFilter[] meshes, MeshFilter[] segments)
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x947F7C", Offset = "0x947F7C", VA = "0x947F7C")]
	private Mesh TrimMesh(MeshFilter mf)
	{
		return null;
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x948254", Offset = "0x948254", VA = "0x948254")]
	public MockupMaker()
	{
	}
}
[Token(Token = "0x200016F")]
public class PanoramaMaker : MonoBehaviour
{
	[Token(Token = "0x4000A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Cubemap m_Cubemap;

	[Token(Token = "0x4000A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoFramesToGenerate;

	[Token(Token = "0x4000A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Meshes;

	[Token(Token = "0x4000A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string m_OutName;

	[Token(Token = "0x4000A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform[] m_Planes;

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x94825C", Offset = "0x94825C", VA = "0x94825C")]
	private void Update()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x94826C", Offset = "0x94826C", VA = "0x94826C")]
	private void PrepareMesh()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x948270", Offset = "0x948270", VA = "0x948270")]
	private void SaveTextures()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x9485E4", Offset = "0x9485E4", VA = "0x9485E4")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x9491B8", Offset = "0x9491B8", VA = "0x9491B8")]
	private void CutMesh(ref Vector3[] vertices, ref int no_tris)
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x949C74", Offset = "0x949C74", VA = "0x949C74")]
	private void SliceTraingle(ref Vector3[] vertices, ref int no_tris, int idx)
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x948A2C", Offset = "0x948A2C", VA = "0x948A2C")]
	private void CopyMesh(ref Mesh mesh, MeshFilter[] meshes)
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x94A3F8", Offset = "0x94A3F8", VA = "0x94A3F8")]
	private int CountTris(MeshFilter[] meshes)
	{
		return default(int);
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x9495A0", Offset = "0x9495A0", VA = "0x9495A0")]
	private void CalculateNormals(Vector3[] vertices, ref Vector3[] normals, int no_tris)
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x948C0C", Offset = "0x948C0C", VA = "0x948C0C")]
	private void Trim(ref Vector3[] vertices, ref int no_tris)
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x949370", Offset = "0x949370", VA = "0x949370")]
	private void CalcualeUVS(ref Vector3[] vertices, ref Vector2[] uv, int no_tris)
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x94A534", Offset = "0x94A534", VA = "0x94A534")]
	private void Pump(ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x94A6BC", Offset = "0x94A6BC", VA = "0x94A6BC")]
	private void Divide(ref Vector3[] vertices, ref int[] tris, ref int no_tris)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x94ABC4", Offset = "0x94ABC4", VA = "0x94ABC4")]
	private void GenerateBox(ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x94B0DC", Offset = "0x94B0DC", VA = "0x94B0DC")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x94B164", Offset = "0x94B164", VA = "0x94B164")]
	public PanoramaMaker()
	{
	}
}
[Serializable]
[Token(Token = "0x2000170")]
public class GameEvent
{
	[Token(Token = "0x4000A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int source_id;

	[Token(Token = "0x4000A19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frame;

	[Token(Token = "0x4000A1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000A1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 v3_param;

	[Token(Token = "0x4000A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int i_param;

	[Token(Token = "0x4000A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int i_param2;

	[Token(Token = "0x4000A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool was_played;

	[Token(Token = "0x4000A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rejcected;

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x94B174", Offset = "0x94B174", VA = "0x94B174")]
	public GameEvent()
	{
	}
}
[Token(Token = "0x2000171")]
public class Recorder : MonoBehaviour
{
	[Token(Token = "0x4000A20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x4000A21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_PrevFrame;

	[Token(Token = "0x4000A22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_SourceID;

	[Token(Token = "0x4000A23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_Record;

	[Token(Token = "0x4000A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool m_Smooth;

	[Token(Token = "0x4000A25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool m_Copy;

	[Token(Token = "0x4000A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool m_RecordTransform;

	[Token(Token = "0x4000A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameEvent> m_Events;

	[Token(Token = "0x4000A28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] m_RecordingPos;

	[Token(Token = "0x4000A29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Quaternion[] m_RecordingRot;

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x94B17C", Offset = "0x94B17C", VA = "0x94B17C")]
	public void Copy(ref Recorder reference)
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x94B1F8", Offset = "0x94B1F8", VA = "0x94B1F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x94B40C", Offset = "0x94B40C", VA = "0x94B40C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x94B564", Offset = "0x94B564", VA = "0x94B564")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x94B638", Offset = "0x94B638", VA = "0x94B638")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x94B6BC", Offset = "0x94B6BC", VA = "0x94B6BC")]
	public void Play()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x94B748", Offset = "0x94B748", VA = "0x94B748")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x94BA20", Offset = "0x94BA20", VA = "0x94BA20")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x94BA28", Offset = "0x94BA28", VA = "0x94BA28")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x94BA40", Offset = "0x94BA40", VA = "0x94BA40")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x94BA58", Offset = "0x94BA58", VA = "0x94BA58")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int i_param2, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x94BC44", Offset = "0x94BC44", VA = "0x94BC44")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x94BE0C", Offset = "0x94BE0C", VA = "0x94BE0C")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x94BFA8", Offset = "0x94BFA8", VA = "0x94BFA8")]
	private void Update()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x94B4D0", Offset = "0x94B4D0", VA = "0x94B4D0")]
	public int GetCurrFrame()
	{
		return default(int);
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x94C290", Offset = "0x94C290", VA = "0x94C290")]
	private float GetDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x94BFC4", Offset = "0x94BFC4", VA = "0x94BFC4")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x94C090", Offset = "0x94C090", VA = "0x94C090")]
	private void PlayFrame()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x94C2F8", Offset = "0x94C2F8", VA = "0x94C2F8")]
	public Recorder()
	{
	}
}
[Token(Token = "0x2000172")]
public class Remaper2D : MonoBehaviour
{
	[Token(Token = "0x4000A2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshFilter m_MeshFilter;

	[Token(Token = "0x4000A2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool XZ;

	[Token(Token = "0x4000A2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_OutName;

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x94C394", Offset = "0x94C394", VA = "0x94C394")]
	private void Start()
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x94C5E4", Offset = "0x94C5E4", VA = "0x94C5E4")]
	public Remaper2D()
	{
	}
}
[Token(Token = "0x2000173")]
public class Selector : MonoBehaviour
{
	[Token(Token = "0x4000A2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x4000A2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_MinNoSelected;

	[Token(Token = "0x4000A2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_MaxNoSelected;

	[Token(Token = "0x4000A30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoSelected;

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x94C5EC", Offset = "0x94C5EC", VA = "0x94C5EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x94CA00", Offset = "0x94CA00", VA = "0x94CA00")]
	public Selector()
	{
	}
}
[Token(Token = "0x2000174")]
public class SpeedSim : MonoBehaviour
{
	[Token(Token = "0x4000A31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 m_CurrSpeed;

	[Token(Token = "0x4000A32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 m_PosMod;

	[Token(Token = "0x4000A33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 m_Translate;

	[Token(Token = "0x4000A34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 m_PerlinShift;

	[Token(Token = "0x4000A35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 m_PerlinFreq;

	[Token(Token = "0x4000A36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject m_CenterObj;

	[Token(Token = "0x4000A37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float m_TimeShift;

	[Token(Token = "0x4000A38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4000A39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Game m_Game;

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x94CA10", Offset = "0x94CA10", VA = "0x94CA10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x94CAB8", Offset = "0x94CAB8", VA = "0x94CAB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x94CF74", Offset = "0x94CF74", VA = "0x94CF74")]
	public SpeedSim()
	{
	}
}
[Token(Token = "0x2000175")]
public class SteamLeaderboardManager : MonoBehaviour
{
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x94D08C", Offset = "0x94D08C", VA = "0x94D08C")]
	public SteamLeaderboardManager()
	{
	}
}
[Token(Token = "0x2000176")]
public class TActivator : MonoBehaviour
{
	[Token(Token = "0x4000A3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x94D094", Offset = "0x94D094", VA = "0x94D094")]
	private void Start()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x94D0F8", Offset = "0x94D0F8", VA = "0x94D0F8")]
	public TActivator()
	{
	}
}
[Token(Token = "0x2000177")]
public class TimeDestroyer : MonoBehaviour
{
	[Token(Token = "0x4000A3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_TimeOut;

	[Token(Token = "0x4000A3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool m_DetachChildren;

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x94D100", Offset = "0x94D100", VA = "0x94D100")]
	private void Start()
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x94D150", Offset = "0x94D150", VA = "0x94D150")]
	private void DestroyNow()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x94D1E0", Offset = "0x94D1E0", VA = "0x94D1E0")]
	public TimeDestroyer()
	{
	}
}
[Token(Token = "0x2000178")]
public class Tools
{
	[Token(Token = "0x4000A3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int m_Seed;

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x94D1F0", Offset = "0x94D1F0", VA = "0x94D1F0")]
	public static bool CollTriangleVSSection(Vector3 t1, Vector3 t2, Vector3 t3, Vector3 p1, Vector3 p2, ref Vector3 coll_p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x94C914", Offset = "0x94C914", VA = "0x94C914")]
	public static float GetRandom(int seed, int idx)
	{
		return default(float);
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x94C7F8", Offset = "0x94C7F8", VA = "0x94C7F8")]
	public static int GetRandomIDX(int seed, int idx, int max)
	{
		return default(int);
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x94D45C", Offset = "0x94D45C", VA = "0x94D45C")]
	public static float CosFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x94D4A0", Offset = "0x94D4A0", VA = "0x94D4A0")]
	public static float Mod01(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x94CF60", Offset = "0x94CF60", VA = "0x94CF60")]
	public static float Mod(float val, float mod)
	{
		return default(float);
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x94D4AC", Offset = "0x94D4AC", VA = "0x94D4AC")]
	public static AudioClip GetRandomAudio(string name, int no_samples = 3)
	{
		return null;
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x94D5BC", Offset = "0x94D5BC", VA = "0x94D5BC")]
	public static float GetFloat(string key, float defValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x94D5C4", Offset = "0x94D5C4", VA = "0x94D5C4")]
	public static int GetInt(string key, int defValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x94D5CC", Offset = "0x94D5CC", VA = "0x94D5CC")]
	public static string GetString(string key, string defValue = "")
	{
		return null;
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x94D5D4", Offset = "0x94D5D4", VA = "0x94D5D4")]
	public static void SetFloat(string key, float value)
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x94D5DC", Offset = "0x94D5DC", VA = "0x94D5DC")]
	public static void SetInt(string key, int value)
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x94D5E4", Offset = "0x94D5E4", VA = "0x94D5E4")]
	public static void SetString(string key, string value)
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x94D5EC", Offset = "0x94D5EC", VA = "0x94D5EC")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x94D5F4", Offset = "0x94D5F4", VA = "0x94D5F4")]
	public static void Save()
	{
	}
}
[Token(Token = "0x2000179")]
public class TurnFaceToCamera : MonoBehaviour
{
	[Token(Token = "0x4000A3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_StabilizePos;

	[Token(Token = "0x4000A3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_StabilizeXRot;

	[Token(Token = "0x4000A40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_StabilizeRot;

	[Token(Token = "0x4000A41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR m_VR;

	[Token(Token = "0x4000A42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 m_BaseShift;

	[Token(Token = "0x4000A43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Parent;

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x94D648", Offset = "0x94D648", VA = "0x94D648")]
	private void Start()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x94D6C0", Offset = "0x94D6C0", VA = "0x94D6C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x94DA64", Offset = "0x94DA64", VA = "0x94DA64")]
	public TurnFaceToCamera()
	{
	}
}
[Token(Token = "0x200017A")]
public class UVAnimator : MonoBehaviour
{
	[Token(Token = "0x4000A44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material m_Material;

	[Token(Token = "0x4000A45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 m_Speed;

	[Token(Token = "0x4000A46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float time;

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x94DAD0", Offset = "0x94DAD0", VA = "0x94DAD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x94DB4C", Offset = "0x94DB4C", VA = "0x94DB4C")]
	public UVAnimator()
	{
	}
}
[Token(Token = "0x200017B")]
public class VRKeyboard : MonoBehaviour
{
	[Token(Token = "0x4000A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] ButtonLists;

	[Token(Token = "0x4000A48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Output;

	[Token(Token = "0x4000A49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource m_ClickSFX;

	[Token(Token = "0x4000A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool CapsLock;

	[Token(Token = "0x4000A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string EditedText;

	[Token(Token = "0x4000A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string EditedStringName;

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x94DB54", Offset = "0x94DB54", VA = "0x94DB54")]
	public void Show(string edited_string_name)
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x94DC38", Offset = "0x94DC38", VA = "0x94DC38")]
	public void OnButtonDown(string letter)
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x94DD50", Offset = "0x94DD50", VA = "0x94DD50")]
	public void OnCapsLock()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x94DE08", Offset = "0x94DE08", VA = "0x94DE08")]
	public void OnClear()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x94DE7C", Offset = "0x94DE7C", VA = "0x94DE7C")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x94DEE8", Offset = "0x94DEE8", VA = "0x94DEE8")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x94DF70", Offset = "0x94DF70", VA = "0x94DF70")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x94DCC0", Offset = "0x94DCC0", VA = "0x94DCC0")]
	private void PlayClick()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x94DFA0", Offset = "0x94DFA0", VA = "0x94DFA0")]
	public VRKeyboard()
	{
	}
}
[Token(Token = "0x200017C")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x4000A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float ROTATE_SPEED;

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x94E010", Offset = "0x94E010", VA = "0x94E010")]
	private void Start()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x94E03C", Offset = "0x94E03C", VA = "0x94E03C")]
	private void Update()
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x94E0E0", Offset = "0x94E0E0", VA = "0x94E0E0")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x200017D")]
public class PressedBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x4000A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button btn;

	[Token(Token = "0x4000A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform myIcon;

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x94E0F0", Offset = "0x94E0F0", VA = "0x94E0F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x94E1A4", Offset = "0x94E1A4", VA = "0x94E1A4")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x94E264", Offset = "0x94E264", VA = "0x94E264")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x94E338", Offset = "0x94E338", VA = "0x94E338", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x94E33C", Offset = "0x94E33C", VA = "0x94E33C", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x94E340", Offset = "0x94E340", VA = "0x94E340", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x94E344", Offset = "0x94E344", VA = "0x94E344", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x94E348", Offset = "0x94E348", VA = "0x94E348")]
	public PressedBtn()
	{
	}
}
[Token(Token = "0x200017E")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x4000A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x94E350", Offset = "0x94E350", VA = "0x94E350")]
	private void Start()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x94E3A8", Offset = "0x94E3A8", VA = "0x94E3A8")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0x94E4C0", Offset = "0x94E4C0", VA = "0x94E4C0")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x200017F")]
public class handanimations : MonoBehaviour
{
	[Token(Token = "0x4000A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ViveController;

	[Token(Token = "0x4000A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject OculusController;

	[Token(Token = "0x4000A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject StickUp;

	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject StickFront;

	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator anim;

	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int Idle;

	[Token(Token = "0x4000A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int Point;

	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int GrabLarge;

	[Token(Token = "0x4000A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int GrabSmall;

	[Token(Token = "0x4000A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int GrabStickUp;

	[Token(Token = "0x4000A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int GrabStickFront;

	[Token(Token = "0x4000A5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int ThumbUp;

	[Token(Token = "0x4000A5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int Fist;

	[Token(Token = "0x4000A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int Gun;

	[Token(Token = "0x4000A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int GunShoot;

	[Token(Token = "0x4000A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int PushButton;

	[Token(Token = "0x4000A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int Spread;

	[Token(Token = "0x4000A62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int MiddleFinger;

	[Token(Token = "0x4000A63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int Peace;

	[Token(Token = "0x4000A64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int OK;

	[Token(Token = "0x4000A65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int Phone;

	[Token(Token = "0x4000A66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int Rock;

	[Token(Token = "0x4000A67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int Natural;

	[Token(Token = "0x4000A68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int Number3;

	[Token(Token = "0x4000A69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int Number4;

	[Token(Token = "0x4000A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int Number3V2;

	[Token(Token = "0x4000A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int HoldViveController;

	[Token(Token = "0x4000A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int PressTriggerViveController;

	[Token(Token = "0x4000A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int HoldOculusController;

	[Token(Token = "0x4000A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int PressTriggerOculusController;

	[Token(Token = "0x600078B")]
	[Address(RVA = "0x94E4C8", Offset = "0x94E4C8", VA = "0x94E4C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x94E578", Offset = "0x94E578", VA = "0x94E578")]
	private void Update()
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x94E9EC", Offset = "0x94E9EC", VA = "0x94E9EC")]
	public handanimations()
	{
	}
}
[Token(Token = "0x2000180")]
internal class AnimateSpriteSheet : MonoBehaviour
{
	[Token(Token = "0x2000181")]
	private sealed class <UpdateTiling>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateSpriteSheet <>4__this;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <y>5__2;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 <offset>5__3;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__4;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <j>5__5;

		[Token(Token = "0x1700009A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x94F1A4", Offset = "0x94F1A4", VA = "0x94F1A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x94F1EC", Offset = "0x94F1EC", VA = "0x94F1EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x94EF94", Offset = "0x94EF94", VA = "0x94EF94")]
		[DebuggerHidden]
		public <UpdateTiling>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x94EFDC", Offset = "0x94EFDC", VA = "0x94EFDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x94EFE0", Offset = "0x94EFE0", VA = "0x94EFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x94F1AC", Offset = "0x94F1AC", VA = "0x94F1AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Columns;

	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Rows;

	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float FramesPerSecond;

	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool RunOnce;

	[Token(Token = "0x4000A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material materialCopy;

	[Token(Token = "0x17000099")]
	public float RunTimeInSeconds
	{
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x94EDC4", Offset = "0x94EDC4", VA = "0x94EDC4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x94EDE4", Offset = "0x94EDE4", VA = "0x94EDE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x94EF00", Offset = "0x94EF00", VA = "0x94EF00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x94EF20", Offset = "0x94EF20", VA = "0x94EF20")]
	private IEnumerator UpdateTiling()
	{
		return null;
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x94EFBC", Offset = "0x94EFBC", VA = "0x94EFBC")]
	public AnimateSpriteSheet()
	{
	}
}
[Token(Token = "0x2000182")]
public class Turn_Move : MonoBehaviour
{
	[Token(Token = "0x4000A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TurnX;

	[Token(Token = "0x4000A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int TurnY;

	[Token(Token = "0x4000A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int TurnZ;

	[Token(Token = "0x4000A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int MoveX;

	[Token(Token = "0x4000A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int MoveY;

	[Token(Token = "0x4000A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int MoveZ;

	[Token(Token = "0x4000A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool World;

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x94F1F4", Offset = "0x94F1F4", VA = "0x94F1F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x94F378", Offset = "0x94F378", VA = "0x94F378")]
	public Turn_Move()
	{
	}
}
[Token(Token = "0x2000183")]
public class DoorHori : MonoBehaviour
{
	[Token(Token = "0x2000184")]
	private sealed class <WaitToClose>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DoorHori <>4__this;

		[Token(Token = "0x1700009C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x94FE68", Offset = "0x94FE68", VA = "0x94FE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x94FEB0", Offset = "0x94FEB0", VA = "0x94FEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x94FC44", Offset = "0x94FC44", VA = "0x94FC44")]
		[DebuggerHidden]
		public <WaitToClose>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x94FC74", Offset = "0x94FC74", VA = "0x94FC74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x94FC78", Offset = "0x94FC78", VA = "0x94FC78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x94FE70", Offset = "0x94FE70", VA = "0x94FE70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float translateValue;

	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float easeTime;

	[Token(Token = "0x4000A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OTween.EaseType ease;

	[Token(Token = "0x4000A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float waitTime;

	[Token(Token = "0x4000A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 StartlocalPos;

	[Token(Token = "0x4000A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 endlocalPos;

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x94F380", Offset = "0x94F380", VA = "0x94F380")]
	private void Start()
	{
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x94F3C8", Offset = "0x94F3C8", VA = "0x94F3C8")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x94FA88", Offset = "0x94FA88", VA = "0x94FA88")]
	private void UpdateOpenDoor(float f)
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x94FB10", Offset = "0x94FB10", VA = "0x94FB10")]
	private void UpdateCloseDoor(float f)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x94FB8C", Offset = "0x94FB8C", VA = "0x94FB8C")]
	private void EndOpen()
	{
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x94FBD0", Offset = "0x94FBD0", VA = "0x94FBD0")]
	private IEnumerator WaitToClose()
	{
		return null;
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x94FC6C", Offset = "0x94FC6C", VA = "0x94FC6C")]
	public DoorHori()
	{
	}
}
[Token(Token = "0x2000185")]
public class DoorVert : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	private sealed class <WaitToClose>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DoorVert <>4__this;

		[Token(Token = "0x1700009E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x950454", Offset = "0x950454", VA = "0x950454", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x95049C", Offset = "0x95049C", VA = "0x95049C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x950230", Offset = "0x950230", VA = "0x950230")]
		[DebuggerHidden]
		public <WaitToClose>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x950260", Offset = "0x950260", VA = "0x950260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x950264", Offset = "0x950264", VA = "0x950264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x95045C", Offset = "0x95045C", VA = "0x95045C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float translateValue;

	[Token(Token = "0x4000A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float easeTime;

	[Token(Token = "0x4000A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OTween.EaseType ease;

	[Token(Token = "0x4000A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float waitTime;

	[Token(Token = "0x4000A8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 StartlocalPos;

	[Token(Token = "0x4000A90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 endlocalPos;

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x94FEB8", Offset = "0x94FEB8", VA = "0x94FEB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x94FF00", Offset = "0x94FF00", VA = "0x94FF00")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x950074", Offset = "0x950074", VA = "0x950074")]
	private void UpdateOpenDoor(float f)
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x9500FC", Offset = "0x9500FC", VA = "0x9500FC")]
	private void UpdateCloseDoor(float f)
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x950178", Offset = "0x950178", VA = "0x950178")]
	private void EndOpen()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x9501BC", Offset = "0x9501BC", VA = "0x9501BC")]
	private IEnumerator WaitToClose()
	{
		return null;
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x950258", Offset = "0x950258", VA = "0x950258")]
	public DoorVert()
	{
	}
}
[Token(Token = "0x2000187")]
public class HDRColorChange : MonoBehaviour
{
	[Token(Token = "0x4000A94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color colorStart;

	[Token(Token = "0x4000A95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer rend;

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x9504A4", Offset = "0x9504A4", VA = "0x9504A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x950584", Offset = "0x950584", VA = "0x950584")]
	public HDRColorChange()
	{
	}
}
[Token(Token = "0x2000188")]
public class HoriDoorManager : MonoBehaviour
{
	[Token(Token = "0x4000A96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DoorHori door1;

	[Token(Token = "0x4000A97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DoorHori door2;

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x950594", Offset = "0x950594", VA = "0x950594")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x950648", Offset = "0x950648", VA = "0x950648")]
	public HoriDoorManager()
	{
	}
}
[Token(Token = "0x2000189")]
public class OTween : MonoBehaviour
{
	[Token(Token = "0x200018A")]
	public enum EaseType
	{
		[Token(Token = "0x4000AAB")]
		Linear,
		[Token(Token = "0x4000AAC")]
		CubicIn,
		[Token(Token = "0x4000AAD")]
		CubicOut,
		[Token(Token = "0x4000AAE")]
		BounceIn,
		[Token(Token = "0x4000AAF")]
		BounceOut,
		[Token(Token = "0x4000AB0")]
		ElasticIn,
		[Token(Token = "0x4000AB1")]
		ElasticOut
	}

	[Token(Token = "0x200018B")]
	private enum VariableType
	{
		[Token(Token = "0x4000AB3")]
		Float,
		[Token(Token = "0x4000AB4")]
		V3,
		[Token(Token = "0x4000AB5")]
		V2
	}

	[Token(Token = "0x200018C")]
	private sealed class <LaunchEase>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OTween <>4__this;

		[Token(Token = "0x170000A0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x951754", Offset = "0x951754", VA = "0x951754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x95179C", Offset = "0x95179C", VA = "0x95179C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x950ECC", Offset = "0x950ECC", VA = "0x950ECC")]
		[DebuggerHidden]
		public <LaunchEase>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x95165C", Offset = "0x95165C", VA = "0x95165C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x951660", Offset = "0x951660", VA = "0x951660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x95175C", Offset = "0x95175C", VA = "0x95175C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018D")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string tweenId;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x9513EC", Offset = "0x9513EC", VA = "0x9513EC")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x9517A4", Offset = "0x9517A4", VA = "0x9517A4")]
		internal bool <UpdateEndValue>b__0(OTween t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000A98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EaseType easeType;

	[Token(Token = "0x4000A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float delayToStart;

	[Token(Token = "0x4000A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float duration;

	[Token(Token = "0x4000A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool isStart;

	[Token(Token = "0x4000A9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string startCallBack;

	[Token(Token = "0x4000A9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string updateCallBack;

	[Token(Token = "0x4000AA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string endCallBack;

	[Token(Token = "0x4000AA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float startValue1;

	[Token(Token = "0x4000AA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float startValue2;

	[Token(Token = "0x4000AA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float startValue3;

	[Token(Token = "0x4000AA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float endValue1;

	[Token(Token = "0x4000AA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float endValue2;

	[Token(Token = "0x4000AA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float endValue3;

	[Token(Token = "0x4000AA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float startTime;

	[Token(Token = "0x4000AA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private VariableType variableType;

	[Token(Token = "0x4000AA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<OTween> tweens;

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x950650", Offset = "0x950650", VA = "0x950650")]
	private void Update()
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x950874", Offset = "0x950874", VA = "0x950874")]
	private float UpdateTween(float start, float end, float time)
	{
		return default(float);
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x950A6C", Offset = "0x950A6C", VA = "0x950A6C")]
	private void SendUpdate(float v1, float v2, float v3)
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x950E58", Offset = "0x950E58", VA = "0x950E58")]
	private IEnumerator LaunchEase()
	{
		return null;
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x950BA0", Offset = "0x950BA0", VA = "0x950BA0")]
	private float Linear(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x950BB4", Offset = "0x950BB4", VA = "0x950BB4")]
	private float BounceIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x950BE8", Offset = "0x950BE8", VA = "0x950BE8")]
	private float BounceOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x950CB4", Offset = "0x950CB4", VA = "0x950CB4")]
	private float CubicIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x950CD0", Offset = "0x950CD0", VA = "0x950CD0")]
	private float CubicOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x950CFC", Offset = "0x950CFC", VA = "0x950CFC")]
	private float ElasticIn(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x950DAC", Offset = "0x950DAC", VA = "0x950DAC")]
	private float ElasticOut(float t, float start, float end, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x950EF4", Offset = "0x950EF4", VA = "0x950EF4")]
	private void StartEase()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x94F53C", Offset = "0x94F53C", VA = "0x94F53C")]
	public static string ValueTo(GameObject obj, EaseType easeType, object startValue, object endValue, float duration, float delaytToStart = 0f, string startCallBack = "", string updateCallBack = "", string endCallBack = "")
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x950F40", Offset = "0x950F40", VA = "0x950F40")]
	public static void UpdateEndValue(string tweenId, object endValue)
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x9513F4", Offset = "0x9513F4", VA = "0x9513F4")]
	public static void StopTween(GameObject obj)
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x9515BC", Offset = "0x9515BC", VA = "0x9515BC")]
	public OTween()
	{
	}
}
[Token(Token = "0x200018E")]
[RequireComponent(typeof(AudioSource))]
public class ParticleSound : MonoBehaviour
{
	[Token(Token = "0x4000ABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip OnBirthSound;

	[Token(Token = "0x4000ABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem emitter;

	[Token(Token = "0x4000ABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int particleNum;

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x9517C8", Offset = "0x9517C8", VA = "0x9517C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x951870", Offset = "0x951870", VA = "0x951870")]
	public ParticleSound()
	{
	}
}
[Token(Token = "0x200018F")]
public class VertDoorManager : MonoBehaviour
{
	[Token(Token = "0x4000ABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DoorVert door1;

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x951878", Offset = "0x951878", VA = "0x951878")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x9518F8", Offset = "0x9518F8", VA = "0x9518F8")]
	public VertDoorManager()
	{
	}
}
namespace NeuralNetwork
{
	[Token(Token = "0x2000190")]
	public class NeuralNet
	{
		[Token(Token = "0x2000191")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] inputs;

			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x953C48", Offset = "0x953C48", VA = "0x953C48")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x953E90", Offset = "0x953E90", VA = "0x953E90")]
			internal void <ForwardPropagate>b__0(Neuron a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000192")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Neuron> <>9__31_2;

			[Token(Token = "0x4000AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<Neuron> <>9__31_1;

			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<Neuron> <>9__32_2;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Neuron, float> <>9__33_0;

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x953F44", Offset = "0x953F44", VA = "0x953F44")]
			public <>c()
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x953F4C", Offset = "0x953F4C", VA = "0x953F4C")]
			internal void <ForwardPropagate>b__31_2(Neuron a)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x953F6C", Offset = "0x953F6C", VA = "0x953F6C")]
			internal void <ForwardPropagate>b__31_1(Neuron a)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x953F8C", Offset = "0x953F8C", VA = "0x953F8C")]
			internal void <BackPropagate>b__32_2(Neuron a)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x954114", Offset = "0x954114", VA = "0x954114")]
			internal float <Compute>b__33_0(Neuron a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000193")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] targets;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NeuralNet <>4__this;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Neuron> <>9__3;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x953C50", Offset = "0x953C50", VA = "0x953C50")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x95412C", Offset = "0x95412C", VA = "0x95412C")]
			internal void <BackPropagate>b__0(Neuron a)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x9541C8", Offset = "0x9541C8", VA = "0x9541C8")]
			internal void <BackPropagate>b__3(Neuron a)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x95439C", Offset = "0x95439C", VA = "0x95439C")]
			internal void <BackPropagate>b__1(Neuron a)
			{
			}
		}

		[Token(Token = "0x2000194")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] targets;

			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x953D88", Offset = "0x953D88", VA = "0x953D88")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x9543C8", Offset = "0x9543C8", VA = "0x9543C8")]
			internal float <CalculateError>b__0(Neuron a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float <LearnRate>k__BackingField;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <Momentum>k__BackingField;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <LearnRateFactor>k__BackingField;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Neuron> <InputLayer>k__BackingField;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<List<Neuron>> <HiddenLayers>k__BackingField;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Neuron> <OutputLayer>k__BackingField;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random Random;

		[Token(Token = "0x170000A2")]
		public float LearnRate
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x951900", Offset = "0x951900", VA = "0x951900")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x951908", Offset = "0x951908", VA = "0x951908")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public float Momentum
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x951910", Offset = "0x951910", VA = "0x951910")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x951918", Offset = "0x951918", VA = "0x951918")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float LearnRateFactor
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x951920", Offset = "0x951920", VA = "0x951920")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x951928", Offset = "0x951928", VA = "0x951928")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public List<Neuron> InputLayer
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x951930", Offset = "0x951930", VA = "0x951930")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x951938", Offset = "0x951938", VA = "0x951938")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public List<List<Neuron>> HiddenLayers
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x951940", Offset = "0x951940", VA = "0x951940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x951948", Offset = "0x951948", VA = "0x951948")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public List<Neuron> OutputLayer
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x951950", Offset = "0x951950", VA = "0x951950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x951958", Offset = "0x951958", VA = "0x951958")]
			set
			{
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x951960", Offset = "0x951960", VA = "0x951960")]
		public void Store(ref List<float> weights)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x951CF8", Offset = "0x951CF8", VA = "0x951CF8")]
		public void Restore(ref List<float> weights)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x95200C", Offset = "0x95200C", VA = "0x95200C")]
		public NeuralNet(bool const_hidden_size, int input_size, int hidden_size, int output_size, int num_hidden_layers = 1, [Optional] float? learn_rate, [Optional] float? momentum)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x952A1C", Offset = "0x952A1C", VA = "0x952A1C")]
		public float CalcError(List<DataSet> dataSets)
		{
			return default(float);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x95313C", Offset = "0x95313C", VA = "0x95313C")]
		public void Train(List<DataSet> dataSets, float min_error, int number_of_eppoch)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x952CCC", Offset = "0x952CCC", VA = "0x952CCC")]
		private void ForwardPropagate(params float[] inputs)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x953670", Offset = "0x953670", VA = "0x953670")]
		private void BackPropagate(params float[] targets)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x953C58", Offset = "0x953C58", VA = "0x953C58")]
		public float[] Compute(params float[] inputs)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x953050", Offset = "0x953050", VA = "0x953050")]
		private float CalculateError(params float[] targets)
		{
			return default(float);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x953D90", Offset = "0x953D90", VA = "0x953D90")]
		public static float GetRandom()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000195")]
	public class Neuron
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Synapse, float> <>9__26_0;

			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Synapse, float> <>9__28_0;

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x954734", Offset = "0x954734", VA = "0x954734")]
			public <>c()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x95473C", Offset = "0x95473C", VA = "0x95473C")]
			internal float <CalculateValue>b__26_0(Synapse a)
			{
				return default(float);
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x954764", Offset = "0x954764", VA = "0x954764")]
			internal float <CalculateGradient>b__28_0(Synapse a)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Synapse> <InputSynapses>k__BackingField;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Synapse> <OutputSynapses>k__BackingField;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <Bias>k__BackingField;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <BiasDelta>k__BackingField;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <Gradient>k__BackingField;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <Value>k__BackingField;

		[Token(Token = "0x170000A8")]
		public List<Synapse> InputSynapses
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x95441C", Offset = "0x95441C", VA = "0x95441C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x954424", Offset = "0x954424", VA = "0x954424")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public List<Synapse> OutputSynapses
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x95442C", Offset = "0x95442C", VA = "0x95442C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x954434", Offset = "0x954434", VA = "0x954434")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float Bias
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x95443C", Offset = "0x95443C", VA = "0x95443C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x954444", Offset = "0x954444", VA = "0x954444")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float BiasDelta
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x95444C", Offset = "0x95444C", VA = "0x95444C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x954454", Offset = "0x954454", VA = "0x954454")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public float Gradient
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x95445C", Offset = "0x95445C", VA = "0x95445C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x954464", Offset = "0x954464", VA = "0x954464")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float Value
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x95446C", Offset = "0x95446C", VA = "0x95446C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x954474", Offset = "0x954474", VA = "0x954474")]
			set
			{
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x95250C", Offset = "0x95250C", VA = "0x95250C")]
		public Neuron()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x9525F4", Offset = "0x9525F4", VA = "0x9525F4")]
		public Neuron(IEnumerable<Neuron> inputNeurons)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x954510", Offset = "0x954510", VA = "0x954510", Slot = "4")]
		public virtual float CalculateValue()
		{
			return default(float);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x954410", Offset = "0x954410", VA = "0x954410")]
		public float CalculateError(float target)
		{
			return default(float);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x953FA4", Offset = "0x953FA4", VA = "0x953FA4")]
		public float CalculateGradient([Optional] float? target)
		{
			return default(float);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x9541F4", Offset = "0x9541F4", VA = "0x9541F4")]
		public void UpdateWeights(float learnRate, float momentum)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x951AE8", Offset = "0x951AE8", VA = "0x951AE8")]
		public void Store(ref List<float> weights)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x951E80", Offset = "0x951E80", VA = "0x951E80")]
		public void Restore(ref List<float> weights)
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class Synapse
	{
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Neuron <InputNeuron>k__BackingField;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Neuron <OutputNeuron>k__BackingField;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <Weight>k__BackingField;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <WeightDelta>k__BackingField;

		[Token(Token = "0x170000AE")]
		public Neuron InputNeuron
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x95478C", Offset = "0x95478C", VA = "0x95478C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x954794", Offset = "0x954794", VA = "0x954794")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Neuron OutputNeuron
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x95479C", Offset = "0x95479C", VA = "0x95479C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x9547A4", Offset = "0x9547A4", VA = "0x9547A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public float Weight
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x9547AC", Offset = "0x9547AC", VA = "0x9547AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x9547B4", Offset = "0x9547B4", VA = "0x9547B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public float WeightDelta
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x9547BC", Offset = "0x9547BC", VA = "0x9547BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x9547C4", Offset = "0x9547C4", VA = "0x9547C4")]
			set
			{
			}
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x95447C", Offset = "0x95447C", VA = "0x95447C")]
		public Synapse(Neuron inputNeuron, Neuron outputNeuron)
		{
		}
	}
	[Token(Token = "0x2000198")]
	public static class Sigmoid
	{
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x954664", Offset = "0x954664", VA = "0x954664")]
		public static float Output(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x9546B4", Offset = "0x9546B4", VA = "0x9546B4")]
		public static float Derivative(float x)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000199")]
	public class DataSet
	{
		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] <Inputs>k__BackingField;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] <Outputs>k__BackingField;

		[Token(Token = "0x170000B2")]
		public float[] Inputs
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x9547CC", Offset = "0x9547CC", VA = "0x9547CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x9547D4", Offset = "0x9547D4", VA = "0x9547D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float[] Outputs
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x9547DC", Offset = "0x9547DC", VA = "0x9547DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x9547E4", Offset = "0x9547E4", VA = "0x9547E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x9547EC", Offset = "0x9547EC", VA = "0x9547EC")]
		public DataSet(float[] inputs, float[] outputs)
		{
		}
	}
}
namespace DSPLib
{
	[Token(Token = "0x200019A")]
	public class FFT
	{
		[Token(Token = "0x200019B")]
		private class FFTElement
		{
			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public double re;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double im;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FFTElement next;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint revTgt;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x954B08", Offset = "0x954B08", VA = "0x954B08")]
			public FFTElement()
			{
			}
		}

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double mFFTScale;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint mLogN;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint mN;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint mLengthTotal;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private uint mLengthHalf;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FFTElement[] mX;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x954830", Offset = "0x954830", VA = "0x954830")]
		public FFT()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x954840", Offset = "0x954840", VA = "0x954840")]
		public void Initialize(uint inputDataLength, uint zeroPaddingLength = 0u)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x954B34", Offset = "0x954B34", VA = "0x954B34")]
		public Complex[] Execute(double[] timeSeries)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x954B10", Offset = "0x954B10", VA = "0x954B10")]
		private uint BitReverse(uint x, uint numBits)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x200019C")]
	public class DSP
	{
		[Token(Token = "0x200019D")]
		public static class Window
		{
			[Token(Token = "0x200019E")]
			public enum Type
			{
				[Token(Token = "0x4000AEC")]
				None,
				[Token(Token = "0x4000AED")]
				Rectangular,
				[Token(Token = "0x4000AEE")]
				Welch,
				[Token(Token = "0x4000AEF")]
				Bartlett,
				[Token(Token = "0x4000AF0")]
				Hanning,
				[Token(Token = "0x4000AF1")]
				Hann,
				[Token(Token = "0x4000AF2")]
				Hamming,
				[Token(Token = "0x4000AF3")]
				Nutall3,
				[Token(Token = "0x4000AF4")]
				Nutall4,
				[Token(Token = "0x4000AF5")]
				Nutall3A,
				[Token(Token = "0x4000AF6")]
				Nutall3B,
				[Token(Token = "0x4000AF7")]
				Nutall4A,
				[Token(Token = "0x4000AF8")]
				BH92,
				[Token(Token = "0x4000AF9")]
				Nutall4B,
				[Token(Token = "0x4000AFA")]
				SFT3F,
				[Token(Token = "0x4000AFB")]
				SFT3M,
				[Token(Token = "0x4000AFC")]
				FTNI,
				[Token(Token = "0x4000AFD")]
				SFT4F,
				[Token(Token = "0x4000AFE")]
				SFT5F,
				[Token(Token = "0x4000AFF")]
				SFT4M,
				[Token(Token = "0x4000B00")]
				FTHP,
				[Token(Token = "0x4000B01")]
				HFT70,
				[Token(Token = "0x4000B02")]
				FTSRS,
				[Token(Token = "0x4000B03")]
				SFT5M,
				[Token(Token = "0x4000B04")]
				HFT90D,
				[Token(Token = "0x4000B05")]
				HFT95,
				[Token(Token = "0x4000B06")]
				HFT116D,
				[Token(Token = "0x4000B07")]
				HFT144D,
				[Token(Token = "0x4000B08")]
				HFT169D,
				[Token(Token = "0x4000B09")]
				HFT196D,
				[Token(Token = "0x4000B0A")]
				HFT223D,
				[Token(Token = "0x4000B0B")]
				HFT248D
			}

			[Token(Token = "0x200019F")]
			public static class ScaleFactor
			{
				[Token(Token = "0x600082A")]
				[Address(RVA = "0x9557E0", Offset = "0x9557E0", VA = "0x9557E0")]
				public static double Signal(double[] windowCoefficients)
				{
					return default(double);
				}
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x954E78", Offset = "0x954E78", VA = "0x954E78")]
			public static double[] Coefficients(Type windowName, uint points)
			{
				return null;
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x955514", Offset = "0x955514", VA = "0x955514")]
			private static double[] SineExpansion(uint points, double c0, double c1 = 0.0, double c2 = 0.0, double c3 = 0.0, double c4 = 0.0, double c5 = 0.0, double c6 = 0.0, double c7 = 0.0, double c8 = 0.0, double c9 = 0.0, double c10 = 0.0)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A0")]
		public static class ConvertComplex
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x955850", Offset = "0x955850", VA = "0x955850")]
			public static double[] ToMagnitude(Complex[] rawFFT)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A1")]
		public static class Math
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x955974", Offset = "0x955974", VA = "0x955974")]
			public static double[] Multiply(double[] a, double[] b)
			{
				return null;
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x955A38", Offset = "0x955A38", VA = "0x955A38")]
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
	[Token(Token = "0x20001A2")]
	public struct Complex : IEquatable<Complex>, IFormattable
	{
		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double m_real;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private double m_imaginary;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Complex Zero;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Complex One;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Complex ImaginaryOne;

		[Token(Token = "0x170000B4")]
		public double Real
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x955AEC", Offset = "0x955AEC", VA = "0x955AEC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B5")]
		public double Magnitude
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x955910", Offset = "0x955910", VA = "0x955910")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x954E70", Offset = "0x954E70", VA = "0x954E70")]
		public Complex(double real, double imaginary)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x955AF4", Offset = "0x955AF4", VA = "0x955AF4")]
		public static double Abs(Complex value)
		{
			return default(double);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x955C5C", Offset = "0x955C5C", VA = "0x955C5C")]
		public static bool operator ==(Complex left, Complex right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x955C74", Offset = "0x955C74", VA = "0x955C74", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x955D30", Offset = "0x955D30", VA = "0x955D30", Slot = "4")]
		public bool Equals(Complex value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x955D74", Offset = "0x955D74", VA = "0x955D74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x955E4C", Offset = "0x955E4C", VA = "0x955E4C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x955EDC", Offset = "0x955EDC", VA = "0x955EDC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RhythmTool
{
	[Token(Token = "0x20001A3")]
	public abstract class Analysis : MonoBehaviour
	{
		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int <frameSize>k__BackingField;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <hopSize>k__BackingField;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int <frameIndex>k__BackingField;

		[Token(Token = "0x170000B6")]
		public Track track
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x956044", Offset = "0x956044", VA = "0x956044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public int sampleRate
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x956050", Offset = "0x956050", VA = "0x956050")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x956058", Offset = "0x956058", VA = "0x956058")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int frameSize
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x956060", Offset = "0x956060", VA = "0x956060")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x956068", Offset = "0x956068", VA = "0x956068")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public int hopSize
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x956070", Offset = "0x956070", VA = "0x956070")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x956078", Offset = "0x956078", VA = "0x956078")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public new abstract string name
		{
			[Token(Token = "0x6000840")]
			get;
		}

		[Token(Token = "0x170000BB")]
		protected int frameIndex
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x956080", Offset = "0x956080", VA = "0x956080")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x956088", Offset = "0x956088", VA = "0x956088")]
			private set
			{
			}
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x956090", Offset = "0x956090", VA = "0x956090", Slot = "5")]
		public virtual void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x95609C", Offset = "0x95609C", VA = "0x95609C", Slot = "6")]
		public virtual void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x9560A4", Offset = "0x9560A4", VA = "0x9560A4")]
		protected float FrameIndexToSeconds(float frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000846")]
		protected abstract Track GetTrack();

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x9560C0", Offset = "0x9560C0", VA = "0x9560C0")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	[ExecuteInEditMode]
	public abstract class Analysis<T> : Analysis where T : Feature
	{
		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Track<T> <track>k__BackingField;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toAdd;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toRemove;

		[Token(Token = "0x170000BC")]
		public new Track<T> track
		{
			[Token(Token = "0x6000848")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			private set
			{
			}
		}

		[Token(Token = "0x600084A")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x600084B")]
		protected sealed override Track GetTrack()
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		protected void AddFeature(T feature)
		{
		}

		[Token(Token = "0x600084D")]
		protected void RemoveFeature(T feature)
		{
		}

		[Token(Token = "0x600084E")]
		private void Update()
		{
		}

		[Token(Token = "0x600084F")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class BeatTrack : Track<Beat>
	{
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x9560C8", Offset = "0x9560C8", VA = "0x9560C8")]
		public BeatTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A6")]
	public class Beat : Feature
	{
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float bpm;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x956134", Offset = "0x956134", VA = "0x956134")]
		public Beat()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[DisallowMultipleComponent]
	public class BeatTracker : Analysis<Beat>
	{
		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] signalBuffer;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] signal;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] smoothedSignal;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] autoCorrelation;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] combFilter;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] lengthScore;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] offsetScore;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] signalWindow;

		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] offsetWindow;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] kernel;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] prevMagnitude;

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float prevSpectralFlux;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int maxBeatLength;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int minBeatLength;

		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int beatLength;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int prevBeatLength;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int beatOffset;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int updateOffset;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int bufferSize;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int resolution;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int combElements;

		[Token(Token = "0x170000BD")]
		public override string name
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x956144", Offset = "0x956144", VA = "0x956144", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x956184", Offset = "0x956184", VA = "0x956184", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x95665C", Offset = "0x95665C", VA = "0x95665C", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x9567B4", Offset = "0x9567B4", VA = "0x9567B4")]
		private float GetSample(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x956868", Offset = "0x956868", VA = "0x956868")]
		private void UpdateSignal()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x956BA4", Offset = "0x956BA4", VA = "0x956BA4")]
		private void UpdateOffset()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x9569E4", Offset = "0x9569E4", VA = "0x9569E4")]
		private void UpdateLength()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x956FEC", Offset = "0x956FEC", VA = "0x956FEC")]
		private void UpdateAutoCorrelation()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x957170", Offset = "0x957170", VA = "0x957170")]
		private void UpdateLengthScore()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x95733C", Offset = "0x95733C", VA = "0x95733C")]
		public BeatTracker()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public static class Bindings<T>
	{
		[Token(Token = "0x20001A9")]
		private delegate T ObjectActivator(params object[] args);

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, ObjectActivator> bindings;

		[Token(Token = "0x600085C")]
		public static T GetBinding(params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x600085D")]
		private static ObjectActivator GetCachedActivator(Type type)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		private static ObjectActivator GetActivator(ConstructorInfo ctor)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		private static Type GetBindingType(Type featureType)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		private static ConstructorInfo GetConstructor(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AA")]
	public class Chromagram : Analysis<Chroma>
	{
		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int startNote;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int endNote;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int downsampleFactor;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int chromaInterval;

		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] noteIndices;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] downsampled;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] spectrum;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] magnitude;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] window;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] pitchWindow;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] pitch;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] chroma;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int offset;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[] chromaHistory;

		[Token(Token = "0x170000BE")]
		public override string name
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x957390", Offset = "0x957390", VA = "0x957390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x9573D0", Offset = "0x9573D0", VA = "0x9573D0", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x9577E0", Offset = "0x9577E0", VA = "0x9577E0", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x957824", Offset = "0x957824", VA = "0x957824")]
		private void Downsample(float[] samples)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x95794C", Offset = "0x95794C", VA = "0x95794C")]
		private void UpdateChroma()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x9576F8", Offset = "0x9576F8", VA = "0x9576F8")]
		private static int FrequencyToIndex(float frequency, int length, int samplerate)
		{
			return default(int);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x9576CC", Offset = "0x9576CC", VA = "0x9576CC")]
		private static float GetMidiFrequency(int index)
		{
			return default(float);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x957DC4", Offset = "0x957DC4", VA = "0x957DC4")]
		public Chromagram()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class ChromaTrack : Track<Chroma>
	{
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x957E20", Offset = "0x957E20", VA = "0x957E20")]
		public ChromaTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AC")]
	public class Chroma : Feature
	{
		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Note note;

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x957DBC", Offset = "0x957DBC", VA = "0x957DBC")]
		public Chroma()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public enum Note
	{
		[Token(Token = "0x4000B40")]
		A,
		[Token(Token = "0x4000B41")]
		ASharp,
		[Token(Token = "0x4000B42")]
		B,
		[Token(Token = "0x4000B43")]
		C,
		[Token(Token = "0x4000B44")]
		CSHARP,
		[Token(Token = "0x4000B45")]
		D,
		[Token(Token = "0x4000B46")]
		DSHARP,
		[Token(Token = "0x4000B47")]
		E,
		[Token(Token = "0x4000B48")]
		F,
		[Token(Token = "0x4000B49")]
		FSHARP,
		[Token(Token = "0x4000B4A")]
		G,
		[Token(Token = "0x4000B4B")]
		GSHARP
	}
	[Token(Token = "0x20001AE")]
	[RequireComponent(typeof(RhythmPlayer))]
	public class DebugDrawer : MonoBehaviour
	{
		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RhythmPlayer <rhythmPlayer>k__BackingField;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float width;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float height;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float padding;

		[Token(Token = "0x170000BF")]
		public RhythmPlayer rhythmPlayer
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x957E8C", Offset = "0x957E8C", VA = "0x957E8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x957E94", Offset = "0x957E94", VA = "0x957E94")]
			private set
			{
			}
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x957E9C", Offset = "0x957E9C", VA = "0x957E9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x957EF4", Offset = "0x957EF4", VA = "0x957EF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x9586A0", Offset = "0x9586A0", VA = "0x9586A0")]
		public DebugDrawer()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public abstract class TrackDrawer
	{
		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, TrackDrawer> trackDrawers;

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x958398", Offset = "0x958398", VA = "0x958398")]
		public static void Draw(Track track, Rect rect, float start, float end)
		{
		}

		[Token(Token = "0x6000874")]
		protected abstract void DrawTrack(Track track, Rect rect, float start, float end);

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x9586BC", Offset = "0x9586BC", VA = "0x9586BC")]
		public static TrackDrawer GetTrackDrawer(Track track)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B0")]
	public class Feature
	{
		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timestamp;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float length;

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x95613C", Offset = "0x95613C", VA = "0x95613C")]
		public Feature()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class LomontFFT
	{
		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] cosTable;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] sinTable;

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x958904", Offset = "0x958904", VA = "0x958904")]
		public void FFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x958D84", Offset = "0x958D84", VA = "0x958D84")]
		public void RealFFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x958E30", Offset = "0x958E30", VA = "0x958E30")]
		private void Reconstruct(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x958BF0", Offset = "0x958BF0", VA = "0x958BF0")]
		private void InitializeTables(int length)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x958B60", Offset = "0x958B60", VA = "0x958B60")]
		private static void BitReverse(float[] data)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x958FD4", Offset = "0x958FD4", VA = "0x958FD4")]
		private static void Swap(float[] data, int a, int b)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x959014", Offset = "0x959014", VA = "0x959014")]
		public LomontFFT()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class OnsetDetector : Analysis<Onset>
	{
		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float normalization;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float threshold;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(2f, 32f)]
		public int bufferSize;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int start;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int end;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mean;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m2;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] prevMagnitude;

		[Token(Token = "0x170000C0")]
		public override string name
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x95901C", Offset = "0x95901C", VA = "0x95901C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x95905C", Offset = "0x95905C", VA = "0x95905C", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x959130", Offset = "0x959130", VA = "0x959130", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x9592FC", Offset = "0x9592FC", VA = "0x9592FC")]
		private float SpectralDifference(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x9593B0", Offset = "0x9593B0", VA = "0x9593B0")]
		private float Normalize(float sample)
		{
			return default(float);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x95942C", Offset = "0x95942C", VA = "0x95942C")]
		public OnsetDetector()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class OnsetTrack : Track<Onset>
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x959490", Offset = "0x959490", VA = "0x959490")]
		public OnsetTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B4")]
	public class Onset : Feature
	{
		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float strength;

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x959424", Offset = "0x959424", VA = "0x959424")]
		public Onset()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	[ExecuteInEditMode]
	public class RhythmAnalyzer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B6")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Analysis> <>9__41_0;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Analysis, Track> <>9__41_1;

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x95A3B0", Offset = "0x95A3B0", VA = "0x95A3B0")]
			public <>c()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x95A3B8", Offset = "0x95A3B8", VA = "0x95A3B8")]
			internal bool <Initialize>b__41_0(Analysis a)
			{
				return default(bool);
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x95A3E0", Offset = "0x95A3E0", VA = "0x95A3E0")]
			internal Track <Initialize>b__41_1(Analysis a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RhythmData <rhythmData>k__BackingField;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <progress>k__BackingField;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool <isDone>k__BackingField;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool <initialized>k__BackingField;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioClip audioClip;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int hopSize;

		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int frameSize;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int bufferCount;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int channels;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int sampleRate;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int totalFrames;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastFrame;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] window;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] samples;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] monoSamples;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] spectrum;

		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] magnitude;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Thread analyze;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AutoResetEvent waitForMainThread;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool getData;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool abort;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int initialLength;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Analysis> analyses;

		[Token(Token = "0x170000C1")]
		public RhythmData rhythmData
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x95965C", Offset = "0x95965C", VA = "0x95965C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x959664", Offset = "0x959664", VA = "0x959664")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public float progress
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x95966C", Offset = "0x95966C", VA = "0x95966C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x959674", Offset = "0x959674", VA = "0x959674")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public bool isDone
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x95967C", Offset = "0x95967C", VA = "0x95967C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x959684", Offset = "0x959684", VA = "0x959684")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool initialized
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x959690", Offset = "0x959690", VA = "0x959690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x959698", Offset = "0x959698", VA = "0x959698")]
			private set
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<RhythmData> Initialized
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x9594FC", Offset = "0x9594FC", VA = "0x9594FC")]
			add
			{
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x9595AC", Offset = "0x9595AC", VA = "0x9595AC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x9596A4", Offset = "0x9596A4", VA = "0x9596A4")]
		public RhythmData Analyze(AudioClip audioClip, float initialLength = 5f)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x9597D8", Offset = "0x9597D8", VA = "0x9597D8")]
		public void Abort()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x959834", Offset = "0x959834", VA = "0x959834")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x959CBC", Offset = "0x959CBC", VA = "0x959CBC")]
		private void StartAnalyze()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x959ED0", Offset = "0x959ED0", VA = "0x959ED0")]
		private void Analyze()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x95A18C", Offset = "0x95A18C", VA = "0x95A18C")]
		private void OnAnalysisDone()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x959FBC", Offset = "0x959FBC", VA = "0x959FBC")]
		private void ProcessFrame(float[] samples)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x959F90", Offset = "0x959F90", VA = "0x959F90")]
		private void FillBuffer()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x95A198", Offset = "0x95A198", VA = "0x95A198")]
		private void GetData()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x95A244", Offset = "0x95A244", VA = "0x95A244")]
		private void Update()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x95A2A4", Offset = "0x95A2A4", VA = "0x95A2A4")]
		public RhythmAnalyzer()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class RhythmData : ScriptableObject, IEnumerable<Track>, IEnumerable
	{
		[Token(Token = "0x20001B8")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<Track>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Track <>2__current;

			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RhythmData <>4__this;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Track>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000C6")]
			private Track System.Collections.Generic.IEnumerator<RhythmTool.Track>.Current
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x95AA6C", Offset = "0x95AA6C", VA = "0x95AA6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B5")]
				[Address(RVA = "0x95AAB4", Offset = "0x95AAB4", VA = "0x95AAB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x95A47C", Offset = "0x95A47C", VA = "0x95A47C")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x95A858", Offset = "0x95A858", VA = "0x95A858", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x95A874", Offset = "0x95A874", VA = "0x95A874", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x95AA1C", Offset = "0x95AA1C", VA = "0x95AA1C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x95AA74", Offset = "0x95AA74", VA = "0x95AA74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B9")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Track> <>9__14_0;

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x95AB2C", Offset = "0x95AB2C", VA = "0x95AB2C")]
			public <>c()
			{
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x95AB34", Offset = "0x95AB34", VA = "0x95AB34")]
			internal bool <OnEnable>b__14_0(Track t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Track> _tracks;

		[Token(Token = "0x170000C5")]
		public List<Track> tracks
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x95A400", Offset = "0x95A400", VA = "0x95A400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A1")]
		public Track<T> GetTrack<T>() where T : Feature
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		public Track<T> GetTrack<T>(string trackName) where T : Feature
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		public void GetTracks<T>(List<Track<T>> tracks) where T : Feature
		{
		}

		[Token(Token = "0x60008A4")]
		public void GetTracks<T>(List<Track<T>> tracks, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60008A5")]
		public void GetFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x60008A6")]
		public void GetFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60008A7")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x60008A8")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x95A408", Offset = "0x95A408", VA = "0x95A408", Slot = "4")]
		public IEnumerator<Track> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x95A4A4", Offset = "0x95A4A4", VA = "0x95A4A4", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x95A534", Offset = "0x95A534", VA = "0x95A534")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x95A63C", Offset = "0x95A63C", VA = "0x95A63C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x959BF8", Offset = "0x959BF8", VA = "0x959BF8")]
		public static RhythmData Create(AudioClip audioClip, IEnumerable<Track> tracks)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x95A7D0", Offset = "0x95A7D0", VA = "0x95A7D0")]
		public RhythmData()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class RhythmEventProvider : RhythmTarget
	{
		[Token(Token = "0x20001BB")]
		private abstract class RhythmEvent : IDisposable
		{
			[Token(Token = "0x60008C3")]
			public abstract void Process(RhythmData rhythmData, float start, float end);

			[Token(Token = "0x60008C4")]
			public abstract void Dispose();

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x95AFC8", Offset = "0x95AFC8", VA = "0x95AFC8")]
			protected RhythmEvent()
			{
			}
		}

		[Token(Token = "0x20001BC")]
		private class RhythmEvent<T> : RhythmEvent where T : Feature
		{
			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> _action;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<T> _features;

			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string trackName;

			[Token(Token = "0x60008C6")]
			public RhythmEvent(string trackName)
			{
			}

			[Token(Token = "0x60008C7")]
			public override void Process(RhythmData rhythmData, float start, float end)
			{
			}

			[Token(Token = "0x60008C8")]
			public void Register(Action<T> action)
			{
			}

			[Token(Token = "0x60008C9")]
			public void Unregister(Action<T> action)
			{
			}

			[Token(Token = "0x60008CA")]
			public override void Dispose()
			{
			}
		}

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(-10f, 10f)]
		public float offset;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, RhythmEvent> _events;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x95AB90", Offset = "0x95AB90", VA = "0x95AB90", Slot = "4")]
		public override void Process(RhythmData rhythmData, float start, float end)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x95AD0C", Offset = "0x95AD0C", VA = "0x95AD0C", Slot = "5")]
		public override void Reset(RhythmData rhythmData, float time)
		{
		}

		[Token(Token = "0x60008BB")]
		public void Register<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x60008BC")]
		public void Unregister<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x60008BD")]
		public void Register<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60008BE")]
		public void Unregister<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x95AD30", Offset = "0x95AD30", VA = "0x95AD30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x95AECC", Offset = "0x95AECC", VA = "0x95AECC")]
		private static int GetHashCode(Type type, string trackName)
		{
			return default(int);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x95AF2C", Offset = "0x95AF2C", VA = "0x95AF2C")]
		private static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x95AF38", Offset = "0x95AF38", VA = "0x95AF38")]
		public RhythmEventProvider()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	[RequireComponent(typeof(AudioSource))]
	public class RhythmPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audioSource>k__BackingField;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <prevTime>k__BackingField;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RhythmData rhythmData;

		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<RhythmTarget> targets;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _time;

		[Token(Token = "0x170000C8")]
		public AudioSource audioSource
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x95B240", Offset = "0x95B240", VA = "0x95B240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x95B248", Offset = "0x95B248", VA = "0x95B248")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public AudioClip audioClip
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x95B250", Offset = "0x95B250", VA = "0x95B250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public float time
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x95B2D0", Offset = "0x95B2D0", VA = "0x95B2D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x95B2D8", Offset = "0x95B2D8", VA = "0x95B2D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public float volume
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x95B2FC", Offset = "0x95B2FC", VA = "0x95B2FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x95B318", Offset = "0x95B318", VA = "0x95B318")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public float pitch
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x95B334", Offset = "0x95B334", VA = "0x95B334")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x95B350", Offset = "0x95B350", VA = "0x95B350")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool isPlaying
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x95B36C", Offset = "0x95B36C", VA = "0x95B36C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public float prevTime
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x95B388", Offset = "0x95B388", VA = "0x95B388")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x95B390", Offset = "0x95B390", VA = "0x95B390")]
			private set
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action SongEnded
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x95AFD0", Offset = "0x95AFD0", VA = "0x95AFD0")]
			add
			{
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x95B06C", Offset = "0x95B06C", VA = "0x95B06C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action Reset
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x95B108", Offset = "0x95B108", VA = "0x95B108")]
			add
			{
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x95B1A4", Offset = "0x95B1A4", VA = "0x95B1A4")]
			remove
			{
			}
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x95B398", Offset = "0x95B398", VA = "0x95B398")]
		public void Play()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x95B62C", Offset = "0x95B62C", VA = "0x95B62C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x95B648", Offset = "0x95B648", VA = "0x95B648")]
		public void Pause()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x95B664", Offset = "0x95B664", VA = "0x95B664")]
		public void UnPause()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x95B680", Offset = "0x95B680", VA = "0x95B680")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x95B6D8", Offset = "0x95B6D8", VA = "0x95B6D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x95B9E8", Offset = "0x95B9E8", VA = "0x95B9E8")]
		private void OnSongEnded()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x95B468", Offset = "0x95B468", VA = "0x95B468")]
		private void OnReset()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x95BA04", Offset = "0x95BA04", VA = "0x95BA04")]
		public RhythmPlayer()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public abstract class RhythmTarget : ScriptableObject
	{
		[Token(Token = "0x60008E4")]
		public abstract void Process(RhythmData rhythmData, float start, float end);

		[Token(Token = "0x60008E5")]
		public abstract void Reset(RhythmData rhythmData, float time);

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x95AFC0", Offset = "0x95AFC0", VA = "0x95AFC0")]
		protected RhythmTarget()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class Segmenter : Analysis<Value>
	{
		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 64f)]
		public float threshold;

		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(1f, 16f)]
		public int smoothing;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 changeWeight;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float changeStartSlope;

		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float changeEndSlope;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int iterations;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int bufferSize;

		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[][] buffer;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] kernel;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float w;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float current;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float next;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool change;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float changeSign;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector2 changeStart;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float maxSlope;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int maxSlopeIndex;

		[Token(Token = "0x170000CF")]
		public override string name
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x95BA0C", Offset = "0x95BA0C", VA = "0x95BA0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x95BA4C", Offset = "0x95BA4C", VA = "0x95BA4C", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x95BCB4", Offset = "0x95BCB4", VA = "0x95BCB4", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x95BFF8", Offset = "0x95BFF8", VA = "0x95BFF8")]
		private void FindSegments()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x95C058", Offset = "0x95C058", VA = "0x95C058")]
		private void FindChangeEnd(float slope)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x95C1C8", Offset = "0x95C1C8", VA = "0x95C1C8")]
		private void FindChangeStart(float slope)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x95C234", Offset = "0x95C234", VA = "0x95C234")]
		public Segmenter()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public abstract class Track : ScriptableObject
	{
		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x170000D0")]
		public new string name
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x95C2AC", Offset = "0x95C2AC", VA = "0x95C2AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x95C2B4", Offset = "0x95C2B4", VA = "0x95C2B4")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public abstract class Track<T> : Track where T : Feature
	{
		[Serializable]
		[Token(Token = "0x20001C2")]
		private sealed class <>c
		{
			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Comparison<T> <>9__11_0;

			[Token(Token = "0x6000901")]
			public <>c()
			{
			}

			[Token(Token = "0x6000902")]
			internal int <Sort>b__11_0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _features;

		[NonSerialized]
		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<int> cachedTimestamps;

		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, int> cachedIndices;

		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type concreteType;

		[Token(Token = "0x170000D1")]
		public T this[int index]
		{
			[Token(Token = "0x60008F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public int count
		{
			[Token(Token = "0x60008F1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008F2")]
		static Track()
		{
		}

		[Token(Token = "0x60008F3")]
		public void Add(T feature)
		{
		}

		[Token(Token = "0x60008F4")]
		public void Remove(T feature)
		{
		}

		[Token(Token = "0x60008F5")]
		public void Sort()
		{
		}

		[Token(Token = "0x60008F6")]
		public void GetFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60008F7")]
		public void GetIntersectingFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60008F8")]
		public int GetIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008F9")]
		public int GetIndex(T feature)
		{
			return default(int);
		}

		[Token(Token = "0x60008FA")]
		public int GetIntersectingIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008FB")]
		private int BinarySearch(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008FC")]
		private int GetCacheIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008FD")]
		private void ClearCache(float timestamp)
		{
		}

		[Token(Token = "0x60008FE")]
		public static Track<T> Create(string name)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class Util
	{
		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LomontFFT fft;

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x95C2BC", Offset = "0x95C2BC", VA = "0x95C2BC")]
		public static void GetMono(float[] samples, float[] monoSamples, int channels = 0)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x95C488", Offset = "0x95C488", VA = "0x95C488")]
		public static void GetSpectrum(float[] samples)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x95C4F8", Offset = "0x95C4F8", VA = "0x95C4F8")]
		public static void GetSpectrumMagnitude(float[] spectrum, float[] magnitude)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x95C638", Offset = "0x95C638", VA = "0x95C638")]
		internal static void ApplyWindow(float[] array, float[] window)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x95BEE8", Offset = "0x95BEE8", VA = "0x95BEE8")]
		public static float Mean(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x95BF54", Offset = "0x95BF54", VA = "0x95BF54")]
		public static float WeightedSum(float[] array, float[] kernel, int index)
		{
			return default(float);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x95C6A4", Offset = "0x95C6A4", VA = "0x95C6A4")]
		public static int MaxIndex(float[] array, int start = 0, int end = 0)
		{
			return default(int);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x95C724", Offset = "0x95C724", VA = "0x95C724")]
		public static float Max(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x95C7B4", Offset = "0x95C7B4", VA = "0x95C7B4")]
		public static void Smooth(float[] array, float[] smoothedArray, float[] kernel)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x95C880", Offset = "0x95C880", VA = "0x95C880")]
		public static float Interpolate(float[] array, float index)
		{
			return default(float);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x95C908", Offset = "0x95C908", VA = "0x95C908")]
		public static void HannWindow(float[] array)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x95BC28", Offset = "0x95BC28", VA = "0x95BC28")]
		public static float[] HannWindow(int length)
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x95C9E0", Offset = "0x95C9E0", VA = "0x95C9E0")]
		public static float HannWindow(int n, int windowSize)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20001C4")]
	public class ValueTrack : Track<Value>
	{
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x95CAA0", Offset = "0x95CAA0", VA = "0x95CAA0")]
		public ValueTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001C5")]
	public class Value : Feature
	{
		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x95C22C", Offset = "0x95C22C", VA = "0x95C22C")]
		public Value()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class VolumeSampler : Analysis<Value>
	{
		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(1f, 64f)]
		private int _interval;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 16f)]
		[SerializeField]
		private int _smoothing;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int smoothingBufferSize;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] buffer;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] smoothingBuffer;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] smoothingKernel;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float w;

		[Token(Token = "0x170000D3")]
		public override string name
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x95CB0C", Offset = "0x95CB0C", VA = "0x95CB0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public int interval
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x95CB4C", Offset = "0x95CB4C", VA = "0x95CB4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x95CB54", Offset = "0x95CB54", VA = "0x95CB54")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public int smoothing
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x95CB70", Offset = "0x95CB70", VA = "0x95CB70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x95CB78", Offset = "0x95CB78", VA = "0x95CB78")]
			set
			{
			}
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x95CB90", Offset = "0x95CB90", VA = "0x95CB90", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x95CD04", Offset = "0x95CD04", VA = "0x95CD04", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x95CF28", Offset = "0x95CF28", VA = "0x95CF28")]
		public VolumeSampler()
		{
		}
	}
}
namespace RhythmTool.Examples
{
	[Token(Token = "0x20001C7")]
	public abstract class SongSelector : MonoBehaviour
	{
		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x95CF7C", Offset = "0x95CF7C", VA = "0x95CF7C", Slot = "4")]
		public virtual void NextSong()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x95CFA0", Offset = "0x95CFA0", VA = "0x95CFA0")]
		protected SongSelector()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class AudioClipSelector : SongSelector
	{
		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioClip> songs;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentSong;

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x95CFA8", Offset = "0x95CFA8", VA = "0x95CFA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x95CFB4", Offset = "0x95CFB4", VA = "0x95CFB4", Slot = "4")]
		public override void NextSong()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x95D0A8", Offset = "0x95D0A8", VA = "0x95D0A8")]
		public AudioClipSelector()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <timestamp>k__BackingField;

		[Token(Token = "0x170000D6")]
		public float timestamp
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x95D0B8", Offset = "0x95D0B8", VA = "0x95D0B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x95D0C0", Offset = "0x95D0C0", VA = "0x95D0C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x95D0C8", Offset = "0x95D0C8", VA = "0x95D0C8")]
		public void Init(Color color, float opacity, float timestamp)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x95D1AC", Offset = "0x95D1AC", VA = "0x95D1AC")]
		public Line()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class Visualizer : MonoBehaviour
	{
		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RhythmEventProvider eventProvider;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text textBPM;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Line linePrefab;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Line> lines;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Chroma> chromaFeatures;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Note lastNote;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x95D1B4", Offset = "0x95D1B4", VA = "0x95D1B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x95D4B8", Offset = "0x95D4B8", VA = "0x95D4B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x95D4F4", Offset = "0x95D4F4", VA = "0x95D4F4")]
		private void UpdateLines()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x95D980", Offset = "0x95D980", VA = "0x95D980")]
		private void OnInitialized(RhythmData rhythmData)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x95D998", Offset = "0x95D998", VA = "0x95D998")]
		private void OnReset()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x95DB50", Offset = "0x95DB50", VA = "0x95DB50")]
		private void OnBeat(Beat beat)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x95DE8C", Offset = "0x95DE8C", VA = "0x95DE8C")]
		private void OnOnset(Onset onset)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x95E160", Offset = "0x95E160", VA = "0x95E160")]
		private void OnSegment(Value segment)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x95DCD4", Offset = "0x95DCD4", VA = "0x95DCD4")]
		private void CreateLine(float timestamp, float position, float scale, Color color, float opacity)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x95E19C", Offset = "0x95E19C", VA = "0x95E19C")]
		public Visualizer()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20001CB")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000D7")]
		public bool Highlight
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x95E1AC", Offset = "0x95E1AC", VA = "0x95E1AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x95E1B4", Offset = "0x95E1B4", VA = "0x95E1B4")]
			set
			{
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x95E1C0", Offset = "0x95E1C0", VA = "0x95E1C0")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x95E360", Offset = "0x95E360", VA = "0x95E360", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x95E37C", Offset = "0x95E37C", VA = "0x95E37C", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x95E398", Offset = "0x95E398", VA = "0x95E398")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x95E26C", Offset = "0x95E26C", VA = "0x95E26C")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x95E64C", Offset = "0x95E64C", VA = "0x95E64C")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000D8")]
		public bool InRange
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x95E6C4", Offset = "0x95E6C4", VA = "0x95E6C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x95E6CC", Offset = "0x95E6CC", VA = "0x95E6CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool Targeted
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x95E838", Offset = "0x95E838", VA = "0x95E838")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x95E840", Offset = "0x95E840", VA = "0x95E840")]
			set
			{
			}
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x95E84C", Offset = "0x95E84C", VA = "0x95E84C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x95E6D8", Offset = "0x95E6D8", VA = "0x95E6D8")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x95EA3C", Offset = "0x95EA3C", VA = "0x95EA3C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20001CD")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000DA")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x95EA44", Offset = "0x95EA44", VA = "0x95EA44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x95EA4C", Offset = "0x95EA4C", VA = "0x95EA4C")]
			set
			{
			}
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x95EA68", Offset = "0x95EA68", VA = "0x95EA68", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x95EC74", Offset = "0x95EC74", VA = "0x95EC74", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x95F560", Offset = "0x95F560", VA = "0x95F560", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x95FAC8", Offset = "0x95FAC8", VA = "0x95FAC8", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x95FED8", Offset = "0x95FED8", VA = "0x95FED8")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x95EE9C", Offset = "0x95EE9C", VA = "0x95EE9C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x95FFC4", Offset = "0x95FFC4", VA = "0x95FFC4")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x9603C4", Offset = "0x9603C4", VA = "0x9603C4", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x9603DC", Offset = "0x9603DC", VA = "0x9603DC", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x9603E4", Offset = "0x9603E4", VA = "0x9603E4")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20001CF")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000BDC")]
			Disabled,
			[Token(Token = "0x4000BDD")]
			Enabled,
			[Token(Token = "0x4000BDE")]
			Targeted
		}

		[Token(Token = "0x4000BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x960404", Offset = "0x960404", VA = "0x960404")]
		private void Start()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x95E9B0", Offset = "0x95E9B0", VA = "0x95E9B0")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x96046C", Offset = "0x96046C", VA = "0x96046C")]
		private void Update()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x9604A4", Offset = "0x9604A4", VA = "0x9604A4")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x9604AC", Offset = "0x9604AC", VA = "0x9604AC")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x960558", Offset = "0x960558", VA = "0x960558")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x960600", Offset = "0x960600", VA = "0x960600")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x960608", Offset = "0x960608", VA = "0x960608")]
		private void Start()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x9606F4", Offset = "0x9606F4", VA = "0x9606F4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x960700", Offset = "0x960700", VA = "0x960700")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x96070C", Offset = "0x96070C", VA = "0x96070C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x960714", Offset = "0x960714", VA = "0x960714")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x960764", Offset = "0x960764", VA = "0x960764")]
		private void Update()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x960B3C", Offset = "0x960B3C", VA = "0x960B3C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x960C28", Offset = "0x960C28", VA = "0x960C28")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x960768", Offset = "0x960768", VA = "0x960768")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x960D14", Offset = "0x960D14", VA = "0x960D14")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20001D4")]
		public enum ContactTest
		{
			[Token(Token = "0x4000BF5")]
			PerpenTest,
			[Token(Token = "0x4000BF6")]
			BackwardsPress
		}

		[Token(Token = "0x4000BE6")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000BE7")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000DB")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x960DEC", Offset = "0x960DEC", VA = "0x960DEC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x960DF4", Offset = "0x960DF4", VA = "0x960DF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000DD")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x960E00", Offset = "0x960E00", VA = "0x960E00")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x960E08", Offset = "0x960E08", VA = "0x960E08")]
			private set
			{
			}
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x960E10", Offset = "0x960E10", VA = "0x960E10", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x960F60", Offset = "0x960F60", VA = "0x960F60")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x961168", Offset = "0x961168", VA = "0x961168", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x96172C", Offset = "0x96172C", VA = "0x96172C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x961894", Offset = "0x961894", VA = "0x961894")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x961650", Offset = "0x961650", VA = "0x961650")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x9619A0", Offset = "0x9619A0", VA = "0x9619A0")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x961AAC", Offset = "0x961AAC", VA = "0x961AAC")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x961B34", Offset = "0x961B34", VA = "0x961B34")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000DE")]
		public Collider Collider
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x961C58", Offset = "0x961C58", VA = "0x961C58", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x961C60", Offset = "0x961C60", VA = "0x961C60")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x961C68", Offset = "0x961C68", VA = "0x961C68", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x961C70", Offset = "0x961C70", VA = "0x961C70")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x961C78", Offset = "0x961C78", VA = "0x961C78", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x961CC8", Offset = "0x961CC8", VA = "0x961CC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x961D5C", Offset = "0x961D5C", VA = "0x961D5C")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000E1")]
		Collider Collider
		{
			[Token(Token = "0x600096F")]
			get;
		}

		[Token(Token = "0x170000E2")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000970")]
			get;
		}

		[Token(Token = "0x170000E3")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000971")]
			get;
		}
	}
	[Token(Token = "0x20001D7")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x9610BC", Offset = "0x9610BC", VA = "0x9610BC")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public enum InteractionType
	{
		[Token(Token = "0x4000BFF")]
		Enter,
		[Token(Token = "0x4000C00")]
		Stay,
		[Token(Token = "0x4000C01")]
		Exit
	}
	[Token(Token = "0x20001D9")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20001DA")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000C13")]
			Mesh,
			[Token(Token = "0x4000C14")]
			Skeleton,
			[Token(Token = "0x4000C15")]
			Both
		}

		[Token(Token = "0x20001DB")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x9631BC", Offset = "0x9631BC", VA = "0x9631BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x963204", Offset = "0x963204", VA = "0x963204", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x9627B4", Offset = "0x9627B4", VA = "0x9627B4")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x962F9C", Offset = "0x962F9C", VA = "0x962F9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x962FA0", Offset = "0x962FA0", VA = "0x962FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x9631C4", Offset = "0x9631C4", VA = "0x9631C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C02")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000E4")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x961D64", Offset = "0x961D64", VA = "0x961D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x961D90", Offset = "0x961D90", VA = "0x961D90")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x961DF4", Offset = "0x961DF4", VA = "0x961DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x961E20", Offset = "0x961E20", VA = "0x961E20")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x961E84", Offset = "0x961E84", VA = "0x961E84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x961EB0", Offset = "0x961EB0", VA = "0x961EB0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x961F14", Offset = "0x961F14", VA = "0x961F14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x961F40", Offset = "0x961F40", VA = "0x961F40")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x961FA4", Offset = "0x961FA4", VA = "0x961FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x961FD0", Offset = "0x961FD0", VA = "0x961FD0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x962034", Offset = "0x962034", VA = "0x962034")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x96205C", Offset = "0x96205C", VA = "0x96205C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x9620BC", Offset = "0x9620BC", VA = "0x9620BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x9620E4", Offset = "0x9620E4", VA = "0x9620E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x962144", Offset = "0x962144", VA = "0x962144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x96216C", Offset = "0x96216C", VA = "0x96216C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x9621CC", Offset = "0x9621CC", VA = "0x9621CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x9621F4", Offset = "0x9621F4", VA = "0x9621F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x962254", Offset = "0x962254", VA = "0x962254")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x96227C", Offset = "0x96227C", VA = "0x96227C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x9622DC", Offset = "0x9622DC", VA = "0x9622DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x962324", Offset = "0x962324", VA = "0x962324")]
			private set
			{
			}
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x96237C", Offset = "0x96237C", VA = "0x96237C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x962738", Offset = "0x962738", VA = "0x962738")]
		private void Update()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x9626C4", Offset = "0x9626C4", VA = "0x9626C4")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x9627DC", Offset = "0x9627DC", VA = "0x9627DC")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x9628A0", Offset = "0x9628A0", VA = "0x9628A0")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x962A70", Offset = "0x962A70", VA = "0x962A70")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x962CD4", Offset = "0x962CD4", VA = "0x962CD4")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x962E34", Offset = "0x962E34", VA = "0x962E34")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001DD")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x963854", Offset = "0x963854", VA = "0x963854")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000F1")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x96320C", Offset = "0x96320C", VA = "0x96320C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x963214", Offset = "0x963214", VA = "0x963214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x96321C", Offset = "0x96321C", VA = "0x96321C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x963224", Offset = "0x963224", VA = "0x963224", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000015")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x96322C", Offset = "0x96322C", VA = "0x96322C")]
			add
			{
			}
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x9632DC", Offset = "0x9632DC", VA = "0x9632DC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x9633A8", Offset = "0x9633A8", VA = "0x9633A8")]
			add
			{
			}
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x963458", Offset = "0x963458", VA = "0x963458")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x963524", Offset = "0x963524", VA = "0x963524")]
			add
			{
			}
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x9635D4", Offset = "0x9635D4", VA = "0x9635D4")]
			remove
			{
			}
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x96338C", Offset = "0x96338C", VA = "0x96338C", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x963508", Offset = "0x963508", VA = "0x963508", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x963684", Offset = "0x963684", VA = "0x963684", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60009A4")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x960F0C", Offset = "0x960F0C", VA = "0x960F0C", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x963750", Offset = "0x963750", VA = "0x963750", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x961C50", Offset = "0x961C50", VA = "0x961C50")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000C21")]
		None,
		[Token(Token = "0x4000C22")]
		Proximity,
		[Token(Token = "0x4000C23")]
		Contact,
		[Token(Token = "0x4000C24")]
		Action
	}
	[Token(Token = "0x20001DF")]
	public enum InteractableState
	{
		[Token(Token = "0x4000C26")]
		Default,
		[Token(Token = "0x4000C27")]
		ProximityState,
		[Token(Token = "0x4000C28")]
		ContactState,
		[Token(Token = "0x4000C29")]
		ActionState
	}
	[Token(Token = "0x20001E0")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x9617DC", Offset = "0x9617DC", VA = "0x9617DC")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000F5")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x96389C", Offset = "0x96389C", VA = "0x96389C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x9636A0", Offset = "0x9636A0", VA = "0x9636A0")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x9637A4", Offset = "0x9637A4", VA = "0x9637A4")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x9638F4", Offset = "0x9638F4", VA = "0x9638F4")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001E3")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000C36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0x9640B4", Offset = "0x9640B4", VA = "0x9640B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B9")]
				[Address(RVA = "0x9640FC", Offset = "0x9640FC", VA = "0x9640FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x963A9C", Offset = "0x963A9C", VA = "0x963A9C")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x963BD8", Offset = "0x963BD8", VA = "0x963BD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x963BF4", Offset = "0x963BF4", VA = "0x963BF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x964064", Offset = "0x964064", VA = "0x964064")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x9640BC", Offset = "0x9640BC", VA = "0x9640BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x963994", Offset = "0x963994", VA = "0x963994")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x963A00", Offset = "0x963A00", VA = "0x963A00")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x963AC4", Offset = "0x963AC4", VA = "0x963AC4")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x963BD0", Offset = "0x963BD0", VA = "0x963BD0")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000F8")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x964104", Offset = "0x964104", VA = "0x964104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x964260", Offset = "0x964260", VA = "0x964260")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x9642FC", Offset = "0x9642FC", VA = "0x9642FC")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x964398", Offset = "0x964398", VA = "0x964398")]
		private void Update()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x964634", Offset = "0x964634", VA = "0x964634")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x964670", Offset = "0x964670", VA = "0x964670")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x964948", Offset = "0x964948", VA = "0x964948")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x964B50", Offset = "0x964B50", VA = "0x964B50")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001E6")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000FD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D3")]
				[Address(RVA = "0x965D20", Offset = "0x965D20", VA = "0x965D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x965D68", Offset = "0x965D68", VA = "0x965D68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x964DEC", Offset = "0x964DEC", VA = "0x964DEC")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x965890", Offset = "0x965890", VA = "0x965890", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x965894", Offset = "0x965894", VA = "0x965894", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x965D28", Offset = "0x965D28", VA = "0x965D28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C42")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000F9")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x964C58", Offset = "0x964C58", VA = "0x964C58", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000FA")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x964C60", Offset = "0x964C60", VA = "0x964C60", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000FB")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x964C68", Offset = "0x964C68", VA = "0x964C68", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public override bool EnableState
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x964C70", Offset = "0x964C70", VA = "0x964C70", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x964C98", Offset = "0x964C98", VA = "0x964C98", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x964CC8", Offset = "0x964CC8", VA = "0x964CC8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x964D78", Offset = "0x964D78", VA = "0x964D78")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x964E14", Offset = "0x964E14", VA = "0x964E14")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x965094", Offset = "0x965094", VA = "0x965094")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x965250", Offset = "0x965250", VA = "0x965250")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x965338", Offset = "0x965338", VA = "0x965338", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x9656CC", Offset = "0x9656CC", VA = "0x9656CC", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x9656D0", Offset = "0x9656D0", VA = "0x9656D0", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x9656D4", Offset = "0x9656D4", VA = "0x9656D4")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	public class FingerTipPokeToolView : MonoBehaviour
	{
		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000FF")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x965D70", Offset = "0x965D70", VA = "0x965D70", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x965D78", Offset = "0x965D78", VA = "0x965D78")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool EnableState
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x965D80", Offset = "0x965D80", VA = "0x965D80", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x965D9C", Offset = "0x965D9C", VA = "0x965D9C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x965DBC", Offset = "0x965DBC", VA = "0x965DBC", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x965DC4", Offset = "0x965DC4", VA = "0x965DC4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float SphereRadius
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x965DD0", Offset = "0x965DD0", VA = "0x965DD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x965DD8", Offset = "0x965DD8", VA = "0x965DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x965DE0", Offset = "0x965DE0", VA = "0x965DE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x965E1C", Offset = "0x965E1C", VA = "0x965E1C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000C55")]
		None = 0,
		[Token(Token = "0x4000C56")]
		Ray = 1,
		[Token(Token = "0x4000C57")]
		Poke = 4,
		[Token(Token = "0x4000C58")]
		All = -1
	}
	[Token(Token = "0x20001E9")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000C5A")]
		Inactive,
		[Token(Token = "0x4000C5B")]
		PrimaryInputDown,
		[Token(Token = "0x4000C5C")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000C5D")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001EA")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x965678", Offset = "0x965678", VA = "0x965678")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x17000103")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x961B2C", Offset = "0x961B2C", VA = "0x961B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x965E24", Offset = "0x965E24", VA = "0x965E24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x965E2C", Offset = "0x965E2C", VA = "0x965E2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009E4")]
			get;
		}

		[Token(Token = "0x17000106")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60009E5")]
			get;
		}

		[Token(Token = "0x17000107")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60009E6")]
			get;
		}

		[Token(Token = "0x17000108")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x965E38", Offset = "0x965E38", VA = "0x965E38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x965E44", Offset = "0x965E44", VA = "0x965E44")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x965E50", Offset = "0x965E50", VA = "0x965E50")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x965E5C", Offset = "0x965E5C", VA = "0x965E5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60009EF")]
			get;
			[Token(Token = "0x60009F0")]
			set;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x965E68", Offset = "0x965E68", VA = "0x965E68")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60009ED")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60009EE")]
		public abstract void DeFocus();

		[Token(Token = "0x60009F1")]
		public abstract void Initialize();

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x964AB8", Offset = "0x964AB8", VA = "0x964AB8")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x964B00", Offset = "0x964B00", VA = "0x964B00")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x965E70", Offset = "0x965E70", VA = "0x965E70", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x966138", Offset = "0x966138", VA = "0x966138", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x9656E8", Offset = "0x9656E8", VA = "0x9656E8")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001EC")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001ED")]
		private enum PinchState
		{
			[Token(Token = "0x4000C6E")]
			None,
			[Token(Token = "0x4000C6F")]
			PinchDown,
			[Token(Token = "0x4000C70")]
			PinchStay,
			[Token(Token = "0x4000C71")]
			PinchUp
		}

		[Token(Token = "0x4000C6A")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x1700010B")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x9669D4", Offset = "0x9669D4", VA = "0x9669D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x966A50", Offset = "0x966A50", VA = "0x966A50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x966ACC", Offset = "0x966ACC", VA = "0x966ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x966B48", Offset = "0x966B48", VA = "0x966B48")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x966B70", Offset = "0x966B70", VA = "0x966B70")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000C72")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000C73")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000C74")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000C75")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000C76")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x1700010E")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x966CE8", Offset = "0x966CE8", VA = "0x966CE8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700010F")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x966CF0", Offset = "0x966CF0", VA = "0x966CF0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000110")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x966D4C", Offset = "0x966D4C", VA = "0x966D4C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public override bool EnableState
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x966D54", Offset = "0x966D54", VA = "0x966D54", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x966D94", Offset = "0x966D94", VA = "0x966D94", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x966E04", Offset = "0x966E04", VA = "0x966E04", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x966E58", Offset = "0x966E58", VA = "0x966E58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x966EE4", Offset = "0x966EE4", VA = "0x966EE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x967188", Offset = "0x967188", VA = "0x967188")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x967204", Offset = "0x967204", VA = "0x967204", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x9675F8", Offset = "0x9675F8", VA = "0x9675F8")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x967794", Offset = "0x967794", VA = "0x967794")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x9678AC", Offset = "0x9678AC", VA = "0x9678AC")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x967BD0", Offset = "0x967BD0", VA = "0x967BD0")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x967F4C", Offset = "0x967F4C", VA = "0x967F4C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x968024", Offset = "0x968024", VA = "0x968024", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x968054", Offset = "0x968054", VA = "0x968054")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	public class RayToolView : MonoBehaviour
	{
		[Token(Token = "0x4000C82")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000C83")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x17000112")]
		public bool EnableState
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x966D78", Offset = "0x966D78", VA = "0x966D78", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x966DB0", Offset = "0x966DB0", VA = "0x966DB0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x968168", Offset = "0x968168", VA = "0x968168", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x96714C", Offset = "0x96714C", VA = "0x96714C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x968390", Offset = "0x968390", VA = "0x968390", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x968398", Offset = "0x968398", VA = "0x968398")]
			set
			{
			}
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x968170", Offset = "0x968170", VA = "0x968170")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x967F84", Offset = "0x967F84", VA = "0x967F84", Slot = "9")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x9683A0", Offset = "0x9683A0", VA = "0x9683A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x96864C", Offset = "0x96864C", VA = "0x96864C")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x9686F4", Offset = "0x9686F4", VA = "0x9686F4")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x17000115")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x968758", Offset = "0x968758", VA = "0x968758")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x968760", Offset = "0x968760", VA = "0x968760")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x9687DC", Offset = "0x9687DC", VA = "0x9687DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x9687E4", Offset = "0x9687E4", VA = "0x9687E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x968840", Offset = "0x968840", VA = "0x968840")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x968AE0", Offset = "0x968AE0", VA = "0x968AE0")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x968AF0", Offset = "0x968AF0", VA = "0x968AF0")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x968B00", Offset = "0x968B00", VA = "0x968B00")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x968B08", Offset = "0x968B08", VA = "0x968B08")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x968B94", Offset = "0x968B94", VA = "0x968B94")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x968C24", Offset = "0x968C24", VA = "0x968C24")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x968CB4", Offset = "0x968CB4", VA = "0x968CB4")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x968D60", Offset = "0x968D60", VA = "0x968D60")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x968E3C", Offset = "0x968E3C", VA = "0x968E3C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x968E80", Offset = "0x968E80", VA = "0x968E80")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x968EE0", Offset = "0x968EE0", VA = "0x968EE0")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x968F40", Offset = "0x968F40", VA = "0x968F40")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x968F48", Offset = "0x968F48", VA = "0x968F48")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x968F10", Offset = "0x968F10", VA = "0x968F10")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x968F7C", Offset = "0x968F7C", VA = "0x968F7C")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001F4")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A34")]
				[Address(RVA = "0x9695FC", Offset = "0x9695FC", VA = "0x9695FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0x969644", Offset = "0x969644", VA = "0x969644", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x969374", Offset = "0x969374", VA = "0x969374")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x96943C", Offset = "0x96943C", VA = "0x96943C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x969440", Offset = "0x969440", VA = "0x969440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x969604", Offset = "0x969604", VA = "0x969604", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C93")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000C94")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x968F84", Offset = "0x968F84", VA = "0x968F84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x969024", Offset = "0x969024", VA = "0x969024")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x969334", Offset = "0x969334", VA = "0x969334")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x9692C0", Offset = "0x9692C0", VA = "0x9692C0")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x96939C", Offset = "0x96939C", VA = "0x96939C")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001F6")]
		public enum SelectionState
		{
			[Token(Token = "0x4000CAA")]
			Off,
			[Token(Token = "0x4000CAB")]
			Selected,
			[Token(Token = "0x4000CAC")]
			Highlighted
		}

		[Token(Token = "0x4000CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x17000119")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x96964C", Offset = "0x96964C", VA = "0x96964C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x969654", Offset = "0x969654", VA = "0x969654")]
			set
			{
			}
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x9697A8", Offset = "0x9697A8", VA = "0x9697A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x96996C", Offset = "0x96996C", VA = "0x96996C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x9696C8", Offset = "0x9696C8", VA = "0x9696C8")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x969A34", Offset = "0x969A34", VA = "0x969A34")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001F8")]
		public enum SegmentType
		{
			[Token(Token = "0x4000CBB")]
			Straight,
			[Token(Token = "0x4000CBC")]
			LeftTurn,
			[Token(Token = "0x4000CBD")]
			RightTurn,
			[Token(Token = "0x4000CBE")]
			Switch
		}

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000CB3")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000CB4")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x1700011A")]
		public float StartDistance
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x969AA4", Offset = "0x969AA4", VA = "0x969AA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x969AAC", Offset = "0x969AAC", VA = "0x969AAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public float GridSize
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x969AB4", Offset = "0x969AB4", VA = "0x969AB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x969ABC", Offset = "0x969ABC", VA = "0x969ABC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public int SubDivCount
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x969AC4", Offset = "0x969AC4", VA = "0x969AC4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x969ACC", Offset = "0x969ACC", VA = "0x969ACC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public SegmentType Type
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x969AD4", Offset = "0x969AD4", VA = "0x969AD4")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x1700011E")]
		public Pose EndPose
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x969ADC", Offset = "0x969ADC", VA = "0x969ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public float Radius
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x969EB0", Offset = "0x969EB0", VA = "0x969EB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000120")]
		public float SegmentLength
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x969B38", Offset = "0x969B38", VA = "0x969B38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x969EC0", Offset = "0x969EC0", VA = "0x969EC0")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x969B78", Offset = "0x969B78", VA = "0x969B78")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x969ED8", Offset = "0x969ED8", VA = "0x969ED8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x969F34", Offset = "0x969F34", VA = "0x969F34")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x96A868", Offset = "0x96A868", VA = "0x96A868")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x96AAEC", Offset = "0x96AAEC", VA = "0x96AAEC")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001F9")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001FA")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x17000121")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x96B610", Offset = "0x96B610", VA = "0x96B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x96B658", Offset = "0x96B658", VA = "0x96B658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x96B444", Offset = "0x96B444", VA = "0x96B444")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x96B494", Offset = "0x96B494", VA = "0x96B494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x96B498", Offset = "0x96B498", VA = "0x96B498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x96B618", Offset = "0x96B618", VA = "0x96B618", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000CBF")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000CC0")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x96AC4C", Offset = "0x96AC4C", VA = "0x96AC4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x96AD04", Offset = "0x96AD04", VA = "0x96AD04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x96AD94", Offset = "0x96AD94", VA = "0x96AD94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x96AEDC", Offset = "0x96AEDC", VA = "0x96AEDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x96B068", Offset = "0x96B068", VA = "0x96B068")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x96B178", Offset = "0x96B178", VA = "0x96B178")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x96B37C", Offset = "0x96B37C", VA = "0x96B37C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x96B288", Offset = "0x96B288", VA = "0x96B288")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x96B29C", Offset = "0x96B29C", VA = "0x96B29C")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x96B3D0", Offset = "0x96B3D0", VA = "0x96B3D0")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x96B46C", Offset = "0x96B46C", VA = "0x96B46C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001FB")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x17000123")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x96B660", Offset = "0x96B660", VA = "0x96B660")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x96B670", Offset = "0x96B670", VA = "0x96B670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x96B678", Offset = "0x96B678", VA = "0x96B678", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x96B9A8", Offset = "0x96B9A8", VA = "0x96B9A8")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001FC")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000CD8")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000CD9")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x17000124")]
		public float Distance
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x96BAA4", Offset = "0x96BAA4", VA = "0x96BAA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x96BAAC", Offset = "0x96BAAC", VA = "0x96BAAC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float Scale
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x96BAB4", Offset = "0x96BAB4", VA = "0x96BAB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x96BABC", Offset = "0x96BABC", VA = "0x96BABC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x96B674", Offset = "0x96B674", VA = "0x96B674", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x96BAC4", Offset = "0x96BAC4", VA = "0x96BAC4")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x96B6B4", Offset = "0x96B6B4", VA = "0x96B6B4")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x96B8C4", Offset = "0x96B8C4", VA = "0x96B8C4")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000A6B")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x96BA08", Offset = "0x96BA08", VA = "0x96BA08")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001FD")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001FE")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000CED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000CEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000CEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000CF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000CF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000CF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000CF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000CF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000CF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000CF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000CF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7A")]
				[Address(RVA = "0x96C394", Offset = "0x96C394", VA = "0x96C394", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x96C3DC", Offset = "0x96C3DC", VA = "0x96C3DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x96C008", Offset = "0x96C008", VA = "0x96C008")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x96C17C", Offset = "0x96C17C", VA = "0x96C17C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x96C180", Offset = "0x96C180", VA = "0x96C180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x96C39C", Offset = "0x96C39C", VA = "0x96C39C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x96BC34", Offset = "0x96BC34", VA = "0x96BC34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x96BC90", Offset = "0x96BC90", VA = "0x96BC90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x96BD68", Offset = "0x96BD68", VA = "0x96BD68")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x96BEBC", Offset = "0x96BEBC", VA = "0x96BEBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x96BDC4", Offset = "0x96BDC4", VA = "0x96BDC4")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x96BF84", Offset = "0x96BF84", VA = "0x96BF84")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x96C030", Offset = "0x96C030", VA = "0x96C030")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x96C0C8", Offset = "0x96C0C8", VA = "0x96C0C8")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x96C124", Offset = "0x96C124", VA = "0x96C124")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x2000200")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000D16")]
			Start,
			[Token(Token = "0x4000D17")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000D18")]
			Stop
		}

		[Token(Token = "0x2000201")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x96CC74", Offset = "0x96CC74", VA = "0x96CC74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A91")]
				[Address(RVA = "0x96CCBC", Offset = "0x96CCBC", VA = "0x96CCBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x96C684", Offset = "0x96C684", VA = "0x96C684")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x96CA4C", Offset = "0x96CA4C", VA = "0x96CA4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x96CA50", Offset = "0x96CA50", VA = "0x96CA50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x96CC7C", Offset = "0x96CC7C", VA = "0x96CC7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000CF8")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000CF9")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000CFA")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000CFB")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x4000CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x96C3E4", Offset = "0x96C3E4", VA = "0x96C3E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x96C540", Offset = "0x96C540", VA = "0x96C540")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x96C54C", Offset = "0x96C54C", VA = "0x96C54C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x968B38", Offset = "0x968B38", VA = "0x968B38")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x96C4B8", Offset = "0x96C4B8", VA = "0x96C4B8")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x96C6AC", Offset = "0x96C6AC", VA = "0x96C6AC")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x96C624", Offset = "0x96C624", VA = "0x96C624")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x968BC4", Offset = "0x968BC4", VA = "0x968BC4")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x968C54", Offset = "0x968C54", VA = "0x968C54")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x96C8C0", Offset = "0x96C8C0", VA = "0x96C8C0")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x96C9B4", Offset = "0x96C9B4", VA = "0x96C9B4")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x968CE4", Offset = "0x968CE4", VA = "0x968CE4")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x968D90", Offset = "0x968D90", VA = "0x968D90")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x968E70", Offset = "0x968E70", VA = "0x968E70")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x96C9F0", Offset = "0x96C9F0", VA = "0x96C9F0")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000202")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x1700012A")]
		public float TrackLength
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x96CCC4", Offset = "0x96CCC4", VA = "0x96CCC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x96CCCC", Offset = "0x96CCCC", VA = "0x96CCCC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x96CCD4", Offset = "0x96CCD4", VA = "0x96CCD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x96BB2C", Offset = "0x96BB2C", VA = "0x96BB2C")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x96CCD8", Offset = "0x96CCD8", VA = "0x96CCD8")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x96CED0", Offset = "0x96CED0", VA = "0x96CED0")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x96CFB0", Offset = "0x96CFB0", VA = "0x96CFB0")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000203")]
	public class Pose
	{
		[Token(Token = "0x4000D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x96ABB4", Offset = "0x96ABB4", VA = "0x96ABB4")]
		public Pose()
		{
		}
	}
	[Token(Token = "0x2000204")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000205")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000D3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000D3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AA6")]
				[Address(RVA = "0x96D55C", Offset = "0x96D55C", VA = "0x96D55C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA8")]
				[Address(RVA = "0x96D5A4", Offset = "0x96D5A4", VA = "0x96D5A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x96D244", Offset = "0x96D244", VA = "0x96D244")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x96D3B8", Offset = "0x96D3B8", VA = "0x96D3B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x96D3BC", Offset = "0x96D3BC", VA = "0x96D3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x96D564", Offset = "0x96D564", VA = "0x96D564", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000206")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000D3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000D40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000D41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AAC")]
				[Address(RVA = "0x96D680", Offset = "0x96D680", VA = "0x96D680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AAE")]
				[Address(RVA = "0x96D6C8", Offset = "0x96D6C8", VA = "0x96D6C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x96D320", Offset = "0x96D320", VA = "0x96D320")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x96D5AC", Offset = "0x96D5AC", VA = "0x96D5AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x96D5B0", Offset = "0x96D5B0", VA = "0x96D5B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x96D688", Offset = "0x96D688", VA = "0x96D688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000D2B")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x4000D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x1700012B")]
		public bool IsMoving
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x96CFCC", Offset = "0x96CFCC", VA = "0x96CFCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x96CFD4", Offset = "0x96CFD4", VA = "0x96CFD4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x96CFE0", Offset = "0x96CFE0", VA = "0x96CFE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x96D010", Offset = "0x96D010", VA = "0x96D010")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x96D150", Offset = "0x96D150", VA = "0x96D150")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x96D1C0", Offset = "0x96D1C0", VA = "0x96D1C0")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x96D26C", Offset = "0x96D26C", VA = "0x96D26C")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x96D348", Offset = "0x96D348", VA = "0x96D348")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x96D3B0", Offset = "0x96D3B0", VA = "0x96D3B0")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000207")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x96D6D0", Offset = "0x96D6D0", VA = "0x96D6D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x96D744", Offset = "0x96D744", VA = "0x96D744")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x96D80C", Offset = "0x96D80C", VA = "0x96D80C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x96D91C", Offset = "0x96D91C", VA = "0x96D91C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x96D998", Offset = "0x96D998", VA = "0x96D998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x96DA60", Offset = "0x96DA60", VA = "0x96DA60")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000208")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x2000209")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x17000130")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x8B23B8", Offset = "0x8B23B8", VA = "0x8B23B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000131")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x8B2400", Offset = "0x8B2400", VA = "0x8B2400", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x8B218C", Offset = "0x8B218C", VA = "0x8B218C")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x8B21B4", Offset = "0x8B21B4", VA = "0x8B21B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x8B21B8", Offset = "0x8B21B8", VA = "0x8B21B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x8B23C0", Offset = "0x8B23C0", VA = "0x8B23C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000D48")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000D49")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000D4A")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject mainCamera;

		[Token(Token = "0x4000D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x4000D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x96DA70", Offset = "0x96DA70", VA = "0x96DA70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x96E2B0", Offset = "0x96E2B0", VA = "0x96E2B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x96E3D8", Offset = "0x96E3D8", VA = "0x96E3D8")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x96E508", Offset = "0x96E508", VA = "0x96E508")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x96E638", Offset = "0x96E638", VA = "0x96E638")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x96E3B8", Offset = "0x96E3B8", VA = "0x96E3B8")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x96E70C", Offset = "0x96E70C", VA = "0x96E70C")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x96E780", Offset = "0x96E780", VA = "0x96E780")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x96DEE0", Offset = "0x96DEE0", VA = "0x96DEE0")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x96E8C8", Offset = "0x96E8C8", VA = "0x96E8C8")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x96E7A8", Offset = "0x96E7A8", VA = "0x96E7A8")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x96EC50", Offset = "0x96EC50", VA = "0x96EC50")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x96ED3C", Offset = "0x96ED3C", VA = "0x96ED3C")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x96EDD0", Offset = "0x96EDD0", VA = "0x96EDD0")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x96EE24", Offset = "0x96EE24", VA = "0x96EE24")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x96EE78", Offset = "0x96EE78", VA = "0x96EE78")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200020A")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200020B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x8B3210", Offset = "0x8B3210", VA = "0x8B3210")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x8B3218", Offset = "0x8B3218", VA = "0x8B3218")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000D62")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000D63")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000D64")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000D65")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000D66")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000D67")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000D68")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000D69")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000D6A")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000D6B")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000D6C")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x8B2408", Offset = "0x8B2408", VA = "0x8B2408")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x8B2460", Offset = "0x8B2460", VA = "0x8B2460")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x8B28B0", Offset = "0x8B28B0", VA = "0x8B28B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x8B299C", Offset = "0x8B299C", VA = "0x8B299C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x8B2B00", Offset = "0x8B2B00", VA = "0x8B2B00")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x8B2DD0", Offset = "0x8B2DD0", VA = "0x8B2DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x8B2EB4", Offset = "0x8B2EB4", VA = "0x8B2EB4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x8B3064", Offset = "0x8B3064", VA = "0x8B3064")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x8B2B8C", Offset = "0x8B2B8C", VA = "0x8B2B8C")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x8B2BE0", Offset = "0x8B2BE0", VA = "0x8B2BE0")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x8B2770", Offset = "0x8B2770", VA = "0x8B2770")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x8B3188", Offset = "0x8B3188", VA = "0x8B3188")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200020C")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000D81")]
		Default,
		[Token(Token = "0x4000D82")]
		Generic,
		[Token(Token = "0x4000D83")]
		PingPongBall,
		[Token(Token = "0x4000D84")]
		Controller
	}
	[Token(Token = "0x200020D")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x17000132")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x8B3240", Offset = "0x8B3240", VA = "0x8B3240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x8B3248", Offset = "0x8B3248", VA = "0x8B3248")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000134")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x8B3250", Offset = "0x8B3250", VA = "0x8B3250")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x8B3258", Offset = "0x8B3258", VA = "0x8B3258")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x200020E")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x8B3260", Offset = "0x8B3260", VA = "0x8B3260")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x8B352C", Offset = "0x8B352C", VA = "0x8B352C")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x8B357C", Offset = "0x8B357C", VA = "0x8B357C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x8B35B4", Offset = "0x8B35B4", VA = "0x8B35B4")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200020F")]
	public class CAPI
	{
		[Token(Token = "0x2000210")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x4000D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x4000D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x4000D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[PreserveSig]
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x8B3614", Offset = "0x8B3614", VA = "0x8B3614")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x8B36A0", Offset = "0x8B36A0", VA = "0x8B36A0")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x8B38BC", Offset = "0x8B38BC", VA = "0x8B38BC")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x8B3994", Offset = "0x8B3994", VA = "0x8B3994")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x8B39F8", Offset = "0x8B39F8", VA = "0x8B39F8")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x8B3A60", Offset = "0x8B3A60", VA = "0x8B3A60")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x8B3ADC", Offset = "0x8B3ADC", VA = "0x8B3ADC")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x8B3C0C", Offset = "0x8B3C0C", VA = "0x8B3C0C")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x8B3C88", Offset = "0x8B3C88", VA = "0x8B3C88")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x8B3DB8", Offset = "0x8B3DB8", VA = "0x8B3DB8")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x8B3E34", Offset = "0x8B3E34", VA = "0x8B3E34")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x8B3EB0", Offset = "0x8B3EB0", VA = "0x8B3EB0")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x8B3F2C", Offset = "0x8B3F2C", VA = "0x8B3F2C")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x8B3FA8", Offset = "0x8B3FA8", VA = "0x8B3FA8")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x8B402C", Offset = "0x8B402C", VA = "0x8B402C")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x8B40B0", Offset = "0x8B40B0", VA = "0x8B40B0")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x8B4134", Offset = "0x8B4134", VA = "0x8B4134")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x8B41B0", Offset = "0x8B41B0", VA = "0x8B41B0")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x8B4234", Offset = "0x8B4234", VA = "0x8B4234")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x8B42B8", Offset = "0x8B42B8", VA = "0x8B42B8")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x8B433C", Offset = "0x8B433C", VA = "0x8B433C")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x8B43B8", Offset = "0x8B43B8", VA = "0x8B43B8")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x8B444C", Offset = "0x8B444C", VA = "0x8B444C")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x8B44B4", Offset = "0x8B44B4", VA = "0x8B44B4")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x8B4550", Offset = "0x8B4550", VA = "0x8B4550")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x8B4614", Offset = "0x8B4614", VA = "0x8B4614")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x8B46A0", Offset = "0x8B46A0", VA = "0x8B46A0")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x8B4724", Offset = "0x8B4724", VA = "0x8B4724")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x8B47A8", Offset = "0x8B47A8", VA = "0x8B47A8")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x8B4994", Offset = "0x8B4994", VA = "0x8B4994")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x8B4AF8", Offset = "0x8B4AF8", VA = "0x8B4AF8")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000B01")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x8B4B74", Offset = "0x8B4B74", VA = "0x8B4B74")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x8B4E08", Offset = "0x8B4E08", VA = "0x8B4E08")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x8B4E84", Offset = "0x8B4E84", VA = "0x8B4E84")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x8B4FE8", Offset = "0x8B4FE8", VA = "0x8B4FE8")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x8B5064", Offset = "0x8B5064", VA = "0x8B5064")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x8B51C8", Offset = "0x8B51C8", VA = "0x8B51C8")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x8B5244", Offset = "0x8B5244", VA = "0x8B5244")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x8B53A8", Offset = "0x8B53A8", VA = "0x8B53A8")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x8B5424", Offset = "0x8B5424", VA = "0x8B5424")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x8B5588", Offset = "0x8B5588", VA = "0x8B5588")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x8B5604", Offset = "0x8B5604", VA = "0x8B5604")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x8B5690", Offset = "0x8B5690", VA = "0x8B5690")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x8B570C", Offset = "0x8B570C", VA = "0x8B570C")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x8B58C4", Offset = "0x8B58C4", VA = "0x8B58C4")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x8B5A00", Offset = "0x8B5A00", VA = "0x8B5A00")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x8B5848", Offset = "0x8B5848", VA = "0x8B5848")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x8B5A7C", Offset = "0x8B5A7C", VA = "0x8B5A7C")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x8B5AF8", Offset = "0x8B5AF8", VA = "0x8B5AF8")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x8B5B7C", Offset = "0x8B5B7C", VA = "0x8B5B7C")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x8B5BF8", Offset = "0x8B5BF8", VA = "0x8B5BF8")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x8B5C7C", Offset = "0x8B5C7C", VA = "0x8B5C7C")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x8B5CF8", Offset = "0x8B5CF8", VA = "0x8B5CF8")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x8B5D74", Offset = "0x8B5D74", VA = "0x8B5D74")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x8B5FBC", Offset = "0x8B5FBC", VA = "0x8B5FBC")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x8B6040", Offset = "0x8B6040", VA = "0x8B6040")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x8B6254", Offset = "0x8B6254", VA = "0x8B6254")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x8B62E8", Offset = "0x8B62E8", VA = "0x8B62E8")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x8B641C", Offset = "0x8B641C", VA = "0x8B641C")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x8B6498", Offset = "0x8B6498", VA = "0x8B6498")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x8B6514", Offset = "0x8B6514", VA = "0x8B6514")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x8B664C", Offset = "0x8B664C", VA = "0x8B664C")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x8B66C8", Offset = "0x8B66C8", VA = "0x8B66C8")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x8B6800", Offset = "0x8B6800", VA = "0x8B6800")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x8B687C", Offset = "0x8B687C", VA = "0x8B687C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x8B6900", Offset = "0x8B6900", VA = "0x8B6900")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x8B6984", Offset = "0x8B6984", VA = "0x8B6984")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x8B6A08", Offset = "0x8B6A08", VA = "0x8B6A08")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x8B6A84", Offset = "0x8B6A84", VA = "0x8B6A84")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x8B6B08", Offset = "0x8B6B08", VA = "0x8B6B08")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x8B6B84", Offset = "0x8B6B84", VA = "0x8B6B84")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x8B6C00", Offset = "0x8B6C00", VA = "0x8B6C00")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x8B6CB0", Offset = "0x8B6CB0", VA = "0x8B6CB0")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x8B6D34", Offset = "0x8B6D34", VA = "0x8B6D34")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x8B6DB8", Offset = "0x8B6DB8", VA = "0x8B6DB8")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x8B6E34", Offset = "0x8B6E34", VA = "0x8B6E34")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x8B6EB0", Offset = "0x8B6EB0", VA = "0x8B6EB0")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x8B6F2C", Offset = "0x8B6F2C", VA = "0x8B6F2C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x8B6FC0", Offset = "0x8B6FC0", VA = "0x8B6FC0")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x8B704C", Offset = "0x8B704C", VA = "0x8B704C")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x8B70D8", Offset = "0x8B70D8", VA = "0x8B70D8")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x8B7164", Offset = "0x8B7164", VA = "0x8B7164")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x8B71F8", Offset = "0x8B71F8", VA = "0x8B71F8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x8B728C", Offset = "0x8B728C", VA = "0x8B728C")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x8B7308", Offset = "0x8B7308", VA = "0x8B7308")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x8B7384", Offset = "0x8B7384", VA = "0x8B7384")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x8B74BC", Offset = "0x8B74BC", VA = "0x8B74BC")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x8B7538", Offset = "0x8B7538", VA = "0x8B7538")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x8B7670", Offset = "0x8B7670", VA = "0x8B7670")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x8B76EC", Offset = "0x8B76EC", VA = "0x8B76EC")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x8B780C", Offset = "0x8B780C", VA = "0x8B780C")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x8B7888", Offset = "0x8B7888", VA = "0x8B7888")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x8B7B30", Offset = "0x8B7B30", VA = "0x8B7B30")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x8B7BB4", Offset = "0x8B7BB4", VA = "0x8B7BB4")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x8B7C30", Offset = "0x8B7C30", VA = "0x8B7C30")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x8B7CB4", Offset = "0x8B7CB4", VA = "0x8B7CB4")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x8B7D38", Offset = "0x8B7D38", VA = "0x8B7D38")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x8B7DBC", Offset = "0x8B7DBC", VA = "0x8B7DBC")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x8B7E58", Offset = "0x8B7E58", VA = "0x8B7E58")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x8B7EF4", Offset = "0x8B7EF4", VA = "0x8B7EF4")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x8B7F88", Offset = "0x8B7F88", VA = "0x8B7F88")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x8B8004", Offset = "0x8B8004", VA = "0x8B8004")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x8B8080", Offset = "0x8B8080", VA = "0x8B8080")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x8B80FC", Offset = "0x8B80FC", VA = "0x8B80FC")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x8B8178", Offset = "0x8B8178", VA = "0x8B8178")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x8B81F4", Offset = "0x8B81F4", VA = "0x8B81F4")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x8B8318", Offset = "0x8B8318", VA = "0x8B8318")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x8B83A4", Offset = "0x8B83A4", VA = "0x8B83A4")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x8B8420", Offset = "0x8B8420", VA = "0x8B8420")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x8B8474", Offset = "0x8B8474", VA = "0x8B8474")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x8B85A8", Offset = "0x8B85A8", VA = "0x8B85A8")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x8B862C", Offset = "0x8B862C", VA = "0x8B862C")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x8B86C0", Offset = "0x8B86C0", VA = "0x8B86C0")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x8B89F8", Offset = "0x8B89F8", VA = "0x8B89F8")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x8B8A74", Offset = "0x8B8A74", VA = "0x8B8A74")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x8B8B00", Offset = "0x8B8B00", VA = "0x8B8B00")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x8B9254", Offset = "0x8B9254", VA = "0x8B9254")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x8B35BC", Offset = "0x8B35BC", VA = "0x8B35BC")]
		[MonoPInvokeCallback(typeof(LoggingDelegate))]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x8B92D0", Offset = "0x8B92D0", VA = "0x8B92D0")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x8B9350", Offset = "0x8B9350", VA = "0x8B9350")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);
	}
}
namespace CurvedUI
{
	[Token(Token = "0x2000211")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x8B9584", Offset = "0x8B9584", VA = "0x8B9584")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x8B975C", Offset = "0x8B975C", VA = "0x8B975C")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x2000212")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x4000D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x4000D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x4000D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x4000D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController Instance;

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x8B9764", Offset = "0x8B9764", VA = "0x8B9764")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x8B97BC", Offset = "0x8B97BC", VA = "0x8B97BC")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x2000213")]
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[Token(Token = "0x4000D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Sensitivity;

		[Token(Token = "0x4000D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _oldMousePos;

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x8B97D4", Offset = "0x8B97D4", VA = "0x8B97D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x8B9830", Offset = "0x8B9830", VA = "0x8B9830")]
		public CUI_CameraRotationOnButtonHeld()
		{
		}
	}
	[Token(Token = "0x2000214")]
	public class CUI_ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x8B9840", Offset = "0x8B9840", VA = "0x8B9840")]
		public void ChangeColorToBlue()
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x8B98B4", Offset = "0x8B98B4", VA = "0x8B98B4")]
		public void ChangeColorToCyan()
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x8B9928", Offset = "0x8B9928", VA = "0x8B9928")]
		public void ChangeColorToWhite()
		{
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x8B999C", Offset = "0x8B999C", VA = "0x8B999C")]
		public CUI_ChangeColor()
		{
		}
	}
	[Token(Token = "0x2000215")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x4000D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x4000D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x4000D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x4000D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x4000D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x4000D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x8B99A4", Offset = "0x8B99A4", VA = "0x8B99A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x8B9A20", Offset = "0x8B9A20", VA = "0x8B9A20")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x8B9B70", Offset = "0x8B9B70", VA = "0x8B9B70", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x8B9C00", Offset = "0x8B9C00", VA = "0x8B9C00", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x8B9C84", Offset = "0x8B9C84", VA = "0x8B9C84")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x2000216")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x8B9C8C", Offset = "0x8B9C8C", VA = "0x8B9C8C", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x8B9FA4", Offset = "0x8B9FA4", VA = "0x8B9FA4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x8BA70C", Offset = "0x8BA70C", VA = "0x8BA70C", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x8B9DCC", Offset = "0x8B9DCC", VA = "0x8B9DCC")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x8BA774", Offset = "0x8BA774", VA = "0x8BA774")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x2000217")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x4000DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x8BA77C", Offset = "0x8BA77C", VA = "0x8BA77C", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x8BAA9C", Offset = "0x8BAA9C", VA = "0x8BAA9C", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x8BAAA0", Offset = "0x8BAAA0", VA = "0x8BAAA0", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x8BAB14", Offset = "0x8BAB14", VA = "0x8BAB14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x8BA8C4", Offset = "0x8BA8C4", VA = "0x8BA8C4")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x8BAC28", Offset = "0x8BAC28", VA = "0x8BAC28")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x2000218")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000219")]
		private sealed class <>c
		{
			[Token(Token = "0x4000DA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000DA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x8BB14C", Offset = "0x8BB14C", VA = "0x8BB14C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x8BB154", Offset = "0x8BB154", VA = "0x8BB154")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x4000DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x8BAC30", Offset = "0x8BAC30", VA = "0x8BAC30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x8BB0D4", Offset = "0x8BB0D4", VA = "0x8BB0D4")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x200021A")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x4000DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 lastMouse;

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x8BB210", Offset = "0x8BB210", VA = "0x8BB210")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x8BB26C", Offset = "0x8BB26C", VA = "0x8BB26C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x8BB3D8", Offset = "0x8BB3D8", VA = "0x8BB3D8")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x200021B")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x4000DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x4000DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x4000DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x4000DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x4000DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x8BB3EC", Offset = "0x8BB3EC", VA = "0x8BB3EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x8BB430", Offset = "0x8BB430", VA = "0x8BB430")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x8BB644", Offset = "0x8BB644", VA = "0x8BB644")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x200021C")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x8BB654", Offset = "0x8BB654", VA = "0x8BB654")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x8BB6AC", Offset = "0x8BB6AC", VA = "0x8BB6AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x8BBC40", Offset = "0x8BBC40", VA = "0x8BBC40")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x200021D")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x4000DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x4000DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x4000DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x8BBC48", Offset = "0x8BBC48", VA = "0x8BBC48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x8BBCC8", Offset = "0x8BBCC8", VA = "0x8BBCC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x8BBD9C", Offset = "0x8BBD9C", VA = "0x8BBD9C")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x200021E")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x4000DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x4000DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x4000DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x8BBDAC", Offset = "0x8BBDAC", VA = "0x8BBDAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x8BBE2C", Offset = "0x8BBE2C", VA = "0x8BBE2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x8BBEAC", Offset = "0x8BBEAC", VA = "0x8BBEAC")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x200021F")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x4000DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x8BBEC0", Offset = "0x8BBEC0", VA = "0x8BBEC0")]
		public void PickThis()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x8BC060", Offset = "0x8BC060", VA = "0x8BC060")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x2000220")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x8BC068", Offset = "0x8BC068", VA = "0x8BC068")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x8BC0C0", Offset = "0x8BC0C0", VA = "0x8BC0C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x8BC1A0", Offset = "0x8BC1A0", VA = "0x8BC1A0")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x2000221")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x4000DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x4000DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x4000DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x8BC1A8", Offset = "0x8BC1A8", VA = "0x8BC1A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x8BC528", Offset = "0x8BC528", VA = "0x8BC528")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x4000DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x4000DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x4000DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x8BC53C", Offset = "0x8BC53C", VA = "0x8BC53C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x8BC5AC", Offset = "0x8BC5AC", VA = "0x8BC5AC")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x2000223")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x2000224")]
		private enum ViveButton
		{
			[Token(Token = "0x4000DC2")]
			Trigger,
			[Token(Token = "0x4000DC3")]
			TouchpadTouch,
			[Token(Token = "0x4000DC4")]
			TouchpadPress,
			[Token(Token = "0x4000DC5")]
			Grip,
			[Token(Token = "0x4000DC6")]
			Menu
		}

		[Token(Token = "0x4000DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x4000DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x4000DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x8BC5B4", Offset = "0x8BC5B4", VA = "0x8BC5B4")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x2000225")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x4000DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x8BC5D4", Offset = "0x8BC5D4", VA = "0x8BC5D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x8BC5E0", Offset = "0x8BC5E0", VA = "0x8BC5E0")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x8BC5FC", Offset = "0x8BC5FC", VA = "0x8BC5FC")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x2000226")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x4000DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x8BC604", Offset = "0x8BC604", VA = "0x8BC604")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x8BC72C", Offset = "0x8BC72C", VA = "0x8BC72C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x8BC7B4", Offset = "0x8BC7B4", VA = "0x8BC7B4")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x2000227")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x4000DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x4000DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x4000DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x8BC7BC", Offset = "0x8BC7BC", VA = "0x8BC7BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x8BCAB0", Offset = "0x8BCAB0", VA = "0x8BCAB0")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x2000228")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x4000DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x8BCAB8", Offset = "0x8BCAB8", VA = "0x8BCAB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x8BCB1C", Offset = "0x8BCB1C", VA = "0x8BCB1C")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x2000229")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x8BCB74", Offset = "0x8BCB74", VA = "0x8BCB74")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x8BB628", Offset = "0x8BB628", VA = "0x8BB628")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x8BCBA4", Offset = "0x8BCBA4", VA = "0x8BCBA4")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x8BCBD0", Offset = "0x8BCBD0", VA = "0x8BCBD0")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x8BCBE4", Offset = "0x8BCBE4", VA = "0x8BCBE4")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x8BB0C4", Offset = "0x8BB0C4", VA = "0x8BB0C4")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x8BB0CC", Offset = "0x8BB0CC", VA = "0x8BB0CC")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x8BB0BC", Offset = "0x8BB0BC", VA = "0x8BB0BC")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x8BA360", Offset = "0x8BA360", VA = "0x8BA360")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000BA9")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000BAA")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x200022A")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x4000DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool autoSwitchHands;

		[Token(Token = "0x4000DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform leftHandOverride;

		[Token(Token = "0x4000DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform rightHandOverride;

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x8BCBEC", Offset = "0x8BCBEC", VA = "0x8BCBEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x8BCEF0", Offset = "0x8BCEF0", VA = "0x8BCEF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x8BCC54", Offset = "0x8BCC54", VA = "0x8BCC54")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x8BD0E0", Offset = "0x8BD0E0", VA = "0x8BD0E0")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x200022B")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x200022C")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000DD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000DDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x17000138")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BC1")]
				[Address(RVA = "0x8BDCC0", Offset = "0x8BDCC0", VA = "0x8BDCC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000139")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BC3")]
				[Address(RVA = "0x8BDD08", Offset = "0x8BDD08", VA = "0x8BDD08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x8BD8B0", Offset = "0x8BD8B0", VA = "0x8BD8B0")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x8BDBA4", Offset = "0x8BDBA4", VA = "0x8BDBA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x8BDBA8", Offset = "0x8BDBA8", VA = "0x8BDBA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x8BDCC8", Offset = "0x8BDCC8", VA = "0x8BDCC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x4000DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x4000DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x17000135")]
		public Color CaretColor
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x8BDB2C", Offset = "0x8BDB2C", VA = "0x8BDB2C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x8BDB38", Offset = "0x8BDB38", VA = "0x8BDB38")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x8BDB44", Offset = "0x8BDB44", VA = "0x8BDB44")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x8BDB50", Offset = "0x8BDB50", VA = "0x8BDB50")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x8BDB5C", Offset = "0x8BDB5C", VA = "0x8BDB5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x8BDB78", Offset = "0x8BDB78", VA = "0x8BDB78")]
			set
			{
			}
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x8BD0F0", Offset = "0x8BD0F0", VA = "0x8BD0F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x8BD148", Offset = "0x8BD148", VA = "0x8BD148")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x8BD40C", Offset = "0x8BD40C", VA = "0x8BD40C", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x8BD87C", Offset = "0x8BD87C", VA = "0x8BD87C", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x8BD808", Offset = "0x8BD808", VA = "0x8BD808")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x8BD4BC", Offset = "0x8BD4BC", VA = "0x8BD4BC")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x8BD158", Offset = "0x8BD158", VA = "0x8BD158")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x8BD8D8", Offset = "0x8BD8D8", VA = "0x8BD8D8")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x8BDB94", Offset = "0x8BDB94", VA = "0x8BDB94")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x200022D")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200022E")]
		private sealed class <>c
		{
			[Token(Token = "0x4000DDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000DDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__3_0;

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x8BE30C", Offset = "0x8BE30C", VA = "0x8BE30C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x8BE314", Offset = "0x8BE314", VA = "0x8BE314")]
			internal bool <Update>b__3_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x4000DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x4000DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x8BDD10", Offset = "0x8BDD10", VA = "0x8BDD10")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x8BE294", Offset = "0x8BE294", VA = "0x8BE294")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x200022F")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x4000DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x4000DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RaycastHit hitInfo;

		[Token(Token = "0x4000DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastResult result;

		[Token(Token = "0x1700013A")]
		public int CompoundEventMask
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x8BE750", Offset = "0x8BE750", VA = "0x8BE750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013B")]
		public override Camera eventCamera
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x8BE844", Offset = "0x8BE844", VA = "0x8BE844", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		public virtual int Depth
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x8BE900", Offset = "0x8BE900", VA = "0x8BE900", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013D")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x8BE9C4", Offset = "0x8BE9C4", VA = "0x8BE9C4", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x8BE3F4", Offset = "0x8BE3F4", VA = "0x8BE3F4")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x8BE404", Offset = "0x8BE404", VA = "0x8BE404", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x2000230")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x2000231")]
		private sealed class <>c
		{
			[Token(Token = "0x4000DF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000DF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__21_0;

			[Token(Token = "0x4000DFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__32_0;

			[Token(Token = "0x4000DFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x8C7674", Offset = "0x8C7674", VA = "0x8C7674")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x8C767C", Offset = "0x8C767C", VA = "0x8C767C")]
			internal bool <Update>b__21_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x8C7734", Offset = "0x8C7734", VA = "0x8C7734")]
			internal int <FlatRaycastAndSort>b__32_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x8C7788", Offset = "0x8C7788", VA = "0x8C7788")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x4000DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x4000DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x4000DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x4000DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x4000DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x4000DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x4000DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x4000DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x4000DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x4000DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x4000DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x4000DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x4000DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x4000DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x4000DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x4000DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x4000DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x4000DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x4000DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x1700013E")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x8BF8C0", Offset = "0x8BF8C0", VA = "0x8BF8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x8C6A6C", Offset = "0x8C6A6C", VA = "0x8C6A6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x8BE9CC", Offset = "0x8BE9CC", VA = "0x8BE9CC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x8BEC0C", Offset = "0x8BEC0C", VA = "0x8BEC0C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x8BF340", Offset = "0x8BF340", VA = "0x8BF340", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x8BF724", Offset = "0x8BF724", VA = "0x8BF724")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x8BF704", Offset = "0x8BF704", VA = "0x8BF704")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x8BFE28", Offset = "0x8BFE28", VA = "0x8BFE28", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x8C10B8", Offset = "0x8C10B8", VA = "0x8C10B8", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x8C1860", Offset = "0x8C1860", VA = "0x8C1860", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x8C1F34", Offset = "0x8C1F34", VA = "0x8C1F34", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x8C2530", Offset = "0x8C2530", VA = "0x8C2530", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x8C0AA4", Offset = "0x8C0AA4", VA = "0x8C0AA4")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x8C30BC", Offset = "0x8C30BC", VA = "0x8C30BC")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x8BEE5C", Offset = "0x8BEE5C", VA = "0x8BEE5C")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x8C50AC", Offset = "0x8C50AC", VA = "0x8C50AC")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x8C3630", Offset = "0x8C3630", VA = "0x8C3630")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x8C42C0", Offset = "0x8C42C0", VA = "0x8C42C0")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x8C5160", Offset = "0x8C5160", VA = "0x8C5160")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x8C6100", Offset = "0x8C6100", VA = "0x8C6100")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x8C1790", Offset = "0x8C1790", VA = "0x8C1790")]
		private LayerMask GetRaycastLayerMask()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x8C17F0", Offset = "0x8C17F0", VA = "0x8C17F0")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x8C614C", Offset = "0x8C614C", VA = "0x8C614C")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x8C617C", Offset = "0x8C617C", VA = "0x8C617C", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x8C0568", Offset = "0x8C0568", VA = "0x8C0568")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x8C6194", Offset = "0x8C6194", VA = "0x8C6194")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x8C67B8", Offset = "0x8C67B8", VA = "0x8C67B8")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x8C692C", Offset = "0x8C692C", VA = "0x8C692C")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x8BEC8C", Offset = "0x8BEC8C", VA = "0x8BEC8C")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x8C6A74", Offset = "0x8C6A74", VA = "0x8C6A74")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x8BB030", Offset = "0x8BB030", VA = "0x8BB030")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x8C6AA4", Offset = "0x8C6AA4", VA = "0x8C6AA4")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x8C6B80", Offset = "0x8C6B80", VA = "0x8C6B80")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x8BF920", Offset = "0x8BF920", VA = "0x8BF920")]
		public void Click()
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x8C5BBC", Offset = "0x8C5BBC", VA = "0x8C5BBC")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x8C70E4", Offset = "0x8C70E4", VA = "0x8C70E4")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x8C73D8", Offset = "0x8C73D8", VA = "0x8C73D8")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x2000232")]
	[RequireComponent(typeof(Canvas))]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x2000233")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x4000E0E")]
			CYLINDER,
			[Token(Token = "0x4000E0F")]
			RING,
			[Token(Token = "0x4000E10")]
			SPHERE,
			[Token(Token = "0x4000E11")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x4000DFC")]
		public const string Version = "3.3";

		[Token(Token = "0x4000DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x4000DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x4000DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x4000E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x4000E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x4000E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x4000E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x4000E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x4000E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x4000E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x4000E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x4000E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x4000E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x4000E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x4000E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x17000140")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x8C785C", Offset = "0x8C785C", VA = "0x8C785C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000141")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x8C89F8", Offset = "0x8C89F8", VA = "0x8C89F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000142")]
		public int Angle
		{
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x8C8A00", Offset = "0x8C8A00", VA = "0x8C8A00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x8C8A08", Offset = "0x8C8A08", VA = "0x8C8A08")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public float Quality
		{
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x8C8A1C", Offset = "0x8C8A1C", VA = "0x8C8A1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x8C8A24", Offset = "0x8C8A24", VA = "0x8C8A24")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x8C8A40", Offset = "0x8C8A40", VA = "0x8C8A40")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x8C8A48", Offset = "0x8C8A48", VA = "0x8C8A48")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public int VerticalAngle
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x8C8A68", Offset = "0x8C8A68", VA = "0x8C8A68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x8C8A70", Offset = "0x8C8A70", VA = "0x8C8A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public float RingFill
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x8C8A90", Offset = "0x8C8A90", VA = "0x8C8A90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x8B9740", Offset = "0x8B9740", VA = "0x8B9740")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public float SavedRadius
		{
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x8C8204", Offset = "0x8C8204", VA = "0x8C8204")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000148")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x8C8A98", Offset = "0x8C8A98", VA = "0x8C8A98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x8C8AA0", Offset = "0x8C8AA0", VA = "0x8C8AA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x8C8AC0", Offset = "0x8C8AC0", VA = "0x8C8AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x8C8AC8", Offset = "0x8C8AC8", VA = "0x8C8AC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public bool PreserveAspect
		{
			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x8C8AE8", Offset = "0x8C8AE8", VA = "0x8C8AE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x8C8AF0", Offset = "0x8C8AF0", VA = "0x8C8AF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public bool Interactable
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x8C8B10", Offset = "0x8C8B10", VA = "0x8C8B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x8C8B18", Offset = "0x8C8B18", VA = "0x8C8B18")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x8C8B24", Offset = "0x8C8B24", VA = "0x8C8B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x8C8B2C", Offset = "0x8C8B2C", VA = "0x8C8B2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x8C8B38", Offset = "0x8C8B38", VA = "0x8C8B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x8C8B40", Offset = "0x8C8B40", VA = "0x8C8B40")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		[Obsolete("Use RaycastLayerMask property instead.")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x8C8C0C", Offset = "0x8C8C0C", VA = "0x8C8C0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014F")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x8C8CB0", Offset = "0x8C8CB0", VA = "0x8C8CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000150")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x8C6768", Offset = "0x8C6768", VA = "0x8C6768")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x8C8E68", Offset = "0x8C8E68", VA = "0x8C8E68")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x8C9140", Offset = "0x8C9140", VA = "0x8C9140")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x8C91A0", Offset = "0x8C91A0", VA = "0x8C91A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public float GazeClickTimer
		{
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x8C9208", Offset = "0x8C9208", VA = "0x8C9208")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x8C9268", Offset = "0x8C9268", VA = "0x8C9268")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x8C92D8", Offset = "0x8C92D8", VA = "0x8C92D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x8C9338", Offset = "0x8C9338", VA = "0x8C9338")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x8C93A8", Offset = "0x8C93A8", VA = "0x8C93A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x8C77DC", Offset = "0x8C77DC", VA = "0x8C77DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x8C792C", Offset = "0x8C792C", VA = "0x8C792C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x8C7CB4", Offset = "0x8C7CB4", VA = "0x8C7CB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x8C7D54", Offset = "0x8C7D54", VA = "0x8C7D54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x8C7DF4", Offset = "0x8C7DF4", VA = "0x8C7DF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x8C7F14", Offset = "0x8C7F14", VA = "0x8C7F14")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x8C812C", Offset = "0x8C812C", VA = "0x8C812C")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x8C8228", Offset = "0x8C8228", VA = "0x8C8228")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x8C8300", Offset = "0x8C8300", VA = "0x8C8300")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x8C83D0", Offset = "0x8C83D0", VA = "0x8C83D0")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x8C8568", Offset = "0x8C8568", VA = "0x8C8568")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x8C88F4", Offset = "0x8C88F4", VA = "0x8C88F4")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x8BB840", Offset = "0x8BB840", VA = "0x8BB840")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x8BB9A8", Offset = "0x8BB9A8", VA = "0x8BB9A8")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x8BA558", Offset = "0x8BA558", VA = "0x8BA558")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x8BEAD4", Offset = "0x8BEAD4", VA = "0x8BEAD4")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x8C5914", Offset = "0x8C5914", VA = "0x8C5914")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x8C897C", Offset = "0x8C897C", VA = "0x8C897C")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x8C8C14", Offset = "0x8C8C14", VA = "0x8C8C14")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x8C8DB0", Offset = "0x8C8DB0", VA = "0x8C8DB0")]
		public void Click()
		{
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x8BE198", Offset = "0x8BE198", VA = "0x8BE198")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x8C8EC0", Offset = "0x8C8EC0", VA = "0x8C8EC0")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x8C9018", Offset = "0x8C9018", VA = "0x8C9018")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x8C9408", Offset = "0x8C9408", VA = "0x8C9408")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x2000234")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x4000E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool DoNotTesselate;

		[Token(Token = "0x4000E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x4000E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x4000E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x4000E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x4000E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x4000E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x4000E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x4000E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x4000E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x4000E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x4000E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x4000E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x4000E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x4000E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x4000E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x4000E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private Vector3 savedPos;

		[Token(Token = "0x4000E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Vector3 savedUp;

		[Token(Token = "0x4000E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Color savedColor;

		[Token(Token = "0x4000E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private Vector4 savedTextUV0;

		[Token(Token = "0x4000E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private float savedFill;

		[Token(Token = "0x4000E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x4000E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x4000E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x17000155")]
		private bool tesselationRequired
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x8C944C", Offset = "0x8C944C", VA = "0x8C944C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x8C9454", Offset = "0x8C9454", VA = "0x8C9454")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool TesselationRequired
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x8CC790", Offset = "0x8CC790", VA = "0x8CC790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x8B9BF4", Offset = "0x8B9BF4", VA = "0x8B9BF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool CurvingRequired
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x8CC798", Offset = "0x8CC798", VA = "0x8CC798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x8CC7A0", Offset = "0x8CC7A0", VA = "0x8CC7A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x8C9460", Offset = "0x8C9460", VA = "0x8C9460", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x8C9564", Offset = "0x8C9564", VA = "0x8C9564", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x8C9720", Offset = "0x8C9720", VA = "0x8C9720", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x8C9D98", Offset = "0x8C9D98", VA = "0x8C9D98", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x8C9F30", Offset = "0x8C9F30", VA = "0x8C9F30")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x8C9F3C", Offset = "0x8C9F3C", VA = "0x8C9F3C")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x8C9FC8", Offset = "0x8C9FC8", VA = "0x8C9FC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x8CA724", Offset = "0x8CA724", VA = "0x8CA724", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x8CB6E8", Offset = "0x8CB6E8", VA = "0x8CB6E8")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x8CADF0", Offset = "0x8CADF0", VA = "0x8CADF0")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x8CAED4", Offset = "0x8CAED4", VA = "0x8CAED4")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x8BA440", Offset = "0x8BA440", VA = "0x8BA440")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x8CB3E4", Offset = "0x8CB3E4", VA = "0x8CB3E4")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x8CB168", Offset = "0x8CB168", VA = "0x8CB168")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x8CBDDC", Offset = "0x8CBDDC", VA = "0x8CBDDC")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x8CB9C4", Offset = "0x8CB9C4", VA = "0x8CB9C4")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x8CC4E8", Offset = "0x8CC4E8", VA = "0x8CC4E8")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x8C8120", Offset = "0x8C8120", VA = "0x8C8120")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x8CC7AC", Offset = "0x8CC7AC", VA = "0x8CC7AC")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x2000235")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x8CD8F4", Offset = "0x8CD8F4", VA = "0x8CD8F4")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x2000236")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x4000E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x4000E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x4000E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x2000237")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x4000E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x4000E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x4000E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x4000E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x4000E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x4000E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x4000E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x4000E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x4000E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x4000E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x4000E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x4000E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x4000E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x4000E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x4000E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x8CD8FC", Offset = "0x8CD8FC", VA = "0x8CD8FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x8CD9AC", Offset = "0x8CD9AC", VA = "0x8CD9AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x8CDCD0", Offset = "0x8CDCD0", VA = "0x8CDCD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x8CDE4C", Offset = "0x8CDE4C", VA = "0x8CDE4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x8CDE58", Offset = "0x8CDE58", VA = "0x8CDE58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x8CE664", Offset = "0x8CE664", VA = "0x8CE664")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x8CEFF0", Offset = "0x8CEFF0", VA = "0x8CEFF0")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x8CE92C", Offset = "0x8CE92C", VA = "0x8CE92C")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x8CDB60", Offset = "0x8CDB60", VA = "0x8CDB60")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x8CEA8C", Offset = "0x8CEA8C", VA = "0x8CEA8C")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x8CE37C", Offset = "0x8CE37C", VA = "0x8CE37C")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x8CF034", Offset = "0x8CF034", VA = "0x8CF034")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x8CF050", Offset = "0x8CF050", VA = "0x8CF050")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x8CF05C", Offset = "0x8CF05C", VA = "0x8CF05C")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x2000238")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x2000239")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000E4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000E4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x1700015B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C71")]
				[Address(RVA = "0x8CFF6C", Offset = "0x8CFF6C", VA = "0x8CFF6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C73")]
				[Address(RVA = "0x8CFFB4", Offset = "0x8CFFB4", VA = "0x8CFFB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x8CFD10", Offset = "0x8CFD10", VA = "0x8CFD10")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x8CFE50", Offset = "0x8CFE50", VA = "0x8CFE50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x8CFE54", Offset = "0x8CFE54", VA = "0x8CFE54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x8CFF74", Offset = "0x8CFF74", VA = "0x8CFF74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x4000E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x17000158")]
		public Color CaretColor
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x8CFDE0", Offset = "0x8CFDE0", VA = "0x8CFDE0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x8CFDEC", Offset = "0x8CFDEC", VA = "0x8CFDEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x8CFDF8", Offset = "0x8CFDF8", VA = "0x8CFDF8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x8CFE04", Offset = "0x8CFE04", VA = "0x8CFE04")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x8CFE10", Offset = "0x8CFE10", VA = "0x8CFE10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x8CFE2C", Offset = "0x8CFE2C", VA = "0x8CFE2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x8CF134", Offset = "0x8CF134", VA = "0x8CF134")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x8CF5A8", Offset = "0x8CF5A8", VA = "0x8CF5A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x8CF84C", Offset = "0x8CF84C", VA = "0x8CF84C", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x8CFCDC", Offset = "0x8CFCDC", VA = "0x8CFCDC", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x8CFC68", Offset = "0x8CFC68", VA = "0x8CFC68")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x8CF8FC", Offset = "0x8CF8FC", VA = "0x8CF8FC")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x8CF5B8", Offset = "0x8CF5B8", VA = "0x8CF5B8")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x8CFD38", Offset = "0x8CFD38", VA = "0x8CFD38")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x8CF1E8", Offset = "0x8CF1E8", VA = "0x8CF1E8")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x8CFE48", Offset = "0x8CFE48", VA = "0x8CFE48")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x200023A")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x4000E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x4000E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x4000E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x4000E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x8CEC08", Offset = "0x8CEC08", VA = "0x8CEC08")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x8CFFBC", Offset = "0x8CFFBC", VA = "0x8CFFBC")]
		public CurvedUITMPSubmesh()
		{
		}
	}
}
namespace SciFiArsenal
{
	[Token(Token = "0x200023B")]
	public class SciFiButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiFireProjectile effectScript;

		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SciFiProjectileScript projectileScript;

		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x8CFFC4", Offset = "0x8CFFC4", VA = "0x8CFFC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x8D0180", Offset = "0x8D0180", VA = "0x8D0180")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x8D00CC", Offset = "0x8D00CC", VA = "0x8D00CC")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x8D01AC", Offset = "0x8D01AC", VA = "0x8D01AC")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x8D0284", Offset = "0x8D0284", VA = "0x8D0284")]
		public SciFiButtonScript()
		{
		}
	}
	[Token(Token = "0x200023C")]
	public class SciFiDragMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x4000E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x4000E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x8D028C", Offset = "0x8D028C", VA = "0x8D028C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x8D0358", Offset = "0x8D0358", VA = "0x8D0358")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x8D06D4", Offset = "0x8D06D4", VA = "0x8D06D4")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x8D0710", Offset = "0x8D0710", VA = "0x8D0710")]
		public SciFiDragMouseOrbit()
		{
		}
	}
	[Token(Token = "0x200023D")]
	public class SciFiFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RaycastHit hit;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] projectiles;

		[Token(Token = "0x4000E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform spawnPosition;

		[Token(Token = "0x4000E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int currentProjectile;

		[Token(Token = "0x4000E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float speed;

		[Token(Token = "0x4000E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SciFiButtonScript selectedProjectileButton;

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x8D072C", Offset = "0x8D072C", VA = "0x8D072C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x8D07A8", Offset = "0x8D07A8", VA = "0x8D07A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x8D0BF4", Offset = "0x8D0BF4", VA = "0x8D0BF4")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x8D0C24", Offset = "0x8D0C24", VA = "0x8D0C24")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x8D0C54", Offset = "0x8D0C54", VA = "0x8D0C54")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x8D0C5C", Offset = "0x8D0C5C", VA = "0x8D0C5C")]
		public SciFiFireProjectile()
		{
		}
	}
	[Token(Token = "0x200023E")]
	public class SciFiLoadSceneOnClick : MonoBehaviour
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x8D0C6C", Offset = "0x8D0C6C", VA = "0x8D0C6C")]
		public void LoadSceneSciFiProjectiles()
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x8D0CD4", Offset = "0x8D0CD4", VA = "0x8D0CD4")]
		public void LoadSceneSciFiBeamup()
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x8D0D3C", Offset = "0x8D0D3C", VA = "0x8D0D3C")]
		public void LoadSceneSciFiBuff()
		{
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x8D0DA4", Offset = "0x8D0DA4", VA = "0x8D0DA4")]
		public void LoadSceneSciFiFlamethrowers2()
		{
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x8D0E0C", Offset = "0x8D0E0C", VA = "0x8D0E0C")]
		public void LoadSceneSciFiQuestZone()
		{
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x8D0E74", Offset = "0x8D0E74", VA = "0x8D0E74")]
		public void LoadSceneSciFiLightjump()
		{
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x8D0EDC", Offset = "0x8D0EDC", VA = "0x8D0EDC")]
		public void LoadSceneSciFiLoot()
		{
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x8D0F44", Offset = "0x8D0F44", VA = "0x8D0F44")]
		public void LoadSceneSciFiBeams()
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x8D0FAC", Offset = "0x8D0FAC", VA = "0x8D0FAC")]
		public void LoadSceneSciFiPortals()
		{
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x8D1014", Offset = "0x8D1014", VA = "0x8D1014")]
		public void LoadSceneSciFiRegenerate()
		{
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x8D107C", Offset = "0x8D107C", VA = "0x8D107C")]
		public void LoadSceneSciFiShields()
		{
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x8D10E4", Offset = "0x8D10E4", VA = "0x8D10E4")]
		public void LoadSceneSciFiSwirlyAura()
		{
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x8D114C", Offset = "0x8D114C", VA = "0x8D114C")]
		public void LoadSceneSciFiWarpgates()
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x8D11B4", Offset = "0x8D11B4", VA = "0x8D11B4")]
		public void LoadSceneSciFiJetflame()
		{
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x8D121C", Offset = "0x8D121C", VA = "0x8D121C")]
		public void LoadSceneSciFiUltimateNova()
		{
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x8D1284", Offset = "0x8D1284", VA = "0x8D1284")]
		public void LoadSceneSciFiFire()
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x8D12EC", Offset = "0x8D12EC", VA = "0x8D12EC")]
		public SciFiLoadSceneOnClick()
		{
		}
	}
	[Token(Token = "0x200023F")]
	public class SciFiLoadSceneOnClick2 : MonoBehaviour
	{
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x8D12F4", Offset = "0x8D12F4", VA = "0x8D12F4")]
		public void LoadSceneSciFiUpdate1()
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x8D135C", Offset = "0x8D135C", VA = "0x8D135C")]
		public void LoadSceneSciFiUpdate2()
		{
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x8D13C4", Offset = "0x8D13C4", VA = "0x8D13C4")]
		public void LoadSceneSciFiUpdate3()
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x8D142C", Offset = "0x8D142C", VA = "0x8D142C")]
		public void LoadSceneSciFiUpdate4()
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x8D1494", Offset = "0x8D1494", VA = "0x8D1494")]
		public void LoadSceneSciFiUpdate5()
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x8D14FC", Offset = "0x8D14FC", VA = "0x8D14FC")]
		public void LoadSceneSciFiUpdate6()
		{
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x8D1564", Offset = "0x8D1564", VA = "0x8D1564")]
		public void LoadSceneSciFiUpdate7()
		{
		}

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x8D15CC", Offset = "0x8D15CC", VA = "0x8D15CC")]
		public SciFiLoadSceneOnClick2()
		{
		}
	}
	[Token(Token = "0x2000240")]
	public class SciFiLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000241")]
		private sealed class <EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000E72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000E73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SciFiLoopScript <>4__this;

			[Token(Token = "0x4000E74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x1700015D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CA5")]
				[Address(RVA = "0x8D189C", Offset = "0x8D189C", VA = "0x8D189C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CA7")]
				[Address(RVA = "0x8D18E4", Offset = "0x8D18E4", VA = "0x8D18E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x8D1698", Offset = "0x8D1698", VA = "0x8D1698")]
			[DebuggerHidden]
			public <EffectLoop>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x8D16D0", Offset = "0x8D16D0", VA = "0x8D16D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x8D16D4", Offset = "0x8D16D4", VA = "0x8D16D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x8D18A4", Offset = "0x8D18A4", VA = "0x8D18A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x8D15D4", Offset = "0x8D15D4", VA = "0x8D15D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x8D15D8", Offset = "0x8D15D8", VA = "0x8D15D8")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x8D1624", Offset = "0x8D1624", VA = "0x8D1624")]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x8D16C0", Offset = "0x8D16C0", VA = "0x8D16C0")]
		public SciFiLoopScript()
		{
		}
	}
	[Token(Token = "0x2000242")]
	public class SciFiProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x4000E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject impactParticle;

		[Token(Token = "0x4000E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectileParticle;

		[Token(Token = "0x4000E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4000E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] trailParticles;

		[Token(Token = "0x4000E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 impactNormal;

		[Token(Token = "0x4000E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasCollided;

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x8D18EC", Offset = "0x8D18EC", VA = "0x8D18EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x8D1BE8", Offset = "0x8D1BE8", VA = "0x8D1BE8")]
		private void OnCollisionEnter(Collision hit)
		{
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x8D2000", Offset = "0x8D2000", VA = "0x8D2000")]
		public SciFiProjectileScript()
		{
		}
	}
	[Token(Token = "0x2000243")]
	public class SciFiLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float life;

		[Token(Token = "0x4000E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x8D2008", Offset = "0x8D2008", VA = "0x8D2008")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x8D2124", Offset = "0x8D2124", VA = "0x8D2124")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x8D2260", Offset = "0x8D2260", VA = "0x8D2260")]
		public SciFiLightFade()
		{
		}
	}
	[Token(Token = "0x2000244")]
	public class SciFiRotation : MonoBehaviour
	{
		[Token(Token = "0x2000245")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000E82")]
			Local,
			[Token(Token = "0x4000E83")]
			World
		}

		[Token(Token = "0x4000E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x8D227C", Offset = "0x8D227C", VA = "0x8D227C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x8D2350", Offset = "0x8D2350", VA = "0x8D2350")]
		public SciFiRotation()
		{
		}
	}
}
