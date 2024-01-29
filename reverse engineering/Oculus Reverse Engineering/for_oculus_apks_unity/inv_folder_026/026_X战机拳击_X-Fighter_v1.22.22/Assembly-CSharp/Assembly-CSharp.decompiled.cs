using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using AmazingAssets.AdvancedDissolve;
using Il2CppDummyDll;
using NAudio.Wave;
using Oculus.Platform;
using Oculus.Platform.Models;
using Pico.Platform;
using Pico.Platform.Models;
using RhythmTool;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations.Rigging;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public class Section
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x9B5FE0", Offset = "0x9B5FE0", VA = "0x9B5FE0")]
		public Section()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x9B5FD8", Offset = "0x9B5FD8", VA = "0x9B5FD8")]
	public Readme()
	{
	}
}
[Token(Token = "0x2000004")]
public class mParent : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	private enum Mode
	{
		[Token(Token = "0x400000C")]
		Idle,
		[Token(Token = "0x400000D")]
		Ground,
		[Token(Token = "0x400000E")]
		Hand,
		[Token(Token = "0x400000F")]
		Back
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mParentCon;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mode m_Mode;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x9B5FE8", Offset = "0x9B5FE8", VA = "0x9B5FE8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9B6124", Offset = "0x9B6124", VA = "0x9B6124")]
	public void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9B6198", Offset = "0x9B6198", VA = "0x9B6198")]
	public void hand()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9B620C", Offset = "0x9B620C", VA = "0x9B620C")]
	public void back()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9B6280", Offset = "0x9B6280", VA = "0x9B6280")]
	public mParent()
	{
	}
}
[Token(Token = "0x2000006")]
public class ImporterExample : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	private sealed class <Import>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ImporterExample <>4__this;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x9B6768", Offset = "0x9B6768", VA = "0x9B6768", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x9B67B0", Offset = "0x9B67B0", VA = "0x9B67B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x9B64E4", Offset = "0x9B64E4", VA = "0x9B64E4")]
		[DebuggerHidden]
		public <Import>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x9B6514", Offset = "0x9B6514", VA = "0x9B6514", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x9B6518", Offset = "0x9B6518", VA = "0x9B6518", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x9B6770", Offset = "0x9B6770", VA = "0x9B6770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Browser browser;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioImporter importer;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource audioSource;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9B6288", Offset = "0x9B6288", VA = "0x9B6288")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9B63C0", Offset = "0x9B63C0", VA = "0x9B63C0")]
	private void OnFileSelected(string path)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9B6454", Offset = "0x9B6454", VA = "0x9B6454")]
	private IEnumerator Import(string path)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9B650C", Offset = "0x9B650C", VA = "0x9B650C")]
	public ImporterExample()
	{
	}
}
[Token(Token = "0x2000008")]
public abstract class AudioImporter : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Uri <uri>k__BackingField;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioClip <audioClip>k__BackingField;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float <progress>k__BackingField;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool <isDone>k__BackingField;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool <isInitialized>k__BackingField;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool <isError>k__BackingField;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string <error>k__BackingField;

	[Token(Token = "0x17000003")]
	public Uri uri
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x9B6918", Offset = "0x9B6918", VA = "0x9B6918")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9B6920", Offset = "0x9B6920", VA = "0x9B6920")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public virtual AudioClip audioClip
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x9B6928", Offset = "0x9B6928", VA = "0x9B6928", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x9B6930", Offset = "0x9B6930", VA = "0x9B6930", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public virtual float progress
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9B6938", Offset = "0x9B6938", VA = "0x9B6938", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x9B6940", Offset = "0x9B6940", VA = "0x9B6940", Slot = "7")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public virtual bool isDone
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9B6948", Offset = "0x9B6948", VA = "0x9B6948", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9B6950", Offset = "0x9B6950", VA = "0x9B6950", Slot = "9")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public virtual bool isInitialized
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x9B695C", Offset = "0x9B695C", VA = "0x9B695C", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x9B6964", Offset = "0x9B6964", VA = "0x9B6964", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual bool isError
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x9B6970", Offset = "0x9B6970", VA = "0x9B6970", Slot = "12")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9B6978", Offset = "0x9B6978", VA = "0x9B6978", Slot = "13")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public virtual string error
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9B6984", Offset = "0x9B6984", VA = "0x9B6984", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9B698C", Offset = "0x9B698C", VA = "0x9B698C", Slot = "15")]
		protected set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<AudioClip> Loaded
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9B67B8", Offset = "0x9B67B8", VA = "0x9B67B8")]
		add
		{
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9B6868", Offset = "0x9B6868", VA = "0x9B6868")]
		remove
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9B667C", Offset = "0x9B667C", VA = "0x9B667C")]
	public void Import(string uri)
	{
	}

	[Token(Token = "0x6000023")]
	public abstract void Abort();

	[Token(Token = "0x6000024")]
	protected abstract void Import();

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9B6994", Offset = "0x9B6994", VA = "0x9B6994")]
	protected void OnLoaded()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9B69D0", Offset = "0x9B69D0", VA = "0x9B69D0")]
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
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Browser <>4__this;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x9B7C2C", Offset = "0x9B7C2C", VA = "0x9B7C2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x9B7C74", Offset = "0x9B7C74", VA = "0x9B7C74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9B73D0", Offset = "0x9B73D0", VA = "0x9B73D0")]
		[DebuggerHidden]
		public <refreshFiles>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x9B7B70", Offset = "0x9B7B70", VA = "0x9B7B70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x9B7B74", Offset = "0x9B7B74", VA = "0x9B7B74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x9B7C34", Offset = "0x9B7C34", VA = "0x9B7C34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	private sealed class <refreshDirectories>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Browser <>4__this;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x9B7D38", Offset = "0x9B7D38", VA = "0x9B7D38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x9B7D80", Offset = "0x9B7D80", VA = "0x9B7D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x9B73F8", Offset = "0x9B73F8", VA = "0x9B73F8")]
		[DebuggerHidden]
		public <refreshDirectories>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x9B7C7C", Offset = "0x9B7C7C", VA = "0x9B7C7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x9B7C80", Offset = "0x9B7C80", VA = "0x9B7C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x9B7D40", Offset = "0x9B7D40", VA = "0x9B7D40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Browser <>4__this;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x9B7654", Offset = "0x9B7654", VA = "0x9B7654")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x9B7D88", Offset = "0x9B7D88", VA = "0x9B7D88")]
		internal void <AddFileItem>b__0()
		{
		}
	}

	[Token(Token = "0x200000D")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Browser <>4__this;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x9B78A8", Offset = "0x9B78A8", VA = "0x9B78A8")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9B7DA8", Offset = "0x9B7DA8", VA = "0x9B7DA8")]
		internal void <AddDirectoryItem>b__0()
		{
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> extensions;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject listItemPrefab;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject upButton;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ScrollRect scrollRect;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject folderPanel;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject filePanel;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string currentDirectory;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] drives;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<string> directories;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<string> files;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool selectDrive;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool scrolling;

	[Token(Token = "0x14000002")]
	public event Action<string> FileSelected
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9B6310", Offset = "0x9B6310", VA = "0x9B6310")]
		add
		{
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9B69D8", Offset = "0x9B69D8", VA = "0x9B69D8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9B6A88", Offset = "0x9B6A88", VA = "0x9B6A88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9B6F74", Offset = "0x9B6F74", VA = "0x9B6F74")]
	public void Up()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9B6BD0", Offset = "0x9B6BD0", VA = "0x9B6BD0")]
	private void BuildContent()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9B703C", Offset = "0x9B703C", VA = "0x9B703C")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9B7280", Offset = "0x9B7280", VA = "0x9B7280")]
	private void OnFileSelected(int index)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9B7318", Offset = "0x9B7318", VA = "0x9B7318")]
	private void OnDirectorySelected(int index)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9B720C", Offset = "0x9B720C", VA = "0x9B720C")]
	private IEnumerator refreshFiles()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9B7198", Offset = "0x9B7198", VA = "0x9B7198")]
	private IEnumerator refreshDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9B7420", Offset = "0x9B7420", VA = "0x9B7420")]
	private void AddFileItem(int index)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9B765C", Offset = "0x9B765C", VA = "0x9B765C")]
	private void AddDirectoryItem(int index)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9B78B0", Offset = "0x9B78B0", VA = "0x9B78B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9B7B68", Offset = "0x9B7B68", VA = "0x9B7B68")]
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
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <lengthSamples>k__BackingField;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <channels>k__BackingField;

		[Token(Token = "0x1700000E")]
		public int lengthSamples
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x9B88BC", Offset = "0x9B88BC", VA = "0x9B88BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x9B88C4", Offset = "0x9B88C4", VA = "0x9B88C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int sampleRate
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x9B88CC", Offset = "0x9B88CC", VA = "0x9B88CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x9B88D4", Offset = "0x9B88D4", VA = "0x9B88D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int channels
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x9B88DC", Offset = "0x9B88DC", VA = "0x9B88DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x9B88E4", Offset = "0x9B88E4", VA = "0x9B88E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x9B88EC", Offset = "0x9B88EC", VA = "0x9B88EC")]
		public AudioInfo(int lengthSamples, int sampleRate, int channels)
		{
		}
	}

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioInfo info;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int bufferSize;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] buffer;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AutoResetEvent waitForMainThread;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Thread import;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int index;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool abort;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Queue<Action> executionQueue;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private object _lock;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x9B7DC8", Offset = "0x9B7DC8", VA = "0x9B7DC8", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x9B7F7C", Offset = "0x9B7F7C", VA = "0x9B7F7C", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9B8104", Offset = "0x9B8104", VA = "0x9B8104")]
	private void DoImport()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x9B8334", Offset = "0x9B8334", VA = "0x9B8334")]
	private void Decode()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x9B8494", Offset = "0x9B8494", VA = "0x9B8494")]
	private void CreateClip()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9B854C", Offset = "0x9B854C", VA = "0x9B854C")]
	private void SetData()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9B867C", Offset = "0x9B867C", VA = "0x9B867C")]
	protected void OnError(string error)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9B8220", Offset = "0x9B8220", VA = "0x9B8220")]
	private void Dispatch(Action action)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9B86C4", Offset = "0x9B86C4", VA = "0x9B86C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	protected abstract void Initialize();

	[Token(Token = "0x600004F")]
	protected abstract void Cleanup();

	[Token(Token = "0x6000050")]
	protected abstract int GetSamples(float[] buffer, int offset, int count);

	[Token(Token = "0x6000051")]
	protected abstract AudioInfo GetInfo();

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9B87F8", Offset = "0x9B87F8", VA = "0x9B87F8")]
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
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MobileImporter <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x9B8C6C", Offset = "0x9B8C6C", VA = "0x9B8C6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x9B8CB4", Offset = "0x9B8CB4", VA = "0x9B8CB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x9B8B5C", Offset = "0x9B8B5C", VA = "0x9B8B5C")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x9B8B8C", Offset = "0x9B8B8C", VA = "0x9B8B8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x9B8B90", Offset = "0x9B8B90", VA = "0x9B8B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x9B8C74", Offset = "0x9B8C74", VA = "0x9B8C74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AsyncOperation operation;

	[Token(Token = "0x17000011")]
	public override float progress
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x9B8928", Offset = "0x9B8928", VA = "0x9B8928", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public override bool isDone
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x9B8940", Offset = "0x9B8940", VA = "0x9B8940", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public override bool isInitialized
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x9B8954", Offset = "0x9B8954", VA = "0x9B8954", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public override bool isError
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x9B8960", Offset = "0x9B8960", VA = "0x9B8960", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public override string error
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x9B89A0", Offset = "0x9B89A0", VA = "0x9B89A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9B8A04", Offset = "0x9B8A04", VA = "0x9B8A04", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9B8A68", Offset = "0x9B8A68", VA = "0x9B8A68", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9B8AE8", Offset = "0x9B8AE8", VA = "0x9B8AE8")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9B8B84", Offset = "0x9B8B84", VA = "0x9B8B84")]
	public MobileImporter()
	{
	}
}
[Token(Token = "0x2000012")]
public class NAudioImporter : DecoderImporter
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Mp3FileReader reader;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ISampleProvider sampleProvider;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9B8CBC", Offset = "0x9B8CBC", VA = "0x9B8CBC", Slot = "18")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9B8EBC", Offset = "0x9B8EBC", VA = "0x9B8EBC", Slot = "19")]
	protected override void Cleanup()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9B8F04", Offset = "0x9B8F04", VA = "0x9B8F04", Slot = "21")]
	protected override AudioInfo GetInfo()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9B8FD0", Offset = "0x9B8FD0", VA = "0x9B8FD0", Slot = "20")]
	protected override int GetSamples(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9B9090", Offset = "0x9B9090", VA = "0x9B9090")]
	public NAudioImporter()
	{
	}
}
[Token(Token = "0x2000013")]
public class AchievementsManager : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	public class Achievement
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsAchieved;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button3D Icon;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Counter;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x9BCD38", Offset = "0x9BCD38", VA = "0x9BCD38")]
		public Achievement(string name)
		{
		}
	}

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text debugText;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AchievementsManager instance;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool officialTrack;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text achiveName;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text achiveDesc;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<string> collectedAchives;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Achievement GreenEnergy;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Achievement Untouchable;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Achievement OneArmedBandit;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Achievement WithoutAMiss;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Achievement Score5000;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Achievement Score10000;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Achievement Speed20;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Achievement Speed25;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static Achievement L5R5;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static Achievement Hit5In1;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static Achievement Headache;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static Achievement HiMed;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Achievement FirstBlood;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Achievement MP3;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static Achievement Customer;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static Achievement Longplay;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static Achievement Combo;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static Achievement TenMilions;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static Achievement Minutes88;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static Achievement LeMans;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static List<Achievement> AllAchievements;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool lastHandL5R5;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int noChangesL5R5;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] hitTimes;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int noHeadache;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Game game;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CommonVR vr;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x9B9094", Offset = "0x9B9094", VA = "0x9B9094")]
	private void CheckGreenEnergy()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x9B92C4", Offset = "0x9B92C4", VA = "0x9B92C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9B92C8", Offset = "0x9B92C8", VA = "0x9B92C8")]
	private void CheckUntouchable()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9B9398", Offset = "0x9B9398", VA = "0x9B9398")]
	private void CheckHiMed(string track_vid)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x9B94DC", Offset = "0x9B94DC", VA = "0x9B94DC")]
	private void CheckOneArmedBandit(string track_vid)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9B9620", Offset = "0x9B9620", VA = "0x9B9620")]
	private void CheckWithoutAMiss(string track_vid)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9B9764", Offset = "0x9B9764", VA = "0x9B9764")]
	private void CheckFirstBlood()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9B9808", Offset = "0x9B9808", VA = "0x9B9808")]
	private void CheckMP3()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9B98D8", Offset = "0x9B98D8", VA = "0x9B98D8")]
	private void CheckCustomer()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9B99AC", Offset = "0x9B99AC", VA = "0x9B99AC")]
	public void OnGameFinish()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9B9C2C", Offset = "0x9B9C2C", VA = "0x9B9C2C")]
	public void OnPlaylistFinish()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9B9CD0", Offset = "0x9B9CD0", VA = "0x9B9CD0")]
	public void OnFullCombo()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x9B9D74", Offset = "0x9B9D74", VA = "0x9B9D74")]
	private void CheckScore5000(int score)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9B9E3C", Offset = "0x9B9E3C", VA = "0x9B9E3C")]
	private void CheckScore10000(int score)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9B9F04", Offset = "0x9B9F04", VA = "0x9B9F04")]
	private void CheckSpeed20(float speed)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x9B9FC4", Offset = "0x9B9FC4", VA = "0x9B9FC4")]
	private void CheckSpeed25(float speed)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9BA084", Offset = "0x9BA084", VA = "0x9BA084")]
	private void CheckL5R5(bool right_hand)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x9BA174", Offset = "0x9BA174", VA = "0x9BA174")]
	private void CheckHit5In1()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x9BA2A0", Offset = "0x9BA2A0", VA = "0x9BA2A0")]
	private void CheckHeadache(Game.HitTarget target)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9BA378", Offset = "0x9BA378", VA = "0x9BA378")]
	public void OnHit(float speed, Game.HitTarget target, bool right_hand, int score)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x9BA404", Offset = "0x9BA404", VA = "0x9BA404")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x9BA46C", Offset = "0x9BA46C", VA = "0x9BA46C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x9B9190", Offset = "0x9B9190", VA = "0x9B9190")]
	private void OnAchievement(string achievement_name)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x9B9BB8", Offset = "0x9B9BB8", VA = "0x9B9BB8")]
	private void AchievementCounter(string achievement_name, int count)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x9BA630", Offset = "0x9BA630", VA = "0x9BA630")]
	public void CheckForAchievements()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x9BAAD8", Offset = "0x9BAAD8", VA = "0x9BAAD8")]
	private void RefreshIcons()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x9BAF90", Offset = "0x9BAF90", VA = "0x9BAF90")]
	public List<Vector3> GeneratePoints(int N, float MAX_X, float MAX_Y)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9BA8C4", Offset = "0x9BA8C4", VA = "0x9BA8C4")]
	private void CollectAchievementsToCheck(ref List<string> to_get)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9BB680", Offset = "0x9BB680", VA = "0x9BB680")]
	private void SetupAchievementByName(string name, int count, bool unlocked)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x9BB7F4", Offset = "0x9BB7F4", VA = "0x9BB7F4")]
	public void OnSelectIcon(int idx)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x9BBB80", Offset = "0x9BBB80", VA = "0x9BBB80")]
	public void GenerateIconsOnSummary(StatsSummary summary)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9BBEC0", Offset = "0x9BBEC0", VA = "0x9BBEC0")]
	public AchievementsManager()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9BCD84", Offset = "0x9BCD84", VA = "0x9BCD84")]
	private void <CheckForAchievements>b__58_0(Oculus.Platform.Message<Oculus.Platform.Models.AchievementProgressList> msg)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9BD02C", Offset = "0x9BD02C", VA = "0x9BD02C")]
	private void <CheckForAchievements>b__58_1(Pico.Platform.Message<Pico.Platform.Models.AchievementProgressList> msg)
	{
	}
}
[Token(Token = "0x2000015")]
public class Activator : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToActivate;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objectsToDeactivate;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator[] animators;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string[] anims;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MonoBehaviour[] componentsToActivate;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MonoBehaviour[] componentsToDeactivate;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip sound;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x9BD190", Offset = "0x9BD190", VA = "0x9BD190")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9BD334", Offset = "0x9BD334", VA = "0x9BD334")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x9BD340", Offset = "0x9BD340", VA = "0x9BD340")]
	public Activator()
	{
	}
}
[Token(Token = "0x2000016")]
public class AimOnCamera : MonoBehaviour
{
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x9BD348", Offset = "0x9BD348", VA = "0x9BD348")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x9BD3D4", Offset = "0x9BD3D4", VA = "0x9BD3D4")]
	public AimOnCamera()
	{
	}
}
[Token(Token = "0x2000017")]
public class ArmsCorrection : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	public enum Mode
	{
		[Token(Token = "0x4000082")]
		None,
		[Token(Token = "0x4000083")]
		Up,
		[Token(Token = "0x4000084")]
		Down
	}

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mode mode;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TwoBoneIKConstraint ikArmsL;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TwoBoneIKConstraint ikArmsR;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform headTransform;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform spineTransform;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 ikPosHeadL;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 ikPosHeadR;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 ikPosSpineL;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 ikPosSpineR;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float weight;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x9BD3DC", Offset = "0x9BD3DC", VA = "0x9BD3DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x9BD594", Offset = "0x9BD594", VA = "0x9BD594")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x9BD8D4", Offset = "0x9BD8D4", VA = "0x9BD8D4")]
	public ArmsCorrection()
	{
	}
}
[Token(Token = "0x2000019")]
public class Avatar : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR vr;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game game;

	[Token(Token = "0x4000087")]
	private const float ARM_ACTIVATOR_PERIOD = 0.25f;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform headDetector;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform bodyDetector;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform handRDetector;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform handLDetector;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform guardDetector;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform armRDetector;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform armLDetector;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform upperarmRDetector;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform upperarmLDetector;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform handRDetectorCopy;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform handLDetectorCopy;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform armRDetectorCopy;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform armLDetectorCopy;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject markerL;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject markerR;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject elbowVisL;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject elbowVisR;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material hitMat;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject hitEffect;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject blockEffect;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float hitEffectProgress;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float hitMatAlpha;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float hitMatColor;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Material guardMat;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float guardMatColor;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public float armActivatorL;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float armActivatorR;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject centerMarker;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Vector3 avgPlayerPos;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector3 <playerCenter>k__BackingField;

	[Token(Token = "0x17000018")]
	public Vector3 playerCenter
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9BF820", Offset = "0x9BF820", VA = "0x9BF820")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9BF830", Offset = "0x9BF830", VA = "0x9BF830")]
		set
		{
		}
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x9BD8DC", Offset = "0x9BD8DC", VA = "0x9BD8DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9BD9A0", Offset = "0x9BD9A0", VA = "0x9BD9A0")]
	private void UpdateGuard()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x9BE22C", Offset = "0x9BE22C", VA = "0x9BE22C")]
	private void UpdateCopies()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x9BE364", Offset = "0x9BE364", VA = "0x9BE364")]
	private void UpdateArm(ref Vector3 cam_pos, Vector3 body_left, Vector3 body_dir, Vector3 hand_pos, Vector3 hand_fwd, Vector3 hand_up, bool isLeft, Transform elbowVis)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x9BEE14", Offset = "0x9BEE14", VA = "0x9BEE14")]
	private void UpdateArms()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x9BF4F0", Offset = "0x9BF4F0", VA = "0x9BF4F0")]
	private void UpdateDetectorTransforms()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x9BF840", Offset = "0x9BF840", VA = "0x9BF840")]
	private void UpdatePlayerCenter()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x9BFB00", Offset = "0x9BFB00", VA = "0x9BFB00")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9BFB20", Offset = "0x9BFB20", VA = "0x9BFB20")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x9BFCDC", Offset = "0x9BFCDC", VA = "0x9BFCDC")]
	public void OnHit(Detector detector, bool left, bool kick)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x9BFED8", Offset = "0x9BFED8", VA = "0x9BFED8")]
	public void OnBlock(Collider other, Detector detector)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x9C04C8", Offset = "0x9C04C8", VA = "0x9C04C8")]
	public Avatar()
	{
	}
}
[Token(Token = "0x200001A")]
public class BagEnemy : MonoBehaviour, IEnemy
{
	[Token(Token = "0x200001B")]
	public enum OnHitBeh
	{
		[Token(Token = "0x4000104")]
		NoReaction,
		[Token(Token = "0x4000105")]
		TwoNoneOne,
		[Token(Token = "0x4000106")]
		TwoNoneTwo,
		[Token(Token = "0x4000107")]
		TwoNoneNone,
		[Token(Token = "0x4000108")]
		OneNoneNone,
		[Token(Token = "0x4000109")]
		OneNoneTwo,
		[Token(Token = "0x400010A")]
		OneNoneOne
	}

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnHitBeh onHitBehaviour;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool noRotate;

	[Token(Token = "0x40000A8")]
	private const float HAND_ON_TIME = 0.3f;

	[Token(Token = "0x40000A9")]
	private const float SNAP_TO_BASE_PERIOD = 0.4f;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float hitEffectPower;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] atacksLen;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] atacksHitFrame;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float[] atacksRatio;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] attackSeq;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int[] berserkerkSeq;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int[] complicatedSeq;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Game game;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject mainMesh;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 animatorBasePos;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion animatorBaseRot;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool duringAttackAnim;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	private bool rightHandAttack;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
	private bool leftHandAttack;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8F")]
	private bool rightLegAttack;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool leftLegAttack;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float duringMovementAnim;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float lifeTime;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SkinnedMeshRenderer[] bodyParts;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int[] matIndexes;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool mirrored;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float movementLayerWeight;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ArmsCorrection armsCorrection;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float handOffLayerWeight;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float handOffTime;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float handOffPower;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public bool handsOffDuringCombo;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ComboMarker[] comboMarkers;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource audioSource;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Vector3 hudOffset;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool duringBerserker;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float comboLayerWeight;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float comboLayerPower;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float baseScale;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float baseDist;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float minDistToPlayer;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float maxDistToPlayer;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float offsetToPlayerDuringAttack;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float animatedOffsetDuringAttack;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float rotationCorrection;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public float ANIM_IDLE_SPEED;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ComboMarker finisher;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject[] toHideDuringDissolve;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 basePos;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float timeToNormalSpeed;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float nextAttackTime;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float nextAttackMaxLen;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Game.EEventType nextAttackType;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float attackTime;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private float attackMaxLen;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private Game.EEventType attackType;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float handsOffWindow;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int attackIDX;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool canBlockDuringCombo;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private int headBonus;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int upBodyBonus;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private int downBodyBonus;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Material[] mainMats;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Material[] appearMats;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Material[] finisherMats;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Material shadowMat;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float beatHighlight;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Material[] beatHighMats;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool appearMatChanged;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float dissolve;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Material hitMaterial;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector3 lastHitPos;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private Color lastHitColor;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Transform lastHitTransform;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float lastHitProgress;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private float lastHitRadius;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Vector3 prevHitPos;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private Color prevHitColor;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float prevHitProgress;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Transform prevHitTransform;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private float prevHitRadius;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private float timeToPlayerDodge;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public bool dead;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private float timeToDisperse;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private float timeToDelete;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private Game.HitTarget prevHitTarget;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float snapToBasePosDuringIdleTime;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float snapRotataionTempo;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool outOfRingDirLeft;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private float timeToChnageOutOfDir;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float toCloseTime;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public bool flyingBeh;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Vector3 bodyPenetrationInfluence;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9C052C", Offset = "0x9C052C", VA = "0x9C052C")]
	public float GetBaseDist()
	{
		return default(float);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x9C053C", Offset = "0x9C053C", VA = "0x9C053C")]
	public float GetMinDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x9C054C", Offset = "0x9C054C", VA = "0x9C054C")]
	public float GetMaxDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x9C055C", Offset = "0x9C055C", VA = "0x9C055C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x9C0DB8", Offset = "0x9C0DB8", VA = "0x9C0DB8")]
	private void UpdateHandsOff()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9C1068", Offset = "0x9C1068", VA = "0x9C1068")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x9C1254", Offset = "0x9C1254", VA = "0x9C1254")]
	private void UpdateDead()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9C12E8", Offset = "0x9C12E8", VA = "0x9C12E8")]
	private void UpdateOffsetDuringAttack()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9C131C", Offset = "0x9C131C", VA = "0x9C131C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x9C1A3C", Offset = "0x9C1A3C", VA = "0x9C1A3C")]
	private void UpdateAnimTransition()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9C36A0", Offset = "0x9C36A0", VA = "0x9C36A0", Slot = "11")]
	public bool IsDuringAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9C36D8", Offset = "0x9C36D8", VA = "0x9C36D8", Slot = "12")]
	public bool IsLeftHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9C36F0", Offset = "0x9C36F0", VA = "0x9C36F0", Slot = "13")]
	public bool IsRightHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9C3708", Offset = "0x9C3708", VA = "0x9C3708", Slot = "14")]
	public bool IsRightLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9C3720", Offset = "0x9C3720", VA = "0x9C3720", Slot = "15")]
	public bool IsLeftLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x9C3738", Offset = "0x9C3738", VA = "0x9C3738", Slot = "22")]
	public void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x9C37F4", Offset = "0x9C37F4", VA = "0x9C37F4")]
	public void SynchronizeIdleToMusic(float time_attack)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x9C3904", Offset = "0x9C3904", VA = "0x9C3904")]
	private void UploadNextAttackFromOrder()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x9C3970", Offset = "0x9C3970", VA = "0x9C3970")]
	private int SelectAttactIDXFromSequence()
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9C3A1C", Offset = "0x9C3A1C", VA = "0x9C3A1C")]
	private float GetTimeToAttack()
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9C154C", Offset = "0x9C154C", VA = "0x9C154C")]
	private void UpdateNextAttack()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x9C3A60", Offset = "0x9C3A60", VA = "0x9C3A60", Slot = "23")]
	public void Strafe(bool left, float max_move_length)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x9C3B50", Offset = "0x9C3B50", VA = "0x9C3B50", Slot = "21")]
	public void PlayEmot()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x9C3BC8", Offset = "0x9C3BC8", VA = "0x9C3BC8")]
	private void BlockDown(float time = 2f)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x9C3CD4", Offset = "0x9C3CD4", VA = "0x9C3CD4")]
	private void BlockUp(float time = 2f)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x9C3DD8", Offset = "0x9C3DD8", VA = "0x9C3DD8", Slot = "16")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x9C418C", Offset = "0x9C418C", VA = "0x9C418C", Slot = "17")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x9C4190", Offset = "0x9C4190", VA = "0x9C4190", Slot = "9")]
	public bool IsComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x9C11D8", Offset = "0x9C11D8", VA = "0x9C11D8", Slot = "24")]
	public bool IsDuringCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9C4220", Offset = "0x9C4220", VA = "0x9C4220", Slot = "10")]
	public void StartCombo(float period)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9C4454", Offset = "0x9C4454", VA = "0x9C4454")]
	private void CalculateBonus(Game.HitTarget target, ref int body_part_bonus, ref Color hit_color)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x9C45FC", Offset = "0x9C45FC", VA = "0x9C45FC", Slot = "20")]
	public void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x9C35D0", Offset = "0x9C35D0", VA = "0x9C35D0")]
	private void UpdateDisperseEffect()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x9C1A98", Offset = "0x9C1A98", VA = "0x9C1A98")]
	private void UpdateAppearEffect()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9C203C", Offset = "0x9C203C", VA = "0x9C203C")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9C1D6C", Offset = "0x9C1D6C", VA = "0x9C1D6C")]
	private void UpdateBeatEfect()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x9C49D4", Offset = "0x9C49D4", VA = "0x9C49D4")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x9C4ADC", Offset = "0x9C4ADC", VA = "0x9C4ADC")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x9C4B44", Offset = "0x9C4B44", VA = "0x9C4B44")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9C4BAC", Offset = "0x9C4BAC", VA = "0x9C4BAC")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9C4C14", Offset = "0x9C4C14", VA = "0x9C4C14", Slot = "19")]
	public void OnEndAttackAfterHit()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9C4C20", Offset = "0x9C4C20", VA = "0x9C4C20")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9C4C58", Offset = "0x9C4C58", VA = "0x9C4C58", Slot = "5")]
	public void Disapear()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9C12DC", Offset = "0x9C12DC", VA = "0x9C12DC")]
	public void Die()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x9C4A3C", Offset = "0x9C4A3C", VA = "0x9C4A3C")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x9C4C6C", Offset = "0x9C4C6C", VA = "0x9C4C6C", Slot = "6")]
	public void Activate()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x9C4C90", Offset = "0x9C4C90", VA = "0x9C4C90", Slot = "7")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x9C4CB4", Offset = "0x9C4CB4", VA = "0x9C4CB4", Slot = "4")]
	public void Despawn()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x9C48F4", Offset = "0x9C48F4", VA = "0x9C48F4")]
	private void OnHitBehaviour(Game.HitTarget target)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x9C4F08", Offset = "0x9C4F08", VA = "0x9C4F08")]
	private void UpdateOutOfRing()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9C54A8", Offset = "0x9C54A8", VA = "0x9C54A8")]
	private void UpdateEnemyToClose(Vector3 center_pos)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9C23D0", Offset = "0x9C23D0", VA = "0x9C23D0")]
	public void UpdateFlyingBeh()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9C5850", Offset = "0x9C5850", VA = "0x9C5850")]
	public float GetRotataionCorrection()
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x9C2AA4", Offset = "0x9C2AA4", VA = "0x9C2AA4")]
	private void UpdatePosAndRotation()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9C5868", Offset = "0x9C5868", VA = "0x9C5868", Slot = "18")]
	public void OnBodyPenetraaion(Vector3 avatar_pos)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x9C3380", Offset = "0x9C3380", VA = "0x9C3380")]
	private void UpdateBodyPenetration()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9C59C0", Offset = "0x9C59C0", VA = "0x9C59C0", Slot = "8")]
	public Enemy GetEnemy()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9C59C8", Offset = "0x9C59C8", VA = "0x9C59C8")]
	public BagEnemy()
	{
	}
}
[Token(Token = "0x200001C")]
public class BeatColorizer : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game game;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material material;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string paramName;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color[] colors;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool alphaModify;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x9C5AC8", Offset = "0x9C5AC8", VA = "0x9C5AC8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x9C5B40", Offset = "0x9C5B40", VA = "0x9C5B40")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x9C5CE0", Offset = "0x9C5CE0", VA = "0x9C5CE0")]
	public BeatColorizer()
	{
	}
}
[Token(Token = "0x200001D")]
public class BeatScaller : MonoBehaviour
{
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 baseScale;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 destScale;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Game game;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x9C5CF0", Offset = "0x9C5CF0", VA = "0x9C5CF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x9C5D68", Offset = "0x9C5D68", VA = "0x9C5D68")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x9C5DE0", Offset = "0x9C5DE0", VA = "0x9C5DE0")]
	public BeatScaller()
	{
	}
}
[Token(Token = "0x200001E")]
public class Bliboards : MonoBehaviour
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpriteRenderer[] rendereres;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite[] sprites;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] times;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] sequences;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int seq_idx;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x9C5DE8", Offset = "0x9C5DE8", VA = "0x9C5DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x9C5EA8", Offset = "0x9C5EA8", VA = "0x9C5EA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x9C5FF0", Offset = "0x9C5FF0", VA = "0x9C5FF0")]
	public Bliboards()
	{
	}
}
[Token(Token = "0x200001F")]
public class BoxHandle : HandInteractable
{
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PuzzleBox puzzleBox;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 snapPos;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x9C5FF8", Offset = "0x9C5FF8", VA = "0x9C5FF8")]
	protected void Start()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x9C6050", Offset = "0x9C6050", VA = "0x9C6050")]
	private void Update()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9C6054", Offset = "0x9C6054", VA = "0x9C6054")]
	private void UpdateBoxHolding()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9C6310", Offset = "0x9C6310", VA = "0x9C6310", Slot = "4")]
	public override void OnStartDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x9C63B4", Offset = "0x9C63B4", VA = "0x9C63B4")]
	public BoxHandle()
	{
	}
}
[Token(Token = "0x2000020")]
public class Button3D : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	public enum Type
	{
		[Token(Token = "0x400012F")]
		Exit,
		[Token(Token = "0x4000130")]
		Restart,
		[Token(Token = "0x4000131")]
		Continue,
		[Token(Token = "0x4000132")]
		Play,
		[Token(Token = "0x4000133")]
		Tutorial,
		[Token(Token = "0x4000134")]
		Lobby,
		[Token(Token = "0x4000135")]
		Test,
		[Token(Token = "0x4000136")]
		TOT_Official,
		[Token(Token = "0x4000137")]
		TOT_Custom,
		[Token(Token = "0x4000138")]
		TOT_Mp3,
		[Token(Token = "0x4000139")]
		CHA_OPT1,
		[Token(Token = "0x400013A")]
		CHA_OPT2,
		[Token(Token = "0x400013B")]
		CHA_OPT3,
		[Token(Token = "0x400013C")]
		CustomEnemySlot,
		[Token(Token = "0x400013D")]
		SelectEnemy,
		[Token(Token = "0x400013E")]
		SelectIntensity,
		[Token(Token = "0x400013F")]
		TimeBtwnSpawns,
		[Token(Token = "0x4000140")]
		AddTrack,
		[Token(Token = "0x4000141")]
		RemoveTrack,
		[Token(Token = "0x4000142")]
		UpTrack,
		[Token(Token = "0x4000143")]
		DownTrack,
		[Token(Token = "0x4000144")]
		StartPlaylist,
		[Token(Token = "0x4000145")]
		AutoStart,
		[Token(Token = "0x4000146")]
		TutorialChapter,
		[Token(Token = "0x4000147")]
		ArenaSelector,
		[Token(Token = "0x4000148")]
		SFXVolume,
		[Token(Token = "0x4000149")]
		SFXType,
		[Token(Token = "0x400014A")]
		Achievement,
		[Token(Token = "0x400014B")]
		HowToPlay,
		[Token(Token = "0x400014C")]
		Accept,
		[Token(Token = "0x400014D")]
		ProcessMP3,
		[Token(Token = "0x400014E")]
		MP3Navigation,
		[Token(Token = "0x400014F")]
		MoreStrikes
	}

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int data;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 movement;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 addTranslate;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject selector;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 basePos;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion baseRot;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool selected;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool animateFromGround;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material selMat;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material baseMat;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool playSoundOnSelect;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool readyToUse;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float blockTimeAfterUse;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float blockTime;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 clickTranslate;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float clickAnimTime;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float clickAnimProgress;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRHandController lastTouchedHand;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float waitTime;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9C6414", Offset = "0x9C6414", VA = "0x9C6414")]
	public void SetReadyToUse(bool val)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9C6420", Offset = "0x9C6420", VA = "0x9C6420")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x9C65BC", Offset = "0x9C65BC", VA = "0x9C65BC")]
	public void SetBaseTransform()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x9BBA28", Offset = "0x9BBA28", VA = "0x9BBA28")]
	public void SetSelected(bool sel)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x9C66CC", Offset = "0x9C66CC", VA = "0x9C66CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x9C6A44", Offset = "0x9C6A44", VA = "0x9C6A44")]
	public void SetBasePos(Vector3 pos)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x9C6734", Offset = "0x9C6734", VA = "0x9C6734")]
	private void AnimateButton()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x9C660C", Offset = "0x9C660C", VA = "0x9C660C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x9C6A50", Offset = "0x9C6A50", VA = "0x9C6A50")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x9C6B48", Offset = "0x9C6B48", VA = "0x9C6B48")]
	private void ExecuteButtonAction()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9C6F20", Offset = "0x9C6F20", VA = "0x9C6F20")]
	private void LoadFirstScene()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x9C7208", Offset = "0x9C7208", VA = "0x9C7208")]
	private void HandleCustomButtonActions()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9C7318", Offset = "0x9C7318", VA = "0x9C7318")]
	public Button3D()
	{
	}
}
[Token(Token = "0x2000022")]
public class ComboMarker : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float timeToDeactivate;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float activeTime;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float prevScale;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool passed;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool mainTarget;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool leftHandInside;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	private bool rightHandInside;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material mainMat;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material standardMat;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer rederer;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool finisher;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer finisherTimeMarker;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float timeToPerfectHit;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color inactiveColor;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Color activeColor;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject sphere;

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x9C4208", Offset = "0x9C4208", VA = "0x9C4208")]
	public void SetMainTarget()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9C432C", Offset = "0x9C432C", VA = "0x9C432C")]
	public void Activate(float period, float active_pause)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x9C7444", Offset = "0x9C7444", VA = "0x9C7444")]
	private void Update()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x9C7B78", Offset = "0x9C7B78", VA = "0x9C7B78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x9C81A0", Offset = "0x9C81A0", VA = "0x9C81A0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x9C7D44", Offset = "0x9C7D44", VA = "0x9C7D44")]
	private void OnPassed(Vector3 dir, XRHandController hand)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x9C484C", Offset = "0x9C484C", VA = "0x9C484C")]
	public void OnHit(XRHandController hand, Vector3 dir)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x9C8270", Offset = "0x9C8270", VA = "0x9C8270")]
	public ComboMarker()
	{
	}
}
[Token(Token = "0x2000023")]
public class Compositor : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	private sealed class <WaitForWebRequest>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Compositor <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x9CBC28", Offset = "0x9CBC28", VA = "0x9CBC28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x9CBC70", Offset = "0x9CBC70", VA = "0x9CBC70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x9CBAA8", Offset = "0x9CBAA8", VA = "0x9CBAA8")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x9CBAD0", Offset = "0x9CBAD0", VA = "0x9CBAD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x9CBAD4", Offset = "0x9CBAD4", VA = "0x9CBAD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x9CBC30", Offset = "0x9CBC30", VA = "0x9CBC30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RhythmAnalyzer analyzer;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource musicSource;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool compose;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RhythmData rhythmData;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Beat> m_Beats;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Value> m_Segments;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> m_BeatSeg;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> upDownSeg;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int BPM;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int LEN;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int RATE;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int SLOTS;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int INTENSE;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material progressMaterial;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string notes;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string tamps;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool m_UseHigestBPM;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int TIME_BTWN_SPAWN;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int left_right;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int lastRotateBeatIDX;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AsyncOperation operation;

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x9C8298", Offset = "0x9C8298", VA = "0x9C8298")]
	public int SetTimeBtwnSpawns(int dir)
	{
		return default(int);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x9C82D4", Offset = "0x9C82D4", VA = "0x9C82D4")]
	private int RandomizeRotation(ref string notes, int beat_idx)
	{
		return default(int);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x9C83B4", Offset = "0x9C83B4", VA = "0x9C83B4")]
	private void ComposeNotes(int version)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x9C8DF4", Offset = "0x9C8DF4", VA = "0x9C8DF4")]
	private int AddPadding(int beat_idx, int i)
	{
		return default(int);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9C8F5C", Offset = "0x9C8F5C", VA = "0x9C8F5C")]
	private void TestSegments()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x9C9394", Offset = "0x9C9394", VA = "0x9C9394")]
	public void CalculateBPM()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x9C9774", Offset = "0x9C9774", VA = "0x9C9774")]
	public void Abort()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x9C9804", Offset = "0x9C9804", VA = "0x9C9804")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x9C9878", Offset = "0x9C9878", VA = "0x9C9878")]
	private void LoadAudioClip()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9C99AC", Offset = "0x9C99AC", VA = "0x9C99AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x9C99F0", Offset = "0x9C99F0", VA = "0x9C99F0")]
	public void Compose()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x9C9B90", Offset = "0x9C9B90", VA = "0x9C9B90")]
	private void UpdateProgressMaterial()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x9C99B0", Offset = "0x9C99B0", VA = "0x9C99B0")]
	public void UpdateCompositor()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x9CA3C4", Offset = "0x9CA3C4", VA = "0x9CA3C4")]
	private void MakeHeader()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x9CA4D4", Offset = "0x9CA4D4", VA = "0x9CA4D4")]
	private void CalculateSegments()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x9CAD80", Offset = "0x9CAD80", VA = "0x9CAD80")]
	private void RemoveToOftenSequences()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x9C9C24", Offset = "0x9C9C24", VA = "0x9C9C24")]
	public void CreateTrack()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9CB274", Offset = "0x9CB274", VA = "0x9CB274")]
	private void SaveTamps(string title_path)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x9CB774", Offset = "0x9CB774", VA = "0x9CB774")]
	public void SaveGeneratedTrack(string title_path, string notes)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x9CAF80", Offset = "0x9CAF80", VA = "0x9CAF80")]
	public void StabilizeTempo()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9CB9A8", Offset = "0x9CB9A8", VA = "0x9CB9A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x9CBA38", Offset = "0x9CBA38", VA = "0x9CBA38")]
	public Compositor()
	{
	}
}
[Token(Token = "0x2000025")]
public class Damager : MonoBehaviour
{
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x9CBC78", Offset = "0x9CBC78", VA = "0x9CBC78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9CBD14", Offset = "0x9CBD14", VA = "0x9CBD14")]
	public Damager()
	{
	}
}
[Token(Token = "0x2000026")]
public class Detector : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	public enum Type
	{
		[Token(Token = "0x4000180")]
		Body,
		[Token(Token = "0x4000181")]
		Head,
		[Token(Token = "0x4000182")]
		HandR,
		[Token(Token = "0x4000183")]
		HandL,
		[Token(Token = "0x4000184")]
		Guard,
		[Token(Token = "0x4000185")]
		Camera
	}

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Avatar avatar;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game game;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Type type;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool wasDamageInLastFrame;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	private bool kickDamage;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool leftDamage;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9CBD1C", Offset = "0x9CBD1C", VA = "0x9CBD1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x9CBDC0", Offset = "0x9CBDC0", VA = "0x9CBDC0")]
	private bool IsHandAtackPart(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x9CBE74", Offset = "0x9CBE74", VA = "0x9CBE74")]
	private bool IsLegAtackPart(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x9CBF00", Offset = "0x9CBF00", VA = "0x9CBF00")]
	private bool IsEnemyBody(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x9CBF8C", Offset = "0x9CBF8C", VA = "0x9CBF8C")]
	private void CheckAttackCollision(Collider other)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x9CC4D0", Offset = "0x9CC4D0", VA = "0x9CC4D0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x9CC680", Offset = "0x9CC680", VA = "0x9CC680")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x9CC76C", Offset = "0x9CC76C", VA = "0x9CC76C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x9CC7A8", Offset = "0x9CC7A8", VA = "0x9CC7A8")]
	public Detector()
	{
	}
}
[Token(Token = "0x2000028")]
public class Enemy : MonoBehaviour, IEnemy
{
	[Token(Token = "0x2000029")]
	public enum AttackType
	{
		[Token(Token = "0x40001F3")]
		Unknown,
		[Token(Token = "0x40001F4")]
		RHand,
		[Token(Token = "0x40001F5")]
		LHand,
		[Token(Token = "0x40001F6")]
		RLeg,
		[Token(Token = "0x40001F7")]
		LLeg
	}

	[Token(Token = "0x200002A")]
	public enum OnHitBeh
	{
		[Token(Token = "0x40001F9")]
		NoReaction,
		[Token(Token = "0x40001FA")]
		TwoNoneOne,
		[Token(Token = "0x40001FB")]
		TwoNoneTwo,
		[Token(Token = "0x40001FC")]
		TwoNoneNone,
		[Token(Token = "0x40001FD")]
		OneNoneNone,
		[Token(Token = "0x40001FE")]
		OneNoneTwo,
		[Token(Token = "0x40001FF")]
		OneNoneOne
	}

	[Token(Token = "0x200002B")]
	private sealed class <PlayDelayedSoundCoroutine>d__178 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string clip_name;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Enemy <>4__this;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioClip <clip>5__2;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x9D2F20", Offset = "0x9D2F20", VA = "0x9D2F20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x9D2F68", Offset = "0x9D2F68", VA = "0x9D2F68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x9D2CCC", Offset = "0x9D2CCC", VA = "0x9D2CCC")]
		[DebuggerHidden]
		public <PlayDelayedSoundCoroutine>d__178(int <>1__state)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x9D2E14", Offset = "0x9D2E14", VA = "0x9D2E14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x9D2E18", Offset = "0x9D2E18", VA = "0x9D2E18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9D2F28", Offset = "0x9D2F28", VA = "0x9D2F28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnHitBeh onHitBehaviour;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool noRotate;

	[Token(Token = "0x4000188")]
	private const float HAND_ON_TIME = 0.3f;

	[Token(Token = "0x4000189")]
	private const float SNAP_TO_BASE_PERIOD = 0.4f;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float hitEffectPower;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float[] atacksLen;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] atacksHitFrame;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] atacksRatio;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AttackType[] atacksType;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] attackSeq;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int[] berserkerkSeq;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int[] complicatedSeq;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Game game;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Animator animator;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public HitEffector hitEffector;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 animatorBasePos;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Quaternion animatorBaseRot;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float baseScale;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool duringAttackAnim;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private bool rightHandAttack;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	private bool leftHandAttack;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	private bool rightLegAttack;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool leftLegAttack;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float duringMovementAnim;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float lifeTime;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public SkinnedMeshRenderer[] bodyParts;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] matIndexes;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool mirrored;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float movementLayerWeight;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ArmsCorrection armsCorrection;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float handOffLayerWeight;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float handOffTime;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float handOffPower;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool handsOffDuringCombo;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public ComboMarker[] comboMarkers;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private AudioSource audioSource;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3 hudOffset;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public bool duringBerserker;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float comboLayerWeight;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float comboLayerPower;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float baseDist;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float minDistToPlayer;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float maxDistToPlayer;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float offsetToPlayerDuringAttack;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float animatedOffsetDuringAttack;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public float rotationCorrection;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float ANIM_IDLE_SPEED;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public ComboMarker finisher;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject[] toHideDuringDissolve;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Vector3 basePos;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float timeToNormalSpeed;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float nextAttackTime;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float nextAttackMaxLen;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Game.EEventType nextAttackType;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private float attackTime;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float attackMaxLen;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private Game.EEventType attackType;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float handsOffWindow;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool blockAttacks;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int attackIDX;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public bool canBlockDuringCombo;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int headBonus;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int upBodyBonus;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int downBodyBonus;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Material[] mainMats;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Material[] appearMats;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Material[] finisherMats;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Material shadowMat;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private float beatHighlight;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Material[] beatHighMats;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool appearMatChanged;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private float dissolve;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Material hitMaterial;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Vector3 lastHitPos;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private Color lastHitColor;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Transform lastHitTransform;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private float lastHitProgress;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private float lastHitRadius;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Vector3 prevHitPos;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private Color prevHitColor;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private float prevHitProgress;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Transform prevHitTransform;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private float prevHitRadius;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private float timeToPlayerDodge;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public bool dead;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float timeToDisperse;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private float timeToDelete;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private Game.HitTarget prevHitTarget;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public bool scalerBehave;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float destScale;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private float scaleProgress;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	private float currScale;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public bool jumperBehave;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	public float jumpTime;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public float jumpSpeed;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private float destJumperAngle;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private float curr_angle;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	private float jump_progress;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private float snapToBasePosDuringIdleTime;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private float snapRotataionTempo;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private bool outOfRingDirLeft;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	private float timeToChnageOutOfDir;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public bool blockOutOfRing;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private float toCloseTime;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public bool dancingBeh;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x269")]
	public bool flyingBeh;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26A")]
	public bool capoeiraBeh;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private Vector3 bodyPenetrationInfluence;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x9CC7B0", Offset = "0x9CC7B0", VA = "0x9CC7B0")]
	public float GetBaseDist()
	{
		return default(float);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x9CC7C0", Offset = "0x9CC7C0", VA = "0x9CC7C0")]
	public float GetMinDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x9CC7D0", Offset = "0x9CC7D0", VA = "0x9CC7D0")]
	public float GetMaxDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x9CC7E0", Offset = "0x9CC7E0", VA = "0x9CC7E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x9CD0B8", Offset = "0x9CD0B8", VA = "0x9CD0B8")]
	private void UpdateMovement()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x9CD1B8", Offset = "0x9CD1B8", VA = "0x9CD1B8")]
	private void UpdateHandsOff()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x9CD468", Offset = "0x9CD468", VA = "0x9CD468")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x9CD654", Offset = "0x9CD654", VA = "0x9CD654")]
	private void UpdateDead()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x9CD740", Offset = "0x9CD740", VA = "0x9CD740")]
	private void UpdateOffsetDuringAttack()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x9CD774", Offset = "0x9CD774", VA = "0x9CD774")]
	private void Update()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x9CDF48", Offset = "0x9CDF48", VA = "0x9CDF48")]
	private void UpdateAnimTransition()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x9D07B4", Offset = "0x9D07B4", VA = "0x9D07B4", Slot = "11")]
	public bool IsDuringAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x9D07EC", Offset = "0x9D07EC", VA = "0x9D07EC", Slot = "12")]
	public bool IsLeftHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x9D0804", Offset = "0x9D0804", VA = "0x9D0804", Slot = "13")]
	public bool IsRightHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x9D081C", Offset = "0x9D081C", VA = "0x9D081C", Slot = "14")]
	public bool IsRightLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x9D0834", Offset = "0x9D0834", VA = "0x9D0834", Slot = "15")]
	public bool IsLeftLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x9D084C", Offset = "0x9D084C", VA = "0x9D084C")]
	public void BlockAttacks(bool val)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x9D0858", Offset = "0x9D0858", VA = "0x9D0858", Slot = "22")]
	public void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x9D0930", Offset = "0x9D0930", VA = "0x9D0930")]
	public void SynchronizeIdleToMusic(float time_attack)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x9D0AEC", Offset = "0x9D0AEC", VA = "0x9D0AEC")]
	private void UploadNextAttackFromOrder()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x9D0B58", Offset = "0x9D0B58", VA = "0x9D0B58")]
	private int SelectAttactIDXFromSequence()
	{
		return default(int);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x9D0C04", Offset = "0x9D0C04", VA = "0x9D0C04")]
	private float GetTimeToAttack()
	{
		return default(float);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x9CD9C0", Offset = "0x9CD9C0", VA = "0x9CD9C0")]
	private void UpdateNextAttack()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x9D0C74", Offset = "0x9D0C74", VA = "0x9D0C74", Slot = "23")]
	public void Strafe(bool left, float max_move_length)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x9D0D74", Offset = "0x9D0D74", VA = "0x9D0D74", Slot = "21")]
	public void PlayEmot()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x9D0DF4", Offset = "0x9D0DF4", VA = "0x9D0DF4")]
	private void BlockDown(float time = 2f)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x9D0F00", Offset = "0x9D0F00", VA = "0x9D0F00")]
	private void BlockUp(float time = 2f)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x9D1004", Offset = "0x9D1004", VA = "0x9D1004", Slot = "16")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x9D13EC", Offset = "0x9D13EC", VA = "0x9D13EC", Slot = "17")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x9D13F0", Offset = "0x9D13F0", VA = "0x9D13F0", Slot = "9")]
	public bool IsComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x9CD5D8", Offset = "0x9CD5D8", VA = "0x9CD5D8", Slot = "24")]
	public bool IsDuringCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x9D1458", Offset = "0x9D1458", VA = "0x9D1458", Slot = "10")]
	public void StartCombo(float period)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x9D1560", Offset = "0x9D1560", VA = "0x9D1560")]
	public void ClearBodyBonus()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x9D156C", Offset = "0x9D156C", VA = "0x9D156C")]
	private void CalculateBonus(Game.HitTarget target, ref int body_part_bonus, ref Color hit_color)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x9D1710", Offset = "0x9D1710", VA = "0x9D1710", Slot = "20")]
	public void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x9D1AB4", Offset = "0x9D1AB4", VA = "0x9D1AB4")]
	public void SetAppearMatChanged(bool val)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x9D0548", Offset = "0x9D0548", VA = "0x9D0548")]
	private void UpdateDisperseEffect()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x9CDFA4", Offset = "0x9CDFA4", VA = "0x9CDFA4")]
	private void UpdateAppearEffect()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x9CE54C", Offset = "0x9CE54C", VA = "0x9CE54C")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x9CE27C", Offset = "0x9CE27C", VA = "0x9CE27C")]
	private void UpdateBeatEfect()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x9D1AC0", Offset = "0x9D1AC0", VA = "0x9D1AC0")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x9D1AD4", Offset = "0x9D1AD4", VA = "0x9D1AD4")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x9D1AE8", Offset = "0x9D1AE8", VA = "0x9D1AE8")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x9D1AFC", Offset = "0x9D1AFC", VA = "0x9D1AFC")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x9D1B10", Offset = "0x9D1B10", VA = "0x9D1B10", Slot = "19")]
	public void OnEndAttackAfterHit()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x9D1B1C", Offset = "0x9D1B1C", VA = "0x9D1B1C")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x9D1B54", Offset = "0x9D1B54", VA = "0x9D1B54", Slot = "5")]
	public void Disapear()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x9CD6E4", Offset = "0x9CD6E4", VA = "0x9CD6E4")]
	public void Die()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x9D1C58", Offset = "0x9D1C58", VA = "0x9D1C58", Slot = "6")]
	public void Activate()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9D1C7C", Offset = "0x9D1C7C", VA = "0x9D1C7C", Slot = "7")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x9D1CA0", Offset = "0x9D1CA0", VA = "0x9D1CA0", Slot = "4")]
	public void Despawn()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x9D19D4", Offset = "0x9D19D4", VA = "0x9D19D4")]
	private void OnHitBehaviour(Game.HitTarget target)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x9CEDBC", Offset = "0x9CEDBC", VA = "0x9CEDBC")]
	private void UpdateScalerBehave()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x9D1EE8", Offset = "0x9D1EE8", VA = "0x9D1EE8")]
	public void OnJump()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x9CE8E0", Offset = "0x9CE8E0", VA = "0x9CE8E0")]
	private void UpdateJumperBehave()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x9D1FCC", Offset = "0x9D1FCC", VA = "0x9D1FCC")]
	private void UpdateOutOfRing()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x9D2574", Offset = "0x9D2574", VA = "0x9D2574")]
	private void UpdateEnemyToClose(Vector3 center_pos)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x9CEEF8", Offset = "0x9CEEF8", VA = "0x9CEEF8")]
	public void UpdateDancingBeh()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x9CF338", Offset = "0x9CF338", VA = "0x9CF338")]
	public void UpdateFlyingBeh()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x9CFA0C", Offset = "0x9CFA0C", VA = "0x9CFA0C")]
	public void UpdateCapoeiraBeh()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x9D1FB4", Offset = "0x9D1FB4", VA = "0x9D1FB4")]
	public float GetRotataionCorrection()
	{
		return default(float);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x9CFA10", Offset = "0x9CFA10", VA = "0x9CFA10")]
	private void UpdatePosAndRotation()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x9D293C", Offset = "0x9D293C", VA = "0x9D293C", Slot = "18")]
	public void OnBodyPenetraaion(Vector3 avatar_pos)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x9D02F4", Offset = "0x9D02F4", VA = "0x9D02F4")]
	private void UpdateBodyPenetration()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x9D2A98", Offset = "0x9D2A98", VA = "0x9D2A98", Slot = "8")]
	public Enemy GetEnemy()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x9D2A9C", Offset = "0x9D2A9C", VA = "0x9D2A9C")]
	public void SetupTransform(Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x9D0C54", Offset = "0x9D0C54", VA = "0x9D0C54")]
	public void PlayDelayedSound(string clip_name, float delay, float volume = 1f)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x9D2C2C", Offset = "0x9D2C2C", VA = "0x9D2C2C")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x9D2B84", Offset = "0x9D2B84", VA = "0x9D2B84")]
	private IEnumerator PlayDelayedSoundCoroutine(string clip_name, float delay, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x9D2CF4", Offset = "0x9D2CF4", VA = "0x9D2CF4")]
	public Enemy()
	{
	}
}
[Token(Token = "0x200002C")]
public class EqualizerEffect : MonoBehaviour
{
	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource musicSource;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool m_Tutorial;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material m_AnimLightMat;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material m_RoundEqulizerMat;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_BarsEqulizerMat;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material m_BarsEqulizerHaloMat;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material m_SkyscraperWindowsMat;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material m_SkyscraperWindowsHaloMat;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material m_MotionMat;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material m_MotionColorofonMat;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material m_MotionColorofonHaloMat;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material m_FlorHaloMat;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material m_SkyMat;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material m_ArenaMat;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material m_ArenaMatNoReflects;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material m_ArenaLinesMat;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material m_ArenaLinesHaloMat;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Material m_LavaToAnimMat;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float LavaMul;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Light m_HUDLight;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float m_WallEffectPow;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float m_SpecAmpltudeMod;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float m_AnimMatTime;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float m_ScaleMod;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float m_Hue;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int m_HueIDX;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int m_HueStep;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int m_NoBands;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float[] m_SpecVis;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float[] m_NotesVis;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float[] m_NotesVisBlend;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool m_UseNotes;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool m_MainMenu;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public int m_ColorScheme;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool m_DimColors;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float m_LavaProgress;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float barScale;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x9D2F70", Offset = "0x9D2F70", VA = "0x9D2F70")]
	private void UpdateHue()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x9D30C4", Offset = "0x9D30C4", VA = "0x9D30C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x9D3204", Offset = "0x9D3204", VA = "0x9D3204")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x9D3820", Offset = "0x9D3820", VA = "0x9D3820")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x9D3CE4", Offset = "0x9D3CE4", VA = "0x9D3CE4")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x9D3D84", Offset = "0x9D3D84", VA = "0x9D3D84")]
	private Color HueToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x9D3ED4", Offset = "0x9D3ED4", VA = "0x9D3ED4")]
	private Color HueToLineColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x9D40CC", Offset = "0x9D40CC", VA = "0x9D40CC")]
	private void UpdateLava()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x9D4208", Offset = "0x9D4208", VA = "0x9D4208")]
	private void Update()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x9D46E0", Offset = "0x9D46E0", VA = "0x9D46E0")]
	private void RoundEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x9D4938", Offset = "0x9D4938", VA = "0x9D4938")]
	private void BarsEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x9D4F64", Offset = "0x9D4F64", VA = "0x9D4F64")]
	private void MotionMatUpdate()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x9D5624", Offset = "0x9D5624", VA = "0x9D5624")]
	private void UpdateLightSynchroMats()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x9D56FC", Offset = "0x9D56FC", VA = "0x9D56FC")]
	public EqualizerEffect()
	{
	}
}
[Token(Token = "0x200002D")]
public class EventCatcher : MonoBehaviour
{
	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Enemy enemy;

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x9D57C8", Offset = "0x9D57C8", VA = "0x9D57C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x9D5820", Offset = "0x9D5820", VA = "0x9D5820")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x9D58A0", Offset = "0x9D58A0", VA = "0x9D58A0")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x9D5920", Offset = "0x9D5920", VA = "0x9D5920")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x9D59A0", Offset = "0x9D59A0", VA = "0x9D59A0")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x9D5A20", Offset = "0x9D5A20", VA = "0x9D5A20")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x9D5AC4", Offset = "0x9D5AC4", VA = "0x9D5AC4")]
	public void OnJump()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x9D5B40", Offset = "0x9D5B40", VA = "0x9D5B40")]
	public EventCatcher()
	{
	}
}
[Token(Token = "0x200002E")]
public class Game : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	public enum HitTarget
	{
		[Token(Token = "0x400029B")]
		BodyUp = 1,
		[Token(Token = "0x400029C")]
		BodyDown,
		[Token(Token = "0x400029D")]
		Head,
		[Token(Token = "0x400029E")]
		Other
	}

	[Token(Token = "0x2000030")]
	public enum EEventType
	{
		[Token(Token = "0x40002A0")]
		Empty,
		[Token(Token = "0x40002A1")]
		TutorialTest,
		[Token(Token = "0x40002A2")]
		Emot,
		[Token(Token = "0x40002A3")]
		SpawnEnemy,
		[Token(Token = "0x40002A4")]
		DespawnEnemy,
		[Token(Token = "0x40002A5")]
		Attack,
		[Token(Token = "0x40002A6")]
		Berserker,
		[Token(Token = "0x40002A7")]
		Complicated,
		[Token(Token = "0x40002A8")]
		Left,
		[Token(Token = "0x40002A9")]
		Right,
		[Token(Token = "0x40002AA")]
		LasrDespawnEnemy
	}

	[Token(Token = "0x2000031")]
	public struct HandStats
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_Missed;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_Speed;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_Timing;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_Variety;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_BodyVariety;
	}

	[Token(Token = "0x2000032")]
	public struct TrackEvent
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EEventType type;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int timeLen;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string enemyName;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeStamp;
	}

	[Token(Token = "0x2000033")]
	private sealed class <LoadWebFile>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x9E6324", Offset = "0x9E6324", VA = "0x9E6324", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x9E636C", Offset = "0x9E636C", VA = "0x9E636C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9E601C", Offset = "0x9E601C", VA = "0x9E601C")]
		[DebuggerHidden]
		public <LoadWebFile>d__90(int <>1__state)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9E6044", Offset = "0x9E6044", VA = "0x9E6044", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x9E6048", Offset = "0x9E6048", VA = "0x9E6048", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x9E632C", Offset = "0x9E632C", VA = "0x9E632C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000034")]
	private sealed class <WaitForWebRequest>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x9E65C0", Offset = "0x9E65C0", VA = "0x9E65C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x9E6608", Offset = "0x9E6608", VA = "0x9E6608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x9E6374", Offset = "0x9E6374", VA = "0x9E6374")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__91(int <>1__state)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x9E639C", Offset = "0x9E639C", VA = "0x9E639C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x9E63A0", Offset = "0x9E63A0", VA = "0x9E63A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x9E65C8", Offset = "0x9E65C8", VA = "0x9E65C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000035")]
	private sealed class <LoadLocalClip>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x9E68A8", Offset = "0x9E68A8", VA = "0x9E68A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x9E68F0", Offset = "0x9E68F0", VA = "0x9E68F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x9E6610", Offset = "0x9E6610", VA = "0x9E6610")]
		[DebuggerHidden]
		public <LoadLocalClip>d__95(int <>1__state)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x9E6638", Offset = "0x9E6638", VA = "0x9E6638", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x9E663C", Offset = "0x9E663C", VA = "0x9E663C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x9E68B0", Offset = "0x9E68B0", VA = "0x9E68B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Game instance;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool movieRecorder;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onlyFXes;

	[Token(Token = "0x4000233")]
	public const float TIMING_PERFECT = 0.9f;

	[Token(Token = "0x4000234")]
	public const float TIMING_GOOD = 0.8f;

	[Token(Token = "0x4000235")]
	public const float TIMING_OK = 0.7f;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject dissolveSphere;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AdvancedDissolvePropertiesController dissolveController;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool comboTest;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool offsetTest;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timeTest;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string m_Notes;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string m_Song;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_AvHeight;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float currTime;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float prevTime;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int startBeat;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float BPM;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float offset;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioSource musicSource;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LevelCompleted levelCompleted;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public HUD hud;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_Volume;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool m_RepeatedTut;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	private bool m_SmallArea;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] toActivateOnFinish;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] toActivateOnPause;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float slomoFactor;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float slomoTime;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XRHandController lGlove;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public XRHandController rGlove;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CommonVR vr;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool wasStarted;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool m_Inited;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int m_FinisBeatIDx;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioClip m_ClipToPlay;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TrackEvent[] events;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float m_Blackout;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private HandStats[] m_LStats;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private HandStats[] m_RStats;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_LStatIDX;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_RStatIDX;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int noDodges;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int noDamages;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int noBlocks;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public bool m_Pause;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float[] m_TimeStamps;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float m_GlobalSynchro;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public IEnemy currEnemy;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int m_TrackLength;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public int m_AnalizedBeat;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int m_PrevAnalizedBeat;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public int m_GBeatIDx;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float m_GBeatProgress;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public int m_FXBeatIDx;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float m_FXBeatProgress;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public int m_PrevIDx;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public int scoreMul;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public int scoreCounter;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public float comboProgress;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float duringCombo;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float comboDecraseTempo;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool m_Finished;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public string[] enemyNames;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int noEnemyNames;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int currEnemyIDX;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Transform spawnPlace;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Light mainLight;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Color NORMAL_LIGHT;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Color SLOMO_LIGHT;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Color PERFECT_COLOR;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Color GOOD_COLOR;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Color OK_COLOR;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public Color BAD_COLOR;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public bool getFromWeb;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Avatar <avatar>k__BackingField;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Transform orientation;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool noCombo;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Text skipText;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Text restartText;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private AsyncOperation operation;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private int trackRate;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private int trackSlots;

	[Token(Token = "0x4000284")]
	private const float FULL_COMBO_PROGRESS = 100f;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public bool musicVolControlledOut;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private float comboMod;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public LiveTutorial tutorial;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private string sceneToReload;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float timeToReload;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float m_LHandEnergy;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private float m_RHandEnergy;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	private float m_HeadEnergy;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public float m_Calories;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private Vector3 m_LHandSpeed;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Vector3 m_RHandSpeed;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private Vector3 m_HeadSpeed;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private Vector3 m_LHandSpeedPrev;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private Vector3 m_RHandSpeedPrev;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Vector3 m_HeadSpeedPrev;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private Vector3 m_LHandPos;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private Vector3 m_RHandPos;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	private Vector3 m_HeadPos;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private Vector3 m_LHandPosPrev;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	private Vector3 m_RHandPosPrev;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private Vector3 m_HeadPosPrev;

	[Token(Token = "0x1700001D")]
	public Avatar avatar
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x9D5C90", Offset = "0x9D5C90", VA = "0x9D5C90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x9D5C98", Offset = "0x9D5C98", VA = "0x9D5C98")]
		set
		{
		}
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x9D5B48", Offset = "0x9D5B48", VA = "0x9D5B48")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x9D5B78", Offset = "0x9D5B78", VA = "0x9D5B78")]
	public int GetBeatTiming()
	{
		return default(int);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x9D5BF0", Offset = "0x9D5BF0", VA = "0x9D5BF0")]
	public float GetStatsBeatTiming()
	{
		return default(float);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x9D5CA8", Offset = "0x9D5CA8", VA = "0x9D5CA8")]
	private IEnumerator LoadWebFile()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x9D5D1C", Offset = "0x9D5D1C", VA = "0x9D5D1C")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x9D5D90", Offset = "0x9D5D90", VA = "0x9D5D90")]
	private void LoadMP3Clip()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x9D5F1C", Offset = "0x9D5F1C", VA = "0x9D5F1C")]
	private IEnumerator LoadLocalClip()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x9D5F90", Offset = "0x9D5F90", VA = "0x9D5F90")]
	private void Init()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x9D6004", Offset = "0x9D6004", VA = "0x9D6004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x9D63C8", Offset = "0x9D63C8", VA = "0x9D63C8")]
	private void ClearEvents()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x9D64AC", Offset = "0x9D64AC", VA = "0x9D64AC")]
	private void StartGame()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x9D64F0", Offset = "0x9D64F0", VA = "0x9D64F0")]
	public void PrepareTrack()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x9D6F6C", Offset = "0x9D6F6C", VA = "0x9D6F6C")]
	private void GenerateTamps()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x9D6610", Offset = "0x9D6610", VA = "0x9D6610")]
	public void ParseInfo(string notes)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x9D7738", Offset = "0x9D7738", VA = "0x9D7738")]
	private int ParseBeatsLen(ref string track, ref int beat_idx)
	{
		return default(int);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x9D70C8", Offset = "0x9D70C8", VA = "0x9D70C8")]
	private string ParseTrack(string track, ref int beat_idx)
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x9D7844", Offset = "0x9D7844", VA = "0x9D7844")]
	public float GetCurrProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x9D0C44", Offset = "0x9D0C44", VA = "0x9D0C44")]
	public float GetCurrMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x9D7858", Offset = "0x9D7858", VA = "0x9D7858")]
	private void UpdateSlomo()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x9D7A70", Offset = "0x9D7A70", VA = "0x9D7A70")]
	public void StartCombo()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x9D7D54", Offset = "0x9D7D54", VA = "0x9D7D54")]
	public void OnComboSucess()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x9D7E18", Offset = "0x9D7E18", VA = "0x9D7E18")]
	public void OnComboMicroSucess()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x9D7E28", Offset = "0x9D7E28", VA = "0x9D7E28")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x9D7F94", Offset = "0x9D7F94", VA = "0x9D7F94")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x9D8F30", Offset = "0x9D8F30", VA = "0x9D8F30")]
	private void UpdateBlackout()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x9D8108", Offset = "0x9D8108", VA = "0x9D8108")]
	public void Pause()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x9D6304", Offset = "0x9D6304", VA = "0x9D6304")]
	public void HideAllButtons()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x9D9890", Offset = "0x9D9890", VA = "0x9D9890")]
	public void Resume()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x9D9A04", Offset = "0x9D9A04", VA = "0x9D9A04")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x9D9C1C", Offset = "0x9D9C1C", VA = "0x9D9C1C")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x9D0618", Offset = "0x9D0618", VA = "0x9D0618")]
	public void OnDodge()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x9D9E30", Offset = "0x9D9E30", VA = "0x9D9E30")]
	public void AddBonusPoints(int points)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x9D9E44", Offset = "0x9D9E44", VA = "0x9D9E44")]
	public void SetComboMod(float val)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x9D9E4C", Offset = "0x9D9E4C", VA = "0x9D9E4C")]
	public int OnHit(Vector3 pos, Vector3 dir, float speed, int hand_variety, XRHandController hand, HitTarget target, Collider collider)
	{
		return default(int);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x9D8560", Offset = "0x9D8560", VA = "0x9D8560")]
	public void OnFinish()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x9DA474", Offset = "0x9DA474", VA = "0x9DA474")]
	public void ReloadScene(string scene_name, float time)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x9D8068", Offset = "0x9D8068", VA = "0x9D8068")]
	private void UpdateReload()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x9D7CB4", Offset = "0x9D7CB4", VA = "0x9D7CB4")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x9DA538", Offset = "0x9DA538", VA = "0x9DA538")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x9D8FE8", Offset = "0x9D8FE8", VA = "0x9D8FE8")]
	private void EnergyCalculator()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x9D7C4C", Offset = "0x9D7C4C", VA = "0x9D7C4C")]
	public bool IsDespawnEvent(int no_beats)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x9D0A58", Offset = "0x9D0A58", VA = "0x9D0A58")]
	public float GetPeriodToBeat(int no_beats)
	{
		return default(float);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x9DA574", Offset = "0x9DA574", VA = "0x9DA574")]
	private void UpdateTimeStamp()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x9D838C", Offset = "0x9D838C", VA = "0x9D838C")]
	private void UpdateBeatIDx()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x9D8DF8", Offset = "0x9D8DF8", VA = "0x9D8DF8")]
	private void AnalyzeEvents()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x9DAB1C", Offset = "0x9DAB1C", VA = "0x9DAB1C")]
	private void PrepareAttack(int curr_beat)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x9DA96C", Offset = "0x9DA96C", VA = "0x9DA96C")]
	private void SpawnEnemy(int curr_beat)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x9DA828", Offset = "0x9DA828", VA = "0x9DA828")]
	private void DespawnEnemy(int curr_beat)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x9DA66C", Offset = "0x9DA66C", VA = "0x9DA66C")]
	private void PlayAnim(int curr_beat)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x9DAC60", Offset = "0x9DAC60", VA = "0x9DAC60")]
	public void OnButton(Button3D.Type button_type)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x9DAC64", Offset = "0x9DAC64", VA = "0x9DAC64")]
	public Game()
	{
	}
}
[Token(Token = "0x2000036")]
public class GameLeaderboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000037")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>.Handler <>9__12_0;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9E8FE4", Offset = "0x9E8FE4", VA = "0x9E8FE4")]
		public <>c()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9E8FEC", Offset = "0x9E8FEC", VA = "0x9E8FEC")]
		internal void <PicoInit>b__12_0(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> m)
		{
		}
	}

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool waitingOnData;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text debugText;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text titleText;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILBEntry[] entries;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite[] otherBackgrounds;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite userSprite;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SortedDictionary<int, Pico.Platform.Models.LeaderboardEntry> m_PicoHighScores;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SortedDictionary<int, Oculus.Platform.Models.LeaderboardEntry> m_OculusHighScores;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string m_LB_ID;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_FriendsMode;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int request_delay;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int first_request_delay;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int waitingAnimProgress;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int animPos;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool visible;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float animProgress;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 basePos;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 hidePos;

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x9E68F8", Offset = "0x9E68F8", VA = "0x9E68F8")]
	public void OnFriends()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x9E6B2C", Offset = "0x9E6B2C", VA = "0x9E6B2C")]
	public void OnOverall()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x9E6B34", Offset = "0x9E6B34", VA = "0x9E6B34")]
	private void PicoInit()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x9E6C70", Offset = "0x9E6C70", VA = "0x9E6C70")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x9E6F14", Offset = "0x9E6F14", VA = "0x9E6F14")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x9E7374", Offset = "0x9E7374", VA = "0x9E7374")]
	private void UpdateWaitingAnim()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x9E6D64", Offset = "0x9E6D64", VA = "0x9E6D64")]
	public void FillEmpty()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x9E757C", Offset = "0x9E757C", VA = "0x9E757C")]
	public void OnHighLeaderboardUpdated()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x9E7AFC", Offset = "0x9E7AFC", VA = "0x9E7AFC")]
	public void OnNearLeaderboardUpdated()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x9E6F68", Offset = "0x9E6F68", VA = "0x9E6F68")]
	private void QueryHighScoreLeaderboard()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x9E8118", Offset = "0x9E8118", VA = "0x9E8118")]
	private void StopProgessAnim()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x9E81B8", Offset = "0x9E81B8", VA = "0x9E81B8")]
	private void FillEntries(ref Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x9E84A4", Offset = "0x9E84A4", VA = "0x9E84A4")]
	private void MostScoreGetEntriesCallback(Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x9E85C0", Offset = "0x9E85C0", VA = "0x9E85C0")]
	private void AroundGetEntriesCallback(Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x9E85E8", Offset = "0x9E85E8", VA = "0x9E85E8")]
	private void FillEntries(ref Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x9E8784", Offset = "0x9E8784", VA = "0x9E8784")]
	private void MostScoreGetEntriesCallback(Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x9E88A4", Offset = "0x9E88A4", VA = "0x9E88A4")]
	private void AroundGetEntriesCallback(Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x9E6904", Offset = "0x9E6904", VA = "0x9E6904")]
	public void RefreshScore()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x9E88CC", Offset = "0x9E88CC", VA = "0x9E88CC")]
	public void WritePlayerScore()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x9E8E18", Offset = "0x9E8E18", VA = "0x9E8E18")]
	public void Show()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x9E8E34", Offset = "0x9E8E34", VA = "0x9E8E34")]
	public void Hide()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x9E71B0", Offset = "0x9E71B0", VA = "0x9E71B0")]
	private void UpdateShowAnim()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x9E8E68", Offset = "0x9E8E68", VA = "0x9E8E68")]
	public GameLeaderboard()
	{
	}
}
[Token(Token = "0x2000038")]
public class HandInteractable : Interactable
{
	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool hapticOnlyWhenGripOff;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x9E9004", Offset = "0x9E9004", VA = "0x9E9004", Slot = "8")]
	public virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x9E90C4", Offset = "0x9E90C4", VA = "0x9E90C4", Slot = "9")]
	public virtual void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x9E9338", Offset = "0x9E9338", VA = "0x9E9338", Slot = "10")]
	public virtual void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x9E9424", Offset = "0x9E9424", VA = "0x9E9424")]
	public HandInteractable()
	{
	}
}
[Token(Token = "0x2000039")]
public class HeightSetup : ItemsList
{
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool metricUnit;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x9E9444", Offset = "0x9E9444", VA = "0x9E9444", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x9E9540", Offset = "0x9E9540", VA = "0x9E9540", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x9E94B8", Offset = "0x9E94B8", VA = "0x9E94B8")]
	public void SetupHeight(float height)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x9E96A4", Offset = "0x9E96A4", VA = "0x9E96A4", Slot = "4")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x9E9754", Offset = "0x9E9754", VA = "0x9E9754")]
	public void OnChangeUnit()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x9E975C", Offset = "0x9E975C", VA = "0x9E975C", Slot = "10")]
	public override void OnHideItems()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x9E97E4", Offset = "0x9E97E4", VA = "0x9E97E4", Slot = "9")]
	public override void OnShowItems()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x9E9864", Offset = "0x9E9864", VA = "0x9E9864")]
	public HeightSetup()
	{
	}
}
[Token(Token = "0x200003A")]
public class HitEffector : MonoBehaviour
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform spine1Effector;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform spine2Effector;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform spine3Effector;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform headEffector;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform downMarker;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform headMarker;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform leftMarker;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform rightMarker;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] rotations;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] rotationsToPlayer;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] destRotations;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float hitPower;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float powerAmply;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Game game;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Enemy enemy;

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x9E9874", Offset = "0x9E9874", VA = "0x9E9874")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x9E98EC", Offset = "0x9E98EC", VA = "0x9E98EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x9E9DB4", Offset = "0x9E9DB4", VA = "0x9E9DB4")]
	private void UpdateRotationToPlayer()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x9EA260", Offset = "0x9EA260", VA = "0x9EA260")]
	public void OnHit(Vector3 pos, Vector3 dir, float power, bool right_hand, Game.HitTarget target)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x9EA790", Offset = "0x9EA790", VA = "0x9EA790")]
	public HitEffector()
	{
	}
}
[Token(Token = "0x200003B")]
public class HitFxController : MonoBehaviour
{
	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject impactMedFx;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject impactBigFx;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject varietySmalFx;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject varietyMedFx;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject varietyMaxFx;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject perfectFx;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject hiPowerFx;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Light light;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float animProgress;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timeToDelete;

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x9EA838", Offset = "0x9EA838", VA = "0x9EA838")]
	public void Play(Vector3 fx_pos, int speed, int timing, int variety)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x9EAC54", Offset = "0x9EAC54", VA = "0x9EAC54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x9EADA0", Offset = "0x9EADA0", VA = "0x9EADA0")]
	public HitFxController()
	{
	}
}
[Token(Token = "0x200003C")]
public interface IEnemy
{
	[Token(Token = "0x6000203")]
	void Despawn();

	[Token(Token = "0x6000204")]
	void Disapear();

	[Token(Token = "0x6000205")]
	void Activate();

	[Token(Token = "0x6000206")]
	void Deactivate();

	[Token(Token = "0x6000207")]
	Enemy GetEnemy();

	[Token(Token = "0x6000208")]
	bool IsComboSucess();

	[Token(Token = "0x6000209")]
	void StartCombo(float period);

	[Token(Token = "0x600020A")]
	bool IsDuringAttack();

	[Token(Token = "0x600020B")]
	bool IsLeftHandAttack();

	[Token(Token = "0x600020C")]
	bool IsRightHandAttack();

	[Token(Token = "0x600020D")]
	bool IsRightLegAttack();

	[Token(Token = "0x600020E")]
	bool IsLeftLegAttack();

	[Token(Token = "0x600020F")]
	void OnBlock();

	[Token(Token = "0x6000210")]
	void OnPlayerDamage();

	[Token(Token = "0x6000211")]
	void OnBodyPenetraaion(Vector3 avatar_pos);

	[Token(Token = "0x6000212")]
	void OnEndAttackAfterHit();

	[Token(Token = "0x6000213")]
	void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus);

	[Token(Token = "0x6000214")]
	void PlayEmot();

	[Token(Token = "0x6000215")]
	void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type);

	[Token(Token = "0x6000216")]
	void Strafe(bool left, float max_move_length);
}
[Token(Token = "0x200003D")]
public class Interactable : MonoBehaviour
{
	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRHandController handOpertating;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh illuminableMesh;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool dragable;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool usable;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x9EADB0", Offset = "0x9EADB0", VA = "0x9EADB0", Slot = "4")]
	public virtual void OnStartDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x9EADC4", Offset = "0x9EADC4", VA = "0x9EADC4", Slot = "5")]
	public virtual void OnFinishDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x9EAE50", Offset = "0x9EAE50", VA = "0x9EAE50", Slot = "6")]
	public virtual void OnStartUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x9EAE64", Offset = "0x9EAE64", VA = "0x9EAE64", Slot = "7")]
	public virtual void OnFinishUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x9E9434", Offset = "0x9E9434", VA = "0x9E9434")]
	public Interactable()
	{
	}
}
[Token(Token = "0x200003E")]
public class Item : MonoBehaviour
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x9EAEF0", Offset = "0x9EAEF0", VA = "0x9EAEF0")]
	public Item()
	{
	}
}
[Token(Token = "0x200003F")]
public class LanguageSetup : ItemsList
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Sprite[] sprites;

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x9EAEF8", Offset = "0x9EAEF8", VA = "0x9EAEF8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x9EAF78", Offset = "0x9EAF78", VA = "0x9EAF78", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x9EAF70", Offset = "0x9EAF70", VA = "0x9EAF70")]
	public void SetupLanguage(int lang)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x9EAFD0", Offset = "0x9EAFD0", VA = "0x9EAFD0", Slot = "4")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x9EB040", Offset = "0x9EB040", VA = "0x9EB040")]
	public LanguageSetup()
	{
	}
}
[Token(Token = "0x2000040")]
public class LastGameStatistics : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	public class EnemyAttackEvent
	{
		[Token(Token = "0x2000042")]
		public enum Type
		{
			[Token(Token = "0x4000304")]
			Hit,
			[Token(Token = "0x4000305")]
			Block,
			[Token(Token = "0x4000306")]
			Dodge
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float time;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9EB8D0", Offset = "0x9EB8D0", VA = "0x9EB8D0")]
		public EnemyAttackEvent()
		{
		}
	}

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TIMELINE_SPEED;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float CHART_RANGE;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float CHART_PAUSE;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float CHART_METERS_PER_SEC;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float PAUSE_TIME;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pause;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<EnemyAttackEvent> enemyAttackEvents;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<float> bpmMarkers;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem bpmPS;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem enemyAttacksPS;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float currentTime;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float progress;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float maxChartTime;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int bpmIDX;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int enemyAttackIDX;

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x9EB048", Offset = "0x9EB048", VA = "0x9EB048")]
	private void Start()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x9EB3D0", Offset = "0x9EB3D0", VA = "0x9EB3D0")]
	private void RestartDrawing()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9EB3E4", Offset = "0x9EB3E4", VA = "0x9EB3E4")]
	private void UpdateTimeAndPos()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x9EB580", Offset = "0x9EB580", VA = "0x9EB580")]
	private void Update()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x9EB818", Offset = "0x9EB818", VA = "0x9EB818")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x9EB1C0", Offset = "0x9EB1C0", VA = "0x9EB1C0")]
	private void FillFakeData()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x9EB8D8", Offset = "0x9EB8D8", VA = "0x9EB8D8")]
	public LastGameStatistics()
	{
	}
}
[Token(Token = "0x2000043")]
public class ListCylinder : MonoBehaviour
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 entryPos;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ItemsList parentList;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rotatorTransform;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool inUse;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float insideTime;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool handInside;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x9EB9E4", Offset = "0x9EB9E4", VA = "0x9EB9E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x9EBA40", Offset = "0x9EBA40", VA = "0x9EBA40")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x9EBBA0", Offset = "0x9EBBA0", VA = "0x9EBBA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x9EBBD8", Offset = "0x9EBBD8", VA = "0x9EBBD8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x9EBF08", Offset = "0x9EBF08", VA = "0x9EBF08")]
	public ListCylinder()
	{
	}
}
[Token(Token = "0x2000044")]
public class LiveTutorial : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	public enum TutorialStage
	{
		[Token(Token = "0x400032A")]
		Welcome,
		[Token(Token = "0x400032B")]
		OpponentPresentation,
		[Token(Token = "0x400032C")]
		ScoreIndicator,
		[Token(Token = "0x400032D")]
		PunchingSpeed,
		[Token(Token = "0x400032E")]
		AlternatingHands,
		[Token(Token = "0x400032F")]
		TargetingDifferentParts,
		[Token(Token = "0x4000330")]
		RhythmStriking,
		[Token(Token = "0x4000331")]
		Blocking,
		[Token(Token = "0x4000332")]
		BuildingCombo,
		[Token(Token = "0x4000333")]
		PerformingCombo,
		[Token(Token = "0x4000334")]
		ComboMultiplier,
		[Token(Token = "0x4000335")]
		FinishingMove,
		[Token(Token = "0x4000336")]
		Summary
	}

	[Token(Token = "0x2000046")]
	public enum StagePhase
	{
		[Token(Token = "0x4000338")]
		Presentation,
		[Token(Token = "0x4000339")]
		Task
	}

	[Token(Token = "0x2000047")]
	public delegate void StageSetup();

	[Token(Token = "0x2000048")]
	public delegate bool TaskCompletionCheck();

	[Token(Token = "0x2000049")]
	public struct StageData
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<StagePhase, string> dataIDs;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TaskCompletionCheck taskCheck;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StageSetup setupMethod;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StageSetup setupTaskMethod;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showProgress;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useSideConfiguration;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x9EDE3C", Offset = "0x9EDE3C", VA = "0x9EDE3C")]
		public StageData(Dictionary<StagePhase, string> dataIDs, StageSetup setupMethod, StageSetup setupTaskMethod, TaskCompletionCheck taskCheck, bool showProgress, bool useSideConfiguration)
		{
		}
	}

	[Token(Token = "0x200004A")]
	private sealed class <DespawnEnemy>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timeToDespawn>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x9EECB4", Offset = "0x9EECB4", VA = "0x9EECB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x9EECFC", Offset = "0x9EECFC", VA = "0x9EECFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x9ECA4C", Offset = "0x9ECA4C", VA = "0x9ECA4C")]
		[DebuggerHidden]
		public <DespawnEnemy>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x9EEC10", Offset = "0x9EEC10", VA = "0x9EEC10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x9EEC14", Offset = "0x9EEC14", VA = "0x9EEC14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x9EECBC", Offset = "0x9EECBC", VA = "0x9EECBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004B")]
	private sealed class <SetBodyPartsSkinAfter4Sec>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time_to_change>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x9EEDAC", Offset = "0x9EEDAC", VA = "0x9EEDAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x9EEDF4", Offset = "0x9EEDF4", VA = "0x9EEDF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x9ECA78", Offset = "0x9ECA78", VA = "0x9ECA78")]
		[DebuggerHidden]
		public <SetBodyPartsSkinAfter4Sec>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x9EED04", Offset = "0x9EED04", VA = "0x9EED04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9EED08", Offset = "0x9EED08", VA = "0x9EED08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x9EEDB4", Offset = "0x9EEDB4", VA = "0x9EEDB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004C")]
	private sealed class <ExecuteStage>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TutorialStage stage;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StagePhase phase;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private StageData <currentData>5__2;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <pause_time>5__3;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x9EF23C", Offset = "0x9EF23C", VA = "0x9EF23C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x9EF284", Offset = "0x9EF284", VA = "0x9EF284", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x9EE00C", Offset = "0x9EE00C", VA = "0x9EE00C")]
		[DebuggerHidden]
		public <ExecuteStage>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9EEDFC", Offset = "0x9EEDFC", VA = "0x9EEDFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x9EEE00", Offset = "0x9EEE00", VA = "0x9EEE00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9EF244", Offset = "0x9EF244", VA = "0x9EF244", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004D")]
	private sealed class <FadeOutAndChangeMusic>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <startVolume>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x9EF4AC", Offset = "0x9EF4AC", VA = "0x9EF4AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x9EF4F4", Offset = "0x9EF4F4", VA = "0x9EF4F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9EE6E8", Offset = "0x9EE6E8", VA = "0x9EE6E8")]
		[DebuggerHidden]
		public <FadeOutAndChangeMusic>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x9EF28C", Offset = "0x9EF28C", VA = "0x9EF28C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9EF290", Offset = "0x9EF290", VA = "0x9EF290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x9EF4B4", Offset = "0x9EF4B4", VA = "0x9EF4B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HUD hud;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject progressBar;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game game;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Enemy enemy;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource audioSrc;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text prompt;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VideoPlayer videoPlayer;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material progressMat;

	[Token(Token = "0x4000315")]
	private const float MAX_TASK_TIME = 12f;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float taskTime;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int oppPresProgress;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int alternatingHandsProgress;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int targetingDifferentPartsProgress;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int rhythmStrikingProgress;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int blockProgress;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float comboFinished;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float minPlayTime;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string lang;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private TutorialStage currentStage;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private StagePhase currentPhase;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<TutorialStage, StageData> tutorialData;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject videoBaseTransform;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject videoSideTransform;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool useSideConfiguration;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float switchTime;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject enemyBaseTransform;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject enemySideTransform;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float fadeOutTime;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x9EBF10", Offset = "0x9EBF10", VA = "0x9EBF10")]
	private void SetProgressMat(float progress)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x9EC01C", Offset = "0x9EC01C", VA = "0x9EC01C")]
	public void OnHit(float speed, int hit_level, int hand_variety, int body_variety)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x9EC2AC", Offset = "0x9EC2AC", VA = "0x9EC2AC")]
	private void OpponentPresentationSetup()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x9EC4B4", Offset = "0x9EC4B4", VA = "0x9EC4B4")]
	private bool OpponentPresentationTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x9EC4E4", Offset = "0x9EC4E4", VA = "0x9EC4E4")]
	private void PunchingSpeedTaskSetup()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x9EC51C", Offset = "0x9EC51C", VA = "0x9EC51C")]
	private bool PunchingSpeedTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x9EC564", Offset = "0x9EC564", VA = "0x9EC564")]
	private void AlternatingHandsTaskSetup()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x9EC5D0", Offset = "0x9EC5D0", VA = "0x9EC5D0")]
	private bool AlternatingHandsTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x9EC600", Offset = "0x9EC600", VA = "0x9EC600")]
	private void TargetingDifferentPartsSetup()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x9EC700", Offset = "0x9EC700", VA = "0x9EC700")]
	private bool TargetingDifferentPartsTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x9EC730", Offset = "0x9EC730", VA = "0x9EC730")]
	private void RhythmStrikingTaskSetup()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x9EC740", Offset = "0x9EC740", VA = "0x9EC740")]
	private bool RhythmStrikingTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x9EC770", Offset = "0x9EC770", VA = "0x9EC770")]
	private void BlockingTaskSetup()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x9EC7A0", Offset = "0x9EC7A0", VA = "0x9EC7A0")]
	public void OnBlockDodge()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x9EC7B0", Offset = "0x9EC7B0", VA = "0x9EC7B0")]
	private bool BlockingTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x9EC7E0", Offset = "0x9EC7E0", VA = "0x9EC7E0")]
	private void BuildingComboSetup()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x9EC818", Offset = "0x9EC818", VA = "0x9EC818")]
	private bool BuildingComboCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x9EC844", Offset = "0x9EC844", VA = "0x9EC844")]
	private void PerformingComboTaskSetup()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x9EC870", Offset = "0x9EC870", VA = "0x9EC870")]
	public void OnComboFinished()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x9EC87C", Offset = "0x9EC87C", VA = "0x9EC87C")]
	private bool PerformingComboCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x9EC8B0", Offset = "0x9EC8B0", VA = "0x9EC8B0")]
	private void ComboMultiplierSetup()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x9EC8D0", Offset = "0x9EC8D0", VA = "0x9EC8D0")]
	private void ComboMultiplierTaskSetup()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x9EC904", Offset = "0x9EC904", VA = "0x9EC904")]
	private bool ComboMultiplierCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x9EC938", Offset = "0x9EC938", VA = "0x9EC938")]
	private void FinishingMoveSetup()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x9EC958", Offset = "0x9EC958", VA = "0x9EC958")]
	private void FinishingMoveTaskSetup()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x9EC9EC", Offset = "0x9EC9EC", VA = "0x9EC9EC")]
	private bool FinishingMoveTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x9EC978", Offset = "0x9EC978", VA = "0x9EC978")]
	private IEnumerator DespawnEnemy()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x9ECA74", Offset = "0x9ECA74", VA = "0x9ECA74")]
	private void WelcomeSetup()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x9EC440", Offset = "0x9EC440", VA = "0x9EC440")]
	private IEnumerator SetBodyPartsSkinAfter4Sec()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x9ECAA0", Offset = "0x9ECAA0", VA = "0x9ECAA0")]
	private void PlayAudio(string audioFilePath)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x9ECBB0", Offset = "0x9ECBB0", VA = "0x9ECBB0")]
	private bool IsAudioPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x9ECC04", Offset = "0x9ECC04", VA = "0x9ECC04")]
	private void DisplayText(string textID)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x9ECC8C", Offset = "0x9ECC8C", VA = "0x9ECC8C")]
	private void PlayVideo(string videoFilePath)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x9ECD70", Offset = "0x9ECD70", VA = "0x9ECD70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x9EDF84", Offset = "0x9EDF84", VA = "0x9EDF84")]
	private IEnumerator ExecuteStage(TutorialStage stage, StagePhase phase)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x9EE034", Offset = "0x9EE034", VA = "0x9EE034")]
	private TutorialStage NextStage(TutorialStage current)
	{
		return default(TutorialStage);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x9EE03C", Offset = "0x9EE03C", VA = "0x9EE03C")]
	private void ShowHands()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x9EE160", Offset = "0x9EE160", VA = "0x9EE160")]
	private void HideHands()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x9EE284", Offset = "0x9EE284", VA = "0x9EE284")]
	private void Update()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x9EC670", Offset = "0x9EC670", VA = "0x9EC670")]
	private IEnumerator FadeOutAndChangeMusic(string title)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x9EE710", Offset = "0x9EE710", VA = "0x9EE710")]
	private void PlayFX(string fx_name, Vector3 fx_pos)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x9EC138", Offset = "0x9EC138", VA = "0x9EC138")]
	private void PlayQualityFX(int hit_quality)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x9EE870", Offset = "0x9EE870", VA = "0x9EE870")]
	private void LoadFirstScene()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x9EEAB4", Offset = "0x9EEAB4", VA = "0x9EEAB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x9EDC00", Offset = "0x9EDC00", VA = "0x9EDC00")]
	private void SetupLanguage()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x9EEB74", Offset = "0x9EEB74", VA = "0x9EEB74")]
	public LiveTutorial()
	{
	}
}
[Token(Token = "0x200004E")]
public class MainMenu : MonoBehaviour
{
	[Token(Token = "0x200004F")]
	public enum TypeOfTracks
	{
		[Token(Token = "0x4000395")]
		Unknow,
		[Token(Token = "0x4000396")]
		Official,
		[Token(Token = "0x4000397")]
		Custom,
		[Token(Token = "0x4000398")]
		MP3
	}

	[Token(Token = "0x2000050")]
	private class LocalTrackInfo
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int noSlots;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<List<string>> enemies;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string notes;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int bpm;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int length;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int rate;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x9F9834", Offset = "0x9F9834", VA = "0x9F9834")]
		public LocalTrackInfo()
		{
		}
	}

	[Token(Token = "0x2000051")]
	private class CachedSprite
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x9F98C4", Offset = "0x9F98C4", VA = "0x9F98C4")]
		public CachedSprite()
		{
		}
	}

	[Token(Token = "0x2000052")]
	public class ProgramTrack
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TypeOfTracks track_type;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int official_enemy_slot;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> enemies;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x9F98CC", Offset = "0x9F98CC", VA = "0x9F98CC")]
		public ProgramTrack()
		{
		}
	}

	[Token(Token = "0x2000053")]
	public class Program
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ProgramTrack> tracks;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int length;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bpm_min;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bpm_max;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int rate;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool random_program;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x9F9954", Offset = "0x9F9954", VA = "0x9F9954")]
		public Program()
		{
		}
	}

	[Token(Token = "0x2000054")]
	private sealed class <LoadLocalClipPrev>d__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenu <>4__this;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <path>5__2;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x9F9B9C", Offset = "0x9F9B9C", VA = "0x9F9B9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x9F9BE4", Offset = "0x9F9BE4", VA = "0x9F9BE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x9F99DC", Offset = "0x9F99DC", VA = "0x9F99DC")]
		[DebuggerHidden]
		public <LoadLocalClipPrev>d__98(int <>1__state)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x9F9A04", Offset = "0x9F9A04", VA = "0x9F9A04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9F9A08", Offset = "0x9F9A08", VA = "0x9F9A08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x9F9BA4", Offset = "0x9F9BA4", VA = "0x9F9BA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	private sealed class <WaitForWebRequest>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenu <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x9F9CDC", Offset = "0x9F9CDC", VA = "0x9F9CDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x9F9D24", Offset = "0x9F9D24", VA = "0x9F9D24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x9F9BEC", Offset = "0x9F9BEC", VA = "0x9F9BEC")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__99(int <>1__state)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9F9C14", Offset = "0x9F9C14", VA = "0x9F9C14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x9F9C18", Offset = "0x9F9C18", VA = "0x9F9C18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x9F9CE4", Offset = "0x9F9CE4", VA = "0x9F9CE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string CALCULATE_STATS_TRACK;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool HUB;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MainMenu instance;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeToRefreshAvatars;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string selTrackID;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string selProgramID;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset tracksFile;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset tracksMoreStrikesFile;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TrackList trackList;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Compositor compositor;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TrackList programItems;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TrackList playLists;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TypeOfTracks typeOfTracks;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button3D playButton;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Button3D addToPLButton;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Button3D officialTOTButton;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Button3D customTOTButton;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Button3D mp3TOTButton;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Button3D autostartButton;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Button3D moreStrikesButton;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Button3D opt1ChaButton;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Button3D opt2ChaButton;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Button3D opt3ChaButton;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image[] pot1ChaIcons;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image[] pot2ChaIcons;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image[] pot3ChaIcons;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Button3D[] customEnemySlot;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Image[] customEnemyIcons;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Button3D[] enemySelecetion;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject enemySelector;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject customMP3;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button3D[] arrenaButtons;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform[] avatarTransforms;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<GameObject> avatars;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int charatersOption;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private StatsSummary statsSummary;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameLeaderboard leaderboard;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject mp3HowTo;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Text mp3Path;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool makeMP3Test;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private int first_request_delay;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Button3D enterFolderButton;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Button3D processMP3Button;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Text mp3FreqVal;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Text mp3IntensityVal;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<LocalTrackInfo> localInfos;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Text SFXVolText;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Text SFXTypeText;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int selectedSlotToSet;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private float slotsAnimProgress;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private List<CachedSprite> cachedSprites;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private AsyncOperation operation;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private AudioSource musicSource;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float timeToRefreshPreview;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<Program> programs;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public TextAsset programsFile;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private int selectedProgramTrackIDX;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private string sceneToReload;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float timeToReload;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private float currHeight;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private float mp3TestTimer;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private int mp3TestStep;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public GameObject ToHideWhenHieghtSeupActive;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x9EF4FC", Offset = "0x9EF4FC", VA = "0x9EF4FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x9EF554", Offset = "0x9EF554", VA = "0x9EF554")]
	private void FirstInit()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x9EF7B8", Offset = "0x9EF7B8", VA = "0x9EF7B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x9F1D38", Offset = "0x9F1D38", VA = "0x9F1D38")]
	private void UpdateAvatars()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x9F23C4", Offset = "0x9F23C4", VA = "0x9F23C4")]
	private void DelayedRequest()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x9F249C", Offset = "0x9F249C", VA = "0x9F249C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x9F32AC", Offset = "0x9F32AC", VA = "0x9F32AC")]
	private void FillOfficialEnemyInfo(TrackList.TrackInfo info, ref string notes)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x9F33F8", Offset = "0x9F33F8", VA = "0x9F33F8")]
	private void FillCustomEnemyInfo(ref string notes)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x9F350C", Offset = "0x9F350C", VA = "0x9F350C")]
	private void FillLocalMusicNotes(ref string notes)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x9F36D8", Offset = "0x9F36D8", VA = "0x9F36D8")]
	private bool FillMP3MusicNotes(ref string notes, string track_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x9F3924", Offset = "0x9F3924", VA = "0x9F3924")]
	public void OnPlay()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x9F40C4", Offset = "0x9F40C4", VA = "0x9F40C4")]
	private void FillOfficialEnemyIcons()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x9F4944", Offset = "0x9F4944", VA = "0x9F4944")]
	public void OnSelectTrack(string track_id)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x9F159C", Offset = "0x9F159C", VA = "0x9F159C")]
	public void OnSelectProgram(string program_id)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x9F55B0", Offset = "0x9F55B0", VA = "0x9F55B0")]
	private void OnSelectIntensity(int data)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x9F5664", Offset = "0x9F5664", VA = "0x9F5664")]
	public void OnSelectArena(int arena_id)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x9F1AF8", Offset = "0x9F1AF8", VA = "0x9F1AF8")]
	private void RefreshArenaButtons()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x9F56DC", Offset = "0x9F56DC", VA = "0x9F56DC")]
	private void OnTimeBtwnSpawns(int data)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x9F577C", Offset = "0x9F577C", VA = "0x9F577C")]
	public void OnComposeTrack(string track_id, Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x9F5934", Offset = "0x9F5934", VA = "0x9F5934")]
	public void FillOfficialTracks()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x9F5E98", Offset = "0x9F5E98", VA = "0x9F5E98")]
	public void FillCustomTracks()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x9F3554", Offset = "0x9F3554", VA = "0x9F3554")]
	private LocalTrackInfo GetLocalInfoByID(string id)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x9EFBB4", Offset = "0x9EFBB4", VA = "0x9EFBB4")]
	private void ReadTracksInfos()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x9F1684", Offset = "0x9F1684", VA = "0x9F1684")]
	private void SwitchTypeOfTracks(TypeOfTracks new_type)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x9F6A9C", Offset = "0x9F6A9C", VA = "0x9F6A9C")]
	private void OnSwitchMoreStrikes()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x9F6B40", Offset = "0x9F6B40", VA = "0x9F6B40")]
	private void OnChangeAutoStart()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x9F6BCC", Offset = "0x9F6BCC", VA = "0x9F6BCC")]
	private void OnChangeSFXVol()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x9F6C94", Offset = "0x9F6C94", VA = "0x9F6C94")]
	private void MP3Navigation()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x9F6CB0", Offset = "0x9F6CB0", VA = "0x9F6CB0")]
	private void OnProcessMP3File()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x9F6CE4", Offset = "0x9F6CE4", VA = "0x9F6CE4")]
	private void OnChangeSFXType()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x9F1BA8", Offset = "0x9F1BA8", VA = "0x9F1BA8")]
	private void RefreshSetings()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x9F60B8", Offset = "0x9F60B8", VA = "0x9F60B8")]
	private void SwitchCharactersOption(int option)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x9F6DA0", Offset = "0x9F6DA0", VA = "0x9F6DA0")]
	public void OnSelectEnemySlot(int slot)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x9F7014", Offset = "0x9F7014", VA = "0x9F7014")]
	public void OnSelectEnemy(int enemy_id)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x9F1228", Offset = "0x9F1228", VA = "0x9F1228")]
	private void ResetCustomSlotsButtons()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x9F2CE0", Offset = "0x9F2CE0", VA = "0x9F2CE0")]
	private void UpdateEnemySlotSelection()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x9F6224", Offset = "0x9F6224", VA = "0x9F6224")]
	private void RefershEnemySlotsIcons()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x9F70A8", Offset = "0x9F70A8", VA = "0x9F70A8")]
	public void OnButton(Button3D.Type button_type, int data)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x9F2310", Offset = "0x9F2310", VA = "0x9F2310")]
	public string EnemyIDToName(int id)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x9F462C", Offset = "0x9F462C", VA = "0x9F462C")]
	public Sprite GetCachedSprite(string path)
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x9F63BC", Offset = "0x9F63BC", VA = "0x9F63BC")]
	public void OpenDirectory(string path, int min_index, int max_index)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x9F7DD8", Offset = "0x9F7DD8", VA = "0x9F7DD8")]
	private bool IsSupportedFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x9F7794", Offset = "0x9F7794", VA = "0x9F7794")]
	private int FillFiles(string path, FileInfo[] fileinfo, int no_records)
	{
		return default(int);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x9F7C20", Offset = "0x9F7C20", VA = "0x9F7C20")]
	private int FillGroupFiles(FileInfo[] fileinfo, int no_records, int min_index, int max_index)
	{
		return default(int);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x9F7E50", Offset = "0x9F7E50", VA = "0x9F7E50")]
	private IEnumerator LoadLocalClipPrev()
	{
		return null;
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x9F7EC4", Offset = "0x9F7EC4", VA = "0x9F7EC4")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x9F7F38", Offset = "0x9F7F38", VA = "0x9F7F38")]
	public void StopPreview()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x9F7F90", Offset = "0x9F7F90", VA = "0x9F7F90")]
	public void PlayPreview()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x9F80E0", Offset = "0x9F80E0", VA = "0x9F80E0")]
	public AudioSource GetMusicSource()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x9F2F1C", Offset = "0x9F2F1C", VA = "0x9F2F1C")]
	private void UpdatePreview()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x9F80E8", Offset = "0x9F80E8", VA = "0x9F80E8")]
	private void ParseEnemiesSection(string section, ref ProgramTrack track)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x9F825C", Offset = "0x9F825C", VA = "0x9F825C")]
	private void ParseStats(ref Program item, string config)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x9F0974", Offset = "0x9F0974", VA = "0x9F0974")]
	private void ReadPrograms()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x9F84BC", Offset = "0x9F84BC", VA = "0x9F84BC")]
	private Program GetProgramByID(string id)
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x9F1388", Offset = "0x9F1388", VA = "0x9F1388")]
	public void FillPlayLists()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x9F4D84", Offset = "0x9F4D84", VA = "0x9F4D84")]
	public void FillPlaylistTracks()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x9F7270", Offset = "0x9F7270", VA = "0x9F7270")]
	public void AddTrackToProgram()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x9F86D0", Offset = "0x9F86D0", VA = "0x9F86D0")]
	private void WriteProgram()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x9F8640", Offset = "0x9F8640", VA = "0x9F8640")]
	private void AfterProgramChanged()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x9F7550", Offset = "0x9F7550", VA = "0x9F7550")]
	private void OnChangeProgramTrack(int dir)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x9F9478", Offset = "0x9F9478", VA = "0x9F9478")]
	public void OnSelectProgramItem(int idx)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x9F2740", Offset = "0x9F2740", VA = "0x9F2740")]
	private bool UpdateHUB()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x9F3B68", Offset = "0x9F3B68", VA = "0x9F3B68")]
	private string RandomScene()
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x9F76F0", Offset = "0x9F76F0", VA = "0x9F76F0")]
	private void OnStartPlaylist()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x9F94EC", Offset = "0x9F94EC", VA = "0x9F94EC")]
	public float GetTimeToReload()
	{
		return default(float);
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x9F4000", Offset = "0x9F4000", VA = "0x9F4000")]
	public void ReloadScene(string scene_name, float time)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x9F2C38", Offset = "0x9F2C38", VA = "0x9F2C38")]
	private void UpdateReload()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x9F94F4", Offset = "0x9F94F4", VA = "0x9F94F4")]
	private void UpdateMenuHeight()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x9F310C", Offset = "0x9F310C", VA = "0x9F310C")]
	private void UpdateMakeMP3Test()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x9E9844", Offset = "0x9E9844", VA = "0x9E9844")]
	public void OnShowHeightSetup()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x9E97BC", Offset = "0x9E97BC", VA = "0x9E97BC")]
	public void OnHideHeightSetup()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x9F961C", Offset = "0x9F961C", VA = "0x9F961C")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x2000056")]
public class MixedRealityCaptureController : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	private enum CameraMode
	{
		[Token(Token = "0x40003BE")]
		Normal
	}

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inited;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CameraMode currentMode;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera defaultExternalCamera;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRPlugin.Fovf defaultFov;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 camePos;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion cameRot;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject testObj;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x9F9D2C", Offset = "0x9F9D2C", VA = "0x9F9D2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x9F9E28", Offset = "0x9F9E28", VA = "0x9F9E28")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x9FA06C", Offset = "0x9FA06C", VA = "0x9FA06C")]
	private void UpdateDefaultExternalCamera()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x9FA418", Offset = "0x9FA418", VA = "0x9FA418")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x9FA4B8", Offset = "0x9FA4B8", VA = "0x9FA4B8")]
	public MixedRealityCaptureController()
	{
	}
}
[Token(Token = "0x2000058")]
public class MRController : MonoBehaviour
{
	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool turnOnMR;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool setupFinished;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRPassthroughLayer pass_layer;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x9FA550", Offset = "0x9FA550", VA = "0x9FA550")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x9FA560", Offset = "0x9FA560", VA = "0x9FA560")]
	public void SetupMR()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x9FA70C", Offset = "0x9FA70C", VA = "0x9FA70C")]
	public MRController()
	{
	}
}
[Token(Token = "0x2000059")]
public class MultiTest : MonoBehaviour
{
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x9FA71C", Offset = "0x9FA71C", VA = "0x9FA71C")]
	public MultiTest()
	{
	}
}
[Token(Token = "0x200005A")]
public class Plug : MonoBehaviour
{
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x9FA724", Offset = "0x9FA724", VA = "0x9FA724")]
	public Plug()
	{
	}
}
[Token(Token = "0x200005B")]
public class PosLocker : MonoBehaviour
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 basePos;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion baseRot;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lastUpdateTime;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x9FA72C", Offset = "0x9FA72C", VA = "0x9FA72C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x9FA77C", Offset = "0x9FA77C", VA = "0x9FA77C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x9FA7FC", Offset = "0x9FA7FC", VA = "0x9FA7FC")]
	public PosLocker()
	{
	}
}
[Token(Token = "0x200005C")]
public class PuzzleBox : MonoBehaviour
{
	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRRig xrRig;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Quaternion rotationSpeed;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 fingerForces;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 basePos;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 currSpeed;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool animateTransform;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 leftHandForce;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 righHandForce;

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x9FA804", Offset = "0x9FA804", VA = "0x9FA804")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x9FA87C", Offset = "0x9FA87C", VA = "0x9FA87C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x9FAA50", Offset = "0x9FAA50", VA = "0x9FAA50")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x9FA880", Offset = "0x9FA880", VA = "0x9FA880")]
	private void AnimateTransform()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x9FB210", Offset = "0x9FB210", VA = "0x9FB210")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x9FB298", Offset = "0x9FB298", VA = "0x9FB298")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x9FB320", Offset = "0x9FB320", VA = "0x9FB320")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x9FB5C8", Offset = "0x9FB5C8", VA = "0x9FB5C8")]
	public PuzzleBox()
	{
	}
}
[Token(Token = "0x200005D")]
public class Socket : Interactable
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string correctPluginID;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] acceptedPluginIDs;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pluginTransform;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Mesh gizmoMesh;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x9FB70C", Offset = "0x9FB70C", VA = "0x9FB70C")]
	public Socket()
	{
	}
}
[Token(Token = "0x200005E")]
public class StatsSummary : MonoBehaviour
{
	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 basePos;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 baseScale;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion baseRot;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool animated;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text title;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text highScoreText;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text highScore;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text score;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text maxSpeedL;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text maxSpeedR;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text avgSpeedL;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text avgSpeedR;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text timingL;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text timingR;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text varietyL;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text varietyR;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text hitsL;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text hitsR;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text missedL;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text missedR;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text blocks;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text dodges;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Text damages;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject toHide;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject toShow;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool canAnimHiScore;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject[] fxes;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float waitTime;

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x9FB714", Offset = "0x9FB714", VA = "0x9FB714")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x9FC0A4", Offset = "0x9FC0A4", VA = "0x9FC0A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x9FC2F4", Offset = "0x9FC2F4", VA = "0x9FC2F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x9FC644", Offset = "0x9FC644", VA = "0x9FC644")]
	public StatsSummary()
	{
	}
}
[Token(Token = "0x200005F")]
public class TestMove : MonoBehaviour
{
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 basePos;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 destPos;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float movePeriod;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float releasePeriod;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float time;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Game game;

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x9FC65C", Offset = "0x9FC65C", VA = "0x9FC65C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x9FC6E8", Offset = "0x9FC6E8", VA = "0x9FC6E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x9FC7FC", Offset = "0x9FC7FC", VA = "0x9FC7FC")]
	public TestMove()
	{
	}
}
[Token(Token = "0x2000060")]
public class TouchMarker : Interactable
{
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Activator activator;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip touchSound;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource audioSource;

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x9FC80C", Offset = "0x9FC80C", VA = "0x9FC80C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x9FC8A8", Offset = "0x9FC8A8", VA = "0x9FC8A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x9FCA24", Offset = "0x9FCA24", VA = "0x9FCA24", Slot = "6")]
	public override void OnStartUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x9FCAC4", Offset = "0x9FCAC4", VA = "0x9FCAC4")]
	public TouchMarker()
	{
	}
}
[Token(Token = "0x2000061")]
public class TransformCopier : MonoBehaviour
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform baseTransform;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool copyPosition;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x9FCACC", Offset = "0x9FCACC", VA = "0x9FCACC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x9FCBC0", Offset = "0x9FCBC0", VA = "0x9FCBC0")]
	public TransformCopier()
	{
	}
}
[Token(Token = "0x2000062")]
public class TranslatorTool : MonoBehaviour
{
	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TranslatorTool instance;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] m_Text;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] m_ID;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextAsset m_EnTranslateFile;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAsset m_CnTranslateFile;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset m_JpTranslateFile;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset m_KrTranslateFile;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset m_FrTranslateFile;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset m_DeTranslateFile;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextAsset m_SpTranslateFile;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextAsset m_PtTranslateFile;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextAsset m_ThTranslateFile;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAsset m_ItTranslateFile;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<List<string>> m_Translate;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<string>> m_AllTranslates;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<string>> m_AllIDs;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int currLang;

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x9FCBC8", Offset = "0x9FCBC8", VA = "0x9FCBC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x9FD77C", Offset = "0x9FD77C", VA = "0x9FD77C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x9FD838", Offset = "0x9FD838", VA = "0x9FD838")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x9FD62C", Offset = "0x9FD62C", VA = "0x9FD62C")]
	private void SelectDefaultLanguage()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x9FD0B0", Offset = "0x9FD0B0", VA = "0x9FD0B0")]
	private void ReadTransalte(TextAsset translate_file)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x9FD7E4", Offset = "0x9FD7E4", VA = "0x9FD7E4")]
	public void SetupLanguage()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x9FD83C", Offset = "0x9FD83C", VA = "0x9FD83C")]
	private void SetupLanguage(int lang_idx)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x9FD99C", Offset = "0x9FD99C", VA = "0x9FD99C")]
	public string Translate(string text)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x9FDB3C", Offset = "0x9FDB3C", VA = "0x9FDB3C")]
	public TranslatorTool()
	{
	}
}
[Token(Token = "0x2000063")]
public class TutorialList : MonoBehaviour
{
	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] chapter0;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] chapter1;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] chapter2;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] chapter3;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] chapter4;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject[][] chapters;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject begining;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int currChapter;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int currProgress;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float scale;

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x9FDC1C", Offset = "0x9FDC1C", VA = "0x9FDC1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x9FE0D8", Offset = "0x9FE0D8", VA = "0x9FE0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x9FE2EC", Offset = "0x9FE2EC", VA = "0x9FE2EC")]
	private void StartVideo()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x9FE47C", Offset = "0x9FE47C", VA = "0x9FE47C")]
	public void OnSelectChapter(int chapter)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x9FE4AC", Offset = "0x9FE4AC", VA = "0x9FE4AC")]
	public TutorialList()
	{
	}
}
[Token(Token = "0x2000064")]
public class UIHeightItem : UIItem
{
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MeshRenderer unitQuad;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MeshRenderer tensQuad;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MeshRenderer hundredsQuad;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MeshRenderer cmQuad;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public MeshRenderer backQuad;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material normBackMat;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material highBackMat;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material[] digitsMat;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x9FE520", Offset = "0x9FE520", VA = "0x9FE520", Slot = "6")]
	public override bool SetHighlighted(bool val)
	{
		return default(bool);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x9FE580", Offset = "0x9FE580", VA = "0x9FE580", Slot = "5")]
	public override bool SetVersion(int idx, ItemsList list)
	{
		return default(bool);
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x9FE5C0", Offset = "0x9FE5C0", VA = "0x9FE5C0")]
	public UIHeightItem()
	{
	}
}
[Token(Token = "0x2000065")]
public class UILBEntry : MonoBehaviour
{
	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image background;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_LP;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_UserName;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_Score;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x9FE5C8", Offset = "0x9FE5C8", VA = "0x9FE5C8")]
	public UILBEntry()
	{
	}
}
[Token(Token = "0x2000066")]
public class CommonVR : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	public enum HDMType
	{
		[Token(Token = "0x4000447")]
		Pico,
		[Token(Token = "0x4000448")]
		Quest,
		[Token(Token = "0x4000449")]
		Steam,
		[Token(Token = "0x400044A")]
		Unknown
	}

	[Serializable]
	[Token(Token = "0x2000068")]
	private sealed class <>c
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Pico.Platform.Message<EntitlementCheckResult>.Handler <>9__3_1;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>.Handler <>9__3_0;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Oculus.Platform.Message.Callback <>9__4_0;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA023A0", Offset = "0xA023A0", VA = "0xA023A0")]
		public <>c()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA023A8", Offset = "0xA023A8", VA = "0xA023A8")]
		internal void <PicoEntitlementCheck>b__3_0(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> m)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA024C0", Offset = "0xA024C0", VA = "0xA024C0")]
		internal void <PicoEntitlementCheck>b__3_1(Pico.Platform.Message<EntitlementCheckResult> checkMessage)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA02504", Offset = "0xA02504", VA = "0xA02504")]
		internal void <OculusEntitlementCheck>b__4_0(Oculus.Platform.Message msg)
		{
		}
	}

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool entitlementCheck;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public HDMType hdmType;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float commonParam1;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float commonParam2;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MRController controllerMR;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XRHandController leftHand;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XRHandController rightHand;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Camera cameraVR;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool m_Blackout;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_BlackoutQuad;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_MenuWasPressed;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool m_MenuPressedNow;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_BlackoutScale;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CommonVR instance;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool useFPSGuard;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] fpsSamples;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float qualityStayTime;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool useLowQuality;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int noHiLoLoops;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool wasUpPressedL;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	private bool wasDownPressedL;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	private bool wasUpPressedR;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
	private bool wasDownPressedR;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool recordTransforms;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool playTransforms;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3[] headPositions;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Quaternion[] headRotations;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] leftHandPositions;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Quaternion[] leftHandRotations;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3[] rightHandPositions;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Quaternion[] rightHandRotations;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float currRecordTime;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string readFilePath;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float cameraSmooth;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float handSmooth;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int prevFrame;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject[] objToHideInDashboard;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool inDashboardMode;

	[Token(Token = "0x17000030")]
	public bool UpPressed
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA01EF4", Offset = "0xA01EF4", VA = "0xA01EF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000031")]
	public bool UpPressedL
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x9FF88C", Offset = "0x9FF88C", VA = "0x9FF88C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public bool UpPressedR
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x9FFA4C", Offset = "0x9FFA4C", VA = "0x9FFA4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	public bool DownPressed
	{
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA0203C", Offset = "0xA0203C", VA = "0xA0203C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public bool DownPressedL
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x9FF96C", Offset = "0x9FF96C", VA = "0x9FF96C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public bool DownPressedR
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x9FFB2C", Offset = "0x9FFB2C", VA = "0x9FFB2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x9FE5D0", Offset = "0x9FE5D0", VA = "0x9FE5D0")]
	private void SetupHDMType()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x9FE5DC", Offset = "0x9FE5DC", VA = "0x9FE5DC")]
	private void PicoEntitlementCheck()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x9FE718", Offset = "0x9FE718", VA = "0x9FE718")]
	private void OculusEntitlementCheck()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x9FE864", Offset = "0x9FE864", VA = "0x9FE864")]
	public XRHandController GetAnyHand()
	{
		return null;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x9FE8D8", Offset = "0x9FE8D8", VA = "0x9FE8D8")]
	private void UpdateFPSGuard()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x9FE998", Offset = "0x9FE998", VA = "0x9FE998")]
	private void Start()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x9FEA60", Offset = "0x9FEA60", VA = "0x9FEA60")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x9FEB8C", Offset = "0x9FEB8C", VA = "0x9FEB8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x9FF7BC", Offset = "0x9FF7BC", VA = "0x9FF7BC")]
	private void UpdateDebugParams()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x9FFC0C", Offset = "0x9FFC0C", VA = "0x9FFC0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xA014E0", Offset = "0xA014E0", VA = "0xA014E0")]
	public bool IsMenuPressedNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x9FFCA0", Offset = "0x9FFCA0", VA = "0x9FFCA0")]
	public bool IsMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xA014E8", Offset = "0xA014E8", VA = "0xA014E8")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xA01618", Offset = "0xA01618", VA = "0xA01618")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xA0170C", Offset = "0xA0170C", VA = "0xA0170C")]
	public Vector3 GetLHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xA017EC", Offset = "0xA017EC", VA = "0xA017EC")]
	public Vector3 GetRHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xA018CC", Offset = "0xA018CC", VA = "0xA018CC")]
	public Vector3 GetLHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xA019AC", Offset = "0xA019AC", VA = "0xA019AC")]
	public Vector3 GetRHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xA01A8C", Offset = "0xA01A8C", VA = "0xA01A8C")]
	public Vector3 GetPointerPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xA01BEC", Offset = "0xA01BEC", VA = "0xA01BEC")]
	public Vector3 GetPointerRot()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xA01D8C", Offset = "0xA01D8C", VA = "0xA01D8C")]
	public Vector3 GetPointerDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xA01E88", Offset = "0xA01E88", VA = "0xA01E88")]
	public Vector3 GetHeadPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xA01EB0", Offset = "0xA01EB0", VA = "0xA01EB0")]
	public Vector3 GetHeadDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xA01ED8", Offset = "0xA01ED8", VA = "0xA01ED8")]
	public bool IsHQVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x9FFD70", Offset = "0x9FFD70", VA = "0x9FFD70")]
	private void RecordTransforms()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xA02184", Offset = "0xA02184", VA = "0xA02184")]
	private void CreateTransformArrays(int count)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x9FED14", Offset = "0x9FED14", VA = "0x9FED14")]
	private void ReadTransforms()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xA00DC4", Offset = "0xA00DC4", VA = "0xA00DC4")]
	private void PlayTransforms()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xA012C4", Offset = "0xA012C4", VA = "0xA012C4")]
	private void UpdateDashboardMode()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xA02288", Offset = "0xA02288", VA = "0xA02288")]
	public CommonVR()
	{
	}
}
[Token(Token = "0x2000069")]
public class FingerSensor : MonoBehaviour
{
	[Token(Token = "0x200006A")]
	public enum FingerType
	{
		[Token(Token = "0x4000452")]
		Unknown,
		[Token(Token = "0x4000453")]
		Index,
		[Token(Token = "0x4000454")]
		Middle,
		[Token(Token = "0x4000455")]
		Ring,
		[Token(Token = "0x4000456")]
		Pinky,
		[Token(Token = "0x4000457")]
		Thumb
	}

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FingerType type;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRHandController hand;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xA02534", Offset = "0xA02534", VA = "0xA02534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xA025C0", Offset = "0xA025C0", VA = "0xA025C0")]
	public FingerSensor()
	{
	}
}
[Token(Token = "0x200006B")]
public enum HandType
{
	[Token(Token = "0x4000459")]
	Left,
	[Token(Token = "0x400045A")]
	Right
}
[Token(Token = "0x200006C")]
public class XRHandController : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	private class CachedAudioClip
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA05180", Offset = "0xA05180", VA = "0xA05180")]
		public CachedAudioClip()
		{
		}
	}

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool menuHand;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FingerSensor indexFinger;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float blockHitTime;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public HandType handType;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 prevPosition;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 avgSpeed;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float avgSpeedMagnitude;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Interactable bestInteractable;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isDragged;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool isInUse;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool isGrip;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	private bool wasGrip;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isTrigger;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool wasTrigger;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material illuminateMaterial;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource audioSource;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip[] hitSounds;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip missSound;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject visualisation;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 enterCollPos;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float collisionInfluence;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Light light;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material[] comboMaterials;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int varietyCounter;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int varietyValue;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private XRHandController otherHand;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject sphereMR;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Game game;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private CommonVR vr;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Game.HitTarget target;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float SFXVol;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int SFXType;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int hitHapticPower;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int lastHitHapticIDs;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int hapticDelay;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private AudioClip[] hitHapticClips;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private InputDevice m_InputDevice;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool wasCollsionLastTime;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Text debugText;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Canvas debugPanel;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public LineRenderer debugLine;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float indexValue;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private float thumbValue;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float threeFingersValue;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Animator animator;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject blockEffect;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Material progressMaterial;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public RectTransform progressTransform;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float progress;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private float animProgress;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<CachedAudioClip> cachedClips;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xA025C8", Offset = "0xA025C8", VA = "0xA025C8")]
	public bool IsInBody()
	{
		return default(bool);
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xA025F8", Offset = "0xA025F8", VA = "0xA025F8")]
	private void PlayHitFX(int hit_quality, float hit_speed)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xA02804", Offset = "0xA02804", VA = "0xA02804")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xA03858", Offset = "0xA03858", VA = "0xA03858")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xA0390C", Offset = "0xA0390C", VA = "0xA0390C")]
	private void SetupHaptic()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xA03A58", Offset = "0xA03A58", VA = "0xA03A58")]
	private void UpdateHaptic()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x9FC97C", Offset = "0x9FC97C", VA = "0x9FC97C")]
	public void AddHaptic(float power, float period)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xA03568", Offset = "0xA03568", VA = "0xA03568")]
	public void AddHitHaptic(float power)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xA03B64", Offset = "0xA03B64", VA = "0xA03B64")]
	private void Start()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xA03F70", Offset = "0xA03F70", VA = "0xA03F70")]
	private void Update()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xA04778", Offset = "0xA04778", VA = "0xA04778")]
	private void UpdateTrigger()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xA04578", Offset = "0xA04578", VA = "0xA04578")]
	private void UpdateGrip()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xA03B18", Offset = "0xA03B18", VA = "0xA03B18")]
	private InputDevice GetInputDevice()
	{
		return default(InputDevice);
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xA04B14", Offset = "0xA04B14", VA = "0xA04B14")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xA04BE4", Offset = "0xA04BE4", VA = "0xA04BE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xA036D0", Offset = "0xA036D0", VA = "0xA036D0")]
	public void ChangeVariety(int value)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xA04C2C", Offset = "0xA04C2C", VA = "0xA04C2C")]
	private void UpdateDebug()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xA04320", Offset = "0xA04320", VA = "0xA04320")]
	private void AnimateHand()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xA030A4", Offset = "0xA030A4", VA = "0xA030A4")]
	public void PlayBlockEffect(Collider other)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xA04CBC", Offset = "0xA04CBC", VA = "0xA04CBC")]
	public bool IncraseProgress(float val)
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xA04CF8", Offset = "0xA04CF8", VA = "0xA04CF8")]
	public void ResetProgress()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xA0494C", Offset = "0xA0494C", VA = "0xA0494C")]
	private void UpdateProgress()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xA04D00", Offset = "0xA04D00", VA = "0xA04D00")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xA05064", Offset = "0xA05064", VA = "0xA05064")]
	public void PlayRandomSound(string clip_name, int no_variants, float volume = 1f)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xA04DDC", Offset = "0xA04DDC", VA = "0xA04DDC")]
	public AudioClip GetCachedClip(string path)
	{
		return null;
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xA05188", Offset = "0xA05188", VA = "0xA05188")]
	public void PlaySFXSample()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xA052AC", Offset = "0xA052AC", VA = "0xA052AC")]
	public XRHandController()
	{
	}
}
[Token(Token = "0x200006E")]
public class SciFiBeamStatic : MonoBehaviour
{
	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject beamLineRendererPrefab;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject beamStartPrefab;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beamEndPrefab;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject beamStart;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject beamEnd;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beam;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer line;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool alwaysOn;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool beamCollides;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float beamLength;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float beamEndOffset;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float textureScrollSpeed;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float textureLengthScale;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xA053C8", Offset = "0xA053C8", VA = "0xA053C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xA056A8", Offset = "0xA056A8", VA = "0xA056A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xA057C0", Offset = "0xA057C0", VA = "0xA057C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xA053D8", Offset = "0xA053D8", VA = "0xA053D8")]
	public void SpawnBeam()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xA056AC", Offset = "0xA056AC", VA = "0xA056AC")]
	public void RemoveBeam()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xA05BC4", Offset = "0xA05BC4", VA = "0xA05BC4")]
	public SciFiBeamStatic()
	{
	}
}
[Token(Token = "0x200006F")]
public class SciFiLightFlicker : MonoBehaviour
{
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string waveFunction;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float startValue;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float amplitude;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float phase;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float frequency;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color originalColor;

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xA05BE4", Offset = "0xA05BE4", VA = "0xA05BE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xA05C48", Offset = "0xA05C48", VA = "0xA05C48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xA05CDC", Offset = "0xA05CDC", VA = "0xA05CDC")]
	private float EvalWave()
	{
		return default(float);
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xA05EA8", Offset = "0xA05EA8", VA = "0xA05EA8")]
	public SciFiLightFlicker()
	{
	}
}
[Token(Token = "0x2000070")]
public class assetUrl : MonoBehaviour
{
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string link;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xA05F10", Offset = "0xA05F10", VA = "0xA05F10")]
	public void url()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xA05F1C", Offset = "0xA05F1C", VA = "0xA05F1C")]
	public assetUrl()
	{
	}
}
[Token(Token = "0x2000071")]
public class camSlider : MonoBehaviour
{
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xA05F24", Offset = "0xA05F24", VA = "0xA05F24")]
	public void camX()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xA05F90", Offset = "0xA05F90", VA = "0xA05F90")]
	public void camY()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xA05FF4", Offset = "0xA05FF4", VA = "0xA05FF4")]
	public camSlider()
	{
	}
}
[Token(Token = "0x2000072")]
public class globalVolumeTuner : MonoBehaviour
{
	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xA06004", Offset = "0xA06004", VA = "0xA06004")]
	private void Start()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xA06010", Offset = "0xA06010", VA = "0xA06010")]
	public void slider()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xA0603C", Offset = "0xA0603C", VA = "0xA0603C")]
	public globalVolumeTuner()
	{
	}
}
[Token(Token = "0x2000073")]
public class HUDFPS : MonoBehaviour
{
	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float updateInterval;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float accum;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frames;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timeleft;

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xA06044", Offset = "0xA06044", VA = "0xA06044")]
	private void Start()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xA0613C", Offset = "0xA0613C", VA = "0xA0613C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xA06338", Offset = "0xA06338", VA = "0xA06338")]
	public HUDFPS()
	{
	}
}
[Token(Token = "0x2000074")]
public class KeyboardCameraControl : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public enum KeyboardAxis
	{
		[Token(Token = "0x40004B6")]
		Horizontal = 0,
		[Token(Token = "0x40004B7")]
		Vertical = 1,
		[Token(Token = "0x40004B8")]
		None = 3
	}

	[Serializable]
	[Token(Token = "0x2000076")]
	public class Modifiers
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftAlt;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool leftControl;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool leftShift;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA06A00", Offset = "0xA06A00", VA = "0xA06A00")]
		public bool checkModifiers()
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA069F8", Offset = "0xA069F8", VA = "0xA069F8")]
		public Modifiers()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000077")]
	public class KeyboardControlConfiguration
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public KeyboardAxis keyboardAxis;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA06708", Offset = "0xA06708", VA = "0xA06708")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA069F0", Offset = "0xA069F0", VA = "0xA069F0")]
		public KeyboardControlConfiguration()
		{
		}
	}

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public KeyboardControlConfiguration yaw;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeyboardControlConfiguration pitch;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public KeyboardControlConfiguration roll;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public KeyboardControlConfiguration verticalTranslation;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public KeyboardControlConfiguration horizontalTranslation;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public KeyboardControlConfiguration depthTranslation;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string keyboardHorizontalAxisName;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string keyboardVerticalAxisName;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] keyboardAxesNames;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xA06348", Offset = "0xA06348", VA = "0xA06348")]
	private void Start()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xA06428", Offset = "0xA06428", VA = "0xA06428")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xA06740", Offset = "0xA06740", VA = "0xA06740")]
	public KeyboardCameraControl()
	{
	}
}
[Token(Token = "0x2000078")]
public class limitFramerate : MonoBehaviour
{
	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int fps;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xA06A80", Offset = "0xA06A80", VA = "0xA06A80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xA06A8C", Offset = "0xA06A8C", VA = "0xA06A8C")]
	public limitFramerate()
	{
	}
}
[Token(Token = "0x2000079")]
public class magicEffectButton : MonoBehaviour
{
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string button;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem ps;

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xA06A9C", Offset = "0xA06A9C", VA = "0xA06A9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xA06B10", Offset = "0xA06B10", VA = "0xA06B10")]
	public void offOnButton()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xA06B78", Offset = "0xA06B78", VA = "0xA06B78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xA06BA4", Offset = "0xA06BA4", VA = "0xA06BA4")]
	public magicEffectButton()
	{
	}
}
[Token(Token = "0x200007A")]
public class materialColor : MonoBehaviour
{
	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] materials;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] rend;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem ps;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TrailRenderer[] trail;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text[] text;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color color2;

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xA06BAC", Offset = "0xA06BAC", VA = "0xA06BAC")]
	public void colorButtonWhite()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xA06ED4", Offset = "0xA06ED4", VA = "0xA06ED4")]
	public void colorButtonBlack()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xA06EE8", Offset = "0xA06EE8", VA = "0xA06EE8")]
	public void colorButtonRed()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xA06EFC", Offset = "0xA06EFC", VA = "0xA06EFC")]
	public void colorButtonYellow()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xA06F10", Offset = "0xA06F10", VA = "0xA06F10")]
	public void colorButtonGreen()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xA06F24", Offset = "0xA06F24", VA = "0xA06F24")]
	public void colorButtonCyan()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xA06F38", Offset = "0xA06F38", VA = "0xA06F38")]
	public void colorButtonBlue()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xA06F4C", Offset = "0xA06F4C", VA = "0xA06F4C")]
	public void colorButtonPurple()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xA06BC0", Offset = "0xA06BC0", VA = "0xA06BC0")]
	private void colorSwitch(Color color)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xA06F60", Offset = "0xA06F60", VA = "0xA06F60")]
	public materialColor()
	{
	}
}
[Token(Token = "0x200007B")]
public class MouseCameraControl : MonoBehaviour
{
	[Token(Token = "0x200007C")]
	public enum MouseButton
	{
		[Token(Token = "0x40004D4")]
		Left,
		[Token(Token = "0x40004D5")]
		Right,
		[Token(Token = "0x40004D6")]
		Middle,
		[Token(Token = "0x40004D7")]
		None
	}

	[Serializable]
	[Token(Token = "0x200007D")]
	public class Modifiers
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftAlt;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool leftControl;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool leftShift;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA074BC", Offset = "0xA074BC", VA = "0xA074BC")]
		public bool checkModifiers()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA074AC", Offset = "0xA074AC", VA = "0xA074AC")]
		public Modifiers()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007E")]
	public class MouseControlConfiguration
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public MouseButton mouseButton;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA071BC", Offset = "0xA071BC", VA = "0xA071BC")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA074A4", Offset = "0xA074A4", VA = "0xA074A4")]
		public MouseControlConfiguration()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007F")]
	public class MouseScrollConfiguration
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA071FC", Offset = "0xA071FC", VA = "0xA071FC")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA074B4", Offset = "0xA074B4", VA = "0xA074B4")]
		public MouseScrollConfiguration()
		{
		}
	}

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MouseControlConfiguration yaw;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MouseControlConfiguration pitch;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MouseControlConfiguration roll;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MouseControlConfiguration verticalTranslation;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MouseControlConfiguration horizontalTranslation;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MouseControlConfiguration depthTranslation;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MouseScrollConfiguration scroll;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string mouseHorizontalAxisName;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string mouseVerticalAxisName;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string scrollAxisName;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xA06F68", Offset = "0xA06F68", VA = "0xA06F68")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xA07228", Offset = "0xA07228", VA = "0xA07228")]
	public MouseCameraControl()
	{
	}
}
[Token(Token = "0x2000080")]
public class moveLimit : MonoBehaviour
{
	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 MinRange;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 MaxRange;

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xA0753C", Offset = "0xA0753C", VA = "0xA0753C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xA07610", Offset = "0xA07610", VA = "0xA07610")]
	public moveLimit()
	{
	}
}
[Token(Token = "0x2000081")]
public class PinchMove2 : MonoBehaviour
{
	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Touch touchOne;

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xA07630", Offset = "0xA07630", VA = "0xA07630")]
	private void Update()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xA0787C", Offset = "0xA0787C", VA = "0xA0787C")]
	public PinchMove2()
	{
	}
}
[Token(Token = "0x2000082")]
public class PinchMove3 : MonoBehaviour
{
	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Touch touchOne;

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xA07884", Offset = "0xA07884", VA = "0xA07884")]
	private void Update()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xA07AD0", Offset = "0xA07AD0", VA = "0xA07AD0")]
	public PinchMove3()
	{
	}
}
[Token(Token = "0x2000083")]
public class PinchVerticalTranslation : MonoBehaviour
{
	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivity;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Touch touchZero;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Touch touchOne;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public Touch touchTwo;

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xA07AD8", Offset = "0xA07AD8", VA = "0xA07AD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xA07D54", Offset = "0xA07D54", VA = "0xA07D54")]
	public PinchVerticalTranslation()
	{
	}
}
[Token(Token = "0x2000084")]
public class quitButton : MonoBehaviour
{
	[Token(Token = "0x600038B")]
	[Address(RVA = "0xA07D64", Offset = "0xA07D64", VA = "0xA07D64")]
	public void quit()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xA07D6C", Offset = "0xA07D6C", VA = "0xA07D6C")]
	public quitButton()
	{
	}
}
[Token(Token = "0x2000085")]
public class rotateButton : MonoBehaviour
{
	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform objectTransform;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 rotation;

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xA07D74", Offset = "0xA07D74", VA = "0xA07D74")]
	public void onButton()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xA07DC0", Offset = "0xA07DC0", VA = "0xA07DC0")]
	public rotateButton()
	{
	}
}
[Token(Token = "0x2000086")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xA07DC8", Offset = "0xA07DC8", VA = "0xA07DC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xA07E20", Offset = "0xA07E20", VA = "0xA07E20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xA07E28", Offset = "0xA07E28", VA = "0xA07E28")]
	public void clickOn()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xA07E80", Offset = "0xA07E80", VA = "0xA07E80")]
	public void clickOff()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xA07E88", Offset = "0xA07E88", VA = "0xA07E88")]
	private void rotate()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xA07ED8", Offset = "0xA07ED8", VA = "0xA07ED8")]
	public rotation()
	{
	}
}
[Token(Token = "0x2000087")]
public class sunSlider : MonoBehaviour
{
	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 rotateAxis;

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xA07EE0", Offset = "0xA07EE0", VA = "0xA07EE0")]
	public void sun()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xA0802C", Offset = "0xA0802C", VA = "0xA0802C")]
	public sunSlider()
	{
	}
}
[Token(Token = "0x2000088")]
public class toggleControl : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	public enum FOM
	{
		[Token(Token = "0x4000510")]
		none,
		[Token(Token = "0x4000511")]
		outInstantly,
		[Token(Token = "0x4000512")]
		outByTransparencyTintColor,
		[Token(Token = "0x4000513")]
		outByTransparencyColor,
		[Token(Token = "0x4000514")]
		outByCutoff,
		[Token(Token = "0x4000515")]
		inInstantly,
		[Token(Token = "0x4000516")]
		inByTransparencyTintColor,
		[Token(Token = "0x4000517")]
		inByTransparencyColor,
		[Token(Token = "0x4000518")]
		inByCutoff,
		[Token(Token = "0x4000519")]
		outInInstantly,
		[Token(Token = "0x400051A")]
		outInByTransparencyTintColor,
		[Token(Token = "0x400051B")]
		outInByTransparencyColor,
		[Token(Token = "0x400051C")]
		outInByCutoff
	}

	[Token(Token = "0x200008A")]
	private sealed class <outInNewPos>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public toggleControl <>4__this;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xA08F34", Offset = "0xA08F34", VA = "0xA08F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xA08F7C", Offset = "0xA08F7C", VA = "0xA08F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA08B20", Offset = "0xA08B20", VA = "0xA08B20")]
		[DebuggerHidden]
		public <outInNewPos>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA08D2C", Offset = "0xA08D2C", VA = "0xA08D2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA08D30", Offset = "0xA08D30", VA = "0xA08D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA08F3C", Offset = "0xA08F3C", VA = "0xA08F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public dispersePixels disperseScript;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera mainCamera;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int count;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] executionInterval;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] effects;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float[] maxPartilceMultiplier;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FOM[] fadingMode;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float[] fadingDelay;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float[] fadingDuration;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float[] outInDuration;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material[] materialSubstitute;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip[] audioClip;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string[] label;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text toggleText;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Toggle toggleButton;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Button prevButton;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Button nextButton;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Animator animator;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Toggle animationToggle;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 randPos;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 mousePos;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool mobile;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xA08044", Offset = "0xA08044", VA = "0xA08044")]
	private void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xA085D0", Offset = "0xA085D0", VA = "0xA085D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xA087EC", Offset = "0xA087EC", VA = "0xA087EC")]
	public void onOff()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xA08A9C", Offset = "0xA08A9C", VA = "0xA08A9C")]
	private IEnumerator outInNewPos(int i)
	{
		return null;
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xA08758", Offset = "0xA08758", VA = "0xA08758")]
	public void next()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xA087A4", Offset = "0xA087A4", VA = "0xA087A4")]
	public void prev()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xA08148", Offset = "0xA08148", VA = "0xA08148")]
	private void nextPrevAction(int i)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xA08B48", Offset = "0xA08B48", VA = "0xA08B48")]
	private void FOMConvert(int i)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xA08C68", Offset = "0xA08C68", VA = "0xA08C68")]
	public toggleControl()
	{
	}
}
[Token(Token = "0x200008B")]
public class toggleControlSingle : MonoBehaviour
{
	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] effects;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem[] ps;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle toggleButton;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text toggleText;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button prevButton;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button nextButton;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int count;

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xA08F84", Offset = "0xA08F84", VA = "0xA08F84")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xA09104", Offset = "0xA09104", VA = "0xA09104")]
	public void onOff()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xA091C8", Offset = "0xA091C8", VA = "0xA091C8")]
	public void next()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xA09318", Offset = "0xA09318", VA = "0xA09318")]
	public void prev()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xA09478", Offset = "0xA09478", VA = "0xA09478")]
	public toggleControlSingle()
	{
	}
}
[Token(Token = "0x200008C")]
public class toggleParticleSystem : MonoBehaviour
{
	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Toggle toggleButton;

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xA09480", Offset = "0xA09480", VA = "0xA09480")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xA094D8", Offset = "0xA094D8", VA = "0xA094D8")]
	public void onOff()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xA09518", Offset = "0xA09518", VA = "0xA09518")]
	public toggleParticleSystem()
	{
	}
}
[Token(Token = "0x200008D")]
public class TouchRotate : MonoBehaviour
{
	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xA09520", Offset = "0xA09520", VA = "0xA09520")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xA09668", Offset = "0xA09668", VA = "0xA09668")]
	public TouchRotate()
	{
	}
}
[Token(Token = "0x200008E")]
public class dispersePixels : MonoBehaviour
{
	[Token(Token = "0x200008F")]
	public enum FOM
	{
		[Token(Token = "0x400056D")]
		none,
		[Token(Token = "0x400056E")]
		outInstantly,
		[Token(Token = "0x400056F")]
		outByTransparencyTintColor,
		[Token(Token = "0x4000570")]
		outByTransparencyColor,
		[Token(Token = "0x4000571")]
		outByCutoff,
		[Token(Token = "0x4000572")]
		inInstantly,
		[Token(Token = "0x4000573")]
		inByTransparencyTintColor,
		[Token(Token = "0x4000574")]
		inByTransparencyColor,
		[Token(Token = "0x4000575")]
		inByCutoff,
		[Token(Token = "0x4000576")]
		outInInstantly,
		[Token(Token = "0x4000577")]
		outInByTransparencyTintColor,
		[Token(Token = "0x4000578")]
		outInByTransparencyColor,
		[Token(Token = "0x4000579")]
		outInByCutoff
	}

	[Token(Token = "0x2000090")]
	private sealed class <RestoreOrgTimeScale>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xA0DB2C", Offset = "0xA0DB2C", VA = "0xA0DB2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xA0DB74", Offset = "0xA0DB74", VA = "0xA0DB74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA0DA1C", Offset = "0xA0DA1C", VA = "0xA0DA1C")]
		[DebuggerHidden]
		public <RestoreOrgTimeScale>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA0DA44", Offset = "0xA0DA44", VA = "0xA0DA44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA0DA48", Offset = "0xA0DA48", VA = "0xA0DA48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA0DB34", Offset = "0xA0DB34", VA = "0xA0DB34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000091")]
	private sealed class <TintParticles>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xA0E6BC", Offset = "0xA0E6BC", VA = "0xA0E6BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xA0E704", Offset = "0xA0E704", VA = "0xA0E704", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA0DB7C", Offset = "0xA0DB7C", VA = "0xA0DB7C")]
		[DebuggerHidden]
		public <TintParticles>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA0DBA4", Offset = "0xA0DBA4", VA = "0xA0DBA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA0DBA8", Offset = "0xA0DBA8", VA = "0xA0DBA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA0E6C4", Offset = "0xA0E6C4", VA = "0xA0E6C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	private sealed class <FadeTargetObject>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xA10AD8", Offset = "0xA10AD8", VA = "0xA10AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xA10B20", Offset = "0xA10B20", VA = "0xA10B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA0E70C", Offset = "0xA0E70C", VA = "0xA0E70C")]
		[DebuggerHidden]
		public <FadeTargetObject>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA0E734", Offset = "0xA0E734", VA = "0xA0E734", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA0E738", Offset = "0xA0E738", VA = "0xA0E738", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA10AE0", Offset = "0xA10AE0", VA = "0xA10AE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float executionInterval;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] targetObject;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Camera mainCamera;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Camera disperseCamera;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 31f)]
	public int layerIndex;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool randomizeLayer;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(1f, 32f)]
	public int downsampling;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool transparentTarget;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator animator;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem disperseParticle;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool reinstantiate;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float destroyDelay;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool destroyOnDisable;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float tintingTime;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float sizeMultiplier;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int[] maxParticles;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float maxParticlesMultiplier;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3[] emitterBoxSize;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color gizmosColor;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector3[] pSystemOffset;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FOM fadingMode;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float fadingDelay;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float fadingDuration;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool animateAfterFadeIn;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Vector3 outInNewPosition;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float outInDuration;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Material[] materialSubstitute;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Material[] materialOriginal;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool playSound;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource audioSource;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioClip audioClip;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int soundOrigin;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public Vector3 soundOffset;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float soundDelay;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float _orgTimeScale;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int[] _componentTypes;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Renderer[] _renderers;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Image[] _UI_images;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Text[] _UI_texts;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int[] _orgObjectLayers;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject _disperseCameraClone;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Camera _disperseCamera;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Rect _viewRect;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector2 _viewRectDownsampled;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Texture2D _screenCapture1;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Texture2D _screenCapture2;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Canvas[] _UI_canvases;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject[] _PS_clones;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ParticleSystem[] _PS_components;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ParticleSystem.MainModule[] _PSM_mains;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float _PS_orgGravity;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private particleHomecoming[] _particleHomecomings;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Material[] _materials;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Color[] _orgColorRGBA;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float[] _orgColorAlpha;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject _audioClone;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private AudioSource _audio;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Collider[] _colliders;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private int _FOMifGroup;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool[] _materialChangeCondition;

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xA09670", Offset = "0xA09670", VA = "0xA09670")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xA0A96C", Offset = "0xA0A96C", VA = "0xA0A96C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xA0C8DC", Offset = "0xA0C8DC", VA = "0xA0C8DC")]
	private IEnumerator RestoreOrgTimeScale()
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xA0ABF0", Offset = "0xA0ABF0", VA = "0xA0ABF0")]
	private void DefineIfConditions()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xA0AD4C", Offset = "0xA0AD4C", VA = "0xA0AD4C")]
	private void ShootScreenCapture()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xA0B9E4", Offset = "0xA0B9E4", VA = "0xA0B9E4")]
	private void InitiateParticleSystems()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xA0C950", Offset = "0xA0C950", VA = "0xA0C950")]
	private IEnumerator TintParticles(int i)
	{
		return null;
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xA0C9D4", Offset = "0xA0C9D4", VA = "0xA0C9D4")]
	private Vector2 ClampDownsampleParticlePos(Vector2 _position)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xA0C858", Offset = "0xA0C858", VA = "0xA0C858")]
	private IEnumerator FadeTargetObject(int i)
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xA0CA70", Offset = "0xA0CA70", VA = "0xA0CA70")]
	private void WarnUnsupportedFOM(string _target, string _mode)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xA0CDF4", Offset = "0xA0CDF4", VA = "0xA0CDF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xA0D590", Offset = "0xA0D590", VA = "0xA0D590")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xA0D3D8", Offset = "0xA0D3D8", VA = "0xA0D3D8")]
	private void Annihilate()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xA0D594", Offset = "0xA0D594", VA = "0xA0D594")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xA0D8A4", Offset = "0xA0D8A4", VA = "0xA0D8A4")]
	public dispersePixels()
	{
	}
}
[Token(Token = "0x2000093")]
public class dispersePixelsInitiator : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	private sealed class <executeDispersePixels>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int i;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public dispersePixelsInitiator <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xA10DD0", Offset = "0xA10DD0", VA = "0xA10DD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xA10E18", Offset = "0xA10E18", VA = "0xA10E18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA10C08", Offset = "0xA10C08", VA = "0xA10C08")]
		[DebuggerHidden]
		public <executeDispersePixels>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA10CA8", Offset = "0xA10CA8", VA = "0xA10CA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA10CAC", Offset = "0xA10CAC", VA = "0xA10CAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xA10DD8", Offset = "0xA10DD8", VA = "0xA10DD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float executionInterval;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public dispersePixels[] dispersePixelsObjects;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint seed;

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xA10B28", Offset = "0xA10B28", VA = "0xA10B28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xA10B84", Offset = "0xA10B84", VA = "0xA10B84")]
	private IEnumerator executeDispersePixels(int i)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xA10C30", Offset = "0xA10C30", VA = "0xA10C30")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xA10C94", Offset = "0xA10C94", VA = "0xA10C94")]
	public dispersePixelsInitiator()
	{
	}
}
[Token(Token = "0x2000095")]
public class particleHomecoming : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	private sealed class <getStartPosition>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public particleHomecoming <>4__this;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <positionDiff>5__3;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xA1145C", Offset = "0xA1145C", VA = "0xA1145C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xA114A4", Offset = "0xA114A4", VA = "0xA114A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xA10F70", Offset = "0xA10F70", VA = "0xA10F70")]
		[DebuggerHidden]
		public <getStartPosition>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA10FB4", Offset = "0xA10FB4", VA = "0xA10FB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA10FB8", Offset = "0xA10FB8", VA = "0xA10FB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA11464", Offset = "0xA11464", VA = "0xA11464", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxSpeed;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float homingDelay;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool teleport;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 newPositionVector;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform newPositionTransform;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem m_System;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] startPosition;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int numParticlesAlive;

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xA10E20", Offset = "0xA10E20", VA = "0xA10E20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xA10EFC", Offset = "0xA10EFC", VA = "0xA10EFC")]
	private IEnumerator getStartPosition()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xA10F98", Offset = "0xA10F98", VA = "0xA10F98")]
	public particleHomecoming()
	{
	}
}
[Token(Token = "0x2000097")]
public class selfDestroy : MonoBehaviour
{
	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delayInSecond;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float activateDelay;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objToActivate;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MonoBehaviour monoToEnable;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer monoToDeactiave;

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xA114AC", Offset = "0xA114AC", VA = "0xA114AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xA11528", Offset = "0xA11528", VA = "0xA11528")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xA11698", Offset = "0xA11698", VA = "0xA11698")]
	public selfDestroy()
	{
	}
}
[Token(Token = "0x2000098")]
public class HUD : MonoBehaviour
{
	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game game;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR vr;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text fpsText;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text heightText;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text scoreText;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text multiText;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text healthText;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material comboMat;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject comboCircle;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float heightMeter;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool menusereHeight;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int prevScore;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int prevMul;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float comboValueA;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float comboValueB;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float time_to_save_height;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float fpsCount;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float[] fpsSamples;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject comboSucessFX;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float comboSucessProgress;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject comboSphereBack;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material comboSphereMat;

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xA116A8", Offset = "0xA116A8", VA = "0xA116A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xA11AC8", Offset = "0xA11AC8", VA = "0xA11AC8")]
	public void Show()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xA11AEC", Offset = "0xA11AEC", VA = "0xA11AEC")]
	public void OnComboSucess()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xA11B78", Offset = "0xA11B78", VA = "0xA11B78")]
	public void Hide()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xA11B9C", Offset = "0xA11B9C", VA = "0xA11B9C")]
	private void UpdateDebug()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xA120B0", Offset = "0xA120B0", VA = "0xA120B0")]
	private void UpdateComboCircle()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xA123F0", Offset = "0xA123F0", VA = "0xA123F0")]
	private bool UpdateComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xA12888", Offset = "0xA12888", VA = "0xA12888")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xA12F20", Offset = "0xA12F20", VA = "0xA12F20")]
	public void SetHealth(int health, int max_health)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xA12B58", Offset = "0xA12B58", VA = "0xA12B58")]
	private void UpdateOrientation(float dt)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xA13024", Offset = "0xA13024", VA = "0xA13024")]
	private void AdjustToStandardEnemy(Enemy enemy)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xA12D84", Offset = "0xA12D84", VA = "0xA12D84")]
	private void AdjustToEnemy()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xA136A0", Offset = "0xA136A0", VA = "0xA136A0")]
	public HUD()
	{
	}
}
[Token(Token = "0x2000099")]
public class LevelCompleted : MonoBehaviour
{
	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Game m_Game;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool m_LoadHUB;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_TimeToHide;

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xA1372C", Offset = "0xA1372C", VA = "0xA1372C")]
	public void Show()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xA13750", Offset = "0xA13750", VA = "0xA13750")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xA138C8", Offset = "0xA138C8", VA = "0xA138C8")]
	public void Hide()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xA1389C", Offset = "0xA1389C", VA = "0xA1389C")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xA138D8", Offset = "0xA138D8", VA = "0xA138D8")]
	public LevelCompleted()
	{
	}
}
[Token(Token = "0x200009A")]
public class ScorePanel : MonoBehaviour
{
	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlatCounter[] m_ScoreMuls;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FlatCounter m_Score;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer m_MulCircle;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color m_PositiveColor;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color m_NegativeColor;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color m_BaseColor;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float m_PrevMulProgressVal;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int m_PrevMulCount;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float m_MulImproveEffect;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_LocalScore;

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xA138E8", Offset = "0xA138E8", VA = "0xA138E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xA139A0", Offset = "0xA139A0", VA = "0xA139A0")]
	private void UpdateScoreCounter(int score)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xA13A10", Offset = "0xA13A10", VA = "0xA13A10")]
	private void UpdateScoreMulAnimation()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xA13D20", Offset = "0xA13D20", VA = "0xA13D20")]
	private void Update()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xA13DB0", Offset = "0xA13DB0", VA = "0xA13DB0")]
	private void UpdateOrientation()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xA13FCC", Offset = "0xA13FCC", VA = "0xA13FCC")]
	public ScorePanel()
	{
	}
}
[Token(Token = "0x200009B")]
public class movex : MonoBehaviour
{
	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yspeed;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float oldY;

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xA14004", Offset = "0xA14004", VA = "0xA14004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xA14030", Offset = "0xA14030", VA = "0xA14030")]
	private void Update()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xA140D8", Offset = "0xA140D8", VA = "0xA140D8")]
	public movex()
	{
	}
}
[Token(Token = "0x200009C")]
public class ItemsList : MonoBehaviour
{
	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRHandController <actveHand>k__BackingField;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIItem prefab;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int noVisibleItems;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float radius;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float visAngle;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform center;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rotator;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UIItem[] items;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float rotateSpeed;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float rotate;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool refreshSelected;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int noItems;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool hideWhenInactive;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool hidden;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool useProgressEvent;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int selectedIDX;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool waitToHandOut;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool loopedList;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float minRotate;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float maxRotate;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool ruletteMode;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float timeFromTouch;

	[Token(Token = "0x17000042")]
	public XRHandController actveHand
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA140E8", Offset = "0xA140E8", VA = "0xA140E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA140F0", Offset = "0xA140F0", VA = "0xA140F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xA140F8", Offset = "0xA140F8", VA = "0xA140F8")]
	private float CalculateItemAngleAndIDX(int i, ref int idx)
	{
		return default(float);
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xA14218", Offset = "0xA14218", VA = "0xA14218")]
	private void UpdateRotation()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xA14410", Offset = "0xA14410", VA = "0xA14410")]
	private void UpdateHighlight()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xA1448C", Offset = "0xA1448C", VA = "0xA1448C")]
	private void FillVisibleElements()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xA146CC", Offset = "0xA146CC", VA = "0xA146CC")]
	public void SelectItemUnderTouch(float touch_y_pos)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xA14800", Offset = "0xA14800", VA = "0xA14800")]
	public void OnClick(Vector3 touch_pos)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xA14898", Offset = "0xA14898", VA = "0xA14898")]
	private void Update()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xA149D4", Offset = "0xA149D4", VA = "0xA149D4")]
	public void SetMoveSpeed(float diff)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xA14A08", Offset = "0xA14A08", VA = "0xA14A08", Slot = "4")]
	public virtual void OnSelect(int idx)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xA14A9C", Offset = "0xA14A9C", VA = "0xA14A9C", Slot = "5")]
	public virtual void OnFillProgress()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xA14B70", Offset = "0xA14B70", VA = "0xA14B70")]
	public void RefreshList()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xA14BD0", Offset = "0xA14BD0", VA = "0xA14BD0")]
	public void SetSelected(int idx)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xA14C08", Offset = "0xA14C08", VA = "0xA14C08")]
	public void OnTouched()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xA14CAC", Offset = "0xA14CAC", VA = "0xA14CAC")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xA14CB4", Offset = "0xA14CB4", VA = "0xA14CB4")]
	private void SetupItems()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xA14F0C", Offset = "0xA14F0C", VA = "0xA14F0C", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xA14F24", Offset = "0xA14F24", VA = "0xA14F24")]
	public UIItem GetItemByIDX(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xA14C24", Offset = "0xA14C24", VA = "0xA14C24")]
	private void ShowItems()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xA1491C", Offset = "0xA1491C", VA = "0xA1491C")]
	private void HideItems()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xA14F80", Offset = "0xA14F80", VA = "0xA14F80", Slot = "7")]
	public virtual void SpecificUpdate()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xA14F84", Offset = "0xA14F84", VA = "0xA14F84", Slot = "8")]
	public virtual void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xA14F88", Offset = "0xA14F88", VA = "0xA14F88", Slot = "9")]
	public virtual void OnShowItems()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xA14F8C", Offset = "0xA14F8C", VA = "0xA14F8C", Slot = "10")]
	public virtual void OnHideItems()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xA14F90", Offset = "0xA14F90", VA = "0xA14F90")]
	public UIItem GetUIItemByIDX(int idx)
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xA14FEC", Offset = "0xA14FEC", VA = "0xA14FEC")]
	public ItemsList()
	{
	}
}
[Token(Token = "0x200009D")]
public class CircleSlider : MonoBehaviour
{
	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xA15028", Offset = "0xA15028", VA = "0xA15028")]
	private void Update()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xA15164", Offset = "0xA15164", VA = "0xA15164")]
	public CircleSlider()
	{
	}
}
[Token(Token = "0x200009E")]
public class CircleSliderA : MonoBehaviour
{
	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xA1517C", Offset = "0xA1517C", VA = "0xA1517C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xA151F4", Offset = "0xA151F4", VA = "0xA151F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xA15330", Offset = "0xA15330", VA = "0xA15330")]
	public CircleSliderA()
	{
	}
}
[Token(Token = "0x200009F")]
public class FourCirclePercent : MonoBehaviour
{
	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 9999f)]
	public float no1;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 9999f)]
	public float no2;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 9999f)]
	public float no3;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 9999f)]
	public float no4;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image a;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Image b;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image c;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image d;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t1;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t2;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text t3;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text t4;

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xA15348", Offset = "0xA15348", VA = "0xA15348")]
	private void Update()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xA15354", Offset = "0xA15354", VA = "0xA15354")]
	public void UpdatePercent(float n1, float n2, float n3, float n4)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xA15604", Offset = "0xA15604", VA = "0xA15604")]
	public FourCirclePercent()
	{
	}
}
[Token(Token = "0x20000A0")]
public class FourPercent : MonoBehaviour
{
	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 100f)]
	public float no2;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 100f)]
	public float no3;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 100f)]
	public float no4;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform a;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform b;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform c;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform d;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t1;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t2;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text t3;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text t4;

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xA1560C", Offset = "0xA1560C", VA = "0xA1560C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xA15618", Offset = "0xA15618", VA = "0xA15618")]
	public void UpdatePercent(float n1, float n2, float n3, float n4)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xA15A28", Offset = "0xA15A28", VA = "0xA15A28")]
	public FourPercent()
	{
	}
}
[Token(Token = "0x20000A1")]
public class GetTime : MonoBehaviour
{
	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xA15A38", Offset = "0xA15A38", VA = "0xA15A38")]
	private void Update()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xA15AD0", Offset = "0xA15AD0", VA = "0xA15AD0")]
	public GetTime()
	{
	}
}
[Token(Token = "0x20000A2")]
public class HillPercent : MonoBehaviour
{
	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform a;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text t1;

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xA15AD8", Offset = "0xA15AD8", VA = "0xA15AD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xA15AE0", Offset = "0xA15AE0", VA = "0xA15AE0")]
	public void UpdatePercent(float n1)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xA15BEC", Offset = "0xA15BEC", VA = "0xA15BEC")]
	public HillPercent()
	{
	}
}
[Token(Token = "0x20000A3")]
public class ImageBoard : MonoBehaviour
{
	[Token(Token = "0x600042D")]
	[Address(RVA = "0xA15BFC", Offset = "0xA15BFC", VA = "0xA15BFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xA15C84", Offset = "0xA15C84", VA = "0xA15C84")]
	public ImageBoard()
	{
	}
}
[Token(Token = "0x20000A4")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canRotate;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xA15C8C", Offset = "0xA15C8C", VA = "0xA15C8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xA15D4C", Offset = "0xA15D4C", VA = "0xA15D4C")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x20000A5")]
public class KeekOrit : MonoBehaviour
{
	[Token(Token = "0x6000431")]
	[Address(RVA = "0xA15D64", Offset = "0xA15D64", VA = "0xA15D64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xA15DCC", Offset = "0xA15DCC", VA = "0xA15DCC")]
	public KeekOrit()
	{
	}
}
[Token(Token = "0x20000A6")]
public class KeepSize : MonoBehaviour
{
	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetPosition;

	[Token(Token = "0x6000433")]
	[Address(RVA = "0xA15DD4", Offset = "0xA15DD4", VA = "0xA15DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xA15E14", Offset = "0xA15E14", VA = "0xA15E14")]
	public KeepSize()
	{
	}
}
[Token(Token = "0x20000A7")]
public class LineChart : MonoBehaviour
{
	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<RectTransform> allPoint;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject linePrefab;

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xA15E1C", Offset = "0xA15E1C", VA = "0xA15E1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xA15E20", Offset = "0xA15E20", VA = "0xA15E20")]
	private void InitPointAndLine()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xA16298", Offset = "0xA16298", VA = "0xA16298")]
	private void Update()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xA1629C", Offset = "0xA1629C", VA = "0xA1629C")]
	public void UpdateLineChart()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xA164DC", Offset = "0xA164DC", VA = "0xA164DC")]
	public LineChart()
	{
	}
}
[Token(Token = "0x20000A8")]
public class MyUIShape : Graphic
{
	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Transform> thepoints;

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xA16564", Offset = "0xA16564", VA = "0xA16564", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xA165D4", Offset = "0xA165D4", VA = "0xA165D4")]
	public void UpdateShape(List<Transform> theList)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xA16948", Offset = "0xA16948", VA = "0xA16948", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xA17040", Offset = "0xA17040", VA = "0xA17040")]
	public MyUIShape()
	{
	}
}
[Token(Token = "0x20000A9")]
public class OilGauge : MonoBehaviour
{
	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform oilOilGaugePivot;

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xA170EC", Offset = "0xA170EC", VA = "0xA170EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xA172B4", Offset = "0xA172B4", VA = "0xA172B4")]
	public OilGauge()
	{
	}
}
[Token(Token = "0x20000AA")]
public class OilGauge1 : MonoBehaviour
{
	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform oilOilGaugePivot;

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xA172CC", Offset = "0xA172CC", VA = "0xA172CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xA17464", Offset = "0xA17464", VA = "0xA17464")]
	public OilGauge1()
	{
	}
}
[Token(Token = "0x20000AB")]
public class PressedBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button btn;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform myIcon;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xA1747C", Offset = "0xA1747C", VA = "0xA1747C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xA17530", Offset = "0xA17530", VA = "0xA17530")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xA175F0", Offset = "0xA175F0", VA = "0xA175F0")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xA176C4", Offset = "0xA176C4", VA = "0xA176C4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xA176C8", Offset = "0xA176C8", VA = "0xA176C8", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xA176CC", Offset = "0xA176CC", VA = "0xA176CC", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xA176D0", Offset = "0xA176D0", VA = "0xA176D0", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xA176D4", Offset = "0xA176D4", VA = "0xA176D4")]
	public PressedBtn()
	{
	}
}
[Token(Token = "0x20000AC")]
public class RandomEnableAnimator : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	private sealed class <Show>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float f;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomEnableAnimator <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xA17970", Offset = "0xA17970", VA = "0xA17970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xA179B8", Offset = "0xA179B8", VA = "0xA179B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA17874", Offset = "0xA17874", VA = "0xA17874")]
		[DebuggerHidden]
		public <Show>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA178A4", Offset = "0xA178A4", VA = "0xA178A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xA178A8", Offset = "0xA178A8", VA = "0xA178A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA17978", Offset = "0xA17978", VA = "0xA17978", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator am;

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xA176DC", Offset = "0xA176DC", VA = "0xA176DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xA177F0", Offset = "0xA177F0", VA = "0xA177F0")]
	private IEnumerator Show(float f)
	{
		return null;
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xA1789C", Offset = "0xA1789C", VA = "0xA1789C")]
	public RandomEnableAnimator()
	{
	}
}
[Token(Token = "0x20000AE")]
public class RandomNumber : MonoBehaviour
{
	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text numText;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initInterval;

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xA179C0", Offset = "0xA179C0", VA = "0xA179C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xA17A30", Offset = "0xA17A30", VA = "0xA17A30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xA17AC4", Offset = "0xA17AC4", VA = "0xA17AC4")]
	public RandomNumber()
	{
	}
}
[Token(Token = "0x20000AF")]
public class RandomNumberPro : MonoBehaviour
{
	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text numText;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initInterval;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int min;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int Max;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xA17ACC", Offset = "0xA17ACC", VA = "0xA17ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xA17B3C", Offset = "0xA17B3C", VA = "0xA17B3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xA17BCC", Offset = "0xA17BCC", VA = "0xA17BCC")]
	public RandomNumberPro()
	{
	}
}
[Token(Token = "0x20000B0")]
public class RunningNumber : MonoBehaviour
{
	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text progress;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float time;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float number;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float targetNum;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeCost;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timer1;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xA17BE0", Offset = "0xA17BE0", VA = "0xA17BE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xA17D68", Offset = "0xA17D68", VA = "0xA17D68")]
	public RunningNumber()
	{
	}
}
[Token(Token = "0x20000B1")]
public class SimpleProgress : MonoBehaviour
{
	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xA17D7C", Offset = "0xA17D7C", VA = "0xA17D7C")]
	public void Start()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xA17DEC", Offset = "0xA17DEC", VA = "0xA17DEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xA17E50", Offset = "0xA17E50", VA = "0xA17E50")]
	public SimpleProgress()
	{
	}
}
[Token(Token = "0x20000B2")]
public class SimpleProgress1 : MonoBehaviour
{
	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xA17E60", Offset = "0xA17E60", VA = "0xA17E60")]
	public void Start()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xA17EB8", Offset = "0xA17EB8", VA = "0xA17EB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xA17F1C", Offset = "0xA17F1C", VA = "0xA17F1C")]
	public SimpleProgress1()
	{
	}
}
[Token(Token = "0x20000B3")]
public class SliderRunTo1 : MonoBehaviour
{
	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider slider;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xA17F2C", Offset = "0xA17F2C", VA = "0xA17F2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xA17F84", Offset = "0xA17F84", VA = "0xA17F84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xA17FF4", Offset = "0xA17FF4", VA = "0xA17FF4")]
	public SliderRunTo1()
	{
	}
}
[Token(Token = "0x20000B4")]
public class SliderRunTo1A : MonoBehaviour
{
	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider slider;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xA1800C", Offset = "0xA1800C", VA = "0xA1800C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xA18064", Offset = "0xA18064", VA = "0xA18064")]
	private void Update()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xA180D0", Offset = "0xA180D0", VA = "0xA180D0")]
	public SliderRunTo1A()
	{
	}
}
[Token(Token = "0x20000B5")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xA180E8", Offset = "0xA180E8", VA = "0xA180E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xA18140", Offset = "0xA18140", VA = "0xA18140")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xA18258", Offset = "0xA18258", VA = "0xA18258")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x20000B6")]
public class Spider : MonoBehaviour
{
	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject linePrefab;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Point;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float radius;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] testArray;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] testArray1;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool FillPolyGon;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MyUIShape myUIShape;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Transform> allPoint;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject theRoot;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> allRoot;

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xA18260", Offset = "0xA18260", VA = "0xA18260")]
	public void GenerateSpider(params float[] values0To1)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xA18CB4", Offset = "0xA18CB4", VA = "0xA18CB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xA18CBC", Offset = "0xA18CBC", VA = "0xA18CBC")]
	private void Update()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xA1863C", Offset = "0xA1863C", VA = "0xA1863C")]
	private void CreatePointsLines(int attributes)
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xA18A74", Offset = "0xA18A74", VA = "0xA18A74")]
	private void SetDataToSpider(params float[] values0To1)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xA18B44", Offset = "0xA18B44", VA = "0xA18B44")]
	private void InitPointAndLine()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xA182C8", Offset = "0xA182C8", VA = "0xA182C8")]
	private void ClearAll()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xA18D14", Offset = "0xA18D14", VA = "0xA18D14")]
	public void UpdateLineChart()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xA190C4", Offset = "0xA190C4", VA = "0xA190C4")]
	public Spider()
	{
	}
}
[Token(Token = "0x20000B7")]
[RequireComponent(typeof(Text))]
public class TextChangeMyColor : MonoBehaviour
{
	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color normalColor;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color highlightColor;

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xA19228", Offset = "0xA19228", VA = "0xA19228")]
	public void Start()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xA19294", Offset = "0xA19294", VA = "0xA19294")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xA192FC", Offset = "0xA192FC", VA = "0xA192FC")]
	public void OnExit()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xA19364", Offset = "0xA19364", VA = "0xA19364")]
	public TextChangeMyColor()
	{
	}
}
[Token(Token = "0x20000B8")]
[RequireComponent(typeof(Text))]
public class TextColorControl : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color normalColor;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color highlightColor;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xA1936C", Offset = "0xA1936C", VA = "0xA1936C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xA193D8", Offset = "0xA193D8", VA = "0xA193D8", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xA19440", Offset = "0xA19440", VA = "0xA19440", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xA194A8", Offset = "0xA194A8", VA = "0xA194A8")]
	public TextColorControl()
	{
	}
}
[Token(Token = "0x20000B9")]
public class ThreePercent : MonoBehaviour
{
	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 9999f)]
	public float no1;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 9999f)]
	public float no2;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 9999f)]
	public float no3;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image a;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Image b;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image c;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text t1;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t2;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t3;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xA194B0", Offset = "0xA194B0", VA = "0xA194B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xA194BC", Offset = "0xA194BC", VA = "0xA194BC")]
	public void UpdatePercent(float n1, float n2, float n3)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xA196C0", Offset = "0xA196C0", VA = "0xA196C0")]
	public ThreePercent()
	{
	}
}
[Token(Token = "0x20000BA")]
[RequireComponent(typeof(PolygonCollider2D))]
public class UIPolygon : Image
{
	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private PolygonCollider2D _polygon;

	[Token(Token = "0x17000045")]
	private PolygonCollider2D polygon
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA196C8", Offset = "0xA196C8", VA = "0xA196C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xA19768", Offset = "0xA19768", VA = "0xA19768")]
	protected UIPolygon()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0xA197CC", Offset = "0xA197CC", VA = "0xA197CC", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xA197E4", Offset = "0xA197E4", VA = "0xA197E4", Slot = "84")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000BB")]
public class Wavecircle : MonoBehaviour
{
	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform wave;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform s;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform e;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text theText;

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xA19840", Offset = "0xA19840", VA = "0xA19840")]
	private void Update()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xA19848", Offset = "0xA19848", VA = "0xA19848")]
	private void UpdatePercent(float f)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xA19A48", Offset = "0xA19A48", VA = "0xA19A48")]
	public Wavecircle()
	{
	}
}
[Token(Token = "0x20000BC")]
public class TrackList : ItemsList
{
	[Token(Token = "0x20000BD")]
	public class TrackInfo
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool directory;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool group;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool file;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int start_group_index;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int end_group_index;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bpm_min;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bpm_max;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int length;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int rate;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int slots;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MainMenu.TypeOfTracks type;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<List<string>> enemies;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA1AC68", Offset = "0xA1AC68", VA = "0xA1AC68")]
		public bool IsNavigation()
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA1B610", Offset = "0xA1B610", VA = "0xA1B610")]
		public TrackInfo()
		{
		}
	}

	[Token(Token = "0x20000BE")]
	public enum TypeOfList
	{
		[Token(Token = "0x4000670")]
		Tracks,
		[Token(Token = "0x4000671")]
		Programs,
		[Token(Token = "0x4000672")]
		ProgramItems
	}

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<TrackInfo> tracks;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TypeOfList typeOfList;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string prevComposeTrackID;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Button3D enterFolderButton;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Button3D processMP3Button;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 BUTTONS_TRANS;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 CUSTOM_MP3_TRANS;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject customMP3;

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xA19A50", Offset = "0xA19A50", VA = "0xA19A50", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xA1A7BC", Offset = "0xA1A7BC", VA = "0xA1A7BC")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xA1A838", Offset = "0xA1A838", VA = "0xA1A838")]
	public void AddData(TrackInfo track)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xA1A904", Offset = "0xA1A904", VA = "0xA1A904")]
	public TrackInfo GetInfoByID(string id)
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xA1A9D0", Offset = "0xA1A9D0", VA = "0xA1A9D0")]
	public TrackInfo GetTrackByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xA1AA30", Offset = "0xA1AA30", VA = "0xA1AA30")]
	public void SelectItem(string id)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xA1AB0C", Offset = "0xA1AB0C", VA = "0xA1AB0C", Slot = "4")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xA1AC88", Offset = "0xA1AC88", VA = "0xA1AC88")]
	public void OnProcessMP3File()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xA1AE98", Offset = "0xA1AE98", VA = "0xA1AE98")]
	private void UpdateProcessingProgress()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xA1B158", Offset = "0xA1B158", VA = "0xA1B158", Slot = "7")]
	public override void SpecificUpdate()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xA1B3A8", Offset = "0xA1B3A8", VA = "0xA1B3A8")]
	public void RevertOrder()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xA1B4AC", Offset = "0xA1B4AC", VA = "0xA1B4AC")]
	public UIItem GetUIItemByID(string id)
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xA1B56C", Offset = "0xA1B56C", VA = "0xA1B56C")]
	public TrackList()
	{
	}
}
[Token(Token = "0x20000BF")]
public class UIItem : MonoBehaviour
{
	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ItemsList parentList;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool highlighted;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite normalBack;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite highlightBack;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite emptyBack;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image icon;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int index;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text title;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro titlePro;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image background;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected float prevDissolve;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool empty;

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xA1B6A0", Offset = "0xA1B6A0", VA = "0xA1B6A0")]
	public int GetIDX()
	{
		return default(int);
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xA14BC4", Offset = "0xA14BC4", VA = "0xA14BC4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xA1B6A8", Offset = "0xA1B6A8", VA = "0xA1B6A8", Slot = "4")]
	public virtual void SetDissolve(float dissolve)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xA1B888", Offset = "0xA1B888", VA = "0xA1B888", Slot = "5")]
	public virtual bool SetVersion(int idx, ItemsList list)
	{
		return default(bool);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xA1B9D0", Offset = "0xA1B9D0", VA = "0xA1B9D0", Slot = "6")]
	public virtual bool SetHighlighted(bool val)
	{
		return default(bool);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xA1BC18", Offset = "0xA1BC18", VA = "0xA1BC18")]
	public UIItem()
	{
	}
}
[Token(Token = "0x20000C0")]
public class UITrackItem : UIItem
{
	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image[] infoIcons;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Image progress;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshPro bpm;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshPro length;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshPro rate;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Image folderIcon;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Image fileIcon;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image groupIcon;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image processingIcon;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject processingGroup;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image mp3Icon;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image customIcon;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image officialIcon;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image[] enemyIcons;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xA1BC30", Offset = "0xA1BC30", VA = "0xA1BC30", Slot = "4")]
	public override void SetDissolve(float dissolve)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0xA1C068", Offset = "0xA1C068", VA = "0xA1C068")]
	public UITrackItem()
	{
	}
}
[Token(Token = "0x20000C1")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string currentName;

	[Token(Token = "0x600049C")]
	[Address(RVA = "0xA1C080", Offset = "0xA1C080", VA = "0xA1C080")]
	private void Start()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xA1C1A8", Offset = "0xA1C1A8", VA = "0xA1C1A8")]
	public static string GetCurrent()
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xA1C1F0", Offset = "0xA1C1F0", VA = "0xA1C1F0")]
	public static void SetCurrent(string newCurrentName)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xA1C248", Offset = "0xA1C248", VA = "0xA1C248")]
	public GameManager()
	{
	}
}
[Token(Token = "0x20000C2")]
public class OrbitCamera2 : MonoBehaviour
{
	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxOffsetDistance;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float orbitSpeed;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float panSpeed;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float zoomSpeed;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 targetOffset;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 startPos;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 goTo;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion startRot;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Renderer rendd;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool setReset;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool autoReset;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float turnSpeed;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Slider mainSlider;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool state;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool curTabb;

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xA1C250", Offset = "0xA1C250", VA = "0xA1C250")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xA1C390", Offset = "0xA1C390", VA = "0xA1C390")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xA1CCFC", Offset = "0xA1CCFC", VA = "0xA1CCFC")]
	public void changeState(bool activ)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xA1CD08", Offset = "0xA1CD08", VA = "0xA1CD08")]
	public void setAutoRes(bool activ)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xA1CD14", Offset = "0xA1CD14", VA = "0xA1CD14")]
	public void turnSpeedf(float speed)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xA1CA08", Offset = "0xA1CA08", VA = "0xA1CA08")]
	public void TurnTable()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xA1CDBC", Offset = "0xA1CDBC", VA = "0xA1CDBC")]
	public static void SetNewResetCamPos(bool asd)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xA1CE08", Offset = "0xA1CE08", VA = "0xA1CE08")]
	public void SetNewResetCamPos2(bool asd)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xA1CBA0", Offset = "0xA1CBA0", VA = "0xA1CBA0")]
	public void NewResetCamPos()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xA1C3B0", Offset = "0xA1C3B0", VA = "0xA1C3B0")]
	public void MoveCam()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xA1CE54", Offset = "0xA1CE54", VA = "0xA1CE54")]
	public OrbitCamera2()
	{
	}
}
[Token(Token = "0x20000C3")]
public class SpawnArmor : MonoBehaviour
{
	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject current;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string currentAlienName;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool state;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Toggle touchToggle;

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xA1CEC0", Offset = "0xA1CEC0", VA = "0xA1CEC0")]
	private void SelectAlien(string name)
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xA1D118", Offset = "0xA1D118", VA = "0xA1D118")]
	public SpawnArmor()
	{
	}
}
[Token(Token = "0x20000C4")]
public class AnimateTiledTexture : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	public delegate void VoidEvent();

	[Token(Token = "0x20000C6")]
	private sealed class <updateTiling>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateTiledTexture <>4__this;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <checkAgainst>5__2;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xA1EC00", Offset = "0xA1EC00", VA = "0xA1EC00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xA1EC48", Offset = "0xA1EC48", VA = "0xA1EC48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA1EA54", Offset = "0xA1EA54", VA = "0xA1EA54")]
		[DebuggerHidden]
		public <updateTiling>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA1EA7C", Offset = "0xA1EA7C", VA = "0xA1EA7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA1EA80", Offset = "0xA1EA80", VA = "0xA1EA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA1EC08", Offset = "0xA1EC08", VA = "0xA1EC08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int _columns;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int _rows;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 _scale;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 _offset;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 _buffer;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _framesPerSecond;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool _playOnce;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool _disableUponCompletion;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool _enableEvents;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool _playOnEnable;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _newMaterialInstance;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int _index;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 _textureSize;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _materialInstance;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _hasMaterialInstance;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool _isPlaying;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<VoidEvent> _voidEventCallbackList;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xA1D120", Offset = "0xA1D120", VA = "0xA1D120")]
	public void RegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xA1D224", Offset = "0xA1D224", VA = "0xA1D224")]
	public void UnRegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xA1D2D0", Offset = "0xA1D2D0", VA = "0xA1D2D0")]
	public void Play()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xA1D3F0", Offset = "0xA1D3F0", VA = "0xA1D3F0")]
	public void ChangeMaterial(Material newMaterial, bool newInstance = false)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xA1D5A4", Offset = "0xA1D5A4", VA = "0xA1D5A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xA1D664", Offset = "0xA1D664", VA = "0xA1D664")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xA1D704", Offset = "0xA1D704", VA = "0xA1D704")]
	private void HandleCallbacks(List<VoidEvent> cbList)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xA1D7A0", Offset = "0xA1D7A0", VA = "0xA1D7A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xA1D580", Offset = "0xA1D580", VA = "0xA1D580")]
	private void CalcTextureSize()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xA1D37C", Offset = "0xA1D37C", VA = "0xA1D37C")]
	private IEnumerator updateTiling()
	{
		return null;
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xA1D7D0", Offset = "0xA1D7D0", VA = "0xA1D7D0")]
	private void ApplyOffset()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xA1D8E8", Offset = "0xA1D8E8", VA = "0xA1D8E8")]
	public AnimateTiledTexture()
	{
	}
}
[Token(Token = "0x20000C7")]
public class LiquidAnim : MonoBehaviour
{
	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Texture2D[] _animationTexture;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int AnimTileX;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int AnimTileY;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int animSpeedFPS;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int framesCount;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 textureSize;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 scrollSpeed;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _startTime;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector2 currentOffset;

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xA1EC50", Offset = "0xA1EC50", VA = "0xA1EC50")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xA1EFBC", Offset = "0xA1EFBC", VA = "0xA1EFBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xA1F174", Offset = "0xA1F174", VA = "0xA1F174")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xA1ECC0", Offset = "0xA1ECC0", VA = "0xA1ECC0")]
	public void InitAnimTexture()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xA1F25C", Offset = "0xA1F25C", VA = "0xA1F25C")]
	public LiquidAnim()
	{
	}
}
[Token(Token = "0x20000C8")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CursorLockMode lockCursor;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 sensitivity;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 smoothing;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 targetDirection;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject characterBody;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float acceleration;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float maxSpeed;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float dampingSpeed;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public KeyCode fwdKey;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public KeyCode leftKey;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public KeyCode backKey;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public KeyCode rightKey;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float speedX;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float speedZ;

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xA1F278", Offset = "0xA1F278", VA = "0xA1F278")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xA1F370", Offset = "0xA1F370", VA = "0xA1F370")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xA1F8E8", Offset = "0xA1F8E8", VA = "0xA1F8E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xA1FAE8", Offset = "0xA1FAE8", VA = "0xA1FAE8")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x20000C9")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x20000CA")]
	public delegate void OnClick();

	[Token(Token = "0x20000CB")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x20000CC")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x20000CD")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA211C0", Offset = "0xA211C0", VA = "0xA211C0")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA2212C", Offset = "0xA2212C", VA = "0xA2212C")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x20000CE")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA21488", Offset = "0xA21488", VA = "0xA21488")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA22150", Offset = "0xA22150", VA = "0xA22150")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x20000CF")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA216FC", Offset = "0xA216FC", VA = "0xA216FC")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA22174", Offset = "0xA22174", VA = "0xA22174")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000D0")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA218F8", Offset = "0xA218F8", VA = "0xA218F8")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xA2219C", Offset = "0xA2219C", VA = "0xA2219C")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000D1")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA21BF0", Offset = "0xA21BF0", VA = "0xA21BF0")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA221C4", Offset = "0xA221C4", VA = "0xA221C4")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40006D3")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40006D4")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40006D5")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xA1FB2C", Offset = "0xA1FB2C", VA = "0xA1FB2C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xA20098", Offset = "0xA20098", VA = "0xA20098")]
	public void Show()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xA20414", Offset = "0xA20414", VA = "0xA20414")]
	public void Hide()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xA20590", Offset = "0xA20590", VA = "0xA20590")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xA207A8", Offset = "0xA207A8", VA = "0xA207A8")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xA20404", Offset = "0xA20404", VA = "0xA20404")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xA20A9C", Offset = "0xA20A9C", VA = "0xA20A9C")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xA20E18", Offset = "0xA20E18", VA = "0xA20E18")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xA211C8", Offset = "0xA211C8", VA = "0xA211C8")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xA212C0", Offset = "0xA212C0", VA = "0xA212C0")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xA21490", Offset = "0xA21490", VA = "0xA21490")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xA21528", Offset = "0xA21528", VA = "0xA21528")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xA21704", Offset = "0xA21704", VA = "0xA21704")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xA21900", Offset = "0xA21900", VA = "0xA21900")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xA21BF8", Offset = "0xA21BF8", VA = "0xA21BF8")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xA21CE8", Offset = "0xA21CE8", VA = "0xA21CE8")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xA21D7C", Offset = "0xA21D7C", VA = "0xA21D7C")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000D2")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xA221EC", Offset = "0xA221EC", VA = "0xA221EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xA22290", Offset = "0xA22290", VA = "0xA22290")]
	private void Update()
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xA2232C", Offset = "0xA2232C", VA = "0xA2232C")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xA22364", Offset = "0xA22364", VA = "0xA22364")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000D3")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000D4")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000705")]
		On,
		[Token(Token = "0x4000706")]
		Off,
		[Token(Token = "0x4000707")]
		OnWhenHitTarget
	}

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000048")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA2236C", Offset = "0xA2236C", VA = "0xA2236C")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA20058", Offset = "0xA20058", VA = "0xA20058")]
		set
		{
		}
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xA22374", Offset = "0xA22374", VA = "0xA22374")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xA223CC", Offset = "0xA223CC", VA = "0xA223CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xA22504", Offset = "0xA22504", VA = "0xA22504", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xA22520", Offset = "0xA22520", VA = "0xA22520", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xA22570", Offset = "0xA22570", VA = "0xA22570")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xA22710", Offset = "0xA22710", VA = "0xA22710")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xA22820", Offset = "0xA22820", VA = "0xA22820")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xA228A4", Offset = "0xA228A4", VA = "0xA228A4")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xA22964", Offset = "0xA22964", VA = "0xA22964")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xA22A0C", Offset = "0xA22A0C", VA = "0xA22A0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xA22AF8", Offset = "0xA22AF8", VA = "0xA22AF8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000D5")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000708")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000709")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400070A")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float HeightOffset;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumHeight;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float MaximumHeight;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xA22B08", Offset = "0xA22B08", VA = "0xA22B08")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xA22B10", Offset = "0xA22B10", VA = "0xA22B10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xA22BA0", Offset = "0xA22BA0", VA = "0xA22BA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xA22CC4", Offset = "0xA22CC4", VA = "0xA22CC4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xA22DE8", Offset = "0xA22DE8", VA = "0xA22DE8")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xA23108", Offset = "0xA23108", VA = "0xA23108")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0xA23368", Offset = "0xA23368", VA = "0xA23368")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000D6")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xA23AC0", Offset = "0xA23AC0", VA = "0xA23AC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0xA23B6C", Offset = "0xA23B6C", VA = "0xA23B6C")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000D7")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000D8")]
	public enum States
	{
		[Token(Token = "0x4000738")]
		Ready,
		[Token(Token = "0x4000739")]
		Aim,
		[Token(Token = "0x400073A")]
		CancelAim,
		[Token(Token = "0x400073B")]
		PreTeleport,
		[Token(Token = "0x400073C")]
		CancelTeleport,
		[Token(Token = "0x400073D")]
		Teleporting,
		[Token(Token = "0x400073E")]
		PostTeleport
	}

	[Token(Token = "0x20000D9")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000740")]
		None,
		[Token(Token = "0x4000741")]
		Aim,
		[Token(Token = "0x4000742")]
		PreTeleport,
		[Token(Token = "0x4000743")]
		Teleport
	}

	[Token(Token = "0x20000DA")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000745")]
		Point,
		[Token(Token = "0x4000746")]
		Sphere,
		[Token(Token = "0x4000747")]
		Capsule
	}

	[Token(Token = "0x20000DB")]
	public class AimData
	{
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700004C")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xA258AC", Offset = "0xA258AC", VA = "0xA258AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xA258B4", Offset = "0xA258B4", VA = "0xA258B4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA25824", Offset = "0xA25824", VA = "0xA25824")]
		public AimData()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA258BC", Offset = "0xA258BC", VA = "0xA258BC")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xA25A24", Offset = "0xA25A24", VA = "0xA25A24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xA25A6C", Offset = "0xA25A6C", VA = "0xA25A6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA24578", Offset = "0xA24578", VA = "0xA24578")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA25914", Offset = "0xA25914", VA = "0xA25914", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA25918", Offset = "0xA25918", VA = "0xA25918", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA25A2C", Offset = "0xA25A2C", VA = "0xA25A2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DD")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xA25BD0", Offset = "0xA25BD0", VA = "0xA25BD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xA25C18", Offset = "0xA25C18", VA = "0xA25C18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xA24A00", Offset = "0xA24A00", VA = "0xA24A00")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xA25A74", Offset = "0xA25A74", VA = "0xA25A74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xA25A78", Offset = "0xA25A78", VA = "0xA25A78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA25BD8", Offset = "0xA25BD8", VA = "0xA25BD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DE")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xA25CD0", Offset = "0xA25CD0", VA = "0xA25CD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xA25D18", Offset = "0xA25D18", VA = "0xA25D18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xA24BD4", Offset = "0xA24BD4", VA = "0xA24BD4")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xA25C20", Offset = "0xA25C20", VA = "0xA25C20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xA25C24", Offset = "0xA25C24", VA = "0xA25C24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA25CD8", Offset = "0xA25CD8", VA = "0xA25CD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DF")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xA25E08", Offset = "0xA25E08", VA = "0xA25E08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xA25E50", Offset = "0xA25E50", VA = "0xA25E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA24DA8", Offset = "0xA24DA8", VA = "0xA24DA8")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA25D20", Offset = "0xA25D20", VA = "0xA25D20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA25D24", Offset = "0xA25D24", VA = "0xA25D24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xA25E10", Offset = "0xA25E10", VA = "0xA25E10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E0")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xA25F08", Offset = "0xA25F08", VA = "0xA25F08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xA25F50", Offset = "0xA25F50", VA = "0xA25F50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xA24F7C", Offset = "0xA24F7C", VA = "0xA24F7C")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xA25E58", Offset = "0xA25E58", VA = "0xA25E58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xA25E5C", Offset = "0xA25E5C", VA = "0xA25E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xA25F10", Offset = "0xA25F10", VA = "0xA25F10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E1")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xA2603C", Offset = "0xA2603C", VA = "0xA2603C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xA26084", Offset = "0xA26084", VA = "0xA26084", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xA25150", Offset = "0xA25150", VA = "0xA25150")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xA25F58", Offset = "0xA25F58", VA = "0xA25F58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xA25F5C", Offset = "0xA25F5C", VA = "0xA25F5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xA26044", Offset = "0xA26044", VA = "0xA26044", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E2")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xA2618C", Offset = "0xA2618C", VA = "0xA2618C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xA261D4", Offset = "0xA261D4", VA = "0xA261D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xA25324", Offset = "0xA25324", VA = "0xA25324")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xA2608C", Offset = "0xA2608C", VA = "0xA2608C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xA26090", Offset = "0xA26090", VA = "0xA26090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xA26194", Offset = "0xA26194", VA = "0xA26194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float AimCollisionRadius;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000049")]
	public States CurrentState
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xA23BBC", Offset = "0xA23BBC", VA = "0xA23BBC")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xA23BC4", Offset = "0xA23BC4", VA = "0xA23BC4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0xA23D94", Offset = "0xA23D94", VA = "0xA23D94")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700004B")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA23DB8", Offset = "0xA23DB8", VA = "0xA23DB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA23DC0", Offset = "0xA23DC0", VA = "0xA23DC0")]
		private set
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000509")]
		[Address(RVA = "0xA23BCC", Offset = "0xA23BCC", VA = "0xA23BCC")]
		add
		{
		}
		[Token(Token = "0x600050A")]
		[Address(RVA = "0xA23C7C", Offset = "0xA23C7C", VA = "0xA23C7C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA24440", Offset = "0xA24440", VA = "0xA24440")]
		add
		{
		}
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA244DC", Offset = "0xA244DC", VA = "0xA244DC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA245A0", Offset = "0xA245A0", VA = "0xA245A0")]
		add
		{
		}
		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA2463C", Offset = "0xA2463C", VA = "0xA2463C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA246D8", Offset = "0xA246D8", VA = "0xA246D8")]
		add
		{
		}
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA24788", Offset = "0xA24788", VA = "0xA24788")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA24854", Offset = "0xA24854", VA = "0xA24854")]
		add
		{
		}
		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA248F0", Offset = "0xA248F0", VA = "0xA248F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xA24A28", Offset = "0xA24A28", VA = "0xA24A28")]
		add
		{
		}
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xA24AC4", Offset = "0xA24AC4", VA = "0xA24AC4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000526")]
		[Address(RVA = "0xA24BFC", Offset = "0xA24BFC", VA = "0xA24BFC")]
		add
		{
		}
		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA24C98", Offset = "0xA24C98", VA = "0xA24C98")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA24DD0", Offset = "0xA24DD0", VA = "0xA24DD0")]
		add
		{
		}
		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA24E6C", Offset = "0xA24E6C", VA = "0xA24E6C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA24FA4", Offset = "0xA24FA4", VA = "0xA24FA4")]
		add
		{
		}
		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA25040", Offset = "0xA25040", VA = "0xA25040")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA25178", Offset = "0xA25178", VA = "0xA25178")]
		add
		{
		}
		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA25214", Offset = "0xA25214", VA = "0xA25214")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA2534C", Offset = "0xA2534C", VA = "0xA2534C")]
		add
		{
		}
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA253FC", Offset = "0xA253FC", VA = "0xA253FC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0xA23B74", Offset = "0xA23B74", VA = "0xA23B74")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0xA23B98", Offset = "0xA23B98", VA = "0xA23B98")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0xA23D2C", Offset = "0xA23D2C", VA = "0xA23D2C")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0xA23DC8", Offset = "0xA23DC8", VA = "0xA23DC8")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0xA24090", Offset = "0xA24090", VA = "0xA24090")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xA24138", Offset = "0xA24138", VA = "0xA24138")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xA24224", Offset = "0xA24224", VA = "0xA24224")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0xA24260", Offset = "0xA24260", VA = "0xA24260")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0xA24310", Offset = "0xA24310", VA = "0xA24310")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0xA24340", Offset = "0xA24340", VA = "0xA24340")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0xA243A0", Offset = "0xA243A0", VA = "0xA243A0", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0xA24438", Offset = "0xA24438", VA = "0xA24438", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0xA243C4", Offset = "0xA243C4", VA = "0xA243C4")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0xA24838", Offset = "0xA24838", VA = "0xA24838")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xA2498C", Offset = "0xA2498C", VA = "0xA2498C")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xA24B60", Offset = "0xA24B60", VA = "0xA24B60")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xA24D34", Offset = "0xA24D34", VA = "0xA24D34")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0xA24F08", Offset = "0xA24F08", VA = "0xA24F08")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xA250DC", Offset = "0xA250DC", VA = "0xA250DC")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0xA252B0", Offset = "0xA252B0", VA = "0xA252B0")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0xA254AC", Offset = "0xA254AC", VA = "0xA254AC")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xA255C0", Offset = "0xA255C0", VA = "0xA255C0")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0xA255F0", Offset = "0xA255F0", VA = "0xA255F0")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0xA2572C", Offset = "0xA2572C", VA = "0xA2572C")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0xA25814", Offset = "0xA25814", VA = "0xA25814")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000E3")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000E")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA22C28", Offset = "0xA22C28", VA = "0xA22C28")]
		add
		{
		}
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA22D4C", Offset = "0xA22D4C", VA = "0xA22D4C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA261DC", Offset = "0xA261DC", VA = "0xA261DC")]
		add
		{
		}
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xA26278", Offset = "0xA26278", VA = "0xA26278")]
		remove
		{
		}
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0xA26314", Offset = "0xA26314", VA = "0xA26314")]
	private void Awake()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0xA263F4", Offset = "0xA263F4", VA = "0xA263F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0xA26468", Offset = "0xA26468", VA = "0xA26468")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0xA2658C", Offset = "0xA2658C", VA = "0xA2658C")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0xA26804", Offset = "0xA26804", VA = "0xA26804")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0xA26A24", Offset = "0xA26A24", VA = "0xA26A24")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000E4")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000571")]
	[Address(RVA = "0xA26A44", Offset = "0xA26A44", VA = "0xA26A44", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0xA26AD4", Offset = "0xA26AD4", VA = "0xA26AD4", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000573")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000574")]
	[Address(RVA = "0xA26BA4", Offset = "0xA26BA4", VA = "0xA26BA4")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000E5")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x6000575")]
	[Address(RVA = "0xA26BB4", Offset = "0xA26BB4", VA = "0xA26BB4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0xA26D44", Offset = "0xA26D44", VA = "0xA26D44")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000E6")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumElevation;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Gravity;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x6000577")]
	[Address(RVA = "0xA26D54", Offset = "0xA26D54", VA = "0xA26D54", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0xA26F28", Offset = "0xA26F28", VA = "0xA26F28")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000E7")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000579")]
	[Address(RVA = "0xA26F3C", Offset = "0xA26F3C", VA = "0xA26F3C")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0xA27068", Offset = "0xA27068", VA = "0xA27068")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0xA27094", Offset = "0xA27094", VA = "0xA27094")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0xA270C0", Offset = "0xA270C0", VA = "0xA270C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0xA27164", Offset = "0xA27164", VA = "0xA27164", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0xA271B8", Offset = "0xA271B8", VA = "0xA271B8", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0xA27208", Offset = "0xA27208", VA = "0xA27208")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000E8")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform PositionIndicator;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform OrientationIndicator;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700005B")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xA27304", Offset = "0xA27304", VA = "0xA27304")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000581")]
		[Address(RVA = "0xA2730C", Offset = "0xA2730C", VA = "0xA2730C")]
		private set
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xA27494", Offset = "0xA27494", VA = "0xA27494")]
		add
		{
		}
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xA27544", Offset = "0xA27544", VA = "0xA27544")]
		remove
		{
		}
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0xA27318", Offset = "0xA27318", VA = "0xA27318")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0xA2739C", Offset = "0xA2739C", VA = "0xA2739C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0xA27460", Offset = "0xA27460", VA = "0xA27460")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0xA27490", Offset = "0xA27490", VA = "0xA27490")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0xA2423C", Offset = "0xA2423C", VA = "0xA2423C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0xA275F4", Offset = "0xA275F4", VA = "0xA275F4")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0xA27610", Offset = "0xA27610", VA = "0xA27610", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000E9")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000EA")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xA27BD8", Offset = "0xA27BD8", VA = "0xA27BD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xA27C20", Offset = "0xA27C20", VA = "0xA27C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xA27A44", Offset = "0xA27A44", VA = "0xA27A44")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xA27B48", Offset = "0xA27B48", VA = "0xA27B48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xA27B4C", Offset = "0xA27B4C", VA = "0xA27B4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xA27BE0", Offset = "0xA27BE0", VA = "0xA27BE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xA27CC4", Offset = "0xA27CC4", VA = "0xA27CC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0xA27D0C", Offset = "0xA27D0C", VA = "0xA27D0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xA27AE0", Offset = "0xA27AE0", VA = "0xA27AE0")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xA27C28", Offset = "0xA27C28", VA = "0xA27C28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xA27C2C", Offset = "0xA27C2C", VA = "0xA27C2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA27CCC", Offset = "0xA27CCC", VA = "0xA27CCC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600058B")]
	[Address(RVA = "0xA27804", Offset = "0xA27804", VA = "0xA27804")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0xA278D8", Offset = "0xA278D8", VA = "0xA278D8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0xA27924", Offset = "0xA27924", VA = "0xA27924", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0xA279D0", Offset = "0xA279D0", VA = "0xA279D0")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0xA27A6C", Offset = "0xA27A6C", VA = "0xA27A6C")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000590")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000591")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x6000592")]
	[Address(RVA = "0xA27B08", Offset = "0xA27B08", VA = "0xA27B08")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0xA27B28", Offset = "0xA27B28", VA = "0xA27B28")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000EC")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool FastTeleport;

	[Token(Token = "0x17000060")]
	public Transform Pointer
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xA27D14", Offset = "0xA27D14", VA = "0xA27D14")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xA27D1C", Offset = "0xA27D1C", VA = "0xA27D1C")]
		private set
		{
		}
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0xA27D24", Offset = "0xA27D24", VA = "0xA27D24", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xA27E50", Offset = "0xA27E50", VA = "0xA27E50", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xA27F04", Offset = "0xA27F04", VA = "0xA27F04")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000ED")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000EE")]
	public enum InputModes
	{
		[Token(Token = "0x4000798")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x4000799")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400079A")]
		ThumbstickTeleport,
		[Token(Token = "0x400079B")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000EF")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x400079D")]
		A,
		[Token(Token = "0x400079E")]
		B,
		[Token(Token = "0x400079F")]
		LeftTrigger,
		[Token(Token = "0x40007A0")]
		LeftThumbstick,
		[Token(Token = "0x40007A1")]
		RightTrigger,
		[Token(Token = "0x40007A2")]
		RightThumbstick,
		[Token(Token = "0x40007A3")]
		X,
		[Token(Token = "0x40007A4")]
		Y
	}

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputModes InputMode;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xA27F08", Offset = "0xA27F08", VA = "0xA27F08", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0xA2833C", Offset = "0xA2833C", VA = "0xA2833C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0xA283F8", Offset = "0xA283F8", VA = "0xA283F8")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000F0")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000F1")]
	public enum OrientationModes
	{
		[Token(Token = "0x40007A9")]
		HeadRelative,
		[Token(Token = "0x40007AA")]
		ForwardFacing
	}

	[Token(Token = "0x20000F2")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xA288A8", Offset = "0xA288A8", VA = "0xA288A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xA288F0", Offset = "0xA288F0", VA = "0xA288F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA286B8", Offset = "0xA286B8", VA = "0xA286B8")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA287F8", Offset = "0xA287F8", VA = "0xA287F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA287FC", Offset = "0xA287FC", VA = "0xA287FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA288B0", Offset = "0xA288B0", VA = "0xA288B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xA284E8", Offset = "0xA284E8", VA = "0xA284E8")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0xA285D0", Offset = "0xA285D0", VA = "0xA285D0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0xA285D8", Offset = "0xA285D8", VA = "0xA285D8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0xA28610", Offset = "0xA28610", VA = "0xA28610", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0xA28644", Offset = "0xA28644", VA = "0xA28644")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005AD")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60005AE")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0xA286E0", Offset = "0xA286E0", VA = "0xA286E0")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0xA287D8", Offset = "0xA287D8", VA = "0xA287D8")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000F3")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0xA288F8", Offset = "0xA288F8", VA = "0xA288F8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xA288FC", Offset = "0xA288FC", VA = "0xA288FC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0xA289A4", Offset = "0xA289A4", VA = "0xA289A4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000F4")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0xA289A8", Offset = "0xA289A8", VA = "0xA289A8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0xA289F8", Offset = "0xA289F8", VA = "0xA289F8", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0xA28EBC", Offset = "0xA28EBC", VA = "0xA28EBC")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000F5")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float RotateStickThreshold;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0xA28EC0", Offset = "0xA28EC0", VA = "0xA28EC0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0xA28EF4", Offset = "0xA28EF4", VA = "0xA28EF4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0xA293F0", Offset = "0xA293F0", VA = "0xA293F0")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000F6")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0xA29400", Offset = "0xA29400", VA = "0xA29400")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0xA29408", Offset = "0xA29408", VA = "0xA29408")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0xA294F4", Offset = "0xA294F4", VA = "0xA294F4")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0xA29510", Offset = "0xA29510", VA = "0xA29510")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000F7")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000063")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xA29528", Offset = "0xA29528", VA = "0xA29528")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xA29530", Offset = "0xA29530", VA = "0xA29530")]
		private set
		{
		}
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0xA26A6C", Offset = "0xA26A6C", VA = "0xA26A6C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0xA26B7C", Offset = "0xA26B7C", VA = "0xA26B7C", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0xA29538", Offset = "0xA29538", VA = "0xA29538")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0xA271AC", Offset = "0xA271AC", VA = "0xA271AC", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xA27200", Offset = "0xA27200", VA = "0xA27200", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xA26BAC", Offset = "0xA26BAC", VA = "0xA26BAC")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000F8")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000F9")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xA29C28", Offset = "0xA29C28", VA = "0xA29C28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xA29C70", Offset = "0xA29C70", VA = "0xA29C70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xA297E0", Offset = "0xA297E0", VA = "0xA297E0")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xA2995C", Offset = "0xA2995C", VA = "0xA2995C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA29960", Offset = "0xA29960", VA = "0xA29960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA29C30", Offset = "0xA29C30", VA = "0xA29C30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40007C4")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0xA29608", Offset = "0xA29608", VA = "0xA29608")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0xA29720", Offset = "0xA29720", VA = "0xA29720", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xA29748", Offset = "0xA29748", VA = "0xA29748", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0xA2976C", Offset = "0xA2976C", VA = "0xA2976C")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0xA29808", Offset = "0xA29808", VA = "0xA29808", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60005D1")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0xA29820", Offset = "0xA29820", VA = "0xA29820", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0xA2993C", Offset = "0xA2993C", VA = "0xA2993C")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000FA")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0xA29C78", Offset = "0xA29C78", VA = "0xA29C78")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0xA29CE0", Offset = "0xA29CE0", VA = "0xA29CE0", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0xA29E48", Offset = "0xA29E48", VA = "0xA29E48", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0xA29F34", Offset = "0xA29F34", VA = "0xA29F34")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000FB")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float LOSOffset;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0xA29F40", Offset = "0xA29F40", VA = "0xA29F40", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xA2A138", Offset = "0xA2A138", VA = "0xA2A138")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000FC")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xA2A144", Offset = "0xA2A144", VA = "0xA2A144", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xA2A2AC", Offset = "0xA2A2AC", VA = "0xA2A2AC")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000FD")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xA2A2B0", Offset = "0xA2A2B0", VA = "0xA2A2B0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xA2A334", Offset = "0xA2A334", VA = "0xA2A334", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005E4")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xA2A3B4", Offset = "0xA2A3B4", VA = "0xA2A3B4")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000FE")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000FF")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xA2A718", Offset = "0xA2A718", VA = "0xA2A718", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xA2A760", Offset = "0xA2A760", VA = "0xA2A760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xA2A450", Offset = "0xA2A450", VA = "0xA2A450")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xA2A614", Offset = "0xA2A614", VA = "0xA2A614", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xA2A618", Offset = "0xA2A618", VA = "0xA2A618", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xA2A720", Offset = "0xA2A720", VA = "0xA2A720", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xA2A3BC", Offset = "0xA2A3BC", VA = "0xA2A3BC", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xA2A3DC", Offset = "0xA2A3DC", VA = "0xA2A3DC")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xA2A478", Offset = "0xA2A478", VA = "0xA2A478")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000100")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xA2A768", Offset = "0xA2A768", VA = "0xA2A768", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0xA2A780", Offset = "0xA2A780", VA = "0xA2A780")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000101")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000102")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xA2A9A4", Offset = "0xA2A9A4", VA = "0xA2A9A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xA2A9EC", Offset = "0xA2A9EC", VA = "0xA2A9EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xA2A81C", Offset = "0xA2A81C", VA = "0xA2A81C")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xA2A88C", Offset = "0xA2A88C", VA = "0xA2A88C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xA2A890", Offset = "0xA2A890", VA = "0xA2A890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xA2A9AC", Offset = "0xA2A9AC", VA = "0xA2A9AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0xA2A788", Offset = "0xA2A788", VA = "0xA2A788", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0xA2A7A8", Offset = "0xA2A7A8", VA = "0xA2A7A8")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0xA2A844", Offset = "0xA2A844", VA = "0xA2A844")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000103")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000104")]
	public enum StereoMode
	{
		[Token(Token = "0x40007F3")]
		Unknown = -1,
		[Token(Token = "0x40007F4")]
		Mono,
		[Token(Token = "0x40007F5")]
		TopBottom,
		[Token(Token = "0x40007F6")]
		LeftRight,
		[Token(Token = "0x40007F7")]
		Mesh
	}

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700006A")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xA2A9F4", Offset = "0xA2A9F4", VA = "0xA2A9F4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700006B")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xA2ACE4", Offset = "0xA2ACE4", VA = "0xA2ACE4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700006C")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xA2AF64", Offset = "0xA2AF64", VA = "0xA2AF64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006D")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xA2AFD8", Offset = "0xA2AFD8", VA = "0xA2AFD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public static long Duration
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xA2B0DC", Offset = "0xA2B0DC", VA = "0xA2B0DC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700006F")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xA2B1E4", Offset = "0xA2B1E4", VA = "0xA2B1E4")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000070")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xA2B2EC", Offset = "0xA2B2EC", VA = "0xA2B2EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000071")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xA2B3F4", Offset = "0xA2B3F4", VA = "0xA2B3F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000072")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xA2B4FC", Offset = "0xA2B4FC", VA = "0xA2B4FC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xA2B604", Offset = "0xA2B604", VA = "0xA2B604")]
		set
		{
		}
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0xA2B76C", Offset = "0xA2B76C", VA = "0xA2B76C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0xA2B984", Offset = "0xA2B984", VA = "0xA2B984")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0xA2BA8C", Offset = "0xA2BA8C", VA = "0xA2BA8C")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0xA2BB94", Offset = "0xA2BB94", VA = "0xA2BB94")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0xA2BC9C", Offset = "0xA2BC9C", VA = "0xA2BC9C")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0xA2BE0C", Offset = "0xA2BE0C", VA = "0xA2BE0C")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0xA2BF78", Offset = "0xA2BF78", VA = "0xA2BF78")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000105")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x14000011")]
	public event Action onButtonDown
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0xA2C1CC", Offset = "0xA2C1CC", VA = "0xA2C1CC")]
		add
		{
		}
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xA2C268", Offset = "0xA2C268", VA = "0xA2C268")]
		remove
		{
		}
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0xA2C304", Offset = "0xA2C304", VA = "0xA2C304", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0xA2C320", Offset = "0xA2C320", VA = "0xA2C320")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x2000106")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000107")]
	public enum ButtonType
	{
		[Token(Token = "0x40007FB")]
		Play,
		[Token(Token = "0x40007FC")]
		Pause,
		[Token(Token = "0x40007FD")]
		FastForward,
		[Token(Token = "0x40007FE")]
		Rewind,
		[Token(Token = "0x40007FF")]
		SkipForward,
		[Token(Token = "0x4000800")]
		SkipBack,
		[Token(Token = "0x4000801")]
		Stop
	}

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000073")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xA2C328", Offset = "0xA2C328", VA = "0xA2C328")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xA2C330", Offset = "0xA2C330", VA = "0xA2C330")]
		set
		{
		}
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0xA2C354", Offset = "0xA2C354", VA = "0xA2C354", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0xA2D1A8", Offset = "0xA2D1A8", VA = "0xA2D1A8")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000108")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000109")]
	public enum VideoShape
	{
		[Token(Token = "0x4000816")]
		_360,
		[Token(Token = "0x4000817")]
		_180,
		[Token(Token = "0x4000818")]
		Quad
	}

	[Token(Token = "0x200010A")]
	public enum VideoStereo
	{
		[Token(Token = "0x400081A")]
		Mono,
		[Token(Token = "0x400081B")]
		TopBottom,
		[Token(Token = "0x400081C")]
		LeftRight,
		[Token(Token = "0x400081D")]
		BottomTop
	}

	[Token(Token = "0x200010B")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0xA2E6D0", Offset = "0xA2E6D0", VA = "0xA2E6D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xA2E718", Offset = "0xA2E718", VA = "0xA2E718", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xA2D88C", Offset = "0xA2D88C", VA = "0xA2D88C")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xA2E524", Offset = "0xA2E524", VA = "0xA2E524", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xA2E528", Offset = "0xA2E528", VA = "0xA2E528", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xA2E6D8", Offset = "0xA2E6D8", VA = "0xA2E6D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200010C")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xA2DB84", Offset = "0xA2DB84", VA = "0xA2DB84")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xA2E720", Offset = "0xA2E720", VA = "0xA2E720")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000074")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000614")]
		[Address(RVA = "0xA2D200", Offset = "0xA2D200", VA = "0xA2D200")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000615")]
		[Address(RVA = "0xA2D208", Offset = "0xA2D208", VA = "0xA2D208")]
		private set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public long Duration
	{
		[Token(Token = "0x6000616")]
		[Address(RVA = "0xA2D214", Offset = "0xA2D214", VA = "0xA2D214")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000617")]
		[Address(RVA = "0xA2D21C", Offset = "0xA2D21C", VA = "0xA2D21C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public long PlaybackPosition
	{
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xA2D224", Offset = "0xA2D224", VA = "0xA2D224")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000619")]
		[Address(RVA = "0xA2D22C", Offset = "0xA2D22C", VA = "0xA2D22C")]
		private set
		{
		}
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0xA2D234", Offset = "0xA2D234", VA = "0xA2D234")]
	private void Awake()
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0xA2D4B8", Offset = "0xA2D4B8", VA = "0xA2D4B8")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0xA2D518", Offset = "0xA2D518", VA = "0xA2D518")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0xA2D818", Offset = "0xA2D818", VA = "0xA2D818")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0xA2D8B4", Offset = "0xA2D8B4", VA = "0xA2D8B4")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0xA2DB8C", Offset = "0xA2DB8C", VA = "0xA2DB8C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0xA2DC10", Offset = "0xA2DC10", VA = "0xA2DC10")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0xA2DC90", Offset = "0xA2DC90", VA = "0xA2DC90")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0xA2DD7C", Offset = "0xA2DD7C", VA = "0xA2DD7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0xA2E318", Offset = "0xA2E318", VA = "0xA2E318")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0xA2E3B4", Offset = "0xA2E3B4", VA = "0xA2E3B4")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0xA2E434", Offset = "0xA2E434", VA = "0xA2E434")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0xA2E514", Offset = "0xA2E514", VA = "0xA2E514")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x200010D")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x200010E")]
	private enum PlaybackState
	{
		[Token(Token = "0x400083A")]
		Playing,
		[Token(Token = "0x400083B")]
		Paused,
		[Token(Token = "0x400083C")]
		Rewinding,
		[Token(Token = "0x400083D")]
		FastForwarding
	}

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x600062F")]
	[Address(RVA = "0xA2E7F4", Offset = "0xA2E7F4", VA = "0xA2E7F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0xA2EB20", Offset = "0xA2EB20", VA = "0xA2EB20")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0xA2ECF0", Offset = "0xA2ECF0", VA = "0xA2ECF0")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0xA2EE14", Offset = "0xA2EE14", VA = "0xA2EE14")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0xA2EF10", Offset = "0xA2EF10", VA = "0xA2EF10")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0xA2EDE8", Offset = "0xA2EDE8", VA = "0xA2EDE8")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0xA2EF70", Offset = "0xA2EF70", VA = "0xA2EF70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0xA2EA20", Offset = "0xA2EA20", VA = "0xA2EA20")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0xA2F2A0", Offset = "0xA2F2A0", VA = "0xA2F2A0")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x200010F")]
public static class VectorUtil
{
	[Token(Token = "0x6000638")]
	[Address(RVA = "0xA2E2A0", Offset = "0xA2E2A0", VA = "0xA2E2A0")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000110")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400083E")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x400083F")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000639")]
	[Address(RVA = "0xA2F2B0", Offset = "0xA2F2B0", VA = "0xA2F2B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0xA2F8D0", Offset = "0xA2F8D0", VA = "0xA2F8D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0xA2FB24", Offset = "0xA2FB24", VA = "0xA2FB24")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0xA2FC88", Offset = "0xA2FC88", VA = "0xA2FC88")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0xA2FDF0", Offset = "0xA2FDF0", VA = "0xA2FDF0")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0xA2FF74", Offset = "0xA2FF74", VA = "0xA2FF74")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x2000111")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000848")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x600063F")]
	[Address(RVA = "0xA2FF84", Offset = "0xA2FF84", VA = "0xA2FF84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0xA2F678", Offset = "0xA2F678", VA = "0xA2F678")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0xA2FFDC", Offset = "0xA2FFDC", VA = "0xA2FFDC")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0xA301F8", Offset = "0xA301F8", VA = "0xA301F8")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000112")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000643")]
	[Address(RVA = "0xA31200", Offset = "0xA31200", VA = "0xA31200")]
	private void Start()
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0xA31760", Offset = "0xA31760", VA = "0xA31760")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0xA3180C", Offset = "0xA3180C", VA = "0xA3180C")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0xA31A9C", Offset = "0xA31A9C", VA = "0xA31A9C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0xA31B70", Offset = "0xA31B70", VA = "0xA31B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0xA31C48", Offset = "0xA31C48", VA = "0xA31C48")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0xA31CB0", Offset = "0xA31CB0", VA = "0xA31CB0")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0xA31CB8", Offset = "0xA31CB8", VA = "0xA31CB8")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0xA31D20", Offset = "0xA31D20", VA = "0xA31D20")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0xA31D88", Offset = "0xA31D88", VA = "0xA31D88")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0xA31DF0", Offset = "0xA31DF0", VA = "0xA31DF0")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x2000113")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x600064E")]
	[Address(RVA = "0xA31E58", Offset = "0xA31E58", VA = "0xA31E58")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x2000114")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0xA31E60", Offset = "0xA31E60", VA = "0xA31E60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0xA31EF8", Offset = "0xA31EF8", VA = "0xA31EF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0xA31FD0", Offset = "0xA31FD0", VA = "0xA31FD0")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x2000115")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000652")]
	[Address(RVA = "0xA31FD8", Offset = "0xA31FD8", VA = "0xA31FD8")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x2000116")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x2000117")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xA323E8", Offset = "0xA323E8", VA = "0xA323E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xA32430", Offset = "0xA32430", VA = "0xA32430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xA32284", Offset = "0xA32284", VA = "0xA32284")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xA322B4", Offset = "0xA322B4", VA = "0xA322B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xA322B8", Offset = "0xA322B8", VA = "0xA322B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xA323F0", Offset = "0xA323F0", VA = "0xA323F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000653")]
	[Address(RVA = "0xA31FE0", Offset = "0xA31FE0", VA = "0xA31FE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0xA320EC", Offset = "0xA320EC", VA = "0xA320EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0xA32078", Offset = "0xA32078", VA = "0xA32078")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0xA322AC", Offset = "0xA322AC", VA = "0xA322AC")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x2000118")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x400085A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x600065D")]
	[Address(RVA = "0xA32438", Offset = "0xA32438", VA = "0xA32438")]
	private void Update()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0xA33DE0", Offset = "0xA33DE0", VA = "0xA33DE0")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x2000119")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700007B")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x600065F")]
		[Address(RVA = "0xA33DE8", Offset = "0xA33DE8", VA = "0xA33DE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0xA33E38", Offset = "0xA33E38", VA = "0xA33E38")]
	public void Start()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0xA34270", Offset = "0xA34270", VA = "0xA34270")]
	public void Update()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0xA34348", Offset = "0xA34348", VA = "0xA34348")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000663")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000664")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000665")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000666")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000667")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000668")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000669")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600066A")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0xA343A0", Offset = "0xA343A0", VA = "0xA343A0")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0xA343E0", Offset = "0xA343E0", VA = "0xA343E0")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0xA3444C", Offset = "0xA3444C", VA = "0xA3444C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0xA34598", Offset = "0xA34598", VA = "0xA34598")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0xA34668", Offset = "0xA34668", VA = "0xA34668")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xA3414C", Offset = "0xA3414C", VA = "0xA3414C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xA34738", Offset = "0xA34738", VA = "0xA34738")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0xA34784", Offset = "0xA34784", VA = "0xA34784")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0xA34894", Offset = "0xA34894", VA = "0xA34894")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x200011A")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x200011B")]
	public enum DrawMode
	{
		[Token(Token = "0x4000877")]
		Opaque,
		[Token(Token = "0x4000878")]
		OpaqueWithClip,
		[Token(Token = "0x4000879")]
		TransparentDefaultAlpha,
		[Token(Token = "0x400087A")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700007C")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA35ED8", Offset = "0xA35ED8", VA = "0xA35ED8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600067B")]
		[Address(RVA = "0xA35F5C", Offset = "0xA35F5C", VA = "0xA35F5C")]
		set
		{
		}
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0xA3489C", Offset = "0xA3489C", VA = "0xA3489C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0xA35560", Offset = "0xA35560", VA = "0xA35560")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0xA355D4", Offset = "0xA355D4", VA = "0xA355D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0xA356A4", Offset = "0xA356A4", VA = "0xA356A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xA35774", Offset = "0xA35774", VA = "0xA35774", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xA35978", Offset = "0xA35978", VA = "0xA35978")]
	private void Update()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xA36018", Offset = "0xA36018", VA = "0xA36018")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x200011C")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xA360D4", Offset = "0xA360D4", VA = "0xA360D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xA36474", Offset = "0xA36474", VA = "0xA36474")]
	private void Update()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xA36608", Offset = "0xA36608", VA = "0xA36608")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xA36610", Offset = "0xA36610", VA = "0xA36610")]
	public void Release()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xA365F8", Offset = "0xA365F8", VA = "0xA365F8")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0xA36618", Offset = "0xA36618", VA = "0xA36618")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x200011D")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x200011E")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xA36D60", Offset = "0xA36D60", VA = "0xA36D60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xA36DA8", Offset = "0xA36DA8", VA = "0xA36DA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA36C04", Offset = "0xA36C04", VA = "0xA36C04")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xA36C5C", Offset = "0xA36C5C", VA = "0xA36C5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xA36C60", Offset = "0xA36C60", VA = "0xA36C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xA36D68", Offset = "0xA36D68", VA = "0xA36D68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200011F")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xA36F2C", Offset = "0xA36F2C", VA = "0xA36F2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xA36F74", Offset = "0xA36F74", VA = "0xA36F74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xA36C2C", Offset = "0xA36C2C", VA = "0xA36C2C")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xA36DB0", Offset = "0xA36DB0", VA = "0xA36DB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xA36DB4", Offset = "0xA36DB4", VA = "0xA36DB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xA36F34", Offset = "0xA36F34", VA = "0xA36F34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xA36620", Offset = "0xA36620", VA = "0xA36620")]
	private void Start()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xA36900", Offset = "0xA36900", VA = "0xA36900")]
	private void Update()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xA36950", Offset = "0xA36950", VA = "0xA36950")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0xA36AC8", Offset = "0xA36AC8", VA = "0xA36AC8")]
	public void Release()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0xA36B6C", Offset = "0xA36B6C", VA = "0xA36B6C")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xA36A08", Offset = "0xA36A08", VA = "0xA36A08")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xA36C54", Offset = "0xA36C54", VA = "0xA36C54")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000120")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x6000697")]
	[Address(RVA = "0xA36F7C", Offset = "0xA36F7C", VA = "0xA36F7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xA36FD0", Offset = "0xA36FD0", VA = "0xA36FD0")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x2000121")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xA36FD8", Offset = "0xA36FD8", VA = "0xA36FD8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0xA371AC", Offset = "0xA371AC", VA = "0xA371AC")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0xA3723C", Offset = "0xA3723C", VA = "0xA3723C")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0xA37298", Offset = "0xA37298", VA = "0xA37298")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000122")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000123")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xA38470", Offset = "0xA38470", VA = "0xA38470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xA384B8", Offset = "0xA384B8", VA = "0xA384B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xA381D8", Offset = "0xA381D8", VA = "0xA381D8")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xA382A0", Offset = "0xA382A0", VA = "0xA382A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xA382A4", Offset = "0xA382A4", VA = "0xA382A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xA38478", Offset = "0xA38478", VA = "0xA38478", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x600069D")]
	[Address(RVA = "0xA372A0", Offset = "0xA372A0", VA = "0xA372A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0xA37588", Offset = "0xA37588", VA = "0xA37588")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xA37874", Offset = "0xA37874", VA = "0xA37874")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xA37B9C", Offset = "0xA37B9C", VA = "0xA37B9C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0xA37E74", Offset = "0xA37E74", VA = "0xA37E74")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0xA37F5C", Offset = "0xA37F5C", VA = "0xA37F5C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xA380F4", Offset = "0xA380F4", VA = "0xA380F4")]
	public void Release()
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xA38044", Offset = "0xA38044", VA = "0xA38044")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xA38200", Offset = "0xA38200", VA = "0xA38200")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x2000124")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x2000125")]
	public enum ManipulationType
	{
		[Token(Token = "0x40008AF")]
		Default,
		[Token(Token = "0x40008B0")]
		ForcedHand,
		[Token(Token = "0x40008B1")]
		DollyHand,
		[Token(Token = "0x40008B2")]
		DollyAttached,
		[Token(Token = "0x40008B3")]
		HorizontalScaled,
		[Token(Token = "0x40008B4")]
		VerticalScaled,
		[Token(Token = "0x40008B5")]
		Menu
	}

	[Token(Token = "0x2000126")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x2000127")]
	public delegate void ReleasedObject();

	[Token(Token = "0x2000128")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ObjectName;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ObjectInstructions;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xA384C0", Offset = "0xA384C0", VA = "0xA384C0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xA38520", Offset = "0xA38520", VA = "0xA38520")]
	public void Release()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xA3853C", Offset = "0xA3853C", VA = "0xA3853C")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xA38558", Offset = "0xA38558", VA = "0xA38558")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x2000129")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int radialDivisions;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float borderSize;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fingerTaper;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fingerTipLength;

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float webOffset;

	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xA386C0", Offset = "0xA386C0", VA = "0xA386C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xA38920", Offset = "0xA38920", VA = "0xA38920")]
	private void Update()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xA38AE8", Offset = "0xA38AE8", VA = "0xA38AE8")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xA3913C", Offset = "0xA3913C", VA = "0xA3913C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0xA396D4", Offset = "0xA396D4", VA = "0xA396D4")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0xA3B9DC", Offset = "0xA3B9DC", VA = "0xA3B9DC")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xA3BD50", Offset = "0xA3BD50", VA = "0xA3BD50")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x200012A")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xA3BD74", Offset = "0xA3BD74", VA = "0xA3BD74")]
	private void Start()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xA3C0DC", Offset = "0xA3C0DC", VA = "0xA3C0DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xA3BE10", Offset = "0xA3BE10", VA = "0xA3BE10")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xA3C544", Offset = "0xA3C544", VA = "0xA3C544")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xA3CAB4", Offset = "0xA3CAB4", VA = "0xA3CAB4")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x200012B")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x200012C")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xA3F354", Offset = "0xA3F354", VA = "0xA3F354", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xA3F39C", Offset = "0xA3F39C", VA = "0xA3F39C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xA3EC98", Offset = "0xA3EC98", VA = "0xA3EC98")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xA3F080", Offset = "0xA3F080", VA = "0xA3F080", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xA3F084", Offset = "0xA3F084", VA = "0xA3F084", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xA3F35C", Offset = "0xA3F35C", VA = "0xA3F35C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x40008DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xA3CAC4", Offset = "0xA3CAC4", VA = "0xA3CAC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xA3CCBC", Offset = "0xA3CCBC", VA = "0xA3CCBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xA3DBF8", Offset = "0xA3DBF8", VA = "0xA3DBF8")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xA3E98C", Offset = "0xA3E98C", VA = "0xA3E98C")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xA3CC48", Offset = "0xA3CC48", VA = "0xA3CC48")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xA3CF0C", Offset = "0xA3CF0C", VA = "0xA3CF0C")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xA3DEEC", Offset = "0xA3DEEC", VA = "0xA3DEEC")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xA3ECC0", Offset = "0xA3ECC0", VA = "0xA3ECC0")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0xA3ED74", Offset = "0xA3ED74", VA = "0xA3ED74")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xA3EDA4", Offset = "0xA3EDA4", VA = "0xA3EDA4")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xA3EB7C", Offset = "0xA3EB7C", VA = "0xA3EB7C")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xA3EE94", Offset = "0xA3EE94", VA = "0xA3EE94")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x200012D")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xA3F3A4", Offset = "0xA3F3A4", VA = "0xA3F3A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xA3F510", Offset = "0xA3F510", VA = "0xA3F510")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0xA3F5C4", Offset = "0xA3F5C4", VA = "0xA3F5C4")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x200012E")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x200012F")]
	public enum BrushState
	{
		[Token(Token = "0x40008F2")]
		Idle,
		[Token(Token = "0x40008F3")]
		Inking
	}

	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xA3F5CC", Offset = "0xA3F5CC", VA = "0xA3F5CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xA3F5D4", Offset = "0xA3F5D4", VA = "0xA3F5D4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xA3F884", Offset = "0xA3F884", VA = "0xA3F884")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0xA3FAB8", Offset = "0xA3FAB8", VA = "0xA3FAB8")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0xA3FCF8", Offset = "0xA3FCF8", VA = "0xA3FCF8")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0xA3F79C", Offset = "0xA3F79C", VA = "0xA3F79C")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xA3FDC8", Offset = "0xA3FDC8", VA = "0xA3FDC8")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000130")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xA3FE64", Offset = "0xA3FE64", VA = "0xA3FE64")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xA3FFD0", Offset = "0xA3FFD0", VA = "0xA3FFD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0xA401BC", Offset = "0xA401BC", VA = "0xA401BC")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000131")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0xA401C4", Offset = "0xA401C4", VA = "0xA401C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xA403AC", Offset = "0xA403AC", VA = "0xA403AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xA4054C", Offset = "0xA4054C", VA = "0xA4054C")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000132")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000133")]
	private sealed class <FadeToCurrentStyle>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xA4125C", Offset = "0xA4125C", VA = "0xA4125C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xA412A4", Offset = "0xA412A4", VA = "0xA412A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xA41050", Offset = "0xA41050", VA = "0xA41050")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xA411D0", Offset = "0xA411D0", VA = "0xA411D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xA411D4", Offset = "0xA411D4", VA = "0xA411D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xA41264", Offset = "0xA41264", VA = "0xA41264", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000134")]
	private sealed class <FadeToDefaultPassthrough>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xA41330", Offset = "0xA41330", VA = "0xA41330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xA41378", Offset = "0xA41378", VA = "0xA41378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xA41078", Offset = "0xA41078", VA = "0xA41078")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xA412AC", Offset = "0xA412AC", VA = "0xA412AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xA412B0", Offset = "0xA412B0", VA = "0xA412B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xA41338", Offset = "0xA41338", VA = "0xA41338", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000135")]
	private sealed class <FadeTo>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float styleValueMultiplier;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timer>5__2;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <brightness>5__3;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <contrast>5__4;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <saturation>5__5;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <blend>5__7;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xA41570", Offset = "0xA41570", VA = "0xA41570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xA415B8", Offset = "0xA415B8", VA = "0xA415B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xA41128", Offset = "0xA41128", VA = "0xA41128")]
		[DebuggerHidden]
		public <FadeTo>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xA41380", Offset = "0xA41380", VA = "0xA41380", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xA41384", Offset = "0xA41384", VA = "0xA41384", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA41578", Offset = "0xA41578", VA = "0xA41578", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008F8")]
	private const float FadeDuration = 0.2f;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Controller _controllerHand;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OVRPassthroughLayer _passthroughLayer;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform _colorWheel;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Texture2D _colorTexture;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture2D _colorLutTexture;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private CanvasGroup _mainCanvas;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject[] _compactObjects;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] _objectsToHideForColorPassthrough;

	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 _cursorPosition;

	[Token(Token = "0x4000902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _settingColor;

	[Token(Token = "0x4000903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Color _savedColor;

	[Token(Token = "0x4000904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float _savedBrightness;

	[Token(Token = "0x4000905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float _savedContrast;

	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _savedSaturation;

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private OVRPassthroughLayer.ColorMapEditorType _currentStyle;

	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _savedBlend;

	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private OVRPassthroughColorLut _passthroughColorLut;

	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IEnumerator _fade;

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xA40554", Offset = "0xA40554", VA = "0xA40554")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0xA408F4", Offset = "0xA408F4", VA = "0xA408F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0xA40C94", Offset = "0xA40C94", VA = "0xA40C94")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xA40CC4", Offset = "0xA40CC4", VA = "0xA40CC4")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0xA40CCC", Offset = "0xA40CCC", VA = "0xA40CCC")]
	public void OnSaturationChanged(float newValue)
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0xA40CD4", Offset = "0xA40CD4", VA = "0xA40CD4")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0xA40D08", Offset = "0xA40D08", VA = "0xA40D08")]
	public void OnBlendChange(float newValue)
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xA40D30", Offset = "0xA40D30", VA = "0xA40D30")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0xA40D3C", Offset = "0xA40D3C", VA = "0xA40D3C")]
	public void SetPassthroughStyleToColorAdjustment(bool isOn)
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0xA40D8C", Offset = "0xA40D8C", VA = "0xA40D8C")]
	public void SetPassthroughStyleToColorLut(bool isOn)
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0xA40D9C", Offset = "0xA40D9C", VA = "0xA40D9C")]
	private void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0xA40EFC", Offset = "0xA40EFC", VA = "0xA40EFC")]
	private void Release()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0xA40E78", Offset = "0xA40E78", VA = "0xA40E78")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0xA40FCC", Offset = "0xA40FCC", VA = "0xA40FCC")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0xA410A0", Offset = "0xA410A0", VA = "0xA410A0")]
	private IEnumerator FadeTo(float styleValueMultiplier, float duration)
	{
		return null;
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0xA40C9C", Offset = "0xA40C9C", VA = "0xA40C9C")]
	private void UpdateBrighnessContrastSaturation()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0xA4088C", Offset = "0xA4088C", VA = "0xA4088C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0xA41150", Offset = "0xA41150", VA = "0xA41150")]
	private void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0xA4090C", Offset = "0xA4090C", VA = "0xA4090C")]
	private void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0xA40D50", Offset = "0xA40D50", VA = "0xA40D50")]
	private void SetPassthroughStyle(OVRPassthroughLayer.ColorMapEditorType passthroughStyle)
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0xA4115C", Offset = "0xA4115C", VA = "0xA4115C")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000136")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x600070B")]
	[Address(RVA = "0xA415C0", Offset = "0xA415C0", VA = "0xA415C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xA41674", Offset = "0xA41674", VA = "0xA41674")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x2000137")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xA4167C", Offset = "0xA4167C", VA = "0xA4167C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xA416E8", Offset = "0xA416E8", VA = "0xA416E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xA419DC", Offset = "0xA419DC", VA = "0xA419DC")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x2000138")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xA419E4", Offset = "0xA419E4", VA = "0xA419E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xA41E38", Offset = "0xA41E38", VA = "0xA41E38")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x2000139")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x6000712")]
	[Address(RVA = "0xA41E40", Offset = "0xA41E40", VA = "0xA41E40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0xA420A0", Offset = "0xA420A0", VA = "0xA420A0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0xA420EC", Offset = "0xA420EC", VA = "0xA420EC")]
	public void Release()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0xA4212C", Offset = "0xA4212C", VA = "0xA4212C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200013A")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x200013B")]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xA42848", Offset = "0xA42848", VA = "0xA42848", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0xA42890", Offset = "0xA42890", VA = "0xA42890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA42710", Offset = "0xA42710", VA = "0xA42710")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA42750", Offset = "0xA42750", VA = "0xA42750", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA42754", Offset = "0xA42754", VA = "0xA42754", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA42850", Offset = "0xA42850", VA = "0xA42850", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x6000716")]
	[Address(RVA = "0xA42134", Offset = "0xA42134", VA = "0xA42134")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0xA42158", Offset = "0xA42158", VA = "0xA42158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0xA42260", Offset = "0xA42260", VA = "0xA42260")]
	private void Update()
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0xA42304", Offset = "0xA42304", VA = "0xA42304")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0xA42558", Offset = "0xA42558", VA = "0xA42558")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0xA425FC", Offset = "0xA425FC", VA = "0xA425FC")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0xA424D4", Offset = "0xA424D4", VA = "0xA424D4")]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0xA42738", Offset = "0xA42738", VA = "0xA42738")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x200013C")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x6000724")]
	[Address(RVA = "0xA42898", Offset = "0xA42898", VA = "0xA42898")]
	private void Update()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0xA42BA8", Offset = "0xA42BA8", VA = "0xA42BA8")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x200013D")]
[RequireComponent(typeof(OVRSceneAnchor))]
[DefaultExecutionOrder(30)]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x6000726")]
	[Address(RVA = "0xA42BB0", Offset = "0xA42BB0", VA = "0xA42BB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xA42DC8", Offset = "0xA42DC8", VA = "0xA42DC8")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xA43238", Offset = "0xA43238", VA = "0xA43238")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xA42C50", Offset = "0xA42C50", VA = "0xA42C50")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0xA43458", Offset = "0xA43458", VA = "0xA43458")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0xA43944", Offset = "0xA43944", VA = "0xA43944")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x200013E")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x200013F")]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xA43B78", Offset = "0xA43B78", VA = "0xA43B78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0xA43BC0", Offset = "0xA43BC0", VA = "0xA43BC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xA439C0", Offset = "0xA439C0", VA = "0xA439C0")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA43A78", Offset = "0xA43A78", VA = "0xA43A78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xA43A7C", Offset = "0xA43A7C", VA = "0xA43A7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xA43B80", Offset = "0xA43B80", VA = "0xA43B80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xA4394C", Offset = "0xA4394C", VA = "0xA4394C")]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0xA439E8", Offset = "0xA439E8", VA = "0xA439E8", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0xA43A08", Offset = "0xA43A08", VA = "0xA43A08", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0xA43A70", Offset = "0xA43A70", VA = "0xA43A70")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x2000140")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x6000736")]
	[Address(RVA = "0xA43BC8", Offset = "0xA43BC8", VA = "0xA43BC8")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x2000141")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x6000737")]
	[Address(RVA = "0xA43BD0", Offset = "0xA43BD0", VA = "0xA43BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0xA43C48", Offset = "0xA43C48", VA = "0xA43C48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0xA43CCC", Offset = "0xA43CCC", VA = "0xA43CCC")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x2000142")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x2000143")]
	public enum Method
	{
		[Token(Token = "0x4000957")]
		Adapt,
		[Token(Token = "0x4000958")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x4000959")]
		Scale,
		[Token(Token = "0x400095A")]
		None
	}

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method ScalingX;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Method ScalingY;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Method ScalingZ;

	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 <NewSize>k__BackingField;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 <DefaultSize>k__BackingField;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh <Mesh>k__BackingField;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700008F")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA43CDC", Offset = "0xA43CDC", VA = "0xA43CDC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000090")]
	public Vector3 NewSize
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA43CF8", Offset = "0xA43CF8", VA = "0xA43CF8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA43D04", Offset = "0xA43D04", VA = "0xA43D04")]
		set
		{
		}
	}

	[Token(Token = "0x17000091")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA43D10", Offset = "0xA43D10", VA = "0xA43D10")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA43D1C", Offset = "0xA43D1C", VA = "0xA43D1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000092")]
	public Mesh Mesh
	{
		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA43D28", Offset = "0xA43D28", VA = "0xA43D28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA43D30", Offset = "0xA43D30", VA = "0xA43D30")]
		private set
		{
		}
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0xA43D38", Offset = "0xA43D38", VA = "0xA43D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0xA43E74", Offset = "0xA43E74", VA = "0xA43E74")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x2000144")]
public class SimpleResizer
{
	[Token(Token = "0x6000743")]
	[Address(RVA = "0xA435B0", Offset = "0xA435B0", VA = "0xA435B0")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0xA43E7C", Offset = "0xA43E7C", VA = "0xA43E7C")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0xA44100", Offset = "0xA44100", VA = "0xA44100")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0xA435A8", Offset = "0xA435A8", VA = "0xA435A8")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000145")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x400095C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x400095D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x6000747")]
	[Address(RVA = "0xA441A8", Offset = "0xA441A8", VA = "0xA441A8", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xA441AC", Offset = "0xA441AC", VA = "0xA441AC", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xA44614", Offset = "0xA44614", VA = "0xA44614")]
	public Spawnable()
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0xA44300", Offset = "0xA44300", VA = "0xA44300")]
	internal static int <OnAfterDeserialize>g__IndexOf|4_0(string label, IEnumerable<string> collection)
	{
		return default(int);
	}
}
[Token(Token = "0x2000146")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x2000147")]
	public enum GeometryType
	{
		[Token(Token = "0x4000962")]
		Plane,
		[Token(Token = "0x4000963")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x2000148")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x400095E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x400095F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x600074B")]
	[Address(RVA = "0xA4466C", Offset = "0xA4466C", VA = "0xA4466C")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0xA44A98", Offset = "0xA44A98", VA = "0xA44A98")]
	private void Start()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0xA453D0", Offset = "0xA453D0", VA = "0xA453D0")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0xA452A8", Offset = "0xA452A8", VA = "0xA452A8")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0xA45450", Offset = "0xA45450", VA = "0xA45450")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x2000149")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x200014A")]
	private sealed class <Start>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000094")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xA46348", Offset = "0xA46348", VA = "0xA46348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xA46390", Offset = "0xA46390", VA = "0xA46390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xA457AC", Offset = "0xA457AC", VA = "0xA457AC")]
		[DebuggerHidden]
		public <Start>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xA461FC", Offset = "0xA461FC", VA = "0xA461FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xA46200", Offset = "0xA46200", VA = "0xA46200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA46350", Offset = "0xA46350", VA = "0xA46350", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000966")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x4000967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x4000968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x4000969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x400096A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x400096B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x400096C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("anchorName_")]
	[SerializeField]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x400096D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("saveIcon_")]
	[SerializeField]
	private GameObject _saveIcon;

	[Token(Token = "0x400096E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("labelImage_")]
	[SerializeField]
	private Image _labelImage;

	[Token(Token = "0x400096F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("labelBaseColor_")]
	[SerializeField]
	private Color _labelBaseColor;

	[Token(Token = "0x4000970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x4000971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("labelSelectedColor_")]
	[SerializeField]
	private Color _labelSelectedColor;

	[Token(Token = "0x4000972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("renderers_")]
	[SerializeField]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x4000975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000976")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x4000977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000093")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0xA45D40", Offset = "0xA45D40", VA = "0xA45D40")]
		set
		{
		}
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0xA45458", Offset = "0xA45458", VA = "0xA45458")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0xA455D8", Offset = "0xA455D8", VA = "0xA455D8")]
	private static string ConvertUuidToString(Guid guid)
	{
		return null;
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0xA45738", Offset = "0xA45738", VA = "0xA45738")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0xA457D4", Offset = "0xA457D4", VA = "0xA457D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0xA45A4C", Offset = "0xA45A4C", VA = "0xA45A4C")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xA45B1C", Offset = "0xA45B1C", VA = "0xA45B1C")]
	private void SaveUuidToPlayerPrefs(Guid uuid)
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0xA45C04", Offset = "0xA45C04", VA = "0xA45C04")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0xA45C70", Offset = "0xA45C70", VA = "0xA45C70")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0xA45D60", Offset = "0xA45D60", VA = "0xA45D60")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0xA45E7C", Offset = "0xA45E7C", VA = "0xA45E7C")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0xA45F84", Offset = "0xA45F84", VA = "0xA45F84")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0xA45824", Offset = "0xA45824", VA = "0xA45824")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0xA45958", Offset = "0xA45958", VA = "0xA45958")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0xA46054", Offset = "0xA46054", VA = "0xA46054")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0xA4618C", Offset = "0xA4618C", VA = "0xA4618C")]
	public Anchor()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0xA46194", Offset = "0xA46194", VA = "0xA46194")]
	private void <OnSaveLocalButtonPressed>b__23_0(OVRSpatialAnchor anchor, bool success)
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0xA461D0", Offset = "0xA461D0", VA = "0xA461D0")]
	private void <OnEraseButtonPressed>b__26_0(OVRSpatialAnchor anchor, bool success)
	{
	}
}
[Token(Token = "0x200014B")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x200014C")]
	public enum AnchorMode
	{
		[Token(Token = "0x400098F")]
		Create,
		[Token(Token = "0x4000990")]
		Select
	}

	[Token(Token = "0x200014D")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400097C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x4000982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("buttonList_")]
	[SerializeField]
	private List<Button> _buttonList;

	[Token(Token = "0x4000987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x400098A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x400098B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000096")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x6000768")]
		[Address(RVA = "0xA46398", Offset = "0xA46398", VA = "0xA46398")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0xA463A0", Offset = "0xA463A0", VA = "0xA463A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0xA4646C", Offset = "0xA4646C", VA = "0xA4646C")]
	private void Start()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0xA465BC", Offset = "0xA465BC", VA = "0xA465BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0xA46A2C", Offset = "0xA46A2C", VA = "0xA46A2C")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0xA46A98", Offset = "0xA46A98", VA = "0xA46A98")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0xA46554", Offset = "0xA46554", VA = "0xA46554")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0xA46D18", Offset = "0xA46D18", VA = "0xA46D18")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0xA46DA0", Offset = "0xA46DA0", VA = "0xA46DA0")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0xA46DC0", Offset = "0xA46DC0", VA = "0xA46DC0")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0xA46CF8", Offset = "0xA46CF8", VA = "0xA46CF8")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0xA46938", Offset = "0xA46938", VA = "0xA46938")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0xA46FC0", Offset = "0xA46FC0", VA = "0xA46FC0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0xA46E48", Offset = "0xA46E48", VA = "0xA46E48")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0xA46F34", Offset = "0xA46F34", VA = "0xA46F34")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0xA470C0", Offset = "0xA470C0", VA = "0xA470C0")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0xA46F54", Offset = "0xA46F54", VA = "0xA46F54")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0xA46F8C", Offset = "0xA46F8C", VA = "0xA46F8C")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0xA466BC", Offset = "0xA466BC", VA = "0xA466BC")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0xA471AC", Offset = "0xA471AC", VA = "0xA471AC")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0xA471D4", Offset = "0xA471D4", VA = "0xA471D4")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0xA47264", Offset = "0xA47264", VA = "0xA47264")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0xA473AC", Offset = "0xA473AC", VA = "0xA473AC")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x200014E")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x4000991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x4000992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xA46AEC", Offset = "0xA46AEC", VA = "0xA46AEC")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xA4753C", Offset = "0xA4753C", VA = "0xA4753C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xA4745C", Offset = "0xA4745C", VA = "0xA4745C")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xA475C0", Offset = "0xA475C0", VA = "0xA475C0")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xA473D0", Offset = "0xA473D0", VA = "0xA473D0")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xA47770", Offset = "0xA47770", VA = "0xA47770")]
	public SpatialAnchorLoader()
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xA47778", Offset = "0xA47778", VA = "0xA47778")]
	private void <Load>b__4_0(OVRSpatialAnchor.UnboundAnchor[] anchors)
	{
	}
}
[Token(Token = "0x200014F")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x2000150")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xA47AB4", Offset = "0xA47AB4", VA = "0xA47AB4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xA47BC8", Offset = "0xA47BC8", VA = "0xA47BC8")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xA478A8", Offset = "0xA478A8", VA = "0xA478A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xA47ABC", Offset = "0xA47ABC", VA = "0xA47ABC")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xA47BC0", Offset = "0xA47BC0", VA = "0xA47BC0")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x2000151")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xA47BE4", Offset = "0xA47BE4", VA = "0xA47BE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xA47C0C", Offset = "0xA47C0C", VA = "0xA47C0C")]
	private void Update()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xA47D48", Offset = "0xA47D48", VA = "0xA47D48")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x2000152")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_fixedTimeStep;

	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_gravityScalar;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xA47D58", Offset = "0xA47D58", VA = "0xA47D58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0xA47DF0", Offset = "0xA47DF0", VA = "0xA47DF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0xA47DF8", Offset = "0xA47DF8", VA = "0xA47DF8")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0xA47EBC", Offset = "0xA47EBC", VA = "0xA47EBC")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x2000153")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x400099D")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x400099E")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x400099F")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_trackingSpace;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x40009A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x40009A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000794")]
	[Address(RVA = "0xA47EDC", Offset = "0xA47EDC", VA = "0xA47EDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0xA4815C", Offset = "0xA4815C", VA = "0xA4815C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0xA4858C", Offset = "0xA4858C", VA = "0xA4858C")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0xA486B8", Offset = "0xA486B8", VA = "0xA486B8")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x2000154")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x40009A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_minExtent;

	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x6000798")]
	[Address(RVA = "0xA486D0", Offset = "0xA486D0", VA = "0xA486D0")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0xA486D8", Offset = "0xA486D8", VA = "0xA486D8")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0xA486FC", Offset = "0xA486FC", VA = "0xA486FC")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0xA48800", Offset = "0xA48800", VA = "0xA48800")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x2000155")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2 m_xExtent;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x40009AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x40009B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x40009B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x600079C")]
	[Address(RVA = "0xA48810", Offset = "0xA48810", VA = "0xA48810")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0xA4881C", Offset = "0xA4881C", VA = "0xA4881C")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0xA48840", Offset = "0xA48840", VA = "0xA48840")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0xA48C08", Offset = "0xA48C08", VA = "0xA48C08")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x2000156")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0xA48C1C", Offset = "0xA48C1C", VA = "0xA48C1C")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0xA48C40", Offset = "0xA48C40", VA = "0xA48C40")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0xA48C60", Offset = "0xA48C60", VA = "0xA48C60")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x2000157")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x40009B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x40009B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x40009BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x40009BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x40009BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x60007A3")]
	[Address(RVA = "0xA48C68", Offset = "0xA48C68", VA = "0xA48C68")]
	private void Start()
	{
	}

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0xA48C90", Offset = "0xA48C90", VA = "0xA48C90")]
	private void Update()
	{
	}

	[Token(Token = "0x60007A5")]
	[Address(RVA = "0xA49218", Offset = "0xA49218", VA = "0xA49218")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0xA49258", Offset = "0xA49258", VA = "0xA49258")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0xA492DC", Offset = "0xA492DC", VA = "0xA492DC")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x2000158")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0xA492EC", Offset = "0xA492EC", VA = "0xA492EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0xA495B8", Offset = "0xA495B8", VA = "0xA495B8")]
	private void Update()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0xA496D0", Offset = "0xA496D0", VA = "0xA496D0")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0xA4976C", Offset = "0xA4976C", VA = "0xA4976C")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0xA497B0", Offset = "0xA497B0", VA = "0xA497B0")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0xA4984C", Offset = "0xA4984C", VA = "0xA4984C")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0xA497BC", Offset = "0xA497BC", VA = "0xA497BC")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0xA49858", Offset = "0xA49858", VA = "0xA49858")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0xA498E8", Offset = "0xA498E8", VA = "0xA498E8")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0xA49714", Offset = "0xA49714", VA = "0xA49714")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0xA49390", Offset = "0xA49390", VA = "0xA49390")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0xA49950", Offset = "0xA49950", VA = "0xA49950")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x2000159")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0xA49958", Offset = "0xA49958", VA = "0xA49958")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0xA4997C", Offset = "0xA4997C", VA = "0xA4997C")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0xA49A2C", Offset = "0xA49A2C", VA = "0xA49A2C")]
	public UiVectorInspector()
	{
	}
}
[Token(Token = "0x200015A")]
public class Counter : MonoBehaviour
{
	[Token(Token = "0x40009CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Digit[] m_Digits;

	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_Count;

	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_PrevCount;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_AlarmValue;

	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color m_OutlineColor;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color m_AlarmColor;

	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool m_SetColor;

	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_Material;

	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool m_Align;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string m_PerfName;

	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0xA49A34", Offset = "0xA49A34", VA = "0xA49A34")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0xA49A98", Offset = "0xA49A98", VA = "0xA49A98")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0xA49CF4", Offset = "0xA49CF4", VA = "0xA49CF4")]
	private void UpdateHighlight()
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0xA49E20", Offset = "0xA49E20", VA = "0xA49E20")]
	public Counter()
	{
	}
}
[Token(Token = "0x200015B")]
public class Digit : MonoBehaviour
{
	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_Value;

	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_PrevValue;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] m_Digits;

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0xA49E38", Offset = "0xA49E38", VA = "0xA49E38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0xA49F14", Offset = "0xA49F14", VA = "0xA49F14")]
	public Digit()
	{
	}
}
[Token(Token = "0x200015C")]
public class FlatCounter : MonoBehaviour
{
	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] m_Digits;

	[Token(Token = "0x40009DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer[] m_Adds;

	[Token(Token = "0x40009DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Count;

	[Token(Token = "0x40009DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_AlarmValue;

	[Token(Token = "0x40009DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color m_Color;

	[Token(Token = "0x40009DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color m_AlarmColor;

	[Token(Token = "0x40009E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_PrevCount;

	[Token(Token = "0x40009E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_SetColor;

	[Token(Token = "0x40009E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool m_Align;

	[Token(Token = "0x40009E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string m_PerfName;

	[Token(Token = "0x40009E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x40009E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color m_HighlightColor;

	[Token(Token = "0x40009E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_HighlightProgress;

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0xA49F24", Offset = "0xA49F24", VA = "0xA49F24")]
	private void Start()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0xA4A0C0", Offset = "0xA4A0C0", VA = "0xA4A0C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0xA4A384", Offset = "0xA4A384", VA = "0xA4A384")]
	private void UpdateAlarm()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0xA49F94", Offset = "0xA49F94", VA = "0xA49F94")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0xA4A414", Offset = "0xA4A414", VA = "0xA4A414")]
	public FlatCounter()
	{
	}
}
[Token(Token = "0x200015D")]
public class MockupMaker : MonoBehaviour
{
	[Token(Token = "0x40009E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40009E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_ToTrim;

	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Decoration;

	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Mockup;

	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Bound;

	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform m_VROrientation;

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0xA4A430", Offset = "0xA4A430", VA = "0xA4A430")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0xA4AC54", Offset = "0xA4AC54", VA = "0xA4AC54")]
	public void Show()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0xA4AE68", Offset = "0xA4AE68", VA = "0xA4AE68")]
	public void Hide()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0xA4A538", Offset = "0xA4A538", VA = "0xA4A538")]
	private void GenerateSegments(MeshFilter[] meshes, MeshFilter[] segments)
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0xA4AF24", Offset = "0xA4AF24", VA = "0xA4AF24")]
	private Mesh TrimMesh(MeshFilter mf)
	{
		return null;
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0xA4B1FC", Offset = "0xA4B1FC", VA = "0xA4B1FC")]
	public MockupMaker()
	{
	}
}
[Serializable]
[Token(Token = "0x200015E")]
public class GameEvent
{
	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int source_id;

	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frame;

	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40009F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 v3_param;

	[Token(Token = "0x40009F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int i_param;

	[Token(Token = "0x40009F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int i_param2;

	[Token(Token = "0x40009F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool was_played;

	[Token(Token = "0x40009F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rejcected;

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0xA4B204", Offset = "0xA4B204", VA = "0xA4B204")]
	public GameEvent()
	{
	}
}
[Token(Token = "0x200015F")]
public class Recorder : MonoBehaviour
{
	[Token(Token = "0x40009F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40009F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_PrevFrame;

	[Token(Token = "0x40009F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_SourceID;

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_Record;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool m_Smooth;

	[Token(Token = "0x40009FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool m_Copy;

	[Token(Token = "0x40009FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool m_RecordTransform;

	[Token(Token = "0x40009FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameEvent> m_Events;

	[Token(Token = "0x40009FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] m_RecordingPos;

	[Token(Token = "0x40009FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Quaternion[] m_RecordingRot;

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0xA4B20C", Offset = "0xA4B20C", VA = "0xA4B20C")]
	public void Copy(ref Recorder reference)
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0xA4B288", Offset = "0xA4B288", VA = "0xA4B288")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0xA4B46C", Offset = "0xA4B46C", VA = "0xA4B46C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0xA4B5C4", Offset = "0xA4B5C4", VA = "0xA4B5C4")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0xA4B698", Offset = "0xA4B698", VA = "0xA4B698")]
	public void Clear()
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0xA4B71C", Offset = "0xA4B71C", VA = "0xA4B71C")]
	public void Play()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0xA4B7A8", Offset = "0xA4B7A8", VA = "0xA4B7A8")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0xA4BA80", Offset = "0xA4BA80", VA = "0xA4BA80")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0xA4BA88", Offset = "0xA4BA88", VA = "0xA4BA88")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0xA4BAA0", Offset = "0xA4BAA0", VA = "0xA4BAA0")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0xA4BAB8", Offset = "0xA4BAB8", VA = "0xA4BAB8")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int i_param2, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0xA4BCA4", Offset = "0xA4BCA4", VA = "0xA4BCA4")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0xA4BE6C", Offset = "0xA4BE6C", VA = "0xA4BE6C")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0xA4C008", Offset = "0xA4C008", VA = "0xA4C008")]
	private void Update()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0xA4B530", Offset = "0xA4B530", VA = "0xA4B530")]
	public int GetCurrFrame()
	{
		return default(int);
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0xA4C2F0", Offset = "0xA4C2F0", VA = "0xA4C2F0")]
	private float GetDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0xA4C024", Offset = "0xA4C024", VA = "0xA4C024")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0xA4C0F0", Offset = "0xA4C0F0", VA = "0xA4C0F0")]
	private void PlayFrame()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0xA4C358", Offset = "0xA4C358", VA = "0xA4C358")]
	public Recorder()
	{
	}
}
[Token(Token = "0x2000160")]
public class Selector : MonoBehaviour
{
	[Token(Token = "0x40009FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x4000A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_MinNoSelected;

	[Token(Token = "0x4000A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_MaxNoSelected;

	[Token(Token = "0x4000A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoSelected;

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0xA4C3F4", Offset = "0xA4C3F4", VA = "0xA4C3F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0xA4C808", Offset = "0xA4C808", VA = "0xA4C808")]
	public Selector()
	{
	}
}
[Token(Token = "0x2000161")]
public class TActivator : MonoBehaviour
{
	[Token(Token = "0x4000A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0xA4C818", Offset = "0xA4C818", VA = "0xA4C818")]
	private void Start()
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0xA4C87C", Offset = "0xA4C87C", VA = "0xA4C87C")]
	public TActivator()
	{
	}
}
[Token(Token = "0x2000162")]
public class Tools
{
	[Token(Token = "0x4000A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int m_Seed;

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0xA4C884", Offset = "0xA4C884", VA = "0xA4C884")]
	public static float CalculateSectionPos(Vector3 start_pos, Vector3 end_pos, Vector3 pnt)
	{
		return default(float);
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0xA4C71C", Offset = "0xA4C71C", VA = "0xA4C71C")]
	public static float GetRandom(int seed, int idx)
	{
		return default(float);
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0xA4C600", Offset = "0xA4C600", VA = "0xA4C600")]
	public static int GetRandomIDX(int seed, int idx, int max)
	{
		return default(int);
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0xA4C9F0", Offset = "0xA4C9F0", VA = "0xA4C9F0")]
	public static float CosFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0xA4CA34", Offset = "0xA4CA34", VA = "0xA4CA34")]
	public static float SinSqrtFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0xA4CA5C", Offset = "0xA4CA5C", VA = "0xA4CA5C")]
	public static float SinPowFun(float val, float pow)
	{
		return default(float);
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0xA4CAA4", Offset = "0xA4CAA4", VA = "0xA4CAA4")]
	public static float FlatSinPowFun(float val, float pow, float flat)
	{
		return default(float);
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0xA4CAFC", Offset = "0xA4CAFC", VA = "0xA4CAFC")]
	public static string GetRandomAudioName(string name, int no_samples = 3)
	{
		return null;
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0xA4CBEC", Offset = "0xA4CBEC", VA = "0xA4CBEC")]
	public static float Mod01(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0xA4CBF8", Offset = "0xA4CBF8", VA = "0xA4CBF8")]
	public static float Mod(float val, float mod)
	{
		return default(float);
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0xA4CC0C", Offset = "0xA4CC0C", VA = "0xA4CC0C")]
	public static void DrawArrow(Vector3 start, Vector3 dir, Color color)
	{
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0xA4D0C0", Offset = "0xA4D0C0", VA = "0xA4D0C0")]
	public static void DrawArrow(Color color, Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0xA4D198", Offset = "0xA4D198", VA = "0xA4D198")]
	public static int PullNumberFormBrackets(string param)
	{
		return default(int);
	}
}
[Token(Token = "0x2000163")]
public class TurnFaceToCamera : MonoBehaviour
{
	[Token(Token = "0x4000A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_StabilizePos;

	[Token(Token = "0x4000A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_StabilizeXRot;

	[Token(Token = "0x4000A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_StabilizeRot;

	[Token(Token = "0x4000A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float baseRotFactor;

	[Token(Token = "0x4000A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera m_Camera;

	[Token(Token = "0x4000A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 m_BaseShift;

	[Token(Token = "0x4000A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject m_Parent;

	[Token(Token = "0x4000A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Quaternion baseRotation;

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0xA4D2A0", Offset = "0xA4D2A0", VA = "0xA4D2A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60007EF")]
	[Address(RVA = "0xA4D2EC", Offset = "0xA4D2EC", VA = "0xA4D2EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xA4D670", Offset = "0xA4D670", VA = "0xA4D670")]
	public TurnFaceToCamera()
	{
	}
}
[Token(Token = "0x2000164")]
public class UVAnimator : MonoBehaviour
{
	[Token(Token = "0x4000A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material m_Material;

	[Token(Token = "0x4000A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 m_Speed;

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xA4D6DC", Offset = "0xA4D6DC", VA = "0xA4D6DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xA4D754", Offset = "0xA4D754", VA = "0xA4D754")]
	public UVAnimator()
	{
	}
}
[Token(Token = "0x2000165")]
public class VRKeyboard : MonoBehaviour
{
	[Token(Token = "0x4000A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] ButtonLists;

	[Token(Token = "0x4000A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Output;

	[Token(Token = "0x4000A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource m_ClickSFX;

	[Token(Token = "0x4000A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool CapsLock;

	[Token(Token = "0x4000A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string EditedText;

	[Token(Token = "0x4000A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string EditedStringName;

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0xA4D75C", Offset = "0xA4D75C", VA = "0xA4D75C")]
	public void Show(string edited_string_name)
	{
	}

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0xA4D7DC", Offset = "0xA4D7DC", VA = "0xA4D7DC")]
	public void OnButtonDown(string letter)
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xA4D8F4", Offset = "0xA4D8F4", VA = "0xA4D8F4")]
	public void OnCapsLock()
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0xA4D9AC", Offset = "0xA4D9AC", VA = "0xA4D9AC")]
	public void OnClear()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xA4DA20", Offset = "0xA4DA20", VA = "0xA4DA20")]
	public void OnBack()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xA4DA8C", Offset = "0xA4DA8C", VA = "0xA4DA8C")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0xA4DACC", Offset = "0xA4DACC", VA = "0xA4DACC")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xA4D864", Offset = "0xA4D864", VA = "0xA4D864")]
	private void PlayClick()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xA4DAFC", Offset = "0xA4DAFC", VA = "0xA4DAFC")]
	public VRKeyboard()
	{
	}
}
namespace RhythmTool
{
	[Token(Token = "0x2000166")]
	public abstract class Analysis : MonoBehaviour
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int <frameSize>k__BackingField;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <hopSize>k__BackingField;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int <frameIndex>k__BackingField;

		[Token(Token = "0x17000097")]
		public Track track
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xA4DB6C", Offset = "0xA4DB6C", VA = "0xA4DB6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public int sampleRate
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xA4DB78", Offset = "0xA4DB78", VA = "0xA4DB78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xA4DB80", Offset = "0xA4DB80", VA = "0xA4DB80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public int frameSize
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xA4DB88", Offset = "0xA4DB88", VA = "0xA4DB88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0xA4DB90", Offset = "0xA4DB90", VA = "0xA4DB90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int hopSize
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xA4DB98", Offset = "0xA4DB98", VA = "0xA4DB98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xA4DBA0", Offset = "0xA4DBA0", VA = "0xA4DBA0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public new abstract string name
		{
			[Token(Token = "0x6000803")]
			get;
		}

		[Token(Token = "0x1700009C")]
		protected int frameIndex
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xA4DBA8", Offset = "0xA4DBA8", VA = "0xA4DBA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xA4DBB0", Offset = "0xA4DBB0", VA = "0xA4DBB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xA4DBB8", Offset = "0xA4DBB8", VA = "0xA4DBB8", Slot = "5")]
		public virtual void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xA4DBC4", Offset = "0xA4DBC4", VA = "0xA4DBC4", Slot = "6")]
		public virtual void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xA4DBCC", Offset = "0xA4DBCC", VA = "0xA4DBCC")]
		protected float FrameIndexToSeconds(float frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000809")]
		protected abstract Track GetTrack();

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xA4DBE8", Offset = "0xA4DBE8", VA = "0xA4DBE8")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[ExecuteInEditMode]
	public abstract class Analysis<T> : Analysis where T : Feature
	{
		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Track<T> <track>k__BackingField;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toAdd;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toRemove;

		[Token(Token = "0x1700009D")]
		public new Track<T> track
		{
			[Token(Token = "0x600080B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080C")]
			private set
			{
			}
		}

		[Token(Token = "0x600080D")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x600080E")]
		protected sealed override Track GetTrack()
		{
			return null;
		}

		[Token(Token = "0x600080F")]
		protected void AddFeature(T feature)
		{
		}

		[Token(Token = "0x6000810")]
		protected void RemoveFeature(T feature)
		{
		}

		[Token(Token = "0x6000811")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class BeatTrack : Track<Beat>
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0xA4DBF0", Offset = "0xA4DBF0", VA = "0xA4DBF0")]
		public BeatTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class Beat : Feature
	{
		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float bpm;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xA4DC5C", Offset = "0xA4DC5C", VA = "0xA4DC5C")]
		public Beat()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[DisallowMultipleComponent]
	public class BeatTracker : Analysis<Beat>
	{
		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] signalBuffer;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] signal;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] smoothedSignal;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] autoCorrelation;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] combFilter;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] lengthScore;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] offsetScore;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] signalWindow;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] offsetWindow;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] kernel;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] prevMagnitude;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float prevSpectralFlux;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int maxBeatLength;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int minBeatLength;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int beatLength;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int prevBeatLength;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int beatOffset;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int updateOffset;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int bufferSize;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int resolution;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int combElements;

		[Token(Token = "0x1700009E")]
		public override string name
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xA4DC6C", Offset = "0xA4DC6C", VA = "0xA4DC6C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xA4DCAC", Offset = "0xA4DCAC", VA = "0xA4DCAC", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xA4E204", Offset = "0xA4E204", VA = "0xA4E204", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA4E35C", Offset = "0xA4E35C", VA = "0xA4E35C")]
		private float GetSample(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA4E410", Offset = "0xA4E410", VA = "0xA4E410")]
		private void UpdateSignal()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xA4E774", Offset = "0xA4E774", VA = "0xA4E774")]
		private void UpdateOffset()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xA4E588", Offset = "0xA4E588", VA = "0xA4E588")]
		private void UpdateLength()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xA4ED88", Offset = "0xA4ED88", VA = "0xA4ED88")]
		private void UpdateAutoCorrelation()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xA4EF08", Offset = "0xA4EF08", VA = "0xA4EF08")]
		private void UpdateLengthScore()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xA4F160", Offset = "0xA4F160", VA = "0xA4F160")]
		public BeatTracker()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public static class Bindings<T>
	{
		[Token(Token = "0x200016C")]
		private delegate T ObjectActivator(params object[] args);

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, ObjectActivator> bindings;

		[Token(Token = "0x600081F")]
		public static T GetBinding(params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x6000820")]
		private static ObjectActivator GetCachedActivator(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		private static ObjectActivator GetActivator(ConstructorInfo ctor)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		private static Type GetBindingType(Type featureType)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		private static ConstructorInfo GetConstructor(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200016D")]
	public class Chromagram : Analysis<Chroma>
	{
		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int startNote;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int endNote;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int downsampleFactor;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int chromaInterval;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] noteIndices;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] downsampled;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] spectrum;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] magnitude;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] window;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] pitchWindow;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] pitch;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] chroma;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int offset;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[] chromaHistory;

		[Token(Token = "0x1700009F")]
		public override string name
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xA4F1B4", Offset = "0xA4F1B4", VA = "0xA4F1B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xA4F1F4", Offset = "0xA4F1F4", VA = "0xA4F1F4", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xA4F6B8", Offset = "0xA4F6B8", VA = "0xA4F6B8", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xA4F6FC", Offset = "0xA4F6FC", VA = "0xA4F6FC")]
		private void Downsample(float[] samples)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xA4F824", Offset = "0xA4F824", VA = "0xA4F824")]
		private void UpdateChroma()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xA4F544", Offset = "0xA4F544", VA = "0xA4F544")]
		private static int FrequencyToIndex(float frequency, int length, int samplerate)
		{
			return default(int);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xA4F518", Offset = "0xA4F518", VA = "0xA4F518")]
		private static float GetMidiFrequency(int index)
		{
			return default(float);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xA4FF08", Offset = "0xA4FF08", VA = "0xA4FF08")]
		public Chromagram()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class ChromaTrack : Track<Chroma>
	{
		[Token(Token = "0x600082F")]
		[Address(RVA = "0xA4FF64", Offset = "0xA4FF64", VA = "0xA4FF64")]
		public ChromaTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public class Chroma : Feature
	{
		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Note note;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xA4FF00", Offset = "0xA4FF00", VA = "0xA4FF00")]
		public Chroma()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public enum Note
	{
		[Token(Token = "0x4000A44")]
		A,
		[Token(Token = "0x4000A45")]
		ASharp,
		[Token(Token = "0x4000A46")]
		B,
		[Token(Token = "0x4000A47")]
		C,
		[Token(Token = "0x4000A48")]
		CSHARP,
		[Token(Token = "0x4000A49")]
		D,
		[Token(Token = "0x4000A4A")]
		DSHARP,
		[Token(Token = "0x4000A4B")]
		E,
		[Token(Token = "0x4000A4C")]
		F,
		[Token(Token = "0x4000A4D")]
		FSHARP,
		[Token(Token = "0x4000A4E")]
		G,
		[Token(Token = "0x4000A4F")]
		GSHARP
	}
	[Token(Token = "0x2000171")]
	[RequireComponent(typeof(RhythmPlayer))]
	public class DebugDrawer : MonoBehaviour
	{
		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RhythmPlayer <rhythmPlayer>k__BackingField;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float width;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float height;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float padding;

		[Token(Token = "0x170000A0")]
		public RhythmPlayer rhythmPlayer
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0xA4FFD0", Offset = "0xA4FFD0", VA = "0xA4FFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0xA4FFD8", Offset = "0xA4FFD8", VA = "0xA4FFD8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xA4FFE0", Offset = "0xA4FFE0", VA = "0xA4FFE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xA50038", Offset = "0xA50038", VA = "0xA50038")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xA507E4", Offset = "0xA507E4", VA = "0xA507E4")]
		public DebugDrawer()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public abstract class TrackDrawer
	{
		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, TrackDrawer> trackDrawers;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xA504DC", Offset = "0xA504DC", VA = "0xA504DC")]
		public static void Draw(Track track, Rect rect, float start, float end)
		{
		}

		[Token(Token = "0x6000837")]
		protected abstract void DrawTrack(Track track, Rect rect, float start, float end);

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xA50800", Offset = "0xA50800", VA = "0xA50800")]
		public static TrackDrawer GetTrackDrawer(Track track)
		{
			return null;
		}
	}
	[Token(Token = "0x2000173")]
	public class Feature
	{
		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timestamp;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float length;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xA4DC64", Offset = "0xA4DC64", VA = "0xA4DC64")]
		public Feature()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class LomontFFT
	{
		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] cosTable;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] sinTable;

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xA50A48", Offset = "0xA50A48", VA = "0xA50A48")]
		public void FFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xA50EC8", Offset = "0xA50EC8", VA = "0xA50EC8")]
		public void RealFFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xA50F74", Offset = "0xA50F74", VA = "0xA50F74")]
		private void Reconstruct(float[] data, bool forward)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xA50D34", Offset = "0xA50D34", VA = "0xA50D34")]
		private void InitializeTables(int length)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xA50CA4", Offset = "0xA50CA4", VA = "0xA50CA4")]
		private static void BitReverse(float[] data)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xA51118", Offset = "0xA51118", VA = "0xA51118")]
		private static void Swap(float[] data, int a, int b)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xA51158", Offset = "0xA51158", VA = "0xA51158")]
		public LomontFFT()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class OnsetDetector : Analysis<Onset>
	{
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float normalization;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float threshold;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(2f, 32f)]
		public int bufferSize;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int start;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int end;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mean;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m2;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] prevMagnitude;

		[Token(Token = "0x170000A1")]
		public override string name
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xA51160", Offset = "0xA51160", VA = "0xA51160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xA511A0", Offset = "0xA511A0", VA = "0xA511A0", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xA51274", Offset = "0xA51274", VA = "0xA51274", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xA51438", Offset = "0xA51438", VA = "0xA51438")]
		private float SpectralDifference(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xA514EC", Offset = "0xA514EC", VA = "0xA514EC")]
		private float Normalize(float sample)
		{
			return default(float);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xA51568", Offset = "0xA51568", VA = "0xA51568")]
		public OnsetDetector()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class OnsetTrack : Track<Onset>
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0xA515CC", Offset = "0xA515CC", VA = "0xA515CC")]
		public OnsetTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000177")]
	public class Onset : Feature
	{
		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float strength;

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xA51560", Offset = "0xA51560", VA = "0xA51560")]
		public Onset()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[ExecuteInEditMode]
	public class RhythmAnalyzer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000179")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Analysis> <>9__41_0;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Analysis, Track> <>9__41_1;

			[Token(Token = "0x6000860")]
			[Address(RVA = "0xA526A4", Offset = "0xA526A4", VA = "0xA526A4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0xA526AC", Offset = "0xA526AC", VA = "0xA526AC")]
			internal bool <Initialize>b__41_0(Analysis a)
			{
				return default(bool);
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0xA526D4", Offset = "0xA526D4", VA = "0xA526D4")]
			internal Track <Initialize>b__41_1(Analysis a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RhythmData <rhythmData>k__BackingField;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <progress>k__BackingField;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool <isDone>k__BackingField;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool <initialized>k__BackingField;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioClip audioClip;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int hopSize;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int frameSize;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int bufferCount;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int channels;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int sampleRate;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int totalFrames;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastFrame;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] window;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] samples;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] monoSamples;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] spectrum;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] magnitude;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Thread analyze;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AutoResetEvent waitForMainThread;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool getData;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool abort;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int initialLength;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Analysis> analyses;

		[Token(Token = "0x170000A2")]
		public RhythmData rhythmData
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xA51798", Offset = "0xA51798", VA = "0xA51798")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0xA517A0", Offset = "0xA517A0", VA = "0xA517A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public float progress
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xA517A8", Offset = "0xA517A8", VA = "0xA517A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xA517B0", Offset = "0xA517B0", VA = "0xA517B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool isDone
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xA517B8", Offset = "0xA517B8", VA = "0xA517B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xA517C0", Offset = "0xA517C0", VA = "0xA517C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool initialized
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xA517CC", Offset = "0xA517CC", VA = "0xA517CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xA517D4", Offset = "0xA517D4", VA = "0xA517D4")]
			private set
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<RhythmData> Initialized
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xA51638", Offset = "0xA51638", VA = "0xA51638")]
			add
			{
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xA516E8", Offset = "0xA516E8", VA = "0xA516E8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xA517E0", Offset = "0xA517E0", VA = "0xA517E0")]
		public RhythmData Analyze(AudioClip audioClip, float initialLength = 5f)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xA51914", Offset = "0xA51914", VA = "0xA51914")]
		public void Abort()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xA51970", Offset = "0xA51970", VA = "0xA51970")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA51DF8", Offset = "0xA51DF8", VA = "0xA51DF8")]
		private void StartAnalyze()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA52008", Offset = "0xA52008", VA = "0xA52008")]
		private void Analyze()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA522B4", Offset = "0xA522B4", VA = "0xA522B4")]
		private void OnAnalysisDone()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xA520F4", Offset = "0xA520F4", VA = "0xA520F4")]
		private void ProcessFrame(float[] samples)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xA520C8", Offset = "0xA520C8", VA = "0xA520C8")]
		private void FillBuffer()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xA5248C", Offset = "0xA5248C", VA = "0xA5248C")]
		private void GetData()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xA52538", Offset = "0xA52538", VA = "0xA52538")]
		private void Update()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xA52598", Offset = "0xA52598", VA = "0xA52598")]
		public RhythmAnalyzer()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class RhythmData : ScriptableObject, IEnumerable<Track>, IEnumerable
	{
		[Token(Token = "0x200017B")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<Track>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Track <>2__current;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RhythmData <>4__this;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Track>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000A7")]
			private Track System.Collections.Generic.IEnumerator<RhythmTool.Track>.Current
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0xA52D60", Offset = "0xA52D60", VA = "0xA52D60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000878")]
				[Address(RVA = "0xA52DA8", Offset = "0xA52DA8", VA = "0xA52DA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0xA52770", Offset = "0xA52770", VA = "0xA52770")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0xA52B4C", Offset = "0xA52B4C", VA = "0xA52B4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0xA52B68", Offset = "0xA52B68", VA = "0xA52B68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0xA52D10", Offset = "0xA52D10", VA = "0xA52D10")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0xA52D68", Offset = "0xA52D68", VA = "0xA52D68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Track> <>9__14_0;

			[Token(Token = "0x600087A")]
			[Address(RVA = "0xA52E20", Offset = "0xA52E20", VA = "0xA52E20")]
			public <>c()
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0xA52E28", Offset = "0xA52E28", VA = "0xA52E28")]
			internal bool <OnEnable>b__14_0(Track t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Track> _tracks;

		[Token(Token = "0x170000A6")]
		public List<Track> tracks
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xA526F4", Offset = "0xA526F4", VA = "0xA526F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000864")]
		public Track<T> GetTrack<T>() where T : Feature
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		public Track<T> GetTrack<T>(string trackName) where T : Feature
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		public void GetTracks<T>(List<Track<T>> tracks) where T : Feature
		{
		}

		[Token(Token = "0x6000867")]
		public void GetTracks<T>(List<Track<T>> tracks, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000868")]
		public void GetFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x6000869")]
		public void GetFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x600086A")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x600086B")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xA526FC", Offset = "0xA526FC", VA = "0xA526FC", Slot = "4")]
		public IEnumerator<Track> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xA52798", Offset = "0xA52798", VA = "0xA52798", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xA52828", Offset = "0xA52828", VA = "0xA52828")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xA52930", Offset = "0xA52930", VA = "0xA52930")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xA51D34", Offset = "0xA51D34", VA = "0xA51D34")]
		public static RhythmData Create(AudioClip audioClip, IEnumerable<Track> tracks)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xA52AC4", Offset = "0xA52AC4", VA = "0xA52AC4")]
		public RhythmData()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class RhythmEventProvider : RhythmTarget
	{
		[Token(Token = "0x200017E")]
		private abstract class RhythmEvent : IDisposable
		{
			[Token(Token = "0x6000886")]
			public abstract void Process(RhythmData rhythmData, float start, float end);

			[Token(Token = "0x6000887")]
			public abstract void Dispose();

			[Token(Token = "0x6000888")]
			[Address(RVA = "0xA532BC", Offset = "0xA532BC", VA = "0xA532BC")]
			protected RhythmEvent()
			{
			}
		}

		[Token(Token = "0x200017F")]
		private class RhythmEvent<T> : RhythmEvent where T : Feature
		{
			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> _action;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<T> _features;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string trackName;

			[Token(Token = "0x6000889")]
			public RhythmEvent(string trackName)
			{
			}

			[Token(Token = "0x600088A")]
			public override void Process(RhythmData rhythmData, float start, float end)
			{
			}

			[Token(Token = "0x600088B")]
			public void Register(Action<T> action)
			{
			}

			[Token(Token = "0x600088C")]
			public void Unregister(Action<T> action)
			{
			}

			[Token(Token = "0x600088D")]
			public override void Dispose()
			{
			}
		}

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(-10f, 10f)]
		public float offset;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, RhythmEvent> _events;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xA52E84", Offset = "0xA52E84", VA = "0xA52E84", Slot = "4")]
		public override void Process(RhythmData rhythmData, float start, float end)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xA53000", Offset = "0xA53000", VA = "0xA53000", Slot = "5")]
		public override void Reset(RhythmData rhythmData, float time)
		{
		}

		[Token(Token = "0x600087E")]
		public void Register<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x600087F")]
		public void Unregister<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x6000880")]
		public void Register<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000881")]
		public void Unregister<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xA53024", Offset = "0xA53024", VA = "0xA53024")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xA531C0", Offset = "0xA531C0", VA = "0xA531C0")]
		private static int GetHashCode(Type type, string trackName)
		{
			return default(int);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xA53220", Offset = "0xA53220", VA = "0xA53220")]
		private static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xA5322C", Offset = "0xA5322C", VA = "0xA5322C")]
		public RhythmEventProvider()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[RequireComponent(typeof(AudioSource))]
	public class RhythmPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audioSource>k__BackingField;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <prevTime>k__BackingField;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RhythmData rhythmData;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<RhythmTarget> targets;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _time;

		[Token(Token = "0x170000A9")]
		public AudioSource audioSource
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xA53534", Offset = "0xA53534", VA = "0xA53534")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xA5353C", Offset = "0xA5353C", VA = "0xA5353C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public AudioClip audioClip
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xA53544", Offset = "0xA53544", VA = "0xA53544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public float time
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xA535C4", Offset = "0xA535C4", VA = "0xA535C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xA535CC", Offset = "0xA535CC", VA = "0xA535CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public float volume
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xA535F0", Offset = "0xA535F0", VA = "0xA535F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xA5360C", Offset = "0xA5360C", VA = "0xA5360C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float pitch
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xA53628", Offset = "0xA53628", VA = "0xA53628")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xA53644", Offset = "0xA53644", VA = "0xA53644")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool isPlaying
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xA53660", Offset = "0xA53660", VA = "0xA53660")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public float prevTime
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xA5367C", Offset = "0xA5367C", VA = "0xA5367C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xA53684", Offset = "0xA53684", VA = "0xA53684")]
			private set
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action SongEnded
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xA532C4", Offset = "0xA532C4", VA = "0xA532C4")]
			add
			{
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xA53360", Offset = "0xA53360", VA = "0xA53360")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action Reset
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xA533FC", Offset = "0xA533FC", VA = "0xA533FC")]
			add
			{
			}
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xA53498", Offset = "0xA53498", VA = "0xA53498")]
			remove
			{
			}
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xA5368C", Offset = "0xA5368C", VA = "0xA5368C")]
		public void Play()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xA53920", Offset = "0xA53920", VA = "0xA53920")]
		public void Stop()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xA5393C", Offset = "0xA5393C", VA = "0xA5393C")]
		public void Pause()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xA53958", Offset = "0xA53958", VA = "0xA53958")]
		public void UnPause()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xA53974", Offset = "0xA53974", VA = "0xA53974")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xA539CC", Offset = "0xA539CC", VA = "0xA539CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xA53CDC", Offset = "0xA53CDC", VA = "0xA53CDC")]
		private void OnSongEnded()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xA5375C", Offset = "0xA5375C", VA = "0xA5375C")]
		private void OnReset()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xA53CF8", Offset = "0xA53CF8", VA = "0xA53CF8")]
		public RhythmPlayer()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public abstract class RhythmTarget : ScriptableObject
	{
		[Token(Token = "0x60008A7")]
		public abstract void Process(RhythmData rhythmData, float start, float end);

		[Token(Token = "0x60008A8")]
		public abstract void Reset(RhythmData rhythmData, float time);

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xA532B4", Offset = "0xA532B4", VA = "0xA532B4")]
		protected RhythmTarget()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class Segmenter : Analysis<Value>
	{
		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 64f)]
		public float threshold;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(1f, 16f)]
		public int smoothing;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 changeWeight;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float changeStartSlope;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float changeEndSlope;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int iterations;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int bufferSize;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[][] buffer;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] kernel;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float w;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float current;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float next;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool change;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float changeSign;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector2 changeStart;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float maxSlope;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int maxSlopeIndex;

		[Token(Token = "0x170000B0")]
		public override string name
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xA53D00", Offset = "0xA53D00", VA = "0xA53D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xA53D40", Offset = "0xA53D40", VA = "0xA53D40", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xA53F1C", Offset = "0xA53F1C", VA = "0xA53F1C", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xA541DC", Offset = "0xA541DC", VA = "0xA541DC")]
		private void FindSegments()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xA5423C", Offset = "0xA5423C", VA = "0xA5423C")]
		private void FindChangeEnd(float slope)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xA543B8", Offset = "0xA543B8", VA = "0xA543B8")]
		private void FindChangeStart(float slope)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xA54424", Offset = "0xA54424", VA = "0xA54424")]
		public Segmenter()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public abstract class Track : ScriptableObject
	{
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x170000B1")]
		public new string name
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xA5449C", Offset = "0xA5449C", VA = "0xA5449C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xA544A4", Offset = "0xA544A4", VA = "0xA544A4")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public abstract class Track<T> : Track where T : Feature
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Comparison<T> <>9__11_0;

			[Token(Token = "0x60008C4")]
			public <>c()
			{
			}

			[Token(Token = "0x60008C5")]
			internal int <Sort>b__11_0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _features;

		[NonSerialized]
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<int> cachedTimestamps;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, int> cachedIndices;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type concreteType;

		[Token(Token = "0x170000B2")]
		public T this[int index]
		{
			[Token(Token = "0x60008B3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		public int count
		{
			[Token(Token = "0x60008B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008B5")]
		static Track()
		{
		}

		[Token(Token = "0x60008B6")]
		public void Add(T feature)
		{
		}

		[Token(Token = "0x60008B7")]
		public void Remove(T feature)
		{
		}

		[Token(Token = "0x60008B8")]
		public void Sort()
		{
		}

		[Token(Token = "0x60008B9")]
		public void GetFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60008BA")]
		public void GetIntersectingFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x60008BB")]
		public int GetIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008BC")]
		public int GetIndex(T feature)
		{
			return default(int);
		}

		[Token(Token = "0x60008BD")]
		public int GetIntersectingIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008BE")]
		private int BinarySearch(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008BF")]
		private int GetCacheIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x60008C0")]
		private void ClearCache(float timestamp)
		{
		}

		[Token(Token = "0x60008C1")]
		public static Track<T> Create(string name)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class Util
	{
		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LomontFFT fft;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xA522C0", Offset = "0xA522C0", VA = "0xA522C0")]
		public static void GetMono(float[] samples, float[] monoSamples, int channels = 0)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xA4FCE8", Offset = "0xA4FCE8", VA = "0xA4FCE8")]
		public static void GetSpectrum(float[] samples)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xA4FD54", Offset = "0xA4FD54", VA = "0xA4FD54")]
		public static void GetSpectrumMagnitude(float[] spectrum, float[] magnitude)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xA4FC7C", Offset = "0xA4FC7C", VA = "0xA4FC7C")]
		internal static void ApplyWindow(float[] array, float[] window)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xA4FE94", Offset = "0xA4FE94", VA = "0xA4FE94")]
		public static float Mean(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xA54138", Offset = "0xA54138", VA = "0xA54138")]
		public static float WeightedSum(float[] array, float[] kernel, int index)
		{
			return default(float);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xA4ED08", Offset = "0xA4ED08", VA = "0xA4ED08")]
		public static int MaxIndex(float[] array, int start = 0, int end = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xA4F0D0", Offset = "0xA4F0D0", VA = "0xA4F0D0")]
		public static float Max(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xA4EBB4", Offset = "0xA4EBB4", VA = "0xA4EBB4")]
		public static void Smooth(float[] array, float[] smoothedArray, float[] kernel)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xA4EC80", Offset = "0xA4EC80", VA = "0xA4EC80")]
		public static float Interpolate(float[] array, float index)
		{
			return default(float);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xA544AC", Offset = "0xA544AC", VA = "0xA544AC")]
		public static void HannWindow(float[] array)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xA4F62C", Offset = "0xA4F62C", VA = "0xA4F62C")]
		public static float[] HannWindow(int length)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xA4E1C8", Offset = "0xA4E1C8", VA = "0xA4E1C8")]
		public static float HannWindow(int n, int windowSize)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000187")]
	public class ValueTrack : Track<Value>
	{
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xA54608", Offset = "0xA54608", VA = "0xA54608")]
		public ValueTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000188")]
	public class Value : Feature
	{
		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xA5441C", Offset = "0xA5441C", VA = "0xA5441C")]
		public Value()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class VolumeSampler : Analysis<Value>
	{
		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(1f, 64f)]
		private int _interval;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 16f)]
		private int _smoothing;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int smoothingBufferSize;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] buffer;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] smoothingBuffer;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] smoothingKernel;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float w;

		[Token(Token = "0x170000B4")]
		public override string name
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xA54674", Offset = "0xA54674", VA = "0xA54674", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public int interval
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xA546B4", Offset = "0xA546B4", VA = "0xA546B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xA546BC", Offset = "0xA546BC", VA = "0xA546BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public int smoothing
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xA546D8", Offset = "0xA546D8", VA = "0xA546D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xA546E0", Offset = "0xA546E0", VA = "0xA546E0")]
			set
			{
			}
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xA546F8", Offset = "0xA546F8", VA = "0xA546F8", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xA5486C", Offset = "0xA5486C", VA = "0xA5486C", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xA54A84", Offset = "0xA54A84", VA = "0xA54A84")]
		public VolumeSampler()
		{
		}
	}
}
namespace RhythmTool.Examples
{
	[Token(Token = "0x200018A")]
	public abstract class SongSelector : MonoBehaviour
	{
		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xA54AD8", Offset = "0xA54AD8", VA = "0xA54AD8", Slot = "4")]
		public virtual void NextSong()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xA54AFC", Offset = "0xA54AFC", VA = "0xA54AFC")]
		protected SongSelector()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class AudioClipSelector : SongSelector
	{
		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioClip> songs;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentSong;

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xA54B04", Offset = "0xA54B04", VA = "0xA54B04")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xA54B10", Offset = "0xA54B10", VA = "0xA54B10", Slot = "4")]
		public override void NextSong()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xA54C00", Offset = "0xA54C00", VA = "0xA54C00")]
		public AudioClipSelector()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <timestamp>k__BackingField;

		[Token(Token = "0x170000B7")]
		public float timestamp
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xA54C10", Offset = "0xA54C10", VA = "0xA54C10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xA54C18", Offset = "0xA54C18", VA = "0xA54C18")]
			private set
			{
			}
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xA54C20", Offset = "0xA54C20", VA = "0xA54C20")]
		public void Init(Color color, float opacity, float timestamp)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xA54D04", Offset = "0xA54D04", VA = "0xA54D04")]
		public Line()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class Visualizer : MonoBehaviour
	{
		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RhythmEventProvider eventProvider;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text textBPM;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Line linePrefab;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Line> lines;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Chroma> chromaFeatures;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Note lastNote;

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xA54D0C", Offset = "0xA54D0C", VA = "0xA54D0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xA5500C", Offset = "0xA5500C", VA = "0xA5500C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xA55048", Offset = "0xA55048", VA = "0xA55048")]
		private void UpdateLines()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xA554D4", Offset = "0xA554D4", VA = "0xA554D4")]
		private void OnInitialized(RhythmData rhythmData)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xA554EC", Offset = "0xA554EC", VA = "0xA554EC")]
		private void OnReset()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xA556A4", Offset = "0xA556A4", VA = "0xA556A4")]
		private void OnBeat(Beat beat)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xA559E0", Offset = "0xA559E0", VA = "0xA559E0")]
		private void OnOnset(Onset onset)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xA55CB4", Offset = "0xA55CB4", VA = "0xA55CB4")]
		private void OnSegment(Value segment)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xA55828", Offset = "0xA55828", VA = "0xA55828")]
		private void CreateLine(float timestamp, float position, float scale, Color color, float opacity)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xA55CF0", Offset = "0xA55CF0", VA = "0xA55CF0")]
		public Visualizer()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200018E")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000B8")]
		public bool Highlight
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xA55D00", Offset = "0xA55D00", VA = "0xA55D00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xA55D08", Offset = "0xA55D08", VA = "0xA55D08")]
			set
			{
			}
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xA55D14", Offset = "0xA55D14", VA = "0xA55D14")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xA55EB4", Offset = "0xA55EB4", VA = "0xA55EB4", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xA55ED0", Offset = "0xA55ED0", VA = "0xA55ED0", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xA55EEC", Offset = "0xA55EEC", VA = "0xA55EEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xA55DC0", Offset = "0xA55DC0", VA = "0xA55DC0")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xA561A0", Offset = "0xA561A0", VA = "0xA561A0")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000B9")]
		public bool InRange
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xA56218", Offset = "0xA56218", VA = "0xA56218")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xA56220", Offset = "0xA56220", VA = "0xA56220")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool Targeted
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xA56390", Offset = "0xA56390", VA = "0xA56390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xA56398", Offset = "0xA56398", VA = "0xA56398")]
			set
			{
			}
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xA563A4", Offset = "0xA563A4", VA = "0xA563A4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xA5622C", Offset = "0xA5622C", VA = "0xA5622C")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xA56508", Offset = "0xA56508", VA = "0xA56508")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000BB")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0xA56510", Offset = "0xA56510", VA = "0xA56510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000902")]
			[Address(RVA = "0xA56518", Offset = "0xA56518", VA = "0xA56518")]
			set
			{
			}
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xA56534", Offset = "0xA56534", VA = "0xA56534", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xA56740", Offset = "0xA56740", VA = "0xA56740", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xA5702C", Offset = "0xA5702C", VA = "0xA5702C", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xA57594", Offset = "0xA57594", VA = "0xA57594", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xA579A4", Offset = "0xA579A4", VA = "0xA579A4")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xA56968", Offset = "0xA56968", VA = "0xA56968")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xA57A90", Offset = "0xA57A90", VA = "0xA57A90")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xA57E90", Offset = "0xA57E90", VA = "0xA57E90", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xA57EA8", Offset = "0xA57EA8", VA = "0xA57EA8", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xA57EB0", Offset = "0xA57EB0", VA = "0xA57EB0")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000AE0")]
			Disabled,
			[Token(Token = "0x4000AE1")]
			Enabled,
			[Token(Token = "0x4000AE2")]
			Targeted
		}

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xA57ED0", Offset = "0xA57ED0", VA = "0xA57ED0")]
		private void Start()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xA57F38", Offset = "0xA57F38", VA = "0xA57F38")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xA57FC4", Offset = "0xA57FC4", VA = "0xA57FC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xA57FFC", Offset = "0xA57FFC", VA = "0xA57FFC")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xA58004", Offset = "0xA58004", VA = "0xA58004")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xA580B0", Offset = "0xA580B0", VA = "0xA580B0")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xA5815C", Offset = "0xA5815C", VA = "0xA5815C")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000914")]
		[Address(RVA = "0xA58164", Offset = "0xA58164", VA = "0xA58164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xA58250", Offset = "0xA58250", VA = "0xA58250")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xA5825C", Offset = "0xA5825C", VA = "0xA5825C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xA58268", Offset = "0xA58268", VA = "0xA58268")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xA58270", Offset = "0xA58270", VA = "0xA58270")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xA582C0", Offset = "0xA582C0", VA = "0xA582C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xA58698", Offset = "0xA58698", VA = "0xA58698")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xA58784", Offset = "0xA58784", VA = "0xA58784")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xA582C4", Offset = "0xA582C4", VA = "0xA582C4")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xA58870", Offset = "0xA58870", VA = "0xA58870")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000197")]
		public enum ContactTest
		{
			[Token(Token = "0x4000AF9")]
			PerpenTest,
			[Token(Token = "0x4000AFA")]
			BackwardsPress
		}

		[Token(Token = "0x4000AEA")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000AEB")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000BC")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xA58948", Offset = "0xA58948", VA = "0xA58948", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BD")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xA58950", Offset = "0xA58950", VA = "0xA58950")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BE")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xA5895C", Offset = "0xA5895C", VA = "0xA5895C")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0xA58964", Offset = "0xA58964", VA = "0xA58964")]
			private set
			{
			}
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xA5896C", Offset = "0xA5896C", VA = "0xA5896C", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xA58ABC", Offset = "0xA58ABC", VA = "0xA58ABC")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xA58CC4", Offset = "0xA58CC4", VA = "0xA58CC4", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xA59288", Offset = "0xA59288", VA = "0xA59288")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xA593F0", Offset = "0xA593F0", VA = "0xA593F0")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xA591AC", Offset = "0xA591AC", VA = "0xA591AC")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xA594FC", Offset = "0xA594FC", VA = "0xA594FC")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xA59608", Offset = "0xA59608", VA = "0xA59608")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xA59690", Offset = "0xA59690", VA = "0xA59690")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000BF")]
		public Collider Collider
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xA597B4", Offset = "0xA597B4", VA = "0xA597B4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0xA597BC", Offset = "0xA597BC", VA = "0xA597BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xA597C4", Offset = "0xA597C4", VA = "0xA597C4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xA597CC", Offset = "0xA597CC", VA = "0xA597CC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xA597D4", Offset = "0xA597D4", VA = "0xA597D4", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xA59824", Offset = "0xA59824", VA = "0xA59824")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xA598B8", Offset = "0xA598B8", VA = "0xA598B8")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000C2")]
		Collider Collider
		{
			[Token(Token = "0x6000932")]
			get;
		}

		[Token(Token = "0x170000C3")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000933")]
			get;
		}

		[Token(Token = "0x170000C4")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000934")]
			get;
		}
	}
	[Token(Token = "0x200019A")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xA58C18", Offset = "0xA58C18", VA = "0xA58C18")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x200019B")]
	public enum InteractionType
	{
		[Token(Token = "0x4000B03")]
		Enter,
		[Token(Token = "0x4000B04")]
		Stay,
		[Token(Token = "0x4000B05")]
		Exit
	}
	[Token(Token = "0x200019C")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x200019D")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000B17")]
			Mesh,
			[Token(Token = "0x4000B18")]
			Skeleton,
			[Token(Token = "0x4000B19")]
			Both
		}

		[Token(Token = "0x200019E")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xA5AD18", Offset = "0xA5AD18", VA = "0xA5AD18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xA5AD60", Offset = "0xA5AD60", VA = "0xA5AD60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0xA5A310", Offset = "0xA5A310", VA = "0xA5A310")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xA5AAF8", Offset = "0xA5AAF8", VA = "0xA5AAF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xA5AAFC", Offset = "0xA5AAFC", VA = "0xA5AAFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0xA5AD20", Offset = "0xA5AD20", VA = "0xA5AD20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B06")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000C5")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0xA598C0", Offset = "0xA598C0", VA = "0xA598C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000937")]
			[Address(RVA = "0xA598EC", Offset = "0xA598EC", VA = "0xA598EC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0xA59950", Offset = "0xA59950", VA = "0xA59950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xA5997C", Offset = "0xA5997C", VA = "0xA5997C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xA599E0", Offset = "0xA599E0", VA = "0xA599E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xA59A0C", Offset = "0xA59A0C", VA = "0xA59A0C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xA59A70", Offset = "0xA59A70", VA = "0xA59A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xA59A9C", Offset = "0xA59A9C", VA = "0xA59A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xA59B00", Offset = "0xA59B00", VA = "0xA59B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xA59B2C", Offset = "0xA59B2C", VA = "0xA59B2C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xA59B90", Offset = "0xA59B90", VA = "0xA59B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xA59BB8", Offset = "0xA59BB8", VA = "0xA59BB8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xA59C18", Offset = "0xA59C18", VA = "0xA59C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xA59C40", Offset = "0xA59C40", VA = "0xA59C40")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0xA59CA0", Offset = "0xA59CA0", VA = "0xA59CA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0xA59CC8", Offset = "0xA59CC8", VA = "0xA59CC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0xA59D28", Offset = "0xA59D28", VA = "0xA59D28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0xA59D50", Offset = "0xA59D50", VA = "0xA59D50")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0xA59DB0", Offset = "0xA59DB0", VA = "0xA59DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000949")]
			[Address(RVA = "0xA59DD8", Offset = "0xA59DD8", VA = "0xA59DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0xA59E38", Offset = "0xA59E38", VA = "0xA59E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094B")]
			[Address(RVA = "0xA59E80", Offset = "0xA59E80", VA = "0xA59E80")]
			private set
			{
			}
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xA59ED8", Offset = "0xA59ED8", VA = "0xA59ED8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xA5A294", Offset = "0xA5A294", VA = "0xA5A294")]
		private void Update()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xA5A220", Offset = "0xA5A220", VA = "0xA5A220")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xA5A338", Offset = "0xA5A338", VA = "0xA5A338")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xA5A3FC", Offset = "0xA5A3FC", VA = "0xA5A3FC")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xA5A5CC", Offset = "0xA5A5CC", VA = "0xA5A5CC")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xA5A830", Offset = "0xA5A830", VA = "0xA5A830")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xA5A990", Offset = "0xA5A990", VA = "0xA5A990")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0xA5B3B0", Offset = "0xA5B3B0", VA = "0xA5B3B0")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000D2")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0xA5AD68", Offset = "0xA5AD68", VA = "0xA5AD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0xA5AD70", Offset = "0xA5AD70", VA = "0xA5AD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0xA5AD78", Offset = "0xA5AD78", VA = "0xA5AD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0xA5AD80", Offset = "0xA5AD80", VA = "0xA5AD80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000015")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0xA5AD88", Offset = "0xA5AD88", VA = "0xA5AD88")]
			add
			{
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xA5AE38", Offset = "0xA5AE38", VA = "0xA5AE38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0xA5AF04", Offset = "0xA5AF04", VA = "0xA5AF04")]
			add
			{
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0xA5AFB4", Offset = "0xA5AFB4", VA = "0xA5AFB4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0xA5B080", Offset = "0xA5B080", VA = "0xA5B080")]
			add
			{
			}
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xA5B130", Offset = "0xA5B130", VA = "0xA5B130")]
			remove
			{
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xA5AEE8", Offset = "0xA5AEE8", VA = "0xA5AEE8", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xA5B064", Offset = "0xA5B064", VA = "0xA5B064", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xA5B1E0", Offset = "0xA5B1E0", VA = "0xA5B1E0", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000967")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xA58A68", Offset = "0xA58A68", VA = "0xA58A68", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xA5B2AC", Offset = "0xA5B2AC", VA = "0xA5B2AC", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xA597AC", Offset = "0xA597AC", VA = "0xA597AC")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000B25")]
		None,
		[Token(Token = "0x4000B26")]
		Proximity,
		[Token(Token = "0x4000B27")]
		Contact,
		[Token(Token = "0x4000B28")]
		Action
	}
	[Token(Token = "0x20001A2")]
	public enum InteractableState
	{
		[Token(Token = "0x4000B2A")]
		Default,
		[Token(Token = "0x4000B2B")]
		ProximityState,
		[Token(Token = "0x4000B2C")]
		ContactState,
		[Token(Token = "0x4000B2D")]
		ActionState
	}
	[Token(Token = "0x20001A3")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xA59338", Offset = "0xA59338", VA = "0xA59338")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000D6")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0xA5B3F8", Offset = "0xA5B3F8", VA = "0xA5B3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xA5B1FC", Offset = "0xA5B1FC", VA = "0xA5B1FC")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xA5B300", Offset = "0xA5B300", VA = "0xA5B300")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xA5B450", Offset = "0xA5B450", VA = "0xA5B450")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097A")]
				[Address(RVA = "0xA5BC10", Offset = "0xA5BC10", VA = "0xA5BC10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0xA5BC58", Offset = "0xA5BC58", VA = "0xA5BC58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xA5B5F8", Offset = "0xA5B5F8", VA = "0xA5B5F8")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xA5B734", Offset = "0xA5B734", VA = "0xA5B734", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xA5B750", Offset = "0xA5B750", VA = "0xA5B750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xA5BBC0", Offset = "0xA5BBC0", VA = "0xA5BBC0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xA5BC18", Offset = "0xA5BC18", VA = "0xA5BC18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xA5B4F0", Offset = "0xA5B4F0", VA = "0xA5B4F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xA5B55C", Offset = "0xA5B55C", VA = "0xA5B55C")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xA5B620", Offset = "0xA5B620", VA = "0xA5B620")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xA5B72C", Offset = "0xA5B72C", VA = "0xA5B72C")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000D9")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xA5BC60", Offset = "0xA5BC60", VA = "0xA5BC60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xA5BDBC", Offset = "0xA5BDBC", VA = "0xA5BDBC")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xA5BE58", Offset = "0xA5BE58", VA = "0xA5BE58")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xA5BEF4", Offset = "0xA5BEF4", VA = "0xA5BEF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xA5C190", Offset = "0xA5C190", VA = "0xA5C190")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xA5C1CC", Offset = "0xA5C1CC", VA = "0xA5C1CC")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xA5C4A4", Offset = "0xA5C4A4", VA = "0xA5C4A4")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xA5C6AC", Offset = "0xA5C6AC", VA = "0xA5C6AC")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001A9")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0xA5D87C", Offset = "0xA5D87C", VA = "0xA5D87C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000998")]
				[Address(RVA = "0xA5D8C4", Offset = "0xA5D8C4", VA = "0xA5D8C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0xA5C948", Offset = "0xA5C948", VA = "0xA5C948")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0xA5D3EC", Offset = "0xA5D3EC", VA = "0xA5D3EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0xA5D3F0", Offset = "0xA5D3F0", VA = "0xA5D3F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0xA5D884", Offset = "0xA5D884", VA = "0xA5D884", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B46")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000DA")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0xA5C7B4", Offset = "0xA5C7B4", VA = "0xA5C7B4", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000DB")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xA5C7BC", Offset = "0xA5C7BC", VA = "0xA5C7BC", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000DC")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xA5C7C4", Offset = "0xA5C7C4", VA = "0xA5C7C4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public override bool EnableState
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xA5C7CC", Offset = "0xA5C7CC", VA = "0xA5C7CC", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xA5C7F4", Offset = "0xA5C7F4", VA = "0xA5C7F4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xA5C824", Offset = "0xA5C824", VA = "0xA5C824", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA5C8D4", Offset = "0xA5C8D4", VA = "0xA5C8D4")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA5C970", Offset = "0xA5C970", VA = "0xA5C970")]
		private void Update()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA5CBF0", Offset = "0xA5CBF0", VA = "0xA5CBF0")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xA5CDAC", Offset = "0xA5CDAC", VA = "0xA5CDAC")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xA5CE94", Offset = "0xA5CE94", VA = "0xA5CE94", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xA5D228", Offset = "0xA5D228", VA = "0xA5D228", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xA5D22C", Offset = "0xA5D22C", VA = "0xA5D22C", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xA5D230", Offset = "0xA5D230", VA = "0xA5D230")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class FingerTipPokeToolView : MonoBehaviour
	{
		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000E0")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0xA5D8CC", Offset = "0xA5D8CC", VA = "0xA5D8CC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600099A")]
			[Address(RVA = "0xA5D8D4", Offset = "0xA5D8D4", VA = "0xA5D8D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public bool EnableState
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0xA5D8DC", Offset = "0xA5D8DC", VA = "0xA5D8DC", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099C")]
			[Address(RVA = "0xA5D8F8", Offset = "0xA5D8F8", VA = "0xA5D8F8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public bool ToolActivateState
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0xA5D918", Offset = "0xA5D918", VA = "0xA5D918", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099E")]
			[Address(RVA = "0xA5D920", Offset = "0xA5D920", VA = "0xA5D920", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public float SphereRadius
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0xA5D92C", Offset = "0xA5D92C", VA = "0xA5D92C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xA5D934", Offset = "0xA5D934", VA = "0xA5D934")]
			private set
			{
			}
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xA5D93C", Offset = "0xA5D93C", VA = "0xA5D93C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xA5D978", Offset = "0xA5D978", VA = "0xA5D978")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000B59")]
		None = 0,
		[Token(Token = "0x4000B5A")]
		Ray = 1,
		[Token(Token = "0x4000B5B")]
		Poke = 4,
		[Token(Token = "0x4000B5C")]
		All = -1
	}
	[Token(Token = "0x20001AC")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000B5E")]
		Inactive,
		[Token(Token = "0x4000B5F")]
		PrimaryInputDown,
		[Token(Token = "0x4000B60")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000B61")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001AD")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xA5D1D4", Offset = "0xA5D1D4", VA = "0xA5D1D4")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000E4")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0xA59688", Offset = "0xA59688", VA = "0xA59688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xA5D980", Offset = "0xA5D980", VA = "0xA5D980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xA5D988", Offset = "0xA5D988", VA = "0xA5D988")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009A7")]
			get;
		}

		[Token(Token = "0x170000E7")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60009A8")]
			get;
		}

		[Token(Token = "0x170000E8")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60009A9")]
			get;
		}

		[Token(Token = "0x170000E9")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xA5D994", Offset = "0xA5D994", VA = "0xA5D994")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xA5D9A0", Offset = "0xA5D9A0", VA = "0xA5D9A0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xA5D9AC", Offset = "0xA5D9AC", VA = "0xA5D9AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xA5D9B8", Offset = "0xA5D9B8", VA = "0xA5D9B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60009B2")]
			get;
			[Token(Token = "0x60009B3")]
			set;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xA5D9C4", Offset = "0xA5D9C4", VA = "0xA5D9C4")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60009B0")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60009B1")]
		public abstract void DeFocus();

		[Token(Token = "0x60009B4")]
		public abstract void Initialize();

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xA5C614", Offset = "0xA5C614", VA = "0xA5C614")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xA5C65C", Offset = "0xA5C65C", VA = "0xA5C65C")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA5D9CC", Offset = "0xA5D9CC", VA = "0xA5D9CC", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA5DC94", Offset = "0xA5DC94", VA = "0xA5DC94", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA5D244", Offset = "0xA5D244", VA = "0xA5D244")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001B0")]
		private enum PinchState
		{
			[Token(Token = "0x4000B72")]
			None,
			[Token(Token = "0x4000B73")]
			PinchDown,
			[Token(Token = "0x4000B74")]
			PinchStay,
			[Token(Token = "0x4000B75")]
			PinchUp
		}

		[Token(Token = "0x4000B6E")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000EC")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0xA5E530", Offset = "0xA5E530", VA = "0xA5E530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0xA5E5AC", Offset = "0xA5E5AC", VA = "0xA5E5AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0xA5E628", Offset = "0xA5E628", VA = "0xA5E628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xA5E6A4", Offset = "0xA5E6A4", VA = "0xA5E6A4")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA5E6CC", Offset = "0xA5E6CC", VA = "0xA5E6CC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000B76")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000B77")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000B78")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000B79")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000B7A")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000EF")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xA5E844", Offset = "0xA5E844", VA = "0xA5E844", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000F0")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xA5E84C", Offset = "0xA5E84C", VA = "0xA5E84C", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000F1")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xA5E8A8", Offset = "0xA5E8A8", VA = "0xA5E8A8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F2")]
		public override bool EnableState
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xA5E8B0", Offset = "0xA5E8B0", VA = "0xA5E8B0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0xA5E8F0", Offset = "0xA5E8F0", VA = "0xA5E8F0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xA5E960", Offset = "0xA5E960", VA = "0xA5E960", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xA5E9B4", Offset = "0xA5E9B4", VA = "0xA5E9B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xA5EA40", Offset = "0xA5EA40", VA = "0xA5EA40")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xA5ECE4", Offset = "0xA5ECE4", VA = "0xA5ECE4")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xA5ED60", Offset = "0xA5ED60", VA = "0xA5ED60", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xA5F154", Offset = "0xA5F154", VA = "0xA5F154")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xA5F2F0", Offset = "0xA5F2F0", VA = "0xA5F2F0")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xA5F408", Offset = "0xA5F408", VA = "0xA5F408")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xA5F72C", Offset = "0xA5F72C", VA = "0xA5F72C")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xA5FAA8", Offset = "0xA5FAA8", VA = "0xA5FAA8", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xA5FB80", Offset = "0xA5FB80", VA = "0xA5FB80", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xA5FBB0", Offset = "0xA5FBB0", VA = "0xA5FBB0")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class RayToolView : MonoBehaviour
	{
		[Token(Token = "0x4000B86")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000B87")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000F3")]
		public bool EnableState
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xA5E8D4", Offset = "0xA5E8D4", VA = "0xA5E8D4", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xA5E90C", Offset = "0xA5E90C", VA = "0xA5E90C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xA5FCC4", Offset = "0xA5FCC4", VA = "0xA5FCC4", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xA5ECA8", Offset = "0xA5ECA8", VA = "0xA5ECA8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xA5FEEC", Offset = "0xA5FEEC", VA = "0xA5FEEC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xA5FEF4", Offset = "0xA5FEF4", VA = "0xA5FEF4")]
			set
			{
			}
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA5FCCC", Offset = "0xA5FCCC", VA = "0xA5FCCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xA5FAE0", Offset = "0xA5FAE0", VA = "0xA5FAE0", Slot = "9")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xA5FEFC", Offset = "0xA5FEFC", VA = "0xA5FEFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xA601A8", Offset = "0xA601A8", VA = "0xA601A8")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xA60250", Offset = "0xA60250", VA = "0xA60250")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000F6")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xA602B4", Offset = "0xA602B4", VA = "0xA602B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xA602BC", Offset = "0xA602BC", VA = "0xA602BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xA60328", Offset = "0xA60328", VA = "0xA60328")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xA60330", Offset = "0xA60330", VA = "0xA60330")]
			set
			{
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xA6038C", Offset = "0xA6038C", VA = "0xA6038C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xA6062C", Offset = "0xA6062C", VA = "0xA6062C")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xA6063C", Offset = "0xA6063C", VA = "0xA6063C")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xA6064C", Offset = "0xA6064C", VA = "0xA6064C")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xA60654", Offset = "0xA60654", VA = "0xA60654")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xA606E0", Offset = "0xA606E0", VA = "0xA606E0")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xA60770", Offset = "0xA60770", VA = "0xA60770")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xA60800", Offset = "0xA60800", VA = "0xA60800")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xA608AC", Offset = "0xA608AC", VA = "0xA608AC")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xA60988", Offset = "0xA60988", VA = "0xA60988")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xA609CC", Offset = "0xA609CC", VA = "0xA609CC")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xA60A2C", Offset = "0xA60A2C", VA = "0xA60A2C")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xA60A8C", Offset = "0xA60A8C", VA = "0xA60A8C")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xA60A94", Offset = "0xA60A94", VA = "0xA60A94")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xA60A5C", Offset = "0xA60A5C", VA = "0xA60A5C")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xA60AC8", Offset = "0xA60AC8", VA = "0xA60AC8")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001B7")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000F8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F7")]
				[Address(RVA = "0xA61148", Offset = "0xA61148", VA = "0xA61148", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0xA61190", Offset = "0xA61190", VA = "0xA61190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xA60EC0", Offset = "0xA60EC0", VA = "0xA60EC0")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xA60F88", Offset = "0xA60F88", VA = "0xA60F88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xA60F8C", Offset = "0xA60F8C", VA = "0xA60F8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xA61150", Offset = "0xA61150", VA = "0xA61150", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B97")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000B98")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xA60AD0", Offset = "0xA60AD0", VA = "0xA60AD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xA60B70", Offset = "0xA60B70", VA = "0xA60B70")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xA60E80", Offset = "0xA60E80", VA = "0xA60E80")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xA60E0C", Offset = "0xA60E0C", VA = "0xA60E0C")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xA60EE8", Offset = "0xA60EE8", VA = "0xA60EE8")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001B9")]
		public enum SelectionState
		{
			[Token(Token = "0x4000BAE")]
			Off,
			[Token(Token = "0x4000BAF")]
			Selected,
			[Token(Token = "0x4000BB0")]
			Highlighted
		}

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000FA")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xA61198", Offset = "0xA61198", VA = "0xA61198")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xA611A0", Offset = "0xA611A0", VA = "0xA611A0")]
			set
			{
			}
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xA612F4", Offset = "0xA612F4", VA = "0xA612F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xA614B8", Offset = "0xA614B8", VA = "0xA614B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xA61214", Offset = "0xA61214", VA = "0xA61214")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xA61580", Offset = "0xA61580", VA = "0xA61580")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001BB")]
		public enum SegmentType
		{
			[Token(Token = "0x4000BBF")]
			Straight,
			[Token(Token = "0x4000BC0")]
			LeftTurn,
			[Token(Token = "0x4000BC1")]
			RightTurn,
			[Token(Token = "0x4000BC2")]
			Switch
		}

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000BB7")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000BB8")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000FB")]
		public float StartDistance
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xA615F0", Offset = "0xA615F0", VA = "0xA615F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xA615F8", Offset = "0xA615F8", VA = "0xA615F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float GridSize
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xA61600", Offset = "0xA61600", VA = "0xA61600")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xA61608", Offset = "0xA61608", VA = "0xA61608")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public int SubDivCount
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xA61610", Offset = "0xA61610", VA = "0xA61610")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xA61618", Offset = "0xA61618", VA = "0xA61618")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public SegmentType Type
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xA61620", Offset = "0xA61620", VA = "0xA61620")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000FF")]
		public Pose EndPose
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xA61628", Offset = "0xA61628", VA = "0xA61628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public float Radius
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xA619FC", Offset = "0xA619FC", VA = "0xA619FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000101")]
		public float SegmentLength
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0xA61684", Offset = "0xA61684", VA = "0xA61684")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xA61A0C", Offset = "0xA61A0C", VA = "0xA61A0C")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xA616C4", Offset = "0xA616C4", VA = "0xA616C4")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xA61A24", Offset = "0xA61A24", VA = "0xA61A24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xA61A80", Offset = "0xA61A80", VA = "0xA61A80")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xA623B4", Offset = "0xA623B4", VA = "0xA623B4")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xA62638", Offset = "0xA62638", VA = "0xA62638")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001BD")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0xA6315C", Offset = "0xA6315C", VA = "0xA6315C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0xA631A4", Offset = "0xA631A4", VA = "0xA631A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xA62F90", Offset = "0xA62F90", VA = "0xA62F90")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xA62FE0", Offset = "0xA62FE0", VA = "0xA62FE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xA62FE4", Offset = "0xA62FE4", VA = "0xA62FE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xA63164", Offset = "0xA63164", VA = "0xA63164", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BC3")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000BC4")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xA62798", Offset = "0xA62798", VA = "0xA62798")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xA62850", Offset = "0xA62850", VA = "0xA62850")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xA628E0", Offset = "0xA628E0", VA = "0xA628E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xA62A28", Offset = "0xA62A28", VA = "0xA62A28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xA62BB4", Offset = "0xA62BB4", VA = "0xA62BB4")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xA62CC4", Offset = "0xA62CC4", VA = "0xA62CC4")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xA62EC8", Offset = "0xA62EC8", VA = "0xA62EC8")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xA62DD4", Offset = "0xA62DD4", VA = "0xA62DD4")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xA62DE8", Offset = "0xA62DE8", VA = "0xA62DE8")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xA62F1C", Offset = "0xA62F1C", VA = "0xA62F1C")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xA62FB8", Offset = "0xA62FB8", VA = "0xA62FB8")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x17000104")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xA631AC", Offset = "0xA631AC", VA = "0xA631AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xA631BC", Offset = "0xA631BC", VA = "0xA631BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xA631C4", Offset = "0xA631C4", VA = "0xA631C4", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xA634F4", Offset = "0xA634F4", VA = "0xA634F4")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000BDC")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000BDD")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x17000105")]
		public float Distance
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0xA635F0", Offset = "0xA635F0", VA = "0xA635F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0xA635F8", Offset = "0xA635F8", VA = "0xA635F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float Scale
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xA63600", Offset = "0xA63600", VA = "0xA63600")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xA63608", Offset = "0xA63608", VA = "0xA63608")]
			set
			{
			}
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xA631C0", Offset = "0xA631C0", VA = "0xA631C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xA63610", Offset = "0xA63610", VA = "0xA63610")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xA63200", Offset = "0xA63200", VA = "0xA63200")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xA63410", Offset = "0xA63410", VA = "0xA63410")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000A2E")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xA63554", Offset = "0xA63554", VA = "0xA63554")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001C1")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000BF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0xA63EE0", Offset = "0xA63EE0", VA = "0xA63EE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3F")]
				[Address(RVA = "0xA63F28", Offset = "0xA63F28", VA = "0xA63F28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xA63B54", Offset = "0xA63B54", VA = "0xA63B54")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xA63CC8", Offset = "0xA63CC8", VA = "0xA63CC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xA63CCC", Offset = "0xA63CCC", VA = "0xA63CCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xA63EE8", Offset = "0xA63EE8", VA = "0xA63EE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA63780", Offset = "0xA63780", VA = "0xA63780")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xA637DC", Offset = "0xA637DC", VA = "0xA637DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xA638B4", Offset = "0xA638B4", VA = "0xA638B4")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA63A08", Offset = "0xA63A08", VA = "0xA63A08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA63910", Offset = "0xA63910", VA = "0xA63910")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA63AD0", Offset = "0xA63AD0", VA = "0xA63AD0")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA63B7C", Offset = "0xA63B7C", VA = "0xA63B7C")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xA63C14", Offset = "0xA63C14", VA = "0xA63C14")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xA63C70", Offset = "0xA63C70", VA = "0xA63C70")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001C3")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000C1A")]
			Start,
			[Token(Token = "0x4000C1B")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000C1C")]
			Stop
		}

		[Token(Token = "0x20001C4")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0xA647C0", Offset = "0xA647C0", VA = "0xA647C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0xA64808", Offset = "0xA64808", VA = "0xA64808", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0xA641D0", Offset = "0xA641D0", VA = "0xA641D0")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0xA64598", Offset = "0xA64598", VA = "0xA64598", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0xA6459C", Offset = "0xA6459C", VA = "0xA6459C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0xA647C8", Offset = "0xA647C8", VA = "0xA647C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BFC")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000BFD")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000BFE")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000BFF")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0.2f, 2.7f)]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xA63F30", Offset = "0xA63F30", VA = "0xA63F30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xA6408C", Offset = "0xA6408C", VA = "0xA6408C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xA64098", Offset = "0xA64098", VA = "0xA64098", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xA60684", Offset = "0xA60684", VA = "0xA60684")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xA64004", Offset = "0xA64004", VA = "0xA64004")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xA641F8", Offset = "0xA641F8", VA = "0xA641F8")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xA64170", Offset = "0xA64170", VA = "0xA64170")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA60710", Offset = "0xA60710", VA = "0xA60710")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xA607A0", Offset = "0xA607A0", VA = "0xA607A0")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xA6440C", Offset = "0xA6440C", VA = "0xA6440C")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xA64500", Offset = "0xA64500", VA = "0xA64500")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xA60830", Offset = "0xA60830", VA = "0xA60830")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA608DC", Offset = "0xA608DC", VA = "0xA608DC")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA609BC", Offset = "0xA609BC", VA = "0xA609BC")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA6453C", Offset = "0xA6453C", VA = "0xA6453C")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x1700010B")]
		public float TrackLength
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xA64810", Offset = "0xA64810", VA = "0xA64810")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0xA64818", Offset = "0xA64818", VA = "0xA64818")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xA64820", Offset = "0xA64820", VA = "0xA64820")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xA63678", Offset = "0xA63678", VA = "0xA63678")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA64824", Offset = "0xA64824", VA = "0xA64824")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA64A1C", Offset = "0xA64A1C", VA = "0xA64A1C")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA64AFC", Offset = "0xA64AFC", VA = "0xA64AFC")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class Pose
	{
		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xA62700", Offset = "0xA62700", VA = "0xA62700")]
		public Pose()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001C8")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0xA650A8", Offset = "0xA650A8", VA = "0xA650A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6B")]
				[Address(RVA = "0xA650F0", Offset = "0xA650F0", VA = "0xA650F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xA64D90", Offset = "0xA64D90", VA = "0xA64D90")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0xA64F04", Offset = "0xA64F04", VA = "0xA64F04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xA64F08", Offset = "0xA64F08", VA = "0xA64F08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xA650B0", Offset = "0xA650B0", VA = "0xA650B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001C9")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x1700010F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0xA651CC", Offset = "0xA651CC", VA = "0xA651CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0xA65214", Offset = "0xA65214", VA = "0xA65214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0xA64E6C", Offset = "0xA64E6C", VA = "0xA64E6C")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0xA650F8", Offset = "0xA650F8", VA = "0xA650F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0xA650FC", Offset = "0xA650FC", VA = "0xA650FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xA651D4", Offset = "0xA651D4", VA = "0xA651D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C2F")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x4000C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x1700010C")]
		public bool IsMoving
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xA64B18", Offset = "0xA64B18", VA = "0xA64B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xA64B20", Offset = "0xA64B20", VA = "0xA64B20")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xA64B2C", Offset = "0xA64B2C", VA = "0xA64B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xA64B5C", Offset = "0xA64B5C", VA = "0xA64B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xA64C9C", Offset = "0xA64C9C", VA = "0xA64C9C")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xA64D0C", Offset = "0xA64D0C", VA = "0xA64D0C")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xA64DB8", Offset = "0xA64DB8", VA = "0xA64DB8")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xA64E94", Offset = "0xA64E94", VA = "0xA64E94")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xA64EFC", Offset = "0xA64EFC", VA = "0xA64EFC")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xA6521C", Offset = "0xA6521C", VA = "0xA6521C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xA65290", Offset = "0xA65290", VA = "0xA65290")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xA65358", Offset = "0xA65358", VA = "0xA65358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xA65468", Offset = "0xA65468", VA = "0xA65468")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xA654E4", Offset = "0xA654E4", VA = "0xA654E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xA655AC", Offset = "0xA655AC", VA = "0xA655AC")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001CC")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0xA66C3C", Offset = "0xA66C3C", VA = "0xA66C3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0xA66C84", Offset = "0xA66C84", VA = "0xA66C84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xA662CC", Offset = "0xA662CC", VA = "0xA662CC")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0xA66A40", Offset = "0xA66A40", VA = "0xA66A40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xA66A44", Offset = "0xA66A44", VA = "0xA66A44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0xA66C44", Offset = "0xA66C44", VA = "0xA66C44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000C4C")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000C4D")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000C4E")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject mainCamera;

		[Token(Token = "0x4000C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xA655BC", Offset = "0xA655BC", VA = "0xA655BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xA65DFC", Offset = "0xA65DFC", VA = "0xA65DFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xA65F24", Offset = "0xA65F24", VA = "0xA65F24")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xA66054", Offset = "0xA66054", VA = "0xA66054")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xA66184", Offset = "0xA66184", VA = "0xA66184")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xA65F04", Offset = "0xA65F04", VA = "0xA65F04")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xA66258", Offset = "0xA66258", VA = "0xA66258")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xA662F4", Offset = "0xA662F4", VA = "0xA662F4")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xA65A2C", Offset = "0xA65A2C", VA = "0xA65A2C")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xA6643C", Offset = "0xA6643C", VA = "0xA6643C")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xA6631C", Offset = "0xA6631C", VA = "0xA6631C")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xA667C4", Offset = "0xA667C4", VA = "0xA667C4")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xA668B0", Offset = "0xA668B0", VA = "0xA668B0")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xA66944", Offset = "0xA66944", VA = "0xA66944")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xA66998", Offset = "0xA66998", VA = "0xA66998")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xA669EC", Offset = "0xA669EC", VA = "0xA669EC")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001CD")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001CE")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xA67A94", Offset = "0xA67A94", VA = "0xA67A94")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xA67A9C", Offset = "0xA67A9C", VA = "0xA67A9C")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000C66")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000C67")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000C68")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000C69")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000C6A")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000C6B")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000C6C")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000C6D")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000C6E")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000C6F")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000C70")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xA66C8C", Offset = "0xA66C8C", VA = "0xA66C8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xA66CE4", Offset = "0xA66CE4", VA = "0xA66CE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xA67134", Offset = "0xA67134", VA = "0xA67134")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xA67220", Offset = "0xA67220", VA = "0xA67220")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xA67384", Offset = "0xA67384", VA = "0xA67384")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xA67654", Offset = "0xA67654", VA = "0xA67654")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xA67738", Offset = "0xA67738", VA = "0xA67738")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xA678E8", Offset = "0xA678E8", VA = "0xA678E8")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xA67410", Offset = "0xA67410", VA = "0xA67410")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xA67464", Offset = "0xA67464", VA = "0xA67464")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xA66FF4", Offset = "0xA66FF4", VA = "0xA66FF4")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xA67A0C", Offset = "0xA67A0C", VA = "0xA67A0C")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001CF")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000C85")]
		Default,
		[Token(Token = "0x4000C86")]
		Generic,
		[Token(Token = "0x4000C87")]
		PingPongBall,
		[Token(Token = "0x4000C88")]
		Controller
	}
	[Token(Token = "0x20001D0")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x17000113")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xA67AC4", Offset = "0xA67AC4", VA = "0xA67AC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xA67ACC", Offset = "0xA67ACC", VA = "0xA67ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xA67AD4", Offset = "0xA67AD4", VA = "0xA67AD4")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xA67ADC", Offset = "0xA67ADC", VA = "0xA67ADC")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xA67AE4", Offset = "0xA67AE4", VA = "0xA67AE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xA67DB0", Offset = "0xA67DB0", VA = "0xA67DB0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xA67E00", Offset = "0xA67E00", VA = "0xA67E00")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xA67E38", Offset = "0xA67E38", VA = "0xA67E38")]
		public TouchController()
		{
		}
	}
}
namespace MRCHelpers
{
	[Token(Token = "0x20001D2")]
	public class CopyTransform : MonoBehaviour
	{
		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_originalTransform;

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xA67E40", Offset = "0xA67E40", VA = "0xA67E40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xA67EBC", Offset = "0xA67EBC", VA = "0xA67EBC")]
		public CopyTransform()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class OVRMixedRealityCaptureTestMod : MonoBehaviour
	{
		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera defaultExternalCamera;

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xA67EC4", Offset = "0xA67EC4", VA = "0xA67EC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xA67F74", Offset = "0xA67F74", VA = "0xA67F74")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xA681A4", Offset = "0xA681A4", VA = "0xA681A4")]
		private void UpdateDefaultExternalCamera()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xA68524", Offset = "0xA68524", VA = "0xA68524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xA6865C", Offset = "0xA6865C", VA = "0xA6865C")]
		public OVRMixedRealityCaptureTestMod()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class RemoveMRCamerasTracking : MonoBehaviour
	{
		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int frames;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text debugText;

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xA68664", Offset = "0xA68664", VA = "0xA68664")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xA6867C", Offset = "0xA6867C", VA = "0xA6867C")]
		private void RemoveCamerasTracking()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xA687BC", Offset = "0xA687BC", VA = "0xA687BC")]
		public RemoveMRCamerasTracking()
		{
		}
	}
}
namespace creepycat.scifikitvol3
{
	[Token(Token = "0x20001D5")]
	public class ScrollTexture : MonoBehaviour
	{
		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scrollSpeed;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer rend;

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xA687CC", Offset = "0xA687CC", VA = "0xA687CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xA68824", Offset = "0xA68824", VA = "0xA68824")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xA688A4", Offset = "0xA688A4", VA = "0xA688A4")]
		public ScrollTexture()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class Turn_Move : MonoBehaviour
	{
		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float TurnX;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TurnY;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TurnZ;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MoveX;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MoveY;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MoveZ;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool World;

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xA688B4", Offset = "0xA688B4", VA = "0xA688B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xA68944", Offset = "0xA68944", VA = "0xA68944")]
		public Turn_Move()
		{
		}
	}
}
namespace UnityTemplateProject
{
	[Token(Token = "0x20001D7")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001D8")]
		private class CameraState
		{
			[Token(Token = "0x4000CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xA689A0", Offset = "0xA689A0", VA = "0xA689A0")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xA68EF8", Offset = "0xA68EF8", VA = "0xA68EF8")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xA68F78", Offset = "0xA68F78", VA = "0xA68F78")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xA69000", Offset = "0xA69000", VA = "0xA69000")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xA69224", Offset = "0xA69224", VA = "0xA69224")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x4000CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xA6894C", Offset = "0xA6894C", VA = "0xA6894C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xA68A24", Offset = "0xA68A24", VA = "0xA68A24")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xA68C54", Offset = "0xA68C54", VA = "0xA68C54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xA69048", Offset = "0xA69048", VA = "0xA69048")]
		public SimpleCameraController()
		{
		}
	}
}
namespace AmazingAssets.AdvancedDissolve
{
	[Token(Token = "0x20001D9")]
	[ExecuteAlways]
	public abstract class AdvancedDissolveController : MonoBehaviour
	{
		[Token(Token = "0x4000CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveKeywords.GlobalControlID globalControlID;

		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material[] materials;

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xA6922C", Offset = "0xA6922C", VA = "0xA6922C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xA69238", Offset = "0xA69238", VA = "0xA69238", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000ABF")]
		public abstract void ForceUpdateShaderData();

		[Token(Token = "0x6000AC0")]
		public abstract void ResetShaderData();

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xA6923C", Offset = "0xA6923C", VA = "0xA6923C")]
		public void AddMaterialsFromSelection(GameObject[] selection)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xA695A8", Offset = "0xA695A8", VA = "0xA695A8")]
		protected AdvancedDissolveController()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[ExecuteAlways]
	public class AdvancedDissolveGeometricCutoutController : AdvancedDissolveController
	{
		[Token(Token = "0x20001DB")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000CD9")]
			OnFixedUpdate,
			[Token(Token = "0x4000CDA")]
			EveryFrame,
			[Token(Token = "0x4000CDB")]
			Manual
		}

		[Token(Token = "0x4000CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool drawGizmos;

		[Token(Token = "0x4000CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveKeywords.CutoutGeometricType type;

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public AdvancedDissolveKeywords.CutoutGeometricCount count;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZAxis xyzAxis;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZStyle xyzStyle;

		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZSpace xyzSpace;

		[Token(Token = "0x4000CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float xyzRollout;

		[Token(Token = "0x4000CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform xyzPivotPointTransform;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 xyzPivotPointPosition;

		[Token(Token = "0x4000CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform target1StartPointTransform;

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform target1EndPointTransform;

		[Token(Token = "0x4000CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 target1StartPointPosition;

		[Token(Token = "0x4000CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 target1EndPointPosition;

		[Token(Token = "0x4000CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float target1Radius;

		[Token(Token = "0x4000CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Vector3 target1Normal;

		[Token(Token = "0x4000CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 target1Rotation;

		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector3 target1Size;

		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Transform target2StartPointTransform;

		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform target2EndPointTransform;

		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3 target2StartPointPosition;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Vector3 target2EndPointPosition;

		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float target2Radius;

		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector3 target2Normal;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Vector3 target2Rotation;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public Vector3 target2Size;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform target3StartPointTransform;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Transform target3EndPointTransform;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Vector3 target3StartPointPosition;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public Vector3 target3EndPointPosition;

		[Token(Token = "0x4000CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float target3Radius;

		[Token(Token = "0x4000CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public Vector3 target3Normal;

		[Token(Token = "0x4000CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Vector3 target3Rotation;

		[Token(Token = "0x4000CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public Vector3 target3Size;

		[Token(Token = "0x4000CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Transform target4StartPointTransform;

		[Token(Token = "0x4000CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Transform target4EndPointTransform;

		[Token(Token = "0x4000CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Vector3 target4StartPointPosition;

		[Token(Token = "0x4000CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public Vector3 target4EndPointPosition;

		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float target4Radius;

		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public Vector3 target4Normal;

		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Vector3 target4Rotation;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public Vector3 target4Size;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public bool invert;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public float noise;

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xA695B0", Offset = "0xA695B0", VA = "0xA695B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xA695BC", Offset = "0xA695BC", VA = "0xA695BC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xA69F14", Offset = "0xA69F14", VA = "0xA69F14")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xA69F24", Offset = "0xA69F24", VA = "0xA69F24", Slot = "6")]
		[ContextMenu("Force Update Geometric Cutout Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xA69F28", Offset = "0xA69F28", VA = "0xA69F28", Slot = "7")]
		[ContextMenu("Reset Geometric Cutout Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xA695F4", Offset = "0xA695F4", VA = "0xA695F4")]
		private void UpdateShaderData()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xA6A5B8", Offset = "0xA6A5B8", VA = "0xA6A5B8")]
		public Transform GetTargetStartPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return null;
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xA6A608", Offset = "0xA6A608", VA = "0xA6A608")]
		public Transform GetTargetEndPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return null;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xA6A658", Offset = "0xA6A658", VA = "0xA6A658")]
		public Vector3 GetTargetStartPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xA6A808", Offset = "0xA6A808", VA = "0xA6A808")]
		public Vector3 GetTargetEndPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xA6A9B8", Offset = "0xA6A9B8", VA = "0xA6A9B8")]
		public float GetTargetRadius(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(float);
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xA6AA34", Offset = "0xA6AA34", VA = "0xA6AA34")]
		public Vector3 GetTargetNormal(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xA6AC84", Offset = "0xA6AC84", VA = "0xA6AC84")]
		public Vector3 GetTargetRotation(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xA6AE58", Offset = "0xA6AE58", VA = "0xA6AE58")]
		public Vector3 GetTargetSize(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xA6B008", Offset = "0xA6B008", VA = "0xA6B008")]
		public void SetTargetStartPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID, Transform transform)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xA6B058", Offset = "0xA6B058", VA = "0xA6B058")]
		public void SetTargetEndPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID, Transform transform)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xA6B0A8", Offset = "0xA6B0A8", VA = "0xA6B0A8")]
		public void SetTargetStartPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xA6B108", Offset = "0xA6B108", VA = "0xA6B108")]
		public void SetTargetEndPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position)
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xA6B168", Offset = "0xA6B168", VA = "0xA6B168")]
		public void SetTargetRadius(AdvancedDissolveKeywords.CutoutGeometricCount countID, float radius)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xA6B1B0", Offset = "0xA6B1B0", VA = "0xA6B1B0")]
		public void SetTargetNormal(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 normal)
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xA6B210", Offset = "0xA6B210", VA = "0xA6B210")]
		public void SetTargetRotation(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 rotation)
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xA6B270", Offset = "0xA6B270", VA = "0xA6B270")]
		public void SetTargetSize(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 size)
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xA6A400", Offset = "0xA6A400", VA = "0xA6A400")]
		public void GetPlaneData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out Vector3 normal)
		{
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xA6A44C", Offset = "0xA6A44C", VA = "0xA6A44C")]
		public void GetSphereData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out float radius)
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xA6A494", Offset = "0xA6A494", VA = "0xA6A494")]
		public void GetCubeData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out Vector3 rotation, out Vector3 size)
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xA6A4F8", Offset = "0xA6A4F8", VA = "0xA6A4F8")]
		public void GetCapsuleData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 startPosition, out Vector3 endPosition, out float radius)
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0xA6A558", Offset = "0xA6A558", VA = "0xA6A558")]
		public void GetConeSmoothData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 startPosition, out Vector3 endPosition, out float radius)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0xA6B2D0", Offset = "0xA6B2D0", VA = "0xA6B2D0")]
		public AdvancedDissolveGeometricCutoutController()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	[ExecuteAlways]
	public class AdvancedDissolveKeywordsController : AdvancedDissolveController
	{
		[Token(Token = "0x4000CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AdvancedDissolveKeywords.State state;

		[Token(Token = "0x4000CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int previousState;

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveKeywords.CutoutStandardSource cutoutStandardSource;

		[Token(Token = "0x4000CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int previousCutoutStandardSource;

		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveKeywords.CutoutStandardSourceMapsMappingType cutoutStandardSourceMapsMappingType;

		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int previousCutoutStandardSourceMapsMappingType;

		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveKeywords.CutoutGeometricType cutoutGeometricType;

		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int previousCutoutGeometricType;

		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancedDissolveKeywords.CutoutGeometricCount cutoutGeometricCount;

		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int previousCutoutGeometricCount;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AdvancedDissolveKeywords.EdgeBaseSource edgeBaseSource;

		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int previousEdgeBaseSource;

		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AdvancedDissolveKeywords.EdgeAdditionalColorSource edgeAdditionalColorSource;

		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int previousEdgeAdditionalColorSource;

		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AdvancedDissolveKeywords.EdgeUVDistortionSource edgeUVDistortionSource;

		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int previousEdgeUVDistortionSource;

		[Token(Token = "0x4000CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int previousGlobalControlID;

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0xA6C564", Offset = "0xA6C564", VA = "0xA6C564", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xA6C588", Offset = "0xA6C588", VA = "0xA6C588", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xA6CE60", Offset = "0xA6CE60", VA = "0xA6CE60", Slot = "6")]
		[ContextMenu("Force Update Keywords Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0xA6CE8C", Offset = "0xA6CE8C", VA = "0xA6CE8C", Slot = "7")]
		[ContextMenu("Reset Keywords Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xA6CEB8", Offset = "0xA6CEB8", VA = "0xA6CEB8")]
		public AdvancedDissolveKeywordsController()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	[ExecuteAlways]
	public class AdvancedDissolvePropertiesController : AdvancedDissolveController
	{
		[Token(Token = "0x20001DE")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000CF5")]
			OnAwake,
			[Token(Token = "0x4000CF6")]
			OnFixedUpdate,
			[Token(Token = "0x4000CF7")]
			EveryFrame,
			[Token(Token = "0x4000CF8")]
			Manual
		}

		[Token(Token = "0x4000CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveProperties.Cutout.Standard cutoutStandard;

		[Token(Token = "0x4000CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveProperties.Cutout.Geometric cutoutGeometric;

		[Token(Token = "0x4000CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveProperties.Edge.Base edgeBase;

		[Token(Token = "0x4000CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancedDissolveProperties.Edge.AdditionalColor edgeAdditionalColor;

		[Token(Token = "0x4000CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AdvancedDissolveProperties.Edge.UVDistortion edgeUVDistortion;

		[Token(Token = "0x4000CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AdvancedDissolveProperties.Edge.GlobalIllumination edgeGlobalIllumination;

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0xA6CEE8", Offset = "0xA6CEE8", VA = "0xA6CEE8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0xA6CFD8", Offset = "0xA6CFD8", VA = "0xA6CFD8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xA6D01C", Offset = "0xA6D01C", VA = "0xA6D01C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xA6D030", Offset = "0xA6D030", VA = "0xA6D030", Slot = "6")]
		[ContextMenu("Force Update Properties Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xA6CF14", Offset = "0xA6CF14", VA = "0xA6CF14")]
		private void UpdateShaderData()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xA6DCA8", Offset = "0xA6DCA8", VA = "0xA6DCA8", Slot = "7")]
		[ContextMenu("Reset Properties Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0xA6E164", Offset = "0xA6E164", VA = "0xA6E164")]
		public AdvancedDissolvePropertiesController()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public static class AdvancedDissolveKeywords
	{
		[Token(Token = "0x20001E0")]
		public enum State
		{
			[Token(Token = "0x4000CFC")]
			Disabled,
			[Token(Token = "0x4000CFD")]
			Enabled
		}

		[Token(Token = "0x20001E1")]
		public enum CutoutStandardSource
		{
			[Token(Token = "0x4000CFF")]
			None,
			[Token(Token = "0x4000D00")]
			BaseAlpha,
			[Token(Token = "0x4000D01")]
			CustomMap,
			[Token(Token = "0x4000D02")]
			TwoCustomMaps,
			[Token(Token = "0x4000D03")]
			ThreeCustomMaps,
			[Token(Token = "0x4000D04")]
			UserDefined
		}

		[Token(Token = "0x20001E2")]
		public enum CutoutStandardSourceMapsMappingType
		{
			[Token(Token = "0x4000D06")]
			Default,
			[Token(Token = "0x4000D07")]
			Triplanar,
			[Token(Token = "0x4000D08")]
			ScreenSpace
		}

		[Token(Token = "0x20001E3")]
		public enum CutoutGeometricType
		{
			[Token(Token = "0x4000D0A")]
			None,
			[Token(Token = "0x4000D0B")]
			XYZAxis,
			[Token(Token = "0x4000D0C")]
			Plane,
			[Token(Token = "0x4000D0D")]
			Sphere,
			[Token(Token = "0x4000D0E")]
			Cube,
			[Token(Token = "0x4000D0F")]
			Capsule,
			[Token(Token = "0x4000D10")]
			ConeSmooth
		}

		[Token(Token = "0x20001E4")]
		public enum CutoutGeometricCount
		{
			[Token(Token = "0x4000D12")]
			One,
			[Token(Token = "0x4000D13")]
			Two,
			[Token(Token = "0x4000D14")]
			Three,
			[Token(Token = "0x4000D15")]
			Four
		}

		[Token(Token = "0x20001E5")]
		public enum EdgeBaseSource
		{
			[Token(Token = "0x4000D17")]
			None,
			[Token(Token = "0x4000D18")]
			CutoutStandard,
			[Token(Token = "0x4000D19")]
			CutoutGeometric,
			[Token(Token = "0x4000D1A")]
			All
		}

		[Token(Token = "0x20001E6")]
		public enum EdgeAdditionalColorSource
		{
			[Token(Token = "0x4000D1C")]
			None,
			[Token(Token = "0x4000D1D")]
			BaseColor,
			[Token(Token = "0x4000D1E")]
			CustomMap,
			[Token(Token = "0x4000D1F")]
			GradientMap,
			[Token(Token = "0x4000D20")]
			GradientColor,
			[Token(Token = "0x4000D21")]
			UserDefined
		}

		[Token(Token = "0x20001E7")]
		public enum EdgeUVDistortionSource
		{
			[Token(Token = "0x4000D23")]
			Default,
			[Token(Token = "0x4000D24")]
			CustomMap
		}

		[Token(Token = "0x20001E8")]
		public enum GlobalControlID
		{
			[Token(Token = "0x4000D26")]
			None,
			[Token(Token = "0x4000D27")]
			One,
			[Token(Token = "0x4000D28")]
			Two,
			[Token(Token = "0x4000D29")]
			Three,
			[Token(Token = "0x4000D2A")]
			Four
		}

		[Token(Token = "0x4000CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[][] enumNames;

		[Token(Token = "0x4000CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] materialKeywordVariables;

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0xA6C7C4", Offset = "0xA6C7C4", VA = "0xA6C7C4")]
		public static void SetKeyword(Material[] materials, State keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0xA6C880", Offset = "0xA6C880", VA = "0xA6C880")]
		public static void SetKeyword(Material[] materials, CutoutStandardSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0xA6C93C", Offset = "0xA6C93C", VA = "0xA6C93C")]
		public static void SetKeyword(Material[] materials, CutoutStandardSourceMapsMappingType keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xA6C9F8", Offset = "0xA6C9F8", VA = "0xA6C9F8")]
		public static void SetKeyword(Material[] materials, CutoutGeometricType keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xA6CAB4", Offset = "0xA6CAB4", VA = "0xA6CAB4")]
		public static void SetKeyword(Material[] materials, CutoutGeometricCount keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xA6CB70", Offset = "0xA6CB70", VA = "0xA6CB70")]
		public static void SetKeyword(Material[] materials, EdgeBaseSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xA6CC2C", Offset = "0xA6CC2C", VA = "0xA6CC2C")]
		public static void SetKeyword(Material[] materials, EdgeAdditionalColorSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0xA6CCE8", Offset = "0xA6CCE8", VA = "0xA6CCE8")]
		public static void SetKeyword(Material[] materials, EdgeUVDistortionSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0xA6CDA4", Offset = "0xA6CDA4", VA = "0xA6CDA4")]
		public static void SetKeyword(Material[] materials, GlobalControlID keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0xA6E32C", Offset = "0xA6E32C", VA = "0xA6E32C")]
		private static void SetKeyword(Material material, int enumID, int enumValue, bool enable)
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public static class AdvancedDissolveProperties
	{
		[Serializable]
		[Token(Token = "0x20001EA")]
		public class Cutout
		{
			[Serializable]
			[Token(Token = "0x20001EB")]
			public class Standard
			{
				[Token(Token = "0x20001EC")]
				private class IDs
				{
					[Token(Token = "0x4000D46")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int clip;

					[Token(Token = "0x4000D47")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int map1;

					[Token(Token = "0x4000D48")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int map1Tiling;

					[Token(Token = "0x4000D49")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int map1Offset;

					[Token(Token = "0x4000D4A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int map1Scroll;

					[Token(Token = "0x4000D4B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int map1Intensity;

					[Token(Token = "0x4000D4C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int map1Channel;

					[Token(Token = "0x4000D4D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int map1Invert;

					[Token(Token = "0x4000D4E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int map2;

					[Token(Token = "0x4000D4F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int map2Tiling;

					[Token(Token = "0x4000D50")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int map2Offset;

					[Token(Token = "0x4000D51")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int map2Scroll;

					[Token(Token = "0x4000D52")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
					public int map2Intensity;

					[Token(Token = "0x4000D53")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
					public int map2Channel;

					[Token(Token = "0x4000D54")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
					public int map2Invert;

					[Token(Token = "0x4000D55")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
					public int map3;

					[Token(Token = "0x4000D56")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
					public int map3Tiling;

					[Token(Token = "0x4000D57")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
					public int map3Offset;

					[Token(Token = "0x4000D58")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
					public int map3Scroll;

					[Token(Token = "0x4000D59")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
					public int map3Intensity;

					[Token(Token = "0x4000D5A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
					public int map3Channel;

					[Token(Token = "0x4000D5B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
					public int map3Invert;

					[Token(Token = "0x4000D5C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
					public int mapsBlendType;

					[Token(Token = "0x4000D5D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
					public int mapsTriplanarMappingSpace;

					[Token(Token = "0x4000D5E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
					public int mapsScreenSpaceUVScale;

					[Token(Token = "0x4000D5F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
					public int baseInvert;

					[Token(Token = "0x6000AFE")]
					[Address(RVA = "0xA727AC", Offset = "0xA727AC", VA = "0xA727AC")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001ED")]
				public enum Property
				{
					[Token(Token = "0x4000D61")]
					Clip,
					[Token(Token = "0x4000D62")]
					Map1,
					[Token(Token = "0x4000D63")]
					Map1Tiling,
					[Token(Token = "0x4000D64")]
					Map1Offset,
					[Token(Token = "0x4000D65")]
					Map1Scroll,
					[Token(Token = "0x4000D66")]
					Map1Intensity,
					[Token(Token = "0x4000D67")]
					Map1Channel,
					[Token(Token = "0x4000D68")]
					Map1Invert,
					[Token(Token = "0x4000D69")]
					Map2,
					[Token(Token = "0x4000D6A")]
					Map2Tiling,
					[Token(Token = "0x4000D6B")]
					Map2Offset,
					[Token(Token = "0x4000D6C")]
					Map2Scroll,
					[Token(Token = "0x4000D6D")]
					Map2Intensity,
					[Token(Token = "0x4000D6E")]
					Map2Channel,
					[Token(Token = "0x4000D6F")]
					Map2Invert,
					[Token(Token = "0x4000D70")]
					Map3,
					[Token(Token = "0x4000D71")]
					Map3Tiling,
					[Token(Token = "0x4000D72")]
					Map3Offset,
					[Token(Token = "0x4000D73")]
					Map3Scroll,
					[Token(Token = "0x4000D74")]
					Map3Intensity,
					[Token(Token = "0x4000D75")]
					Map3Channel,
					[Token(Token = "0x4000D76")]
					Map3Invert,
					[Token(Token = "0x4000D77")]
					MapsBlendType,
					[Token(Token = "0x4000D78")]
					TriplanarMappingSpace,
					[Token(Token = "0x4000D79")]
					ScreenSpaceUVScale,
					[Token(Token = "0x4000D7A")]
					BaseInvert
				}

				[Token(Token = "0x20001EE")]
				public enum MapsBlendType
				{
					[Token(Token = "0x4000D7C")]
					Multiply,
					[Token(Token = "0x4000D7D")]
					Add
				}

				[Token(Token = "0x20001EF")]
				public enum TriplanarMappingSpace
				{
					[Token(Token = "0x4000D7F")]
					World,
					[Token(Token = "0x4000D80")]
					Local
				}

				[Token(Token = "0x20001F0")]
				public enum ScreenSpaceUVScale
				{
					[Token(Token = "0x4000D82")]
					Constant,
					[Token(Token = "0x4000D83")]
					CameraRelative
				}

				[Token(Token = "0x20001F1")]
				public enum MapChannel
				{
					[Token(Token = "0x4000D85")]
					Red,
					[Token(Token = "0x4000D86")]
					Green,
					[Token(Token = "0x4000D87")]
					Blue,
					[Token(Token = "0x4000D88")]
					Alpha
				}

				[Token(Token = "0x4000D2B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000D2C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Range(0f, 1f)]
				public float clip;

				[Token(Token = "0x4000D2D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Texture2D map1;

				[Token(Token = "0x4000D2E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector3 map1Tiling;

				[Token(Token = "0x4000D2F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				public Vector3 map1Offset;

				[Token(Token = "0x4000D30")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public Vector3 map1Scroll;

				[Token(Token = "0x4000D31")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				[Range(0f, 1f)]
				public float map1Intensity;

				[Token(Token = "0x4000D32")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public MapChannel map1Channel;

				[Token(Token = "0x4000D33")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				public bool map1Invert;

				[Token(Token = "0x4000D34")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public Texture2D map2;

				[Token(Token = "0x4000D35")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public Vector3 map2Tiling;

				[Token(Token = "0x4000D36")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
				public Vector3 map2Offset;

				[Token(Token = "0x4000D37")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Vector3 map2Scroll;

				[Token(Token = "0x4000D38")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
				[Range(0f, 1f)]
				public float map2Intensity;

				[Token(Token = "0x4000D39")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				public MapChannel map2Channel;

				[Token(Token = "0x4000D3A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
				public bool map2Invert;

				[Token(Token = "0x4000D3B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				public Texture2D map3;

				[Token(Token = "0x4000D3C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public Vector3 map3Tiling;

				[Token(Token = "0x4000D3D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
				public Vector3 map3Offset;

				[Token(Token = "0x4000D3E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				public Vector3 map3Scroll;

				[Token(Token = "0x4000D3F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
				[Range(0f, 1f)]
				public float map3Intensity;

				[Token(Token = "0x4000D40")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				public MapChannel map3Channel;

				[Token(Token = "0x4000D41")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
				public bool map3Invert;

				[Token(Token = "0x4000D42")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				public MapsBlendType mapsBlendType;

				[Token(Token = "0x4000D43")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
				public TriplanarMappingSpace triplanarMappingSpace;

				[Token(Token = "0x4000D44")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				public ScreenSpaceUVScale screenSpaceUVScale;

				[Token(Token = "0x4000D45")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
				public bool baseInvert;

				[Token(Token = "0x6000AF7")]
				[Address(RVA = "0xA6D034", Offset = "0xA6D034", VA = "0xA6D034")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0xA6F80C", Offset = "0xA6F80C", VA = "0xA6F80C")]
				public void UpdateLocal(Material material)
				{
				}

				[Token(Token = "0x6000AF9")]
				[Address(RVA = "0xA6D23C", Offset = "0xA6D23C", VA = "0xA6D23C")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000AFA")]
				[Address(RVA = "0xA6FD0C", Offset = "0xA6FD0C", VA = "0xA6FD0C")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0xA710B4", Offset = "0xA710B4", VA = "0xA710B4")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AFC")]
				[Address(RVA = "0xA6DE20", Offset = "0xA6DE20", VA = "0xA6DE20")]
				public Standard()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001F2")]
			public class Geometric
			{
				[Token(Token = "0x20001F3")]
				private class IDs
				{
					[Token(Token = "0x4000D8A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int invert;

					[Token(Token = "0x4000D8B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int noise;

					[Token(Token = "0x4000D8C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int xyzAxis;

					[Token(Token = "0x4000D8D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int xyzStyle;

					[Token(Token = "0x4000D8E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int xyzSpace;

					[Token(Token = "0x4000D8F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int xyzRollout;

					[Token(Token = "0x4000D90")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int xyzPivotPointPosition;

					[Token(Token = "0x4000D91")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int position1;

					[Token(Token = "0x4000D92")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int normal1;

					[Token(Token = "0x4000D93")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int radius1;

					[Token(Token = "0x4000D94")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int height1;

					[Token(Token = "0x4000D95")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int size1;

					[Token(Token = "0x4000D96")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
					public int matrixTRS1;

					[Token(Token = "0x4000D97")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
					public int position2;

					[Token(Token = "0x4000D98")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
					public int normal2;

					[Token(Token = "0x4000D99")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
					public int radius2;

					[Token(Token = "0x4000D9A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
					public int height2;

					[Token(Token = "0x4000D9B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
					public int size2;

					[Token(Token = "0x4000D9C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
					public int matrixTRS2;

					[Token(Token = "0x4000D9D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
					public int position3;

					[Token(Token = "0x4000D9E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
					public int normal3;

					[Token(Token = "0x4000D9F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
					public int radius3;

					[Token(Token = "0x4000DA0")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
					public int height3;

					[Token(Token = "0x4000DA1")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
					public int size3;

					[Token(Token = "0x4000DA2")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
					public int matrixTRS3;

					[Token(Token = "0x4000DA3")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
					public int position4;

					[Token(Token = "0x4000DA4")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
					public int normal4;

					[Token(Token = "0x4000DA5")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
					public int radius4;

					[Token(Token = "0x4000DA6")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
					public int height4;

					[Token(Token = "0x4000DA7")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
					public int size4;

					[Token(Token = "0x4000DA8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
					public int matrixTRS4;

					[Token(Token = "0x6000B03")]
					[Address(RVA = "0xA756BC", Offset = "0xA756BC", VA = "0xA756BC")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001F4")]
				public enum Property
				{
					[Token(Token = "0x4000DAA")]
					XYZAxis,
					[Token(Token = "0x4000DAB")]
					XYZStyle,
					[Token(Token = "0x4000DAC")]
					XYZSpace,
					[Token(Token = "0x4000DAD")]
					XYZRollout,
					[Token(Token = "0x4000DAE")]
					XYZPosition,
					[Token(Token = "0x4000DAF")]
					Position1,
					[Token(Token = "0x4000DB0")]
					Normal1,
					[Token(Token = "0x4000DB1")]
					Radius1,
					[Token(Token = "0x4000DB2")]
					Height1,
					[Token(Token = "0x4000DB3")]
					Size1,
					[Token(Token = "0x4000DB4")]
					MatrixTRS1,
					[Token(Token = "0x4000DB5")]
					Position2,
					[Token(Token = "0x4000DB6")]
					Normal2,
					[Token(Token = "0x4000DB7")]
					Radius2,
					[Token(Token = "0x4000DB8")]
					Height2,
					[Token(Token = "0x4000DB9")]
					Size2,
					[Token(Token = "0x4000DBA")]
					MatrixTRS2,
					[Token(Token = "0x4000DBB")]
					Position3,
					[Token(Token = "0x4000DBC")]
					Normal3,
					[Token(Token = "0x4000DBD")]
					Radius3,
					[Token(Token = "0x4000DBE")]
					Height3,
					[Token(Token = "0x4000DBF")]
					Size3,
					[Token(Token = "0x4000DC0")]
					MatrixTRS3,
					[Token(Token = "0x4000DC1")]
					Position4,
					[Token(Token = "0x4000DC2")]
					Normal4,
					[Token(Token = "0x4000DC3")]
					Radius4,
					[Token(Token = "0x4000DC4")]
					Height4,
					[Token(Token = "0x4000DC5")]
					Size4,
					[Token(Token = "0x4000DC6")]
					MatrixTRS4,
					[Token(Token = "0x4000DC7")]
					Invert,
					[Token(Token = "0x4000DC8")]
					Noise
				}

				[Token(Token = "0x20001F5")]
				public enum XYZAxis
				{
					[Token(Token = "0x4000DCA")]
					X,
					[Token(Token = "0x4000DCB")]
					Y,
					[Token(Token = "0x4000DCC")]
					Z
				}

				[Token(Token = "0x20001F6")]
				public enum XYZStyle
				{
					[Token(Token = "0x4000DCE")]
					Linear,
					[Token(Token = "0x4000DCF")]
					Rollout
				}

				[Token(Token = "0x20001F7")]
				public enum XYZSpace
				{
					[Token(Token = "0x4000DD1")]
					World,
					[Token(Token = "0x4000DD2")]
					Local
				}

				[Token(Token = "0x20001F8")]
				public static class UpdateLocalProperty
				{
					[Token(Token = "0x6000B04")]
					[Address(RVA = "0xA75D54", Offset = "0xA75D54", VA = "0xA75D54")]
					public static void XYZAxis(Material material, XYZAxis xyzAxis, XYZStyle xyzStyle, XYZSpace xyzSpace, float axisRollout, Vector3 axisPosition)
					{
					}

					[Token(Token = "0x6000B05")]
					[Address(RVA = "0xA75F00", Offset = "0xA75F00", VA = "0xA75F00")]
					public static void Plane(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Vector3 normal)
					{
					}

					[Token(Token = "0x6000B06")]
					[Address(RVA = "0xA760F0", Offset = "0xA760F0", VA = "0xA760F0")]
					public static void Sphere(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, float radius)
					{
					}

					[Token(Token = "0x6000B07")]
					[Address(RVA = "0xA762F4", Offset = "0xA762F4", VA = "0xA762F4")]
					public static void Cube(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Quaternion rotation, Vector3 size)
					{
					}

					[Token(Token = "0x6000B08")]
					[Address(RVA = "0xA765EC", Offset = "0xA765EC", VA = "0xA765EC")]
					public static void Capsule(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000B09")]
					[Address(RVA = "0xA76A54", Offset = "0xA76A54", VA = "0xA76A54")]
					public static void ConeSmooth(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000B0A")]
					[Address(RVA = "0xA76A58", Offset = "0xA76A58", VA = "0xA76A58")]
					public static void Invert(Material material, bool invert)
					{
					}

					[Token(Token = "0x6000B0B")]
					[Address(RVA = "0xA76AF8", Offset = "0xA76AF8", VA = "0xA76AF8")]
					public static void Noise(Material material, float noise)
					{
					}
				}

				[Token(Token = "0x20001F9")]
				public static class UpdateGlobalProperty
				{
					[Token(Token = "0x6000B0C")]
					[Address(RVA = "0xA76BA0", Offset = "0xA76BA0", VA = "0xA76BA0")]
					public static void XYZAxis(AdvancedDissolveKeywords.GlobalControlID globalControlID, XYZAxis xyzAxis, XYZStyle xyzStyle, XYZSpace xyzSpace, float axisRollout, Vector3 position)
					{
					}

					[Token(Token = "0x6000B0D")]
					[Address(RVA = "0xA76D4C", Offset = "0xA76D4C", VA = "0xA76D4C")]
					public static void Plane(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Vector3 normal)
					{
					}

					[Token(Token = "0x6000B0E")]
					[Address(RVA = "0xA76F3C", Offset = "0xA76F3C", VA = "0xA76F3C")]
					public static void Sphere(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, float radius)
					{
					}

					[Token(Token = "0x6000B0F")]
					[Address(RVA = "0xA77140", Offset = "0xA77140", VA = "0xA77140")]
					public static void Cube(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Quaternion rotation, Vector3 size)
					{
					}

					[Token(Token = "0x6000B10")]
					[Address(RVA = "0xA77438", Offset = "0xA77438", VA = "0xA77438")]
					public static void Capsule(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000B11")]
					[Address(RVA = "0xA778A0", Offset = "0xA778A0", VA = "0xA778A0")]
					public static void ConeSmooth(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000B12")]
					[Address(RVA = "0xA778A4", Offset = "0xA778A4", VA = "0xA778A4")]
					public static void Invert(AdvancedDissolveKeywords.GlobalControlID globalControlID, bool invert)
					{
					}

					[Token(Token = "0x6000B13")]
					[Address(RVA = "0xA77944", Offset = "0xA77944", VA = "0xA77944")]
					public static void Noise(AdvancedDissolveKeywords.GlobalControlID globalControlID, float noise)
					{
					}
				}

				[Token(Token = "0x4000D89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0xA72D54", Offset = "0xA72D54", VA = "0xA72D54")]
				private static void UpdateLocal(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000B00")]
				[Address(RVA = "0xA740D0", Offset = "0xA740D0", VA = "0xA740D0")]
				private static void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000B01")]
				[Address(RVA = "0xA6E324", Offset = "0xA6E324", VA = "0xA6E324")]
				public Geometric()
				{
				}
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xA6F804", Offset = "0xA6F804", VA = "0xA6F804")]
			public Cutout()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001FA")]
		public class Edge
		{
			[Serializable]
			[Token(Token = "0x20001FB")]
			public class Base
			{
				[Token(Token = "0x20001FC")]
				private class IDs
				{
					[Token(Token = "0x4000DDA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int widthStandard;

					[Token(Token = "0x4000DDB")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int widthGeometric;

					[Token(Token = "0x4000DDC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int shape;

					[Token(Token = "0x4000DDD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int color;

					[Token(Token = "0x4000DDE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int colorTransparency;

					[Token(Token = "0x4000DDF")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int colorIntensity;

					[Token(Token = "0x6000B1C")]
					[Address(RVA = "0xA78964", Offset = "0xA78964", VA = "0xA78964")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001FD")]
				public enum Property
				{
					[Token(Token = "0x4000DE1")]
					WidthStandard,
					[Token(Token = "0x4000DE2")]
					WidthGeometric,
					[Token(Token = "0x4000DE3")]
					Shape,
					[Token(Token = "0x4000DE4")]
					Color,
					[Token(Token = "0x4000DE5")]
					ColorTransparency,
					[Token(Token = "0x4000DE6")]
					ColorIntensity
				}

				[Token(Token = "0x20001FE")]
				public enum Shape
				{
					[Token(Token = "0x4000DE8")]
					Solid,
					[Token(Token = "0x4000DE9")]
					Smooth,
					[Token(Token = "0x4000DEA")]
					Smoother
				}

				[Token(Token = "0x4000DD3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DD4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Range(0f, 1f)]
				public float widthCutoutStandard;

				[Token(Token = "0x4000DD5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				public float widthCutoutGeometric;

				[Token(Token = "0x4000DD6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Shape shape;

				[Token(Token = "0x4000DD7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public Color color;

				[Token(Token = "0x4000DD8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				[Range(0f, 1f)]
				public float colorTransparency;

				[Token(Token = "0x4000DD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public float colorIntensity;

				[Token(Token = "0x6000B15")]
				[Address(RVA = "0xA6D09C", Offset = "0xA6D09C", VA = "0xA6D09C")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000B16")]
				[Address(RVA = "0xA779F4", Offset = "0xA779F4", VA = "0xA779F4")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000B17")]
				[Address(RVA = "0xA6D708", Offset = "0xA6D708", VA = "0xA6D708")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000B18")]
				[Address(RVA = "0xA77B7C", Offset = "0xA77B7C", VA = "0xA77B7C")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000B19")]
				[Address(RVA = "0xA78180", Offset = "0xA78180", VA = "0xA78180")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0xA6DFFC", Offset = "0xA6DFFC", VA = "0xA6DFFC")]
				public Base()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FF")]
			public class AdditionalColor
			{
				[Token(Token = "0x2000200")]
				private class IDs
				{
					[Token(Token = "0x4000DF8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int color;

					[Token(Token = "0x4000DF9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int colorTransparency;

					[Token(Token = "0x4000DFA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int colorIntensity;

					[Token(Token = "0x4000DFB")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int clipInterpolation;

					[Token(Token = "0x4000DFC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int map;

					[Token(Token = "0x4000DFD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int mapTiling;

					[Token(Token = "0x4000DFE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int mapOffset;

					[Token(Token = "0x4000DFF")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int mapScroll;

					[Token(Token = "0x4000E00")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int mapReverse;

					[Token(Token = "0x4000E01")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int mapMipMap;

					[Token(Token = "0x4000E02")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int phaseOffset;

					[Token(Token = "0x4000E03")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int alphaOffset;

					[Token(Token = "0x6000B24")]
					[Address(RVA = "0xA7A8F0", Offset = "0xA7A8F0", VA = "0xA7A8F0")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x2000201")]
				public enum Property
				{
					[Token(Token = "0x4000E05")]
					Map,
					[Token(Token = "0x4000E06")]
					MapTiling,
					[Token(Token = "0x4000E07")]
					MapOffset,
					[Token(Token = "0x4000E08")]
					MapScroll,
					[Token(Token = "0x4000E09")]
					MapReverse,
					[Token(Token = "0x4000E0A")]
					MapMipmap,
					[Token(Token = "0x4000E0B")]
					PhaseOffset,
					[Token(Token = "0x4000E0C")]
					AlphaOffset,
					[Token(Token = "0x4000E0D")]
					Color,
					[Token(Token = "0x4000E0E")]
					ColorTransparency,
					[Token(Token = "0x4000E0F")]
					ColorIntensity,
					[Token(Token = "0x4000E10")]
					ClipInterpolation
				}

				[Token(Token = "0x4000DEB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DEC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Texture2D map;

				[Token(Token = "0x4000DED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Vector2 mapTiling;

				[Token(Token = "0x4000DEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector2 mapOffset;

				[Token(Token = "0x4000DEF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Vector2 mapScroll;

				[Token(Token = "0x4000DF0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public bool mapReverse;

				[Token(Token = "0x4000DF1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				[Range(0f, 10f)]
				public int mapMipmap;

				[Token(Token = "0x4000DF2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public float phaseOffset;

				[Token(Token = "0x4000DF3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				[Range(-1f, 1f)]
				public float alphaOffset;

				[Token(Token = "0x4000DF4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Color color;

				[Token(Token = "0x4000DF5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				[Range(0f, 1f)]
				public float colorTransparency;

				[Token(Token = "0x4000DF6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				public float colorIntensity;

				[Token(Token = "0x4000DF7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public bool clipInterpolation;

				[Token(Token = "0x6000B1D")]
				[Address(RVA = "0xA6D104", Offset = "0xA6D104", VA = "0xA6D104")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000B1E")]
				[Address(RVA = "0xA78B3C", Offset = "0xA78B3C", VA = "0xA78B3C")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000B1F")]
				[Address(RVA = "0xA6D890", Offset = "0xA6D890", VA = "0xA6D890")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000B20")]
				[Address(RVA = "0xA78DB4", Offset = "0xA78DB4", VA = "0xA78DB4")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000B21")]
				[Address(RVA = "0xA79A48", Offset = "0xA79A48", VA = "0xA79A48")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000B22")]
				[Address(RVA = "0xA6E028", Offset = "0xA6E028", VA = "0xA6E028")]
				public AdditionalColor()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000202")]
			public class UVDistortion
			{
				[Token(Token = "0x2000203")]
				private class IDs
				{
					[Token(Token = "0x4000E17")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int map;

					[Token(Token = "0x4000E18")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int mapTiling;

					[Token(Token = "0x4000E19")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int mapOffset;

					[Token(Token = "0x4000E1A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int mapScroll;

					[Token(Token = "0x4000E1B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int strength;

					[Token(Token = "0x6000B2C")]
					[Address(RVA = "0xA7B9F4", Offset = "0xA7B9F4", VA = "0xA7B9F4")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x2000204")]
				public enum Property
				{
					[Token(Token = "0x4000E1D")]
					Map,
					[Token(Token = "0x4000E1E")]
					MapTiling,
					[Token(Token = "0x4000E1F")]
					MapOffset,
					[Token(Token = "0x4000E20")]
					MapScroll,
					[Token(Token = "0x4000E21")]
					Strength
				}

				[Token(Token = "0x4000E11")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000E12")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Texture2D map;

				[Token(Token = "0x4000E13")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Vector2 mapTiling;

				[Token(Token = "0x4000E14")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector2 mapOffset;

				[Token(Token = "0x4000E15")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Vector2 mapScroll;

				[Token(Token = "0x4000E16")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public float strength;

				[Token(Token = "0x6000B25")]
				[Address(RVA = "0xA6D16C", Offset = "0xA6D16C", VA = "0xA6D16C")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000B26")]
				[Address(RVA = "0xA7ABF8", Offset = "0xA7ABF8", VA = "0xA7ABF8")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000B27")]
				[Address(RVA = "0xA6DB08", Offset = "0xA6DB08", VA = "0xA6DB08")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000B28")]
				[Address(RVA = "0xA7AD28", Offset = "0xA7AD28", VA = "0xA7AD28")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000B29")]
				[Address(RVA = "0xA7B298", Offset = "0xA7B298", VA = "0xA7B298")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0xA6E0CC", Offset = "0xA6E0CC", VA = "0xA6E0CC")]
				public UVDistortion()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000205")]
			public class GlobalIllumination
			{
				[Token(Token = "0x2000206")]
				private class IDs
				{
					[Token(Token = "0x4000E24")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int metaPassMultiplier;

					[Token(Token = "0x6000B34")]
					[Address(RVA = "0xA7BFA4", Offset = "0xA7BFA4", VA = "0xA7BFA4")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x4000E22")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000E23")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float metaPassMultiplier;

				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0xA6D1D4", Offset = "0xA6D1D4", VA = "0xA6D1D4")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000B2E")]
				[Address(RVA = "0xA7BB9C", Offset = "0xA7BB9C", VA = "0xA7BB9C")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0xA6DC38", Offset = "0xA6DC38", VA = "0xA6DC38")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000B30")]
				[Address(RVA = "0xA7BC0C", Offset = "0xA7BC0C", VA = "0xA7BC0C")]
				public static void UpdateLocalProperty(Material material, float value)
				{
				}

				[Token(Token = "0x6000B31")]
				[Address(RVA = "0xA7BCEC", Offset = "0xA7BCEC", VA = "0xA7BCEC")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, float value)
				{
				}

				[Token(Token = "0x6000B32")]
				[Address(RVA = "0xA6E15C", Offset = "0xA6E15C", VA = "0xA6E15C")]
				public GlobalIllumination()
				{
				}
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xA779EC", Offset = "0xA779EC", VA = "0xA779EC")]
			public Edge()
			{
			}
		}
	}
	[Token(Token = "0x2000207")]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class AdvancedDissolveSpotLightToConeSmooth : MonoBehaviour
	{
		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x4000E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float radiusOffset;

		[Token(Token = "0x4000E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Light spotLight;

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xA7C070", Offset = "0xA7C070", VA = "0xA7C070")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0xA7C0C8", Offset = "0xA7C0C8", VA = "0xA7C0C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0xA7C234", Offset = "0xA7C234", VA = "0xA7C234")]
		public AdvancedDissolveSpotLightToConeSmooth()
		{
		}
	}
	[Token(Token = "0x2000208")]
	[ExecuteAlways]
	public class AdvancedDissolveTransformScaleToRadius : MonoBehaviour
	{
		[Token(Token = "0x4000E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0xA7C23C", Offset = "0xA7C23C", VA = "0xA7C23C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0xA7C320", Offset = "0xA7C320", VA = "0xA7C320")]
		public AdvancedDissolveTransformScaleToRadius()
		{
		}
	}
}
namespace AmazingAssets.AdvancedDissolve.ExampleScripts
{
	[Token(Token = "0x2000209")]
	public class AnimateCutout : MonoBehaviour
	{
		[Token(Token = "0x4000E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material material;

		[Token(Token = "0x4000E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float offset;

		[Token(Token = "0x4000E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float speed;

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0xA7C328", Offset = "0xA7C328", VA = "0xA7C328")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0xA7C3C8", Offset = "0xA7C3C8", VA = "0xA7C3C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xA7C4C0", Offset = "0xA7C4C0", VA = "0xA7C4C0")]
		public AnimateCutout()
		{
		}
	}
	[Token(Token = "0x200020A")]
	public class AnimateGI : MonoBehaviour
	{
		[Token(Token = "0x4000E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer mRenderer;

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0xA7C4C8", Offset = "0xA7C4C8", VA = "0xA7C4C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0xA7C520", Offset = "0xA7C520", VA = "0xA7C520")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xA7C52C", Offset = "0xA7C52C", VA = "0xA7C52C")]
		public AnimateGI()
		{
		}
	}
	[Token(Token = "0x200020B")]
	public class CameraOrbitalMove : MonoBehaviour
	{
		[Token(Token = "0x4000E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float x;

		[Token(Token = "0x4000E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float y;

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xA7C534", Offset = "0xA7C534", VA = "0xA7C534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xA7C560", Offset = "0xA7C560", VA = "0xA7C560")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xA7C7F4", Offset = "0xA7C7F4", VA = "0xA7C7F4")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xA7C830", Offset = "0xA7C830", VA = "0xA7C830")]
		public CameraOrbitalMove()
		{
		}
	}
	[Token(Token = "0x200020C")]
	[RequireComponent(typeof(LineRenderer))]
	[ExecuteAlways]
	public class CapsuleFromLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x4000E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xA7C858", Offset = "0xA7C858", VA = "0xA7C858")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0xA7CA90", Offset = "0xA7CA90", VA = "0xA7CA90")]
		public CapsuleFromLineRenderer()
		{
		}
	}
}
namespace RengeGames.HealthBars
{
	[Token(Token = "0x200020D")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class CompoundHealthBar : MonoBehaviour, ISegmentedHealthBar
	{
		[Serializable]
		[Token(Token = "0x200020E")]
		private sealed class <>c
		{
			[Token(Token = "0x4000E48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000E49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, ISegmentedHealthBar, int> <>9__29_0;

			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0xA7DC64", Offset = "0xA7DC64", VA = "0xA7DC64")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0xA7DC6C", Offset = "0xA7DC6C", VA = "0xA7DC6C")]
			internal int <TotalSegmentCount>b__29_0(int sum, ISegmentedHealthBar next)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string oldParentName;

		[Token(Token = "0x4000E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string parentName;

		[Token(Token = "0x4000E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string oldHbName;

		[Token(Token = "0x4000E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string hbName;

		[Token(Token = "0x4000E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ISegmentedHealthBar> healthBars;

		[Token(Token = "0x4000E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool segmentsToggle;

		[Token(Token = "0x4000E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 1f)]
		private float value;

		[Token(Token = "0x4000E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int removedSegments;

		[Token(Token = "0x4000E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool fillFrontToBack;

		[Token(Token = "0x4000E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool useGradient;

		[Token(Token = "0x4000E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Gradient gradient;

		[Token(Token = "0x4000E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<string> healthBarNames;

		[Token(Token = "0x17000116")]
		public string ParentName
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xA7CA98", Offset = "0xA7CA98", VA = "0xA7CA98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xA7CAA0", Offset = "0xA7CAA0", VA = "0xA7CAA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public string Name
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xA7CB08", Offset = "0xA7CB08", VA = "0xA7CB08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xA7CB10", Offset = "0xA7CB10", VA = "0xA7CB10")]
			set
			{
			}
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0xA7CB78", Offset = "0xA7CB78", VA = "0xA7CB78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xA7CBA4", Offset = "0xA7CBA4", VA = "0xA7CBA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xA7D15C", Offset = "0xA7D15C", VA = "0xA7D15C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xA7CBA8", Offset = "0xA7CBA8", VA = "0xA7CBA8")]
		private void Populate()
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xA7D8E0", Offset = "0xA7D8E0", VA = "0xA7D8E0", Slot = "9")]
		public void AddRemovePercent(float value)
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xA7D904", Offset = "0xA7D904", VA = "0xA7D904", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xA7D90C", Offset = "0xA7D90C", VA = "0xA7D90C", Slot = "4")]
		public string GetParentName()
		{
			return null;
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xA7D38C", Offset = "0xA7D38C", VA = "0xA7D38C", Slot = "7")]
		public void SetPercent(float value)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xA7D914", Offset = "0xA7D914", VA = "0xA7D914", Slot = "10")]
		public void AddRemoveSegments(float value)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xA7D1A4", Offset = "0xA7D1A4", VA = "0xA7D1A4", Slot = "6")]
		public void SetRemovedSegments(float value)
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xA7D970", Offset = "0xA7D970", VA = "0xA7D970")]
		private float TotalSegmentCount()
		{
			return default(float);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xA7DA80", Offset = "0xA7DA80", VA = "0xA7DA80")]
		private float SegmentCount(ISegmentedHealthBar hb)
		{
			return default(float);
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xA7DB0C", Offset = "0xA7DB0C", VA = "0xA7DB0C", Slot = "11")]
		public bool SetShaderKeywordValue(string propertyName, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B57")]
		public bool SetShaderPropertyValue<T>(string propertyName, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xA7DB14", Offset = "0xA7DB14", VA = "0xA7DB14", Slot = "12")]
		public bool GetShaderKeyword(string propertyName, out ShaderKeyword shaderKeyword)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xA7DB34", Offset = "0xA7DB34", VA = "0xA7DB34", Slot = "13")]
		public bool GetShaderKeywordValue(string propertyName, out bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5A")]
		public bool GetShaderProperty<T>(string propertyName, out ShaderProperty<T> shaderProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5B")]
		public bool GetShaderPropertyValue<T>(string propertyName, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xA7DB40", Offset = "0xA7DB40", VA = "0xA7DB40")]
		public CompoundHealthBar()
		{
		}
	}
	[Token(Token = "0x200020F")]
	public interface ISegmentedHealthBar
	{
		[Token(Token = "0x6000B60")]
		string GetParentName();

		[Token(Token = "0x6000B61")]
		string GetName();

		[Token(Token = "0x6000B62")]
		void SetRemovedSegments(float value);

		[Token(Token = "0x6000B63")]
		void SetPercent(float value);

		[Token(Token = "0x6000B64")]
		bool SetShaderPropertyValue<T>(string propertyName, T value);
	}
	[Token(Token = "0x2000210")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class RadialSegmentedHealthBar : MonoBehaviour, ISegmentedHealthBar
	{
		[Token(Token = "0x4000E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string oldParentName;

		[Token(Token = "0x4000E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string parentName;

		[Token(Token = "0x4000E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string oldHbName;

		[Token(Token = "0x4000E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string hbName;

		[Token(Token = "0x4000E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool usingSpriteRenderer;

		[Token(Token = "0x4000E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool forceBuiltInShader;

		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ShaderPropertyColor <OverlayColor>k__BackingField;

		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ShaderPropertyColor <InnerColor>k__BackingField;

		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShaderPropertyColor <BorderColor>k__BackingField;

		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ShaderPropertyColor <EmptyColor>k__BackingField;

		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ShaderPropertyColor <SpaceColor>k__BackingField;

		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShaderPropertyFloat <SegmentCount>k__BackingField;

		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShaderPropertyFloat <RemoveSegments>k__BackingField;

		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShaderPropertyFloat <SegmentSpacing>k__BackingField;

		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ShaderPropertyFloat <Arc>k__BackingField;

		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ShaderPropertyFloat <Radius>k__BackingField;

		[Token(Token = "0x4000E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ShaderPropertyFloat <LineWidth>k__BackingField;

		[Token(Token = "0x4000E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ShaderPropertyFloat <Rotation>k__BackingField;

		[Token(Token = "0x4000E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ShaderPropertyVector2 <Offset>k__BackingField;

		[Token(Token = "0x4000E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShaderPropertyFloat <BorderWidth>k__BackingField;

		[Token(Token = "0x4000E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ShaderPropertyFloat <BorderSpacing>k__BackingField;

		[Token(Token = "0x4000E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ShaderPropertyFloat <RemoveBorder>k__BackingField;

		[Token(Token = "0x4000E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ShaderPropertyBool <OverlayNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayNoiseScale>k__BackingField;

		[Token(Token = "0x4000E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ShaderPropertyBool <EmptyNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyNoiseScale>k__BackingField;

		[Token(Token = "0x4000E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ShaderPropertyBool <ContentNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ShaderPropertyFloat <ContentNoiseScale>k__BackingField;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ShaderPropertyFloat <ContentNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ShaderPropertyVector2 <ContentNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ShaderPropertyBool <PulsateWhenLow>k__BackingField;

		[Token(Token = "0x4000E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private ShaderPropertyColor <PulseColor>k__BackingField;

		[Token(Token = "0x4000E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ShaderPropertyFloat <PulseSpeed>k__BackingField;

		[Token(Token = "0x4000E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private ShaderPropertyFloat <PulseActivationThreshold>k__BackingField;

		[Token(Token = "0x4000E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private ShaderKeyword <OverlayTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ShaderPropertyTexture2D <OverlayTexture>k__BackingField;

		[Token(Token = "0x4000E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayTextureTiling>k__BackingField;

		[Token(Token = "0x4000E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayTextureOffset>k__BackingField;

		[Token(Token = "0x4000E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private ShaderKeyword <InnerTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private ShaderPropertyTexture2D <InnerTexture>k__BackingField;

		[Token(Token = "0x4000E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private ShaderPropertyBool <AlignInnerTexture>k__BackingField;

		[Token(Token = "0x4000E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ShaderPropertyBool <InnerTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private ShaderPropertyFloat <InnerTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private ShaderPropertyVector2 <InnerTextureTiling>k__BackingField;

		[Token(Token = "0x4000E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private ShaderPropertyVector2 <InnerTextureOffset>k__BackingField;

		[Token(Token = "0x4000E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ShaderKeyword <BorderTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private ShaderPropertyTexture2D <BorderTexture>k__BackingField;

		[Token(Token = "0x4000E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private ShaderPropertyBool <AlignBorderTexture>k__BackingField;

		[Token(Token = "0x4000E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private ShaderPropertyBool <BorderTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private ShaderPropertyFloat <BorderTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ShaderPropertyVector2 <BorderTextureTiling>k__BackingField;

		[Token(Token = "0x4000E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private ShaderPropertyVector2 <BorderTextureOffset>k__BackingField;

		[Token(Token = "0x4000E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private ShaderKeyword <EmptyTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private ShaderPropertyTexture2D <EmptyTexture>k__BackingField;

		[Token(Token = "0x4000E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private ShaderPropertyBool <AlignEmptyTexture>k__BackingField;

		[Token(Token = "0x4000E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private ShaderPropertyBool <EmptyTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyTextureTiling>k__BackingField;

		[Token(Token = "0x4000E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyTextureOffset>k__BackingField;

		[Token(Token = "0x4000E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private ShaderKeyword <SpaceTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private ShaderPropertyTexture2D <SpaceTexture>k__BackingField;

		[Token(Token = "0x4000E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[SerializeField]
		private ShaderPropertyBool <AlignSpaceTexture>k__BackingField;

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private ShaderPropertyFloat <SpaceTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[SerializeField]
		private ShaderPropertyVector2 <SpaceTextureTiling>k__BackingField;

		[Token(Token = "0x4000E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private ShaderPropertyVector2 <SpaceTextureOffset>k__BackingField;

		[Token(Token = "0x4000E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[SerializeField]
		private ShaderPropertyGradient <InnerGradient>k__BackingField;

		[Token(Token = "0x4000E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[SerializeField]
		private ShaderPropertyBool <InnerGradientEnabled>k__BackingField;

		[Token(Token = "0x4000E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[SerializeField]
		private ShaderPropertyBool <ValueAsGradientTimeInner>k__BackingField;

		[Token(Token = "0x4000E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[SerializeField]
		private ShaderPropertyGradient <EmptyGradient>k__BackingField;

		[Token(Token = "0x4000E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[SerializeField]
		private ShaderPropertyBool <EmptyGradientEnabled>k__BackingField;

		[Token(Token = "0x4000E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		private ShaderPropertyBool <ValueAsGradientTimeEmpty>k__BackingField;

		[Token(Token = "0x4000E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[SerializeField]
		private ShaderPropertyAnimationCurve <VariableWidthCurve>k__BackingField;

		[Token(Token = "0x4000E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		private ShaderPropertyBool <FillClockwise>k__BackingField;

		[Token(Token = "0x4000E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Material currentMaterial;

		[Token(Token = "0x4000E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private SpriteRenderer spriteRenderer;

		[Token(Token = "0x4000E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Image image;

		[Token(Token = "0x4000E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool materialAssigned;

		[Token(Token = "0x4000E9C")]
		private const string MaterialName = "radialSegmentedHealthBarInstance";

		[Token(Token = "0x4000E9D")]
		private const string PlaceholderSpriteName = "rshb_placeholderSprite";

		[Token(Token = "0x4000E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private SortedDictionary<string, IShaderProperty> properties;

		[Token(Token = "0x17000118")]
		public string ParentName
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xA7DD18", Offset = "0xA7DD18", VA = "0xA7DD18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xA7D810", Offset = "0xA7D810", VA = "0xA7D810")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public string Name
		{
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xA7DD20", Offset = "0xA7DD20", VA = "0xA7DD20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xA7D878", Offset = "0xA7D878", VA = "0xA7D878")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public bool UsingSpriteRenderer
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xA7DD28", Offset = "0xA7DD28", VA = "0xA7DD28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0xA7DD30", Offset = "0xA7DD30", VA = "0xA7DD30")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool ForceBuiltInShader
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0xA7E148", Offset = "0xA7E148", VA = "0xA7E148")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0xA7E150", Offset = "0xA7E150", VA = "0xA7E150")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public ShaderPropertyColor OverlayColor
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0xA7E160", Offset = "0xA7E160", VA = "0xA7E160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xA7E168", Offset = "0xA7E168", VA = "0xA7E168")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public ShaderPropertyColor InnerColor
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xA7E170", Offset = "0xA7E170", VA = "0xA7E170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0xA7E178", Offset = "0xA7E178", VA = "0xA7E178")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public ShaderPropertyColor BorderColor
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0xA7E180", Offset = "0xA7E180", VA = "0xA7E180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0xA7E188", Offset = "0xA7E188", VA = "0xA7E188")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public ShaderPropertyColor EmptyColor
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0xA7E190", Offset = "0xA7E190", VA = "0xA7E190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0xA7E198", Offset = "0xA7E198", VA = "0xA7E198")]
			private set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public ShaderPropertyColor SpaceColor
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0xA7E1A0", Offset = "0xA7E1A0", VA = "0xA7E1A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0xA7E1A8", Offset = "0xA7E1A8", VA = "0xA7E1A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public ShaderPropertyFloat SegmentCount
		{
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0xA7E1B0", Offset = "0xA7E1B0", VA = "0xA7E1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0xA7E1B8", Offset = "0xA7E1B8", VA = "0xA7E1B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public ShaderPropertyFloat RemoveSegments
		{
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0xA7E1C0", Offset = "0xA7E1C0", VA = "0xA7E1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0xA7E1C8", Offset = "0xA7E1C8", VA = "0xA7E1C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public ShaderPropertyFloat SegmentSpacing
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0xA7E1D0", Offset = "0xA7E1D0", VA = "0xA7E1D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0xA7E1D8", Offset = "0xA7E1D8", VA = "0xA7E1D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public ShaderPropertyFloat Arc
		{
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0xA7E1E0", Offset = "0xA7E1E0", VA = "0xA7E1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0xA7E1E8", Offset = "0xA7E1E8", VA = "0xA7E1E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public ShaderPropertyFloat Radius
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0xA7E1F0", Offset = "0xA7E1F0", VA = "0xA7E1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0xA7E1F8", Offset = "0xA7E1F8", VA = "0xA7E1F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public ShaderPropertyFloat LineWidth
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0xA7E200", Offset = "0xA7E200", VA = "0xA7E200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0xA7E208", Offset = "0xA7E208", VA = "0xA7E208")]
			private set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public ShaderPropertyFloat Rotation
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0xA7E210", Offset = "0xA7E210", VA = "0xA7E210")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0xA7E218", Offset = "0xA7E218", VA = "0xA7E218")]
			private set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public ShaderPropertyVector2 Offset
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0xA7E220", Offset = "0xA7E220", VA = "0xA7E220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0xA7E228", Offset = "0xA7E228", VA = "0xA7E228")]
			private set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public ShaderPropertyFloat BorderWidth
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0xA7E230", Offset = "0xA7E230", VA = "0xA7E230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0xA7E238", Offset = "0xA7E238", VA = "0xA7E238")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public ShaderPropertyFloat BorderSpacing
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0xA7E240", Offset = "0xA7E240", VA = "0xA7E240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0xA7E248", Offset = "0xA7E248", VA = "0xA7E248")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public ShaderPropertyFloat RemoveBorder
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0xA7E250", Offset = "0xA7E250", VA = "0xA7E250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0xA7E258", Offset = "0xA7E258", VA = "0xA7E258")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public ShaderPropertyBool OverlayNoiseEnabled
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0xA7E260", Offset = "0xA7E260", VA = "0xA7E260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0xA7E268", Offset = "0xA7E268", VA = "0xA7E268")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public ShaderPropertyFloat OverlayNoiseScale
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0xA7E270", Offset = "0xA7E270", VA = "0xA7E270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0xA7E278", Offset = "0xA7E278", VA = "0xA7E278")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public ShaderPropertyFloat OverlayNoiseStrength
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0xA7E280", Offset = "0xA7E280", VA = "0xA7E280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0xA7E288", Offset = "0xA7E288", VA = "0xA7E288")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public ShaderPropertyVector2 OverlayNoiseOffset
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0xA7E290", Offset = "0xA7E290", VA = "0xA7E290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0xA7E298", Offset = "0xA7E298", VA = "0xA7E298")]
			private set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public ShaderPropertyBool EmptyNoiseEnabled
		{
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0xA7E2A0", Offset = "0xA7E2A0", VA = "0xA7E2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0xA7E2A8", Offset = "0xA7E2A8", VA = "0xA7E2A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public ShaderPropertyFloat EmptyNoiseScale
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0xA7E2B0", Offset = "0xA7E2B0", VA = "0xA7E2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0xA7E2B8", Offset = "0xA7E2B8", VA = "0xA7E2B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public ShaderPropertyFloat EmptyNoiseStrength
		{
			[Token(Token = "0x6000B99")]
			[Address(RVA = "0xA7E2C0", Offset = "0xA7E2C0", VA = "0xA7E2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0xA7E2C8", Offset = "0xA7E2C8", VA = "0xA7E2C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public ShaderPropertyVector2 EmptyNoiseOffset
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0xA7E2D0", Offset = "0xA7E2D0", VA = "0xA7E2D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0xA7E2D8", Offset = "0xA7E2D8", VA = "0xA7E2D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public ShaderPropertyBool ContentNoiseEnabled
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0xA7E2E0", Offset = "0xA7E2E0", VA = "0xA7E2E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0xA7E2E8", Offset = "0xA7E2E8", VA = "0xA7E2E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public ShaderPropertyFloat ContentNoiseScale
		{
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0xA7E2F8", Offset = "0xA7E2F8", VA = "0xA7E2F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0xA7E300", Offset = "0xA7E300", VA = "0xA7E300")]
			private set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public ShaderPropertyFloat ContentNoiseStrength
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0xA7E310", Offset = "0xA7E310", VA = "0xA7E310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0xA7E318", Offset = "0xA7E318", VA = "0xA7E318")]
			private set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public ShaderPropertyVector2 ContentNoiseOffset
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0xA7E328", Offset = "0xA7E328", VA = "0xA7E328")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0xA7E330", Offset = "0xA7E330", VA = "0xA7E330")]
			private set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public ShaderPropertyBool PulsateWhenLow
		{
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0xA7E340", Offset = "0xA7E340", VA = "0xA7E340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0xA7E348", Offset = "0xA7E348", VA = "0xA7E348")]
			private set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public ShaderPropertyColor PulseColor
		{
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0xA7E358", Offset = "0xA7E358", VA = "0xA7E358")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0xA7E360", Offset = "0xA7E360", VA = "0xA7E360")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public ShaderPropertyFloat PulseSpeed
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0xA7E370", Offset = "0xA7E370", VA = "0xA7E370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0xA7E378", Offset = "0xA7E378", VA = "0xA7E378")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public ShaderPropertyFloat PulseActivationThreshold
		{
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0xA7E388", Offset = "0xA7E388", VA = "0xA7E388")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xA7E390", Offset = "0xA7E390", VA = "0xA7E390")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public ShaderKeyword OverlayTextureEnabled
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0xA7E3A0", Offset = "0xA7E3A0", VA = "0xA7E3A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0xA7E3A8", Offset = "0xA7E3A8", VA = "0xA7E3A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public ShaderPropertyTexture2D OverlayTexture
		{
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0xA7E3B8", Offset = "0xA7E3B8", VA = "0xA7E3B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xA7E3C0", Offset = "0xA7E3C0", VA = "0xA7E3C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public ShaderPropertyFloat OverlayTextureOpacity
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0xA7E3D0", Offset = "0xA7E3D0", VA = "0xA7E3D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0xA7E3D8", Offset = "0xA7E3D8", VA = "0xA7E3D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public ShaderPropertyVector2 OverlayTextureTiling
		{
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0xA7E3E8", Offset = "0xA7E3E8", VA = "0xA7E3E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0xA7E3F0", Offset = "0xA7E3F0", VA = "0xA7E3F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public ShaderPropertyVector2 OverlayTextureOffset
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0xA7E400", Offset = "0xA7E400", VA = "0xA7E400")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0xA7E408", Offset = "0xA7E408", VA = "0xA7E408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public ShaderKeyword InnerTextureEnabled
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xA7E418", Offset = "0xA7E418", VA = "0xA7E418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0xA7E420", Offset = "0xA7E420", VA = "0xA7E420")]
			private set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public ShaderPropertyTexture2D InnerTexture
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0xA7E430", Offset = "0xA7E430", VA = "0xA7E430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0xA7E438", Offset = "0xA7E438", VA = "0xA7E438")]
			private set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public ShaderPropertyBool AlignInnerTexture
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0xA7E448", Offset = "0xA7E448", VA = "0xA7E448")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0xA7E450", Offset = "0xA7E450", VA = "0xA7E450")]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public ShaderPropertyBool InnerTextureScaleWithSegments
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0xA7E460", Offset = "0xA7E460", VA = "0xA7E460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0xA7E468", Offset = "0xA7E468", VA = "0xA7E468")]
			private set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public ShaderPropertyFloat InnerTextureOpacity
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0xA7E478", Offset = "0xA7E478", VA = "0xA7E478")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0xA7E480", Offset = "0xA7E480", VA = "0xA7E480")]
			private set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public ShaderPropertyVector2 InnerTextureTiling
		{
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0xA7E490", Offset = "0xA7E490", VA = "0xA7E490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0xA7E498", Offset = "0xA7E498", VA = "0xA7E498")]
			private set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public ShaderPropertyVector2 InnerTextureOffset
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0xA7E4A8", Offset = "0xA7E4A8", VA = "0xA7E4A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0xA7E4B0", Offset = "0xA7E4B0", VA = "0xA7E4B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public ShaderKeyword BorderTextureEnabled
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0xA7E4C0", Offset = "0xA7E4C0", VA = "0xA7E4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0xA7E4C8", Offset = "0xA7E4C8", VA = "0xA7E4C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public ShaderPropertyTexture2D BorderTexture
		{
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0xA7E4D8", Offset = "0xA7E4D8", VA = "0xA7E4D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0xA7E4E0", Offset = "0xA7E4E0", VA = "0xA7E4E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public ShaderPropertyBool AlignBorderTexture
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0xA7E4F0", Offset = "0xA7E4F0", VA = "0xA7E4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0xA7E4F8", Offset = "0xA7E4F8", VA = "0xA7E4F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public ShaderPropertyBool BorderTextureScaleWithSegments
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0xA7E508", Offset = "0xA7E508", VA = "0xA7E508")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0xA7E510", Offset = "0xA7E510", VA = "0xA7E510")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public ShaderPropertyFloat BorderTextureOpacity
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0xA7E520", Offset = "0xA7E520", VA = "0xA7E520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0xA7E528", Offset = "0xA7E528", VA = "0xA7E528")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public ShaderPropertyVector2 BorderTextureTiling
		{
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0xA7E538", Offset = "0xA7E538", VA = "0xA7E538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0xA7E540", Offset = "0xA7E540", VA = "0xA7E540")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public ShaderPropertyVector2 BorderTextureOffset
		{
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0xA7E550", Offset = "0xA7E550", VA = "0xA7E550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0xA7E558", Offset = "0xA7E558", VA = "0xA7E558")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public ShaderKeyword EmptyTextureEnabled
		{
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0xA7E568", Offset = "0xA7E568", VA = "0xA7E568")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0xA7E570", Offset = "0xA7E570", VA = "0xA7E570")]
			private set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public ShaderPropertyTexture2D EmptyTexture
		{
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0xA7E580", Offset = "0xA7E580", VA = "0xA7E580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0xA7E588", Offset = "0xA7E588", VA = "0xA7E588")]
			private set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public ShaderPropertyBool AlignEmptyTexture
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0xA7E598", Offset = "0xA7E598", VA = "0xA7E598")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0xA7E5A0", Offset = "0xA7E5A0", VA = "0xA7E5A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public ShaderPropertyBool EmptyTextureScaleWithSegments
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0xA7E5B0", Offset = "0xA7E5B0", VA = "0xA7E5B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0xA7E5B8", Offset = "0xA7E5B8", VA = "0xA7E5B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public ShaderPropertyFloat EmptyTextureOpacity
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0xA7E5C8", Offset = "0xA7E5C8", VA = "0xA7E5C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0xA7E5D0", Offset = "0xA7E5D0", VA = "0xA7E5D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public ShaderPropertyVector2 EmptyTextureTiling
		{
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0xA7E5E0", Offset = "0xA7E5E0", VA = "0xA7E5E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0xA7E5E8", Offset = "0xA7E5E8", VA = "0xA7E5E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public ShaderPropertyVector2 EmptyTextureOffset
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0xA7E5F8", Offset = "0xA7E5F8", VA = "0xA7E5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0xA7E600", Offset = "0xA7E600", VA = "0xA7E600")]
			private set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public ShaderKeyword SpaceTextureEnabled
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0xA7E610", Offset = "0xA7E610", VA = "0xA7E610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0xA7E618", Offset = "0xA7E618", VA = "0xA7E618")]
			private set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public ShaderPropertyTexture2D SpaceTexture
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0xA7E628", Offset = "0xA7E628", VA = "0xA7E628")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0xA7E630", Offset = "0xA7E630", VA = "0xA7E630")]
			private set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public ShaderPropertyBool AlignSpaceTexture
		{
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0xA7E640", Offset = "0xA7E640", VA = "0xA7E640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0xA7E648", Offset = "0xA7E648", VA = "0xA7E648")]
			private set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public ShaderPropertyFloat SpaceTextureOpacity
		{
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0xA7E658", Offset = "0xA7E658", VA = "0xA7E658")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0xA7E660", Offset = "0xA7E660", VA = "0xA7E660")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public ShaderPropertyVector2 SpaceTextureTiling
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0xA7E670", Offset = "0xA7E670", VA = "0xA7E670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0xA7E678", Offset = "0xA7E678", VA = "0xA7E678")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public ShaderPropertyVector2 SpaceTextureOffset
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0xA7E688", Offset = "0xA7E688", VA = "0xA7E688")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0xA7E690", Offset = "0xA7E690", VA = "0xA7E690")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public ShaderPropertyGradient InnerGradient
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0xA7E6A0", Offset = "0xA7E6A0", VA = "0xA7E6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0xA7E6A8", Offset = "0xA7E6A8", VA = "0xA7E6A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public ShaderPropertyBool InnerGradientEnabled
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0xA7E6B8", Offset = "0xA7E6B8", VA = "0xA7E6B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0xA7E6C0", Offset = "0xA7E6C0", VA = "0xA7E6C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public ShaderPropertyBool ValueAsGradientTimeInner
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0xA7E6D0", Offset = "0xA7E6D0", VA = "0xA7E6D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0xA7E6D8", Offset = "0xA7E6D8", VA = "0xA7E6D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public ShaderPropertyGradient EmptyGradient
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0xA7E6E8", Offset = "0xA7E6E8", VA = "0xA7E6E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0xA7E6F0", Offset = "0xA7E6F0", VA = "0xA7E6F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public ShaderPropertyBool EmptyGradientEnabled
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0xA7E700", Offset = "0xA7E700", VA = "0xA7E700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0xA7E708", Offset = "0xA7E708", VA = "0xA7E708")]
			private set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public ShaderPropertyBool ValueAsGradientTimeEmpty
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0xA7E718", Offset = "0xA7E718", VA = "0xA7E718")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0xA7E720", Offset = "0xA7E720", VA = "0xA7E720")]
			private set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public ShaderPropertyAnimationCurve VariableWidthCurve
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0xA7E730", Offset = "0xA7E730", VA = "0xA7E730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0xA7E738", Offset = "0xA7E738", VA = "0xA7E738")]
			private set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public ShaderPropertyBool FillClockwise
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0xA7E748", Offset = "0xA7E748", VA = "0xA7E748")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0xA7E750", Offset = "0xA7E750", VA = "0xA7E750")]
			private set
			{
			}
		}

		[Token(Token = "0x17000164")]
		private Material ActiveMaterial
		{
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0xA7E760", Offset = "0xA7E760", VA = "0xA7E760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		private string BaseMaterialName
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0xA7E798", Offset = "0xA7E798", VA = "0xA7E798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0xA7E884", Offset = "0xA7E884", VA = "0xA7E884")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0xA82214", Offset = "0xA82214", VA = "0xA82214")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0xA8261C", Offset = "0xA8261C", VA = "0xA8261C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0xA7DD40", Offset = "0xA7DD40", VA = "0xA7DD40")]
		private void GenerateRequiredComponents(bool useExisting)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0xA7E8BC", Offset = "0xA7E8BC", VA = "0xA7E8BC")]
		private void InitProperties()
		{
		}

		[Token(Token = "0x6000C04")]
		public bool GetShaderProperty<T>(string propertyName, out ShaderProperty<T> shaderProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0xA82AC8", Offset = "0xA82AC8", VA = "0xA82AC8", Slot = "10")]
		public bool GetShaderKeyword(string propertyName, out ShaderKeyword shaderKeyword)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C06")]
		public bool GetShaderPropertyValue<T>(string propertyName, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C07")]
		public bool SetShaderPropertyValue<T>(string propertyName, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xA82BA0", Offset = "0xA82BA0", VA = "0xA82BA0", Slot = "12")]
		public bool GetShaderKeywordValue(string propertyName, out bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xA82C6C", Offset = "0xA82C6C", VA = "0xA82C6C", Slot = "13")]
		public bool SetShaderKeywordValue(string propertyName, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xA82D38", Offset = "0xA82D38", VA = "0xA82D38")]
		private bool BoolPropertyFunc(int id, bool setInShader, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xA82E20", Offset = "0xA82E20", VA = "0xA82E20")]
		private float FloatPropertyFunc(int id, bool setInShader, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0xA82E8C", Offset = "0xA82E8C", VA = "0xA82E8C")]
		private Color ColorPropertyFunc(int id, bool setInShader, Color value)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0xA82F30", Offset = "0xA82F30", VA = "0xA82F30")]
		private Vector2 VectorPropertyFunc(int id, bool setInShader, Vector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0xA82FC4", Offset = "0xA82FC4", VA = "0xA82FC4")]
		private Texture2D TexturePropertyFunc(int id, bool setInShader, Texture2D value)
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0xA83080", Offset = "0xA83080", VA = "0xA83080")]
		private Gradient GradientPropertyFunc(int id, bool setInShader, Gradient value)
		{
			return null;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0xA830F0", Offset = "0xA830F0", VA = "0xA830F0")]
		private AnimationCurve CurvePropertyFunc(int id, bool setInShader, AnimationCurve value)
		{
			return null;
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0xA83160", Offset = "0xA83160", VA = "0xA83160")]
		private bool KeywordFunc(string id, bool setInShader, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0xA82684", Offset = "0xA82684", VA = "0xA82684")]
		private void AssignMaterial(Image r)
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0xA82848", Offset = "0xA82848", VA = "0xA82848")]
		private void AssignMaterial(SpriteRenderer r)
		{
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0xA82434", Offset = "0xA82434", VA = "0xA82434")]
		private void ApplyToShader(bool ignoreDirty)
		{
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0xA831E0", Offset = "0xA831E0", VA = "0xA831E0")]
		private void ResetPublicFields()
		{
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0xA833C8", Offset = "0xA833C8", VA = "0xA833C8")]
		public void ResetPropertiesToDefault()
		{
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0xA835C8", Offset = "0xA835C8", VA = "0xA835C8", Slot = "14")]
		public void SetSegmentCount(float value)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0xA8362C", Offset = "0xA8362C", VA = "0xA8362C", Slot = "6")]
		public void SetRemovedSegments(float value)
		{
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0xA836B4", Offset = "0xA836B4", VA = "0xA836B4", Slot = "7")]
		public void SetPercent(float value)
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0xA83740", Offset = "0xA83740", VA = "0xA83740", Slot = "15")]
		public void AddRemoveSegments(float value)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0xA837E4", Offset = "0xA837E4", VA = "0xA837E4", Slot = "16")]
		public void AddRemovePercent(float value)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0xA83898", Offset = "0xA83898", VA = "0xA83898", Slot = "4")]
		public string GetParentName()
		{
			return null;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0xA838A0", Offset = "0xA838A0", VA = "0xA838A0", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0xA838A8", Offset = "0xA838A8", VA = "0xA838A8")]
		public RadialSegmentedHealthBar()
		{
		}
	}
	[Token(Token = "0x2000211")]
	public interface IShaderProperty
	{
		[Token(Token = "0x6000C1F")]
		void Reset();

		[Token(Token = "0x6000C20")]
		void ResetToDefault();

		[Token(Token = "0x6000C21")]
		bool ApplyToShader(bool ignoreDirty);
	}
	[Serializable]
	[Token(Token = "0x2000212")]
	public class ShaderKeyword : IShaderProperty
	{
		[Token(Token = "0x4000E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _value;

		[Token(Token = "0x4000EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool <IsDirty>k__BackingField;

		[Token(Token = "0x4000EA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _keywordId;

		[Token(Token = "0x4000EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<string, bool, bool, bool> _keywordFunc;

		[Token(Token = "0x4000EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _defaultValue;

		[Token(Token = "0x17000166")]
		public bool Value
		{
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x9DBF44", Offset = "0x9DBF44", VA = "0x9DBF44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x9DBF4C", Offset = "0x9DBF4C", VA = "0x9DBF4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public bool IsDirty
		{
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x9DBF60", Offset = "0x9DBF60", VA = "0x9DBF60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x9DBF68", Offset = "0x9DBF68", VA = "0x9DBF68")]
			set
			{
			}
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x9DBF74", Offset = "0x9DBF74", VA = "0x9DBF74")]
		public ShaderKeyword(string keywordId, Func<string, bool, bool, bool> keywordFunc, bool value = false, [Optional] ShaderKeyword ancestor)
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x9DBFE4", Offset = "0x9DBFE4", VA = "0x9DBFE4", Slot = "4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x9DC024", Offset = "0x9DC024", VA = "0x9DC024", Slot = "5")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x9DC038", Offset = "0x9DC038", VA = "0x9DC038", Slot = "6")]
		public bool ApplyToShader(bool ignoreDirty)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000213")]
	public class ShaderProperty<T> : IShaderProperty
	{
		[Token(Token = "0x4000EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected T _value;

		[Token(Token = "0x4000EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool <IsDirty>k__BackingField;

		[Token(Token = "0x4000EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly int _propertyId;

		[Token(Token = "0x4000EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Func<int, bool, T, T> _propertyFunc;

		[Token(Token = "0x4000EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T _defaultValue;

		[Token(Token = "0x17000168")]
		public T Value
		{
			[Token(Token = "0x6000C2A")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000C2B")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public bool IsDirty
		{
			[Token(Token = "0x6000C2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C2D")]
			set
			{
			}
		}

		[Token(Token = "0x6000C2E")]
		public ShaderProperty(string propertyName, Func<int, bool, T, T> propertyFunc, [Optional] T value, [Optional] ShaderProperty<T> ancestor)
		{
		}

		[Token(Token = "0x6000C2F")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000C30")]
		public virtual void ResetToDefault()
		{
		}

		[Token(Token = "0x6000C31")]
		public bool ApplyToShader(bool ignoreDirty)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000214")]
	public class ShaderPropertyFloat : ShaderProperty<float>
	{
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x9DC098", Offset = "0x9DC098", VA = "0x9DC098")]
		public ShaderPropertyFloat(string propertyName, Func<int, bool, float, float> propertyFunc, float value = 0f, [Optional] ShaderPropertyFloat ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000215")]
	public class ShaderPropertyBool : ShaderProperty<bool>
	{
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x9DC118", Offset = "0x9DC118", VA = "0x9DC118")]
		public ShaderPropertyBool(string propertyName, Func<int, bool, bool, bool> propertyFunc, bool value = false, [Optional] ShaderPropertyBool ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000216")]
	public class ShaderPropertyVector2 : ShaderProperty<Vector2>
	{
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x9DC190", Offset = "0x9DC190", VA = "0x9DC190")]
		public ShaderPropertyVector2(string propertyName, Func<int, bool, Vector2, Vector2> propertyFunc, [Optional] Vector2 value, [Optional] ShaderPropertyVector2 ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000217")]
	public class ShaderPropertyColor : ShaderProperty<Color>
	{
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x9DC218", Offset = "0x9DC218", VA = "0x9DC218")]
		public ShaderPropertyColor(string propertyName, Func<int, bool, Color, Color> propertyFunc, [Optional] Color value, [Optional] ShaderPropertyColor ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000218")]
	public class ShaderPropertyTexture2D : ShaderProperty<Texture2D>
	{
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x9DC2B8", Offset = "0x9DC2B8", VA = "0x9DC2B8")]
		public ShaderPropertyTexture2D(string propertyName, Func<int, bool, Texture2D, Texture2D> propertyFunc, [Optional] Texture2D value, [Optional] ShaderPropertyTexture2D ancestor)
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x9DC364", Offset = "0x9DC364", VA = "0x9DC364", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000219")]
	public class ShaderPropertyGradient : ShaderProperty<Gradient>
	{
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x9DC368", Offset = "0x9DC368", VA = "0x9DC368")]
		public ShaderPropertyGradient(string propertyName, Func<int, bool, Gradient, Gradient> propertyFunc, [Optional] Gradient value, [Optional] ShaderPropertyGradient ancestor)
		{
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x9DC58C", Offset = "0x9DC58C", VA = "0x9DC58C", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200021A")]
	public class ShaderPropertyAnimationCurve : ShaderProperty<AnimationCurve>
	{
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x9DC590", Offset = "0x9DC590", VA = "0x9DC590")]
		public ShaderPropertyAnimationCurve(string propertyName, Func<int, bool, AnimationCurve, AnimationCurve> propertyFunc, [Optional] AnimationCurve value, [Optional] ShaderPropertyAnimationCurve ancestor)
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x9DC744", Offset = "0x9DC744", VA = "0x9DC744", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Token(Token = "0x200021B")]
	public class StatusBarsManager
	{
		[Token(Token = "0x200021C")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000EAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float value;

			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x9DD3EC", Offset = "0x9DD3EC", VA = "0x9DD3EC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x9DD3F4", Offset = "0x9DD3F4", VA = "0x9DD3F4")]
			internal void <SetPercent>b__0(ISegmentedHealthBar hb)
			{
			}
		}

		[Token(Token = "0x200021D")]
		private sealed class <>c__DisplayClass29_0<T>
		{
			[Token(Token = "0x4000EAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string propertyName;

			[Token(Token = "0x4000EAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T value;

			[Token(Token = "0x6000C44")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000C45")]
			internal void <SetShaderPropertyValue>b__0(ISegmentedHealthBar hb)
			{
			}
		}

		[Token(Token = "0x4000EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StatusBarsManager _instance;

		[Token(Token = "0x4000EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool enabled;

		[Token(Token = "0x4000EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, Dictionary<string, List<ISegmentedHealthBar>>> _healthBars;

		[Token(Token = "0x1700016A")]
		private static StatusBarsManager InternalInstance
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x9DC798", Offset = "0x9DC798", VA = "0x9DC798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x9DC818", Offset = "0x9DC818", VA = "0x9DC818")]
		private StatusBarsManager()
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x9DC8A8", Offset = "0x9DC8A8", VA = "0x9DC8A8")]
		public static void AddHealthBar(ISegmentedHealthBar healthBar)
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x9DCE7C", Offset = "0x9DCE7C", VA = "0x9DCE7C")]
		public static void RemoveHealthBar(ISegmentedHealthBar healthBar, bool removeAll)
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x9DD27C", Offset = "0x9DD27C", VA = "0x9DD27C")]
		public static void SetPercent(string parentName, string healthBarName, float value)
		{
		}

		[Token(Token = "0x6000C41")]
		public static bool SetShaderPropertyValue<T>(string parentName, string healthBarName, string propertyName, T value)
		{
			return default(bool);
		}
	}
}
namespace RengeGames.HealthBars.Extensions
{
	[Token(Token = "0x200021E")]
	public static class UCHBExtensions
	{
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x9DD4A8", Offset = "0x9DD4A8", VA = "0x9DD4A8")]
		public static Texture2D ToTexture2D(this AnimationCurve curve, int width = 500, int height = 1)
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x9DD5E4", Offset = "0x9DD5E4", VA = "0x9DD5E4")]
		public static Texture2D ToTexture2D(this Gradient gradient, int width = 250, int height = 1)
		{
			return null;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x9DC43C", Offset = "0x9DC43C", VA = "0x9DC43C")]
		public static Gradient Clone(this Gradient gradient)
		{
			return null;
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x9DC67C", Offset = "0x9DC67C", VA = "0x9DC67C")]
		public static AnimationCurve Clone(this AnimationCurve curve)
		{
			return null;
		}
	}
}
namespace RengeGames.HealthBars.Demo
{
	[Token(Token = "0x200021F")]
	public class DemoHealthController : MonoBehaviour
	{
		[Token(Token = "0x4000EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string parentName;

		[Token(Token = "0x4000EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string healthBarName;

		[Token(Token = "0x4000EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool updateFromScript;

		[Token(Token = "0x4000EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RadialSegmentedHealthBar exampleHealthBar;

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x9DD760", Offset = "0x9DD760", VA = "0x9DD760")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x9DD7C8", Offset = "0x9DD7C8", VA = "0x9DD7C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x9DD7E4", Offset = "0x9DD7E4", VA = "0x9DD7E4")]
		public void SetHealthPercent(float value)
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x9DD84C", Offset = "0x9DD84C", VA = "0x9DD84C")]
		public void ToggleNoise(bool toggle)
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x9DD8BC", Offset = "0x9DD8BC", VA = "0x9DD8BC")]
		public void Instantiate()
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x9DDB3C", Offset = "0x9DDB3C", VA = "0x9DDB3C")]
		public DemoHealthController()
		{
		}
	}
}
namespace SciFiArsenal
{
	[Token(Token = "0x2000220")]
	public class SciFiBeamScript : MonoBehaviour
	{
		[Token(Token = "0x4000EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] beamLineRendererPrefab;

		[Token(Token = "0x4000EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] beamStartPrefab;

		[Token(Token = "0x4000EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] beamEndPrefab;

		[Token(Token = "0x4000EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentBeam;

		[Token(Token = "0x4000EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject beamStart;

		[Token(Token = "0x4000EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject beamEnd;

		[Token(Token = "0x4000EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject beam;

		[Token(Token = "0x4000EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LineRenderer line;

		[Token(Token = "0x4000EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float beamEndOffset;

		[Token(Token = "0x4000EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float textureScrollSpeed;

		[Token(Token = "0x4000EBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float textureLengthScale;

		[Token(Token = "0x4000EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Slider endOffSetSlider;

		[Token(Token = "0x4000EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Slider scrollSpeedSlider;

		[Token(Token = "0x4000EC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text textBeamName;

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x9DDBD0", Offset = "0x9DDBD0", VA = "0x9DDBD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x9DDD10", Offset = "0x9DDD10", VA = "0x9DDD10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x9DE56C", Offset = "0x9DE56C", VA = "0x9DE56C")]
		public void nextBeam()
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x9DE64C", Offset = "0x9DE64C", VA = "0x9DE64C")]
		public void previousBeam()
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x9DE72C", Offset = "0x9DE72C", VA = "0x9DE72C")]
		public void UpdateEndOffset()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x9DE75C", Offset = "0x9DE75C", VA = "0x9DE75C")]
		public void UpdateScrollSpeed()
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x9DE148", Offset = "0x9DE148", VA = "0x9DE148")]
		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x9DE78C", Offset = "0x9DE78C", VA = "0x9DE78C")]
		public SciFiBeamScript()
		{
		}
	}
	[Token(Token = "0x2000221")]
	public class SciFiButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4000EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x4000EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x4000EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x4000EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiFireProjectile effectScript;

		[Token(Token = "0x4000EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SciFiProjectileScript projectileScript;

		[Token(Token = "0x4000EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x9DE7A8", Offset = "0x9DE7A8", VA = "0x9DE7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x9DE964", Offset = "0x9DE964", VA = "0x9DE964")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x9DE8B0", Offset = "0x9DE8B0", VA = "0x9DE8B0")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x9DE990", Offset = "0x9DE990", VA = "0x9DE990")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x9DEA68", Offset = "0x9DEA68", VA = "0x9DEA68")]
		public SciFiButtonScript()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public class SciFiDragMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x4000ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x4000ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x9DEA70", Offset = "0x9DEA70", VA = "0x9DEA70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x9DEB3C", Offset = "0x9DEB3C", VA = "0x9DEB3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x9DEEB8", Offset = "0x9DEEB8", VA = "0x9DEEB8")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x9DEEF4", Offset = "0x9DEEF4", VA = "0x9DEEF4")]
		public SciFiDragMouseOrbit()
		{
		}
	}
	[Token(Token = "0x2000223")]
	public class SciFiFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public GameObject[] projectiles;

		[Token(Token = "0x4000EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform spawnPosition;

		[Token(Token = "0x4000EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int currentProjectile;

		[Token(Token = "0x4000EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float speed;

		[Token(Token = "0x4000EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiButtonScript selectedProjectileButton;

		[Token(Token = "0x4000EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hit;

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x9DEF10", Offset = "0x9DEF10", VA = "0x9DEF10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x9DEF8C", Offset = "0x9DEF8C", VA = "0x9DEF8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x9DF35C", Offset = "0x9DF35C", VA = "0x9DF35C")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x9DF398", Offset = "0x9DF398", VA = "0x9DF398")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x9DF3D4", Offset = "0x9DF3D4", VA = "0x9DF3D4")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x9DF3DC", Offset = "0x9DF3DC", VA = "0x9DF3DC")]
		public SciFiFireProjectile()
		{
		}
	}
	[Token(Token = "0x2000224")]
	public class SciFiLoadSceneOnClick : MonoBehaviour
	{
		[Token(Token = "0x4000EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool GUIHide;

		[Token(Token = "0x4000EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool GUIHide2;

		[Token(Token = "0x4000EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GUIHide3;

		[Token(Token = "0x4000EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool GUIHide4;

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x9DF3EC", Offset = "0x9DF3EC", VA = "0x9DF3EC")]
		public void LoadSceneSciFiProjectiles()
		{
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x9DF454", Offset = "0x9DF454", VA = "0x9DF454")]
		public void LoadSceneSciFiBeamup()
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x9DF4BC", Offset = "0x9DF4BC", VA = "0x9DF4BC")]
		public void LoadSceneSciFiBuff()
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x9DF524", Offset = "0x9DF524", VA = "0x9DF524")]
		public void LoadSceneSciFiFlamethrowers2()
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x9DF58C", Offset = "0x9DF58C", VA = "0x9DF58C")]
		public void LoadSceneSciFiQuestZone()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x9DF5F4", Offset = "0x9DF5F4", VA = "0x9DF5F4")]
		public void LoadSceneSciFiLightjump()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x9DF65C", Offset = "0x9DF65C", VA = "0x9DF65C")]
		public void LoadSceneSciFiLoot()
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x9DF6C4", Offset = "0x9DF6C4", VA = "0x9DF6C4")]
		public void LoadSceneSciFiBeams()
		{
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x9DF72C", Offset = "0x9DF72C", VA = "0x9DF72C")]
		public void LoadSceneSciFiPortals()
		{
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x9DF794", Offset = "0x9DF794", VA = "0x9DF794")]
		public void LoadSceneSciFiRegenerate()
		{
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x9DF7FC", Offset = "0x9DF7FC", VA = "0x9DF7FC")]
		public void LoadSceneSciFiShields()
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x9DF864", Offset = "0x9DF864", VA = "0x9DF864")]
		public void LoadSceneSciFiSwirlyAura()
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x9DF8CC", Offset = "0x9DF8CC", VA = "0x9DF8CC")]
		public void LoadSceneSciFiWarpgates()
		{
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x9DF934", Offset = "0x9DF934", VA = "0x9DF934")]
		public void LoadSceneSciFiJetflame()
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x9DF99C", Offset = "0x9DF99C", VA = "0x9DF99C")]
		public void LoadSceneSciFiUltimateNova()
		{
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x9DFA04", Offset = "0x9DFA04", VA = "0x9DFA04")]
		public void LoadSceneSciFiFire()
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x9DFA6C", Offset = "0x9DFA6C", VA = "0x9DFA6C")]
		public void LoadSceneSciFiUpdate6()
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x9DFAD4", Offset = "0x9DFAD4", VA = "0x9DFAD4")]
		public void LoadSceneSciFiUpdate7()
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x9DFB3C", Offset = "0x9DFB3C", VA = "0x9DFB3C")]
		public void LoadSceneSciFiUpdate8()
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x9DFBA4", Offset = "0x9DFBA4", VA = "0x9DFBA4")]
		public void LoadSceneSciFiUpdate9()
		{
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x9DFC0C", Offset = "0x9DFC0C", VA = "0x9DFC0C")]
		public void LoadSceneSciFiUpdate10()
		{
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x9DFC74", Offset = "0x9DFC74", VA = "0x9DFC74")]
		public void LoadSceneSciFiUpdate11()
		{
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x9DFCDC", Offset = "0x9DFCDC", VA = "0x9DFCDC")]
		public void LoadSceneSciFiUpdate12()
		{
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x9DFD44", Offset = "0x9DFD44", VA = "0x9DFD44")]
		public void LoadSceneSciFiBlood()
		{
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x9DFDAC", Offset = "0x9DFDAC", VA = "0x9DFDAC")]
		public void LoadSceneSciFiRoundZone()
		{
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x9DFE14", Offset = "0x9DFE14", VA = "0x9DFE14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x9DFFD4", Offset = "0x9DFFD4", VA = "0x9DFFD4")]
		public SciFiLoadSceneOnClick()
		{
		}
	}
	[Token(Token = "0x2000225")]
	public class SciFiLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000226")]
		private sealed class <EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000EE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000EE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SciFiLoopScript <>4__this;

			[Token(Token = "0x4000EE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x1700016B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C89")]
				[Address(RVA = "0x9E02A4", Offset = "0x9E02A4", VA = "0x9E02A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C8B")]
				[Address(RVA = "0x9E02EC", Offset = "0x9E02EC", VA = "0x9E02EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x9E00A0", Offset = "0x9E00A0", VA = "0x9E00A0")]
			[DebuggerHidden]
			public <EffectLoop>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x9E00D8", Offset = "0x9E00D8", VA = "0x9E00D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x9E00DC", Offset = "0x9E00DC", VA = "0x9E00DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x9E02AC", Offset = "0x9E02AC", VA = "0x9E02AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x9DFFDC", Offset = "0x9DFFDC", VA = "0x9DFFDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x9DFFE0", Offset = "0x9DFFE0", VA = "0x9DFFE0")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x9E002C", Offset = "0x9E002C", VA = "0x9E002C")]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x9E00C8", Offset = "0x9E00C8", VA = "0x9E00C8")]
		public SciFiLoopScript()
		{
		}
	}
	[Token(Token = "0x2000227")]
	public class SciFiProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x4000EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject impactParticle;

		[Token(Token = "0x4000EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectileParticle;

		[Token(Token = "0x4000EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4000EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] trailParticles;

		[Token(Token = "0x4000EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 impactNormal;

		[Token(Token = "0x4000EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasCollided;

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x9E02F4", Offset = "0x9E02F4", VA = "0x9E02F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x9E05F0", Offset = "0x9E05F0", VA = "0x9E05F0")]
		private void OnCollisionEnter(Collision hit)
		{
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x9E0A08", Offset = "0x9E0A08", VA = "0x9E0A08")]
		public SciFiProjectileScript()
		{
		}
	}
	[Token(Token = "0x2000228")]
	public class SciFiLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float life;

		[Token(Token = "0x4000EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x9E0A10", Offset = "0x9E0A10", VA = "0x9E0A10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x9E0B2C", Offset = "0x9E0B2C", VA = "0x9E0B2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x9E0C68", Offset = "0x9E0C68", VA = "0x9E0C68")]
		public SciFiLightFade()
		{
		}
	}
	[Token(Token = "0x2000229")]
	public class SciFiPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x4000EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x9E0C84", Offset = "0x9E0C84", VA = "0x9E0C84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x9E0D34", Offset = "0x9E0D34", VA = "0x9E0D34")]
		public SciFiPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x200022A")]
	public class SciFiRotation : MonoBehaviour
	{
		[Token(Token = "0x200022B")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000EF7")]
			Local,
			[Token(Token = "0x4000EF8")]
			World
		}

		[Token(Token = "0x4000EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x9E0D44", Offset = "0x9E0D44", VA = "0x9E0D44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x9E0E18", Offset = "0x9E0E18", VA = "0x9E0E18")]
		public SciFiRotation()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200022C")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200022D")]
		private class CameraState
		{
			[Token(Token = "0x4000F00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000F01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x9E0ECC", Offset = "0x9E0ECC", VA = "0x9E0ECC")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x9E1424", Offset = "0x9E1424", VA = "0x9E1424")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x9E14A4", Offset = "0x9E14A4", VA = "0x9E14A4")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x9E152C", Offset = "0x9E152C", VA = "0x9E152C")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x9E1750", Offset = "0x9E1750", VA = "0x9E1750")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x4000EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x9E0E78", Offset = "0x9E0E78", VA = "0x9E0E78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x9E0F50", Offset = "0x9E0F50", VA = "0x9E0F50")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x9E1180", Offset = "0x9E1180", VA = "0x9E1180")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x9E1574", Offset = "0x9E1574", VA = "0x9E1574")]
		public SimpleCameraController()
		{
		}
	}
}
namespace KevinIglesias
{
	[Token(Token = "0x200022E")]
	public class BowLoadScript : MonoBehaviour
	{
		[Token(Token = "0x4000F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bow;

		[Token(Token = "0x4000F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform arrowHandRetargeter;

		[Token(Token = "0x4000F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bowHandRetargeter;

		[Token(Token = "0x4000F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SkinnedMeshRenderer bowSkinnedMeshRenderer;

		[Token(Token = "0x4000F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool arrowOnHand;

		[Token(Token = "0x4000F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform arrowToDraw;

		[Token(Token = "0x4000F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform arrowToShoot;

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x9E1758", Offset = "0x9E1758", VA = "0x9E1758")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x9E1890", Offset = "0x9E1890", VA = "0x9E1890")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x9E1BA8", Offset = "0x9E1BA8", VA = "0x9E1BA8")]
		public BowLoadScript()
		{
		}
	}
	[Token(Token = "0x200022F")]
	public class AddCastEffect : StateMachineBehaviour
	{
		[Token(Token = "0x4000F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x9E1BB0", Offset = "0x9E1BB0", VA = "0x9E1BB0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x9E1DD0", Offset = "0x9E1DD0", VA = "0x9E1DD0")]
		public AddCastEffect()
		{
		}
	}
	[Token(Token = "0x2000230")]
	public enum CastHand
	{
		[Token(Token = "0x4000F10")]
		RightHand,
		[Token(Token = "0x4000F11")]
		LeftHand
	}
	[Token(Token = "0x2000231")]
	public class CastSpells : MonoBehaviour
	{
		[Token(Token = "0x2000232")]
		private sealed class <SpawnFireball>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000F1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x1700016D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CB3")]
				[Address(RVA = "0x9E2660", Offset = "0x9E2660", VA = "0x9E2660", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CB5")]
				[Address(RVA = "0x9E26A8", Offset = "0x9E26A8", VA = "0x9E26A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x9E2098", Offset = "0x9E2098", VA = "0x9E2098")]
			[DebuggerHidden]
			public <SpawnFireball>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x9E2278", Offset = "0x9E2278", VA = "0x9E2278", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x9E227C", Offset = "0x9E227C", VA = "0x9E227C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x9E2668", Offset = "0x9E2668", VA = "0x9E2668", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000233")]
		private sealed class <SpawnHealing>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000F23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000F24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000F25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x4000F26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Transform <t>5__3;

			[Token(Token = "0x4000F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 <startSize>5__4;

			[Token(Token = "0x4000F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <i>5__5;

			[Token(Token = "0x1700016F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CB9")]
				[Address(RVA = "0x9E2BD0", Offset = "0x9E2BD0", VA = "0x9E2BD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000170")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CBB")]
				[Address(RVA = "0x9E2C18", Offset = "0x9E2C18", VA = "0x9E2C18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x9E20C0", Offset = "0x9E20C0", VA = "0x9E20C0")]
			[DebuggerHidden]
			public <SpawnHealing>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x9E26B0", Offset = "0x9E26B0", VA = "0x9E26B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x9E26B4", Offset = "0x9E26B4", VA = "0x9E26B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x9E2BD8", Offset = "0x9E2BD8", VA = "0x9E2BD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000234")]
		private sealed class <SpawnNova>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject <newNova>5__2;

			[Token(Token = "0x4000F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <t>5__3;

			[Token(Token = "0x4000F2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 <startSize>5__4;

			[Token(Token = "0x4000F30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <i>5__5;

			[Token(Token = "0x4000F31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Renderer <r>5__6;

			[Token(Token = "0x4000F32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Color <initColor>5__7;

			[Token(Token = "0x4000F33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Color <endColor>5__8;

			[Token(Token = "0x17000171")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CBF")]
				[Address(RVA = "0x9E31A0", Offset = "0x9E31A0", VA = "0x9E31A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000172")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CC1")]
				[Address(RVA = "0x9E31E8", Offset = "0x9E31E8", VA = "0x9E31E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x9E20E8", Offset = "0x9E20E8", VA = "0x9E20E8")]
			[DebuggerHidden]
			public <SpawnNova>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x9E2C20", Offset = "0x9E2C20", VA = "0x9E2C20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x9E2C24", Offset = "0x9E2C24", VA = "0x9E2C24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC0")]
			[Address(RVA = "0x9E31A8", Offset = "0x9E31A8", VA = "0x9E31A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000235")]
		private sealed class <SpawnShockwave>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000F37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000F38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x4000F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GameObject <newShockwave>5__3;

			[Token(Token = "0x4000F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Transform <t>5__4;

			[Token(Token = "0x4000F3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Renderer <r>5__5;

			[Token(Token = "0x4000F3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Color <initColor>5__6;

			[Token(Token = "0x4000F3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Color <endColor>5__7;

			[Token(Token = "0x4000F3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private float <i>5__8;

			[Token(Token = "0x17000173")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CC5")]
				[Address(RVA = "0x9E368C", Offset = "0x9E368C", VA = "0x9E368C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000174")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CC7")]
				[Address(RVA = "0x9E36D4", Offset = "0x9E36D4", VA = "0x9E36D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x9E2110", Offset = "0x9E2110", VA = "0x9E2110")]
			[DebuggerHidden]
			public <SpawnShockwave>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x9E31F0", Offset = "0x9E31F0", VA = "0x9E31F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x9E31F4", Offset = "0x9E31F4", VA = "0x9E31F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x9E3694", Offset = "0x9E3694", VA = "0x9E3694", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000236")]
		private sealed class <AppearFireball>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform t;

			[Token(Token = "0x4000F43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <startSize>5__2;

			[Token(Token = "0x4000F44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <i>5__3;

			[Token(Token = "0x17000175")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CCB")]
				[Address(RVA = "0x9E3854", Offset = "0x9E3854", VA = "0x9E3854", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000176")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CCD")]
				[Address(RVA = "0x9E389C", Offset = "0x9E389C", VA = "0x9E389C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x9E21AC", Offset = "0x9E21AC", VA = "0x9E21AC")]
			[DebuggerHidden]
			public <AppearFireball>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x9E36DC", Offset = "0x9E36DC", VA = "0x9E36DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x9E36E0", Offset = "0x9E36E0", VA = "0x9E36E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x9E385C", Offset = "0x9E385C", VA = "0x9E385C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000237")]
		private sealed class <MoveFireball>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform t;

			[Token(Token = "0x4000F48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <initPosition>5__2;

			[Token(Token = "0x4000F49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <i>5__3;

			[Token(Token = "0x17000177")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CD1")]
				[Address(RVA = "0x9E3A28", Offset = "0x9E3A28", VA = "0x9E3A28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000178")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CD3")]
				[Address(RVA = "0x9E3A70", Offset = "0x9E3A70", VA = "0x9E3A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x9E2248", Offset = "0x9E2248", VA = "0x9E2248")]
			[DebuggerHidden]
			public <MoveFireball>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x9E38A4", Offset = "0x9E38A4", VA = "0x9E38A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x9E38A8", Offset = "0x9E38A8", VA = "0x9E38A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x9E3A30", Offset = "0x9E3A30", VA = "0x9E3A30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightHand;

		[Token(Token = "0x4000F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftHand;

		[Token(Token = "0x4000F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 handOffset;

		[Token(Token = "0x4000F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float spellOffset;

		[Token(Token = "0x4000F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject spellPrefab;

		[Token(Token = "0x4000F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject castEffectPrefab;

		[Token(Token = "0x4000F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject castEffectR;

		[Token(Token = "0x4000F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject castEffectL;

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x9E1DD8", Offset = "0x9E1DD8", VA = "0x9E1DD8")]
		public void ThrowFireball(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x9E1E8C", Offset = "0x9E1E8C", VA = "0x9E1E8C")]
		public void ThrowNova(float delay)
		{
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x9E1F30", Offset = "0x9E1F30", VA = "0x9E1F30")]
		public void ThrowHealing(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x9E1FE4", Offset = "0x9E1FE4", VA = "0x9E1FE4")]
		public void ThrowShockwave(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x9E1DF8", Offset = "0x9E1DF8", VA = "0x9E1DF8")]
		public IEnumerator SpawnFireball(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x9E1F50", Offset = "0x9E1F50", VA = "0x9E1F50")]
		public IEnumerator SpawnHealing(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x9E1CA4", Offset = "0x9E1CA4", VA = "0x9E1CA4")]
		public void SpawnEffect(CastHand hand)
		{
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x9E1EAC", Offset = "0x9E1EAC", VA = "0x9E1EAC")]
		public IEnumerator SpawnNova(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x9E2004", Offset = "0x9E2004", VA = "0x9E2004")]
		public IEnumerator SpawnShockwave(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x9E2138", Offset = "0x9E2138", VA = "0x9E2138")]
		private IEnumerator AppearFireball(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x9E21D4", Offset = "0x9E21D4", VA = "0x9E21D4")]
		private IEnumerator MoveFireball(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x9E2270", Offset = "0x9E2270", VA = "0x9E2270")]
		public CastSpells()
		{
		}
	}
	[Token(Token = "0x2000238")]
	public class ThrowFireball : StateMachineBehaviour
	{
		[Token(Token = "0x4000F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x9E3A78", Offset = "0x9E3A78", VA = "0x9E3A78", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x9E3B84", Offset = "0x9E3B84", VA = "0x9E3B84")]
		public ThrowFireball()
		{
		}
	}
	[Token(Token = "0x2000239")]
	public class ThrowHealing : StateMachineBehaviour
	{
		[Token(Token = "0x4000F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x9E3B8C", Offset = "0x9E3B8C", VA = "0x9E3B8C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x9E3C98", Offset = "0x9E3C98", VA = "0x9E3C98")]
		public ThrowHealing()
		{
		}
	}
	[Token(Token = "0x200023A")]
	public class ThrowNova : StateMachineBehaviour
	{
		[Token(Token = "0x4000F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spawnDelay;

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x9E3CA0", Offset = "0x9E3CA0", VA = "0x9E3CA0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x9E3DA8", Offset = "0x9E3DA8", VA = "0x9E3DA8")]
		public ThrowNova()
		{
		}
	}
	[Token(Token = "0x200023B")]
	public class ThrowShockwave : StateMachineBehaviour
	{
		[Token(Token = "0x4000F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x9E3DB0", Offset = "0x9E3DB0", VA = "0x9E3DB0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x9E3EBC", Offset = "0x9E3EBC", VA = "0x9E3EBC")]
		public ThrowShockwave()
		{
		}
	}
	[Token(Token = "0x200023C")]
	public enum SoldierIKGoal
	{
		[Token(Token = "0x4000F56")]
		LeftHand,
		[Token(Token = "0x4000F57")]
		RightHand
	}
	[Token(Token = "0x200023D")]
	public class SoldierHandsIK : MonoBehaviour
	{
		[Token(Token = "0x4000F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform handEffector;

		[Token(Token = "0x4000F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SoldierIKGoal hand;

		[Token(Token = "0x4000F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x9E3EC4", Offset = "0x9E3EC4", VA = "0x9E3EC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x9E3F24", Offset = "0x9E3F24", VA = "0x9E3F24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x9E3F80", Offset = "0x9E3F80", VA = "0x9E3F80")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x9E408C", Offset = "0x9E408C", VA = "0x9E408C")]
		public SoldierHandsIK()
		{
		}
	}
	[Token(Token = "0x200023E")]
	public class ChangeSpear : MonoBehaviour
	{
		[Token(Token = "0x200023F")]
		private sealed class <StartChange>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChangeSpear <>4__this;

			[Token(Token = "0x4000F6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <yRotation>5__2;

			[Token(Token = "0x4000F6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <i>5__3;

			[Token(Token = "0x17000179")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CE8")]
				[Address(RVA = "0x9E4654", Offset = "0x9E4654", VA = "0x9E4654", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CEA")]
				[Address(RVA = "0x9E469C", Offset = "0x9E469C", VA = "0x9E469C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x9E4210", Offset = "0x9E4210", VA = "0x9E4210")]
			[DebuggerHidden]
			public <StartChange>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x9E4240", Offset = "0x9E4240", VA = "0x9E4240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x9E4244", Offset = "0x9E4244", VA = "0x9E4244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x9E465C", Offset = "0x9E465C", VA = "0x9E465C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform spear;

		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool changeActive;

		[Token(Token = "0x4000F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool secondTime;

		[Token(Token = "0x4000F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform characterRoot;

		[Token(Token = "0x4000F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 zeroRotation;

		[Token(Token = "0x4000F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private IEnumerator changeCO;

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x9E4094", Offset = "0x9E4094", VA = "0x9E4094")]
		public void Start()
		{
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x9E40FC", Offset = "0x9E40FC", VA = "0x9E40FC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x9E4148", Offset = "0x9E4148", VA = "0x9E4148")]
		public void DoChangeSpear()
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x9E419C", Offset = "0x9E419C", VA = "0x9E419C")]
		private IEnumerator StartChange()
		{
			return null;
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x9E4238", Offset = "0x9E4238", VA = "0x9E4238")]
		public ChangeSpear()
		{
		}
	}
	[Token(Token = "0x2000240")]
	public class IdleThrowTrick : MonoBehaviour
	{
		[Token(Token = "0x2000241")]
		private sealed class <StartSpin>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IdleThrowTrick <>4__this;

			[Token(Token = "0x4000F81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <i>5__2;

			[Token(Token = "0x1700017B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CF3")]
				[Address(RVA = "0x9E4C00", Offset = "0x9E4C00", VA = "0x9E4C00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CF5")]
				[Address(RVA = "0x9E4C48", Offset = "0x9E4C48", VA = "0x9E4C48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x9E487C", Offset = "0x9E487C", VA = "0x9E487C")]
			[DebuggerHidden]
			public <StartSpin>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x9E48AC", Offset = "0x9E48AC", VA = "0x9E48AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x9E48B0", Offset = "0x9E48B0", VA = "0x9E48B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x9E4C08", Offset = "0x9E4C08", VA = "0x9E4C08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform propToThrow;

		[Token(Token = "0x4000F71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float trickDistance;

		[Token(Token = "0x4000F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float trickTranslationSpeed;

		[Token(Token = "0x4000F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float trickRotationSpeed;

		[Token(Token = "0x4000F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool trickActive;

		[Token(Token = "0x4000F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform characterRoot;

		[Token(Token = "0x4000F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IEnumerator spinCO;

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x9E46A4", Offset = "0x9E46A4", VA = "0x9E46A4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x9E470C", Offset = "0x9E470C", VA = "0x9E470C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x9E47B4", Offset = "0x9E47B4", VA = "0x9E47B4")]
		public void SpinProp()
		{
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x9E4808", Offset = "0x9E4808", VA = "0x9E4808")]
		private IEnumerator StartSpin()
		{
			return null;
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x9E48A4", Offset = "0x9E48A4", VA = "0x9E48A4")]
		public IdleThrowTrick()
		{
		}
	}
	[Token(Token = "0x2000242")]
	public class ThrowBigAxe : MonoBehaviour
	{
		[Token(Token = "0x2000243")]
		private sealed class <StartSpin>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThrowBigAxe <>4__this;

			[Token(Token = "0x4000F96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <i>5__2;

			[Token(Token = "0x1700017D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CFE")]
				[Address(RVA = "0x9E51B8", Offset = "0x9E51B8", VA = "0x9E51B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D00")]
				[Address(RVA = "0x9E5200", Offset = "0x9E5200", VA = "0x9E5200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x9E4E28", Offset = "0x9E4E28", VA = "0x9E4E28")]
			[DebuggerHidden]
			public <StartSpin>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x9E4E58", Offset = "0x9E4E58", VA = "0x9E4E58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x9E4E5C", Offset = "0x9E4E5C", VA = "0x9E4E5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x9E51C0", Offset = "0x9E51C0", VA = "0x9E51C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform propToSpin;

		[Token(Token = "0x4000F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spinDistance;

		[Token(Token = "0x4000F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float translationSpeed;

		[Token(Token = "0x4000F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float spinSpeed;

		[Token(Token = "0x4000F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool spinActive;

		[Token(Token = "0x4000F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 endPositionOffset;

		[Token(Token = "0x4000F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 returningPositionOffset;

		[Token(Token = "0x4000F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform characterRoot;

		[Token(Token = "0x4000F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IEnumerator spinCO;

		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x9E4C50", Offset = "0x9E4C50", VA = "0x9E4C50")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x9E4CB8", Offset = "0x9E4CB8", VA = "0x9E4CB8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x9E4D60", Offset = "0x9E4D60", VA = "0x9E4D60")]
		public void SpinProp()
		{
		}

		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x9E4DB4", Offset = "0x9E4DB4", VA = "0x9E4DB4")]
		private IEnumerator StartSpin()
		{
			return null;
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x9E4E50", Offset = "0x9E4E50", VA = "0x9E4E50")]
		public ThrowBigAxe()
		{
		}
	}
	[Token(Token = "0x2000244")]
	public class ThrowMultipleProps : MonoBehaviour
	{
		[Token(Token = "0x4000F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter1;

		[Token(Token = "0x4000F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform retargeter2;

		[Token(Token = "0x4000F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform propToThrow1;

		[Token(Token = "0x4000F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform propToThrow2;

		[Token(Token = "0x4000F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform hand1;

		[Token(Token = "0x4000F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform hand2;

		[Token(Token = "0x4000F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform targetPos;

		[Token(Token = "0x4000F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speed;

		[Token(Token = "0x4000F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float arcHeight;

		[Token(Token = "0x4000FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool launched1;

		[Token(Token = "0x4000FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool launched2;

		[Token(Token = "0x4000FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool recoverProp1;

		[Token(Token = "0x4000FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		public bool recoverProp2;

		[Token(Token = "0x4000FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool propLanded1;

		[Token(Token = "0x4000FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool propLanded2;

		[Token(Token = "0x4000FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform characterRoot;

		[Token(Token = "0x4000FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 startPos1;

		[Token(Token = "0x4000FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 startPos2;

		[Token(Token = "0x4000FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 zeroPosition1;

		[Token(Token = "0x4000FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion zeroRotation1;

		[Token(Token = "0x4000FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 zeroPosition2;

		[Token(Token = "0x4000FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion zeroRotation2;

		[Token(Token = "0x4000FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 nextPos;

		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x9E5208", Offset = "0x9E5208", VA = "0x9E5208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x9E52A0", Offset = "0x9E52A0", VA = "0x9E52A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x9E5734", Offset = "0x9E5734", VA = "0x9E5734")]
		private static Quaternion LookAt2D(Vector3 forward)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x9E5784", Offset = "0x9E5784", VA = "0x9E5784")]
		public void Throw1()
		{
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x9E5828", Offset = "0x9E5828", VA = "0x9E5828")]
		public void Throw2()
		{
		}

		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x9E57CC", Offset = "0x9E57CC", VA = "0x9E57CC")]
		public void RecoverProp1()
		{
		}

		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x9E5870", Offset = "0x9E5870", VA = "0x9E5870")]
		public void RecoverProp2()
		{
		}

		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x9E58CC", Offset = "0x9E58CC", VA = "0x9E58CC")]
		public ThrowMultipleProps()
		{
		}
	}
	[Token(Token = "0x2000245")]
	public enum PropType
	{
		[Token(Token = "0x4000FAF")]
		Spear,
		[Token(Token = "0x4000FB0")]
		Knife,
		[Token(Token = "0x4000FB1")]
		Tomahawk
	}
	[Token(Token = "0x2000246")]
	public class ThrowProp : MonoBehaviour
	{
		[Token(Token = "0x4000FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropType propType;

		[Token(Token = "0x4000FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform propToThrow;

		[Token(Token = "0x4000FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform hand;

		[Token(Token = "0x4000FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform targetPos;

		[Token(Token = "0x4000FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float speed;

		[Token(Token = "0x4000FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float arcHeight;

		[Token(Token = "0x4000FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool launched;

		[Token(Token = "0x4000FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool recoverProp;

		[Token(Token = "0x4000FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool propLanded;

		[Token(Token = "0x4000FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform characterRoot;

		[Token(Token = "0x4000FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		[Token(Token = "0x4000FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 nextPos;

		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x9E58E0", Offset = "0x9E58E0", VA = "0x9E58E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x9E5948", Offset = "0x9E5948", VA = "0x9E5948")]
		private void Update()
		{
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x9E5D48", Offset = "0x9E5D48", VA = "0x9E5D48")]
		private static Quaternion LookAt2D(Vector3 forward)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x9E5D98", Offset = "0x9E5D98", VA = "0x9E5D98")]
		public void Throw()
		{
		}

		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x9E5DDC", Offset = "0x9E5DDC", VA = "0x9E5DDC")]
		public void RecoverProp()
		{
		}

		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x9E5E38", Offset = "0x9E5E38", VA = "0x9E5E38")]
		public ThrowProp()
		{
		}
	}
	[Token(Token = "0x2000247")]
	public enum VillagerIKGoal
	{
		[Token(Token = "0x4000FC2")]
		LeftHand,
		[Token(Token = "0x4000FC3")]
		RightHand
	}
	[Token(Token = "0x2000248")]
	public class VillagerHandsIK : MonoBehaviour
	{
		[Token(Token = "0x4000FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform handEffector;

		[Token(Token = "0x4000FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VillagerIKGoal hand;

		[Token(Token = "0x4000FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x9E5E4C", Offset = "0x9E5E4C", VA = "0x9E5E4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x9E5EAC", Offset = "0x9E5EAC", VA = "0x9E5EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x9E5F08", Offset = "0x9E5F08", VA = "0x9E5F08")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x9E6014", Offset = "0x9E6014", VA = "0x9E6014")]
		public VillagerHandsIK()
		{
		}
	}
}
